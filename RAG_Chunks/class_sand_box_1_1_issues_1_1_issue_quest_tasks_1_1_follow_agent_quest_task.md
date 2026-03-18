--- SOURCE: class_sand_box_1_1_issues_1_1_issue_quest_tasks_1_1_follow_agent_quest_task.html ---

SandBox.Issues.IssueQuestTasks.FollowAgentQuestTask Class ReferenceInherits [TaleWorlds.CampaignSystem.QuestTaskBase](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [FollowAgentQuestTask](class_sand_box_1_1_issues_1_1_issue_quest_tasks_1_1_follow_agent_quest_task.html#ad6eac97f0cd67c82449e6d164c71505c) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) followedAgent, [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) targetEntity, Action onSucceededAction, Action onCanceledAction, [DialogFlow](class_tale_worlds_1_1_campaign_system_1_1_dialog_flow.html) dialogFlow=null) |
|  | [FollowAgentQuestTask](class_sand_box_1_1_issues_1_1_issue_quest_tasks_1_1_follow_agent_quest_task.html#a1d18ff19484b43f2f01e640e8aa57d1d) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) followedAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) targetAgent, Action onSucceededAction, Action onCanceledAction, [DialogFlow](class_tale_worlds_1_1_campaign_system_1_1_dialog_flow.html) dialogFlow=null) |
| void | [MissionTick](class_sand_box_1_1_issues_1_1_issue_quest_tasks_1_1_follow_agent_quest_task.html#af1c87547b74588e66d71431d91f2ce80) (float dt) |
| override void | [SetReferences](class_sand_box_1_1_issues_1_1_issue_quest_tasks_1_1_follow_agent_quest_task.html#a4c448affaaf962c04cf84b7e375b9282) () |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.QuestTaskBase](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html) | |
|  | [QuestTaskBase](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#ae8cf0e422a44996b71259afcd58de8c7) ([DialogFlow](class_tale_worlds_1_1_campaign_system_1_1_dialog_flow.html) dialogFlow=null, Action onSucceedAction=null, Action onFailedAction=null, Action onCanceledAction=null) |
| void | [Finish](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a5af50c8bc9108796d8d4746cbbcc1ed3) ([FinishStates](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a13482b3e54ed4be480f6a5ae787c06f1) finishState) |
| void | [AddTaskDialogs](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a1c650b1a6dc42d2d6d1ecbdb2706b30c) () |
| void | [AddTaskDialogOnGameLoaded](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a45bb993f36434cb1541a00584824b170) ([DialogFlow](class_tale_worlds_1_1_campaign_system_1_1_dialog_flow.html) dialogFlow) |
| void | [AddTaskBehaviorsOnGameLoad](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a806fffbd9531f563aff41c96f4840be1) (Action onSucceededAction=null, Action onFailedAction=null, Action onCanceledAction=null) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnFinished](class_sand_box_1_1_issues_1_1_issue_quest_tasks_1_1_follow_agent_quest_task.html#aa562b67752fd70ae98af86834c7ff73f) () |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Types inherited from [TaleWorlds.CampaignSystem.QuestTaskBase](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html) | |
| enum | [FinishStates](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a13482b3e54ed4be480f6a5ae787c06f1) {     [Success](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a13482b3e54ed4be480f6a5ae787c06f1a505a83f220c02df2f85c3810cd9ceb38) ,     [Fail](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a13482b3e54ed4be480f6a5ae787c06f1aceaa0734f0b3c738120c67344d8f3ec1) ,     [Cancel](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a13482b3e54ed4be480f6a5ae787c06f1aea4788705e6873b424c65e91c2846b19)   } |
| Protected Attributes inherited from [TaleWorlds.CampaignSystem.QuestTaskBase](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html) | |
| Dictionary< [EventDelegateType](namespace_tale_worlds_1_1_campaign_system.html#ac1e263aa12f4a694770e2b8ede75d8aa), [TriggerDelegateType](namespace_tale_worlds_1_1_campaign_system.html#ab1d5216affb18132ca2bbfd4d2c596bc) > | [EvenTriggerDelegates](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a4cefa4bbf5714c6c1f6114be1bba196c) |
| Properties inherited from [TaleWorlds.CampaignSystem.QuestTaskBase](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html) | |
| bool | [IsLogged](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a5ce96561557c263cf0cf495ca5677032) `[get, set]` |
| bool | [IsActive](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#ad5adacce7b8898a0623267896f92ada1) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_issues_1_1_issue_quest_tasks_1_1_follow_agent_quest_task.html#ad6eac97f0cd67c82449e6d164c71505c)FollowAgentQuestTask() [1/2]
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| SandBox.Issues.IssueQuestTasks.FollowAgentQuestTask.FollowAgentQuestTask | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *followedAgent*, |
|  |  | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *targetEntity*, |
|  |  | Action | *onSucceededAction*, |
|  |  | Action | *onCanceledAction*, |
|  |  | [DialogFlow](class_tale_worlds_1_1_campaign_system_1_1_dialog_flow.html) | *dialogFlow* = null ) |

[◆](class_sand_box_1_1_issues_1_1_issue_quest_tasks_1_1_follow_agent_quest_task.html#a1d18ff19484b43f2f01e640e8aa57d1d)FollowAgentQuestTask() [2/2]
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| SandBox.Issues.IssueQuestTasks.FollowAgentQuestTask.FollowAgentQuestTask | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *followedAgent*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *targetAgent*, |
|  |  | Action | *onSucceededAction*, |
|  |  | Action | *onCanceledAction*, |
|  |  | [DialogFlow](class_tale_worlds_1_1_campaign_system_1_1_dialog_flow.html) | *dialogFlow* = null ) |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_issues_1_1_issue_quest_tasks_1_1_follow_agent_quest_task.html#af1c87547b74588e66d71431d91f2ce80)MissionTick()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.Issues.IssueQuestTasks.FollowAgentQuestTask.MissionTick | ( | float | *dt* | ) |  |

[◆](class_sand_box_1_1_issues_1_1_issue_quest_tasks_1_1_follow_agent_quest_task.html#aa562b67752fd70ae98af86834c7ff73f)OnFinished()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.Issues.IssueQuestTasks.FollowAgentQuestTask.OnFinished | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.QuestTaskBase](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a162d415583eb3158fac1676e72496c5c).

[◆](class_sand_box_1_1_issues_1_1_issue_quest_tasks_1_1_follow_agent_quest_task.html#a4c448affaaf962c04cf84b7e375b9282)SetReferences()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.Issues.IssueQuestTasks.FollowAgentQuestTask.SetReferences | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.QuestTaskBase](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#ace6b77069641ba881a808214b987088f).

