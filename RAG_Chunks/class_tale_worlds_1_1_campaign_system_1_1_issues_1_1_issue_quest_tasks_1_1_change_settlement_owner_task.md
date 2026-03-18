--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_quest_tasks_1_1_change_settlement_owner_task.html ---

TaleWorlds.CampaignSystem.Issues.IssueQuestTasks.ChangeSettlementOwnerTask Class ReferenceInherits [TaleWorlds.CampaignSystem.QuestTaskBase](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ChangeSettlementOwnerTask](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_quest_tasks_1_1_change_settlement_owner_task.html#ae1ed5a14caf7e3a1cdc5cb838409a031) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newOwner, Action onSucceededAction, Action onFailedAction, Action onCanceledAction, [DialogFlow](class_tale_worlds_1_1_campaign_system_1_1_dialog_flow.html) dialogFlow=null) |
| void | [OnSettlementOwnerChanged](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_quest_tasks_1_1_change_settlement_owner_task.html#a9a6a437f898a97a2c8c3911409cd675a) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, bool openToClaim, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newOwner, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) oldOwner, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) capturerHero, ChangeOwnerOfSettlementAction.ChangeOwnerOfSettlementDetail detail) |
| override void | [SetReferences](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_quest_tasks_1_1_change_settlement_owner_task.html#a64aab68cd5ecf5edf5a05b065b44405b) () |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_quest_tasks_1_1_change_settlement_owner_task.html#ae1ed5a14caf7e3a1cdc5cb838409a031)ChangeSettlementOwnerTask()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Issues.IssueQuestTasks.ChangeSettlementOwnerTask.ChangeSettlementOwnerTask | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newOwner*, |
|  |  | Action | *onSucceededAction*, |
|  |  | Action | *onFailedAction*, |
|  |  | Action | *onCanceledAction*, |
|  |  | [DialogFlow](class_tale_worlds_1_1_campaign_system_1_1_dialog_flow.html) | *dialogFlow* = null ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_quest_tasks_1_1_change_settlement_owner_task.html#a9a6a437f898a97a2c8c3911409cd675a)OnSettlementOwnerChanged()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Issues.IssueQuestTasks.ChangeSettlementOwnerTask.OnSettlementOwnerChanged | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | bool | *openToClaim*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newOwner*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *oldOwner*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *capturerHero*, |
|  |  | ChangeOwnerOfSettlementAction.ChangeOwnerOfSettlementDetail | *detail* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_quest_tasks_1_1_change_settlement_owner_task.html#a64aab68cd5ecf5edf5a05b065b44405b)SetReferences()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Issues.IssueQuestTasks.ChangeSettlementOwnerTask.SetReferences | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.QuestTaskBase](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html#ace6b77069641ba881a808214b987088f).

