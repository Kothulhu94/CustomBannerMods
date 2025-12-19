using System;
using System.Collections.Generic;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;
using Microsoft.Extensions.Logging;

namespace Brigands.Training
{
    public class BanditTrainingBehavior : CampaignBehaviorBase
    {
        private readonly ILogger<BanditTrainingBehavior> _logger;
        private readonly GlobalSettings _settings;

        public BanditTrainingBehavior(ILogger<BanditTrainingBehavior> logger, GlobalSettings settings)
        {
            _logger = logger;
            _settings = settings;
        }

        public override void RegisterEvents()
        {
            CampaignEvents.HourlyTickEvent.AddNonSerializedListener(this, OnHourlyTick);
        }

        public override void SyncData(IDataStore dataStore) { }

        private void OnHourlyTick()
        {
            if (CampaignTime.Now.CurrentHourInDay != 6) return;

            List<MobileParty> safeBandits = new List<MobileParty>();
            foreach (var p in MobileParty.All)
            {
                if (p == null || !p.IsActive || p.MapFaction == null) continue;

                bool isBandit = (p.MapFaction.IsBanditFaction || p.MapFaction.IsOutlaw);
                
                try
                {
                    if (!isBandit && p.MapFaction.StringId != null && p.MapFaction.StringId.ToLower().Contains("deserter")) 
                    {
                        isBandit = true;
                    }
                } 
                catch {}
                
                bool isTarget = isBandit || (p.MapFaction.StringId == "TheSyndicate");

                if (isTarget)
                {
                    safeBandits.Add(p);
                }
            }

            int xpPerMan = _settings.DailyXpPerMan;

            foreach (var bandit in safeBandits)
            {
                try
                {
                    if (!bandit.IsActive) continue;
                    
                    if (bandit.MapEvent != null || bandit.MapEventSide != null) continue;
                    
                    if (bandit.TargetParty == MobileParty.MainParty) continue;

                    var rosterSnapshot = bandit.MemberRoster.GetTroopRoster().ToList();
                    foreach (var element in rosterSnapshot)
                    {
                        var troop = element.Character;
                        if (troop != null)
                        {
                            int totalXp = xpPerMan * element.Number;
                            bandit.MemberRoster.AddXpToTroop(troop, totalXp);
                            
                            int index = bandit.MemberRoster.FindIndexOfTroop(troop);
                            if (index >= 0)
                            {
                                var updatedElement = bandit.MemberRoster.GetElementCopyAtIndex(index);
                                
                                int ready = 0;
                                if (troop.UpgradeTargets != null && troop.UpgradeTargets.Length > 0)
                                {
                                    int xpCost = troop.GetUpgradeXpCost(bandit.Party, 0);
                                    if (xpCost > 0)
                                    {
                                        ready = updatedElement.Xp / xpCost;
                                    }
                                }
                                
                                if (ready > 0 && troop.UpgradeTargets != null && troop.UpgradeTargets.Length > 0)
                                {
                                    int targetIndex = MBRandom.RandomInt(troop.UpgradeTargets.Length);
                                    var target = troop.UpgradeTargets[targetIndex];
                                    
                                    bandit.MemberRoster.AddToCounts(target, ready);
                                    bandit.MemberRoster.AddToCounts(troop, -ready);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogWarning($"Skipping buggy bandit {bandit?.Name?.ToString() ?? "Unknown"}: {ex.Message}");
                    continue;
                }
            }
        }
    }
}

