using System;
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

            // Setup Isolated Serilog Logger
            // writing to d:\Bannerlord_Mods\logs\LivingLegend.log
            var serilogLogger = new LoggerConfiguration()
                .WriteTo.File("d:\\Bannerlord_Mods\\logs\\LivingLegend.log", rollingInterval: RollingInterval.Infinite)
                .CreateLogger();

            _logger = new Serilog.Extensions.Logging.SerilogLoggerFactory(serilogLogger).CreateLogger<LivingLegendSubModule>();

            try
            {
                var harmony = new HarmonyLib.Harmony("com.prophecy.livinglegend");
                LivingLegendPatches.Apply(harmony);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to apply patches in SubModuleLoad");
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
                
                // Register the isolated logger so DI can inject it into behaviors/models
                services.AddSingleton<Microsoft.Extensions.Logging.ILogger>(_logger);
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
                     campaignStarter.AddBehavior(serviceProvider.GetRequiredService<LivingLegendBehavior>());
                     campaignStarter.AddModel(serviceProvider.GetRequiredService<LivingLegendClanTierModel>());
                     campaignStarter.AddModel(serviceProvider.GetRequiredService<LivingLegendMilitiaModel>());
                     campaignStarter.AddModel(serviceProvider.GetRequiredService<LivingLegendLoyaltyModel>());
                }
            }
        }
    }
}
