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

namespace HonestWork
{
    public class VillageLaborBehavior : CampaignBehaviorBase
    {
        private readonly ILogger _logger;
        private readonly GlobalSettings _settings;

        private CampaignTime _startTime;
        private int _hoursWorked;
        private int _totalContinuousHours;

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
            foreach(var party in settlement.Parties)
            {
                if (party.LeaderHero != null && party.LeaderHero.Clan != Clan.PlayerClan)
                {
                    // 1. Work: 20% Chance AND Passive Boosts
                    float workChance = 0.2f;
                    
                    // Passive Boosts based on Party Tier Power
                    int power = HonestWorkHelpers.GetPartyTotalTier(party);
                    if (power > 0)
                    {
                        if (settlement.Village != null)
                        {
                            // Hearth Boost: 1000 tier power (approx 200 elite troops) -> 0.5 per hour
                            float hearthGain = power * 0.0005f;
                            settlement.Village.Hearth += hearthGain;
                        }
                        
                        // Militia Boost
                        float militiaGain = power * 0.001f;
                        settlement.Militia += militiaGain;
                        
                        // Spawn Acceleration (Refresh recruits)
                        AccelerateRecruitSpawning(settlement.Village, power);
                    }

                    if (MBRandom.RandomFloat < workChance)
                    {
                        HonestWorkHelpers.GiveRandomPartyXp(party, 20, 20, 50); // Hard Labor XP
                    }
                    
                    // 2. Noble Farming / Recruitment Logic (Every hour check)
                    // If Party has room
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
             
             // Chance to fill a slot per hour based on power.
             // 1000 Power = 5% chance per notable check?
             float spawnChance = power * 0.00005f; 
             
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
                                 
                                 // 15% Chance for Elite (Noble Line) if available (Configurable)
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
                             if (!recruitedThisTick && MBRandom.RandomFloat < 0.15f) // 15% chance per effective slot check per hour
                             {
                                 // Take him
                                 party.MemberRoster.AddToCounts(charObj, 1);
                                 
                                 // Clear slot
                                 notable.VolunteerTypes[i] = null;
                                 recruitedThisTick = true;
                                 
                                 // Log/Flavor
                                 if (MBRandom.RandomFloat < 0.05f) 
                                     InformationManager.DisplayMessage(new InformationMessage($"{party.LeaderHero.Name} recruited a {charObj.Name} from {village.Name}."));
                                 
                                 // Give Food
                                 party.ItemRoster.AddToCounts(DefaultItems.Grain, 2);
                             }
                         }
                     }
                 }
             }

             // AI STAY LOGIC
             // If we found good troops (even if we didn't recruit one this specific second), we WANT to stay.
             // "If the roster has more tier 0 or 1 they dont wait any more" -> if !foundSomethingGood, we do nothing (allow leave).
             if (foundSomethingGood && party.MemberRoster.TotalManCount < party.Party.PartySizeLimit && _settings.EnableNobleFarming)
             {
                 // Reinforce "Stay Here" (Camp)
                 party.SetMoveModeHold();
             }
        }

        private void AddGameMenus(CampaignGameStarter campaignStarter)
        {
            campaignStarter.AddGameMenuOption("village", "village_work", "Work in the fields (Wait)",
                (MenuCallbackArgs args) =>
                {
                    args.optionLeaveType = GameMenuOption.LeaveType.Wait;
                    return !Hero.MainHero.MapFaction.IsAtWarWith(Settlement.CurrentSettlement.MapFaction);
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
            
             campaignStarter.AddGameMenuOption("village_work_wait", "village_work_wait_leave", "Stop Working",
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
                        
                        // Grant Companion XP
                        comp.AddSkillXp(DefaultSkills.Athletics, (int)(20 * (1.0f + contribution)));

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
                HonestWorkHelpers.GiveRandomPartyXp(Hero.MainHero.PartyBelongedTo, 20, 20, 50);
            }
            
            // XP: Buff Athletics gain to Base + Streak * Multiplier
            float xpMultiplier = 1.0f + (_totalContinuousHours * _settings.XpStreakMultiplier);
            xpMultiplier += companionBonus; // Companions help ease the load/teach
            
            int xpAmount = (int)(_settings.VillageBaseXp * xpMultiplier);
            Hero.MainHero.AddSkillXp(DefaultSkills.Athletics, xpAmount);
            InformationManager.DisplayMessage(new InformationMessage($"Gained {xpAmount} Athletics XP."));

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
            // Normalize: 100 Athletics -> 0.1 (10%)
            // Maybe generous? 
            return score * 0.001f;
        }

        private void GiveShiftReward()
        {
            var settlement = Settlement.CurrentSettlement;
            if (settlement != null && settlement.Village != null)
            {
                // Production: Add 5 Units of the village's primary production to the Village Market.
                if (settlement.Village.VillageType.PrimaryProduction != null)
                {
                    // Village Market is essentially the Settlement ItemRoster
                    settlement.ItemRoster.AddToCounts(settlement.Village.VillageType.PrimaryProduction, 5);
                }

                // Reward: Pick a random item from the Village Market and give it to the Player.
                if (settlement.ItemRoster.Count > 0)
                {
                     var randomItem = settlement.ItemRoster.GetRandomElement();
                     if (randomItem.EquipmentElement.Item != null)
                     {
                         Hero.MainHero.PartyBelongedTo.ItemRoster.AddToCounts(randomItem.EquipmentElement.Item, 1);
                         settlement.ItemRoster.AddToCounts(randomItem.EquipmentElement.Item, -1);
                         
                         InformationManager.DisplayMessage(new InformationMessage($"Received 1 {randomItem.EquipmentElement.Item.Name}"));
                     }
                }

                if (settlement.Notables.Count > 0)
                {
                    Hero notable = settlement.Notables.GetRandomElement();
                    ChangeRelationAction.ApplyRelationChangeBetweenHeroes(Hero.MainHero, notable, 1, true);
                    InformationManager.DisplayMessage(new InformationMessage($"Relationship increased with {notable.Name}"));
                }
            }

            GainRenownAction.Apply(Hero.MainHero, 0.5f, false);
            InformationManager.DisplayMessage(new InformationMessage("Shift complete. You continue your labor..."));
            
            // Loop Logic: RESET the start time and let the player continue waiting.
            _startTime = CampaignTime.Now;
            _hoursWorked = 0;
        }
    }
}
