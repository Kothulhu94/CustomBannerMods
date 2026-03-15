using System.Collections.Generic;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Localization;
using TaleWorlds.ObjectSystem;
using TaleWorlds.Library;
using Microsoft.Extensions.Logging;

namespace FieldSquire.Behaviors
{
    public class SquireSpawnBehavior : CampaignBehaviorBase
    {
        public const string SquireStringId = "field_squire";
        private readonly ILogger<SquireSpawnBehavior> _logger;
        private readonly GlobalSettings _settings;

        private static bool _hasEverSpawnedSquire = false;

        public SquireSpawnBehavior(ILogger<SquireSpawnBehavior> logger, GlobalSettings settings)
        {
            _logger = logger;
            _settings = settings;
        }

        public static Hero GetActiveSquire()
        {
            return Hero.AllAliveHeroes.FirstOrDefault(h => h.StringId == SquireStringId && h.Clan == Clan.PlayerClan);
        }

        public static void PromoteToSquire(Hero hero)
        {
            if (hero == null) return;
            
            // Set ID via reflection
            SetHeroStringId(hero, SquireStringId);
            
            // Ensure they are in player clan as a companion
            if (hero.Clan != Clan.PlayerClan)
            {
                AddCompanionAction.Apply(Clan.PlayerClan, hero);
            }
            
            // Set Name
            hero.SetName(new TextObject("Your Squire"), new TextObject("Your Squire"));
            
            InformationManager.DisplayMessage(new InformationMessage($"{hero.Name} is now your Squire."));
        }

        public static void DismissSquire(Hero hero)
        {
            if (hero == null || hero.StringId != SquireStringId) return;

            string oldName = hero.Name.ToString();
            // Reset ID to something unique so they are no longer "The Squire"
            string newId = $"squire_retired_{hero.Name.ToString().Replace(" ", "_")}_{hero.Id.InternalValue}";
            SetHeroStringId(hero, newId);
            
            // Revert Name
            hero.SetName(new TextObject("Former Squire"), new TextObject("Former Squire"));

            InformationManager.DisplayMessage(new InformationMessage($"{oldName} is no longer your Squire."));
        }

        private static void SetHeroStringId(Hero hero, string newId)
        {
            if (hero == null) return;
            var prop = typeof(MBObjectBase).GetProperty("StringId", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic);
            if (prop != null && prop.CanWrite)
            {
                prop.SetValue(hero, newId);
            }
            else
            {
                var setMethod = prop?.GetSetMethod(true);
                if (setMethod != null) setMethod.Invoke(hero, new object[] { newId });
                else
                {
                    var method = typeof(MBObjectBase).GetMethod("set_StringId", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic);
                    if (method != null) method.Invoke(hero, new object[] { newId });
                }
            }
        }

        public override void RegisterEvents()
        {
            CampaignEvents.OnSessionLaunchedEvent.AddNonSerializedListener(this, OnSessionLaunched);
            CampaignEvents.DailyTickEvent.AddNonSerializedListener(this, OnDailyTick);
        }

        public override void SyncData(IDataStore dataStore)
        {
            dataStore.SyncData("_hasEverSpawnedSquire", ref _hasEverSpawnedSquire);
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
            // 1. Find the Squire
            var squire = GetActiveSquire();

            // 2. Initial Setup or Recovery
            if (squire == null && !_hasEverSpawnedSquire)
            {
                 // Try to find by name fallback (for transition/legacy)
                 squire = Hero.AllAliveHeroes.FirstOrDefault(h => h.Name != null && h.Name.ToString().Contains("Squire") && h.Clan == Clan.PlayerClan);
                 if (squire != null && squire.StringId != SquireStringId)
                 {
                     SetHeroStringId(squire, SquireStringId);
                 }
            }

            if (squire == null && !_hasEverSpawnedSquire)
            {
                _logger.LogInformation($"{context}: First-time Squire setup required. Spawning.");
                squire = SpawnSquire();
                _hasEverSpawnedSquire = true;
            }
            else if (squire != null)
            {
                _hasEverSpawnedSquire = true;
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
