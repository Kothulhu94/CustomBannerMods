--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_ship_owner_action.html ---

TaleWorlds.CampaignSystem.Actions.ChangeShipOwnerAction Class Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [ShipOwnerChangeDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_ship_owner_action.html#a4c22b9d8d2c3ee8b9dbadb809d61235f) {     [ApplyByTrade](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_ship_owner_action.html#a4c22b9d8d2c3ee8b9dbadb809d61235fae992e5b126ea7189b844be7af7fb69d6) ,     [ApplyByTransferring](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_ship_owner_action.html#a4c22b9d8d2c3ee8b9dbadb809d61235fae546d95d2e6c210286c352f9af92f9d1) ,     [ApplyByLooting](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_ship_owner_action.html#a4c22b9d8d2c3ee8b9dbadb809d61235fadcd34bfb0a8fae5eeaafe6a98fbfc78a) ,     [ApplyByMobilePartyCreation](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_ship_owner_action.html#a4c22b9d8d2c3ee8b9dbadb809d61235fa86edba4add6b00ee105f12103349a15e) ,     [ApplyByProduction](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_ship_owner_action.html#a4c22b9d8d2c3ee8b9dbadb809d61235fa65343561804124db94b06621e1bddb21)   } |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [ApplyByTransferring](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_ship_owner_action.html#a9bda3ac02c64da3de86e951c337b9238) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) newOwner, [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship) |
| static void | [ApplyByTrade](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_ship_owner_action.html#a871d11f3b3322d4a14de92a106b493af) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) newOwner, [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship) |
| static void | [ApplyByLooting](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_ship_owner_action.html#ab98a4ab444aa09379438dddb2325dc4a) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) newOwner, [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship) |
| static void | [ApplyByProduction](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_ship_owner_action.html#a84de4bdc50402fe13f54de550f293903) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) newOwner, [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship) |
| static void | [ApplyByMobilePartyCreation](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_ship_owner_action.html#af85e41febe64b453f074843c6a864427) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) newOwner, [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship) |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_ship_owner_action.html#a4c22b9d8d2c3ee8b9dbadb809d61235f)ShipOwnerChangeDetail
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.Actions.ChangeShipOwnerAction.ShipOwnerChangeDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_ship_owner_action.html#a4c22b9d8d2c3ee8b9dbadb809d61235f) |

| Enumerator | |
| --- | --- |
| ApplyByTrade |  |
| ApplyByTransferring |  |
| ApplyByLooting |  |
| ApplyByMobilePartyCreation |  |
| ApplyByProduction |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_ship_owner_action.html#a9bda3ac02c64da3de86e951c337b9238)ApplyByTransferring()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.ChangeShipOwnerAction.ApplyByTransferring | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *newOwner*, | |  |  | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_ship_owner_action.html#a871d11f3b3322d4a14de92a106b493af)ApplyByTrade()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.ChangeShipOwnerAction.ApplyByTrade | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *newOwner*, | |  |  | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_ship_owner_action.html#ab98a4ab444aa09379438dddb2325dc4a)ApplyByLooting()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.ChangeShipOwnerAction.ApplyByLooting | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *newOwner*, | |  |  | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_ship_owner_action.html#a84de4bdc50402fe13f54de550f293903)ApplyByProduction()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.ChangeShipOwnerAction.ApplyByProduction | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *newOwner*, | |  |  | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_ship_owner_action.html#af85e41febe64b453f074843c6a864427)ApplyByMobilePartyCreation()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.ChangeShipOwnerAction.ApplyByMobilePartyCreation | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *newOwner*, | |  |  | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship* ) | | static |

