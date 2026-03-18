--- SOURCE: class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html ---

SandBox.BoardGames.Pawns.PawnBase Class ReferenceabstractInherited by [SandBox.BoardGames.Pawns.PawnBaghChal](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_bagh_chal.html), [SandBox.BoardGames.Pawns.PawnKonane](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_konane.html), [SandBox.BoardGames.Pawns.PawnMuTorere](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_mu_torere.html), [SandBox.BoardGames.Pawns.PawnPuluc](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html), [SandBox.BoardGames.Pawns.PawnSeega](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_seega.html), and [SandBox.BoardGames.Pawns.PawnTablut](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_tablut.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| virtual void | [Reset](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a388301780c442a0b19e1d464f1f56e1f) () |
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
| Action< [PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a3e17dd27c274733a28facb905a8e154f), [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html), [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) > | [OnArrivedIntermediateGoalPosition](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a0d21aba76834e59664ee4cb7381da1bd) |
| Action< [PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a3e17dd27c274733a28facb905a8e154f), [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html), [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) > | [OnArrivedFinalGoalPosition](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a500006f18d04944995f955eb119ef0a9) |

|  |  |
| --- | --- |
| Protected Member Functions | |
|  | [PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a3e17dd27c274733a28facb905a8e154f) ([GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) entity, bool playerOne) |

|  |  |
| --- | --- |
| Protected Attributes | |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [PosBeforeMovingBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a4e858989e78202d7012a4beca1a14910) |

|  |  |
| --- | --- |
| Properties | |
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

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a3e17dd27c274733a28facb905a8e154f)PawnBase()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | SandBox.BoardGames.Pawns.PawnBase.PawnBase | ( | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *entity*, | |  |  | bool | *playerOne* ) | | protected |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a388301780c442a0b19e1d464f1f56e1f)Reset()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void SandBox.BoardGames.Pawns.PawnBase.Reset | ( |  | ) |  | | virtual |

Reimplemented in [SandBox.BoardGames.Pawns.PawnBaghChal](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_bagh_chal.html#a8ba697f85fab1012b657b8d934a86e9a), [SandBox.BoardGames.Pawns.PawnKonane](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_konane.html#a9dd5a4e76d5e171e95c5cc455623a628), [SandBox.BoardGames.Pawns.PawnMuTorere](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_mu_torere.html#a790198d47a21ccc11acbbc6f687da525), [SandBox.BoardGames.Pawns.PawnPuluc](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#aaa883cf3253012d82abdc4745c3f9b2f), [SandBox.BoardGames.Pawns.PawnSeega](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_seega.html#a6efdb208f81b98fd67c4e32cb4e3daad), and [SandBox.BoardGames.Pawns.PawnTablut](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_tablut.html#aab9975cbd8d1b5215a675908f4c3106b).

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a25a5b8252d8079a903a99177dffa4479)AddGoalPosition()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void SandBox.BoardGames.Pawns.PawnBase.AddGoalPosition | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *goal* | ) |  | | virtual |

Reimplemented in [SandBox.BoardGames.Pawns.PawnPuluc](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#a218a87d9594bac63af20472d358b4b26).

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#ae7ac49ab784baacf9e05c1a56c2a435c)SetPawnAtPosition()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void SandBox.BoardGames.Pawns.PawnBase.SetPawnAtPosition | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position* | ) |  | | virtual |

Reimplemented in [SandBox.BoardGames.Pawns.PawnPuluc](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#a0ba1736b78217ef7f8a91ea6747e82c4).

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a5d06ace40b6f7d7dfce1689175349a7f)MovePawnToGoalPositions()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void SandBox.BoardGames.Pawns.PawnBase.MovePawnToGoalPositions | ( | bool | *instantMove*, | |  |  | float | *speed*, | |  |  | bool | *dragged* = false ) | | virtual |

Reimplemented in [SandBox.BoardGames.Pawns.PawnPuluc](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#a1a6b69c4266e572ede818b29955390cb).

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a9e93b3262b5352eea366ec9847f5adb1)EnableCollisionBody()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void SandBox.BoardGames.Pawns.PawnBase.EnableCollisionBody | ( |  | ) |  | | virtual |

Reimplemented in [SandBox.BoardGames.Pawns.PawnPuluc](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#a982d58c8597fced408c94015ffc110fc).

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a816beb3474c66a707270188704be3410)DisableCollisionBody()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void SandBox.BoardGames.Pawns.PawnBase.DisableCollisionBody | ( |  | ) |  | | virtual |

Reimplemented in [SandBox.BoardGames.Pawns.PawnPuluc](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#a9cac39d312b6514d1146aff938fbb8a0).

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a23f316bc36d7eaaef0c154cf335cf59d)Tick()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.BoardGames.Pawns.PawnBase.Tick | ( | float | *dt* | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a1e41f5da7e1fdf940d01cd3578e84cb7)MovePawnToGoalPositionsDelayed()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.BoardGames.Pawns.PawnBase.MovePawnToGoalPositionsDelayed | ( | bool | *instantMove*, |
|  |  | float | *speed*, |
|  |  | bool | *dragged*, |
|  |  | float | *delay* ) |

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#ad28e3b70f2e3fde59506d17d6966744f)SetPlayerOne()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.BoardGames.Pawns.PawnBase.SetPlayerOne | ( | bool | *playerOne* | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#aa059c65d107f16eefbb65abb0132596f)ClearGoalPositions()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.BoardGames.Pawns.PawnBase.ClearGoalPositions | ( |  | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a66fa8f6f21885c305e9d60e58cb6df55)UpdatePawnPosition()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.BoardGames.Pawns.PawnBase.UpdatePawnPosition | ( |  | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a67465cf2861a88baee9d03fa5a61b97e)PlayPawnSelectSound()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.BoardGames.Pawns.PawnBase.PlayPawnSelectSound | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a0d21aba76834e59664ee4cb7381da1bd)OnArrivedIntermediateGoalPosition
-----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a3e17dd27c274733a28facb905a8e154f), [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html), [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html)> SandBox.BoardGames.Pawns.PawnBase.OnArrivedIntermediateGoalPosition |

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a500006f18d04944995f955eb119ef0a9)OnArrivedFinalGoalPosition
----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a3e17dd27c274733a28facb905a8e154f), [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html), [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html)> SandBox.BoardGames.Pawns.PawnBase.OnArrivedFinalGoalPosition |

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a4e858989e78202d7012a4beca1a14910)PosBeforeMovingBase
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) SandBox.BoardGames.Pawns.PawnBase.PosBeforeMovingBase | | protected |

Property Documentation
----------------------

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#afe63d442a2603a642d9f701262f82d4c)PawnMoveSoundCodeID
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.BoardGames.Pawns.PawnBase.PawnMoveSoundCodeID | | staticgetset |

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#ae557c0897ce91ecec31b25336f687d3b)PawnSelectSoundCodeID
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.BoardGames.Pawns.PawnBase.PawnSelectSoundCodeID | | staticgetset |

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#ad9246415b5bac79be3ee6424cb5cb93a)PawnTapSoundCodeID
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.BoardGames.Pawns.PawnBase.PawnTapSoundCodeID | | staticgetset |

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a6c3f9e847c7e591bf845211bdcf5def0)PawnRemoveSoundCodeID
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.BoardGames.Pawns.PawnBase.PawnRemoveSoundCodeID | | staticgetset |

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a582dadb72ea2c36c6c3a3be2d275dec4)IsPlaced
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.BoardGames.Pawns.PawnBase.IsPlaced | | getabstract |

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a14e18c58b94d1535261961b50059e113)PosBeforeMoving
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) SandBox.BoardGames.Pawns.PawnBase.PosBeforeMoving | | getprotected set |

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#afc9cebc692db7204473a0e970028473e)Entity
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) SandBox.BoardGames.Pawns.PawnBase.Entity | | get |

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a13839ca2ae72f859bc66a00ce8dcb33d)GoalPositions
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html)> SandBox.BoardGames.Pawns.PawnBase.GoalPositions | | getprotected |

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#ac327d34a0e2f27e24cad53194f084dd3)CurrentPos
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) SandBox.BoardGames.Pawns.PawnBase.CurrentPos | | getprotected |

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a00026e6978c6144ed5493798f4b6d140)Captured
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.BoardGames.Pawns.PawnBase.Captured | | getset |

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a4310426e5a1c15651a7b8c0cfb083d05)MovingToDifferentTile
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.BoardGames.Pawns.PawnBase.MovingToDifferentTile | | getset |

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#ae445305b8e0d2c8f9f9a32a645382e84)Moving
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.BoardGames.Pawns.PawnBase.Moving | | get |

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a393a57ff1651c32d9356ff331447a74d)PlayerOne
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.BoardGames.Pawns.PawnBase.PlayerOne | | get |

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a4f7dec38bbfcf0cfa5ac745eee1671d7)HasAnyGoalPosition
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.BoardGames.Pawns.PawnBase.HasAnyGoalPosition | | get |

