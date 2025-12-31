using TaleWorlds.CampaignSystem;
using System.Collections.Generic;
using LudusMagnus.Core;
using Serilog;
using Microsoft.Extensions.Logging;

namespace LudusMagnus.Economy
{
    public class LudusEconomyBehavior : CampaignBehaviorBase
    {
        private LudusMarketModel _marketModel;

        public LudusEconomyBehavior()
        {
            _marketModel = new LudusMarketModel();
        }

        public override void RegisterEvents()
        {
            CampaignEvents.DailyTickEvent.AddNonSerializedListener(this, OnDailyTick);
        }

        public override void SyncData(IDataStore dataStore)
        {
            if (LudusManager.Instance == null) return;
            
            var registry = LudusManager.Instance.LudusRegistry;
            dataStore.SyncData("_ludusRegistry", ref registry);

            if (dataStore.IsLoading)
            {
                if (registry == null) registry = new Dictionary<Hero, LudusLocation>();
                LudusManager.Instance.LudusRegistry = registry;
            }
        }

        private void OnDailyTick()
        {
            if (LudusManager.Instance == null) return;

            foreach (var kvp in LudusManager.Instance.LudusRegistry)
            {
                LudusLocation ludus = kvp.Value;
                if (ludus.Owner?.Clan == null) continue;

                // 1. Ticket Sales
                int income = _marketModel.CalculateTicketSales(ludus.Owner.Clan);
                if (income > 0)
                {
                    ludus.Owner.Clan.Leader.ChangeHeroGold(income);
                    LudusSubModule.InstanceLogger?.LogDebug("Ludus {Ludus} generated {Income} ticket sales for {Clan}.", ludus.Settlement?.Name, income, ludus.Owner.Clan.Name);
                }

                // 2. Training Fees
                // Logic: Find all parties waiting at Ludus settlement not owned by player.
                if (ludus.Settlement != null)
                {
                    foreach (var party in ludus.Settlement.Parties)
                    {
                        if (party.LeaderHero != null && party.LeaderHero.Clan != ludus.Owner.Clan)
                        {
                            // It's a customer! Charge them.
                            int fee = 50; // Flat fee for now
                            if (party.LeaderHero.Gold >= fee)
                            {
                                party.LeaderHero.ChangeHeroGold(-fee);
                                ludus.Owner.Clan.Leader.ChangeHeroGold(fee);
                                LudusSubModule.InstanceLogger?.LogTrace("Collected {Fee} training fee from {Party} (Leader: {Leader}) at {Ludus}.", fee, party.Name, party.LeaderHero.Name, ludus.Settlement.Name);
                            }
                        }
                    }
                }
            }
        }
    }
}
