using MCM.Abstractions.Attributes;
using MCM.Abstractions.Attributes.v2;
using MCM.Abstractions.Base.Global;

namespace HonestWork
{
    public class GlobalSettings : AttributeGlobalSettings<GlobalSettings>
    {
        public override string Id => "HonestWork_v1";
        public override string DisplayName => "Honest Work Settings";
        public override string FolderName => "HonestWork";
        public override string FormatType => "json";



        // Town Job Settings
        [SettingPropertyInteger("Town Base Wage", 1, 100, "0 Gold", Order = 1, RequireRestart = false, HintText = "Base wage per hour for town jobs.")]
        public int TownBaseWage { get; set; } = 10;

        [SettingPropertyFloatingInteger("Town Prosperity Divisor", 100f, 1000f, "0.0", Order = 2, RequireRestart = false, HintText = "Higher value means prosperity contributes less to wage.")]
        public float TownProsperityDivisor { get; set; } = 250f;

        [SettingPropertyInteger("Shift Length", 1, 24, "0 Hours", Order = 3, RequireRestart = false, HintText = "Number of hours in a work shift.")]
        public int ShiftHours { get; set; } = 8;
        
        [SettingPropertyFloatingInteger("Town Effect Magnitude", 0f, 10f, "0.00", Order = 4, RequireRestart = false, HintText = "Multiplier for town stat changes per hour.")]
        public float TownEffectMagnitude { get; set; } = 0.2f;

        [SettingPropertyFloatingInteger("AI Effect Magnitude", 0f, 10f, "0.00", Order = 5, RequireRestart = false, HintText = "Multiplier for AI town stat changes per hour.")]
        public float AiEffectMagnitude { get; set; } = 0.05f;

        // Village Labor Settings
        [SettingPropertyFloatingInteger("Hearth Wage Divisor", 1f, 100f, "0.0", Order = 6, RequireRestart = false, HintText = "Hearths divided by this equals hourly wage.")]
        public float VillageHearthWageDivisor { get; set; } = 10f;

        [SettingPropertyFloatingInteger("Labor Hearth Gain", 0f, 5f, "0.0", Order = 7, RequireRestart = false, HintText = "Hearths gained per hour of labor.")]
        public float VillageHearthGain { get; set; } = 0.1f;

        // XP Settings
        [SettingPropertyInteger("Town Job Base XP", 1, 500, "0 XP", Order = 8, RequireRestart = false, HintText = "Base XP gained per hour.")]
        public int TownJobBaseXp { get; set; } = 50;
        
        [SettingPropertyInteger("Village Base XP", 1, 500, "0 XP", Order = 9, RequireRestart = false, HintText = "Base Athletics XP gained per hour in village.")]
        public int VillageBaseXp { get; set; } = 50;

        [SettingPropertyFloatingInteger("XP Streak Multiplier", 0f, 1f, "0.00", Order = 10, RequireRestart = false, HintText = "Extra XP multiplier per hour worked.")]
        public float XpStreakMultiplier { get; set; } = 0.05f;

        // NEW: AI Settings
        [SettingPropertyGroup("AI Settings")]
        [SettingPropertyBool("Enable AI in Villages", Order = 0, RequireRestart = false, HintText = "If disabled, AI will not work in villages.")]
        public bool EnableAiVillages { get; set; } = true;

        [SettingPropertyGroup("AI Settings")]
        [SettingPropertyBool("Enable AI in Castles", Order = 1, RequireRestart = false, HintText = "If disabled, AI will not drill in castles.")]
        public bool EnableAiCastles { get; set; } = true;

        [SettingPropertyGroup("AI Settings")]
        [SettingPropertyBool("Enable Noble Recruitment", Order = 2, RequireRestart = false, HintText = "If enabled, AI lords will camp at villages to recruit elites.")]
        public bool EnableNobleFarming { get; set; } = true;

        [SettingPropertyGroup("AI Settings")]
        [SettingPropertyFloatingInteger("Recruit Spawn Chance", 0f, 1f, "0%", Order = 3, RequireRestart = false, HintText = "Chance for an Elite recruit to spawn when Army accelerates growth.")]
        public float EliteSpawnChance { get; set; } = 0.15f;

        // NEW: Seasonal Settings
        [SettingPropertyGroup("Seasonal Economy")]
        [SettingPropertyBool("Enable Seasonal Wages", Order = 0, RequireRestart = false, HintText = "If enabled, job wages fluctuate by season.")]
        public bool EnableSeasonalWages { get; set; } = true;

        [SettingPropertyGroup("Seasonal Economy")]
        [SettingPropertyFloatingInteger("Volatility", 0f, 2f, "0.0", Order = 1, RequireRestart = false, HintText = "Multiplier for wage fluctuation range.")]
        public float SeasonalVolatility { get; set; } = 1.0f;

        // NEW: Thug Life Settings
        [SettingPropertyGroup("Criminal Activity")]
        [SettingPropertyFloatingInteger("Arrest Risk Factor", 0f, 0.01f, "0.000", Order = 0, RequireRestart = false, HintText = "Base risk per point of Town Security.")]
        public float ThugArrestBaseRisk { get; set; } = 0.001f;

        [SettingPropertyGroup("Criminal Activity")]
        [SettingPropertyFloatingInteger("Roguery Safety Factor", 0f, 0.01f, "0.000", Order = 1, RequireRestart = false, HintText = "Risk reduction per point of Roguery.")]
        public float ThugRoguerySafety { get; set; } = 0.0005f;

        [SettingPropertyGroup("Criminal Activity")]
        [SettingPropertyBool("Owner Exemption", Order = 2, RequireRestart = false, HintText = "If enabled, you cannot be arrested in your own town.")]
        public bool PlayerTownExemption { get; set; } = true;
    }
}
