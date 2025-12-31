using System;
using System.IO;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Extensions.Logging;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

namespace CoastalLife
{
    public class CoastalLifeSubModule : MBSubModuleBase
    {
        private IServiceProvider _serviceProvider;
        private Microsoft.Extensions.Logging.ILogger _logger;

        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();

            // Configure Serilog
            // Configure Serilog
            string logPath = @"d:\Bannerlord_Mods\logs\CoastalLife.log";
            
            try
            {
                var localLogger = new LoggerConfiguration()
                    .WriteTo.File(logPath, rollingInterval: RollingInterval.Infinite, outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}")
                    .CreateLogger();

                var services = new ServiceCollection();
                services.AddLogging(loggingBuilder => loggingBuilder.AddSerilog(localLogger, dispose: true));
                
                // Register Settings
                services.AddSingleton(GlobalSettings.Instance ?? new GlobalSettings());

                // Register Behaviors
                services.AddSingleton<CoastalPatrolBehavior>();
                services.AddSingleton<CoastalJobBehavior>();
                services.AddSingleton<PortEconomyBehavior>();
                services.AddSingleton<PressGangBehavior>();
                services.AddSingleton<ShipDumperBehavior>();

                _serviceProvider = services.BuildServiceProvider();
                _logger = _serviceProvider.GetRequiredService<ILogger<CoastalLifeSubModule>>();

                _logger.LogInformation($"CoastalLife SubModule Loaded. Log Path: {logPath}");

                // Apply Harmony Patches
                new HarmonyLib.Harmony("com.coastallife").PatchAll();
                _logger.LogInformation("CoastalLife Harmony patches applied.");
            }
            catch (Exception ex)
            {
                try 
                {
                    File.AppendAllText(@"d:\Bannerlord_Mods\logs\panic.log", $"[CoastalLife] CRITICAL: Init Failed: {ex}\n"); 
                } catch { }
            }
        }

        protected override void OnGameStart(Game game, IGameStarter gameStarterObject)
        {
            base.OnGameStart(game, gameStarterObject);

            if (game.GameType is Campaign)
            {
                _logger.LogInformation("CoastalLife OnGameStart: Validating dependencies...");
                try
                {
                    CampaignGameStarter campaignStarter = (CampaignGameStarter)gameStarterObject;

                    // Check for NavalDLC
                    bool navalDlcPresent = AppDomain.CurrentDomain.GetAssemblies().Any(a => a.GetName().Name == "NavalDLC");

                    if (navalDlcPresent)
                    {
                        campaignStarter.AddBehavior(_serviceProvider.GetRequiredService<CoastalJobBehavior>());
                        campaignStarter.AddBehavior(_serviceProvider.GetRequiredService<PortEconomyBehavior>());
                        campaignStarter.AddBehavior(_serviceProvider.GetRequiredService<PressGangBehavior>());
                        campaignStarter.AddBehavior(_serviceProvider.GetRequiredService<CoastalPatrolBehavior>());
                        campaignStarter.AddBehavior(_serviceProvider.GetRequiredService<ShipDumperBehavior>());
                        
                        _logger.LogInformation("CoastalLife behaviors added.");
                    }
                    else
                    {
                        _logger.LogError("NavalDLC not found! CoastalLife behaviors skipped to prevent crash.");
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogCritical(ex, "CRASH in CoastalLife OnGameStart");
                }
            }
        }

        private static string GetLogFilePath(string filename)
        {
            try
            {
                 // Try to resolve workspace logs relative to assembly
                 string assemblyLocation = System.Reflection.Assembly.GetExecutingAssembly().Location;
                 string binDir = Path.GetDirectoryName(assemblyLocation);
                 DirectoryInfo dir = new DirectoryInfo(binDir);
                 
                 // Up to Modules
                 while (dir != null && dir.Name != "Modules")
                 {
                     dir = dir.Parent;
                 }
                 
                 // Up to Workspace Root
                 if (dir != null && dir.Parent != null)
                 {
                     string logsDir = Path.Combine(dir.Parent.FullName, "logs");
                     if (Directory.Exists(logsDir)) return Path.Combine(logsDir, filename);
                 }
            }
            catch {}

            // Fallback for user's specific environment
            if (Directory.Exists(@"d:\Bannerlord_Mods\logs")) return @"d:\Bannerlord_Mods\logs\" + filename;
            return filename;
        }
    }
}
