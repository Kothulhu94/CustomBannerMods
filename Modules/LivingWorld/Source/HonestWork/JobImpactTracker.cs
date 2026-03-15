using System;
using System.Collections.Generic;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Library;

namespace HonestWork
{
    public static class JobImpactTracker
    {
        private static bool _calculating = false;

        public struct ImpactResult
        {
            public float Security;
            public float Loyalty;
            public float Prosperity;
            public float Militia;
            public float GarrisonXP; 
            public float GarrisonChange; 
            public float Food;
            public float Hearth;
        }

        public static ImpactResult CalculateHeroImpact(Hero hero, string jobId, Town townContext = null)
        {
            var result = new ImpactResult();
            if (hero == null || string.IsNullOrEmpty(jobId)) return result;

            if (GlobalSettings.Instance == null) return result;
            var settings = GlobalSettings.Instance;

            bool isAi = hero != Hero.MainHero;
            float hourlyVal = isAi ? settings.AiEffectMagnitude : settings.TownEffectMagnitude; 
            float dailyMult = 24.0f;
            float totalDailyVal = hourlyVal * dailyMult;

            switch (jobId)
            {
                case "guard":
                    result.Security += totalDailyVal;
                    result.Prosperity += totalDailyVal;
                    break;
                case "thug":
                    result.Security -= totalDailyVal;
                    result.Loyalty -= totalDailyVal;
                    break;
                case "artisan":
                    result.Prosperity += totalDailyVal;
                    result.Militia += totalDailyVal;
                    break;
                case "official":
                    result.Prosperity += totalDailyVal;
                    result.Food += (5f * 24f); 
                    break;
                case "physician":
                    result.Loyalty += totalDailyVal;
                    break;
                case "outrider":
                    // Desertion Check (Overcrowding only)
                    bool desertion = false;
                    if (townContext != null)
                    {
                        int overcrowding = HonestWorkHelpers.GetGarrisonOvercrowding(townContext);
                        if (overcrowding >= 10) desertion = true;
                    }

                    if (desertion)
                    {
                         result.GarrisonXP += (20f * 24f); // Double XP
                         result.Security += (0.5f * 24f); 
                    }
                    else
                    {
                         result.GarrisonChange += (1f * 24f); 
                         result.GarrisonXP += (10f * 24f);
                         result.Security += (0.5f * 24f);
                    }
                    break;
                case "deckhand":
                    result.Prosperity += totalDailyVal;
                    break;
                case "shipwright":
                    result.Prosperity += totalDailyVal;
                    result.Militia += totalDailyVal;
                    break;
                case "harbormaster":
                    result.Prosperity += totalDailyVal;
                    result.Loyalty += totalDailyVal;
                    break;
                case "instructor":
                    result.GarrisonXP += (10f * 24f);
                    result.Militia += totalDailyVal;
                    break;
            }

            return result;
        }

        public static List<Tuple<Hero, ImpactResult>> GetSettlementImpacts(Settlement settlement)
        {
            if (_calculating) return new List<Tuple<Hero, ImpactResult>>();
            
            var list = new List<Tuple<Hero, ImpactResult>>();
            if (settlement == null) return list;

            try
            {
                _calculating = true;
                
                var jobBehavior = Campaign.Current.GetCampaignBehavior<TownJobBehavior>();
                if (jobBehavior == null) return list;
                
                Town town = settlement.Town;

                // 1. Check Workers in Town (Heroes without party)
                if (settlement.HeroesWithoutParty != null)
                {
                    foreach (var hero in settlement.HeroesWithoutParty)
                    {
                        if (hero.IsAlive)
                        {
                            string job = jobBehavior.GetHeroJob(hero);
                            if (job != null)
                            {
                                list.Add(new Tuple<Hero, ImpactResult>(hero, CalculateHeroImpact(hero, job, town)));
                            }
                        }
                    }
                }

                // 2. Check Parties in Town
                if (settlement.Parties != null)
                {
                    foreach (var party in settlement.Parties)
                    {
                        if (party.LeaderHero != null)
                        {
                            string job = jobBehavior.GetHeroJob(party.LeaderHero);
                            if (job != null)
                            {
                                list.Add(new Tuple<Hero, ImpactResult>(party.LeaderHero, CalculateHeroImpact(party.LeaderHero, job, town)));
                            }
                        }
                    }
                }
            }
            finally
            {
                _calculating = false;
            }

            return list;
        }
    }
}
