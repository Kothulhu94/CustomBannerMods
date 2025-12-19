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
                // 1. Setup Logging via ButterLib Standard
                this.AddSerilogLoggerProvider(@"d:\Bannerlord_Mods\logs\HappyParty.log", new[] { "HappyParty.*" }, config =>
                {
                    bool debugMode = false;
                    try
                    {
                        // Accessing GlobalSettings.Instance this early might be unsafe if MCM isn't ready
                        if (GlobalSettings.Instance != null && GlobalSettings.Instance.DebugMode)
                        {
                            debugMode = true;
                        }
                    }
                    catch { /* MCM might not be ready, default to Info */ }

                    if (debugMode)
                    {
                        config.MinimumLevel.Debug();
                    }
                    else
                    {
                        config.MinimumLevel.Information();
                    }
                });

                // 1.1 Apply Patches AFTER Logging
                new Harmony("com.happyparty").PatchAll();
                Log.Information("HappyParty Harmony patches applied.");

                // 2. Register Services via ButterLib
                var services = this.GetServices();
                if (services != null)
                {
                    // Register as factory to delay instantiation until OnGameStart (safer for MCM)
                    services.AddSingleton(sp => GlobalSettings.Instance ?? new GlobalSettings());

                    // Register Serilog.ILogger explicitly
                    services.AddSingleton<Serilog.ILogger>(_ => Log.Logger);

                    // 3. Register Behaviors
                    services.AddScoped<CustomWandererSpawnBehavior>();
                    services.AddScoped<EliteRecruiterBehavior>();
                    services.AddScoped<GourmetArmyBehavior>();
                    services.AddScoped<JobSeekerBehavior>();
                    services.AddScoped<RansomPrisonerBehavior>();
                    services.AddScoped<TavernCleanerBehavior>();
                }
            }
            catch (Exception ex)
            {
                 try 
                 {
                     File.AppendAllText(@"d:\Bannerlord_Mods\logs\panic.log", $"[HappyParty] CRITICAL: Init Failed: {ex}\n"); 
                 } catch { }
                 
                 Log.Error(ex, "HappyParty CRITICAL: Startup Failed.");
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
                    // Add Behaviors using DI
                    campaignStarter.AddBehavior(serviceProvider.GetRequiredService<RansomPrisonerBehavior>());
                    campaignStarter.AddBehavior(serviceProvider.GetRequiredService<GourmetArmyBehavior>());
                    campaignStarter.AddBehavior(serviceProvider.GetRequiredService<EliteRecruiterBehavior>());
                    campaignStarter.AddBehavior(serviceProvider.GetRequiredService<JobSeekerBehavior>());
                    campaignStarter.AddBehavior(serviceProvider.GetRequiredService<TavernCleanerBehavior>());
                    campaignStarter.AddBehavior(serviceProvider.GetRequiredService<CustomWandererSpawnBehavior>());
                    
                    serviceProvider.GetRequiredService<Serilog.ILogger>().Information("HappyParty Loaded with ButterLib Services.");
                }
                else
                {
                    // Fallback should likely not happen if ButterLib is loaded
                    // But if it does, we can't do much without the logger setup.
                }
            }
        }
    }
}
