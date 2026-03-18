--- SOURCE: class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html ---

SandBox.View.Map.CampaignEntityVisualComponent Class ReferenceInherits [TaleWorlds.Core.IEntityComponent](interface_tale_worlds_1_1_core_1_1_i_entity_component.html).

Inherited by [SandBox.View.Map.Managers.EntityVisualManagerBase](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_entity_visual_manager_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| virtual void | [OnVisualTick](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#ae06d90ae358b2d12ca56ab4405adef42) ([MapScreen](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html) screen, float realDt, float dt) |
| virtual bool | [OnMouseClick](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#ad6d5323b1ec3e619a7a04127bea0203d) ([MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) visualOfSelectedEntity, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) intersectionPoint, [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) mouseOverFaceIndex, bool isDoubleClick) |
| virtual bool | [OnVisualIntersected](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#ad01384ad8bee563491f68e95f8518fa9) ([Ray](struct_tale_worlds_1_1_library_1_1_ray.html) mouseRay, UIntPtr[] intersectedEntityIDs, [Intersection](struct_tale_worlds_1_1_engine_1_1_intersection.html)[] intersectionInfos, int entityCount, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) worldMouseNear, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) worldMouseFar, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) terrainIntersectionPoint, ref [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) hoveredVisual, ref [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) selectedVisual) |
| virtual void | [OnFrameTick](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#a8aaefcb31569ccde23d75537756b4fb4) (float dt) |
| virtual void | [OnGameLoadFinished](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#aa0d1c778dceac329b37cab9f89250866) () |
| virtual void | [OnTick](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#a8d45a987aeaa4529b4701c2bf4450c3f) (float realDt, float dt) |
| virtual void | [ClearVisualMemory](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#af5ec6f5b3305f8b5d314d9f99b95169c) () |

|  |  |
| --- | --- |
| Protected Member Functions | |
| virtual void | [OnInitialize](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#ac013367a7fa0746866fa9b43c5591938) () |
| virtual void | [OnFinalize](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#a7b8fff62960f0056f396c1d635e6fc98) () |

|  |  |
| --- | --- |
| Properties | |
| virtual int | [Priority](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#a6020ffe5b9a64319089f18addf557485) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#ae06d90ae358b2d12ca56ab4405adef42)OnVisualTick()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void SandBox.View.Map.CampaignEntityVisualComponent.OnVisualTick | ( | [MapScreen](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html) | *screen*, | |  |  | float | *realDt*, | |  |  | float | *dt* ) | | virtual |

Reimplemented in [SandBox.View.Map.Managers.MapTracksVisualManager](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_tracks_visual_manager.html#a689c222a834d379ed15a1745b8ee6317), [SandBox.View.Map.Managers.MapWeatherVisualManager](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_weather_visual_manager.html#a9fb34ccbf9dc3fbae4f5dffb7f91f8a8), and [SandBox.View.Map.Managers.MobilePartyVisualManager](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_mobile_party_visual_manager.html#a91458d045240bce627079178c67336b2).

[◆](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#ad6d5323b1ec3e619a7a04127bea0203d)OnMouseClick()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual bool SandBox.View.Map.CampaignEntityVisualComponent.OnMouseClick | ( | [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) | *visualOfSelectedEntity*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *intersectionPoint*, | |  |  | [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | *mouseOverFaceIndex*, | |  |  | bool | *isDoubleClick* ) | | virtual |

Reimplemented in [SandBox.View.Map.Managers.SettlementVisualManager](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_settlement_visual_manager.html#aa75ddf5f18b4a2fc923759037a11bc4e).

[◆](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#ad01384ad8bee563491f68e95f8518fa9)OnVisualIntersected()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual bool SandBox.View.Map.CampaignEntityVisualComponent.OnVisualIntersected | ( | [Ray](struct_tale_worlds_1_1_library_1_1_ray.html) | *mouseRay*, | |  |  | UIntPtr[] | *intersectedEntityIDs*, | |  |  | [Intersection](struct_tale_worlds_1_1_engine_1_1_intersection.html)[] | *intersectionInfos*, | |  |  | int | *entityCount*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *worldMouseNear*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *worldMouseFar*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *terrainIntersectionPoint*, | |  |  | ref [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) | *hoveredVisual*, | |  |  | ref [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) | *selectedVisual* ) | | virtual |

Reimplemented in [SandBox.View.Map.Managers.MapTracksVisualManager](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_tracks_visual_manager.html#a84fd4d96f814eb937ad1fa38d45df5a8), [SandBox.View.Map.Managers.MobilePartyVisualManager](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_mobile_party_visual_manager.html#afe3d822a94889aa86418f30dfefdfcd2), and [SandBox.View.Map.Managers.SettlementVisualManager](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_settlement_visual_manager.html#a9927f6c2a7ac5b8ebf4917a5d064a0b9).

[◆](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#a8aaefcb31569ccde23d75537756b4fb4)OnFrameTick()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void SandBox.View.Map.CampaignEntityVisualComponent.OnFrameTick | ( | float | *dt* | ) |  | | virtual |

Reimplemented in [SandBox.View.Map.Managers.SettlementVisualManager](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_settlement_visual_manager.html#a1eee9c67ed49cf606509738726533858).

[◆](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#aa0d1c778dceac329b37cab9f89250866)OnGameLoadFinished()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void SandBox.View.Map.CampaignEntityVisualComponent.OnGameLoadFinished | ( |  | ) |  | | virtual |

Reimplemented in [SandBox.View.Map.Managers.MapTracksVisualManager](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_tracks_visual_manager.html#acddedf38594df2d3172ee6a73432a917).

[◆](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#a8d45a987aeaa4529b4701c2bf4450c3f)OnTick()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void SandBox.View.Map.CampaignEntityVisualComponent.OnTick | ( | float | *realDt*, | |  |  | float | *dt* ) | | virtual |

Reimplemented in [SandBox.View.Map.Managers.MobilePartyVisualManager](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_mobile_party_visual_manager.html#a2a02a9f97f01ec15b0456252d68a7a90), and [SandBox.View.Map.Managers.SettlementVisualManager](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_settlement_visual_manager.html#adbda13555a9648dc85b2223e83b14229).

[◆](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#af5ec6f5b3305f8b5d314d9f99b95169c)ClearVisualMemory()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void SandBox.View.Map.CampaignEntityVisualComponent.ClearVisualMemory | ( |  | ) |  | | virtual |

Reimplemented in [SandBox.View.Map.Managers.MobilePartyVisualManager](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_mobile_party_visual_manager.html#a4932f6a309efeb7742b6d764c7e54e70).

[◆](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#ac013367a7fa0746866fa9b43c5591938)OnInitialize()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void SandBox.View.Map.CampaignEntityVisualComponent.OnInitialize | ( |  | ) |  | | protectedvirtual |

Implements [TaleWorlds.Core.IEntityComponent](interface_tale_worlds_1_1_core_1_1_i_entity_component.html#a3c72fe2025800ba4f834ad3e80400e02).

Reimplemented in [SandBox.View.Map.Managers.MapTracksVisualManager](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_tracks_visual_manager.html#a14a1be4554096815d09f91dc1714397d), [SandBox.View.Map.Managers.MapWeatherVisualManager](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_weather_visual_manager.html#a612d4bf048ce70cad5f9d59c81b3941c), [SandBox.View.Map.Managers.MobilePartyVisualManager](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_mobile_party_visual_manager.html#a7654d8118b95affad5f8fd39a483e132), and [SandBox.View.Map.Managers.SettlementVisualManager](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_settlement_visual_manager.html#a42dc1b8ed96260fc924e8c2db69838ff).

[◆](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#a7b8fff62960f0056f396c1d635e6fc98)OnFinalize()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void SandBox.View.Map.CampaignEntityVisualComponent.OnFinalize | ( |  | ) |  | | protectedvirtual |

Implements [TaleWorlds.Core.IEntityComponent](interface_tale_worlds_1_1_core_1_1_i_entity_component.html#a549cc1f41ba91a20fe0e471be9da1e6e).

Reimplemented in [SandBox.View.Map.Managers.MapTracksVisualManager](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_tracks_visual_manager.html#a3c397a3a97051f43d69fa10eedc08919), [SandBox.View.Map.Managers.MobilePartyVisualManager](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_mobile_party_visual_manager.html#a1d074e7a950b2e46b6cc631824f07192), and [SandBox.View.Map.Managers.SettlementVisualManager](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_settlement_visual_manager.html#a370d5bf2b129180f3555a20bad60eafc).

Property Documentation
----------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#a6020ffe5b9a64319089f18addf557485)Priority
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual int SandBox.View.Map.CampaignEntityVisualComponent.Priority | | get |

