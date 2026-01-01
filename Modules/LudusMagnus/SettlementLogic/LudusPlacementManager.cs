using System;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.Core;
using TaleWorlds.Engine;
using TaleWorlds.InputSystem;
using TaleWorlds.Library;
using TaleWorlds.ModuleManager;

namespace LudusMagnus.SettlementLogic
{
    public static class LudusPlacementManager
    {
        public static void OnApplicationTick(float dt)
        {
            CheckStartInput();
        }

        private static void CheckStartInput()
        {
             try
             {
                 if (Campaign.Current == null || MobileParty.MainParty == null) return;

                 if (Input.IsKeyDown(InputKey.LeftControl) && Input.IsKeyPressed(InputKey.B))
                 {
                     InformationManager.DisplayMessage(new InformationMessage("Attempting to build Ludus...", Colors.Yellow));
                     // Corrected property access
                     var p = MobileParty.MainParty.Position.ToVec2();
                     LudusSpawner.SpawnLudus(Hero.MainHero, p);
                 }
             }
             catch (Exception ex)
             {
                 InformationManager.DisplayMessage(new InformationMessage($"Input Error: {ex.Message}", Colors.Red));
             }
        }
    }
}
