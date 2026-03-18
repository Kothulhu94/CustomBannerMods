--- SOURCE: interface_tale_worlds_1_1_library_1_1_i_debug_manager.html ---

TaleWorlds.Library.IDebugManager Interface ReferenceInherited by [TaleWorlds.Library.DiamondDebugManager](class_tale_worlds_1_1_library_1_1_diamond_debug_manager.html), and [TaleWorlds.MountAndBlade.MBDebugManager](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_debug_manager.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [ShowWarning](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#a2376a1257e79d26b6d243ecf8148b498) (string message) |
| void | [Assert](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#a108f7a100e982ab10a7c1c3b2940aa42) (bool condition, string message, [CallerFilePath] string callerFile="", [CallerMemberName] string callerMethod="", [CallerLineNumber] int callerLine=0) |
| void | [SilentAssert](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#af23df5e7f00415d39401068ec2a1d202) (bool condition, string message="", bool getDump=false, [CallerFilePath] string callerFile="", [CallerMemberName] string callerMethod="", [CallerLineNumber] int callerLine=0) |
| void | [Print](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#a27026f6db3ff8b34bb8c26bd95601a18) (string message, int logLevel=0, TaleWorlds.Library.Debug.DebugColor color=TaleWorlds.Library.Debug.DebugColor.White, UInt64 debugFilter=(UInt64) Debug.DebugSystemFilter.Mono) |
| void | [PrintError](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#a921c96f6b6607b9a1b5af7cb61fdb386) (string error, string stackTrace, UInt64 debugFilter=(UInt64) Debug.DebugSystemFilter.Mono) |
| void | [PrintWarning](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#a889a63b56ce24531028ffc144fc857f8) (string warning, UInt64 debugFilter=(UInt64) Debug.DebugSystemFilter.Mono) |
| void | [ShowError](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#a022cf7ac1994aa09bdacc743fc91ec2a) (string message) |
| void | [ShowMessageBox](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#a12e33037694c7d2d0cd2270c1ad9a83a) (string lpText, string lpCaption, uint uType) |
| void | [DisplayDebugMessage](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#ad0f7fd48f7d2f8f2d9256ac56831a340) (string message) |
| void | [WatchVariable](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#a21b09373a8f6df4e34b7d5e11eed81a8) (string name, object value) |
| void | [WriteDebugLineOnScreen](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#a1c6be4c38b06768f8823058d0986e2ba) (string message) |
| void | [RenderDebugLine](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#ae02c7804bba830988953e1c213f8926e) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) direction, uint color=0xFFFFFFFF, bool depthCheck=false, float time=0.0f) |
| void | [RenderDebugSphere](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#a8c5211b461db35c5b865526b86040e58) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position, float radius, uint color=0xFFFFFFFF, bool depthCheck=false, float time=0.0f) |
| void | [RenderDebugText3D](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#a54f98923df6e1ad2894498448dece7f3) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position, string text, uint color=0xFFFFFFFF, int screenPosOffsetX=0, int screenPosOffsetY=0, float time=0.0f) |
| void | [RenderDebugFrame](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#a42a17cf3c5d74ff1fe52f773099b9ba8) ([MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame, float lineLength, float time=0.0f) |
| void | [RenderDebugText](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#a2a680da95a60f86d0680d97b1f8f2938) (float screenX, float screenY, string text, uint color=0xFFFFFFFF, float time=0.0f) |
| void | [RenderDebugRectWithColor](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#aae3f7ce31b7b92f4242ee66646342e2d) (float left, float bottom, float right, float top, uint color=0xFFFFFFFF) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetDebugVector](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#a5a82ff88c76c0dc237d0078da253ebba) () |
| void | [SetDebugVector](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#ad52466aa780ce11e7fb94df7501d8934) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) value) |
| void | [SetCrashReportCustomString](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#a5b73fb2edefe212ca662547ac50df99a) (string customString) |
| void | [SetCrashReportCustomStack](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#a3cb7921ce50cc32b0dc4771768491aba) (string customStack) |
| void | [SetTestModeEnabled](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#a47103c7b5d7549a14022b0fe5501ca05) (bool testModeEnabled) |
| void | [AbortGame](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#acbc30dfc542723065efe3be08e4fb6d0) () |
| void | [DoDelayedexit](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#ab99591edac23f8fa4365a9725b5775ef) (int returnCode) |
| void | [ReportMemoryBookmark](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#a708cdfb04570544fa7f874c251d67bc9) (string message) |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#a2376a1257e79d26b6d243ecf8148b498)ShowWarning()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.IDebugManager.ShowWarning | ( | string | *message* | ) |  |

[◆](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#a108f7a100e982ab10a7c1c3b2940aa42)Assert()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.IDebugManager.Assert | ( | bool | *condition*, |
|  |  | string | *message*, |
|  |  | [CallerFilePath] string | *callerFile* = "", |
|  |  | [CallerMemberName] string | *callerMethod* = "", |
|  |  | [CallerLineNumber] int | *callerLine* = 0 ) |

[◆](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#af23df5e7f00415d39401068ec2a1d202)SilentAssert()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.IDebugManager.SilentAssert | ( | bool | *condition*, |
|  |  | string | *message* = "", |
|  |  | bool | *getDump* = false, |
|  |  | [CallerFilePath] string | *callerFile* = "", |
|  |  | [CallerMemberName] string | *callerMethod* = "", |
|  |  | [CallerLineNumber] int | *callerLine* = 0 ) |

[◆](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#a27026f6db3ff8b34bb8c26bd95601a18)Print()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.IDebugManager.Print | ( | string | *message*, |
|  |  | int | *logLevel* = 0, |
|  |  | TaleWorlds.Library.Debug.DebugColor | *color* = TaleWorlds.Library.Debug.DebugColor.White, |
|  |  | UInt64 | *debugFilter* = (UInt64) Debug.DebugSystemFilter.Mono ) |

[◆](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#a921c96f6b6607b9a1b5af7cb61fdb386)PrintError()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.IDebugManager.PrintError | ( | string | *error*, |
|  |  | string | *stackTrace*, |
|  |  | UInt64 | *debugFilter* = (UInt64) Debug.DebugSystemFilter.Mono ) |

[◆](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#a889a63b56ce24531028ffc144fc857f8)PrintWarning()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.IDebugManager.PrintWarning | ( | string | *warning*, |
|  |  | UInt64 | *debugFilter* = (UInt64) Debug.DebugSystemFilter.Mono ) |

[◆](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#a022cf7ac1994aa09bdacc743fc91ec2a)ShowError()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.IDebugManager.ShowError | ( | string | *message* | ) |  |

[◆](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#a12e33037694c7d2d0cd2270c1ad9a83a)ShowMessageBox()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.IDebugManager.ShowMessageBox | ( | string | *lpText*, |
|  |  | string | *lpCaption*, |
|  |  | uint | *uType* ) |

[◆](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#ad0f7fd48f7d2f8f2d9256ac56831a340)DisplayDebugMessage()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.IDebugManager.DisplayDebugMessage | ( | string | *message* | ) |  |

[◆](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#a21b09373a8f6df4e34b7d5e11eed81a8)WatchVariable()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.IDebugManager.WatchVariable | ( | string | *name*, |
|  |  | object | *value* ) |

[◆](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#a1c6be4c38b06768f8823058d0986e2ba)WriteDebugLineOnScreen()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.IDebugManager.WriteDebugLineOnScreen | ( | string | *message* | ) |  |

[◆](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#ae02c7804bba830988953e1c213f8926e)RenderDebugLine()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.IDebugManager.RenderDebugLine | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *direction*, |
|  |  | uint | *color* = 0xFFFFFFFF, |
|  |  | bool | *depthCheck* = false, |
|  |  | float | *time* = 0.0f ) |

[◆](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#a8c5211b461db35c5b865526b86040e58)RenderDebugSphere()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.IDebugManager.RenderDebugSphere | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position*, |
|  |  | float | *radius*, |
|  |  | uint | *color* = 0xFFFFFFFF, |
|  |  | bool | *depthCheck* = false, |
|  |  | float | *time* = 0.0f ) |

[◆](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#a54f98923df6e1ad2894498448dece7f3)RenderDebugText3D()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.IDebugManager.RenderDebugText3D | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position*, |
|  |  | string | *text*, |
|  |  | uint | *color* = 0xFFFFFFFF, |
|  |  | int | *screenPosOffsetX* = 0, |
|  |  | int | *screenPosOffsetY* = 0, |
|  |  | float | *time* = 0.0f ) |

[◆](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#a42a17cf3c5d74ff1fe52f773099b9ba8)RenderDebugFrame()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.IDebugManager.RenderDebugFrame | ( | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame*, |
|  |  | float | *lineLength*, |
|  |  | float | *time* = 0.0f ) |

[◆](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#a2a680da95a60f86d0680d97b1f8f2938)RenderDebugText()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.IDebugManager.RenderDebugText | ( | float | *screenX*, |
|  |  | float | *screenY*, |
|  |  | string | *text*, |
|  |  | uint | *color* = 0xFFFFFFFF, |
|  |  | float | *time* = 0.0f ) |

[◆](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#aae3f7ce31b7b92f4242ee66646342e2d)RenderDebugRectWithColor()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.IDebugManager.RenderDebugRectWithColor | ( | float | *left*, |
|  |  | float | *bottom*, |
|  |  | float | *right*, |
|  |  | float | *top*, |
|  |  | uint | *color* = 0xFFFFFFFF ) |

[◆](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#a5a82ff88c76c0dc237d0078da253ebba)GetDebugVector()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Library.IDebugManager.GetDebugVector | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#ad52466aa780ce11e7fb94df7501d8934)SetDebugVector()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.IDebugManager.SetDebugVector | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *value* | ) |  |

[◆](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#a5b73fb2edefe212ca662547ac50df99a)SetCrashReportCustomString()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.IDebugManager.SetCrashReportCustomString | ( | string | *customString* | ) |  |

[◆](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#a3cb7921ce50cc32b0dc4771768491aba)SetCrashReportCustomStack()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.IDebugManager.SetCrashReportCustomStack | ( | string | *customStack* | ) |  |

[◆](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#a47103c7b5d7549a14022b0fe5501ca05)SetTestModeEnabled()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.IDebugManager.SetTestModeEnabled | ( | bool | *testModeEnabled* | ) |  |

[◆](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#acbc30dfc542723065efe3be08e4fb6d0)AbortGame()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Library.IDebugManager.AbortGame | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#ab99591edac23f8fa4365a9725b5775ef)DoDelayedexit()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.IDebugManager.DoDelayedexit | ( | int | *returnCode* | ) |  |

[◆](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#a708cdfb04570544fa7f874c251d67bc9)ReportMemoryBookmark()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.IDebugManager.ReportMemoryBookmark | ( | string | *message* | ) |  |

