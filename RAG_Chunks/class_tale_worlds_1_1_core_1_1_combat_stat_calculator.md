--- SOURCE: class_tale_worlds_1_1_core_1_1_combat_stat_calculator.html ---

TaleWorlds.Core.CombatStatCalculator Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static float | [CalculateStrikeMagnitudeForSwing](class_tale_worlds_1_1_core_1_1_combat_stat_calculator.html#a165399e5781c90df1254ec085ae79a9a) (float swingSpeed, float impactPointAsPercent, float weaponWeight, float weaponLength, float weaponInertia, float weaponCoM, float extraLinearSpeed) |
| static float | [CalculateStrikeMagnitudeForThrust](class_tale_worlds_1_1_core_1_1_combat_stat_calculator.html#a5830250de43375cb02771e10e68f474b) (float thrustWeaponSpeed, float weaponWeight, float extraLinearSpeed, bool isThrown) |
| static float | [CalculateBaseBlowMagnitudeForSwing](class_tale_worlds_1_1_core_1_1_combat_stat_calculator.html#a5a1a6f2f6eb547c01dc98a6fc3a981bc) (float angularSpeed, float weaponReach, float weaponWeight, float weaponInertia, float weaponCoM, float impactPoint, float exraLinearSpeed) |
| static float | [CalculateBaseBlowMagnitudeForThrust](class_tale_worlds_1_1_core_1_1_combat_stat_calculator.html#acd72abb88a4be7801e4a8aafa8fc0da6) (float linearSpeed, float weaponWeight, float exraLinearSpeed) |
| static float | [CalculateBaseBlowMagnitudeForPassiveUsage](class_tale_worlds_1_1_core_1_1_combat_stat_calculator.html#a527cdc01f919e417c882f63e0e4ccbfd) (float weaponWeight, float extraLinearSpeed) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const float | [ReferenceSwingSpeed](class_tale_worlds_1_1_core_1_1_combat_stat_calculator.html#a0f87fac6bbb3227068f69f63b065f506) = 22.0f |
| const float | [ReferenceThrustSpeed](class_tale_worlds_1_1_core_1_1_combat_stat_calculator.html#ae9ade8ffcbb9fc2b7b0f0161e3910af1) = 8.5f |
| const float | [SwingSpeedConst](class_tale_worlds_1_1_core_1_1_combat_stat_calculator.html#a6b560b1070fdbfcb4877eecac2f2907f) = 100.0f / [ReferenceSwingSpeed](class_tale_worlds_1_1_core_1_1_combat_stat_calculator.html#a0f87fac6bbb3227068f69f63b065f506) |
| const float | [ThrustSpeedConst](class_tale_worlds_1_1_core_1_1_combat_stat_calculator.html#ad06680bcc4bac568a59ea3d731d0393d) = 100.0f / [ReferenceThrustSpeed](class_tale_worlds_1_1_core_1_1_combat_stat_calculator.html#ae9ade8ffcbb9fc2b7b0f0161e3910af1) |
| const float | [DefaultImpactDistanceFromTip](class_tale_worlds_1_1_core_1_1_combat_stat_calculator.html#a6f40767a9a75ee98e796afce33b91667) = 0.07f |
| const float | [ArmLength](class_tale_worlds_1_1_core_1_1_combat_stat_calculator.html#a96442b648e67008e4972cd6e08186fcd) = 0.5f |
| const float | [ArmWeight](class_tale_worlds_1_1_core_1_1_combat_stat_calculator.html#a851b46fce5629412b8ae56cabb283bf2) = 2.5f |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_combat_stat_calculator.html#a165399e5781c90df1254ec085ae79a9a)CalculateStrikeMagnitudeForSwing()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.Core.CombatStatCalculator.CalculateStrikeMagnitudeForSwing | ( | float | *swingSpeed*, | |  |  | float | *impactPointAsPercent*, | |  |  | float | *weaponWeight*, | |  |  | float | *weaponLength*, | |  |  | float | *weaponInertia*, | |  |  | float | *weaponCoM*, | |  |  | float | *extraLinearSpeed* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_combat_stat_calculator.html#a5830250de43375cb02771e10e68f474b)CalculateStrikeMagnitudeForThrust()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.Core.CombatStatCalculator.CalculateStrikeMagnitudeForThrust | ( | float | *thrustWeaponSpeed*, | |  |  | float | *weaponWeight*, | |  |  | float | *extraLinearSpeed*, | |  |  | bool | *isThrown* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_combat_stat_calculator.html#a5a1a6f2f6eb547c01dc98a6fc3a981bc)CalculateBaseBlowMagnitudeForSwing()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.Core.CombatStatCalculator.CalculateBaseBlowMagnitudeForSwing | ( | float | *angularSpeed*, | |  |  | float | *weaponReach*, | |  |  | float | *weaponWeight*, | |  |  | float | *weaponInertia*, | |  |  | float | *weaponCoM*, | |  |  | float | *impactPoint*, | |  |  | float | *exraLinearSpeed* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_combat_stat_calculator.html#acd72abb88a4be7801e4a8aafa8fc0da6)CalculateBaseBlowMagnitudeForThrust()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.Core.CombatStatCalculator.CalculateBaseBlowMagnitudeForThrust | ( | float | *linearSpeed*, | |  |  | float | *weaponWeight*, | |  |  | float | *exraLinearSpeed* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_combat_stat_calculator.html#a527cdc01f919e417c882f63e0e4ccbfd)CalculateBaseBlowMagnitudeForPassiveUsage()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.Core.CombatStatCalculator.CalculateBaseBlowMagnitudeForPassiveUsage | ( | float | *weaponWeight*, | |  |  | float | *extraLinearSpeed* ) | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_core_1_1_combat_stat_calculator.html#a0f87fac6bbb3227068f69f63b065f506)ReferenceSwingSpeed
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.Core.CombatStatCalculator.ReferenceSwingSpeed = 22.0f | | static |

[◆](class_tale_worlds_1_1_core_1_1_combat_stat_calculator.html#ae9ade8ffcbb9fc2b7b0f0161e3910af1)ReferenceThrustSpeed
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.Core.CombatStatCalculator.ReferenceThrustSpeed = 8.5f | | static |

[◆](class_tale_worlds_1_1_core_1_1_combat_stat_calculator.html#a6b560b1070fdbfcb4877eecac2f2907f)SwingSpeedConst
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.Core.CombatStatCalculator.SwingSpeedConst = 100.0f / [ReferenceSwingSpeed](class_tale_worlds_1_1_core_1_1_combat_stat_calculator.html#a0f87fac6bbb3227068f69f63b065f506) | | static |

[◆](class_tale_worlds_1_1_core_1_1_combat_stat_calculator.html#ad06680bcc4bac568a59ea3d731d0393d)ThrustSpeedConst
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.Core.CombatStatCalculator.ThrustSpeedConst = 100.0f / [ReferenceThrustSpeed](class_tale_worlds_1_1_core_1_1_combat_stat_calculator.html#ae9ade8ffcbb9fc2b7b0f0161e3910af1) | | static |

[◆](class_tale_worlds_1_1_core_1_1_combat_stat_calculator.html#a6f40767a9a75ee98e796afce33b91667)DefaultImpactDistanceFromTip
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.Core.CombatStatCalculator.DefaultImpactDistanceFromTip = 0.07f | | static |

[◆](class_tale_worlds_1_1_core_1_1_combat_stat_calculator.html#a96442b648e67008e4972cd6e08186fcd)ArmLength
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.Core.CombatStatCalculator.ArmLength = 0.5f | | static |

[◆](class_tale_worlds_1_1_core_1_1_combat_stat_calculator.html#a851b46fce5629412b8ae56cabb283bf2)ArmWeight
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.Core.CombatStatCalculator.ArmWeight = 2.5f | | static |

