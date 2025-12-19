using System;
using System.Reflection;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.Core;
using TaleWorlds.Localization;
using TaleWorlds.ObjectSystem;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace Brigands.Warlords
{
    public class SyndicateFactionBehavior : CampaignBehaviorBase
    {
        private readonly ILogger<SyndicateFactionBehavior> _logger;
        private readonly GlobalSettings _settings;

        public SyndicateFactionBehavior(ILogger<SyndicateFactionBehavior> logger, GlobalSettings settings)
        {
            _logger = logger;
            _settings = settings;
        }

        public override void RegisterEvents()
        {
            CampaignEvents.OnGameLoadedEvent.AddNonSerializedListener(this, new Action<CampaignGameStarter>(this.OnGameLoaded));
            CampaignEvents.OnNewGameCreatedEvent.AddNonSerializedListener(this, new Action<CampaignGameStarter>(this.OnNewGameCreated));
            CampaignEvents.OnSessionLaunchedEvent.AddNonSerializedListener(this, new Action<CampaignGameStarter>(this.OnSessionLaunched));
            CampaignEvents.DailyTickEvent.AddNonSerializedListener(this, OnDailyTick);
        }

        private void OnDailyTick()
        {
            this._logger.LogInformation("Daily Tick: Verifying Syndicate War State...");
            this.EnsureSyndicateIntegrity();
            this.DeclareWars();
        }

        public override void SyncData(IDataStore dataStore)
        {
        }

        private void OnGameLoaded(CampaignGameStarter campaignGameStarter)
        {
            this.EnsureSyndicateIntegrity();
            this.DeclareWars();
        }

        private void OnNewGameCreated(CampaignGameStarter campaignGameStarter)
        {
        }

        private void OnSessionLaunched(CampaignGameStarter campaignGameStarter)
        {
            this.EnsureSyndicateIntegrity();
            this.DeclareWars();
        }

        private void DeclareWars()
        {
            try
            {
                Clan syndicate = Clan.All.Find(x => x.StringId == "TheSyndicate");
                if (syndicate != null)
                {
                    // 1. Declare war on ALL Kingdoms
                    foreach (Kingdom kingdom in Kingdom.All)
                    {
                         if (kingdom.IsEliminated) continue;
                         
                         if (!syndicate.IsAtWarWith(kingdom))
                         {
                              DeclareWarOnFaction(syndicate, kingdom);
                         }
                    }

                    // 2. Declare war on ALL Clans (Minor, Independent, Rebel, Bandit, Players)
                    foreach (Clan clan in Clan.All)
                    {
                         // Skip: Self, Eliminated, or belongs to a Kingdom (handled above to avoid spam)
                         if (clan == syndicate || clan.IsEliminated || clan.Kingdom != null) continue;

                         // WAR AGAINST THE WORLD: No exceptions.
                         if (!syndicate.IsAtWarWith(clan))
                         {
                              DeclareWarOnFaction(syndicate, clan);
                         }
                    }
                }

                // 4. Force Personal Hostility to ensure Red Nameplates
                if (syndicate != null && syndicate.Leader != null && Hero.MainHero != null)
                {
                    if (syndicate.Leader.GetRelation(Hero.MainHero) > -100)
                    {
                        ChangeRelationAction.ApplyRelationChangeBetweenHeroes(syndicate.Leader, Hero.MainHero, -100);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in DeclareWars");
            }
        }

        private void DeclareWarOnFaction(Clan syndicate, IFaction targetFaction)
        {
             // 1. Force negative relation
             if (syndicate.Leader != null && targetFaction.Leader != null)
             {
                 ChangeRelationAction.ApplyRelationChangeBetweenHeroes(syndicate.Leader, targetFaction.Leader, -100);
             }

             // 2. Declare War Robustly
             try
             {
                 if (!syndicate.IsAtWarWith(targetFaction))
                 {
                     if (targetFaction == Clan.PlayerClan)
                     {
                         _logger.LogInformation("!!! DECLARING WAR ON PLAYER CLAN !!!");
                     }
                     else if (_settings.DebugMode)
                     {
                         _logger.LogInformation($"Declaring war on {targetFaction.Name}...");
                     }
                     
                     DeclareWarAction.ApplyByDefault(syndicate, targetFaction);
                 }
             }
             catch (Exception ex)
             {
                  _logger.LogError(ex, $"Error declaring war on {targetFaction.Name}");
             }
        }

        private void EnsureSyndicateIntegrity()
        {
            try
            {
                Clan clan = Clan.All.Find(x => x.StringId == "TheSyndicate");
                if (clan == null)
                {
                    CheckAndCreateSyndicate(); // Fallback to creation
                }
                else
                {
                    // Check Logic: Is Leader Valid?
                    if (clan.Leader == null || !clan.Leader.IsAlive)
                    {
                         _logger.LogWarning("Syndicate Leader is dead or missing. Checking for succession...");
                         
                         // Succession Logic: Find best candidate (Active, Alive, Not Prisoner)
                         var successor = clan.Heroes.Where(h => h.IsAlive && h.HeroState == Hero.CharacterStates.Active && !h.IsPrisoner && h.IsWanderer).OrderByDescending(h => h.Level).FirstOrDefault();
                         
                         if (successor != null)
                         {
                             _logger.LogInformation($"Promoting {successor.Name} to Syndicate Leader!");
                             clan.SetLeader(successor);
                             successor.SetName(new TextObject("The Warlord"), new TextObject("The Warlord"));
                         }
                         else
                         {
                             _logger.LogWarning("No successors found. Appointing new Warlord from scratch.");
                             CreateLeader(clan);
                         }
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error ensuring Syndicate integrity.");
            }
        }

        private void CheckAndCreateSyndicate()
        {
            try
            {
                Clan oldClan = Clan.All.Find(x => x.StringId == "clan_syndicate");
                if (oldClan != null)
                {
                    _logger.LogWarning("WARNING: Found legacy 'clan_syndicate' from old save. This might cause conflicts.");
                }

                if (Clan.All.Find(x => x.StringId == "TheSyndicate") == null)
                {
                    _logger.LogInformation("Creating 'TheSyndicate' Clan...");
                    Clan clan = Clan.CreateClan("TheSyndicate");
                    TextObject name = new TextObject("The Syndicate", null);
                    TextObject informalName = new TextObject("The Syndicate", null);
                    
                    clan.ChangeClanName(name, informalName);

                    Banner banner = new Banner("11.116.116.1528.1528.764.764.1.0.0");
                    banner.ChangePrimaryColor(116); // Black
                    banner.ChangeIconColors(19);    // Silver/Gray
                    clan.Banner = banner;

                    CultureObject culture = MBObjectManager.Instance.GetObject<CultureObject>("empire");
                    if (culture == null)
                    {
                        culture = MBObjectManager.Instance.GetObject<CultureObject>("neutral_culture");
                    }
                    if (culture != null)
                    {
                        clan.Culture = culture;
                    }
                    else
                    {
                        _logger.LogWarning("WARNING: Could not find culture 'empire' or 'neutral_culture'.");
                    }
                    
                    try {
                        FieldInfo isMinorFactionField = typeof(Clan).GetField("<IsMinorFaction>k__BackingField", BindingFlags.Instance | BindingFlags.NonPublic);
                        if (isMinorFactionField != null)
                            isMinorFactionField.SetValue(clan, true);
                    } catch {}

                    try {
                         FieldInfo isBanditFactionField = typeof(Clan).GetField("<IsBanditFaction>k__BackingField", BindingFlags.Instance | BindingFlags.NonPublic);
                         if (isBanditFactionField != null)
                             // FIX: Must be TRUE to ensure persistent hostility (Red Nameplates) and correct War behavior.
                             // Setting this to false causes the faction to be treated as a Neutral Clan that constantly resets peace with Kingdoms.
                             isBanditFactionField.SetValue(clan, true);
                    } catch {}

                    clan.UpdateBannerColor(banner.GetPrimaryColor(), banner.GetFirstIconColor());

                    CreateLeader(clan);

                    _logger.LogInformation("'TheSyndicate' created successfully.");
                }
                else
                {
                    // Existing check moved to EnsureSyndicateIntegrity
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in CheckAndCreateSyndicate");
            }
        }

        private void CreateLeader(Clan clan)
        {
            try
            {
                _logger.LogInformation("Creating Syndicate Leader...");
                CultureObject culture = clan.Culture;
                CharacterObject template = culture.LordTemplates.FirstOrDefault();
                
                if (template == null)
                {
                     template = MBObjectManager.Instance.GetObject<CharacterObject>("spc_wanderer_empire_1");
                }

                if (template == null)
                {
                    // Fallback to any valid wanderer if specific one fails
                    template = MBObjectManager.Instance.GetObject<CharacterObject>("spc_wanderer_empire_2");
                }

                if (template != null)
                {
                    Hero leader = HeroCreator.CreateSpecialHero(template, null, clan, null, -1);
                    leader.SetName(new TextObject("The Warlord"), new TextObject("The Warlord"));
                    leader.ChangeState(Hero.CharacterStates.Active);
                    


                    clan.SetLeader(leader);
                    _logger.LogInformation($"Leader created: {leader.Name}");
                }
                else
                {
                    _logger.LogError("ERROR: Could not find a template for Syndicate Leader.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating leader");
            }
        }
    }
}
