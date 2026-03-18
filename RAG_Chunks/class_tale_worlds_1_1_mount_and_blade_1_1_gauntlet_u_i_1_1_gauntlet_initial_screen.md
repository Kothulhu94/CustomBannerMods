--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_initial_screen.html ---

TaleWorlds.MountAndBlade.GauntletUI.GauntletInitialScreen Class ReferenceInherits [TaleWorlds.MountAndBlade.MBInitialScreenBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html), and [TaleWorlds.MountAndBlade.View.IChatLogHandlerScreen](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_i_chat_log_handler_screen.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [GauntletInitialScreen](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_initial_screen.html#a3ec8d80d44204772c4c5c1aabbcf676f) ([InitialState](class_tale_worlds_1_1_mount_and_blade_1_1_initial_state.html) initialState) |
| void | [TryUpdateChatLogLayerParameters](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_initial_screen.html#a56725aace7f58d5b8e2bcfacc01df13b) (ref bool isTeamChatAvailable, ref bool inputEnabled, ref bool isToggleChatHintAvailable, ref bool isMouseVisible, ref [InputContext](class_tale_worlds_1_1_input_system_1_1_input_context.html) inputContext) |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.MBInitialScreenBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html) | |
|  | [MBInitialScreenBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#a22c944d6d1b402bda44e7d17f8f05bb9) ([InitialState](class_tale_worlds_1_1_mount_and_blade_1_1_initial_state.html) state) |
| bool | [StartedRendering](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#a29f1133d6bc48a35af6b71b455e3f108) () |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnInitialize](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_initial_screen.html#aafc6685d15b1be65c06e0ec374d34510) () |
| override void | [OnInitialScreenTick](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_initial_screen.html#abfe91c44c8d938cf3c6e82ad119df8b9) (float dt) |
| override void | [OnActivate](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_initial_screen.html#abfd19711a8f5bd2d8b833fa494bac875) () |
| override void | [OnFinalize](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_initial_screen.html#a40e80043652ededb41584507fef5e592) () |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.MBInitialScreenBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html) | |
| override void | [OnInitialize](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#a82ff17e342a0b32d60e4ae41745caaa9) () |
| override void | [OnFinalize](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#a606f6e3b5dc2e2e51152a8e94fde3ec7) () |
| override void | [OnFrameTick](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#a3464aab6f758a9bbf347d2d9723976c0) (float dt) |
| override void | [OnActivate](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#a9a7a775720547782e6ff84aa57b8faa9) () |
| override void | [OnDeactivate](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#aefd14edbafcd21c8ad97c74e81b651fa) () |
| override void | [OnPause](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#a854b7062a116890ea86298d52e4681eb) () |
| override void | [OnResume](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#a9fbb3ee95e3a420f0982af47340aac68) () |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.MountAndBlade.MBInitialScreenBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html) | |
| static void | [DoExitButtonAction](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#aa56a2d5de116182c0782324820453d14) () |
| static void | [OnEditModeEnterPress](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#ac3938c4953d950c717fec24b979042dc) () |
| static void | [OnEditModeEnterRelease](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#a72f732c0b8aee5a998ccc4619eb459bc) () |
| Protected Attributes inherited from [TaleWorlds.MountAndBlade.MBInitialScreenBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html) | |
| [VideoPlayerView](class_tale_worlds_1_1_engine_1_1_video_player_view.html) | [\_videoPlayerView](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#a220ac392d626f0a63e6ba9eac0994100) |
| Properties inherited from [TaleWorlds.MountAndBlade.MBInitialScreenBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html) | |
| [InitialState](class_tale_worlds_1_1_mount_and_blade_1_1_initial_state.html) | [\_state](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#a2b875d84a2a0936b342903b8df188f9b) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_initial_screen.html#a3ec8d80d44204772c4c5c1aabbcf676f)GauntletInitialScreen()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.GauntletUI.GauntletInitialScreen.GauntletInitialScreen | ( | [InitialState](class_tale_worlds_1_1_mount_and_blade_1_1_initial_state.html) | *initialState* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_initial_screen.html#aafc6685d15b1be65c06e0ec374d34510)OnInitialize()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.GauntletUI.GauntletInitialScreen.OnInitialize | ( |  | ) |  | | protected |

Implements [TaleWorlds.Core.IGameStateListener](interface_tale_worlds_1_1_core_1_1_i_game_state_listener.html#a8df8104360d9c66aedb341b13367b8e5).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_initial_screen.html#abfe91c44c8d938cf3c6e82ad119df8b9)OnInitialScreenTick()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.GauntletUI.GauntletInitialScreen.OnInitialScreenTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.MBInitialScreenBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#aa0b62a754b02c9f3b1a2298f8b125998).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_initial_screen.html#abfd19711a8f5bd2d8b833fa494bac875)OnActivate()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.GauntletUI.GauntletInitialScreen.OnActivate | ( |  | ) |  | | protected |

Implements [TaleWorlds.Core.IGameStateListener](interface_tale_worlds_1_1_core_1_1_i_game_state_listener.html#aa8b05eeab9e1f4691b9ef1ac12a05b77).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_initial_screen.html#a40e80043652ededb41584507fef5e592)OnFinalize()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.GauntletUI.GauntletInitialScreen.OnFinalize | ( |  | ) |  | | protected |

Implements [TaleWorlds.Core.IGameStateListener](interface_tale_worlds_1_1_core_1_1_i_game_state_listener.html#ac916ee3e48edbf09b47eacac07b5c574).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_initial_screen.html#a56725aace7f58d5b8e2bcfacc01df13b)TryUpdateChatLogLayerParameters()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.GauntletUI.GauntletInitialScreen.TryUpdateChatLogLayerParameters | ( | ref bool | *isTeamChatAvailable*, |
|  |  | ref bool | *inputEnabled*, |
|  |  | ref bool | *isToggleChatHintAvailable*, |
|  |  | ref bool | *isMouseVisible*, |
|  |  | ref [InputContext](class_tale_worlds_1_1_input_system_1_1_input_context.html) | *inputContext* ) |

Implements [TaleWorlds.MountAndBlade.View.IChatLogHandlerScreen](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_i_chat_log_handler_screen.html#a6bba68ed93f7c47bf8ebb6a3d71851c7).

