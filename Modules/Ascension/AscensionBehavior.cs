using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;
using System.IO;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.GameMenus;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;
using TaleWorlds.ObjectSystem;
using TaleWorlds.CampaignSystem.Settlements;


namespace Ascension
{
    public class AscensionBehavior : CampaignBehaviorBase
    {
        public static AscensionBehavior Instance { get; private set; }
        
        private const int MAX_RANKS = 20;
        
        public AscensionBehavior()
        {
            Instance = this;
        }

        private static void Log(string message)
        {
            try
            {
                File.AppendAllText("d:/Bannerlord_Mods/logs/Ascension_Runtime.log", $"[{DateTime.Now}] [Behavior] {message}\n");
            }
            catch { }
        }

        public override void RegisterEvents()
        {
            CampaignEvents.OnSessionLaunchedEvent.AddNonSerializedListener(this, OnSessionLaunched);
            CampaignEvents.SettlementEntered.AddNonSerializedListener(this, OnSettlementEntered);
        }

        private void OnSettlementEntered(MobileParty party, Settlement settlement, Hero hero)
        {
            if (party == null || settlement == null || !settlement.IsTown || party.IsMainParty) return;
            if (party.LeaderHero == null || party.LeaderHero.Clan == null || party.LeaderHero.Clan.IsMinorFaction) return;
            
            // AI Logic: Check Gold and Ascend
            AscendAITroops(party);
        }

        private void AscendAITroops(MobileParty party)
        {
            if (party.LeaderHero.Gold < 1000) return;

            // Identify eligible troops
            // Copy list to avoid concurrent modification issues
            var roster = party.MemberRoster.GetTroopRoster().ToList();
            
            foreach (var element in roster)
            {
                CharacterObject character = element.Character;
                if (character.IsHero) continue;

                // Check eligibility: Tier 5+ (Vanilla) OR Already Ascended
                bool isEligible = false;
                if (character.StringId.Contains("_asc_")) isEligible = true;
                else if (character.Tier >= 5 && (character.UpgradeTargets == null || character.UpgradeTargets.Length == 0)) isEligible = true;

                if (!isEligible) continue;

                int amount = element.Number;
                if (amount <= 0) continue;

                int currentRank = GetAscensionRank(character);
                int nextRank = currentRank + 1;
                
                if (nextRank > MAX_RANKS) continue;

                int costPerUnit = nextRank * 1000;
                
                // Determine how many we can afford
                int affordableCount = 0;
                
                int totalCostCheck = costPerUnit * amount;
                if (party.LeaderHero.Gold >= totalCostCheck)
                {
                    affordableCount = amount;
                }
                else
                {
                    affordableCount = party.LeaderHero.Gold / costPerUnit;
                }

                if (affordableCount > 0)
                {
                    int finalCost = affordableCount * costPerUnit;
                    party.LeaderHero.Gold -= finalCost; // Direct deduction
                    AscendTroop(party.Party, character, affordableCount, true); // Silent
                }

                if (party.LeaderHero.Gold < 1000) break; // Stop if broke
            }
        }

        private void OnSessionLaunched(CampaignGameStarter starter)
        {
             Log("OnSessionLaunched: Fired");

             // --- NEW TEMPLE FEATURE ---
             starter.AddGameMenuOption("town", "town_temple_of_ascended", "{=asc_tmp_01}Temple of the Ascended",
                (MenuCallbackArgs args) => {
                    args.optionLeaveType = GameMenuOption.LeaveType.Submenu;
                    return true;
                },
                (MenuCallbackArgs args) => {
                    GameMenu.SwitchToMenu("ascension_temple_menu");
                }, false, 4);

             starter.AddGameMenu("ascension_temple_menu", "{=asc_tmp_desc}You enter the Temple of the Ascended. The air is thick with incense. Five silent masters stand before the altar, each representing a lineage of power.",
                 (MenuCallbackArgs args) => { },
                 GameMenu.MenuOverlayType.SettlementWithBoth);

             // 1. Recruit Option
             starter.AddGameMenuOption("ascension_temple_menu", "ascension_recruit_elite", "{=asc_tmp_rec}Recruit Ascended Nobles",
                 (MenuCallbackArgs args) => {
                     args.optionLeaveType = GameMenuOption.LeaveType.Recruit;
                     return true;
                 },
                 (MenuCallbackArgs args) => {
                     ShowTempleRecruitment(Settlement.CurrentSettlement);
                 });

             // 2. Ascend Option (Moved from Town)
             starter.AddGameMenuOption("ascension_temple_menu", "ascension_perform_ritual", "{=asc_tmp_rit}Perform Ascension Ritual",
                 (MenuCallbackArgs args) => {
                     args.optionLeaveType = GameMenuOption.LeaveType.Wait; // Closest icon
                     return true;
                 },
                 (MenuCallbackArgs args) => {
                     ShowAscensionInquiry();
                 });

             starter.AddGameMenuOption("ascension_temple_menu", "ascension_temple_leave", "{=asc_tmp_lv}Leave Temple",
                 (MenuCallbackArgs args) => {
                     args.optionLeaveType = GameMenuOption.LeaveType.Leave;
                     return true;
                 },
                 (MenuCallbackArgs args) => {
                     GameMenu.SwitchToMenu("town");
                 }, true);
        }

        // --- Improved Ascension Ritual Logic ---
        private void ShowAscensionInquiry()
        {
            var elements = new List<InquiryElement>();
            
            // STRICT FILTERING: Only Tier 5+ (Vanilla) OR Ascended Units (Ranked).
            // Explicitly exclude anything lower.
            var eligibleTroops = MobileParty.MainParty.MemberRoster.GetTroopRoster()
                .Where(t => !t.Character.IsHero && 
                            (t.Character.UpgradeTargets == null || t.Character.UpgradeTargets.Length == 0) &&
                            (t.Character.Tier >= 5 || t.Character.StringId.Contains("_asc_"))
                ) 
                .GroupBy(t => t.Character);

            foreach (var group in eligibleTroops)
            {
                CharacterObject troop = group.Key;
                // Double check Tier just in case
                if (!troop.StringId.Contains("_asc_") && troop.Tier < 5) continue;

                int currentRank = GetAscensionRank(troop);
                int nextRank = currentRank + 1;
                int costPerTroop = nextRank * 1000;
                
                if (nextRank > MAX_RANKS) continue;

                int count = group.Sum(t => t.Number);
                string hint = $"Ascend to Rank {nextRank}\nCost: {costPerTroop}g per unit\nAvailable: {count}";
                elements.Add(new InquiryElement(troop, $"{troop.Name} (Rank {currentRank} -> {nextRank}) - {costPerTroop}g [x{count}]", null, true, hint));
            }

            if (elements.Count == 0)
            {
                InformationManager.DisplayMessage(new InformationMessage("No eligible troops (Tier 5+ or Ascended) for Ascension."));
                return;
            }

            MBInformationManager.ShowMultiSelectionInquiry(new MultiSelectionInquiryData(
                "Ascension Ritual",
                "Select veterans to ascend. Cost: 1000g * Target Rank.",
                elements,
                true, 1, 999, // Allow selecting multiple TYPES
                "Ascend Selected", "Cancel",
                (selected) => {
                     // Convert selected to list to handle multiple types
                     var queue = new Queue<InquiryElement>(selected);
                     ProcessAscensionQueue(queue); // Use recursive/sequential processing
                },
                (entry) => { }
            ));
        }

        private void ProcessAscensionQueue(Queue<InquiryElement> queue)
        {
            if (queue.Count == 0) return;
            
            var item = queue.Dequeue();
            CharacterObject character = item.Identifier as CharacterObject;
            int totalAvailable = MobileParty.MainParty.MemberRoster.GetTroopCount(character);
            
            int currentRank = GetAscensionRank(character);
            int nextRank = currentRank + 1;
            int costPerUnit = nextRank * 1000;

            // Ask for Quantity for THIS type
            InformationManager.ShowTextInquiry(new TextInquiryData(
                $"Ascend {character.Name}",
                $"How many of your {totalAvailable} warriors should ascend?\nCost per unit: {costPerUnit}g",
                true, true, "Ascend", "Skip",
                (text) => {
                    if (int.TryParse(text, out int qty) && qty > 0)
                    {
                        if (qty > totalAvailable) qty = totalAvailable;
                        
                        int totalCost = qty * costPerUnit;
                         if (Hero.MainHero.Gold >= totalCost)
                         {
                             GiveGoldAction.ApplyBetweenCharacters(Hero.MainHero, null, totalCost, true);
                             AscendTroop(MobileParty.MainParty.Party, character, qty);
                         }
                         else
                         {
                             InformationManager.DisplayMessage(new InformationMessage($"Not enough gold for {qty} units! Needed {totalCost}g.", Color.FromUint(0xFFFF0000)));
                         }
                    }
                    ProcessAscensionQueue(queue); // Next item
                },
                () => {
                    ProcessAscensionQueue(queue); // Skip and go next
                },
                false, // shouldInputBeObscured
                (text) => { 
                    bool isValid = int.TryParse(text, out int val) && val > 0 && val <= totalAvailable; 
                    return new Tuple<bool, string>(isValid, "Invalid Quantity"); 
                } 
            ));
        }

        // --- Improved Recruitment Logic ---
        private void ShowTempleRecruitment(Settlement settlement)
        {
            if (settlement == null) return;

            // ... (Data Generation skipped for brevity, assumed existing logic persists via partial replacement or is valid) ...
            // We need to re-fetch the data here as we are replacing the method.
            if (!_templeData.ContainsKey(settlement.StringId)) _templeData[settlement.StringId] = new TempleSettlementData { LastRefreshDay = -1 };
            
            var data = _templeData[settlement.StringId];
            int currentDay = (int)CampaignTime.Now.ToDays;
            if (data.LastRefreshDay != currentDay || data.Offers == null || data.Offers.Count == 0) GenerateDailyOffers(data, currentDay);

            List<InquiryElement> inquiryElements = new List<InquiryElement>();

            foreach(var offerData in data.Offers)
            {
                var charObj = MBObjectManager.Instance.GetObject<CharacterObject>(offerData.TroopId);
                if (charObj != null)
                {
                    var offerObj = new TempleOffer(charObj, offerData.Price, offerData.Quantity, offerData.MasterName);
                    string hint = $"{offerData.MasterName} offers:\n{offerData.Quantity} x {charObj.Name}\nCost: {offerData.Price} Gold each.";
                    inquiryElements.Add(new InquiryElement(offerObj, $"{offerData.MasterName}: {charObj.Name} (Avail: {offerData.Quantity}) - {offerData.Price}g", null, true, hint));
                }
            }

            MBInformationManager.ShowMultiSelectionInquiry(new MultiSelectionInquiryData(
                "Temple Recruitment",
                "Select troops to hire. You will be asked for quantities.",
                inquiryElements,
                true, 1, 99, 
                "Hire Selected", "Leave",
                (selected) => {
                    var queue = new Queue<InquiryElement>(selected);
                    ProcessRecruitmentQueue(queue, data, settlement.StringId);
                },
                (exit) => { }
            ));
        }

        private void ProcessRecruitmentQueue(Queue<InquiryElement> queue, TempleSettlementData data, string settlementId)
        {
            if (queue.Count == 0) return;
            
            var item = queue.Dequeue();
            var offer = item.Identifier as TempleOffer;
            
            InformationManager.ShowTextInquiry(new TextInquiryData(
                $"Recruit {offer.Troop.Name}",
                $"Price: {offer.Price}g | Available: {offer.Quantity}\nHow many?",
                true, true, "Recruit", "Skip",
                (text) => {
                     if (int.TryParse(text, out int qty) && qty > 0)
                     {
                         if (qty > offer.Quantity) qty = offer.Quantity;
                         int totalCost = qty * offer.Price;
                         
                         if (Hero.MainHero.Gold >= totalCost)
                         {
                             GiveGoldAction.ApplyBetweenCharacters(Hero.MainHero, null, totalCost, true);
                             MobileParty.MainParty.AddElementToMemberRoster(offer.Troop, qty);
                             InformationManager.DisplayMessage(new InformationMessage($"Recruited {qty} {offer.Troop.Name}.", Color.FromUint(0xFF00FF00)));
                             
                             // Update Stock
                             var dataOffer = data.Offers.FirstOrDefault(o => o.TroopId == offer.Troop.StringId && o.MasterName == offer.NotableName);
                             if (dataOffer != null)
                             {
                                 dataOffer.Quantity -= qty;
                                 if (dataOffer.Quantity <= 0) data.Offers.Remove(dataOffer);
                             }
                         }
                         else
                         {
                             InformationManager.DisplayMessage(new InformationMessage("Not enough gold!", Color.FromUint(0xFFFF0000)));
                         }
                     }
                     ProcessRecruitmentQueue(queue, data, settlementId);
                },
                () => ProcessRecruitmentQueue(queue, data, settlementId),
                false, 
                (text) => {
                    bool isValid = int.TryParse(text, out int val) && val > 0 && val <= offer.Quantity;
                    return new Tuple<bool, string>(isValid, "Invalid Quantity");
                }
            ));
        }

        private void GenerateDailyOffers(TempleSettlementData data, int currentDay)
        {
            data.LastRefreshDay = currentDay;
            data.Offers.Clear();

            // Cultures to represent
            var cultures = new List<string> { "Empire", "Battania", "Sturgia", "Khuzait", "Aserai", "Vlandia", "Nord" };
            Random rng = new Random(currentDay + (int)CampaignTime.Now.CurrentHourInDay); // Seed with time for variety

            foreach (var cultName in cultures)
            {
                // RNG Roll
                // 70% Chance: Rank 0 (Vanilla Elite Tier 2-6)
                // 30% Chance: Rank 1 or 2 (Ascended Elite)
                
                TempleOfferData offer = null;
                double roll = rng.NextDouble();
                string masterName = $"Master of the {cultName}";

                string nobleBaseId = GetNobleBaseId(cultName);
                if (string.IsNullOrEmpty(nobleBaseId)) continue; // Skip if config error

                if (roll < 0.70) 
                {
                    // Rank 0: Vanilla Noble
                    CharacterObject baseRecruit = MBObjectManager.Instance.GetObject<CharacterObject>(nobleBaseId);
                    if (baseRecruit != null)
                    {
                        CharacterObject selectedTroop = baseRecruit;
                        int upgrades = rng.Next(0, 5); // 0, 1, 2, 3, 4
                        for(int i=0; i<upgrades; i++)
                        {
                            if (selectedTroop.UpgradeTargets != null && selectedTroop.UpgradeTargets.Length > 0)
                            {
                                selectedTroop = selectedTroop.UpgradeTargets[0]; // Noble lines are usually linear, take first path
                            }
                        }
                        
                        int price = 500 * (selectedTroop.Tier + 1); // Dynamic price for standard elites
                        int qty = rng.Next(2, 6);
                        offer = new TempleOfferData(selectedTroop.StringId, price, qty, masterName);
                    }
                }
                else
                {
                    // Rank 1/2: Ascended Noble
                    bool isRank2 = (roll >= 0.90); 
                    int rank = isRank2 ? 2 : 1;
                    
                    string ascId = $"{nobleBaseId}_asc_{rank}";
                    
                    int price = isRank2 ? 10000 : 5000;
                    int qty = rng.Next(1, 4); // Fewer ascended

                    offer = new TempleOfferData(ascId, price, qty, masterName);
                }

                if (offer != null)
                {
                    // Verify validity (in case XML is missing that specific unit)
                    if (MBObjectManager.Instance.GetObject<CharacterObject>(offer.TroopId) != null)
                    {
                        data.Offers.Add(offer);
                    }
                }
            }
        }

        // --- Data Persistence ---
        public class TempleSettlementData
        {
            public int LastRefreshDay;
            public List<TempleOfferData> Offers = new List<TempleOfferData>();
        }

        public class TempleOfferData
        {
            public string TroopId;
            public int Price;
            public int Quantity;
            public string MasterName;

            public TempleOfferData() { } 
            public TempleOfferData(string t, int p, int q, string m) { TroopId = t; Price = p; Quantity = q; MasterName = m; }
        }

        private Dictionary<string, TempleSettlementData> _templeData = new Dictionary<string, TempleSettlementData>();

        public override void SyncData(IDataStore dataStore)
        {
             string dataStr = "";
             if (dataStore.IsSaving)
             {
                 List<string> settlementEntries = new List<string>();
                 foreach(var kvp in _templeData)
                 {
                     string sId = kvp.Key;
                     var tData = kvp.Value;
                     List<string> offerStrs = new List<string>();
                     if (tData.Offers != null)
                     {
                         foreach(var o in tData.Offers) offerStrs.Add($"{o.TroopId},{o.Price},{o.Quantity},{o.MasterName}"); 
                     }
                     settlementEntries.Add($"{sId}:{tData.LastRefreshDay}:{string.Join(";", offerStrs)}");
                 }
                 dataStr = string.Join("|", settlementEntries);
             }
             
             dataStore.SyncData("_templeDataSerialized", ref dataStr);
             
             if (dataStore.IsLoading)
             {
                 _templeData = new Dictionary<string, TempleSettlementData>();
                 if (!string.IsNullOrEmpty(dataStr))
                 {
                     var chunks = dataStr.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                     foreach(var chunk in chunks)
                     {
                         var parts = chunk.Split(':');
                         if (parts.Length >= 3)
                         {
                             string sId = parts[0];
                             if (int.TryParse(parts[1], out int day))
                             {
                                 var tData = new TempleSettlementData { LastRefreshDay = day };
                                 if (!string.IsNullOrEmpty(parts[2]))
                                 {
                                     foreach(var oc in parts[2].Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries))
                                     {
                                         var fields = oc.Split(',');
                                         if (fields.Length >= 4 && int.TryParse(fields[1], out int p) && int.TryParse(fields[2], out int q))
                                             tData.Offers.Add(new TempleOfferData(fields[0], p, q, fields[3]));
                                     }
                                 }
                                 _templeData[sId] = tData;
                             }
                         }
                     }
                 }
             }
        }

        private string GetNobleBaseId(string cultName)
        {
            switch (cultName)
            {
                case "Empire": return "imperial_vigla_recruit";
                case "Battania": return "battanian_highborn_youth";
                case "Sturgia": return "sturgian_warrior_son";
                case "Khuzait": return "khuzait_noble_son";
                case "Aserai": return "aserai_youth";
                case "Vlandia": return "vlandian_squire";
                case "Nord": return "nord_youngling"; // Nord Noble Line from NavalDLC
                default: return null;
            }
        }

        private class TempleOffer
        {
            public CharacterObject Troop;
            public int Price;
            public int Quantity;
            public string NotableName;

            public TempleOffer(CharacterObject t, int p, int q, string n)
            {
                Troop = t; Price = p; Quantity = q; NotableName = n;
            }
        }

        public void AscendTroop(PartyBase party, CharacterObject character, int amount, bool silent = false)
        {
            if (character == null || amount <= 0) return;
            
            // STRICT SAFETY CHECK
            // Prevent accidental invalid ascension of low tier troops (Exploit Fix)
            bool isAscended = character.StringId.Contains("_asc_");
            bool isMaxTierVanilla = character.Tier >= 5;
            bool hasNoUpgrades = character.UpgradeTargets == null || character.UpgradeTargets.Length == 0;
            
            if (!hasNoUpgrades || (!isAscended && !isMaxTierVanilla))
            {
                 // Must be end of tree (No Upgrades) AND (Tier 5+ OR Already Ascended)
                 if (!silent) InformationManager.DisplayMessage(new InformationMessage($"Cannot Ascend {character.Name}. Must be fully upgraded (End of Tree)!", Color.FromUint(0xFFFF0000)));
                 return;
            }

            int currentRank = GetAscensionRank(character);
            CharacterObject root = FindRootAncestor(character);
            
            if (root == null)
            {
                if (!silent) InformationManager.DisplayMessage(new InformationMessage("Could not determine root ancestor!", Color.FromUint(0xFFFF0000)));
                return;
            }

            int nextRank = currentRank + 1;
            string targetId = $"{root.StringId}_asc_{nextRank}";
            if (nextRank > MAX_RANKS)
            {
                 if (!silent) InformationManager.DisplayMessage(new InformationMessage($"Max Ascension Rank ({MAX_RANKS}) reached!", Color.FromUint(0xFFFF0000)));
                 return;
            }

            CharacterObject ascendedUnit = MBObjectManager.Instance.GetObject<CharacterObject>(targetId);

            if (ascendedUnit != null)
            {
                party.MemberRoster.AddToCounts(character, -amount);
                party.MemberRoster.AddToCounts(ascendedUnit, amount);
                
                if (!silent)
                {
                    InformationManager.DisplayMessage(new InformationMessage(
                        $"{amount} {character.Name} ascended to {ascendedUnit.Name}!",
                        Color.FromUint(0xFF00FF00)
                    ));
                }
            }
            else
            {
                 if (!silent) InformationManager.DisplayMessage(new InformationMessage($"Target {targetId} not found. Ascended troops did not load correctly.", Color.FromUint(0xFFFF0000)));
            }
        }

        private int GetAscensionRank(CharacterObject character)
        {
            if (character == null) return 0;
            string id = character.StringId;
            if (id.Contains("_asc_"))
            {
                int index = id.LastIndexOf("_asc_") + 5;
                if (index < id.Length && int.TryParse(id.Substring(index), out int rank))
                    return rank;
            }
            return 0;
        }

        private CharacterObject FindRootAncestor(CharacterObject character)
        {
            string baseId = character.StringId;
            if (baseId.Contains("_asc_"))
            {
                baseId = baseId.Substring(0, baseId.LastIndexOf("_asc_"));
            }
            
            CharacterObject current = MBObjectManager.Instance.GetObject<CharacterObject>(baseId);
            if (current == null) return character; 
            
            return FindRootViaScan(current);
        }

        private Dictionary<CharacterObject, CharacterObject> _rootCache;
        private CharacterObject FindRootViaScan(CharacterObject target)
        {
            if (_rootCache == null)
            {
                _rootCache = new Dictionary<CharacterObject, CharacterObject>();
                var all = MBObjectManager.Instance.GetObjectTypeList<CharacterObject>();
                
                Dictionary<CharacterObject, CharacterObject> parentMap = new Dictionary<CharacterObject, CharacterObject>();
                
                foreach(var c in all) {
                    if(c.UpgradeTargets != null) {
                        foreach(var t in c.UpgradeTargets) {
                            bool isOutlaw = c.Occupation == Occupation.Bandit || c.Occupation == Occupation.GangLeader;
                            
                            if (!parentMap.ContainsKey(t))
                            {
                                parentMap[t] = c;
                            }
                            else
                            {
                                CharacterObject existingParent = parentMap[t];
                                bool existingIsOutlaw = existingParent.Occupation == Occupation.Bandit || existingParent.Occupation == Occupation.GangLeader;
                                
                                if (existingIsOutlaw && !isOutlaw)
                                {
                                    parentMap[t] = c;
                                }
                            }
                        }
                    }
                }
                
                foreach(var c in all) {
                    var curr = c;
                    int depth = 0;
                    while(parentMap.ContainsKey(curr) && depth < 10) {
                        curr = parentMap[curr];
                        if (curr.Tier <= 1) break;
                        depth++;
                    }
                    _rootCache[c] = curr;
                }
            }
            
            if (_rootCache.TryGetValue(target, out var root)) return root;
            return target;
        }
        
        // Data Structure for Offers
        // (Moved to top level if needed, but inner class works for sync)

    }
}
