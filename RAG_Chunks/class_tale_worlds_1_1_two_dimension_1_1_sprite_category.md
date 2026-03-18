--- SOURCE: class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html ---

TaleWorlds.TwoDimension.SpriteCategory Class Reference|  |  |
| --- | --- |
| Classes | |
| class | [SpriteSizeComparer](class_tale_worlds_1_1_two_dimension_1_1_sprite_category_1_1_sprite_size_comparer.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [SpriteCategory](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html#ab10bea4dd7c0f449b9c556d2b2a28cc8) (string name, int spriteSheetCount, bool alwaysLoad=false) |
| void | [Load](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html#a138ddfe85dc1a9e39f88a6ce983f627f) ([ITwoDimensionResourceContext](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_resource_context.html) resourceContext, [ResourceDepot](class_tale_worlds_1_1_library_1_1_resource_depot.html) resourceDepot) |
| void | [Unload](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html#a4eda3f8699012051b93ab8747ee28c0f) () |
| void | [Reload](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html#a16ca9e6e8e06dc2670b3352503f422c3) ([ITwoDimensionResourceContext](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_resource_context.html) resourceContext, [ResourceDepot](class_tale_worlds_1_1_library_1_1_resource_depot.html) resourceDepot, [SpriteCategory](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html#ab10bea4dd7c0f449b9c556d2b2a28cc8) newCategoryInfo) |
| void | [InitializePartialLoad](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html#a646a8c31df53a8ae48c3b851cd4eb543) () |
| void | [ReleasePartialLoad](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html#aac907f3609219bee07b04b762b423c9a) () |
| void | [PartialLoadAtIndex](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html#aefdd90a8773878e972cfb7642a9d8cdd) ([ITwoDimensionResourceContext](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_resource_context.html) resourceContext, [ResourceDepot](class_tale_worlds_1_1_library_1_1_resource_depot.html) resourceDepot, int sheetIndex) |
| void | [PartialUnloadAtIndex](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html#a55733a4026e675ba1b3c555242f8b513) (int sheetIndex) |
| void | [SortList](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html#a4ab74f2da3bb8640e3f6f95dbbd8dac3) () |
| bool | [IsCategoryFullyLoaded](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html#a45896c8d2c3a83a7eeb36f39f8f0a3f4) () |
|  | Represents if all the requested spritesheets in this category fully loaded to the GPU. |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly bool | [AlwaysLoad](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html#acd6757e32c609b5013b52601ec22a983) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const int | [SpriteSheetSize](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html#ad3e6a279d68c21b045fe7ed9ec547340) = 4096 |

|  |  |
| --- | --- |
| Properties | |
| string | [Name](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html#a918bbf08eb1b07e5a5e10e284ea5eaa0) `[get]` |
| List< [SpritePart](class_tale_worlds_1_1_two_dimension_1_1_sprite_part.html) > | [SpriteParts](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html#a5c9e441d65b874975f3d19198eb1c4b0) `[get]` |
| List< [SpritePart](class_tale_worlds_1_1_two_dimension_1_1_sprite_part.html) > | [SortedSpritePartList](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html#a40b2da0ec3058c28518ce9f48913a190) `[get]` |
| List< [Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) > | [SpriteSheets](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html#acb19e9470118ea42b3bd0c830f0e5c90) `[get]` |
| int | [SpriteSheetCount](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html#a82bdb5bca1d0719142d16a4f3972a5a3) `[get, set]` |
| bool | [IsLoaded](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html#a1d7f53af4aaa2611423467c55d996946) `[get]` |
| bool | [IsPartiallyLoaded](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html#a73bb55365f28b106d68961b6d151180d) `[get]` |
| [Vec2i](struct_tale_worlds_1_1_library_1_1_vec2i.html)[] | [SheetSizes](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html#a9e8a1e21d7f0ceb3a1698bddeed1e32f) `[get, set]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html#ab10bea4dd7c0f449b9c556d2b2a28cc8)SpriteCategory()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.TwoDimension.SpriteCategory.SpriteCategory | ( | string | *name*, |
|  |  | int | *spriteSheetCount*, |
|  |  | bool | *alwaysLoad* = false ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html#a138ddfe85dc1a9e39f88a6ce983f627f)Load()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.SpriteCategory.Load | ( | [ITwoDimensionResourceContext](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_resource_context.html) | *resourceContext*, |
|  |  | [ResourceDepot](class_tale_worlds_1_1_library_1_1_resource_depot.html) | *resourceDepot* ) |

[◆](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html#a4eda3f8699012051b93ab8747ee28c0f)Unload()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.SpriteCategory.Unload | ( |  | ) |  |

[◆](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html#a16ca9e6e8e06dc2670b3352503f422c3)Reload()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.SpriteCategory.Reload | ( | [ITwoDimensionResourceContext](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_resource_context.html) | *resourceContext*, |
|  |  | [ResourceDepot](class_tale_worlds_1_1_library_1_1_resource_depot.html) | *resourceDepot*, |
|  |  | [SpriteCategory](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html#ab10bea4dd7c0f449b9c556d2b2a28cc8) | *newCategoryInfo* ) |

[◆](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html#a646a8c31df53a8ae48c3b851cd4eb543)InitializePartialLoad()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.SpriteCategory.InitializePartialLoad | ( |  | ) |  |

[◆](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html#aac907f3609219bee07b04b762b423c9a)ReleasePartialLoad()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.SpriteCategory.ReleasePartialLoad | ( |  | ) |  |

[◆](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html#aefdd90a8773878e972cfb7642a9d8cdd)PartialLoadAtIndex()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.SpriteCategory.PartialLoadAtIndex | ( | [ITwoDimensionResourceContext](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_resource_context.html) | *resourceContext*, |
|  |  | [ResourceDepot](class_tale_worlds_1_1_library_1_1_resource_depot.html) | *resourceDepot*, |
|  |  | int | *sheetIndex* ) |

[◆](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html#a55733a4026e675ba1b3c555242f8b513)PartialUnloadAtIndex()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.SpriteCategory.PartialUnloadAtIndex | ( | int | *sheetIndex* | ) |  |

[◆](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html#a4ab74f2da3bb8640e3f6f95dbbd8dac3)SortList()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.SpriteCategory.SortList | ( |  | ) |  |

[◆](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html#a45896c8d2c3a83a7eeb36f39f8f0a3f4)IsCategoryFullyLoaded()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.TwoDimension.SpriteCategory.IsCategoryFullyLoaded | ( |  | ) |  |

Returns

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html#ad3e6a279d68c21b045fe7ed9ec547340)SpriteSheetSize
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.TwoDimension.SpriteCategory.SpriteSheetSize = 4096 | | static |

[◆](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html#acd6757e32c609b5013b52601ec22a983)AlwaysLoad
-------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly bool TaleWorlds.TwoDimension.SpriteCategory.AlwaysLoad |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html#a918bbf08eb1b07e5a5e10e284ea5eaa0)Name
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.TwoDimension.SpriteCategory.Name | | get |

[◆](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html#a5c9e441d65b874975f3d19198eb1c4b0)SpriteParts
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[SpritePart](class_tale_worlds_1_1_two_dimension_1_1_sprite_part.html)> TaleWorlds.TwoDimension.SpriteCategory.SpriteParts | | get |

[◆](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html#a40b2da0ec3058c28518ce9f48913a190)SortedSpritePartList
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[SpritePart](class_tale_worlds_1_1_two_dimension_1_1_sprite_part.html)> TaleWorlds.TwoDimension.SpriteCategory.SortedSpritePartList | | get |

[◆](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html#acb19e9470118ea42b3bd0c830f0e5c90)SpriteSheets
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html)> TaleWorlds.TwoDimension.SpriteCategory.SpriteSheets | | get |

[◆](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html#a82bdb5bca1d0719142d16a4f3972a5a3)SpriteSheetCount
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.TwoDimension.SpriteCategory.SpriteSheetCount | | getset |

[◆](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html#a1d7f53af4aaa2611423467c55d996946)IsLoaded
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.TwoDimension.SpriteCategory.IsLoaded | | get |

[◆](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html#a73bb55365f28b106d68961b6d151180d)IsPartiallyLoaded
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.TwoDimension.SpriteCategory.IsPartiallyLoaded | | get |

[◆](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html#a9e8a1e21d7f0ceb3a1698bddeed1e32f)SheetSizes
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2i](struct_tale_worlds_1_1_library_1_1_vec2i.html) [] TaleWorlds.TwoDimension.SpriteCategory.SheetSizes | | getset |

