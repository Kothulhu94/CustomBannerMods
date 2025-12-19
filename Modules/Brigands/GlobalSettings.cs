using MCM.Abstractions.Attributes;
using MCM.Abstractions.Attributes.v2;
using MCM.Abstractions.Base.Global;

namespace Brigands
{
    public class GlobalSettings : AttributeGlobalSettings<GlobalSettings>
    {
        public override string Id => "Brigands_v1";

        public override string DisplayName => "Brigands: Bandit Overhaul";

        public override string FolderName => "Brigands";

        public override string FormatType => "json";

        [SettingPropertyBool("Debug Mode", Order = 0, RequireRestart = false, HintText = "Enable debug logging.")]
        [SettingPropertyGroup("General")]
        public bool DebugMode { get; set; } = true;

        [SettingPropertyFloatingInteger("Terror Grid Size", 10f, 200f, "0.0", Order = 1, RequireRestart = true, HintText = "Size of spatial grid cells for Terror tracking.")]
        [SettingPropertyGroup("Terror")]
        public float TerrorGridSize { get; set; } = 50f;

        [SettingPropertyFloatingInteger("Terror Distance Sqr", 5000f, 50000f, "0.0", Order = 2, RequireRestart = false, HintText = "Max distance squared for bandits to detect villages.")]
        [SettingPropertyGroup("Terror")]
        public float TerrorDistanceSquared { get; set; } = 22500f;

        [SettingPropertyFloatingInteger("Militia Strength Multiplier", 1.5f, 5.0f, "0.0", Order = 3, RequireRestart = false, HintText = "Ratio of Bandit Ratio to Militia Ratio required to attack (Default 2.0 = Bandits must be 2x stronger).")]
        [SettingPropertyGroup("Terror")]
        public float TerrorStrengthRatio { get; set; } = 2.0f;

        [SettingPropertyInteger("Max Horde Size Base", 20, 100, Order = 1, RequireRestart = false, HintText = "Base party size cap for bandit parties.")]
        [SettingPropertyGroup("Cohesion")]
        public int MaxHordeSizeBase { get; set; } = 40;

        [SettingPropertyInteger("Per Clan Tier Bonus", 0, 50, Order = 2, RequireRestart = false, HintText = "Extra party capacity per player clan tier (scaling difficulty).")]
        [SettingPropertyGroup("Cohesion")]
        public int PerClanTierBonus { get; set; } = 20;

        [SettingPropertyBool("Enable Naval Merging", Order = 3, RequireRestart = false, HintText = "Allow Sea Raiders to merge.")]
        [SettingPropertyGroup("Cohesion")]
        public bool EnableNavalMerging { get; set; } = true;

        [SettingPropertyInteger("Daily Recruit Chance", 0, 100, Order = 1, RequireRestart = false, HintText = "Percent chance per prisoner to be recruited daily.")]
        [SettingPropertyGroup("Recruitment")]
        public int DailyRecruitChance { get; set; } = 20;

        [SettingPropertyInteger("XP Per Day", 0, 2000, Order = 1, RequireRestart = false, HintText = "XP gained by each bandit troop daily.")]
        [SettingPropertyGroup("Training")]
        public int DailyXpPerMan { get; set; } = 500;

        [SettingPropertyInteger("Warlord Spawn Chance Weekly", 0, 100, Order = 1, RequireRestart = false, HintText = "Percent chance per eligible wanderer to become a Warlord weekly.")]
        [SettingPropertyGroup("Warlords")]
        public int WarlordSpawnChance { get; set; } = 10;
        
        [SettingPropertyInteger("Warlord Respawn Chance Daily", 0, 100, Order = 2, RequireRestart = false, HintText = "Percent chance per day for a defeated Warlord to respawn at a hideout.")]
        [SettingPropertyGroup("Warlords")]
        public int WarlordRespawnChance { get; set; } = 25;
    }
}
