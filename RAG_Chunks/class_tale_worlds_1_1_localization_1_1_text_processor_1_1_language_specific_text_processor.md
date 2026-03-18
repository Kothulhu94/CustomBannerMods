--- SOURCE: class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_specific_text_processor.html ---

TaleWorlds.Localization.TextProcessor.LanguageSpecificTextProcessor Class ReferenceabstractInherited by [TaleWorlds.Localization.TextProcessor.DefaultTextProcessor](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_default_text_processor.html), [TaleWorlds.Localization.TextProcessor.LanguageProcessors.EnglishTextProcessor](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_processors_1_1_english_text_processor.html), [TaleWorlds.Localization.TextProcessor.LanguageProcessors.FrenchTextProcessor](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_processors_1_1_french_text_processor.html), [TaleWorlds.Localization.TextProcessor.LanguageProcessors.GermanTextProcessor](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_processors_1_1_german_text_processor.html), [TaleWorlds.Localization.TextProcessor.LanguageProcessors.ItalianTextProcessor](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_processors_1_1_italian_text_processor.html), [TaleWorlds.Localization.TextProcessor.LanguageProcessors.PolishTextProcessor](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_processors_1_1_polish_text_processor.html), [TaleWorlds.Localization.TextProcessor.LanguageProcessors.RussianTextProcessor](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_processors_1_1_russian_text_processor.html), [TaleWorlds.Localization.TextProcessor.LanguageProcessors.SpanishTextProcessor](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_processors_1_1_spanish_text_processor.html), and [TaleWorlds.Localization.TextProcessor.LanguageProcessors.TurkishTextProcessor](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_processors_1_1_turkish_text_processor.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [ProcessToken](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_specific_text_processor.html#ace9e33be9ff73dd2c6152826158a7d75) (string sourceText, ref int cursorPos, string token, StringBuilder outputString) |
| void | [ClearTemporaryData](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_specific_text_processor.html#a60fe046b769e4b855e44ec8bdad781ed) () |
|  | [LanguageSpecificTextProcessor](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_specific_text_processor.html#a368e90e4d154b71135c2d3b41f6d5ecf) () |
| string | [Process](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_specific_text_processor.html#a4bb15179944170b1494ef54540574b2b) (string text) |

|  |  |
| --- | --- |
| Properties | |
| CultureInfo | [CultureInfoForLanguage](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_specific_text_processor.html#a7ce9889ca2b1b6e5d771457a7e1f0383) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_specific_text_processor.html#a368e90e4d154b71135c2d3b41f6d5ecf)LanguageSpecificTextProcessor()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Localization.TextProcessor.LanguageSpecificTextProcessor.LanguageSpecificTextProcessor | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_specific_text_processor.html#ace9e33be9ff73dd2c6152826158a7d75)ProcessToken()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Localization.TextProcessor.LanguageSpecificTextProcessor.ProcessToken | ( | string | *sourceText*, | |  |  | ref int | *cursorPos*, | |  |  | string | *token*, | |  |  | StringBuilder | *outputString* ) | | abstract |

[◆](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_specific_text_processor.html#a60fe046b769e4b855e44ec8bdad781ed)ClearTemporaryData()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Localization.TextProcessor.LanguageSpecificTextProcessor.ClearTemporaryData | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_specific_text_processor.html#a4bb15179944170b1494ef54540574b2b)Process()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| string TaleWorlds.Localization.TextProcessor.LanguageSpecificTextProcessor.Process | ( | string | *text* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_specific_text_processor.html#a7ce9889ca2b1b6e5d771457a7e1f0383)CultureInfoForLanguage
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | CultureInfo TaleWorlds.Localization.TextProcessor.LanguageSpecificTextProcessor.CultureInfoForLanguage | | getabstract |

