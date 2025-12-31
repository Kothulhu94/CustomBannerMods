using System;
using System.Collections.Generic;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.MapEvents;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;
using Microsoft.Extensions.Logging;

namespace Brigands.Recruitment
{
    public class PressGangBehavior : CampaignBehaviorBase
    {
        private readonly ILogger<PressGangBehavior> _logger;
        private readonly GlobalSettings _settings;

        public PressGangBehavior(ILogger<PressGangBehavior> logger, GlobalSettings settings)
        {
            _logger = logger;
            _settings = settings;
        }

        public override void RegisterEvents()
        {
            CampaignEvents.MapEventEnded.AddNonSerializedListener(this, OnMapEventEnded);
            CampaignEvents.DailyTickPartyEvent.AddNonSerializedListener(this, OnDailyTickParty);
        }

        public override void SyncData(IDataStore dataStore) { }

        private void OnDailyTickParty(MobileParty party)
        {
            try
            {
                if (party == null || !party.IsActive) return;
                if (party.MapEvent != null) return; 
                
                if (party.TargetParty == MobileParty.MainParty) return;

                if (party.MapFaction == null) return;

                bool isBandit = party.MapFaction.IsBanditFaction || party.MapFaction.IsOutlaw;
                try { if (party.MapFaction.StringId.ToLower().Contains("deserter")) isBandit = true; } catch {}

                bool isTarget = party.MapFaction != null && (isBandit || party.MapFaction.StringId == "TheSyndicate");

                if (isTarget && party.PrisonRoster.TotalManCount > 0)
                {
                    var prisoners = party.PrisonRoster.GetTroopRoster().ToList();
                    foreach (var element in prisoners)
                    {
                        if (element.Character != null && !element.Character.IsHero)
                        {
                            int recruitCount = 0;
                            for(int i=0; i < element.Number; i++)
                            {
                                if (MBRandom.RandomInt(100) < _settings.DailyRecruitChance) recruitCount++;
                            }

                            if (recruitCount > 0)
                            {
                                party.MemberRoster.AddToCounts(element.Character, recruitCount);
                                party.PrisonRoster.AddToCounts(element.Character, -recruitCount);
                                
                                if (_settings.DebugMode)
                                     _logger.LogInformation($"PressGang: {party.Name} recruiting {recruitCount} {element.Character.Name}");
                            }
                        }
                    }
                    try { UpdateBanditName(party); } catch {}
                }
            }
            catch (Exception ex)
            {
                 _logger.LogError(ex, "Error in PressGangBehavior.OnDailyTickParty");
            }
        }

        private void OnMapEventEnded(MapEvent mapEvent)
        {
            try
            {
                if (mapEvent == null) return;
                if (mapEvent.WinningSide == BattleSideEnum.None) return;

                var winnerSide = mapEvent.WinningSide;
                var winnerParty = winnerSide == BattleSideEnum.Attacker ? mapEvent.AttackerSide.LeaderParty : mapEvent.DefenderSide.LeaderParty;

                if (winnerParty == null) return;
                if (winnerParty.MapFaction == null) return;

                bool isBandit = winnerParty.MapFaction.IsBanditFaction || winnerParty.MapFaction.IsOutlaw;
                try { if (winnerParty.MapFaction.StringId.ToLower().Contains("deserter")) isBandit = true; } catch {}

                bool isTarget = (isBandit || winnerParty.MapFaction.StringId == "TheSyndicate");

                if (isTarget && winnerParty.MobileParty != null && winnerParty.MobileParty.IsActive)
                {
                    var mobileParty = winnerParty.MobileParty;

                    if (mapEvent.IsRaid)
                    {
                        int count = MBRandom.RandomInt(5, 16);
                        
                        var recruit = Game.Current.ObjectManager.GetObject<CharacterObject>("looter");
                        if (recruit != null)
                        {
                            mobileParty.MemberRoster.AddToCounts(recruit, count);
                            if (_settings.DebugMode)
                                _logger.LogInformation($"PressGang: {mobileParty.Name} won a raid! Gained {count} recruits.");
                        }
                        UpdateBanditName(mobileParty);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in PressGangBehavior.OnMapEventEnded");
            }
        }

        public void UpdateBanditName(MobileParty party)
        {
            try
            {
                if (party == null || party.MemberRoster == null || party.Party == null) return;

                if (party.MemberRoster.TotalManCount > _settings.MaxHordeSizeBase)
                {
                     try 
                     {
                         string cultureName = party.Party.Culture?.Name?.ToString() ?? "Bandit";
                         party.Party.SetCustomName(new TextObject($"Grand {cultureName} Horde"));
                     }
                     catch {}
                }
            }
            catch {}
        }
    }
}

