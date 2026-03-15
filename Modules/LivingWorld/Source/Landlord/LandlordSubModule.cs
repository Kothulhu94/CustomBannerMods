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
        private static readonly string LogPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Mount and Blade II Bannerlord", "Configs", "ModLogs", "LivingWorld", "Landlord.log");
        private Serilog.ILogger _serilogLogger;

        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();

            try
            {
                // Initialize Central Core
                LivingWorld.LivingWorldCore.Initialize();
                _serilogLogger = LivingWorld.LivingWorldCore.Logger;

                if (GlobalSettings.Instance != null && !GlobalSettings.Instance.ModuleEnabled)
                {
                    _serilogLogger?.Information("Landlord: DISABLED via MCM.");
                    return;
                }

                // Register Services
                var services = this.GetServices();
                if (services != null)
                {
                    services.AddSingleton<EconomyBehavior>();
                    services.AddSingleton<ViolenceBehavior>();
                    services.AddSingleton<VillageWealthBehavior>();
                    services.AddTransient<LandlordFinanceModel>();
                    services.AddTransient<WealthMilitiaModel>();
                    LivingWorld.LivingWorldCore.Logger?.Information("Landlord: Services registered.");
                }
            }
            catch (Exception ex)
            {
                LivingWorld.LivingWorldCore.Logger?.Error(ex, "Landlord: Error during startup.");
            }
        }

        protected override void OnGameStart(Game game, IGameStarter gameStarterObject)
        {
            base.OnGameStart(game, gameStarterObject);

            if (game.GameType is Campaign)
            {
                CampaignGameStarter campaignStarter = (CampaignGameStarter)gameStarterObject;
                var serviceProvider = this.GetServiceProvider();

                if (GlobalSettings.Instance != null && !GlobalSettings.Instance.ModuleEnabled) return;

                try
                {
                    // Add Behaviors
                    campaignStarter.AddBehavior(serviceProvider.GetRequiredService<EconomyBehavior>());
                    campaignStarter.AddBehavior(serviceProvider.GetRequiredService<ViolenceBehavior>());
                    campaignStarter.AddBehavior(serviceProvider.GetRequiredService<VillageWealthBehavior>());

                    // Add Models
                    campaignStarter.AddModel(serviceProvider.GetRequiredService<LandlordFinanceModel>());
                    campaignStarter.AddModel(serviceProvider.GetRequiredService<WealthMilitiaModel>());
                    
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
