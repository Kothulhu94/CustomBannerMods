using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.CharacterDevelopment;
using TaleWorlds.Core;
using FieldSquire.Behaviors;

namespace FieldSquire.Patches
{
    [HarmonyPatch(typeof(HeroDeveloper), "AddSkillXp")]
    public class SquireXpSharePatch
    {
        private static bool _isInternalXpAdd = false;

        [HarmonyPostfix]
        public static void Postfix(HeroDeveloper __instance, SkillObject skill, float xp, bool isInternal, bool isSkillLevelUp)
        {
            // Recursion guard
            if (_isInternalXpAdd || isInternal) return;

            // Only share if the gain is for the Main Hero and it's Stewardship
            if (__instance.Hero == Hero.MainHero && skill == DefaultSkills.Steward && xp > 0.01f)
            {
                var squire = SquireSpawnBehavior.GetActiveSquire();
                
                // Only share if Squire is in the same party
                if (squire != null && squire.IsAlive && squire.PartyBelongedTo == Hero.MainHero.PartyBelongedTo)
                {
                    try
                    {
                        _isInternalXpAdd = true;

                        float playerLearningRate = 1f;
                        if (Campaign.Current?.Models?.CharacterDevelopmentModel != null)
                        {
                            var model = Campaign.Current.Models.CharacterDevelopmentModel;
                            var hero = __instance.Hero;
                            
                            // Pass the exact properties the 5-parameter signature expects
                            playerLearningRate = model.CalculateLearningRate(
                                hero.CharacterAttributes, 
                                __instance.GetFocus(skill), 
                                hero.GetSkillValue(skill), 
                                skill, 
                                false
                            ).ResultNumber;
                        }
                        
                        if (playerLearningRate <= 0.01f) playerLearningRate = 1f;

                        // Calculate the "raw" XP value before player modifiers
                        float rawXp = xp / playerLearningRate;
                        
                        // Take 50% of the raw value
                        float rawShare = rawXp * 0.5f;
                        
                        // Add to Squire. The Squire's HeroDeveloper applies its own LR to this raw amount.
                        squire.AddSkillXp(skill, rawShare);
                    }
                    catch (System.Exception ex)
                    {
                        FieldSquireSubModule.Logger?.Error(ex, "Error in SquireXpSharePatch");
                    }
                    finally
                    {
                        _isInternalXpAdd = false;
                    }
                }
            }
        }

        public static void Apply(Harmony harmony)
        {
            // Explicit apply if needed
        }
    }
}