--- SOURCE: class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html ---

SandBox.BoardGames.AI.BoardGameAIBase Class ReferenceabstractInherited by [SandBox.BoardGames.AI.BoardGameAIBaghChal](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_bagh_chal.html), [SandBox.BoardGames.AI.BoardGameAIKonane](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_konane.html), [SandBox.BoardGames.AI.BoardGameAIMuTorere](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_mu_torere.html), [SandBox.BoardGames.AI.BoardGameAIPuluc](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_puluc.html), [SandBox.BoardGames.AI.BoardGameAISeega](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_seega.html), and [SandBox.BoardGames.AI.BoardGameAITablut](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_tablut.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [AIState](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a84fa730c8e32050a46cb1369f4545690) {     [NeedsToRun](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a84fa730c8e32050a46cb1369f4545690aee0e495aa7083746ca384d861d82f380) ,     [ReadyToRun](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a84fa730c8e32050a46cb1369f4545690a506db5c85cf0fd10f93e5478013650b6) ,     [Running](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a84fa730c8e32050a46cb1369f4545690a5bda814c4aedb126839228f1a3d92f09) ,     [AbortRequested](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a84fa730c8e32050a46cb1369f4545690a3267fb95d13d5ed7c6b0512cbc434554) ,     [Aborted](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a84fa730c8e32050a46cb1369f4545690a721c28f4c74928cc9e0bb3fef345e408) ,     [Done](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a84fa730c8e32050a46cb1369f4545690af92965e2c8a7afb3c1b9a5c09a263636)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| virtual [Move](struct_sand_box_1_1_board_games_1_1_move.html) | [CalculatePreMovementStageMove](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#aa925c33cf7c07af45fef1d2710dbb477) () |
| [Move](struct_sand_box_1_1_board_games_1_1_move.html) | [CalculateMovementStageMove](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a30e2e2c33923f49187387305a047d90d) () |
| virtual bool | [WantsToForfeit](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a3552fb9f766d654e0870971d91f4dc2d) () |
| virtual void | [OnSetGameOver](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a4f16be17ef76049291851d9a0cfaeb8d) () |
| virtual void | [Initialize](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a84c5e439ed995d4620da539340c7c3be) () |
| void | [SetDifficulty](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a34467b37d80a6c35d4fd48f697dc692b) ([BoardGameHelper.AIDifficulty](class_helpers_1_1_board_game_helper.html#a4eae119f51c59e72692b19fd9f1cc9c8) difficulty) |
| float | [HowLongDidAIThinkAboutMove](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a1e7d531838d11bf24ac086d2c0770bf5) () |
| void | [UpdateThinkingAboutMove](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a025b5850d18b1c564cbf63ba4825b9bb) (float dt) |
| void | [ResetThinking](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a768b81fc05b8db5490aef2e010614396) () |
| bool | [CanMakeMove](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a092a0bc44cb20fe9317e81d8fe7932f5) () |

|  |  |
| --- | --- |
| Protected Member Functions | |
|  | [BoardGameAIBase](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#aadc486abc9f925612f0e9b507f2a51d2) ([BoardGameHelper.AIDifficulty](class_helpers_1_1_board_game_helper.html#a4eae119f51c59e72692b19fd9f1cc9c8) difficulty, [MissionBoardGameLogic](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html) boardGameHandler) |
| void | [InitializeDifficulty](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#aafb2db94d341622dee7eb594a2a7c3a4) () |

|  |  |
| --- | --- |
| Protected Attributes | |
| bool | [MayForfeit](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a7bbc72dba3d99faa18f41311e9365e5d) |
| int | [MaxDepth](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a7a5b38a99182281b5d584f6006ddbcb5) |

|  |  |
| --- | --- |
| Properties | |
| [AIState](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a84fa730c8e32050a46cb1369f4545690) | [State](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a0c13181ee95ea3b3220637feb4a526b7) `[get]` |
| [Move](struct_sand_box_1_1_board_games_1_1_move.html) | [RecentMoveCalculated](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#adf760758e8fddddbdf5a710bbc97bd9f) `[get]` |
| bool | [AbortRequested](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#ac4813c7e4a0a70f454e5322efc636c5a) `[get]` |
| [BoardGameHelper.AIDifficulty](class_helpers_1_1_board_game_helper.html#a4eae119f51c59e72692b19fd9f1cc9c8) | [Difficulty](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a6db3303810a3c0f3dff07c1c64b59e8f) `[get]` |
| [MissionBoardGameLogic](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html) | [BoardGameHandler](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a80d9b283334016383a9cc36d74cb9c4e) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a84fa730c8e32050a46cb1369f4545690)AIState
-----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [SandBox.BoardGames.AI.BoardGameAIBase.AIState](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a84fa730c8e32050a46cb1369f4545690) |

| Enumerator | |
| --- | --- |
| NeedsToRun |  |
| ReadyToRun |  |
| Running |  |
| AbortRequested |  |
| Aborted |  |
| Done |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#aadc486abc9f925612f0e9b507f2a51d2)BoardGameAIBase()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | SandBox.BoardGames.AI.BoardGameAIBase.BoardGameAIBase | ( | [BoardGameHelper.AIDifficulty](class_helpers_1_1_board_game_helper.html#a4eae119f51c59e72692b19fd9f1cc9c8) | *difficulty*, | |  |  | [MissionBoardGameLogic](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html) | *boardGameHandler* ) | | protected |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#aa925c33cf7c07af45fef1d2710dbb477)CalculatePreMovementStageMove()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual [Move](struct_sand_box_1_1_board_games_1_1_move.html) SandBox.BoardGames.AI.BoardGameAIBase.CalculatePreMovementStageMove | ( |  | ) |  | | virtual |

Reimplemented in [SandBox.BoardGames.AI.BoardGameAIBaghChal](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_bagh_chal.html#a5f5fa9f1629ff01ee14d875463852e55), [SandBox.BoardGames.AI.BoardGameAIKonane](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_konane.html#af4e924ec24d783ab4983fc94b6137e17), and [SandBox.BoardGames.AI.BoardGameAISeega](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_seega.html#ac06abd670a848db4adad8cd91a715c7f).

[◆](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a30e2e2c33923f49187387305a047d90d)CalculateMovementStageMove()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [Move](struct_sand_box_1_1_board_games_1_1_move.html) SandBox.BoardGames.AI.BoardGameAIBase.CalculateMovementStageMove | ( |  | ) |  | | abstract |

[◆](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#aafb2db94d341622dee7eb594a2a7c3a4)InitializeDifficulty()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void SandBox.BoardGames.AI.BoardGameAIBase.InitializeDifficulty | ( |  | ) |  | | abstractprotected |

[◆](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a3552fb9f766d654e0870971d91f4dc2d)WantsToForfeit()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual bool SandBox.BoardGames.AI.BoardGameAIBase.WantsToForfeit | ( |  | ) |  | | virtual |

Reimplemented in [SandBox.BoardGames.AI.BoardGameAISeega](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_seega.html#a76e04c06d600ffc169db240220036629).

[◆](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a4f16be17ef76049291851d9a0cfaeb8d)OnSetGameOver()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void SandBox.BoardGames.AI.BoardGameAIBase.OnSetGameOver | ( |  | ) |  | | virtual |

Reimplemented in [SandBox.BoardGames.AI.BoardGameAITablut](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_tablut.html#a9c2dee88cc9dc5743d9f781762c1b026).

[◆](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a84c5e439ed995d4620da539340c7c3be)Initialize()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void SandBox.BoardGames.AI.BoardGameAIBase.Initialize | ( |  | ) |  | | virtual |

Reimplemented in [SandBox.BoardGames.AI.BoardGameAITablut](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_tablut.html#ac365233af86a29f6f6d6739063fe775a).

[◆](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a34467b37d80a6c35d4fd48f697dc692b)SetDifficulty()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.BoardGames.AI.BoardGameAIBase.SetDifficulty | ( | [BoardGameHelper.AIDifficulty](class_helpers_1_1_board_game_helper.html#a4eae119f51c59e72692b19fd9f1cc9c8) | *difficulty* | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a1e7d531838d11bf24ac086d2c0770bf5)HowLongDidAIThinkAboutMove()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float SandBox.BoardGames.AI.BoardGameAIBase.HowLongDidAIThinkAboutMove | ( |  | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a025b5850d18b1c564cbf63ba4825b9bb)UpdateThinkingAboutMove()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.BoardGames.AI.BoardGameAIBase.UpdateThinkingAboutMove | ( | float | *dt* | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a768b81fc05b8db5490aef2e010614396)ResetThinking()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.BoardGames.AI.BoardGameAIBase.ResetThinking | ( |  | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a092a0bc44cb20fe9317e81d8fe7932f5)CanMakeMove()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool SandBox.BoardGames.AI.BoardGameAIBase.CanMakeMove | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a7bbc72dba3d99faa18f41311e9365e5d)MayForfeit
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.BoardGames.AI.BoardGameAIBase.MayForfeit | | protected |

[◆](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a7a5b38a99182281b5d584f6006ddbcb5)MaxDepth
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.BoardGames.AI.BoardGameAIBase.MaxDepth | | protected |

Property Documentation
----------------------

[◆](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a0c13181ee95ea3b3220637feb4a526b7)State
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [AIState](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a84fa730c8e32050a46cb1369f4545690) SandBox.BoardGames.AI.BoardGameAIBase.State | | get |

[◆](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#adf760758e8fddddbdf5a710bbc97bd9f)RecentMoveCalculated
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Move](struct_sand_box_1_1_board_games_1_1_move.html) SandBox.BoardGames.AI.BoardGameAIBase.RecentMoveCalculated | | get |

[◆](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#ac4813c7e4a0a70f454e5322efc636c5a)AbortRequested
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.BoardGames.AI.BoardGameAIBase.AbortRequested | | get |

[◆](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a6db3303810a3c0f3dff07c1c64b59e8f)Difficulty
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BoardGameHelper.AIDifficulty](class_helpers_1_1_board_game_helper.html#a4eae119f51c59e72692b19fd9f1cc9c8) SandBox.BoardGames.AI.BoardGameAIBase.Difficulty | | getprotected |

[◆](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a80d9b283334016383a9cc36d74cb9c4e)BoardGameHandler
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MissionBoardGameLogic](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html) SandBox.BoardGames.AI.BoardGameAIBase.BoardGameHandler | | getprotected |

