--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html ---

TaleWorlds.MountAndBlade.HumanAIComponent Class ReferenceInherits [TaleWorlds.MountAndBlade.AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html).

|  |  |
| --- | --- |
| Classes | |
| struct | [BehaviorValues](struct_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component_1_1_behavior_values.html) |

|  |  |
| --- | --- |
| Public Types | |
| enum | [AISimpleBehaviorKind](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#af5bb0a806d07de4fe21691beca41b4f4) {     [GoToPos](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#af5bb0a806d07de4fe21691beca41b4f4a52c953f32e959dd7b49333ba9b5d85e5) = 0 ,     [Melee](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#af5bb0a806d07de4fe21691beca41b4f4afcbd772e48c4b07d7d3be13b37a82f5e) ,     [Ranged](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#af5bb0a806d07de4fe21691beca41b4f4ac2f329a17c18a701dbe1e96e03858728) ,     [ChargeHorseback](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#af5bb0a806d07de4fe21691beca41b4f4a8ab4890aff5f377083962ed1bfd08096) ,     [RangedHorseback](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#af5bb0a806d07de4fe21691beca41b4f4a1b50550659aea7196f9d76dc195f09b8) ,     [AttackEntityMelee](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#af5bb0a806d07de4fe21691beca41b4f4a7bcfa6f6a5012b759b218fdf105b9d35) ,     [AttackEntityRanged](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#af5bb0a806d07de4fe21691beca41b4f4a50724b68f8da37efe6c7cab6d9dfe940) ,     [Count](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#af5bb0a806d07de4fe21691beca41b4f4ae93f994f01c537c4e2f7d8528c3eb5e9)   } |
| enum | [BehaviorValueSet](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a43eff3d9dfd7c2f47aadcc748c7d3346) {     [Default](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a43eff3d9dfd7c2f47aadcc748c7d3346a7a1920d61156abc05a60135aefe8bc67) ,     [DefensiveArrangementMove](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a43eff3d9dfd7c2f47aadcc748c7d3346a2cd4b01dbf62de40d75a7352b49966e9) ,     [Follow](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a43eff3d9dfd7c2f47aadcc748c7d3346a3903aab323863bd2e9b68218a7a65ebd) ,     [DefaultMove](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a43eff3d9dfd7c2f47aadcc748c7d3346a7e1962a5844a894b737672be78917f76) ,     [Charge](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a43eff3d9dfd7c2f47aadcc748c7d3346a517349a3cdc1acf50617693e3ba33988) ,     [DefaultDetached](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a43eff3d9dfd7c2f47aadcc748c7d3346a1436307b2756d9f195acab5ba0a76a0c) ,     [Overriden](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a43eff3d9dfd7c2f47aadcc748c7d3346a044c2f8ab03a1d068b07333e66b0e998)   } |
| enum | [UsableObjectInterestKind](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a60040a3621ba83e5133cf21ec4b7e322) {     [None](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a60040a3621ba83e5133cf21ec4b7e322a6adf97f83acf6453d4a6a4b1070f3754) ,     [MovingTo](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a60040a3621ba83e5133cf21ec4b7e322a99e0dca0eae52d6aa3f19185976e73bb) ,     [Defending](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a60040a3621ba83e5133cf21ec4b7e322afb08a52d95d398c12b24d6c075d43051) ,     [Count](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a60040a3621ba83e5133cf21ec4b7e322ae93f994f01c537c4e2f7d8528c3eb5e9)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [HumanAIComponent](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#ad5049939080a3dda2d024054d5f5c975) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) agent) |
| void | [OverrideBehaviorParams](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a8d7e05c06c35240796e5640b3a9935cd) ([AISimpleBehaviorKind](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#af5bb0a806d07de4fe21691beca41b4f4) behavior, float y1, float x2, float y2, float x3, float y3) |
| void | [SyncBehaviorParamsIfNecessary](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a7e23ae76dfe2446ff16d7967721d721b) () |
| void | [DisablePickUpForAgentIfNeeded](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a06f7dd21f7321cf560e7237b33cde68d) () |
| override void | [OnTickParallel](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a2b407e2c329ab037eff78f0e07e3d97e) (float dt) |
| override void | [OnTick](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a9edf5347e3fe3c79b4129066bd0c0e4b) (float dt) |
| override void | [OnAgentRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a12266e13e70f2da8ad44d6fac03bfbde) () |
| override void | [OnComponentRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a9873d2cd3273c3e9530e86221b6bc6c7) () |
|  | Only called if component is manually removed without removing the owner [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) during the mission. |
| bool | [IsInImportantCombatAction](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a0788ee0125dbff96d2f44a8d59b18ac6) () |
| [UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) | [GetCurrentlyMovingGameObject](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a0684c7ed3bfeedbee0a984c1efeb3e07) () |
| [UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) | [GetCurrentlyDefendingGameObject](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a330898a42c28d1f52e0e0ec3ad7a1d74) () |
| void | [MoveToUsableGameObject](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a4333eaf1105298e26b22e052b1a0f4f9) ([UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) usedObject, [IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html) detachment, [Agent.AIScriptedFrameFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0) scriptedFrameFlags=[Agent.AIScriptedFrameFlags.NoAttack](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0afd717fc56e019faf5bdeb3429d6eb17d)) |
| void | [MoveToClear](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a585f82ce2f480e2f835a2ec158b7003f) () |
| void | [StartDefendingGameObject](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a82cc4cccc3972d3b79bad1cc2bb043a7) ([UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) usedObject, [IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html) detachment) |
| void | [StopDefendingGameObject](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#ae6b087bd3b227611f215da218940750a) () |
| bool | [IsInterestedInAnyGameObject](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a44ec6ee640cd586f824ffe030744a49c) () |
| bool | [IsInterestedInGameObject](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a4b29aa24be684f9113803d0e805d87fd) ([UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) usableMissionObject) |
| void | [FollowAgent](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#adcca9d053fc3a6e4535d14c71abb4366) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) agent) |
| float | [GetDesiredSpeedInFormation](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#aa7c5cdfa1a126468fd6906ec360a702b) (bool isCharging) |
| void | [AdjustSpeedLimit](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#ac9737471f257426e2fa71db7dcb10415) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) agent, float desiredSpeed, bool limitIsMultiplier) |
| void | [ParallelUpdateFormationMovement](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a4cc9c29901cac71dc51c38cd7efb00d1) () |
| override void | [OnRetreating](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#ab2284d6adb975c96c29d78263d66a54d) () |
| override void | [OnDismount](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a229c64419d5f8ce3a4cf0a5cd2bdd927) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) mount) |
| void | [SetBehaviorValueSet](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#ad2df2329b79e90e3089bd6cfc13ed345) ([BehaviorValueSet](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a43eff3d9dfd7c2f47aadcc748c7d3346) behaviorValueSet) |
| void | [RefreshBehaviorValues](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a7cba856e0e3f9567c762677c0e8025c3) (MovementOrderEnum movementOrder, ArrangementOrderEnum arrangementOrder) |
| void | [ForceDisablePickUpForAgent](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a75bcc981ce004700d922b23970263636) () |
| void | [SetScriptedPositionAndDirectionTimed](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#ad8b37a8712ef6155a5aba1645f42844b) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position, float directionAsRotationInRadians, float duration) |
| void | [DisableTimedScriptedMovement](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a24f102ba2d4fb6d7a7c10c5c472fca1e) () |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html) | |
| virtual void | [Initialize](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a23212feac472e08d23165fe6db7cd28f) () |
| virtual float | [GetMoraleAddition](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a50f9e9736a7fe32eee200fcae949d30f) () |
| virtual float | [GetMoraleDecreaseConstant](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#ad632fe59edb9b7c4d79a4166b3ceda40) () |
| virtual void | [OnItemPickup](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#af943da73b5c5015d8cede597df2e5500) ([SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html) item) |
| virtual void | [OnWeaponDrop](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#ad09f9803d1bd76cc43f85d8c21a1d7d4) ([MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) droppedWeapon) |
| virtual void | [OnStopUsingGameObject](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a94d4186a8544b74f93f47e4f8a67a753) () |
| virtual void | [OnWeaponHPChanged](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#ad10774dc526a149ead4cf05c540142f2) ([TaleWorlds.Core.ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item, int hitPoints) |
| virtual void | [OnMount](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68eb40d609376819d7449be8f1ead5cf) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) mount) |
| virtual void | [OnHit](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#ab9f12157938b85af29b4d5cb91539b8d) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) affectorAgent, int damage, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) affectorWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) b, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData) |
| virtual void | [OnDisciplineChanged](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a893a41fdfad686d7fa36e81c01e70370) () |
| virtual void | [OnAgentTeleported](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#aff9ffe09f9846409e86968055d9b6871) () |
| virtual void | [OnAIInputSet](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#af81841738899b2aee40e1ffc2a0f093a) (ref [Agent.EventControlFlag](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a027f37ecbc637dd0fb2a480d87139429) eventFlag, ref [Agent.MovementControlFlag](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a81bece812eef7b0170864a38f387e797) movementFlag, ref [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) inputVector) |
| virtual void | [OnFormationSet](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a2782f6a10b66065665b38a5b3a390f93) () |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static bool | [FormationSpeedAdjustmentEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a88162e09483f7383b8139f7ffc20c742) = true |

|  |  |
| --- | --- |
| Properties | |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) | [FollowedAgent](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#af2a941e0cc1fbf20fcd073b27a403d2e) `[get]` |
| bool | [ShouldCatchUpWithFormation](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a19929b936fcc62fa6ae492d381b3c975) `[get]` |
| bool | [IsDefending](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a64f4c73fc020907eacee8d2f0b8c1f11) `[get]` |
| bool | [HasTimedScriptedFrame](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a579162ef39e3f41d3ff07b4a037adb89) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html) | |
|  | [AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a72d82f2ac09f7f436c49a0b07fb83314) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) agent) |
| Protected Attributes inherited from [TaleWorlds.MountAndBlade.AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html) | |
| readonly Agent | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#af5bb0a806d07de4fe21691beca41b4f4)AISimpleBehaviorKind
-----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.HumanAIComponent.AISimpleBehaviorKind](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#af5bb0a806d07de4fe21691beca41b4f4) |

| Enumerator | |
| --- | --- |
| GoToPos |  |
| Melee |  |
| Ranged |  |
| ChargeHorseback |  |
| RangedHorseback |  |
| AttackEntityMelee |  |
| AttackEntityRanged |  |
| Count |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a43eff3d9dfd7c2f47aadcc748c7d3346)BehaviorValueSet
-------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.HumanAIComponent.BehaviorValueSet](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a43eff3d9dfd7c2f47aadcc748c7d3346) |

| Enumerator | |
| --- | --- |
| Default |  |
| DefensiveArrangementMove |  |
| Follow |  |
| DefaultMove |  |
| Charge |  |
| DefaultDetached |  |
| Overriden |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a60040a3621ba83e5133cf21ec4b7e322)UsableObjectInterestKind
---------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.HumanAIComponent.UsableObjectInterestKind](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a60040a3621ba83e5133cf21ec4b7e322) |

| Enumerator | |
| --- | --- |
| None |  |
| MovingTo |  |
| Defending |  |
| Count |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#ad5049939080a3dda2d024054d5f5c975)HumanAIComponent()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.HumanAIComponent.HumanAIComponent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) | *agent* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a8d7e05c06c35240796e5640b3a9935cd)OverrideBehaviorParams()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.HumanAIComponent.OverrideBehaviorParams | ( | [AISimpleBehaviorKind](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#af5bb0a806d07de4fe21691beca41b4f4) | *behavior*, |
|  |  | float | *y1*, |
|  |  | float | *x2*, |
|  |  | float | *y2*, |
|  |  | float | *x3*, |
|  |  | float | *y3* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a7e23ae76dfe2446ff16d7967721d721b)SyncBehaviorParamsIfNecessary()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.HumanAIComponent.SyncBehaviorParamsIfNecessary | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a06f7dd21f7321cf560e7237b33cde68d)DisablePickUpForAgentIfNeeded()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.HumanAIComponent.DisablePickUpForAgentIfNeeded | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a2b407e2c329ab037eff78f0e07e3d97e)OnTickParallel()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.HumanAIComponent.OnTickParallel | ( | float | *dt* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a4cf2b9047a9068d5ed8a91e15b8d45d4).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a9edf5347e3fe3c79b4129066bd0c0e4b)OnTick()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.HumanAIComponent.OnTick | ( | float | *dt* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a3c75fd76296919a27d232e63e41d5790).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a12266e13e70f2da8ad44d6fac03bfbde)OnAgentRemoved()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.HumanAIComponent.OnAgentRemoved | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a12cec8129389d6a70645aca41a797674).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a9873d2cd3273c3e9530e86221b6bc6c7)OnComponentRemoved()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.HumanAIComponent.OnComponentRemoved | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a8e1db4125ef644c5a22a663fafcc340a).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a0788ee0125dbff96d2f44a8d59b18ac6)IsInImportantCombatAction()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.HumanAIComponent.IsInImportantCombatAction | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a0684c7ed3bfeedbee0a984c1efeb3e07)GetCurrentlyMovingGameObject()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) TaleWorlds.MountAndBlade.HumanAIComponent.GetCurrentlyMovingGameObject | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a330898a42c28d1f52e0e0ec3ad7a1d74)GetCurrentlyDefendingGameObject()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) TaleWorlds.MountAndBlade.HumanAIComponent.GetCurrentlyDefendingGameObject | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a4333eaf1105298e26b22e052b1a0f4f9)MoveToUsableGameObject()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.HumanAIComponent.MoveToUsableGameObject | ( | [UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) | *usedObject*, |
|  |  | [IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html) | *detachment*, |
|  |  | [Agent.AIScriptedFrameFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0) | *scriptedFrameFlags* = [Agent::AIScriptedFrameFlags::NoAttack](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0afd717fc56e019faf5bdeb3429d6eb17d) ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a585f82ce2f480e2f835a2ec158b7003f)MoveToClear()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.HumanAIComponent.MoveToClear | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a82cc4cccc3972d3b79bad1cc2bb043a7)StartDefendingGameObject()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.HumanAIComponent.StartDefendingGameObject | ( | [UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) | *usedObject*, |
|  |  | [IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html) | *detachment* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#ae6b087bd3b227611f215da218940750a)StopDefendingGameObject()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.HumanAIComponent.StopDefendingGameObject | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a44ec6ee640cd586f824ffe030744a49c)IsInterestedInAnyGameObject()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.HumanAIComponent.IsInterestedInAnyGameObject | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a4b29aa24be684f9113803d0e805d87fd)IsInterestedInGameObject()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.HumanAIComponent.IsInterestedInGameObject | ( | [UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) | *usableMissionObject* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#adcca9d053fc3a6e4535d14c71abb4366)FollowAgent()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.HumanAIComponent.FollowAgent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) | *agent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#aa7c5cdfa1a126468fd6906ec360a702b)GetDesiredSpeedInFormation()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.HumanAIComponent.GetDesiredSpeedInFormation | ( | bool | *isCharging* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#ac9737471f257426e2fa71db7dcb10415)AdjustSpeedLimit()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.HumanAIComponent.AdjustSpeedLimit | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) | *agent*, |
|  |  | float | *desiredSpeed*, |
|  |  | bool | *limitIsMultiplier* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a4cc9c29901cac71dc51c38cd7efb00d1)ParallelUpdateFormationMovement()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.HumanAIComponent.ParallelUpdateFormationMovement | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#ab2284d6adb975c96c29d78263d66a54d)OnRetreating()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.HumanAIComponent.OnRetreating | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a091078b59471649794d1b8792d286605).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a229c64419d5f8ce3a4cf0a5cd2bdd927)OnDismount()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.HumanAIComponent.OnDismount | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) | *mount* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a49064846b17ce1a14ed1edb99b082cf1).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#ad2df2329b79e90e3089bd6cfc13ed345)SetBehaviorValueSet()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.HumanAIComponent.SetBehaviorValueSet | ( | [BehaviorValueSet](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a43eff3d9dfd7c2f47aadcc748c7d3346) | *behaviorValueSet* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a7cba856e0e3f9567c762677c0e8025c3)RefreshBehaviorValues()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.HumanAIComponent.RefreshBehaviorValues | ( | MovementOrderEnum | *movementOrder*, |
|  |  | ArrangementOrderEnum | *arrangementOrder* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a75bcc981ce004700d922b23970263636)ForceDisablePickUpForAgent()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.HumanAIComponent.ForceDisablePickUpForAgent | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#ad8b37a8712ef6155a5aba1645f42844b)SetScriptedPositionAndDirectionTimed()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.HumanAIComponent.SetScriptedPositionAndDirectionTimed | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position*, |
|  |  | float | *directionAsRotationInRadians*, |
|  |  | float | *duration* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a24f102ba2d4fb6d7a7c10c5c472fca1e)DisableTimedScriptedMovement()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.HumanAIComponent.DisableTimedScriptedMovement | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a88162e09483f7383b8139f7ffc20c742)FormationSpeedAdjustmentEnabled
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.HumanAIComponent.FormationSpeedAdjustmentEnabled = true | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#af2a941e0cc1fbf20fcd073b27a403d2e)FollowedAgent
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) TaleWorlds.MountAndBlade.HumanAIComponent.FollowedAgent | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a19929b936fcc62fa6ae492d381b3c975)ShouldCatchUpWithFormation
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.HumanAIComponent.ShouldCatchUpWithFormation | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a64f4c73fc020907eacee8d2f0b8c1f11)IsDefending
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.HumanAIComponent.IsDefending | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a579162ef39e3f41d3ff07b4a037adb89)HasTimedScriptedFrame
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.HumanAIComponent.HasTimedScriptedFrame | | get |

