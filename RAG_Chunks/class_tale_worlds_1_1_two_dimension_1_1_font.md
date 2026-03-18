--- SOURCE: class_tale_worlds_1_1_two_dimension_1_1_font.html ---

TaleWorlds.TwoDimension.Font Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [Font](class_tale_worlds_1_1_two_dimension_1_1_font.html#a0b5c27154df4ed0c277dde358a943042) (string name) |
| bool | [TryLoadFontFromPath](class_tale_worlds_1_1_two_dimension_1_1_font.html#ad1296dbcc0743255c9f20fb4f3482ce7) (string path, [SpriteData](class_tale_worlds_1_1_two_dimension_1_1_sprite_data.html) spriteData) |
| float | [GetWordWidth](class_tale_worlds_1_1_two_dimension_1_1_font.html#a296e74a22bb7c3d306eee47323733038) (string word, float extraPadding) |
| float | [GetCharacterWidth](class_tale_worlds_1_1_two_dimension_1_1_font.html#a34e27ec8a789d9dfa55ea568ecfbf914) (char character, float extraPadding) |
| override string | [ToString](class_tale_worlds_1_1_two_dimension_1_1_font.html#af00def2f18d88d90089ee0dc3bbf1566) () |

|  |  |
| --- | --- |
| Properties | |
| string | [Name](class_tale_worlds_1_1_two_dimension_1_1_font.html#a8a0f9fde0d15464742bf6a64ed368318) `[get]` |
| int | [Size](class_tale_worlds_1_1_two_dimension_1_1_font.html#a3941dea3852935d5e78e99f00aa5921a) `[get]` |
| int | [LineHeight](class_tale_worlds_1_1_two_dimension_1_1_font.html#abe2532b02abe59deb69f993de9b841e1) `[get]` |
| int | [Base](class_tale_worlds_1_1_two_dimension_1_1_font.html#a7bacd16111d1f5d2b0b5399e7e7501ce) `[get]` |
| int | [CharacterCount](class_tale_worlds_1_1_two_dimension_1_1_font.html#a249bfba5866b4f8d269e0425e4541c7a) `[get]` |
| float | [SmoothingConstant](class_tale_worlds_1_1_two_dimension_1_1_font.html#a83ac5cb1e57465abc3f6165b600e1276) `[get]` |
| float | [CustomScale](class_tale_worlds_1_1_two_dimension_1_1_font.html#a6b7e9b2735681f0e0b00185b68a10a89) = 1f `[get]` |
|  | Used for scaling font size. Already applied to Size. |
| bool | [Smooth](class_tale_worlds_1_1_two_dimension_1_1_font.html#a7741c20cb6fc88f71df3bda9f64f4e4f) `[get]` |
| [SpritePart](class_tale_worlds_1_1_two_dimension_1_1_sprite_part.html) | [FontSprite](class_tale_worlds_1_1_two_dimension_1_1_font.html#a1f2d5ca4ca3d6e20f12002a091827f67) `[get]` |
| Dictionary< int, [BitmapFontCharacter](struct_tale_worlds_1_1_two_dimension_1_1_bitmap_font_character.html) > | [Characters](class_tale_worlds_1_1_two_dimension_1_1_font.html#a4a785afff632887d2b5968a25f7a4248) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_two_dimension_1_1_font.html#a0b5c27154df4ed0c277dde358a943042)Font()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.TwoDimension.Font.Font | ( | string | *name* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_two_dimension_1_1_font.html#ad1296dbcc0743255c9f20fb4f3482ce7)TryLoadFontFromPath()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.TwoDimension.Font.TryLoadFontFromPath | ( | string | *path*, |
|  |  | [SpriteData](class_tale_worlds_1_1_two_dimension_1_1_sprite_data.html) | *spriteData* ) |

[◆](class_tale_worlds_1_1_two_dimension_1_1_font.html#a296e74a22bb7c3d306eee47323733038)GetWordWidth()
------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.TwoDimension.Font.GetWordWidth | ( | string | *word*, |
|  |  | float | *extraPadding* ) |

[◆](class_tale_worlds_1_1_two_dimension_1_1_font.html#a34e27ec8a789d9dfa55ea568ecfbf914)GetCharacterWidth()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.TwoDimension.Font.GetCharacterWidth | ( | char | *character*, |
|  |  | float | *extraPadding* ) |

[◆](class_tale_worlds_1_1_two_dimension_1_1_font.html#af00def2f18d88d90089ee0dc3bbf1566)ToString()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.TwoDimension.Font.ToString | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_two_dimension_1_1_font.html#a8a0f9fde0d15464742bf6a64ed368318)Name
--------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.TwoDimension.Font.Name | | get |

[◆](class_tale_worlds_1_1_two_dimension_1_1_font.html#a3941dea3852935d5e78e99f00aa5921a)Size
--------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.TwoDimension.Font.Size | | get |

[◆](class_tale_worlds_1_1_two_dimension_1_1_font.html#abe2532b02abe59deb69f993de9b841e1)LineHeight
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.TwoDimension.Font.LineHeight | | get |

[◆](class_tale_worlds_1_1_two_dimension_1_1_font.html#a7bacd16111d1f5d2b0b5399e7e7501ce)Base
--------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.TwoDimension.Font.Base | | get |

[◆](class_tale_worlds_1_1_two_dimension_1_1_font.html#a249bfba5866b4f8d269e0425e4541c7a)CharacterCount
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.TwoDimension.Font.CharacterCount | | get |

[◆](class_tale_worlds_1_1_two_dimension_1_1_font.html#a83ac5cb1e57465abc3f6165b600e1276)SmoothingConstant
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.TwoDimension.Font.SmoothingConstant | | get |

[◆](class_tale_worlds_1_1_two_dimension_1_1_font.html#a6b7e9b2735681f0e0b00185b68a10a89)CustomScale
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.TwoDimension.Font.CustomScale = 1f | | get |

[◆](class_tale_worlds_1_1_two_dimension_1_1_font.html#a7741c20cb6fc88f71df3bda9f64f4e4f)Smooth
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.TwoDimension.Font.Smooth | | get |

[◆](class_tale_worlds_1_1_two_dimension_1_1_font.html#a1f2d5ca4ca3d6e20f12002a091827f67)FontSprite
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SpritePart](class_tale_worlds_1_1_two_dimension_1_1_sprite_part.html) TaleWorlds.TwoDimension.Font.FontSprite | | get |

[◆](class_tale_worlds_1_1_two_dimension_1_1_font.html#a4a785afff632887d2b5968a25f7a4248)Characters
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Dictionary<int, [BitmapFontCharacter](struct_tale_worlds_1_1_two_dimension_1_1_bitmap_font_character.html)> TaleWorlds.TwoDimension.Font.Characters | | get |

