--- SOURCE: class_tale_worlds_1_1_gauntlet_u_i_1_1_font_factory.html ---

TaleWorlds.GauntletUI.FontFactory Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [FontFactory](class_tale_worlds_1_1_gauntlet_u_i_1_1_font_factory.html#aa4c0fe7a621bc6d6035bb332018a568f) ([ResourceDepot](class_tale_worlds_1_1_library_1_1_resource_depot.html) resourceDepot) |
| void | [LoadAllFonts](class_tale_worlds_1_1_gauntlet_u_i_1_1_font_factory.html#aeaf9ed4f47e3ed5d303de43a3d78dab3) ([SpriteData](class_tale_worlds_1_1_two_dimension_1_1_sprite_data.html) spriteData) |
| bool | [TryAddFontDefinition](class_tale_worlds_1_1_gauntlet_u_i_1_1_font_factory.html#addd37e078df74bc8cf3f8ee69d7d0e44) (string fontPath, string fontName, [SpriteData](class_tale_worlds_1_1_two_dimension_1_1_sprite_data.html) spriteData) |
| void | [LoadLocalizationValues](class_tale_worlds_1_1_gauntlet_u_i_1_1_font_factory.html#a14c8a81c2271a94fa27cc9785eb82507) (string sourceXMLPath) |
| [Font](class_tale_worlds_1_1_two_dimension_1_1_font.html) | [GetFont](class_tale_worlds_1_1_gauntlet_u_i_1_1_font_factory.html#a74ec7b33ca0e7e9305d412664ccc2360) (string fontName) |
| IEnumerable< [Font](class_tale_worlds_1_1_two_dimension_1_1_font.html) > | [GetFonts](class_tale_worlds_1_1_gauntlet_u_i_1_1_font_factory.html#a58ceed35e1139bd91c9462bf74c96cbb) () |
| string | [GetFontName](class_tale_worlds_1_1_gauntlet_u_i_1_1_font_factory.html#ae385f208821b8d3f217d9074dce0729d) ([Font](class_tale_worlds_1_1_two_dimension_1_1_font.html) font) |
| [Font](class_tale_worlds_1_1_two_dimension_1_1_font.html) | [GetMappedFontForLocalization](class_tale_worlds_1_1_gauntlet_u_i_1_1_font_factory.html#a51e9d8e81c26f6b241f8113d0004832e) (string englishFontName) |
| void | [OnLanguageChange](class_tale_worlds_1_1_gauntlet_u_i_1_1_font_factory.html#abea091259c83fe2fefb3536fce67deed) (string newLanguageCode) |
| [Font](class_tale_worlds_1_1_two_dimension_1_1_font.html) | [GetUsableFontForCharacter](class_tale_worlds_1_1_gauntlet_u_i_1_1_font_factory.html#abb2494e4f1ea4eb18a4e734f4c13c8d5) (int characterCode) |
|  | Used in cases where a text is requested but the used font doesn't include that character. |
| void | [CheckForUpdates](class_tale_worlds_1_1_gauntlet_u_i_1_1_font_factory.html#abbc29979ca3142d7f736c13fbd17f764) () |

|  |  |
| --- | --- |
| Properties | |
| [Language](class_tale_worlds_1_1_gauntlet_u_i_1_1_language.html) | [DefaultLanguage](class_tale_worlds_1_1_gauntlet_u_i_1_1_font_factory.html#ae6a80fcf5b1e93206c267f93001436e6) `[get]` |
| [Language](class_tale_worlds_1_1_gauntlet_u_i_1_1_language.html)?????? | [CurrentLanguage](class_tale_worlds_1_1_gauntlet_u_i_1_1_font_factory.html#ab074bd2797664018911bebe46bcac645) `[get]` |
| [Font](class_tale_worlds_1_1_two_dimension_1_1_font.html) | [DefaultFont](class_tale_worlds_1_1_gauntlet_u_i_1_1_font_factory.html#ae68765562b848095ffca54bcdf505b95) `[get]` |
|  | Default font for the current language. |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_font_factory.html#aa4c0fe7a621bc6d6035bb332018a568f)FontFactory()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.GauntletUI.FontFactory.FontFactory | ( | [ResourceDepot](class_tale_worlds_1_1_library_1_1_resource_depot.html) | *resourceDepot* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_font_factory.html#aeaf9ed4f47e3ed5d303de43a3d78dab3)LoadAllFonts()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.FontFactory.LoadAllFonts | ( | [SpriteData](class_tale_worlds_1_1_two_dimension_1_1_sprite_data.html) | *spriteData* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_font_factory.html#addd37e078df74bc8cf3f8ee69d7d0e44)TryAddFontDefinition()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.GauntletUI.FontFactory.TryAddFontDefinition | ( | string | *fontPath*, |
|  |  | string | *fontName*, |
|  |  | [SpriteData](class_tale_worlds_1_1_two_dimension_1_1_sprite_data.html) | *spriteData* ) |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_font_factory.html#a14c8a81c2271a94fa27cc9785eb82507)LoadLocalizationValues()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.FontFactory.LoadLocalizationValues | ( | string | *sourceXMLPath* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_font_factory.html#a74ec7b33ca0e7e9305d412664ccc2360)GetFont()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Font](class_tale_worlds_1_1_two_dimension_1_1_font.html) TaleWorlds.GauntletUI.FontFactory.GetFont | ( | string | *fontName* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_font_factory.html#a58ceed35e1139bd91c9462bf74c96cbb)GetFonts()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< [Font](class_tale_worlds_1_1_two_dimension_1_1_font.html) > TaleWorlds.GauntletUI.FontFactory.GetFonts | ( |  | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_font_factory.html#ae385f208821b8d3f217d9074dce0729d)GetFontName()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| string TaleWorlds.GauntletUI.FontFactory.GetFontName | ( | [Font](class_tale_worlds_1_1_two_dimension_1_1_font.html) | *font* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_font_factory.html#a51e9d8e81c26f6b241f8113d0004832e)GetMappedFontForLocalization()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Font](class_tale_worlds_1_1_two_dimension_1_1_font.html) TaleWorlds.GauntletUI.FontFactory.GetMappedFontForLocalization | ( | string | *englishFontName* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_font_factory.html#abea091259c83fe2fefb3536fce67deed)OnLanguageChange()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.FontFactory.OnLanguageChange | ( | string | *newLanguageCode* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_font_factory.html#abb2494e4f1ea4eb18a4e734f4c13c8d5)GetUsableFontForCharacter()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Font](class_tale_worlds_1_1_two_dimension_1_1_font.html) TaleWorlds.GauntletUI.FontFactory.GetUsableFontForCharacter | ( | int | *characterCode* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_font_factory.html#abbc29979ca3142d7f736c13fbd17f764)CheckForUpdates()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.FontFactory.CheckForUpdates | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_font_factory.html#ae6a80fcf5b1e93206c267f93001436e6)DefaultLanguage
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Language](class_tale_worlds_1_1_gauntlet_u_i_1_1_language.html) TaleWorlds.GauntletUI.FontFactory.DefaultLanguage | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_font_factory.html#ab074bd2797664018911bebe46bcac645)CurrentLanguage
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Language](class_tale_worlds_1_1_gauntlet_u_i_1_1_language.html)?????? TaleWorlds.GauntletUI.FontFactory.CurrentLanguage | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_font_factory.html#ae68765562b848095ffca54bcdf505b95)DefaultFont
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Font](class_tale_worlds_1_1_two_dimension_1_1_font.html) TaleWorlds.GauntletUI.FontFactory.DefaultFont | | get |

