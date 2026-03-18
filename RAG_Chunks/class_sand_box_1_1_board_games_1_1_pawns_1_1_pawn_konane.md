--- SOURCE: class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_konane.html ---

SandBox.BoardGames.Pawns.PawnKonane Class ReferenceInherits [SandBox.BoardGames.Pawns.PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [PawnKonane](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_konane.html#ac44836fe33c62b7631da03fa854d4f12) ([GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) entity, bool playerOne) |
| override void | [Reset](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_konane.html#a9dd5a4e76d5e171e95c5cc455623a628) () |
| Public Member Functions inherited from [SandBox.BoardGames.Pawns.PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) | |
| virtual void | [AddGoalPosition](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a25a5b8252d8079a903a99177dffa4479) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) goal) |
| virtual void | [SetPawnAtPosition](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#ae7ac49ab784baacf9e05c1a56c2a435c) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position) |
| virtual void | [MovePawnToGoalPositions](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a5d06ace40b6f7d7dfce1689175349a7f) (bool instantMove, float speed, bool dragged=false) |
| virtual void | [EnableCollisionBody](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a9e93b3262b5352eea366ec9847f5adb1) () |
| virtual void | [DisableCollisionBody](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a816beb3474c66a707270188704be3410) () |
| void | [Tick](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a23f316bc36d7eaaef0c154cf335cf59d) (float dt) |
| void | [MovePawnToGoalPositionsDelayed](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a1e41f5da7e1fdf940d01cd3578e84cb7) (bool instantMove, float speed, bool dragged, float delay) |
| void | [SetPlayerOne](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#ad28e3b70f2e3fde59506d17d6966744f) (bool playerOne) |
| void | [ClearGoalPositions](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#aa059c65d107f16eefbb65abb0132596f) () |
| void | [UpdatePawnPosition](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a66fa8f6f21885c305e9d60e58cb6df55) () |
| void | [PlayPawnSelectSound](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a67465cf2861a88baee9d03fa5a61b97e) () |

|  |  |
| --- | --- |
| Public Attributes | |
| int | [X](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_konane.html#ad268ead68cca081e579a9b771facba68) |
| int | [Y](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_konane.html#a71934d4808a8487c7026ef7115702832) |
| int | [PrevX](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_konane.html#a72c48c193c112c50b0ea84f4bdf5a05b) |
| int | [PrevY](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_konane.html#a4d447b3317fbbab5b1b3b807e71cb0e2) |
| Public Attributes inherited from [SandBox.BoardGames.Pawns.PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) | |
| Action< [PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a3e17dd27c274733a28facb905a8e154f), [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html), [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) > | [OnArrivedIntermediateGoalPosition](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a0d21aba76834e59664ee4cb7381da1bd) |
| Action< [PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a3e17dd27c274733a28facb905a8e154f), [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html), [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) > | [OnArrivedFinalGoalPosition](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a500006f18d04944995f955eb119ef0a9) |

|  |  |
| --- | --- |
| Properties | |
| override bool | [IsPlaced](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_konane.html#a4c9fc67eaeed5a60f178e88202e2a122) `[get]` |
| Properties inherited from [SandBox.BoardGames.Pawns.PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) | |
| static int | [PawnMoveSoundCodeID](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#afe63d442a2603a642d9f701262f82d4c) `[get, set]` |
| static int | [PawnSelectSoundCodeID](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#ae557c0897ce91ecec31b25336f687d3b) `[get, set]` |
| static int | [PawnTapSoundCodeID](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#ad9246415b5bac79be3ee6424cb5cb93a) `[get, set]` |
| static int | [PawnRemoveSoundCodeID](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a6c3f9e847c7e591bf845211bdcf5def0) `[get, set]` |
| bool | [IsPlaced](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a582dadb72ea2c36c6c3a3be2d275dec4) `[get]` |
| virtual [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [PosBeforeMoving](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a14e18c58b94d1535261961b50059e113) `[get, protected set]` |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [Entity](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#afc9cebc692db7204473a0e970028473e) `[get]` |
| List< [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) > | [GoalPositions](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a13839ca2ae72f859bc66a00ce8dcb33d) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [CurrentPos](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#ac327d34a0e2f27e24cad53194f084dd3) `[get]` |
| bool | [Captured](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a00026e6978c6144ed5493798f4b6d140) `[get, set]` |
| bool | [MovingToDifferentTile](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a4310426e5a1c15651a7b8c0cfb083d05) `[get, set]` |
| bool | [Moving](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#ae445305b8e0d2c8f9f9a32a645382e84) `[get]` |
| bool | [PlayerOne](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a393a57ff1651c32d9356ff331447a74d) `[get]` |
| bool | [HasAnyGoalPosition](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a4f7dec38bbfcf0cfa5ac745eee1671d7) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Protected Member Functions inherited from [SandBox.BoardGames.Pawns.PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) | |
|  | [PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a3e17dd27c274733a28facb905a8e154f) ([GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) entity, bool playerOne) |
| Protected Attributes inherited from [SandBox.BoardGames.Pawns.PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) | |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [PosBeforeMovingBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a4e858989e78202d7012a4beca1a14910) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_konane.html#ac44836fe33c62b7631da03fa854d4f12)PawnKonane()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| SandBox.BoardGames.Pawns.PawnKonane.PawnKonane | ( | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *entity*, |
|  |  | bool | *playerOne* ) |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_konane.html#a9dd5a4e76d5e171e95c5cc455623a628)Reset()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.BoardGames.Pawns.PawnKonane.Reset | ( |  | ) |  | | virtual |

Reimplemented from [SandBox.BoardGames.Pawns.PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a388301780c442a0b19e1d464f1f56e1f).

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_konane.html#ad268ead68cca081e579a9b771facba68)X
-----------------------------------------------------------------------------------------------------

|  |
| --- |
| int SandBox.BoardGames.Pawns.PawnKonane.X |

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_konane.html#a71934d4808a8487c7026ef7115702832)Y
-----------------------------------------------------------------------------------------------------

|  |
| --- |
| int SandBox.BoardGames.Pawns.PawnKonane.Y |

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_konane.html#a72c48c193c112c50b0ea84f4bdf5a05b)PrevX
---------------------------------------------------------------------------------------------------------

|  |
| --- |
| int SandBox.BoardGames.Pawns.PawnKonane.PrevX |

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_konane.html#a4d447b3317fbbab5b1b3b807e71cb0e2)PrevY
---------------------------------------------------------------------------------------------------------

|  |
| --- |
| int SandBox.BoardGames.Pawns.PawnKonane.PrevY |

Property Documentation
----------------------

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_konane.html#a4c9fc67eaeed5a60f178e88202e2a122)IsPlaced
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override bool SandBox.BoardGames.Pawns.PawnKonane.IsPlaced | | get |

