--- SOURCE: interface_tale_worlds_1_1_two_dimension_1_1_i_language.html ---

TaleWorlds.TwoDimension.ILanguage Interface ReferenceInherited by [TaleWorlds.GauntletUI.Language](class_tale_worlds_1_1_gauntlet_u_i_1_1_language.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| IEnumerable< char > | [GetForbiddenStartOfLineCharacters](interface_tale_worlds_1_1_two_dimension_1_1_i_language.html#a401415b9c0a720c0e758030b80e3dcaf) () |
|  | List of characters that cannot come at the beginning of lines. |
| bool | [IsCharacterForbiddenAtStartOfLine](interface_tale_worlds_1_1_two_dimension_1_1_i_language.html#a92adf5e8cda7a8d40539a02c189bbf22) (char character) |
| IEnumerable< char > | [GetForbiddenEndOfLineCharacters](interface_tale_worlds_1_1_two_dimension_1_1_i_language.html#a5ebc0bf467a5ce23153c9e14897cc178) () |
|  | List of characters that cannot come to the end of lines. |
| bool | [IsCharacterForbiddenAtEndOfLine](interface_tale_worlds_1_1_two_dimension_1_1_i_language.html#a4633f62d067cef54ee1ae95eb1604dd3) (char character) |
| string | [GetLanguageID](interface_tale_worlds_1_1_two_dimension_1_1_i_language.html#aec87c0646b452eda51ec7a25170df557) () |
| string | [GetDefaultFontName](interface_tale_worlds_1_1_two_dimension_1_1_i_language.html#a7ec157f50c8a3f20dec520149aec9d35) () |
| [Font](class_tale_worlds_1_1_two_dimension_1_1_font.html) | [GetDefaultFont](interface_tale_worlds_1_1_two_dimension_1_1_i_language.html#a163bc3357b39de4ee86a3285f571b40a) () |
|  | Default font of this language. |
| char | [GetLineSeperatorChar](interface_tale_worlds_1_1_two_dimension_1_1_i_language.html#a1f1e8c3bd94ca523241c02b1fc022e22) () |
|  | Line separator character of this language. |
| bool | [DoesLanguageRequireSpaceForNewline](interface_tale_worlds_1_1_two_dimension_1_1_i_language.html#ac4008f59d1fab13de9f6849224cd49e6) () |
|  | Does this language require a space for breaking into a new line Some Asian languages don't require spaces for newlines. |
| bool | [FontMapHasKey](interface_tale_worlds_1_1_two_dimension_1_1_i_language.html#a37a923cebe9d49b162368e19888cce3a) (string keyFontName) |
|  | Returns if given keyFontName is defined in the mapping in this language. |
| [Font](class_tale_worlds_1_1_two_dimension_1_1_font.html) | [GetMappedFont](interface_tale_worlds_1_1_two_dimension_1_1_i_language.html#ad4bd3ac895d1e6801130579a16983038) (string keyFontName) |
|  | Get mapped font in this language from keyFontName to font in this language. |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_two_dimension_1_1_i_language.html#a401415b9c0a720c0e758030b80e3dcaf)GetForbiddenStartOfLineCharacters()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< char > TaleWorlds.TwoDimension.ILanguage.GetForbiddenStartOfLineCharacters | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_two_dimension_1_1_i_language.html#a92adf5e8cda7a8d40539a02c189bbf22)IsCharacterForbiddenAtStartOfLine()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.TwoDimension.ILanguage.IsCharacterForbiddenAtStartOfLine | ( | char | *character* | ) |  |

[◆](interface_tale_worlds_1_1_two_dimension_1_1_i_language.html#a5ebc0bf467a5ce23153c9e14897cc178)GetForbiddenEndOfLineCharacters()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< char > TaleWorlds.TwoDimension.ILanguage.GetForbiddenEndOfLineCharacters | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_two_dimension_1_1_i_language.html#a4633f62d067cef54ee1ae95eb1604dd3)IsCharacterForbiddenAtEndOfLine()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.TwoDimension.ILanguage.IsCharacterForbiddenAtEndOfLine | ( | char | *character* | ) |  |

[◆](interface_tale_worlds_1_1_two_dimension_1_1_i_language.html#aec87c0646b452eda51ec7a25170df557)GetLanguageID()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.TwoDimension.ILanguage.GetLanguageID | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_two_dimension_1_1_i_language.html#a7ec157f50c8a3f20dec520149aec9d35)GetDefaultFontName()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.TwoDimension.ILanguage.GetDefaultFontName | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_two_dimension_1_1_i_language.html#a163bc3357b39de4ee86a3285f571b40a)GetDefaultFont()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Font](class_tale_worlds_1_1_two_dimension_1_1_font.html) TaleWorlds.TwoDimension.ILanguage.GetDefaultFont | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_two_dimension_1_1_i_language.html#a1f1e8c3bd94ca523241c02b1fc022e22)GetLineSeperatorChar()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| char TaleWorlds.TwoDimension.ILanguage.GetLineSeperatorChar | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_two_dimension_1_1_i_language.html#ac4008f59d1fab13de9f6849224cd49e6)DoesLanguageRequireSpaceForNewline()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.TwoDimension.ILanguage.DoesLanguageRequireSpaceForNewline | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_two_dimension_1_1_i_language.html#a37a923cebe9d49b162368e19888cce3a)FontMapHasKey()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.TwoDimension.ILanguage.FontMapHasKey | ( | string | *keyFontName* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | keyFontName |  |

Implemented in [TaleWorlds.GauntletUI.Language](class_tale_worlds_1_1_gauntlet_u_i_1_1_language.html#a286a1f68732c4e103a0650924e4a1c9d).

[◆](interface_tale_worlds_1_1_two_dimension_1_1_i_language.html#ad4bd3ac895d1e6801130579a16983038)GetMappedFont()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Font](class_tale_worlds_1_1_two_dimension_1_1_font.html) TaleWorlds.TwoDimension.ILanguage.GetMappedFont | ( | string | *keyFontName* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | keyFontName | [Font](class_tale_worlds_1_1_two_dimension_1_1_font.html) name in English font |

Implemented in [TaleWorlds.GauntletUI.Language](class_tale_worlds_1_1_gauntlet_u_i_1_1_language.html#ad33a4feee7b30960f751bb8d57c7bf5d).

