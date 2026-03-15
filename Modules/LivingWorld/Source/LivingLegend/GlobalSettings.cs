using LivingWorld;

namespace LivingLegend
{
    public class GlobalSettings
    {
        private static GlobalSettings _instance;
        public static GlobalSettings Instance
        {
            get
            {
                if (_instance == null) _instance = new GlobalSettings();
                return _instance;
            }
        }

        public bool ModuleEnabled => LivingWorldSettings.Instance?.LivingLegend_ModuleEnabled ?? true;
        public bool DebugMode => LivingWorldSettings.Instance?.LivingLegend_DebugMode ?? false;
        public int RenownThreshold => LivingWorldSettings.Instance?.LivingLegend_RenownThreshold ?? 6000;
        public int DailyRenownCost => LivingWorldSettings.Instance?.LivingLegend_DailyRenownCost ?? 10;
        public int CallToArmsCost => LivingWorldSettings.Instance?.LivingLegend_CallToArmsCost ?? 500;
        public int RallyMilitiaCost => LivingWorldSettings.Instance?.LivingLegend_RallyMilitiaCost ?? 200;
        public int RecruitMinorFactionCost => LivingWorldSettings.Instance?.LivingLegend_RecruitMinorFactionCost ?? 2000;
        public int RenownToInfluenceCostFactor => LivingWorldSettings.Instance?.LivingLegend_RenownToInfluenceCostFactor ?? 5;
        public int MilitiaPatrolDuration => LivingWorldSettings.Instance?.LivingLegend_MilitiaPatrolDuration ?? 5;
        public int MilitiaTroopCount => LivingWorldSettings.Instance?.LivingLegend_MilitiaTroopCount ?? 40;
        public int CallToArmsRelationPenalty => LivingWorldSettings.Instance?.LivingLegend_CallToArmsRelationPenalty ?? 5;
        public bool AI_EnableLegendLogic => LivingWorldSettings.Instance?.LivingLegend_AI_EnableLegendLogic ?? true;
        public int AI_MinRenownForRally => LivingWorldSettings.Instance?.LivingLegend_AI_MinRenownForRally ?? 6500;
        public float AI_RallyChance => LivingWorldSettings.Instance?.LivingLegend_AI_RallyChance ?? 0.05f;
        public int CompanionLimitRenownDivisor => LivingWorldSettings.Instance?.LivingLegend_CompanionLimitRenownDivisor ?? 1000;
        public float LegendMilitiaBonus => LivingWorldSettings.Instance?.LivingLegend_LegendMilitiaBonus ?? 1.0f;
        public float LegendLoyaltyBonus => LivingWorldSettings.Instance?.LivingLegend_LegendLoyaltyBonus ?? 2.0f;
    }
}
