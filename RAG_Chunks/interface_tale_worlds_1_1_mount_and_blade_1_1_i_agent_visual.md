--- SOURCE: interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html ---

TaleWorlds.MountAndBlade.IAgentVisual Interface ReferenceInherited by [TaleWorlds.MountAndBlade.AgentVisualHolder](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html), and [TaleWorlds.MountAndBlade.View.AgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [SetAction](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#a53be6feb924d05907ac8983595db9808) (in [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) actionName, float startProgress=0.0f, bool forceFaceMorphRestart=true) |
| [MBAgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html) | [GetVisuals](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#a3dc96f9313b98cd3a66c6ee5723196ca) () |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetFrame](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#ada28b0142843cd3334a6a5c100646e8e) () |
| [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | [GetBodyProperties](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#a05841f319fca07fdf54fb964cfa820f2) () |
| void | [SetBodyProperties](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#a7c44c22632eb0a95bbaca60924a39976) ([BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) bodyProperties) |
| bool | [GetIsFemale](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#aababa5a533418a080eecb0648ae5b1b8) () |
| string | [GetCharacterObjectID](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#ab1679a02dea200afbce005f1f7265c94) () |
| void | [SetCharacterObjectID](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#aa4c706230e0bbf41e42af63ef8148a86) (string id) |
| [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) | [GetEquipment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#a2796f004e3c9c61242ce9356a380414b) () |
| void | [SetClothingColors](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#a944ac287409d2dfe79b277fce2180f54) (uint color1, uint color2) |
| void | [GetClothingColors](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#aab9c3763b85e033039aa4d068ff4c924) (out uint color1, out uint color2) |
| [AgentVisualsData](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visuals_data.html) | [GetCopyAgentVisualsData](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#ac6d319c39c78a3e9443b5a6cdf48de62) () |
| void | [Refresh](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#a2efafa0263fecd5d87c5f33ae286ff46) (bool needBatchedVersionForWeaponMeshes, [AgentVisualsData](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visuals_data.html) data, bool forceUseFaceCache=false) |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#a53be6feb924d05907ac8983595db9808)SetAction()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IAgentVisual.SetAction | ( | in [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) | *actionName*, |
|  |  | float | *startProgress* = 0.0f, |
|  |  | bool | *forceFaceMorphRestart* = true ) |

Implemented in [TaleWorlds.MountAndBlade.AgentVisualHolder](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#a118bfdf86581c0c5fe6931ad91dccd2e), and [TaleWorlds.MountAndBlade.View.AgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a4fa38c7fba2bd9f7ad01afb711fef2bb).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#a3dc96f9313b98cd3a66c6ee5723196ca)GetVisuals()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MBAgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html) TaleWorlds.MountAndBlade.IAgentVisual.GetVisuals | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.AgentVisualHolder](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#a53f887f5c8797135b1919d80172d17f0), and [TaleWorlds.MountAndBlade.View.AgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a0274e900e4fd7bb19b446bb47ea42819).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#ada28b0142843cd3334a6a5c100646e8e)GetFrame()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.IAgentVisual.GetFrame | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.AgentVisualHolder](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#ac2af93e062f8e1990e9fed443b1e6cee), and [TaleWorlds.MountAndBlade.View.AgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a42827112b8a6def93e6bfd9013dcc5a2).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#a05841f319fca07fdf54fb964cfa820f2)GetBodyProperties()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) TaleWorlds.MountAndBlade.IAgentVisual.GetBodyProperties | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.AgentVisualHolder](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#a5837726e451c9bd189d7529005580312), and [TaleWorlds.MountAndBlade.View.AgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a83b2f7cd53c18154629fbab4cf4a7b8c).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#a7c44c22632eb0a95bbaca60924a39976)SetBodyProperties()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IAgentVisual.SetBodyProperties | ( | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *bodyProperties* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.AgentVisualHolder](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#a5207bbbac1b705a8862281b74a06c1e4), and [TaleWorlds.MountAndBlade.View.AgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a78dd68dfe1f4dccd03202fb0a69fe403).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#aababa5a533418a080eecb0648ae5b1b8)GetIsFemale()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.IAgentVisual.GetIsFemale | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.AgentVisualHolder](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#a52aae3656a4f3ad434b5675eecf4874d), and [TaleWorlds.MountAndBlade.View.AgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a90c2d3f67cad28939ccc7fd6d0d85472).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#ab1679a02dea200afbce005f1f7265c94)GetCharacterObjectID()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.MountAndBlade.IAgentVisual.GetCharacterObjectID | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.AgentVisualHolder](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#ac04c693ab03a58a0672ebe386e6bb49c), and [TaleWorlds.MountAndBlade.View.AgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#adee5059d8a9fbf3c0ec98c181594ff3d).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#aa4c706230e0bbf41e42af63ef8148a86)SetCharacterObjectID()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IAgentVisual.SetCharacterObjectID | ( | string | *id* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.AgentVisualHolder](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#a8867f76e10ce2c485cfa8b2b815e105e), and [TaleWorlds.MountAndBlade.View.AgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a35224394ab5cc405d70af2f0ce684fc9).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#a2796f004e3c9c61242ce9356a380414b)GetEquipment()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) TaleWorlds.MountAndBlade.IAgentVisual.GetEquipment | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.AgentVisualHolder](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#a0eced4824c43b175b3e9f3b714486696), and [TaleWorlds.MountAndBlade.View.AgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#ade9161738ae466ed1917caca69ed8112).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#a944ac287409d2dfe79b277fce2180f54)SetClothingColors()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IAgentVisual.SetClothingColors | ( | uint | *color1*, |
|  |  | uint | *color2* ) |

Implemented in [TaleWorlds.MountAndBlade.AgentVisualHolder](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#a93204aaaf0a916966a8701e6775af985), and [TaleWorlds.MountAndBlade.View.AgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a121efd87ef031552ad63cb25a21e6ce2).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#aab9c3763b85e033039aa4d068ff4c924)GetClothingColors()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IAgentVisual.GetClothingColors | ( | out uint | *color1*, |
|  |  | out uint | *color2* ) |

Implemented in [TaleWorlds.MountAndBlade.AgentVisualHolder](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#a8acdea400a5a86c6c2f70c3795f65ac8), and [TaleWorlds.MountAndBlade.View.AgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a46621e154aaf05581dc01c58a2d691c3).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#ac6d319c39c78a3e9443b5a6cdf48de62)GetCopyAgentVisualsData()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [AgentVisualsData](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visuals_data.html) TaleWorlds.MountAndBlade.IAgentVisual.GetCopyAgentVisualsData | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.AgentVisualHolder](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#a041373c84a5bf9529adf5ac63bd35e9b), and [TaleWorlds.MountAndBlade.View.AgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a79244819afd8e0e3e7a3eeeba21ae979).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#a2efafa0263fecd5d87c5f33ae286ff46)Refresh()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IAgentVisual.Refresh | ( | bool | *needBatchedVersionForWeaponMeshes*, |
|  |  | [AgentVisualsData](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visuals_data.html) | *data*, |
|  |  | bool | *forceUseFaceCache* = false ) |

Implemented in [TaleWorlds.MountAndBlade.AgentVisualHolder](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visual_holder.html#a577d6b0c9c48a8394b7f82d30af33916), and [TaleWorlds.MountAndBlade.View.AgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a93d02d1569bba4caa0adc915d8e9a072).

