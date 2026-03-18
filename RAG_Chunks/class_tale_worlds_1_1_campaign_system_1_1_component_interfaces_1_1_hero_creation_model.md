--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_creation_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.HeroCreationModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultHeroCreationModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_hero_creation_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) deathDay | [GetBirthAndDeathDay](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_creation_model.html#a29885dc643c3f5457c71ca1f75bef524) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, bool createAlive, int age) |
| [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [GetBornSettlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_creation_model.html#afac99b3f6311823a6d5d53c8bd1031fc) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) character) |
| [StaticBodyProperties](struct_tale_worlds_1_1_core_1_1_static_body_properties.html) | [GetStaticBodyProperties](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_creation_model.html#a346290f6ae1038ca6f97f09dfa44bdd5) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) character, bool isOffspring, float variationAmount=0.35f) |
| [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | [GetPreferredUpgradeFormation](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_creation_model.html#a7ee62d15e5e398f513c2e4d9a2a26ea7) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) character) |
| [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | [GetClan](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_creation_model.html#ac877d949849d3ef484014f40f1216fde) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) character) |
| [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | [GetCulture](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_creation_model.html#abfdb89c6081ad7bb3a850b45099056fe) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) bornSettlement, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [GetRandomTemplateByOccupation](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_creation_model.html#aecac85aae2cdbec81a34868902549282) ([Occupation](namespace_tale_worlds_1_1_campaign_system.html#aec98373ba979379d4fc6ada5620d672f) occupation, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement=null) |
| List<([TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html) trait, int level)> | [GetTraitsForHero](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_creation_model.html#a5efbb0ee5c1bca3902034025c5ade2ab) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) | [GetCivilianEquipment](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_creation_model.html#a5db5edba7f7b66896bd3f26f855d7dd4) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) | [GetBattleEquipment](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_creation_model.html#afc9a36150fecbf85e107a65ddf92cb28) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [GetCharacterTemplateForOffspring](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_creation_model.html#a7d8a2c14b5648e8deba41b861487dc14) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) mother, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) father, bool isOffspringFemale) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) name | [GenerateFirstAndFullName](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_creation_model.html#a3226cf831476164af364f7e0b63c5b49) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| List<([SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html), int)> | [GetDefaultSkillsForHero](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_creation_model.html#a30beaad162d58c35f6c22a70ec355d66) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| List<([SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html), int)> | [GetInheritedSkillsForHero](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_creation_model.html#aff0e2df4b1839a20819b48de726571ee) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| bool | [IsHeroCombatant](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_creation_model.html#af96b6816e4fcab0313082a5a54206c05) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Public Attributes | |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [birthDay](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_creation_model.html#a4d180032e814f104c97181eb90ce2175) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [firstName](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_creation_model.html#a0d27fffa13ad00ace320a102ee99ee4e) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_creation_model.html#a29885dc643c3f5457c71ca1f75bef524)GetBirthAndDeathDay()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) deathDay TaleWorlds.CampaignSystem.ComponentInterfaces.HeroCreationModel.GetBirthAndDeathDay | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, |
|  |  | bool | *createAlive*, |
|  |  | int | *age* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_creation_model.html#afac99b3f6311823a6d5d53c8bd1031fc)GetBornSettlement()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) TaleWorlds.CampaignSystem.ComponentInterfaces.HeroCreationModel.GetBornSettlement | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *character* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_creation_model.html#a346290f6ae1038ca6f97f09dfa44bdd5)GetStaticBodyProperties()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [StaticBodyProperties](struct_tale_worlds_1_1_core_1_1_static_body_properties.html) TaleWorlds.CampaignSystem.ComponentInterfaces.HeroCreationModel.GetStaticBodyProperties | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *character*, | |  |  | bool | *isOffspring*, | |  |  | float | *variationAmount* = 0.35f ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_creation_model.html#a7ee62d15e5e398f513c2e4d9a2a26ea7)GetPreferredUpgradeFormation()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) TaleWorlds.CampaignSystem.ComponentInterfaces.HeroCreationModel.GetPreferredUpgradeFormation | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *character* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_creation_model.html#ac877d949849d3ef484014f40f1216fde)GetClan()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) TaleWorlds.CampaignSystem.ComponentInterfaces.HeroCreationModel.GetClan | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *character* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_creation_model.html#abfdb89c6081ad7bb3a850b45099056fe)GetCulture()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) TaleWorlds.CampaignSystem.ComponentInterfaces.HeroCreationModel.GetCulture | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *bornSettlement*, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_creation_model.html#aecac85aae2cdbec81a34868902549282)GetRandomTemplateByOccupation()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.ComponentInterfaces.HeroCreationModel.GetRandomTemplateByOccupation | ( | [Occupation](namespace_tale_worlds_1_1_campaign_system.html#aec98373ba979379d4fc6ada5620d672f) | *occupation*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* = null ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_creation_model.html#a5efbb0ee5c1bca3902034025c5ade2ab)GetTraitsForHero()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | List<([TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html) trait, int level)> TaleWorlds.CampaignSystem.ComponentInterfaces.HeroCreationModel.GetTraitsForHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_creation_model.html#a5db5edba7f7b66896bd3f26f855d7dd4)GetCivilianEquipment()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) TaleWorlds.CampaignSystem.ComponentInterfaces.HeroCreationModel.GetCivilianEquipment | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_creation_model.html#afc9a36150fecbf85e107a65ddf92cb28)GetBattleEquipment()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) TaleWorlds.CampaignSystem.ComponentInterfaces.HeroCreationModel.GetBattleEquipment | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_creation_model.html#a7d8a2c14b5648e8deba41b861487dc14)GetCharacterTemplateForOffspring()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.ComponentInterfaces.HeroCreationModel.GetCharacterTemplateForOffspring | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *mother*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *father*, | |  |  | bool | *isOffspringFemale* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_creation_model.html#a3226cf831476164af364f7e0b63c5b49)GenerateFirstAndFullName()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) name TaleWorlds.CampaignSystem.ComponentInterfaces.HeroCreationModel.GenerateFirstAndFullName | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_creation_model.html#a30beaad162d58c35f6c22a70ec355d66)GetDefaultSkillsForHero()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | List<([SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html), int)> TaleWorlds.CampaignSystem.ComponentInterfaces.HeroCreationModel.GetDefaultSkillsForHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_creation_model.html#aff0e2df4b1839a20819b48de726571ee)GetInheritedSkillsForHero()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | List<([SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html), int)> TaleWorlds.CampaignSystem.ComponentInterfaces.HeroCreationModel.GetInheritedSkillsForHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_creation_model.html#af96b6816e4fcab0313082a5a54206c05)IsHeroCombatant()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.HeroCreationModel.IsHeroCombatant | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | abstract |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_creation_model.html#a4d180032e814f104c97181eb90ce2175)birthDay
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.ComponentInterfaces.HeroCreationModel.birthDay | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_creation_model.html#a0d27fffa13ad00ace320a102ee99ee4e)firstName
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.ComponentInterfaces.HeroCreationModel.firstName | | abstract |

