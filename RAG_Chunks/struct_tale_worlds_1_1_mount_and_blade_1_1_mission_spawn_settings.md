--- SOURCE: struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html ---

TaleWorlds.MountAndBlade.MissionSpawnSettings Struct Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [ReinforcementSpawnMethod](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a62d944ae26aa36796468a508f5eb419c) {     [Balanced](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a62d944ae26aa36796468a508f5eb419cac6589f5236c0c434d0c63dc5f9a856f2) ,     [Wave](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a62d944ae26aa36796468a508f5eb419cad911b34823c7674c292556dc56148c27) ,     [Fixed](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a62d944ae26aa36796468a508f5eb419ca4457d440870ad6d42bab9082d9bf9b61)   } |
| enum | [ReinforcementTimingMethod](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a2e604e4e5f03b24378ce2b75ff389e8c) {     [GlobalTimer](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a2e604e4e5f03b24378ce2b75ff389e8caade3742e8d39c5ac8b0bc6d1bef80220) ,     [CustomTimer](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a2e604e4e5f03b24378ce2b75ff389e8ca62676edc2a1e8ed59d0da9edc52084ca)   } |
| enum | [InitialSpawnMethod](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a58b4d87ab700274e731d901760892ba5) {     [BattleSizeAllocating](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a58b4d87ab700274e731d901760892ba5ab68bd488647a899d716537e267377759) ,     [FreeAllocation](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a58b4d87ab700274e731d901760892ba5ab2e92a7acda8f8cf2504e81f7e3bd7cf)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MissionSpawnSettings](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a13d0bf0905da318e29cf7f69fcc13243) ([InitialSpawnMethod](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a58b4d87ab700274e731d901760892ba5) initialTroopsSpawnMethod, [ReinforcementTimingMethod](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a2e604e4e5f03b24378ce2b75ff389e8c) reinforcementTimingMethod, [ReinforcementSpawnMethod](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a62d944ae26aa36796468a508f5eb419c) reinforcementTroopsSpawnMethod, float globalReinforcementInterval=0f, float reinforcementBatchPercentage=0f, float desiredReinforcementPercentage=0f, float reinforcementWavePercentage=0f, int maximumReinforcementWaveCount=0, float defenderReinforcementBatchPercentage=0f, float attackerReinforcementBatchPercentage=0f, float defenderAdvantageFactor=[DefaultDefenderAdvantageFactor](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#aefd34f53568bc5c08c2be5b98ee6e193), float maximumBattleSizeRatio=[DefaultMaximumBattleSizeRatio](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#ae691d2c93f18199ce10076b9d996dd47)) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [MissionSpawnSettings](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a13d0bf0905da318e29cf7f69fcc13243) | [CreateDefaultSpawnSettings](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a58d2a374dcaba164d1b7fe10c7b482c2) () |
|  | Returns default balanced configuration for single player battles. |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const float | [MinimumReinforcementInterval](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a31ea9d1a672d0291a3636947955223e1) = 1f |
| const float | [MinimumDefenderAdvantageFactor](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a230e0a0da84cfd03568c85e2650b7f99) = 0.1f |
| const float | [MaximumDefenderAdvantageFactor](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a95fb1cb5b7f2c2ca10fd7a33411a105e) = 10f |
| const float | [MinimumBattleSizeRatioLimit](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a915d92a15d793d514ede1ab5869ca3d5) = 0.50f |
| const float | [MaximumBattleSizeRatioLimit](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#ae9f9d11c1fe05d83cfab0c72ba5545d6) = 0.99f |
| const float | [DefaultMaximumBattleSizeRatio](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#ae691d2c93f18199ce10076b9d996dd47) = 0.75f |
| const float | [DefaultDefenderAdvantageFactor](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#aefd34f53568bc5c08c2be5b98ee6e193) = 1f |

|  |  |
| --- | --- |
| Properties | |
| float | [GlobalReinforcementInterval](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a30f6be530ff5c1660827fa75f29a50de) `[get, set]` |
|  | Reinforcement iterval specifying time between consecutive reinforcement cycles (in seconds). This specifies a global interval for both attacker and defender sides. |
| float | [DefenderAdvantageFactor](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a91253a3c824e17f20932d811c43bd780) `[get, set]` |
|  | Controls how advantageous the defender side is for sharing mission maximum battle size Default value is one. Which makes sure defenders and attackers share battle size proportionally with respect to their troop count. Values above one favor defenders and below one favor attackers Example: Defenders have 100 troops and Attackers have 300. In this case %25 of the battle size is allocated to defenders. If advantage factor is set to two, This would cause %50 of the battle size to be allocated to defender and the other %50 to attackers. Troops that do not fill into battle size become reinforcements for both sides. If all troops can fit into mission battle size advantage factor will not have an effect. |
| float | [MaximumBattleSideRatio](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a13b2a0484d10438a1f9cef55ed961476) `[get, set]` |
|  | Maximum ratio of a battle side when battle begins. |
| [InitialSpawnMethod](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a58b4d87ab700274e731d901760892ba5) | [InitialTroopsSpawnMethod](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a6ae19ffd83bde7b358eb7641844015cc) `[get]` |
| [ReinforcementTimingMethod](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a2e604e4e5f03b24378ce2b75ff389e8c) | [ReinforcementTroopsTimingMethod](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#aaf1b0281f1604f4af285066e689a2d9e) `[get]` |
| [ReinforcementSpawnMethod](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a62d944ae26aa36796468a508f5eb419c) | [ReinforcementTroopsSpawnMethod](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#afcb93f1bf73b21d875c91c6ce199f8f1) `[get]` |
| float | [ReinforcementBatchPercentage](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a6ae8437dbb766c65d6cb4b4fc19b63fb) `[get, set]` |
|  | Specifies reinforcement batch percentage (for both defenders and attackers) If number of reinforcement troops reserved for next reinforcement cycle is below this number times battle size spawn will not occur. Only valid in balanced spawn method. Must be between (0,1]. |
| float | [DesiredReinforcementPercentage](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a053211f6a9a47275d4cfd72ea42ae8c9) `[get, set]` |
|  | Specifies desired reinforcement percentage (for both defenders and attackers) The number of reinforcements desired by any side within a cycle cannot exceed this number times their the sides initial reinforcement count. Only used in balanced spawn method Must be Between (0,1]. |
| float | [ReinforcementWavePercentage](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#abd248117d2f7ef906bdcb81e5ecf4c5e) `[get, set]` |
|  | Specifies reinforcement threshold percentage (for both defenders and attackers) If number of active troops for a battle size drops below this number times their initial spawn number, reinforcement spawn will occur. Only valid in wave spawn method. Must be between (0,1]. |
| int | [MaximumReinforcementWaveCount](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a4d7af7df80cc45de0d17ae6f1d6afa2a) `[get, set]` |
|  | Specifies maximum amount of reinforcement waves that will be spawned during the mission. If passed zero, there wont be any limit. all reinforcemens will be spawned abiding reinforcement wave percentage. |
| float | [DefenderReinforcementBatchPercentage](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a688114866e9f4437b0cdcbcf00f842bc) `[get, set]` |
|  | Specifies reinforcement batch percentage for defenders for fixed spawn method. This number times battle size will be the amount of defender reinforcements to be spawned per reinforcement cycle Only used in fixed spawn method Must be between [0,1]. |
| float | [AttackerReinforcementBatchPercentage](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a634869a717788035d8c4527ed2d12729) `[get, set]` |
|  | Specifies reinforcement batch percentage for attackers This number times battle size will be the amount of attacker reinforcements to be spawned per reinforcement cycle Only used in fixed spawn method Must be Between [0,1]. |

Member Enumeration Documentation
--------------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a62d944ae26aa36796468a508f5eb419c)ReinforcementSpawnMethod
-------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.MissionSpawnSettings.ReinforcementSpawnMethod](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a62d944ae26aa36796468a508f5eb419c) |

| Enumerator | |
| --- | --- |
| Balanced |  |
| Wave |  |
| Fixed |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a2e604e4e5f03b24378ce2b75ff389e8c)ReinforcementTimingMethod
--------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.MissionSpawnSettings.ReinforcementTimingMethod](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a2e604e4e5f03b24378ce2b75ff389e8c) |

| Enumerator | |
| --- | --- |
| GlobalTimer |  |
| CustomTimer |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a58b4d87ab700274e731d901760892ba5)InitialSpawnMethod
-------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.MissionSpawnSettings.InitialSpawnMethod](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a58b4d87ab700274e731d901760892ba5) |

| Enumerator | |
| --- | --- |
| BattleSizeAllocating |  |
| FreeAllocation |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a13d0bf0905da318e29cf7f69fcc13243)MissionSpawnSettings()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.MissionSpawnSettings.MissionSpawnSettings | ( | [InitialSpawnMethod](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a58b4d87ab700274e731d901760892ba5) | *initialTroopsSpawnMethod*, |
|  |  | [ReinforcementTimingMethod](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a2e604e4e5f03b24378ce2b75ff389e8c) | *reinforcementTimingMethod*, |
|  |  | [ReinforcementSpawnMethod](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a62d944ae26aa36796468a508f5eb419c) | *reinforcementTroopsSpawnMethod*, |
|  |  | float | *globalReinforcementInterval* = 0f, |
|  |  | float | *reinforcementBatchPercentage* = 0f, |
|  |  | float | *desiredReinforcementPercentage* = 0f, |
|  |  | float | *reinforcementWavePercentage* = 0f, |
|  |  | int | *maximumReinforcementWaveCount* = 0, |
|  |  | float | *defenderReinforcementBatchPercentage* = 0f, |
|  |  | float | *attackerReinforcementBatchPercentage* = 0f, |
|  |  | float | *defenderAdvantageFactor* = [DefaultDefenderAdvantageFactor](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#aefd34f53568bc5c08c2be5b98ee6e193), |
|  |  | float | *maximumBattleSizeRatio* = [DefaultMaximumBattleSizeRatio](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#ae691d2c93f18199ce10076b9d996dd47) ) |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a58d2a374dcaba164d1b7fe10c7b482c2)CreateDefaultSpawnSettings()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [MissionSpawnSettings](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a13d0bf0905da318e29cf7f69fcc13243) TaleWorlds.MountAndBlade.MissionSpawnSettings.CreateDefaultSpawnSettings | ( |  | ) |  | | static |

Returns

Member Data Documentation
-------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a31ea9d1a672d0291a3636947955223e1)MinimumReinforcementInterval
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.MissionSpawnSettings.MinimumReinforcementInterval = 1f | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a230e0a0da84cfd03568c85e2650b7f99)MinimumDefenderAdvantageFactor
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.MissionSpawnSettings.MinimumDefenderAdvantageFactor = 0.1f | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a95fb1cb5b7f2c2ca10fd7a33411a105e)MaximumDefenderAdvantageFactor
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.MissionSpawnSettings.MaximumDefenderAdvantageFactor = 10f | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a915d92a15d793d514ede1ab5869ca3d5)MinimumBattleSizeRatioLimit
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.MissionSpawnSettings.MinimumBattleSizeRatioLimit = 0.50f | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#ae9f9d11c1fe05d83cfab0c72ba5545d6)MaximumBattleSizeRatioLimit
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.MissionSpawnSettings.MaximumBattleSizeRatioLimit = 0.99f | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#ae691d2c93f18199ce10076b9d996dd47)DefaultMaximumBattleSizeRatio
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.MissionSpawnSettings.DefaultMaximumBattleSizeRatio = 0.75f | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#aefd34f53568bc5c08c2be5b98ee6e193)DefaultDefenderAdvantageFactor
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.MissionSpawnSettings.DefaultDefenderAdvantageFactor = 1f | | static |

Property Documentation
----------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a30f6be530ff5c1660827fa75f29a50de)GlobalReinforcementInterval
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.MissionSpawnSettings.GlobalReinforcementInterval | | getset |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a91253a3c824e17f20932d811c43bd780)DefenderAdvantageFactor
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.MissionSpawnSettings.DefenderAdvantageFactor | | getset |

REMARK\_ATES: If advantage factor is below 1, this makes attackers more advantageous

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a13b2a0484d10438a1f9cef55ed961476)MaximumBattleSideRatio
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.MissionSpawnSettings.MaximumBattleSideRatio | | getset |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a6ae19ffd83bde7b358eb7641844015cc)InitialTroopsSpawnMethod
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InitialSpawnMethod](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a58b4d87ab700274e731d901760892ba5) TaleWorlds.MountAndBlade.MissionSpawnSettings.InitialTroopsSpawnMethod | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#aaf1b0281f1604f4af285066e689a2d9e)ReinforcementTroopsTimingMethod
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ReinforcementTimingMethod](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a2e604e4e5f03b24378ce2b75ff389e8c) TaleWorlds.MountAndBlade.MissionSpawnSettings.ReinforcementTroopsTimingMethod | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#afcb93f1bf73b21d875c91c6ce199f8f1)ReinforcementTroopsSpawnMethod
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ReinforcementSpawnMethod](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a62d944ae26aa36796468a508f5eb419c) TaleWorlds.MountAndBlade.MissionSpawnSettings.ReinforcementTroopsSpawnMethod | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a6ae8437dbb766c65d6cb4b4fc19b63fb)ReinforcementBatchPercentage
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.MissionSpawnSettings.ReinforcementBatchPercentage | | getset |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a053211f6a9a47275d4cfd72ea42ae8c9)DesiredReinforcementPercentage
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.MissionSpawnSettings.DesiredReinforcementPercentage | | getset |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#abd248117d2f7ef906bdcb81e5ecf4c5e)ReinforcementWavePercentage
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.MissionSpawnSettings.ReinforcementWavePercentage | | getset |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a4d7af7df80cc45de0d17ae6f1d6afa2a)MaximumReinforcementWaveCount
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.MissionSpawnSettings.MaximumReinforcementWaveCount | | getset |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a688114866e9f4437b0cdcbcf00f842bc)DefenderReinforcementBatchPercentage
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.MissionSpawnSettings.DefenderReinforcementBatchPercentage | | getset |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html#a634869a717788035d8c4527ed2d12729)AttackerReinforcementBatchPercentage
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.MissionSpawnSettings.AttackerReinforcementBatchPercentage | | getset |

