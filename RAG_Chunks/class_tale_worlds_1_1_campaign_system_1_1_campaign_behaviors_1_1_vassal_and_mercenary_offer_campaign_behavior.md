--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_vassal_and_mercenary_offer_campaign_behavior.html ---

TaleWorlds.CampaignSystem.CampaignBehaviors.VassalAndMercenaryOfferCampaignBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html), and [TaleWorlds.CampaignSystem.CampaignBehaviors.IVassalAndMercenaryOfferCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_vassal_and_mercenary_offer_campaign_behavior.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_vassal_and_mercenary_offer_campaign_behavior.html#ada653dc8859116e02c6f39015936b320) () |
| override void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_vassal_and_mercenary_offer_campaign_behavior.html#ac11f47d2c5fece45134705c7eb44f4b7) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| void | [CancelVassalOrMercenaryServiceOffer](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_vassal_and_mercenary_offer_campaign_behavior.html#ac78c92ab91249dd4dccacdf7fafa0815) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom) |
| void | [CreateMercenaryOffer](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_vassal_and_mercenary_offer_campaign_behavior.html#a0d975a566bf0b8f48610186d5d1616bc) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom) |
| void | [CreateVassalOffer](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_vassal_and_mercenary_offer_campaign_behavior.html#adf8c9c7559e6786579fb992cfc50295a) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom) |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_vassal_and_mercenary_offer_campaign_behavior.html#ada653dc8859116e02c6f39015936b320)RegisterEvents()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.VassalAndMercenaryOfferCampaignBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_vassal_and_mercenary_offer_campaign_behavior.html#ac11f47d2c5fece45134705c7eb44f4b7)SyncData()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.VassalAndMercenaryOfferCampaignBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_vassal_and_mercenary_offer_campaign_behavior.html#ac78c92ab91249dd4dccacdf7fafa0815)CancelVassalOrMercenaryServiceOffer()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.VassalAndMercenaryOfferCampaignBehavior.CancelVassalOrMercenaryServiceOffer | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom* | ) |  |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.IVassalAndMercenaryOfferCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_vassal_and_mercenary_offer_campaign_behavior.html#ad2761985e2cd7ee31c512c3b4a4c9195).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_vassal_and_mercenary_offer_campaign_behavior.html#a0d975a566bf0b8f48610186d5d1616bc)CreateMercenaryOffer()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.VassalAndMercenaryOfferCampaignBehavior.CreateMercenaryOffer | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_vassal_and_mercenary_offer_campaign_behavior.html#adf8c9c7559e6786579fb992cfc50295a)CreateVassalOffer()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.VassalAndMercenaryOfferCampaignBehavior.CreateVassalOffer | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom* | ) |  |

