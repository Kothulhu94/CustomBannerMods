--- SOURCE: class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html ---

SandBox.ViewModelCollection.Missions.NameMarker.MissionNameMarkerProvider Class ReferenceabstractInherited by [SandBox.View.Missions.NameMarkers.DefaultMissionNameMarkerHandler](class_sand_box_1_1_view_1_1_missions_1_1_name_markers_1_1_default_mission_name_marker_handler.html), [SandBox.View.Missions.NameMarkers.StealthNameMarkerProvider](class_sand_box_1_1_view_1_1_missions_1_1_name_markers_1_1_stealth_name_marker_provider.html), and [StoryMode.View.MarkerProviders.StealthTutorialMarkerProvider](class_story_mode_1_1_view_1_1_marker_providers_1_1_stealth_tutorial_marker_provider.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MissionNameMarkerProvider](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html#a2c1a4a074995f5b858c0ad729a0f5811) () |
| void | [CreateMarkers](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html#a52e6a7aed895bcca4af500a9222303df) (List< [MissionNameMarkerTargetBaseVM](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_target_base_v_m.html) > markers) |
| void | [Initialize](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html#ab511dbe8f7e0979fd79393728d49f940) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission, Action onSetMarkersDirty) |
| void | [Destroy](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html#a6d717f172128dccc91dc98232a4d914d) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission) |
| void | [Tick](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html#a1bbd0ebec234ae2c9386e5734eb4af05) (float dt) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| virtual void | [OnInitialize](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html#a74b63efac587dc5bebef7df72aabd674) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission) |
| virtual void | [OnDestroy](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html#a53ab3c9ac514d39e0c4f71072a2ff1f6) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission) |
| virtual void | [OnTick](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html#a589ae870e3fdb6688ff1d72cb7b8e854) (float dt) |
| void | [SetMarkersDirty](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html#ac955c011a34d101dec99315acc59e420) () |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html#a2c1a4a074995f5b858c0ad729a0f5811)MissionNameMarkerProvider()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| SandBox.ViewModelCollection.Missions.NameMarker.MissionNameMarkerProvider.MissionNameMarkerProvider | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html#a52e6a7aed895bcca4af500a9222303df)CreateMarkers()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void SandBox.ViewModelCollection.Missions.NameMarker.MissionNameMarkerProvider.CreateMarkers | ( | List< [MissionNameMarkerTargetBaseVM](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_target_base_v_m.html) > | *markers* | ) |  | | abstract |

[◆](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html#ab511dbe8f7e0979fd79393728d49f940)Initialize()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.ViewModelCollection.Missions.NameMarker.MissionNameMarkerProvider.Initialize | ( | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | *mission*, |
|  |  | Action | *onSetMarkersDirty* ) |

[◆](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html#a6d717f172128dccc91dc98232a4d914d)Destroy()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.Missions.NameMarker.MissionNameMarkerProvider.Destroy | ( | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | *mission* | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html#a1bbd0ebec234ae2c9386e5734eb4af05)Tick()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.Missions.NameMarker.MissionNameMarkerProvider.Tick | ( | float | *dt* | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html#a74b63efac587dc5bebef7df72aabd674)OnInitialize()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void SandBox.ViewModelCollection.Missions.NameMarker.MissionNameMarkerProvider.OnInitialize | ( | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | *mission* | ) |  | | protectedvirtual |

Reimplemented in [SandBox.View.Missions.NameMarkers.DefaultMissionNameMarkerHandler](class_sand_box_1_1_view_1_1_missions_1_1_name_markers_1_1_default_mission_name_marker_handler.html#a141f05bf784902b8b6b0bc112f577b23), and [SandBox.View.Missions.NameMarkers.StealthNameMarkerProvider](class_sand_box_1_1_view_1_1_missions_1_1_name_markers_1_1_stealth_name_marker_provider.html#a7ec5d939af3b4f6b65e5d1a6c68d07ba).

[◆](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html#a53ab3c9ac514d39e0c4f71072a2ff1f6)OnDestroy()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void SandBox.ViewModelCollection.Missions.NameMarker.MissionNameMarkerProvider.OnDestroy | ( | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | *mission* | ) |  | | protectedvirtual |

Reimplemented in [SandBox.View.Missions.NameMarkers.DefaultMissionNameMarkerHandler](class_sand_box_1_1_view_1_1_missions_1_1_name_markers_1_1_default_mission_name_marker_handler.html#a37ab889b48c13bc4f1162287fbedaed6), and [SandBox.View.Missions.NameMarkers.StealthNameMarkerProvider](class_sand_box_1_1_view_1_1_missions_1_1_name_markers_1_1_stealth_name_marker_provider.html#a451320c7f1fe09ff262059e6b5fe3a8f).

[◆](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html#a589ae870e3fdb6688ff1d72cb7b8e854)OnTick()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void SandBox.ViewModelCollection.Missions.NameMarker.MissionNameMarkerProvider.OnTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented in [SandBox.View.Missions.NameMarkers.DefaultMissionNameMarkerHandler](class_sand_box_1_1_view_1_1_missions_1_1_name_markers_1_1_default_mission_name_marker_handler.html#a0079416dc2a4911b5bcb8ff00d4565d0), and [StoryMode.View.MarkerProviders.StealthTutorialMarkerProvider](class_story_mode_1_1_view_1_1_marker_providers_1_1_stealth_tutorial_marker_provider.html#acd57a07fc5af40bfe5783a827a1f315c).

[◆](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html#ac955c011a34d101dec99315acc59e420)SetMarkersDirty()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void SandBox.ViewModelCollection.Missions.NameMarker.MissionNameMarkerProvider.SetMarkersDirty | ( |  | ) |  | | protected |

