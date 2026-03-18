--- SOURCE: class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html ---

TaleWorlds.Engine.Options.NativeOptions Class Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [ConfigQuality](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#ad7f49467b0a407a876ea0a0c26735cc5) {     [GFXVeryLow](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#ad7f49467b0a407a876ea0a0c26735cc5a3c8bee4d5c68319b818f02b2130915ad) = 0 ,     [GFXLow](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#ad7f49467b0a407a876ea0a0c26735cc5a3d157fa3e680c48663211334e70b58d1) = 1 ,     [GFXMedium](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#ad7f49467b0a407a876ea0a0c26735cc5a3dd0f0e9c0978c555e30f9e51590fed4) = 2 ,     [GFXHigh](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#ad7f49467b0a407a876ea0a0c26735cc5a603cbece6d8ad5bbc2c43e510d0afc12) = 3 ,     [GFXVeryHigh](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#ad7f49467b0a407a876ea0a0c26735cc5aca8c4f7c6454b54ce4e4700a8a6eb804) = 4 ,     [GFXCustom](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#ad7f49467b0a407a876ea0a0c26735cc5ac6ba6d691c38d5e61fed7bffe2d513f6) = 5   } |
| enum | [NativeOptionsType](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6) : int {     [None](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6a6adf97f83acf6453d4a6a4b1070f3754) = -1 ,     [MasterVolume](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6a8cc7f554aba0291dd3336e13e0370f12) = 0 ,     [SoundVolume](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6ae38a1914813936851478ce3318217f68) = 1 ,     [MusicVolume](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6ab87d968cb6bb395d225258f27d5136c0) ,     [VoiceChatVolume](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6ab7a786a7167ab2fe99e10f38ccaaeaaf) ,     [VoiceOverVolume](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6a720d6d84c5d839f881ca5c9f373b92de) ,     [SoundDevice](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6a62f888626c599a46404f2e1d6074f187) ,     [MaxSimultaneousSoundEventCount](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6afb70544fb473d05bfb4f01a398b459e7) ,     [SoundPreset](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6aaea7611d3103ceab847a15af6cf1a767) ,     [KeepSoundInBackground](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6a62c0b70121f1610b3d1116414413b167) ,     [SoundOcclusion](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6ac299422e56a91172a892ccd1d27f583a) ,     [MouseSensitivity](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6aba7a4e9f3b4b27c9652017e90bb3fc63) ,     [InvertMouseYAxis](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6a36f067f50e1eb529dd416f9bc6a63e4b) ,     [MouseYMovementScale](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6a7ca129be044a339371e68c4ef0fac0c6) ,     [TrailAmount](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6aca7778e8393dc36bcd7aeaa995273c48) ,     [EnableVibration](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6aa03eb94faf80252517834487295bef85) ,     [EnableGyroAssistedAim](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6adc22d4dafefa92a524870dd4bb698166) ,     [GyroAimSensitivity](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6a8203d8b8bb4a90971111b63e0886ec37) ,     [EnableTouchpadMouse](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6a88594f5b0f58a4a653d4f9be7ee304a3) ,     [EnableAlternateAiming](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6aa800da18d36f4d034dbea511d987cd4f) ,     [DisplayMode](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6aae99aba6a9e7bcd58153e2234c255d46) ,     [SelectedMonitor](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6a9a89b11a9e203c3090003d6d12e0a1d9) ,     [SelectedAdapter](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6a50b20aadbf176ebaf72b2a6c509bcc10) ,     [ScreenResolution](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6a1271514be04d5b75d3349bedfa9d97f2) ,     [RefreshRate](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6a4cb6a64aa6060dc3282dd238e7c57a56) ,     [ResolutionScale](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6adfb6b3dc46d248252d841d015660cc48) ,     [FrameLimiter](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6ad37a91849bec217ed3083659417bed3e) ,     [VSync](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6a98b06ef30caa386be0f897d0e5c5a135) ,     [Brightness](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6ab25323f99788ce64617f018b8a9f5f70) ,     [OverAll](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6aab0c186697cf938ca4236f623ebf4c0a) ,     [ShaderQuality](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6acc0415879b6ee4a8125b78238dbbf9aa) ,     [TextureBudget](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6ae82b6ff2421b41f29c3ecbc203b3ef87) ,     [TextureQuality](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6a99a3bb3ce7a02993947cb57434dd1439) ,     [ShadowmapResolution](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6acca468578169fc2ca16782885ddd5d2c) ,     [ShadowmapType](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6a2bd9fade9f5e8c58557db7343c685a11) ,     [ShadowmapFiltering](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6a5a1872d19ebae63af476ada122c8a6bc) ,     [ParticleDetail](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6adff839b25d43df1ba5004f8be0efd60e) ,     [ParticleQuality](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6a26f80d7fb5b249d9ce8527687744bb43) ,     [FoliageQuality](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6a8a3bb538bcd6482d52a525acdb254c72) ,     [CharacterDetail](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6a82c1692a6a2169a146953c70118d01c9) ,     [EnvironmentDetail](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6a3b734e3e4c0692864a910890dd21acf9) ,     [TerrainQuality](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6ad0ed081221aeb1691afed99fc6ed6ed4) ,     [NumberOfRagDolls](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6ae51dfe112828ff060d92bbeb58db9188) ,     [AnimationSamplingQuality](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6aade752c35755fd9a5254a603c0d6f5b1) ,     [Occlusion](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6aaaceaef1909e0c12c4eb1a0d2b4bc42f) ,     [TextureFiltering](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6af5ecd608ece94f641dc2f5d1fef14722) ,     [WaterQuality](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6ad6177cce213e1f40101a8e917f9e1f63) ,     [Antialiasing](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6abe2e7b79019158c00e374a658ef4ebf8) ,     [DLSS](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6a7556084ad8fdbd67e713c19b0befbeeb) ,     [LightingQuality](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6a063a7dbf6180f814c64cd1835b6b5588) ,     [DecalQuality](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6af1dc91b749551c0dccd3dc3ecc82127e) ,     [DepthOfField](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6a66a45ffadda29d57e51bc9e5ebb34364) ,     [SSR](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6a1c16e694abe7b18f52484174b0aa3c87) ,     [ClothSimulation](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6ad19d95f9d7aaf736aee103cd5aa5e752) ,     [InteractiveGrass](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6ab02f796a4388f95b07abe76b1109609c) ,     [SunShafts](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6a38ff0ad2037b8a3fdd0e56681f46df66) ,     [SSSSS](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6a3389aad9193234e1e88b726958fe20b5) ,     [Tesselation](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6a6c92ec979d177ed7b18683f1d76642ba) ,     [Bloom](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6ae57cdfbc09f4e0f7445c279d9f580bdd) ,     [FilmGrain](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6ad83ba28f0127b67e14a4cc7d80a709b5) ,     [MotionBlur](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6afe48233724644e35fefdd8e6600946a3) ,     [SharpenAmount](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6aef105d2a2e4c7ed957be5cd79241464e) ,     [PostFXLensFlare](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6a77a7f7c15765ed284490e7fb88094fbe) ,     [PostFXStreaks](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6a90c470dbeeb20a805e59c53619b4c312) ,     [PostFXChromaticAberration](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6afc24a17c8497fa83337f01c042f85576) ,     [PostFXVignette](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6a673dbee4eb98ad62120214dbb59a8dc5) ,     [PostFXHexagonVignette](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6afc4dbcd47035101bc737f1fc6dd5f4d2) ,     [BrightnessMin](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6ac55eab081b690fc7dd33d816f45f0311) ,     [BrightnessMax](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6a242e669be5b2046ec988f0fb219076a7) ,     [BrightnessCalibrated](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6aaa671333a73ec999c1e9e3473553dc96) ,     [ExposureCompensation](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6adaf0fc279aa9743069261893e0bb1271) ,     [DynamicResolution](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6ade9b35456f7dfd717b82fa64202114c6) ,     [DynamicResolutionTarget](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6af85ce53520e209be9a5734516f614aaf) ,     [FSR](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6aa8847ff460e700f63a54f06a667534b1) ,     [PhysicsTickRate](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6af6bd7208e93caa33faee3187176a8dcf) ,     [NumOfOptionTypes](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6a7af2fa255b44d2a67ca78b2a5fc20d27) ,     [TotalOptions](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6a0dd372f39071f7fdd12b7c7eff704f3f)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| delegate void | [OnNativeOptionChangedDelegate](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a2127fdb0fcae313548df6a68a7cb02df) ([NativeOptionsType](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6) changedNativeOptionsType) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static string | [GetGFXPresetName](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a6cc90669a34d39cb58c9b359c8cf8067) ([NativeOptions.ConfigQuality](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#ad7f49467b0a407a876ea0a0c26735cc5) presetIndex) |
| static bool | [IsGFXOptionChangeable](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a6b249798b3a73e70c18c29b0d6a2a221) ([ConfigQuality](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#ad7f49467b0a407a876ea0a0c26735cc5) config) |
| static void | [ReadRGLConfigFiles](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a50d7eefc6de559d4cedba1415f5702dd) () |
| static float | [GetConfig](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#aba01acd1c57feaba25333e1dc944fa21) ([NativeOptionsType](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6) type) |
| static float | [GetDefaultConfig](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#abe19fc1aa45b66f5384fbc522b889ecc) ([NativeOptionsType](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6) type) |
| static float | [GetDefaultConfigForOverallSettings](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#acae1a963c580e5e1dea2d332e9223756) ([NativeOptionsType](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6) type, int config) |
| static int | [GetGameKeys](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#ad87fc40e45740a856f378a9f12e7c6c7) (int keyType, int i) |
| static string | [GetSoundDeviceName](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a347f9e520c8e333b8b3ce7555e4f57bb) (int i) |
| static string | [GetMonitorDeviceName](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a24a132a3a499730fe332b48d1f6f2434) (int i) |
| static string | [GetVideoDeviceName](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#ac6371b6c1dba7fe76dbd184bbc8805b0) (int i) |
| static int | [GetSoundDeviceCount](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a7d29341f9f4d1d298c90f209a38e5f26) () |
| static int | [GetMonitorDeviceCount](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#ae61814dffb6c8d1d81296fe83f988013) () |
| static int | [GetVideoDeviceCount](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#ac4afeb11a911a14c101a2ee757a657ba) () |
| static int | [GetResolutionCount](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a79a2eb649ecd95e3860faa795b6f7b5c) () |
| static void | [RefreshOptionsData](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a2567cffb1009ded517cc0c5f0e880a32) () |
| static int | [GetRefreshRateCount](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#ac1cda378602aa051430e979a0cbbc45e) () |
| static int | [GetRefreshRateAtIndex](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#ae362a246340e6a29ce00ed9b492545eb) (int index) |
| static void | [SetCustomResolution](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a24317e607b248e3477a1e980694a36c4) (int width, int height) |
| static void | [GetResolution](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a1490e00638339e0268c17ced3a4d1bb2) (ref int width, ref int height) |
| static void | [GetDesktopResolution](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a8975a934b3f12df5c87aa0dedececc74) (ref int width, ref int height) |
| static [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetResolutionAtIndex](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#af093606b8e14882ed89068803e548e96) (int index) |
| static int | [GetDLSSTechnique](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#abd07e578ff00d2d5fc7900f887e3a7bc) () |
| static bool | [Is120HzAvailable](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a144a8802730f0e12e2ba23fdb170a320) () |
| static int | [GetDLSSOptionCount](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#af264eda99f676bddc8867ce2f294bec6) () |
| static bool | [GetIsDLSSAvailable](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a5bf24b17f9274d39d84666d01c0873a4) () |
| static bool | [CheckGFXSupportStatus](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a50a2abeb7d984ed1aee409dd59099cfd) (int enumType) |
| static void | [SetConfig](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#acf14f7148a766875594e03381cf71506) ([NativeOptionsType](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6) type, float value) |
| static void | [ApplyConfigChanges](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#af96045e5611c78e844d6087f76f5c1a4) (bool resizeWindow) |
| static void | [SetGameKeys](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a4cd43efa43f7ea157c6a8a63a2b0f3ac) (int keyType, int index, int key) |
| static void | [Apply](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#aa4278aea2ae00b372684ab674265f2a5) (int texture\_budget, int sharpen\_amount, int hdr, int dof\_mode, int motion\_blur, int ssr, int size, int texture\_filtering, int trail\_amount, int dynamic\_resolution\_target) |
| static [SaveResult](namespace_tale_worlds_1_1_library.html#a1fede41b93a35a4b6f9d87fcab58a5bc) | [SaveConfig](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a4aa1a6e408f5b15047abce43e3851d38) () |
| static void | [SetBrightness](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a5df47cc2b2ff261e3c21a4a2dcb81fab) (float gamma) |
| static void | [SetDefaultGameKeys](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a481c088c3bc9c0588de88a2402bb444b) () |
| static void | [SetDefaultGameConfig](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a05273275db2413890954bcbbc0b61c66) () |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static [OnNativeOptionChangedDelegate](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a2127fdb0fcae313548df6a68a7cb02df) | [OnNativeOptionChanged](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a68ce5063ddc701942ba19810468d1512) |

|  |  |
| --- | --- |
| Properties | |
| static List< [NativeOptionData](class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html) > | [VideoOptions](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a5d7bcd31778332e3f7a2af8ae5399614) `[get]` |
| static List< [NativeOptionData](class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html) > | [GraphicsOptions](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#acb20d0dbc6be1a7244cbb41c12dbe0dc) `[get]` |

|  |  |
| --- | --- |
| Events | |
| static Action | [OnNativeOptionsApplied](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a6b2501deac144d0584d4845647a9dce6) |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#ad7f49467b0a407a876ea0a0c26735cc5)ConfigQuality
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.Engine.Options.NativeOptions.ConfigQuality](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#ad7f49467b0a407a876ea0a0c26735cc5) |

| Enumerator | |
| --- | --- |
| GFXVeryLow |  |
| GFXLow |  |
| GFXMedium |  |
| GFXHigh |  |
| GFXVeryHigh |  |
| GFXCustom |  |

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6)NativeOptionsType
------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.Engine.Options.NativeOptions.NativeOptionsType](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6) : int |

| Enumerator | |
| --- | --- |
| None |  |
| MasterVolume |  |
| SoundVolume |  |
| MusicVolume |  |
| VoiceChatVolume |  |
| VoiceOverVolume |  |
| SoundDevice |  |
| MaxSimultaneousSoundEventCount |  |
| SoundPreset |  |
| KeepSoundInBackground |  |
| SoundOcclusion |  |
| MouseSensitivity |  |
| InvertMouseYAxis |  |
| MouseYMovementScale |  |
| TrailAmount |  |
| EnableVibration |  |
| EnableGyroAssistedAim |  |
| GyroAimSensitivity |  |
| EnableTouchpadMouse |  |
| EnableAlternateAiming |  |
| DisplayMode |  |
| SelectedMonitor |  |
| SelectedAdapter |  |
| ScreenResolution |  |
| RefreshRate |  |
| ResolutionScale |  |
| FrameLimiter |  |
| VSync |  |
| Brightness |  |
| OverAll |  |
| ShaderQuality |  |
| TextureBudget |  |
| TextureQuality |  |
| ShadowmapResolution |  |
| ShadowmapType |  |
| ShadowmapFiltering |  |
| ParticleDetail |  |
| ParticleQuality |  |
| FoliageQuality |  |
| CharacterDetail |  |
| EnvironmentDetail |  |
| TerrainQuality |  |
| NumberOfRagDolls |  |
| AnimationSamplingQuality |  |
| Occlusion |  |
| TextureFiltering |  |
| WaterQuality |  |
| Antialiasing |  |
| DLSS |  |
| LightingQuality |  |
| DecalQuality |  |
| DepthOfField |  |
| SSR |  |
| ClothSimulation |  |
| InteractiveGrass |  |
| SunShafts |  |
| SSSSS |  |
| Tesselation |  |
| Bloom |  |
| FilmGrain |  |
| MotionBlur |  |
| SharpenAmount |  |
| PostFXLensFlare |  |
| PostFXStreaks |  |
| PostFXChromaticAberration |  |
| PostFXVignette |  |
| PostFXHexagonVignette |  |
| BrightnessMin |  |
| BrightnessMax |  |
| BrightnessCalibrated |  |
| ExposureCompensation |  |
| DynamicResolution |  |
| DynamicResolutionTarget |  |
| FSR |  |
| PhysicsTickRate |  |
| NumOfOptionTypes |  |
| TotalOptions |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a6cc90669a34d39cb58c9b359c8cf8067)GetGFXPresetName()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.Engine.Options.NativeOptions.GetGFXPresetName | ( | [NativeOptions.ConfigQuality](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#ad7f49467b0a407a876ea0a0c26735cc5) | *presetIndex* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a6b249798b3a73e70c18c29b0d6a2a221)IsGFXOptionChangeable()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.Options.NativeOptions.IsGFXOptionChangeable | ( | [ConfigQuality](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#ad7f49467b0a407a876ea0a0c26735cc5) | *config* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a2127fdb0fcae313548df6a68a7cb02df)OnNativeOptionChangedDelegate()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| delegate void TaleWorlds.Engine.Options.NativeOptions.OnNativeOptionChangedDelegate | ( | [NativeOptionsType](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6) | *changedNativeOptionsType* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a50d7eefc6de559d4cedba1415f5702dd)ReadRGLConfigFiles()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Options.NativeOptions.ReadRGLConfigFiles | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#aba01acd1c57feaba25333e1dc944fa21)GetConfig()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.Engine.Options.NativeOptions.GetConfig | ( | [NativeOptionsType](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6) | *type* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#abe19fc1aa45b66f5384fbc522b889ecc)GetDefaultConfig()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.Engine.Options.NativeOptions.GetDefaultConfig | ( | [NativeOptionsType](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6) | *type* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#acae1a963c580e5e1dea2d332e9223756)GetDefaultConfigForOverallSettings()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.Engine.Options.NativeOptions.GetDefaultConfigForOverallSettings | ( | [NativeOptionsType](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6) | *type*, | |  |  | int | *config* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#ad87fc40e45740a856f378a9f12e7c6c7)GetGameKeys()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.Engine.Options.NativeOptions.GetGameKeys | ( | int | *keyType*, | |  |  | int | *i* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a347f9e520c8e333b8b3ce7555e4f57bb)GetSoundDeviceName()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.Engine.Options.NativeOptions.GetSoundDeviceName | ( | int | *i* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a24a132a3a499730fe332b48d1f6f2434)GetMonitorDeviceName()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.Engine.Options.NativeOptions.GetMonitorDeviceName | ( | int | *i* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#ac6371b6c1dba7fe76dbd184bbc8805b0)GetVideoDeviceName()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.Engine.Options.NativeOptions.GetVideoDeviceName | ( | int | *i* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a7d29341f9f4d1d298c90f209a38e5f26)GetSoundDeviceCount()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.Engine.Options.NativeOptions.GetSoundDeviceCount | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#ae61814dffb6c8d1d81296fe83f988013)GetMonitorDeviceCount()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.Engine.Options.NativeOptions.GetMonitorDeviceCount | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#ac4afeb11a911a14c101a2ee757a657ba)GetVideoDeviceCount()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.Engine.Options.NativeOptions.GetVideoDeviceCount | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a79a2eb649ecd95e3860faa795b6f7b5c)GetResolutionCount()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.Engine.Options.NativeOptions.GetResolutionCount | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a2567cffb1009ded517cc0c5f0e880a32)RefreshOptionsData()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Options.NativeOptions.RefreshOptionsData | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#ac1cda378602aa051430e979a0cbbc45e)GetRefreshRateCount()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.Engine.Options.NativeOptions.GetRefreshRateCount | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#ae362a246340e6a29ce00ed9b492545eb)GetRefreshRateAtIndex()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.Engine.Options.NativeOptions.GetRefreshRateAtIndex | ( | int | *index* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a24317e607b248e3477a1e980694a36c4)SetCustomResolution()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.Options.NativeOptions.SetCustomResolution | ( | int | *width*, | |  |  | int | *height* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a1490e00638339e0268c17ced3a4d1bb2)GetResolution()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.Options.NativeOptions.GetResolution | ( | ref int | *width*, | |  |  | ref int | *height* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a8975a934b3f12df5c87aa0dedececc74)GetDesktopResolution()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.Options.NativeOptions.GetDesktopResolution | ( | ref int | *width*, | |  |  | ref int | *height* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#af093606b8e14882ed89068803e548e96)GetResolutionAtIndex()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.Engine.Options.NativeOptions.GetResolutionAtIndex | ( | int | *index* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#abd07e578ff00d2d5fc7900f887e3a7bc)GetDLSSTechnique()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.Engine.Options.NativeOptions.GetDLSSTechnique | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a144a8802730f0e12e2ba23fdb170a320)Is120HzAvailable()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.Options.NativeOptions.Is120HzAvailable | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#af264eda99f676bddc8867ce2f294bec6)GetDLSSOptionCount()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.Engine.Options.NativeOptions.GetDLSSOptionCount | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a5bf24b17f9274d39d84666d01c0873a4)GetIsDLSSAvailable()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.Options.NativeOptions.GetIsDLSSAvailable | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a50a2abeb7d984ed1aee409dd59099cfd)CheckGFXSupportStatus()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.Options.NativeOptions.CheckGFXSupportStatus | ( | int | *enumType* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#acf14f7148a766875594e03381cf71506)SetConfig()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.Options.NativeOptions.SetConfig | ( | [NativeOptionsType](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6) | *type*, | |  |  | float | *value* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#af96045e5611c78e844d6087f76f5c1a4)ApplyConfigChanges()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Options.NativeOptions.ApplyConfigChanges | ( | bool | *resizeWindow* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a4cd43efa43f7ea157c6a8a63a2b0f3ac)SetGameKeys()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.Options.NativeOptions.SetGameKeys | ( | int | *keyType*, | |  |  | int | *index*, | |  |  | int | *key* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#aa4278aea2ae00b372684ab674265f2a5)Apply()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.Options.NativeOptions.Apply | ( | int | *texture\_budget*, | |  |  | int | *sharpen\_amount*, | |  |  | int | *hdr*, | |  |  | int | *dof\_mode*, | |  |  | int | *motion\_blur*, | |  |  | int | *ssr*, | |  |  | int | *size*, | |  |  | int | *texture\_filtering*, | |  |  | int | *trail\_amount*, | |  |  | int | *dynamic\_resolution\_target* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a4aa1a6e408f5b15047abce43e3851d38)SaveConfig()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [SaveResult](namespace_tale_worlds_1_1_library.html#a1fede41b93a35a4b6f9d87fcab58a5bc) TaleWorlds.Engine.Options.NativeOptions.SaveConfig | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a5df47cc2b2ff261e3c21a4a2dcb81fab)SetBrightness()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Options.NativeOptions.SetBrightness | ( | float | *gamma* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a481c088c3bc9c0588de88a2402bb444b)SetDefaultGameKeys()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Options.NativeOptions.SetDefaultGameKeys | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a05273275db2413890954bcbbc0b61c66)SetDefaultGameConfig()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Options.NativeOptions.SetDefaultGameConfig | ( |  | ) |  | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a68ce5063ddc701942ba19810468d1512)OnNativeOptionChanged
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [OnNativeOptionChangedDelegate](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a2127fdb0fcae313548df6a68a7cb02df) TaleWorlds.Engine.Options.NativeOptions.OnNativeOptionChanged | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a5d7bcd31778332e3f7a2af8ae5399614)VideoOptions
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[NativeOptionData](class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html)> TaleWorlds.Engine.Options.NativeOptions.VideoOptions | | staticget |

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#acb20d0dbc6be1a7244cbb41c12dbe0dc)GraphicsOptions
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[NativeOptionData](class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html)> TaleWorlds.Engine.Options.NativeOptions.GraphicsOptions | | staticget |

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a6b2501deac144d0584d4845647a9dce6)OnNativeOptionsApplied
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action TaleWorlds.Engine.Options.NativeOptions.OnNativeOptionsApplied | | static |

