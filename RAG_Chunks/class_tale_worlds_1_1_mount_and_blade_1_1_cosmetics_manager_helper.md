--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_cosmetics_manager_helper.html ---

TaleWorlds.MountAndBlade.CosmeticsManagerHelper Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static Dictionary< int, List< int > > | [GetUsedIndicesFromIds](class_tale_worlds_1_1_mount_and_blade_1_1_cosmetics_manager_helper.html#a0d17a61019dcfc7d9b9017e0cc00b14f) (Dictionary< string, List< string > > usedCosmetics) |
| static [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) | [GetSuitableTauntAction](class_tale_worlds_1_1_mount_and_blade_1_1_cosmetics_manager_helper.html#a81f86cb80b02ef5606254f5ff5e4ce6d) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, int tauntIndex) |
| static [TauntUsageManager.TauntUsage.TauntUsageFlag](class_tale_worlds_1_1_core_1_1_taunt_usage_manager_1_1_taunt_usage.html#ac6eea7b7d0a87574366ca374c2dd657a) | [GetActionNotUsableReason](class_tale_worlds_1_1_mount_and_blade_1_1_cosmetics_manager_helper.html#a5a1ed51991522f00c5a087101d8e4d3a) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, int tauntIndex) |
| static string | [GetSuitableTauntActionForEquipment](class_tale_worlds_1_1_mount_and_blade_1_1_cosmetics_manager_helper.html#a69bc28cac222c102f8adbd402fa10ed6) ([Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) equipment, TauntCosmeticElement taunt) |
| static bool | [IsWeaponClassOneHanded](class_tale_worlds_1_1_mount_and_blade_1_1_cosmetics_manager_helper.html#a088506194c9816445c2e9e40cd0c7768) ([WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) weaponClass) |
| static bool | [IsWeaponClassTwoHanded](class_tale_worlds_1_1_mount_and_blade_1_1_cosmetics_manager_helper.html#a04e0b896e959fb017617998071c3e317) ([WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) weaponClass) |
| static bool | [IsWeaponClassShield](class_tale_worlds_1_1_mount_and_blade_1_1_cosmetics_manager_helper.html#a6e7e46290febd5afefbcb2750f1b738f) ([WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) weaponClass) |
| static bool | [IsWeaponClassBow](class_tale_worlds_1_1_mount_and_blade_1_1_cosmetics_manager_helper.html#ac19b1d93867efb8ebb6e86263c545259) ([WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) weaponClass) |
| static bool | [IsWeaponClassCrossbow](class_tale_worlds_1_1_mount_and_blade_1_1_cosmetics_manager_helper.html#a1d69ea64708719fd2f07e7ca8afb74bb) ([WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) weaponClass) |
| static [WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61)[] | [GetComplimentaryWeaponClasses](class_tale_worlds_1_1_mount_and_blade_1_1_cosmetics_manager_helper.html#a31a99dc6b973414e42d32841f44b7410) ([WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) weaponClass) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_cosmetics_manager_helper.html#a0d17a61019dcfc7d9b9017e0cc00b14f)GetUsedIndicesFromIds()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | Dictionary< int, List< int > > TaleWorlds.MountAndBlade.CosmeticsManagerHelper.GetUsedIndicesFromIds | ( | Dictionary< string, List< string > > | *usedCosmetics* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_cosmetics_manager_helper.html#a81f86cb80b02ef5606254f5ff5e4ce6d)GetSuitableTauntAction()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) TaleWorlds.MountAndBlade.CosmeticsManagerHelper.GetSuitableTauntAction | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | int | *tauntIndex* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_cosmetics_manager_helper.html#a5a1ed51991522f00c5a087101d8e4d3a)GetActionNotUsableReason()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [TauntUsageManager.TauntUsage.TauntUsageFlag](class_tale_worlds_1_1_core_1_1_taunt_usage_manager_1_1_taunt_usage.html#ac6eea7b7d0a87574366ca374c2dd657a) TaleWorlds.MountAndBlade.CosmeticsManagerHelper.GetActionNotUsableReason | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | int | *tauntIndex* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_cosmetics_manager_helper.html#a69bc28cac222c102f8adbd402fa10ed6)GetSuitableTauntActionForEquipment()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.CosmeticsManagerHelper.GetSuitableTauntActionForEquipment | ( | [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) | *equipment*, | |  |  | TauntCosmeticElement | *taunt* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_cosmetics_manager_helper.html#a088506194c9816445c2e9e40cd0c7768)IsWeaponClassOneHanded()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.CosmeticsManagerHelper.IsWeaponClassOneHanded | ( | [WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) | *weaponClass* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_cosmetics_manager_helper.html#a04e0b896e959fb017617998071c3e317)IsWeaponClassTwoHanded()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.CosmeticsManagerHelper.IsWeaponClassTwoHanded | ( | [WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) | *weaponClass* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_cosmetics_manager_helper.html#a6e7e46290febd5afefbcb2750f1b738f)IsWeaponClassShield()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.CosmeticsManagerHelper.IsWeaponClassShield | ( | [WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) | *weaponClass* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_cosmetics_manager_helper.html#ac19b1d93867efb8ebb6e86263c545259)IsWeaponClassBow()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.CosmeticsManagerHelper.IsWeaponClassBow | ( | [WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) | *weaponClass* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_cosmetics_manager_helper.html#a1d69ea64708719fd2f07e7ca8afb74bb)IsWeaponClassCrossbow()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.CosmeticsManagerHelper.IsWeaponClassCrossbow | ( | [WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) | *weaponClass* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_cosmetics_manager_helper.html#a31a99dc6b973414e42d32841f44b7410)GetComplimentaryWeaponClasses()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61)[] TaleWorlds.MountAndBlade.CosmeticsManagerHelper.GetComplimentaryWeaponClasses | ( | [WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) | *weaponClass* | ) |  | | static |

