using System;
using System.Linq;
using System.Collections.Generic;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Map;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;
using TaleWorlds.CampaignSystem.Actions;
using Microsoft.Extensions.Logging;

namespace Brigands.Terror
{
    public class BanditTerrorBehavior : CampaignBehaviorBase
    {
        private readonly ILogger<BanditTerrorBehavior> _logger;
        private readonly GlobalSettings _settings;
        
        private Dictionary<(int, int), List<Settlement>> _spatialGrid = new Dictionary<(int, int), List<Settlement>>();
        private Dictionary<Settlement, bool> _coastalCache = new Dictionary<Settlement, bool>();
        private int _tickCounter = 0;

        public BanditTerrorBehavior(ILogger<BanditTerrorBehavior> logger, GlobalSettings settings)
        {
            _logger = logger;
            _settings = settings;
        }

        public override void RegisterEvents()
        {
            CampaignEvents.HourlyTickEvent.AddNonSerializedListener(this, OnHourlyTick);
            CampaignEvents.DailyTickEvent.AddNonSerializedListener(this, OnDailyTick);
        }

        public override void SyncData(IDataStore dataStore) { }

        private void OnDailyTick()
        {
            RefreshSpatialGrid();
        }

        private void RefreshSpatialGrid()
        {
            _spatialGrid.Clear();
            float gridSize = _settings.TerrorGridSize;

            foreach (var s in Settlement.All)
            {
                if (!s.IsVillage) continue;
                
                try
                {
                    if (s.Village != null)
                    {
                        if (!_coastalCache.ContainsKey(s))
                        {
                            _coastalCache[s] = IsCoastal(s);
                        }

                        if (s.Village.VillageState == Village.VillageStates.Normal && 
                            s.MilitiaPartyComponent != null && 
                            s.MilitiaPartyComponent.MobileParty != null &&
                            s.MilitiaPartyComponent.MobileParty.IsActive)
                        {
                             int gx = (int)(s.Position.X / gridSize);
                             int gy = (int)(s.Position.Y / gridSize);
                             
                             if (!_spatialGrid.ContainsKey((gx, gy))) _spatialGrid[(gx, gy)] = new List<Settlement>();
                             _spatialGrid[(gx, gy)].Add(s);
                        }
                    }
                }
                catch {} 
            }
        }

        private void OnHourlyTick()
        {
            if (CampaignTime.Now.CurrentHourInDay % 2 == 0) return;
            
            if (_spatialGrid.Count == 0) RefreshSpatialGrid();

            _tickCounter++;
            long targetMod = _tickCounter % 100;
            float gridSize = _settings.TerrorGridSize;
            float maxDistSq = _settings.TerrorDistanceSquared;
            float strengthRatio = _settings.TerrorStrengthRatio;

            var sw = System.Diagnostics.Stopwatch.StartNew();

            try
            {
                var allAggressors = new List<MobileParty>();
                
                // 1. Collection Phase
                try
                {
                     foreach(var p in MobileParty.All) 
                     {
                         if (p == null || !p.IsActive) continue;
                         
                         if (Math.Abs(p.Id.GetHashCode()) % 100 != targetMod) continue;

                         if (p.IsMainParty || p.Army != null) continue; 

                         var mapFaction = p.MapFaction;
                         if (mapFaction == null) continue;

                         bool isBandit = mapFaction.IsBanditFaction || mapFaction.IsOutlaw;
                         if (!isBandit && mapFaction.StringId != null && mapFaction.StringId.IndexOf("deserter", StringComparison.OrdinalIgnoreCase) >= 0) isBandit = true;
                         bool isSyndicate = (mapFaction.StringId == "TheSyndicate");

                         if (isBandit || isSyndicate)
                         {
                             if (p.MapEvent != null && p.MapEvent.IsRaid) { }
                             else allAggressors.Add(p);
                         }
                     }
                }
                catch (Exception ex) { _logger.LogError(ex, "Error collecting aggressors"); }

                // 2. Logic Phase (Absorption & Aggression)
                foreach (var bandit in allAggressors)
                {
                    try
                    {
                        if (bandit == null || !bandit.IsActive || bandit.Party == null) continue;
                        
                        bool isSyndicate = (bandit.MapFaction != null && bandit.MapFaction.StringId == "TheSyndicate");

                        // 2a. Syndicate Absorption/Recruitment Logic (Peaceful Merge)
                        if (isSyndicate && bandit.LeaderHero != null)
                        {
                            try 
                            {
                                var nearbyBandits = new List<MobileParty>();
                                foreach(var p in MobileParty.All)
                                {
                                    if (p == bandit || !p.IsActive || p.IsMainParty) continue;
                                    if (p.MapFaction == null || (!p.MapFaction.IsBanditFaction && !p.MapFaction.IsOutlaw)) continue;
                                    
                                    // Safety: Do not absorb parties involved in active quests (e.g. Poachers, Manhunters)

                                    
                                    if (bandit.Party.Position.DistanceSquared(p.Party.Position) < 1500f) // Close proximity
                                    {
                                        nearbyBandits.Add(p);
                                    }
                                }

                                if (nearbyBandits.Count > 0)
                                {
                                    // Feed them to the merger
                                    var merger = Campaign.Current.GetCampaignBehavior<Brigands.Merge.BanditCohesionBehavior>();
                                    if (merger != null)
                                    {
                                        nearbyBandits.Add(bandit); // Include self
                                        merger.MergeParties(nearbyBandits);
                                        if (!bandit.IsActive) continue; 
                                    }
                                }
                            }
                            catch (Exception ex) { _logger.LogError(ex, "Syndicate Absorption logic failed"); }
                            
                            // 2a-2. Prisoner Ransom Check
                            if (bandit.PrisonRoster.Count > 0 && MBRandom.RandomFloat < 0.2f) // 20% chance per tick to ransom
                            {
                                try
                                {
                                    // Check for Heroes
                                    var heroes = bandit.PrisonRoster.GetTroopRoster().Where(t => t.Character.IsHero && t.Character.HeroObject != null).ToList();
                                    if (heroes.Count > 0)
                                    {

                                         if (bandit.CurrentSettlement == null && bandit.MapEvent == null)
                                         {
                                             foreach(var h in heroes)
                                             {
                                                 EndCaptivityAction.ApplyByRansom(h.Character.HeroObject, null); 
                                                 _logger.LogInformation($"Syndicate ransomed prisoner: {h.Character.Name}");
                                             }
                                         }
                                    }
                                }
                                catch {}
                            }
                        }

                        // 2b. Aggression Logic (Targeting)
                        if (bandit.TargetSettlement != null)
                        {
                            try 
                            {
                                if (bandit.TargetSettlement.IsUnderRaid || bandit.TargetSettlement.IsUnderSiege) continue;
                            }
                            catch { continue; }
                        }

                        if (bandit.TargetParty == MobileParty.MainParty) continue;

                        CampaignVec2 banditPos = bandit.Party.Position;
                        bool isNaval = IsNavalBandit(bandit);

                        int bx = (int)(banditPos.X / gridSize);
                        int by = (int)(banditPos.Y / gridSize);

                        Settlement bestTarget = null;
                        MobileParty bestPartyTarget = null;
                        float bestDistSq = maxDistSq; 
                        
                        // For Syndicate, we are MORE aggressive (0.8 ratio) vs Regular Bandits (2.0 ratio)
                        float effectiveRatio = isSyndicate ? 0.8f : strengthRatio;

                        // Scan for Villages
                        for (int x = bx - 1; x <= bx + 1; x++)
                        {
                            for (int y = by - 1; y <= by + 1; y++)
                            {
                                if (_spatialGrid.TryGetValue((x, y), out var cellVillages))
                                {
                                    if (cellVillages == null) continue;

                                    foreach (var s in cellVillages)
                                    {
                                         if (s == null) continue;
                                         if (s.MilitiaPartyComponent == null || 
                                             s.MilitiaPartyComponent.MobileParty == null || 
                                             s.MilitiaPartyComponent.MobileParty.MemberRoster == null) 
                                         {
                                             continue;
                                         }

                                         // Skip if already raided
                                         if (s.IsRaided || s.IsUnderRaid) continue;

                                         float dSq = banditPos.DistanceSquared(s.Position);
                                         if (dSq >= bestDistSq) continue;

                                         if (isNaval)
                                         {
                                             if (!_coastalCache.TryGetValue(s, out bool isCoastal) || !isCoastal) continue;
                                         }

                                         int mStr = s.MilitiaPartyComponent.MobileParty.MemberRoster.TotalManCount;
                                         int bStr = (bandit.MemberRoster != null) ? bandit.MemberRoster.TotalManCount : 0;
                                         
                                         if (bStr > (mStr * effectiveRatio))
                                         {
                                             bestDistSq = dSq;
                                             bestTarget = s;
                                         }
                                    }
                                }
                            }
                        }
                        
                        // Scan for Weak Parties (Villagers / Caravans) if Syndicate
                        if (isSyndicate)
                        {
                            var nearbyParties = MobileParty.All.Where(p => 
                                p.IsActive && 
                                p != bandit && 
                                (p.IsVillager || p.IsCaravan) && 
                                p.MapFaction != bandit.MapFaction && 
                                bandit.Party.Position.DistanceSquared(p.Party.Position) < maxDistSq
                            ).ToList();

                            foreach(var prey in nearbyParties)
                            {
                                float dSq = bandit.Party.Position.DistanceSquared(prey.Party.Position);
                                if (dSq < bestDistSq)
                                {
                                    int pStr = prey.MemberRoster.TotalManCount;
                                    int bStr = bandit.MemberRoster.TotalManCount;
                                    
                                    if (bStr > (pStr * effectiveRatio))
                                    {
                                         bestDistSq = dSq;
                                         bestPartyTarget = prey;
                                         bestTarget = null; // Prioritize Party over Village if closer
                                    }
                                }
                            }
                        }

                        if (bestPartyTarget != null)
                        {
                            bandit.SetMoveEngageParty(bestPartyTarget, MobileParty.NavigationType.Default);
                        }
                        else if (bestTarget != null)
                        {
                             bandit.SetMoveRaidSettlement(bestTarget, MobileParty.NavigationType.Default);
                        }
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, $"Error processing bandit AI for {bandit?.Name}");
                    }
                }
            }
            catch (Exception ex)
            {
               _logger.LogError(ex, "Critical Error in OnHourlyTick");
            }

            sw.Stop();
            if (sw.ElapsedMilliseconds > 25 && _settings.DebugMode)
            {
                _logger.LogWarning($"[LAG SPOKE] Bandits check took {sw.ElapsedMilliseconds}ms");
            }
        }

        private bool IsNavalBandit(MobileParty party)
        {
            if (party == null) return false;
            try
            {
                if (party.Name != null)
                {
                    string name = party.Name.ToString().ToLower();
                    if (name.Contains("corsair") || name.Contains("sea raider") || name.Contains("pirate")) return true;
                }
                
                if (party.Party != null && party.Party.Culture != null)
                {
                     string cid = party.Party.Culture.StringId.ToLower();
                     if (cid.Contains("sea_raider") || cid.Contains("nord")) return true; 
                }
            }
            catch {}
            return false;
        }

        private bool IsCoastal(Settlement settlement)
        {
            if (Campaign.Current.MapSceneWrapper == null) return false;

            Vec2 pos = new Vec2(settlement.GatePosition.X, settlement.GatePosition.Y);
            float radius = 3.0f; 
            
            for (float angle = 0; angle < (float)Math.PI * 2; angle += (float)Math.PI / 4)
            {
                Vec2 checkPos = new Vec2(pos.X + (float)Math.Cos(angle) * radius, pos.Y + (float)Math.Sin(angle) * radius);
                var t = Campaign.Current.MapSceneWrapper.GetTerrainTypeAtPosition(new CampaignVec2(checkPos, false));
                if (t == TerrainType.Water || t == TerrainType.River || t == TerrainType.Lake) return true;
            }
            return false;
        }
    }
}
