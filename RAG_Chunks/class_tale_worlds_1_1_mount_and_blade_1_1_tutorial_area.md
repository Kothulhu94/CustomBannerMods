--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html ---

TaleWorlds.MountAndBlade.TutorialArea Class ReferenceInherits [TaleWorlds.MountAndBlade.MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [TrainingType](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#a816694f172b8036b193969b288e8be07) {     [Bow](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#a816694f172b8036b193969b288e8be07a48fce5d02f6935e50f256d5dedac4437) ,     [Melee](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#a816694f172b8036b193969b288e8be07afcbd772e48c4b07d7d3be13b37a82f5e) ,     [Mounted](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#a816694f172b8036b193969b288e8be07aab4e7334a8f96cc4068b7de43e57b9e4) ,     [AdvancedMelee](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#a816694f172b8036b193969b288e8be07a6e4d1529f5f8a90ea5590d4bf77ca5f8)   } |
| Public Types inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| enum | [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) : uint {     [None](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da6adf97f83acf6453d4a6a4b1070f3754) = 0x00000000 ,     [TickOccasionally](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da9cee052f50afabfc1098c1aa6af80b75) = 0x00000001 ,     [Tick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0b3516a5bbb77566f904f9d3877f4710) = 0x00000002 ,     [TickParallel](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da5f5a8f4b9ce783164665db4d70e03ee3) = 0x00000004 ,     [TickParallel2](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0ea9f0c260cdfd8b20ce19a48dbc329f) = 0x00000008 ,     [FixedTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154dadd067942f0b8cc66859698bc9711ba15) = 0x00000010 ,     [FixedParallelTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daa226d712a5ffd8d400f850393ff68492) = 0x00000020 ,     [TickParallel3](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daf785c2c005d708ea434168efc10611b8) = 0x00000040   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [AfterMissionStart](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#aedcf6ab14c8d3e3981dcc49cce15785c) () |
| void | [MarkTrainingIcons](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#a5fa803325ac13e1a2ac9bff41bf9c196) (bool mark) |
| [TrainingIcon](class_tale_worlds_1_1_mount_and_blade_1_1_training_icon.html) | [GetActiveTrainingIcon](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#ab4e5d44ccfc57f0fc64f4f9ccf1ad50f) () |
| int | [GetIndexFromTag](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#aed659143323f442f73e77e64dbdf995d) (string tag) |
| List< string > | [GetSubTrainingTags](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#a748705c9b2d42c8650deeeb70f1f29a9) () |
| void | [ActivateTaggedWeapons](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#ada059d0475d0d151d1755d45233401b3) (int index) |
| void | [EquipWeaponsToPlayer](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#a49c48748522646e656685cb0c607a0e9) (int index) |
| void | [DeactivateAllWeapons](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#a216054f2f2a9a95cb190c8d4e656b243) (bool resetDestructibles) |
| void | [ActivateBoundaries](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#a6d68388c78a381ee3895217fc34522ad) () |
| void | [HideBoundaries](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#a1aaefb34f0483877086e73da3b823fc4) () |
| int | [GetBreakablesCount](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#ab4498aaab7b8dbd2d7f5dccac317225b) (int index) |
| void | [MakeDestructible](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#a1de09d71f930c470461ca9ee6b203280) (int index) |
| void | [MarkAllTargets](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#a4fef5760fcf504d39a15310ca24db4b4) (int index, bool mark) |
| void | [ResetMarkingTargetTimers](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#aabd8edcab03e4000bb657d8150173aae) (int index) |
| void | [MakeInDestructible](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#a8ed91a3ef97b6eba0c832bbe6ce22b83) (int index) |
| bool | [AllBreakablesAreBroken](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#a6839bb59e33893d31bb58db5cf5ad1d6) (int index) |
| int | [GetBrokenBreakableCount](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#a5979ed6b2a2edf599bf237f136a96362) (int index) |
| int | [GetUnbrokenBreakableCount](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#acec1fd95d96c39d819a3e0749ec5055e) (int index) |
| void | [ResetBreakables](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#a9818137c87a54a5668dff6b373a02bcc) (int index, bool makeIndestructible=true) |
| bool | [HasMainAgentPickedAll](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#af70cd9f72e5ccac96e4532d64c2230cc) (int index) |
| void | [CheckMainAgentEquipment](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#a376b5ef9eb225668887221c8b3ca3fb3) (int index) |
| void | [CheckWeapons](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#a5c6ea1b7021dffef3e75600a3ec61aec) (int index) |
| bool | [IsPositionInsideTutorialArea](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#ade70deccae1ed14eaf1eeacfc7281966) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position, out string[] volumeBoxTags) |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | |
|  | [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a4eaa53f5b1c5e3af4d4189e099c8e05e) () |
| virtual void | [SetAbilityOfFaces](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#ad02ae6fa04bfdc79f9fcd010afbff84e) (bool enabled) |
| override int | [GetHashCode](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a41ecc2ecbc888f99ca3b942d63503381) () |
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
| Properties | |
| MBReadOnlyList< [TrainingIcon](class_tale_worlds_1_1_mount_and_blade_1_1_training_icon.html) > | [TrainingIconsReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#ae376d5f9604cdd7cbb799c890931618c) `[get]` |
| [TrainingType](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#a816694f172b8036b193969b288e8be07) | [TypeOfTraining](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#a5363c905bf04695c71d1747730ab2716) `[get]` |
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

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#a816694f172b8036b193969b288e8be07)TrainingType
---------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.TutorialArea.TrainingType](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#a816694f172b8036b193969b288e8be07) |

| Enumerator | |
| --- | --- |
| Bow |  |
| Melee |  |
| Mounted |  |
| AdvancedMelee |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#aedcf6ab14c8d3e3981dcc49cce15785c)AfterMissionStart()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.TutorialArea.AfterMissionStart | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a925fa787ae9b9a2ec414c9b575156fc1).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#a5fa803325ac13e1a2ac9bff41bf9c196)MarkTrainingIcons()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.TutorialArea.MarkTrainingIcons | ( | bool | *mark* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#ab4e5d44ccfc57f0fc64f4f9ccf1ad50f)GetActiveTrainingIcon()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [TrainingIcon](class_tale_worlds_1_1_mount_and_blade_1_1_training_icon.html) TaleWorlds.MountAndBlade.TutorialArea.GetActiveTrainingIcon | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#aed659143323f442f73e77e64dbdf995d)GetIndexFromTag()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.TutorialArea.GetIndexFromTag | ( | string | *tag* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#a748705c9b2d42c8650deeeb70f1f29a9)GetSubTrainingTags()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| List< string > TaleWorlds.MountAndBlade.TutorialArea.GetSubTrainingTags | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#ada059d0475d0d151d1755d45233401b3)ActivateTaggedWeapons()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.TutorialArea.ActivateTaggedWeapons | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#a49c48748522646e656685cb0c607a0e9)EquipWeaponsToPlayer()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.TutorialArea.EquipWeaponsToPlayer | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#a216054f2f2a9a95cb190c8d4e656b243)DeactivateAllWeapons()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.TutorialArea.DeactivateAllWeapons | ( | bool | *resetDestructibles* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#a6d68388c78a381ee3895217fc34522ad)ActivateBoundaries()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.TutorialArea.ActivateBoundaries | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#a1aaefb34f0483877086e73da3b823fc4)HideBoundaries()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.TutorialArea.HideBoundaries | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#ab4498aaab7b8dbd2d7f5dccac317225b)GetBreakablesCount()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.TutorialArea.GetBreakablesCount | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#a1de09d71f930c470461ca9ee6b203280)MakeDestructible()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.TutorialArea.MakeDestructible | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#a4fef5760fcf504d39a15310ca24db4b4)MarkAllTargets()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.TutorialArea.MarkAllTargets | ( | int | *index*, |
|  |  | bool | *mark* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#aabd8edcab03e4000bb657d8150173aae)ResetMarkingTargetTimers()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.TutorialArea.ResetMarkingTargetTimers | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#a8ed91a3ef97b6eba0c832bbe6ce22b83)MakeInDestructible()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.TutorialArea.MakeInDestructible | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#a6839bb59e33893d31bb58db5cf5ad1d6)AllBreakablesAreBroken()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.TutorialArea.AllBreakablesAreBroken | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#a5979ed6b2a2edf599bf237f136a96362)GetBrokenBreakableCount()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.TutorialArea.GetBrokenBreakableCount | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#acec1fd95d96c39d819a3e0749ec5055e)GetUnbrokenBreakableCount()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.TutorialArea.GetUnbrokenBreakableCount | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#a9818137c87a54a5668dff6b373a02bcc)ResetBreakables()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.TutorialArea.ResetBreakables | ( | int | *index*, |
|  |  | bool | *makeIndestructible* = true ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#af70cd9f72e5ccac96e4532d64c2230cc)HasMainAgentPickedAll()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.TutorialArea.HasMainAgentPickedAll | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#a376b5ef9eb225668887221c8b3ca3fb3)CheckMainAgentEquipment()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.TutorialArea.CheckMainAgentEquipment | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#a5c6ea1b7021dffef3e75600a3ec61aec)CheckWeapons()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.TutorialArea.CheckWeapons | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#ade70deccae1ed14eaf1eeacfc7281966)IsPositionInsideTutorialArea()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.TutorialArea.IsPositionInsideTutorialArea | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position*, |
|  |  | out string[] | *volumeBoxTags* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#ae376d5f9604cdd7cbb799c890931618c)TrainingIconsReadOnly
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[TrainingIcon](class_tale_worlds_1_1_mount_and_blade_1_1_training_icon.html)> TaleWorlds.MountAndBlade.TutorialArea.TrainingIconsReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#a5363c905bf04695c71d1747730ab2716)TypeOfTraining
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TrainingType](class_tale_worlds_1_1_mount_and_blade_1_1_tutorial_area.html#a816694f172b8036b193969b288e8be07) TaleWorlds.MountAndBlade.TutorialArea.TypeOfTraining | | get |

