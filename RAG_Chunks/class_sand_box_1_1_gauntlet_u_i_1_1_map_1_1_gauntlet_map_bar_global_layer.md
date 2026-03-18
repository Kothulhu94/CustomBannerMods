--- SOURCE: class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_bar_global_layer.html ---

SandBox.GauntletUI.Map.GauntletMapBarGlobalLayer Class ReferenceInherits GlobalLayer.

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [GauntletMapBarGlobalLayer](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_bar_global_layer.html#a64aef48b39876c35a80cd2875c94e6d0) ([MapScreen](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html) mapScreen, [INavigationHandler](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_handler.html) navigationHandler, float contextAlphaModifider) |
| void | [Initialize](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_bar_global_layer.html#a49da5d74328cf437cbf37f9d1a28d08b) ([MapBarVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html) dataSource) |
| void | [OnFinalize](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_bar_global_layer.html#a0cdcc04ff086ed7791246490c843b05e) () |
| void | [OnMapConversationStarted](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_bar_global_layer.html#a943f793891edb8387906767ac2465ba6) () |
| void | [OnMapConversationOver](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_bar_global_layer.html#ad5fc3146898f876502f01c7459e40658) () |
| void | [Refresh](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_bar_global_layer.html#a36171b4683645d6cb1ada7b6f6224164) () |
| bool | [IsEscaped](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_bar_global_layer.html#ad5b3ef000c2825e9206f03ca78c081a3) () |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnTick](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_bar_global_layer.html#ae9dbef24f565fa706b89d172973a4ee3) (float dt) |
| virtual bool | [HandlePanelSwitchingInput](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_bar_global_layer.html#a922048093c6585893ea5c95f427c5184) ([InputContext](class_tale_worlds_1_1_input_system_1_1_input_context.html) inputContext) |

|  |  |
| --- | --- |
| Protected Attributes | |
| [MapBarVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html) | [\_dataSource](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_bar_global_layer.html#a415738533a133dd72fe30f777bba0bcb) |
| [GauntletLayer](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html) | [\_gauntletLayer](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_bar_global_layer.html#a52faab6566110ec55d017fb94a4555ae) |
| [GauntletMovieIdentifier](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_movie_identifier.html) | [\_movie](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_bar_global_layer.html#a9e6dcfa46b00ddb00a4b854c095c3bb8) |
| [SpriteCategory](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html) | [\_mapBarCategory](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_bar_global_layer.html#a1f222c2400177b402b1a98a72a5fed94) |
| [MapScreen](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html) | [\_mapScreen](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_bar_global_layer.html#adfdebf8625eccd6cfe666fe71a676495) |
| [INavigationHandler](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_handler.html) | [\_mapNavigationHandler](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_bar_global_layer.html#a0b4985d8762b27e0e4a5d11506ae4d7c) |
| [MapEncyclopediaView](class_sand_box_1_1_view_1_1_map_1_1_map_encyclopedia_view.html) | [\_encyclopediaManager](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_bar_global_layer.html#a581b4b99d2098a987574ee16a144c889) |
| float | [\_contextAlphaTarget](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_bar_global_layer.html#a85d5d502b83a403874cc9555b71a1cee) = 1 |
| float | [\_contextAlphaModifider](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_bar_global_layer.html#aed7fa108d2a798da48523b4db71ce9c1) |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsInArmyManagement](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_bar_global_layer.html#aac2453bfbc83184923c9addf0ce9e353) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_bar_global_layer.html#a64aef48b39876c35a80cd2875c94e6d0)GauntletMapBarGlobalLayer()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| SandBox.GauntletUI.Map.GauntletMapBarGlobalLayer.GauntletMapBarGlobalLayer | ( | [MapScreen](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html) | *mapScreen*, |
|  |  | [INavigationHandler](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_handler.html) | *navigationHandler*, |
|  |  | float | *contextAlphaModifider* ) |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_bar_global_layer.html#a49da5d74328cf437cbf37f9d1a28d08b)Initialize()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.GauntletUI.Map.GauntletMapBarGlobalLayer.Initialize | ( | [MapBarVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html) | *dataSource* | ) |  |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_bar_global_layer.html#a0cdcc04ff086ed7791246490c843b05e)OnFinalize()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.GauntletUI.Map.GauntletMapBarGlobalLayer.OnFinalize | ( |  | ) |  |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_bar_global_layer.html#a943f793891edb8387906767ac2465ba6)OnMapConversationStarted()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.GauntletUI.Map.GauntletMapBarGlobalLayer.OnMapConversationStarted | ( |  | ) |  |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_bar_global_layer.html#ad5fc3146898f876502f01c7459e40658)OnMapConversationOver()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.GauntletUI.Map.GauntletMapBarGlobalLayer.OnMapConversationOver | ( |  | ) |  |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_bar_global_layer.html#a36171b4683645d6cb1ada7b6f6224164)Refresh()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.GauntletUI.Map.GauntletMapBarGlobalLayer.Refresh | ( |  | ) |  |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_bar_global_layer.html#ae9dbef24f565fa706b89d172973a4ee3)OnTick()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Map.GauntletMapBarGlobalLayer.OnTick | ( | float | *dt* | ) |  | | protected |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_bar_global_layer.html#a922048093c6585893ea5c95f427c5184)HandlePanelSwitchingInput()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual bool SandBox.GauntletUI.Map.GauntletMapBarGlobalLayer.HandlePanelSwitchingInput | ( | [InputContext](class_tale_worlds_1_1_input_system_1_1_input_context.html) | *inputContext* | ) |  | | protectedvirtual |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_bar_global_layer.html#ad5b3ef000c2825e9206f03ca78c081a3)IsEscaped()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool SandBox.GauntletUI.Map.GauntletMapBarGlobalLayer.IsEscaped | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_bar_global_layer.html#a415738533a133dd72fe30f777bba0bcb)\_dataSource
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MapBarVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html) SandBox.GauntletUI.Map.GauntletMapBarGlobalLayer.\_dataSource | | protected |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_bar_global_layer.html#a52faab6566110ec55d017fb94a4555ae)\_gauntletLayer
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GauntletLayer](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html) SandBox.GauntletUI.Map.GauntletMapBarGlobalLayer.\_gauntletLayer | | protected |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_bar_global_layer.html#a9e6dcfa46b00ddb00a4b854c095c3bb8)\_movie
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GauntletMovieIdentifier](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_movie_identifier.html) SandBox.GauntletUI.Map.GauntletMapBarGlobalLayer.\_movie | | protected |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_bar_global_layer.html#a1f222c2400177b402b1a98a72a5fed94)\_mapBarCategory
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SpriteCategory](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html) SandBox.GauntletUI.Map.GauntletMapBarGlobalLayer.\_mapBarCategory | | protected |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_bar_global_layer.html#adfdebf8625eccd6cfe666fe71a676495)\_mapScreen
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MapScreen](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html) SandBox.GauntletUI.Map.GauntletMapBarGlobalLayer.\_mapScreen | | protected |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_bar_global_layer.html#a0b4985d8762b27e0e4a5d11506ae4d7c)\_mapNavigationHandler
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [INavigationHandler](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_handler.html) SandBox.GauntletUI.Map.GauntletMapBarGlobalLayer.\_mapNavigationHandler | | protected |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_bar_global_layer.html#a581b4b99d2098a987574ee16a144c889)\_encyclopediaManager
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MapEncyclopediaView](class_sand_box_1_1_view_1_1_map_1_1_map_encyclopedia_view.html) SandBox.GauntletUI.Map.GauntletMapBarGlobalLayer.\_encyclopediaManager | | protected |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_bar_global_layer.html#a85d5d502b83a403874cc9555b71a1cee)\_contextAlphaTarget
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float SandBox.GauntletUI.Map.GauntletMapBarGlobalLayer.\_contextAlphaTarget = 1 | | protected |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_bar_global_layer.html#aed7fa108d2a798da48523b4db71ce9c1)\_contextAlphaModifider
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float SandBox.GauntletUI.Map.GauntletMapBarGlobalLayer.\_contextAlphaModifider | | protected |

Property Documentation
----------------------

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_bar_global_layer.html#aac2453bfbc83184923c9addf0ce9e353)IsInArmyManagement
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.GauntletUI.Map.GauntletMapBarGlobalLayer.IsInArmyManagement | | get |

