--- SOURCE: class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_notification_view.html ---

SandBox.GauntletUI.Map.GauntletMapNotificationView Class ReferenceInherits [SandBox.View.Map.MapNotificationView](class_sand_box_1_1_view_1_1_map_1_1_map_notification_view.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [GauntletMapNotificationView](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_notification_view.html#aac907c1e68e46724eb633d25453ba29e) () |
| override void | [RegisterMapNotificationType](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_notification_view.html#a7dfcdc48807bcf49e3d7a4f27e2018d6) (Type data, Type item) |
| override void | [ResetNotifications](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_notification_view.html#aae99db715188094b5557f3cd50ba1d10) () |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [CreateLayout](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_notification_view.html#a3612418d45fcbb2f0e02d5320c739c7a) () |
| override void | [OnFinalize](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_notification_view.html#a1ef9dca2208347857f4df34a29c38d1a) () |
| override void | [OnFrameTick](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_notification_view.html#a156156ec5e733783fd82d20c4f32daea) (float dt) |
| override void | [OnMenuModeTick](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_notification_view.html#a1124f34d448a4dd883289f7b840840d1) (float dt) |
| override void | [OnMapConversationStart](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_notification_view.html#a5241c9206772bef4ebe878a6352c95fb) () |
| override void | [OnMapConversationOver](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_notification_view.html#a89a4d5b6bb80adc2d1e823cb76ac6473) () |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Protected Attributes inherited from [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html) | |
| const float | [ContextAlphaModifier](class_sand_box_1_1_view_1_1_map_1_1_map_view.html#a9efbb55b721c1331986ba14d416c84f6) = 8.5f |
| Properties inherited from [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html) | |
| MapScreen | [MapScreen](class_sand_box_1_1_view_1_1_map_1_1_map_view.html#af4f77c9eec549e6d57cb4667f09ea0b4) `[get]` |
| MapState | [MapState](class_sand_box_1_1_view_1_1_map_1_1_map_view.html#abf6624dfb0331164523cae87d042e691) `[get]` |
| Properties inherited from [SandBox.View.SandboxView](class_sand_box_1_1_view_1_1_sandbox_view.html) | |
| bool | [IsFinalized](class_sand_box_1_1_view_1_1_sandbox_view.html#a5807fb2c109c6715d7fae1a6cf2f4693) `[get, protected set]` |
| ScreenLayer | [Layer](class_sand_box_1_1_view_1_1_sandbox_view.html#a070dec1267ecf8ff4afadffc12374024) `[get, protected set]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_notification_view.html#aac907c1e68e46724eb633d25453ba29e)GauntletMapNotificationView()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| SandBox.GauntletUI.Map.GauntletMapNotificationView.GauntletMapNotificationView | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_notification_view.html#a3612418d45fcbb2f0e02d5320c739c7a)CreateLayout()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Map.GauntletMapNotificationView.CreateLayout | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_notification_view.html#a7dfcdc48807bcf49e3d7a4f27e2018d6)RegisterMapNotificationType()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void SandBox.GauntletUI.Map.GauntletMapNotificationView.RegisterMapNotificationType | ( | Type | *data*, | |  |  | Type | *item* ) | | virtual |

Reimplemented from [SandBox.View.Map.MapNotificationView](class_sand_box_1_1_view_1_1_map_1_1_map_notification_view.html#a31fe13cbc3fb30e0fc94ea4f0c077859).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_notification_view.html#a1ef9dca2208347857f4df34a29c38d1a)OnFinalize()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Map.GauntletMapNotificationView.OnFinalize | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.SandboxView](class_sand_box_1_1_view_1_1_sandbox_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_notification_view.html#a156156ec5e733783fd82d20c4f32daea)OnFrameTick()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Map.GauntletMapNotificationView.OnFrameTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.SandboxView](class_sand_box_1_1_view_1_1_sandbox_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_notification_view.html#a1124f34d448a4dd883289f7b840840d1)OnMenuModeTick()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Map.GauntletMapNotificationView.OnMenuModeTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_notification_view.html#a5241c9206772bef4ebe878a6352c95fb)OnMapConversationStart()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Map.GauntletMapNotificationView.OnMapConversationStart | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_notification_view.html#a89a4d5b6bb80adc2d1e823cb76ac6473)OnMapConversationOver()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Map.GauntletMapNotificationView.OnMapConversationOver | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_notification_view.html#aae99db715188094b5557f3cd50ba1d10)ResetNotifications()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Map.GauntletMapNotificationView.ResetNotifications | ( |  | ) |  | | virtual |

Reimplemented from [SandBox.View.Map.MapNotificationView](class_sand_box_1_1_view_1_1_map_1_1_map_notification_view.html#af24031abc7c02a25f614e3d531f4b0bc).

