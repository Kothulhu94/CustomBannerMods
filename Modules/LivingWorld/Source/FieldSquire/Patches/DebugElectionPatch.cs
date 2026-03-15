using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Election;
using TaleWorlds.Core;
using TaleWorlds.Library;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using TaleWorlds.CampaignSystem.GameComponents;
using TaleWorlds.CampaignSystem.Settlements;

namespace FieldSquire.Patches
{
    public static class DebugElectionPatch
    {
        private static bool _patchesApplied = false;

        public static void Apply(Harmony harmony)
        {
            if (_patchesApplied) return;

            // Manual Application to survive the 7x-SubModule-assembly-slam
            
            // 1. Kingdom.AddDecision
            var originalAddDec = AccessTools.Method(typeof(Kingdom), "AddDecision");
            var prefixAddDec = AccessTools.Method(typeof(DebugAddDecisionPatch), nameof(DebugAddDecisionPatch.Prefix));
            if (originalAddDec != null) harmony.Patch(originalAddDec, prefix: new HarmonyMethod(prefixAddDec));

            // 2. Election Merit Fix
            var meritFixMethods = ElectionMeritFixPatch.TargetMethods();
            var meritFixPostfix = AccessTools.Method(typeof(ElectionMeritFixPatch), nameof(ElectionMeritFixPatch.Postfix));
            foreach (var m in meritFixMethods) harmony.Patch(m, postfix: new HarmonyMethod(meritFixPostfix));

            // 3. Election Candidate Fix
            var candFixMethods = ElectionCandidateFixPatch.TargetMethods();
            var candFixPostfix = AccessTools.Method(typeof(ElectionCandidateFixPatch), nameof(ElectionCandidateFixPatch.Postfix));
            foreach (var m in candFixMethods) harmony.Patch(m, postfix: new HarmonyMethod(candFixPostfix));

            // 4. Siege Crash Patch
            var originalGeog = AccessTools.Method(typeof(DefaultSettlementValueModel), "GeographicalAdvantageForFaction");
            var prefixGeog = AccessTools.Method(typeof(SiegeCrashPatch), nameof(SiegeCrashPatch.Prefix));
            if (originalGeog != null) harmony.Patch(originalGeog, prefix: new HarmonyMethod(prefixGeog));

            // 5. Determine Support Safety
            var originalSupport = AccessTools.Method(typeof(SettlementClaimantDecision), "DetermineSupport");
            var prefixSupport = AccessTools.Method(typeof(DetermineSupportSafetyPatch), nameof(DetermineSupportSafetyPatch.Prefix));
            if (originalSupport != null) harmony.Patch(originalSupport, prefix: new HarmonyMethod(prefixSupport));

            _patchesApplied = true;
            FieldSquireSubModule.Logger?.Information("FieldSquire: Manual Election fixes applied (Protected from double-patching).");
        }
    }

    public static class DebugAddDecisionPatch
    {
        private static string LogPath => Path.Combine(BasePath.Name, "Modules", "LivingWorld", "ELECTION_DEBUG_ROOT.log");

        public static void Prefix(Kingdom __instance, KingdomDecision kingdomDecision)
        {
            try
            {
                if (kingdomDecision is SettlementClaimantDecision scd)
                {
                    string dir = Path.GetDirectoryName(LogPath);
                    if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
                    File.AppendAllText(LogPath, $"[{DateTime.Now}] Intercepted AddDecision for Settlement: {scd.Settlement?.Name?.ToString() ?? "NULL"}\n");
                }
            }
            catch (Exception) { }
        }
    }

    public static class ElectionMeritFixPatch
    {
        private static string LogPath => Path.Combine(BasePath.Name, "Modules", "LivingWorld", "ELECTION_FIX_MERIT.log");

        public static IEnumerable<MethodBase> TargetMethods()
        {
             var method = AccessTools.Method(typeof(SettlementClaimantDecision), "CalculateMeritOfOutcome");
             if (method != null) yield return method;

             method = AccessTools.Method(typeof(KingdomDecision), "CalculateMeritOfOutcome");
             if (method != null) yield return method;
        }

        public static void Postfix(KingdomDecision __instance, DecisionOutcome candidateOutcome, ref float __result)
        {
             if (__instance is SettlementClaimantDecision && candidateOutcome != null)
             {
                 var clanProp = candidateOutcome.GetType().GetProperty("Clan", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                 if (clanProp != null)
                 {
                     Clan clan = clanProp.GetValue(candidateOutcome) as Clan;
                     if (clan != null && clan.Leader != null)
                     {
                         if (clan.Leader.IsWanderer && clan != Clan.PlayerClan)
                         {
                             __result = -1000000f;
                             try { 
                                 string dir = Path.GetDirectoryName(LogPath);
                                 if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
                                 File.AppendAllText(LogPath, $"[MeritFix] NUKED score for Wanderer {clan.Leader.Name} in {(__instance as SettlementClaimantDecision).Settlement?.Name?.ToString()}\n"); 
                             } catch {}
                         }
                     }
                 }
             }
        }
    }

    public static class ElectionCandidateFixPatch
    {
        private static string LogPath => Path.Combine(BasePath.Name, "Modules", "LivingWorld", "ELECTION_FIX_CALC.log");

        public static IEnumerable<MethodBase> TargetMethods()
        {
            string[] possibleNames = { "DetermineInitialCandidates", "CalculateDecisionOutcomes" };
            Type[] types = { typeof(SettlementClaimantDecision), typeof(KingdomDecision) };

            foreach (var type in types)
            {
                foreach (var name in possibleNames)
                {
                    var method = AccessTools.Method(type, name);
                    if (method != null && !method.IsAbstract)
                    {
                        yield return method;
                    }
                }
            }
        }

        public static void Postfix(KingdomDecision __instance, ref IEnumerable<DecisionOutcome> __result)
        {
             if (!(__instance is SettlementClaimantDecision decision)) return;

             try
             {
                 if (__result == null) return;

                 var list = __result.ToList();
                 bool modified = false;

                 for (int i = list.Count - 1; i >= 0; i--)
                 {
                     var outcome = list[i];
                     if (outcome == null) continue;

                     var clanProp = outcome.GetType().GetProperty("Clan", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.FlattenHierarchy);
                     
                     if (clanProp == null)
                     {
                        var clanField = outcome.GetType().GetField("Clan", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.FlattenHierarchy);
                        if (clanField != null)
                        {
                            Clan clan = clanField.GetValue(outcome) as Clan;
                            if (CheckAndRemove(clan, decision, outcome))
                            {
                                list.RemoveAt(i);
                                modified = true;
                            }
                        }
                     }
                     else
                     {
                         Clan clan = clanProp.GetValue(outcome) as Clan;
                         if (CheckAndRemove(clan, decision, outcome))
                         {
                             list.RemoveAt(i);
                             modified = true;
                         }
                     }
                 }

                 if (modified)
                 {
                     __result = list;
                 }
             }
             catch (Exception ex)
             {
                 try { 
                     string dir = Path.GetDirectoryName(LogPath);
                     if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
                     File.AppendAllText(LogPath, $"[ERROR] Postfix: {ex}\n"); 
                 } catch { }
             }
        }

        private static bool CheckAndRemove(Clan clan, SettlementClaimantDecision decision, DecisionOutcome outcome)
        {
            if (clan != null && clan.Leader != null)
            {
                if (clan.Leader.IsWanderer && clan != Clan.PlayerClan)
                {
                    try 
                    {
                        string dir = Path.GetDirectoryName(LogPath);
                        if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
                        File.AppendAllText(LogPath, $"[ElectionFix] Removing Wanderer: {clan.Leader.Name} (Clan: {clan.Name}) from {decision.Settlement?.Name?.ToString()}\n");
                    } catch {}
                    return true;
                }
            }
            return false;
        }
    }

    public static class SiegeCrashPatch
    {
        public static bool Prefix(Settlement settlement, IFaction faction, ref float __result)
        {
            if (faction == null)
            {
                 __result = 0f;
                 return false;
            }

            if (faction.FactionMidSettlement == null)
            {
                // If it's the player faction or a major kingdom, this shouldn't be null.
                // If it is, we return 0 to prevent the crash in DefaultSettlementValueModel.
                FieldSquire.FieldSquireSubModule.Logger?.Warning("SiegeCrashPatch: FactionMidSettlement for {FactionName} at {SettlementName} is NULL. Returning 0.", faction.Name, settlement?.Name);
                __result = 0.0f;
                return false;
            }
            return true;
        }
    }

    public static class DetermineSupportSafetyPatch
    {
        public static bool Prefix(Clan clan, DecisionOutcome possibleOutcome, ref float __result)
        {
            if (clan == null) return true;
            if (clan.MapFaction != null && clan.MapFaction.FactionMidSettlement == null)
            {
                 __result = 0.0f;
                 return false; 
            }
            return true;
        }
    }
}


