using System;
using System.Reflection;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.CampaignBehaviors;
using TaleWorlds.CampaignSystem.MapEvents;

class Program
{
    static void Main()
    {
        Console.WriteLine("Probing TaleWorlds.CampaignSystem...");
        
        var assembly = typeof(Campaign).Assembly;

        // Check PrisonerReleaseCampaignBehavior
        var prisonerType = assembly.GetType("TaleWorlds.CampaignSystem.CampaignBehaviors.PrisonerReleaseCampaignBehavior");
        if (prisonerType == null)
        {
            Console.WriteLine("Type PrisonerReleaseCampaignBehavior NOT FOUND");
        }
        else
        {
            Console.WriteLine($"Type PrisonerReleaseCampaignBehavior FOUND. Scaning methods...");
            var methods = prisonerType.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            foreach (var m in methods)
            {
                if (m.Name.Contains("Hourly"))
                    Console.WriteLine($" - Found method: {m.Name}");
            }
        }

        // Check MapEvent
        var mapEventType = typeof(MapEvent);
        Console.WriteLine($"Type MapEvent FOUND. Scanning methods for 'Loot'...");
        var meMethods = mapEventType.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
        bool foundLoot = false;
        foreach (var m in meMethods)
        {
             if (m.Name.Contains("Loot"))
             {
                 Console.WriteLine($" - Found method: {m.Name}");
                 foundLoot = true;
             }
        }
        if (!foundLoot) Console.WriteLine(" - No methods containing 'Loot' found in MapEvent.");
    }
}
