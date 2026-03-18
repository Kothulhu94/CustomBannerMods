--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html ---

TaleWorlds.MountAndBlade.BatteringRam Class ReferenceInherits [TaleWorlds.MountAndBlade.SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html), [TaleWorlds.MountAndBlade.IPathHolder](interface_tale_worlds_1_1_mount_and_blade_1_1_i_path_holder.html), [TaleWorlds.MountAndBlade.IPrimarySiegeWeapon](interface_tale_worlds_1_1_mount_and_blade_1_1_i_primary_siege_weapon.html), [TaleWorlds.MountAndBlade.IMoveableSiegeWeapon](interface_tale_worlds_1_1_mount_and_blade_1_1_i_moveable_siege_weapon.html), and [TaleWorlds.MountAndBlade.Objects.Siege.ISpawnable](interface_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_i_spawnable.html).

|  |  |
| --- | --- |
| Classes | |
| struct | [BatteringRamRecord](struct_tale_worlds_1_1_mount_and_blade_1_1_battering_ram_1_1_battering_ram_record.html) |

|  |  |
| --- | --- |
| Public Types | |
| enum | [RamState](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#ace723ee11f45a0b9af00494dc17233d2) {     [Stable](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#ace723ee11f45a0b9af00494dc17233d2afa3aff3c185c6dc7754235f397c2099a) ,     [Hitting](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#ace723ee11f45a0b9af00494dc17233d2aa03b8ffd108557a04d1b7d11c58a6c02) ,     [AfterHit](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#ace723ee11f45a0b9af00494dc17233d2a465f7fa627d8e48b92df9c7c7d1458b4) ,     [NumberOfStates](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#ace723ee11f45a0b9af00494dc17233d2a78d6d95a0773a734f15e0b31bba59359)   } |
| Public Types inherited from [TaleWorlds.MountAndBlade.SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html) | |
| enum | [SynchFlags](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5ca) : uint {     [SynchNone](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5caa2da4e8e99f2913602376d36f8089a315) = 0x00000000 ,     [SynchTransform](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5caaa2b2f6339ae0b34de079c6d36495701a) = 0x00000001 ,     [SynchAnimation](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5caa896890ac2c4ab8db6aa3d8aa54201e2f) = 0x00000002 ,     [SynchBodyFlags](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5caabe8d4d441f6ffd28e6c51f8f3c7be862) = 0x00000004 ,     [SyncColors](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5caa10774fbeeb25df50516d9b754652622a) = 0x00000008 ,     [SynchAll](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5caa86cdc154b35c72e83e8b91718295bd3a) = 0xffffffff   } |
| Public Types inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| enum | [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) : uint {     [None](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da6adf97f83acf6453d4a6a4b1070f3754) = 0x00000000 ,     [TickOccasionally](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da9cee052f50afabfc1098c1aa6af80b75) = 0x00000001 ,     [Tick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0b3516a5bbb77566f904f9d3877f4710) = 0x00000002 ,     [TickParallel](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da5f5a8f4b9ce783164665db4d70e03ee3) = 0x00000004 ,     [TickParallel2](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0ea9f0c260cdfd8b20ce19a48dbc329f) = 0x00000008 ,     [FixedTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154dadd067942f0b8cc66859698bc9711ba15) = 0x00000010 ,     [FixedParallelTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daa226d712a5ffd8d400f850393ff68492) = 0x00000020 ,     [TickParallel3](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daf785c2c005d708ea434168efc10611b8) = 0x00000040   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| bool | [HasCompletedAction](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#af37e3c781dd026a142b5c8e7592055e0) () |
| override void | [Disable](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#ab8668c0e9924ada7324b33e60f4f28eb) () |
| override [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | [GetSiegeEngineType](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a58f07e8288697c629cb86c1e5f12bed2) () |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetInitialFrame](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#ae1985e18f077723e1d24bb030d8e61d0) () |
| override [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) | [GetTickRequirement](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a41e7e41d85abbc7f97716805e5ca4a2a) () |
| override [UsableMachineAIBase](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html) | [CreateAIBehaviorObject](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a4690923b1dfc24c31eacd7a8ab0fa231) () |
| override void | [WriteToNetwork](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a4a88f84212f2f15007c512323e6cd5c4) () |
| void | [HighlightPath](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a58133c540f6e5e6bf36e37b57aa7a8f3) () |
| void | [SwitchGhostEntityMovementMode](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a650b9b7d57e6d26038ed16bf9b449571) (bool isGhostEnabled) |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetDescriptionText](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a4de21924a9d34f665d411f3642aca421) ([WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity) |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetActionTextForStandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#ac6071ecb0cb55d3e007bd1f7814a5ae2) ([UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) usableGameObject) |
| override [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) | [GetOrder](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#af8f64557c106fd6ba4e284d90c4f69eb) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| override [TargetFlags](namespace_tale_worlds_1_1_mount_and_blade.html#a54230c76514f63e19c2e14dfedae9fb4) | [GetTargetFlags](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#ac968d519652f3d012fdf39085fac0ca2) () |
| override float | [GetTargetValue](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a39cc9819565a3a91062a9b00a2673262) (List< [Vec3](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a9bff92ab19906860837e7fa21126ee13) > weaponPos) |
| void | [SetSpawnedFromSpawner](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a8e8e41913f2268e4d669eeb39303625d) () |
| void | [AssignParametersFromSpawner](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#ab925d327d0da069058a51ee12c1ad4d8) (string gateTag, string sideTag, int bridgeNavMeshID1, int bridgeNavMeshID2, int ditchNavMeshID1, int ditchNavMeshID2, int groundToBridgeNavMeshID1, int groundToBridgeNavMeshID2, string pathEntityName) |
| override void | [OnAfterReadFromNetwork](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a009d6de4ff91b34a81d2ecf43efd35a1) (([BaseSynchedMissionObjectReadableRecord](struct_tale_worlds_1_1_mount_and_blade_1_1_base_synched_mission_object_readable_record.html), [ISynchedMissionObjectReadableRecord](interface_tale_worlds_1_1_mount_and_blade_1_1_i_synched_mission_object_readable_record.html)) synchedMissionObjectReadableRecord, bool allowVisibilityUpdate=true) |
| bool | [GetNavmeshFaceIds](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a860805b45d615872ddf5d198e2e4ea21) (out List< int > navmeshFaceIds) |
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
| virtual bool | [IsDisabledForBattleSide](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#af346e6bcdeb8bf6ab98835181779fb75) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) sideEnum) |
| virtual bool | [IsDisabledForBattleSideAI](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a5f3f910b34b937da3eba99d858e7e6b2) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) sideEnum) |
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
| bool | [GhostEntityMove](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a26f8bb0400f8c396d8b64d6639542a53) = true |
| float | [GhostEntitySpeedMultiplier](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#af063eb925778640817b433902e957b80) = 1.0f |
| float | [WheelDiameter](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#add077c68465b92c56b08d5a94625d9e8) = 1.3f |
| int | [GateNavMeshId](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#aefbcde26627b9dbef68a3bf3a6208f30) = 7 |
| int | [DisabledNavMeshID](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a5dbf3cdf94770977304bcdfe726a52c8) = 8 |
| int | [NavMeshIdToDisableOnDestination](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a3fae63133992a3b448cde4b2cb55fe59) = -1 |
| float | [MinSpeed](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a53a7affbf3c6d047ec972e546906c451) = 0.5f |
| float | [MaxSpeed](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#ab447146d0812ee9e6c2f00a54b961794) = 1.0f |
| float | [DamageMultiplier](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#aad355caf715f5d918e349c004cee41c5) = 10 |
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
| Protected Member Functions | |
| override float | [GetDistanceMultiplierOfWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#ace133167bd580eecbc9253651e31d34e) ([Vec3](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a9bff92ab19906860837e7fa21126ee13) weaponPos) |
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
| Properties | |
| [SiegeWeaponMovementComponent](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html) | [MovementComponent](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a6be305fbb624ed0838e0085afd04056a) `[get]` |
| [FormationAI.BehaviorSide](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#af0e557fbaea88404cb872c1bc2b7912b) | [WeaponSide](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a17bbecfec80f14fa0d450adb04d3e73c) `[get]` |
| string | [PathEntity](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a5f5937eab69747be1bf9c3f9f62ba65d) `[get]` |
| bool | [EditorGhostEntityMove](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a24de00563940c20db09bfb2e89c9f751) `[get]` |
| [RamState](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#ace723ee11f45a0b9af00494dc17233d2) | [State](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#af0fec1b83ad262ccf5aab52f207ba6ea) `[get, set]` |
| [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | [TargetCastlePosition](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a47fc5bd7c4c623b12c337beea91fe054) `[get]` |
| float | [SiegeWeaponPriority](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a13bdb37d8cea756218469691511f25a7) `[get]` |
| int | [OverTheWallNavMeshID](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a99658752c7bb24ad378ff048feb793e2) `[get]` |
| bool | [HoldLadders](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a6eeff584223d4526bb1c4f9197539d14) `[get]` |
| bool | [SendLadders](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a723afb671b0d7b212d2df7b1a56db9ae) `[get]` |
| bool | [HasArrivedAtTarget](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#adfa5b5cc951c18523a815b7cef5b8f30) `[get, set]` |
| override bool | [IsDeactivated](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#aedf309e65b8f928037a2f3439ac17984) `[get]` |
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
| Static Public Attributes inherited from [TaleWorlds.MountAndBlade.UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) | |
| const string | [UsableMachineParentTag](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a010d494a549acc4496826c009dffe185) = "machine\_parent" |
| Static Public Attributes inherited from [TaleWorlds.MountAndBlade.MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | |
| const int | [MaxNavMeshPerDynamicObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#ad33e7f4aeb39643c81e3f22ae208d9e1) = 50 |
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

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#ace723ee11f45a0b9af00494dc17233d2)RamState
-----------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.BatteringRam.RamState](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#ace723ee11f45a0b9af00494dc17233d2) |

| Enumerator | |
| --- | --- |
| Stable |  |
| Hitting |  |
| AfterHit |  |
| NumberOfStates |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#af37e3c781dd026a142b5c8e7592055e0)HasCompletedAction()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.BatteringRam.HasCompletedAction | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IPrimarySiegeWeapon](interface_tale_worlds_1_1_mount_and_blade_1_1_i_primary_siege_weapon.html#ad6dd66df1468ead07dcee65e801db366).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#ab8668c0e9924ada7324b33e60f4f28eb)Disable()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.BatteringRam.Disable | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#aa62c88ecb68ef71f7e4e17cb6e74c29a).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a58f07e8288697c629cb86c1e5f12bed2)GetSiegeEngineType()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) TaleWorlds.MountAndBlade.BatteringRam.GetSiegeEngineType | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#ae1985e18f077723e1d24bb030d8e61d0)GetInitialFrame()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.BatteringRam.GetInitialFrame | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IMoveableSiegeWeapon](interface_tale_worlds_1_1_mount_and_blade_1_1_i_moveable_siege_weapon.html#a03b952a7aff0448651c93d2aa7e2488f).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a41e7e41d85abbc7f97716805e5ca4a2a)GetTickRequirement()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) TaleWorlds.MountAndBlade.BatteringRam.GetTickRequirement | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ac17100a83d592505ed8d9ac565e512a5).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a4690923b1dfc24c31eacd7a8ab0fa231)CreateAIBehaviorObject()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [UsableMachineAIBase](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html) TaleWorlds.MountAndBlade.BatteringRam.CreateAIBehaviorObject | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#abbf63ca39c7d9d26a2bd8e6bc3458c6d).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a4a88f84212f2f15007c512323e6cd5c4)WriteToNetwork()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.BatteringRam.WriteToNetwork | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#ae2659d0b019f69ee37de2d69beb032ce).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a58133c540f6e5e6bf36e37b57aa7a8f3)HighlightPath()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.BatteringRam.HighlightPath | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IMoveableSiegeWeapon](interface_tale_worlds_1_1_mount_and_blade_1_1_i_moveable_siege_weapon.html#a5aaddb658af0a7767180eeb6509ec9b8).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a650b9b7d57e6d26038ed16bf9b449571)SwitchGhostEntityMovementMode()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.BatteringRam.SwitchGhostEntityMovementMode | ( | bool | *isGhostEnabled* | ) |  |

Implements [TaleWorlds.MountAndBlade.IMoveableSiegeWeapon](interface_tale_worlds_1_1_mount_and_blade_1_1_i_moveable_siege_weapon.html#a0c7a4c8ad101800638fea2d3c9a50db0).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a4de21924a9d34f665d411f3642aca421)GetDescriptionText()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.MountAndBlade.BatteringRam.GetDescriptionText | ( | [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity* | ) |  |

Implements [TaleWorlds.MountAndBlade.IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html#ae296d89b1b2262987e2a6c7bb88368f8).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#ac6071ecb0cb55d3e007bd1f7814a5ae2)GetActionTextForStandingPoint()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.MountAndBlade.BatteringRam.GetActionTextForStandingPoint | ( | [UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) | *usableGameObject* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#af8f64557c106fd6ba4e284d90c4f69eb)GetOrder()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) TaleWorlds.MountAndBlade.BatteringRam.GetOrder | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a1cb5d50fdbbeb6cfdfd5106bfbde0ab5).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#ac968d519652f3d012fdf39085fac0ca2)GetTargetFlags()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [TargetFlags](namespace_tale_worlds_1_1_mount_and_blade.html#a54230c76514f63e19c2e14dfedae9fb4) TaleWorlds.MountAndBlade.BatteringRam.GetTargetFlags | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.ITargetable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_targetable.html#a4896040b596dbef060fe758288c6dc50).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a39cc9819565a3a91062a9b00a2673262)GetTargetValue()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.BatteringRam.GetTargetValue | ( | List< [Vec3](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a9bff92ab19906860837e7fa21126ee13) > | *weaponPos* | ) |  |

Implements [TaleWorlds.MountAndBlade.ITargetable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_targetable.html#a1886be0506013fe8a507455e8757cabd).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#ace133167bd580eecbc9253651e31d34e)GetDistanceMultiplierOfWeapon()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override float TaleWorlds.MountAndBlade.BatteringRam.GetDistanceMultiplierOfWeapon | ( | [Vec3](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a9bff92ab19906860837e7fa21126ee13) | *weaponPos* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a39de6efe184f0535c693834e75929440).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a8e8e41913f2268e4d669eeb39303625d)SetSpawnedFromSpawner()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.BatteringRam.SetSpawnedFromSpawner | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.Objects.Siege.ISpawnable](interface_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_i_spawnable.html#a6f1e5c34a0ebdc75c2994ea0dac85607).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#ab925d327d0da069058a51ee12c1ad4d8)AssignParametersFromSpawner()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.BatteringRam.AssignParametersFromSpawner | ( | string | *gateTag*, |
|  |  | string | *sideTag*, |
|  |  | int | *bridgeNavMeshID1*, |
|  |  | int | *bridgeNavMeshID2*, |
|  |  | int | *ditchNavMeshID1*, |
|  |  | int | *ditchNavMeshID2*, |
|  |  | int | *groundToBridgeNavMeshID1*, |
|  |  | int | *groundToBridgeNavMeshID2*, |
|  |  | string | *pathEntityName* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a009d6de4ff91b34a81d2ecf43efd35a1)OnAfterReadFromNetwork()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.BatteringRam.OnAfterReadFromNetwork | ( | ([BaseSynchedMissionObjectReadableRecord](struct_tale_worlds_1_1_mount_and_blade_1_1_base_synched_mission_object_readable_record.html), [ISynchedMissionObjectReadableRecord](interface_tale_worlds_1_1_mount_and_blade_1_1_i_synched_mission_object_readable_record.html)) | *synchedMissionObjectReadableRecord*, | |  |  | bool | *allowVisibilityUpdate* = true ) | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a4709dc8d1a0b3228df3c8e630e40a58a).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a860805b45d615872ddf5d198e2e4ea21)GetNavmeshFaceIds()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.BatteringRam.GetNavmeshFaceIds | ( | out List< int > | *navmeshFaceIds* | ) |  |

Implements [TaleWorlds.MountAndBlade.IPrimarySiegeWeapon](interface_tale_worlds_1_1_mount_and_blade_1_1_i_primary_siege_weapon.html#abfcc7161e612e62115d31f8dd93a2ca5).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a26f8bb0400f8c396d8b64d6639542a53)GhostEntityMove
------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.BatteringRam.GhostEntityMove = true |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#af063eb925778640817b433902e957b80)GhostEntitySpeedMultiplier
-----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.BatteringRam.GhostEntitySpeedMultiplier = 1.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#add077c68465b92c56b08d5a94625d9e8)WheelDiameter
----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.BatteringRam.WheelDiameter = 1.3f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#aefbcde26627b9dbef68a3bf3a6208f30)GateNavMeshId
----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.BatteringRam.GateNavMeshId = 7 |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a5dbf3cdf94770977304bcdfe726a52c8)DisabledNavMeshID
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.BatteringRam.DisabledNavMeshID = 8 |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a3fae63133992a3b448cde4b2cb55fe59)NavMeshIdToDisableOnDestination
----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.BatteringRam.NavMeshIdToDisableOnDestination = -1 |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a53a7affbf3c6d047ec972e546906c451)MinSpeed
-----------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.BatteringRam.MinSpeed = 0.5f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#ab447146d0812ee9e6c2f00a54b961794)MaxSpeed
-----------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.BatteringRam.MaxSpeed = 1.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#aad355caf715f5d918e349c004cee41c5)DamageMultiplier
-------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.BatteringRam.DamageMultiplier = 10 |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a6be305fbb624ed0838e0085afd04056a)MovementComponent
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SiegeWeaponMovementComponent](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html) TaleWorlds.MountAndBlade.BatteringRam.MovementComponent | | get |

Implements [TaleWorlds.MountAndBlade.IMoveableSiegeWeapon](interface_tale_worlds_1_1_mount_and_blade_1_1_i_moveable_siege_weapon.html#afb2a985681813bf472f9065b0c2dcaed).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a17bbecfec80f14fa0d450adb04d3e73c)WeaponSide
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [FormationAI.BehaviorSide](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#af0e557fbaea88404cb872c1bc2b7912b) TaleWorlds.MountAndBlade.BatteringRam.WeaponSide | | get |

Implements [TaleWorlds.MountAndBlade.IPrimarySiegeWeapon](interface_tale_worlds_1_1_mount_and_blade_1_1_i_primary_siege_weapon.html#a966ca954fd294a918598cd6614c8efda).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a5f5937eab69747be1bf9c3f9f62ba65d)PathEntity
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.BatteringRam.PathEntity | | get |

Implements [TaleWorlds.MountAndBlade.IPathHolder](interface_tale_worlds_1_1_mount_and_blade_1_1_i_path_holder.html#aea41ce2092528cc9486c8cc9bc47d191).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a24de00563940c20db09bfb2e89c9f751)EditorGhostEntityMove
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.BatteringRam.EditorGhostEntityMove | | get |

Implements [TaleWorlds.MountAndBlade.IPathHolder](interface_tale_worlds_1_1_mount_and_blade_1_1_i_path_holder.html#a8747781aa12bae995406d6bf2bf35e41).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#af0fec1b83ad262ccf5aab52f207ba6ea)State
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [RamState](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#ace723ee11f45a0b9af00494dc17233d2) TaleWorlds.MountAndBlade.BatteringRam.State | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a47fc5bd7c4c623b12c337beea91fe054)TargetCastlePosition
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) TaleWorlds.MountAndBlade.BatteringRam.TargetCastlePosition | | get |

Implements [TaleWorlds.MountAndBlade.IPrimarySiegeWeapon](interface_tale_worlds_1_1_mount_and_blade_1_1_i_primary_siege_weapon.html#a5f3cf006ac29e3a56df07fca764a5bd8).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a13bdb37d8cea756218469691511f25a7)SiegeWeaponPriority
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.BatteringRam.SiegeWeaponPriority | | get |

Implements [TaleWorlds.MountAndBlade.IPrimarySiegeWeapon](interface_tale_worlds_1_1_mount_and_blade_1_1_i_primary_siege_weapon.html#a62b2ad4c0fd2e4f1a1bab9eb12d290cf).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a99658752c7bb24ad378ff048feb793e2)OverTheWallNavMeshID
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.BatteringRam.OverTheWallNavMeshID | | get |

Implements [TaleWorlds.MountAndBlade.IPrimarySiegeWeapon](interface_tale_worlds_1_1_mount_and_blade_1_1_i_primary_siege_weapon.html#aa6d60a18c21f3a094af9a230ad9aefe6).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a6eeff584223d4526bb1c4f9197539d14)HoldLadders
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.BatteringRam.HoldLadders | | get |

Implements [TaleWorlds.MountAndBlade.IPrimarySiegeWeapon](interface_tale_worlds_1_1_mount_and_blade_1_1_i_primary_siege_weapon.html#a8767c012083d205e56cba9676629038d).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a723afb671b0d7b212d2df7b1a56db9ae)SendLadders
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.BatteringRam.SendLadders | | get |

Implements [TaleWorlds.MountAndBlade.IPrimarySiegeWeapon](interface_tale_worlds_1_1_mount_and_blade_1_1_i_primary_siege_weapon.html#aeec9e5c3da8927bd3c0b56aca6b2a78a).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#adfa5b5cc951c18523a815b7cef5b8f30)HasArrivedAtTarget
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.BatteringRam.HasArrivedAtTarget | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#aedf309e65b8f928037a2f3439ac17984)IsDeactivated
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override bool TaleWorlds.MountAndBlade.BatteringRam.IsDeactivated | | get |

