--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html ---

TaleWorlds.MountAndBlade.UsableMachine Class ReferenceabstractInherits [TaleWorlds.MountAndBlade.SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html), [TaleWorlds.MountAndBlade.IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html), [TaleWorlds.MountAndBlade.IOrderable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_orderable.html), and [TaleWorlds.MountAndBlade.IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html).

Inherited by [SandBox.Objects.Usables.Chair](class_sand_box_1_1_objects_1_1_usables_1_1_chair.html), [SandBox.Objects.Usables.CheckpointUsePoint](class_sand_box_1_1_objects_1_1_usables_1_1_checkpoint_use_point.html), [SandBox.Objects.Usables.MusicianGroup](class_sand_box_1_1_objects_1_1_usables_1_1_musician_group.html), [SandBox.Objects.Usables.Passage](class_sand_box_1_1_objects_1_1_usables_1_1_passage.html), [SandBox.Objects.Usables.PatrolArea](class_sand_box_1_1_objects_1_1_usables_1_1_patrol_area.html), [SandBox.Objects.Usables.SmithingMachine](class_sand_box_1_1_objects_1_1_usables_1_1_smithing_machine.html), [SandBox.Objects.Usables.UsablePlace](class_sand_box_1_1_objects_1_1_usables_1_1_usable_place.html), [TaleWorlds.MountAndBlade.CastleGate](class_tale_worlds_1_1_mount_and_blade_1_1_castle_gate.html), [TaleWorlds.MountAndBlade.ExitDoor](class_tale_worlds_1_1_mount_and_blade_1_1_exit_door.html), [TaleWorlds.MountAndBlade.Objects.Usables.AmmoBarrelBase](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_usables_1_1_ammo_barrel_base.html), [TaleWorlds.MountAndBlade.Objects.Usables.ClimbingMachine](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_usables_1_1_climbing_machine.html), [TaleWorlds.MountAndBlade.Objects.Usables.EventTriggeringUsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_usables_1_1_event_triggering_usable_machine.html), [TaleWorlds.MountAndBlade.Objects.Usables.SiegeMachineStonePile](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_usables_1_1_siege_machine_stone_pile.html), [TaleWorlds.MountAndBlade.SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html), [TaleWorlds.MountAndBlade.StonePile](class_tale_worlds_1_1_mount_and_blade_1_1_stone_pile.html), and [TaleWorlds.MountAndBlade.TrainingIcon](class_tale_worlds_1_1_mount_and_blade_1_1_training_icon.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [AddComponent](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a35b3b37ed3d8bd65301a2c598c618de2) ([UsableMissionObjectComponent](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object_component.html) component) |
| void | [RemoveComponent](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#ae9a927027a7b66ea04d6f34888290b63) ([UsableMissionObjectComponent](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object_component.html) component) |
| T | [GetComponent< T >](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a6f7a8e0718688e9d630852f124a70fbc) () |
| virtual [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) | [GetOrder](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a1cb5d50fdbbeb6cfdfd5106bfbde0ab5) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| virtual [UsableMachineAIBase](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html) | [CreateAIBehaviorObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#abbf63ca39c7d9d26a2bd8e6bc3458c6d) () |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | [GetValidStandingPointForAgent](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#aa71816e27d7d4d58dcd19cd1d0e1d3d3) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| void | [SetAI](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#aba7b9fd4d09eac6fbd73c9c0e75ebe5b) ([UsableMachineAIBase](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html) ai) |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | [GetValidStandingPointForAgentWithoutDistanceCheck](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a10615b1a2ab30fcf170f2c4a697c3194) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) | [GetVacantStandingPointForAI](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a74483e07858c6c7f2f36d8fc077c4085) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) | [GetTargetStandingPointOfAIAgent](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#aa6b6dba7df3c53a9ab2449eee322f162) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| override void | [OnMissionEnded](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a6cc35c8b9bbd3bccb6cec5471adff0d3) () |
| override void | [SetVisibleSynched](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a9a16d907b5ee47e62675f130eedf1c5c) (bool value, bool forceChildrenVisible=false) |
|  | The user agent who controls this object. |
| override void | [SetPhysicsStateSynched](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a8a92a30bf12c4144e9401803ddc4d1ee) (bool value, bool setChildren=true) |
| override [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) | [GetTickRequirement](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a963459a479fbc66654701b3c03525a5a) () |
| virtual void | [OnFocusGain](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a54afc29002fc4db9129e2a222266c789) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) userAgent) |
| virtual void | [OnFocusLose](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a5756d077496044cac2ed3623cd19af6a) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) userAgent) |
| virtual void | [OnPilotAssignedDuringSpawn](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a4e826bd545a1f7dd2daf8348541f3b69) () |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetInfoTextForBeingNotInteractable](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#aff8ecaec44cb3bcc0197ecf6f9b01d14) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) userAgent) |
| void | [Deactivate](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a30713d3ca3d233328f178eca72a094a1) () |
| void | [Activate](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a9763624842c425b7c9789d6274c3fb8c) () |
| virtual bool | [IsDisabledForBattleSide](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#af346e6bcdeb8bf6ab98835181779fb75) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) sideEnum) |
| virtual bool | [IsDisabledForBattleSideAI](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a5f3f910b34b937da3eba99d858e7e6b2) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) sideEnum) |
| virtual bool | [ShouldAutoLeaveDetachmentWhenDisabled](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a06fef2eda2c1bece5940acbe4ed45789) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) sideEnum) |
| virtual bool | [AutoAttachUserToFormation](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a06534cdd0a0c96ffa3a9289943981b0b) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) sideEnum) |
| virtual bool | [HasToBeDefendedByUser](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a9b4afecbad6ca52604d7dbb52f9d5df6) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) sideEnum) |
| virtual void | [Disable](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#aa62c88ecb68ef71f7e4e17cb6e74c29a) () |
| override string | [ToString](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a1d38daf4ce2aff596db158fd464e6fc2) () |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetActionTextForStandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#ad6643e6fa1b677c88803e85f3d68c0ce) ([UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) usableGameObject) |
| virtual [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) | [GetBestPointAlternativeTo](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a801c0d1fcd9392c6d57ab5f4bb42254e) ([StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) standingPoint, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| virtual bool | [IsInRangeToCheckAlternativePoints](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a27136dface20c158b5ce90c56c9df1c7) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| void | [AddAgentAtSlotIndex](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#aa83078c6c4b23b1f40bf3f895548c3e8) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, int slotIndex) |
| void | [SetIsDisabledForAI](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a6e49369f46614a08c98ca6c98dc15de8) (bool isDisabledForAI) |
| int | [GetNumberOfUsableSlots](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a85932ec1160bbaba72eaedc8c7f30ff1) () |
| bool | [IsStandingPointAvailableForAgent](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a235d97c77e03d34ac7433b15c4644c0d) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| bool | [IsUsedByFormation](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#aa9ac0e4cdff26c48683b1189964162f3) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetDescriptionText](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a8611445480f4dbf8da3df065933f9365) ([WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity) |
| void | [SetEnemyRangeToStopUsing](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#ad5ab0cdf786bde7ed3b3833fe97abe68) (float value) |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html) | |
| void | [SetLocalPositionSmoothStep](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#ac3d9c08322fdc346100bca4e4762762b) (ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) targetPosition) |
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
| virtual void | [AfterMissionStart](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a925fa787ae9b9a2ec414c9b575156fc1) () |
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
| string | [PilotStandingPointTag](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a27274ccfbfea192b85857d456397a5b8) = "Pilot" |
| string | [AmmoPickUpTag](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a72018b9873164ff073991e34beb3532f) = "ammopickup" |
| string | [WaitStandingPointTag](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a9718490c262e4c207d77b17cf0b9c340) = "Wait" |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const string | [UsableMachineParentTag](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a010d494a549acc4496826c009dffe185) = "machine\_parent" |
| Static Public Attributes inherited from [TaleWorlds.MountAndBlade.MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | |
| const int | [MaxNavMeshPerDynamicObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#ad33e7f4aeb39643c81e3f22ae208d9e1) = 50 |

|  |  |
| --- | --- |
| Protected Member Functions | |
|  | [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#ac5fe63ebe9d4d5b7d6e31521577178ee) () |
| virtual void | [DebugTick](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#acb4973db4969533a42bf0dc4ea27de3a) (float dt) |
| bool | [IsDisabledDueToEnemyInRange](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#afb7df349a54b2ffcb85c2c6e7c60e373) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) sideEnum) |
| override void | [OnRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#abc7226debc7d7f91ee2db48317dd9ca7) (int removeReason) |
| virtual float | [GetWeightOfStandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a1799fb6802848c721ca165fbe39b6f23) ([StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) sp) |
| virtual float | [GetDetachmentWeightAux](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#aaed333395ea45e95254004c01602c785) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| virtual bool | [IsAgentOnInconvenientNavmesh](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a231d4a00adb93489d694947f3ddfc84d) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) standingPoint) |
| virtual [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) | [GetSuitableStandingPointFor](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#ac21beefc597d31859f29689b192f30a5) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent=null, List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > agents=null, List< ValueTuple< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), float > > agentValuePairs=null) |
| virtual bool | [ShouldDisableTickIfMachineDisabled](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#ac6935984e4f8f54115a62b891e4b1786) () |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | |
| virtual void | [AttachDynamicNavmeshToEntity](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a96b0e630894be6b18d6395ad12f811ac) () |
| virtual [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | [GetEntityToAttachNavMeshFaces](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a91b69e394d98f64d45604ee179496bb3) () |
| Protected Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [InvalidateWeakPointersIfValid](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#af39d73d0c78790ba81a40a5a350c0526) () |
|  | [ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0bc136bb53989f2b9a4f23f12f54a332) () |

|  |  |
| --- | --- |
| Protected Attributes | |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0a02cc65cc567db6101ea4afa275ff36) | [ActiveWaitStandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#ae3c7f9940bc3470875fe12e71eea1ec8) |
| bool | [\_areUsableStandingPointsVacant](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a9ad82c6fc37cc8e8dae58fad8e86c536) = true |
| List< ValueTuple< int, [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) > > | [\_usableStandingPoints](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#acceb99a464c9fe94cb4d45422574c14f) |
| bool | [\_isDetachmentRecentlyEvaluated](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#afc1ae7bcf297dfa730f4974194ef0688) = false |
| float | [EnemyRangeToStopUsing](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a234a71f65242db22ab72e6b2d7ddc5eb) = 0.0f |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [MachinePositionOffsetToStopUsingLocal](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#ab2c95215b7cc9b9ca0d4ddc7fbc6e264) = Vec2.Zero |
| bool | [MakeVisibilityCheck](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a3139a0f8f431878512d2abecb54b1eb5) = true |
| QueryData< bool > | [IsDisabledForAttackerAIDueToEnemyInRange](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a53245d1ef6a75419bcee9f8765c2554b) |
| QueryData< bool > | [IsDisabledForDefenderAIDueToEnemyInRange](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a915dc3567db757f9cecb0d79b068614c) |
| MBList< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > | [\_userFormations](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#af1654cd4b1c325706b1fc015c4237c71) |
| Protected Attributes inherited from [TaleWorlds.MountAndBlade.MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | |
| string | [NavMeshPrefabName](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#afbbb7a7a9d7d3196e2166a3408c30d3e) = "" |
| int | [DynamicNavmeshIdStart](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a86be6f4e676cad159e82a8803daf8d1e) = 0 |

|  |  |
| --- | --- |
| Properties | |
| MBList< [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) > | [StandingPoints](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a4e09ef1e05b6ac1ae22b44e47f0a730e) `[get]` |
| [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) | [PilotStandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a43473add87f178c67da5189bd2422881) `[get]` |
| int | [PilotStandingPointSlotIndex](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#aac70384d67ee40b12fd4b8ca5d7ec920) `[get]` |
| List< [GameEntity](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0a02cc65cc567db6101ea4afa275ff36) > | [WaitStandingPoints](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a31dd39d00c0df78b9ba04690253c2e34) `[get]` |
| [DestructableComponent](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html) | [DestructionComponent](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a1d7a12ec58f38303f4c811aac0d4ecc1) `[get]` |
| bool | [IsDestructible](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#ac894856ee3eb7cf48c740bc071b3214e) `[get]` |
| bool | [IsDestroyed](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a6626d316662f75afd5342feda7224665) `[get]` |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [PilotAgent](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#afa83e992adead73fdbfca2ce707bcd3d) `[get]` |
| bool | [IsLoose](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#aca1e3b6c22ea4ce05497c4b435d51eb6) `[get]` |
| virtual float | [SinkingReferenceOffset](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a2d630e0ef538af729106ffc6ba820d62) `[get]` |
| [UsableMachineAIBase](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html) | [Ai](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a6bf668c5d7a9d1db972f446914aee8c4) `[get]` |
| virtual [FocusableObjectType](namespace_tale_worlds_1_1_mount_and_blade.html#aa83361d8fb674ed9b16444d43d30d141) | [FocusableObjectType](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#abcbb0aa3eb7586452c6012a8786b8b41) `[get]` |
| virtual bool | [IsFocusable](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a8601d28166f23a8f850eb90d1d86f3c4) `[get]` |
| [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) | [CurrentlyUsedAmmoPickUpPoint](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#ae96425b918bfcce099aafa9813c2fdb3) `[get, set]` |
| bool | [HasAIPickingUpAmmo](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a169ee8692dcf8e5367ff6540287fee6b) `[get]` |
| bool | [IsDisabledForAI](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#ac46bbe4526dd462d8b3607b4e9c313e4) `[get, protected set]` |
| MBReadOnlyList< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > | [UserFormations](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a063bc1ab0685f631a3d6c4c587a91e4b) `[get]` |
| int | [UserCountNotInStruckAction](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a84710718891666308e423d2db5da534d) `[get]` |
| int | [UserCountIncludingInStruckAction](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#ae3d04cb7f9332a3342e831f4b54b5449) `[get]` |
| virtual int | [MaxUserCount](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a9e05fc11a3274ecb5017cc0dcf85c542) `[get]` |
| virtual bool | [HasWaitFrame](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#afb2f60fdb64a03d99fe43c24c2418d46) `[get]` |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [WaitFrame](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#aae80c64f159ba9ac8cae26bfdc8401dd) `[get]` |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0a02cc65cc567db6101ea4afa275ff36) | [WaitEntity](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a53d7f1c2433c6162c43f8131b63c6f7a) `[get]` |
| virtual bool | [IsDeactivated](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a8f0c5d843d87777aef51cc19ee08bac2) `[get]` |
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
| Additional Inherited Members | |
| Public Types inherited from [TaleWorlds.MountAndBlade.SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html) | |
| enum | [SynchFlags](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5ca) : uint {     [SynchNone](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5caa2da4e8e99f2913602376d36f8089a315) = 0x00000000 ,     [SynchTransform](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5caaa2b2f6339ae0b34de079c6d36495701a) = 0x00000001 ,     [SynchAnimation](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5caa896890ac2c4ab8db6aa3d8aa54201e2f) = 0x00000002 ,     [SynchBodyFlags](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5caabe8d4d441f6ffd28e6c51f8f3c7be862) = 0x00000004 ,     [SyncColors](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5caa10774fbeeb25df50516d9b754652622a) = 0x00000008 ,     [SynchAll](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5caa86cdc154b35c72e83e8b91718295bd3a) = 0xffffffff   } |
| Public Types inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| enum | [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) : uint {     [None](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da6adf97f83acf6453d4a6a4b1070f3754) = 0x00000000 ,     [TickOccasionally](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da9cee052f50afabfc1098c1aa6af80b75) = 0x00000001 ,     [Tick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0b3516a5bbb77566f904f9d3877f4710) = 0x00000002 ,     [TickParallel](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da5f5a8f4b9ce783164665db4d70e03ee3) = 0x00000004 ,     [TickParallel2](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0ea9f0c260cdfd8b20ce19a48dbc329f) = 0x00000008 ,     [FixedTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154dadd067942f0b8cc66859698bc9711ba15) = 0x00000010 ,     [FixedParallelTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daa226d712a5ffd8d400f850393ff68492) = 0x00000020 ,     [TickParallel3](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daf785c2c005d708ea434168efc10611b8) = 0x00000040   } |
| Protected Types inherited from [TaleWorlds.MountAndBlade.MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | |
| enum | [DynamicNavmeshLocalIds](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90b) : int {     [Inside](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90ba9b6d3000134648fc9f1e71094ae0847d) = 1 ,     [Enter](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90baf1851d5600eae616ee802a31ac74701b) = 2 ,     [Exit](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90bafef46e5063ce3dc78b8ae64fa474241d) = 3 ,     [Blocker](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90bada32a1684e943a766fec67b13009be79) = 4 ,     [Extra1](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90ba113f84d105af2b8016b3896117c9deab) = 5 ,     [Extra2](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90ba83dca46dd08ad782e968d586375715e1) = 6 ,     [Extra3](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90bab7f54183dc84b2982ebe161b9c59f2d9) = 7 ,     [Reserved1](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90ba93876cb309016fa725517b046474c44b) = 9 ,     [Count](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90bae93f994f01c537c4e2f7d8528c3eb5e9)   } |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#ac5fe63ebe9d4d5b7d6e31521577178ee)UsableMachine()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | TaleWorlds.MountAndBlade.UsableMachine.UsableMachine | ( |  | ) |  | | protected |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a35b3b37ed3d8bd65301a2c598c618de2)AddComponent()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.UsableMachine.AddComponent | ( | [UsableMissionObjectComponent](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object_component.html) | *component* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#ae9a927027a7b66ea04d6f34888290b63)RemoveComponent()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.UsableMachine.RemoveComponent | ( | [UsableMissionObjectComponent](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object_component.html) | *component* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a6f7a8e0718688e9d630852f124a70fbc)GetComponent< T >()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| T TaleWorlds.MountAndBlade.UsableMachine.GetComponent< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[UsableMissionObjectComponent](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object_component.html)* |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a1cb5d50fdbbeb6cfdfd5106bfbde0ab5)GetOrder()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) TaleWorlds.MountAndBlade.UsableMachine.GetOrder | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* | ) |  | | virtual |

Implements [TaleWorlds.MountAndBlade.IOrderable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_orderable.html#aadb767c97ef108a6a30fd5d2f3386ac6).

Reimplemented in [SandBox.Objects.Usables.Chair](class_sand_box_1_1_objects_1_1_usables_1_1_chair.html#ae12cb8163678597f296785ebaacc1f44), [TaleWorlds.MountAndBlade.BatteringRam](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#af8f64557c106fd6ba4e284d90c4f69eb), [TaleWorlds.MountAndBlade.CastleGate](class_tale_worlds_1_1_mount_and_blade_1_1_castle_gate.html#a452d1b2b872adee920f7172aff6528b8), [TaleWorlds.MountAndBlade.Objects.Usables.AmmoBarrelBase](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_usables_1_1_ammo_barrel_base.html#abccf60d8bb021cc0920dca74773e17e8), [TaleWorlds.MountAndBlade.Objects.Usables.SiegeMachineStonePile](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_usables_1_1_siege_machine_stone_pile.html#a0bddd3040c71255ca1505a12b4478b4e), [TaleWorlds.MountAndBlade.RangedSiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#af26696855b229f651b2b00e58f16a826), [TaleWorlds.MountAndBlade.SiegeLadder](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a0279c1fe169ce144c0be843a9d338c64), and [TaleWorlds.MountAndBlade.SiegeTower](class_tale_worlds_1_1_mount_and_blade_1_1_siege_tower.html#a65c2c67df9f537ba45da62216f4a55eb).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#abbf63ca39c7d9d26a2bd8e6bc3458c6d)CreateAIBehaviorObject()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual [UsableMachineAIBase](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html) TaleWorlds.MountAndBlade.UsableMachine.CreateAIBehaviorObject | ( |  | ) |  | | virtual |

Reimplemented in [SandBox.Objects.Usables.Chair](class_sand_box_1_1_objects_1_1_usables_1_1_chair.html#a0e82a8c5b85423903bb3dd89d86e2407), [SandBox.Objects.Usables.MusicianGroup](class_sand_box_1_1_objects_1_1_usables_1_1_musician_group.html#ac37477326a4cd8246895c0bcb5d4ab16), [SandBox.Objects.Usables.Passage](class_sand_box_1_1_objects_1_1_usables_1_1_passage.html#a06fd7465a553ca63f0b4c837880717bc), [SandBox.Objects.Usables.PatrolArea](class_sand_box_1_1_objects_1_1_usables_1_1_patrol_area.html#add54415b5d0220ec9c12f043c7b70713), [SandBox.Objects.Usables.SmithingMachine](class_sand_box_1_1_objects_1_1_usables_1_1_smithing_machine.html#a8d995f484bfcfecb70f29ff8f0f1b7fd), [SandBox.Objects.Usables.UsablePlace](class_sand_box_1_1_objects_1_1_usables_1_1_usable_place.html#a0bcbb0a00ef70228a35763b73a42f141), [TaleWorlds.MountAndBlade.Ballista](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a01f893e8ba8b6b9d2849cf683bb306ca), [TaleWorlds.MountAndBlade.BatteringRam](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a4690923b1dfc24c31eacd7a8ab0fa231), [TaleWorlds.MountAndBlade.CastleGate](class_tale_worlds_1_1_mount_and_blade_1_1_castle_gate.html#afacad865873fe9e1d3558d7206dbf995), [TaleWorlds.MountAndBlade.Mangonel](class_tale_worlds_1_1_mount_and_blade_1_1_mangonel.html#ad73efb98b5d6288585a9ce118c833007), [TaleWorlds.MountAndBlade.SiegeLadder](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#ac0a74dc17b9a4a8ee7040ca8f04e047f), [TaleWorlds.MountAndBlade.SiegeTower](class_tale_worlds_1_1_mount_and_blade_1_1_siege_tower.html#a8ac7c1763ae7472b16b86e8448b3fb9a), [TaleWorlds.MountAndBlade.StonePile](class_tale_worlds_1_1_mount_and_blade_1_1_stone_pile.html#a76fbf0760767058b3e996ea5a3a6e95a), and [TaleWorlds.MountAndBlade.Trebuchet](class_tale_worlds_1_1_mount_and_blade_1_1_trebuchet.html#a29350e35d9705aba538f8e0cb2bbe1a6).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#aa71816e27d7d4d58dcd19cd1d0e1d3d3)GetValidStandingPointForAgent()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) TaleWorlds.MountAndBlade.UsableMachine.GetValidStandingPointForAgent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#aba7b9fd4d09eac6fbd73c9c0e75ebe5b)SetAI()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.UsableMachine.SetAI | ( | [UsableMachineAIBase](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html) | *ai* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a10615b1a2ab30fcf170f2c4a697c3194)GetValidStandingPointForAgentWithoutDistanceCheck()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) TaleWorlds.MountAndBlade.UsableMachine.GetValidStandingPointForAgentWithoutDistanceCheck | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a74483e07858c6c7f2f36d8fc077c4085)GetVacantStandingPointForAI()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) TaleWorlds.MountAndBlade.UsableMachine.GetVacantStandingPointForAI | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#aa6b6dba7df3c53a9ab2449eee322f162)GetTargetStandingPointOfAIAgent()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) TaleWorlds.MountAndBlade.UsableMachine.GetTargetStandingPointOfAIAgent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a6cc35c8b9bbd3bccb6cec5471adff0d3)OnMissionEnded()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.UsableMachine.OnMissionEnded | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#aa903cd7aefee1178f7e0700031f6cbd3).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a9a16d907b5ee47e62675f130eedf1c5c)SetVisibleSynched()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.UsableMachine.SetVisibleSynched | ( | bool | *value*, | |  |  | bool | *forceChildrenVisible* = false ) | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#adfd7b558f73221bc0026ae3537f20f87).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a8a92a30bf12c4144e9401803ddc4d1ee)SetPhysicsStateSynched()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.UsableMachine.SetPhysicsStateSynched | ( | bool | *value*, | |  |  | bool | *setChildren* = true ) | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a4c5c4d8e7bfcf7c1060df3b71eb690b0).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a963459a479fbc66654701b3c03525a5a)GetTickRequirement()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) TaleWorlds.MountAndBlade.UsableMachine.GetTickRequirement | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a4ac82f3267a7b398201cb1f30ee9a37f).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#acb4973db4969533a42bf0dc4ea27de3a)DebugTick()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.UsableMachine.DebugTick | ( | float | *dt* | ) |  | | protectedvirtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a54afc29002fc4db9129e2a222266c789)OnFocusGain()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.UsableMachine.OnFocusGain | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *userAgent* | ) |  | | virtual |

Implements [TaleWorlds.MountAndBlade.IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html#a42697fa1ea31f29be949e5325dfbc95e).

Reimplemented in [TaleWorlds.MountAndBlade.TrainingIcon](class_tale_worlds_1_1_mount_and_blade_1_1_training_icon.html#a64be363610fadd2f144853610f428a4b).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a5756d077496044cac2ed3623cd19af6a)OnFocusLose()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.UsableMachine.OnFocusLose | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *userAgent* | ) |  | | virtual |

Implements [TaleWorlds.MountAndBlade.IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html#af920e5735d03cd6b971c458640fd6bba).

Reimplemented in [TaleWorlds.MountAndBlade.TrainingIcon](class_tale_worlds_1_1_mount_and_blade_1_1_training_icon.html#a16c516af7f5ff17a71bd8e0e2eec0705).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a4e826bd545a1f7dd2daf8348541f3b69)OnPilotAssignedDuringSpawn()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.UsableMachine.OnPilotAssignedDuringSpawn | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.Ballista](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a26415173f8d1426315c86be339b71a76), and [TaleWorlds.MountAndBlade.Mangonel](class_tale_worlds_1_1_mount_and_blade_1_1_mangonel.html#ae78eb626d5c415c6d4fa4f08a036542f).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#aff8ecaec44cb3bcc0197ecf6f9b01d14)GetInfoTextForBeingNotInteractable()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.MountAndBlade.UsableMachine.GetInfoTextForBeingNotInteractable | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *userAgent* | ) |  | | virtual |

Implements [TaleWorlds.MountAndBlade.IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html#af5595369849cf9b7ba326828eab1c33d).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a30713d3ca3d233328f178eca72a094a1)Deactivate()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.UsableMachine.Deactivate | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a9763624842c425b7c9789d6274c3fb8c)Activate()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.UsableMachine.Activate | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#af346e6bcdeb8bf6ab98835181779fb75)IsDisabledForBattleSide()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual bool TaleWorlds.MountAndBlade.UsableMachine.IsDisabledForBattleSide | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *sideEnum* | ) |  | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.SiegeLadder](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a0ae882415b8ee812df50630764c43558).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a5f3f910b34b937da3eba99d858e7e6b2)IsDisabledForBattleSideAI()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual bool TaleWorlds.MountAndBlade.UsableMachine.IsDisabledForBattleSideAI | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *sideEnum* | ) |  | | virtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a06fef2eda2c1bece5940acbe4ed45789)ShouldAutoLeaveDetachmentWhenDisabled()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual bool TaleWorlds.MountAndBlade.UsableMachine.ShouldAutoLeaveDetachmentWhenDisabled | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *sideEnum* | ) |  | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a8b14aadd795b8738e1c9100f886b0651).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#afb7df349a54b2ffcb85c2c6e7c60e373)IsDisabledDueToEnemyInRange()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.UsableMachine.IsDisabledDueToEnemyInRange | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *sideEnum* | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a06534cdd0a0c96ffa3a9289943981b0b)AutoAttachUserToFormation()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual bool TaleWorlds.MountAndBlade.UsableMachine.AutoAttachUserToFormation | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *sideEnum* | ) |  | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a12e65015f5e841b9557060581a02dee8).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a9b4afecbad6ca52604d7dbb52f9d5df6)HasToBeDefendedByUser()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual bool TaleWorlds.MountAndBlade.UsableMachine.HasToBeDefendedByUser | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *sideEnum* | ) |  | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#aa23df3bbf9018070ed1e0b14b2039752).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#aa62c88ecb68ef71f7e4e17cb6e74c29a)Disable()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.UsableMachine.Disable | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.BatteringRam](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#ab8668c0e9924ada7324b33e60f4f28eb), and [TaleWorlds.MountAndBlade.SiegeTower](class_tale_worlds_1_1_mount_and_blade_1_1_siege_tower.html#a85d274948bc303187f5acc22bba957e4).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#abc7226debc7d7f91ee2db48317dd9ca7)OnRemoved()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.UsableMachine.OnRemoved | ( | int | *removeReason* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a67f885c862847e8c64853294b822cb3f).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a1d38daf4ce2aff596db158fd464e6fc2)ToString()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.MountAndBlade.UsableMachine.ToString | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#ad6643e6fa1b677c88803e85f3d68c0ce)GetActionTextForStandingPoint()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.MountAndBlade.UsableMachine.GetActionTextForStandingPoint | ( | [UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) | *usableGameObject* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a801c0d1fcd9392c6d57ab5f4bb42254e)GetBestPointAlternativeTo()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) TaleWorlds.MountAndBlade.UsableMachine.GetBestPointAlternativeTo | ( | [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) | *standingPoint*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* ) | | virtual |

Reimplemented in [SandBox.Objects.Usables.Chair](class_sand_box_1_1_objects_1_1_usables_1_1_chair.html#aee82404ad5a066f312ff647f53c7f506), [TaleWorlds.MountAndBlade.RangedSiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a9afc4647e2c809670c8d80fe85039efa), and [TaleWorlds.MountAndBlade.StonePile](class_tale_worlds_1_1_mount_and_blade_1_1_stone_pile.html#af08a61ad98fe53788a1c42968a0cb3a6).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a27136dface20c158b5ce90c56c9df1c7)IsInRangeToCheckAlternativePoints()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual bool TaleWorlds.MountAndBlade.UsableMachine.IsInRangeToCheckAlternativePoints | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.RangedSiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a9de5e37f60623bd440bd09eb843e517e), and [TaleWorlds.MountAndBlade.StonePile](class_tale_worlds_1_1_mount_and_blade_1_1_stone_pile.html#aa2a5b5b1f3d10a22415ee46fea7cadc0).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a1799fb6802848c721ca165fbe39b6f23)GetWeightOfStandingPoint()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual float TaleWorlds.MountAndBlade.UsableMachine.GetWeightOfStandingPoint | ( | [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) | *sp* | ) |  | | protectedvirtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#aaed333395ea45e95254004c01602c785)GetDetachmentWeightAux()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual float TaleWorlds.MountAndBlade.UsableMachine.GetDetachmentWeightAux | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* | ) |  | | protectedvirtual |

Reimplemented in [TaleWorlds.MountAndBlade.Mangonel](class_tale_worlds_1_1_mount_and_blade_1_1_mangonel.html#ad081e3252567d5c671d0d2b5be66d9d0), [TaleWorlds.MountAndBlade.RangedSiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#af8de4c4f1560380fda0505a2eceef1a5), [TaleWorlds.MountAndBlade.SiegeLadder](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a59e8f938f83a5637227fa917551ed5aa), [TaleWorlds.MountAndBlade.StonePile](class_tale_worlds_1_1_mount_and_blade_1_1_stone_pile.html#ab470eae542aecda0e52634d4257a2b99), and [TaleWorlds.MountAndBlade.Trebuchet](class_tale_worlds_1_1_mount_and_blade_1_1_trebuchet.html#a3d317877bb497da448eb233351e050b7).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a231d4a00adb93489d694947f3ddfc84d)IsAgentOnInconvenientNavmesh()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual bool TaleWorlds.MountAndBlade.UsableMachine.IsAgentOnInconvenientNavmesh | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) | *standingPoint* ) | | protectedvirtual |

Reimplemented in [TaleWorlds.MountAndBlade.CastleGate](class_tale_worlds_1_1_mount_and_blade_1_1_castle_gate.html#a42be81a1c8538621b2510ffe8094faa0), and [TaleWorlds.MountAndBlade.SiegeTower](class_tale_worlds_1_1_mount_and_blade_1_1_siege_tower.html#aee1e673b7677acbc35b27d6e31b13ee8).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#aa83078c6c4b23b1f40bf3f895548c3e8)AddAgentAtSlotIndex()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.UsableMachine.AddAgentAtSlotIndex | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | int | *slotIndex* ) |

Implements [TaleWorlds.MountAndBlade.IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a5b8eedf6fd897637fa9941a1452bed11).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a6e49369f46614a08c98ca6c98dc15de8)SetIsDisabledForAI()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.UsableMachine.SetIsDisabledForAI | ( | bool | *isDisabledForAI* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a85932ec1160bbaba72eaedc8c7f30ff1)GetNumberOfUsableSlots()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.UsableMachine.GetNumberOfUsableSlots | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#ad075e3a8acd6a1a28a74d183ea79760c).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a235d97c77e03d34ac7433b15c4644c0d)IsStandingPointAvailableForAgent()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.UsableMachine.IsStandingPointAvailableForAgent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

Implements [TaleWorlds.MountAndBlade.IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#aa7011006963db3f87d4857714c5f5f88).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#aa9ac0e4cdff26c48683b1189964162f3)IsUsedByFormation()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.UsableMachine.IsUsedByFormation | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  |

Implements [TaleWorlds.MountAndBlade.IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a301b5d910555ebe58458ff114557fa7a).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#ac21beefc597d31859f29689b192f30a5)GetSuitableStandingPointFor()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) TaleWorlds.MountAndBlade.UsableMachine.GetSuitableStandingPointFor | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* = null, | |  |  | List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | *agents* = null, | |  |  | List< ValueTuple< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), float > > | *agentValuePairs* = null ) | | protectedvirtual |

Reimplemented in [TaleWorlds.MountAndBlade.SiegeLadder](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a11fd88f464c34e0855a01a2bda72dbe8), and [TaleWorlds.MountAndBlade.StonePile](class_tale_worlds_1_1_mount_and_blade_1_1_stone_pile.html#af27fb07060d98854d09a7c7c199d0f94).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a8611445480f4dbf8da3df065933f9365)GetDescriptionText()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.MountAndBlade.UsableMachine.GetDescriptionText | ( | [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity* | ) |  | | abstract |

Implements [TaleWorlds.MountAndBlade.IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html#ae296d89b1b2262987e2a6c7bb88368f8).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#ac6935984e4f8f54115a62b891e4b1786)ShouldDisableTickIfMachineDisabled()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual bool TaleWorlds.MountAndBlade.UsableMachine.ShouldDisableTickIfMachineDisabled | ( |  | ) |  | | protectedvirtual |

Reimplemented in [TaleWorlds.MountAndBlade.RangedSiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a15a71167251e679c75fc4348144ab2f2).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#ad5ab0cdf786bde7ed3b3833fe97abe68)SetEnemyRangeToStopUsing()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.UsableMachine.SetEnemyRangeToStopUsing | ( | float | *value* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a010d494a549acc4496826c009dffe185)UsableMachineParentTag
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.UsableMachine.UsableMachineParentTag = "machine\_parent" | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a27274ccfbfea192b85857d456397a5b8)PilotStandingPointTag
-------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.UsableMachine.PilotStandingPointTag = "Pilot" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a72018b9873164ff073991e34beb3532f)AmmoPickUpTag
-----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.UsableMachine.AmmoPickUpTag = "ammopickup" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a9718490c262e4c207d77b17cf0b9c340)WaitStandingPointTag
------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.UsableMachine.WaitStandingPointTag = "Wait" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#ae3c7f9940bc3470875fe12e71eea1ec8)ActiveWaitStandingPoint
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GameEntity](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0a02cc65cc567db6101ea4afa275ff36) TaleWorlds.MountAndBlade.UsableMachine.ActiveWaitStandingPoint | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a9ad82c6fc37cc8e8dae58fad8e86c536)\_areUsableStandingPointsVacant
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.UsableMachine.\_areUsableStandingPointsVacant = true | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#acceb99a464c9fe94cb4d45422574c14f)\_usableStandingPoints
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<ValueTuple<int, [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html)> > TaleWorlds.MountAndBlade.UsableMachine.\_usableStandingPoints | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#afc1ae7bcf297dfa730f4974194ef0688)\_isDetachmentRecentlyEvaluated
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.UsableMachine.\_isDetachmentRecentlyEvaluated = false | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a234a71f65242db22ab72e6b2d7ddc5eb)EnemyRangeToStopUsing
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.UsableMachine.EnemyRangeToStopUsing = 0.0f | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#ab2c95215b7cc9b9ca0d4ddc7fbc6e264)MachinePositionOffsetToStopUsingLocal
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.UsableMachine.MachinePositionOffsetToStopUsingLocal = Vec2.Zero | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a3139a0f8f431878512d2abecb54b1eb5)MakeVisibilityCheck
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.UsableMachine.MakeVisibilityCheck = true | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a53245d1ef6a75419bcee9f8765c2554b)IsDisabledForAttackerAIDueToEnemyInRange
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | QueryData<bool> TaleWorlds.MountAndBlade.UsableMachine.IsDisabledForAttackerAIDueToEnemyInRange | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a915dc3567db757f9cecb0d79b068614c)IsDisabledForDefenderAIDueToEnemyInRange
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | QueryData<bool> TaleWorlds.MountAndBlade.UsableMachine.IsDisabledForDefenderAIDueToEnemyInRange | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#af1654cd4b1c325706b1fc015c4237c71)\_userFormations
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBList<[Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html)> TaleWorlds.MountAndBlade.UsableMachine.\_userFormations | | protected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a4e09ef1e05b6ac1ae22b44e47f0a730e)StandingPoints
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBList<[StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html)> TaleWorlds.MountAndBlade.UsableMachine.StandingPoints | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a43473add87f178c67da5189bd2422881)PilotStandingPoint
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) TaleWorlds.MountAndBlade.UsableMachine.PilotStandingPoint | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#aac70384d67ee40b12fd4b8ca5d7ec920)PilotStandingPointSlotIndex
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.UsableMachine.PilotStandingPointSlotIndex | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a31dd39d00c0df78b9ba04690253c2e34)WaitStandingPoints
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[GameEntity](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0a02cc65cc567db6101ea4afa275ff36)> TaleWorlds.MountAndBlade.UsableMachine.WaitStandingPoints | | getprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a1d7a12ec58f38303f4c811aac0d4ecc1)DestructionComponent
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [DestructableComponent](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html) TaleWorlds.MountAndBlade.UsableMachine.DestructionComponent | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#ac894856ee3eb7cf48c740bc071b3214e)IsDestructible
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.UsableMachine.IsDestructible | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a6626d316662f75afd5342feda7224665)IsDestroyed
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.UsableMachine.IsDestroyed | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#afa83e992adead73fdbfca2ce707bcd3d)PilotAgent
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) TaleWorlds.MountAndBlade.UsableMachine.PilotAgent | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#aca1e3b6c22ea4ce05497c4b435d51eb6)IsLoose
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.UsableMachine.IsLoose | | get |

Implements [TaleWorlds.MountAndBlade.IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#ab8aa0c3047a6963ac8a641c31b3adb57).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a2d630e0ef538af729106ffc6ba820d62)SinkingReferenceOffset
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual float TaleWorlds.MountAndBlade.UsableMachine.SinkingReferenceOffset | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a6bf668c5d7a9d1db972f446914aee8c4)Ai
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [UsableMachineAIBase](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html) TaleWorlds.MountAndBlade.UsableMachine.Ai | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#abcbb0aa3eb7586452c6012a8786b8b41)FocusableObjectType
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual [FocusableObjectType](namespace_tale_worlds_1_1_mount_and_blade.html#aa83361d8fb674ed9b16444d43d30d141) TaleWorlds.MountAndBlade.UsableMachine.FocusableObjectType | | get |

Implements [TaleWorlds.MountAndBlade.IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html#ad45e6dc0d435f66db8f1dee1055b18d6).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a8601d28166f23a8f850eb90d1d86f3c4)IsFocusable
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual bool TaleWorlds.MountAndBlade.UsableMachine.IsFocusable | | get |

Implements [TaleWorlds.MountAndBlade.IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html#a1acaf86c44c33cbc58c6c9b88dcd682c).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#ae96425b918bfcce099aafa9813c2fdb3)CurrentlyUsedAmmoPickUpPoint
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) TaleWorlds.MountAndBlade.UsableMachine.CurrentlyUsedAmmoPickUpPoint | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a169ee8692dcf8e5367ff6540287fee6b)HasAIPickingUpAmmo
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.UsableMachine.HasAIPickingUpAmmo | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#ac46bbe4526dd462d8b3607b4e9c313e4)IsDisabledForAI
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.UsableMachine.IsDisabledForAI | | getprotected set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a063bc1ab0685f631a3d6c4c587a91e4b)UserFormations
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html)> TaleWorlds.MountAndBlade.UsableMachine.UserFormations | | get |

Implements [TaleWorlds.MountAndBlade.IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a42ddcfd10b9ead1eb8da56ee1397c317).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a84710718891666308e423d2db5da534d)UserCountNotInStruckAction
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.UsableMachine.UserCountNotInStruckAction | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#ae3d04cb7f9332a3342e831f4b54b5449)UserCountIncludingInStruckAction
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.UsableMachine.UserCountIncludingInStruckAction | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a9e05fc11a3274ecb5017cc0dcf85c542)MaxUserCount
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual int TaleWorlds.MountAndBlade.UsableMachine.MaxUserCount | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#afb2f60fdb64a03d99fe43c24c2418d46)HasWaitFrame
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual bool TaleWorlds.MountAndBlade.UsableMachine.HasWaitFrame | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#aae80c64f159ba9ac8cae26bfdc8401dd)WaitFrame
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.UsableMachine.WaitFrame | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a53d7f1c2433c6162c43f8131b63c6f7a)WaitEntity
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GameEntity](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0a02cc65cc567db6101ea4afa275ff36) TaleWorlds.MountAndBlade.UsableMachine.WaitEntity | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a8f0c5d843d87777aef51cc19ee08bac2)IsDeactivated
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual bool TaleWorlds.MountAndBlade.UsableMachine.IsDeactivated | | get |

