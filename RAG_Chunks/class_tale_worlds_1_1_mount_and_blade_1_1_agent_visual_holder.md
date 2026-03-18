--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html ---

TaleWorlds.MountAndBlade.AgentVisualHolder Class ReferenceInherits [TaleWorlds.MountAndBlade.IAgentVisual](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [AgentVisualHolder](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#a243e6aa67867de04e5c72dea76d7fdc4) ([MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame, [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) equipment, string name, [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) bodyProperties) |
| void | [SetAction](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#a118bfdf86581c0c5fe6931ad91dccd2e) (in [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) actionName, float startProgress=0.0f, bool forceFaceMorphRestart=true) |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [GetEntity](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#ace63508fa8c964bbc8e098147370ef53) () |
| [MBAgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html) | [GetVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#a53f887f5c8797135b1919d80172d17f0) () |
| void | [SetFrame](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#ad787e30eadd6cac24f017328c5b3fda2) (ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame) |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetFrame](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#ac2af93e062f8e1990e9fed443b1e6cee) () |
| [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | [GetBodyProperties](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#a5837726e451c9bd189d7529005580312) () |
| void | [SetBodyProperties](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#a5207bbbac1b705a8862281b74a06c1e4) ([BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) bodyProperties) |
| bool | [GetIsFemale](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#a52aae3656a4f3ad434b5675eecf4874d) () |
| string | [GetCharacterObjectID](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#ac04c693ab03a58a0672ebe386e6bb49c) () |
| void | [SetCharacterObjectID](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#a8867f76e10ce2c485cfa8b2b815e105e) (string id) |
| [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) | [GetEquipment](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#a0eced4824c43b175b3e9f3b714486696) () |
| void | [RefreshWithNewEquipment](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#a5e9ce6a2c2300597b4611e1fbeb2b0ab) ([Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) equipment) |
| void | [SetClothingColors](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#a93204aaaf0a916966a8701e6775af985) (uint color1, uint color2) |
| void | [GetClothingColors](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#a8acdea400a5a86c6c2f70c3795f65ac8) (out uint color1, out uint color2) |
| [AgentVisualsData](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visuals_data.html) | [GetCopyAgentVisualsData](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#a041373c84a5bf9529adf5ac63bd35e9b) () |
| void | [Refresh](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#a577d6b0c9c48a8394b7f82d30af33916) (bool needBatchedVersionForWeaponMeshes, [AgentVisualsData](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visuals_data.html) data, bool forceUseFaceCache=false) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#a243e6aa67867de04e5c72dea76d7fdc4)AgentVisualHolder()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.AgentVisualHolder.AgentVisualHolder | ( | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame*, |
|  |  | [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) | *equipment*, |
|  |  | string | *name*, |
|  |  | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *bodyProperties* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#a118bfdf86581c0c5fe6931ad91dccd2e)SetAction()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.AgentVisualHolder.SetAction | ( | in [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) | *actionName*, |
|  |  | float | *startProgress* = 0::0f, |
|  |  | bool | *forceFaceMorphRestart* = true ) |

Implements [TaleWorlds.MountAndBlade.IAgentVisual](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#a53be6feb924d05907ac8983595db9808).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#ace63508fa8c964bbc8e098147370ef53)GetEntity()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) TaleWorlds.MountAndBlade.AgentVisualHolder.GetEntity | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#a53f887f5c8797135b1919d80172d17f0)GetVisuals()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MBAgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html) TaleWorlds.MountAndBlade.AgentVisualHolder.GetVisuals | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IAgentVisual](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#a3dc96f9313b98cd3a66c6ee5723196ca).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#ad787e30eadd6cac24f017328c5b3fda2)SetFrame()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.AgentVisualHolder.SetFrame | ( | ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#ac2af93e062f8e1990e9fed443b1e6cee)GetFrame()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.AgentVisualHolder.GetFrame | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IAgentVisual](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#ada28b0142843cd3334a6a5c100646e8e).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#a5837726e451c9bd189d7529005580312)GetBodyProperties()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) TaleWorlds.MountAndBlade.AgentVisualHolder.GetBodyProperties | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IAgentVisual](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#a05841f319fca07fdf54fb964cfa820f2).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#a5207bbbac1b705a8862281b74a06c1e4)SetBodyProperties()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.AgentVisualHolder.SetBodyProperties | ( | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *bodyProperties* | ) |  |

Implements [TaleWorlds.MountAndBlade.IAgentVisual](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#a7c44c22632eb0a95bbaca60924a39976).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#a52aae3656a4f3ad434b5675eecf4874d)GetIsFemale()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.AgentVisualHolder.GetIsFemale | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IAgentVisual](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#aababa5a533418a080eecb0648ae5b1b8).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#ac04c693ab03a58a0672ebe386e6bb49c)GetCharacterObjectID()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.MountAndBlade.AgentVisualHolder.GetCharacterObjectID | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IAgentVisual](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#ab1679a02dea200afbce005f1f7265c94).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#a8867f76e10ce2c485cfa8b2b815e105e)SetCharacterObjectID()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.AgentVisualHolder.SetCharacterObjectID | ( | string | *id* | ) |  |

Implements [TaleWorlds.MountAndBlade.IAgentVisual](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#aa4c706230e0bbf41e42af63ef8148a86).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#a0eced4824c43b175b3e9f3b714486696)GetEquipment()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) TaleWorlds.MountAndBlade.AgentVisualHolder.GetEquipment | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IAgentVisual](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#a2796f004e3c9c61242ce9356a380414b).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#a5e9ce6a2c2300597b4611e1fbeb2b0ab)RefreshWithNewEquipment()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.AgentVisualHolder.RefreshWithNewEquipment | ( | [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) | *equipment* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#a93204aaaf0a916966a8701e6775af985)SetClothingColors()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.AgentVisualHolder.SetClothingColors | ( | uint | *color1*, |
|  |  | uint | *color2* ) |

Implements [TaleWorlds.MountAndBlade.IAgentVisual](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#a944ac287409d2dfe79b277fce2180f54).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#a8acdea400a5a86c6c2f70c3795f65ac8)GetClothingColors()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.AgentVisualHolder.GetClothingColors | ( | out uint | *color1*, |
|  |  | out uint | *color2* ) |

Implements [TaleWorlds.MountAndBlade.IAgentVisual](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#aab9c3763b85e033039aa4d068ff4c924).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#a041373c84a5bf9529adf5ac63bd35e9b)GetCopyAgentVisualsData()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [AgentVisualsData](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visuals_data.html) TaleWorlds.MountAndBlade.AgentVisualHolder.GetCopyAgentVisualsData | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IAgentVisual](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#ac6d319c39c78a3e9443b5a6cdf48de62).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#a577d6b0c9c48a8394b7f82d30af33916)Refresh()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.AgentVisualHolder.Refresh | ( | bool | *needBatchedVersionForWeaponMeshes*, |
|  |  | [AgentVisualsData](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visuals_data.html) | *data*, |
|  |  | bool | *forceUseFaceCache* = false ) |

Implements [TaleWorlds.MountAndBlade.IAgentVisual](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#a2efafa0263fecd5d87c5f33ae286ff46).

