using System;
using System.Linq;
using Microsoft.Extensions.Logging;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.GameMenus;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;

using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.CharacterDevelopment;
using NavalDLC;

namespace CoastalLife
{
    public class PressGangBehavior : CampaignBehaviorBase
    {
        private readonly ILogger<PressGangBehavior> _logger;
        private readonly GlobalSettings _settings;

        public PressGangBehavior(ILogger<PressGangBehavior> logger, GlobalSettings settings)
        {
            _logger = logger;
            _settings = settings;
        }

        public override void RegisterEvents()
        {
            CampaignEvents.OnSessionLaunchedEvent.AddNonSerializedListener(this, OnSessionLaunched);

        }

        public override void SyncData(IDataStore dataStore)
        {
        }

        private void OnSessionLaunched(CampaignGameStarter campaignStarter)
        {
            _logger.LogDebug("PressGangBehavior: Adding menu option to 'town'...");
            campaignStarter.AddGameMenuOption("town", "press_gang_crew", "Press Gang Crew (Lose Honor)",
                (MenuCallbackArgs args) =>
                {
                    args.optionLeaveType = GameMenuOption.LeaveType.Recruit;
                    
                    if (Settlement.CurrentSettlement == null || !Settlement.CurrentSettlement.IsTown) return false;
                    
                    // Check for shipyard
                    try
                    {
                        var shipyard = NavalDLCExtensions.GetShipyard(Settlement.CurrentSettlement.Town);
                        if (shipyard == null) return false;
                    }
                    catch { return false; }

                    return true;
                },
                (MenuCallbackArgs args) =>
                {
                    ExecutePressGang(Settlement.CurrentSettlement);
                }, false, -1, false);
             _logger.LogDebug("PressGangBehavior: Menu option added.");
        }

        private void ExecutePressGang(Settlement settlement)
        {
            CharacterObject recruit = null;
            
            var culture = settlement.Culture;
            if (culture != null)
            {
                 recruit = culture.BasicTroop; 
            }

            if (recruit == null) return;

            if (MobileParty.MainParty == null)
            {
                _logger.LogWarning("PressGang: MainParty is null, cannot add recruits.");
                return;
            }

            int count = MBRandom.RandomInt(10, 21);
            MobileParty.MainParty.MemberRoster.AddToCounts(recruit, count);

            ChangeRelationAction.ApplyRelationChangeBetweenHeroes(Hero.MainHero, settlement.OwnerClan.Leader, _settings.PressGangRelationPenalty, true);
            Hero.MainHero.SetTraitLevel(DefaultTraits.Honor, Hero.MainHero.GetTraitLevel(DefaultTraits.Honor) - 1);

            InformationManager.DisplayMessage(new InformationMessage($"Pressed {count} {recruit.Name} into service!"));
            _logger.LogInformation($"PressGang: Pressed {count} {recruit.Name} at {settlement.Name}");
        }
    }
}
