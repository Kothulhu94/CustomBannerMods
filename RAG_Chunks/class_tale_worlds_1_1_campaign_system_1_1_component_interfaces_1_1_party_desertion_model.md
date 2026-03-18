--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_desertion_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.PartyDesertionModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultPartyDesertionModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_desertion_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | [GetTroopsToDesert](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_desertion_model.html#a617d5ffab302c44afd9994d1c13ef269) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| float | [GetDesertionChanceForTroop](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_desertion_model.html#a99ee288cf26fb2930853ef7aba2005f4) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, in [TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html) troopRosterElement) |
| int | [GetMoraleThresholdForTroopDesertion](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_desertion_model.html#a8a1bb0316653df51bc89adcd46038d2f) () |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_desertion_model.html#a617d5ffab302c44afd9994d1c13ef269)GetTroopsToDesert()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) TaleWorlds.CampaignSystem.ComponentInterfaces.PartyDesertionModel.GetTroopsToDesert | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_desertion_model.html#a99ee288cf26fb2930853ef7aba2005f4)GetDesertionChanceForTroop()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.PartyDesertionModel.GetDesertionChanceForTroop | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, | |  |  | in [TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html) | *troopRosterElement* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_desertion_model.html#a8a1bb0316653df51bc89adcd46038d2f)GetMoraleThresholdForTroopDesertion()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.PartyDesertionModel.GetMoraleThresholdForTroopDesertion | ( |  | ) |  | | abstract |

