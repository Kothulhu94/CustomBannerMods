--- SOURCE: interface_tale_worlds_1_1_mount_and_blade_1_1_i_primary_siege_weapon.html ---

TaleWorlds.MountAndBlade.IPrimarySiegeWeapon Interface ReferenceInherited by [TaleWorlds.MountAndBlade.BatteringRam](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html), [TaleWorlds.MountAndBlade.SiegeLadder](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html), and [TaleWorlds.MountAndBlade.SiegeTower](class_tale_worlds_1_1_mount_and_blade_1_1_siege_tower.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| bool | [HasCompletedAction](interface_tale_worlds_1_1_mount_and_blade_1_1_i_primary_siege_weapon.html#ad6dd66df1468ead07dcee65e801db366) () |
| bool | [GetNavmeshFaceIds](interface_tale_worlds_1_1_mount_and_blade_1_1_i_primary_siege_weapon.html#abfcc7161e612e62115d31f8dd93a2ca5) (out List< int > navmeshFaceIds) |

|  |  |
| --- | --- |
| Properties | |
| float | [SiegeWeaponPriority](interface_tale_worlds_1_1_mount_and_blade_1_1_i_primary_siege_weapon.html#a62b2ad4c0fd2e4f1a1bab9eb12d290cf) `[get]` |
| int | [OverTheWallNavMeshID](interface_tale_worlds_1_1_mount_and_blade_1_1_i_primary_siege_weapon.html#aa6d60a18c21f3a094af9a230ad9aefe6) `[get]` |
| bool | [HoldLadders](interface_tale_worlds_1_1_mount_and_blade_1_1_i_primary_siege_weapon.html#a8767c012083d205e56cba9676629038d) `[get]` |
| bool | [SendLadders](interface_tale_worlds_1_1_mount_and_blade_1_1_i_primary_siege_weapon.html#aeec9e5c3da8927bd3c0b56aca6b2a78a) `[get]` |
| [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | [TargetCastlePosition](interface_tale_worlds_1_1_mount_and_blade_1_1_i_primary_siege_weapon.html#a5f3cf006ac29e3a56df07fca764a5bd8) `[get]` |
| [FormationAI.BehaviorSide](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#af0e557fbaea88404cb872c1bc2b7912b) | [WeaponSide](interface_tale_worlds_1_1_mount_and_blade_1_1_i_primary_siege_weapon.html#a966ca954fd294a918598cd6614c8efda) `[get]` |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_primary_siege_weapon.html#ad6dd66df1468ead07dcee65e801db366)HasCompletedAction()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.IPrimarySiegeWeapon.HasCompletedAction | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.BatteringRam](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#af37e3c781dd026a142b5c8e7592055e0), [TaleWorlds.MountAndBlade.SiegeLadder](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a84b1cfb6e21344172ad600373a497955), and [TaleWorlds.MountAndBlade.SiegeTower](class_tale_worlds_1_1_mount_and_blade_1_1_siege_tower.html#acfa06eaa9d60455e0c39a129e6ca3aa2).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_primary_siege_weapon.html#abfcc7161e612e62115d31f8dd93a2ca5)GetNavmeshFaceIds()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.IPrimarySiegeWeapon.GetNavmeshFaceIds | ( | out List< int > | *navmeshFaceIds* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.BatteringRam](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a860805b45d615872ddf5d198e2e4ea21), [TaleWorlds.MountAndBlade.SiegeLadder](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#aad76e76bbe32be585ca594e5e1f194e3), and [TaleWorlds.MountAndBlade.SiegeTower](class_tale_worlds_1_1_mount_and_blade_1_1_siege_tower.html#a22c3b974f53360c7b0df52f4a14bc155).

Property Documentation
----------------------

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_primary_siege_weapon.html#a62b2ad4c0fd2e4f1a1bab9eb12d290cf)SiegeWeaponPriority
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.IPrimarySiegeWeapon.SiegeWeaponPriority | | get |

Implemented in [TaleWorlds.MountAndBlade.BatteringRam](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a13bdb37d8cea756218469691511f25a7), [TaleWorlds.MountAndBlade.SiegeLadder](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#ab3c781b180b3894958e3b2a584c62b16), and [TaleWorlds.MountAndBlade.SiegeTower](class_tale_worlds_1_1_mount_and_blade_1_1_siege_tower.html#af25cb4131b6326ab7bba77059b0bf5c5).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_primary_siege_weapon.html#aa6d60a18c21f3a094af9a230ad9aefe6)OverTheWallNavMeshID
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.IPrimarySiegeWeapon.OverTheWallNavMeshID | | get |

Implemented in [TaleWorlds.MountAndBlade.BatteringRam](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a99658752c7bb24ad378ff048feb793e2), [TaleWorlds.MountAndBlade.SiegeLadder](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#af99d19268993a6aea9feae6d8be8cade), and [TaleWorlds.MountAndBlade.SiegeTower](class_tale_worlds_1_1_mount_and_blade_1_1_siege_tower.html#a48d7f224fd8d9871b41cbcdfaa148ee5).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_primary_siege_weapon.html#a8767c012083d205e56cba9676629038d)HoldLadders
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.IPrimarySiegeWeapon.HoldLadders | | get |

Implemented in [TaleWorlds.MountAndBlade.BatteringRam](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a6eeff584223d4526bb1c4f9197539d14), [TaleWorlds.MountAndBlade.SiegeLadder](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#add354d1e390881709896af76c34da1fe), and [TaleWorlds.MountAndBlade.SiegeTower](class_tale_worlds_1_1_mount_and_blade_1_1_siege_tower.html#a7cdda8fc1af9baf819d1f2ef90d500d9).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_primary_siege_weapon.html#aeec9e5c3da8927bd3c0b56aca6b2a78a)SendLadders
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.IPrimarySiegeWeapon.SendLadders | | get |

Implemented in [TaleWorlds.MountAndBlade.BatteringRam](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a723afb671b0d7b212d2df7b1a56db9ae), [TaleWorlds.MountAndBlade.SiegeLadder](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a47cfca2814a9b23245d5ff3985750f04), and [TaleWorlds.MountAndBlade.SiegeTower](class_tale_worlds_1_1_mount_and_blade_1_1_siege_tower.html#ac2736d0dca4942a2662bf29ee1ef39f7).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_primary_siege_weapon.html#a5f3cf006ac29e3a56df07fca764a5bd8)TargetCastlePosition
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) TaleWorlds.MountAndBlade.IPrimarySiegeWeapon.TargetCastlePosition | | get |

Implemented in [TaleWorlds.MountAndBlade.BatteringRam](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a47fc5bd7c4c623b12c337beea91fe054), [TaleWorlds.MountAndBlade.SiegeLadder](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#aa43a8fe4865491eab2aff6540ff3594a), and [TaleWorlds.MountAndBlade.SiegeTower](class_tale_worlds_1_1_mount_and_blade_1_1_siege_tower.html#afa5bd315db7241b129f1426599f8c109).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_primary_siege_weapon.html#a966ca954fd294a918598cd6614c8efda)WeaponSide
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [FormationAI.BehaviorSide](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#af0e557fbaea88404cb872c1bc2b7912b) TaleWorlds.MountAndBlade.IPrimarySiegeWeapon.WeaponSide | | get |

Implemented in [TaleWorlds.MountAndBlade.BatteringRam](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a17bbecfec80f14fa0d450adb04d3e73c), [TaleWorlds.MountAndBlade.SiegeLadder](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#adf2abde222925a1bfe355aefb6f15d3b), and [TaleWorlds.MountAndBlade.SiegeTower](class_tale_worlds_1_1_mount_and_blade_1_1_siege_tower.html#a42b8e02f190c3e7f9c2a4b15159f24ab).

