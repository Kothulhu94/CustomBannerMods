--- SOURCE: class_tale_worlds_1_1_localization_1_1_text_object.html ---

TaleWorlds.Localization.TextObject Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html#a696a10886cc704d4b7883907f665d26c) (string value, Dictionary< string, object > attributes=null) |
|  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html#a3e58800523b180f2eeae35e5e6fe2523) (int value, Dictionary< string, object > attributes=null) |
|  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html#ab0bf637a8b8d0160f9a540e139c2c551) (float value, Dictionary< string, object > attributes=null) |
| void | [CacheTokens](class_tale_worlds_1_1_localization_1_1_text_object.html#a2353b61730093d60fc6abbce14bfbb5c) () |
| bool | [IsEmpty](class_tale_worlds_1_1_localization_1_1_text_object.html#a8929029b76607e8c31be4107b4166009) () |
| override string | [ToString](class_tale_worlds_1_1_localization_1_1_text_object.html#a833285114fb615b39128400ccead3dc6) () |
| string | [ToStringWithoutClear](class_tale_worlds_1_1_localization_1_1_text_object.html#a229601bbfb7903b4d3e3d19adcc1b3f4) () |
| string | [Format](class_tale_worlds_1_1_localization_1_1_text_object.html#a681623c56224645e471b1d44d6685b06) (float p1) |
| bool | [Contains](class_tale_worlds_1_1_localization_1_1_text_object.html#a211678d339eedebbdc50a5807f4fb27a) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html#a696a10886cc704d4b7883907f665d26c) to) |
| bool | [Contains](class_tale_worlds_1_1_localization_1_1_text_object.html#a6f21ce5b5dd20a4208a9b77202fe40e2) (string text) |
| override bool | [Equals](class_tale_worlds_1_1_localization_1_1_text_object.html#a348272d4b966edc4dc34218329ba6c38) (object other) |
| override int | [GetHashCode](class_tale_worlds_1_1_localization_1_1_text_object.html#a8bb3756e1d2794959653793774bf7c83) () |
| bool | [Equals](class_tale_worlds_1_1_localization_1_1_text_object.html#a9a1de601ef960b27601d5aefe709d87d) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html#a696a10886cc704d4b7883907f665d26c) other) |
| bool | [HasSameValue](class_tale_worlds_1_1_localization_1_1_text_object.html#a683fdc4206e39491bb08cd0b17364a8b) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html#a696a10886cc704d4b7883907f665d26c) to) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html#a696a10886cc704d4b7883907f665d26c) | [SetTextVariable](class_tale_worlds_1_1_localization_1_1_text_object.html#ae6adb0f55aa91287fba042e06eef1170) (string tag, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html#a696a10886cc704d4b7883907f665d26c) variable) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html#a696a10886cc704d4b7883907f665d26c) | [SetTextVariable](class_tale_worlds_1_1_localization_1_1_text_object.html#ab0a7998bddc20a9645e2d56fc4a87f1c) (string tag, string variable) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html#a696a10886cc704d4b7883907f665d26c) | [SetTextVariable](class_tale_worlds_1_1_localization_1_1_text_object.html#a75fbbd126729ffc3f3f55075760f9f71) (string tag, float variable, int decimalDigits=2) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html#a696a10886cc704d4b7883907f665d26c) | [SetTextVariable](class_tale_worlds_1_1_localization_1_1_text_object.html#ab34e146be63b03975814bfbb43bb6d2f) (string tag, int variable) |
| void | [AddIDToValue](class_tale_worlds_1_1_localization_1_1_text_object.html#a2e274d2362e6bfb66fdf57a5cbe36126) (string id) |
| bool | [GetVariableValue](class_tale_worlds_1_1_localization_1_1_text_object.html#ae632b4f77a2a2ae1536d91a7202ed81b) (string tag, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html#a696a10886cc704d4b7883907f665d26c) variable) |
| int | [GetValueHashCode](class_tale_worlds_1_1_localization_1_1_text_object.html#af8311d14cc6659949c2556a16694b2bb) () |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html#a696a10886cc704d4b7883907f665d26c) | [CopyTextObject](class_tale_worlds_1_1_localization_1_1_text_object.html#a05d23fade2bf4229f22b5e541fd30186) () |
| string | [GetID](class_tale_worlds_1_1_localization_1_1_text_object.html#a847081f3fc93ed26fc59c155b23021a3) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html#a696a10886cc704d4b7883907f665d26c) | [GetEmpty](class_tale_worlds_1_1_localization_1_1_text_object.html#a7610c7f72e75604a8fcaf95b35e020a5) () |
| static bool | [IsNullOrEmpty](class_tale_worlds_1_1_localization_1_1_text_object.html#af09a483c8e2050ec26635427fd0db587) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html#a696a10886cc704d4b7883907f665d26c) obj) |
| static bool | [operator==](class_tale_worlds_1_1_localization_1_1_text_object.html#a25de14647d1694aca782e530959e5207) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html#a696a10886cc704d4b7883907f665d26c) lhs, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html#a696a10886cc704d4b7883907f665d26c) rhs) |
| static bool | [operator!=](class_tale_worlds_1_1_localization_1_1_text_object.html#ad002427d8d40be1bbe521d416f89356a) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html#a696a10886cc704d4b7883907f665d26c) lhs, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html#a696a10886cc704d4b7883907f665d26c) rhs) |
| static List< string > | [ConvertToStringList](class_tale_worlds_1_1_localization_1_1_text_object.html#a56badaa4e0485d31470e5cab91350d8c) (List< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html#a696a10886cc704d4b7883907f665d26c) > to) |

|  |  |
| --- | --- |
| Public Attributes | |
| string | [Value](class_tale_worlds_1_1_localization_1_1_text_object.html#af2a6b37c76a75776cf2bbc1af5eaef6a) |

|  |  |
| --- | --- |
| Properties | |
| Dictionary< string, object > | [Attributes](class_tale_worlds_1_1_localization_1_1_text_object.html#aa5b8c6248c37503abd77de6c39209f91) `[get]` |
| int | [Length](class_tale_worlds_1_1_localization_1_1_text_object.html#a8c52c32903a6a86ef8868ddad53e0939) `[get]` |
| bool | [IsLink](class_tale_worlds_1_1_localization_1_1_text_object.html#a32d187d7e5ae2ff925d05fb85e928c1c) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_localization_1_1_text_object.html#a696a10886cc704d4b7883907f665d26c)TextObject() [1/3]
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Localization.TextObject.TextObject | ( | string | *value*, |
|  |  | Dictionary< string, object > | *attributes* = null ) |

[◆](class_tale_worlds_1_1_localization_1_1_text_object.html#a3e58800523b180f2eeae35e5e6fe2523)TextObject() [2/3]
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Localization.TextObject.TextObject | ( | int | *value*, |
|  |  | Dictionary< string, object > | *attributes* = null ) |

[◆](class_tale_worlds_1_1_localization_1_1_text_object.html#ab0bf637a8b8d0160f9a540e139c2c551)TextObject() [3/3]
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Localization.TextObject.TextObject | ( | float | *value*, |
|  |  | Dictionary< string, object > | *attributes* = null ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_localization_1_1_text_object.html#a2353b61730093d60fc6abbce14bfbb5c)CacheTokens()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Localization.TextObject.CacheTokens | ( |  | ) |  |

[◆](class_tale_worlds_1_1_localization_1_1_text_object.html#a7610c7f72e75604a8fcaf95b35e020a5)GetEmpty()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html#a696a10886cc704d4b7883907f665d26c) TaleWorlds.Localization.TextObject.GetEmpty | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_localization_1_1_text_object.html#a8929029b76607e8c31be4107b4166009)IsEmpty()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Localization.TextObject.IsEmpty | ( |  | ) |  |

[◆](class_tale_worlds_1_1_localization_1_1_text_object.html#af09a483c8e2050ec26635427fd0db587)IsNullOrEmpty()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Localization.TextObject.IsNullOrEmpty | ( | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html#a696a10886cc704d4b7883907f665d26c) | *obj* | ) |  | | static |

[◆](class_tale_worlds_1_1_localization_1_1_text_object.html#a833285114fb615b39128400ccead3dc6)ToString()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.Localization.TextObject.ToString | ( |  | ) |  |

[◆](class_tale_worlds_1_1_localization_1_1_text_object.html#a229601bbfb7903b4d3e3d19adcc1b3f4)ToStringWithoutClear()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.Localization.TextObject.ToStringWithoutClear | ( |  | ) |  |

[◆](class_tale_worlds_1_1_localization_1_1_text_object.html#a681623c56224645e471b1d44d6685b06)Format()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| string TaleWorlds.Localization.TextObject.Format | ( | float | *p1* | ) |  |

[◆](class_tale_worlds_1_1_localization_1_1_text_object.html#a211678d339eedebbdc50a5807f4fb27a)Contains() [1/2]
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Localization.TextObject.Contains | ( | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html#a696a10886cc704d4b7883907f665d26c) | *to* | ) |  |

[◆](class_tale_worlds_1_1_localization_1_1_text_object.html#a6f21ce5b5dd20a4208a9b77202fe40e2)Contains() [2/2]
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Localization.TextObject.Contains | ( | string | *text* | ) |  |

[◆](class_tale_worlds_1_1_localization_1_1_text_object.html#a348272d4b966edc4dc34218329ba6c38)Equals() [1/2]
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.Localization.TextObject.Equals | ( | object | *other* | ) |  |

[◆](class_tale_worlds_1_1_localization_1_1_text_object.html#a8bb3756e1d2794959653793774bf7c83)GetHashCode()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.Localization.TextObject.GetHashCode | ( |  | ) |  |

[◆](class_tale_worlds_1_1_localization_1_1_text_object.html#a9a1de601ef960b27601d5aefe709d87d)Equals() [2/2]
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Localization.TextObject.Equals | ( | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html#a696a10886cc704d4b7883907f665d26c) | *other* | ) |  |

[◆](class_tale_worlds_1_1_localization_1_1_text_object.html#a683fdc4206e39491bb08cd0b17364a8b)HasSameValue()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Localization.TextObject.HasSameValue | ( | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html#a696a10886cc704d4b7883907f665d26c) | *to* | ) |  |

[◆](class_tale_worlds_1_1_localization_1_1_text_object.html#a25de14647d1694aca782e530959e5207)operator==()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Localization.TextObject.operator== | ( | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html#a696a10886cc704d4b7883907f665d26c) | *lhs*, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html#a696a10886cc704d4b7883907f665d26c) | *rhs* ) | | static |

[◆](class_tale_worlds_1_1_localization_1_1_text_object.html#ad002427d8d40be1bbe521d416f89356a)operator!=()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Localization.TextObject.operator!= | ( | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html#a696a10886cc704d4b7883907f665d26c) | *lhs*, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html#a696a10886cc704d4b7883907f665d26c) | *rhs* ) | | static |

[◆](class_tale_worlds_1_1_localization_1_1_text_object.html#a56badaa4e0485d31470e5cab91350d8c)ConvertToStringList()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | List< string > TaleWorlds.Localization.TextObject.ConvertToStringList | ( | List< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html#a696a10886cc704d4b7883907f665d26c) > | *to* | ) |  | | static |

[◆](class_tale_worlds_1_1_localization_1_1_text_object.html#ae6adb0f55aa91287fba042e06eef1170)SetTextVariable() [1/4]
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html#a696a10886cc704d4b7883907f665d26c) TaleWorlds.Localization.TextObject.SetTextVariable | ( | string | *tag*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html#a696a10886cc704d4b7883907f665d26c) | *variable* ) |

[◆](class_tale_worlds_1_1_localization_1_1_text_object.html#ab0a7998bddc20a9645e2d56fc4a87f1c)SetTextVariable() [2/4]
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html#a696a10886cc704d4b7883907f665d26c) TaleWorlds.Localization.TextObject.SetTextVariable | ( | string | *tag*, |
|  |  | string | *variable* ) |

[◆](class_tale_worlds_1_1_localization_1_1_text_object.html#a75fbbd126729ffc3f3f55075760f9f71)SetTextVariable() [3/4]
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html#a696a10886cc704d4b7883907f665d26c) TaleWorlds.Localization.TextObject.SetTextVariable | ( | string | *tag*, |
|  |  | float | *variable*, |
|  |  | int | *decimalDigits* = 2 ) |

[◆](class_tale_worlds_1_1_localization_1_1_text_object.html#ab34e146be63b03975814bfbb43bb6d2f)SetTextVariable() [4/4]
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html#a696a10886cc704d4b7883907f665d26c) TaleWorlds.Localization.TextObject.SetTextVariable | ( | string | *tag*, |
|  |  | int | *variable* ) |

[◆](class_tale_worlds_1_1_localization_1_1_text_object.html#a2e274d2362e6bfb66fdf57a5cbe36126)AddIDToValue()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Localization.TextObject.AddIDToValue | ( | string | *id* | ) |  |

[◆](class_tale_worlds_1_1_localization_1_1_text_object.html#ae632b4f77a2a2ae1536d91a7202ed81b)GetVariableValue()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Localization.TextObject.GetVariableValue | ( | string | *tag*, |
|  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html#a696a10886cc704d4b7883907f665d26c) | *variable* ) |

[◆](class_tale_worlds_1_1_localization_1_1_text_object.html#af8311d14cc6659949c2556a16694b2bb)GetValueHashCode()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.Localization.TextObject.GetValueHashCode | ( |  | ) |  |

[◆](class_tale_worlds_1_1_localization_1_1_text_object.html#a05d23fade2bf4229f22b5e541fd30186)CopyTextObject()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html#a696a10886cc704d4b7883907f665d26c) TaleWorlds.Localization.TextObject.CopyTextObject | ( |  | ) |  |

[◆](class_tale_worlds_1_1_localization_1_1_text_object.html#a847081f3fc93ed26fc59c155b23021a3)GetID()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.Localization.TextObject.GetID | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_localization_1_1_text_object.html#af2a6b37c76a75776cf2bbc1af5eaef6a)Value
---------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.Localization.TextObject.Value |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_localization_1_1_text_object.html#aa5b8c6248c37503abd77de6c39209f91)Attributes
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Dictionary<string, object> TaleWorlds.Localization.TextObject.Attributes | | get |

[◆](class_tale_worlds_1_1_localization_1_1_text_object.html#a8c52c32903a6a86ef8868ddad53e0939)Length
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Localization.TextObject.Length | | get |

[◆](class_tale_worlds_1_1_localization_1_1_text_object.html#a32d187d7e5ae2ff925d05fb85e928c1c)IsLink
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Localization.TextObject.IsLink | | get |

