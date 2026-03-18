--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_m_b_item.html ---

TaleWorlds.MountAndBlade.MBItem Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static int | [GetItemUsageIndex](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_item.html#a7453a254d3b0801bb2b7140f0fdd199a) (string itemUsageName) |
| static int | [GetItemHolsterIndex](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_item.html#a48644c49ff33a191a7226c26cd15d2bb) (string itemHolsterName) |
| static bool | [GetItemIsPassiveUsage](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_item.html#ae86044c19398282293f8811786e7a66f) (string itemUsageName) |
| static [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetHolsterFrameByIndex](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_item.html#adad2a4c3bdb487e1aa798000f78dc1da) (int index) |
| static [ItemObject.ItemUsageSetFlags](class_tale_worlds_1_1_core_1_1_item_object.html#aa70dbfec5035754721873468a3526c22) | [GetItemUsageSetFlags](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_item.html#a7a20733f198b657758c1ae03264c4a37) (string ItemUsageName) |
| static [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) | [GetItemUsageReloadActionCode](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_item.html#ade3a26c8d465ecfce63c52fe1f1a7d6a) (string itemUsageName, int usageDirection, bool isMounted, int leftHandUsageSetIndex, bool isLeftStance, bool isLowLookDirection) |
| static int | [GetItemUsageStrikeType](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_item.html#ad2c88e8aaa67cf9befba0c153f606ada) (string itemUsageName, int usageDirection, bool isMounted, int leftHandUsageSetIndex, bool isLeftStance, bool isLowLookDirection) |
| static float | [GetMissileRange](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_item.html#a8e85c7538d5cc3820e2468e06c215a41) (float shotSpeed, float zDiff) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_item.html#a7453a254d3b0801bb2b7140f0fdd199a)GetItemUsageIndex()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.MBItem.GetItemUsageIndex | ( | string | *itemUsageName* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_item.html#a48644c49ff33a191a7226c26cd15d2bb)GetItemHolsterIndex()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.MBItem.GetItemHolsterIndex | ( | string | *itemHolsterName* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_item.html#ae86044c19398282293f8811786e7a66f)GetItemIsPassiveUsage()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.MBItem.GetItemIsPassiveUsage | ( | string | *itemUsageName* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_item.html#adad2a4c3bdb487e1aa798000f78dc1da)GetHolsterFrameByIndex()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.MBItem.GetHolsterFrameByIndex | ( | int | *index* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_item.html#a7a20733f198b657758c1ae03264c4a37)GetItemUsageSetFlags()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [ItemObject.ItemUsageSetFlags](class_tale_worlds_1_1_core_1_1_item_object.html#aa70dbfec5035754721873468a3526c22) TaleWorlds.MountAndBlade.MBItem.GetItemUsageSetFlags | ( | string | *ItemUsageName* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_item.html#ade3a26c8d465ecfce63c52fe1f1a7d6a)GetItemUsageReloadActionCode()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) TaleWorlds.MountAndBlade.MBItem.GetItemUsageReloadActionCode | ( | string | *itemUsageName*, | |  |  | int | *usageDirection*, | |  |  | bool | *isMounted*, | |  |  | int | *leftHandUsageSetIndex*, | |  |  | bool | *isLeftStance*, | |  |  | bool | *isLowLookDirection* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_item.html#ad2c88e8aaa67cf9befba0c153f606ada)GetItemUsageStrikeType()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.MBItem.GetItemUsageStrikeType | ( | string | *itemUsageName*, | |  |  | int | *usageDirection*, | |  |  | bool | *isMounted*, | |  |  | int | *leftHandUsageSetIndex*, | |  |  | bool | *isLeftStance*, | |  |  | bool | *isLowLookDirection* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_item.html#a8e85c7538d5cc3820e2468e06c215a41)GetMissileRange()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.MBItem.GetMissileRange | ( | float | *shotSpeed*, | |  |  | float | *zDiff* ) | | static |

