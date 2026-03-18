--- SOURCE: class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html ---

TaleWorlds.GauntletUI.Style Class ReferenceInherits [TaleWorlds.GauntletUI.IDataSource](interface_tale_worlds_1_1_gauntlet_u_i_1_1_i_data_source.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [Style](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a22059d4ea8883aca92262e9f221e92fc) (IEnumerable< [BrushLayer](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer.html) > layers) |
| void | [FillFrom](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a618c573697b650611c6ba3403858f67d) ([Style](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a22059d4ea8883aca92262e9f221e92fc) style) |
| void | [AddLayer](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a06848f5f3deba09470ee1bbcd63de76f) ([StyleLayer](class_tale_worlds_1_1_gauntlet_u_i_1_1_style_layer.html) layer) |
| void | [RemoveLayer](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#af5ebb9e238e3e665521e5f5945b32535) (string layerName) |
| [StyleLayer](class_tale_worlds_1_1_gauntlet_u_i_1_1_style_layer.html) | [GetLayer](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#aa97854f83750aca693f6b48713023116) (int index) |
| [StyleLayer](class_tale_worlds_1_1_gauntlet_u_i_1_1_style_layer.html) | [GetLayer](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a129353dd70a982155cf06b9affcfa857) (string name) |
| [StyleLayer](class_tale_worlds_1_1_gauntlet_u_i_1_1_style_layer.html)[] | [GetLayers](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a2f12f14ae11bcbe93587db9b5b85d30d) () |
| [TextMaterial](class_tale_worlds_1_1_two_dimension_1_1_text_material.html) | [CreateTextMaterial](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#aa062aefb14fa254669690e80abbb4b6f) ([TwoDimensionDrawContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html) drawContext) |
| float | [GetValueAsFloat](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a64c9eacdc542b8a4d7bfdf6b55ca091e) ([BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) propertyType) |
| [Color](struct_tale_worlds_1_1_library_1_1_color.html) | [GetValueAsColor](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a6ae537afafacc8c13fbcd5dfe7aae148) ([BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) propertyType) |
| [Sprite](class_tale_worlds_1_1_two_dimension_1_1_sprite.html) | [GetValueAsSprite](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#ace3e95d384ecd4e968a3fe35544ae3fc) ([BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) propertyType) |
| void | [SetAsDefaultStyle](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a0988d93c1ebb613db29efe3ede43f9cf) () |

|  |  |
| --- | --- |
| Properties | |
| [Style](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a22059d4ea8883aca92262e9f221e92fc) | [DefaultStyle](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a7d78a37766e18933ee006f00f3bb0030) `[get, set]` |
| string | [Name](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#ad208dd908c869903ff18b50469305d0d) `[get, set]` |
| long | [Version](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a4581567394cd4ac36f72b2a80133f542) `[get]` |
| string | [AnimationToPlayOnBegin](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a5a34b6a43d781bba4e7ce4d2b2e76f37) `[get, set]` |
| int | [LayerCount](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a9ba2ec617a1c25022d1a38149f81c081) `[get]` |
| [StyleLayer](class_tale_worlds_1_1_gauntlet_u_i_1_1_style_layer.html) | [DefaultLayer](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#af4a89177da682f91245dcac396361689) `[get]` |
| [StyleAnimationMode](namespace_tale_worlds_1_1_gauntlet_u_i.html#a565517fa41f4c91b35d4a689ad8239de) | [AnimationMode](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a9698c385bb9aba9638305cd1891bf739) `[get, set]` |
| [Color](struct_tale_worlds_1_1_library_1_1_color.html) | [FontColor](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a3d562fe9c646790ad54156688f3e0ee9) `[get, set]` |
| [Color](struct_tale_worlds_1_1_library_1_1_color.html) | [TextGlowColor](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a5ee6914fada67f6e263badfe0ca5f510) `[get, set]` |
| [Color](struct_tale_worlds_1_1_library_1_1_color.html) | [TextOutlineColor](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a3b32ec5dfe85d5432950b017e0e03795) `[get, set]` |
| float | [TextOutlineAmount](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a10b79651aaea09a51c876ff1aaa3a6ee) `[get, set]` |
| float | [TextGlowRadius](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a4f92e49a5bb1f35df1f6bbc9fe34ec94) `[get, set]` |
| float | [TextBlur](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a1892bd98e69a3fb1e05cd27d449edbf9) `[get, set]` |
| float | [TextShadowOffset](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#ac6cba51f75badf5a6e72305e84ec757c) `[get, set]` |
| float | [TextShadowAngle](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#ad886497424042e7e290c49bf0e321f0c) `[get, set]` |
| float | [TextColorFactor](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#aea199ffeb642ce745781f0d2b15094dc) `[get, set]` |
| float | [TextAlphaFactor](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a42d4a04b9b6d45d4f4e84b302fb08aa8) `[get, set]` |
| float | [TextHueFactor](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#ad66e45de00b8d2d9a61595b8de53e54c) `[get, set]` |
| float | [TextSaturationFactor](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#aa8c5ba351613bd40625da2126c6d86aa) `[get, set]` |
| float | [TextValueFactor](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a6d145c2e888746de77065a87cfc58f2c) `[get, set]` |
| Font | [Font](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a3ff10d7879a99a37a8252fe9ac90dca2) `[get, set]` |
| [FontStyle](namespace_tale_worlds_1_1_two_dimension.html#a0d75ad17da5b455fc1422fdd33883622) | [FontStyle](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a47f66c955c9018093e7901299402b4be) `[get, set]` |
| int | [FontSize](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a039ec5be31161beb31f0450cc0e8388d) `[get, set]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a22059d4ea8883aca92262e9f221e92fc)Style()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.GauntletUI.Style.Style | ( | IEnumerable< [BrushLayer](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer.html) > | *layers* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a618c573697b650611c6ba3403858f67d)FillFrom()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.Style.FillFrom | ( | [Style](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a22059d4ea8883aca92262e9f221e92fc) | *style* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a06848f5f3deba09470ee1bbcd63de76f)AddLayer()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.Style.AddLayer | ( | [StyleLayer](class_tale_worlds_1_1_gauntlet_u_i_1_1_style_layer.html) | *layer* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#af5ebb9e238e3e665521e5f5945b32535)RemoveLayer()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.Style.RemoveLayer | ( | string | *layerName* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#aa97854f83750aca693f6b48713023116)GetLayer() [1/2]
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [StyleLayer](class_tale_worlds_1_1_gauntlet_u_i_1_1_style_layer.html) TaleWorlds.GauntletUI.Style.GetLayer | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a129353dd70a982155cf06b9affcfa857)GetLayer() [2/2]
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [StyleLayer](class_tale_worlds_1_1_gauntlet_u_i_1_1_style_layer.html) TaleWorlds.GauntletUI.Style.GetLayer | ( | string | *name* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a2f12f14ae11bcbe93587db9b5b85d30d)GetLayers()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [StyleLayer](class_tale_worlds_1_1_gauntlet_u_i_1_1_style_layer.html)[] TaleWorlds.GauntletUI.Style.GetLayers | ( |  | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#aa062aefb14fa254669690e80abbb4b6f)CreateTextMaterial()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [TextMaterial](class_tale_worlds_1_1_two_dimension_1_1_text_material.html) TaleWorlds.GauntletUI.Style.CreateTextMaterial | ( | [TwoDimensionDrawContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html) | *drawContext* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a64c9eacdc542b8a4d7bfdf6b55ca091e)GetValueAsFloat()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.GauntletUI.Style.GetValueAsFloat | ( | [BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) | *propertyType* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a6ae537afafacc8c13fbcd5dfe7aae148)GetValueAsColor()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Color](struct_tale_worlds_1_1_library_1_1_color.html) TaleWorlds.GauntletUI.Style.GetValueAsColor | ( | [BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) | *propertyType* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#ace3e95d384ecd4e968a3fe35544ae3fc)GetValueAsSprite()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Sprite](class_tale_worlds_1_1_two_dimension_1_1_sprite.html) TaleWorlds.GauntletUI.Style.GetValueAsSprite | ( | [BrushAnimationProperty.BrushAnimationPropertyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation_property.html#ac552bddf75ef776ef5eadae815f62cc0) | *propertyType* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a0988d93c1ebb613db29efe3ede43f9cf)SetAsDefaultStyle()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.Style.SetAsDefaultStyle | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a7d78a37766e18933ee006f00f3bb0030)DefaultStyle
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Style](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a22059d4ea8883aca92262e9f221e92fc) TaleWorlds.GauntletUI.Style.DefaultStyle | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#ad208dd908c869903ff18b50469305d0d)Name
--------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.GauntletUI.Style.Name | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a4581567394cd4ac36f72b2a80133f542)Version
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | long TaleWorlds.GauntletUI.Style.Version | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a5a34b6a43d781bba4e7ce4d2b2e76f37)AnimationToPlayOnBegin
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.GauntletUI.Style.AnimationToPlayOnBegin | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a9ba2ec617a1c25022d1a38149f81c081)LayerCount
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.GauntletUI.Style.LayerCount | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#af4a89177da682f91245dcac396361689)DefaultLayer
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [StyleLayer](class_tale_worlds_1_1_gauntlet_u_i_1_1_style_layer.html) TaleWorlds.GauntletUI.Style.DefaultLayer | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a9698c385bb9aba9638305cd1891bf739)AnimationMode
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [StyleAnimationMode](namespace_tale_worlds_1_1_gauntlet_u_i.html#a565517fa41f4c91b35d4a689ad8239de) TaleWorlds.GauntletUI.Style.AnimationMode | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a3d562fe9c646790ad54156688f3e0ee9)FontColor
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Color](struct_tale_worlds_1_1_library_1_1_color.html) TaleWorlds.GauntletUI.Style.FontColor | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a5ee6914fada67f6e263badfe0ca5f510)TextGlowColor
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Color](struct_tale_worlds_1_1_library_1_1_color.html) TaleWorlds.GauntletUI.Style.TextGlowColor | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a3b32ec5dfe85d5432950b017e0e03795)TextOutlineColor
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Color](struct_tale_worlds_1_1_library_1_1_color.html) TaleWorlds.GauntletUI.Style.TextOutlineColor | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a10b79651aaea09a51c876ff1aaa3a6ee)TextOutlineAmount
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.Style.TextOutlineAmount | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a4f92e49a5bb1f35df1f6bbc9fe34ec94)TextGlowRadius
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.Style.TextGlowRadius | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a1892bd98e69a3fb1e05cd27d449edbf9)TextBlur
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.Style.TextBlur | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#ac6cba51f75badf5a6e72305e84ec757c)TextShadowOffset
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.Style.TextShadowOffset | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#ad886497424042e7e290c49bf0e321f0c)TextShadowAngle
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.Style.TextShadowAngle | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#aea199ffeb642ce745781f0d2b15094dc)TextColorFactor
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.Style.TextColorFactor | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a42d4a04b9b6d45d4f4e84b302fb08aa8)TextAlphaFactor
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.Style.TextAlphaFactor | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#ad66e45de00b8d2d9a61595b8de53e54c)TextHueFactor
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.Style.TextHueFactor | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#aa8c5ba351613bd40625da2126c6d86aa)TextSaturationFactor
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.Style.TextSaturationFactor | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a6d145c2e888746de77065a87cfc58f2c)TextValueFactor
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.Style.TextValueFactor | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a3ff10d7879a99a37a8252fe9ac90dca2)Font
--------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Font TaleWorlds.GauntletUI.Style.Font | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a47f66c955c9018093e7901299402b4be)FontStyle
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [FontStyle](namespace_tale_worlds_1_1_two_dimension.html#a0d75ad17da5b455fc1422fdd33883622) TaleWorlds.GauntletUI.Style.FontStyle | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html#a039ec5be31161beb31f0450cc0e8388d)FontSize
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.GauntletUI.Style.FontSize | | getset |

