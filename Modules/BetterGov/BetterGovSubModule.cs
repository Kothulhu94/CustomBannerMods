using System;
using System.IO;
using Bannerlord.ButterLib.Common.Extensions;
using HarmonyLib;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Events;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.ModuleManager;
using TaleWorlds.Library;
using TaleWorlds.MountAndBlade;
using Bannerlord.ButterLib.Extensions;

namespace BetterGov
{
    public class BetterGovSubModule : MBSubModuleBase
    {
        private const string ModuleId = "BetterGov";

        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();
            try {
                // Calculate Path Manually
                string logPath = @"d:\Bannerlord_Mods\logs\BetterGov.log";

                var services = this.GetServices();
                if (services != null)
                {
                    // Use ButterLib's scoped logger extension to prevent log bleeding
                    this.AddSerilogLoggerProvider(logPath, new[] { "BetterGov" });

                    services.AddSingleton<GovernorService>();
                    services.AddSingleton<AutoResolveIssuesBehavior>();

                    // Patch AFTER logging is setup
                    new Harmony("com.bettergov").PatchAll();
                    Log.Information("BetterGov Harmony patches applied.");
                }
                else
                {
                    File.AppendAllText(@"d:\Bannerlord_Mods\logs\panic.log", "[BetterGov] CRITICAL: Services container is null. Dependency Injection failed.\n");
                }
            }
            catch (Exception ex)
            {
                try 
                {
                    File.AppendAllText(@"d:\Bannerlord_Mods\logs\panic.log", $"[BetterGov] CRITICAL: Init Failed: {ex}\n"); 
                } catch { }

                Log.Error(ex, "BetterGov CRITICAL: Failed during startup.");
            }
        }

        protected override void OnGameStart(Game game, IGameStarter gameStarterObject)
        {
            if (game.GameType is Campaign)
            {
                var campaignStarter = (CampaignGameStarter)gameStarterObject;
                var serviceProvider = game.GetServiceProvider();

                if (serviceProvider != null)
                {
                    var logger = serviceProvider.GetRequiredService<ILogger<BetterGovSubModule>>();
                    logger.LogInformation("BetterGov Starting... Dependency Injection Active.");

                    // Add Behaviors (Resolved from DI)
                    try
                    {
                        var issuesBehavior = serviceProvider.GetRequiredService<AutoResolveIssuesBehavior>();
                        campaignStarter.AddBehavior(issuesBehavior);
                        logger.LogInformation("AutoResolveIssuesBehavior registered.");
                    }
                    catch (Exception ex)
                    {
                        logger.LogError(ex, "Failed to register AutoResolveIssuesBehavior.");
                    }
                }
            }
        }
    }
}
