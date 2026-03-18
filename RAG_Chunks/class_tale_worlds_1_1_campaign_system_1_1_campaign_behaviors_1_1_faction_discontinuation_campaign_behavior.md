--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_faction_discontinuation_campaign_behavior.html ---

TaleWorlds.CampaignSystem.CampaignBehaviors.FactionDiscontinuationCampaignBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_faction_discontinuation_campaign_behavior.html#af76acb736a11abaaa589c8df786d48d9) () |
| void | [OnSettlementOwnerChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_faction_discontinuation_campaign_behavior.html#a6fe24541bbe1fcae7279440c65735542) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, bool openToClaim, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newOwner, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) oldOwner, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) capturerHero, ChangeOwnerOfSettlementAction.ChangeOwnerOfSettlementDetail detail) |
| void | [OnClanChangedKingdom](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_faction_discontinuation_campaign_behavior.html#af7cc6af950f897e8ba56829225aed9fd) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) oldKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) newKingdom, [ChangeKingdomAction.ChangeKingdomActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#a9b4b755abdfb7030dcc3a26bb9dad035) detail, bool showNotification=true) |
| override void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_faction_discontinuation_campaign_behavior.html#a058a49c445881a782953290e98304167) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a053965730807cc40179cb1ee0495c376) (string stringId) |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab8914958880a708aaf68f676e6c29df1) () |
| void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a402e03be483527df560a46a7a01004a6) () |
| void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a5f2a833b5a67619021c6c437a1232877) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| static T | [GetCampaignBehavior< T >](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#af9fd34472faff4ae39b627e8d3091b7e) () |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| readonly string | [StringId](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab1c3b0a4161f58781148a9499be70fa3) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_faction_discontinuation_campaign_behavior.html#af76acb736a11abaaa589c8df786d48d9)RegisterEvents()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.FactionDiscontinuationCampaignBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_faction_discontinuation_campaign_behavior.html#a6fe24541bbe1fcae7279440c65735542)OnSettlementOwnerChanged()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.FactionDiscontinuationCampaignBehavior.OnSettlementOwnerChanged | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | bool | *openToClaim*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newOwner*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *oldOwner*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *capturerHero*, |
|  |  | ChangeOwnerOfSettlementAction.ChangeOwnerOfSettlementDetail | *detail* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_faction_discontinuation_campaign_behavior.html#af7cc6af950f897e8ba56829225aed9fd)OnClanChangedKingdom()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.FactionDiscontinuationCampaignBehavior.OnClanChangedKingdom | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *oldKingdom*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *newKingdom*, |
|  |  | [ChangeKingdomAction.ChangeKingdomActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#a9b4b755abdfb7030dcc3a26bb9dad035) | *detail*, |
|  |  | bool | *showNotification* = true ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_faction_discontinuation_campaign_behavior.html#a058a49c445881a782953290e98304167)SyncData()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.FactionDiscontinuationCampaignBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

