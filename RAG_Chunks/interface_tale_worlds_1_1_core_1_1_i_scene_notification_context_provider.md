--- SOURCE: interface_tale_worlds_1_1_core_1_1_i_scene_notification_context_provider.html ---

TaleWorlds.Core.ISceneNotificationContextProvider Interface ReferenceInherited by [SandBox.GauntletUI.SandboxSceneNotificationContextProvider](class_sand_box_1_1_gauntlet_u_i_1_1_sandbox_scene_notification_context_provider.html), and [TaleWorlds.MountAndBlade.GauntletUI.SceneNotification.NativeSceneNotificationContextProvider](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_scene_notification_1_1_native_scene_notification_context_provider.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| bool | [IsContextAllowed](interface_tale_worlds_1_1_core_1_1_i_scene_notification_context_provider.html#a0c8c0876e129bf9211a0f8fc24db5427) ([SceneNotificationData.RelevantContextType](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#af8e737e2e18e86e26353861b970a9fad) relevantType) |
|  | Returns if the given context is allowed according to the context provider. e.g MP lobby context is not allowed while lobby is not active according to the native context provider. |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_core_1_1_i_scene_notification_context_provider.html#a0c8c0876e129bf9211a0f8fc24db5427)IsContextAllowed()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Core.ISceneNotificationContextProvider.IsContextAllowed | ( | [SceneNotificationData.RelevantContextType](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#af8e737e2e18e86e26353861b970a9fad) | *relevantType* | ) |  |

