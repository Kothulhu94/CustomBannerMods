--- SOURCE: interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html ---

TaleWorlds.MountAndBlade.IFormationArrangement Interface ReferenceInherited by [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | [GetPlayerUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a32c22789ad6011f58a75ee38d8078ac5) () |
| MBReadOnlyList< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) > | [GetAllUnits](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a6abe84a600b4f267833d44b1360d8c5f) () |
| void | [GetAllUnits](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#ad0a07d5f80401fec4e20d88867b2e987) (in MBList< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) > allUnitsListToBeFilledIn) |
| MBList< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) > | [GetUnpositionedUnits](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a3f83d0764b9f0b83037d9d4ded5ba960) () |
| bool | [AddUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a53f94792e98a99f79305126e5523a48e) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit) |
|  | Adding may fail if there is no vacant position and deepening the formation does not create any new vacant positions. |
| void | [RemoveUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#aa590c4de43334b7d2c358957f3264ec7) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit) |
| [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | [GetUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#ae36460fe10ef540bc37b3dfcad650403) (int fileIndex, int rankIndex) |
|  | Returns the unit at the specified file and rank index Returns null if the specified position is restrained, is not valid or if there is no agent assigned to this position. |
| void | [OnBatchRemoveStart](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a2085c3e610cd50fec71a746eefedabac) () |
|  | Notifies the arrangement that remove operations will be done in batch for performance. Child arrangements should provide their own implementation. |
| void | [OnBatchRemoveEnd](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a255a1df4f76b3d8761f0746b4fd288fc) () |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? | [GetLocalPositionOfUnitOrDefault](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a06380fe6392a767c555b036d8ae7498e) (int unitIndex) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? | [GetLocalPositionOfUnitOrDefault](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a8700124a27d5cfd5a599eef0fe1837b2) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? | [GetLocalPositionOfUnitOrDefaultWithAdjustment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#af17137194d3ec246b194b1db5fa48cfa) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit, float distanceBetweenAgentsAdjustment) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? | [GetLocalDirectionOfUnitOrDefault](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a9d10d06e060da29631c06419ee4c5aed) (int unitIndex) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? | [GetLocalDirectionOfUnitOrDefault](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#ab72e0281ae01128e489da011fc42cac1) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit) |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html)? | [GetWorldPositionOfUnitOrDefault](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#acaae521a85a39a61c3e41c3a66c4f50f) (int unitIndex) |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html)? | [GetWorldPositionOfUnitOrDefault](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#ae46ec8d36431ec66100df9c1bc77cb53) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit) |
| List< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) > | [GetUnitsToPop](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#ad4587c3e6f53978541c429673bcd5c11) (int count) |
| List< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) > | [GetUnitsToPop](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a58b08994df46f18cf265f08810a32990) (int count, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) targetPosition) |
| IEnumerable< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) > | [GetUnitsToPopWithCondition](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#aa32183d476ddaa533fdfc0cb54827834) (int count, Func< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html), bool > conditionFunction) |
| void | [SwitchUnitLocations](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#aa47e0c145f2967367173aa1897051484) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) firstUnit, [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) secondUnit) |
| void | [SwitchUnitLocationsWithUnpositionedUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a43cc204afeaf1d6d84aa8776090ec770) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) firstUnit, [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) secondUnit) |
| void | [SwitchUnitLocationsWithBackMostUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a7741ce1df7d36c03e279a1642001ea99) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit) |
| [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | [GetNeighborUnitOfLeftSide](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a6953a3d189fdeec4c68110289ed4ca4e) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit) |
| [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | [GetNeighborUnitOfRightSide](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#ad4409efc0ae28390225eb06c7f98b778) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? | [GetLocalWallDirectionOfRelativeFormationLocation](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#ad889218ea97d431c87ea2e650c4e0091) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit) |
| IEnumerable< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > | [GetUnavailableUnitPositions](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a30638b69303230d246866448975fe8c1) () |
| float | [GetOccupationWidth](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a7968a6cb7d535d47ed9629bf18d3b6ea) (int unitCount) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? | [CreateNewPosition](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a2f667fdcff79740e5dbb1b3e668efb9f) (int unitIndex) |
| void | [BeforeFormationFrameChange](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#acf7d0bb88e1c195e72acac4028f1d9e3) () |
| void | [OnFormationFrameChanged](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#add9fd60bfd45bc92ecd0cfd87ede4e29) (bool updateCachedOrderedLocalPositions=false) |
| bool | [IsTurnBackwardsNecessary](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a1d7239d88e4e84caac19a39032a5c2a2) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) previousPosition, [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html)? newPosition, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) previousDirection, bool hasNewDirection, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? newDirection) |
| void | [TurnBackwards](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a583fcacfc9f4349a3024a0702433063f) () |
| void | [OnFormationDispersed](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a16b4ebf92e69322841872bcf88b6bfe9) () |
| void | [Reset](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a8434e1dafc7edd8d041c74059b449abe) () |
| [IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html) | [Clone](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a207c093e1e348052e7020dc7da66ce84) ([IFormation](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html) formation) |
| void | [DeepCopyFrom](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#ad9a15d343f3af412d748ab4cdedfe978) ([IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html) arrangement) |
| void | [RearrangeTo](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a1a4d8fb1ed78c6b7d9e93b26e7e486f4) ([IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html) arrangement) |
| void | [RearrangeFrom](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a381c014f2567a97de3f10f8773fe2b1d) ([IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html) arrangement) |
| void | [RearrangeTransferUnits](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a6e34bea198e23bdb84c469bd9a0a502e) ([IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html) arrangement) |
| void | [ReserveMiddleFrontUnitPosition](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#ae65d7187f26fdecadba667f4d5f91d9d) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) vanguard) |
| void | [ReleaseMiddleFrontUnitPosition](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#ab53990c59e26fc60b5df6845a36fb3d8) () |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetLocalPositionOfReservedUnitPosition](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#add707208f600f08e6372c20044073460) () |
| void | [OnTickOccasionallyOfUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#afb294caccbcb96c16056a8646166a765) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit, bool arrangementChangeAllowed) |
| void | [OnUnitLostMount](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a50cc6728f1395b45b9da05757ebdd79b) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit) |
| float | [GetDirectionChangeTendencyOfUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#ae679ba5718f054c821b76b102daf3201) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit) |
| void | [UpdateLocalPositionErrors](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a15834260ca5bb308e54e3f359e549c80) (bool recalculateErrors=true) |

|  |  |
| --- | --- |
| Properties | |
| float | [Width](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#ae6868d2f11498b4cab1212058632f721) `[get, set]` |
|  | Actual space occupied by the formation along side (x) direction, measured from left to right. |
| float | [Depth](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a1ecf79938e3f22968b4f3b9ed00962ae) `[get]` |
|  | Actual space occupied by the formation along forward (y) direction, from front to back. |
| float | [FlankWidth](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a94375778a37a85ec5f5e6b094cb92114) `[get, set]` |
|  | Space occupied from the formation's left most flank to right most flank REMARK\_ATES: For rectangular formations this matches width. For circular formations (and alike) this matches circumference. |
| float | [RankDepth](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a2f97d0763b96aee5d1b08becf71f39ae) `[get]` |
|  | Space occupied from the formation's front rank to back most rank. REMARK\_ATES: For rectangular formations this matches depth. For circular formations (and alike) this matches radius. |
| float | [MinimumWidth](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a3e5c80bbae958b7141074be325d2a3fc) `[get]` |
|  | Minimum width of the formation. Using current unit count, minimum unit interval and minimum unit distance. |
| float | [MaximumWidth](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a1cb7740e6f20be6640de70096f97b548) `[get]` |
|  | Maximum width of the formation. Using current unit count, maximum unit interval and maximum unit distance. |
| float | [MinimumFlankWidth](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a06f2e4d019268f5cbb15b77c7a13376e) `[get]` |
| bool? | [IsLoose](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#afc3574ca66956284e2bb1f2cc11e38d3) `[get]` |
| float | [IntervalMultiplier](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#aada9bbebda964c6c76a4a9f10d30f7a0) `[get]` |
| float | [DistanceMultiplier](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#af4713af02731997131a907d8f24a6c23) `[get]` |
| int | [UnitCount](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#af3f5bef273b1e365406d2deebf0f61f0) `[get]` |
| int | [RankCount](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a189bebd267ba9c27681a2ada579dab0e) `[get]` |
| int | [PositionedUnitCount](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a8a246a7ebd8b74d694b5f9b60af8fbd7) `[get]` |
| bool | [AreLocalPositionsDirty](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#aa555c4d2863671397562a6a26df77a20) `[set]` |

|  |  |
| --- | --- |
| Events | |
| Action | [OnWidthChanged](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a8eca772c003fa241531f6022f57c7cda) |
| Action | [OnShapeChanged](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#aa1835383010828f063c22a87936e55c0) |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a32c22789ad6011f58a75ee38d8078ac5)GetPlayerUnit()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) TaleWorlds.MountAndBlade.IFormationArrangement.GetPlayerUnit | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a42aac95d5de11086096bcd19df59ca07), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a0a74f9a1ae14833d612d5fb9ccf06c10).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a6abe84a600b4f267833d44b1360d8c5f)GetAllUnits() [1/2]
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| MBReadOnlyList< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) > TaleWorlds.MountAndBlade.IFormationArrangement.GetAllUnits | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a8b2e95ba8cef12b7186e88f01deee99e), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#add0225d964627e93cb739ff317367a88).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#ad0a07d5f80401fec4e20d88867b2e987)GetAllUnits() [2/2]
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IFormationArrangement.GetAllUnits | ( | in MBList< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) > | *allUnitsListToBeFilledIn* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a635768e082b0b6c63a907173f3a780f9), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a8929dba4b5372ce4644222775276bd63).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a3f83d0764b9f0b83037d9d4ded5ba960)GetUnpositionedUnits()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| MBList< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) > TaleWorlds.MountAndBlade.IFormationArrangement.GetUnpositionedUnits | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a8c37d1064a45382fe6cfa1e8687ea330), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#ad9fefc58d2ab46f606522f0ed0981fce).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a53f94792e98a99f79305126e5523a48e)AddUnit()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.IFormationArrangement.AddUnit | ( | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | *unit* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | unit |  |

Returns

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a576583fa2f60069a9aa0783b0ac05fbb), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a4684552820ed7082bb52b46decd338be).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#aa590c4de43334b7d2c358957f3264ec7)RemoveUnit()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IFormationArrangement.RemoveUnit | ( | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | *unit* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a7bdd248bd650d0e2e50eb08e739f2e69), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a81527609361fcfd3c5ff4c1f51f61869).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#ae36460fe10ef540bc37b3dfcad650403)GetUnit()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) TaleWorlds.MountAndBlade.IFormationArrangement.GetUnit | ( | int | *fileIndex*, |
|  |  | int | *rankIndex* ) |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a7489aa3624e37cec7e55750a8a8ce5ca), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#add11124d5e82da883d59519ac1fc3aae).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a2085c3e610cd50fec71a746eefedabac)OnBatchRemoveStart()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IFormationArrangement.OnBatchRemoveStart | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a970d1d8c7fa16f7b59429ad19ae8502f), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a88c17f2b05ca61e98a99d3c483d65c5d).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a255a1df4f76b3d8761f0746b4fd288fc)OnBatchRemoveEnd()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IFormationArrangement.OnBatchRemoveEnd | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#ad92b2fefd7c3b866fca488f6f1ee93db), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#aa90ea163ede511ff85b433502e769ea9).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a06380fe6392a767c555b036d8ae7498e)GetLocalPositionOfUnitOrDefault() [1/2]
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? TaleWorlds.MountAndBlade.IFormationArrangement.GetLocalPositionOfUnitOrDefault | ( | int | *unitIndex* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a2cd9e271b2ca42ef7d9ba9039913e702), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a28fadd4a2ee88fdaa5a8ea6dc4a1698b).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a8700124a27d5cfd5a599eef0fe1837b2)GetLocalPositionOfUnitOrDefault() [2/2]
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? TaleWorlds.MountAndBlade.IFormationArrangement.GetLocalPositionOfUnitOrDefault | ( | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | *unit* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a69448c673fc3073da91d2d2fbe72af0e), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a320eba730720807ceec65a88c3e9bfac).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#af17137194d3ec246b194b1db5fa48cfa)GetLocalPositionOfUnitOrDefaultWithAdjustment()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? TaleWorlds.MountAndBlade.IFormationArrangement.GetLocalPositionOfUnitOrDefaultWithAdjustment | ( | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | *unit*, |
|  |  | float | *distanceBetweenAgentsAdjustment* ) |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#ad108ea53fcf1548aa601287c40c2023a), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a30d3af25f65059fd6f1124aecc435908).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a9d10d06e060da29631c06419ee4c5aed)GetLocalDirectionOfUnitOrDefault() [1/2]
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? TaleWorlds.MountAndBlade.IFormationArrangement.GetLocalDirectionOfUnitOrDefault | ( | int | *unitIndex* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a098d94bae6cb8dff6281caae8d3ba028), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#ab07847f7b570643b659637d4ac5cdc2d).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#ab72e0281ae01128e489da011fc42cac1)GetLocalDirectionOfUnitOrDefault() [2/2]
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? TaleWorlds.MountAndBlade.IFormationArrangement.GetLocalDirectionOfUnitOrDefault | ( | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | *unit* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.CircularFormation](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#ac27d80ae8fb141c31d7b94a58627d36d), [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#af0a93e3763fc3d369fc840623c4f6f95), [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#ae0a9f503a604a88f6cd6a88dd24594cb), and [TaleWorlds.MountAndBlade.SquareFormation](class_tale_worlds_1_1_mount_and_blade_1_1_square_formation.html#a904d515bc7fcb84abe320d6a8aa6fe74).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#acaae521a85a39a61c3e41c3a66c4f50f)GetWorldPositionOfUnitOrDefault() [1/2]
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html)? TaleWorlds.MountAndBlade.IFormationArrangement.GetWorldPositionOfUnitOrDefault | ( | int | *unitIndex* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#aed80768728defe9168b1e4d763968cd8), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a365f6acfed78d47f63c1ba769b193f22).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#ae46ec8d36431ec66100df9c1bc77cb53)GetWorldPositionOfUnitOrDefault() [2/2]
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html)? TaleWorlds.MountAndBlade.IFormationArrangement.GetWorldPositionOfUnitOrDefault | ( | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | *unit* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a4174e0f407cfd30e1395a0253adbc076), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#ab34208765576c568144374cd76caf39c).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#ad4587c3e6f53978541c429673bcd5c11)GetUnitsToPop() [1/2]
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| List< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) > TaleWorlds.MountAndBlade.IFormationArrangement.GetUnitsToPop | ( | int | *count* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a0fc58dfdf8f3cd835f94d77ad2bb780e), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a4394a57324b687f029ce11c7a9606274).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a58b08994df46f18cf265f08810a32990)GetUnitsToPop() [2/2]
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| List< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) > TaleWorlds.MountAndBlade.IFormationArrangement.GetUnitsToPop | ( | int | *count*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *targetPosition* ) |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#ab6642593c77e0ec2aa6a4624cda2e876), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#ae2b7e656499c667367e57133247b7b30).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#aa32183d476ddaa533fdfc0cb54827834)GetUnitsToPopWithCondition()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| IEnumerable< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) > TaleWorlds.MountAndBlade.IFormationArrangement.GetUnitsToPopWithCondition | ( | int | *count*, |
|  |  | Func< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html), bool > | *conditionFunction* ) |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a3b745a1eb725795c2941c370206ac197), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#adb6fb57642fad4bc27c76b31e88cb5e9).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#aa47e0c145f2967367173aa1897051484)SwitchUnitLocations()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IFormationArrangement.SwitchUnitLocations | ( | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | *firstUnit*, |
|  |  | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | *secondUnit* ) |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#acf47628e0ca8f93aa3a26cbd074123f4), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a5813cf9b2d0a0289887363495f7afe14).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a43cc204afeaf1d6d84aa8776090ec770)SwitchUnitLocationsWithUnpositionedUnit()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IFormationArrangement.SwitchUnitLocationsWithUnpositionedUnit | ( | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | *firstUnit*, |
|  |  | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | *secondUnit* ) |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a740f8c3c8e8c5e47a4c134f11aa07740), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#af439ae1ab5a6cf51e0d18caf1add1aa0).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a7741ce1df7d36c03e279a1642001ea99)SwitchUnitLocationsWithBackMostUnit()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IFormationArrangement.SwitchUnitLocationsWithBackMostUnit | ( | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | *unit* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a3060cd6e0aa1c8b475e22c6741ef2b14), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a7b04d7cf89307276c7be65596d72b827).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a6953a3d189fdeec4c68110289ed4ca4e)GetNeighborUnitOfLeftSide()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) TaleWorlds.MountAndBlade.IFormationArrangement.GetNeighborUnitOfLeftSide | ( | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | *unit* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a8a2813843674453209083a81c2d6a7bd), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a9a528733baba29bc158b35e3c7ab15f5).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#ad4409efc0ae28390225eb06c7f98b778)GetNeighborUnitOfRightSide()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) TaleWorlds.MountAndBlade.IFormationArrangement.GetNeighborUnitOfRightSide | ( | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | *unit* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a3f463cd36d0c5d6e6d4de3af04ec4d1a), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#ac422d8cfd2423822c307b27ecadc1f1a).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#ad889218ea97d431c87ea2e650c4e0091)GetLocalWallDirectionOfRelativeFormationLocation()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? TaleWorlds.MountAndBlade.IFormationArrangement.GetLocalWallDirectionOfRelativeFormationLocation | ( | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | *unit* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#adf228e91f7724e70e53460063c65bb9f), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a7a0b7dcb3d3a6e075b80ad0d60e4b011).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a30638b69303230d246866448975fe8c1)GetUnavailableUnitPositions()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > TaleWorlds.MountAndBlade.IFormationArrangement.GetUnavailableUnitPositions | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a45b1775f9a912dc2ad330e19ae2164e3), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a8f1ff0ee186eb5e46f96d8d6fbb43716).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a7968a6cb7d535d47ed9629bf18d3b6ea)GetOccupationWidth()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.IFormationArrangement.GetOccupationWidth | ( | int | *unitCount* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a0396a9001e7b6bfb582ef98b7c1cce7e), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a1605581599861ba8537089d4ff4bdb6b).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a2f667fdcff79740e5dbb1b3e668efb9f)CreateNewPosition()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? TaleWorlds.MountAndBlade.IFormationArrangement.CreateNewPosition | ( | int | *unitIndex* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a06ff4d35fe40b9a19c6545273162bcec), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a22123a25295d87b37978397972325db0).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#acf7d0bb88e1c195e72acac4028f1d9e3)BeforeFormationFrameChange()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IFormationArrangement.BeforeFormationFrameChange | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a30612ff457801000410f1849c301f81e), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a78b2d6c7f683522a3cdb2ad1a068877c).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#add9fd60bfd45bc92ecd0cfd87ede4e29)OnFormationFrameChanged()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IFormationArrangement.OnFormationFrameChanged | ( | bool | *updateCachedOrderedLocalPositions* = false | ) |  |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a1b470d7b3e6414214120342ab1e7887c), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a01ee9a009d0d4f79900f7c54140be6fa).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a1d7239d88e4e84caac19a39032a5c2a2)IsTurnBackwardsNecessary()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.IFormationArrangement.IsTurnBackwardsNecessary | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *previousPosition*, |
|  |  | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html)? | *newPosition*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *previousDirection*, |
|  |  | bool | *hasNewDirection*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? | *newDirection* ) |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a3ae58195fb58db067c8afd7a30dd3edf), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a2e6087e185738ff4ca81214f5dc6d6c9).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a583fcacfc9f4349a3024a0702433063f)TurnBackwards()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IFormationArrangement.TurnBackwards | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#aabdcf368fbd1d1a3fe4d6f986b99f0bf), [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#af0bb32c9af38510f6573a0e85ecbc771), and [TaleWorlds.MountAndBlade.SquareFormation](class_tale_worlds_1_1_mount_and_blade_1_1_square_formation.html#a5feed29788c903ac3fb6b33a1a62b69f).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a16b4ebf92e69322841872bcf88b6bfe9)OnFormationDispersed()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IFormationArrangement.OnFormationDispersed | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a333981a7f4ce30e56ac13c64255cd880), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#aee534bb23a7ff8b6617193bc9a681e4d).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a8434e1dafc7edd8d041c74059b449abe)Reset()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IFormationArrangement.Reset | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a568c56ad34007f9cf022e00e50df69d7), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#ae899370e39c0859c5fee5678f9fa4561).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a207c093e1e348052e7020dc7da66ce84)Clone()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html) TaleWorlds.MountAndBlade.IFormationArrangement.Clone | ( | [IFormation](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html) | *formation* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.CircularFormation](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#a5de7b831c830fb8e3981dff25c0445ce), [TaleWorlds.MountAndBlade.CircularSchiltronFormation](class_tale_worlds_1_1_mount_and_blade_1_1_circular_schiltron_formation.html#abfaba6c9ea567be5be06b20310c6cb27), [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a1f4944024551fe1d2f86869613f049ef), [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#adcb2fa04513de6999a740cc8126e1d64), [TaleWorlds.MountAndBlade.RectilinearSchiltronFormation](class_tale_worlds_1_1_mount_and_blade_1_1_rectilinear_schiltron_formation.html#a90d90863943853513f722f1649888d37), [TaleWorlds.MountAndBlade.SkeinFormation](class_tale_worlds_1_1_mount_and_blade_1_1_skein_formation.html#a892a801b311a35892c49f2c7391ea0c9), [TaleWorlds.MountAndBlade.SquareFormation](class_tale_worlds_1_1_mount_and_blade_1_1_square_formation.html#a3e744753874aaf38055457e95e510c46), [TaleWorlds.MountAndBlade.TransposedLineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_transposed_line_formation.html#a65ccb399edae2d475f09ea4018f6e394), and [TaleWorlds.MountAndBlade.WedgeFormation](class_tale_worlds_1_1_mount_and_blade_1_1_wedge_formation.html#a25de5d32bc554f883d26943eab0acfa3).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#ad9a15d343f3af412d748ab4cdedfe978)DeepCopyFrom()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IFormationArrangement.DeepCopyFrom | ( | [IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html) | *arrangement* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a2f153bdef0930d1633240eb9bada8d87), [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#af31e02e6fbb50a19716fb54d048266b3), and [TaleWorlds.MountAndBlade.SquareFormation](class_tale_worlds_1_1_mount_and_blade_1_1_square_formation.html#abe5a4ffe2e9eb213ad1f42a3d01d3534).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a1a4d8fb1ed78c6b7d9e93b26e7e486f4)RearrangeTo()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IFormationArrangement.RearrangeTo | ( | [IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html) | *arrangement* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#ab096bebe119dc1c0bf6159d50b3ea543), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#ad82999fa02f02a8d3601883c82c33e28).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a381c014f2567a97de3f10f8773fe2b1d)RearrangeFrom()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IFormationArrangement.RearrangeFrom | ( | [IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html) | *arrangement* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#aa7195e1891201b75b7639009ff6582d0), [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a1e6b60338dab64bd1a1b48d4d2a83a50), and [TaleWorlds.MountAndBlade.TransposedLineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_transposed_line_formation.html#a6c93de990bc74521dbf278e57e8654a4).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a6e34bea198e23bdb84c469bd9a0a502e)RearrangeTransferUnits()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IFormationArrangement.RearrangeTransferUnits | ( | [IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html) | *arrangement* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a4b53b51f20799187461c458a0d31b37d), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a11337053da33cbe6cf52f32eed7a6758).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#ae65d7187f26fdecadba667f4d5f91d9d)ReserveMiddleFrontUnitPosition()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IFormationArrangement.ReserveMiddleFrontUnitPosition | ( | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | *vanguard* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a9fea29db30c7f198d725794657fb3587), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a005d7bf4c8902b5dd7d02fd2206d5021).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#ab53990c59e26fc60b5df6845a36fb3d8)ReleaseMiddleFrontUnitPosition()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IFormationArrangement.ReleaseMiddleFrontUnitPosition | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#af5f4bacab90b350c448ed46e76d22277), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a817080a4821f1c74a237592596f27023).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#add707208f600f08e6372c20044073460)GetLocalPositionOfReservedUnitPosition()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.IFormationArrangement.GetLocalPositionOfReservedUnitPosition | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a2ca4f9fbba99015484ab9ce611804bb1), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a5324c9e09350ddfc07efbb4641b9d3a3).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#afb294caccbcb96c16056a8646166a765)OnTickOccasionallyOfUnit()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IFormationArrangement.OnTickOccasionallyOfUnit | ( | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | *unit*, |
|  |  | bool | *arrangementChangeAllowed* ) |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#aee6ea8206ffb018cd4517da1a94cc21f), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#ae768eeec9e8ca2319f82f4697331a9ff).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a50cc6728f1395b45b9da05757ebdd79b)OnUnitLostMount()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IFormationArrangement.OnUnitLostMount | ( | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | *unit* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a9e7951ca7ff496b1d39def0242bf92b3), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a1be40d4c2d101151b8c5b43cf7bd7bc2).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#ae679ba5718f054c821b76b102daf3201)GetDirectionChangeTendencyOfUnit()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.IFormationArrangement.GetDirectionChangeTendencyOfUnit | ( | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | *unit* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a82acfb590f74fbb4e96e80b8d890f373), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a7cfa6dd26ef36929f35f4c0fd59bd4bd).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a15834260ca5bb308e54e3f359e549c80)UpdateLocalPositionErrors()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IFormationArrangement.UpdateLocalPositionErrors | ( | bool | *recalculateErrors* = true | ) |  |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a48ef7b2a9a9593671195f0668da6ed9f), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a14f9e0e6958134bc64db4200fe4996cc).

Property Documentation
----------------------

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#ae6868d2f11498b4cab1212058632f721)Width
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.IFormationArrangement.Width | | getset |

Implemented in [TaleWorlds.MountAndBlade.CircularFormation](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#a63911dd5dabfc67b3495b19b911bc0f0), [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#ab7e049d4a81e5c186596bb40a50d14ca), [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a9b9abb6f5f14d4ad08bc04fb846137a9), and [TaleWorlds.MountAndBlade.SquareFormation](class_tale_worlds_1_1_mount_and_blade_1_1_square_formation.html#a87db4c48e3c967575fd5ced3e1ccd05b).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a1ecf79938e3f22968b4f3b9ed00962ae)Depth
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.IFormationArrangement.Depth | | get |

Implemented in [TaleWorlds.MountAndBlade.CircularFormation](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#afea527b9b7f6a00a2d4e1d0e4cc3f997), [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a120f6be253e534a835c46f00133feab6), [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a5a62cd96f4868206a6b4d9c73a50e9d9), and [TaleWorlds.MountAndBlade.SquareFormation](class_tale_worlds_1_1_mount_and_blade_1_1_square_formation.html#ad607461d3cbd85b6fdcb92e060da3fcb).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a94375778a37a85ec5f5e6b094cb92114)FlankWidth
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.IFormationArrangement.FlankWidth | | getset |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#ad35a68e82bc3d2e2155450fbbd0f8478), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#ad5a42164c7022400e81057d4f292de69).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a2f97d0763b96aee5d1b08becf71f39ae)RankDepth
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.IFormationArrangement.RankDepth | | get |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a3bf8b7787fbaf22491d73e7526798dc6), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#aeb4940251f15b46527dbb00059c6aef9).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a3e5c80bbae958b7141074be325d2a3fc)MinimumWidth
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.IFormationArrangement.MinimumWidth | | get |

Implemented in [TaleWorlds.MountAndBlade.CircularFormation](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#ad56885a8ad478c35c719719900b4d4f6), [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#afead97b31a44056b11b0eedfb7fb7cc6), [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a2c2c0097e654067e42764f77ab833efd), and [TaleWorlds.MountAndBlade.SquareFormation](class_tale_worlds_1_1_mount_and_blade_1_1_square_formation.html#ad0498366a0a49c1629edf7a9a50344ce).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a1cb7740e6f20be6640de70096f97b548)MaximumWidth
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.IFormationArrangement.MaximumWidth | | get |

Implemented in [TaleWorlds.MountAndBlade.CircularFormation](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#a985dd20a797a0091aac1a8569d01d6e8), [TaleWorlds.MountAndBlade.CircularSchiltronFormation](class_tale_worlds_1_1_mount_and_blade_1_1_circular_schiltron_formation.html#a937c2a24575a759351cddae812d8fb0f), [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a17459b47b7bf46bff501030218d2f1bd), [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a0d91236568334bd781bddf1f9082e72b), [TaleWorlds.MountAndBlade.RectilinearSchiltronFormation](class_tale_worlds_1_1_mount_and_blade_1_1_rectilinear_schiltron_formation.html#adba29dcdc764c05758da2b2ed6a08ca4), and [TaleWorlds.MountAndBlade.SquareFormation](class_tale_worlds_1_1_mount_and_blade_1_1_square_formation.html#a8fbef5453625184c90cdf0314ee667b4).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a06f2e4d019268f5cbb15b77c7a13376e)MinimumFlankWidth
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.IFormationArrangement.MinimumFlankWidth | | get |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a8e699c36d5105b8b99ce45eeadc989f8), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a02920d5f458a2e7a465351fe7b77eec5).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#afc3574ca66956284e2bb1f2cc11e38d3)IsLoose
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool? TaleWorlds.MountAndBlade.IFormationArrangement.IsLoose | | get |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a733545cd9af348645ac2417336adab5b), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a734b86432f500ecedbc0a2f478ddd662).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#aada9bbebda964c6c76a4a9f10d30f7a0)IntervalMultiplier
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.IFormationArrangement.IntervalMultiplier | | get |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a663d928db46c6806f2581a51c4aa263f), [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a74c0226ed71d566de925b51f65f7e53f), and [TaleWorlds.MountAndBlade.TransposedLineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_transposed_line_formation.html#a04d2d4627ce17203cdab5cff2ea36ff9).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#af4713af02731997131a907d8f24a6c23)DistanceMultiplier
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.IFormationArrangement.DistanceMultiplier | | get |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a7caab215cb5e839666af86c6496226d6), [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a0760e217232b8bf2266695953a8a14cc), and [TaleWorlds.MountAndBlade.TransposedLineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_transposed_line_formation.html#adefa558c3d4463b1c2f7a767bb2a6f9c).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#af3f5bef273b1e365406d2deebf0f61f0)UnitCount
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.IFormationArrangement.UnitCount | | get |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a34b3280ccfccea28ba1717f9b0824011), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a34ab9d761ba38764c6a51d38e82d8dab).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a189bebd267ba9c27681a2ada579dab0e)RankCount
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.IFormationArrangement.RankCount | | get |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a62b43ff31d3b9304fdd36ac4bc624b67), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a47e40e769be5946ccf3ada66f5b166fe).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a8a246a7ebd8b74d694b5f9b60af8fbd7)PositionedUnitCount
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.IFormationArrangement.PositionedUnitCount | | get |

Implemented in [TaleWorlds.MountAndBlade.ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html#a0da8e29071daf30633fb6d45945eda86), and [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#ab444f044f844786416d83c73623854b5).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#aa555c4d2863671397562a6a26df77a20)AreLocalPositionsDirty
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.IFormationArrangement.AreLocalPositionsDirty | | set |

Implemented in [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a3ab98d106ec6ed41cb8e2aaf0639a8b1).

Event Documentation
-------------------

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a8eca772c003fa241531f6022f57c7cda)OnWidthChanged
-------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action TaleWorlds.MountAndBlade.IFormationArrangement.OnWidthChanged |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#aa1835383010828f063c22a87936e55c0)OnShapeChanged
-------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action TaleWorlds.MountAndBlade.IFormationArrangement.OnShapeChanged |

