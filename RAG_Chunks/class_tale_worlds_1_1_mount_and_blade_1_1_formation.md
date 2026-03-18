--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_formation.html ---

TaleWorlds.MountAndBlade.Formation Class ReferencesealedInherits [TaleWorlds.MountAndBlade.IFormation](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html).

|  |  |
| --- | --- |
| Classes | |
| struct | [FormationIntegrityDataGroup](struct_tale_worlds_1_1_mount_and_blade_1_1_formation_1_1_formation_integrity_data_group.html) |
| class | [RetreatPositionCacheSystem](class_tale_worlds_1_1_mount_and_blade_1_1_formation_1_1_retreat_position_cache_system.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a652b19eb51d801d5676e612af2602458) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a197f8d61e357068919155a35a51ce674) team, int index) |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | [CreateNewOrderWorldPosition](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a12f3f4b081308833c5433aacf3aa9ca1) ([WorldPosition.WorldPositionEnforcedCache](struct_tale_worlds_1_1_engine_1_1_world_position.html#a329057f863819c6dea70ecaf11784df9) worldPositionEnforcedCache) |
|  | Creates new world position from the order position. Warning: this reduces the efficiency of world position ground height caching. Avoid using this if possible. |
| void | [SetMovementOrder](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#adb38f7dd5b33999d6469c921dff9cba4) ([MovementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html) input) |
| void | [SetFacingOrder](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a19fd9e7cd2ae2ed9d4476379e6c8dd29) ([FacingOrder](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a00fd2370583b7af1b6004788e9cb7075) order) |
| void | [SetArrangementOrder](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a5fec10f739ab2334c194d2dad0c277b3) ([ArrangementOrder](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#afb7942c27906e9c5cc0b0be788680277) order) |
| void | [SetFormOrder](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a574df0890b9297cf6ff840c817ca3841) ([FormOrder](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a56666478bfe043dfc00675eecfb65c34) order, bool updateDesiredFileCount=true) |
| void | [SetRidingOrder](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a0b9619775629768372043eccc3ed1064) ([RidingOrder](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a995f2bb7f801ea3af2153842c38a84da) order) |
| void | [SetFiringOrder](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a5e3f76ab4c691c8a257b74d7cabab6e9) ([FiringOrder](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a006674b13a96fe8900cd6b7aa57e51db) order) |
| void | [SetControlledByAI](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a2832fc6e97c874ffae9a972e64df5e6d) (bool isControlledByAI, bool enforceNotSplittableByAI=false) |
|  | Sets if formation is controlled by the [AI](namespace_tale_worlds_1_1_mount_and_blade_1_1_a_i.html). |
| void | [SetTargetFormation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a2e82f0cf5523349c766eeda8b2024bf8) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a652b19eb51d801d5676e612af2602458) targetFormation) |
| void | [OnDeploymentFinished](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a3104510e17b227481d72a34f7a0a5b6b) () |
| void | [ResetArrangementOrderTickTimer](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a10d33712241941665f98a228fc4c3ad2) () |
| void | [SetPositioning](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a073b4cf50f2c347d5aabed04729efd81) ([WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html)? position=null, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? direction=null, int? unitSpacing=null) |
| int | [GetCountOfUnitsWithCondition](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ae8aeb1da36038f7a8b9d2fb95e163bff) (Func< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), bool > function) |
| ref readonly [MovementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html) | [GetReadonlyMovementOrderReference](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#aeb958312049a7544d0db8d12e41b9800) () |
|  | Don't try to use returned value to call member functions of it that changes the returned value. It will be compiled but actual \_movementOrder variable will not be changed after the call. |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [GetFirstUnit](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a3e739dad4271411c3cbcbe8f6ea5b621) () |
| int | [GetCountOfUnitsBelongingToLogicalClass](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#aba22709061ccb242ff29e2cf1e5cecd7) ([FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) logicalClass) |
| int | [GetCountOfUnitsBelongingToPhysicalClass](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a5c4e0be9f8ad40310aa45447d173e678) ([FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) physicalClass, bool excludeBannerBearers) |
| void | [SetSpawnIndex](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a4bfe69434cd88d810b6ba73adca11680) (int value=0) |
| int | [GetNextSpawnIndex](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a09f016176366f0333b86283349229441) () |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [GetUnitWithIndex](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a72e1019ca77e6b1d89b8c79de8f8d763) (int unitIndex) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetAveragePositionOfUnits](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a4b55bf3e4bcf86017f2b57cccd5592e5) (bool excludeDetachedUnits, bool excludePlayer) |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [GetMedianAgent](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#af1ea80d6df4e927f2fcf69e791fb0c85) (bool excludeDetachedUnits, bool excludePlayer, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) averagePosition) |
| [Agent.UnderAttackType](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa6bf6f204fa49aaa08ddab2434120d27) | [GetUnderAttackTypeOfUnits](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a76d562949b2c1dc252076c4356769b67) (float timeLimit=3.0f) |
| [Agent.MovementBehaviorType](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aae8de26b7a3c90f2606b38ac9e062cac) | [GetMovementTypeOfUnits](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a82d73c1f50c325af61a669f0a603cf0a) () |
| IEnumerable< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | [GetUnitsWithoutDetachedOnes](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a2f67540e40440ad8ca05c3324a29d189) () |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetWallDirectionOfRelativeFormationLocation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a29b0782d875ec0a6fab08a65d4d214eb) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) unit) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetDirectionOfUnit](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a484400c63e3d8e82d786689990aa3a46) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) unit) |
| MovementStateEnum | [GetMovementState](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ad7bcded7ea5c37a7f35b7787368a6e35) () |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | [GetOrderPositionOfUnit](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#af0a2fdfeaf05b2a1b8aad2107f08c545) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) unit) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetCurrentGlobalPositionOfUnit](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#accabe7ca35db615da39a23078dba156d) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) unit, bool blendWithOrderDirection) |
| float | [GetAverageMaximumMovementSpeedOfUnits](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#af9dcb261c3fa604a31f47953b787ac12) () |
| float | [GetFormationPower](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ad41e1e195066c70bc40f2dc23a17ddba) () |
| float | [GetFormationMeleeFightingPower](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a675db1af40bcd7bc544a3a31f9a1e3cc) () |
| [IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html) | [GetDetachmentOrDefault](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a96432b851f9b9274cdc1c5ae18bfb99e) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| [WorldFrame](struct_tale_worlds_1_1_engine_1_1_world_frame.html)? | [GetDetachmentFrame](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ac8c10504707e2d7c70dc7661bf7d8cb9) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetMiddleFrontUnitPositionOffset](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a4c8d98d3dec80992f6fa712f87c8fffe) () |
| List< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) > | [GetUnitsToPopWithReferencePosition](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a19b1a9a12bf1af922fb3e6caf0194f03) (int count, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) targetPosition) |
| List< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) > | [GetUnitsToPop](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a6d8fc7429bcd7eeaa30d5a83da6d9e90) (int count) |
| IEnumerable< ValueTuple< [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html), [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > > | [GetUnavailableUnitPositionsAccordingToNewOrder](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a78e5ffdd14b2c9438cbd0e4ccbae73d1) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a652b19eb51d801d5676e612af2602458) simulationFormation, in [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) position, in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) direction, float width, int unitSpacing) |
| void | [GetUnitSpawnFrameWithIndex](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a7304827d530aaf8655132bae1aa396f8) (int unitIndex, in [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) formationPosition, in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) formationDirection, float width, int unitCount, int unitSpacing, bool isMountedFormation, out [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html)? unitSpawnPosition, out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? unitSpawnDirection) |
| void | [GetUnitPositionWithIndexAccordingToNewOrder](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a6106efbf193f2924a6cff2f87a8b7d0d) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a652b19eb51d801d5676e612af2602458) simulationFormation, int unitIndex, in [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) formationPosition, in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) formationDirection, float width, int unitSpacing, out [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html)? unitSpawnPosition, out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? unitSpawnDirection) |
| void | [GetUnitPositionWithIndexAccordingToNewOrder](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a9e137d540e3460924d9ec04efc85187a) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a652b19eb51d801d5676e612af2602458) simulationFormation, int unitIndex, in [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) formationPosition, in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) formationDirection, float width, int unitSpacing, int overridenUnitCount, out [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html)? unitPosition, out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? unitDirection) |
| void | [GetUnitPositionWithIndexAccordingToNewOrder](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a9e81f4356d37a01c5570c2eb72c9aad0) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a652b19eb51d801d5676e612af2602458) simulationFormation, int unitIndex, in [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) formationPosition, in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) formationDirection, float width, int unitSpacing, out [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html)? unitSpawnPosition, out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? unitSpawnDirection, out float actualWidth) |
| bool | [HasUnitsWithCondition](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ad25fe5febec61037ee8422e2ceed20a0) (Func< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), bool > function) |
| bool | [HasUnitsWithCondition](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ab93577ba29284c0c8c0713807952d12f) (Func< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), bool > function, out [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) result) |
| bool | [HasAnyEnemyFormationsThatIsNotEmpty](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a0c9bf9cadde396436d79d518a824510f) () |
| bool | [HasUnitWithConditionLimitedRandom](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a3a3f902ea84195219f425faab639d7d2) (Func< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), bool > function, int startingIndex, int willBeCheckedUnitCount, out [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) resultAgent) |
|  | Prioritizes attached agents. |
| int[] | [CollectUnitIndices](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ab2da5c3ab264a15c4bed8c5c58fcc668) () |
| void | [ApplyActionOnEachUnit](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a92f19ea9fadf302d0830991f3a0056c3) (Action< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > action, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) ignoreAgent=null) |
| void | [ApplyActionOnEachAttachedUnit](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ac84fee149a19faf5173d8d51f37c8681) (Action< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > action) |
| void | [ApplyActionOnEachDetachedUnit](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a83e44d7083aaaf29abe04929eddc56ea) (Action< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > action) |
| void | [ApplyActionOnEachUnitViaBackupList](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a953eb5103d3661da407f497668eb97c5) (Action< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > action) |
| void | [ApplyActionOnEachUnit](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#aef2fe66b77acbb2e81453f82605a75b4) (Action< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), List< [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) > > action, List< [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) > list) |
| int | [CountUnitsOnNavMeshIDMod10](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ab37053284f6b10f1969d5603948412e8) (int navMeshID, bool includeOnlyPositionedUnits) |
| void | [OnAgentControllerChanged](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#af6c41f82deaee931ef1d7b8bbaddab18) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [AgentControllerType](namespace_tale_worlds_1_1_core.html#a9023c2d9c44f6d3f5d63611a38b3bedb) oldController) |
| void | [OnMassUnitTransferStart](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a8002e7467eef00e7761ea31d11cc8ccb) () |
| void | [OnMassUnitTransferEnd](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a6dcbd8ead29007214c67ecec64f4205b) () |
| void | [OnBatchUnitRemovalStart](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a81990678fa124f6c96a03170dd8df884) () |
| void | [OnBatchUnitRemovalEnd](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a44be1a73d5bf9f1928a75d3e10e8ad57) () |
| void | [OnUnitAddedOrRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a4bb61b5e9b0b858c638efa8dbbae1e9e) () |
| void | [OnAgentLostMount](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ae4eb00ae319354c2bf21430f1b35c91d) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| void | [OnFormationDispersed](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a410c6cdd52f6b65e63aca64d09fd411e) () |
| void | [OnUnitDetachmentChanged](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a5ea0be21b1dc93df1df3dabf64e226a3) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) unit, bool isOldDetachmentLoose, bool isNewDetachmentLoose) |
| void | [OnUndetachableNonPlayerUnitAdded](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#aab8485ed28246802fa14802862920eab) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) unit) |
| void | [OnUndetachableNonPlayerUnitRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a61199c688d6d9157c9ddb5ff529aabf8) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) unit) |
| void | [ResetMovementOrderPositionCache](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ae15584b7b5e3d8775c9e497e3bdffdd9) () |
| void | [Reset](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ac7e157d316a363351cdd1a41b059b6fe) () |
| IEnumerable< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a652b19eb51d801d5676e612af2602458) > | [Split](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a91cec3666e4f5a01bd53c9629b4333b8) (int count=2) |
| void | [TransferUnits](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a25cf966a2a10d2d169fb25a8d3eb769c) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a652b19eb51d801d5676e612af2602458) target, int unitCount) |
| void | [TransferUnitsAux](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a9b8d1c6182e9f295d3d019c54c41ded1) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a652b19eb51d801d5676e612af2602458) target, int unitCount, bool isPlayerOrder, bool useSelectivePop) |
|  | DO NOT USE THIS METHOD. |
| void | [DebugArrangements](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a5605ccc61d8c8d7e48d1bb01d451b715) () |
| void | [AddUnit](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ac86d5d5c0dae76ea43f031af5b9e234c) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) unit) |
| void | [RemoveUnit](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#aceb0a292a2de36d65d2e6477f293b9d9) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) unit) |
| void | [DetachUnit](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a28b15fb0e0bce3473946f23d915dcc27) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) unit, bool isLoose) |
| void | [AttachUnit](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a398e1dbc9f0d4459a6d8af5db059f4ed) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) unit) |
| void | [SwitchUnitLocations](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a63a6bfa0c2c81d71477960f18749b302) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) firstUnit, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) secondUnit) |
| void | [ForceCalculateCaches](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a3beae4c51da3e666151315a15bc5a26c) () |
| void | [Tick](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ac1cdb1765b200b7fafcdb6e26e2ec548) (float dt) |
| void | [SetHasPendingUnitPositions](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a6997d831b52428a3c964b9d649d5b573) (bool hasPendingUnitPositions) |
| void | [JoinDetachment](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#adb7d25f916c037d1be9a1b7f560eda66) ([IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html) detachment) |
| void | [FormAttackEntityDetachment](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a6cc6a3dc26a1d8b3268e55e4fceacb90) ([GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) targetEntity) |
| void | [LeaveDetachment](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#aaa1fe0a66a40f41e8011db9a7f214fcb) ([IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html) detachment) |
| void | [DisbandAttackEntityDetachment](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a3ce7f476b0f54b2201ee5cfc46f2458e) () |
| void | [Rearrange](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#aad49c7c9d05dd9476564cc7176c5892e) ([IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html) arrangement) |
| void | [TickForColumnArrangementInitialPositioning](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a6125f62023f517bfc948378a1e8d946d) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a652b19eb51d801d5676e612af2602458) formation) |
| float | [CalculateFormationDirectionEnforcingFactorForRank](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a4ce2cbc4c41eed52b13c49303ccd3537) (int rankIndex) |
| void | [BeginSpawn](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a7516737ce0cf94c32334497b9612228b) (int unitCount, bool isMounted) |
| void | [EndSpawn](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a4e44bf7d2791668755f1ab7529420f11) () |
| override int | [GetHashCode](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a78684ad02ffc5e0a4e00fcdca98908c6) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static float | [GetLastSimulatedFormationsOccupationWidthIfLesserThanActualWidth](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a097f643ddfc2cc5c4aaa8cf7e4baa04b) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a652b19eb51d801d5676e612af2602458) simulationFormation) |
| static List< [WorldFrame](struct_tale_worlds_1_1_engine_1_1_world_frame.html) > | [GetFormationFramesForBeforeFormationCreation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#af751ea07a2ef530ab292ac5778518e85) (float width, int manCount, bool areMounted, [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) spawnOrigin, [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html) spawnRotation) |
| static float | [GetDefaultUnitDiameter](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a40cf4f9bdcf3945e755186507d3d2c29) (bool isMounted) |
| static float | [GetDefaultMinimumUnitInterval](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a638b5a7fda68450ffdb91d10a9d4e423) (bool isMounted) |
| static float | [GetDefaultUnitInterval](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a2a2a69f517be9a4841c297a1ed0ec6ea) (bool isMounted, int unitSpacing) |
| static float | [GetDefaultMinimumUnitDistance](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a8e837fe3e61dd1cfd2ef3cf5ab8a4530) (bool isMounted) |
| static float | [GetDefaultUnitDistance](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#afc15f565e66049eda3e4a8b192fc1ff2) (bool isMounted, int unitSpacing) |
| static float | [GetDefaultFileWidth](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a1ae1023536b2f17440eec92c035c745d) (int fileUnitCount, int unitSpacing, bool isMounted) |
| static float | [GetDefaultRankDepth](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ad625e2abbd3c5de1dff5ef632410106b) (int rankUnitCount, int unitSpacing, bool isMounted) |
| static float | [InfantryInterval](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#adbc8950cc33b29c2c5749e6db37aee8e) (int unitSpacing) |
| static float | [CavalryInterval](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a6115db6058d051167d918fa9d65a25e8) (int unitSpacing) |
| static float | [InfantryDistance](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#aff07731f4d580431cd19445f504ba562) (int unitSpacing) |
| static float | [CavalryDistance](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#af459c7aa190d38891c4fd2ebf2f21ae7) (int unitSpacing) |
| static bool | [IsDefenseRelatedAIDrivenComponent](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#af33b834ef6e6a204790ef94ae7adb034) ([DrivenProperty](namespace_tale_worlds_1_1_core.html#a5365354e6dce5280fbc150c13f9e60cf) drivenProperty) |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly Team | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a197f8d61e357068919155a35a51ce674) |
| readonly int | [Index](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ab3f7af64a361f52decb4d6a99799b200) |
| readonly [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | [FormationIndex](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a8bdf7e9f62e7560207e5fe2790d64f36) |
| Banner | [Banner](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#abbd9406f90e4d4a6a1f72157b56c4c26) |
| bool | [HasBeenPositioned](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ab79dbe103aff076250c46653c8192419) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? | [ReferencePosition](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a4089f43156ff7d9a04a941ae3a72c1c7) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const float | [AveragePositionCalculatePeriod](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#afc4e8e0870a277bbc325d0908897486e) = 0.1f |
| const int | [MinimumUnitSpacing](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a7df3398e58704ab2097faa67f61a43ee) = 0 |
| const int | [RetreatPositionDistanceCacheCount](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a7b6685673c4fb1203ca1c535e9c8c2b5) = 2 |
| const float | [RetreatPositionCacheUseDistanceSquared](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#afe614bce1c7c388f94440ba30b66ce78) = 400.0f |

|  |  |
| --- | --- |
| Properties | |
| [RetreatPositionCacheSystem](class_tale_worlds_1_1_mount_and_blade_1_1_formation_1_1_retreat_position_cache_system.html) | [RetreatPositionCache](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ae08982eef3c786ec1927aec30540cbd8) = new [RetreatPositionCacheSystem](class_tale_worlds_1_1_mount_and_blade_1_1_formation_1_1_retreat_position_cache_system.html)([RetreatPositionDistanceCacheCount](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a7b6685673c4fb1203ca1c535e9c8c2b5)) `[get]` |
| [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | [RepresentativeClass](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a8ec0995a951fb84f1d84fc95969716cd) = FormationClass.Unset `[get]` |
|  | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html)'s current representative class. Representative class is the same as the logical class except for the following occasion: Unlike logical class, if all units of a formation die or flee representative class will retain its previous value. As an example an infantry formation losing its last infantry unit will still representatively remain as an infantry formation, but its logical class will switch to unset. This is preferable for deciding the formations within which reinforcements will spawn The only exception to this is troop transfers. if the player or [AI](namespace_tale_worlds_1_1_mount_and_blade_1_1_a_i.html) transfers all troops of a formation to another formation, both the logical class and the representative class will be set to unset (i.e. undecided class). |
| bool | [IsAIControlled](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a3dc35375e1ded0cd7199742ba1a98074) = true `[get]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [Direction](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#aabff2be0dc1fd46af2a7a012a333fb4f) `[get]` |
| int | [UnitSpacing](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#abe56764c3ce85ee65d4ab003a24bd18a) `[get]` |
| object | [OrderPositionLock](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ae24350e48f91e8181c6ecfe06e649aac) = new object() `[get]` |
| int | [CountOfUnits](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ac5491e82bad4b0a50bdd0e39d3eb6375) `[get]` |
| int | [CountOfDetachedUnits](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a6c129a8bd0c69ac7f48aa648a297f14d) `[get]` |
| int | [CountOfUndetachableNonPlayerUnits](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a8d0606a08ab603f9b7d143aca6c52972) `[get]` |
| int | [CountOfUnitsWithoutDetachedOnes](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a5044e8f7044ba47bc3a1d6eecd90cbc6) `[get]` |
| MBReadOnlyList< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) > | [UnitsWithoutLooseDetachedOnes](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a6b3b660c61daa734881f2d589ebe6978) `[get]` |
| int | [CountOfUnitsWithoutLooseDetachedOnes](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a4a568c77018a0064376f659d35e8cd39) `[get]` |
| int | [CountOfDetachableNonPlayerUnits](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a4fcc9cd6c38ce1f36128330ef5a4575e) `[get]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [OrderPosition](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a0884caa721b2048f16eeda7c7b8fa523) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [OrderGroundPosition](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a926ba38c5c3c8e92dde949c3e4f65b51) `[get]` |
| bool | [OrderPositionIsValid](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a21a8439594eb5b2d5c075dd02c9cc90b) `[get]` |
| float | [Depth](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a6d5bfb0196cdab3d0ce8849d551db188) `[get]` |
| float | [MinimumWidth](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a520091fbc62716f12286d44ba0c20dc5) `[get]` |
| float | [MaximumWidth](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a421b402b300ca57ce1fd6ccfcb9fd402) `[get]` |
| float | [UnitDiameter](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a883436020c9ffb9e409373a354c297ee) `[get]` |
|  | Size of a single unit. |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [CurrentDirection](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#af4b2cb5d63ac7aa5b893fb30f757a95b) `[get]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [SmoothedAverageUnitPosition](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a0d5d97d308a51cff5ff4e082486c39a0) `[get]` |
| MBReadOnlyList< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | [LooseDetachedUnits](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#aacfe6a6fa3d8571d03ccffc9df6027e6) `[get]` |
| MBReadOnlyList< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | [DetachedUnits](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ab077ece63815ee8be770f659cf7cfd3d) `[get]` |
| AttackEntityOrderSecondaryDetachment | [AttackEntityOrderSecondaryDetachment](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a8124b39115704467d843b0622ae9dfdc) `[get]` |
| [FormationAI](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html) | [AI](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a12fcd017024e3c9da75cb909ddffcf1a) `[get]` |
| [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a652b19eb51d801d5676e612af2602458) | [TargetFormation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#aed23e394e9390125ff0c8e4e22b55648) `[get]` |
| [FormationQuerySystem](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html) | [QuerySystem](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a1e293841443ec8305931cf46444f6401) `[get]` |
| [FormationIntegrityDataGroup](struct_tale_worlds_1_1_mount_and_blade_1_1_formation_1_1_formation_integrity_data_group.html) | [CachedFormationIntegrityData](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ad45ab8787e8e1523f49e2adac0e45d7e) `[get]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [CachedAveragePosition](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#abb3bc3cb8b61eaa1342db5754a0d46ff) `[get]` |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | [CachedMedianPosition](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a9ccb89517ff88a8ab54471753b32b999) `[get]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [CachedCurrentVelocity](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a4c7642d2f6fac20f138687954b9a5848) `[get]` |
| float | [CachedMovementSpeed](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#adfc6751664da27ed475a3f8e90d06f3d) = 1.0f `[get]` |
| float | [CachedClosestEnemyFormationDistanceSquared](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a9e2156d42d4b948cefa18fa7ed9cde2e) `[get]` |
| [FormationQuerySystem](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html) | [CachedClosestEnemyFormation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#aadfe84574f78f90566b20c1da4626361) `[get]` |
| MBReadOnlyList< [IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html) > | [Detachments](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a6415e1ccc7a93e21335af93a038315be) `[get]` |
| int? | [OverridenUnitCount](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a6bb3901a85a3cb45b5efcdada013191e) `[get]` |
|  | Should only used by dummy formations or when the formation is spawning for the first time. |
| bool | [IsSpawning](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a5ca15d475b176e87eef06be9f3cb31bc) `[get]` |
| bool | [IsAITickedAfterSplit](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a2a3db20dcafd7cf57b78fc0c50bda224) `[get, set]` |
| bool | [HasPlayerControlledTroop](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#af9e1089edeffc366aff2a849c7a48a02) `[get]` |
| bool | [IsPlayerTroopInFormation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a086c70808b4dcd346da85af4f579152e) `[get]` |
| bool | [ContainsAgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a32a9cdf6dd0bcc13cf2d64c64a19b8cd) `[get, set]` |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [PlayerOwner](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a7ebf20ccb5bd64ac0e6f53023fb96b14) `[get, set]` |
| string | [BannerCode](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a27564046d9b8e86f74e5151c730ee1e9) `[get, set]` |
| bool | [IsSplittableByAI](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#af34585205f5d289af7ff39eaf849fede) `[get]` |
| bool | [IsAIOwned](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ab461d4c0c5b9e327347e02e8cc3bed7a) `[get]` |
| bool | [IsConvenientForTransfer](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a37f9bd9ef0ce9894f5384d31f8738861) `[get]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [OrderLocalAveragePosition](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#af10345a5b4573d23a5d65e788a2e1661) `[get]` |
| FacingOrder | [FacingOrder](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a00fd2370583b7af1b6004788e9cb7075) `[get]` |
| ArrangementOrder | [ArrangementOrder](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#afb7942c27906e9c5cc0b0be788680277) `[get]` |
| FormOrder | [FormOrder](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a56666478bfe043dfc00675eecfb65c34) `[get]` |
| RidingOrder | [RidingOrder](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a995f2bb7f801ea3af2153842c38a84da) `[get]` |
| FiringOrder | [FiringOrder](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a006674b13a96fe8900cd6b7aa57e51db) `[get]` |
| bool | [HasAnyMountedUnit](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ac488dc89465a4c642b35bde5d81f4f2b) `[get]` |
| float | [Width](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ac05047081f6e297d32e223bb3b232eda) `[get]` |
| bool | [IsDeployment](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a5a6733499cb9f4c7bf6388a625b4e967) `[get]` |
| [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | [LogicalClass](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a6d1909d5a9352d6c9b2d97699bd9fa09) `[get]` |
|  | Represents the logical troop class that is dominant within this formation Can only be a default class (infantry, ranged, cavalry or horse archer) Logical class of a troop is decided at spawn time and it does not change during the mission For example a troop spawned as horse cavalry will always logically remain as horse cavalry for the entire mission. But if its mount is killed, its physical troop class will become infantry. |
| IEnumerable< [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) > | [SecondaryLogicalClasses](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ae9abbc70133d8543fbd82e573ade88f9) `[get]` |
|  | Returns a list of non-dominant secondary logical troop classes contained by this formation. The list will be sorted in descending order w.r.t. secondary troop class counts. |
| [IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html) | [Arrangement](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a934ae7acd73dfdc3f6f0b00473bab6cb) `[get, set]` |
| [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | [PhysicalClass](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#afbb48fd4050abf08f6d526753bcea035) `[get]` |
|  | Represents the physical troop class that is dominant within this formation Can only be a default class (infantry, ranged, cavalry or horse archer) Unlike a troop's logical class, physical class of a troop might change during the mission. For example a cavalry unit that had lost its mount becomes an infantry in terms of physical troop class. But its logical class stays the same (as cavalry). |
| IEnumerable< [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) > | [SecondaryPhysicalClasses](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ac95f2c0966e1a8350a710fdc058acffb) `[get]` |
|  | Returns a list of available (but not dominant) physical troop classes in the formation. Use PhysicalClass to retrieve the dominant class. |
| float | [Interval](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a1d5338088d09866e5de87bbadc0c3a9e) `[get]` |
|  | The lateral space between units on one same line. |
| bool | [CalculateHasSignificantNumberOfMounted](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a0a9a07ab7107cb1ec9a52ed128f94118) `[get]` |
| float | [Distance](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#adae80886ca11f989758b8ea6651c6d44) `[get]` |
|  | Space between units in the direction of depth. |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [CurrentPosition](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a483b27ec05e79b602c45b4c317b548cc) `[get]` |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [Captain](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ad3e2c8e7a1995cd78de4772581e306de) `[get, set]` |
| float | [MinimumDistance](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ab4d2d970278d71f1f8e28dde5a2f4215) `[get]` |
| bool | [IsLoose](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a3243c97dff14c84067e2befb7f73c009) `[get]` |
| float | [MinimumInterval](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ac3995945c60b4b170a9432b35d7b5c1d) `[get]` |
| float | [MaximumInterval](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ad566074c163536c2ee63cd83ac052077) `[get]` |
| float | [MaximumDistance](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ad316f295a867b05295d9a061c0b9645c) `[get]` |

|  |  |
| --- | --- |
| Events | |
| Action< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a652b19eb51d801d5676e612af2602458), [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | [OnUnitAdded](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#aaa01ab64ed6c7d16d89c657ef5eae138) |
| Action< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a652b19eb51d801d5676e612af2602458), [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | [OnUnitRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a246e08d73880c61d277aebebd25a099a) |
| Action< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a652b19eb51d801d5676e612af2602458), [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | [OnUnitAttached](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a29d7cf8a2621284776d9f92188068d9c) |
| Action< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a652b19eb51d801d5676e612af2602458) > | [OnUnitCountChanged](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a2450dcf8829a4cc4eba8410899dd820b) |
| Action< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a652b19eb51d801d5676e612af2602458) > | [OnUnitSpacingChanged](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#aa28160d545a53c9adb5be18735a88c92) |
| Action< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a652b19eb51d801d5676e612af2602458) > | [OnTick](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#abe3d580892a4d79b5d7b4b0dda7ecf95) |
| Action< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a652b19eb51d801d5676e612af2602458) > | [OnWidthChanged](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a56f91d6c98eddcae46ed1310a7f9ed45) |
| Action< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a652b19eb51d801d5676e612af2602458), [MovementOrder.MovementOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a76e586c5e2ab511f2c81b00ad8059d95) > | [OnBeforeMovementOrderApplied](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ac4eba257f48298dbf75a8ee891e9d053) |
| Action< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a652b19eb51d801d5676e612af2602458), [ArrangementOrder.ArrangementOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280) > | [OnAfterArrangementOrderApplied](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a10577aa23a6e269d22bc9f694ece8186) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a652b19eb51d801d5676e612af2602458)Formation()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.Formation.Formation | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a197f8d61e357068919155a35a51ce674) | *team*, |
|  |  | int | *index* ) |

Parameters
:   |  |  |
    | --- | --- |
    | team |  |
    | index |  |
    | isVisualOnly | Is only used by UI, no effect on game logic |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a12f3f4b081308833c5433aacf3aa9ca1)CreateNewOrderWorldPosition()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) TaleWorlds.MountAndBlade.Formation.CreateNewOrderWorldPosition | ( | [WorldPosition.WorldPositionEnforcedCache](struct_tale_worlds_1_1_engine_1_1_world_position.html#a329057f863819c6dea70ecaf11784df9) | *worldPositionEnforcedCache* | ) |  |

Returns

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#adb38f7dd5b33999d6469c921dff9cba4)SetMovementOrder()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.SetMovementOrder | ( | [MovementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html) | *input* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a19fd9e7cd2ae2ed9d4476379e6c8dd29)SetFacingOrder()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.SetFacingOrder | ( | [FacingOrder](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a00fd2370583b7af1b6004788e9cb7075) | *order* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a5fec10f739ab2334c194d2dad0c277b3)SetArrangementOrder()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.SetArrangementOrder | ( | [ArrangementOrder](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#afb7942c27906e9c5cc0b0be788680277) | *order* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a574df0890b9297cf6ff840c817ca3841)SetFormOrder()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.SetFormOrder | ( | [FormOrder](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a56666478bfe043dfc00675eecfb65c34) | *order*, |
|  |  | bool | *updateDesiredFileCount* = true ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a0b9619775629768372043eccc3ed1064)SetRidingOrder()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.SetRidingOrder | ( | [RidingOrder](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a995f2bb7f801ea3af2153842c38a84da) | *order* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a5e3f76ab4c691c8a257b74d7cabab6e9)SetFiringOrder()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.SetFiringOrder | ( | [FiringOrder](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a006674b13a96fe8900cd6b7aa57e51db) | *order* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a2832fc6e97c874ffae9a972e64df5e6d)SetControlledByAI()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.SetControlledByAI | ( | bool | *isControlledByAI*, |
|  |  | bool | *enforceNotSplittableByAI* = false ) |

Parameters
:   |  |  |
    | --- | --- |
    | isControlledByAI | Determines if the formation will be controlled by the ai |
    | enforceNotSplittableByAI | If set ai cannot split this formation (i.e. transfer troops from this formation to others) when deciding tactics |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a2e82f0cf5523349c766eeda8b2024bf8)SetTargetFormation()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.SetTargetFormation | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a652b19eb51d801d5676e612af2602458) | *targetFormation* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a3104510e17b227481d72a34f7a0a5b6b)OnDeploymentFinished()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.OnDeploymentFinished | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a10d33712241941665f98a228fc4c3ad2)ResetArrangementOrderTickTimer()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.ResetArrangementOrderTickTimer | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a073b4cf50f2c347d5aabed04729efd81)SetPositioning()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.SetPositioning | ( | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html)? | *position* = null, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? | *direction* = null, |
|  |  | int? | *unitSpacing* = null ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ae8aeb1da36038f7a8b9d2fb95e163bff)GetCountOfUnitsWithCondition()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.Formation.GetCountOfUnitsWithCondition | ( | Func< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), bool > | *function* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#aeb958312049a7544d0db8d12e41b9800)GetReadonlyMovementOrderReference()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| ref readonly [MovementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html) TaleWorlds.MountAndBlade.Formation.GetReadonlyMovementOrderReference | ( |  | ) |  |

Returns

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a3e739dad4271411c3cbcbe8f6ea5b621)GetFirstUnit()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) TaleWorlds.MountAndBlade.Formation.GetFirstUnit | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#aba22709061ccb242ff29e2cf1e5cecd7)GetCountOfUnitsBelongingToLogicalClass()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.Formation.GetCountOfUnitsBelongingToLogicalClass | ( | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | *logicalClass* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a5c4e0be9f8ad40310aa45447d173e678)GetCountOfUnitsBelongingToPhysicalClass()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.Formation.GetCountOfUnitsBelongingToPhysicalClass | ( | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | *physicalClass*, |
|  |  | bool | *excludeBannerBearers* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a4bfe69434cd88d810b6ba73adca11680)SetSpawnIndex()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.SetSpawnIndex | ( | int | *value* = 0 | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a09f016176366f0333b86283349229441)GetNextSpawnIndex()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.Formation.GetNextSpawnIndex | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a72e1019ca77e6b1d89b8c79de8f8d763)GetUnitWithIndex()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) TaleWorlds.MountAndBlade.Formation.GetUnitWithIndex | ( | int | *unitIndex* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a4b55bf3e4bcf86017f2b57cccd5592e5)GetAveragePositionOfUnits()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.Formation.GetAveragePositionOfUnits | ( | bool | *excludeDetachedUnits*, |
|  |  | bool | *excludePlayer* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#af1ea80d6df4e927f2fcf69e791fb0c85)GetMedianAgent()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) TaleWorlds.MountAndBlade.Formation.GetMedianAgent | ( | bool | *excludeDetachedUnits*, |
|  |  | bool | *excludePlayer*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *averagePosition* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a76d562949b2c1dc252076c4356769b67)GetUnderAttackTypeOfUnits()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Agent.UnderAttackType](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa6bf6f204fa49aaa08ddab2434120d27) TaleWorlds.MountAndBlade.Formation.GetUnderAttackTypeOfUnits | ( | float | *timeLimit* = 3::0f | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a82d73c1f50c325af61a669f0a603cf0a)GetMovementTypeOfUnits()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Agent.MovementBehaviorType](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aae8de26b7a3c90f2606b38ac9e062cac) TaleWorlds.MountAndBlade.Formation.GetMovementTypeOfUnits | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a2f67540e40440ad8ca05c3324a29d189)GetUnitsWithoutDetachedOnes()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > TaleWorlds.MountAndBlade.Formation.GetUnitsWithoutDetachedOnes | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a29b0782d875ec0a6fab08a65d4d214eb)GetWallDirectionOfRelativeFormationLocation()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.Formation.GetWallDirectionOfRelativeFormationLocation | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *unit* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a484400c63e3d8e82d786689990aa3a46)GetDirectionOfUnit()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.Formation.GetDirectionOfUnit | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *unit* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ad7bcded7ea5c37a7f35b7787368a6e35)GetMovementState()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| MovementStateEnum TaleWorlds.MountAndBlade.Formation.GetMovementState | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#af0a2fdfeaf05b2a1b8aad2107f08c545)GetOrderPositionOfUnit()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) TaleWorlds.MountAndBlade.Formation.GetOrderPositionOfUnit | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *unit* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#accabe7ca35db615da39a23078dba156d)GetCurrentGlobalPositionOfUnit()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.Formation.GetCurrentGlobalPositionOfUnit | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *unit*, |
|  |  | bool | *blendWithOrderDirection* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#af9dcb261c3fa604a31f47953b787ac12)GetAverageMaximumMovementSpeedOfUnits()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Formation.GetAverageMaximumMovementSpeedOfUnits | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ad41e1e195066c70bc40f2dc23a17ddba)GetFormationPower()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Formation.GetFormationPower | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a675db1af40bcd7bc544a3a31f9a1e3cc)GetFormationMeleeFightingPower()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Formation.GetFormationMeleeFightingPower | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a96432b851f9b9274cdc1c5ae18bfb99e)GetDetachmentOrDefault()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html) TaleWorlds.MountAndBlade.Formation.GetDetachmentOrDefault | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ac8c10504707e2d7c70dc7661bf7d8cb9)GetDetachmentFrame()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [WorldFrame](struct_tale_worlds_1_1_engine_1_1_world_frame.html)? TaleWorlds.MountAndBlade.Formation.GetDetachmentFrame | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a4c8d98d3dec80992f6fa712f87c8fffe)GetMiddleFrontUnitPositionOffset()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.Formation.GetMiddleFrontUnitPositionOffset | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a19b1a9a12bf1af922fb3e6caf0194f03)GetUnitsToPopWithReferencePosition()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| List< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) > TaleWorlds.MountAndBlade.Formation.GetUnitsToPopWithReferencePosition | ( | int | *count*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *targetPosition* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a6d8fc7429bcd7eeaa30d5a83da6d9e90)GetUnitsToPop()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| List< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) > TaleWorlds.MountAndBlade.Formation.GetUnitsToPop | ( | int | *count* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a78e5ffdd14b2c9438cbd0e4ccbae73d1)GetUnavailableUnitPositionsAccordingToNewOrder()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| IEnumerable< ValueTuple< [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html), [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > > TaleWorlds.MountAndBlade.Formation.GetUnavailableUnitPositionsAccordingToNewOrder | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a652b19eb51d801d5676e612af2602458) | *simulationFormation*, |
|  |  | in [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *position*, |
|  |  | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *direction*, |
|  |  | float | *width*, |
|  |  | int | *unitSpacing* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a7304827d530aaf8655132bae1aa396f8)GetUnitSpawnFrameWithIndex()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.GetUnitSpawnFrameWithIndex | ( | int | *unitIndex*, |
|  |  | in [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *formationPosition*, |
|  |  | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *formationDirection*, |
|  |  | float | *width*, |
|  |  | int | *unitCount*, |
|  |  | int | *unitSpacing*, |
|  |  | bool | *isMountedFormation*, |
|  |  | out [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html)? | *unitSpawnPosition*, |
|  |  | out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? | *unitSpawnDirection* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a6106efbf193f2924a6cff2f87a8b7d0d)GetUnitPositionWithIndexAccordingToNewOrder() [1/3]
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.GetUnitPositionWithIndexAccordingToNewOrder | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a652b19eb51d801d5676e612af2602458) | *simulationFormation*, |
|  |  | int | *unitIndex*, |
|  |  | in [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *formationPosition*, |
|  |  | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *formationDirection*, |
|  |  | float | *width*, |
|  |  | int | *unitSpacing*, |
|  |  | out [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html)? | *unitSpawnPosition*, |
|  |  | out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? | *unitSpawnDirection* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a9e137d540e3460924d9ec04efc85187a)GetUnitPositionWithIndexAccordingToNewOrder() [2/3]
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.GetUnitPositionWithIndexAccordingToNewOrder | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a652b19eb51d801d5676e612af2602458) | *simulationFormation*, |
|  |  | int | *unitIndex*, |
|  |  | in [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *formationPosition*, |
|  |  | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *formationDirection*, |
|  |  | float | *width*, |
|  |  | int | *unitSpacing*, |
|  |  | int | *overridenUnitCount*, |
|  |  | out [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html)? | *unitPosition*, |
|  |  | out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? | *unitDirection* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a9e81f4356d37a01c5570c2eb72c9aad0)GetUnitPositionWithIndexAccordingToNewOrder() [3/3]
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.GetUnitPositionWithIndexAccordingToNewOrder | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a652b19eb51d801d5676e612af2602458) | *simulationFormation*, |
|  |  | int | *unitIndex*, |
|  |  | in [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *formationPosition*, |
|  |  | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *formationDirection*, |
|  |  | float | *width*, |
|  |  | int | *unitSpacing*, |
|  |  | out [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html)? | *unitSpawnPosition*, |
|  |  | out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? | *unitSpawnDirection*, |
|  |  | out float | *actualWidth* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ad25fe5febec61037ee8422e2ceed20a0)HasUnitsWithCondition() [1/2]
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Formation.HasUnitsWithCondition | ( | Func< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), bool > | *function* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ab93577ba29284c0c8c0713807952d12f)HasUnitsWithCondition() [2/2]
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Formation.HasUnitsWithCondition | ( | Func< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), bool > | *function*, |
|  |  | out [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *result* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a0c9bf9cadde396436d79d518a824510f)HasAnyEnemyFormationsThatIsNotEmpty()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Formation.HasAnyEnemyFormationsThatIsNotEmpty | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a3a3f902ea84195219f425faab639d7d2)HasUnitWithConditionLimitedRandom()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Formation.HasUnitWithConditionLimitedRandom | ( | Func< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), bool > | *function*, |
|  |  | int | *startingIndex*, |
|  |  | int | *willBeCheckedUnitCount*, |
|  |  | out [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *resultAgent* ) |

Parameters
:   |  |  |
    | --- | --- |
    | function |  |
    | willBeCheckedUnitCount |  |

Returns

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ab2da5c3ab264a15c4bed8c5c58fcc668)CollectUnitIndices()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int[] TaleWorlds.MountAndBlade.Formation.CollectUnitIndices | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a92f19ea9fadf302d0830991f3a0056c3)ApplyActionOnEachUnit() [1/2]
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.ApplyActionOnEachUnit | ( | Action< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | *action*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *ignoreAgent* = null ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ac84fee149a19faf5173d8d51f37c8681)ApplyActionOnEachAttachedUnit()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.ApplyActionOnEachAttachedUnit | ( | Action< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | *action* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a83e44d7083aaaf29abe04929eddc56ea)ApplyActionOnEachDetachedUnit()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.ApplyActionOnEachDetachedUnit | ( | Action< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | *action* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a953eb5103d3661da407f497668eb97c5)ApplyActionOnEachUnitViaBackupList()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.ApplyActionOnEachUnitViaBackupList | ( | Action< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | *action* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#aef2fe66b77acbb2e81453f82605a75b4)ApplyActionOnEachUnit() [2/2]
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.ApplyActionOnEachUnit | ( | Action< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), List< [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) > > | *action*, |
|  |  | List< [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) > | *list* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ab37053284f6b10f1969d5603948412e8)CountUnitsOnNavMeshIDMod10()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.Formation.CountUnitsOnNavMeshIDMod10 | ( | int | *navMeshID*, |
|  |  | bool | *includeOnlyPositionedUnits* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#af6c41f82deaee931ef1d7b8bbaddab18)OnAgentControllerChanged()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.OnAgentControllerChanged | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | [AgentControllerType](namespace_tale_worlds_1_1_core.html#a9023c2d9c44f6d3f5d63611a38b3bedb) | *oldController* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a8002e7467eef00e7761ea31d11cc8ccb)OnMassUnitTransferStart()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.OnMassUnitTransferStart | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a6dcbd8ead29007214c67ecec64f4205b)OnMassUnitTransferEnd()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.OnMassUnitTransferEnd | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a81990678fa124f6c96a03170dd8df884)OnBatchUnitRemovalStart()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.OnBatchUnitRemovalStart | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a44be1a73d5bf9f1928a75d3e10e8ad57)OnBatchUnitRemovalEnd()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.OnBatchUnitRemovalEnd | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a4bb61b5e9b0b858c638efa8dbbae1e9e)OnUnitAddedOrRemoved()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.OnUnitAddedOrRemoved | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IFormation](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html#a2bf4dcc8786b0d2b393602be998675f5).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ae4eb00ae319354c2bf21430f1b35c91d)OnAgentLostMount()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.OnAgentLostMount | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a410c6cdd52f6b65e63aca64d09fd411e)OnFormationDispersed()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.OnFormationDispersed | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a5ea0be21b1dc93df1df3dabf64e226a3)OnUnitDetachmentChanged()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.OnUnitDetachmentChanged | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *unit*, |
|  |  | bool | *isOldDetachmentLoose*, |
|  |  | bool | *isNewDetachmentLoose* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#aab8485ed28246802fa14802862920eab)OnUndetachableNonPlayerUnitAdded()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.OnUndetachableNonPlayerUnitAdded | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *unit* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a61199c688d6d9157c9ddb5ff529aabf8)OnUndetachableNonPlayerUnitRemoved()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.OnUndetachableNonPlayerUnitRemoved | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *unit* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ae15584b7b5e3d8775c9e497e3bdffdd9)ResetMovementOrderPositionCache()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.ResetMovementOrderPositionCache | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ac7e157d316a363351cdd1a41b059b6fe)Reset()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.Reset | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a91cec3666e4f5a01bd53c9629b4333b8)Split()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| IEnumerable< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a652b19eb51d801d5676e612af2602458) > TaleWorlds.MountAndBlade.Formation.Split | ( | int | *count* = 2 | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a25cf966a2a10d2d169fb25a8d3eb769c)TransferUnits()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.TransferUnits | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a652b19eb51d801d5676e612af2602458) | *target*, |
|  |  | int | *unitCount* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a9b8d1c6182e9f295d3d019c54c41ded1)TransferUnitsAux()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.TransferUnitsAux | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a652b19eb51d801d5676e612af2602458) | *target*, |
|  |  | int | *unitCount*, |
|  |  | bool | *isPlayerOrder*, |
|  |  | bool | *useSelectivePop* ) |

Parameters
:   |  |  |
    | --- | --- |
    | target |  |
    | unitCount |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a5605ccc61d8c8d7e48d1bb01d451b715)DebugArrangements()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.DebugArrangements | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ac86d5d5c0dae76ea43f031af5b9e234c)AddUnit()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.AddUnit | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *unit* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#aceb0a292a2de36d65d2e6477f293b9d9)RemoveUnit()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.RemoveUnit | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *unit* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a28b15fb0e0bce3473946f23d915dcc27)DetachUnit()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.DetachUnit | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *unit*, |
|  |  | bool | *isLoose* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a398e1dbc9f0d4459a6d8af5db059f4ed)AttachUnit()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.AttachUnit | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *unit* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a63a6bfa0c2c81d71477960f18749b302)SwitchUnitLocations()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.SwitchUnitLocations | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *firstUnit*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *secondUnit* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a3beae4c51da3e666151315a15bc5a26c)ForceCalculateCaches()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.ForceCalculateCaches | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ac1cdb1765b200b7fafcdb6e26e2ec548)Tick()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.Tick | ( | float | *dt* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a6997d831b52428a3c964b9d649d5b573)SetHasPendingUnitPositions()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.SetHasPendingUnitPositions | ( | bool | *hasPendingUnitPositions* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#adb7d25f916c037d1be9a1b7f560eda66)JoinDetachment()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.JoinDetachment | ( | [IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html) | *detachment* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a6cc6a3dc26a1d8b3268e55e4fceacb90)FormAttackEntityDetachment()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.FormAttackEntityDetachment | ( | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *targetEntity* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#aaa1fe0a66a40f41e8011db9a7f214fcb)LeaveDetachment()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.LeaveDetachment | ( | [IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html) | *detachment* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a3ce7f476b0f54b2201ee5cfc46f2458e)DisbandAttackEntityDetachment()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.DisbandAttackEntityDetachment | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#aad49c7c9d05dd9476564cc7176c5892e)Rearrange()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.Rearrange | ( | [IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html) | *arrangement* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a6125f62023f517bfc948378a1e8d946d)TickForColumnArrangementInitialPositioning()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.TickForColumnArrangementInitialPositioning | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a652b19eb51d801d5676e612af2602458) | *formation* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a4ce2cbc4c41eed52b13c49303ccd3537)CalculateFormationDirectionEnforcingFactorForRank()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Formation.CalculateFormationDirectionEnforcingFactorForRank | ( | int | *rankIndex* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a7516737ce0cf94c32334497b9612228b)BeginSpawn()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.BeginSpawn | ( | int | *unitCount*, |
|  |  | bool | *isMounted* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a4e44bf7d2791668755f1ab7529420f11)EndSpawn()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Formation.EndSpawn | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a78684ad02ffc5e0a4e00fcdca98908c6)GetHashCode()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.MountAndBlade.Formation.GetHashCode | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a097f643ddfc2cc5c4aaa8cf7e4baa04b)GetLastSimulatedFormationsOccupationWidthIfLesserThanActualWidth()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.Formation.GetLastSimulatedFormationsOccupationWidthIfLesserThanActualWidth | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a652b19eb51d801d5676e612af2602458) | *simulationFormation* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#af751ea07a2ef530ab292ac5778518e85)GetFormationFramesForBeforeFormationCreation()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | List< [WorldFrame](struct_tale_worlds_1_1_engine_1_1_world_frame.html) > TaleWorlds.MountAndBlade.Formation.GetFormationFramesForBeforeFormationCreation | ( | float | *width*, | |  |  | int | *manCount*, | |  |  | bool | *areMounted*, | |  |  | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *spawnOrigin*, | |  |  | [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html) | *spawnRotation* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a40cf4f9bdcf3945e755186507d3d2c29)GetDefaultUnitDiameter()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.Formation.GetDefaultUnitDiameter | ( | bool | *isMounted* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a638b5a7fda68450ffdb91d10a9d4e423)GetDefaultMinimumUnitInterval()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.Formation.GetDefaultMinimumUnitInterval | ( | bool | *isMounted* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a2a2a69f517be9a4841c297a1ed0ec6ea)GetDefaultUnitInterval()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.Formation.GetDefaultUnitInterval | ( | bool | *isMounted*, | |  |  | int | *unitSpacing* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a8e837fe3e61dd1cfd2ef3cf5ab8a4530)GetDefaultMinimumUnitDistance()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.Formation.GetDefaultMinimumUnitDistance | ( | bool | *isMounted* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#afc15f565e66049eda3e4a8b192fc1ff2)GetDefaultUnitDistance()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.Formation.GetDefaultUnitDistance | ( | bool | *isMounted*, | |  |  | int | *unitSpacing* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a1ae1023536b2f17440eec92c035c745d)GetDefaultFileWidth()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.Formation.GetDefaultFileWidth | ( | int | *fileUnitCount*, | |  |  | int | *unitSpacing*, | |  |  | bool | *isMounted* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ad625e2abbd3c5de1dff5ef632410106b)GetDefaultRankDepth()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.Formation.GetDefaultRankDepth | ( | int | *rankUnitCount*, | |  |  | int | *unitSpacing*, | |  |  | bool | *isMounted* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#adbc8950cc33b29c2c5749e6db37aee8e)InfantryInterval()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.Formation.InfantryInterval | ( | int | *unitSpacing* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a6115db6058d051167d918fa9d65a25e8)CavalryInterval()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.Formation.CavalryInterval | ( | int | *unitSpacing* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#aff07731f4d580431cd19445f504ba562)InfantryDistance()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.Formation.InfantryDistance | ( | int | *unitSpacing* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#af459c7aa190d38891c4fd2ebf2f21ae7)CavalryDistance()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.Formation.CavalryDistance | ( | int | *unitSpacing* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#af33b834ef6e6a204790ef94ae7adb034)IsDefenseRelatedAIDrivenComponent()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.Formation.IsDefenseRelatedAIDrivenComponent | ( | [DrivenProperty](namespace_tale_worlds_1_1_core.html#a5365354e6dce5280fbc150c13f9e60cf) | *drivenProperty* | ) |  | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#afc4e8e0870a277bbc325d0908897486e)AveragePositionCalculatePeriod
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.Formation.AveragePositionCalculatePeriod = 0.1f | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a7df3398e58704ab2097faa67f61a43ee)MinimumUnitSpacing
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.MountAndBlade.Formation.MinimumUnitSpacing = 0 | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a7b6685673c4fb1203ca1c535e9c8c2b5)RetreatPositionDistanceCacheCount
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.MountAndBlade.Formation.RetreatPositionDistanceCacheCount = 2 | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#afe614bce1c7c388f94440ba30b66ce78)RetreatPositionCacheUseDistanceSquared
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.Formation.RetreatPositionCacheUseDistanceSquared = 400.0f | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a197f8d61e357068919155a35a51ce674)Team
---------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly Team TaleWorlds.MountAndBlade.Formation.Team |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ab3f7af64a361f52decb4d6a99799b200)Index
----------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly int TaleWorlds.MountAndBlade.Formation.Index |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a8bdf7e9f62e7560207e5fe2790d64f36)FormationIndex
-------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) TaleWorlds.MountAndBlade.Formation.FormationIndex |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#abbd9406f90e4d4a6a1f72157b56c4c26)Banner
-----------------------------------------------------------------------------------------------------

|  |
| --- |
| Banner TaleWorlds.MountAndBlade.Formation.Banner |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ab79dbe103aff076250c46653c8192419)HasBeenPositioned
----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.Formation.HasBeenPositioned |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a4089f43156ff7d9a04a941ae3a72c1c7)ReferencePosition
----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? TaleWorlds.MountAndBlade.Formation.ReferencePosition |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ae08982eef3c786ec1927aec30540cbd8)RetreatPositionCache
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [RetreatPositionCacheSystem](class_tale_worlds_1_1_mount_and_blade_1_1_formation_1_1_retreat_position_cache_system.html) TaleWorlds.MountAndBlade.Formation.RetreatPositionCache = new [RetreatPositionCacheSystem](class_tale_worlds_1_1_mount_and_blade_1_1_formation_1_1_retreat_position_cache_system.html)([RetreatPositionDistanceCacheCount](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a7b6685673c4fb1203ca1c535e9c8c2b5)) | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a8ec0995a951fb84f1d84fc95969716cd)RepresentativeClass
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) TaleWorlds.MountAndBlade.Formation.RepresentativeClass = FormationClass.Unset | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a3dc35375e1ded0cd7199742ba1a98074)IsAIControlled
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Formation.IsAIControlled = true | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#aabff2be0dc1fd46af2a7a012a333fb4f)Direction
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.Formation.Direction | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#abe56764c3ce85ee65d4ab003a24bd18a)UnitSpacing
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.Formation.UnitSpacing | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ae24350e48f91e8181c6ecfe06e649aac)OrderPositionLock
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | object TaleWorlds.MountAndBlade.Formation.OrderPositionLock = new object() | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ac5491e82bad4b0a50bdd0e39d3eb6375)CountOfUnits
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.Formation.CountOfUnits | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a6c129a8bd0c69ac7f48aa648a297f14d)CountOfDetachedUnits
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.Formation.CountOfDetachedUnits | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a8d0606a08ab603f9b7d143aca6c52972)CountOfUndetachableNonPlayerUnits
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.Formation.CountOfUndetachableNonPlayerUnits | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a5044e8f7044ba47bc3a1d6eecd90cbc6)CountOfUnitsWithoutDetachedOnes
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.Formation.CountOfUnitsWithoutDetachedOnes | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a6b3b660c61daa734881f2d589ebe6978)UnitsWithoutLooseDetachedOnes
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html)> TaleWorlds.MountAndBlade.Formation.UnitsWithoutLooseDetachedOnes | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a4a568c77018a0064376f659d35e8cd39)CountOfUnitsWithoutLooseDetachedOnes
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.Formation.CountOfUnitsWithoutLooseDetachedOnes | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a4fcc9cd6c38ce1f36128330ef5a4575e)CountOfDetachableNonPlayerUnits
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.Formation.CountOfDetachableNonPlayerUnits | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a0884caa721b2048f16eeda7c7b8fa523)OrderPosition
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.Formation.OrderPosition | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a926ba38c5c3c8e92dde949c3e4f65b51)OrderGroundPosition
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.Formation.OrderGroundPosition | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a21a8439594eb5b2d5c075dd02c9cc90b)OrderPositionIsValid
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Formation.OrderPositionIsValid | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a6d5bfb0196cdab3d0ce8849d551db188)Depth
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Formation.Depth | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a520091fbc62716f12286d44ba0c20dc5)MinimumWidth
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Formation.MinimumWidth | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a421b402b300ca57ce1fd6ccfcb9fd402)MaximumWidth
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Formation.MaximumWidth | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a883436020c9ffb9e409373a354c297ee)UnitDiameter
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Formation.UnitDiameter | | get |

Implements [TaleWorlds.MountAndBlade.IFormation](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html#a6aea59f8c1ab59b1c318d900e889b752).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#af4b2cb5d63ac7aa5b893fb30f757a95b)CurrentDirection
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.Formation.CurrentDirection | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a0d5d97d308a51cff5ff4e082486c39a0)SmoothedAverageUnitPosition
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.Formation.SmoothedAverageUnitPosition | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#aacfe6a6fa3d8571d03ccffc9df6027e6)LooseDetachedUnits
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html)> TaleWorlds.MountAndBlade.Formation.LooseDetachedUnits | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ab077ece63815ee8be770f659cf7cfd3d)DetachedUnits
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html)> TaleWorlds.MountAndBlade.Formation.DetachedUnits | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a8124b39115704467d843b0622ae9dfdc)AttackEntityOrderSecondaryDetachment
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | AttackEntityOrderSecondaryDetachment TaleWorlds.MountAndBlade.Formation.AttackEntityOrderSecondaryDetachment | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a12fcd017024e3c9da75cb909ddffcf1a)AI
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [FormationAI](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html) TaleWorlds.MountAndBlade.Formation.AI | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#aed23e394e9390125ff0c8e4e22b55648)TargetFormation
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a652b19eb51d801d5676e612af2602458) TaleWorlds.MountAndBlade.Formation.TargetFormation | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a1e293841443ec8305931cf46444f6401)QuerySystem
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [FormationQuerySystem](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html) TaleWorlds.MountAndBlade.Formation.QuerySystem | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ad45ab8787e8e1523f49e2adac0e45d7e)CachedFormationIntegrityData
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [FormationIntegrityDataGroup](struct_tale_worlds_1_1_mount_and_blade_1_1_formation_1_1_formation_integrity_data_group.html) TaleWorlds.MountAndBlade.Formation.CachedFormationIntegrityData | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#abb3bc3cb8b61eaa1342db5754a0d46ff)CachedAveragePosition
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.Formation.CachedAveragePosition | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a9ccb89517ff88a8ab54471753b32b999)CachedMedianPosition
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) TaleWorlds.MountAndBlade.Formation.CachedMedianPosition | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a4c7642d2f6fac20f138687954b9a5848)CachedCurrentVelocity
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.Formation.CachedCurrentVelocity | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#adfc6751664da27ed475a3f8e90d06f3d)CachedMovementSpeed
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Formation.CachedMovementSpeed = 1.0f | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a9e2156d42d4b948cefa18fa7ed9cde2e)CachedClosestEnemyFormationDistanceSquared
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Formation.CachedClosestEnemyFormationDistanceSquared | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#aadfe84574f78f90566b20c1da4626361)CachedClosestEnemyFormation
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [FormationQuerySystem](class_tale_worlds_1_1_mount_and_blade_1_1_formation_query_system.html) TaleWorlds.MountAndBlade.Formation.CachedClosestEnemyFormation | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a6415e1ccc7a93e21335af93a038315be)Detachments
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html)> TaleWorlds.MountAndBlade.Formation.Detachments | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a6bb3901a85a3cb45b5efcdada013191e)OverridenUnitCount
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int? TaleWorlds.MountAndBlade.Formation.OverridenUnitCount | | get |

Implements [TaleWorlds.MountAndBlade.IFormation](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html#ae5ff51a1ccbcbe5e076371b5b3591dd5).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a5ca15d475b176e87eef06be9f3cb31bc)IsSpawning
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Formation.IsSpawning | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a2a3db20dcafd7cf57b78fc0c50bda224)IsAITickedAfterSplit
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Formation.IsAITickedAfterSplit | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#af9e1089edeffc366aff2a849c7a48a02)HasPlayerControlledTroop
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Formation.HasPlayerControlledTroop | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a086c70808b4dcd346da85af4f579152e)IsPlayerTroopInFormation
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Formation.IsPlayerTroopInFormation | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a32a9cdf6dd0bcc13cf2d64c64a19b8cd)ContainsAgentVisuals
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Formation.ContainsAgentVisuals | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a7ebf20ccb5bd64ac0e6f53023fb96b14)PlayerOwner
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) TaleWorlds.MountAndBlade.Formation.PlayerOwner | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a27564046d9b8e86f74e5151c730ee1e9)BannerCode
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.Formation.BannerCode | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#af34585205f5d289af7ff39eaf849fede)IsSplittableByAI
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Formation.IsSplittableByAI | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ab461d4c0c5b9e327347e02e8cc3bed7a)IsAIOwned
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Formation.IsAIOwned | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a37f9bd9ef0ce9894f5384d31f8738861)IsConvenientForTransfer
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Formation.IsConvenientForTransfer | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#af10345a5b4573d23a5d65e788a2e1661)OrderLocalAveragePosition
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.Formation.OrderLocalAveragePosition | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a00fd2370583b7af1b6004788e9cb7075)FacingOrder
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | FacingOrder TaleWorlds.MountAndBlade.Formation.FacingOrder | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#afb7942c27906e9c5cc0b0be788680277)ArrangementOrder
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ArrangementOrder TaleWorlds.MountAndBlade.Formation.ArrangementOrder | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a56666478bfe043dfc00675eecfb65c34)FormOrder
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | FormOrder TaleWorlds.MountAndBlade.Formation.FormOrder | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a995f2bb7f801ea3af2153842c38a84da)RidingOrder
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | RidingOrder TaleWorlds.MountAndBlade.Formation.RidingOrder | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a006674b13a96fe8900cd6b7aa57e51db)FiringOrder
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | FiringOrder TaleWorlds.MountAndBlade.Formation.FiringOrder | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ac488dc89465a4c642b35bde5d81f4f2b)HasAnyMountedUnit
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Formation.HasAnyMountedUnit | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ac05047081f6e297d32e223bb3b232eda)Width
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Formation.Width | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a5a6733499cb9f4c7bf6388a625b4e967)IsDeployment
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Formation.IsDeployment | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a6d1909d5a9352d6c9b2d97699bd9fa09)LogicalClass
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) TaleWorlds.MountAndBlade.Formation.LogicalClass | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ae9abbc70133d8543fbd82e573ade88f9)SecondaryLogicalClasses
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IEnumerable<[FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90)> TaleWorlds.MountAndBlade.Formation.SecondaryLogicalClasses | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a934ae7acd73dfdc3f6f0b00473bab6cb)Arrangement
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IFormationArrangement](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_arrangement.html) TaleWorlds.MountAndBlade.Formation.Arrangement | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#afbb48fd4050abf08f6d526753bcea035)PhysicalClass
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) TaleWorlds.MountAndBlade.Formation.PhysicalClass | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ac95f2c0966e1a8350a710fdc058acffb)SecondaryPhysicalClasses
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IEnumerable<[FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90)> TaleWorlds.MountAndBlade.Formation.SecondaryPhysicalClasses | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a1d5338088d09866e5de87bbadc0c3a9e)Interval
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Formation.Interval | | get |

Implements [TaleWorlds.MountAndBlade.IFormation](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html#a2b2b71d662717848550b32c0cf741a5c).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a0a9a07ab7107cb1ec9a52ed128f94118)CalculateHasSignificantNumberOfMounted
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Formation.CalculateHasSignificantNumberOfMounted | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#adae80886ca11f989758b8ea6651c6d44)Distance
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Formation.Distance | | get |

Implements [TaleWorlds.MountAndBlade.IFormation](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html#a0dfa3c2a029427e6e4f9a41c51f2b13b).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a483b27ec05e79b602c45b4c317b548cc)CurrentPosition
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.Formation.CurrentPosition | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ad3e2c8e7a1995cd78de4772581e306de)Captain
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) TaleWorlds.MountAndBlade.Formation.Captain | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ab4d2d970278d71f1f8e28dde5a2f4215)MinimumDistance
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Formation.MinimumDistance | | get |

Implements [TaleWorlds.MountAndBlade.IFormation](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html#a469607d9ffa21a4115ad3abad9e9d852).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a3243c97dff14c84067e2befb7f73c009)IsLoose
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Formation.IsLoose | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ac3995945c60b4b170a9432b35d7b5c1d)MinimumInterval
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Formation.MinimumInterval | | get |

Implements [TaleWorlds.MountAndBlade.IFormation](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html#a30d83f0b04fefbb407117325be800d74).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ad566074c163536c2ee63cd83ac052077)MaximumInterval
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Formation.MaximumInterval | | get |

Implements [TaleWorlds.MountAndBlade.IFormation](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html#a9c1f2688ca225b37f1697dfd8d466527).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ad316f295a867b05295d9a061c0b9645c)MaximumDistance
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Formation.MaximumDistance | | get |

Implements [TaleWorlds.MountAndBlade.IFormation](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html#ac7b1fc89b7160caed506b47ed0da20f8).

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#aaa01ab64ed6c7d16d89c657ef5eae138)OnUnitAdded
----------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a652b19eb51d801d5676e612af2602458),[Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html)> TaleWorlds.MountAndBlade.Formation.OnUnitAdded |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a246e08d73880c61d277aebebd25a099a)OnUnitRemoved
------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a652b19eb51d801d5676e612af2602458),[Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html)> TaleWorlds.MountAndBlade.Formation.OnUnitRemoved |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a29d7cf8a2621284776d9f92188068d9c)OnUnitAttached
-------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a652b19eb51d801d5676e612af2602458),[Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html)> TaleWorlds.MountAndBlade.Formation.OnUnitAttached |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a2450dcf8829a4cc4eba8410899dd820b)OnUnitCountChanged
-----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a652b19eb51d801d5676e612af2602458)> TaleWorlds.MountAndBlade.Formation.OnUnitCountChanged |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#aa28160d545a53c9adb5be18735a88c92)OnUnitSpacingChanged
-------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a652b19eb51d801d5676e612af2602458)> TaleWorlds.MountAndBlade.Formation.OnUnitSpacingChanged |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#abe3d580892a4d79b5d7b4b0dda7ecf95)OnTick
-----------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a652b19eb51d801d5676e612af2602458)> TaleWorlds.MountAndBlade.Formation.OnTick |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a56f91d6c98eddcae46ed1310a7f9ed45)OnWidthChanged
-------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a652b19eb51d801d5676e612af2602458)> TaleWorlds.MountAndBlade.Formation.OnWidthChanged |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ac4eba257f48298dbf75a8ee891e9d053)OnBeforeMovementOrderApplied
---------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a652b19eb51d801d5676e612af2602458), [MovementOrder.MovementOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a76e586c5e2ab511f2c81b00ad8059d95)> TaleWorlds.MountAndBlade.Formation.OnBeforeMovementOrderApplied |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a10577aa23a6e269d22bc9f694ece8186)OnAfterArrangementOrderApplied
-----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a652b19eb51d801d5676e612af2602458), [ArrangementOrder.ArrangementOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280)> TaleWorlds.MountAndBlade.Formation.OnAfterArrangementOrderApplied |

