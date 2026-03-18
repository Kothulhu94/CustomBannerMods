--- SOURCE: interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_map_tracks_campaign_behavior.html ---

TaleWorlds.CampaignSystem.CampaignBehaviors.IMapTracksCampaignBehavior Interface ReferenceInherits [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html).

Inherited by [TaleWorlds.CampaignSystem.CampaignBehaviors.MapTracksCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_map_tracks_campaign_behavior.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [AddTrack](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_map_tracks_campaign_behavior.html#ae227c4fad3c0dce325bc5d755961e597) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) target, [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) trackPosition, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) trackDirection) |
| void | [AddMapArrow](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_map_tracks_campaign_behavior.html#a04dae0d3027938d0d91a635e0b41901e) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) pointerName, [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) trackPosition, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) trackDirection, float life) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html) | |
| void | [RegisterEvents](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522) () |

|  |  |
| --- | --- |
| Properties | |
| MBReadOnlyList< [Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) > | [DetectedTracks](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_map_tracks_campaign_behavior.html#a0f452434a4aac64affe087f31ddf565a) `[get]` |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_map_tracks_campaign_behavior.html#ae227c4fad3c0dce325bc5d755961e597)AddTrack()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.IMapTracksCampaignBehavior.AddTrack | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *target*, |
|  |  | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *trackPosition*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *trackDirection* ) |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.MapTracksCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_map_tracks_campaign_behavior.html#a0d3c8db3eebf0e7d8fa3877e54582389).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_map_tracks_campaign_behavior.html#a04dae0d3027938d0d91a635e0b41901e)AddMapArrow()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.IMapTracksCampaignBehavior.AddMapArrow | ( | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *pointerName*, |
|  |  | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *trackPosition*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *trackDirection*, |
|  |  | float | *life* ) |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.MapTracksCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_map_tracks_campaign_behavior.html#ace08afeea89842e51d60ecae3cd73efb).

Property Documentation
----------------------

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_map_tracks_campaign_behavior.html#a0f452434a4aac64affe087f31ddf565a)DetectedTracks
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Track](class_tale_worlds_1_1_campaign_system_1_1_track.html)> TaleWorlds.CampaignSystem.CampaignBehaviors.IMapTracksCampaignBehavior.DetectedTracks | | get |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.MapTracksCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_map_tracks_campaign_behavior.html#a0b4e47c9cb23df7801574d8b75ec2b4b).

