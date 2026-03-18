--- SOURCE: class_story_mode_1_1_game_components_1_1_campaign_behaviors_1_1_achievements_campaign_behavior.html ---

StoryMode.GameComponents.CampaignBehaviors.AchievementsCampaignBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [SyncData](class_story_mode_1_1_game_components_1_1_campaign_behaviors_1_1_achievements_campaign_behavior.html#abb1a7f04170c26794bec2b6969913c2c) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| override void | [RegisterEvents](class_story_mode_1_1_game_components_1_1_campaign_behaviors_1_1_achievements_campaign_behavior.html#a08d46eac45200c7617a897efc847a724) () |
| bool | [CheckAchievementSystemActivity](class_story_mode_1_1_game_components_1_1_campaign_behaviors_1_1_achievements_campaign_behavior.html#a6df68081b8516dca6dc8b6cda70e9e8a) (out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) reason) |
| void | [OnRadagosDuelWon](class_story_mode_1_1_game_components_1_1_campaign_behaviors_1_1_achievements_campaign_behavior.html#a9caae9ae26ca375312caa968018da7ef) () |
| void | [DeactivateAchievements](class_story_mode_1_1_game_components_1_1_campaign_behaviors_1_1_achievements_campaign_behavior.html#afc3136098644ebc534f6d711755b2c55) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) reason=null, bool showMessage=true, bool temporarily=false) |
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

[◆](class_story_mode_1_1_game_components_1_1_campaign_behaviors_1_1_achievements_campaign_behavior.html#abb1a7f04170c26794bec2b6969913c2c)SyncData()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void StoryMode.GameComponents.CampaignBehaviors.AchievementsCampaignBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

[◆](class_story_mode_1_1_game_components_1_1_campaign_behaviors_1_1_achievements_campaign_behavior.html#a08d46eac45200c7617a897efc847a724)RegisterEvents()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void StoryMode.GameComponents.CampaignBehaviors.AchievementsCampaignBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_story_mode_1_1_game_components_1_1_campaign_behaviors_1_1_achievements_campaign_behavior.html#a6df68081b8516dca6dc8b6cda70e9e8a)CheckAchievementSystemActivity()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool StoryMode.GameComponents.CampaignBehaviors.AchievementsCampaignBehavior.CheckAchievementSystemActivity | ( | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *reason* | ) |  |

[◆](class_story_mode_1_1_game_components_1_1_campaign_behaviors_1_1_achievements_campaign_behavior.html#a9caae9ae26ca375312caa968018da7ef)OnRadagosDuelWon()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void StoryMode.GameComponents.CampaignBehaviors.AchievementsCampaignBehavior.OnRadagosDuelWon | ( |  | ) |  |

[◆](class_story_mode_1_1_game_components_1_1_campaign_behaviors_1_1_achievements_campaign_behavior.html#afc3136098644ebc534f6d711755b2c55)DeactivateAchievements()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void StoryMode.GameComponents.CampaignBehaviors.AchievementsCampaignBehavior.DeactivateAchievements | ( | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *reason* = null, |
|  |  | bool | *showMessage* = true, |
|  |  | bool | *temporarily* = false ) |

