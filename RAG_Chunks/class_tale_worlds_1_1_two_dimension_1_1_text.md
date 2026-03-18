--- SOURCE: class_tale_worlds_1_1_two_dimension_1_1_text.html ---

TaleWorlds.TwoDimension.Text Class ReferenceInherits [TaleWorlds.TwoDimension.IText](interface_tale_worlds_1_1_two_dimension_1_1_i_text.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [Text](class_tale_worlds_1_1_two_dimension_1_1_text.html#a40d842ffd6b7e22826fe308ff75aabb0) (int width, int height, [Font](class_tale_worlds_1_1_two_dimension_1_1_text.html#ac9f7876d598a260b7fec2b781474ce45) bitmapFont, Func< int, [Font](class_tale_worlds_1_1_two_dimension_1_1_text.html#ac9f7876d598a260b7fec2b781474ce45) > getUsableFontForCharacter) |
| Vector2 | [GetPreferredSize](class_tale_worlds_1_1_two_dimension_1_1_text.html#a1b63c0d456541e787022f6797c52c8c0) (bool fixedWidth, float widthSize, bool fixedHeight, float heightSize, [SpriteData](class_tale_worlds_1_1_two_dimension_1_1_sprite_data.html) spriteData, float renderScale) |
| void | [UpdateSize](class_tale_worlds_1_1_two_dimension_1_1_text.html#a74a170c676aff713ce1e0754b2b0735a) (int width, int height) |
| void | [SetAllDirty](class_tale_worlds_1_1_two_dimension_1_1_text.html#a0f9d7da9fab236ea0374e877d4c0edd5) () |
| List< [TextPart](class_tale_worlds_1_1_two_dimension_1_1_text_part.html) > | [GetParts](class_tale_worlds_1_1_two_dimension_1_1_text.html#ac9c20fc50ca1a69cb2484cb185b4d852) () |

|  |  |
| --- | --- |
| Properties | |
| [ILanguage](interface_tale_worlds_1_1_two_dimension_1_1_i_language.html) | [CurrentLanguage](class_tale_worlds_1_1_two_dimension_1_1_text.html#ac0623dc26476623f988958ac65ee6eff) `[get, set]` |
| float | [ScaleToFitTextInLayout](class_tale_worlds_1_1_two_dimension_1_1_text.html#a36ecf971ba23574b39eb226234b962d3) = 1 `[get]` |
|  | After a placement pass, if this value is != 1, it means we need to make another pass with this modifier to fit the text inside the given text area. |
| int | [LineCount](class_tale_worlds_1_1_two_dimension_1_1_text.html#aeedcbf74bc00429892a6579bc093c901) `[get]` |
| int | [Width](class_tale_worlds_1_1_two_dimension_1_1_text.html#a9f87de8ed01642639824de895db5ec17) `[get]` |
| int | [Height](class_tale_worlds_1_1_two_dimension_1_1_text.html#a06ade5d51b04b068f2ff3daed5144ebc) `[get]` |
| Font | [Font](class_tale_worlds_1_1_two_dimension_1_1_text.html#ac9f7876d598a260b7fec2b781474ce45) `[get, set]` |
| [TextHorizontalAlignment](namespace_tale_worlds_1_1_two_dimension.html#af6ca63d15408f01210c236921a377db2) | [HorizontalAlignment](class_tale_worlds_1_1_two_dimension_1_1_text.html#a9eee59132c52a85e0bc97371212a4674) `[get, set]` |
| [TextVerticalAlignment](namespace_tale_worlds_1_1_two_dimension.html#ae0c712f027593e48326763d56ecdcc3f) | [VerticalAlignment](class_tale_worlds_1_1_two_dimension_1_1_text.html#a0cf5893399f3a0e83395c513c7d5af5e) `[get, set]` |
| float | [FontSize](class_tale_worlds_1_1_two_dimension_1_1_text.html#aef49b20e3116da2749381ffee5d5d4af) `[get, set]` |
| string | [Value](class_tale_worlds_1_1_two_dimension_1_1_text.html#ab5e7cfee9e811a150cdc54c053448e9e) `[get, set]` |
| bool | [SkipLineOnContainerExceeded](class_tale_worlds_1_1_two_dimension_1_1_text.html#a104b4ee9cdccee2a47e8a75db6fa6e54) `[get, set]` |
| bool | [CanBreakWords](class_tale_worlds_1_1_two_dimension_1_1_text.html#ab946f7268a3f2b86e71d262c009fec2d) `[get, set]` |
| bool | [ResizeTextOnOverflow](class_tale_worlds_1_1_two_dimension_1_1_text.html#a11061ed945f836d005c2958bf782ed6d) `[get, set]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_two_dimension_1_1_text.html#a40d842ffd6b7e22826fe308ff75aabb0)Text()
----------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.TwoDimension.Text.Text | ( | int | *width*, |
|  |  | int | *height*, |
|  |  | [Font](class_tale_worlds_1_1_two_dimension_1_1_text.html#ac9f7876d598a260b7fec2b781474ce45) | *bitmapFont*, |
|  |  | Func< int, [Font](class_tale_worlds_1_1_two_dimension_1_1_text.html#ac9f7876d598a260b7fec2b781474ce45) > | *getUsableFontForCharacter* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_two_dimension_1_1_text.html#a1b63c0d456541e787022f6797c52c8c0)GetPreferredSize()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| Vector2 TaleWorlds.TwoDimension.Text.GetPreferredSize | ( | bool | *fixedWidth*, |
|  |  | float | *widthSize*, |
|  |  | bool | *fixedHeight*, |
|  |  | float | *heightSize*, |
|  |  | [SpriteData](class_tale_worlds_1_1_two_dimension_1_1_sprite_data.html) | *spriteData*, |
|  |  | float | *renderScale* ) |

Implements [TaleWorlds.TwoDimension.IText](interface_tale_worlds_1_1_two_dimension_1_1_i_text.html#a6ddd3436e506f1036e93a237e4cf217c).

[◆](class_tale_worlds_1_1_two_dimension_1_1_text.html#a74a170c676aff713ce1e0754b2b0735a)UpdateSize()
----------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.Text.UpdateSize | ( | int | *width*, |
|  |  | int | *height* ) |

[◆](class_tale_worlds_1_1_two_dimension_1_1_text.html#a0f9d7da9fab236ea0374e877d4c0edd5)SetAllDirty()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.Text.SetAllDirty | ( |  | ) |  |

[◆](class_tale_worlds_1_1_two_dimension_1_1_text.html#ac9c20fc50ca1a69cb2484cb185b4d852)GetParts()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| List< [TextPart](class_tale_worlds_1_1_two_dimension_1_1_text_part.html) > TaleWorlds.TwoDimension.Text.GetParts | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_two_dimension_1_1_text.html#ac0623dc26476623f988958ac65ee6eff)CurrentLanguage
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ILanguage](interface_tale_worlds_1_1_two_dimension_1_1_i_language.html) TaleWorlds.TwoDimension.Text.CurrentLanguage | | getset |

[◆](class_tale_worlds_1_1_two_dimension_1_1_text.html#a36ecf971ba23574b39eb226234b962d3)ScaleToFitTextInLayout
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.TwoDimension.Text.ScaleToFitTextInLayout = 1 | | get |

[◆](class_tale_worlds_1_1_two_dimension_1_1_text.html#aeedcbf74bc00429892a6579bc093c901)LineCount
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.TwoDimension.Text.LineCount | | get |

[◆](class_tale_worlds_1_1_two_dimension_1_1_text.html#a9f87de8ed01642639824de895db5ec17)Width
---------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.TwoDimension.Text.Width | | get |

[◆](class_tale_worlds_1_1_two_dimension_1_1_text.html#a06ade5d51b04b068f2ff3daed5144ebc)Height
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.TwoDimension.Text.Height | | get |

[◆](class_tale_worlds_1_1_two_dimension_1_1_text.html#ac9f7876d598a260b7fec2b781474ce45)Font
--------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Font TaleWorlds.TwoDimension.Text.Font | | getset |

[◆](class_tale_worlds_1_1_two_dimension_1_1_text.html#a9eee59132c52a85e0bc97371212a4674)HorizontalAlignment
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextHorizontalAlignment](namespace_tale_worlds_1_1_two_dimension.html#af6ca63d15408f01210c236921a377db2) TaleWorlds.TwoDimension.Text.HorizontalAlignment | | getset |

Implements [TaleWorlds.TwoDimension.IText](interface_tale_worlds_1_1_two_dimension_1_1_i_text.html#ab4b11ca7dbf073bee7d319ac031b757d).

[◆](class_tale_worlds_1_1_two_dimension_1_1_text.html#a0cf5893399f3a0e83395c513c7d5af5e)VerticalAlignment
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextVerticalAlignment](namespace_tale_worlds_1_1_two_dimension.html#ae0c712f027593e48326763d56ecdcc3f) TaleWorlds.TwoDimension.Text.VerticalAlignment | | getset |

Implements [TaleWorlds.TwoDimension.IText](interface_tale_worlds_1_1_two_dimension_1_1_i_text.html#a62eec8ae3c6c43cb2600417758fbb3a4).

[◆](class_tale_worlds_1_1_two_dimension_1_1_text.html#aef49b20e3116da2749381ffee5d5d4af)FontSize
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.TwoDimension.Text.FontSize | | getset |

[◆](class_tale_worlds_1_1_two_dimension_1_1_text.html#ab5e7cfee9e811a150cdc54c053448e9e)Value
---------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.TwoDimension.Text.Value | | getset |

Implements [TaleWorlds.TwoDimension.IText](interface_tale_worlds_1_1_two_dimension_1_1_i_text.html#ad32f83d78505d56f1f51ea1534afa09e).

[◆](class_tale_worlds_1_1_two_dimension_1_1_text.html#a104b4ee9cdccee2a47e8a75db6fa6e54)SkipLineOnContainerExceeded
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.TwoDimension.Text.SkipLineOnContainerExceeded | | getset |

[◆](class_tale_worlds_1_1_two_dimension_1_1_text.html#ab946f7268a3f2b86e71d262c009fec2d)CanBreakWords
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.TwoDimension.Text.CanBreakWords | | getset |

[◆](class_tale_worlds_1_1_two_dimension_1_1_text.html#a11061ed945f836d005c2958bf782ed6d)ResizeTextOnOverflow
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.TwoDimension.Text.ResizeTextOnOverflow | | getset |

