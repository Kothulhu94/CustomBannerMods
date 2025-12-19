using MCM.Abstractions.Attributes;
using MCM.Abstractions.Attributes.v2;
using MCM.Abstractions.Base.Global;

namespace CoastalLife
{
    public class GlobalSettings : AttributeGlobalSettings<GlobalSettings>
    {
        public override string Id => "CoastalLife_v1";
        public override string DisplayName => "Coastal Life Settings";
        public override string FolderName => "CoastalLife";
        public override string FormatType => "json";

        [SettingPropertyBool("Debug Mode", Order = 0, RequireRestart = false, HintText = "Enable debug logging.")]
        [SettingPropertyGroup("General")]
        public bool DebugMode { get; set; } = false;

        [SettingPropertyInteger("Docking Slip Cost", 1000, 100000, "0", Order = 1, RequireRestart = false, HintText = "Cost to purchase a docking slip.")]
        [SettingPropertyGroup("Economy")]
        public int SlipCost { get; set; } = 10000;

        [SettingPropertyFloatingInteger("Docking Slip Income (Prosperity %)", 0.01f, 1.0f, "0.00", Order = 2, RequireRestart = false, HintText = "Percentage of town prosperity given as daily income.")]
        [SettingPropertyGroup("Economy")]
        public float DockingSlipIncomePercentage { get; set; } = 0.1f;

        [SettingPropertyInteger("Press Gang Relation Penalty", -100, 0, "0", Order = 3, RequireRestart = false, HintText = "Relation penalty with town owner when press ganging.")]
        [SettingPropertyGroup("Crime")]
        public int PressGangRelationPenalty { get; set; } = -5;
        
        [SettingPropertyInteger("Coast Guard Ship Count", 1, 10, "0", Order = 4, RequireRestart = false, HintText = "Number of ships in a Coast Guard patrol.")]
        [SettingPropertyGroup("Coast Guard")]
        public int ShipCount { get; set; } = 2;

        [SettingPropertyInteger("Coast Guard Marine Count", 10, 100, "0", Order = 5, RequireRestart = false, HintText = "Number of marines in a Coast Guard patrol.")]
        [SettingPropertyGroup("Coast Guard")]
        public int MarineCount { get; set; } = 20;
    }
}
