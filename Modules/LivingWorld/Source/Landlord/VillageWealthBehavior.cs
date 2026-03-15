using System;
using System.Collections.Generic;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.CampaignSystem.Roster;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;
using Microsoft.Extensions.Logging;
using LivingLegend; 

namespace Landlord
{
    public class VillageWealthBehavior : CampaignBehaviorBase
    {
        private readonly ILogger<VillageWealthBehavior> _logger;
        private readonly string[] _cultureRotation = { "empire", "vlandia", "sturgia", "battania", "aserai", "khuzait", "nord" };

        public VillageWealthBehavior(ILogger<VillageWealthBehavior> logger)
        {
            _logger = logger;
        }

        public override void RegisterEvents()
        {
            CampaignEvents.DailyTickEvent.AddNonSerializedListener(this, OnDailyTick);
            CampaignEvents.HourlyTickEvent.AddNonSerializedListener(this, OnHourlyTick);
        }

        public override void SyncData(IDataStore dataStore)
        {
            LandlordManager.Instance.SyncData(dataStore);
        }

        private void OnHourlyTick()
        {
            foreach (var kvp in LandlordManager.Instance.VillageWealthValues)
            {
                if (string.IsNullOrEmpty(kvp.Value.PatrolPartyId)) continue;

                MobileParty patrol = MobileParty.All.FirstOrDefault(p => p.StringId == kvp.Value.PatrolPartyId);
                if (patrol == null || !patrol.IsActive) continue;

                UpdatePatrolAI(patrol);
            }
        }

        private void UpdatePatrolAI(MobileParty patrol)
        {
            if (patrol.HomeSettlement == null) return;

            // 1. Hideout Detection (Strength >= 50 and Range <= 50)
            if (patrol.Party.EstimatedStrength >= 50f)
            {
                Settlement nearestHideout = Settlement.All.Where(s => s.IsHideout && s.IsVisible)
                    .OrderBy(s => s.Position.ToVec2().DistanceSquared(patrol.Position.ToVec2()))
                    .FirstOrDefault();

                if (nearestHideout != null && nearestHideout.Position.ToVec2().Distance(patrol.Position.ToVec2()) <= 50f)
                {
                    if (patrol.ShortTermTargetSettlement != nearestHideout)
                    {
                        patrol.SetMoveGoToSettlement(nearestHideout, MobileParty.NavigationType.Default, false);
                        _logger.LogInformation($"[VillageWealth] Patrol {patrol.Name} targeting hideout {nearestHideout.Name}");
                    }
                    return;
                }
            }

            // 2. Loose Tailing of Villagers
            // In 1.3, Village might use VillagerParty or VillagerPartyComponent.
            MobileParty villagerParty = patrol.HomeSettlement.Village?.VillagerPartyComponent?.MobileParty;
            if (villagerParty != null && villagerParty.IsActive)
            {
                if (patrol.TargetParty != villagerParty)
                {
                    // "Loosely tail" by setting target party but with a distance bias if possible, 
                    // or just standard follow which is effective for ambushing bandits targeting the villagers.
                    patrol.SetMoveEscortParty(villagerParty, MobileParty.NavigationType.Default, false);
                    _logger.LogInformation($"[VillageWealth] Patrol {patrol.Name} tailing villagers of {patrol.HomeSettlement.Name}");
                }
                return;
            }

            // 3. Fallback: Patrol Home Settlement
            if (patrol.ShortTermTargetSettlement != patrol.HomeSettlement)
            {
                patrol.SetMovePatrolAroundSettlement(patrol.HomeSettlement, MobileParty.NavigationType.Default, false);
            }
        }

        private void OnDailyTick()
        {
            int dayOffset = (int)CampaignTime.Now.ToDays;
            string currentCultureId = _cultureRotation[dayOffset % _cultureRotation.Length];

            _logger.LogInformation($"[VillageWealth] Daily Tick: Processing culture {currentCultureId}");

            foreach (var settlement in Settlement.All)
            {
                if (!settlement.IsVillage || settlement.Village == null) continue;

                // Process matching culture or rebels belonging to that base culture
                bool isRebel = settlement.OwnerClan?.IsRebelClan ?? false;
                string baseCultureId = settlement.Culture.StringId.ToLower();

                if (baseCultureId.Contains(currentCultureId))
                {
                    ProcessVillageWealth(settlement);
                }
            }
        }

        private void ProcessVillageWealth(Settlement settlement)
        {
            Village village = settlement.Village;
            if (village.Gold < 10000) return;

            int attempts = 0;
            int maxAttempts = village.Gold > 50000 ? 3 : 1;

            while (village.Gold >= 10000 && attempts < maxAttempts)
            {
                attempts++;
                var wealthData = LandlordManager.Instance.GetWealthData(settlement.StringId);
                float hearths = village.Hearth;

                // Determine Purchase Probabilities
                float hearthChance = 0f;
                float militiaChance = 0f;
                float patrolChance = 0f;

                bool militiaCapped = wealthData.MilitiaBonus >= (hearths * 0.25f);

                if (hearths < 600)
                {
                    hearthChance = 0.6f;
                    militiaChance = 0.3f;
                    patrolChance = 0.1f;
                }
                else
                {
                    hearthChance = 0.25f;
                    militiaChance = 0.50f;
                    patrolChance = 0.25f;
                }

                if (militiaCapped)
                {
                    hearthChance = 0.25f;
                    militiaChance = 0f;
                    patrolChance = 0.75f;
                }

                // Roll for purchase
                float roll = MBRandom.RandomFloat;
                if (roll < hearthChance)
                {
                    ApplyHearthPurchase(settlement);
                }
                else if (roll < hearthChance + militiaChance)
                {
                    ApplyMilitiaPurchase(settlement);
                }
                else if (roll < hearthChance + militiaChance + patrolChance)
                {
                    ApplyPatrolPurchase(settlement);
                }
            }
        }

        private void ApplyHearthPurchase(Settlement settlement)
        {
            Village village = settlement.Village;
            int cost = 10000 + (int)(village.Hearth * 100);

            if (village.Gold >= cost)
            {
                ModifyVillageGold(village, -cost);
                ModifyHearths(village, 10f);
                InformationManager.DisplayMessage(new InformationMessage(new TextObject($"{{=vw_hearth_purchased}}{settlement.Name} invested in land development (+10 Hearths).").ToString(), Colors.Green));
                _logger.LogInformation($"[VillageWealth] {settlement.Name} bought Hearths for {cost}g.");
            }
        }

        private void ApplyMilitiaPurchase(Settlement settlement)
        {
            Village village = settlement.Village;
            int cost = 10000;

            if (village.Gold >= cost)
            {
                var wealthData = LandlordManager.Instance.GetWealthData(settlement.StringId);
                ModifyVillageGold(village, -cost);
                wealthData.MilitiaBonus += 5f;
                InformationManager.DisplayMessage(new InformationMessage(new TextObject($"{{=vw_militia_purchased}}{settlement.Name} invested in town watch (+5 Militia Cap).").ToString(), Colors.Green));
                _logger.LogInformation($"[VillageWealth] {settlement.Name} bought Militia Bonus for {cost}g.");
            }
        }

        private void ApplyPatrolPurchase(Settlement settlement)
        {
            Village village = settlement.Village;
            int cost = 10000;

            if (village.Gold >= cost)
            {
                var wealthData = LandlordManager.Instance.GetWealthData(settlement.StringId);
                MobileParty patrol = null;

                if (!string.IsNullOrEmpty(wealthData.PatrolPartyId))
                {
                    patrol = MobileParty.All.FirstOrDefault(p => p.StringId == wealthData.PatrolPartyId);
                }

                if (patrol == null || !patrol.IsActive)
                {
                    // Initial Spawn or Restore
                    ModifyVillageGold(village, -cost);
                    wealthData.PatrolCapacity = 15;
                    wealthData.PatrolPartyId = SpawnVillagePatrol(settlement, 15);
                    InformationManager.DisplayMessage(new InformationMessage(new TextObject($"{{=vw_patrol_spawned}}{settlement.Name} hired a new militia patrol.").ToString(), Colors.Green));
                }
                else
                {
                    // Upgrade: Choice between Capacity/Count and Tier
                    ModifyVillageGold(village, -cost);
                    
                    if (MBRandom.RandomFloat < 0.5f)
                    {
                        // Option A: Increase Capacity and add troops
                        wealthData.PatrolCapacity += 5;
                        AddTroopsToPatrol(patrol, 5);
                        InformationManager.DisplayMessage(new InformationMessage(new TextObject($"{{=vw_patrol_upgraded_cap}}{settlement.Name} expanded their militia patrol capacity (+5).").ToString(), Colors.Green));
                    }
                    else
                    {
                        // Option B: Upgrade Tiers of existing troops
                        UpgradePatrolTiers(patrol, 10);
                        InformationManager.DisplayMessage(new InformationMessage(new TextObject($"{{=vw_patrol_upgraded_tier}}{settlement.Name} provided elite training to their militia patrol.").ToString(), Colors.Green));
                    }
                }
            }
        }

        private string SpawnVillagePatrol(Settlement settlement, int count)
        {
            MobileParty patrolParty = MobileParty.CreateParty("wealth_patrol_" + settlement.Name + "_" + Guid.NewGuid().ToString().Substring(0, 4), new MilitiaPatrolComponent(settlement));
            
            CharacterObject troop = settlement.Culture.BasicTroop;
            patrolParty.Initialize();
            patrolParty.MemberRoster.AddToCounts(troop, count);
            patrolParty.ActualClan = settlement.OwnerClan;
            
            patrolParty.InitializeMobilePartyAtPosition(patrolParty.MemberRoster, patrolParty.PrisonRoster, settlement.GatePosition);
            patrolParty.SetMovePatrolAroundSettlement(settlement, MobileParty.NavigationType.Default, false);

            return patrolParty.StringId;
        }

        private void AddTroopsToPatrol(MobileParty patrol, int count)
        {
            CharacterObject troop = patrol.HomeSettlement.Culture.BasicTroop;
            patrol.MemberRoster.AddToCounts(troop, count);
        }

        private void UpgradePatrolTiers(MobileParty patrol, int upgradeCount)
        {
            var roster = patrol.MemberRoster;
            int upgraded = 0;
            
            var list = roster.GetTroopRoster().OrderBy(t => t.Character.Tier).ToList();
            
            foreach (var element in list)
            {
                if (upgraded >= upgradeCount) break;
                
                if (element.Character.UpgradeTargets != null && element.Character.UpgradeTargets.Length > 0)
                {
                    CharacterObject nextTier = element.Character.UpgradeTargets[MBRandom.RandomInt(element.Character.UpgradeTargets.Length)];
                    int toUpgrade = Math.Min(element.Number, upgradeCount - upgraded);
                    
                    roster.RemoveTroop(element.Character, toUpgrade);
                    roster.AddToCounts(nextTier, toUpgrade);
                    upgraded += toUpgrade;
                }
            }
        }

        private void ModifyVillageGold(Village village, int amount)
        {
            // Implementation borrowed from EconomyBehavior
            try
            {
                var field = typeof(Village).GetField("_gold", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public);
                if (field != null)
                {
                    int current = (int)field.GetValue(village);
                    field.SetValue(village, current + amount);
                }
            }
            catch { }
        }

        private void ModifyHearths(Village v, float amount)
        {
            try
            {
                var prop = typeof(Village).GetProperty("Hearth");
                if (prop != null)
                {
                    float current = (float)prop.GetValue(v);
                    prop.SetValue(v, current + amount);
                }
            }
            catch { }
        }
    }
}
