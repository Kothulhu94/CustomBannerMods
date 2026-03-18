--- SOURCE: class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html ---

SandBox.GameComponents.SandboxAgentApplyDamageModel Class ReferenceInherits [TaleWorlds.MountAndBlade.ComponentInterfaces.AgentApplyDamageModel](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_agent_apply_damage_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override bool | [IsDamageIgnored](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#a20ceba16b2a16017a4be205d3b292862) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData) |
| override float | [ApplyDamageAmplifications](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#a67d49e285ae677f44982d2382feb715f) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, float baseDamage) |
| override float | [ApplyDamageScaling](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#afe2e4b0a74789c7eca4f6e510f4c8cbb) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, float baseDamage) |
| override float | [ApplyDamageReductions](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#adc10666d372e7d85b31db5d288caf239) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, float baseDamage) |
| override float | [ApplyGeneralDamageModifiers](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#a6a9d3ebd3c6f98c61ffeee2e9bb7f7c2) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, float baseDamage) |
| override bool | [DecideCrushedThrough](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#aee5e4723747fddc7b34a96c5b43f1caa) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) defenderAgent, float totalAttackEnergy, Agent.UsageDirection attackDirection, [StrikeType](namespace_tale_worlds_1_1_core.html#a2adc9126cb9a9e45bc133ebc57833835) strikeType, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) defendItem, bool isPassiveUsage) |
| override void | [DecideMissileWeaponFlags](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#a5a9481dc21000bb1c381a3657bf64ef6) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) missileWeapon, ref [WeaponFlags](namespace_tale_worlds_1_1_core.html#a777ba058af61ad6bd9a4a27124c20051) missileWeaponFlags) |
| override bool | [CanWeaponIgnoreFriendlyFireChecks](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#a5167bcbe6d81134ddf3f6c418a34c0a9) ([WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) weapon) |
| override bool | [CanWeaponDealSneakAttack](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#a877ce57f323a13adda0768c1c796c2ba) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) weapon) |
| override bool | [CanWeaponDismount](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#a823f16ce47e99cf0662c50f8e7eda418) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData) |
| override void | [CalculateDefendedBlowStunMultipliers](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#ab93dadf7434803302e8226c9328bee14) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) defenderAgent, [CombatCollisionResult](namespace_tale_worlds_1_1_mount_and_blade.html#a69ccd75a0d558392b56af494b23edcfc) collisionResult, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) defenderWeapon, ref float attackerStunPeriod, ref float defenderStunPeriod) |
| override bool | [CanWeaponKnockback](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#af218d8c5291d07f4a9cafb24679716a3) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData) |
| override bool | [CanWeaponKnockDown](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#acfb2ec5ef50d301102ca2655693ad1b8) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victimAgent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData) |
| override float | [GetDismountPenetration](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#ae695e361a83f37bc1163ab9f4742b1c7) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData) |
| override float | [GetKnockBackPenetration](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#af63a6f88686ffa9f4589bd2884e28632) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData) |
| override float | [GetKnockDownPenetration](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#a289214ebf49f70a2c139b3682d8da2ee) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData) |
| override float | [GetHorseChargePenetration](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#af4d29f9c54bcd838bffdb7d67f6d8a79) () |
| override float | [CalculateStaggerThresholdDamage](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#a7a88e1f6d8ebce9cf4f27da868427259) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) defenderAgent, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow) |
| override float | [CalculateAlternativeAttackDamage](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#a2e4a7f695b161cd863812abeb4decbfd) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) weapon) |
| override float | [CalculatePassiveAttackDamage](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#a4f244acc3720b107247f313dad991e71) ([BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) attackerCharacter, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, float baseDamage) |
| override [MeleeCollisionReaction](namespace_tale_worlds_1_1_mount_and_blade.html#abcba7a0a66dea15c390f0cb9ab6d1378) | [DecidePassiveAttackCollisionReaction](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#a2e41272412156af0c72f75be30ac7a58) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attacker, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) defender, bool isFatalHit) |
| override float | [CalculateShieldDamage](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#a42c59499ef06450b2a05335edb3cfa76) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, float baseDamage) |
| override float | [CalculateSailFireDamage](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#a75f80aa9a809626020ecf5d6e6f16ed1) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) shipOrigin, float baseDamage, bool damageFromShipMachine) |
| override float | [CalculateHullFireDamage](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#a55c7a3b5a8c800d4bbe4172e7f03426a) (float baseFireDamage, [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) shipOrigin) |
| override float | [GetDamageMultiplierForBodyPart](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#ac4cc05f06e95cd4ce868761da6b680fd) ([BoneBodyPartType](namespace_tale_worlds_1_1_mount_and_blade.html#a88860bf2968d0069d9696746ebb47115) bodyPart, [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) type, bool isHuman, bool isMissile) |
| override bool | [DecideAgentShrugOffBlow](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#a92d83f48b6e14cbfc5b62db80b635b55) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victimAgent, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow) |
| override bool | [DecideAgentDismountedByBlow](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#a59a81624d9406e4084d9fdc8341e8681) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victimAgent, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow) |
| override bool | [DecideAgentKnockedBackByBlow](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#accf216cc4c9bb545637491aa8871b2fd) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victimAgent, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow) |
| override bool | [DecideAgentKnockedDownByBlow](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#a5fb8eda128d6c3e6563624bc5a811d93) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victimAgent, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow) |
| override bool | [DecideMountRearedByBlow](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#aa9ea69cd637a23efbeb15f11928acd5e) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victimAgent, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow) |
| override void | [DecideWeaponCollisionReaction](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#a406911a4e673ebfadf31fcd4068e31d0) (in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) registeredBlow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attacker, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) defender, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) attackerWeapon, bool isFatalHit, bool isShruggedOff, float momentumRemaining, out [MeleeCollisionReaction](namespace_tale_worlds_1_1_mount_and_blade.html#abcba7a0a66dea15c390f0cb9ab6d1378) colReaction) |
| override bool | [ShouldMissilePassThroughAfterShieldBreak](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#a979dacf7228dd1e7fe4cbeeb392fdef2) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon) |
| override float | [CalculateRemainingMomentum](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#a306befa557a9ef945d215e4d5c9e3fd7) (float originalMomentum, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) b, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attacker, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victim, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) attackerWeapon, bool isCrushThrough) |
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

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#a20ceba16b2a16017a4be205d3b292862)IsDamageIgnored()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool SandBox.GameComponents.SandboxAgentApplyDamageModel.IsDamageIgnored | ( | in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) | *attackInformation*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData* ) |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#a67d49e285ae677f44982d2382feb715f)ApplyDamageAmplifications()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float SandBox.GameComponents.SandboxAgentApplyDamageModel.ApplyDamageAmplifications | ( | in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) | *attackInformation*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | float | *baseDamage* ) |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#afe2e4b0a74789c7eca4f6e510f4c8cbb)ApplyDamageScaling()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float SandBox.GameComponents.SandboxAgentApplyDamageModel.ApplyDamageScaling | ( | in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) | *attackInformation*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | float | *baseDamage* ) |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#adc10666d372e7d85b31db5d288caf239)ApplyDamageReductions()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float SandBox.GameComponents.SandboxAgentApplyDamageModel.ApplyDamageReductions | ( | in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) | *attackInformation*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | float | *baseDamage* ) |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#a6a9d3ebd3c6f98c61ffeee2e9bb7f7c2)ApplyGeneralDamageModifiers()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float SandBox.GameComponents.SandboxAgentApplyDamageModel.ApplyGeneralDamageModifiers | ( | in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) | *attackInformation*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | float | *baseDamage* ) |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#aee5e4723747fddc7b34a96c5b43f1caa)DecideCrushedThrough()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool SandBox.GameComponents.SandboxAgentApplyDamageModel.DecideCrushedThrough | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *defenderAgent*, |
|  |  | float | *totalAttackEnergy*, |
|  |  | Agent.UsageDirection | *attackDirection*, |
|  |  | [StrikeType](namespace_tale_worlds_1_1_core.html#a2adc9126cb9a9e45bc133ebc57833835) | *strikeType*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *defendItem*, |
|  |  | bool | *isPassiveUsage* ) |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#a5a9481dc21000bb1c381a3657bf64ef6)DecideMissileWeaponFlags()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void SandBox.GameComponents.SandboxAgentApplyDamageModel.DecideMissileWeaponFlags | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *missileWeapon*, |
|  |  | ref [WeaponFlags](namespace_tale_worlds_1_1_core.html#a777ba058af61ad6bd9a4a27124c20051) | *missileWeaponFlags* ) |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#a5167bcbe6d81134ddf3f6c418a34c0a9)CanWeaponIgnoreFriendlyFireChecks()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool SandBox.GameComponents.SandboxAgentApplyDamageModel.CanWeaponIgnoreFriendlyFireChecks | ( | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *weapon* | ) |  |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#a877ce57f323a13adda0768c1c796c2ba)CanWeaponDealSneakAttack()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool SandBox.GameComponents.SandboxAgentApplyDamageModel.CanWeaponDealSneakAttack | ( | in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) | *attackInformation*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *weapon* ) |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#a823f16ce47e99cf0662c50f8e7eda418)CanWeaponDismount()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool SandBox.GameComponents.SandboxAgentApplyDamageModel.CanWeaponDismount | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon*, |
|  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData* ) |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#ab93dadf7434803302e8226c9328bee14)CalculateDefendedBlowStunMultipliers()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void SandBox.GameComponents.SandboxAgentApplyDamageModel.CalculateDefendedBlowStunMultipliers | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *defenderAgent*, |
|  |  | [CombatCollisionResult](namespace_tale_worlds_1_1_mount_and_blade.html#a69ccd75a0d558392b56af494b23edcfc) | *collisionResult*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *defenderWeapon*, |
|  |  | ref float | *attackerStunPeriod*, |
|  |  | ref float | *defenderStunPeriod* ) |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#af218d8c5291d07f4a9cafb24679716a3)CanWeaponKnockback()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool SandBox.GameComponents.SandboxAgentApplyDamageModel.CanWeaponKnockback | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon*, |
|  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData* ) |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#acfb2ec5ef50d301102ca2655693ad1b8)CanWeaponKnockDown()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool SandBox.GameComponents.SandboxAgentApplyDamageModel.CanWeaponKnockDown | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *victimAgent*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon*, |
|  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData* ) |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#ae695e361a83f37bc1163ab9f4742b1c7)GetDismountPenetration()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float SandBox.GameComponents.SandboxAgentApplyDamageModel.GetDismountPenetration | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon*, |
|  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData* ) |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#af63a6f88686ffa9f4589bd2884e28632)GetKnockBackPenetration()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float SandBox.GameComponents.SandboxAgentApplyDamageModel.GetKnockBackPenetration | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon*, |
|  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData* ) |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#a289214ebf49f70a2c139b3682d8da2ee)GetKnockDownPenetration()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float SandBox.GameComponents.SandboxAgentApplyDamageModel.GetKnockDownPenetration | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon*, |
|  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData* ) |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#af4d29f9c54bcd838bffdb7d67f6d8a79)GetHorseChargePenetration()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override float SandBox.GameComponents.SandboxAgentApplyDamageModel.GetHorseChargePenetration | ( |  | ) |  |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#a7a88e1f6d8ebce9cf4f27da868427259)CalculateStaggerThresholdDamage()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float SandBox.GameComponents.SandboxAgentApplyDamageModel.CalculateStaggerThresholdDamage | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *defenderAgent*, |
|  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow* ) |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#a2e4a7f695b161cd863812abeb4decbfd)CalculateAlternativeAttackDamage()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float SandBox.GameComponents.SandboxAgentApplyDamageModel.CalculateAlternativeAttackDamage | ( | in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) | *attackInformation*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *weapon* ) |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#a4f244acc3720b107247f313dad991e71)CalculatePassiveAttackDamage()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float SandBox.GameComponents.SandboxAgentApplyDamageModel.CalculatePassiveAttackDamage | ( | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *attackerCharacter*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | float | *baseDamage* ) |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#a2e41272412156af0c72f75be30ac7a58)DecidePassiveAttackCollisionReaction()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [MeleeCollisionReaction](namespace_tale_worlds_1_1_mount_and_blade.html#abcba7a0a66dea15c390f0cb9ab6d1378) SandBox.GameComponents.SandboxAgentApplyDamageModel.DecidePassiveAttackCollisionReaction | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attacker*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *defender*, |
|  |  | bool | *isFatalHit* ) |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#a42c59499ef06450b2a05335edb3cfa76)CalculateShieldDamage()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float SandBox.GameComponents.SandboxAgentApplyDamageModel.CalculateShieldDamage | ( | in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) | *attackInformation*, |
|  |  | float | *baseDamage* ) |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#a75f80aa9a809626020ecf5d6e6f16ed1)CalculateSailFireDamage()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float SandBox.GameComponents.SandboxAgentApplyDamageModel.CalculateSailFireDamage | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) | *shipOrigin*, |
|  |  | float | *baseDamage*, |
|  |  | bool | *damageFromShipMachine* ) |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#a55c7a3b5a8c800d4bbe4172e7f03426a)CalculateHullFireDamage()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float SandBox.GameComponents.SandboxAgentApplyDamageModel.CalculateHullFireDamage | ( | float | *baseFireDamage*, |
|  |  | [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) | *shipOrigin* ) |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#ac4cc05f06e95cd4ce868761da6b680fd)GetDamageMultiplierForBodyPart()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float SandBox.GameComponents.SandboxAgentApplyDamageModel.GetDamageMultiplierForBodyPart | ( | [BoneBodyPartType](namespace_tale_worlds_1_1_mount_and_blade.html#a88860bf2968d0069d9696746ebb47115) | *bodyPart*, |
|  |  | [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) | *type*, |
|  |  | bool | *isHuman*, |
|  |  | bool | *isMissile* ) |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#a92d83f48b6e14cbfc5b62db80b635b55)DecideAgentShrugOffBlow()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool SandBox.GameComponents.SandboxAgentApplyDamageModel.DecideAgentShrugOffBlow | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *victimAgent*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow* ) |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#a59a81624d9406e4084d9fdc8341e8681)DecideAgentDismountedByBlow()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool SandBox.GameComponents.SandboxAgentApplyDamageModel.DecideAgentDismountedByBlow | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *victimAgent*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon*, |
|  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow* ) |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#accf216cc4c9bb545637491aa8871b2fd)DecideAgentKnockedBackByBlow()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool SandBox.GameComponents.SandboxAgentApplyDamageModel.DecideAgentKnockedBackByBlow | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *victimAgent*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon*, |
|  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow* ) |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#a5fb8eda128d6c3e6563624bc5a811d93)DecideAgentKnockedDownByBlow()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool SandBox.GameComponents.SandboxAgentApplyDamageModel.DecideAgentKnockedDownByBlow | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *victimAgent*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon*, |
|  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow* ) |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#aa9ea69cd637a23efbeb15f11928acd5e)DecideMountRearedByBlow()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool SandBox.GameComponents.SandboxAgentApplyDamageModel.DecideMountRearedByBlow | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *victimAgent*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon*, |
|  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow* ) |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#a406911a4e673ebfadf31fcd4068e31d0)DecideWeaponCollisionReaction()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void SandBox.GameComponents.SandboxAgentApplyDamageModel.DecideWeaponCollisionReaction | ( | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *registeredBlow*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attacker*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *defender*, |
|  |  | in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *attackerWeapon*, |
|  |  | bool | *isFatalHit*, |
|  |  | bool | *isShruggedOff*, |
|  |  | float | *momentumRemaining*, |
|  |  | out [MeleeCollisionReaction](namespace_tale_worlds_1_1_mount_and_blade.html#abcba7a0a66dea15c390f0cb9ab6d1378) | *colReaction* ) |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#a979dacf7228dd1e7fe4cbeeb392fdef2)ShouldMissilePassThroughAfterShieldBreak()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool SandBox.GameComponents.SandboxAgentApplyDamageModel.ShouldMissilePassThroughAfterShieldBreak | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon* ) |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_apply_damage_model.html#a306befa557a9ef945d215e4d5c9e3fd7)CalculateRemainingMomentum()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float SandBox.GameComponents.SandboxAgentApplyDamageModel.CalculateRemainingMomentum | ( | float | *originalMomentum*, |
|  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *b*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attacker*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *victim*, |
|  |  | in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *attackerWeapon*, |
|  |  | bool | *isCrushThrough* ) |

