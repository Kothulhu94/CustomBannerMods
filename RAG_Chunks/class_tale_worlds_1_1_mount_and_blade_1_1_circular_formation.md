--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html ---

TaleWorlds.MountAndBlade.CircularFormation Class ReferenceInherits [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html).

Inherited by [TaleWorlds.MountAndBlade.CircularSchiltronFormation](class_tale_worlds_1_1_mount_and_blade_1_1_circular_schiltron_formation.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [CircularFormation](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#a74a32a0d84dd13ce300496e4726acf9e) ([IFormation](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html) [owner](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#aa5aeaa83bdcfd1aab3d5136669cb8535)) |
| override [IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html) | [Clone](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#a5de7b831c830fb8e3981dff25c0445ce) ([IFormation](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html) formation) |
| override? [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetLocalDirectionOfUnitOrDefault](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#ac27d80ae8fb141c31d7b94a58627d36d) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit) |
| float | [GetCircumferenceFromRankCount](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#ab3d5b6a26e3aca4deab4a999df1dbc0f) (int rankCount) |
| void | [FormFromCircumference](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#afa43fd7e546874c4c7f8f1f0631daa27) (float circumference) |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html) | |
| int | [GetFileCountFromWidth](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a9cc9ce8ed352a96c80e5ace42f2317f7) (float width) |
|  | [LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#af61e6ad0a9baed61cb97dcf24bcfaba9) ([IFormation](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html) ownerFormation, bool isStaggered=true) |
| virtual void | [DeepCopyFrom](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#af31e02e6fbb50a19716fb54d048266b3) ([IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html) arrangement) |
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
| virtual void | [TurnBackwards](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#af0bb32c9af38510f6573a0e85ecbc771) () |
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
| Protected Member Functions | |
| override bool | [IsDeepenApplicable](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#a8c717f0ea6ed9a026d22fdc43365179b) () |
| override bool | [IsNarrowApplicable](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#a2098bc41784e4f677e3470be7c2dca1a) (int amount) |
| override bool | [IsUnitPositionRestrained](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#ada32fe6ab083bf4e53199466adfc67d4) (int fileIndex, int rankIndex) |
| override void | [MakeRestrainedPositionsUnavailable](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#afd548daaf2851c062f91b6b4458b2dfb) () |
| override [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetLocalDirectionOfUnit](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#a24060c218ade7889fb64477501f3e89c) (int fileIndex, int rankIndex) |
| override [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetLocalPositionOfUnit](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#ac8abaa3ba7f3ae5d74ee1cbfe6a47a71) (int fileIndex, int rankIndex) |
| override [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetLocalPositionOfUnitWithAdjustment](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#a1ed20ede8f7bd08064b8ee727d5ca449) (int fileIndex, int rankIndex, float distanceBetweenAgentsAdjustment) |
| override bool | [TryGetUnitPositionIndexFromLocalPosition](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#a50e74eaaae34b59e468f2c441ad90048) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) localPosition, out int fileIndex, out int rankIndex) |
| int | [GetCurrentMaximumRankCount](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#a8fdb52459e4e27d808e54b47913cb50f) (int unitCount) |
| float | [GetCircumferenceAux](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#ad80909860e29a18566847162e4054130) (int unitCount, int rankCount, float radialInterval, float distanceInterval) |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html) | |
| int | [GetUnitCountWithOverride](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a1482f3087fd5bb460052d1374cca27ed) () |
|  | [LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a452b27c89e7d22fdc45b404c5e773217) ([IFormation](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html) ownerFormation, bool isDeformingOnWidthChange, bool isStaggered=true) |
| [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | [GetUnitAt](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a3a9e25364a25bcd9c84948c588d24c5c) (int fileIndex, int rankIndex) |
| void | [RelocateUnit](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#ae8ca8db4dfe1b1ee7d9e8c060e808a85) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit, int fileIndex, int rankIndex) |

|  |  |
| --- | --- |
| Properties | |
| override float | [Width](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#a63911dd5dabfc67b3495b19b911bc0f0) `[get, set]` |
|  | Actual space occupied by the formation along side (x) direction, measured from left to right. |
| override float | [Depth](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#afea527b9b7f6a00a2d4e1d0e4cc3f997) `[get]` |
|  | Actual space occupied by the formation along forward (y) direction, from front to back. |
| override float | [MinimumWidth](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#ad56885a8ad478c35c719719900b4d4f6) `[get]` |
|  | Minimum width of the formation. Using current unit count, minimum unit interval and minimum unit distance. |
| override float | [MaximumWidth](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#a985dd20a797a0091aac1a8569d01d6e8) `[get]` |
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

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#a74a32a0d84dd13ce300496e4726acf9e)CircularFormation()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.CircularFormation.CircularFormation | ( | [IFormation](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html) | *owner* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#a5de7b831c830fb8e3981dff25c0445ce)Clone()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override [IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html) TaleWorlds.MountAndBlade.CircularFormation.Clone | ( | [IFormation](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html) | *formation* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#adcb2fa04513de6999a740cc8126e1d64).

Reimplemented in [TaleWorlds.MountAndBlade.CircularSchiltronFormation](class_tale_worlds_1_1_mount_and_blade_1_1_circular_schiltron_formation.html#abfaba6c9ea567be5be06b20310c6cb27).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#a8c717f0ea6ed9a026d22fdc43365179b)IsDeepenApplicable()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override bool TaleWorlds.MountAndBlade.CircularFormation.IsDeepenApplicable | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a627ac5738d2c7b03ff3e09017b814a22).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#a2098bc41784e4f677e3470be7c2dca1a)IsNarrowApplicable()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override bool TaleWorlds.MountAndBlade.CircularFormation.IsNarrowApplicable | ( | int | *amount* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a120b5d8d38d2c8f78ad03165678d9ab0).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#ada32fe6ab083bf4e53199466adfc67d4)IsUnitPositionRestrained()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override bool TaleWorlds.MountAndBlade.CircularFormation.IsUnitPositionRestrained | ( | int | *fileIndex*, | |  |  | int | *rankIndex* ) | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#ae1bca98a85e5e6f96cd9064be88ff89a).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#afd548daaf2851c062f91b6b4458b2dfb)MakeRestrainedPositionsUnavailable()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.CircularFormation.MakeRestrainedPositionsUnavailable | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a77a3e410375dea4c02d5d175de873f05).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#a24060c218ade7889fb64477501f3e89c)GetLocalDirectionOfUnit()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.CircularFormation.GetLocalDirectionOfUnit | ( | int | *fileIndex*, | |  |  | int | *rankIndex* ) | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#adab2cb47a2732dfff38f3beca0f664d9).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#ac27d80ae8fb141c31d7b94a58627d36d)GetLocalDirectionOfUnitOrDefault()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override? [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.CircularFormation.GetLocalDirectionOfUnitOrDefault | ( | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | *unit* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#ae0a9f503a604a88f6cd6a88dd24594cb).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#ac8abaa3ba7f3ae5d74ee1cbfe6a47a71)GetLocalPositionOfUnit()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.CircularFormation.GetLocalPositionOfUnit | ( | int | *fileIndex*, | |  |  | int | *rankIndex* ) | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#abfe604641fed1c10f40e1c01a2cba02b).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#a1ed20ede8f7bd08064b8ee727d5ca449)GetLocalPositionOfUnitWithAdjustment()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.CircularFormation.GetLocalPositionOfUnitWithAdjustment | ( | int | *fileIndex*, | |  |  | int | *rankIndex*, | |  |  | float | *distanceBetweenAgentsAdjustment* ) | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a232bfde390645794ce503bca43654f95).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#a50e74eaaae34b59e468f2c441ad90048)TryGetUnitPositionIndexFromLocalPosition()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override bool TaleWorlds.MountAndBlade.CircularFormation.TryGetUnitPositionIndexFromLocalPosition | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *localPosition*, | |  |  | out int | *fileIndex*, | |  |  | out int | *rankIndex* ) | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.LineFormation](class_tale_worlds_1_1_mount_and_blade_1_1_line_formation.html#a6887328becb031989168be2c48e93d2a).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#a8fdb52459e4e27d808e54b47913cb50f)GetCurrentMaximumRankCount()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.CircularFormation.GetCurrentMaximumRankCount | ( | int | *unitCount* | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#ab3d5b6a26e3aca4deab4a999df1dbc0f)GetCircumferenceFromRankCount()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.CircularFormation.GetCircumferenceFromRankCount | ( | int | *rankCount* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#afa43fd7e546874c4c7f8f1f0631daa27)FormFromCircumference()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.CircularFormation.FormFromCircumference | ( | float | *circumference* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#ad80909860e29a18566847162e4054130)GetCircumferenceAux()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.CircularFormation.GetCircumferenceAux | ( | int | *unitCount*, | |  |  | int | *rankCount*, | |  |  | float | *radialInterval*, | |  |  | float | *distanceInterval* ) | | protected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#a63911dd5dabfc67b3495b19b911bc0f0)Width
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.MountAndBlade.CircularFormation.Width | | getset |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#ae6868d2f11498b4cab1212058632f721).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#afea527b9b7f6a00a2d4e1d0e4cc3f997)Depth
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.MountAndBlade.CircularFormation.Depth | | get |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a1ecf79938e3f22968b4f3b9ed00962ae).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#ad56885a8ad478c35c719719900b4d4f6)MinimumWidth
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.MountAndBlade.CircularFormation.MinimumWidth | | get |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a3e5c80bbae958b7141074be325d2a3fc).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_circular_formation.html#a985dd20a797a0091aac1a8569d01d6e8)MaximumWidth
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.MountAndBlade.CircularFormation.MaximumWidth | | get |

Implements [TaleWorlds.MountAndBlade.IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html#a1cb7740e6f20be6640de70096f97b548).

