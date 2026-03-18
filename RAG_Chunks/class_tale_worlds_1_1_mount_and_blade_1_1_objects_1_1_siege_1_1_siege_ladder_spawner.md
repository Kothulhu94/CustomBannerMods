--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_ladder_spawner.html ---

TaleWorlds.MountAndBlade.Objects.Siege.SiegeLadderSpawner Class ReferenceInherits [TaleWorlds.MountAndBlade.Objects.Siege.SpawnerBase](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [AssignParameters](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_ladder_spawner.html#a007df7f6561ca63b3065206e8e9736c8) ([SpawnerEntityMissionHelper](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_mission_helper.html) [\_spawnerMissionHelper](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html#a7d2449bd0874c0e6a6e15257a890f033)) |
|  | This function has "\_spawnerMissionHelper" argument because when this function has been called the spawner script hasn't acquired SpawnerMissionHelper yet. |
| Public Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [SetScriptComponentToTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ae15c963749bd0f9a75bba24a333b39d4) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) tickReq) |
| void | [SetScriptComponentToTickMT](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a9b2183852eb7b70042ed82ef917022c6) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) value) |
| virtual [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) | [GetTickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ac17100a83d592505ed8d9ac565e512a5) () |

|  |  |
| --- | --- |
| Public Attributes | |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [fork\_holder](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_ladder_spawner.html#a614a945a82631dae04ee072c785a8939) = [MatrixFrame.Zero](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a3334fcb67f6967b227157c879ca90d15) |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [initial\_wait\_pos](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_ladder_spawner.html#a98cce83479e989571731af1bc1108242) = [MatrixFrame.Zero](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a3334fcb67f6967b227157c879ca90d15) |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [use\_push](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_ladder_spawner.html#affe00c0bd5d9436ea61f6a576fb13c58) = [MatrixFrame.Zero](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a3334fcb67f6967b227157c879ca90d15) |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [stand\_position\_wall\_push](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_ladder_spawner.html#a63d99231be998ec8392d2f33885c7f9e) = [MatrixFrame.Zero](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a3334fcb67f6967b227157c879ca90d15) |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [distance\_holder](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_ladder_spawner.html#a54e19486d4e49543428251191a116936) = [MatrixFrame.Zero](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a3334fcb67f6967b227157c879ca90d15) |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [stand\_position\_ground\_wait](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_ladder_spawner.html#a88802f66d8df90b684c1fc4e8a0ae9eb) = [MatrixFrame.Zero](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a3334fcb67f6967b227157c879ca90d15) |
| string | [SideTag](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_ladder_spawner.html#ab6d07c6a493541a5efc358b61dfb3f6a) |
| string | [TargetWallSegmentTag](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_ladder_spawner.html#a1230a75a7c91b17736b8c09320cd93e8) = "" |
| int | [OnWallNavMeshId](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_ladder_spawner.html#a72351b7b66dd1a5ce85a308cf1b59b0b) = -1 |
| string | [AddOnDeployTag](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_ladder_spawner.html#aa5f79376b7f5e4cc68562698a251f28e) = "" |
| string | [RemoveOnDeployTag](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_ladder_spawner.html#a05122c39bd491341f1ab112b9d715160) = "" |
| float | [UpperStateRotationDegree](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_ladder_spawner.html#ad8fa15b6d75f8893e62918dd1119e9c9) = 0.0f |
| float | [DownStateRotationDegree](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_ladder_spawner.html#ac5f94862143947d7e17bd6644279ade1) = 90.0f |
| float | [TacticalPositionWidth](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_ladder_spawner.html#a20b98653902f6c815633f058302fab75) = 1.0f |
| string | [BarrierTagToRemove](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_ladder_spawner.html#adb65aa8aa5c9013510390ec1fe7cd99e) = string.Empty |
| string | [IndestructibleMerlonsTag](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_ladder_spawner.html#ac292b2031f7198dbbb6c14c1e329d97e) = string.Empty |
| Public Attributes inherited from [TaleWorlds.MountAndBlade.Objects.Siege.SpawnerBase](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html) | |
| string | [ToBeSpawnedOverrideName](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html#a42841a9c707593f9f35e715fe94792c8) = "" |
| string | [ToBeSpawnedOverrideNameForFireVersion](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html#a14aae7a1fe000bc7ac844fe1c0ebaf10) = "" |

|  |  |
| --- | --- |
| Properties | |
| float | [UpperStateRotationRadian](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_ladder_spawner.html#ac27ae6aed4720878b6b4c0f2892d8a26) `[get]` |
| float | [DownStateRotationRadian](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_ladder_spawner.html#ad2bd1349e9a590fdf575f49479642060) `[get]` |
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

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_ladder_spawner.html#a007df7f6561ca63b3065206e8e9736c8)AssignParameters()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.Objects.Siege.SiegeLadderSpawner.AssignParameters | ( | [SpawnerEntityMissionHelper](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_mission_helper.html) | *\_spawnerMissionHelper* | ) |  | | virtual |

Parameters
:   |  |  |
    | --- | --- |
    | spawnedEntity |  |

Reimplemented from [TaleWorlds.MountAndBlade.Objects.Siege.SpawnerBase](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html#a41a777f01cd5b27c470efda6db7b6adf).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_ladder_spawner.html#a614a945a82631dae04ee072c785a8939)fork\_holder
--------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.Objects.Siege.SiegeLadderSpawner.fork\_holder = [MatrixFrame.Zero](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a3334fcb67f6967b227157c879ca90d15) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_ladder_spawner.html#a98cce83479e989571731af1bc1108242)initial\_wait\_pos
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.Objects.Siege.SiegeLadderSpawner.initial\_wait\_pos = [MatrixFrame.Zero](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a3334fcb67f6967b227157c879ca90d15) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_ladder_spawner.html#affe00c0bd5d9436ea61f6a576fb13c58)use\_push
-----------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.Objects.Siege.SiegeLadderSpawner.use\_push = [MatrixFrame.Zero](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a3334fcb67f6967b227157c879ca90d15) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_ladder_spawner.html#a63d99231be998ec8392d2f33885c7f9e)stand\_position\_wall\_push
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.Objects.Siege.SiegeLadderSpawner.stand\_position\_wall\_push = [MatrixFrame.Zero](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a3334fcb67f6967b227157c879ca90d15) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_ladder_spawner.html#a54e19486d4e49543428251191a116936)distance\_holder
------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.Objects.Siege.SiegeLadderSpawner.distance\_holder = [MatrixFrame.Zero](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a3334fcb67f6967b227157c879ca90d15) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_ladder_spawner.html#a88802f66d8df90b684c1fc4e8a0ae9eb)stand\_position\_ground\_wait
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.Objects.Siege.SiegeLadderSpawner.stand\_position\_ground\_wait = [MatrixFrame.Zero](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a3334fcb67f6967b227157c879ca90d15) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_ladder_spawner.html#ab6d07c6a493541a5efc358b61dfb3f6a)SideTag
---------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.Objects.Siege.SiegeLadderSpawner.SideTag |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_ladder_spawner.html#a1230a75a7c91b17736b8c09320cd93e8)TargetWallSegmentTag
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.Objects.Siege.SiegeLadderSpawner.TargetWallSegmentTag = "" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_ladder_spawner.html#a72351b7b66dd1a5ce85a308cf1b59b0b)OnWallNavMeshId
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.Objects.Siege.SiegeLadderSpawner.OnWallNavMeshId = -1 |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_ladder_spawner.html#aa5f79376b7f5e4cc68562698a251f28e)AddOnDeployTag
----------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.Objects.Siege.SiegeLadderSpawner.AddOnDeployTag = "" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_ladder_spawner.html#a05122c39bd491341f1ab112b9d715160)RemoveOnDeployTag
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.Objects.Siege.SiegeLadderSpawner.RemoveOnDeployTag = "" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_ladder_spawner.html#ad8fa15b6d75f8893e62918dd1119e9c9)UpperStateRotationDegree
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.Objects.Siege.SiegeLadderSpawner.UpperStateRotationDegree = 0.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_ladder_spawner.html#ac5f94862143947d7e17bd6644279ade1)DownStateRotationDegree
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.Objects.Siege.SiegeLadderSpawner.DownStateRotationDegree = 90.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_ladder_spawner.html#a20b98653902f6c815633f058302fab75)TacticalPositionWidth
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.Objects.Siege.SiegeLadderSpawner.TacticalPositionWidth = 1.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_ladder_spawner.html#adb65aa8aa5c9013510390ec1fe7cd99e)BarrierTagToRemove
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.Objects.Siege.SiegeLadderSpawner.BarrierTagToRemove = string.Empty |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_ladder_spawner.html#ac292b2031f7198dbbb6c14c1e329d97e)IndestructibleMerlonsTag
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.Objects.Siege.SiegeLadderSpawner.IndestructibleMerlonsTag = string.Empty |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_ladder_spawner.html#ac27ae6aed4720878b6b4c0f2892d8a26)UpperStateRotationRadian
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Objects.Siege.SiegeLadderSpawner.UpperStateRotationRadian | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_siege_ladder_spawner.html#ad2bd1349e9a590fdf575f49479642060)DownStateRotationRadian
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Objects.Siege.SiegeLadderSpawner.DownStateRotationRadian | | get |

