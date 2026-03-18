--- SOURCE: class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_mobile_party_visual_manager.html ---

SandBox.View.Map.Managers.MobilePartyVisualManager Class ReferenceInherits [SandBox.View.Map.Managers.EntityVisualManagerBase< TEntity >](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_entity_visual_manager_base-1-g.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [OnTick](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_mobile_party_visual_manager.html#a2a02a9f97f01ec15b0456252d68a7a90) (float realDt, float dt) |
| override void | [ClearVisualMemory](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_mobile_party_visual_manager.html#a4932f6a309efeb7742b6d764c7e54e70) () |
| override void | [OnVisualTick](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_mobile_party_visual_manager.html#a91458d045240bce627079178c67336b2) ([MapScreen](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html) screen, float realDt, float dt) |
| override bool | [OnVisualIntersected](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_mobile_party_visual_manager.html#afe3d822a94889aa86418f30dfefdfcd2) ([Ray](struct_tale_worlds_1_1_library_1_1_ray.html) mouseRay, UIntPtr[] intersectedEntityIDs, [Intersection](struct_tale_worlds_1_1_engine_1_1_intersection.html)[] intersectionInfos, int entityCount, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) worldMouseNear, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) worldMouseFar, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) terrainIntersectionPoint, ref [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) hoveredVisual, ref [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) selectedVisual) |
| override [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html)< [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > | [GetVisualOfEntity](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_mobile_party_visual_manager.html#af0e159a0399618ae7d01de97328b17b5) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) partyBase) |
| [MobilePartyVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html) | [GetPartyVisual](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_mobile_party_visual_manager.html#a60127e4db20cb906f39f994888a4815b) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) partyBase) |
| Public Member Functions inherited from [SandBox.View.Map.Managers.EntityVisualManagerBase< TEntity >](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_entity_visual_manager_base-1-g.html) | |
| [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html)< TEntity > | [GetVisualOfEntity](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_entity_visual_manager_base-1-g.html#a509edb49e43c6e798fa8a364718aa5da) (TEntity entity) |
| Public Member Functions inherited from [SandBox.View.Map.CampaignEntityVisualComponent](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html) | |
| virtual bool | [OnMouseClick](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#ad6d5323b1ec3e619a7a04127bea0203d) ([MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) visualOfSelectedEntity, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) intersectionPoint, [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) mouseOverFaceIndex, bool isDoubleClick) |
| virtual void | [OnFrameTick](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#a8aaefcb31569ccde23d75537756b4fb4) (float dt) |
| virtual void | [OnGameLoadFinished](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#aa0d1c778dceac329b37cab9f89250866) () |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnFinalize](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_mobile_party_visual_manager.html#a1d074e7a950b2e46b6cc631824f07192) () |
| override void | [OnInitialize](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_mobile_party_visual_manager.html#a7654d8118b95affad5f8fd39a483e132) () |

|  |  |
| --- | --- |
| Properties | |
| override int | [Priority](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_mobile_party_visual_manager.html#a47751dd739cfed2273f4b2bdaa050e4f) `[get]` |
| static [MobilePartyVisualManager](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_mobile_party_visual_manager.html) | [Current](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_mobile_party_visual_manager.html#ac25a609246eb6594608ebdb400aa927c) `[get]` |
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

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_mobile_party_visual_manager.html#a2a02a9f97f01ec15b0456252d68a7a90)OnTick()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void SandBox.View.Map.Managers.MobilePartyVisualManager.OnTick | ( | float | *realDt*, | |  |  | float | *dt* ) | | virtual |

Reimplemented from [SandBox.View.Map.CampaignEntityVisualComponent](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#a8d45a987aeaa4529b4701c2bf4450c3f).

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_mobile_party_visual_manager.html#a4932f6a309efeb7742b6d764c7e54e70)ClearVisualMemory()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.View.Map.Managers.MobilePartyVisualManager.ClearVisualMemory | ( |  | ) |  | | virtual |

Reimplemented from [SandBox.View.Map.CampaignEntityVisualComponent](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#af5ec6f5b3305f8b5d314d9f99b95169c).

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_mobile_party_visual_manager.html#a91458d045240bce627079178c67336b2)OnVisualTick()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void SandBox.View.Map.Managers.MobilePartyVisualManager.OnVisualTick | ( | [MapScreen](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html) | *screen*, | |  |  | float | *realDt*, | |  |  | float | *dt* ) | | virtual |

Reimplemented from [SandBox.View.Map.CampaignEntityVisualComponent](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#ae06d90ae358b2d12ca56ab4405adef42).

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_mobile_party_visual_manager.html#afe3d822a94889aa86418f30dfefdfcd2)OnVisualIntersected()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override bool SandBox.View.Map.Managers.MobilePartyVisualManager.OnVisualIntersected | ( | [Ray](struct_tale_worlds_1_1_library_1_1_ray.html) | *mouseRay*, | |  |  | UIntPtr[] | *intersectedEntityIDs*, | |  |  | [Intersection](struct_tale_worlds_1_1_engine_1_1_intersection.html)[] | *intersectionInfos*, | |  |  | int | *entityCount*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *worldMouseNear*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *worldMouseFar*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *terrainIntersectionPoint*, | |  |  | ref [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) | *hoveredVisual*, | |  |  | ref [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) | *selectedVisual* ) | | virtual |

Reimplemented from [SandBox.View.Map.CampaignEntityVisualComponent](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#ad01384ad8bee563491f68e95f8518fa9).

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_mobile_party_visual_manager.html#af0e159a0399618ae7d01de97328b17b5)GetVisualOfEntity()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html)< [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > SandBox.View.Map.Managers.MobilePartyVisualManager.GetVisualOfEntity | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *partyBase* | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_mobile_party_visual_manager.html#a1d074e7a950b2e46b6cc631824f07192)OnFinalize()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.View.Map.Managers.MobilePartyVisualManager.OnFinalize | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Map.CampaignEntityVisualComponent](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#a7b8fff62960f0056f396c1d635e6fc98).

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_mobile_party_visual_manager.html#a7654d8118b95affad5f8fd39a483e132)OnInitialize()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.View.Map.Managers.MobilePartyVisualManager.OnInitialize | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Map.CampaignEntityVisualComponent](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html#ac013367a7fa0746866fa9b43c5591938).

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_mobile_party_visual_manager.html#a60127e4db20cb906f39f994888a4815b)GetPartyVisual()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [MobilePartyVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_mobile_party_visual.html) SandBox.View.Map.Managers.MobilePartyVisualManager.GetPartyVisual | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *partyBase* | ) |  |

Property Documentation
----------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_mobile_party_visual_manager.html#a47751dd739cfed2273f4b2bdaa050e4f)Priority
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int SandBox.View.Map.Managers.MobilePartyVisualManager.Priority | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_mobile_party_visual_manager.html#ac25a609246eb6594608ebdb400aa927c)Current
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MobilePartyVisualManager](class_sand_box_1_1_view_1_1_map_1_1_managers_1_1_mobile_party_visual_manager.html) SandBox.View.Map.Managers.MobilePartyVisualManager.Current | | staticget |

