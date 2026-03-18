--- SOURCE: class_sand_box_1_1_view_1_1_sand_box_view_visual_manager.html ---

SandBox.View.SandBoxViewVisualManager Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [SandBoxViewVisualManager](class_sand_box_1_1_view_1_1_sand_box_view_visual_manager.html#ae828c157440cdde3b5201e855cbec5a9) () |
| TComponent | [GetEntityComponent< TComponent >](class_sand_box_1_1_view_1_1_sand_box_view_visual_manager.html#a6cdf341106e7569ed54a83a86a849a14) () |
| TComponent | [AddEntityComponent< TComponent >](class_sand_box_1_1_view_1_1_sand_box_view_visual_manager.html#a503a692399bbfca9b9e5de72ca4926cf) () |
| void | [RemoveEntityComponent< TComponent >](class_sand_box_1_1_view_1_1_sand_box_view_visual_manager.html#abf6fb5fe4267934f1a6e4f201b7654bb) () |
| void | [Finalize< TComponent >](class_sand_box_1_1_view_1_1_sand_box_view_visual_manager.html#a70089db672b3d26a50a7c7453d7eb871) (TComponent component) |
| void | [RemoveEntityComponent< TComponent >](class_sand_box_1_1_view_1_1_sand_box_view_visual_manager.html#ae2816dd7421b27b4f073a3e687ca4a13) (TComponent component) |
| List< TComponent > | [GetComponents< TComponent >](class_sand_box_1_1_view_1_1_sand_box_view_visual_manager.html#ab341055db2142a46056bf84e3ce655c6) () |
| MBList< [CampaignEntityVisualComponent](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html) > | [GetComponents](class_sand_box_1_1_view_1_1_sand_box_view_visual_manager.html#a1e5c9f7ceb52dfd0a10f1f5747b5b2cd) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [VisualTick](class_sand_box_1_1_view_1_1_sand_box_view_visual_manager.html#a92ae850210a3a5a121a7051e84ed3cc5) ([MapScreen](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html) screen, float realDt, float dt) |
| static void | [OnTick](class_sand_box_1_1_view_1_1_sand_box_view_visual_manager.html#ad89fddc8b04eeec5ad7d0937b2bf591c) (float realDt, float dt) |
| static void | [ClearVisualMemory](class_sand_box_1_1_view_1_1_sand_box_view_visual_manager.html#a2bed50dbb6df13c46a16186504e8f048) () |
| static void | [OnFrameTick](class_sand_box_1_1_view_1_1_sand_box_view_visual_manager.html#acf9f6327d06222d40d12f35ed3e8fbaf) (float dt) |
| static bool | [OnMouseClick](class_sand_box_1_1_view_1_1_sand_box_view_visual_manager.html#a1590f91fc38615804cda0e6861f05abf) ([MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) visualOfSelectedEntity, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) intersectionPoint, [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) mouseOverFaceIndex, bool isDoubleClick) |
| static void | [OnGameLoadFinished](class_sand_box_1_1_view_1_1_sand_box_view_visual_manager.html#ac539cea66e41c642a2ddf27ea4f98993) () |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_view_1_1_sand_box_view_visual_manager.html#ae828c157440cdde3b5201e855cbec5a9)SandBoxViewVisualManager()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| SandBox.View.SandBoxViewVisualManager.SandBoxViewVisualManager | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_view_1_1_sand_box_view_visual_manager.html#a92ae850210a3a5a121a7051e84ed3cc5)VisualTick()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void SandBox.View.SandBoxViewVisualManager.VisualTick | ( | [MapScreen](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html) | *screen*, | |  |  | float | *realDt*, | |  |  | float | *dt* ) | | static |

[◆](class_sand_box_1_1_view_1_1_sand_box_view_visual_manager.html#ad89fddc8b04eeec5ad7d0937b2bf591c)OnTick()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void SandBox.View.SandBoxViewVisualManager.OnTick | ( | float | *realDt*, | |  |  | float | *dt* ) | | static |

[◆](class_sand_box_1_1_view_1_1_sand_box_view_visual_manager.html#a2bed50dbb6df13c46a16186504e8f048)ClearVisualMemory()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void SandBox.View.SandBoxViewVisualManager.ClearVisualMemory | ( |  | ) |  | | static |

[◆](class_sand_box_1_1_view_1_1_sand_box_view_visual_manager.html#acf9f6327d06222d40d12f35ed3e8fbaf)OnFrameTick()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void SandBox.View.SandBoxViewVisualManager.OnFrameTick | ( | float | *dt* | ) |  | | static |

[◆](class_sand_box_1_1_view_1_1_sand_box_view_visual_manager.html#a1590f91fc38615804cda0e6861f05abf)OnMouseClick()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool SandBox.View.SandBoxViewVisualManager.OnMouseClick | ( | [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) | *visualOfSelectedEntity*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *intersectionPoint*, | |  |  | [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | *mouseOverFaceIndex*, | |  |  | bool | *isDoubleClick* ) | | static |

[◆](class_sand_box_1_1_view_1_1_sand_box_view_visual_manager.html#ac539cea66e41c642a2ddf27ea4f98993)OnGameLoadFinished()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void SandBox.View.SandBoxViewVisualManager.OnGameLoadFinished | ( |  | ) |  | | static |

[◆](class_sand_box_1_1_view_1_1_sand_box_view_visual_manager.html#a6cdf341106e7569ed54a83a86a849a14)GetEntityComponent< TComponent >()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TComponent SandBox.View.SandBoxViewVisualManager.GetEntityComponent< TComponent > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *TComponent* | : | *CampaignEntityVisualComponent* |  |

[◆](class_sand_box_1_1_view_1_1_sand_box_view_visual_manager.html#a503a692399bbfca9b9e5de72ca4926cf)AddEntityComponent< TComponent >()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TComponent SandBox.View.SandBoxViewVisualManager.AddEntityComponent< TComponent > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *TComponent* | : | *CampaignEntityVisualComponent* |  |
    | *TComponent* | : | *new()* |  |

[◆](class_sand_box_1_1_view_1_1_sand_box_view_visual_manager.html#abf6fb5fe4267934f1a6e4f201b7654bb)RemoveEntityComponent< TComponent >() [1/2]
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.View.SandBoxViewVisualManager.RemoveEntityComponent< TComponent > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *TComponent* | : | *CampaignEntityVisualComponent* |  |

[◆](class_sand_box_1_1_view_1_1_sand_box_view_visual_manager.html#a70089db672b3d26a50a7c7453d7eb871)Finalize< TComponent >()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.View.SandBoxViewVisualManager.Finalize< TComponent > | ( | TComponent | *component* | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *TComponent* | : | *CampaignEntityVisualComponent* |  |

[◆](class_sand_box_1_1_view_1_1_sand_box_view_visual_manager.html#ae2816dd7421b27b4f073a3e687ca4a13)RemoveEntityComponent< TComponent >() [2/2]
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.View.SandBoxViewVisualManager.RemoveEntityComponent< TComponent > | ( | TComponent | *component* | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *TComponent* | : | *CampaignEntityVisualComponent* |  |

[◆](class_sand_box_1_1_view_1_1_sand_box_view_visual_manager.html#ab341055db2142a46056bf84e3ce655c6)GetComponents< TComponent >()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| List< TComponent > [SandBox.View.SandBoxViewVisualManager.GetComponents](class_sand_box_1_1_view_1_1_sand_box_view_visual_manager.html#a1e5c9f7ceb52dfd0a10f1f5747b5b2cd)< TComponent > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *TComponent* | : | *CampaignEntityVisualComponent* |  |

[◆](class_sand_box_1_1_view_1_1_sand_box_view_visual_manager.html#a1e5c9f7ceb52dfd0a10f1f5747b5b2cd)GetComponents()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| MBList< [CampaignEntityVisualComponent](class_sand_box_1_1_view_1_1_map_1_1_campaign_entity_visual_component.html) > SandBox.View.SandBoxViewVisualManager.GetComponents | ( |  | ) |  |

