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
                
                var rosterList = new List<TroopRosterElement>();
                foreach(var element in prisonRoster.GetTroopRoster()) rosterList.Add(element);

                foreach (var element in rosterList)
                {
                    int count = element.Number;
                    if (element.Character != null)
                    {
                        int value = element.Character.Tier * 100; 
                        if (value == 0) value = 50; 
                        
                        totalRansomValue += value * count;
                    }
                }

                if (totalRansomValue > 0)
                {
                    // Apply modifier (default 100%)
                    totalRansomValue = (int)(totalRansomValue * (_settings.PrisonerRansomModifier / 100.0f));
                    
                    if (mobileParty.LeaderHero != null)
                    {
                        GiveGoldAction.ApplyBetweenCharacters(null, mobileParty.LeaderHero, totalRansomValue, true);
                        mobileParty.PrisonRoster.Clear();
                        
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
