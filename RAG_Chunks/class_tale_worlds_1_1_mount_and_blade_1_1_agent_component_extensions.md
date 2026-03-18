--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html ---

TaleWorlds.MountAndBlade.AgentComponentExtensions Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static float | [GetMorale](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#a24c9d6e3c0cae4d034d8c84aa6633107) (this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| static void | [SetMorale](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#a6730ad44ade588de4e29780025fadd8d) (this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, float morale) |
| static void | [ChangeMorale](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#a7251384a5313868d69c1bba2e5ddb120) (this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, float delta) |
| static bool | [IsRetreating](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#a9cb8911f1317b139dcb6f8f0e39e18a7) (this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, bool isComponentAssured=true) |
| static void | [Retreat](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#ad08f234a453c163e2aae4f9fa659dc33) (this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, bool useCachingSystem=false) |
| static void | [StopRetreatingMoraleComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#ac8f7d82edcdbab5ef5d299b4e4e88c1d) (this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| static void | [SetBehaviorValueSet](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#aab08dc58fa247df41e99b8dd2394bdcf) (this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [HumanAIComponent.BehaviorValueSet](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a43eff3d9dfd7c2f47aadcc748c7d3346) behaviorValueSet) |
| static void | [RefreshBehaviorValues](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#a72af11359797851f7da8324ce5d1ba3a) (this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [MovementOrder.MovementOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a76e586c5e2ab511f2c81b00ad8059d95) movementOrder, [ArrangementOrder.ArrangementOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280) arrangementOrder) |
| static void | [SetAIBehaviorValues](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#a78d4bee57e30a6fcd9424c9cdf11a8de) (this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [HumanAIComponent.AISimpleBehaviorKind](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#af5bb0a806d07de4fe21691beca41b4f4) behavior, float y1, float x2, float y2, float x3, float y3) |
| static void | [AIMoveToGameObjectEnable](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#aeab134eaa10ed0e396a547b4e7a8f86e) (this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) usedObject, [IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html) detachment, [Agent.AIScriptedFrameFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0) scriptedFrameFlags=[Agent.AIScriptedFrameFlags.NoAttack](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0afd717fc56e019faf5bdeb3429d6eb17d)) |
| static void | [AIMoveToGameObjectDisable](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#aa6acd70896e7e45aebcc2e583182a8fc) (this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| static bool | [AIMoveToGameObjectIsEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#a7563968b020830a22f76011b1cd0d967) (this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| static void | [AIDefendGameObjectEnable](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#a6bccceb39fbe2df05e83059276a999af) (this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) usedObject, [IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html) detachment) |
| static void | [AIDefendGameObjectDisable](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#a666f330301cdda2da4daf089d87dfa67) (this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| static bool | [AIDefendGameObjectIsEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#a4b7022349af07f05c7eaf6b049749351) (this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| static bool | [AIInterestedInAnyGameObject](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#a11f578ad0047ac9df044d229c775658e) (this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| static bool | [AIInterestedInGameObject](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#a2b00987f681f85b7b332047d2f731672) (this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) usableMissionObject) |
| static void | [AIUseGameObjectEnable](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#a82c8f59ed1376a3a61b7641881a9077e) (this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| static void | [AIUseGameObjectDisable](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#a547fcefffd6d7ee195264a5e0f5148a1) (this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| static bool | [AIUseGameObjectIsEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#a26d59a6439e6b62bd06823d682f66e8e) (this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| static [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [GetFollowedUnit](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#ae4790beebe689e434a2785f201c8dc4c) (this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| static void | [SetFollowedUnit](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#ace5f53aad291b6b4a1638c108efa9e98) (this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) followedUnit) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#a24c9d6e3c0cae4d034d8c84aa6633107)GetMorale()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.AgentComponentExtensions.GetMorale | ( | this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#a6730ad44ade588de4e29780025fadd8d)SetMorale()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.AgentComponentExtensions.SetMorale | ( | this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | float | *morale* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#a7251384a5313868d69c1bba2e5ddb120)ChangeMorale()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.AgentComponentExtensions.ChangeMorale | ( | this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | float | *delta* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#a9cb8911f1317b139dcb6f8f0e39e18a7)IsRetreating()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.AgentComponentExtensions.IsRetreating | ( | this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | bool | *isComponentAssured* = true ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#ad08f234a453c163e2aae4f9fa659dc33)Retreat()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.AgentComponentExtensions.Retreat | ( | this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | bool | *useCachingSystem* = false ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#ac8f7d82edcdbab5ef5d299b4e4e88c1d)StopRetreatingMoraleComponent()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.AgentComponentExtensions.StopRetreatingMoraleComponent | ( | this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#aab08dc58fa247df41e99b8dd2394bdcf)SetBehaviorValueSet()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.AgentComponentExtensions.SetBehaviorValueSet | ( | this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | [HumanAIComponent.BehaviorValueSet](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a43eff3d9dfd7c2f47aadcc748c7d3346) | *behaviorValueSet* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#a72af11359797851f7da8324ce5d1ba3a)RefreshBehaviorValues()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.AgentComponentExtensions.RefreshBehaviorValues | ( | this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | [MovementOrder.MovementOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a76e586c5e2ab511f2c81b00ad8059d95) | *movementOrder*, | |  |  | [ArrangementOrder.ArrangementOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280) | *arrangementOrder* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#a78d4bee57e30a6fcd9424c9cdf11a8de)SetAIBehaviorValues()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.AgentComponentExtensions.SetAIBehaviorValues | ( | this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | [HumanAIComponent.AISimpleBehaviorKind](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#af5bb0a806d07de4fe21691beca41b4f4) | *behavior*, | |  |  | float | *y1*, | |  |  | float | *x2*, | |  |  | float | *y2*, | |  |  | float | *x3*, | |  |  | float | *y3* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#aeab134eaa10ed0e396a547b4e7a8f86e)AIMoveToGameObjectEnable()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.AgentComponentExtensions.AIMoveToGameObjectEnable | ( | this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | [UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) | *usedObject*, | |  |  | [IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html) | *detachment*, | |  |  | [Agent.AIScriptedFrameFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0) | *scriptedFrameFlags* = [Agent::AIScriptedFrameFlags::NoAttack](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0afd717fc56e019faf5bdeb3429d6eb17d) ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#aa6acd70896e7e45aebcc2e583182a8fc)AIMoveToGameObjectDisable()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.AgentComponentExtensions.AIMoveToGameObjectDisable | ( | this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#a7563968b020830a22f76011b1cd0d967)AIMoveToGameObjectIsEnabled()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.AgentComponentExtensions.AIMoveToGameObjectIsEnabled | ( | this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#a6bccceb39fbe2df05e83059276a999af)AIDefendGameObjectEnable()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.AgentComponentExtensions.AIDefendGameObjectEnable | ( | this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | [UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) | *usedObject*, | |  |  | [IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html) | *detachment* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#a666f330301cdda2da4daf089d87dfa67)AIDefendGameObjectDisable()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.AgentComponentExtensions.AIDefendGameObjectDisable | ( | this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#a4b7022349af07f05c7eaf6b049749351)AIDefendGameObjectIsEnabled()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.AgentComponentExtensions.AIDefendGameObjectIsEnabled | ( | this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#a11f578ad0047ac9df044d229c775658e)AIInterestedInAnyGameObject()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.AgentComponentExtensions.AIInterestedInAnyGameObject | ( | this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#a2b00987f681f85b7b332047d2f731672)AIInterestedInGameObject()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.AgentComponentExtensions.AIInterestedInGameObject | ( | this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | [UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) | *usableMissionObject* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#a82c8f59ed1376a3a61b7641881a9077e)AIUseGameObjectEnable()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.AgentComponentExtensions.AIUseGameObjectEnable | ( | this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#a547fcefffd6d7ee195264a5e0f5148a1)AIUseGameObjectDisable()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.AgentComponentExtensions.AIUseGameObjectDisable | ( | this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#a26d59a6439e6b62bd06823d682f66e8e)AIUseGameObjectIsEnabled()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.AgentComponentExtensions.AIUseGameObjectIsEnabled | ( | this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#ae4790beebe689e434a2785f201c8dc4c)GetFollowedUnit()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) TaleWorlds.MountAndBlade.AgentComponentExtensions.GetFollowedUnit | ( | this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component_extensions.html#ace5f53aad291b6b4a1638c108efa9e98)SetFollowedUnit()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.AgentComponentExtensions.SetFollowedUnit | ( | this [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *followedUnit* ) | | static |

