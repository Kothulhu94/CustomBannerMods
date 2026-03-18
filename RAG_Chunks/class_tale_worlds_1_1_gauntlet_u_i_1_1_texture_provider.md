--- SOURCE: class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html ---

TaleWorlds.GauntletUI.TextureProvider Class ReferenceabstractInherited by [SandBox.GauntletUI.MapConversationTextureProvider](class_sand_box_1_1_gauntlet_u_i_1_1_map_conversation_texture_provider.html), [TaleWorlds.GauntletUI.ResourceTextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_resource_texture_provider.html), [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.BannerTableauTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_banner_tableau_texture_provider.html), [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.BrightnessDemoTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_brightness_demo_texture_provider.html), [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.CharacterTableauTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html), [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ImageIdentifiers.ImageIdentifierTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html), [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ItemTableauTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_item_tableau_texture_provider.html), [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.OnlineImageTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_online_image_texture_provider.html), [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.SaveLoadHeroTableauTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_save_load_hero_tableau_texture_provider.html), and [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.SceneTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_scene_texture_provider.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| virtual void | [SetTargetSize](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#a1d840a6eb2069b6d62e59a37a7374393) (int width, int height) |
| [Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) | [GetTextureForRender](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#ade86cbe04ebe31e95f7022ddbcf9a4e7) ([TwoDimensionContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html) context, string name=null) |
| virtual void | [Tick](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#aa8e76bc61347b14690b39ec4897978ba) (float dt) |
| virtual void | [Clear](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#ad55ae18c49d5b0fd17fd72aa11cfff11) (bool clearNextFrame) |
| void | [SetProperty](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#aa1070ade9147c6089986a2a874d9a465) (string name, object value) |
| object | [GetProperty](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#a18435ef5f4aa4f0693498278fb76c6a2) (string name) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| [Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) | [OnGetTextureForRender](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#ac65b91fd4b9ccfb73220121fa7396844) ([TwoDimensionContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html) twoDimensionContext, string name) |

|  |  |
| --- | --- |
| Properties | |
| string | [SourceInfo](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#a3189b71ef4da6dfc199adddb1584191f) `[get, set]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#a1d840a6eb2069b6d62e59a37a7374393)SetTargetSize()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.GauntletUI.TextureProvider.SetTargetSize | ( | int | *width*, | |  |  | int | *height* ) | | virtual |

Reimplemented in [SandBox.GauntletUI.MapConversationTextureProvider](class_sand_box_1_1_gauntlet_u_i_1_1_map_conversation_texture_provider.html#a897f9ae178729fd5419c268236664d15), [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.BannerTableauTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_banner_tableau_texture_provider.html#a3f242ad6f37381a5f6145a63902601ba), [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.BrightnessDemoTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_brightness_demo_texture_provider.html#aea07dab7e851c49c141be9adc46a6c63), [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.CharacterTableauTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#adfeeeea1f2bd5cff5ad9438d2ccf2007), [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ItemTableauTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_item_tableau_texture_provider.html#ae1b098421c984a3b03e50707a7458080), [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.SaveLoadHeroTableauTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_save_load_hero_tableau_texture_provider.html#a7b989b5253ead926d61e43b17fcbaa5a), and [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.SceneTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_scene_texture_provider.html#a23d215570e175910edbf8527a7eb7909).

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#ade86cbe04ebe31e95f7022ddbcf9a4e7)GetTextureForRender()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) TaleWorlds.GauntletUI.TextureProvider.GetTextureForRender | ( | [TwoDimensionContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html) | *context*, |
|  |  | string | *name* = null ) |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#ac65b91fd4b9ccfb73220121fa7396844)OnGetTextureForRender()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) TaleWorlds.GauntletUI.TextureProvider.OnGetTextureForRender | ( | [TwoDimensionContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html) | *twoDimensionContext*, | |  |  | string | *name* ) | | abstractprotected |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#aa8e76bc61347b14690b39ec4897978ba)Tick()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.GauntletUI.TextureProvider.Tick | ( | float | *dt* | ) |  | | virtual |

Reimplemented in [SandBox.GauntletUI.MapConversationTextureProvider](class_sand_box_1_1_gauntlet_u_i_1_1_map_conversation_texture_provider.html#af0c115fe3bd27da0dbc04efd80a99aad), [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.BannerTableauTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_banner_tableau_texture_provider.html#a92366e76fe8f1f50b0b9204f3e3ae41f), [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.BrightnessDemoTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_brightness_demo_texture_provider.html#abeca7fe1bc06a2b832d827d61fc73f30), [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.CharacterTableauTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#ab2d5f0c1b6d72a944ec0ef3c17ee9d44), [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ImageIdentifiers.ImageIdentifierTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#af487c8c926f1afbdd9a447d34a3fa9b0), [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ImageIdentifiers.PlayerAvatarImageTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifiecc3cd9c7e1ef7574ec7fe15370c47d8d.html#ad0a5e03ea16dd02fc130fdd5a0f81f3c), [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ItemTableauTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_item_tableau_texture_provider.html#a307d7bddac8c9d0ac8c9fc9181d9d387), [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.OnlineImageTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_online_image_texture_provider.html#a0e4ed208008e385e33f37eb23c1bb603), [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.SaveLoadHeroTableauTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_save_load_hero_tableau_texture_provider.html#a9cb7000301fbc0f71f55b26111e707a8), and [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.SceneTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_scene_texture_provider.html#ac8f8ee5f6a67272891febad269c26720).

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#ad55ae18c49d5b0fd17fd72aa11cfff11)Clear()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.GauntletUI.TextureProvider.Clear | ( | bool | *clearNextFrame* | ) |  | | virtual |

Reimplemented in [SandBox.GauntletUI.MapConversationTextureProvider](class_sand_box_1_1_gauntlet_u_i_1_1_map_conversation_texture_provider.html#add1254314d3d4c4c658639b6b0c974b3), [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.BannerTableauTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_banner_tableau_texture_provider.html#a1fefda7ee1cc8b391653c6681373fdd2), [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.BrightnessDemoTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_brightness_demo_texture_provider.html#a7c8fde53ba7bda00ee5bc960dee74be5), [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.CharacterTableauTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#a609fb8f4ae2bb59f572a1cf9c33020a7), [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ImageIdentifiers.ImageIdentifierTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_image_identifie40482c117d668f0a8455582dbc6a6037.html#a52505a82b366c8f00a748463edc0ae72), [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ItemTableauTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_item_tableau_texture_provider.html#a8a829f23882f8d3b022f85ccc5045d6a), and [TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.SaveLoadHeroTableauTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_save_load_hero_tableau_texture_provider.html#a713821cb32440659741c0ac9f06049ba).

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#aa1070ade9147c6089986a2a874d9a465)SetProperty()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.TextureProvider.SetProperty | ( | string | *name*, |
|  |  | object | *value* ) |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#a18435ef5f4aa4f0693498278fb76c6a2)GetProperty()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| object TaleWorlds.GauntletUI.TextureProvider.GetProperty | ( | string | *name* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#a3189b71ef4da6dfc199adddb1584191f)SourceInfo
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.GauntletUI.TextureProvider.SourceInfo | | getset |

