using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Localization;
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using HarmonyLib;
using TaleWorlds.Library;
using TaleWorlds.ObjectSystem;
using TaleWorlds.ModuleManager;

namespace Ascension
{
    public class AscensionSubModule : MBSubModuleBase
    {
        private static void Log(string message)
        {
            try
            {
                File.AppendAllText("d:/Bannerlord_Mods/logs/Ascension_Runtime.log", $"[{DateTime.Now}] {message}\n");
            }
            catch { }
        }

        protected override void OnSubModuleLoad()
        {
            Log("OnSubModuleLoad: Started");
            base.OnSubModuleLoad();
            
            try 
            {
                Harmony harmony = new Harmony("com.ascension.mod");
                harmony.PatchAll();
                Log("OnSubModuleLoad: Harmony Patched");
            }
            catch (Exception ex)
            {
                Log($"OnSubModuleLoad ERROR: {ex}");
            }
        }



        protected override void OnBeforeInitialModuleScreenSetAsRoot()
        {
            Log("OnBeforeInitialModuleScreenSetAsRoot: Started");
            base.OnBeforeInitialModuleScreenSetAsRoot();
            InformationManager.DisplayMessage(new InformationMessage("Ascension Active"));
        }

        protected override void OnGameStart(Game game, IGameStarter gameStarterObject)
        {
            Log($"OnGameStart: GameType={game.GameType.GetType().Name}");
            base.OnGameStart(game, gameStarterObject);

            if (game.GameType is Campaign)
            {
                CampaignGameStarter starter = (CampaignGameStarter)gameStarterObject;
                starter.AddBehavior(new AscensionBehavior());
                Log("Added AscensionBehavior to Campaign.");
            }
        }
    }
}
