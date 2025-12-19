using MCM.Abstractions.Attributes;
using MCM.Abstractions.Attributes.v2;
using MCM.Abstractions.Base.Global;

namespace HappyParty
{
    public class GlobalSettings : AttributeGlobalSettings<GlobalSettings>
    {
        public override string Id => "HappyParty";
        public override string DisplayName => "Happy Party";
        public override string FolderName => "HappyParty";
        public override string FormatType => "json2";

        [SettingPropertyBool("Debug Mode", Order = 0, RequireRestart = false, HintText = "Enable debug logging for AI decisions.")]
        public bool DebugMode { get; set; } = false;

        [SettingPropertyInteger("Target Wanderer Count", 10, 100, "0", Order = 1, RequireRestart = false, HintText = "Target number of wanderers in the world (min 10).")]
        public int TargetWandererCount { get; set; } = 30;

        [SettingPropertyInteger("Daily Spawn Cap", 1, 50, "0", Order = 2, RequireRestart = false, HintText = "Maximum number of wanderers to spawn per day.")]
        public int DailySpawnCap { get; set; } = 10;

        [SettingPropertyInteger("Troops Per Food Item", 1, 20, "0", Order = 3, RequireRestart = false, HintText = "The AI will try to buy 1 food item per X troops. Lower means more food.")]
        public int TroopsPerFoodItem { get; set; } = 5;

        [SettingPropertyInteger("Job Seeker Hire Cost", 500, 10000, "0", Order = 4, RequireRestart = false, HintText = "Gold cost for an AI Lord to hire a specialist wanderer.")]
        public int JobSeekerHireCost { get; set; } = 2000;
        
        [SettingPropertyInteger("Prisoner Ransom Modifier", 50, 200, "0", Order = 5, RequireRestart = false, HintText = "Percentage of ransom value AI receives (100 = full value).")]
        public int PrisonerRansomModifier { get; set; } = 100;
    }
}
