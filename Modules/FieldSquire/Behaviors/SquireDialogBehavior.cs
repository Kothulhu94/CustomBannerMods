using System.Collections.Generic;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Engine.GauntletUI;
using TaleWorlds.Library;
using TaleWorlds.Localization;
using TaleWorlds.ScreenSystem;
using TaleWorlds.CampaignSystem.Party;
using FieldSquire.ViewModels;
using Microsoft.Extensions.Logging;

namespace FieldSquire.Behaviors
{
    public class SquireDialogBehavior : CampaignBehaviorBase
    {
        private readonly ILogger<SquireDialogBehavior> _logger;
        private readonly GlobalSettings _settings;
        private List<Hero> _wandererCache;

        public SquireDialogBehavior(ILogger<SquireDialogBehavior> logger, GlobalSettings settings)
        {
            _logger = logger;
            _settings = settings;
            _wandererCache = new List<Hero>();
        }

        public override void RegisterEvents()
        {
            CampaignEvents.OnSessionLaunchedEvent.AddNonSerializedListener(this, OnSessionLaunched);
            CampaignEvents.DailyTickEvent.AddNonSerializedListener(this, OnDailyTick);
        }

        public override void SyncData(IDataStore dataStore)
        {
        }

        private void OnDailyTick()
        {
            RefreshWandererCache();
        }

        private void RefreshWandererCache()
        {
            // Cache valid wanderers daily to massive performance spike during dialog
            _wandererCache = Hero.AllAliveHeroes
                .Where(h => h.IsWanderer && h.HeroState == Hero.CharacterStates.Active && h.Clan == null)
                .ToList();
        }

        private void OnSessionLaunched(CampaignGameStarter starter)
        {
            RefreshWandererCache();

            // Remote Management
            starter.AddPlayerLine("squire_talk_manage", "hero_main_options", "squire_manage_reply", "Let me review the ledgers.", IsSquire, null);
            starter.AddDialogLine("squire_manage_reply", "squire_manage_reply", "close_window", "Certainly. Which settlement reviews do you strictly need?", null, OpenManagementInquiry);

            // Supply Settings
            starter.AddPlayerLine("squire_talk_supply", "hero_main_options", "squire_supply_reply", "I need to set our supply list.", IsSquire, null);
            starter.AddDialogLine("squire_supply_reply", "squire_supply_reply", "close_window", "I shall arrange the manifest. What is the target stock level?", null, OpenSupplyInquiry);

            // Wanderer Search (Tinder)
            starter.AddPlayerLine("squire_talk_search", "hero_main_options", "squire_search_start", "Anyone worth bringing along nearby?", IsSquire, null);
            starter.AddDialogLine("squire_search_reply", "squire_search_start", "squire_search_options", "It depends on the job. Who do you need?", null, null);

            // Search Options

            starter.AddPlayerLine("squire_search_healer", "squire_search_options", "squire_search_result", "Find me a Healer.", null, () => SearchForWanderer(DefaultSkills.Medicine));
            starter.AddPlayerLine("squire_search_scout", "squire_search_options", "squire_search_result", "We need a Scout.", null, () => SearchForWanderer(DefaultSkills.Scouting));
            starter.AddPlayerLine("squire_search_engineer", "squire_search_options", "squire_search_result", "We need an Engineer.", null, () => SearchForWanderer(DefaultSkills.Engineering));
            starter.AddPlayerLine("squire_search_steward", "squire_search_options", "squire_search_result", "Find me a Quartermaster.", null, () => SearchForWanderer(DefaultSkills.Steward));
            starter.AddPlayerLine("squire_search_warrior", "squire_search_options", "squire_search_result", "We need a Warrior.", null, SearchForWarrior);
            starter.AddPlayerLine("squire_search_cancel", "squire_search_options", "close_window", "Never mind.", null, null);

            // Result
            starter.AddDialogLine("squire_search_result_reply", "squire_search_result", "close_window", "{SQUIRE_SEARCH_RESULT}", null, null);
        }

        private void SearchForWanderer(SkillObject skill)
        {
            string result = FindWandererBySkill(skill);
            MBTextManager.SetTextVariable("SQUIRE_SEARCH_RESULT", result);
        }

        private void SearchForWarrior()
        {
            string result = FindWarriorWanderer();
            MBTextManager.SetTextVariable("SQUIRE_SEARCH_RESULT", result);
        }

        // Cache the PropertyInfo to avoid O(N) reflection lookup in loops
        private static readonly System.Reflection.PropertyInfo _positionProperty = typeof(MobileParty).GetProperty("Position2D", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic);

        private Vec2 GetHeroPosition(Hero hero)
        {
            if (hero.CurrentSettlement != null) return hero.CurrentSettlement.GetPosition().AsVec2;
            
            if (hero.PartyBelongedTo != null && _positionProperty != null) 
            {
                 return (Vec2)_positionProperty.GetValue(hero.PartyBelongedTo);
            }
            return Vec2.Zero; 
        }

        private string FindWarriorWanderer()
        {
            try
            {
                var combatSkills = new List<SkillObject> { DefaultSkills.OneHanded, DefaultSkills.TwoHanded, DefaultSkills.Polearm, DefaultSkills.Bow, DefaultSkills.Crossbow, DefaultSkills.Throwing };

                // Optimization: Calculate Main Hero position once, outside the loop.
                Vec2 mainPos = GetHeroPosition(Hero.MainHero);

                // Use Cache
                if (_wandererCache == null || _wandererCache.Count == 0) RefreshWandererCache();

                var candidates = _wandererCache
                    .Select(h => 
                    {
                        var bestSkill = combatSkills.OrderByDescending(s => h.GetSkillValue(s)).First();
                        return new { Hero = h, BestSkill = bestSkill, Value = h.GetSkillValue(bestSkill), Distance = GetHeroPosition(h).Distance(mainPos) };
                    })
                    .Where(x => x.Value >= 60)
                    .OrderBy(x => x.Distance)
                    .Take(3)
                    .ToList();

                if (candidates.Count == 0)
                {
                    return "I couldn't find any skilled warriors nearby, my lord.";
                }

                List<string> results = new List<string>();
                foreach (var match in candidates)
                {
                    string loc = match.Hero.CurrentSettlement != null ? match.Hero.CurrentSettlement.Name.ToString() : "roaming";
                    results.Add($"{match.Hero.Name} in {loc} ({match.Value} {match.BestSkill.Name})");
                }

                return "I found some warriors:\n" + string.Join("\n", results);
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex, "Error in FindWarriorWanderer");
                return "I apologize, my lord, I lost my notes.";
            }
        }

        private string FindWandererBySkill(SkillObject skillToSearch)
        {
            try
            {
                // Optimization: Calculate Main Hero position once, outside the loop.
                Vec2 mainPos = GetHeroPosition(Hero.MainHero);

                // Use Cache
                if (_wandererCache == null || _wandererCache.Count == 0) RefreshWandererCache();

                var candidates = _wandererCache
                    .Where(h => h.GetSkillValue(skillToSearch) >= 60)
                    .Select(h => new { Hero = h, Distance = GetHeroPosition(h).Distance(mainPos) }) // Use cached mainPos
                    .OrderBy(x => x.Distance)
                    .Take(3)
                    .ToList();

                if (candidates.Count == 0)
                {
                    return "I couldn't find anyone with those talents nearby, my lord.";
                }

                List<string> results = new List<string>();
                foreach (var match in candidates)
                {
                    string loc = match.Hero.CurrentSettlement != null ? match.Hero.CurrentSettlement.Name.ToString() : "roaming";
                    results.Add($"{match.Hero.Name} in {loc} ({match.Hero.GetSkillValue(skillToSearch)} {skillToSearch.Name})");
                }

                return "I found some prospects:\n" + string.Join("\n", results);
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex, "Error in FindWandererBySkill");
                return "I apologize, my lord, I lost my notes.";
            }
        }

        private bool IsSquire()
        {
            return Hero.OneToOneConversationHero?.StringId == SquireSpawnBehavior.SquireStringId;
        }

        private void OpenManagementInquiry()
        {
            List<InquiryElement> elements = new List<InquiryElement>();
            foreach (var s in Settlement.All.Where(x => x.OwnerClan == Clan.PlayerClan && (x.IsTown || x.IsCastle)))
            {
                elements.Add(new InquiryElement(s, s.Name.ToString(), null));
            }

            if (elements.Count == 0)
            {
                InformationManager.ShowInquiry(new InquiryData(
                    "Settlement Ledgers",
                    "You do not currently hold title to any major fiefs, my lord.",
                    true,
                    false,
                    "Return",
                    "",
                    () => { },
                    () => { }
                ));
                return;
            }

            MBInformationManager.ShowMultiSelectionInquiry(new MultiSelectionInquiryData(
                "Settlement Ledgers",
                "Select a settlement to review.",
                elements,
                true,
                1,
                1,
                "Examine",
                "Cancel",
                (args) => {
                    var settlement = args.FirstOrDefault()?.Identifier as Settlement;
                    if (settlement != null)
                    {
                        _logger.LogInformation($"OpenManagementInquiry: Opening management for {settlement.Name}");
                        OpenManagementUI(settlement);
                    }
                },
                null
            ));
        }

        private void OpenManagementUI(Settlement settlement)
        {
             try 
             {
                 // Create and Push the Layer
                 var layer = new GauntletLayer("GauntletLayer", 100);
                 
                 // Use Safe VM (No Hacks)
                 var vm = new SquireTownManagementVM(settlement, layer);
                 
                 layer.LoadMovie("TownManagement", vm);
                 layer.InputRestrictions.SetInputRestrictions(true, InputUsageMask.All);
                 ScreenManager.TopScreen.AddLayer(layer);
             }
             catch(System.Exception ex)
             {
                 _logger.LogError(ex, "Error opening Ledger");
                 InformationManager.DisplayMessage(new InformationMessage("Failed to retrieve the ledger."));
             }
        }

        private void OpenSupplyInquiry()
        {
            List<InquiryElement> elements = new List<InquiryElement>();
            for (int i = 5; i <= 50; i += 5)
            {
                elements.Add(new InquiryElement(i, i.ToString(), null));
            }

            MBInformationManager.ShowMultiSelectionInquiry(new MultiSelectionInquiryData(
                "Supply Target",
                "Select the desired food stock level.",
                elements,
                true,
                1,
                1,
                "Set Level",
                "Cancel",
                (args) => {
                    var val = args.FirstOrDefault()?.Identifier;
                    if (val is int limit)
                    {
                        if (GlobalSettings.Instance != null)
                        {
                            GlobalSettings.Instance.FoodThreshold = limit;
                            string msg = $"Squire confirms: Supply threshold set to {limit}.";
                            InformationManager.DisplayMessage(new InformationMessage(msg));
                            _logger.LogInformation(msg);
                        }
                    }
                },
                null
            ));
        }
    }
}
