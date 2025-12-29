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

            // 1. Initialize Serilog (Robust Mode - Same as FieldSquire)
            _serilogLogger = new LoggerConfiguration()
                .WriteTo.File(LogPath, rollingInterval: RollingInterval.Infinite, shared: true, 
                    outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
                .MinimumLevel.Debug()
                .CreateLogger();

            Log.Logger = _serilogLogger; // Assign Global Shared Logger
            _serilogLogger.Information("Landlord Module Loaded via Four Pillars Stack");

            // 2. Initialize Harmony
            try
            {
                // Harmony.DEBUG = true; // REMOVED: Global instability
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
                // Match FieldSquire's Robust DI Registration
                services.AddLogging(loggingBuilder =>
                {
                    loggingBuilder.AddSerilog(_serilogLogger);
                });

                services.AddSingleton<EconomyBehavior>();
                services.AddSingleton<ViolenceBehavior>();
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
