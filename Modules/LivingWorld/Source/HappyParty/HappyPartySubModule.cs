using System;
using System.IO;
using Bannerlord.ButterLib.Common.Extensions;
using Microsoft.Extensions.DependencyInjection;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;
using HarmonyLib;
using Serilog;
using MCM.Abstractions.Base.Global;
using TaleWorlds.Library;

namespace HappyParty
{
    public class HappyPartySubModule : MBSubModuleBase
    {
        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();
            try {
                // Initialize the shared Core
                LivingWorld.LivingWorldCore.Initialize();

                var services = this.GetServices();
                if (services != null)
                {
                    LivingWorld.LivingWorldCore.RegisterServices(services);
                    services.AddSingleton(sp => GlobalSettings.Instance ?? new GlobalSettings());
                    services.AddScoped<CustomWandererSpawnBehavior>();
                    services.AddScoped<EliteRecruiterBehavior>();
                    services.AddScoped<GourmetArmyBehavior>();
                    services.AddScoped<JobSeekerBehavior>();
                    services.AddScoped<RansomPrisonerBehavior>();
                    services.AddScoped<TavernCleanerBehavior>();
                    services.AddScoped<TavernShooBehavior>();
                    services.AddScoped<CompanionManagementBehavior>();
                }

                if (GlobalSettings.Instance != null && !GlobalSettings.Instance.ModuleEnabled)
                {
                    LivingWorld.LivingWorldCore.Logger?.Information("HappyParty: Disabled via MCM.");
                    return;
                }
            }
            catch (Exception ex)
            {
                 LivingWorld.LivingWorldCore.Logger?.Error(ex, "HappyParty CRITICAL: Startup Failed.");
            }
        }

        protected override void OnGameStart(Game game, IGameStarter gameStarterObject)
        {
            base.OnGameStart(game, gameStarterObject);

            if (game.GameType is Campaign)
            {
                CampaignGameStarter campaignStarter = (CampaignGameStarter)gameStarterObject;
                var serviceProvider = game.GetServiceProvider();

                if (serviceProvider != null)
                {
                    if (GlobalSettings.Instance != null && !GlobalSettings.Instance.ModuleEnabled) return;

                    // Add Behaviors using DI
                    campaignStarter.AddBehavior(serviceProvider.GetRequiredService<RansomPrisonerBehavior>());
                    campaignStarter.AddBehavior(serviceProvider.GetRequiredService<GourmetArmyBehavior>());
                    campaignStarter.AddBehavior(serviceProvider.GetRequiredService<EliteRecruiterBehavior>());
                    campaignStarter.AddBehavior(serviceProvider.GetRequiredService<JobSeekerBehavior>());
                    campaignStarter.AddBehavior(serviceProvider.GetRequiredService<TavernCleanerBehavior>());
                    campaignStarter.AddBehavior(serviceProvider.GetRequiredService<TavernShooBehavior>());
                    campaignStarter.AddBehavior(serviceProvider.GetRequiredService<CompanionManagementBehavior>());
                    campaignStarter.AddBehavior(serviceProvider.GetRequiredService<CustomWandererSpawnBehavior>());
                    
                    serviceProvider.GetRequiredService<Serilog.ILogger>().Information("HappyParty Loaded with ButterLib Services.");
                }
                else
                {
                    // Fallback if ButterLib services are missing
                }
            }
        }
    }
}
