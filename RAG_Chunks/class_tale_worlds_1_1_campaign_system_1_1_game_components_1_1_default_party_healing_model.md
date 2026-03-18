--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_healing_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultPartyHealingModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.PartyHealingModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_healing_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override float | [GetSurgeryChance](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_healing_model.html#a23caaba5b6e3277999cd5b5c24bf272a) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| override float | [GetSiegeBombardmentHitSurgeryChance](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_healing_model.html#aaf63b70905f2ac7f5b137bb22e16d957) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| override float | [GetSurvivalChance](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_healing_model.html#a5688ffcd4d372c0f9c0396a50c4e2a9d) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) damageType, bool canDamageKillEvenIfBlunt, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) enemyParty=null) |
| override int | [GetSkillXpFromHealingTroop](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_healing_model.html#a7ec040467a4f596d723cfbe7731d1a8c) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetDailyHealingForRegulars](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_healing_model.html#af561d1de47e81acd9db59d536dbf5212) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, bool isPrisoners, bool includeDescriptions=false) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetDailyHealingHpForHeroes](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_healing_model.html#aecd6ee6a1c452a1abe4648381d4d62b6) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, bool isPrisoners, bool includeDescriptions=false) |
| override int | [GetHeroesEffectedHealingAmount](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_healing_model.html#abb6c7c859ba0795732924c67c6bf93c0) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, float healingRate) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetBattleEndHealingAmount](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_healing_model.html#a32c086e4d2af7e53ab1ba6a29c5fd55b) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.PartyHealingModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_healing_model.html) | |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_healing_model.html#a23caaba5b6e3277999cd5b5c24bf272a)GetSurgeryChance()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultPartyHealingModel.GetSurgeryChance | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_healing_model.html#aaf63b70905f2ac7f5b137bb22e16d957)GetSiegeBombardmentHitSurgeryChance()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultPartyHealingModel.GetSiegeBombardmentHitSurgeryChance | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_healing_model.html#a5688ffcd4d372c0f9c0396a50c4e2a9d)GetSurvivalChance()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultPartyHealingModel.GetSurvivalChance | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, |
|  |  | [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) | *damageType*, |
|  |  | bool | *canDamageKillEvenIfBlunt*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *enemyParty* = null ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_healing_model.html#a7ec040467a4f596d723cfbe7731d1a8c)GetSkillXpFromHealingTroop()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultPartyHealingModel.GetSkillXpFromHealingTroop | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_healing_model.html#af561d1de47e81acd9db59d536dbf5212)GetDailyHealingForRegulars()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultPartyHealingModel.GetDailyHealingForRegulars | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, |
|  |  | bool | *isPrisoners*, |
|  |  | bool | *includeDescriptions* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_healing_model.html#aecd6ee6a1c452a1abe4648381d4d62b6)GetDailyHealingHpForHeroes()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultPartyHealingModel.GetDailyHealingHpForHeroes | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, |
|  |  | bool | *isPrisoners*, |
|  |  | bool | *includeDescriptions* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_healing_model.html#abb6c7c859ba0795732924c67c6bf93c0)GetHeroesEffectedHealingAmount()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultPartyHealingModel.GetHeroesEffectedHealingAmount | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | float | *healingRate* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_healing_model.html#a32c086e4d2af7e53ab1ba6a29c5fd55b)GetBattleEndHealingAmount()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultPartyHealingModel.GetBattleEndHealingAmount | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* ) |

