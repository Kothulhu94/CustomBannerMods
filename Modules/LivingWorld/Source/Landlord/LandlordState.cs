using System.Collections.Generic;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Roster;
using TaleWorlds.SaveSystem;

namespace Landlord
{
    public class VillagePlot
    {
        [SaveableField(1)]
        public string VillageStringId;

        [SaveableField(2)]
        public int SlotIndex;

        [SaveableField(3)]
        public Hero Owner;

        [SaveableField(4)]
        public string ProductionId;

        [SaveableField(5)]
        public int WageLevel;

        [SaveableField(6)]
        public int GuardhouseLevel; // 0=None, 1-3=Upgrades

        [SaveableField(7)]
        public int StashYieldPct; // 0, 25, 50, 75, 100

        [SaveableField(8)]
        public TroopRoster Garrison;

        [SaveableField(9)]
        public ItemRoster Stash;

        [SaveableField(10)]
        public int LastDailyIncome;

        public VillagePlot()
        {
            Garrison = TroopRoster.CreateDummyTroopRoster();
            Stash = new ItemRoster();
        }
    }

    public class VillageWealthData
    {
        [SaveableField(1)]
        public string VillageId;

        [SaveableField(2)]
        public float MilitiaBonus;

        [SaveableField(3)]
        public string PatrolPartyId;

        [SaveableField(4)]
        public int PatrolCapacity;

        [SaveableField(5)]
        public CampaignTime LastPurchaseDate;

        public VillageWealthData()
        {
            PatrolCapacity = 15;
            LastPurchaseDate = CampaignTime.Never;
        }

        public VillageWealthData(string villageId) : this()
        {
            VillageId = villageId;
        }
    }

    public class LandlordManager
    {
        private Dictionary<string, List<VillagePlot>> _globalPlots;
        public Dictionary<string, List<VillagePlot>> GlobalPlots => _globalPlots;

        private Dictionary<string, VillageWealthData> _villageWealthValues;
        public Dictionary<string, VillageWealthData> VillageWealthValues => _villageWealthValues;

        private static LandlordManager _instance;
        public static LandlordManager Instance
        {
            get
            {
                if (_instance == null) _instance = new LandlordManager();
                return _instance;
            }
        }

        public VillagePlot SelectedPlot { get; set; }

        public LandlordManager()
        {
            _globalPlots = new Dictionary<string, List<VillagePlot>>();
            _villageWealthValues = new Dictionary<string, VillageWealthData>();
        }

        public void SetPlots(Dictionary<string, List<VillagePlot>> plots) 
        { 
            _globalPlots = plots; 
        }

        public void SetWealthData(Dictionary<string, VillageWealthData> data)
        {
            _villageWealthValues = data;
        }

        public VillageWealthData GetWealthData(string villageId)
        {
            if (!_villageWealthValues.ContainsKey(villageId))
            {
                _villageWealthValues[villageId] = new VillageWealthData(villageId);
            }
            return _villageWealthValues[villageId];
        }

        public void SyncData(IDataStore dataStore)
        {
            dataStore.SyncData("GlobalPlots", ref _globalPlots);
            dataStore.SyncData("VillageWealthValues", ref _villageWealthValues);
        }
    }
}
