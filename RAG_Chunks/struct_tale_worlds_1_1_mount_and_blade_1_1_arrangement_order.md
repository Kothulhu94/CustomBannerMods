--- SOURCE: struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html ---

TaleWorlds.MountAndBlade.ArrangementOrder Struct Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [ArrangementOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280) {     [Circle](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280a30954d90085f6eaaf5817917fc5fecb3) = 0 ,     [Column](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280a1976d7f704de389d9fe064e08ea35b2d) = 1 ,     [Line](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280a4803e6b9e63dabf04de980788d6a13c4) = 2 ,     [Loose](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280a08d78f099561104c2015d19ea7d9d41e) = 3 ,     [Scatter](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280a09870720ca8134284e4e305ac6ce5f19) = 4 ,     [ShieldWall](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280a091908edf5a30749347c230f2d806d30) = 5 ,     [Skein](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280ab98cb5d447f822d60925907c563934ed) = 6 ,     [Square](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280aceb46ca115d05c51aa5a16a8867c3304) = 7   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ArrangementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a93368c53fc6e2bdd532739787d857efc) ([ArrangementOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280) orderEnum) |
| void | [GetMovementSpeedRestriction](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a01ea1d4e54901346928fbf276e38163e) (out float? runRestriction, out float? walkRestriction) |
| [IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html) | [GetArrangement](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#acaa63d4cf6369de288533f3012675715) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| void | [OnApply](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a9609283a10bbe6000649523004fb81fe) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| void | [SoftUpdate](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a9a3b3d67451c81dc16c0d864164ecb48) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| int | [GetUnitSpacing](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a62c3142ecbaa09b869328d4c377c438e) () |
| void | [Rearrange](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a80885f6e94398e2695f8693f35c20af4) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| void | [RearrangeAux](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#aaba4aa856d8284abf30008fb87ab5636) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation, bool isDirectly) |
| void | [OnCancel](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#add61d5ed80b195e49ba51a87ce4cf8dc) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| void | [TickOccasionally](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#ae478ab201562507c08c695bad4b52738) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| [ArrangementOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280) | [GetNativeEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#afeb1ce8daa02e0852791c13f5af77f3a) () |
| override bool | [Equals](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a83cf07ed6e25cf20283299e4553e231e) (object obj) |
| override int | [GetHashCode](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a86a6aed4a5798099110f10574d20ecb1) () |
| void | [OnOrderPositionChanged](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#add7bce6c8d9c496a96bc7c9c4fcab62e) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) previousOrderPosition) |
| float | [CalculateFormationDirectionEnforcingFactorForRank](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a148a2e49d337738e7b10f0852077a3e7) (int formationRankIndex, int rankCount) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static int | [GetUnitSpacingOf](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a8c91208dd4e244a19064d7b7bc3ac32e) ([ArrangementOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280) a) |
| static bool | [GetUnitLooseness](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a721aa96e61cc7e5419e9242b0f45d356) ([ArrangementOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280) a) |
| static [Agent.UsageDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922a) | [GetShieldDirectionOfUnit](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a82bccb7fa8d4448e5b320514eb201262) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) unit, [ArrangementOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280) orderEnum) |
| static void | [TransposeLineFormation](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a2e5f7bf100bea41f5e1c7aa46c3623c9) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| static [StrategicArea](class_tale_worlds_1_1_mount_and_blade_1_1_strategic_area.html) | [CreateStrategicArea](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a95903b3f602b34b99a6ffbdbbb865f87) ([Scene](class_tale_worlds_1_1_engine_1_1_scene.html) scene, [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) position, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) direction, float width, int capacity, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| static IEnumerable< [StrategicArea](class_tale_worlds_1_1_mount_and_blade_1_1_strategic_area.html) > | [CreateStrategicAreas](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a1a56e918b17380217d393c622ea498cc) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission, int count, [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) center, float distance, [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) target, float width, int capacity, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| static bool | [operator!=](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#ae62ce4915a3ad495fb73e953fe95732f) ([ArrangementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a93368c53fc6e2bdd532739787d857efc) a1, [ArrangementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a93368c53fc6e2bdd532739787d857efc) a2) |
| static bool | [operator==](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a8af02994c91966ded68596a3143988f8) ([ArrangementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a93368c53fc6e2bdd532739787d857efc) a1, [ArrangementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a93368c53fc6e2bdd532739787d857efc) a2) |
| static int | [GetArrangementOrderDefensiveness](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a2d5016ac2ffaa15529171c0c1854299d) ([ArrangementOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280) orderEnum) |
| static int | [GetArrangementOrderDefensivenessChange](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#ae093bf92def0759860244adb773ddb99) ([ArrangementOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280) previousOrderEnum, [ArrangementOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280) nextOrderEnum) |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly [ArrangementOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280) | [OrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a3f3f5e59b85bae366b00f876fc6d0cdc) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static readonly [ArrangementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a93368c53fc6e2bdd532739787d857efc) | [ArrangementOrderCircle](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#ae5f7d6b92cf596f93657acb6fcf392b3) = new [ArrangementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a93368c53fc6e2bdd532739787d857efc)([ArrangementOrderEnum.Circle](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280a30954d90085f6eaaf5817917fc5fecb3)) |
| static readonly [ArrangementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a93368c53fc6e2bdd532739787d857efc) | [ArrangementOrderColumn](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#aebdf527fabf1c6c53902a1510e0523c3) = new [ArrangementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a93368c53fc6e2bdd532739787d857efc)([ArrangementOrderEnum.Column](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280a1976d7f704de389d9fe064e08ea35b2d)) |
| static readonly [ArrangementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a93368c53fc6e2bdd532739787d857efc) | [ArrangementOrderLine](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#aaea37888ff39aeba6dd3501516cde09f) = new [ArrangementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a93368c53fc6e2bdd532739787d857efc)([ArrangementOrderEnum.Line](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280a4803e6b9e63dabf04de980788d6a13c4)) |
| static readonly [ArrangementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a93368c53fc6e2bdd532739787d857efc) | [ArrangementOrderLoose](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#ad9ccbc67dbff43dac7c00c4137bd4622) = new [ArrangementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a93368c53fc6e2bdd532739787d857efc)([ArrangementOrderEnum.Loose](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280a08d78f099561104c2015d19ea7d9d41e)) |
| static readonly [ArrangementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a93368c53fc6e2bdd532739787d857efc) | [ArrangementOrderScatter](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a517ff336bc8c0c0fb9f9a7a8fac6b4e7) = new [ArrangementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a93368c53fc6e2bdd532739787d857efc)([ArrangementOrderEnum.Scatter](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280a09870720ca8134284e4e305ac6ce5f19)) |
| static readonly [ArrangementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a93368c53fc6e2bdd532739787d857efc) | [ArrangementOrderShieldWall](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a0cf468e42e4d6beae2eb6a0cbe055881) = new [ArrangementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a93368c53fc6e2bdd532739787d857efc)([ArrangementOrderEnum.ShieldWall](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280a091908edf5a30749347c230f2d806d30)) |
| static readonly [ArrangementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a93368c53fc6e2bdd532739787d857efc) | [ArrangementOrderSkein](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a590b3e3e53f2bd84f8f59db66ed1822a) = new [ArrangementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a93368c53fc6e2bdd532739787d857efc)([ArrangementOrderEnum.Skein](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280ab98cb5d447f822d60925907c563934ed)) |
| static readonly [ArrangementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a93368c53fc6e2bdd532739787d857efc) | [ArrangementOrderSquare](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#ad245cb4e1937ee4bd15d701cccb6922a) = new [ArrangementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a93368c53fc6e2bdd532739787d857efc)([ArrangementOrderEnum.Square](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280aceb46ca115d05c51aa5a16a8867c3304)) |

|  |  |
| --- | --- |
| Properties | |
| [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) | [OrderType](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a867680becb911a10f33ea2bf056deaf5) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280)ArrangementOrderEnum
----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.ArrangementOrder.ArrangementOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280) |

| Enumerator | |
| --- | --- |
| Circle |  |
| Column |  |
| Line |  |
| Loose |  |
| Scatter |  |
| ShieldWall |  |
| Skein |  |
| Square |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a93368c53fc6e2bdd532739787d857efc)ArrangementOrder()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.ArrangementOrder.ArrangementOrder | ( | [ArrangementOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280) | *orderEnum* | ) |  |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a8c91208dd4e244a19064d7b7bc3ac32e)GetUnitSpacingOf()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.ArrangementOrder.GetUnitSpacingOf | ( | [ArrangementOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280) | *a* | ) |  | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a721aa96e61cc7e5419e9242b0f45d356)GetUnitLooseness()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.ArrangementOrder.GetUnitLooseness | ( | [ArrangementOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280) | *a* | ) |  | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a01ea1d4e54901346928fbf276e38163e)GetMovementSpeedRestriction()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ArrangementOrder.GetMovementSpeedRestriction | ( | out float? | *runRestriction*, |
|  |  | out float? | *walkRestriction* ) |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#acaa63d4cf6369de288533f3012675715)GetArrangement()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html) TaleWorlds.MountAndBlade.ArrangementOrder.GetArrangement | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a9609283a10bbe6000649523004fb81fe)OnApply()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ArrangementOrder.OnApply | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a9a3b3d67451c81dc16c0d864164ecb48)SoftUpdate()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ArrangementOrder.SoftUpdate | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a82bccb7fa8d4448e5b320514eb201262)GetShieldDirectionOfUnit()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Agent.UsageDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922a) TaleWorlds.MountAndBlade.ArrangementOrder.GetShieldDirectionOfUnit | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *unit*, | |  |  | [ArrangementOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280) | *orderEnum* ) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a62c3142ecbaa09b869328d4c377c438e)GetUnitSpacing()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.ArrangementOrder.GetUnitSpacing | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a80885f6e94398e2695f8693f35c20af4)Rearrange()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ArrangementOrder.Rearrange | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#aaba4aa856d8284abf30008fb87ab5636)RearrangeAux()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ArrangementOrder.RearrangeAux | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation*, |
|  |  | bool | *isDirectly* ) |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a2e5f7bf100bea41f5e1c7aa46c3623c9)TransposeLineFormation()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.ArrangementOrder.TransposeLineFormation | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#add61d5ed80b195e49ba51a87ce4cf8dc)OnCancel()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ArrangementOrder.OnCancel | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a95903b3f602b34b99a6ffbdbbb865f87)CreateStrategicArea()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [StrategicArea](class_tale_worlds_1_1_mount_and_blade_1_1_strategic_area.html) TaleWorlds.MountAndBlade.ArrangementOrder.CreateStrategicArea | ( | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *scene*, | |  |  | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *position*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *direction*, | |  |  | float | *width*, | |  |  | int | *capacity*, | |  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* ) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a1a56e918b17380217d393c622ea498cc)CreateStrategicAreas()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IEnumerable< [StrategicArea](class_tale_worlds_1_1_mount_and_blade_1_1_strategic_area.html) > TaleWorlds.MountAndBlade.ArrangementOrder.CreateStrategicAreas | ( | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | *mission*, | |  |  | int | *count*, | |  |  | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *center*, | |  |  | float | *distance*, | |  |  | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *target*, | |  |  | float | *width*, | |  |  | int | *capacity*, | |  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* ) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#ae478ab201562507c08c695bad4b52738)TickOccasionally()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ArrangementOrder.TickOccasionally | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#afeb1ce8daa02e0852791c13f5af77f3a)GetNativeEnum()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [ArrangementOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280) TaleWorlds.MountAndBlade.ArrangementOrder.GetNativeEnum | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a83cf07ed6e25cf20283299e4553e231e)Equals()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.MountAndBlade.ArrangementOrder.Equals | ( | object | *obj* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a86a6aed4a5798099110f10574d20ecb1)GetHashCode()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.MountAndBlade.ArrangementOrder.GetHashCode | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#ae62ce4915a3ad495fb73e953fe95732f)operator!=()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.ArrangementOrder.operator!= | ( | [ArrangementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a93368c53fc6e2bdd532739787d857efc) | *a1*, | |  |  | [ArrangementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a93368c53fc6e2bdd532739787d857efc) | *a2* ) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a8af02994c91966ded68596a3143988f8)operator==()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.ArrangementOrder.operator== | ( | [ArrangementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a93368c53fc6e2bdd532739787d857efc) | *a1*, | |  |  | [ArrangementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a93368c53fc6e2bdd532739787d857efc) | *a2* ) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#add7bce6c8d9c496a96bc7c9c4fcab62e)OnOrderPositionChanged()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ArrangementOrder.OnOrderPositionChanged | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *previousOrderPosition* ) |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a2d5016ac2ffaa15529171c0c1854299d)GetArrangementOrderDefensiveness()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.ArrangementOrder.GetArrangementOrderDefensiveness | ( | [ArrangementOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280) | *orderEnum* | ) |  | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#ae093bf92def0759860244adb773ddb99)GetArrangementOrderDefensivenessChange()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.ArrangementOrder.GetArrangementOrderDefensivenessChange | ( | [ArrangementOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280) | *previousOrderEnum*, | |  |  | [ArrangementOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280) | *nextOrderEnum* ) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a148a2e49d337738e7b10f0852077a3e7)CalculateFormationDirectionEnforcingFactorForRank()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.ArrangementOrder.CalculateFormationDirectionEnforcingFactorForRank | ( | int | *formationRankIndex*, |
|  |  | int | *rankCount* ) |

Member Data Documentation
-------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a3f3f5e59b85bae366b00f876fc6d0cdc)OrderEnum
-----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [ArrangementOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280) TaleWorlds.MountAndBlade.ArrangementOrder.OrderEnum |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#ae5f7d6b92cf596f93657acb6fcf392b3)ArrangementOrderCircle
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [ArrangementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a93368c53fc6e2bdd532739787d857efc) TaleWorlds.MountAndBlade.ArrangementOrder.ArrangementOrderCircle = new [ArrangementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a93368c53fc6e2bdd532739787d857efc)([ArrangementOrderEnum.Circle](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280a30954d90085f6eaaf5817917fc5fecb3)) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#aebdf527fabf1c6c53902a1510e0523c3)ArrangementOrderColumn
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [ArrangementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a93368c53fc6e2bdd532739787d857efc) TaleWorlds.MountAndBlade.ArrangementOrder.ArrangementOrderColumn = new [ArrangementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a93368c53fc6e2bdd532739787d857efc)([ArrangementOrderEnum.Column](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280a1976d7f704de389d9fe064e08ea35b2d)) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#aaea37888ff39aeba6dd3501516cde09f)ArrangementOrderLine
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [ArrangementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a93368c53fc6e2bdd532739787d857efc) TaleWorlds.MountAndBlade.ArrangementOrder.ArrangementOrderLine = new [ArrangementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a93368c53fc6e2bdd532739787d857efc)([ArrangementOrderEnum.Line](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280a4803e6b9e63dabf04de980788d6a13c4)) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#ad9ccbc67dbff43dac7c00c4137bd4622)ArrangementOrderLoose
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [ArrangementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a93368c53fc6e2bdd532739787d857efc) TaleWorlds.MountAndBlade.ArrangementOrder.ArrangementOrderLoose = new [ArrangementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a93368c53fc6e2bdd532739787d857efc)([ArrangementOrderEnum.Loose](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280a08d78f099561104c2015d19ea7d9d41e)) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a517ff336bc8c0c0fb9f9a7a8fac6b4e7)ArrangementOrderScatter
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [ArrangementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a93368c53fc6e2bdd532739787d857efc) TaleWorlds.MountAndBlade.ArrangementOrder.ArrangementOrderScatter = new [ArrangementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a93368c53fc6e2bdd532739787d857efc)([ArrangementOrderEnum.Scatter](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280a09870720ca8134284e4e305ac6ce5f19)) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a0cf468e42e4d6beae2eb6a0cbe055881)ArrangementOrderShieldWall
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [ArrangementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a93368c53fc6e2bdd532739787d857efc) TaleWorlds.MountAndBlade.ArrangementOrder.ArrangementOrderShieldWall = new [ArrangementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a93368c53fc6e2bdd532739787d857efc)([ArrangementOrderEnum.ShieldWall](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280a091908edf5a30749347c230f2d806d30)) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a590b3e3e53f2bd84f8f59db66ed1822a)ArrangementOrderSkein
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [ArrangementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a93368c53fc6e2bdd532739787d857efc) TaleWorlds.MountAndBlade.ArrangementOrder.ArrangementOrderSkein = new [ArrangementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a93368c53fc6e2bdd532739787d857efc)([ArrangementOrderEnum.Skein](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280ab98cb5d447f822d60925907c563934ed)) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#ad245cb4e1937ee4bd15d701cccb6922a)ArrangementOrderSquare
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [ArrangementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a93368c53fc6e2bdd532739787d857efc) TaleWorlds.MountAndBlade.ArrangementOrder.ArrangementOrderSquare = new [ArrangementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a93368c53fc6e2bdd532739787d857efc)([ArrangementOrderEnum.Square](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280aceb46ca115d05c51aa5a16a8867c3304)) | | static |

Property Documentation
----------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a867680becb911a10f33ea2bf056deaf5)OrderType
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) TaleWorlds.MountAndBlade.ArrangementOrder.OrderType | | get |

