using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;
using TaleWorlds.ObjectSystem;
using NavalDLC;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.GameMenus;
using System.Linq;
using TaleWorlds.CampaignSystem.Naval;
using TaleWorlds.CampaignSystem.Roster;

namespace CoastalLife
{
    public class CoastGuardBehavior : CampaignBehaviorBase
    {
        private readonly ILogger<CoastGuardBehavior> _logger;
        private readonly GlobalSettings _settings;

        public CoastGuardBehavior(ILogger<CoastGuardBehavior> logger, GlobalSettings settings)
        {
            _logger = logger;
            _settings = settings;
        }

        public override void RegisterEvents()
        {
            // CampaignEvents.DailyTickSettlementEvent.AddNonSerializedListener(this, OnDailySettlementTick);
            // CampaignEvents.HourlyTickEvent.AddNonSerializedListener(this, OnHourlyTick);
            // CampaignEvents.OnSessionLaunchedEvent.AddNonSerializedListener(this, OnSessionLaunched);
            // _logger.LogDebug("CoastGuardBehavior: Events Registered (DISABLED)");
        }

        public override void SyncData(IDataStore dataStore)
        {
        }

        private List<MobileParty> _coastGuardParties = new List<MobileParty>();
        private bool _initialized = false;

        private void OnSessionLaunched(CampaignGameStarter campaignStarter)
        {
            // AddGameMenus(campaignStarter);
            
            // Initialize Cache
            _coastGuardParties.Clear();
            foreach (var party in MobileParty.All)
            {
                if (party.IsActive && party.StringId != null && party.StringId.StartsWith("coast_guard_"))
                {
                    _coastGuardParties.Add(party);
                }
            }
            _initialized = true;
        }

        private void OnHourlyTick()
        {
            if (!_initialized) return;

            // Cleanup Cache
            for (int i = _coastGuardParties.Count - 1; i >= 0; i--)
            {
                if (_coastGuardParties[i] == null || !_coastGuardParties[i].IsActive)
                {
                    _coastGuardParties.RemoveAt(i);
                }
            }

            // Manage AI for existing Coast Guard parties
            foreach (var party in _coastGuardParties)
            {
                 try
                 {
                     if (party.MapFaction == null || party.MapFaction.IsAtWarWith(Hero.MainHero.MapFaction))
                     {
                         // Simple hostile logic or just let them be
                     }

                     // If they have no target, patrol their home
                     if (party.TargetSettlement == null && party.MapEvent == null)
                     {
                         string[] parts = party.StringId.Split('_');
                         if (parts.Length >= 3)
                         {
                             string settlementId = parts[2]; // coast_guard_settlementId_random
                             var settlement = Settlement.Find(settlementId);
                             if (settlement != null)
                             {
                                 // Safe AI assignment
                                  party.SetMovePatrolAroundSettlement(settlement, MobileParty.NavigationType.Naval, true);
                             }
                         }
                     }
                 }
                 catch(Exception ex)
                 {
                     _logger.LogError($"CoastGuard AI Error for {party.Name}: {ex.Message}");
                 }
            }
        }

        private bool IsSafeWater(Vec2 pos)
        {
             if (Campaign.Current.MapSceneWrapper == null) return false;
             var t = Campaign.Current.MapSceneWrapper.GetTerrainTypeAtPosition(new CampaignVec2(pos, false));
             if (t != TerrainType.Water && t != TerrainType.River && t != TerrainType.Lake) return false;

             // 2. NavMesh Check
             // GetFaceIndex returns a PathFaceRecord. If it is valid, the point is on the navmesh (or close enough/projected).
             // If we spawn off-mesh, the ship cannot move and might crash.
             var face = Campaign.Current.MapSceneWrapper.GetFaceIndex(new CampaignVec2(pos, false));
             return face.IsValid();
        }

        private Vec2? FindWaterNear(Vec2 center, float radius)
        {
            // Radial search for SAFE water (NavMesh + Water)
            for (float r = 5f; r <= radius; r += 5f) // Increased step size for performance
            {
                // Reduce angular resolution slightly
                for (float angle = 0; angle < (float)Math.PI * 2; angle += 0.5f)
                {
                    Vec2 checkPos = new Vec2(center.X + (float)Math.Cos(angle) * r, center.Y + (float)Math.Sin(angle) * r);
                    
                    if (IsSafeWater(checkPos)) return checkPos;
                }
            }
            return null;
        }

        private bool IsCoastGuardActive(Settlement settlement)
        {
            foreach (var party in MobileParty.All)
            {
                if (party.IsActive && party.StringId != null && party.StringId.StartsWith("coast_guard_" + settlement.StringId))
                {
                    return true;
                }
            }
            return false;
        }

        private ShipHull GetShipHullForCulture(CultureObject culture)
        {
            try 
            {
                var allHulls = MBObjectManager.Instance.GetObjectTypeList<ShipHull>();
                if (allHulls == null || allHulls.Count == 0) 
                {
                    _logger.LogWarning("CoastGuard: No ShipHulls found in ObjectManager!");
                    return null;
                }

                // 1. Try generic culture match
                var match = allHulls.FirstOrDefault(h => h.StringId.ToLower().Contains(culture.StringId.ToLower()));

                // 2. Try 'medium' ship fallback
                if (match == null)
                {
                    match = allHulls.FirstOrDefault(h => h.StringId.ToLower().Contains("medium"));
                }

                // 3. Absolute fallback
                if (match == null)
                {
                    match = allHulls.FirstOrDefault();
                }

                if (match != null) 
                {
                    _logger.LogDebug($"CoastGuard: Selected ship '{match.StringId}' for {culture.Name}");
                }
                
                return match;
            }
            catch(Exception ex)
            {
                _logger.LogError($"CoastGuard: Error finding ship hull: {ex.Message}");
                return null;
            }
        }

    }
}
