--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_troop_supplier.html ---

TaleWorlds.MountAndBlade.CustomBattleTroopSupplier Class ReferenceInherits [TaleWorlds.Core.IMissionTroopSupplier](interface_tale_worlds_1_1_core_1_1_i_mission_troop_supplier.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [CustomBattleTroopSupplier](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_troop_supplier.html#a5e1f2007beb23851804003a66d7f71e2) ([CustomBattleCombatant](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html) customBattleCombatant, bool isPlayerSide, bool isPlayerGeneral, bool isSallyOut, Func< [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html), bool > customAllocationConditions=null) |
| IEnumerable< [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) > | [SupplyTroops](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_troop_supplier.html#a799132e9ada710bc92270c4269db6b29) (int numberToAllocate) |
| [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) | [SupplyOneTroop](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_troop_supplier.html#a1127dd3510748de4e8da7bb8a9543f92) () |
| IEnumerable< [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) > | [GetAllTroops](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_troop_supplier.html#acfc36e6cce9672fc5022bdbfa0088883) () |
| [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | [GetGeneralCharacter](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_troop_supplier.html#ade5b4efa4323a41db8e6bcd087b45351) () |
| void | [OnTroopWounded](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_troop_supplier.html#ae9d04540547b752baadfc75d1d040650) () |
| void | [OnTroopKilled](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_troop_supplier.html#a43c844c5f49c49438440a02c9d54cf85) () |
| void | [OnTroopRouted](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_troop_supplier.html#acb58f9d9368bc73ec7f12b56ccff9c0c) () |
| int | [GetNumberOfPlayerControllableTroops](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_troop_supplier.html#a0617c8aacee35a87bb48500db3fc32b0) () |

|  |  |
| --- | --- |
| Properties | |
| int | [NumRemovedTroops](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_troop_supplier.html#a06d4f3f343f42891e85dc688ac8eb9f0) `[get]` |
| int | [NumTroopsNotSupplied](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_troop_supplier.html#a08fbc16aed339b6223a43d71109d3e08) `[get]` |
| bool | [AnyTroopRemainsToBeSupplied](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_troop_supplier.html#aaa5b82d532a41e540d6a8a7f285e3a10) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_troop_supplier.html#a5e1f2007beb23851804003a66d7f71e2)CustomBattleTroopSupplier()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.CustomBattleTroopSupplier.CustomBattleTroopSupplier | ( | [CustomBattleCombatant](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html) | *customBattleCombatant*, |
|  |  | bool | *isPlayerSide*, |
|  |  | bool | *isPlayerGeneral*, |
|  |  | bool | *isSallyOut*, |
|  |  | Func< [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html), bool > | *customAllocationConditions* = null ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_troop_supplier.html#a799132e9ada710bc92270c4269db6b29)SupplyTroops()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| IEnumerable< [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) > TaleWorlds.MountAndBlade.CustomBattleTroopSupplier.SupplyTroops | ( | int | *numberToAllocate* | ) |  |

Implements [TaleWorlds.Core.IMissionTroopSupplier](interface_tale_worlds_1_1_core_1_1_i_mission_troop_supplier.html#a3b8bca07be7be57be64ccf0bad18cdc1).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_troop_supplier.html#a1127dd3510748de4e8da7bb8a9543f92)SupplyOneTroop()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) TaleWorlds.MountAndBlade.CustomBattleTroopSupplier.SupplyOneTroop | ( |  | ) |  |

Implements [TaleWorlds.Core.IMissionTroopSupplier](interface_tale_worlds_1_1_core_1_1_i_mission_troop_supplier.html#a11c432fa5d71d3975c13a6f50204cec3).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_troop_supplier.html#acfc36e6cce9672fc5022bdbfa0088883)GetAllTroops()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) > TaleWorlds.MountAndBlade.CustomBattleTroopSupplier.GetAllTroops | ( |  | ) |  |

Implements [TaleWorlds.Core.IMissionTroopSupplier](interface_tale_worlds_1_1_core_1_1_i_mission_troop_supplier.html#aca254fd48f4c18a1b762d3d4f83a1c86).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_troop_supplier.html#ade5b4efa4323a41db8e6bcd087b45351)GetGeneralCharacter()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) TaleWorlds.MountAndBlade.CustomBattleTroopSupplier.GetGeneralCharacter | ( |  | ) |  |

Implements [TaleWorlds.Core.IMissionTroopSupplier](interface_tale_worlds_1_1_core_1_1_i_mission_troop_supplier.html#ade41bce7cc56033df13d609ce9fcec1f).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_troop_supplier.html#ae9d04540547b752baadfc75d1d040650)OnTroopWounded()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.CustomBattleTroopSupplier.OnTroopWounded | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_troop_supplier.html#a43c844c5f49c49438440a02c9d54cf85)OnTroopKilled()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.CustomBattleTroopSupplier.OnTroopKilled | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_troop_supplier.html#acb58f9d9368bc73ec7f12b56ccff9c0c)OnTroopRouted()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.CustomBattleTroopSupplier.OnTroopRouted | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_troop_supplier.html#a0617c8aacee35a87bb48500db3fc32b0)GetNumberOfPlayerControllableTroops()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.CustomBattleTroopSupplier.GetNumberOfPlayerControllableTroops | ( |  | ) |  |

Implements [TaleWorlds.Core.IMissionTroopSupplier](interface_tale_worlds_1_1_core_1_1_i_mission_troop_supplier.html#a7b0a382e8a111de2053ce9e89d1c6d27).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_troop_supplier.html#a06d4f3f343f42891e85dc688ac8eb9f0)NumRemovedTroops
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.CustomBattleTroopSupplier.NumRemovedTroops | | get |

Implements [TaleWorlds.Core.IMissionTroopSupplier](interface_tale_worlds_1_1_core_1_1_i_mission_troop_supplier.html#abeabac08f1c534f896a01f64ab1e43de).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_troop_supplier.html#a08fbc16aed339b6223a43d71109d3e08)NumTroopsNotSupplied
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.CustomBattleTroopSupplier.NumTroopsNotSupplied | | get |

Implements [TaleWorlds.Core.IMissionTroopSupplier](interface_tale_worlds_1_1_core_1_1_i_mission_troop_supplier.html#aedaae926f0af683c179f5b2ccf45f74d).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_troop_supplier.html#aaa5b82d532a41e540d6a8a7f285e3a10)AnyTroopRemainsToBeSupplied
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.CustomBattleTroopSupplier.AnyTroopRemainsToBeSupplied | | get |

Implements [TaleWorlds.Core.IMissionTroopSupplier](interface_tale_worlds_1_1_core_1_1_i_mission_troop_supplier.html#a5bade452a4221c4fc9f63650fe096af5).

