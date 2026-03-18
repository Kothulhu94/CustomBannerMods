--- SOURCE: class_sand_box_1_1_view_1_1_map_1_1_map_camera_fade_view.html ---

SandBox.View.Map.MapCameraFadeView Class ReferenceInherits [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html).

Inherited by [SandBox.GauntletUI.Map.GauntletMapCameraFadeView](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_camera_fade_view.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [CameraFadeState](class_sand_box_1_1_view_1_1_map_1_1_map_camera_fade_view.html#a51533d2025e77539f6e1a0db7ee6e5c9) {     [White](class_sand_box_1_1_view_1_1_map_1_1_map_camera_fade_view.html#a51533d2025e77539f6e1a0db7ee6e5c9a25a81701fbfa4a1efdf660a950c1d006) ,     [FadingOut](class_sand_box_1_1_view_1_1_map_1_1_map_camera_fade_view.html#a51533d2025e77539f6e1a0db7ee6e5c9a2ddb22b5f505aaafbe118c502a5a56ac) ,     [Black](class_sand_box_1_1_view_1_1_map_1_1_map_camera_fade_view.html#a51533d2025e77539f6e1a0db7ee6e5c9ae90dfb84e30edf611e326eeb04d680de) ,     [FadingIn](class_sand_box_1_1_view_1_1_map_1_1_map_camera_fade_view.html#a51533d2025e77539f6e1a0db7ee6e5c9a6830a6bcb5563d6b8ba7bafda3eda348)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [BeginFadeOutAndIn](class_sand_box_1_1_view_1_1_map_1_1_map_camera_fade_view.html#ab02325dee5c985a9d239516f6a29c8ec) (float fadeOutTime, float blackTime, float fadeInTime) |
| void | [BeginFadeOut](class_sand_box_1_1_view_1_1_map_1_1_map_camera_fade_view.html#ac4f85e83fc354bacbab2cece1bd4f8a9) (float fadeOutTime) |
| void | [BeginFadeIn](class_sand_box_1_1_view_1_1_map_1_1_map_camera_fade_view.html#a46cad4de9ab7bcabd1405b3adf9388f1) (float fadeInTime) |

|  |  |
| --- | --- |
| Properties | |
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

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Protected Attributes inherited from [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html) | |
| const float | [ContextAlphaModifier](class_sand_box_1_1_view_1_1_map_1_1_map_view.html#a9efbb55b721c1331986ba14d416c84f6) = 8.5f |

Member Enumeration Documentation
--------------------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_fade_view.html#a51533d2025e77539f6e1a0db7ee6e5c9)CameraFadeState
-------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [SandBox.View.Map.MapCameraFadeView.CameraFadeState](class_sand_box_1_1_view_1_1_map_1_1_map_camera_fade_view.html#a51533d2025e77539f6e1a0db7ee6e5c9) |

| Enumerator | |
| --- | --- |
| White |  |
| FadingOut |  |
| Black |  |
| FadingIn |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_fade_view.html#ab02325dee5c985a9d239516f6a29c8ec)BeginFadeOutAndIn()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.View.Map.MapCameraFadeView.BeginFadeOutAndIn | ( | float | *fadeOutTime*, |
|  |  | float | *blackTime*, |
|  |  | float | *fadeInTime* ) |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_fade_view.html#ac4f85e83fc354bacbab2cece1bd4f8a9)BeginFadeOut()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapCameraFadeView.BeginFadeOut | ( | float | *fadeOutTime* | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_fade_view.html#a46cad4de9ab7bcabd1405b3adf9388f1)BeginFadeIn()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapCameraFadeView.BeginFadeIn | ( | float | *fadeInTime* | ) |  |

Property Documentation
----------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_fade_view.html#a1fe36f8e4c8c248fb729e2d49f2b8249)FadeAlpha
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float SandBox.View.Map.MapCameraFadeView.FadeAlpha | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_fade_view.html#ac67f394e6a10bb3b7cfdb331b3fb5251)FadeState
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CameraFadeState](class_sand_box_1_1_view_1_1_map_1_1_map_camera_fade_view.html#a51533d2025e77539f6e1a0db7ee6e5c9) SandBox.View.Map.MapCameraFadeView.FadeState | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_fade_view.html#af57ad4bd62b99cac1f72f70a0baa88dc)IsCameraFading
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.View.Map.MapCameraFadeView.IsCameraFading | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_fade_view.html#a3945d476f86ab5dff219415caa071208)HasCameraFadeOut
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.View.Map.MapCameraFadeView.HasCameraFadeOut | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_fade_view.html#ab38924f0c17154875c64dbad8b2dd180)HasCameraFadeIn
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.View.Map.MapCameraFadeView.HasCameraFadeIn | | get |

