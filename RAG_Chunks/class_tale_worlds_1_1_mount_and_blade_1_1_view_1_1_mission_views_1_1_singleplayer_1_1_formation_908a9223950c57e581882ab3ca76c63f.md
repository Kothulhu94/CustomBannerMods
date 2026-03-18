--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_singleplayer_1_1_formation_908a9223950c57e581882ab3ca76c63f.html ---

TaleWorlds.MountAndBlade.View.MissionViews.Singleplayer.FormationIndicatorMissionView.Indicator Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
| void | [DetermineIndicatorState](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_singleplayer_1_1_formation_908a9223950c57e581882ab3ca76c63f.html#a8584bc8f253809a1b4a1fcc8c74bcade) (float dt, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position) |

|  |  |
| --- | --- |
| Public Attributes | |
| [Screens.MissionScreen](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html) | [missionScreen](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_singleplayer_1_1_formation_908a9223950c57e581882ab3ca76c63f.html#a3aab3a3a5218a2ef195613ec8016aa3d) |
| bool | [indicatorVisible](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_singleplayer_1_1_formation_908a9223950c57e581882ab3ca76c63f.html#a0c8eda54db4f0255cf64c8da563e9fca) = false |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [indicatorFrame](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_singleplayer_1_1_formation_908a9223950c57e581882ab3ca76c63f.html#af48aa600f4bcc5b0094584c886cb8b3a) |
| bool | [firstTime](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_singleplayer_1_1_formation_908a9223950c57e581882ab3ca76c63f.html#aecbf37a62bd5fb767024a9e55e18827b) = true |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [indicatorEntity](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_singleplayer_1_1_formation_908a9223950c57e581882ab3ca76c63f.html#a738cd97db4267bf91293246a916e0c7f) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [nextIndicatorPosition](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_singleplayer_1_1_formation_908a9223950c57e581882ab3ca76c63f.html#ad43891d538639ad59f0ea5a088cd5e24) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [prevIndicatorPosition](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_singleplayer_1_1_formation_908a9223950c57e581882ab3ca76c63f.html#a63e06d20624f2cca7aa0a90b6d5111dd) |
| float | [indicatorAlpha](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_singleplayer_1_1_formation_908a9223950c57e581882ab3ca76c63f.html#a3d994ad8e5715b1441e5a553750bc17e) = 1f |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_singleplayer_1_1_formation_908a9223950c57e581882ab3ca76c63f.html#a8584bc8f253809a1b4a1fcc8c74bcade)DetermineIndicatorState()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.MissionViews.Singleplayer.FormationIndicatorMissionView.Indicator.DetermineIndicatorState | ( | float | *dt*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position* ) |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_singleplayer_1_1_formation_908a9223950c57e581882ab3ca76c63f.html#a3aab3a3a5218a2ef195613ec8016aa3d)missionScreen
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Screens.MissionScreen](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html) TaleWorlds.MountAndBlade.View.MissionViews.Singleplayer.FormationIndicatorMissionView.Indicator.missionScreen |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_singleplayer_1_1_formation_908a9223950c57e581882ab3ca76c63f.html#a0c8eda54db4f0255cf64c8da563e9fca)indicatorVisible
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.View.MissionViews.Singleplayer.FormationIndicatorMissionView.Indicator.indicatorVisible = false |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_singleplayer_1_1_formation_908a9223950c57e581882ab3ca76c63f.html#af48aa600f4bcc5b0094584c886cb8b3a)indicatorFrame
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.View.MissionViews.Singleplayer.FormationIndicatorMissionView.Indicator.indicatorFrame |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_singleplayer_1_1_formation_908a9223950c57e581882ab3ca76c63f.html#aecbf37a62bd5fb767024a9e55e18827b)firstTime
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.View.MissionViews.Singleplayer.FormationIndicatorMissionView.Indicator.firstTime = true |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_singleplayer_1_1_formation_908a9223950c57e581882ab3ca76c63f.html#a738cd97db4267bf91293246a916e0c7f)indicatorEntity
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) TaleWorlds.MountAndBlade.View.MissionViews.Singleplayer.FormationIndicatorMissionView.Indicator.indicatorEntity |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_singleplayer_1_1_formation_908a9223950c57e581882ab3ca76c63f.html#ad43891d538639ad59f0ea5a088cd5e24)nextIndicatorPosition
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.View.MissionViews.Singleplayer.FormationIndicatorMissionView.Indicator.nextIndicatorPosition |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_singleplayer_1_1_formation_908a9223950c57e581882ab3ca76c63f.html#a63e06d20624f2cca7aa0a90b6d5111dd)prevIndicatorPosition
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.View.MissionViews.Singleplayer.FormationIndicatorMissionView.Indicator.prevIndicatorPosition |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_singleplayer_1_1_formation_908a9223950c57e581882ab3ca76c63f.html#a3d994ad8e5715b1441e5a553750bc17e)indicatorAlpha
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.View.MissionViews.Singleplayer.FormationIndicatorMissionView.Indicator.indicatorAlpha = 1f |

