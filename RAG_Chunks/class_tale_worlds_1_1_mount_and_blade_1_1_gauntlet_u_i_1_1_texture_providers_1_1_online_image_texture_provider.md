--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_online_image_texture_provider.html ---

TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.OnlineImageTextureProvider Class ReferenceInherits [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [OnlineImageTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_online_image_texture_provider.html#a73f7525d2fa7f8250d67c55821ca54ac) () |
| override void | [Tick](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_online_image_texture_provider.html#a0e4ed208008e385e33f37eb23c1bb603) (float dt) |
| Public Member Functions inherited from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html) | |
| virtual void | [SetTargetSize](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#a1d840a6eb2069b6d62e59a37a7374393) (int width, int height) |
| [Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) | [GetTextureForRender](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#ade86cbe04ebe31e95f7022ddbcf9a4e7) ([TwoDimensionContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html) context, string name=null) |
| virtual void | [Clear](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#ad55ae18c49d5b0fd17fd72aa11cfff11) (bool clearNextFrame) |
| void | [SetProperty](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#aa1070ade9147c6089986a2a874d9a465) (string name, object value) |
| object | [GetProperty](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#a18435ef5f4aa4f0693498278fb76c6a2) (string name) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override [TwoDimension.Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) | [OnGetTextureForRender](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_online_image_texture_provider.html#ab80649997840dbdd092b6bb16c24b745) ([TwoDimensionContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html) twoDimensionContext, string name) |
| Protected Member Functions inherited from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html) | |
| [Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) | [OnGetTextureForRender](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#ac65b91fd4b9ccfb73220121fa7396844) ([TwoDimensionContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html) twoDimensionContext, string name) |

|  |  |
| --- | --- |
| Properties | |
| string | [OnlineSourceUrl](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_online_image_texture_provider.html#a71567c1e0409c63712433d9c3180c470) `[set]` |
| Properties inherited from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html) | |
| string | [SourceInfo](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#a3189b71ef4da6dfc199adddb1584191f) `[get, set]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_online_image_texture_provider.html#a73f7525d2fa7f8250d67c55821ca54ac)OnlineImageTextureProvider()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.OnlineImageTextureProvider.OnlineImageTextureProvider | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_online_image_texture_provider.html#a0e4ed208008e385e33f37eb23c1bb603)Tick()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.OnlineImageTextureProvider.Tick | ( | float | *dt* | ) |  | | virtual |

Reimplemented from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#aa8e76bc61347b14690b39ec4897978ba).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_online_image_texture_provider.html#ab80649997840dbdd092b6bb16c24b745)OnGetTextureForRender()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override [TwoDimension.Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.OnlineImageTextureProvider.OnGetTextureForRender | ( | [TwoDimensionContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html) | *twoDimensionContext*, | |  |  | string | *name* ) | | protected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_online_image_texture_provider.html#a71567c1e0409c63712433d9c3180c470)OnlineSourceUrl
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.OnlineImageTextureProvider.OnlineSourceUrl | | set |

