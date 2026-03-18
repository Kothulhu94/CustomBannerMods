--- SOURCE: class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html ---

TaleWorlds.GauntletUI.Brush Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [Brush](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a9bec3890b9409b767a253c43bfaad3af) () |
| [Style](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html) | [GetStyle](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a7ea755dbfce66564887fbf5382268a29) (string name) |
| [Style](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html) | [GetStyleOrDefault](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a9030b8e13d63201d845eef07c15b2dac) (string name) |
| void | [AddStyle](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a709a7adfe4360cdb9b10e4e72e769d80) ([Style](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html) style) |
| void | [RemoveStyle](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a08db44ad3fe8615d0daf3acd5a51fc17) (string styleName) |
| void | [AddLayer](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#ad52fbf5ff5bf19ce67386a27100224e9) ([BrushLayer](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer.html) layer) |
| void | [RemoveLayer](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a8deb1accf65244d287edaa209c958186) (string layerName) |
| [BrushLayer](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer.html) | [GetLayer](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a0cba20c92d708fd8770b59c517286f43) (string name) |
| void | [FillFrom](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a2f2c4cb5be0be637b7958226b3e6ba85) ([Brush](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a9bec3890b9409b767a253c43bfaad3af) brush) |
| [Brush](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a9bec3890b9409b767a253c43bfaad3af) | [Clone](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a997e39f3e66c52469849d15ceda7f364) () |
| void | [AddAnimation](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a923e2938b867e9b2974b66ca8b3588c4) ([BrushAnimation](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation.html) animation) |
| [BrushAnimation](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation.html) | [GetAnimation](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a550b10b8cb1e003602bc34d6ce6b912c) (string name) |
| IEnumerable< [BrushAnimation](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation.html) > | [GetAnimations](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#af432253464f7e214a64af6c721e6c8bd) () |
| override string | [ToString](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a1e32c84df3b62e5b1c47034722170dd4) () |
| bool | [IsCloneRelated](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#ac7ee287a720486166cf79af3418d7ea5) ([Brush](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a9bec3890b9409b767a253c43bfaad3af) brush) |

|  |  |
| --- | --- |
| Properties | |
| [Brush](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a9bec3890b9409b767a253c43bfaad3af) | [ClonedFrom](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a93c25a7cef02af511db7a12513a80492) `[get]` |
| [Brush](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a9bec3890b9409b767a253c43bfaad3af) | [OverriddenBrush](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#ab6d2e7828f086f16822a366b83920efa) `[get]` |
| string | [Name](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a0aa495dc641757bc5d7c949dda01c3f3) `[get, set]` |
| float | [TransitionDuration](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a7b86857bd625163d049b9dd26b0a3cf1) `[get, set]` |
| [Style](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html) | [DefaultStyle](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#ab0486677797fd65cb5d5d4e43b3abb39) `[get]` |
| Font | [Font](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a1d760525f88963564407234332fcd9c2) `[get, set]` |
| [FontStyle](namespace_tale_worlds_1_1_two_dimension.html#a0d75ad17da5b455fc1422fdd33883622) | [FontStyle](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#abca353b8f270fb028f9a1990befa92d3) `[get, set]` |
| int | [FontSize](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a1408532e465cb5c4516ace3bd27b213b) `[get, set]` |
| [TextHorizontalAlignment](namespace_tale_worlds_1_1_two_dimension.html#af6ca63d15408f01210c236921a377db2) | [TextHorizontalAlignment](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#ad821a83f9319aa5c486b5039cebf68c9) `[get, set]` |
| [TextVerticalAlignment](namespace_tale_worlds_1_1_two_dimension.html#ae0c712f027593e48326763d56ecdcc3f) | [TextVerticalAlignment](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a5704d12e4cf7355d11e937f5ef70f4b5) `[get, set]` |
| float | [GlobalColorFactor](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a4cafebe849ac57a909ed709eb4b61a21) `[get, set]` |
| float | [GlobalAlphaFactor](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a4043ff8ea3678275555091c88c4a052f) `[get, set]` |
| [Color](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a5324b667803e68231e17ffdf5db3e971) | [GlobalColor](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#ae1c13f0dfb68478208545ae6d0cdb198) `[get, set]` |
| SoundProperties | [SoundProperties](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a5f6df47e497fd932ddda5716b833ff76) `[get, set]` |
| Sprite | [Sprite](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#ab7f1cad6de9a78f1c9098bd2717c123b) `[get, set]` |
| bool | [VerticalFlip](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a2059c3571c52da0de937385e06359f66) `[get, set]` |
| bool | [HorizontalFlip](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a5e902aa5c8353786d44a51b8e3e202ac) `[get, set]` |
| Color | [Color](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a5324b667803e68231e17ffdf5db3e971) `[get, set]` |
| float | [ColorFactor](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#ac2a4874fe7c5cb39468993f740f89a8f) `[get, set]` |
| float | [AlphaFactor](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a18cfe7386d8933b2a71a36d2023f2a76) `[get, set]` |
| float | [HueFactor](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#aa84468e256cae2bb155324b8dc32c28f) `[get, set]` |
| float | [SaturationFactor](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a46375bb98df8ecc94cfd025bd9677191) `[get, set]` |
| float | [ValueFactor](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#abab2d18e66455df3dcc804cf695e9a3b) `[get, set]` |
| [Color](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a5324b667803e68231e17ffdf5db3e971) | [FontColor](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a7df27bf9103292ed0bf1f5a1ae5527bc) `[get, set]` |
| float | [TextColorFactor](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a7f2114bdfd69ca0ffbfd201cedbad55f) `[get, set]` |
| float | [TextAlphaFactor](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#aeab38ad56108ae832a679255bfccee44) `[get, set]` |
| float | [TextHueFactor](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a85f744e07b13b8eefa557ed97775cd36) `[get, set]` |
| float | [TextSaturationFactor](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#ae2a66f30acd11f113d085e0246317ebb) `[get, set]` |
| float | [TextValueFactor](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a3349a6cec614de19f4c25e2b6f50b74d) `[get, set]` |
| Dictionary< string, [BrushLayer](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer.html) >.ValueCollection | [Layers](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a1e7a470e280b5da557c3d0548e20e30c) `[get]` |
| [StyleLayer](class_tale_worlds_1_1_gauntlet_u_i_1_1_style_layer.html) | [DefaultStyleLayer](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a59c607dd1f02293ee4bc192f30fe4816) `[get]` |
| [BrushLayer](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer.html) | [DefaultLayer](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a556ce65e972fe530cd24731cc8a653cc) `[get]` |
| Dictionary< string, [Style](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html) >.ValueCollection | [Styles](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a2981108733d9326cbd970d9e39e292f1) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a9bec3890b9409b767a253c43bfaad3af)Brush()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.GauntletUI.Brush.Brush | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a7ea755dbfce66564887fbf5382268a29)GetStyle()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Style](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html) TaleWorlds.GauntletUI.Brush.GetStyle | ( | string | *name* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a9030b8e13d63201d845eef07c15b2dac)GetStyleOrDefault()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Style](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html) TaleWorlds.GauntletUI.Brush.GetStyleOrDefault | ( | string | *name* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a709a7adfe4360cdb9b10e4e72e769d80)AddStyle()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.Brush.AddStyle | ( | [Style](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html) | *style* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a08db44ad3fe8615d0daf3acd5a51fc17)RemoveStyle()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.Brush.RemoveStyle | ( | string | *styleName* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#ad52fbf5ff5bf19ce67386a27100224e9)AddLayer()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.Brush.AddLayer | ( | [BrushLayer](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer.html) | *layer* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a8deb1accf65244d287edaa209c958186)RemoveLayer()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.Brush.RemoveLayer | ( | string | *layerName* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a0cba20c92d708fd8770b59c517286f43)GetLayer()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [BrushLayer](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer.html) TaleWorlds.GauntletUI.Brush.GetLayer | ( | string | *name* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a2f2c4cb5be0be637b7958226b3e6ba85)FillFrom()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.Brush.FillFrom | ( | [Brush](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a9bec3890b9409b767a253c43bfaad3af) | *brush* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a997e39f3e66c52469849d15ceda7f364)Clone()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Brush](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a9bec3890b9409b767a253c43bfaad3af) TaleWorlds.GauntletUI.Brush.Clone | ( |  | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a923e2938b867e9b2974b66ca8b3588c4)AddAnimation()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.Brush.AddAnimation | ( | [BrushAnimation](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation.html) | *animation* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a550b10b8cb1e003602bc34d6ce6b912c)GetAnimation()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [BrushAnimation](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation.html) TaleWorlds.GauntletUI.Brush.GetAnimation | ( | string | *name* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#af432253464f7e214a64af6c721e6c8bd)GetAnimations()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< [BrushAnimation](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_animation.html) > TaleWorlds.GauntletUI.Brush.GetAnimations | ( |  | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a1e32c84df3b62e5b1c47034722170dd4)ToString()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.GauntletUI.Brush.ToString | ( |  | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#ac7ee287a720486166cf79af3418d7ea5)IsCloneRelated()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.GauntletUI.Brush.IsCloneRelated | ( | [Brush](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a9bec3890b9409b767a253c43bfaad3af) | *brush* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a93c25a7cef02af511db7a12513a80492)ClonedFrom
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Brush](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a9bec3890b9409b767a253c43bfaad3af) TaleWorlds.GauntletUI.Brush.ClonedFrom | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#ab6d2e7828f086f16822a366b83920efa)OverriddenBrush
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Brush](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a9bec3890b9409b767a253c43bfaad3af) TaleWorlds.GauntletUI.Brush.OverriddenBrush | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a0aa495dc641757bc5d7c949dda01c3f3)Name
--------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.GauntletUI.Brush.Name | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a7b86857bd625163d049b9dd26b0a3cf1)TransitionDuration
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.Brush.TransitionDuration | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#ab0486677797fd65cb5d5d4e43b3abb39)DefaultStyle
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Style](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html) TaleWorlds.GauntletUI.Brush.DefaultStyle | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a1d760525f88963564407234332fcd9c2)Font
--------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Font TaleWorlds.GauntletUI.Brush.Font | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#abca353b8f270fb028f9a1990befa92d3)FontStyle
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [FontStyle](namespace_tale_worlds_1_1_two_dimension.html#a0d75ad17da5b455fc1422fdd33883622) TaleWorlds.GauntletUI.Brush.FontStyle | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a1408532e465cb5c4516ace3bd27b213b)FontSize
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.GauntletUI.Brush.FontSize | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#ad821a83f9319aa5c486b5039cebf68c9)TextHorizontalAlignment
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextHorizontalAlignment](namespace_tale_worlds_1_1_two_dimension.html#af6ca63d15408f01210c236921a377db2) TaleWorlds.GauntletUI.Brush.TextHorizontalAlignment | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a5704d12e4cf7355d11e937f5ef70f4b5)TextVerticalAlignment
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextVerticalAlignment](namespace_tale_worlds_1_1_two_dimension.html#ae0c712f027593e48326763d56ecdcc3f) TaleWorlds.GauntletUI.Brush.TextVerticalAlignment | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a4cafebe849ac57a909ed709eb4b61a21)GlobalColorFactor
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.Brush.GlobalColorFactor | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a4043ff8ea3678275555091c88c4a052f)GlobalAlphaFactor
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.Brush.GlobalAlphaFactor | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#ae1c13f0dfb68478208545ae6d0cdb198)GlobalColor
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Color](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a5324b667803e68231e17ffdf5db3e971) TaleWorlds.GauntletUI.Brush.GlobalColor | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a5f6df47e497fd932ddda5716b833ff76)SoundProperties
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | SoundProperties TaleWorlds.GauntletUI.Brush.SoundProperties | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#ab7f1cad6de9a78f1c9098bd2717c123b)Sprite
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Sprite TaleWorlds.GauntletUI.Brush.Sprite | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a2059c3571c52da0de937385e06359f66)VerticalFlip
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.GauntletUI.Brush.VerticalFlip | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a5e902aa5c8353786d44a51b8e3e202ac)HorizontalFlip
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.GauntletUI.Brush.HorizontalFlip | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a5324b667803e68231e17ffdf5db3e971)Color
---------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Color TaleWorlds.GauntletUI.Brush.Color | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#ac2a4874fe7c5cb39468993f740f89a8f)ColorFactor
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.Brush.ColorFactor | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a18cfe7386d8933b2a71a36d2023f2a76)AlphaFactor
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.Brush.AlphaFactor | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#aa84468e256cae2bb155324b8dc32c28f)HueFactor
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.Brush.HueFactor | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a46375bb98df8ecc94cfd025bd9677191)SaturationFactor
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.Brush.SaturationFactor | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#abab2d18e66455df3dcc804cf695e9a3b)ValueFactor
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.Brush.ValueFactor | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a7df27bf9103292ed0bf1f5a1ae5527bc)FontColor
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Color](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a5324b667803e68231e17ffdf5db3e971) TaleWorlds.GauntletUI.Brush.FontColor | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a7f2114bdfd69ca0ffbfd201cedbad55f)TextColorFactor
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.Brush.TextColorFactor | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#aeab38ad56108ae832a679255bfccee44)TextAlphaFactor
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.Brush.TextAlphaFactor | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a85f744e07b13b8eefa557ed97775cd36)TextHueFactor
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.Brush.TextHueFactor | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#ae2a66f30acd11f113d085e0246317ebb)TextSaturationFactor
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.Brush.TextSaturationFactor | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a3349a6cec614de19f4c25e2b6f50b74d)TextValueFactor
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.Brush.TextValueFactor | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a1e7a470e280b5da557c3d0548e20e30c)Layers
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Dictionary<string, [BrushLayer](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer.html)>.ValueCollection TaleWorlds.GauntletUI.Brush.Layers | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a59c607dd1f02293ee4bc192f30fe4816)DefaultStyleLayer
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [StyleLayer](class_tale_worlds_1_1_gauntlet_u_i_1_1_style_layer.html) TaleWorlds.GauntletUI.Brush.DefaultStyleLayer | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a556ce65e972fe530cd24731cc8a653cc)DefaultLayer
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BrushLayer](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_layer.html) TaleWorlds.GauntletUI.Brush.DefaultLayer | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html#a2981108733d9326cbd970d9e39e292f1)Styles
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Dictionary<string, [Style](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html)>.ValueCollection TaleWorlds.GauntletUI.Brush.Styles | | get |

