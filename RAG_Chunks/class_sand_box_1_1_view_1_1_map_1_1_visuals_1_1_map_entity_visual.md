--- SOURCE: class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html ---

SandBox.View.Map.Visuals.MapEntityVisual Class ReferenceabstractInherited by [SandBox.View.Map.Visuals.MapEntityVisual< T >](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual-1-g.html).

|  |  |
| --- | --- |
| Public Member Functions | |
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
| Properties | |
| MapScreen | [MapScreen](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#a026a0bef91676ade48b04a854756ecff) `[get]` |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | [InteractionPositionForPlayer](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#a928d7b3a51b551c8a019817b93ac5de8) `[get]` |
| [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) | [AttachedTo](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#ae155f7a72eebe40f62460b690caee033) `[get]` |
| virtual bool | [IsMobileEntity](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#a80a4638fc0c3b0881d45e420854dfd35) `[get]` |
| virtual [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [CircleLocalFrame](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#ac9059e3d25bbeef57ab7ed62e787c422) `[get, protected set]` |
| virtual bool | [IsMainEntity](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#aa5a7186b6c18be401da3a475178e4394) `[get]` |
| virtual float | [BearingRotation](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#ab061d14cc4b5b369273799338002b75b) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#abfb72a8373506880cb2006f9da8112aa)OnMapClick()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool SandBox.View.Map.Visuals.MapEntityVisual.OnMapClick | ( | bool | *followModifierUsed* | ) |  | | abstract |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#ae1d8479c69516ff2cc0ae8f9565f39cc)OnHover()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void SandBox.View.Map.Visuals.MapEntityVisual.OnHover | ( |  | ) |  | | abstract |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#a9924d983a08a3185e84a928627aa6438)OnOpenEncyclopedia()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void SandBox.View.Map.Visuals.MapEntityVisual.OnOpenEncyclopedia | ( |  | ) |  | | abstract |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#acbdbf9474d6e7e9a7c9b4b912161921a)IsVisibleOrFadingOut()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool SandBox.View.Map.Visuals.MapEntityVisual.IsVisibleOrFadingOut | ( |  | ) |  | | abstract |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#a88a2094ec9072930de3a568f9db8d6bb)GetVisualPosition()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) SandBox.View.Map.Visuals.MapEntityVisual.GetVisualPosition | ( |  | ) |  | | abstract |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#a291e1626e881e7fb84e322664639c89e)ReleaseResources()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void SandBox.View.Map.Visuals.MapEntityVisual.ReleaseResources | ( |  | ) |  | | virtual |

Reimplemented in [SandBox.View.Map.Visuals.MobilePartyVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#a30fc40cc64905eb37c5715eef59a050f), [SandBox.View.Map.Visuals.SettlementVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html#a156960c21dad2c202e4db419e4a431ac), and [SandBox.View.Map.Visuals.TrackVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_track_visual.html#ae36e6b0cc67266af464fe89c9b755aad).

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#a31e8d1fb2be16d17a9588d0f2ac38853)OnHoverEnd()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void SandBox.View.Map.Visuals.MapEntityVisual.OnHoverEnd | ( |  | ) |  | | virtual |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#a7ad1ed3d661a9df3d13df6d9e6ce9fbf)OnTrackAction()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void SandBox.View.Map.Visuals.MapEntityVisual.OnTrackAction | ( |  | ) |  | | virtual |

Reimplemented in [SandBox.View.Map.Visuals.MobilePartyVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#add7110e5ba6d5909cfc44a80c71edcc8), and [SandBox.View.Map.Visuals.SettlementVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html#ab663cf7f8f926f24bffc8f921157f7d8).

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#a513030b6c090d05f1f7c0ae16fed627a)IsEnemyOf()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual bool SandBox.View.Map.Visuals.MapEntityVisual.IsEnemyOf | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction* | ) |  | | virtual |

Reimplemented in [SandBox.View.Map.Visuals.MobilePartyVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#a34cdcd8559c8f71a46018e635b5071f0), and [SandBox.View.Map.Visuals.SettlementVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html#a9ce53a944540962a126ecd28566f6b34).

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#ab7a8abc00c4d87513030e5663c88c7e1)IsAllyOf()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual bool SandBox.View.Map.Visuals.MapEntityVisual.IsAllyOf | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction* | ) |  | | virtual |

Reimplemented in [SandBox.View.Map.Visuals.MobilePartyVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#a3108f39aaa12b50f619f51f7a6cde46b), and [SandBox.View.Map.Visuals.SettlementVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html#a41e449fa3a2e68df2cbf740c78bcac15).

Property Documentation
----------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#a026a0bef91676ade48b04a854756ecff)MapScreen
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MapScreen SandBox.View.Map.Visuals.MapEntityVisual.MapScreen | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#a928d7b3a51b551c8a019817b93ac5de8)InteractionPositionForPlayer
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) SandBox.View.Map.Visuals.MapEntityVisual.InteractionPositionForPlayer | | getabstract |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#ae155f7a72eebe40f62460b690caee033)AttachedTo
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) SandBox.View.Map.Visuals.MapEntityVisual.AttachedTo | | getabstract |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#a80a4638fc0c3b0881d45e420854dfd35)IsMobileEntity
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual bool SandBox.View.Map.Visuals.MapEntityVisual.IsMobileEntity | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#ac9059e3d25bbeef57ab7ed62e787c422)CircleLocalFrame
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) SandBox.View.Map.Visuals.MapEntityVisual.CircleLocalFrame | | getprotected set |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#aa5a7186b6c18be401da3a475178e4394)IsMainEntity
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual bool SandBox.View.Map.Visuals.MapEntityVisual.IsMainEntity | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#ab061d14cc4b5b369273799338002b75b)BearingRotation
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual float SandBox.View.Map.Visuals.MapEntityVisual.BearingRotation | | get |

