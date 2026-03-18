--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_clan_variables_campaign_behavior.html ---

TaleWorlds.CampaignSystem.CampaignBehaviors.ClanVariablesCampaignBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_clan_variables_campaign_behavior.html#ab1ecbe21b354dbc4de8643233cc84fd8) () |
| override void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_clan_variables_campaign_behavior.html#a9c96eca2b04ef3dffb0012a884f28dfd) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| void | [OnSettlementOwnerChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_clan_variables_campaign_behavior.html#aa5e6ea160eb26c1b34c4d626e7d5cba4) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, bool openToClaim, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newOwner, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) oldOwner, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) capturerHero, ChangeOwnerOfSettlementAction.ChangeOwnerOfSettlementDetail detail) |
| void | [OnNewGameCreated](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_clan_variables_campaign_behavior.html#a64373081fd38857acb5f4d85cb377d09) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) starter) |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_clan_variables_campaign_behavior.html#ab1ecbe21b354dbc4de8643233cc84fd8)RegisterEvents()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.ClanVariablesCampaignBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_clan_variables_campaign_behavior.html#a9c96eca2b04ef3dffb0012a884f28dfd)SyncData()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.ClanVariablesCampaignBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_clan_variables_campaign_behavior.html#aa5e6ea160eb26c1b34c4d626e7d5cba4)OnSettlementOwnerChanged()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.ClanVariablesCampaignBehavior.OnSettlementOwnerChanged | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | bool | *openToClaim*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newOwner*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *oldOwner*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *capturerHero*, |
|  |  | ChangeOwnerOfSettlementAction.ChangeOwnerOfSettlementDetail | *detail* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_clan_variables_campaign_behavior.html#a64373081fd38857acb5f4d85cb377d09)OnNewGameCreated()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.ClanVariablesCampaignBehavior.OnNewGameCreated | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *starter* | ) |  |

