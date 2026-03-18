--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_item_tableau_texture_provider.html ---

TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ItemTableauTextureProvider Class ReferenceInherits [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ItemTableauTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_item_tableau_texture_provider.html#afae0f273a830976253f193e3d8048fac) () |
| override void | [Clear](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_item_tableau_texture_provider.html#a8a829f23882f8d3b022f85ccc5045d6a) (bool clearNextFrame) |
| override void | [SetTargetSize](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_item_tableau_texture_provider.html#ae1b098421c984a3b03e50707a7458080) (int width, int height) |
| override void | [Tick](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_item_tableau_texture_provider.html#a307d7bddac8c9d0ac8c9fc9181d9d387) (float dt) |
| Public Member Functions inherited from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html) | |
| [Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) | [GetTextureForRender](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#ade86cbe04ebe31e95f7022ddbcf9a4e7) ([TwoDimensionContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html) context, string name=null) |
| void | [SetProperty](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#aa1070ade9147c6089986a2a874d9a465) (string name, object value) |
| object | [GetProperty](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#a18435ef5f4aa4f0693498278fb76c6a2) (string name) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override [TwoDimension.Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) | [OnGetTextureForRender](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_item_tableau_texture_provider.html#a5eb553f98057b60aa90181b73b722277) ([TwoDimensionContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html) twoDimensionContext, string name) |
| Protected Member Functions inherited from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html) | |
| [Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) | [OnGetTextureForRender](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#ac65b91fd4b9ccfb73220121fa7396844) ([TwoDimensionContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html) twoDimensionContext, string name) |

|  |  |
| --- | --- |
| Properties | |
| string | [ItemModifierId](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_item_tableau_texture_provider.html#a01c36f335707852520d852bf769a153a) `[set]` |
| string | [StringId](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_item_tableau_texture_provider.html#adc2662903d793eff20e4577ba39c01bf) `[set]` |
| [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) | [Item](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_item_tableau_texture_provider.html#a9dcebbd493b462d7f2c39e21cbfa95c3) `[set]` |
| int | [Ammo](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_item_tableau_texture_provider.html#a5d846a1113be297480ef0e91702bed73) `[set]` |
| int | [AverageUnitCost](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_item_tableau_texture_provider.html#a33313709bc7101de75f93e8a96514cef) `[set]` |
| string | [BannerCode](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_item_tableau_texture_provider.html#a6d755acebd8f6e56fe272aa20ee25bc4) `[set]` |
| bool | [CurrentlyRotating](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_item_tableau_texture_provider.html#afb36496e0578022a93a95b6d23853e92) `[set]` |
| float | [RotateItemVertical](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_item_tableau_texture_provider.html#a32fa3cca0c6d746e282874e41b2ea2b0) `[set]` |
| float | [RotateItemHorizontal](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_item_tableau_texture_provider.html#aa3b565728bde59fed716aba9b577fbc0) `[set]` |
| float | [InitialTiltRotation](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_item_tableau_texture_provider.html#ae2e9b1d4b48bdfc5259ab378c46b0153) `[set]` |
| float | [InitialPanRotation](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_item_tableau_texture_provider.html#a1a9488af8fb137abdfe0f45662390069) `[set]` |
| Properties inherited from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html) | |
| string | [SourceInfo](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#a3189b71ef4da6dfc199adddb1584191f) `[get, set]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_item_tableau_texture_provider.html#afae0f273a830976253f193e3d8048fac)ItemTableauTextureProvider()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ItemTableauTextureProvider.ItemTableauTextureProvider | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_item_tableau_texture_provider.html#a8a829f23882f8d3b022f85ccc5045d6a)Clear()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ItemTableauTextureProvider.Clear | ( | bool | *clearNextFrame* | ) |  | | virtual |

Reimplemented from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#ad55ae18c49d5b0fd17fd72aa11cfff11).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_item_tableau_texture_provider.html#a5eb553f98057b60aa90181b73b722277)OnGetTextureForRender()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override [TwoDimension.Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ItemTableauTextureProvider.OnGetTextureForRender | ( | [TwoDimensionContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html) | *twoDimensionContext*, | |  |  | string | *name* ) | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_item_tableau_texture_provider.html#ae1b098421c984a3b03e50707a7458080)SetTargetSize()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ItemTableauTextureProvider.SetTargetSize | ( | int | *width*, | |  |  | int | *height* ) | | virtual |

Reimplemented from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#a1d840a6eb2069b6d62e59a37a7374393).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_item_tableau_texture_provider.html#a307d7bddac8c9d0ac8c9fc9181d9d387)Tick()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ItemTableauTextureProvider.Tick | ( | float | *dt* | ) |  | | virtual |

Reimplemented from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#aa8e76bc61347b14690b39ec4897978ba).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_item_tableau_texture_provider.html#a01c36f335707852520d852bf769a153a)ItemModifierId
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ItemTableauTextureProvider.ItemModifierId | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_item_tableau_texture_provider.html#adc2662903d793eff20e4577ba39c01bf)StringId
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ItemTableauTextureProvider.StringId | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_item_tableau_texture_provider.html#a9dcebbd493b462d7f2c39e21cbfa95c3)Item
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ItemTableauTextureProvider.Item | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_item_tableau_texture_provider.html#a5d846a1113be297480ef0e91702bed73)Ammo
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ItemTableauTextureProvider.Ammo | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_item_tableau_texture_provider.html#a33313709bc7101de75f93e8a96514cef)AverageUnitCost
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ItemTableauTextureProvider.AverageUnitCost | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_item_tableau_texture_provider.html#a6d755acebd8f6e56fe272aa20ee25bc4)BannerCode
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ItemTableauTextureProvider.BannerCode | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_item_tableau_texture_provider.html#afb36496e0578022a93a95b6d23853e92)CurrentlyRotating
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ItemTableauTextureProvider.CurrentlyRotating | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_item_tableau_texture_provider.html#a32fa3cca0c6d746e282874e41b2ea2b0)RotateItemVertical
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ItemTableauTextureProvider.RotateItemVertical | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_item_tableau_texture_provider.html#aa3b565728bde59fed716aba9b577fbc0)RotateItemHorizontal
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ItemTableauTextureProvider.RotateItemHorizontal | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_item_tableau_texture_provider.html#ae2e9b1d4b48bdfc5259ab378c46b0153)InitialTiltRotation
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ItemTableauTextureProvider.InitialTiltRotation | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_item_tableau_texture_provider.html#a1a9488af8fb137abdfe0f45662390069)InitialPanRotation
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.ItemTableauTextureProvider.InitialPanRotation | | set |

