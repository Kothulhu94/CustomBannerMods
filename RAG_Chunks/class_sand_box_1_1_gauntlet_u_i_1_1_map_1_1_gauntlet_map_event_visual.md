--- SOURCE: class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_event_visual.html ---

SandBox.GauntletUI.Map.GauntletMapEventVisual Class ReferenceInherits [TaleWorlds.CampaignSystem.MapEvents.IMapEventVisual](interface_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_i_map_event_visual.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [GauntletMapEventVisual](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_event_visual.html#adf7ee2c748596d38e5f62b073095a7cd) ([MapEvent](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_event_visual.html#a55b82d609aab944585722527c1e8a25e) mapEvent, Action< GauntletMapEventVisual > onInitialized, Action< GauntletMapEventVisual > onVisibilityChanged, Action< GauntletMapEventVisual > onDeactivate) |
| void | [Initialize](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_event_visual.html#a078c55022ac7c30ab3b33b220109cab7) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) position, int battleSizeValue, bool isVisible) |
| void | [OnMapEventEnd](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_event_visual.html#a7f3287df07e5b2de53b92587230638ac) () |
| void | [SetVisibility](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_event_visual.html#acaf5b57244a177b82f46e99798747441) (bool isVisible) |

|  |  |
| --- | --- |
| Properties | |
| MapEvent | [MapEvent](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_event_visual.html#a55b82d609aab944585722527c1e8a25e) `[get]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [WorldPosition](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_event_visual.html#a69c0b7cae3013d2378a6bb8b28bea450) `[get]` |
| bool | [IsVisible](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_event_visual.html#af1420f772942c4ef47a96f366db2504d) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_event_visual.html#adf7ee2c748596d38e5f62b073095a7cd)GauntletMapEventVisual()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| SandBox.GauntletUI.Map.GauntletMapEventVisual.GauntletMapEventVisual | ( | [MapEvent](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_event_visual.html#a55b82d609aab944585722527c1e8a25e) | *mapEvent*, |
|  |  | Action< GauntletMapEventVisual > | *onInitialized*, |
|  |  | Action< GauntletMapEventVisual > | *onVisibilityChanged*, |
|  |  | Action< GauntletMapEventVisual > | *onDeactivate* ) |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_event_visual.html#a078c55022ac7c30ab3b33b220109cab7)Initialize()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.GauntletUI.Map.GauntletMapEventVisual.Initialize | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *position*, |
|  |  | int | *battleSizeValue*, |
|  |  | bool | *isVisible* ) |

Implements [TaleWorlds.CampaignSystem.MapEvents.IMapEventVisual](interface_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_i_map_event_visual.html#acb5c655dbebbf5476ea825a22a52ef00).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_event_visual.html#a7f3287df07e5b2de53b92587230638ac)OnMapEventEnd()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.GauntletUI.Map.GauntletMapEventVisual.OnMapEventEnd | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.MapEvents.IMapEventVisual](interface_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_i_map_event_visual.html#a922079313ef354f7960b1e607fddd5c6).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_event_visual.html#acaf5b57244a177b82f46e99798747441)SetVisibility()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.GauntletUI.Map.GauntletMapEventVisual.SetVisibility | ( | bool | *isVisible* | ) |  |

Implements [TaleWorlds.CampaignSystem.MapEvents.IMapEventVisual](interface_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_i_map_event_visual.html#a7b57b15777d370f0ae643c994f71f2de).

Property Documentation
----------------------

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_event_visual.html#a55b82d609aab944585722527c1e8a25e)MapEvent
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MapEvent SandBox.GauntletUI.Map.GauntletMapEventVisual.MapEvent | | get |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_event_visual.html#a69c0b7cae3013d2378a6bb8b28bea450)WorldPosition
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) SandBox.GauntletUI.Map.GauntletMapEventVisual.WorldPosition | | get |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_event_visual.html#af1420f772942c4ef47a96f366db2504d)IsVisible
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.GauntletUI.Map.GauntletMapEventVisual.IsVisible | | get |

