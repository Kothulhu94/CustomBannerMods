--- SOURCE: class_tale_worlds_1_1_core_1_1_crafting.html ---

TaleWorlds.Core.Crafting Class Reference|  |  |
| --- | --- |
| Classes | |
| class | [RefiningFormula](class_tale_worlds_1_1_core_1_1_crafting_1_1_refining_formula.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [Crafting](class_tale_worlds_1_1_core_1_1_crafting.html#ae6dc62277604d7ac93d4077d930ef518) ([CraftingTemplate](class_tale_worlds_1_1_core_1_1_crafting_template.html) craftingTemplate, [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) culture, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) name) |
| void | [SetCraftedWeaponName](class_tale_worlds_1_1_core_1_1_crafting.html#ab30229aecdb839543d9adaa5ca226426) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) weaponName) |
| void | [Init](class_tale_worlds_1_1_core_1_1_crafting.html#a6aff9e54651eb4456bdd99960602562f) () |
| [WeaponDesignElement](class_tale_worlds_1_1_core_1_1_weapon_design_element.html) | [GetRandomPieceOfType](class_tale_worlds_1_1_core_1_1_crafting.html#a53ec45a7ae3eb0ebec9649e5d2d60290) ([CraftingPiece.PieceTypes](class_tale_worlds_1_1_core_1_1_crafting_piece.html#abd49d9ef3473e52ebea56620d84b8e6a) pieceType, bool randomScale) |
| void | [SwitchToCraftedItem](class_tale_worlds_1_1_core_1_1_crafting.html#a611529b06ba0bbf6d291102b2fb09c47) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item) |
| void | [Randomize](class_tale_worlds_1_1_core_1_1_crafting.html#a05a32ab1ae13ab88b600532f3c7afe9f) () |
| void | [SwitchToPiece](class_tale_worlds_1_1_core_1_1_crafting.html#a4d11fb300c7940a791afd7de9bfd3da7) ([WeaponDesignElement](class_tale_worlds_1_1_core_1_1_weapon_design_element.html) piece) |
| void | [ScaleThePiece](class_tale_worlds_1_1_core_1_1_crafting.html#a7afa6dba7d162488dfb95d0e5094a9c2) ([CraftingPiece.PieceTypes](class_tale_worlds_1_1_core_1_1_crafting_piece.html#abd49d9ef3473e52ebea56620d84b8e6a) scalingPieceType, int percentage) |
| void | [ReIndex](class_tale_worlds_1_1_core_1_1_crafting.html#a825acc1006d324c7b9808459254c8344) (bool enforceReCreation=false) |
| bool | [Undo](class_tale_worlds_1_1_core_1_1_crafting.html#a65dc46f261c1f1726d8d3451412daef0) () |
| bool | [Redo](class_tale_worlds_1_1_core_1_1_crafting.html#a1a2f85bfa5213dd4b981f478f6e31ce2) () |
| void | [UpdateHistory](class_tale_worlds_1_1_core_1_1_crafting.html#a638ef9c70179a6ceeae464ef9c9c6aea) () |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetRandomCraftName](class_tale_worlds_1_1_core_1_1_crafting.html#a3b6c579e60a83bdaf54e87cade5cbff9) () |
| [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | [GetCurrentCraftedItemObject](class_tale_worlds_1_1_core_1_1_crafting.html#a9b54baec0133a8733673fff9b200c53d) (bool forceReCreate=false, string customId=null) |
| IEnumerable< [CraftingStatData](struct_tale_worlds_1_1_core_1_1_crafting_stat_data.html) > | [GetStatDatas](class_tale_worlds_1_1_core_1_1_crafting.html#a66e41234442dfa256411ea05f80b6387) (int usageIndex) |
| string | [GetXmlCodeForCurrentItem](class_tale_worlds_1_1_core_1_1_crafting.html#a67cee99d63fe9f10b4ae21572b70272a) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item) |
| bool | [TryGetWeaponPropertiesFromXmlCode](class_tale_worlds_1_1_core_1_1_crafting.html#a4f1515ea633fbb52ecf79d25b3c10d39) (string xmlCode, out [CraftingTemplate](class_tale_worlds_1_1_core_1_1_crafting_template.html) craftingTemplate, out([CraftingPiece](class_tale_worlds_1_1_core_1_1_crafting_piece.html), int)[] pieces) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [GenerateItem](class_tale_worlds_1_1_core_1_1_crafting.html#abfe48f2127394afe7eb535d08f06ad99) ([WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) weaponDesignTemplate, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) name, [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) culture, [ItemModifierGroup](class_tale_worlds_1_1_core_1_1_item_modifier_group.html) itemModifierGroup, ref [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) itemObject, string customId=null) |
| static IEnumerable< [CraftingStatData](struct_tale_worlds_1_1_core_1_1_crafting_stat_data.html) > | [GetStatDatasFromTemplate](class_tale_worlds_1_1_core_1_1_crafting.html#a147ecc5f49ea99deea35357f64fbbbdc) (int usageIndex, [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) craftedItemObject, [CraftingTemplate](class_tale_worlds_1_1_core_1_1_crafting_template.html) template) |
| static [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | [CreatePreCraftedWeaponOnDeserialize](class_tale_worlds_1_1_core_1_1_crafting.html#a6e500982f0f710eafee6f4e9a1e3244d) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) itemObject, [WeaponDesignElement](class_tale_worlds_1_1_core_1_1_weapon_design_element.html)[] usedPieces, string templateId, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) craftedWeaponName, [ItemModifierGroup](class_tale_worlds_1_1_core_1_1_item_modifier_group.html) itemModifierGroup) |
| static [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | [InitializePreCraftedWeaponOnLoad](class_tale_worlds_1_1_core_1_1_crafting.html#a5a2af0c3ab67efb2b98f4ed3c80700fa) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) itemObject, [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) craftedData, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) itemName, [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) culture) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const int | [WeightOfCrudeIron](class_tale_worlds_1_1_core_1_1_crafting.html#a40b4f8fbe8c8328e6525e4e6ed2c0b3e) = 1 |
| const int | [WeightOfIron](class_tale_worlds_1_1_core_1_1_crafting.html#ab33d0e539217a8b1d90673cfd2dbe201) = 2 |
| const int | [WeightOfCompositeIron](class_tale_worlds_1_1_core_1_1_crafting.html#a4cb8d8f4bd93289d4d3af777bebd8240) = 3 |
| const int | [WeightOfSteel](class_tale_worlds_1_1_core_1_1_crafting.html#a552935cdac52b4718f110115ff9f7f0e) = 4 |
| const int | [WeightOfRefinedSteel](class_tale_worlds_1_1_core_1_1_crafting.html#ad9ac79c3608d5171a0a9579e10df7019) = 5 |
| const int | [WeightOfCalradianSteel](class_tale_worlds_1_1_core_1_1_crafting.html#a0982bbb369b7ded261a7434f69bc7983) = 6 |

|  |  |
| --- | --- |
| Properties | |
| [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) | [CurrentCulture](class_tale_worlds_1_1_core_1_1_crafting.html#ab8d759aca70baf8ff57cc9d4ea4d3bfc) `[get]` |
| [CraftingTemplate](class_tale_worlds_1_1_core_1_1_crafting_template.html) | [CurrentCraftingTemplate](class_tale_worlds_1_1_core_1_1_crafting.html#a273f40f644aeb4a81dd02609810bae7c) `[get]` |
| [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) | [CurrentWeaponDesign](class_tale_worlds_1_1_core_1_1_crafting.html#ae580da626edea538b89364e9763eed27) `[get]` |
| [ItemModifierGroup](class_tale_worlds_1_1_core_1_1_item_modifier_group.html) | [CurrentItemModifierGroup](class_tale_worlds_1_1_core_1_1_crafting.html#a1a0b60ae754404a523a31c87a782a0bb) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [CraftedWeaponName](class_tale_worlds_1_1_core_1_1_crafting.html#a9e30e4d82051c59a6fafe8d9ca1e6ecc) `[get]` |
| List< [WeaponDesignElement](class_tale_worlds_1_1_core_1_1_weapon_design_element.html) >[] | [UsablePiecesList](class_tale_worlds_1_1_core_1_1_crafting.html#a042bb6ea7874f28d9e0a681a4162cd28) `[get]` |
| [WeaponDesignElement](class_tale_worlds_1_1_core_1_1_weapon_design_element.html)[] | [SelectedPieces](class_tale_worlds_1_1_core_1_1_crafting.html#a036bc76f3830ce9e3861a15a09749949) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_core_1_1_crafting.html#ae6dc62277604d7ac93d4077d930ef518)Crafting()
---------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Core.Crafting.Crafting | ( | [CraftingTemplate](class_tale_worlds_1_1_core_1_1_crafting_template.html) | *craftingTemplate*, |
|  |  | [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) | *culture*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *name* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_crafting.html#ab30229aecdb839543d9adaa5ca226426)SetCraftedWeaponName()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.Crafting.SetCraftedWeaponName | ( | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *weaponName* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_crafting.html#a6aff9e54651eb4456bdd99960602562f)Init()
-----------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.Crafting.Init | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_crafting.html#a53ec45a7ae3eb0ebec9649e5d2d60290)GetRandomPieceOfType()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [WeaponDesignElement](class_tale_worlds_1_1_core_1_1_weapon_design_element.html) TaleWorlds.Core.Crafting.GetRandomPieceOfType | ( | [CraftingPiece.PieceTypes](class_tale_worlds_1_1_core_1_1_crafting_piece.html#abd49d9ef3473e52ebea56620d84b8e6a) | *pieceType*, |
|  |  | bool | *randomScale* ) |

[◆](class_tale_worlds_1_1_core_1_1_crafting.html#a611529b06ba0bbf6d291102b2fb09c47)SwitchToCraftedItem()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.Crafting.SwitchToCraftedItem | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_crafting.html#a05a32ab1ae13ab88b600532f3c7afe9f)Randomize()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.Crafting.Randomize | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_crafting.html#a4d11fb300c7940a791afd7de9bfd3da7)SwitchToPiece()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.Crafting.SwitchToPiece | ( | [WeaponDesignElement](class_tale_worlds_1_1_core_1_1_weapon_design_element.html) | *piece* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_crafting.html#a7afa6dba7d162488dfb95d0e5094a9c2)ScaleThePiece()
--------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.Crafting.ScaleThePiece | ( | [CraftingPiece.PieceTypes](class_tale_worlds_1_1_core_1_1_crafting_piece.html#abd49d9ef3473e52ebea56620d84b8e6a) | *scalingPieceType*, |
|  |  | int | *percentage* ) |

[◆](class_tale_worlds_1_1_core_1_1_crafting.html#a825acc1006d324c7b9808459254c8344)ReIndex()
--------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.Crafting.ReIndex | ( | bool | *enforceReCreation* = false | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_crafting.html#a65dc46f261c1f1726d8d3451412daef0)Undo()
-----------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Core.Crafting.Undo | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_crafting.html#a1a2f85bfa5213dd4b981f478f6e31ce2)Redo()
-----------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Core.Crafting.Redo | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_crafting.html#a638ef9c70179a6ceeae464ef9c9c6aea)UpdateHistory()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.Crafting.UpdateHistory | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_crafting.html#a3b6c579e60a83bdaf54e87cade5cbff9)GetRandomCraftName()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.Core.Crafting.GetRandomCraftName | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_crafting.html#abfe48f2127394afe7eb535d08f06ad99)GenerateItem()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Core.Crafting.GenerateItem | ( | [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) | *weaponDesignTemplate*, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *name*, | |  |  | [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) | *culture*, | |  |  | [ItemModifierGroup](class_tale_worlds_1_1_core_1_1_item_modifier_group.html) | *itemModifierGroup*, | |  |  | ref [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *itemObject*, | |  |  | string | *customId* = null ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_crafting.html#a9b54baec0133a8733673fff9b200c53d)GetCurrentCraftedItemObject()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) TaleWorlds.Core.Crafting.GetCurrentCraftedItemObject | ( | bool | *forceReCreate* = false, |
|  |  | string | *customId* = null ) |

[◆](class_tale_worlds_1_1_core_1_1_crafting.html#a147ecc5f49ea99deea35357f64fbbbdc)GetStatDatasFromTemplate()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IEnumerable< [CraftingStatData](struct_tale_worlds_1_1_core_1_1_crafting_stat_data.html) > TaleWorlds.Core.Crafting.GetStatDatasFromTemplate | ( | int | *usageIndex*, | |  |  | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *craftedItemObject*, | |  |  | [CraftingTemplate](class_tale_worlds_1_1_core_1_1_crafting_template.html) | *template* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_crafting.html#a66e41234442dfa256411ea05f80b6387)GetStatDatas()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| IEnumerable< [CraftingStatData](struct_tale_worlds_1_1_core_1_1_crafting_stat_data.html) > TaleWorlds.Core.Crafting.GetStatDatas | ( | int | *usageIndex* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_crafting.html#a67cee99d63fe9f10b4ae21572b70272a)GetXmlCodeForCurrentItem()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| string TaleWorlds.Core.Crafting.GetXmlCodeForCurrentItem | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_crafting.html#a4f1515ea633fbb52ecf79d25b3c10d39)TryGetWeaponPropertiesFromXmlCode()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Core.Crafting.TryGetWeaponPropertiesFromXmlCode | ( | string | *xmlCode*, |
|  |  | out [CraftingTemplate](class_tale_worlds_1_1_core_1_1_crafting_template.html) | *craftingTemplate*, |
|  |  | out([CraftingPiece](class_tale_worlds_1_1_core_1_1_crafting_piece.html), int)[] | *pieces* ) |

[◆](class_tale_worlds_1_1_core_1_1_crafting.html#a6e500982f0f710eafee6f4e9a1e3244d)CreatePreCraftedWeaponOnDeserialize()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) TaleWorlds.Core.Crafting.CreatePreCraftedWeaponOnDeserialize | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *itemObject*, | |  |  | [WeaponDesignElement](class_tale_worlds_1_1_core_1_1_weapon_design_element.html)[] | *usedPieces*, | |  |  | string | *templateId*, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *craftedWeaponName*, | |  |  | [ItemModifierGroup](class_tale_worlds_1_1_core_1_1_item_modifier_group.html) | *itemModifierGroup* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_crafting.html#a5a2af0c3ab67efb2b98f4ed3c80700fa)InitializePreCraftedWeaponOnLoad()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) TaleWorlds.Core.Crafting.InitializePreCraftedWeaponOnLoad | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *itemObject*, | |  |  | [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) | *craftedData*, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *itemName*, | |  |  | [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) | *culture* ) | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_core_1_1_crafting.html#a40b4f8fbe8c8328e6525e4e6ed2c0b3e)WeightOfCrudeIron
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.Core.Crafting.WeightOfCrudeIron = 1 | | static |

[◆](class_tale_worlds_1_1_core_1_1_crafting.html#ab33d0e539217a8b1d90673cfd2dbe201)WeightOfIron
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.Core.Crafting.WeightOfIron = 2 | | static |

[◆](class_tale_worlds_1_1_core_1_1_crafting.html#a4cb8d8f4bd93289d4d3af777bebd8240)WeightOfCompositeIron
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.Core.Crafting.WeightOfCompositeIron = 3 | | static |

[◆](class_tale_worlds_1_1_core_1_1_crafting.html#a552935cdac52b4718f110115ff9f7f0e)WeightOfSteel
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.Core.Crafting.WeightOfSteel = 4 | | static |

[◆](class_tale_worlds_1_1_core_1_1_crafting.html#ad9ac79c3608d5171a0a9579e10df7019)WeightOfRefinedSteel
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.Core.Crafting.WeightOfRefinedSteel = 5 | | static |

[◆](class_tale_worlds_1_1_core_1_1_crafting.html#a0982bbb369b7ded261a7434f69bc7983)WeightOfCalradianSteel
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.Core.Crafting.WeightOfCalradianSteel = 6 | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_crafting.html#ab8d759aca70baf8ff57cc9d4ea4d3bfc)CurrentCulture
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) TaleWorlds.Core.Crafting.CurrentCulture | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting.html#a273f40f644aeb4a81dd02609810bae7c)CurrentCraftingTemplate
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CraftingTemplate](class_tale_worlds_1_1_core_1_1_crafting_template.html) TaleWorlds.Core.Crafting.CurrentCraftingTemplate | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting.html#ae580da626edea538b89364e9763eed27)CurrentWeaponDesign
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) TaleWorlds.Core.Crafting.CurrentWeaponDesign | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting.html#a1a0b60ae754404a523a31c87a782a0bb)CurrentItemModifierGroup
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ItemModifierGroup](class_tale_worlds_1_1_core_1_1_item_modifier_group.html) TaleWorlds.Core.Crafting.CurrentItemModifierGroup | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting.html#a9e30e4d82051c59a6fafe8d9ca1e6ecc)CraftedWeaponName
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.Core.Crafting.CraftedWeaponName | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting.html#a042bb6ea7874f28d9e0a681a4162cd28)UsablePiecesList
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[WeaponDesignElement](class_tale_worlds_1_1_core_1_1_weapon_design_element.html)> [] TaleWorlds.Core.Crafting.UsablePiecesList | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting.html#a036bc76f3830ce9e3861a15a09749949)SelectedPieces
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [WeaponDesignElement](class_tale_worlds_1_1_core_1_1_weapon_design_element.html) [] TaleWorlds.Core.Crafting.SelectedPieces | | get |

