--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html ---

TaleWorlds.MountAndBlade.MultiplayerAgentApplyDamageModel Class ReferenceInherits [TaleWorlds.MountAndBlade.ComponentInterfaces.AgentApplyDamageModel](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_agent_apply_damage_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override bool | [IsDamageIgnored](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#aadb40dd22a98c182a97627f4fd302873) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData) |
| override float | [ApplyDamageAmplifications](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#a5b77f7f3b1d19127f9977331ebfc49e5) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, float baseDamage) |
| override float | [ApplyDamageScaling](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#a51eb466fe56b798cbe6902ff865d0be3) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, float baseDamage) |
| override float | [ApplyDamageReductions](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#aa91e315deab6569427d2c865e7ec4316) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, float baseDamage) |
| override float | [ApplyGeneralDamageModifiers](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#a3492eca26288defd78510e3b39cf7e7a) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, float baseDamage) |
| override void | [DecideMissileWeaponFlags](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#a6f27f4299821926187b5d24b2b1b53e3) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) missileWeapon, ref [WeaponFlags](namespace_tale_worlds_1_1_core.html#a777ba058af61ad6bd9a4a27124c20051) missileWeaponFlags) |
| override bool | [DecideCrushedThrough](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#a8f96cb83c11b94cf16143579cdc2dc45) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) defenderAgent, float totalAttackEnergy, [Agent.UsageDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922a) attackDirection, [StrikeType](namespace_tale_worlds_1_1_core.html#a2adc9126cb9a9e45bc133ebc57833835) strikeType, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) defendItem, bool isPassiveUsage) |
| override bool | [CanWeaponDealSneakAttack](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#adf413dde92467977067b637f541923d9) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) weapon) |
| override bool | [CanWeaponDismount](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#a93741ac76ec9b37a62e0081ce1745bcd) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData) |
| override void | [CalculateDefendedBlowStunMultipliers](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#af70eeb28d0e448bd6233da165d506647) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) defenderAgent, [CombatCollisionResult](namespace_tale_worlds_1_1_mount_and_blade.html#a69ccd75a0d558392b56af494b23edcfc) collisionResult, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) defenderWeapon, ref float attackerStunPeriod, ref float defenderStunPeriod) |
| override bool | [CanWeaponKnockback](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#af8dfab71a7d42d0bd98297c9d4907975) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData) |
| override bool | [CanWeaponKnockDown](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#a282933c24b46444f256e1ab57bcd7c61) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victimAgent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData) |
| override float | [GetDismountPenetration](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#ab9fd759ae74d1bfbbc0801132dd9d58e) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) attackCollisionData) |
| override float | [GetKnockBackPenetration](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#a2b16749ec9093cec348a8de2ae30db92) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) attackCollisionData) |
| override float | [GetKnockDownPenetration](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#aea2e7916ef8302be3d47c5b7c9ad665f) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) attackCollisionData) |
| override float | [GetHorseChargePenetration](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#ae2601815c6d3d86b4cb5471c467566ff) () |
| override float | [CalculateStaggerThresholdDamage](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#ab5d23c473a913be0fc12d8525549d88f) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) defenderAgent, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow) |
| override float | [CalculateAlternativeAttackDamage](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#aa69d9c67c825feb0143974a199eda5ca) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) weapon) |
| override float | [CalculatePassiveAttackDamage](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#aba056e5c1eb47b3233d1a1bba69f61e8) ([BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) attackerCharacter, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, float baseDamage) |
| override [MeleeCollisionReaction](namespace_tale_worlds_1_1_mount_and_blade.html#abcba7a0a66dea15c390f0cb9ab6d1378) | [DecidePassiveAttackCollisionReaction](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#a41e6f6b80ad7369c8c2857d1b76d24a2) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attacker, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) defender, bool isFatalHit) |
| override float | [CalculateShieldDamage](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#a3665455b289bf2282777b760d95f23d9) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, float baseDamage) |
| override float | [CalculateSailFireDamage](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#a0f48e79e7b982193e4880e7bd54ba138) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) shipOrigin, float baseDamage, bool damageFromShipMachine) |
| override float | [CalculateHullFireDamage](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#add053b104034c8570f2469f9efcbac5b) (float baseFireDamage, [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) shipOrigin) |
| override float | [GetDamageMultiplierForBodyPart](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#afea7053f2b95bc4a711582254967aa03) ([BoneBodyPartType](namespace_tale_worlds_1_1_mount_and_blade.html#a88860bf2968d0069d9696746ebb47115) bodyPart, [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) type, bool isHuman, bool isMissile) |
| override bool | [CanWeaponIgnoreFriendlyFireChecks](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#a00d018f956698edd4afe71ef18fa5020) ([WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) weapon) |
| override bool | [DecideAgentShrugOffBlow](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#ac0a9b9e08565e73469a43c41503578f8) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victimAgent, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow) |
| override bool | [DecideAgentDismountedByBlow](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#a427204665be67f9ccd66e21fe7418c2a) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victimAgent, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow) |
| override bool | [DecideAgentKnockedBackByBlow](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#af9fbf2fe2fbf11bf462f8d6d6d1d6b44) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victimAgent, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow) |
| override bool | [DecideAgentKnockedDownByBlow](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#a0f70e81c86fbde2bda497793212282b9) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victimAgent, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow) |
| override bool | [DecideMountRearedByBlow](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#afd28811b7fb13519d0b936187a60e503) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victimAgent, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow) |
| override void | [DecideWeaponCollisionReaction](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#a36de8ed0a7cac859973195dcbaf4e722) (in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) registeredBlow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attacker, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) defender, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) attackerWeapon, bool isFatalHit, bool isShruggedOff, float momentumRemaining, out [MeleeCollisionReaction](namespace_tale_worlds_1_1_mount_and_blade.html#abcba7a0a66dea15c390f0cb9ab6d1378) colReaction) |
| override bool | [ShouldMissilePassThroughAfterShieldBreak](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#aab7fbf7484f28ff89ec2ffc1bda9b671) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon) |
| override float | [CalculateRemainingMomentum](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#a21e51f8239c42ca7c3861490bc63ef80) (float originalMomentum, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) b, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attacker, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victim, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) attackerWeapon, bool isCrushThrough) |
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

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#aadb40dd22a98c182a97627f4fd302873)IsDamageIgnored()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.MountAndBlade.MultiplayerAgentApplyDamageModel.IsDamageIgnored | ( | in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) | *attackInformation*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#a5b77f7f3b1d19127f9977331ebfc49e5)ApplyDamageAmplifications()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.MultiplayerAgentApplyDamageModel.ApplyDamageAmplifications | ( | in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) | *attackInformation*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | float | *baseDamage* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#a51eb466fe56b798cbe6902ff865d0be3)ApplyDamageScaling()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.MultiplayerAgentApplyDamageModel.ApplyDamageScaling | ( | in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) | *attackInformation*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | float | *baseDamage* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#aa91e315deab6569427d2c865e7ec4316)ApplyDamageReductions()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.MultiplayerAgentApplyDamageModel.ApplyDamageReductions | ( | in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) | *attackInformation*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | float | *baseDamage* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#a3492eca26288defd78510e3b39cf7e7a)ApplyGeneralDamageModifiers()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.MultiplayerAgentApplyDamageModel.ApplyGeneralDamageModifiers | ( | in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) | *attackInformation*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | float | *baseDamage* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#a6f27f4299821926187b5d24b2b1b53e3)DecideMissileWeaponFlags()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.MountAndBlade.MultiplayerAgentApplyDamageModel.DecideMissileWeaponFlags | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *missileWeapon*, |
|  |  | ref [WeaponFlags](namespace_tale_worlds_1_1_core.html#a777ba058af61ad6bd9a4a27124c20051) | *missileWeaponFlags* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#a8f96cb83c11b94cf16143579cdc2dc45)DecideCrushedThrough()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.MountAndBlade.MultiplayerAgentApplyDamageModel.DecideCrushedThrough | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *defenderAgent*, |
|  |  | float | *totalAttackEnergy*, |
|  |  | [Agent.UsageDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922a) | *attackDirection*, |
|  |  | [StrikeType](namespace_tale_worlds_1_1_core.html#a2adc9126cb9a9e45bc133ebc57833835) | *strikeType*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *defendItem*, |
|  |  | bool | *isPassiveUsage* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#adf413dde92467977067b637f541923d9)CanWeaponDealSneakAttack()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.MountAndBlade.MultiplayerAgentApplyDamageModel.CanWeaponDealSneakAttack | ( | in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) | *attackInformation*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *weapon* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#a93741ac76ec9b37a62e0081ce1745bcd)CanWeaponDismount()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.MountAndBlade.MultiplayerAgentApplyDamageModel.CanWeaponDismount | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon*, |
|  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#af70eeb28d0e448bd6233da165d506647)CalculateDefendedBlowStunMultipliers()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.MountAndBlade.MultiplayerAgentApplyDamageModel.CalculateDefendedBlowStunMultipliers | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *defenderAgent*, |
|  |  | [CombatCollisionResult](namespace_tale_worlds_1_1_mount_and_blade.html#a69ccd75a0d558392b56af494b23edcfc) | *collisionResult*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *defenderWeapon*, |
|  |  | ref float | *attackerStunPeriod*, |
|  |  | ref float | *defenderStunPeriod* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#af8dfab71a7d42d0bd98297c9d4907975)CanWeaponKnockback()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.MountAndBlade.MultiplayerAgentApplyDamageModel.CanWeaponKnockback | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon*, |
|  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#a282933c24b46444f256e1ab57bcd7c61)CanWeaponKnockDown()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.MountAndBlade.MultiplayerAgentApplyDamageModel.CanWeaponKnockDown | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *victimAgent*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon*, |
|  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#ab9fd759ae74d1bfbbc0801132dd9d58e)GetDismountPenetration()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.MultiplayerAgentApplyDamageModel.GetDismountPenetration | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon*, |
|  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *attackCollisionData* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#a2b16749ec9093cec348a8de2ae30db92)GetKnockBackPenetration()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.MultiplayerAgentApplyDamageModel.GetKnockBackPenetration | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon*, |
|  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *attackCollisionData* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#aea2e7916ef8302be3d47c5b7c9ad665f)GetKnockDownPenetration()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.MultiplayerAgentApplyDamageModel.GetKnockDownPenetration | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon*, |
|  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *attackCollisionData* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#ae2601815c6d3d86b4cb5471c467566ff)GetHorseChargePenetration()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.MultiplayerAgentApplyDamageModel.GetHorseChargePenetration | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#ab5d23c473a913be0fc12d8525549d88f)CalculateStaggerThresholdDamage()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.MultiplayerAgentApplyDamageModel.CalculateStaggerThresholdDamage | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *defenderAgent*, |
|  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#aa69d9c67c825feb0143974a199eda5ca)CalculateAlternativeAttackDamage()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.MultiplayerAgentApplyDamageModel.CalculateAlternativeAttackDamage | ( | in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) | *attackInformation*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *weapon* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#aba056e5c1eb47b3233d1a1bba69f61e8)CalculatePassiveAttackDamage()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.MultiplayerAgentApplyDamageModel.CalculatePassiveAttackDamage | ( | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *attackerCharacter*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | float | *baseDamage* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#a41e6f6b80ad7369c8c2857d1b76d24a2)DecidePassiveAttackCollisionReaction()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [MeleeCollisionReaction](namespace_tale_worlds_1_1_mount_and_blade.html#abcba7a0a66dea15c390f0cb9ab6d1378) TaleWorlds.MountAndBlade.MultiplayerAgentApplyDamageModel.DecidePassiveAttackCollisionReaction | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attacker*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *defender*, |
|  |  | bool | *isFatalHit* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#a3665455b289bf2282777b760d95f23d9)CalculateShieldDamage()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.MultiplayerAgentApplyDamageModel.CalculateShieldDamage | ( | in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) | *attackInformation*, |
|  |  | float | *baseDamage* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#a0f48e79e7b982193e4880e7bd54ba138)CalculateSailFireDamage()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.MultiplayerAgentApplyDamageModel.CalculateSailFireDamage | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) | *shipOrigin*, |
|  |  | float | *baseDamage*, |
|  |  | bool | *damageFromShipMachine* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#add053b104034c8570f2469f9efcbac5b)CalculateHullFireDamage()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.MultiplayerAgentApplyDamageModel.CalculateHullFireDamage | ( | float | *baseFireDamage*, |
|  |  | [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) | *shipOrigin* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#afea7053f2b95bc4a711582254967aa03)GetDamageMultiplierForBodyPart()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.MultiplayerAgentApplyDamageModel.GetDamageMultiplierForBodyPart | ( | [BoneBodyPartType](namespace_tale_worlds_1_1_mount_and_blade.html#a88860bf2968d0069d9696746ebb47115) | *bodyPart*, |
|  |  | [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) | *type*, |
|  |  | bool | *isHuman*, |
|  |  | bool | *isMissile* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#a00d018f956698edd4afe71ef18fa5020)CanWeaponIgnoreFriendlyFireChecks()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.MountAndBlade.MultiplayerAgentApplyDamageModel.CanWeaponIgnoreFriendlyFireChecks | ( | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *weapon* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#ac0a9b9e08565e73469a43c41503578f8)DecideAgentShrugOffBlow()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.MountAndBlade.MultiplayerAgentApplyDamageModel.DecideAgentShrugOffBlow | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *victimAgent*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#a427204665be67f9ccd66e21fe7418c2a)DecideAgentDismountedByBlow()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.MountAndBlade.MultiplayerAgentApplyDamageModel.DecideAgentDismountedByBlow | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *victimAgent*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon*, |
|  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#af9fbf2fe2fbf11bf462f8d6d6d1d6b44)DecideAgentKnockedBackByBlow()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.MountAndBlade.MultiplayerAgentApplyDamageModel.DecideAgentKnockedBackByBlow | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *victimAgent*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon*, |
|  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#a0f70e81c86fbde2bda497793212282b9)DecideAgentKnockedDownByBlow()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.MountAndBlade.MultiplayerAgentApplyDamageModel.DecideAgentKnockedDownByBlow | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *victimAgent*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon*, |
|  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#afd28811b7fb13519d0b936187a60e503)DecideMountRearedByBlow()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.MountAndBlade.MultiplayerAgentApplyDamageModel.DecideMountRearedByBlow | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *victimAgent*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon*, |
|  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#a36de8ed0a7cac859973195dcbaf4e722)DecideWeaponCollisionReaction()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.MountAndBlade.MultiplayerAgentApplyDamageModel.DecideWeaponCollisionReaction | ( | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *registeredBlow*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attacker*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *defender*, |
|  |  | in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *attackerWeapon*, |
|  |  | bool | *isFatalHit*, |
|  |  | bool | *isShruggedOff*, |
|  |  | float | *momentumRemaining*, |
|  |  | out [MeleeCollisionReaction](namespace_tale_worlds_1_1_mount_and_blade.html#abcba7a0a66dea15c390f0cb9ab6d1378) | *colReaction* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#aab7fbf7484f28ff89ec2ffc1bda9b671)ShouldMissilePassThroughAfterShieldBreak()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.MountAndBlade.MultiplayerAgentApplyDamageModel.ShouldMissilePassThroughAfterShieldBreak | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_apply_damage_model.html#a21e51f8239c42ca7c3861490bc63ef80)CalculateRemainingMomentum()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.MultiplayerAgentApplyDamageModel.CalculateRemainingMomentum | ( | float | *originalMomentum*, |
|  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *b*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attacker*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *victim*, |
|  |  | in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *attackerWeapon*, |
|  |  | bool | *isCrushThrough* ) |

