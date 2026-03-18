--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_game_notification.html ---

TaleWorlds.MountAndBlade.GauntletUI.GauntletGameNotification Class ReferenceInherits GlobalLayer.

Inherited by [SandBox.GauntletUI.SandBoxGauntletGameNotification](class_sand_box_1_1_gauntlet_u_i_1_1_sand_box_gauntlet_game_notification.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| virtual void | [OnFinalize](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_game_notification.html#ab2048869ffcfc2e62d57376948802738) () |
| virtual void | [RegisterEvents](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_game_notification.html#ac1d260cea6a5facea7366f616ab43afc) () |
| virtual void | [UnregisterEvents](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_game_notification.html#a568b02c81f5bcba881c6957f5f8c960a) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [Initialize](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_game_notification.html#ae2839d8ca2f7284e2307601cd2945ed6) () |

|  |  |
| --- | --- |
| Protected Member Functions | |
|  | [GauntletGameNotification](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_game_notification.html#a78506a27351dd54f6e5d86a39298236e) () |
| virtual void | [OnReceiveNewNotification](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_game_notification.html#a23a10144d95bf2a01f70a44a5754268b) ([GameNotificationItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_game_notification_item_v_m.html) notification) |
| override void | [OnTick](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_game_notification.html#a48bf80cce887f6be04e8dcb8c4289c45) (float dt) |
| virtual bool | [GetShouldBeSuspended](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_game_notification.html#a63a2432af65bd24a375b42321bbd0299) () |

|  |  |
| --- | --- |
| Protected Attributes | |
| [GameNotificationVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_game_notification_v_m.html) | [\_dataSource](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_game_notification.html#a3e65f71e4992bd9dc36c6c284984dccc) |

|  |  |
| --- | --- |
| Properties | |
| static [GauntletGameNotification](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_game_notification.html#a78506a27351dd54f6e5d86a39298236e) | [Current](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_game_notification.html#aa09c134368e8fc15c4eb6dd4278cd9b0) `[get, set]` |
| virtual string | [MovieName](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_game_notification.html#a1bf26f50570bfeb1b9d680190168a6ec) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_game_notification.html#a78506a27351dd54f6e5d86a39298236e)GauntletGameNotification()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | TaleWorlds.MountAndBlade.GauntletUI.GauntletGameNotification.GauntletGameNotification | ( |  | ) |  | | protected |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_game_notification.html#a23a10144d95bf2a01f70a44a5754268b)OnReceiveNewNotification()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.GauntletUI.GauntletGameNotification.OnReceiveNewNotification | ( | [GameNotificationItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_game_notification_item_v_m.html) | *notification* | ) |  | | protectedvirtual |

Reimplemented in [SandBox.GauntletUI.SandBoxGauntletGameNotification](class_sand_box_1_1_gauntlet_u_i_1_1_sand_box_gauntlet_game_notification.html#a3851654adff7c359089f151df45f380c).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_game_notification.html#ae2839d8ca2f7284e2307601cd2945ed6)Initialize()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GauntletUI.GauntletGameNotification.Initialize | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_game_notification.html#ab2048869ffcfc2e62d57376948802738)OnFinalize()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.GauntletUI.GauntletGameNotification.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented in [SandBox.GauntletUI.SandBoxGauntletGameNotification](class_sand_box_1_1_gauntlet_u_i_1_1_sand_box_gauntlet_game_notification.html#a86a43da0b59bf9ea45c926ecd99dfe06).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_game_notification.html#ac1d260cea6a5facea7366f616ab43afc)RegisterEvents()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.GauntletUI.GauntletGameNotification.RegisterEvents | ( |  | ) |  | | virtual |

Reimplemented in [SandBox.GauntletUI.SandBoxGauntletGameNotification](class_sand_box_1_1_gauntlet_u_i_1_1_sand_box_gauntlet_game_notification.html#a62b4e1e9f3728509a6269245b3f627ed).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_game_notification.html#a568b02c81f5bcba881c6957f5f8c960a)UnregisterEvents()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.GauntletUI.GauntletGameNotification.UnregisterEvents | ( |  | ) |  | | virtual |

Reimplemented in [SandBox.GauntletUI.SandBoxGauntletGameNotification](class_sand_box_1_1_gauntlet_u_i_1_1_sand_box_gauntlet_game_notification.html#a7c4292654bfd202d2958d2de0f9fe8dd).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_game_notification.html#a48bf80cce887f6be04e8dcb8c4289c45)OnTick()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.GauntletUI.GauntletGameNotification.OnTick | ( | float | *dt* | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_game_notification.html#a63a2432af65bd24a375b42321bbd0299)GetShouldBeSuspended()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual bool TaleWorlds.MountAndBlade.GauntletUI.GauntletGameNotification.GetShouldBeSuspended | ( |  | ) |  | | protectedvirtual |

Reimplemented in [SandBox.GauntletUI.SandBoxGauntletGameNotification](class_sand_box_1_1_gauntlet_u_i_1_1_sand_box_gauntlet_game_notification.html#afee5376bfa74f00a30665d01c9876088).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_game_notification.html#a3e65f71e4992bd9dc36c6c284984dccc)\_dataSource
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GameNotificationVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_game_notification_v_m.html) TaleWorlds.MountAndBlade.GauntletUI.GauntletGameNotification.\_dataSource | | protected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_game_notification.html#aa09c134368e8fc15c4eb6dd4278cd9b0)Current
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GauntletGameNotification](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_game_notification.html#a78506a27351dd54f6e5d86a39298236e) TaleWorlds.MountAndBlade.GauntletUI.GauntletGameNotification.Current | | staticgetsetprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_game_notification.html#a1bf26f50570bfeb1b9d680190168a6ec)MovieName
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual string TaleWorlds.MountAndBlade.GauntletUI.GauntletGameNotification.MovieName | | getprotected |

