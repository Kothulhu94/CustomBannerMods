using LivingWorld;

namespace FieldSquire
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

        public bool ModuleEnabled => LivingWorldSettings.Instance?.FieldSquire_ModuleEnabled ?? true;
        
        public int FoodThreshold 
        {
            get => LivingWorldSettings.Instance?.FieldSquire_FoodThreshold ?? 20;
            set
            {
                if (LivingWorldSettings.Instance != null)
                    LivingWorldSettings.Instance.FieldSquire_FoodThreshold = value;
            }
        }

        public bool DebugMode => LivingWorldSettings.Instance?.FieldSquire_DebugMode ?? false;
    }
}
