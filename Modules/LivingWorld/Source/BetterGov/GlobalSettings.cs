using LivingWorld;

namespace BetterGov
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

        public bool ModuleEnabled => LivingWorldSettings.Instance?.BetterGov_ModuleEnabled ?? true;
        public bool DebugMode => LivingWorldSettings.Instance?.BetterGov_DebugMode ?? false;
        public bool AutoAssignGovernor => LivingWorldSettings.Instance?.BetterGov_AutoAssignGovernor ?? true;
        public bool AutoResolveIssues => LivingWorldSettings.Instance?.BetterGov_AutoResolveIssues ?? true;
        public int IssueResolveThresholdDays => LivingWorldSettings.Instance?.BetterGov_IssueResolveThresholdDays ?? 7;
        public int IssueResolveCost => LivingWorldSettings.Instance?.BetterGov_IssueResolveCost ?? 500;
    }
}
