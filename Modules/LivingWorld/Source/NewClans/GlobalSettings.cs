using LivingWorld;

namespace NewClans
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

        public bool ModuleEnabled => LivingWorldSettings.Instance?.NewClans_ModuleEnabled ?? true;
        public int PromotionCost => LivingWorldSettings.Instance?.NewClans_PromotionCost ?? 1000000;
        public bool DebugMode => LivingWorldSettings.Instance?.NewClans_DebugMode ?? false;

        public int AiMinTier => LivingWorldSettings.Instance?.NewClans_AiMinTier ?? 6;
        public int AiMinGold => LivingWorldSettings.Instance?.NewClans_AiMinGold ?? 3000000;
        public int AiMinFiefs => LivingWorldSettings.Instance?.NewClans_AiMinFiefs ?? 5;
    }
}
