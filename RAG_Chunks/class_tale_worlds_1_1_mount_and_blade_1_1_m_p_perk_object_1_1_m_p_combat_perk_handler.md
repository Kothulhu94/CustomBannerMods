--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_combat_perk_handler.html ---

TaleWorlds.MountAndBlade.MPPerkObject.MPCombatPerkHandler Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
| float | [GetDamage](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_combat_perk_handler.html#acb242a62b22740cd41df1c85d7762536) ([WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) damageType, bool isAlternativeAttack) |
| float | [GetDamageTaken](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_combat_perk_handler.html#a7a42c0c3d082cf6a8d42bbcee17f8132) ([WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) damageType) |
| float | [GetSpeedBonusEffectiveness](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_combat_perk_handler.html#ae3423df570635e9a6c4d5da5b74fad5b) ([WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) damageType) |
| float | [GetShieldDamage](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_combat_perk_handler.html#ad4d2404cbd79851e8a6177ff6af1e8d8) (bool isCorrectSideBlock) |
| float | [GetShieldDamageTaken](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_combat_perk_handler.html#ac2489c30cc9605a8722cae038d426068) (bool isCorrectSideBlock) |
| float | [GetRangedHeadShotDamage](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_combat_perk_handler.html#ae00e6686ebf57c5f1a2e76c77b086525) () |

|  |  |
| --- | --- |
| Protected Member Functions | |
|  | [MPCombatPerkHandler](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_combat_perk_handler.html#afe8968ae66129596aaa6e4bbff11e036) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attacker, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) defender) |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsWarmup](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_combat_perk_handler.html#a8652d5fcdeb5debff835b5525f5e0c0b) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_combat_perk_handler.html#afe8968ae66129596aaa6e4bbff11e036)MPCombatPerkHandler()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | TaleWorlds.MountAndBlade.MPPerkObject.MPCombatPerkHandler.MPCombatPerkHandler | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attacker*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *defender* ) | | protected |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_combat_perk_handler.html#acb242a62b22740cd41df1c85d7762536)GetDamage()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.MPPerkObject.MPCombatPerkHandler.GetDamage | ( | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon*, |
|  |  | [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) | *damageType*, |
|  |  | bool | *isAlternativeAttack* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_combat_perk_handler.html#a7a42c0c3d082cf6a8d42bbcee17f8132)GetDamageTaken()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.MPPerkObject.MPCombatPerkHandler.GetDamageTaken | ( | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon*, |
|  |  | [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) | *damageType* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_combat_perk_handler.html#ae3423df570635e9a6c4d5da5b74fad5b)GetSpeedBonusEffectiveness()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.MPPerkObject.MPCombatPerkHandler.GetSpeedBonusEffectiveness | ( | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon*, |
|  |  | [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) | *damageType* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_combat_perk_handler.html#ad4d2404cbd79851e8a6177ff6af1e8d8)GetShieldDamage()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.MPPerkObject.MPCombatPerkHandler.GetShieldDamage | ( | bool | *isCorrectSideBlock* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_combat_perk_handler.html#ac2489c30cc9605a8722cae038d426068)GetShieldDamageTaken()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.MPPerkObject.MPCombatPerkHandler.GetShieldDamageTaken | ( | bool | *isCorrectSideBlock* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_combat_perk_handler.html#ae00e6686ebf57c5f1a2e76c77b086525)GetRangedHeadShotDamage()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.MPPerkObject.MPCombatPerkHandler.GetRangedHeadShotDamage | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_combat_perk_handler.html#a8652d5fcdeb5debff835b5525f5e0c0b)IsWarmup
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.MPPerkObject.MPCombatPerkHandler.IsWarmup | | get |

