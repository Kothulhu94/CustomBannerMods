--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_debug_siege_behavior.html ---

TaleWorlds.MountAndBlade.DebugSiegeBehavior Class Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [DebugStateAttacker](class_tale_worlds_1_1_mount_and_blade_1_1_debug_siege_behavior.html#af3b17ad6a0ca747a188e3e924840da85) {     [None](class_tale_worlds_1_1_mount_and_blade_1_1_debug_siege_behavior.html#af3b17ad6a0ca747a188e3e924840da85a6adf97f83acf6453d4a6a4b1070f3754) ,     [DebugAttackersToBallistae](class_tale_worlds_1_1_mount_and_blade_1_1_debug_siege_behavior.html#af3b17ad6a0ca747a188e3e924840da85aa5649d1b290629da3efde25b84d10955) ,     [DebugAttackersToMangonels](class_tale_worlds_1_1_mount_and_blade_1_1_debug_siege_behavior.html#af3b17ad6a0ca747a188e3e924840da85afa55ca127d6a7a9d563f44af0dad1b98) ,     [DebugAttackersToBattlements](class_tale_worlds_1_1_mount_and_blade_1_1_debug_siege_behavior.html#af3b17ad6a0ca747a188e3e924840da85a3f70227d5f42c66226d488c2863515eb)   } |
| enum | [DebugStateDefender](class_tale_worlds_1_1_mount_and_blade_1_1_debug_siege_behavior.html#abf7bb1fa165d64648111448884ea0363) {     [None](class_tale_worlds_1_1_mount_and_blade_1_1_debug_siege_behavior.html#abf7bb1fa165d64648111448884ea0363a6adf97f83acf6453d4a6a4b1070f3754) ,     [DebugDefendersToBallistae](class_tale_worlds_1_1_mount_and_blade_1_1_debug_siege_behavior.html#abf7bb1fa165d64648111448884ea0363ae9fee779d3d9a12798871e1201d9e772) ,     [DebugDefendersToMangonels](class_tale_worlds_1_1_mount_and_blade_1_1_debug_siege_behavior.html#abf7bb1fa165d64648111448884ea0363aa8c22ceb9bd0d29d9bbfb43a4aca8a19) ,     [DebugDefendersToRam](class_tale_worlds_1_1_mount_and_blade_1_1_debug_siege_behavior.html#abf7bb1fa165d64648111448884ea0363a1e1fe8b332c8aad056b2ac232f3cfcbf) ,     [DebugDefendersToTower](class_tale_worlds_1_1_mount_and_blade_1_1_debug_siege_behavior.html#abf7bb1fa165d64648111448884ea0363a62e4b29f1609570123128a335d5c7d0f)   } |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [SiegeDebug](class_tale_worlds_1_1_mount_and_blade_1_1_debug_siege_behavior.html#a4d1424f22416c0f857fd1da66a212281) ([UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) usableMachine) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static bool | [ToggleTargetDebug](class_tale_worlds_1_1_mount_and_blade_1_1_debug_siege_behavior.html#a01558944f19f6d67c8b0ca7e0fa56b78) = false |
| static [DebugStateAttacker](class_tale_worlds_1_1_mount_and_blade_1_1_debug_siege_behavior.html#af3b17ad6a0ca747a188e3e924840da85) | [DebugAttackState](class_tale_worlds_1_1_mount_and_blade_1_1_debug_siege_behavior.html#a47100cf8059be79a53d99d167ae817b4) = [DebugStateAttacker.None](class_tale_worlds_1_1_mount_and_blade_1_1_debug_siege_behavior.html#af3b17ad6a0ca747a188e3e924840da85a6adf97f83acf6453d4a6a4b1070f3754) |
| static [DebugStateDefender](class_tale_worlds_1_1_mount_and_blade_1_1_debug_siege_behavior.html#abf7bb1fa165d64648111448884ea0363) | [DebugDefendState](class_tale_worlds_1_1_mount_and_blade_1_1_debug_siege_behavior.html#a7a93b8e9f849c0f8e38dd71a7a7ee7b6) = [DebugStateDefender.None](class_tale_worlds_1_1_mount_and_blade_1_1_debug_siege_behavior.html#abf7bb1fa165d64648111448884ea0363a6adf97f83acf6453d4a6a4b1070f3754) |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_debug_siege_behavior.html#af3b17ad6a0ca747a188e3e924840da85)DebugStateAttacker
----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.DebugSiegeBehavior.DebugStateAttacker](class_tale_worlds_1_1_mount_and_blade_1_1_debug_siege_behavior.html#af3b17ad6a0ca747a188e3e924840da85) |

| Enumerator | |
| --- | --- |
| None |  |
| DebugAttackersToBallistae |  |
| DebugAttackersToMangonels |  |
| DebugAttackersToBattlements |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_debug_siege_behavior.html#abf7bb1fa165d64648111448884ea0363)DebugStateDefender
----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.DebugSiegeBehavior.DebugStateDefender](class_tale_worlds_1_1_mount_and_blade_1_1_debug_siege_behavior.html#abf7bb1fa165d64648111448884ea0363) |

| Enumerator | |
| --- | --- |
| None |  |
| DebugDefendersToBallistae |  |
| DebugDefendersToMangonels |  |
| DebugDefendersToRam |  |
| DebugDefendersToTower |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_debug_siege_behavior.html#a4d1424f22416c0f857fd1da66a212281)SiegeDebug()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.DebugSiegeBehavior.SiegeDebug | ( | [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) | *usableMachine* | ) |  | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_debug_siege_behavior.html#a01558944f19f6d67c8b0ca7e0fa56b78)ToggleTargetDebug
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.DebugSiegeBehavior.ToggleTargetDebug = false | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_debug_siege_behavior.html#a47100cf8059be79a53d99d167ae817b4)DebugAttackState
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [DebugStateAttacker](class_tale_worlds_1_1_mount_and_blade_1_1_debug_siege_behavior.html#af3b17ad6a0ca747a188e3e924840da85) TaleWorlds.MountAndBlade.DebugSiegeBehavior.DebugAttackState = [DebugStateAttacker.None](class_tale_worlds_1_1_mount_and_blade_1_1_debug_siege_behavior.html#af3b17ad6a0ca747a188e3e924840da85a6adf97f83acf6453d4a6a4b1070f3754) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_debug_siege_behavior.html#a7a93b8e9f849c0f8e38dd71a7a7ee7b6)DebugDefendState
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [DebugStateDefender](class_tale_worlds_1_1_mount_and_blade_1_1_debug_siege_behavior.html#abf7bb1fa165d64648111448884ea0363) TaleWorlds.MountAndBlade.DebugSiegeBehavior.DebugDefendState = [DebugStateDefender.None](class_tale_worlds_1_1_mount_and_blade_1_1_debug_siege_behavior.html#abf7bb1fa165d64648111448884ea0363a6adf97f83acf6453d4a6a4b1070f3754) | | static |

