--- SOURCE: class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html ---

SandBox.Missions.AgentBehaviors.AgentBehaviorGroup Class ReferenceabstractInherited by [SandBox.Missions.AgentBehaviors.AlarmedBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html), [SandBox.Missions.AgentBehaviors.DailyBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_daily_behavior_group.html), and [SandBox.Missions.AgentBehaviors.InterruptingBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_interrupting_behavior_group.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| T | [AddBehavior< T >](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a39e9d0417242dbda9a888e70aab61f77) () |
| T | [GetBehavior< T >](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a582fb5408cd87c05f9213df710b8892e) () |
| bool | [HasBehavior< T >](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#abb258dc00c633f3d09774f3165fd9642) () |
| void | [RemoveBehavior< T >](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#af8fcea62838e89c1baa1dc7f4e9e08ee) () |
| void | [SetScriptedBehavior< T >](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a6f0190a0ae9a14b6a5971fdd8cd5c097) () |
| void | [DisableScriptedBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a4843fa9415c1a955f0e6d686e6aaacbb) () |
| void | [DisableAllBehaviors](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#ad5a5ddc146cc1e56b1210890c5e9816c) () |
| [AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html) | [GetActiveBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a212cd80a0081cd35bf4d48b988eb2605) () |
| virtual void | [Tick](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#ab6bdbd16818c340582179e430bbccf53) (float dt, bool isSimulation) |
| virtual void | [ConversationTick](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a2b034c8bf2bb16bfe82c9b7260411ff7) () |
| virtual void | [OnAgentRemoved](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#ae83cb68cdacaaa6f701c6ac47012afa0) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| virtual float | [GetScore](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a50df7719e7f5b081c6a15b9ae386c668) (bool isSimulation) |
| virtual void | [ForceThink](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#afdcde11796441e4306e3695877cc5294) (float inSeconds) |

|  |  |
| --- | --- |
| Public Attributes | |
| [AgentNavigator](class_sand_box_1_1_agent_navigator.html) | [Navigator](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a246bea1189ff3ab22077e209ca8b5df8) |
| List< [AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html) > | [Behaviors](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a19c465b7589adfb2763cd18a04fa36cd) |

|  |  |
| --- | --- |
| Protected Member Functions | |
|  | [AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a32df764d335fbc961b8e17b7197e9ac4) ([AgentNavigator](class_sand_box_1_1_agent_navigator.html) navigator, [Mission](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a44884a9d081bdab8c3413c579b8b0da5) mission) |
| virtual void | [OnActivate](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a778f19cd14a6f98f1311ec353f0f19df) () |
| virtual void | [OnDeactivate](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#ab5efe10c6df868897fc4d162d1912786) () |

|  |  |
| --- | --- |
| Protected Attributes | |
| float | [CheckBehaviorTime](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a295ec363790e3acc9fe43d8039903c1c) = 5.0f |
| [Timer](class_tale_worlds_1_1_core_1_1_timer.html) | [CheckBehaviorTimer](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a604598a8f19e4ad78ae0d9ef1c516718) |

|  |  |
| --- | --- |
| Properties | |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [OwnerAgent](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a5bc980731dc0635f2cd7cebcedd98f31) `[get]` |
| [AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html) | [ScriptedBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#ae74d8790a3ef1516c961a72d8bcb3f26) `[get]` |
| bool | [IsActive](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a4fcb577d6dcf949af86b1f0be28b0586) `[get, set]` |
| Mission | [Mission](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a44884a9d081bdab8c3413c579b8b0da5) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a32df764d335fbc961b8e17b7197e9ac4)AgentBehaviorGroup()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | SandBox.Missions.AgentBehaviors.AgentBehaviorGroup.AgentBehaviorGroup | ( | [AgentNavigator](class_sand_box_1_1_agent_navigator.html) | *navigator*, | |  |  | [Mission](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a44884a9d081bdab8c3413c579b8b0da5) | *mission* ) | | protected |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a39e9d0417242dbda9a888e70aab61f77)AddBehavior< T >()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| T SandBox.Missions.AgentBehaviors.AgentBehaviorGroup.AddBehavior< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html)* |  |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a582fb5408cd87c05f9213df710b8892e)GetBehavior< T >()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| T SandBox.Missions.AgentBehaviors.AgentBehaviorGroup.GetBehavior< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *AgentBehavior* |  |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#abb258dc00c633f3d09774f3165fd9642)HasBehavior< T >()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool SandBox.Missions.AgentBehaviors.AgentBehaviorGroup.HasBehavior< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html)* |  |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#af8fcea62838e89c1baa1dc7f4e9e08ee)RemoveBehavior< T >()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.Missions.AgentBehaviors.AgentBehaviorGroup.RemoveBehavior< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html)* |  |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a6f0190a0ae9a14b6a5971fdd8cd5c097)SetScriptedBehavior< T >()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.Missions.AgentBehaviors.AgentBehaviorGroup.SetScriptedBehavior< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html)* |  |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a4843fa9415c1a955f0e6d686e6aaacbb)DisableScriptedBehavior()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.Missions.AgentBehaviors.AgentBehaviorGroup.DisableScriptedBehavior | ( |  | ) |  |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#ad5a5ddc146cc1e56b1210890c5e9816c)DisableAllBehaviors()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.Missions.AgentBehaviors.AgentBehaviorGroup.DisableAllBehaviors | ( |  | ) |  |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a212cd80a0081cd35bf4d48b988eb2605)GetActiveBehavior()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html) SandBox.Missions.AgentBehaviors.AgentBehaviorGroup.GetActiveBehavior | ( |  | ) |  |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#ab6bdbd16818c340582179e430bbccf53)Tick()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void SandBox.Missions.AgentBehaviors.AgentBehaviorGroup.Tick | ( | float | *dt*, | |  |  | bool | *isSimulation* ) | | virtual |

Reimplemented in [SandBox.Missions.AgentBehaviors.AlarmedBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#aa4b3a084112ac0cd211a0fd94c618dd0), [SandBox.Missions.AgentBehaviors.DailyBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_daily_behavior_group.html#a960e0ad41232848ded7b761ddbc6d551), and [SandBox.Missions.AgentBehaviors.InterruptingBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_interrupting_behavior_group.html#a2ea8e029f453b7a45274b655bb4f6a20).

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a2b034c8bf2bb16bfe82c9b7260411ff7)ConversationTick()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void SandBox.Missions.AgentBehaviors.AgentBehaviorGroup.ConversationTick | ( |  | ) |  | | virtual |

Reimplemented in [SandBox.Missions.AgentBehaviors.DailyBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_daily_behavior_group.html#a825e842ef4d2d26de023499b0dcdd9c5).

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#ae83cb68cdacaaa6f701c6ac47012afa0)OnAgentRemoved()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void SandBox.Missions.AgentBehaviors.AgentBehaviorGroup.OnAgentRemoved | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | virtual |

Reimplemented in [SandBox.Missions.AgentBehaviors.AlarmedBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#a65c6812854cb28acdf994b844d5b7077), and [SandBox.Missions.AgentBehaviors.DailyBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_daily_behavior_group.html#a9058befaf439a17fa0914a0653ef1176).

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a778f19cd14a6f98f1311ec353f0f19df)OnActivate()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void SandBox.Missions.AgentBehaviors.AgentBehaviorGroup.OnActivate | ( |  | ) |  | | protectedvirtual |

Reimplemented in [SandBox.Missions.AgentBehaviors.AlarmedBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#ac6c172021a51d6effe1e3be2740b17cb), and [SandBox.Missions.AgentBehaviors.DailyBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_daily_behavior_group.html#a82363aa06d5247f5434cccb5e85d1ea6).

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#ab5efe10c6df868897fc4d162d1912786)OnDeactivate()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void SandBox.Missions.AgentBehaviors.AgentBehaviorGroup.OnDeactivate | ( |  | ) |  | | protectedvirtual |

Reimplemented in [SandBox.Missions.AgentBehaviors.AlarmedBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#a215f1f22b68b8818e3c67598927bc9f9), and [SandBox.Missions.AgentBehaviors.DailyBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_daily_behavior_group.html#a117ca62c075d3bffe4d7da34511d67fb).

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a50df7719e7f5b081c6a15b9ae386c668)GetScore()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual float SandBox.Missions.AgentBehaviors.AgentBehaviorGroup.GetScore | ( | bool | *isSimulation* | ) |  | | virtual |

Reimplemented in [SandBox.Missions.AgentBehaviors.AlarmedBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#a0e4d17d71d66534dcc2a4e0ebd338b6a), [SandBox.Missions.AgentBehaviors.DailyBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_daily_behavior_group.html#a8d27ea0ff3a4bd42a0909fc0b65e8706), and [SandBox.Missions.AgentBehaviors.InterruptingBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_interrupting_behavior_group.html#a5b8579856a5104cdef57abf2a084147b).

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#afdcde11796441e4306e3695877cc5294)ForceThink()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void SandBox.Missions.AgentBehaviors.AgentBehaviorGroup.ForceThink | ( | float | *inSeconds* | ) |  | | virtual |

Reimplemented in [SandBox.Missions.AgentBehaviors.AlarmedBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#aec1155cf3a091f5af9edb9725022cf95), [SandBox.Missions.AgentBehaviors.DailyBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_daily_behavior_group.html#a657a7af6b61971b8b2ae8c6bd4e8798d), and [SandBox.Missions.AgentBehaviors.InterruptingBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_interrupting_behavior_group.html#a021e9a5becb9fcb13a4b41d7ad745488).

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a246bea1189ff3ab22077e209ca8b5df8)Navigator
-----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [AgentNavigator](class_sand_box_1_1_agent_navigator.html) SandBox.Missions.AgentBehaviors.AgentBehaviorGroup.Navigator |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a19c465b7589adfb2763cd18a04fa36cd)Behaviors
-----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| List<[AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html)> SandBox.Missions.AgentBehaviors.AgentBehaviorGroup.Behaviors |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a295ec363790e3acc9fe43d8039903c1c)CheckBehaviorTime
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float SandBox.Missions.AgentBehaviors.AgentBehaviorGroup.CheckBehaviorTime = 5.0f | | protected |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a604598a8f19e4ad78ae0d9ef1c516718)CheckBehaviorTimer
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Timer](class_tale_worlds_1_1_core_1_1_timer.html) SandBox.Missions.AgentBehaviors.AgentBehaviorGroup.CheckBehaviorTimer | | protected |

Property Documentation
----------------------

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a5bc980731dc0635f2cd7cebcedd98f31)OwnerAgent
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) SandBox.Missions.AgentBehaviors.AgentBehaviorGroup.OwnerAgent | | get |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#ae74d8790a3ef1516c961a72d8bcb3f26)ScriptedBehavior
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html) SandBox.Missions.AgentBehaviors.AgentBehaviorGroup.ScriptedBehavior | | get |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a4fcb577d6dcf949af86b1f0be28b0586)IsActive
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.Missions.AgentBehaviors.AgentBehaviorGroup.IsActive | | getset |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a44884a9d081bdab8c3413c579b8b0da5)Mission
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Mission SandBox.Missions.AgentBehaviors.AgentBehaviorGroup.Mission | | get |

