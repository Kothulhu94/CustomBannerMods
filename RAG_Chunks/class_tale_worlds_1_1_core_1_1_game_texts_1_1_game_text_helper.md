--- SOURCE: class_tale_worlds_1_1_core_1_1_game_texts_1_1_game_text_helper.html ---

TaleWorlds.Core.GameTexts.GameTextHelper Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [GameTextHelper](class_tale_worlds_1_1_core_1_1_game_texts_1_1_game_text_helper.html#a34b81b2346d722af483a7ca7be987857) (string id) |
| [GameTextHelper](class_tale_worlds_1_1_core_1_1_game_texts_1_1_game_text_helper.html#a34b81b2346d722af483a7ca7be987857) | [Variation](class_tale_worlds_1_1_core_1_1_game_texts_1_1_game_text_helper.html#ac24491903c51b3579f93d0340f1a6425) (string text, params object[] propertiesAndWeights) |
|  | Add a variation for a dialog flow line. |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [MergeTextObjectsWithComma](class_tale_worlds_1_1_core_1_1_game_texts_1_1_game_text_helper.html#a8040b7940d88345e74a32d956ab71625) (List< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > textObjects, bool includeAnd) |
| static [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [MergeTextObjectsWithSymbol](class_tale_worlds_1_1_core_1_1_game_texts_1_1_game_text_helper.html#ab3286b9a7d59962d4d0cf4b48ed2bbb7) (List< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > textObjects, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) symbol, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) lastSymbol=null) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_core_1_1_game_texts_1_1_game_text_helper.html#a34b81b2346d722af483a7ca7be987857)GameTextHelper()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Core.GameTexts.GameTextHelper.GameTextHelper | ( | string | *id* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_game_texts_1_1_game_text_helper.html#ac24491903c51b3579f93d0340f1a6425)Variation()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [GameTextHelper](class_tale_worlds_1_1_core_1_1_game_texts_1_1_game_text_helper.html#a34b81b2346d722af483a7ca7be987857) TaleWorlds.Core.GameTexts.GameTextHelper.Variation | ( | string | *text*, |
|  |  | params object[] | *propertiesAndWeights* ) |

///

Parameters
:   |  |  |
    | --- | --- |
    | text | Variation text. |

///

Parameters
:   |  |  |
    | --- | --- |
    | propertiesAndWeights | Property and weight sequence for multiple entries. |

[◆](class_tale_worlds_1_1_core_1_1_game_texts_1_1_game_text_helper.html#a8040b7940d88345e74a32d956ab71625)MergeTextObjectsWithComma()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.Core.GameTexts.GameTextHelper.MergeTextObjectsWithComma | ( | List< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > | *textObjects*, | |  |  | bool | *includeAnd* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_game_texts_1_1_game_text_helper.html#ab3286b9a7d59962d4d0cf4b48ed2bbb7)MergeTextObjectsWithSymbol()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.Core.GameTexts.GameTextHelper.MergeTextObjectsWithSymbol | ( | List< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > | *textObjects*, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *symbol*, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *lastSymbol* = null ) | | static |

