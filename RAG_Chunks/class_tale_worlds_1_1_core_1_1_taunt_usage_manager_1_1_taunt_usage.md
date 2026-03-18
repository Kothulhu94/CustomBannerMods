--- SOURCE: class_tale_worlds_1_1_core_1_1_taunt_usage_manager_1_1_taunt_usage.html ---

TaleWorlds.Core.TauntUsageManager.TauntUsage Class Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [TauntUsageFlag](class_tale_worlds_1_1_core_1_1_taunt_usage_manager_1_1_taunt_usage.html#ac6eea7b7d0a87574366ca374c2dd657a) {     [None](class_tale_worlds_1_1_core_1_1_taunt_usage_manager_1_1_taunt_usage.html#ac6eea7b7d0a87574366ca374c2dd657aa6adf97f83acf6453d4a6a4b1070f3754) = 0 << 0 ,     [RequiresBow](class_tale_worlds_1_1_core_1_1_taunt_usage_manager_1_1_taunt_usage.html#ac6eea7b7d0a87574366ca374c2dd657aa49d86c0af0e6cd0f500ede2143169ae5) = 1 << 0 ,     [RequiresShield](class_tale_worlds_1_1_core_1_1_taunt_usage_manager_1_1_taunt_usage.html#ac6eea7b7d0a87574366ca374c2dd657aae41abc2098e432b37060af5d6559830b) = 1 << 1 ,     [IsLeftStance](class_tale_worlds_1_1_core_1_1_taunt_usage_manager_1_1_taunt_usage.html#ac6eea7b7d0a87574366ca374c2dd657aa9926ff29239f042390560841b2d28855) = 1 << 2 ,     [RequiresOnFoot](class_tale_worlds_1_1_core_1_1_taunt_usage_manager_1_1_taunt_usage.html#ac6eea7b7d0a87574366ca374c2dd657aa138bf2c99e34dc0f47601727b9c0755b) = 1 << 3 ,     [UnsuitableForTwoHanded](class_tale_worlds_1_1_core_1_1_taunt_usage_manager_1_1_taunt_usage.html#ac6eea7b7d0a87574366ca374c2dd657aa386ab957b1369c079b47dc6dc0da249f) = 1 << 4 ,     [UnsuitableForOneHanded](class_tale_worlds_1_1_core_1_1_taunt_usage_manager_1_1_taunt_usage.html#ac6eea7b7d0a87574366ca374c2dd657aa23021b09c7d3f23b64ac990ac1145840) = 1 << 5 ,     [UnsuitableForShield](class_tale_worlds_1_1_core_1_1_taunt_usage_manager_1_1_taunt_usage.html#ac6eea7b7d0a87574366ca374c2dd657aadda1deb934ae8a660a393911e778e615) = 1 << 6 ,     [UnsuitableForBow](class_tale_worlds_1_1_core_1_1_taunt_usage_manager_1_1_taunt_usage.html#ac6eea7b7d0a87574366ca374c2dd657aadf85523f2bd533d47a973c27220d60f2) = 1 << 7 ,     [UnsuitableForCrossbow](class_tale_worlds_1_1_core_1_1_taunt_usage_manager_1_1_taunt_usage.html#ac6eea7b7d0a87574366ca374c2dd657aa931a01f9dae50fd4a5bac7fe14c633d9) = 1 << 8 ,     [UnsuitableForEmpty](class_tale_worlds_1_1_core_1_1_taunt_usage_manager_1_1_taunt_usage.html#ac6eea7b7d0a87574366ca374c2dd657aa0eda956601d46f1e22dd009ff9b8a853) = 1 << 9   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [TauntUsage](class_tale_worlds_1_1_core_1_1_taunt_usage_manager_1_1_taunt_usage.html#a39a60b9264252269a45fec46d902dffd) ([TauntUsageFlag](class_tale_worlds_1_1_core_1_1_taunt_usage_manager_1_1_taunt_usage.html#ac6eea7b7d0a87574366ca374c2dd657a) usageFlag, string actionName) |
| bool | [IsSuitable](class_tale_worlds_1_1_core_1_1_taunt_usage_manager_1_1_taunt_usage.html#a0b12807f4dbce6e9c8847e5c1fe28ab9) (bool isLeftStance, bool isOnFoot, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) mainHandWeapon, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) offhandWeapon) |
| [TauntUsageFlag](class_tale_worlds_1_1_core_1_1_taunt_usage_manager_1_1_taunt_usage.html#ac6eea7b7d0a87574366ca374c2dd657a) | [GetIsNotSuitableReason](class_tale_worlds_1_1_core_1_1_taunt_usage_manager_1_1_taunt_usage.html#aac68a7b8530a68519e005048254fd931) (bool isLeftStance, bool isOnFoot, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) mainHandWeapon, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) offhandWeapon) |
| string | [GetAction](class_tale_worlds_1_1_core_1_1_taunt_usage_manager_1_1_taunt_usage.html#a46f5c0aa6497b5d0d4c82bac62750285) () |

|  |  |
| --- | --- |
| Properties | |
| [TauntUsageFlag](class_tale_worlds_1_1_core_1_1_taunt_usage_manager_1_1_taunt_usage.html#ac6eea7b7d0a87574366ca374c2dd657a) | [UsageFlag](class_tale_worlds_1_1_core_1_1_taunt_usage_manager_1_1_taunt_usage.html#a8d815932842baebc05a9a01c6bc7a4e7) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_core_1_1_taunt_usage_manager_1_1_taunt_usage.html#ac6eea7b7d0a87574366ca374c2dd657a)TauntUsageFlag
----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.Core.TauntUsageManager.TauntUsage.TauntUsageFlag](class_tale_worlds_1_1_core_1_1_taunt_usage_manager_1_1_taunt_usage.html#ac6eea7b7d0a87574366ca374c2dd657a) |

| Enumerator | |
| --- | --- |
| None |  |
| RequiresBow |  |
| RequiresShield |  |
| IsLeftStance |  |
| RequiresOnFoot |  |
| UnsuitableForTwoHanded |  |
| UnsuitableForOneHanded |  |
| UnsuitableForShield |  |
| UnsuitableForBow |  |
| UnsuitableForCrossbow |  |
| UnsuitableForEmpty |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_core_1_1_taunt_usage_manager_1_1_taunt_usage.html#a39a60b9264252269a45fec46d902dffd)TauntUsage()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Core.TauntUsageManager.TauntUsage.TauntUsage | ( | [TauntUsageFlag](class_tale_worlds_1_1_core_1_1_taunt_usage_manager_1_1_taunt_usage.html#ac6eea7b7d0a87574366ca374c2dd657a) | *usageFlag*, |
|  |  | string | *actionName* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_taunt_usage_manager_1_1_taunt_usage.html#a0b12807f4dbce6e9c8847e5c1fe28ab9)IsSuitable()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Core.TauntUsageManager.TauntUsage.IsSuitable | ( | bool | *isLeftStance*, |
|  |  | bool | *isOnFoot*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *mainHandWeapon*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *offhandWeapon* ) |

[◆](class_tale_worlds_1_1_core_1_1_taunt_usage_manager_1_1_taunt_usage.html#aac68a7b8530a68519e005048254fd931)GetIsNotSuitableReason()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [TauntUsageFlag](class_tale_worlds_1_1_core_1_1_taunt_usage_manager_1_1_taunt_usage.html#ac6eea7b7d0a87574366ca374c2dd657a) TaleWorlds.Core.TauntUsageManager.TauntUsage.GetIsNotSuitableReason | ( | bool | *isLeftStance*, |
|  |  | bool | *isOnFoot*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *mainHandWeapon*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *offhandWeapon* ) |

[◆](class_tale_worlds_1_1_core_1_1_taunt_usage_manager_1_1_taunt_usage.html#a46f5c0aa6497b5d0d4c82bac62750285)GetAction()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.Core.TauntUsageManager.TauntUsage.GetAction | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_taunt_usage_manager_1_1_taunt_usage.html#a8d815932842baebc05a9a01c6bc7a4e7)UsageFlag
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TauntUsageFlag](class_tale_worlds_1_1_core_1_1_taunt_usage_manager_1_1_taunt_usage.html#ac6eea7b7d0a87574366ca374c2dd657a) TaleWorlds.Core.TauntUsageManager.TauntUsage.UsageFlag | | get |

