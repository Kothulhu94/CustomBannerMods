--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mount_visual_creator.html ---

TaleWorlds.MountAndBlade.View.MountVisualCreator Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [SetMaterialProperties](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mount_visual_creator.html#a3fbb4e05b88c10e198a45dbd48a727ed) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) mountItem, [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) mountMesh, [MountCreationKey](class_tale_worlds_1_1_core_1_1_mount_creation_key.html) key, ref uint maneMeshMultiplier) |
| static List< [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) > | [AddMountMesh](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mount_visual_creator.html#aebdecbf497ae75570d9e92199e09b515) ([MBAgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html) agentVisual, [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) mountItem, [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) harnessItem, string mountCreationKeyStr, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent=null) |
| static void | [SetHorseColors](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mount_visual_creator.html#ad403b25d168a8435829429c101972ae3) ([MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) horseMesh, [MountCreationKey](class_tale_worlds_1_1_core_1_1_mount_creation_key.html) mountCreationKey) |
| static void | [ClearMountMesh](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mount_visual_creator.html#a75876cb76b9fff95b9aeb403063ab93b) ([GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity) |
| static void | [AddMountMeshToEntity](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mount_visual_creator.html#a55221c3e20dfaa6b33c5caf2325e55aa) ([GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity, [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) mountItem, [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) harnessItem, string mountCreationKeyStr, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent=null) |
| static void | [AddMountMeshToAgentVisual](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mount_visual_creator.html#ad41b20fb208153f4ad72a61467146e1b) ([MBAgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html) agentVisual, [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) mountItem, [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) harnessItem, string mountCreationKeyStr, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent=null) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mount_visual_creator.html#a3fbb4e05b88c10e198a45dbd48a727ed)SetMaterialProperties()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.View.MountVisualCreator.SetMaterialProperties | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *mountItem*, | |  |  | [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | *mountMesh*, | |  |  | [MountCreationKey](class_tale_worlds_1_1_core_1_1_mount_creation_key.html) | *key*, | |  |  | ref uint | *maneMeshMultiplier* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mount_visual_creator.html#aebdecbf497ae75570d9e92199e09b515)AddMountMesh()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | List< [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) > TaleWorlds.MountAndBlade.View.MountVisualCreator.AddMountMesh | ( | [MBAgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html) | *agentVisual*, | |  |  | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *mountItem*, | |  |  | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *harnessItem*, | |  |  | string | *mountCreationKeyStr*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* = null ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mount_visual_creator.html#ad403b25d168a8435829429c101972ae3)SetHorseColors()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.View.MountVisualCreator.SetHorseColors | ( | [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | *horseMesh*, | |  |  | [MountCreationKey](class_tale_worlds_1_1_core_1_1_mount_creation_key.html) | *mountCreationKey* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mount_visual_creator.html#a75876cb76b9fff95b9aeb403063ab93b)ClearMountMesh()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.View.MountVisualCreator.ClearMountMesh | ( | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mount_visual_creator.html#a55221c3e20dfaa6b33c5caf2325e55aa)AddMountMeshToEntity()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.View.MountVisualCreator.AddMountMeshToEntity | ( | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity*, | |  |  | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *mountItem*, | |  |  | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *harnessItem*, | |  |  | string | *mountCreationKeyStr*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* = null ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mount_visual_creator.html#ad41b20fb208153f4ad72a61467146e1b)AddMountMeshToAgentVisual()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.View.MountVisualCreator.AddMountMeshToAgentVisual | ( | [MBAgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html) | *agentVisual*, | |  |  | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *mountItem*, | |  |  | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *harnessItem*, | |  |  | string | *mountCreationKeyStr*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* = null ) | | static |

