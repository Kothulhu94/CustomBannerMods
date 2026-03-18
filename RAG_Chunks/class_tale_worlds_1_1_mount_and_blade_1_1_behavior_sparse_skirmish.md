--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_behavior_sparse_skirmish.html ---

TaleWorlds.MountAndBlade.BehaviorSparseSkirmish Class ReferenceRanged soldiers move to positions marked in scene for advantageous shooting.

Inherits [TaleWorlds.MountAndBlade.BehaviorComponent](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [BehaviorSparseSkirmish](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_sparse_skirmish.html#aa5f6c6ebd3e1b6f16fef88b7d10507fd) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#a4360805b0766bfc028f6527caede2f86) formation) |
| override void | [TickOccasionally](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_sparse_skirmish.html#a2ece53f10fb2c9a0929eebaf9cfbdf8b) () |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.BehaviorComponent](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html) | |
| virtual void | [OnBehaviorCanceled](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#a7b21eb0bcb678be10607e553bd04cb99) () |
| virtual void | [OnLostAIControl](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#aaac3ec4bc4cda6390042a1f8221899df) () |
| virtual void | [OnAgentRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#a83b45132d34ddd1efe9094c928ae7114) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| void | [RemindSergeantPlayer](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#acf87edadc59dabc0a3d8700cf29c3bab) () |
| float | [GetAIWeight](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#ae1476ae3f9facc0f25b2e2228f5d7b20) () |
| virtual void | [ResetBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#a86b12fc5650a5576366a40470bbec960) () |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetBehaviorString](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#a9593b7100634eef2cea3353ad139ff45) () |
| virtual void | [OnValidBehaviorSideChanged](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#adf2e65767d60b028bc21c6e6b4ac89e2) () |
| void | [PrecalculateMovementOrder](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#a6ff04e84401807b78987f82b5b46b2f2) () |
| override bool | [Equals](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#a221f378ff733e60aca88a9fa33b339d0) (object obj) |
| override int | [GetHashCode](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#a5cfd35f2bff33997418ddff5244eadf5) () |
| virtual void | [OnDeploymentFinished](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#a2a8c0709990d8ef3ba80259abed3a01f) () |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnBehaviorActivatedAux](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_sparse_skirmish.html#a8cf082f6695bb5aa9bfc47336ddf711d) () |
| override float | [GetAiWeight](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_sparse_skirmish.html#a4b0019424eae298ebaf28390f3d7ff05) () |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.BehaviorComponent](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html) | |
|  | [BehaviorComponent](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#a17d0fdfe2fa5c1aaa057c8423c213ca2) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#a4360805b0766bfc028f6527caede2f86) formation) |
|  | [BehaviorComponent](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#ae1c93102801ec8553ce73a85921f1282) () |
| float | [GetAiWeight](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#a1c487cef0b117cff8e1cabaa8f8bb6a4) () |
| virtual void | [CalculateCurrentOrder](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#ad5f4869be5f4254d3c587906ef5e64ae) () |

|  |  |
| --- | --- |
| Properties | |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [ArcherPosition](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_sparse_skirmish.html#a401a16be7bdf92325c53286b13e67ebd) `[get, set]` |
| override float | [NavmeshlessTargetPositionPenalty](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_sparse_skirmish.html#acd8c3719a44ab88a6bf53e9ec69914e9) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.BehaviorComponent](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html) | |
| Formation | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#a4360805b0766bfc028f6527caede2f86) `[get]` |
| float | [BehaviorCoherence](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#a5bb9efd02c2e3665fb0eb5571d532bfe) `[get, set]` |
| virtual float | [NavmeshlessTargetPositionPenalty](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#a2868ce3a0e1abd701bdb9f74f84d1643) `[get, set]` |
| [MovementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html) | [CurrentOrder](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#ad51cf223a0ec035eb3518c1bd90b31b9) `[get, protected set]` |
| float | [PreserveExpireTime](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#ad0932acfa55a6ad0d395c403c8da17f0) `[get, set]` |
| float | [WeightFactor](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#a296545f52814ec1bc4ac30c0edb96d67) `[get, set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Attributes inherited from [TaleWorlds.MountAndBlade.BehaviorComponent](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html) | |
| bool | [IsCurrentOrderChanged](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#acf611b4df74a22a018d34c4e5a9390e9) |
| Protected Attributes inherited from [TaleWorlds.MountAndBlade.BehaviorComponent](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html) | |
| [FormationAI.BehaviorSide](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#af0e557fbaea88404cb872c1bc2b7912b) | [\_behaviorSide](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#af5128f07b394993742de980d9204ce86) |
| float | [\_lastPlayerInformTime](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#a0d414fb2e9aa60407afa2ae47257efed) = 0f |
| [FacingOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_facing_order.html) | [CurrentFacingOrder](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#a5c463463766f31cc5161b61ce0031a0e) = [FacingOrder.FacingOrderLookAtEnemy](struct_tale_worlds_1_1_mount_and_blade_1_1_facing_order.html#a89656a1e21d867f3c7bb069c2e4cd951) |
| Static Protected Attributes inherited from [TaleWorlds.MountAndBlade.BehaviorComponent](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html) | |
| const float | [FormArrangementDistanceToOrderPosition](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#a7221d122b8e3a294eb95871692a956a0) = 10f |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_sparse_skirmish.html#aa5f6c6ebd3e1b6f16fef88b7d10507fd)BehaviorSparseSkirmish()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.BehaviorSparseSkirmish.BehaviorSparseSkirmish | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#a4360805b0766bfc028f6527caede2f86) | *formation* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_sparse_skirmish.html#a2ece53f10fb2c9a0929eebaf9cfbdf8b)TickOccasionally()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.BehaviorSparseSkirmish.TickOccasionally | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.BehaviorComponent](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#a0b0402a9dfcf310aeb25b0ed51898613).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_sparse_skirmish.html#a8cf082f6695bb5aa9bfc47336ddf711d)OnBehaviorActivatedAux()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.BehaviorSparseSkirmish.OnBehaviorActivatedAux | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.BehaviorComponent](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#ab13f0bfd3c875ec8cc32cd03fc010aaa).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_sparse_skirmish.html#a4b0019424eae298ebaf28390f3d7ff05)GetAiWeight()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override float TaleWorlds.MountAndBlade.BehaviorSparseSkirmish.GetAiWeight | ( |  | ) |  | | protected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_sparse_skirmish.html#a401a16be7bdf92325c53286b13e67ebd)ArcherPosition
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) TaleWorlds.MountAndBlade.BehaviorSparseSkirmish.ArcherPosition | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_sparse_skirmish.html#acd8c3719a44ab88a6bf53e9ec69914e9)NavmeshlessTargetPositionPenalty
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.MountAndBlade.BehaviorSparseSkirmish.NavmeshlessTargetPositionPenalty | | get |

