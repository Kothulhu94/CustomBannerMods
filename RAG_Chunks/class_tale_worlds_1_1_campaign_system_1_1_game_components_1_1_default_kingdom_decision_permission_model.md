--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_kingdom_decision_permission_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultKingdomDecisionPermissionModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.KingdomDecisionPermissionModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_kingdom_decision_permission_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override bool | [IsPolicyDecisionAllowed](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_kingdom_decision_permission_model.html#aa0dff2e74b9157de7e4faf6784feed74) ([PolicyObject](class_tale_worlds_1_1_campaign_system_1_1_policy_object.html) policy) |
| override bool | [IsWarDecisionAllowedBetweenKingdoms](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_kingdom_decision_permission_model.html#a6355617a1fcc2ee0735ee8fdbd09fde9) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom1, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom2, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) reason) |
| override bool | [IsPeaceDecisionAllowedBetweenKingdoms](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_kingdom_decision_permission_model.html#af729beadb409cd8d21cce791955b4c19) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom1, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom2, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) reason) |
| override bool | [IsAnnexationDecisionAllowed](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_kingdom_decision_permission_model.html#a065ceefe578daea851a676ddf9d8ec05) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) annexedSettlement) |
| override bool | [IsExpulsionDecisionAllowed](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_kingdom_decision_permission_model.html#a9bb68f427b919e49899430ff8a091976) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) expelledClan) |
| override bool | [IsKingSelectionDecisionAllowed](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_kingdom_decision_permission_model.html#a600c20846f3b86c53f4f2e219f13009f) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom) |
| override bool | [IsStartAllianceDecisionAllowedBetweenKingdoms](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_kingdom_decision_permission_model.html#a995fc03b443857f7dcda7bf6c803637a) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom1, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom2, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) reason) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.KingdomDecisionPermissionModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_kingdom_decision_permission_model.html) | |
| bool | [IsPolicyDecisionAllowed](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_kingdom_decision_permission_model.html#aa805228da73ce32db83092e085567e54) ([PolicyObject](class_tale_worlds_1_1_campaign_system_1_1_policy_object.html) policy) |
| bool | [IsWarDecisionAllowedBetweenKingdoms](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_kingdom_decision_permission_model.html#ab1554d4b9e9d0e2626afa0cc723c1b78) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom1, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom2, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) reason) |
| bool | [IsPeaceDecisionAllowedBetweenKingdoms](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_kingdom_decision_permission_model.html#a4d3a1f25df27cb46312ba7cd5989bd91) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom1, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom2, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) reason) |
| bool | [IsStartAllianceDecisionAllowedBetweenKingdoms](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_kingdom_decision_permission_model.html#a22ed16b32348b5881474fa59a3c5e36b) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom1, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom2, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) reason) |
| bool | [IsAnnexationDecisionAllowed](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_kingdom_decision_permission_model.html#a7aac34ab06fe86a0ce1514ac3532c6c6) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) annexedSettlement) |
| bool | [IsExpulsionDecisionAllowed](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_kingdom_decision_permission_model.html#a25dbf859e141486a62ed6c521bba710f) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) expelledClan) |
| bool | [IsKingSelectionDecisionAllowed](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_kingdom_decision_permission_model.html#a7fdc1559524d51b87749c89b59ef643c) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_kingdom_decision_permission_model.html#aa0dff2e74b9157de7e4faf6784feed74)IsPolicyDecisionAllowed()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultKingdomDecisionPermissionModel.IsPolicyDecisionAllowed | ( | [PolicyObject](class_tale_worlds_1_1_campaign_system_1_1_policy_object.html) | *policy* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_kingdom_decision_permission_model.html#a6355617a1fcc2ee0735ee8fdbd09fde9)IsWarDecisionAllowedBetweenKingdoms()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultKingdomDecisionPermissionModel.IsWarDecisionAllowedBetweenKingdoms | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom1*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom2*, |
|  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *reason* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_kingdom_decision_permission_model.html#af729beadb409cd8d21cce791955b4c19)IsPeaceDecisionAllowedBetweenKingdoms()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultKingdomDecisionPermissionModel.IsPeaceDecisionAllowedBetweenKingdoms | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom1*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom2*, |
|  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *reason* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_kingdom_decision_permission_model.html#a065ceefe578daea851a676ddf9d8ec05)IsAnnexationDecisionAllowed()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultKingdomDecisionPermissionModel.IsAnnexationDecisionAllowed | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *annexedSettlement* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_kingdom_decision_permission_model.html#a9bb68f427b919e49899430ff8a091976)IsExpulsionDecisionAllowed()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultKingdomDecisionPermissionModel.IsExpulsionDecisionAllowed | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *expelledClan* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_kingdom_decision_permission_model.html#a600c20846f3b86c53f4f2e219f13009f)IsKingSelectionDecisionAllowed()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultKingdomDecisionPermissionModel.IsKingSelectionDecisionAllowed | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_kingdom_decision_permission_model.html#a995fc03b443857f7dcda7bf6c803637a)IsStartAllianceDecisionAllowedBetweenKingdoms()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultKingdomDecisionPermissionModel.IsStartAllianceDecisionAllowedBetweenKingdoms | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom1*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom2*, |
|  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *reason* ) |

