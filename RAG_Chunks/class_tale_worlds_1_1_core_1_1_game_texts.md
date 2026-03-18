--- SOURCE: class_tale_worlds_1_1_core_1_1_game_texts.html ---

TaleWorlds.Core.GameTexts Class Reference|  |  |
| --- | --- |
| Classes | |
| class | [GameTextHelper](class_tale_worlds_1_1_core_1_1_game_texts_1_1_game_text_helper.html) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [Initialize](class_tale_worlds_1_1_core_1_1_game_texts.html#a7ed0e3c4242c32829d847c2b102fd9e9) ([GameTextManager](class_tale_worlds_1_1_core_1_1_game_text_manager.html) gameTextManager) |
| static [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [FindText](class_tale_worlds_1_1_core_1_1_game_texts.html#ace7a16004aee57924856521dd3f177f0) (string id, string variation=null) |
| static bool | [TryGetText](class_tale_worlds_1_1_core_1_1_game_texts.html#abb742f48d545a1f6e619f9c0d0cd839a) (string id, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) textObject, string variation=null) |
| static IEnumerable< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > | [FindAllTextVariations](class_tale_worlds_1_1_core_1_1_game_texts.html#ac96e557919396c41855cc63ded4e07ff) (string id) |
| static void | [SetVariable](class_tale_worlds_1_1_core_1_1_game_texts.html#a2e289a2660fe1c4515caa51b02ccb81d) (string variableName, string content) |
| static void | [SetVariable](class_tale_worlds_1_1_core_1_1_game_texts.html#a7bd7a13058ea9b7cbaf8ab4434db33cd) (string variableName, float content) |
| static void | [SetVariable](class_tale_worlds_1_1_core_1_1_game_texts.html#aefa858174cfd85ccca55007215cde3ad) (string variableName, int content) |
| static void | [SetVariable](class_tale_worlds_1_1_core_1_1_game_texts.html#a2b35a187680d426cf5b39c48b71d900c) (string variableName, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) content) |
| static void | [ClearInstance](class_tale_worlds_1_1_core_1_1_game_texts.html#a6f62eab804bdbfa17a857d8f43c8052f) () |
| static [GameTextHelper](class_tale_worlds_1_1_core_1_1_game_texts_1_1_game_text_helper.html) | [AddGameTextWithVariation](class_tale_worlds_1_1_core_1_1_game_texts.html#adf492f3c06962cfb2cc0f24e04054747) (string id) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_game_texts.html#a7ed0e3c4242c32829d847c2b102fd9e9)Initialize()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Core.GameTexts.Initialize | ( | [GameTextManager](class_tale_worlds_1_1_core_1_1_game_text_manager.html) | *gameTextManager* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_game_texts.html#ace7a16004aee57924856521dd3f177f0)FindText()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.Core.GameTexts.FindText | ( | string | *id*, | |  |  | string | *variation* = null ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_game_texts.html#abb742f48d545a1f6e619f9c0d0cd839a)TryGetText()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Core.GameTexts.TryGetText | ( | string | *id*, | |  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *textObject*, | |  |  | string | *variation* = null ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_game_texts.html#ac96e557919396c41855cc63ded4e07ff)FindAllTextVariations()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IEnumerable< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > TaleWorlds.Core.GameTexts.FindAllTextVariations | ( | string | *id* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_game_texts.html#a2e289a2660fe1c4515caa51b02ccb81d)SetVariable() [1/4]
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Core.GameTexts.SetVariable | ( | string | *variableName*, | |  |  | string | *content* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_game_texts.html#a7bd7a13058ea9b7cbaf8ab4434db33cd)SetVariable() [2/4]
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Core.GameTexts.SetVariable | ( | string | *variableName*, | |  |  | float | *content* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_game_texts.html#aefa858174cfd85ccca55007215cde3ad)SetVariable() [3/4]
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Core.GameTexts.SetVariable | ( | string | *variableName*, | |  |  | int | *content* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_game_texts.html#a2b35a187680d426cf5b39c48b71d900c)SetVariable() [4/4]
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Core.GameTexts.SetVariable | ( | string | *variableName*, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *content* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_game_texts.html#a6f62eab804bdbfa17a857d8f43c8052f)ClearInstance()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Core.GameTexts.ClearInstance | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_game_texts.html#adf492f3c06962cfb2cc0f24e04054747)AddGameTextWithVariation()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [GameTextHelper](class_tale_worlds_1_1_core_1_1_game_texts_1_1_game_text_helper.html) TaleWorlds.Core.GameTexts.AddGameTextWithVariation | ( | string | *id* | ) |  | | static |

