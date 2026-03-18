--- SOURCE: struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html ---

TaleWorlds.GauntletUI.BrushState Struct ReferenceInherits [TaleWorlds.GauntletUI.IBrushAnimationState](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_animation_state.html), and [TaleWorlds.GauntletUI.IDataSource](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_data_source.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [FillFrom](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#ab178db26fa5698d90d58e8625151d367) ([Style](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html) style) |
| void | [LerpFrom](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#af9357ee21348af1fd35e5ce0f18496d5) ([BrushState](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html) start, [Style](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html) end, float ratio) |
| void IBrushAnimationState. | [FillFrom](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#ab6b92a7e0001f4a63a11aaf513255004) ([IDataSource](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_data_source.html) source) |
| void IBrushAnimationState. | [LerpFrom](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#a40358124ba29f94335286e06aa48fe8b) ([IBrushAnimationState](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_animation_state.html) start, [IDataSource](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_data_source.html) end, float ratio) |
| float | [GetValueAsFloat](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#ad141866901b9371069d57b5f886ee060) ([BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) propertyType) |
| [Color](struct_tale_worlds_1_1_library_1_1_color.html) | [GetValueAsColor](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#ae36fc0da57c76c4713cbc43d9e558869) ([BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) propertyType) |
| [Sprite](class_tale_worlds_1_1_two_dimension_1_1_sprite.html) | [GetValueAsSprite](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#ae273dfaeff2136c1cab7598076c14fdc) ([BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) propertyType) |
| void | [SetValueAsFloat](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#ab89e26ce5c1d6c57121136c352d85372) ([BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) propertyType, float value) |
| void | [SetValueAsColor](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#a7f9c2399d10ed578c058b7758c5305d2) ([BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) propertyType, in [Color](struct_tale_worlds_1_1_library_1_1_color.html) value) |
| void | [SetValueAsSprite](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#a7472fa9bba47faeace037fe8d3659c1f) ([BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) propertyType, [Sprite](class_tale_worlds_1_1_two_dimension_1_1_sprite.html) value) |
| [TextMaterial](class_tale_worlds_1_1_two_dimension_1_1_text_material.html) | [CreateTextMaterial](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#ade32331a7afd7dc7fdf4fe3ffc780590) ([TwoDimensionDrawContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html) drawContext) |

|  |  |
| --- | --- |
| Public Attributes | |
| [Color](struct_tale_worlds_1_1_library_1_1_color.html) | [FontColor](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#a94e87ca6b568aa3fedd3849142781cf3) |
| [Color](struct_tale_worlds_1_1_library_1_1_color.html) | [TextGlowColor](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#a9b2434722064a305f65dfad1dea8a7ea) |
| [Color](struct_tale_worlds_1_1_library_1_1_color.html) | [TextOutlineColor](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#a0176edc1df97b65728ebaa98530ba68d) |
| float | [TextOutlineAmount](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#a1c834d125a2369c9b2aa599295d6fa07) |
| float | [TextGlowRadius](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#aba714442e435bd1c44e8e4108cdd9670) |
| float | [TextBlur](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#ac5f2599b0ecc3c0b9a84377215692596) |
| float | [TextShadowOffset](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#aef155aab9e52877d4f53e75a0bafe32d) |
| float | [TextShadowAngle](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#a0d7e38ca1ce48076a8a0a8d13ebc35bc) |
| float | [TextColorFactor](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#af1534100c8c671aa5be5b7fb59864077) |
| float | [TextAlphaFactor](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#a2c4e8c6437421b574971cef3f60a4b00) |
| float | [TextHueFactor](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#a45f84c7e5c44f6ebe14168f0d449d8fd) |
| float | [TextSaturationFactor](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#adcdf2fd07d78a50d162bf1ce039cc22f) |
| float | [TextValueFactor](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#a5a3fbf48c0a7954a611431b969abf4a5) |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#ab178db26fa5698d90d58e8625151d367)FillFrom() [1/2]
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.BrushState.FillFrom | ( | [Style](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html) | *style* | ) |  |

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#af9357ee21348af1fd35e5ce0f18496d5)LerpFrom() [1/2]
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.BrushState.LerpFrom | ( | [BrushState](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html) | *start*, |
|  |  | [Style](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html) | *end*, |
|  |  | float | *ratio* ) |

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#ab6b92a7e0001f4a63a11aaf513255004)FillFrom() [2/2]
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void IBrushAnimationState. TaleWorlds.GauntletUI.BrushState.FillFrom | ( | [IDataSource](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_data_source.html) | *source* | ) |  |

Implements [TaleWorlds.GauntletUI.IBrushAnimationState](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_animation_state.html#a720cf83c62264c3ff5fa2b7d4f4650ba).

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#a40358124ba29f94335286e06aa48fe8b)LerpFrom() [2/2]
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void IBrushAnimationState. TaleWorlds.GauntletUI.BrushState.LerpFrom | ( | [IBrushAnimationState](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_animation_state.html) | *start*, |
|  |  | [IDataSource](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_data_source.html) | *end*, |
|  |  | float | *ratio* ) |

Implements [TaleWorlds.GauntletUI.IBrushAnimationState](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_animation_state.html#a1c83538ca5ccaa62f3cbd3bde78d2a72).

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#ad141866901b9371069d57b5f886ee060)GetValueAsFloat()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.GauntletUI.BrushState.GetValueAsFloat | ( | [BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) | *propertyType* | ) |  |

Implements [TaleWorlds.GauntletUI.IBrushAnimationState](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_animation_state.html#abaa8ebf4113af7a12a9e6224ee8fcb01).

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#ae36fc0da57c76c4713cbc43d9e558869)GetValueAsColor()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Color](struct_tale_worlds_1_1_library_1_1_color.html) TaleWorlds.GauntletUI.BrushState.GetValueAsColor | ( | [BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) | *propertyType* | ) |  |

Implements [TaleWorlds.GauntletUI.IBrushAnimationState](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_animation_state.html#a7ae21d40e4e36e537583e5fd00796cfa).

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#ae273dfaeff2136c1cab7598076c14fdc)GetValueAsSprite()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Sprite](class_tale_worlds_1_1_two_dimension_1_1_sprite.html) TaleWorlds.GauntletUI.BrushState.GetValueAsSprite | ( | [BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) | *propertyType* | ) |  |

Implements [TaleWorlds.GauntletUI.IBrushAnimationState](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_animation_state.html#ac7aa0bd3603ccb7b85b2e9e8548ce657).

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#ab89e26ce5c1d6c57121136c352d85372)SetValueAsFloat()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.BrushState.SetValueAsFloat | ( | [BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) | *propertyType*, |
|  |  | float | *value* ) |

Implements [TaleWorlds.GauntletUI.IBrushAnimationState](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_animation_state.html#a7779cdf9e04f392906a995102648686c).

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#a7f9c2399d10ed578c058b7758c5305d2)SetValueAsColor()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.BrushState.SetValueAsColor | ( | [BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) | *propertyType*, |
|  |  | in [Color](struct_tale_worlds_1_1_library_1_1_color.html) | *value* ) |

Implements [TaleWorlds.GauntletUI.IBrushAnimationState](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_animation_state.html#ab46f050b414ed0c99078530307190619).

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#a7472fa9bba47faeace037fe8d3659c1f)SetValueAsSprite()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.BrushState.SetValueAsSprite | ( | [BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) | *propertyType*, |
|  |  | [Sprite](class_tale_worlds_1_1_two_dimension_1_1_sprite.html) | *value* ) |

Implements [TaleWorlds.GauntletUI.IBrushAnimationState](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_brush_animation_state.html#a890630c8d38bac50dd2d9336366e3944).

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#ade32331a7afd7dc7fdf4fe3ffc780590)CreateTextMaterial()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [TextMaterial](class_tale_worlds_1_1_two_dimension_1_1_text_material.html) TaleWorlds.GauntletUI.BrushState.CreateTextMaterial | ( | [TwoDimensionDrawContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html) | *drawContext* | ) |  |

Member Data Documentation
-------------------------

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#a94e87ca6b568aa3fedd3849142781cf3)FontColor
--------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Color](struct_tale_worlds_1_1_library_1_1_color.html) TaleWorlds.GauntletUI.BrushState.FontColor |

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#a9b2434722064a305f65dfad1dea8a7ea)TextGlowColor
------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Color](struct_tale_worlds_1_1_library_1_1_color.html) TaleWorlds.GauntletUI.BrushState.TextGlowColor |

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#a0176edc1df97b65728ebaa98530ba68d)TextOutlineColor
---------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Color](struct_tale_worlds_1_1_library_1_1_color.html) TaleWorlds.GauntletUI.BrushState.TextOutlineColor |

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#a1c834d125a2369c9b2aa599295d6fa07)TextOutlineAmount
----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.GauntletUI.BrushState.TextOutlineAmount |

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#aba714442e435bd1c44e8e4108cdd9670)TextGlowRadius
-------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.GauntletUI.BrushState.TextGlowRadius |

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#ac5f2599b0ecc3c0b9a84377215692596)TextBlur
-------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.GauntletUI.BrushState.TextBlur |

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#aef155aab9e52877d4f53e75a0bafe32d)TextShadowOffset
---------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.GauntletUI.BrushState.TextShadowOffset |

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#a0d7e38ca1ce48076a8a0a8d13ebc35bc)TextShadowAngle
--------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.GauntletUI.BrushState.TextShadowAngle |

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#af1534100c8c671aa5be5b7fb59864077)TextColorFactor
--------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.GauntletUI.BrushState.TextColorFactor |

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#a2c4e8c6437421b574971cef3f60a4b00)TextAlphaFactor
--------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.GauntletUI.BrushState.TextAlphaFactor |

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#a45f84c7e5c44f6ebe14168f0d449d8fd)TextHueFactor
------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.GauntletUI.BrushState.TextHueFactor |

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#adcdf2fd07d78a50d162bf1ce039cc22f)TextSaturationFactor
-------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.GauntletUI.BrushState.TextSaturationFactor |

[◆](struct_tale_worlds_1_1_gauntlet_u_i_1_1_brush_state.html#a5a3fbf48c0a7954a611431b969abf4a5)TextValueFactor
--------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.GauntletUI.BrushState.TextValueFactor |

