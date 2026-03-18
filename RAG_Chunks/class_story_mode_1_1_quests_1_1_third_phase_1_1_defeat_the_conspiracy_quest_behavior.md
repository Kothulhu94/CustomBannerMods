--- SOURCE: class_story_mode_1_1_quests_1_1_third_phase_1_1_defeat_the_conspiracy_quest_behavior.html ---

StoryMode.Quests.ThirdPhase.DefeatTheConspiracyQuestBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html).

|  |  |
| --- | --- |
| Classes | |
| class | [DefeatTheConspiracyQuestBehaviorTypeDefiner](class_story_mode_1_1_quests_1_1_third_phase_1_1_defeat_the_conspiracy_quest_behavior_1_1_defeat_e3a9e1b31e1ec36f510d6c4658279c67.html) |
| class | [DefeatTheConspiracyQuest](class_story_mode_1_1_quests_1_1_third_phase_1_1_defeat_the_conspiracy_quest_behavior_1_1_defeat_the_conspiracy_quest.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
| bool | [IsMobilePartyCreatedForQuest](class_story_mode_1_1_quests_1_1_third_phase_1_1_defeat_the_conspiracy_quest_behavior.html#ae9be337e097af0d4d09514adf4f01fd2) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| override void | [RegisterEvents](class_story_mode_1_1_quests_1_1_third_phase_1_1_defeat_the_conspiracy_quest_behavior.html#ae067f12cdc91e4ceb6bfe367b3c1663c) () |
| override void | [SyncData](class_story_mode_1_1_quests_1_1_third_phase_1_1_defeat_the_conspiracy_quest_behavior.html#a15ed0ed92cdcfc92b83e20510f5a7e75) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a053965730807cc40179cb1ee0495c376) (string stringId) |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab8914958880a708aaf68f676e6c29df1) () |
| void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a402e03be483527df560a46a7a01004a6) () |
| void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a5f2a833b5a67619021c6c437a1232877) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const int | [TroopLimitPerNewClanParty](class_story_mode_1_1_quests_1_1_third_phase_1_1_defeat_the_conspiracy_quest_behavior.html#a7ce9a428438dd018c9c2cc51184a36eb) = 600 |

|  |  |
| --- | --- |
| Protected Member Functions | |
| void | [InitializeFinalPhase](class_story_mode_1_1_quests_1_1_third_phase_1_1_defeat_the_conspiracy_quest_behavior.html#af7550e9fbd09389a59b2d5a14cdc945d) () |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| static T | [GetCampaignBehavior< T >](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#af9fd34472faff4ae39b627e8d3091b7e) () |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| readonly string | [StringId](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab1c3b0a4161f58781148a9499be70fa3) |

Member Function Documentation
-----------------------------

[◆](class_story_mode_1_1_quests_1_1_third_phase_1_1_defeat_the_conspiracy_quest_behavior.html#ae9be337e097af0d4d09514adf4f01fd2)IsMobilePartyCreatedForQuest()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool StoryMode.Quests.ThirdPhase.DefeatTheConspiracyQuestBehavior.IsMobilePartyCreatedForQuest | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  |

[◆](class_story_mode_1_1_quests_1_1_third_phase_1_1_defeat_the_conspiracy_quest_behavior.html#ae067f12cdc91e4ceb6bfe367b3c1663c)RegisterEvents()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void StoryMode.Quests.ThirdPhase.DefeatTheConspiracyQuestBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_story_mode_1_1_quests_1_1_third_phase_1_1_defeat_the_conspiracy_quest_behavior.html#af7550e9fbd09389a59b2d5a14cdc945d)InitializeFinalPhase()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void StoryMode.Quests.ThirdPhase.DefeatTheConspiracyQuestBehavior.InitializeFinalPhase | ( |  | ) |  | | protected |

[◆](class_story_mode_1_1_quests_1_1_third_phase_1_1_defeat_the_conspiracy_quest_behavior.html#a15ed0ed92cdcfc92b83e20510f5a7e75)SyncData()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void StoryMode.Quests.ThirdPhase.DefeatTheConspiracyQuestBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

Member Data Documentation
-------------------------

[◆](class_story_mode_1_1_quests_1_1_third_phase_1_1_defeat_the_conspiracy_quest_behavior.html#a7ce9a428438dd018c9c2cc51184a36eb)TroopLimitPerNewClanParty
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int StoryMode.Quests.ThirdPhase.DefeatTheConspiracyQuestBehavior.TroopLimitPerNewClanParty = 600 | | static |

