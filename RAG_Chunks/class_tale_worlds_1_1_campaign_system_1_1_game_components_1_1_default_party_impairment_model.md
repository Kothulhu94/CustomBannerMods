--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_impairment_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultPartyImpairmentModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.PartyImpairmentModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_impairment_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override float | [GetSiegeExpectedVulnerabilityTime](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_impairment_model.html#a88e10a3d890da6d95e3dbae749807c4d) () |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetDisorganizedStateDuration](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_impairment_model.html#a3bce702a782941d1b37bc54079e34e0d) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |
| override bool | [CanGetDisorganized](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_impairment_model.html#aa3fcd61cc2c8780c7aad99beaae484ea) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| override float | [GetVulnerabilityStateDuration](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_impairment_model.html#ae336de1b2b1e36f0b89c71153ccaea06) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.PartyImpairmentModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_impairment_model.html) | |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetDisorganizedStateDuration](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_impairment_model.html#a987022b2a3b3d3aafbdfec889852a4cd) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |
| float | [GetVulnerabilityStateDuration](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_impairment_model.html#ad0aa1e78be740937217f4cb99bf529bb) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| float | [GetSiegeExpectedVulnerabilityTime](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_impairment_model.html#a253545fa6af851ddd4aecc637cf1c498) () |
| bool | [CanGetDisorganized](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_impairment_model.html#af55cc426ebdd707ac86e23dd02e76a3c) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) partyBase) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_impairment_model.html#a88e10a3d890da6d95e3dbae749807c4d)GetSiegeExpectedVulnerabilityTime()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultPartyImpairmentModel.GetSiegeExpectedVulnerabilityTime | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_impairment_model.html#a3bce702a782941d1b37bc54079e34e0d)GetDisorganizedStateDuration()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultPartyImpairmentModel.GetDisorganizedStateDuration | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_impairment_model.html#aa3fcd61cc2c8780c7aad99beaae484ea)CanGetDisorganized()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultPartyImpairmentModel.CanGetDisorganized | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_impairment_model.html#ae336de1b2b1e36f0b89c71153ccaea06)GetVulnerabilityStateDuration()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultPartyImpairmentModel.GetVulnerabilityStateDuration | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  |

