using System;
using System.Linq;
using System.Reflection;
using System.IO;

namespace DllInspector
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string dllPath = @"C:\Users\RHoskins.evvcr\.gemini\antigravity\scratch\Steam\steamapps\common\Mount & Blade II Bannerlord\Modules\LivingWorld\bin\Win64_Shipping_Client\LivingWorld.dll";
                
                if (!File.Exists(dllPath))
                {
                    Console.WriteLine($"File missing: {dllPath}");
                    return;
                }

                var assembly = Assembly.LoadFrom(dllPath);
                Console.WriteLine($"Assembly: {assembly.FullName}");
                Console.WriteLine($"Location: {assembly.Location}");
                
                var types = assembly.GetTypes()
                                    .Where(t => t.Namespace != null && t.Namespace.StartsWith("FieldSquire"))
                                    .OrderBy(t => t.Name)
                                    .ToList();

                Console.WriteLine("\n--- Types in FieldSquire ---");
                foreach (var t in types)
                {
                    Console.WriteLine(t.FullName);
                    // Check for Postfix method params if it's a patch
                    var postfix = t.GetMethod("Postfix", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
                    if (postfix != null)
                    {
                         Console.WriteLine("   Postfix(" + string.Join(", ", postfix.GetParameters().Select(p => p.ParameterType.Name + " " + p.Name)) + ")");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
            }
        }
    }
}
