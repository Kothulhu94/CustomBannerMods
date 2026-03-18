--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html ---

TaleWorlds.MountAndBlade.Objects.Siege.SpawnerBase Class ReferenceInherits [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

Inherited by [TaleWorlds.MountAndBlade.Objects.Siege.BallistaSpawner](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_ballista_spawner.html), [TaleWorlds.MountAndBlade.Objects.Siege.BatteringRamSpawner](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_battering_ram_spawner.html), [TaleWorlds.MountAndBlade.Objects.Siege.MangonelSpawner](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_mangonel_spawner.html), [TaleWorlds.MountAndBlade.Objects.Siege.SiegeLadderSpawner](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_ladder_spawner.html), [TaleWorlds.MountAndBlade.Objects.Siege.SiegeTowerSpawner](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html), and [TaleWorlds.MountAndBlade.TrebuchetSpawner](class_tale_worlds_1_1_mount_and_blade_1_1_trebuchet_spawner.html).

|  |  |
| --- | --- |
| Classes | |
| class | [SpawnerPermissionField](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base_1_1_spawner_permission_field.html) |
|  | Fields marked with this field will be used in reflection so please don't erase them. [More...](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base_1_1_spawner_permission_field.html#details) |

|  |  |
| --- | --- |
| Public Member Functions | |
| virtual void | [AssignParameters](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html#a41a777f01cd5b27c470efda6db7b6adf) ([SpawnerEntityMissionHelper](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_mission_helper.html) [\_spawnerMissionHelper](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html#a7d2449bd0874c0e6a6e15257a890f033)) |
|  | This function has "\_spawnerMissionHelper" argument because when this function has been called the spawner script hasn't acquired SpawnerMissionHelper yet. |
| Public Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [SetScriptComponentToTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ae15c963749bd0f9a75bba24a333b39d4) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) tickReq) |
| void | [SetScriptComponentToTickMT](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a9b2183852eb7b70042ed82ef917022c6) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) value) |
| virtual [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) | [GetTickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ac17100a83d592505ed8d9ac565e512a5) () |

|  |  |
| --- | --- |
| Public Attributes | |
| string | [ToBeSpawnedOverrideName](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html#a42841a9c707593f9f35e715fe94792c8) = "" |
| string | [ToBeSpawnedOverrideNameForFireVersion](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html#a14aae7a1fe000bc7ac844fe1c0ebaf10) = "" |

|  |  |
| --- | --- |
| Protected Attributes | |
| [SpawnerEntityEditorHelper](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_editor_helper.html) | [\_spawnerEditorHelper](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html#a36ae72189adf79cea47efdbc15af4642) = null |
| [SpawnerEntityMissionHelper](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_mission_helper.html) | [\_spawnerMissionHelper](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html#a7d2449bd0874c0e6a6e15257a890f033) = null |
| [SpawnerEntityMissionHelper](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_mission_helper.html) | [\_spawnerMissionHelperFire](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html#abce255df73789f982d92a11c57d0016d) = null |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Types inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| enum | [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) : uint {     [None](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da6adf97f83acf6453d4a6a4b1070f3754) = 0x00000000 ,     [TickOccasionally](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da9cee052f50afabfc1098c1aa6af80b75) = 0x00000001 ,     [Tick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0b3516a5bbb77566f904f9d3877f4710) = 0x00000002 ,     [TickParallel](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da5f5a8f4b9ce783164665db4d70e03ee3) = 0x00000004 ,     [TickParallel2](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0ea9f0c260cdfd8b20ce19a48dbc329f) = 0x00000008 ,     [FixedTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154dadd067942f0b8cc66859698bc9711ba15) = 0x00000010 ,     [FixedParallelTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daa226d712a5ffd8d400f850393ff68492) = 0x00000020 ,     [TickParallel3](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daf785c2c005d708ea434168efc10611b8) = 0x00000040   } |
| Protected Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [InvalidateWeakPointersIfValid](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#af39d73d0c78790ba81a40a5a350c0526) () |
|  | [ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0bc136bb53989f2b9a4f23f12f54a332) () |
| virtual void | [OnRemoved](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a4778f913080fc216866daa15518c8ecd) (int removeReason) |
| Properties inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | [GameEntity](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0a02cc65cc567db6101ea4afa275ff36) `[get]` |
| [ManagedScriptComponent](class_tale_worlds_1_1_engine_1_1_managed_script_component.html) | [ScriptComponent](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a8d7c5772e6b456b1e22ccd46a0b391ce) `[get]` |
| ManagedScriptHolder | [ManagedScriptHolder](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a58417dd71bf3daca6eb58df177617c2d) `[get]` |
| Scene | [Scene](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a9d7d5b77582948847f1d1c532face2c8) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html#a41a777f01cd5b27c470efda6db7b6adf)AssignParameters()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.Objects.Siege.SpawnerBase.AssignParameters | ( | [SpawnerEntityMissionHelper](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_mission_helper.html) | *\_spawnerMissionHelper* | ) |  | | virtual |

Parameters
:   |  |  |
    | --- | --- |
    | spawnedEntity |  |

Reimplemented in [TaleWorlds.MountAndBlade.Objects.Siege.BallistaSpawner](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_ballista_spawner.html#aad317b2d2ed4c6b638c80775d2be2c21), [TaleWorlds.MountAndBlade.Objects.Siege.BatteringRamSpawner](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_battering_ram_spawner.html#aa1397ea26d277d139f624823f8d69020), [TaleWorlds.MountAndBlade.Objects.Siege.MangonelSpawner](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_mangonel_spawner.html#a58f444b3e685e25000a24d008dc2cc50), [TaleWorlds.MountAndBlade.Objects.Siege.MultiplayerBatteringRamSpawner](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_multiplayer_battering_ram_spawner.html#a5d35248dd1feb44f1a37e05145e21303), [TaleWorlds.MountAndBlade.Objects.Siege.MultiplayerSiegeTowerSpawner](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_multiplayer_siege_tower_spawner.html#af5b450980bb40b5659dd261f7517a97f), [TaleWorlds.MountAndBlade.Objects.Siege.SiegeLadderSpawner](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_ladder_spawner.html#a007df7f6561ca63b3065206e8e9736c8), [TaleWorlds.MountAndBlade.Objects.Siege.SiegeTowerSpawner](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#a5486da8a8f4c0308ca108b5a00774318), and [TaleWorlds.MountAndBlade.TrebuchetSpawner](class_tale_worlds_1_1_mount_and_blade_1_1_trebuchet_spawner.html#aa779101ba00c036fedb0f6ffad5ea59b).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html#a42841a9c707593f9f35e715fe94792c8)ToBeSpawnedOverrideName
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.Objects.Siege.SpawnerBase.ToBeSpawnedOverrideName = "" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html#a14aae7a1fe000bc7ac844fe1c0ebaf10)ToBeSpawnedOverrideNameForFireVersion
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.Objects.Siege.SpawnerBase.ToBeSpawnedOverrideNameForFireVersion = "" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html#a36ae72189adf79cea47efdbc15af4642)\_spawnerEditorHelper
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SpawnerEntityEditorHelper](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_editor_helper.html) TaleWorlds.MountAndBlade.Objects.Siege.SpawnerBase.\_spawnerEditorHelper = null | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html#a7d2449bd0874c0e6a6e15257a890f033)\_spawnerMissionHelper
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SpawnerEntityMissionHelper](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_mission_helper.html) TaleWorlds.MountAndBlade.Objects.Siege.SpawnerBase.\_spawnerMissionHelper = null | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html#abce255df73789f982d92a11c57d0016d)\_spawnerMissionHelperFire
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SpawnerEntityMissionHelper](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_mission_helper.html) TaleWorlds.MountAndBlade.Objects.Siege.SpawnerBase.\_spawnerMissionHelperFire = null | | protected |

