--- SOURCE: class_tale_worlds_1_1_core_1_1_weapon_design.html ---

TaleWorlds.Core.WeaponDesign Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html#a7131a7be51dc231b1202eaf008604ebe) ([CraftingTemplate](class_tale_worlds_1_1_core_1_1_crafting_template.html) template, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) weaponName, [WeaponDesignElement](class_tale_worlds_1_1_core_1_1_weapon_design_element.html)[] usedPieces, string customId=null) |
| override bool | [Equals](class_tale_worlds_1_1_core_1_1_weapon_design.html#abced86bcf1bef381098463db0d5e7ad5) (object obj) |
| override int | [GetHashCode](class_tale_worlds_1_1_core_1_1_weapon_design.html#aff4c51930c73cff5ffe40597b86c49df) () |
| void | [SetWeaponName](class_tale_worlds_1_1_core_1_1_weapon_design.html#a42fd1d89df6fdc65b4d01b5b0bc0580a) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) name) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static bool | [operator==](class_tale_worlds_1_1_core_1_1_weapon_design.html#a2f7c93803884d7b9039e21a84248111b) ([WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html#a7131a7be51dc231b1202eaf008604ebe) x, [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html#a7131a7be51dc231b1202eaf008604ebe) y) |
| static bool | [operator!=](class_tale_worlds_1_1_core_1_1_weapon_design.html#ad3ad9a5ae72f53eb109be0a0f2c14a0b) ([WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html#a7131a7be51dc231b1202eaf008604ebe) x, [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html#a7131a7be51dc231b1202eaf008604ebe) y) |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly [WeaponFlags](namespace_tale_worlds_1_1_core.html#a777ba058af61ad6bd9a4a27124c20051) | [WeaponFlags](class_tale_worlds_1_1_core_1_1_weapon_design.html#aa3cf7ed607b97f1b3c0b89c65d49073c) |
| readonly float | [CraftedWeaponLength](class_tale_worlds_1_1_core_1_1_weapon_design.html#aee76597a4acf174ff2149f74811e561e) |
| readonly [CraftingTemplate](class_tale_worlds_1_1_core_1_1_crafting_template.html) | [Template](class_tale_worlds_1_1_core_1_1_weapon_design.html#a6b5f991eecaf724d83608098d3a00363) |
| List< float > | [TopPivotOffsets](class_tale_worlds_1_1_core_1_1_weapon_design.html#ac27987ec53f7d89d7dbcee83c50a784a) |
| List< float > | [BottomPivotOffsets](class_tale_worlds_1_1_core_1_1_weapon_design.html#aa7ba014a3652ad01783e6d18f7f4b56a) |
| readonly [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [HolsterShiftAmount](class_tale_worlds_1_1_core_1_1_weapon_design.html#aa68aff7ec75305e21c42b2e4dbbffabf) |

|  |  |
| --- | --- |
| Properties | |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [WeaponName](class_tale_worlds_1_1_core_1_1_weapon_design.html#a55c6e277a29a5b2298038760c85cc5c5) `[get]` |
| [WeaponDesignElement](class_tale_worlds_1_1_core_1_1_weapon_design_element.html)[] | [UsedPieces](class_tale_worlds_1_1_core_1_1_weapon_design.html#a68a226c4d325f64f881beebc3cd3ca4d) `[get]` |
| float[] | [PiecePivotDistances](class_tale_worlds_1_1_core_1_1_weapon_design.html#a67e2f8427b62380c42e757de314b9548) `[get]` |
| float | [TotalLength](class_tale_worlds_1_1_core_1_1_weapon_design.html#a2d56604674207a094659d0f3de4708ad) `[get]` |
| float | [HandToBottomLength](class_tale_worlds_1_1_core_1_1_weapon_design.html#aa894305c69262d678466ca31eaf0e362) `[get]` |
| string | [HashedCode](class_tale_worlds_1_1_core_1_1_weapon_design.html#a6b06740d222e44fff3c415b7247d5318) `[get]` |
| float | [BottomPivotOffset](class_tale_worlds_1_1_core_1_1_weapon_design.html#a13657d3a6e0940196622f5a1e76dfff9) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_core_1_1_weapon_design.html#a7131a7be51dc231b1202eaf008604ebe)WeaponDesign()
------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Core.WeaponDesign.WeaponDesign | ( | [CraftingTemplate](class_tale_worlds_1_1_core_1_1_crafting_template.html) | *template*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *weaponName*, |
|  |  | [WeaponDesignElement](class_tale_worlds_1_1_core_1_1_weapon_design_element.html)[] | *usedPieces*, |
|  |  | string | *customId* = null ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_weapon_design.html#abced86bcf1bef381098463db0d5e7ad5)Equals()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.Core.WeaponDesign.Equals | ( | object | *obj* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_weapon_design.html#aff4c51930c73cff5ffe40597b86c49df)GetHashCode()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.Core.WeaponDesign.GetHashCode | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_weapon_design.html#a42fd1d89df6fdc65b4d01b5b0bc0580a)SetWeaponName()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.WeaponDesign.SetWeaponName | ( | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *name* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_weapon_design.html#a2f7c93803884d7b9039e21a84248111b)operator==()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Core.WeaponDesign.operator== | ( | [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html#a7131a7be51dc231b1202eaf008604ebe) | *x*, | |  |  | [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html#a7131a7be51dc231b1202eaf008604ebe) | *y* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_weapon_design.html#ad3ad9a5ae72f53eb109be0a0f2c14a0b)operator!=()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Core.WeaponDesign.operator!= | ( | [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html#a7131a7be51dc231b1202eaf008604ebe) | *x*, | |  |  | [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html#a7131a7be51dc231b1202eaf008604ebe) | *y* ) | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_core_1_1_weapon_design.html#aa3cf7ed607b97f1b3c0b89c65d49073c)WeaponFlags
---------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [WeaponFlags](namespace_tale_worlds_1_1_core.html#a777ba058af61ad6bd9a4a27124c20051) TaleWorlds.Core.WeaponDesign.WeaponFlags |

[◆](class_tale_worlds_1_1_core_1_1_weapon_design.html#aee76597a4acf174ff2149f74811e561e)CraftedWeaponLength
-----------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly float TaleWorlds.Core.WeaponDesign.CraftedWeaponLength |

[◆](class_tale_worlds_1_1_core_1_1_weapon_design.html#a6b5f991eecaf724d83608098d3a00363)Template
------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [CraftingTemplate](class_tale_worlds_1_1_core_1_1_crafting_template.html) TaleWorlds.Core.WeaponDesign.Template |

[◆](class_tale_worlds_1_1_core_1_1_weapon_design.html#ac27987ec53f7d89d7dbcee83c50a784a)TopPivotOffsets
-------------------------------------------------------------------------------------------------------

|  |
| --- |
| List<float> TaleWorlds.Core.WeaponDesign.TopPivotOffsets |

[◆](class_tale_worlds_1_1_core_1_1_weapon_design.html#aa7ba014a3652ad01783e6d18f7f4b56a)BottomPivotOffsets
----------------------------------------------------------------------------------------------------------

|  |
| --- |
| List<float> TaleWorlds.Core.WeaponDesign.BottomPivotOffsets |

[◆](class_tale_worlds_1_1_core_1_1_weapon_design.html#aa68aff7ec75305e21c42b2e4dbbffabf)HolsterShiftAmount
----------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Core.WeaponDesign.HolsterShiftAmount |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_weapon_design.html#a55c6e277a29a5b2298038760c85cc5c5)WeaponName
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.Core.WeaponDesign.WeaponName | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_design.html#a68a226c4d325f64f881beebc3cd3ca4d)UsedPieces
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [WeaponDesignElement](class_tale_worlds_1_1_core_1_1_weapon_design_element.html) [] TaleWorlds.Core.WeaponDesign.UsedPieces | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_design.html#a67e2f8427b62380c42e757de314b9548)PiecePivotDistances
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float [] TaleWorlds.Core.WeaponDesign.PiecePivotDistances | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_design.html#a2d56604674207a094659d0f3de4708ad)TotalLength
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.WeaponDesign.TotalLength | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_design.html#aa894305c69262d678466ca31eaf0e362)HandToBottomLength
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.WeaponDesign.HandToBottomLength | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_design.html#a6b06740d222e44fff3c415b7247d5318)HashedCode
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.WeaponDesign.HashedCode | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_design.html#a13657d3a6e0940196622f5a1e76dfff9)BottomPivotOffset
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.WeaponDesign.BottomPivotOffset | | get |

