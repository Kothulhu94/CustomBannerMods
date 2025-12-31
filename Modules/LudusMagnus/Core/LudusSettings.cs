using MCM.Abstractions.Attributes;
using MCM.Abstractions.Attributes.v2;
using MCM.Abstractions.Base.Global;

namespace LudusMagnus.Core
{
    public class LudusSettings : AttributeGlobalSettings<LudusSettings>
    {
        public override string Id => "LudusMagnus_Settings_v1";
        public override string DisplayName => "Ludus Magnus Settings";
        public override string FolderName => "LudusMagnus";
        public override string FormatType => "json";

        [SettingPropertyBool("Debug Mode", Order = 0, RequireRestart = false, HintText = "Enable debug messaging.")]
        [SettingPropertyGroup("General")]
        public bool DebugMode { get; set; } = false;
        
        [SettingPropertyInteger("Construction Cost", 1000, 10000000, "0", Order = 1, RequireRestart = false, HintText = "Cost to build the Ludus.")]
        [SettingPropertyGroup("Economy")]
        public int ConstructionCost { get; set; } = 1000000;
    }
}
