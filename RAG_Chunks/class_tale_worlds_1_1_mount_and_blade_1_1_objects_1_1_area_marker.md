--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_area_marker.html ---

TaleWorlds.MountAndBlade.Objects.AreaMarker Class ReferenceInherits [TaleWorlds.MountAndBlade.MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html), and [TaleWorlds.Core.ITrackableBase](interface_tale_worlds_1_1_core_1_1_i_trackable_base.html).

Inherited by [SandBox.Objects.AreaMarkers.AnimatedBasicAreaIndicator](class_sand_box_1_1_objects_1_1_area_markers_1_1_animated_basic_area_indicator.html), [SandBox.Objects.AreaMarkers.BasicAreaIndicator](class_sand_box_1_1_objects_1_1_area_markers_1_1_basic_area_indicator.html), [SandBox.Objects.AreaMarkers.CommonAreaMarker](class_sand_box_1_1_objects_1_1_area_markers_1_1_common_area_marker.html), [SandBox.Objects.AreaMarkers.StealthAreaMarker](class_sand_box_1_1_objects_1_1_area_markers_1_1_stealth_area_marker.html), [SandBox.Objects.AreaMarkers.WorkshopAreaMarker](class_sand_box_1_1_objects_1_1_area_markers_1_1_workshop_area_marker.html), and [TaleWorlds.MountAndBlade.Objects.FightAreaMarker](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_fight_area_marker.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| bool | [IsPositionInRange](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_area_marker.html#a5e1c3c8bc2b35127ff4263a7fd11d534) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position) |
| virtual List< [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) > | [GetUsableMachinesInRange](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_area_marker.html#a8687efe32533118893d36496d81070a5) (string excludeTag=null) |
| virtual List< [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) > | [GetUsableMachinesWithTagInRange](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_area_marker.html#a67b11ccec270c24a54863d814f7301b7) (string tag) |
| virtual List< [GameEntity](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0a02cc65cc567db6101ea4afa275ff36) > | [GetGameEntitiesWithTagInRange](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_area_marker.html#a92ce5830d0714330e4b54ba017dcdc8b) (string tag) |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetName](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_area_marker.html#affaa768dc3476abb1d979883d6ad6468) () |
| virtual [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetPosition](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_area_marker.html#a8f3ae01be2ca7346a7cb444f3499265c) () |
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
| virtual [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) | [GetTickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ac17100a83d592505ed8d9ac565e512a5) () |

|  |  |
| --- | --- |
| Public Attributes | |
| float | [AreaRadius](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_area_marker.html#ac3d900f9228a2e8621eb1c05d41ca425) = 3.0f |
| int | [AreaIndex](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_area_marker.html#a1e6a829e99a61fdbf6eb3b73ccfa44fb) = 0 |
| bool | [CheckToggle](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_area_marker.html#a8e55318238f2fc57e72683561421959f) |

|  |  |
| --- | --- |
| Properties | |
| virtual string | [Tag](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_area_marker.html#a87ee84ab483777dc09a5cea77eee9127) `[get]` |
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

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_area_marker.html#a5e1c3c8bc2b35127ff4263a7fd11d534)IsPositionInRange()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Objects.AreaMarker.IsPositionInRange | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_area_marker.html#a8687efe32533118893d36496d81070a5)GetUsableMachinesInRange()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual List< [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) > TaleWorlds.MountAndBlade.Objects.AreaMarker.GetUsableMachinesInRange | ( | string | *excludeTag* = null | ) |  | | virtual |

Reimplemented in [SandBox.Objects.AreaMarkers.CommonAreaMarker](class_sand_box_1_1_objects_1_1_area_markers_1_1_common_area_marker.html#ab5eadf44710a2d3ccf2eb5e5defd64bc).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_area_marker.html#a67b11ccec270c24a54863d814f7301b7)GetUsableMachinesWithTagInRange()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual List< [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) > TaleWorlds.MountAndBlade.Objects.AreaMarker.GetUsableMachinesWithTagInRange | ( | string | *tag* | ) |  | | virtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_area_marker.html#a92ce5830d0714330e4b54ba017dcdc8b)GetGameEntitiesWithTagInRange()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual List< [GameEntity](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0a02cc65cc567db6101ea4afa275ff36) > TaleWorlds.MountAndBlade.Objects.AreaMarker.GetGameEntitiesWithTagInRange | ( | string | *tag* | ) |  | | virtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_area_marker.html#affaa768dc3476abb1d979883d6ad6468)GetName()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.MountAndBlade.Objects.AreaMarker.GetName | ( |  | ) |  | | virtual |

Implements [TaleWorlds.Core.ITrackableBase](interface_tale_worlds_1_1_core_1_1_i_trackable_base.html#aff065375b1e966c654a2b6089da8b53e).

Reimplemented in [SandBox.Objects.AreaMarkers.AnimatedBasicAreaIndicator](class_sand_box_1_1_objects_1_1_area_markers_1_1_animated_basic_area_indicator.html#a1219f86dc6b2aafdeb41a8835b791554), [SandBox.Objects.AreaMarkers.BasicAreaIndicator](class_sand_box_1_1_objects_1_1_area_markers_1_1_basic_area_indicator.html#ab2c563a14e1e539b5d6ada76e54e242e), [SandBox.Objects.AreaMarkers.CommonAreaMarker](class_sand_box_1_1_objects_1_1_area_markers_1_1_common_area_marker.html#a089c7129df64dab8bb3b68cc06c97c07), and [SandBox.Objects.AreaMarkers.WorkshopAreaMarker](class_sand_box_1_1_objects_1_1_area_markers_1_1_workshop_area_marker.html#a851d5fef5912302a48f189f88e7182ca).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_area_marker.html#a8f3ae01be2ca7346a7cb444f3499265c)GetPosition()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.Objects.AreaMarker.GetPosition | ( |  | ) |  | | virtual |

Implements [TaleWorlds.Core.ITrackableBase](interface_tale_worlds_1_1_core_1_1_i_trackable_base.html#a2c1f3cba0651fa9caa3fb054640f9ea1).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_area_marker.html#ac3d900f9228a2e8621eb1c05d41ca425)AreaRadius
-----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.Objects.AreaMarker.AreaRadius = 3.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_area_marker.html#a1e6a829e99a61fdbf6eb3b73ccfa44fb)AreaIndex
----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.Objects.AreaMarker.AreaIndex = 0 |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_area_marker.html#a8e55318238f2fc57e72683561421959f)CheckToggle
------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.Objects.AreaMarker.CheckToggle |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_area_marker.html#a87ee84ab483777dc09a5cea77eee9127)Tag
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual string TaleWorlds.MountAndBlade.Objects.AreaMarker.Tag | | get |

