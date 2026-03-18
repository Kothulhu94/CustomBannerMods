--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_map_1_1_map_marker_manager.html ---

TaleWorlds.CampaignSystem.Map.MapMarkerManager Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
| [MapMarker](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_map_marker.html) | [CreateMapMarker](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_map_marker_manager.html#a11d283bcb72b5fe31a44936a39f401d1) ([Banner](class_tale_worlds_1_1_core_1_1_banner.html) banner, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) name, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position, bool isVisibleOnMap, string questId) |
| void | [RemoveMapMarker](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_map_marker_manager.html#ae38c5df76c81a3e28d4b58bb9893f731) ([MapMarker](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_map_marker.html) mapMarker) |
| void | [RemoveAllMapMarkersByQuestId](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_map_marker_manager.html#ad083c5b05de6a0dfa656b7e4df2d743b) (string questId) |
| IEnumerable< [MapMarker](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_map_marker.html) > | [GetMapMarkersByQuestId](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_map_marker_manager.html#a4108d667b12a35e856a70dba6ac4fead) (string questId) |

|  |  |
| --- | --- |
| Properties | |
| MBReadOnlyList< [MapMarker](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_map_marker.html) > | [MapMarkers](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_map_marker_manager.html#a19ee89d5deba83d56b969c3e5b7f361f) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_map_marker_manager.html#a11d283bcb72b5fe31a44936a39f401d1)CreateMapMarker()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [MapMarker](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_map_marker.html) TaleWorlds.CampaignSystem.Map.MapMarkerManager.CreateMapMarker | ( | [Banner](class_tale_worlds_1_1_core_1_1_banner.html) | *banner*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *name*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position*, |
|  |  | bool | *isVisibleOnMap*, |
|  |  | string | *questId* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_map_marker_manager.html#ae38c5df76c81a3e28d4b58bb9893f731)RemoveMapMarker()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Map.MapMarkerManager.RemoveMapMarker | ( | [MapMarker](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_map_marker.html) | *mapMarker* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_map_marker_manager.html#ad083c5b05de6a0dfa656b7e4df2d743b)RemoveAllMapMarkersByQuestId()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Map.MapMarkerManager.RemoveAllMapMarkersByQuestId | ( | string | *questId* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_map_marker_manager.html#a4108d667b12a35e856a70dba6ac4fead)GetMapMarkersByQuestId()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| IEnumerable< [MapMarker](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_map_marker.html) > TaleWorlds.CampaignSystem.Map.MapMarkerManager.GetMapMarkersByQuestId | ( | string | *questId* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_map_marker_manager.html#a19ee89d5deba83d56b969c3e5b7f361f)MapMarkers
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[MapMarker](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_map_marker.html)> TaleWorlds.CampaignSystem.Map.MapMarkerManager.MapMarkers | | get |

