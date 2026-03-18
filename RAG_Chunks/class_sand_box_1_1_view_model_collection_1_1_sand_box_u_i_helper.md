--- SOURCE: class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html ---

SandBox.ViewModelCollection.SandBoxUIHelper Class ReferenceThis is a temporary class before Tooltip refactor. To show hints in proper formatting, we need to convert them to list of [TooltipProperty](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html). Because, UiHelper class in logic, can't refer to [TooltipProperty](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html), I added this class to [SandBox](namespace_sand_box.html) for it's references. This class and CampaignUIHelper will be deleted after the Tooltip refactor.

|  |  |
| --- | --- |
| Public Types | |
| enum | [SortState](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#aa34c79118173f22b1bcdb49fba9fb949) {     [Default](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#aa34c79118173f22b1bcdb49fba9fb949a7a1920d61156abc05a60135aefe8bc67) = 0 ,     [Ascending](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#aa34c79118173f22b1bcdb49fba9fb949acf3fb1ff52ea1eed3347ac5401ee7f0c) ,     [Descending](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#aa34c79118173f22b1bcdb49fba9fb949ae3cf5ac19407b1a62c6fccaff675a53b)   } |
| enum | [MapEventVisualTypes](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#ae241453d0d697e74a818a7301738e535) {     [None](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#ae241453d0d697e74a818a7301738e535a6adf97f83acf6453d4a6a4b1070f3754) ,     [Raid](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#ae241453d0d697e74a818a7301738e535ac8a23798f7577fe951f173d3380bee0d) ,     [Siege](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#ae241453d0d697e74a818a7301738e535a7e86b036c23f9a7df08bff9baeaf98ad) ,     [Battle](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#ae241453d0d697e74a818a7301738e535a747d99f92ee9c080ba26108ac5d26488) ,     [Rebellion](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#ae241453d0d697e74a818a7301738e535abffe31a84fee5fd2a13c44ce083676b4) ,     [SallyOut](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#ae241453d0d697e74a818a7301738e535a3d6806e222f143afc07bd405190644b7)   } |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static List< [TooltipProperty](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html) > | [GetExplainedNumberTooltip](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#a8d6779d62be96090bafc712548e4952a) (ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) explanation) |
| static List< [TooltipProperty](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html) > | [GetBattleLootAwardTooltip](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#a2908cc1acd5b56a46406fca2e7e57124) (float lootPercentage) |
| static List< [TooltipProperty](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html) > | [GetFigureheadTooltip](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#a86ef8b37cf6b58a66a10777bcaa35367) ([Figurehead](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_figurehead.html) figurehead) |
| static string | [GetSkillEffectText](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#a4c23a9326561b1b27248868c14a23e19) ([SkillEffect](class_tale_worlds_1_1_campaign_system_1_1_skill_effect.html) effect, int skillLevel) |
| static string | [GetRecruitNotificationText](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#a1db0206e131a0b43f132e86743b2a228) (int recruitmentAmount) |
| static string | [GetItemSoldNotificationText](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#a83e6b6e28848c65cb72db4d71d016173) ([ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) item, int itemAmount, bool fromHeroToSettlement) |
| static string | [GetShipSoldNotificationText](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#afb5061d978b8276c1ef07a9cbad13614) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship, int itemAmount, bool fromHeroToSettlement) |
| static string | [GetTroopGivenToSettlementNotificationText](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#a9555ffa40953f7a82bb231f618f52501) (int givenAmount) |
| static List< [TooltipProperty](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html) > | [GetSiegeEngineInProgressTooltip](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#aac3daa606fbe23f5e941887af330bb5c) ([SiegeEvent.SiegeEngineConstructionProgress](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engine_construction_progress.html) engineInProgress) |
| static List< [TooltipProperty](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html) > | [GetSiegeEngineTooltip](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#ab15074fcd9809eaedcee35bab24115f2) ([SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) engine) |
| static List< [TooltipProperty](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html) > | [GetWallSectionTooltip](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#a348f8aab64e037478933e07de249ceda) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, int wallIndex) |
| static string | [GetPrisonersSoldNotificationText](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#a403d3570718cba607aab9a43c7fc18df) (int soldPrisonerAmount) |
| static int | [GetPartyHealthyCount](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#a36d71ec57b60e9f549e3330af7fdc2e6) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |
| static string | [GetPartyWoundedText](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#ae7c6014633e70d706d96750f3025c867) (int woundedAmount) |
| static string | [GetPartyPrisonerText](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#a759ae16d588fd13af460a9cadd1d688e) (int prisonerAmount) |
| static int | [GetAllWoundedMembersAmount](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#ac075151291ebe72fc9b03c4177e6ef95) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |
| static int | [GetAllPrisonerMembersAmount](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#ae631680841b0f0afa5e89d99796a9065) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |
| static [CharacterCode](class_tale_worlds_1_1_core_1_1_character_code.html) | [GetCharacterCode](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#a817b6212aa049c4b81ecc51237c24a29) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, bool useCivilian=false) |
| static bool | [IsHeroInformationHidden](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#a178761e10355072afb69421885b73e96) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) disableReason) |
| static [MapEventVisualTypes](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#ae241453d0d697e74a818a7301738e535) | [GetMapEventVisualTypeFromMapEvent](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#aeb5fdba8752b714dd0d4c8fb301466cb) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) mapEvent) |
| static bool | [IsAgentInVisibilityRangeApproximate](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#a7b4cd56f558185b4c3618fc46247c620) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) seerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) seenAgent) |
| static bool | [CanAgentBeAlarmed](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#ad8a68eb28fd49b73f797f21dedf7aa5e) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const float | [AgentMarkerWorldHeightOffset](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#a2a9cedf9831739bab243f8e3c3638cb7) = 0.35f |

Member Enumeration Documentation
--------------------------------

[◆](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#aa34c79118173f22b1bcdb49fba9fb949)SortState
---------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [SandBox.ViewModelCollection.SandBoxUIHelper.SortState](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#aa34c79118173f22b1bcdb49fba9fb949) |

| Enumerator | |
| --- | --- |
| Default |  |
| Ascending |  |
| Descending |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#ae241453d0d697e74a818a7301738e535)MapEventVisualTypes
-------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [SandBox.ViewModelCollection.SandBoxUIHelper.MapEventVisualTypes](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#ae241453d0d697e74a818a7301738e535) |

| Enumerator | |
| --- | --- |
| None |  |
| Raid |  |
| Siege |  |
| Battle |  |
| Rebellion |  |
| SallyOut |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#a8d6779d62be96090bafc712548e4952a)GetExplainedNumberTooltip()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | List< [TooltipProperty](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html) > SandBox.ViewModelCollection.SandBoxUIHelper.GetExplainedNumberTooltip | ( | ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | *explanation* | ) |  | | static |

[◆](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#a2908cc1acd5b56a46406fca2e7e57124)GetBattleLootAwardTooltip()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | List< [TooltipProperty](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html) > SandBox.ViewModelCollection.SandBoxUIHelper.GetBattleLootAwardTooltip | ( | float | *lootPercentage* | ) |  | | static |

[◆](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#a86ef8b37cf6b58a66a10777bcaa35367)GetFigureheadTooltip()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | List< [TooltipProperty](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html) > SandBox.ViewModelCollection.SandBoxUIHelper.GetFigureheadTooltip | ( | [Figurehead](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_figurehead.html) | *figurehead* | ) |  | | static |

[◆](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#a4c23a9326561b1b27248868c14a23e19)GetSkillEffectText()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | string SandBox.ViewModelCollection.SandBoxUIHelper.GetSkillEffectText | ( | [SkillEffect](class_tale_worlds_1_1_campaign_system_1_1_skill_effect.html) | *effect*, | |  |  | int | *skillLevel* ) | | static |

[◆](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#a1db0206e131a0b43f132e86743b2a228)GetRecruitNotificationText()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string SandBox.ViewModelCollection.SandBoxUIHelper.GetRecruitNotificationText | ( | int | *recruitmentAmount* | ) |  | | static |

[◆](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#a83e6b6e28848c65cb72db4d71d016173)GetItemSoldNotificationText()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | string SandBox.ViewModelCollection.SandBoxUIHelper.GetItemSoldNotificationText | ( | [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) | *item*, | |  |  | int | *itemAmount*, | |  |  | bool | *fromHeroToSettlement* ) | | static |

[◆](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#afb5061d978b8276c1ef07a9cbad13614)GetShipSoldNotificationText()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | string SandBox.ViewModelCollection.SandBoxUIHelper.GetShipSoldNotificationText | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship*, | |  |  | int | *itemAmount*, | |  |  | bool | *fromHeroToSettlement* ) | | static |

[◆](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#a9555ffa40953f7a82bb231f618f52501)GetTroopGivenToSettlementNotificationText()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string SandBox.ViewModelCollection.SandBoxUIHelper.GetTroopGivenToSettlementNotificationText | ( | int | *givenAmount* | ) |  | | static |

[◆](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#aac3daa606fbe23f5e941887af330bb5c)GetSiegeEngineInProgressTooltip()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | List< [TooltipProperty](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html) > SandBox.ViewModelCollection.SandBoxUIHelper.GetSiegeEngineInProgressTooltip | ( | [SiegeEvent.SiegeEngineConstructionProgress](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engine_construction_progress.html) | *engineInProgress* | ) |  | | static |

[◆](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#ab15074fcd9809eaedcee35bab24115f2)GetSiegeEngineTooltip()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | List< [TooltipProperty](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html) > SandBox.ViewModelCollection.SandBoxUIHelper.GetSiegeEngineTooltip | ( | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *engine* | ) |  | | static |

[◆](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#a348f8aab64e037478933e07de249ceda)GetWallSectionTooltip()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | List< [TooltipProperty](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html) > SandBox.ViewModelCollection.SandBoxUIHelper.GetWallSectionTooltip | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | int | *wallIndex* ) | | static |

[◆](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#a403d3570718cba607aab9a43c7fc18df)GetPrisonersSoldNotificationText()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string SandBox.ViewModelCollection.SandBoxUIHelper.GetPrisonersSoldNotificationText | ( | int | *soldPrisonerAmount* | ) |  | | static |

[◆](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#a36d71ec57b60e9f549e3330af7fdc2e6)GetPartyHealthyCount()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int SandBox.ViewModelCollection.SandBoxUIHelper.GetPartyHealthyCount | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* | ) |  | | static |

[◆](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#ae7c6014633e70d706d96750f3025c867)GetPartyWoundedText()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string SandBox.ViewModelCollection.SandBoxUIHelper.GetPartyWoundedText | ( | int | *woundedAmount* | ) |  | | static |

[◆](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#a759ae16d588fd13af460a9cadd1d688e)GetPartyPrisonerText()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string SandBox.ViewModelCollection.SandBoxUIHelper.GetPartyPrisonerText | ( | int | *prisonerAmount* | ) |  | | static |

[◆](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#ac075151291ebe72fc9b03c4177e6ef95)GetAllWoundedMembersAmount()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int SandBox.ViewModelCollection.SandBoxUIHelper.GetAllWoundedMembersAmount | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* | ) |  | | static |

[◆](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#ae631680841b0f0afa5e89d99796a9065)GetAllPrisonerMembersAmount()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int SandBox.ViewModelCollection.SandBoxUIHelper.GetAllPrisonerMembersAmount | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* | ) |  | | static |

[◆](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#a817b6212aa049c4b81ecc51237c24a29)GetCharacterCode()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [CharacterCode](class_tale_worlds_1_1_core_1_1_character_code.html) SandBox.ViewModelCollection.SandBoxUIHelper.GetCharacterCode | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, | |  |  | bool | *useCivilian* = false ) | | static |

[◆](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#a178761e10355072afb69421885b73e96)IsHeroInformationHidden()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool SandBox.ViewModelCollection.SandBoxUIHelper.IsHeroInformationHidden | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *disableReason* ) | | static |

[◆](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#aeb5fdba8752b714dd0d4c8fb301466cb)GetMapEventVisualTypeFromMapEvent()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [MapEventVisualTypes](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#ae241453d0d697e74a818a7301738e535) SandBox.ViewModelCollection.SandBoxUIHelper.GetMapEventVisualTypeFromMapEvent | ( | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *mapEvent* | ) |  | | static |

[◆](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#a7b4cd56f558185b4c3618fc46247c620)IsAgentInVisibilityRangeApproximate()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool SandBox.ViewModelCollection.SandBoxUIHelper.IsAgentInVisibilityRangeApproximate | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *seerAgent*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *seenAgent* ) | | static |

[◆](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#ad8a68eb28fd49b73f797f21dedf7aa5e)CanAgentBeAlarmed()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool SandBox.ViewModelCollection.SandBoxUIHelper.CanAgentBeAlarmed | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | static |

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_view_model_collection_1_1_sand_box_u_i_helper.html#a2a9cedf9831739bab243f8e3c3638cb7)AgentMarkerWorldHeightOffset
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float SandBox.ViewModelCollection.SandBoxUIHelper.AgentMarkerWorldHeightOffset = 0.35f | | static |

