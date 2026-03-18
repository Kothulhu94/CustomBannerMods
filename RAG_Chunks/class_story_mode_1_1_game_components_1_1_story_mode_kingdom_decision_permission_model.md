--- SOURCE: class_story_mode_1_1_game_components_1_1_story_mode_kingdom_decision_permission_model.html ---

StoryMode.GameComponents.StoryModeKingdomDecisionPermissionModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.KingdomDecisionPermissionModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_kingdom_decision_permission_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override bool | [IsPolicyDecisionAllowed](class_story_mode_1_1_game_components_1_1_story_mode_kingdom_decision_permission_model.html#ad62137da1343316a0e588bd4165a05bb) ([PolicyObject](class_tale_worlds_1_1_campaign_system_1_1_policy_object.html) policy) |
| override bool | [IsAnnexationDecisionAllowed](class_story_mode_1_1_game_components_1_1_story_mode_kingdom_decision_permission_model.html#a57fe678fec548f4bd0de7d11b510d904) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) annexedSettlement) |
| override bool | [IsExpulsionDecisionAllowed](class_story_mode_1_1_game_components_1_1_story_mode_kingdom_decision_permission_model.html#a3bddca7b0da3000f9f07fd32828126cc) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) expelledClan) |
| override bool | [IsKingSelectionDecisionAllowed](class_story_mode_1_1_game_components_1_1_story_mode_kingdom_decision_permission_model.html#a323a1b4c48ee5592c68e39b718936c5c) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom) |
| override bool | [IsWarDecisionAllowedBetweenKingdoms](class_story_mode_1_1_game_components_1_1_story_mode_kingdom_decision_permission_model.html#a1ed4944b53a9f189f81f5473d2912960) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom1, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom2, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) reason) |
| override bool | [IsPeaceDecisionAllowedBetweenKingdoms](class_story_mode_1_1_game_components_1_1_story_mode_kingdom_decision_permission_model.html#a8c23def4d3ddc0e0aba691ff28f131f6) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom1, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom2, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) reason) |
| override bool | [IsStartAllianceDecisionAllowedBetweenKingdoms](class_story_mode_1_1_game_components_1_1_story_mode_kingdom_decision_permission_model.html#a91d88c25ca1c2f6be7b1a62a0a5d4eea) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom1, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom2, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) reason) |
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

[◆](class_story_mode_1_1_game_components_1_1_story_mode_kingdom_decision_permission_model.html#ad62137da1343316a0e588bd4165a05bb)IsPolicyDecisionAllowed()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool StoryMode.GameComponents.StoryModeKingdomDecisionPermissionModel.IsPolicyDecisionAllowed | ( | [PolicyObject](class_tale_worlds_1_1_campaign_system_1_1_policy_object.html) | *policy* | ) |  |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_kingdom_decision_permission_model.html#a57fe678fec548f4bd0de7d11b510d904)IsAnnexationDecisionAllowed()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool StoryMode.GameComponents.StoryModeKingdomDecisionPermissionModel.IsAnnexationDecisionAllowed | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *annexedSettlement* | ) |  |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_kingdom_decision_permission_model.html#a3bddca7b0da3000f9f07fd32828126cc)IsExpulsionDecisionAllowed()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool StoryMode.GameComponents.StoryModeKingdomDecisionPermissionModel.IsExpulsionDecisionAllowed | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *expelledClan* | ) |  |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_kingdom_decision_permission_model.html#a323a1b4c48ee5592c68e39b718936c5c)IsKingSelectionDecisionAllowed()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool StoryMode.GameComponents.StoryModeKingdomDecisionPermissionModel.IsKingSelectionDecisionAllowed | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom* | ) |  |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_kingdom_decision_permission_model.html#a1ed4944b53a9f189f81f5473d2912960)IsWarDecisionAllowedBetweenKingdoms()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool StoryMode.GameComponents.StoryModeKingdomDecisionPermissionModel.IsWarDecisionAllowedBetweenKingdoms | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom1*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom2*, |
|  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *reason* ) |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_kingdom_decision_permission_model.html#a8c23def4d3ddc0e0aba691ff28f131f6)IsPeaceDecisionAllowedBetweenKingdoms()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool StoryMode.GameComponents.StoryModeKingdomDecisionPermissionModel.IsPeaceDecisionAllowedBetweenKingdoms | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom1*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom2*, |
|  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *reason* ) |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_kingdom_decision_permission_model.html#a91d88c25ca1c2f6be7b1a62a0a5d4eea)IsStartAllianceDecisionAllowedBetweenKingdoms()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool StoryMode.GameComponents.StoryModeKingdomDecisionPermissionModel.IsStartAllianceDecisionAllowedBetweenKingdoms | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom1*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom2*, |
|  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *reason* ) |

