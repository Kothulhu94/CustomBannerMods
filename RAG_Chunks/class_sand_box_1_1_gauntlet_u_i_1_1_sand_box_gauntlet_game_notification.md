--- SOURCE: class_sand_box_1_1_gauntlet_u_i_1_1_sand_box_gauntlet_game_notification.html ---

SandBox.GauntletUI.SandBoxGauntletGameNotification Class ReferenceInherits [TaleWorlds.MountAndBlade.GauntletUI.GauntletGameNotification](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_game_notification.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [OnFinalize](class_sand_box_1_1_gauntlet_u_i_1_1_sand_box_gauntlet_game_notification.html#a86a43da0b59bf9ea45c926ecd99dfe06) () |
| override void | [RegisterEvents](class_sand_box_1_1_gauntlet_u_i_1_1_sand_box_gauntlet_game_notification.html#a62b4e1e9f3728509a6269245b3f627ed) () |
| override void | [UnregisterEvents](class_sand_box_1_1_gauntlet_u_i_1_1_sand_box_gauntlet_game_notification.html#a7c4292654bfd202d2958d2de0f9fe8dd) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static new void | [Initialize](class_sand_box_1_1_gauntlet_u_i_1_1_sand_box_gauntlet_game_notification.html#af784ff4a702e22972645e2d7f195bcdb) () |
| Static Public Member Functions inherited from [TaleWorlds.MountAndBlade.GauntletUI.GauntletGameNotification](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_game_notification.html) | |
| static void | [Initialize](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_game_notification.html#ae2839d8ca2f7284e2307601cd2945ed6) () |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnReceiveNewNotification](class_sand_box_1_1_gauntlet_u_i_1_1_sand_box_gauntlet_game_notification.html#a3851654adff7c359089f151df45f380c) ([GameNotificationItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_game_notification_item_v_m.html) notification) |
| override void | [OnTick](class_sand_box_1_1_gauntlet_u_i_1_1_sand_box_gauntlet_game_notification.html#a9adf0d1d9ccd45ead46b3cbb79397fe5) (float dt) |
| override bool | [GetShouldBeSuspended](class_sand_box_1_1_gauntlet_u_i_1_1_sand_box_gauntlet_game_notification.html#afee5376bfa74f00a30665d01c9876088) () |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.GauntletUI.GauntletGameNotification](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_game_notification.html) | |
|  | [GauntletGameNotification](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_game_notification.html#a78506a27351dd54f6e5d86a39298236e) () |
| override void | [OnTick](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_game_notification.html#a48bf80cce887f6be04e8dcb8c4289c45) (float dt) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Protected Attributes inherited from [TaleWorlds.MountAndBlade.GauntletUI.GauntletGameNotification](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_game_notification.html) | |
| [GameNotificationVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_game_notification_v_m.html) | [\_dataSource](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_game_notification.html#a3e65f71e4992bd9dc36c6c284984dccc) |
| Properties inherited from [TaleWorlds.MountAndBlade.GauntletUI.GauntletGameNotification](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_game_notification.html) | |
| static [GauntletGameNotification](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_game_notification.html#a78506a27351dd54f6e5d86a39298236e) | [Current](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_game_notification.html#aa09c134368e8fc15c4eb6dd4278cd9b0) `[get, set]` |
| virtual string | [MovieName](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_game_notification.html#a1bf26f50570bfeb1b9d680190168a6ec) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_sand_box_gauntlet_game_notification.html#af784ff4a702e22972645e2d7f195bcdb)Initialize()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | new void SandBox.GauntletUI.SandBoxGauntletGameNotification.Initialize | ( |  | ) |  | | static |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_sand_box_gauntlet_game_notification.html#a3851654adff7c359089f151df45f380c)OnReceiveNewNotification()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.SandBoxGauntletGameNotification.OnReceiveNewNotification | ( | [GameNotificationItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_game_notification_item_v_m.html) | *notification* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.GauntletUI.GauntletGameNotification](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_game_notification.html#a23a10144d95bf2a01f70a44a5754268b).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_sand_box_gauntlet_game_notification.html#a86a43da0b59bf9ea45c926ecd99dfe06)OnFinalize()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.SandBoxGauntletGameNotification.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.GauntletUI.GauntletGameNotification](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_game_notification.html#ab2048869ffcfc2e62d57376948802738).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_sand_box_gauntlet_game_notification.html#a62b4e1e9f3728509a6269245b3f627ed)RegisterEvents()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.SandBoxGauntletGameNotification.RegisterEvents | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.GauntletUI.GauntletGameNotification](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_game_notification.html#ac1d260cea6a5facea7366f616ab43afc).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_sand_box_gauntlet_game_notification.html#a7c4292654bfd202d2958d2de0f9fe8dd)UnregisterEvents()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.SandBoxGauntletGameNotification.UnregisterEvents | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.GauntletUI.GauntletGameNotification](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_game_notification.html#a568b02c81f5bcba881c6957f5f8c960a).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_sand_box_gauntlet_game_notification.html#a9adf0d1d9ccd45ead46b3cbb79397fe5)OnTick()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.SandBoxGauntletGameNotification.OnTick | ( | float | *dt* | ) |  | | protected |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_sand_box_gauntlet_game_notification.html#afee5376bfa74f00a30665d01c9876088)GetShouldBeSuspended()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override bool SandBox.GauntletUI.SandBoxGauntletGameNotification.GetShouldBeSuspended | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.GauntletUI.GauntletGameNotification](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_game_notification.html#a63a2432af65bd24a375b42321bbd0299).

