--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html ---

TaleWorlds.MountAndBlade.TeamQuerySystem Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
| void | [Expire](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#ad6ee4fbb86b584a949cb1cb3ac8dcfa4) () |
| void | [ExpireAfterUnitAddRemove](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a17b422171833c9c598a531f56b808fdc) () |
|  | [TeamQuerySystem](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#aca92eb5f6a00246f3ea9235a278c5a66) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a4c773155ebc70ead97a8374a273750f0) team) |
| void | [RegisterDeath](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a8c84c900dad15faf8d8963b2c58cdea4) () |
| void | [RegisterDeathByRanged](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a024dd79502ba740f9faa9625dfb57eb8) () |
| float | [GetLocalAllyPower](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#af04040b9da9e8cfb2409efd488379d12) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) target) |
| float | [GetLocalEnemyPower](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a1040d509ed587b46fc2396595765026b) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) target) |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly Team | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a4c773155ebc70ead97a8374a273750f0) |

|  |  |
| --- | --- |
| Properties | |
| int | [MemberCount](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#ad63ecd1808073bb9725809c7b555c3ff) `[get]` |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | [MedianPosition](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#ab8e34eb67ccd5d6e26ee4ed3c6c27bf4) `[get]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [AveragePosition](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a6c709606b00cccf346190e70dcb6c502) `[get]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [AverageEnemyPosition](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#aa0a941dc70248bec1de2be046f598533) `[get]` |
| [FormationQuerySystem](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html) | [MedianTargetFormation](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#aedfae3716d42a87f5bdf215a196b1e60) `[get]` |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | [MedianTargetFormationPosition](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a3eb77d6976aaf13b309c42e8692e766d) `[get]` |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | [LeftFlankEdgePosition](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a6d2bf4b647dd2e28f965830a6ddf1eda) `[get]` |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | [RightFlankEdgePosition](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#af8e6308d75005e9e6fe58f34cd9ac350) `[get]` |
| float | [InfantryRatio](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a7e7e1b4daa32cf06e96f790108b66738) `[get]` |
| float | [RangedRatio](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a07f491339648cddd915a05c47e63f5cb) `[get]` |
| float | [CavalryRatio](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a50aa5d318f2475bc877465770ab32bb3) `[get]` |
| float | [RangedCavalryRatio](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a1d5ef25be359360b2d85b0ff3bd65cb4) `[get]` |
| int | [AllyUnitCount](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a67285b53ce9c809c65243d447075e804) `[get]` |
| int | [EnemyUnitCount](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a42b5af9969466377b8c62ba2be06162c) `[get]` |
| float | [AllyInfantryRatio](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#aa732c0ab576c2138176420d369d1820d) `[get]` |
| float | [AllyRangedRatio](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a795565fe5ea7aca0e5e07680c27ce08d) `[get]` |
| float | [AllyCavalryRatio](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a086bad9860786b54b670e081ae6030f0) `[get]` |
| float | [AllyRangedCavalryRatio](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a0a50dcc6b7d270e32ea2eb1d1c866637) `[get]` |
| float | [EnemyInfantryRatio](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a7b7eb8dbe6f5a92c34e3e1cbb03069a1) `[get]` |
| float | [EnemyRangedRatio](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a6ac90df87c7916f5dbcc3c3f1f07e8f8) `[get]` |
| float | [EnemyCavalryRatio](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a1ce6384174540c11437e1a4dede2d0d0) `[get]` |
| float | [EnemyRangedCavalryRatio](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a298c4d5e9a2c178607b4826b3fcd1207) `[get]` |
| float | [RemainingPowerRatio](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a37899a4c318d081201deb8be015a9cec) `[get]` |
| float | [TeamPower](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#afb4f25dc5048fd8166c72e681af85ab8) `[get]` |
| float | [TotalPowerRatio](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#ab986c2431bda88086f6ba157cb7878bb) `[get]` |
| float | [InsideWallsRatio](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a088ba644ede174043d6997f1eb4e383a) `[get]` |
| [IBattlePowerCalculationLogic](interface_tale_worlds_1_1_mount_and_blade_1_1_i_battle_power_calculation_logic.html) | [BattlePowerLogic](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#af975db8badd735ab0a8f8b5edf55b674) `[get]` |
| CasualtyHandler | [CasualtyHandler](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a84acbd8ba0fa7b42b1467e7e9c7213ac) `[get]` |
| float | [MaxUnderRangedAttackRatio](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a80964316295e0a1cdc48838930b98263) `[get]` |
| int | [DeathCount](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a13bb38317e22af9cf2fd203e4a3b458c) `[get]` |
| int | [DeathByRangedCount](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a35da9d3fa699c4fb96779433ec6236e8) `[get]` |
| int | [AllyRangedUnitCount](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a8163f2ab00d8fd6f1469314528c87c9f) `[get]` |
| int | [AllCavalryUnitCount](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a5872a63f30fff85702dcf43e36b455d5) `[get]` |
| int | [EnemyRangedUnitCount](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#acf331624c8edaa2f851a15f9a3beeeb8) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#aca92eb5f6a00246f3ea9235a278c5a66)TeamQuerySystem()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.TeamQuerySystem.TeamQuerySystem | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a4c773155ebc70ead97a8374a273750f0) | *team* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#ad6ee4fbb86b584a949cb1cb3ac8dcfa4)Expire()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.TeamQuerySystem.Expire | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a17b422171833c9c598a531f56b808fdc)ExpireAfterUnitAddRemove()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.TeamQuerySystem.ExpireAfterUnitAddRemove | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a8c84c900dad15faf8d8963b2c58cdea4)RegisterDeath()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.TeamQuerySystem.RegisterDeath | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a024dd79502ba740f9faa9625dfb57eb8)RegisterDeathByRanged()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.TeamQuerySystem.RegisterDeathByRanged | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#af04040b9da9e8cfb2409efd488379d12)GetLocalAllyPower()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.TeamQuerySystem.GetLocalAllyPower | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *target* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a1040d509ed587b46fc2396595765026b)GetLocalEnemyPower()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.TeamQuerySystem.GetLocalEnemyPower | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *target* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a4c773155ebc70ead97a8374a273750f0)Team
-----------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly Team TaleWorlds.MountAndBlade.TeamQuerySystem.Team |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#ad63ecd1808073bb9725809c7b555c3ff)MemberCount
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.TeamQuerySystem.MemberCount | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#ab8e34eb67ccd5d6e26ee4ed3c6c27bf4)MedianPosition
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) TaleWorlds.MountAndBlade.TeamQuerySystem.MedianPosition | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a6c709606b00cccf346190e70dcb6c502)AveragePosition
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.TeamQuerySystem.AveragePosition | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#aa0a941dc70248bec1de2be046f598533)AverageEnemyPosition
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.TeamQuerySystem.AverageEnemyPosition | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#aedfae3716d42a87f5bdf215a196b1e60)MedianTargetFormation
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [FormationQuerySystem](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html) TaleWorlds.MountAndBlade.TeamQuerySystem.MedianTargetFormation | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a3eb77d6976aaf13b309c42e8692e766d)MedianTargetFormationPosition
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) TaleWorlds.MountAndBlade.TeamQuerySystem.MedianTargetFormationPosition | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a6d2bf4b647dd2e28f965830a6ddf1eda)LeftFlankEdgePosition
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) TaleWorlds.MountAndBlade.TeamQuerySystem.LeftFlankEdgePosition | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#af8e6308d75005e9e6fe58f34cd9ac350)RightFlankEdgePosition
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) TaleWorlds.MountAndBlade.TeamQuerySystem.RightFlankEdgePosition | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a7e7e1b4daa32cf06e96f790108b66738)InfantryRatio
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.TeamQuerySystem.InfantryRatio | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a07f491339648cddd915a05c47e63f5cb)RangedRatio
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.TeamQuerySystem.RangedRatio | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a50aa5d318f2475bc877465770ab32bb3)CavalryRatio
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.TeamQuerySystem.CavalryRatio | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a1d5ef25be359360b2d85b0ff3bd65cb4)RangedCavalryRatio
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.TeamQuerySystem.RangedCavalryRatio | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a67285b53ce9c809c65243d447075e804)AllyUnitCount
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.TeamQuerySystem.AllyUnitCount | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a42b5af9969466377b8c62ba2be06162c)EnemyUnitCount
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.TeamQuerySystem.EnemyUnitCount | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#aa732c0ab576c2138176420d369d1820d)AllyInfantryRatio
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.TeamQuerySystem.AllyInfantryRatio | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a795565fe5ea7aca0e5e07680c27ce08d)AllyRangedRatio
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.TeamQuerySystem.AllyRangedRatio | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a086bad9860786b54b670e081ae6030f0)AllyCavalryRatio
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.TeamQuerySystem.AllyCavalryRatio | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a0a50dcc6b7d270e32ea2eb1d1c866637)AllyRangedCavalryRatio
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.TeamQuerySystem.AllyRangedCavalryRatio | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a7b7eb8dbe6f5a92c34e3e1cbb03069a1)EnemyInfantryRatio
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.TeamQuerySystem.EnemyInfantryRatio | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a6ac90df87c7916f5dbcc3c3f1f07e8f8)EnemyRangedRatio
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.TeamQuerySystem.EnemyRangedRatio | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a1ce6384174540c11437e1a4dede2d0d0)EnemyCavalryRatio
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.TeamQuerySystem.EnemyCavalryRatio | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a298c4d5e9a2c178607b4826b3fcd1207)EnemyRangedCavalryRatio
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.TeamQuerySystem.EnemyRangedCavalryRatio | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a37899a4c318d081201deb8be015a9cec)RemainingPowerRatio
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.TeamQuerySystem.RemainingPowerRatio | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#afb4f25dc5048fd8166c72e681af85ab8)TeamPower
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.TeamQuerySystem.TeamPower | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#ab986c2431bda88086f6ba157cb7878bb)TotalPowerRatio
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.TeamQuerySystem.TotalPowerRatio | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a088ba644ede174043d6997f1eb4e383a)InsideWallsRatio
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.TeamQuerySystem.InsideWallsRatio | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#af975db8badd735ab0a8f8b5edf55b674)BattlePowerLogic
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IBattlePowerCalculationLogic](interface_tale_worlds_1_1_mount_and_blade_1_1_i_battle_power_calculation_logic.html) TaleWorlds.MountAndBlade.TeamQuerySystem.BattlePowerLogic | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a84acbd8ba0fa7b42b1467e7e9c7213ac)CasualtyHandler
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | CasualtyHandler TaleWorlds.MountAndBlade.TeamQuerySystem.CasualtyHandler | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a80964316295e0a1cdc48838930b98263)MaxUnderRangedAttackRatio
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.TeamQuerySystem.MaxUnderRangedAttackRatio | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a13bb38317e22af9cf2fd203e4a3b458c)DeathCount
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.TeamQuerySystem.DeathCount | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a35da9d3fa699c4fb96779433ec6236e8)DeathByRangedCount
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.TeamQuerySystem.DeathByRangedCount | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a8163f2ab00d8fd6f1469314528c87c9f)AllyRangedUnitCount
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.TeamQuerySystem.AllyRangedUnitCount | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#a5872a63f30fff85702dcf43e36b455d5)AllCavalryUnitCount
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.TeamQuerySystem.AllCavalryUnitCount | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html#acf331624c8edaa2f851a15f9a3beeeb8)EnemyRangedUnitCount
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.TeamQuerySystem.EnemyRangedUnitCount | | get |

