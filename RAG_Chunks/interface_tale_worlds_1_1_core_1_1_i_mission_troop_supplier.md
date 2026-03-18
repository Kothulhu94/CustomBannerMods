--- SOURCE: interface_tale_worlds_1_1_core_1_1_i_mission_troop_supplier.html ---

TaleWorlds.Core.IMissionTroopSupplier Interface ReferenceInherited by [TaleWorlds.CampaignSystem.TroopSuppliers.PartyGroupTroopSupplier](class_tale_worlds_1_1_campaign_system_1_1_troop_suppliers_1_1_party_group_troop_supplier.html), and [TaleWorlds.MountAndBlade.CustomBattleTroopSupplier](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_troop_supplier.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| IEnumerable< [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) > | [SupplyTroops](interface_tale_worlds_1_1_core_1_1_i_mission_troop_supplier.html#a3b8bca07be7be57be64ccf0bad18cdc1) (int numberToAllocate) |
| [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) | [SupplyOneTroop](interface_tale_worlds_1_1_core_1_1_i_mission_troop_supplier.html#a11c432fa5d71d3975c13a6f50204cec3) () |
| IEnumerable< [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) > | [GetAllTroops](interface_tale_worlds_1_1_core_1_1_i_mission_troop_supplier.html#aca254fd48f4c18a1b762d3d4f83a1c86) () |
| [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | [GetGeneralCharacter](interface_tale_worlds_1_1_core_1_1_i_mission_troop_supplier.html#ade41bce7cc56033df13d609ce9fcec1f) () |
| int | [GetNumberOfPlayerControllableTroops](interface_tale_worlds_1_1_core_1_1_i_mission_troop_supplier.html#a7b0a382e8a111de2053ce9e89d1c6d27) () |

|  |  |
| --- | --- |
| Properties | |
| int | [NumRemovedTroops](interface_tale_worlds_1_1_core_1_1_i_mission_troop_supplier.html#abeabac08f1c534f896a01f64ab1e43de) `[get]` |
| int | [NumTroopsNotSupplied](interface_tale_worlds_1_1_core_1_1_i_mission_troop_supplier.html#aedaae926f0af683c179f5b2ccf45f74d) `[get]` |
| bool | [AnyTroopRemainsToBeSupplied](interface_tale_worlds_1_1_core_1_1_i_mission_troop_supplier.html#a5bade452a4221c4fc9f63650fe096af5) `[get]` |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_core_1_1_i_mission_troop_supplier.html#a3b8bca07be7be57be64ccf0bad18cdc1)SupplyTroops()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| IEnumerable< [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) > TaleWorlds.Core.IMissionTroopSupplier.SupplyTroops | ( | int | *numberToAllocate* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.TroopSuppliers.PartyGroupTroopSupplier](class_tale_worlds_1_1_campaign_system_1_1_troop_suppliers_1_1_party_group_troop_supplier.html#af77738fc8b6fe79a6a12229932668f07), and [TaleWorlds.MountAndBlade.CustomBattleTroopSupplier](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_troop_supplier.html#a799132e9ada710bc92270c4269db6b29).

[◆](interface_tale_worlds_1_1_core_1_1_i_mission_troop_supplier.html#a11c432fa5d71d3975c13a6f50204cec3)SupplyOneTroop()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) TaleWorlds.Core.IMissionTroopSupplier.SupplyOneTroop | ( |  | ) |  |

Implemented in [TaleWorlds.CampaignSystem.TroopSuppliers.PartyGroupTroopSupplier](class_tale_worlds_1_1_campaign_system_1_1_troop_suppliers_1_1_party_group_troop_supplier.html#ad2f73b42ff7a46b0582756ce34b4a10c), and [TaleWorlds.MountAndBlade.CustomBattleTroopSupplier](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_troop_supplier.html#a1127dd3510748de4e8da7bb8a9543f92).

[◆](interface_tale_worlds_1_1_core_1_1_i_mission_troop_supplier.html#aca254fd48f4c18a1b762d3d4f83a1c86)GetAllTroops()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) > TaleWorlds.Core.IMissionTroopSupplier.GetAllTroops | ( |  | ) |  |

Implemented in [TaleWorlds.CampaignSystem.TroopSuppliers.PartyGroupTroopSupplier](class_tale_worlds_1_1_campaign_system_1_1_troop_suppliers_1_1_party_group_troop_supplier.html#ab87feebfb75a291f6ea7b4f0f069b3af), and [TaleWorlds.MountAndBlade.CustomBattleTroopSupplier](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_troop_supplier.html#acfc36e6cce9672fc5022bdbfa0088883).

[◆](interface_tale_worlds_1_1_core_1_1_i_mission_troop_supplier.html#ade41bce7cc56033df13d609ce9fcec1f)GetGeneralCharacter()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) TaleWorlds.Core.IMissionTroopSupplier.GetGeneralCharacter | ( |  | ) |  |

Implemented in [TaleWorlds.CampaignSystem.TroopSuppliers.PartyGroupTroopSupplier](class_tale_worlds_1_1_campaign_system_1_1_troop_suppliers_1_1_party_group_troop_supplier.html#a900cb3688ae1804b3a2caaf56ef5f5a1), and [TaleWorlds.MountAndBlade.CustomBattleTroopSupplier](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_troop_supplier.html#ade5b4efa4323a41db8e6bcd087b45351).

[◆](interface_tale_worlds_1_1_core_1_1_i_mission_troop_supplier.html#a7b0a382e8a111de2053ce9e89d1c6d27)GetNumberOfPlayerControllableTroops()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.Core.IMissionTroopSupplier.GetNumberOfPlayerControllableTroops | ( |  | ) |  |

Implemented in [TaleWorlds.CampaignSystem.TroopSuppliers.PartyGroupTroopSupplier](class_tale_worlds_1_1_campaign_system_1_1_troop_suppliers_1_1_party_group_troop_supplier.html#ace44e7cb2d5cf86e26d7b3737840d750), and [TaleWorlds.MountAndBlade.CustomBattleTroopSupplier](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_troop_supplier.html#a0617c8aacee35a87bb48500db3fc32b0).

Property Documentation
----------------------

[◆](interface_tale_worlds_1_1_core_1_1_i_mission_troop_supplier.html#abeabac08f1c534f896a01f64ab1e43de)NumRemovedTroops
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.IMissionTroopSupplier.NumRemovedTroops | | get |

Implemented in [TaleWorlds.CampaignSystem.TroopSuppliers.PartyGroupTroopSupplier](class_tale_worlds_1_1_campaign_system_1_1_troop_suppliers_1_1_party_group_troop_supplier.html#ad642d3a9480ff157befc162d847f1bf6), and [TaleWorlds.MountAndBlade.CustomBattleTroopSupplier](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_troop_supplier.html#a06d4f3f343f42891e85dc688ac8eb9f0).

[◆](interface_tale_worlds_1_1_core_1_1_i_mission_troop_supplier.html#aedaae926f0af683c179f5b2ccf45f74d)NumTroopsNotSupplied
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.IMissionTroopSupplier.NumTroopsNotSupplied | | get |

Implemented in [TaleWorlds.CampaignSystem.TroopSuppliers.PartyGroupTroopSupplier](class_tale_worlds_1_1_campaign_system_1_1_troop_suppliers_1_1_party_group_troop_supplier.html#a07823be177461f2d021d42f185f47f7b), and [TaleWorlds.MountAndBlade.CustomBattleTroopSupplier](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_troop_supplier.html#a08fbc16aed339b6223a43d71109d3e08).

[◆](interface_tale_worlds_1_1_core_1_1_i_mission_troop_supplier.html#a5bade452a4221c4fc9f63650fe096af5)AnyTroopRemainsToBeSupplied
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.IMissionTroopSupplier.AnyTroopRemainsToBeSupplied | | get |

Implemented in [TaleWorlds.CampaignSystem.TroopSuppliers.PartyGroupTroopSupplier](class_tale_worlds_1_1_campaign_system_1_1_troop_suppliers_1_1_party_group_troop_supplier.html#afd1d8357292834513f4524767cc68add), and [TaleWorlds.MountAndBlade.CustomBattleTroopSupplier](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_troop_supplier.html#aaa5b82d532a41e540d6a8a7f285e3a10).

