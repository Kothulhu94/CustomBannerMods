--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_barter_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.BarterModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultBarterModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_barter_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| int | [CalculateOverpayRelationIncreaseCosts](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_barter_model.html#a158c19f3c4b04a74dcf7414dfb444842) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, float overpayAmount) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetBarterPenalty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_barter_model.html#ada066ca8f70a4afefeff96614d90f34c) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction, [ItemBarterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_item_barterable.html) itemBarterable, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) otherHero, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) otherParty) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| int | [BarterCooldownWithHeroInDays](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_barter_model.html#a7aba879a8fe04f47a83fa00d647fb653) `[get]` |
| float | [MaximumPercentageOfNpcGoldToSpendAtBarter](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_barter_model.html#ae11fd106c31901333b5cb3e03c9ce526) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_barter_model.html#a158c19f3c4b04a74dcf7414dfb444842)CalculateOverpayRelationIncreaseCosts()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.BarterModel.CalculateOverpayRelationIncreaseCosts | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | float | *overpayAmount* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_barter_model.html#ada066ca8f70a4afefeff96614d90f34c)GetBarterPenalty()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.BarterModel.GetBarterPenalty | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction*, | |  |  | [ItemBarterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_item_barterable.html) | *itemBarterable*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *otherHero*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *otherParty* ) | | abstract |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_barter_model.html#a7aba879a8fe04f47a83fa00d647fb653)BarterCooldownWithHeroInDays
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.BarterModel.BarterCooldownWithHeroInDays | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_barter_model.html#ae11fd106c31901333b5cb3e03c9ce526)MaximumPercentageOfNpcGoldToSpendAtBarter
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.BarterModel.MaximumPercentageOfNpcGoldToSpendAtBarter | | getabstract |

