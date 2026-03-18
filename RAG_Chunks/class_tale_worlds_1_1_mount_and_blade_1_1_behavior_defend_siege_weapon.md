--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_behavior_defend_siege_weapon.html ---

TaleWorlds.MountAndBlade.BehaviorDefendSiegeWeapon Class Reference[Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) tries to maintain position and defend siege weapon it is expected to defend.

Inherits [TaleWorlds.MountAndBlade.BehaviorComponent](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [BehaviorDefendSiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_defend_siege_weapon.html#a7aa5e28bc2dcda20d0832005df40be5b) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#a4360805b0766bfc028f6527caede2f86) formation) |
| void | [SetDefensePositionFromTactic](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_defend_siege_weapon.html#a74fe20fdaa6290074bec237382ae8245) ([WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) defensePosition) |
| void | [SetDefendedSiegeWeaponFromTactic](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_defend_siege_weapon.html#a5945e9282eae0853dd091de3bad37cd5) ([SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html) siegeWeapon) |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetBehaviorString](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_defend_siege_weapon.html#ab4373be1d00cee4db69ea364abc349b9) () |
| override void | [TickOccasionally](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_defend_siege_weapon.html#af5e5628016378f87be489e3459e445ea) () |
| override void | [ResetBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_defend_siege_weapon.html#abf81fbd844174dc3c89c5f3df911aede) () |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.BehaviorComponent](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html) | |
| virtual void | [OnBehaviorCanceled](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#a7b21eb0bcb678be10607e553bd04cb99) () |
| virtual void | [OnLostAIControl](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#aaac3ec4bc4cda6390042a1f8221899df) () |
| virtual void | [OnAgentRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#a83b45132d34ddd1efe9094c928ae7114) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| void | [RemindSergeantPlayer](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#acf87edadc59dabc0a3d8700cf29c3bab) () |
| float | [GetAIWeight](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#ae1476ae3f9facc0f25b2e2228f5d7b20) () |
| virtual void | [OnValidBehaviorSideChanged](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#adf2e65767d60b028bc21c6e6b4ac89e2) () |
| void | [PrecalculateMovementOrder](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#a6ff04e84401807b78987f82b5b46b2f2) () |
| override bool | [Equals](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#a221f378ff733e60aca88a9fa33b339d0) (object obj) |
| override int | [GetHashCode](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#a5cfd35f2bff33997418ddff5244eadf5) () |
| virtual void | [OnDeploymentFinished](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#a2a8c0709990d8ef3ba80259abed3a01f) () |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [CalculateCurrentOrder](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_defend_siege_weapon.html#ab7e51e1b92e8631e57b189bd0d462a8c) () |
| override void | [OnBehaviorActivatedAux](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_defend_siege_weapon.html#a8f0b377e3b36aab8615780ae4f768d62) () |
| override float | [GetAiWeight](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_defend_siege_weapon.html#aa70b0fd3a23115181c56931b3fc34b67) () |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.BehaviorComponent](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html) | |
|  | [BehaviorComponent](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#a17d0fdfe2fa5c1aaa057c8423c213ca2) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#a4360805b0766bfc028f6527caede2f86) formation) |
|  | [BehaviorComponent](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#ae1c93102801ec8553ce73a85921f1282) () |
| float | [GetAiWeight](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#a1c487cef0b117cff8e1cabaa8f8bb6a4) () |

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
| Properties inherited from [TaleWorlds.MountAndBlade.BehaviorComponent](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html) | |
| Formation | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#a4360805b0766bfc028f6527caede2f86) `[get]` |
| float | [BehaviorCoherence](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#a5bb9efd02c2e3665fb0eb5571d532bfe) `[get, set]` |
| virtual float | [NavmeshlessTargetPositionPenalty](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#a2868ce3a0e1abd701bdb9f74f84d1643) `[get, set]` |
| [MovementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html) | [CurrentOrder](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#ad51cf223a0ec035eb3518c1bd90b31b9) `[get, protected set]` |
| float | [PreserveExpireTime](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#ad0932acfa55a6ad0d395c403c8da17f0) `[get, set]` |
| float | [WeightFactor](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#a296545f52814ec1bc4ac30c0edb96d67) `[get, set]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_defend_siege_weapon.html#a7aa5e28bc2dcda20d0832005df40be5b)BehaviorDefendSiegeWeapon()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.BehaviorDefendSiegeWeapon.BehaviorDefendSiegeWeapon | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#a4360805b0766bfc028f6527caede2f86) | *formation* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_defend_siege_weapon.html#a74fe20fdaa6290074bec237382ae8245)SetDefensePositionFromTactic()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.BehaviorDefendSiegeWeapon.SetDefensePositionFromTactic | ( | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *defensePosition* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_defend_siege_weapon.html#a5945e9282eae0853dd091de3bad37cd5)SetDefendedSiegeWeaponFromTactic()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.BehaviorDefendSiegeWeapon.SetDefendedSiegeWeaponFromTactic | ( | [SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html) | *siegeWeapon* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_defend_siege_weapon.html#ab4373be1d00cee4db69ea364abc349b9)GetBehaviorString()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.MountAndBlade.BehaviorDefendSiegeWeapon.GetBehaviorString | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.BehaviorComponent](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#a9593b7100634eef2cea3353ad139ff45).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_defend_siege_weapon.html#ab7e51e1b92e8631e57b189bd0d462a8c)CalculateCurrentOrder()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.BehaviorDefendSiegeWeapon.CalculateCurrentOrder | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.BehaviorComponent](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#ad5f4869be5f4254d3c587906ef5e64ae).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_defend_siege_weapon.html#af5e5628016378f87be489e3459e445ea)TickOccasionally()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.BehaviorDefendSiegeWeapon.TickOccasionally | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.BehaviorComponent](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#a0b0402a9dfcf310aeb25b0ed51898613).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_defend_siege_weapon.html#a8f0b377e3b36aab8615780ae4f768d62)OnBehaviorActivatedAux()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.BehaviorDefendSiegeWeapon.OnBehaviorActivatedAux | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.BehaviorComponent](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#ab13f0bfd3c875ec8cc32cd03fc010aaa).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_defend_siege_weapon.html#abf81fbd844174dc3c89c5f3df911aede)ResetBehavior()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.BehaviorDefendSiegeWeapon.ResetBehavior | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.BehaviorComponent](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_component.html#a86b12fc5650a5576366a40470bbec960).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_behavior_defend_siege_weapon.html#aa70b0fd3a23115181c56931b3fc34b67)GetAiWeight()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override float TaleWorlds.MountAndBlade.BehaviorDefendSiegeWeapon.GetAiWeight | ( |  | ) |  | | protected |

