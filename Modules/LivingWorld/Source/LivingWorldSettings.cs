using MCM.Abstractions.Attributes;
using MCM.Abstractions.Attributes.v2;
using MCM.Abstractions.Base.Global;

namespace LivingWorld
{
    public class LivingWorldSettings : AttributeGlobalSettings<LivingWorldSettings>
    {
        public override string Id => "LivingWorld_Unified_v1";
        public override string DisplayName => "Living World";
        public override string FolderName => "LivingWorld";
        public override string FormatType => "json";

        [SettingPropertyBool("Enable Better Gov", Order = -1, RequireRestart = true, HintText = "Enable or disable Better Gov features.")]
        [SettingPropertyGroup("Better Gov/General", GroupOrder = 1)]
        public bool BetterGov_ModuleEnabled { get; set; } = true;

        [SettingPropertyBool("Debug Mode", Order = 0, RequireRestart = false, HintText = "Enable debug logging to 'BetterGov.log'.")]
        [SettingPropertyGroup("Better Gov/General")]
        public bool BetterGov_DebugMode { get; set; } = false;

        [SettingPropertyBool("Auto-Assign Governor", Order = 1, RequireRestart = false, HintText = "Automatically assign clan leaders as governors when entering their settlements.")]
        [SettingPropertyGroup("Better Gov/Governors")]
        public bool BetterGov_AutoAssignGovernor { get; set; } = true;

        [SettingPropertyBool("Auto-Resolve Issues", Order = 2, RequireRestart = false, HintText = "Governors will automatically resolve issues in their settlements.")]
        [SettingPropertyGroup("Better Gov/Issues")]
        public bool BetterGov_AutoResolveIssues { get; set; } = true;

        [SettingPropertyInteger("Resolve Threshold (Days)", 1, 30, "0 days", Order = 3, RequireRestart = false, HintText = "How many days an issue must be active before it is auto-resolved.")]
        [SettingPropertyGroup("Better Gov/Issues")]
        public int BetterGov_IssueResolveThresholdDays { get; set; } = 7;

        [SettingPropertyInteger("Resolve Cost (Gold)", 0, 10000, "0 Gold", Order = 4, RequireRestart = false, HintText = "Gold cost for AI governors to resolve an issue.")]
        [SettingPropertyGroup("Better Gov/Issues")]
        public int BetterGov_IssueResolveCost { get; set; } = 500;

        [SettingPropertyBool("Enable Field Squire", Order = -1, RequireRestart = true, HintText = "Enable or disable Field Squire features.")]
        [SettingPropertyGroup("Field Squire/General", GroupOrder = 2)]
        public bool FieldSquire_ModuleEnabled { get; set; } = true;

        [SettingPropertyBool("Debug Mode", Order = 1, RequireRestart = false, HintText = "Enable verbose logging to isolated file.")]
        [SettingPropertyGroup("Field Squire/General")]
        public bool FieldSquire_DebugMode { get; set; } = false;

        [SettingPropertyInteger("Stewardship Scaling", 1, 100, "0", Order = 4, RequireRestart = false, HintText = "Levels of Steward required per extra troop. Default is 5.")]
        [SettingPropertyGroup("Field Squire/General")]
        public int FieldSquire_StewardshipScaling { get; set; } = 5;

        [SettingPropertyInteger("Companion Scaling", 1, 100, "0", Order = 5, RequireRestart = false, HintText = "Levels of Steward required per extra companion slot. Default is 50.")]
        [SettingPropertyGroup("Field Squire/General")]
        public int FieldSquire_CompanionScaling { get; set; } = 50;


        [SettingPropertyInteger("Food Supply Threshold", 0, 100, "0", Order = 0, RequireRestart = false, HintText = "Squire will buy food to maintain this level.")]
        [SettingPropertyGroup("Field Squire/Logistics")]
        public int FieldSquire_FoodThreshold { get; set; } = 20;


        [SettingPropertyBool("Enable Happy Party", Order = -1, RequireRestart = true, HintText = "Enable or disable Happy Party features.")]
        [SettingPropertyGroup("Happy Party", GroupOrder = 3)]
        public bool HappyParty_ModuleEnabled { get; set; } = true;

        [SettingPropertyBool("Debug Mode", Order = 0, RequireRestart = false, HintText = "Enable debug logging for AI decisions.")]
        [SettingPropertyGroup("Happy Party")]
        public bool HappyParty_DebugMode { get; set; } = false;

        [SettingPropertyBool("Enable 'Shoo' Dialogue", Order = 1, RequireRestart = false, HintText = "Enable the 'Don't you have somewhere to be?' dialogue option for wanderers.")]
        [SettingPropertyGroup("Happy Party")]
        public bool HappyParty_EnableShooOption { get; set; } = false;

        [SettingPropertyInteger("Target Wanderer Count", 10, 100, "0", Order = 1, RequireRestart = false, HintText = "Target number of wanderers in the world (min 10).")]
        [SettingPropertyGroup("Happy Party")]
        public int HappyParty_TargetWandererCount { get; set; } = 30;

        [SettingPropertyInteger("Daily Spawn Cap", 1, 50, "0", Order = 2, RequireRestart = false, HintText = "Maximum number of wanderers to spawn per day.")]
        [SettingPropertyGroup("Happy Party")]
        public int HappyParty_DailySpawnCap { get; set; } = 10;

        [SettingPropertyInteger("Troops Per Food Item", 1, 20, "0", Order = 3, RequireRestart = false, HintText = "The AI will try to buy 1 food item per X troops. Lower means more food.")]
        [SettingPropertyGroup("Happy Party")]
        public int HappyParty_TroopsPerFoodItem { get; set; } = 5;

        [SettingPropertyInteger("Job Seeker Hire Cost", 500, 10000, "0", Order = 4, RequireRestart = false, HintText = "Gold cost for an AI Lord to hire a specialist wanderer.")]
        [SettingPropertyGroup("Happy Party")]
        public int HappyParty_JobSeekerHireCost { get; set; } = 2000;

        [SettingPropertyInteger("Prisoner Ransom Modifier", 50, 200, "0", Order = 5, RequireRestart = false, HintText = "Percentage of ransom value AI receives (100 = full value).")]
        [SettingPropertyGroup("Happy Party")]
        public int HappyParty_PrisonerRansomModifier { get; set; } = 100;

        [SettingPropertyBool("Enable Honest Work", Order = -1, RequireRestart = true, HintText = "Enable or disable all Honest Work features.")]
        [SettingPropertyGroup("Honest Work/General", GroupOrder = 4)]
        public bool HonestWork_ModuleEnabled { get; set; } = true;

        [SettingPropertyInteger("Town Base Wage", 1, 100, "0 Gold", Order = 1, RequireRestart = false, HintText = "Base wage per hour for town jobs.")]
        [SettingPropertyGroup("Honest Work/General")]
        public int HonestWork_TownBaseWage { get; set; } = 10;

        [SettingPropertyFloatingInteger("Town Prosperity Divisor", 100f, 1000f, "0.0", Order = 2, RequireRestart = false, HintText = "Higher value means prosperity contributes less to wage.")]
        [SettingPropertyGroup("Honest Work/General")]
        public float HonestWork_TownProsperityDivisor { get; set; } = 250f;

        [SettingPropertyInteger("Shift Length", 1, 24, "0 Hours", Order = 3, RequireRestart = false, HintText = "Number of hours in a work shift.")]
        [SettingPropertyGroup("Honest Work/General")]
        public int HonestWork_ShiftHours { get; set; } = 4;

        [SettingPropertyFloatingInteger("Town Effect Magnitude", 0f, 10f, "0.00", Order = 4, RequireRestart = false, HintText = "Multiplier for town stat changes per hour.")]
        [SettingPropertyGroup("Honest Work/General")]
        public float HonestWork_TownEffectMagnitude { get; set; } = 0.2f;

        [SettingPropertyFloatingInteger("AI Effect Magnitude", 0f, 10f, "0.00", Order = 5, RequireRestart = false, HintText = "Multiplier for AI town stat changes per hour.")]
        [SettingPropertyGroup("Honest Work/General")]
        public float HonestWork_AiEffectMagnitude { get; set; } = 0.05f;

        [SettingPropertyBool("Enable Town Stat Increases", Order = 6, RequireRestart = false, HintText = "If disabled, jobs will not provide security, prosperity, loyalty, or militia increases.")]
        [SettingPropertyGroup("Honest Work/General")]
        public bool HonestWork_EnableTownStatIncreases { get; set; } = true;

        [SettingPropertyFloatingInteger("Hearth Wage Divisor", 1f, 100f, "0.0", Order = 6, RequireRestart = false, HintText = "Hearths divided by this equals hourly wage.")]
        [SettingPropertyGroup("Honest Work/General")]
        public float HonestWork_VillageHearthWageDivisor { get; set; } = 10f;

        [SettingPropertyFloatingInteger("Labor Hearth Gain", 0f, 5f, "0.0", Order = 7, RequireRestart = false, HintText = "Hearths gained per hour of labor.")]
        [SettingPropertyGroup("Honest Work/General")]
        public float HonestWork_VillageHearthGain { get; set; } = 0.1f;

        [SettingPropertyInteger("Town Job Base XP", 1, 500, "0 XP", Order = 8, RequireRestart = false, HintText = "Base XP gained per hour.")]
        [SettingPropertyGroup("Honest Work/General")]
        public int HonestWork_TownJobBaseXp { get; set; } = 50;

        [SettingPropertyInteger("Village Base XP", 1, 500, "0 XP", Order = 9, RequireRestart = false, HintText = "Base Athletics XP gained per hour in village.")]
        [SettingPropertyGroup("Honest Work/General")]
        public int HonestWork_VillageBaseXp { get; set; } = 50;

        [SettingPropertyFloatingInteger("XP Step Multiplier", 0f, 1f, "0.00", Order = 10, RequireRestart = false, HintText = "XP increase multiplier per interval. (e.g. 0.02 = +2% XP)")]
        [SettingPropertyGroup("Honest Work/General")]
        public float HonestWork_XpStepMultiplier { get; set; } = 0.02f;

        [SettingPropertyInteger("XP Increase Interval", 1, 24, "0 Hours", Order = 11, RequireRestart = false, HintText = "Hours required to trigger an XP increase.")]
        [SettingPropertyGroup("Honest Work/General")]
        public int HonestWork_XpIncreaseInterval { get; set; } = 4;

        // Honest Work: AI Settings
        [SettingPropertyBool("Enable AI in Villages", Order = 0, RequireRestart = false, HintText = "If disabled, AI will not work in villages.")]
        [SettingPropertyGroup("Honest Work/AI Settings")]
        public bool HonestWork_EnableAiVillages { get; set; } = true;

        [SettingPropertyBool("Enable AI in Castles", Order = 1, RequireRestart = false, HintText = "If disabled, AI will not drill in castles.")]
        [SettingPropertyGroup("Honest Work/AI Settings")]
        public bool HonestWork_EnableAiCastles { get; set; } = true;

        [SettingPropertyBool("Enable Noble Recruitment", Order = 2, RequireRestart = false, HintText = "If enabled, AI lords will camp at villages to recruit elites.")]
        [SettingPropertyGroup("Honest Work/AI Settings")]
        public bool HonestWork_EnableNobleFarming { get; set; } = true;

        [SettingPropertyFloatingInteger("Recruit Spawn Chance", 0f, 1f, "0%", Order = 3, RequireRestart = false, HintText = "Chance for an Elite recruit to spawn when Army accelerates growth.")]
        [SettingPropertyGroup("Honest Work/AI Settings")]
        public float HonestWork_EliteSpawnChance { get; set; } = 0.15f;

        // Honest Work: Seasonal Economy
        [SettingPropertyBool("Enable Seasonal Wages", Order = 0, RequireRestart = false, HintText = "If enabled, job wages fluctuate by season.")]
        [SettingPropertyGroup("Honest Work/Seasonal Economy")]
        public bool HonestWork_EnableSeasonalWages { get; set; } = true;

        [SettingPropertyFloatingInteger("Volatility", 0f, 2f, "0.0", Order = 1, RequireRestart = false, HintText = "Multiplier for wage fluctuation range.")]
        [SettingPropertyGroup("Honest Work/Seasonal Economy")]
        public float HonestWork_SeasonalVolatility { get; set; } = 1.0f;

        // Honest Work: Criminal Activity
        [SettingPropertyFloatingInteger("Arrest Risk Factor", 0f, 0.01f, "0.000", Order = 0, RequireRestart = false, HintText = "Base risk per point of Town Security.")]
        [SettingPropertyGroup("Honest Work/Criminal Activity")]
        public float HonestWork_ThugArrestBaseRisk { get; set; } = 0.001f;

        [SettingPropertyFloatingInteger("Roguery Safety Factor", 0f, 0.01f, "0.000", Order = 1, RequireRestart = false, HintText = "Risk reduction per point of Roguery.")]
        [SettingPropertyGroup("Honest Work/Criminal Activity")]
        public float HonestWork_ThugRoguerySafety { get; set; } = 0.0005f;

        [SettingPropertyBool("Owner Exemption", Order = 2, RequireRestart = false, HintText = "If enabled, you cannot be arrested in your own town.")]
        [SettingPropertyGroup("Honest Work/Criminal Activity")]
        public bool HonestWork_PlayerTownExemption { get; set; } = true;

        [SettingPropertyFloatingInteger("Arrest Roll Eyes Chance", 0.0f, 1.0f, "0.00", Order = 3, RequireRestart = false, HintText = "Chance for guards to ignore you if caught (Flavor).")]
        [SettingPropertyGroup("Honest Work/Criminal Activity")]
        public float HonestWork_ArrestRollEyesChance { get; set; } = 0.05f;

        // Honest Work: Job Wages
        [SettingPropertyFloatingInteger("Guard Wage Multiplier", 1.0f, 3.0f, "0.0", Order = 0, RequireRestart = false, HintText = "Wage multiplier for Guard jobs.")]
        [SettingPropertyGroup("Honest Work/Job Wages")]
        public float HonestWork_WageGuard { get; set; } = 1.0f;

        [SettingPropertyFloatingInteger("Thug Wage Multiplier", 1.0f, 3.0f, "0.0", Order = 1, RequireRestart = false, HintText = "Wage multiplier for Thug jobs (High due to risk).")]
        [SettingPropertyGroup("Honest Work/Job Wages")]
        public float HonestWork_WageThug { get; set; } = 1.5f;

        [SettingPropertyFloatingInteger("Artisan Wage Multiplier", 1.0f, 3.0f, "0.0", Order = 2, RequireRestart = false, HintText = "Wage multiplier for Artisan jobs.")]
        [SettingPropertyGroup("Honest Work/Job Wages")]
        public float HonestWork_WageArtisan { get; set; } = 1.1f;

        [SettingPropertyFloatingInteger("Official Wage Multiplier", 1.0f, 3.0f, "0.0", Order = 3, RequireRestart = false, HintText = "Wage multiplier for Official jobs.")]
        [SettingPropertyGroup("Honest Work/Job Wages")]
        public float HonestWork_WageOfficial { get; set; } = 1.2f;

        [SettingPropertyFloatingInteger("Physician Wage Multiplier", 1.0f, 3.0f, "0.0", Order = 4, RequireRestart = false, HintText = "Wage multiplier for Physician jobs.")]
        [SettingPropertyGroup("Honest Work/Job Wages")]
        public float HonestWork_WagePhysician { get; set; } = 1.2f;

        [SettingPropertyFloatingInteger("Instructor Wage Multiplier", 1.0f, 3.0f, "0.0", Order = 5, RequireRestart = false, HintText = "Wage multiplier for Instructor jobs.")]
        [SettingPropertyGroup("Honest Work/Job Wages")]
        public float HonestWork_WageInstructor { get; set; } = 1.0f;

        [SettingPropertyFloatingInteger("Outrider Wage Multiplier", 1.0f, 3.0f, "0.0", Order = 6, RequireRestart = false, HintText = "Wage multiplier for Outrider jobs.")]
        [SettingPropertyGroup("Honest Work/Job Wages")]
        public float HonestWork_WageOutrider { get; set; } = 1.1f;

        // Honest Work: XP Balancing
        [SettingPropertyInteger("Primary Skill XP", 10, 200, "0 XP", Order = 0, RequireRestart = false, HintText = "XP given to primary job skill per hour (e.g. Athletics for Guard).")]
        [SettingPropertyGroup("Honest Work/XP Balancing")]
        public int HonestWork_XpPrimary { get; set; } = 20;

        [SettingPropertyInteger("Secondary Skill XP", 10, 200, "0 XP", Order = 1, RequireRestart = false, HintText = "XP given to secondary/combat skill per hour.")]
        [SettingPropertyGroup("Honest Work/XP Balancing")]
        public int HonestWork_XpSecondary { get; set; } = 30;

        [SettingPropertyFloatingInteger("Companion Contribution Factor", 0.001f, 0.01f, "0.000", Order = 2, RequireRestart = false, HintText = "Multiplier for converting companion skill points into bonus efficiency.")]
        [SettingPropertyGroup("Honest Work/XP Balancing")]
        public float HonestWork_CompanionEfficiencyFactor { get; set; } = 0.001f;

        [SettingPropertyFloatingInteger("Troop XP Multiplier", 0.0f, 2.0f, "0.00", Order = 3, RequireRestart = false, HintText = "Multiplier for all troop XP given. 0 disables troop XP gains entirely.")]
        [SettingPropertyGroup("Honest Work/XP Balancing")]
        public float HonestWork_TroopXpMultiplier { get; set; } = 1.0f;

        // Honest Work: Shift Rewards
        [SettingPropertyInteger("Shift XP Bonus", 10, 500, "0 XP", Order = 0, RequireRestart = false, HintText = "Bonus XP assigned to Party/Garrison after a full shift.")]
        [SettingPropertyGroup("Honest Work/Shift Rewards")]
        public int HonestWork_ShiftXpBonus { get; set; } = 25;

        [SettingPropertyInteger("Official Food Bonus", 1, 50, "0 Items", Order = 1, RequireRestart = false, HintText = "Amount of food added to town by Official shift.")]
        [SettingPropertyGroup("Honest Work/Shift Rewards")]
        public int HonestWork_ShiftFoodBonus { get; set; } = 10;

        [SettingPropertyInteger("Relation Reward", 1, 10, "0 Rel", Order = 2, RequireRestart = false, HintText = "Relationship points gained with a notable per shift.")]
        [SettingPropertyGroup("Honest Work/Shift Rewards")]
        public int HonestWork_ShiftRelationBonus { get; set; } = 1;

        [SettingPropertyBool("Enable Town Item Rewards", Order = 3, RequireRestart = false, HintText = "If disabled, you will not receive a bonus item after finishing a shift in a town.")]
        [SettingPropertyGroup("Honest Work/Shift Rewards")]
        public bool HonestWork_EnableTownItemRewards { get; set; } = true;

        // Honest Work: Village Advanced
        [SettingPropertyFloatingInteger("AI Work Chance", 0.0f, 1.0f, "0.00", Order = 0, RequireRestart = false, HintText = "Hourly probability that an AI party will work in a village.")]
        [SettingPropertyGroup("Honest Work/Village Advanced")]
        public float HonestWork_AiWorkChance { get; set; } = 0.3f;

        [SettingPropertyFloatingInteger("Power Hearth Scalar", 0.0001f, 0.01f, "0.0000", Order = 1, RequireRestart = false, HintText = "Scaling factor for converting Party Tier Total into Hearth Growth.")]
        [SettingPropertyGroup("Honest Work/Village Advanced")]
        public float HonestWork_PowerHearthScalar { get; set; } = 0.0005f;

        [SettingPropertyFloatingInteger("Recruit Spawn Scalar", 0.00001f, 0.001f, "0.00000", Order = 2, RequireRestart = false, HintText = "Scaling factor for converting Party Tier Total into Recruit Spawn Chance.")]
        [SettingPropertyGroup("Honest Work/Village Advanced")]
        public float HonestWork_PowerRecruitScalar { get; set; } = 0.00005f;

        [SettingPropertyBool("Enable Siege Betrayal", Order = 3, RequireRestart = false, HintText = "If enabled, wanderers sharing the culture of besiegers will defect.")]
        [SettingPropertyGroup("Honest Work/Village Advanced")]
        public bool HonestWork_EnableSiegeBetrayal { get; set; } = true;

        [SettingPropertyBool("Enable Village Item Rewards", Order = 4, RequireRestart = false, HintText = "If disabled, you will not receive a bonus item after finishing a shift in a village.")]
        [SettingPropertyGroup("Honest Work/Village Advanced")]
        public bool HonestWork_EnableVillageItemRewards { get; set; } = true;


        [SettingPropertyBool("Enable Landlord", Order = -1, RequireRestart = true, HintText = "Enable or disable Landlord features.")]
        [SettingPropertyGroup("Landlord/General", GroupOrder = 5)]
        public bool Landlord_ModuleEnabled { get; set; } = true;

        [SettingPropertyBool("Debug Mode", Order = 0, RequireRestart = false, HintText = "Enable debug logging.")]
        [SettingPropertyGroup("Landlord/General")]
        public bool Landlord_DebugMode { get; set; } = true;

        [SettingPropertyInteger("Normal Plot Cost", 1000, 1000000, "0", Order = 1, RequireRestart = false, HintText = "Cost to purchase a Normal Plot.")]
        [SettingPropertyGroup("Landlord/Economy")]
        public int Landlord_NormalPlotCost { get; set; } = 10000;

        [SettingPropertyInteger("Good Plot Cost", 5000, 1000000, "0", Order = 2, RequireRestart = false, HintText = "Cost to purchase a Good Plot.")]
        [SettingPropertyGroup("Landlord/Economy")]
        public int Landlord_GoodPlotCost { get; set; } = 50000;

        [SettingPropertyInteger("Great Plot Cost", 10000, 1000000, "0", Order = 3, RequireRestart = false, HintText = "Cost to purchase a Great Plot.")]
        [SettingPropertyGroup("Landlord/Economy")]
        public int Landlord_GreatPlotCost { get; set; } = 100000;

        [SettingPropertyInteger("Change Production Cost", 0, 100000, "0", Order = 4, RequireRestart = false, HintText = "Cost to change production type.")]
        [SettingPropertyGroup("Landlord/Economy")]
        public int Landlord_ChangeProductionCost { get; set; } = 2000;

        [SettingPropertyFloatingInteger("Base Yield Multiplier", 1f, 20f, "0.0", Order = 0, RequireRestart = false, HintText = "Global multiplier for all production yields. Default: 8.0")]
        [SettingPropertyGroup("Landlord/Economy")]
        public float Landlord_BaseYieldMultiplier { get; set; } = 8.0f;

        [SettingPropertyFloatingInteger("Normal Plot Yield", 0.1f, 5f, "0.0", Order = 1, RequireRestart = false, HintText = "Yield multiplier for Normal Plots.")]
        [SettingPropertyGroup("Landlord/Economy")]
        public float Landlord_NormalYield { get; set; } = 1.0f;

        [SettingPropertyFloatingInteger("Good Plot Yield", 0.1f, 5f, "0.0", Order = 2, RequireRestart = false, HintText = "Yield multiplier for Good Plots.")]
        [SettingPropertyGroup("Landlord/Economy")]
        public float Landlord_GoodYield { get; set; } = 1.2f;

        [SettingPropertyFloatingInteger("Great Plot Yield", 0.1f, 5f, "0.0", Order = 3, RequireRestart = false, HintText = "Yield multiplier for Great Plots.")]
        [SettingPropertyGroup("Landlord/Economy")]
        public float Landlord_GreatYield { get; set; } = 1.5f;

        [SettingPropertyFloatingInteger("Village Stimulus Ratio", 0f, 1f, "0.0", Order = 4, RequireRestart = false, HintText = "Percentage of profit injected back into the village gold pool. Default: 0.5 (50%)")]
        [SettingPropertyGroup("Landlord/Economy")]
        public float Landlord_VillageStimulusRatio { get; set; } = 0.5f;

        [SettingPropertyInteger("Initial Investment Multiplier", 0, 100, "0", Order = 0, RequireRestart = false, HintText = "Multiplier for the item price included in the initial plot purchase cost (Default: 10x).")]
        [SettingPropertyGroup("Landlord/Economy")]
        public int Landlord_InitialInvestmentItemMultiplier { get; set; } = 10;

        [SettingPropertyFloatingInteger("Hearth Bonus Normal", 0f, 5f, "0.0", Order = 10, RequireRestart = false, HintText = "Daily hearth growth bonus for Normal Plots.")]
        [SettingPropertyGroup("Landlord/Economy")]
        public float Landlord_HearthBonusNormal { get; set; } = 0.1f;

        [SettingPropertyFloatingInteger("Hearth Bonus Good", 0f, 5f, "0.0", Order = 11, RequireRestart = false, HintText = "Daily hearth growth bonus for Good Plots.")]
        [SettingPropertyGroup("Landlord/Economy")]
        public float Landlord_HearthBonusGood { get; set; } = 0.2f;

        [SettingPropertyFloatingInteger("Hearth Bonus Great", 0f, 5f, "0.0", Order = 12, RequireRestart = false, HintText = "Daily hearth growth bonus for Great Plots.")]
        [SettingPropertyGroup("Landlord/Economy")]
        public float Landlord_HearthBonusGreat { get; set; } = 0.5f;

        [SettingPropertyFloatingInteger("Hearth Damage on Raze", 0f, 500f, "0.0", Order = 5, RequireRestart = false, HintText = "Hearth damage inflicted when a plot is razed.")]
        [SettingPropertyGroup("Landlord/Violence")]
        public float Landlord_HearthDamageOnRaze { get; set; } = 50.0f;

        [SettingPropertyInteger("Relation Penalty on Raze", 0, 100, "0", Order = 6, RequireRestart = false, HintText = "Relation penalty with the owner when a plot is razed.")]
        [SettingPropertyGroup("Landlord/Violence")]
        public int Landlord_RelationPenaltyOnRaze { get; set; } = 10;

        [SettingPropertyBool("Allow Livestock Production", Order = 10, RequireRestart = false, HintText = "Allow production of animals. WARNING: Balance Breaking.")]
        [SettingPropertyGroup("Landlord/Production Options")]
        public bool Landlord_AllowLivestock { get; set; } = false;

        [SettingPropertyBool("Allow Village Goods Production", Order = 11, RequireRestart = false, HintText = "Allow production of raw materials (Iron, Clay, etc). WARNING: Balance Breaking.")]
        [SettingPropertyGroup("Landlord/Production Options")]
        public bool Landlord_AllowVillageGoods { get; set; } = false;

        [SettingPropertyBool("Allow Pack Animals", Order = 12, RequireRestart = false, HintText = "Allow production of Pack Animals. WARNING: Balance Breaking.")]
        [SettingPropertyGroup("Landlord/Production Options")]
        public bool Landlord_AllowPack { get; set; } = false;

        [SettingPropertyBool("Allow Mounts", Order = 13, RequireRestart = false, HintText = "Allow production of Riding Horses. WARNING: Balance Breaking.")]
        [SettingPropertyGroup("Landlord/Production Options")]
        public bool Landlord_AllowMounts { get; set; } = false;

        [SettingPropertyBool("Allow War Mounts", Order = 14, RequireRestart = false, HintText = "Allow production of War Horses. WARNING: Balance Breaking.")]
        [SettingPropertyGroup("Landlord/Production Options")]
        public bool Landlord_AllowWarMounts { get; set; } = false;

        [SettingPropertyBool("Allow Noble Mounts", Order = 15, RequireRestart = false, HintText = "Allow production of Noble Horses. WARNING: Balance Breaking.")]
        [SettingPropertyGroup("Landlord/Production Options")]
        public bool Landlord_AllowNobleMounts { get; set; } = false;

        [SettingPropertyInteger("Base Upgrade Cost", 1000, 50000, "0", Order = 0, RequireRestart = false, HintText = "Base cost for upgrading Guardhouse per level.")]
        [SettingPropertyGroup("Landlord/Property Management")]
        public int Landlord_BaseUpgradeCost { get; set; } = 5000;

        [SettingPropertyInteger("Guard Cap Lvl 1", 10, 500, "0", Order = 1, RequireRestart = false, HintText = "Garrison capacity at Guardhouse Level 1.")]
        [SettingPropertyGroup("Landlord/Property Management")]
        public int Landlord_GuardCapLvl1 { get; set; } = 50;

        [SettingPropertyInteger("Guard Cap Lvl 2", 10, 1000, "0", Order = 2, RequireRestart = false, HintText = "Garrison capacity at Guardhouse Level 2.")]
        [SettingPropertyGroup("Landlord/Property Management")]
        public int Landlord_GuardCapLvl2 { get; set; } = 100;

        [SettingPropertyInteger("Guard Cap Lvl 3", 10, 2000, "0", Order = 3, RequireRestart = false, HintText = "Garrison capacity at Guardhouse Level 3.")]
        [SettingPropertyGroup("Landlord/Property Management")]
        public int Landlord_GuardCapLvl3 { get; set; } = 200;

        [SettingPropertyInteger("Stash Cap Lvl 1", 50, 1000, "0", Order = 4, RequireRestart = false, HintText = "Warehouse capacity at Guardhouse Level 1.")]
        [SettingPropertyGroup("Landlord/Property Management")]
        public int Landlord_StashCapLvl1 { get; set; } = 200;

        [SettingPropertyInteger("Stash Cap Lvl 2", 50, 2000, "0", Order = 5, RequireRestart = false, HintText = "Warehouse capacity at Guardhouse Level 2.")]
        [SettingPropertyGroup("Landlord/Property Management")]
        public int Landlord_StashCapLvl2 { get; set; } = 400;

        [SettingPropertyInteger("Stash Cap Lvl 3", 50, 5000, "0", Order = 6, RequireRestart = false, HintText = "Warehouse capacity at Guardhouse Level 3.")]
        [SettingPropertyGroup("Landlord/Property Management")]
        public int Landlord_StashCapLvl3 { get; set; } = 600;

        [SettingPropertyInteger("AI Buy Threshold", 10000, 10000000, "0", Order = 0, RequireRestart = false, HintText = "Gold required for AI Lords to consider buying land.")]
        [SettingPropertyGroup("Landlord/AI Settings")]
        public int Landlord_AIPlotBuyThreshold { get; set; } = 150000;

        [SettingPropertyBool("Enable Living Legend", Order = -1, RequireRestart = true, HintText = "Enable or disable Legend features.")]
        [SettingPropertyGroup("Living Legend/General", GroupOrder = 6)]
        public bool LivingLegend_ModuleEnabled { get; set; } = true;

        [SettingPropertyBool("Debug Mode", Order = 0, RequireRestart = false, HintText = "Enable debug logging.")]
        [SettingPropertyGroup("Living Legend/General")]
        public bool LivingLegend_DebugMode { get; set; } = false;

        [SettingPropertyInteger("Renown Threshold", 0, 100000, "0", Order = 1, RequireRestart = false, HintText = "Renown required to enter Legend status.")]
        [SettingPropertyGroup("Living Legend/Requirements")]
        public int LivingLegend_RenownThreshold { get; set; } = 6000;

        [SettingPropertyInteger("Daily Renown Cost", 0, 1000, "0", Order = 2, RequireRestart = false, HintText = "Daily renown cost for Legend status.")]
        [SettingPropertyGroup("Living Legend/Requirements")]
        public int LivingLegend_DailyRenownCost { get; set; } = 10;

        [SettingPropertyInteger("Call to Arms Cost", 0, 5000, "0", Order = 1, RequireRestart = false, HintText = "Renown cost to force a lord into your army.")]
        [SettingPropertyGroup("Living Legend/Costs")]
        public int LivingLegend_CallToArmsCost { get; set; } = 500;

        [SettingPropertyInteger("Rally Militia Cost", 0, 1000, "0", Order = 2, RequireRestart = false, HintText = "Renown cost to rally militia.")]
        [SettingPropertyGroup("Living Legend/Costs")]
        public int LivingLegend_RallyMilitiaCost { get; set; } = 200;

        [SettingPropertyInteger("Recruit Minor Faction Cost", 0, 10000, "0", Order = 3, RequireRestart = false, HintText = "Renown cost to recruit a minor faction leader.")]
        [SettingPropertyGroup("Living Legend/Costs")]
        public int LivingLegend_RecruitMinorFactionCost { get; set; } = 2000;

        [SettingPropertyInteger("Renown to Influence Ratio", 1, 100, "0", Order = 4, RequireRestart = false, HintText = "Renown cost per 1 Influence when recruiting armies.")]
        [SettingPropertyGroup("Living Legend/Costs")]
        public int LivingLegend_RenownToInfluenceCostFactor { get; set; } = 5;

        [SettingPropertyInteger("Call to Arms Relation Penalty", 0, 100, "0", Order = 5, RequireRestart = false, HintText = "Relation loss when forcing a lord to join your army.")]
        [SettingPropertyGroup("Living Legend/Costs")]
        public int LivingLegend_CallToArmsRelationPenalty { get; set; } = 5;

        [SettingPropertyInteger("Militia Patrol Duration", 1, 30, "0 days", Order = 1, RequireRestart = false, HintText = "Days a militia patrol lasts.")]
        [SettingPropertyGroup("Living Legend/Militia")]
        public int LivingLegend_MilitiaPatrolDuration { get; set; } = 5;

        [SettingPropertyInteger("Militia Troop Count", 1, 200, "0", Order = 2, RequireRestart = false, HintText = "Number of troops in a militia patrol.")]
        [SettingPropertyGroup("Living Legend/Militia")]
        public int LivingLegend_MilitiaTroopCount { get; set; } = 40;

        [SettingPropertyBool("AI Enable Legend Logic", Order = 0, RequireRestart = false, HintText = "If disabled, AI lords will never use Legend mechanics.")]
        [SettingPropertyGroup("Living Legend/AI")]
        public bool LivingLegend_AI_EnableLegendLogic { get; set; } = true;

        [SettingPropertyInteger("AI Min Renown For Rally", 0, 50000, "0", Order = 1, RequireRestart = false, HintText = "Renown threshold for AI clans to start spending renown on rallies.")]
        [SettingPropertyGroup("Living Legend/AI")]
        public int LivingLegend_AI_MinRenownForRally { get; set; } = 6500;

        [SettingPropertyFloatingInteger("AI Rally Chance", 0.0f, 1.0f, "0.00%", Order = 2, RequireRestart = false, HintText = "Daily chance for an eligible AI to rally militia.")]
        [SettingPropertyGroup("Living Legend/AI")]
        public float LivingLegend_AI_RallyChance { get; set; } = 0.05f;

        [SettingPropertyInteger("Companion Limit Divisor", 100, 10000, "0", Order = 0, RequireRestart = false, HintText = "Renown amount above threshold required to gain +1 Companion slot.")]
        [SettingPropertyGroup("Living Legend/Bonuses")]
        public int LivingLegend_CompanionLimitRenownDivisor { get; set; } = 1000;

        [SettingPropertyFloatingInteger("Legend Militia Bonus", 0.0f, 10.0f, "0.0", Order = 1, RequireRestart = false, HintText = "Daily militia growth bonus from Legend's Aura.")]
        [SettingPropertyGroup("Living Legend/Bonuses")]
        public float LivingLegend_LegendMilitiaBonus { get; set; } = 1.0f;

        [SettingPropertyFloatingInteger("Legend Loyalty Bonus", 0.0f, 10.0f, "0.0", Order = 2, RequireRestart = false, HintText = "Daily loyalty bonus from Legend's Aura.")]
        [SettingPropertyGroup("Living Legend/Bonuses")]
        public float LivingLegend_LegendLoyaltyBonus { get; set; } = 2.0f;

        [SettingPropertyBool("Enable New Clans", Order = -1, RequireRestart = true, HintText = "Enable or disable New Clans features.")]
        [SettingPropertyGroup("New Clans/General", GroupOrder = 7)]
        public bool NewClans_ModuleEnabled { get; set; } = true;

        [SettingPropertyInteger("Promotion Cost", 10000, 10000000, "0", Order = 1, RequireRestart = false, HintText = "The cost to promote a companion to a noble house.")]
        [SettingPropertyGroup("New Clans/General")]
        public int NewClans_PromotionCost { get; set; } = 1000000;

        [SettingPropertyBool("Debug Mode", Order = 2, RequireRestart = false, HintText = "Enable detailed logging.")]
        [SettingPropertyGroup("New Clans/General")]
        public bool NewClans_DebugMode { get; set; } = false;
        [SettingPropertyInteger("AI Min Tier", 1, 6, "0", Order = 3, RequireRestart = false, HintText = "Minimum Clan Tier for AI clans to consider promoting a companion.")]
        [SettingPropertyGroup("New Clans/AI Settings")]
        public int NewClans_AiMinTier { get; set; } = 6;

        [SettingPropertyInteger("AI Min Gold", 100000, 10000000, "0", Order = 4, RequireRestart = false, HintText = "Minimum Gold for AI clans to consider promoting a companion.")]
        [SettingPropertyGroup("New Clans/AI Settings")]
        public int NewClans_AiMinGold { get; set; } = 3000000;

        [SettingPropertyInteger("AI Min Fiefs", 1, 20, "0", Order = 5, RequireRestart = false, HintText = "Minimum Fiefs owned for AI clans to consider promoting a companion.")]
        [SettingPropertyGroup("New Clans/AI Settings")]
        public int NewClans_AiMinFiefs { get; set; } = 5;
    }
}
