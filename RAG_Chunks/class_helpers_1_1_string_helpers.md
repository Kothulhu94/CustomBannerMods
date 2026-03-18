--- SOURCE: class_helpers_1_1_string_helpers.html ---

Helpers.StringHelpers Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static string | [SplitCamelCase](class_helpers_1_1_string_helpers.html#a0342b18ae13f5e0c34672ce192d4fdfb) (string text) |
| static string | [CamelCaseToSnakeCase](class_helpers_1_1_string_helpers.html#ae4517dae096198604f9710d34dfd3ddb) (string camelCaseString) |
|  | Converts CamelCase string to snake\_case. |
| static void | [SetSettlementProperties](class_helpers_1_1_string_helpers.html#a76097f87dd747bd664bbbcb0d0285fe9) (string tag, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) parent=null, bool isRepeatable=false) |
| static void | [SetRepeatableCharacterProperties](class_helpers_1_1_string_helpers.html#a7f2ab4bd7d962f7fcab5dfa0f36467d8) (string tag, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, bool includeDetails=false) |
| static [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [SetCharacterProperties](class_helpers_1_1_string_helpers.html#a5edd715535ce283ee469fefa377f54d3) (string tag, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) parent=null, bool includeDetails=false) |
| static void | [SetEffectIncrementTypeTextVariable](class_helpers_1_1_string_helpers.html#a3b8ae6b9b49de90b32eff11519d19ca5) (string tag, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) description, float bonus, [EffectIncrementType](namespace_tale_worlds_1_1_core.html#a75c4a0450b5435c513e0e23882d2b92f) effectIncrementType) |
| static string | [RemoveDiacritics](class_helpers_1_1_string_helpers.html#a57250ef58b69b82f5968f9ac3b468e0c) (string originalText) |

Member Function Documentation
-----------------------------

[◆](class_helpers_1_1_string_helpers.html#a0342b18ae13f5e0c34672ce192d4fdfb)SplitCamelCase()
--------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string Helpers.StringHelpers.SplitCamelCase | ( | string | *text* | ) |  | | static |

[◆](class_helpers_1_1_string_helpers.html#ae4517dae096198604f9710d34dfd3ddb)CamelCaseToSnakeCase()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string Helpers.StringHelpers.CamelCaseToSnakeCase | ( | string | *camelCaseString* | ) |  | | static |

Parameters
:   |  |  |
    | --- | --- |
    | camelCaseString |  |

Returns

[◆](class_helpers_1_1_string_helpers.html#a76097f87dd747bd664bbbcb0d0285fe9)SetSettlementProperties()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.StringHelpers.SetSettlementProperties | ( | string | *tag*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *parent* = null, | |  |  | bool | *isRepeatable* = false ) | | static |

[◆](class_helpers_1_1_string_helpers.html#a7f2ab4bd7d962f7fcab5dfa0f36467d8)SetRepeatableCharacterProperties()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.StringHelpers.SetRepeatableCharacterProperties | ( | string | *tag*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, | |  |  | bool | *includeDetails* = false ) | | static |

[◆](class_helpers_1_1_string_helpers.html#a5edd715535ce283ee469fefa377f54d3)SetCharacterProperties()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) Helpers.StringHelpers.SetCharacterProperties | ( | string | *tag*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *parent* = null, | |  |  | bool | *includeDetails* = false ) | | static |

[◆](class_helpers_1_1_string_helpers.html#a3b8ae6b9b49de90b32eff11519d19ca5)SetEffectIncrementTypeTextVariable()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.StringHelpers.SetEffectIncrementTypeTextVariable | ( | string | *tag*, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *description*, | |  |  | float | *bonus*, | |  |  | [EffectIncrementType](namespace_tale_worlds_1_1_core.html#a75c4a0450b5435c513e0e23882d2b92f) | *effectIncrementType* ) | | static |

[◆](class_helpers_1_1_string_helpers.html#a57250ef58b69b82f5968f9ac3b468e0c)RemoveDiacritics()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string Helpers.StringHelpers.RemoveDiacritics | ( | string | *originalText* | ) |  | | static |

