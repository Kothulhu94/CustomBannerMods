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
    }
}
