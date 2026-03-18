--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_healing_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.PartyHealingModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultPartyHealingModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_healing_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| float | [GetSurgeryChance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_healing_model.html#aee4e978db50cf8dc53b9a240007db069) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| float | [GetSurvivalChance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_healing_model.html#ae0b92b27ccc1a9615a9e247d4e121564) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) agentCharacter, [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) damageType, bool canDamageKillEvenIfBlunt, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) enemyParty=null) |
| int | [GetSkillXpFromHealingTroop](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_healing_model.html#ab75898213147fdb29662d3a3c95e7f50) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetDailyHealingForRegulars](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_healing_model.html#a81b00c98df96390ea046b13a7220621e) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) partyBase, bool isPrisoner, bool includeDescriptions=false) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetDailyHealingHpForHeroes](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_healing_model.html#a1bb27b0b24dc809716e92ea6d7a921e9) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) partyBase, bool isPrisoners, bool includeDescriptions=false) |
| int | [GetHeroesEffectedHealingAmount](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_healing_model.html#a0262be8d6b3b633ac5c32aec17738fd5) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, float healingRate) |
| float | [GetSiegeBombardmentHitSurgeryChance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_healing_model.html#a81e7982e912e71868841df4b3fd386a8) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetBattleEndHealingAmount](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_healing_model.html#ad79366bbebf43cefed344b3face3f03e) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) partyBase, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_healing_model.html#aee4e978db50cf8dc53b9a240007db069)GetSurgeryChance()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.PartyHealingModel.GetSurgeryChance | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_healing_model.html#ae0b92b27ccc1a9615a9e247d4e121564)GetSurvivalChance()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.PartyHealingModel.GetSurvivalChance | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *agentCharacter*, | |  |  | [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) | *damageType*, | |  |  | bool | *canDamageKillEvenIfBlunt*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *enemyParty* = null ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_healing_model.html#ab75898213147fdb29662d3a3c95e7f50)GetSkillXpFromHealingTroop()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.PartyHealingModel.GetSkillXpFromHealingTroop | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_healing_model.html#a81b00c98df96390ea046b13a7220621e)GetDailyHealingForRegulars()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.PartyHealingModel.GetDailyHealingForRegulars | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *partyBase*, | |  |  | bool | *isPrisoner*, | |  |  | bool | *includeDescriptions* = false ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_healing_model.html#a1bb27b0b24dc809716e92ea6d7a921e9)GetDailyHealingHpForHeroes()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.PartyHealingModel.GetDailyHealingHpForHeroes | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *partyBase*, | |  |  | bool | *isPrisoners*, | |  |  | bool | *includeDescriptions* = false ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_healing_model.html#a0262be8d6b3b633ac5c32aec17738fd5)GetHeroesEffectedHealingAmount()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.PartyHealingModel.GetHeroesEffectedHealingAmount | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | float | *healingRate* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_healing_model.html#a81e7982e912e71868841df4b3fd386a8)GetSiegeBombardmentHitSurgeryChance()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.PartyHealingModel.GetSiegeBombardmentHitSurgeryChance | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_healing_model.html#ad79366bbebf43cefed344b3face3f03e)GetBattleEndHealingAmount()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.PartyHealingModel.GetBattleEndHealingAmount | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *partyBase*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* ) | | abstract |

