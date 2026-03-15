using System;
using System.IO;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;
using TaleWorlds.CampaignSystem;
using FieldSquire.Behaviors;
using Bannerlord.ButterLib.Extensions;
using Bannerlord.ButterLib.Common.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using TaleWorlds.Library;

namespace FieldSquire
{
    public class FieldSquireSubModule : MBSubModuleBase
    {
        // Wrapper for legacy compatibility within this namespace
        public static Serilog.ILogger Logger => LivingWorld.LivingWorldCore.Logger;

        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();
            try
            {
                // Initialize Central Core (Harmony + Unified Logging)
                LivingWorld.LivingWorldCore.Initialize();

                if (GlobalSettings.Instance != null && !GlobalSettings.Instance.ModuleEnabled)
                {
                    Logger?.Information("FieldSquire: Disabled via MCM.");
                    return;
                }

                // Register Services (ButterLib)
                var services = this.GetServices();
                if (services != null)
                {
                    LivingWorld.LivingWorldCore.RegisterServices(services);
                    services.AddSingleton(sp => GlobalSettings.Instance);
                    services.AddScoped<SquireDialogBehavior>();
                    services.AddScoped<SquireSpawnBehavior>();
                    services.AddScoped<SquireLogisticsBehavior>();
                }
            }
            catch (Exception ex)
            {
                Logger?.Error(ex, "FieldSquire: FAILED during OnSubModuleLoad");
            }
        }

        protected override void OnGameStart(Game game, IGameStarter gameStarter)
        {
            base.OnGameStart(game, gameStarter);

            if (game.GameType is Campaign)
            {
                CampaignGameStarter campaignStarter = (CampaignGameStarter)gameStarter;
                if (GlobalSettings.Instance != null && !GlobalSettings.Instance.ModuleEnabled) return;

                var serviceProvider = this.GetServiceProvider();
                if (serviceProvider != null)
                {
                    campaignStarter.AddBehavior(serviceProvider.GetRequiredService<SquireSpawnBehavior>());
                    campaignStarter.AddBehavior(serviceProvider.GetRequiredService<SquireDialogBehavior>());
                    campaignStarter.AddBehavior(serviceProvider.GetRequiredService<SquireLogisticsBehavior>());
                    Logger?.Information("FieldSquire: Behaviors registered via DI.");
                }
                else
                {
                    // Fallback using living world core logger
                    var factory = new LoggerFactory();
                    if (Logger != null) factory.AddSerilog(Logger);

                    campaignStarter.AddBehavior(new SquireSpawnBehavior(factory.CreateLogger<SquireSpawnBehavior>(), GlobalSettings.Instance));
                    campaignStarter.AddBehavior(new SquireDialogBehavior(factory.CreateLogger<SquireDialogBehavior>(), GlobalSettings.Instance));
                    campaignStarter.AddBehavior(new SquireLogisticsBehavior(factory.CreateLogger<SquireLogisticsBehavior>(), GlobalSettings.Instance));
                    Logger?.Information("FieldSquire: Behaviors registered via Manual Fallback.");
                }
            }
        }
    }
}
