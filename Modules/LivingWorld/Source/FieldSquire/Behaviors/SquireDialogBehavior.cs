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
using TaleWorlds.CampaignSystem.Conversation;
using FieldSquire.ViewModels;
using Microsoft.Extensions.Logging;

namespace FieldSquire.Behaviors
{
    public class SquireDialogBehavior : CampaignBehaviorBase
    {
        private readonly ILogger<SquireDialogBehavior> _logger;
        private readonly GlobalSettings _settings;
        private List<Hero> _wandererCache;
        private Hero _talkingSquire;
        private bool _returningFromVM;

        public SquireDialogBehavior(ILogger<SquireDialogBehavior> logger, GlobalSettings settings)
        {
            _logger = logger;
            _settings = settings;
            _wandererCache = new List<Hero>();
        }

        private System.Action _queuedAction;

        private void OnTick(float dt)
        {
            if (_queuedAction != null)
            {
                var action = _queuedAction;
                _queuedAction = null;
                action.Invoke();
            }
        }

        public override void RegisterEvents()
        {
            CampaignEvents.OnSessionLaunchedEvent.AddNonSerializedListener(this, OnSessionLaunched);
            CampaignEvents.DailyTickEvent.AddNonSerializedListener(this, OnDailyTick);
            CampaignEvents.TickEvent.AddNonSerializedListener(this, OnTick);
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
            string[] entryPoints = { "hero_main_options", "companion_talk" };
            foreach (var entry in entryPoints)
            {
                starter.AddPlayerLine("squire_talk_manage_" + entry, entry, "squire_manage_reply_" + entry, "Let me review the ledgers.", IsSquire, null);
                starter.AddDialogLine("squire_manage_reply_" + entry, "squire_manage_reply_" + entry, entry, "Certainly. Which settlement reviews do you strictly need?", null, OpenManagementInquiry);

                starter.AddPlayerLine("squire_talk_supply_" + entry, entry, "squire_supply_reply_" + entry, "I need to set our supply list.", IsSquire, null);
                starter.AddDialogLine("squire_supply_reply_" + entry, "squire_supply_reply_" + entry, entry, "I shall arrange the manifest. What is the target stock level?", null, OpenSupplyInquiry);

                starter.AddPlayerLine("squire_talk_governor_" + entry, entry, "squire_governor_reply_" + entry, "I'd like to govern a settlement.", IsSquire, null);
                starter.AddDialogLine("squire_governor_reply_" + entry, "squire_governor_reply_" + entry, entry, "A wise choice, my lord. Which settlement shall receive your personal oversight?", null, OpenGovernorSelection);

                // Search (Entry-Specific Flow)
                starter.AddPlayerLine("squire_talk_search_" + entry, entry, "squire_search_start_" + entry, "Anyone worth bringing along nearby?", IsSquire, null);
                starter.AddDialogLine("squire_search_reply_" + entry, "squire_search_start_" + entry, "squire_search_options_" + entry, "It depends on the job. Who do you need?", null, null);

                // Search Options
                starter.AddPlayerLine("squire_search_healer_" + entry, "squire_search_options_" + entry, "squire_search_result_" + entry, "Find me a Healer.", null, () => SearchForWanderer(DefaultSkills.Medicine));
                starter.AddPlayerLine("squire_search_scout_" + entry, "squire_search_options_" + entry, "squire_search_result_" + entry, "We need a Scout.", null, () => SearchForWanderer(DefaultSkills.Scouting));
                starter.AddPlayerLine("squire_search_engineer_" + entry, "squire_search_options_" + entry, "squire_search_result_" + entry, "We need an Engineer.", null, () => SearchForWanderer(DefaultSkills.Engineering));
                starter.AddPlayerLine("squire_search_steward_" + entry, "squire_search_options_" + entry, "squire_search_result_" + entry, "Find me a Quartermaster.", null, () => SearchForWanderer(DefaultSkills.Steward));
                starter.AddPlayerLine("squire_search_warrior_" + entry, "squire_search_options_" + entry, "squire_search_result_" + entry, "We need a Warrior.", null, SearchForWarrior);
                starter.AddPlayerLine("squire_search_trader_" + entry, "squire_search_options_" + entry, "squire_search_result_" + entry, "Find me a Trader.", null, () => SearchForWanderer(DefaultSkills.Trade));
                starter.AddPlayerLine("squire_search_tactician_" + entry, "squire_search_options_" + entry, "squire_search_result_" + entry, "We need a Tactician.", null, () => SearchForWanderer(DefaultSkills.Tactics));
                starter.AddPlayerLine("squire_search_rogue_" + entry, "squire_search_options_" + entry, "squire_search_result_" + entry, "Find me a Rogue.", null, () => SearchForWanderer(DefaultSkills.Roguery));
                starter.AddPlayerLine("squire_search_smith_" + entry, "squire_search_options_" + entry, "squire_search_result_" + entry, "We need a Smith.", null, () => SearchForWanderer(DefaultSkills.Crafting));
                
                // Return to Main Options instead of Close
                starter.AddPlayerLine("squire_search_cancel_" + entry, "squire_search_options_" + entry, "squire_search_cancel_response_" + entry, "Never mind.", null, null);
                starter.AddDialogLine("squire_return_msg_" + entry, "squire_search_cancel_response_" + entry, entry, "Is there anything else requiring my attention?", null, null);

                // Result (Loops back to options)
                starter.AddDialogLine("squire_search_result_reply_" + entry, "squire_search_result_" + entry, "squire_search_options_" + entry, "{SQUIRE_SEARCH_RESULT}", null, null);
            }
            
            // Return from VM Logic
            starter.AddDialogLine("squire_return_vm_start", "start", "hero_main_options", "Is there anything else requiring my attention?", () => _returningFromVM && Hero.OneToOneConversationHero == _talkingSquire, () => _returningFromVM = false);

            // Promotion & Firing
            starter.AddPlayerLine("squire_promote_start", "companion_talk", "squire_promote_response", "I have need of a Squire. Would you take up the mantle?", IsPromotionAvailable, null);
            starter.AddDialogLine("squire_promote_confirm", "squire_promote_response", "hero_main_options", "It would be an honor, my lord. I shall handle the ledgers and logistics from now on.", null, () => SquireSpawnBehavior.PromoteToSquire(Hero.OneToOneConversationHero));

            starter.AddPlayerLine("squire_dismiss_start", "hero_main_options", "squire_dismiss_response", "I no longer require your services as my Squire. You're relieved.", IsSquire, null);
            starter.AddDialogLine("squire_dismiss_confirm", "squire_dismiss_response", "close_window", "As you wish, my lord. I shall return to my previous duties.", null, () => SquireSpawnBehavior.DismissSquire(Hero.OneToOneConversationHero));
        }

        private bool IsPromotionAvailable()
        {
            var hero = Hero.OneToOneConversationHero;
            if (hero == null || hero.Clan != Clan.PlayerClan || hero == Hero.MainHero) return false;
            
            // Cannot promote if there is already an active squire
            if (SquireSpawnBehavior.GetActiveSquire() != null) return false;
            
            return true;
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
            var hero = Hero.OneToOneConversationHero;
            if (hero == null) return false;

            // Use the shared helper from SpawnBehavior
            var activeSquire = SquireSpawnBehavior.GetActiveSquire();
            if (activeSquire != null && activeSquire == hero) return true;

            // Fallback for name check (handles cases where ID might have drifted but name is set)
            bool matchName = hero.Name != null && hero.Name.ToString().Contains("Squire") && hero.Clan == Clan.PlayerClan;
            
            if (matchName)
            {
                _logger.LogInformation($"IsSquire: Matched {hero.Name} via name fallback. Correcting ID.");
                SquireSpawnBehavior.PromoteToSquire(hero); // Re-stamp ID if needed
                return true;
            }
            
            return false;
        }

        private void OpenManagementInquiry()
        {
            _talkingSquire = Hero.OneToOneConversationHero;
            
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
             System.Reflection.FieldInfo currentSettlementField = null;
             object oldSettlement = null;

             try 
             {
                 if (MobileParty.MainParty != null)
                 {
                     currentSettlementField = typeof(MobileParty).GetField("_currentSettlement", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                     if (currentSettlementField != null)
                     {
                         oldSettlement = currentSettlementField.GetValue(MobileParty.MainParty);
                         currentSettlementField.SetValue(MobileParty.MainParty, settlement);
                     }
                 }

                 // Create and Push the Layer
                 var layer = new GauntletLayer("GauntletLayer", 100);
                 
                 // Construct VM (Mock is active here, satisfying base constructor)
                 var vm = new SquireTownManagementVM(settlement, layer, () => 
                 {
                     // Queue the return logic to run on the next Tick to avoid UI/State conflicts
                     _queuedAction = AttemptReturnToDialogue;
                 });
                 
                 // RESTORE IMMEDIATELY
                 if (currentSettlementField != null && MobileParty.MainParty != null)
                 {
                     currentSettlementField.SetValue(MobileParty.MainParty, oldSettlement);
                 }

                 layer.LoadMovie("TownManagement", vm);
                 layer.InputRestrictions.SetInputRestrictions(true, InputUsageMask.All);
                 ScreenManager.TopScreen.AddLayer(layer);
             }
             catch(System.Exception ex)
             {
                 _logger.LogError(ex, "Error opening Ledger");
                 InformationManager.DisplayMessage(new InformationMessage(new TaleWorlds.Localization.TextObject("{=lw_failedtoretriev}Failed to retrieve the ledger.").ToString()));
                 
                 // Emergency Restore
                 if (currentSettlementField != null && MobileParty.MainParty != null)
                 {
                     try { currentSettlementField.SetValue(MobileParty.MainParty, oldSettlement); } catch { }
                 }
             }
        }

        private void AttemptReturnToDialogue()
        {
             try
             {
                 // Return to conversation
                 if (_talkingSquire != null)
                 {
                     if (!(GameStateManager.Current.ActiveState is TaleWorlds.CampaignSystem.GameState.MapState))
                     {
                         InformationManager.DisplayMessage(new InformationMessage(new TaleWorlds.Localization.TextObject("{=lw_ledgerclosed}Ledger closed.").ToString()));
                         return; 
                     }

                     _returningFromVM = true;
                     var playerParty = PartyBase.MainParty;
                     
                     var squireParty = _talkingSquire.PartyBelongedTo?.Party ?? _talkingSquire.CurrentSettlement?.Party;
                     var effectiveSquireParty = (squireParty?.MobileParty != null) ? squireParty : playerParty;

                     // Sanity check
                     if (playerParty != null)
                     {
                         ConversationCharacterData playerData = new ConversationCharacterData(CharacterObject.PlayerCharacter, playerParty);
                         ConversationCharacterData squireData = new ConversationCharacterData(_talkingSquire.CharacterObject, effectiveSquireParty);
                         CampaignMapConversation.OpenConversation(playerData, squireData);
                     }
                 }
             }
             catch (System.Exception ex)
             {
                 // Last resort safety net
                 InformationManager.DisplayMessage(new InformationMessage(new TaleWorlds.Localization.TextObject("{=lw_squireconnectio}Squire connection lost.").ToString()));
                 _logger?.LogError(ex, "Error reopening conversation with squire.");
             }
        }

        private void OpenGovernorSelection()
        {
            _talkingSquire = Hero.OneToOneConversationHero;
            
            List<InquiryElement> elements = new List<InquiryElement>();
            foreach (var s in Settlement.All.Where(x => x.OwnerClan == Clan.PlayerClan && (x.IsTown || x.IsCastle)))
            {
                string suffix = (s.Town?.Governor == Hero.MainHero) ? " (Current)" : "";
                elements.Add(new InquiryElement(s, s.Name.ToString() + suffix, null));
            }

            if (elements.Count == 0)
            {
                InformationManager.ShowInquiry(new InquiryData(
                    "Governance",
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
                "Select Fief to Govern",
                "Select a settlement to personally oversee as governor.",
                elements,
                true,
                1,
                1,
                "Govern",
                "Cancel",
                (args) => {
                    var settlement = args.FirstOrDefault()?.Identifier as Settlement;
                    if (settlement != null)
                    {
                        _logger.LogInformation($"OpenGovernorSelection: Setting player as governor for {settlement.Name}");
                        SetPlayerAsGovernor(settlement);
                    }
                },
                null
            ));
        }

        private void SetPlayerAsGovernor(Settlement settlement)
        {
            try
            {
                if (settlement.Town == null) return;

                if (settlement.Town.Governor == Hero.MainHero)
                {
                    InformationManager.DisplayMessage(new InformationMessage(new TaleWorlds.Localization.TextObject($"{{=lw_youarealreadygo}}You are already governing {settlement.Name}.").ToString()));
                    return;
                }

                // Use direct assignment to avoid ChangeGovernorAction's hero-teleportation/party-removal logic
                settlement.Town.Governor = Hero.MainHero;
                
                string msg = $"You are now personally governing {settlement.Name}.";
                InformationManager.DisplayMessage(new InformationMessage(msg));
                _logger.LogInformation(msg);
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex, $"Error setting player as governor of {settlement.Name}");
                InformationManager.DisplayMessage(new InformationMessage(new TaleWorlds.Localization.TextObject("{=lw_iapologizeicoul}I apologize, I could not update the records.").ToString()));
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
