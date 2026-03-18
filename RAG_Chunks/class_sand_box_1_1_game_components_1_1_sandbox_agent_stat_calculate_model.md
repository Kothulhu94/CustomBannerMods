--- SOURCE: class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html ---

SandBox.GameComponents.SandboxAgentStatCalculateModel Class ReferenceInherits [TaleWorlds.MountAndBlade.AgentStatCalculateModel](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override float | [GetDifficultyModifier](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#afe165cfc08658fb058516870c8c240c2) () |
| override bool | [CanAgentRideMount](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#a46072801d10259d1c3d8df2b648a9242) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) targetMount) |
| override void | [InitializeAgentStats](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#a27d41a9723b196b981ab5a2e8fbb9297) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) spawnEquipment, [AgentDrivenProperties](class_tale_worlds_1_1_mount_and_blade_1_1_agent_driven_properties.html) agentDrivenProperties, [AgentBuildData](class_tale_worlds_1_1_mount_and_blade_1_1_agent_build_data.html) agentBuildData) |
| override void | [InitializeMissionEquipment](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#a3563a1573b9eb38068c6a3660dc295c6) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| override void | [UpdateAgentStats](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#a5c3b9e33b4510eba3278219f73b9eb62) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [AgentDrivenProperties](class_tale_worlds_1_1_mount_and_blade_1_1_agent_driven_properties.html) agentDrivenProperties) |
| override int | [GetEffectiveSkill](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#ae69147723ff1dee7706c64cf1811d242) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill) |
|  | Returns the total (effective) skill of an agent regarding any perks or effects that are applied on it during the mission. This is the same as [BasicCharacterObject.GetSkillValue()](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a42ea2bc67456fe86b090e72583a23a12) if there are no such perks or effects. |
| override float | [GetWeaponDamageMultiplier](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#a5ad6a489e86ab958d1fc6713f55d68f6) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) weapon) |
| override float | [GetEquipmentStealthBonus](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#a8bf61ee0045ee750c89e0390fd27193f) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| override float | [GetSneakAttackMultiplier](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#a2b4a8f7a77735bbb787a824cf8e464a9) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) weapon) |
| override float | [GetKnockBackResistance](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#a939ae0d58fda31681000945f5598269e) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| override float | [GetKnockDownResistance](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#a70bf071ae6e89450f2cadd750e5413e6) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [StrikeType](namespace_tale_worlds_1_1_core.html#a2adc9126cb9a9e45bc133ebc57833835) strikeType=StrikeType.Invalid) |
| override float | [GetDismountResistance](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#a82a8cdf29da747a53fd72f21d0bc798b) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| override float | [GetBreatheHoldMaxDuration](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#a8f8164f6a274b237284fde79bdccd902) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, float baseBreatheHoldMaxDuration) |
| override float | [GetWeaponInaccuracy](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#a716f17f2556966a23ff87e1b4db82f66) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) weapon, int weaponSkill) |
| override float | [GetInteractionDistance](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#a2facdf51535f12b5dc7e2a02eb8a3fdf) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| override float | [GetMaxCameraZoom](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#aeb59fdc3affab35d64c88174a66e54df) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| List< [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) > | [GetPerksOfAgent](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#ade7663717e0f4fab7b9df1c087ed8f24) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) agentCharacter, [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill=null, bool filterPartyRole=false, [PartyRole](namespace_tale_worlds_1_1_campaign_system.html#af60f394cea2e7c527bf1950e31fd13cf) partyRole=PartyRole.Personal) |
| override string | [GetMissionDebugInfoForAgent](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#a58d3513f1d7d41d8f7cc55fed0cf67d3) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| override float | [GetEffectiveArmorEncumbrance](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#a6692f0520baf213b922dc7ed46f44248) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) equipment) |
| override float | [GetEffectiveMaxHealth](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#a6b6a8da54b6fa523f3381196a85695f4) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
|  | Returns effective health of an agent w.r.t. mission time perks & effects. |
| override float | [GetEnvironmentSpeedFactor](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#aa31e841199a16d9cab35193d45faaa1e) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
|  | Speed multiplier of the agent due to environment (w.r.t. mission time or weather effects like rain etc.). |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.AgentStatCalculateModel](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html) | |
| void | [InitializeAgentStats](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a0694d2618d41ff26999c7c6cc6c0ba9b) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) spawnEquipment, [AgentDrivenProperties](class_tale_worlds_1_1_mount_and_blade_1_1_agent_driven_properties.html) agentDrivenProperties, [AgentBuildData](class_tale_worlds_1_1_mount_and_blade_1_1_agent_build_data.html) agentBuildData) |
| virtual void | [InitializeAgentStatsAfterDeploymentFinished](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a0b281b611684accefbe8fdda70b0ed5b) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| virtual void | [InitializeMissionEquipmentAfterDeploymentFinished](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#ab96cbddffc255dffcf140277fd29ebcf) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| void | [UpdateAgentStats](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#acf42c5901e8443f56207973c6603ed84) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [AgentDrivenProperties](class_tale_worlds_1_1_mount_and_blade_1_1_agent_driven_properties.html) agentDrivenProperties) |
| float | [GetDifficultyModifier](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a95004fbfeaa3a4d5e2991702b2c2bc65) () |
| bool | [CanAgentRideMount](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a88166bd4acc84676f4ffdede30825419) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) targetMount) |
| virtual bool | [HasHeavyArmor](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#ab1faf80907e983f1e27231b0adbe00f1) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| float | [CalculateAIAttackOnDecideMaxValue](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a605a814cbbd67b85e7c4a70ac072ea66) () |
| virtual float | [GetDetachmentCostMultiplierOfAgent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a439d9e607b98e519348a8c698f935554) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html) detachment) |
| virtual int | [GetEffectiveSkillForWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a19db4a7f670ecd5f191a416bbef06519) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) weapon) |
| float | [GetWeaponDamageMultiplier](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#abd0481a901078339dcca774878bcb06a) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) weapon) |
| float | [GetEquipmentStealthBonus](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#ad603e987dd093851d2bd671f94748ba5) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| float | [GetSneakAttackMultiplier](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a4f5c85d65ff4ccc0810affb2a1267ece) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) weapon) |
| float | [GetKnockBackResistance](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a0d9dd7736222bb8c5213298327eeb37d) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| float | [GetKnockDownResistance](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#abc549f94e996c3290b5b2e85c4d9b719) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [StrikeType](namespace_tale_worlds_1_1_core.html#a2adc9126cb9a9e45bc133ebc57833835) strikeType=StrikeType.Invalid) |
| float | [GetDismountResistance](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a182f52839e469329b744797b0977df0a) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| float | [GetBreatheHoldMaxDuration](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#aa194e519012ce060f72a610bc8a86484) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, float baseBreatheHoldMaxDuration) |
| void | [ResetAILevelMultiplier](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a07569bdfb942e6208ece3f2dacb28c86) () |
| void | [SetAILevelMultiplier](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a1cafb9cabc16db40d6a8b0e390377e43) (float multiplier) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static float | [CalculateMaximumSpeedMultiplier](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#ad03b5ca410b9d24cfb4368bbdd71a195) (int athletics, float baseWeight, float totalEncumbrance) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.AgentStatCalculateModel](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html) | |
| int | [GetMeleeSkill](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a0a4c859c323e4802b2d06306f708f42c) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) equippedItem, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) secondaryItem) |
| float | [CalculateAILevel](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#af04653b329ca9e5d9c70e73afaecf242) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, int relevantSkillLevel) |
| void | [SetAiRelatedProperties](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a5887ef8496b0a0402268fbe694920d56) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [AgentDrivenProperties](class_tale_worlds_1_1_mount_and_blade_1_1_agent_driven_properties.html) agentDrivenProperties, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) equippedItem, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) secondaryItem) |
| void | [SetAllWeaponInaccuracy](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a886f958c2f2c1627da1dc199f49097f9) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [AgentDrivenProperties](class_tale_worlds_1_1_mount_and_blade_1_1_agent_driven_properties.html) agentDrivenProperties, int equippedIndex, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) equippedWeaponComponent) |
| Static Protected Attributes inherited from [TaleWorlds.MountAndBlade.AgentStatCalculateModel](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html) | |
| const float | [MaxHorizontalErrorRadian](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a1293bf9c35f8165615cd92cce1775787) = 2f \* [MathF.DegToRad](class_tale_worlds_1_1_library_1_1_math_f.html#a940007fa7aac7553a3f08a767f78a6c1) |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#afe165cfc08658fb058516870c8c240c2)GetDifficultyModifier()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override float SandBox.GameComponents.SandboxAgentStatCalculateModel.GetDifficultyModifier | ( |  | ) |  |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#a46072801d10259d1c3d8df2b648a9242)CanAgentRideMount()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool SandBox.GameComponents.SandboxAgentStatCalculateModel.CanAgentRideMount | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *targetMount* ) |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#a27d41a9723b196b981ab5a2e8fbb9297)InitializeAgentStats()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void SandBox.GameComponents.SandboxAgentStatCalculateModel.InitializeAgentStats | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) | *spawnEquipment*, |
|  |  | [AgentDrivenProperties](class_tale_worlds_1_1_mount_and_blade_1_1_agent_driven_properties.html) | *agentDrivenProperties*, |
|  |  | [AgentBuildData](class_tale_worlds_1_1_mount_and_blade_1_1_agent_build_data.html) | *agentBuildData* ) |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#a3563a1573b9eb38068c6a3660dc295c6)InitializeMissionEquipment()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.GameComponents.SandboxAgentStatCalculateModel.InitializeMissionEquipment | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.AgentStatCalculateModel](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a121ebbaf2cfaccb25e8db05a8e5b0195).

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#a5c3b9e33b4510eba3278219f73b9eb62)UpdateAgentStats()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void SandBox.GameComponents.SandboxAgentStatCalculateModel.UpdateAgentStats | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | [AgentDrivenProperties](class_tale_worlds_1_1_mount_and_blade_1_1_agent_driven_properties.html) | *agentDrivenProperties* ) |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#ae69147723ff1dee7706c64cf1811d242)GetEffectiveSkill()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override int SandBox.GameComponents.SandboxAgentStatCalculateModel.GetEffectiveSkill | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill* ) | | virtual |

Parameters
:   |  |  |
    | --- | --- |
    | agent |  |
    | skill |  |

Returns

Reimplemented from [TaleWorlds.MountAndBlade.AgentStatCalculateModel](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a0e6fdfe3c57660cd63e3b85f60accf12).

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#a5ad6a489e86ab958d1fc6713f55d68f6)GetWeaponDamageMultiplier()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float SandBox.GameComponents.SandboxAgentStatCalculateModel.GetWeaponDamageMultiplier | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *weapon* ) |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#a8bf61ee0045ee750c89e0390fd27193f)GetEquipmentStealthBonus()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float SandBox.GameComponents.SandboxAgentStatCalculateModel.GetEquipmentStealthBonus | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#a2b4a8f7a77735bbb787a824cf8e464a9)GetSneakAttackMultiplier()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float SandBox.GameComponents.SandboxAgentStatCalculateModel.GetSneakAttackMultiplier | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *weapon* ) |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#a939ae0d58fda31681000945f5598269e)GetKnockBackResistance()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float SandBox.GameComponents.SandboxAgentStatCalculateModel.GetKnockBackResistance | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#a70bf071ae6e89450f2cadd750e5413e6)GetKnockDownResistance()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float SandBox.GameComponents.SandboxAgentStatCalculateModel.GetKnockDownResistance | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | [StrikeType](namespace_tale_worlds_1_1_core.html#a2adc9126cb9a9e45bc133ebc57833835) | *strikeType* = StrikeType::Invalid ) |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#a82a8cdf29da747a53fd72f21d0bc798b)GetDismountResistance()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float SandBox.GameComponents.SandboxAgentStatCalculateModel.GetDismountResistance | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#a8f8164f6a274b237284fde79bdccd902)GetBreatheHoldMaxDuration()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float SandBox.GameComponents.SandboxAgentStatCalculateModel.GetBreatheHoldMaxDuration | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | float | *baseBreatheHoldMaxDuration* ) |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#a716f17f2556966a23ff87e1b4db82f66)GetWeaponInaccuracy()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override float SandBox.GameComponents.SandboxAgentStatCalculateModel.GetWeaponInaccuracy | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *weapon*, | |  |  | int | *weaponSkill* ) | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.AgentStatCalculateModel](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a4a2622f11b9f91bf1778e226515339f0).

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#a2facdf51535f12b5dc7e2a02eb8a3fdf)GetInteractionDistance()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override float SandBox.GameComponents.SandboxAgentStatCalculateModel.GetInteractionDistance | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.AgentStatCalculateModel](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a841a1ee2656315ae85fdf9d0eae08303).

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#aeb59fdc3affab35d64c88174a66e54df)GetMaxCameraZoom()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override float SandBox.GameComponents.SandboxAgentStatCalculateModel.GetMaxCameraZoom | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.AgentStatCalculateModel](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#ad2f18c596356a3d07e99353f3f966024).

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#ade7663717e0f4fab7b9df1c087ed8f24)GetPerksOfAgent()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| List< [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) > SandBox.GameComponents.SandboxAgentStatCalculateModel.GetPerksOfAgent | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *agentCharacter*, |
|  |  | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill* = null, |
|  |  | bool | *filterPartyRole* = false, |
|  |  | [PartyRole](namespace_tale_worlds_1_1_campaign_system.html#af60f394cea2e7c527bf1950e31fd13cf) | *partyRole* = PartyRole::Personal ) |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#a58d3513f1d7d41d8f7cc55fed0cf67d3)GetMissionDebugInfoForAgent()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override string SandBox.GameComponents.SandboxAgentStatCalculateModel.GetMissionDebugInfoForAgent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.AgentStatCalculateModel](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a954d2a255a779ed3c85688eaa553a678).

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#a6692f0520baf213b922dc7ed46f44248)GetEffectiveArmorEncumbrance()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override float SandBox.GameComponents.SandboxAgentStatCalculateModel.GetEffectiveArmorEncumbrance | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) | *equipment* ) | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.AgentStatCalculateModel](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#ae8ae1b44c11e16d51cde7b1b61ed29b9).

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#a6b6a8da54b6fa523f3381196a85695f4)GetEffectiveMaxHealth()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override float SandBox.GameComponents.SandboxAgentStatCalculateModel.GetEffectiveMaxHealth | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.AgentStatCalculateModel](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#af625f5a48fe33d7c2259c4b84e33f1b8).

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#aa31e841199a16d9cab35193d45faaa1e)GetEnvironmentSpeedFactor()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override float SandBox.GameComponents.SandboxAgentStatCalculateModel.GetEnvironmentSpeedFactor | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | virtual |

Parameters
:   |  |  |
    | --- | --- |
    | agent |  |

Returns

Reimplemented from [TaleWorlds.MountAndBlade.AgentStatCalculateModel](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a55574411a9ae2f6f309f4dffc165d0e6).

[◆](class_sand_box_1_1_game_components_1_1_sandbox_agent_stat_calculate_model.html#ad03b5ca410b9d24cfb4368bbdd71a195)CalculateMaximumSpeedMultiplier()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float SandBox.GameComponents.SandboxAgentStatCalculateModel.CalculateMaximumSpeedMultiplier | ( | int | *athletics*, | |  |  | float | *baseWeight*, | |  |  | float | *totalEncumbrance* ) | | static |

