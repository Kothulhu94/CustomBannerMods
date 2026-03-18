--- SOURCE: class_sand_box_1_1_campaign_behaviors_1_1_clan_member_roles_campaign_behavior.html ---

SandBox.CampaignBehaviors.ClanMemberRolesCampaignBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html), and [SandBox.GameComponents.IMissionPlayerFollowerHandler](interface_sand_box_1_1_game_components_1_1_i_mission_player_follower_handler.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [RegisterEvents](class_sand_box_1_1_campaign_behaviors_1_1_clan_member_roles_campaign_behavior.html#a140ed72f46ffe454b6f9617146d40614) () |
| override void | [SyncData](class_sand_box_1_1_campaign_behaviors_1_1_clan_member_roles_campaign_behavior.html#a50efba6898e470ca31e712f82e4eb5de) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| bool | [IsFollowingPlayer](class_sand_box_1_1_campaign_behaviors_1_1_clan_member_roles_campaign_behavior.html#a5b78e6ce8f719ce967862abadcfd9c32) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| void | [RemoveFollowingHero](class_sand_box_1_1_campaign_behaviors_1_1_clan_member_roles_campaign_behavior.html#ae21780013f11ccb55d80eeef2ebe2c13) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
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

[◆](class_sand_box_1_1_campaign_behaviors_1_1_clan_member_roles_campaign_behavior.html#a140ed72f46ffe454b6f9617146d40614)RegisterEvents()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void SandBox.CampaignBehaviors.ClanMemberRolesCampaignBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_sand_box_1_1_campaign_behaviors_1_1_clan_member_roles_campaign_behavior.html#a50efba6898e470ca31e712f82e4eb5de)SyncData()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void SandBox.CampaignBehaviors.ClanMemberRolesCampaignBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_clan_member_roles_campaign_behavior.html#a5b78e6ce8f719ce967862abadcfd9c32)IsFollowingPlayer()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool SandBox.CampaignBehaviors.ClanMemberRolesCampaignBehavior.IsFollowingPlayer | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_clan_member_roles_campaign_behavior.html#ae21780013f11ccb55d80eeef2ebe2c13)RemoveFollowingHero()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.CampaignBehaviors.ClanMemberRolesCampaignBehavior.RemoveFollowingHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

Implements [SandBox.GameComponents.IMissionPlayerFollowerHandler](interface_sand_box_1_1_game_components_1_1_i_mission_player_follower_handler.html#a1a17f7fd4636f47f256af70d3010e7c7).

