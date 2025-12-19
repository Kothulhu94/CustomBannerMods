using System;
using System.IO;
using Serilog;
using Serilog.Events;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;
using TaleWorlds.CampaignSystem;
using Bannerlord.ButterLib.Common.Extensions;
using Bannerlord.ButterLib.Extensions;
using Microsoft.Extensions.DependencyInjection;
using MCM.Abstractions.Base.Global;
using MCM.Abstractions.FluentBuilder;
using MCM.Common;

namespace HonestWork
{
    public class HonestWorkSubModule : MBSubModuleBase
    {
        private ILogger _logger;

        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();

            // Initialize Logging
            var logPath = @"d:\Bannerlord_Mods\logs\HonestWork.log";
            
            try
            {
                _logger = new LoggerConfiguration()
                    .WriteTo.File(logPath, rollingInterval: RollingInterval.Infinite)
                    .CreateLogger();

                _logger.Information("HonestWork Loaded. Logging Initialized.");

                // Register Logger Provider with ButterLib (optional but good for shared logging if needed)
                this.AddSerilogLoggerProvider($"{logPath}", new[] { "HonestWork" });
            }
            catch (Exception ex)
            {
                // Fallback: Emergency Log
                try 
                {
                    File.AppendAllText(@"d:\Bannerlord_Mods\logs\panic.log", $"[HonestWork] CRITICAL: Serilog Init Failed: {ex}\n"); 
                } catch { } // Give up if we can't even write text
            }
        }

        protected override void OnSubModuleUnloaded()
        {
            base.OnSubModuleUnloaded();
            _logger.Information("HonestWork Unloaded.");
            Log.CloseAndFlush();
        }

        protected override void OnGameStart(Game game, IGameStarter gameStarterObject)
        {
            base.OnGameStart(game, gameStarterObject);

            if (game.GameType is Campaign)
            {
                var campaignStarter = (CampaignGameStarter)gameStarterObject;

                try
                {
                    // Manual Dependency Injection (Composition Root)
                    var settings = GlobalSettings.Instance;

                    if (settings == null)
                    {
                        _logger.Error("GlobalSettings.Instance is null! Using defaults.");
                        settings = new GlobalSettings(); // Fallback
                    }

                    // Resolve and Add Behaviors
                    var townJobBehavior = new TownJobBehavior(_logger, settings);
                    campaignStarter.AddBehavior(townJobBehavior);
                    _logger.Information("TownJobBehavior Added.");

                    var villageLaborBehavior = new VillageLaborBehavior(_logger, settings);
                    campaignStarter.AddBehavior(villageLaborBehavior);
                    _logger.Information("VillageLaborBehavior Added.");

                    try 
                    {
                        var castleJobBehavior = new CastleJobBehavior(_logger, settings);
                        campaignStarter.AddBehavior(castleJobBehavior);
                        _logger.Information("CastleJobBehavior Added.");
                    }
                    catch (Exception ex)
                    {
                         _logger.Error(ex, "FAILED to add CastleJobBehavior. Continuing without it.");
                    }
                }
                catch (Exception ex)
                {
                    _logger.Error(ex, "Failed to add behaviors in OnGameStart.");
                }
            }
        }
    }
}
