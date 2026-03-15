using System;
using System.IO;
using HarmonyLib;
using Serilog;
using TaleWorlds.Library;
using Microsoft.Extensions.DependencyInjection;

namespace LivingWorld
{
    public static class LivingWorldCore
    {
        private static bool _isInitialized = false;
        private static readonly object _lock = new object();
        private static ILogger _logger;

        public static ILogger Logger => _logger;

        public static void Initialize()
        {
            if (_isInitialized) return;

            lock (_lock)
            {
                if (_isInitialized) return;

                // 1. Setup Unified Logging
                string logDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Mount and Blade II Bannerlord", "Configs", "ModLogs", "LivingWorld");
                if (!Directory.Exists(logDir)) Directory.CreateDirectory(logDir);
                
                string logPath = Path.Combine(logDir, "LivingWorld.log");

                _logger = new LoggerConfiguration()
                    .WriteTo.File(logPath, rollingInterval: RollingInterval.Infinite, shared: true,
                        outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
                    .MinimumLevel.Debug()
                    .CreateLogger();

                _logger.Information("================================================================================");
                _logger.Information("LIVING WORLD CORE: Initializing Assembly-Wide Services");
                _logger.Information("================================================================================");

                // 2. Assembly-Wide Harmony Patching
                try
                {
                    var harmony = new Harmony("com.livingworld.core");
                    
                    harmony.PatchAll(typeof(LivingWorldCore).Assembly);
                    _logger.Information("LIVING WORLD CORE: Assembly-Wide Harmony PatchAll completed.");
                    
                    // Apply Manual Patches (protected by _patchesApplied flags)
                    FieldSquire.Patches.SquireUIPatches.Apply(harmony);
                    FieldSquire.Patches.DebugElectionPatch.Apply(harmony);
                    FieldSquire.Patches.PartySizeLimitPatch.Apply(harmony);
                    LivingLegend.LivingLegendPatches.Apply(harmony);
                    LivingLegend.MilitiaPatrolPatches.Apply(harmony);
                    
                }
                catch (Exception ex)
                {
                    _logger.Error(ex, "LIVING WORLD CORE: Critical Error during Harmony Patching.");
                }

                _isInitialized = true;
            }
        }

        public static void RegisterServices(IServiceCollection services)
        {
            if (services == null) return;
            
            // Register Serilog ILogger globally
            if (_logger != null)
            {
                services.AddSingleton<Serilog.ILogger>(_logger);
                services.AddSingleton<Microsoft.Extensions.Logging.ILogger>(sp => 
                {
                    var factory = new Microsoft.Extensions.Logging.LoggerFactory();
                    factory.AddSerilog(_logger);
                    return factory.CreateLogger("LivingWorld");
                });
            }
        }
    }
}
