--- SOURCE: struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html ---

TaleWorlds.GauntletUI.BrushLayerState Struct ReferenceInherits [TaleWorlds.GauntletUI.IBrushAnimationState](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_animation_state.html), and [TaleWorlds.GauntletUI.IDataSource](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_data_source.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [FillFrom](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#abffbc42fd653451b30108e7b95edad51) ([IBrushLayerData](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_layer_data.html) styleLayer) |
| void IBrushAnimationState. | [FillFrom](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#af61955222a1eccffe1a5e53204a1b792) ([IDataSource](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_data_source.html) source) |
| void IBrushAnimationState. | [LerpFrom](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#ab2dc9fe407d5724cfcdff67b7d7d92e3) ([IBrushAnimationState](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_animation_state.html) start, [IDataSource](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_data_source.html) end, float ratio) |
| void | [LerpFrom](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#a5801c93568e76b59d4cd594c049ce12a) ([BrushLayerState](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html) start, [IBrushLayerData](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_layer_data.html) end, float ratio) |
| void | [SetValueAsFloat](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#a7cfb07975cbcd99cf65bdec159c928f8) ([BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) propertyType, float value) |
| void | [SetValueAsColor](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#ae62cc3804283dcda447bf5bb8337cfe1) ([BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) propertyType, in [Color](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#a4a6affc8af09f4793d5216848ec79137) value) |
| void | [SetValueAsSprite](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#a4ae7abbe991f7391ccc9fd98b1187ab0) ([BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) propertyType, [Sprite](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#ab86a1692ae4add961860f7cc79e44172) value) |
| float | [GetValueAsFloat](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#a28ab54e10ef444f9a591bff8bcbfce40) ([BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) propertyType) |
| [Color](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#a4a6affc8af09f4793d5216848ec79137) | [GetValueAsColor](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#a7f2d51f2616df1bbb4b12b66bbd0a26e) ([BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) propertyType) |
| [Sprite](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#ab86a1692ae4add961860f7cc79e44172) | [GetValueAsSprite](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#ac8b74c0b6aa38c0ad1a85a6024f13f41) ([BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) propertyType) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [SetValueAsLerpOfValues](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#aaa64f466fe80cb27626db33140d1ae8f) (ref [BrushLayerState](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html) currentState, in [BrushAnimationKeyFrame](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_key_frame.html) startValue, in [BrushAnimationKeyFrame](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_key_frame.html) endValue, [BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) propertyType, float ratio) |

|  |  |
| --- | --- |
| Public Attributes | |
| Color | [Color](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#a4a6affc8af09f4793d5216848ec79137) |
| float | [ColorFactor](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#a1a0168e63d45f1ba8326674703b435b8) |
| float | [AlphaFactor](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#af149e276d3c0e688201b258ce76d604a) |
| float | [HueFactor](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#a4ed3e8a16f73cb2b942a21993c87eb81) |
| float | [SaturationFactor](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#a372b460c233971da97d79a13a81c7d99) |
| float | [ValueFactor](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#a9cdfdfda10bbf27b43729391ace259c9) |
| float | [OverlayXOffset](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#acf14271cc157453ff6971b1e27527ded) |
| float | [OverlayYOffset](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#a89bf1087bfbe090a4da196b4ec92a281) |
| float | [XOffset](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#af2a9eed8aa4091f394801fb1a760d76a) |
| float | [YOffset](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#a43da142c6df9c8b97282056cc2e3b70b) |
| float | [Rotation](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#a096d9a70cf508bfd5ebfba4cb4901ef6) |
| float | [ExtendRight](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#a0556d926d48b1370041b272ed7df71e3) |
| float | [ExtendTop](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#a6dd394b93c8d2fb7097f7e6913667a24) |
| float | [ExtendBottom](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#a7fc5c7e36a7175522434747a3023ffeb) |
| float | [ExtendLeft](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#a8003a998325f700a90913dcc7cbf7694) |
| Sprite | [Sprite](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#ab86a1692ae4add961860f7cc79e44172) |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#abffbc42fd653451b30108e7b95edad51)FillFrom() [1/2]
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.BrushLayerState.FillFrom | ( | [IBrushLayerData](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_layer_data.html) | *styleLayer* | ) |  |

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#af61955222a1eccffe1a5e53204a1b792)FillFrom() [2/2]
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void IBrushAnimationState. TaleWorlds.GauntletUI.BrushLayerState.FillFrom | ( | [IDataSource](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_data_source.html) | *source* | ) |  |

Implements [TaleWorlds.GauntletUI.IBrushAnimationState](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_animation_state.html#a720cf83c62264c3ff5fa2b7d4f4650ba).

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#ab2dc9fe407d5724cfcdff67b7d7d92e3)LerpFrom() [1/2]
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void IBrushAnimationState. TaleWorlds.GauntletUI.BrushLayerState.LerpFrom | ( | [IBrushAnimationState](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_animation_state.html) | *start*, |
|  |  | [IDataSource](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_data_source.html) | *end*, |
|  |  | float | *ratio* ) |

Implements [TaleWorlds.GauntletUI.IBrushAnimationState](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_animation_state.html#a1c83538ca5ccaa62f3cbd3bde78d2a72).

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#a5801c93568e76b59d4cd594c049ce12a)LerpFrom() [2/2]
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.BrushLayerState.LerpFrom | ( | [BrushLayerState](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html) | *start*, |
|  |  | [IBrushLayerData](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_layer_data.html) | *end*, |
|  |  | float | *ratio* ) |

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#a7cfb07975cbcd99cf65bdec159c928f8)SetValueAsFloat()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.BrushLayerState.SetValueAsFloat | ( | [BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) | *propertyType*, |
|  |  | float | *value* ) |

Implements [TaleWorlds.GauntletUI.IBrushAnimationState](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_animation_state.html#a7779cdf9e04f392906a995102648686c).

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#ae62cc3804283dcda447bf5bb8337cfe1)SetValueAsColor()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.BrushLayerState.SetValueAsColor | ( | [BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) | *propertyType*, |
|  |  | in [Color](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#a4a6affc8af09f4793d5216848ec79137) | *value* ) |

Implements [TaleWorlds.GauntletUI.IBrushAnimationState](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_animation_state.html#ab46f050b414ed0c99078530307190619).

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#a4ae7abbe991f7391ccc9fd98b1187ab0)SetValueAsSprite()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.BrushLayerState.SetValueAsSprite | ( | [BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) | *propertyType*, |
|  |  | [Sprite](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#ab86a1692ae4add961860f7cc79e44172) | *value* ) |

Implements [TaleWorlds.GauntletUI.IBrushAnimationState](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_animation_state.html#a890630c8d38bac50dd2d9336366e3944).

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#a28ab54e10ef444f9a591bff8bcbfce40)GetValueAsFloat()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.GauntletUI.BrushLayerState.GetValueAsFloat | ( | [BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) | *propertyType* | ) |  |

Implements [TaleWorlds.GauntletUI.IBrushAnimationState](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_animation_state.html#abaa8ebf4113af7a12a9e6224ee8fcb01).

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#a7f2d51f2616df1bbb4b12b66bbd0a26e)GetValueAsColor()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Color](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#a4a6affc8af09f4793d5216848ec79137) TaleWorlds.GauntletUI.BrushLayerState.GetValueAsColor | ( | [BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) | *propertyType* | ) |  |

Implements [TaleWorlds.GauntletUI.IBrushAnimationState](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_animation_state.html#a7ae21d40e4e36e537583e5fd00796cfa).

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#ac8b74c0b6aa38c0ad1a85a6024f13f41)GetValueAsSprite()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Sprite](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#ab86a1692ae4add961860f7cc79e44172) TaleWorlds.GauntletUI.BrushLayerState.GetValueAsSprite | ( | [BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) | *propertyType* | ) |  |

Implements [TaleWorlds.GauntletUI.IBrushAnimationState](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_animation_state.html#ac7aa0bd3603ccb7b85b2e9e8548ce657).

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#aaa64f466fe80cb27626db33140d1ae8f)SetValueAsLerpOfValues()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.GauntletUI.BrushLayerState.SetValueAsLerpOfValues | ( | ref [BrushLayerState](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html) | *currentState*, | |  |  | in [BrushAnimationKeyFrame](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_key_frame.html) | *startValue*, | |  |  | in [BrushAnimationKeyFrame](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_key_frame.html) | *endValue*, | |  |  | [BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) | *propertyType*, | |  |  | float | *ratio* ) | | static |

Member Data Documentation
-------------------------

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#a4a6affc8af09f4793d5216848ec79137)Color
----------------------------------------------------------------------------------------------------------

|  |
| --- |
| Color TaleWorlds.GauntletUI.BrushLayerState.Color |

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#a1a0168e63d45f1ba8326674703b435b8)ColorFactor
----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.GauntletUI.BrushLayerState.ColorFactor |

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#af149e276d3c0e688201b258ce76d604a)AlphaFactor
----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.GauntletUI.BrushLayerState.AlphaFactor |

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#a4ed3e8a16f73cb2b942a21993c87eb81)HueFactor
--------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.GauntletUI.BrushLayerState.HueFactor |

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#a372b460c233971da97d79a13a81c7d99)SaturationFactor
---------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.GauntletUI.BrushLayerState.SaturationFactor |

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#a9cdfdfda10bbf27b43729391ace259c9)ValueFactor
----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.GauntletUI.BrushLayerState.ValueFactor |

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#acf14271cc157453ff6971b1e27527ded)OverlayXOffset
-------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.GauntletUI.BrushLayerState.OverlayXOffset |

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#a89bf1087bfbe090a4da196b4ec92a281)OverlayYOffset
-------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.GauntletUI.BrushLayerState.OverlayYOffset |

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#af2a9eed8aa4091f394801fb1a760d76a)XOffset
------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.GauntletUI.BrushLayerState.XOffset |

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#a43da142c6df9c8b97282056cc2e3b70b)YOffset
------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.GauntletUI.BrushLayerState.YOffset |

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#a096d9a70cf508bfd5ebfba4cb4901ef6)Rotation
-------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.GauntletUI.BrushLayerState.Rotation |

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#a0556d926d48b1370041b272ed7df71e3)ExtendRight
----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.GauntletUI.BrushLayerState.ExtendRight |

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#a6dd394b93c8d2fb7097f7e6913667a24)ExtendTop
--------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.GauntletUI.BrushLayerState.ExtendTop |

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#a7fc5c7e36a7175522434747a3023ffeb)ExtendBottom
-----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.GauntletUI.BrushLayerState.ExtendBottom |

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#a8003a998325f700a90913dcc7cbf7694)ExtendLeft
---------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.GauntletUI.BrushLayerState.ExtendLeft |

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#ab86a1692ae4add961860f7cc79e44172)Sprite
-----------------------------------------------------------------------------------------------------------

|  |
| --- |
| Sprite TaleWorlds.GauntletUI.BrushLayerState.Sprite |

