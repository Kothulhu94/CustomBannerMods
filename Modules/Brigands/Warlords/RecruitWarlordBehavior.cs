using System;
using System.Collections.Generic;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.Conversation;
using TaleWorlds.CampaignSystem.MapEvents;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.Localization;
using TaleWorlds.Library;
using TaleWorlds.Core;
using Microsoft.Extensions.Logging;

namespace Brigands.Warlords
{
    public class RecruitWarlordBehavior : CampaignBehaviorBase
    {
        private readonly ILogger<RecruitWarlordBehavior> _logger;
        private readonly GlobalSettings _settings;
        private HashSet<Hero> _recentlyKilledWarlords = new HashSet<Hero>();

        public RecruitWarlordBehavior(ILogger<RecruitWarlordBehavior> logger, GlobalSettings settings)
        {
            _logger = logger;
            _settings = settings;
        }

        public override void RegisterEvents()
        {
            CampaignEvents.OnSessionLaunchedEvent.AddNonSerializedListener(this, new Action<CampaignGameStarter>(this.OnSessionLaunched));
            CampaignEvents.MapEventEnded.AddNonSerializedListener(this, OnMapEventEnded);
            CampaignEvents.HeroKilledEvent.AddNonSerializedListener(this, OnHeroKilled);
            CampaignEvents.MapEventStarted.AddNonSerializedListener(this, OnMapEventStarted);
        }

        public override void SyncData(IDataStore dataStore)
        {
        }

        private void OnMapEventStarted(MapEvent mapEvent, PartyBase attackerParty, PartyBase defenderParty)
        {
            try 
            {
                if (mapEvent.IsPlayerMapEvent)
                {
                    _recentlyKilledWarlords.Clear();
                }
            }
            catch {}
        }

        private void OnHeroKilled(Hero victim, Hero killer, KillCharacterAction.KillCharacterActionDetail detail, bool showNotification)
        {
            try
            {
                if (victim != null && victim.Clan?.StringId == "TheSyndicate")
                {
                    _recentlyKilledWarlords.Add(victim);
                    if (_settings.DebugMode)
                         _logger.LogInformation($"Warlord {victim.Name} was killed in battle. flagged as Dead.");
                }
            }
            catch {}
        }

        private void OnMapEventEnded(MapEvent mapEvent)
        {
            // Logic moved to Warlords/Patches/WarlordBattlePatch.cs
        }

        private void OnSessionLaunched(CampaignGameStarter starter)
        {
            try
            {
                _logger.LogInformation("RecruitWarlordBehavior.OnSessionLaunched");
                starter.AddPlayerLine("warlord_recruit_start", "hero_main_options", "warlord_recruit_response", "You fought well. Swear loyalty to me, and you live.", new ConversationSentence.OnConditionDelegate(this.recruit_warlord_condition), null, 100, null, null);
                starter.AddDialogLine("warlord_recruit_response", "warlord_recruit_response", "close_window", "Better a servant than a corpse. I accept.", null, new ConversationSentence.OnConsequenceDelegate(this.recruit_warlord_consequence), 100, null);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in RecruitWarlordBehavior.OnSessionLaunched");
            }
        }

        private bool recruit_warlord_condition()
        {
            return Hero.OneToOneConversationHero != null &&
                   Hero.OneToOneConversationHero.Clan != null &&
                   Hero.OneToOneConversationHero.Clan.StringId == "TheSyndicate" &&
                   Hero.OneToOneConversationHero.IsPrisoner &&
                   Hero.OneToOneConversationHero.PartyBelongedToAsPrisoner == MobileParty.MainParty.Party;
        }

        private void recruit_warlord_consequence()
        {
            Hero hero = Hero.OneToOneConversationHero;
            
            try 
            {
                EndCaptivityAction.ApplyByReleasedByChoice(hero, Hero.MainHero);

                AddCompanionAction.Apply(Clan.PlayerClan, hero);
                
                AddHeroToPartyAction.Apply(hero, MobileParty.MainParty);
                
                InformationManager.DisplayMessage(new InformationMessage(hero.Name.ToString() + " is now your Companion.", Colors.Green));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex,($"Error recruiting Warlord {hero.Name}"));
            }
        }
    }
}

