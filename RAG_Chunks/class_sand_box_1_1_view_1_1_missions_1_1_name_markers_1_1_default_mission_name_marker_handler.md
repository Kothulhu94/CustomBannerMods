--- SOURCE: class_sand_box_1_1_view_1_1_missions_1_1_name_markers_1_1_default_mission_name_marker_handler.html ---

SandBox.View.Missions.NameMarkers.DefaultMissionNameMarkerHandler Class ReferenceInherits [SandBox.ViewModelCollection.Missions.NameMarker.MissionNameMarkerProvider](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [CreateMarkers](class_sand_box_1_1_view_1_1_missions_1_1_name_markers_1_1_default_mission_name_marker_handler.html#a81ed0d499c6586012b3ec05ace9f6a50) (List< [MissionNameMarkerTargetBaseVM](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_target_base_v_m.html) > markers) |
| Public Member Functions inherited from [SandBox.ViewModelCollection.Missions.NameMarker.MissionNameMarkerProvider](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html) | |
|  | [MissionNameMarkerProvider](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html#a2c1a4a074995f5b858c0ad729a0f5811) () |
| void | [CreateMarkers](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html#a52e6a7aed895bcca4af500a9222303df) (List< [MissionNameMarkerTargetBaseVM](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_target_base_v_m.html) > markers) |
| void | [Initialize](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html#ab511dbe8f7e0979fd79393728d49f940) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission, Action onSetMarkersDirty) |
| void | [Destroy](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html#a6d717f172128dccc91dc98232a4d914d) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission) |
| void | [Tick](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html#a1bbd0ebec234ae2c9386e5734eb4af05) (float dt) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnInitialize](class_sand_box_1_1_view_1_1_missions_1_1_name_markers_1_1_default_mission_name_marker_handler.html#a141f05bf784902b8b6b0bc112f577b23) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission) |
| override void | [OnDestroy](class_sand_box_1_1_view_1_1_missions_1_1_name_markers_1_1_default_mission_name_marker_handler.html#a37ab889b48c13bc4f1162287fbedaed6) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission) |
| override void | [OnTick](class_sand_box_1_1_view_1_1_missions_1_1_name_markers_1_1_default_mission_name_marker_handler.html#a0079416dc2a4911b5bcb8ff00d4565d0) (float dt) |
| Protected Member Functions inherited from [SandBox.ViewModelCollection.Missions.NameMarker.MissionNameMarkerProvider](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html) | |
| void | [SetMarkersDirty](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html#ac955c011a34d101dec99315acc59e420) () |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_view_1_1_missions_1_1_name_markers_1_1_default_mission_name_marker_handler.html#a141f05bf784902b8b6b0bc112f577b23)OnInitialize()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.View.Missions.NameMarkers.DefaultMissionNameMarkerHandler.OnInitialize | ( | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | *mission* | ) |  | | protectedvirtual |

Reimplemented from [SandBox.ViewModelCollection.Missions.NameMarker.MissionNameMarkerProvider](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html#a74b63efac587dc5bebef7df72aabd674).

[◆](class_sand_box_1_1_view_1_1_missions_1_1_name_markers_1_1_default_mission_name_marker_handler.html#a37ab889b48c13bc4f1162287fbedaed6)OnDestroy()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.View.Missions.NameMarkers.DefaultMissionNameMarkerHandler.OnDestroy | ( | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | *mission* | ) |  | | protectedvirtual |

Reimplemented from [SandBox.ViewModelCollection.Missions.NameMarker.MissionNameMarkerProvider](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html#a53ab3c9ac514d39e0c4f71072a2ff1f6).

[◆](class_sand_box_1_1_view_1_1_missions_1_1_name_markers_1_1_default_mission_name_marker_handler.html#a0079416dc2a4911b5bcb8ff00d4565d0)OnTick()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.View.Missions.NameMarkers.DefaultMissionNameMarkerHandler.OnTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented from [SandBox.ViewModelCollection.Missions.NameMarker.MissionNameMarkerProvider](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html#a589ae870e3fdb6688ff1d72cb7b8e854).

[◆](class_sand_box_1_1_view_1_1_missions_1_1_name_markers_1_1_default_mission_name_marker_handler.html#a81ed0d499c6586012b3ec05ace9f6a50)CreateMarkers()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void SandBox.View.Missions.NameMarkers.DefaultMissionNameMarkerHandler.CreateMarkers | ( | List< [MissionNameMarkerTargetBaseVM](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_target_base_v_m.html) > | *markers* | ) |  |

