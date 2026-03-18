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
                // Initialize the shared Core (Harmony + Logging)
                LivingWorld.LivingWorldCore.Initialize();

                if (GlobalSettings.Instance != null && !GlobalSettings.Instance.ModuleEnabled)
                    return;

                var services = this.GetServices();
                if (services != null)
                {
                    services.AddSingleton<GovernorService>();
                    services.AddSingleton<AutoResolveIssuesBehavior>();
                    LivingWorld.LivingWorldCore.Logger.Information("BetterGov: Services registered.");
                }
            }
            catch (Exception ex)
            {
                LivingWorld.LivingWorldCore.Logger?.Error(ex, "BetterGov: Failed during startup.");
            }
        }

        protected override void OnGameStart(Game game, IGameStarter gameStarterObject)
        {
            base.OnGameStart(game, gameStarterObject);

            if (game.GameType is Campaign)
            {
                var campaignStarter = (CampaignGameStarter)gameStarterObject;
                var serviceProvider = game.GetServiceProvider();

                // Use the shared logger instead of DI ILogger which might not be registered correctly
                var logger = LivingWorld.LivingWorldCore.Logger;
                logger?.Information("BetterGov: OnGameStart triggered.");

                if (serviceProvider != null)
                {
                    if (GlobalSettings.Instance != null && !GlobalSettings.Instance.ModuleEnabled) 
                    {
                        logger?.Information("BetterGov: Module disabled in settings.");
                        return;
                    }

                    // Add Behaviors
                    try
                    {
                        var issuesBehavior = serviceProvider.GetRequiredService<AutoResolveIssuesBehavior>();
                        if (issuesBehavior != null)
                        {
                            campaignStarter.AddBehavior(issuesBehavior);
                            logger?.Information("BetterGov: AutoResolveIssuesBehavior registered.");
                        }
                    }
                    catch (Exception ex)
                    {
                        logger?.Error(ex, "BetterGov: Failed to register AutoResolveIssuesBehavior.");
                    }
                }
            }
        }
    }
}
