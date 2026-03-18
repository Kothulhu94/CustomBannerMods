--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_map_tracks_campaign_behavior.html ---

TaleWorlds.CampaignSystem.CampaignBehaviors.MapTracksCampaignBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html), and [TaleWorlds.CampaignSystem.CampaignBehaviors.IMapTracksCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_map_tracks_campaign_behavior.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MapTracksCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_map_tracks_campaign_behavior.html#ac735a1bc59b9b0069650e6bf4718971a) () |
| override void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_map_tracks_campaign_behavior.html#ae46d8df2b0da87f40c9da61a6db25513) () |
| override void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_map_tracks_campaign_behavior.html#aee7797b07b9d1d2a0b8c369f1bff503d) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| bool | [IsTrackDropped](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_map_tracks_campaign_behavior.html#a11e81af3ce4fc8dfe240cb30d6e6354a) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| void | [AddTrack](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_map_tracks_campaign_behavior.html#a0d3c8db3eebf0e7d8fa3877e54582389) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) trackPosition, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) trackDirection) |
| void | [AddMapArrow](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_map_tracks_campaign_behavior.html#ace08afeea89842e51d60ecae3cd73efb) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) pointerName, [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) trackPosition, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) trackDirection, float life) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a053965730807cc40179cb1ee0495c376) (string stringId) |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab8914958880a708aaf68f676e6c29df1) () |
| void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a402e03be483527df560a46a7a01004a6) () |
| void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a5f2a833b5a67619021c6c437a1232877) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |

|  |  |
| --- | --- |
| Properties | |
| MBReadOnlyList< [Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) > | [DetectedTracks](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_map_tracks_campaign_behavior.html#a0b4e47c9cb23df7801574d8b75ec2b4b) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| static T | [GetCampaignBehavior< T >](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#af9fd34472faff4ae39b627e8d3091b7e) () |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| readonly string | [StringId](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab1c3b0a4161f58781148a9499be70fa3) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_map_tracks_campaign_behavior.html#ac735a1bc59b9b0069650e6bf4718971a)MapTracksCampaignBehavior()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.CampaignBehaviors.MapTracksCampaignBehavior.MapTracksCampaignBehavior | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_map_tracks_campaign_behavior.html#ae46d8df2b0da87f40c9da61a6db25513)RegisterEvents()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.MapTracksCampaignBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_map_tracks_campaign_behavior.html#aee7797b07b9d1d2a0b8c369f1bff503d)SyncData()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.MapTracksCampaignBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_map_tracks_campaign_behavior.html#a11e81af3ce4fc8dfe240cb30d6e6354a)IsTrackDropped()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CampaignBehaviors.MapTracksCampaignBehavior.IsTrackDropped | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_map_tracks_campaign_behavior.html#a0d3c8db3eebf0e7d8fa3877e54582389)AddTrack()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.MapTracksCampaignBehavior.AddTrack | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, |
|  |  | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *trackPosition*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *trackDirection* ) |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.IMapTracksCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_map_tracks_campaign_behavior.html#ae227c4fad3c0dce325bc5d755961e597).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_map_tracks_campaign_behavior.html#ace08afeea89842e51d60ecae3cd73efb)AddMapArrow()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.MapTracksCampaignBehavior.AddMapArrow | ( | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *pointerName*, |
|  |  | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *trackPosition*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *trackDirection*, |
|  |  | float | *life* ) |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.IMapTracksCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_map_tracks_campaign_behavior.html#a04dae0d3027938d0d91a635e0b41901e).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_map_tracks_campaign_behavior.html#a0b4e47c9cb23df7801574d8b75ec2b4b)DetectedTracks
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Track](class_tale_worlds_1_1_campaign_system_1_1_track.html)> TaleWorlds.CampaignSystem.CampaignBehaviors.MapTracksCampaignBehavior.DetectedTracks | | get |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.IMapTracksCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_map_tracks_campaign_behavior.html#a0f452434a4aac64affe087f31ddf565a).

