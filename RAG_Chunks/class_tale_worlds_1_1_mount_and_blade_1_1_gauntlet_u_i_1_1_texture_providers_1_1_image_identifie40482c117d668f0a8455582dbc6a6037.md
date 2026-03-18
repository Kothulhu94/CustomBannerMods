--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html ---

TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ImageIdentifiers.ImageIdentifierTextureProvider Class ReferenceabstractInherits [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html), and IDisposable.

Inherited by [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ImageIdentifiers.BannerImageTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie2e881ee921d72214e50951f694756bd4.html), [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ImageIdentifiers.CharacterImageTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifiebd9a5c4e8a9356d44c47d28e2f5433ce.html), [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ImageIdentifiers.CraftingPieceImageTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie0afc3dd29a01d3488fc309aa258a82e5.html), [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ImageIdentifiers.ItemImageTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie268ae77146c687f787ee7963fd1a5bf5.html), and [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ImageIdentifiers.PlayerAvatarImageTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifiecc3cd9c7e1ef7574ec7fe15370c47d8d.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ImageIdentifierTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#abbfaadb86d6bcbfb612c71119335213a) () |
| override void | [Tick](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#af487c8c926f1afbdd9a447d34a3fa9b0) (float dt) |
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
| void | [OnCreateImageWithId](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#aacfcf976877137191fdd76d42c2d0584) (string id, string additionalArgs) |
| virtual bool | [GetCanForceCheckTexture](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#a842c16b8e25af03f8204b5d0b72c7c85) () |
| virtual void | [OnCheckTexture](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#a1493aed0ae1e002f96ce4db642a11098) () |
| override [TwoDimension.Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) | [OnGetTextureForRender](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#a929b7ecd1b5afc207d1ab2155a634ae5) ([TwoDimensionContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html) twoDimensionContext, string name) |
| void | [ForceRefreshTextures](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#a501583e5aae387f14fe07ea9edaf478b) () |
| void | [OnTextureCreated](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#a49560412ab034a3b74682ff63db1f956) ([Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) texture) |
| void | [OnTextureCreationCancelled](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#aac9ea727768bb72201c457da251057d7) () |
| Protected Member Functions inherited from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html) | |
| [Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) | [OnGetTextureForRender](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#ac65b91fd4b9ccfb73220121fa7396844) ([TwoDimensionContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html) twoDimensionContext, string name) |

|  |  |
| --- | --- |
| Properties | |
| ThumbnailCreationData | [ThumbnailCreationData](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#aff958dce7d67630e0bf91f504e4cb029) `[get, set]` |
| bool | [IsReleased](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#af91dc90186197e2728134b0ffb4c0c9c) `[get, set]` |
| bool | [IsBig](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#a1fdcd8b389a6a92cb170d9ca01b00e7d) `[get, set]` |
| string | [ImageId](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#ad08172b9178ac2beb30b64c4664330ba) `[get, set]` |
| string | [AdditionalArgs](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#ac13b626cb2db717a6085539b845fc4d8) `[get, set]` |
| Properties inherited from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html) | |
| string | [SourceInfo](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#a3189b71ef4da6dfc199adddb1584191f) `[get, set]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#abbfaadb86d6bcbfb612c71119335213a)ImageIdentifierTextureProvider()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ImageIdentifiers.ImageIdentifierTextureProvider.ImageIdentifierTextureProvider | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#aacfcf976877137191fdd76d42c2d0584)OnCreateImageWithId()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ImageIdentifiers.ImageIdentifierTextureProvider.OnCreateImageWithId | ( | string | *id*, | |  |  | string | *additionalArgs* ) | | abstractprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#af487c8c926f1afbdd9a447d34a3fa9b0)Tick()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ImageIdentifiers.ImageIdentifierTextureProvider.Tick | ( | float | *dt* | ) |  | | virtual |

Reimplemented from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#aa8e76bc61347b14690b39ec4897978ba).

Reimplemented in [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ImageIdentifiers.PlayerAvatarImageTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifiecc3cd9c7e1ef7574ec7fe15370c47d8d.html#ad0a5e03ea16dd02fc130fdd5a0f81f3c).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#a52505a82b366c8f00a748463edc0ae72)Clear()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ImageIdentifiers.ImageIdentifierTextureProvider.Clear | ( | bool | *clearNextFrame* | ) |  | | virtual |

Reimplemented from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#ad55ae18c49d5b0fd17fd72aa11cfff11).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#a842c16b8e25af03f8204b5d0b72c7c85)GetCanForceCheckTexture()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual bool TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ImageIdentifiers.ImageIdentifierTextureProvider.GetCanForceCheckTexture | ( |  | ) |  | | protectedvirtual |

Reimplemented in [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ImageIdentifiers.PlayerAvatarImageTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifiecc3cd9c7e1ef7574ec7fe15370c47d8d.html#af8afa48a6dd2b8b412752df14e662404).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#a1493aed0ae1e002f96ce4db642a11098)OnCheckTexture()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ImageIdentifiers.ImageIdentifierTextureProvider.OnCheckTexture | ( |  | ) |  | | protectedvirtual |

Reimplemented in [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ImageIdentifiers.PlayerAvatarImageTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifiecc3cd9c7e1ef7574ec7fe15370c47d8d.html#af22d00547ff74b73507a2f6e9e58143c).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#a929b7ecd1b5afc207d1ab2155a634ae5)OnGetTextureForRender()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override [TwoDimension.Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ImageIdentifiers.ImageIdentifierTextureProvider.OnGetTextureForRender | ( | [TwoDimensionContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html) | *twoDimensionContext*, | |  |  | string | *name* ) | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#a501583e5aae387f14fe07ea9edaf478b)ForceRefreshTextures()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ImageIdentifiers.ImageIdentifierTextureProvider.ForceRefreshTextures | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#ae4a8cb21d453997dfca68abff333e8db)CreateImageWithId()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ImageIdentifiers.ImageIdentifierTextureProvider.CreateImageWithId | ( | string | *id*, |
|  |  | string | *additionalArgs* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#a49560412ab034a3b74682ff63db1f956)OnTextureCreated()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ImageIdentifiers.ImageIdentifierTextureProvider.OnTextureCreated | ( | [Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) | *texture* | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#aac9ea727768bb72201c457da251057d7)OnTextureCreationCancelled()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ImageIdentifiers.ImageIdentifierTextureProvider.OnTextureCreationCancelled | ( |  | ) |  | | protected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#aff958dce7d67630e0bf91f504e4cb029)ThumbnailCreationData
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ThumbnailCreationData TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ImageIdentifiers.ImageIdentifierTextureProvider.ThumbnailCreationData | | getsetprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#af91dc90186197e2728134b0ffb4c0c9c)IsReleased
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ImageIdentifiers.ImageIdentifierTextureProvider.IsReleased | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#a1fdcd8b389a6a92cb170d9ca01b00e7d)IsBig
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ImageIdentifiers.ImageIdentifierTextureProvider.IsBig | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#ad08172b9178ac2beb30b64c4664330ba)ImageId
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ImageIdentifiers.ImageIdentifierTextureProvider.ImageId | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#ac13b626cb2db717a6085539b845fc4d8)AdditionalArgs
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ImageIdentifiers.ImageIdentifierTextureProvider.AdditionalArgs | | getset |

