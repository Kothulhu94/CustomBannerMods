--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html ---

TaleWorlds.CampaignSystem.Actions.KillCharacterAction Class Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) {     [None](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1a6adf97f83acf6453d4a6a4b1070f3754) ,     [Murdered](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1a1ad1efd2486403d568480debf93c4ca5) ,     [DiedInLabor](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1aca4577fffdac31700d153bff7e1256aa) ,     [DiedOfOldAge](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1a4203e55e29cd01910c0b3b0c01f7cc19) ,     [DiedInBattle](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1aee1892c3cabfc23b0a6b281eafc721e5) ,     [WoundedInBattle](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1a37c2cce166920b153bebbdc42705a5c8) ,     [Executed](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1a37ae3959ff931a36a5157d1d971d964c) ,     [ExecutionAfterMapEvent](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1a7ab9e996f7c126d1c6723d737f9cf41e) ,     [Lost](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1ab578b733cbb788fc6ad208314d2c4c2b)   } |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [ApplyByOldAge](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#a47a87784255ef2512d756bb1517f1cd0) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) victim, bool showNotification=true) |
| static void | [ApplyByWounds](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#aba90d8510b16be18d85e3a1a57431786) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) victim, bool showNotification=true) |
| static void | [ApplyByBattle](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#a4384a2c7811771232c0314b92a2ea2c0) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) victim, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) killer, bool showNotification=true) |
| static void | [ApplyByMurder](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#a596c6d5fe8f81fc307ac826b7acbc34e) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) victim, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) killer=null, bool showNotification=true) |
| static void | [ApplyInLabor](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#a8278bb65c2de77d02846ec208b21dd16) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) lostMother, bool showNotification=true) |
| static void | [ApplyByExecution](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#a4a1fb52a153b8c9a1e212141e90a598a) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) victim, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) executer, bool showNotification=true, bool isForced=false) |
| static void | [ApplyByExecutionAfterMapEvent](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#a7e55c2e723096f4be7534fe4a9d6cd60) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) victim, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) executer, bool showNotification=true, bool isForced=false) |
| static void | [ApplyByRemove](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#a221ce3fdfc97dd738d9219ecef8e50d3) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) victim, bool showNotification=false, bool isForced=true) |
| static void | [ApplyByDeathMark](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#a0f251f5160a1704b7ebf9bc46fdb591f) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) victim, bool showNotification=false) |
| static void | [ApplyByDeathMarkForced](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#a64c9ebf5a63d3be34538f650c1ab14d2) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) victim, bool showNotification=false) |
| static void | [ApplyByPlayerIllness](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#a0781c493ffd16c3f1a838400a825873e) () |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1)KillCharacterActionDetail
------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.Actions.KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) |

| Enumerator | |
| --- | --- |
| None |  |
| Murdered |  |
| DiedInLabor |  |
| DiedOfOldAge |  |
| DiedInBattle |  |
| WoundedInBattle |  |
| Executed |  |
| ExecutionAfterMapEvent |  |
| Lost |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#a47a87784255ef2512d756bb1517f1cd0)ApplyByOldAge()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.KillCharacterAction.ApplyByOldAge | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *victim*, | |  |  | bool | *showNotification* = true ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#aba90d8510b16be18d85e3a1a57431786)ApplyByWounds()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.KillCharacterAction.ApplyByWounds | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *victim*, | |  |  | bool | *showNotification* = true ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#a4384a2c7811771232c0314b92a2ea2c0)ApplyByBattle()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.KillCharacterAction.ApplyByBattle | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *victim*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *killer*, | |  |  | bool | *showNotification* = true ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#a596c6d5fe8f81fc307ac826b7acbc34e)ApplyByMurder()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.KillCharacterAction.ApplyByMurder | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *victim*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *killer* = null, | |  |  | bool | *showNotification* = true ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#a8278bb65c2de77d02846ec208b21dd16)ApplyInLabor()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.KillCharacterAction.ApplyInLabor | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *lostMother*, | |  |  | bool | *showNotification* = true ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#a4a1fb52a153b8c9a1e212141e90a598a)ApplyByExecution()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.KillCharacterAction.ApplyByExecution | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *victim*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *executer*, | |  |  | bool | *showNotification* = true, | |  |  | bool | *isForced* = false ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#a7e55c2e723096f4be7534fe4a9d6cd60)ApplyByExecutionAfterMapEvent()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.KillCharacterAction.ApplyByExecutionAfterMapEvent | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *victim*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *executer*, | |  |  | bool | *showNotification* = true, | |  |  | bool | *isForced* = false ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#a221ce3fdfc97dd738d9219ecef8e50d3)ApplyByRemove()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.KillCharacterAction.ApplyByRemove | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *victim*, | |  |  | bool | *showNotification* = false, | |  |  | bool | *isForced* = true ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#a0f251f5160a1704b7ebf9bc46fdb591f)ApplyByDeathMark()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.KillCharacterAction.ApplyByDeathMark | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *victim*, | |  |  | bool | *showNotification* = false ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#a64c9ebf5a63d3be34538f650c1ab14d2)ApplyByDeathMarkForced()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.KillCharacterAction.ApplyByDeathMarkForced | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *victim*, | |  |  | bool | *showNotification* = false ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#a0781c493ffd16c3f1a838400a825873e)ApplyByPlayerIllness()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.KillCharacterAction.ApplyByPlayerIllness | ( |  | ) |  | | static |

