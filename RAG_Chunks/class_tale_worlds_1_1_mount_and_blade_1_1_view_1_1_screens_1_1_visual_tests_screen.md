--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_visual_tests_screen.html ---

TaleWorlds.MountAndBlade.View.Screens.VisualTestsScreen Class ReferenceInherits ScreenBase.

|  |  |
| --- | --- |
| Classes | |
| class | [CameraPoint](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_visual_tests_screen_1_1_camera_point.html) |

|  |  |
| --- | --- |
| Public Types | |
| enum | [CameraPointTestType](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_visual_tests_screen.html#ae2f5532facb35f2751552a997788fcff) {     [Final](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_visual_tests_screen.html#ae2f5532facb35f2751552a997788fcffabeae421a14a34f831c113f61323d1ab3) = 0 ,     [Albedo](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_visual_tests_screen.html#ae2f5532facb35f2751552a997788fcffaf879d0a27915d351a8e47c2223777710) = 1 ,     [Normal](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_visual_tests_screen.html#ae2f5532facb35f2751552a997788fcffa960b44c579bc2f6818d2daaf9e4c16f0) = 2 ,     [Specular](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_visual_tests_screen.html#ae2f5532facb35f2751552a997788fcffa39b0044dd8789d333e7794f359406740) = 3 ,     [AO](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_visual_tests_screen.html#ae2f5532facb35f2751552a997788fcffa2c64c5cf613d8b9f4f7f3980d29aca10) = 4 ,     [OnlyAmbient](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_visual_tests_screen.html#ae2f5532facb35f2751552a997788fcffaae47787f78bceddb03f68ff9d8ae1dde) = 5 ,     [OnlyDirect](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_visual_tests_screen.html#ae2f5532facb35f2751552a997788fcffac63acaba5803a4490b49ecc57b59a7d2) = 6   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| bool | [StartedRendering](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_visual_tests_screen.html#acfc6f42ab596a3907087ff52fdfc587a) () |
| String | [GetSubTestName](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_visual_tests_screen.html#a96aec9f4212eaae77cae828fbe18a92c) ([CameraPointTestType](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_visual_tests_screen.html#ae2f5532facb35f2751552a997788fcff) type) |
| [Utilities.EngineRenderDisplayMode](class_tale_worlds_1_1_engine_1_1_utilities.html#a74c5b49a9b64eb789664664f96087a75) | [GetRenderMode](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_visual_tests_screen.html#a66a20c6b8d21c389ec0d8a8ae6b5af0f) ([CameraPointTestType](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_visual_tests_screen.html#ae2f5532facb35f2751552a997788fcff) type) |
|  | [VisualTestsScreen](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_visual_tests_screen.html#a1c5c382025b58224396e41b2194bdf44) (bool isValidTest, NativeOptions.ConfigQuality preset, string sceneName, DateTime testTime, List< string > testTypesToCheck) |
| void | [Reset](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_visual_tests_screen.html#a9bd89ed7cc7440bbee9fd2129618b961) () |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static bool | [isSceneSuccess](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_visual_tests_screen.html#a253b548cfd985f18167b13d94fe9afb2) = true |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnInitialize](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_visual_tests_screen.html#ab02bbbe75df7e3f975a72446eb855edf) () |
| override void | [OnActivate](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_visual_tests_screen.html#a28a7d9e82eca8c48849dabaf6f8ffe32) () |
| override void | [OnDeactivate](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_visual_tests_screen.html#a39c7f1df8d84a01a69384b5d2b2f67c6) () |
| override void | [OnFrameTick](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_visual_tests_screen.html#a4980224ee45425155a1fe616ce3a5c25) (float dt) |
| override void | [OnFinalize](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_visual_tests_screen.html#aab9c34f64a5cd5648ee16e2435c241d2) () |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_visual_tests_screen.html#ae2f5532facb35f2751552a997788fcff)CameraPointTestType
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum TaleWorlds.MountAndBlade.View.Screens.VisualTestsScreen.CameraPointTestType |

| Enumerator | |
| --- | --- |
| Final |  |
| Albedo |  |
| Normal |  |
| Specular |  |
| AO |  |
| OnlyAmbient |  |
| OnlyDirect |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_visual_tests_screen.html#a1c5c382025b58224396e41b2194bdf44)VisualTestsScreen()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.View.Screens.VisualTestsScreen.VisualTestsScreen | ( | bool | *isValidTest*, |
|  |  | NativeOptions.ConfigQuality | *preset*, |
|  |  | string | *sceneName*, |
|  |  | DateTime | *testTime*, |
|  |  | List< string > | *testTypesToCheck* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_visual_tests_screen.html#acfc6f42ab596a3907087ff52fdfc587a)StartedRendering()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.View.Screens.VisualTestsScreen.StartedRendering | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_visual_tests_screen.html#a96aec9f4212eaae77cae828fbe18a92c)GetSubTestName()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| String TaleWorlds.MountAndBlade.View.Screens.VisualTestsScreen.GetSubTestName | ( | [CameraPointTestType](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_visual_tests_screen.html#ae2f5532facb35f2751552a997788fcff) | *type* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_visual_tests_screen.html#a66a20c6b8d21c389ec0d8a8ae6b5af0f)GetRenderMode()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Utilities.EngineRenderDisplayMode](class_tale_worlds_1_1_engine_1_1_utilities.html#a74c5b49a9b64eb789664664f96087a75) TaleWorlds.MountAndBlade.View.Screens.VisualTestsScreen.GetRenderMode | ( | [CameraPointTestType](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_visual_tests_screen.html#ae2f5532facb35f2751552a997788fcff) | *type* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_visual_tests_screen.html#ab02bbbe75df7e3f975a72446eb855edf)OnInitialize()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.Screens.VisualTestsScreen.OnInitialize | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_visual_tests_screen.html#a28a7d9e82eca8c48849dabaf6f8ffe32)OnActivate()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.Screens.VisualTestsScreen.OnActivate | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_visual_tests_screen.html#a39c7f1df8d84a01a69384b5d2b2f67c6)OnDeactivate()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.Screens.VisualTestsScreen.OnDeactivate | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_visual_tests_screen.html#a4980224ee45425155a1fe616ce3a5c25)OnFrameTick()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.Screens.VisualTestsScreen.OnFrameTick | ( | float | *dt* | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_visual_tests_screen.html#aab9c34f64a5cd5648ee16e2435c241d2)OnFinalize()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.Screens.VisualTestsScreen.OnFinalize | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_visual_tests_screen.html#a9bd89ed7cc7440bbee9fd2129618b961)Reset()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Screens.VisualTestsScreen.Reset | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_visual_tests_screen.html#a253b548cfd985f18167b13d94fe9afb2)isSceneSuccess
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.View.Screens.VisualTestsScreen.isSceneSuccess = true | | static |

