--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alliance_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.AllianceModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultAllianceModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alliance_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| int | [GetCallToWarCost](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alliance_model.html#aa32b0637b8c7978b0b1e9999d11ce41c) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) callingKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) calledKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdomToCallToWarAgainst) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetScoreOfStartingAlliance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alliance_model.html#a49016783e1916b203adc8c3fec24c9ae) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdomDeclaresAlliance, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdomDeclaredAlliance, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) evaluatingFaction, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) explanation, bool includeDescription=false) |
| float | [GetScoreOfCallingToWar](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alliance_model.html#af452a00d367a157b7cf68ecb09515b19) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) callingKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) calledKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdomToCallToWarAgainst, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) evaluatingFaction, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) reason) |
| float | [GetScoreOfJoiningWar](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alliance_model.html#a64185e3c2a9998f5f5f2db5c981bcf8e) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) offeringKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdomToOfferToJoinWarWith, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdomToOfferToJoinWarAgainst, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) evaluatingFaction, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) reason) |
| int | [GetInfluenceCostOfProposingStartingAlliance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alliance_model.html#aafed478d86efdac206290dabe8d28e2f) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) proposingClan) |
| int | [GetInfluenceCostOfCallingToWar](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alliance_model.html#aeb982037f4aac96f8cf3d2759bfb4aae) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) proposingClan) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [MaxDurationOfAlliance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alliance_model.html#a2ee0b07ea5bc281b93091dcbb461f1be) `[get]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [MaxDurationOfWarParticipation](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alliance_model.html#a95fd48230d753892f950b09f4fe7a750) `[get]` |
| int | [MaxNumberOfAlliances](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alliance_model.html#adeb36b8bb2831c9694e9dead137ac713) `[get]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [DurationForOffers](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alliance_model.html#a4072429b325d8c502f3026dcc328c60d) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alliance_model.html#aa32b0637b8c7978b0b1e9999d11ce41c)GetCallToWarCost()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.AllianceModel.GetCallToWarCost | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *callingKingdom*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *calledKingdom*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdomToCallToWarAgainst* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alliance_model.html#a49016783e1916b203adc8c3fec24c9ae)GetScoreOfStartingAlliance()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.AllianceModel.GetScoreOfStartingAlliance | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdomDeclaresAlliance*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdomDeclaredAlliance*, | |  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *evaluatingFaction*, | |  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *explanation*, | |  |  | bool | *includeDescription* = false ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alliance_model.html#af452a00d367a157b7cf68ecb09515b19)GetScoreOfCallingToWar()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.AllianceModel.GetScoreOfCallingToWar | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *callingKingdom*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *calledKingdom*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdomToCallToWarAgainst*, | |  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *evaluatingFaction*, | |  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *reason* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alliance_model.html#a64185e3c2a9998f5f5f2db5c981bcf8e)GetScoreOfJoiningWar()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.AllianceModel.GetScoreOfJoiningWar | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *offeringKingdom*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdomToOfferToJoinWarWith*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdomToOfferToJoinWarAgainst*, | |  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *evaluatingFaction*, | |  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *reason* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alliance_model.html#aafed478d86efdac206290dabe8d28e2f)GetInfluenceCostOfProposingStartingAlliance()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.AllianceModel.GetInfluenceCostOfProposingStartingAlliance | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *proposingClan* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alliance_model.html#aeb982037f4aac96f8cf3d2759bfb4aae)GetInfluenceCostOfCallingToWar()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.AllianceModel.GetInfluenceCostOfCallingToWar | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *proposingClan* | ) |  | | abstract |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alliance_model.html#a2ee0b07ea5bc281b93091dcbb461f1be)MaxDurationOfAlliance
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.ComponentInterfaces.AllianceModel.MaxDurationOfAlliance | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alliance_model.html#a95fd48230d753892f950b09f4fe7a750)MaxDurationOfWarParticipation
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.ComponentInterfaces.AllianceModel.MaxDurationOfWarParticipation | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alliance_model.html#adeb36b8bb2831c9694e9dead137ac713)MaxNumberOfAlliances
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.AllianceModel.MaxNumberOfAlliances | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alliance_model.html#a4072429b325d8c502f3026dcc328c60d)DurationForOffers
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.ComponentInterfaces.AllianceModel.DurationForOffers | | getabstract |

