--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_morale_model.html ---

TaleWorlds.MountAndBlade.CustomBattleMoraleModel Class ReferenceInherits [TaleWorlds.MountAndBlade.ComponentInterfaces.BattleMoraleModel](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_morale_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [override](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_morale_model.html#a67e12e53e2d628c63f3fdd4ffa13f994) (float [affectedSideMaxMoraleLoss](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_morale_model.html#a2eb67360cd66e3156e244fc9b5236b6a), float affectorSideMaxMoraleGain) [CalculateMaxMoraleChangeDueToAgentIncapacitated](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_morale_model.html#a859de3b9ac73b15ccdfc427d9baacd67)([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectedAgent |
|  | [override](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_morale_model.html#abc6d160353eb51e0135f03df65588937) (float [affectedSideMaxMoraleLoss](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_morale_model.html#a2eb67360cd66e3156e244fc9b5236b6a), float affectorSideMaxMoraleGain) [CalculateMaxMoraleChangeDueToAgentPanicked](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_morale_model.html#a617aad0c6beadf627d652b2d12542993)([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| [override](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_morale_model.html#a67e12e53e2d628c63f3fdd4ffa13f994) float | [CalculateMoraleChangeToCharacter](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_morale_model.html#ad5780985bee024eb8dd91861e437ac46) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, float maxMoraleChange) |
| [override](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_morale_model.html#a67e12e53e2d628c63f3fdd4ffa13f994) float | [GetEffectiveInitialMorale](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_morale_model.html#a0e971ac568bb0803dc445f40820dde17) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, float baseMorale) |
| [override](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_morale_model.html#a67e12e53e2d628c63f3fdd4ffa13f994) bool | [CanPanicDueToMorale](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_morale_model.html#addfe1d487f931bf93fe9620baae28eba) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| [override](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_morale_model.html#a67e12e53e2d628c63f3fdd4ffa13f994) float | [CalculateCasualtiesFactor](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_morale_model.html#a294d8d8c575611dbbd11af4fb76eefe9) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) battleSide) |
| [override](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_morale_model.html#a67e12e53e2d628c63f3fdd4ffa13f994) float | [GetAverageMorale](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_morale_model.html#a96e6531ebee3b70b00958bd605910283) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| [override](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_morale_model.html#a67e12e53e2d628c63f3fdd4ffa13f994) float | [CalculateMoraleChangeOnShipSunk](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_morale_model.html#aa24b151620db8f66b333cfda4eeee875) ([IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) shipOrigin) |
| [override](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_morale_model.html#a67e12e53e2d628c63f3fdd4ffa13f994) float | [CalculateMoraleOnRamming](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_morale_model.html#a57a23a6f803d08e93c29a5145b280db7) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) rammingShip, [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) rammedShip) |
| [override](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_morale_model.html#a67e12e53e2d628c63f3fdd4ffa13f994) float | [CalculateMoraleOnShipsConnected](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_morale_model.html#af6ae31832489be12e79325971a2392f0) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) ownerShip, [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) targetShip) |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.ComponentInterfaces.BattleMoraleModel](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_morale_model.html) | |
| float float affectorSideMaxMoraleGain | [CalculateMaxMoraleChangeDueToAgentIncapacitated](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_morale_model.html#a859de3b9ac73b15ccdfc427d9baacd67) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectedAgent, [AgentState](namespace_tale_worlds_1_1_core.html#a799bcc77ddb6372c7383f3340ed4d1c0) affectedAgentState, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectorAgent, in [KillingBlow](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html) killingBlow) |
| float float affectorSideMaxMoraleGain | [CalculateMaxMoraleChangeDueToAgentPanicked](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_morale_model.html#a617aad0c6beadf627d652b2d12542993) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| float | [CalculateMoraleChangeToCharacter](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_morale_model.html#a22669042763bd5fb87194870e0bc116a) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, float maxMoraleChange) |
| float | [GetEffectiveInitialMorale](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_morale_model.html#aea1dc68835b0dfcac1a4ab8fcc7b5f5c) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, float baseMorale) |
| bool | [CanPanicDueToMorale](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_morale_model.html#a40c0e3e390bd6329ec91a93b065e9736) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| float | [CalculateCasualtiesFactor](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_morale_model.html#ad521980691881efa2ee81641ea510bcc) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) battleSide) |
| float | [GetAverageMorale](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_morale_model.html#a395062a3f8a589e7b8c67c878de9d746) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| float | [CalculateMoraleChangeOnShipSunk](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_morale_model.html#a02813417bb3d097da649353d2b9c9e4a) ([IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) shipOrigin) |
| float | [CalculateMoraleOnRamming](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_morale_model.html#a90a08ddb1b398846623d543e94519f99) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) rammingShip, [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) rammedShip) |
| float | [CalculateMoraleOnShipsConnected](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_morale_model.html#a5062f2b051496fc9dd0714f6dcb0d7cb) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) ownerShip, [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) targetShip) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Attributes inherited from [TaleWorlds.MountAndBlade.ComponentInterfaces.BattleMoraleModel](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_morale_model.html) | |
| float | [affectedSideMaxMoraleLoss](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_morale_model.html#a2eb67360cd66e3156e244fc9b5236b6a) |
| Static Public Attributes inherited from [TaleWorlds.MountAndBlade.ComponentInterfaces.BattleMoraleModel](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_morale_model.html) | |
| const float | [BaseMoraleGainOnKill](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_morale_model.html#ae21a85b3a6d08323ff5e7d79c61b54bb) = 3f |
| const float | [BaseMoraleLossOnKill](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_morale_model.html#ad5c3eb630fddd7db736cd2adb8464397) = 4f |
| const float | [BaseMoraleGainOnPanic](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_morale_model.html#a72fdb6398c10ebb1283ff42aad2becb9) = 2f |
| const float | [BaseMoraleLossOnPanic](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_morale_model.html#a15f1c308761d2bdb62033dcbf98b3fb4) = 1.10f |
| const float | [MeleeWeaponMoraleMultiplier](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_morale_model.html#a7c59c5bb10171ba35e288e6de219e0cc) = 0.75f |
| const float | [RangedWeaponMoraleMultiplier](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_morale_model.html#a90737af3e7491a8ef20371654f6f6ac4) = 0.5f |
| const float | [SiegeWeaponMoraleMultiplier](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_morale_model.html#a0e5c28daa1df57df72c49d005f5c0b31) = 0.25f |
| const float | [BurningSiegeWeaponMoraleBonus](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_morale_model.html#abfcb2468ad5778a74f4114a127a12e8e) = 0.25f |
| const float | [CasualtyFactorRate](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_morale_model.html#aa146fc8ba756822cecf1f59f871c3dff) = 2.0f |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_morale_model.html#a67e12e53e2d628c63f3fdd4ffa13f994)override() [1/2]
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.CustomBattleMoraleModel.override | ( | float | *affectedSideMaxMoraleLoss*, |
|  |  | float | *affectorSideMaxMoraleGain* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_morale_model.html#abc6d160353eb51e0135f03df65588937)override() [2/2]
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.CustomBattleMoraleModel.override | ( | float | *affectedSideMaxMoraleLoss*, |
|  |  | float | *affectorSideMaxMoraleGain* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_morale_model.html#ad5780985bee024eb8dd91861e437ac46)CalculateMoraleChangeToCharacter()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_morale_model.html#a67e12e53e2d628c63f3fdd4ffa13f994) float TaleWorlds.MountAndBlade.CustomBattleMoraleModel.CalculateMoraleChangeToCharacter | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | float | *maxMoraleChange* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_morale_model.html#a0e971ac568bb0803dc445f40820dde17)GetEffectiveInitialMorale()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_morale_model.html#a67e12e53e2d628c63f3fdd4ffa13f994) float TaleWorlds.MountAndBlade.CustomBattleMoraleModel.GetEffectiveInitialMorale | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | float | *baseMorale* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_morale_model.html#addfe1d487f931bf93fe9620baae28eba)CanPanicDueToMorale()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_morale_model.html#a67e12e53e2d628c63f3fdd4ffa13f994) bool TaleWorlds.MountAndBlade.CustomBattleMoraleModel.CanPanicDueToMorale | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_morale_model.html#a294d8d8c575611dbbd11af4fb76eefe9)CalculateCasualtiesFactor()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_morale_model.html#a67e12e53e2d628c63f3fdd4ffa13f994) float TaleWorlds.MountAndBlade.CustomBattleMoraleModel.CalculateCasualtiesFactor | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *battleSide* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_morale_model.html#a96e6531ebee3b70b00958bd605910283)GetAverageMorale()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_morale_model.html#a67e12e53e2d628c63f3fdd4ffa13f994) float TaleWorlds.MountAndBlade.CustomBattleMoraleModel.GetAverageMorale | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_morale_model.html#aa24b151620db8f66b333cfda4eeee875)CalculateMoraleChangeOnShipSunk()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_morale_model.html#a67e12e53e2d628c63f3fdd4ffa13f994) float TaleWorlds.MountAndBlade.CustomBattleMoraleModel.CalculateMoraleChangeOnShipSunk | ( | [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) | *shipOrigin* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_morale_model.html#a57a23a6f803d08e93c29a5145b280db7)CalculateMoraleOnRamming()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_morale_model.html#a67e12e53e2d628c63f3fdd4ffa13f994) float TaleWorlds.MountAndBlade.CustomBattleMoraleModel.CalculateMoraleOnRamming | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) | *rammingShip*, |
|  |  | [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) | *rammedShip* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_morale_model.html#af6ae31832489be12e79325971a2392f0)CalculateMoraleOnShipsConnected()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_morale_model.html#a67e12e53e2d628c63f3fdd4ffa13f994) float TaleWorlds.MountAndBlade.CustomBattleMoraleModel.CalculateMoraleOnShipsConnected | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) | *ownerShip*, |
|  |  | [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) | *targetShip* ) |

