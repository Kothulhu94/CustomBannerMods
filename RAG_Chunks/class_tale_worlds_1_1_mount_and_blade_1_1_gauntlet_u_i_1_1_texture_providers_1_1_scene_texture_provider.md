--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_scene_texture_provider.html ---

TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.SceneTextureProvider Class ReferenceInherits [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [SceneTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_scene_texture_provider.html#a439f405818aa71f1bce3fdc6f8ae3e0c) () |
| override void | [Tick](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_scene_texture_provider.html#ac8f8ee5f6a67272891febad269c26720) (float dt) |
| override void | [SetTargetSize](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_scene_texture_provider.html#a23d215570e175910edbf8527a7eb7909) (int width, int height) |
| Public Member Functions inherited from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html) | |
| [Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) | [GetTextureForRender](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#ade86cbe04ebe31e95f7022ddbcf9a4e7) ([TwoDimensionContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html) context, string name=null) |
| virtual void | [Clear](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#ad55ae18c49d5b0fd17fd72aa11cfff11) (bool clearNextFrame) |
| void | [SetProperty](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#aa1070ade9147c6089986a2a874d9a465) (string name, object value) |
| object | [GetProperty](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#a18435ef5f4aa4f0693498278fb76c6a2) (string name) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override [TwoDimension.Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) | [OnGetTextureForRender](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_scene_texture_provider.html#a1c13948d0f80d016454ad9b4f7e1e789) ([TwoDimensionContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html) twoDimensionContext, string name) |
| Protected Member Functions inherited from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html) | |
| [Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) | [OnGetTextureForRender](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#ac65b91fd4b9ccfb73220121fa7396844) ([TwoDimensionContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html) twoDimensionContext, string name) |

|  |  |
| --- | --- |
| Properties | |
| [Scene](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_scene_texture_provider.html#a2c629093fa1e9d72cf6575eaaa0613f4) | [WantedScene](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_scene_texture_provider.html#a0e52b1661497822d8dd35a25990bdb95) `[get]` |
| bool? | [IsReady](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_scene_texture_provider.html#aa512033d128412434ba5d4ef055060c4) `[get]` |
| object | [Scene](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_scene_texture_provider.html#a2c629093fa1e9d72cf6575eaaa0613f4) `[set]` |
| Properties inherited from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html) | |
| string | [SourceInfo](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#a3189b71ef4da6dfc199adddb1584191f) `[get, set]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_scene_texture_provider.html#a439f405818aa71f1bce3fdc6f8ae3e0c)SceneTextureProvider()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.SceneTextureProvider.SceneTextureProvider | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_scene_texture_provider.html#ac8f8ee5f6a67272891febad269c26720)Tick()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.SceneTextureProvider.Tick | ( | float | *dt* | ) |  | | virtual |

Reimplemented from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#aa8e76bc61347b14690b39ec4897978ba).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_scene_texture_provider.html#a23d215570e175910edbf8527a7eb7909)SetTargetSize()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.SceneTextureProvider.SetTargetSize | ( | int | *width*, | |  |  | int | *height* ) | | virtual |

Reimplemented from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#a1d840a6eb2069b6d62e59a37a7374393).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_scene_texture_provider.html#a1c13948d0f80d016454ad9b4f7e1e789)OnGetTextureForRender()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override [TwoDimension.Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.SceneTextureProvider.OnGetTextureForRender | ( | [TwoDimensionContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html) | *twoDimensionContext*, | |  |  | string | *name* ) | | protected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_scene_texture_provider.html#a0e52b1661497822d8dd35a25990bdb95)WantedScene
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Scene](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_scene_texture_provider.html#a2c629093fa1e9d72cf6575eaaa0613f4) TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.SceneTextureProvider.WantedScene | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_scene_texture_provider.html#aa512033d128412434ba5d4ef055060c4)IsReady
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool? TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.SceneTextureProvider.IsReady | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_scene_texture_provider.html#a2c629093fa1e9d72cf6575eaaa0613f4)Scene
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | object TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.SceneTextureProvider.Scene | | set |

