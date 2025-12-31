using System;
using System.Linq;
using System.Collections.Generic;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.Conversation;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Roster;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;
using TaleWorlds.ObjectSystem;
using Serilog;

namespace NewClans
{
    public class NewClansBehavior : CampaignBehaviorBase
    {
        private readonly ILogger _logger;
        private readonly GlobalSettings _settings;

        public NewClansBehavior(ILogger logger, GlobalSettings settings)
        {
            _logger = logger;
            _settings = settings;
        }

        public override void RegisterEvents()
        {
            CampaignEvents.OnSessionLaunchedEvent.AddNonSerializedListener(this, OnSessionLaunched);
            CampaignEvents.WeeklyTickEvent.AddNonSerializedListener(this, OnWeeklyTick);
        }

        public override void SyncData(IDataStore dataStore)
        {
        }

        private void OnSessionLaunched(CampaignGameStarter campaignGameStarter)
        {
            _logger.Information("NewClans: OnSessionLaunched");
            campaignGameStarter.AddPlayerLine(
                "companion_promote_offer",
                "hero_main_options",
                "companion_promote_response",
                "I want to sponsor your promotion to a noble house. (Cost: {COST} Denars).".Replace("{COST}", _settings.PromotionCost.ToString("N0")),
                companion_promote_condition,
                companion_promote_consequence,
                100,
                null
            );

            campaignGameStarter.AddDialogLine(
                "companion_promote_response_text",
                "companion_promote_response",
                "close_window",
                "I am honored, my lord! I shall serve you and the realm with dignity.",
                null,
                null
            );


        }



        private bool companion_promote_condition()
        {
            if (Hero.OneToOneConversationHero == null) return false;

            // Check if target is a companion in player's party and not family
            bool isCompanion = Hero.OneToOneConversationHero.IsPlayerCompanion;
            
            if (!isCompanion) return false;

            // Check player gold
            if (Hero.MainHero.Gold < _settings.PromotionCost) return false;

            // Check player is a vassal but not the faction leader
            if (Clan.PlayerClan.Kingdom == null) return false;
            if (Clan.PlayerClan.Kingdom.Leader == Hero.MainHero) return false;

            return true;
        }

        private void companion_promote_consequence()
        {
            try
            {
                Hero companion = Hero.OneToOneConversationHero;
                Hero player = Hero.MainHero;
                Kingdom kingdom = player.Clan.Kingdom;
                Hero factionLeader = kingdom.Leader;

                _logger.Information("Promoting {Companion} in {Kingdom}", companion.Name, kingdom.Name);

                // 1. Deduct gold from Player
                GiveGoldAction.ApplyBetweenCharacters(player, null, _settings.PromotionCost, true);

                // 2. Give gold to Faction Leader
                GiveGoldAction.ApplyBetweenCharacters(null, factionLeader, _settings.PromotionCost, true);

                // 3. Find Settlement to take
                Settlement settlementToTake = null;
                Clan sourceClan = null;

                // Priority A: Take from a "Greedy" clan (lots of fiefs)
                var clans = kingdom.Clans.Where(c => c != Clan.PlayerClan && c != factionLeader.Clan && !c.IsEliminated).ToList();
                var greedyClan = clans.OrderByDescending(c => c.Settlements.Count).FirstOrDefault();

                if (greedyClan != null && greedyClan.Settlements.Count > 0)
                {
                    // Prioritize castles, then towns. MUST be a fortification, not a village.
                    settlementToTake = greedyClan.Settlements.FirstOrDefault(s => s.IsCastle);
                    if (settlementToTake == null)
                    {
                        settlementToTake = greedyClan.Settlements.FirstOrDefault(s => s.IsTown);
                    }
                    
                    if (settlementToTake != null)
                    {
                        sourceClan = greedyClan;
                    }
                }

                // Priority B: Fallback to Player Clan if valid
                if (settlementToTake == null && player.Clan.Settlements.Count > 0)
                {
                    if (_settings.DebugMode) _logger.Information("No greedy clan found. User must provide fief.");
                     // Check if player has enough to spare? User has 11, so yes.
                     // We take a castle if possible, else town.
                    settlementToTake = player.Clan.Settlements.FirstOrDefault(s => s.IsCastle);
                    if (settlementToTake == null)
                    {
                        settlementToTake = player.Clan.Settlements.FirstOrDefault(s => s.IsTown);
                    }

                    if (settlementToTake != null)
                    {
                        sourceClan = player.Clan;
                    }
                }

                if (settlementToTake != null && sourceClan != null)
                {
                    _logger.Information("Taking {Settlement} from {SourceClan}", settlementToTake.Name, sourceClan.Name);
                    // 4. Promote the Companion
                    string clanName = companion.Name.ToString() + "'s Clan";
                    int iconId = companion.StringId.GetHashCode();
                    
                    Clan.CreateCompanionToLordClan(companion, settlementToTake, new TextObject(clanName), iconId);
                    _logger.Information("Created new clan: {ClanName}", clanName);

                    // 5. Ensure Companion leaves player party
                    // 5. Ensure Companion leaves player party
                    if (MobileParty.MainParty.MemberRoster.Contains(companion.CharacterObject))
                    {
                        try 
                        {
                            MobileParty.MainParty.MemberRoster.RemoveTroop(companion.CharacterObject, 1);
                            if (_settings.DebugMode) _logger.Information("Removed {Companion} from MainParty roster.", companion.Name);
                        } 
                        catch (Exception ex) 
                        {
                             _logger.Error(ex, "Error removing from roster");
                        }
                    }

                    // 6. Move to their new fief
                    if (settlementToTake != null)
                    {
                         try
                         {
                             // Teleport them to the settlement clearly
                             TeleportHeroAction.ApplyImmediateTeleportToSettlement(companion, settlementToTake);
                             _logger.Information("Teleported {Companion} to {Settlement}", companion.Name, settlementToTake.Name);
                         }
                         catch (Exception ex)
                         {
                             _logger.Error(ex, "Error moving companion (Teleport)");
                         }
                    }
                }
                else
                {
                    _logger.Warning("No suitable fief found (Fortification required). Refunding.");
                    GiveGoldAction.ApplyBetweenCharacters(null, player, _settings.PromotionCost, true);
                    GiveGoldAction.ApplyBetweenCharacters(factionLeader, null, _settings.PromotionCost, true);
                    InformationManager.DisplayMessage(new InformationMessage("No suitable fief found for promotion! Refunding."));
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error during companion promotion sequence");
            }
        }



        private void OnWeeklyTick()
        {
             // AI Logic: Check for Wealthy Clans triggering fission
             foreach(var clan in Clan.All)
             {
                 if (clan == Clan.PlayerClan) continue;
                 if (clan.IsEliminated || clan.IsBanditFaction || clan.Kingdom == null) continue;
                 
                 // Criteria: Very Rich, High Tier, Many Fiefs
                 if (clan.Tier >= 5 && clan.Gold > 2000000 && clan.Settlements.Count >= 3)
                 {
                     ManageAiPromotion(clan);
                 }
             }
        }

        private void ManageAiPromotion(Clan clan)
        {
            // Find a companion to promote
            // AI Clans usually don't keep "Companions" in roster?
            // They have "Heroes" (Family/Lords).
            // Do AI Lords hire wanderers? 
            // LudusMagnus/LudusAiManagementBehavior hires staff (wanderers) but they stay in Ludus.
            // Regular AI Lords don't usually hire wanderers unless modded (HappyParty?).
            // If they have a wanderer in their party/clan who is NOT family:
            
            var candidates = clan.Companions.Where(h => 
                h.IsAlive && 
                h.IsPlayerCompanion == false && // "PlayerCompanion" flag might be false for AI?
                h.IsWanderer && 
                !h.IsLord).ToList(); // Ensure not already noble

            if (candidates.Count == 0) return;

            Hero candidate = candidates.GetRandomElement();
            
            // Fief to give: One of their own Castles
            Settlement fief = clan.Settlements.FirstOrDefault(s => s.IsCastle);
            if (fief == null) return;

            // Cost
            int cost = _settings.PromotionCost;
            if (clan.Gold < cost * 2) return; // Safety buffer

            // Action
            if (MBRandom.RandomFloat < 0.1f) // 10% chance per week if conditions met
            {
                // Pay gold to Kingdom Leader (or sink if leader)
                Hero king = clan.Kingdom.Leader;
                if (king != null && king != clan.Leader)
                {
                    GiveGoldAction.ApplyBetweenCharacters(clan.Leader, king, cost, true);
                }
                else
                {
                    GiveGoldAction.ApplyBetweenCharacters(clan.Leader, null, cost, true); // Sink
                }

                // Promote
                PerformPromotion(candidate, fief);
                if (_settings.DebugMode)
                    _logger.Information($"[NewClans AI] {clan.Name} promoted {candidate.Name} to new clan with {fief.Name}.");
            }
        }

        private void PerformPromotion(Hero companion, Settlement fief)
        {
             try
             {
                 string clanName = companion.Name.ToString() + "'s Clan";
                 int iconId = companion.StringId.GetHashCode();
                 
                 Clan.CreateCompanionToLordClan(companion, fief, new TextObject(clanName), iconId);
                 
                 // Ensure removed from old party logic handled by game usually, but good to check
                 if (companion.PartyBelongedTo != null)
                 {
                      // If leading a party, the party becomes the new clan's party automatically?
                      // If in a party, they leave.
                 }
                 
                 _logger.Information($"Created new clan: {clanName}");
             }
             catch (Exception ex)
             {
                 _logger.Error(ex, "Error promoting AI companion");
             }
        }
}
}
