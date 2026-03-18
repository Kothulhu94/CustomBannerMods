--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_skill_campaign_behavior.html ---

TaleWorlds.CampaignSystem.CampaignBehaviors.TradeSkillCampaignBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html), and [TaleWorlds.CampaignSystem.Inventory.IPlayerTradeBehavior](interface_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_i_player_trade_behavior.html).

|  |  |
| --- | --- |
| Classes | |
| class | [TradeSkillCampaignBehaviorTypeDefiner](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_skill_campaign_behavior_1523282d933b1db93b508e402c5142e0a.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_skill_campaign_behavior.html#ad501dfedc2b82a4b846654712632e17a) () |
| override void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_skill_campaign_behavior.html#acccef6278d499702d8dae2266d20411c) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| int | [GetProjectedProfit](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_skill_campaign_behavior.html#ad22351410f61d2250335dfaa7f1cf94f) ([ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) itemRosterElement, int itemCost) |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_skill_campaign_behavior.html#ad501dfedc2b82a4b846654712632e17a)RegisterEvents()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.TradeSkillCampaignBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_skill_campaign_behavior.html#acccef6278d499702d8dae2266d20411c)SyncData()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.TradeSkillCampaignBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_skill_campaign_behavior.html#ad22351410f61d2250335dfaa7f1cf94f)GetProjectedProfit()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.CampaignBehaviors.TradeSkillCampaignBehavior.GetProjectedProfit | ( | [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) | *itemRosterElement*, |
|  |  | int | *itemCost* ) |

Implements [TaleWorlds.CampaignSystem.Inventory.IPlayerTradeBehavior](interface_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_i_player_trade_behavior.html#ac4558c7b5d88b68b4de1b1b3d0812564).

