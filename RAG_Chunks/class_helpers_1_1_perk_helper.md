--- SOURCE: class_helpers_1_1_perk_helper.html ---

Helpers.PerkHelper Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static IEnumerable< [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) > | [GetCaptainPerksForTroopUsages](class_helpers_1_1_perk_helper.html#afac49002d493aa619811bd71ded3a77a) ([TroopUsageFlags](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872ab) troopUsageFlags) |
| static bool | [PlayerHasAnyItemDonationPerk](class_helpers_1_1_perk_helper.html#aa06f5256202b628dfe698540c268fe97) () |
| static void | [AddPerkBonusForParty](class_helpers_1_1_perk_helper.html#aa863f5a733cd35a175283d864a4d95d2) ([PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) perk, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, bool isPrimaryBonus, ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) stat, bool shouldApplyNavalMultiplier=false) |
| static void | [AddPerkBonusForCharacter](class_helpers_1_1_perk_helper.html#a87bdf07fe4c8c4159efcbf2e73bf4864) ([PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) perk, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, bool isPrimaryBonus, ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) bonuses, bool shouldApplyNavalMultiplier=false) |
| static void | [AddEpicPerkBonusForCharacter](class_helpers_1_1_perk_helper.html#ae63f004fff0f802a876f1201ae2aab1a) ([PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) perk, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skillType, bool applyPrimaryBonus, ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) bonuses, int skillRequired, bool shouldApplyNavalMultiplier=false) |
| static void | [AddPerkBonusFromCaptain](class_helpers_1_1_perk_helper.html#a93d758079976c5c26a91127d6dc135e9) ([PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) perk, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) captainCharacter, ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) bonuses) |
| static void | [AddPerkBonusForTown](class_helpers_1_1_perk_helper.html#a51fc76b27b537cb65d5876a55363f114) ([PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) perk, [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) bonuses) |
| static bool | [GetPerkValueForTown](class_helpers_1_1_perk_helper.html#acb814790c1a6d8fcc3faf57f2429db60) ([PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) perk, [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| static List< [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) > | [GetGovernorPerksForHero](class_helpers_1_1_perk_helper.html#ad6f7a5a2a6d8d023b0b0fc2ee60d9885) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| static [TextObject](class_helpers_1_1_perk_helper.html#aebc9ea05d61fda56aeddc13586ecc194) | [GetGovernorEngineeringSkillEffectForHero](class_helpers_1_1_perk_helper.html#a811231ecdc743666c57bf2d2cbda8749) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) governor) |
| static int | [AvailablePerkCountOfHero](class_helpers_1_1_perk_helper.html#a1a5c0457a18f0f23f4d952b2cb90b23a) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static | [TextObject](class_helpers_1_1_perk_helper.html#aebc9ea05d61fda56aeddc13586ecc194) |
| const float | [NavalMultiplier](class_helpers_1_1_perk_helper.html#a8c1303709500fa735616dc73bfa0e7e1) = 0.5f |

Member Function Documentation
-----------------------------

[◆](class_helpers_1_1_perk_helper.html#afac49002d493aa619811bd71ded3a77a)GetCaptainPerksForTroopUsages()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IEnumerable< [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) > Helpers.PerkHelper.GetCaptainPerksForTroopUsages | ( | [TroopUsageFlags](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872ab) | *troopUsageFlags* | ) |  | | static |

[◆](class_helpers_1_1_perk_helper.html#aa06f5256202b628dfe698540c268fe97)PlayerHasAnyItemDonationPerk()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool Helpers.PerkHelper.PlayerHasAnyItemDonationPerk | ( |  | ) |  | | static |

[◆](class_helpers_1_1_perk_helper.html#aa863f5a733cd35a175283d864a4d95d2)AddPerkBonusForParty()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.PerkHelper.AddPerkBonusForParty | ( | [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) | *perk*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | bool | *isPrimaryBonus*, | |  |  | ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | *stat*, | |  |  | bool | *shouldApplyNavalMultiplier* = false ) | | static |

[◆](class_helpers_1_1_perk_helper.html#a87bdf07fe4c8c4159efcbf2e73bf4864)AddPerkBonusForCharacter()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.PerkHelper.AddPerkBonusForCharacter | ( | [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) | *perk*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, | |  |  | bool | *isPrimaryBonus*, | |  |  | ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | *bonuses*, | |  |  | bool | *shouldApplyNavalMultiplier* = false ) | | static |

[◆](class_helpers_1_1_perk_helper.html#ae63f004fff0f802a876f1201ae2aab1a)AddEpicPerkBonusForCharacter()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.PerkHelper.AddEpicPerkBonusForCharacter | ( | [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) | *perk*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, | |  |  | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skillType*, | |  |  | bool | *applyPrimaryBonus*, | |  |  | ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | *bonuses*, | |  |  | int | *skillRequired*, | |  |  | bool | *shouldApplyNavalMultiplier* = false ) | | static |

[◆](class_helpers_1_1_perk_helper.html#a93d758079976c5c26a91127d6dc135e9)AddPerkBonusFromCaptain()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.PerkHelper.AddPerkBonusFromCaptain | ( | [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) | *perk*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *captainCharacter*, | |  |  | ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | *bonuses* ) | | static |

[◆](class_helpers_1_1_perk_helper.html#a51fc76b27b537cb65d5876a55363f114)AddPerkBonusForTown()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.PerkHelper.AddPerkBonusForTown | ( | [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) | *perk*, | |  |  | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | *bonuses* ) | | static |

[◆](class_helpers_1_1_perk_helper.html#acb814790c1a6d8fcc3faf57f2429db60)GetPerkValueForTown()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool Helpers.PerkHelper.GetPerkValueForTown | ( | [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) | *perk*, | |  |  | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* ) | | static |

[◆](class_helpers_1_1_perk_helper.html#ad6f7a5a2a6d8d023b0b0fc2ee60d9885)GetGovernorPerksForHero()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | List< [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) > Helpers.PerkHelper.GetGovernorPerksForHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | static |

[◆](class_helpers_1_1_perk_helper.html#a811231ecdc743666c57bf2d2cbda8749)GetGovernorEngineeringSkillEffectForHero()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [TextObject](class_helpers_1_1_perk_helper.html#aebc9ea05d61fda56aeddc13586ecc194) Helpers.PerkHelper.GetGovernorEngineeringSkillEffectForHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *governor* | ) |  | | static |

[◆](class_helpers_1_1_perk_helper.html#a1a5c0457a18f0f23f4d952b2cb90b23a)AvailablePerkCountOfHero()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int Helpers.PerkHelper.AvailablePerkCountOfHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | static |

Member Data Documentation
-------------------------

[◆](class_helpers_1_1_perk_helper.html#aebc9ea05d61fda56aeddc13586ecc194)TextObject
-----------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Helpers.PerkHelper.TextObject | | static |

[◆](class_helpers_1_1_perk_helper.html#a8c1303709500fa735616dc73bfa0e7e1)NavalMultiplier
----------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float Helpers.PerkHelper.NavalMultiplier = 0.5f | | static |

