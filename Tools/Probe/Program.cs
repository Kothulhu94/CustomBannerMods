using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;

namespace Probe
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string libDir = System.IO.Path.GetFullPath(@"./libs");
                
                Console.WriteLine("=== PROBE: RecruitmentVM Analysis ===");
                
                // Load core libraries first to resolve dependencies
                var coreLibs = new[] { 
                    "TaleWorlds.Library.dll",
                    "TaleWorlds.Core.dll", 
                    "TaleWorlds.CampaignSystem.dll", 
                    "TaleWorlds.CampaignSystem.ViewModelCollection.dll",
                    "TaleWorlds.Localization.dll"
                };

                foreach(var lib in coreLibs)
                {
                    try { Assembly.LoadFrom(System.IO.Path.Combine(libDir, lib)); } catch {}
                }

                var vmCollectionPath = System.IO.Path.Combine(libDir, "TaleWorlds.CampaignSystem.ViewModelCollection.dll");
                var vmAsm = Assembly.LoadFrom(vmCollectionPath);
                
                var vmType = vmAsm.GetTypes().FirstOrDefault(t => t.Name == "RecruitmentVM");
                
                if (vmType == null)
                {
                    Console.WriteLine("Could not find RecruitmentVM!");
                    return;
                }
                
                Console.WriteLine($"[CLASS] {vmType.FullName}");
                
                Console.WriteLine("\n--- PROPERTIES (Looking for Lists) ---");
                foreach(var prop in vmType.GetProperties(BindingFlags.Public | BindingFlags.Instance))
                {
                    Console.WriteLine($"  PROP: {prop.PropertyType.Name} {prop.Name}");
                }
                
                Console.WriteLine("\n--- FIELDS (Private backing fields) ---");
                foreach(var field in vmType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
                {
                    Console.WriteLine($"  FIELD: {field.FieldType.Name} {field.Name}");
                }

                Console.WriteLine("\n--- METHODS (Void methods regarding volunteers) ---");
                foreach(var method in vmType.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
                {
                    if (method.Name.Contains("Recruit") || method.Name.Contains("Volunteer") || method.Name.Contains("Refresh") || method.Name.Contains("On"))
                        Console.WriteLine($"  METHOD: {method.Name}");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"CRITICAL ERROR: {ex}");
            }
        }
    }
}
