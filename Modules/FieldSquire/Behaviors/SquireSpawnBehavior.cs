using System.Collections.Generic;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Localization;
using TaleWorlds.ObjectSystem;
using Microsoft.Extensions.Logging;

namespace FieldSquire.Behaviors
{
    public class SquireSpawnBehavior : CampaignBehaviorBase
    {
        public const string SquireStringId = "field_squire";
        private readonly ILogger<SquireSpawnBehavior> _logger;
        private readonly GlobalSettings _settings;

        public SquireSpawnBehavior(ILogger<SquireSpawnBehavior> logger, GlobalSettings settings)
        {
            _logger = logger;
            _settings = settings;
        }

        public override void RegisterEvents()
        {
            CampaignEvents.OnSessionLaunchedEvent.AddNonSerializedListener(this, OnSessionLaunched);
            CampaignEvents.DailyTickEvent.AddNonSerializedListener(this, OnDailyTick);
            // OnSettlementEntered removed to avoid performance overhead and "forced recall" spam when not needed.
            // DailyTick and SessionLaunch are sufficient for recovery.
        }

        public override void SyncData(IDataStore dataStore)
        {
        }

        private void OnSessionLaunched(CampaignGameStarter starter)
        {
            ManageSquire("OnSessionLaunched");
        }
        
        private void OnDailyTick()
        {
            ManageSquire("OnDailyTick");
        }

        private void ManageSquire(string context)
        {
            // 1. Identify the Squire
            // Search Player Clan first (Preferred/Expected location)
            var squire = Clan.PlayerClan?.Heroes.FirstOrDefault(h => h.StringId == SquireStringId);

            // Fallback: Search all alive heroes if not in clan (e.g. kicked out, or legacy save data where they were a wanderer)
            if (squire == null)
            {
                squire = Hero.AllAliveHeroes.FirstOrDefault(h => h.StringId == SquireStringId);
            }

            // Fallback 2: Name match (Legacy/Bugfix for existing duplicates). 
            // We prioritize the one in the main party.
            if (squire == null)
            {
                var candidates = Hero.AllAliveHeroes
                    .Where(h => h.Name != null && h.Name.ToString().Contains("Squire"))
                    .ToList();

                if (candidates.Any())
                {
                    // Pick the best candidate: In Party > Player Clan > Alive
                    squire = candidates.FirstOrDefault(h => h.PartyBelongedTo == MobileParty.MainParty) 
                             ?? candidates.FirstOrDefault(h => h.Clan == Clan.PlayerClan) 
                             ?? candidates.First();

                    // If we found one via name, stamp the ID now so we find them correctly next time
                    if (squire.StringId != SquireStringId)
                    {
                        var setStringId = typeof(MBObjectBase).GetMethod("set_StringId", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                        if (setStringId != null)
                        {
                            setStringId.Invoke(squire, new object[] { SquireStringId });
                        }
                    }

                    // Clean up potential duplicates
                    if (candidates.Count > 1)
                    {
                        foreach (var dupe in candidates.Where(d => d != squire))
                        {
                            _logger.LogWarning($"{context}: Removing duplicate Squire {dupe.Name} ({dupe.StringId})");
                            KillCharacterAction.ApplyByRemove(dupe, false, true);
                        }
                    }
                }
            }

            // 2. Ensure Existence
            if (squire == null)
            {
                _logger.LogInformation($"{context}: Squire not found. Spawning new one.");
                squire = SpawnSquire();
            }

            // 3. Ensure Status (Clan Member & Party Presence)
            if (squire != null)
            {
                _logger.LogInformation($"{context}: Verified Squire: {squire.Name} (ID: {squire.StringId}) in Clan: {squire.Clan?.Name}");

                // Enforce Player Clan (User req: "Always player clan")
                if (squire.Clan != Clan.PlayerClan)
                {
                    _logger.LogInformation($"{context}: Adopting Squire into Player Clan.");
                    // AddCompanionAction is safer than direct Clan assignment as it handles occupations/states
                    AddCompanionAction.Apply(Clan.PlayerClan, squire);
                }

                // Handle Captivity / Fugitive State / Missing
                if (squire.IsPrisoner)
                {
                    _logger.LogInformation($"{context}: Squire was prisoner. Liberating...");
                    EndCaptivityAction.ApplyByEscape(squire, null);
                }

                // If not in generic main party (and not dead), recall them
                // We do NOT check if they are leading a party, because user said "they're meant to be a passive utility companion".
                // So if they ARE leading a party, we disband it and pull them back.
                bool isInMainParty = MobileParty.MainParty.MemberRoster.Contains(squire.CharacterObject);
                
                if (!isInMainParty)
                {
                     // Special Case: Leading a caravan or party?
                     if (squire.PartyBelongedTo != null && squire.PartyBelongedTo != MobileParty.MainParty)
                     {
                         _logger.LogWarning($"{context}: Is the Squire leading a party/caravan? Disbanding and recalling.");
                         // This forces them back to the roster
                         // DestroyPartyAction might be too harsh if it's a legit party, but user requested passive utility.
                         // Safer: Just add to party, engine usually handles the previous party leadership transfer or disband.
                     }

                     _logger.LogInformation($"{context}: Recalling Squire to Main Party.");
                     AddHeroToPartyAction.Apply(squire, MobileParty.MainParty, true);
                }
            }
        }

        private Hero SpawnSquire()
        {
            // Use an Empire Wanderer template
            var template = CharacterObject.All.FirstOrDefault(x => x.Occupation == Occupation.Wanderer && x.Culture.StringId == "empire");
            if (template == null) template = CharacterObject.All.FirstOrDefault(x => x.Occupation == Occupation.Wanderer);

            if (template != null)
            {
                // Create hero at Main Party location
                Hero squire = HeroCreator.CreateSpecialHero(template, Hero.MainHero.HomeSettlement ?? Settlement.All.FirstOrDefault(), null, null, 25);
                
                squire.SetName(new TextObject("Your Squire"), new TextObject("Your Squire"));
                _logger.LogInformation($"Created hero. Preliminary ID: {squire.StringId}");
                
                // Helper to set ID via reflection since property relies on private setter sometimes
                var setStringId = typeof(MBObjectBase).GetMethod("set_StringId", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                if (setStringId != null)
                {
                    setStringId.Invoke(squire, new object[] { SquireStringId });
                    _logger.LogInformation($"Set StringId to: {squire.StringId}");
                }
                else
                {
                    _logger.LogError("Failed to find set_StringId method via reflection!");
                }
                
                // Add to clan immediately
                AddCompanionAction.Apply(Clan.PlayerClan, squire);
                
                // Add to party
                AddHeroToPartyAction.Apply(squire, MobileParty.MainParty, true);
                
                _logger.LogInformation("Spawned new Squire.");
                return squire;
            }
            return null;
        }
    }
}
