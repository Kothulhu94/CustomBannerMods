--- SOURCE: struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html ---

TaleWorlds.MountAndBlade.FormOrder Struct Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [FormOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#a07d0de287bb31700aa04e35d3799bf4e) {     [Deep](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#a07d0de287bb31700aa04e35d3799bf4ea21d01af167e6874b88ed5f6dc7c4b1e4) = 0 ,     [Wide](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#a07d0de287bb31700aa04e35d3799bf4eae7c770a61dbdf81ca922ae0260e327c1) = 1 ,     [Wider](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#a07d0de287bb31700aa04e35d3799bf4eaec114b1e189d6c3044e5706e93682fa8) = 2 ,     [Custom](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#a07d0de287bb31700aa04e35d3799bf4ea90589c47f06eb971d548591f23c285af) = 3   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [OnApply](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#ac6669c12b2fe503601787c324c5c1995) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| bool | [OnApplyToCustomArrangement](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#a1c4cf11d03a1f67e354047fae577cfaf) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation, [IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html) arrangement) |
| void | [OnApplyToArrangement](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#a07d30baecabd571378c803c952555243) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation, [IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html) arrangement) |
| int? | [GetMaxFileCount](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#adfa2fb6bca3573332afcf005cff93948) (int unitCount) |
| override bool | [Equals](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#abda86ec376d962ef89897ace05d7bc0f) (object obj) |
| override int | [GetHashCode](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#a8ccba46abc0241e05cbb5869f17c7679) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static FormOrder | [FormOrderCustom](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#a08d5fde80b2815aa9686964b66570f94) (float customWidth) |
| static int | [GetUnitCountOf](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#af64a2e7e8a70a199b5e7cc2c58d6123b) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| static ? int | [GetMaxFileCountStatic](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#abd2af22dd50c3ef7972e60cebaf66104) ([FormOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#a07d0de287bb31700aa04e35d3799bf4e) order, int unitCount) |
| static ? int | [GetMaxFileCountAux](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#abb34165930697bea6b9cd8aa4fbc2bf0) ([FormOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#a07d0de287bb31700aa04e35d3799bf4e) order, int unitCount) |
| static bool | [operator!=](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#a62f6d8d8ec1abf1573c4076d1d377fe8) (FormOrder f1, FormOrder f2) |
| static bool | [operator==](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#a400e6c478088acc4917d0cf40e19561e) (FormOrder f1, FormOrder f2) |

|  |  |
| --- | --- |
| Public Attributes | |
| float | [\_customFlankWidth](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#a4648bc8d099a1425d3018b68b689fd66) |
| readonly [FormOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#a07d0de287bb31700aa04e35d3799bf4e) | [OrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#ad2b7fd037a6744f0a8fe1f4fd62d91e2) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static readonly FormOrder | [FormOrderDeep](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#a25a08f7871857197240d3724f2f4bbcd) = new FormOrder([FormOrderEnum.Deep](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#a07d0de287bb31700aa04e35d3799bf4ea21d01af167e6874b88ed5f6dc7c4b1e4)) |
| static readonly FormOrder | [FormOrderWide](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#a0d8abdecfaf92c0d2f35ffce19add5e1) = new FormOrder([FormOrderEnum.Wide](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#a07d0de287bb31700aa04e35d3799bf4eae7c770a61dbdf81ca922ae0260e327c1)) |
| static readonly FormOrder | [FormOrderWider](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#acf3fcc6b75f2be476c20b9677e04773b) = new FormOrder([FormOrderEnum.Wider](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#a07d0de287bb31700aa04e35d3799bf4eaec114b1e189d6c3044e5706e93682fa8)) |

|  |  |
| --- | --- |
| Properties | |
| float | [CustomFlankWidth](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#a64ad60de4bb0433e8eede256deaa43a7) `[get, set]` |
| [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) | [OrderType](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#af0b28412deb8677142481f77478df771) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#a07d0de287bb31700aa04e35d3799bf4e)FormOrderEnum
--------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.FormOrder.FormOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#a07d0de287bb31700aa04e35d3799bf4e) |

| Enumerator | |
| --- | --- |
| Deep |  |
| Wide |  |
| Wider |  |
| Custom |  |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#a08d5fde80b2815aa9686964b66570f94)FormOrderCustom()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | FormOrder TaleWorlds.MountAndBlade.FormOrder.FormOrderCustom | ( | float | *customWidth* | ) |  | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#ac6669c12b2fe503601787c324c5c1995)OnApply()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.FormOrder.OnApply | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#af64a2e7e8a70a199b5e7cc2c58d6123b)GetUnitCountOf()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.FormOrder.GetUnitCountOf | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#a1c4cf11d03a1f67e354047fae577cfaf)OnApplyToCustomArrangement()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.FormOrder.OnApplyToCustomArrangement | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation*, |
|  |  | [IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html) | *arrangement* ) |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#a07d30baecabd571378c803c952555243)OnApplyToArrangement()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.FormOrder.OnApplyToArrangement | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation*, |
|  |  | [IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html) | *arrangement* ) |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#adfa2fb6bca3573332afcf005cff93948)GetMaxFileCount()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int? TaleWorlds.MountAndBlade.FormOrder.GetMaxFileCount | ( | int | *unitCount* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#abd2af22dd50c3ef7972e60cebaf66104)GetMaxFileCountStatic()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | ? int TaleWorlds.MountAndBlade.FormOrder.GetMaxFileCountStatic | ( | [FormOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#a07d0de287bb31700aa04e35d3799bf4e) | *order*, | |  |  | int | *unitCount* ) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#abb34165930697bea6b9cd8aa4fbc2bf0)GetMaxFileCountAux()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | ? int TaleWorlds.MountAndBlade.FormOrder.GetMaxFileCountAux | ( | [FormOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#a07d0de287bb31700aa04e35d3799bf4e) | *order*, | |  |  | int | *unitCount* ) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#abda86ec376d962ef89897ace05d7bc0f)Equals()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.MountAndBlade.FormOrder.Equals | ( | object | *obj* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#a8ccba46abc0241e05cbb5869f17c7679)GetHashCode()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.MountAndBlade.FormOrder.GetHashCode | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#a62f6d8d8ec1abf1573c4076d1d377fe8)operator!=()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.FormOrder.operator!= | ( | FormOrder | *f1*, | |  |  | FormOrder | *f2* ) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#a400e6c478088acc4917d0cf40e19561e)operator==()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.FormOrder.operator== | ( | FormOrder | *f1*, | |  |  | FormOrder | *f2* ) | | static |

Member Data Documentation
-------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#a4648bc8d099a1425d3018b68b689fd66)\_customFlankWidth
-------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.FormOrder.\_customFlankWidth |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#ad2b7fd037a6744f0a8fe1f4fd62d91e2)OrderEnum
----------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [FormOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#a07d0de287bb31700aa04e35d3799bf4e) TaleWorlds.MountAndBlade.FormOrder.OrderEnum |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#a25a08f7871857197240d3724f2f4bbcd)FormOrderDeep
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly FormOrder TaleWorlds.MountAndBlade.FormOrder.FormOrderDeep = new FormOrder([FormOrderEnum.Deep](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#a07d0de287bb31700aa04e35d3799bf4ea21d01af167e6874b88ed5f6dc7c4b1e4)) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#a0d8abdecfaf92c0d2f35ffce19add5e1)FormOrderWide
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly FormOrder TaleWorlds.MountAndBlade.FormOrder.FormOrderWide = new FormOrder([FormOrderEnum.Wide](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#a07d0de287bb31700aa04e35d3799bf4eae7c770a61dbdf81ca922ae0260e327c1)) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#acf3fcc6b75f2be476c20b9677e04773b)FormOrderWider
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly FormOrder TaleWorlds.MountAndBlade.FormOrder.FormOrderWider = new FormOrder([FormOrderEnum.Wider](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#a07d0de287bb31700aa04e35d3799bf4eaec114b1e189d6c3044e5706e93682fa8)) | | static |

Property Documentation
----------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#a64ad60de4bb0433e8eede256deaa43a7)CustomFlankWidth
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormOrder.CustomFlankWidth | | getset |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_form_order.html#af0b28412deb8677142481f77478df771)OrderType
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) TaleWorlds.MountAndBlade.FormOrder.OrderType | | get |

