--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_crafted_data_view.html ---

TaleWorlds.MountAndBlade.View.CraftedDataView Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
| delegate void | [OnMeshBuiltDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_crafted_data_view.html#ae41063e7dd213ec578d5147fccf2c9db) ([WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) weaponDesign, ref [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) builtMesh) |
|  | [CraftedDataView](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_crafted_data_view.html#a56daf41f9b4d01b72a2aa25ffd62a37a) ([WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) craftedData) |
| void | [Clear](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_crafted_data_view.html#a681734d82fbeccdb4090124c42cfce14) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | [BuildWeaponMesh](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_crafted_data_view.html#adb96e41ec9777d9f5b8f1d9ab7d1215e) ([WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) craftedData, float pivotDiff, bool pieceTypeHidingEnabledForHolster, bool batchAllMeshes) |
| static [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | [BuildHolsterMesh](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_crafted_data_view.html#a01a94c41d8dc62741e3a77a1185202b0) ([WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) craftedData) |
| static [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | [BuildHolsterMeshWithWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_crafted_data_view.html#a90238fa42c242ecb1bdf0a670619f694) ([WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) craftedData, float pivotDiff, bool batchAllMeshes) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static [OnMeshBuiltDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_crafted_data_view.html#ae41063e7dd213ec578d5147fccf2c9db) | [OnWeaponMeshBuilt](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_crafted_data_view.html#aaa33d5e9ea7881b204dabe1ae3304653) |
| static [OnMeshBuiltDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_crafted_data_view.html#ae41063e7dd213ec578d5147fccf2c9db) | [OnHolsterMeshBuilt](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_crafted_data_view.html#aae69e9809841fab068fdbae170e0ff55) |
| static [OnMeshBuiltDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_crafted_data_view.html#ae41063e7dd213ec578d5147fccf2c9db) | [OnHolsterMeshWithWeaponBuilt](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_crafted_data_view.html#a46b746b09eb8feb1d21a763f2481a6ad) |

|  |  |
| --- | --- |
| Properties | |
| [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) | [CraftedData](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_crafted_data_view.html#a89c854d8ac110de6e6ae1d3ffe022818) `[get]` |
| [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | [WeaponMesh](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_crafted_data_view.html#a008267403c021d088c712684d6024440) `[get]` |
| [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | [HolsterMesh](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_crafted_data_view.html#a62040c818ae04765b43e370daaaa0988) `[get]` |
| [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | [HolsterMeshWithWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_crafted_data_view.html#a20c16e8379486c937b01853adae52323) `[get]` |
| [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | [NonBatchedWeaponMesh](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_crafted_data_view.html#aa24fadca5b6e89d455ad449b11d8c2aa) `[get]` |
| [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | [NonBatchedHolsterMesh](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_crafted_data_view.html#a09981362aec8b77cddc6b5e70b9d9017) `[get]` |
| [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | [NonBatchedHolsterMeshWithWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_crafted_data_view.html#af14a4d445681e71e1e2c2321762d4065) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_crafted_data_view.html#a56daf41f9b4d01b72a2aa25ffd62a37a)CraftedDataView()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.View.CraftedDataView.CraftedDataView | ( | [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) | *craftedData* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_crafted_data_view.html#ae41063e7dd213ec578d5147fccf2c9db)OnMeshBuiltDelegate()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate void TaleWorlds.MountAndBlade.View.CraftedDataView.OnMeshBuiltDelegate | ( | [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) | *weaponDesign*, |
|  |  | ref [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | *builtMesh* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_crafted_data_view.html#a681734d82fbeccdb4090124c42cfce14)Clear()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.CraftedDataView.Clear | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_crafted_data_view.html#adb96e41ec9777d9f5b8f1d9ab7d1215e)BuildWeaponMesh()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) TaleWorlds.MountAndBlade.View.CraftedDataView.BuildWeaponMesh | ( | [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) | *craftedData*, | |  |  | float | *pivotDiff*, | |  |  | bool | *pieceTypeHidingEnabledForHolster*, | |  |  | bool | *batchAllMeshes* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_crafted_data_view.html#a01a94c41d8dc62741e3a77a1185202b0)BuildHolsterMesh()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) TaleWorlds.MountAndBlade.View.CraftedDataView.BuildHolsterMesh | ( | [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) | *craftedData* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_crafted_data_view.html#a90238fa42c242ecb1bdf0a670619f694)BuildHolsterMeshWithWeapon()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) TaleWorlds.MountAndBlade.View.CraftedDataView.BuildHolsterMeshWithWeapon | ( | [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) | *craftedData*, | |  |  | float | *pivotDiff*, | |  |  | bool | *batchAllMeshes* ) | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_crafted_data_view.html#aaa33d5e9ea7881b204dabe1ae3304653)OnWeaponMeshBuilt
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [OnMeshBuiltDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_crafted_data_view.html#ae41063e7dd213ec578d5147fccf2c9db) TaleWorlds.MountAndBlade.View.CraftedDataView.OnWeaponMeshBuilt | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_crafted_data_view.html#aae69e9809841fab068fdbae170e0ff55)OnHolsterMeshBuilt
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [OnMeshBuiltDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_crafted_data_view.html#ae41063e7dd213ec578d5147fccf2c9db) TaleWorlds.MountAndBlade.View.CraftedDataView.OnHolsterMeshBuilt | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_crafted_data_view.html#a46b746b09eb8feb1d21a763f2481a6ad)OnHolsterMeshWithWeaponBuilt
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [OnMeshBuiltDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_crafted_data_view.html#ae41063e7dd213ec578d5147fccf2c9db) TaleWorlds.MountAndBlade.View.CraftedDataView.OnHolsterMeshWithWeaponBuilt | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_crafted_data_view.html#a89c854d8ac110de6e6ae1d3ffe022818)CraftedData
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) TaleWorlds.MountAndBlade.View.CraftedDataView.CraftedData | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_crafted_data_view.html#a008267403c021d088c712684d6024440)WeaponMesh
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) TaleWorlds.MountAndBlade.View.CraftedDataView.WeaponMesh | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_crafted_data_view.html#a62040c818ae04765b43e370daaaa0988)HolsterMesh
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) TaleWorlds.MountAndBlade.View.CraftedDataView.HolsterMesh | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_crafted_data_view.html#a20c16e8379486c937b01853adae52323)HolsterMeshWithWeapon
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) TaleWorlds.MountAndBlade.View.CraftedDataView.HolsterMeshWithWeapon | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_crafted_data_view.html#aa24fadca5b6e89d455ad449b11d8c2aa)NonBatchedWeaponMesh
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) TaleWorlds.MountAndBlade.View.CraftedDataView.NonBatchedWeaponMesh | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_crafted_data_view.html#a09981362aec8b77cddc6b5e70b9d9017)NonBatchedHolsterMesh
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) TaleWorlds.MountAndBlade.View.CraftedDataView.NonBatchedHolsterMesh | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_crafted_data_view.html#af14a4d445681e71e1e2c2321762d4065)NonBatchedHolsterMeshWithWeapon
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) TaleWorlds.MountAndBlade.View.CraftedDataView.NonBatchedHolsterMeshWithWeapon | | get |

