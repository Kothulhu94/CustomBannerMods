--- SOURCE: class_sand_box_1_1_board_games_1_1_a_i_1_1_tree_node_tablut.html ---

SandBox.BoardGames.AI.TreeNodeTablut Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [TreeNodeTablut](class_sand_box_1_1_board_games_1_1_a_i_1_1_tree_node_tablut.html#a38876231aa412ec7ee1e2b26477e3771) ([BoardGameSide](namespace_sand_box_1_1_board_games.html#a2932623e2fafdc970ef0ed27f680d2f7) lastTurnIsPlayedBy, int depth) |
| [TreeNodeTablut](class_sand_box_1_1_board_games_1_1_a_i_1_1_tree_node_tablut.html#a38876231aa412ec7ee1e2b26477e3771) | [GetChildWithBestScore](class_sand_box_1_1_board_games_1_1_a_i_1_1_tree_node_tablut.html#a3784e8510cfa87ed21ea8d65ef0248e1) () |
| void | [SelectAction](class_sand_box_1_1_board_games_1_1_a_i_1_1_tree_node_tablut.html#a54e661d009dfc9c2c9e17f71eba83c2e) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [TreeNodeTablut](class_sand_box_1_1_board_games_1_1_a_i_1_1_tree_node_tablut.html#a38876231aa412ec7ee1e2b26477e3771) | [CreateTreeAndReturnRootNode](class_sand_box_1_1_board_games_1_1_a_i_1_1_tree_node_tablut.html#ab525247e8c3bf54d5bbbaa76a066083c) ([BoardGameTablut.BoardInformation](struct_sand_box_1_1_board_games_1_1_board_game_tablut_1_1_board_information.html) initialBoardState, int maxDepth) |

|  |  |
| --- | --- |
| Properties | |
| [Move](struct_sand_box_1_1_board_games_1_1_move.html) | [OpeningMove](class_sand_box_1_1_board_games_1_1_a_i_1_1_tree_node_tablut.html#a372d9aa321212d609086bad59a515326) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_board_games_1_1_a_i_1_1_tree_node_tablut.html#a38876231aa412ec7ee1e2b26477e3771)TreeNodeTablut()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| SandBox.BoardGames.AI.TreeNodeTablut.TreeNodeTablut | ( | [BoardGameSide](namespace_sand_box_1_1_board_games.html#a2932623e2fafdc970ef0ed27f680d2f7) | *lastTurnIsPlayedBy*, |
|  |  | int | *depth* ) |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_board_games_1_1_a_i_1_1_tree_node_tablut.html#ab525247e8c3bf54d5bbbaa76a066083c)CreateTreeAndReturnRootNode()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [TreeNodeTablut](class_sand_box_1_1_board_games_1_1_a_i_1_1_tree_node_tablut.html#a38876231aa412ec7ee1e2b26477e3771) SandBox.BoardGames.AI.TreeNodeTablut.CreateTreeAndReturnRootNode | ( | [BoardGameTablut.BoardInformation](struct_sand_box_1_1_board_games_1_1_board_game_tablut_1_1_board_information.html) | *initialBoardState*, | |  |  | int | *maxDepth* ) | | static |

[◆](class_sand_box_1_1_board_games_1_1_a_i_1_1_tree_node_tablut.html#a3784e8510cfa87ed21ea8d65ef0248e1)GetChildWithBestScore()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [TreeNodeTablut](class_sand_box_1_1_board_games_1_1_a_i_1_1_tree_node_tablut.html#a38876231aa412ec7ee1e2b26477e3771) SandBox.BoardGames.AI.TreeNodeTablut.GetChildWithBestScore | ( |  | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_a_i_1_1_tree_node_tablut.html#a54e661d009dfc9c2c9e17f71eba83c2e)SelectAction()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.BoardGames.AI.TreeNodeTablut.SelectAction | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_sand_box_1_1_board_games_1_1_a_i_1_1_tree_node_tablut.html#a372d9aa321212d609086bad59a515326)OpeningMove
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Move](struct_sand_box_1_1_board_games_1_1_move.html) SandBox.BoardGames.AI.TreeNodeTablut.OpeningMove | | get |

