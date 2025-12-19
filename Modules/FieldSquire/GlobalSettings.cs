using MCM.Abstractions.Attributes;
using MCM.Abstractions.Attributes.v2;
using MCM.Abstractions.Base.Global;

namespace FieldSquire
{
    public sealed class GlobalSettings : AttributeGlobalSettings<GlobalSettings>
    {
        public override string Id => "FieldSquire_v1";
        public override string DisplayName => "Field Squire";
        public override string FolderName => "FieldSquire";
        public override string FormatType => "json";

        [SettingPropertyInteger("Food Supply Threshold", 0, 100, "0", Order = 0, RequireRestart = false, HintText = "Squire will buy food to maintain this level.")]
        [SettingPropertyGroup("Logistics")]
        public int FoodThreshold { get; set; } = 20;

        [SettingPropertyBool("Debug Mode", Order = 1, RequireRestart = false, HintText = "Enable verbose logging to isolated file.")]
        [SettingPropertyGroup("General")]
        public bool DebugMode { get; set; } = false;
        
        [SettingPropertyBool("Squire Immortality", Order = 2, RequireRestart = false, HintText = "Prevents the squire from dying in battle.")]
        [SettingPropertyGroup("General")]
        public bool SquireImmortality { get; set; } = true;
    }
}
