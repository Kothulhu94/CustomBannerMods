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
        }

        private void OnSessionLaunched(CampaignGameStarter starter)
        {
             Log("OnSessionLaunched: Fired");
             // Debug message removed per user request.

             starter.AddGameMenuOption("town", "town_ascend_troop", "Ascend Troops",
                (MenuCallbackArgs args) => {
                    args.optionLeaveType = GameMenuOption.LeaveType.Default;
                    return true;
                },
                (MenuCallbackArgs args) => ShowAscensionInquiry(),
                false, 4);
             Log("Registered 'town' menu option.");
                
             starter.AddGameMenuOption("castle", "castle_ascend_troop_main", "Ascend Troops",
                (MenuCallbackArgs args) => {
                    args.optionLeaveType = GameMenuOption.LeaveType.Default;
                    return true;
                },
                (MenuCallbackArgs args) => ShowAscensionInquiry(),
                false, 4);
             Log("Registered 'castle' menu option.");

             starter.AddGameMenuOption("castle_guard", "castle_ascend_troop_guard", "Ascend Troops",
                (MenuCallbackArgs args) => {
                    args.optionLeaveType = GameMenuOption.LeaveType.Default;
                    return true;
                },
                (MenuCallbackArgs args) => ShowAscensionInquiry(),
                false, 4);
             Log("Registered 'castle_guard' menu option.");

             starter.AddGameMenuOption("village", "village_ascend_troop", "Ascend Troops",
                (MenuCallbackArgs args) => {
                    args.optionLeaveType = GameMenuOption.LeaveType.Default;
                    return true;
                },
                (MenuCallbackArgs args) => ShowAscensionInquiry(),
                false, 4);
             Log("Registered 'village' menu option.");
        }

        private void ShowAscensionInquiry()
        {
            // Debugging: Check what is actually loaded
            var allObjects = MBObjectManager.Instance.GetObjectTypeList<CharacterObject>();
            int foundCount = 0;
            foreach (var obj in allObjects)
            {
                if (obj.StringId.Contains("battanian_highborn_youth_asc"))
                {
                    foundCount++;
                    if (foundCount <= 5) Log($"Found loaded unit: {obj.StringId}");
                }
            }
            InformationManager.DisplayMessage(new InformationMessage($"[DEBUG] Found {foundCount} Ascended Highborn units in ObjectManager."));

            var elements = new List<InquiryElement>();
            
            var eligibleTroops = MobileParty.MainParty.MemberRoster.GetTroopRoster()
                .Where(t => !t.Character.IsHero && 
                            t.Character.Tier >= 5 && 
                            (t.Character.UpgradeTargets == null || t.Character.UpgradeTargets.Length == 0)) 
                .GroupBy(t => t.Character);

            foreach (var group in eligibleTroops)
            {
                CharacterObject troop = group.Key;
                int count = group.Sum(t => t.Number);
                elements.Add(new InquiryElement(troop, $"{troop.Name} (x{count})", null));
            }

            if (elements.Count == 0)
            {
                InformationManager.DisplayMessage(new InformationMessage("No eligible troops (Tier 5+ required) for Ascension."));
                return;
            }

            MBInformationManager.ShowMultiSelectionInquiry(new MultiSelectionInquiryData(
                "Ascension Ritual",
                "Select veterans to Reborn as Rank 1 Ascended units (Stats +20 Init).",
                elements,
                true, 1, 999,
                "Ascend", "Cancel",
                (selected) => {
                     foreach (var item in selected)
                     {
                         CharacterObject character = item.Identifier as CharacterObject;
                         int total = MobileParty.MainParty.MemberRoster.GetTroopCount(character);
                         AscendTroop(MobileParty.MainParty.Party, character, total); 
                     }
                },
                (entry) => { }
            ));
        }

        public void AscendTroop(PartyBase party, CharacterObject character, int amount)
        {
            if (character == null || amount <= 0) return;
            
            int currentRank = GetAscensionRank(character);
            CharacterObject root = FindRootAncestor(character);
            
            if (root == null)
            {
                InformationManager.DisplayMessage(new InformationMessage("Could not determine root ancestor!", Color.FromUint(0xFFFF0000)));
                return;
            }

            int nextRank = currentRank + 1;
            string targetId = $"{root.StringId}_asc_{nextRank}";
            if (nextRank > MAX_RANKS)
            {
                 InformationManager.DisplayMessage(new InformationMessage($"Max Ascension Rank ({MAX_RANKS}) reached!", Color.FromUint(0xFFFF0000)));
                 return;
            }

            CharacterObject ascendedUnit = MBObjectManager.Instance.GetObject<CharacterObject>(targetId);

            if (ascendedUnit != null)
            {
                party.MemberRoster.AddToCounts(character, -amount);
                party.MemberRoster.AddToCounts(ascendedUnit, amount);
                
                InformationManager.DisplayMessage(new InformationMessage(
                    $"{amount} {character.Name} ascended to {ascendedUnit.Name}!",
                    Color.FromUint(0xFF00FF00)
                ));
            }
            else
            {
                 InformationManager.DisplayMessage(new InformationMessage($"Target {targetId} not found. Ascended troops did not load correctly. Check 'Ascension_Runtime.log'.", Color.FromUint(0xFFFF0000)));
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
        public override void SyncData(IDataStore dataStore) { }
    }
}

