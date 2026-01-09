using MCM.Abstractions.Attributes;
using MCM.Abstractions.Attributes.v2;
using MCM.Abstractions.Base.Global;

namespace Landlord
{
    public class GlobalSettings : AttributeGlobalSettings<GlobalSettings>
    {
        public override string Id => "Landlord_v1";
        public override string DisplayName => "Landlord Settings";
        public override string FolderName => "Landlord";
        public override string FormatType => "json";

        [SettingPropertyBool("Debug Mode", Order = 0, RequireRestart = false, HintText = "Enable debug logging.")]
        [SettingPropertyGroup("General")]
        public bool DebugMode { get; set; } = true;

        [SettingPropertyInteger("Normal Plot Cost", 1000, 1000000, "0", Order = 1, RequireRestart = false, HintText = "Cost to purchase a Normal Plot.")]
        [SettingPropertyGroup("Economy")]
        public int NormalPlotCost { get; set; } = 10000;

        [SettingPropertyInteger("Good Plot Cost", 5000, 1000000, "0", Order = 2, RequireRestart = false, HintText = "Cost to purchase a Good Plot.")]
        [SettingPropertyGroup("Economy")]
        public int GoodPlotCost { get; set; } = 50000;

        [SettingPropertyInteger("Great Plot Cost", 10000, 1000000, "0", Order = 3, RequireRestart = false, HintText = "Cost to purchase a Great Plot.")]
        [SettingPropertyGroup("Economy")]
        public int GreatPlotCost { get; set; } = 100000;

        [SettingPropertyInteger("Change Production Cost", 0, 100000, "0", Order = 4, RequireRestart = false, HintText = "Cost to change production type.")]
        [SettingPropertyGroup("Economy")]
        public int ChangeProductionCost { get; set; } = 2000;

        [SettingPropertyFloatingInteger("Hearth Damage on Raze", 0f, 500f, "0.0", Order = 5, RequireRestart = false, HintText = "Hearth damage inflicted when a plot is razed.")]
        [SettingPropertyGroup("Violence")]
        public float HearthDamageOnRaze { get; set; } = 50.0f;

        [SettingPropertyInteger("Relation Penalty on Raze", 0, 100, "0", Order = 6, RequireRestart = false, HintText = "Relation penalty with the owner when a plot is razed.")]
        [SettingPropertyGroup("Violence")]
        public int RelationPenaltyOnRaze { get; set; } = 10;

        [SettingPropertyBool("Allow Livestock Production", Order = 10, RequireRestart = false, HintText = "Allow production of animals. WARNING: Balance Breaking.")]
        [SettingPropertyGroup("Production Options")]
        public bool AllowLivestock { get; set; } = false;

        [SettingPropertyBool("Allow Village Goods Production", Order = 11, RequireRestart = false, HintText = "Allow production of raw materials (Iron, Clay, etc). WARNING: Balance Breaking.")]
        [SettingPropertyGroup("Production Options")]
        public bool AllowVillageGoods { get; set; } = false;

        [SettingPropertyBool("Allow Pack Animals", Order = 12, RequireRestart = false, HintText = "Allow production of Pack Animals. WARNING: Balance Breaking.")]
        [SettingPropertyGroup("Production Options")]
        public bool AllowPack { get; set; } = false;

        [SettingPropertyBool("Allow Mounts", Order = 13, RequireRestart = false, HintText = "Allow production of Riding Horses. WARNING: Balance Breaking.")]
        [SettingPropertyGroup("Production Options")]
        public bool AllowMounts { get; set; } = false;

        [SettingPropertyBool("Allow War Mounts", Order = 14, RequireRestart = false, HintText = "Allow production of War Horses. WARNING: Balance Breaking.")]
        [SettingPropertyGroup("Production Options")]
        public bool AllowWarMounts { get; set; } = false;
        
        [SettingPropertyBool("Allow Noble Mounts", Order = 15, RequireRestart = false, HintText = "Allow production of Noble Horses. WARNING: Balance Breaking.")]
        [SettingPropertyGroup("Production Options")]
        public bool AllowNobleMounts { get; set; } = false;
    }
}
