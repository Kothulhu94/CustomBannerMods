using System;
using System.Collections.Generic;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.GameMenus;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Localization;
using TaleWorlds.Library;
using TaleWorlds.CampaignSystem.CharacterDevelopment;
using Serilog;
using Microsoft.Extensions.Logging;

namespace LivingLegend
{
    public class LivingLegendBehavior : CampaignBehaviorBase
    {
        private readonly GlobalSettings _settings;
        private List<MobileParty> _patrolParties = new List<MobileParty>();
        private List<CampaignTime> _patrolExpiryTimes = new List<CampaignTime>();

        public LivingLegendBehavior(GlobalSettings settings)
        {
            _settings = settings;
        }

        private Microsoft.Extensions.Logging.ILogger Logger => LivingLegendSubModule.Logger;

        public override void RegisterEvents()
        {
            CampaignEvents.DailyTickClanEvent.AddNonSerializedListener(this, new Action<Clan>(OnDailyClanTick));
            CampaignEvents.OnSessionLaunchedEvent.AddNonSerializedListener(this, new Action<CampaignGameStarter>(OnSessionLaunched));
            CampaignEvents.PlayerTraitChangedEvent.AddNonSerializedListener(this, new Action<TraitObject, int>(OnPlayerTraitChanged));
        }

        public override void SyncData(IDataStore dataStore)
        {
            dataStore.SyncData("_patrolParties", ref _patrolParties);
            dataStore.SyncData("_patrolExpiryTimes", ref _patrolExpiryTimes);
        }

        private void OnPlayerTraitChanged(TraitObject trait, int previousLevel)
        {
            if (_settings.DebugMode)
            {
                Logger?.LogInformation($"Player trait changed: {trait.Name} from {previousLevel} to {Hero.MainHero.GetTraitLevel(trait)}");
            }
        }

        private void OnDailyClanTick(Clan clan)
        {
            // Player Logic: Daily Renown Decay
            if (clan == Clan.PlayerClan)
            {
                if (clan.Tier >= 6 && clan.Renown > _settings.RenownThreshold)
                {
                    clan.Renown -= _settings.DailyRenownCost;
                    if (_settings.DebugMode)
                    {
                        Logger?.LogInformation($"Hero of the People: Daily renown deducted ({_settings.DailyRenownCost}). Current Renown: {clan.Renown}");
                    }
                    InformationManager.DisplayMessage(new InformationMessage($"The Legend's Aura inspires your people. (-{_settings.DailyRenownCost} Renown)", Colors.Green));
                }
            }

            // AI Logic
            ManageAiRenownActions(clan);

            // Cleanup Patrols (Only run once per day, use PlayerClan as trigger)
            if (clan != Clan.PlayerClan) return;

            // Manage Militia Patrols
            if (_patrolParties.Count != _patrolExpiryTimes.Count)
            {
                 // Sanity check reset if sync failed badly
                 Logger?.LogWarning("Error: Patrol lists desynced. Clearing.");
                 _patrolParties.Clear();
                 _patrolExpiryTimes.Clear();
                 return;
            }

            for (int i = _patrolParties.Count - 1; i >= 0; i--)
            {
                var party = _patrolParties[i];
                var expiry = _patrolExpiryTimes[i];

                if (party != null && party.IsActive && CampaignTime.Now >= expiry)
                {
                    // Disband
                    if (_settings.DebugMode)
                    {
                        Logger?.LogInformation($"Disbanding militia patrol: {party.Name}");
                    }
                    DestroyPartyAction.Apply(null, party);
                    _patrolParties.RemoveAt(i);
                    _patrolExpiryTimes.RemoveAt(i);
                    InformationManager.DisplayMessage(new InformationMessage("A militia patrol has completed its duty and disbanded.", Colors.Yellow));
                }
                else if (party == null || !party.IsActive)
                {
                   _patrolParties.RemoveAt(i);
                   _patrolExpiryTimes.RemoveAt(i);
                }
            }
        }

        private void OnSessionLaunched(CampaignGameStarter starter)
        {
            Logger?.LogInformation("LivingLegendBehavior: Session Launched. Initializing dialogs and menus.");
            AddPoliticalCapitalDialogs(starter);
            AddHeroOfThePeopleMenus(starter);
            AddRetinuerecruitDialogs(starter);
        }

        private void AddPoliticalCapitalDialogs(CampaignGameStarter starter)
        {
            starter.AddPlayerLine("living_legend_call_to_arms", "lord_talk_speak_diplomacy_2", "living_legend_call_to_arms_response", 
                "I demand you join my army immediately. My legend commands it.", 
                CallToArmsCondition, 
                CallToArmsConsequence, 
                100, 
                (out TextObject explanation) => { explanation = new TextObject($"Cost: {_settings.CallToArmsCost} Renown"); return true; }
            );

            starter.AddDialogLine("living_legend_call_to_arms_response", "living_legend_call_to_arms_response", "lord_start", 
                "As you command... I cannot refuse such a legend.", 
                null, 
                null);
        }

        private bool CallToArmsCondition()
        {
            if (MobileParty.MainParty.Army == null || MobileParty.MainParty.Army.LeaderParty != MobileParty.MainParty)
                return false;

            if (Hero.OneToOneConversationHero == null || Hero.OneToOneConversationHero.MapFaction != Hero.MainHero.MapFaction)
                return false;

            if (Hero.OneToOneConversationHero.PartyBelongedTo == null || Hero.OneToOneConversationHero.PartyBelongedTo.Army != null)
                return false;
            
            return Clan.PlayerClan.Renown >= _settings.CallToArmsCost;
        }

        private void CallToArmsConsequence()
        {
            Clan.PlayerClan.Renown -= _settings.CallToArmsCost;
            Hero target = Hero.OneToOneConversationHero;
            
            Logger?.LogInformation($"Political Capital used: Forced {target.Name} to join army.");
            
            if (target.PartyBelongedTo != null)
            {
                target.PartyBelongedTo.Army = MobileParty.MainParty.Army;
                // Assigning Army property triggers the game's army logic to handle movement
            }
            
            ChangeRelationAction.ApplyPlayerRelation(target, -5);
        }

        private void AddHeroOfThePeopleMenus(CampaignGameStarter starter)
        {
            starter.AddGameMenuOption("village", "living_legend_rally_militia", $"Rally the Peasantry ({_settings.RallyMilitiaCost} Renown)", 
                RallyMilitiaCondition, 
                RallyMilitiaConsequence, 
                false, 
                1);
        }

        private bool RallyMilitiaCondition(MenuCallbackArgs args)
        {
            if (Settlement.CurrentSettlement == null || !Settlement.CurrentSettlement.IsVillage) return false;
            if (Settlement.CurrentSettlement.OwnerClan != Clan.PlayerClan) return false;
            
            args.optionLeaveType = GameMenuOption.LeaveType.Recruit;
            args.Tooltip = new TextObject($"Spend {_settings.RallyMilitiaCost} Renown to raise a militia patrol for {_settings.MilitiaPatrolDuration} days.");
            return Clan.PlayerClan.Renown >= _settings.RallyMilitiaCost;
        }

        private void RallyMilitiaConsequence(MenuCallbackArgs args)
        {
            // Player usage: Cost check is done in Condition, but double check safety
            if (Clan.PlayerClan.Renown >= _settings.RallyMilitiaCost)
            {
                Clan.PlayerClan.Renown -= _settings.RallyMilitiaCost;
                SpawnMilitiaPatrol(Settlement.CurrentSettlement);
                GameMenu.SwitchToMenu("village");
            }
        }

        public void SpawnMilitiaPatrol(Settlement village)
        {
             if (village == null) return;

             Logger?.LogInformation($"Rally Militia: Spawning patrol at {village.Name}");

             MobileParty militiaParty = MobileParty.CreateParty("militia_patrol_" + village.Name, new MilitiaPatrolComponent(village));
             if (militiaParty == null)
             {
                 Logger?.LogError($"Failed to create militia party for {village.Name}. CreateParty returned null.");
                 return;
             }

             militiaParty.Initialize(); 
            
             CharacterObject militiaTroop = village.Culture.BasicTroop; 
             if (militiaTroop != null)
             {
                 militiaParty.MemberRoster.AddToCounts(militiaTroop, _settings.MilitiaTroopCount);
             }
            
             militiaParty.ActualClan = village.OwnerClan; 
             // Use explicit roster initialization to ensure visual/logical sync
             militiaParty.InitializeMobilePartyAtPosition(militiaParty.MemberRoster, militiaParty.PrisonRoster, village.GatePosition);
             militiaParty.SetMovePatrolAroundSettlement(village, MobileParty.NavigationType.Default, true); 
            
             _patrolParties.Add(militiaParty);
             _patrolExpiryTimes.Add(CampaignTime.Now + CampaignTime.Days(_settings.MilitiaPatrolDuration));
             Logger?.LogInformation($"Rally Militia: Patrol successfully spawned/initialized at {village.Name}");
        }

        private void ManageAiRenownActions(Clan clan)
        {
            // AI Living Legend Logic
            if (clan == Clan.PlayerClan) return;
            if (clan.Tier < 6) return;

            // 1. Rally Militia Logic
            // If Rich in Renown and Village being raided/threatened or just rich
            if (clan.Renown > 2000) // High threshold
            {
                foreach (var settlement in clan.Settlements)
                {
                    if (settlement.IsVillage && settlement.Village.VillageState == Village.VillageStates.Normal)
                    {
                        // Check if already patrolled?
                        bool hasPatrol = _patrolParties.Any(p => p.IsActive && p.TargetPosition.DistanceSquared(settlement.GatePosition) < 100f);
                        if (!hasPatrol)
                        {
                            // 5% Chance per day per village
                            if (MBRandom.RandomFloat < 0.05f)
                            {
                                if (clan.Renown >= _settings.RallyMilitiaCost)
                                {
                                    clan.Renown -= _settings.RallyMilitiaCost;
                                    SpawnMilitiaPatrol(settlement);
                                    if (_settings.DebugMode)
                                        Logger?.LogInformation($"[AI Legend] {clan.Name} rallied militia at {settlement.Name}");
                                    return; // One per day max
                                }
                            }
                        }
                    }
                }
            }
        }

        private void AddRetinuerecruitDialogs(CampaignGameStarter starter)
        {
             starter.AddPlayerLine("living_legend_recruit_minor", "lord_talk_speak_diplomacy_2", "living_legend_recruit_minor_response",
                 "Your faction is crumbling. Pledge your blade to my legend.",
                 RecruitMinorCondition,
                 RecruitMinorConsequence,
                 100,
                 (out TextObject explanation) => { explanation = new TextObject($"Cost: {_settings.RecruitMinorFactionCost} Renown"); return true; });

             starter.AddDialogLine("living_legend_recruit_minor_response", "living_legend_recruit_minor_response", "lord_start",
                 "I have heard the tales... I will serve you.",
                 null,
                 null);
        }

        private bool RecruitMinorCondition()
        {
             if (Hero.OneToOneConversationHero == null) return false;
             Hero target = Hero.OneToOneConversationHero;
             
             if (target.Clan == null || !target.Clan.IsMinorFaction) return false;
             if (target.Clan.Leader != target) return false;
             
             return Clan.PlayerClan.Renown >= _settings.RecruitMinorFactionCost;
        }

        private void RecruitMinorConsequence()
        {
            Clan.PlayerClan.Renown -= _settings.RecruitMinorFactionCost;
            Hero target = Hero.OneToOneConversationHero;
            
            Logger?.LogInformation($"Recruited minor faction leader: {target.Name}");

            AddCompanionAction.Apply(Clan.PlayerClan, target);
        }
    }
}
