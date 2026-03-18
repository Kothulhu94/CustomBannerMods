--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_video_playback_screen.html ---

TaleWorlds.MountAndBlade.View.Screens.VideoPlaybackScreen Class ReferenceInherits ScreenBase, and [TaleWorlds.Core.IGameStateListener](interface_tale_worlds_1_1_core_1_1_i_game_state_listener.html).

Inherited by [TaleWorlds.MountAndBlade.GauntletUI.GauntletVideoPlaybackScreen](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_video_playback_screen.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [VideoPlaybackScreen](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_video_playback_screen.html#a0049ee32bb245aa06ebcb7e7903b8e35) ([VideoPlaybackState](class_tale_worlds_1_1_mount_and_blade_1_1_video_playback_state.html) videoPlaybackState) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnFrameTick](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_video_playback_screen.html#adbcd405a38f3d8a70ae28120e2dadbf5) (float dt) |
| virtual void | [OnVideoPlaybackTick](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_video_playback_screen.html#ae664e1d723ab5b9288ac3216f3d9b136) (float dt) |

|  |  |
| --- | --- |
| Protected Attributes | |
| [VideoPlaybackState](class_tale_worlds_1_1_mount_and_blade_1_1_video_playback_state.html) | [\_videoPlaybackState](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_video_playback_screen.html#abb863bb0dbfe10115dc062b2360bf56b) |
| [VideoPlayerView](class_tale_worlds_1_1_engine_1_1_video_player_view.html) | [\_videoPlayerView](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_video_playback_screen.html#a401bf0fad01e6c34d7bdc90fea13e8ff) |
| float | [\_totalElapsedTimeSinceVideoStart](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_video_playback_screen.html#a4ee04cb848e4a966c6031eea4f9c8e71) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_video_playback_screen.html#a0049ee32bb245aa06ebcb7e7903b8e35)VideoPlaybackScreen()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.View.Screens.VideoPlaybackScreen.VideoPlaybackScreen | ( | [VideoPlaybackState](class_tale_worlds_1_1_mount_and_blade_1_1_video_playback_state.html) | *videoPlaybackState* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_video_playback_screen.html#adbcd405a38f3d8a70ae28120e2dadbf5)OnFrameTick()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.Screens.VideoPlaybackScreen.OnFrameTick | ( | float | *dt* | ) |  | | sealedprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_video_playback_screen.html#ae664e1d723ab5b9288ac3216f3d9b136)OnVideoPlaybackTick()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.View.Screens.VideoPlaybackScreen.OnVideoPlaybackTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented in [TaleWorlds.MountAndBlade.GauntletUI.GauntletVideoPlaybackScreen](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_video_playback_screen.html#a9bb9826e44f096456e6684a894dbdfb4).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_video_playback_screen.html#abb863bb0dbfe10115dc062b2360bf56b)\_videoPlaybackState
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [VideoPlaybackState](class_tale_worlds_1_1_mount_and_blade_1_1_video_playback_state.html) TaleWorlds.MountAndBlade.View.Screens.VideoPlaybackScreen.\_videoPlaybackState | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_video_playback_screen.html#a401bf0fad01e6c34d7bdc90fea13e8ff)\_videoPlayerView
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [VideoPlayerView](class_tale_worlds_1_1_engine_1_1_video_player_view.html) TaleWorlds.MountAndBlade.View.Screens.VideoPlaybackScreen.\_videoPlayerView | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_video_playback_screen.html#a4ee04cb848e4a966c6031eea4f9c8e71)\_totalElapsedTimeSinceVideoStart
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.View.Screens.VideoPlaybackScreen.\_totalElapsedTimeSinceVideoStart | | protected |

