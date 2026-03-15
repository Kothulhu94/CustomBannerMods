using System;
using System.IO;
using Serilog;
using Serilog.Events;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;
using Bannerlord.ButterLib.Common.Extensions;
using Bannerlord.ButterLib.Extensions;
using Microsoft.Extensions.DependencyInjection;
using MCM.Abstractions.Base.Global;
using MCM.Abstractions.FluentBuilder;
using MCM.Common;
using HarmonyLib;
using TaleWorlds.CampaignSystem.Encounters;

namespace HonestWork
{
    public class HonestWorkSubModule : MBSubModuleBase
    {
        private ILogger _logger;

        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();
            try
            {
                // Initialize the shared Core
                LivingWorld.LivingWorldCore.Initialize();
                _logger = LivingWorld.LivingWorldCore.Logger;
                
                _logger?.Information("HonestWork: Loaded via LivingWorldCore.");
            }
            catch (Exception)
            {
                 // Silent fail or system log
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
                    // DEBUG: Print Active Models
                    if (Campaign.Current != null && Campaign.Current.Models != null)
                    {
                         var loyaltyModel = Campaign.Current.Models.SettlementLoyaltyModel;
                         var securityModel = Campaign.Current.Models.SettlementSecurityModel;
                         var prosperityModel = Campaign.Current.Models.SettlementProsperityModel;
                         
                         _logger.Information($"Active Loyalty Model: {loyaltyModel?.GetType().FullName ?? "NULL"}");
                         _logger.Information($"Active Security Model: {securityModel?.GetType().FullName ?? "NULL"}");
                         _logger.Information($"Active Prosperity Model: {prosperityModel?.GetType().FullName ?? "NULL"}");
                    }

                    // Manual Dependency Injection (Composition Root)
                    var settings = GlobalSettings.Instance;

                    if (settings == null)
                    {
                        _logger.Error("GlobalSettings.Instance is null! Using defaults.");
                        settings = new GlobalSettings(); // Fallback
                    }

                    if (!settings.ModuleEnabled)
                    {
                         _logger.Information("HonestWork disabled via settings.");
                         return;
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

        public override void OnMissionBehaviorInitialize(Mission mission)
        {
            base.OnMissionBehaviorInitialize(mission);
            
            // DIAGNOSTIC LOGGING
            var logger = LivingWorld.LivingWorldCore.Logger;
            
            Settlement current = Settlement.CurrentSettlement;
            // Fallback removed to fix build error (PlayerEncounter property access issues)

            string settlementName = current?.Name?.ToString() ?? "NULL";
            logger?.Information($"HonestWork: OnMissionBehaviorInitialize. Settlement: {settlementName}. IsVillage: {current?.IsVillage ?? false}");

            // Add Village Labor Interaction Behavior if it's a village mission
            // We load this always for the V-Key Beacons and stability fixes.
            if (current != null && current.IsVillage)
            {
                mission.AddMissionBehavior(new VillageLaborMissionBehavior());
                logger?.Information("HonestWork: VillageLaborMissionBehavior ADDED to mission.");
            }
            else
            {
                logger?.Information("HonestWork: VillageLaborMissionBehavior NOT added (Condition failed).");
            }
        }
    }
}
