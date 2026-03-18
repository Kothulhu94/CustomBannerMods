--- SOURCE: class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html ---

SandBox.BoardGames.Pawns.PawnPuluc Class ReferenceInherits [SandBox.BoardGames.Pawns.PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [MovementState](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#a543851f80f41a5d6dd1d77507d9b6b67) {     [MovingForward](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#a543851f80f41a5d6dd1d77507d9b6b67af132ce714faeb12ac8ce177f29829e71) ,     [MovingBackward](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#a543851f80f41a5d6dd1d77507d9b6b67a534be42511e11f8aeb9bfded064ffe8e) ,     [ChangingDirection](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#a543851f80f41a5d6dd1d77507d9b6b67aa341c790316fd5312dd64730b1c06a29)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [PawnPuluc](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#a4a572f1707d6b2d3361514722ab692c7) ([GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) entity, bool playerOne) |
| override void | [Reset](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#aaa883cf3253012d82abdc4745c3f9b2f) () |
| override void | [AddGoalPosition](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#a218a87d9594bac63af20472d358b4b26) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) goal) |
| override void | [MovePawnToGoalPositions](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#a1a6b69c4266e572ede818b29955390cb) (bool instantMove, float speed, bool dragged=false) |
| override void | [SetPawnAtPosition](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#a0ba1736b78217ef7f8a91ea6747e82c4) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position) |
| override void | [EnableCollisionBody](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#a982d58c8597fced408c94015ffc110fc) () |
| override void | [DisableCollisionBody](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#a9cac39d312b6514d1146aff938fbb8a0) () |
| void | [MovePawnBackToSpawn](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#acf9974315e8ffbc5cf53578b1ce3f115) (bool instantMove, float speed, bool fake=false) |
| Public Member Functions inherited from [SandBox.BoardGames.Pawns.PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) | |
| void | [Tick](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a23f316bc36d7eaaef0c154cf335cf59d) (float dt) |
| void | [MovePawnToGoalPositionsDelayed](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a1e41f5da7e1fdf940d01cd3578e84cb7) (bool instantMove, float speed, bool dragged, float delay) |
| void | [SetPlayerOne](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#ad28e3b70f2e3fde59506d17d6966744f) (bool playerOne) |
| void | [ClearGoalPositions](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#aa059c65d107f16eefbb65abb0132596f) () |
| void | [UpdatePawnPosition](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a66fa8f6f21885c305e9d60e58cb6df55) () |
| void | [PlayPawnSelectSound](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a67465cf2861a88baee9d03fa5a61b97e) () |

|  |  |
| --- | --- |
| Public Attributes | |
| [MovementState](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#a543851f80f41a5d6dd1d77507d9b6b67) | [State](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#a0c735cf07a2b66084df58188315211e2) |
| [PawnPuluc](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#a4a572f1707d6b2d3361514722ab692c7) | [CapturedBy](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#aec931f0adf915a49082f1df7c5e5a2c0) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [SpawnPos](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#a02f1ef1b6aa0bc7efebb8d5c4d2d132b) |
| bool | [IsInSpawn](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#ad09e626cbb6faf584235cc5b06a7a98a) = true |
| bool | [IsTopPawn](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#ac9f8588536200335682d8f3c22dedf06) = true |
| Public Attributes inherited from [SandBox.BoardGames.Pawns.PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) | |
| Action< [PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a3e17dd27c274733a28facb905a8e154f), [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html), [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) > | [OnArrivedIntermediateGoalPosition](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a0d21aba76834e59664ee4cb7381da1bd) |
| Action< [PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a3e17dd27c274733a28facb905a8e154f), [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html), [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) > | [OnArrivedFinalGoalPosition](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a500006f18d04944995f955eb119ef0a9) |

|  |  |
| --- | --- |
| Properties | |
| float | [Height](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#a1950ba0e0c01fa576e1ed271e4fd4d27) `[get]` |
| override [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [PosBeforeMoving](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#ac83cb4b0d6a5055c8d868a248cb5ae94) `[get]` |
| override bool | [IsPlaced](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#a6dd5ba73e260a4f6bb84ecf940adc9c8) `[get]` |
| int | [X](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#a09a3d594e7d7ac7355206abe63cd4f87) `[get, set]` |
| List< [PawnPuluc](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#a4a572f1707d6b2d3361514722ab692c7) > | [PawnsBelow](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#acbe0bbda1fc8baa23dd071da318921dd) `[get]` |
| bool | [InPlay](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#a951981c7c11760bac0133263ecbdd327) `[get]` |
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

Member Enumeration Documentation
--------------------------------

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#a543851f80f41a5d6dd1d77507d9b6b67)MovementState
----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [SandBox.BoardGames.Pawns.PawnPuluc.MovementState](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#a543851f80f41a5d6dd1d77507d9b6b67) |

| Enumerator | |
| --- | --- |
| MovingForward |  |
| MovingBackward |  |
| ChangingDirection |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#a4a572f1707d6b2d3361514722ab692c7)PawnPuluc()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| SandBox.BoardGames.Pawns.PawnPuluc.PawnPuluc | ( | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *entity*, |
|  |  | bool | *playerOne* ) |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#aaa883cf3253012d82abdc4745c3f9b2f)Reset()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.BoardGames.Pawns.PawnPuluc.Reset | ( |  | ) |  | | virtual |

Reimplemented from [SandBox.BoardGames.Pawns.PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a388301780c442a0b19e1d464f1f56e1f).

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#a218a87d9594bac63af20472d358b4b26)AddGoalPosition()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.BoardGames.Pawns.PawnPuluc.AddGoalPosition | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *goal* | ) |  | | virtual |

Reimplemented from [SandBox.BoardGames.Pawns.PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a25a5b8252d8079a903a99177dffa4479).

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#a1a6b69c4266e572ede818b29955390cb)MovePawnToGoalPositions()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void SandBox.BoardGames.Pawns.PawnPuluc.MovePawnToGoalPositions | ( | bool | *instantMove*, | |  |  | float | *speed*, | |  |  | bool | *dragged* = false ) | | virtual |

Reimplemented from [SandBox.BoardGames.Pawns.PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a5d06ace40b6f7d7dfce1689175349a7f).

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#a0ba1736b78217ef7f8a91ea6747e82c4)SetPawnAtPosition()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.BoardGames.Pawns.PawnPuluc.SetPawnAtPosition | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position* | ) |  | | virtual |

Reimplemented from [SandBox.BoardGames.Pawns.PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#ae7ac49ab784baacf9e05c1a56c2a435c).

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#a982d58c8597fced408c94015ffc110fc)EnableCollisionBody()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.BoardGames.Pawns.PawnPuluc.EnableCollisionBody | ( |  | ) |  | | virtual |

Reimplemented from [SandBox.BoardGames.Pawns.PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a9e93b3262b5352eea366ec9847f5adb1).

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#a9cac39d312b6514d1146aff938fbb8a0)DisableCollisionBody()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.BoardGames.Pawns.PawnPuluc.DisableCollisionBody | ( |  | ) |  | | virtual |

Reimplemented from [SandBox.BoardGames.Pawns.PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html#a816beb3474c66a707270188704be3410).

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#acf9974315e8ffbc5cf53578b1ce3f115)MovePawnBackToSpawn()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.BoardGames.Pawns.PawnPuluc.MovePawnBackToSpawn | ( | bool | *instantMove*, |
|  |  | float | *speed*, |
|  |  | bool | *fake* = false ) |

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#a0c735cf07a2b66084df58188315211e2)State
--------------------------------------------------------------------------------------------------------

|  |
| --- |
| [MovementState](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#a543851f80f41a5d6dd1d77507d9b6b67) SandBox.BoardGames.Pawns.PawnPuluc.State |

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#aec931f0adf915a49082f1df7c5e5a2c0)CapturedBy
-------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [PawnPuluc](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#a4a572f1707d6b2d3361514722ab692c7) SandBox.BoardGames.Pawns.PawnPuluc.CapturedBy |

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#a02f1ef1b6aa0bc7efebb8d5c4d2d132b)SpawnPos
-----------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) SandBox.BoardGames.Pawns.PawnPuluc.SpawnPos |

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#ad09e626cbb6faf584235cc5b06a7a98a)IsInSpawn
------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool SandBox.BoardGames.Pawns.PawnPuluc.IsInSpawn = true |

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#ac9f8588536200335682d8f3c22dedf06)IsTopPawn
------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool SandBox.BoardGames.Pawns.PawnPuluc.IsTopPawn = true |

Property Documentation
----------------------

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#a1950ba0e0c01fa576e1ed271e4fd4d27)Height
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float SandBox.BoardGames.Pawns.PawnPuluc.Height | | get |

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#ac83cb4b0d6a5055c8d868a248cb5ae94)PosBeforeMoving
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) SandBox.BoardGames.Pawns.PawnPuluc.PosBeforeMoving | | get |

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#a6dd5ba73e260a4f6bb84ecf940adc9c8)IsPlaced
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override bool SandBox.BoardGames.Pawns.PawnPuluc.IsPlaced | | get |

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#a09a3d594e7d7ac7355206abe63cd4f87)X
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.BoardGames.Pawns.PawnPuluc.X | | getset |

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#acbe0bbda1fc8baa23dd071da318921dd)PawnsBelow
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[PawnPuluc](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#a4a572f1707d6b2d3361514722ab692c7)> SandBox.BoardGames.Pawns.PawnPuluc.PawnsBelow | | get |

[◆](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_puluc.html#a951981c7c11760bac0133263ecbdd327)InPlay
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.BoardGames.Pawns.PawnPuluc.InPlay | | get |

