--- SOURCE: class_helpers_1_1_character_helper.html ---

Helpers.CharacterHelper Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetDeathNotification](class_helpers_1_1_character_helper.html#ab6338eb93b45888aedaa68fac83f86ed) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) victimHero, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) killer, [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) detail) |
| static [DynamicBodyProperties](struct_tale_worlds_1_1_core_1_1_dynamic_body_properties.html) | [GetDynamicBodyPropertiesBetweenMinMaxRange](class_helpers_1_1_character_helper.html#a846c06b7442191080899b5926ff4d6e9) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| static [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetReputationDescription](class_helpers_1_1_character_helper.html#a67c94598219558438880906dfaa884c0) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| static uint uint color2 | [GetDeterministicColorsForCharacter](class_helpers_1_1_character_helper.html#abf0250ddb91c5341d005ee58ebd7afb2) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| static [IFaceGeneratorCustomFilter](interface_tale_worlds_1_1_core_1_1_i_face_generator_custom_filter.html) | [GetFaceGeneratorFilter](class_helpers_1_1_character_helper.html#aed67371c4cb562d4760fd3feb3dd7e0f) () |
| static string | [GetNonconversationPose](class_helpers_1_1_character_helper.html#a3c60fe909b88634334ed23079a17a7fe) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| static string | [GetNonconversationFacialIdle](class_helpers_1_1_character_helper.html#aff84a39f85d332ab013c6ff8ed6f5846) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| static string | [GetStandingBodyIdle](class_helpers_1_1_character_helper.html#a2572183ee09b1132268e66684363056b) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| static string | [GetDefaultFaceIdle](class_helpers_1_1_character_helper.html#a3fa231d7d5ec02b6d71d35a71c9d454a) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| static [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [FindUpgradeRootOf](class_helpers_1_1_character_helper.html#accdb8ef82368b6224891571c267a55c6) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| static [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | [GetDefaultWeapon](class_helpers_1_1_character_helper.html#a5771d6b7ce588005ccfb04bf2a38507e) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) affectorCharacter) |
| static bool | [CanUseItemBasedOnSkill](class_helpers_1_1_character_helper.html#a67013a2bb9d5a6b216a375403abc76ac) ([BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) currentCharacter, [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) itemRosterElement) |
| static int | [GetPartyMemberFaceSeed](class_helpers_1_1_character_helper.html#ac43dc8c7f53d96c29e69a72b5ebf8f47) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) character, int rank) |
| static int | [GetDefaultFaceSeed](class_helpers_1_1_character_helper.html#a2d07c1163b640d20050e86f03dd511ce) ([BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) character, int rank) |
| static bool | [SearchForFormationInTroopTree](class_helpers_1_1_character_helper.html#a117ccfcaffc97f2d607e3a9d9b0bac23) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) baseTroop, [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) formation) |
| static IEnumerable< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > | [GetTroopTree](class_helpers_1_1_character_helper.html#ae6c2811cfcf4aea22157365e8aafce94) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) baseTroop, float minTier=-1, float maxTier=float.MaxValue) |
| static void | [DeleteQuestCharacter](class_helpers_1_1_character_helper.html#ac5620718d8fc02267ac8c94eb86ef532) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) questSettlement) |
| static [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [GetRandomCompanionTemplateWithPredicate](class_helpers_1_1_character_helper.html#a9590941bd704faf5b1cc118908e82015) (Func< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), bool > predicate=null) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static uint | [color1](class_helpers_1_1_character_helper.html#a435e96b35ab251fa7220f4c8cf476c69) |

Member Function Documentation
-----------------------------

[◆](class_helpers_1_1_character_helper.html#ab6338eb93b45888aedaa68fac83f86ed)GetDeathNotification()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) Helpers.CharacterHelper.GetDeathNotification | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *victimHero*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *killer*, | |  |  | [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) | *detail* ) | | static |

[◆](class_helpers_1_1_character_helper.html#a846c06b7442191080899b5926ff4d6e9)GetDynamicBodyPropertiesBetweenMinMaxRange()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [DynamicBodyProperties](struct_tale_worlds_1_1_core_1_1_dynamic_body_properties.html) Helpers.CharacterHelper.GetDynamicBodyPropertiesBetweenMinMaxRange | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character* | ) |  | | static |

[◆](class_helpers_1_1_character_helper.html#a67c94598219558438880906dfaa884c0)GetReputationDescription()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) Helpers.CharacterHelper.GetReputationDescription | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character* | ) |  | | static |

[◆](class_helpers_1_1_character_helper.html#abf0250ddb91c5341d005ee58ebd7afb2)GetDeterministicColorsForCharacter()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | uint uint color2 Helpers.CharacterHelper.GetDeterministicColorsForCharacter | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character* | ) |  | | static |

[◆](class_helpers_1_1_character_helper.html#aed67371c4cb562d4760fd3feb3dd7e0f)GetFaceGeneratorFilter()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [IFaceGeneratorCustomFilter](interface_tale_worlds_1_1_core_1_1_i_face_generator_custom_filter.html) Helpers.CharacterHelper.GetFaceGeneratorFilter | ( |  | ) |  | | static |

[◆](class_helpers_1_1_character_helper.html#a3c60fe909b88634334ed23079a17a7fe)GetNonconversationPose()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string Helpers.CharacterHelper.GetNonconversationPose | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character* | ) |  | | static |

[◆](class_helpers_1_1_character_helper.html#aff84a39f85d332ab013c6ff8ed6f5846)GetNonconversationFacialIdle()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string Helpers.CharacterHelper.GetNonconversationFacialIdle | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character* | ) |  | | static |

[◆](class_helpers_1_1_character_helper.html#a2572183ee09b1132268e66684363056b)GetStandingBodyIdle()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | string Helpers.CharacterHelper.GetStandingBodyIdle | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* ) | | static |

[◆](class_helpers_1_1_character_helper.html#a3fa231d7d5ec02b6d71d35a71c9d454a)GetDefaultFaceIdle()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string Helpers.CharacterHelper.GetDefaultFaceIdle | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character* | ) |  | | static |

[◆](class_helpers_1_1_character_helper.html#accdb8ef82368b6224891571c267a55c6)FindUpgradeRootOf()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) Helpers.CharacterHelper.FindUpgradeRootOf | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character* | ) |  | | static |

[◆](class_helpers_1_1_character_helper.html#a5771d6b7ce588005ccfb04bf2a38507e)GetDefaultWeapon()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) Helpers.CharacterHelper.GetDefaultWeapon | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *affectorCharacter* | ) |  | | static |

[◆](class_helpers_1_1_character_helper.html#a67013a2bb9d5a6b216a375403abc76ac)CanUseItemBasedOnSkill()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool Helpers.CharacterHelper.CanUseItemBasedOnSkill | ( | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *currentCharacter*, | |  |  | [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) | *itemRosterElement* ) | | static |

[◆](class_helpers_1_1_character_helper.html#ac43dc8c7f53d96c29e69a72b5ebf8f47)GetPartyMemberFaceSeed()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int Helpers.CharacterHelper.GetPartyMemberFaceSeed | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, | |  |  | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *character*, | |  |  | int | *rank* ) | | static |

[◆](class_helpers_1_1_character_helper.html#a2d07c1163b640d20050e86f03dd511ce)GetDefaultFaceSeed()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int Helpers.CharacterHelper.GetDefaultFaceSeed | ( | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *character*, | |  |  | int | *rank* ) | | static |

[◆](class_helpers_1_1_character_helper.html#a117ccfcaffc97f2d607e3a9d9b0bac23)SearchForFormationInTroopTree()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool Helpers.CharacterHelper.SearchForFormationInTroopTree | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *baseTroop*, | |  |  | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | *formation* ) | | static |

[◆](class_helpers_1_1_character_helper.html#ae6c2811cfcf4aea22157365e8aafce94)GetTroopTree()
--------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IEnumerable< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > Helpers.CharacterHelper.GetTroopTree | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *baseTroop*, | |  |  | float | *minTier* = -1, | |  |  | float | *maxTier* = float::MaxValue ) | | static |

[◆](class_helpers_1_1_character_helper.html#ac5620718d8fc02267ac8c94eb86ef532)DeleteQuestCharacter()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.CharacterHelper.DeleteQuestCharacter | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *questSettlement* ) | | static |

[◆](class_helpers_1_1_character_helper.html#a9590941bd704faf5b1cc118908e82015)GetRandomCompanionTemplateWithPredicate()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) Helpers.CharacterHelper.GetRandomCompanionTemplateWithPredicate | ( | Func< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), bool > | *predicate* = null | ) |  | | static |

Member Data Documentation
-------------------------

[◆](class_helpers_1_1_character_helper.html#a435e96b35ab251fa7220f4c8cf476c69)color1
------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint Helpers.CharacterHelper.color1 | | static |

