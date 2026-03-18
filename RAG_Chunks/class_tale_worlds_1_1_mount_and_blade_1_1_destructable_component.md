--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html ---

TaleWorlds.MountAndBlade.DestructableComponent Class ReferenceInherits [TaleWorlds.MountAndBlade.SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html), and [TaleWorlds.MountAndBlade.IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html).

|  |  |
| --- | --- |
| Classes | |
| struct | [DestructableComponentRecord](struct_tale_worlds_1_1_mount_and_blade_1_1_destructable_component_1_1_destructable_component_record.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
| delegate void | [OnHitTakenAndDestroyedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#ab5c30adb63ba678ed9d76ed606933889) ([DestructableComponent](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a5e9cc4a2f68ace3af9d4612ff3ef82e1) target, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) weapon, [ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0bc136bb53989f2b9a4f23f12f54a332) attackerScriptComponentBehavior, int inflictedDamage) |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | [GetOriginalState](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#af49a40eb4bca704818b1e0ab3f6309e5) ([WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) parent) |
| void | [Reset](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a77df4deea16d994592f3ce68d781e9bb) () |
| void | [TriggerOnHit](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#af791ba393f73fa83c47ac773a21e4066) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, int inflictedDamage, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) impactPosition, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) impactDirection, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) weapon, int affectorWeaponSlotOrMissileIndex, [ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0bc136bb53989f2b9a4f23f12f54a332) attackerScriptComponentBehavior) |
| void | [BurstHeavyHitParticles](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a79b8bdaf87e07847d9db5e077593f7f4) () |
| void | [SetDestructionLevel](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a21ebbcd2b4821f1f253a7fd62086eea0) (int state, int forcedId, float blowMagnitude, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) blowPosition, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) blowDirection, bool noEffects=false) |
| void | [PreDestroy](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a242bc1b9dba5b8f1b75a6a733a013313) () |
| override void | [WriteToNetwork](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a9fb3931a04e35ba172d7521abec863a0) () |
| override void | [AddStuckMissile](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#aaa5e19f57dbdfe5baa1d96fd34b07848) ([GameEntity](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0a02cc65cc567db6101ea4afa275ff36) missileEntity) |
| void | [OnFocusGain](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a4e3a16a4fc574cc51126620d8c6d21ed) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) userAgent) |
| void | [OnFocusLose](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a3f77c9d85204a2de32fa94d5adaf8bab) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) userAgent) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetInfoTextForBeingNotInteractable](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a0a0fb220200601a625ed4598592c4c33) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) userAgent) |
| override void | [OnAfterReadFromNetwork](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a060d0eb4614e18fd006455c94f909137) (([BaseSynchedMissionObjectReadableRecord](struct_tale_worlds_1_1_mount_and_blade_1_1_base_synched_mission_object_readable_record.html), [ISynchedMissionObjectReadableRecord](interface_tale_worlds_1_1_mount_and_blade_1_1_i_synched_mission_object_readable_record.html)) synchedMissionObjectReadableRecord, bool allowVisibilityUpdate=true) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetDescriptionText](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a4d154c8c827ddd2e51d67552e0a4b65e) ([WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity) |
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
| Public Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [SetScriptComponentToTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ae15c963749bd0f9a75bba24a333b39d4) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) tickReq) |
| void | [SetScriptComponentToTickMT](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a9b2183852eb7b70042ed82ef917022c6) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) value) |

|  |  |
| --- | --- |
| Public Attributes | |
| string | [DestructionStates](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#aa86a387d14af6ad4f53ff0f96751c625) |
| bool | [DestroyedByStoneOnly](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a39a2351fa61bca8aa268bfe9b4fd3cfa) = false |
| bool | [CanBeDestroyedInitially](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#acac6bb71858e416f05ceabcb57afad3e) = true |
| float | [MaxHitPoint](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a9b49fb10171e62a62960a648b9552b0b) = 100.0f |
| bool | [DestroyOnAnyHit](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a734f18be1303d25d5034261f0139708a) = false |
| bool | [PassHitOnToParent](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#adba0450ee013a62ea543bfcd1f5b3f9c) = false |
| string | [ReferenceEntityTag](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a035d555073348ac4e177ed0b01477128) |
| string | [HeavyHitParticlesTag](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a4199531989613d81552688acad9ed0b9) |
| float | [HeavyHitParticlesThreshold](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a255170a381b08a6e7ea4b13fc4c92427) = 5.0f |
| string | [ParticleEffectOnDestroy](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#ae967f31028cd4b7464a0424ff8b0a110) = "" |
| string | [SoundEffectOnDestroy](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a25159d13d9e9d36bd1f62373764ba6af) = "" |
| float | [SoundAndParticleEffectHeightOffset](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#adf46a6a273d4c3d3ed121efafeae7532) = 0.0f |
| float | [SoundAndParticleEffectForwardOffset](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a49b0163afbd115f9c1ae48942f0f4408) = 0.0f |
| [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | [BattleSide](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a0876b0390381bc9b300edd134803a39c) = BattleSideEnum.None |
| Func< int, int, int, int > | [OnCalculateDestructionStateIndex](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a4242efb79739f0723ca51d536c39208a) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const string | [CleanStateTag](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a857928665ab838be1bf2994cc9e9528b) = "operational" |
| static float | [MaxBlowMagnitude](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#ae843d2f993705bd47f0d0d1831f65fb5) = 20.0f |
| Static Public Attributes inherited from [TaleWorlds.MountAndBlade.MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | |
| const int | [MaxNavMeshPerDynamicObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#ad33e7f4aeb39643c81e3f22ae208d9e1) = 50 |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a147ec56484a2403cef2f0f1018f61f77) (int removeReason) |
|  | [DestructableComponent](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a5e9cc4a2f68ace3af9d4612ff3ef82e1) () |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | |
| virtual void | [AttachDynamicNavmeshToEntity](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a96b0e630894be6b18d6395ad12f811ac) () |
| virtual [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | [GetEntityToAttachNavMeshFaces](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a91b69e394d98f64d45604ee179496bb3) () |
| override void | [OnRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a67f885c862847e8c64853294b822cb3f) (int removeReason) |
| Protected Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [InvalidateWeakPointersIfValid](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#af39d73d0c78790ba81a40a5a350c0526) () |
|  | [ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0bc136bb53989f2b9a4f23f12f54a332) () |

|  |  |
| --- | --- |
| Properties | |
| float | [HitPoint](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#abf5a6e275e63afa41869f18576cc08f3) `[get, set]` |
| [FocusableObjectType](namespace_tale_worlds_1_1_mount_and_blade.html#aa83361d8fb674ed9b16444d43d30d141) | [FocusableObjectType](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#af79e0c0c4151c3d4cff3b3ea0b6f4b3b) `[get]` |
| virtual bool | [IsFocusable](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a77399e5de500757ae9a71a42c718cd25) `[get]` |
| bool | [IsDestroyed](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a7e4109f2b7fd0f2080997c9071bb6d21) `[get]` |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0a02cc65cc567db6101ea4afa275ff36) | [CurrentState](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#ae7811bdd806b1a4174feaa17e0dede4d) `[get]` |
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
| Action | [OnNextDestructionState](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#ad5a4cf27cb7e86d7691807de14926ee5) |
| [OnHitTakenAndDestroyedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#ab5c30adb63ba678ed9d76ed606933889) | [OnDestroyed](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#ad2c438baca91cef8b6564306cb9b9bbf) |
| [OnHitTakenAndDestroyedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#ab5c30adb63ba678ed9d76ed606933889) | [OnHitTaken](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#af0b5c471785add203af80aaa16f73457) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Types inherited from [TaleWorlds.MountAndBlade.SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html) | |
| enum | [SynchFlags](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5ca) : uint {     [SynchNone](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5caa2da4e8e99f2913602376d36f8089a315) = 0x00000000 ,     [SynchTransform](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5caaa2b2f6339ae0b34de079c6d36495701a) = 0x00000001 ,     [SynchAnimation](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5caa896890ac2c4ab8db6aa3d8aa54201e2f) = 0x00000002 ,     [SynchBodyFlags](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5caabe8d4d441f6ffd28e6c51f8f3c7be862) = 0x00000004 ,     [SyncColors](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5caa10774fbeeb25df50516d9b754652622a) = 0x00000008 ,     [SynchAll](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5caa86cdc154b35c72e83e8b91718295bd3a) = 0xffffffff   } |
| Public Types inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| enum | [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) : uint {     [None](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da6adf97f83acf6453d4a6a4b1070f3754) = 0x00000000 ,     [TickOccasionally](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da9cee052f50afabfc1098c1aa6af80b75) = 0x00000001 ,     [Tick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0b3516a5bbb77566f904f9d3877f4710) = 0x00000002 ,     [TickParallel](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da5f5a8f4b9ce783164665db4d70e03ee3) = 0x00000004 ,     [TickParallel2](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0ea9f0c260cdfd8b20ce19a48dbc329f) = 0x00000008 ,     [FixedTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154dadd067942f0b8cc66859698bc9711ba15) = 0x00000010 ,     [FixedParallelTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daa226d712a5ffd8d400f850393ff68492) = 0x00000020 ,     [TickParallel3](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daf785c2c005d708ea434168efc10611b8) = 0x00000040   } |
| Protected Types inherited from [TaleWorlds.MountAndBlade.MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | |
| enum | [DynamicNavmeshLocalIds](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90b) : int {     [Inside](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90ba9b6d3000134648fc9f1e71094ae0847d) = 1 ,     [Enter](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90baf1851d5600eae616ee802a31ac74701b) = 2 ,     [Exit](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90bafef46e5063ce3dc78b8ae64fa474241d) = 3 ,     [Blocker](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90bada32a1684e943a766fec67b13009be79) = 4 ,     [Extra1](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90ba113f84d105af2b8016b3896117c9deab) = 5 ,     [Extra2](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90ba83dca46dd08ad782e968d586375715e1) = 6 ,     [Extra3](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90bab7f54183dc84b2982ebe161b9c59f2d9) = 7 ,     [Reserved1](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90ba93876cb309016fa725517b046474c44b) = 9 ,     [Count](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90bae93f994f01c537c4e2f7d8528c3eb5e9)   } |
| Protected Attributes inherited from [TaleWorlds.MountAndBlade.MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | |
| string | [NavMeshPrefabName](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#afbbb7a7a9d7d3196e2166a3408c30d3e) = "" |
| int | [DynamicNavmeshIdStart](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a86be6f4e676cad159e82a8803daf8d1e) = 0 |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a5e9cc4a2f68ace3af9d4612ff3ef82e1)DestructableComponent()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | TaleWorlds.MountAndBlade.DestructableComponent.DestructableComponent | ( |  | ) |  | | protected |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#ab5c30adb63ba678ed9d76ed606933889)OnHitTakenAndDestroyedDelegate()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate void TaleWorlds.MountAndBlade.DestructableComponent.OnHitTakenAndDestroyedDelegate | ( | [DestructableComponent](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a5e9cc4a2f68ace3af9d4612ff3ef82e1) | *target*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *weapon*, |
|  |  | [ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0bc136bb53989f2b9a4f23f12f54a332) | *attackerScriptComponentBehavior*, |
|  |  | int | *inflictedDamage* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a147ec56484a2403cef2f0f1018f61f77)OnRemoved()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.DestructableComponent.OnRemoved | ( | int | *removeReason* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a4778f913080fc216866daa15518c8ecd).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#af49a40eb4bca704818b1e0ab3f6309e5)GetOriginalState()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) TaleWorlds.MountAndBlade.DestructableComponent.GetOriginalState | ( | [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *parent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a77df4deea16d994592f3ce68d781e9bb)Reset()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DestructableComponent.Reset | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#af791ba393f73fa83c47ac773a21e4066)TriggerOnHit()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DestructableComponent.TriggerOnHit | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | int | *inflictedDamage*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *impactPosition*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *impactDirection*, |
|  |  | in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *weapon*, |
|  |  | int | *affectorWeaponSlotOrMissileIndex*, |
|  |  | [ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0bc136bb53989f2b9a4f23f12f54a332) | *attackerScriptComponentBehavior* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a79b8bdaf87e07847d9db5e077593f7f4)BurstHeavyHitParticles()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DestructableComponent.BurstHeavyHitParticles | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a21ebbcd2b4821f1f253a7fd62086eea0)SetDestructionLevel()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DestructableComponent.SetDestructionLevel | ( | int | *state*, |
|  |  | int | *forcedId*, |
|  |  | float | *blowMagnitude*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *blowPosition*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *blowDirection*, |
|  |  | bool | *noEffects* = false ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a242bc1b9dba5b8f1b75a6a733a013313)PreDestroy()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DestructableComponent.PreDestroy | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a9fb3931a04e35ba172d7521abec863a0)WriteToNetwork()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.DestructableComponent.WriteToNetwork | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#ae2659d0b019f69ee37de2d69beb032ce).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#aaa5e19f57dbdfe5baa1d96fd34b07848)AddStuckMissile()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.DestructableComponent.AddStuckMissile | ( | [GameEntity](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0a02cc65cc567db6101ea4afa275ff36) | *missileEntity* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a0173366e9a2f20a2b9bb83939c3f4d2d).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a4e3a16a4fc574cc51126620d8c6d21ed)OnFocusGain()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DestructableComponent.OnFocusGain | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *userAgent* | ) |  |

Implements [TaleWorlds.MountAndBlade.IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html#a42697fa1ea31f29be949e5325dfbc95e).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a3f77c9d85204a2de32fa94d5adaf8bab)OnFocusLose()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DestructableComponent.OnFocusLose | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *userAgent* | ) |  |

Implements [TaleWorlds.MountAndBlade.IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html#af920e5735d03cd6b971c458640fd6bba).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a0a0fb220200601a625ed4598592c4c33)GetInfoTextForBeingNotInteractable()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.MountAndBlade.DestructableComponent.GetInfoTextForBeingNotInteractable | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *userAgent* | ) |  |

Implements [TaleWorlds.MountAndBlade.IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html#af5595369849cf9b7ba326828eab1c33d).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a060d0eb4614e18fd006455c94f909137)OnAfterReadFromNetwork()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.DestructableComponent.OnAfterReadFromNetwork | ( | ([BaseSynchedMissionObjectReadableRecord](struct_tale_worlds_1_1_mount_and_blade_1_1_base_synched_mission_object_readable_record.html), [ISynchedMissionObjectReadableRecord](interface_tale_worlds_1_1_mount_and_blade_1_1_i_synched_mission_object_readable_record.html)) | *synchedMissionObjectReadableRecord*, | |  |  | bool | *allowVisibilityUpdate* = true ) | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a4709dc8d1a0b3228df3c8e630e40a58a).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a4d154c8c827ddd2e51d67552e0a4b65e)GetDescriptionText()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.MountAndBlade.DestructableComponent.GetDescriptionText | ( | [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity* | ) |  |

Implements [TaleWorlds.MountAndBlade.IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html#ae296d89b1b2262987e2a6c7bb88368f8).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a857928665ab838be1bf2994cc9e9528b)CleanStateTag
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.DestructableComponent.CleanStateTag = "operational" | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#ae843d2f993705bd47f0d0d1831f65fb5)MaxBlowMagnitude
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.DestructableComponent.MaxBlowMagnitude = 20.0f | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#aa86a387d14af6ad4f53ff0f96751c625)DestructionStates
-----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.DestructableComponent.DestructionStates |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a39a2351fa61bca8aa268bfe9b4fd3cfa)DestroyedByStoneOnly
--------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.DestructableComponent.DestroyedByStoneOnly = false |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#acac6bb71858e416f05ceabcb57afad3e)CanBeDestroyedInitially
-----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.DestructableComponent.CanBeDestroyedInitially = true |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a9b49fb10171e62a62960a648b9552b0b)MaxHitPoint
-----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.DestructableComponent.MaxHitPoint = 100.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a734f18be1303d25d5034261f0139708a)DestroyOnAnyHit
---------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.DestructableComponent.DestroyOnAnyHit = false |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#adba0450ee013a62ea543bfcd1f5b3f9c)PassHitOnToParent
-----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.DestructableComponent.PassHitOnToParent = false |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a035d555073348ac4e177ed0b01477128)ReferenceEntityTag
------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.DestructableComponent.ReferenceEntityTag |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a4199531989613d81552688acad9ed0b9)HeavyHitParticlesTag
--------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.DestructableComponent.HeavyHitParticlesTag |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a255170a381b08a6e7ea4b13fc4c92427)HeavyHitParticlesThreshold
--------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.DestructableComponent.HeavyHitParticlesThreshold = 5.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#ae967f31028cd4b7464a0424ff8b0a110)ParticleEffectOnDestroy
-----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.DestructableComponent.ParticleEffectOnDestroy = "" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a25159d13d9e9d36bd1f62373764ba6af)SoundEffectOnDestroy
--------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.DestructableComponent.SoundEffectOnDestroy = "" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#adf46a6a273d4c3d3ed121efafeae7532)SoundAndParticleEffectHeightOffset
----------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.DestructableComponent.SoundAndParticleEffectHeightOffset = 0.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a49b0163afbd115f9c1ae48942f0f4408)SoundAndParticleEffectForwardOffset
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.DestructableComponent.SoundAndParticleEffectForwardOffset = 0.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a0876b0390381bc9b300edd134803a39c)BattleSide
----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) TaleWorlds.MountAndBlade.DestructableComponent.BattleSide = BattleSideEnum.None |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a4242efb79739f0723ca51d536c39208a)OnCalculateDestructionStateIndex
--------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Func<int, int, int, int> TaleWorlds.MountAndBlade.DestructableComponent.OnCalculateDestructionStateIndex |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#abf5a6e275e63afa41869f18576cc08f3)HitPoint
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.DestructableComponent.HitPoint | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#af79e0c0c4151c3d4cff3b3ea0b6f4b3b)FocusableObjectType
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [FocusableObjectType](namespace_tale_worlds_1_1_mount_and_blade.html#aa83361d8fb674ed9b16444d43d30d141) TaleWorlds.MountAndBlade.DestructableComponent.FocusableObjectType | | get |

Implements [TaleWorlds.MountAndBlade.IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html#ad45e6dc0d435f66db8f1dee1055b18d6).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a77399e5de500757ae9a71a42c718cd25)IsFocusable
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual bool TaleWorlds.MountAndBlade.DestructableComponent.IsFocusable | | get |

Implements [TaleWorlds.MountAndBlade.IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html#a1acaf86c44c33cbc58c6c9b88dcd682c).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a7e4109f2b7fd0f2080997c9071bb6d21)IsDestroyed
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.DestructableComponent.IsDestroyed | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#ae7811bdd806b1a4174feaa17e0dede4d)CurrentState
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GameEntity](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0a02cc65cc567db6101ea4afa275ff36) TaleWorlds.MountAndBlade.DestructableComponent.CurrentState | | get |

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#ad5a4cf27cb7e86d7691807de14926ee5)OnNextDestructionState
----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action TaleWorlds.MountAndBlade.DestructableComponent.OnNextDestructionState |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#ad2c438baca91cef8b6564306cb9b9bbf)OnDestroyed
-----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [OnHitTakenAndDestroyedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#ab5c30adb63ba678ed9d76ed606933889) TaleWorlds.MountAndBlade.DestructableComponent.OnDestroyed |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#af0b5c471785add203af80aaa16f73457)OnHitTaken
----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [OnHitTakenAndDestroyedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#ab5c30adb63ba678ed9d76ed606933889) TaleWorlds.MountAndBlade.DestructableComponent.OnHitTaken |

