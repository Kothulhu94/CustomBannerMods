--- SOURCE: class_sand_box_1_1_game_components_1_1_sandbox_strike_magnitude_model.html ---

SandBox.GameComponents.SandboxStrikeMagnitudeModel Class ReferenceInherits [TaleWorlds.MountAndBlade.ComponentInterfaces.StrikeMagnitudeCalculationModel](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_strike_magnitude_calculation_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override float | [CalculateHorseArcheryFactor](class_sand_box_1_1_game_components_1_1_sandbox_strike_magnitude_model.html#a83d2b329cefa0dee062867e8e92e4b5f) ([BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) characterObject) |
| override float | [CalculateStrikeMagnitudeForMissile](class_sand_box_1_1_game_components_1_1_sandbox_strike_magnitude_model.html#a4b6c79d223b1af3a6babdbe5a2643b7a) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) weapon, float missileSpeed) |
| override float | [CalculateStrikeMagnitudeForSwing](class_sand_box_1_1_game_components_1_1_sandbox_strike_magnitude_model.html#aaca915454f345ef0fd74b42c97e01e07) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) weapon, float swingSpeed, float impactPointAsPercent, float extraLinearSpeed) |
| override float | [CalculateStrikeMagnitudeForUnarmedAttack](class_sand_box_1_1_game_components_1_1_sandbox_strike_magnitude_model.html#aa08a918fee2bc1139f589ff269ff91c3) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, float progressEffect, float momentumRemaining) |
| override float | [CalculateStrikeMagnitudeForThrust](class_sand_box_1_1_game_components_1_1_sandbox_strike_magnitude_model.html#a1eb8ed754697c01649c8c909f1dd04c3) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) weapon, float thrustWeaponSpeed, float extraLinearSpeed, bool isThrown=false) |
| override float | [ComputeRawDamage](class_sand_box_1_1_game_components_1_1_sandbox_strike_magnitude_model.html#a18955e1aa76bc2c677b66ca0225cdae9) ([DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) damageType, float magnitude, float armorEffectiveness, float absorbedDamageRatio) |
| override float | [GetBluntDamageFactorByDamageType](class_sand_box_1_1_game_components_1_1_sandbox_strike_magnitude_model.html#a93c97e64cccb3c983f1945eded4742c8) ([DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) damageType) |
| override float | [CalculateAdjustedArmorForBlow](class_sand_box_1_1_game_components_1_1_sandbox_strike_magnitude_model.html#a66ae36297fb864980d190b10cd72d223) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, float baseArmor, [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) attackerCharacter, [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) attackerCaptainCharacter, [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) victimCharacter, [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) victimCaptainCharacter, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) weaponComponent) |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.ComponentInterfaces.StrikeMagnitudeCalculationModel](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_strike_magnitude_calculation_model.html) | |
| float | [CalculateStrikeMagnitudeForMissile](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_strike_magnitude_calculation_model.html#a32710543dd09dd93544ceb9fe58cb4d1) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) weapon, float missileSpeed) |
| float | [CalculateStrikeMagnitudeForSwing](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_strike_magnitude_calculation_model.html#add1cca263e8c313949340387d4dd8aef) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) weapon, float swingSpeed, float impactPointAsPercent, float extraLinearSpeed) |
| float | [CalculateStrikeMagnitudeForThrust](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_strike_magnitude_calculation_model.html#a3044c72ead8022944bd8708c9d57365c) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) weapon, float thrustSpeed, float extraLinearSpeed, bool isThrown=false) |
| float | [ComputeRawDamage](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_strike_magnitude_calculation_model.html#a1d3c5d4fb078bbdc7385b73804c0bef2) ([DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) damageType, float magnitude, float armorEffectiveness, float absorbedDamageRatio) |
| float | [CalculateStrikeMagnitudeForUnarmedAttack](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_strike_magnitude_calculation_model.html#a01b80bdee7c0098f2c5be6c3b894ea67) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, float progressEffect, float momentumRemaining) |
| float | [GetBluntDamageFactorByDamageType](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_strike_magnitude_calculation_model.html#af14e4f47239d9d28265ffc7259b46314) ([DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) damageType) |
| float | [CalculateHorseArcheryFactor](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_strike_magnitude_calculation_model.html#af2bef9fdbc666626177b11899f7b9d2a) ([BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) characterObject) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_game_components_1_1_sandbox_strike_magnitude_model.html#a83d2b329cefa0dee062867e8e92e4b5f)CalculateHorseArcheryFactor()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float SandBox.GameComponents.SandboxStrikeMagnitudeModel.CalculateHorseArcheryFactor | ( | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *characterObject* | ) |  |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_strike_magnitude_model.html#a4b6c79d223b1af3a6babdbe5a2643b7a)CalculateStrikeMagnitudeForMissile()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float SandBox.GameComponents.SandboxStrikeMagnitudeModel.CalculateStrikeMagnitudeForMissile | ( | in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) | *attackInformation*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *weapon*, |
|  |  | float | *missileSpeed* ) |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_strike_magnitude_model.html#aaca915454f345ef0fd74b42c97e01e07)CalculateStrikeMagnitudeForSwing()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float SandBox.GameComponents.SandboxStrikeMagnitudeModel.CalculateStrikeMagnitudeForSwing | ( | in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) | *attackInformation*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *weapon*, |
|  |  | float | *swingSpeed*, |
|  |  | float | *impactPointAsPercent*, |
|  |  | float | *extraLinearSpeed* ) |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_strike_magnitude_model.html#aa08a918fee2bc1139f589ff269ff91c3)CalculateStrikeMagnitudeForUnarmedAttack()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float SandBox.GameComponents.SandboxStrikeMagnitudeModel.CalculateStrikeMagnitudeForUnarmedAttack | ( | in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) | *attackInformation*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | float | *progressEffect*, |
|  |  | float | *momentumRemaining* ) |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_strike_magnitude_model.html#a1eb8ed754697c01649c8c909f1dd04c3)CalculateStrikeMagnitudeForThrust()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float SandBox.GameComponents.SandboxStrikeMagnitudeModel.CalculateStrikeMagnitudeForThrust | ( | in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) | *attackInformation*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *weapon*, |
|  |  | float | *thrustWeaponSpeed*, |
|  |  | float | *extraLinearSpeed*, |
|  |  | bool | *isThrown* = false ) |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_strike_magnitude_model.html#a18955e1aa76bc2c677b66ca0225cdae9)ComputeRawDamage()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float SandBox.GameComponents.SandboxStrikeMagnitudeModel.ComputeRawDamage | ( | [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) | *damageType*, |
|  |  | float | *magnitude*, |
|  |  | float | *armorEffectiveness*, |
|  |  | float | *absorbedDamageRatio* ) |

Parameters
:   |  |  |
    | --- | --- |
    | damageType |  |
    | magnitude |  |
    | absorbedDamageRatio |  |
    | armorEffectiveness |  |

Returns

[◆](class_sand_box_1_1_game_components_1_1_sandbox_strike_magnitude_model.html#a93c97e64cccb3c983f1945eded4742c8)GetBluntDamageFactorByDamageType()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float SandBox.GameComponents.SandboxStrikeMagnitudeModel.GetBluntDamageFactorByDamageType | ( | [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) | *damageType* | ) |  |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_strike_magnitude_model.html#a66ae36297fb864980d190b10cd72d223)CalculateAdjustedArmorForBlow()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override float SandBox.GameComponents.SandboxStrikeMagnitudeModel.CalculateAdjustedArmorForBlow | ( | in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) | *attackInformation*, | |  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, | |  |  | float | *baseArmor*, | |  |  | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *attackerCharacter*, | |  |  | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *attackerCaptainCharacter*, | |  |  | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *victimCharacter*, | |  |  | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *victimCaptainCharacter*, | |  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *weaponComponent* ) | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.ComponentInterfaces.StrikeMagnitudeCalculationModel](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_strike_magnitude_calculation_model.html#a95e65de80f8799fea881d6858c2207dd).

