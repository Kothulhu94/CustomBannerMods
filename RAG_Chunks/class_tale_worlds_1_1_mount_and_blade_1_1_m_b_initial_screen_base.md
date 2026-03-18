--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html ---

TaleWorlds.MountAndBlade.MBInitialScreenBase Class ReferenceInherits ScreenBase, and [TaleWorlds.Core.IGameStateListener](interface_tale_worlds_1_1_core_1_1_i_game_state_listener.html).

Inherited by [TaleWorlds.MountAndBlade.GauntletUI.GauntletInitialScreen](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_initial_screen.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MBInitialScreenBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#a22c944d6d1b402bda44e7d17f8f05bb9) ([InitialState](class_tale_worlds_1_1_mount_and_blade_1_1_initial_state.html) state) |
| bool | [StartedRendering](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#a29f1133d6bc48a35af6b71b455e3f108) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [DoExitButtonAction](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#aa56a2d5de116182c0782324820453d14) () |
| static void | [OnEditModeEnterPress](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#ac3938c4953d950c717fec24b979042dc) () |
| static void | [OnEditModeEnterRelease](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#a72f732c0b8aee5a998ccc4619eb459bc) () |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnInitialize](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#a82ff17e342a0b32d60e4ae41745caaa9) () |
| override void | [OnFinalize](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#a606f6e3b5dc2e2e51152a8e94fde3ec7) () |
| override void | [OnFrameTick](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#a3464aab6f758a9bbf347d2d9723976c0) (float dt) |
| virtual void | [OnInitialScreenTick](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#aa0b62a754b02c9f3b1a2298f8b125998) (float dt) |
| override void | [OnActivate](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#a9a7a775720547782e6ff84aa57b8faa9) () |
| override void | [OnDeactivate](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#aefd14edbafcd21c8ad97c74e81b651fa) () |
| override void | [OnPause](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#a854b7062a116890ea86298d52e4681eb) () |
| override void | [OnResume](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#a9fbb3ee95e3a420f0982af47340aac68) () |

|  |  |
| --- | --- |
| Protected Attributes | |
| [VideoPlayerView](class_tale_worlds_1_1_engine_1_1_video_player_view.html) | [\_videoPlayerView](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#a220ac392d626f0a63e6ba9eac0994100) |

|  |  |
| --- | --- |
| Properties | |
| [InitialState](class_tale_worlds_1_1_mount_and_blade_1_1_initial_state.html) | [\_state](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#a2b875d84a2a0936b342903b8df188f9b) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#a22c944d6d1b402bda44e7d17f8f05bb9)MBInitialScreenBase()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.MBInitialScreenBase.MBInitialScreenBase | ( | [InitialState](class_tale_worlds_1_1_mount_and_blade_1_1_initial_state.html) | *state* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#a82ff17e342a0b32d60e4ae41745caaa9)OnInitialize()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MBInitialScreenBase.OnInitialize | ( |  | ) |  | | protected |

Implements [TaleWorlds.Core.IGameStateListener](interface_tale_worlds_1_1_core_1_1_i_game_state_listener.html#a8df8104360d9c66aedb341b13367b8e5).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#a606f6e3b5dc2e2e51152a8e94fde3ec7)OnFinalize()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MBInitialScreenBase.OnFinalize | ( |  | ) |  | | protected |

Implements [TaleWorlds.Core.IGameStateListener](interface_tale_worlds_1_1_core_1_1_i_game_state_listener.html#ac916ee3e48edbf09b47eacac07b5c574).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#a3464aab6f758a9bbf347d2d9723976c0)OnFrameTick()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MBInitialScreenBase.OnFrameTick | ( | float | *dt* | ) |  | | sealedprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#aa0b62a754b02c9f3b1a2298f8b125998)OnInitialScreenTick()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MBInitialScreenBase.OnInitialScreenTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented in [TaleWorlds.MountAndBlade.GauntletUI.GauntletInitialScreen](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_initial_screen.html#abfe91c44c8d938cf3c6e82ad119df8b9).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#a9a7a775720547782e6ff84aa57b8faa9)OnActivate()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MBInitialScreenBase.OnActivate | ( |  | ) |  | | protected |

Implements [TaleWorlds.Core.IGameStateListener](interface_tale_worlds_1_1_core_1_1_i_game_state_listener.html#aa8b05eeab9e1f4691b9ef1ac12a05b77).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#aefd14edbafcd21c8ad97c74e81b651fa)OnDeactivate()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MBInitialScreenBase.OnDeactivate | ( |  | ) |  | | protected |

Implements [TaleWorlds.Core.IGameStateListener](interface_tale_worlds_1_1_core_1_1_i_game_state_listener.html#a64ece7c9e2bec7a45b85be293166b6ef).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#a854b7062a116890ea86298d52e4681eb)OnPause()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MBInitialScreenBase.OnPause | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#a9fbb3ee95e3a420f0982af47340aac68)OnResume()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MBInitialScreenBase.OnResume | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#aa56a2d5de116182c0782324820453d14)DoExitButtonAction()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBInitialScreenBase.DoExitButtonAction | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#a29f1133d6bc48a35af6b71b455e3f108)StartedRendering()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MBInitialScreenBase.StartedRendering | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#ac3938c4953d950c717fec24b979042dc)OnEditModeEnterPress()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBInitialScreenBase.OnEditModeEnterPress | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#a72f732c0b8aee5a998ccc4619eb459bc)OnEditModeEnterRelease()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBInitialScreenBase.OnEditModeEnterRelease | ( |  | ) |  | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#a220ac392d626f0a63e6ba9eac0994100)\_videoPlayerView
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [VideoPlayerView](class_tale_worlds_1_1_engine_1_1_video_player_view.html) TaleWorlds.MountAndBlade.MBInitialScreenBase.\_videoPlayerView | | protected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_initial_screen_base.html#a2b875d84a2a0936b342903b8df188f9b)\_state
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InitialState](class_tale_worlds_1_1_mount_and_blade_1_1_initial_state.html) TaleWorlds.MountAndBlade.MBInitialScreenBase.\_state | | getprotected |

