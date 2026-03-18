--- SOURCE: class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_base.html ---

SandBox.BoardGames.Tiles.TileBase Class ReferenceabstractInherited by [SandBox.BoardGames.Tiles.Tile1D](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile1_d.html), and [SandBox.BoardGames.Tiles.Tile2D](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile2_d.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| virtual void | [Reset](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_base.html#ab91cdbf7034ffb111c6113f2b96a1a01) () |
| void | [Tick](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_base.html#a78412075983e3d00f5186d9c61b35d73) (float dt) |
| void | [SetVisibility](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_base.html#a23723bd7de903c8aaa99d3dd338548c6) (bool isVisible) |

|  |  |
| --- | --- |
| Public Attributes | |
| [PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) | [PawnOnTile](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_base.html#a6209dc540b1e1a81f9c100c90656dba6) |

|  |  |
| --- | --- |
| Protected Member Functions | |
|  | [TileBase](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_base.html#a2cbec3a6acc05696322095f1cc9c48d7) ([GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) entity, [BoardGameDecal](class_sand_box_1_1_board_games_1_1_objects_1_1_board_game_decal.html) decal) |

|  |  |
| --- | --- |
| Properties | |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [Entity](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_base.html#a61fc46fa731bf11ac3ad6ff1fd8a8a0b) `[get]` |
| [BoardGameDecal](class_sand_box_1_1_board_games_1_1_objects_1_1_board_game_decal.html) | [ValidMoveDecal](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_base.html#acc51ddf5645df26bc3864d6999ceb99e) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_base.html#a2cbec3a6acc05696322095f1cc9c48d7)TileBase()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | SandBox.BoardGames.Tiles.TileBase.TileBase | ( | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *entity*, | |  |  | [BoardGameDecal](class_sand_box_1_1_board_games_1_1_objects_1_1_board_game_decal.html) | *decal* ) | | protected |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_base.html#ab91cdbf7034ffb111c6113f2b96a1a01)Reset()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void SandBox.BoardGames.Tiles.TileBase.Reset | ( |  | ) |  | | virtual |

[◆](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_base.html#a78412075983e3d00f5186d9c61b35d73)Tick()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.BoardGames.Tiles.TileBase.Tick | ( | float | *dt* | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_base.html#a23723bd7de903c8aaa99d3dd338548c6)SetVisibility()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.BoardGames.Tiles.TileBase.SetVisibility | ( | bool | *isVisible* | ) |  |

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_base.html#a6209dc540b1e1a81f9c100c90656dba6)PawnOnTile
------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [PawnBase](class_sand_box_1_1_board_games_1_1_pawns_1_1_pawn_base.html) SandBox.BoardGames.Tiles.TileBase.PawnOnTile |

Property Documentation
----------------------

[◆](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_base.html#a61fc46fa731bf11ac3ad6ff1fd8a8a0b)Entity
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) SandBox.BoardGames.Tiles.TileBase.Entity | | get |

[◆](class_sand_box_1_1_board_games_1_1_tiles_1_1_tile_base.html#acc51ddf5645df26bc3864d6999ceb99e)ValidMoveDecal
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BoardGameDecal](class_sand_box_1_1_board_games_1_1_objects_1_1_board_game_decal.html) SandBox.BoardGames.Tiles.TileBase.ValidMoveDecal | | get |

