--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_option.html ---

TaleWorlds.CampaignSystem.CharacterCreationContent.NarrativeMenuOption Class Referencesealed|  |  |
| --- | --- |
| Public Member Functions | |
|  | [NarrativeMenuOption](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_option.html#a893eebc4824dc5e1ae362997886d2f63) (string stringId, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) text, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) descriptionText, [GetNarrativeMenuOptionArgsDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_character_creation_content.html#a4a72a8cecb5148fa553a662c76c1c1a3) getNarrativeMenuOptionArgs, [NarrativeMenuOptionOnConditionDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_character_creation_content.html#abc2f25f84e55fdc033b54921092b7417) onCondition, [NarrativeMenuOptionOnSelectDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_character_creation_content.html#a36d7fe5701492dd0729332434afdf5b7) onSelect, [NarrativeMenuOptionOnConsequenceDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_character_creation_content.html#ae099f5f8c3ce4b6c5f92c767e57de8fc) onConsequence) |
| bool | [OnCondition](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_option.html#a73fc2d2a97188c3f553591115fefb837) ([CharacterCreationManager](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html) characterCreationManager) |
| void | [OnSelect](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_option.html#a4542b692190c0b91ad23c3b3aa617166) ([CharacterCreationManager](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html) characterCreationManager) |
| void | [OnConsequence](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_option.html#a9a57059704744c2f5c62901b92d76da4) ([CharacterCreationManager](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html) characterCreationManager) |
| void | [SetOnCondition](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_option.html#adecb7577cccd0b4e1b0b6b72f583c8bc) ([NarrativeMenuOptionOnConditionDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_character_creation_content.html#abc2f25f84e55fdc033b54921092b7417) onCondition) |
| void | [SetOnSelect](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_option.html#a7d9e32c39fa492b48d0d88675409892c) ([NarrativeMenuOptionOnSelectDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_character_creation_content.html#a36d7fe5701492dd0729332434afdf5b7) onSelect) |
| void | [SetOnConsequence](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_option.html#a869343db8527dbac60da71bee0a4ad2b) ([NarrativeMenuOptionOnConsequenceDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_character_creation_content.html#ae099f5f8c3ce4b6c5f92c767e57de8fc) onConsequence) |
| void | [ApplyFinalEffects](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_option.html#a9c898fd0f7c243256fb970326e87075b) ([CharacterCreationContent](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html) characterCreationContent) |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly string | [StringId](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_option.html#ab457a7e22a7efe9fbc885f60cc562bdc) |
| readonly [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Text](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_option.html#a8c710c33e668073021fd401e55d16e74) |
| readonly [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [DescriptionText](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_option.html#a9f9138a3c90d9e9d2865b6b26719d88f) |
| readonly [NarrativeMenuOptionArgs](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_option_args.html) | [Args](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_option.html#abb12ea55142f9fec6973e2643bfe1025) |

|  |  |
| --- | --- |
| Properties | |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [PositiveEffectText](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_option.html#a698ea5385e812ea5a9afea95c8208315) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_option.html#a893eebc4824dc5e1ae362997886d2f63)NarrativeMenuOption()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.CharacterCreationContent.NarrativeMenuOption.NarrativeMenuOption | ( | string | *stringId*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *text*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *descriptionText*, |
|  |  | [GetNarrativeMenuOptionArgsDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_character_creation_content.html#a4a72a8cecb5148fa553a662c76c1c1a3) | *getNarrativeMenuOptionArgs*, |
|  |  | [NarrativeMenuOptionOnConditionDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_character_creation_content.html#abc2f25f84e55fdc033b54921092b7417) | *onCondition*, |
|  |  | [NarrativeMenuOptionOnSelectDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_character_creation_content.html#a36d7fe5701492dd0729332434afdf5b7) | *onSelect*, |
|  |  | [NarrativeMenuOptionOnConsequenceDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_character_creation_content.html#ae099f5f8c3ce4b6c5f92c767e57de8fc) | *onConsequence* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_option.html#a73fc2d2a97188c3f553591115fefb837)OnCondition()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CharacterCreationContent.NarrativeMenuOption.OnCondition | ( | [CharacterCreationManager](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html) | *characterCreationManager* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_option.html#a4542b692190c0b91ad23c3b3aa617166)OnSelect()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterCreationContent.NarrativeMenuOption.OnSelect | ( | [CharacterCreationManager](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html) | *characterCreationManager* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_option.html#a9a57059704744c2f5c62901b92d76da4)OnConsequence()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterCreationContent.NarrativeMenuOption.OnConsequence | ( | [CharacterCreationManager](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html) | *characterCreationManager* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_option.html#adecb7577cccd0b4e1b0b6b72f583c8bc)SetOnCondition()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterCreationContent.NarrativeMenuOption.SetOnCondition | ( | [NarrativeMenuOptionOnConditionDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_character_creation_content.html#abc2f25f84e55fdc033b54921092b7417) | *onCondition* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_option.html#a7d9e32c39fa492b48d0d88675409892c)SetOnSelect()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterCreationContent.NarrativeMenuOption.SetOnSelect | ( | [NarrativeMenuOptionOnSelectDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_character_creation_content.html#a36d7fe5701492dd0729332434afdf5b7) | *onSelect* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_option.html#a869343db8527dbac60da71bee0a4ad2b)SetOnConsequence()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterCreationContent.NarrativeMenuOption.SetOnConsequence | ( | [NarrativeMenuOptionOnConsequenceDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_character_creation_content.html#ae099f5f8c3ce4b6c5f92c767e57de8fc) | *onConsequence* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_option.html#a9c898fd0f7c243256fb970326e87075b)ApplyFinalEffects()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterCreationContent.NarrativeMenuOption.ApplyFinalEffects | ( | [CharacterCreationContent](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html) | *characterCreationContent* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_option.html#ab457a7e22a7efe9fbc885f60cc562bdc)StringId
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly string TaleWorlds.CampaignSystem.CharacterCreationContent.NarrativeMenuOption.StringId |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_option.html#a8c710c33e668073021fd401e55d16e74)Text
----------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.CharacterCreationContent.NarrativeMenuOption.Text |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_option.html#a9f9138a3c90d9e9d2865b6b26719d88f)DescriptionText
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.CharacterCreationContent.NarrativeMenuOption.DescriptionText |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_option.html#abb12ea55142f9fec6973e2643bfe1025)Args
----------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [NarrativeMenuOptionArgs](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_option_args.html) TaleWorlds.CampaignSystem.CharacterCreationContent.NarrativeMenuOption.Args |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_option.html#a698ea5385e812ea5a9afea95c8208315)PositiveEffectText
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.CharacterCreationContent.NarrativeMenuOption.PositiveEffectText | | get |

