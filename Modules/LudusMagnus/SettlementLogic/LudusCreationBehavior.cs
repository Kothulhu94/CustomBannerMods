using System;
using System.Linq;
using System.Xml;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.GameMenus;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;
using TaleWorlds.ObjectSystem;
using TaleWorlds.ModuleManager;
using LudusMagnus.Core;
using SandBox.View.Map;
using TaleWorlds.Engine;
using TaleWorlds.InputSystem;
using TaleWorlds.ScreenSystem;
using TaleWorlds.CampaignSystem.Map;

namespace LudusMagnus.SettlementLogic
{
    public class LudusCreationBehavior : CampaignBehaviorBase
    {
        private const int LudusCost = 1000000;
        private const float LudusWealthThreshold = 1500000f;
        private bool _isSelecting = false;

        public override void RegisterEvents()
        {
            CampaignEvents.DailyTickEvent.AddNonSerializedListener(this, OnDailyTick);
            CampaignEvents.OnSessionLaunchedEvent.AddNonSerializedListener(this, OnSessionLaunched);
            CampaignEvents.TickEvent.AddNonSerializedListener(this, OnTick);
        }

        public override void SyncData(IDataStore dataStore)
        {
        }

        private void OnSessionLaunched(CampaignGameStarter starter)
        {
            starter.AddGameMenuOption("town", "build_ludus", "{=ludus_build}Construct Ludus (1,000,000 Gold)",
                (MenuCallbackArgs args) =>
                {
                    bool canBuild = Hero.MainHero.Gold >= LudusCost && LudusManager.Instance.GetLudusFor(Hero.MainHero) == null;
                    args.optionLeaveType = GameMenuOption.LeaveType.Manage;
                    if (!canBuild)
                    {
                        args.IsEnabled = false;
                        args.Tooltip = new TextObject("{=ludus_req}Requires 1,000,000 Gold and no existing Ludus.");
                    }
                    return true;
                },
                (MenuCallbackArgs args) =>
                {
                    if (Hero.MainHero.Gold >= LudusCost)
                    {
                        GameMenu.ExitToLast();
                        _isSelecting = true;
                        InformationManager.DisplayMessage(new InformationMessage("Click on the map to place your Ludus. Right-click to cancel.", Colors.Yellow));
                    }
                }, false, 4);
        }

        private void OnDailyTick()
        {
            foreach (Clan clan in Clan.All)
            {
                if (clan.IsEliminated || clan.Leader == null || clan.Tier < 5) continue;
                if (clan == Clan.PlayerClan) continue;

                if (clan.Leader.Gold >= LudusWealthThreshold)
                {
                    if (LudusManager.Instance.GetLudusFor(clan.Leader) == null)
                    {
                        if (MBRandom.RandomFloat < 0.01f)
                        {
                            BuildLudusForHero(clan.Leader);
                        }
                    }
                }
            }
        }

        private void OnTick(float dt)
        {
            if (_isSelecting && MapScreen.Instance != null)
            {
                if (Input.IsReleased(InputKey.LeftMouseButton))
                {
                    Vec3 rayOrigin = Vec3.Zero;
                    Vec3 rayDir = Vec3.Zero;
                    float distance = 0f;
                    Vec3 intersection = Vec3.Zero;
                    PathFaceRecord face = PathFaceRecord.NullFaceRecord;
                    bool hit = false;

                    // Use BodyFlags from PlayerSettlement: (BodyFlags)79617
                    MapScreen.Instance.GetCursorIntersectionPoint(ref rayOrigin, ref rayDir, out distance, out intersection, ref face, out hit, (BodyFlags)79617);

                    if (hit)
                    {
                        _isSelecting = false;
                        BuildLudusForHero(Hero.MainHero, intersection.AsVec2);
                    }
                }
                if (Input.IsReleased(InputKey.RightMouseButton))
                {
                    _isSelecting = false;
                    InformationManager.DisplayMessage(new InformationMessage("Ludus placement canceled.", Colors.Red));
                }
            }
        }

        private void BuildLudusForHero(Hero hero, Vec2? customPos = null)
        {
            if (hero == Hero.MainHero)
            {
                GiveGoldAction.ApplyBetweenCharacters(hero, null, LudusCost);
            }
            else
            {
                GiveGoldAction.ApplyBetweenCharacters(hero, null, (int)LudusWealthThreshold);
            }

            // Fix: Use GatePosition and manually construct Vec2 to avoid CS0029/CS1061 errors
            Vec2 spawnPos;
            if (customPos.HasValue)
            {
                spawnPos = customPos.Value;
            }
            else
            {
                // Smart AI Placement: Find a valid spot near an existing settlement
                spawnPos = Vec2.Zero;
                Settlement originSettlement = hero.Clan.Settlements.FirstOrDefault() ?? Settlement.All.GetRandomElement();
                
                if (originSettlement != null)
                {
                    bool foundValidSpot = false;
                    Vec2 origin = new Vec2(originSettlement.GatePosition.X, originSettlement.GatePosition.Y);
                    
                    // Try 10 random spots in a donut shape (min 3.0, max 8.0 distance)
                    for (int i = 0; i < 10; i++)
                    {
                         float randomDist = 3.0f + (MBRandom.RandomFloat * 5.0f);
                         float randomAngle = MBRandom.RandomFloat * 2f * (float)Math.PI;
                         Vec2 testOffset = new Vec2((float)Math.Cos(randomAngle), (float)Math.Sin(randomAngle)) * randomDist;
                         Vec2 testPos = origin + testOffset;

                         // Validation 1: Check if it's on a valid Navigation Mesh face (not a mountain/void)
                         PathFaceRecord face = Campaign.Current.MapSceneWrapper.GetFaceIndex(new CampaignVec2(testPos, true));
                         if (!face.IsValid()) continue;

                         // Validation 2: Ensure it's not Water
                         TerrainType terrain = Campaign.Current.MapSceneWrapper.GetTerrainTypeAtPosition(new CampaignVec2(testPos, true));
                         if (terrain == TerrainType.Water || terrain == TerrainType.River || terrain == TerrainType.Canyon) continue;

                         // Validation 3: Ensure accessibility from the origin settlement
                         PathFaceRecord originFace = Campaign.Current.MapSceneWrapper.GetFaceIndex(new CampaignVec2(origin, true));
                         if (originFace.IsValid())
                         {
                              float pathDistance;
                              if (Campaign.Current.MapSceneWrapper.GetPathDistanceBetweenAIFaces(originFace, face, origin, testPos, 0.1f, 15.0f, out pathDistance, null, 1000, 1000))
                              {
                                   // Success! We found a reachable, valid spot.
                                   spawnPos = testPos;
                                   foundValidSpot = true;
                                   break;
                              }
                         }
                    }

                    // If all smart checks fail, default to very close proximity as fallback
                    if (!foundValidSpot) 
                    {
                         spawnPos = origin + (new Vec2(1f, 1f));
                    }
                }
                else
                {
                   return; // Should happen rarely
                }
            }

            SpawnLudusSettlement(hero, spawnPos);
        }

        private void SpawnLudusSettlement(Hero hero, Vec2 position)
        {
            try
            {
                string templatePath = "D:/Bannerlord_Mods/Modules/LudusMagnus/ModuleData/ludus_template.xml";
                
                XmlDocument doc = new XmlDocument();
                doc.Load(templatePath);

                string id = $"ludus_{hero.StringId}_{MBRandom.RandomInt(10000)}";
                string name = $"{hero.Name}'s Ludus";

                string xmlContent = doc.OuterXml;
                xmlContent = xmlContent.Replace("{{ID}}", id);
                xmlContent = xmlContent.Replace("{{NAME}}", name);
                xmlContent = xmlContent.Replace("{{OWNER_CLAN}}", hero.Clan.StringId);
                xmlContent = xmlContent.Replace("{{POS_X}}", position.X.ToString("0.00"));
                xmlContent = xmlContent.Replace("{{POS_Y}}", position.Y.ToString("0.00"));
                xmlContent = xmlContent.Replace("{{G_POS_X}}", position.X.ToString("0.00"));
                xmlContent = xmlContent.Replace("{{G_POS_Y}}", position.Y.ToString("0.00"));
                xmlContent = xmlContent.Replace("{{CULTURE}}", hero.Culture.StringId);

                XmlDocument processedDoc = new XmlDocument();
                processedDoc.LoadXml(xmlContent);

                MBObjectManager.Instance.LoadXml(processedDoc);

                Settlement newSettlement = Settlement.Find(id);
                if (newSettlement != null)
                {
                    LudusLocation location = new LudusLocation(hero);
                    location.SettlementId = id;
                    LudusManager.Instance.RegisterLudus(hero, location);

                    InformationManager.DisplayMessage(new InformationMessage($"{name} has been constructed!", Colors.Green));
                    newSettlement.IsVisible = true;
                }
            }
            catch (Exception ex)
            {
                InformationManager.DisplayMessage(new InformationMessage("Failed to build Ludus: " + ex.Message, Colors.Red));
            }
        }
    }
}
