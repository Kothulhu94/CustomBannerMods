using System;
using System.IO;
using System.Reflection;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Events;
using Bannerlord.ButterLib.Common.Extensions;
using Bannerlord.ButterLib.Extensions;
using HarmonyLib;

namespace Landlord
{
    public class SubModule : MBSubModuleBase
    {
        private static readonly string LogPath = @"d:\Bannerlord_Mods\logs\Landlord.log";
        private Serilog.ILogger _serilogLogger;

        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();

            // 1. Initialize Serilog
            _serilogLogger = new LoggerConfiguration()
                .WriteTo.File(LogPath, rollingInterval: RollingInterval.Infinite, outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
                .MinimumLevel.Debug()
                .CreateLogger();

            _serilogLogger.Information("Landlord Module Loaded via Four Pillars Stack");

            // 2. Initialize Harmony
            try
            {
                var harmony = new Harmony("com.landlord.mod");
                harmony.PatchAll();
                _serilogLogger.Information("Harmony patches applied.");
            }
            catch (Exception ex)
            {
                _serilogLogger.Error(ex, "Error initializing Harmony.");
            }

            // 3. Register Services
            var services = this.GetServices();
            if (services != null)
            {
                this.AddSerilogLoggerProvider(LogPath, new[] { "Landlord" });
                services.AddSingleton<EconomyBehavior>();
                services.AddSingleton<ViolenceBehavior>();
                // LandlordFinanceModel is a Model, usually just added, but we can register if it needs dependencies.
                // Models in Bannerlord are not usually DI friendly unless we wrap them. 
                // We'll just instantiate it manually or transiently.
                services.AddTransient<LandlordFinanceModel>();
            }
        }

        protected override void OnGameStart(Game game, IGameStarter gameStarterObject)
        {
            base.OnGameStart(game, gameStarterObject);

            if (game.GameType is Campaign)
            {
                CampaignGameStarter campaignStarter = (CampaignGameStarter)gameStarterObject;
                var serviceProvider = this.GetServiceProvider();

                try
                {
                    // Add Behaviors
                    campaignStarter.AddBehavior(serviceProvider.GetRequiredService<EconomyBehavior>());
                    campaignStarter.AddBehavior(serviceProvider.GetRequiredService<ViolenceBehavior>());

                    // Add Models
                    campaignStarter.AddModel(serviceProvider.GetRequiredService<LandlordFinanceModel>());
                    
                    _serilogLogger.Information("Landlord behaviors and models registered.");
                }
                catch (Exception ex)
                {
                    _serilogLogger.Error(ex, "Error registering Landlord behaviors/models.");
                }
            }
        }
    }
}
