--- SOURCE: class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_weather_visual.html ---

SandBox.View.Map.Visuals.MapWeatherVisual Class ReferenceInherits [SandBox.View.Map.Visuals.MapEntityVisual< T >](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual-1-g.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override string | [ToString](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_weather_visual.html#aa30590d24a1b997664e16323a76eb7c5) () |
|  | [MapWeatherVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_weather_visual.html#a19a71b44ead548cc27485b6e528c2e90) ([WeatherNode](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_weather_node.html) weatherNode) |
| void | [Tick](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_weather_visual.html#a8ac752afa7641b0f240700b3c78e20fe) () |
| override bool | [OnMapClick](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_weather_visual.html#a2b9ed91dbc754808f693e8482e043e8f) (bool followModifierUsed) |
| override void | [OnHover](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_weather_visual.html#a397284c4932cd6096dbfd80360854b6f) () |
| override void | [OnOpenEncyclopedia](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_weather_visual.html#acae8739acc272c64b3e86d55b8501c4b) () |
| override bool | [IsVisibleOrFadingOut](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_weather_visual.html#a0ff663c7b89c999ea2c05926157df498) () |
| override [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetVisualPosition](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_weather_visual.html#a542fdcd3c8dc826094b6a3745422f696) () |
| Public Member Functions inherited from [SandBox.View.Map.Visuals.MapEntityVisual< T >](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual-1-g.html) | |
|  | [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual-1-g.html#aae194c8456324a49b0d81554f14e330a) (T entity) |
| Public Member Functions inherited from [SandBox.View.Map.Visuals.MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) | |
| bool | [OnMapClick](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#abfb72a8373506880cb2006f9da8112aa) (bool followModifierUsed) |
| void | [OnHover](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#ae1d8479c69516ff2cc0ae8f9565f39cc) () |
| void | [OnOpenEncyclopedia](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#a9924d983a08a3185e84a928627aa6438) () |
| bool | [IsVisibleOrFadingOut](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#acbdbf9474d6e7e9a7c9b4b912161921a) () |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetVisualPosition](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#a88a2094ec9072930de3a568f9db8d6bb) () |
| virtual void | [ReleaseResources](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#a291e1626e881e7fb84e322664639c89e) () |
| virtual void | [OnHoverEnd](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#a31e8d1fb2be16d17a9588d0f2ac38853) () |
| virtual void | [OnTrackAction](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#a7ad1ed3d661a9df3d13df6d9e6ce9fbf) () |
| virtual bool | [IsEnemyOf](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#a513030b6c090d05f1f7c0ae16fed627a) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| virtual bool | [IsAllyOf](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#ab7a8abc00c4d87513030e5663c88c7e1) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |

|  |  |
| --- | --- |
| Public Attributes | |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [Prefab](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_weather_visual.html#ab1656c0f11ae024a7cb7fd79fa50c56a) |

|  |  |
| --- | --- |
| Properties | |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [Position](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_weather_visual.html#a9e4c88a0e3673fc70dbb6362aa336f81) `[get]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [PrefabSpawnOffset](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_weather_visual.html#aecbd4c7cc461361e69937968186bba67) `[get]` |
| int | [MaskPixelIndex](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_weather_visual.html#a0be954d56383769464222a3df14db263) `[get]` |
| override [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | [InteractionPositionForPlayer](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_weather_visual.html#af1da011be9f552a8053fc7ec005f7225) `[get]` |
| override [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual-1-g.html#aae194c8456324a49b0d81554f14e330a) | [AttachedTo](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_weather_visual.html#ab476f68aa7c99055a45f83de54d969dd) `[get]` |
| Properties inherited from [SandBox.View.Map.Visuals.MapEntityVisual< T >](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual-1-g.html) | |
| T | [MapEntity](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual-1-g.html#aa5820401a79e17fac5bdac933d010479) `[get]` |
| Properties inherited from [SandBox.View.Map.Visuals.MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) | |
| MapScreen | [MapScreen](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#a026a0bef91676ade48b04a854756ecff) `[get]` |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | [InteractionPositionForPlayer](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#a928d7b3a51b551c8a019817b93ac5de8) `[get]` |
| [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) | [AttachedTo](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#ae155f7a72eebe40f62460b690caee033) `[get]` |
| virtual bool | [IsMobileEntity](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#a80a4638fc0c3b0881d45e420854dfd35) `[get]` |
| virtual [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [CircleLocalFrame](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#ac9059e3d25bbeef57ab7ed62e787c422) `[get, protected set]` |
| virtual bool | [IsMainEntity](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#aa5a7186b6c18be401da3a475178e4394) `[get]` |
| virtual float | [BearingRotation](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#ab061d14cc4b5b369273799338002b75b) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_weather_visual.html#a19a71b44ead548cc27485b6e528c2e90)MapWeatherVisual()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| SandBox.View.Map.Visuals.MapWeatherVisual.MapWeatherVisual | ( | [WeatherNode](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_weather_node.html) | *weatherNode* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_weather_visual.html#aa30590d24a1b997664e16323a76eb7c5)ToString()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string SandBox.View.Map.Visuals.MapWeatherVisual.ToString | ( |  | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_weather_visual.html#a8ac752afa7641b0f240700b3c78e20fe)Tick()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.View.Map.Visuals.MapWeatherVisual.Tick | ( |  | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_weather_visual.html#a2b9ed91dbc754808f693e8482e043e8f)OnMapClick()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool SandBox.View.Map.Visuals.MapWeatherVisual.OnMapClick | ( | bool | *followModifierUsed* | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_weather_visual.html#a397284c4932cd6096dbfd80360854b6f)OnHover()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void SandBox.View.Map.Visuals.MapWeatherVisual.OnHover | ( |  | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_weather_visual.html#acae8739acc272c64b3e86d55b8501c4b)OnOpenEncyclopedia()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void SandBox.View.Map.Visuals.MapWeatherVisual.OnOpenEncyclopedia | ( |  | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_weather_visual.html#a0ff663c7b89c999ea2c05926157df498)IsVisibleOrFadingOut()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override bool SandBox.View.Map.Visuals.MapWeatherVisual.IsVisibleOrFadingOut | ( |  | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_weather_visual.html#a542fdcd3c8dc826094b6a3745422f696)GetVisualPosition()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) SandBox.View.Map.Visuals.MapWeatherVisual.GetVisualPosition | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_weather_visual.html#ab1656c0f11ae024a7cb7fd79fa50c56a)Prefab
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) SandBox.View.Map.Visuals.MapWeatherVisual.Prefab |

Property Documentation
----------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_weather_visual.html#a9e4c88a0e3673fc70dbb6362aa336f81)Position
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) SandBox.View.Map.Visuals.MapWeatherVisual.Position | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_weather_visual.html#aecbd4c7cc461361e69937968186bba67)PrefabSpawnOffset
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) SandBox.View.Map.Visuals.MapWeatherVisual.PrefabSpawnOffset | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_weather_visual.html#a0be954d56383769464222a3df14db263)MaskPixelIndex
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.View.Map.Visuals.MapWeatherVisual.MaskPixelIndex | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_weather_visual.html#af1da011be9f552a8053fc7ec005f7225)InteractionPositionForPlayer
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) SandBox.View.Map.Visuals.MapWeatherVisual.InteractionPositionForPlayer | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_weather_visual.html#ab476f68aa7c99055a45f83de54d969dd)AttachedTo
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual-1-g.html#aae194c8456324a49b0d81554f14e330a) SandBox.View.Map.Visuals.MapWeatherVisual.AttachedTo | | get |

