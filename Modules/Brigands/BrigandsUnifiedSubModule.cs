using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;
using TaleWorlds.CampaignSystem;
using System;
using System.IO;
using Brigands.Warlords;
using Brigands.Recruitment;
using Brigands.Training;
using Brigands.Terror;
using Brigands.Merge;
using HarmonyLib;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Bannerlord.ButterLib.Common.Extensions;
using ILogger = Microsoft.Extensions.Logging.ILogger;

namespace Brigands
{
    public class BrigandsUnifiedSubModule : MBSubModuleBase
    {
        private IServiceProvider _serviceProvider;
        private static ILogger _log;

        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();

            // 1. Setup Serilog
            // We use a hardcoded path as requested by the user environment: d:/Bannerlord_Mods/logs/Brigands.log
            // 1. Setup Serilog
            string logPath = @"d:\Bannerlord_Mods\logs\Brigands.log";
            
            try 
            {
                var serilogLogger = new LoggerConfiguration()
                    .WriteTo.File(logPath, rollingInterval: RollingInterval.Infinite, outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
                    .CreateLogger();

                // 2. Setup Dependency Injection
                var services = new ServiceCollection();
                services.AddLogging(loggingBuilder =>
                {
                    loggingBuilder.AddSerilog(serilogLogger);
                });

                // Register Settings
                services.AddSingleton<GlobalSettings>(sp => GlobalSettings.Instance ?? new GlobalSettings());

                // Register Behaviors
                services.AddTransient<SyndicateFactionBehavior>();
                services.AddTransient<WarlordSpawnBehavior>();
                services.AddTransient<RecruitWarlordBehavior>();
                services.AddTransient<PressGangBehavior>();
                services.AddTransient<PartyAlignmentFixerBehavior>();
                services.AddTransient<BanditTrainingBehavior>();
                services.AddTransient<BanditTerrorBehavior>();
                services.AddTransient<BanditCohesionBehavior>();
                services.AddTransient<SanityCheckBehavior>();

                _serviceProvider = services.BuildServiceProvider();
                
                // Store static log for fallback
                var factory = _serviceProvider.GetRequiredService<ILoggerFactory>();
                _log = factory.CreateLogger<BrigandsUnifiedSubModule>();

                _log.LogInformation("Brigands Unified SubModule Loaded. Logging initialized to " + logPath);

                // Harmony
                new Harmony("com.brigands.unified").PatchAll();
                _log.LogInformation("Brigands Harmony patches applied.");
            }
            catch (Exception ex)
            {
                try 
                {
                    File.AppendAllText(@"d:\Bannerlord_Mods\logs\panic.log", $"[Brigands] CRITICAL: Init Failed: {ex}\n"); 
                } catch { }
            }
        }

        protected override void OnGameStart(Game game, IGameStarter gameStarterObject)
        {
            base.OnGameStart(game, gameStarterObject);
            if (game.GameType is Campaign)
            {
                _log.LogInformation("Brigands Unified: Game Start");
                CampaignGameStarter campaignStarter = (CampaignGameStarter)gameStarterObject;

                try
                {
                    // Resolve behaviors from the DI container (invoking their constructors with ILogger injected)
                    // Warlords Behaviors
                    AddBehavior<SyndicateFactionBehavior>(campaignStarter);
                    AddBehavior<WarlordSpawnBehavior>(campaignStarter);
                    AddBehavior<RecruitWarlordBehavior>(campaignStarter);

                    // Recruitment Behaviors
                    AddBehavior<PressGangBehavior>(campaignStarter);
                    AddBehavior<PartyAlignmentFixerBehavior>(campaignStarter);

                    // Training Behaviors
                    AddBehavior<BanditTrainingBehavior>(campaignStarter);

                    // Terror Behaviors
                    AddBehavior<BanditTerrorBehavior>(campaignStarter);

                    // Merge Behaviors
                    AddBehavior<BanditCohesionBehavior>(campaignStarter);
                    AddBehavior<SanityCheckBehavior>(campaignStarter);
                }
                catch (Exception ex)
                {
                    _log.LogError(ex, "Failed to initialize behaviors via DI.");
                }
            }
        }

        private void AddBehavior<T>(CampaignGameStarter starter) where T : CampaignBehaviorBase
        {
            try
            {
                var behavior = _serviceProvider.GetRequiredService<T>();
                starter.AddBehavior(behavior);
                _log.LogInformation($"Registered behavior: {typeof(T).Name}");
            }
            catch (Exception ex)
            {
                _log.LogError(ex, $"Failed to resolve or register behavior: {typeof(T).Name}");
            }
        }
    }
}

