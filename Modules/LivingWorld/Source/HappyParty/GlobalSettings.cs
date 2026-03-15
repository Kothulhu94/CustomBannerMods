using LivingWorld;

namespace HappyParty
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

        public bool ModuleEnabled => LivingWorldSettings.Instance?.HappyParty_ModuleEnabled ?? true;
        public bool DebugMode => LivingWorldSettings.Instance?.HappyParty_DebugMode ?? false;
        public bool EnableShooOption => LivingWorldSettings.Instance?.HappyParty_EnableShooOption ?? false;
        public int TargetWandererCount => LivingWorldSettings.Instance?.HappyParty_TargetWandererCount ?? 30;
        public int DailySpawnCap => LivingWorldSettings.Instance?.HappyParty_DailySpawnCap ?? 10;
        public int TroopsPerFoodItem => LivingWorldSettings.Instance?.HappyParty_TroopsPerFoodItem ?? 5;
        public int JobSeekerHireCost => LivingWorldSettings.Instance?.HappyParty_JobSeekerHireCost ?? 2000;
        public int PrisonerRansomModifier => LivingWorldSettings.Instance?.HappyParty_PrisonerRansomModifier ?? 100;
    }
}
