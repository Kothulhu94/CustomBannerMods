--- SOURCE: class_tale_worlds_1_1_localization_1_1_localized_text_manager.html ---

TaleWorlds.Localization.LocalizedTextManager Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static string | [GetTranslatedText](class_tale_worlds_1_1_localization_1_1_localized_text_manager.html#a92c09246e1c65cd75a893fb1a4ea66e0) (string languageId, string id) |
| static List< string > | [GetLanguageIds](class_tale_worlds_1_1_localization_1_1_localized_text_manager.html#ac5088d4dd97f64f6c4010c4b002fb702) (bool developmentMode) |
| static string | [GetLanguageTitle](class_tale_worlds_1_1_localization_1_1_localized_text_manager.html#a4611b8edee43e0266da1d6c4a98cdaee) (string id) |
| static [LanguageSpecificTextProcessor](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_specific_text_processor.html) | [CreateTextProcessorForLanguage](class_tale_worlds_1_1_localization_1_1_localized_text_manager.html#a86f9ca141759fa4211f3450ca62a4162) (string id) |
| static void | [AddLanguageTest](class_tale_worlds_1_1_localization_1_1_localized_text_manager.html#a67b4b65e6319dbfb0073da8ac8867aaf) (string id, string processor) |
| static int | [GetLanguageIndex](class_tale_worlds_1_1_localization_1_1_localized_text_manager.html#a5d16e909320d654b3b170187e299aa44) (string id) |
| static void | [LoadLocalizationXmls](class_tale_worlds_1_1_localization_1_1_localized_text_manager.html#ac93fefcd2533c2d9e04038197c245f17) (string[] loadedModules) |
| static void | [AddLocalizationXml](class_tale_worlds_1_1_localization_1_1_localized_text_manager.html#aaa049a7579d4912533f201ab67de7b4d) (string newModule) |
| static string | [GetDateFormattedByLanguage](class_tale_worlds_1_1_localization_1_1_localized_text_manager.html#a02c542b147e6b56649482ceb1379f65c) (string languageCode, DateTime dateTime) |
| static string | [GetTimeFormattedByLanguage](class_tale_worlds_1_1_localization_1_1_localized_text_manager.html#aabb2e0b77021cac9430110a3a7808c60) (string languageCode, DateTime dateTime) |
| static string | [GetSubtitleExtensionOfLanguage](class_tale_worlds_1_1_localization_1_1_localized_text_manager.html#a7656b1f301af8fe20f4fde252526f407) (string languageId) |
| static string | [GetLocalizationCodeOfISOLanguageCode](class_tale_worlds_1_1_localization_1_1_localized_text_manager.html#af578653b3dfd9cd8303b68443364b7f4) (string isoLanguageCode) |
|  | Returns localization code used in, in-game localization files, from given ISO-Language Code. |
| static string | [ChangeLanguage](class_tale_worlds_1_1_localization_1_1_localized_text_manager.html#ad2ebaafa4d86682b7e1b2558b05fdf09) (List< string > strings) |
| static string | [ReloadTexts](class_tale_worlds_1_1_localization_1_1_localized_text_manager.html#a72d8047b10171906a3472ab45c461e1b) (List< string > strings) |
| static string | [CheckValidity](class_tale_worlds_1_1_localization_1_1_localized_text_manager.html#a16b3e3aa632be2dc0dfecbf7851514a9) (List< string > strings) |
| static bool | [CheckValidity](class_tale_worlds_1_1_localization_1_1_localized_text_manager.html#adb2bebef5213e4ec2b0b4207b6fc31e8) (string id, string text, out string errorLine) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const string | [LanguageDataFileName](class_tale_worlds_1_1_localization_1_1_localized_text_manager.html#afe94df6dbc901b36389522537b76cbef) = "language\_data" |
| const string | [DefaultEnglishLanguageId](class_tale_worlds_1_1_localization_1_1_localized_text_manager.html#a253b8c984b0158b78c2c8ede158347e8) = "English" |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_localization_1_1_localized_text_manager.html#a92c09246e1c65cd75a893fb1a4ea66e0)GetTranslatedText()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | string TaleWorlds.Localization.LocalizedTextManager.GetTranslatedText | ( | string | *languageId*, | |  |  | string | *id* ) | | static |

[◆](class_tale_worlds_1_1_localization_1_1_localized_text_manager.html#ac5088d4dd97f64f6c4010c4b002fb702)GetLanguageIds()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | List< string > TaleWorlds.Localization.LocalizedTextManager.GetLanguageIds | ( | bool | *developmentMode* | ) |  | | static |

[◆](class_tale_worlds_1_1_localization_1_1_localized_text_manager.html#a4611b8edee43e0266da1d6c4a98cdaee)GetLanguageTitle()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.Localization.LocalizedTextManager.GetLanguageTitle | ( | string | *id* | ) |  | | static |

[◆](class_tale_worlds_1_1_localization_1_1_localized_text_manager.html#a86f9ca141759fa4211f3450ca62a4162)CreateTextProcessorForLanguage()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [LanguageSpecificTextProcessor](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_specific_text_processor.html) TaleWorlds.Localization.LocalizedTextManager.CreateTextProcessorForLanguage | ( | string | *id* | ) |  | | static |

[◆](class_tale_worlds_1_1_localization_1_1_localized_text_manager.html#a67b4b65e6319dbfb0073da8ac8867aaf)AddLanguageTest()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Localization.LocalizedTextManager.AddLanguageTest | ( | string | *id*, | |  |  | string | *processor* ) | | static |

[◆](class_tale_worlds_1_1_localization_1_1_localized_text_manager.html#a5d16e909320d654b3b170187e299aa44)GetLanguageIndex()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.Localization.LocalizedTextManager.GetLanguageIndex | ( | string | *id* | ) |  | | static |

[◆](class_tale_worlds_1_1_localization_1_1_localized_text_manager.html#ac93fefcd2533c2d9e04038197c245f17)LoadLocalizationXmls()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Localization.LocalizedTextManager.LoadLocalizationXmls | ( | string[] | *loadedModules* | ) |  | | static |

[◆](class_tale_worlds_1_1_localization_1_1_localized_text_manager.html#aaa049a7579d4912533f201ab67de7b4d)AddLocalizationXml()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Localization.LocalizedTextManager.AddLocalizationXml | ( | string | *newModule* | ) |  | | static |

[◆](class_tale_worlds_1_1_localization_1_1_localized_text_manager.html#a02c542b147e6b56649482ceb1379f65c)GetDateFormattedByLanguage()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | string TaleWorlds.Localization.LocalizedTextManager.GetDateFormattedByLanguage | ( | string | *languageCode*, | |  |  | DateTime | *dateTime* ) | | static |

[◆](class_tale_worlds_1_1_localization_1_1_localized_text_manager.html#aabb2e0b77021cac9430110a3a7808c60)GetTimeFormattedByLanguage()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | string TaleWorlds.Localization.LocalizedTextManager.GetTimeFormattedByLanguage | ( | string | *languageCode*, | |  |  | DateTime | *dateTime* ) | | static |

[◆](class_tale_worlds_1_1_localization_1_1_localized_text_manager.html#a7656b1f301af8fe20f4fde252526f407)GetSubtitleExtensionOfLanguage()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.Localization.LocalizedTextManager.GetSubtitleExtensionOfLanguage | ( | string | *languageId* | ) |  | | static |

[◆](class_tale_worlds_1_1_localization_1_1_localized_text_manager.html#af578653b3dfd9cd8303b68443364b7f4)GetLocalizationCodeOfISOLanguageCode()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.Localization.LocalizedTextManager.GetLocalizationCodeOfISOLanguageCode | ( | string | *isoLanguageCode* | ) |  | | static |

[◆](class_tale_worlds_1_1_localization_1_1_localized_text_manager.html#ad2ebaafa4d86682b7e1b2558b05fdf09)ChangeLanguage()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.Localization.LocalizedTextManager.ChangeLanguage | ( | List< string > | *strings* | ) |  | | static |

[◆](class_tale_worlds_1_1_localization_1_1_localized_text_manager.html#a72d8047b10171906a3472ab45c461e1b)ReloadTexts()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.Localization.LocalizedTextManager.ReloadTexts | ( | List< string > | *strings* | ) |  | | static |

[◆](class_tale_worlds_1_1_localization_1_1_localized_text_manager.html#a16b3e3aa632be2dc0dfecbf7851514a9)CheckValidity() [1/2]
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.Localization.LocalizedTextManager.CheckValidity | ( | List< string > | *strings* | ) |  | | static |

[◆](class_tale_worlds_1_1_localization_1_1_localized_text_manager.html#adb2bebef5213e4ec2b0b4207b6fc31e8)CheckValidity() [2/2]
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Localization.LocalizedTextManager.CheckValidity | ( | string | *id*, | |  |  | string | *text*, | |  |  | out string | *errorLine* ) | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_localization_1_1_localized_text_manager.html#afe94df6dbc901b36389522537b76cbef)LanguageDataFileName
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.Localization.LocalizedTextManager.LanguageDataFileName = "language\_data" | | static |

[◆](class_tale_worlds_1_1_localization_1_1_localized_text_manager.html#a253b8c984b0158b78c2c8ede158347e8)DefaultEnglishLanguageId
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.Localization.LocalizedTextManager.DefaultEnglishLanguageId = "English" | | static |

