--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_building_construction_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.BuildingConstructionModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultBuildingConstructionModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_building_construction_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateDailyConstructionPower](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_building_construction_model.html#ad68d82d188c2380da0cef652930aa52a) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, bool includeDescriptions=false) |
| int | [CalculateDailyConstructionPowerWithoutBoost](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_building_construction_model.html#ace0775dfe7d06417c545aba1174ac555) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| int | [GetBoostCost](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_building_construction_model.html#aa69aed8212ec445eca18a34e1f3c9d1b) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| int | [GetBoostAmount](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_building_construction_model.html#a351b68f07297a0feaa6d6b8b074e85be) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| int | [TownBoostCost](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_building_construction_model.html#a2d67790ae3491569b079e8967c31aa52) `[get]` |
| int | [TownBoostBonus](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_building_construction_model.html#a5c2abd79eb06226a6b27a2aa31a8fd06) `[get]` |
| int | [CastleBoostCost](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_building_construction_model.html#ad714db6b2cc0d8c8c76f262cf6533bb6) `[get]` |
| int | [CastleBoostBonus](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_building_construction_model.html#a381741a059838a49f3b42e2cc96632b1) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_building_construction_model.html#ad68d82d188c2380da0cef652930aa52a)CalculateDailyConstructionPower()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.BuildingConstructionModel.CalculateDailyConstructionPower | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | bool | *includeDescriptions* = false ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_building_construction_model.html#ace0775dfe7d06417c545aba1174ac555)CalculateDailyConstructionPowerWithoutBoost()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.BuildingConstructionModel.CalculateDailyConstructionPowerWithoutBoost | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_building_construction_model.html#aa69aed8212ec445eca18a34e1f3c9d1b)GetBoostCost()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.BuildingConstructionModel.GetBoostCost | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_building_construction_model.html#a351b68f07297a0feaa6d6b8b074e85be)GetBoostAmount()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.BuildingConstructionModel.GetBoostAmount | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* | ) |  | | abstract |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_building_construction_model.html#a2d67790ae3491569b079e8967c31aa52)TownBoostCost
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.BuildingConstructionModel.TownBoostCost | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_building_construction_model.html#a5c2abd79eb06226a6b27a2aa31a8fd06)TownBoostBonus
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.BuildingConstructionModel.TownBoostBonus | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_building_construction_model.html#ad714db6b2cc0d8c8c76f262cf6533bb6)CastleBoostCost
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.BuildingConstructionModel.CastleBoostCost | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_building_construction_model.html#a381741a059838a49f3b42e2cc96632b1)CastleBoostBonus
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.BuildingConstructionModel.CastleBoostBonus | | getabstract |

