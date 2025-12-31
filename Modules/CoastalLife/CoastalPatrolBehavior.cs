using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.Map;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;
using Microsoft.Extensions.Logging;
using NavalDLC; // Ensure this namespace is available via DLL ref
using TaleWorlds.CampaignSystem.Naval; // May require reflection if not in ref

namespace CoastalLife
{
    public class CoastalPatrolBehavior : CampaignBehaviorBase
    {
        private Dictionary<Settlement, CampaignTime> _partyGenerationQueue = new Dictionary<Settlement, CampaignTime>();
        private Dictionary<Settlement, MobileParty> _patrolParties = new Dictionary<Settlement, MobileParty>();
        
        // Configurable Cost
        private const int PatrolSpawnCost = 2000;
        
        private readonly ILogger<CoastalPatrolBehavior> _logger;

        public CoastalPatrolBehavior(ILogger<CoastalPatrolBehavior> logger)
        {
            _logger = logger;
        }

        public override void RegisterEvents()
        {
            CampaignEvents.DailyTickSettlementEvent.AddNonSerializedListener(this, DailyTickSettlement);
            CampaignEvents.OnSettlementLeftEvent.AddNonSerializedListener(this, OnSettlementLeft);
            CampaignEvents.MobilePartyDestroyed.AddNonSerializedListener(this, OnMobilePartyDestroyed);
            CampaignEvents.OnSettlementOwnerChangedEvent.AddNonSerializedListener(this, OnSettlementOwnerChangedEvent);
            CampaignEvents.OnSessionLaunchedEvent.AddNonSerializedListener(this, OnSessionLaunched);
        }

        private void OnSessionLaunched(CampaignGameStarter starter)
        {
             // Sync handles initialization
        }

        public override void SyncData(IDataStore dataStore)
        {
            dataStore.SyncData("_partyGenerationQueue", ref _partyGenerationQueue);
            dataStore.SyncData("_patrolParties", ref _patrolParties);
        }

        private void DailyTickSettlement(Settlement settlement)
        {
            TextObject reason;
            if (CanSettlementSpawnNewPartyCurrently(settlement, out reason))
            {
                CampaignTime queueTime;
                if (!_partyGenerationQueue.TryGetValue(settlement, out queueTime))
                {
                    float delay = 1f;
                    try {
                        // Reflection to access SettlementPatrolModel
                         object model = GetSettlementPatrolModel();
                         if (model != null)
                         {
                             MethodInfo method = model.GetType().GetMethod("GetPatrolPartySpawnDuration");
                             if (method != null)
                             {
                                 delay = (float)method.Invoke(model, new object[] { settlement, true }); // naval=true
                             }
                         }
                    } catch {}

                    UpdateSettlementQueue(settlement, CampaignTime.Now + CampaignTime.Days(delay));
                }
                else if (queueTime.IsPast)
                {
                    SpawnPatrolParty(settlement);
                }
            }
            else
            {
                UpdateSettlementParties(settlement);
            }
        }

        private bool CanSettlementSpawnNewPartyCurrently(Settlement settlement, out TextObject reason)
        {
            reason = TextObject.GetEmpty();

            if (!settlement.IsTown)
            {
                 reason = new TextObject("Not a Town");
                 return false;
            }
            
            // Port Check
            bool hasPort = false;
            try {
                PropertyInfo portProp = settlement.GetType().GetProperty("HasPort");
                if (portProp != null) hasPort = (bool)portProp.GetValue(settlement);
            } catch {}
            
            if (!hasPort)
            {
                reason = new TextObject("No Port");
                return false;
            }

            // Gold Check
            if (settlement.OwnerClan == null || settlement.OwnerClan.Gold < PatrolSpawnCost)
            {
                reason = new TextObject("{=NoFunds}Insufficient Funds ({COST}{GOLD_ICON})");
                reason.SetTextVariable("COST", PatrolSpawnCost);
                 // reason.SetTextVariable("GOLD_ICON", "{!}<img src=\"General\\Icons\\Coin\" extend=\"8\">"); // simple text for now
                return false;
            }

            // Status Checks
            if (settlement.InRebelliousState)
            {
                reason = new TextObject("{=Rebellious}Rebellious");
                return false;
            }
            if (settlement.Town.IsUnderSiege || (settlement.Party != null && settlement.Party.MapEvent != null))
            {
                reason = new TextObject("{=UnderSiege}Under Siege");
                return false;
            }

            // Existence Check
            if (GetNavalPatrolParty(settlement) != null)
            {
                reason = new TextObject("{=AlreadyActive}Active");
                return false;
            }

            return true;
        }

        private void SpawnPatrolParty(Settlement settlement)
        {
            _partyGenerationQueue.Remove(settlement);

            // Deduct Gold
            if (settlement.OwnerClan != null)
            {
                 GiveGoldAction.ApplyBetweenCharacters(settlement.OwnerClan.Leader, null, PatrolSpawnCost, true);
            }

            try 
            {
                PartyTemplateObject partyTemplate = null;
                try {
                     object model = GetSettlementPatrolModel();
                     if (model != null)
                     {
                         MethodInfo method = model.GetType().GetMethod("GetPartyTemplateForPatrolParty");
                         if (method != null)
                         {
                             partyTemplate = (PartyTemplateObject)method.Invoke(model, new object[] { settlement, true });
                         }
                     }
                }
                catch (Exception ex) 
                {
                    _logger.LogError($"Failed to get Patrol Template: {ex.Message}");
                }

                if (partyTemplate == null) 
                {
                    _logger.LogError($"Template not found for {settlement.Culture?.Name}!");
                    return; 
                }

                // Create Party using PatrolPartyComponent from NavalDLC
                // We assume PatrolPartyComponent type is available.
                
                try {
                     _logger.LogInformation($"Attempting to spawn patrol for {settlement.Name} using template {partyTemplate.StringId}");

                     // Direct instantiation of our custom component
                     var coastGuardComponent = new CoastalPatrolComponent(settlement);
                     if (coastGuardComponent == null) throw new Exception("Failed to create CoastalPatrolComponent");

                     // Create Party
                     string partyId = $"coastal_patrol_{settlement.StringId}_{MBRandom.RandomInt(10000)}";
                     
                     _logger.LogInformation($"Creating MobileParty: {partyId}");
                     MobileParty patrol = MobileParty.CreateParty(partyId, coastGuardComponent);
                     
                     if (patrol == null) throw new Exception("MobileParty.CreateParty returned null");

                     _logger.LogInformation($"MobileParty created: {patrol.Name}");
                     
                     // CRITICAL FIX: Ensure Party belongs to Clan explicitly before Init to satisfy NavalDLC
                     if (settlement.OwnerClan != null)
                     {
                         // Force the Clan reference so PartyBase.Culture is resolved immediately!
                         patrol.ActualClan = settlement.OwnerClan; 
                     }

                     try
                     {
                         // Initialize Position
                         CampaignVec2 spawnPos = settlement.GatePosition;
                         _logger.LogInformation($"Spawn Position: {spawnPos}. Initializing Template: {partyTemplate.StringId}");
                         
                         // Try-Catch the init specifically
                         try 
                         {
                              patrol.InitializeMobilePartyAtPosition(partyTemplate, spawnPos);
                         }
                         catch (Exception initEx)
                         {
                              _logger.LogError(initEx, "InitializeMobilePartyAtPosition failed (NavalDLC conflict?). attempting manual cleanup.");
                              // If init failed, we MUST destroy the party or the game will crash on next tick
                              DestroyPartyAction.Apply(null, patrol);
                              throw; // Re-throw to abort setup
                         }
                         
                         _logger.LogInformation("Initialized at position.");
                     }
                     catch (Exception ex)
                     {
                         _logger.LogError(ex, "Generic Failure during Init sequence.");
                         if (patrol.IsActive) DestroyPartyAction.Apply(null, patrol);
                         throw;
                     }

                     try
                     {
                         patrol.SetMovePatrolAroundSettlement(settlement, MobileParty.NavigationType.Default, true);
                         _logger.LogInformation("SetMovePatrolAroundSettlement successful.");
                     }
                     catch(Exception ex)
                     {
                         _logger.LogError(ex, "SetMovePatrolAroundSettlement failed.");
                     }
                     
                     if (patrol.IsActive)
                     {
                         _patrolParties[settlement] = patrol;
                         _logger.LogInformation($"Spawned Coastal Patrol {patrol.Name} for {settlement.Name}");
                     }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, $"Spawn Failed Detailed: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Failed to Spawn Patrol (Outer): {ex.Message}");
            }
        }
        
        private object GetSettlementPatrolModel()
        {
             // Campaign.Current.Models.SettlementPatrolModel
             // Property likely named 'SettlementPatrolModel'
             PropertyInfo prop = Campaign.Current.Models.GetType().GetProperty("SettlementPatrolModel");
             if (prop != null) return prop.GetValue(Campaign.Current.Models);
             return null;
        }

        private void UpdateSettlementParties(Settlement settlement)
        {
             if (settlement.InRebelliousState || (GetNavalPatrolParty(settlement) != null && settlement.Town.IsUnderSiege)) 
             {
                 RemoveSettlementParties(settlement);
             }
        }

        private void RemoveSettlementParties(Settlement settlement)
        {
            _partyGenerationQueue.Remove(settlement);
            var party = GetNavalPatrolParty(settlement);
            if (party != null)
            {
                if (party.IsActive)
                {
                    DestroyPartyAction.Apply(null, party);
                }
                _patrolParties.Remove(settlement);
            }
        }

        private void UpdateSettlementQueue(Settlement settlement, CampaignTime time)
        {
            _partyGenerationQueue[settlement] = time;
        }

        private void OnSettlementLeft(MobileParty party, Settlement settlement)
        {
             // Cache update if needed
        }

        private void OnMobilePartyDestroyed(MobileParty party, PartyBase destroyer)
        {
             foreach(var kvp in _patrolParties.ToList())
             {
                 if (kvp.Value == party)
                 {
                     _patrolParties.Remove(kvp.Key);
                     break;
                 }
             }
        }

        private void OnSettlementOwnerChangedEvent(Settlement settlement, bool openToClaim, Hero newOwner, Hero oldOwner, Hero capturerHero, ChangeOwnerOfSettlementAction.ChangeOwnerOfSettlementDetail detail)
        {
            if (GetNavalPatrolParty(settlement) != null)
            {
                RemoveSettlementParties(settlement);
            }
        }

        public MobileParty GetNavalPatrolParty(Settlement settlement)
        {
            if (_patrolParties.TryGetValue(settlement, out var party))
            {
                if (party != null && party.IsActive) return party;
                _patrolParties.Remove(settlement); 
                return null;
            }
            return null;
        }
    }
}
