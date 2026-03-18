--- SOURCE: class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_puluc.html ---

SandBox.BoardGames.Tiles.TilePuluc Class ReferenceInherits [SandBox.BoardGames.Tiles.Tile1D](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile1_d.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [TilePuluc](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_puluc.html#a6bea8d6192d15beb4dc7ccbb5504f976) ([GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) entity, [BoardGameDecal](class_sand_box_1_1_board_games_1_1_objects_1_1_board_game_decal.html) decal, int x) |
| void | [UpdateTilePosition](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_puluc.html#ae037615227dd1b1573b076395cd88447) () |
| Public Member Functions inherited from [SandBox.BoardGames.Tiles.Tile1D](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile1_d.html) | |
|  | [Tile1D](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile1_d.html#aba1328e252ebadd42021187c634bfd4f) ([GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) entity, [BoardGameDecal](class_sand_box_1_1_board_games_1_1_objects_1_1_board_game_decal.html) decal, int x) |
| Public Member Functions inherited from [SandBox.BoardGames.Tiles.TileBase](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_base.html) | |
| virtual void | [Reset](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_base.html#ab91cdbf7034ffb111c6113f2b96a1a01) () |
| void | [Tick](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_base.html#a78412075983e3d00f5186d9c61b35d73) (float dt) |
| void | [SetVisibility](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_base.html#a23723bd7de903c8aaa99d3dd338548c6) (bool isVisible) |

|  |  |
| --- | --- |
| Properties | |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [PosLeft](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_puluc.html#ab1cbc25b16f019dd9084aab7c532faac) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [PosLeftMid](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_puluc.html#a1666d03940dc8d5274326488663dbea6) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [PosRight](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_puluc.html#aef75aace3c67fe8983ea0adfced195f1) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [PosRightMid](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_puluc.html#a80fdc4768b65038576d498e3b153ea4d) `[get]` |
| Properties inherited from [SandBox.BoardGames.Tiles.Tile1D](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile1_d.html) | |
| int | [X](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile1_d.html#aba70a784985962ecfcf0535e8aeb9438) `[get]` |
| Properties inherited from [SandBox.BoardGames.Tiles.TileBase](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_base.html) | |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [Entity](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_base.html#a61fc46fa731bf11ac3ad6ff1fd8a8a0b) `[get]` |
| [BoardGameDecal](class_sand_box_1_1_board_games_1_1_objects_1_1_board_game_decal.html) | [ValidMoveDecal](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_base.html#acc51ddf5645df26bc3864d6999ceb99e) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Attributes inherited from [SandBox.BoardGames.Tiles.TileBase](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_base.html) | |
| [PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) | [PawnOnTile](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_base.html#a6209dc540b1e1a81f9c100c90656dba6) |
| Protected Member Functions inherited from [SandBox.BoardGames.Tiles.TileBase](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_base.html) | |
|  | [TileBase](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_base.html#a2cbec3a6acc05696322095f1cc9c48d7) ([GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) entity, [BoardGameDecal](class_sand_box_1_1_board_games_1_1_objects_1_1_board_game_decal.html) decal) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_puluc.html#a6bea8d6192d15beb4dc7ccbb5504f976)TilePuluc()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| SandBox.BoardGames.Tiles.TilePuluc.TilePuluc | ( | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *entity*, |
|  |  | [BoardGameDecal](class_sand_box_1_1_board_games_1_1_objects_1_1_board_game_decal.html) | *decal*, |
|  |  | int | *x* ) |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_puluc.html#ae037615227dd1b1573b076395cd88447)UpdateTilePosition()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.BoardGames.Tiles.TilePuluc.UpdateTilePosition | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_puluc.html#ab1cbc25b16f019dd9084aab7c532faac)PosLeft
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) SandBox.BoardGames.Tiles.TilePuluc.PosLeft | | get |

[◆](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_puluc.html#a1666d03940dc8d5274326488663dbea6)PosLeftMid
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) SandBox.BoardGames.Tiles.TilePuluc.PosLeftMid | | get |

[◆](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_puluc.html#aef75aace3c67fe8983ea0adfced195f1)PosRight
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) SandBox.BoardGames.Tiles.TilePuluc.PosRight | | get |

[◆](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_puluc.html#a80fdc4768b65038576d498e3b153ea4d)PosRightMid
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) SandBox.BoardGames.Tiles.TilePuluc.PosRightMid | | get |

