--- SOURCE: class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_processors_1_1_russian_text_processor.html ---

TaleWorlds.Localization.TextProcessor.LanguageProcessors.RussianTextProcessor Class ReferenceInherits [TaleWorlds.Localization.TextProcessor.LanguageSpecificTextProcessor](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_specific_text_processor.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [ClearTemporaryData](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_processors_1_1_russian_text_processor.html#a3a8860bf18b6530498dd28d568f38e1f) () |
| override void | [ProcessToken](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_processors_1_1_russian_text_processor.html#a1d780a866d78ee81e19c7af45570a2a8) (string sourceText, ref int cursorPos, string token, StringBuilder outputString) |
| string | [PrepareNounCheckString](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_processors_1_1_russian_text_processor.html#ac0ef13844eb6e67bdfd86809160a7593) (string noun) |
| string | [PrepareAdjectiveCheckString](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_processors_1_1_russian_text_processor.html#aa1e8777f034f95347033b105f213d986) (string adj) |
| Public Member Functions inherited from [TaleWorlds.Localization.TextProcessor.LanguageSpecificTextProcessor](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_specific_text_processor.html) | |
| void | [ProcessToken](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_specific_text_processor.html#ace9e33be9ff73dd2c6152826158a7d75) (string sourceText, ref int cursorPos, string token, StringBuilder outputString) |
| void | [ClearTemporaryData](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_specific_text_processor.html#a60fe046b769e4b855e44ec8bdad781ed) () |
|  | [LanguageSpecificTextProcessor](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_specific_text_processor.html#a368e90e4d154b71135c2d3b41f6d5ecf) () |
| string | [Process](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_specific_text_processor.html#a4bb15179944170b1494ef54540574b2b) (string text) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static string[] | [GetProcessedNouns](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_processors_1_1_russian_text_processor.html#acd839af058281639b9f8c4b836cd04e7) (string str, string gender, string[] tokens=null) |

|  |  |
| --- | --- |
| Properties | |
| override CultureInfo | [CultureInfoForLanguage](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_processors_1_1_russian_text_processor.html#af22999151cd0f73ccc160eda62232a48) `[get]` |
| Properties inherited from [TaleWorlds.Localization.TextProcessor.LanguageSpecificTextProcessor](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_specific_text_processor.html) | |
| CultureInfo | [CultureInfoForLanguage](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_specific_text_processor.html#a7ce9889ca2b1b6e5d771457a7e1f0383) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_processors_1_1_russian_text_processor.html#a3a8860bf18b6530498dd28d568f38e1f)ClearTemporaryData()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.Localization.TextProcessor.LanguageProcessors.RussianTextProcessor.ClearTemporaryData | ( |  | ) |  |

[◆](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_processors_1_1_russian_text_processor.html#a1d780a866d78ee81e19c7af45570a2a8)ProcessToken()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.Localization.TextProcessor.LanguageProcessors.RussianTextProcessor.ProcessToken | ( | string | *sourceText*, |
|  |  | ref int | *cursorPos*, |
|  |  | string | *token*, |
|  |  | StringBuilder | *outputString* ) |

[◆](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_processors_1_1_russian_text_processor.html#ac0ef13844eb6e67bdfd86809160a7593)PrepareNounCheckString()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| string TaleWorlds.Localization.TextProcessor.LanguageProcessors.RussianTextProcessor.PrepareNounCheckString | ( | string | *noun* | ) |  |

[◆](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_processors_1_1_russian_text_processor.html#aa1e8777f034f95347033b105f213d986)PrepareAdjectiveCheckString()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| string TaleWorlds.Localization.TextProcessor.LanguageProcessors.RussianTextProcessor.PrepareAdjectiveCheckString | ( | string | *adj* | ) |  |

[◆](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_processors_1_1_russian_text_processor.html#acd839af058281639b9f8c4b836cd04e7)GetProcessedNouns()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | string[] TaleWorlds.Localization.TextProcessor.LanguageProcessors.RussianTextProcessor.GetProcessedNouns | ( | string | *str*, | |  |  | string | *gender*, | |  |  | string[] | *tokens* = null ) | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_processors_1_1_russian_text_processor.html#af22999151cd0f73ccc160eda62232a48)CultureInfoForLanguage
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override CultureInfo TaleWorlds.Localization.TextProcessor.LanguageProcessors.RussianTextProcessor.CultureInfoForLanguage | | get |

