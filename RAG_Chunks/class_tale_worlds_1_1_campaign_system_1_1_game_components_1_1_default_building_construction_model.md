--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_building_construction_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultBuildingConstructionModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.BuildingConstructionModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_building_construction_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateDailyConstructionPower](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_building_construction_model.html#ace6472153f2daf6089c9d647380119fe) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, bool includeDescriptions=false) |
| override int | [CalculateDailyConstructionPowerWithoutBoost](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_building_construction_model.html#ad5b4c9044e10a341fc2cf4940a34e8fc) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| override int | [GetBoostAmount](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_building_construction_model.html#ac4c1f3bb3ff281e94ed97832e9d608f9) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| override int | [GetBoostCost](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_building_construction_model.html#a8dfa63d6bc5e22e1056524322addef82) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.BuildingConstructionModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_building_construction_model.html) | |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateDailyConstructionPower](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_building_construction_model.html#ad68d82d188c2380da0cef652930aa52a) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, bool includeDescriptions=false) |
| int | [CalculateDailyConstructionPowerWithoutBoost](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_building_construction_model.html#ace0775dfe7d06417c545aba1174ac555) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| int | [GetBoostCost](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_building_construction_model.html#aa69aed8212ec445eca18a34e1f3c9d1b) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| int | [GetBoostAmount](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_building_construction_model.html#a351b68f07297a0feaa6d6b8b074e85be) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| override int | [TownBoostCost](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_building_construction_model.html#a4072f0b5bfb7b69bc5ff576fadc10f3a) `[get]` |
| override int | [TownBoostBonus](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_building_construction_model.html#aa0923538412e8f476a91e28e8a9066ec) `[get]` |
| override int | [CastleBoostCost](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_building_construction_model.html#aa14cff79fcb7d160de85bebc99611995) `[get]` |
| override int | [CastleBoostBonus](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_building_construction_model.html#ad49e370516dfa6fd0789192a79b34988) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.BuildingConstructionModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_building_construction_model.html) | |
| int | [TownBoostCost](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_building_construction_model.html#a2d67790ae3491569b079e8967c31aa52) `[get]` |
| int | [TownBoostBonus](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_building_construction_model.html#a5c2abd79eb06226a6b27a2aa31a8fd06) `[get]` |
| int | [CastleBoostCost](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_building_construction_model.html#ad714db6b2cc0d8c8c76f262cf6533bb6) `[get]` |
| int | [CastleBoostBonus](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_building_construction_model.html#a381741a059838a49f3b42e2cc96632b1) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_building_construction_model.html#ace6472153f2daf6089c9d647380119fe)CalculateDailyConstructionPower()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultBuildingConstructionModel.CalculateDailyConstructionPower | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, |
|  |  | bool | *includeDescriptions* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_building_construction_model.html#ad5b4c9044e10a341fc2cf4940a34e8fc)CalculateDailyConstructionPowerWithoutBoost()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultBuildingConstructionModel.CalculateDailyConstructionPowerWithoutBoost | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_building_construction_model.html#ac4c1f3bb3ff281e94ed97832e9d608f9)GetBoostAmount()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultBuildingConstructionModel.GetBoostAmount | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_building_construction_model.html#a8dfa63d6bc5e22e1056524322addef82)GetBoostCost()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultBuildingConstructionModel.GetBoostCost | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_building_construction_model.html#a4072f0b5bfb7b69bc5ff576fadc10f3a)TownBoostCost
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultBuildingConstructionModel.TownBoostCost | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_building_construction_model.html#aa0923538412e8f476a91e28e8a9066ec)TownBoostBonus
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultBuildingConstructionModel.TownBoostBonus | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_building_construction_model.html#aa14cff79fcb7d160de85bebc99611995)CastleBoostCost
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultBuildingConstructionModel.CastleBoostCost | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_building_construction_model.html#ad49e370516dfa6fd0789192a79b34988)CastleBoostBonus
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultBuildingConstructionModel.CastleBoostBonus | | get |

