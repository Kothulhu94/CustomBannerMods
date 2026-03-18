--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html ---

TaleWorlds.MountAndBlade.Ballista Class ReferenceInherits [TaleWorlds.MountAndBlade.RangedSiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html), and [TaleWorlds.MountAndBlade.Objects.Siege.ISpawnable](interface_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_i_spawnable.html).

Inherited by [TaleWorlds.MountAndBlade.FireBallista](class_tale_worlds_1_1_mount_and_blade_1_1_fire_ballista.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | [GetSiegeEngineType](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#aa005caba4301dcb6c33ce2cff63900dd) () |
| override void | [OnPilotAssignedDuringSpawn](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a26415173f8d1426315c86be339b71a76) () |
| override [UsableMachineAIBase](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html) | [CreateAIBehaviorObject](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a01f893e8ba8b6b9d2849cf683bb306ca) () |
| override [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) | [GetTickRequirement](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a0bc1658456a9b9751bb0841665c55cf4) () |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetActionTextForStandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a364b0527483314e7a3e46c60b71f6241) ([UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) usableGameObject) |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetDescriptionText](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#ad014df364a0e80db4a44dd1a604fe213) ([WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity) |
| override float | [ProcessTargetValue](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#ab56f30f974212fb4904a76cdd882fc00) (float baseValue, [TargetFlags](namespace_tale_worlds_1_1_mount_and_blade.html#a54230c76514f63e19c2e14dfedae9fb4) flags) |
| override [TargetFlags](namespace_tale_worlds_1_1_mount_and_blade.html#a54230c76514f63e19c2e14dfedae9fb4) | [GetTargetFlags](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a3758b69d67a7745d337e49abd5e29527) () |
| override float | [GetTargetValue](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a0c0a3eb63f693236d3036d7897cb3610) (List< [Vec3](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a9bff92ab19906860837e7fa21126ee13) > weaponPos) |
| void | [SetSpawnedFromSpawner](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#ab720c173c2099c9c22353fa7d800b8bb) () |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.RangedSiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html) | |
| delegate void | [OnSiegeWeaponReloadDone](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a24c062b8ec1f241b4c68f1f1423ecd7d) () |
| virtual void | [SetAmmo](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#aad97c3dd3c45a2e5613d12729326cbcb) (int ammoLeft) |
| virtual void | [SetStartAmmo](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a3e68b370455135ac0e01a107886c4995) (int ammoLeft) |
| void | [ChangeProjectileEntityClient](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a72ff98785f0d526727d1aa13f451e9b6) (int index) |
| override void | [WriteToNetwork](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a40a03145780e7f56ddbc1d5cdd16440a) () |
| override bool | [IsInRangeToCheckAlternativePoints](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a9de5e37f60623bd440bd09eb843e517e) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| override [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) | [GetBestPointAlternativeTo](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a9afc4647e2c809670c8d80fe85039efa) ([StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) standingPoint, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| override [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) | [GetTickRequirement](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a353246e344df4aac562d8f720489fb1b) () |
| void | [GiveInput](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a4d23da6c7b86213a9a81f54016c6e2fc) (float inputX, float inputY) |
| void | [GiveExactInput](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a966009add523ae1d2c422dc35648c45f) (float targetX, float targetY) |
| virtual float | [GetTargetReleaseAngle](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#aebbe3fc1e3cc3c07bbd0af4b190e9e48) ([Vec3](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a9bff92ab19906860837e7fa21126ee13) target) |
|  | Calculates the required release angle of this ranged siege weapon to hit the param target. |
| virtual bool | [AimAtThreat](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#adcc4fd388ac2cecc076247c0f79944da) ([Threat](class_tale_worlds_1_1_mount_and_blade_1_1_threat.html) threat) |
|  | Changes weapon's direction and angle of release to aim at the param target. |
| bool | [AimAtTarget](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a43d27805a264b9f7dcba7a1a922d1653) ([Vec3](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a9bff92ab19906860837e7fa21126ee13) target) |
| virtual bool | [CheckIsTargetReached](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a85736e0909cdac312a7c9b6e1b130396) ([Vec3](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a9bff92ab19906860837e7fa21126ee13) target) |
| [Vec3](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a9bff92ab19906860837e7fa21126ee13) | [GetEstimatedTargetGlobalPoint](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#abb33ffcb93c6067b12ad58b43ba3fc02) ([Threat](class_tale_worlds_1_1_mount_and_blade_1_1_threat.html) threat) |
| [Vec3](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a9bff92ab19906860837e7fa21126ee13) | [GetEstimatedTargetGlobalPointForAgent](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#aad0fd31a1f3fad7dfcbcb0a36f5120a9) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| virtual void | [AimAtRotation](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a762192820f3041d62aa9588153a523bb) (float horizontalRotation, float verticalRotation) |
| bool | [Shoot](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#ae8db45159a807dd270e96302de7f0098) () |
|  | Shoots if it is ready to shoot. |
| void | [ManualReload](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#ab661de3050c272ab1247c8163e0e55bd) () |
| void | [AiRequestsShoot](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#ac32b13f6407ec8d1a698950baccfdec7) () |
| void | [AiRequestsManualReload](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#abdc182d44dad961842556a4eb6aca88f) () |
| override [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | [GetSiegeEngineType](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#af7e602c45522ff0716433b137f75bc73) () |
| bool | [CanShootAtBox](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a7da8ae59694274039334ff6b8250721a) ([Vec3](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a9bff92ab19906860837e7fa21126ee13) boxMin, [Vec3](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a9bff92ab19906860837e7fa21126ee13) boxMax, uint attempts=5) |
| bool | [CanShootAtThreat](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#ab0e9ea5074409b47d805f28b9058c163) ([Threat](class_tale_worlds_1_1_mount_and_blade_1_1_threat.html) threat) |
| virtual [Vec3](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a9bff92ab19906860837e7fa21126ee13) | [GetEstimatedTargetMovementVector](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#abcd4ebe0febbe77f846de3b6919e7438) ([Vec3](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a9bff92ab19906860837e7fa21126ee13) targetCurrentPosition, [Vec3](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a9bff92ab19906860837e7fa21126ee13) targetVelocity) |
| bool | [CanShootAtAgent](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a8471dcfd46c595d898c2a1dba16eec1a) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| bool | [CanShootAtPoint](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a83c6df625385e9954bd895bb4812ca74) ([Vec3](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a9bff92ab19906860837e7fa21126ee13) target) |
| override [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) | [GetOrder](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#af26696855b229f651b2b00e58f16a826) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| float | [ProcessTargetValue](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#ae82566dadbdaf0580e0a94250b3118e7) (float baseValue, [TargetFlags](namespace_tale_worlds_1_1_mount_and_blade.html#a54230c76514f63e19c2e14dfedae9fb4) flags) |
| override void | [OnAfterReadFromNetwork](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a0064264493e414ac2b33beb7147b8796) (([BaseSynchedMissionObjectReadableRecord](struct_tale_worlds_1_1_mount_and_blade_1_1_base_synched_mission_object_readable_record.html), [ISynchedMissionObjectReadableRecord](interface_tale_worlds_1_1_mount_and_blade_1_1_i_synched_mission_object_readable_record.html)) synchedMissionObjectReadableRecord, bool allowVisibilityUpdate=true) |
| virtual [Vec3](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a9bff92ab19906860837e7fa21126ee13) | [GetGlobalVelocity](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#af37d7f653f6d20f733f6d20e7d536aad) () |
| void | [SetPlayerForceUse](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#ac107bfdffc7730ad7bc80a5452ca284d) (bool value) |
| override void | [OnShipCaptured](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#aaad0ffbb0ac4eaed7bdb6164b666a589) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) newDefaultSide) |
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
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetInfoTextForBeingNotInteractable](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#aff8ecaec44cb3bcc0197ecf6f9b01d14) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) userAgent) |
| void | [Deactivate](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a30713d3ca3d233328f178eca72a094a1) () |
| void | [Activate](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a9763624842c425b7c9789d6274c3fb8c) () |
| virtual bool | [IsDisabledForBattleSide](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#af346e6bcdeb8bf6ab98835181779fb75) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) sideEnum) |
| virtual bool | [IsDisabledForBattleSideAI](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a5f3f910b34b937da3eba99d858e7e6b2) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) sideEnum) |
| virtual void | [Disable](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#aa62c88ecb68ef71f7e4e17cb6e74c29a) () |
| override string | [ToString](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a1d38daf4ce2aff596db158fd464e6fc2) () |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetActionTextForStandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#ad6643e6fa1b677c88803e85f3d68c0ce) ([UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) usableGameObject) |
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
| string | [NavelTag](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a9e73839d69c1f50750c5c97b9455dd05) = "BallistaNavel" |
| string | [BodyTag](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a8752f4e9037b640a016e6c92666f6cdd) = "BallistaBody" |
| string | [SkeletonTag](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a406b4c2b663b9b7ccd59432c7c045d1a) = "SkeletonEntity" |
| float | [AnimationHeightDifference](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a8e1fd2d23c29c47492b0a8f4c024dcc6) = 0.0f |
| float | [HorizontalDirectionRestriction](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#ac68dd3aa6e0fd9c9996d73c48b7d2015) = MBMath.PI / 2.0f |
| float | [BallistaShootingSpeed](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#aa966123a31f3fd7c0c3333a88b426da4) = 120.0f |
| Public Attributes inherited from [TaleWorlds.MountAndBlade.RangedSiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html) | |
| string | [MissileItemID](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a71c266699a730e0538c7369a1ee2c5f3) |
| [FiringFocus](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#aff19891067614f7da0149f8bee668293) | [Focus](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a916cf876fe477041c77a512f5172e916) |
| int | [StartingAmmoCount](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#ab9c6614e459a974f39f8a3bee0ca244d) = 20 |
| float | [TopReleaseAngleRestriction](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a8672a1e8b42f3f2b45069838ca1c2596) = MBMath.PI / 2.0f |
|  | /// |
| float | [BottomReleaseAngleRestriction](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a55649ca7cc034b06d47869238a1dcfad) = -MBMath.PI / 2.0f |
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
| override void | [RegisterAnimationParameters](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#aa0025a6fa4f29b923f852aa4e036b85b) () |
| override bool | [CanRotate](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a2d1e5c249e881f048d80c1ce01a082b6) () |
| override void | [OnRangedSiegeWeaponStateChange](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a61012bc04f3cd7b32e6a8cbc3cc8c041) () |
| override void | [HandleUserAiming](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a1ccd7281687cf8ad00cfbbc853bf0a8e) (float dt) |
| override void | [ApplyAimChange](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#aa3cdb0a7fa4b5ee8ea2658557db29798) () |
| override void | [ApplyCurrentDirectionToEntity](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a149257026c975d29810668f9f675eaa3) () |
| override void | [GetSoundEventIndices](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a4cd13273bc3943d5a99b32c3e95ac507) () |
| override void | [UpdateAmmoMesh](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a276cbf53959b8279884b98bb999dc063) () |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.RangedSiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html) | |
| void | [RegisterAnimationParameters](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a2912bca5b9492778a026a105a73fad03) () |
| void | [GetSoundEventIndices](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a37a6de6d323fd42aeb05b149cad4a2a9) () |
| virtual void | [ConsumeAmmo](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a12c77916afb2c31fc1108a47796c833e) () |
| virtual void | [CheckAmmo](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a6c282f763c8677f47a76495bf41fd8e2) () |
| void | [ChangeProjectileEntityServer](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a3adcc649405ab4614b6686c3fbb02ca9) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) loadingAgent, string missileItemID) |
| virtual void | [DetermineDefaultBattleSide](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a2df1baa761b99f93e154240daf9619be) () |
| virtual void | [UpdateProjectilePosition](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a3b41f9376e0abd27241105bce2cf37cc) () |
| virtual void | [SetActivationLoadAmmoPoint](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#ab4a542dc7306f455fee88968571240c1) (bool activate) |
| override float | [GetDetachmentWeightAux](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#af8de4c4f1560380fda0505a2eceef1a5) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| float | [GetDetachmentWeightAuxForExternalAmmoWeapons](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#ae58da7767c68d595239b8fd6be02b612) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| void | [OnLoadingAmmoPointUsingCancelled](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a6067fa55f416fd1bfd8222cccf16d6fd) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, bool isCanceledBecauseOfAnimation) |
| void | [OnAmmoPickupUsingCancelled](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#ae90f2dd10cbe170a4d3b368bff3c81c4) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, bool isCanceledBecauseOfAnimation) |
| void | [SendAgentToAmmoPickup](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a8b0a0f16276edadb071e74bd553b1790) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| void | [SendReloaderAgentToOriginalPoint](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#abeef1fa536d4416d059aea03c842095c) () |
| void | [ShootProjectile](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a9c4dab331849e9b07c0f0919a09aab62) () |
| virtual [Mission.Missile](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_missile.html) | [ShootProjectileAux](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a2f315b11330615db15e59b70936e3932) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) missileItem, bool randomizeMissileSpeed) |
| void | [SetupProjectileToShoot](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a33f1e5f84163e9d9ce300da3ae8ca1c2) (bool randomizeMissileSpeed, out [Vec3](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a9bff92ab19906860837e7fa21126ee13) direction, out [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html) orientation, out float missileBaseSpeed, out float missileShootingSpeed) |
| void | [OnRotationStarted](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a50f1862378eb3b15b64ab7537b7b1bf7) () |
| void | [OnRotationStopped](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a750cc7de8abc11bbd8c6a68fb4b2a4f9) () |
| virtual bool | [CheckFriendlyFireForObjects](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a9be1773759dcb3ef20e307862b61c3e0) ([Vec3](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a9bff92ab19906860837e7fa21126ee13) target) |
| override [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | [GetEntityToAttachNavMeshFaces](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#ac77f4bfadc1a673370e3af9f6f83e931) () |
| override bool | [IsAnyUserBelongsToFormation](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a10f2501e7d3d2f2bb1fe442964e94174) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| override bool | [ShouldDisableTickIfMachineDisabled](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a15a71167251e679c75fc4348144ab2f2) () |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html) | |
| virtual bool | [CalculateIsSufficientlyManned](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a5f6d63a7ed8384f16b9070b43e12c517) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) battleSide) |
| float | [GetUserMultiplierOfWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#aa8c3c52a20f74a40ef46b80c41ce4780) () |
| virtual float | [GetDistanceMultiplierOfWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a39de6efe184f0535c693834e75929440) ([Vec3](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a9bff92ab19906860837e7fa21126ee13) weaponPos) |
| virtual float | [GetMinimumDistanceBetweenPositions](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#ae5ac4098a350dfd36975093c4e0449ff) ([Vec3](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a9bff92ab19906860837e7fa21126ee13) position) |
| float | [GetHitPointMultiplierOfWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a7d1f373b1026ad9474405e767baaf556) () |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) | |
|  | [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#ac5fe63ebe9d4d5b7d6e31521577178ee) () |
| virtual void | [DebugTick](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#acb4973db4969533a42bf0dc4ea27de3a) (float dt) |
| bool | [IsDisabledDueToEnemyInRange](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#afb7df349a54b2ffcb85c2c6e7c60e373) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) sideEnum) |
| override void | [OnRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#abc7226debc7d7f91ee2db48317dd9ca7) (int removeReason) |
| virtual float | [GetWeightOfStandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a1799fb6802848c721ca165fbe39b6f23) ([StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) sp) |
| virtual bool | [IsAgentOnInconvenientNavmesh](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a231d4a00adb93489d694947f3ddfc84d) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) standingPoint) |
| virtual [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) | [GetSuitableStandingPointFor](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#ac21beefc597d31859f29689b192f30a5) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent=null, List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > agents=null, List< ValueTuple< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), float > > agentValuePairs=null) |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | |
| virtual void | [AttachDynamicNavmeshToEntity](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a96b0e630894be6b18d6395ad12f811ac) () |
| Protected Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [InvalidateWeakPointersIfValid](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#af39d73d0c78790ba81a40a5a350c0526) () |
|  | [ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0bc136bb53989f2b9a4f23f12f54a332) () |

|  |  |
| --- | --- |
| Protected Attributes | |
| string | [IdleActionName](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#ab13e24ba19e1d736e38e611e6d714e0e) = "act\_usage\_ballista\_idle\_attacker" |
| string | [ReloadActionName](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#abfe85ada5f9f1956cf8ead396c9b29da) = "act\_usage\_ballista\_reload\_attacker" |
| string | [PlaceAmmoStartActionName](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#aa2a0e4230aa44fefb0f5f47641f4783e) = "act\_usage\_ballista\_ammo\_place\_start\_attacker" |
| string | [PlaceAmmoEndActionName](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a0cdc26e4695cc4d2f06c506618b2d77b) = "act\_usage\_ballista\_ammo\_place\_end\_attacker" |
| string | [PickUpAmmoStartActionName](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#ae000c8e4a9f1e7951ff3eb2a7ce3a344) = "act\_usage\_ballista\_ammo\_pick\_up\_start\_attacker" |
| string | [PickUpAmmoEndActionName](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a4fdb342cf7b28bd1fa391fd1d3903afb) = "act\_usage\_ballista\_ammo\_pick\_up\_end\_attacker" |
| Protected Attributes inherited from [TaleWorlds.MountAndBlade.RangedSiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html) | |
| bool | [UsesMouseForAiming](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a3ddf3a2d239c20fae05dfdcba91acf9c) |
| int | [MultipleProjectileCount](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a5127eaa43ffe12094532ac3e75356356) = 5 |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0a02cc65cc567db6101ea4afa275ff36) | [MissileStartingPositionEntityForSimulation](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a119a55c1d084bd5f86b82d5a7ae58f97) |
| [Skeleton](class_tale_worlds_1_1_engine_1_1_skeleton.html)[] | [Skeletons](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#afe9474dcb1af77a085f5f734c80e45fc) |
| [SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html)[] | [SkeletonOwnerObjects](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#aae2fb194c11c5c972321de5f15184793) |
| string[] | [SkeletonNames](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a596446ce51e997850aea54e05c1bcb69) |
| string[] | [FireAnimations](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#aaa06e9575250271d57f73d4327d9dc93) |
| string[] | [SetUpAnimations](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#adc29ee3725a880af5fb3ab1a35f2f938) |
| int[] | [FireAnimationIndices](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#ae72fe86df2a338d192938626a47c38cc) |
| int[] | [SetUpAnimationIndices](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a69ec29c1231f83265630d7ab2baad983) |
| [SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html) | [RotationObject](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#abaa1db6d967f6c111a7efce3ad816095) |
| [SoundEvent](class_tale_worlds_1_1_engine_1_1_sound_event.html) | [MoveSound](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a83d6cc7bad50ec1897d48b64409bc4e2) |
| [SoundEvent](class_tale_worlds_1_1_engine_1_1_sound_event.html) | [ReloadSound](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#aa4789ecdfb132f2c5dfc3f5adc4d451b) |
| int | [MoveSoundIndex](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#ae24e5bc4f67fb30c2d48f504a7994904) = -1 |
| int | [ReloadSoundIndex](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#af90cc14663f5ab61e369fa91e3765287) = -1 |
| int | [FireSoundIndex](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a67f4780af9ac46253137fce1b3817e70) = -1 |
| [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | [OriginalMissileItem](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#ae6d8cb53e718678d6ebb2b4240d4a728) |
| [WeaponStatsData](struct_tale_worlds_1_1_mount_and_blade_1_1_weapon_stats_data.html) | [OriginalMissileWeaponStatsDataForTargeting](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#af406cf1805773d6875232cb0db801a18) |
| List< [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) > | [CanPickUpAmmoStandingPoints](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a8f1acc93699d026721f7683d648b68e1) |
| List< [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) > | [ReloadStandingPoints](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#abecaebca841977239a42b1756a010f0d) |
| [StandingPointWithWeaponRequirement](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point_with_weapon_requirement.html) | [LoadAmmoStandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a851d78829c96c8490a9388a17dc995d3) |
| Dictionary< [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html), float > | [PilotReservePriorityValues](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#ad8d6e8da3b69539c4f87a2d5ffdcd290) = new Dictionary<[StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html), float>() |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [ReloaderAgent](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a2213c8a6897910306456fd8d7ca7689d) |
| [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) | [ReloaderAgentOriginalPoint](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a529bc57bc65fdb69abde00994196b488) |
| bool | [AttackClickWillReload](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a0c5eb3190f33b61e304ee40e033b04e3) = false |
| bool | [WeaponNeedsClickToReload](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a9a444cc6029005c0ebfa4f679650d748) = false |
| float | [FinalReloadSpeed](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#ada910a05fba436a7c56b9fdc680f8403) = 1.0f |
| float | [BaseReloadSpeed](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#aa511e7c0e8c6b76a3c362b587c1ec7fb) = 1.0f |
| int | [CurrentAmmo](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a84a419d40e9cd295549f4de81eb0ad84) = 1 |
| float | [TargetDirection](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a1392f42ed69d19a36fffa81b157f726b) |
| float | [TargetReleaseAngle](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a3caf2bb44724fff867455e6afc1f2ff0) |
| float | [CameraDirection](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a08b2791f3c8b8e4846710758a48a1b88) |
| float | [CameraReleaseAngle](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a52b9d85ff1bd53dd359dc9337ef8025a) |
| float | [ReloadTargetReleaseAngle](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#ad03e0c6d3e40445362d8b84c595f7d29) |
| float | [MaxRotateSpeed](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a0288d1f9b4aa1610f619bb769e28af98) |
| float | [DontMoveTimer](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a8099e13294ec1e17c4fe563e34480c6d) |
| float | [CurrentDirection](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a49ac4a467e92cdfdd7ff9f1125cfcbb2) |
|  | The angle of current direction, θ, measured in radians, such that -π≤θ≤π. |
| float | [CurrentReleaseAngle](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#aa2f22c1cee2e0982da9438b3f51a747c) |
|  | The angle of launch, θ, measured in radians. |
| float | [ReleaseAngleRestrictionCenter](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a59c9aee39188704b1a66e8edb658bfe1) |
| float | [ReleaseAngleRestrictionAngle](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a6c8589a951a69567858500331faf844b) |
| float | [TimeGapBetweenShootingEndAndReloadingStart](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#af82d7fa506d66b875e0c7d4fb7dcc27b) = 0.6f |
| float | [TimeGapBetweenShootActionAndProjectileLeaving](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a58c3fe10e28040e1e5f107e468fe7aca) = 0.0f |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [LastShooterAgent](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#aee83a50ff7ab27ee6bd09a872bd2d9bb) |
| [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | [DefaultSide](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a099c3e0bea1d7743f79ade344048cf15) |
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

|  |  |
| --- | --- |
| Properties | |
| [SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html) | [ballistaBody](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#afc3e1dc439d00ba0b986fc45057e6372) `[get]` |
| [SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html) | [ballistaNavel](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a327edccd0f7a69d902fba7ea2a716006) `[get]` |
| override float | [DirectionRestriction](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a677eb8343ee177b0b002f4dc3411da23) `[get]` |
| override float | [ShootingSpeed](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a87528327e108fe97be5cc1c090dd9333) `[get]` |
| override [Vec3](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a9bff92ab19906860837e7fa21126ee13) | [CanShootAtPointCheckingOffset](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a2a09533a8de133cc4e8ae2f9f65d2aa7) `[get]` |
| override bool | [WeaponMovesDownToReload](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a5a119560fde78b982009d40ba358b9a2) `[get]` |
| override string | [MultipleProjectileId](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#ade9da752807ef340da162a15ca43944c) `[get]` |
| override string | [MultipleProjectileFlyingId](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a17867050b35f2c2fb6a0a3e7c5a3e9b2) `[get]` |
| override float | [MaximumBallisticError](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a1acfed248075a59472f7809e501d262a) `[get]` |
| override float | [HorizontalAimSensitivity](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a963be1a261f748ef9df299d1865e7189) `[get]` |
| override float | [VerticalAimSensitivity](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a0554cf0379e13a94a59a8d3ce7db158c) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.RangedSiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html) | |
| virtual string | [MultipleFireProjectileId](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#aeb4bac694c11120eed1addb9a0f2f55c) `[get]` |
| virtual string | [MultipleFireProjectileFlyingId](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a15a136b8933fd97f07a2280402ef299c) `[get]` |
| virtual string | [MultipleProjectileId](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a75d5803761a4564e3b15418967396479) `[get]` |
| virtual string | [MultipleProjectileFlyingId](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a1a1d482f8b7a734ad60e2b142a44a2b2) `[get]` |
| virtual string | [SingleFireProjectileId](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a88a4c7e837a7661c53d5224b28922726) `[get]` |
| virtual string | [SingleFireProjectileFlyingId](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a642718cb46e71d73ecfdeb66762e79ac) `[get]` |
| virtual string | [SingleProjectileId](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a122971ca36ffe86bb3a744a8bddb57fa) `[get]` |
| virtual string | [SingleProjectileFlyingId](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a33c9e28996a642f4d7c5ac461846886e) `[get]` |
| [WeaponState](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#ae5894115c68b3ca9de74e540c6650084) | [State](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a5eff5510b08f81114ea26a45bf45d687) `[get, set]` |
| virtual float | [MaximumBallisticError](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#ac6c5facf458d069a065318989ad4dd98) `[get]` |
| float | [ShootingSpeed](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#aa7108eedf64b69e9fa95bbcbb628cf00) `[get]` |
| virtual [Vec3](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a9bff92ab19906860837e7fa21126ee13) | [CanShootAtPointCheckingOffset](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#abd9ba8b5cee8a216a83e8b0969801b2b) `[get]` |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0a02cc65cc567db6101ea4afa275ff36) | [CameraHolder](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#aabbb6518700001b6924aba4d4a7005c3) `[get]` |
| [SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html) | [Projectile](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a2f8a1644f93e80127af4b10fe94f5ecd) `[get]` |
| [Vec3](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a9bff92ab19906860837e7fa21126ee13) | [MissileStartingGlobalPositionForSimulation](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#aaab433f42209471ab4752d516be9e3b3) `[get]` |
| string | [SkeletonName](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#ae1d82670447194e1908029661451bb33) `[set]` |
| string | [FireAnimation](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a61c2b4f5f800ae219a320a256c8d977f) `[set]` |
| string | [SetUpAnimation](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a4bac1b2ea9a52f912363458ce2ab2849) `[set]` |
| int | [FireAnimationIndex](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a022da5c1eecc8582e64be8ee314af289) `[set]` |
| int | [SetUpAnimationIndex](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a28a971ad2bcc4cf10d2f72f4cefe63ba) `[set]` |
| [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | [LoadedMissileItem](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a56bd4b372146557303807b6fd083ed06) `[get, set]` |
| virtual bool | [WeaponMovesDownToReload](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a9cbb433bdc44b5fa8c337b32b90b11c2) `[get]` |
| int | [AmmoCount](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a977b40d633a2597af2eb15b8446dcec5) `[get, protected set]` |
| virtual bool | [HasAmmo](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a18cb37570dd53dfd732a4e4c7f18e8c2) = true `[get, set]` |
| virtual float | [DirectionRestriction](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a3d1dcabe3a17d0b808924e5851761b6a) `[get]` |
|  | Central angle of restriction circular sector of weapon's direction, θ, measured in radians, such that 0<θ≤π/2. |
| virtual float | [HorizontalAimSensitivity](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a9def5223f6d5d7acbf5f36b21cdae105) `[get]` |
| virtual float | [VerticalAimSensitivity](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#aa4d1bdd4b50e776e7793c6187e1e7074) `[get]` |
| virtual float | [ReloadSpeedMultiplier](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a4831284f2c6aed8dcb5dba17aa930de8) `[get]` |
| bool | [PlayerForceUse](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a0a4bc7ea4a90e92f74cab5edc646deb2) `[get]` |
| virtual [Vec3](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a9bff92ab19906860837e7fa21126ee13) | [ShootingDirection](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a45e0198321383ffb9489483ac80dbc51) `[get]` |
| virtual [Vec3](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a9bff92ab19906860837e7fa21126ee13) | [ProjectileEntityCurrentGlobalPosition](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a15ed10297922fb3b415ace9499d5dc0a) `[get]` |
| override [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | [Side](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a5af5b11e289e8cb7a4c5269bd2fd93c5) `[get]` |
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
| Public Types inherited from [TaleWorlds.MountAndBlade.RangedSiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html) | |
| enum | [WeaponState](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#ae5894115c68b3ca9de74e540c6650084) {     [Invalid](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#ae5894115c68b3ca9de74e540c6650084a4bbb8f967da6d1a610596d7257179c2b) = -1 ,     [Idle](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#ae5894115c68b3ca9de74e540c6650084ae599161956d626eda4cb0a5ffb85271c) = 0 ,     [WaitingBeforeProjectileLeaving](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#ae5894115c68b3ca9de74e540c6650084a43512334d9a8af4c0c1de482b597d0a0) ,     [Shooting](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#ae5894115c68b3ca9de74e540c6650084ad77f3ab1f2d580d0267893842d79b625) ,     [WaitingAfterShooting](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#ae5894115c68b3ca9de74e540c6650084a91b0cf169315c25eead441134b922095) ,     [WaitingBeforeReloading](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#ae5894115c68b3ca9de74e540c6650084a7b4be68945d1afaa1cd98ba4ff659066) ,     [LoadingAmmo](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#ae5894115c68b3ca9de74e540c6650084a00784366a2a597e5fb0ff6ac6e79cf05) ,     [WaitingBeforeIdle](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#ae5894115c68b3ca9de74e540c6650084ae7e242adde7881733a73a5e088595fc0) ,     [Reloading](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#ae5894115c68b3ca9de74e540c6650084a1046222ea676e1c79b0f8d955cf3a55c) ,     [ReloadingPaused](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#ae5894115c68b3ca9de74e540c6650084af7ccc2685eac453c12372b41e4fba975) ,     [NumberOfStates](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#ae5894115c68b3ca9de74e540c6650084a78d6d95a0773a734f15e0b31bba59359)   } |
|  | The cycle of states is as follows: Idle => WaitingBeforeProjectileLeaving => Shooting => WaitingBeforeReloading => Reloading => Idle. Shoot method should be called for moving from Idle state to WaitingBeforeProjectileLeaving state. All other state changes are done in StateUpdate method. Default value is Idle state. [More...](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#ae5894115c68b3ca9de74e540c6650084) |
| enum | [FiringFocus](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#aff19891067614f7da0149f8bee668293) {     [Troops](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#aff19891067614f7da0149f8bee668293a209e7bfff9aa195bd2c6963a3fb33dda) ,     [Walls](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#aff19891067614f7da0149f8bee668293a1f5c5ce5cdbea723378e6db882a732ec) ,     [RangedSiegeWeapons](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#aff19891067614f7da0149f8bee668293a4452e995c9706633a3cffdcdd9c73a84) ,     [PrimarySiegeWeapons](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#aff19891067614f7da0149f8bee668293acfd21fd66081c755102c281c68c1143a)   } |
| enum | [CameraState](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a56f2c1320b7697adf7f15c7709dcc355) {     [StickToWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a56f2c1320b7697adf7f15c7709dcc355aa56b95efd19a2704b5e7404bea433190) ,     [DontMove](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a56f2c1320b7697adf7f15c7709dcc355a800f66ebfb45069d99041b412d8a2cae) ,     [MoveDownToReload](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a56f2c1320b7697adf7f15c7709dcc355a98e68192617182fd3889e7b994fbd48b) ,     [RememberLastShotDirection](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a56f2c1320b7697adf7f15c7709dcc355ac0c762a74b7d6d52af8a695076822a8b) ,     [FreeMove](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a56f2c1320b7697adf7f15c7709dcc355a15a9766e0342e352f202a02f7cf9bb38) ,     [ApproachToCamera](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a56f2c1320b7697adf7f15c7709dcc355ade3128f29c4695d2ff2ac006d07b196c)   } |
| enum | [ForceUseState](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#af0a9fbe749afd702aaa594bedacb470d) {     [NotForced](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#af0a9fbe749afd702aaa594bedacb470da9d5178805df12669e5d6b3e11ff3c00d) ,     [ForcefullyWatched](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#af0a9fbe749afd702aaa594bedacb470da037aebfac2461b75dc6a40b2cb9febc0) ,     [ForcefullyUsed](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#af0a9fbe749afd702aaa594bedacb470da59b8b62b3b16c949a514135cd91075ba)   } |
| Public Types inherited from [TaleWorlds.MountAndBlade.SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html) | |
| enum | [SynchFlags](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5ca) : uint {     [SynchNone](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5caa2da4e8e99f2913602376d36f8089a315) = 0x00000000 ,     [SynchTransform](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5caaa2b2f6339ae0b34de079c6d36495701a) = 0x00000001 ,     [SynchAnimation](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5caa896890ac2c4ab8db6aa3d8aa54201e2f) = 0x00000002 ,     [SynchBodyFlags](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5caabe8d4d441f6ffd28e6c51f8f3c7be862) = 0x00000004 ,     [SyncColors](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5caa10774fbeeb25df50516d9b754652622a) = 0x00000008 ,     [SynchAll](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5caa86cdc154b35c72e83e8b91718295bd3a) = 0xffffffff   } |
| Public Types inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| enum | [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) : uint {     [None](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da6adf97f83acf6453d4a6a4b1070f3754) = 0x00000000 ,     [TickOccasionally](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da9cee052f50afabfc1098c1aa6af80b75) = 0x00000001 ,     [Tick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0b3516a5bbb77566f904f9d3877f4710) = 0x00000002 ,     [TickParallel](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da5f5a8f4b9ce783164665db4d70e03ee3) = 0x00000004 ,     [TickParallel2](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0ea9f0c260cdfd8b20ce19a48dbc329f) = 0x00000008 ,     [FixedTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154dadd067942f0b8cc66859698bc9711ba15) = 0x00000010 ,     [FixedParallelTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daa226d712a5ffd8d400f850393ff68492) = 0x00000020 ,     [TickParallel3](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daf785c2c005d708ea434168efc10611b8) = 0x00000040   } |
| Static Public Attributes inherited from [TaleWorlds.MountAndBlade.RangedSiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html) | |
| const float | [DefaultDirectionRestriction](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a3308a696f2e32f16223de95b72714b5f) = MBMath.PI / 1.5f |
| const string | [CanGoAmmoPickupTag](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a342d91b647f64431790f60487c018990) = "can\_pick\_up\_ammo" |
| const string | [DontApplySidePenaltyTag](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a9738ab90a2b1c0f0cb6d7e1dfeed3d0f) = "no\_ammo\_pick\_up\_penalty" |
| const string | [ReloadTag](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#ac63012571834ae5f696616750404ff0d) = "reload" |
| const string | [AmmoLoadTag](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#ad425c01ef66f3f46076f1e646e01af93) = "ammoload" |
| const string | [CameraHolderTag](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#aa59fbcb0477bd3344e61b07184ea1361) = "cameraHolder" |
| const string | [ProjectileTag](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#ae95bb061b15114a994a2ca317ead92b6) = "projectile" |
| Static Public Attributes inherited from [TaleWorlds.MountAndBlade.UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) | |
| const string | [UsableMachineParentTag](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a010d494a549acc4496826c009dffe185) = "machine\_parent" |
| Static Public Attributes inherited from [TaleWorlds.MountAndBlade.MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | |
| const int | [MaxNavMeshPerDynamicObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#ad33e7f4aeb39643c81e3f22ae208d9e1) = 50 |
| Protected Types inherited from [TaleWorlds.MountAndBlade.MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | |
| enum | [DynamicNavmeshLocalIds](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90b) : int {     [Inside](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90ba9b6d3000134648fc9f1e71094ae0847d) = 1 ,     [Enter](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90baf1851d5600eae616ee802a31ac74701b) = 2 ,     [Exit](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90bafef46e5063ce3dc78b8ae64fa474241d) = 3 ,     [Blocker](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90bada32a1684e943a766fec67b13009be79) = 4 ,     [Extra1](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90ba113f84d105af2b8016b3896117c9deab) = 5 ,     [Extra2](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90ba83dca46dd08ad782e968d586375715e1) = 6 ,     [Extra3](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90bab7f54183dc84b2982ebe161b9c59f2d9) = 7 ,     [Reserved1](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90ba93876cb309016fa725517b046474c44b) = 9 ,     [Count](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90bae93f994f01c537c4e2f7d8528c3eb5e9)   } |
| Static Protected Member Functions inherited from [TaleWorlds.MountAndBlade.RangedSiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html) | |
| static bool | [ApproachToAngle](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#ab2705c4176299fbff482ef561d368d1d) (ref float angle, float angleToApproach, bool isMouse, float speed\_limit, float dt, float sensitivity) |
| Events inherited from [TaleWorlds.MountAndBlade.RangedSiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html) | |
| Action< [RangedSiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html), [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | [OnAgentLoadsMachine](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a51b15e3639a214d840129c9a1e13871b) |
| [OnSiegeWeaponReloadDone](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a24c062b8ec1f241b4c68f1f1423ecd7d) | [OnReloadDone](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a20f84c01b6b285fc9b4eb1230e5925a3) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#aa0025a6fa4f29b923f852aa4e036b85b)RegisterAnimationParameters()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.Ballista.RegisterAnimationParameters | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#aa005caba4301dcb6c33ce2cff63900dd)GetSiegeEngineType()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) TaleWorlds.MountAndBlade.Ballista.GetSiegeEngineType | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a26415173f8d1426315c86be339b71a76)OnPilotAssignedDuringSpawn()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.Ballista.OnPilotAssignedDuringSpawn | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a4e826bd545a1f7dd2daf8348541f3b69).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a2d1e5c249e881f048d80c1ce01a082b6)CanRotate()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override bool TaleWorlds.MountAndBlade.Ballista.CanRotate | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.RangedSiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a60986074a2270982de01461943bd6deb).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a01f893e8ba8b6b9d2849cf683bb306ca)CreateAIBehaviorObject()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [UsableMachineAIBase](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html) TaleWorlds.MountAndBlade.Ballista.CreateAIBehaviorObject | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#abbf63ca39c7d9d26a2bd8e6bc3458c6d).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a61012bc04f3cd7b32e6a8cbc3cc8c041)OnRangedSiegeWeaponStateChange()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.Ballista.OnRangedSiegeWeaponStateChange | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.RangedSiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a12493ed3dfe5c28fcea43c03e5a255f9).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a1ccd7281687cf8ad00cfbbc853bf0a8e)HandleUserAiming()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.Ballista.HandleUserAiming | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.RangedSiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#ac4213e1b4f2b7aaf07b87399d36fb78d).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#aa3cdb0a7fa4b5ee8ea2658557db29798)ApplyAimChange()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.Ballista.ApplyAimChange | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.RangedSiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#a70bb2972bbe6afe1946e783edfbaa320).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a149257026c975d29810668f9f675eaa3)ApplyCurrentDirectionToEntity()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.Ballista.ApplyCurrentDirectionToEntity | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.RangedSiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#aa909cd30c6e7883f1736780220d60b95).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a4cd13273bc3943d5a99b32c3e95ac507)GetSoundEventIndices()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.Ballista.GetSoundEventIndices | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a0bc1658456a9b9751bb0841665c55cf4)GetTickRequirement()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) TaleWorlds.MountAndBlade.Ballista.GetTickRequirement | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ac17100a83d592505ed8d9ac565e512a5).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a364b0527483314e7a3e46c60b71f6241)GetActionTextForStandingPoint()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.MountAndBlade.Ballista.GetActionTextForStandingPoint | ( | [UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) | *usableGameObject* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#ad014df364a0e80db4a44dd1a604fe213)GetDescriptionText()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.MountAndBlade.Ballista.GetDescriptionText | ( | [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity* | ) |  |

Implements [TaleWorlds.MountAndBlade.IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html#ae296d89b1b2262987e2a6c7bb88368f8).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a276cbf53959b8279884b98bb999dc063)UpdateAmmoMesh()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.Ballista.UpdateAmmoMesh | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.RangedSiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html#ac4845297663a7637ea7cde840f9a4a68).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#ab56f30f974212fb4904a76cdd882fc00)ProcessTargetValue()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.Ballista.ProcessTargetValue | ( | float | *baseValue*, |
|  |  | [TargetFlags](namespace_tale_worlds_1_1_mount_and_blade.html#a54230c76514f63e19c2e14dfedae9fb4) | *flags* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a3758b69d67a7745d337e49abd5e29527)GetTargetFlags()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [TargetFlags](namespace_tale_worlds_1_1_mount_and_blade.html#a54230c76514f63e19c2e14dfedae9fb4) TaleWorlds.MountAndBlade.Ballista.GetTargetFlags | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.ITargetable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_targetable.html#a4896040b596dbef060fe758288c6dc50).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a0c0a3eb63f693236d3036d7897cb3610)GetTargetValue()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.Ballista.GetTargetValue | ( | List< [Vec3](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a9bff92ab19906860837e7fa21126ee13) > | *weaponPos* | ) |  |

Implements [TaleWorlds.MountAndBlade.ITargetable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_targetable.html#a1886be0506013fe8a507455e8757cabd).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#ab720c173c2099c9c22353fa7d800b8bb)SetSpawnedFromSpawner()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Ballista.SetSpawnedFromSpawner | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.Objects.Siege.ISpawnable](interface_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_i_spawnable.html#a6f1e5c34a0ebdc75c2994ea0dac85607).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a9e73839d69c1f50750c5c97b9455dd05)NavelTag
------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.Ballista.NavelTag = "BallistaNavel" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a8752f4e9037b640a016e6c92666f6cdd)BodyTag
-----------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.Ballista.BodyTag = "BallistaBody" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a406b4c2b663b9b7ccd59432c7c045d1a)SkeletonTag
---------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.Ballista.SkeletonTag = "SkeletonEntity" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a8e1fd2d23c29c47492b0a8f4c024dcc6)AnimationHeightDifference
-----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.Ballista.AnimationHeightDifference = 0.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#ab13e24ba19e1d736e38e611e6d714e0e)IdleActionName
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.Ballista.IdleActionName = "act\_usage\_ballista\_idle\_attacker" | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#abfe85ada5f9f1956cf8ead396c9b29da)ReloadActionName
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.Ballista.ReloadActionName = "act\_usage\_ballista\_reload\_attacker" | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#aa2a0e4230aa44fefb0f5f47641f4783e)PlaceAmmoStartActionName
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.Ballista.PlaceAmmoStartActionName = "act\_usage\_ballista\_ammo\_place\_start\_attacker" | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a0cdc26e4695cc4d2f06c506618b2d77b)PlaceAmmoEndActionName
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.Ballista.PlaceAmmoEndActionName = "act\_usage\_ballista\_ammo\_place\_end\_attacker" | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#ae000c8e4a9f1e7951ff3eb2a7ce3a344)PickUpAmmoStartActionName
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.Ballista.PickUpAmmoStartActionName = "act\_usage\_ballista\_ammo\_pick\_up\_start\_attacker" | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a4fdb342cf7b28bd1fa391fd1d3903afb)PickUpAmmoEndActionName
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.Ballista.PickUpAmmoEndActionName = "act\_usage\_ballista\_ammo\_pick\_up\_end\_attacker" | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#ac68dd3aa6e0fd9c9996d73c48b7d2015)HorizontalDirectionRestriction
----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.Ballista.HorizontalDirectionRestriction = MBMath.PI / 2.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#aa966123a31f3fd7c0c3333a88b426da4)BallistaShootingSpeed
-------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.Ballista.BallistaShootingSpeed = 120.0f |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#afc3e1dc439d00ba0b986fc45057e6372)ballistaBody
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html) TaleWorlds.MountAndBlade.Ballista.ballistaBody | | getprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a327edccd0f7a69d902fba7ea2a716006)ballistaNavel
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html) TaleWorlds.MountAndBlade.Ballista.ballistaNavel | | getprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a677eb8343ee177b0b002f4dc3411da23)DirectionRestriction
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.MountAndBlade.Ballista.DirectionRestriction | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a87528327e108fe97be5cc1c090dd9333)ShootingSpeed
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.MountAndBlade.Ballista.ShootingSpeed | | getprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a2a09533a8de133cc4e8ae2f9f65d2aa7)CanShootAtPointCheckingOffset
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [Vec3](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a9bff92ab19906860837e7fa21126ee13) TaleWorlds.MountAndBlade.Ballista.CanShootAtPointCheckingOffset | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a5a119560fde78b982009d40ba358b9a2)WeaponMovesDownToReload
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override bool TaleWorlds.MountAndBlade.Ballista.WeaponMovesDownToReload | | getprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#ade9da752807ef340da162a15ca43944c)MultipleProjectileId
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override string TaleWorlds.MountAndBlade.Ballista.MultipleProjectileId | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a17867050b35f2c2fb6a0a3e7c5a3e9b2)MultipleProjectileFlyingId
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override string TaleWorlds.MountAndBlade.Ballista.MultipleProjectileFlyingId | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a1acfed248075a59472f7809e501d262a)MaximumBallisticError
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.MountAndBlade.Ballista.MaximumBallisticError | | getprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a963be1a261f748ef9df299d1865e7189)HorizontalAimSensitivity
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.MountAndBlade.Ballista.HorizontalAimSensitivity | | getprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a0554cf0379e13a94a59a8d3ce7db158c)VerticalAimSensitivity
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.MountAndBlade.Ballista.VerticalAimSensitivity | | getprotected |

