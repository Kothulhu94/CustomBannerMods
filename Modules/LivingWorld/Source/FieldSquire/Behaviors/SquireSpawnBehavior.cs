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
            var squire = Clan.PlayerClan?.Heroes.FirstOrDefault(h => h.StringId == SquireStringId);

            // Fallback: Search all alive heroes if not in clan (e.g. kicked out, or legacy save data where they were a wanderer)
            if (squire == null)
            {
                squire = Hero.AllAliveHeroes.FirstOrDefault(h => h.StringId == SquireStringId);
            }

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
                        var prop = typeof(MBObjectBase).GetProperty("StringId", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic);
                        if (prop != null && prop.CanWrite)
                        {
                            prop.SetValue(squire, SquireStringId);
                        }
                        else
                        {
                            var setMethod = prop?.GetSetMethod(true);
                            if (setMethod != null) setMethod.Invoke(squire, new object[] { SquireStringId });
                            else
                            {
                                var method = typeof(MBObjectBase).GetMethod("set_StringId", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic);
                                if (method != null) method.Invoke(squire, new object[] { SquireStringId });
                                else _logger.LogError("Failed to set StringId via all reflection methods!");
                            }
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
                // Logic removed: Let them remain captured or lead other parties.
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
                var prop = typeof(MBObjectBase).GetProperty("StringId", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic);
                if (prop != null && prop.CanWrite)
                {
                    prop.SetValue(squire, SquireStringId);
                    _logger.LogInformation($"Set StringId to: {squire.StringId}");
                }
                else
                {
                    var setMethod = prop?.GetSetMethod(true);
                    if (setMethod != null) 
                    {
                        setMethod.Invoke(squire, new object[] { SquireStringId });
                        _logger.LogInformation($"Set StringId via SetMethod to: {squire.StringId}");
                    }
                    else
                    {
                         var method = typeof(MBObjectBase).GetMethod("set_StringId", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic);
                         if (method != null) 
                         {
                             method.Invoke(squire, new object[] { SquireStringId });
                             _logger.LogInformation($"Set StringId via MethodInvoke to: {squire.StringId}");
                         }
                         else _logger.LogError("Failed to set StringId via all reflection methods!");
                    }
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
