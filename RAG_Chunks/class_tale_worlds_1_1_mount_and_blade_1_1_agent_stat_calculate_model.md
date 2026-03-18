--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html ---

TaleWorlds.MountAndBlade.AgentStatCalculateModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [SandBox.GameComponents.SandboxAgentStatCalculateModel](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html), [TaleWorlds.MountAndBlade.CustomBattleAgentStatCalculateModel](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_stat_calculate_model.html), and [TaleWorlds.MountAndBlade.MultiplayerAgentStatCalculateModel](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_stat_calculate_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [InitializeAgentStats](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a0694d2618d41ff26999c7c6cc6c0ba9b) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) spawnEquipment, [AgentDrivenProperties](class_tale_worlds_1_1_mount_and_blade_1_1_agent_driven_properties.html) agentDrivenProperties, [AgentBuildData](class_tale_worlds_1_1_mount_and_blade_1_1_agent_build_data.html) agentBuildData) |
| virtual void | [InitializeMissionEquipment](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a121ebbaf2cfaccb25e8db05a8e5b0195) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| virtual void | [InitializeAgentStatsAfterDeploymentFinished](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a0b281b611684accefbe8fdda70b0ed5b) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| virtual void | [InitializeMissionEquipmentAfterDeploymentFinished](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#ab96cbddffc255dffcf140277fd29ebcf) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| void | [UpdateAgentStats](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#acf42c5901e8443f56207973c6603ed84) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [AgentDrivenProperties](class_tale_worlds_1_1_mount_and_blade_1_1_agent_driven_properties.html) agentDrivenProperties) |
| float | [GetDifficultyModifier](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a95004fbfeaa3a4d5e2991702b2c2bc65) () |
| bool | [CanAgentRideMount](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a88166bd4acc84676f4ffdede30825419) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) targetMount) |
| virtual bool | [HasHeavyArmor](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#ab1faf80907e983f1e27231b0adbe00f1) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| virtual float | [GetEffectiveArmorEncumbrance](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#ae8ae1b44c11e16d51cde7b1b61ed29b9) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) equipment) |
| virtual float | [GetEffectiveMaxHealth](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#af625f5a48fe33d7c2259c4b84e33f1b8) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
|  | Returns effective health of an agent w.r.t. mission time perks & effects. |
| virtual float | [GetEnvironmentSpeedFactor](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a55574411a9ae2f6f309f4dffc165d0e6) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
|  | Speed multiplier of the agent due to environment (w.r.t. mission time or weather effects like rain etc.). |
| float | [CalculateAIAttackOnDecideMaxValue](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a605a814cbbd67b85e7c4a70ac072ea66) () |
| virtual float | [GetWeaponInaccuracy](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a4a2622f11b9f91bf1778e226515339f0) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) weapon, int weaponSkill) |
| virtual float | [GetDetachmentCostMultiplierOfAgent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a439d9e607b98e519348a8c698f935554) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html) detachment) |
| virtual float | [GetInteractionDistance](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a841a1ee2656315ae85fdf9d0eae08303) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| virtual float | [GetMaxCameraZoom](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#ad2f18c596356a3d07e99353f3f966024) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| virtual int | [GetEffectiveSkill](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a0e6fdfe3c57660cd63e3b85f60accf12) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill) |
|  | Returns the total (effective) skill of an agent regarding any perks or effects that are applied on it during the mission. This is the same as [BasicCharacterObject.GetSkillValue()](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a42ea2bc67456fe86b090e72583a23a12) if there are no such perks or effects. |
| virtual int | [GetEffectiveSkillForWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a19db4a7f670ecd5f191a416bbef06519) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) weapon) |
| float | [GetWeaponDamageMultiplier](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#abd0481a901078339dcca774878bcb06a) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) weapon) |
| float | [GetEquipmentStealthBonus](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#ad603e987dd093851d2bd671f94748ba5) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| float | [GetSneakAttackMultiplier](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a4f5c85d65ff4ccc0810affb2a1267ece) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) weapon) |
| float | [GetKnockBackResistance](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a0d9dd7736222bb8c5213298327eeb37d) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| float | [GetKnockDownResistance](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#abc549f94e996c3290b5b2e85c4d9b719) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [StrikeType](namespace_tale_worlds_1_1_core.html#a2adc9126cb9a9e45bc133ebc57833835) strikeType=StrikeType.Invalid) |
| float | [GetDismountResistance](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a182f52839e469329b744797b0977df0a) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| float | [GetBreatheHoldMaxDuration](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#aa194e519012ce060f72a610bc8a86484) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, float baseBreatheHoldMaxDuration) |
| virtual string | [GetMissionDebugInfoForAgent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a954d2a255a779ed3c85688eaa553a678) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| void | [ResetAILevelMultiplier](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a07569bdfb942e6208ece3f2dacb28c86) () |
| void | [SetAILevelMultiplier](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a1cafb9cabc16db40d6a8b0e390377e43) (float multiplier) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| int | [GetMeleeSkill](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a0a4c859c323e4802b2d06306f708f42c) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) equippedItem, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) secondaryItem) |
| float | [CalculateAILevel](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#af04653b329ca9e5d9c70e73afaecf242) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, int relevantSkillLevel) |
| void | [SetAiRelatedProperties](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a5887ef8496b0a0402268fbe694920d56) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [AgentDrivenProperties](class_tale_worlds_1_1_mount_and_blade_1_1_agent_driven_properties.html) agentDrivenProperties, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) equippedItem, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) secondaryItem) |
| void | [SetAllWeaponInaccuracy](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a886f958c2f2c1627da1dc199f49097f9) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [AgentDrivenProperties](class_tale_worlds_1_1_mount_and_blade_1_1_agent_driven_properties.html) agentDrivenProperties, int equippedIndex, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) equippedWeaponComponent) |

|  |  |
| --- | --- |
| Static Protected Attributes | |
| const float | [MaxHorizontalErrorRadian](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a1293bf9c35f8165615cd92cce1775787) = 2f \* [MathF.DegToRad](class_tale_worlds_1_1_library_1_1_math_f.html#a940007fa7aac7553a3f08a767f78a6c1) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a0694d2618d41ff26999c7c6cc6c0ba9b)InitializeAgentStats()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.AgentStatCalculateModel.InitializeAgentStats | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) | *spawnEquipment*, | |  |  | [AgentDrivenProperties](class_tale_worlds_1_1_mount_and_blade_1_1_agent_driven_properties.html) | *agentDrivenProperties*, | |  |  | [AgentBuildData](class_tale_worlds_1_1_mount_and_blade_1_1_agent_build_data.html) | *agentBuildData* ) | | abstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a121ebbaf2cfaccb25e8db05a8e5b0195)InitializeMissionEquipment()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.AgentStatCalculateModel.InitializeMissionEquipment | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | virtual |

Reimplemented in [SandBox.GameComponents.SandboxAgentStatCalculateModel](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#a3563a1573b9eb38068c6a3660dc295c6).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a0b281b611684accefbe8fdda70b0ed5b)InitializeAgentStatsAfterDeploymentFinished()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.AgentStatCalculateModel.InitializeAgentStatsAfterDeploymentFinished | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | virtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#ab96cbddffc255dffcf140277fd29ebcf)InitializeMissionEquipmentAfterDeploymentFinished()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.AgentStatCalculateModel.InitializeMissionEquipmentAfterDeploymentFinished | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | virtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#acf42c5901e8443f56207973c6603ed84)UpdateAgentStats()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.AgentStatCalculateModel.UpdateAgentStats | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | [AgentDrivenProperties](class_tale_worlds_1_1_mount_and_blade_1_1_agent_driven_properties.html) | *agentDrivenProperties* ) | | abstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a95004fbfeaa3a4d5e2991702b2c2bc65)GetDifficultyModifier()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.AgentStatCalculateModel.GetDifficultyModifier | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a88166bd4acc84676f4ffdede30825419)CanAgentRideMount()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.AgentStatCalculateModel.CanAgentRideMount | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *targetMount* ) | | abstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#ab1faf80907e983f1e27231b0adbe00f1)HasHeavyArmor()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual bool TaleWorlds.MountAndBlade.AgentStatCalculateModel.HasHeavyArmor | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | virtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#ae8ae1b44c11e16d51cde7b1b61ed29b9)GetEffectiveArmorEncumbrance()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual float TaleWorlds.MountAndBlade.AgentStatCalculateModel.GetEffectiveArmorEncumbrance | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) | *equipment* ) | | virtual |

Reimplemented in [SandBox.GameComponents.SandboxAgentStatCalculateModel](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#a6692f0520baf213b922dc7ed46f44248).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#af625f5a48fe33d7c2259c4b84e33f1b8)GetEffectiveMaxHealth()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual float TaleWorlds.MountAndBlade.AgentStatCalculateModel.GetEffectiveMaxHealth | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | virtual |

Reimplemented in [SandBox.GameComponents.SandboxAgentStatCalculateModel](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#a6b6a8da54b6fa523f3381196a85695f4).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a55574411a9ae2f6f309f4dffc165d0e6)GetEnvironmentSpeedFactor()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual float TaleWorlds.MountAndBlade.AgentStatCalculateModel.GetEnvironmentSpeedFactor | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | virtual |

Parameters
:   |  |  |
    | --- | --- |
    | agent |  |

Returns

Reimplemented in [SandBox.GameComponents.SandboxAgentStatCalculateModel](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#aa31e841199a16d9cab35193d45faaa1e).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a605a814cbbd67b85e7c4a70ac072ea66)CalculateAIAttackOnDecideMaxValue()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.AgentStatCalculateModel.CalculateAIAttackOnDecideMaxValue | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a4a2622f11b9f91bf1778e226515339f0)GetWeaponInaccuracy()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual float TaleWorlds.MountAndBlade.AgentStatCalculateModel.GetWeaponInaccuracy | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *weapon*, | |  |  | int | *weaponSkill* ) | | virtual |

Reimplemented in [SandBox.GameComponents.SandboxAgentStatCalculateModel](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#a716f17f2556966a23ff87e1b4db82f66), and [TaleWorlds.MountAndBlade.MultiplayerAgentStatCalculateModel](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_stat_calculate_model.html#a0c43926a6a8245f733269ca780933dab).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a439d9e607b98e519348a8c698f935554)GetDetachmentCostMultiplierOfAgent()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual float TaleWorlds.MountAndBlade.AgentStatCalculateModel.GetDetachmentCostMultiplierOfAgent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | [IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html) | *detachment* ) | | virtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a841a1ee2656315ae85fdf9d0eae08303)GetInteractionDistance()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual float TaleWorlds.MountAndBlade.AgentStatCalculateModel.GetInteractionDistance | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | virtual |

Reimplemented in [SandBox.GameComponents.SandboxAgentStatCalculateModel](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#a2facdf51535f12b5dc7e2a02eb8a3fdf).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#ad2f18c596356a3d07e99353f3f966024)GetMaxCameraZoom()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual float TaleWorlds.MountAndBlade.AgentStatCalculateModel.GetMaxCameraZoom | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | virtual |

Reimplemented in [SandBox.GameComponents.SandboxAgentStatCalculateModel](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#aeb59fdc3affab35d64c88174a66e54df).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a0e6fdfe3c57660cd63e3b85f60accf12)GetEffectiveSkill()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual int TaleWorlds.MountAndBlade.AgentStatCalculateModel.GetEffectiveSkill | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill* ) | | virtual |

Parameters
:   |  |  |
    | --- | --- |
    | agent |  |
    | skill |  |

Returns

Reimplemented in [SandBox.GameComponents.SandboxAgentStatCalculateModel](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#ae69147723ff1dee7706c64cf1811d242).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a19db4a7f670ecd5f191a416bbef06519)GetEffectiveSkillForWeapon()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual int TaleWorlds.MountAndBlade.AgentStatCalculateModel.GetEffectiveSkillForWeapon | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *weapon* ) | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.MultiplayerAgentStatCalculateModel](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_stat_calculate_model.html#aa8012ad477bc391aca1e76b4e81bc416).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#abd0481a901078339dcca774878bcb06a)GetWeaponDamageMultiplier()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.AgentStatCalculateModel.GetWeaponDamageMultiplier | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *weapon* ) | | abstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#ad603e987dd093851d2bd671f94748ba5)GetEquipmentStealthBonus()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.AgentStatCalculateModel.GetEquipmentStealthBonus | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a4f5c85d65ff4ccc0810affb2a1267ece)GetSneakAttackMultiplier()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.AgentStatCalculateModel.GetSneakAttackMultiplier | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *weapon* ) | | abstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a0d9dd7736222bb8c5213298327eeb37d)GetKnockBackResistance()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.AgentStatCalculateModel.GetKnockBackResistance | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#abc549f94e996c3290b5b2e85c4d9b719)GetKnockDownResistance()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.AgentStatCalculateModel.GetKnockDownResistance | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | [StrikeType](namespace_tale_worlds_1_1_core.html#a2adc9126cb9a9e45bc133ebc57833835) | *strikeType* = StrikeType.Invalid ) | | abstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a182f52839e469329b744797b0977df0a)GetDismountResistance()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.AgentStatCalculateModel.GetDismountResistance | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#aa194e519012ce060f72a610bc8a86484)GetBreatheHoldMaxDuration()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.AgentStatCalculateModel.GetBreatheHoldMaxDuration | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | float | *baseBreatheHoldMaxDuration* ) | | abstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a954d2a255a779ed3c85688eaa553a678)GetMissionDebugInfoForAgent()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual string TaleWorlds.MountAndBlade.AgentStatCalculateModel.GetMissionDebugInfoForAgent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | virtual |

Reimplemented in [SandBox.GameComponents.SandboxAgentStatCalculateModel](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#a58d3513f1d7d41d8f7cc55fed0cf67d3).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a07569bdfb942e6208ece3f2dacb28c86)ResetAILevelMultiplier()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.AgentStatCalculateModel.ResetAILevelMultiplier | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a1cafb9cabc16db40d6a8b0e390377e43)SetAILevelMultiplier()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.AgentStatCalculateModel.SetAILevelMultiplier | ( | float | *multiplier* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a0a4c859c323e4802b2d06306f708f42c)GetMeleeSkill()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.AgentStatCalculateModel.GetMeleeSkill | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *equippedItem*, | |  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *secondaryItem* ) | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#af04653b329ca9e5d9c70e73afaecf242)CalculateAILevel()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.AgentStatCalculateModel.CalculateAILevel | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | int | *relevantSkillLevel* ) | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a5887ef8496b0a0402268fbe694920d56)SetAiRelatedProperties()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.AgentStatCalculateModel.SetAiRelatedProperties | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | [AgentDrivenProperties](class_tale_worlds_1_1_mount_and_blade_1_1_agent_driven_properties.html) | *agentDrivenProperties*, | |  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *equippedItem*, | |  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *secondaryItem* ) | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a886f958c2f2c1627da1dc199f49097f9)SetAllWeaponInaccuracy()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.AgentStatCalculateModel.SetAllWeaponInaccuracy | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | [AgentDrivenProperties](class_tale_worlds_1_1_mount_and_blade_1_1_agent_driven_properties.html) | *agentDrivenProperties*, | |  |  | int | *equippedIndex*, | |  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *equippedWeaponComponent* ) | | protected |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a1293bf9c35f8165615cd92cce1775787)MaxHorizontalErrorRadian
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.AgentStatCalculateModel.MaxHorizontalErrorRadian = 2f \* [MathF.DegToRad](class_tale_worlds_1_1_library_1_1_math_f.html#a940007fa7aac7553a3f08a767f78a6c1) | | staticprotected |

