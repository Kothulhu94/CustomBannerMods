--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html ---

TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.CharacterTableauTextureProvider Class ReferenceInherits [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [CharacterTableauTextureProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#af514bc1fde4f86b80bf8b315ebcb0a28) () |
| override void | [Clear](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#a609fb8f4ae2bb59f572a1cf9c33020a7) (bool clearNextFrame) |
| override void | [SetTargetSize](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#adfeeeea1f2bd5cff5ad9438d2ccf2007) (int width, int height) |
| override void | [Tick](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#ab2d5f0c1b6d72a944ec0ef3c17ee9d44) (float dt) |
| Public Member Functions inherited from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html) | |
| [Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) | [GetTextureForRender](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#ade86cbe04ebe31e95f7022ddbcf9a4e7) ([TwoDimensionContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html) context, string name=null) |
| void | [SetProperty](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#aa1070ade9147c6089986a2a874d9a465) (string name, object value) |
| object | [GetProperty](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#a18435ef5f4aa4f0693498278fb76c6a2) (string name) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override [TwoDimension.Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) | [OnGetTextureForRender](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#a7b861428a43e0c12e57faff1bc8d34e4) ([TwoDimensionContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html) twoDimensionContext, string name) |
| Protected Member Functions inherited from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html) | |
| [Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) | [OnGetTextureForRender](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#ac65b91fd4b9ccfb73220121fa7396844) ([TwoDimensionContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html) twoDimensionContext, string name) |

|  |  |
| --- | --- |
| Properties | |
| float | [CustomAnimationProgressRatio](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#a16dfa10fdbd3e51aac2be33980e31420) `[get]` |
| string | [BannerCodeText](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#a35bd49baeffd88a923458e027a139c93) `[set]` |
| string | [BodyProperties](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#af09a4fbafa6908e43bcd5e439280e6e5) `[set]` |
| int | [StanceIndex](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#ab68604d261382470584a4e97c3bc44ec) `[set]` |
| bool | [IsFemale](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#a00be60d6caa778b271a779af6beff5b3) `[set]` |
| int | [Race](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#ab034752491538beb25841d88cbe5fed9) `[set]` |
| bool | [IsBannerShownInBackground](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#a210a9c30ba44ea20416df045aadeff02) `[set]` |
| bool | [IsEquipmentAnimActive](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#afa1e8a275f01e280a671c2fdbae2a8c1) `[set]` |
| string | [EquipmentCode](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#af8953831e3c01710815415c6b40789f4) `[set]` |
| string | [IdleAction](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#acbc95b559174e051f1de588d0cd9e6df) `[set]` |
| string | [IdleFaceAnim](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#a1292bbaeb3ff2a05345ecfe4e8d99280) `[set]` |
| bool | [CurrentlyRotating](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#a80d92a25f59aefd1645a4984449ada04) `[set]` |
| string | [MountCreationKey](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#aa32302fc9680270f19759a398df2fc04) `[set]` |
| uint | [ArmorColor1](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#acd9770aea0b15f0c4032a89c336d1528) `[set]` |
| uint | [ArmorColor2](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#a5bfa6c1f1917ccecfd55f49457aa0ee0) `[set]` |
| string | [CharStringId](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#a8ba2f6319b7b8a3c5b10af895082a1e2) `[set]` |
| bool | [TriggerCharacterMountPlacesSwap](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#a31704cb37b55e5bf6d38f5a0333d854c) `[set]` |
| float | [CustomRenderScale](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#ad6b093e5583169352890a4b36499c37a) `[set]` |
| bool | [IsPlayingCustomAnimations](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#ada52381da9e7e94bf22119fda97c1826) `[get, set]` |
| bool | [ShouldLoopCustomAnimation](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#aff7712eecbe4523a4aa44db8593915de) `[get, set]` |
| int | [LeftHandWieldedEquipmentIndex](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#a83056bbd4175326e126ccae1f4e13382) `[set]` |
| int | [RightHandWieldedEquipmentIndex](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#a497419e241755474ad7ff8cbd11962a7) `[set]` |
| float | [CustomAnimationWaitDuration](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#a9b2895d6efa2cf7bce4273fb12c292e8) `[set]` |
| string | [CustomAnimation](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#a3ab3dae7b200847b02d856fbabf4ab22) `[set]` |
| bool | [IsHidden](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#a70155f7f03d511ef980a7eff15b36bf5) `[get, set]` |
| Properties inherited from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html) | |
| string | [SourceInfo](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#a3189b71ef4da6dfc199adddb1584191f) `[get, set]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#af514bc1fde4f86b80bf8b315ebcb0a28)CharacterTableauTextureProvider()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.CharacterTableauTextureProvider.CharacterTableauTextureProvider | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#a609fb8f4ae2bb59f572a1cf9c33020a7)Clear()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.CharacterTableauTextureProvider.Clear | ( | bool | *clearNextFrame* | ) |  | | virtual |

Reimplemented from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#ad55ae18c49d5b0fd17fd72aa11cfff11).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#a7b861428a43e0c12e57faff1bc8d34e4)OnGetTextureForRender()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override [TwoDimension.Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.CharacterTableauTextureProvider.OnGetTextureForRender | ( | [TwoDimensionContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html) | *twoDimensionContext*, | |  |  | string | *name* ) | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#adfeeeea1f2bd5cff5ad9438d2ccf2007)SetTargetSize()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.CharacterTableauTextureProvider.SetTargetSize | ( | int | *width*, | |  |  | int | *height* ) | | virtual |

Reimplemented from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#a1d840a6eb2069b6d62e59a37a7374393).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#ab2d5f0c1b6d72a944ec0ef3c17ee9d44)Tick()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.CharacterTableauTextureProvider.Tick | ( | float | *dt* | ) |  | | virtual |

Reimplemented from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#aa8e76bc61347b14690b39ec4897978ba).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#a16dfa10fdbd3e51aac2be33980e31420)CustomAnimationProgressRatio
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.CharacterTableauTextureProvider.CustomAnimationProgressRatio | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#a35bd49baeffd88a923458e027a139c93)BannerCodeText
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.CharacterTableauTextureProvider.BannerCodeText | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#af09a4fbafa6908e43bcd5e439280e6e5)BodyProperties
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.CharacterTableauTextureProvider.BodyProperties | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#ab68604d261382470584a4e97c3bc44ec)StanceIndex
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.CharacterTableauTextureProvider.StanceIndex | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#a00be60d6caa778b271a779af6beff5b3)IsFemale
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.CharacterTableauTextureProvider.IsFemale | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#ab034752491538beb25841d88cbe5fed9)Race
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.CharacterTableauTextureProvider.Race | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#a210a9c30ba44ea20416df045aadeff02)IsBannerShownInBackground
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.CharacterTableauTextureProvider.IsBannerShownInBackground | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#afa1e8a275f01e280a671c2fdbae2a8c1)IsEquipmentAnimActive
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.CharacterTableauTextureProvider.IsEquipmentAnimActive | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#af8953831e3c01710815415c6b40789f4)EquipmentCode
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.CharacterTableauTextureProvider.EquipmentCode | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#acbc95b559174e051f1de588d0cd9e6df)IdleAction
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.CharacterTableauTextureProvider.IdleAction | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#a1292bbaeb3ff2a05345ecfe4e8d99280)IdleFaceAnim
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.CharacterTableauTextureProvider.IdleFaceAnim | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#a80d92a25f59aefd1645a4984449ada04)CurrentlyRotating
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.CharacterTableauTextureProvider.CurrentlyRotating | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#aa32302fc9680270f19759a398df2fc04)MountCreationKey
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.CharacterTableauTextureProvider.MountCreationKey | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#acd9770aea0b15f0c4032a89c336d1528)ArmorColor1
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.CharacterTableauTextureProvider.ArmorColor1 | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#a5bfa6c1f1917ccecfd55f49457aa0ee0)ArmorColor2
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.CharacterTableauTextureProvider.ArmorColor2 | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#a8ba2f6319b7b8a3c5b10af895082a1e2)CharStringId
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.CharacterTableauTextureProvider.CharStringId | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#a31704cb37b55e5bf6d38f5a0333d854c)TriggerCharacterMountPlacesSwap
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.CharacterTableauTextureProvider.TriggerCharacterMountPlacesSwap | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#ad6b093e5583169352890a4b36499c37a)CustomRenderScale
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.CharacterTableauTextureProvider.CustomRenderScale | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#ada52381da9e7e94bf22119fda97c1826)IsPlayingCustomAnimations
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.CharacterTableauTextureProvider.IsPlayingCustomAnimations | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#aff7712eecbe4523a4aa44db8593915de)ShouldLoopCustomAnimation
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.CharacterTableauTextureProvider.ShouldLoopCustomAnimation | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#a83056bbd4175326e126ccae1f4e13382)LeftHandWieldedEquipmentIndex
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.CharacterTableauTextureProvider.LeftHandWieldedEquipmentIndex | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#a497419e241755474ad7ff8cbd11962a7)RightHandWieldedEquipmentIndex
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.CharacterTableauTextureProvider.RightHandWieldedEquipmentIndex | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#a9b2895d6efa2cf7bce4273fb12c292e8)CustomAnimationWaitDuration
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.CharacterTableauTextureProvider.CustomAnimationWaitDuration | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#a3ab3dae7b200847b02d856fbabf4ab22)CustomAnimation
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.CharacterTableauTextureProvider.CustomAnimation | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_texture_providers_1_1_character_tableau_texture_provider.html#a70155f7f03d511ef980a7eff15b36bf5)IsHidden
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.GauntletUI.TextureProviders.CharacterTableauTextureProvider.IsHidden | | getset |

