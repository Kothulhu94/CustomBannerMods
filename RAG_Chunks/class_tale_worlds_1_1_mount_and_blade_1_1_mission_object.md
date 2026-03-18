--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html ---

TaleWorlds.MountAndBlade.MissionObject Class ReferenceabstractInherits [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

Inherited by [SandBox.Objects.DynamicPatrolAreaParent](class_sand_box_1_1_objects_1_1_dynamic_patrol_area_parent.html), [TaleWorlds.MountAndBlade.Bird](class_tale_worlds_1_1_mount_and_blade_1_1_bird.html), [TaleWorlds.MountAndBlade.DestructableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_mission_object.html), [TaleWorlds.MountAndBlade.DestructedPrefabInfoMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_destructed_prefab_info_mission_object.html), [TaleWorlds.MountAndBlade.LadderQueueManager](class_tale_worlds_1_1_mount_and_blade_1_1_ladder_queue_manager.html), [TaleWorlds.MountAndBlade.Objects.AreaMarker](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_area_marker.html), [TaleWorlds.MountAndBlade.StrategicArea](class_tale_worlds_1_1_mount_and_blade_1_1_strategic_area.html), [TaleWorlds.MountAndBlade.SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html), [TaleWorlds.MountAndBlade.TacticalPosition](class_tale_worlds_1_1_mount_and_blade_1_1_tactical_position.html), [TaleWorlds.MountAndBlade.TacticalRegion](class_tale_worlds_1_1_mount_and_blade_1_1_tactical_region.html), [TaleWorlds.MountAndBlade.TutorialArea](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html), and [TaleWorlds.MountAndBlade.VolumeBox](class_tale_worlds_1_1_mount_and_blade_1_1_volume_box.html).

|  |  |
| --- | --- |
| Public Member Functions | |
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
| virtual [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) | [GetTickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ac17100a83d592505ed8d9ac565e512a5) () |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const int | [MaxNavMeshPerDynamicObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#ad33e7f4aeb39643c81e3f22ae208d9e1) = 50 |

|  |  |
| --- | --- |
| Protected Types | |
| enum | [DynamicNavmeshLocalIds](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90b) : int {     [Inside](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90ba9b6d3000134648fc9f1e71094ae0847d) = 1 ,     [Enter](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90baf1851d5600eae616ee802a31ac74701b) = 2 ,     [Exit](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90bafef46e5063ce3dc78b8ae64fa474241d) = 3 ,     [Blocker](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90bada32a1684e943a766fec67b13009be79) = 4 ,     [Extra1](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90ba113f84d105af2b8016b3896117c9deab) = 5 ,     [Extra2](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90ba83dca46dd08ad782e968d586375715e1) = 6 ,     [Extra3](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90bab7f54183dc84b2982ebe161b9c59f2d9) = 7 ,     [Reserved1](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90ba93876cb309016fa725517b046474c44b) = 9 ,     [Count](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90bae93f994f01c537c4e2f7d8528c3eb5e9)   } |

|  |  |
| --- | --- |
| Protected Member Functions | |
| virtual void | [AttachDynamicNavmeshToEntity](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a96b0e630894be6b18d6395ad12f811ac) () |
| virtual [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | [GetEntityToAttachNavMeshFaces](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a91b69e394d98f64d45604ee179496bb3) () |
| override void | [OnRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a67f885c862847e8c64853294b822cb3f) (int removeReason) |
| Protected Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [InvalidateWeakPointersIfValid](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#af39d73d0c78790ba81a40a5a350c0526) () |
|  | [ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0bc136bb53989f2b9a4f23f12f54a332) () |

|  |  |
| --- | --- |
| Protected Attributes | |
| string | [NavMeshPrefabName](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#afbbb7a7a9d7d3196e2166a3408c30d3e) = "" |
| int | [DynamicNavmeshIdStart](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a86be6f4e676cad159e82a8803daf8d1e) = 0 |

|  |  |
| --- | --- |
| Properties | |
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

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90b)DynamicNavmeshLocalIds
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | enum [TaleWorlds.MountAndBlade.MissionObject.DynamicNavmeshLocalIds](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90b) : int | | protected |

| Enumerator | |
| --- | --- |
| Inside |  |
| Enter |  |
| Exit |  |
| Blocker |  |
| Extra1 |  |
| Extra2 |  |
| Extra3 |  |
| Reserved1 |  |
| Count |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a4eaa53f5b1c5e3af4d4189e099c8e05e)MissionObject()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.MissionObject.MissionObject | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#ad02ae6fa04bfdc79f9fcd010afbff84e)SetAbilityOfFaces()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MissionObject.SetAbilityOfFaces | ( | bool | *enabled* | ) |  | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.SiegeLadder](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a4876f4c44728a4d2297918cb6442540c), and [TaleWorlds.MountAndBlade.SiegeTower](class_tale_worlds_1_1_mount_and_blade_1_1_siege_tower.html#aa66a208efa63f366d34becb84b72c0d3).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a96b0e630894be6b18d6395ad12f811ac)AttachDynamicNavmeshToEntity()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MissionObject.AttachDynamicNavmeshToEntity | ( |  | ) |  | | protectedvirtual |

Reimplemented in [TaleWorlds.MountAndBlade.SiegeTower](class_tale_worlds_1_1_mount_and_blade_1_1_siege_tower.html#a696b6490899f710ec9147d6dc889422a).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a91b69e394d98f64d45604ee179496bb3)GetEntityToAttachNavMeshFaces()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) TaleWorlds.MountAndBlade.MissionObject.GetEntityToAttachNavMeshFaces | ( |  | ) |  | | protectedvirtual |

Reimplemented in [TaleWorlds.MountAndBlade.RangedSiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#ac77f4bfadc1a673370e3af9f6f83e931), and [TaleWorlds.MountAndBlade.SiegeTower](class_tale_worlds_1_1_mount_and_blade_1_1_siege_tower.html#af1a6ef0ce29d50f1387cab973d6fe481).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a41ecc2ecbc888f99ca3b942d63503381)GetHashCode()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.MountAndBlade.MissionObject.GetHashCode | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a925fa787ae9b9a2ec414c9b575156fc1)AfterMissionStart()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MissionObject.AfterMissionStart | ( |  | ) |  | | virtual |

Reimplemented in [SandBox.Objects.AnimationPoints.AnimationPoint](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#aded015ca936e0470df140b39681960b3), [SandBox.Objects.AreaMarkers.StealthAreaMarker](class_sand_box_1_1_objects_1_1_area_markers_1_1_stealth_area_marker.html#a7fa9a6903b694fc0ec4a468f9f3b22e2), [SandBox.Objects.CheckpointArea](class_sand_box_1_1_objects_1_1_checkpoint_area.html#ad851ffac990445417ff5ce6151dab80e), [SandBox.Objects.PassageUsePoint](class_sand_box_1_1_objects_1_1_passage_use_point.html#a944d0b45649bc198a7eeac7756c2ea07), [SandBox.Objects.Usables.CheckpointUsePoint](class_sand_box_1_1_objects_1_1_usables_1_1_checkpoint_use_point.html#ae172646b32085c7345320a765262cc77), [TaleWorlds.MountAndBlade.CastleGate](class_tale_worlds_1_1_mount_and_blade_1_1_castle_gate.html#aff4048832b6a6370a7fbe4b2d44cdf2f), [TaleWorlds.MountAndBlade.DeploymentPoint](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a0fb7eaefa9162b5c258b178c6f54dd58), [TaleWorlds.MountAndBlade.StonePile](class_tale_worlds_1_1_mount_and_blade_1_1_stone_pile.html#aa6eee710cdda17c99502bab94c965c5c), [TaleWorlds.MountAndBlade.TacticalPosition](class_tale_worlds_1_1_mount_and_blade_1_1_tactical_position.html#a5845c42030e102ced518982dcab44ba0), [TaleWorlds.MountAndBlade.TacticalRegion](class_tale_worlds_1_1_mount_and_blade_1_1_tactical_region.html#a4cacc8120aeb13d741670ff772561888), [TaleWorlds.MountAndBlade.Trebuchet](class_tale_worlds_1_1_mount_and_blade_1_1_trebuchet.html#ae6bece11de7685d6c5d8714719d91633), and [TaleWorlds.MountAndBlade.TutorialArea](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#aedcf6ab14c8d3e3981dcc49cce15785c).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#aa903cd7aefee1178f7e0700031f6cbd3)OnMissionEnded()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MissionObject.OnMissionEnded | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a6cc35c8b9bbd3bccb6cec5471adff0d3).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a4e4cad37fb9742ab43c03a1c897c2e69)OnDeploymentFinished()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MissionObject.OnDeploymentFinished | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.Objects.Usables.AmmoBarrelBase](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_usables_1_1_ammo_barrel_base.html#aa88b1a28a7469d6b82c48c22488016af), and [TaleWorlds.MountAndBlade.Objects.Usables.ClimbingMachine](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_usables_1_1_climbing_machine.html#acadcf3687caa0ae2804ffa3b20b9dd06).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a71e0f9570275a903e70677f952e208df)SetEnabled()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionObject.SetEnabled | ( | bool | *isParentObject* = false | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | isParentObject | If set also recursively traverses all children mission objects and enables them as well |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#ac49392483340a58efd0348abc690fbed)SetEnabledAndMakeVisible()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionObject.SetEnabledAndMakeVisible | ( | bool | *isParentObject* = false, |
|  |  | bool | *enableFaces* = false ) |

Parameters
:   |  |  |
    | --- | --- |
    | isParentObject |  |
    | enableFaces |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a628c7044cb17819d62166341a4153b55)SetDisabled()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionObject.SetDisabled | ( | bool | *isParentObject* = false | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | isParentObject | If set also recursively traverses all children mission objects and disables them as well |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a617290738365d2ff7e1423b194d08d34)SetDisabledAndMakeInvisible()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionObject.SetDisabledAndMakeInvisible | ( | bool | *isParentObject* = false, |
|  |  | bool | *disableFaces* = false ) |

Parameters
:   |  |  |
    | --- | --- |
    | isParentObject |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a67f885c862847e8c64853294b822cb3f)OnRemoved()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MissionObject.OnRemoved | ( | int | *removeReason* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a4778f913080fc216866daa15518c8ecd).

Reimplemented in [TaleWorlds.MountAndBlade.SiegeTower](class_tale_worlds_1_1_mount_and_blade_1_1_siege_tower.html#a15c7ef60e80e59ee071ac391c20aae3c), [TaleWorlds.MountAndBlade.SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html#a08b88a59b20053ba9d50ed17379d4c75), [TaleWorlds.MountAndBlade.StrategicArea](class_tale_worlds_1_1_mount_and_blade_1_1_strategic_area.html#a1de78d0aefa4a4771f51cbb15c99be2e), [TaleWorlds.MountAndBlade.UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#abc7226debc7d7f91ee2db48317dd9ca7), [TaleWorlds.MountAndBlade.UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#a4f1f6f103fd69340341f510b1113b215), and [TaleWorlds.MountAndBlade.VertexAnimator](class_tale_worlds_1_1_mount_and_blade_1_1_vertex_animator.html#aa1ddc13658a5da67cf7d84df8ac89782).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#af152bc8075fde480466449956ac0db4c)OnEndMission()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MissionObject.OnEndMission | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html#a99bf2fcb5563e7f9ae0d1483d2cf712b), and [TaleWorlds.MountAndBlade.UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#aceeacd54ae263afd796366d18e0b4f94).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a0173366e9a2f20a2b9bb83939c3f4d2d)AddStuckMissile()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MissionObject.AddStuckMissile | ( | [GameEntity](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0a02cc65cc567db6101ea4afa275ff36) | *missileEntity* | ) |  | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.DestructableComponent](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#aaa5e19f57dbdfe5baa1d96fd34b07848).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#ad33e7f4aeb39643c81e3f22ae208d9e1)MaxNavMeshPerDynamicObject
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.MountAndBlade.MissionObject.MaxNavMeshPerDynamicObject = 50 | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#afbbb7a7a9d7d3196e2166a3408c30d3e)NavMeshPrefabName
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.MissionObject.NavMeshPrefabName = "" | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a86be6f4e676cad159e82a8803daf8d1e)DynamicNavmeshIdStart
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.MissionObject.DynamicNavmeshIdStart = 0 | | protected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a6fbaa061b2ba0b6d0ad628a95f2f15ab)Id
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MissionObjectId](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_object_id.html) TaleWorlds.MountAndBlade.MissionObject.Id | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a53552a096fb534b9ea90ae1527b19cf4)IsDisabled
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.MissionObject.IsDisabled | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a157e8b8a578e378ca91fb22639741ab3)HitObjectName
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.MountAndBlade.MissionObject.HitObjectName | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a4d626d05a65d1a028bd791bbeba1f723)CreatedAtRuntime
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.MissionObject.CreatedAtRuntime | | get |

