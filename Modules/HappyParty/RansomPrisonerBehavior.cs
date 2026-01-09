using System;
using System.Collections.Generic;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.CampaignSystem.Roster;
using TaleWorlds.Core;
using TaleWorlds.Library;
using Serilog;

namespace HappyParty
{
    public class RansomPrisonerBehavior : CampaignBehaviorBase
    {
        private readonly GlobalSettings _settings;
        private readonly ILogger _logger;

        public RansomPrisonerBehavior(GlobalSettings settings, ILogger logger)
        {
            _settings = settings;
            _logger = logger.ForContext<RansomPrisonerBehavior>();
        }

        public override void RegisterEvents()
        {
            CampaignEvents.SettlementEntered.AddNonSerializedListener(this, OnSettlementEntered);
        }

        public override void SyncData(IDataStore dataStore)
        {
        }

        private void OnSettlementEntered(MobileParty mobileParty, Settlement settlement, Hero hero)
        {
            try
            {
                if (mobileParty == null || mobileParty.IsMainParty || !mobileParty.IsLordParty)
                {
                    return;
                }

                if (!settlement.IsTown)
                {
                    return;
                }

                if (mobileParty.PrisonRoster.TotalManCount <= 0)
                {
                    return;
                }

                int totalRansomValue = 0;
                var prisonRoster = mobileParty.PrisonRoster;
                
                // Snapshot to modify collection while iterating
                var rosterList = new List<TroopRosterElement>(prisonRoster.GetTroopRoster());

                foreach (var element in rosterList)
                {
                    int count = element.Number;
                    if (element.Character != null)
                    {
                        // CRITICAL FIX: Handle Heroes via Proper Actions
                        if (element.Character.IsHero && element.Character.HeroObject != null)
                        {
                            if (_settings.DebugMode)
                                _logger.Information($"[RansomPrisoner] Releasing Hero {element.Character.Name} from {mobileParty.Name} to prevent eternal imprisonment.");

                            // Releases the hero from captivity properly (updates state, log, etc)
                            // This automatically removes them from the PrisonRoster.
                            // Use valid API method
                            if (mobileParty.LeaderHero != null)
                                EndCaptivityAction.ApplyByReleasedByChoice(element.Character.HeroObject, mobileParty.LeaderHero);
                            else
                                EndCaptivityAction.ApplyByEscape(element.Character.HeroObject, null);
                            continue;
                        }

                        // Logic Refactor: Recruit High Tier Prisoners if we have space
                        if (mobileParty.Party.PartySizeLimit > mobileParty.MemberRoster.TotalManCount &&
                            mobileParty.LeaderHero.Gold > 2000)
                        {
                             if (element.Character.Tier >= 4) // Ensure we only recruit troops
                             {
                                 // Attempt to recruit up to available space
                                 int space = mobileParty.Party.PartySizeLimit - mobileParty.MemberRoster.TotalManCount;
                                 int toRecruit = Math.Min(count, space);
                                 
                                 if (toRecruit > 0)
                                 {
                                     mobileParty.MemberRoster.AddToCounts(element.Character, toRecruit);
                                     mobileParty.PrisonRoster.AddToCounts(element.Character, -toRecruit);
                                     
                                     // Simulation Cost: 200g per recruit (Bribe)
                                     mobileParty.LeaderHero.Gold -= (toRecruit * 200);
                                     
                                     if (_settings.DebugMode) 
                                        _logger.Information($"[AI Decision] {mobileParty.Name} recruited {toRecruit} {element.Character.Name} from prisoners.");

                                     count -= toRecruit;
                                 }
                             }
                        }

                        if (count > 0)
                        {
                            int value = element.Character.Tier * 100; 
                            if (value == 0) value = 50; 
                            totalRansomValue += value * count;

                            // Manually remove ransomed troops since we don't Clear() anymore
                            mobileParty.PrisonRoster.AddToCounts(element.Character, -count);
                        }
                    }
                }

                if (totalRansomValue > 0)
                {
                    // Apply modifier (default 100%)
                    totalRansomValue = (int)(totalRansomValue * (_settings.PrisonerRansomModifier / 100.0f));
                    
                    if (mobileParty.LeaderHero != null)
                    {
                        GiveGoldAction.ApplyBetweenCharacters(null, mobileParty.LeaderHero, totalRansomValue, true);
                        
                        if (_settings.DebugMode)
                        {
                            _logger.Debug($"{mobileParty.Name} ransomed prisoners for {totalRansomValue} gold.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (_settings.DebugMode) _logger.Error(ex, "Error in RansomPrisonerBehavior");
            }
        }
    }
}
