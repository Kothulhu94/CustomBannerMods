--- SOURCE: class_tale_worlds_1_1_gauntlet_u_i_1_1_language.html ---

TaleWorlds.GauntletUI.Language Class ReferenceInherits [TaleWorlds.TwoDimension.ILanguage](interface_tale_worlds_1_1_two_dimension_1_1_i_language.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| bool | [FontMapHasKey](class_tale_worlds_1_1_gauntlet_u_i_1_1_language.html#a286a1f68732c4e103a0650924e4a1c9d) (string keyFontName) |
|  | Returns if given keyFontName is defined in the mapping in this language. |
| [Font](class_tale_worlds_1_1_two_dimension_1_1_font.html) | [GetMappedFont](class_tale_worlds_1_1_gauntlet_u_i_1_1_language.html#ad33a4feee7b30960f751bb8d57c7bf5d) (string keyFontName) |
|  | Get mapped font in this language from keyFontName to font in this language. |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static Language | [CreateFrom](class_tale_worlds_1_1_gauntlet_u_i_1_1_language.html#a1bb2b4f20f15200ca2eba07c24294a5c) (XmlNode languageNode, [FontFactory](class_tale_worlds_1_1_gauntlet_u_i_1_1_font_factory.html) fontFactory) |

|  |  |
| --- | --- |
| Properties | |
| char[] | [ForbiddenStartOfLineCharacters](class_tale_worlds_1_1_gauntlet_u_i_1_1_language.html#a448c17340e7ba301321568e7efb94e16) `[get]` |
|  | List of characters that cannot come at the beginning of lines. |
| char[] | [ForbiddenEndOfLineCharacters](class_tale_worlds_1_1_gauntlet_u_i_1_1_language.html#ad2ca23db784b668ce3dba04386d9cacb) `[get]` |
|  | List of characters that cannot come to the end of lines. |
| string | [LanguageID](class_tale_worlds_1_1_gauntlet_u_i_1_1_language.html#a0adbc3580063548cc4b575b5c2edf7f8) `[get]` |
| string | [DefaultFontName](class_tale_worlds_1_1_gauntlet_u_i_1_1_language.html#a0c5adc61187012d20cd1645442bc9555) `[get]` |
| bool | [DoesFontRequireSpaceForNewline](class_tale_worlds_1_1_gauntlet_u_i_1_1_language.html#a13499d0710e0be3edeeed4a013a9e34e) = true `[get]` |
|  | Does this language require a space for breaking into a new line Some Asian languages don't require spaces for newlines. |
| [Font](class_tale_worlds_1_1_two_dimension_1_1_font.html) | [DefaultFont](class_tale_worlds_1_1_gauntlet_u_i_1_1_language.html#a8c39f2032819fadfdb626b9df78e60a6) `[get]` |
|  | Default font of this language. |
| char | [LineSeperatorChar](class_tale_worlds_1_1_gauntlet_u_i_1_1_language.html#aa9066c5046d0522554301c99f1a4595a) `[get]` |
|  | Char that is used to separate the line. |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_language.html#a286a1f68732c4e103a0650924e4a1c9d)FontMapHasKey()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.GauntletUI.Language.FontMapHasKey | ( | string | *keyFontName* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | keyFontName |  |

Implements [TaleWorlds.TwoDimension.ILanguage](interface_tale_worlds_1_1_two_dimension_1_1_i_language.html#a37a923cebe9d49b162368e19888cce3a).

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_language.html#ad33a4feee7b30960f751bb8d57c7bf5d)GetMappedFont()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Font](class_tale_worlds_1_1_two_dimension_1_1_font.html) TaleWorlds.GauntletUI.Language.GetMappedFont | ( | string | *keyFontName* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | keyFontName | [Font](class_tale_worlds_1_1_two_dimension_1_1_font.html) name in English font |

Implements [TaleWorlds.TwoDimension.ILanguage](interface_tale_worlds_1_1_two_dimension_1_1_i_language.html#ad4bd3ac895d1e6801130579a16983038).

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_language.html#a1bb2b4f20f15200ca2eba07c24294a5c)CreateFrom()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | Language TaleWorlds.GauntletUI.Language.CreateFrom | ( | XmlNode | *languageNode*, | |  |  | [FontFactory](class_tale_worlds_1_1_gauntlet_u_i_1_1_font_factory.html) | *fontFactory* ) | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_language.html#a448c17340e7ba301321568e7efb94e16)ForbiddenStartOfLineCharacters
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | char [] TaleWorlds.GauntletUI.Language.ForbiddenStartOfLineCharacters | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_language.html#ad2ca23db784b668ce3dba04386d9cacb)ForbiddenEndOfLineCharacters
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | char [] TaleWorlds.GauntletUI.Language.ForbiddenEndOfLineCharacters | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_language.html#a0adbc3580063548cc4b575b5c2edf7f8)LanguageID
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.GauntletUI.Language.LanguageID | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_language.html#a0c5adc61187012d20cd1645442bc9555)DefaultFontName
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.GauntletUI.Language.DefaultFontName | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_language.html#a13499d0710e0be3edeeed4a013a9e34e)DoesFontRequireSpaceForNewline
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.GauntletUI.Language.DoesFontRequireSpaceForNewline = true | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_language.html#a8c39f2032819fadfdb626b9df78e60a6)DefaultFont
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Font](class_tale_worlds_1_1_two_dimension_1_1_font.html) TaleWorlds.GauntletUI.Language.DefaultFont | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_language.html#aa9066c5046d0522554301c99f1a4595a)LineSeperatorChar
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | char TaleWorlds.GauntletUI.Language.LineSeperatorChar | | get |

