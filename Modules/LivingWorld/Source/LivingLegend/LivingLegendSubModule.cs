using System;
using System.IO;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;
using TaleWorlds.Library;
using Bannerlord.ButterLib.Common.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Events;

namespace LivingLegend
{
    public class LivingLegendSubModule : MBSubModuleBase
    {
        private static Microsoft.Extensions.Logging.ILogger _logger;
        public static Microsoft.Extensions.Logging.ILogger Logger => _logger;

        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();

            try
            {
                // Initialize Central Core
                LivingWorld.LivingWorldCore.Initialize();

                // Assign Logger for legacy internal support
                var factory = new LoggerFactory();
                if (LivingWorld.LivingWorldCore.Logger != null) factory.AddSerilog(LivingWorld.LivingWorldCore.Logger);
                _logger = factory.CreateLogger<LivingLegendSubModule>();

                if (GlobalSettings.Instance != null && !GlobalSettings.Instance.ModuleEnabled)
                {
                    LivingWorld.LivingWorldCore.Logger?.Information("LivingLegend: disabled via MCM.");
                    return; 
                }
            }
            catch (Exception ex)
            {
                LivingWorld.LivingWorldCore.Logger?.Error(ex, "LivingLegend: Error during startup.");
            }

            // Register Services
            var services = this.GetServices();
            if (services != null)
            {
                services.AddScoped<GlobalSettings>(sp => GlobalSettings.Instance);
                services.AddScoped<LivingLegendBehavior>();
                services.AddScoped<LivingLegendClanTierModel>();
                services.AddScoped<LivingLegendMilitiaModel>();
                services.AddScoped<LivingLegendLoyaltyModel>();
                LivingWorld.LivingWorldCore.Logger?.Information("LivingLegend: Services registered.");
            }
        }

        protected override void OnGameStart(Game game, IGameStarter gameStarterObject)
        {
            base.OnGameStart(game, gameStarterObject);
            if (game.GameType is Campaign)
            {
                CampaignGameStarter campaignStarter = (CampaignGameStarter)gameStarterObject;
                var serviceProvider = this.GetServiceProvider();
                
                if (serviceProvider != null)
                {

                     var settings = serviceProvider.GetRequiredService<GlobalSettings>();
                     if (settings != null && !settings.ModuleEnabled) return;

                     campaignStarter.AddBehavior(serviceProvider.GetRequiredService<LivingLegendBehavior>());
                     campaignStarter.AddModel(serviceProvider.GetRequiredService<LivingLegendClanTierModel>());
                     campaignStarter.AddModel(serviceProvider.GetRequiredService<LivingLegendMilitiaModel>());
                     campaignStarter.AddModel(serviceProvider.GetRequiredService<LivingLegendLoyaltyModel>());
                }
            }
        }
    }
}
