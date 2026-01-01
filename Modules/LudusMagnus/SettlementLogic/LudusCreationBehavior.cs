using System;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.CampaignSystem.Map;
using LudusMagnus.Core;

namespace LudusMagnus.SettlementLogic
{
    public class LudusCreationBehavior : CampaignBehaviorBase
    {
        private const float LudusWealthThreshold = 1500000f;

        public override void RegisterEvents()
        {
            CampaignEvents.DailyTickEvent.AddNonSerializedListener(this, OnDailyTick);
            CampaignEvents.OnSessionLaunchedEvent.AddNonSerializedListener(this, OnSessionLaunched);
        }

        public override void SyncData(IDataStore dataStore)
        {
        }

        private void OnSessionLaunched(CampaignGameStarter starter)
        {
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

        private void BuildLudusForHero(Hero hero, Vec2? customPos = null)
        {
            if (hero != Hero.MainHero)
            {
                GiveGoldAction.ApplyBetweenCharacters(hero, null, (int)LudusWealthThreshold);
            }

            Vec2 spawnPos;
            if (customPos.HasValue)
            {
                spawnPos = customPos.Value;
            }
            else
            {
                spawnPos = Vec2.Zero;
                Settlement originSettlement = hero.Clan.Settlements.FirstOrDefault() ?? Settlement.All.GetRandomElement();
                
                if (originSettlement != null)
                {
                    bool foundValidSpot = false;
                    Vec2 origin = new Vec2(originSettlement.GatePosition.X, originSettlement.GatePosition.Y);
                    
                    for (int i = 0; i < 10; i++)
                    {
                         float randomDist = 3.0f + (MBRandom.RandomFloat * 5.0f);
                         float randomAngle = MBRandom.RandomFloat * 2f * (float)Math.PI;
                         Vec2 testPos = origin + new Vec2((float)Math.Cos(randomAngle), (float)Math.Sin(randomAngle)) * randomDist;

                         PathFaceRecord face = Campaign.Current.MapSceneWrapper.GetFaceIndex(new CampaignVec2(testPos, true));
                         if (!face.IsValid()) continue;

                         TerrainType terrain = Campaign.Current.MapSceneWrapper.GetTerrainTypeAtPosition(new CampaignVec2(testPos, true));
                         if (terrain == TerrainType.Water || terrain == TerrainType.River || terrain == TerrainType.Canyon) continue;

                         PathFaceRecord originFace = Campaign.Current.MapSceneWrapper.GetFaceIndex(new CampaignVec2(origin, true));
                         if (originFace.IsValid())
                         {
                              float pathDistance;
                              if (Campaign.Current.MapSceneWrapper.GetPathDistanceBetweenAIFaces(originFace, face, origin, testPos, 0.1f, 15.0f, out pathDistance, null, 1000, 1000))
                              {
                                   spawnPos = testPos;
                                   foundValidSpot = true;
                                   break;
                              }
                         }
                    }

                    if (!foundValidSpot) spawnPos = origin + (new Vec2(1f, 1f));
                }
                else
                {
                   return; 
                }
            }

            LudusSpawner.SpawnLudus(hero, spawnPos);
        }
    }
}
