--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementAccessModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementAccessModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_access_model.html).

|  |  |
| --- | --- |
| Classes | |
| struct | [AccessDetails](struct_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model_1_1_access_details.html) |

|  |  |
| --- | --- |
| Public Types | |
| enum | [AccessLevel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#adff23607cd4a3311e41be27189310732) {     [NoAccess](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#adff23607cd4a3311e41be27189310732a88a12f09800c497f30b98781952b50f2) ,     [LimitedAccess](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#adff23607cd4a3311e41be27189310732a962108d60bf2bf7c9f98b58974385702) ,     [FullAccess](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#adff23607cd4a3311e41be27189310732a0268c876e4588f7ad98bacb113933dab)   } |
| enum | [AccessMethod](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a6e5c62eba92fdffc83323d1c1021b3d8) {     [None](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a6e5c62eba92fdffc83323d1c1021b3d8a6adf97f83acf6453d4a6a4b1070f3754) ,     [Direct](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a6e5c62eba92fdffc83323d1c1021b3d8afd1dd0c603be8170f9eae0be9f2f6afb) ,     [ByRequest](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a6e5c62eba92fdffc83323d1c1021b3d8a9e8760d189aec3032aa01cff8b9438cd)   } |
| enum | [AccessLimitationReason](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a9c5de3995c4f5bdf7f6caeb4f97bb106) {     [None](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a9c5de3995c4f5bdf7f6caeb4f97bb106a6adf97f83acf6453d4a6a4b1070f3754) ,     [HostileFaction](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a9c5de3995c4f5bdf7f6caeb4f97bb106a1c4a057a74c07ea2abd87a4dce3f3a0b) ,     [RelationshipWithOwner](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a9c5de3995c4f5bdf7f6caeb4f97bb106aa66d36fbade3e3e8c33d9cd82ecb7a6a) ,     [CrimeRating](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a9c5de3995c4f5bdf7f6caeb4f97bb106aeab080c9b45e97eadc03d79e41fca434) ,     [VillageIsLooted](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a9c5de3995c4f5bdf7f6caeb4f97bb106ad6f12817cd9e63209d1a32eb34097219) ,     [Disguised](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a9c5de3995c4f5bdf7f6caeb4f97bb106a289284911fb6f41c0ccaecc3a0c28911) ,     [ClanTier](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a9c5de3995c4f5bdf7f6caeb4f97bb106ac1e6b014543c5e05f24c3974096e574f) ,     [LocationEmpty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a9c5de3995c4f5bdf7f6caeb4f97bb106a39abfbd6648580cebc874aa64c62b58f)   } |
| enum | [LimitedAccessSolution](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a605294a908dbe0fb37541763c2889426) {     [None](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a605294a908dbe0fb37541763c2889426a6adf97f83acf6453d4a6a4b1070f3754) ,     [Bribe](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a605294a908dbe0fb37541763c2889426a696292917787c80d98b42f08245ab5df) ,     [Disguise](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a605294a908dbe0fb37541763c2889426a616d8ea055532b9a89d6d43ad31c0a98)   } |
| enum | [PreliminaryActionObligation](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a54f0830376f4dbf0b5c3aca506d0d7db) {     [None](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a54f0830376f4dbf0b5c3aca506d0d7dba6adf97f83acf6453d4a6a4b1070f3754) ,     [Optional](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a54f0830376f4dbf0b5c3aca506d0d7dbaebb061953c0454b2c8ee7b0ac615ebcd)   } |
| enum | [PreliminaryActionType](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#ae1fd7bafe9851cc9abcea57978fba591) {     [None](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#ae1fd7bafe9851cc9abcea57978fba591a6adf97f83acf6453d4a6a4b1070f3754) ,     [FaceCharges](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#ae1fd7bafe9851cc9abcea57978fba591a73fd980967647d325b9732450175999f)   } |
| enum | [SettlementAction](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a00567dd2a162608eeeda4eb2783afbb5) {     [RecruitTroops](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a00567dd2a162608eeeda4eb2783afbb5a9c1ecb706c628a0fe70225a2640d74f2) ,     [Craft](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a00567dd2a162608eeeda4eb2783afbb5ad64fc815b787209309dca16ff96371f3) ,     [WalkAroundTheArena](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a00567dd2a162608eeeda4eb2783afbb5a3aa79731a98532c7b1a511a08230be42) ,     [JoinTournament](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a00567dd2a162608eeeda4eb2783afbb5ac7cdd2e2193016c56c33df2564f0a7bb) ,     [WatchTournament](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a00567dd2a162608eeeda4eb2783afbb5a8021b8efd65544bf09916433f0eb4c01) ,     [Trade](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a00567dd2a162608eeeda4eb2783afbb5a5f390d80b20daad8f5d2f483fb0ae9d8) ,     [WaitInSettlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a00567dd2a162608eeeda4eb2783afbb5a6869a29a3d8247b14843752d0e7d4da3) ,     [ManageTown](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a00567dd2a162608eeeda4eb2783afbb5ae0160a55a5dcdd1fa33b9a1cb7c4a1b8)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
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
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#adff23607cd4a3311e41be27189310732)AccessLevel
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementAccessModel.AccessLevel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#adff23607cd4a3311e41be27189310732) |

| Enumerator | |
| --- | --- |
| NoAccess |  |
| LimitedAccess |  |
| FullAccess |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a6e5c62eba92fdffc83323d1c1021b3d8)AccessMethod
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementAccessModel.AccessMethod](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a6e5c62eba92fdffc83323d1c1021b3d8) |

| Enumerator | |
| --- | --- |
| None |  |
| Direct |  |
| ByRequest |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a9c5de3995c4f5bdf7f6caeb4f97bb106)AccessLimitationReason
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementAccessModel.AccessLimitationReason](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a9c5de3995c4f5bdf7f6caeb4f97bb106) |

| Enumerator | |
| --- | --- |
| None |  |
| HostileFaction |  |
| RelationshipWithOwner |  |
| CrimeRating |  |
| VillageIsLooted |  |
| Disguised |  |
| ClanTier |  |
| LocationEmpty |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a605294a908dbe0fb37541763c2889426)LimitedAccessSolution
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementAccessModel.LimitedAccessSolution](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a605294a908dbe0fb37541763c2889426) |

| Enumerator | |
| --- | --- |
| None |  |
| Bribe |  |
| Disguise |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a54f0830376f4dbf0b5c3aca506d0d7db)PreliminaryActionObligation
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementAccessModel.PreliminaryActionObligation](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a54f0830376f4dbf0b5c3aca506d0d7db) |

| Enumerator | |
| --- | --- |
| None |  |
| Optional |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#ae1fd7bafe9851cc9abcea57978fba591)PreliminaryActionType
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementAccessModel.PreliminaryActionType](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#ae1fd7bafe9851cc9abcea57978fba591) |

| Enumerator | |
| --- | --- |
| None |  |
| FaceCharges |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a00567dd2a162608eeeda4eb2783afbb5)SettlementAction
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementAccessModel.SettlementAction](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a00567dd2a162608eeeda4eb2783afbb5) |

| Enumerator | |
| --- | --- |
| RecruitTroops |  |
| Craft |  |
| WalkAroundTheArena |  |
| JoinTournament |  |
| WatchTournament |  |
| Trade |  |
| WaitInSettlement |  |
| ManageTown |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a838fc75bdf5c694f2f741f234b391d71)CanMainHeroEnterSettlement()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementAccessModel.CanMainHeroEnterSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | out [AccessDetails](struct_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model_1_1_access_details.html) | *accessDetails* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#ab77e7796f358d32ffb87655801eaa136)CanMainHeroEnterLordsHall()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementAccessModel.CanMainHeroEnterLordsHall | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | out [AccessDetails](struct_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model_1_1_access_details.html) | *accessDetails* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a6e13d21e10d704440c9548dfeacaf647)CanMainHeroEnterDungeon()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementAccessModel.CanMainHeroEnterDungeon | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | out [AccessDetails](struct_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model_1_1_access_details.html) | *accessDetails* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#ad72695e9f45ef2111dd578b7996a5c2d)CanMainHeroAccessLocation()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementAccessModel.CanMainHeroAccessLocation | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | string | *locationId*, | |  |  | out bool | *disableOption*, | |  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *disabledText* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a1fa434b469a7df6da61712b14c2e880e)CanMainHeroDoSettlementAction()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementAccessModel.CanMainHeroDoSettlementAction | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | [SettlementAction](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a00567dd2a162608eeeda4eb2783afbb5) | *settlementAction*, | |  |  | out bool | *disableOption*, | |  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *disabledText* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_access_model.html#a9f7ca08b5e945495b24724ce152cd2c5)IsRequestMeetingOptionAvailable()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementAccessModel.IsRequestMeetingOptionAvailable | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | out bool | *disableOption*, | |  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *disabledText* ) | | abstract |

