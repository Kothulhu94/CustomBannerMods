--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_agreements_campaign_behavior.html ---

TaleWorlds.CampaignSystem.CampaignBehaviors.TradeAgreementsCampaignBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html), and [TaleWorlds.CampaignSystem.CampaignBehaviors.ITradeAgreementsCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_trade_agreements_campaign_behavior.html).

|  |  |
| --- | --- |
| Classes | |
| class | [TradeAgreementsCampaignBehaviorTypeDefiner](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_agreements_campaign_behave533f031e221077ca4ee2efceea98ed4.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_agreements_campaign_behavior.html#a196432fdfebf9e12f3c00e8a2701b8d7) () |
| void | [OnTradeAgreementOfferedToPlayer](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_agreements_campaign_behavior.html#acb1df07c7f91e7b6af0e20b7ba546f8e) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) fromKingdom) |
| override void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_agreements_campaign_behavior.html#a92892e56e8170e813c34e7f7cf7c8854) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| void | [MakeTradeAgreement](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_agreements_campaign_behavior.html#af3ee0d185d2550ede8e9c156cf123276) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom1, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom2, [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) duration) |
| void | [EndTradeAgreementsOfKingdom](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_agreements_campaign_behavior.html#a4cf2426f79a5ed9de041be835d52290f) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom) |
| void | [EndTradeAgreement](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_agreements_campaign_behavior.html#a2485f50f9ddf8cb9b846ed8481db1568) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom1, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom2) |
| bool | [HasTradeAgreement](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_agreements_campaign_behavior.html#a7094081b22de841a75b35e127941f160) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom1, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom2) |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [GetTradeAgreementEndDate](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_agreements_campaign_behavior.html#a418a62b11d7405d59507cb2d80ee0fb1) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom1, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom2) |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_agreements_campaign_behavior.html#a196432fdfebf9e12f3c00e8a2701b8d7)RegisterEvents()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.TradeAgreementsCampaignBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_agreements_campaign_behavior.html#acb1df07c7f91e7b6af0e20b7ba546f8e)OnTradeAgreementOfferedToPlayer()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.TradeAgreementsCampaignBehavior.OnTradeAgreementOfferedToPlayer | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *fromKingdom* | ) |  |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.ITradeAgreementsCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_trade_agreements_campaign_behavior.html#a15daf8a61dc58808cb87c330dad6c4c3).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_agreements_campaign_behavior.html#a92892e56e8170e813c34e7f7cf7c8854)SyncData()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.TradeAgreementsCampaignBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_agreements_campaign_behavior.html#af3ee0d185d2550ede8e9c156cf123276)MakeTradeAgreement()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.TradeAgreementsCampaignBehavior.MakeTradeAgreement | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom1*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom2*, |
|  |  | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | *duration* ) |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.ITradeAgreementsCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_trade_agreements_campaign_behavior.html#a32559c10ed823dea520f6e2e63c51085).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_agreements_campaign_behavior.html#a4cf2426f79a5ed9de041be835d52290f)EndTradeAgreementsOfKingdom()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.TradeAgreementsCampaignBehavior.EndTradeAgreementsOfKingdom | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_agreements_campaign_behavior.html#a2485f50f9ddf8cb9b846ed8481db1568)EndTradeAgreement()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.TradeAgreementsCampaignBehavior.EndTradeAgreement | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom1*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom2* ) |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.ITradeAgreementsCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_trade_agreements_campaign_behavior.html#ac5ac61fcb8cc2405c865be3c27b9ace9).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_agreements_campaign_behavior.html#a7094081b22de841a75b35e127941f160)HasTradeAgreement()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CampaignBehaviors.TradeAgreementsCampaignBehavior.HasTradeAgreement | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom1*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom2* ) |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.ITradeAgreementsCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_trade_agreements_campaign_behavior.html#a5ff11b4bf07ecc1131819d8a817afbb9).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_agreements_campaign_behavior.html#a418a62b11d7405d59507cb2d80ee0fb1)GetTradeAgreementEndDate()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.CampaignBehaviors.TradeAgreementsCampaignBehavior.GetTradeAgreementEndDate | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom1*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom2* ) |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.ITradeAgreementsCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_trade_agreements_campaign_behavior.html#a387e16eaa7a51344eaf5062866222227).

