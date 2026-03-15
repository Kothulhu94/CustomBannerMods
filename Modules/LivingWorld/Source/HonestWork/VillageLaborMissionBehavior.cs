using System;
using System.Collections.Generic;
using System.Linq;
using TaleWorlds.Core;
using TaleWorlds.Engine;
using TaleWorlds.InputSystem;
using TaleWorlds.Library;
using TaleWorlds.MountAndBlade;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;
using Bannerlord.ButterLib.Extensions;
using Bannerlord.ButterLib.Common.Extensions;

using TaleWorlds.CampaignSystem.Actions;

namespace HonestWork
{
    public class VillageLaborMissionBehavior : MissionBehavior
    {
        public override MissionBehaviorType BehaviorType => MissionBehaviorType.Other;

        private float _entryTimer = 0f;

        private bool _beaconsActive = false;
        private readonly List<GameEntity> _waterAnchors = new List<GameEntity>();
        private readonly List<GameEntity> _maintenanceAnchors = new List<GameEntity>();
        private readonly List<GameEntity> _agricultureAnchors = new List<GameEntity>();
        private readonly List<GameEntity> _logisticsAnchors = new List<GameEntity>();
        private bool _anchorsInitialized = false;
        private readonly Serilog.ILogger _logger = LivingWorld.LivingWorldCore.Logger;

        public override void OnMissionTick(float dt)
        {
            base.OnMissionTick(dt);

            if (Agent.Main == null || !Agent.Main.IsActive()) return;

            // Only run in villages
            if (Settlement.CurrentSettlement == null || !Settlement.CurrentSettlement.IsVillage)
            {
                return;
            }

            // [FIX] Removed aggressive SetMissionMode. 
            // It was interfering with Native Alt UI (Notable icons).
            _entryTimer += dt;

            // Beacon Logic (Held V)
            bool isVDown = Input.IsKeyDown(InputKey.V);
            
            if (isVDown)
            {
                if (!_anchorsInitialized) 
                {
                    _logger?.Information("HonestWork Beacons: V-Key pressed. Initializing anchors...");
                    InitializeAnchors();
                }
                UpdateBeacons(true);
                _beaconsActive = true;
            }
            else if (_beaconsActive)
            {
                _logger?.Information("HonestWork Beacons: V-Key released. Cleaning up beacons.");
                UpdateBeacons(false);
                _beaconsActive = false;
            }
        }

        private void InitializeAnchors()
        {
            _waterAnchors.Clear();
            _maintenanceAnchors.Clear();
            _agricultureAnchors.Clear();
            _logisticsAnchors.Clear();

            // FALLBACK SEARCH: Iterate all entities if tags are unreliable
            List<GameEntity> allEntities = new List<GameEntity>();
            
            // Fix: GetAllEntitiesWithScriptComponent usually requires ref
            Mission.Scene.GetAllEntitiesWithScriptComponent<MissionObject>(ref allEntities);
            
            _logger?.Information($"HonestWork Beacons: Scanned {allEntities.Count} entities in scene.");

            foreach (var entity in allEntities)
            {
                string prefab = entity.GetPrefabName()?.ToLower() ?? "";
                string name = entity.Name?.ToLower() ?? "";
                
                bool isWorkstation = entity.HasTag("prop") || entity.HasTag("wait_place") || entity.HasTag("npc_common");
                
                // If not tagged, check naming conventions for common village props
                if (!isWorkstation)
                {
                    isWorkstation = prefab.Contains("well") || prefab.Contains("trough") || prefab.Contains("repair_set") || 
                                    prefab.Contains("farmer") || prefab.Contains("cart") || prefab.Contains("barrel");
                }

                if (!isWorkstation) continue;

                // 1. Water
                if (prefab.Contains("well") || prefab.Contains("trough") || name.Contains("well"))
                {
                    _waterAnchors.Add(entity);
                }
                // 2. Maintenance
                else if (prefab.Contains("repair_set") || prefab.Contains("bench") || name.Contains("repair_set"))
                {
                    _maintenanceAnchors.Add(entity);
                }
                // 3. Agriculture
                else if (prefab.Contains("farmer") || prefab.Contains("digging") || prefab.Contains("farm_set") || prefab.Contains("agriculture"))
                {
                    _agricultureAnchors.Add(entity);
                }
                // 4. Logistics
                else if (prefab.Contains("cart") || prefab.Contains("barrel") || prefab.Contains("sack") || name.Contains("logistics"))
                {
                    _logisticsAnchors.Add(entity);
                }
            }

            _logger?.Information($"HonestWork Beacons: Result - Water:{_waterAnchors.Count}, Maint:{_maintenanceAnchors.Count}, Agri:{_agricultureAnchors.Count}, Logi:{_logisticsAnchors.Count}");
            _anchorsInitialized = true;
        }

        private void UpdateBeacons(bool active)
        {
            // Standard Colors
            uint blue = new Color(0.1f, 0.4f, 1.0f).ToUnsignedInteger();      // Water
            uint orange = new Color(1.0f, 0.5f, 0.0f).ToUnsignedInteger();    // Maintenance
            uint green = new Color(0.2f, 0.8f, 0.2f).ToUnsignedInteger();     // Agriculture
            uint yellow = new Color(1.0f, 0.9f, 0.0f).ToUnsignedInteger();    // Logistics

            DrawCategoryBeacons(_waterAnchors, blue, active);
            DrawCategoryBeacons(_maintenanceAnchors, orange, active);
            DrawCategoryBeacons(_agricultureAnchors, green, active);
            DrawCategoryBeacons(_logisticsAnchors, yellow, active);
        }

        private void DrawCategoryBeacons(List<GameEntity> entities, uint color, bool active)
        {
            foreach (var entity in entities)
            {
                if (active)
                {
                    // Through-wall contour
                    entity.SetContourColor(color, true);
                    
                    // Vertical Pillar
                    Vec3 start = entity.GlobalPosition;
                    Vec3 end = start + new Vec3(0, 0, 150f); 
                    
                    // Always visible debug line
                    MBDebug.RenderDebugLine(start, end, color, true, 0.1f);
                    
                    // Crosshair at base (Fallback visual)
                    MBDebug.RenderDebugLine(start + new Vec3(0.5f, 0, 0), start - new Vec3(0.5f, 0, 0), color, true, 0.1f);
                    MBDebug.RenderDebugLine(start + new Vec3(0, 0.5f, 0), start - new Vec3(0, 0.5f, 0), color, true, 0.1f);
                }
                else
                {
                    entity.SetContourColor(null, false);
                }
            }
        }
    }
}
