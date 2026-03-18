--- SOURCE: interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_trade_agreements_campaign_behavior.html ---

TaleWorlds.CampaignSystem.CampaignBehaviors.ITradeAgreementsCampaignBehavior Interface ReferenceInherited by [TaleWorlds.CampaignSystem.CampaignBehaviors.TradeAgreementsCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_agreements_campaign_behavior.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [MakeTradeAgreement](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_trade_agreements_campaign_behavior.html#a32559c10ed823dea520f6e2e63c51085) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom1, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom2, [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) duration) |
| bool | [HasTradeAgreement](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_trade_agreements_campaign_behavior.html#a5ff11b4bf07ecc1131819d8a817afbb9) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) other) |
| void | [EndTradeAgreement](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_trade_agreements_campaign_behavior.html#ac5ac61fcb8cc2405c865be3c27b9ace9) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) other) |
| void | [OnTradeAgreementOfferedToPlayer](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_trade_agreements_campaign_behavior.html#a15daf8a61dc58808cb87c330dad6c4c3) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) fromKingdom) |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [GetTradeAgreementEndDate](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_trade_agreements_campaign_behavior.html#a387e16eaa7a51344eaf5062866222227) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) other) |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_trade_agreements_campaign_behavior.html#a32559c10ed823dea520f6e2e63c51085)MakeTradeAgreement()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.ITradeAgreementsCampaignBehavior.MakeTradeAgreement | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom1*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom2*, |
|  |  | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | *duration* ) |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.TradeAgreementsCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_agreements_campaign_behavior.html#af3ee0d185d2550ede8e9c156cf123276).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_trade_agreements_campaign_behavior.html#a5ff11b4bf07ecc1131819d8a817afbb9)HasTradeAgreement()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CampaignBehaviors.ITradeAgreementsCampaignBehavior.HasTradeAgreement | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *other* ) |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.TradeAgreementsCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_agreements_campaign_behavior.html#a7094081b22de841a75b35e127941f160).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_trade_agreements_campaign_behavior.html#ac5ac61fcb8cc2405c865be3c27b9ace9)EndTradeAgreement()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.ITradeAgreementsCampaignBehavior.EndTradeAgreement | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *other* ) |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.TradeAgreementsCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_agreements_campaign_behavior.html#a2485f50f9ddf8cb9b846ed8481db1568).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_trade_agreements_campaign_behavior.html#a15daf8a61dc58808cb87c330dad6c4c3)OnTradeAgreementOfferedToPlayer()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.ITradeAgreementsCampaignBehavior.OnTradeAgreementOfferedToPlayer | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *fromKingdom* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.TradeAgreementsCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_agreements_campaign_behavior.html#acb1df07c7f91e7b6af0e20b7ba546f8e).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_trade_agreements_campaign_behavior.html#a387e16eaa7a51344eaf5062866222227)GetTradeAgreementEndDate()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.CampaignBehaviors.ITradeAgreementsCampaignBehavior.GetTradeAgreementEndDate | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *other* ) |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.TradeAgreementsCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_agreements_campaign_behavior.html#a418a62b11d7405d59507cb2d80ee0fb1).

