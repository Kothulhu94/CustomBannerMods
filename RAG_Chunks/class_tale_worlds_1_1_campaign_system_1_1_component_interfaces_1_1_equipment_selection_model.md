--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_equipment_selection_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.EquipmentSelectionModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultEquipmentSelectionModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_equipment_selection_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| MBList< [MBEquipmentRoster](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html) > | [GetEquipmentRostersForHeroComeOfAge](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_equipment_selection_model.html#ad85ab86501c6b4d62d5ec3b354d1e4e7) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, bool isCivilian) |
| MBList< [MBEquipmentRoster](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html) > | [GetEquipmentRostersForHeroReachesTeenAge](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_equipment_selection_model.html#a2a4830f4cf48177675d5c18284df83af) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| MBList< [MBEquipmentRoster](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html) > | [GetEquipmentRostersForInitialChildrenGeneration](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_equipment_selection_model.html#aea2b6df1c722bdf6b67c45130b852711) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| MBList< [MBEquipmentRoster](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html) > | [GetEquipmentRostersForDeliveredOffspring](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_equipment_selection_model.html#ab21281747e8581be7aee10618cf018c6) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| MBList< [MBEquipmentRoster](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html) > | [GetEquipmentRostersForCompanion](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_equipment_selection_model.html#a3dd40b2f954d7eb2f5514faafca46c64) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) companionHero, bool isCivilian) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_equipment_selection_model.html#ad85ab86501c6b4d62d5ec3b354d1e4e7)GetEquipmentRostersForHeroComeOfAge()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | MBList< [MBEquipmentRoster](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html) > TaleWorlds.CampaignSystem.ComponentInterfaces.EquipmentSelectionModel.GetEquipmentRostersForHeroComeOfAge | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | bool | *isCivilian* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_equipment_selection_model.html#a2a4830f4cf48177675d5c18284df83af)GetEquipmentRostersForHeroReachesTeenAge()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | MBList< [MBEquipmentRoster](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html) > TaleWorlds.CampaignSystem.ComponentInterfaces.EquipmentSelectionModel.GetEquipmentRostersForHeroReachesTeenAge | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_equipment_selection_model.html#aea2b6df1c722bdf6b67c45130b852711)GetEquipmentRostersForInitialChildrenGeneration()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | MBList< [MBEquipmentRoster](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html) > TaleWorlds.CampaignSystem.ComponentInterfaces.EquipmentSelectionModel.GetEquipmentRostersForInitialChildrenGeneration | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_equipment_selection_model.html#ab21281747e8581be7aee10618cf018c6)GetEquipmentRostersForDeliveredOffspring()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | MBList< [MBEquipmentRoster](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html) > TaleWorlds.CampaignSystem.ComponentInterfaces.EquipmentSelectionModel.GetEquipmentRostersForDeliveredOffspring | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_equipment_selection_model.html#a3dd40b2f954d7eb2f5514faafca46c64)GetEquipmentRostersForCompanion()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | MBList< [MBEquipmentRoster](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html) > TaleWorlds.CampaignSystem.ComponentInterfaces.EquipmentSelectionModel.GetEquipmentRostersForCompanion | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *companionHero*, | |  |  | bool | *isCivilian* ) | | abstract |

