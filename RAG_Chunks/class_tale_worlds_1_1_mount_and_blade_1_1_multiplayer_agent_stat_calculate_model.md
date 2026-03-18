--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_stat_calculate_model.html ---

TaleWorlds.MountAndBlade.MultiplayerAgentStatCalculateModel Class ReferenceInherits [TaleWorlds.MountAndBlade.AgentStatCalculateModel](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override float | [GetDifficultyModifier](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_stat_calculate_model.html#a61d53d9891cc4cc9cf3652515824da0a) () |
| override bool | [CanAgentRideMount](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_stat_calculate_model.html#a9ad3f89d4c06517c029a3f3991207e24) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) targetMount) |
| override void | [InitializeAgentStats](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_stat_calculate_model.html#a9774b1868381469d3b10e0b7a7836030) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) spawnEquipment, [AgentDrivenProperties](class_tale_worlds_1_1_mount_and_blade_1_1_agent_driven_properties.html) agentDrivenProperties, [AgentBuildData](class_tale_worlds_1_1_mount_and_blade_1_1_agent_build_data.html) agentBuildData) |
| override float | [GetWeaponInaccuracy](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_stat_calculate_model.html#a0c43926a6a8245f733269ca780933dab) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) weapon, int weaponSkill) |
| override float | [GetWeaponDamageMultiplier](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_stat_calculate_model.html#af702ef42e7217abc653856fde78a2526) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) weapon) |
| override float | [GetEquipmentStealthBonus](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_stat_calculate_model.html#a96f7523fd7c51734d432a8343d583ad8) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| override float | [GetSneakAttackMultiplier](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_stat_calculate_model.html#a6ca99134d25423c52719531b69f94bd9) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) weapon) |
| override float | [GetKnockBackResistance](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_stat_calculate_model.html#a14d30aaae45e61ba1227097478ad8eda) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| override float | [GetKnockDownResistance](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_stat_calculate_model.html#a064b4b8b935c78ae2d4d2a508ee04952) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [StrikeType](namespace_tale_worlds_1_1_core.html#a2adc9126cb9a9e45bc133ebc57833835) strikeType=StrikeType.Invalid) |
| override float | [GetDismountResistance](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_stat_calculate_model.html#a28a2ea196dad9af7d926b3dc29b395bd) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| override float | [GetBreatheHoldMaxDuration](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_stat_calculate_model.html#a1d57b588df7e81f2cdf7c6ef2442c8fc) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, float baseBreatheHoldMaxDuration) |
| override void | [UpdateAgentStats](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_stat_calculate_model.html#aa45ffb5981f689e20b2246bd9cf26c47) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [AgentDrivenProperties](class_tale_worlds_1_1_mount_and_blade_1_1_agent_driven_properties.html) agentDrivenProperties) |
| override int | [GetEffectiveSkillForWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_stat_calculate_model.html#aa8012ad477bc391aca1e76b4e81bc416) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) weapon) |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.AgentStatCalculateModel](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html) | |
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
| virtual float | [GetDetachmentCostMultiplierOfAgent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a439d9e607b98e519348a8c698f935554) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html) detachment) |
| virtual float | [GetInteractionDistance](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a841a1ee2656315ae85fdf9d0eae08303) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| virtual float | [GetMaxCameraZoom](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#ad2f18c596356a3d07e99353f3f966024) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| virtual int | [GetEffectiveSkill](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a0e6fdfe3c57660cd63e3b85f60accf12) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill) |
|  | Returns the total (effective) skill of an agent regarding any perks or effects that are applied on it during the mission. This is the same as [BasicCharacterObject.GetSkillValue()](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a42ea2bc67456fe86b090e72583a23a12) if there are no such perks or effects. |
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
| Static Public Member Functions | |
| static float | [CalculateMaximumSpeedMultiplier](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_stat_calculate_model.html#ae637a9110e59d7859a17d54ce54c250b) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |

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

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_stat_calculate_model.html#a61d53d9891cc4cc9cf3652515824da0a)GetDifficultyModifier()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.MultiplayerAgentStatCalculateModel.GetDifficultyModifier | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_stat_calculate_model.html#a9ad3f89d4c06517c029a3f3991207e24)CanAgentRideMount()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.MountAndBlade.MultiplayerAgentStatCalculateModel.CanAgentRideMount | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *targetMount* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_stat_calculate_model.html#a9774b1868381469d3b10e0b7a7836030)InitializeAgentStats()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.MountAndBlade.MultiplayerAgentStatCalculateModel.InitializeAgentStats | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) | *spawnEquipment*, |
|  |  | [AgentDrivenProperties](class_tale_worlds_1_1_mount_and_blade_1_1_agent_driven_properties.html) | *agentDrivenProperties*, |
|  |  | [AgentBuildData](class_tale_worlds_1_1_mount_and_blade_1_1_agent_build_data.html) | *agentBuildData* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_stat_calculate_model.html#a0c43926a6a8245f733269ca780933dab)GetWeaponInaccuracy()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override float TaleWorlds.MountAndBlade.MultiplayerAgentStatCalculateModel.GetWeaponInaccuracy | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *weapon*, | |  |  | int | *weaponSkill* ) | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.AgentStatCalculateModel](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a4a2622f11b9f91bf1778e226515339f0).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_stat_calculate_model.html#af702ef42e7217abc653856fde78a2526)GetWeaponDamageMultiplier()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.MultiplayerAgentStatCalculateModel.GetWeaponDamageMultiplier | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *weapon* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_stat_calculate_model.html#a96f7523fd7c51734d432a8343d583ad8)GetEquipmentStealthBonus()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.MultiplayerAgentStatCalculateModel.GetEquipmentStealthBonus | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_stat_calculate_model.html#a6ca99134d25423c52719531b69f94bd9)GetSneakAttackMultiplier()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.MultiplayerAgentStatCalculateModel.GetSneakAttackMultiplier | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *weapon* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_stat_calculate_model.html#a14d30aaae45e61ba1227097478ad8eda)GetKnockBackResistance()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.MultiplayerAgentStatCalculateModel.GetKnockBackResistance | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_stat_calculate_model.html#a064b4b8b935c78ae2d4d2a508ee04952)GetKnockDownResistance()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.MultiplayerAgentStatCalculateModel.GetKnockDownResistance | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | [StrikeType](namespace_tale_worlds_1_1_core.html#a2adc9126cb9a9e45bc133ebc57833835) | *strikeType* = StrikeType::Invalid ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_stat_calculate_model.html#a28a2ea196dad9af7d926b3dc29b395bd)GetDismountResistance()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.MultiplayerAgentStatCalculateModel.GetDismountResistance | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_stat_calculate_model.html#a1d57b588df7e81f2cdf7c6ef2442c8fc)GetBreatheHoldMaxDuration()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.MountAndBlade.MultiplayerAgentStatCalculateModel.GetBreatheHoldMaxDuration | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | float | *baseBreatheHoldMaxDuration* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_stat_calculate_model.html#aa45ffb5981f689e20b2246bd9cf26c47)UpdateAgentStats()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.MountAndBlade.MultiplayerAgentStatCalculateModel.UpdateAgentStats | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | [AgentDrivenProperties](class_tale_worlds_1_1_mount_and_blade_1_1_agent_driven_properties.html) | *agentDrivenProperties* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_stat_calculate_model.html#aa8012ad477bc391aca1e76b4e81bc416)GetEffectiveSkillForWeapon()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override int TaleWorlds.MountAndBlade.MultiplayerAgentStatCalculateModel.GetEffectiveSkillForWeapon | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *weapon* ) | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.AgentStatCalculateModel](class_tale_worlds_1_1_mount_and_blade_1_1_agent_stat_calculate_model.html#a19db4a7f670ecd5f191a416bbef06519).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_agent_stat_calculate_model.html#ae637a9110e59d7859a17d54ce54c250b)CalculateMaximumSpeedMultiplier()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.MultiplayerAgentStatCalculateModel.CalculateMaximumSpeedMultiplier | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | static |

