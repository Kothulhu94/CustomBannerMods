--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html ---

TaleWorlds.MountAndBlade.FormationQuerySystem Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [FormationQuerySystem](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ad4443de7cc5568ff0193354228badc97) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a5d7d6b9f319176e7cf7aef377816a7b8) formation) |
| void | [EvaluateAllPreliminaryQueryData](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a9e5e481b246f2fd35e8b05a3d7990d75) () |
| void | [ForceExpireCavalryUnitRatio](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a342bf0da63786a9666d942b896289dd2) () |
| void | [Expire](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#aaed0ecb021a41d6b0d73180d99a0b4e5) () |
| void | [ExpireAfterUnitAddRemove](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#aad9993d46d105ab41887366623b5f022) () |
| float | [GetClassWeightedFactor](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a4a2d5467089d7286412158fb62a7f8b0) (float infantryWeight, float rangedWeight, float cavalryWeight, float rangedCavalryWeight) |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly Formation | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a5d7d6b9f319176e7cf7aef377816a7b8) |

|  |  |
| --- | --- |
| Properties | |
| [TeamQuerySystem](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html) | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ac0aa86d2b2720b1831f4f6a2a368bcfa) `[get]` |
| float | [FormationPower](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ace81b41c3c28c073f69ec54d697a8f2d) `[get]` |
| float | [FormationPowerReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a8e92e7dc1dce3c09f2df9ab5c1f0a868) `[get]` |
| float | [FormationMeleeFightingPower](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a384f8aa10ac654db893c927024148678) `[get]` |
| float | [FormationMeleeFightingPowerReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ade55c4430b755b2132ba73f5f89ba420) `[get]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [EstimatedDirection](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a19557423eb2ba29dcfdc266ba8a291ff) `[get]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [EstimatedDirectionReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a5db14f486432763d677088e8d2552409) `[get]` |
| float | [EstimatedInterval](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a5292e778fba63f77cc9dad1ffdb2f4aa) `[get]` |
| float | [EstimatedIntervalReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a0d0ff9add81e4c5be824469931eec8aa) `[get]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [AverageAllyPosition](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a6655682cc20df98d7583ab49fb478d04) `[get]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [AverageAllyPositionReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a01ff6ea102e5f4069f734e9b33ead1b3) `[get]` |
| float | [IdealAverageDisplacement](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a66b6f6d68de4b4e7ce9621cd648dbc51) `[get]` |
| float | [IdealAverageDisplacementReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a4b402130fea2b8a746c78640d08fc65a) `[get]` |
| MBList< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | [LocalAllyUnits](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ac509cdea5a0edf541d56fced9335f143) `[get]` |
| MBList< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | [LocalAllyUnitsReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ab88cbd62bfb44a10b917e41d6def4628) `[get]` |
| MBList< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | [LocalEnemyUnits](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a079bcd2a0d9121853aa8c5178e9e3c5c) `[get]` |
| MBList< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | [LocalEnemyUnitsReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ae2ef71965c0025f56f0171051aa9b0e2) `[get]` |
| [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | [MainClass](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#afeb905a3bce85972fede56efa2bb5a42) `[get]` |
| [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | [MainClassReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a5cdbdac8284151d3d8934fd309ad060d) `[get]` |
| float | [InfantryUnitRatio](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a38345db880382757e3618c8f797874aa) `[get]` |
| float | [InfantryUnitRatioReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#aedc939306f2b81424ccc2e2a727d9b5f) `[get]` |
| float | [HasShieldUnitRatio](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ab180d15e5f6df47deed0e9fc5d5a86a5) `[get]` |
| float | [HasShieldUnitRatioReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#aff1464c181dea43ec6ff6374c64b6d84) `[get]` |
| float | [HasThrowingUnitRatio](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#afaaa1e0cfe79c5453bb8541695f79144) `[get]` |
| float | [HasThrowingUnitRatioReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a48591f14d5c27b47a23206e04f57da20) `[get]` |
| float | [RangedUnitRatio](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ac4aa15af9d193c47cdc919ebcadaede0) `[get]` |
| float | [RangedUnitRatioReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a7efca92a88f239f0fceb2161976aed64) `[get]` |
| int | [InsideCastleUnitCountIncludingUnpositioned](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ad614bde7967120dec391c4fdd6070e75) `[get]` |
| int | [InsideCastleUnitCountIncludingUnpositionedReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#abefee318d3221bc3288c2a90eed2f434) `[get]` |
| int | [InsideCastleUnitCountPositioned](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a09735a60e831fd8a187f7535abd54d87) `[get]` |
| int | [InsideCastleUnitCountPositionedReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a2bf882ffda9758b92adccc2baadfc567) `[get]` |
| float | [CavalryUnitRatio](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a5276c8a740feda91bf5f2b2fd3fd9780) `[get]` |
| float | [CavalryUnitRatioReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#afe2870fef1bc53e2bc4811b75068aa55) `[get]` |
| float | [RangedCavalryUnitRatio](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a1fe65e3ef51917dc380e40aecc2c5a45) `[get]` |
| float | [RangedCavalryUnitRatioReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a609565eebd87382366e118adad0ace49) `[get]` |
| bool | [IsMeleeFormation](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ae3319686749192889c3a81f995f1d613) `[get]` |
| bool | [IsMeleeFormationReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a66bd23f00d90603551c6e4fa443b5930) `[get]` |
| bool | [IsInfantryFormation](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#aa3ec0993289d2f1512f325ecb82faa3a) `[get]` |
| bool | [IsInfantryFormationReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#acb6e91fed9e6fb8b42911f3e30bcafc6) `[get]` |
| bool | [HasShield](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a94a8dd6382e47a6c25831f699c8890c7) `[get]` |
| bool | [HasShieldReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a9688522fa1dfae4c53578026f2ce6109) `[get]` |
| bool | [HasThrowing](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a8b68f7b3922d233d8590abb52490a11e) `[get]` |
| bool | [HasThrowingReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a3325a1e0fd7083673a08d0bff6875997) `[get]` |
| bool | [IsRangedFormation](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ac19b95b97b53f7539e2e97b8d3611e74) `[get]` |
| bool | [IsRangedFormationReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#af7ebd705d650aaf4687e347cdc321ba6) `[get]` |
| bool | [IsCavalryFormation](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a0a2379f80d4743062812382cb916f73f) `[get]` |
| bool | [IsCavalryFormationReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a3830c6f398e16754129812f0e9941b5d) `[get]` |
| bool | [IsRangedCavalryFormation](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a7cd3a2dd53d432fc72d50e855aa60b4b) `[get]` |
| bool | [IsRangedCavalryFormationReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ae6509f317d2b8d652b4a8b200422dcec) `[get]` |
| float | [MovementSpeedMaximum](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a884c71287ba0d48a3e6ec7205851cd62) `[get]` |
| float | [MovementSpeedMaximumReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ae2843cd23a6cf7542ff5fe7b1727d931) `[get]` |
| float | [MaximumMissileRange](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#abadb804f8087a2de5f3934b2517ad19b) `[get]` |
| float | [MaximumMissileRangeReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ac43fc4271a860e7520725413215f8724) `[get]` |
| float | [MissileRangeAdjusted](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a1efc668ac7a7c9037d5ada919112e874) `[get]` |
| float | [MissileRangeAdjustedReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a059430ad895f3983e3abb0d04489fb70) `[get]` |
| float | [LocalInfantryUnitRatio](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ac1be85a2607a4c7ab1d98796566edc0c) `[get]` |
| float | [LocalInfantryUnitRatioReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ad87ceeb47e7db5b96e09d0e6c11bf623) `[get]` |
| float | [LocalRangedUnitRatio](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a262c409bef6ed10f5aa29bf4a3be8935) `[get]` |
| float | [LocalRangedUnitRatioReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#aed7a22f2586f9bddfcc282be73658d1a) `[get]` |
| float | [LocalCavalryUnitRatio](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ade49a7504949d9f627ea7f560f33c239) `[get]` |
| float | [LocalCavalryUnitRatioReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#abf098118d53858d8f644de48bf0649fd) `[get]` |
| float | [LocalRangedCavalryUnitRatio](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a8a5c369933ab6c95306b5f1fd790b864) `[get]` |
| float | [LocalRangedCavalryUnitRatioReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a7f324161ca7683602e3395728c56ae5d) `[get]` |
| float | [LocalAllyPower](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ad0e64ca9d96e262baac055a9bfae3a9a) `[get]` |
| float | [LocalAllyPowerReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a45339dcec59d556ec4a90b3e3691e26c) `[get]` |
| float | [LocalEnemyPower](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#aadcf9606d3d7e343f2038e1e46196c5c) `[get]` |
| float | [LocalEnemyPowerReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a121519604ecd86d866f836e5c4b71c30) `[get]` |
| float | [LocalPowerRatio](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#aa87308a17b7433fd651866fd31359938) `[get]` |
| float | [LocalPowerRatioReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#abd69154b3e9783658002d1eb45ab4b50) `[get]` |
| float | [CasualtyRatio](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#aed5b383f20233482f0624c69a9f0c620) `[get]` |
| float | [CasualtyRatioReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a0218f47a892e9a25c21f2835ec26d59c) `[get]` |
| bool | [IsUnderRangedAttack](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ab1f5eca5be479d31b4c67406f78263e4) `[get]` |
| bool | [IsUnderRangedAttackReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a17b2054c263b130582d122a19a50b936) `[get]` |
| float | [UnderRangedAttackRatio](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a5149f246e1b576ea2a3f6277ccf19785) `[get]` |
| float | [UnderRangedAttackRatioReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a80ee27aa31abb1295a1504230ccd9e21) `[get]` |
| float | [MakingRangedAttackRatio](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a31d030d9f8be60ba7574d7f4adb9f97e) `[get]` |
| float | [MakingRangedAttackRatioReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#aa184fd30788906a8f7138fde5ef6b3db) `[get]` |
| [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a5d7d6b9f319176e7cf7aef377816a7b8) | [MainFormation](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ad2c65680a5622fad75ccc77e090a41fa) `[get]` |
| [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a5d7d6b9f319176e7cf7aef377816a7b8) | [MainFormationReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a090a051dbbbcc72f5ef213d5784abd48) `[get]` |
| float | [MainFormationReliabilityFactor](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#abe876f8c08a2d23061d3a1c53455d917) `[get]` |
| float | [MainFormationReliabilityFactorReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a276a9481f4d1fc26186174f8a871f59f) `[get]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [WeightedAverageEnemyPosition](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a46c79e1f6c16e15ab1962a35e6a30daa) `[get]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [WeightedAverageEnemyPositionReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ac59346311ad18680501bb65a3f542a3f) `[get]` |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [ClosestEnemyAgent](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a3a97e80c1b5a7af4c01dd3e1c22306a2) `[get]` |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [ClosestEnemyAgentReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#aece0514efdd50bc0f282eb08bdb6e701) `[get]` |
| [FormationQuerySystem](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ad4443de7cc5568ff0193354228badc97) | [ClosestSignificantlyLargeEnemyFormation](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a17a9352f8fb05c12cbfce120d12b59a7) `[get]` |
|  | Closest formation in terms of distance, use when thinking about attacking/getting to the formation. |
| [FormationQuerySystem](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ad4443de7cc5568ff0193354228badc97) | [ClosestSignificantlyLargeEnemyFormationReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a8e238794822ae85b74345bc0c00be7c5) `[get]` |
| [FormationQuerySystem](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ad4443de7cc5568ff0193354228badc97) | [FastestSignificantlyLargeEnemyFormation](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#aef5a37ab87223c3f05b9c73227669e88) `[get]` |
|  | Closest enemy formation in terms of catching up to our formation, use when worrying about them getting to our formation. |
| [FormationQuerySystem](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ad4443de7cc5568ff0193354228badc97) | [FastestSignificantlyLargeEnemyFormationReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ac52532fb4a071bccf9fb00e7cdcbbf9f) `[get]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [HighGroundCloseToForeseenBattleGround](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a3e5d5aafaa0d3ecebba23e7aaaf2265d) `[get]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [HighGroundCloseToForeseenBattleGroundReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a15132fc78eafec64e991bce34af4903b) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ad4443de7cc5568ff0193354228badc97)FormationQuerySystem()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.FormationQuerySystem.FormationQuerySystem | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a5d7d6b9f319176e7cf7aef377816a7b8) | *formation* | ) |  |

dispersednessFactor

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a9e5e481b246f2fd35e8b05a3d7990d75)EvaluateAllPreliminaryQueryData()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.FormationQuerySystem.EvaluateAllPreliminaryQueryData | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a342bf0da63786a9666d942b896289dd2)ForceExpireCavalryUnitRatio()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.FormationQuerySystem.ForceExpireCavalryUnitRatio | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#aaed0ecb021a41d6b0d73180d99a0b4e5)Expire()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.FormationQuerySystem.Expire | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#aad9993d46d105ab41887366623b5f022)ExpireAfterUnitAddRemove()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.FormationQuerySystem.ExpireAfterUnitAddRemove | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a4a2d5467089d7286412158fb62a7f8b0)GetClassWeightedFactor()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.FormationQuerySystem.GetClassWeightedFactor | ( | float | *infantryWeight*, |
|  |  | float | *rangedWeight*, |
|  |  | float | *cavalryWeight*, |
|  |  | float | *rangedCavalryWeight* ) |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a5d7d6b9f319176e7cf7aef377816a7b8)Formation
---------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly Formation TaleWorlds.MountAndBlade.FormationQuerySystem.Formation |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ac0aa86d2b2720b1831f4f6a2a368bcfa)Team
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TeamQuerySystem](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html) TaleWorlds.MountAndBlade.FormationQuerySystem.Team | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ace81b41c3c28c073f69ec54d697a8f2d)FormationPower
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.FormationPower | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a8e92e7dc1dce3c09f2df9ab5c1f0a868)FormationPowerReadOnly
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.FormationPowerReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a384f8aa10ac654db893c927024148678)FormationMeleeFightingPower
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.FormationMeleeFightingPower | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ade55c4430b755b2132ba73f5f89ba420)FormationMeleeFightingPowerReadOnly
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.FormationMeleeFightingPowerReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a19557423eb2ba29dcfdc266ba8a291ff)EstimatedDirection
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.FormationQuerySystem.EstimatedDirection | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a5db14f486432763d677088e8d2552409)EstimatedDirectionReadOnly
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.FormationQuerySystem.EstimatedDirectionReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a5292e778fba63f77cc9dad1ffdb2f4aa)EstimatedInterval
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.EstimatedInterval | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a0d0ff9add81e4c5be824469931eec8aa)EstimatedIntervalReadOnly
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.EstimatedIntervalReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a6655682cc20df98d7583ab49fb478d04)AverageAllyPosition
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.FormationQuerySystem.AverageAllyPosition | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a01ff6ea102e5f4069f734e9b33ead1b3)AverageAllyPositionReadOnly
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.FormationQuerySystem.AverageAllyPositionReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a66b6f6d68de4b4e7ce9621cd648dbc51)IdealAverageDisplacement
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.IdealAverageDisplacement | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a4b402130fea2b8a746c78640d08fc65a)IdealAverageDisplacementReadOnly
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.IdealAverageDisplacementReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ac509cdea5a0edf541d56fced9335f143)LocalAllyUnits
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBList<[Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html)> TaleWorlds.MountAndBlade.FormationQuerySystem.LocalAllyUnits | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ab88cbd62bfb44a10b917e41d6def4628)LocalAllyUnitsReadOnly
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBList<[Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html)> TaleWorlds.MountAndBlade.FormationQuerySystem.LocalAllyUnitsReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a079bcd2a0d9121853aa8c5178e9e3c5c)LocalEnemyUnits
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBList<[Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html)> TaleWorlds.MountAndBlade.FormationQuerySystem.LocalEnemyUnits | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ae2ef71965c0025f56f0171051aa9b0e2)LocalEnemyUnitsReadOnly
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBList<[Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html)> TaleWorlds.MountAndBlade.FormationQuerySystem.LocalEnemyUnitsReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#afeb905a3bce85972fede56efa2bb5a42)MainClass
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) TaleWorlds.MountAndBlade.FormationQuerySystem.MainClass | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a5cdbdac8284151d3d8934fd309ad060d)MainClassReadOnly
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) TaleWorlds.MountAndBlade.FormationQuerySystem.MainClassReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a38345db880382757e3618c8f797874aa)InfantryUnitRatio
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.InfantryUnitRatio | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#aedc939306f2b81424ccc2e2a727d9b5f)InfantryUnitRatioReadOnly
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.InfantryUnitRatioReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ab180d15e5f6df47deed0e9fc5d5a86a5)HasShieldUnitRatio
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.HasShieldUnitRatio | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#aff1464c181dea43ec6ff6374c64b6d84)HasShieldUnitRatioReadOnly
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.HasShieldUnitRatioReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#afaaa1e0cfe79c5453bb8541695f79144)HasThrowingUnitRatio
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.HasThrowingUnitRatio | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a48591f14d5c27b47a23206e04f57da20)HasThrowingUnitRatioReadOnly
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.HasThrowingUnitRatioReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ac4aa15af9d193c47cdc919ebcadaede0)RangedUnitRatio
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.RangedUnitRatio | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a7efca92a88f239f0fceb2161976aed64)RangedUnitRatioReadOnly
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.RangedUnitRatioReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ad614bde7967120dec391c4fdd6070e75)InsideCastleUnitCountIncludingUnpositioned
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.FormationQuerySystem.InsideCastleUnitCountIncludingUnpositioned | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#abefee318d3221bc3288c2a90eed2f434)InsideCastleUnitCountIncludingUnpositionedReadOnly
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.FormationQuerySystem.InsideCastleUnitCountIncludingUnpositionedReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a09735a60e831fd8a187f7535abd54d87)InsideCastleUnitCountPositioned
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.FormationQuerySystem.InsideCastleUnitCountPositioned | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a2bf882ffda9758b92adccc2baadfc567)InsideCastleUnitCountPositionedReadOnly
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.FormationQuerySystem.InsideCastleUnitCountPositionedReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a5276c8a740feda91bf5f2b2fd3fd9780)CavalryUnitRatio
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.CavalryUnitRatio | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#afe2870fef1bc53e2bc4811b75068aa55)CavalryUnitRatioReadOnly
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.CavalryUnitRatioReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a1fe65e3ef51917dc380e40aecc2c5a45)RangedCavalryUnitRatio
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.RangedCavalryUnitRatio | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a609565eebd87382366e118adad0ace49)RangedCavalryUnitRatioReadOnly
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.RangedCavalryUnitRatioReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ae3319686749192889c3a81f995f1d613)IsMeleeFormation
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.FormationQuerySystem.IsMeleeFormation | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a66bd23f00d90603551c6e4fa443b5930)IsMeleeFormationReadOnly
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.FormationQuerySystem.IsMeleeFormationReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#aa3ec0993289d2f1512f325ecb82faa3a)IsInfantryFormation
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.FormationQuerySystem.IsInfantryFormation | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#acb6e91fed9e6fb8b42911f3e30bcafc6)IsInfantryFormationReadOnly
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.FormationQuerySystem.IsInfantryFormationReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a94a8dd6382e47a6c25831f699c8890c7)HasShield
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.FormationQuerySystem.HasShield | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a9688522fa1dfae4c53578026f2ce6109)HasShieldReadOnly
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.FormationQuerySystem.HasShieldReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a8b68f7b3922d233d8590abb52490a11e)HasThrowing
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.FormationQuerySystem.HasThrowing | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a3325a1e0fd7083673a08d0bff6875997)HasThrowingReadOnly
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.FormationQuerySystem.HasThrowingReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ac19b95b97b53f7539e2e97b8d3611e74)IsRangedFormation
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.FormationQuerySystem.IsRangedFormation | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#af7ebd705d650aaf4687e347cdc321ba6)IsRangedFormationReadOnly
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.FormationQuerySystem.IsRangedFormationReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a0a2379f80d4743062812382cb916f73f)IsCavalryFormation
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.FormationQuerySystem.IsCavalryFormation | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a3830c6f398e16754129812f0e9941b5d)IsCavalryFormationReadOnly
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.FormationQuerySystem.IsCavalryFormationReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a7cd3a2dd53d432fc72d50e855aa60b4b)IsRangedCavalryFormation
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.FormationQuerySystem.IsRangedCavalryFormation | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ae6509f317d2b8d652b4a8b200422dcec)IsRangedCavalryFormationReadOnly
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.FormationQuerySystem.IsRangedCavalryFormationReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a884c71287ba0d48a3e6ec7205851cd62)MovementSpeedMaximum
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.MovementSpeedMaximum | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ae2843cd23a6cf7542ff5fe7b1727d931)MovementSpeedMaximumReadOnly
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.MovementSpeedMaximumReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#abadb804f8087a2de5f3934b2517ad19b)MaximumMissileRange
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.MaximumMissileRange | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ac43fc4271a860e7520725413215f8724)MaximumMissileRangeReadOnly
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.MaximumMissileRangeReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a1efc668ac7a7c9037d5ada919112e874)MissileRangeAdjusted
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.MissileRangeAdjusted | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a059430ad895f3983e3abb0d04489fb70)MissileRangeAdjustedReadOnly
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.MissileRangeAdjustedReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ac1be85a2607a4c7ab1d98796566edc0c)LocalInfantryUnitRatio
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.LocalInfantryUnitRatio | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ad87ceeb47e7db5b96e09d0e6c11bf623)LocalInfantryUnitRatioReadOnly
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.LocalInfantryUnitRatioReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a262c409bef6ed10f5aa29bf4a3be8935)LocalRangedUnitRatio
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.LocalRangedUnitRatio | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#aed7a22f2586f9bddfcc282be73658d1a)LocalRangedUnitRatioReadOnly
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.LocalRangedUnitRatioReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ade49a7504949d9f627ea7f560f33c239)LocalCavalryUnitRatio
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.LocalCavalryUnitRatio | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#abf098118d53858d8f644de48bf0649fd)LocalCavalryUnitRatioReadOnly
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.LocalCavalryUnitRatioReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a8a5c369933ab6c95306b5f1fd790b864)LocalRangedCavalryUnitRatio
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.LocalRangedCavalryUnitRatio | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a7f324161ca7683602e3395728c56ae5d)LocalRangedCavalryUnitRatioReadOnly
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.LocalRangedCavalryUnitRatioReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ad0e64ca9d96e262baac055a9bfae3a9a)LocalAllyPower
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.LocalAllyPower | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a45339dcec59d556ec4a90b3e3691e26c)LocalAllyPowerReadOnly
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.LocalAllyPowerReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#aadcf9606d3d7e343f2038e1e46196c5c)LocalEnemyPower
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.LocalEnemyPower | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a121519604ecd86d866f836e5c4b71c30)LocalEnemyPowerReadOnly
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.LocalEnemyPowerReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#aa87308a17b7433fd651866fd31359938)LocalPowerRatio
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.LocalPowerRatio | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#abd69154b3e9783658002d1eb45ab4b50)LocalPowerRatioReadOnly
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.LocalPowerRatioReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#aed5b383f20233482f0624c69a9f0c620)CasualtyRatio
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.CasualtyRatio | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a0218f47a892e9a25c21f2835ec26d59c)CasualtyRatioReadOnly
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.CasualtyRatioReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ab1f5eca5be479d31b4c67406f78263e4)IsUnderRangedAttack
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.FormationQuerySystem.IsUnderRangedAttack | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a17b2054c263b130582d122a19a50b936)IsUnderRangedAttackReadOnly
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.FormationQuerySystem.IsUnderRangedAttackReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a5149f246e1b576ea2a3f6277ccf19785)UnderRangedAttackRatio
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.UnderRangedAttackRatio | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a80ee27aa31abb1295a1504230ccd9e21)UnderRangedAttackRatioReadOnly
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.UnderRangedAttackRatioReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a31d030d9f8be60ba7574d7f4adb9f97e)MakingRangedAttackRatio
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.MakingRangedAttackRatio | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#aa184fd30788906a8f7138fde5ef6b3db)MakingRangedAttackRatioReadOnly
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.MakingRangedAttackRatioReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ad2c65680a5622fad75ccc77e090a41fa)MainFormation
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a5d7d6b9f319176e7cf7aef377816a7b8) TaleWorlds.MountAndBlade.FormationQuerySystem.MainFormation | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a090a051dbbbcc72f5ef213d5784abd48)MainFormationReadOnly
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a5d7d6b9f319176e7cf7aef377816a7b8) TaleWorlds.MountAndBlade.FormationQuerySystem.MainFormationReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#abe876f8c08a2d23061d3a1c53455d917)MainFormationReliabilityFactor
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.MainFormationReliabilityFactor | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a276a9481f4d1fc26186174f8a871f59f)MainFormationReliabilityFactorReadOnly
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.FormationQuerySystem.MainFormationReliabilityFactorReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a46c79e1f6c16e15ab1962a35e6a30daa)WeightedAverageEnemyPosition
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.FormationQuerySystem.WeightedAverageEnemyPosition | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ac59346311ad18680501bb65a3f542a3f)WeightedAverageEnemyPositionReadOnly
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.FormationQuerySystem.WeightedAverageEnemyPositionReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a3a97e80c1b5a7af4c01dd3e1c22306a2)ClosestEnemyAgent
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) TaleWorlds.MountAndBlade.FormationQuerySystem.ClosestEnemyAgent | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#aece0514efdd50bc0f282eb08bdb6e701)ClosestEnemyAgentReadOnly
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) TaleWorlds.MountAndBlade.FormationQuerySystem.ClosestEnemyAgentReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a17a9352f8fb05c12cbfce120d12b59a7)ClosestSignificantlyLargeEnemyFormation
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [FormationQuerySystem](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ad4443de7cc5568ff0193354228badc97) TaleWorlds.MountAndBlade.FormationQuerySystem.ClosestSignificantlyLargeEnemyFormation | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a8e238794822ae85b74345bc0c00be7c5)ClosestSignificantlyLargeEnemyFormationReadOnly
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [FormationQuerySystem](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ad4443de7cc5568ff0193354228badc97) TaleWorlds.MountAndBlade.FormationQuerySystem.ClosestSignificantlyLargeEnemyFormationReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#aef5a37ab87223c3f05b9c73227669e88)FastestSignificantlyLargeEnemyFormation
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [FormationQuerySystem](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ad4443de7cc5568ff0193354228badc97) TaleWorlds.MountAndBlade.FormationQuerySystem.FastestSignificantlyLargeEnemyFormation | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ac52532fb4a071bccf9fb00e7cdcbbf9f)FastestSignificantlyLargeEnemyFormationReadOnly
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [FormationQuerySystem](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#ad4443de7cc5568ff0193354228badc97) TaleWorlds.MountAndBlade.FormationQuerySystem.FastestSignificantlyLargeEnemyFormationReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a3e5d5aafaa0d3ecebba23e7aaaf2265d)HighGroundCloseToForeseenBattleGround
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.FormationQuerySystem.HighGroundCloseToForeseenBattleGround | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html#a15132fc78eafec64e991bce34af4903b)HighGroundCloseToForeseenBattleGroundReadOnly
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.FormationQuerySystem.HighGroundCloseToForeseenBattleGroundReadOnly | | get |

