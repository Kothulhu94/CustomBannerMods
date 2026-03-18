--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_make_peace_action.html ---

TaleWorlds.CampaignSystem.Actions.MakePeaceAction Class Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [MakePeaceDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_make_peace_action.html#a6899ba26eb5b509b23d7bc231a1c30ff) {     [Default](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_make_peace_action.html#a6899ba26eb5b509b23d7bc231a1c30ffa7a1920d61156abc05a60135aefe8bc67) ,     [ByKingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_make_peace_action.html#a6899ba26eb5b509b23d7bc231a1c30ffa5846d118f26a8262c3313a386c8a77de)   } |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [Apply](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_make_peace_action.html#a8bc0f9593bcea9135df09c2eacfdb2eb) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction1, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction2) |
| static void | [ApplyByKingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_make_peace_action.html#aaedfb2f8362655ed9d3a0d0e0b208347) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction1, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction2, int dailyTributeFrom1To2, int dailyTributeDuration) |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_make_peace_action.html#a6899ba26eb5b509b23d7bc231a1c30ff)MakePeaceDetail
----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.Actions.MakePeaceAction.MakePeaceDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_make_peace_action.html#a6899ba26eb5b509b23d7bc231a1c30ff) |

| Enumerator | |
| --- | --- |
| Default |  |
| ByKingdomDecision |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_make_peace_action.html#a8bc0f9593bcea9135df09c2eacfdb2eb)Apply()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.MakePeaceAction.Apply | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction1*, | |  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction2* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_make_peace_action.html#aaedfb2f8362655ed9d3a0d0e0b208347)ApplyByKingdomDecision()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.MakePeaceAction.ApplyByKingdomDecision | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction1*, | |  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction2*, | |  |  | int | *dailyTributeFrom1To2*, | |  |  | int | *dailyTributeDuration* ) | | static |

