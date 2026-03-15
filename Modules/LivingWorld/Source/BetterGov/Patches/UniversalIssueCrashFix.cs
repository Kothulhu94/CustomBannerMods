using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Issues;

namespace BetterGov.Patches
{
    [HarmonyPatch]
    public static class UniversalIssueCrashFix
    {
        // Dynamic target finding: Scans SandBox.dll for all Issue types
        static IEnumerable<MethodBase> TargetMethods()
        {

            var assembliesToScan = new[] { "SandBox", "TaleWorlds.CampaignSystem" };

            foreach (var assemblyName in assembliesToScan)
            {
                var assembly = AppDomain.CurrentDomain.GetAssemblies()
                    .FirstOrDefault(a => a.GetName().Name == assemblyName);

                if (assembly == null)
                {
                    try { assembly = Assembly.Load(assemblyName); } catch { }
                }

                if (assembly == null) continue;

                var issueTypes = assembly.GetTypes()
                    .Where(t => t.IsClass && !t.IsAbstract && typeof(IssueBase).IsAssignableFrom(t));

                foreach (var type in issueTypes)
                {
                    var method = AccessTools.Method(type, "IssueStayAliveConditions");
                    if (method != null && method.DeclaringType == type)
                    {
                        yield return method;
                    }
                }
            }
        }


        static bool Prefix(IssueBase __instance, ref bool __result)
        {
            try
            {
                if (__instance == null)
                {
                    __result = false;
                    return false; // Skip original
                }


                if (__instance.IssueOwner == null || !__instance.IssueOwner.IsAlive)
                {

                    __result = false;
                    return false; // Skip original
                }


            }
            catch (Exception)
            {
                __result = false;
                return false;
            }

            return true;
        }


        static Exception Finalizer(Exception __exception, ref bool __result)
        {
            if (__exception != null)
            {

                __result = false;
                return null; // returning null swallows the exception
            }
            return null;
        }
    }
}
