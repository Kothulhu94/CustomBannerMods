--- SOURCE: class_tale_worlds_1_1_two_dimension_1_1_rich_text.html ---

TaleWorlds.TwoDimension.RichText Class ReferenceInherits [TaleWorlds.TwoDimension.IText](interface_tale_worlds_1_1_two_dimension_1_1_i_text.html).

Inherited by [TaleWorlds.TwoDimension.EditableText](class_tale_worlds_1_1_two_dimension_1_1_editable_text.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [RichText](class_tale_worlds_1_1_two_dimension_1_1_rich_text.html#a8860d7518b989eb33bb4b923b7e4ad6a) (int width, int height, [Font](class_tale_worlds_1_1_two_dimension_1_1_font.html) font, Func< int, [Font](class_tale_worlds_1_1_two_dimension_1_1_font.html) > getUsableFontForCharacter) |
| virtual void | [Update](class_tale_worlds_1_1_two_dimension_1_1_rich_text.html#ac07725fc4a1d77030bf9d8d927c08ff4) (float dt, [SpriteData](class_tale_worlds_1_1_two_dimension_1_1_sprite_data.html) spriteData, Vector2 focusPosition, bool focus, bool isFixedWidth, bool isFixedHeight, float renderScale) |
| void | [SetAllDirty](class_tale_worlds_1_1_two_dimension_1_1_rich_text.html#a75aa64b813593f4d141eaab5c00a626c) () |
| Vector2 | [GetPreferredSize](class_tale_worlds_1_1_two_dimension_1_1_rich_text.html#a3fb8f6550a6c45d3bda5781ff3038503) (bool fixedWidth, float widthSize, bool fixedHeight, float heightSize, [SpriteData](class_tale_worlds_1_1_two_dimension_1_1_sprite_data.html) spriteData, float renderScale) |
| void | [CalculateTextOutput](class_tale_worlds_1_1_two_dimension_1_1_rich_text.html#aed4852c55a3588271970636b1c72302d) (float width, float height, [SpriteData](class_tale_worlds_1_1_two_dimension_1_1_sprite_data.html) spriteData, float renderScale) |
| void | [UpdateSize](class_tale_worlds_1_1_two_dimension_1_1_rich_text.html#a399f4ba74a21ae18697eb0bbb6ef4a62) (int width, int height) |
| List< [RichTextPart](class_tale_worlds_1_1_two_dimension_1_1_rich_text_part.html) > | [GetParts](class_tale_worlds_1_1_two_dimension_1_1_rich_text.html#a2ce1b1c71250fee0eae408da999b362c) () |

|  |  |
| --- | --- |
| Public Attributes | |
| [ILanguage](interface_tale_worlds_1_1_two_dimension_1_1_i_language.html) | [CurrentLanguage](class_tale_worlds_1_1_two_dimension_1_1_rich_text.html#ae58161fbe8b37f2960911aa250da2f66) |

|  |  |
| --- | --- |
| Protected Attributes | |
| readonly Func< int, [Font](class_tale_worlds_1_1_two_dimension_1_1_font.html) > | [\_getUsableFontForCharacter](class_tale_worlds_1_1_two_dimension_1_1_rich_text.html#a725b08ca05a49a3e43632ec2481dd6fa) |

|  |  |
| --- | --- |
| Static Protected Attributes | |
| const float | [ExtraLetterPaddingHorizontal](class_tale_worlds_1_1_two_dimension_1_1_rich_text.html#abd5ca41ec7a09e6755ff5e2eb2df2e33) = 0.5f |
| const float | [ExtraLetterPaddingVertical](class_tale_worlds_1_1_two_dimension_1_1_rich_text.html#ab3ab5247a74d182a1b96705899ffee67) = 2.5f \* 2f |

|  |  |
| --- | --- |
| Properties | |
| string | [CurrentStyle](class_tale_worlds_1_1_two_dimension_1_1_rich_text.html#ad98b6671026074bf1279fc17469c9893) = "Default" `[get, set]` |
| int | [TextHeight](class_tale_worlds_1_1_two_dimension_1_1_rich_text.html#a9f3bb1f74df9bc509755607e22de427c) `[get]` |
| StyleFontContainer | [StyleFontContainer](class_tale_worlds_1_1_two_dimension_1_1_rich_text.html#a8ffdb468b77777f94f94cf77f49bae0b) `[get]` |
| [TextHorizontalAlignment](namespace_tale_worlds_1_1_two_dimension.html#af6ca63d15408f01210c236921a377db2) | [HorizontalAlignment](class_tale_worlds_1_1_two_dimension_1_1_rich_text.html#a887ce10a357093ed82c2007ecdd53cf1) `[get, set]` |
| [TextVerticalAlignment](namespace_tale_worlds_1_1_two_dimension.html#ae0c712f027593e48326763d56ecdcc3f) | [VerticalAlignment](class_tale_worlds_1_1_two_dimension_1_1_rich_text.html#a82b6ce8cdff2bd6f5d1258f024f62a8a) `[get, set]` |
| string | [Value](class_tale_worlds_1_1_two_dimension_1_1_rich_text.html#a68e70ddad20edd557d1d1b2c1286f1a8) `[get, set]` |
| [RichTextLinkGroup](class_tale_worlds_1_1_two_dimension_1_1_rich_text_link_group.html) | [FocusedLinkGroup](class_tale_worlds_1_1_two_dimension_1_1_rich_text.html#a1437b65ee880c8d9584b499faaa46743) `[get]` |
| bool | [SkipLineOnContainerExceeded](class_tale_worlds_1_1_two_dimension_1_1_rich_text.html#afd14dfac0c3976bf84b3107165dc66f0) `[get, set]` |
| bool | [CanBreakWords](class_tale_worlds_1_1_two_dimension_1_1_rich_text.html#ac5eec7572d7ab8fc43fec1076309f304) `[get, set]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_two_dimension_1_1_rich_text.html#a8860d7518b989eb33bb4b923b7e4ad6a)RichText()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.TwoDimension.RichText.RichText | ( | int | *width*, |
|  |  | int | *height*, |
|  |  | [Font](class_tale_worlds_1_1_two_dimension_1_1_font.html) | *font*, |
|  |  | Func< int, [Font](class_tale_worlds_1_1_two_dimension_1_1_font.html) > | *getUsableFontForCharacter* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_two_dimension_1_1_rich_text.html#ac07725fc4a1d77030bf9d8d927c08ff4)Update()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.TwoDimension.RichText.Update | ( | float | *dt*, | |  |  | [SpriteData](class_tale_worlds_1_1_two_dimension_1_1_sprite_data.html) | *spriteData*, | |  |  | Vector2 | *focusPosition*, | |  |  | bool | *focus*, | |  |  | bool | *isFixedWidth*, | |  |  | bool | *isFixedHeight*, | |  |  | float | *renderScale* ) | | virtual |

Reimplemented in [TaleWorlds.TwoDimension.EditableText](class_tale_worlds_1_1_two_dimension_1_1_editable_text.html#a3d7ba5917e37777d91ac38c7c17ac2f7).

[◆](class_tale_worlds_1_1_two_dimension_1_1_rich_text.html#a75aa64b813593f4d141eaab5c00a626c)SetAllDirty()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.RichText.SetAllDirty | ( |  | ) |  |

[◆](class_tale_worlds_1_1_two_dimension_1_1_rich_text.html#a3fb8f6550a6c45d3bda5781ff3038503)GetPreferredSize()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| Vector2 TaleWorlds.TwoDimension.RichText.GetPreferredSize | ( | bool | *fixedWidth*, |
|  |  | float | *widthSize*, |
|  |  | bool | *fixedHeight*, |
|  |  | float | *heightSize*, |
|  |  | [SpriteData](class_tale_worlds_1_1_two_dimension_1_1_sprite_data.html) | *spriteData*, |
|  |  | float | *renderScale* ) |

Implements [TaleWorlds.TwoDimension.IText](interface_tale_worlds_1_1_two_dimension_1_1_i_text.html#a6ddd3436e506f1036e93a237e4cf217c).

[◆](class_tale_worlds_1_1_two_dimension_1_1_rich_text.html#aed4852c55a3588271970636b1c72302d)CalculateTextOutput()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.RichText.CalculateTextOutput | ( | float | *width*, |
|  |  | float | *height*, |
|  |  | [SpriteData](class_tale_worlds_1_1_two_dimension_1_1_sprite_data.html) | *spriteData*, |
|  |  | float | *renderScale* ) |

[◆](class_tale_worlds_1_1_two_dimension_1_1_rich_text.html#a399f4ba74a21ae18697eb0bbb6ef4a62)UpdateSize()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.RichText.UpdateSize | ( | int | *width*, |
|  |  | int | *height* ) |

[◆](class_tale_worlds_1_1_two_dimension_1_1_rich_text.html#a2ce1b1c71250fee0eae408da999b362c)GetParts()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| List< [RichTextPart](class_tale_worlds_1_1_two_dimension_1_1_rich_text_part.html) > TaleWorlds.TwoDimension.RichText.GetParts | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_two_dimension_1_1_rich_text.html#ae58161fbe8b37f2960911aa250da2f66)CurrentLanguage
------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [ILanguage](interface_tale_worlds_1_1_two_dimension_1_1_i_language.html) TaleWorlds.TwoDimension.RichText.CurrentLanguage |

[◆](class_tale_worlds_1_1_two_dimension_1_1_rich_text.html#abd5ca41ec7a09e6755ff5e2eb2df2e33)ExtraLetterPaddingHorizontal
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.TwoDimension.RichText.ExtraLetterPaddingHorizontal = 0.5f | | staticprotected |

[◆](class_tale_worlds_1_1_two_dimension_1_1_rich_text.html#ab3ab5247a74d182a1b96705899ffee67)ExtraLetterPaddingVertical
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.TwoDimension.RichText.ExtraLetterPaddingVertical = 2.5f \* 2f | | staticprotected |

[◆](class_tale_worlds_1_1_two_dimension_1_1_rich_text.html#a725b08ca05a49a3e43632ec2481dd6fa)\_getUsableFontForCharacter
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly Func<int, [Font](class_tale_worlds_1_1_two_dimension_1_1_font.html)> TaleWorlds.TwoDimension.RichText.\_getUsableFontForCharacter | | protected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_two_dimension_1_1_rich_text.html#ad98b6671026074bf1279fc17469c9893)CurrentStyle
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.TwoDimension.RichText.CurrentStyle = "Default" | | getset |

[◆](class_tale_worlds_1_1_two_dimension_1_1_rich_text.html#a9f3bb1f74df9bc509755607e22de427c)TextHeight
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.TwoDimension.RichText.TextHeight | | get |

[◆](class_tale_worlds_1_1_two_dimension_1_1_rich_text.html#a8ffdb468b77777f94f94cf77f49bae0b)StyleFontContainer
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | StyleFontContainer TaleWorlds.TwoDimension.RichText.StyleFontContainer | | get |

[◆](class_tale_worlds_1_1_two_dimension_1_1_rich_text.html#a887ce10a357093ed82c2007ecdd53cf1)HorizontalAlignment
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextHorizontalAlignment](namespace_tale_worlds_1_1_two_dimension.html#af6ca63d15408f01210c236921a377db2) TaleWorlds.TwoDimension.RichText.HorizontalAlignment | | getset |

Implements [TaleWorlds.TwoDimension.IText](interface_tale_worlds_1_1_two_dimension_1_1_i_text.html#ab4b11ca7dbf073bee7d319ac031b757d).

[◆](class_tale_worlds_1_1_two_dimension_1_1_rich_text.html#a82b6ce8cdff2bd6f5d1258f024f62a8a)VerticalAlignment
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextVerticalAlignment](namespace_tale_worlds_1_1_two_dimension.html#ae0c712f027593e48326763d56ecdcc3f) TaleWorlds.TwoDimension.RichText.VerticalAlignment | | getset |

Implements [TaleWorlds.TwoDimension.IText](interface_tale_worlds_1_1_two_dimension_1_1_i_text.html#a62eec8ae3c6c43cb2600417758fbb3a4).

[◆](class_tale_worlds_1_1_two_dimension_1_1_rich_text.html#a68e70ddad20edd557d1d1b2c1286f1a8)Value
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.TwoDimension.RichText.Value | | getset |

Implements [TaleWorlds.TwoDimension.IText](interface_tale_worlds_1_1_two_dimension_1_1_i_text.html#ad32f83d78505d56f1f51ea1534afa09e).

[◆](class_tale_worlds_1_1_two_dimension_1_1_rich_text.html#a1437b65ee880c8d9584b499faaa46743)FocusedLinkGroup
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [RichTextLinkGroup](class_tale_worlds_1_1_two_dimension_1_1_rich_text_link_group.html) TaleWorlds.TwoDimension.RichText.FocusedLinkGroup | | get |

[◆](class_tale_worlds_1_1_two_dimension_1_1_rich_text.html#afd14dfac0c3976bf84b3107165dc66f0)SkipLineOnContainerExceeded
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.TwoDimension.RichText.SkipLineOnContainerExceeded | | getset |

[◆](class_tale_worlds_1_1_two_dimension_1_1_rich_text.html#ac5eec7572d7ab8fc43fec1076309f304)CanBreakWords
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.TwoDimension.RichText.CanBreakWords | | getset |

