--- SOURCE: class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html ---

SandBox.BoardGames.BoardGameMuTorere Class ReferenceInherits [SandBox.BoardGames.BoardGameBase](class_sand_box_1_1_board_games_1_1_board_game_base.html).

|  |  |
| --- | --- |
| Classes | |
| struct | [BoardInformation](struct_sand_box_1_1_board_games_1_1_board_game_mu_torere_1_1_board_information.html) |
| struct | [PawnInformation](struct_sand_box_1_1_board_games_1_1_board_game_mu_torere_1_1_pawn_information.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [BoardGameMuTorere](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#a96c36bce0b7e88412670ab93dfe28ef1) ([MissionBoardGameLogic](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html) mission, [PlayerTurn](namespace_sand_box_1_1_board_games.html#a75a1d942d9b6c180a65697998b1e9bfe) startingPlayer) |
| override void | [InitializeUnits](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#a551f85a5ccc482e5d45fcdda4a6719e4) () |
| override void | [InitializeTiles](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#ad8f5d870df92e48d1003039278a7d1da) () |
| override void | [InitializeCapturedUnitsZones](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#a489f0d92117cca25b00e392f0024a342) () |
| override void | [InitializeSound](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#a8a349bc627c463469f3c320b4a4d3ca2) () |
| override void | [Reset](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#afed1febbc913fc2d7ccc587ba1a619b3) () |
| override List< [Move](struct_sand_box_1_1_board_games_1_1_move.html) > | [CalculateValidMoves](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#a880c70fbda223f9999ac5014721e4b1e) ([PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) pawn) |
| [TileMuTorere](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_mu_torere.html) | [FindTileByCoordinate](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#ad6769e232ab70d9c10165413cf6d289b) (int x) |
| [BoardInformation](struct_sand_box_1_1_board_games_1_1_board_game_mu_torere_1_1_board_information.html) | [TakePawnsSnapshot](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#aa4b87c994e7035e9c0c55734eb378fed) () |
| void | [UndoMove](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#a575cb0bd7ea44808c92feb1acb81b6f5) (ref [BoardInformation](struct_sand_box_1_1_board_games_1_1_board_game_mu_torere_1_1_board_information.html) board) |
| void | [AIMakeMove](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#a30553fefe8945e84adb4e0ff6b8c8b1c) ([Move](struct_sand_box_1_1_board_games_1_1_move.html) move) |
| [TileBase](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_base.html) | [FindAvailableTile](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#a381cf4cdca50b5ce1e7e873b6d98437d) () |
| Public Member Functions inherited from [SandBox.BoardGames.BoardGameBase](class_sand_box_1_1_board_games_1_1_board_game_base.html) | |
| void | [InitializeUnits](class_sand_box_1_1_board_games_1_1_board_game_base.html#a2402b868620ea1d906a82fca7cc1aeb1) () |
| void | [InitializeTiles](class_sand_box_1_1_board_games_1_1_board_game_base.html#ac4539084220c83d5676477a4ac4fad9e) () |
| void | [InitializeSound](class_sand_box_1_1_board_games_1_1_board_game_base.html#a8648215288e8bfd151b378cf9844b48c) () |
| List< [Move](struct_sand_box_1_1_board_games_1_1_move.html) > | [CalculateValidMoves](class_sand_box_1_1_board_games_1_1_board_game_base.html#aca1649ba76caf279c671af8cbe29b536) ([PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) pawn) |
| virtual void | [RollDice](class_sand_box_1_1_board_games_1_1_board_game_base.html#a5fd1193147bdca844a2296878471e4af) () |
| virtual void | [InitializeDiceBoard](class_sand_box_1_1_board_games_1_1_board_game_base.html#aa9e033564d76333826161d37f59da3d1) () |
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
| const int | [WhitePawnCount](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#a1e5a775a0a48e1894c74c4da9a6b4dc5) = 4 |
| const int | [BlackPawnCount](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#a87734ac1c5404bea910f3b5cb7d87254) = 4 |
| Static Public Attributes inherited from [SandBox.BoardGames.BoardGameBase](class_sand_box_1_1_board_games_1_1_board_game_base.html) | |
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
| override [PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) | [SelectPawn](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#adbe38bd3e16171b6b4501f9d25414317) ([PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) pawn) |
| override void | [MovePawnToTileDelayed](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#a0f7edaa94c28af9ee8a50ece22aff85d) ([PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) pawn, [TileBase](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_base.html) tile, bool instantMove, bool displayMessage, float delay) |
| override void | [SwitchPlayerTurn](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#abccec9659ed50b925e00f82cf2ff3a35) () |
| override bool | [CheckGameEnded](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#adb0f9602822388d460a9bab38f1996c7) () |
| override void | [OnAfterBoardSetUp](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#a61ff1586723821037a543c702328fb7a) () |
| Protected Member Functions inherited from [SandBox.BoardGames.BoardGameBase](class_sand_box_1_1_board_games_1_1_board_game_base.html) | |
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
| virtual void | [MovePawnToTile](class_sand_box_1_1_board_games_1_1_board_game_base.html#a8ab007301be1ddd44b7f22520ff4a879) ([PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) pawn, [TileBase](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_base.html) tile, bool instantMove=false, bool displayMessage=true) |
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
| Properties | |
| override int | [TileCount](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#ad8dc1c7658d86cbd65d65ee8a9851a1b) `[get]` |
| override bool | [RotateBoard](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#a822aebdc044cc2472e007506069c26f9) `[get]` |
| override bool | [PreMovementStagePresent](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#a792b3af04ddf5649b4b1d9789e69cbfb) `[get]` |
| override bool | [DiceRollRequired](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#aafa9eb3c6c5019c47678de3b7574b985) `[get]` |
| Properties inherited from [SandBox.BoardGames.BoardGameBase](class_sand_box_1_1_board_games_1_1_board_game_base.html) | |
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

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Protected Attributes inherited from [SandBox.BoardGames.BoardGameBase](class_sand_box_1_1_board_games_1_1_board_game_base.html) | |
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
| Static Protected Attributes inherited from [SandBox.BoardGames.BoardGameBase](class_sand_box_1_1_board_games_1_1_board_game_base.html) | |
| const int | [InvalidDice](class_sand_box_1_1_board_games_1_1_board_game_base.html#a7f5bb237c02172d143bc2b1b72b1ad5d) = -1 |
| const float | [DelayBeforeMovingAnyPawn](class_sand_box_1_1_board_games_1_1_board_game_base.html#a7f6af10972320fabf506ce0ae1732b15) = 0.25f |
| const float | [DelayBetweenPawnMovementsBegin](class_sand_box_1_1_board_games_1_1_board_game_base.html#a94faec1629408edfff0d497a580fda3c) = 0.15f |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#a96c36bce0b7e88412670ab93dfe28ef1)BoardGameMuTorere()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| SandBox.BoardGames.BoardGameMuTorere.BoardGameMuTorere | ( | [MissionBoardGameLogic](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html) | *mission*, |
|  |  | [PlayerTurn](namespace_sand_box_1_1_board_games.html#a75a1d942d9b6c180a65697998b1e9bfe) | *startingPlayer* ) |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#a551f85a5ccc482e5d45fcdda4a6719e4)InitializeUnits()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void SandBox.BoardGames.BoardGameMuTorere.InitializeUnits | ( |  | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#ad8f5d870df92e48d1003039278a7d1da)InitializeTiles()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void SandBox.BoardGames.BoardGameMuTorere.InitializeTiles | ( |  | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#a489f0d92117cca25b00e392f0024a342)InitializeCapturedUnitsZones()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.BoardGames.BoardGameMuTorere.InitializeCapturedUnitsZones | ( |  | ) |  | | virtual |

Reimplemented from [SandBox.BoardGames.BoardGameBase](class_sand_box_1_1_board_games_1_1_board_game_base.html#ad3dee4bda18ffc725f842fb98e959fd9).

[◆](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#a8a349bc627c463469f3c320b4a4d3ca2)InitializeSound()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void SandBox.BoardGames.BoardGameMuTorere.InitializeSound | ( |  | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#afed1febbc913fc2d7ccc587ba1a619b3)Reset()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.BoardGames.BoardGameMuTorere.Reset | ( |  | ) |  | | virtual |

Reimplemented from [SandBox.BoardGames.BoardGameBase](class_sand_box_1_1_board_games_1_1_board_game_base.html#a5ec25b42b7bb3813427ffa223e5730c2).

[◆](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#a880c70fbda223f9999ac5014721e4b1e)CalculateValidMoves()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override List< [Move](struct_sand_box_1_1_board_games_1_1_move.html) > SandBox.BoardGames.BoardGameMuTorere.CalculateValidMoves | ( | [PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) | *pawn* | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#adbe38bd3e16171b6b4501f9d25414317)SelectPawn()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override [PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) SandBox.BoardGames.BoardGameMuTorere.SelectPawn | ( | [PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) | *pawn* | ) |  | | protected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#a0f7edaa94c28af9ee8a50ece22aff85d)MovePawnToTileDelayed()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void SandBox.BoardGames.BoardGameMuTorere.MovePawnToTileDelayed | ( | [PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) | *pawn*, | |  |  | [TileBase](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_base.html) | *tile*, | |  |  | bool | *instantMove*, | |  |  | bool | *displayMessage*, | |  |  | float | *delay* ) | | protectedvirtual |

Reimplemented from [SandBox.BoardGames.BoardGameBase](class_sand_box_1_1_board_games_1_1_board_game_base.html#a1376d9e47ec3d625e2e6630d2eec2488).

[◆](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#abccec9659ed50b925e00f82cf2ff3a35)SwitchPlayerTurn()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.BoardGames.BoardGameMuTorere.SwitchPlayerTurn | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.BoardGames.BoardGameBase](class_sand_box_1_1_board_games_1_1_board_game_base.html#a9ce77f118f2b245a5d5e85a758dca37a).

[◆](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#adb0f9602822388d460a9bab38f1996c7)CheckGameEnded()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override bool SandBox.BoardGames.BoardGameMuTorere.CheckGameEnded | ( |  | ) |  | | protected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#a61ff1586723821037a543c702328fb7a)OnAfterBoardSetUp()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.BoardGames.BoardGameMuTorere.OnAfterBoardSetUp | ( |  | ) |  | | protected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#ad6769e232ab70d9c10165413cf6d289b)FindTileByCoordinate()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [TileMuTorere](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_mu_torere.html) SandBox.BoardGames.BoardGameMuTorere.FindTileByCoordinate | ( | int | *x* | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#aa4b87c994e7035e9c0c55734eb378fed)TakePawnsSnapshot()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [BoardInformation](struct_sand_box_1_1_board_games_1_1_board_game_mu_torere_1_1_board_information.html) SandBox.BoardGames.BoardGameMuTorere.TakePawnsSnapshot | ( |  | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#a575cb0bd7ea44808c92feb1acb81b6f5)UndoMove()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.BoardGames.BoardGameMuTorere.UndoMove | ( | ref [BoardInformation](struct_sand_box_1_1_board_games_1_1_board_game_mu_torere_1_1_board_information.html) | *board* | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#a30553fefe8945e84adb4e0ff6b8c8b1c)AIMakeMove()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.BoardGames.BoardGameMuTorere.AIMakeMove | ( | [Move](struct_sand_box_1_1_board_games_1_1_move.html) | *move* | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#a381cf4cdca50b5ce1e7e873b6d98437d)FindAvailableTile()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [TileBase](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_base.html) SandBox.BoardGames.BoardGameMuTorere.FindAvailableTile | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#a1e5a775a0a48e1894c74c4da9a6b4dc5)WhitePawnCount
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int SandBox.BoardGames.BoardGameMuTorere.WhitePawnCount = 4 | | static |

[◆](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#a87734ac1c5404bea910f3b5cb7d87254)BlackPawnCount
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int SandBox.BoardGames.BoardGameMuTorere.BlackPawnCount = 4 | | static |

Property Documentation
----------------------

[◆](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#ad8dc1c7658d86cbd65d65ee8a9851a1b)TileCount
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int SandBox.BoardGames.BoardGameMuTorere.TileCount | | get |

[◆](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#a822aebdc044cc2472e007506069c26f9)RotateBoard
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override bool SandBox.BoardGames.BoardGameMuTorere.RotateBoard | | getprotected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#a792b3af04ddf5649b4b1d9789e69cbfb)PreMovementStagePresent
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override bool SandBox.BoardGames.BoardGameMuTorere.PreMovementStagePresent | | getprotected |

[◆](class_sand_box_1_1_board_games_1_1_board_game_mu_torere.html#aafa9eb3c6c5019c47678de3b7574b985)DiceRollRequired
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override bool SandBox.BoardGames.BoardGameMuTorere.DiceRollRequired | | getprotected |

