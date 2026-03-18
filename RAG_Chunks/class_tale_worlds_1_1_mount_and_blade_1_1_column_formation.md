--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html ---

TaleWorlds.MountAndBlade.ColumnFormation Class ReferenceSingle file formation.

Inherits [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a9ac1bc59793e5f1a4e16bcd519b2ac31) ([IFormation](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html) ownerFormation, [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) vanguard=null, int columnCount=1) |
| [IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html) | [Clone](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a1f4944024551fe1d2f86869613f049ef) ([IFormation](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html) formation) |
| void | [DeepCopyFrom](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a2f153bdef0930d1633240eb9bada8d87) ([IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html) arrangement) |
| [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | [GetPlayerUnit](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a42aac95d5de11086096bcd19df59ca07) () |
| MBReadOnlyList< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) > | [GetAllUnits](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a8b2e95ba8cef12b7186e88f01deee99e) () |
| void | [GetAllUnits](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a635768e082b0b6c63a907173f3a780f9) (in MBList< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) > allUnitsListToBeFilledIn) |
| MBList< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) > | [GetUnpositionedUnits](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a8c37d1064a45382fe6cfa1e8687ea330) () |
| bool | [AddUnit](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a576583fa2f60069a9aa0783b0ac05fbb) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit) |
|  | Adding may fail if there is no vacant position and deepening the formation does not create any new vacant positions. |
| void | [RemoveUnit](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a7bdd248bd650d0e2e50eb08e739f2e69) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit) |
| [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | [GetUnit](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a7489aa3624e37cec7e55750a8a8ce5ca) (int fileIndex, int rankIndex) |
|  | Returns the unit at the specified file and rank index Returns null if the specified position is restrained, is not valid or if there is no agent assigned to this position. |
| void | [OnBatchRemoveStart](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a970d1d8c7fa16f7b59429ad19ae8502f) () |
|  | Notifies the arrangement that remove operations will be done in batch for performance. Child arrangements should provide their own implementation. |
| void | [OnBatchRemoveEnd](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#ad92b2fefd7c3b866fca488f6f1ee93db) () |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? | [GetLocalPositionOfUnitOrDefault](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a2cd9e271b2ca42ef7d9ba9039913e702) (int unitIndex) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? | [GetLocalDirectionOfUnitOrDefault](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a098d94bae6cb8dff6281caae8d3ba028) (int unitIndex) |
| Engine.? [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | [GetWorldPositionOfUnitOrDefault](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#aed80768728defe9168b1e4d763968cd8) (int unitIndex) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? | [GetLocalPositionOfUnitOrDefault](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a69448c673fc3073da91d2d2fbe72af0e) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? | [GetLocalPositionOfUnitOrDefaultWithAdjustment](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#ad108ea53fcf1548aa601287c40c2023a) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit, float distanceBetweenAgentsAdjustment) |
| Engine.? [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | [GetWorldPositionOfUnitOrDefault](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a4174e0f407cfd30e1395a0253adbc076) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? | [GetLocalDirectionOfUnitOrDefault](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#af0a93e3763fc3d369fc840623c4f6f95) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit) |
| List< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) > | [GetUnitsToPop](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a0fc58dfdf8f3cd835f94d77ad2bb780e) (int count) |
| List< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) > | [GetUnitsToPop](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#ab6642593c77e0ec2aa6a4624cda2e876) (int count, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) targetPosition) |
| IEnumerable< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) > | [GetUnitsToPopWithCondition](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a3b745a1eb725795c2941c370206ac197) (int count, Func< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html), bool > currentCondition) |
| void | [SwitchUnitLocations](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#acf47628e0ca8f93aa3a26cbd074123f4) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) firstUnit, [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) secondUnit) |
| void | [SwitchUnitLocationsWithUnpositionedUnit](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a740f8c3c8e8c5e47a4c134f11aa07740) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) firstUnit, [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) secondUnit) |
| void | [SwitchUnitLocationsWithBackMostUnit](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a3060cd6e0aa1c8b475e22c6741ef2b14) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit) |
| float | [GetUnitsDistanceToFrontLine](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a9071374fd27a87a5a6e0df3746e90169) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? | [GetLocalDirectionOfRelativeFormationLocation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a50cb3557431728eeed93a313dc4b5b3a) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? | [GetLocalWallDirectionOfRelativeFormationLocation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#adf228e91f7724e70e53460063c65bb9f) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit) |
| IEnumerable< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > | [GetUnavailableUnitPositions](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a45b1775f9a912dc2ad330e19ae2164e3) () |
| float | [GetOccupationWidth](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a0396a9001e7b6bfb582ef98b7c1cce7e) (int unitCount) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? | [CreateNewPosition](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a06ff4d35fe40b9a19c6545273162bcec) (int unitIndex) |
| void | [InvalidateCacheOfUnitAux](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#acaa61a808ce6caa29cde7e6a656a5bd3) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) roundedLocalPosition) |
| void | [BeforeFormationFrameChange](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a30612ff457801000410f1849c301f81e) () |
| void | [OnFormationFrameChanged](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a1b470d7b3e6414214120342ab1e7887c) (bool updateCachedOrderedLocalPositions=false) |
| void | [OnUnitLostMount](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a9e7951ca7ff496b1d39def0242bf92b3) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit) |
| bool | [IsTurnBackwardsNecessary](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a3ae58195fb58db067c8afd7a30dd3edf) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) previousPosition, [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html)? newPosition, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) previousDirection, bool hasNewDirection, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? newDirection) |
| void | [TurnBackwards](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#aabdcf368fbd1d1a3fe4d6f986b99f0bf) () |
| void | [OnFormationDispersed](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a333981a7f4ce30e56ac13c64255cd880) () |
| void | [Reset](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a568c56ad34007f9cf022e00e50df69d7) () |
| virtual void | [RearrangeFrom](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#aa7195e1891201b75b7639009ff6582d0) ([IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html) arrangement) |
| virtual void | [RearrangeTo](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#ab096bebe119dc1c0bf6159d50b3ea543) ([IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html) arrangement) |
| virtual void | [RearrangeTransferUnits](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a4b53b51f20799187461c458a0d31b37d) ([IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html) arrangement) |
| void | [FormFromWidth](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a1219bcf218b2be219903ebd083c6b5a5) (float width) |
| [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | [GetNeighborUnitOfLeftSide](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a8a2813843674453209083a81c2d6a7bd) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit) |
| [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | [GetNeighborUnitOfRightSide](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a3f463cd36d0c5d6e6d4de3af04ec4d1a) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit) |
| void | [ReserveMiddleFrontUnitPosition](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a9fea29db30c7f198d725794657fb3587) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) vanguard) |
| void | [ReleaseMiddleFrontUnitPosition](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#af5f4bacab90b350c448ed46e76d22277) () |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetLocalPositionOfReservedUnitPosition](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a2ca4f9fbba99015484ab9ce611804bb1) () |
| void | [OnTickOccasionallyOfUnit](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#aee6ea8206ffb018cd4517da1a94cc21f) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit, bool arrangementChangeAllowed) |
| float | [GetDirectionChangeTendencyOfUnit](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a82acfb590f74fbb4e96e80b8d890f373) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit) |
| IEnumerable< T > | [GetUnitsAtVanguardFile< T >](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a301e84e185872f3a69bbc8410808e0e5) () |
| void | [UpdateLocalPositionErrors](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a48ef7b2a9a9593671195f0668da6ed9f) (bool recalculateErrors) |
| List< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > | [GetUnitPositionsOnVanguardFileIndex](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a7319d35e0b38fe2edd59232b9049336e) () |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static readonly int | [ArrangementAspectRatio](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#aa9a015783f5d606211ce5ae7a9af35e3) = 5 |

|  |  |
| --- | --- |
| Protected Member Functions | |
| int | [GetUnitCountWithOverride](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#ad8d374495d15bb166aa2edf83917777f) () |

|  |  |
| --- | --- |
| Properties | |
| [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | [Vanguard](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a70fdf91077ac0aedad269caf9d4bd322) `[get]` |
|  | Forward unit of the column. |
| int | [ColumnCount](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#ad271c1edd36e196b7294eabcfab490d9) `[get, set]` |
| int | [FileCount](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#accb70c706bd8bb223722ba6324415152) `[get]` |
| int | [RankCount](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a62b43ff31d3b9304fdd36ac4bc624b67) `[get]` |
| int | [VanguardFileIndex](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a82036c9eea820fd9946e48b597f9cc58) `[get]` |
| float | [Distance](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#ab6d68b262a94fc622a876c7a21376b7b) `[get]` |
|  | Space between units in the direction of depth. |
| float | [DistanceMultiplier](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a7caab215cb5e839666af86c6496226d6) `[get]` |
| float | [Interval](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#ad7282f62f35828080c8c2aef5111278c) `[get]` |
|  | The lateral space between units on one same line. |
| float | [IntervalMultiplier](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a663d928db46c6806f2581a51c4aa263f) `[get]` |
| float | [Width](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#ab7e049d4a81e5c186596bb40a50d14ca) `[get, set]` |
|  | Actual space occupied by the formation along side (x) direction, measured from left to right. |
| float | [FlankWidth](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#ad35a68e82bc3d2e2155450fbbd0f8478) `[get, set]` |
|  | The space occupied by the formation, measured from left to right most flank. |
| List< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > | [UnitPositionsOnVanguardFileIndex](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a049dce02785cf0bc2a962b6f838f9235) `[get]` |
| float | [Depth](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a120f6be253e534a835c46f00133feab6) `[get]` |
|  | Actual space occupied by the formation along forward (y) direction, from front to back. |
| float | [RankDepth](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a3bf8b7787fbaf22491d73e7526798dc6) `[get]` |
|  | The space occupied by the formation, from front rank to back most rank. |
| float | [MinimumWidth](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#afead97b31a44056b11b0eedfb7fb7cc6) `[get]` |
|  | Minimum width of the formation. Using current unit count, minimum unit interval and minimum unit distance. |
| float | [MaximumWidth](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a17459b47b7bf46bff501030218d2f1bd) `[get]` |
|  | Maximum width of the formation. Using current unit count, maximum unit interval and maximum unit distance. |
| float | [MinimumFlankWidth](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a8e699c36d5105b8b99ce45eeadc989f8) `[get]` |
| bool? | [IsLoose](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a733545cd9af348645ac2417336adab5b) `[get]` |
| int | [UnitCount](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a34b3280ccfccea28ba1717f9b0824011) `[get]` |
| int | [PositionedUnitCount](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a0da8e29071daf30633fb6d45945eda86) `[get]` |

|  |  |
| --- | --- |
| Events | |
| Action | [OnWidthChanged](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#ab62b765a88940448e8e43620921b91bf) |
| Action | [OnShapeChanged](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a99c7a22b2d445a6df9cd633864b2bc7a) |
| Events inherited from [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html) | |
| Action | [OnWidthChanged](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a8eca772c003fa241531f6022f57c7cda) |
| Action | [OnShapeChanged](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#aa1835383010828f063c22a87936e55c0) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a9ac1bc59793e5f1a4e16bcd519b2ac31)ColumnFormation()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.ColumnFormation.ColumnFormation | ( | [IFormation](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html) | *ownerFormation*, |
|  |  | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | *vanguard* = null, |
|  |  | int | *columnCount* = 1 ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a1f4944024551fe1d2f86869613f049ef)Clone()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html) TaleWorlds.MountAndBlade.ColumnFormation.Clone | ( | [IFormation](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html) | *formation* | ) |  |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a207c093e1e348052e7020dc7da66ce84).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a2f153bdef0930d1633240eb9bada8d87)DeepCopyFrom()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ColumnFormation.DeepCopyFrom | ( | [IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html) | *arrangement* | ) |  |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#ad9a15d343f3af412d748ab4cdedfe978).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a42aac95d5de11086096bcd19df59ca07)GetPlayerUnit()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) TaleWorlds.MountAndBlade.ColumnFormation.GetPlayerUnit | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a32c22789ad6011f58a75ee38d8078ac5).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a8b2e95ba8cef12b7186e88f01deee99e)GetAllUnits() [1/2]
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| MBReadOnlyList< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) > TaleWorlds.MountAndBlade.ColumnFormation.GetAllUnits | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a6abe84a600b4f267833d44b1360d8c5f).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a635768e082b0b6c63a907173f3a780f9)GetAllUnits() [2/2]
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ColumnFormation.GetAllUnits | ( | in MBList< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) > | *allUnitsListToBeFilledIn* | ) |  |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#ad0a07d5f80401fec4e20d88867b2e987).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a8c37d1064a45382fe6cfa1e8687ea330)GetUnpositionedUnits()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| MBList< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) > TaleWorlds.MountAndBlade.ColumnFormation.GetUnpositionedUnits | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a3f83d0764b9f0b83037d9d4ded5ba960).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a576583fa2f60069a9aa0783b0ac05fbb)AddUnit()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.ColumnFormation.AddUnit | ( | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | *unit* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | unit |  |

Returns

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a53f94792e98a99f79305126e5523a48e).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a7bdd248bd650d0e2e50eb08e739f2e69)RemoveUnit()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ColumnFormation.RemoveUnit | ( | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | *unit* | ) |  |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#aa590c4de43334b7d2c358957f3264ec7).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a7489aa3624e37cec7e55750a8a8ce5ca)GetUnit()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) TaleWorlds.MountAndBlade.ColumnFormation.GetUnit | ( | int | *fileIndex*, |
|  |  | int | *rankIndex* ) |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#ae36460fe10ef540bc37b3dfcad650403).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a970d1d8c7fa16f7b59429ad19ae8502f)OnBatchRemoveStart()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ColumnFormation.OnBatchRemoveStart | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a2085c3e610cd50fec71a746eefedabac).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#ad92b2fefd7c3b866fca488f6f1ee93db)OnBatchRemoveEnd()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ColumnFormation.OnBatchRemoveEnd | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a255a1df4f76b3d8761f0746b4fd288fc).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a2cd9e271b2ca42ef7d9ba9039913e702)GetLocalPositionOfUnitOrDefault() [1/2]
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? TaleWorlds.MountAndBlade.ColumnFormation.GetLocalPositionOfUnitOrDefault | ( | int | *unitIndex* | ) |  |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a06380fe6392a767c555b036d8ae7498e).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a098d94bae6cb8dff6281caae8d3ba028)GetLocalDirectionOfUnitOrDefault() [1/2]
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? TaleWorlds.MountAndBlade.ColumnFormation.GetLocalDirectionOfUnitOrDefault | ( | int | *unitIndex* | ) |  |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a9d10d06e060da29631c06419ee4c5aed).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#aed80768728defe9168b1e4d763968cd8)GetWorldPositionOfUnitOrDefault() [1/2]
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| Engine.? [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) TaleWorlds.MountAndBlade.ColumnFormation.GetWorldPositionOfUnitOrDefault | ( | int | *unitIndex* | ) |  |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#acaae521a85a39a61c3e41c3a66c4f50f).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a69448c673fc3073da91d2d2fbe72af0e)GetLocalPositionOfUnitOrDefault() [2/2]
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? TaleWorlds.MountAndBlade.ColumnFormation.GetLocalPositionOfUnitOrDefault | ( | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | *unit* | ) |  |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a8700124a27d5cfd5a599eef0fe1837b2).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#ad108ea53fcf1548aa601287c40c2023a)GetLocalPositionOfUnitOrDefaultWithAdjustment()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? TaleWorlds.MountAndBlade.ColumnFormation.GetLocalPositionOfUnitOrDefaultWithAdjustment | ( | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | *unit*, |
|  |  | float | *distanceBetweenAgentsAdjustment* ) |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#af17137194d3ec246b194b1db5fa48cfa).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a4174e0f407cfd30e1395a0253adbc076)GetWorldPositionOfUnitOrDefault() [2/2]
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| Engine.? [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) TaleWorlds.MountAndBlade.ColumnFormation.GetWorldPositionOfUnitOrDefault | ( | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | *unit* | ) |  |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#ae46ec8d36431ec66100df9c1bc77cb53).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#af0a93e3763fc3d369fc840623c4f6f95)GetLocalDirectionOfUnitOrDefault() [2/2]
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? TaleWorlds.MountAndBlade.ColumnFormation.GetLocalDirectionOfUnitOrDefault | ( | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | *unit* | ) |  |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#ab72e0281ae01128e489da011fc42cac1).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a0fc58dfdf8f3cd835f94d77ad2bb780e)GetUnitsToPop() [1/2]
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| List< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) > TaleWorlds.MountAndBlade.ColumnFormation.GetUnitsToPop | ( | int | *count* | ) |  |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#ad4587c3e6f53978541c429673bcd5c11).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#ab6642593c77e0ec2aa6a4624cda2e876)GetUnitsToPop() [2/2]
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| List< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) > TaleWorlds.MountAndBlade.ColumnFormation.GetUnitsToPop | ( | int | *count*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *targetPosition* ) |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a58b08994df46f18cf265f08810a32990).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a3b745a1eb725795c2941c370206ac197)GetUnitsToPopWithCondition()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| IEnumerable< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) > TaleWorlds.MountAndBlade.ColumnFormation.GetUnitsToPopWithCondition | ( | int | *count*, |
|  |  | Func< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html), bool > | *currentCondition* ) |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#aa32183d476ddaa533fdfc0cb54827834).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#acf47628e0ca8f93aa3a26cbd074123f4)SwitchUnitLocations()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ColumnFormation.SwitchUnitLocations | ( | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | *firstUnit*, |
|  |  | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | *secondUnit* ) |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#aa47e0c145f2967367173aa1897051484).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a740f8c3c8e8c5e47a4c134f11aa07740)SwitchUnitLocationsWithUnpositionedUnit()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ColumnFormation.SwitchUnitLocationsWithUnpositionedUnit | ( | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | *firstUnit*, |
|  |  | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | *secondUnit* ) |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a43cc204afeaf1d6d84aa8776090ec770).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a3060cd6e0aa1c8b475e22c6741ef2b14)SwitchUnitLocationsWithBackMostUnit()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ColumnFormation.SwitchUnitLocationsWithBackMostUnit | ( | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | *unit* | ) |  |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a7741ce1df7d36c03e279a1642001ea99).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a9071374fd27a87a5a6e0df3746e90169)GetUnitsDistanceToFrontLine()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.ColumnFormation.GetUnitsDistanceToFrontLine | ( | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | *unit* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a50cb3557431728eeed93a313dc4b5b3a)GetLocalDirectionOfRelativeFormationLocation()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? TaleWorlds.MountAndBlade.ColumnFormation.GetLocalDirectionOfRelativeFormationLocation | ( | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | *unit* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#adf228e91f7724e70e53460063c65bb9f)GetLocalWallDirectionOfRelativeFormationLocation()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? TaleWorlds.MountAndBlade.ColumnFormation.GetLocalWallDirectionOfRelativeFormationLocation | ( | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | *unit* | ) |  |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#ad889218ea97d431c87ea2e650c4e0091).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a45b1775f9a912dc2ad330e19ae2164e3)GetUnavailableUnitPositions()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > TaleWorlds.MountAndBlade.ColumnFormation.GetUnavailableUnitPositions | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a30638b69303230d246866448975fe8c1).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a0396a9001e7b6bfb582ef98b7c1cce7e)GetOccupationWidth()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.ColumnFormation.GetOccupationWidth | ( | int | *unitCount* | ) |  |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a7968a6cb7d535d47ed9629bf18d3b6ea).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a06ff4d35fe40b9a19c6545273162bcec)CreateNewPosition()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? TaleWorlds.MountAndBlade.ColumnFormation.CreateNewPosition | ( | int | *unitIndex* | ) |  |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a2f667fdcff79740e5dbb1b3e668efb9f).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#acaa61a808ce6caa29cde7e6a656a5bd3)InvalidateCacheOfUnitAux()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ColumnFormation.InvalidateCacheOfUnitAux | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *roundedLocalPosition* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a30612ff457801000410f1849c301f81e)BeforeFormationFrameChange()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ColumnFormation.BeforeFormationFrameChange | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#acf7d0bb88e1c195e72acac4028f1d9e3).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a1b470d7b3e6414214120342ab1e7887c)OnFormationFrameChanged()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ColumnFormation.OnFormationFrameChanged | ( | bool | *updateCachedOrderedLocalPositions* = false | ) |  |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#add9fd60bfd45bc92ecd0cfd87ede4e29).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a9e7951ca7ff496b1d39def0242bf92b3)OnUnitLostMount()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ColumnFormation.OnUnitLostMount | ( | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | *unit* | ) |  |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a50cc6728f1395b45b9da05757ebdd79b).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a3ae58195fb58db067c8afd7a30dd3edf)IsTurnBackwardsNecessary()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.ColumnFormation.IsTurnBackwardsNecessary | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *previousPosition*, |
|  |  | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html)? | *newPosition*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *previousDirection*, |
|  |  | bool | *hasNewDirection*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? | *newDirection* ) |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a1d7239d88e4e84caac19a39032a5c2a2).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#aabdcf368fbd1d1a3fe4d6f986b99f0bf)TurnBackwards()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ColumnFormation.TurnBackwards | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a583fcacfc9f4349a3024a0702433063f).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a333981a7f4ce30e56ac13c64255cd880)OnFormationDispersed()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ColumnFormation.OnFormationDispersed | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a16b4ebf92e69322841872bcf88b6bfe9).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a568c56ad34007f9cf022e00e50df69d7)Reset()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ColumnFormation.Reset | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a8434e1dafc7edd8d041c74059b449abe).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#aa7195e1891201b75b7639009ff6582d0)RearrangeFrom()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.ColumnFormation.RearrangeFrom | ( | [IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html) | *arrangement* | ) |  | | virtual |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a381c014f2567a97de3f10f8773fe2b1d).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#ab096bebe119dc1c0bf6159d50b3ea543)RearrangeTo()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.ColumnFormation.RearrangeTo | ( | [IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html) | *arrangement* | ) |  | | virtual |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a1a4d8fb1ed78c6b7d9e93b26e7e486f4).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a4b53b51f20799187461c458a0d31b37d)RearrangeTransferUnits()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.ColumnFormation.RearrangeTransferUnits | ( | [IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html) | *arrangement* | ) |  | | virtual |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a6e34bea198e23bdb84c469bd9a0a502e).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#ad8d374495d15bb166aa2edf83917777f)GetUnitCountWithOverride()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.ColumnFormation.GetUnitCountWithOverride | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a1219bcf218b2be219903ebd083c6b5a5)FormFromWidth()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ColumnFormation.FormFromWidth | ( | float | *width* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a8a2813843674453209083a81c2d6a7bd)GetNeighborUnitOfLeftSide()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) TaleWorlds.MountAndBlade.ColumnFormation.GetNeighborUnitOfLeftSide | ( | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | *unit* | ) |  |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a6953a3d189fdeec4c68110289ed4ca4e).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a3f463cd36d0c5d6e6d4de3af04ec4d1a)GetNeighborUnitOfRightSide()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) TaleWorlds.MountAndBlade.ColumnFormation.GetNeighborUnitOfRightSide | ( | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | *unit* | ) |  |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#ad4409efc0ae28390225eb06c7f98b778).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a9fea29db30c7f198d725794657fb3587)ReserveMiddleFrontUnitPosition()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ColumnFormation.ReserveMiddleFrontUnitPosition | ( | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | *vanguard* | ) |  |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#ae65d7187f26fdecadba667f4d5f91d9d).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#af5f4bacab90b350c448ed46e76d22277)ReleaseMiddleFrontUnitPosition()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ColumnFormation.ReleaseMiddleFrontUnitPosition | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#ab53990c59e26fc60b5df6845a36fb3d8).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a2ca4f9fbba99015484ab9ce611804bb1)GetLocalPositionOfReservedUnitPosition()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.ColumnFormation.GetLocalPositionOfReservedUnitPosition | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#add707208f600f08e6372c20044073460).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#aee6ea8206ffb018cd4517da1a94cc21f)OnTickOccasionallyOfUnit()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ColumnFormation.OnTickOccasionallyOfUnit | ( | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | *unit*, |
|  |  | bool | *arrangementChangeAllowed* ) |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#afb294caccbcb96c16056a8646166a765).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a82acfb590f74fbb4e96e80b8d890f373)GetDirectionChangeTendencyOfUnit()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.ColumnFormation.GetDirectionChangeTendencyOfUnit | ( | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | *unit* | ) |  |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#ae679ba5718f054c821b76b102daf3201).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a301e84e185872f3a69bbc8410808e0e5)GetUnitsAtVanguardFile< T >()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< T > TaleWorlds.MountAndBlade.ColumnFormation.GetUnitsAtVanguardFile< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html)* |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a48ef7b2a9a9593671195f0668da6ed9f)UpdateLocalPositionErrors()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ColumnFormation.UpdateLocalPositionErrors | ( | bool | *recalculateErrors* | ) |  |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a15834260ca5bb308e54e3f359e549c80).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a7319d35e0b38fe2edd59232b9049336e)GetUnitPositionsOnVanguardFileIndex()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| List< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > TaleWorlds.MountAndBlade.ColumnFormation.GetUnitPositionsOnVanguardFileIndex | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#aa9a015783f5d606211ce5ae7a9af35e3)ArrangementAspectRatio
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly int TaleWorlds.MountAndBlade.ColumnFormation.ArrangementAspectRatio = 5 | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a70fdf91077ac0aedad269caf9d4bd322)Vanguard
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) TaleWorlds.MountAndBlade.ColumnFormation.Vanguard | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#ad271c1edd36e196b7294eabcfab490d9)ColumnCount
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ColumnFormation.ColumnCount | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#accb70c706bd8bb223722ba6324415152)FileCount
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ColumnFormation.FileCount | | getprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a62b43ff31d3b9304fdd36ac4bc624b67)RankCount
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ColumnFormation.RankCount | | get |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a189bebd267ba9c27681a2ada579dab0e).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a82036c9eea820fd9946e48b597f9cc58)VanguardFileIndex
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ColumnFormation.VanguardFileIndex | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#ab6d68b262a94fc622a876c7a21376b7b)Distance
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.ColumnFormation.Distance | | getprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a7caab215cb5e839666af86c6496226d6)DistanceMultiplier
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.ColumnFormation.DistanceMultiplier | | get |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#af4713af02731997131a907d8f24a6c23).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#ad7282f62f35828080c8c2aef5111278c)Interval
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.ColumnFormation.Interval | | getprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a663d928db46c6806f2581a51c4aa263f)IntervalMultiplier
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.ColumnFormation.IntervalMultiplier | | get |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#aada9bbebda964c6c76a4a9f10d30f7a0).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#ab7e049d4a81e5c186596bb40a50d14ca)Width
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.ColumnFormation.Width | | getset |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#ae6868d2f11498b4cab1212058632f721).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#ad35a68e82bc3d2e2155450fbbd0f8478)FlankWidth
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.ColumnFormation.FlankWidth | | getset |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a94375778a37a85ec5f5e6b094cb92114).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a049dce02785cf0bc2a962b6f838f9235)UnitPositionsOnVanguardFileIndex
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)> TaleWorlds.MountAndBlade.ColumnFormation.UnitPositionsOnVanguardFileIndex | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a120f6be253e534a835c46f00133feab6)Depth
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.ColumnFormation.Depth | | get |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a1ecf79938e3f22968b4f3b9ed00962ae).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a3bf8b7787fbaf22491d73e7526798dc6)RankDepth
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.ColumnFormation.RankDepth | | get |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a2f97d0763b96aee5d1b08becf71f39ae).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#afead97b31a44056b11b0eedfb7fb7cc6)MinimumWidth
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.ColumnFormation.MinimumWidth | | get |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a3e5c80bbae958b7141074be325d2a3fc).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a17459b47b7bf46bff501030218d2f1bd)MaximumWidth
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.ColumnFormation.MaximumWidth | | get |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a1cb7740e6f20be6640de70096f97b548).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a8e699c36d5105b8b99ce45eeadc989f8)MinimumFlankWidth
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.ColumnFormation.MinimumFlankWidth | | get |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a06f2e4d019268f5cbb15b77c7a13376e).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a733545cd9af348645ac2417336adab5b)IsLoose
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool? TaleWorlds.MountAndBlade.ColumnFormation.IsLoose | | get |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#afc3574ca66956284e2bb1f2cc11e38d3).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a34b3280ccfccea28ba1717f9b0824011)UnitCount
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ColumnFormation.UnitCount | | get |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#af3f5bef273b1e365406d2deebf0f61f0).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a0da8e29071daf30633fb6d45945eda86)PositionedUnitCount
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ColumnFormation.PositionedUnitCount | | get |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a8a246a7ebd8b74d694b5f9b60af8fbd7).

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#ab62b765a88940448e8e43620921b91bf)OnWidthChanged
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action TaleWorlds.MountAndBlade.ColumnFormation.OnWidthChanged |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a99c7a22b2d445a6df9cd633864b2bc7a)OnShapeChanged
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action TaleWorlds.MountAndBlade.ColumnFormation.OnShapeChanged |

