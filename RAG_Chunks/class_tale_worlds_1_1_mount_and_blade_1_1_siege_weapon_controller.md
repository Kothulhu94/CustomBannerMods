--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_controller.html ---

TaleWorlds.MountAndBlade.SiegeWeaponController Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [SiegeWeaponController](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_controller.html#a325594e28a098528d9af9f687371e0c1) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission, [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
| void | [Select](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_controller.html#a08b00bf85d5fdf64d85341ef02023d29) ([SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html) weapon) |
| void | [ClearSelectedWeapons](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_controller.html#a78fa31c4f0b6132c6afd1f0dd878b3ac) () |
| void | [Deselect](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_controller.html#af2f5b108a82dcc36c0d533933390edec) ([SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html) weapon) |
| void | [SelectAll](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_controller.html#ab95142e11b9ad94b34bae21c1bbeb121) () |
| void | [SetOrder](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_controller.html#a12546b9630dd628c336640b5699f9645) ([SiegeWeaponOrderType](namespace_tale_worlds_1_1_mount_and_blade.html#ac97eb5fd0d0939e5d96e661275225222) order) |
| int | [GetShortcutIndexOf](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_controller.html#afcb9862a431502b8969f4c49bf10eb96) ([SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html) weapon) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static bool | [IsWeaponSelectable](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_controller.html#a5cdefc0089cf99af7755584358a7ce83) ([SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html) weapon) |
| static [SiegeWeaponOrderType](namespace_tale_worlds_1_1_mount_and_blade.html#ac97eb5fd0d0939e5d96e661275225222) | [GetActiveOrderOf](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_controller.html#a22a5af63edc93c4022e7bfbcc90dc732) ([SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html) weapon) |
| static [SiegeWeaponOrderType](namespace_tale_worlds_1_1_mount_and_blade.html#ac97eb5fd0d0939e5d96e661275225222) | [GetActiveMovementOrderOf](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_controller.html#a6948df0c0fa1a7cfdb0f2e09f362a742) ([SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html) weapon) |
| static [SiegeWeaponOrderType](namespace_tale_worlds_1_1_mount_and_blade.html#ac97eb5fd0d0939e5d96e661275225222) | [GetActiveFacingOrderOf](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_controller.html#a2e7f50b0e7b667e12551d3a468fa7dce) ([SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html) weapon) |
| static [SiegeWeaponOrderType](namespace_tale_worlds_1_1_mount_and_blade.html#ac97eb5fd0d0939e5d96e661275225222) | [GetActiveFiringOrderOf](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_controller.html#a7e70bfcdfd7896cf4f881441bc55d834) ([SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html) weapon) |
| static [SiegeWeaponOrderType](namespace_tale_worlds_1_1_mount_and_blade.html#ac97eb5fd0d0939e5d96e661275225222) | [GetActiveAIControlOrderOf](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_controller.html#acdf58199f97db40575c7ba075b6540b6) ([SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html) weapon) |

|  |  |
| --- | --- |
| Properties | |
| MBReadOnlyList< [SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html) > | [SelectedWeapons](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_controller.html#a05c5f5fad9f99991e2fcbd57e30bf3d1) `[get]` |

|  |  |
| --- | --- |
| Events | |
| Action< [SiegeWeaponOrderType](namespace_tale_worlds_1_1_mount_and_blade.html#ac97eb5fd0d0939e5d96e661275225222), IEnumerable< [SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html) > > | [OnOrderIssued](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_controller.html#a6842f3fc19ab9c13ae2a8b0b1b8c270c) |
| Action | [OnSelectedSiegeWeaponsChanged](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_controller.html#a16dc497fb478852100cac9481fd796e9) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_controller.html#a325594e28a098528d9af9f687371e0c1)SiegeWeaponController()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.SiegeWeaponController.SiegeWeaponController | ( | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | *mission*, |
|  |  | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_controller.html#a08b00bf85d5fdf64d85341ef02023d29)Select()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SiegeWeaponController.Select | ( | [SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html) | *weapon* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_controller.html#a78fa31c4f0b6132c6afd1f0dd878b3ac)ClearSelectedWeapons()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SiegeWeaponController.ClearSelectedWeapons | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_controller.html#af2f5b108a82dcc36c0d533933390edec)Deselect()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SiegeWeaponController.Deselect | ( | [SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html) | *weapon* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_controller.html#ab95142e11b9ad94b34bae21c1bbeb121)SelectAll()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SiegeWeaponController.SelectAll | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_controller.html#a5cdefc0089cf99af7755584358a7ce83)IsWeaponSelectable()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.SiegeWeaponController.IsWeaponSelectable | ( | [SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html) | *weapon* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_controller.html#a22a5af63edc93c4022e7bfbcc90dc732)GetActiveOrderOf()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [SiegeWeaponOrderType](namespace_tale_worlds_1_1_mount_and_blade.html#ac97eb5fd0d0939e5d96e661275225222) TaleWorlds.MountAndBlade.SiegeWeaponController.GetActiveOrderOf | ( | [SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html) | *weapon* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_controller.html#a6948df0c0fa1a7cfdb0f2e09f362a742)GetActiveMovementOrderOf()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [SiegeWeaponOrderType](namespace_tale_worlds_1_1_mount_and_blade.html#ac97eb5fd0d0939e5d96e661275225222) TaleWorlds.MountAndBlade.SiegeWeaponController.GetActiveMovementOrderOf | ( | [SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html) | *weapon* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_controller.html#a2e7f50b0e7b667e12551d3a468fa7dce)GetActiveFacingOrderOf()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [SiegeWeaponOrderType](namespace_tale_worlds_1_1_mount_and_blade.html#ac97eb5fd0d0939e5d96e661275225222) TaleWorlds.MountAndBlade.SiegeWeaponController.GetActiveFacingOrderOf | ( | [SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html) | *weapon* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_controller.html#a7e70bfcdfd7896cf4f881441bc55d834)GetActiveFiringOrderOf()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [SiegeWeaponOrderType](namespace_tale_worlds_1_1_mount_and_blade.html#ac97eb5fd0d0939e5d96e661275225222) TaleWorlds.MountAndBlade.SiegeWeaponController.GetActiveFiringOrderOf | ( | [SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html) | *weapon* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_controller.html#acdf58199f97db40575c7ba075b6540b6)GetActiveAIControlOrderOf()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [SiegeWeaponOrderType](namespace_tale_worlds_1_1_mount_and_blade.html#ac97eb5fd0d0939e5d96e661275225222) TaleWorlds.MountAndBlade.SiegeWeaponController.GetActiveAIControlOrderOf | ( | [SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html) | *weapon* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_controller.html#a12546b9630dd628c336640b5699f9645)SetOrder()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SiegeWeaponController.SetOrder | ( | [SiegeWeaponOrderType](namespace_tale_worlds_1_1_mount_and_blade.html#ac97eb5fd0d0939e5d96e661275225222) | *order* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_controller.html#afcb9862a431502b8969f4c49bf10eb96)GetShortcutIndexOf()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.SiegeWeaponController.GetShortcutIndexOf | ( | [SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html) | *weapon* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_controller.html#a05c5f5fad9f99991e2fcbd57e30bf3d1)SelectedWeapons
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html)> TaleWorlds.MountAndBlade.SiegeWeaponController.SelectedWeapons | | get |

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_controller.html#a6842f3fc19ab9c13ae2a8b0b1b8c270c)OnOrderIssued
--------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[SiegeWeaponOrderType](namespace_tale_worlds_1_1_mount_and_blade.html#ac97eb5fd0d0939e5d96e661275225222), IEnumerable<[SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html)> > TaleWorlds.MountAndBlade.SiegeWeaponController.OnOrderIssued |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_controller.html#a16dc497fb478852100cac9481fd796e9)OnSelectedSiegeWeaponsChanged
------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action TaleWorlds.MountAndBlade.SiegeWeaponController.OnSelectedSiegeWeaponsChanged |

