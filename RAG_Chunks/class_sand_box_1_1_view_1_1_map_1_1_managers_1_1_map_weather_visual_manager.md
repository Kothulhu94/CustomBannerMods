--- SOURCE: class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_weather_visual_manager.html ---

SandBox.View.Map.Managers.MapWeatherVisualManager Class ReferenceInherits [SandBox.View.Map.Managers.EntityVisualManagerBase< TEntity >](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_entity_visual_manager_base-1-g.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MapWeatherVisualManager](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_weather_visual_manager.html#a77c858ef33b272a388e02b60fa91275b) () |
| override void | [OnVisualTick](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_weather_visual_manager.html#a9fb34ccbf9dc3fbae4f5dffb7f91f8a8) ([MapScreen](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html) screen, float realDt, float dt) |
| void | [SetRainData](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_weather_visual_manager.html#a4ca6b60706812162146269aaa325c411) (int dataIndex, byte value) |
| void | [SetCloudData](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_weather_visual_manager.html#aa295f3cb76b37a938eea9829df604a74) (int dataIndex, byte value) |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [GetRainPrefabFromPool](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_weather_visual_manager.html#ad28fd03222d6106d7cc90193e074d1cc) () |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [GetBlizzardPrefabFromPool](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_weather_visual_manager.html#a03014606927817a0652c8a7757dbf8f2) () |
| void | [ReleaseRainPrefab](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_weather_visual_manager.html#a47fc3da748ec23f448e999f5caa55856) ([GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) prefab) |
| void | [ReleaseBlizzardPrefab](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_weather_visual_manager.html#a6e0123855193dcf6738e80ba0f7d6603) ([GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) prefab) |
| override [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html)< [WeatherNode](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_weather_node.html) > | [GetVisualOfEntity](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_weather_visual_manager.html#aec050d3a01d53ad4eadc6802a9245cf4) ([WeatherNode](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_weather_node.html) entity) |
| Public Member Functions inherited from [SandBox.View.Map.Managers.EntityVisualManagerBase< TEntity >](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_entity_visual_manager_base-1-g.html) | |
| [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html)< TEntity > | [GetVisualOfEntity](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_entity_visual_manager_base-1-g.html#a509edb49e43c6e798fa8a364718aa5da) (TEntity entity) |
| Public Member Functions inherited from [SandBox.View.Map.CampaignEntityVisualComponent](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html) | |
| virtual bool | [OnMouseClick](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#ad6d5323b1ec3e619a7a04127bea0203d) ([MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) visualOfSelectedEntity, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) intersectionPoint, [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) mouseOverFaceIndex, bool isDoubleClick) |
| virtual bool | [OnVisualIntersected](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#ad01384ad8bee563491f68e95f8518fa9) ([Ray](struct_tale_worlds_1_1_library_1_1_ray.html) mouseRay, UIntPtr[] intersectedEntityIDs, [Intersection](struct_tale_worlds_1_1_engine_1_1_intersection.html)[] intersectionInfos, int entityCount, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) worldMouseNear, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) worldMouseFar, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) terrainIntersectionPoint, ref [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) hoveredVisual, ref [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) selectedVisual) |
| virtual void | [OnFrameTick](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#a8aaefcb31569ccde23d75537756b4fb4) (float dt) |
| virtual void | [OnGameLoadFinished](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#aa0d1c778dceac329b37cab9f89250866) () |
| virtual void | [OnTick](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#a8d45a987aeaa4529b4701c2bf4450c3f) (float realDt, float dt) |
| virtual void | [ClearVisualMemory](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#af5ec6f5b3305f8b5d314d9f99b95169c) () |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const int | [DefaultCloudHeight](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_weather_visual_manager.html#a05bd54098983dc1a42e6b18e2422cd6d) = 26 |
| const int | [OpenSeaStormCloudHeight](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_weather_visual_manager.html#aee7c6fd13104fad930fab105e0347575) = 20 |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnInitialize](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_weather_visual_manager.html#a612d4bf048ce70cad5f9d59c81b3941c) () |
| Protected Member Functions inherited from [SandBox.View.Map.CampaignEntityVisualComponent](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html) | |
| virtual void | [OnFinalize](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#a7b8fff62960f0056f396c1d635e6fc98) () |

|  |  |
| --- | --- |
| Properties | |
| static [MapWeatherVisualManager](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_weather_visual_manager.html#a77c858ef33b272a388e02b60fa91275b) | [Current](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_weather_visual_manager.html#a5e1de8416ebfd3f8ae7ecf2e7fff0393) `[get]` |
| override int | [Priority](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_weather_visual_manager.html#a760c1c6300a209360c658c4c8cfedf5a) `[get]` |
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

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_weather_visual_manager.html#a77c858ef33b272a388e02b60fa91275b)MapWeatherVisualManager()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| SandBox.View.Map.Managers.MapWeatherVisualManager.MapWeatherVisualManager | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_weather_visual_manager.html#a9fb34ccbf9dc3fbae4f5dffb7f91f8a8)OnVisualTick()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void SandBox.View.Map.Managers.MapWeatherVisualManager.OnVisualTick | ( | [MapScreen](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html) | *screen*, | |  |  | float | *realDt*, | |  |  | float | *dt* ) | | virtual |

Reimplemented from [SandBox.View.Map.CampaignEntityVisualComponent](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#ae06d90ae358b2d12ca56ab4405adef42).

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_weather_visual_manager.html#a4ca6b60706812162146269aaa325c411)SetRainData()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.View.Map.Managers.MapWeatherVisualManager.SetRainData | ( | int | *dataIndex*, |
|  |  | byte | *value* ) |

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_weather_visual_manager.html#aa295f3cb76b37a938eea9829df604a74)SetCloudData()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.View.Map.Managers.MapWeatherVisualManager.SetCloudData | ( | int | *dataIndex*, |
|  |  | byte | *value* ) |

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_weather_visual_manager.html#a612d4bf048ce70cad5f9d59c81b3941c)OnInitialize()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.View.Map.Managers.MapWeatherVisualManager.OnInitialize | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Map.CampaignEntityVisualComponent](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#ac013367a7fa0746866fa9b43c5591938).

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_weather_visual_manager.html#ad28fd03222d6106d7cc90193e074d1cc)GetRainPrefabFromPool()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) SandBox.View.Map.Managers.MapWeatherVisualManager.GetRainPrefabFromPool | ( |  | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_weather_visual_manager.html#a03014606927817a0652c8a7757dbf8f2)GetBlizzardPrefabFromPool()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) SandBox.View.Map.Managers.MapWeatherVisualManager.GetBlizzardPrefabFromPool | ( |  | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_weather_visual_manager.html#a47fc3da748ec23f448e999f5caa55856)ReleaseRainPrefab()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.View.Map.Managers.MapWeatherVisualManager.ReleaseRainPrefab | ( | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *prefab* | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_weather_visual_manager.html#a6e0123855193dcf6738e80ba0f7d6603)ReleaseBlizzardPrefab()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.View.Map.Managers.MapWeatherVisualManager.ReleaseBlizzardPrefab | ( | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *prefab* | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_weather_visual_manager.html#aec050d3a01d53ad4eadc6802a9245cf4)GetVisualOfEntity()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html)< [WeatherNode](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_weather_node.html) > SandBox.View.Map.Managers.MapWeatherVisualManager.GetVisualOfEntity | ( | [WeatherNode](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_weather_node.html) | *entity* | ) |  |

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_weather_visual_manager.html#a05bd54098983dc1a42e6b18e2422cd6d)DefaultCloudHeight
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int SandBox.View.Map.Managers.MapWeatherVisualManager.DefaultCloudHeight = 26 | | static |

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_weather_visual_manager.html#aee7c6fd13104fad930fab105e0347575)OpenSeaStormCloudHeight
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int SandBox.View.Map.Managers.MapWeatherVisualManager.OpenSeaStormCloudHeight = 20 | | static |

Property Documentation
----------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_weather_visual_manager.html#a5e1de8416ebfd3f8ae7ecf2e7fff0393)Current
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MapWeatherVisualManager](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_weather_visual_manager.html#a77c858ef33b272a388e02b60fa91275b) SandBox.View.Map.Managers.MapWeatherVisualManager.Current | | staticget |

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_map_weather_visual_manager.html#a760c1c6300a209360c658c4c8cfedf5a)Priority
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int SandBox.View.Map.Managers.MapWeatherVisualManager.Priority | | get |

