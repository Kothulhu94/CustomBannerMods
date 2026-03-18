--- SOURCE: class_sand_box_1_1_board_games_1_1_board_game_base.html ---

SandBox.BoardGames.BoardGameBase Class ReferenceabstractInherited by [SandBox.BoardGames.BoardGameBaghChal](class_sand_box_1_1_board_games_1_1_board_game_bagh_chal.html), [SandBox.BoardGames.BoardGameKonane](class_sand_box_1_1_board_games_1_1_board_game_konane.html), [SandBox.BoardGames.BoardGameMuTorere](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html), [SandBox.BoardGames.BoardGamePuluc](class_sand_box_1_1_board_games_1_1_board_game_puluc.html), [SandBox.BoardGames.BoardGameSeega](class_sand_box_1_1_board_games_1_1_board_game_seega.html), and [SandBox.BoardGames.BoardGameTablut](class_sand_box_1_1_board_games_1_1_board_game_tablut.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [InitializeUnits](class_sand_box_1_1_board_games_1_1_board_game_base.html#a2402b868620ea1d906a82fca7cc1aeb1) () |
| void | [InitializeTiles](class_sand_box_1_1_board_games_1_1_board_game_base.html#ac4539084220c83d5676477a4ac4fad9e) () |
| void | [InitializeSound](class_sand_box_1_1_board_games_1_1_board_game_base.html#a8648215288e8bfd151b378cf9844b48c) () |
| List< [Move](struct_sand_box_1_1_board_games_1_1_move.html) > | [CalculateValidMoves](class_sand_box_1_1_board_games_1_1_board_game_base.html#aca1649ba76caf279c671af8cbe29b536) ([PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) pawn) |
| virtual void | [RollDice](class_sand_box_1_1_board_games_1_1_board_game_base.html#a5fd1193147bdca844a2296878471e4af) () |
| virtual void | [InitializeDiceBoard](class_sand_box_1_1_board_games_1_1_board_game_base.html#aa9e033564d76333826161d37f59da3d1) () |
| virtual void | [Reset](class_sand_box_1_1_board_games_1_1_board_game_base.html#a5ec25b42b7bb3813427ffa223e5730c2) () |
| virtual void | [InitializeCapturedUnitsZones](class_sand_box_1_1_board_games_1_1_board_game_base.html#ad3dee4bda18ffc725f842fb98e959fd9) () |
| virtual void | [SetPawnCaptured](class_sand_box_1_1_board_games_1_1_board_game_base.html#acb2fec8241cd72d1c5995ab971f01aad) ([PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) pawn, bool fake=false) |
| virtual List< List< [Move](struct_sand_box_1_1_board_games_1_1_move.html) > > | [CalculateAllValidMoves](class_sand_box_1_1_board_games_1_1_board_game_base.html#a3d8c608fae47fd0c5bb6baec21f92711) ([BoardGameSide](namespace_sand_box_1_1_board_games.html#a2932623e2fafdc970ef0ed27f680d2f7) side) |
| void | [SetUserRay](class_sand_box_1_1_board_games_1_1_board_game_base.html#a95d6965edbb6fbe0b26cd5d0f38d1d1f) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) rayBegin, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) rayEnd) |
| void | [SetStartingPlayer](class_sand_box_1_1_board_games_1_1_board_game_base.html#ac6197897eeb33aa978525de80f2f3bce) ([PlayerTurn](namespace_sand_box_1_1_board_games.html#a75a1d942d9b6c180a65697998b1e9bfe) player) |
| void | [SetGameOverInfo](class_sand_box_1_1_board_games_1_1_board_game_base.html#ac8a90bf2f9640c29140b0997bc24a3e8) ([GameOverEnum](namespace_sand_box_1_1_board_games.html#ae41e8e73c4b3a94cf72401595a8cf6d6) info) |
| bool | [HasMovesAvailable](class_sand_box_1_1_board_games_1_1_board_game_base.html#a5ae228fc87bb18baeebe54c7ef148b04) (ref List< List< [Move](struct_sand_box_1_1_board_games_1_1_move.html) > > moves) |
| int | [GetTotalMovesAvailable](class_sand_box_1_1_board_games_1_1_board_game_base.html#a65d0c44c2728f9a92db67f1a5ed94a06) (ref List< List< [Move](struct_sand_box_1_1_board_games_1_1_move.html) > > moves) |
| void | [PlayDiceRollSound](class_sand_box_1_1_board_games_1_1_board_game_base.html#a27a927833689478969e1fe049df20505) () |
| int | [GetPlayerOneUnitsAlive](class_sand_box_1_1_board_games_1_1_board_game_base.html#aa34d9588edd4fdc3c34b7b5315ad149d) () |
| int | [GetPlayerTwoUnitsAlive](class_sand_box_1_1_board_games_1_1_board_game_base.html#a992b884f4a08eada763d874ba2277608) () |
| int | [GetPlayerOneUnitsDead](class_sand_box_1_1_board_games_1_1_board_game_base.html#a621638014fce94eab0ba7c3d841682fa) () |
| int | [GetPlayerTwoUnitsDead](class_sand_box_1_1_board_games_1_1_board_game_base.html#a64d12c41d710d30da7aa79df738b05a1) () |
| void | [Initialize](class_sand_box_1_1_board_games_1_1_board_game_base.html#a8ff92b4a87da4387689d8532f49dae62) () |
| bool | [Tick](class_sand_box_1_1_board_games_1_1_board_game_base.html#af43270da95243ecea06be0057a66b41c) (float dt) |
| void | [ForceDice](class_sand_box_1_1_board_games_1_1_board_game_base.html#a866a66a689a2b2ab891f5ce1206d4c2f) (int value) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const string | [StringBoardGame](class_sand_box_1_1_board_games_1_1_board_game_base.html#a3023b7a7a8ab2e1f8a0011a8cc7216b5) = "str\_boardgame" |
| const string | [StringForfeitQuestion](class_sand_box_1_1_board_games_1_1_board_game_base.html#a7801a187441399bf47d7ce01ff84288e) = "str\_boardgame\_forfeit\_question" |
| const string | [StringMovePiecePlayer](class_sand_box_1_1_board_games_1_1_board_game_base.html#a6ffacd43132eca749aa853f95ff2053e) = "str\_boardgame\_move\_piece\_player" |
| const string | [StringMovePieceOpponent](class_sand_box_1_1_board_games_1_1_board_game_base.html#a778185bb426a9328fd579cb06469ba54) = "str\_boardgame\_move\_piece\_opponent" |
| const string | [StringCapturePiecePlayer](class_sand_box_1_1_board_games_1_1_board_game_base.html#a3509f139e50229e5394bbf7023506e16) = "str\_boardgame\_capture\_piece\_player" |
| const string | [StringCapturePieceOpponent](class_sand_box_1_1_board_games_1_1_board_game_base.html#a3fcaaccc231c445280a06add04d57ec0) = "str\_boardgame\_capture\_piece\_opponent" |
| const string | [StringVictoryMessage](class_sand_box_1_1_board_games_1_1_board_game_base.html#a3c01aa424fd9a08275bb029cbd9fab13) = "str\_boardgame\_victory\_message" |
| const string | [StringDefeatMessage](class_sand_box_1_1_board_games_1_1_board_game_base.html#a2d4a228536e2e601347d186288c1faf6) = "str\_boardgame\_defeat\_message" |
| const string | [StringDrawMessage](class_sand_box_1_1_board_games_1_1_board_game_base.html#a9ce0a4c6d32b55451e3c563ce2c0fe3a) = "str\_boardgame\_draw\_message" |
| const string | [StringNoAvailableMovesPlayer](class_sand_box_1_1_board_games_1_1_board_game_base.html#a96edb913b1e5f0db6fece841b1f945d9) = "str\_boardgame\_no\_available\_moves\_player" |
| const string | [StringNoAvailableMovesOpponent](class_sand_box_1_1_board_games_1_1_board_game_base.html#a0f714a63873e7e2d1179f1a7e73bb200) = "str\_boardgame\_no\_available\_moves\_opponent" |
| const string | [StringSeegaBarrierByP1DrawMessage](class_sand_box_1_1_board_games_1_1_board_game_base.html#aedc12d1985aa5dfcd8be64b631eba551) = "str\_boardgame\_seega\_barrier\_by\_player\_one\_draw\_message" |
| const string | [StringSeegaBarrierByP2DrawMessage](class_sand_box_1_1_board_games_1_1_board_game_base.html#a5c91213ed0c88258f1b65dff9c0ae27c) = "str\_boardgame\_seega\_barrier\_by\_player\_two\_draw\_message" |
| const string | [StringSeegaBarrierByP1VictoryMessage](class_sand_box_1_1_board_games_1_1_board_game_base.html#ae492661271faf47f66355fff5f0f62d2) = "str\_boardgame\_seega\_barrier\_by\_player\_one\_victory\_message" |
| const string | [StringSeegaBarrierByP2VictoryMessage](class_sand_box_1_1_board_games_1_1_board_game_base.html#a1e8b657c7a5b64e005562de3b6d66015) = "str\_boardgame\_seega\_barrier\_by\_player\_two\_victory\_message" |
| const string | [StringSeegaBarrierByP1DefeatMessage](class_sand_box_1_1_board_games_1_1_board_game_base.html#a342d1eaaaa0f587dd558fb163f308e9f) = "str\_boardgame\_seega\_barrier\_by\_player\_one\_defeat\_message" |
| const string | [StringSeegaBarrierByP2DefeatMessage](class_sand_box_1_1_board_games_1_1_board_game_base.html#af3b35f577d08693adab48d7b9f814009) = "str\_boardgame\_seega\_barrier\_by\_player\_two\_defeat\_message" |
| const string | [StringRollDicePlayer](class_sand_box_1_1_board_games_1_1_board_game_base.html#a87ec5cf6a33d3ef39db07d30e4d09b82) = "str\_boardgame\_roll\_dice\_player" |
| const string | [StringRollDiceOpponent](class_sand_box_1_1_board_games_1_1_board_game_base.html#ad2c08cdcc82e2fceb2e913c75c5de9bd) = "str\_boardgame\_roll\_dice\_opponent" |

|  |  |
| --- | --- |
| Protected Member Functions | |
|  | [BoardGameBase](class_sand_box_1_1_board_games_1_1_board_game_base.html#a77221aa873a276f1ca87e3a145bd0a36) ([MissionBoardGameLogic](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html) mission, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) name, [PlayerTurn](namespace_sand_box_1_1_board_games.html#a75a1d942d9b6c180a65697998b1e9bfe) startingPlayer) |
| [PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) | [SelectPawn](class_sand_box_1_1_board_games_1_1_board_game_base.html#a406f608df80c2a062460c45c9ffa8321) ([PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) pawn) |
| bool | [CheckGameEnded](class_sand_box_1_1_board_games_1_1_board_game_base.html#a2c7ba84d99ef5c96957fc1456157abb6) () |
| void | [OnAfterBoardSetUp](class_sand_box_1_1_board_games_1_1_board_game_base.html#a043eb01e6d03de3a8eea9a907edb8717) () |
| virtual void | [OnAfterBoardRotated](class_sand_box_1_1_board_games_1_1_board_game_base.html#a10a4b2a409edd453c10db03c34fb2b7d) () |
| virtual void | [OnBeforeEndTurn](class_sand_box_1_1_board_games_1_1_board_game_base.html#a3556e6f2762dae8ea602b88ddcd05194) () |
| virtual void | [UpdateAllTilesPositions](class_sand_box_1_1_board_games_1_1_board_game_base.html#a615461d9400a15fb3425dc523caf6ad7) () |
| virtual void | [OnPawnArrivesGoalPosition](class_sand_box_1_1_board_games_1_1_board_game_base.html#a54f1a6f6fff0fffc734c2face09e80f0) ([PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) pawn, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) prevPos, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) currentPos) |
| virtual void | [HandlePreMovementStage](class_sand_box_1_1_board_games_1_1_board_game_base.html#ada0f33ccead63dc5b0c8b01e96651b6f) (float dt) |
| virtual void | [HandlePreMovementStageAI](class_sand_box_1_1_board_games_1_1_board_game_base.html#a3dd9515dcd4f709c83fbac40fe96f673) ([Move](struct_sand_box_1_1_board_games_1_1_move.html) move) |
| virtual void | [SwitchPlayerTurn](class_sand_box_1_1_board_games_1_1_board_game_base.html#a9ce77f118f2b245a5d5e85a758dca37a) () |
| virtual void | [MovePawnToTile](class_sand_box_1_1_board_games_1_1_board_game_base.html#a8ab007301be1ddd44b7f22520ff4a879) ([PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) pawn, [TileBase](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_base.html) tile, bool instantMove=false, bool displayMessage=true) |
| virtual void | [MovePawnToTileDelayed](class_sand_box_1_1_board_games_1_1_board_game_base.html#a1376d9e47ec3d625e2e6630d2eec2488) ([PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) pawn, [TileBase](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_base.html) tile, bool instantMove, bool displayMessage, float delay) |
| virtual void | [OnAfterDiceRollAnimation](class_sand_box_1_1_board_games_1_1_board_game_base.html#ac0338e5daf0a5ecab053ab32a88afd44) () |
| void | [RemovePawnFromBoard](class_sand_box_1_1_board_games_1_1_board_game_base.html#a1cd1d98360a36597ba12aeebff679c3e) ([PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) pawn, float speed, bool instantMove=false) |
| [PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) | [InitializeUnit](class_sand_box_1_1_board_games_1_1_board_game_base.html#a94ef9b9498b4a8f292c27e90727df452) ([PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) pawnToInit) |
| [Move](struct_sand_box_1_1_board_games_1_1_move.html) | [HandlePlayerInput](class_sand_box_1_1_board_games_1_1_board_game_base.html#a826d44095b492f3e9da4563257b6c76a) (float dt) |
| [PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) | [GetHoveredPawnIfAny](class_sand_box_1_1_board_games_1_1_board_game_base.html#a6df96f14c9baaa212c0053121a72743e) () |
| [TileBase](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_base.html) | [GetHoveredTileIfAny](class_sand_box_1_1_board_games_1_1_board_game_base.html#ae0da9e4a635e97e84ea87397ddc14c5b) () |
| void | [CheckSwitchPlayerTurn](class_sand_box_1_1_board_games_1_1_board_game_base.html#a1ae4d3d500a8c9c29bc9647ec44f35a1) () |
| void | [OnVictory](class_sand_box_1_1_board_games_1_1_board_game_base.html#af0e41e2b4afcf519cb6a9f3815382e00) (string message=[StringVictoryMessage](class_sand_box_1_1_board_games_1_1_board_game_base.html#a3c01aa424fd9a08275bb029cbd9fab13)) |
| void | [OnAfterEndTurn](class_sand_box_1_1_board_games_1_1_board_game_base.html#a723479b957392ea02940b879596c3f40) () |
| void | [OnDefeat](class_sand_box_1_1_board_games_1_1_board_game_base.html#a1f0600c4f1486fee34c7bd3b07e0faff) (string message=[StringDefeatMessage](class_sand_box_1_1_board_games_1_1_board_game_base.html#a2d4a228536e2e601347d186288c1faf6)) |
| void | [OnDraw](class_sand_box_1_1_board_games_1_1_board_game_base.html#a4eac9652ef52ea79f36cbba998280ff7) (string message=[StringDrawMessage](class_sand_box_1_1_board_games_1_1_board_game_base.html#a9ce0a4c6d32b55451e3c563ce2c0fe3a)) |
| void | [EndTurn](class_sand_box_1_1_board_games_1_1_board_game_base.html#af639d1b2d9e3f240c70d6877d4b95f37) () |
| void | [ClearValidMoves](class_sand_box_1_1_board_games_1_1_board_game_base.html#a2609a3d39e8e98cff153a2071f983c9f) () |
| void | [HideAllValidTiles](class_sand_box_1_1_board_games_1_1_board_game_base.html#a92bfbb9fd24874a14cf8cc1911b2094e) () |
| void | [ShowAllValidTiles](class_sand_box_1_1_board_games_1_1_board_game_base.html#a1f61fa838d3df06b5dfcb11484f0c79e) () |
| void | [OnAIWantsForfeit](class_sand_box_1_1_board_games_1_1_board_game_base.html#aef61a1ec4ff6655dfdcfd40b28497fca) () |

|  |  |
| --- | --- |
| Protected Attributes | |
| uint | [PawnSelectedFactor](class_sand_box_1_1_board_games_1_1_board_game_base.html#a2b0fffd4dbbad8784934c226fd6150aa) = 0xFFFFFFFF |
| uint | [PawnUnselectedFactor](class_sand_box_1_1_board_games_1_1_board_game_base.html#a6f5d068fce2211d179b4363f96192cf3) = 0xFF3D3D3D |
| [MissionBoardGameLogic](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html) | [MissionHandler](class_sand_box_1_1_board_games_1_1_board_game_base.html#ab5673e779b09d2eeefaf5d8c4cfe2827) |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [BoardEntity](class_sand_box_1_1_board_games_1_1_board_game_base.html#a53de1bc7232942ca82ae6ba187613c58) |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [DiceBoard](class_sand_box_1_1_board_games_1_1_board_game_base.html#aeec191917b8d03eec0715236831c89fc) |
| bool | [JustStoppedDraggingUnit](class_sand_box_1_1_board_games_1_1_board_game_base.html#a57ca5e0ad317588ab8c28674b75538f1) |
| [CapturedPawnsPool](class_sand_box_1_1_board_games_1_1_captured_pawns_pool.html) | [PlayerOnePool](class_sand_box_1_1_board_games_1_1_board_game_base.html#a70c7cfa5ca1598da17f7bee2fa65d834) |
| bool | [ReadyToPlay](class_sand_box_1_1_board_games_1_1_board_game_base.html#a1845c5e3a30855bb28539927f5929e3e) |
| [CapturedPawnsPool](class_sand_box_1_1_board_games_1_1_captured_pawns_pool.html) | [PlayerTwoPool](class_sand_box_1_1_board_games_1_1_board_game_base.html#a5bce381bfa66adfb490cbac8bed44d0f) |
| bool | [SettingUpBoard](class_sand_box_1_1_board_games_1_1_board_game_base.html#a174297fff4fb4e1cf7831dbd0c8ec4cc) = true |
| bool | [HasToMovePawnsAcross](class_sand_box_1_1_board_games_1_1_board_game_base.html#a5b116d59a04a82a269b76cf31dfc0b52) |
| float | [DiceRollAnimationTimer](class_sand_box_1_1_board_games_1_1_board_game_base.html#a0e10124e900e8cc42a6e989fc02b599e) |
| int | [MovesLeftToEndTurn](class_sand_box_1_1_board_games_1_1_board_game_base.html#aedde03e870373114bb67a18811587637) |
| bool | [DiceRollAnimationRunning](class_sand_box_1_1_board_games_1_1_board_game_base.html#ae6a12d4436d38524e05e6e87e28765f8) |
| int | [DiceRollSoundCodeID](class_sand_box_1_1_board_games_1_1_board_game_base.html#ab8be02269fd0a37651562887335738be) |

|  |  |
| --- | --- |
| Static Protected Attributes | |
| const int | [InvalidDice](class_sand_box_1_1_board_games_1_1_board_game_base.html#a7f5bb237c02172d143bc2b1b72b1ad5d) = -1 |
| const float | [DelayBeforeMovingAnyPawn](class_sand_box_1_1_board_games_1_1_board_game_base.html#a7f6af10972320fabf506ce0ae1732b15) = 0.25f |
| const float | [DelayBetweenPawnMovementsBegin](class_sand_box_1_1_board_games_1_1_board_game_base.html#a94faec1629408edfff0d497a580fda3c) = 0.15f |

|  |  |
| --- | --- |
| Properties | |
| int | [TileCount](class_sand_box_1_1_board_games_1_1_board_game_base.html#a55e1eeee78e073d11530a1d882ad01ea) `[get]` |
| bool | [RotateBoard](class_sand_box_1_1_board_games_1_1_board_game_base.html#a4ee1e3b83ab81b7e494b650f58901906) `[get]` |
| bool | [PreMovementStagePresent](class_sand_box_1_1_board_games_1_1_board_game_base.html#a8ec1e7b21d94df4aeeb4b139ab6bafeb) `[get]` |
| bool | [DiceRollRequired](class_sand_box_1_1_board_games_1_1_board_game_base.html#aa770cfdbc510f444af8e51f1460f6a9a) `[get]` |
| virtual int | [UnitsToPlacePerTurnInPreMovementStage](class_sand_box_1_1_board_games_1_1_board_game_base.html#ab0f5bfa6683415021e0208eb90b0c0b7) `[get]` |
| virtual [PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) | [SelectedUnit](class_sand_box_1_1_board_games_1_1_board_game_base.html#a0e33f8999efa060bfae5f8e6be1e6b54) `[get, set]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](class_sand_box_1_1_board_games_1_1_board_game_base.html#a4d5bc7d2c5c6bf6b156c70b152bc5d82) `[get]` |
| bool | [InPreMovementStage](class_sand_box_1_1_board_games_1_1_board_game_base.html#a949c7e6a206fbd5eb5229e7c34339b92) `[get, protected set]` |
| [TileBase](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_base.html)[] | [Tiles](class_sand_box_1_1_board_games_1_1_board_game_base.html#a6f2aad9ad1a4b97e3ec0fe7bc6304593) `[get, protected set]` |
| List< [PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) > | [PlayerOneUnits](class_sand_box_1_1_board_games_1_1_board_game_base.html#a937c9b2bd722ac7c87bd1024f7c053d7) `[get, protected set]` |
| List< [PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) > | [PlayerTwoUnits](class_sand_box_1_1_board_games_1_1_board_game_base.html#a5d378664871ed391e4ab56a318d072ef) `[get, protected set]` |
| int | [LastDice](class_sand_box_1_1_board_games_1_1_board_game_base.html#a3e7599d21ce2a908d773d2b4b3694469) `[get, protected set]` |
| bool | [IsReady](class_sand_box_1_1_board_games_1_1_board_game_base.html#a6842ddee2b4397fa252459e17ac45d21) `[get]` |
| [PlayerTurn](namespace_sand_box_1_1_board_games.html#a75a1d942d9b6c180a65697998b1e9bfe) | [PlayerWhoStarted](class_sand_box_1_1_board_games_1_1_board_game_base.html#ae3984811b862fc52ac858adb9a55d791) `[get]` |
| [GameOverEnum](namespace_sand_box_1_1_board_games.html#ae41e8e73c4b3a94cf72401595a8cf6d6) | [GameOverInfo](class_sand_box_1_1_board_games_1_1_board_game_base.html#ae5f7ea3f83b8ac741f026eddf34a448b) `[get]` |
| [PlayerTurn](namespace_sand_box_1_1_board_games.html#a75a1d942d9b6c180a65697998b1e9bfe) | [PlayerTurn](class_sand_box_1_1_board_games_1_1_board_game_base.html#a07697a6e493838f542051003183b1501) `[get, protected set]` |
| [IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html) | [InputManager](class_sand_box_1_1_board_games_1_1_board_game_base.html#a6bbe50a9e1e6000a4be18b14560b118a) `[get]` |
| List< [PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) > | [PawnSelectFilter](class_sand_box_1_1_board_games_1_1_board_game_base.html#ac301ffabd1789e47b0906fc5ecd1ae7a) `[get]` |
| [BoardGameAIBase](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html) | [AIOpponent](class_sand_box_1_1_board_games_1_1_board_game_base.html#aae987dc3fa29fb5df9cf44e4c0e570d4) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a77221aa873a276f1ca87e3a145bd0a36)BoardGameBase()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | SandBox.BoardGames.BoardGameBase.BoardGameBase | ( | [MissionBoardGameLogic](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html) | *mission*, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *name*, | |  |  | [PlayerTurn](namespace_sand_box_1_1_board_games.html#a75a1d942d9b6c180a65697998b1e9bfe) | *startingPlayer* ) | | protected |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a2402b868620ea1d906a82fca7cc1aeb1)InitializeUnits()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void SandBox.BoardGames.BoardGameBase.InitializeUnits | ( |  | ) |  | | abstract |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#ac4539084220c83d5676477a4ac4fad9e)InitializeTiles()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void SandBox.BoardGames.BoardGameBase.InitializeTiles | ( |  | ) |  | | abstract |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a8648215288e8bfd151b378cf9844b48c)InitializeSound()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void SandBox.BoardGames.BoardGameBase.InitializeSound | ( |  | ) |  | | abstract |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#aca1649ba76caf279c671af8cbe29b536)CalculateValidMoves()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | List< [Move](struct_sand_box_1_1_board_games_1_1_move.html) > SandBox.BoardGames.BoardGameBase.CalculateValidMoves | ( | [PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) | *pawn* | ) |  | | abstract |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a406f608df80c2a062460c45c9ffa8321)SelectPawn()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) SandBox.BoardGames.BoardGameBase.SelectPawn | ( | [PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) | *pawn* | ) |  | | abstractprotected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a2c7ba84d99ef5c96957fc1456157abb6)CheckGameEnded()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool SandBox.BoardGames.BoardGameBase.CheckGameEnded | ( |  | ) |  | | abstractprotected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a043eb01e6d03de3a8eea9a907edb8717)OnAfterBoardSetUp()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void SandBox.BoardGames.BoardGameBase.OnAfterBoardSetUp | ( |  | ) |  | | abstractprotected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a10a4b2a409edd453c10db03c34fb2b7d)OnAfterBoardRotated()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void SandBox.BoardGames.BoardGameBase.OnAfterBoardRotated | ( |  | ) |  | | protectedvirtual |

Reimplemented in [SandBox.BoardGames.BoardGameBaghChal](class_sand_box_1_1_board_games_1_1_board_game_bagh_chal.html#abf14b56a5597cdd914e1deea6410f43d).

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a3556e6f2762dae8ea602b88ddcd05194)OnBeforeEndTurn()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void SandBox.BoardGames.BoardGameBase.OnBeforeEndTurn | ( |  | ) |  | | protectedvirtual |

Reimplemented in [SandBox.BoardGames.BoardGamePuluc](class_sand_box_1_1_board_games_1_1_board_game_puluc.html#af2adce2a6e38a407cdc457968f3f2861).

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a5fd1193147bdca844a2296878471e4af)RollDice()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void SandBox.BoardGames.BoardGameBase.RollDice | ( |  | ) |  | | virtual |

Reimplemented in [SandBox.BoardGames.BoardGamePuluc](class_sand_box_1_1_board_games_1_1_board_game_puluc.html#a28b1ac4c2c49d1b86bcb6477dba9079f).

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a615461d9400a15fb3425dc523caf6ad7)UpdateAllTilesPositions()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void SandBox.BoardGames.BoardGameBase.UpdateAllTilesPositions | ( |  | ) |  | | protectedvirtual |

Reimplemented in [SandBox.BoardGames.BoardGamePuluc](class_sand_box_1_1_board_games_1_1_board_game_puluc.html#a6a796764febb8c5f69dab4a8b92c23a7).

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#aa9e033564d76333826161d37f59da3d1)InitializeDiceBoard()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void SandBox.BoardGames.BoardGameBase.InitializeDiceBoard | ( |  | ) |  | | virtual |

Reimplemented in [SandBox.BoardGames.BoardGamePuluc](class_sand_box_1_1_board_games_1_1_board_game_puluc.html#a12ab0f7d35482bdad1c406b6c23b9945).

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a5ec25b42b7bb3813427ffa223e5730c2)Reset()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void SandBox.BoardGames.BoardGameBase.Reset | ( |  | ) |  | | virtual |

Reimplemented in [SandBox.BoardGames.BoardGameBaghChal](class_sand_box_1_1_board_games_1_1_board_game_bagh_chal.html#a4fdb797f538a081040b0eff35f5ca826), [SandBox.BoardGames.BoardGameKonane](class_sand_box_1_1_board_games_1_1_board_game_konane.html#a085c875cddc00addf4c8433a4752aef3), [SandBox.BoardGames.BoardGameMuTorere](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#afed1febbc913fc2d7ccc587ba1a619b3), [SandBox.BoardGames.BoardGamePuluc](class_sand_box_1_1_board_games_1_1_board_game_puluc.html#ac19fb5020413f1ba79b17ddbb5881a4b), [SandBox.BoardGames.BoardGameSeega](class_sand_box_1_1_board_games_1_1_board_game_seega.html#a5c9e7eed391487a34e3ccf95d2395181), and [SandBox.BoardGames.BoardGameTablut](class_sand_box_1_1_board_games_1_1_board_game_tablut.html#ac19a6265265e5359c916996f21fb026d).

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a54f1a6f6fff0fffc734c2face09e80f0)OnPawnArrivesGoalPosition()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void SandBox.BoardGames.BoardGameBase.OnPawnArrivesGoalPosition | ( | [PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) | *pawn*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *prevPos*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *currentPos* ) | | protectedvirtual |

Reimplemented in [SandBox.BoardGames.BoardGameSeega](class_sand_box_1_1_board_games_1_1_board_game_seega.html#a9e493df56b5da807bc25468fca64a4ee).

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#ada0f33ccead63dc5b0c8b01e96651b6f)HandlePreMovementStage()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void SandBox.BoardGames.BoardGameBase.HandlePreMovementStage | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented in [SandBox.BoardGames.BoardGameBaghChal](class_sand_box_1_1_board_games_1_1_board_game_bagh_chal.html#aa6115c4d4432fbd77521538dd42bfbf6), [SandBox.BoardGames.BoardGameKonane](class_sand_box_1_1_board_games_1_1_board_game_konane.html#a5c5d71ca6a077a9ef727df2bb6080b1d), and [SandBox.BoardGames.BoardGameSeega](class_sand_box_1_1_board_games_1_1_board_game_seega.html#a928ed1f9c7003a3a4b4c74655176cdd4).

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#ad3dee4bda18ffc725f842fb98e959fd9)InitializeCapturedUnitsZones()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void SandBox.BoardGames.BoardGameBase.InitializeCapturedUnitsZones | ( |  | ) |  | | virtual |

Reimplemented in [SandBox.BoardGames.BoardGameMuTorere](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#a489f0d92117cca25b00e392f0024a342).

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a3dd9515dcd4f709c83fbac40fe96f673)HandlePreMovementStageAI()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void SandBox.BoardGames.BoardGameBase.HandlePreMovementStageAI | ( | [Move](struct_sand_box_1_1_board_games_1_1_move.html) | *move* | ) |  | | protectedvirtual |

Reimplemented in [SandBox.BoardGames.BoardGameBaghChal](class_sand_box_1_1_board_games_1_1_board_game_bagh_chal.html#a3008962a8ca8c058144f06eb4953917d), [SandBox.BoardGames.BoardGameKonane](class_sand_box_1_1_board_games_1_1_board_game_konane.html#a664418dad729afd6ccf0a3f430438853), and [SandBox.BoardGames.BoardGameSeega](class_sand_box_1_1_board_games_1_1_board_game_seega.html#aae19910c1c3338dc17b19ff6a1202872).

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#acb2fec8241cd72d1c5995ab971f01aad)SetPawnCaptured()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void SandBox.BoardGames.BoardGameBase.SetPawnCaptured | ( | [PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) | *pawn*, | |  |  | bool | *fake* = false ) | | virtual |

Reimplemented in [SandBox.BoardGames.BoardGameBaghChal](class_sand_box_1_1_board_games_1_1_board_game_bagh_chal.html#a702c32821b6fce937dc1167be7c82d66), [SandBox.BoardGames.BoardGameKonane](class_sand_box_1_1_board_games_1_1_board_game_konane.html#ad5849f990edff55a2cb5a2446cfd3c8f), [SandBox.BoardGames.BoardGameSeega](class_sand_box_1_1_board_games_1_1_board_game_seega.html#ada40963bd550ae32405ebdf0e03def37), and [SandBox.BoardGames.BoardGameTablut](class_sand_box_1_1_board_games_1_1_board_game_tablut.html#a28192c322829b33a12825dc8f0c5b468).

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a3d8c608fae47fd0c5bb6baec21f92711)CalculateAllValidMoves()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual List< List< [Move](struct_sand_box_1_1_board_games_1_1_move.html) > > SandBox.BoardGames.BoardGameBase.CalculateAllValidMoves | ( | [BoardGameSide](namespace_sand_box_1_1_board_games.html#a2932623e2fafdc970ef0ed27f680d2f7) | *side* | ) |  | | virtual |

Reimplemented in [SandBox.BoardGames.BoardGameBaghChal](class_sand_box_1_1_board_games_1_1_board_game_bagh_chal.html#a26bc0f30283bcf6253811fad16948b26).

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a9ce77f118f2b245a5d5e85a758dca37a)SwitchPlayerTurn()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void SandBox.BoardGames.BoardGameBase.SwitchPlayerTurn | ( |  | ) |  | | protectedvirtual |

Reimplemented in [SandBox.BoardGames.BoardGameBaghChal](class_sand_box_1_1_board_games_1_1_board_game_bagh_chal.html#a7e24a338585c6a7cc0f7d2c0ef131414), [SandBox.BoardGames.BoardGameKonane](class_sand_box_1_1_board_games_1_1_board_game_konane.html#a15d75ad06c03185dfa54ff46a279e562), [SandBox.BoardGames.BoardGameMuTorere](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#abccec9659ed50b925e00f82cf2ff3a35), [SandBox.BoardGames.BoardGamePuluc](class_sand_box_1_1_board_games_1_1_board_game_puluc.html#a989bed9cbadd2b111d3f7b23095e9736), [SandBox.BoardGames.BoardGameSeega](class_sand_box_1_1_board_games_1_1_board_game_seega.html#a7f8038943a9fb2224cc0b03f7463880c), and [SandBox.BoardGames.BoardGameTablut](class_sand_box_1_1_board_games_1_1_board_game_tablut.html#a79f5c07f9e4e2eb8e51293fe0690c6d7).

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a8ab007301be1ddd44b7f22520ff4a879)MovePawnToTile()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void SandBox.BoardGames.BoardGameBase.MovePawnToTile | ( | [PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) | *pawn*, | |  |  | [TileBase](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_base.html) | *tile*, | |  |  | bool | *instantMove* = false, | |  |  | bool | *displayMessage* = true ) | | protectedvirtual |

Reimplemented in [SandBox.BoardGames.BoardGamePuluc](class_sand_box_1_1_board_games_1_1_board_game_puluc.html#a290f608abcba91d25cc93ba7872c3887).

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a1376d9e47ec3d625e2e6630d2eec2488)MovePawnToTileDelayed()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void SandBox.BoardGames.BoardGameBase.MovePawnToTileDelayed | ( | [PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) | *pawn*, | |  |  | [TileBase](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_base.html) | *tile*, | |  |  | bool | *instantMove*, | |  |  | bool | *displayMessage*, | |  |  | float | *delay* ) | | protectedvirtual |

Reimplemented in [SandBox.BoardGames.BoardGameBaghChal](class_sand_box_1_1_board_games_1_1_board_game_bagh_chal.html#a24d05324f9fab07d3fb0a7afde4fe16d), [SandBox.BoardGames.BoardGameKonane](class_sand_box_1_1_board_games_1_1_board_game_konane.html#aff9b7c7c4edc6de0255177a5fc70d443), [SandBox.BoardGames.BoardGameMuTorere](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#a0f7edaa94c28af9ee8a50ece22aff85d), [SandBox.BoardGames.BoardGameSeega](class_sand_box_1_1_board_games_1_1_board_game_seega.html#a7a619ece135f458c87b93864fe0c5b8a), and [SandBox.BoardGames.BoardGameTablut](class_sand_box_1_1_board_games_1_1_board_game_tablut.html#a18efa909df90fbab93faf6bec4ff5206).

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#ac0338e5daf0a5ecab053ab32a88afd44)OnAfterDiceRollAnimation()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void SandBox.BoardGames.BoardGameBase.OnAfterDiceRollAnimation | ( |  | ) |  | | protectedvirtual |

Reimplemented in [SandBox.BoardGames.BoardGamePuluc](class_sand_box_1_1_board_games_1_1_board_game_puluc.html#af23386706cb01ffc59e5354edf9a8447).

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a95d6965edbb6fbe0b26cd5d0f38d1d1f)SetUserRay()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.BoardGames.BoardGameBase.SetUserRay | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *rayBegin*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *rayEnd* ) |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#ac6197897eeb33aa978525de80f2f3bce)SetStartingPlayer()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.BoardGames.BoardGameBase.SetStartingPlayer | ( | [PlayerTurn](namespace_sand_box_1_1_board_games.html#a75a1d942d9b6c180a65697998b1e9bfe) | *player* | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#ac8a90bf2f9640c29140b0997bc24a3e8)SetGameOverInfo()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.BoardGames.BoardGameBase.SetGameOverInfo | ( | [GameOverEnum](namespace_sand_box_1_1_board_games.html#ae41e8e73c4b3a94cf72401595a8cf6d6) | *info* | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a5ae228fc87bb18baeebe54c7ef148b04)HasMovesAvailable()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool SandBox.BoardGames.BoardGameBase.HasMovesAvailable | ( | ref List< List< [Move](struct_sand_box_1_1_board_games_1_1_move.html) > > | *moves* | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a65d0c44c2728f9a92db67f1a5ed94a06)GetTotalMovesAvailable()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int SandBox.BoardGames.BoardGameBase.GetTotalMovesAvailable | ( | ref List< List< [Move](struct_sand_box_1_1_board_games_1_1_move.html) > > | *moves* | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a27a927833689478969e1fe049df20505)PlayDiceRollSound()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.BoardGames.BoardGameBase.PlayDiceRollSound | ( |  | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#aa34d9588edd4fdc3c34b7b5315ad149d)GetPlayerOneUnitsAlive()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int SandBox.BoardGames.BoardGameBase.GetPlayerOneUnitsAlive | ( |  | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a992b884f4a08eada763d874ba2277608)GetPlayerTwoUnitsAlive()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int SandBox.BoardGames.BoardGameBase.GetPlayerTwoUnitsAlive | ( |  | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a621638014fce94eab0ba7c3d841682fa)GetPlayerOneUnitsDead()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int SandBox.BoardGames.BoardGameBase.GetPlayerOneUnitsDead | ( |  | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a64d12c41d710d30da7aa79df738b05a1)GetPlayerTwoUnitsDead()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int SandBox.BoardGames.BoardGameBase.GetPlayerTwoUnitsDead | ( |  | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a8ff92b4a87da4387689d8532f49dae62)Initialize()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.BoardGames.BoardGameBase.Initialize | ( |  | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a1cd1d98360a36597ba12aeebff679c3e)RemovePawnFromBoard()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void SandBox.BoardGames.BoardGameBase.RemovePawnFromBoard | ( | [PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) | *pawn*, | |  |  | float | *speed*, | |  |  | bool | *instantMove* = false ) | | protected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#af43270da95243ecea06be0057a66b41c)Tick()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool SandBox.BoardGames.BoardGameBase.Tick | ( | float | *dt* | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a866a66a689a2b2ab891f5ce1206d4c2f)ForceDice()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.BoardGames.BoardGameBase.ForceDice | ( | int | *value* | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a94ef9b9498b4a8f292c27e90727df452)InitializeUnit()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) SandBox.BoardGames.BoardGameBase.InitializeUnit | ( | [PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) | *pawnToInit* | ) |  | | protected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a826d44095b492f3e9da4563257b6c76a)HandlePlayerInput()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Move](struct_sand_box_1_1_board_games_1_1_move.html) SandBox.BoardGames.BoardGameBase.HandlePlayerInput | ( | float | *dt* | ) |  | | protected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a6df96f14c9baaa212c0053121a72743e)GetHoveredPawnIfAny()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) SandBox.BoardGames.BoardGameBase.GetHoveredPawnIfAny | ( |  | ) |  | | protected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#ae0da9e4a635e97e84ea87397ddc14c5b)GetHoveredTileIfAny()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [TileBase](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_base.html) SandBox.BoardGames.BoardGameBase.GetHoveredTileIfAny | ( |  | ) |  | | protected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a1ae4d3d500a8c9c29bc9647ec44f35a1)CheckSwitchPlayerTurn()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void SandBox.BoardGames.BoardGameBase.CheckSwitchPlayerTurn | ( |  | ) |  | | protected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#af0e41e2b4afcf519cb6a9f3815382e00)OnVictory()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void SandBox.BoardGames.BoardGameBase.OnVictory | ( | string | *message* = [StringVictoryMessage](class_sand_box_1_1_board_games_1_1_board_game_base.html#a3c01aa424fd9a08275bb029cbd9fab13) | ) |  | | protected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a723479b957392ea02940b879596c3f40)OnAfterEndTurn()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void SandBox.BoardGames.BoardGameBase.OnAfterEndTurn | ( |  | ) |  | | protected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a1f0600c4f1486fee34c7bd3b07e0faff)OnDefeat()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void SandBox.BoardGames.BoardGameBase.OnDefeat | ( | string | *message* = [StringDefeatMessage](class_sand_box_1_1_board_games_1_1_board_game_base.html#a2d4a228536e2e601347d186288c1faf6) | ) |  | | protected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a4eac9652ef52ea79f36cbba998280ff7)OnDraw()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void SandBox.BoardGames.BoardGameBase.OnDraw | ( | string | *message* = [StringDrawMessage](class_sand_box_1_1_board_games_1_1_board_game_base.html#a9ce0a4c6d32b55451e3c563ce2c0fe3a) | ) |  | | protected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#af639d1b2d9e3f240c70d6877d4b95f37)EndTurn()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void SandBox.BoardGames.BoardGameBase.EndTurn | ( |  | ) |  | | protected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a2609a3d39e8e98cff153a2071f983c9f)ClearValidMoves()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void SandBox.BoardGames.BoardGameBase.ClearValidMoves | ( |  | ) |  | | protected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a92bfbb9fd24874a14cf8cc1911b2094e)HideAllValidTiles()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void SandBox.BoardGames.BoardGameBase.HideAllValidTiles | ( |  | ) |  | | protected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a1f61fa838d3df06b5dfcb11484f0c79e)ShowAllValidTiles()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void SandBox.BoardGames.BoardGameBase.ShowAllValidTiles | ( |  | ) |  | | protected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#aef61a1ec4ff6655dfdcfd40b28497fca)OnAIWantsForfeit()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void SandBox.BoardGames.BoardGameBase.OnAIWantsForfeit | ( |  | ) |  | | protected |

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a3023b7a7a8ab2e1f8a0011a8cc7216b5)StringBoardGame
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string SandBox.BoardGames.BoardGameBase.StringBoardGame = "str\_boardgame" | | static |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a7801a187441399bf47d7ce01ff84288e)StringForfeitQuestion
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string SandBox.BoardGames.BoardGameBase.StringForfeitQuestion = "str\_boardgame\_forfeit\_question" | | static |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a6ffacd43132eca749aa853f95ff2053e)StringMovePiecePlayer
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string SandBox.BoardGames.BoardGameBase.StringMovePiecePlayer = "str\_boardgame\_move\_piece\_player" | | static |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a778185bb426a9328fd579cb06469ba54)StringMovePieceOpponent
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string SandBox.BoardGames.BoardGameBase.StringMovePieceOpponent = "str\_boardgame\_move\_piece\_opponent" | | static |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a3509f139e50229e5394bbf7023506e16)StringCapturePiecePlayer
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string SandBox.BoardGames.BoardGameBase.StringCapturePiecePlayer = "str\_boardgame\_capture\_piece\_player" | | static |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a3fcaaccc231c445280a06add04d57ec0)StringCapturePieceOpponent
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string SandBox.BoardGames.BoardGameBase.StringCapturePieceOpponent = "str\_boardgame\_capture\_piece\_opponent" | | static |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a3c01aa424fd9a08275bb029cbd9fab13)StringVictoryMessage
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string SandBox.BoardGames.BoardGameBase.StringVictoryMessage = "str\_boardgame\_victory\_message" | | static |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a2d4a228536e2e601347d186288c1faf6)StringDefeatMessage
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string SandBox.BoardGames.BoardGameBase.StringDefeatMessage = "str\_boardgame\_defeat\_message" | | static |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a9ce0a4c6d32b55451e3c563ce2c0fe3a)StringDrawMessage
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string SandBox.BoardGames.BoardGameBase.StringDrawMessage = "str\_boardgame\_draw\_message" | | static |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a96edb913b1e5f0db6fece841b1f945d9)StringNoAvailableMovesPlayer
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string SandBox.BoardGames.BoardGameBase.StringNoAvailableMovesPlayer = "str\_boardgame\_no\_available\_moves\_player" | | static |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a0f714a63873e7e2d1179f1a7e73bb200)StringNoAvailableMovesOpponent
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string SandBox.BoardGames.BoardGameBase.StringNoAvailableMovesOpponent = "str\_boardgame\_no\_available\_moves\_opponent" | | static |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#aedc12d1985aa5dfcd8be64b631eba551)StringSeegaBarrierByP1DrawMessage
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string SandBox.BoardGames.BoardGameBase.StringSeegaBarrierByP1DrawMessage = "str\_boardgame\_seega\_barrier\_by\_player\_one\_draw\_message" | | static |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a5c91213ed0c88258f1b65dff9c0ae27c)StringSeegaBarrierByP2DrawMessage
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string SandBox.BoardGames.BoardGameBase.StringSeegaBarrierByP2DrawMessage = "str\_boardgame\_seega\_barrier\_by\_player\_two\_draw\_message" | | static |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#ae492661271faf47f66355fff5f0f62d2)StringSeegaBarrierByP1VictoryMessage
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string SandBox.BoardGames.BoardGameBase.StringSeegaBarrierByP1VictoryMessage = "str\_boardgame\_seega\_barrier\_by\_player\_one\_victory\_message" | | static |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a1e8b657c7a5b64e005562de3b6d66015)StringSeegaBarrierByP2VictoryMessage
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string SandBox.BoardGames.BoardGameBase.StringSeegaBarrierByP2VictoryMessage = "str\_boardgame\_seega\_barrier\_by\_player\_two\_victory\_message" | | static |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a342d1eaaaa0f587dd558fb163f308e9f)StringSeegaBarrierByP1DefeatMessage
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string SandBox.BoardGames.BoardGameBase.StringSeegaBarrierByP1DefeatMessage = "str\_boardgame\_seega\_barrier\_by\_player\_one\_defeat\_message" | | static |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#af3b35f577d08693adab48d7b9f814009)StringSeegaBarrierByP2DefeatMessage
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string SandBox.BoardGames.BoardGameBase.StringSeegaBarrierByP2DefeatMessage = "str\_boardgame\_seega\_barrier\_by\_player\_two\_defeat\_message" | | static |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a87ec5cf6a33d3ef39db07d30e4d09b82)StringRollDicePlayer
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string SandBox.BoardGames.BoardGameBase.StringRollDicePlayer = "str\_boardgame\_roll\_dice\_player" | | static |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#ad2c08cdcc82e2fceb2e913c75c5de9bd)StringRollDiceOpponent
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string SandBox.BoardGames.BoardGameBase.StringRollDiceOpponent = "str\_boardgame\_roll\_dice\_opponent" | | static |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a7f5bb237c02172d143bc2b1b72b1ad5d)InvalidDice
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int SandBox.BoardGames.BoardGameBase.InvalidDice = -1 | | staticprotected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a7f6af10972320fabf506ce0ae1732b15)DelayBeforeMovingAnyPawn
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float SandBox.BoardGames.BoardGameBase.DelayBeforeMovingAnyPawn = 0.25f | | staticprotected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a94faec1629408edfff0d497a580fda3c)DelayBetweenPawnMovementsBegin
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float SandBox.BoardGames.BoardGameBase.DelayBetweenPawnMovementsBegin = 0.15f | | staticprotected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a2b0fffd4dbbad8784934c226fd6150aa)PawnSelectedFactor
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint SandBox.BoardGames.BoardGameBase.PawnSelectedFactor = 0xFFFFFFFF | | protected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a6f5d068fce2211d179b4363f96192cf3)PawnUnselectedFactor
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint SandBox.BoardGames.BoardGameBase.PawnUnselectedFactor = 0xFF3D3D3D | | protected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#ab5673e779b09d2eeefaf5d8c4cfe2827)MissionHandler
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MissionBoardGameLogic](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html) SandBox.BoardGames.BoardGameBase.MissionHandler | | protected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a53de1bc7232942ca82ae6ba187613c58)BoardEntity
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) SandBox.BoardGames.BoardGameBase.BoardEntity | | protected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#aeec191917b8d03eec0715236831c89fc)DiceBoard
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) SandBox.BoardGames.BoardGameBase.DiceBoard | | protected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a57ca5e0ad317588ab8c28674b75538f1)JustStoppedDraggingUnit
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.BoardGames.BoardGameBase.JustStoppedDraggingUnit | | protected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a70c7cfa5ca1598da17f7bee2fa65d834)PlayerOnePool
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CapturedPawnsPool](class_sand_box_1_1_board_games_1_1_captured_pawns_pool.html) SandBox.BoardGames.BoardGameBase.PlayerOnePool | | protected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a1845c5e3a30855bb28539927f5929e3e)ReadyToPlay
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.BoardGames.BoardGameBase.ReadyToPlay | | protected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a5bce381bfa66adfb490cbac8bed44d0f)PlayerTwoPool
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CapturedPawnsPool](class_sand_box_1_1_board_games_1_1_captured_pawns_pool.html) SandBox.BoardGames.BoardGameBase.PlayerTwoPool | | protected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a174297fff4fb4e1cf7831dbd0c8ec4cc)SettingUpBoard
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.BoardGames.BoardGameBase.SettingUpBoard = true | | protected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a5b116d59a04a82a269b76cf31dfc0b52)HasToMovePawnsAcross
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.BoardGames.BoardGameBase.HasToMovePawnsAcross | | protected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a0e10124e900e8cc42a6e989fc02b599e)DiceRollAnimationTimer
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float SandBox.BoardGames.BoardGameBase.DiceRollAnimationTimer | | protected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#aedde03e870373114bb67a18811587637)MovesLeftToEndTurn
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.BoardGames.BoardGameBase.MovesLeftToEndTurn | | protected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#ae6a12d4436d38524e05e6e87e28765f8)DiceRollAnimationRunning
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.BoardGames.BoardGameBase.DiceRollAnimationRunning | | protected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#ab8be02269fd0a37651562887335738be)DiceRollSoundCodeID
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.BoardGames.BoardGameBase.DiceRollSoundCodeID | | protected |

Property Documentation
----------------------

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a55e1eeee78e073d11530a1d882ad01ea)TileCount
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.BoardGames.BoardGameBase.TileCount | | getabstract |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a4ee1e3b83ab81b7e494b650f58901906)RotateBoard
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.BoardGames.BoardGameBase.RotateBoard | | getabstractprotected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a8ec1e7b21d94df4aeeb4b139ab6bafeb)PreMovementStagePresent
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.BoardGames.BoardGameBase.PreMovementStagePresent | | getabstractprotected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#aa770cfdbc510f444af8e51f1460f6a9a)DiceRollRequired
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.BoardGames.BoardGameBase.DiceRollRequired | | getabstractprotected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#ab0f5bfa6683415021e0208eb90b0c0b7)UnitsToPlacePerTurnInPreMovementStage
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual int SandBox.BoardGames.BoardGameBase.UnitsToPlacePerTurnInPreMovementStage | | getprotected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a0e33f8999efa060bfae5f8e6be1e6b54)SelectedUnit
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual [PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) SandBox.BoardGames.BoardGameBase.SelectedUnit | | getsetprotected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a4d5bc7d2c5c6bf6b156c70b152bc5d82)Name
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) SandBox.BoardGames.BoardGameBase.Name | | get |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a949c7e6a206fbd5eb5229e7c34339b92)InPreMovementStage
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.BoardGames.BoardGameBase.InPreMovementStage | | getprotected set |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a6f2aad9ad1a4b97e3ec0fe7bc6304593)Tiles
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TileBase](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_base.html) [] SandBox.BoardGames.BoardGameBase.Tiles | | getprotected set |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a937c9b2bd722ac7c87bd1024f7c053d7)PlayerOneUnits
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html)> SandBox.BoardGames.BoardGameBase.PlayerOneUnits | | getprotected set |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a5d378664871ed391e4ab56a318d072ef)PlayerTwoUnits
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html)> SandBox.BoardGames.BoardGameBase.PlayerTwoUnits | | getprotected set |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a3e7599d21ce2a908d773d2b4b3694469)LastDice
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.BoardGames.BoardGameBase.LastDice | | getprotected set |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a6842ddee2b4397fa252459e17ac45d21)IsReady
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.BoardGames.BoardGameBase.IsReady | | get |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#ae3984811b862fc52ac858adb9a55d791)PlayerWhoStarted
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PlayerTurn](namespace_sand_box_1_1_board_games.html#a75a1d942d9b6c180a65697998b1e9bfe) SandBox.BoardGames.BoardGameBase.PlayerWhoStarted | | get |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#ae5f7ea3f83b8ac741f026eddf34a448b)GameOverInfo
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GameOverEnum](namespace_sand_box_1_1_board_games.html#ae41e8e73c4b3a94cf72401595a8cf6d6) SandBox.BoardGames.BoardGameBase.GameOverInfo | | get |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a07697a6e493838f542051003183b1501)PlayerTurn
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PlayerTurn](namespace_sand_box_1_1_board_games.html#a75a1d942d9b6c180a65697998b1e9bfe) SandBox.BoardGames.BoardGameBase.PlayerTurn | | getprotected set |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#a6bbe50a9e1e6000a4be18b14560b118a)InputManager
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html) SandBox.BoardGames.BoardGameBase.InputManager | | getprotected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#ac301ffabd1789e47b0906fc5ecd1ae7a)PawnSelectFilter
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html)> SandBox.BoardGames.BoardGameBase.PawnSelectFilter | | getprotected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_base.html#aae987dc3fa29fb5df9cf44e4c0e570d4)AIOpponent
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BoardGameAIBase](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html) SandBox.BoardGames.BoardGameBase.AIOpponent | | getprotected |

