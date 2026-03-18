--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_morale_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultPartyMoraleModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.PartyMoraleModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_morale_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override int | [GetDailyStarvationMoralePenalty](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_morale_model.html#af9ee3f5674454d1f1608fe7a9e874956) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| override int | [GetDailyNoWageMoralePenalty](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_morale_model.html#a2a2756e86f7f34c9f11ac7accd249c73) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |
| override float | [GetStandardBaseMorale](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_morale_model.html#aea92d3641c0e3a0eb785750600962114) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| override float | [GetVictoryMoraleChange](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_morale_model.html#a41e953a7a83412eedaee80bd950077ce) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| override float | [GetDefeatMoraleChange](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_morale_model.html#aed05f3e6fd7aa3cea2e00ca70e9ba8fe) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetEffectivePartyMorale](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_morale_model.html#a8a330a6a1745d26b9dfc822d5e95944f) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, bool includeDescription=false) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.PartyMoraleModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_morale_model.html) | |
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
| override float | [HighMoraleValue](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_morale_model.html#a82699ec30cddd538712651729d1b38c4) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.PartyMoraleModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_morale_model.html) | |
| float | [HighMoraleValue](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_morale_model.html#aadaff9990391e42c5993f2e4968189e2) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_morale_model.html#af9ee3f5674454d1f1608fe7a9e874956)GetDailyStarvationMoralePenalty()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultPartyMoraleModel.GetDailyStarvationMoralePenalty | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_morale_model.html#a2a2756e86f7f34c9f11ac7accd249c73)GetDailyNoWageMoralePenalty()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultPartyMoraleModel.GetDailyNoWageMoralePenalty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_morale_model.html#aea92d3641c0e3a0eb785750600962114)GetStandardBaseMorale()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultPartyMoraleModel.GetStandardBaseMorale | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_morale_model.html#a41e953a7a83412eedaee80bd950077ce)GetVictoryMoraleChange()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultPartyMoraleModel.GetVictoryMoraleChange | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_morale_model.html#aed05f3e6fd7aa3cea2e00ca70e9ba8fe)GetDefeatMoraleChange()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultPartyMoraleModel.GetDefeatMoraleChange | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_morale_model.html#a8a330a6a1745d26b9dfc822d5e95944f)GetEffectivePartyMorale()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultPartyMoraleModel.GetEffectivePartyMorale | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, |
|  |  | bool | *includeDescription* = false ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_morale_model.html#a82699ec30cddd538712651729d1b38c4)HighMoraleValue
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultPartyMoraleModel.HighMoraleValue | | get |

