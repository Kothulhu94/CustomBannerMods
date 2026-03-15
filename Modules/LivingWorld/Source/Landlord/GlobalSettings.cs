using LivingWorld;

namespace Landlord
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

        public bool ModuleEnabled => LivingWorldSettings.Instance?.Landlord_ModuleEnabled ?? true;
        public bool DebugMode => LivingWorldSettings.Instance?.Landlord_DebugMode ?? true;
        public int NormalPlotCost => LivingWorldSettings.Instance?.Landlord_NormalPlotCost ?? 10000;
        public int GoodPlotCost => LivingWorldSettings.Instance?.Landlord_GoodPlotCost ?? 50000;
        public int GreatPlotCost => LivingWorldSettings.Instance?.Landlord_GreatPlotCost ?? 100000;
        public int ChangeProductionCost => LivingWorldSettings.Instance?.Landlord_ChangeProductionCost ?? 2000;
        public float BaseYieldMultiplier => LivingWorldSettings.Instance?.Landlord_BaseYieldMultiplier ?? 8.0f;
        public float NormalYield => LivingWorldSettings.Instance?.Landlord_NormalYield ?? 1.0f;
        public float GoodYield => LivingWorldSettings.Instance?.Landlord_GoodYield ?? 1.2f;
        public float GreatYield => LivingWorldSettings.Instance?.Landlord_GreatYield ?? 1.5f;
        public float VillageStimulusRatio => LivingWorldSettings.Instance?.Landlord_VillageStimulusRatio ?? 0.5f;
        public int InitialInvestmentItemMultiplier => LivingWorldSettings.Instance?.Landlord_InitialInvestmentItemMultiplier ?? 10;
        public float HearthBonusNormal => LivingWorldSettings.Instance?.Landlord_HearthBonusNormal ?? 0.1f;
        public float HearthBonusGood => LivingWorldSettings.Instance?.Landlord_HearthBonusGood ?? 0.2f;
        public float HearthBonusGreat => LivingWorldSettings.Instance?.Landlord_HearthBonusGreat ?? 0.5f;
        public float HearthDamageOnRaze => LivingWorldSettings.Instance?.Landlord_HearthDamageOnRaze ?? 50.0f;
        public int RelationPenaltyOnRaze => LivingWorldSettings.Instance?.Landlord_RelationPenaltyOnRaze ?? 10;
        public bool AllowLivestock => LivingWorldSettings.Instance?.Landlord_AllowLivestock ?? false;
        public bool AllowVillageGoods => LivingWorldSettings.Instance?.Landlord_AllowVillageGoods ?? false;
        public bool AllowPack => LivingWorldSettings.Instance?.Landlord_AllowPack ?? false;
        public bool AllowMounts => LivingWorldSettings.Instance?.Landlord_AllowMounts ?? false;
        public bool AllowWarMounts => LivingWorldSettings.Instance?.Landlord_AllowWarMounts ?? false;
        public bool AllowNobleMounts => LivingWorldSettings.Instance?.Landlord_AllowNobleMounts ?? false;
        public int BaseUpgradeCost => LivingWorldSettings.Instance?.Landlord_BaseUpgradeCost ?? 5000;
        public int GuardCapLvl1 => LivingWorldSettings.Instance?.Landlord_GuardCapLvl1 ?? 50;
        public int GuardCapLvl2 => LivingWorldSettings.Instance?.Landlord_GuardCapLvl2 ?? 100;
        public int GuardCapLvl3 => LivingWorldSettings.Instance?.Landlord_GuardCapLvl3 ?? 200;
        public int StashCapLvl1 => LivingWorldSettings.Instance?.Landlord_StashCapLvl1 ?? 200;
        public int StashCapLvl2 => LivingWorldSettings.Instance?.Landlord_StashCapLvl2 ?? 400;
        public int StashCapLvl3 => LivingWorldSettings.Instance?.Landlord_StashCapLvl3 ?? 600;
        public int AIPlotBuyThreshold => LivingWorldSettings.Instance?.Landlord_AIPlotBuyThreshold ?? 150000;
    }
}
