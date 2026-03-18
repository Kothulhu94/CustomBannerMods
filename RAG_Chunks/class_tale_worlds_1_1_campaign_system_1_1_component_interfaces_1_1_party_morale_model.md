--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_morale_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.PartyMoraleModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultPartyMoraleModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_morale_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| int | [GetDailyStarvationMoralePenalty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_morale_model.html#adabfb2c4173a3b21fd38f0bd964bbb2d) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| int | [GetDailyNoWageMoralePenalty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_morale_model.html#a46978db446a4eb1efba9c7e6e486c5c8) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |
| float | [GetStandardBaseMorale](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_morale_model.html#adc1aa9c83303ed69ca048aadcb9c2d3c) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| float | [GetVictoryMoraleChange](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_morale_model.html#a751ecb88f79f07e04b540db059152d2a) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| float | [GetDefeatMoraleChange](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_morale_model.html#a90c8003985254493d605ccc2d9974e0d) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetEffectivePartyMorale](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_morale_model.html#a164a03326e4e72c6e8ab13573241cb53) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, bool includeDescription=false) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| float | [HighMoraleValue](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_morale_model.html#aadaff9990391e42c5993f2e4968189e2) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_morale_model.html#adabfb2c4173a3b21fd38f0bd964bbb2d)GetDailyStarvationMoralePenalty()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.PartyMoraleModel.GetDailyStarvationMoralePenalty | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_morale_model.html#a46978db446a4eb1efba9c7e6e486c5c8)GetDailyNoWageMoralePenalty()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.PartyMoraleModel.GetDailyNoWageMoralePenalty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_morale_model.html#adc1aa9c83303ed69ca048aadcb9c2d3c)GetStandardBaseMorale()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.PartyMoraleModel.GetStandardBaseMorale | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_morale_model.html#a751ecb88f79f07e04b540db059152d2a)GetVictoryMoraleChange()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.PartyMoraleModel.GetVictoryMoraleChange | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_morale_model.html#a90c8003985254493d605ccc2d9974e0d)GetDefeatMoraleChange()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.PartyMoraleModel.GetDefeatMoraleChange | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_morale_model.html#a164a03326e4e72c6e8ab13573241cb53)GetEffectivePartyMorale()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.PartyMoraleModel.GetEffectivePartyMorale | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | bool | *includeDescription* = false ) | | abstract |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_morale_model.html#aadaff9990391e42c5993f2e4968189e2)HighMoraleValue
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.PartyMoraleModel.HighMoraleValue | | getabstract |

