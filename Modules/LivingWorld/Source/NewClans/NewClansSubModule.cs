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

            try
            {
                // Initialize Central Core
                LivingWorld.LivingWorldCore.Initialize();
                _logger = LivingWorld.LivingWorldCore.Logger;

                if (GlobalSettings.Instance != null && !GlobalSettings.Instance.ModuleEnabled)
                {
                    _logger?.Information("NewClans: disabled via MCM.");
                    return;
                }
            }
            catch (Exception)
            {
                 // Init Failed
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

                if (!settings.ModuleEnabled) return;

                campaignStarter.AddBehavior(new NewClansBehavior(_logger, settings));
            }
        }
    }
}
