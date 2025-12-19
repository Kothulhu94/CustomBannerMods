using System;
using System.Reflection;
using TaleWorlds.CampaignSystem.Settlements;

// Mock classes to simulate structure if libs not available contextually (but we have libs)
// Actually, I can just reflect on the DLLs.
// I will write a script that loads the DLL and prints fields of Town/Fief.

public class Probe
{
    public static void Main()
    {
        try 
        {
            var asm = Assembly.LoadFrom("libs/TaleWorlds.CampaignSystem.dll");
            var townType = asm.GetType("TaleWorlds.CampaignSystem.Settlements.Town");
            var fiefType = asm.GetType("TaleWorlds.CampaignSystem.Settlements.Fief");

            Console.WriteLine($"Town BaseType: {townType?.BaseType?.Name}");
            Console.WriteLine($"Fief BaseType: {fiefType?.BaseType?.Name}");

            if (fiefType != null)
            {
                var field = fiefType.GetField("_militia", BindingFlags.NonPublic | BindingFlags.Instance);
                Console.WriteLine($"Fief._militia exists: {field != null}");

                if (field == null)
                {
                    // Check for auto-property backing field
                    var autoField = fiefType.GetField("<Militia>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance);
                    Console.WriteLine($"Fief.<Militia>k__BackingField exists: {autoField != null}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}
