--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html ---

TaleWorlds.MountAndBlade.TacticComponent Class ReferenceabstractSmall scale tasks or procedures to carry out the larger strategy (which is team ai).

Inherited by [TaleWorlds.MountAndBlade.TacticBreachWalls](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_breach_walls.html), [TaleWorlds.MountAndBlade.TacticCharge](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_charge.html), [TaleWorlds.MountAndBlade.TacticCoordinatedRetreat](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_coordinated_retreat.html), [TaleWorlds.MountAndBlade.TacticDefendCastle](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_defend_castle.html), [TaleWorlds.MountAndBlade.TacticDefensiveEngagement](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_defensive_engagement.html), [TaleWorlds.MountAndBlade.TacticDefensiveLine](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_defensive_line.html), [TaleWorlds.MountAndBlade.TacticDefensiveRing](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_defensive_ring.html), [TaleWorlds.MountAndBlade.TacticFrontalCavalryCharge](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_frontal_cavalry_charge.html), [TaleWorlds.MountAndBlade.TacticFullScaleAttack](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_full_scale_attack.html), [TaleWorlds.MountAndBlade.TacticHoldChokePoint](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_hold_choke_point.html), [TaleWorlds.MountAndBlade.TacticPerimeterDefense](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_perimeter_defense.html), [TaleWorlds.MountAndBlade.TacticRangedHarrassmentOffensive](https://apidoc.bannerlord.com/v/1.3.14/class_tale_worlds_1_1_mount_and_blade_1_1_tactic_ranged_harrassment_offensive.html), [TaleWorlds.MountAndBlade.TacticSallyOutDefense](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_sally_out_defense.html), [TaleWorlds.MountAndBlade.TacticSallyOutHitAndRun](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_sally_out_hit_and_run.html), [TaleWorlds.MountAndBlade.TacticSergeantMPBotTactic](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_sergeant_m_p_bot_tactic.html), and [TaleWorlds.MountAndBlade.TacticStop](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_stop.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| virtual void | [TickOccasionally](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#aad5888c363c530896030e14ddc3d0da7) () |
| void | [ResetTactic](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a31c5db4fa785aa17c27aa4912be775a3) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [SetDefaultBehaviorWeights](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a13ca056ee798736653472aae376bbcb7) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) f) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static readonly int | [MoveHornSoundIndex](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#acff620c6e075c1a78e81a2b693f1aed1) |
| static readonly int | [AttackHornSoundIndex](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#ad0777839f211847a18647c851b9a2e41) |
| static readonly int | [RetreatHornSoundIndex](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a6b68dc41a9d894454aa384dd894cded8) |

|  |  |
| --- | --- |
| Protected Member Functions | |
|  | [TacticComponent](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a893f6c73b2325a63970bb999a87c6f20) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a6fef7bf329157fe343198ee035fa30d1) team) |
| List< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > | [ConsolidateFormations](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a8ec0dcdfd4bd6e6bf7727b96131c423b) (List< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > formationsToBeConsolidated, int neededCount) |
| void | [SplitFormationClassIntoGivenNumber](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#adee9f3d0c1590bdd17f0c307cf3bbc48) (Func< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html), bool > formationClass, int count) |
| virtual bool | [CheckAndSetAvailableFormationsChanged](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a60dca2865dd00ace11a99094919aecbb) () |
| void | [AssignTacticFormations1121](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a274d136322f2338a7cfbe06394615a48) () |
|  | Merge and split [AI](namespace_tale_worlds_1_1_mount_and_blade_1_1_a_i.html) controlled formations to end up with 1 infantry, 1 ranged, 2 cavalry(left and right) and 1 mounted range formation. |
| virtual void | [ManageFormationCounts](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a405474353564c2ee6dbed8acd236fef9) () |
| void | [ManageFormationCounts](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#af34cd256ece85c894ac01d780ea724e9) (int infantryCount, int rangedCount, int cavalryCount, int rangedCavalryCount) |
| virtual void | [StopUsingAllMachines](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a01ffaaeb2ca31552da9f9021836395a6) () |
| void | [StopUsingAllRangedSiegeWeapons](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a456e23ed7528479904c03142546afa64) () |
| void | [SoundTacticalHorn](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a4130a124934591a60b85aa0fba1dd659) (int soundCode) |
| bool | [CheckAndDetermineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#ae84467aa6395a42325057b9726deff89) (ref [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation, Func< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html), bool > isEligible) |
|  | Checks whether a reference to a formation is null or empty, if it is null or empty tries to re-refer it to an eligible formation. |

|  |  |
| --- | --- |
| Static Protected Member Functions | |
| static float | [GetFormationGroupEffectivenessOverOrder](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a580bed700ff531e189aafef79bb4a8a8) (IEnumerable< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > formationGroup, [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) orderType, [IOrderable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_orderable.html) targetObject=null) |
| static float | [GetFormationEffectivenessOverOrder](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a3b13c9c6cdddbbb6868662a4732940bf) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation, [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) orderType, [IOrderable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_orderable.html) targetObject=null) |
| static float | [CalculateNotEngagingTacticalAdvantage](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a2354d260f590c9dd11e632f6f385e523) ([TeamQuerySystem](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html) team) |
| static List< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > | [ChooseAndSortByPriority](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#ad041bfcd353f9f99d8d5904eedea22b8) (IEnumerable< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > formations, Func< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html), bool > isEligible, Func< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html), bool > isPrioritized, Func< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html), float > score) |

|  |  |
| --- | --- |
| Protected Attributes | |
| int | [\_AIControlledFormationCount](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#abceb69632bc2376e7465f544d6d0a737) = 0 |
| bool | [IsTacticReapplyNeeded](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#ab2c4205bf18eca1a6621d8828b23fe09) = false |
| [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | [\_mainInfantry](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#ad5ceb503580f616a55b63c88411f4769) |
| [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | [\_archers](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a22c7e3a8c6fba96e00cd21a894a046ec) |
| [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | [\_leftCavalry](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a8cf213632168f1b4c373039133799465) |
| [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | [\_rightCavalry](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#ae41b12a775262154245fa347303fd2ff) |
| [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | [\_rangedCavalry](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#ac4e0c721645b4410b025f49e24bef973) |

|  |  |
| --- | --- |
| Properties | |
| Team | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a6fef7bf329157fe343198ee035fa30d1) `[get, protected set]` |
| MBList< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > | [FormationsIncludingSpecialAndEmpty](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#ab44a4012d42c0ed5e0ea2ced6027b8a2) `[get]` |
| MBList< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > | [FormationsIncludingEmpty](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a4d3e500a27e9572d19e9640723ec4e7f) `[get]` |
| bool | [AreFormationsCreated](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a8bd5a005e216ee561166b07612704aaa) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a893f6c73b2325a63970bb999a87c6f20)TacticComponent()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | TaleWorlds.MountAndBlade.TacticComponent.TacticComponent | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a6fef7bf329157fe343198ee035fa30d1) | *team* | ) |  | | protected |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#aad5888c363c530896030e14ddc3d0da7)TickOccasionally()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.TacticComponent.TickOccasionally | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.TacticBreachWalls](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_breach_walls.html#a333825243491a3915d1805d6c8e6531d), [TaleWorlds.MountAndBlade.TacticCharge](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_charge.html#a55ebc5785307f5c09a0bc8437bc561dc), [TaleWorlds.MountAndBlade.TacticCoordinatedRetreat](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_coordinated_retreat.html#a1ffca6f52fa572525b04e48559852698), [TaleWorlds.MountAndBlade.TacticDefendCastle](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_defend_castle.html#ac35f2aaa29f62608ce90fcd2923b96f3), [TaleWorlds.MountAndBlade.TacticDefensiveEngagement](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_defensive_engagement.html#a51884e9c35edf1f65830610df74c6854), [TaleWorlds.MountAndBlade.TacticDefensiveLine](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_defensive_line.html#a6130c7556c06358c8b76db87629d640b), [TaleWorlds.MountAndBlade.TacticDefensiveRing](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_defensive_ring.html#a3c7a58f0336ecfcec807d0e8de178ba8), [TaleWorlds.MountAndBlade.TacticFrontalCavalryCharge](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_frontal_cavalry_charge.html#a65ebf3e6f2269b058d5656308d02ea09), [TaleWorlds.MountAndBlade.TacticFullScaleAttack](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_full_scale_attack.html#a8d4e5fe20248830a3b2180b44776f23c), [TaleWorlds.MountAndBlade.TacticHoldChokePoint](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_hold_choke_point.html#aa06192377be199c9f752ce5b18d47427), [TaleWorlds.MountAndBlade.TacticPerimeterDefense](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_perimeter_defense.html#ac10b4638178df50527ae4d351c5213ee), [TaleWorlds.MountAndBlade.TacticRangedHarrassmentOffensive](https://apidoc.bannerlord.com/v/1.3.14/class_tale_worlds_1_1_mount_and_blade_1_1_tactic_ranged_harrassment_offensive.html#a2b5e04bbd6d9f29af61c4e9c9d459ede), [TaleWorlds.MountAndBlade.TacticSallyOutDefense](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_sally_out_defense.html#a1a9d8f12312f0c882d622b7a697e71d5), [TaleWorlds.MountAndBlade.TacticSallyOutHitAndRun](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_sally_out_hit_and_run.html#a02c350bac978b3b97331983dca74cbec), [TaleWorlds.MountAndBlade.TacticSergeantMPBotTactic](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_sergeant_m_p_bot_tactic.html#a8b84c4d3ba6780f38cf990c4d612b7b8), and [TaleWorlds.MountAndBlade.TacticStop](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_stop.html#adb7847a72d2dc2a90bcd0f2c051a5aac).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a580bed700ff531e189aafef79bb4a8a8)GetFormationGroupEffectivenessOverOrder()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.TacticComponent.GetFormationGroupEffectivenessOverOrder | ( | IEnumerable< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > | *formationGroup*, | |  |  | [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) | *orderType*, | |  |  | [IOrderable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_orderable.html) | *targetObject* = null ) | | staticprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a3b13c9c6cdddbbb6868662a4732940bf)GetFormationEffectivenessOverOrder()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.TacticComponent.GetFormationEffectivenessOverOrder | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation*, | |  |  | [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) | *orderType*, | |  |  | [IOrderable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_orderable.html) | *targetObject* = null ) | | staticprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a8ec0dcdfd4bd6e6bf7727b96131c423b)ConsolidateFormations()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | List< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > TaleWorlds.MountAndBlade.TacticComponent.ConsolidateFormations | ( | List< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > | *formationsToBeConsolidated*, | |  |  | int | *neededCount* ) | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a2354d260f590c9dd11e632f6f385e523)CalculateNotEngagingTacticalAdvantage()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.TacticComponent.CalculateNotEngagingTacticalAdvantage | ( | [TeamQuerySystem](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html) | *team* | ) |  | | staticprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#adee9f3d0c1590bdd17f0c307cf3bbc48)SplitFormationClassIntoGivenNumber()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.TacticComponent.SplitFormationClassIntoGivenNumber | ( | Func< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html), bool > | *formationClass*, | |  |  | int | *count* ) | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a60dca2865dd00ace11a99094919aecbb)CheckAndSetAvailableFormationsChanged()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual bool TaleWorlds.MountAndBlade.TacticComponent.CheckAndSetAvailableFormationsChanged | ( |  | ) |  | | protectedvirtual |

Reimplemented in [TaleWorlds.MountAndBlade.TacticBreachWalls](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_breach_walls.html#ae84a31b3ae9d3dd6703af12f36a2dbe5), [TaleWorlds.MountAndBlade.TacticCoordinatedRetreat](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_coordinated_retreat.html#a4489cd6e7c5fbe948349663fee198c08), [TaleWorlds.MountAndBlade.TacticDefendCastle](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_defend_castle.html#ab2e844eaf0da8b6f88eac2ccd67d132a), [TaleWorlds.MountAndBlade.TacticDefensiveEngagement](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_defensive_engagement.html#a95369bce11b147db9507d296baebed0a), [TaleWorlds.MountAndBlade.TacticDefensiveLine](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_defensive_line.html#a4c5d707429e2d171aca4a9111163fd81), [TaleWorlds.MountAndBlade.TacticDefensiveRing](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_defensive_ring.html#a6ae9a51803756c01a1a9cb5fc3eaea7f), [TaleWorlds.MountAndBlade.TacticFrontalCavalryCharge](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_frontal_cavalry_charge.html#ad394f0e0d82b118557f73114ff42adb6), [TaleWorlds.MountAndBlade.TacticFullScaleAttack](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_full_scale_attack.html#a3add6ecdff6700ee2bc07b9cb487ef1d), [TaleWorlds.MountAndBlade.TacticHoldChokePoint](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_hold_choke_point.html#ac72792fb942f08711f5ff3f1a4c42809), [TaleWorlds.MountAndBlade.TacticRangedHarrassmentOffensive](https://apidoc.bannerlord.com/v/1.3.14/class_tale_worlds_1_1_mount_and_blade_1_1_tactic_ranged_harrassment_offensive.html#a36a59bbf7a7c788c9407b2ba8ad28f12), [TaleWorlds.MountAndBlade.TacticSallyOutDefense](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_sally_out_defense.html#a5fc39d1ade38de84d975be7e1086ed6a), and [TaleWorlds.MountAndBlade.TacticSallyOutHitAndRun](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_sally_out_hit_and_run.html#a5817e38824e78f30b158b95efc28e182).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a31c5db4fa785aa17c27aa4912be775a3)ResetTactic()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.TacticComponent.ResetTactic | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a274d136322f2338a7cfbe06394615a48)AssignTacticFormations1121()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.TacticComponent.AssignTacticFormations1121 | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#ad041bfcd353f9f99d8d5904eedea22b8)ChooseAndSortByPriority()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | List< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > TaleWorlds.MountAndBlade.TacticComponent.ChooseAndSortByPriority | ( | IEnumerable< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > | *formations*, | |  |  | Func< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html), bool > | *isEligible*, | |  |  | Func< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html), bool > | *isPrioritized*, | |  |  | Func< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html), float > | *score* ) | | staticprotected |

Parameters
:   |  |  |
    | --- | --- |
    | formations |  |

Formations that are to be sorted and returned

Parameters
:   |  |  |
    | --- | --- |
    | isEligible |  |

Formations not satisfying this condition are excluded from the result

Parameters
:   |  |  |
    | --- | --- |
    | isPrioritized |  |

Formations satisfying this condition come before others regardless of score

Parameters
:   |  |  |
    | --- | --- |
    | score |  |

Formations are sorted according to their evaluation with this function

Returns

Sorted list

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a405474353564c2ee6dbed8acd236fef9)ManageFormationCounts() [1/2]
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.TacticComponent.ManageFormationCounts | ( |  | ) |  | | protectedvirtual |

Reimplemented in [TaleWorlds.MountAndBlade.TacticBreachWalls](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_breach_walls.html#a609e4ef5ed149a2a344339f85c7c5c7b), [TaleWorlds.MountAndBlade.TacticCoordinatedRetreat](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_coordinated_retreat.html#a7a88861e6c48264b17cf72eadbc3f3f1), [TaleWorlds.MountAndBlade.TacticDefendCastle](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_defend_castle.html#a77db7ed90263d4fed1c735a291476ac9), [TaleWorlds.MountAndBlade.TacticDefensiveEngagement](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_defensive_engagement.html#ac02204263828b719f46b6e544d8f4c11), [TaleWorlds.MountAndBlade.TacticDefensiveLine](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_defensive_line.html#aad324c6f2ed59eec83a0f9f0e017cc88), [TaleWorlds.MountAndBlade.TacticDefensiveRing](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_defensive_ring.html#adc1c95292a1a067667382f4a0ddc6b66), [TaleWorlds.MountAndBlade.TacticFrontalCavalryCharge](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_frontal_cavalry_charge.html#a09bb6ea339babc6b74e10a48649cce69), [TaleWorlds.MountAndBlade.TacticFullScaleAttack](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_full_scale_attack.html#af2260ba47b7863461355707562c57822), [TaleWorlds.MountAndBlade.TacticHoldChokePoint](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_hold_choke_point.html#af88b6bb6229c22b1a991865ab03073ad), [TaleWorlds.MountAndBlade.TacticRangedHarrassmentOffensive](https://apidoc.bannerlord.com/v/1.3.14/class_tale_worlds_1_1_mount_and_blade_1_1_tactic_ranged_harrassment_offensive.html#aa47db1fdc697837d09cf44ec407773ea), [TaleWorlds.MountAndBlade.TacticSallyOutDefense](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_sally_out_defense.html#ab2491cc713c11010cf7826da25d557e9), and [TaleWorlds.MountAndBlade.TacticSallyOutHitAndRun](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_sally_out_hit_and_run.html#a32f2a4d973e93eb7a1b5a34bffabddc9).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#af34cd256ece85c894ac01d780ea724e9)ManageFormationCounts() [2/2]
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.TacticComponent.ManageFormationCounts | ( | int | *infantryCount*, | |  |  | int | *rangedCount*, | |  |  | int | *cavalryCount*, | |  |  | int | *rangedCavalryCount* ) | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a01ffaaeb2ca31552da9f9021836395a6)StopUsingAllMachines()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.TacticComponent.StopUsingAllMachines | ( |  | ) |  | | protectedvirtual |

Reimplemented in [TaleWorlds.MountAndBlade.TacticDefendCastle](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_defend_castle.html#a0a1675fc4013db936396dbf85917a50b).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a456e23ed7528479904c03142546afa64)StopUsingAllRangedSiegeWeapons()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.TacticComponent.StopUsingAllRangedSiegeWeapons | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a4130a124934591a60b85aa0fba1dd659)SoundTacticalHorn()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.TacticComponent.SoundTacticalHorn | ( | int | *soundCode* | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a13ca056ee798736653472aae376bbcb7)SetDefaultBehaviorWeights()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.TacticComponent.SetDefaultBehaviorWeights | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *f* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#ae84467aa6395a42325057b9726deff89)CheckAndDetermineFormation()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.TacticComponent.CheckAndDetermineFormation | ( | ref [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation*, | |  |  | Func< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html), bool > | *isEligible* ) | | protected |

Parameters
:   |  |  |
    | --- | --- |
    | formation |  |

formation reference to be checked and updated

Parameters
:   |  |  |
    | --- | --- |
    | isEligible |  |

function to determine which formations are eligible for given reference

Returns

whether the reference formation is usable or not

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#acff620c6e075c1a78e81a2b693f1aed1)MoveHornSoundIndex
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly int TaleWorlds.MountAndBlade.TacticComponent.MoveHornSoundIndex | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#ad0777839f211847a18647c851b9a2e41)AttackHornSoundIndex
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly int TaleWorlds.MountAndBlade.TacticComponent.AttackHornSoundIndex | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a6b68dc41a9d894454aa384dd894cded8)RetreatHornSoundIndex
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly int TaleWorlds.MountAndBlade.TacticComponent.RetreatHornSoundIndex | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#abceb69632bc2376e7465f544d6d0a737)\_AIControlledFormationCount
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.TacticComponent.\_AIControlledFormationCount = 0 | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#ab2c4205bf18eca1a6621d8828b23fe09)IsTacticReapplyNeeded
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.TacticComponent.IsTacticReapplyNeeded = false | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#ad5ceb503580f616a55b63c88411f4769)\_mainInfantry
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) TaleWorlds.MountAndBlade.TacticComponent.\_mainInfantry | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a22c7e3a8c6fba96e00cd21a894a046ec)\_archers
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) TaleWorlds.MountAndBlade.TacticComponent.\_archers | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a8cf213632168f1b4c373039133799465)\_leftCavalry
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) TaleWorlds.MountAndBlade.TacticComponent.\_leftCavalry | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#ae41b12a775262154245fa347303fd2ff)\_rightCavalry
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) TaleWorlds.MountAndBlade.TacticComponent.\_rightCavalry | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#ac4e0c721645b4410b025f49e24bef973)\_rangedCavalry
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) TaleWorlds.MountAndBlade.TacticComponent.\_rangedCavalry | | protected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a6fef7bf329157fe343198ee035fa30d1)Team
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Team TaleWorlds.MountAndBlade.TacticComponent.Team | | getprotected set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#ab44a4012d42c0ed5e0ea2ced6027b8a2)FormationsIncludingSpecialAndEmpty
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBList<[Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html)> TaleWorlds.MountAndBlade.TacticComponent.FormationsIncludingSpecialAndEmpty | | getprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a4d3e500a27e9572d19e9640723ec4e7f)FormationsIncludingEmpty
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBList<[Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html)> TaleWorlds.MountAndBlade.TacticComponent.FormationsIncludingEmpty | | getprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html#a8bd5a005e216ee561166b07612704aaa)AreFormationsCreated
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.TacticComponent.AreFormationsCreated | | getprotected |

