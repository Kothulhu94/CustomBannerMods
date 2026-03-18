--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_ladder_queue_manager.html ---

TaleWorlds.MountAndBlade.LadderQueueManager Class ReferenceInherits [TaleWorlds.MountAndBlade.MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [DeactivateImmediate](class_tale_worlds_1_1_mount_and_blade_1_1_ladder_queue_manager.html#a97785c0e531f0dbba5596dd66bcc0b5d) () |
| void | [Deactivate](class_tale_worlds_1_1_mount_and_blade_1_1_ladder_queue_manager.html#ad8e1f2d80f0a20685e1a1e5dda167fcc) () |
| void | [Activate](class_tale_worlds_1_1_mount_and_blade_1_1_ladder_queue_manager.html#ae2d4206ad177cdca4ee970597310e1e3) () |
| void | [Initialize](class_tale_worlds_1_1_mount_and_blade_1_1_ladder_queue_manager.html#a9260d55f4a8212870c55fb7a9999b980) (int managedNavigationFaceId, [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) managedFrame, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) managedDirection, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) managedSide, int maxUserCount, float arcAngle, float queueBeginDistance, float queueRowSize, float costPerRow, float baseCost, bool blockUsage, float agentSpacing, float zDifferenceToStopUsing, float distanceToStopUsing2d, bool doesManageMultipleIDs, int managedNavigationFaceAlternateID1, int managedNavigationFaceAlternateID2, int maxClimberCount, int maxRunnerCount) |
| override [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) | [GetTickRequirement](class_tale_worlds_1_1_mount_and_blade_1_1_ladder_queue_manager.html#a0906cdf96ec0559e11f879e8acc3cf37) () |
| void | [FlushQueueManager](class_tale_worlds_1_1_mount_and_blade_1_1_ladder_queue_manager.html#a14f3858ccfb2524c689b98c599d007de) () |
| void | [AssignNeighborQueueManager](class_tale_worlds_1_1_mount_and_blade_1_1_ladder_queue_manager.html#a03a0a82d971a1de52c4ee948958159fb) ([LadderQueueManager](class_tale_worlds_1_1_mount_and_blade_1_1_ladder_queue_manager.html) neighborLadderQueueManager) |
| void | [OnFormationFrameChanged](class_tale_worlds_1_1_mount_and_blade_1_1_ladder_queue_manager.html#a1d0e17fc742787959a83e2e5d5ab3b1d) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, bool hasFrame, [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) frame) |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | |
|  | [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a4eaa53f5b1c5e3af4d4189e099c8e05e) () |
| virtual void | [SetAbilityOfFaces](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#ad02ae6fa04bfdc79f9fcd010afbff84e) (bool enabled) |
| override int | [GetHashCode](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a41ecc2ecbc888f99ca3b942d63503381) () |
| virtual void | [AfterMissionStart](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a925fa787ae9b9a2ec414c9b575156fc1) () |
| virtual void | [OnMissionEnded](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#aa903cd7aefee1178f7e0700031f6cbd3) () |
| virtual void | [OnDeploymentFinished](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a4e4cad37fb9742ab43c03a1c897c2e69) () |
| void | [SetEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a71e0f9570275a903e70677f952e208df) (bool isParentObject=false) |
|  | Enables the mission object script and adds it to active mission objects. |
| void | [SetEnabledAndMakeVisible](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#ac49392483340a58efd0348abc690fbed) (bool isParentObject=false, bool enableFaces=false) |
|  | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) object is enabled and added to active mission objects list, its entity is made visible and therefore its physics is turned on. |
| void | [SetDisabled](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a628c7044cb17819d62166341a4153b55) (bool isParentObject=false) |
|  | Only disables the mission object script and removes it from active mission objects list but the object entity remains visible with active physics. |
| void | [SetDisabledAndMakeInvisible](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a617290738365d2ff7e1423b194d08d34) (bool isParentObject=false, bool disableFaces=false) |
|  | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) object is disabled and removed from active mission objects list, its entity is made invisible and therefore its physics is turned off. |
| virtual void | [OnEndMission](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#af152bc8075fde480466449956ac0db4c) () |
| virtual void | [AddStuckMissile](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a0173366e9a2f20a2b9bb83939c3f4d2d) ([GameEntity](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0a02cc65cc567db6101ea4afa275ff36) missileEntity) |
| Public Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [SetScriptComponentToTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ae15c963749bd0f9a75bba24a333b39d4) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) tickReq) |
| void | [SetScriptComponentToTickMT](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a9b2183852eb7b70042ed82ef917022c6) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) value) |

|  |  |
| --- | --- |
| Public Attributes | |
| int | [ManagedNavigationFaceId](class_tale_worlds_1_1_mount_and_blade_1_1_ladder_queue_manager.html#a96e20094c04690e39f09ea60f234a870) |
| int | [ManagedNavigationFaceAlternateID1](class_tale_worlds_1_1_mount_and_blade_1_1_ladder_queue_manager.html#a652d391c08ee7b03019a0f41bd2e100e) |
| int | [ManagedNavigationFaceAlternateID2](class_tale_worlds_1_1_mount_and_blade_1_1_ladder_queue_manager.html#a242b7f2db35c9e6929bfd60df69dd376) |
| float | [CostAddition](class_tale_worlds_1_1_mount_and_blade_1_1_ladder_queue_manager.html#a69910d94e5d2eec839c728946ec68173) |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsDeactivated](class_tale_worlds_1_1_mount_and_blade_1_1_ladder_queue_manager.html#a8a4de37ee4e68be06b1b616119633b48) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | |
| [MissionObjectId](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_object_id.html) | [Id](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a6fbaa061b2ba0b6d0ad628a95f2f15ab) `[get, set]` |
| bool | [IsDisabled](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a53552a096fb534b9ea90ae1527b19cf4) `[get]` |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [HitObjectName](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a157e8b8a578e378ca91fb22639741ab3) `[get]` |
| bool | [CreatedAtRuntime](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a4d626d05a65d1a028bd791bbeba1f723) `[get]` |
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
| Static Public Attributes inherited from [TaleWorlds.MountAndBlade.MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | |
| const int | [MaxNavMeshPerDynamicObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#ad33e7f4aeb39643c81e3f22ae208d9e1) = 50 |
| Protected Types inherited from [TaleWorlds.MountAndBlade.MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | |
| enum | [DynamicNavmeshLocalIds](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90b) : int {     [Inside](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90ba9b6d3000134648fc9f1e71094ae0847d) = 1 ,     [Enter](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90baf1851d5600eae616ee802a31ac74701b) = 2 ,     [Exit](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90bafef46e5063ce3dc78b8ae64fa474241d) = 3 ,     [Blocker](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90bada32a1684e943a766fec67b13009be79) = 4 ,     [Extra1](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90ba113f84d105af2b8016b3896117c9deab) = 5 ,     [Extra2](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90ba83dca46dd08ad782e968d586375715e1) = 6 ,     [Extra3](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90bab7f54183dc84b2982ebe161b9c59f2d9) = 7 ,     [Reserved1](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90ba93876cb309016fa725517b046474c44b) = 9 ,     [Count](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90bae93f994f01c537c4e2f7d8528c3eb5e9)   } |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | |
| virtual void | [AttachDynamicNavmeshToEntity](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a96b0e630894be6b18d6395ad12f811ac) () |
| virtual [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | [GetEntityToAttachNavMeshFaces](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a91b69e394d98f64d45604ee179496bb3) () |
| override void | [OnRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a67f885c862847e8c64853294b822cb3f) (int removeReason) |
| Protected Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [InvalidateWeakPointersIfValid](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#af39d73d0c78790ba81a40a5a350c0526) () |
|  | [ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0bc136bb53989f2b9a4f23f12f54a332) () |
| Protected Attributes inherited from [TaleWorlds.MountAndBlade.MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | |
| string | [NavMeshPrefabName](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#afbbb7a7a9d7d3196e2166a3408c30d3e) = "" |
| int | [DynamicNavmeshIdStart](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a86be6f4e676cad159e82a8803daf8d1e) = 0 |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ladder_queue_manager.html#a97785c0e531f0dbba5596dd66bcc0b5d)DeactivateImmediate()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.LadderQueueManager.DeactivateImmediate | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ladder_queue_manager.html#ad8e1f2d80f0a20685e1a1e5dda167fcc)Deactivate()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.LadderQueueManager.Deactivate | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ladder_queue_manager.html#ae2d4206ad177cdca4ee970597310e1e3)Activate()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.LadderQueueManager.Activate | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ladder_queue_manager.html#a9260d55f4a8212870c55fb7a9999b980)Initialize()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.LadderQueueManager.Initialize | ( | int | *managedNavigationFaceId*, |
|  |  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *managedFrame*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *managedDirection*, |
|  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *managedSide*, |
|  |  | int | *maxUserCount*, |
|  |  | float | *arcAngle*, |
|  |  | float | *queueBeginDistance*, |
|  |  | float | *queueRowSize*, |
|  |  | float | *costPerRow*, |
|  |  | float | *baseCost*, |
|  |  | bool | *blockUsage*, |
|  |  | float | *agentSpacing*, |
|  |  | float | *zDifferenceToStopUsing*, |
|  |  | float | *distanceToStopUsing2d*, |
|  |  | bool | *doesManageMultipleIDs*, |
|  |  | int | *managedNavigationFaceAlternateID1*, |
|  |  | int | *managedNavigationFaceAlternateID2*, |
|  |  | int | *maxClimberCount*, |
|  |  | int | *maxRunnerCount* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ladder_queue_manager.html#a0906cdf96ec0559e11f879e8acc3cf37)GetTickRequirement()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) TaleWorlds.MountAndBlade.LadderQueueManager.GetTickRequirement | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ac17100a83d592505ed8d9ac565e512a5).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ladder_queue_manager.html#a14f3858ccfb2524c689b98c599d007de)FlushQueueManager()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.LadderQueueManager.FlushQueueManager | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ladder_queue_manager.html#a03a0a82d971a1de52c4ee948958159fb)AssignNeighborQueueManager()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.LadderQueueManager.AssignNeighborQueueManager | ( | [LadderQueueManager](class_tale_worlds_1_1_mount_and_blade_1_1_ladder_queue_manager.html) | *neighborLadderQueueManager* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ladder_queue_manager.html#a1d0e17fc742787959a83e2e5d5ab3b1d)OnFormationFrameChanged()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.LadderQueueManager.OnFormationFrameChanged | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | bool | *hasFrame*, |
|  |  | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *frame* ) |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ladder_queue_manager.html#a96e20094c04690e39f09ea60f234a870)ManagedNavigationFaceId
---------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.LadderQueueManager.ManagedNavigationFaceId |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ladder_queue_manager.html#a652d391c08ee7b03019a0f41bd2e100e)ManagedNavigationFaceAlternateID1
-------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.LadderQueueManager.ManagedNavigationFaceAlternateID1 |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ladder_queue_manager.html#a242b7f2db35c9e6929bfd60df69dd376)ManagedNavigationFaceAlternateID2
-------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.LadderQueueManager.ManagedNavigationFaceAlternateID2 |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ladder_queue_manager.html#a69910d94e5d2eec839c728946ec68173)CostAddition
----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.LadderQueueManager.CostAddition |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ladder_queue_manager.html#a8a4de37ee4e68be06b1b616119633b48)IsDeactivated
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.LadderQueueManager.IsDeactivated | | get |

