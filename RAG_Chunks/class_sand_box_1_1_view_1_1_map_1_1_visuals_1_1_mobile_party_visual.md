--- SOURCE: class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html ---

SandBox.View.Map.Visuals.MobilePartyVisual Class ReferenceInherits [SandBox.View.Map.Visuals.MapEntityVisual< T >](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual-1-g.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MobilePartyVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#a75d3da693850b563cecca3427683df46) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) partyBase) |
| override bool | [IsEnemyOf](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#a34cdcd8559c8f71a46018e635b5071f0) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| override bool | [IsAllyOf](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#a3108f39aaa12b50f619f51f7a6cde46b) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| override void | [OnTrackAction](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#add7110e5ba6d5909cfc44a80c71edcc8) () |
| override bool | [OnMapClick](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#aaa8b3ceafdc82476c56158c20c9bd105) (bool followModifierUsed) |
| override void | [OnHover](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#a6375c739c9aaddd67c1f9424dcec6277) () |
| override [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetVisualPosition](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#ae352753353265e032664362033e7a619) () |
| override void | [ReleaseResources](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#a30fc40cc64905eb37c5715eef59a050f) () |
| override bool | [IsVisibleOrFadingOut](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#a0536107d31c4f2256ae4f8fbc889271a) () |
| override void | [OnOpenEncyclopedia](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#a00b0740e3df5c4b70dbe91faa236068a) () |
| void | [AddTentEntityForParty](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#a61b39a43d78bcb416f4912222dc61151) ([GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) strategicEntity, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, ref bool clearBannerComponentCache) |
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
| Static Public Member Functions | |
| static [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | [GetBannerOfCharacter](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#a275dbd75a6335fa84bb78306f8aade39) ([Banner](class_tale_worlds_1_1_core_1_1_banner.html) banner, string bannerMeshName) |

|  |  |
| --- | --- |
| Properties | |
| override float | [BearingRotation](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#a4a3d8f3fa00a26714b3830aa7420a487) `[get]` |
| override [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual-1-g.html#aae194c8456324a49b0d81554f14e330a) | [AttachedTo](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#a82ca38c4326b64246a41cc9c69dec997) `[get]` |
| override [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | [InteractionPositionForPlayer](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#a7e2112d309b46421094a172d5d714674) `[get]` |
| override bool | [IsMobileEntity](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#a51646e7b9e34f816f773e4b2146f701a) `[get]` |
| override bool | [IsMainEntity](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#a4c3fe9df162ac3a039d4de3ed40ef2ef) `[get]` |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [StrategicEntity](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#a95f34035a9da7e53b1082951e61eaa8c) `[get]` |
| [AgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html) | [HumanAgentVisuals](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#a168459e1438e6c54f4b8566844b2544c) `[get]` |
| [AgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html) | [MountAgentVisuals](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#a15f03bb0b23fcbd1d6f43d1a7a672f00) `[get]` |
| [AgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html) | [CaravanMountAgentVisuals](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#a2b598d024243b81a63c88077f6b3246a) `[get]` |
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

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#a75d3da693850b563cecca3427683df46)MobilePartyVisual()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| SandBox.View.Map.Visuals.MobilePartyVisual.MobilePartyVisual | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *partyBase* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#a34cdcd8559c8f71a46018e635b5071f0)IsEnemyOf()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override bool SandBox.View.Map.Visuals.MobilePartyVisual.IsEnemyOf | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction* | ) |  | | virtual |

Reimplemented from [SandBox.View.Map.Visuals.MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#a513030b6c090d05f1f7c0ae16fed627a).

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#a3108f39aaa12b50f619f51f7a6cde46b)IsAllyOf()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override bool SandBox.View.Map.Visuals.MobilePartyVisual.IsAllyOf | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction* | ) |  | | virtual |

Reimplemented from [SandBox.View.Map.Visuals.MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#ab7a8abc00c4d87513030e5663c88c7e1).

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#add7110e5ba6d5909cfc44a80c71edcc8)OnTrackAction()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.View.Map.Visuals.MobilePartyVisual.OnTrackAction | ( |  | ) |  | | virtual |

Reimplemented from [SandBox.View.Map.Visuals.MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#a7ad1ed3d661a9df3d13df6d9e6ce9fbf).

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#aaa8b3ceafdc82476c56158c20c9bd105)OnMapClick()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool SandBox.View.Map.Visuals.MobilePartyVisual.OnMapClick | ( | bool | *followModifierUsed* | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#a6375c739c9aaddd67c1f9424dcec6277)OnHover()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void SandBox.View.Map.Visuals.MobilePartyVisual.OnHover | ( |  | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#ae352753353265e032664362033e7a619)GetVisualPosition()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) SandBox.View.Map.Visuals.MobilePartyVisual.GetVisualPosition | ( |  | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#a30fc40cc64905eb37c5715eef59a050f)ReleaseResources()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.View.Map.Visuals.MobilePartyVisual.ReleaseResources | ( |  | ) |  | | virtual |

Reimplemented from [SandBox.View.Map.Visuals.MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html#a291e1626e881e7fb84e322664639c89e).

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#a0536107d31c4f2256ae4f8fbc889271a)IsVisibleOrFadingOut()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override bool SandBox.View.Map.Visuals.MobilePartyVisual.IsVisibleOrFadingOut | ( |  | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#a00b0740e3df5c4b70dbe91faa236068a)OnOpenEncyclopedia()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void SandBox.View.Map.Visuals.MobilePartyVisual.OnOpenEncyclopedia | ( |  | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#a275dbd75a6335fa84bb78306f8aade39)GetBannerOfCharacter()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) SandBox.View.Map.Visuals.MobilePartyVisual.GetBannerOfCharacter | ( | [Banner](class_tale_worlds_1_1_core_1_1_banner.html) | *banner*, | |  |  | string | *bannerMeshName* ) | | static |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#a61b39a43d78bcb416f4912222dc61151)AddTentEntityForParty()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.View.Map.Visuals.MobilePartyVisual.AddTentEntityForParty | ( | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *strategicEntity*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, |
|  |  | ref bool | *clearBannerComponentCache* ) |

Property Documentation
----------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#a4a3d8f3fa00a26714b3830aa7420a487)BearingRotation
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float SandBox.View.Map.Visuals.MobilePartyVisual.BearingRotation | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#a82ca38c4326b64246a41cc9c69dec997)AttachedTo
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual-1-g.html#aae194c8456324a49b0d81554f14e330a) SandBox.View.Map.Visuals.MobilePartyVisual.AttachedTo | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#a7e2112d309b46421094a172d5d714674)InteractionPositionForPlayer
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) SandBox.View.Map.Visuals.MobilePartyVisual.InteractionPositionForPlayer | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#a51646e7b9e34f816f773e4b2146f701a)IsMobileEntity
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override bool SandBox.View.Map.Visuals.MobilePartyVisual.IsMobileEntity | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#a4c3fe9df162ac3a039d4de3ed40ef2ef)IsMainEntity
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override bool SandBox.View.Map.Visuals.MobilePartyVisual.IsMainEntity | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#a95f34035a9da7e53b1082951e61eaa8c)StrategicEntity
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) SandBox.View.Map.Visuals.MobilePartyVisual.StrategicEntity | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#a168459e1438e6c54f4b8566844b2544c)HumanAgentVisuals
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [AgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html) SandBox.View.Map.Visuals.MobilePartyVisual.HumanAgentVisuals | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#a15f03bb0b23fcbd1d6f43d1a7a672f00)MountAgentVisuals
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [AgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html) SandBox.View.Map.Visuals.MobilePartyVisual.MountAgentVisuals | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html#a2b598d024243b81a63c88077f6b3246a)CaravanMountAgentVisuals
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [AgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html) SandBox.View.Map.Visuals.MobilePartyVisual.CaravanMountAgentVisuals | | get |

