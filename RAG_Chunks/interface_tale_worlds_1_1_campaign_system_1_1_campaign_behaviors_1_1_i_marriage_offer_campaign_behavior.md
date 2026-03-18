--- SOURCE: interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_marriage_offer_campaign_behavior.html ---

TaleWorlds.CampaignSystem.CampaignBehaviors.IMarriageOfferCampaignBehavior Interface ReferenceInherits [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html).

Inherited by [TaleWorlds.CampaignSystem.CampaignBehaviors.MarriageOfferCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_marriage_offer_campaign_behavior.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [OnMarriageOfferedToPlayer](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_marriage_offer_campaign_behavior.html#a04b5178a5dc8f24ac4a88f8716ec86a8) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) suitor, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) maiden) |
| void | [OnMarriageOfferCanceled](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_marriage_offer_campaign_behavior.html#a1842b86bd2259704336104e41827864c) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) suitor, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) maiden) |
| MBBindingList< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > | [GetMarriageAcceptedConsequences](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_marriage_offer_campaign_behavior.html#a3ba1ea6e2ae86d828f16cc2ceb5d1bad) () |
| void | [OnMarriageOfferAcceptedOnPopUp](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_marriage_offer_campaign_behavior.html#a55b2ac4bad103534d433a04c7f35da1f) () |
| void | [OnMarriageOfferDeclinedOnPopUp](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_marriage_offer_campaign_behavior.html#a0c95729267e4c63b6c8414d54e256311) () |
| bool | [IsHeroEngaged](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_marriage_offer_campaign_behavior.html#a65d603f22cc23b591a64c4959b6e36c5) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html) | |
| void | [RegisterEvents](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522) () |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_marriage_offer_campaign_behavior.html#a04b5178a5dc8f24ac4a88f8716ec86a8)OnMarriageOfferedToPlayer()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.IMarriageOfferCampaignBehavior.OnMarriageOfferedToPlayer | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *suitor*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *maiden* ) |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.MarriageOfferCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_marriage_offer_campaign_behavior.html#ae769af32d6aad31b5044434915f438bf).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_marriage_offer_campaign_behavior.html#a1842b86bd2259704336104e41827864c)OnMarriageOfferCanceled()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.IMarriageOfferCampaignBehavior.OnMarriageOfferCanceled | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *suitor*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *maiden* ) |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.MarriageOfferCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_marriage_offer_campaign_behavior.html#a6714ffd209ab4f396dc06199cbfc962f).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_marriage_offer_campaign_behavior.html#a3ba1ea6e2ae86d828f16cc2ceb5d1bad)GetMarriageAcceptedConsequences()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| MBBindingList< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > TaleWorlds.CampaignSystem.CampaignBehaviors.IMarriageOfferCampaignBehavior.GetMarriageAcceptedConsequences | ( |  | ) |  |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.MarriageOfferCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_marriage_offer_campaign_behavior.html#a9f18e2a57b29eb2e79fa049fb732735f).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_marriage_offer_campaign_behavior.html#a55b2ac4bad103534d433a04c7f35da1f)OnMarriageOfferAcceptedOnPopUp()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.IMarriageOfferCampaignBehavior.OnMarriageOfferAcceptedOnPopUp | ( |  | ) |  |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.MarriageOfferCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_marriage_offer_campaign_behavior.html#a88e5f85eed267a424ac7015453f21f60).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_marriage_offer_campaign_behavior.html#a0c95729267e4c63b6c8414d54e256311)OnMarriageOfferDeclinedOnPopUp()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.IMarriageOfferCampaignBehavior.OnMarriageOfferDeclinedOnPopUp | ( |  | ) |  |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.MarriageOfferCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_marriage_offer_campaign_behavior.html#a664193cd6fee0ec4c93d16ea535d97b6).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_marriage_offer_campaign_behavior.html#a65d603f22cc23b591a64c4959b6e36c5)IsHeroEngaged()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CampaignBehaviors.IMarriageOfferCampaignBehavior.IsHeroEngaged | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.MarriageOfferCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_marriage_offer_campaign_behavior.html#a6e33a7c2af3734965da85a91d75220f1).

