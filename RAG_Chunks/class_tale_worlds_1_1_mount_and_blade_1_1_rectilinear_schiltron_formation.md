--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_rectilinear_schiltron_formation.html ---

TaleWorlds.MountAndBlade.RectilinearSchiltronFormation Class ReferenceInherits [TaleWorlds.MountAndBlade.SquareFormation](class_tale_worlds_1_1_mount_and_blade_1_1_square_formation.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [RectilinearSchiltronFormation](class_tale_worlds_1_1_mount_and_blade_1_1_rectilinear_schiltron_formation.html#afdee9604cd550f089a99db2967db5565) ([IFormation](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html) [owner](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#aa5aeaa83bdcfd1aab3d5136669cb8535)) |
| override [IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html) | [Clone](class_tale_worlds_1_1_mount_and_blade_1_1_rectilinear_schiltron_formation.html#a90d90863943853513f722f1649888d37) ([IFormation](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html) formation) |
| void | [Form](class_tale_worlds_1_1_mount_and_blade_1_1_rectilinear_schiltron_formation.html#a4ab3aba778b27426a201621b37a9ca47) () |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.SquareFormation](class_tale_worlds_1_1_mount_and_blade_1_1_square_formation.html) | |
|  | [SquareFormation](class_tale_worlds_1_1_mount_and_blade_1_1_square_formation.html#a19130ec07443f4f4de7ca1295f62310f) ([IFormation](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html) [owner](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#aa5aeaa83bdcfd1aab3d5136669cb8535)) |
| override [IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html) | [Clone](class_tale_worlds_1_1_mount_and_blade_1_1_square_formation.html#a3e744753874aaf38055457e95e510c46) ([IFormation](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html) formation) |
| override void | [DeepCopyFrom](class_tale_worlds_1_1_mount_and_blade_1_1_square_formation.html#abe5a4ffe2e9eb213ad1f42a3d01d3534) ([IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html) arrangement) |
| void | [FormFromBorderSideWidth](class_tale_worlds_1_1_mount_and_blade_1_1_square_formation.html#a62765cd0ede97b33af63cfd545675f38) (float borderSideWidth) |
| void | [FormFromBorderUnitCountPerSide](class_tale_worlds_1_1_mount_and_blade_1_1_square_formation.html#aaefe7b446ed47aaa2946969005d2859c) (int unitCountPerSide) |
| int | [GetUnitsPerSideFromRankCount](class_tale_worlds_1_1_mount_and_blade_1_1_square_formation.html#abc4858d81a69ab4f5c47a32e189e568d) (int rankCount) |
| void | [FormFromRankCount](class_tale_worlds_1_1_mount_and_blade_1_1_square_formation.html#aa2ca8e7db01e3491b4e8051bfeb28566) (int rankCount) |
| override? [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetLocalDirectionOfUnitOrDefault](class_tale_worlds_1_1_mount_and_blade_1_1_square_formation.html#a904d515bc7fcb84abe320d6a8aa6fe74) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit) |
| override void | [TurnBackwards](class_tale_worlds_1_1_mount_and_blade_1_1_square_formation.html#a5feed29788c903ac3fb6b33a1a62b69f) () |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html) | |
| int | [GetFileCountFromWidth](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a9cc9ce8ed352a96c80e5ace42f2317f7) (float width) |
|  | [LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#af61e6ad0a9baed61cb97dcf24bcfaba9) ([IFormation](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html) ownerFormation, bool isStaggered=true) |
| void | [Reset](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#ae899370e39c0859c5fee5678f9fa4561) () |
| bool | [IsUnitPositionAvailable](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a0a4334fdb9dfd4d20188dd50ae5c1110) (int fileIndex, int rankIndex) |
|  | Checks if unit position is a valid point in the scene. |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? | [GetLocalPositionOfUnitOrDefault](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a28fadd4a2ee88fdaa5a8ea6dc4a1698b) (int unitIndex) |
|  | Gets the local position of unit with index of fill order. |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? | [GetLocalDirectionOfUnitOrDefault](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#ab07847f7b570643b659637d4ac5cdc2d) (int unitIndex) |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html)? | [GetWorldPositionOfUnitOrDefault](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a365f6acfed78d47f63c1ba769b193f22) (int unitIndex) |
| IEnumerable< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > | [GetUnavailableUnitPositions](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a8f1ff0ee186eb5e46f96d8d6fbb43716) () |
| bool | [AddUnit](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a4684552820ed7082bb52b46decd338be) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit) |
|  | Adding may fail if there is no vacant position and deepening the formation does not create any new vacant positions. |
| void | [RemoveUnit](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a81527609361fcfd3c5ff4c1f51f61869) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit) |
| [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | [GetUnit](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#add11124d5e82da883d59519ac1fc3aae) (int fileIndex, int rankIndex) |
|  | Returns the unit at the specified file and rank index Returns null if the specified position is restrained, is not valid or if there is no agent assigned to this position. |
| void | [OnBatchRemoveStart](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a88c17f2b05ca61e98a99d3c483d65c5d) () |
|  | Notifies the arrangement that remove operations will be done in batch for performance. Child arrangements should provide their own implementation. |
| void | [OnBatchRemoveEnd](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#aa90ea163ede511ff85b433502e769ea9) () |
| List< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) > | [GetUnitsToPop](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a4394a57324b687f029ce11c7a9606274) (int count) |
| IEnumerable< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) > | [GetUnitsToPopWithCondition](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#adb6fb57642fad4bc27c76b31e88cb5e9) (int count, Func< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html), bool > currentCondition) |
| List< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) > | [GetUnitsToPop](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#ae2b7e656499c667367e57133247b7b30) (int count, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) targetPosition) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? | [GetLocalPositionOfUnitOrDefault](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a320eba730720807ceec65a88c3e9bfac) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? | [GetLocalPositionOfUnitOrDefaultWithAdjustment](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a30d3af25f65059fd6f1124aecc435908) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit, float distanceBetweenAgentsAdjustment) |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html)? | [GetWorldPositionOfUnitOrDefault](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#ab34208765576c568144374cd76caf39c) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit) |
| [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | [GetPlayerUnit](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a0a74f9a1ae14833d612d5fb9ccf06c10) () |
| MBReadOnlyList< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) > | [GetAllUnits](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#add0225d964627e93cb739ff317367a88) () |
| void | [GetAllUnits](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a8929dba4b5372ce4644222775276bd63) (in MBList< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) > allUnitsListToBeFilledIn) |
| MBList< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) > | [GetUnpositionedUnits](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#ad9fefc58d2ab46f606522f0ed0981fce) () |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? | [GetLocalDirectionOfRelativeFormationLocation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#aa1ce6e1ecc10de5abab26c144a8f2908) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? | [GetLocalWallDirectionOfRelativeFormationLocation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a7a0b7dcb3d3a6e075b80ad0d60e4b011) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit) |
| void | [GetFormationInfo](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a719a08f625a2975ff13bedbc1671ddd8) (out int fileCount, out int rankCount) |
| float | [GetUnitsDistanceToFrontLine](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#ad8736c55c80e3d2a8af2d4ed983d1481) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit) |
| [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | [GetNeighborUnitOfLeftSide](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a9a528733baba29bc158b35e3c7ab15f5) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit) |
| [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | [GetNeighborUnitOfRightSide](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#ac422d8cfd2423822c307b27ecadc1f1a) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit) |
| void | [SwitchUnitLocationsWithUnpositionedUnit](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#af439ae1ab5a6cf51e0d18caf1add1aa0) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) firstUnit, [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) secondUnit) |
| void | [SwitchUnitLocations](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a5813cf9b2d0a0289887363495f7afe14) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) firstUnit, [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) secondUnit) |
| void | [SwitchUnitLocationsWithBackMostUnit](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a7b04d7cf89307276c7be65596d72b827) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit) |
| void | [BeforeFormationFrameChange](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a78b2d6c7f683522a3cdb2ad1a068877c) () |
| void | [BatchUnitPositionAvailabilities](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a99cc933f0cb21febcce6622d4d2e65b0) (bool isUpdatingCachedOrderedLocalPositions=true) |
| void | [OnFormationFrameChanged](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a01ee9a009d0d4f79900f7c54140be6fa) (bool updateCachedOrderedLocalPositions=false) |
|  | Unit position availabilities may change due to frame change. If so, this method moves units around so every unit position is available and there are no gaps in the formation. |
| void | [UpdateLocalPositionErrors](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a14f9e0e6958134bc64db4200fe4996cc) (bool recalculateErrors) |
| void | [OnFormationDispersed](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#aee534bb23a7ff8b6617193bc9a681e4d) () |
| void | [OnUnitLostMount](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a1be40d4c2d101151b8c5b43cf7bd7bc2) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit) |
| bool | [IsTurnBackwardsNecessary](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a2e6087e185738ff4ca81214f5dc6d6c9) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) previousPosition, [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html)? newPosition, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) previousDirection, bool hasNewDirection, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? newDirection) |
| float | [GetOccupationWidth](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a1605581599861ba8537089d4ff4bdb6b) (int unitCount) |
| void | [InvalidateCacheOfUnitAux](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#aadb1c8eff21c200b2f9733940cb0542d) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) roundedLocalPosition) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? | [CreateNewPosition](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a22123a25295d87b37978397972325db0) (int unitIndex) |
| virtual void | [RearrangeFrom](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a1e6b60338dab64bd1a1b48d4d2a83a50) ([IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html) arrangement) |
| virtual void | [RearrangeTo](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#ad82999fa02f02a8d3601883c82c33e28) ([IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html) arrangement) |
| virtual void | [RearrangeTransferUnits](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a11337053da33cbe6cf52f32eed7a6758) ([IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html) arrangement) |
| void | [FormFromFlankWidth](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#aab6aa5377c0ab244ac2c53e42b728ab2) (int unitCountOnLine, bool skipSingleFileChangesForPerformance=false) |
| void | [ReserveMiddleFrontUnitPosition](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a005d7bf4c8902b5dd7d02fd2206d5021) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) vanguard) |
| void | [ReleaseMiddleFrontUnitPosition](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a817080a4821f1c74a237592596f27023) () |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetLocalPositionOfReservedUnitPosition](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a5324c9e09350ddfc07efbb4641b9d3a3) () |
| virtual void | [OnTickOccasionallyOfUnit](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#ae768eeec9e8ca2319f82f4697331a9ff) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit, bool arrangementChangeAllowed) |
| virtual float | [GetDirectionChangeTendencyOfUnit](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a7cfa6dd26ef36929f35f4c0fd59bd4bd) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit) |
| int | [GetCachedOrderedAndAvailableUnitPositionIndicesCount](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a13316cef2eba58548b4d04b50ba736ce) () |
|  | Used only for getting troop positions before any formation or troops are present in multiplayer, not to be used for casual formation operations. |
| [PositionIndexType](namespace_tale_worlds_1_1_mount_and_blade.html#aed254a8aa6d6d58cf96232353b220c23) | [GetCachedOrderedAndAvailableUnitPositionIndexAt](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a40f04ab566fb09f415591d96c81793ce) (int i) |
|  | Used only for getting troop positions before any formation or troops are present in multiplayer, not to be used for casual formation operations. |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | [GetGlobalPositionAtIndex](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a2649301a8aa162de2a4613c5267568f7) (int indexX, int indexY) |
|  | Used only for getting troop positions before any formation or troops are present in multiplayer, not to be used for casual formation operations. |

|  |  |
| --- | --- |
| Properties | |
| override float | [MaximumWidth](class_tale_worlds_1_1_mount_and_blade_1_1_rectilinear_schiltron_formation.html#adba29dcdc764c05758da2b2ed6a08ca4) `[get]` |
|  | Maximum width of the formation. Using current unit count, maximum unit interval and maximum unit distance. |
| Properties inherited from [TaleWorlds.MountAndBlade.SquareFormation](class_tale_worlds_1_1_mount_and_blade_1_1_square_formation.html) | |
| override float | [Width](class_tale_worlds_1_1_mount_and_blade_1_1_square_formation.html#a87db4c48e3c967575fd5ced3e1ccd05b) `[get, set]` |
|  | Actual space occupied by the formation along side (x) direction, measured from left to right. |
| override float | [Depth](class_tale_worlds_1_1_mount_and_blade_1_1_square_formation.html#ad607461d3cbd85b6fdcb92e060da3fcb) `[get]` |
|  | Actual space occupied by the formation along forward (y) direction, from front to back. |
| override float | [MinimumWidth](class_tale_worlds_1_1_mount_and_blade_1_1_square_formation.html#ad0498366a0a49c1629edf7a9a50344ce) `[get]` |
|  | Minimum width of the formation. Using current unit count, minimum unit interval and minimum unit distance. |
| override float | [MaximumWidth](class_tale_worlds_1_1_mount_and_blade_1_1_square_formation.html#a8fbef5453625184c90cdf0314ee667b4) `[get]` |
|  | Maximum width of the formation. Using current unit count, maximum unit interval and maximum unit distance. |
| Properties inherited from [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html) | |
| int | [FileCount](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a74d8ba2c11d8962898d967cfaea4aa15) `[get]` |
| int | [RankCount](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a47e40e769be5946ccf3ada66f5b166fe) `[get]` |
| bool | [AreLocalPositionsDirty](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a3ab98d106ec6ed41cb8e2aaf0639a8b1) `[protected get, set]` |
| float | [Interval](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#ab31e2920e4d786c6aba85554c1d14b12) `[get]` |
|  | The lateral space between units on one same line. |
| virtual float | [IntervalMultiplier](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a74c0226ed71d566de925b51f65f7e53f) `[get]` |
| float | [Distance](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#ac77da62a95e33be6c3cd7e343985a9da) `[get]` |
|  | Space between units in the direction of depth. |
| virtual float | [DistanceMultiplier](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a0760e217232b8bf2266695953a8a14cc) `[get]` |
| float | [UnitDiameter](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a2828a7024d44d964126a61c0c0a6c6bb) `[get]` |
|  | Size of a single unit. |
| virtual float | [Width](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a9b9abb6f5f14d4ad08bc04fb846137a9) `[get, set]` |
|  | Actual space occupied by the formation, measured from left to right. |
| virtual float | [Depth](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a5a62cd96f4868206a6b4d9c73a50e9d9) `[get]` |
|  | Actual space occupied by the formation, from front to back. |
| float | [FlankWidth](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#ad5a42164c7022400e81057d4f292de69) `[get, set]` |
|  | The space occupied by the formation, measured from left to right most flank. |
| float | [RankDepth](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#aeb4940251f15b46527dbb00059c6aef9) `[get]` |
|  | The space occupied by the formation, from front rank to back most rank. |
| float | [MinimumFlankWidth](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a02920d5f458a2e7a465351fe7b77eec5) `[get]` |
| virtual float | [MinimumWidth](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a2c2c0097e654067e42764f77ab833efd) `[get]` |
|  | Minimum width of the formation. Using current unit count, minimum unit interval and minimum unit distance. |
| virtual float | [MaximumWidth](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a0d91236568334bd781bddf1f9082e72b) `[get]` |
|  | Maximum width of the formation. Using current unit count, maximum unit interval and maximum unit distance. |
| bool | [IsStaggered](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#ac1cd3f4db128eacc55ea02f492867232) `[get, set]` |
| virtual ? bool | [IsLoose](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a734b86432f500ecedbc0a2f478ddd662) `[get]` |
| bool | [PostponeReconstructUnitsFromUnits2D](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#ac423e422cfabf0f829d6efc11e72d2bd) `[get, set]` |
| int | [UnitCount](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a34ab9d761ba38764c6a51d38e82d8dab) `[get]` |
| int | [PositionedUnitCount](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#ab444f044f844786416d83c73623854b5) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html) | |
| static float | [CalculateWidth](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#aba6a195bbe20126a7f8ab5e0fc8a63e7) (float interval, float unitDiameter, int unitCountOnLine) |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.SquareFormation](class_tale_worlds_1_1_mount_and_blade_1_1_square_formation.html) | |
| override [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetLocalPositionOfUnit](class_tale_worlds_1_1_mount_and_blade_1_1_square_formation.html#a1f35cc749a4c3e32a183a4262af1dd7e) (int fileIndex, int rankIndex) |
| override [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetLocalPositionOfUnitWithAdjustment](class_tale_worlds_1_1_mount_and_blade_1_1_square_formation.html#a8dbbad5f58e3f4334bd40177851270d8) (int fileIndex, int rankIndex, float distanceBetweenAgentsAdjustment) |
| override [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetLocalDirectionOfUnit](class_tale_worlds_1_1_mount_and_blade_1_1_square_formation.html#a2cd2df67b3b3c1820633cf85f5acdff2) (int fileIndex, int rankIndex) |
| override bool | [IsUnitPositionRestrained](class_tale_worlds_1_1_mount_and_blade_1_1_square_formation.html#a07ba180e46c1a1d66f5f3cf160010516) (int fileIndex, int rankIndex) |
| override void | [MakeRestrainedPositionsUnavailable](class_tale_worlds_1_1_mount_and_blade_1_1_square_formation.html#a5393d314915f1b925ecc342256af2713) () |
| override bool | [TryGetUnitPositionIndexFromLocalPosition](class_tale_worlds_1_1_mount_and_blade_1_1_square_formation.html#a6ba20381eecbb665cc5d1f86212104f4) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) localPosition, out int fileIndex, out int rankIndex) |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html) | |
| int | [GetUnitCountWithOverride](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a1482f3087fd5bb460052d1374cca27ed) () |
|  | [LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a452b27c89e7d22fdc45b404c5e773217) ([IFormation](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html) ownerFormation, bool isDeformingOnWidthChange, bool isStaggered=true) |
| [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | [GetUnitAt](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a3a9e25364a25bcd9c84948c588d24c5c) (int fileIndex, int rankIndex) |
| virtual bool | [IsDeepenApplicable](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a627ac5738d2c7b03ff3e09017b814a22) () |
| virtual bool | [IsNarrowApplicable](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a120b5d8d38d2c8f78ad03165678d9ab0) (int amount) |
| void | [RelocateUnit](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#ae8ca8db4dfe1b1ee7d9e8c060e808a85) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit, int fileIndex, int rankIndex) |
| Static Protected Member Functions inherited from [TaleWorlds.MountAndBlade.SquareFormation](class_tale_worlds_1_1_mount_and_blade_1_1_square_formation.html) | |
| static int | [GetMaximumRankCount](class_tale_worlds_1_1_mount_and_blade_1_1_square_formation.html#adad055c53de5fdc6abbe505734aeed01) (int unitCount, out int minimumFlankCount) |
| static float | [GetSideWidthFromUnitCount](class_tale_worlds_1_1_mount_and_blade_1_1_square_formation.html#a004362b20122a703adffa784f7afc78f) (int sideUnitCount, float interval, float unitDiameter) |
| Protected Attributes inherited from [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html) | |
| readonly [IFormation](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html) | [owner](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#aa5aeaa83bdcfd1aab3d5136669cb8535) |
| MBList2D< int > | [UnitPositionAvailabilities](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a66a04eb9905e0702d6eafc40af68c070) |
|  | This table is for caching position availabilities of the units for method [IsUnitPositionAvailable](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a0a4334fdb9dfd4d20188dd50ae5c1110 "Checks if unit position is a valid point in the scene."). |
| bool | [IsTransforming](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#aa14d2654a558a375c792520c784f4aec) |
| Static Protected Attributes inherited from [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html) | |
| const int | [UnitPositionAvailabilityValueOfUnprocessed](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a5a05ca6d417993989e3ece161edc553e) = 0 |
| const int | [UnitPositionAvailabilityValueOfUnavailable](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a5685c3e0d1e1302987c968486d20e6ea) = 1 |
| const int | [UnitPositionAvailabilityValueOfAvailable](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a6036f39294b2870acd71b92073bde463) = 2 |
| Events inherited from [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html) | |
| Action | [OnWidthChanged](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a5c71f495986a9643f2d34bb02d79ef91) |
| Action | [OnShapeChanged](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a0f1e7246276faf07d3b3121331384375) |
| Events inherited from [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html) | |
| Action | [OnWidthChanged](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a8eca772c003fa241531f6022f57c7cda) |
| Action | [OnShapeChanged](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#aa1835383010828f063c22a87936e55c0) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_rectilinear_schiltron_formation.html#afdee9604cd550f089a99db2967db5565)RectilinearSchiltronFormation()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.RectilinearSchiltronFormation.RectilinearSchiltronFormation | ( | [IFormation](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html) | *owner* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_rectilinear_schiltron_formation.html#a90d90863943853513f722f1649888d37)Clone()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override [IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html) TaleWorlds.MountAndBlade.RectilinearSchiltronFormation.Clone | ( | [IFormation](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html) | *formation* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#adcb2fa04513de6999a740cc8126e1d64).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_rectilinear_schiltron_formation.html#a4ab3aba778b27426a201621b37a9ca47)Form()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.RectilinearSchiltronFormation.Form | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_rectilinear_schiltron_formation.html#adba29dcdc764c05758da2b2ed6a08ca4)MaximumWidth
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.MountAndBlade.RectilinearSchiltronFormation.MaximumWidth | | get |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a1cb7740e6f20be6640de70096f97b548).

