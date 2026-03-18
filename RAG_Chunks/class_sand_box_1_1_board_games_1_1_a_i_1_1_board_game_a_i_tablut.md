--- SOURCE: class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_tablut.html ---

SandBox.BoardGames.AI.BoardGameAITablut Class ReferenceInherits [SandBox.BoardGames.AI.BoardGameAIBase](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [BoardGameAITablut](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_tablut.html#af94c1f1d77a5c05af03398dea7a8c5f3) ([BoardGameHelper.AIDifficulty](class_helpers_1_1_board_game_helper.html#a4eae119f51c59e72692b19fd9f1cc9c8) difficulty, [MissionBoardGameLogic](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html) boardGameHandler) |
| override void | [Initialize](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_tablut.html#ac365233af86a29f6f6d6739063fe775a) () |
| override void | [OnSetGameOver](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_tablut.html#a9c2dee88cc9dc5743d9f781762c1b026) () |
| override [Move](struct_sand_box_1_1_board_games_1_1_move.html) | [CalculateMovementStageMove](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_tablut.html#a6c478adacb5dc86ae187dea92fbb7a90) () |
| Public Member Functions inherited from [SandBox.BoardGames.AI.BoardGameAIBase](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html) | |
| virtual [Move](struct_sand_box_1_1_board_games_1_1_move.html) | [CalculatePreMovementStageMove](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#aa925c33cf7c07af45fef1d2710dbb477) () |
| [Move](struct_sand_box_1_1_board_games_1_1_move.html) | [CalculateMovementStageMove](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a30e2e2c33923f49187387305a047d90d) () |
| virtual bool | [WantsToForfeit](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a3552fb9f766d654e0870971d91f4dc2d) () |
| void | [SetDifficulty](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a34467b37d80a6c35d4fd48f697dc692b) ([BoardGameHelper.AIDifficulty](class_helpers_1_1_board_game_helper.html#a4eae119f51c59e72692b19fd9f1cc9c8) difficulty) |
| float | [HowLongDidAIThinkAboutMove](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a1e7d531838d11bf24ac086d2c0770bf5) () |
| void | [UpdateThinkingAboutMove](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a025b5850d18b1c564cbf63ba4825b9bb) (float dt) |
| void | [ResetThinking](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a768b81fc05b8db5490aef2e010614396) () |
| bool | [CanMakeMove](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a092a0bc44cb20fe9317e81d8fe7932f5) () |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static [BoardGameTablut](class_sand_box_1_1_board_games_1_1_board_game_tablut.html) | [Board](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_tablut.html#a530c9c4126135ee197fb17083f3287d1) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [InitializeDifficulty](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_tablut.html#ae3c93a52219cb9e837e54a8e21e050bb) () |
| Protected Member Functions inherited from [SandBox.BoardGames.AI.BoardGameAIBase](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html) | |
|  | [BoardGameAIBase](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#aadc486abc9f925612f0e9b507f2a51d2) ([BoardGameHelper.AIDifficulty](class_helpers_1_1_board_game_helper.html#a4eae119f51c59e72692b19fd9f1cc9c8) difficulty, [MissionBoardGameLogic](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html) boardGameHandler) |
| void | [InitializeDifficulty](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#aafb2db94d341622dee7eb594a2a7c3a4) () |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Types inherited from [SandBox.BoardGames.AI.BoardGameAIBase](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html) | |
| enum | [AIState](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a84fa730c8e32050a46cb1369f4545690) {     [NeedsToRun](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a84fa730c8e32050a46cb1369f4545690aee0e495aa7083746ca384d861d82f380) ,     [ReadyToRun](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a84fa730c8e32050a46cb1369f4545690a506db5c85cf0fd10f93e5478013650b6) ,     [Running](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a84fa730c8e32050a46cb1369f4545690a5bda814c4aedb126839228f1a3d92f09) ,     [AbortRequested](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a84fa730c8e32050a46cb1369f4545690a3267fb95d13d5ed7c6b0512cbc434554) ,     [Aborted](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a84fa730c8e32050a46cb1369f4545690a721c28f4c74928cc9e0bb3fef345e408) ,     [Done](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a84fa730c8e32050a46cb1369f4545690af92965e2c8a7afb3c1b9a5c09a263636)   } |
| Protected Attributes inherited from [SandBox.BoardGames.AI.BoardGameAIBase](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html) | |
| bool | [MayForfeit](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a7bbc72dba3d99faa18f41311e9365e5d) |
| int | [MaxDepth](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a7a5b38a99182281b5d584f6006ddbcb5) |
| Properties inherited from [SandBox.BoardGames.AI.BoardGameAIBase](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html) | |
| [AIState](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a84fa730c8e32050a46cb1369f4545690) | [State](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a0c13181ee95ea3b3220637feb4a526b7) `[get]` |
| [Move](struct_sand_box_1_1_board_games_1_1_move.html) | [RecentMoveCalculated](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#adf760758e8fddddbdf5a710bbc97bd9f) `[get]` |
| bool | [AbortRequested](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#ac4813c7e4a0a70f454e5322efc636c5a) `[get]` |
| [BoardGameHelper.AIDifficulty](class_helpers_1_1_board_game_helper.html#a4eae119f51c59e72692b19fd9f1cc9c8) | [Difficulty](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a6db3303810a3c0f3dff07c1c64b59e8f) `[get]` |
| [MissionBoardGameLogic](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html) | [BoardGameHandler](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a80d9b283334016383a9cc36d74cb9c4e) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_tablut.html#af94c1f1d77a5c05af03398dea7a8c5f3)BoardGameAITablut()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| SandBox.BoardGames.AI.BoardGameAITablut.BoardGameAITablut | ( | [BoardGameHelper.AIDifficulty](class_helpers_1_1_board_game_helper.html#a4eae119f51c59e72692b19fd9f1cc9c8) | *difficulty*, |
|  |  | [MissionBoardGameLogic](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html) | *boardGameHandler* ) |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_tablut.html#ac365233af86a29f6f6d6739063fe775a)Initialize()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.BoardGames.AI.BoardGameAITablut.Initialize | ( |  | ) |  | | virtual |

Reimplemented from [SandBox.BoardGames.AI.BoardGameAIBase](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a84c5e439ed995d4620da539340c7c3be).

[◆](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_tablut.html#a9c2dee88cc9dc5743d9f781762c1b026)OnSetGameOver()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.BoardGames.AI.BoardGameAITablut.OnSetGameOver | ( |  | ) |  | | virtual |

Reimplemented from [SandBox.BoardGames.AI.BoardGameAIBase](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#a4f16be17ef76049291851d9a0cfaeb8d).

[◆](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_tablut.html#a6c478adacb5dc86ae187dea92fbb7a90)CalculateMovementStageMove()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [Move](struct_sand_box_1_1_board_games_1_1_move.html) SandBox.BoardGames.AI.BoardGameAITablut.CalculateMovementStageMove | ( |  | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_tablut.html#ae3c93a52219cb9e837e54a8e21e050bb)InitializeDifficulty()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.BoardGames.AI.BoardGameAITablut.InitializeDifficulty | ( |  | ) |  | | protected |

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_tablut.html#a530c9c4126135ee197fb17083f3287d1)Board
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BoardGameTablut](class_sand_box_1_1_board_games_1_1_board_game_tablut.html) SandBox.BoardGames.AI.BoardGameAITablut.Board | | static |

