--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html ---

TaleWorlds.CampaignSystem.Actions.ChangeKingdomAction Class Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [ChangeKingdomActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#a9b4b755abdfb7030dcc3a26bb9dad035) {     [JoinAsMercenary](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#a9b4b755abdfb7030dcc3a26bb9dad035a69489287f1cabb4fc22e9d851e782234) ,     [JoinKingdom](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#a9b4b755abdfb7030dcc3a26bb9dad035a02fbc349b504db9627269fb4acd5405c) ,     [JoinKingdomByDefection](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#a9b4b755abdfb7030dcc3a26bb9dad035a3ca286c29a02ddc61dd4e6a220de2fac) ,     [LeaveKingdom](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#a9b4b755abdfb7030dcc3a26bb9dad035a91bf2015f85718ad1dfb3647edaec9e1) ,     [LeaveWithRebellion](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#a9b4b755abdfb7030dcc3a26bb9dad035a8fdfbaa5652d776206dcf2533b96fa01) ,     [LeaveAsMercenary](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#a9b4b755abdfb7030dcc3a26bb9dad035adc6cb541e5c501ed18bbd14095bca8a8) ,     [LeaveByClanDestruction](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#a9b4b755abdfb7030dcc3a26bb9dad035ad6e270fae77c4f80d27778c4f002d203) ,     [CreateKingdom](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#a9b4b755abdfb7030dcc3a26bb9dad035a94896d1e2267581d93beec1dd4ca7f9c) ,     [LeaveByKingdomDestruction](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#a9b4b755abdfb7030dcc3a26bb9dad035ae1dd809863b667b5b90fe794f2206489)   } |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [ApplyByJoinToKingdom](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#ae13fdc67f61d631e296011049d60f764) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) newKingdom, [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) shouldStayInKingdomUntil=default, bool showNotification=true) |
| static void | [ApplyByJoinToKingdomByDefection](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#aa6836223994de7f3286b545259c97813) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) oldKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) newKingdom, [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) shouldStayInKingdomUntil=default, bool showNotification=true) |
| static void | [ApplyByCreateKingdom](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#ac6399e29f0621286039b250c26bdfa08) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) newKingdom, bool showNotification=true) |
| static void | [ApplyByLeaveByKingdomDestruction](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#a4b4b1211ff7f5172bec8975dddb4d853) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, bool showNotification=true) |
| static void | [ApplyByLeaveKingdom](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#adab597f3dfe6a3242803a9bd6e78adc2) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, bool showNotification=true) |
| static void | [ApplyByLeaveWithRebellionAgainstKingdom](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#a9ef545878a0daec751ed4af18ff60f23) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, bool showNotification=true) |
| static void | [ApplyByJoinFactionAsMercenary](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#ab4f4e7387a7dfb998bedbc0d98478c28) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) newKingdom, [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) shouldStayInKingdomUntil=default, int awardMultiplier=50, bool showNotification=true) |
| static void | [ApplyByLeaveKingdomAsMercenary](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#a665aa485630239f7bea763bea7a6fe01) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) mercenaryClan, bool showNotification=true) |
| static void | [ApplyByLeaveKingdomByClanDestruction](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#a266c661238b53a3363de6d5991a5dfb2) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, bool showNotification=true) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const float | [PotentialSettlementsPerNobleEffect](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#a0130b6b1862c9c7f855dbf3df5ae7096) = 0.2f |
| const float | [NewGainedFiefsValueForKingdomConstant](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#a7556db87972a1ed25bc8b07417c8a890) = 0.1f |
| const float | [LordsUnitStrengthValue](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#a83bd85c168886da74fbce24d2ba2292f) = 20.0f |
| const float | [MercenaryUnitStrengthValue](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#aabff0cad52c20a1faf0a12c67023182b) = 5.0f |
| const float | [MinimumNeededGoldForRecruitingMercenaries](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#a3d6b3ad0f6ae13b7fb96c9469ad0c025) = 20000 |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#a9b4b755abdfb7030dcc3a26bb9dad035)ChangeKingdomActionDetail
------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.Actions.ChangeKingdomAction.ChangeKingdomActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#a9b4b755abdfb7030dcc3a26bb9dad035) |

| Enumerator | |
| --- | --- |
| JoinAsMercenary |  |
| JoinKingdom |  |
| JoinKingdomByDefection |  |
| LeaveKingdom |  |
| LeaveWithRebellion |  |
| LeaveAsMercenary |  |
| LeaveByClanDestruction |  |
| CreateKingdom |  |
| LeaveByKingdomDestruction |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#ae13fdc67f61d631e296011049d60f764)ApplyByJoinToKingdom()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.ChangeKingdomAction.ApplyByJoinToKingdom | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *newKingdom*, | |  |  | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | *shouldStayInKingdomUntil* = default, | |  |  | bool | *showNotification* = true ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#aa6836223994de7f3286b545259c97813)ApplyByJoinToKingdomByDefection()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.ChangeKingdomAction.ApplyByJoinToKingdomByDefection | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *oldKingdom*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *newKingdom*, | |  |  | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | *shouldStayInKingdomUntil* = default, | |  |  | bool | *showNotification* = true ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#ac6399e29f0621286039b250c26bdfa08)ApplyByCreateKingdom()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.ChangeKingdomAction.ApplyByCreateKingdom | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *newKingdom*, | |  |  | bool | *showNotification* = true ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#a4b4b1211ff7f5172bec8975dddb4d853)ApplyByLeaveByKingdomDestruction()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.ChangeKingdomAction.ApplyByLeaveByKingdomDestruction | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, | |  |  | bool | *showNotification* = true ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#adab597f3dfe6a3242803a9bd6e78adc2)ApplyByLeaveKingdom()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.ChangeKingdomAction.ApplyByLeaveKingdom | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, | |  |  | bool | *showNotification* = true ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#a9ef545878a0daec751ed4af18ff60f23)ApplyByLeaveWithRebellionAgainstKingdom()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.ChangeKingdomAction.ApplyByLeaveWithRebellionAgainstKingdom | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, | |  |  | bool | *showNotification* = true ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#ab4f4e7387a7dfb998bedbc0d98478c28)ApplyByJoinFactionAsMercenary()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.ChangeKingdomAction.ApplyByJoinFactionAsMercenary | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *newKingdom*, | |  |  | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | *shouldStayInKingdomUntil* = default, | |  |  | int | *awardMultiplier* = 50, | |  |  | bool | *showNotification* = true ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#a665aa485630239f7bea763bea7a6fe01)ApplyByLeaveKingdomAsMercenary()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.ChangeKingdomAction.ApplyByLeaveKingdomAsMercenary | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *mercenaryClan*, | |  |  | bool | *showNotification* = true ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#a266c661238b53a3363de6d5991a5dfb2)ApplyByLeaveKingdomByClanDestruction()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.ChangeKingdomAction.ApplyByLeaveKingdomByClanDestruction | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, | |  |  | bool | *showNotification* = true ) | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#a0130b6b1862c9c7f855dbf3df5ae7096)PotentialSettlementsPerNobleEffect
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.CampaignSystem.Actions.ChangeKingdomAction.PotentialSettlementsPerNobleEffect = 0.2f | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#a7556db87972a1ed25bc8b07417c8a890)NewGainedFiefsValueForKingdomConstant
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.CampaignSystem.Actions.ChangeKingdomAction.NewGainedFiefsValueForKingdomConstant = 0.1f | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#a83bd85c168886da74fbce24d2ba2292f)LordsUnitStrengthValue
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.CampaignSystem.Actions.ChangeKingdomAction.LordsUnitStrengthValue = 20.0f | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#aabff0cad52c20a1faf0a12c67023182b)MercenaryUnitStrengthValue
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.CampaignSystem.Actions.ChangeKingdomAction.MercenaryUnitStrengthValue = 5.0f | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#a3d6b3ad0f6ae13b7fb96c9469ad0c025)MinimumNeededGoldForRecruitingMercenaries
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.CampaignSystem.Actions.ChangeKingdomAction.MinimumNeededGoldForRecruitingMercenaries = 20000 | | static |

