using System;
using System.IO;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;
using HarmonyLib;
using Serilog;
using MCM.Abstractions.Base.Global;

namespace NewClans
{
    public class SubModule : MBSubModuleBase
    {
        private ILogger _logger;

        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();
            try { File.WriteAllText(@"d:\Bannerlord_Mods\logs\simple_debug.txt", "NewClans OnSubModuleLoad entered.\n"); } catch { }

            try
            {
                _logger = new LoggerConfiguration()
                    .WriteTo.File(@"d:\Bannerlord_Mods\logs\NewClans.log", rollingInterval: RollingInterval.Infinite)
                    .CreateLogger();

                new Harmony("com.newclans").PatchAll();
                _logger.Information("NewClans Harmony patches applied.");
            }
            catch (Exception ex)
            {
                try 
                {
                    File.AppendAllText(@"d:\Bannerlord_Mods\logs\panic.log", $"[NewClans] CRITICAL: Init Failed: {ex}\n"); 
                } catch { }
            }
        }

        protected override void OnGameStart(Game game, IGameStarter gameStarterObject)
        {
            base.OnGameStart(game, gameStarterObject);

            if (game.GameType is Campaign)
            {
                CampaignGameStarter campaignStarter = (CampaignGameStarter)gameStarterObject;
                
                // Retrieve settings from MCM
                var settings = GlobalSettings.Instance;
                if (settings == null)
                {
                    _logger.Warning("MCM GlobalSettings.Instance is null! Using default settings.");
                    settings = new GlobalSettings();
                }

                campaignStarter.AddBehavior(new NewClansBehavior(_logger, settings));
            }
        }
    }
}
