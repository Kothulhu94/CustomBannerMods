using System;
using System.Collections.Generic;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.Map;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;
using Microsoft.Extensions.Logging;

namespace Brigands.Merge
{
    public class BanditCohesionBehavior : CampaignBehaviorBase
    {
        private readonly ILogger<BanditCohesionBehavior> _logger;
        private readonly GlobalSettings _settings;

        public BanditCohesionBehavior(ILogger<BanditCohesionBehavior> logger, GlobalSettings settings)
        {
            _logger = logger;
            _settings = settings;
        }

        public override void SyncData(IDataStore dataStore) { }

        public override void RegisterEvents()
        {
            // Merging is handled by Harmony Patch on MapEvent.FinalizeEvent calling MergeParties
        }

        public void MergeParties(List<MobileParty> candidateParties)
        {
            try
            {
                int playerTier = (Clan.PlayerClan != null) ? Clan.PlayerClan.Tier : 0;
                int mergeCount = 0;
                
                List<MobileParty> safeBandits = candidateParties
                    .Where(p => p != null && p.IsActive && p.MapFaction != null && 
                           (p.MapFaction.IsBanditFaction || p.MapFaction.StringId == "TheSyndicate" || p.MapFaction.IsOutlaw))
                    .ToList();

                if (safeBandits.Count < 2) return;

                safeBandits.Sort((a, b) => 
                {
                    bool aSyn = (a.MapFaction.StringId == "TheSyndicate");
                    bool bSyn = (b.MapFaction.StringId == "TheSyndicate");
                    if (aSyn && !bSyn) return -1;
                    if (!aSyn && bSyn) return 1;
                    return b.MemberRoster.TotalManCount.CompareTo(a.MemberRoster.TotalManCount);
                });

                MobileParty survivor = safeBandits[0];
                int cap = _settings.MaxHordeSizeBase + (playerTier * _settings.PerClanTierBonus);
                bool allowNaval = _settings.EnableNavalMerging;

                for (int i = 1; i < safeBandits.Count; i++)
                {
                    MobileParty victim = safeBandits[i];
                    if (victim == survivor || !victim.IsActive) continue;

                    bool survivorNaval = IsNaval(survivor);
                    bool victimNaval = IsNaval(victim);

                    if (!allowNaval && (survivorNaval || victimNaval)) continue;
                    if (survivorNaval != victimNaval) continue;

                    if (victim.LeaderHero != null) continue;

                    if (survivor.MemberRoster.TotalManCount >= cap) 
                    {
                        survivor = victim; 
                        continue;
                    }

                    if (survivor.MemberRoster.TotalManCount + victim.MemberRoster.TotalManCount <= cap)
                    {
                         try
                        {
                            if (_settings.DebugMode)
                                _logger.LogInformation($"MERGING: {victim.Name} ({victim.MemberRoster.TotalManCount}) -> {survivor.Name} ({survivor.MemberRoster.TotalManCount}) [Naval: {survivorNaval}]");
                            
                            var troops = victim.MemberRoster.GetTroopRoster().ToList();
                            foreach(var t in troops)
                            {
                                survivor.MemberRoster.AddToCounts(t.Character, t.Number);
                            }
                            
                            var prisoners = victim.PrisonRoster.GetTroopRoster().ToList();
                            foreach(var p in prisoners)
                            {
                                survivor.PrisonRoster.AddToCounts(p.Character, p.Number);
                            }
                            
                            victim.MemberRoster.Clear();
                            
                            UpdateBanditName(survivor);
                            
                            DestroyPartyAction.Apply(survivor.Party, victim);
                            mergeCount++;
                        }
                        catch (Exception ex) 
                        {
                            _logger.LogError(ex, "Error during merge");
                        }
                    }
                }
                
                if (mergeCount > 0 && _settings.DebugMode) _logger.LogInformation($"Total Merges this battle: {mergeCount}");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in MergeParties outer block");
            }
        }

        private bool IsNaval(MobileParty party)
        {
            if (party == null) return false;
            try
            {
                if (party.Name != null)
                {
                    string nm = party.Name.ToString().ToLower();
                    if (nm.Contains("sea raider") || nm.Contains("pirate") || nm.Contains("corsair")) return true;
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

        public void UpdateBanditName(MobileParty party)
        {
            try
            {
                if (party.MemberRoster.GetTroopRoster().Count > 1)
                {
                     if (party.MemberRoster.TotalManCount > _settings.MaxHordeSizeBase)
                    {
                         try 
                         {
                             bool isSyndicate = false;
                             try { isSyndicate = (party.MapFaction != null && party.MapFaction.StringId == "TheSyndicate"); } catch {}

                             if (isSyndicate && party.LeaderHero != null) return;

                             string prefix = isSyndicate ? "Syndicate" : "Grand";
                             TextObject newName = new TextObject($"{prefix} {party.Party.Culture.Name} Horde");
                             
                             party.Party.SetCustomName(newName);
                         }
                         catch {}
                    }
                }
            }
            catch {}
        }
    }
}

