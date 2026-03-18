--- SOURCE: class_story_mode_1_1_quests_1_1_quest_tasks_1_1_recruit_troop_tutorial_quest_task.html ---

StoryMode.Quests.QuestTasks.RecruitTroopTutorialQuestTask Class ReferenceInherits [TaleWorlds.CampaignSystem.QuestTaskBase](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [RecruitTroopTutorialQuestTask](class_story_mode_1_1_quests_1_1_quest_tasks_1_1_recruit_troop_tutorial_quest_task.html#ab8e707843356ea0e6bf279008846961c) (Action onSucceed, int targetRecruitAmount, Func< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), bool > recruitTypeConditions, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) recruitSettlement=null, [JournalLog](class_tale_worlds_1_1_campaign_system_1_1_journal_log.html) progressLog=null) |
| void | [InitializeTaskOnLoad](class_story_mode_1_1_quests_1_1_quest_tasks_1_1_recruit_troop_tutorial_quest_task.html#a949cbd68470fc4f0d7512692d2024947) (int targetRecruitAmount, Func< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), bool > recruitTypeConditions, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) recruitSettlement=null) |
| override void | [SetReferences](class_story_mode_1_1_quests_1_1_quest_tasks_1_1_recruit_troop_tutorial_quest_task.html#adbdb85ea4a218f276b8afacde2da76a7) () |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.QuestTaskBase](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html) | |
|  | [QuestTaskBase](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#ae8cf0e422a44996b71259afcd58de8c7) ([DialogFlow](class_tale_worlds_1_1_campaign_system_1_1_dialog_flow.html) dialogFlow=null, Action onSucceedAction=null, Action onFailedAction=null, Action onCanceledAction=null) |
| void | [Finish](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a5af50c8bc9108796d8d4746cbbcc1ed3) ([FinishStates](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a13482b3e54ed4be480f6a5ae787c06f1) finishState) |
| void | [AddTaskDialogs](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a1c650b1a6dc42d2d6d1ecbdb2706b30c) () |
| void | [AddTaskDialogOnGameLoaded](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a45bb993f36434cb1541a00584824b170) ([DialogFlow](class_tale_worlds_1_1_campaign_system_1_1_dialog_flow.html) dialogFlow) |
| void | [AddTaskBehaviorsOnGameLoad](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a806fffbd9531f563aff41c96f4840be1) (Action onSucceededAction=null, Action onFailedAction=null, Action onCanceledAction=null) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Types inherited from [TaleWorlds.CampaignSystem.QuestTaskBase](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html) | |
| enum | [FinishStates](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a13482b3e54ed4be480f6a5ae787c06f1) {     [Success](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a13482b3e54ed4be480f6a5ae787c06f1a505a83f220c02df2f85c3810cd9ceb38) ,     [Fail](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a13482b3e54ed4be480f6a5ae787c06f1aceaa0734f0b3c738120c67344d8f3ec1) ,     [Cancel](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a13482b3e54ed4be480f6a5ae787c06f1aea4788705e6873b424c65e91c2846b19)   } |
| Protected Member Functions inherited from [TaleWorlds.CampaignSystem.QuestTaskBase](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html) | |
| virtual void | [OnFinished](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a162d415583eb3158fac1676e72496c5c) () |
| Protected Attributes inherited from [TaleWorlds.CampaignSystem.QuestTaskBase](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html) | |
| Dictionary< [EventDelegateType](namespace_tale_worlds_1_1_campaign_system.html#ac1e263aa12f4a694770e2b8ede75d8aa), [TriggerDelegateType](namespace_tale_worlds_1_1_campaign_system.html#ab1d5216affb18132ca2bbfd4d2c596bc) > | [EvenTriggerDelegates](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a4cefa4bbf5714c6c1f6114be1bba196c) |
| Properties inherited from [TaleWorlds.CampaignSystem.QuestTaskBase](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html) | |
| bool | [IsLogged](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#a5ce96561557c263cf0cf495ca5677032) `[get, set]` |
| bool | [IsActive](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#ad5adacce7b8898a0623267896f92ada1) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_story_mode_1_1_quests_1_1_quest_tasks_1_1_recruit_troop_tutorial_quest_task.html#ab8e707843356ea0e6bf279008846961c)RecruitTroopTutorialQuestTask()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| StoryMode.Quests.QuestTasks.RecruitTroopTutorialQuestTask.RecruitTroopTutorialQuestTask | ( | Action | *onSucceed*, |
|  |  | int | *targetRecruitAmount*, |
|  |  | Func< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), bool > | *recruitTypeConditions*, |
|  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *recruitSettlement* = null, |
|  |  | [JournalLog](class_tale_worlds_1_1_campaign_system_1_1_journal_log.html) | *progressLog* = null ) |

Member Function Documentation
-----------------------------

[◆](class_story_mode_1_1_quests_1_1_quest_tasks_1_1_recruit_troop_tutorial_quest_task.html#a949cbd68470fc4f0d7512692d2024947)InitializeTaskOnLoad()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void StoryMode.Quests.QuestTasks.RecruitTroopTutorialQuestTask.InitializeTaskOnLoad | ( | int | *targetRecruitAmount*, |
|  |  | Func< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), bool > | *recruitTypeConditions*, |
|  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *recruitSettlement* = null ) |

[◆](class_story_mode_1_1_quests_1_1_quest_tasks_1_1_recruit_troop_tutorial_quest_task.html#adbdb85ea4a218f276b8afacde2da76a7)SetReferences()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void StoryMode.Quests.QuestTasks.RecruitTroopTutorialQuestTask.SetReferences | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.QuestTaskBase](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#ace6b77069641ba881a808214b987088f).

