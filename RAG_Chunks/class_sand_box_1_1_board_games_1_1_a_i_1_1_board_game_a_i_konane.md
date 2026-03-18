--- SOURCE: class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_konane.html ---

SandBox.BoardGames.AI.BoardGameAIKonane Class ReferenceInherits [SandBox.BoardGames.AI.BoardGameAIBase](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [BoardGameAIKonane](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_konane.html#a2bd72e3305c192bab23cdcea84c9ab46) ([BoardGameHelper.AIDifficulty](class_helpers_1_1_board_game_helper.html#a4eae119f51c59e72692b19fd9f1cc9c8) difficulty, [MissionBoardGameLogic](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html) boardGameHandler) |
| override [Move](struct_sand_box_1_1_board_games_1_1_move.html) | [CalculateMovementStageMove](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_konane.html#a257d8cc7df60d473e8eb3de61756f47d) () |
| override [Move](struct_sand_box_1_1_board_games_1_1_move.html) | [CalculatePreMovementStageMove](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_konane.html#af4e924ec24d783ab4983fc94b6137e17) () |
| Public Member Functions inherited from [SandBox.BoardGames.AI.BoardGameAIBase](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html) | |
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
| override void | [InitializeDifficulty](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_konane.html#a24b537dd2b296bcef64afb1024785be5) () |
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

[◆](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_konane.html#a2bd72e3305c192bab23cdcea84c9ab46)BoardGameAIKonane()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| SandBox.BoardGames.AI.BoardGameAIKonane.BoardGameAIKonane | ( | [BoardGameHelper.AIDifficulty](class_helpers_1_1_board_game_helper.html#a4eae119f51c59e72692b19fd9f1cc9c8) | *difficulty*, |
|  |  | [MissionBoardGameLogic](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html) | *boardGameHandler* ) |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_konane.html#a24b537dd2b296bcef64afb1024785be5)InitializeDifficulty()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.BoardGames.AI.BoardGameAIKonane.InitializeDifficulty | ( |  | ) |  | | protected |

[◆](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_konane.html#a257d8cc7df60d473e8eb3de61756f47d)CalculateMovementStageMove()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [Move](struct_sand_box_1_1_board_games_1_1_move.html) SandBox.BoardGames.AI.BoardGameAIKonane.CalculateMovementStageMove | ( |  | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_konane.html#af4e924ec24d783ab4983fc94b6137e17)CalculatePreMovementStageMove()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [Move](struct_sand_box_1_1_board_games_1_1_move.html) SandBox.BoardGames.AI.BoardGameAIKonane.CalculatePreMovementStageMove | ( |  | ) |  | | virtual |

Reimplemented from [SandBox.BoardGames.AI.BoardGameAIBase](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html#aa925c33cf7c07af45fef1d2710dbb477).

