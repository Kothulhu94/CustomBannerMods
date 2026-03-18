--- SOURCE: class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_track_visual.html ---

SandBox.View.Map.Visuals.TrackVisual Class ReferenceInherits [SandBox.View.Map.Visuals.MapEntityVisual< T >](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual-1-g.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [TrackVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_track_visual.html#a59dd9c35babe803b666753be57230b36) ([Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) track) |
| override [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetVisualPosition](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_track_visual.html#affe6e912f8c0bfe7c7a50a92b0471d61) () |
| override bool | [IsVisibleOrFadingOut](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_track_visual.html#acb638121d501ace0f0b43ff5dd151119) () |
| override void | [OnHover](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_track_visual.html#a4df28a4e6fb708ae78bd4560718893bb) () |
| override bool | [OnMapClick](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_track_visual.html#a5d98cc3f71b7e371abe85fe62e2323a3) (bool followModifierUsed) |
| override void | [OnOpenEncyclopedia](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_track_visual.html#a4f33cdabd5adcfdac03b2848bad5dd70) () |
| override void | [ReleaseResources](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_track_visual.html#ae36e6b0cc67266af464fe89c9b755aad) () |
| Public Member Functions inherited from [SandBox.View.Map.Visuals.MapEntityVisual< T >](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual-1-g.html) | |
|  | [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual-1-g.html#aae194c8456324a49b0d81554f14e330a) (T entity) |
| Public Member Functions inherited from [SandBox.View.Map.Visuals.MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) | |
| bool | [OnMapClick](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#abfb72a8373506880cb2006f9da8112aa) (bool followModifierUsed) |
| void | [OnHover](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#ae1d8479c69516ff2cc0ae8f9565f39cc) () |
| void | [OnOpenEncyclopedia](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#a9924d983a08a3185e84a928627aa6438) () |
| bool | [IsVisibleOrFadingOut](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#acbdbf9474d6e7e9a7c9b4b912161921a) () |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetVisualPosition](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#a88a2094ec9072930de3a568f9db8d6bb) () |
| virtual void | [OnHoverEnd](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#a31e8d1fb2be16d17a9588d0f2ac38853) () |
| virtual void | [OnTrackAction](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#a7ad1ed3d661a9df3d13df6d9e6ce9fbf) () |
| virtual bool | [IsEnemyOf](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#a513030b6c090d05f1f7c0ae16fed627a) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| virtual bool | [IsAllyOf](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#ab7a8abc00c4d87513030e5663c88c7e1) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |

|  |  |
| --- | --- |
| Properties | |
| override [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | [InteractionPositionForPlayer](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_track_visual.html#a0ff5f72a7ff433e16497e75fc836a3ad) `[get]` |
| override [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual-1-g.html#aae194c8456324a49b0d81554f14e330a) | [AttachedTo](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_track_visual.html#ae0e85e56ac4abe19aac5a3b7e524351b) `[get]` |
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

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_track_visual.html#a59dd9c35babe803b666753be57230b36)TrackVisual()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| SandBox.View.Map.Visuals.TrackVisual.TrackVisual | ( | [Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) | *track* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_track_visual.html#affe6e912f8c0bfe7c7a50a92b0471d61)GetVisualPosition()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) SandBox.View.Map.Visuals.TrackVisual.GetVisualPosition | ( |  | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_track_visual.html#acb638121d501ace0f0b43ff5dd151119)IsVisibleOrFadingOut()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override bool SandBox.View.Map.Visuals.TrackVisual.IsVisibleOrFadingOut | ( |  | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_track_visual.html#a4df28a4e6fb708ae78bd4560718893bb)OnHover()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void SandBox.View.Map.Visuals.TrackVisual.OnHover | ( |  | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_track_visual.html#a5d98cc3f71b7e371abe85fe62e2323a3)OnMapClick()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool SandBox.View.Map.Visuals.TrackVisual.OnMapClick | ( | bool | *followModifierUsed* | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_track_visual.html#a4f33cdabd5adcfdac03b2848bad5dd70)OnOpenEncyclopedia()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void SandBox.View.Map.Visuals.TrackVisual.OnOpenEncyclopedia | ( |  | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_track_visual.html#ae36e6b0cc67266af464fe89c9b755aad)ReleaseResources()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.View.Map.Visuals.TrackVisual.ReleaseResources | ( |  | ) |  | | virtual |

Reimplemented from [SandBox.View.Map.Visuals.MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#a291e1626e881e7fb84e322664639c89e).

Property Documentation
----------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_track_visual.html#a0ff5f72a7ff433e16497e75fc836a3ad)InteractionPositionForPlayer
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) SandBox.View.Map.Visuals.TrackVisual.InteractionPositionForPlayer | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_track_visual.html#ae0e85e56ac4abe19aac5a3b7e524351b)AttachedTo
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual-1-g.html#aae194c8456324a49b0d81554f14e330a) SandBox.View.Map.Visuals.TrackVisual.AttachedTo | | get |

