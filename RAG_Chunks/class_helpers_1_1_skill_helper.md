--- SOURCE: class_helpers_1_1_skill_helper.html ---

Helpers.SkillHelper Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [AddSkillBonusForSkillLevel](class_helpers_1_1_skill_helper.html#a42a261b2b349375096352e9301f8e65d) ([SkillEffect](class_tale_worlds_1_1_campaign_system_1_1_skill_effect.html) skillEffect, ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) explainedNumber, int skillLevel) |
| static void | [AddSkillBonusForParty](class_helpers_1_1_skill_helper.html#a8df64c6c9d0f79692e3ebad66bf64aba) ([SkillEffect](class_tale_worlds_1_1_campaign_system_1_1_skill_effect.html) skillEffect, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) explainedNumber) |
| static void | [AddSkillBonusForTown](class_helpers_1_1_skill_helper.html#afe31bd42f78474499a949e49740db3f7) ([SkillEffect](class_tale_worlds_1_1_campaign_system_1_1_skill_effect.html) skillEffect, [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) explainedNumber) |
| static void | [AddSkillBonusForCharacter](class_helpers_1_1_skill_helper.html#a50cd8329e430865b0cabfade513d2924) ([SkillEffect](class_tale_worlds_1_1_campaign_system_1_1_skill_effect.html) skillEffect, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) explainedNumber) |
| static [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetEffectDescriptionForSkillLevel](class_helpers_1_1_skill_helper.html#a00b990cc09af43071b96872e0ec1d291) ([SkillEffect](class_tale_worlds_1_1_campaign_system_1_1_skill_effect.html) effect, int level) |
| static [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [GetEffectivePartyLeaderForSkill](class_helpers_1_1_skill_helper.html#a962f2ae66745f4b7ac21dcd3f563184a) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |

Member Function Documentation
-----------------------------

[◆](class_helpers_1_1_skill_helper.html#a42a261b2b349375096352e9301f8e65d)AddSkillBonusForSkillLevel()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.SkillHelper.AddSkillBonusForSkillLevel | ( | [SkillEffect](class_tale_worlds_1_1_campaign_system_1_1_skill_effect.html) | *skillEffect*, | |  |  | ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | *explainedNumber*, | |  |  | int | *skillLevel* ) | | static |

[◆](class_helpers_1_1_skill_helper.html#a8df64c6c9d0f79692e3ebad66bf64aba)AddSkillBonusForParty()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.SkillHelper.AddSkillBonusForParty | ( | [SkillEffect](class_tale_worlds_1_1_campaign_system_1_1_skill_effect.html) | *skillEffect*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | *explainedNumber* ) | | static |

[◆](class_helpers_1_1_skill_helper.html#afe31bd42f78474499a949e49740db3f7)AddSkillBonusForTown()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.SkillHelper.AddSkillBonusForTown | ( | [SkillEffect](class_tale_worlds_1_1_campaign_system_1_1_skill_effect.html) | *skillEffect*, | |  |  | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | *explainedNumber* ) | | static |

[◆](class_helpers_1_1_skill_helper.html#a50cd8329e430865b0cabfade513d2924)AddSkillBonusForCharacter()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.SkillHelper.AddSkillBonusForCharacter | ( | [SkillEffect](class_tale_worlds_1_1_campaign_system_1_1_skill_effect.html) | *skillEffect*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, | |  |  | ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | *explainedNumber* ) | | static |

[◆](class_helpers_1_1_skill_helper.html#a00b990cc09af43071b96872e0ec1d291)GetEffectDescriptionForSkillLevel()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) Helpers.SkillHelper.GetEffectDescriptionForSkillLevel | ( | [SkillEffect](class_tale_worlds_1_1_campaign_system_1_1_skill_effect.html) | *effect*, | |  |  | int | *level* ) | | static |

[◆](class_helpers_1_1_skill_helper.html#a962f2ae66745f4b7ac21dcd3f563184a)GetEffectivePartyLeaderForSkill()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) Helpers.SkillHelper.GetEffectivePartyLeaderForSkill | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  | | static |

