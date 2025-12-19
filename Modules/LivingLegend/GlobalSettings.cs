using MCM.Abstractions.Attributes;
using MCM.Abstractions.Attributes.v2;
using MCM.Abstractions.Base.Global;

namespace LivingLegend
{
    public class GlobalSettings : AttributeGlobalSettings<GlobalSettings>
    {
        public override string Id => "LivingLegend_v1.0.0";
        public override string DisplayName => "Living Legend";
        public override string FolderName => "LivingLegend";
        public override string FormatType => "json2";

        [SettingPropertyBool("Debug Mode", Order = 0, RequireRestart = false, HintText = "Enable debug logging.")]
        [SettingPropertyGroup("General")]
        public bool DebugMode { get; set; } = false;

        [SettingPropertyInteger("Renown Threshold", 0, 100000, "0", Order = 1, RequireRestart = false, HintText = "Renown required to enter Legend status.")]
        [SettingPropertyGroup("Requirements")]
        public int RenownThreshold { get; set; } = 6000;

        [SettingPropertyInteger("Daily Renown Cost", 0, 1000, "0", Order = 2, RequireRestart = false, HintText = "Daily renown cost for Legend status.")]
        [SettingPropertyGroup("Requirements")]
        public int DailyRenownCost { get; set; } = 10;

        [SettingPropertyInteger("Call to Arms Cost", 0, 5000, "0", Order = 1, RequireRestart = false, HintText = "Renown cost to force a lord into your army.")]
        [SettingPropertyGroup("Costs")]
        public int CallToArmsCost { get; set; } = 500;

        [SettingPropertyInteger("Rally Militia Cost", 0, 1000, "0", Order = 2, RequireRestart = false, HintText = "Renown cost to rally militia.")]
        [SettingPropertyGroup("Costs")]
        public int RallyMilitiaCost { get; set; } = 200;

        [SettingPropertyInteger("Recruit Minor Faction Cost", 0, 10000, "0", Order = 3, RequireRestart = false, HintText = "Renown cost to recruit a minor faction leader.")]
        [SettingPropertyGroup("Costs")]
        public int RecruitMinorFactionCost { get; set; } = 2000;

        [SettingPropertyInteger("Renown to Influence Ratio", 1, 100, "0", Order = 4, RequireRestart = false, HintText = "Renown cost per 1 Influence when recruiting armies.")]
        [SettingPropertyGroup("Costs")]
        public int RenownToInfluenceCostFactor { get; set; } = 5;

        [SettingPropertyInteger("Militia Patrol Duration", 1, 30, "0 days", Order = 1, RequireRestart = false, HintText = "Days a militia patrol lasts.")]
        [SettingPropertyGroup("Militia")]
        public int MilitiaPatrolDuration { get; set; } = 5;

        [SettingPropertyInteger("Militia Troop Count", 1, 200, "0", Order = 2, RequireRestart = false, HintText = "Number of troops in a militia patrol.")]
        [SettingPropertyGroup("Militia")]
        public int MilitiaTroopCount { get; set; } = 40;
    }
}
