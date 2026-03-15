using System;
using System.Collections.Generic;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Library;
using Serilog;

namespace HappyParty
{
    public class EliteRecruiterBehavior : CampaignBehaviorBase
    {
        private readonly GlobalSettings _settings;
        private readonly ILogger _logger;

        public EliteRecruiterBehavior(GlobalSettings settings, ILogger logger)
        {
            _settings = settings;
            _logger = logger.ForContext<EliteRecruiterBehavior>();
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

                if (mobileParty.MemberRoster.TotalManCount >= mobileParty.Party.PartySizeLimit)
                {
                    return;
                }

                if (settlement.Notables == null) return;

                var notables = new List<Hero>();
                foreach(var n in settlement.Notables) notables.Add(n);

                foreach (var notable in notables)
                {
                    if (notable == null) continue;

                    for (int i = 0; i < 6; i++)
                    {
                        try
                        {
                            if (mobileParty.MemberRoster.TotalManCount >= mobileParty.Party.PartySizeLimit)
                            {
                                return;
                            }

                            CharacterObject recruit = null;
                            if (notable.VolunteerTypes != null && i < notable.VolunteerTypes.Length)
                            {
                                recruit = notable.VolunteerTypes[i];
                            }

                            if (recruit != null)
                            {
                                bool isElite = recruit.Tier >= 3;
                                
                                if (isElite)
                                {
                                    int cost = (int)Campaign.Current.Models.PartyWageModel.GetTroopRecruitmentCost(recruit, mobileParty.LeaderHero).ResultNumber;

                                    if (mobileParty.LeaderHero != null && mobileParty.LeaderHero.Gold >= cost)
                                    {
                                        GiveGoldAction.ApplyBetweenCharacters(mobileParty.LeaderHero, null, cost, true);
                                        mobileParty.MemberRoster.AddToCounts(recruit, 1);

                                        if (notable.VolunteerTypes != null)
                                        {
                                            notable.VolunteerTypes[i] = null;
                                        }

                                        if (_settings.DebugMode)
                                        {
                                            _logger.Debug($"{mobileParty.Name} recruited elite {recruit.Name} from {settlement.Name}");
                                        }
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                           if (_settings.DebugMode) _logger.Error(ex, "Error processing notable volunteer");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (_settings.DebugMode) _logger.Error(ex, "Error in EliteRecruiterBehavior");
            }
        }
    }
}
