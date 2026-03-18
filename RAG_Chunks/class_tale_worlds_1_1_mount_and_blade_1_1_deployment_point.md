--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html ---

TaleWorlds.MountAndBlade.DeploymentPoint Class ReferenceInherits [TaleWorlds.MountAndBlade.SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [DeploymentPointType](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a76d1a5f569e81add70aa8b7d113c7900) {     [BatteringRam](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a76d1a5f569e81add70aa8b7d113c7900a1ef64d25343f01be1317e02d23387b7f) ,     [TowerLadder](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a76d1a5f569e81add70aa8b7d113c7900a8cfc265bd6749ebfead397c3f0b6f32c) ,     [Breach](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a76d1a5f569e81add70aa8b7d113c7900acbb8040f65bb73151d0530a8a6e110e1) ,     [Ranged](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a76d1a5f569e81add70aa8b7d113c7900ac2f329a17c18a701dbe1e96e03858728)   } |
| enum | [DeploymentPointState](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a280811520990ba8ab1c9c8d09bfd62d2) {     [NotDeployed](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a280811520990ba8ab1c9c8d09bfd62d2a7478f1aeeb3236ed65366e2bf42ee20f) ,     [BatteringRam](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a280811520990ba8ab1c9c8d09bfd62d2a1ef64d25343f01be1317e02d23387b7f) ,     [SiegeLadder](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a280811520990ba8ab1c9c8d09bfd62d2aecaa659f71a5ac32ded5055c2298266f) ,     [SiegeTower](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a280811520990ba8ab1c9c8d09bfd62d2aefc2d870cd2ff8553592c376513e26d4) ,     [Breach](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a280811520990ba8ab1c9c8d09bfd62d2acbb8040f65bb73151d0530a8a6e110e1) ,     [Ranged](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a280811520990ba8ab1c9c8d09bfd62d2ac2f329a17c18a701dbe1e96e03858728)   } |
| Public Types inherited from [TaleWorlds.MountAndBlade.SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html) | |
| enum | [SynchFlags](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5ca) : uint {     [SynchNone](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5caa2da4e8e99f2913602376d36f8089a315) = 0x00000000 ,     [SynchTransform](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5caaa2b2f6339ae0b34de079c6d36495701a) = 0x00000001 ,     [SynchAnimation](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5caa896890ac2c4ab8db6aa3d8aa54201e2f) = 0x00000002 ,     [SynchBodyFlags](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5caabe8d4d441f6ffd28e6c51f8f3c7be862) = 0x00000004 ,     [SyncColors](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5caa10774fbeeb25df50516d9b754652622a) = 0x00000008 ,     [SynchAll](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5caa86cdc154b35c72e83e8b91718295bd3a) = 0xffffffff   } |
| Public Types inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| enum | [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) : uint {     [None](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da6adf97f83acf6453d4a6a4b1070f3754) = 0x00000000 ,     [TickOccasionally](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da9cee052f50afabfc1098c1aa6af80b75) = 0x00000001 ,     [Tick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0b3516a5bbb77566f904f9d3877f4710) = 0x00000002 ,     [TickParallel](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da5f5a8f4b9ce783164665db4d70e03ee3) = 0x00000004 ,     [TickParallel2](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0ea9f0c260cdfd8b20ce19a48dbc329f) = 0x00000008 ,     [FixedTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154dadd067942f0b8cc66859698bc9711ba15) = 0x00000010 ,     [FixedParallelTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daa226d712a5ffd8d400f850393ff68492) = 0x00000020 ,     [TickParallel3](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daf785c2c005d708ea434168efc10611b8) = 0x00000040   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [AfterMissionStart](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a0fb7eaefa9162b5c258b178c6f54dd58) () |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetDeploymentOrigin](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#ae958d55502823c51e6b58c8329c03dbc) () |
| [DeploymentPointState](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a280811520990ba8ab1c9c8d09bfd62d2) | [GetDeploymentPointState](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a2871c76a276dbd9a7c80b2cec8dae2ba) () |
| [DeploymentPointType](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a76d1a5f569e81add70aa8b7d113c7900) | [GetDeploymentPointType](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a7c0ea72e453adab2151d8828cec58872) () |
| List< [SiegeLadder](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html) > | [GetAssociatedSiegeLadders](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#abf36105f59a2ec7b6a2e9cdbe15b3e20) () |
| MBList< [SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html) > | [GetWeaponsUnder](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a8b585b67ea77a4f81c4368ff2adcebb2) () |
| IEnumerable< [SpawnerBase](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html) > | [GetSpawnersForEditor](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a96a2a74d21243f152cc43481439d1625) () |
| void | [Deploy](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a335554a878cd61971a803394378bb010) (Type t) |
| void | [Deploy](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#ae91c65406d437c51573408da878e4d0e) ([SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html) s) |
| [ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0bc136bb53989f2b9a4f23f12f54a332) | [Disband](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a9f0ca2edb0db109e56495b53aa3555d3) () |
| void | [Hide](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#af6b5ca883ee7b8e4546cfc95389558e1) () |
| void | [Show](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#aae8935da798492da28eaf4013bdf04f1) () |
| void | [ToggleWeaponVisibility](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a7c11ba8159b09bb40c17ad4158737d30) (bool visible, [SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html) weapon) |
| void | [HideAllWeapons](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#ae52715690a7abd6a671959e42c1e2e91) () |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html) | |
| override [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) | [GetTickRequirement](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a4ac82f3267a7b398201cb1f30ee9a37f) () |
| void | [SetLocalPositionSmoothStep](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#ac3d9c08322fdc346100bca4e4762762b) (ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) targetPosition) |
| virtual void | [SetVisibleSynched](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#adfd7b558f73221bc0026ae3537f20f87) (bool value, bool forceChildrenVisible=false) |
| virtual void | [SetPhysicsStateSynched](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a4c5c4d8e7bfcf7c1060df3b71eb690b0) (bool value, bool setChildren=true) |
| virtual void | [SetDisabledSynched](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#ae09410bb02fc8fc88fc102e8be966e0a) () |
| void | [SetFrameSynched](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a007c85e9032d6abeae67664b7041aa3b) (ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame, bool isClient=false) |
| void | [SetGlobalFrameSynched](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a807953d5b1169590b4210911e44f7a72) (ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame, bool isClient=false) |
| void | [SetFrameSynchedOverTime](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a3329b617636e9f59126e646e53428ea7) (ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame, float duration, bool isClient=false) |
| void | [SetGlobalFrameSynchedOverTime](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a3b351de7c8809172349afdbdcb4816ec) (ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame, float duration, bool isClient=false) |
| void | [SetAnimationAtChannelSynched](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#aec216ecb7efe2ffb6c35ab8cbcb7145f) (string animationName, int channelNo, float animationSpeed=1.0f) |
| void | [SetAnimationAtChannelSynched](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a4a52e17030a4c85e0c227455992fd86b) (int animationIndex, int channelNo, float animationSpeed=1.0f) |
| void | [SetAnimationChannelParameterSynched](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a9346db672221f04ae2e302f127a8deb0) (int channelNo, float parameter) |
| void | [PauseSkeletonAnimationSynched](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a0bf8bc896100e854a4d0d2ec805925cd) () |
| void | [ResumeSkeletonAnimationSynched](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a039bcbc75df8020e8da1ffe72c763eeb) () |
| void | [BurstParticlesSynched](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a2aced2f1c98005c8c6417beced585997) (bool doChildren=true) |
| void | [ApplyImpulseSynched](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#acb2120f6447949d574486f92f0c9a055) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) localPosition, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) impulse) |
| void | [AddBodyFlagsSynched](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a7be570332d3835a27b36c512b7ec652e) ([BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) flags, bool applyToChildren=true) |
| void | [RemoveBodyFlagsSynched](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a3c28a2be85209207acd98fe70eea5dbb) ([BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) flags, bool applyToChildren=true) |
| void | [SetTeamColors](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a4e57328ba7581176377d8705804d0229) (uint color, uint color2) |
| virtual void | [SetTeamColorsSynched](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#aa12c5772def937a161a7859471ef4bae) (uint color, uint color2) |
| virtual void | [WriteToNetwork](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#ae2659d0b019f69ee37de2d69beb032ce) () |
| virtual void | [OnAfterReadFromNetwork](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a4709dc8d1a0b3228df3c8e630e40a58a) (([BaseSynchedMissionObjectReadableRecord](struct_tale_worlds_1_1_mount_and_blade_1_1_base_synched_mission_object_readable_record.html), [ISynchedMissionObjectReadableRecord](interface_tale_worlds_1_1_mount_and_blade_1_1_i_synched_mission_object_readable_record.html)) synchedMissionObjectReadableRecord, bool allowVisibilityUpdate=true) |
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

|  |  |
| --- | --- |
| Public Attributes | |
| [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | [Side](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#aebde52fdf492874e0e6290d3ad3c2aeb) = BattleSideEnum.Attacker |
| float | [Radius](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a11db6e54dd5a5cd3786a186e4eefdf44) = 3f |
| string | [SiegeWeaponTag](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a8de4a37c82bee916e2872aa7c11b85de) = "dpWeapon" |

|  |  |
| --- | --- |
| Properties | |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [DeploymentTargetPosition](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#af6fab60df28e73a0687f86915e1b9d1c) `[get]` |
| [WallSegment](class_tale_worlds_1_1_mount_and_blade_1_1_wall_segment.html) | [AssociatedWallSegment](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#af6a0815628fd9a2faf8d8ef08cc60f19) `[get]` |
| IEnumerable< [SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html) > | [DeployableWeapons](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#adbb5b245918a7f6341560e7a53a1e3ba) `[get]` |
| bool | [IsDeployed](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a3c92743cf99b1e41cdd33d683f7fde8f) `[get]` |
| [SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html) | [DeployedWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a7dfa2b3745981bdb26f6ba2c0dd710ad) `[get]` |
| [SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html) | [DisbandedWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#aa9cc181ef8391a42364ea2406706e223) `[get]` |
| IEnumerable< Type > | [DeployableWeaponTypes](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#ab6d12e13afdd3f37c49f5ab0783d0e77) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html) | |
| uint | [Color](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a832ccf9e2bf604c00868fa3b15db3e55) `[get]` |
| uint | [Color2](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#ada43d051ea21ec2ed928b2850a28d1fe) `[get]` |
| bool | [SynchronizeCompleted](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a1db8c6d3c11f75a0a1ef610ad5bc0e71) `[get]` |
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
| Events | |
| Action< [DeploymentPoint](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html), [SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html) > | [OnDeploymentStateChanged](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#adc0a0b1eb2dd0ea5e53c9a75d43df285) |
| Action< [DeploymentPoint](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html) > | [OnDeploymentPointTypeDetermined](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a672a25fd367f445cf370b7930b02f4fd) |

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

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a76d1a5f569e81add70aa8b7d113c7900)DeploymentPointType
-------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.DeploymentPoint.DeploymentPointType](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a76d1a5f569e81add70aa8b7d113c7900) |

| Enumerator | |
| --- | --- |
| BatteringRam |  |
| TowerLadder |  |
| Breach |  |
| Ranged |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a280811520990ba8ab1c9c8d09bfd62d2)DeploymentPointState
--------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.DeploymentPoint.DeploymentPointState](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a280811520990ba8ab1c9c8d09bfd62d2) |

| Enumerator | |
| --- | --- |
| NotDeployed |  |
| BatteringRam |  |
| SiegeLadder |  |
| SiegeTower |  |
| Breach |  |
| Ranged |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a0fb7eaefa9162b5c258b178c6f54dd58)AfterMissionStart()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.DeploymentPoint.AfterMissionStart | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a925fa787ae9b9a2ec414c9b575156fc1).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#ae958d55502823c51e6b58c8329c03dbc)GetDeploymentOrigin()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.DeploymentPoint.GetDeploymentOrigin | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a2871c76a276dbd9a7c80b2cec8dae2ba)GetDeploymentPointState()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [DeploymentPointState](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a280811520990ba8ab1c9c8d09bfd62d2) TaleWorlds.MountAndBlade.DeploymentPoint.GetDeploymentPointState | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a7c0ea72e453adab2151d8828cec58872)GetDeploymentPointType()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [DeploymentPointType](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a76d1a5f569e81add70aa8b7d113c7900) TaleWorlds.MountAndBlade.DeploymentPoint.GetDeploymentPointType | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#abf36105f59a2ec7b6a2e9cdbe15b3e20)GetAssociatedSiegeLadders()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| List< [SiegeLadder](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html) > TaleWorlds.MountAndBlade.DeploymentPoint.GetAssociatedSiegeLadders | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a8b585b67ea77a4f81c4368ff2adcebb2)GetWeaponsUnder()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| MBList< [SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html) > TaleWorlds.MountAndBlade.DeploymentPoint.GetWeaponsUnder | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a96a2a74d21243f152cc43481439d1625)GetSpawnersForEditor()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< [SpawnerBase](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html) > TaleWorlds.MountAndBlade.DeploymentPoint.GetSpawnersForEditor | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a335554a878cd61971a803394378bb010)Deploy() [1/2]
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DeploymentPoint.Deploy | ( | Type | *t* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#ae91c65406d437c51573408da878e4d0e)Deploy() [2/2]
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DeploymentPoint.Deploy | ( | [SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html) | *s* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a9f0ca2edb0db109e56495b53aa3555d3)Disband()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0bc136bb53989f2b9a4f23f12f54a332) TaleWorlds.MountAndBlade.DeploymentPoint.Disband | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#af6b5ca883ee7b8e4546cfc95389558e1)Hide()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DeploymentPoint.Hide | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#aae8935da798492da28eaf4013bdf04f1)Show()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DeploymentPoint.Show | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a7c11ba8159b09bb40c17ad4158737d30)ToggleWeaponVisibility()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DeploymentPoint.ToggleWeaponVisibility | ( | bool | *visible*, |
|  |  | [SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html) | *weapon* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#ae52715690a7abd6a671959e42c1e2e91)HideAllWeapons()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DeploymentPoint.HideAllWeapons | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#aebde52fdf492874e0e6290d3ad3c2aeb)Side
----------------------------------------------------------------------------------------------------------

|  |
| --- |
| [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) TaleWorlds.MountAndBlade.DeploymentPoint.Side = BattleSideEnum.Attacker |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a11db6e54dd5a5cd3786a186e4eefdf44)Radius
------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.DeploymentPoint.Radius = 3f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a8de4a37c82bee916e2872aa7c11b85de)SiegeWeaponTag
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.DeploymentPoint.SiegeWeaponTag = "dpWeapon" |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#af6fab60df28e73a0687f86915e1b9d1c)DeploymentTargetPosition
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.DeploymentPoint.DeploymentTargetPosition | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#af6a0815628fd9a2faf8d8ef08cc60f19)AssociatedWallSegment
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [WallSegment](class_tale_worlds_1_1_mount_and_blade_1_1_wall_segment.html) TaleWorlds.MountAndBlade.DeploymentPoint.AssociatedWallSegment | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#adbb5b245918a7f6341560e7a53a1e3ba)DeployableWeapons
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IEnumerable<[SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html)> TaleWorlds.MountAndBlade.DeploymentPoint.DeployableWeapons | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a3c92743cf99b1e41cdd33d683f7fde8f)IsDeployed
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.DeploymentPoint.IsDeployed | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a7dfa2b3745981bdb26f6ba2c0dd710ad)DeployedWeapon
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html) TaleWorlds.MountAndBlade.DeploymentPoint.DeployedWeapon | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#aa9cc181ef8391a42364ea2406706e223)DisbandedWeapon
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html) TaleWorlds.MountAndBlade.DeploymentPoint.DisbandedWeapon | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#ab6d12e13afdd3f37c49f5ab0783d0e77)DeployableWeaponTypes
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IEnumerable<Type> TaleWorlds.MountAndBlade.DeploymentPoint.DeployableWeaponTypes | | get |

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#adc0a0b1eb2dd0ea5e53c9a75d43df285)OnDeploymentStateChanged
------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[DeploymentPoint](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html), [SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html)> TaleWorlds.MountAndBlade.DeploymentPoint.OnDeploymentStateChanged |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html#a672a25fd367f445cf370b7930b02f4fd)OnDeploymentPointTypeDetermined
-------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[DeploymentPoint](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html)> TaleWorlds.MountAndBlade.DeploymentPoint.OnDeploymentPointTypeDetermined |

