--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_rumors_campaign_behavior.html ---

TaleWorlds.CampaignSystem.CampaignBehaviors.TradeRumorsCampaignBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html), and [TaleWorlds.CampaignSystem.CampaignBehaviors.ITradeRumorCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_trade_rumor_campaign_behavior.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_rumors_campaign_behavior.html#ac451d928b7b85a2a12448b08ccb42a4d) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| override void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_rumors_campaign_behavior.html#a4a1b69b6c5e3d45553064a8dad7a2da5) () |
| void | [OnTradeRumorIsTaken](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_rumors_campaign_behavior.html#aa16f9693b806d11e56411fd2399adced) (List< [TradeRumor](class_tale_worlds_1_1_campaign_system_1_1_trade_rumor.html) > newRumors, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) sourceSettlement=null) |
| void | [AddTradeRumors](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_rumors_campaign_behavior.html#ae6bf23d68673ccaf7a26b34b515d50f3) (List< [TradeRumor](class_tale_worlds_1_1_campaign_system_1_1_trade_rumor.html) > newRumors, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) sourceSettlement=null) |
| void | [DailyTick](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_rumors_campaign_behavior.html#aa49a80a3ae8fd7e0d5ac220f08971e96) () |
| void | [OnSettlementEntered](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_rumors_campaign_behavior.html#a303854a1f2de3078d0047818cf035cdd) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| void | [DeleteExpiredRumors](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_rumors_campaign_behavior.html#afcc4a4997a599e48c09ad43e712908b8) () |
| void | [AddDailyTradeRumors](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_rumors_campaign_behavior.html#aabca16527085298793603d10c8a80dbf) (int numberOfTradeRumors) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a053965730807cc40179cb1ee0495c376) (string stringId) |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab8914958880a708aaf68f676e6c29df1) () |
| void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a402e03be483527df560a46a7a01004a6) () |
| void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a5f2a833b5a67619021c6c437a1232877) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |

|  |  |
| --- | --- |
| Properties | |
| IEnumerable< [TradeRumor](class_tale_worlds_1_1_campaign_system_1_1_trade_rumor.html) > | [TradeRumors](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_rumors_campaign_behavior.html#ae289686f59bd687ec370f0e16211e0b2) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| static T | [GetCampaignBehavior< T >](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#af9fd34472faff4ae39b627e8d3091b7e) () |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| readonly string | [StringId](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab1c3b0a4161f58781148a9499be70fa3) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_rumors_campaign_behavior.html#ac451d928b7b85a2a12448b08ccb42a4d)SyncData()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.TradeRumorsCampaignBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_rumors_campaign_behavior.html#a4a1b69b6c5e3d45553064a8dad7a2da5)RegisterEvents()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.TradeRumorsCampaignBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_rumors_campaign_behavior.html#aa16f9693b806d11e56411fd2399adced)OnTradeRumorIsTaken()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.TradeRumorsCampaignBehavior.OnTradeRumorIsTaken | ( | List< [TradeRumor](class_tale_worlds_1_1_campaign_system_1_1_trade_rumor.html) > | *newRumors*, |
|  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *sourceSettlement* = null ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_rumors_campaign_behavior.html#ae6bf23d68673ccaf7a26b34b515d50f3)AddTradeRumors()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.TradeRumorsCampaignBehavior.AddTradeRumors | ( | List< [TradeRumor](class_tale_worlds_1_1_campaign_system_1_1_trade_rumor.html) > | *newRumors*, |
|  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *sourceSettlement* = null ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_rumors_campaign_behavior.html#aa49a80a3ae8fd7e0d5ac220f08971e96)DailyTick()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.TradeRumorsCampaignBehavior.DailyTick | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_rumors_campaign_behavior.html#a303854a1f2de3078d0047818cf035cdd)OnSettlementEntered()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.TradeRumorsCampaignBehavior.OnSettlementEntered | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, |
|  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_rumors_campaign_behavior.html#afcc4a4997a599e48c09ad43e712908b8)DeleteExpiredRumors()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.TradeRumorsCampaignBehavior.DeleteExpiredRumors | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_rumors_campaign_behavior.html#aabca16527085298793603d10c8a80dbf)AddDailyTradeRumors()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.TradeRumorsCampaignBehavior.AddDailyTradeRumors | ( | int | *numberOfTradeRumors* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_rumors_campaign_behavior.html#ae289686f59bd687ec370f0e16211e0b2)TradeRumors
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IEnumerable<[TradeRumor](class_tale_worlds_1_1_campaign_system_1_1_trade_rumor.html)> TaleWorlds.CampaignSystem.CampaignBehaviors.TradeRumorsCampaignBehavior.TradeRumors | | get |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.ITradeRumorCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_trade_rumor_campaign_behavior.html#aa516b030b5c5114f534dbd1781f745b9).

