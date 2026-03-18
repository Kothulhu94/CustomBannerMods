--- SOURCE: class_sand_box_1_1_agent_navigator.html ---

SandBox.AgentNavigator Class Referencesealed|  |  |
| --- | --- |
| Public Types | |
| enum | [NavigationState](class_sand_box_1_1_agent_navigator.html#ab33251d42863096e3c2f024404562333) {     [NoTarget](class_sand_box_1_1_agent_navigator.html#ab33251d42863096e3c2f024404562333aff4d8f7b051f09ecae01888dda54c15c) ,     [GoToTarget](class_sand_box_1_1_agent_navigator.html#ab33251d42863096e3c2f024404562333af8e014b9930df69c62108f774928d652) ,     [AtTargetPosition](class_sand_box_1_1_agent_navigator.html#ab33251d42863096e3c2f024404562333a52c3326e50c74b37f12607a0f9d37b5e) ,     [UseMachine](class_sand_box_1_1_agent_navigator.html#ab33251d42863096e3c2f024404562333a57f9eaa82f0bb689590138dae4032943)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [AgentNavigator](class_sand_box_1_1_agent_navigator.html#a3350b0cee82662815aa45ec0bb20f1e3) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) locationCharacter) |
|  | [AgentNavigator](class_sand_box_1_1_agent_navigator.html#ac2679d0683386dba85c60ba3dd0e1d08) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| void | [OnStopUsingGameObject](class_sand_box_1_1_agent_navigator.html#a006a22fb026f6de28c5da0433f7d5a50) () |
| void | [OnAgentRemoved](class_sand_box_1_1_agent_navigator.html#ab0cc71c9ecc8d5b6d368357e42a9480a) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| void | [SetTarget](class_sand_box_1_1_agent_navigator.html#a45e885c45cd5506ff11774ed6c9c0a94) ([UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) usableMachine, bool isInitialTarget=false, Agent.AIScriptedFrameFlags customFlags=Agent.AIScriptedFrameFlags.None) |
| void | [SetTargetFrame](class_sand_box_1_1_agent_navigator.html#a16489cc3ba2ae9ed429067535a0d1c1f) ([WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) position, float rotation, float rangeThreshold=1.0f, float rotationThreshold=-10.0f, Agent.AIScriptedFrameFlags flags=Agent.AIScriptedFrameFlags.None, bool disableClearTargetWhenTargetIsReached=false) |
| void | [ClearTarget](class_sand_box_1_1_agent_navigator.html#af212f9d57a5ab5996f7e6b01d94d9051) () |
| void | [Tick](class_sand_box_1_1_agent_navigator.html#a048687acda9cf08ffbe3a42d10cb6f0d) (float dt, bool isSimulation=false) |
| float | [GetDistanceToTarget](class_sand_box_1_1_agent_navigator.html#a1110f18d5f96b381d264c268c1b6d63a) ([UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) target) |
| bool | [IsTargetReached](class_sand_box_1_1_agent_navigator.html#a09e4f3e2e21d3441d2793eafbf1b15b9) () |
| void | [HoldAndHideRecentlyUsedMeshes](class_sand_box_1_1_agent_navigator.html#a0a5649e2459dd3c19db239dd8cc5105b) () |
| void | [RecoverRecentlyUsedMeshes](class_sand_box_1_1_agent_navigator.html#aabe67017686bf12e2578ca5b8cb09c20) () |
| bool | [CanSeeAgent](class_sand_box_1_1_agent_navigator.html#aaaf1e5c7f59535da8aef039391b65d25) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) otherAgent) |
| bool | [IsCarryingSomething](class_sand_box_1_1_agent_navigator.html#ab0ffa544c0feac0b0a8aac5b35336a68) () |
| void | [SetPrefabVisibility](class_sand_box_1_1_agent_navigator.html#afa520f3fe8865fec76cd33eda8c970b3) (sbyte realBoneIndex, string prefabName, bool isVisible) |
| bool | [GetPrefabVisibility](class_sand_box_1_1_agent_navigator.html#a2e58c62c7ee7764dd33840f7c00eafc7) (sbyte realBoneIndex, string prefabName) |
| void | [SetSpecialItem](class_sand_box_1_1_agent_navigator.html#a7866850c4aaa9a58e0c609f81269809e) () |
| void | [SetItemsVisibility](class_sand_box_1_1_agent_navigator.html#adef6c87f47cedb941ab5ad8899f935c6) (bool isVisible) |
| void | [SetCommonArea](class_sand_box_1_1_agent_navigator.html#abe18b10bbbf01395bba6125ea02abd54) ([Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) alley) |
| void | [ForceThink](class_sand_box_1_1_agent_navigator.html#a3637022fcdf960bd86509f12738a0397) (float inSeconds) |
| T | [AddBehaviorGroup< T >](class_sand_box_1_1_agent_navigator.html#a66f1c07dc833a59e95f628028fba5309) () |
| T | [GetBehaviorGroup< T >](class_sand_box_1_1_agent_navigator.html#a3f10ce8d702e91f051a2f324bfb41fe2) () |
| [AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html) | [GetBehavior< T >](class_sand_box_1_1_agent_navigator.html#a31489cb4b8634ab3010acb6d40f7f27b) () |
| bool | [HasBehaviorGroup< T >](class_sand_box_1_1_agent_navigator.html#a12b39f11b4371beae8137b65b1e4eeee) () |
| void | [RemoveBehaviorGroup< T >](class_sand_box_1_1_agent_navigator.html#a92b6efcea7ffbcf7d437bb77043a2823) () |
| void | [RefreshBehaviorGroups](class_sand_box_1_1_agent_navigator.html#ad2d65d72a2a687c7c1d078e878903571) (bool isSimulation) |
| [AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html) | [GetActiveBehavior](class_sand_box_1_1_agent_navigator.html#ab0dc54ef0bfd602af529e978af7fbb17) () |
| [AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html) | [GetActiveBehaviorGroup](class_sand_box_1_1_agent_navigator.html#a18d1a979612395e5afbf81b9e794cbfe) () |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [OwnerAgent](class_sand_box_1_1_agent_navigator.html#a08e5338315a2e0a1b5eeb12fc1c7b016) |

|  |  |
| --- | --- |
| Properties | |
| [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) | [TargetUsableMachine](class_sand_box_1_1_agent_navigator.html#a1cfa16b0bdc08b98324e216cc6e38d78) `[get]` |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | [TargetPosition](class_sand_box_1_1_agent_navigator.html#a3e1a541e1e60dd6777f7d3e255616a5f) `[get]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [TargetDirection](class_sand_box_1_1_agent_navigator.html#aed1941dd37cc63e5c7ea2b37da0c5055) `[get]` |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [TargetEntity](class_sand_box_1_1_agent_navigator.html#a03013aa20559e6e7e5ca3382db28abea) `[get]` |
| [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | [MemberOfAlley](class_sand_box_1_1_agent_navigator.html#a962055305b3ae3c096efd90cd56d79e7) `[get]` |
| string | [SpecialTargetTag](class_sand_box_1_1_agent_navigator.html#a93a142b13f5fda3440e0728ad9c7eb4e) `[get, set]` |
| [NavigationState](class_sand_box_1_1_agent_navigator.html#ab33251d42863096e3c2f024404562333) | [\_agentState](class_sand_box_1_1_agent_navigator.html#adb7388396d3490800bc643702b758b08) `[get]` |
| bool | [CharacterHasVisiblePrefabs](class_sand_box_1_1_agent_navigator.html#a6a5225ea4d99135406e85447189c44d2) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_sand_box_1_1_agent_navigator.html#ab33251d42863096e3c2f024404562333)NavigationState
---------------------------------------------------------------------------------------------

|  |
| --- |
| enum [SandBox.AgentNavigator.NavigationState](class_sand_box_1_1_agent_navigator.html#ab33251d42863096e3c2f024404562333) |

| Enumerator | |
| --- | --- |
| NoTarget |  |
| GoToTarget |  |
| AtTargetPosition |  |
| UseMachine |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_agent_navigator.html#a3350b0cee82662815aa45ec0bb20f1e3)AgentNavigator() [1/2]
----------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| SandBox.AgentNavigator.AgentNavigator | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) | *locationCharacter* ) |

[◆](class_sand_box_1_1_agent_navigator.html#ac2679d0683386dba85c60ba3dd0e1d08)AgentNavigator() [2/2]
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| SandBox.AgentNavigator.AgentNavigator | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_agent_navigator.html#a006a22fb026f6de28c5da0433f7d5a50)OnStopUsingGameObject()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.AgentNavigator.OnStopUsingGameObject | ( |  | ) |  |

[◆](class_sand_box_1_1_agent_navigator.html#ab0cc71c9ecc8d5b6d368357e42a9480a)OnAgentRemoved()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.AgentNavigator.OnAgentRemoved | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](class_sand_box_1_1_agent_navigator.html#a45e885c45cd5506ff11774ed6c9c0a94)SetTarget()
-----------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.AgentNavigator.SetTarget | ( | [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) | *usableMachine*, |
|  |  | bool | *isInitialTarget* = false, |
|  |  | Agent.AIScriptedFrameFlags | *customFlags* = Agent::AIScriptedFrameFlags::None ) |

[◆](class_sand_box_1_1_agent_navigator.html#a16489cc3ba2ae9ed429067535a0d1c1f)SetTargetFrame()
----------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.AgentNavigator.SetTargetFrame | ( | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *position*, |
|  |  | float | *rotation*, |
|  |  | float | *rangeThreshold* = 1::0f, |
|  |  | float | *rotationThreshold* = -10::0f, |
|  |  | Agent.AIScriptedFrameFlags | *flags* = Agent::AIScriptedFrameFlags::None, |
|  |  | bool | *disableClearTargetWhenTargetIsReached* = false ) |

[◆](class_sand_box_1_1_agent_navigator.html#af212f9d57a5ab5996f7e6b01d94d9051)ClearTarget()
-------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.AgentNavigator.ClearTarget | ( |  | ) |  |

[◆](class_sand_box_1_1_agent_navigator.html#a048687acda9cf08ffbe3a42d10cb6f0d)Tick()
------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.AgentNavigator.Tick | ( | float | *dt*, |
|  |  | bool | *isSimulation* = false ) |

[◆](class_sand_box_1_1_agent_navigator.html#a1110f18d5f96b381d264c268c1b6d63a)GetDistanceToTarget()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float SandBox.AgentNavigator.GetDistanceToTarget | ( | [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) | *target* | ) |  |

[◆](class_sand_box_1_1_agent_navigator.html#a09e4f3e2e21d3441d2793eafbf1b15b9)IsTargetReached()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool SandBox.AgentNavigator.IsTargetReached | ( |  | ) |  |

[◆](class_sand_box_1_1_agent_navigator.html#a0a5649e2459dd3c19db239dd8cc5105b)HoldAndHideRecentlyUsedMeshes()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.AgentNavigator.HoldAndHideRecentlyUsedMeshes | ( |  | ) |  |

[◆](class_sand_box_1_1_agent_navigator.html#aabe67017686bf12e2578ca5b8cb09c20)RecoverRecentlyUsedMeshes()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.AgentNavigator.RecoverRecentlyUsedMeshes | ( |  | ) |  |

[◆](class_sand_box_1_1_agent_navigator.html#aaaf1e5c7f59535da8aef039391b65d25)CanSeeAgent()
-------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool SandBox.AgentNavigator.CanSeeAgent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *otherAgent* | ) |  |

[◆](class_sand_box_1_1_agent_navigator.html#ab0ffa544c0feac0b0a8aac5b35336a68)IsCarryingSomething()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool SandBox.AgentNavigator.IsCarryingSomething | ( |  | ) |  |

[◆](class_sand_box_1_1_agent_navigator.html#afa520f3fe8865fec76cd33eda8c970b3)SetPrefabVisibility()
---------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.AgentNavigator.SetPrefabVisibility | ( | sbyte | *realBoneIndex*, |
|  |  | string | *prefabName*, |
|  |  | bool | *isVisible* ) |

[◆](class_sand_box_1_1_agent_navigator.html#a2e58c62c7ee7764dd33840f7c00eafc7)GetPrefabVisibility()
---------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool SandBox.AgentNavigator.GetPrefabVisibility | ( | sbyte | *realBoneIndex*, |
|  |  | string | *prefabName* ) |

[◆](class_sand_box_1_1_agent_navigator.html#a7866850c4aaa9a58e0c609f81269809e)SetSpecialItem()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.AgentNavigator.SetSpecialItem | ( |  | ) |  |

[◆](class_sand_box_1_1_agent_navigator.html#adef6c87f47cedb941ab5ad8899f935c6)SetItemsVisibility()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.AgentNavigator.SetItemsVisibility | ( | bool | *isVisible* | ) |  |

[◆](class_sand_box_1_1_agent_navigator.html#abe18b10bbbf01395bba6125ea02abd54)SetCommonArea()
---------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.AgentNavigator.SetCommonArea | ( | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | *alley* | ) |  |

[◆](class_sand_box_1_1_agent_navigator.html#a3637022fcdf960bd86509f12738a0397)ForceThink()
------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.AgentNavigator.ForceThink | ( | float | *inSeconds* | ) |  |

[◆](class_sand_box_1_1_agent_navigator.html#a66f1c07dc833a59e95f628028fba5309)AddBehaviorGroup< T >()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| T SandBox.AgentNavigator.AddBehaviorGroup< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *AgentBehaviorGroup* |  |

[◆](class_sand_box_1_1_agent_navigator.html#a3f10ce8d702e91f051a2f324bfb41fe2)GetBehaviorGroup< T >()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| T SandBox.AgentNavigator.GetBehaviorGroup< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *AgentBehaviorGroup* |  |

[◆](class_sand_box_1_1_agent_navigator.html#a31489cb4b8634ab3010acb6d40f7f27b)GetBehavior< T >()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html) SandBox.AgentNavigator.GetBehavior< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *AgentBehavior* |  |

[◆](class_sand_box_1_1_agent_navigator.html#a12b39f11b4371beae8137b65b1e4eeee)HasBehaviorGroup< T >()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool SandBox.AgentNavigator.HasBehaviorGroup< T > | ( |  | ) |  |

[◆](class_sand_box_1_1_agent_navigator.html#a92b6efcea7ffbcf7d437bb77043a2823)RemoveBehaviorGroup< T >()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.AgentNavigator.RemoveBehaviorGroup< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *AgentBehaviorGroup* |  |

[◆](class_sand_box_1_1_agent_navigator.html#ad2d65d72a2a687c7c1d078e878903571)RefreshBehaviorGroups()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.AgentNavigator.RefreshBehaviorGroups | ( | bool | *isSimulation* | ) |  |

[◆](class_sand_box_1_1_agent_navigator.html#ab0dc54ef0bfd602af529e978af7fbb17)GetActiveBehavior()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html) SandBox.AgentNavigator.GetActiveBehavior | ( |  | ) |  |

[◆](class_sand_box_1_1_agent_navigator.html#a18d1a979612395e5afbf81b9e794cbfe)GetActiveBehaviorGroup()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html) SandBox.AgentNavigator.GetActiveBehaviorGroup | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_agent_navigator.html#a08e5338315a2e0a1b5eeb12fc1c7b016)OwnerAgent
----------------------------------------------------------------------------------------

|  |
| --- |
| readonly [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) SandBox.AgentNavigator.OwnerAgent |

Property Documentation
----------------------

[◆](class_sand_box_1_1_agent_navigator.html#a1cfa16b0bdc08b98324e216cc6e38d78)TargetUsableMachine
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) SandBox.AgentNavigator.TargetUsableMachine | | get |

[◆](class_sand_box_1_1_agent_navigator.html#a3e1a541e1e60dd6777f7d3e255616a5f)TargetPosition
--------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) SandBox.AgentNavigator.TargetPosition | | get |

[◆](class_sand_box_1_1_agent_navigator.html#aed1941dd37cc63e5c7ea2b37da0c5055)TargetDirection
---------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) SandBox.AgentNavigator.TargetDirection | | get |

[◆](class_sand_box_1_1_agent_navigator.html#a03013aa20559e6e7e5ca3382db28abea)TargetEntity
------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) SandBox.AgentNavigator.TargetEntity | | get |

[◆](class_sand_box_1_1_agent_navigator.html#a962055305b3ae3c096efd90cd56d79e7)MemberOfAlley
-------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) SandBox.AgentNavigator.MemberOfAlley | | get |

[◆](class_sand_box_1_1_agent_navigator.html#a93a142b13f5fda3440e0728ad9c7eb4e)SpecialTargetTag
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.AgentNavigator.SpecialTargetTag | | getset |

[◆](class_sand_box_1_1_agent_navigator.html#adb7388396d3490800bc643702b758b08)\_agentState
------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [NavigationState](class_sand_box_1_1_agent_navigator.html#ab33251d42863096e3c2f024404562333) SandBox.AgentNavigator.\_agentState | | get |

[◆](class_sand_box_1_1_agent_navigator.html#a6a5225ea4d99135406e85447189c44d2)CharacterHasVisiblePrefabs
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.AgentNavigator.CharacterHasVisiblePrefabs | | get |

