--- SOURCE: class_tale_worlds_1_1_engine_1_1_m_b_debug.html ---

TaleWorlds.Engine.MBDebug Class Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [MessageBoxTypeFlag](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#add07835112ec57802579b56478cd900e) {     [Ok](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#add07835112ec57802579b56478cd900eaa60852f204ed8028c1c58808b746d115) = 0x00000001 ,     [Warning](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#add07835112ec57802579b56478cd900ea0eaadb4fcb48a0a0ed7bc9868be9fbaa) = 0x00000002 ,     [Error](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#add07835112ec57802579b56478cd900ea902b0d55fddef6f8d651fe1035b7d4bd) = 0x00000004 ,     [OkCancel](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#add07835112ec57802579b56478cd900ea4b116999b87115628973f2e30b59fd08) = 0x00000008 ,     [RetryCancel](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#add07835112ec57802579b56478cd900ea5d1f937d009d6f924b50b9e742ecc8ac) = 0x00000010 ,     [YesNo](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#add07835112ec57802579b56478cd900eab65ffbcb4dcfb93ecdc257d6e4ba42c4) = 0x00000020 ,     [YesNoCancel](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#add07835112ec57802579b56478cd900ea71fc7b7aece69111c0b6967de4b101c5) = 0x00000040 ,     [Information](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#add07835112ec57802579b56478cd900eaa82be0f551b8708bc08eb33cd9ded0cf) = 0x00000080 ,     [Exclamation](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#add07835112ec57802579b56478cd900ea2cacce52cca35cbc2d8e590fce9afbd4) = 0x00000100 ,     [Question](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#add07835112ec57802579b56478cd900eaa97ea56b0e00b2379736ae60869ff66a) = 0x00000200 ,     [AssertFailed](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#add07835112ec57802579b56478cd900ea3f5bb06fb656c141afc9af493ac6f122) = 0x00000400   } |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static string | [DisableUI](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a08f0e4fb19665053a347b00ce2d7fa03) (List< string > strings) |
| static void | [AssertMemoryUsage](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#aa09d9d83a7f4963217da1512c9e47a33) (int memoryMB) |
| static void | [AbortGame](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a8ab0f14366a96712040a70a55d6896fb) (int ExitCode=5) |
| static void | [ShowWarning](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a438ef46de7c9698144173c72835b4d76) (string message) |
| static void | [ContentWarning](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#afd792e63e74f1a39a1602150a36f6d99) (string message) |
| static void | [ShowError](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a5a9f5c912300d3fcc2a28b6dfd6cbf82) (string message) |
| static void | [ShowMessageBox](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a969226d1b9126eb5e931db6d374212a6) (string lpText, string lpCaption, uint uType) |
| static void | [Assert](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#ae74dcce7fc9cb12d3f80c1be659687e9) (bool condition, string message, [CallerFilePath] string callerFile="", [CallerMemberName] string callerMethod="", [CallerLineNumber] int callerLine=0) |
| static void | [FailedAssert](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#aef54150074d4fd10c6b9ab6f42c36861) (string message, [CallerFilePath] string callerFile="", [CallerMemberName] string callerMethod="", [CallerLineNumber] int callerLine=0) |
| static void | [SilentAssert](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a0ad600413097748323c4e7a260b590b9) (bool condition, string message="", bool getDump=false, [CallerFilePath] string callerFile="", [CallerMemberName] string callerMethod="", [CallerLineNumber] int callerLine=0) |
| static void | [AssertConditionOrCallerClassName](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a4014d59d87b940a8459c1c7703571083) (bool condition, string name) |
| static void | [AssertConditionOrCallerClassNameSearchAllCallstack](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a5e11118375855c363cec7f7fb2743218) (bool condition, string name) |
| static void | [Print](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a361cefb4c7af7c985031211d2bf31300) (string message, int logLevel=0, TaleWorlds.Library.Debug.DebugColor color=TaleWorlds.Library.Debug.DebugColor.White, UInt64 debugFilter=(UInt64) Library.Debug.DebugSystemFilter.Mono) |
| static void | [ConsolePrint](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a7c6dc35a53be85e56cc743893fe52a07) (string message, TaleWorlds.Library.Debug.DebugColor color=TaleWorlds.Library.Debug.DebugColor.White, UInt64 debugFilter=(UInt64) Library.Debug.DebugSystemFilter.Mono) |
|  | Prints a message to Console. |
| static void | [WriteDebugLineOnScreen](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a232bbbe12a698c7136b6c30bcda51011) (string str) |
| static void | [RenderDebugText](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#af55885d21dd6583dc7672d390f560f4b) (float screenX, float screenY, string text, uint color=0xFFFFFFFF, float time=0.0f) |
| static void | [RenderText](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a9c3c0df706e815d7a4bffbf89e376bf7) (float screenX, float screenY, string text, uint color=0xFFFFFFFF, float time=0.0f) |
| static void | [RenderDebugRect](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a794af631594acb5ad07bbcc3dc46e18a) (float left, float bottom, float right, float top) |
| static void | [RenderDebugRectWithColor](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a186b5ed99f207c554914ef03ffcbdd77) (float left, float bottom, float right, float top, uint color=0xFFFFFFFF) |
| static void | [RenderDebugFrame](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#ac49636895cdaa3987a37ebc95037a13c) ([MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame, float lineLength, float time=0.0f) |
| static void | [RenderDebugText3D](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a16171d3ac256d3a4f3801fe8514eec78) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) worldPosition, string str, uint color=0xFFFFFFFF, int screenPosOffsetX=0, int screenPosOffsetY=0, float time=0.0f) |
| static void | [RenderDebugDirectionArrow](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a4f6ddd12f31fcd43f81cfe6ae48e7e5c) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) direction, uint color=0xFFFFFFFF, bool depthCheck=false) |
| static void | [RenderDebugLine](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a81b57630ad57e586528207de7f3dfaa2) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) direction, uint color=0xFFFFFFFF, bool depthCheck=false, float time=0.0f) |
| static void | [RenderDebugSphere](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a90112af1987d39221fd4ec1adf4c7cce) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position, float radius, uint color=0xFFFFFFFF, bool depthCheck=false, float time=0.0f) |
| static void | [RenderDebugCapsule](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a0ae274e73ccd51cb1ad5d762eed8ed35) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) p0, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) p1, float radius, uint color=0xFFFFFFFF, bool depthCheck=false, float time=0.0f) |
| static void | [RenderDebugBoundingBoxOfEntity](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a44cd8d635b8350741187f17096aa4933) ([GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) entity, [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame, uint color=0xFFFFFFFF, bool depthCheck=false, float time=0.0f) |
| static void | [RenderDebugBoundingBox](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a09832911c9f2a5e711a5b0c93641d443) ([BoundingBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html) box, [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame, uint color=0xFFFFFFFF, bool depthCheck=false, float time=0.0f) |
| static void | [ClearRenderObjects](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#ad8280e1de93f462be41dde27c1f1300f) () |
| static void | [RenderDebugBoxObject](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#ab77bb63ba405cb5f00dc0cbcf809c7dc) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) min, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) max, uint color=0xFFFFFFFF, bool depthCheck=false, float time=0.0f) |
| static void | [RenderDebugBoxObject](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a9bd686dfd0b45fa6508d925f7dfed558) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) min, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) max, [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame, uint color=0xFFFFFFFF, bool depthCheck=false, float time=0.0f) |
| static void | [PostWarningLine](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a30c9bb19843a303acf723e2a80a38285) (string line) |
| static bool | [IsErrorReportModeActive](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a4b89ccbb92dcca989a706afa92f88ef7) () |
| static bool | [IsErrorReportModePauseMission](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#af72c53d50878546b767151f906b905cd) () |
| static void | [SetErrorReportScene](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a69833ed7218a7d4699e8fbe0cc259419) ([Scene](class_tale_worlds_1_1_engine_1_1_scene.html) scene) |
| static void | [SetDumpGenerationDisabled](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a9e40537031ed3875ff36d50339b93a19) (bool value) |
| static void | [EchoCommandWindow](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a23ecbc7950b29406af01cc98ea476544) (string content) |
| static string | [ClearConsole](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a573b1662b0ac05e44ba143014fb9dbbe) (List< String > strings) |
| static string | [EchoCommandWindow](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a8d70bb63a9d22c4feb902e8c48f4fb26) (List< String > strings) |
| static string | [EchoCommandWindowTest](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a43df530cdf44ed823870190d4a45e972) (List< String > strings) |
| static bool | [IsTestMode](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a862732862952d0eb223ef2920b35f4d3) () |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static bool | [DisableAllUI](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a9c7dce3519be87e242c1c779c43e0e45) = false |
| static bool | [TestModeEnabled](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a7f91028be71a83318c6b310f22d3d43c) = false |
| static bool | [ShouldAssertThrowException](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a539e484d34987578795e2835c9d37921) = false |
| static bool | [IsDisplayingHighLevelAI](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a6ee0b0088f85ee882d26b9d79d09e9ff) |
| static bool | [DisableLogging](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#aa0da78a9514c96d1c87aa3e26fd2ec35) = false |

|  |  |
| --- | --- |
| Properties | |
| static [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [DebugVector](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a9d0bc97f3ddebd85087f1a133620f6d0) `[get, set]` |
| static int | [ShowDebugInfoState](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a262ee6a9515343ba7d446978bb3ead3a) `[get, set]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#add07835112ec57802579b56478cd900e)MessageBoxTypeFlag
--------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum TaleWorlds.Engine.MBDebug.MessageBoxTypeFlag |

| Enumerator | |
| --- | --- |
| Ok |  |
| Warning |  |
| Error |  |
| OkCancel |  |
| RetryCancel |  |
| YesNo |  |
| YesNoCancel |  |
| Information |  |
| Exclamation |  |
| Question |  |
| AssertFailed |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a08f0e4fb19665053a347b00ce2d7fa03)DisableUI()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.Engine.MBDebug.DisableUI | ( | List< string > | *strings* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#aa09d9d83a7f4963217da1512c9e47a33)AssertMemoryUsage()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.MBDebug.AssertMemoryUsage | ( | int | *memoryMB* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a8ab0f14366a96712040a70a55d6896fb)AbortGame()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.MBDebug.AbortGame | ( | int | *ExitCode* = 5 | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a438ef46de7c9698144173c72835b4d76)ShowWarning()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.MBDebug.ShowWarning | ( | string | *message* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#afd792e63e74f1a39a1602150a36f6d99)ContentWarning()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.MBDebug.ContentWarning | ( | string | *message* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a5a9f5c912300d3fcc2a28b6dfd6cbf82)ShowError()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.MBDebug.ShowError | ( | string | *message* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a969226d1b9126eb5e931db6d374212a6)ShowMessageBox()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.MBDebug.ShowMessageBox | ( | string | *lpText*, | |  |  | string | *lpCaption*, | |  |  | uint | *uType* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#ae74dcce7fc9cb12d3f80c1be659687e9)Assert()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.MBDebug.Assert | ( | bool | *condition*, | |  |  | string | *message*, | |  |  | [CallerFilePath] string | *callerFile* = "", | |  |  | [CallerMemberName] string | *callerMethod* = "", | |  |  | [CallerLineNumber] int | *callerLine* = 0 ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#aef54150074d4fd10c6b9ab6f42c36861)FailedAssert()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.MBDebug.FailedAssert | ( | string | *message*, | |  |  | [CallerFilePath] string | *callerFile* = "", | |  |  | [CallerMemberName] string | *callerMethod* = "", | |  |  | [CallerLineNumber] int | *callerLine* = 0 ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a0ad600413097748323c4e7a260b590b9)SilentAssert()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.MBDebug.SilentAssert | ( | bool | *condition*, | |  |  | string | *message* = "", | |  |  | bool | *getDump* = false, | |  |  | [CallerFilePath] string | *callerFile* = "", | |  |  | [CallerMemberName] string | *callerMethod* = "", | |  |  | [CallerLineNumber] int | *callerLine* = 0 ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a4014d59d87b940a8459c1c7703571083)AssertConditionOrCallerClassName()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.MBDebug.AssertConditionOrCallerClassName | ( | bool | *condition*, | |  |  | string | *name* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a5e11118375855c363cec7f7fb2743218)AssertConditionOrCallerClassNameSearchAllCallstack()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.MBDebug.AssertConditionOrCallerClassNameSearchAllCallstack | ( | bool | *condition*, | |  |  | string | *name* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a361cefb4c7af7c985031211d2bf31300)Print()
---------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.MBDebug.Print | ( | string | *message*, | |  |  | int | *logLevel* = 0, | |  |  | TaleWorlds.Library.Debug.DebugColor | *color* = TaleWorlds::Library::Debug::DebugColor::White, | |  |  | UInt64 | *debugFilter* = (UInt64)Library::Debug::DebugSystemFilter::Mono ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a7c6dc35a53be85e56cc743893fe52a07)ConsolePrint()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.MBDebug.ConsolePrint | ( | string | *message*, | |  |  | TaleWorlds.Library.Debug.DebugColor | *color* = TaleWorlds::Library::Debug::DebugColor::White, | |  |  | UInt64 | *debugFilter* = (UInt64)Library::Debug::DebugSystemFilter::Mono ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | message | Message to be printed. |
    | color | [Color](struct_tale_worlds_1_1_library_1_1_color.html) of the message. Default is white. |
    | debugFilter | Filters the message. Default is mono. |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a232bbbe12a698c7136b6c30bcda51011)WriteDebugLineOnScreen()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.MBDebug.WriteDebugLineOnScreen | ( | string | *str* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#af55885d21dd6583dc7672d390f560f4b)RenderDebugText()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.MBDebug.RenderDebugText | ( | float | *screenX*, | |  |  | float | *screenY*, | |  |  | string | *text*, | |  |  | uint | *color* = 0xFFFFFFFF, | |  |  | float | *time* = 0::0f ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a9c3c0df706e815d7a4bffbf89e376bf7)RenderText()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.MBDebug.RenderText | ( | float | *screenX*, | |  |  | float | *screenY*, | |  |  | string | *text*, | |  |  | uint | *color* = 0xFFFFFFFF, | |  |  | float | *time* = 0::0f ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a794af631594acb5ad07bbcc3dc46e18a)RenderDebugRect()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.MBDebug.RenderDebugRect | ( | float | *left*, | |  |  | float | *bottom*, | |  |  | float | *right*, | |  |  | float | *top* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a186b5ed99f207c554914ef03ffcbdd77)RenderDebugRectWithColor()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.MBDebug.RenderDebugRectWithColor | ( | float | *left*, | |  |  | float | *bottom*, | |  |  | float | *right*, | |  |  | float | *top*, | |  |  | uint | *color* = 0xFFFFFFFF ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#ac49636895cdaa3987a37ebc95037a13c)RenderDebugFrame()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.MBDebug.RenderDebugFrame | ( | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame*, | |  |  | float | *lineLength*, | |  |  | float | *time* = 0::0f ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a16171d3ac256d3a4f3801fe8514eec78)RenderDebugText3D()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.MBDebug.RenderDebugText3D | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *worldPosition*, | |  |  | string | *str*, | |  |  | uint | *color* = 0xFFFFFFFF, | |  |  | int | *screenPosOffsetX* = 0, | |  |  | int | *screenPosOffsetY* = 0, | |  |  | float | *time* = 0::0f ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a4f6ddd12f31fcd43f81cfe6ae48e7e5c)RenderDebugDirectionArrow()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.MBDebug.RenderDebugDirectionArrow | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *direction*, | |  |  | uint | *color* = 0xFFFFFFFF, | |  |  | bool | *depthCheck* = false ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a81b57630ad57e586528207de7f3dfaa2)RenderDebugLine()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.MBDebug.RenderDebugLine | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *direction*, | |  |  | uint | *color* = 0xFFFFFFFF, | |  |  | bool | *depthCheck* = false, | |  |  | float | *time* = 0::0f ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a90112af1987d39221fd4ec1adf4c7cce)RenderDebugSphere()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.MBDebug.RenderDebugSphere | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position*, | |  |  | float | *radius*, | |  |  | uint | *color* = 0xFFFFFFFF, | |  |  | bool | *depthCheck* = false, | |  |  | float | *time* = 0::0f ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a0ae274e73ccd51cb1ad5d762eed8ed35)RenderDebugCapsule()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.MBDebug.RenderDebugCapsule | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *p0*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *p1*, | |  |  | float | *radius*, | |  |  | uint | *color* = 0xFFFFFFFF, | |  |  | bool | *depthCheck* = false, | |  |  | float | *time* = 0::0f ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a44cd8d635b8350741187f17096aa4933)RenderDebugBoundingBoxOfEntity()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.MBDebug.RenderDebugBoundingBoxOfEntity | ( | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *entity*, | |  |  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame*, | |  |  | uint | *color* = 0xFFFFFFFF, | |  |  | bool | *depthCheck* = false, | |  |  | float | *time* = 0::0f ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a09832911c9f2a5e711a5b0c93641d443)RenderDebugBoundingBox()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.MBDebug.RenderDebugBoundingBox | ( | [BoundingBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html) | *box*, | |  |  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame*, | |  |  | uint | *color* = 0xFFFFFFFF, | |  |  | bool | *depthCheck* = false, | |  |  | float | *time* = 0::0f ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#ad8280e1de93f462be41dde27c1f1300f)ClearRenderObjects()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.MBDebug.ClearRenderObjects | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#ab77bb63ba405cb5f00dc0cbcf809c7dc)RenderDebugBoxObject() [1/2]
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.MBDebug.RenderDebugBoxObject | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *min*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *max*, | |  |  | uint | *color* = 0xFFFFFFFF, | |  |  | bool | *depthCheck* = false, | |  |  | float | *time* = 0::0f ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a9bd686dfd0b45fa6508d925f7dfed558)RenderDebugBoxObject() [2/2]
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.MBDebug.RenderDebugBoxObject | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *min*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *max*, | |  |  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame*, | |  |  | uint | *color* = 0xFFFFFFFF, | |  |  | bool | *depthCheck* = false, | |  |  | float | *time* = 0::0f ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a30c9bb19843a303acf723e2a80a38285)PostWarningLine()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.MBDebug.PostWarningLine | ( | string | *line* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a4b89ccbb92dcca989a706afa92f88ef7)IsErrorReportModeActive()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.MBDebug.IsErrorReportModeActive | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#af72c53d50878546b767151f906b905cd)IsErrorReportModePauseMission()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.MBDebug.IsErrorReportModePauseMission | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a69833ed7218a7d4699e8fbe0cc259419)SetErrorReportScene()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.MBDebug.SetErrorReportScene | ( | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *scene* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a9e40537031ed3875ff36d50339b93a19)SetDumpGenerationDisabled()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.MBDebug.SetDumpGenerationDisabled | ( | bool | *value* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a23ecbc7950b29406af01cc98ea476544)EchoCommandWindow() [1/2]
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.MBDebug.EchoCommandWindow | ( | string | *content* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a573b1662b0ac05e44ba143014fb9dbbe)ClearConsole()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.Engine.MBDebug.ClearConsole | ( | List< String > | *strings* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a8d70bb63a9d22c4feb902e8c48f4fb26)EchoCommandWindow() [2/2]
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.Engine.MBDebug.EchoCommandWindow | ( | List< String > | *strings* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a43df530cdf44ed823870190d4a45e972)EchoCommandWindowTest()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.Engine.MBDebug.EchoCommandWindowTest | ( | List< String > | *strings* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a862732862952d0eb223ef2920b35f4d3)IsTestMode()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.MBDebug.IsTestMode | ( |  | ) |  | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a9c7dce3519be87e242c1c779c43e0e45)DisableAllUI
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Engine.MBDebug.DisableAllUI = false | | static |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a7f91028be71a83318c6b310f22d3d43c)TestModeEnabled
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Engine.MBDebug.TestModeEnabled = false | | static |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a539e484d34987578795e2835c9d37921)ShouldAssertThrowException
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Engine.MBDebug.ShouldAssertThrowException = false | | static |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a6ee0b0088f85ee882d26b9d79d09e9ff)IsDisplayingHighLevelAI
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Engine.MBDebug.IsDisplayingHighLevelAI | | static |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#aa0da78a9514c96d1c87aa3e26fd2ec35)DisableLogging
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Engine.MBDebug.DisableLogging = false | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a9d0bc97f3ddebd85087f1a133620f6d0)DebugVector
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.MBDebug.DebugVector | | staticgetset |

[◆](class_tale_worlds_1_1_engine_1_1_m_b_debug.html#a262ee6a9515343ba7d446978bb3ead3a)ShowDebugInfoState
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Engine.MBDebug.ShowDebugInfoState | | staticgetset |

