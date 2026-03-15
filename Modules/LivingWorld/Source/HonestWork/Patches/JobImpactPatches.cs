using System;
using System.Linq;
using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.GameComponents;
using TaleWorlds.CampaignSystem.ComponentInterfaces;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Localization;

namespace HonestWork.Patches
{
    public static class JobLoyaltyPatch
    {
        public static void Postfix(Town town, bool includeDescriptions, ref ExplainedNumber __result)
        {
            if (town?.Settlement == null) return;
            // JobImpactPatchesHelper.ApplyImpacts(town.Settlement, ref __result, (i) => i.Loyalty);
        }
    }

    public static class JobSecurityPatch
    {
        public static void Postfix(Town town, bool includeDescriptions, ref ExplainedNumber __result)
        {
             if (town?.Settlement == null) return;
             // JobImpactPatchesHelper.ApplyImpacts(town.Settlement, ref __result, (i) => i.Security);
             
        }
    }

    public static class JobProsperityPatch
    {
        public static void Postfix(Town fortification, bool includeDescriptions, ref ExplainedNumber __result)
        {
             if (fortification?.Settlement == null) return;
             // JobImpactPatchesHelper.ApplyImpacts(fortification.Settlement, ref __result, (i) => i.Prosperity);
        }
    }

    public static class JobMilitiaPatch
    {
        public static void Postfix(Settlement settlement, bool includeDescriptions, ref ExplainedNumber __result)
        {
             if (settlement == null) return;
             // JobImpactPatchesHelper.ApplyImpacts(settlement, ref __result, (i) => i.Militia);
        }
    }

    public static class JobFoodPatch
    {
        public static void Postfix(Town town, bool includeMarketStocks, bool includeDescriptions, ref ExplainedNumber __result)
        {
             if (town?.Settlement == null) return;
             // JobImpactPatchesHelper.ApplyImpacts(town.Settlement, ref __result, (i) => i.Food);
        }
    }

    public static class JobGarrisonPatch
    {
        public static void Postfix(Settlement settlement, bool includeDescriptions, ref ExplainedNumber __result)
        {
             if (settlement == null) return;
             // JobImpactPatchesHelper.ApplyImpacts(settlement, ref __result, (i) => i.GarrisonChange);
        }
    }

    public static class JobImpactPatchesHelper
    {
        public static void ApplyImpacts(Settlement settlement, ref ExplainedNumber result, Func<JobImpactTracker.ImpactResult, float> selector, string labelFormat = null)
        {
            var impacts = JobImpactTracker.GetSettlementImpacts(settlement);
            
            foreach (var impact in impacts)
            {
                float val = selector(impact.Item2);
                if (Math.Abs(val) > 0.001f)
                {
                    string name = impact.Item1.Name.ToString();
                    string finalLabel = string.IsNullOrEmpty(labelFormat) ? name : string.Format(labelFormat, name);
                    
                    result.Add(val, new TextObject(finalLabel));
                }
            }
        }
    }
}
