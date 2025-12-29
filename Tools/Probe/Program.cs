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
                string libDir = System.IO.Path.GetFullPath(@"..\..\libs");
                
                Console.WriteLine("=== DEBUG: LOADED ASSEMBLIES ===");
                foreach(var d in System.IO.Directory.GetFiles(libDir, "*.dll"))
                {
                    try { 
                        var asm = Assembly.LoadFrom(d); 
                        // Console.WriteLine("Loaded: " + asm.GetName().Name);
                    } catch {}
                }
                
                var loaded = AppDomain.CurrentDomain.GetAssemblies().Select(a => a.GetName().Name).ToList();
                Console.WriteLine("TaleWorlds.TwoDimension Loaded: " + loaded.Contains("TaleWorlds.TwoDimension"));

                // 1. GauntletLayer signature
                Console.WriteLine("=== SCANNING GauntletUI ===");
                try {
                    var uiPath = System.IO.Path.Combine(libDir, "TaleWorlds.Engine.GauntletUI.dll");
                    var uiAsm = Assembly.LoadFrom(uiPath);
                    var layerType = uiAsm.GetTypes().FirstOrDefault(t => t.Name == "GauntletLayer");
                    if (layerType != null)
                    {
                         Console.WriteLine($"[CLASS] {layerType.FullName}");
                         foreach (var ctor in layerType.GetConstructors())
                             Console.WriteLine($"  CTOR: ({string.Join(", ", ctor.GetParameters().Select(p => p.ParameterType.Name + " " + p.Name))})");
                    }
                } catch (Exception ex) { Console.WriteLine("Error scanning GauntletUI: " + ex.Message); }

                // 2. TownManagementVM signature
                Console.WriteLine("\n=== SCANNING TownManagementVM ===");
                var vmFiles = System.IO.Directory.GetFiles(libDir, "*ViewModelCollection.dll");
                foreach(var f in vmFiles)
                {
                    try {
                        var asm = Assembly.LoadFrom(f);
                        var vmType = asm.GetTypes().FirstOrDefault(t => t.Name == "TownManagementVM");
                        if (vmType != null)
                        {
                            Console.WriteLine($"[FOUND in {System.IO.Path.GetFileName(f)}]");
                             foreach (var ctor in vmType.GetConstructors(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
                                 Console.WriteLine($"  CTOR: ({string.Join(", ", ctor.GetParameters().Select(p => p.ParameterType.Name + " " + p.Name))})");
                             // Fields
                             foreach(var field in vmType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public))
                                 Console.WriteLine($"  FIELD: {field.FieldType.Name} {field.Name}");
                             
                             foreach(var prop in vmType.GetProperties())
                                 Console.WriteLine($"  PROP: {prop.PropertyType.Name} {prop.Name}");
                        }
                    } catch (Exception ex) { 
                        // Console.WriteLine($"Error scanning {System.IO.Path.GetFileName(f)}: " + ex.Message); 
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"CRITICAL: {ex.GetType().Name}: {ex.Message}");
            }
        }
    }
}
