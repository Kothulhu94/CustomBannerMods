--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_kingdom_decision_permission_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.KingdomDecisionPermissionModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [StoryMode.GameComponents.StoryModeKingdomDecisionPermissionModel](class_story_mode_1_1_game_components_1_1_story_mode_kingdom_decision_permission_model.html), and [TaleWorlds.CampaignSystem.GameComponents.DefaultKingdomDecisionPermissionModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_kingdom_decision_permission_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_kingdom_decision_permission_model.html#aa805228da73ce32db83092e085567e54)IsPolicyDecisionAllowed()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.KingdomDecisionPermissionModel.IsPolicyDecisionAllowed | ( | [PolicyObject](class_tale_worlds_1_1_campaign_system_1_1_policy_object.html) | *policy* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_kingdom_decision_permission_model.html#ab1554d4b9e9d0e2626afa0cc723c1b78)IsWarDecisionAllowedBetweenKingdoms()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.KingdomDecisionPermissionModel.IsWarDecisionAllowedBetweenKingdoms | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom1*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom2*, | |  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *reason* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_kingdom_decision_permission_model.html#a4d3a1f25df27cb46312ba7cd5989bd91)IsPeaceDecisionAllowedBetweenKingdoms()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.KingdomDecisionPermissionModel.IsPeaceDecisionAllowedBetweenKingdoms | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom1*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom2*, | |  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *reason* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_kingdom_decision_permission_model.html#a22ed16b32348b5881474fa59a3c5e36b)IsStartAllianceDecisionAllowedBetweenKingdoms()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.KingdomDecisionPermissionModel.IsStartAllianceDecisionAllowedBetweenKingdoms | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom1*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom2*, | |  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *reason* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_kingdom_decision_permission_model.html#a7aac34ab06fe86a0ce1514ac3532c6c6)IsAnnexationDecisionAllowed()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.KingdomDecisionPermissionModel.IsAnnexationDecisionAllowed | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *annexedSettlement* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_kingdom_decision_permission_model.html#a25dbf859e141486a62ed6c521bba710f)IsExpulsionDecisionAllowed()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.KingdomDecisionPermissionModel.IsExpulsionDecisionAllowed | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *expelledClan* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_kingdom_decision_permission_model.html#a7fdc1559524d51b87749c89b59ef643c)IsKingSelectionDecisionAllowed()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.KingdomDecisionPermissionModel.IsKingSelectionDecisionAllowed | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom* | ) |  | | abstract |

