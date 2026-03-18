--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_marriage_offer_campaign_behavior.html ---

TaleWorlds.CampaignSystem.CampaignBehaviors.MarriageOfferCampaignBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html), and [TaleWorlds.CampaignSystem.CampaignBehaviors.IMarriageOfferCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_marriage_offer_campaign_behavior.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_marriage_offer_campaign_behavior.html#a77466e5282fbfaa62600782bc6bcd82d) () |
| override void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_marriage_offer_campaign_behavior.html#abd455a522a8d5b5769b13b4f80784091) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| void | [CreateMarriageOffer](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_marriage_offer_campaign_behavior.html#a8c151a75f92b4ffaddbdbfd0afee550e) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) currentOfferedPlayerClanHero, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) currentOfferedOtherClanHero) |
| MBBindingList< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > | [GetMarriageAcceptedConsequences](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_marriage_offer_campaign_behavior.html#a9f18e2a57b29eb2e79fa049fb732735f) () |
| void | [OnMarriageOfferAcceptedOnPopUp](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_marriage_offer_campaign_behavior.html#a88e5f85eed267a424ac7015453f21f60) () |
| void | [OnMarriageOfferedToPlayer](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_marriage_offer_campaign_behavior.html#ae769af32d6aad31b5044434915f438bf) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) suitor, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) maiden) |
| void | [OnMarriageOfferDeclinedOnPopUp](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_marriage_offer_campaign_behavior.html#a664193cd6fee0ec4c93d16ea535d97b6) () |
| void | [OnMarriageOfferCanceled](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_marriage_offer_campaign_behavior.html#a6714ffd209ab4f396dc06199cbfc962f) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) suitor, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) maiden) |
| bool | [IsHeroEngaged](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_marriage_offer_campaign_behavior.html#a6e33a7c2af3734965da85a91d75220f1) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_marriage_offer_campaign_behavior.html#a77466e5282fbfaa62600782bc6bcd82d)RegisterEvents()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.MarriageOfferCampaignBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_marriage_offer_campaign_behavior.html#abd455a522a8d5b5769b13b4f80784091)SyncData()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.MarriageOfferCampaignBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_marriage_offer_campaign_behavior.html#a8c151a75f92b4ffaddbdbfd0afee550e)CreateMarriageOffer()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.MarriageOfferCampaignBehavior.CreateMarriageOffer | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *currentOfferedPlayerClanHero*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *currentOfferedOtherClanHero* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_marriage_offer_campaign_behavior.html#a9f18e2a57b29eb2e79fa049fb732735f)GetMarriageAcceptedConsequences()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| MBBindingList< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > TaleWorlds.CampaignSystem.CampaignBehaviors.MarriageOfferCampaignBehavior.GetMarriageAcceptedConsequences | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.IMarriageOfferCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_marriage_offer_campaign_behavior.html#a3ba1ea6e2ae86d828f16cc2ceb5d1bad).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_marriage_offer_campaign_behavior.html#a88e5f85eed267a424ac7015453f21f60)OnMarriageOfferAcceptedOnPopUp()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.MarriageOfferCampaignBehavior.OnMarriageOfferAcceptedOnPopUp | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.IMarriageOfferCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_marriage_offer_campaign_behavior.html#a55b2ac4bad103534d433a04c7f35da1f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_marriage_offer_campaign_behavior.html#ae769af32d6aad31b5044434915f438bf)OnMarriageOfferedToPlayer()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.MarriageOfferCampaignBehavior.OnMarriageOfferedToPlayer | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *suitor*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *maiden* ) |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.IMarriageOfferCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_marriage_offer_campaign_behavior.html#a04b5178a5dc8f24ac4a88f8716ec86a8).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_marriage_offer_campaign_behavior.html#a664193cd6fee0ec4c93d16ea535d97b6)OnMarriageOfferDeclinedOnPopUp()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.MarriageOfferCampaignBehavior.OnMarriageOfferDeclinedOnPopUp | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.IMarriageOfferCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_marriage_offer_campaign_behavior.html#a0c95729267e4c63b6c8414d54e256311).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_marriage_offer_campaign_behavior.html#a6714ffd209ab4f396dc06199cbfc962f)OnMarriageOfferCanceled()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.MarriageOfferCampaignBehavior.OnMarriageOfferCanceled | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *suitor*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *maiden* ) |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.IMarriageOfferCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_marriage_offer_campaign_behavior.html#a1842b86bd2259704336104e41827864c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_marriage_offer_campaign_behavior.html#a6e33a7c2af3734965da85a91d75220f1)IsHeroEngaged()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CampaignBehaviors.MarriageOfferCampaignBehavior.IsHeroEngaged | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.IMarriageOfferCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_marriage_offer_campaign_behavior.html#a65d603f22cc23b591a64c4959b6e36c5).

