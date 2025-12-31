using System.Collections.Generic;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.GameMenus;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.Core;
using TaleWorlds.Localization;
using TaleWorlds.Library;
using LudusMagnus.Core;
using LudusMagnus.Integration;
using Serilog;
using Microsoft.Extensions.Logging;

using LudusMagnus.Settlements;

namespace LudusMagnus.Events
{
    public class LudusGameMenus
    {
        public static void AddGameMenus(CampaignGameStarter gameStarter)
        {
            gameStarter.AddGameMenu("ludus_manage_staff", "You enter the administration chambers. Here you can assign roles to your trusted companions.", (MenuCallbackArgs args) => {
                var ludus = LudusManager.Instance?.GetLudus(Clan.PlayerClan.Leader);
                if (ludus == null)
                {
                    args.MenuTitle = new TextObject("Error: No Ludus Found");
                    LudusSubModule.InstanceLogger?.LogWarning("LudusGameMenus: Player tried to manage staff but no Ludus found for Clan Leader {Leader}.", Clan.PlayerClan.Leader.Name);
                }
            });

            gameStarter.AddGameMenuOption("ludus_manage_staff", "ludus_staff_back", "Return to Main Hall", (MenuCallbackArgs args) => {
                args.optionLeaveType = GameMenuOption.LeaveType.Leave;
                return true;
            }, (MenuCallbackArgs args) => {
                GameMenu.SwitchToMenu("ludus_main");
            });

            AddStaffAssignmentOption(gameStarter, StaffRole.Lanista, "Appoint Lanista (Manager)", "Oversees finances and ticket sales.");
            AddStaffAssignmentOption(gameStarter, StaffRole.Doctore, "Appoint Doctore (Trainer)", "Trains the garrison and raises gladiators.");
            AddStaffAssignmentOption(gameStarter, StaffRole.Procurator, "Appoint Procurator (Logistics)", "Manages the supply caravan.");
            AddStaffAssignmentOption(gameStarter, StaffRole.Medicus, "Appoint Medicus (Healer)", "Ensures the wounded recover.");

            gameStarter.AddGameMenuOption("ludus_main", "ludus_facilities_link", "Inspect Facilities",
                (MenuCallbackArgs args) => {
                    args.optionLeaveType = GameMenuOption.LeaveType.Submenu;
                    return true;
                },
                (MenuCallbackArgs args) => {
                    GameMenu.SwitchToMenu("ludus_facilities");
                });

            gameStarter.AddGameMenu("ludus_facilities", "You walk the grounds of your Ludus. The sounds of training and construction fill the air.", (MenuCallbackArgs args) => { });

            // Add Upgrade Options
            AddUpgradeOption(gameStarter, FacilityType.MasterSmithy, "Master Smithy", "Produces high-quality equipment daily."); 


            gameStarter.AddGameMenuOption("ludus_facilities", "enter_temple", "Enter the Temple of the Ascended",
                (MenuCallbackArgs args) => {
                    var ludus = LudusManager.Instance?.GetLudus(Clan.PlayerClan.Leader);
                    if (ludus != null && ludus.Facilities.ContainsKey(FacilityType.Temple))
                    {
                        args.optionLeaveType = GameMenuOption.LeaveType.Mission;
                        return true;
                    }
                    return false;
                },
                (MenuCallbackArgs args) => {
                    OpenAscensionInquiry();
                });

            gameStarter.AddGameMenuOption("ludus_facilities", "enter_temple_troops", "Ascend Troops (Ritual)",
                (MenuCallbackArgs args) => {
                    var ludus = LudusManager.Instance?.GetLudus(Clan.PlayerClan.Leader);
                    if (ludus != null && ludus.Facilities.ContainsKey(FacilityType.Temple))
                    {
                         args.optionLeaveType = GameMenuOption.LeaveType.Submenu;
                         return true;
                    }
                    return false;
                },
                (MenuCallbackArgs args) => {
                    LudusMagnus.Ascension.AscensionTroopLogic.ShowInquiry();
                });

            gameStarter.AddGameMenuOption("ludus_facilities", "enter_naumachia", "Host a Naumachia (Naval Battle)",
                (MenuCallbackArgs args) => {
                    var ludus = LudusManager.Instance?.GetLudus(Clan.PlayerClan.Leader);
                    if (ludus != null && ludus.Facilities.ContainsKey(FacilityType.Naumachia))
                    {
                        if (NavalArenaWrapper.IsWarSailsLoaded())
                        {
                            args.optionLeaveType = GameMenuOption.LeaveType.Raid;
                            return true;
                        }
                        args.Tooltip = new TextObject("Requires 'War Sails' mod.");
                        args.IsEnabled = false;
                        return true;
                    }
                    return false;
                },
                (MenuCallbackArgs args) => {
                    new NavalArenaWrapper().TriggerNavalBattle();
                });

            gameStarter.AddGameMenuOption("ludus_facilities", "enter_dormitory", "Visit the Great Dormitory",
                (MenuCallbackArgs args) => {
                    var ludus = LudusManager.Instance?.GetLudus(Clan.PlayerClan.Leader);
                    if (ludus != null && ludus.Facilities.ContainsKey(FacilityType.Dormitory))
                    {
                        args.optionLeaveType = GameMenuOption.LeaveType.Wait;
                        return true;
                    }
                    return false;
                },
                (MenuCallbackArgs args) => {
                    InformationManager.DisplayMessage(new InformationMessage("You visit the heroes resting in the dormitory."));
                });

            gameStarter.AddGameMenuOption("ludus_facilities", "ludus_facilities_back", "Return to Main Hall",
                (MenuCallbackArgs args) => {
                    args.optionLeaveType = GameMenuOption.LeaveType.Leave;
                    return true;
                },
                (MenuCallbackArgs args) => {
                    GameMenu.SwitchToMenu("ludus_main");
                });
        }

        private static void OpenAscensionInquiry()
        {
            List<InquiryElement> elements = new List<InquiryElement>();
            foreach (var hero in Clan.PlayerClan.Heroes)
            {
                if (AscensionRitual.CanAscend(hero))
                {
                    elements.Add(new InquiryElement(hero, hero.Name.ToString(), null)); // Fixed: Removed ImageIdentifier
                }
            }

            if (elements.Count == 0)
            {
                InformationManager.DisplayMessage(new InformationMessage("No heroes are ready for Ascension (Lvl 20+)."));
                return;
            }

            MBInformationManager.ShowMultiSelectionInquiry(new MultiSelectionInquiryData(
                "Select Hero to Ascend",
                "Choose a hero to undergo the ritual. They will be reborn with greater potential.",
                elements,
                true, 1, 1, "Ascend", "Cancel",
                (List<InquiryElement> selected) => {
                    if (selected.Count > 0)
                    {
                        AscensionRitual.Execute(selected[0].Identifier as Hero);
                    }
                },
                null
            ));
        }

        private static void AddStaffAssignmentOption(CampaignGameStarter starter, StaffRole role, string text, string tooltip)
        {
            starter.AddGameMenuOption("ludus_manage_staff", $"assign_{role}", text,
                (MenuCallbackArgs args) => {
                    args.optionLeaveType = GameMenuOption.LeaveType.Manage;
                    args.Tooltip = new TextObject(tooltip);
                    
                    var ludus = LudusManager.Instance?.GetLudus(Clan.PlayerClan.Leader);
                    if (ludus != null && ludus.Staff.ContainsKey(role))
                    {
                        var current = ludus.Staff[role];
                        args.Text = new TextObject($"{text} (Current: {current.Name})");
                    }
                    return true;
                },
                (MenuCallbackArgs args) => {
                    OpenHeroSelectionInquiry(role);
                });
        }

        private static void OpenHeroSelectionInquiry(StaffRole role)
        {
            List<InquiryElement> elements = new List<InquiryElement>();
            elements.Add(new InquiryElement(null, "Dismiss Current", null));

            foreach (var hero in Clan.PlayerClan.Heroes)
            {
                if (hero == Hero.MainHero || hero.IsChild || hero.IsDead) continue;
                if (hero.GovernorOf != null) continue;
                if (hero.PartyBelongedTo != MobileParty.MainParty && hero.PartyBelongedTo?.LeaderHero == hero) continue;

                string roleInfo = $"Steward: {hero.GetSkillValue(DefaultSkills.Steward)} | Leadership: {hero.GetSkillValue(DefaultSkills.Leadership)}";
                elements.Add(new InquiryElement(hero, hero.Name.ToString(), null, true, roleInfo)); // Fixed: Removed ImageIdentifier
            }

            MBInformationManager.ShowMultiSelectionInquiry(new MultiSelectionInquiryData(
                $"Appoint {role}",
                "Select a companion to take this role. They must be in your clan and available.",
                elements,
                true, 1, 1, "Confirm", "Cancel",
                (List<InquiryElement> selected) => {
                    if (selected.Count > 0)
                    {
                        Hero choice = selected[0].Identifier as Hero;
                        AssignStaff(role, choice);
                    }
                },
                null
            ));
        }

        private static void AssignStaff(StaffRole role, Hero hero)
        {
            var ludus = LudusManager.Instance?.GetLudus(Clan.PlayerClan.Leader);
            if (ludus == null) return;

            if (hero == null)
            {
                if (ludus.Staff.ContainsKey(role)) 
                {
                     var old = ludus.Staff[role];
                     ludus.Staff.Remove(role);
                     LudusSubModule.InstanceLogger?.LogInformation("Player dismissed {Hero} from {Role} at {Ludus}.", old.Name, role, ludus.Settlement?.Name);
                }
                InformationManager.DisplayMessage(new InformationMessage($"Dimissed {role}."));
            }
            else
            {
                if (ludus.Staff.ContainsKey(role)) ludus.Staff[role] = hero;
                else ludus.Staff.Add(role, hero);
                
                LudusSubModule.InstanceLogger?.LogInformation("Player assigned {Hero} to {Role} at {Ludus}.", hero.Name, role, ludus.Settlement?.Name);
                InformationManager.DisplayMessage(new InformationMessage($"{hero.Name} is now the {role}."));
            }
            GameMenu.SwitchToMenu("ludus_manage_staff");
        }
        private static void AddUpgradeOption(CampaignGameStarter starter, FacilityType type, string name, string desc)
        {
             starter.AddGameMenuOption("ludus_facilities", $"upgrade_{type}", name,
                (MenuCallbackArgs args) => {
                    var ludus = LudusManager.Instance?.GetLudus(Clan.PlayerClan.Leader);
                    if (ludus == null) return false;

                    int currentLevel = LudusUpgradeManager.Instance.GetUpgradeLevel(ludus, type);
                    int cost = LudusUpgradeManager.Instance.GetUpgradeCost(currentLevel);
                    
                    bool canUpgrade = LudusUpgradeManager.Instance.CanUpgrade(ludus, type, out string reason);

                    if (currentLevel == 0)
                        args.Text = new TextObject($"Build {name} ({cost} Gold)");
                    else
                        args.Text = new TextObject($"Upgrade {name} to Level {currentLevel + 1} ({cost} Gold)");

                    args.Tooltip = new TextObject($"{desc}\nStatus: Level {currentLevel}\nCost: {cost}\nCondition: {reason}");
                    
                    if (!canUpgrade && reason != "Ready")
                    {
                        args.IsEnabled = false;
                    }
                    else
                    {
                        args.optionLeaveType = GameMenuOption.LeaveType.Surrender; // Uses hammer icon usually
                    }
                    return true;
                },
                (MenuCallbackArgs args) => {
                     var ludus = LudusManager.Instance?.GetLudus(Clan.PlayerClan.Leader);
                     if (ludus != null)
                     {
                         LudusUpgradeManager.Instance.UpgradeFacility(ludus, type);
                         // Refresh menu
                         GameMenu.SwitchToMenu("ludus_facilities");
                     }
                });
        }
    }
}
