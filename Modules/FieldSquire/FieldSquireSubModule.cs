using System;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;
using TaleWorlds.CampaignSystem;
using HarmonyLib;
using FieldSquire.Behaviors;
using Bannerlord.ButterLib.Extensions;
using Bannerlord.ButterLib.Common.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Serilog;
using Serilog.Events;
using System.IO;

namespace FieldSquire
{
    public class FieldSquireSubModule : MBSubModuleBase
    {
        public static Serilog.ILogger Logger { get; private set; }
        private static readonly string LogPath = @"d:\Bannerlord_Mods\logs\FieldSquire.log";

        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();
            
            try 
            {
                // ROBUST LOGGING: Initialize manually to ensure file creation immediately
                // We use Shared=true to avoid locking issues, and minimal locking otherwise.
                Log.Logger = new LoggerConfiguration()
                    .MinimumLevel.Debug()
                    .WriteTo.File(LogPath, 
                        rollingInterval: RollingInterval.Infinite,
                        shared: true,
                        outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
                    .CreateLogger();

                Logger = Log.Logger;
                Logger.Information("FieldSquire: Logger Initialized Manually (Robust Mode).");

                // 2. Register Services (ButterLib) if available
                var services = this.GetServices();
                if (services != null)
                {
                    Logger.Information("FieldSquire: Registering services with ButterLib container...");
                    
                    services.AddLogging(loggingBuilder =>
                    {
                        loggingBuilder.AddSerilog(Logger);
                    });
                    
                    // Register GlobalSettings
                    services.AddSingleton<GlobalSettings>(sp => GlobalSettings.Instance ?? new GlobalSettings());

                    // Register Behaviors
                    services.AddScoped<SquireSpawnBehavior>();
                    services.AddScoped<SquireDialogBehavior>();
                    services.AddScoped<SquireLogisticsBehavior>();
                }
                else
                {
                    Logger.Warning("FieldSquire: ButterLib IServiceCollection is null. Falling back to local instantiation.");
                }

                // 3. Initialize Harmony
                 new Harmony("com.fieldsquire.mod").PatchAll();
                 Logger.Information("FieldSquire: Harmony Patches applied successfully.");
            }
            catch (Exception ex)
            {
                 // Panic Logging
                 try 
                 {
                     File.AppendAllText(@"d:\Bannerlord_Mods\logs\panic.log", $"[FieldSquire] CRITICAL: Init Failed: {ex}\n"); 
                 } catch { }

                 if (Logger != null)
                 {
                     Logger.Error(ex, "FieldSquire: FAILED to apply Harmony patches or Initialize.");
                 }
            }
        }

        public static void UpdateLogLevel(bool distinctDebugMode)
        {
            // Fallback: No-op safely if we can't switch levels dynamically to avoid crashes
        }

        protected override void OnGameStart(Game game, IGameStarter gameStarter)
        {
            base.OnGameStart(game, gameStarter);

            if (game.GameType is Campaign)
            {
                CampaignGameStarter campaignStarter = (CampaignGameStarter)gameStarter;

                // Resolve Behaviors from Container
                var serviceProvider = this.GetServiceProvider();
                
                if (serviceProvider != null)
                {
                    // Update Log Level based on persisted settings
                    var settings = serviceProvider.GetService<GlobalSettings>();
                    if (settings != null)
                    {
                        UpdateLogLevel(settings.DebugMode);
                    }

                    campaignStarter.AddBehavior(serviceProvider.GetRequiredService<SquireSpawnBehavior>());
                    campaignStarter.AddBehavior(serviceProvider.GetRequiredService<SquireDialogBehavior>());
                    campaignStarter.AddBehavior(serviceProvider.GetRequiredService<SquireLogisticsBehavior>());
                }
                else
                {
                    // Fallback for No-ButterLib environments (Safe Failover using Manual Logger)
                    // Create a factory wrapping our manual Serilog logger
                    var factory = new LoggerFactory();
                    factory.AddSerilog(Logger);

                    campaignStarter.AddBehavior(new SquireSpawnBehavior(factory.CreateLogger<SquireSpawnBehavior>(), GlobalSettings.Instance));
                    campaignStarter.AddBehavior(new SquireDialogBehavior(factory.CreateLogger<SquireDialogBehavior>(), GlobalSettings.Instance));
                    campaignStarter.AddBehavior(new SquireLogisticsBehavior(factory.CreateLogger<SquireLogisticsBehavior>(), GlobalSettings.Instance));
                }
            }
        }
    }
}
