--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_item_pickup_model.html ---

TaleWorlds.MountAndBlade.ComponentInterfaces.ItemPickupModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.MountAndBlade.DefaultItemPickupModel](class_tale_worlds_1_1_mount_and_blade_1_1_default_item_pickup_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| float | [GetItemScoreForAgent](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_item_pickup_model.html#ac28b98dda9e86f9a53cfed78bf043aa9) ([SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html) item, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| bool | [IsItemAvailableForAgent](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_item_pickup_model.html#abc43e98c1df3b5236cfab9d29a174581) ([SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html) item, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) slotToPickUp) |
| bool | [IsAgentEquipmentSuitableForPickUpAvailability](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_item_pickup_model.html#a7bb756480601c8bbd295f2fcefe6fa77) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_item_pickup_model.html#ac28b98dda9e86f9a53cfed78bf043aa9)GetItemScoreForAgent()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.ComponentInterfaces.ItemPickupModel.GetItemScoreForAgent | ( | [SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html) | *item*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* ) | | abstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_item_pickup_model.html#abc43e98c1df3b5236cfab9d29a174581)IsItemAvailableForAgent()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.ComponentInterfaces.ItemPickupModel.IsItemAvailableForAgent | ( | [SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html) | *item*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *slotToPickUp* ) | | abstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_item_pickup_model.html#a7bb756480601c8bbd295f2fcefe6fa77)IsAgentEquipmentSuitableForPickUpAvailability()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.ComponentInterfaces.ItemPickupModel.IsAgentEquipmentSuitableForPickUpAvailability | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | abstract |

