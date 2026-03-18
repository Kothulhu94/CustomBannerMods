--- SOURCE: class_tale_worlds_1_1_core_1_1_mission_result.html ---

TaleWorlds.Core.MissionResult Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MissionResult](class_tale_worlds_1_1_core_1_1_mission_result.html#adb52fc7735ea9caf589b08d611564c6e) ([BattleState](namespace_tale_worlds_1_1_core.html#a53c64d3498c18a933d19dbf60e962fed) battleState, bool playerVictory, bool playerDefeated, bool enemyRetreated) |
|  | [MissionResult](class_tale_worlds_1_1_core_1_1_mission_result.html#a020bd404dd86921f12c3e94094230cbf) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [MissionResult](class_tale_worlds_1_1_core_1_1_mission_result.html#adb52fc7735ea9caf589b08d611564c6e) | [CreateSuccessful](class_tale_worlds_1_1_core_1_1_mission_result.html#ade936da25f63731011e6cf6520de3c14) ([IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) mission, bool enemyRetreated=false) |
| static [MissionResult](class_tale_worlds_1_1_core_1_1_mission_result.html#adb52fc7735ea9caf589b08d611564c6e) | [CreateDefeated](class_tale_worlds_1_1_core_1_1_mission_result.html#abe03ecae3e894650ae6f1513f41e0d42) ([IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) mission) |
| static [MissionResult](class_tale_worlds_1_1_core_1_1_mission_result.html#adb52fc7735ea9caf589b08d611564c6e) | [CreateDefenderPushedBack](class_tale_worlds_1_1_core_1_1_mission_result.html#a219fd8a7ed6662ebba139a0de180c20f) () |

|  |  |
| --- | --- |
| Properties | |
| [BattleState](namespace_tale_worlds_1_1_core.html#a53c64d3498c18a933d19dbf60e962fed) | [BattleState](class_tale_worlds_1_1_core_1_1_mission_result.html#abfea79a3c6b5c9e493d09cecd3ff2aca) `[get]` |
| bool | [BattleResolved](class_tale_worlds_1_1_core_1_1_mission_result.html#a3baf9a3ecb624353f8d5ad43c4f52e0f) `[get]` |
| bool | [PlayerVictory](class_tale_worlds_1_1_core_1_1_mission_result.html#a9bf26695cf4ebcb6b8199892b58f70ec) `[get]` |
| bool | [PlayerDefeated](class_tale_worlds_1_1_core_1_1_mission_result.html#ad1179d0326c5bf1b225c725f2b8bcc3d) `[get]` |
| bool | [EnemyRetreated](class_tale_worlds_1_1_core_1_1_mission_result.html#a5d8f92f9cda58e9db374e470f156efd8) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_core_1_1_mission_result.html#adb52fc7735ea9caf589b08d611564c6e)MissionResult() [1/2]
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Core.MissionResult.MissionResult | ( | [BattleState](namespace_tale_worlds_1_1_core.html#a53c64d3498c18a933d19dbf60e962fed) | *battleState*, |
|  |  | bool | *playerVictory*, |
|  |  | bool | *playerDefeated*, |
|  |  | bool | *enemyRetreated* ) |

[◆](class_tale_worlds_1_1_core_1_1_mission_result.html#a020bd404dd86921f12c3e94094230cbf)MissionResult() [2/2]
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Core.MissionResult.MissionResult | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_mission_result.html#ade936da25f63731011e6cf6520de3c14)CreateSuccessful()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MissionResult](class_tale_worlds_1_1_core_1_1_mission_result.html#adb52fc7735ea9caf589b08d611564c6e) TaleWorlds.Core.MissionResult.CreateSuccessful | ( | [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | *mission*, | |  |  | bool | *enemyRetreated* = false ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_mission_result.html#abe03ecae3e894650ae6f1513f41e0d42)CreateDefeated()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [MissionResult](class_tale_worlds_1_1_core_1_1_mission_result.html#adb52fc7735ea9caf589b08d611564c6e) TaleWorlds.Core.MissionResult.CreateDefeated | ( | [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | *mission* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_mission_result.html#a219fd8a7ed6662ebba139a0de180c20f)CreateDefenderPushedBack()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [MissionResult](class_tale_worlds_1_1_core_1_1_mission_result.html#adb52fc7735ea9caf589b08d611564c6e) TaleWorlds.Core.MissionResult.CreateDefenderPushedBack | ( |  | ) |  | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_mission_result.html#abfea79a3c6b5c9e493d09cecd3ff2aca)BattleState
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BattleState](namespace_tale_worlds_1_1_core.html#a53c64d3498c18a933d19dbf60e962fed) TaleWorlds.Core.MissionResult.BattleState | | get |

[◆](class_tale_worlds_1_1_core_1_1_mission_result.html#a3baf9a3ecb624353f8d5ad43c4f52e0f)BattleResolved
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.MissionResult.BattleResolved | | get |

[◆](class_tale_worlds_1_1_core_1_1_mission_result.html#a9bf26695cf4ebcb6b8199892b58f70ec)PlayerVictory
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.MissionResult.PlayerVictory | | get |

[◆](class_tale_worlds_1_1_core_1_1_mission_result.html#ad1179d0326c5bf1b225c725f2b8bcc3d)PlayerDefeated
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.MissionResult.PlayerDefeated | | get |

[◆](class_tale_worlds_1_1_core_1_1_mission_result.html#a5d8f92f9cda58e9db374e470f156efd8)EnemyRetreated
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.MissionResult.EnemyRetreated | | get |

