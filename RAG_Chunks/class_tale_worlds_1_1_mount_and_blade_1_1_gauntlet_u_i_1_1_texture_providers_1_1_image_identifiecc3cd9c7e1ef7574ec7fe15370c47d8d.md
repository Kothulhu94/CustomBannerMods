--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifiecc3cd9c7e1ef7574ec7fe15370c47d8d.html ---

TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ImageIdentifiers.PlayerAvatarImageTextureProvider Class ReferenceInherits [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ImageIdentifiers.ImageIdentifierTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [PlayerAvatarImageTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifiecc3cd9c7e1ef7574ec7fe15370c47d8d.html#ac957a088625b2e84ba2b6d436574a348) () |
| override void | [Tick](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifiecc3cd9c7e1ef7574ec7fe15370c47d8d.html#ad0a5e03ea16dd02fc130fdd5a0f81f3c) (float dt) |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ImageIdentifiers.ImageIdentifierTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html) | |
|  | [ImageIdentifierTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#abbfaadb86d6bcbfb612c71119335213a) () |
| override void | [Clear](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#a52505a82b366c8f00a748463edc0ae72) (bool clearNextFrame) |
|  | Only clears \_providedTexture. Doesn't reset set properties from the view side.(e.g ImageTypeCode, AdditionalArgs, ImageId, IsBig). |
| void | [CreateImageWithId](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#ae4a8cb21d453997dfca68abff333e8db) (string id, string additionalArgs) |
| Public Member Functions inherited from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html) | |
| virtual void | [SetTargetSize](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#a1d840a6eb2069b6d62e59a37a7374393) (int width, int height) |
| [Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) | [GetTextureForRender](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#ade86cbe04ebe31e95f7022ddbcf9a4e7) ([TwoDimensionContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html) context, string name=null) |
| void | [SetProperty](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#aa1070ade9147c6089986a2a874d9a465) (string name, object value) |
| object | [GetProperty](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#a18435ef5f4aa4f0693498278fb76c6a2) (string name) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnCreateImageWithId](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifiecc3cd9c7e1ef7574ec7fe15370c47d8d.html#afab9d039c35944134a9dfae876c1edfe) (string id, string additionalArgs) |
| override bool | [GetCanForceCheckTexture](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifiecc3cd9c7e1ef7574ec7fe15370c47d8d.html#af8afa48a6dd2b8b412752df14e662404) () |
| override void | [OnCheckTexture](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifiecc3cd9c7e1ef7574ec7fe15370c47d8d.html#af22d00547ff74b73507a2f6e9e58143c) () |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ImageIdentifiers.ImageIdentifierTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html) | |
| void | [OnCreateImageWithId](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#aacfcf976877137191fdd76d42c2d0584) (string id, string additionalArgs) |
| override [TwoDimension.Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) | [OnGetTextureForRender](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#a929b7ecd1b5afc207d1ab2155a634ae5) ([TwoDimensionContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html) twoDimensionContext, string name) |
| void | [ForceRefreshTextures](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#a501583e5aae387f14fe07ea9edaf478b) () |
| void | [OnTextureCreated](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#a49560412ab034a3b74682ff63db1f956) ([Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) texture) |
| void | [OnTextureCreationCancelled](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#aac9ea727768bb72201c457da251057d7) () |
| Protected Member Functions inherited from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html) | |
| [Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) | [OnGetTextureForRender](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#ac65b91fd4b9ccfb73220121fa7396844) ([TwoDimensionContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html) twoDimensionContext, string name) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ImageIdentifiers.ImageIdentifierTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html) | |
| ThumbnailCreationData | [ThumbnailCreationData](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#aff958dce7d67630e0bf91f504e4cb029) `[get, set]` |
| bool | [IsReleased](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#af91dc90186197e2728134b0ffb4c0c9c) `[get, set]` |
| bool | [IsBig](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#a1fdcd8b389a6a92cb170d9ca01b00e7d) `[get, set]` |
| string | [ImageId](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#ad08172b9178ac2beb30b64c4664330ba) `[get, set]` |
| string | [AdditionalArgs](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#ac13b626cb2db717a6085539b845fc4d8) `[get, set]` |
| Properties inherited from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html) | |
| string | [SourceInfo](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#a3189b71ef4da6dfc199adddb1584191f) `[get, set]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifiecc3cd9c7e1ef7574ec7fe15370c47d8d.html#ac957a088625b2e84ba2b6d436574a348)PlayerAvatarImageTextureProvider()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ImageIdentifiers.PlayerAvatarImageTextureProvider.PlayerAvatarImageTextureProvider | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifiecc3cd9c7e1ef7574ec7fe15370c47d8d.html#ad0a5e03ea16dd02fc130fdd5a0f81f3c)Tick()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ImageIdentifiers.PlayerAvatarImageTextureProvider.Tick | ( | float | *dt* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ImageIdentifiers.ImageIdentifierTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#af487c8c926f1afbdd9a447d34a3fa9b0).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifiecc3cd9c7e1ef7574ec7fe15370c47d8d.html#afab9d039c35944134a9dfae876c1edfe)OnCreateImageWithId()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ImageIdentifiers.PlayerAvatarImageTextureProvider.OnCreateImageWithId | ( | string | *id*, | |  |  | string | *additionalArgs* ) | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifiecc3cd9c7e1ef7574ec7fe15370c47d8d.html#af8afa48a6dd2b8b412752df14e662404)GetCanForceCheckTexture()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override bool TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ImageIdentifiers.PlayerAvatarImageTextureProvider.GetCanForceCheckTexture | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ImageIdentifiers.ImageIdentifierTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#a842c16b8e25af03f8204b5d0b72c7c85).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifiecc3cd9c7e1ef7574ec7fe15370c47d8d.html#af22d00547ff74b73507a2f6e9e58143c)OnCheckTexture()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ImageIdentifiers.PlayerAvatarImageTextureProvider.OnCheckTexture | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ImageIdentifiers.ImageIdentifierTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#a1493aed0ae1e002f96ce4db642a11098).

