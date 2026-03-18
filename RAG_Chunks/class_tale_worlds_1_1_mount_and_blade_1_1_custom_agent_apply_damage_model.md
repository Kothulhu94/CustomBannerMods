--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html ---

TaleWorlds.MountAndBlade.CustomAgentApplyDamageModel Class ReferenceInherits [TaleWorlds.MountAndBlade.ComponentInterfaces.AgentApplyDamageModel](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_agent_apply_damage_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override bool | [IsDamageIgnored](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a0edabd01dbe4fffe5acfb7a9ad801822) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData) |
| override float | [ApplyDamageAmplifications](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a3c909e1ded1bb71957479b5c331209ef) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, float baseDamage) |
| override float | [ApplyDamageScaling](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a7ea7e2c128ddfd919bd6600f742d091d) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, float baseDamage) |
| override float | [ApplyDamageReductions](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a1d80dee388bb19fe8ad2b319743428b8) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, float baseDamage) |
| override float | [ApplyGeneralDamageModifiers](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a5af632d1cd7e7ee63714cea1af2ab3f4) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, float baseDamage) |
| override void | [DecideMissileWeaponFlags](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#ab9417722c36002744403d53f35ce5ce0) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) missileWeapon, ref [WeaponFlags](namespace_tale_worlds_1_1_core.html#a777ba058af61ad6bd9a4a27124c20051) missileWeaponFlags) |
| override bool | [DecideCrushedThrough](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#ab8aa646a6764b9b8d67fc71d1edf22c0) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) defenderAgent, float totalAttackEnergy, [Agent.UsageDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922a) attackDirection, [StrikeType](namespace_tale_worlds_1_1_core.html#a2adc9126cb9a9e45bc133ebc57833835) strikeType, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) defendItem, bool isPassiveUsage) |
| override bool | [CanWeaponDealSneakAttack](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#ae96ee0fb6d0f4ebfed6da67c5c90a129) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) weapon) |
| override bool | [CanWeaponDismount](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#ab493ddf5cd2eb3586d20e572dbd89be4) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData) |
| override void | [CalculateDefendedBlowStunMultipliers](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a6ce84bc33ab1d32c8c5d29cdddc3291c) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) defenderAgent, [CombatCollisionResult](namespace_tale_worlds_1_1_mount_and_blade.html#a69ccd75a0d558392b56af494b23edcfc) collisionResult, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) defenderWeapon, ref float attackerStunPeriod, ref float defenderStunPeriod) |
| override bool | [CanWeaponKnockback](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a45a5268bca6be5e442ba421c5a430058) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData) |
| override bool | [CanWeaponKnockDown](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a406fdb832324d02ee02b5b90fb09e731) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victimAgent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData) |
| override float | [GetDismountPenetration](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#aee8858f83f5ca49e81e47b05bc54af0c) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) attackCollisionData) |
| override float | [GetKnockBackPenetration](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#acbb4e9ef6633d46e172a0d8cbe289ea7) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) attackCollisionData) |
| override float | [GetKnockDownPenetration](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a4711aa0c139c883f90f8cb1ef28a5127) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) attackCollisionData) |
| override float | [GetHorseChargePenetration](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a2ec0e298a77ae7e80aa8d37ed74d02ed) () |
| override float | [CalculateStaggerThresholdDamage](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a078e168486905b9668a982e434adc8f0) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) defenderAgent, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow) |
| override float | [CalculateAlternativeAttackDamage](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a928874ee85b8ab17a4f2ef5f7be09b6f) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) weapon) |
| override float | [CalculatePassiveAttackDamage](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a441b75c5618dd19154809c88a3a7a048) ([BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) attackerCharacter, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, float baseDamage) |
| override [MeleeCollisionReaction](namespace_tale_worlds_1_1_mount_and_blade.html#abcba7a0a66dea15c390f0cb9ab6d1378) | [DecidePassiveAttackCollisionReaction](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#afc859e4ec55b947f3f8cd3f81ed2e540) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attacker, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) defender, bool isFatalHit) |
| override float | [CalculateShieldDamage](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a0b3ab99589faf74ed629915b4c6a1ad4) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, float baseDamage) |
| override float | [CalculateSailFireDamage](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a1ea1d6545d1a30dd941e323c6dd34eff) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) shipOrigin, float baseDamage, bool damageFromShipMachine) |
| override float | [CalculateHullFireDamage](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a525c886a33edb76ffbd76d45d2e68d93) (float baseFireDamage, [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) shipOrigin) |
| override float | [GetDamageMultiplierForBodyPart](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#aeec7fd3400428b77072b40690cb69da5) ([BoneBodyPartType](namespace_tale_worlds_1_1_mount_and_blade.html#a88860bf2968d0069d9696746ebb47115) bodyPart, [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) type, bool isHuman, bool isMissile) |
| override bool | [CanWeaponIgnoreFriendlyFireChecks](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a39ac2a96f8e90e0d5ae835f2b11c684d) ([WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) weapon) |
| override bool | [DecideAgentShrugOffBlow](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#aca6ce732a33c1c611f485846922af079) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victimAgent, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow) |
| override bool | [DecideAgentDismountedByBlow](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#ac4f0a0f2ba3da4a0e5dbc3cb226e61e4) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victimAgent, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow) |
| override bool | [DecideAgentKnockedBackByBlow](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a3eb6a5522ba7b27d1bc1675ac80cfab4) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victimAgent, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow) |
| override bool | [DecideAgentKnockedDownByBlow](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a7221a735f9123fef6088c4a072342c25) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victimAgent, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow) |
| override bool | [DecideMountRearedByBlow](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a549103ce156957e1a8b5158639ab4d3a) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victimAgent, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow) |
| override void | [DecideWeaponCollisionReaction](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a64f81b23e14d2ff2c6c86a9926d49be9) (in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) registeredBlow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attacker, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) defender, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) attackerWeapon, bool isFatalHit, bool isShruggedOff, float momentumRemaining, out [MeleeCollisionReaction](namespace_tale_worlds_1_1_mount_and_blade.html#abcba7a0a66dea15c390f0cb9ab6d1378) colReaction) |
| override bool | [ShouldMissilePassThroughAfterShieldBreak](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a986e6ae8a5db0e75c7e5a75167c9c9ba) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon) |
| override float | [CalculateRemainingMomentum](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a4884af733463742c25db8cc1f0715f09) (float originalMomentum, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) b, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attacker, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victim, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) attackerWeapon, bool isCrushThrough) |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.ComponentInterfaces.AgentApplyDamageModel](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_agent_apply_damage_model.html) | |
| float | [CalculateDamage](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_agent_apply_damage_model.html#ac23e101c2f38e94ebe6c3fc7626238ec) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, float baseDamage) |
|  | Calculates/modifies base damage when a weapon collides with it target. Perks and skill effects that increase base weapon damage can be implemented with this method. |
| bool | [IsDamageIgnored](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_agent_apply_damage_model.html#a5d5071a35f00f8649e613e3e1f687e7b) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData) |
|  | Checks whether the damage meant to be dealt to the agent is ignored or not. |
| float | [ApplyDamageAmplifications](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_agent_apply_damage_model.html#aa303f85f63cd09a8430cf05b8bc67871) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, float baseDamage) |
| float | [ApplyDamageScaling](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_agent_apply_damage_model.html#ae5d0aec59ae29877ee030da6b09b6319) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, float baseDamage) |
| float | [ApplyDamageReductions](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_agent_apply_damage_model.html#a653e816ef6f066283374a52a65d3c4b9) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, float baseDamage) |
| float | [ApplyGeneralDamageModifiers](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_agent_apply_damage_model.html#a112a49ccc4aabb9cbfb879317f185074) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, float baseDamage) |
| void | [DecideMissileWeaponFlags](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_agent_apply_damage_model.html#a8a1f33279375a781145e8dd02813d32b) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) missileWeapon, ref [WeaponFlags](namespace_tale_worlds_1_1_core.html#a777ba058af61ad6bd9a4a27124c20051) missileWeaponFlags) |
|  | Overrides weapon flags for a missile weapon when it leaves the bow/crossbow or the user's hand. For example if a missile can penetrate shields, CanPenetrateShield flag can be added within this method. |
| void | [CalculateDefendedBlowStunMultipliers](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_agent_apply_damage_model.html#ad230e332073b64e3fc55d254537db7e5) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) defenderAgent, [CombatCollisionResult](namespace_tale_worlds_1_1_mount_and_blade.html#a69ccd75a0d558392b56af494b23edcfc) collisionResult, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) defenderWeapon, ref float attackerStunPeriod, ref float defenderStunPeriod) |
|  | Calculates stun multipliers when a defender agents successfully defends (by blocking, parrying etc.) against an attacker's weapon blow. This scales how long the defender and the attacker will play the stun animation. For example hitting a defender agent's shield with a one handed weapon while it is blocking will cause the attacker to stun momentarily. Perfect blocks (i.e. blocking an attack from the correct side at the right moment) should reduce defender's stun amount as well. |
| float | [CalculateStaggerThresholdDamage](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_agent_apply_damage_model.html#a577e3691edd560e6ef199b154903ec09) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) defenderAgent, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow) |
|  | Calculates stagger damage threshold damage for the given agent. If the agent is staggered by an attack then any combat animations it is currently performing will be stopped momentarily. If an attack fails to stagger an agent, the agent will still take the attack's damage but its current combat animation will continue. |
| float | [CalculateAlternativeAttackDamage](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_agent_apply_damage_model.html#a90947ff2bf6ad6e015c52cf2aee74405) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) weapon) |
|  | Calculates alternative attack damage (weapon bashes, shield bashes and kicks). |
| float | [CalculatePassiveAttackDamage](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_agent_apply_damage_model.html#a23784360bc903f4d0a1a6ef39cb8e1ea) ([BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) attackerCharacter, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, float baseDamage) |
|  | Calculates/modifies passive attack damage (i.e. couched lance damage or spear brace damage). |
| [MeleeCollisionReaction](namespace_tale_worlds_1_1_mount_and_blade.html#abcba7a0a66dea15c390f0cb9ab6d1378) | [DecidePassiveAttackCollisionReaction](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_agent_apply_damage_model.html#a66236c0ba18473732101ff5190a2b6e9) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attacker, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) defender, bool isFatalHit) |
|  | Decides melee collision reaction for passive attacks (i.e. couched lance attacks or spear brace attacks) Passive attacks can hit one target or slice through multiple targets depending on the returned value. |
| void | [DecideWeaponCollisionReaction](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_agent_apply_damage_model.html#a7bbf14a0972b3eb0e73acdae62100774) (in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) registeredBlow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attacker, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) defender, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) attackerWeapon, bool isFatalHit, bool isShruggedOff, float momentumRemaining, out [MeleeCollisionReaction](namespace_tale_worlds_1_1_mount_and_blade.html#abcba7a0a66dea15c390f0cb9ab6d1378) colReaction) |
| float | [CalculateShieldDamage](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_agent_apply_damage_model.html#acd602f743cc0e805d42d2837d23b957a) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, float baseDamage) |
|  | Calculates/modifies damage dealt to a shield. |
| float | [CalculateSailFireDamage](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_agent_apply_damage_model.html#a1041031e46e120ec528be429350aaf63) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) shipOrigin, float baseDamage, bool damageFromShipMachine) |
| float | [CalculateHullFireDamage](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_agent_apply_damage_model.html#a632e196dd454c9ae848122c9ed2ebb0d) (float baseFireDamage, [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) shipOrigin) |
| float | [GetDamageMultiplierForBodyPart](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_agent_apply_damage_model.html#a018ee476d81c14b1755d16bf4ca54621) ([BoneBodyPartType](namespace_tale_worlds_1_1_mount_and_blade.html#a88860bf2968d0069d9696746ebb47115) bodyPart, [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) type, bool isHuman, bool isMissile) |
|  | Returns damage multiplier for a body part (i.e. certain body parts like neck & head can have higher multipliers for increase damage). |
| bool | [CanWeaponIgnoreFriendlyFireChecks](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_agent_apply_damage_model.html#a4f6010efd9d96c6fcd5cf6b216452987) ([WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) weapon) |
|  | Decides if the given weapon can ignore friendly fire checks and deal friendly fire damage. |
| bool | [CanWeaponDealSneakAttack](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_agent_apply_damage_model.html#a733db23f8683f5e7318772f1c6ef2665) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) weapon) |
| bool | [CanWeaponDismount](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_agent_apply_damage_model.html#a75d65d441abcf0a82e8a658a611b130a) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData) |
|  | Decides if the given weapon and blow can dismount its target. |
| bool | [CanWeaponKnockback](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_agent_apply_damage_model.html#a4425a7e8ec94413e5e712dca3f85243c) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData) |
|  | Decides if the given weapon and blow can knock back its target. |
| bool | [CanWeaponKnockDown](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_agent_apply_damage_model.html#aa94aabb346174dee1dd21d5bee5013d6) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victimAgent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData) |
|  | Decides if the given weapon and blow can knock down its target. |
| bool | [DecideCrushedThrough](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_agent_apply_damage_model.html#a358a41cd63920ecbf047f055552c7149) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) defenderAgent, float totalAttackEnergy, [Agent.UsageDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922a) attackDirection, [StrikeType](namespace_tale_worlds_1_1_core.html#a2adc9126cb9a9e45bc133ebc57833835) strikeType, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) defendItem, bool isPassiveUsageHit) |
| float | [CalculateRemainingMomentum](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_agent_apply_damage_model.html#ae0d3fff974fdaee4f72a1924c910a3d1) (float originalMomentum, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) b, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attacker, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victim, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) attackerWeapon, bool isCrushThrough) |
| bool | [DecideAgentShrugOffBlow](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_agent_apply_damage_model.html#ac9d8a6297436e49c9df77e410a83e639) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victimAgent, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow) |
|  | Decide if victim agent can successfully shrug off blow. Blows that are shrugged off does not deal damage and does not apply combat mechanics (knock back, knock down etc.). |
| bool | [DecideAgentDismountedByBlow](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_agent_apply_damage_model.html#a1df343b0c54c99bd1d88ec0c57bdd0d0) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victimAgent, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow) |
|  | Decide if a mounted victim can be dismounted by a blow. Victim must be a mounted human. |
| bool | [DecideAgentKnockedBackByBlow](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_agent_apply_damage_model.html#a4e3ba9019ddb7b46c87a34f27880ac3a) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victimAgent, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow) |
|  | Decides if a victim can be knocked back by a blow. Only applies to agents on foot. Victim must not be mounted. |
| bool | [DecideAgentKnockedDownByBlow](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_agent_apply_damage_model.html#af951e8106b0fda0efc03023c8fd0d842) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victimAgent, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow) |
|  | Decides if a victim can be knocked down by a blow. Only applies to agents on foot. Victim must not be mounted. |
| bool | [DecideMountRearedByBlow](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_agent_apply_damage_model.html#a1e083e1b2a533340495114dd57082b4a) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victimAgent, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow) |
|  | Decides if mount can be reared by a blow (i.e. a polearm thrust attack). Victim must be a mount. |
| bool | [ShouldMissilePassThroughAfterShieldBreak](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_agent_apply_damage_model.html#ab4f1ab69925bb154d373e5a386a0f2c1) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon) |
| float | [GetDismountPenetration](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_agent_apply_damage_model.html#a10c0bc52d7058e3c4eb4f3046b040c5d) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData) |
|  | Returns dismount penetration of a blow used for defeating an enemy's dismount resistance. |
| float | [GetKnockBackPenetration](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_agent_apply_damage_model.html#affd971e9df476a0fe70b723327fa0a93) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData) |
|  | Returns knock back penetration of a blow used for defeating an enemy's knockback resistance. |
| float | [GetKnockDownPenetration](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_agent_apply_damage_model.html#aa3166aecb3d6fca1651c0f66d702abc6) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData) |
|  | Returns knock down penetration of a blow used for defeating an enemy's knock down resistance. |
| float | [GetHorseChargePenetration](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_agent_apply_damage_model.html#ab89ae86b78db796d4bf69fac46ef5151) () |
|  | Returns knock down penetration for horse charge (trample) for defeating an enemy's knock down resistance. |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.ComponentInterfaces.AgentApplyDamageModel](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_agent_apply_damage_model.html) | |
| float | [CalculateDefaultRemainingMomentum](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_agent_apply_damage_model.html#a65332fd813068cdac0431db0a57b0076) (float originalMomentum, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) b, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attacker, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victim, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) attackerWeapon, bool isCrushThrough) |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a0edabd01dbe4fffe5acfb7a9ad801822)IsDamageIgnored()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.MountAndBlade.CustomAgentApplyDamageModel.IsDamageIgnored | ( | in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) | *attackInformation*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a3c909e1ded1bb71957479b5c331209ef)ApplyDamageAmplifications()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.CustomAgentApplyDamageModel.ApplyDamageAmplifications | ( | in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) | *attackInformation*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | float | *baseDamage* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a7ea7e2c128ddfd919bd6600f742d091d)ApplyDamageScaling()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.CustomAgentApplyDamageModel.ApplyDamageScaling | ( | in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) | *attackInformation*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | float | *baseDamage* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a1d80dee388bb19fe8ad2b319743428b8)ApplyDamageReductions()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.CustomAgentApplyDamageModel.ApplyDamageReductions | ( | in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) | *attackInformation*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | float | *baseDamage* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a5af632d1cd7e7ee63714cea1af2ab3f4)ApplyGeneralDamageModifiers()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.CustomAgentApplyDamageModel.ApplyGeneralDamageModifiers | ( | in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) | *attackInformation*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | float | *baseDamage* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#ab9417722c36002744403d53f35ce5ce0)DecideMissileWeaponFlags()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.MountAndBlade.CustomAgentApplyDamageModel.DecideMissileWeaponFlags | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *missileWeapon*, |
|  |  | ref [WeaponFlags](namespace_tale_worlds_1_1_core.html#a777ba058af61ad6bd9a4a27124c20051) | *missileWeaponFlags* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#ab8aa646a6764b9b8d67fc71d1edf22c0)DecideCrushedThrough()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.MountAndBlade.CustomAgentApplyDamageModel.DecideCrushedThrough | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *defenderAgent*, |
|  |  | float | *totalAttackEnergy*, |
|  |  | [Agent.UsageDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922a) | *attackDirection*, |
|  |  | [StrikeType](namespace_tale_worlds_1_1_core.html#a2adc9126cb9a9e45bc133ebc57833835) | *strikeType*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *defendItem*, |
|  |  | bool | *isPassiveUsage* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#ae96ee0fb6d0f4ebfed6da67c5c90a129)CanWeaponDealSneakAttack()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.MountAndBlade.CustomAgentApplyDamageModel.CanWeaponDealSneakAttack | ( | in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) | *attackInformation*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *weapon* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#ab493ddf5cd2eb3586d20e572dbd89be4)CanWeaponDismount()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.MountAndBlade.CustomAgentApplyDamageModel.CanWeaponDismount | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon*, |
|  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a6ce84bc33ab1d32c8c5d29cdddc3291c)CalculateDefendedBlowStunMultipliers()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.MountAndBlade.CustomAgentApplyDamageModel.CalculateDefendedBlowStunMultipliers | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *defenderAgent*, |
|  |  | [CombatCollisionResult](namespace_tale_worlds_1_1_mount_and_blade.html#a69ccd75a0d558392b56af494b23edcfc) | *collisionResult*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *defenderWeapon*, |
|  |  | ref float | *attackerStunPeriod*, |
|  |  | ref float | *defenderStunPeriod* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a45a5268bca6be5e442ba421c5a430058)CanWeaponKnockback()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.MountAndBlade.CustomAgentApplyDamageModel.CanWeaponKnockback | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon*, |
|  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a406fdb832324d02ee02b5b90fb09e731)CanWeaponKnockDown()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.MountAndBlade.CustomAgentApplyDamageModel.CanWeaponKnockDown | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *victimAgent*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon*, |
|  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#aee8858f83f5ca49e81e47b05bc54af0c)GetDismountPenetration()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.CustomAgentApplyDamageModel.GetDismountPenetration | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon*, |
|  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *attackCollisionData* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#acbb4e9ef6633d46e172a0d8cbe289ea7)GetKnockBackPenetration()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.CustomAgentApplyDamageModel.GetKnockBackPenetration | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon*, |
|  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *attackCollisionData* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a4711aa0c139c883f90f8cb1ef28a5127)GetKnockDownPenetration()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.CustomAgentApplyDamageModel.GetKnockDownPenetration | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon*, |
|  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *attackCollisionData* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a2ec0e298a77ae7e80aa8d37ed74d02ed)GetHorseChargePenetration()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.CustomAgentApplyDamageModel.GetHorseChargePenetration | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a078e168486905b9668a982e434adc8f0)CalculateStaggerThresholdDamage()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.CustomAgentApplyDamageModel.CalculateStaggerThresholdDamage | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *defenderAgent*, |
|  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a928874ee85b8ab17a4f2ef5f7be09b6f)CalculateAlternativeAttackDamage()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.CustomAgentApplyDamageModel.CalculateAlternativeAttackDamage | ( | in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) | *attackInformation*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *weapon* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a441b75c5618dd19154809c88a3a7a048)CalculatePassiveAttackDamage()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.CustomAgentApplyDamageModel.CalculatePassiveAttackDamage | ( | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *attackerCharacter*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | float | *baseDamage* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#afc859e4ec55b947f3f8cd3f81ed2e540)DecidePassiveAttackCollisionReaction()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [MeleeCollisionReaction](namespace_tale_worlds_1_1_mount_and_blade.html#abcba7a0a66dea15c390f0cb9ab6d1378) TaleWorlds.MountAndBlade.CustomAgentApplyDamageModel.DecidePassiveAttackCollisionReaction | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attacker*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *defender*, |
|  |  | bool | *isFatalHit* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a0b3ab99589faf74ed629915b4c6a1ad4)CalculateShieldDamage()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.CustomAgentApplyDamageModel.CalculateShieldDamage | ( | in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) | *attackInformation*, |
|  |  | float | *baseDamage* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a1ea1d6545d1a30dd941e323c6dd34eff)CalculateSailFireDamage()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.CustomAgentApplyDamageModel.CalculateSailFireDamage | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) | *shipOrigin*, |
|  |  | float | *baseDamage*, |
|  |  | bool | *damageFromShipMachine* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a525c886a33edb76ffbd76d45d2e68d93)CalculateHullFireDamage()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.CustomAgentApplyDamageModel.CalculateHullFireDamage | ( | float | *baseFireDamage*, |
|  |  | [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) | *shipOrigin* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#aeec7fd3400428b77072b40690cb69da5)GetDamageMultiplierForBodyPart()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.CustomAgentApplyDamageModel.GetDamageMultiplierForBodyPart | ( | [BoneBodyPartType](namespace_tale_worlds_1_1_mount_and_blade.html#a88860bf2968d0069d9696746ebb47115) | *bodyPart*, |
|  |  | [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) | *type*, |
|  |  | bool | *isHuman*, |
|  |  | bool | *isMissile* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a39ac2a96f8e90e0d5ae835f2b11c684d)CanWeaponIgnoreFriendlyFireChecks()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.MountAndBlade.CustomAgentApplyDamageModel.CanWeaponIgnoreFriendlyFireChecks | ( | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *weapon* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#aca6ce732a33c1c611f485846922af079)DecideAgentShrugOffBlow()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.MountAndBlade.CustomAgentApplyDamageModel.DecideAgentShrugOffBlow | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *victimAgent*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#ac4f0a0f2ba3da4a0e5dbc3cb226e61e4)DecideAgentDismountedByBlow()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.MountAndBlade.CustomAgentApplyDamageModel.DecideAgentDismountedByBlow | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *victimAgent*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon*, |
|  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a3eb6a5522ba7b27d1bc1675ac80cfab4)DecideAgentKnockedBackByBlow()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.MountAndBlade.CustomAgentApplyDamageModel.DecideAgentKnockedBackByBlow | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *victimAgent*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon*, |
|  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a7221a735f9123fef6088c4a072342c25)DecideAgentKnockedDownByBlow()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.MountAndBlade.CustomAgentApplyDamageModel.DecideAgentKnockedDownByBlow | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *victimAgent*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon*, |
|  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a549103ce156957e1a8b5158639ab4d3a)DecideMountRearedByBlow()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.MountAndBlade.CustomAgentApplyDamageModel.DecideMountRearedByBlow | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *victimAgent*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon*, |
|  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a64f81b23e14d2ff2c6c86a9926d49be9)DecideWeaponCollisionReaction()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.MountAndBlade.CustomAgentApplyDamageModel.DecideWeaponCollisionReaction | ( | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *registeredBlow*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attacker*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *defender*, |
|  |  | in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *attackerWeapon*, |
|  |  | bool | *isFatalHit*, |
|  |  | bool | *isShruggedOff*, |
|  |  | float | *momentumRemaining*, |
|  |  | out [MeleeCollisionReaction](namespace_tale_worlds_1_1_mount_and_blade.html#abcba7a0a66dea15c390f0cb9ab6d1378) | *colReaction* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a986e6ae8a5db0e75c7e5a75167c9c9ba)ShouldMissilePassThroughAfterShieldBreak()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.MountAndBlade.CustomAgentApplyDamageModel.ShouldMissilePassThroughAfterShieldBreak | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_agent_apply_damage_model.html#a4884af733463742c25db8cc1f0715f09)CalculateRemainingMomentum()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.CustomAgentApplyDamageModel.CalculateRemainingMomentum | ( | float | *originalMomentum*, |
|  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *b*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attacker*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *victim*, |
|  |  | in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *attackerWeapon*, |
|  |  | bool | *isCrushThrough* ) |

