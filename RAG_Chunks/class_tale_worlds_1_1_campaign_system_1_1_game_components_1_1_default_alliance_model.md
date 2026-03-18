--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alliance_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultAllianceModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.AllianceModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alliance_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override int | [GetCallToWarCost](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alliance_model.html#a604dc5647693779907a792104f19a64a) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) callingKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) calledKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdomToCallToWarAgainst) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetScoreOfStartingAlliance](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alliance_model.html#a85023b5d2f875acaf0fa016a67183617) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdomDeclaresAlliance, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdomDeclaredAlliance, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) evaluatingFaction, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) explanationText, bool includeDescription=false) |
| override int | [GetInfluenceCostOfProposingStartingAlliance](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alliance_model.html#a9beff380f50d06557e54fb0841aaa951) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) proposingClan) |
| override float | [GetScoreOfCallingToWar](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alliance_model.html#a57815e7b7cabf4ea7c2d38cb74ea681d) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) callingKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) calledKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdomToCallToWarAgainst, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) evaluatingFaction, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) reason) |
| override float | [GetScoreOfJoiningWar](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alliance_model.html#afa5c7a49ae3426d0b9c9ee091934c1a4) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) callingKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) calledKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdomToCallToWarAgainst, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) evaluatingFaction, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) reason) |
| override int | [GetInfluenceCostOfCallingToWar](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alliance_model.html#a3de097e44f5171e6540fcbc58d7a9d24) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) proposingClan) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.AllianceModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alliance_model.html) | |
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
| override [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [MaxDurationOfAlliance](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alliance_model.html#ac95aebae8793a552572d2a37f3b7de1f) `[get]` |
| override [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [MaxDurationOfWarParticipation](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alliance_model.html#aa98c5024d33e71327f2228ae55df56cd) `[get]` |
| override int | [MaxNumberOfAlliances](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alliance_model.html#a83c56ec10b9db2a30955d93fa9882def) `[get]` |
| override [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [DurationForOffers](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alliance_model.html#aa5cda5fe44422de44fb9a000fa170cf0) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.AllianceModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alliance_model.html) | |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [MaxDurationOfAlliance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alliance_model.html#a2ee0b07ea5bc281b93091dcbb461f1be) `[get]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [MaxDurationOfWarParticipation](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alliance_model.html#a95fd48230d753892f950b09f4fe7a750) `[get]` |
| int | [MaxNumberOfAlliances](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alliance_model.html#adeb36b8bb2831c9694e9dead137ac713) `[get]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [DurationForOffers](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alliance_model.html#a4072429b325d8c502f3026dcc328c60d) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alliance_model.html#a604dc5647693779907a792104f19a64a)GetCallToWarCost()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultAllianceModel.GetCallToWarCost | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *callingKingdom*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *calledKingdom*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdomToCallToWarAgainst* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alliance_model.html#a85023b5d2f875acaf0fa016a67183617)GetScoreOfStartingAlliance()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultAllianceModel.GetScoreOfStartingAlliance | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdomDeclaresAlliance*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdomDeclaredAlliance*, |
|  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *evaluatingFaction*, |
|  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *explanationText*, |
|  |  | bool | *includeDescription* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alliance_model.html#a9beff380f50d06557e54fb0841aaa951)GetInfluenceCostOfProposingStartingAlliance()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultAllianceModel.GetInfluenceCostOfProposingStartingAlliance | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *proposingClan* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alliance_model.html#a57815e7b7cabf4ea7c2d38cb74ea681d)GetScoreOfCallingToWar()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultAllianceModel.GetScoreOfCallingToWar | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *callingKingdom*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *calledKingdom*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdomToCallToWarAgainst*, |
|  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *evaluatingFaction*, |
|  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *reason* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alliance_model.html#afa5c7a49ae3426d0b9c9ee091934c1a4)GetScoreOfJoiningWar()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultAllianceModel.GetScoreOfJoiningWar | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *callingKingdom*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *calledKingdom*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdomToCallToWarAgainst*, |
|  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *evaluatingFaction*, |
|  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *reason* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alliance_model.html#a3de097e44f5171e6540fcbc58d7a9d24)GetInfluenceCostOfCallingToWar()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultAllianceModel.GetInfluenceCostOfCallingToWar | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *proposingClan* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alliance_model.html#ac95aebae8793a552572d2a37f3b7de1f)MaxDurationOfAlliance
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.GameComponents.DefaultAllianceModel.MaxDurationOfAlliance | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alliance_model.html#aa98c5024d33e71327f2228ae55df56cd)MaxDurationOfWarParticipation
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.GameComponents.DefaultAllianceModel.MaxDurationOfWarParticipation | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alliance_model.html#a83c56ec10b9db2a30955d93fa9882def)MaxNumberOfAlliances
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultAllianceModel.MaxNumberOfAlliances | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alliance_model.html#aa5cda5fe44422de44fb9a000fa170cf0)DurationForOffers
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.GameComponents.DefaultAllianceModel.DurationForOffers | | get |

