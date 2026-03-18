--- SOURCE: class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_handler.html ---

SandBox.View.Map.Navigation.MapNavigationHandler Class ReferenceInherits [TaleWorlds.CampaignSystem.INavigationHandler](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_handler.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| [INavigationElement](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_element.html)[] | [GetElements](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_handler.html#a45ddbc4c142c864e3ae982c83cbe5387) () |
|  | [MapNavigationHandler](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_handler.html#a180814ffea8385cc0daa24d60db535f2) () |
| bool | [IsAnyElementActive](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_handler.html#a3ed0f53a3ffdfc8d7e5b4989a23bcb71) () |
| [INavigationElement](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_element.html) | [GetElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_handler.html#a843b998b8e265eded8846ed41457a704) (string id) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| virtual [INavigationElement](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_element.html)[] | [OnCreateElements](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_handler.html#a958727d78152b1c1a2d1c49f206933c4) () |

|  |  |
| --- | --- |
| Protected Attributes | |
| readonly [Game](class_tale_worlds_1_1_core_1_1_game.html) | [\_game](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_handler.html#aa7f48662fb4fba5b284ed32a8cbac474) |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsNavigationLocked](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_handler.html#a72a32d606fd9f053f005374bab637a88) `[get, set]` |
| bool | [IsEscapeMenuActive](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_handler.html#a241d9b2efe5962ad69bdd2fca8c6521c) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_handler.html#a180814ffea8385cc0daa24d60db535f2)MapNavigationHandler()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| SandBox.View.Map.Navigation.MapNavigationHandler.MapNavigationHandler | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_handler.html#a45ddbc4c142c864e3ae982c83cbe5387)GetElements()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [INavigationElement](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_element.html)[] SandBox.View.Map.Navigation.MapNavigationHandler.GetElements | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.INavigationHandler](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_handler.html#a9c5c8f5b9f2f29afafafe3b3b4d41c59).

[◆](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_handler.html#a3ed0f53a3ffdfc8d7e5b4989a23bcb71)IsAnyElementActive()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool SandBox.View.Map.Navigation.MapNavigationHandler.IsAnyElementActive | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.INavigationHandler](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_handler.html#a1b70e862d248265c80e73f18c7dcd8f3).

[◆](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_handler.html#a958727d78152b1c1a2d1c49f206933c4)OnCreateElements()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual [INavigationElement](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_element.html)[] SandBox.View.Map.Navigation.MapNavigationHandler.OnCreateElements | ( |  | ) |  | | protectedvirtual |

[◆](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_handler.html#a843b998b8e265eded8846ed41457a704)GetElement()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [INavigationElement](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_element.html) SandBox.View.Map.Navigation.MapNavigationHandler.GetElement | ( | string | *id* | ) |  |

Implements [TaleWorlds.CampaignSystem.INavigationHandler](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_handler.html#ab4090cd1ba108610ffd3a338d96ffef3).

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_handler.html#aa7f48662fb4fba5b284ed32a8cbac474)\_game
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [Game](class_tale_worlds_1_1_core_1_1_game.html) SandBox.View.Map.Navigation.MapNavigationHandler.\_game | | protected |

Property Documentation
----------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_handler.html#a72a32d606fd9f053f005374bab637a88)IsNavigationLocked
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.View.Map.Navigation.MapNavigationHandler.IsNavigationLocked | | getset |

Implements [TaleWorlds.CampaignSystem.INavigationHandler](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_handler.html#aa6386ae2b0f21ca00e55f789ffb85287).

[◆](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_handler.html#a241d9b2efe5962ad69bdd2fca8c6521c)IsEscapeMenuActive
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.View.Map.Navigation.MapNavigationHandler.IsEscapeMenuActive | | get |

