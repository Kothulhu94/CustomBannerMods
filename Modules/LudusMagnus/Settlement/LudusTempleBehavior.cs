using System;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.Core;
using LudusMagnus.Core;

namespace LudusMagnus.Settlements
{
    public class LudusTempleBehavior : CampaignBehaviorBase
    {
        public override void RegisterEvents()
        {
            CampaignEvents.DailyTickEvent.AddNonSerializedListener(this, OnDailyTick);
        }

        public override void SyncData(IDataStore dataStore) { }

        private void OnDailyTick()
        {
            if (LudusManager.Instance == null) return;

            foreach (var kvp in LudusManager.Instance.LudusRegistry)
            {
                var ludus = kvp.Value;
                if (ludus.State != LudusState.Active || ludus.Settlement == null) continue;

                if (ludus.Facilities.TryGetValue(FacilityType.Temple, out int level))
                {
                    ApplyTempleEffects(ludus, level);
                }
            }
        }

        private void ApplyTempleEffects(LudusLocation ludus, int level)
        {
            if (level <= 0) return;

            // 1. Influence Gain (Owner Clan)
            if (ludus.Owner != null && ludus.Owner.Clan != null)
            {
                float influenceGain = 0.5f * level;
                ChangeClanInfluenceAction.Apply(ludus.Owner.Clan, influenceGain);
            }

            // 2. Morale Gain (Garrison & Sentinels)
            float moraleGain = 2f * level;

            // Garrison
            if (ludus.Settlement.Town != null && ludus.Settlement.Town.GarrisonParty != null)
            {
                ludus.Settlement.Town.GarrisonParty.RecentEventsMorale += moraleGain;
            }

            // Sentinels (Venatores)
            // Find all sentinels attached to this Ludus
             foreach (var party in MobileParty.All)
            {
                if (party.IsActive && 
                    party.StringId.Contains("ludus_sentinel") && 
                    party.HomeSettlement == ludus.Settlement)
                {
                    party.RecentEventsMorale += moraleGain;
                }
            }
        }
    }
}
