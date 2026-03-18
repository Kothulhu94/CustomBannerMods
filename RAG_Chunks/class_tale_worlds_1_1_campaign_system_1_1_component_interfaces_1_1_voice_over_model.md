--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_voice_over_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.VoiceOverModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [StoryMode.GameComponents.StoryModeVoiceOverModel](class_story_mode_1_1_game_components_1_1_story_mode_voice_over_model.html), and [TaleWorlds.CampaignSystem.GameComponents.DefaultVoiceOverModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_voice_over_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| string | [GetSoundPathForCharacter](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_voice_over_model.html#a9ae0ed751a45abc136733415db96e187) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, [VoiceObject](class_tale_worlds_1_1_localization_1_1_voice_object.html) voiceObject) |
| string | [GetAccentClass](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_voice_over_model.html#a3dbd261b627dc74ea1e717b8f1630579) ([CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) culture, bool isHighClass) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_voice_over_model.html#a9ae0ed751a45abc136733415db96e187)GetSoundPathForCharacter()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | string TaleWorlds.CampaignSystem.ComponentInterfaces.VoiceOverModel.GetSoundPathForCharacter | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, | |  |  | [VoiceObject](class_tale_worlds_1_1_localization_1_1_voice_object.html) | *voiceObject* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_voice_over_model.html#a3dbd261b627dc74ea1e717b8f1630579)GetAccentClass()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | string TaleWorlds.CampaignSystem.ComponentInterfaces.VoiceOverModel.GetAccentClass | ( | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | *culture*, | |  |  | bool | *isHighClass* ) | | abstract |

