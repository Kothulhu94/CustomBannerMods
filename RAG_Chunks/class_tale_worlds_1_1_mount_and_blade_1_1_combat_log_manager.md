--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_combat_log_manager.html ---

TaleWorlds.MountAndBlade.CombatLogManager Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
| delegate void | [OnPrintCombatLogHandler](class_tale_worlds_1_1_mount_and_blade_1_1_combat_log_manager.html#a16ce6d37db481271c0ab0bf999fb2710) ([CombatLogData](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html) logData) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [PrintDebugLogForInfo](class_tale_worlds_1_1_mount_and_blade_1_1_combat_log_manager.html#a05fbc6c4e8cc10340047469bd6332b28) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victimAgent, [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) damageType, int speedBonus, int armorAmount, int inflictedDamage, int absorbedByArmor, sbyte collisionBone, float lostHpPercentage) |
| static void | [GenerateCombatLog](class_tale_worlds_1_1_mount_and_blade_1_1_combat_log_manager.html#ac9df5cd18c128ba6f4087747cb195006) ([CombatLogData](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html) logData) |

|  |  |
| --- | --- |
| Events | |
| static [OnPrintCombatLogHandler](class_tale_worlds_1_1_mount_and_blade_1_1_combat_log_manager.html#a16ce6d37db481271c0ab0bf999fb2710) | [OnGenerateCombatLog](class_tale_worlds_1_1_mount_and_blade_1_1_combat_log_manager.html#adbdc5b05eb25db313b628e6b516be76b) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_combat_log_manager.html#a16ce6d37db481271c0ab0bf999fb2710)OnPrintCombatLogHandler()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| delegate void TaleWorlds.MountAndBlade.CombatLogManager.OnPrintCombatLogHandler | ( | [CombatLogData](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html) | *logData* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_combat_log_manager.html#a05fbc6c4e8cc10340047469bd6332b28)PrintDebugLogForInfo()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.CombatLogManager.PrintDebugLogForInfo | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *victimAgent*, | |  |  | [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) | *damageType*, | |  |  | int | *speedBonus*, | |  |  | int | *armorAmount*, | |  |  | int | *inflictedDamage*, | |  |  | int | *absorbedByArmor*, | |  |  | sbyte | *collisionBone*, | |  |  | float | *lostHpPercentage* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_combat_log_manager.html#ac9df5cd18c128ba6f4087747cb195006)GenerateCombatLog()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.CombatLogManager.GenerateCombatLog | ( | [CombatLogData](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html) | *logData* | ) |  | | static |

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_combat_log_manager.html#adbdc5b05eb25db313b628e6b516be76b)OnGenerateCombatLog
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [OnPrintCombatLogHandler](class_tale_worlds_1_1_mount_and_blade_1_1_combat_log_manager.html#a16ce6d37db481271c0ab0bf999fb2710) TaleWorlds.MountAndBlade.CombatLogManager.OnGenerateCombatLog | | static |

