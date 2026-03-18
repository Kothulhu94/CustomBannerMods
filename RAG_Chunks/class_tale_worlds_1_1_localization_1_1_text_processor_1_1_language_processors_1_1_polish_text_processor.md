--- SOURCE: class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_processors_1_1_polish_text_processor.html ---

TaleWorlds.Localization.TextProcessor.LanguageProcessors.PolishTextProcessor Class ReferenceInherits [TaleWorlds.Localization.TextProcessor.LanguageSpecificTextProcessor](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_specific_text_processor.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [ClearTemporaryData](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_processors_1_1_polish_text_processor.html#a7cd288163351b34dfabe83fc3cd4d4f2) () |
| override void | [ProcessToken](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_processors_1_1_polish_text_processor.html#a5643bfec12413820170e4d098a3ae104) (string sourceText, ref int cursorPos, string token, StringBuilder outputString) |
| Public Member Functions inherited from [TaleWorlds.Localization.TextProcessor.LanguageSpecificTextProcessor](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_specific_text_processor.html) | |
| void | [ProcessToken](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_specific_text_processor.html#ace9e33be9ff73dd2c6152826158a7d75) (string sourceText, ref int cursorPos, string token, StringBuilder outputString) |
| void | [ClearTemporaryData](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_specific_text_processor.html#a60fe046b769e4b855e44ec8bdad781ed) () |
|  | [LanguageSpecificTextProcessor](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_specific_text_processor.html#a368e90e4d154b71135c2d3b41f6d5ecf) () |
| string | [Process](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_specific_text_processor.html#a4bb15179944170b1494ef54540574b2b) (string text) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static string[] | [GetProcessedNouns](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_processors_1_1_polish_text_processor.html#a3451ab9b941df1023a4031bc00aca216) (string str, string gender, string[] tokens=null) |
| static string[] | [GetProcessedAdjectives](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_processors_1_1_polish_text_processor.html#aa5ba46e7e2360e2473e9b29c9584371f) (string str, string gender, string[] tokens=null) |

|  |  |
| --- | --- |
| Properties | |
| override CultureInfo | [CultureInfoForLanguage](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_processors_1_1_polish_text_processor.html#a7f809a8928ee211468d040300acdaa7d) `[get]` |
| Properties inherited from [TaleWorlds.Localization.TextProcessor.LanguageSpecificTextProcessor](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_specific_text_processor.html) | |
| CultureInfo | [CultureInfoForLanguage](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_specific_text_processor.html#a7ce9889ca2b1b6e5d771457a7e1f0383) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_processors_1_1_polish_text_processor.html#a7cd288163351b34dfabe83fc3cd4d4f2)ClearTemporaryData()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.Localization.TextProcessor.LanguageProcessors.PolishTextProcessor.ClearTemporaryData | ( |  | ) |  |

[◆](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_processors_1_1_polish_text_processor.html#a5643bfec12413820170e4d098a3ae104)ProcessToken()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.Localization.TextProcessor.LanguageProcessors.PolishTextProcessor.ProcessToken | ( | string | *sourceText*, |
|  |  | ref int | *cursorPos*, |
|  |  | string | *token*, |
|  |  | StringBuilder | *outputString* ) |

[◆](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_processors_1_1_polish_text_processor.html#a3451ab9b941df1023a4031bc00aca216)GetProcessedNouns()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | string[] TaleWorlds.Localization.TextProcessor.LanguageProcessors.PolishTextProcessor.GetProcessedNouns | ( | string | *str*, | |  |  | string | *gender*, | |  |  | string[] | *tokens* = null ) | | static |

[◆](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_processors_1_1_polish_text_processor.html#aa5ba46e7e2360e2473e9b29c9584371f)GetProcessedAdjectives()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | string[] TaleWorlds.Localization.TextProcessor.LanguageProcessors.PolishTextProcessor.GetProcessedAdjectives | ( | string | *str*, | |  |  | string | *gender*, | |  |  | string[] | *tokens* = null ) | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_localization_1_1_text_processor_1_1_language_processors_1_1_polish_text_processor.html#a7f809a8928ee211468d040300acdaa7d)CultureInfoForLanguage
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override CultureInfo TaleWorlds.Localization.TextProcessor.LanguageProcessors.PolishTextProcessor.CultureInfoForLanguage | | get |

