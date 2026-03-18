--- SOURCE: class_sand_box_1_1_view_1_1_map_1_1_map_views_container.html ---

SandBox.View.Map.MapViewsContainer Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MapViewsContainer](class_sand_box_1_1_view_1_1_map_1_1_map_views_container.html#abfb31e994b4664dade97c631cb271c8c) () |
| void | [Add](class_sand_box_1_1_view_1_1_map_1_1_map_views_container.html#abd375b6a0f71440e545a69fb4ac52520) ([MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html) mapView) |
| void | [Remove](class_sand_box_1_1_view_1_1_map_1_1_map_views_container.html#ac5c9fa4734d3745664ecd3e13581b9e3) ([MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html) mapView) |
| bool | [Contains](class_sand_box_1_1_view_1_1_map_1_1_map_views_container.html#ab654816a22cd9de117f12c2e70b4ee9a) ([MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html) mapView) |
| void | [Foreach](class_sand_box_1_1_view_1_1_map_1_1_map_views_container.html#abc6e47270c2bae3764ecdd512797d7d5) (Action< [MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html) > action) |
| void | [ForeachReverse](class_sand_box_1_1_view_1_1_map_1_1_map_views_container.html#a85bba9f9caa8ed97df772902daeadf98) (Action< [MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html) > action) |
| [MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html) | [ReturnFirstElementWithCondition](class_sand_box_1_1_view_1_1_map_1_1_map_views_container.html#a532519ebe4fdd59163eedfa0ade7774e) (Func< [MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html), bool > condition) |
| T | [GetMapViewWithType< T >](class_sand_box_1_1_view_1_1_map_1_1_map_views_container.html#a66650e5a6016f7bd76ed6aec01de1645) () |
| [TutorialContexts](namespace_tale_worlds_1_1_core.html#a0e55f29880be385de604e852ae10794c) | [GetContextToChangeTo](class_sand_box_1_1_view_1_1_map_1_1_map_views_container.html#ae742296c809a443ea910860324c5435f) () |
| bool | [IsThereAnyViewIsEscaped](class_sand_box_1_1_view_1_1_map_1_1_map_views_container.html#a573afca3fa1ba50b8023dd7abe45faf6) () |
| bool | [IsOpeningEscapeMenuOnFocusChangeAllowedForAll](class_sand_box_1_1_view_1_1_map_1_1_map_views_container.html#a98eb559906a82cea3369ab93a172aae7) () |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly ObservableCollection< [MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html) > | [MapViews](class_sand_box_1_1_view_1_1_map_1_1_map_views_container.html#a8bed4efe2ab6b785464c730cedda4917) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_views_container.html#abfb31e994b4664dade97c631cb271c8c)MapViewsContainer()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| SandBox.View.Map.MapViewsContainer.MapViewsContainer | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_views_container.html#abd375b6a0f71440e545a69fb4ac52520)Add()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapViewsContainer.Add | ( | [MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html) | *mapView* | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_views_container.html#ac5c9fa4734d3745664ecd3e13581b9e3)Remove()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapViewsContainer.Remove | ( | [MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html) | *mapView* | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_views_container.html#ab654816a22cd9de117f12c2e70b4ee9a)Contains()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool SandBox.View.Map.MapViewsContainer.Contains | ( | [MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html) | *mapView* | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_views_container.html#abc6e47270c2bae3764ecdd512797d7d5)Foreach()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapViewsContainer.Foreach | ( | Action< [MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html) > | *action* | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_views_container.html#a85bba9f9caa8ed97df772902daeadf98)ForeachReverse()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapViewsContainer.ForeachReverse | ( | Action< [MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html) > | *action* | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_views_container.html#a532519ebe4fdd59163eedfa0ade7774e)ReturnFirstElementWithCondition()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html) SandBox.View.Map.MapViewsContainer.ReturnFirstElementWithCondition | ( | Func< [MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html), bool > | *condition* | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_views_container.html#a66650e5a6016f7bd76ed6aec01de1645)GetMapViewWithType< T >()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| T SandBox.View.Map.MapViewsContainer.GetMapViewWithType< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html)* |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_views_container.html#ae742296c809a443ea910860324c5435f)GetContextToChangeTo()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [TutorialContexts](namespace_tale_worlds_1_1_core.html#a0e55f29880be385de604e852ae10794c) SandBox.View.Map.MapViewsContainer.GetContextToChangeTo | ( |  | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_views_container.html#a573afca3fa1ba50b8023dd7abe45faf6)IsThereAnyViewIsEscaped()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool SandBox.View.Map.MapViewsContainer.IsThereAnyViewIsEscaped | ( |  | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_views_container.html#a98eb559906a82cea3369ab93a172aae7)IsOpeningEscapeMenuOnFocusChangeAllowedForAll()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool SandBox.View.Map.MapViewsContainer.IsOpeningEscapeMenuOnFocusChangeAllowedForAll | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_views_container.html#a8bed4efe2ab6b785464c730cedda4917)MapViews
-----------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly ObservableCollection<[MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html)> SandBox.View.Map.MapViewsContainer.MapViews |

