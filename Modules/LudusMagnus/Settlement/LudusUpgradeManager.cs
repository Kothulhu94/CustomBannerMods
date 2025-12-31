using System;
using System.Collections.Generic;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.Core;
using TaleWorlds.Library;
using LudusMagnus.Core;
using Serilog;
using Microsoft.Extensions.Logging;

namespace LudusMagnus.Settlements
{
    public class LudusUpgradeManager
    {
        public static LudusUpgradeManager Instance { get; } = new LudusUpgradeManager();

        public int GetUpgradeLevel(LudusLocation ludus, FacilityType type)
        {
            if (ludus == null || ludus.Facilities == null) return 0;
            return ludus.Facilities.TryGetValue(type, out int level) ? level : 0;
        }

        public int GetUpgradeCost(int currentLevel)
        {
            return (currentLevel + 1) * 50000;
        }

        public bool CanUpgrade(LudusLocation ludus, FacilityType type, out string reason)
        {
            int currentLevel = GetUpgradeLevel(ludus, type);
            if (currentLevel >= 3)
            {
                reason = "Max Level Reached";
                return false;
            }

            int cost = GetUpgradeCost(currentLevel);
            // Use owner if available, otherwise fallback to MainHero or fail
            Hero payer = ludus?.Owner ?? Hero.MainHero;
            
            if (payer.Gold < cost)
            {
                reason = $"Not Enough Gold ({cost})";
                LudusSubModule.InstanceLogger?.LogTrace("Upgrade check failed for {Facility} at {Settlement}: Not enough gold ({Gold}/{Cost}).", 
                    type, ludus?.Settlement?.Name?.ToString() ?? "Unknown", payer.Gold, cost);
                return false;
            }

            reason = "Ready";
            return true;
        }

        public void UpgradeFacility(LudusLocation ludus, FacilityType type)
        {
            if (ludus == null || ludus.Facilities == null || ludus.Owner == null) return;

            int currentLevel = GetUpgradeLevel(ludus, type);
            int cost = GetUpgradeCost(currentLevel);
            Hero payer = ludus.Owner;

            if (payer.Gold >= cost)
            {
                GiveGoldAction.ApplyBetweenCharacters(payer, null, cost);
                
                int newLevel = 1;
                if (ludus.Facilities.ContainsKey(type))
                {
                    ludus.Facilities[type]++;
                    newLevel = ludus.Facilities[type];
                }
                else
                {
                    ludus.Facilities.Add(type, 1);
                }

                LudusSubModule.InstanceLogger?.LogInformation("Upgraded {Facility} to Level {Level} at {Ludus} for {Cost}.", type, newLevel, ludus.Settlement?.Name?.ToString() ?? "Unknown", cost);

                if (payer == Hero.MainHero)
                {
                    InformationManager.DisplayMessage(new InformationMessage($"{type} upgraded to Level {newLevel}!", Colors.Green));
                }
            }
            else
            {
                LudusSubModule.InstanceLogger?.LogWarning("Upgrade failed for {Facility} at {Ludus}: Transaction incomplete despite check.", type, ludus.Settlement?.Name?.ToString() ?? "Unknown");
            }
        }

        // Stubbed for now, future use
        public bool IsDamaged(string ludusId, string facilityName)
        {
            return false;
        }
    }
}
