--- SOURCE: class_tale_worlds_1_1_core_1_1_game_text.html ---

TaleWorlds.Core.GameText Class Reference|  |  |
| --- | --- |
| Classes | |
| struct | [GameTextVariation](struct_tale_worlds_1_1_core_1_1_game_text_1_1_game_text_variation.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [AddVariationWithId](class_tale_worlds_1_1_core_1_1_game_text.html#a052d92b4c2d421f9a384bd3b7ce45234) (string variationId, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) text, List< [GameTextManager.ChoiceTag](struct_tale_worlds_1_1_core_1_1_game_text_manager_1_1_choice_tag.html) > choiceTags) |
| void | [SetVariationWithId](class_tale_worlds_1_1_core_1_1_game_text.html#acc184588ea1f1ef51f0591e224dfceb3) (string variationId, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) text, List< [GameTextManager.ChoiceTag](struct_tale_worlds_1_1_core_1_1_game_text_manager_1_1_choice_tag.html) > choiceTags) |
| void | [AddVariation](class_tale_worlds_1_1_core_1_1_game_text.html#a78e2e36573bda22f3250acb4a83c8228) (string text, params object[] propertiesAndWeights) |

|  |  |
| --- | --- |
| Properties | |
| string | [Id](class_tale_worlds_1_1_core_1_1_game_text.html#a0c39d985138cb5ac76de0d864eced1a6) `[get]` |
| IEnumerable< [GameTextVariation](struct_tale_worlds_1_1_core_1_1_game_text_1_1_game_text_variation.html) > | [Variations](class_tale_worlds_1_1_core_1_1_game_text.html#a83dd1c04bcad9af8f1217ce10fecb9ae) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [DefaultText](class_tale_worlds_1_1_core_1_1_game_text.html#ae7e53580bba654768a19f3182f2e5454) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_game_text.html#a052d92b4c2d421f9a384bd3b7ce45234)AddVariationWithId()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.GameText.AddVariationWithId | ( | string | *variationId*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *text*, |
|  |  | List< [GameTextManager.ChoiceTag](struct_tale_worlds_1_1_core_1_1_game_text_manager_1_1_choice_tag.html) > | *choiceTags* ) |

[◆](class_tale_worlds_1_1_core_1_1_game_text.html#acc184588ea1f1ef51f0591e224dfceb3)SetVariationWithId()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.GameText.SetVariationWithId | ( | string | *variationId*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *text*, |
|  |  | List< [GameTextManager.ChoiceTag](struct_tale_worlds_1_1_core_1_1_game_text_manager_1_1_choice_tag.html) > | *choiceTags* ) |

[◆](class_tale_worlds_1_1_core_1_1_game_text.html#a78e2e36573bda22f3250acb4a83c8228)AddVariation()
--------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.GameText.AddVariation | ( | string | *text*, |
|  |  | params object[] | *propertiesAndWeights* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_game_text.html#a0c39d985138cb5ac76de0d864eced1a6)Id
--------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.GameText.Id | | get |

[◆](class_tale_worlds_1_1_core_1_1_game_text.html#a83dd1c04bcad9af8f1217ce10fecb9ae)Variations
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IEnumerable<[GameTextVariation](struct_tale_worlds_1_1_core_1_1_game_text_1_1_game_text_variation.html)> TaleWorlds.Core.GameText.Variations | | get |

[◆](class_tale_worlds_1_1_core_1_1_game_text.html#ae7e53580bba654768a19f3182f2e5454)DefaultText
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.Core.GameText.DefaultText | | get |

