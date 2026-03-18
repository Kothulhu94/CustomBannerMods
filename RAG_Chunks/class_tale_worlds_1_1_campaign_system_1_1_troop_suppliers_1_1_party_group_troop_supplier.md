--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_troop_suppliers_1_1_party_group_troop_supplier.html ---

TaleWorlds.CampaignSystem.TroopSuppliers.PartyGroupTroopSupplier Class ReferenceInherits [TaleWorlds.Core.IMissionTroopSupplier](interface_tale_worlds_1_1_core_1_1_i_mission_troop_supplier.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [PartyGroupTroopSupplier](class_tale_worlds_1_1_campaign_system_1_1_troop_suppliers_1_1_party_group_troop_supplier.html#a8ac2df2f7480a6d0c7096e88ae3cd2b9) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) mapEvent, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) priorTroops=null, Func< [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html), [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html), bool > customAllocationConditions=null) |
| IEnumerable< [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) > | [SupplyTroops](class_tale_worlds_1_1_campaign_system_1_1_troop_suppliers_1_1_party_group_troop_supplier.html#af77738fc8b6fe79a6a12229932668f07) (int numberToAllocate) |
| [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) | [SupplyOneTroop](class_tale_worlds_1_1_campaign_system_1_1_troop_suppliers_1_1_party_group_troop_supplier.html#ad2f73b42ff7a46b0582756ce34b4a10c) () |
| IEnumerable< [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) > | [GetAllTroops](class_tale_worlds_1_1_campaign_system_1_1_troop_suppliers_1_1_party_group_troop_supplier.html#ab87feebfb75a291f6ea7b4f0f069b3af) () |
| [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | [GetGeneralCharacter](class_tale_worlds_1_1_campaign_system_1_1_troop_suppliers_1_1_party_group_troop_supplier.html#a900cb3688ae1804b3a2caaf56ef5f5a1) () |
| int | [GetNumberOfPlayerControllableTroops](class_tale_worlds_1_1_campaign_system_1_1_troop_suppliers_1_1_party_group_troop_supplier.html#ace44e7cb2d5cf86e26d7b3737840d750) () |
| void | [OnTroopWounded](class_tale_worlds_1_1_campaign_system_1_1_troop_suppliers_1_1_party_group_troop_supplier.html#afb59aaa2a3761b242170833e7a28eb74) ([UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) troopDescriptor) |
| void | [OnTroopKilled](class_tale_worlds_1_1_campaign_system_1_1_troop_suppliers_1_1_party_group_troop_supplier.html#a022f4d2e3ee5359c372d5ae275d80171) ([UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) troopDescriptor) |
| void | [OnTroopRouted](class_tale_worlds_1_1_campaign_system_1_1_troop_suppliers_1_1_party_group_troop_supplier.html#a6949852f53631311ed538a761211abbc) ([UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) troopDescriptor, bool isOrderRetreat) |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | [GetParty](class_tale_worlds_1_1_campaign_system_1_1_troop_suppliers_1_1_party_group_troop_supplier.html#ab448828f954b8aaf0b512113910a688e) ([UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) troopDescriptor) |
| void | [OnTroopScoreHit](class_tale_worlds_1_1_campaign_system_1_1_troop_suppliers_1_1_party_group_troop_supplier.html#aefed4f2623e1ac993d48c68118d0b6b6) ([UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) descriptor, [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) attackedCharacter, int damage, bool isFatal, bool isTeamKill, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon) |

|  |  |
| --- | --- |
| Properties | |
| int | [NumRemovedTroops](class_tale_worlds_1_1_campaign_system_1_1_troop_suppliers_1_1_party_group_troop_supplier.html#ad642d3a9480ff157befc162d847f1bf6) `[get]` |
| int | [NumTroopsNotSupplied](class_tale_worlds_1_1_campaign_system_1_1_troop_suppliers_1_1_party_group_troop_supplier.html#a07823be177461f2d021d42f185f47f7b) `[get]` |
| bool | [AnyTroopRemainsToBeSupplied](class_tale_worlds_1_1_campaign_system_1_1_troop_suppliers_1_1_party_group_troop_supplier.html#afd1d8357292834513f4524767cc68add) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_troop_suppliers_1_1_party_group_troop_supplier.html#a8ac2df2f7480a6d0c7096e88ae3cd2b9)PartyGroupTroopSupplier()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.TroopSuppliers.PartyGroupTroopSupplier.PartyGroupTroopSupplier | ( | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *mapEvent*, |
|  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side*, |
|  |  | [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) | *priorTroops* = null, |
|  |  | Func< [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html), [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html), bool > | *customAllocationConditions* = null ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_troop_suppliers_1_1_party_group_troop_supplier.html#af77738fc8b6fe79a6a12229932668f07)SupplyTroops()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| IEnumerable< [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) > TaleWorlds.CampaignSystem.TroopSuppliers.PartyGroupTroopSupplier.SupplyTroops | ( | int | *numberToAllocate* | ) |  |

Implements [TaleWorlds.Core.IMissionTroopSupplier](interface_tale_worlds_1_1_core_1_1_i_mission_troop_supplier.html#a3b8bca07be7be57be64ccf0bad18cdc1).

[◆](class_tale_worlds_1_1_campaign_system_1_1_troop_suppliers_1_1_party_group_troop_supplier.html#ad2f73b42ff7a46b0582756ce34b4a10c)SupplyOneTroop()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) TaleWorlds.CampaignSystem.TroopSuppliers.PartyGroupTroopSupplier.SupplyOneTroop | ( |  | ) |  |

Implements [TaleWorlds.Core.IMissionTroopSupplier](interface_tale_worlds_1_1_core_1_1_i_mission_troop_supplier.html#a11c432fa5d71d3975c13a6f50204cec3).

[◆](class_tale_worlds_1_1_campaign_system_1_1_troop_suppliers_1_1_party_group_troop_supplier.html#ab87feebfb75a291f6ea7b4f0f069b3af)GetAllTroops()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) > TaleWorlds.CampaignSystem.TroopSuppliers.PartyGroupTroopSupplier.GetAllTroops | ( |  | ) |  |

Implements [TaleWorlds.Core.IMissionTroopSupplier](interface_tale_worlds_1_1_core_1_1_i_mission_troop_supplier.html#aca254fd48f4c18a1b762d3d4f83a1c86).

[◆](class_tale_worlds_1_1_campaign_system_1_1_troop_suppliers_1_1_party_group_troop_supplier.html#a900cb3688ae1804b3a2caaf56ef5f5a1)GetGeneralCharacter()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) TaleWorlds.CampaignSystem.TroopSuppliers.PartyGroupTroopSupplier.GetGeneralCharacter | ( |  | ) |  |

Implements [TaleWorlds.Core.IMissionTroopSupplier](interface_tale_worlds_1_1_core_1_1_i_mission_troop_supplier.html#ade41bce7cc56033df13d609ce9fcec1f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_troop_suppliers_1_1_party_group_troop_supplier.html#ace44e7cb2d5cf86e26d7b3737840d750)GetNumberOfPlayerControllableTroops()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.TroopSuppliers.PartyGroupTroopSupplier.GetNumberOfPlayerControllableTroops | ( |  | ) |  |

Implements [TaleWorlds.Core.IMissionTroopSupplier](interface_tale_worlds_1_1_core_1_1_i_mission_troop_supplier.html#a7b0a382e8a111de2053ce9e89d1c6d27).

[◆](class_tale_worlds_1_1_campaign_system_1_1_troop_suppliers_1_1_party_group_troop_supplier.html#afb59aaa2a3761b242170833e7a28eb74)OnTroopWounded()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.TroopSuppliers.PartyGroupTroopSupplier.OnTroopWounded | ( | [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) | *troopDescriptor* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_troop_suppliers_1_1_party_group_troop_supplier.html#a022f4d2e3ee5359c372d5ae275d80171)OnTroopKilled()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.TroopSuppliers.PartyGroupTroopSupplier.OnTroopKilled | ( | [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) | *troopDescriptor* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_troop_suppliers_1_1_party_group_troop_supplier.html#a6949852f53631311ed538a761211abbc)OnTroopRouted()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.TroopSuppliers.PartyGroupTroopSupplier.OnTroopRouted | ( | [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) | *troopDescriptor*, |
|  |  | bool | *isOrderRetreat* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_troop_suppliers_1_1_party_group_troop_supplier.html#ab448828f954b8aaf0b512113910a688e)GetParty()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) TaleWorlds.CampaignSystem.TroopSuppliers.PartyGroupTroopSupplier.GetParty | ( | [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) | *troopDescriptor* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_troop_suppliers_1_1_party_group_troop_supplier.html#aefed4f2623e1ac993d48c68118d0b6b6)OnTroopScoreHit()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.TroopSuppliers.PartyGroupTroopSupplier.OnTroopScoreHit | ( | [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) | *descriptor*, |
|  |  | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *attackedCharacter*, |
|  |  | int | *damage*, |
|  |  | bool | *isFatal*, |
|  |  | bool | *isTeamKill*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_troop_suppliers_1_1_party_group_troop_supplier.html#ad642d3a9480ff157befc162d847f1bf6)NumRemovedTroops
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.TroopSuppliers.PartyGroupTroopSupplier.NumRemovedTroops | | get |

Implements [TaleWorlds.Core.IMissionTroopSupplier](interface_tale_worlds_1_1_core_1_1_i_mission_troop_supplier.html#abeabac08f1c534f896a01f64ab1e43de).

[◆](class_tale_worlds_1_1_campaign_system_1_1_troop_suppliers_1_1_party_group_troop_supplier.html#a07823be177461f2d021d42f185f47f7b)NumTroopsNotSupplied
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.TroopSuppliers.PartyGroupTroopSupplier.NumTroopsNotSupplied | | get |

Implements [TaleWorlds.Core.IMissionTroopSupplier](interface_tale_worlds_1_1_core_1_1_i_mission_troop_supplier.html#aedaae926f0af683c179f5b2ccf45f74d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_troop_suppliers_1_1_party_group_troop_supplier.html#afd1d8357292834513f4524767cc68add)AnyTroopRemainsToBeSupplied
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.TroopSuppliers.PartyGroupTroopSupplier.AnyTroopRemainsToBeSupplied | | get |

Implements [TaleWorlds.Core.IMissionTroopSupplier](interface_tale_worlds_1_1_core_1_1_i_mission_troop_supplier.html#a5bade452a4221c4fc9f63650fe096af5).

