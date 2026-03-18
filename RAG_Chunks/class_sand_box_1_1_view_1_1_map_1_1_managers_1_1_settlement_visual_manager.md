--- SOURCE: class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_settlement_visual_manager.html ---

SandBox.View.Map.Managers.SettlementVisualManager Class ReferenceInherits [SandBox.View.Map.Managers.EntityVisualManagerBase< TEntity >](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_entity_visual_manager_base-1-g.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [OnTick](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_settlement_visual_manager.html#adbda13555a9648dc85b2223e83b14229) (float realDt, float dt) |
| override bool | [OnVisualIntersected](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_settlement_visual_manager.html#a9927f6c2a7ac5b8ebf4917a5d064a0b9) ([Ray](struct_tale_worlds_1_1_library_1_1_ray.html) mouseRay, UIntPtr[] intersectedEntityIDs, [Intersection](struct_tale_worlds_1_1_engine_1_1_intersection.html)[] intersectionInfos, int entityCount, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) worldMouseNear, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) worldMouseFar, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) terrainIntersectionPoint, ref [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) hoveredVisual, ref [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) selectedVisual) |
| override void | [OnFrameTick](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_settlement_visual_manager.html#a1eee9c67ed49cf606509738726533858) (float dt) |
| override bool | [OnMouseClick](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_settlement_visual_manager.html#aa75ddf5f18b4a2fc923759037a11bc4e) ([MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) visualOfSelectedEntity, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) intersectionPoint, [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) mouseOverFaceIndex, bool isDoubleClick) |
| override [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html)< [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > | [GetVisualOfEntity](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_settlement_visual_manager.html#abcd606a447b1d26a0b9da7eab146c4fb) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) partyBase) |
| [SettlementVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html) | [GetSettlementVisual](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_settlement_visual_manager.html#ae6eba4aaf03baf7b7fc616f81c675fe3) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| Public Member Functions inherited from [SandBox.View.Map.Managers.EntityVisualManagerBase< TEntity >](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_entity_visual_manager_base-1-g.html) | |
| [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html)< TEntity > | [GetVisualOfEntity](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_entity_visual_manager_base-1-g.html#a509edb49e43c6e798fa8a364718aa5da) (TEntity entity) |
| Public Member Functions inherited from [SandBox.View.Map.CampaignEntityVisualComponent](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html) | |
| virtual void | [OnVisualTick](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#ae06d90ae358b2d12ca56ab4405adef42) ([MapScreen](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html) screen, float realDt, float dt) |
| virtual void | [OnGameLoadFinished](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#aa0d1c778dceac329b37cab9f89250866) () |
| virtual void | [ClearVisualMemory](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#af5ec6f5b3305f8b5d314d9f99b95169c) () |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnInitialize](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_settlement_visual_manager.html#a42dc1b8ed96260fc924e8c2db69838ff) () |
| override void | [OnFinalize](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_settlement_visual_manager.html#a370d5bf2b129180f3555a20bad60eafc) () |

|  |  |
| --- | --- |
| Properties | |
| override int | [Priority](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_settlement_visual_manager.html#a394db672951389c41b4cd1f901cfb9bf) `[get]` |
| static [SettlementVisualManager](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_settlement_visual_manager.html) | [Current](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_settlement_visual_manager.html#a6625e22c93f8fc60097f07383e1dffd4) `[get]` |
| Properties inherited from [SandBox.View.Map.Managers.EntityVisualManagerBase](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_entity_visual_manager_base.html) | |
| [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | [MapScene](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_entity_visual_manager_base.html#a7ba7cae49c8cf20e173d944e80e66a5a) `[get]` |
| Properties inherited from [SandBox.View.Map.CampaignEntityVisualComponent](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html) | |
| virtual int | [Priority](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#a6020ffe5b9a64319089f18addf557485) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [SandBox.View.Map.Managers.EntityVisualManagerBase< TEntity >](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_entity_visual_manager_base-1-g.html) | |
| static [EntityVisualManagerBase](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_entity_visual_manager_base.html)< TEntity > | [GetEntityVisualManagerBase](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_entity_visual_manager_base-1-g.html#af607286c55ea8f5c0b23fd488367b801) () |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_settlement_visual_manager.html#adbda13555a9648dc85b2223e83b14229)OnTick()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void SandBox.View.Map.Managers.SettlementVisualManager.OnTick | ( | float | *realDt*, | |  |  | float | *dt* ) | | virtual |

Reimplemented from [SandBox.View.Map.CampaignEntityVisualComponent](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#a8d45a987aeaa4529b4701c2bf4450c3f).

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_settlement_visual_manager.html#a9927f6c2a7ac5b8ebf4917a5d064a0b9)OnVisualIntersected()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override bool SandBox.View.Map.Managers.SettlementVisualManager.OnVisualIntersected | ( | [Ray](struct_tale_worlds_1_1_library_1_1_ray.html) | *mouseRay*, | |  |  | UIntPtr[] | *intersectedEntityIDs*, | |  |  | [Intersection](struct_tale_worlds_1_1_engine_1_1_intersection.html)[] | *intersectionInfos*, | |  |  | int | *entityCount*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *worldMouseNear*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *worldMouseFar*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *terrainIntersectionPoint*, | |  |  | ref [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) | *hoveredVisual*, | |  |  | ref [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) | *selectedVisual* ) | | virtual |

Reimplemented from [SandBox.View.Map.CampaignEntityVisualComponent](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#ad01384ad8bee563491f68e95f8518fa9).

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_settlement_visual_manager.html#a1eee9c67ed49cf606509738726533858)OnFrameTick()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.View.Map.Managers.SettlementVisualManager.OnFrameTick | ( | float | *dt* | ) |  | | virtual |

Reimplemented from [SandBox.View.Map.CampaignEntityVisualComponent](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#a8aaefcb31569ccde23d75537756b4fb4).

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_settlement_visual_manager.html#aa75ddf5f18b4a2fc923759037a11bc4e)OnMouseClick()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override bool SandBox.View.Map.Managers.SettlementVisualManager.OnMouseClick | ( | [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) | *visualOfSelectedEntity*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *intersectionPoint*, | |  |  | [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | *mouseOverFaceIndex*, | |  |  | bool | *isDoubleClick* ) | | virtual |

Reimplemented from [SandBox.View.Map.CampaignEntityVisualComponent](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#ad6d5323b1ec3e619a7a04127bea0203d).

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_settlement_visual_manager.html#abcd606a447b1d26a0b9da7eab146c4fb)GetVisualOfEntity()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html)< [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > SandBox.View.Map.Managers.SettlementVisualManager.GetVisualOfEntity | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *partyBase* | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_settlement_visual_manager.html#ae6eba4aaf03baf7b7fc616f81c675fe3)GetSettlementVisual()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [SettlementVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_settlement_visual.html) SandBox.View.Map.Managers.SettlementVisualManager.GetSettlementVisual | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_settlement_visual_manager.html#a42dc1b8ed96260fc924e8c2db69838ff)OnInitialize()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.View.Map.Managers.SettlementVisualManager.OnInitialize | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Map.CampaignEntityVisualComponent](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#ac013367a7fa0746866fa9b43c5591938).

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_settlement_visual_manager.html#a370d5bf2b129180f3555a20bad60eafc)OnFinalize()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.View.Map.Managers.SettlementVisualManager.OnFinalize | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Map.CampaignEntityVisualComponent](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#a7b8fff62960f0056f396c1d635e6fc98).

Property Documentation
----------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_settlement_visual_manager.html#a394db672951389c41b4cd1f901cfb9bf)Priority
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int SandBox.View.Map.Managers.SettlementVisualManager.Priority | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_settlement_visual_manager.html#a6625e22c93f8fc60097f07383e1dffd4)Current
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SettlementVisualManager](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_settlement_visual_manager.html) SandBox.View.Map.Managers.SettlementVisualManager.Current | | staticget |

