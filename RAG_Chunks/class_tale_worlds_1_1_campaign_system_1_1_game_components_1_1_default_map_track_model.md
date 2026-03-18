--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_track_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultMapTrackModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.MapTrackModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_track_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override float | [GetMaxTrackSpottingDistanceForMainParty](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_track_model.html#a4c880d6395c4e78f9f8e7504e499d97f) () |
| override bool | [CanPartyLeaveTrack](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_track_model.html#a8eaddd3505227aa45710c5f4b6f9f814) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| override int | [GetTrackLife](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_track_model.html#ac37158d893b97e7e9a38524c3fca9702) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| override float | [GetTrackDetectionDifficultyForMainParty](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_track_model.html#a1a7af2689d1ce30ee24a18ccca4967dc) ([Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) track, float trackSpottingDistance) |
| override float | [GetSkillFromTrackDetected](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_track_model.html#ac1b1c61662d80af7ff37c97d103810cf) ([Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) track) |
| override float | [GetSkipTrackChance](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_track_model.html#a2517556abc8b9527ac495df7b15063a5) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [TrackTitle](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_track_model.html#a8248e06070abddd0f644fd2772c1b45c) ([Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) track) |
| override IEnumerable<([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html), string)> | [GetTrackDescription](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_track_model.html#aaaf0fd9480beca305fbc880b998cf94d) ([Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) track) |
| override uint | [GetTrackColor](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_track_model.html#a4789b2fedd203b5f9d7aa074db0a303c) ([Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) track) |
| override float | [GetTrackScale](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_track_model.html#a60989ad1d2968aedc8f3ed0a3fc054f7) ([Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) track) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.MapTrackModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_track_model.html) | |
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
| override float | [MaxTrackLife](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_track_model.html#a594f3321da33798b8476f7600cfa5140) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.MapTrackModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_track_model.html) | |
| float | [MaxTrackLife](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_track_model.html#a01ad3bde7b10a9e02199c92c895e933b) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_track_model.html#a4c880d6395c4e78f9f8e7504e499d97f)GetMaxTrackSpottingDistanceForMainParty()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultMapTrackModel.GetMaxTrackSpottingDistanceForMainParty | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_track_model.html#a8eaddd3505227aa45710c5f4b6f9f814)CanPartyLeaveTrack()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultMapTrackModel.CanPartyLeaveTrack | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_track_model.html#ac37158d893b97e7e9a38524c3fca9702)GetTrackLife()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultMapTrackModel.GetTrackLife | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_track_model.html#a1a7af2689d1ce30ee24a18ccca4967dc)GetTrackDetectionDifficultyForMainParty()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultMapTrackModel.GetTrackDetectionDifficultyForMainParty | ( | [Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) | *track*, |
|  |  | float | *trackSpottingDistance* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_track_model.html#ac1b1c61662d80af7ff37c97d103810cf)GetSkillFromTrackDetected()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultMapTrackModel.GetSkillFromTrackDetected | ( | [Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) | *track* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_track_model.html#a2517556abc8b9527ac495df7b15063a5)GetSkipTrackChance()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultMapTrackModel.GetSkipTrackChance | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_track_model.html#a8248e06070abddd0f644fd2772c1b45c)TrackTitle()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.GameComponents.DefaultMapTrackModel.TrackTitle | ( | [Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) | *track* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_track_model.html#aaaf0fd9480beca305fbc880b998cf94d)GetTrackDescription()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override IEnumerable<([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html), string)> TaleWorlds.CampaignSystem.GameComponents.DefaultMapTrackModel.GetTrackDescription | ( | [Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) | *track* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_track_model.html#a4789b2fedd203b5f9d7aa074db0a303c)GetTrackColor()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override uint TaleWorlds.CampaignSystem.GameComponents.DefaultMapTrackModel.GetTrackColor | ( | [Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) | *track* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_track_model.html#a60989ad1d2968aedc8f3ed0a3fc054f7)GetTrackScale()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultMapTrackModel.GetTrackScale | ( | [Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) | *track* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_track_model.html#a594f3321da33798b8476f7600cfa5140)MaxTrackLife
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultMapTrackModel.MaxTrackLife | | get |

