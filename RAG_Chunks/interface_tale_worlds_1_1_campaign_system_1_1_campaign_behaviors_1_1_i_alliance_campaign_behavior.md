--- SOURCE: interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alliance_campaign_behavior.html ---

TaleWorlds.CampaignSystem.CampaignBehaviors.IAllianceCampaignBehavior Interface ReferenceInherited by [TaleWorlds.CampaignSystem.CampaignBehaviors.AllianceCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_alliance_campaign_behavior.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [OnAllianceOfferedToPlayerKingdom](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alliance_campaign_behavior.html#a63b5a54fed13a6350d357c7838b864a3) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) proposerKingdom) |
| void | [OnAllianceOfferedToPlayer](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alliance_campaign_behavior.html#ae64fee628c63aa24682c57c894e366bb) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) proposerKingdom) |
| void | [OnCallToWarAgreementProposedToPlayerKingdom](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alliance_campaign_behavior.html#aa380de3984c63e7f24aeb3f054c9cdbf) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) proposerKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdomToCallToWarAgainst) |
| void | [OnCallToWarAgreementProposedByPlayerKingdom](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alliance_campaign_behavior.html#a52e8ae68bbf564b258f694a409171030) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) proposedKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdomToCallToWarAgainst) |
| void | [OnCallToWarAgreementProposedToPlayer](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alliance_campaign_behavior.html#a511a9fb7fbf46a57b8c25cbe3fe1e0fa) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) proposerKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdomToCallToWarAgainst) |
| void | [OnCallToWarAgreementProposedByPlayer](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alliance_campaign_behavior.html#affd506c9cb32b4abedcf3480656b2b13) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) proposedKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdomToCallToWarAgainst) |
| bool | [IsAllyWithKingdom](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alliance_campaign_behavior.html#ab61ba982695918055a91c629e5a02872) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom1, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom2) |
| void | [StartAlliance](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alliance_campaign_behavior.html#a7b6f94d7351bd00a9b3e6c4de0b57e62) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) proposerKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) receiverKingdom) |
| void | [EndAlliance](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alliance_campaign_behavior.html#a54d85867510a8974b158bb27de17178b) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom1, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom2) |
| bool | [HasCalledToWar](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alliance_campaign_behavior.html#aef2a36bd0f6f8a891a4469ce2820505b) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) callingKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) calledKingdom) |
| bool | [IsAtWarByCallToWarAgreement](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alliance_campaign_behavior.html#af49190aed6d8ef8745bf2153e40a73b9) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) calledKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdomToCallToWarAgainst) |
| void | [StartCallToWarAgreement](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alliance_campaign_behavior.html#ade4538ba8082f19cc589e204042433d7) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) callingKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) calledKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdomToCallToWarAgainst, int callToWarCost, bool isPlayerPaying=false) |
| void | [EndCallToWarAgreement](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alliance_campaign_behavior.html#abe0280984f69e4de4fb25913f9eb3df8) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) callingKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) calledKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdomToCallToWarAgainst) |
| List< [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) > | [GetKingdomsToCallToWarAgainst](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alliance_campaign_behavior.html#a48bfdd71a33d46b5b7d9620cdf9faac6) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) callingKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) calledKingdom) |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [GetAllianceEndDate](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alliance_campaign_behavior.html#aafc88d8c8081f34d05d9b0136425ee93) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom1, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom2) |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alliance_campaign_behavior.html#a63b5a54fed13a6350d357c7838b864a3)OnAllianceOfferedToPlayerKingdom()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.IAllianceCampaignBehavior.OnAllianceOfferedToPlayerKingdom | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *proposerKingdom* | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alliance_campaign_behavior.html#ae64fee628c63aa24682c57c894e366bb)OnAllianceOfferedToPlayer()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.IAllianceCampaignBehavior.OnAllianceOfferedToPlayer | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *proposerKingdom* | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alliance_campaign_behavior.html#aa380de3984c63e7f24aeb3f054c9cdbf)OnCallToWarAgreementProposedToPlayerKingdom()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.IAllianceCampaignBehavior.OnCallToWarAgreementProposedToPlayerKingdom | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *proposerKingdom*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdomToCallToWarAgainst* ) |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alliance_campaign_behavior.html#a52e8ae68bbf564b258f694a409171030)OnCallToWarAgreementProposedByPlayerKingdom()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.IAllianceCampaignBehavior.OnCallToWarAgreementProposedByPlayerKingdom | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *proposedKingdom*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdomToCallToWarAgainst* ) |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.AllianceCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_alliance_campaign_behavior.html#a868048be3ecce72e1b3069f2a0235d4e).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alliance_campaign_behavior.html#a511a9fb7fbf46a57b8c25cbe3fe1e0fa)OnCallToWarAgreementProposedToPlayer()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.IAllianceCampaignBehavior.OnCallToWarAgreementProposedToPlayer | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *proposerKingdom*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdomToCallToWarAgainst* ) |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alliance_campaign_behavior.html#affd506c9cb32b4abedcf3480656b2b13)OnCallToWarAgreementProposedByPlayer()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.IAllianceCampaignBehavior.OnCallToWarAgreementProposedByPlayer | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *proposedKingdom*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdomToCallToWarAgainst* ) |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alliance_campaign_behavior.html#ab61ba982695918055a91c629e5a02872)IsAllyWithKingdom()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CampaignBehaviors.IAllianceCampaignBehavior.IsAllyWithKingdom | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom1*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom2* ) |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.AllianceCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_alliance_campaign_behavior.html#a1a7d2086f294475ddfb8c08f5f72f092).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alliance_campaign_behavior.html#a7b6f94d7351bd00a9b3e6c4de0b57e62)StartAlliance()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.IAllianceCampaignBehavior.StartAlliance | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *proposerKingdom*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *receiverKingdom* ) |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.AllianceCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_alliance_campaign_behavior.html#a0061d901fd0d1bdfc13ace7ef0c0a0c5).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alliance_campaign_behavior.html#a54d85867510a8974b158bb27de17178b)EndAlliance()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.IAllianceCampaignBehavior.EndAlliance | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom1*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom2* ) |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.AllianceCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_alliance_campaign_behavior.html#af59e45ce02e46aac643af805054a8a58).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alliance_campaign_behavior.html#aef2a36bd0f6f8a891a4469ce2820505b)HasCalledToWar()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CampaignBehaviors.IAllianceCampaignBehavior.HasCalledToWar | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *callingKingdom*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *calledKingdom* ) |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.AllianceCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_alliance_campaign_behavior.html#aa17eae4974c9327aab829ecd3076c7d4).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alliance_campaign_behavior.html#af49190aed6d8ef8745bf2153e40a73b9)IsAtWarByCallToWarAgreement()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CampaignBehaviors.IAllianceCampaignBehavior.IsAtWarByCallToWarAgreement | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *calledKingdom*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdomToCallToWarAgainst* ) |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.AllianceCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_alliance_campaign_behavior.html#acfcc77f7abd0a0950dbb30ecf220183c).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alliance_campaign_behavior.html#ade4538ba8082f19cc589e204042433d7)StartCallToWarAgreement()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.IAllianceCampaignBehavior.StartCallToWarAgreement | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *callingKingdom*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *calledKingdom*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdomToCallToWarAgainst*, |
|  |  | int | *callToWarCost*, |
|  |  | bool | *isPlayerPaying* = false ) |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.AllianceCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_alliance_campaign_behavior.html#ac64f95c06e13634200cc6d304449a11d).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alliance_campaign_behavior.html#abe0280984f69e4de4fb25913f9eb3df8)EndCallToWarAgreement()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.IAllianceCampaignBehavior.EndCallToWarAgreement | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *callingKingdom*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *calledKingdom*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdomToCallToWarAgainst* ) |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.AllianceCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_alliance_campaign_behavior.html#a9ae76afd1212746dae4c5c39a4edd45e).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alliance_campaign_behavior.html#a48bfdd71a33d46b5b7d9620cdf9faac6)GetKingdomsToCallToWarAgainst()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| List< [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) > TaleWorlds.CampaignSystem.CampaignBehaviors.IAllianceCampaignBehavior.GetKingdomsToCallToWarAgainst | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *callingKingdom*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *calledKingdom* ) |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.AllianceCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_alliance_campaign_behavior.html#aaef6bfa6142fe41dc2697ee1d10979f1).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alliance_campaign_behavior.html#aafc88d8c8081f34d05d9b0136425ee93)GetAllianceEndDate()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.CampaignBehaviors.IAllianceCampaignBehavior.GetAllianceEndDate | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom1*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom2* ) |

