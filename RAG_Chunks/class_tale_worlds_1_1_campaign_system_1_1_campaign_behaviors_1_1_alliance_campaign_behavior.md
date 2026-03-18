--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_alliance_campaign_behavior.html ---

TaleWorlds.CampaignSystem.CampaignBehaviors.AllianceCampaignBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html), and [TaleWorlds.CampaignSystem.CampaignBehaviors.IAllianceCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alliance_campaign_behavior.html).

|  |  |
| --- | --- |
| Classes | |
| class | [AllianceCampaignBehaviorTypeDefiner](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_alliance_campaign_behavior_1_1_804555152621cb61ec46ecc844490b05.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_alliance_campaign_behavior.html#aacf8aa5a9e9a9e5f05203658652b08aa) () |
| override void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_alliance_campaign_behavior.html#ad16706916b9c672fe3b98a2f88b368af) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| void | [OnCallToWarAgreementProposedByPlayerKingdom](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_alliance_campaign_behavior.html#a868048be3ecce72e1b3069f2a0235d4e) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) proposedKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdomToCallToWarAgainst) |
| bool | [IsAllyWithKingdom](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_alliance_campaign_behavior.html#a1a7d2086f294475ddfb8c08f5f72f092) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom1, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom2) |
| void | [StartAlliance](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_alliance_campaign_behavior.html#a0061d901fd0d1bdfc13ace7ef0c0a0c5) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) proposerKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) receiverKingdom) |
| void | [EndAlliance](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_alliance_campaign_behavior.html#af59e45ce02e46aac643af805054a8a58) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom1, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom2) |
| bool | [HasCalledToWar](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_alliance_campaign_behavior.html#aa17eae4974c9327aab829ecd3076c7d4) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) callingKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) calledKingdom) |
| bool | [IsAtWarByCallToWarAgreement](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_alliance_campaign_behavior.html#acfcc77f7abd0a0950dbb30ecf220183c) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) calledKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdomToCallToWarAgainst) |
| void | [StartCallToWarAgreement](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_alliance_campaign_behavior.html#ac64f95c06e13634200cc6d304449a11d) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) callingKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) calledKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdomToCallToWarAgainst, int callToWarCost, bool isPlayerPaying=false) |
| void | [EndCallToWarAgreement](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_alliance_campaign_behavior.html#a9ae76afd1212746dae4c5c39a4edd45e) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) callingKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) calledKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdomToCallToWarAgainst) |
| List< [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) > | [GetKingdomsToCallToWarAgainst](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_alliance_campaign_behavior.html#aaef6bfa6142fe41dc2697ee1d10979f1) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) callingKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) calledKingdom) |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_alliance_campaign_behavior.html#aacf8aa5a9e9a9e5f05203658652b08aa)RegisterEvents()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.AllianceCampaignBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_alliance_campaign_behavior.html#ad16706916b9c672fe3b98a2f88b368af)SyncData()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.AllianceCampaignBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_alliance_campaign_behavior.html#a868048be3ecce72e1b3069f2a0235d4e)OnCallToWarAgreementProposedByPlayerKingdom()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.AllianceCampaignBehavior.OnCallToWarAgreementProposedByPlayerKingdom | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *proposedKingdom*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdomToCallToWarAgainst* ) |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.IAllianceCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alliance_campaign_behavior.html#a52e8ae68bbf564b258f694a409171030).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_alliance_campaign_behavior.html#a1a7d2086f294475ddfb8c08f5f72f092)IsAllyWithKingdom()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CampaignBehaviors.AllianceCampaignBehavior.IsAllyWithKingdom | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom1*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom2* ) |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.IAllianceCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alliance_campaign_behavior.html#ab61ba982695918055a91c629e5a02872).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_alliance_campaign_behavior.html#a0061d901fd0d1bdfc13ace7ef0c0a0c5)StartAlliance()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.AllianceCampaignBehavior.StartAlliance | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *proposerKingdom*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *receiverKingdom* ) |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.IAllianceCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alliance_campaign_behavior.html#a7b6f94d7351bd00a9b3e6c4de0b57e62).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_alliance_campaign_behavior.html#af59e45ce02e46aac643af805054a8a58)EndAlliance()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.AllianceCampaignBehavior.EndAlliance | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom1*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom2* ) |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.IAllianceCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alliance_campaign_behavior.html#a54d85867510a8974b158bb27de17178b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_alliance_campaign_behavior.html#aa17eae4974c9327aab829ecd3076c7d4)HasCalledToWar()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CampaignBehaviors.AllianceCampaignBehavior.HasCalledToWar | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *callingKingdom*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *calledKingdom* ) |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.IAllianceCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alliance_campaign_behavior.html#aef2a36bd0f6f8a891a4469ce2820505b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_alliance_campaign_behavior.html#acfcc77f7abd0a0950dbb30ecf220183c)IsAtWarByCallToWarAgreement()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CampaignBehaviors.AllianceCampaignBehavior.IsAtWarByCallToWarAgreement | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *calledKingdom*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdomToCallToWarAgainst* ) |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.IAllianceCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alliance_campaign_behavior.html#af49190aed6d8ef8745bf2153e40a73b9).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_alliance_campaign_behavior.html#ac64f95c06e13634200cc6d304449a11d)StartCallToWarAgreement()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.AllianceCampaignBehavior.StartCallToWarAgreement | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *callingKingdom*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *calledKingdom*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdomToCallToWarAgainst*, |
|  |  | int | *callToWarCost*, |
|  |  | bool | *isPlayerPaying* = false ) |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.IAllianceCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alliance_campaign_behavior.html#ade4538ba8082f19cc589e204042433d7).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_alliance_campaign_behavior.html#a9ae76afd1212746dae4c5c39a4edd45e)EndCallToWarAgreement()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.AllianceCampaignBehavior.EndCallToWarAgreement | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *callingKingdom*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *calledKingdom*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdomToCallToWarAgainst* ) |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.IAllianceCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alliance_campaign_behavior.html#abe0280984f69e4de4fb25913f9eb3df8).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_alliance_campaign_behavior.html#aaef6bfa6142fe41dc2697ee1d10979f1)GetKingdomsToCallToWarAgainst()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| List< [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) > TaleWorlds.CampaignSystem.CampaignBehaviors.AllianceCampaignBehavior.GetKingdomsToCallToWarAgainst | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *callingKingdom*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *calledKingdom* ) |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.IAllianceCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alliance_campaign_behavior.html#a48bfdd71a33d46b5b7d9620cdf9faac6).

