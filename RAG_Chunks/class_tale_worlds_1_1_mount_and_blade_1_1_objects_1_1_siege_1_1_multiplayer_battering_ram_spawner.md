--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_multiplayer_battering_ram_spawner.html ---

TaleWorlds.MountAndBlade.Objects.Siege.MultiplayerBatteringRamSpawner Class ReferenceInherits [TaleWorlds.MountAndBlade.Objects.Siege.BatteringRamSpawner](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_battering_ram_spawner.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [AssignParameters](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_multiplayer_battering_ram_spawner.html#a5d35248dd1feb44f1a37e05145e21303) ([SpawnerEntityMissionHelper](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_mission_helper.html) [\_spawnerMissionHelper](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html#a7d2449bd0874c0e6a6e15257a890f033)) |
|  | This function has "\_spawnerMissionHelper" argument because when this function has been called the spawner script hasn't acquired SpawnerMissionHelper yet. |
| Public Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [SetScriptComponentToTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ae15c963749bd0f9a75bba24a333b39d4) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) tickReq) |
| void | [SetScriptComponentToTickMT](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a9b2183852eb7b70042ed82ef917022c6) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) value) |
| virtual [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) | [GetTickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ac17100a83d592505ed8d9ac565e512a5) () |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Types inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| enum | [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) : uint {     [None](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da6adf97f83acf6453d4a6a4b1070f3754) = 0x00000000 ,     [TickOccasionally](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da9cee052f50afabfc1098c1aa6af80b75) = 0x00000001 ,     [Tick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0b3516a5bbb77566f904f9d3877f4710) = 0x00000002 ,     [TickParallel](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da5f5a8f4b9ce783164665db4d70e03ee3) = 0x00000004 ,     [TickParallel2](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0ea9f0c260cdfd8b20ce19a48dbc329f) = 0x00000008 ,     [FixedTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154dadd067942f0b8cc66859698bc9711ba15) = 0x00000010 ,     [FixedParallelTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daa226d712a5ffd8d400f850393ff68492) = 0x00000020 ,     [TickParallel3](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daf785c2c005d708ea434168efc10611b8) = 0x00000040   } |
| Public Attributes inherited from [TaleWorlds.MountAndBlade.Objects.Siege.BatteringRamSpawner](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_battering_ram_spawner.html) | |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [wait\_pos\_ground](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_battering_ram_spawner.html#aad4291995df19ae51437a82f025c3cb8) = [MatrixFrame.Zero](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a3334fcb67f6967b227157c879ca90d15) |
| string | [SideTag](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_battering_ram_spawner.html#abdc88bdd534ffeb8f7c03732bfe4af93) |
| string | [GateTag](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_battering_ram_spawner.html#aa708a875457de6391e6bd0112db241ae) = "" |
| string | [PathEntityName](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_battering_ram_spawner.html#aa4d0b5c9a11cf8b5d464ae96294d41d9) = "Path" |
| int | [BridgeNavMeshID\_1](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_battering_ram_spawner.html#ab67c12d78081f90f9079b9da9c279961) = 8 |
| int | [BridgeNavMeshID\_2](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_battering_ram_spawner.html#afe52ae3e25abc96bba3b8ba241072b62) = 8 |
| int | [DitchNavMeshID\_1](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_battering_ram_spawner.html#ac80987735667be85dfd0f9ba179cf4d5) = 9 |
| int | [DitchNavMeshID\_2](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_battering_ram_spawner.html#a47e32d3d6edc6e7f6099db02a72b22e6) = 10 |
| int | [GroundToBridgeNavMeshID\_1](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_battering_ram_spawner.html#a90cecc784e0573064d088309e1c66f18) = 12 |
| int | [GroundToBridgeNavMeshID\_2](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_battering_ram_spawner.html#a1ee6a92e289db5186791daf362daf049) = 13 |
| string | [AddOnDeployTag](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_battering_ram_spawner.html#a8c1d4ec7314c0a7622d035d58f7d9db5) = "" |
| string | [RemoveOnDeployTag](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_battering_ram_spawner.html#a8d3970e405feaeaf860b47f2536491c6) = "" |
| float | [SpeedModifierFactor](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_battering_ram_spawner.html#afaf51b35e2a235a9ab774499f4898eaf) = 1.0f |
| bool | [EnableAutoGhostMovement](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_battering_ram_spawner.html#ab43396f64d3c800d7f61e619307ed6d0) = false |
| Public Attributes inherited from [TaleWorlds.MountAndBlade.Objects.Siege.SpawnerBase](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html) | |
| string | [ToBeSpawnedOverrideName](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html#a42841a9c707593f9f35e715fe94792c8) = "" |
| string | [ToBeSpawnedOverrideNameForFireVersion](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html#a14aae7a1fe000bc7ac844fe1c0ebaf10) = "" |
| Protected Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [InvalidateWeakPointersIfValid](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#af39d73d0c78790ba81a40a5a350c0526) () |
|  | [ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0bc136bb53989f2b9a4f23f12f54a332) () |
| virtual void | [OnRemoved](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a4778f913080fc216866daa15518c8ecd) (int removeReason) |
| Protected Attributes inherited from [TaleWorlds.MountAndBlade.Objects.Siege.SpawnerBase](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html) | |
| [SpawnerEntityEditorHelper](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_editor_helper.html) | [\_spawnerEditorHelper](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html#a36ae72189adf79cea47efdbc15af4642) = null |
| [SpawnerEntityMissionHelper](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_mission_helper.html) | [\_spawnerMissionHelper](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html#a7d2449bd0874c0e6a6e15257a890f033) = null |
| [SpawnerEntityMissionHelper](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_mission_helper.html) | [\_spawnerMissionHelperFire](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html#abce255df73789f982d92a11c57d0016d) = null |
| Properties inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | [GameEntity](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0a02cc65cc567db6101ea4afa275ff36) `[get]` |
| [ManagedScriptComponent](class_tale_worlds_1_1_engine_1_1_managed_script_component.html) | [ScriptComponent](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a8d7c5772e6b456b1e22ccd46a0b391ce) `[get]` |
| ManagedScriptHolder | [ManagedScriptHolder](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a58417dd71bf3daca6eb58df177617c2d) `[get]` |
| Scene | [Scene](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a9d7d5b77582948847f1d1c532face2c8) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_multiplayer_battering_ram_spawner.html#a5d35248dd1feb44f1a37e05145e21303)AssignParameters()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.Objects.Siege.MultiplayerBatteringRamSpawner.AssignParameters | ( | [SpawnerEntityMissionHelper](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_mission_helper.html) | *\_spawnerMissionHelper* | ) |  | | virtual |

Parameters
:   |  |  |
    | --- | --- |
    | spawnedEntity |  |

Reimplemented from [TaleWorlds.MountAndBlade.Objects.Siege.BatteringRamSpawner](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_battering_ram_spawner.html#aa1397ea26d277d139f624823f8d69020).

