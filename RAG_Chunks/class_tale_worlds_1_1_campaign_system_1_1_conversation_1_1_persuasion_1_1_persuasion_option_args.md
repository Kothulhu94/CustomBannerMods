--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html ---

TaleWorlds.CampaignSystem.Conversation.Persuasion.PersuasionOptionArgs Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [PersuasionOptionArgs](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html#ada079540522adf9a4fda3a03233ba562) ([SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill, [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html) trait, [TraitEffect](namespace_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion.html#ab51476f26b9eb5846cbb436d9aef08ac) traitEffect, [PersuasionArgumentStrength](namespace_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion.html#aa3e0a107d9ed27b893b0b17fcc7e86b5) argumentStrength, bool givesCriticalSuccess, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) line, Tuple< [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html), int >[] traitCorrelation=null, bool canBlockOtherOption=false, bool canMoveToTheNextReservation=false, bool isInitiallyBlocked=false) |
| void | [BlockTheOption](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html#a1c6da936607e5ec5ec9a14e7a00e4805) (bool isBlocked) |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly [PersuasionArgumentStrength](namespace_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion.html#aa3e0a107d9ed27b893b0b17fcc7e86b5) | [ArgumentStrength](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html#acef9e5987a4d984b47d19cc83500de51) |
| readonly [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | [SkillUsed](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html#a18cbe53bbe151b31cbcea78ee60053d0) |
| readonly [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html) | [TraitUsed](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html#aa7d12df3e19507e8dd20fae101803ad7) |
| readonly Tuple< [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html), int >[] | [TraitCorrelation](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html#a53120a20308c573122cdda032308771a) |
| readonly [TraitEffect](namespace_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion.html#ab51476f26b9eb5846cbb436d9aef08ac) | [TraitEffect](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html#a01aff95fc01e5ba64bfa61571f04eeac) |
| readonly bool | [CanBlockOtherOption](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html#af713b764a8e9a7e91952a8f3891b5059) |
| readonly bool | [CanMoveToTheNextReservation](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html#a1e579c4017f774c70f67b813702a672d) |
| readonly bool | [GivesCriticalSuccess](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html#a72a77c1072edfacab55b3e4e6d0e2a12) |
| readonly [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Line](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html#aef35a30c153b524bc53d13580d415386) |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsBlocked](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html#aa91460b34589f71eaabd10d2f166dbd9) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html#ada079540522adf9a4fda3a03233ba562)PersuasionOptionArgs()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Conversation.Persuasion.PersuasionOptionArgs.PersuasionOptionArgs | ( | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill*, |
|  |  | [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html) | *trait*, |
|  |  | [TraitEffect](namespace_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion.html#ab51476f26b9eb5846cbb436d9aef08ac) | *traitEffect*, |
|  |  | [PersuasionArgumentStrength](namespace_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion.html#aa3e0a107d9ed27b893b0b17fcc7e86b5) | *argumentStrength*, |
|  |  | bool | *givesCriticalSuccess*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *line*, |
|  |  | Tuple< [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html), int >[] | *traitCorrelation* = null, |
|  |  | bool | *canBlockOtherOption* = false, |
|  |  | bool | *canMoveToTheNextReservation* = false, |
|  |  | bool | *isInitiallyBlocked* = false ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html#a1c6da936607e5ec5ec9a14e7a00e4805)BlockTheOption()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Conversation.Persuasion.PersuasionOptionArgs.BlockTheOption | ( | bool | *isBlocked* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html#acef9e5987a4d984b47d19cc83500de51)ArgumentStrength
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [PersuasionArgumentStrength](namespace_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion.html#aa3e0a107d9ed27b893b0b17fcc7e86b5) TaleWorlds.CampaignSystem.Conversation.Persuasion.PersuasionOptionArgs.ArgumentStrength |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html#a18cbe53bbe151b31cbcea78ee60053d0)SkillUsed
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) TaleWorlds.CampaignSystem.Conversation.Persuasion.PersuasionOptionArgs.SkillUsed |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html#aa7d12df3e19507e8dd20fae101803ad7)TraitUsed
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html) TaleWorlds.CampaignSystem.Conversation.Persuasion.PersuasionOptionArgs.TraitUsed |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html#a53120a20308c573122cdda032308771a)TraitCorrelation
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly Tuple<[TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html), int> [] TaleWorlds.CampaignSystem.Conversation.Persuasion.PersuasionOptionArgs.TraitCorrelation |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html#a01aff95fc01e5ba64bfa61571f04eeac)TraitEffect
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [TraitEffect](namespace_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion.html#ab51476f26b9eb5846cbb436d9aef08ac) TaleWorlds.CampaignSystem.Conversation.Persuasion.PersuasionOptionArgs.TraitEffect |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html#af713b764a8e9a7e91952a8f3891b5059)CanBlockOtherOption
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly bool TaleWorlds.CampaignSystem.Conversation.Persuasion.PersuasionOptionArgs.CanBlockOtherOption |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html#a1e579c4017f774c70f67b813702a672d)CanMoveToTheNextReservation
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly bool TaleWorlds.CampaignSystem.Conversation.Persuasion.PersuasionOptionArgs.CanMoveToTheNextReservation |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html#a72a77c1072edfacab55b3e4e6d0e2a12)GivesCriticalSuccess
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly bool TaleWorlds.CampaignSystem.Conversation.Persuasion.PersuasionOptionArgs.GivesCriticalSuccess |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html#aef35a30c153b524bc53d13580d415386)Line
------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Conversation.Persuasion.PersuasionOptionArgs.Line |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html#aa91460b34589f71eaabd10d2f166dbd9)IsBlocked
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Conversation.Persuasion.PersuasionOptionArgs.IsBlocked | | get |

