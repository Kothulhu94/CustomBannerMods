--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html ---

TaleWorlds.MountAndBlade.View.AgentVisuals Class ReferenceInherits [TaleWorlds.MountAndBlade.IAgentVisual](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| [MBAgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html) | [GetVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a0274e900e4fd7bb19b446bb47ea42819) () |
| void | [Reset](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a8e70160e7cd2e650a7b6fcb6a15214e8) () |
| void | [ResetNextFrame](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a5de969535675605b7f14e9c6a0bfa515) () |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetFrame](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a42827112b8a6def93e6bfd9013dcc5a2) () |
| [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | [GetBodyProperties](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a83b2f7cd53c18154629fbab4cf4a7b8c) () |
| void | [SetBodyProperties](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a78dd68dfe1f4dccd03202fb0a69fe403) ([BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) bodyProperties) |
| bool | [GetIsFemale](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a90c2d3f67cad28939ccc7fd6d0d85472) () |
| string | [GetCharacterObjectID](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#adee5059d8a9fbf3c0ec98c181594ff3d) () |
| void | [SetCharacterObjectID](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a35224394ab5cc405d70af2f0ce684fc9) (string id) |
| [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) | [GetEquipment](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#ade9161738ae466ed1917caca69ed8112) () |
| [AgentVisualsData](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visuals_data.html) | [GetCopyAgentVisualsData](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a79244819afd8e0e3e7a3eeeba21ae979) () |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [GetEntity](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a6a4499aac7488d42feed787304d213a4) () |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | [GetWeakEntity](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#ae080635b2f6fc7b89316861f6dfac22a) () |
| void | [SetVisible](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a9e0cb72db3b4d70ccc743cb060803bd9) (bool value) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetGlobalStableEyePoint](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#ac8d46c396ff9800af7da08f9d6facaff) (bool isHumanoid) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetGlobalStableNeckPoint](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#aaa370cd69127a13d944c6f2ec1614f3f) (bool isHumanoid) |
| [CompositeComponent](class_tale_worlds_1_1_engine_1_1_composite_component.html) | [AddPrefabToAgentVisualBoneByBoneType](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#afcf2662f104bcc65c47a076c7899cc23) (string prefabName, [HumanBone](namespace_tale_worlds_1_1_core.html#a47efca28876c843963d0ab7136b2bfb0) boneType) |
| [CompositeComponent](class_tale_worlds_1_1_engine_1_1_composite_component.html) | [AddPrefabToAgentVisualBoneByRealBoneIndex](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a62d25f15924ff99706daec71f9dbbdfd) (string prefabName, sbyte realBoneIndex) |
| void | [SetAgentLodZeroOrMax](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#ae0b830ae6a9b4845209c2ba89ed92f4e) (bool value) |
| float | [GetScale](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a822e81666b6dddb3710479c4e5793746) () |
| void | [SetAction](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a4fa38c7fba2bd9f7ad01afb711fef2bb) (in [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) actionIndex, float startProgress=0.0f, bool forceFaceMorphRestart=true) |
| bool | [DoesActionContinueWithCurrentAction](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a28109e7a3cc332d5bc8f5ba319352c5b) (in [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) actionIndex) |
| float | [GetAnimationParameterAtChannel](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a7e8a46d2712fba09b1dbf1996e9bf26b) (int channelIndex) |
| void | [Refresh](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a93d02d1569bba4caa0adc915d8e9a072) (bool needBatchedVersionForWeaponMeshes, [AgentVisualsData](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visuals_data.html) data, bool forceUseFaceCache=false) |
| void | [SetClothWindToWeaponAtIndex](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a81c9c5c548f5bd78f0326cc8c0bd800d) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) localWindVector, bool isLocal, [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) weaponIndex) |
| void | [TickVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#acc58eaf13d7743deb0edefeaf176361e) () |
| void | [Tick](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a328d0441375f20d303ca45d336891753) (AgentVisuals parentAgentVisuals, float dt, bool isEntityMoving=false, float speed=0.0f) |
| void | [SetFaceGenerationParams](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a3afcf291ff71cd34caf70e65ef9d68ab) ([FaceGenerationParams](struct_tale_worlds_1_1_mount_and_blade_1_1_face_generation_params.html) faceGenerationParams) |
| void | [SetVoiceDefinitionIndex](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a5b2a9290169650cad5d2fef58eb7af76) (int voiceDefinitionIndex, float voicePitch) |
| void | [StartRhubarbRecord](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#ab0ecb4ec6dabea8c519f57621eff983a) (string path, int soundId) |
|  | Works only for humanoid animation systems. |
| void | [SetAgentLodZeroOrMaxExternal](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a662680f2e42eae6e6960afd1b7054f3e) (bool makeZero) |
| void | [SetAgentLocalSpeed](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#affd2032e0a7064377d0cc629190b8e52) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) speed) |
| void | [SetLookDirection](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#ab268576c79acdb6aa5c923ac06704ec1) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) direction) |
| void | [AddArmorMultiMeshesToAgentEntity](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#ad22c18575005054ddca1a3b84282fc0e) (uint teamColor1, uint teamColor2) |
| void | [MakeRandomVoiceForFacegen](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#ace4787ad2cea69bddaff86623f1bfc88) () |
| void | [SetClothingColors](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a121efd87ef031552ad63cb25a21e6ce2) (uint color1, uint color2) |
| void | [GetClothingColors](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a46621e154aaf05581dc01c58a2d691c3) (out uint color1, out uint color2) |
| void | [SetEntity](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a43065bd0f323b02a908f7bd1c5c63e50) ([GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) entity) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static AgentVisuals | [Create](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#aef87dd54055414411bfeb7dd5ae926ca) ([AgentVisualsData](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visuals_data.html) data, string name, bool isRandomProgress, bool needBatchedVersionForWeaponMeshes, bool forceUseFaceCache) |
| static float | [GetRandomGlossFactor](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a6dfbbad1747da9b2c6ab01de5ba595fd) (Random randomGenerator) |
| static void | [GetRandomClothingColors](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a4ccd38eabf75da7476fc3c5eab6a7e29) (int seed, [Color](struct_tale_worlds_1_1_library_1_1_color.html) inputColor1, [Color](struct_tale_worlds_1_1_library_1_1_color.html) inputColor2, out [Color](struct_tale_worlds_1_1_library_1_1_color.html) color1, out [Color](struct_tale_worlds_1_1_library_1_1_color.html) color2) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const float | [RandomGlossinessRange](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#adc82b6d7a2ee4607b60649f6506008e8) = 0.05f |
| const float | [RandomClothingColor1HueRange](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a790286d92c74ad123c94cc9d4994c4ef) = 4 |
| const float | [RandomClothingColor1SaturationRange](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a437e088e58033b77541a2c7082ec819b) = 0.2f |
| const float | [RandomClothingColor1BrightnessRange](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a5f246ad8c03c091ffe77dddbf151879b) = 0.2f |
| const float | [RandomClothingColor2HueRange](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a605d74a174a4d6ac668d96a6e2e84611) = 8 |
| const float | [RandomClothingColor2SaturationRange](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#ae9bdd2901eaa1fef33f7be429a266dc0) = 0.5f |
| const float | [RandomClothingColor2BrightnessRange](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#abec18cc64a1efaa17b9296df7fa16f78) = 0.3f |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsFemale](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a97f2bea87bb10c7be39eb1bc35c3aff4) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a0274e900e4fd7bb19b446bb47ea42819)GetVisuals()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MBAgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html) TaleWorlds.MountAndBlade.View.AgentVisuals.GetVisuals | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IAgentVisual](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#a3dc96f9313b98cd3a66c6ee5723196ca).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a8e70160e7cd2e650a7b6fcb6a15214e8)Reset()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.AgentVisuals.Reset | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a5de969535675605b7f14e9c6a0bfa515)ResetNextFrame()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.AgentVisuals.ResetNextFrame | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a42827112b8a6def93e6bfd9013dcc5a2)GetFrame()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.View.AgentVisuals.GetFrame | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IAgentVisual](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#ada28b0142843cd3334a6a5c100646e8e).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a83b2f7cd53c18154629fbab4cf4a7b8c)GetBodyProperties()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) TaleWorlds.MountAndBlade.View.AgentVisuals.GetBodyProperties | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IAgentVisual](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#a05841f319fca07fdf54fb964cfa820f2).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a78dd68dfe1f4dccd03202fb0a69fe403)SetBodyProperties()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.AgentVisuals.SetBodyProperties | ( | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *bodyProperties* | ) |  |

Implements [TaleWorlds.MountAndBlade.IAgentVisual](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#a7c44c22632eb0a95bbaca60924a39976).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a90c2d3f67cad28939ccc7fd6d0d85472)GetIsFemale()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.View.AgentVisuals.GetIsFemale | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IAgentVisual](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#aababa5a533418a080eecb0648ae5b1b8).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#adee5059d8a9fbf3c0ec98c181594ff3d)GetCharacterObjectID()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.MountAndBlade.View.AgentVisuals.GetCharacterObjectID | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IAgentVisual](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#ab1679a02dea200afbce005f1f7265c94).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a35224394ab5cc405d70af2f0ce684fc9)SetCharacterObjectID()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.AgentVisuals.SetCharacterObjectID | ( | string | *id* | ) |  |

Implements [TaleWorlds.MountAndBlade.IAgentVisual](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#aa4c706230e0bbf41e42af63ef8148a86).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#ade9161738ae466ed1917caca69ed8112)GetEquipment()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) TaleWorlds.MountAndBlade.View.AgentVisuals.GetEquipment | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IAgentVisual](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#a2796f004e3c9c61242ce9356a380414b).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a79244819afd8e0e3e7a3eeeba21ae979)GetCopyAgentVisualsData()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [AgentVisualsData](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visuals_data.html) TaleWorlds.MountAndBlade.View.AgentVisuals.GetCopyAgentVisualsData | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IAgentVisual](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#ac6d319c39c78a3e9443b5a6cdf48de62).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a6a4499aac7488d42feed787304d213a4)GetEntity()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) TaleWorlds.MountAndBlade.View.AgentVisuals.GetEntity | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#ae080635b2f6fc7b89316861f6dfac22a)GetWeakEntity()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) TaleWorlds.MountAndBlade.View.AgentVisuals.GetWeakEntity | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a9e0cb72db3b4d70ccc743cb060803bd9)SetVisible()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.AgentVisuals.SetVisible | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#ac8d46c396ff9800af7da08f9d6facaff)GetGlobalStableEyePoint()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.View.AgentVisuals.GetGlobalStableEyePoint | ( | bool | *isHumanoid* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#aaa370cd69127a13d944c6f2ec1614f3f)GetGlobalStableNeckPoint()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.View.AgentVisuals.GetGlobalStableNeckPoint | ( | bool | *isHumanoid* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#afcf2662f104bcc65c47a076c7899cc23)AddPrefabToAgentVisualBoneByBoneType()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [CompositeComponent](class_tale_worlds_1_1_engine_1_1_composite_component.html) TaleWorlds.MountAndBlade.View.AgentVisuals.AddPrefabToAgentVisualBoneByBoneType | ( | string | *prefabName*, |
|  |  | [HumanBone](namespace_tale_worlds_1_1_core.html#a47efca28876c843963d0ab7136b2bfb0) | *boneType* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a62d25f15924ff99706daec71f9dbbdfd)AddPrefabToAgentVisualBoneByRealBoneIndex()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [CompositeComponent](class_tale_worlds_1_1_engine_1_1_composite_component.html) TaleWorlds.MountAndBlade.View.AgentVisuals.AddPrefabToAgentVisualBoneByRealBoneIndex | ( | string | *prefabName*, |
|  |  | sbyte | *realBoneIndex* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#ae0b830ae6a9b4845209c2ba89ed92f4e)SetAgentLodZeroOrMax()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.AgentVisuals.SetAgentLodZeroOrMax | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a822e81666b6dddb3710479c4e5793746)GetScale()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.View.AgentVisuals.GetScale | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a4fa38c7fba2bd9f7ad01afb711fef2bb)SetAction()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.AgentVisuals.SetAction | ( | in [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) | *actionIndex*, |
|  |  | float | *startProgress* = 0::0f, |
|  |  | bool | *forceFaceMorphRestart* = true ) |

Implements [TaleWorlds.MountAndBlade.IAgentVisual](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#a53be6feb924d05907ac8983595db9808).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a28109e7a3cc332d5bc8f5ba319352c5b)DoesActionContinueWithCurrentAction()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.View.AgentVisuals.DoesActionContinueWithCurrentAction | ( | in [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) | *actionIndex* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a7e8a46d2712fba09b1dbf1996e9bf26b)GetAnimationParameterAtChannel()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.View.AgentVisuals.GetAnimationParameterAtChannel | ( | int | *channelIndex* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a93d02d1569bba4caa0adc915d8e9a072)Refresh()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.AgentVisuals.Refresh | ( | bool | *needBatchedVersionForWeaponMeshes*, |
|  |  | [AgentVisualsData](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visuals_data.html) | *data*, |
|  |  | bool | *forceUseFaceCache* = false ) |

Implements [TaleWorlds.MountAndBlade.IAgentVisual](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#a2efafa0263fecd5d87c5f33ae286ff46).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a81c9c5c548f5bd78f0326cc8c0bd800d)SetClothWindToWeaponAtIndex()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.AgentVisuals.SetClothWindToWeaponAtIndex | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *localWindVector*, |
|  |  | bool | *isLocal*, |
|  |  | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *weaponIndex* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#acc58eaf13d7743deb0edefeaf176361e)TickVisuals()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.AgentVisuals.TickVisuals | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a328d0441375f20d303ca45d336891753)Tick()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.AgentVisuals.Tick | ( | AgentVisuals | *parentAgentVisuals*, |
|  |  | float | *dt*, |
|  |  | bool | *isEntityMoving* = false, |
|  |  | float | *speed* = 0::0f ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#aef87dd54055414411bfeb7dd5ae926ca)Create()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | AgentVisuals TaleWorlds.MountAndBlade.View.AgentVisuals.Create | ( | [AgentVisualsData](class_tale_worlds_1_1_mount_and_blade_1_1_agent_visuals_data.html) | *data*, | |  |  | string | *name*, | |  |  | bool | *isRandomProgress*, | |  |  | bool | *needBatchedVersionForWeaponMeshes*, | |  |  | bool | *forceUseFaceCache* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a6dfbbad1747da9b2c6ab01de5ba595fd)GetRandomGlossFactor()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.View.AgentVisuals.GetRandomGlossFactor | ( | Random | *randomGenerator* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a4ccd38eabf75da7476fc3c5eab6a7e29)GetRandomClothingColors()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.View.AgentVisuals.GetRandomClothingColors | ( | int | *seed*, | |  |  | [Color](struct_tale_worlds_1_1_library_1_1_color.html) | *inputColor1*, | |  |  | [Color](struct_tale_worlds_1_1_library_1_1_color.html) | *inputColor2*, | |  |  | out [Color](struct_tale_worlds_1_1_library_1_1_color.html) | *color1*, | |  |  | out [Color](struct_tale_worlds_1_1_library_1_1_color.html) | *color2* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a3afcf291ff71cd34caf70e65ef9d68ab)SetFaceGenerationParams()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.AgentVisuals.SetFaceGenerationParams | ( | [FaceGenerationParams](struct_tale_worlds_1_1_mount_and_blade_1_1_face_generation_params.html) | *faceGenerationParams* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a5b2a9290169650cad5d2fef58eb7af76)SetVoiceDefinitionIndex()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.AgentVisuals.SetVoiceDefinitionIndex | ( | int | *voiceDefinitionIndex*, |
|  |  | float | *voicePitch* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#ab0ecb4ec6dabea8c519f57621eff983a)StartRhubarbRecord()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.AgentVisuals.StartRhubarbRecord | ( | string | *path*, |
|  |  | int | *soundId* ) |

Parameters
:   |  |  |
    | --- | --- |
    | path |  |
    | soundId |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a662680f2e42eae6e6960afd1b7054f3e)SetAgentLodZeroOrMaxExternal()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.AgentVisuals.SetAgentLodZeroOrMaxExternal | ( | bool | *makeZero* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#affd2032e0a7064377d0cc629190b8e52)SetAgentLocalSpeed()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.AgentVisuals.SetAgentLocalSpeed | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *speed* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#ab268576c79acdb6aa5c923ac06704ec1)SetLookDirection()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.AgentVisuals.SetLookDirection | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *direction* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#ad22c18575005054ddca1a3b84282fc0e)AddArmorMultiMeshesToAgentEntity()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.AgentVisuals.AddArmorMultiMeshesToAgentEntity | ( | uint | *teamColor1*, |
|  |  | uint | *teamColor2* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#ace4787ad2cea69bddaff86623f1bfc88)MakeRandomVoiceForFacegen()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.AgentVisuals.MakeRandomVoiceForFacegen | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a121efd87ef031552ad63cb25a21e6ce2)SetClothingColors()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.AgentVisuals.SetClothingColors | ( | uint | *color1*, |
|  |  | uint | *color2* ) |

Implements [TaleWorlds.MountAndBlade.IAgentVisual](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#a944ac287409d2dfe79b277fce2180f54).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a46621e154aaf05581dc01c58a2d691c3)GetClothingColors()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.AgentVisuals.GetClothingColors | ( | out uint | *color1*, |
|  |  | out uint | *color2* ) |

Implements [TaleWorlds.MountAndBlade.IAgentVisual](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html#aab9c3763b85e033039aa4d068ff4c924).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a43065bd0f323b02a908f7bd1c5c63e50)SetEntity()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.AgentVisuals.SetEntity | ( | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *entity* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#adc82b6d7a2ee4607b60649f6506008e8)RandomGlossinessRange
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.View.AgentVisuals.RandomGlossinessRange = 0.05f | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a790286d92c74ad123c94cc9d4994c4ef)RandomClothingColor1HueRange
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.View.AgentVisuals.RandomClothingColor1HueRange = 4 | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a437e088e58033b77541a2c7082ec819b)RandomClothingColor1SaturationRange
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.View.AgentVisuals.RandomClothingColor1SaturationRange = 0.2f | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a5f246ad8c03c091ffe77dddbf151879b)RandomClothingColor1BrightnessRange
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.View.AgentVisuals.RandomClothingColor1BrightnessRange = 0.2f | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a605d74a174a4d6ac668d96a6e2e84611)RandomClothingColor2HueRange
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.View.AgentVisuals.RandomClothingColor2HueRange = 8 | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#ae9bdd2901eaa1fef33f7be429a266dc0)RandomClothingColor2SaturationRange
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.View.AgentVisuals.RandomClothingColor2SaturationRange = 0.5f | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#abec18cc64a1efaa17b9296df7fa16f78)RandomClothingColor2BrightnessRange
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.View.AgentVisuals.RandomClothingColor2BrightnessRange = 0.3f | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html#a97f2bea87bb10c7be39eb1bc35c3aff4)IsFemale
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.View.AgentVisuals.IsFemale | | get |

