--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_tactic_defend_castle.html ---

TaleWorlds.MountAndBlade.TacticDefendCastle Class ReferenceInherits [TaleWorlds.MountAndBlade.TacticComponent](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [TacticState](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_defend_castle.html#a0502cb249e80a4d18228134224ee470e) {     [ProperDefense](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_defend_castle.html#a0502cb249e80a4d18228134224ee470ea692c9457161b9d5a86d955eab633b882) ,     [DesperateDefense](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_defend_castle.html#a0502cb249e80a4d18228134224ee470ea7cc66d3ab52a7805cb51aae5a376dfe0) ,     [RetreatToKeep](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_defend_castle.html#a0502cb249e80a4d18228134224ee470ea8dd36fa12257a638b140bdd722b6639c) ,     [SallyOut](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_defend_castle.html#a0502cb249e80a4d18228134224ee470ea3d6806e222f143afc07bd405190644b7)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [TacticDefendCastle](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_defend_castle.html#aa8f7205a286bee686dcf254052a885e3) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a6fef7bf329157fe343198ee035fa30d1) team) |
| override void | [TickOccasionally](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_defend_castle.html#ac35f2aaa29f62608ce90fcd2923b96f3) () |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.TacticComponent](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html) | |
| void | [ResetTactic](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a31c5db4fa785aa17c27aa4912be775a3) () |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override bool | [CheckAndSetAvailableFormationsChanged](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_defend_castle.html#ab2e844eaf0da8b6f88eac2ccd67d132a) () |
| override void | [ManageFormationCounts](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_defend_castle.html#a77db7ed90263d4fed1c735a291476ac9) () |
| override void | [StopUsingAllMachines](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_defend_castle.html#a0a1675fc4013db936396dbf85917a50b) () |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.TacticComponent](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html) | |
|  | [TacticComponent](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a893f6c73b2325a63970bb999a87c6f20) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a6fef7bf329157fe343198ee035fa30d1) team) |
| List< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > | [ConsolidateFormations](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a8ec0dcdfd4bd6e6bf7727b96131c423b) (List< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > formationsToBeConsolidated, int neededCount) |
| void | [SplitFormationClassIntoGivenNumber](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#adee9f3d0c1590bdd17f0c307cf3bbc48) (Func< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html), bool > formationClass, int count) |
| void | [AssignTacticFormations1121](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a274d136322f2338a7cfbe06394615a48) () |
|  | Merge and split [AI](namespace_tale_worlds_1_1_mount_and_blade_1_1_a_i.html) controlled formations to end up with 1 infantry, 1 ranged, 2 cavalry(left and right) and 1 mounted range formation. |
| void | [ManageFormationCounts](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#af34cd256ece85c894ac01d780ea724e9) (int infantryCount, int rangedCount, int cavalryCount, int rangedCavalryCount) |
| void | [StopUsingAllRangedSiegeWeapons](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a456e23ed7528479904c03142546afa64) () |
| void | [SoundTacticalHorn](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a4130a124934591a60b85aa0fba1dd659) (int soundCode) |
| bool | [CheckAndDetermineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#ae84467aa6395a42325057b9726deff89) (ref [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation, Func< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html), bool > isEligible) |
|  | Checks whether a reference to a formation is null or empty, if it is null or empty tries to re-refer it to an eligible formation. |

|  |  |
| --- | --- |
| Properties | |
| [TacticState](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_defend_castle.html#a0502cb249e80a4d18228134224ee470e) | [CurrentTacticState](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_defend_castle.html#ae3a5a2ea76e5b60111408b27e12e03a2) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.TacticComponent](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html) | |
| Team | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a6fef7bf329157fe343198ee035fa30d1) `[get, protected set]` |
| MBList< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > | [FormationsIncludingSpecialAndEmpty](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#ab44a4012d42c0ed5e0ea2ced6027b8a2) `[get]` |
| MBList< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > | [FormationsIncludingEmpty](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a4d3e500a27e9572d19e9640723ec4e7f) `[get]` |
| bool | [AreFormationsCreated](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a8bd5a005e216ee561166b07612704aaa) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.MountAndBlade.TacticComponent](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html) | |
| static void | [SetDefaultBehaviorWeights](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a13ca056ee798736653472aae376bbcb7) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) f) |
| Static Public Attributes inherited from [TaleWorlds.MountAndBlade.TacticComponent](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html) | |
| static readonly int | [MoveHornSoundIndex](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#acff620c6e075c1a78e81a2b693f1aed1) |
| static readonly int | [AttackHornSoundIndex](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#ad0777839f211847a18647c851b9a2e41) |
| static readonly int | [RetreatHornSoundIndex](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a6b68dc41a9d894454aa384dd894cded8) |
| Static Protected Member Functions inherited from [TaleWorlds.MountAndBlade.TacticComponent](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html) | |
| static float | [GetFormationGroupEffectivenessOverOrder](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a580bed700ff531e189aafef79bb4a8a8) (IEnumerable< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > formationGroup, [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) orderType, [IOrderable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_orderable.html) targetObject=null) |
| static float | [GetFormationEffectivenessOverOrder](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a3b13c9c6cdddbbb6868662a4732940bf) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation, [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) orderType, [IOrderable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_orderable.html) targetObject=null) |
| static float | [CalculateNotEngagingTacticalAdvantage](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a2354d260f590c9dd11e632f6f385e523) ([TeamQuerySystem](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html) team) |
| static List< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > | [ChooseAndSortByPriority](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#ad041bfcd353f9f99d8d5904eedea22b8) (IEnumerable< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > formations, Func< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html), bool > isEligible, Func< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html), bool > isPrioritized, Func< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html), float > score) |
| Protected Attributes inherited from [TaleWorlds.MountAndBlade.TacticComponent](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html) | |
| int | [\_AIControlledFormationCount](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#abceb69632bc2376e7465f544d6d0a737) = 0 |
| bool | [IsTacticReapplyNeeded](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#ab2c4205bf18eca1a6621d8828b23fe09) = false |
| [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | [\_mainInfantry](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#ad5ceb503580f616a55b63c88411f4769) |
| [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | [\_archers](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a22c7e3a8c6fba96e00cd21a894a046ec) |
| [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | [\_leftCavalry](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a8cf213632168f1b4c373039133799465) |
| [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | [\_rightCavalry](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#ae41b12a775262154245fa347303fd2ff) |
| [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | [\_rangedCavalry](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#ac4e0c721645b4410b025f49e24bef973) |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_defend_castle.html#a0502cb249e80a4d18228134224ee470e)TacticState
---------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.TacticDefendCastle.TacticState](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_defend_castle.html#a0502cb249e80a4d18228134224ee470e) |

| Enumerator | |
| --- | --- |
| ProperDefense |  |
| DesperateDefense |  |
| RetreatToKeep |  |
| SallyOut |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_defend_castle.html#aa8f7205a286bee686dcf254052a885e3)TacticDefendCastle()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.TacticDefendCastle.TacticDefendCastle | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a6fef7bf329157fe343198ee035fa30d1) | *team* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_defend_castle.html#ab2e844eaf0da8b6f88eac2ccd67d132a)CheckAndSetAvailableFormationsChanged()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override bool TaleWorlds.MountAndBlade.TacticDefendCastle.CheckAndSetAvailableFormationsChanged | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.TacticComponent](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a60dca2865dd00ace11a99094919aecbb).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_defend_castle.html#a77db7ed90263d4fed1c735a291476ac9)ManageFormationCounts()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.TacticDefendCastle.ManageFormationCounts | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.TacticComponent](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a405474353564c2ee6dbed8acd236fef9).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_defend_castle.html#a0a1675fc4013db936396dbf85917a50b)StopUsingAllMachines()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.TacticDefendCastle.StopUsingAllMachines | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.TacticComponent](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a01ffaaeb2ca31552da9f9021836395a6).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_defend_castle.html#ac35f2aaa29f62608ce90fcd2923b96f3)TickOccasionally()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.TacticDefendCastle.TickOccasionally | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.TacticComponent](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#aad5888c363c530896030e14ddc3d0da7).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_defend_castle.html#ae3a5a2ea76e5b60111408b27e12e03a2)CurrentTacticState
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TacticState](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_defend_castle.html#a0502cb249e80a4d18228134224ee470e) TaleWorlds.MountAndBlade.TacticDefendCastle.CurrentTacticState | | get |

