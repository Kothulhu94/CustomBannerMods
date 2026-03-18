--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html ---

TaleWorlds.MountAndBlade.Objects.Siege.SiegeTowerSpawner Class ReferenceInherits [TaleWorlds.MountAndBlade.Objects.Siege.SpawnerBase](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html).

Inherited by [TaleWorlds.MountAndBlade.Objects.Siege.MultiplayerSiegeTowerSpawner](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_multiplayer_siege_tower_spawner.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [AssignParameters](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#a5486da8a8f4c0308ca108b5a00774318) ([SpawnerEntityMissionHelper](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_mission_helper.html) [\_spawnerMissionHelper](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html#a7d2449bd0874c0e6a6e15257a890f033)) |
|  | This function has "\_spawnerMissionHelper" argument because when this function has been called the spawner script hasn't acquired SpawnerMissionHelper yet. |
| Public Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [SetScriptComponentToTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ae15c963749bd0f9a75bba24a333b39d4) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) tickReq) |
| void | [SetScriptComponentToTickMT](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a9b2183852eb7b70042ed82ef917022c6) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) value) |
| virtual [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) | [GetTickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ac17100a83d592505ed8d9ac565e512a5) () |

|  |  |
| --- | --- |
| Public Attributes | |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [wait\_pos\_ground](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#ad156bb25129b37a421d2728b6e65c584) = [MatrixFrame.Zero](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a3334fcb67f6967b227157c879ca90d15) |
| string | [SideTag](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#ae1569accbf71523161e692c030bbdefb) |
| string | [TargetWallSegmentTag](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#a17a4a23f9a54004ce3cde76feebbe12b) = "" |
| string | [PathEntityName](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#a70333847ca71cd0f1a3b5276b7ae94cb) = "Path" |
| int | [SoilNavMeshID1](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#ad88f308bb938a6d1486da2f4f8f63461) = -1 |
| int | [SoilNavMeshID2](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#afd3be24b56109562559a3eb2d7c9a2f4) = -1 |
| int | [DitchNavMeshID1](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#a91ac5e3df87520d3d56c2c4a5bafe613) = -1 |
| int | [DitchNavMeshID2](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#a664d442ebbb58b1a5a89c42413225b71) = -1 |
| int | [GroundToSoilNavMeshID1](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#a8740d61eaa33632e1ddb91ff3497323e) = -1 |
| int | [GroundToSoilNavMeshID2](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#a0a73afca8c8b05cf852b0b6d213f79ba) = -1 |
| int | [SoilGenericNavMeshID](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#a99e993b819347d9b2e300e0398ec644b) = -1 |
| int | [GroundGenericNavMeshID](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#a8ad9c826bc1a05f08d2782adc9a0c390) = -1 |
| string | [AddOnDeployTag](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#ae0e05384f1cdb7963111d48a57c07fcf) = "" |
| string | [RemoveOnDeployTag](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#a6115895873836dd16c4ce1481240eb63) = "" |
| float | [RampRotationDegree](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#af5578030a195dadae7d4512acf1ff07b) = 0.0f |
| float | [BarrierLength](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#a268f45cdce18a439655381ec6a6244dd) = 1.0f |
| float | [SpeedModifierFactor](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#abcbdd9a72ac95717d0e0b62f3aab166b) = 1.0f |
| bool | [EnableAutoGhostMovement](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#a0df913a032af2b596f9783e509ffdd40) = false |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [ai\_barrier\_l](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#a2458fa2eb04935160a68eced8fd190ba) = [MatrixFrame.Zero](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a3334fcb67f6967b227157c879ca90d15) |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [ai\_barrier\_r](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#ab04c2de5a21e3d2cf24b2e03fbdff7fc) = [MatrixFrame.Zero](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a3334fcb67f6967b227157c879ca90d15) |
| string | [BarrierTagToRemove](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#a6a9082bb73e8f09d99b5bb1dd80d6654) = string.Empty |
| Public Attributes inherited from [TaleWorlds.MountAndBlade.Objects.Siege.SpawnerBase](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html) | |
| string | [ToBeSpawnedOverrideName](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html#a42841a9c707593f9f35e715fe94792c8) = "" |
| string | [ToBeSpawnedOverrideNameForFireVersion](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html#a14aae7a1fe000bc7ac844fe1c0ebaf10) = "" |

|  |  |
| --- | --- |
| Properties | |
| float | [RampRotationRadian](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#a5eab54ee2a8527420a62ed95cb249726) `[get]` |
| Properties inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | [GameEntity](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0a02cc65cc567db6101ea4afa275ff36) `[get]` |
| [ManagedScriptComponent](class_tale_worlds_1_1_engine_1_1_managed_script_component.html) | [ScriptComponent](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a8d7c5772e6b456b1e22ccd46a0b391ce) `[get]` |
| ManagedScriptHolder | [ManagedScriptHolder](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a58417dd71bf3daca6eb58df177617c2d) `[get]` |
| Scene | [Scene](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a9d7d5b77582948847f1d1c532face2c8) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Types inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| enum | [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) : uint {     [None](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da6adf97f83acf6453d4a6a4b1070f3754) = 0x00000000 ,     [TickOccasionally](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da9cee052f50afabfc1098c1aa6af80b75) = 0x00000001 ,     [Tick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0b3516a5bbb77566f904f9d3877f4710) = 0x00000002 ,     [TickParallel](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da5f5a8f4b9ce783164665db4d70e03ee3) = 0x00000004 ,     [TickParallel2](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0ea9f0c260cdfd8b20ce19a48dbc329f) = 0x00000008 ,     [FixedTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154dadd067942f0b8cc66859698bc9711ba15) = 0x00000010 ,     [FixedParallelTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daa226d712a5ffd8d400f850393ff68492) = 0x00000020 ,     [TickParallel3](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daf785c2c005d708ea434168efc10611b8) = 0x00000040   } |
| Protected Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [InvalidateWeakPointersIfValid](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#af39d73d0c78790ba81a40a5a350c0526) () |
|  | [ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0bc136bb53989f2b9a4f23f12f54a332) () |
| virtual void | [OnRemoved](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a4778f913080fc216866daa15518c8ecd) (int removeReason) |
| Protected Attributes inherited from [TaleWorlds.MountAndBlade.Objects.Siege.SpawnerBase](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html) | |
| [SpawnerEntityEditorHelper](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_editor_helper.html) | [\_spawnerEditorHelper](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html#a36ae72189adf79cea47efdbc15af4642) = null |
| [SpawnerEntityMissionHelper](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_mission_helper.html) | [\_spawnerMissionHelper](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html#a7d2449bd0874c0e6a6e15257a890f033) = null |
| [SpawnerEntityMissionHelper](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_mission_helper.html) | [\_spawnerMissionHelperFire](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html#abce255df73789f982d92a11c57d0016d) = null |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#a5486da8a8f4c0308ca108b5a00774318)AssignParameters()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.Objects.Siege.SiegeTowerSpawner.AssignParameters | ( | [SpawnerEntityMissionHelper](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_mission_helper.html) | *\_spawnerMissionHelper* | ) |  | | virtual |

Parameters
:   |  |  |
    | --- | --- |
    | spawnedEntity |  |

Reimplemented from [TaleWorlds.MountAndBlade.Objects.Siege.SpawnerBase](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html#a41a777f01cd5b27c470efda6db7b6adf).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#ad156bb25129b37a421d2728b6e65c584)wait\_pos\_ground
------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.Objects.Siege.SiegeTowerSpawner.wait\_pos\_ground = [MatrixFrame.Zero](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a3334fcb67f6967b227157c879ca90d15) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#ae1569accbf71523161e692c030bbdefb)SideTag
--------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.Objects.Siege.SiegeTowerSpawner.SideTag |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#a17a4a23f9a54004ce3cde76feebbe12b)TargetWallSegmentTag
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.Objects.Siege.SiegeTowerSpawner.TargetWallSegmentTag = "" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#a70333847ca71cd0f1a3b5276b7ae94cb)PathEntityName
---------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.Objects.Siege.SiegeTowerSpawner.PathEntityName = "Path" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#ad88f308bb938a6d1486da2f4f8f63461)SoilNavMeshID1
---------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.Objects.Siege.SiegeTowerSpawner.SoilNavMeshID1 = -1 |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#afd3be24b56109562559a3eb2d7c9a2f4)SoilNavMeshID2
---------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.Objects.Siege.SiegeTowerSpawner.SoilNavMeshID2 = -1 |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#a91ac5e3df87520d3d56c2c4a5bafe613)DitchNavMeshID1
----------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.Objects.Siege.SiegeTowerSpawner.DitchNavMeshID1 = -1 |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#a664d442ebbb58b1a5a89c42413225b71)DitchNavMeshID2
----------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.Objects.Siege.SiegeTowerSpawner.DitchNavMeshID2 = -1 |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#a8740d61eaa33632e1ddb91ff3497323e)GroundToSoilNavMeshID1
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.Objects.Siege.SiegeTowerSpawner.GroundToSoilNavMeshID1 = -1 |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#a0a73afca8c8b05cf852b0b6d213f79ba)GroundToSoilNavMeshID2
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.Objects.Siege.SiegeTowerSpawner.GroundToSoilNavMeshID2 = -1 |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#a99e993b819347d9b2e300e0398ec644b)SoilGenericNavMeshID
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.Objects.Siege.SiegeTowerSpawner.SoilGenericNavMeshID = -1 |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#a8ad9c826bc1a05f08d2782adc9a0c390)GroundGenericNavMeshID
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.Objects.Siege.SiegeTowerSpawner.GroundGenericNavMeshID = -1 |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#ae0e05384f1cdb7963111d48a57c07fcf)AddOnDeployTag
---------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.Objects.Siege.SiegeTowerSpawner.AddOnDeployTag = "" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#a6115895873836dd16c4ce1481240eb63)RemoveOnDeployTag
------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.Objects.Siege.SiegeTowerSpawner.RemoveOnDeployTag = "" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#af5578030a195dadae7d4512acf1ff07b)RampRotationDegree
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.Objects.Siege.SiegeTowerSpawner.RampRotationDegree = 0.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#a268f45cdce18a439655381ec6a6244dd)BarrierLength
--------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.Objects.Siege.SiegeTowerSpawner.BarrierLength = 1.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#abcbdd9a72ac95717d0e0b62f3aab166b)SpeedModifierFactor
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.Objects.Siege.SiegeTowerSpawner.SpeedModifierFactor = 1.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#a0df913a032af2b596f9783e509ffdd40)EnableAutoGhostMovement
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.Objects.Siege.SiegeTowerSpawner.EnableAutoGhostMovement = false |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#a2458fa2eb04935160a68eced8fd190ba)ai\_barrier\_l
---------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.Objects.Siege.SiegeTowerSpawner.ai\_barrier\_l = [MatrixFrame.Zero](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a3334fcb67f6967b227157c879ca90d15) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#ab04c2de5a21e3d2cf24b2e03fbdff7fc)ai\_barrier\_r
---------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.Objects.Siege.SiegeTowerSpawner.ai\_barrier\_r = [MatrixFrame.Zero](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a3334fcb67f6967b227157c879ca90d15) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#a6a9082bb73e8f09d99b5bb1dd80d6654)BarrierTagToRemove
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.Objects.Siege.SiegeTowerSpawner.BarrierTagToRemove = string.Empty |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_tower_spawner.html#a5eab54ee2a8527420a62ed95cb249726)RampRotationRadian
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Objects.Siege.SiegeTowerSpawner.RampRotationRadian | | get |

