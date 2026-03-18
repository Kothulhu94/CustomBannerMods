--- SOURCE: class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_interrupting_behavior_group.html ---

SandBox.Missions.AgentBehaviors.InterruptingBehaviorGroup Class ReferenceInherits [SandBox.Missions.AgentBehaviors.AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [InterruptingBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_interrupting_behavior_group.html#aba45164ca23062e474951cebf0295d37) ([AgentNavigator](class_sand_box_1_1_agent_navigator.html) navigator, [Mission](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a44884a9d081bdab8c3413c579b8b0da5) mission) |
| override void | [Tick](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_interrupting_behavior_group.html#a2ea8e029f453b7a45274b655bb4f6a20) (float dt, bool isSimulation) |
| override float | [GetScore](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_interrupting_behavior_group.html#a5b8579856a5104cdef57abf2a084147b) (bool isSimulation) |
| override void | [ForceThink](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_interrupting_behavior_group.html#a021e9a5becb9fcb13a4b41d7ad745488) (float inSeconds) |
| Public Member Functions inherited from [SandBox.Missions.AgentBehaviors.AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html) | |
| T | [AddBehavior< T >](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a39e9d0417242dbda9a888e70aab61f77) () |
| T | [GetBehavior< T >](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a582fb5408cd87c05f9213df710b8892e) () |
| bool | [HasBehavior< T >](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#abb258dc00c633f3d09774f3165fd9642) () |
| void | [RemoveBehavior< T >](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#af8fcea62838e89c1baa1dc7f4e9e08ee) () |
| void | [SetScriptedBehavior< T >](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a6f0190a0ae9a14b6a5971fdd8cd5c097) () |
| void | [DisableScriptedBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a4843fa9415c1a955f0e6d686e6aaacbb) () |
| void | [DisableAllBehaviors](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#ad5a5ddc146cc1e56b1210890c5e9816c) () |
| [AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html) | [GetActiveBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a212cd80a0081cd35bf4d48b988eb2605) () |
| virtual void | [ConversationTick](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a2b034c8bf2bb16bfe82c9b7260411ff7) () |
| virtual void | [OnAgentRemoved](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#ae83cb68cdacaaa6f701c6ac47012afa0) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Attributes inherited from [SandBox.Missions.AgentBehaviors.AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html) | |
| [AgentNavigator](class_sand_box_1_1_agent_navigator.html) | [Navigator](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a246bea1189ff3ab22077e209ca8b5df8) |
| List< [AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html) > | [Behaviors](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a19c465b7589adfb2763cd18a04fa36cd) |
| Protected Member Functions inherited from [SandBox.Missions.AgentBehaviors.AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html) | |
|  | [AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a32df764d335fbc961b8e17b7197e9ac4) ([AgentNavigator](class_sand_box_1_1_agent_navigator.html) navigator, [Mission](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a44884a9d081bdab8c3413c579b8b0da5) mission) |
| virtual void | [OnActivate](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a778f19cd14a6f98f1311ec353f0f19df) () |
| virtual void | [OnDeactivate](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#ab5efe10c6df868897fc4d162d1912786) () |
| Protected Attributes inherited from [SandBox.Missions.AgentBehaviors.AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html) | |
| float | [CheckBehaviorTime](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a295ec363790e3acc9fe43d8039903c1c) = 5.0f |
| [Timer](class_tale_worlds_1_1_core_1_1_timer.html) | [CheckBehaviorTimer](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a604598a8f19e4ad78ae0d9ef1c516718) |
| Properties inherited from [SandBox.Missions.AgentBehaviors.AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html) | |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [OwnerAgent](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a5bc980731dc0635f2cd7cebcedd98f31) `[get]` |
| [AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html) | [ScriptedBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#ae74d8790a3ef1516c961a72d8bcb3f26) `[get]` |
| bool | [IsActive](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a4fcb577d6dcf949af86b1f0be28b0586) `[get, set]` |
| Mission | [Mission](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a44884a9d081bdab8c3413c579b8b0da5) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_interrupting_behavior_group.html#aba45164ca23062e474951cebf0295d37)InterruptingBehaviorGroup()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| SandBox.Missions.AgentBehaviors.InterruptingBehaviorGroup.InterruptingBehaviorGroup | ( | [AgentNavigator](class_sand_box_1_1_agent_navigator.html) | *navigator*, |
|  |  | [Mission](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a44884a9d081bdab8c3413c579b8b0da5) | *mission* ) |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_interrupting_behavior_group.html#a2ea8e029f453b7a45274b655bb4f6a20)Tick()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void SandBox.Missions.AgentBehaviors.InterruptingBehaviorGroup.Tick | ( | float | *dt*, | |  |  | bool | *isSimulation* ) | | virtual |

Reimplemented from [SandBox.Missions.AgentBehaviors.AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#ab6bdbd16818c340582179e430bbccf53).

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_interrupting_behavior_group.html#a5b8579856a5104cdef57abf2a084147b)GetScore()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override float SandBox.Missions.AgentBehaviors.InterruptingBehaviorGroup.GetScore | ( | bool | *isSimulation* | ) |  | | virtual |

Reimplemented from [SandBox.Missions.AgentBehaviors.AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a50df7719e7f5b081c6a15b9ae386c668).

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_interrupting_behavior_group.html#a021e9a5becb9fcb13a4b41d7ad745488)ForceThink()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.Missions.AgentBehaviors.InterruptingBehaviorGroup.ForceThink | ( | float | *inSeconds* | ) |  | | virtual |

Reimplemented from [SandBox.Missions.AgentBehaviors.AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#afdcde11796441e4306e3695877cc5294).

