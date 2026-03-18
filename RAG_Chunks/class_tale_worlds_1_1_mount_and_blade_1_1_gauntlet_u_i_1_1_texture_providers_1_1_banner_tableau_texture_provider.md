--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_banner_tableau_texture_provider.html ---

TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.BannerTableauTextureProvider Class ReferenceInherits [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [BannerTableauTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_banner_tableau_texture_provider.html#a955600985911be496dbb0ac3a91405bf) () |
| override void | [Clear](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_banner_tableau_texture_provider.html#a1fefda7ee1cc8b391653c6681373fdd2) (bool clearNextFrame) |
| override void | [SetTargetSize](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_banner_tableau_texture_provider.html#a3f242ad6f37381a5f6145a63902601ba) (int width, int height) |
| override void | [Tick](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_banner_tableau_texture_provider.html#a92366e76fe8f1f50b0b9204f3e3ae41f) ([float](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_banner_tableau_texture_provider.html#ac46c7cde4038858e71903aa62581eef9) dt) |
| Public Member Functions inherited from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html) | |
| [Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) | [GetTextureForRender](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#ade86cbe04ebe31e95f7022ddbcf9a4e7) ([TwoDimensionContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html) context, string name=null) |
| void | [SetProperty](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#aa1070ade9147c6089986a2a874d9a465) (string name, object value) |
| object | [GetProperty](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#a18435ef5f4aa4f0693498278fb76c6a2) (string name) |

|  |  |
| --- | --- |
| Public Attributes | |
|  | [float](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_banner_tableau_texture_provider.html#ac46c7cde4038858e71903aa62581eef9) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override [TwoDimension.Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) | [OnGetTextureForRender](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_banner_tableau_texture_provider.html#aef4ad0cbbe7e612141474c132aaef0d5) ([TwoDimensionContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html) twoDimensionContext, string name) |
| Protected Member Functions inherited from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html) | |
| [Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) | [OnGetTextureForRender](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#ac65b91fd4b9ccfb73220121fa7396844) ([TwoDimensionContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html) twoDimensionContext, string name) |

|  |  |
| --- | --- |
| Properties | |
| string | [BannerCodeText](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_banner_tableau_texture_provider.html#a95dd00302f5a6ef9c68714cbc9b52710) `[set]` |
| bool | [IsNineGrid](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_banner_tableau_texture_provider.html#a357e182b33f68ea82871055e6a3cf1a8) `[set]` |
| [float](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_banner_tableau_texture_provider.html#ac46c7cde4038858e71903aa62581eef9) | [CustomRenderScale](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_banner_tableau_texture_provider.html#a9c38ef39bca2f40f9b1c8cdb14b43eb9) `[set]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [UpdatePositionValueManual](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_banner_tableau_texture_provider.html#ab9a36fa3b689f98d85b216bfb0334d86) `[set]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [UpdateSizeValueManual](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_banner_tableau_texture_provider.html#a8f5f422a8e4518453c4ca2dabf7f632f) `[set]` |
| bool | [UpdateRotationValueManualWithMirror](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_banner_tableau_texture_provider.html#a60050bd4506a62905a9022f69a0d977f) `[set]` |
| int | [MeshIndexToUpdate](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_banner_tableau_texture_provider.html#a901b6990b46be5a47bd75b334c243203) `[set]` |
| bool | [IsHidden](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_banner_tableau_texture_provider.html#a4f712cb905dd236026bfb6c7163a4b5b) `[get, set]` |
| Properties inherited from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html) | |
| string | [SourceInfo](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#a3189b71ef4da6dfc199adddb1584191f) `[get, set]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_banner_tableau_texture_provider.html#a955600985911be496dbb0ac3a91405bf)BannerTableauTextureProvider()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.BannerTableauTextureProvider.BannerTableauTextureProvider | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_banner_tableau_texture_provider.html#a1fefda7ee1cc8b391653c6681373fdd2)Clear()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.BannerTableauTextureProvider.Clear | ( | bool | *clearNextFrame* | ) |  | | virtual |

Reimplemented from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#ad55ae18c49d5b0fd17fd72aa11cfff11).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_banner_tableau_texture_provider.html#aef4ad0cbbe7e612141474c132aaef0d5)OnGetTextureForRender()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override [TwoDimension.Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.BannerTableauTextureProvider.OnGetTextureForRender | ( | [TwoDimensionContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html) | *twoDimensionContext*, | |  |  | string | *name* ) | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_banner_tableau_texture_provider.html#a3f242ad6f37381a5f6145a63902601ba)SetTargetSize()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.BannerTableauTextureProvider.SetTargetSize | ( | int | *width*, | |  |  | int | *height* ) | | virtual |

Reimplemented from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#a1d840a6eb2069b6d62e59a37a7374393).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_banner_tableau_texture_provider.html#a92366e76fe8f1f50b0b9204f3e3ae41f)Tick()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.BannerTableauTextureProvider.Tick | ( | [float](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_banner_tableau_texture_provider.html#ac46c7cde4038858e71903aa62581eef9) | *dt* | ) |  | | virtual |

Reimplemented from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#aa8e76bc61347b14690b39ec4897978ba).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_banner_tableau_texture_provider.html#ac46c7cde4038858e71903aa62581eef9)float
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.BannerTableauTextureProvider.float |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_banner_tableau_texture_provider.html#a95dd00302f5a6ef9c68714cbc9b52710)BannerCodeText
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.BannerTableauTextureProvider.BannerCodeText | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_banner_tableau_texture_provider.html#a357e182b33f68ea82871055e6a3cf1a8)IsNineGrid
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.BannerTableauTextureProvider.IsNineGrid | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_banner_tableau_texture_provider.html#a9c38ef39bca2f40f9b1c8cdb14b43eb9)CustomRenderScale
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [float](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_banner_tableau_texture_provider.html#ac46c7cde4038858e71903aa62581eef9) TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.BannerTableauTextureProvider.CustomRenderScale | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_banner_tableau_texture_provider.html#ab9a36fa3b689f98d85b216bfb0334d86)UpdatePositionValueManual
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.BannerTableauTextureProvider.UpdatePositionValueManual | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_banner_tableau_texture_provider.html#a8f5f422a8e4518453c4ca2dabf7f632f)UpdateSizeValueManual
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.BannerTableauTextureProvider.UpdateSizeValueManual | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_banner_tableau_texture_provider.html#a60050bd4506a62905a9022f69a0d977f)UpdateRotationValueManualWithMirror
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.BannerTableauTextureProvider.UpdateRotationValueManualWithMirror | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_banner_tableau_texture_provider.html#a901b6990b46be5a47bd75b334c243203)MeshIndexToUpdate
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.BannerTableauTextureProvider.MeshIndexToUpdate | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_banner_tableau_texture_provider.html#a4f712cb905dd236026bfb6c7163a4b5b)IsHidden
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.BannerTableauTextureProvider.IsHidden | | getset |

