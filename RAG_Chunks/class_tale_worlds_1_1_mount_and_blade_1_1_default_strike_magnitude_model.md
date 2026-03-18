--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_default_strike_magnitude_model.html ---

TaleWorlds.MountAndBlade.DefaultStrikeMagnitudeModel Class ReferenceInherits [TaleWorlds.MountAndBlade.ComponentInterfaces.StrikeMagnitudeCalculationModel](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_strike_magnitude_calculation_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override float | [CalculateStrikeMagnitudeForMissile](class_tale_worlds_1_1_mount_and_blade_1_1_default_strike_magnitude_model.html#a8eb0e13b40dcba21d2d2e02767d0e729) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) weapon, float missileSpeed) |
| override float | [CalculateStrikeMagnitudeForSwing](class_tale_worlds_1_1_mount_and_blade_1_1_default_strike_magnitude_model.html#a95052f80e39df78677ffc0f923d245ce) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) weapon, float swingSpeed, float impactPointAsPercent, float extraLinearSpeed) |
| override float | [CalculateStrikeMagnitudeForUnarmedAttack](class_tale_worlds_1_1_mount_and_blade_1_1_default_strike_magnitude_model.html#aa2f07da21806c1eea8bb60e273f6cfdf) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, float progressEffect, float momentumRemaining) |
| override float | [CalculateStrikeMagnitudeForThrust](class_tale_worlds_1_1_mount_and_blade_1_1_default_strike_magnitude_model.html#af608301ae378184c2fc0e81dfeefbf90) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) weapon, float thrustWeaponSpeed, float extraLinearSpeed, bool isThrown=false) |
| override float | [ComputeRawDamage](class_tale_worlds_1_1_mount_and_blade_1_1_default_strike_magnitude_model.html#a269ee0efbcbc9096ba094579dc91768d) ([DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) damageType, float magnitude, float armorEffectiveness, float absorbedDamageRatio) |
| override float | [GetBluntDamageFactorByDamageType](class_tale_worlds_1_1_mount_and_blade_1_1_default_strike_magnitude_model.html#a14393a9d2bd536f76b3d6553111a6688) ([DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) damageType) |
| override float | [CalculateHorseArcheryFactor](class_tale_worlds_1_1_mount_and_blade_1_1_default_strike_magnitude_model.html#af464d08b7101839d74a6fd66d296a875) ([BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) characterObject) |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.ComponentInterfaces.StrikeMagnitudeCalculationModel](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_strike_magnitude_calculation_model.html) | |
| float | [CalculateStrikeMagnitudeForMissile](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_strike_magnitude_calculation_model.html#a32710543dd09dd93544ceb9fe58cb4d1) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) weapon, float missileSpeed) |
| float | [CalculateStrikeMagnitudeForSwing](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_strike_magnitude_calculation_model.html#add1cca263e8c313949340387d4dd8aef) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) weapon, float swingSpeed, float impactPointAsPercent, float extraLinearSpeed) |
| float | [CalculateStrikeMagnitudeForThrust](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_strike_magnitude_calculation_model.html#a3044c72ead8022944bd8708c9d57365c) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) weapon, float thrustSpeed, float extraLinearSpeed, bool isThrown=false) |
| float | [ComputeRawDamage](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_strike_magnitude_calculation_model.html#a1d3c5d4fb078bbdc7385b73804c0bef2) ([DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) damageType, float magnitude, float armorEffectiveness, float absorbedDamageRatio) |
| float | [CalculateStrikeMagnitudeForUnarmedAttack](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_strike_magnitude_calculation_model.html#a01b80bdee7c0098f2c5be6c3b894ea67) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, float progressEffect, float momentumRemaining) |
| float | [GetBluntDamageFactorByDamageType](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_strike_magnitude_calculation_model.html#af14e4f47239d9d28265ffc7259b46314) ([DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) damageType) |
| float | [CalculateHorseArcheryFactor](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_strike_magnitude_calculation_model.html#af2bef9fdbc666626177b11899f7b9d2a) ([BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) characterObject) |
| virtual float | [CalculateAdjustedArmorForBlow](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_strike_magnitude_calculation_model.html#a95e65de80f8799fea881d6858c2207dd) (in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) attackInformation, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, float baseArmor, [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) attackerCharacter, [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) attackerCaptainCharacter, [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) victimCharacter, [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) victimCaptainCharacter, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) weaponComponent) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_strike_magnitude_model.html#a8eb0e13b40dcba21d2d2e02767d0e729)CalculateStrikeMagnitudeForMissile()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.DefaultStrikeMagnitudeModel.CalculateStrikeMagnitudeForMissile | ( | in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) | *attackInformation*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *weapon*, |
|  |  | float | *missileSpeed* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_strike_magnitude_model.html#a95052f80e39df78677ffc0f923d245ce)CalculateStrikeMagnitudeForSwing()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.DefaultStrikeMagnitudeModel.CalculateStrikeMagnitudeForSwing | ( | in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) | *attackInformation*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *weapon*, |
|  |  | float | *swingSpeed*, |
|  |  | float | *impactPointAsPercent*, |
|  |  | float | *extraLinearSpeed* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_strike_magnitude_model.html#aa2f07da21806c1eea8bb60e273f6cfdf)CalculateStrikeMagnitudeForUnarmedAttack()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.DefaultStrikeMagnitudeModel.CalculateStrikeMagnitudeForUnarmedAttack | ( | in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) | *attackInformation*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | float | *progressEffect*, |
|  |  | float | *momentumRemaining* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_strike_magnitude_model.html#af608301ae378184c2fc0e81dfeefbf90)CalculateStrikeMagnitudeForThrust()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.DefaultStrikeMagnitudeModel.CalculateStrikeMagnitudeForThrust | ( | in [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html) | *attackInformation*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *weapon*, |
|  |  | float | *thrustWeaponSpeed*, |
|  |  | float | *extraLinearSpeed*, |
|  |  | bool | *isThrown* = false ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_strike_magnitude_model.html#a269ee0efbcbc9096ba094579dc91768d)ComputeRawDamage()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.DefaultStrikeMagnitudeModel.ComputeRawDamage | ( | [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) | *damageType*, |
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

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_strike_magnitude_model.html#a14393a9d2bd536f76b3d6553111a6688)GetBluntDamageFactorByDamageType()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.DefaultStrikeMagnitudeModel.GetBluntDamageFactorByDamageType | ( | [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) | *damageType* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_strike_magnitude_model.html#af464d08b7101839d74a6fd66d296a875)CalculateHorseArcheryFactor()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.DefaultStrikeMagnitudeModel.CalculateHorseArcheryFactor | ( | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *characterObject* | ) |  |

