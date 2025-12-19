using MCM.Abstractions.Attributes;
using MCM.Abstractions.Attributes.v2;
using MCM.Abstractions.Base.Global;

namespace BetterGov
{
    public class GlobalSettings : AttributeGlobalSettings<GlobalSettings>
    {
        public override string Id => "BetterGovValues";
        public override string DisplayName => "BetterGov Settings";
        public override string FolderName => "BetterGov";
        public override string FormatType => "json";


        [SettingPropertyBool("Debug Mode", Order = 0, RequireRestart = false, HintText = "Enable debug logging to 'BetterGov.log'.")]
        [SettingPropertyGroup("General", GroupOrder = 0)]
        public bool DebugMode { get; set; } = false;

        [SettingPropertyBool("Auto-Assign Governor", Order = 1, RequireRestart = false, HintText = "Automatically assign clan leaders as governors when entering their settlements.")]
        [SettingPropertyGroup("Governors", GroupOrder = 1)]
        public bool AutoAssignGovernor { get; set; } = true;

        [SettingPropertyBool("Auto-Resolve Issues", Order = 2, RequireRestart = false, HintText = "Governors will automatically resolve issues in their settlements.")]
        [SettingPropertyGroup("Issues", GroupOrder = 2)]
        public bool AutoResolveIssues { get; set; } = true;
    }
}
