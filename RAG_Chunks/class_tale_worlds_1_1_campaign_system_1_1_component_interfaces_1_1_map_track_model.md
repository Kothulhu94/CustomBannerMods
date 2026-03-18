--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_track_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.MapTrackModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultMapTrackModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_track_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| float | [GetSkipTrackChance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_track_model.html#ab674fc627ba3bcbc4bafa11ed583c659) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| float | [GetMaxTrackSpottingDistanceForMainParty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_track_model.html#a1ba254cbfa1b44cdacc266c4f2dceb3b) () |
| bool | [CanPartyLeaveTrack](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_track_model.html#a9610fb0caa8edb5919490fae0730d312) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| float | [GetTrackDetectionDifficultyForMainParty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_track_model.html#ad2a3c383ff0b9502dda5882f13e0ad44) ([Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) track, float trackSpottingDistance) |
| float | [GetSkillFromTrackDetected](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_track_model.html#a5820cec510486200fa8a0c3aacc62c87) ([Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) track) |
| int | [GetTrackLife](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_track_model.html#a8ce7ef660280aeaaf7d5061890b3be32) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [TrackTitle](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_track_model.html#a99e7106e68fedbe8e31b7fa4341c30ae) ([Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) track) |
| IEnumerable<([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html), string)> | [GetTrackDescription](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_track_model.html#a7ced3f5cae2f51b5fe7136d4643dc84e) ([Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) track) |
| uint | [GetTrackColor](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_track_model.html#a3dfd1100b8d14a6b40b4dffb5111cc97) ([Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) track) |
| float | [GetTrackScale](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_track_model.html#a0c25cfaf028675f769cee86cbfa394b4) ([Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) track) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| float | [MaxTrackLife](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_track_model.html#a01ad3bde7b10a9e02199c92c895e933b) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_track_model.html#ab674fc627ba3bcbc4bafa11ed583c659)GetSkipTrackChance()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.MapTrackModel.GetSkipTrackChance | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_track_model.html#a1ba254cbfa1b44cdacc266c4f2dceb3b)GetMaxTrackSpottingDistanceForMainParty()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.MapTrackModel.GetMaxTrackSpottingDistanceForMainParty | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_track_model.html#a9610fb0caa8edb5919490fae0730d312)CanPartyLeaveTrack()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.MapTrackModel.CanPartyLeaveTrack | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_track_model.html#ad2a3c383ff0b9502dda5882f13e0ad44)GetTrackDetectionDifficultyForMainParty()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.MapTrackModel.GetTrackDetectionDifficultyForMainParty | ( | [Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) | *track*, | |  |  | float | *trackSpottingDistance* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_track_model.html#a5820cec510486200fa8a0c3aacc62c87)GetSkillFromTrackDetected()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.MapTrackModel.GetSkillFromTrackDetected | ( | [Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) | *track* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_track_model.html#a8ce7ef660280aeaaf7d5061890b3be32)GetTrackLife()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.MapTrackModel.GetTrackLife | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_track_model.html#a99e7106e68fedbe8e31b7fa4341c30ae)TrackTitle()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.ComponentInterfaces.MapTrackModel.TrackTitle | ( | [Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) | *track* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_track_model.html#a7ced3f5cae2f51b5fe7136d4643dc84e)GetTrackDescription()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IEnumerable<([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html), string)> TaleWorlds.CampaignSystem.ComponentInterfaces.MapTrackModel.GetTrackDescription | ( | [Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) | *track* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_track_model.html#a3dfd1100b8d14a6b40b4dffb5111cc97)GetTrackColor()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | uint TaleWorlds.CampaignSystem.ComponentInterfaces.MapTrackModel.GetTrackColor | ( | [Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) | *track* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_track_model.html#a0c25cfaf028675f769cee86cbfa394b4)GetTrackScale()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.MapTrackModel.GetTrackScale | ( | [Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) | *track* | ) |  | | abstract |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_track_model.html#a01ad3bde7b10a9e02199c92c895e933b)MaxTrackLife
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.MapTrackModel.MaxTrackLife | | getabstract |

