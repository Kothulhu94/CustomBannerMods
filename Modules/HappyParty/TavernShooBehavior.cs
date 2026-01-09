using System;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Party.PartyComponents;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;

namespace HappyParty
{
    public class TavernShooBehavior : CampaignBehaviorBase
    {
        public override void RegisterEvents()
        {
            CampaignEvents.OnSessionLaunchedEvent.AddNonSerializedListener(this, OnSessionLaunched);
        }

        public override void SyncData(IDataStore dataStore) { }

        private void OnSessionLaunched(CampaignGameStarter starter)
        {
            AddDialogs(starter);
        }

        private void AddDialogs(CampaignGameStarter starter)
        {
            // Player asks: "Don't you have somewhere to be?"
            starter.AddPlayerLine(
                "happyparty_shoo_ask",
                "hero_main_options",
                "happyparty_shoo_response",
                "Don't you have somewhere to be?",
                Condition_Shoo_OnCondition,
                null,
                100, // Priority
                null
            );

            // Hero responds: "You're right..." and leaves
            starter.AddDialogLine(
                "happyparty_shoo_reponse",
                "happyparty_shoo_response",
                "close_window",
                "You're right, I should move on.",
                null,
                Consequence_Shoo_OnConsequence,
                100,
                null
            );
        }

        private bool Condition_Shoo_OnCondition()
        {
            if (Hero.OneToOneConversationHero == null) return false;

            Hero hero = Hero.OneToOneConversationHero;

            // Only valid for Wanderers or Noble Lords
            bool isTargetType = hero.IsWanderer || hero.Occupation == Occupation.Lord;
            if (!isTargetType) return false;

            // Must NOT be in player's party
            if (hero.PartyBelongedTo == MobileParty.MainParty) return false;

            // Must NOT be invalid
            if (hero.IsPrisoner || hero.HeroState == Hero.CharacterStates.Dead || hero.HeroState == Hero.CharacterStates.Disabled) return false;

            // Must be in a settlement location (implied by conversation usually, but safety check)
            if (Settlement.CurrentSettlement == null) return false;

            return true;
        }

        private void Consequence_Shoo_OnConsequence()
        {
            Hero hero = Hero.OneToOneConversationHero;
            if (hero == null) return;

            // Logic adapted from TavernCleanerBehavior
             MobileParty targetParty = null;

            // 1. Try to join Clan Leader
            if (hero.Clan != null && hero.Clan.Leader != null && 
                hero.Clan.Leader.PartyBelongedTo != null && 
                hero.Clan.Leader.PartyBelongedTo.IsActive)
            {
                targetParty = hero.Clan.Leader.PartyBelongedTo;
            }

            // 2. Try to join any Clan War Party
            if (targetParty == null && hero.Clan != null)
            {
                foreach(var warParty in hero.Clan.WarPartyComponents)
                {
                    if (warParty.MobileParty != null && warParty.MobileParty.IsActive)
                    {
                        targetParty = warParty.MobileParty;
                        break; 
                    }
                }
            }

            if (targetParty != null)
            {
                LeaveSettlementAction.ApplyForCharacterOnly(hero);
                AddHeroToPartyAction.Apply(hero, targetParty);
                InformationManager.DisplayMessage(new InformationMessage($"{hero.Name} has joined {targetParty.Name}."));
            }
            else if (hero.IsWanderer && hero.Clan != null)
            {
                // 3. Spawn New Party (Wanderers only)
                try
                {
                    MobileParty newParty = LordPartyComponent.CreateLordParty(
                        hero.StringId + "_party_" + MBRandom.RandomInt(10000), 
                        hero,
                        Settlement.CurrentSettlement.GatePosition, 
                        5f,
                        Settlement.CurrentSettlement,
                        hero
                    );

                    if (newParty != null)
                    {
                        CharacterObject recruit = hero.Culture.BasicTroop;
                        if (recruit != null)
                        {
                            newParty.MemberRoster.AddToCounts(recruit, 20);
                        }
                        newParty.ItemRoster.AddToCounts(DefaultItems.Grain, 20);
                        newParty.SetMoveModeHold();
                        
                        InformationManager.DisplayMessage(new InformationMessage($"{hero.Name} has formed a new party."));
                    }
                }
                catch (Exception ex)
                {
                    InformationManager.DisplayMessage(new InformationMessage($"Failed to spawn party for {hero.Name}."));
                }
            }
            else
            {
                // Fallback: Just leave settlement to world map (They might just sit there or despawn if not handled, but they are out of the tavern)
                LeaveSettlementAction.ApplyForCharacterOnly(hero);
                InformationManager.DisplayMessage(new InformationMessage($"{hero.Name} has left the settlement."));
            }
        }
    }
}
