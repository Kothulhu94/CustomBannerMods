--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_video_playback_screen.html ---

TaleWorlds.MountAndBlade.GauntletUI.GauntletVideoPlaybackScreen Class ReferenceInherits [TaleWorlds.MountAndBlade.View.Screens.VideoPlaybackScreen](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_video_playback_screen.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [GauntletVideoPlaybackScreen](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_video_playback_screen.html#a91dafd705e6b5c3acae2b2dd05b42129) ([VideoPlaybackState](class_tale_worlds_1_1_mount_and_blade_1_1_video_playback_state.html) videoPlaybackState) |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.View.Screens.VideoPlaybackScreen](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_video_playback_screen.html) | |
|  | [VideoPlaybackScreen](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_video_playback_screen.html#a0049ee32bb245aa06ebcb7e7903b8e35) ([VideoPlaybackState](class_tale_worlds_1_1_mount_and_blade_1_1_video_playback_state.html) videoPlaybackState) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnInitialize](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_video_playback_screen.html#afe788685350b40857f4b392107f4b782) () |
| override void | [OnVideoPlaybackTick](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_video_playback_screen.html#a9bb9826e44f096456e6684a894dbdfb4) (float dt) |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.View.Screens.VideoPlaybackScreen](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_video_playback_screen.html) | |
| override void | [OnFrameTick](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_video_playback_screen.html#adbcd405a38f3d8a70ae28120e2dadbf5) (float dt) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Protected Attributes inherited from [TaleWorlds.MountAndBlade.View.Screens.VideoPlaybackScreen](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_video_playback_screen.html) | |
| [VideoPlaybackState](class_tale_worlds_1_1_mount_and_blade_1_1_video_playback_state.html) | [\_videoPlaybackState](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_video_playback_screen.html#abb863bb0dbfe10115dc062b2360bf56b) |
| [VideoPlayerView](class_tale_worlds_1_1_engine_1_1_video_player_view.html) | [\_videoPlayerView](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_video_playback_screen.html#a401bf0fad01e6c34d7bdc90fea13e8ff) |
| float | [\_totalElapsedTimeSinceVideoStart](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_video_playback_screen.html#a4ee04cb848e4a966c6031eea4f9c8e71) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_video_playback_screen.html#a91dafd705e6b5c3acae2b2dd05b42129)GauntletVideoPlaybackScreen()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.GauntletUI.GauntletVideoPlaybackScreen.GauntletVideoPlaybackScreen | ( | [VideoPlaybackState](class_tale_worlds_1_1_mount_and_blade_1_1_video_playback_state.html) | *videoPlaybackState* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_video_playback_screen.html#afe788685350b40857f4b392107f4b782)OnInitialize()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.GauntletUI.GauntletVideoPlaybackScreen.OnInitialize | ( |  | ) |  | | protected |

Implements [TaleWorlds.Core.IGameStateListener](interface_tale_worlds_1_1_core_1_1_i_game_state_listener.html#a8df8104360d9c66aedb341b13367b8e5).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_video_playback_screen.html#a9bb9826e44f096456e6684a894dbdfb4)OnVideoPlaybackTick()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.GauntletUI.GauntletVideoPlaybackScreen.OnVideoPlaybackTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.View.Screens.VideoPlaybackScreen](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_video_playback_screen.html#ae664e1d723ab5b9288ac3216f3d9b136).

