--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html ---

TaleWorlds.MountAndBlade.SiegeLadder Class ReferenceInherits [TaleWorlds.MountAndBlade.SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html), [TaleWorlds.MountAndBlade.IPrimarySiegeWeapon](interface_tale_worlds_1_1_mount_and_blade_1_1_i_primary_siege_weapon.html), [TaleWorlds.MountAndBlade.IOrderableWithInteractionArea](interface_tale_worlds_1_1_mount_and_blade_1_1_i_orderable_with_interaction_area.html), and [TaleWorlds.MountAndBlade.Objects.Siege.ISpawnable](interface_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_i_spawnable.html).

|  |  |
| --- | --- |
| Classes | |
| struct | [SiegeLadderRecord](struct_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder_1_1_siege_ladder_record.html) |

|  |  |
| --- | --- |
| Public Types | |
| enum | [LadderState](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a8f3d437ebfbdd90edb2f0e1bd5f0d6ca) {     [OnLand](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a8f3d437ebfbdd90edb2f0e1bd5f0d6caaba4e0b1f904bead06c55c422120def90) ,     [FallToLand](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a8f3d437ebfbdd90edb2f0e1bd5f0d6caaf1bb06be5c6f31c5b617bb26a7560f9e) ,     [BeingRaised](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a8f3d437ebfbdd90edb2f0e1bd5f0d6caac89ee1c43b1340673dad73140acadcab) ,     [BeingRaisedStartFromGround](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a8f3d437ebfbdd90edb2f0e1bd5f0d6caa8e3c238b216a0c00c81dac1f1d4087e5) ,     [BeingRaisedStopped](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a8f3d437ebfbdd90edb2f0e1bd5f0d6caa430948a694362c96cd8526179901d94d) ,     [OnWall](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a8f3d437ebfbdd90edb2f0e1bd5f0d6caa97306066dac1dbaedc9c648edc692105) ,     [FallToWall](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a8f3d437ebfbdd90edb2f0e1bd5f0d6caa5ffe44842cbf3081e3dfa63ee00fd824) ,     [BeingPushedBack](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a8f3d437ebfbdd90edb2f0e1bd5f0d6caa658447c8552422baba06c15aa7546686) ,     [BeingPushedBackStartFromWall](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a8f3d437ebfbdd90edb2f0e1bd5f0d6caa50be56cfc702436de72347c8ef1ec6b8) ,     [BeingPushedBackStopped](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a8f3d437ebfbdd90edb2f0e1bd5f0d6caa5d9a733a128ed4a7e2168bb39951337c) ,     [NumberOfStates](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a8f3d437ebfbdd90edb2f0e1bd5f0d6caa78d6d95a0773a734f15e0b31bba59359)   } |
| enum | [LadderAnimationState](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a5a62e29b52e6951be6ebdd7df9e5baff) {     [Static](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a5a62e29b52e6951be6ebdd7df9e5baffa84a8921b25f505d0d2077aeb5db4bc16) ,     [Animated](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a5a62e29b52e6951be6ebdd7df9e5baffa0a21b95b6f230fe4bfc1db9aa2defad9) ,     [PhysicallyDynamic](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a5a62e29b52e6951be6ebdd7df9e5baffa67e9774920467cc24324daa0a4509aaf) ,     [NumberOfStates](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a5a62e29b52e6951be6ebdd7df9e5baffa78d6d95a0773a734f15e0b31bba59359)   } |
| Public Types inherited from [TaleWorlds.MountAndBlade.SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html) | |
| enum | [SynchFlags](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5ca) : uint {     [SynchNone](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5caa2da4e8e99f2913602376d36f8089a315) = 0x00000000 ,     [SynchTransform](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5caaa2b2f6339ae0b34de079c6d36495701a) = 0x00000001 ,     [SynchAnimation](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5caa896890ac2c4ab8db6aa3d8aa54201e2f) = 0x00000002 ,     [SynchBodyFlags](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5caabe8d4d441f6ffd28e6c51f8f3c7be862) = 0x00000004 ,     [SyncColors](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5caa10774fbeeb25df50516d9b754652622a) = 0x00000008 ,     [SynchAll](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5caa86cdc154b35c72e83e8b91718295bd3a) = 0xffffffff   } |
| Public Types inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| enum | [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) : uint {     [None](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da6adf97f83acf6453d4a6a4b1070f3754) = 0x00000000 ,     [TickOccasionally](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da9cee052f50afabfc1098c1aa6af80b75) = 0x00000001 ,     [Tick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0b3516a5bbb77566f904f9d3877f4710) = 0x00000002 ,     [TickParallel](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da5f5a8f4b9ce783164665db4d70e03ee3) = 0x00000004 ,     [TickParallel2](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0ea9f0c260cdfd8b20ce19a48dbc329f) = 0x00000008 ,     [FixedTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154dadd067942f0b8cc66859698bc9711ba15) = 0x00000010 ,     [FixedParallelTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daa226d712a5ffd8d400f850393ff68492) = 0x00000020 ,     [TickParallel3](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daf785c2c005d708ea434168efc10611b8) = 0x00000040   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| override [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | [GetSiegeEngineType](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a9d91a88168d9a5cc1b579c841e92407f) () |
| override [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) | [GetOrder](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a0279c1fe169ce144c0be843a9d338c64) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| bool | [HasCompletedAction](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a84b1cfb6e21344172ad600373a497955) () |
| override bool | [IsDisabledForBattleSide](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a0ae882415b8ee812df50630764c43558) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) sideEnum) |
| override [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) | [GetTickRequirement](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#aff40799f62a49e614c1b049f25908cf5) () |
| override [UsableMachineAIBase](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html) | [CreateAIBehaviorObject](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#ac0a74dc17b9a4a8ee7040ca8f04e047f) () |
| void | [SetUpStateVisibility](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a2d3382d5f6bcb103d643e3c2b2414bc5) (bool isVisible) |
| override void | [SetAbilityOfFaces](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a4876f4c44728a4d2297918cb6442540c) (bool enabled) |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetDescriptionText](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#af75de6b143432318d41db7b794f60124) ([WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity) |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetActionTextForStandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a7c6d2e481446034577565383b26a38ca) ([UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) usableGameObject) |
| override void | [WriteToNetwork](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a92ab6420480351555b1793bbb73c4197) () |
| override [TargetFlags](namespace_tale_worlds_1_1_mount_and_blade.html#a54230c76514f63e19c2e14dfedae9fb4) | [GetTargetFlags](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a26e1c7f7415b3088b570682b0dad7466) () |
| override float | [GetTargetValue](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a801822eefc478a336a1b871540c69129) (List< [Vec3](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a9bff92ab19906860837e7fa21126ee13) > weaponPos) |
| void | [SetSpawnedFromSpawner](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a6d54e48d0dee8f905b67bb95e9d018bb) () |
| override void | [OnAfterReadFromNetwork](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a768b7a2a1cc3c045aec643ecdef27015) (([BaseSynchedMissionObjectReadableRecord](struct_tale_worlds_1_1_mount_and_blade_1_1_base_synched_mission_object_readable_record.html), [ISynchedMissionObjectReadableRecord](interface_tale_worlds_1_1_mount_and_blade_1_1_i_synched_mission_object_readable_record.html)) synchedMissionObjectReadableRecord, bool allowVisibilityUpdate=true) |
| void | [AssignParametersFromSpawner](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a1398a8807380da4575cb946bc3100a6a) (string sideTag, string targetWallSegment, int onWallNavMeshId, float downStateRotationRadian, float upperStateRotationRadian, string barrierTagToRemove, string indestructibleMerlonsTag) |
| bool | [GetNavmeshFaceIds](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#aad76e76bbe32be585ca594e5e1f194e3) (out List< int > navmeshFaceIds) |
| void | [OnFormationFrameChanged](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a08cea5a165574e666faebeebcd2e6c9f) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, bool hasFrame, [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) position) |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html) | |
| void | [SetForcedUse](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#aa7281b56ed9eaf77371d4653b20f6476) (bool value) |
| [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | [GetSiegeEngineType](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#aeb9f69a5adb9db236d18d0dda0ed620c) () |
| override [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) | [GetTickRequirement](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a3023b7394a73525a663a27ab3d174321) () |
| void | [TickAuxForInit](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#aa5477d360a4b6283869f587ddca89aef) () |
| override bool | [ShouldAutoLeaveDetachmentWhenDisabled](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a8b14aadd795b8738e1c9100f886b0651) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) sideEnum) |
| override bool | [AutoAttachUserToFormation](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a12e65015f5e841b9557060581a02dee8) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) sideEnum) |
| override bool | [HasToBeDefendedByUser](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#aa23df3bbf9018070ed1e0b14b2039752) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) sideEnum) |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | [GetTargetEntity](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a55e93698cedbb4963a503758475ee251) () |
| [Vec3](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a9bff92ab19906860837e7fa21126ee13) | [GetTargetingOffset](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a3ebe3ad09b2d50e66cec54412f88135f) () |
| [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | [GetSide](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a1efe44f7f390ec3bb08e77e66c8068d0) () |
| [Vec3](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a9bff92ab19906860837e7fa21126ee13) | [GetTargetGlobalVelocity](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#abe922cfc407185f4b0a40cfd0b987d0e) () |
| bool | [IsDestructable](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a29cebb1d01706f1efff91c6530e6640a) () |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | [Entity](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a9b9aa4f3be2d18eeb037283c8ace843d) () |
| [Vec3](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a9bff92ab19906860837e7fa21126ee13) | [ComputeGlobalPhysicsBoundingBoxMinMax](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a4305cb6425e1ceaf57e8573c6113a189) () |
| virtual void | [OnShipCaptured](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#ac4ae2bf7382bcde7b7665bd5243562e2) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) newDefaultSide) |
| [TargetFlags](namespace_tale_worlds_1_1_mount_and_blade.html#a54230c76514f63e19c2e14dfedae9fb4) | [GetTargetFlags](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a5e92e28256a00dbfed4037dfe754aaac) () |
| float | [GetTargetValue](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a0f45ce6a53a41d4b0143f7a7d08e995d) (List< [Vec3](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a9bff92ab19906860837e7fa21126ee13) > weaponPos) |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) | |
| void | [AddComponent](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a35b3b37ed3d8bd65301a2c598c618de2) ([UsableMissionObjectComponent](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object_component.html) component) |
| void | [RemoveComponent](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#ae9a927027a7b66ea04d6f34888290b63) ([UsableMissionObjectComponent](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object_component.html) component) |
| T | [GetComponent< T >](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a6f7a8e0718688e9d630852f124a70fbc) () |
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
| virtual bool | [IsDisabledForBattleSideAI](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a5f3f910b34b937da3eba99d858e7e6b2) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) sideEnum) |
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
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | |
|  | [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a4eaa53f5b1c5e3af4d4189e099c8e05e) () |
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
| string | [AttackerTag](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#aa87ece2c2349a487e1296c163429f64e) = "attacker" |
| string | [DefenderTag](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a18944c6e95d0134aaee0cc128c4454e1) = "defender" |
| string | [downStateEntityTag](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a601335f1d644f96403f8757d92541be8) = "ladderDown" |
| string | [IdleAnimation](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a8bf236ad9ed2f47722512b9d79218e85) = "siege\_ladder\_idle" |
| int | [\_idleAnimationIndex](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a3a850c0d1a30f6062bd7cd442067d946) = -1 |
| string | [RaiseAnimation](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#aa6a94b7a07bd0229300bc907de9a4d2c) = "siege\_ladder\_rise" |
| string | [RaiseAnimationWithoutRootBone](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a459f020b2c1c9c323f4f05ccebf40e28) = "siege\_ladder\_rise\_wo\_rootbone" |
| int | [\_raiseAnimationWithoutRootBoneIndex](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a909c107712d78a69aa07a3239fdd20ff) = -1 |
| string | [PushBackAnimation](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a065f988b45e47d734015776d48d3638d) = "siege\_ladder\_push\_back" |
| int | [\_pushBackAnimationIndex](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a210fceb2e07e6a6029eef39d32bafc4b) = -1 |
| string | [PushBackAnimationWithoutRootBone](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#acb76500afd9a8219f0bf7ff8604bc926) = "siege\_ladder\_push\_back\_wo\_rootbone" |
| int | [\_pushBackAnimationWithoutRootBoneIndex](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a79d8084be8add34b38e90b947f078554) = -1 |
| string | [TrembleWallHeavyAnimation](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a48d72baeec1a0ca3aa980f947dac6a71) = "siege\_ladder\_stop\_wall\_heavy" |
| string | [TrembleWallLightAnimation](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#ac91a5b091ef1f452e60b62fbdd508668) = "siege\_ladder\_stop\_wall\_light" |
| string | [TrembleGroundAnimation](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#ad725200c1159a6e294026d72ad978a0a) = "siege\_ladder\_stop\_ground\_heavy" |
| string | [RightStandingPointTag](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#ac4e612d4cad28db2ebff41b5da6d75c4) = "right" |
| string | [LeftStandingPointTag](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a9bc36de1fd3864a8fd78ccb847218c00) = "left" |
| string | [FrontStandingPointTag](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a266ba67765a36dcc03e40941f87ef035) = "front" |
| string | [PushForkItemID](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a5ea509a9aa21da31b8f015a1baebc401) = "push\_fork" |
| string | [upStateEntityTag](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#ac1fa4fd973a04f10ac7b266269a4b7b9) = "ladderUp" |
| string | [BodyTag](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#aa6a7b7190793ea418e23ad3d572eaaa1) = "ladder\_body" |
| string | [CollisionBodyTag](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#ab6f20070a48b0c5537acb04745e86841) = "ladder\_collision\_body" |
| string | [InitialWaitPositionTag](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#aa2f5737a429fe80414dff45bcc4f5d86) = "initialwaitposition" |
| float | [LadderPushTreshold](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a6a53863324e074d727ecad809a20d05d) = 170.0f |
| float | [LadderPushTresholdForOneAgent](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#af0982d44fd30c20d77083140963cacb1) = 55.0f |
| string | [BarrierTagToRemove](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a46b8e32456054e7b409674759a87291a) = "barrier" |
| [LadderState](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a8f3d437ebfbdd90edb2f0e1bd5f0d6ca) | [initialState](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a4df8b61e4b79ed59568312e7f87f2780) = [LadderState.OnLand](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a8f3d437ebfbdd90edb2f0e1bd5f0d6caaba4e0b1f904bead06c55c422120def90) |
| string | [IndestructibleMerlonsTag](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a28faed0cab4eaf75e0a80c31a5975677) = string.Empty |
| Public Attributes inherited from [TaleWorlds.MountAndBlade.SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html) | |
|  | [Vec3](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a9bff92ab19906860837e7fa21126ee13) |
| Public Attributes inherited from [TaleWorlds.MountAndBlade.UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) | |
| string | [PilotStandingPointTag](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a27274ccfbfea192b85857d456397a5b8) = "Pilot" |
| string | [AmmoPickUpTag](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a72018b9873164ff073991e34beb3532f) = "ammopickup" |
| string | [WaitStandingPointTag](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a9718490c262e4c207d77b17cf0b9c340) = "Wait" |
| Public Attributes inherited from [TaleWorlds.MountAndBlade.ITargetable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_targetable.html) | |
|  | [Vec3](interface_tale_worlds_1_1_mount_and_blade_1_1_i_targetable.html#a3ed452285ffcd12f5f9f3c1e6efd3db7) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const float | [ClimbingLimitRadian](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a487043aaa38d8929027004bef1c3b797) = -([MathF.HalfPI](class_tale_worlds_1_1_library_1_1_math_f.html#a366f162feaeb24f21a0842870cf7439c) - 1.369438f) |
| const float | [ClimbingLimitDegree](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a9acf7e2500007dcded3e2a3bd755bf68) = [ClimbingLimitRadian](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a487043aaa38d8929027004bef1c3b797) \* [MathF.RadToDeg](class_tale_worlds_1_1_library_1_1_math_f.html#ae193e88db4d27bd654848c5e3c43e6ec) |
| const float | [AutomaticUseActivationRange](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a4b1db4102ba4136096770e95143a293b) = 20f |
| Static Public Attributes inherited from [TaleWorlds.MountAndBlade.UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) | |
| const string | [UsableMachineParentTag](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a010d494a549acc4496826c009dffe185) = "machine\_parent" |
| Static Public Attributes inherited from [TaleWorlds.MountAndBlade.MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | |
| const int | [MaxNavMeshPerDynamicObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#ad33e7f4aeb39643c81e3f22ae208d9e1) = 50 |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override float | [GetDetachmentWeightAux](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a59e8f938f83a5637227fa917551ed5aa) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| override float | [GetDistanceMultiplierOfWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a18a4f374eb29326bd2bbb57b2b9bec17) ([Vec3](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a9bff92ab19906860837e7fa21126ee13) weaponPos) |
| override [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) | [GetSuitableStandingPointFor](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a11fd88f464c34e0855a01a2bda72dbe8) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent=null, List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > agents=null, List< ValueTuple< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), float > > agentValuePairs=null) |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html) | |
| virtual bool | [CalculateIsSufficientlyManned](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a5f6d63a7ed8384f16b9070b43e12c517) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) battleSide) |
| virtual bool | [IsAnyUserBelongsToFormation](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a6d4dd0112706199bcf940a1632cf0e61) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| float | [GetUserMultiplierOfWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#aa8c3c52a20f74a40ef46b80c41ce4780) () |
| virtual float | [GetMinimumDistanceBetweenPositions](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#ae5ac4098a350dfd36975093c4e0449ff) ([Vec3](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a9bff92ab19906860837e7fa21126ee13) position) |
| float | [GetHitPointMultiplierOfWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a7d1f373b1026ad9474405e767baaf556) () |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) | |
|  | [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#ac5fe63ebe9d4d5b7d6e31521577178ee) () |
| virtual void | [DebugTick](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#acb4973db4969533a42bf0dc4ea27de3a) (float dt) |
| bool | [IsDisabledDueToEnemyInRange](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#afb7df349a54b2ffcb85c2c6e7c60e373) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) sideEnum) |
| override void | [OnRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#abc7226debc7d7f91ee2db48317dd9ca7) (int removeReason) |
| virtual float | [GetWeightOfStandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a1799fb6802848c721ca165fbe39b6f23) ([StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) sp) |
| virtual bool | [IsAgentOnInconvenientNavmesh](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a231d4a00adb93489d694947f3ddfc84d) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) standingPoint) |
| virtual bool | [ShouldDisableTickIfMachineDisabled](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#ac6935984e4f8f54115a62b891e4b1786) () |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | |
| virtual void | [AttachDynamicNavmeshToEntity](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a96b0e630894be6b18d6395ad12f811ac) () |
| virtual [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | [GetEntityToAttachNavMeshFaces](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a91b69e394d98f64d45604ee179496bb3) () |
| Protected Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [InvalidateWeakPointersIfValid](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#af39d73d0c78790ba81a40a5a350c0526) () |
|  | [ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0bc136bb53989f2b9a4f23f12f54a332) () |

|  |  |
| --- | --- |
| Properties | |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0a02cc65cc567db6101ea4afa275ff36) | [InitialWaitPosition](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#ac2383d7ef0c5bbf422da32d55b66dc83) `[get]` |
| int | [OnWallNavMeshId](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#ab9dbb1036eb23506985250394f76f54a) = 0 `[get]` |
| [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | [TargetCastlePosition](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#aa43a8fe4865491eab2aff6540ff3594a) `[get]` |
| [FormationAI.BehaviorSide](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#af0e557fbaea88404cb872c1bc2b7912b) | [WeaponSide](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#adf2abde222925a1bfe355aefb6f15d3b) `[get]` |
| float | [SiegeWeaponPriority](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#ab3c781b180b3894958e3b2a584c62b16) `[get]` |
| int | [OverTheWallNavMeshID](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#af99d19268993a6aea9feae6d8be8cade) `[get]` |
| [LadderState](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a8f3d437ebfbdd90edb2f0e1bd5f0d6ca) | [State](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#ad252360d6fd0e0884c631fefe2162f49) `[get, set]` |
| bool | [HoldLadders](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#add354d1e390881709896af76c34da1fe) `[get]` |
| bool | [SendLadders](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a47cfca2814a9b23245d5ff3985750f04) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html) | |
| bool | [ForcedUse](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#aae04b0f6c7641d70770c60281eb539d2) `[get]` |
| bool | [IsUsed](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a3b2c6bb2cecba407f3723ac59d013192) `[get]` |
| virtual [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | [Side](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a25506e8be457e2c2df2a719ee44b2cc5) `[get]` |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [HitObjectName](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a3b79d9ee6471f008f305bb010a460062) `[get]` |
| override bool | [HasWaitFrame](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a31d09c10daffac0b4f7adcf50eaa9908) `[get]` |
| override bool | [IsDeactivated](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a42d624362ab0bcc79dad8890b39cf03d) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) | |
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
| Protected Types inherited from [TaleWorlds.MountAndBlade.MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | |
| enum | [DynamicNavmeshLocalIds](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90b) : int {     [Inside](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90ba9b6d3000134648fc9f1e71094ae0847d) = 1 ,     [Enter](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90baf1851d5600eae616ee802a31ac74701b) = 2 ,     [Exit](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90bafef46e5063ce3dc78b8ae64fa474241d) = 3 ,     [Blocker](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90bada32a1684e943a766fec67b13009be79) = 4 ,     [Extra1](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90ba113f84d105af2b8016b3896117c9deab) = 5 ,     [Extra2](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90ba83dca46dd08ad782e968d586375715e1) = 6 ,     [Extra3](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90bab7f54183dc84b2982ebe161b9c59f2d9) = 7 ,     [Reserved1](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90ba93876cb309016fa725517b046474c44b) = 9 ,     [Count](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90bae93f994f01c537c4e2f7d8528c3eb5e9)   } |
| Protected Attributes inherited from [TaleWorlds.MountAndBlade.SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html) | |
| bool | [\_spawnedFromSpawner](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a59b27fd1762d3b7acb25cb8d2d3d2220) = false |
| Protected Attributes inherited from [TaleWorlds.MountAndBlade.UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) | |
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

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a8f3d437ebfbdd90edb2f0e1bd5f0d6ca)LadderState
-------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.SiegeLadder.LadderState](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a8f3d437ebfbdd90edb2f0e1bd5f0d6ca) |

| Enumerator | |
| --- | --- |
| OnLand |  |
| FallToLand |  |
| BeingRaised |  |
| BeingRaisedStartFromGround |  |
| BeingRaisedStopped |  |
| OnWall |  |
| FallToWall |  |
| BeingPushedBack |  |
| BeingPushedBackStartFromWall |  |
| BeingPushedBackStopped |  |
| NumberOfStates |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a5a62e29b52e6951be6ebdd7df9e5baff)LadderAnimationState
----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.SiegeLadder.LadderAnimationState](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a5a62e29b52e6951be6ebdd7df9e5baff) |

| Enumerator | |
| --- | --- |
| Static |  |
| Animated |  |
| PhysicallyDynamic |  |
| NumberOfStates |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a9d91a88168d9a5cc1b579c841e92407f)GetSiegeEngineType()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) TaleWorlds.MountAndBlade.SiegeLadder.GetSiegeEngineType | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a0279c1fe169ce144c0be843a9d338c64)GetOrder()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) TaleWorlds.MountAndBlade.SiegeLadder.GetOrder | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a1cb5d50fdbbeb6cfdfd5106bfbde0ab5).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a84b1cfb6e21344172ad600373a497955)HasCompletedAction()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.SiegeLadder.HasCompletedAction | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IPrimarySiegeWeapon](interface_tale_worlds_1_1_mount_and_blade_1_1_i_primary_siege_weapon.html#ad6dd66df1468ead07dcee65e801db366).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a0ae882415b8ee812df50630764c43558)IsDisabledForBattleSide()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override bool TaleWorlds.MountAndBlade.SiegeLadder.IsDisabledForBattleSide | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *sideEnum* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#af346e6bcdeb8bf6ab98835181779fb75).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a59e8f938f83a5637227fa917551ed5aa)GetDetachmentWeightAux()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override float TaleWorlds.MountAndBlade.SiegeLadder.GetDetachmentWeightAux | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#aaed333395ea45e95254004c01602c785).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#aff40799f62a49e614c1b049f25908cf5)GetTickRequirement()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) TaleWorlds.MountAndBlade.SiegeLadder.GetTickRequirement | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ac17100a83d592505ed8d9ac565e512a5).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#ac0a74dc17b9a4a8ee7040ca8f04e047f)CreateAIBehaviorObject()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [UsableMachineAIBase](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html) TaleWorlds.MountAndBlade.SiegeLadder.CreateAIBehaviorObject | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#abbf63ca39c7d9d26a2bd8e6bc3458c6d).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a2d3382d5f6bcb103d643e3c2b2414bc5)SetUpStateVisibility()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SiegeLadder.SetUpStateVisibility | ( | bool | *isVisible* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a4876f4c44728a4d2297918cb6442540c)SetAbilityOfFaces()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.SiegeLadder.SetAbilityOfFaces | ( | bool | *enabled* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#ad02ae6fa04bfdc79f9fcd010afbff84e).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#af75de6b143432318d41db7b794f60124)GetDescriptionText()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.MountAndBlade.SiegeLadder.GetDescriptionText | ( | [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity* | ) |  |

Implements [TaleWorlds.MountAndBlade.IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html#ae296d89b1b2262987e2a6c7bb88368f8).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a7c6d2e481446034577565383b26a38ca)GetActionTextForStandingPoint()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.MountAndBlade.SiegeLadder.GetActionTextForStandingPoint | ( | [UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) | *usableGameObject* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a92ab6420480351555b1793bbb73c4197)WriteToNetwork()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.SiegeLadder.WriteToNetwork | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#ae2659d0b019f69ee37de2d69beb032ce).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a26e1c7f7415b3088b570682b0dad7466)GetTargetFlags()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [TargetFlags](namespace_tale_worlds_1_1_mount_and_blade.html#a54230c76514f63e19c2e14dfedae9fb4) TaleWorlds.MountAndBlade.SiegeLadder.GetTargetFlags | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.ITargetable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_targetable.html#a4896040b596dbef060fe758288c6dc50).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a801822eefc478a336a1b871540c69129)GetTargetValue()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.SiegeLadder.GetTargetValue | ( | List< [Vec3](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a9bff92ab19906860837e7fa21126ee13) > | *weaponPos* | ) |  |

Implements [TaleWorlds.MountAndBlade.ITargetable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_targetable.html#a1886be0506013fe8a507455e8757cabd).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a18a4f374eb29326bd2bbb57b2b9bec17)GetDistanceMultiplierOfWeapon()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override float TaleWorlds.MountAndBlade.SiegeLadder.GetDistanceMultiplierOfWeapon | ( | [Vec3](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a9bff92ab19906860837e7fa21126ee13) | *weaponPos* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a39de6efe184f0535c693834e75929440).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a11fd88f464c34e0855a01a2bda72dbe8)GetSuitableStandingPointFor()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) TaleWorlds.MountAndBlade.SiegeLadder.GetSuitableStandingPointFor | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* = null, | |  |  | List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | *agents* = null, | |  |  | List< ValueTuple< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), float > > | *agentValuePairs* = null ) | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#ac21beefc597d31859f29689b192f30a5).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a6d54e48d0dee8f905b67bb95e9d018bb)SetSpawnedFromSpawner()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SiegeLadder.SetSpawnedFromSpawner | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.Objects.Siege.ISpawnable](interface_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_i_spawnable.html#a6f1e5c34a0ebdc75c2994ea0dac85607).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a768b7a2a1cc3c045aec643ecdef27015)OnAfterReadFromNetwork()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.SiegeLadder.OnAfterReadFromNetwork | ( | ([BaseSynchedMissionObjectReadableRecord](struct_tale_worlds_1_1_mount_and_blade_1_1_base_synched_mission_object_readable_record.html), [ISynchedMissionObjectReadableRecord](interface_tale_worlds_1_1_mount_and_blade_1_1_i_synched_mission_object_readable_record.html)) | *synchedMissionObjectReadableRecord*, | |  |  | bool | *allowVisibilityUpdate* = true ) | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a4709dc8d1a0b3228df3c8e630e40a58a).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a1398a8807380da4575cb946bc3100a6a)AssignParametersFromSpawner()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SiegeLadder.AssignParametersFromSpawner | ( | string | *sideTag*, |
|  |  | string | *targetWallSegment*, |
|  |  | int | *onWallNavMeshId*, |
|  |  | float | *downStateRotationRadian*, |
|  |  | float | *upperStateRotationRadian*, |
|  |  | string | *barrierTagToRemove*, |
|  |  | string | *indestructibleMerlonsTag* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#aad76e76bbe32be585ca594e5e1f194e3)GetNavmeshFaceIds()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.SiegeLadder.GetNavmeshFaceIds | ( | out List< int > | *navmeshFaceIds* | ) |  |

Implements [TaleWorlds.MountAndBlade.IPrimarySiegeWeapon](interface_tale_worlds_1_1_mount_and_blade_1_1_i_primary_siege_weapon.html#abfcc7161e612e62115d31f8dd93a2ca5).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a08cea5a165574e666faebeebcd2e6c9f)OnFormationFrameChanged()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SiegeLadder.OnFormationFrameChanged | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | bool | *hasFrame*, |
|  |  | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *position* ) |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a487043aaa38d8929027004bef1c3b797)ClimbingLimitRadian
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.SiegeLadder.ClimbingLimitRadian = -([MathF.HalfPI](class_tale_worlds_1_1_library_1_1_math_f.html#a366f162feaeb24f21a0842870cf7439c) - 1.369438f) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a9acf7e2500007dcded3e2a3bd755bf68)ClimbingLimitDegree
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.SiegeLadder.ClimbingLimitDegree = [ClimbingLimitRadian](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a487043aaa38d8929027004bef1c3b797) \* [MathF.RadToDeg](class_tale_worlds_1_1_library_1_1_math_f.html#ae193e88db4d27bd654848c5e3c43e6ec) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a4b1db4102ba4136096770e95143a293b)AutomaticUseActivationRange
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.SiegeLadder.AutomaticUseActivationRange = 20f | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#aa87ece2c2349a487e1296c163429f64e)AttackerTag
-------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.SiegeLadder.AttackerTag = "attacker" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a18944c6e95d0134aaee0cc128c4454e1)DefenderTag
-------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.SiegeLadder.DefenderTag = "defender" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a601335f1d644f96403f8757d92541be8)downStateEntityTag
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.SiegeLadder.downStateEntityTag = "ladderDown" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a8bf236ad9ed2f47722512b9d79218e85)IdleAnimation
---------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.SiegeLadder.IdleAnimation = "siege\_ladder\_idle" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a3a850c0d1a30f6062bd7cd442067d946)\_idleAnimationIndex
----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.SiegeLadder.\_idleAnimationIndex = -1 |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#aa6a94b7a07bd0229300bc907de9a4d2c)RaiseAnimation
----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.SiegeLadder.RaiseAnimation = "siege\_ladder\_rise" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a459f020b2c1c9c323f4f05ccebf40e28)RaiseAnimationWithoutRootBone
-------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.SiegeLadder.RaiseAnimationWithoutRootBone = "siege\_ladder\_rise\_wo\_rootbone" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a909c107712d78a69aa07a3239fdd20ff)\_raiseAnimationWithoutRootBoneIndex
--------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.SiegeLadder.\_raiseAnimationWithoutRootBoneIndex = -1 |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a065f988b45e47d734015776d48d3638d)PushBackAnimation
-------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.SiegeLadder.PushBackAnimation = "siege\_ladder\_push\_back" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a210fceb2e07e6a6029eef39d32bafc4b)\_pushBackAnimationIndex
--------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.SiegeLadder.\_pushBackAnimationIndex = -1 |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#acb76500afd9a8219f0bf7ff8604bc926)PushBackAnimationWithoutRootBone
----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.SiegeLadder.PushBackAnimationWithoutRootBone = "siege\_ladder\_push\_back\_wo\_rootbone" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a79d8084be8add34b38e90b947f078554)\_pushBackAnimationWithoutRootBoneIndex
-----------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.SiegeLadder.\_pushBackAnimationWithoutRootBoneIndex = -1 |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a48d72baeec1a0ca3aa980f947dac6a71)TrembleWallHeavyAnimation
---------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.SiegeLadder.TrembleWallHeavyAnimation = "siege\_ladder\_stop\_wall\_heavy" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#ac91a5b091ef1f452e60b62fbdd508668)TrembleWallLightAnimation
---------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.SiegeLadder.TrembleWallLightAnimation = "siege\_ladder\_stop\_wall\_light" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#ad725200c1159a6e294026d72ad978a0a)TrembleGroundAnimation
------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.SiegeLadder.TrembleGroundAnimation = "siege\_ladder\_stop\_ground\_heavy" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#ac4e612d4cad28db2ebff41b5da6d75c4)RightStandingPointTag
-----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.SiegeLadder.RightStandingPointTag = "right" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a9bc36de1fd3864a8fd78ccb847218c00)LeftStandingPointTag
----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.SiegeLadder.LeftStandingPointTag = "left" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a266ba67765a36dcc03e40941f87ef035)FrontStandingPointTag
-----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.SiegeLadder.FrontStandingPointTag = "front" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a5ea509a9aa21da31b8f015a1baebc401)PushForkItemID
----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.SiegeLadder.PushForkItemID = "push\_fork" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#ac1fa4fd973a04f10ac7b266269a4b7b9)upStateEntityTag
------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.SiegeLadder.upStateEntityTag = "ladderUp" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#aa6a7b7190793ea418e23ad3d572eaaa1)BodyTag
---------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.SiegeLadder.BodyTag = "ladder\_body" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#ab6f20070a48b0c5537acb04745e86841)CollisionBodyTag
------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.SiegeLadder.CollisionBodyTag = "ladder\_collision\_body" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#aa2f5737a429fe80414dff45bcc4f5d86)InitialWaitPositionTag
------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.SiegeLadder.InitialWaitPositionTag = "initialwaitposition" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a6a53863324e074d727ecad809a20d05d)LadderPushTreshold
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.SiegeLadder.LadderPushTreshold = 170.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#af0982d44fd30c20d77083140963cacb1)LadderPushTresholdForOneAgent
-------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.SiegeLadder.LadderPushTresholdForOneAgent = 55.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a46b8e32456054e7b409674759a87291a)BarrierTagToRemove
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.SiegeLadder.BarrierTagToRemove = "barrier" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a4df8b61e4b79ed59568312e7f87f2780)initialState
--------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [LadderState](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a8f3d437ebfbdd90edb2f0e1bd5f0d6ca) TaleWorlds.MountAndBlade.SiegeLadder.initialState = [LadderState.OnLand](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a8f3d437ebfbdd90edb2f0e1bd5f0d6caaba4e0b1f904bead06c55c422120def90) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a28faed0cab4eaf75e0a80c31a5975677)IndestructibleMerlonsTag
--------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.SiegeLadder.IndestructibleMerlonsTag = string.Empty |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#ac2383d7ef0c5bbf422da32d55b66dc83)InitialWaitPosition
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GameEntity](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0a02cc65cc567db6101ea4afa275ff36) TaleWorlds.MountAndBlade.SiegeLadder.InitialWaitPosition | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#ab9dbb1036eb23506985250394f76f54a)OnWallNavMeshId
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.SiegeLadder.OnWallNavMeshId = 0 | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#aa43a8fe4865491eab2aff6540ff3594a)TargetCastlePosition
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) TaleWorlds.MountAndBlade.SiegeLadder.TargetCastlePosition | | get |

Implements [TaleWorlds.MountAndBlade.IPrimarySiegeWeapon](interface_tale_worlds_1_1_mount_and_blade_1_1_i_primary_siege_weapon.html#a5f3cf006ac29e3a56df07fca764a5bd8).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#adf2abde222925a1bfe355aefb6f15d3b)WeaponSide
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [FormationAI.BehaviorSide](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#af0e557fbaea88404cb872c1bc2b7912b) TaleWorlds.MountAndBlade.SiegeLadder.WeaponSide | | get |

Implements [TaleWorlds.MountAndBlade.IPrimarySiegeWeapon](interface_tale_worlds_1_1_mount_and_blade_1_1_i_primary_siege_weapon.html#a966ca954fd294a918598cd6614c8efda).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#ab3c781b180b3894958e3b2a584c62b16)SiegeWeaponPriority
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.SiegeLadder.SiegeWeaponPriority | | get |

Implements [TaleWorlds.MountAndBlade.IPrimarySiegeWeapon](interface_tale_worlds_1_1_mount_and_blade_1_1_i_primary_siege_weapon.html#a62b2ad4c0fd2e4f1a1bab9eb12d290cf).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#af99d19268993a6aea9feae6d8be8cade)OverTheWallNavMeshID
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.SiegeLadder.OverTheWallNavMeshID | | get |

Implements [TaleWorlds.MountAndBlade.IPrimarySiegeWeapon](interface_tale_worlds_1_1_mount_and_blade_1_1_i_primary_siege_weapon.html#aa6d60a18c21f3a094af9a230ad9aefe6).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#ad252360d6fd0e0884c631fefe2162f49)State
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [LadderState](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a8f3d437ebfbdd90edb2f0e1bd5f0d6ca) TaleWorlds.MountAndBlade.SiegeLadder.State | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#add354d1e390881709896af76c34da1fe)HoldLadders
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.SiegeLadder.HoldLadders | | get |

Implements [TaleWorlds.MountAndBlade.IPrimarySiegeWeapon](interface_tale_worlds_1_1_mount_and_blade_1_1_i_primary_siege_weapon.html#a8767c012083d205e56cba9676629038d).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a47cfca2814a9b23245d5ff3985750f04)SendLadders
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.SiegeLadder.SendLadders | | get |

Implements [TaleWorlds.MountAndBlade.IPrimarySiegeWeapon](interface_tale_worlds_1_1_mount_and_blade_1_1_i_primary_siege_weapon.html#aeec9e5c3da8927bd3c0b56aca6b2a78a).

