--- SOURCE: class_tale_worlds_1_1_core_1_1_taunt_usage_manager.html ---

TaleWorlds.Core.TauntUsageManager Class Reference|  |  |
| --- | --- |
| Classes | |
| class | [TauntUsageSet](class_tale_worlds_1_1_core_1_1_taunt_usage_manager_1_1_taunt_usage_set.html) |
| class | [TauntUsage](class_tale_worlds_1_1_core_1_1_taunt_usage_manager_1_1_taunt_usage.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [Read](class_tale_worlds_1_1_core_1_1_taunt_usage_manager.html#a02aec3a25825a6799ba94efa318a2431) () |
| [TauntUsageSet](class_tale_worlds_1_1_core_1_1_taunt_usage_manager_1_1_taunt_usage_set.html) | [GetUsageSet](class_tale_worlds_1_1_core_1_1_taunt_usage_manager.html#a8e35c7c08c3f0462bc86f890e7c27cdb) (string id) |
| string | [GetAction](class_tale_worlds_1_1_core_1_1_taunt_usage_manager.html#affcf1f6e752d90f69d4ec1b5ff39efef) (int index, bool isLeftStance, bool onFoot, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) mainHandWeapon, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) offhandWeapon) |
| TauntUsageFlag | [GetIsActionNotSuitableReason](class_tale_worlds_1_1_core_1_1_taunt_usage_manager.html#a6c387621d71118fc67ce9dcd7d880017) (int index, bool isLeftStance, bool onFoot, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) mainHandWeapon, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) offhandWeapon) |
| int | [GetTauntItemCount](class_tale_worlds_1_1_core_1_1_taunt_usage_manager.html#a19d89ddfcf701330895a3d9094d2bf02) () |
| int | [GetIndexOfAction](class_tale_worlds_1_1_core_1_1_taunt_usage_manager.html#aa82933587c92ae1eea3ab96284008218) (string id) |
| string | [GetDefaultAction](class_tale_worlds_1_1_core_1_1_taunt_usage_manager.html#a4c7f1acb63af5714fa6883989dc7becb) (int index) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static TauntUsageManager | [Initialize](class_tale_worlds_1_1_core_1_1_taunt_usage_manager.html#a541a93e6be9f4400b4c14a6dc3e04cdb) () |
| static string | [GetActionDisabledReasonText](class_tale_worlds_1_1_core_1_1_taunt_usage_manager.html#ac6dffc089efe060a3153fe5d6fdff78e) (TauntUsageFlag disabledReasonFlag) |

|  |  |
| --- | --- |
| Properties | |
| static TauntUsageManager | [Instance](class_tale_worlds_1_1_core_1_1_taunt_usage_manager.html#ac2cd07ebdecd5ac34c6271fcbb659f61) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_taunt_usage_manager.html#a541a93e6be9f4400b4c14a6dc3e04cdb)Initialize()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | TauntUsageManager TaleWorlds.Core.TauntUsageManager.Initialize | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_taunt_usage_manager.html#a02aec3a25825a6799ba94efa318a2431)Read()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.TauntUsageManager.Read | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_taunt_usage_manager.html#a8e35c7c08c3f0462bc86f890e7c27cdb)GetUsageSet()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [TauntUsageSet](class_tale_worlds_1_1_core_1_1_taunt_usage_manager_1_1_taunt_usage_set.html) TaleWorlds.Core.TauntUsageManager.GetUsageSet | ( | string | *id* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_taunt_usage_manager.html#affcf1f6e752d90f69d4ec1b5ff39efef)GetAction()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| string TaleWorlds.Core.TauntUsageManager.GetAction | ( | int | *index*, |
|  |  | bool | *isLeftStance*, |
|  |  | bool | *onFoot*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *mainHandWeapon*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *offhandWeapon* ) |

[◆](class_tale_worlds_1_1_core_1_1_taunt_usage_manager.html#ac6dffc089efe060a3153fe5d6fdff78e)GetActionDisabledReasonText()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.Core.TauntUsageManager.GetActionDisabledReasonText | ( | TauntUsageFlag | *disabledReasonFlag* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_taunt_usage_manager.html#a6c387621d71118fc67ce9dcd7d880017)GetIsActionNotSuitableReason()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TauntUsageFlag TaleWorlds.Core.TauntUsageManager.GetIsActionNotSuitableReason | ( | int | *index*, |
|  |  | bool | *isLeftStance*, |
|  |  | bool | *onFoot*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *mainHandWeapon*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *offhandWeapon* ) |

[◆](class_tale_worlds_1_1_core_1_1_taunt_usage_manager.html#a19d89ddfcf701330895a3d9094d2bf02)GetTauntItemCount()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.Core.TauntUsageManager.GetTauntItemCount | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_taunt_usage_manager.html#aa82933587c92ae1eea3ab96284008218)GetIndexOfAction()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.Core.TauntUsageManager.GetIndexOfAction | ( | string | *id* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_taunt_usage_manager.html#a4c7f1acb63af5714fa6883989dc7becb)GetDefaultAction()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| string TaleWorlds.Core.TauntUsageManager.GetDefaultAction | ( | int | *index* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_taunt_usage_manager.html#ac2cd07ebdecd5ac34c6271fcbb659f61)Instance
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | TauntUsageManager TaleWorlds.Core.TauntUsageManager.Instance | | staticget |

