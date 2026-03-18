--- SOURCE: class_tale_worlds_1_1_two_dimension_1_1_sprite_data.html ---

TaleWorlds.TwoDimension.SpriteData Class ReferenceContains all sprites in every spritesheet with their categories and nine-grid data.

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [SpriteData](class_tale_worlds_1_1_two_dimension_1_1_sprite_data.html#a7164fb47f8d02ca74dc94e9a7748c609) (string name) |
| [Sprite](class_tale_worlds_1_1_two_dimension_1_1_sprite.html) | [GetSprite](class_tale_worlds_1_1_two_dimension_1_1_sprite_data.html#a7a757f5d7653fcfc1d1bb69d319eefe7) (string name) |
| bool | [SpriteExists](class_tale_worlds_1_1_two_dimension_1_1_sprite_data.html#aac0419f38abe370305f5aa0f2bb6e8a5) (string spriteName) |
| void | [Load](class_tale_worlds_1_1_two_dimension_1_1_sprite_data.html#a3ba5a6d95cf4b0cf41555f8cb2cb698a) ([ResourceDepot](class_tale_worlds_1_1_library_1_1_resource_depot.html) resourceDepot) |
| void | [Reload](class_tale_worlds_1_1_two_dimension_1_1_sprite_data.html#a8605881769afbdd3d7d0345e9d7227c2) ([ResourceDepot](class_tale_worlds_1_1_library_1_1_resource_depot.html) resourceDepot, [ITwoDimensionResourceContext](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_resource_context.html) resourceContext) |

|  |  |
| --- | --- |
| Properties | |
| Dictionary< string, [SpritePart](class_tale_worlds_1_1_two_dimension_1_1_sprite_part.html) > | [SpriteParts](class_tale_worlds_1_1_two_dimension_1_1_sprite_data.html#a070e00a31aee9de22019d36e77d540df) `[get]` |
| Dictionary< string, [Sprite](class_tale_worlds_1_1_two_dimension_1_1_sprite.html) > | [Sprites](class_tale_worlds_1_1_two_dimension_1_1_sprite_data.html#aa0143f077b1d7775da135f8e92d79f57) `[get]` |
| Dictionary< string, [SpriteCategory](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html) > | [SpriteCategories](class_tale_worlds_1_1_two_dimension_1_1_sprite_data.html#a2ad735f92b61382e2bac6196b66c6d47) `[get]` |
| string | [Name](class_tale_worlds_1_1_two_dimension_1_1_sprite_data.html#affc15e306fd9b426bd626b87f46aab15) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_two_dimension_1_1_sprite_data.html#a7164fb47f8d02ca74dc94e9a7748c609)SpriteData()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.TwoDimension.SpriteData.SpriteData | ( | string | *name* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_two_dimension_1_1_sprite_data.html#a7a757f5d7653fcfc1d1bb69d319eefe7)GetSprite()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Sprite](class_tale_worlds_1_1_two_dimension_1_1_sprite.html) TaleWorlds.TwoDimension.SpriteData.GetSprite | ( | string | *name* | ) |  |

[◆](class_tale_worlds_1_1_two_dimension_1_1_sprite_data.html#aac0419f38abe370305f5aa0f2bb6e8a5)SpriteExists()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.TwoDimension.SpriteData.SpriteExists | ( | string | *spriteName* | ) |  |

[◆](class_tale_worlds_1_1_two_dimension_1_1_sprite_data.html#a3ba5a6d95cf4b0cf41555f8cb2cb698a)Load()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.SpriteData.Load | ( | [ResourceDepot](class_tale_worlds_1_1_library_1_1_resource_depot.html) | *resourceDepot* | ) |  |

[◆](class_tale_worlds_1_1_two_dimension_1_1_sprite_data.html#a8605881769afbdd3d7d0345e9d7227c2)Reload()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.SpriteData.Reload | ( | [ResourceDepot](class_tale_worlds_1_1_library_1_1_resource_depot.html) | *resourceDepot*, |
|  |  | [ITwoDimensionResourceContext](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_resource_context.html) | *resourceContext* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_two_dimension_1_1_sprite_data.html#a070e00a31aee9de22019d36e77d540df)SpriteParts
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Dictionary<string, [SpritePart](class_tale_worlds_1_1_two_dimension_1_1_sprite_part.html)> TaleWorlds.TwoDimension.SpriteData.SpriteParts | | get |

[◆](class_tale_worlds_1_1_two_dimension_1_1_sprite_data.html#aa0143f077b1d7775da135f8e92d79f57)Sprites
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Dictionary<string, [Sprite](class_tale_worlds_1_1_two_dimension_1_1_sprite.html)> TaleWorlds.TwoDimension.SpriteData.Sprites | | get |

[◆](class_tale_worlds_1_1_two_dimension_1_1_sprite_data.html#a2ad735f92b61382e2bac6196b66c6d47)SpriteCategories
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Dictionary<string, [SpriteCategory](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html)> TaleWorlds.TwoDimension.SpriteData.SpriteCategories | | get |

[◆](class_tale_worlds_1_1_two_dimension_1_1_sprite_data.html#affc15e306fd9b426bd626b87f46aab15)Name
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.TwoDimension.SpriteData.Name | | get |

