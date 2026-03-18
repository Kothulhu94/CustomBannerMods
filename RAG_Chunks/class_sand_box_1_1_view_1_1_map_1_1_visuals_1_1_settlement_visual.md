--- SOURCE: class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html ---

SandBox.View.Map.Visuals.SettlementVisual Class ReferenceInherits [SandBox.View.Map.Visuals.MapEntityVisual< T >](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual-1-g.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [SettlementVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html#afa67b2d845a2b80accf883df189802cc) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) entity) |
| override bool | [IsEnemyOf](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html#a9ce53a944540962a126ecd28566f6b34) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| override bool | [IsAllyOf](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html#a41e449fa3a2e68df2cbf740c78bcac15) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| override [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetVisualPosition](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html#a552cb3bae4f649f61b9b74ed78501d60) () |
| override bool | [IsVisibleOrFadingOut](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html#a8251783cf1b89119dc185bd72dbceeeb) () |
| override void | [OnHover](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html#a01debc27a7be2c868894dd348d1b814e) () |
| override void | [OnTrackAction](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html#ab663cf7f8f926f24bffc8f921157f7d8) () |
| override bool | [OnMapClick](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html#af87ede61904ab20c5beadd4c10044f5d) (bool followModifierUsed) |
| override void | [OnOpenEncyclopedia](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html#a2259ee985d3f0c47b7a43a700e687dea) () |
| override void | [ReleaseResources](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html#a156960c21dad2c202e4db419e4a431ac) () |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetBannerPositionForParty](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html#a84e9b4f918b640e0423668b85e744c80) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html)[] | [GetAttackerTowerSiegeEngineFrames](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html#a72a5a9af819ade87a13d4de20d7ca70b) () |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html)[] | [GetAttackerBatteringRamSiegeEngineFrames](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html#a2838f900cb3ed6b7543f5488046fc4d6) () |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html)[] | [GetAttackerRangedSiegeEngineFrames](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html#aeb7cb1ae4c4aab5ccb9b6cb95feb21e3) () |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html)[] | [GetDefenderRangedSiegeEngineFrames](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html#a890d91c7bdd59c4aede01654c7240429) () |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html)[] | [GetBreachableWallFrames](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html#a339030c4265c0051042244d6106a66b6) () |
| Public Member Functions inherited from [SandBox.View.Map.Visuals.MapEntityVisual< T >](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual-1-g.html) | |
|  | [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual-1-g.html#aae194c8456324a49b0d81554f14e330a) (T entity) |
| Public Member Functions inherited from [SandBox.View.Map.Visuals.MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) | |
| bool | [OnMapClick](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#abfb72a8373506880cb2006f9da8112aa) (bool followModifierUsed) |
| void | [OnHover](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#ae1d8479c69516ff2cc0ae8f9565f39cc) () |
| void | [OnOpenEncyclopedia](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#a9924d983a08a3185e84a928627aa6438) () |
| bool | [IsVisibleOrFadingOut](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#acbdbf9474d6e7e9a7c9b4b912161921a) () |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetVisualPosition](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#a88a2094ec9072930de3a568f9db8d6bb) () |
| virtual void | [OnHoverEnd](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#a31e8d1fb2be16d17a9588d0f2ac38853) () |

|  |  |
| --- | --- |
| Properties | |
| override [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual-1-g.html#aae194c8456324a49b0d81554f14e330a) | [AttachedTo](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html#a89401b443dbc29506a88f4093c35afb3) `[get]` |
| override [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | [InteractionPositionForPlayer](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html#a3a1e3999df85ff929aabb97c3d37836d) `[get]` |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [StrategicEntity](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html#a10f3c160cc3b2198361be3eb5f0a4f5e) `[get]` |
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

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html#afa67b2d845a2b80accf883df189802cc)SettlementVisual()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| SandBox.View.Map.Visuals.SettlementVisual.SettlementVisual | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *entity* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html#a9ce53a944540962a126ecd28566f6b34)IsEnemyOf()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override bool SandBox.View.Map.Visuals.SettlementVisual.IsEnemyOf | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction* | ) |  | | virtual |

Reimplemented from [SandBox.View.Map.Visuals.MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#a513030b6c090d05f1f7c0ae16fed627a).

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html#a41e449fa3a2e68df2cbf740c78bcac15)IsAllyOf()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override bool SandBox.View.Map.Visuals.SettlementVisual.IsAllyOf | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction* | ) |  | | virtual |

Reimplemented from [SandBox.View.Map.Visuals.MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#ab7a8abc00c4d87513030e5663c88c7e1).

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html#a552cb3bae4f649f61b9b74ed78501d60)GetVisualPosition()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) SandBox.View.Map.Visuals.SettlementVisual.GetVisualPosition | ( |  | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html#a8251783cf1b89119dc185bd72dbceeeb)IsVisibleOrFadingOut()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override bool SandBox.View.Map.Visuals.SettlementVisual.IsVisibleOrFadingOut | ( |  | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html#a01debc27a7be2c868894dd348d1b814e)OnHover()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void SandBox.View.Map.Visuals.SettlementVisual.OnHover | ( |  | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html#ab663cf7f8f926f24bffc8f921157f7d8)OnTrackAction()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.View.Map.Visuals.SettlementVisual.OnTrackAction | ( |  | ) |  | | virtual |

Reimplemented from [SandBox.View.Map.Visuals.MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#a7ad1ed3d661a9df3d13df6d9e6ce9fbf).

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html#af87ede61904ab20c5beadd4c10044f5d)OnMapClick()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool SandBox.View.Map.Visuals.SettlementVisual.OnMapClick | ( | bool | *followModifierUsed* | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html#a2259ee985d3f0c47b7a43a700e687dea)OnOpenEncyclopedia()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void SandBox.View.Map.Visuals.SettlementVisual.OnOpenEncyclopedia | ( |  | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html#a156960c21dad2c202e4db419e4a431ac)ReleaseResources()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.View.Map.Visuals.SettlementVisual.ReleaseResources | ( |  | ) |  | | virtual |

Reimplemented from [SandBox.View.Map.Visuals.MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#a291e1626e881e7fb84e322664639c89e).

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html#a84e9b4f918b640e0423668b85e744c80)GetBannerPositionForParty()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) SandBox.View.Map.Visuals.SettlementVisual.GetBannerPositionForParty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html#a72a5a9af819ade87a13d4de20d7ca70b)GetAttackerTowerSiegeEngineFrames()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html)[] SandBox.View.Map.Visuals.SettlementVisual.GetAttackerTowerSiegeEngineFrames | ( |  | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html#a2838f900cb3ed6b7543f5488046fc4d6)GetAttackerBatteringRamSiegeEngineFrames()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html)[] SandBox.View.Map.Visuals.SettlementVisual.GetAttackerBatteringRamSiegeEngineFrames | ( |  | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html#aeb7cb1ae4c4aab5ccb9b6cb95feb21e3)GetAttackerRangedSiegeEngineFrames()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html)[] SandBox.View.Map.Visuals.SettlementVisual.GetAttackerRangedSiegeEngineFrames | ( |  | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html#a890d91c7bdd59c4aede01654c7240429)GetDefenderRangedSiegeEngineFrames()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html)[] SandBox.View.Map.Visuals.SettlementVisual.GetDefenderRangedSiegeEngineFrames | ( |  | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html#a339030c4265c0051042244d6106a66b6)GetBreachableWallFrames()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html)[] SandBox.View.Map.Visuals.SettlementVisual.GetBreachableWallFrames | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html#a89401b443dbc29506a88f4093c35afb3)AttachedTo
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual-1-g.html#aae194c8456324a49b0d81554f14e330a) SandBox.View.Map.Visuals.SettlementVisual.AttachedTo | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html#a3a1e3999df85ff929aabb97c3d37836d)InteractionPositionForPlayer
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) SandBox.View.Map.Visuals.SettlementVisual.InteractionPositionForPlayer | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html#a10f3c160cc3b2198361be3eb5f0a4f5e)StrategicEntity
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) SandBox.View.Map.Visuals.SettlementVisual.StrategicEntity | | get |

