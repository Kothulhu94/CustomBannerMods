--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_barter_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultBarterModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.BarterModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_barter_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override int | [CalculateOverpayRelationIncreaseCosts](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_barter_model.html#a2fdb75bb1a0069bc37cf2bc47fd450a8) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, float overpayAmount) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetBarterPenalty](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_barter_model.html#a4e10ddaaed60c48c16090494df70c692) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction, [ItemBarterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_item_barterable.html) itemBarterable, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) otherHero, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) otherParty) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.BarterModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_barter_model.html) | |
| int | [CalculateOverpayRelationIncreaseCosts](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_barter_model.html#a158c19f3c4b04a74dcf7414dfb444842) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, float overpayAmount) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetBarterPenalty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_barter_model.html#ada066ca8f70a4afefeff96614d90f34c) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction, [ItemBarterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_item_barterable.html) itemBarterable, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) otherHero, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) otherParty) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| override int | [BarterCooldownWithHeroInDays](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_barter_model.html#ae17113bfea85923967431c8dbbf3e758) `[get]` |
| override float | [MaximumPercentageOfNpcGoldToSpendAtBarter](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_barter_model.html#a3a97c231bda2960bc118f9ae0ed3fbdc) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.BarterModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_barter_model.html) | |
| int | [BarterCooldownWithHeroInDays](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_barter_model.html#a7aba879a8fe04f47a83fa00d647fb653) `[get]` |
| float | [MaximumPercentageOfNpcGoldToSpendAtBarter](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_barter_model.html#ae11fd106c31901333b5cb3e03c9ce526) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_barter_model.html#a2fdb75bb1a0069bc37cf2bc47fd450a8)CalculateOverpayRelationIncreaseCosts()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultBarterModel.CalculateOverpayRelationIncreaseCosts | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | float | *overpayAmount* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_barter_model.html#a4e10ddaaed60c48c16090494df70c692)GetBarterPenalty()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultBarterModel.GetBarterPenalty | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction*, |
|  |  | [ItemBarterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_item_barterable.html) | *itemBarterable*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *otherHero*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *otherParty* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_barter_model.html#ae17113bfea85923967431c8dbbf3e758)BarterCooldownWithHeroInDays
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultBarterModel.BarterCooldownWithHeroInDays | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_barter_model.html#a3a97c231bda2960bc118f9ae0ed3fbdc)MaximumPercentageOfNpcGoldToSpendAtBarter
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultBarterModel.MaximumPercentageOfNpcGoldToSpendAtBarter | | get |

