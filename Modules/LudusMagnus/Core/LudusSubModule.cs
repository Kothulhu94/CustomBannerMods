using System;
using System.IO;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Library;
using Bannerlord.UIExtenderEx;
using Bannerlord.ButterLib.Common.Extensions;
using HarmonyLib;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Events;

namespace LudusMagnus.Core
{
    public class LudusSubModule : MBSubModuleBase
    {
        private const string ModuleId = "LudusMagnus";
        private const string HarmonyId = "com.ludusmagnus.patch";
        private UIExtender _uiExtender;
        private Harmony _harmony;
        private static Microsoft.Extensions.Logging.ILogger _logger;
        public static Microsoft.Extensions.Logging.ILogger InstanceLogger => _logger;

        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();

            // Configure Serilog
            var serilogLogger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.File(Path.Combine(@"d:\Bannerlord_Mods\logs", "LudusMagnus.log"),
                    rollingInterval: RollingInterval.Infinite,
                    outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}")
                .CreateLogger();

            _logger = new Serilog.Extensions.Logging.SerilogLoggerFactory(serilogLogger).CreateLogger<LudusSubModule>();

            // Register Services
            var services = this.GetServices();
            if (services != null)
            {
                // services.AddSingleton<Microsoft.Extensions.Logging.ILogger>(_logger); // REMOVED: Causes cross-module contamination
                // Register settings if needed, though they are usually singletons accessed via Instance
                services.AddScoped<LudusSettings>(sp => LudusSettings.Instance);
            }

            // Also set global Serilog logger for fallback
            // Log.Logger = serilogLogger; // REMOVED: Global Logger Contamination

            try
            {
                _logger.LogInformation("LudusMagnus SubModule Loading...");
                // Initialize Manager
                LudusManager.Initialize();
                _logger.LogInformation("LudusMagnus Manager Initialized.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "CRITICAL ERROR during LudusMagnus OnSubModuleLoad");
            }
        }

        protected override void OnSubModuleUnloaded()
        {
            base.OnSubModuleUnloaded();
            // Log.CloseAndFlush();
        }

        protected override void OnBeforeInitialModuleScreenSetAsRoot()
        {
            base.OnBeforeInitialModuleScreenSetAsRoot();

            try
            {
                // Init Harmony
                _harmony = new Harmony(HarmonyId);
                _harmony.PatchAll();

                // Init UIExtender - REMOVED: No UI components present, causes Assert failure.
                // _uiExtender = UIExtender.Create(ModuleId);
                // _uiExtender.Register(typeof(LudusSubModule).Assembly);
                // _uiExtender.Enable();

                InformationManager.DisplayMessage(new InformationMessage("LudusMagnus Loaded", Colors.Green));
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, "Error initializing LudusMagnus SubModule");
            }
        }

        protected override void OnGameStart(Game game, IGameStarter gameStarterObject)
        {
            base.OnGameStart(game, gameStarterObject);

            if (game.GameType is Campaign)
            {
                CampaignGameStarter campaignStarter = (CampaignGameStarter)gameStarterObject;

                campaignStarter.AddBehavior(new SettlementLogic.LudusCreationBehavior());
                campaignStarter.AddBehavior(new SettlementLogic.LudusStateBehavior());
                
                // Agent D Economy Behaviors
                campaignStarter.AddBehavior(new Economy.LudusProcuratorBehavior());
                campaignStarter.AddBehavior(new AI.AiProcuratorBehavior());
                campaignStarter.AddBehavior(new Economy.LudusEconomyBehavior());
                campaignStarter.AddBehavior(new Economy.LudusDraftDayBehavior());
                campaignStarter.AddBehavior(new Economy.LudusSmithyBehavior());

                // Agent E AI Behaviors
                campaignStarter.AddBehavior(new AI.AiVisitLudusBehavior());
                campaignStarter.AddBehavior(new AI.LudusRivalryBehavior());
                campaignStarter.AddBehavior(new AI.LudusSentinelBehavior());
                campaignStarter.AddBehavior(new AI.LudusSiegeReliefBehavior());
                campaignStarter.AddBehavior(new AI.LudusAiManagementBehavior());
                // campaignStarter.AddBehavior(new AI.LudusWarBehavior()); // Reserved for future update

                // Agent C Staff & Roles
                campaignStarter.AddBehavior(new Staff.LudusStaffBehavior());
                campaignStarter.AddBehavior(new Settlements.LudusTempleBehavior());

                // Agent F Politics & Council
                campaignStarter.AddBehavior(new Political.GrandCouncilCampaignBehavior());
                campaignStarter.AddBehavior(new Political.LudusQuestBehavior());

                Events.LudusGameMenus.AddGameMenus(campaignStarter);
                
                // Register Models
                // Models are usually added via `gameStarter.AddModel()`.
                // However, Bannerlord usually picks them up via `Default...Model` overrides or XML?
                // If using CampaignGameStarter.AddModel:
                gameStarterObject.AddModel(new Political.CouncilVotingModel());
            }
        }
    }
}
