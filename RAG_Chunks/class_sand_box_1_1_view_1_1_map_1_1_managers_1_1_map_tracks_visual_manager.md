--- SOURCE: class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_tracks_visual_manager.html ---

SandBox.View.Map.Managers.MapTracksVisualManager Class ReferenceInherits [SandBox.View.Map.Managers.EntityVisualManagerBase< TEntity >](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_entity_visual_manager_base-1-g.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MapTracksVisualManager](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_tracks_visual_manager.html#aea9dab8506f6f4dcf25350370e67c268) () |
| override void | [OnVisualTick](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_tracks_visual_manager.html#a689c222a834d379ed15a1745b8ee6317) ([MapScreen](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html) screen, float realDt, float dt) |
| override bool | [OnVisualIntersected](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_tracks_visual_manager.html#a84fd4d96f814eb937ad1fa38d45df5a8) ([Ray](struct_tale_worlds_1_1_library_1_1_ray.html) mouseRay, UIntPtr[] intersectedEntityIDs, [Intersection](struct_tale_worlds_1_1_engine_1_1_intersection.html)[] intersectionInfos, int entityCount, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) worldMouseNear, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) worldMouseFar, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) terrainIntersectionPoint, ref [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) hoveredVisual, ref [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) selectedVisual) |
| override void | [OnGameLoadFinished](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_tracks_visual_manager.html#acddedf38594df2d3172ee6a73432a917) () |
| override [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html)< [Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) > | [GetVisualOfEntity](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_tracks_visual_manager.html#a3ea54993c413a10ef194a52c065de5ea) ([Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) entity) |
| Public Member Functions inherited from [SandBox.View.Map.Managers.EntityVisualManagerBase< TEntity >](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_entity_visual_manager_base-1-g.html) | |
| [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html)< TEntity > | [GetVisualOfEntity](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_entity_visual_manager_base-1-g.html#a509edb49e43c6e798fa8a364718aa5da) (TEntity entity) |
| Public Member Functions inherited from [SandBox.View.Map.CampaignEntityVisualComponent](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html) | |
| virtual bool | [OnMouseClick](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#ad6d5323b1ec3e619a7a04127bea0203d) ([MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) visualOfSelectedEntity, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) intersectionPoint, [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) mouseOverFaceIndex, bool isDoubleClick) |
| virtual void | [OnFrameTick](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#a8aaefcb31569ccde23d75537756b4fb4) (float dt) |
| virtual void | [OnTick](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#a8d45a987aeaa4529b4701c2bf4450c3f) (float realDt, float dt) |
| virtual void | [ClearVisualMemory](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#af5ec6f5b3305f8b5d314d9f99b95169c) () |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnFinalize](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_tracks_visual_manager.html#a3c397a3a97051f43d69fa10eedc08919) () |
| override void | [OnInitialize](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_tracks_visual_manager.html#a14a1be4554096815d09f91dc1714397d) () |

|  |  |
| --- | --- |
| Properties | |
| static [MapTracksVisualManager](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_tracks_visual_manager.html#aea9dab8506f6f4dcf25350370e67c268) | [Current](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_tracks_visual_manager.html#a78d73c214fda1b253518b21b62fd434b) `[get]` |
| override int | [Priority](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_tracks_visual_manager.html#ad79ddccb452e95fb60185e5237e1f355) `[get]` |
| Properties inherited from [SandBox.View.Map.Managers.EntityVisualManagerBase](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_entity_visual_manager_base.html) | |
| [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | [MapScene](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_entity_visual_manager_base.html#a7ba7cae49c8cf20e173d944e80e66a5a) `[get]` |
| Properties inherited from [SandBox.View.Map.CampaignEntityVisualComponent](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html) | |
| virtual int | [Priority](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#a6020ffe5b9a64319089f18addf557485) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [SandBox.View.Map.Managers.EntityVisualManagerBase< TEntity >](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_entity_visual_manager_base-1-g.html) | |
| static [EntityVisualManagerBase](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_entity_visual_manager_base.html)< TEntity > | [GetEntityVisualManagerBase](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_entity_visual_manager_base-1-g.html#af607286c55ea8f5c0b23fd488367b801) () |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_tracks_visual_manager.html#aea9dab8506f6f4dcf25350370e67c268)MapTracksVisualManager()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| SandBox.View.Map.Managers.MapTracksVisualManager.MapTracksVisualManager | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_tracks_visual_manager.html#a689c222a834d379ed15a1745b8ee6317)OnVisualTick()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void SandBox.View.Map.Managers.MapTracksVisualManager.OnVisualTick | ( | [MapScreen](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html) | *screen*, | |  |  | float | *realDt*, | |  |  | float | *dt* ) | | virtual |

Reimplemented from [SandBox.View.Map.CampaignEntityVisualComponent](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#ae06d90ae358b2d12ca56ab4405adef42).

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_tracks_visual_manager.html#a84fd4d96f814eb937ad1fa38d45df5a8)OnVisualIntersected()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override bool SandBox.View.Map.Managers.MapTracksVisualManager.OnVisualIntersected | ( | [Ray](struct_tale_worlds_1_1_library_1_1_ray.html) | *mouseRay*, | |  |  | UIntPtr[] | *intersectedEntityIDs*, | |  |  | [Intersection](struct_tale_worlds_1_1_engine_1_1_intersection.html)[] | *intersectionInfos*, | |  |  | int | *entityCount*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *worldMouseNear*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *worldMouseFar*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *terrainIntersectionPoint*, | |  |  | ref [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) | *hoveredVisual*, | |  |  | ref [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) | *selectedVisual* ) | | virtual |

Reimplemented from [SandBox.View.Map.CampaignEntityVisualComponent](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#ad01384ad8bee563491f68e95f8518fa9).

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_tracks_visual_manager.html#acddedf38594df2d3172ee6a73432a917)OnGameLoadFinished()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.View.Map.Managers.MapTracksVisualManager.OnGameLoadFinished | ( |  | ) |  | | virtual |

Reimplemented from [SandBox.View.Map.CampaignEntityVisualComponent](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#aa0d1c778dceac329b37cab9f89250866).

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_tracks_visual_manager.html#a3ea54993c413a10ef194a52c065de5ea)GetVisualOfEntity()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html)< [Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) > SandBox.View.Map.Managers.MapTracksVisualManager.GetVisualOfEntity | ( | [Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) | *entity* | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_tracks_visual_manager.html#a3c397a3a97051f43d69fa10eedc08919)OnFinalize()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.View.Map.Managers.MapTracksVisualManager.OnFinalize | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Map.CampaignEntityVisualComponent](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#a7b8fff62960f0056f396c1d635e6fc98).

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_tracks_visual_manager.html#a14a1be4554096815d09f91dc1714397d)OnInitialize()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.View.Map.Managers.MapTracksVisualManager.OnInitialize | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Map.CampaignEntityVisualComponent](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#ac013367a7fa0746866fa9b43c5591938).

Property Documentation
----------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_tracks_visual_manager.html#a78d73c214fda1b253518b21b62fd434b)Current
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MapTracksVisualManager](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_tracks_visual_manager.html#aea9dab8506f6f4dcf25350370e67c268) SandBox.View.Map.Managers.MapTracksVisualManager.Current | | staticget |

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_tracks_visual_manager.html#ad79ddccb452e95fb60185e5237e1f355)Priority
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int SandBox.View.Map.Managers.MapTracksVisualManager.Priority | | get |

