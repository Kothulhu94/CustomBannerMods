using System.Collections.Generic;
using TaleWorlds.CampaignSystem;
using TaleWorlds.SaveSystem;
using TaleWorlds.CampaignSystem.Roster;
using TaleWorlds.CampaignSystem.Settlements;

namespace LudusMagnus.Core
{
    public class LudusLocation
    {
        [SaveableProperty(1)]
        public Hero Owner { get; set; }

        [SaveableProperty(2)]
        public LudusState State { get; set; }

        [SaveableProperty(3)]
        public Dictionary<FacilityType, int> Facilities { get; set; }

        [SaveableProperty(4)]
        public Dictionary<StaffRole, Hero> Staff { get; set; }

        [SaveableProperty(7)]
        public List<Hero> Residents { get; set; }

        public LudusLocation(Hero owner)
        {
            Owner = owner;
            State = LudusState.Building;
            Facilities = new Dictionary<FacilityType, int>();
            Staff = new Dictionary<StaffRole, Hero>();
        }
        
        // Default constructor for SaveSystem
        public LudusLocation()
        {
            Facilities = new Dictionary<FacilityType, int>();
            Staff = new Dictionary<StaffRole, Hero>();
        }

        [SaveableProperty(5)]
        public string SettlementId { get; set; }

        [SaveableProperty(6)]
        public ItemRoster Storage { get; set; }

        public TaleWorlds.CampaignSystem.Settlements.Settlement Settlement => TaleWorlds.CampaignSystem.Settlements.Settlement.Find(SettlementId);
    }
}
