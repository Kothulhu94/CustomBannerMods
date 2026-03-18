--- SOURCE: class_tale_worlds_1_1_library_1_1_debug.html ---

TaleWorlds.Library.Debug Class Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [DebugColor](class_tale_worlds_1_1_library_1_1_debug.html#a8303c1b9b6fedc6038077e3b560b2446) {     [DarkRed](class_tale_worlds_1_1_library_1_1_debug.html#a8303c1b9b6fedc6038077e3b560b2446a8746d21f8164452063398744f06307dd) = 0 ,     [DarkGreen](class_tale_worlds_1_1_library_1_1_debug.html#a8303c1b9b6fedc6038077e3b560b2446af780aab6295a2f368ac69a514f8b4605) ,     [DarkBlue](class_tale_worlds_1_1_library_1_1_debug.html#a8303c1b9b6fedc6038077e3b560b2446a877716336e4eb22ac67faaa9c2b86635) ,     [Red](class_tale_worlds_1_1_library_1_1_debug.html#a8303c1b9b6fedc6038077e3b560b2446aee38e4d5dd68c4e440825018d549cb47) ,     [Green](class_tale_worlds_1_1_library_1_1_debug.html#a8303c1b9b6fedc6038077e3b560b2446ad382816a3cbeed082c9e216e7392eed1) ,     [Blue](class_tale_worlds_1_1_library_1_1_debug.html#a8303c1b9b6fedc6038077e3b560b2446a9594eec95be70e7b1710f730fdda33d9) ,     [DarkCyan](class_tale_worlds_1_1_library_1_1_debug.html#a8303c1b9b6fedc6038077e3b560b2446a85b1ae66e65b490f35c5e8b725e7049f) ,     [Cyan](class_tale_worlds_1_1_library_1_1_debug.html#a8303c1b9b6fedc6038077e3b560b2446a023c239d2f2538f140a20e72c7b73f20) ,     [DarkYellow](class_tale_worlds_1_1_library_1_1_debug.html#a8303c1b9b6fedc6038077e3b560b2446a42d873bb34e1055e40aad0ec45039e8b) ,     [Yellow](class_tale_worlds_1_1_library_1_1_debug.html#a8303c1b9b6fedc6038077e3b560b2446a51e6cd92b6c45f9affdc158ecca2b8b8) ,     [Purple](class_tale_worlds_1_1_library_1_1_debug.html#a8303c1b9b6fedc6038077e3b560b2446ab9ba865fec061c9706d2fd7ce49c0cc7) ,     [Magenta](class_tale_worlds_1_1_library_1_1_debug.html#a8303c1b9b6fedc6038077e3b560b2446ab91cc2c1416fcca942b61c7ac5b1a9ac) ,     [White](class_tale_worlds_1_1_library_1_1_debug.html#a8303c1b9b6fedc6038077e3b560b2446a25a81701fbfa4a1efdf660a950c1d006) ,     [BrightWhite](class_tale_worlds_1_1_library_1_1_debug.html#a8303c1b9b6fedc6038077e3b560b2446a44a07eabeb77868ee704ec159a59e8e4)   } |
| enum | [DebugUserFilter](class_tale_worlds_1_1_library_1_1_debug.html#a01dc023ba5b25e8166652a9607cac294) : ulong {     [None](class_tale_worlds_1_1_library_1_1_debug.html#a01dc023ba5b25e8166652a9607cac294a6adf97f83acf6453d4a6a4b1070f3754) = (0ul << 0) ,     [Unused0](class_tale_worlds_1_1_library_1_1_debug.html#a01dc023ba5b25e8166652a9607cac294a9adb4c745cccc9209cb51b8b8a94e84f) = (1ul << 0) ,     [Unused1](class_tale_worlds_1_1_library_1_1_debug.html#a01dc023ba5b25e8166652a9607cac294adb687ac7d13453540c38d5417d3d5e28) = (1ul << 1) ,     [Koray](class_tale_worlds_1_1_library_1_1_debug.html#a01dc023ba5b25e8166652a9607cac294a4308e0c2f554358fe8cf373967a74851) = (1ul << 2) ,     [Armagan](class_tale_worlds_1_1_library_1_1_debug.html#a01dc023ba5b25e8166652a9607cac294add193294846b07f89e91bcad49dadeca) = (1ul << 3) ,     [Intern](class_tale_worlds_1_1_library_1_1_debug.html#a01dc023ba5b25e8166652a9607cac294a17ac93e56edd16cafa7b57979b959292) = (1ul << 4) ,     [Mustafa](class_tale_worlds_1_1_library_1_1_debug.html#a01dc023ba5b25e8166652a9607cac294ab63216ec433358172c1eccd0a9fa8c12) = (1ul << 5) ,     [Oguzhan](class_tale_worlds_1_1_library_1_1_debug.html#a01dc023ba5b25e8166652a9607cac294a5c54b21e8f439fb1b9cd5070ef6b9838) = (1ul << 6) ,     [Omer](class_tale_worlds_1_1_library_1_1_debug.html#a01dc023ba5b25e8166652a9607cac294a6ae9afc96aa3fec4308a320991b508d6) = (1ul << 7) ,     [Ates](class_tale_worlds_1_1_library_1_1_debug.html#a01dc023ba5b25e8166652a9607cac294ac5f79e3e401a0d7e3f55a988f8b6df96) = (1ul << 8) ,     [Unused3](class_tale_worlds_1_1_library_1_1_debug.html#a01dc023ba5b25e8166652a9607cac294afde3855b8fbe566ad1533c117b7f2c5d) = (1ul << 9) ,     [Basak](class_tale_worlds_1_1_library_1_1_debug.html#a01dc023ba5b25e8166652a9607cac294a55cf92a75dee32bf7dc3f645f7e67bc1) = (1ul << 10) ,     [Can](class_tale_worlds_1_1_library_1_1_debug.html#a01dc023ba5b25e8166652a9607cac294ad677b410373bc790d9a8ec2e68090839) = (1ul << 11) ,     [Unused4](class_tale_worlds_1_1_library_1_1_debug.html#a01dc023ba5b25e8166652a9607cac294ad52eaf9420fedfba4867bfb2f0cc0ebc) = (1ul << 12) ,     [Cem](class_tale_worlds_1_1_library_1_1_debug.html#a01dc023ba5b25e8166652a9607cac294a8d04bd4b6668e79919cccc05df6c29ec) = (1ul << 13) ,     [Unused5](class_tale_worlds_1_1_library_1_1_debug.html#a01dc023ba5b25e8166652a9607cac294afd1e8ca1e53fa6c92ed64516ca5bf9e6) = (1ul << 14) ,     [Unused6](class_tale_worlds_1_1_library_1_1_debug.html#a01dc023ba5b25e8166652a9607cac294a31a47fda00eeff95bff5a517acd1f7ff) = (1ul << 15) ,     [Emircan](class_tale_worlds_1_1_library_1_1_debug.html#a01dc023ba5b25e8166652a9607cac294a063a060913e8438ff3321128c2b1d9b9) = (1ul << 16) ,     [Unused7](class_tale_worlds_1_1_library_1_1_debug.html#a01dc023ba5b25e8166652a9607cac294a2e701f5c2073a4c4144867ac2c8b9389) = (1ul << 17) ,     [All](class_tale_worlds_1_1_library_1_1_debug.html#a01dc023ba5b25e8166652a9607cac294ab1c94ca2fbc3e78fc30069c8d0f01680) = 0x00000000FFFFFFFFul ,     [Default](class_tale_worlds_1_1_library_1_1_debug.html#a01dc023ba5b25e8166652a9607cac294a7a1920d61156abc05a60135aefe8bc67) = None ,     [DamageDebug](class_tale_worlds_1_1_library_1_1_debug.html#a01dc023ba5b25e8166652a9607cac294a2c859a4cd2b3d445f7e5f5f1ca2d585e) = Oguzhan | Armagan   } |
| enum | [DebugSystemFilter](class_tale_worlds_1_1_library_1_1_debug.html#a61f2e57c9e78f5921c07304024955538) : ulong {     [None](class_tale_worlds_1_1_library_1_1_debug.html#a61f2e57c9e78f5921c07304024955538a6adf97f83acf6453d4a6a4b1070f3754) = (0ul << 0) ,     [Graphics](class_tale_worlds_1_1_library_1_1_debug.html#a61f2e57c9e78f5921c07304024955538ad334dfcea59127bedfcdbe0a3ee7f494) = (1ul << 32) ,     [ArtificialIntelligence](class_tale_worlds_1_1_library_1_1_debug.html#a61f2e57c9e78f5921c07304024955538ab51d2ff6ee710d8007ddf0ade4d3a8b0) = (1ul << 33) ,     [MultiPlayer](class_tale_worlds_1_1_library_1_1_debug.html#a61f2e57c9e78f5921c07304024955538ae65be2eece04b72c3fb10d5ec8af6dc3) = (1ul << 34) ,     [IO](class_tale_worlds_1_1_library_1_1_debug.html#a61f2e57c9e78f5921c07304024955538acf3882f1c43ab22bff0bd9d82d83251b) = (1ul << 35) ,     [Network](class_tale_worlds_1_1_library_1_1_debug.html#a61f2e57c9e78f5921c07304024955538aeec89088ee408b80387155272b113256) = (1ul << 36) ,     [CampaignEvents](class_tale_worlds_1_1_library_1_1_debug.html#a61f2e57c9e78f5921c07304024955538a84c3e73f54cd3e3fcc4e8dba63e25575) = (1ul << 37) ,     [MemoryManager](class_tale_worlds_1_1_library_1_1_debug.html#a61f2e57c9e78f5921c07304024955538a22ad4707c0b28159f43b2961304d905d) = (1ul << 38) ,     [TCP](class_tale_worlds_1_1_library_1_1_debug.html#a61f2e57c9e78f5921c07304024955538ab136ef5f6a01d816991fe3cf7a6ac763) = (1ul << 39) ,     [FileManager](class_tale_worlds_1_1_library_1_1_debug.html#a61f2e57c9e78f5921c07304024955538a0075136f1cbc7b0e01ef09f94ade05a4) = (1ul << 40) ,     [NaturalInteractionDevice](class_tale_worlds_1_1_library_1_1_debug.html#a61f2e57c9e78f5921c07304024955538a39d5612393819acefb1f0a6bddeac2c1) = (1ul << 41) ,     [UDP](class_tale_worlds_1_1_library_1_1_debug.html#a61f2e57c9e78f5921c07304024955538af5ef036b4d8b630721e51fe23489fbc9) = (1ul << 42) ,     [ResourceManager](class_tale_worlds_1_1_library_1_1_debug.html#a61f2e57c9e78f5921c07304024955538aed760e01ef8cb789b502ad1c9a3829a2) = (1ul << 43) ,     [Mono](class_tale_worlds_1_1_library_1_1_debug.html#a61f2e57c9e78f5921c07304024955538a5d9b47bd3b65072e0d5daf55f01da086) = (1ul << 44) ,     [ONO](class_tale_worlds_1_1_library_1_1_debug.html#a61f2e57c9e78f5921c07304024955538a624449e6e8b2fa12ea122dbf0c051397) = (1ul << 45) ,     [Old](class_tale_worlds_1_1_library_1_1_debug.html#a61f2e57c9e78f5921c07304024955538ac7268757fbabf48019f4984933539d8a) = (1ul << 46) ,     [Sound](class_tale_worlds_1_1_library_1_1_debug.html#a61f2e57c9e78f5921c07304024955538a9d07e0e08af7f96cf45be0112b9ccfbe) = (1ul << 48) ,     [CombatLog](class_tale_worlds_1_1_library_1_1_debug.html#a61f2e57c9e78f5921c07304024955538a4963bc3e72ee2bf0ae70cd437025f7f5) = (1ul << 49) ,     [Notifications](class_tale_worlds_1_1_library_1_1_debug.html#a61f2e57c9e78f5921c07304024955538aa274f4d4670213a9045ce258c6c56b80) = (1ul << 50) ,     [Quest](class_tale_worlds_1_1_library_1_1_debug.html#a61f2e57c9e78f5921c07304024955538a07bf513a88c3df282a30cb374f8a933d) = (1ul << 51) ,     [Dialog](class_tale_worlds_1_1_library_1_1_debug.html#a61f2e57c9e78f5921c07304024955538ad2ab42830caa7a02b36d96a46dd44b8d) = (1ul << 52) ,     [Steam](class_tale_worlds_1_1_library_1_1_debug.html#a61f2e57c9e78f5921c07304024955538a4db4563826bad0eb2f60ee6e42d0ea4b) = (1ul << 53) ,     [All](class_tale_worlds_1_1_library_1_1_debug.html#a61f2e57c9e78f5921c07304024955538ab1c94ca2fbc3e78fc30069c8d0f01680) = 0xFFFFFFFF00000000ul ,     [DefaultMask](class_tale_worlds_1_1_library_1_1_debug.html#a61f2e57c9e78f5921c07304024955538a01c3951471b834aec0235d665d16b0e5) = All   } |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [TelemetryLevelMask](namespace_tale_worlds_1_1_library.html#ad8d0f76bfd44b70413c051072cad64f6) | [GetTelemetryLevelMask](class_tale_worlds_1_1_library_1_1_debug.html#a81cbce35ae6c12e0cebce5dd1ae30da7) () |
| static void | [SetCrashReportCustomString](class_tale_worlds_1_1_library_1_1_debug.html#a1412e081ccedf98af8dee3c14941d6e3) (string customString) |
| static void | [SetCrashReportCustomStack](class_tale_worlds_1_1_library_1_1_debug.html#a88ec21a6f5b75a77eaca071ab5cf99b8) (string customStack) |
| static void | [Assert](class_tale_worlds_1_1_library_1_1_debug.html#a4d8f3b00f7d7e83e0cf3de31298619cf) (bool condition, string message, [CallerFilePath] string callerFile="", [CallerMemberName] string callerMethod="", [CallerLineNumber] int callerLine=0) |
| static void | [FailedAssert](class_tale_worlds_1_1_library_1_1_debug.html#a84e133387a0273f30d0b76f8ee660716) (string message, [CallerFilePath] string callerFile="", [CallerMemberName] string callerMethod="", [CallerLineNumber] int callerLine=0) |
| static void | [SilentAssert](class_tale_worlds_1_1_library_1_1_debug.html#a55f7732484c0c75c0de74c0a4377283d) (bool condition, string message="", bool getDump=false, [CallerFilePath] string callerFile="", [CallerMemberName] string callerMethod="", [CallerLineNumber] int callerLine=0) |
| static void | [ShowError](class_tale_worlds_1_1_library_1_1_debug.html#adabe72f8ee9ed7912bbdd0562b9ef5d2) (string message) |
| static void | [ShowWarning](class_tale_worlds_1_1_library_1_1_debug.html#ab7128186dad888ff8e50167732a8af3c) (string message) |
| static void | [ReportMemoryBookmark](class_tale_worlds_1_1_library_1_1_debug.html#a1a5278be2f8dfcd992fc0337fef891a1) (string message) |
| static void | [Print](class_tale_worlds_1_1_library_1_1_debug.html#a2c023345dacd5d8560358d6146323fb5) (string message, int logLevel=0, [DebugColor](class_tale_worlds_1_1_library_1_1_debug.html#a8303c1b9b6fedc6038077e3b560b2446) color=[DebugColor.White](class_tale_worlds_1_1_library_1_1_debug.html#a8303c1b9b6fedc6038077e3b560b2446a25a81701fbfa4a1efdf660a950c1d006), ulong debugFilter=(ulong) [DebugSystemFilter.Mono](class_tale_worlds_1_1_library_1_1_debug.html#a61f2e57c9e78f5921c07304024955538a5d9b47bd3b65072e0d5daf55f01da086)) |
| static void | [ShowMessageBox](class_tale_worlds_1_1_library_1_1_debug.html#afd3291b479ef58a97c39c35a3c31fab4) (string lpText, string lpCaption, uint uType) |
| static void | [PrintWarning](class_tale_worlds_1_1_library_1_1_debug.html#a6e5fdb8fc3d6d43673fcb090d3d4feb4) (string warning, ulong debugFilter=(ulong) [DebugSystemFilter.Mono](class_tale_worlds_1_1_library_1_1_debug.html#a61f2e57c9e78f5921c07304024955538a5d9b47bd3b65072e0d5daf55f01da086)) |
| static void | [PrintError](class_tale_worlds_1_1_library_1_1_debug.html#a1efe770733c88840df44d8d5b5c67928) (string error, string stackTrace=null, ulong debugFilter=(ulong) [DebugSystemFilter.Mono](class_tale_worlds_1_1_library_1_1_debug.html#a61f2e57c9e78f5921c07304024955538a5d9b47bd3b65072e0d5daf55f01da086)) |
| static void | [DisplayDebugMessage](class_tale_worlds_1_1_library_1_1_debug.html#ab38a51316adfe35db9d9626078497e44) (string message) |
| static void | [WatchVariable](class_tale_worlds_1_1_library_1_1_debug.html#adc018962a4671d6ffcfdaccbd016f7c9) (string name, object value) |
| static void | [StartTelemetryConnection](class_tale_worlds_1_1_library_1_1_debug.html#a72d1a97b8acf220212e3df096da873e3) (bool showErrors) |
| static void | [StopTelemetryConnection](class_tale_worlds_1_1_library_1_1_debug.html#a54ff7d0d4884ee7363dee822b07af41d) () |
| static void | [WriteDebugLineOnScreen](class_tale_worlds_1_1_library_1_1_debug.html#acb8223fe1f04f11b4fe190accdcdb613) (string message) |
| static void | [RenderDebugLine](class_tale_worlds_1_1_library_1_1_debug.html#ad5b43bf79c5e5a4928c1045ae52d2190) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) direction, uint color=0xFFFFFFFF, bool depthCheck=false, float time=0.0f) |
| static void | [RenderDebugLineWithThickness](class_tale_worlds_1_1_library_1_1_debug.html#a67b85f21c9e9fd57f3d0f08252189fb2) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) direction, uint color=0xFFFFFFFF, bool depthCheck=false, float time=0.0f, int thickness=0) |
| static void | [RenderDebugSphere](class_tale_worlds_1_1_library_1_1_debug.html#a0eb48e1b5d274e18d2e148142ddc8ce6) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position, float radius, uint color=0xFFFFFFFF, bool depthCheck=false, float time=0.0f) |
| static void | [RenderDebugFrame](class_tale_worlds_1_1_library_1_1_debug.html#ad3750c86f7dae6111498eca08d9be4b8) ([MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame, float lineLength, float time=0.0f) |
| static void | [RenderDebugText](class_tale_worlds_1_1_library_1_1_debug.html#ae0d8cc41a88624599ed33fcde22a4812) (float screenX, float screenY, string text, uint color=0xFFFFFFFF, float time=0.0f) |
| static void | [RenderDebugRectWithColor](class_tale_worlds_1_1_library_1_1_debug.html#a047099138bc1aebe28e14f05113272ff) (float left, float bottom, float right, float top, uint color=0xFFFFFFFF) |
| static void | [RenderDebugText3D](class_tale_worlds_1_1_library_1_1_debug.html#a9ee48f5d6aa02aa4327bbc7665468110) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position, string text, uint color=0xFFFFFFFF, int screenPosOffsetX=0, int screenPosOffsetY=0, float time=0.0f) |
| static [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetDebugVector](class_tale_worlds_1_1_library_1_1_debug.html#a36b1bfb037336ccb9f2f15af27ad9280) () |
| static void | [SetDebugVector](class_tale_worlds_1_1_library_1_1_debug.html#af382b0691c91d4784ab22a3bc6726dd3) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) value) |
| static void | [SetTestModeEnabled](class_tale_worlds_1_1_library_1_1_debug.html#acbec24617073d463646e43fb05985eb9) (bool testModeEnabled) |
| static void | [AbortGame](class_tale_worlds_1_1_library_1_1_debug.html#a6eceeb107a96cd847aaee090b6eb5787) () |

|  |  |
| --- | --- |
| Properties | |
| static [IDebugManager](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html) | [DebugManager](class_tale_worlds_1_1_library_1_1_debug.html#a1fd88709c4461f599bbd932b03321dcc) `[get, set]` |
| static [ITelemetryManager](interface_tale_worlds_1_1_library_1_1_i_telemetry_manager.html) | [TelemetryManager](class_tale_worlds_1_1_library_1_1_debug.html#a7d2a3cc2df7d6f8371ab8fde8852508a) `[get, set]` |

|  |  |
| --- | --- |
| Events | |
| static Action< string, ulong > | [OnPrint](class_tale_worlds_1_1_library_1_1_debug.html#ad3d1f13a0eaa739387be2cafb71d60b6) |
|  | Used externally for debugging purposed. |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_library_1_1_debug.html#a8303c1b9b6fedc6038077e3b560b2446)DebugColor
---------------------------------------------------------------------------------------------

|  |
| --- |
| enum TaleWorlds.Library.Debug.DebugColor |

| Enumerator | |
| --- | --- |
| DarkRed |  |
| DarkGreen |  |
| DarkBlue |  |
| Red |  |
| Green |  |
| Blue |  |
| DarkCyan |  |
| Cyan |  |
| DarkYellow |  |
| Yellow |  |
| Purple |  |
| Magenta |  |
| White |  |
| BrightWhite |  |

[◆](class_tale_worlds_1_1_library_1_1_debug.html#a01dc023ba5b25e8166652a9607cac294)DebugUserFilter
--------------------------------------------------------------------------------------------------

|  |
| --- |
| enum TaleWorlds.Library.Debug.DebugUserFilter : ulong |

| Enumerator | |
| --- | --- |
| None |  |
| Unused0 |  |
| Unused1 |  |
| Koray |  |
| Armagan |  |
| Intern |  |
| Mustafa |  |
| Oguzhan |  |
| Omer |  |
| Ates |  |
| Unused3 |  |
| Basak |  |
| Can |  |
| Unused4 |  |
| Cem |  |
| Unused5 |  |
| Unused6 |  |
| Emircan |  |
| Unused7 |  |
| All |  |
| Default |  |
| DamageDebug |  |

[◆](class_tale_worlds_1_1_library_1_1_debug.html#a61f2e57c9e78f5921c07304024955538)DebugSystemFilter
----------------------------------------------------------------------------------------------------

|  |
| --- |
| enum TaleWorlds.Library.Debug.DebugSystemFilter : ulong |

| Enumerator | |
| --- | --- |
| None |  |
| Graphics |  |
| ArtificialIntelligence |  |
| MultiPlayer |  |
| IO |  |
| Network |  |
| CampaignEvents |  |
| MemoryManager |  |
| TCP |  |
| FileManager |  |
| NaturalInteractionDevice |  |
| UDP |  |
| ResourceManager |  |
| Mono |  |
| ONO |  |
| Old |  |
| Sound |  |
| CombatLog |  |
| Notifications |  |
| Quest |  |
| Dialog |  |
| Steam |  |
| All |  |
| DefaultMask |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_library_1_1_debug.html#a81cbce35ae6c12e0cebce5dd1ae30da7)GetTelemetryLevelMask()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [TelemetryLevelMask](namespace_tale_worlds_1_1_library.html#ad8d0f76bfd44b70413c051072cad64f6) TaleWorlds.Library.Debug.GetTelemetryLevelMask | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_debug.html#a1412e081ccedf98af8dee3c14941d6e3)SetCrashReportCustomString()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Library.Debug.SetCrashReportCustomString | ( | string | *customString* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_debug.html#a88ec21a6f5b75a77eaca071ab5cf99b8)SetCrashReportCustomStack()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Library.Debug.SetCrashReportCustomStack | ( | string | *customStack* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_debug.html#a4d8f3b00f7d7e83e0cf3de31298619cf)Assert()
-------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Library.Debug.Assert | ( | bool | *condition*, | |  |  | string | *message*, | |  |  | [CallerFilePath] string | *callerFile* = "", | |  |  | [CallerMemberName] string | *callerMethod* = "", | |  |  | [CallerLineNumber] int | *callerLine* = 0 ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_debug.html#a84e133387a0273f30d0b76f8ee660716)FailedAssert()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Library.Debug.FailedAssert | ( | string | *message*, | |  |  | [CallerFilePath] string | *callerFile* = "", | |  |  | [CallerMemberName] string | *callerMethod* = "", | |  |  | [CallerLineNumber] int | *callerLine* = 0 ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_debug.html#a55f7732484c0c75c0de74c0a4377283d)SilentAssert()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Library.Debug.SilentAssert | ( | bool | *condition*, | |  |  | string | *message* = "", | |  |  | bool | *getDump* = false, | |  |  | [CallerFilePath] string | *callerFile* = "", | |  |  | [CallerMemberName] string | *callerMethod* = "", | |  |  | [CallerLineNumber] int | *callerLine* = 0 ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_debug.html#adabe72f8ee9ed7912bbdd0562b9ef5d2)ShowError()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Library.Debug.ShowError | ( | string | *message* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_debug.html#ab7128186dad888ff8e50167732a8af3c)ShowWarning()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Library.Debug.ShowWarning | ( | string | *message* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_debug.html#a1a5278be2f8dfcd992fc0337fef891a1)ReportMemoryBookmark()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Library.Debug.ReportMemoryBookmark | ( | string | *message* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_debug.html#a2c023345dacd5d8560358d6146323fb5)Print()
------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Library.Debug.Print | ( | string | *message*, | |  |  | int | *logLevel* = 0, | |  |  | [DebugColor](class_tale_worlds_1_1_library_1_1_debug.html#a8303c1b9b6fedc6038077e3b560b2446) | *color* = [DebugColor::White](class_tale_worlds_1_1_library_1_1_debug.html#a8303c1b9b6fedc6038077e3b560b2446a25a81701fbfa4a1efdf660a950c1d006), | |  |  | ulong | *debugFilter* = (ulong)[DebugSystemFilter::Mono](class_tale_worlds_1_1_library_1_1_debug.html#a61f2e57c9e78f5921c07304024955538a5d9b47bd3b65072e0d5daf55f01da086) ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_debug.html#afd3291b479ef58a97c39c35a3c31fab4)ShowMessageBox()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Library.Debug.ShowMessageBox | ( | string | *lpText*, | |  |  | string | *lpCaption*, | |  |  | uint | *uType* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_debug.html#a6e5fdb8fc3d6d43673fcb090d3d4feb4)PrintWarning()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Library.Debug.PrintWarning | ( | string | *warning*, | |  |  | ulong | *debugFilter* = (ulong)[DebugSystemFilter::Mono](class_tale_worlds_1_1_library_1_1_debug.html#a61f2e57c9e78f5921c07304024955538a5d9b47bd3b65072e0d5daf55f01da086) ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_debug.html#a1efe770733c88840df44d8d5b5c67928)PrintError()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Library.Debug.PrintError | ( | string | *error*, | |  |  | string | *stackTrace* = null, | |  |  | ulong | *debugFilter* = (ulong)[DebugSystemFilter::Mono](class_tale_worlds_1_1_library_1_1_debug.html#a61f2e57c9e78f5921c07304024955538a5d9b47bd3b65072e0d5daf55f01da086) ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_debug.html#ab38a51316adfe35db9d9626078497e44)DisplayDebugMessage()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Library.Debug.DisplayDebugMessage | ( | string | *message* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_debug.html#adc018962a4671d6ffcfdaccbd016f7c9)WatchVariable()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Library.Debug.WatchVariable | ( | string | *name*, | |  |  | object | *value* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_debug.html#a72d1a97b8acf220212e3df096da873e3)StartTelemetryConnection()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Library.Debug.StartTelemetryConnection | ( | bool | *showErrors* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_debug.html#a54ff7d0d4884ee7363dee822b07af41d)StopTelemetryConnection()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Library.Debug.StopTelemetryConnection | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_debug.html#acb8223fe1f04f11b4fe190accdcdb613)WriteDebugLineOnScreen()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Library.Debug.WriteDebugLineOnScreen | ( | string | *message* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_debug.html#ad5b43bf79c5e5a4928c1045ae52d2190)RenderDebugLine()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Library.Debug.RenderDebugLine | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *direction*, | |  |  | uint | *color* = 0xFFFFFFFF, | |  |  | bool | *depthCheck* = false, | |  |  | float | *time* = 0::0f ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_debug.html#a67b85f21c9e9fd57f3d0f08252189fb2)RenderDebugLineWithThickness()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Library.Debug.RenderDebugLineWithThickness | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *direction*, | |  |  | uint | *color* = 0xFFFFFFFF, | |  |  | bool | *depthCheck* = false, | |  |  | float | *time* = 0::0f, | |  |  | int | *thickness* = 0 ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_debug.html#a0eb48e1b5d274e18d2e148142ddc8ce6)RenderDebugSphere()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Library.Debug.RenderDebugSphere | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position*, | |  |  | float | *radius*, | |  |  | uint | *color* = 0xFFFFFFFF, | |  |  | bool | *depthCheck* = false, | |  |  | float | *time* = 0::0f ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_debug.html#ad3750c86f7dae6111498eca08d9be4b8)RenderDebugFrame()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Library.Debug.RenderDebugFrame | ( | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame*, | |  |  | float | *lineLength*, | |  |  | float | *time* = 0::0f ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_debug.html#ae0d8cc41a88624599ed33fcde22a4812)RenderDebugText()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Library.Debug.RenderDebugText | ( | float | *screenX*, | |  |  | float | *screenY*, | |  |  | string | *text*, | |  |  | uint | *color* = 0xFFFFFFFF, | |  |  | float | *time* = 0::0f ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_debug.html#a047099138bc1aebe28e14f05113272ff)RenderDebugRectWithColor()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Library.Debug.RenderDebugRectWithColor | ( | float | *left*, | |  |  | float | *bottom*, | |  |  | float | *right*, | |  |  | float | *top*, | |  |  | uint | *color* = 0xFFFFFFFF ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_debug.html#a9ee48f5d6aa02aa4327bbc7665468110)RenderDebugText3D()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Library.Debug.RenderDebugText3D | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position*, | |  |  | string | *text*, | |  |  | uint | *color* = 0xFFFFFFFF, | |  |  | int | *screenPosOffsetX* = 0, | |  |  | int | *screenPosOffsetY* = 0, | |  |  | float | *time* = 0::0f ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_debug.html#a36b1bfb037336ccb9f2f15af27ad9280)GetDebugVector()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Library.Debug.GetDebugVector | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_debug.html#af382b0691c91d4784ab22a3bc6726dd3)SetDebugVector()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Library.Debug.SetDebugVector | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *value* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_debug.html#acbec24617073d463646e43fb05985eb9)SetTestModeEnabled()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Library.Debug.SetTestModeEnabled | ( | bool | *testModeEnabled* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_debug.html#a6eceeb107a96cd847aaee090b6eb5787)AbortGame()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Library.Debug.AbortGame | ( |  | ) |  | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_library_1_1_debug.html#a1fd88709c4461f599bbd932b03321dcc)DebugManager
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IDebugManager](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html) TaleWorlds.Library.Debug.DebugManager | | staticgetset |

[◆](class_tale_worlds_1_1_library_1_1_debug.html#a7d2a3cc2df7d6f8371ab8fde8852508a)TelemetryManager
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ITelemetryManager](interface_tale_worlds_1_1_library_1_1_i_telemetry_manager.html) TaleWorlds.Library.Debug.TelemetryManager | | staticgetset |

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_library_1_1_debug.html#ad3d1f13a0eaa739387be2cafb71d60b6)OnPrint
------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<string, ulong> TaleWorlds.Library.Debug.OnPrint | | static |

