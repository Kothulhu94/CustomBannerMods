--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html ---

TaleWorlds.MountAndBlade.View.Screens.MissionScreen Class ReferenceInherits ScreenBase, [TaleWorlds.MountAndBlade.IMissionSystemHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_system_handler.html), [TaleWorlds.Core.IGameStateListener](interface_tale_worlds_1_1_core_1_1_i_game_state_listener.html), [TaleWorlds.MountAndBlade.ViewModelCollection.IMissionScreen](interface_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_i_mission_screen.html), [TaleWorlds.MountAndBlade.IMissionListener](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_listener.html), and [TaleWorlds.MountAndBlade.View.IChatLogHandlerScreen](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_i_chat_log_handler_screen.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| delegate void | [OnSpectateAgentDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a8bba74d82d5ef066ce96d1e937d2645b) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) followedAgent) |
| delegate List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | [GatherCustomAgentListToSpectateDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#ad8cfe52e974ef434844060458d2b0434) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) forcedAgentToInclude) |
|  | [MissionScreen](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#aeb06703525e028d6c39958dfb860d01a) ([MissionState](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html) missionState) |
| override void | [OnFocusChangeOnGameWindow](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#acb14f9bfb8c7711b9b0ab31f4460010f) (bool focusGained) |
| void | [SetOrderFlagVisibility](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a26bcdf5dd2e8fb76ca67eb82a67644fd) (bool value) |
| string | [GetFollowText](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a4ccfe6e967448fbbe2ec29ca275206c8) () |
| string | [GetFollowPartyText](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a87764df962a946e412d4f9366ac3840d) () |
| bool | [SetDisplayDialog](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a1e97c786d13c330c2dbf71a8ef61a17b) (bool value) |
| bool | [IsOpeningEscapeMenuOnFocusChangeAllowed](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#af516ec47e5e033f66b333d4feb4a10c0) () |
| bool | [IsPhotoModeAllowed](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a489adcb62a68d5a164bf8872c03e8bd0) () |
| void | [SetExtraCameraParameters](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#aa6c06eda33b433614511a0d76497f993) (bool newForceCanZoom, float newCameraRayCastStartingPointOffset) |
| void | [SetCustomAgentListToSpectateGatherer](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a4a3c35b23f68ad29fc566c9202b221b3) ([GatherCustomAgentListToSpectateDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#ad8cfe52e974ef434844060458d2b0434) gatherer) |
| void | [UpdateFreeCamera](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#acc34d8a4b64d253427907c48e0d11843) ([MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame) |
| void | [OnMainAgentWeaponChanged](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a1e5b9ff96946a2490dc1619fbfbe290a) () |
| bool | [IsViewingCharacter](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a4f180723024bc5dacd2c1a382216f947) () |
| float | [GetCameraToggleProgress](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a2090b6367605253ab014d914c4ddbb7b) () |
| void | [AddMissionView](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#af4931f146dacab12dbd0af7eb1304c42) ([MissionView](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html) missionView) |
| void | [ScreenPointToWorldRay](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a90c215744b31b52d1c3e695558a04340) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) screenPoint, out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) rayBegin, out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) rayEnd) |
| bool | [GetProjectedMousePositionOnGround](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a677a0311678b7a2e8b85ceabd0b9c744) (out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) groundPosition, out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) groundNormal, [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) excludeBodyOwnerFlags, bool checkOccludedSurface) |
| bool | [GetProjectedMousePositionOnWater](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a5d88592474ceed78fd00d97f7fde0ca9) (out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) waterPosition) |
| void | [CancelQuickPositionOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a4b3bb54ac8bab32ceaa5a8e00af70163) () |
| bool | [MissionStartedRendering](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a7c9d08f4f05d294294c6d548be136844) () |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetOrderFlagPosition](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#af9da5c685d72b864f86fa7201d84855f) () |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetOrderFlagFrame](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a5f1da4649c54560ac895dfc3bb63b088) () |
| void | [RegisterRadialMenuObject< T >](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#abafa4ead2941bfe1c4df6943e00ddc86) (T radialMenuOwnerObject) |
| void | [UnregisterRadialMenuObject](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#ac967cbd559e6e1e5b5aeea3ba5b49b3a) (object radialMenuOwnerObject) |
| void | [SetPhotoModeRequiresMouse](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a5d0ffa62de7a042a5354b2557007a2d0) (bool isRequired) |
| void | [SetPhotoModeEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a97abc576d79bede6640d8e5ca8231a8a) (bool isEnabled) |
| void | [SetConversationActive](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a86de90fd687b23f491acd018496bb7af) (bool isActive) |
| void | [SetCameraLockState](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#acf79eae669ea957dfe281e71f8478e07) (bool isLocked) |
| void | [RegisterView](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#ac4fbc713190bf5fca1e6d81b694b2016) ([MissionView](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html) missionView) |
| void | [UnregisterView](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#aa53ac90f09704be26c7b1d5557d513a3) ([MissionView](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html) missionView) |
| virtual void | [TeleportMainAgentToCameraFocusForCheat](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a7860f4b1ddc4f98259b8f31f206b1909) () |
| [IAgentVisual](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html) | [GetPlayerAgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a19db47955c80ec2a49a83983193dd242) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) lobbyPeer) |
| void | [SetAgentToFollow](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a8b09ca42ebcc0bbd97b9f05d5ac7246a) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| [Mission.SpectatorData](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_spectator_data.html) | [GetSpectatingData](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a5703329f814155970480a3cda9bbf361) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) currentCameraPosition) |
| void | [OnEscape](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#acb3ed25a7393dd26f73be75715dd95e8) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static string | [ToggleFixedMissionCamera](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a378095966e8edb8aee00b5aab9f39ffe) (List< string > strings) |
| static void | [SetFixedMissionCameraActive](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a11dc89174eee160be1241f6cb2189fdf) (bool active) |
| static string | [SetShiftCameraSpeed](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a723fe5f3d797b74638480f5372b3fbac) (List< string > strings) |
| static string | [SetCameraPosition](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a4894f1dd067c754f629aaecfc5406ffb) (List< string > strings) |

|  |  |
| --- | --- |
| Public Attributes | |
| Func< [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) > | [GetSpectatedCharacter](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#ae44100104ea8a77595ffe3d8e1f30647) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const int | [LoadingScreenFramesLeftInitial](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a06ae03bcf8cbb89122e20cfc6b5d9f76) = 15 |
| const float | [FirstPersonNearClippingDistance](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a0fa9537c3be1494622cb318515faddf5) = 0.065f |
| const float | [ThirdPersonNearClippingDistance](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#ae2e553a57d4fef553a82e22223175031) = 0.1f |
| const float | [FarClippingDistance](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a3754a0d91cca9b8b9e3f6e4ae450fb86) = 12500.0f |
| const float | [MinCameraAddedDistance](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#afb2aa6d84ff1482e504100ce6d0a31dc) = 0.7f |
| const float | [MinCameraDistanceHardLimit](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a893f4c3c1255b7dba748c656917f6df8) = 0.48f |
| const float | [DefaultViewAngle](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a97aa099779f95177f645239e9294782c) = 65.0f |
| const float | [MaxCameraAddedDistance](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a5f23241614b51ad9af60905ed92d1bbb) = 2.4f |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnInitialize](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a437d9c39fcc3eb20f2be4ea8f14cfc99) () |
|  | This method is called only ones before onactivate. |
| virtual void | [InitializeMissionView](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a5025cb64b3562e8883b15f3247a5f4c4) () |
| override void | [OnActivate](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a315149650b78280e1f4a3fa9e24c3e80) () |
| override void | [OnResume](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#ad357d83d4214584e5b80e52be8c14274) () |
| override void | [OnFrameTick](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a23cc9fe9524a3c685e9f2b184ecd6fce) (float dt) |
| override void | [OnDeactivate](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#aaf9c6006c30323ce0acf193f79905c60) () |
|  | On Deactivate handler. |
| override void | [OnFinalize](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#af1867f9bd4bec59bb3bba1f72f86dcac) () |
| virtual bool | [CanToggleCamera](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a78ce24f3f8dc539881c434fb813fcb85) () |
| virtual bool | [CanViewCharacter](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#ab6185b3b73d59b4d6155f4390fcb95ca) () |
| virtual void | [AfterMissionTick](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a9aa427ba35ba81f52b892336cfaf28ba) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#acf714559311c08d78eb9d0af4a5fab88) mission, float realDt) |

|  |  |
| --- | --- |
| Properties | |
| bool | [LockCameraMovement](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#ac6864418188123ff8429fe8310905182) `[get]` |
| OrderFlag | [OrderFlag](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a5c82f59504c2bdacef18d15ba9c5d65a) `[get, set]` |
| [Camera](class_tale_worlds_1_1_engine_1_1_camera.html) | [CombatCamera](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a061ad01b93837ae3feae949a06f421bf) `[get]` |
| [Camera](class_tale_worlds_1_1_engine_1_1_camera.html) | [CustomCamera](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a70f7c5e6953022b50df0240c5daffc9b) `[get, set]` |
| float | [CameraBearing](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a046cfcd7fc06ab47e1a2d59fc814990c) `[get, set]` |
| float | [MaxCameraZoom](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a97c47aa2e94827cd7b2d566212e42c8a) = 1.0f `[get]` |
| float | [CameraElevation](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#abda9dd6980c8dbd8bfbeab2bd99ae7ef) `[get]` |
| float | [CameraResultDistanceToTarget](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#acc4c23bb34d20277908075765c556f00) `[get]` |
| float | [CameraViewAngle](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a2f8fccb9b2aa200fdccb66c5db19c4c3) `[get]` |
| bool | [IsPhotoModeEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#afcffdad9d78765cd2b860127a15c8859) `[get]` |
|  | Represents if the screen and scene is in the Photo mode. [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) setting can change in cpp, but shouldn't. |
| bool | [IsConversationActive](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#ad662949dd9606175903c5255e5fd55da) `[get]` |
| bool | [IsDeploymentActive](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#aa921deebc906451ca8a4a330712daa06) `[get]` |
| SceneLayer | [SceneLayer](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#aeae376a8fb13c52379452bb478e608bf) `[get]` |
| SceneView | [SceneView](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a862cdbf388b83427eac684add444c017) `[get]` |
| Mission | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#acf714559311c08d78eb9d0af4a5fab88) `[get]` |
| bool | [IsCheatGhostMode](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#acbf07ece87ca3646f368575d981a5abc) `[get, set]` |
| bool | [IsRadialMenuActive](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a8ca92c5a57047c518379b6388679c694) `[get]` |
| [IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html) | [InputManager](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#ae2dc82647caa1e7d41f424cce413dcd0) `[get]` |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [LastFollowedAgent](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#abb2685098de3c6a04cea1c8a999153a1) `[get]` |
| [IAgentVisual](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html) | [LastFollowedAgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a65d01ae0d0284bad41745b78ddab1e1a) `[get, set]` |
| override bool | [MouseVisible](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#ab803186c98c134791f7b17b6a77c90ca) `[get]` |
| bool | [PhotoModeRequiresMouse](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#acc7d0655095c51b016d0af5b99140afc) `[get]` |
| bool | [IsFocusLost](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a0a515babfbe53947eb3f89dfffa03432) `[get]` |
| bool | [IsMissionTickable](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#afc0a4c9a7bd4f7b6b7f094a6d511ceee) `[get]` |

|  |  |
| --- | --- |
| Events | |
| [OnSpectateAgentDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a8bba74d82d5ef066ce96d1e937d2645b) | [OnSpectateAgentFocusIn](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a6bc3596797e54aa4f954dc989d2b5980) |
| [OnSpectateAgentDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a8bba74d82d5ef066ce96d1e937d2645b) | [OnSpectateAgentFocusOut](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a84350bf7a7886ee27f77296001de77b8) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#aeb06703525e028d6c39958dfb860d01a)MissionScreen()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.View.Screens.MissionScreen.MissionScreen | ( | [MissionState](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html) | *missionState* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a8bba74d82d5ef066ce96d1e937d2645b)OnSpectateAgentDelegate()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| delegate void TaleWorlds.MountAndBlade.View.Screens.MissionScreen.OnSpectateAgentDelegate | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *followedAgent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#ad8cfe52e974ef434844060458d2b0434)GatherCustomAgentListToSpectateDelegate()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| delegate List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > TaleWorlds.MountAndBlade.View.Screens.MissionScreen.GatherCustomAgentListToSpectateDelegate | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *forcedAgentToInclude* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a437d9c39fcc3eb20f2be4ea8f14cfc99)OnInitialize()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.Screens.MissionScreen.OnInitialize | ( |  | ) |  | | protected |

Implements [TaleWorlds.Core.IGameStateListener](interface_tale_worlds_1_1_core_1_1_i_game_state_listener.html#a8df8104360d9c66aedb341b13367b8e5).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a5025cb64b3562e8883b15f3247a5f4c4)InitializeMissionView()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.View.Screens.MissionScreen.InitializeMissionView | ( |  | ) |  | | protectedvirtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a315149650b78280e1f4a3fa9e24c3e80)OnActivate()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.Screens.MissionScreen.OnActivate | ( |  | ) |  | | protected |

Implements [TaleWorlds.Core.IGameStateListener](interface_tale_worlds_1_1_core_1_1_i_game_state_listener.html#aa8b05eeab9e1f4691b9ef1ac12a05b77).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#ad357d83d4214584e5b80e52be8c14274)OnResume()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.Screens.MissionScreen.OnResume | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#acb14f9bfb8c7711b9b0ab31f4460010f)OnFocusChangeOnGameWindow()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.MountAndBlade.View.Screens.MissionScreen.OnFocusChangeOnGameWindow | ( | bool | *focusGained* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a26bcdf5dd2e8fb76ca67eb82a67644fd)SetOrderFlagVisibility()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Screens.MissionScreen.SetOrderFlagVisibility | ( | bool | *value* | ) |  |

Implements [TaleWorlds.MountAndBlade.ViewModelCollection.IMissionScreen](interface_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_i_mission_screen.html#a1cc0f02f1933d989aee86af0d0f041e6).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a4ccfe6e967448fbbe2ec29ca275206c8)GetFollowText()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.MountAndBlade.View.Screens.MissionScreen.GetFollowText | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.ViewModelCollection.IMissionScreen](interface_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_i_mission_screen.html#a4231b8fc75ddef2830e00db910abb4d5).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a87764df962a946e412d4f9366ac3840d)GetFollowPartyText()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.MountAndBlade.View.Screens.MissionScreen.GetFollowPartyText | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.ViewModelCollection.IMissionScreen](interface_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_i_mission_screen.html#a9f67669b59057264e17bb170c0853ee3).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a1e97c786d13c330c2dbf71a8ef61a17b)SetDisplayDialog()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.View.Screens.MissionScreen.SetDisplayDialog | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#af516ec47e5e033f66b333d4feb4a10c0)IsOpeningEscapeMenuOnFocusChangeAllowed()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.View.Screens.MissionScreen.IsOpeningEscapeMenuOnFocusChangeAllowed | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a489adcb62a68d5a164bf8872c03e8bd0)IsPhotoModeAllowed()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.View.Screens.MissionScreen.IsPhotoModeAllowed | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#aa6c06eda33b433614511a0d76497f993)SetExtraCameraParameters()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Screens.MissionScreen.SetExtraCameraParameters | ( | bool | *newForceCanZoom*, |
|  |  | float | *newCameraRayCastStartingPointOffset* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a4a3c35b23f68ad29fc566c9202b221b3)SetCustomAgentListToSpectateGatherer()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Screens.MissionScreen.SetCustomAgentListToSpectateGatherer | ( | [GatherCustomAgentListToSpectateDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#ad8cfe52e974ef434844060458d2b0434) | *gatherer* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#acc34d8a4b64d253427907c48e0d11843)UpdateFreeCamera()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Screens.MissionScreen.UpdateFreeCamera | ( | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a23cc9fe9524a3c685e9f2b184ecd6fce)OnFrameTick()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.Screens.MissionScreen.OnFrameTick | ( | float | *dt* | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a1e5b9ff96946a2490dc1619fbfbe290a)OnMainAgentWeaponChanged()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Screens.MissionScreen.OnMainAgentWeaponChanged | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#aaf9c6006c30323ce0acf193f79905c60)OnDeactivate()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.Screens.MissionScreen.OnDeactivate | ( |  | ) |  | | protected |

Implements [TaleWorlds.Core.IGameStateListener](interface_tale_worlds_1_1_core_1_1_i_game_state_listener.html#a64ece7c9e2bec7a45b85be293166b6ef).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#af1867f9bd4bec59bb3bba1f72f86dcac)OnFinalize()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.Screens.MissionScreen.OnFinalize | ( |  | ) |  | | protected |

Implements [TaleWorlds.Core.IGameStateListener](interface_tale_worlds_1_1_core_1_1_i_game_state_listener.html#ac916ee3e48edbf09b47eacac07b5c574).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a378095966e8edb8aee00b5aab9f39ffe)ToggleFixedMissionCamera()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.View.Screens.MissionScreen.ToggleFixedMissionCamera | ( | List< string > | *strings* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a11dc89174eee160be1241f6cb2189fdf)SetFixedMissionCameraActive()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.View.Screens.MissionScreen.SetFixedMissionCameraActive | ( | bool | *active* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a723fe5f3d797b74638480f5372b3fbac)SetShiftCameraSpeed()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.View.Screens.MissionScreen.SetShiftCameraSpeed | ( | List< string > | *strings* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a4894f1dd067c754f629aaecfc5406ffb)SetCameraPosition()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.View.Screens.MissionScreen.SetCameraPosition | ( | List< string > | *strings* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a78ce24f3f8dc539881c434fb813fcb85)CanToggleCamera()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual bool TaleWorlds.MountAndBlade.View.Screens.MissionScreen.CanToggleCamera | ( |  | ) |  | | protectedvirtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#ab6185b3b73d59b4d6155f4390fcb95ca)CanViewCharacter()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual bool TaleWorlds.MountAndBlade.View.Screens.MissionScreen.CanViewCharacter | ( |  | ) |  | | protectedvirtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a4f180723024bc5dacd2c1a382216f947)IsViewingCharacter()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.View.Screens.MissionScreen.IsViewingCharacter | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a2090b6367605253ab014d914c4ddbb7b)GetCameraToggleProgress()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.View.Screens.MissionScreen.GetCameraToggleProgress | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#af4931f146dacab12dbd0af7eb1304c42)AddMissionView()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Screens.MissionScreen.AddMissionView | ( | [MissionView](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html) | *missionView* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a90c215744b31b52d1c3e695558a04340)ScreenPointToWorldRay()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Screens.MissionScreen.ScreenPointToWorldRay | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *screenPoint*, |
|  |  | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *rayBegin*, |
|  |  | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *rayEnd* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a677a0311678b7a2e8b85ceabd0b9c744)GetProjectedMousePositionOnGround()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.View.Screens.MissionScreen.GetProjectedMousePositionOnGround | ( | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *groundPosition*, |
|  |  | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *groundNormal*, |
|  |  | [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) | *excludeBodyOwnerFlags*, |
|  |  | bool | *checkOccludedSurface* ) |

Parameters
:   |  |  |
    | --- | --- |
    | groundPosition |  |

Returns
:   Returns whether mouse cursor is on ground or not.

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a5d88592474ceed78fd00d97f7fde0ca9)GetProjectedMousePositionOnWater()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.View.Screens.MissionScreen.GetProjectedMousePositionOnWater | ( | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *waterPosition* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | waterPosition |  |

Returns
:   Returns whether mouse cursor is on ground or not.

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a4b3bb54ac8bab32ceaa5a8e00af70163)CancelQuickPositionOrder()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Screens.MissionScreen.CancelQuickPositionOrder | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a7c9d08f4f05d294294c6d548be136844)MissionStartedRendering()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.View.Screens.MissionScreen.MissionStartedRendering | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#af9da5c685d72b864f86fa7201d84855f)GetOrderFlagPosition()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.View.Screens.MissionScreen.GetOrderFlagPosition | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a5f1da4649c54560ac895dfc3bb63b088)GetOrderFlagFrame()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.View.Screens.MissionScreen.GetOrderFlagFrame | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#abafa4ead2941bfe1c4df6943e00ddc86)RegisterRadialMenuObject< T >()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Screens.MissionScreen.RegisterRadialMenuObject< T > | ( | T | *radialMenuOwnerObject* | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *class* |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#ac967cbd559e6e1e5b5aeea3ba5b49b3a)UnregisterRadialMenuObject()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Screens.MissionScreen.UnregisterRadialMenuObject | ( | object | *radialMenuOwnerObject* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a5d0ffa62de7a042a5354b2557007a2d0)SetPhotoModeRequiresMouse()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Screens.MissionScreen.SetPhotoModeRequiresMouse | ( | bool | *isRequired* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a97abc576d79bede6640d8e5ca8231a8a)SetPhotoModeEnabled()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Screens.MissionScreen.SetPhotoModeEnabled | ( | bool | *isEnabled* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a86de90fd687b23f491acd018496bb7af)SetConversationActive()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Screens.MissionScreen.SetConversationActive | ( | bool | *isActive* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#acf79eae669ea957dfe281e71f8478e07)SetCameraLockState()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Screens.MissionScreen.SetCameraLockState | ( | bool | *isLocked* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#ac4fbc713190bf5fca1e6d81b694b2016)RegisterView()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Screens.MissionScreen.RegisterView | ( | [MissionView](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html) | *missionView* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#aa53ac90f09704be26c7b1d5557d513a3)UnregisterView()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Screens.MissionScreen.UnregisterView | ( | [MissionView](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html) | *missionView* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a7860f4b1ddc4f98259b8f31f206b1909)TeleportMainAgentToCameraFocusForCheat()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.View.Screens.MissionScreen.TeleportMainAgentToCameraFocusForCheat | ( |  | ) |  | | virtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a19db47955c80ec2a49a83983193dd242)GetPlayerAgentVisuals()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [IAgentVisual](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html) TaleWorlds.MountAndBlade.View.Screens.MissionScreen.GetPlayerAgentVisuals | ( | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) | *lobbyPeer* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a8b09ca42ebcc0bbd97b9f05d5ac7246a)SetAgentToFollow()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Screens.MissionScreen.SetAgentToFollow | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a5703329f814155970480a3cda9bbf361)GetSpectatingData()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Mission.SpectatorData](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_spectator_data.html) TaleWorlds.MountAndBlade.View.Screens.MissionScreen.GetSpectatingData | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *currentCameraPosition* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a9aa427ba35ba81f52b892336cfaf28ba)AfterMissionTick()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.View.Screens.MissionScreen.AfterMissionTick | ( | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#acf714559311c08d78eb9d0af4a5fab88) | *mission*, | |  |  | float | *realDt* ) | | protectedvirtual |

Implements [TaleWorlds.MountAndBlade.IMissionSystemHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_system_handler.html#a99e5f8510a870e231eaed874f67f7c7d).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#acb3ed25a7393dd26f73be75715dd95e8)OnEscape()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Screens.MissionScreen.OnEscape | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a06ae03bcf8cbb89122e20cfc6b5d9f76)LoadingScreenFramesLeftInitial
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.MountAndBlade.View.Screens.MissionScreen.LoadingScreenFramesLeftInitial = 15 | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a0fa9537c3be1494622cb318515faddf5)FirstPersonNearClippingDistance
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.View.Screens.MissionScreen.FirstPersonNearClippingDistance = 0.065f | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#ae2e553a57d4fef553a82e22223175031)ThirdPersonNearClippingDistance
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.View.Screens.MissionScreen.ThirdPersonNearClippingDistance = 0.1f | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a3754a0d91cca9b8b9e3f6e4ae450fb86)FarClippingDistance
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.View.Screens.MissionScreen.FarClippingDistance = 12500.0f | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#afb2aa6d84ff1482e504100ce6d0a31dc)MinCameraAddedDistance
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.View.Screens.MissionScreen.MinCameraAddedDistance = 0.7f | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a893f4c3c1255b7dba748c656917f6df8)MinCameraDistanceHardLimit
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.View.Screens.MissionScreen.MinCameraDistanceHardLimit = 0.48f | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a97aa099779f95177f645239e9294782c)DefaultViewAngle
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.View.Screens.MissionScreen.DefaultViewAngle = 65.0f | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a5f23241614b51ad9af60905ed92d1bbb)MaxCameraAddedDistance
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.View.Screens.MissionScreen.MaxCameraAddedDistance = 2.4f | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#ae44100104ea8a77595ffe3d8e1f30647)GetSpectatedCharacter
----------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Func<[BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html)> TaleWorlds.MountAndBlade.View.Screens.MissionScreen.GetSpectatedCharacter |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#ac6864418188123ff8429fe8310905182)LockCameraMovement
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.View.Screens.MissionScreen.LockCameraMovement | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a5c82f59504c2bdacef18d15ba9c5d65a)OrderFlag
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | OrderFlag TaleWorlds.MountAndBlade.View.Screens.MissionScreen.OrderFlag | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a061ad01b93837ae3feae949a06f421bf)CombatCamera
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Camera](class_tale_worlds_1_1_engine_1_1_camera.html) TaleWorlds.MountAndBlade.View.Screens.MissionScreen.CombatCamera | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a70f7c5e6953022b50df0240c5daffc9b)CustomCamera
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Camera](class_tale_worlds_1_1_engine_1_1_camera.html) TaleWorlds.MountAndBlade.View.Screens.MissionScreen.CustomCamera | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a046cfcd7fc06ab47e1a2d59fc814990c)CameraBearing
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.View.Screens.MissionScreen.CameraBearing | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a97c47aa2e94827cd7b2d566212e42c8a)MaxCameraZoom
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.View.Screens.MissionScreen.MaxCameraZoom = 1.0f | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#abda9dd6980c8dbd8bfbeab2bd99ae7ef)CameraElevation
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.View.Screens.MissionScreen.CameraElevation | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#acc4c23bb34d20277908075765c556f00)CameraResultDistanceToTarget
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.View.Screens.MissionScreen.CameraResultDistanceToTarget | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a2f8fccb9b2aa200fdccb66c5db19c4c3)CameraViewAngle
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.View.Screens.MissionScreen.CameraViewAngle | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#afcffdad9d78765cd2b860127a15c8859)IsPhotoModeEnabled
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.View.Screens.MissionScreen.IsPhotoModeEnabled | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#ad662949dd9606175903c5255e5fd55da)IsConversationActive
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.View.Screens.MissionScreen.IsConversationActive | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#aa921deebc906451ca8a4a330712daa06)IsDeploymentActive
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.View.Screens.MissionScreen.IsDeploymentActive | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#aeae376a8fb13c52379452bb478e608bf)SceneLayer
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | SceneLayer TaleWorlds.MountAndBlade.View.Screens.MissionScreen.SceneLayer | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a862cdbf388b83427eac684add444c017)SceneView
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | SceneView TaleWorlds.MountAndBlade.View.Screens.MissionScreen.SceneView | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#acf714559311c08d78eb9d0af4a5fab88)Mission
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Mission TaleWorlds.MountAndBlade.View.Screens.MissionScreen.Mission | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#acbf07ece87ca3646f368575d981a5abc)IsCheatGhostMode
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.View.Screens.MissionScreen.IsCheatGhostMode | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a8ca92c5a57047c518379b6388679c694)IsRadialMenuActive
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.View.Screens.MissionScreen.IsRadialMenuActive | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#ae2dc82647caa1e7d41f424cce413dcd0)InputManager
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html) TaleWorlds.MountAndBlade.View.Screens.MissionScreen.InputManager | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#abb2685098de3c6a04cea1c8a999153a1)LastFollowedAgent
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) TaleWorlds.MountAndBlade.View.Screens.MissionScreen.LastFollowedAgent | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a65d01ae0d0284bad41745b78ddab1e1a)LastFollowedAgentVisuals
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IAgentVisual](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html) TaleWorlds.MountAndBlade.View.Screens.MissionScreen.LastFollowedAgentVisuals | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#ab803186c98c134791f7b17b6a77c90ca)MouseVisible
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override bool TaleWorlds.MountAndBlade.View.Screens.MissionScreen.MouseVisible | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#acc7d0655095c51b016d0af5b99140afc)PhotoModeRequiresMouse
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.View.Screens.MissionScreen.PhotoModeRequiresMouse | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a0a515babfbe53947eb3f89dfffa03432)IsFocusLost
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.View.Screens.MissionScreen.IsFocusLost | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#afc0a4c9a7bd4f7b6b7f094a6d511ceee)IsMissionTickable
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.View.Screens.MissionScreen.IsMissionTickable | | get |

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a6bc3596797e54aa4f954dc989d2b5980)OnSpectateAgentFocusIn
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [OnSpectateAgentDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a8bba74d82d5ef066ce96d1e937d2645b) TaleWorlds.MountAndBlade.View.Screens.MissionScreen.OnSpectateAgentFocusIn |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a84350bf7a7886ee27f77296001de77b8)OnSpectateAgentFocusOut
------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [OnSpectateAgentDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a8bba74d82d5ef066ce96d1e937d2645b) TaleWorlds.MountAndBlade.View.Screens.MissionScreen.OnSpectateAgentFocusOut |

