--- SOURCE: class_sand_box_1_1_view_1_1_missions_1_1_name_markers_1_1_stealth_name_marker_provider.html ---

SandBox.View.Missions.NameMarkers.StealthNameMarkerProvider Class ReferenceInherits [SandBox.ViewModelCollection.Missions.NameMarker.MissionNameMarkerProvider](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [CreateMarkers](class_sand_box_1_1_view_1_1_missions_1_1_name_markers_1_1_stealth_name_marker_provider.html#ac5acba811468e8f781fe432571eb676c) (List< [MissionNameMarkerTargetBaseVM](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_target_base_v_m.html) > markers) |
| Public Member Functions inherited from [SandBox.ViewModelCollection.Missions.NameMarker.MissionNameMarkerProvider](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html) | |
|  | [MissionNameMarkerProvider](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html#a2c1a4a074995f5b858c0ad729a0f5811) () |
| void | [CreateMarkers](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html#a52e6a7aed895bcca4af500a9222303df) (List< [MissionNameMarkerTargetBaseVM](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_target_base_v_m.html) > markers) |
| void | [Initialize](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html#ab511dbe8f7e0979fd79393728d49f940) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission, Action onSetMarkersDirty) |
| void | [Destroy](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html#a6d717f172128dccc91dc98232a4d914d) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission) |
| void | [Tick](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html#a1bbd0ebec234ae2c9386e5734eb4af05) (float dt) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnInitialize](class_sand_box_1_1_view_1_1_missions_1_1_name_markers_1_1_stealth_name_marker_provider.html#a7ec5d939af3b4f6b65e5d1a6c68d07ba) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission) |
| override void | [OnDestroy](class_sand_box_1_1_view_1_1_missions_1_1_name_markers_1_1_stealth_name_marker_provider.html#a451320c7f1fe09ff262059e6b5fe3a8f) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission) |
| Protected Member Functions inherited from [SandBox.ViewModelCollection.Missions.NameMarker.MissionNameMarkerProvider](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html) | |
| virtual void | [OnTick](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html#a589ae870e3fdb6688ff1d72cb7b8e854) (float dt) |
| void | [SetMarkersDirty](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html#ac955c011a34d101dec99315acc59e420) () |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_view_1_1_missions_1_1_name_markers_1_1_stealth_name_marker_provider.html#a7ec5d939af3b4f6b65e5d1a6c68d07ba)OnInitialize()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.View.Missions.NameMarkers.StealthNameMarkerProvider.OnInitialize | ( | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | *mission* | ) |  | | protectedvirtual |

Reimplemented from [SandBox.ViewModelCollection.Missions.NameMarker.MissionNameMarkerProvider](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html#a74b63efac587dc5bebef7df72aabd674).

[◆](class_sand_box_1_1_view_1_1_missions_1_1_name_markers_1_1_stealth_name_marker_provider.html#a451320c7f1fe09ff262059e6b5fe3a8f)OnDestroy()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.View.Missions.NameMarkers.StealthNameMarkerProvider.OnDestroy | ( | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | *mission* | ) |  | | protectedvirtual |

Reimplemented from [SandBox.ViewModelCollection.Missions.NameMarker.MissionNameMarkerProvider](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html#a53ab3c9ac514d39e0c4f71072a2ff1f6).

[◆](class_sand_box_1_1_view_1_1_missions_1_1_name_markers_1_1_stealth_name_marker_provider.html#ac5acba811468e8f781fe432571eb676c)CreateMarkers()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void SandBox.View.Missions.NameMarkers.StealthNameMarkerProvider.CreateMarkers | ( | List< [MissionNameMarkerTargetBaseVM](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_target_base_v_m.html) > | *markers* | ) |  |

