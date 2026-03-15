using System;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.GameMenus;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;
using Serilog;

using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.ObjectSystem;
using TaleWorlds.CampaignSystem.Encounters;
using SandBox;
using TaleWorlds.CampaignSystem.Settlements.Locations;

namespace HonestWork
{
    public class VillageLaborBehavior : CampaignBehaviorBase
    {
        private readonly ILogger _logger;
        private readonly GlobalSettings _settings;

        private CampaignTime _startTime;
        private int _hoursWorked;
        private int _totalContinuousHours;

        // Tracks boost expiration time for each village by its StringId
        private System.Collections.Generic.Dictionary<string, CampaignTime> _villageBoostEndTimes = new System.Collections.Generic.Dictionary<string, CampaignTime>();

        public VillageLaborBehavior(ILogger logger, GlobalSettings settings)
        {
            _logger = logger;
            _settings = settings;
        }

        public override void RegisterEvents()
        {
            CampaignEvents.OnSessionLaunchedEvent.AddNonSerializedListener(this, OnSessionLaunched);
            CampaignEvents.HourlyTickEvent.AddNonSerializedListener(this, OnHourlyTick);
        }

        public override void SyncData(IDataStore dataStore)
        {
            dataStore.SyncData("_villageBoostEndTimes", ref _villageBoostEndTimes);
        }

        public void AddBoost(Settlement village, int days)
        {
            if (village == null || !village.IsVillage) return;

            CampaignTime currentEndTime = CampaignTime.Now;
            if (_villageBoostEndTimes.ContainsKey(village.StringId))
            {
                currentEndTime = _villageBoostEndTimes[village.StringId];
                if (currentEndTime < CampaignTime.Now)
                {
                    currentEndTime = CampaignTime.Now;
                }
            }

            _villageBoostEndTimes[village.StringId] = currentEndTime + CampaignTime.Days(days);
            _logger.Information($"VillageLabor: Added {days} days boost to {village.Name}. New expiration: {_villageBoostEndTimes[village.StringId]}");
        }

        public float GetBoostMultiplier(Settlement village)
        {
            if (village == null || !village.IsVillage || !_villageBoostEndTimes.ContainsKey(village.StringId))
                return 1.0f;

            if (_villageBoostEndTimes[village.StringId] > CampaignTime.Now)
            {
                return 1.5f; // 50% increase
            }

            return 1.0f;
        }

        private void OnSessionLaunched(CampaignGameStarter campaignStarter)
        {
            _logger.Information("VillageLaborBehavior: Initializing Menus...");
            AddGameMenus(campaignStarter);
            _logger.Information("VillageLaborBehavior: Menus Initialized.");
        }

        private void OnHourlyTick()
        {
             if (!_settings.EnableAiVillages) return;

             foreach (var settlement in Settlement.All)
             {
                 if (settlement.IsVillage)
                 {
                     ProcessAIHourlyWork(settlement);
                 }
             }
        }
        
        private void ProcessAIHourlyWork(Settlement settlement)
        {
            if (settlement.Parties == null) return;
            
            // Iterate Parties in Village
            foreach(var party in settlement.Parties.ToList())
            {
                if (party.LeaderHero != null && party.LeaderHero.Clan != Clan.PlayerClan)
                {
                    // Work Probability
                    float workChance = _settings.AiWorkChance;
                    
                    // Passive Boosts
                    int power = HonestWorkHelpers.GetPartyTotalTier(party);
                    if (power > 0)
                    {
                        if (settlement.Village != null)
                        {
                            float hearthGain = power * _settings.PowerHearthScalar;
                            settlement.Village.Hearth += hearthGain;
                        }
                        
                        float militiaGain = power * (_settings.PowerHearthScalar * 2.0f); // Militia scalar roughly 2x Hearth
                        settlement.Militia += militiaGain;
                        
                        AccelerateRecruitSpawning(settlement.Village, power);
                    }

                    if (MBRandom.RandomFloat < workChance)
                    {
                        // Party XP
                        int minXp = _settings.XpSecondary;
                        int maxXp = Math.Max(minXp + 20, 50);
                        HonestWorkHelpers.GiveRandomPartyXp(party, _settings.XpPrimary, minXp, maxXp); 

                        // Hearth Gain
                        if (settlement.Village != null)
                        {
                            settlement.Village.Hearth += _settings.VillageHearthGain;
                        }

                        // Wage
                        if (settlement.Village != null)
                        {
                            int wage = (int)(settlement.Village.Hearth / _settings.VillageHearthWageDivisor);
                            if (wage < 1) wage = 1;
                            GiveGoldAction.ApplyForSettlementToParty(settlement, party.Party, wage, false);
                        }

                        // Shift Rewards
                        if ((long)CampaignTime.Now.ToHours % _settings.ShiftHours == (_settings.ShiftHours - 1))
                        {
                            ApplyVillageShiftRewards(settlement, party);
                        }
                    }
                    
                    // Noble Farming Logic
                    if (party.MemberRoster.TotalManCount < party.Party.PartySizeLimit)
                    {
                         CheckAndRecruitEliteTroops(settlement.Village, party);
                    }
                }
            }
        }

        private void AccelerateRecruitSpawning(Village village, int power)
        {
             if (village.Settlement == null || village.Settlement.Notables == null) return;
             
             float spawnChance = power * _settings.PowerRecruitScalar;  
             
             foreach (var notable in village.Settlement.Notables)
             {
                 if (MBRandom.RandomFloat < spawnChance)
                 {
                     for (int i=0; i<6; i++)
                     {
                         if (notable.VolunteerTypes[i] == null)
                         {
                             // Spawn logic
                             if (village.Settlement.Culture != null)
                             {
                                 CharacterObject troopToSpawn = village.Settlement.Culture.BasicTroop;
                                 
                                 // 15% Chance for Elite (Noble Line) if available
                                 if (village.Settlement.Culture.EliteBasicTroop != null && MBRandom.RandomFloat < _settings.EliteSpawnChance)
                                 {
                                     troopToSpawn = village.Settlement.Culture.EliteBasicTroop;
                                 }

                                 if (troopToSpawn != null)
                                 {
                                     notable.VolunteerTypes[i] = troopToSpawn;
                                     break; // Only one per notable per tick max
                                 }
                             }
                         }
                     }
                 }
             }
        }

        private void CheckAndRecruitEliteTroops(Village village, MobileParty party)
        {
             if (village.Settlement == null || village.Settlement.Notables == null) return;
             
             bool foundSomethingGood = false;
             bool recruitedThisTick = false;

             foreach (var notable in village.Settlement.Notables)
             {
                 for (int i=0; i<6; i++) // Standard 6 slots
                 {
                     var charObj = notable.VolunteerTypes[i];
                     if (charObj != null)
                     {
                         // Criteria: Tier >= 2
                         if (charObj.Tier >= 2)
                         {
                             foundSomethingGood = true;

                             // Recruit (Limit 1 per tick to prolong stay/camping)
                             if (!recruitedThisTick && MBRandom.RandomFloat < 0.15f) 
                             {
                                 // Take him
                                 party.MemberRoster.AddToCounts(charObj, 1);
                                 
                                 // Clear slot
                                 notable.VolunteerTypes[i] = null;
                                 recruitedThisTick = true;
                                 
                                 // Log/Flavor
                                 if (MBRandom.RandomFloat < 0.05f) 
                                     InformationManager.DisplayMessage(new InformationMessage(new TaleWorlds.Localization.TextObject($"{{=lw_partyleaderhero}}{party.LeaderHero.Name} recruited a {charObj.Name} from {village.Name}.").ToString()));
                                 
                                 // Give Food
                                 party.ItemRoster.AddToCounts(DefaultItems.Grain, 2);
                             }
                         }
                     }
                 }
             }

             // AI STAY LOGIC
             if (foundSomethingGood && party.MemberRoster.TotalManCount < party.Party.PartySizeLimit && _settings.EnableNobleFarming)
             {
                 // Reinforce "Stay Here" (Camp)
                 party.SetMoveModeHold();
             }
        }

        private void AddGameMenus(CampaignGameStarter campaignStarter)
        {
            campaignStarter.AddGameMenuOption("village", "village_work", "{=lw_workinthefields}Work in the fields (Wait)",
                (MenuCallbackArgs args) =>
                {
                    args.optionLeaveType = GameMenuOption.LeaveType.Wait;
                    return !Hero.MainHero.MapFaction.IsAtWarWith(Settlement.CurrentSettlement.MapFaction) && MobileParty.MainParty.Army == null;
                },
                (MenuCallbackArgs args) =>
                {
                    _startTime = CampaignTime.Now;
                    _hoursWorked = 0;
                    _totalContinuousHours = 0;
                    GameMenu.SwitchToMenu("village_work_wait");
                }, false, -1, false);



            campaignStarter.AddWaitGameMenu("village_work_wait", "You help the locals with the harvest...",
                (MenuCallbackArgs args) => 
                {
                },
                (MenuCallbackArgs args) => 
                {
                    return true;
                },
                (MenuCallbackArgs args) => 
                {
                },
                (MenuCallbackArgs args, CampaignTime dt) => 
                {
                    double elapsedHours = _startTime.ElapsedHoursUntilNow;

                    if ((int)elapsedHours > _hoursWorked)
                    {
                        _hoursWorked++;
                        _totalContinuousHours++;
                        GiveHourlyReward();
                        
                        // Bonus every Shift Length
                        if (_hoursWorked % _settings.ShiftHours == 0)
                        {
                            GiveShiftReward();
                        }
                    }
                },
                GameMenu.MenuAndOptionType.WaitMenuShowOnlyProgressOption,
                GameMenu.MenuOverlayType.SettlementWithBoth,
                0f,
                GameMenu.MenuFlags.None,
                null
            );
            
             campaignStarter.AddGameMenuOption("village_work_wait", "village_work_wait_leave", "{=lw_stopworking}Stop Working",
                (MenuCallbackArgs args) =>
                {
                    args.optionLeaveType = GameMenuOption.LeaveType.Leave;
                    return true;
                },
                (MenuCallbackArgs args) =>
                {
                    GameMenu.SwitchToMenu("village");
                }, true, -1, false);
        }

        private void GiveHourlyReward()
        {
            // Companion Contribution
            float companionBonus = 0f;
            if (Hero.MainHero.PartyBelongedTo != null)
            {
                foreach (var element in Hero.MainHero.PartyBelongedTo.MemberRoster.GetTroopRoster())
                {
                    if (element.Character.IsHero && element.Character.HeroObject != Hero.MainHero && !element.Character.HeroObject.IsWounded)
                    {
                        var comp = element.Character.HeroObject;
                        float contribution = CalculateCompanionVillageContribution(comp);
                        
                        companionBonus += contribution;
                    }
                }
            }

            if (Settlement.CurrentSettlement != null && Hero.MainHero.PartyBelongedTo != null)
            {
                float hearths = 0f;
                // Use Reflection to get Hearth to be safe
                var hearthProp = typeof(Village).GetProperty("Hearth");
                if (hearthProp != null)
                {
                    hearths = (float)hearthProp.GetValue(Settlement.CurrentSettlement.Village);
                }
                
                int goldAmount = (int)Math.Ceiling(hearths / _settings.VillageHearthWageDivisor);
                if (goldAmount < 1) goldAmount = 1;

                // Apply Companion Bonus to Wages
                goldAmount = (int)(goldAmount * (1.0f + companionBonus));

                // Step 1: Give the village its share (equal to player wage) to simulate value added
                try
                {
                    if (Settlement.CurrentSettlement != null && Settlement.CurrentSettlement.Village != null)
                    {
                        var changeGoldMethod = typeof(Village).GetMethod("ChangeGold") ?? typeof(SettlementComponent).GetMethod("ChangeGold");
                        if (changeGoldMethod != null)
                        {
                            // Add wage * 2 to village (One share for them, one share to be transferred to player)
                            changeGoldMethod.Invoke(Settlement.CurrentSettlement.Village, new object[] { goldAmount * 2 });
                        }
                    }
                }
                catch {}

                GiveGoldAction.ApplyForSettlementToParty(Settlement.CurrentSettlement, Hero.MainHero.PartyBelongedTo.Party, goldAmount, false);
            }

            // Random Party XP (Player)
            if (Hero.MainHero.PartyBelongedTo != null)
            {
                int minXp = _settings.XpSecondary;
                int maxXp = Math.Max(minXp + 20, 50);
                HonestWorkHelpers.GiveRandomPartyXp(Hero.MainHero.PartyBelongedTo, _settings.XpPrimary, minXp, maxXp);
            }
            
            int interval = _settings.XpIncreaseInterval > 0 ? _settings.XpIncreaseInterval : 4;
            int steps = Math.Max(0, _totalContinuousHours - 1) / interval;
            float xpMultiplier = 1.0f + (steps * _settings.XpStepMultiplier);
            xpMultiplier += companionBonus; // Companions help ease the load/teach
            
            int xpAmount = (int)(_settings.VillageBaseXp * xpMultiplier);
            Hero.MainHero.AddSkillXp(DefaultSkills.Athletics, xpAmount);
            InformationManager.DisplayMessage(new InformationMessage(new TaleWorlds.Localization.TextObject($"{{=lw_gainedxpamounta}}Gained {xpAmount} Athletics XP.").ToString()));

            // Hearth Increase: 
            try
            {
                if (Settlement.CurrentSettlement?.Village != null)
                {
                   var hearthProp = typeof(Village).GetProperty("Hearth");
                   if (hearthProp != null)
                   {
                       float current = (float)hearthProp.GetValue(Settlement.CurrentSettlement.Village);
                       // Companion bonus increases output
                       float gain = _settings.VillageHearthGain * (1.0f + companionBonus);
                       hearthProp.SetValue(Settlement.CurrentSettlement.Village, current + gain);
                   }
                }
            }
            catch(Exception ex) 
            {
                _logger.Error(ex, "VillageLabor: Error updating hearths");
            }
        }

        private float CalculateCompanionVillageContribution(Hero hero)
        {
            float score = hero.GetSkillValue(DefaultSkills.Athletics);
            return score * _settings.CompanionEfficiencyFactor;
        }

        private void ApplyVillageShiftRewards(Settlement settlement, MobileParty party)
        {
            // Production: Add 5 Units of the village's primary production to the Village Market.
            if (settlement.Village.VillageType.PrimaryProduction != null)
            {
                settlement.ItemRoster.AddToCounts(settlement.Village.VillageType.PrimaryProduction, 5);
            }

            // Reward: Pick a random item from the Village Market and give it to the Party.
            if (settlement.ItemRoster.Count > 0 && _settings.EnableVillageItemRewards)
            {
                 var randomItem = settlement.ItemRoster.GetRandomElement();
                 if (randomItem.EquipmentElement.Item != null)
                 {
                     party.ItemRoster.AddToCounts(randomItem.EquipmentElement.Item, 1);
                     settlement.ItemRoster.AddToCounts(randomItem.EquipmentElement.Item, -1);
                     
                     if (party.LeaderHero == Hero.MainHero)
                        InformationManager.DisplayMessage(new InformationMessage(new TaleWorlds.Localization.TextObject($"{{=lw_received1random}}Received 1 {randomItem.EquipmentElement.Item.Name}").ToString()));
                 }
            }

            if (settlement.Notables.Count > 0 && party.LeaderHero != null)
            {
                Hero notable = settlement.Notables.GetRandomElement();
                ChangeRelationAction.ApplyRelationChangeBetweenHeroes(party.LeaderHero, notable, _settings.ShiftRelationBonus, true);
                if (party.LeaderHero == Hero.MainHero)
                    InformationManager.DisplayMessage(new InformationMessage(new TaleWorlds.Localization.TextObject($"{{=lw_relationshipinc}}Relationship increased with {notable.Name}").ToString()));
            }
        }

        private void GiveShiftReward()
        {
            var settlement = Settlement.CurrentSettlement;
            if (settlement != null && settlement.Village != null)
            {
                ApplyVillageShiftRewards(settlement, Hero.MainHero.PartyBelongedTo);
                
                float companionBonus = 0f;
                int hours = _settings.ShiftHours;
                
                // 1. Companion Loop (Calc bonus first)
                if (Hero.MainHero.PartyBelongedTo != null)
                {
                    foreach (var element in Hero.MainHero.PartyBelongedTo.MemberRoster.GetTroopRoster())
                    {
                        if (element.Character.IsHero && element.Character.HeroObject != Hero.MainHero && !element.Character.HeroObject.IsWounded)
                        {
                            var comp = element.Character.HeroObject;
                            float contribution = CalculateCompanionVillageContribution(comp);
                            companionBonus += contribution;
                            
                            // Give Comp XP
                            int compXp = (int)(20 * (1.0f + contribution) * hours);
                            comp.AddSkillXp(DefaultSkills.Athletics, compXp);
                        }
                    }
                }
                
                }

            GainRenownAction.Apply(Hero.MainHero, 0.5f, false);
            InformationManager.DisplayMessage(new InformationMessage(new TaleWorlds.Localization.TextObject("{=lw_shiftcompleteyo}Shift complete. You continue your labor...").ToString()));
            
            // Loop Logic: RESET the start time and let the player continue waiting.
            _startTime = CampaignTime.Now;
            _hoursWorked = 0;
        }
    }
}
