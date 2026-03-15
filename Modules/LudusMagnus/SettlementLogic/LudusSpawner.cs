using System;
using System.Linq;
using System.Xml;
using System.Reflection;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.CampaignSystem.Settlements.Buildings;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;
using TaleWorlds.ObjectSystem;
using TaleWorlds.ModuleManager;
using LudusMagnus.Core;
using SandBox.View.Map.Managers;

namespace LudusMagnus.SettlementLogic
{
    public static class LudusSpawner
    {
        public static void SpawnLudus(Hero owner, Vec2 position)
        {
            try
            {
                if (owner == null || owner.Clan == null)
                {
                    InformationManager.DisplayMessage(new InformationMessage("Cannot spawn Ludus: Invalid Owner.", Colors.Red));
                    return;
                }

                if (position.IsNonZero() == false)
                {
                    InformationManager.DisplayMessage(new InformationMessage("Cannot spawn Ludus: Invalid Position.", Colors.Red));
                    return;
                }

                string templatePath = ModuleHelper.GetModuleFullPath("LudusMagnus") + "ModuleData/ludus_template.xml";
                string xmlContent = LoadTemplate(templatePath);

                if (string.IsNullOrEmpty(xmlContent))
                {
                     InformationManager.DisplayMessage(new InformationMessage("Failed to load Ludus Template.", Colors.Red));
                     return;
                }

                string id = $"ludus_{owner.StringId}_{MBRandom.RandomInt(10000)}";
                string name = $"{owner.Name}'s Ludus";

                xmlContent = xmlContent.Replace("{{ID}}", id)
                                       .Replace("{{NAME}}", name)
                                       .Replace("{{OWNER_CLAN}}", owner.Clan.StringId)
                                       .Replace("{{POS_X}}", position.X.ToString("0.00"))
                                       .Replace("{{POS_Y}}", position.Y.ToString("0.00"))
                                       .Replace("{{G_POS_X}}", position.X.ToString("0.00"))
                                       .Replace("{{G_POS_Y}}", position.Y.ToString("0.00"))
                                       .Replace("{{CULTURE}}", owner.Culture.StringId);

                XmlDocument processedDoc = new XmlDocument();
                processedDoc.LoadXml(xmlContent);
                MBObjectManager.Instance.LoadXml(processedDoc);

                Settlement newSettlement = Settlement.Find(id);
                if (newSettlement != null)
                {
                    // Validation
                    if (newSettlement.Town == null)
                    {
                        InformationManager.DisplayMessage(new InformationMessage("Ludus Error: Settlement created but 'Town' component is missing!", Colors.Red));
                        return;
                    }
                    if (newSettlement.Party == null)
                    {
                        InformationManager.DisplayMessage(new InformationMessage("Ludus Error: Settlement created but 'Party' is missing!", Colors.Red));
                        return;
                    }

                    // Initialization
                    newSettlement.Town.OwnerClan = owner.Clan;
                    SetPrivateField(newSettlement, "_name", new TextObject(name));

                    // Visuals
                    newSettlement.Party.SetLevelMaskIsDirty();
                    newSettlement.IsVisible = true;
                    newSettlement.IsInspected = true;
                    newSettlement.Party.SetVisualAsDirty();

                    // Critical Visual Manager Call
                    if (SettlementVisualManager.Current != null)
                    {
                        MethodInfo addNewVisualMethod = typeof(SettlementVisualManager).GetMethod("AddNewPartyVisualForParty", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
                        if (addNewVisualMethod != null)
                        {
                            addNewVisualMethod.Invoke(SettlementVisualManager.Current, new object[] { newSettlement.Party });
                        }
                    }

                    // Lifecycle
                    newSettlement.OnGameCreated();
                    newSettlement.OnFinishLoadState();

                    // Buildings
                    InitBuildings(newSettlement);

                    // Garrison
                    newSettlement.AddGarrisonParty();
                    if (newSettlement.Town.GarrisonParty != null)
                    {
                        newSettlement.Town.GarrisonParty.MemberRoster.AddToCounts(owner.Culture.BasicTroop, 20);
                        newSettlement.Town.GarrisonParty.MemberRoster.AddToCounts(owner.Culture.EliteBasicTroop, 10);
                    }

                    // Register
                    LudusLocation location = new LudusLocation(owner);
                    location.SettlementId = id;
                    LudusManager.Instance.RegisterLudus(owner, location);

                    InformationManager.DisplayMessage(new InformationMessage($"Ludus '{name}' Spawned & Initialized!", Colors.Green));
                }
                else
                {
                    InformationManager.DisplayMessage(new InformationMessage("Ludus Spawn Failed: Settlement object not found after LoadXml.", Colors.Red));
                }
            }
            catch (Exception ex)
            {
                InformationManager.DisplayMessage(new InformationMessage($"Critical Error Spawning Ludus: {ex.Message}", Colors.Red));
            }
        }

        private static void InitBuildings(Settlement settlement)
        {
            if (settlement.Town == null) return;

            Town town = settlement.Town;
            int val = MBRandom.RandomInt(1, 4);

            foreach (BuildingType buildingType in BuildingType.All)
            {
                if (!town.Buildings.Any(b => b.BuildingType == buildingType) && buildingType.StringId.StartsWith("building_castle"))
                {
                    town.Buildings.Add(new Building(buildingType, town, 0f, Math.Max(val, buildingType.StartLevel)));
                }
            }

            Building defaultProject = town.Buildings.FirstOrDefault(b => b.BuildingType.IsDailyProject && b.IsCurrentlyDefault);
            if (defaultProject == null)
            {
                defaultProject = town.Buildings.FirstOrDefault(b => b.BuildingType.IsDailyProject);
                if (defaultProject != null)
                {
                    defaultProject.IsCurrentlyDefault = true;
                }
            }
        }

        private static string LoadTemplate(string fullPath)
        {
             if (System.IO.File.Exists(fullPath))
             {
                 return System.IO.File.ReadAllText(fullPath);
             }
             return null;
        }

        private static void SetPrivateField(object target, string fieldName, object value)
        {
            if (target == null) return;
            var t = target.GetType();
            FieldInfo fi = null;
            while (t != null)
            {
                fi = t.GetField(fieldName, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
                if (fi != null) break;
                t = t.BaseType;
            }
            if (fi != null) try { fi.SetValue(target, value); } catch { }
        }
    }
}
