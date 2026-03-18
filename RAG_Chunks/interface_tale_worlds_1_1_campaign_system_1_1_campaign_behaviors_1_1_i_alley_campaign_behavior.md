--- SOURCE: interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alley_campaign_behavior.html ---

TaleWorlds.CampaignSystem.CampaignBehaviors.IAlleyCampaignBehavior Interface ReferenceInherits [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html).

Inherited by [SandBox.CampaignBehaviors.AlleyCampaignBehavior](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| bool | [GetIsPlayerAlleyUnderAttack](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alley_campaign_behavior.html#aab9437903a349ba179dc450e1176ece6) ([Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) alley) |
| int | [GetPlayerOwnedAlleyTroopCount](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alley_campaign_behavior.html#a0dc7b520b02cf1229dab4055f40f6822) ([Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) alley) |
| int | [GetResponseTimeLeftForAttackInDays](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alley_campaign_behavior.html#a901d63e481d66969629e2e8c90d8fda1) ([Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) alley) |
| void | [AbandonAlleyFromClanMenu](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alley_campaign_behavior.html#a98e9a96f3fa87153e4140c075b5fd7fe) ([Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) alley) |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [GetAssignedClanMemberOfAlley](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alley_campaign_behavior.html#aa6b5718051e5cf66992063e4a0c00b82) ([Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) alley) |
| bool | [IsHeroAlleyLeaderOfAnyPlayerAlley](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alley_campaign_behavior.html#aba79ffd17df2859d6da639ad8fae4423) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| List< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [GetAllAssignedClanMembersForOwnedAlleys](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alley_campaign_behavior.html#adbf0a708635c32d7a7116aad33571855) () |
| void | [ChangeAlleyMember](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alley_campaign_behavior.html#a377a04eb3ccd9685ac1c95fbc53dee6a) ([Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) alley, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newAlleyLead) |
| void | [OnPlayerRetreatedFromMission](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alley_campaign_behavior.html#afb92ee5cded8580daa053273367d8415) () |
| void | [OnPlayerDiedInMission](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alley_campaign_behavior.html#ad1ff959bd5ec5425ad8b6ccf8fddb9cd) () |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html) | |
| void | [RegisterEvents](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522) () |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alley_campaign_behavior.html#aab9437903a349ba179dc450e1176ece6)GetIsPlayerAlleyUnderAttack()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CampaignBehaviors.IAlleyCampaignBehavior.GetIsPlayerAlleyUnderAttack | ( | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | *alley* | ) |  |

Implemented in [SandBox.CampaignBehaviors.AlleyCampaignBehavior](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html#a45d0faa813c5741a5604db896394b044).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alley_campaign_behavior.html#a0dc7b520b02cf1229dab4055f40f6822)GetPlayerOwnedAlleyTroopCount()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.CampaignBehaviors.IAlleyCampaignBehavior.GetPlayerOwnedAlleyTroopCount | ( | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | *alley* | ) |  |

Implemented in [SandBox.CampaignBehaviors.AlleyCampaignBehavior](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html#aec8649fc75ea831585fb0c7b6627ede5).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alley_campaign_behavior.html#a901d63e481d66969629e2e8c90d8fda1)GetResponseTimeLeftForAttackInDays()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.CampaignBehaviors.IAlleyCampaignBehavior.GetResponseTimeLeftForAttackInDays | ( | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | *alley* | ) |  |

Implemented in [SandBox.CampaignBehaviors.AlleyCampaignBehavior](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html#a2264baffa7b4545f6f61bc70086855d0).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alley_campaign_behavior.html#a98e9a96f3fa87153e4140c075b5fd7fe)AbandonAlleyFromClanMenu()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.IAlleyCampaignBehavior.AbandonAlleyFromClanMenu | ( | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | *alley* | ) |  |

Implemented in [SandBox.CampaignBehaviors.AlleyCampaignBehavior](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html#a6820ff2795ec41ee3184d7aec580447e).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alley_campaign_behavior.html#aa6b5718051e5cf66992063e4a0c00b82)GetAssignedClanMemberOfAlley()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.CampaignBehaviors.IAlleyCampaignBehavior.GetAssignedClanMemberOfAlley | ( | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | *alley* | ) |  |

Implemented in [SandBox.CampaignBehaviors.AlleyCampaignBehavior](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html#a93bc7b7bab1e62ebe2eb963fb3fb25d2).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alley_campaign_behavior.html#aba79ffd17df2859d6da639ad8fae4423)IsHeroAlleyLeaderOfAnyPlayerAlley()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CampaignBehaviors.IAlleyCampaignBehavior.IsHeroAlleyLeaderOfAnyPlayerAlley | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

Implemented in [SandBox.CampaignBehaviors.AlleyCampaignBehavior](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html#a623da90d6cebf51be8e472f46684a64f).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alley_campaign_behavior.html#adbf0a708635c32d7a7116aad33571855)GetAllAssignedClanMembersForOwnedAlleys()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| List< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > TaleWorlds.CampaignSystem.CampaignBehaviors.IAlleyCampaignBehavior.GetAllAssignedClanMembersForOwnedAlleys | ( |  | ) |  |

Implemented in [SandBox.CampaignBehaviors.AlleyCampaignBehavior](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html#a368684b8b74cc6a87f44a06a5d9ec947).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alley_campaign_behavior.html#a377a04eb3ccd9685ac1c95fbc53dee6a)ChangeAlleyMember()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.IAlleyCampaignBehavior.ChangeAlleyMember | ( | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | *alley*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newAlleyLead* ) |

Implemented in [SandBox.CampaignBehaviors.AlleyCampaignBehavior](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html#a958d41303cf79cf7c25fb256e61520c4).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alley_campaign_behavior.html#afb92ee5cded8580daa053273367d8415)OnPlayerRetreatedFromMission()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.IAlleyCampaignBehavior.OnPlayerRetreatedFromMission | ( |  | ) |  |

Implemented in [SandBox.CampaignBehaviors.AlleyCampaignBehavior](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html#a9eab02ff8fe625d0edd1fc54943881dd).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alley_campaign_behavior.html#ad1ff959bd5ec5425ad8b6ccf8fddb9cd)OnPlayerDiedInMission()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.IAlleyCampaignBehavior.OnPlayerDiedInMission | ( |  | ) |  |

Implemented in [SandBox.CampaignBehaviors.AlleyCampaignBehavior](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html#ad3a3118ccd9cfc90a83373921081e2e6).

