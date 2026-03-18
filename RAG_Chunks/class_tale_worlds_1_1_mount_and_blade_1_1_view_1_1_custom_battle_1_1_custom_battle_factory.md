--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_custom_battle_1_1_custom_battle_factory.html ---

TaleWorlds.MountAndBlade.View.CustomBattle.CustomBattleFactory Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [RegisterProvider< T >](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_custom_battle_1_1_custom_battle_factory.html#a2bc9905000e847fc7d82aaa6466753b4) () |
| static void | [StartCustomBattleWithProvider< T >](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_custom_battle_1_1_custom_battle_factory.html#a0305ca197bca338027a1604f9fc242d2) () |
| static void | [StartCustomBattle](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_custom_battle_1_1_custom_battle_factory.html#a23c07bb134e0d66bc86757893ea5588b) () |
| static int | [GetProviderCount](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_custom_battle_1_1_custom_battle_factory.html#a8c2c631d04ce3017c9ff6c406b58a1d5) () |
| static List< [ICustomBattleProvider](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_custom_battle_1_1_i_custom_battle_provider.html) > | [CollectProviders](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_custom_battle_1_1_custom_battle_factory.html#ad72bb47908737dca2ff0d09a693a366d) () |
| static [ICustomBattleProvider](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_custom_battle_1_1_i_custom_battle_provider.html) | [CollectNextProvider](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_custom_battle_1_1_custom_battle_factory.html#ac9d091f9bcf60d9490f34c06cda029e9) (Type currentProviderType) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_custom_battle_1_1_custom_battle_factory.html#a2bc9905000e847fc7d82aaa6466753b4)RegisterProvider< T >()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.View.CustomBattle.CustomBattleFactory.RegisterProvider< T > | ( |  | ) |  | | static |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[ICustomBattleProvider](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_custom_battle_1_1_i_custom_battle_provider.html)* |  |
    | *T* | : | *new()* |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_custom_battle_1_1_custom_battle_factory.html#a0305ca197bca338027a1604f9fc242d2)StartCustomBattleWithProvider< T >()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.View.CustomBattle.CustomBattleFactory.StartCustomBattleWithProvider< T > | ( |  | ) |  | | static |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[ICustomBattleProvider](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_custom_battle_1_1_i_custom_battle_provider.html)* |  |
    | *T* | : | *new()* |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_custom_battle_1_1_custom_battle_factory.html#a23c07bb134e0d66bc86757893ea5588b)StartCustomBattle()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.View.CustomBattle.CustomBattleFactory.StartCustomBattle | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_custom_battle_1_1_custom_battle_factory.html#a8c2c631d04ce3017c9ff6c406b58a1d5)GetProviderCount()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.View.CustomBattle.CustomBattleFactory.GetProviderCount | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_custom_battle_1_1_custom_battle_factory.html#ad72bb47908737dca2ff0d09a693a366d)CollectProviders()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | List< [ICustomBattleProvider](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_custom_battle_1_1_i_custom_battle_provider.html) > TaleWorlds.MountAndBlade.View.CustomBattle.CustomBattleFactory.CollectProviders | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_custom_battle_1_1_custom_battle_factory.html#ac9d091f9bcf60d9490f34c06cda029e9)CollectNextProvider()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [ICustomBattleProvider](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_custom_battle_1_1_i_custom_battle_provider.html) TaleWorlds.MountAndBlade.View.CustomBattle.CustomBattleFactory.CollectNextProvider | ( | Type | *currentProviderType* | ) |  | | static |

