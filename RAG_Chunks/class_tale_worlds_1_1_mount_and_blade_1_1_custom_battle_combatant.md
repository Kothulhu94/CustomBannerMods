--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html ---

TaleWorlds.MountAndBlade.CustomBattleCombatant Class ReferenceInherits [TaleWorlds.Core.IBattleCombatant](interface_tale_worlds_1_1_core_1_1_i_battle_combatant.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| int | [GetTacticsSkillAmount](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html#a65e94e8a1c86648ed1901f14239b1d93) () |
|  | [CustomBattleCombatant](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html#a9efff15f219a875e7c1b0148ba2d91a7) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) name, [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) culture, [Banner](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html#af1a7a42d0beb70c98a954776cc714ec3) banner) |
| void | [AddCharacter](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html#ad8213fff27f9ff3d009a3ff09b876099) ([BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) characterObject, int number) |
| void | [SetGeneral](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html#af447f7e0c0613ae9d36d5e0662736dd5) ([BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) generalCharacter) |

|  |  |
| --- | --- |
| Properties | |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html#a2bb972b5e200d990e3efd79592b56cf7) `[get]` |
| [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | [Side](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html#a32c4ab4e12c3363f80e0e190bdb2b202) `[get, set]` |
| [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | [General](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html#a67836c82023d6960d0f140224f380434) `[get]` |
| [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) | [BasicCulture](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html#a6eb6506a1bacb33c9e20a39441ac4e7d) `[get]` |
| Tuple< uint, uint > | [PrimaryColorPair](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html#aa5c212d51ec9acdd8c112c432927fb03) `[get]` |
| Tuple< uint, uint > | [AlternativeColorPair](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html#a34eabbd860fa6794d503dcdeda3e9b09) `[get]` |
| Banner | [Banner](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html#af1a7a42d0beb70c98a954776cc714ec3) `[get]` |
| IEnumerable< [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) > | [Characters](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html#a3ee82f40592e475d2bb9314227d61de8) `[get]` |
| int | [CountOfCharacters](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html#a3dedd342db257cad5f715cffb06afe52) `[get]` |
| int | [NumberOfAllMembers](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html#ad362123ecf997cc93388d4097cb15ebe) `[get]` |
| int | [NumberOfHealthyMembers](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html#a450cbe99954901ea6de328202add6bf0) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html#a9efff15f219a875e7c1b0148ba2d91a7)CustomBattleCombatant()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.CustomBattleCombatant.CustomBattleCombatant | ( | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *name*, |
|  |  | [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) | *culture*, |
|  |  | [Banner](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html#af1a7a42d0beb70c98a954776cc714ec3) | *banner* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html#a65e94e8a1c86648ed1901f14239b1d93)GetTacticsSkillAmount()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.CustomBattleCombatant.GetTacticsSkillAmount | ( |  | ) |  |

Implements [TaleWorlds.Core.IBattleCombatant](interface_tale_worlds_1_1_core_1_1_i_battle_combatant.html#a2f81f18eb3d621d5941a7785977342c8).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html#ad8213fff27f9ff3d009a3ff09b876099)AddCharacter()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.CustomBattleCombatant.AddCharacter | ( | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *characterObject*, |
|  |  | int | *number* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html#af447f7e0c0613ae9d36d5e0662736dd5)SetGeneral()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.CustomBattleCombatant.SetGeneral | ( | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *generalCharacter* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html#a2bb972b5e200d990e3efd79592b56cf7)Name
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.MountAndBlade.CustomBattleCombatant.Name | | get |

Implements [TaleWorlds.Core.IBattleCombatant](interface_tale_worlds_1_1_core_1_1_i_battle_combatant.html#a8c22f00b4cee26b345dc6232ad4f1522).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html#a32c4ab4e12c3363f80e0e190bdb2b202)Side
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) TaleWorlds.MountAndBlade.CustomBattleCombatant.Side | | getset |

Implements [TaleWorlds.Core.IBattleCombatant](interface_tale_worlds_1_1_core_1_1_i_battle_combatant.html#a5386c84e433d7a197715f790dcb32ceb).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html#a67836c82023d6960d0f140224f380434)General
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) TaleWorlds.MountAndBlade.CustomBattleCombatant.General | | get |

Implements [TaleWorlds.Core.IBattleCombatant](interface_tale_worlds_1_1_core_1_1_i_battle_combatant.html#adece67aa0876a4f2f3997a1a3a295b1e).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html#a6eb6506a1bacb33c9e20a39441ac4e7d)BasicCulture
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) TaleWorlds.MountAndBlade.CustomBattleCombatant.BasicCulture | | get |

Implements [TaleWorlds.Core.IBattleCombatant](interface_tale_worlds_1_1_core_1_1_i_battle_combatant.html#a12557e16a93d68d470670af6410e30ea).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html#aa5c212d51ec9acdd8c112c432927fb03)PrimaryColorPair
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Tuple<uint, uint> TaleWorlds.MountAndBlade.CustomBattleCombatant.PrimaryColorPair | | get |

Implements [TaleWorlds.Core.IBattleCombatant](interface_tale_worlds_1_1_core_1_1_i_battle_combatant.html#a2cfbcfba83fd48bd8341f2ebcdfa333d).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html#a34eabbd860fa6794d503dcdeda3e9b09)AlternativeColorPair
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Tuple<uint, uint> TaleWorlds.MountAndBlade.CustomBattleCombatant.AlternativeColorPair | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html#af1a7a42d0beb70c98a954776cc714ec3)Banner
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Banner TaleWorlds.MountAndBlade.CustomBattleCombatant.Banner | | get |

Implements [TaleWorlds.Core.IBattleCombatant](interface_tale_worlds_1_1_core_1_1_i_battle_combatant.html#ad9273cd85a1b3b5aa7ab8db3899ce061).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html#a3ee82f40592e475d2bb9314227d61de8)Characters
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IEnumerable<[BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html)> TaleWorlds.MountAndBlade.CustomBattleCombatant.Characters | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html#a3dedd342db257cad5f715cffb06afe52)CountOfCharacters
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.CustomBattleCombatant.CountOfCharacters | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html#ad362123ecf997cc93388d4097cb15ebe)NumberOfAllMembers
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.CustomBattleCombatant.NumberOfAllMembers | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html#a450cbe99954901ea6de328202add6bf0)NumberOfHealthyMembers
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.CustomBattleCombatant.NumberOfHealthyMembers | | get |

