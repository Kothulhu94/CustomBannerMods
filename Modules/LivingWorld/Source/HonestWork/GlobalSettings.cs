using LivingWorld;

namespace HonestWork
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

        public bool ModuleEnabled => LivingWorldSettings.Instance?.HonestWork_ModuleEnabled ?? true;
        public int TownBaseWage => LivingWorldSettings.Instance?.HonestWork_TownBaseWage ?? 10;
        public float TownProsperityDivisor => LivingWorldSettings.Instance?.HonestWork_TownProsperityDivisor ?? 250f;
        public int ShiftHours => LivingWorldSettings.Instance?.HonestWork_ShiftHours ?? 4;
        public float TownEffectMagnitude => LivingWorldSettings.Instance?.HonestWork_TownEffectMagnitude ?? 0.2f;
        public float AiEffectMagnitude => LivingWorldSettings.Instance?.HonestWork_AiEffectMagnitude ?? 0.05f;
        public float VillageHearthWageDivisor => LivingWorldSettings.Instance?.HonestWork_VillageHearthWageDivisor ?? 10f;
        public float VillageHearthGain => LivingWorldSettings.Instance?.HonestWork_VillageHearthGain ?? 0.1f;
        public int TownJobBaseXp => LivingWorldSettings.Instance?.HonestWork_TownJobBaseXp ?? 50;
        public int VillageBaseXp => LivingWorldSettings.Instance?.HonestWork_VillageBaseXp ?? 50;
        public float XpStepMultiplier => LivingWorldSettings.Instance?.HonestWork_XpStepMultiplier ?? 0.02f;
        public int XpIncreaseInterval => LivingWorldSettings.Instance?.HonestWork_XpIncreaseInterval ?? 4;
        public bool EnableAiVillages => LivingWorldSettings.Instance?.HonestWork_EnableAiVillages ?? true;
        public bool EnableAiCastles => LivingWorldSettings.Instance?.HonestWork_EnableAiCastles ?? true;
        public bool EnableNobleFarming => LivingWorldSettings.Instance?.HonestWork_EnableNobleFarming ?? true;
        public float EliteSpawnChance => LivingWorldSettings.Instance?.HonestWork_EliteSpawnChance ?? 0.15f;
        public bool EnableSeasonalWages => LivingWorldSettings.Instance?.HonestWork_EnableSeasonalWages ?? true;
        public float SeasonalVolatility => LivingWorldSettings.Instance?.HonestWork_SeasonalVolatility ?? 1.0f;
        public float ThugArrestBaseRisk => LivingWorldSettings.Instance?.HonestWork_ThugArrestBaseRisk ?? 0.001f;
        public float ThugRoguerySafety => LivingWorldSettings.Instance?.HonestWork_ThugRoguerySafety ?? 0.0005f;
        public bool PlayerTownExemption => LivingWorldSettings.Instance?.HonestWork_PlayerTownExemption ?? true;
        public float WageGuard => LivingWorldSettings.Instance?.HonestWork_WageGuard ?? 1.0f;
        public float WageThug => LivingWorldSettings.Instance?.HonestWork_WageThug ?? 1.5f;
        public float WageArtisan => LivingWorldSettings.Instance?.HonestWork_WageArtisan ?? 1.1f;
        public float WageOfficial => LivingWorldSettings.Instance?.HonestWork_WageOfficial ?? 1.2f;
        public float WagePhysician => LivingWorldSettings.Instance?.HonestWork_WagePhysician ?? 1.2f;
        public float WageInstructor => LivingWorldSettings.Instance?.HonestWork_WageInstructor ?? 1.0f;
        public float WageOutrider => LivingWorldSettings.Instance?.HonestWork_WageOutrider ?? 1.1f;
        public int XpPrimary => LivingWorldSettings.Instance?.HonestWork_XpPrimary ?? 20;
        public int XpSecondary => LivingWorldSettings.Instance?.HonestWork_XpSecondary ?? 30;
        public float CompanionEfficiencyFactor => LivingWorldSettings.Instance?.HonestWork_CompanionEfficiencyFactor ?? 0.001f;
        public float TroopXpMultiplier => LivingWorldSettings.Instance?.HonestWork_TroopXpMultiplier ?? 1.0f;
        public int ShiftXpBonus => LivingWorldSettings.Instance?.HonestWork_ShiftXpBonus ?? 25;
        public int ShiftFoodBonus => LivingWorldSettings.Instance?.HonestWork_ShiftFoodBonus ?? 10;
        public int ShiftRelationBonus => LivingWorldSettings.Instance?.HonestWork_ShiftRelationBonus ?? 1;
        public float AiWorkChance => LivingWorldSettings.Instance?.HonestWork_AiWorkChance ?? 0.3f;
        public float PowerHearthScalar => LivingWorldSettings.Instance?.HonestWork_PowerHearthScalar ?? 0.0005f;
        public float PowerRecruitScalar => LivingWorldSettings.Instance?.HonestWork_PowerRecruitScalar ?? 0.00005f;
        public float ArrestRollEyesChance => LivingWorldSettings.Instance?.HonestWork_ArrestRollEyesChance ?? 0.05f;
        public bool HonestWork_EnableSiegeBetrayal => LivingWorldSettings.Instance?.HonestWork_EnableSiegeBetrayal ?? true;
        public bool EnableTownStatIncreases => LivingWorldSettings.Instance?.HonestWork_EnableTownStatIncreases ?? true;
        public bool EnableTownItemRewards => LivingWorldSettings.Instance?.HonestWork_EnableTownItemRewards ?? true;
        public bool EnableVillageItemRewards => LivingWorldSettings.Instance?.HonestWork_EnableVillageItemRewards ?? true;
    }
}
