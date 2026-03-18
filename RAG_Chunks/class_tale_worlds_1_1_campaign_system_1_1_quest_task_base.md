--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html ---

TaleWorlds.CampaignSystem.QuestTaskBase Class ReferenceInherited by [SandBox.Issues.IssueQuestTasks.ArenaDuelQuestTask](class_sand_box_1_1_issues_1_1_issue_quest_tasks_1_1_arena_duel_quest_task.html), [SandBox.Issues.IssueQuestTasks.BeginConversationInitiatedByAIQuestTask](class_sand_box_1_1_issues_1_1_issue_quest_tasks_1_1_begin_conversation_initiated_by_a_i_quest_task.html), [SandBox.Issues.IssueQuestTasks.FollowAgentQuestTask](class_sand_box_1_1_issues_1_1_issue_quest_tasks_1_1_follow_agent_quest_task.html), [StoryMode.Quests.QuestTasks.PurchaseItemTutorialQuestTask](class_story_mode_1_1_quests_1_1_quest_tasks_1_1_purchase_item_tutorial_quest_task.html), [StoryMode.Quests.QuestTasks.RecruitTroopTutorialQuestTask](class_story_mode_1_1_quests_1_1_quest_tasks_1_1_recruit_troop_tutorial_quest_task.html), [TaleWorlds.CampaignSystem.Issues.IssueQuestTasks.CaptureAndBringNpcTask](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_quest_tasks_1_1_capture_and_bring_npc_task.html), [TaleWorlds.CampaignSystem.Issues.IssueQuestTasks.ChangeCommonAreaOwnerQuestTask](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_quest_tasks_1_1_change_common_area_owner_quest_task.html), [TaleWorlds.CampaignSystem.Issues.IssueQuestTasks.ChangeSettlementOwnerTask](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_quest_tasks_1_1_change_settlement_owner_task.html), [TaleWorlds.CampaignSystem.Issues.IssueQuestTasks.DefeatPartyQuestTask](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_quest_tasks_1_1_defeat_party_quest_task.html), [TaleWorlds.CampaignSystem.Issues.IssueQuestTasks.RaidVillageQuestTask](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_quest_tasks_1_1_raid_village_quest_task.html), and [TaleWorlds.CampaignSystem.Issues.IssueQuestTasks.TalkToNpcQuestTask](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_quest_tasks_1_1_talk_to_npc_quest_task.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [FinishStates](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a13482b3e54ed4be480f6a5ae787c06f1) {     [Success](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a13482b3e54ed4be480f6a5ae787c06f1a505a83f220c02df2f85c3810cd9ceb38) ,     [Fail](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a13482b3e54ed4be480f6a5ae787c06f1aceaa0734f0b3c738120c67344d8f3ec1) ,     [Cancel](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a13482b3e54ed4be480f6a5ae787c06f1aea4788705e6873b424c65e91c2846b19)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [QuestTaskBase](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#ae8cf0e422a44996b71259afcd58de8c7) ([DialogFlow](class_tale_worlds_1_1_campaign_system_1_1_dialog_flow.html) dialogFlow=null, Action onSucceedAction=null, Action onFailedAction=null, Action onCanceledAction=null) |
| void | [Finish](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a5af50c8bc9108796d8d4746cbbcc1ed3) ([FinishStates](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a13482b3e54ed4be480f6a5ae787c06f1) finishState) |
| void | [AddTaskDialogs](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a1c650b1a6dc42d2d6d1ecbdb2706b30c) () |
| virtual void | [SetReferences](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#ace6b77069641ba881a808214b987088f) () |
| void | [AddTaskDialogOnGameLoaded](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a45bb993f36434cb1541a00584824b170) ([DialogFlow](class_tale_worlds_1_1_campaign_system_1_1_dialog_flow.html) dialogFlow) |
| void | [AddTaskBehaviorsOnGameLoad](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a806fffbd9531f563aff41c96f4840be1) (Action onSucceededAction=null, Action onFailedAction=null, Action onCanceledAction=null) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| virtual void | [OnFinished](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a162d415583eb3158fac1676e72496c5c) () |

|  |  |
| --- | --- |
| Protected Attributes | |
| Dictionary< [EventDelegateType](namespace_tale_worlds_1_1_campaign_system.html#ac1e263aa12f4a694770e2b8ede75d8aa), [TriggerDelegateType](namespace_tale_worlds_1_1_campaign_system.html#ab1d5216affb18132ca2bbfd4d2c596bc) > | [EvenTriggerDelegates](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a4cefa4bbf5714c6c1f6114be1bba196c) |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsLogged](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a5ce96561557c263cf0cf495ca5677032) `[get, set]` |
| bool | [IsActive](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#ad5adacce7b8898a0623267896f92ada1) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a13482b3e54ed4be480f6a5ae787c06f1)FinishStates
-----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.QuestTaskBase.FinishStates](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a13482b3e54ed4be480f6a5ae787c06f1) |

| Enumerator | |
| --- | --- |
| Success |  |
| Fail |  |
| Cancel |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#ae8cf0e422a44996b71259afcd58de8c7)QuestTaskBase()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.QuestTaskBase.QuestTaskBase | ( | [DialogFlow](class_tale_worlds_1_1_campaign_system_1_1_dialog_flow.html) | *dialogFlow* = null, |
|  |  | Action | *onSucceedAction* = null, |
|  |  | Action | *onFailedAction* = null, |
|  |  | Action | *onCanceledAction* = null ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a5af50c8bc9108796d8d4746cbbcc1ed3)Finish()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.QuestTaskBase.Finish | ( | [FinishStates](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a13482b3e54ed4be480f6a5ae787c06f1) | *finishState* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a1c650b1a6dc42d2d6d1ecbdb2706b30c)AddTaskDialogs()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.QuestTaskBase.AddTaskDialogs | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a162d415583eb3158fac1676e72496c5c)OnFinished()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.QuestTaskBase.OnFinished | ( |  | ) |  | | protectedvirtual |

Reimplemented in [SandBox.Issues.IssueQuestTasks.BeginConversationInitiatedByAIQuestTask](class_sand_box_1_1_issues_1_1_issue_quest_tasks_1_1_begin_conversation_initiated_by_a_i_quest_task.html#a9d47c04ab880cbbfc213cac93f3ccf3b), [SandBox.Issues.IssueQuestTasks.FollowAgentQuestTask](class_sand_box_1_1_issues_1_1_issue_quest_tasks_1_1_follow_agent_quest_task.html#aa562b67752fd70ae98af86834c7ff73f), [TaleWorlds.CampaignSystem.Issues.IssueQuestTasks.CaptureAndBringNpcTask](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_quest_tasks_1_1_capture_and_bring_npc_task.html#a0106dde479968e08d4632a1078508217), [TaleWorlds.CampaignSystem.Issues.IssueQuestTasks.DefeatPartyQuestTask](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_quest_tasks_1_1_defeat_party_quest_task.html#a4f9c5134ca393096322f3dc3a329307f), and [TaleWorlds.CampaignSystem.Issues.IssueQuestTasks.TalkToNpcQuestTask](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_quest_tasks_1_1_talk_to_npc_quest_task.html#a00cc9ca7047449d708a2014630d52bdd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#ace6b77069641ba881a808214b987088f)SetReferences()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.QuestTaskBase.SetReferences | ( |  | ) |  | | virtual |

Reimplemented in [SandBox.Issues.IssueQuestTasks.ArenaDuelQuestTask](class_sand_box_1_1_issues_1_1_issue_quest_tasks_1_1_arena_duel_quest_task.html#a99e7db4f8f484ebaea3f80e7a3dcc410), [SandBox.Issues.IssueQuestTasks.BeginConversationInitiatedByAIQuestTask](class_sand_box_1_1_issues_1_1_issue_quest_tasks_1_1_begin_conversation_initiated_by_a_i_quest_task.html#a5e82f3fe10da2a8502ce7f18388d21b8), [SandBox.Issues.IssueQuestTasks.FollowAgentQuestTask](class_sand_box_1_1_issues_1_1_issue_quest_tasks_1_1_follow_agent_quest_task.html#a4c448affaaf962c04cf84b7e375b9282), [StoryMode.Quests.QuestTasks.PurchaseItemTutorialQuestTask](class_story_mode_1_1_quests_1_1_quest_tasks_1_1_purchase_item_tutorial_quest_task.html#a506c0e7950375895e812191b774a4400), [StoryMode.Quests.QuestTasks.RecruitTroopTutorialQuestTask](class_story_mode_1_1_quests_1_1_quest_tasks_1_1_recruit_troop_tutorial_quest_task.html#adbdb85ea4a218f276b8afacde2da76a7), [TaleWorlds.CampaignSystem.Issues.IssueQuestTasks.CaptureAndBringNpcTask](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_quest_tasks_1_1_capture_and_bring_npc_task.html#a29fd7af3c56434ece7113d5ca993b18a), [TaleWorlds.CampaignSystem.Issues.IssueQuestTasks.ChangeCommonAreaOwnerQuestTask](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_quest_tasks_1_1_change_common_area_owner_quest_task.html#a39016ac8c3892a87378ad2da239932f4), [TaleWorlds.CampaignSystem.Issues.IssueQuestTasks.ChangeSettlementOwnerTask](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_quest_tasks_1_1_change_settlement_owner_task.html#a64aab68cd5ecf5edf5a05b065b44405b), [TaleWorlds.CampaignSystem.Issues.IssueQuestTasks.DefeatPartyQuestTask](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_quest_tasks_1_1_defeat_party_quest_task.html#a2f207d675164ac2e79b98f5adfc85dbe), [TaleWorlds.CampaignSystem.Issues.IssueQuestTasks.RaidVillageQuestTask](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_quest_tasks_1_1_raid_village_quest_task.html#a8b2445e8ff21a7d62a8bd198ab2d70ab), and [TaleWorlds.CampaignSystem.Issues.IssueQuestTasks.TalkToNpcQuestTask](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_quest_tasks_1_1_talk_to_npc_quest_task.html#a1ab11f8e012c1718f010bd72240cb0d3).

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a45bb993f36434cb1541a00584824b170)AddTaskDialogOnGameLoaded()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.QuestTaskBase.AddTaskDialogOnGameLoaded | ( | [DialogFlow](class_tale_worlds_1_1_campaign_system_1_1_dialog_flow.html) | *dialogFlow* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a806fffbd9531f563aff41c96f4840be1)AddTaskBehaviorsOnGameLoad()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.QuestTaskBase.AddTaskBehaviorsOnGameLoad | ( | Action | *onSucceededAction* = null, |
|  |  | Action | *onFailedAction* = null, |
|  |  | Action | *onCanceledAction* = null ) |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a4cefa4bbf5714c6c1f6114be1bba196c)EvenTriggerDelegates
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Dictionary<[EventDelegateType](namespace_tale_worlds_1_1_campaign_system.html#ac1e263aa12f4a694770e2b8ede75d8aa), [TriggerDelegateType](namespace_tale_worlds_1_1_campaign_system.html#ab1d5216affb18132ca2bbfd4d2c596bc)> TaleWorlds.CampaignSystem.QuestTaskBase.EvenTriggerDelegates | | protected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a5ce96561557c263cf0cf495ca5677032)IsLogged
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.QuestTaskBase.IsLogged | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#ad5adacce7b8898a0623267896f92ada1)IsActive
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.QuestTaskBase.IsActive | | get |

