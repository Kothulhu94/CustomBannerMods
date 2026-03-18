--- SOURCE: class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_entity_visual_manager_base-1-g.html ---

SandBox.View.Map.Managers.EntityVisualManagerBase< TEntity > Class Template ReferenceabstractInherits [SandBox.View.Map.Managers.EntityVisualManagerBase](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_entity_visual_manager_base.html).

Inherited by [SandBox.View.Map.Managers.MapTracksVisualManager](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_tracks_visual_manager.html), [SandBox.View.Map.Managers.MapWeatherVisualManager](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_weather_visual_manager.html), [SandBox.View.Map.Managers.MobilePartyVisualManager](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_mobile_party_visual_manager.html), and [SandBox.View.Map.Managers.SettlementVisualManager](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_settlement_visual_manager.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html)< TEntity > | [GetVisualOfEntity](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_entity_visual_manager_base-1-g.html#a509edb49e43c6e798fa8a364718aa5da) (TEntity entity) |
| Public Member Functions inherited from [SandBox.View.Map.CampaignEntityVisualComponent](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html) | |
| virtual void | [OnVisualTick](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#ae06d90ae358b2d12ca56ab4405adef42) ([MapScreen](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html) screen, float realDt, float dt) |
| virtual bool | [OnMouseClick](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#ad6d5323b1ec3e619a7a04127bea0203d) ([MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) visualOfSelectedEntity, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) intersectionPoint, [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) mouseOverFaceIndex, bool isDoubleClick) |
| virtual bool | [OnVisualIntersected](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#ad01384ad8bee563491f68e95f8518fa9) ([Ray](struct_tale_worlds_1_1_library_1_1_ray.html) mouseRay, UIntPtr[] intersectedEntityIDs, [Intersection](struct_tale_worlds_1_1_engine_1_1_intersection.html)[] intersectionInfos, int entityCount, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) worldMouseNear, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) worldMouseFar, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) terrainIntersectionPoint, ref [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) hoveredVisual, ref [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) selectedVisual) |
| virtual void | [OnFrameTick](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#a8aaefcb31569ccde23d75537756b4fb4) (float dt) |
| virtual void | [OnGameLoadFinished](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#aa0d1c778dceac329b37cab9f89250866) () |
| virtual void | [OnTick](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#a8d45a987aeaa4529b4701c2bf4450c3f) (float realDt, float dt) |
| virtual void | [ClearVisualMemory](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#af5ec6f5b3305f8b5d314d9f99b95169c) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [EntityVisualManagerBase](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_entity_visual_manager_base.html)< TEntity > | [GetEntityVisualManagerBase](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_entity_visual_manager_base-1-g.html#af607286c55ea8f5c0b23fd488367b801) () |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Protected Member Functions inherited from [SandBox.View.Map.CampaignEntityVisualComponent](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html) | |
| virtual void | [OnInitialize](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#ac013367a7fa0746866fa9b43c5591938) () |
| virtual void | [OnFinalize](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#a7b8fff62960f0056f396c1d635e6fc98) () |
| Properties inherited from [SandBox.View.Map.Managers.EntityVisualManagerBase](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_entity_visual_manager_base.html) | |
| [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | [MapScene](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_entity_visual_manager_base.html#a7ba7cae49c8cf20e173d944e80e66a5a) `[get]` |
| Properties inherited from [SandBox.View.Map.CampaignEntityVisualComponent](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html) | |
| virtual int | [Priority](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#a6020ffe5b9a64319089f18addf557485) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_entity_visual_manager_base-1-g.html#a509edb49e43c6e798fa8a364718aa5da)GetVisualOfEntity()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html)< TEntity > [SandBox.View.Map.Managers.EntityVisualManagerBase](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_entity_visual_manager_base.html)< TEntity >.GetVisualOfEntity | ( | TEntity | *entity* | ) |  | | abstract |

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_entity_visual_manager_base-1-g.html#af607286c55ea8f5c0b23fd488367b801)GetEntityVisualManagerBase()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [EntityVisualManagerBase](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_entity_visual_manager_base.html)< TEntity > [SandBox.View.Map.Managers.EntityVisualManagerBase](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_entity_visual_manager_base.html)< TEntity >.GetEntityVisualManagerBase | ( |  | ) |  | | static |

