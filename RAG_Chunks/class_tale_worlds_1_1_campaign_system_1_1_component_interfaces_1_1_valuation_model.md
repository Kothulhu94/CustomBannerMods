--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_valuation_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.ValuationModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultValuationModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_valuation_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| float | [GetValueOfTroop](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_valuation_model.html#a61101149819b78fa7927b3a895209fbe) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) troop) |
| float | [GetMilitaryValueOfParty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_valuation_model.html#a286160eb48ea7125aa601c508500262f) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |
| float | [GetValueOfHero](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_valuation_model.html#a146cb7724d89576b3050f88019670a0b) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_valuation_model.html#a61101149819b78fa7927b3a895209fbe)GetValueOfTroop()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.ValuationModel.GetValueOfTroop | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *troop* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_valuation_model.html#a286160eb48ea7125aa601c508500262f)GetMilitaryValueOfParty()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.ValuationModel.GetMilitaryValueOfParty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_valuation_model.html#a146cb7724d89576b3050f88019670a0b)GetValueOfHero()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.ValuationModel.GetValueOfHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | abstract |

