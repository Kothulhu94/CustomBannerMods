--- SOURCE: class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_camera_fade_view.html ---

SandBox.GauntletUI.Map.GauntletMapCameraFadeView Class ReferenceInherits [SandBox.View.Map.MapCameraFadeView](class_sand_box_1_1_view_1_1_map_1_1_map_camera_fade_view.html).

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [CreateLayout](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_camera_fade_view.html#a34cca6d255976cb323688bc71955827c) () |
| override void | [OnFrameTick](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_camera_fade_view.html#a0432d87c83f24942853c5b03df97eb94) (float dt) |
| override void | [OnIdleTick](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_camera_fade_view.html#aba442178abcb14758a38b454ee32cf4b) (float dt) |
| override void | [OnMenuModeTick](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_camera_fade_view.html#a4e2b56e7acd10001abbc6a013d6af5d7) (float dt) |
| override void | [OnFinalize](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_camera_fade_view.html#a518855f4282fdc8ee6aedb839b474fc8) () |
| override void | [OnMapConversationStart](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_camera_fade_view.html#ad1d2f4eaaf5bad5cc2a4fcfa4acb6557) () |
| override void | [OnMapConversationOver](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_camera_fade_view.html#a006298e321e375d2338092faba521b1f) () |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Types inherited from [SandBox.View.Map.MapCameraFadeView](class_sand_box_1_1_view_1_1_map_1_1_map_camera_fade_view.html) | |
| enum | [CameraFadeState](class_sand_box_1_1_view_1_1_map_1_1_map_camera_fade_view.html#a51533d2025e77539f6e1a0db7ee6e5c9) {     [White](class_sand_box_1_1_view_1_1_map_1_1_map_camera_fade_view.html#a51533d2025e77539f6e1a0db7ee6e5c9a25a81701fbfa4a1efdf660a950c1d006) ,     [FadingOut](class_sand_box_1_1_view_1_1_map_1_1_map_camera_fade_view.html#a51533d2025e77539f6e1a0db7ee6e5c9a2ddb22b5f505aaafbe118c502a5a56ac) ,     [Black](class_sand_box_1_1_view_1_1_map_1_1_map_camera_fade_view.html#a51533d2025e77539f6e1a0db7ee6e5c9ae90dfb84e30edf611e326eeb04d680de) ,     [FadingIn](class_sand_box_1_1_view_1_1_map_1_1_map_camera_fade_view.html#a51533d2025e77539f6e1a0db7ee6e5c9a6830a6bcb5563d6b8ba7bafda3eda348)   } |
| Public Member Functions inherited from [SandBox.View.Map.MapCameraFadeView](class_sand_box_1_1_view_1_1_map_1_1_map_camera_fade_view.html) | |
| void | [BeginFadeOutAndIn](class_sand_box_1_1_view_1_1_map_1_1_map_camera_fade_view.html#ab02325dee5c985a9d239516f6a29c8ec) (float fadeOutTime, float blackTime, float fadeInTime) |
| void | [BeginFadeOut](class_sand_box_1_1_view_1_1_map_1_1_map_camera_fade_view.html#ac4f85e83fc354bacbab2cece1bd4f8a9) (float fadeOutTime) |
| void | [BeginFadeIn](class_sand_box_1_1_view_1_1_map_1_1_map_camera_fade_view.html#a46cad4de9ab7bcabd1405b3adf9388f1) (float fadeInTime) |
| Static Protected Attributes inherited from [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html) | |
| const float | [ContextAlphaModifier](class_sand_box_1_1_view_1_1_map_1_1_map_view.html#a9efbb55b721c1331986ba14d416c84f6) = 8.5f |
| Properties inherited from [SandBox.View.Map.MapCameraFadeView](class_sand_box_1_1_view_1_1_map_1_1_map_camera_fade_view.html) | |
| float | [FadeAlpha](class_sand_box_1_1_view_1_1_map_1_1_map_camera_fade_view.html#a1fe36f8e4c8c248fb729e2d49f2b8249) `[get]` |
| [CameraFadeState](class_sand_box_1_1_view_1_1_map_1_1_map_camera_fade_view.html#a51533d2025e77539f6e1a0db7ee6e5c9) | [FadeState](class_sand_box_1_1_view_1_1_map_1_1_map_camera_fade_view.html#ac67f394e6a10bb3b7cfdb331b3fb5251) `[get]` |
| bool | [IsCameraFading](class_sand_box_1_1_view_1_1_map_1_1_map_camera_fade_view.html#af57ad4bd62b99cac1f72f70a0baa88dc) `[get]` |
| bool | [HasCameraFadeOut](class_sand_box_1_1_view_1_1_map_1_1_map_camera_fade_view.html#a3945d476f86ab5dff219415caa071208) `[get]` |
| bool | [HasCameraFadeIn](class_sand_box_1_1_view_1_1_map_1_1_map_camera_fade_view.html#ab38924f0c17154875c64dbad8b2dd180) `[get]` |
| Properties inherited from [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html) | |
| MapScreen | [MapScreen](class_sand_box_1_1_view_1_1_map_1_1_map_view.html#af4f77c9eec549e6d57cb4667f09ea0b4) `[get]` |
| MapState | [MapState](class_sand_box_1_1_view_1_1_map_1_1_map_view.html#abf6624dfb0331164523cae87d042e691) `[get]` |
| Properties inherited from [SandBox.View.SandboxView](class_sand_box_1_1_view_1_1_sandbox_view.html) | |
| bool | [IsFinalized](class_sand_box_1_1_view_1_1_sandbox_view.html#a5807fb2c109c6715d7fae1a6cf2f4693) `[get, protected set]` |
| ScreenLayer | [Layer](class_sand_box_1_1_view_1_1_sandbox_view.html#a070dec1267ecf8ff4afadffc12374024) `[get, protected set]` |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_camera_fade_view.html#a34cca6d255976cb323688bc71955827c)CreateLayout()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Map.GauntletMapCameraFadeView.CreateLayout | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_camera_fade_view.html#a0432d87c83f24942853c5b03df97eb94)OnFrameTick()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Map.GauntletMapCameraFadeView.OnFrameTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.SandboxView](class_sand_box_1_1_view_1_1_sandbox_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_camera_fade_view.html#aba442178abcb14758a38b454ee32cf4b)OnIdleTick()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Map.GauntletMapCameraFadeView.OnIdleTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_camera_fade_view.html#a4e2b56e7acd10001abbc6a013d6af5d7)OnMenuModeTick()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Map.GauntletMapCameraFadeView.OnMenuModeTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_camera_fade_view.html#a518855f4282fdc8ee6aedb839b474fc8)OnFinalize()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Map.GauntletMapCameraFadeView.OnFinalize | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.SandboxView](class_sand_box_1_1_view_1_1_sandbox_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_camera_fade_view.html#ad1d2f4eaaf5bad5cc2a4fcfa4acb6557)OnMapConversationStart()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Map.GauntletMapCameraFadeView.OnMapConversationStart | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_camera_fade_view.html#a006298e321e375d2338092faba521b1f)OnMapConversationOver()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Map.GauntletMapCameraFadeView.OnMapConversationOver | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html).

