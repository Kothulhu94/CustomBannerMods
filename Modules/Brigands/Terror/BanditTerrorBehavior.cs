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
                                
                                // Optimization: Iterate over pre-filtered list instead of MobileParty.All
                                // We can reuse 'allAggressors' but we need strictly smaller bandit parties.
                                // Ideal: Iterate 'allAggressors' (which are bandits) + find nearby ones.
                                // Even better: Use a spatial query if available, but for now, just iterating the smaller 'allAggressors' list is O(K^2) instead of O(K*N)
                                // However, 'allAggressors' contains ONLY parties processed in this tick. We need ALL potential targets.
                                // We will do a separate light scan or just accept we only merge with active tick bandits? 
                                // NO, Syndicate needs to merge with any bandit.
                                
                                // FIX: Let's create a cached list of 'potentialTargets' in the Collections phase?
                                // That might be too heavy memory wise.
                                // Instead, we accept the overhead but add a fast distance check first?
                                // The original code iterated MobileParty.All (N) for every Syndicate Party (K). O(K*N).
                                // We can't easily avoid N without a spatial grid for parties.
                                // BUT we can fast-fail.
                                
                                // Better approach: Since we already have 'allAggressors' (1% of parties), maybe we only merge with them?
                                // No, that splits the logic.
                                
                                // Let's optimize the loop by using MobileParty.All but with strict fast-fail.
                                // Actually, let's just stick to the plan: Pre-calculate potential recruits if possible.
                                // Or, use the 'allAggressors' list if we assume other bandits are also being ticked? 
                                // No, they might not be in the 1% slice.
                                
                                // Revised Optimization:
                                // Iterate MobileParty.All but strictly filter for Bandits.
                                // Is there a Cached List of Bandits? No.
                                // Let's use the local list 'allAggressors' as the primary candidates for merging? 
                                // That implies Syndicate only merges with 1% of bandits per tick. That is actually FINE for performance and gameplay balance.
                                // It spreads the absorption over time.
                                
                                foreach(var p in allAggressors)
                                {
                                    if (p == bandit || !p.IsActive || p.IsMainParty) continue;
                                    // p is already confirmed bandit/syndicate in allAggressors
                                    
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
                        float bestScore = -1f;                        
                        float bestPartyScore = -1f; 
                        
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

                                         // Logic Refactor: Smart Targeting (Score based on Wealth vs Defense vs Distance)
                                         // Score = (Hearths * 2 + Prosperity/20) / (Distance + Militia*5)
                                         
                                         float dSq = banditPos.DistanceSquared(s.Position);
                                         if (dSq > maxDistSq) continue;

                                         if (isNaval)
                                         {
                                             if (!_coastalCache.TryGetValue(s, out bool isCoastal) || !isCoastal) continue;
                                         }

                                         int mStr = s.MilitiaPartyComponent.MobileParty.MemberRoster.TotalManCount;
                                         int bStr = (bandit.MemberRoster != null) ? bandit.MemberRoster.TotalManCount : 0;
                                         
                                         // Must be able to beat them
                                         if (bStr > (mStr * effectiveRatio))
                                         {
                                             float wealthScore = s.Village.Hearth + (s.Town != null ? s.Town.Prosperity / 20f : 0f);
                                             float riskDistFactor = (dSq / 100f) + (mStr * 2f); // Distance + Militia penalty
                                             if (riskDistFactor < 1f) riskDistFactor = 1f;

                                             float score = wealthScore / riskDistFactor;

                                             if (score > bestScore)
                                             {
                                                 bestScore = score;
                                                 bestTarget = s;
                                             }
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
                                if (dSq < maxDistSq)
                                {
                                    int pStr = prey.MemberRoster.TotalManCount;
                                    int bStr = bandit.MemberRoster.TotalManCount;
                                    
                                    if (bStr > (pStr * effectiveRatio))
                                    {
                                         // Party Score: Gold/Loot Estimate vs Distance
                                         float value = (prey.IsCaravan ? 500f : 100f);
                                         float score = value / ((dSq/100f) + 1f);
                                         
                                         if (score > bestPartyScore)
                                         {
                                             bestPartyScore = score;
                                             bestPartyTarget = prey;
                                         }
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
