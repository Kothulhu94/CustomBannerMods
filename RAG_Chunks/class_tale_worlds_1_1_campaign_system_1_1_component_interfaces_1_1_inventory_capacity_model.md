--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_inventory_capacity_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.InventoryCapacityModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultInventoryCapacityModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_inventory_capacity_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateInventoryCapacity](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_inventory_capacity_model.html#a963d268990f5b5799dedd62f7f4130a5) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, bool isCurrentlyAtSea, bool includeDescriptions=false, int additionalManOnFoot=0, int additionalSpareMounts=0, int additionalPackAnimals=0, bool includeFollowers=false) |
| int | [GetItemAverageWeight](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_inventory_capacity_model.html#a376d94f622381ef0e00b8453443b7d80) () |
| float | [GetItemEffectiveWeight](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_inventory_capacity_model.html#ad7c4327066c1cbe492f67d1a5d9afa2c) ([EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) equipmentElement, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, bool isCurrentlyAtSea, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) description) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateTotalWeightCarried](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_inventory_capacity_model.html#a3bab26783607cde2a27042c2146cb050) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, bool isCurrentlyAtSea, bool includeDescriptions=false) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_inventory_capacity_model.html#a963d268990f5b5799dedd62f7f4130a5)CalculateInventoryCapacity()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.InventoryCapacityModel.CalculateInventoryCapacity | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, | |  |  | bool | *isCurrentlyAtSea*, | |  |  | bool | *includeDescriptions* = false, | |  |  | int | *additionalManOnFoot* = 0, | |  |  | int | *additionalSpareMounts* = 0, | |  |  | int | *additionalPackAnimals* = 0, | |  |  | bool | *includeFollowers* = false ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_inventory_capacity_model.html#a376d94f622381ef0e00b8453443b7d80)GetItemAverageWeight()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.InventoryCapacityModel.GetItemAverageWeight | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_inventory_capacity_model.html#ad7c4327066c1cbe492f67d1a5d9afa2c)GetItemEffectiveWeight()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.InventoryCapacityModel.GetItemEffectiveWeight | ( | [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) | *equipmentElement*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, | |  |  | bool | *isCurrentlyAtSea*, | |  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *description* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_inventory_capacity_model.html#a3bab26783607cde2a27042c2146cb050)CalculateTotalWeightCarried()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.InventoryCapacityModel.CalculateTotalWeightCarried | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, | |  |  | bool | *isCurrentlyAtSea*, | |  |  | bool | *includeDescriptions* = false ) | | abstract |

