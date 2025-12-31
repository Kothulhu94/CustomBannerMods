using System.Collections.Generic;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.Core;
using TaleWorlds.Library;
using LudusMagnus.Core;
using Serilog;
using Microsoft.Extensions.Logging;

namespace LudusMagnus.Economy
{
    public class LudusDraftDayBehavior : CampaignBehaviorBase
    {
        public override void RegisterEvents()
        {
            CampaignEvents.DailyTickEvent.AddNonSerializedListener(this, OnDailyTick);
        }

        public override void SyncData(IDataStore dataStore) { }

        private void OnDailyTick()
        {
            if (CampaignTime.Now.GetDayOfYear != 1) return; // Only on Spring 1st

            if (LudusManager.Instance == null) return;

            LudusSubModule.InstanceLogger?.LogInformation("LudusDraftDay: Commencing Annual Draft Day.");

            foreach (var kvp in LudusManager.Instance.GetAllLudusLocations())
            {
                var ludus = kvp.Value;
                if (ludus.State != LudusState.Active || ludus.Residents == null || ludus.Residents.Count == 0) continue;

                RunDraftForLudus(ludus);
            }
        }

        private void RunDraftForLudus(LudusLocation ludus)
        {
            // Find potential buyers
            var buyers = Clan.All.Where(c => 
                c != ludus.Owner.Clan && 
                !c.IsEliminated && 
                c.Leader != null && 
                c.Tier >= 4 && 
                c.Leader.Gold > 500000).ToList();

            if (buyers.Count == 0) return;

            // Iterate residents backwards so we can remove
            for (int i = ludus.Residents.Count - 1; i >= 0; i--)
            {
                var wanderer = ludus.Residents[i];
                if (wanderer.IsDead) 
                {
                    ludus.Residents.RemoveAt(i);
                    continue;
                }

                int price = wanderer.Level * 10000;
                
                // Pick a random buyer
                var buyer = buyers.GetRandomElement();
                if (buyer != null && buyer.Leader.Gold >= price)
                {
                    SellWanderer(wanderer, buyer, ludus.Owner, price);
                    ludus.Residents.RemoveAt(i);

                    LudusSubModule.InstanceLogger?.LogInformation("Draft Day: {Wanderer} sold to {BuyerClan} for {Price} gold at {Ludus}.", 
                        wanderer.Name, buyer.Name, price, ludus.Settlement?.Name);

                    if (ludus.Owner == Hero.MainHero)
                    {
                        InformationManager.DisplayMessage(new InformationMessage($"Draft Day: {wanderer.Name} sold to {buyer.Name} for {price} gold!", Colors.Green));
                    }
                }
            }
        }

        private void SellWanderer(Hero wanderer, Clan newClan, Hero seller, int price)
        {
            GiveGoldAction.ApplyBetweenCharacters(newClan.Leader, seller, price);
            AddCompanionAction.Apply(newClan, wanderer);
            
            if (newClan.Leader.PartyBelongedTo != null)
            {
                TeleportHeroAction.ApplyImmediateTeleportToParty(wanderer, newClan.Leader.PartyBelongedTo);
            }
        }
    }
}
