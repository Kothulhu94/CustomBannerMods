--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_access_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementAccessModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementAccessModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [CanMainHeroEnterSettlement](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_access_model.html#aad25f270c352ae19a502cbeeea739d8c) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, out [AccessDetails](struct_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model_1_1_access_details.html) accessDetails) |
| override void | [CanMainHeroEnterDungeon](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_access_model.html#ab616df9a9b5ab32f03eec2afc57b4f77) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, out [AccessDetails](struct_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model_1_1_access_details.html) accessDetails) |
| override void | [CanMainHeroEnterLordsHall](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_access_model.html#a14e33a121a0993d3cf588061359dd87c) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, out [AccessDetails](struct_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model_1_1_access_details.html) accessDetails) |
| override bool | [CanMainHeroAccessLocation](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_access_model.html#ac483eb1170f0f86bc13e21fbcf2bf843) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, string locationId, out bool disableOption, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) disabledText) |
| override bool | [IsRequestMeetingOptionAvailable](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_access_model.html#a7b5ddad5ff55c0ea062de4e55416da13) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, out bool disableOption, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) disabledText) |
| override bool | [CanMainHeroDoSettlementAction](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_access_model.html#a8b649838803ce042f7824c57a5d474c5) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [SettlementAction](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a00567dd2a162608eeeda4eb2783afbb5) settlementAction, out bool disableOption, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) disabledText) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementAccessModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html) | |
| void | [CanMainHeroEnterSettlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a838fc75bdf5c694f2f741f234b391d71) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, out [AccessDetails](struct_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model_1_1_access_details.html) accessDetails) |
| void | [CanMainHeroEnterLordsHall](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#ab77e7796f358d32ffb87655801eaa136) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, out [AccessDetails](struct_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model_1_1_access_details.html) accessDetails) |
| void | [CanMainHeroEnterDungeon](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a6e13d21e10d704440c9548dfeacaf647) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, out [AccessDetails](struct_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model_1_1_access_details.html) accessDetails) |
| bool | [CanMainHeroAccessLocation](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#ad72695e9f45ef2111dd578b7996a5c2d) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, string locationId, out bool disableOption, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) disabledText) |
| bool | [CanMainHeroDoSettlementAction](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a1fa434b469a7df6da61712b14c2e880e) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [SettlementAction](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a00567dd2a162608eeeda4eb2783afbb5) settlementAction, out bool disableOption, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) disabledText) |
| bool | [IsRequestMeetingOptionAvailable](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a9f7ca08b5e945495b24724ce152cd2c5) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, out bool disableOption, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) disabledText) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Types inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementAccessModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html) | |
| enum | [AccessLevel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#adff23607cd4a3311e41be27189310732) {     [NoAccess](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#adff23607cd4a3311e41be27189310732a88a12f09800c497f30b98781952b50f2) ,     [LimitedAccess](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#adff23607cd4a3311e41be27189310732a962108d60bf2bf7c9f98b58974385702) ,     [FullAccess](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#adff23607cd4a3311e41be27189310732a0268c876e4588f7ad98bacb113933dab)   } |
| enum | [AccessMethod](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a6e5c62eba92fdffc83323d1c1021b3d8) {     [None](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a6e5c62eba92fdffc83323d1c1021b3d8a6adf97f83acf6453d4a6a4b1070f3754) ,     [Direct](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a6e5c62eba92fdffc83323d1c1021b3d8afd1dd0c603be8170f9eae0be9f2f6afb) ,     [ByRequest](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a6e5c62eba92fdffc83323d1c1021b3d8a9e8760d189aec3032aa01cff8b9438cd)   } |
| enum | [AccessLimitationReason](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a9c5de3995c4f5bdf7f6caeb4f97bb106) {     [None](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a9c5de3995c4f5bdf7f6caeb4f97bb106a6adf97f83acf6453d4a6a4b1070f3754) ,     [HostileFaction](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a9c5de3995c4f5bdf7f6caeb4f97bb106a1c4a057a74c07ea2abd87a4dce3f3a0b) ,     [RelationshipWithOwner](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a9c5de3995c4f5bdf7f6caeb4f97bb106aa66d36fbade3e3e8c33d9cd82ecb7a6a) ,     [CrimeRating](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a9c5de3995c4f5bdf7f6caeb4f97bb106aeab080c9b45e97eadc03d79e41fca434) ,     [VillageIsLooted](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a9c5de3995c4f5bdf7f6caeb4f97bb106ad6f12817cd9e63209d1a32eb34097219) ,     [Disguised](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a9c5de3995c4f5bdf7f6caeb4f97bb106a289284911fb6f41c0ccaecc3a0c28911) ,     [ClanTier](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a9c5de3995c4f5bdf7f6caeb4f97bb106ac1e6b014543c5e05f24c3974096e574f) ,     [LocationEmpty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a9c5de3995c4f5bdf7f6caeb4f97bb106a39abfbd6648580cebc874aa64c62b58f)   } |
| enum | [LimitedAccessSolution](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a605294a908dbe0fb37541763c2889426) {     [None](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a605294a908dbe0fb37541763c2889426a6adf97f83acf6453d4a6a4b1070f3754) ,     [Bribe](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a605294a908dbe0fb37541763c2889426a696292917787c80d98b42f08245ab5df) ,     [Disguise](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a605294a908dbe0fb37541763c2889426a616d8ea055532b9a89d6d43ad31c0a98)   } |
| enum | [PreliminaryActionObligation](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a54f0830376f4dbf0b5c3aca506d0d7db) {     [None](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a54f0830376f4dbf0b5c3aca506d0d7dba6adf97f83acf6453d4a6a4b1070f3754) ,     [Optional](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a54f0830376f4dbf0b5c3aca506d0d7dbaebb061953c0454b2c8ee7b0ac615ebcd)   } |
| enum | [PreliminaryActionType](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#ae1fd7bafe9851cc9abcea57978fba591) {     [None](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#ae1fd7bafe9851cc9abcea57978fba591a6adf97f83acf6453d4a6a4b1070f3754) ,     [FaceCharges](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#ae1fd7bafe9851cc9abcea57978fba591a73fd980967647d325b9732450175999f)   } |
| enum | [SettlementAction](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a00567dd2a162608eeeda4eb2783afbb5) {     [RecruitTroops](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a00567dd2a162608eeeda4eb2783afbb5a9c1ecb706c628a0fe70225a2640d74f2) ,     [Craft](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a00567dd2a162608eeeda4eb2783afbb5ad64fc815b787209309dca16ff96371f3) ,     [WalkAroundTheArena](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a00567dd2a162608eeeda4eb2783afbb5a3aa79731a98532c7b1a511a08230be42) ,     [JoinTournament](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a00567dd2a162608eeeda4eb2783afbb5ac7cdd2e2193016c56c33df2564f0a7bb) ,     [WatchTournament](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a00567dd2a162608eeeda4eb2783afbb5a8021b8efd65544bf09916433f0eb4c01) ,     [Trade](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a00567dd2a162608eeeda4eb2783afbb5a5f390d80b20daad8f5d2f483fb0ae9d8) ,     [WaitInSettlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a00567dd2a162608eeeda4eb2783afbb5a6869a29a3d8247b14843752d0e7d4da3) ,     [ManageTown](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a00567dd2a162608eeeda4eb2783afbb5ae0160a55a5dcdd1fa33b9a1cb7c4a1b8)   } |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_access_model.html#aad25f270c352ae19a502cbeeea739d8c)CanMainHeroEnterSettlement()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementAccessModel.CanMainHeroEnterSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | out [AccessDetails](struct_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model_1_1_access_details.html) | *accessDetails* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_access_model.html#ab616df9a9b5ab32f03eec2afc57b4f77)CanMainHeroEnterDungeon()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementAccessModel.CanMainHeroEnterDungeon | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | out [AccessDetails](struct_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model_1_1_access_details.html) | *accessDetails* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_access_model.html#a14e33a121a0993d3cf588061359dd87c)CanMainHeroEnterLordsHall()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementAccessModel.CanMainHeroEnterLordsHall | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | out [AccessDetails](struct_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model_1_1_access_details.html) | *accessDetails* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_access_model.html#ac483eb1170f0f86bc13e21fbcf2bf843)CanMainHeroAccessLocation()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementAccessModel.CanMainHeroAccessLocation | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | string | *locationId*, |
|  |  | out bool | *disableOption*, |
|  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *disabledText* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_access_model.html#a7b5ddad5ff55c0ea062de4e55416da13)IsRequestMeetingOptionAvailable()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementAccessModel.IsRequestMeetingOptionAvailable | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | out bool | *disableOption*, |
|  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *disabledText* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_access_model.html#a8b649838803ce042f7824c57a5d474c5)CanMainHeroDoSettlementAction()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementAccessModel.CanMainHeroDoSettlementAction | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | [SettlementAction](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a00567dd2a162608eeeda4eb2783afbb5) | *settlementAction*, |
|  |  | out bool | *disableOption*, |
|  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *disabledText* ) |

