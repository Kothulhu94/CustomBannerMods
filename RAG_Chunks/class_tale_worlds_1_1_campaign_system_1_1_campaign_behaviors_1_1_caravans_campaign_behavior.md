--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_caravans_campaign_behavior.html ---

TaleWorlds.CampaignSystem.CampaignBehaviors.CaravansCampaignBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html).

|  |  |
| --- | --- |
| Classes | |
| class | [CaravansCampaignBehaviorTypeDefiner](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_caravans_campaign_behavior_1_1_db59157a26093ab04b5c2902b52fd7b3.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [CaravansCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_caravans_campaign_behavior.html#aea1e508a81961c141acf2507b7c8969d) () |
| override void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_caravans_campaign_behavior.html#a21dc49b8cf3f1faeb8f49b4ffc3362ef) () |
| override void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_caravans_campaign_behavior.html#afdf9a947cc826d4b9eb9803b39835088) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| void | [OnSessionLaunched](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_caravans_campaign_behavior.html#a59ec57d3c3429f6bf08e2ecff0f718ab) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameStarter) |
| void | [SpawnCaravan](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_caravans_campaign_behavior.html#af66e81e0dc915e4773b95edaa8d291dc) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, bool initialSpawn=false) |
| void | [DailyTick](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_caravans_campaign_behavior.html#ab8603d48c5168489a707a63ff65a064a) () |
| void | [HourlyTickParty](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_caravans_campaign_behavior.html#a91f3318499852646edf8b74b0843942b) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| void | [OnSettlementEntered](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_caravans_campaign_behavior.html#adcf1b4bc2a6372a5ea0718ca3c80f6d0) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| void | [OnSettlementLeft](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_caravans_campaign_behavior.html#a22a19a4f011b14f59ffd36a228a6a3fa) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a053965730807cc40179cb1ee0495c376) (string stringId) |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab8914958880a708aaf68f676e6c29df1) () |
| void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a402e03be483527df560a46a7a01004a6) () |
| void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a5f2a833b5a67619021c6c437a1232877) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| void | [AddDialogs](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_caravans_campaign_behavior.html#af081c9b9c3b0cd7b2262ee567261438f) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) starter) |

|  |  |
| --- | --- |
| Properties | |
| [ITradeAgreementsCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_trade_agreements_campaign_behavior.html) | [TradeAgreementsCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_caravans_campaign_behavior.html#adfc9a42ff13d92920913eee1444a1e87) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| static T | [GetCampaignBehavior< T >](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#af9fd34472faff4ae39b627e8d3091b7e) () |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| readonly string | [StringId](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab1c3b0a4161f58781148a9499be70fa3) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_caravans_campaign_behavior.html#aea1e508a81961c141acf2507b7c8969d)CaravansCampaignBehavior()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.CampaignBehaviors.CaravansCampaignBehavior.CaravansCampaignBehavior | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_caravans_campaign_behavior.html#a21dc49b8cf3f1faeb8f49b4ffc3362ef)RegisterEvents()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.CaravansCampaignBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_caravans_campaign_behavior.html#afdf9a947cc826d4b9eb9803b39835088)SyncData()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.CaravansCampaignBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_caravans_campaign_behavior.html#a59ec57d3c3429f6bf08e2ecff0f718ab)OnSessionLaunched()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.CaravansCampaignBehavior.OnSessionLaunched | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *campaignGameStarter* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_caravans_campaign_behavior.html#af66e81e0dc915e4773b95edaa8d291dc)SpawnCaravan()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.CaravansCampaignBehavior.SpawnCaravan | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | bool | *initialSpawn* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_caravans_campaign_behavior.html#ab8603d48c5168489a707a63ff65a064a)DailyTick()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.CaravansCampaignBehavior.DailyTick | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_caravans_campaign_behavior.html#a91f3318499852646edf8b74b0843942b)HourlyTickParty()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.CaravansCampaignBehavior.HourlyTickParty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_caravans_campaign_behavior.html#adcf1b4bc2a6372a5ea0718ca3c80f6d0)OnSettlementEntered()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.CaravansCampaignBehavior.OnSettlementEntered | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, |
|  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_caravans_campaign_behavior.html#a22a19a4f011b14f59ffd36a228a6a3fa)OnSettlementLeft()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.CaravansCampaignBehavior.OnSettlementLeft | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, |
|  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_caravans_campaign_behavior.html#af081c9b9c3b0cd7b2262ee567261438f)AddDialogs()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CampaignBehaviors.CaravansCampaignBehavior.AddDialogs | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *starter* | ) |  | | protected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_caravans_campaign_behavior.html#adfc9a42ff13d92920913eee1444a1e87)TradeAgreementsCampaignBehavior
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ITradeAgreementsCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_trade_agreements_campaign_behavior.html) TaleWorlds.CampaignSystem.CampaignBehaviors.CaravansCampaignBehavior.TradeAgreementsCampaignBehavior | | get |

