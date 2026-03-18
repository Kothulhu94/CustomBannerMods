--- SOURCE: interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_animation_state.html ---

TaleWorlds.GauntletUI.IBrushAnimationState Interface ReferenceInherited by [TaleWorlds.GauntletUI.BrushLayerState](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html), and [TaleWorlds.GauntletUI.BrushState](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [FillFrom](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_animation_state.html#a720cf83c62264c3ff5fa2b7d4f4650ba) ([IDataSource](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_data_source.html) source) |
| void | [LerpFrom](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_animation_state.html#a1c83538ca5ccaa62f3cbd3bde78d2a72) ([IBrushAnimationState](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_animation_state.html) start, [IDataSource](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_data_source.html) end, float ratio) |
| float | [GetValueAsFloat](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_animation_state.html#abaa8ebf4113af7a12a9e6224ee8fcb01) ([BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) propertyType) |
| [Color](struct_tale_worlds_1_1_library_1_1_color.html) | [GetValueAsColor](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_animation_state.html#a7ae21d40e4e36e537583e5fd00796cfa) ([BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) propertyType) |
| [Sprite](class_tale_worlds_1_1_two_dimension_1_1_sprite.html) | [GetValueAsSprite](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_animation_state.html#ac7aa0bd3603ccb7b85b2e9e8548ce657) ([BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) propertyType) |
| void | [SetValueAsFloat](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_animation_state.html#a7779cdf9e04f392906a995102648686c) ([BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) propertyType, float value) |
| void | [SetValueAsColor](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_animation_state.html#ab46f050b414ed0c99078530307190619) ([BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) propertyType, in [Color](struct_tale_worlds_1_1_library_1_1_color.html) value) |
| void | [SetValueAsSprite](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_animation_state.html#a890630c8d38bac50dd2d9336366e3944) ([BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) propertyType, [Sprite](class_tale_worlds_1_1_two_dimension_1_1_sprite.html) value) |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_animation_state.html#a720cf83c62264c3ff5fa2b7d4f4650ba)FillFrom()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.IBrushAnimationState.FillFrom | ( | [IDataSource](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_data_source.html) | *source* | ) |  |

Implemented in [TaleWorlds.GauntletUI.BrushLayerState](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#af61955222a1eccffe1a5e53204a1b792), and [TaleWorlds.GauntletUI.BrushState](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#ab6b92a7e0001f4a63a11aaf513255004).

[◆](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_animation_state.html#a1c83538ca5ccaa62f3cbd3bde78d2a72)LerpFrom()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.IBrushAnimationState.LerpFrom | ( | [IBrushAnimationState](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_animation_state.html) | *start*, |
|  |  | [IDataSource](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_data_source.html) | *end*, |
|  |  | float | *ratio* ) |

Implemented in [TaleWorlds.GauntletUI.BrushLayerState](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#ab2dc9fe407d5724cfcdff67b7d7d92e3), and [TaleWorlds.GauntletUI.BrushState](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#a40358124ba29f94335286e06aa48fe8b).

[◆](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_animation_state.html#abaa8ebf4113af7a12a9e6224ee8fcb01)GetValueAsFloat()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.GauntletUI.IBrushAnimationState.GetValueAsFloat | ( | [BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) | *propertyType* | ) |  |

Implemented in [TaleWorlds.GauntletUI.BrushLayerState](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#a28ab54e10ef444f9a591bff8bcbfce40), and [TaleWorlds.GauntletUI.BrushState](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#ad141866901b9371069d57b5f886ee060).

[◆](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_animation_state.html#a7ae21d40e4e36e537583e5fd00796cfa)GetValueAsColor()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Color](struct_tale_worlds_1_1_library_1_1_color.html) TaleWorlds.GauntletUI.IBrushAnimationState.GetValueAsColor | ( | [BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) | *propertyType* | ) |  |

Implemented in [TaleWorlds.GauntletUI.BrushLayerState](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#a7f2d51f2616df1bbb4b12b66bbd0a26e), and [TaleWorlds.GauntletUI.BrushState](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#ae36fc0da57c76c4713cbc43d9e558869).

[◆](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_animation_state.html#ac7aa0bd3603ccb7b85b2e9e8548ce657)GetValueAsSprite()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Sprite](class_tale_worlds_1_1_two_dimension_1_1_sprite.html) TaleWorlds.GauntletUI.IBrushAnimationState.GetValueAsSprite | ( | [BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) | *propertyType* | ) |  |

Implemented in [TaleWorlds.GauntletUI.BrushLayerState](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#ac8b74c0b6aa38c0ad1a85a6024f13f41), and [TaleWorlds.GauntletUI.BrushState](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#ae273dfaeff2136c1cab7598076c14fdc).

[◆](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_animation_state.html#a7779cdf9e04f392906a995102648686c)SetValueAsFloat()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.IBrushAnimationState.SetValueAsFloat | ( | [BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) | *propertyType*, |
|  |  | float | *value* ) |

Implemented in [TaleWorlds.GauntletUI.BrushLayerState](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#a7cfb07975cbcd99cf65bdec159c928f8), and [TaleWorlds.GauntletUI.BrushState](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#ab89e26ce5c1d6c57121136c352d85372).

[◆](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_animation_state.html#ab46f050b414ed0c99078530307190619)SetValueAsColor()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.IBrushAnimationState.SetValueAsColor | ( | [BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) | *propertyType*, |
|  |  | in [Color](struct_tale_worlds_1_1_library_1_1_color.html) | *value* ) |

Implemented in [TaleWorlds.GauntletUI.BrushLayerState](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#ae62cc3804283dcda447bf5bb8337cfe1), and [TaleWorlds.GauntletUI.BrushState](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#a7f9c2399d10ed578c058b7758c5305d2).

[◆](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_animation_state.html#a890630c8d38bac50dd2d9336366e3944)SetValueAsSprite()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.IBrushAnimationState.SetValueAsSprite | ( | [BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) | *propertyType*, |
|  |  | [Sprite](class_tale_worlds_1_1_two_dimension_1_1_sprite.html) | *value* ) |

Implemented in [TaleWorlds.GauntletUI.BrushLayerState](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer_state.html#a4ae7abbe991f7391ccc9fd98b1187ab0), and [TaleWorlds.GauntletUI.BrushState](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#a7472fa9bba47faeace037fe8d3659c1f).

