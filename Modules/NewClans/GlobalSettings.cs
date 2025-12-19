using MCM.Abstractions.Attributes;
using MCM.Abstractions.Attributes.v2;
using MCM.Abstractions.Base.Global;

namespace NewClans
{
    public class GlobalSettings : AttributeGlobalSettings<GlobalSettings>
    {
        public override string Id => "NewClans_v1";
        public override string DisplayName => "New Clans Settings";
        public override string FolderName => "NewClans";
        public override string FormatType => "json";

        [SettingPropertyInteger("Promotion Cost", 10000, 10000000, "0", Order = 1, RequireRestart = false, HintText = "The cost to promote a companion to a noble house.")]
        [SettingPropertyGroup("General")]
        public int PromotionCost { get; set; } = 1000000;

        [SettingPropertyBool("Debug Mode", Order = 2, RequireRestart = false, HintText = "Enable detailed logging.")]
        [SettingPropertyGroup("General")]
        public bool DebugMode { get; set; } = false;
    }
}
