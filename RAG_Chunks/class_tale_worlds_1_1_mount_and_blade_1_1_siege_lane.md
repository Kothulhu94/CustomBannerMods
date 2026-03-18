--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html ---

TaleWorlds.MountAndBlade.SiegeLane Class Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [LaneStateEnum](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a0c0bd6c8a4c645d3cc11775f37eaff43) {     [Safe](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a0c0bd6c8a4c645d3cc11775f37eaff43ac6eea0560cd6f377e78dff2c85cc9122) = 0 ,     [Unused](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a0c0bd6c8a4c645d3cc11775f37eaff43a92e592d90b9548016776a6fb68dccded) = 1 ,     [Used](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a0c0bd6c8a4c645d3cc11775f37eaff43a019d1ca7d50cc54b995f60d456435e87) = 2 ,     [Active](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a0c0bd6c8a4c645d3cc11775f37eaff43a4d3d769b812b6faa6b76e1a8abaece2d) = 3 ,     [Abandoned](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a0c0bd6c8a4c645d3cc11775f37eaff43a255de8cd6ee11ed4dc01a19844c1271e) = 4 ,     [Contested](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a0c0bd6c8a4c645d3cc11775f37eaff43aa48d8d496b0d2191a227a4915777d16d) = 5 ,     [Conceited](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a0c0bd6c8a4c645d3cc11775f37eaff43a21d2a6c3839f88dfb504c5192af2c261) = 6   } |
| enum | [LaneDefenseStates](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a6fd299fdf29d3d6467dc8823366c048a) {     [Empty](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a6fd299fdf29d3d6467dc8823366c048aace2c8aed9c2fa0cfbed56cbda4d8bf07) ,     [Token](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a6fd299fdf29d3d6467dc8823366c048aa459a6f79ad9b13cbcb5f692d2cc7a94d) ,     [Full](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a6fd299fdf29d3d6467dc8823366c048aabbd47109890259c0127154db1af26c75)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [SiegeLane](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a56de9a71b56dbcb689d10d66ebc2103b) ([FormationAI.BehaviorSide](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#af0e557fbaea88404cb872c1bc2b7912b) laneSide, [SiegeQuerySystem](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html) siegeQuerySystem) |
| bool | [CalculateIsLaneUnusable](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#ada00b967d259a67c91de67196d9bd5e5) () |
| [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | [GetLastAssignedFormation](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a0cc1a2c80fb1ab3a39bbb6f2fb84010b) (int teamIndex) |
| void | [SetLaneState](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a3fcd31a3d6ba1966b5c0a0239be88d85) ([LaneStateEnum](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a0c0bd6c8a4c645d3cc11775f37eaff43) newLaneState) |
| void | [SetLastAssignedFormation](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a95d5d0dfe51a3fc1caa8640d9f0ce8b1) (int teamIndex, [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| void | [SetSiegeQuerySystem](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a152d6f45ff1dd12e122d26cfd668f1ca) ([SiegeQuerySystem](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html) siegeQuerySystem) |
| float | [CalculateLaneCapacity](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a01b805f02a4e0f6d34a930b0ce0848b0) () |
| [LaneDefenseStates](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a6fd299fdf29d3d6467dc8823366c048a) | [GetDefenseState](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a980a9cbc87a5b1ea9634e7cac20b10d8) () |
| bool | [IsUnderAttack](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a2a41d1a444fbbd448d60f57a07dcbce6) () |
| bool | [IsDefended](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a2595da317b674990ad017138249893dc) () |
| void | [DetermineLaneState](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a4bbc8c5727767452cae63fc6f432500b) () |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | [GetCurrentAttackerPosition](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a28fa5b853e64d493ef92da538b603974) () |
| void | [DetermineOrigins](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a12fbdd0bd315be08987d82c6b035aa9c) () |
| void | [RefreshLane](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a1644a8c972abb9a5120ae42dc825055a) () |
| void | [SetPrimarySiegeWeapons](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a8cda36d0e725753266cc1edb06567718) (List< [IPrimarySiegeWeapon](interface_tale_worlds_1_1_mount_and_blade_1_1_i_primary_siege_weapon.html) > primarySiegeWeapons) |
| void | [SetDefensePoints](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#ac66fadee6959216b52cd1b5ebc213474) (List< [ICastleKeyPosition](interface_tale_worlds_1_1_mount_and_blade_1_1_i_castle_key_position.html) > defensePoints) |

|  |  |
| --- | --- |
| Properties | |
| [LaneStateEnum](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a0c0bd6c8a4c645d3cc11775f37eaff43) | [LaneState](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#aea4d4064bffc5f8a961a6d8288a275db) `[get]` |
| [FormationAI.BehaviorSide](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#af0e557fbaea88404cb872c1bc2b7912b) | [LaneSide](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a601c0c040fe00f0bca47c7d0911944fd) `[get]` |
| List< [IPrimarySiegeWeapon](interface_tale_worlds_1_1_mount_and_blade_1_1_i_primary_siege_weapon.html) > | [PrimarySiegeWeapons](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#ad64ac7c6e07b47a4852021f321d8c37f) `[get]` |
| bool | [IsOpen](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#abf84a44e4f83b9c56e510e9a042f5ddd) `[get]` |
| bool | [IsBreach](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a85719d4770863300cb8bbd2e30130f45) `[get]` |
| bool | [HasGate](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#aad8dd3bd91d6cad93707c09b030b08b5) `[get]` |
| List< [ICastleKeyPosition](interface_tale_worlds_1_1_mount_and_blade_1_1_i_castle_key_position.html) > | [DefensePoints](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a943304740fcd78f4c8f23ed0345d1a6e) `[get]` |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | [DefenderOrigin](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#ac81bf8bee638b3df880eed73ad93bec3) `[get]` |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | [AttackerOrigin](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a6c28f013eb55d727d00a1a92752ff4f3) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a0c0bd6c8a4c645d3cc11775f37eaff43)LaneStateEnum
-------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.SiegeLane.LaneStateEnum](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a0c0bd6c8a4c645d3cc11775f37eaff43) |

| Enumerator | |
| --- | --- |
| Safe |  |
| Unused |  |
| Used |  |
| Active |  |
| Abandoned |  |
| Contested |  |
| Conceited |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a6fd299fdf29d3d6467dc8823366c048a)LaneDefenseStates
-----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.SiegeLane.LaneDefenseStates](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a6fd299fdf29d3d6467dc8823366c048a) |

| Enumerator | |
| --- | --- |
| Empty |  |
| Token |  |
| Full |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a56de9a71b56dbcb689d10d66ebc2103b)SiegeLane()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.SiegeLane.SiegeLane | ( | [FormationAI.BehaviorSide](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#af0e557fbaea88404cb872c1bc2b7912b) | *laneSide*, |
|  |  | [SiegeQuerySystem](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html) | *siegeQuerySystem* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#ada00b967d259a67c91de67196d9bd5e5)CalculateIsLaneUnusable()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.SiegeLane.CalculateIsLaneUnusable | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a0cc1a2c80fb1ab3a39bbb6f2fb84010b)GetLastAssignedFormation()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) TaleWorlds.MountAndBlade.SiegeLane.GetLastAssignedFormation | ( | int | *teamIndex* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a3fcd31a3d6ba1966b5c0a0239be88d85)SetLaneState()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SiegeLane.SetLaneState | ( | [LaneStateEnum](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a0c0bd6c8a4c645d3cc11775f37eaff43) | *newLaneState* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a95d5d0dfe51a3fc1caa8640d9f0ce8b1)SetLastAssignedFormation()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SiegeLane.SetLastAssignedFormation | ( | int | *teamIndex*, |
|  |  | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a152d6f45ff1dd12e122d26cfd668f1ca)SetSiegeQuerySystem()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SiegeLane.SetSiegeQuerySystem | ( | [SiegeQuerySystem](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html) | *siegeQuerySystem* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a01b805f02a4e0f6d34a930b0ce0848b0)CalculateLaneCapacity()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.SiegeLane.CalculateLaneCapacity | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a980a9cbc87a5b1ea9634e7cac20b10d8)GetDefenseState()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [LaneDefenseStates](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a6fd299fdf29d3d6467dc8823366c048a) TaleWorlds.MountAndBlade.SiegeLane.GetDefenseState | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a2a41d1a444fbbd448d60f57a07dcbce6)IsUnderAttack()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.SiegeLane.IsUnderAttack | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a2595da317b674990ad017138249893dc)IsDefended()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.SiegeLane.IsDefended | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a4bbc8c5727767452cae63fc6f432500b)DetermineLaneState()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SiegeLane.DetermineLaneState | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a28fa5b853e64d493ef92da538b603974)GetCurrentAttackerPosition()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) TaleWorlds.MountAndBlade.SiegeLane.GetCurrentAttackerPosition | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a12fbdd0bd315be08987d82c6b035aa9c)DetermineOrigins()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SiegeLane.DetermineOrigins | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a1644a8c972abb9a5120ae42dc825055a)RefreshLane()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SiegeLane.RefreshLane | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a8cda36d0e725753266cc1edb06567718)SetPrimarySiegeWeapons()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SiegeLane.SetPrimarySiegeWeapons | ( | List< [IPrimarySiegeWeapon](interface_tale_worlds_1_1_mount_and_blade_1_1_i_primary_siege_weapon.html) > | *primarySiegeWeapons* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#ac66fadee6959216b52cd1b5ebc213474)SetDefensePoints()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SiegeLane.SetDefensePoints | ( | List< [ICastleKeyPosition](interface_tale_worlds_1_1_mount_and_blade_1_1_i_castle_key_position.html) > | *defensePoints* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#aea4d4064bffc5f8a961a6d8288a275db)LaneState
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [LaneStateEnum](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a0c0bd6c8a4c645d3cc11775f37eaff43) TaleWorlds.MountAndBlade.SiegeLane.LaneState | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a601c0c040fe00f0bca47c7d0911944fd)LaneSide
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [FormationAI.BehaviorSide](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#af0e557fbaea88404cb872c1bc2b7912b) TaleWorlds.MountAndBlade.SiegeLane.LaneSide | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#ad64ac7c6e07b47a4852021f321d8c37f)PrimarySiegeWeapons
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[IPrimarySiegeWeapon](interface_tale_worlds_1_1_mount_and_blade_1_1_i_primary_siege_weapon.html)> TaleWorlds.MountAndBlade.SiegeLane.PrimarySiegeWeapons | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#abf84a44e4f83b9c56e510e9a042f5ddd)IsOpen
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.SiegeLane.IsOpen | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a85719d4770863300cb8bbd2e30130f45)IsBreach
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.SiegeLane.IsBreach | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#aad8dd3bd91d6cad93707c09b030b08b5)HasGate
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.SiegeLane.HasGate | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a943304740fcd78f4c8f23ed0345d1a6e)DefensePoints
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[ICastleKeyPosition](interface_tale_worlds_1_1_mount_and_blade_1_1_i_castle_key_position.html)> TaleWorlds.MountAndBlade.SiegeLane.DefensePoints | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#ac81bf8bee638b3df880eed73ad93bec3)DefenderOrigin
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) TaleWorlds.MountAndBlade.SiegeLane.DefenderOrigin | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html#a6c28f013eb55d727d00a1a92752ff4f3)AttackerOrigin
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) TaleWorlds.MountAndBlade.SiegeLane.AttackerOrigin | | get |

