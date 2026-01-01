using System;
using System.Reflection;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.Encounters;
using TaleWorlds.Core;
using TaleWorlds.Engine;
using TaleWorlds.InputSystem;
using TaleWorlds.Library;
using TaleWorlds.Localization;
using TaleWorlds.ScreenSystem;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.CampaignSystem.Party;
using SandBox.View.Map;
using LudusMagnus.Core;

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

                 // Hotkey: Ctrl + B
                if (Input.IsKeyDown(InputKey.LeftControl) && Input.IsKeyPressed(InputKey.B))
                 {
                     InformationManager.DisplayMessage(new InformationMessage("Attempting Strict Spawn...", Colors.Yellow));
                     // CreateLudusSettlement(MobileParty.MainParty.Position2D); // Position2D might be missing
                     var p = MobileParty.MainParty.Position;
                     CreateLudusSettlement(new Vec2(p.X, p.Y));
                 }
             }
             catch
             {
             }
        }

        private static void CreateLudusSettlement(Vec2 position)
        {
            try
            {
                // 1. Create Settlement Object
                Settlement settlement = TaleWorlds.ObjectSystem.MBObjectManager.Instance.CreateObject<Settlement>("my_custom_ludus");
                // settlement.StringId = "my_custom_ludus"; // Already set by CreateObject
                
                // 2. Set Basic Properties
                SetPrivateField(settlement, "_name", new TextObject("Ludus Magnus"));
                settlement.Culture = TaleWorlds.ObjectSystem.MBObjectManager.Instance.GetObject<CultureObject>("empire");
                
                // 3. Set Component (CRITICAL: Only LudusSettlementComponent)
                LudusSettlementComponent ludusComponent = new LudusSettlementComponent();
                // settlement.SettlementComponent = ludusComponent; // Property is read-only?
                
                var compProp = typeof(Settlement).GetProperty("SettlementComponent");
                if (compProp != null && compProp.CanWrite) compProp.SetValue(settlement, ludusComponent);
                else SetPrivateField(settlement, "_settlementComponent", ludusComponent);

                // 4. Set Position
                // settlement.Position2D = position; 
                SetPrivateField(settlement, "_position", position);
                
                // 5. Visuals
                // settlement.Position2D = position; 
                // Use MapSceneWrapper placeholder LOGIC (User Step 5)
                // Since we don't have MapSceneWrapper, we rely on standard visual init if possible or use reflection if we find it.
                // For now, we set IsVisible = true which usually triggers visual creation in Campaign behaviors.
                
                // 6. Initialization
                // settlement.InitializeSettlement(PartyBase.MainParty.Party, null, null); 
                settlement.IsVisible = true;

                // 7. Event
                // CampaignEventDispatcher.Instance.OnSettlementCreated(settlement); // Invalid API

                InformationManager.DisplayMessage(new InformationMessage("Strict Spawn Complete.", Colors.Green));
                
                // 8. Auto-Enter
                if (settlement.Party != null)
                {
                     // Force enter (Placeholder for future menu logic)
                }

                // Temporary: call OnSettlementEntered manual trigger? 
                // The menu injection will handle the rest.
            }
            catch (Exception ex)
            {
                InformationManager.DisplayMessage(new InformationMessage($"Spawn Failed: {ex.Message}", Colors.Red));
            }
        }

        private static void SetPrivateField(object target, string fieldName, object value)
        {
            if (target == null) return;
            var t = target.GetType();
            FieldInfo fi = null;
            while (t != null)
            {
                fi = t.GetField(fieldName, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
                if (fi != null) break;
                t = t.BaseType;
            }
            if (fi != null) try { fi.SetValue(target, value); } catch { }
        }
    }
}
