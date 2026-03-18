--- SOURCE: class_story_mode_1_1_game_components_1_1_campaign_behaviors_1_1_story_mode_tutorial_box_campaign_behavior.html ---

StoryMode.GameComponents.CampaignBehaviors.StoryModeTutorialBoxCampaignBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [StoryModeTutorialBoxCampaignBehavior](class_story_mode_1_1_game_components_1_1_campaign_behaviors_1_1_story_mode_tutorial_box_campaign_behavior.html#abae78e4d7a6b424127f6cf2d4a86f5b5) () |
| override void | [RegisterEvents](class_story_mode_1_1_game_components_1_1_campaign_behaviors_1_1_story_mode_tutorial_box_campaign_behavior.html#a8538e85c18e2883b2c5c5bcdbf103d85) () |
| override void | [SyncData](class_story_mode_1_1_game_components_1_1_campaign_behaviors_1_1_story_mode_tutorial_box_campaign_behavior.html#a1a62aa2f01f51432bf249c7db847d64f) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| void | [OnResetAllTutorials](class_story_mode_1_1_game_components_1_1_campaign_behaviors_1_1_story_mode_tutorial_box_campaign_behavior.html#a3c3c674c98b597a978be3749c4fedd39) ([ResetAllTutorialsEvent](class_tale_worlds_1_1_core_1_1_reset_all_tutorials_event.html) obj) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a053965730807cc40179cb1ee0495c376) (string stringId) |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab8914958880a708aaf68f676e6c29df1) () |
| void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a402e03be483527df560a46a7a01004a6) () |
| void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a5f2a833b5a67619021c6c437a1232877) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |

|  |  |
| --- | --- |
| Properties | |
| MBReadOnlyList< [CampaignTutorial](class_tale_worlds_1_1_campaign_system_1_1_campaign_tutorial.html) > | [AvailableTutorials](class_story_mode_1_1_game_components_1_1_campaign_behaviors_1_1_story_mode_tutorial_box_campaign_behavior.html#a05d2607665d1697a4a9a6b98e4579b56) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| static T | [GetCampaignBehavior< T >](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#af9fd34472faff4ae39b627e8d3091b7e) () |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| readonly string | [StringId](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab1c3b0a4161f58781148a9499be70fa3) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_story_mode_1_1_game_components_1_1_campaign_behaviors_1_1_story_mode_tutorial_box_campaign_behavior.html#abae78e4d7a6b424127f6cf2d4a86f5b5)StoryModeTutorialBoxCampaignBehavior()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| StoryMode.GameComponents.CampaignBehaviors.StoryModeTutorialBoxCampaignBehavior.StoryModeTutorialBoxCampaignBehavior | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_story_mode_1_1_game_components_1_1_campaign_behaviors_1_1_story_mode_tutorial_box_campaign_behavior.html#a8538e85c18e2883b2c5c5bcdbf103d85)RegisterEvents()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void StoryMode.GameComponents.CampaignBehaviors.StoryModeTutorialBoxCampaignBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_story_mode_1_1_game_components_1_1_campaign_behaviors_1_1_story_mode_tutorial_box_campaign_behavior.html#a1a62aa2f01f51432bf249c7db847d64f)SyncData()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void StoryMode.GameComponents.CampaignBehaviors.StoryModeTutorialBoxCampaignBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

[◆](class_story_mode_1_1_game_components_1_1_campaign_behaviors_1_1_story_mode_tutorial_box_campaign_behavior.html#a3c3c674c98b597a978be3749c4fedd39)OnResetAllTutorials()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void StoryMode.GameComponents.CampaignBehaviors.StoryModeTutorialBoxCampaignBehavior.OnResetAllTutorials | ( | [ResetAllTutorialsEvent](class_tale_worlds_1_1_core_1_1_reset_all_tutorials_event.html) | *obj* | ) |  |

Property Documentation
----------------------

[◆](class_story_mode_1_1_game_components_1_1_campaign_behaviors_1_1_story_mode_tutorial_box_campaign_behavior.html#a05d2607665d1697a4a9a6b98e4579b56)AvailableTutorials
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[CampaignTutorial](class_tale_worlds_1_1_campaign_system_1_1_campaign_tutorial.html)> StoryMode.GameComponents.CampaignBehaviors.StoryModeTutorialBoxCampaignBehavior.AvailableTutorials | | get |

