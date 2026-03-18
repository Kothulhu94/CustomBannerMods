--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_mission_combat_mechanics_helper.html ---

TaleWorlds.MountAndBlade.MissionCombatMechanicsHelper Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static bool | [DecideAgentShrugOffBlow](class_tale_worlds_1_1_mount_and_blade_1_1_mission_combat_mechanics_helper.html#a30746efc54424738959f61d35a18a2f4) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victimAgent, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow) |
| static bool | [DecideAgentDismountedByBlow](class_tale_worlds_1_1_mount_and_blade_1_1_mission_combat_mechanics_helper.html#ab429ae8025ee080be3b54ea6798b2d0d) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victimAgent, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow) |
| static bool | [DecideAgentKnockedBackByBlow](class_tale_worlds_1_1_mount_and_blade_1_1_mission_combat_mechanics_helper.html#ae32f93f6428465c662f8529947fc35df) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victimAgent, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow) |
| static bool | [DecideAgentKnockedDownByBlow](class_tale_worlds_1_1_mount_and_blade_1_1_mission_combat_mechanics_helper.html#acbb76b876a0840a4cae31f168da50453) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victimAgent, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow) |
| static bool | [DecideMountRearedByBlow](class_tale_worlds_1_1_mount_and_blade_1_1_mission_combat_mechanics_helper.html#a325584a189ff2c0738ca85dc5a97416d) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victimAgent, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow) |
| static void | [DecideWeaponCollisionReaction](class_tale_worlds_1_1_mount_and_blade_1_1_mission_combat_mechanics_helper.html#a135c718efd360c81b7b1ecdda3c2f399) (in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) registeredBlow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attacker, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) defender, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) attackerWeapon, bool isFatalHit, bool isShruggedOff, float momentumRemaining, out [MeleeCollisionReaction](namespace_tale_worlds_1_1_mount_and_blade.html#abcba7a0a66dea15c390f0cb9ab6d1378) colReaction) |
| static bool | [IsCollisionBoneDifferentThanWeaponAttachBone](class_tale_worlds_1_1_mount_and_blade_1_1_mission_combat_mechanics_helper.html#af65a8e2ff65c934555926abfa0e4f6f2) (in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, int weaponAttachBoneIndex) |
| static bool | [DecideSweetSpotCollision](class_tale_worlds_1_1_mount_and_blade_1_1_mission_combat_mechanics_helper.html#adfdd4ce30f25cf4138a454d28d977cce) (in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData) |
| static void | [GetAttackCollisionResults](class_tale_worlds_1_1_mount_and_blade_1_1_mission_combat_mechanics_helper.html#afdd7ff385bf7e6fbfa7161c1edcf7637) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, bool crushedThrough, float momentumRemaining, bool cancelDamage, ref [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) attackCollisionData, out [CombatLogData](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html) combatLog, out int speedBonus) |
| static void | [UpdateMomentumRemaining](class_tale_worlds_1_1_mount_and_blade_1_1_mission_combat_mechanics_helper.html#ad4a9e4f6902b7a1e979b75314988ac05) (ref float momentumRemaining, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) b, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attacker, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victim, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) attackerWeapon, bool isCrushThrough) |
| static bool | [HitWithAnotherBone](class_tale_worlds_1_1_mount_and_blade_1_1_mission_combat_mechanics_helper.html#a27e0a73099c9e4f44090ae26acac8cd1) (in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attacker, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) attackerWeapon) |
| static float | [CalculateBaseMeleeBlowMagnitude](class_tale_worlds_1_1_mount_and_blade_1_1_mission_combat_mechanics_helper.html#a3801444cded678326b0b19a0148be7d6) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, [StrikeType](namespace_tale_worlds_1_1_core.html#a2adc9126cb9a9e45bc133ebc57833835) strikeType, float progressEffect, float impactPointAsPercent, float exraLinearSpeed) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_combat_mechanics_helper.html#a30746efc54424738959f61d35a18a2f4)DecideAgentShrugOffBlow()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.MissionCombatMechanicsHelper.DecideAgentShrugOffBlow | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *victimAgent*, | |  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, | |  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow* ) | | static |

GetDamageMultiplierOfCombatDifficulty(victimAgent)

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_combat_mechanics_helper.html#ab429ae8025ee080be3b54ea6798b2d0d)DecideAgentDismountedByBlow()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.MissionCombatMechanicsHelper.DecideAgentDismountedByBlow | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *victimAgent*, | |  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, | |  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon*, | |  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_combat_mechanics_helper.html#ae32f93f6428465c662f8529947fc35df)DecideAgentKnockedBackByBlow()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.MissionCombatMechanicsHelper.DecideAgentKnockedBackByBlow | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *victimAgent*, | |  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, | |  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon*, | |  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_combat_mechanics_helper.html#acbb76b876a0840a4cae31f168da50453)DecideAgentKnockedDownByBlow()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.MissionCombatMechanicsHelper.DecideAgentKnockedDownByBlow | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *victimAgent*, | |  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, | |  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon*, | |  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_combat_mechanics_helper.html#a325584a189ff2c0738ca85dc5a97416d)DecideMountRearedByBlow()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.MissionCombatMechanicsHelper.DecideMountRearedByBlow | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *victimAgent*, | |  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, | |  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon*, | |  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_combat_mechanics_helper.html#a135c718efd360c81b7b1ecdda3c2f399)DecideWeaponCollisionReaction()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MissionCombatMechanicsHelper.DecideWeaponCollisionReaction | ( | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *registeredBlow*, | |  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attacker*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *defender*, | |  |  | in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *attackerWeapon*, | |  |  | bool | *isFatalHit*, | |  |  | bool | *isShruggedOff*, | |  |  | float | *momentumRemaining*, | |  |  | out [MeleeCollisionReaction](namespace_tale_worlds_1_1_mount_and_blade.html#abcba7a0a66dea15c390f0cb9ab6d1378) | *colReaction* ) | | static |

attackerWeapon.IsEmpty no need to check due to condition above

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_combat_mechanics_helper.html#af65a8e2ff65c934555926abfa0e4f6f2)IsCollisionBoneDifferentThanWeaponAttachBone()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.MissionCombatMechanicsHelper.IsCollisionBoneDifferentThanWeaponAttachBone | ( | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, | |  |  | int | *weaponAttachBoneIndex* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_combat_mechanics_helper.html#adfdd4ce30f25cf4138a454d28d977cce)DecideSweetSpotCollision()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.MissionCombatMechanicsHelper.DecideSweetSpotCollision | ( | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_combat_mechanics_helper.html#afdd7ff385bf7e6fbfa7161c1edcf7637)GetAttackCollisionResults()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MissionCombatMechanicsHelper.GetAttackCollisionResults | ( | in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) | *attackInformation*, | |  |  | bool | *crushedThrough*, | |  |  | float | *momentumRemaining*, | |  |  | bool | *cancelDamage*, | |  |  | ref [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *attackCollisionData*, | |  |  | out [CombatLogData](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html) | *combatLog*, | |  |  | out int | *speedBonus* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_combat_mechanics_helper.html#ad4a9e4f6902b7a1e979b75314988ac05)UpdateMomentumRemaining()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MissionCombatMechanicsHelper.UpdateMomentumRemaining | ( | ref float | *momentumRemaining*, | |  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *b*, | |  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attacker*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *victim*, | |  |  | in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *attackerWeapon*, | |  |  | bool | *isCrushThrough* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_combat_mechanics_helper.html#a27e0a73099c9e4f44090ae26acac8cd1)HitWithAnotherBone()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.MissionCombatMechanicsHelper.HitWithAnotherBone | ( | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attacker*, | |  |  | in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *attackerWeapon* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_combat_mechanics_helper.html#a3801444cded678326b0b19a0148be7d6)CalculateBaseMeleeBlowMagnitude()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.MissionCombatMechanicsHelper.CalculateBaseMeleeBlowMagnitude | ( | in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) | *attackInformation*, | |  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, | |  |  | [StrikeType](namespace_tale_worlds_1_1_core.html#a2adc9126cb9a9e45bc133ebc57833835) | *strikeType*, | |  |  | float | *progressEffect*, | |  |  | float | *impactPointAsPercent*, | |  |  | float | *exraLinearSpeed* ) | | static |

