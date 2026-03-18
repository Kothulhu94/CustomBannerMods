--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_training_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultPartyTrainingModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.PartyTrainingModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_training_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override int | [GetXpReward](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_training_model.html#a8c89f461d022765a569ce58766fb26bb) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetEffectiveDailyExperience](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_training_model.html#a25ad2f02d93215392dd93bff6b3fd19b) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html) troop) |
| override int | [GenerateSharedXp](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_training_model.html#aee70a08f7237e3573036417b5b2d98e5) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) troop, int xp, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateXpGainFromBattles](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_training_model.html#a9aa2ac09dc0c190c3d2d09971522f71a) ([FlattenedTroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html) troopRosterElement, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.PartyTrainingModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_training_model.html) | |
| int | [GenerateSharedXp](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_training_model.html#a6901c5edc40d7a8007e458df5804ea36) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) troop, int xp, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateXpGainFromBattles](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_training_model.html#af95ffea183f53b18d5e60be984be7eca) ([FlattenedTroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html) troopRosterElement, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| int | [GetXpReward](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_training_model.html#afaed67a306530114a2539de59aad3f17) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetEffectiveDailyExperience](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_training_model.html#ac12197322b4f3deae254e083e05f195c) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html) troop) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_training_model.html#a8c89f461d022765a569ce58766fb26bb)GetXpReward()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultPartyTrainingModel.GetXpReward | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_training_model.html#a25ad2f02d93215392dd93bff6b3fd19b)GetEffectiveDailyExperience()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultPartyTrainingModel.GetEffectiveDailyExperience | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, |
|  |  | [TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html) | *troop* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_training_model.html#aee70a08f7237e3573036417b5b2d98e5)GenerateSharedXp()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultPartyTrainingModel.GenerateSharedXp | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *troop*, |
|  |  | int | *xp*, |
|  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_training_model.html#a9aa2ac09dc0c190c3d2d09971522f71a)CalculateXpGainFromBattles()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultPartyTrainingModel.CalculateXpGainFromBattles | ( | [FlattenedTroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html) | *troopRosterElement*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* ) |

