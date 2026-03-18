--- SOURCE: class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_entity_visual_manager_base.html ---

SandBox.View.Map.Managers.EntityVisualManagerBase Class ReferenceabstractInherits [SandBox.View.Map.CampaignEntityVisualComponent](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html).

Inherited by [SandBox.View.Map.Managers.EntityVisualManagerBase< TEntity >](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_entity_visual_manager_base-1-g.html).

|  |  |
| --- | --- |
| Properties | |
| [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | [MapScene](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_entity_visual_manager_base.html#a7ba7cae49c8cf20e173d944e80e66a5a) `[get]` |
| Properties inherited from [SandBox.View.Map.CampaignEntityVisualComponent](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html) | |
| virtual int | [Priority](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#a6020ffe5b9a64319089f18addf557485) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Member Functions inherited from [SandBox.View.Map.CampaignEntityVisualComponent](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html) | |
| virtual void | [OnVisualTick](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#ae06d90ae358b2d12ca56ab4405adef42) ([MapScreen](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html) screen, float realDt, float dt) |
| virtual bool | [OnMouseClick](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#ad6d5323b1ec3e619a7a04127bea0203d) ([MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) visualOfSelectedEntity, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) intersectionPoint, [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) mouseOverFaceIndex, bool isDoubleClick) |
| virtual bool | [OnVisualIntersected](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#ad01384ad8bee563491f68e95f8518fa9) ([Ray](struct_tale_worlds_1_1_library_1_1_ray.html) mouseRay, UIntPtr[] intersectedEntityIDs, [Intersection](struct_tale_worlds_1_1_engine_1_1_intersection.html)[] intersectionInfos, int entityCount, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) worldMouseNear, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) worldMouseFar, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) terrainIntersectionPoint, ref [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) hoveredVisual, ref [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) selectedVisual) |
| virtual void | [OnFrameTick](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#a8aaefcb31569ccde23d75537756b4fb4) (float dt) |
| virtual void | [OnGameLoadFinished](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#aa0d1c778dceac329b37cab9f89250866) () |
| virtual void | [OnTick](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#a8d45a987aeaa4529b4701c2bf4450c3f) (float realDt, float dt) |
| virtual void | [ClearVisualMemory](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#af5ec6f5b3305f8b5d314d9f99b95169c) () |
| Protected Member Functions inherited from [SandBox.View.Map.CampaignEntityVisualComponent](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html) | |
| virtual void | [OnInitialize](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#ac013367a7fa0746866fa9b43c5591938) () |
| virtual void | [OnFinalize](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#a7b8fff62960f0056f396c1d635e6fc98) () |

Property Documentation
----------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_entity_visual_manager_base.html#a7ba7cae49c8cf20e173d944e80e66a5a)MapScene
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) SandBox.View.Map.Managers.EntityVisualManagerBase.MapScene | | get |

