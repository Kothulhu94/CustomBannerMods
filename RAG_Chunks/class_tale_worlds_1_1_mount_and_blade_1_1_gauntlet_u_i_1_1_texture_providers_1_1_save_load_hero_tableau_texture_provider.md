--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_save_load_hero_tableau_texture_provider.html ---

TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.SaveLoadHeroTableauTextureProvider Class ReferenceInherits [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [SaveLoadHeroTableauTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_save_load_hero_tableau_texture_provider.html#a70f09bade4bb11652daf8b6a1b3e6725) () |
| override void | [Tick](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_save_load_hero_tableau_texture_provider.html#a9cb7000301fbc0f71f55b26111e707a8) (float dt) |
| override void | [SetTargetSize](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_save_load_hero_tableau_texture_provider.html#a7b989b5253ead926d61e43b17fcbaa5a) (int width, int height) |
| override void | [Clear](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_save_load_hero_tableau_texture_provider.html#a713821cb32440659741c0ac9f06049ba) (bool clearNextFrame) |
| Public Member Functions inherited from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html) | |
| [Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) | [GetTextureForRender](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#ade86cbe04ebe31e95f7022ddbcf9a4e7) ([TwoDimensionContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html) context, string name=null) |
| void | [SetProperty](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#aa1070ade9147c6089986a2a874d9a465) (string name, object value) |
| object | [GetProperty](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#a18435ef5f4aa4f0693498278fb76c6a2) (string name) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override [Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) | [OnGetTextureForRender](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_save_load_hero_tableau_texture_provider.html#a765ad0afaba51a417173ab2bc2444d98) ([TwoDimensionContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html) twoDimensionContext, string name) |
| Protected Member Functions inherited from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html) | |
| [Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) | [OnGetTextureForRender](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#ac65b91fd4b9ccfb73220121fa7396844) ([TwoDimensionContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html) twoDimensionContext, string name) |

|  |  |
| --- | --- |
| Properties | |
| string | [HeroVisualCode](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_save_load_hero_tableau_texture_provider.html#a6f4f4f9acf642b439b56dd5ad7364789) `[set]` |
| string | [BannerCode](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_save_load_hero_tableau_texture_provider.html#a2eb7f29dc0e03dbcbd7b87837d68e52f) `[set]` |
| bool | [IsVersionCompatible](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_save_load_hero_tableau_texture_provider.html#aa7c0afc14f10ee424233100b7316c9d1) `[get]` |
| bool | [CurrentlyRotating](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_save_load_hero_tableau_texture_provider.html#a50e717c7fd37dbf1c25e5a06713cf5f2) `[set]` |
| Properties inherited from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html) | |
| string | [SourceInfo](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#a3189b71ef4da6dfc199adddb1584191f) `[get, set]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_save_load_hero_tableau_texture_provider.html#a70f09bade4bb11652daf8b6a1b3e6725)SaveLoadHeroTableauTextureProvider()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.SaveLoadHeroTableauTextureProvider.SaveLoadHeroTableauTextureProvider | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_save_load_hero_tableau_texture_provider.html#a9cb7000301fbc0f71f55b26111e707a8)Tick()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.SaveLoadHeroTableauTextureProvider.Tick | ( | float | *dt* | ) |  | | virtual |

Reimplemented from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#aa8e76bc61347b14690b39ec4897978ba).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_save_load_hero_tableau_texture_provider.html#a7b989b5253ead926d61e43b17fcbaa5a)SetTargetSize()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.SaveLoadHeroTableauTextureProvider.SetTargetSize | ( | int | *width*, | |  |  | int | *height* ) | | virtual |

Reimplemented from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#a1d840a6eb2069b6d62e59a37a7374393).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_save_load_hero_tableau_texture_provider.html#a713821cb32440659741c0ac9f06049ba)Clear()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.SaveLoadHeroTableauTextureProvider.Clear | ( | bool | *clearNextFrame* | ) |  | | virtual |

Reimplemented from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#ad55ae18c49d5b0fd17fd72aa11cfff11).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_save_load_hero_tableau_texture_provider.html#a765ad0afaba51a417173ab2bc2444d98)OnGetTextureForRender()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override [Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.SaveLoadHeroTableauTextureProvider.OnGetTextureForRender | ( | [TwoDimensionContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html) | *twoDimensionContext*, | |  |  | string | *name* ) | | protected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_save_load_hero_tableau_texture_provider.html#a6f4f4f9acf642b439b56dd5ad7364789)HeroVisualCode
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.SaveLoadHeroTableauTextureProvider.HeroVisualCode | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_save_load_hero_tableau_texture_provider.html#a2eb7f29dc0e03dbcbd7b87837d68e52f)BannerCode
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.SaveLoadHeroTableauTextureProvider.BannerCode | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_save_load_hero_tableau_texture_provider.html#aa7c0afc14f10ee424233100b7316c9d1)IsVersionCompatible
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.SaveLoadHeroTableauTextureProvider.IsVersionCompatible | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_save_load_hero_tableau_texture_provider.html#a50e717c7fd37dbf1c25e5a06713cf5f2)CurrentlyRotating
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.SaveLoadHeroTableauTextureProvider.CurrentlyRotating | | set |

