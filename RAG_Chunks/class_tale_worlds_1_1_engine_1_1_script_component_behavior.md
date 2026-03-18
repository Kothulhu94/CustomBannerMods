--- SOURCE: class_tale_worlds_1_1_engine_1_1_script_component_behavior.html ---

TaleWorlds.Engine.ScriptComponentBehavior Class ReferenceabstractInherits DotNetObject.

Inherited by [SandBox.BoardGames.Objects.BoardGameDecal](class_sand_box_1_1_board_games_1_1_objects_1_1_board_game_decal.html), [SandBox.BoardGames.Objects.Tile](class_sand_box_1_1_board_games_1_1_objects_1_1_tile.html), [SandBox.CampaignMapSiegePrefabEntityCache](class_sand_box_1_1_campaign_map_siege_prefab_entity_cache.html), [SandBox.Missions.CameraJumpScript](class_sand_box_1_1_missions_1_1_camera_jump_script.html), [SandBox.Missions.ChangeLightIntensityScript](class_sand_box_1_1_missions_1_1_change_light_intensity_script.html), [SandBox.Missions.RotateObjectScript](class_sand_box_1_1_missions_1_1_rotate_object_script.html), [SandBox.Objects.Cinematics.CinematicBurningArrow](class_sand_box_1_1_objects_1_1_cinematics_1_1_cinematic_burning_arrow.html), [SandBox.Objects.Cinematics.HideoutBossFightBehavior](class_sand_box_1_1_objects_1_1_cinematics_1_1_hideout_boss_fight_behavior.html), [SandBox.Objects.Cinematics.SkeletonAnimatedCamera](class_sand_box_1_1_objects_1_1_cinematics_1_1_skeleton_animated_camera.html), [SandBox.View.Map.BlockadePositionScript](class_sand_box_1_1_view_1_1_map_1_1_blockade_position_script.html), [SandBox.View.Map.SettlementPositionScript](class_sand_box_1_1_view_1_1_map_1_1_settlement_position_script.html), [SandBox.View.Map.SnowAndRainTextureDefiner](class_sand_box_1_1_view_1_1_map_1_1_snow_and_rain_texture_definer.html), [SandBox.View.Missions.SandBox.SpawnPointDebugView](class_sand_box_1_1_view_1_1_missions_1_1_sand_box_1_1_spawn_point_debug_view.html), [TaleWorlds.MountAndBlade.AnimatedFlag](class_tale_worlds_1_1_mount_and_blade_1_1_animated_flag.html), [TaleWorlds.MountAndBlade.BoundaryWallView](class_tale_worlds_1_1_mount_and_blade_1_1_boundary_wall_view.html), [TaleWorlds.MountAndBlade.CameraDisplay](class_tale_worlds_1_1_mount_and_blade_1_1_camera_display.html), [TaleWorlds.MountAndBlade.ColorAssigner](class_tale_worlds_1_1_mount_and_blade_1_1_color_assigner.html), [TaleWorlds.MountAndBlade.DefencePoint](class_tale_worlds_1_1_mount_and_blade_1_1_defence_point.html), [TaleWorlds.MountAndBlade.DuelZoneLandmark](class_tale_worlds_1_1_mount_and_blade_1_1_duel_zone_landmark.html), [TaleWorlds.MountAndBlade.FleePosition](class_tale_worlds_1_1_mount_and_blade_1_1_flee_position.html), [TaleWorlds.MountAndBlade.LightCycle](class_tale_worlds_1_1_mount_and_blade_1_1_light_cycle.html), [TaleWorlds.MountAndBlade.Lightning](class_tale_worlds_1_1_mount_and_blade_1_1_lightning.html), [TaleWorlds.MountAndBlade.MapAtmosphereProbe](class_tale_worlds_1_1_mount_and_blade_1_1_map_atmosphere_probe.html), [TaleWorlds.MountAndBlade.Markable](class_tale_worlds_1_1_mount_and_blade_1_1_markable.html), [TaleWorlds.MountAndBlade.MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html), [TaleWorlds.MountAndBlade.Mover](class_tale_worlds_1_1_mount_and_blade_1_1_mover.html), [TaleWorlds.MountAndBlade.MultiplayerSceneValidator](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_scene_validator.html), [TaleWorlds.MountAndBlade.Objects.AnimalSpawnSettings](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_animal_spawn_settings.html), [TaleWorlds.MountAndBlade.Objects.GenericMissionEventScript](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_generic_mission_event_script.html), [TaleWorlds.MountAndBlade.Objects.ShipVisual](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_ship_visual.html), [TaleWorlds.MountAndBlade.Objects.Siege.SpawnerBase](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html), [TaleWorlds.MountAndBlade.Objects.StealthBox](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_stealth_box.html), [TaleWorlds.MountAndBlade.RandomParticleSpawner](class_tale_worlds_1_1_mount_and_blade_1_1_random_particle_spawner.html), [TaleWorlds.MountAndBlade.RoadPoint](class_tale_worlds_1_1_mount_and_blade_1_1_road_point.html), [TaleWorlds.MountAndBlade.RoadStart](class_tale_worlds_1_1_mount_and_blade_1_1_road_start.html), [TaleWorlds.MountAndBlade.ScenePropDecal](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_decal.html), [TaleWorlds.MountAndBlade.ScenePropNegativeLight](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_negative_light.html), [TaleWorlds.MountAndBlade.ScenePropPositiveLight](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_positive_light.html), [TaleWorlds.MountAndBlade.SoundPlayer](class_tale_worlds_1_1_mount_and_blade_1_1_sound_player.html), [TaleWorlds.MountAndBlade.Source.Objects.NavigationMeshDeactivator](class_tale_worlds_1_1_mount_and_blade_1_1_source_1_1_objects_1_1_navigation_mesh_deactivator.html), [TaleWorlds.MountAndBlade.Source.Objects.SceneLeveler](class_tale_worlds_1_1_mount_and_blade_1_1_source_1_1_objects_1_1_scene_leveler.html), [TaleWorlds.MountAndBlade.TestScript](class_tale_worlds_1_1_mount_and_blade_1_1_test_script.html), [TaleWorlds.MountAndBlade.TrajectoryVisualizer](class_tale_worlds_1_1_mount_and_blade_1_1_trajectory_visualizer.html), [TaleWorlds.MountAndBlade.UsableGameObjectGroup](class_tale_worlds_1_1_mount_and_blade_1_1_usable_game_object_group.html), [TaleWorlds.MountAndBlade.View.ItemVisualizer](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_item_visualizer.html), [TaleWorlds.MountAndBlade.View.PopupSceneEmissionHandler](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_emission_handler.html), [TaleWorlds.MountAndBlade.View.PopupSceneSkeletonAnimationScript](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_skeleton_animation_script.html), [TaleWorlds.MountAndBlade.View.PopupSceneSpawnPoint](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html), [TaleWorlds.MountAndBlade.View.SceneNotification.PopupSceneBanner](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scene_notification_1_1_popup_scene_banner.html), [TaleWorlds.MountAndBlade.View.SceneNotification.PopupSceneShipSpawnPoint](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scene_notification_1_1_popup_scene_ship_spawn_point.html), [TaleWorlds.MountAndBlade.View.Scripts.CharacterDebugSpawner](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_debug_spawner.html), [TaleWorlds.MountAndBlade.View.Scripts.CharacterSpawner](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html), [TaleWorlds.MountAndBlade.View.Scripts.HandMorphTest](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_hand_morph_test.html), [TaleWorlds.MountAndBlade.View.Scripts.HandPose](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_hand_pose.html), [TaleWorlds.MountAndBlade.View.Scripts.MapColorGradeManager](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_map_color_grade_manager.html), [TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html), [TaleWorlds.MountAndBlade.View.Scripts.PopupSceneSequence](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_sequence.html), [TaleWorlds.MountAndBlade.WaterPathPoint](class_tale_worlds_1_1_mount_and_blade_1_1_water_path_point.html), [TaleWorlds.MountAndBlade.WaveFloater](class_tale_worlds_1_1_mount_and_blade_1_1_wave_floater.html), [TaleWorlds.MountAndBlade.WeaponSpawner](class_tale_worlds_1_1_mount_and_blade_1_1_weapon_spawner.html), and [TaleWorlds.MountAndBlade.WindMill](class_tale_worlds_1_1_mount_and_blade_1_1_wind_mill.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) : uint {     [None](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da6adf97f83acf6453d4a6a4b1070f3754) = 0x00000000 ,     [TickOccasionally](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da9cee052f50afabfc1098c1aa6af80b75) = 0x00000001 ,     [Tick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0b3516a5bbb77566f904f9d3877f4710) = 0x00000002 ,     [TickParallel](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da5f5a8f4b9ce783164665db4d70e03ee3) = 0x00000004 ,     [TickParallel2](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0ea9f0c260cdfd8b20ce19a48dbc329f) = 0x00000008 ,     [FixedTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154dadd067942f0b8cc66859698bc9711ba15) = 0x00000010 ,     [FixedParallelTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daa226d712a5ffd8d400f850393ff68492) = 0x00000020 ,     [TickParallel3](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daf785c2c005d708ea434168efc10611b8) = 0x00000040   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [SetScriptComponentToTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ae15c963749bd0f9a75bba24a333b39d4) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) tickReq) |
| void | [SetScriptComponentToTickMT](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a9b2183852eb7b70042ed82ef917022c6) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) value) |
| virtual [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) | [GetTickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ac17100a83d592505ed8d9ac565e512a5) () |

|  |  |
| --- | --- |
| Protected Member Functions | |
| void | [InvalidateWeakPointersIfValid](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#af39d73d0c78790ba81a40a5a350c0526) () |
|  | [ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0bc136bb53989f2b9a4f23f12f54a332) () |
| virtual void | [OnRemoved](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a4778f913080fc216866daa15518c8ecd) (int removeReason) |

|  |  |
| --- | --- |
| Properties | |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | [GameEntity](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0a02cc65cc567db6101ea4afa275ff36) `[get]` |
| [ManagedScriptComponent](class_tale_worlds_1_1_engine_1_1_managed_script_component.html) | [ScriptComponent](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a8d7c5772e6b456b1e22ccd46a0b391ce) `[get]` |
| ManagedScriptHolder | [ManagedScriptHolder](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a58417dd71bf3daca6eb58df177617c2d) `[get]` |
| Scene | [Scene](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a9d7d5b77582948847f1d1c532face2c8) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d)TickRequirement
---------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.Engine.ScriptComponentBehavior.TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) : uint |

| Enumerator | |
| --- | --- |
| None |  |
| TickOccasionally |  |
| Tick |  |
| TickParallel |  |
| TickParallel2 |  |
| FixedTick |  |
| FixedParallelTick |  |
| TickParallel3 |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0bc136bb53989f2b9a4f23f12f54a332)ScriptComponentBehavior()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | TaleWorlds.Engine.ScriptComponentBehavior.ScriptComponentBehavior | ( |  | ) |  | | protected |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#af39d73d0c78790ba81a40a5a350c0526)InvalidateWeakPointersIfValid()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.ScriptComponentBehavior.InvalidateWeakPointersIfValid | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ae15c963749bd0f9a75bba24a333b39d4)SetScriptComponentToTick()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.ScriptComponentBehavior.SetScriptComponentToTick | ( | [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) | *tickReq* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a9b2183852eb7b70042ed82ef917022c6)SetScriptComponentToTickMT()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.ScriptComponentBehavior.SetScriptComponentToTickMT | ( | [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) | *value* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a4778f913080fc216866daa15518c8ecd)OnRemoved()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.Engine.ScriptComponentBehavior.OnRemoved | ( | int | *removeReason* | ) |  | | protectedvirtual |

Reimplemented in [SandBox.Objects.AnimationPoints.AnimationPoint](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#a97811270bafddb849ab5df5a052d4c2a), [SandBox.Objects.Cinematics.HideoutBossFightBehavior](class_sand_box_1_1_objects_1_1_cinematics_1_1_hideout_boss_fight_behavior.html#acda5aee2778020314944ea8591a26640), [TaleWorlds.MountAndBlade.CameraDisplay](class_tale_worlds_1_1_mount_and_blade_1_1_camera_display.html#a80d67f819d1dbc30f4868bb8ea2df4f3), [TaleWorlds.MountAndBlade.CastleGate](class_tale_worlds_1_1_mount_and_blade_1_1_castle_gate.html#a9573ab9ccadf75b444ca284a5c1be733), [TaleWorlds.MountAndBlade.DestructableComponent](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a147ec56484a2403cef2f0f1018f61f77), [TaleWorlds.MountAndBlade.MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a67f885c862847e8c64853294b822cb3f), [TaleWorlds.MountAndBlade.Objects.StealthBox](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_stealth_box.html#a12d1291f530d3dcde88dd1bc7ce0bd32), [TaleWorlds.MountAndBlade.RoadStart](class_tale_worlds_1_1_mount_and_blade_1_1_road_start.html#a6392233a49d1677da24f0cc7cf4e7b2d), [TaleWorlds.MountAndBlade.SiegeTower](class_tale_worlds_1_1_mount_and_blade_1_1_siege_tower.html#a15c7ef60e80e59ee071ac391c20aae3c), [TaleWorlds.MountAndBlade.SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html#a08b88a59b20053ba9d50ed17379d4c75), [TaleWorlds.MountAndBlade.StrategicArea](class_tale_worlds_1_1_mount_and_blade_1_1_strategic_area.html#a1de78d0aefa4a4771f51cbb15c99be2e), [TaleWorlds.MountAndBlade.TrajectoryVisualizer](class_tale_worlds_1_1_mount_and_blade_1_1_trajectory_visualizer.html#aa114bac8644706312671f85156faa5d3), [TaleWorlds.MountAndBlade.UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#abc7226debc7d7f91ee2db48317dd9ca7), [TaleWorlds.MountAndBlade.UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#a4f1f6f103fd69340341f510b1113b215), [TaleWorlds.MountAndBlade.VertexAnimator](class_tale_worlds_1_1_mount_and_blade_1_1_vertex_animator.html#aa1ddc13658a5da67cf7d84df8ac89782), [TaleWorlds.MountAndBlade.View.Scripts.CharacterDebugSpawner](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_debug_spawner.html#a8b752f5d02c677045592e8decf36bb25), [TaleWorlds.MountAndBlade.View.Scripts.CharacterSpawner](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#ac3e658d7af936707ca155bac90a06a95), and [TaleWorlds.MountAndBlade.View.Scripts.HandMorphTest](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_hand_morph_test.html#a46b9857ce3035c24f064cd031a4cd236).

[◆](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ac17100a83d592505ed8d9ac565e512a5)GetTickRequirement()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) TaleWorlds.Engine.ScriptComponentBehavior.GetTickRequirement | ( |  | ) |  | | virtual |

Reimplemented in [SandBox.Missions.CameraJumpScript](class_sand_box_1_1_missions_1_1_camera_jump_script.html#a9808279d4025141ecfd4883e7b5f55f3), [SandBox.Missions.ChangeLightIntensityScript](class_sand_box_1_1_missions_1_1_change_light_intensity_script.html#ac6443c2f157839677fd239900f74aa5c), [SandBox.Missions.RotateObjectScript](class_sand_box_1_1_missions_1_1_rotate_object_script.html#aeb2983bf6348abba7af158e128bf0947), [SandBox.Objects.AnimationPoints.AnimationPoint](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#a687347a98f7ff953af44274b42b6eade), [SandBox.Objects.AnimationPoints.DynamicObjectAnimationPoint](class_sand_box_1_1_objects_1_1_animation_points_1_1_dynamic_object_animation_point.html#a6a03074ddfb3215917ebe34d2d1fbc04), [SandBox.Objects.AnimationPoints.PlayMusicPoint](class_sand_box_1_1_objects_1_1_animation_points_1_1_play_music_point.html#a545c8141118c9b3befb66234ed370464), [SandBox.Objects.CheckpointArea](class_sand_box_1_1_objects_1_1_checkpoint_area.html#abb9f4f1e77a79b4583b1ae9ec21b81c6), [SandBox.Objects.Cinematics.CinematicBurningArrow](class_sand_box_1_1_objects_1_1_cinematics_1_1_cinematic_burning_arrow.html#a9e77731caf6807538d9a48cae4eec20c), [SandBox.Objects.Usables.MusicianGroup](class_sand_box_1_1_objects_1_1_usables_1_1_musician_group.html#ae2ddb4ba4e607da752715d78c36318d7), [SandBox.Objects.Usables.PatrolArea](class_sand_box_1_1_objects_1_1_usables_1_1_patrol_area.html#a9b1d8cd74bfe441bfb932dad2f733997), [SandBox.Objects.Usables.SmithingMachine](class_sand_box_1_1_objects_1_1_usables_1_1_smithing_machine.html#a357e0150a6535dcd06dc6f8089e53b4d), [SandBox.View.Missions.SandBox.SpawnPointDebugView](class_sand_box_1_1_view_1_1_missions_1_1_sand_box_1_1_spawn_point_debug_view.html#ad8bd419e158a730ed2a64302a0fbde59), [TaleWorlds.MountAndBlade.AnimatedFlag](class_tale_worlds_1_1_mount_and_blade_1_1_animated_flag.html#a002548c687b3ff045c26f9da35f4095c), [TaleWorlds.MountAndBlade.Ballista](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a0bc1658456a9b9751bb0841665c55cf4), [TaleWorlds.MountAndBlade.BatteringRam](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a41e7e41d85abbc7f97716805e5ca4a2a), [TaleWorlds.MountAndBlade.Bird](class_tale_worlds_1_1_mount_and_blade_1_1_bird.html#a21af1cb9a0ff7a23fef8663dc1033f21), [TaleWorlds.MountAndBlade.CastleGate](class_tale_worlds_1_1_mount_and_blade_1_1_castle_gate.html#a7b73c282589d04a3177db302ee996d01), [TaleWorlds.MountAndBlade.ExitDoor](class_tale_worlds_1_1_mount_and_blade_1_1_exit_door.html#a466a0aab1d2b64939a0c16ddc2b9bac2), [TaleWorlds.MountAndBlade.LadderQueueManager](class_tale_worlds_1_1_mount_and_blade_1_1_ladder_queue_manager.html#a0906cdf96ec0559e11f879e8acc3cf37), [TaleWorlds.MountAndBlade.Lightning](class_tale_worlds_1_1_mount_and_blade_1_1_lightning.html#afa64357a5efdb3e59f369f5e6cf096a3), [TaleWorlds.MountAndBlade.Mangonel](class_tale_worlds_1_1_mount_and_blade_1_1_mangonel.html#aadc7f18a6d630bbdb56961706d41ec7b), [TaleWorlds.MountAndBlade.Markable](class_tale_worlds_1_1_mount_and_blade_1_1_markable.html#ac660a3a85da762415187ec20f8a7e2c2), [TaleWorlds.MountAndBlade.Mover](class_tale_worlds_1_1_mount_and_blade_1_1_mover.html#a29f08d8e67c367e0eec00f4080cf5515), [TaleWorlds.MountAndBlade.Objects.Usables.AmmoBarrelBase](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_usables_1_1_ammo_barrel_base.html#adea66a418ba860aae862b29565c1b6f1), [TaleWorlds.MountAndBlade.Objects.Usables.ClimbingMachine](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_usables_1_1_climbing_machine.html#a1585bd197763fc86850be2a6cad335a5), [TaleWorlds.MountAndBlade.RandomParticleSpawner](class_tale_worlds_1_1_mount_and_blade_1_1_random_particle_spawner.html#acc0445d7b4a0b1419ec69a45e15d4cd7), [TaleWorlds.MountAndBlade.RangedSiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a353246e344df4aac562d8f720489fb1b), [TaleWorlds.MountAndBlade.SiegeLadder](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#aff40799f62a49e614c1b049f25908cf5), [TaleWorlds.MountAndBlade.SiegeTower](class_tale_worlds_1_1_mount_and_blade_1_1_siege_tower.html#a52b13ae55481fec0ca2d692ec4d28e68), [TaleWorlds.MountAndBlade.SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a3023b7394a73525a663a27ab3d174321), [TaleWorlds.MountAndBlade.SoundPlayer](class_tale_worlds_1_1_mount_and_blade_1_1_sound_player.html#a6d986389f2ec637c64f1423c3205b4b6), [TaleWorlds.MountAndBlade.SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html#ad1e02c9f3d7f5892c24acc9483801668), [TaleWorlds.MountAndBlade.StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html#a5bd0e2de9121087ecee96972cb250e68), [TaleWorlds.MountAndBlade.StandingPointForRangedArea](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point_for_ranged_area.html#a7e827710d8af2ccc2a2412625137617f), [TaleWorlds.MountAndBlade.StonePile](class_tale_worlds_1_1_mount_and_blade_1_1_stone_pile.html#ab589498273cbbd279288ec7c86e7e577), [TaleWorlds.MountAndBlade.SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a4ac82f3267a7b398201cb1f30ee9a37f), [TaleWorlds.MountAndBlade.TestScript](class_tale_worlds_1_1_mount_and_blade_1_1_test_script.html#ad8488f5c72cd507af94460f94d9a78a9), [TaleWorlds.MountAndBlade.TrainingIcon](class_tale_worlds_1_1_mount_and_blade_1_1_training_icon.html#a748c31c550fb5fb970956ab6b7774413), [TaleWorlds.MountAndBlade.Trebuchet](class_tale_worlds_1_1_mount_and_blade_1_1_trebuchet.html#a1eaacd864c1a8529b186d8dfa5f489a6), [TaleWorlds.MountAndBlade.UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a963459a479fbc66654701b3c03525a5a), [TaleWorlds.MountAndBlade.UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#a76db9b9ea560768045354a9aa3075d4b), [TaleWorlds.MountAndBlade.VertexAnimator](class_tale_worlds_1_1_mount_and_blade_1_1_vertex_animator.html#a60be9d86eebbf3e29efd85b77af01653), [TaleWorlds.MountAndBlade.View.PopupSceneEmissionHandler](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_emission_handler.html#a64b12a6f4a00414b123705aaf18f117d), [TaleWorlds.MountAndBlade.View.PopupSceneSkeletonAnimationScript](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_skeleton_animation_script.html#a7d7da95043bd26c4ee9de939646f5b33), [TaleWorlds.MountAndBlade.View.PopupSceneSpawnPoint](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#a9761ce5a179c7a42b7ab6d4043e76303), [TaleWorlds.MountAndBlade.View.Scripts.MapColorGradeManager](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_map_color_grade_manager.html#a2989af6fbf9316a3696fb2c76925d1f0), [TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#ad4fed1f9a176093d174c0132fc27b95b), [TaleWorlds.MountAndBlade.View.Scripts.PopupSceneSequence](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_sequence.html#acb56e5fc97e6d6c60f6f30abe06a0214), [TaleWorlds.MountAndBlade.WaveFloater](class_tale_worlds_1_1_mount_and_blade_1_1_wave_floater.html#aa8b7db2fcb7b45948e9c7a5ca519f6b0), and [TaleWorlds.MountAndBlade.WindMill](class_tale_worlds_1_1_mount_and_blade_1_1_wind_mill.html#a2e2ca05727d8aa3db19c3d880fbda2bd).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0a02cc65cc567db6101ea4afa275ff36)GameEntity
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) TaleWorlds.Engine.ScriptComponentBehavior.GameEntity | | get |

[◆](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a8d7c5772e6b456b1e22ccd46a0b391ce)ScriptComponent
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ManagedScriptComponent](class_tale_worlds_1_1_engine_1_1_managed_script_component.html) TaleWorlds.Engine.ScriptComponentBehavior.ScriptComponent | | get |

[◆](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a58417dd71bf3daca6eb58df177617c2d)ManagedScriptHolder
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ManagedScriptHolder TaleWorlds.Engine.ScriptComponentBehavior.ManagedScriptHolder | | getprotected |

[◆](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a9d7d5b77582948847f1d1c532face2c8)Scene
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Scene TaleWorlds.Engine.ScriptComponentBehavior.Scene | | get |

