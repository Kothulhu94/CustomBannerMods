--- SOURCE: class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html ---

SandBox.CampaignBehaviors.AlleyCampaignBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html), and [TaleWorlds.CampaignSystem.CampaignBehaviors.IAlleyCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alley_campaign_behavior.html).

|  |  |
| --- | --- |
| Classes | |
| class | [AlleyCampaignBehaviorTypeDefiner](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior_1_1_alley_campaign_behavior_type_definer.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [RegisterEvents](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html#a5714a57be07b73b9e0c24a682b57e2fc) () |
| override void | [SyncData](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html#a9f80eef1f693449d25b6566e9a9384a0) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| void | [OnSessionLaunched](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html#a415004fafe5b43a7b73b58dd0d33c66e) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameStarter) |
| bool | [GetIsPlayerAlleyUnderAttack](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html#a45d0faa813c5741a5604db896394b044) ([Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) alley) |
| int | [GetPlayerOwnedAlleyTroopCount](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html#aec8649fc75ea831585fb0c7b6627ede5) ([Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) alley) |
| int | [GetResponseTimeLeftForAttackInDays](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html#a2264baffa7b4545f6f61bc70086855d0) ([Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) alley) |
| void | [AbandonAlleyFromClanMenu](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html#a6820ff2795ec41ee3184d7aec580447e) ([Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) alley) |
| bool | [IsHeroAlleyLeaderOfAnyPlayerAlley](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html#a623da90d6cebf51be8e472f46684a64f) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| List< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [GetAllAssignedClanMembersForOwnedAlleys](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html#a368684b8b74cc6a87f44a06a5d9ec947) () |
| void | [ChangeAlleyMember](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html#a958d41303cf79cf7c25fb256e61520c4) ([Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) alley, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newAlleyLead) |
| void | [OnPlayerRetreatedFromMission](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html#a9eab02ff8fe625d0edd1fc54943881dd) () |
| void | [OnPlayerDiedInMission](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html#ad3a3118ccd9cfc90a83373921081e2e6) () |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [GetAssignedClanMemberOfAlley](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html#a93bc7b7bab1e62ebe2eb963fb3fb25d2) ([Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) alley) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a053965730807cc40179cb1ee0495c376) (string stringId) |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab8914958880a708aaf68f676e6c29df1) () |
| void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a402e03be483527df560a46a7a01004a6) () |
| void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a5f2a833b5a67619021c6c437a1232877) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [alley\_related\_menu\_on\_init](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html#a61f7dd6fbc03c24373ea371bd86aacc5) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| Static Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| static T | [GetCampaignBehavior< T >](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#af9fd34472faff4ae39b627e8d3091b7e) () |

|  |  |
| --- | --- |
| Protected Member Functions | |
| void | [AddGameMenus](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html#afd97b09b27f059d48b4e8b91be830e41) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameSystemStarter) |
| void | [AddDialogs](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html#a50e1640493ffdb545137c150bc1ce35c) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameStarter) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| readonly string | [StringId](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab1c3b0a4161f58781148a9499be70fa3) |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html#a5714a57be07b73b9e0c24a682b57e2fc)RegisterEvents()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void SandBox.CampaignBehaviors.AlleyCampaignBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html#a9f80eef1f693449d25b6566e9a9384a0)SyncData()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void SandBox.CampaignBehaviors.AlleyCampaignBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html#a415004fafe5b43a7b73b58dd0d33c66e)OnSessionLaunched()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.CampaignBehaviors.AlleyCampaignBehavior.OnSessionLaunched | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *campaignGameStarter* | ) |  |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html#afd97b09b27f059d48b4e8b91be830e41)AddGameMenus()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void SandBox.CampaignBehaviors.AlleyCampaignBehavior.AddGameMenus | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *campaignGameSystemStarter* | ) |  | | protected |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html#a50e1640493ffdb545137c150bc1ce35c)AddDialogs()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void SandBox.CampaignBehaviors.AlleyCampaignBehavior.AddDialogs | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *campaignGameStarter* | ) |  | | protected |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html#a45d0faa813c5741a5604db896394b044)GetIsPlayerAlleyUnderAttack()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool SandBox.CampaignBehaviors.AlleyCampaignBehavior.GetIsPlayerAlleyUnderAttack | ( | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | *alley* | ) |  |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.IAlleyCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alley_campaign_behavior.html#aab9437903a349ba179dc450e1176ece6).

[◆](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html#aec8649fc75ea831585fb0c7b6627ede5)GetPlayerOwnedAlleyTroopCount()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int SandBox.CampaignBehaviors.AlleyCampaignBehavior.GetPlayerOwnedAlleyTroopCount | ( | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | *alley* | ) |  |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.IAlleyCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alley_campaign_behavior.html#a0dc7b520b02cf1229dab4055f40f6822).

[◆](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html#a2264baffa7b4545f6f61bc70086855d0)GetResponseTimeLeftForAttackInDays()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int SandBox.CampaignBehaviors.AlleyCampaignBehavior.GetResponseTimeLeftForAttackInDays | ( | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | *alley* | ) |  |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.IAlleyCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alley_campaign_behavior.html#a901d63e481d66969629e2e8c90d8fda1).

[◆](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html#a6820ff2795ec41ee3184d7aec580447e)AbandonAlleyFromClanMenu()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.CampaignBehaviors.AlleyCampaignBehavior.AbandonAlleyFromClanMenu | ( | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | *alley* | ) |  |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.IAlleyCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alley_campaign_behavior.html#a98e9a96f3fa87153e4140c075b5fd7fe).

[◆](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html#a623da90d6cebf51be8e472f46684a64f)IsHeroAlleyLeaderOfAnyPlayerAlley()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool SandBox.CampaignBehaviors.AlleyCampaignBehavior.IsHeroAlleyLeaderOfAnyPlayerAlley | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.IAlleyCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alley_campaign_behavior.html#aba79ffd17df2859d6da639ad8fae4423).

[◆](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html#a368684b8b74cc6a87f44a06a5d9ec947)GetAllAssignedClanMembersForOwnedAlleys()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| List< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > SandBox.CampaignBehaviors.AlleyCampaignBehavior.GetAllAssignedClanMembersForOwnedAlleys | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.IAlleyCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alley_campaign_behavior.html#adbf0a708635c32d7a7116aad33571855).

[◆](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html#a958d41303cf79cf7c25fb256e61520c4)ChangeAlleyMember()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.CampaignBehaviors.AlleyCampaignBehavior.ChangeAlleyMember | ( | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | *alley*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newAlleyLead* ) |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.IAlleyCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alley_campaign_behavior.html#a377a04eb3ccd9685ac1c95fbc53dee6a).

[◆](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html#a9eab02ff8fe625d0edd1fc54943881dd)OnPlayerRetreatedFromMission()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.CampaignBehaviors.AlleyCampaignBehavior.OnPlayerRetreatedFromMission | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.IAlleyCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alley_campaign_behavior.html#afb92ee5cded8580daa053273367d8415).

[◆](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html#ad3a3118ccd9cfc90a83373921081e2e6)OnPlayerDiedInMission()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.CampaignBehaviors.AlleyCampaignBehavior.OnPlayerDiedInMission | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.IAlleyCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alley_campaign_behavior.html#ad1ff959bd5ec5425ad8b6ccf8fddb9cd).

[◆](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html#a93bc7b7bab1e62ebe2eb963fb3fb25d2)GetAssignedClanMemberOfAlley()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) SandBox.CampaignBehaviors.AlleyCampaignBehavior.GetAssignedClanMemberOfAlley | ( | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | *alley* | ) |  |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.IAlleyCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alley_campaign_behavior.html#aa6b5718051e5cf66992063e4a0c00b82).

[◆](class_sand_box_1_1_campaign_behaviors_1_1_alley_campaign_behavior.html#a61f7dd6fbc03c24373ea371bd86aacc5)alley\_related\_menu\_on\_init()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void SandBox.CampaignBehaviors.AlleyCampaignBehavior.alley\_related\_menu\_on\_init | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  | | static |

