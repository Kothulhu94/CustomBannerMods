--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html ---

TaleWorlds.MountAndBlade.FormationAI Class Reference|  |  |
| --- | --- |
| Classes | |
| class | [BehaviorData](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i_1_1_behavior_data.html) |

|  |  |
| --- | --- |
| Public Types | |
| enum | [BehaviorSide](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#af0e557fbaea88404cb872c1bc2b7912b) {     [Left](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#af0e557fbaea88404cb872c1bc2b7912ba945d5e233cf7d6240f6b783b36a374ff) = 0 ,     [Middle](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#af0e557fbaea88404cb872c1bc2b7912bab1ca34f82e83c52b010f86955f264e05) = 1 ,     [Right](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#af0e557fbaea88404cb872c1bc2b7912ba92b09c7c48c520c3c55e497875da437c) = 2 ,     [BehaviorSideNotSet](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#af0e557fbaea88404cb872c1bc2b7912bac3ac6e135cdcbdd4fde839b7754c5df2) = 3 ,     [ValidBehaviorSideCount](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#af0e557fbaea88404cb872c1bc2b7912bacf05b6dcd80ac0be0eb5ac2719bb03d8) = 3   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [FormationAI](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#a4f3a9320e0b81d2886ac175dfe63772b) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| T | [SetBehaviorWeight< T >](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#ac4d9ee41824fbd0aebfae8a177d7e53d) (float w) |
| void | [AddAiBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#a8d82c3ddfdb6523f9dc5f3f202f2a0b0) ([BehaviorComponent](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html) behaviorComponent) |
| T | [GetBehavior< T >](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#a7886cec56cc897bb470c8546042efafc) () |
| void | [AddSpecialBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#a91bf957521aaf7944b2eabc1e706540c) ([BehaviorComponent](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html) behavior, bool purgePreviousSpecialBehaviors=false) |
| void | [Tick](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#aad4546e627983d0c72c348cd54da9b6d) () |
| void | [OnDeploymentFinished](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#a24920b803e68cb02bb5d7b2d535433c6) () |
| void | [OnAgentRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#a2c7f1d9b89f1df494fea0fdd3161eeb4) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| [BehaviorComponent](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html) | [GetBehaviorAtIndex](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#abff89ab5696c03fb533c9233a261d355) (int index) |
| void | [DebugMore](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#a8cc6281b976870a4e0fe2c2f3bc54f54) () |
| void | [DebugScores](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#a0fed403ba516940fac57c6093ae5abf0) () |
| void | [ResetBehaviorWeights](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#a8173136f297eb41c6ba1736b5c1c2720) () |

|  |  |
| --- | --- |
| Properties | |
| [BehaviorComponent](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html) | [ActiveBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#a62aef3130ebc2ca25ff48f0f7574e824) `[get]` |
| [BehaviorSide](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#af0e557fbaea88404cb872c1bc2b7912b) | [Side](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#a60a222c30c4408a771e570bcb002cc66) `[get, set]` |
| bool | [IsMainFormation](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#ae30872eaed55c508ff2b2125db46d07e) `[get, set]` |
| int | [BehaviorCount](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#a25434799b8a8c88d676afcc18aeb9936) `[get]` |

|  |  |
| --- | --- |
| Events | |
| Action< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > | [OnActiveBehaviorChanged](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#a89e489ca890d66f8c8a4f22e130d49ae) |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#af0e557fbaea88404cb872c1bc2b7912b)BehaviorSide
---------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.FormationAI.BehaviorSide](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#af0e557fbaea88404cb872c1bc2b7912b) |

| Enumerator | |
| --- | --- |
| Left |  |
| Middle |  |
| Right |  |
| BehaviorSideNotSet |  |
| ValidBehaviorSideCount |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#a4f3a9320e0b81d2886ac175dfe63772b)FormationAI()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.FormationAI.FormationAI | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#ac4d9ee41824fbd0aebfae8a177d7e53d)SetBehaviorWeight< T >()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| T TaleWorlds.MountAndBlade.FormationAI.SetBehaviorWeight< T > | ( | float | *w* | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[BehaviorComponent](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html)* |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#a8d82c3ddfdb6523f9dc5f3f202f2a0b0)AddAiBehavior()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.FormationAI.AddAiBehavior | ( | [BehaviorComponent](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html) | *behaviorComponent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#a7886cec56cc897bb470c8546042efafc)GetBehavior< T >()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| T TaleWorlds.MountAndBlade.FormationAI.GetBehavior< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[BehaviorComponent](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html)* |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#a91bf957521aaf7944b2eabc1e706540c)AddSpecialBehavior()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.FormationAI.AddSpecialBehavior | ( | [BehaviorComponent](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html) | *behavior*, |
|  |  | bool | *purgePreviousSpecialBehaviors* = false ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#aad4546e627983d0c72c348cd54da9b6d)Tick()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.FormationAI.Tick | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#a24920b803e68cb02bb5d7b2d535433c6)OnDeploymentFinished()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.FormationAI.OnDeploymentFinished | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#a2c7f1d9b89f1df494fea0fdd3161eeb4)OnAgentRemoved()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.FormationAI.OnAgentRemoved | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#abff89ab5696c03fb533c9233a261d355)GetBehaviorAtIndex()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [BehaviorComponent](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html) TaleWorlds.MountAndBlade.FormationAI.GetBehaviorAtIndex | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#a8cc6281b976870a4e0fe2c2f3bc54f54)DebugMore()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.FormationAI.DebugMore | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#a0fed403ba516940fac57c6093ae5abf0)DebugScores()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.FormationAI.DebugScores | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#a8173136f297eb41c6ba1736b5c1c2720)ResetBehaviorWeights()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.FormationAI.ResetBehaviorWeights | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#a62aef3130ebc2ca25ff48f0f7574e824)ActiveBehavior
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BehaviorComponent](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html) TaleWorlds.MountAndBlade.FormationAI.ActiveBehavior | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#a60a222c30c4408a771e570bcb002cc66)Side
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BehaviorSide](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#af0e557fbaea88404cb872c1bc2b7912b) TaleWorlds.MountAndBlade.FormationAI.Side | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#ae30872eaed55c508ff2b2125db46d07e)IsMainFormation
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.FormationAI.IsMainFormation | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#a25434799b8a8c88d676afcc18aeb9936)BehaviorCount
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.FormationAI.BehaviorCount | | get |

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#a89e489ca890d66f8c8a4f22e130d49ae)OnActiveBehaviorChanged
--------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html)> TaleWorlds.MountAndBlade.FormationAI.OnActiveBehaviorChanged |

