--- SOURCE: struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html ---

TaleWorlds.Engine.WeakGameEntity Struct Reference|  |  |
| --- | --- |
| Public Member Functions | |
| void | [Invalidate](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#abc384e72ad9db6f2431646cacba1287b) () |
| UIntPtr | [GetScenePointer](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#af7bb74fa9fc7b4af1d7179bf10c005e2) () |
| override string | [ToString](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a3bc3af06281f292e15cb841d7bd09662) () |
| void | [ClearEntityComponents](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ae221fe6bdf1547235d5af989d141d7b5) (bool resetAll, bool removeScripts, bool deleteChildEntities) |
| void | [ClearComponents](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a9b42999413069700a025143ef13026af) () |
| void | [ClearOnlyOwnComponents](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aa83752279cc7a0c0657781590fac72d5) () |
| bool | [CheckResources](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a41fbc4fe1b662da8603c7d8c40569d05) (bool addToQueue, bool checkFaceResources) |
| void | [SetMobility](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a4ec044f88d50616ee4f0a8e0234495c8) ([GameEntity.Mobility](class_tale_worlds_1_1_engine_1_1_game_entity.html#ae93c67956cedcdb3da1cb8776e7792ed) mobility) |
| [GameEntity.Mobility](class_tale_worlds_1_1_engine_1_1_game_entity.html#ae93c67956cedcdb3da1cb8776e7792ed) | [GetMobility](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a8857f3e373cee3b9f582970a1bd4d04c) () |
| void | [AddMesh](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a564cea1d38bc5ce34c9c75d1185b7298) ([Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) mesh, bool recomputeBoundingBox=true) |
| void | [AddMultiMeshToSkeleton](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a0441a72e0081afb8cff72fae4ed70947) ([MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) metaMesh) |
| void | [AddMultiMeshToSkeletonBone](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#abbc686db851a7e704a86fff423a2be6d) ([MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) metaMesh, sbyte boneIndex) |
| void | [SetColorToAllMeshesWithTagRecursive](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a09044c664d0b5e1d163c8e18e2bbe99c) (uint color, string tag) |
| IEnumerable< [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) > | [GetAllMeshesWithTag](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a204e72fc5255142a9df38de23afd0a70) (string tag) |
| void | [SetName](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a530f052665399670613c9f9aaa84e3ec) (string name) |
| void | [SetEntityFlags](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a77ba2e75403d682d2e2de39a4f01440d) ([EntityFlags](namespace_tale_worlds_1_1_engine.html#ac9a5b603c15afe87f8ec5f36d2e73285) flags) |
| void | [SetEntityVisibilityFlags](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a605d9c65b3d974f88784d2d4dcfab0a7) ([EntityVisibilityFlags](namespace_tale_worlds_1_1_engine.html#abd0987b9b449d071edb76504a2e737f8) flags) |
| [PhysicsMaterial](struct_tale_worlds_1_1_engine_1_1_physics_material.html) | [GetPhysicsMaterial](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ac869d01dd270f20b9248276df3b01e0d) () |
| void | [SetBodyFlags](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a3d7dd7bf8b36588199d54d65651485b0) ([BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) flags) |
| void | [SetBodyFlagsRecursive](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a17420cc0094951e60d91a7e97379e156) ([BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) bodyFlags) |
| void | [AddBodyFlags](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ae196d678fc214c57a1fe27c1a5a07c1e) ([BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) bodyFlags, bool applyToChildren=true) |
| void | [RemoveBodyFlags](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a23a1db799920af71089658daa29cf8be) ([BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) bodyFlags, bool applyToChildren=true) |
| void | [SetLocalPosition](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a4a1c8f8d6d6cac3462b8219167a14982) ([Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) position) |
| void | [SetGlobalPosition](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a8f33e0a6398a4a69c9009e63df8afd24) ([Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) position) |
| void | [SetColor](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a396d91639de3c2769706095dbf5ff38f) (uint color1, uint color2, string meshTag) |
| uint | [GetFactorColor](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a6b4f98c80d077f98909b74a56750db98) () |
| void | [SetFactorColor](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a51f69b359b7e3c7349cf2d40cbadaadf) (uint color) |
| void | [SetAsReplayEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#abea2b4a67cea127d86cecb3afd06dd04) () |
| void | [SetClothMaxDistanceMultiplier](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a554205f499778eef48e814d678ddbd72) (float multiplier) |
| void | [RemoveMultiMeshFromSkeleton](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a4e62f8500600b86d48ce463fadcc8a0a) ([MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) metaMesh) |
| void | [RemoveMultiMeshFromSkeletonBone](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a3def6703f6c2885c721c3244600e477e) ([MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) metaMesh, sbyte boneIndex) |
| bool | [RemoveComponentWithMesh](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a2b4679cadfc1f8a100f858f43d1a7b4c) ([Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) mesh) |
| void | [AddComponent](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a13c39cf979304cde503ddfb75109ec23) ([GameEntityComponent](class_tale_worlds_1_1_engine_1_1_game_entity_component.html) component) |
| bool | [HasComponent](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ae094621c2bdbe394b9c8427658cd274a) ([GameEntityComponent](class_tale_worlds_1_1_engine_1_1_game_entity_component.html) component) |
| bool | [IsInEditorScene](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a69a95f2d31b815da0641bcf1c54f67f6) () |
| bool | [RemoveComponent](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a0fec375bdc091e80b63abfbb64b8973f) ([GameEntityComponent](class_tale_worlds_1_1_engine_1_1_game_entity_component.html) component) |
| string | [GetGuid](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a5882a28ab6c17ca190c548c246bce319) () |
| bool | [IsGuidValid](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a806630c5fc3fa72e915f0190367b9382) () |
| void | [SetEnforcedMaximumLodLevel](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a71ffd93f1040fdff909f1bce440c46ac) (int lodLevel) |
| float | [GetLodLevelForDistanceSq](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ab337c2e7d4608d2773eea0380f48b2dc) (float distSq) |
| void | [GetQuickBoneEntitialFrame](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#af78b99225cf6712379af2802f0c2a076) (sbyte index, out [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame) |
| void | [UpdateVisibilityMask](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a2fad582520fbd1e57e1c2cbf25cb386f) () |
| void | [CallScriptCallbacks](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a3c7b3eb64647f2efb28709442ea45f38) (bool registerScriptComponents) |
| bool | [IsGhostObject](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a002f9add8c7f539f50cfe82691b3a4ce) () |
| void | [CreateAndAddScriptComponent](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ad3960067f48a3a69f794e6e5a679387c) (string name, bool callScriptCallbacks) |
| void | [RemoveScriptComponent](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aa5d03b7d97a9c86d5edcc833c83f7b59) (UIntPtr scriptComponent, int removeReason) |
| void | [SetEntityEnvMapVisibility](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a587e1c8b54864b912987480c440a5113) (bool value) |
| bool | [HasScene](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a0273bd559e43796ce094c69e8f03128f) () |
| bool | [HasScriptComponent](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a578075f6fe1d503b86b71f6595328343) (string scName) |
| bool | [HasScriptComponent](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ab00d351f38ba27df32dfe95433e7cca1) (UInt32 scNameHash) |
| IEnumerable< [ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) > | [GetScriptComponents](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ad02859dcaf2889640035b8ce84f718d7) () |
| IEnumerable< T > | [GetScriptComponents< T >](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a615cd9dec80e859736d25f3eb6ceeefc) () |
| bool | [HasScriptOfType< T >](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aedfa41d44d256ae2c72df180c48ca597) () |
| bool | [HasScriptOfType](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a9b5bde79053cb1d66b6fa5bfc9c3d221) (Type t) |
| T | [GetFirstScriptOfTypeInFamily< T >](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a72ae54e418b692947098294399127108) () |
| [ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | [GetFirstScriptWithNameHash](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aadb69a6381840628756d90c0d745ae26) (UInt32 nameHash) |
| T | [GetFirstScriptOfType< T >](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ad29d2220a41efebea41df2dc5682cfa5) () |
| T | [GetFirstScriptOfTypeRecursive< T >](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a60ddbbf2021ba1cb0c655a83c0a93910) () |
| WeakGameEntity | [GetFirstChildEntityWithTag](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a71d8286fb62e694276cd386d09e5af65) (string tag) |
| int | [GetScriptCountOfTypeRecursive< T >](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a8718909874338b71adbab9b524e9ade1) () |
| void | [SetAlpha](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a742178c22351e09284ef2cb3abb33ff8) (float alpha) |
| void | [SetVisibilityExcludeParents](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a30b6db9778f1f0972199032e008dbcad) (bool visible) |
| void | [SetReadyToRender](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ac1d3664e3180e520f1377a11b980710e) (bool ready) |
| bool | [GetVisibilityExcludeParents](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a352db2b0ee48b702b09d217e91f465be) () |
| bool | [IsVisibleIncludeParents](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a802dfdfd603be7f544e2f878e465befe) () |
| UInt32 | [GetVisibilityLevelMaskIncludingParents](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ad2aae30383ee4839dc36c21b1ff0caf1) () |
| bool | [GetEditModeLevelVisibility](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#abe7581001d2686757454f0b345bea1e3) () |
| void | [Remove](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a4ebc1ce7f545f1ee7a25d9476fe0a7aa) (int removeReason) |
| void | [SetUpgradeLevelMask](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a5ff75b24327afcda1dc547391d0ad5fc) ([GameEntity.UpgradeLevelMask](class_tale_worlds_1_1_engine_1_1_game_entity.html#a3982fe736aa4855ea8106d6d16348768) mask) |
| [GameEntity.UpgradeLevelMask](class_tale_worlds_1_1_engine_1_1_game_entity.html#a3982fe736aa4855ea8106d6d16348768) | [GetUpgradeLevelMask](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a4504fb110ab4cd8f4210e295fb9b5c4f) () |
| [GameEntity.UpgradeLevelMask](class_tale_worlds_1_1_engine_1_1_game_entity.html#a3982fe736aa4855ea8106d6d16348768) | [GetUpgradeLevelMaskCumulative](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ab3506604898ab8829b52e5b340718e85) () |
| int | [GetUpgradeLevelOfEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#af750f9c2d569731e7dcab5125bbeada6) () |
| string | [GetOldPrefabName](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a1b4d68596b70a7e1327c31702a219796) () |
| string | [GetPrefabName](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a64dad0f75b11b678071622265d66301b) () |
| void | [RefreshMeshesToRenderToHullWater](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ad7be9fbd6046344ad937d69ca0f66e42) (UIntPtr visualRecord, string entityTag) |
| void | [DeRegisterWaterMeshMaterials](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a13977d030f383564f8509244c726c632) (UIntPtr visualRecord) |
| void | [SetVisualRecordWakeParams](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a84a92209d59fb50be3a78d0101ad3afe) (UIntPtr visualRecord, [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) wakeParams) |
| void | [ChangeResolutionMultiplierOfWaterVisual](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a3effc436a3ab69446c377c1e03b5dceb) (UIntPtr visualRecord, float multiplier, in [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) waterEffectsBB) |
| void | [ResetHullWater](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ae23e233d299a35d435076b30255687d0) (UIntPtr visualRecord) |
| void | [SetWaterVisualRecordFrameAndDt](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#addb31f2b3e8125ff2b17f3652f74b0fe) (UIntPtr visualRecord, [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame, float dt) |
| void | [AddSplashPositionToWaterVisualRecord](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a1becbe45f4bf7c3d154baf18528b4138) (UIntPtr visualRecord, [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) position) |
| void | [UpdateHullWaterEffectFrames](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a9b8b7f995bd5654dbd8d1d5bf96ae179) (UIntPtr visualRecord) |
| void | [CopyScriptComponentFromAnotherEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#afa8b7cfe7b470e17638a4d9b2929b3be) ([GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) otherEntity, string scriptName) |
| void | [SetFrame](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#af9c0c48d6f10074a3e9c1cfdf9e14a7d) (ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame, bool isTeleportation=true) |
| void | [SetLocalFrame](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aabb7414decdfa6cc8806eacdd2815f51) (ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame, bool isTeleportation) |
| void | [SetClothComponentKeepState](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a95382e25c970fe0258bd37e11311dd30) ([MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) metaMesh, bool state) |
| void | [SetClothComponentKeepStateOfAllMeshes](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a9bf2b2f667e3d2ccb400d0b502a75740) (bool state) |
| void | [SetPreviousFrameInvalid](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#adab4845045d8f152e9ee04682b220b39) () |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetFrame](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a97b715f56c0a3a18e00d4ce016198615) () |
| void | [GetLocalFrame](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a651a9c5b51e443fa5869009349fdad93) (out [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame) |
| bool | [HasBatchedKinematicPhysicsFlag](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef1195ee871853e31822ed615ad396b9) () |
| bool | [HasBatchedRayCastPhysicsFlag](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a73a1fa55bd11e0ae95141370580ce394) () |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetLocalFrame](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a5234ab0d85741131eeed5a33fd5c15b6) () |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetGlobalFrame](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a104abc7d3cdcc4f271c19320e630c7c0) () |
| void | [SetWaterSDFClipData](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a5cde2c0d486f67c1cd5a14e2694b9d67) (int slotIndex, in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame, bool visibility) |
| int | [RegisterWaterSDFClip](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aa181d790b83aeb23fe203f74a57924bd) ([Texture](class_tale_worlds_1_1_engine_1_1_texture.html) sdfTexture) |
| void | [DeRegisterWaterSDFClip](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aa70b3042c30ded895c4c7c8b57ac5c11) (int slot) |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetGlobalFrameImpreciseForFixedTick](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aba1348819c16f68e3ae387ca8ed22003) () |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [ComputePreciseGlobalFrameForFixedTickSlow](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a8a42d7a07b1cd1165771734b573529fe) () |
| void | [SetGlobalFrame](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a1c79cb6db05481dc67c0eb24b399f709) (in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame, bool isTeleportation=true) |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetPreviousGlobalFrame](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ac2d14f96dc0af7dc7814335308fb11c2) () |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetBodyWorldTransform](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ac316680536403201eb3a96a7d8b99997) () |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetBodyVisualWorldTransform](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ab55417b61861f3f0277af46d84d3738c) () |
| void | [UpdateTriadFrameForEditor](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a17a8170d997aaae6245788313d5533e6) () |
| void | [UpdateTriadFrameForEditorForAllChildren](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ac053507a801cacde783a50284cb8bb4c) () |
| [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) | [GetGlobalScale](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aed47a601be90b54cbe1a1f15c75d72cf) () |
| [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) | [GetLocalScale](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a5e293d2265dea9f3ecf9dc8835a2f076) () |
| void | [SetAnimationSoundActivation](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ac3ee1fc165ed32359637bbdadb23086c) (bool activate) |
| void | [CopyComponentsToSkeleton](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aad4fb00827c97c01346b6e456769af53) () |
| void | [AddMeshToBone](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aff5a131d6e1b81355f07f90598309756) (sbyte boneIndex, [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) mesh) |
| void | [ActivateRagdoll](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a6857faa0a2472959b2217931ba90e7f9) () |
| void | [PauseSkeletonAnimation](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a29877295d7a92fb95cf9d520e53ec16a) () |
| void | [ResumeSkeletonAnimation](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a72ea83794ab1950abc0df334783322eb) () |
| bool | [IsSkeletonAnimationPaused](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a4b51704d53796c3a55d6249ffbed8a91) () |
| sbyte | [GetBoneCount](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a877bd5ac429cf5e9e651641deecaaec9) () |
| float | [GetWaterLevelAtPosition](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#af68f3873cda7cc25291b32936b937f0b) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position, bool useWaterRenderer, bool checkWaterBodyEntities) |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetBoneEntitialFrameWithIndex](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a535a5a55d11f33465820c884fa34508d) (sbyte boneIndex) |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetBoneEntitialFrameWithName](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#af80464a0b5bdb60a253f8f63c347c07a) (string boneName) |
| void | [AddTag](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ae12bae9724a72dfc088228d92fb63c83) (string tag) |
| void | [RemoveTag](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a372164ac5320e1e96502e809512e35f6) (string tag) |
| bool | [HasTag](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ab58271b2c309c5f3f41e2e3d569a3b1f) (string tag) |
| void | [AddChild](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ac2a90bb5279e05401ac193b9207c76d0) (WeakGameEntity gameEntity, bool autoLocalizeFrame=false) |
| void | [RemoveChild](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a94ee5c5f6bf83b9e3532a07f33f76493) (WeakGameEntity childEntity, bool keepPhysics, bool keepScenePointer, bool callScriptCallbacks, int removeReason) |
| void | [BreakPrefab](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a120372a4a916813d070b143e17bb1a88) () |
| WeakGameEntity | [GetChild](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#acf584a3019e60e844de8df7fca30621b) (int index) |
| bool | [HasComplexAnimTree](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a7afff22b33cb6df0c68fe9b21749bee3) () |
| void | [AddMultiMesh](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a31cb74dff1da3fe4313423d87d467a68) ([MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) metaMesh, bool updateVisMask=true) |
| bool | [RemoveMultiMesh](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a3c68cfa3a1b1d86f7fd51712e990d6d6) ([MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) metaMesh) |
| int | [GetComponentCount](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a41cb9bd241c84017ed739b735faa6c49) ([GameEntity.ComponentType](class_tale_worlds_1_1_engine_1_1_game_entity.html#ac6f57c8912eaaf5a59c14ec2f153350b) componentType) |
| void | [AddAllMeshesOfGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aae608e73e2eff7546413856f32d8a0d8) ([GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity) |
| void | [SetFrameChanged](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a83695d47becda8d7d78bdb9b508f731a) () |
| [GameEntityComponent](class_tale_worlds_1_1_engine_1_1_game_entity_component.html) | [GetComponentAtIndex](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a7100b74525b8a90518b9bd0f5b595f19) (int index, [GameEntity.ComponentType](class_tale_worlds_1_1_engine_1_1_game_entity.html#ac6f57c8912eaaf5a59c14ec2f153350b) componentType) |
| [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | [GetMetaMesh](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a70dd627b6143ddff33fa9862d63af1c8) (int metaMeshIndex) |
| [ClothSimulatorComponent](class_tale_worlds_1_1_engine_1_1_cloth_simulator_component.html) | [GetClothSimulator](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a92ff87be9b778ccd40ed8e2114284dca) (int clothSimulatorIndex) |
| void | [SetVectorArgument](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a893db5bfb352b535f2922ec2c7f2a6f8) (float vectorArgument0, float vectorArgument1, float vectorArgument2, float vectorArgument3) |
| void | [SetMaterialForAllMeshes](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a51695f7c1ea206b28d53531fe9247f0f) ([Material](class_tale_worlds_1_1_engine_1_1_material.html) material) |
| bool | [AddLight](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aeb03ca93bc716bef9b485cf743714de7) ([Light](class_tale_worlds_1_1_engine_1_1_light.html) light) |
| [Light](class_tale_worlds_1_1_engine_1_1_light.html) | [GetLight](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ac7c4371ef32c1510dc670424aeee875e) () |
| void | [AddParticleSystemComponent](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a3ac26ff2c7edf382750fb19a6588057e) (string particleid) |
| void | [RemoveAllParticleSystems](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#af9ee7a445e78ecfa0d62ff51a5151e50) () |
| bool | [CheckPointWithOrientedBoundingBox](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a51c9c5e0297be966fac060e79aacd710) ([Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) point) |
| void | [PauseParticleSystem](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a29b6f3eb6df594fca140fafbe2ac46d2) (bool doChildren) |
| void | [ResumeParticleSystem](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a1cf03535210707689fd53cec618e2270) (bool doChildren) |
| void | [BurstEntityParticle](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a04b443313870cfadb3eff867959ac0bf) (bool doChildren) |
| void | [SetRuntimeEmissionRateMultiplier](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aaf6f31fcbd26edec1a4102baaa8a5804) (float emissionRateMultiplier) |
| [BoundingBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html) | [GetLocalBoundingBox](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a4066c26603f14331a73e6b8e4bf8c415) () |
| [BoundingBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html) | [GetGlobalBoundingBox](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a90f171a910b9d0f6bcb6ac024d4d5214) () |
| [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) | [GetBoundingBoxMin](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a30d50e65f82da10a81f808404022af2d) () |
| void | [SetHasCustomBoundingBoxValidationSystem](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ab1a5c6771e5fb6ec128d825499814649) (bool hasCustomBoundingBox) |
| void | [ValidateBoundingBox](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a8bb95d7147b0d3c5f94b282b16e35c78) () |
| [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) | [GetBoundingBoxMax](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ab87887f2d90bf4386c34dc43b8d35a7e) () |
| void | [UpdateGlobalBounds](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ac2e54a532e4fbf4c5cfa8b37472581db) () |
| void | [RecomputeBoundingBox](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a4c662c851cdd6c09bdb7de02e2526822) () |
| float | [GetBoundingBoxRadius](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a2fa5260c67311446f89fa00d54cd69fd) () |
| void | [SetBoundingboxDirty](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a0725e43f2611e5f78db77748f6921c75) () |
| [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) | [ComputeGlobalPhysicsBoundingBoxMinMax](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ae2bb76de7e44a405248c1cf20c560cce) () |
| [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) | [ComputeGlobalPhysicsBoundingBoxCenter](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a083e3dd76b4d0da400be5c402d23699e) () |
| void | [SetContourColor](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a1ca08f290f742a5f7b3384d7db64c692) (uint? color, bool alwaysVisible=true) |
| bool | [GetHasFrameChanged](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a703e710a3bb72a1ceb20bb9d04aeb50e) () |
| [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) | [GetFirstMesh](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#af4104387783383785ba439f20ae12bc7) () |
| int | [GetAttachedNavmeshFaceCount](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a84523c2b5af0d463d6ae9214911c4a6a) () |
| void | [GetAttachedNavmeshFaceRecords](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a134f3974928deed46fb6e697fa9b93fe) ([PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html)[] faceRecords) |
| void | [GetAttachedNavmeshFaceVertexIndices](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a07cf6b22a2586bbe47775cfc29700c0a) (in [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) faceRecord, int[] indices) |
| void | [SetCustomVertexPositionEnabled](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a9ee85fa1f76d0eda214c5135fb3f5b2d) (bool customVertexPositionEnabled) |
| void | [SetPositionsForAttachedNavmeshVertices](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a1d8284c6b7ebc48c769f040768d9f6c7) (int[] vertices, int indexCount, [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e)[] positions) |
| void | [SetCostAdderForAttachedFaces](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a149d1770de98c8a79643f34440efcd69) (float costs) |
| void | [SetExternalReferencesUsage](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a03607aac183116a5cc5d8979560d8d79) (bool value) |
| void | [SetMorphFrameOfComponents](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a21d994094926951da369eac87e5c863b) (float value) |
| void | [AddEditDataUserToAllMeshes](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a34f55ceb9668e8cc60c04001c32f7831) (bool entityComponents, bool skeletonComponents) |
| void | [ReleaseEditDataUserToAllMeshes](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ac6e201a4274435f14813aa58670b3ada) (bool entityComponents, bool skeletonComponents) |
| void | [GetCameraParamsFromCameraScript](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a8116a7084338911e48b65ddd5c4d8e5e) ([Camera](class_tale_worlds_1_1_engine_1_1_camera.html) cam, ref [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) dofParams) |
| void | [GetMeshBendedFrame](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ac025b3a86e69283937a0736acfc73f1a) ([MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) worldSpacePosition, ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) output) |
| void | [ComputeTrajectoryVolume](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#af1f4f70fc25473c1a1e0b98ef14a4e28) (float missileSpeed, float verticalAngleMaxInDegrees, float verticalAngleMinInDegrees, float horizontalAngleRangeInDegrees, float airFrictionConstant) |
| void | [SetAnimTreeChannelParameterForceUpdate](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a36a59c20071570018538cc4191cd5480) (float phase, int channelNo) |
| void | [ChangeMetaMeshOrRemoveItIfNotExists](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aa7003edb0e4d6bcedfa6edd359350cae) ([MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) entityMetaMesh, [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) newMetaMesh) |
| void | [SetUpdateValidtyOnFrameChangedOfFacesWithId](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a5fb2078b0950a0a746e476f98d73f6f1) (int faceGroupId, bool updateValidity) |
| void | [AttachNavigationMeshFaces](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a25ad67c1aaf68b086271ca1b3af15511) (int faceGroupId, bool isConnected, bool isBlocker=false, bool autoLocalize=false, bool finalizeBlockerConvexHullComputation=false, bool updateEntityFrame=true) |
| void | [DetachAllAttachedNavigationMeshFaces](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#abd680d13dabed8ac8d31dfe3d960f888) () |
| void | [UpdateAttachedNavigationMeshFaces](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a98605ba80773cee262c1a8df39c3991e) () |
| void | [RemoveSkeleton](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#af36fd42a8ac4b43bb0d53b8cb49fafe6) () |
| void | [RemoveAllChildren](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aae5d201fce712e82937efffd69330f10) () |
| IEnumerable< WeakGameEntity > | [GetChildren](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aa749edeffae78bfde2760a86a8e0848e) () |
| IEnumerable< WeakGameEntity > | [GetEntityAndChildren](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a769179e297f8f7711e8e08772c704ba6) () |
| void | [GetChildrenRecursive](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a31174107843c7650ba6c12d487c4372a) (ref List< WeakGameEntity > children) |
| void | [GetChildrenWithTagRecursive](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ae7b6ae471a8fdcff594ad7ffab2b3661) (List< WeakGameEntity > children, string tag) |
| bool | [IsSelectedOnEditor](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#abfe75ab41ff25b623ad447bcbf794fbf) () |
| void | [SelectEntityOnEditor](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ab62829af6988dc0c4f6ce9ea0a0e1fc1) () |
| void | [DeselectEntityOnEditor](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a53346ea2d4d5de0aceed4a433940e876) () |
| void | [SetAsPredisplayEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ac6ed61ca27241921f58b5e464ffdb356) () |
| void | [RemoveFromPredisplayEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a5c9618d8a8aa3936b1054b69cc26c774) () |
| void | [SetNativeScriptComponentVariable](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a78ff4d94979b4e14336b776b3efd5c20) (string className, string fieldName, ref [ScriptComponentFieldHolder](struct_tale_worlds_1_1_engine_1_1_script_component_field_holder.html) data, [RglScriptFieldType](namespace_tale_worlds_1_1_engine.html#adf2b4fe3d75a4a2c03eaf8620c096933) variableType) |
| void | [SetManualGlobalBoundingBox](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a760b1d8fc07628dec2e9b64115cd0899) ([Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) boundingBoxStartGlobal, [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) boundingBoxEndGlobal) |
| bool | [RayHitEntityWithNormal](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a7daa84a67cb755c53c33923439468029) ([Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) rayOrigin, [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) rayDirection, float maxLength, ref [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) resultNormal, ref float resultLength) |
| bool | [RayHitEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ad7016da8b129a86eb355e70ba6d93046) ([Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) rayOrigin, [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) rayDirection, float maxLength, ref float resultLength) |
| void | [GetNativeScriptComponentVariable](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a683d55a536733e1dbddbda675e9f01f1) (string className, string fieldName, ref [ScriptComponentFieldHolder](struct_tale_worlds_1_1_engine_1_1_script_component_field_holder.html) data, [RglScriptFieldType](namespace_tale_worlds_1_1_engine.html#adf2b4fe3d75a4a2c03eaf8620c096933) variableType) |
| void | [SetCustomClipPlane](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a4515ba97989530812a1de7b4b3aa658e) ([Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) clipPosition, [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) clipNormal, bool setForChildren) |
| float | [GetBoundingBoxLongestHalfDimension](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a6bf4a93fd6b4aac25683174e5d37c25b) () |
| [BoundingBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html) | [ComputeBoundingBoxFromLongestHalfDimension](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aeb42497860ea66d3b900305289a45dd3) (float longestHalfDimensionCoefficient) |
| [BoundingBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html) | [ComputeBoundingBoxIncludeChildren](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a71df47b2dd743c7b729f4271e698107a) () |
| void | [SetManualLocalBoundingBox](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#adc3d7a9caa1a972bace69b2d493cf6c1) (in [BoundingBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html) boundingBox) |
| void | [RelaxLocalBoundingBox](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a20739aff98c2f0ba55e096484ba26f25) (in [BoundingBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html) boundingBox) |
| void | [SetCullMode](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a4ed581ab942d907fbf67ccae3fe8023a) ([MBMeshCullingMode](namespace_tale_worlds_1_1_engine.html#a8363ee42e6331c6a31ed88216accec29) cullMode) |
| WeakGameEntity | [GetFirstChildEntityWithTagRecursive](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a0dab051cadaf0685f997386dbbb6092e) (string tag) |
| override bool | [Equals](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a1e25f0115b9c2808eead5b89b608dbaf) (object obj) |
| override int | [GetHashCode](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a7f2c84e8f9a96b8bbef86f4a1917e66d) () |
| List< WeakGameEntity > | [CollectChildrenEntitiesWithTag](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ae663acc114dc8951df2ad25f5099c3b9) (string tag) |
| IEnumerable< WeakGameEntity > | [CollectChildrenEntitiesWithTagAsEnumarable](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a46823156249ab501b389a65ddeb925be) (string tag) |
| void | [SetDoNotCheckVisibility](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a148bedef84757838e33de6e1886d54d2) (bool value) |
| void | [SetBoneFrameToAllMeshes](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ae3e5f8152461cf24867b9b25b4ee3b50) (int boneIndex, in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetGlobalWindStrengthVectorOfScene](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ab6a9e31b725d439566ed31987bdad482) () |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetGlobalWindVelocityOfScene](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aeef5c8b33fae2ff211217fd8bf5305bc) () |
| [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) | [GetLastFinalRenderCameraPositionOfScene](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a870978157cf80b630412b41881164610) () |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetGlobalWindVelocityWithGustNoiseOfScene](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a4e6fc3f5cb8976d4cb1242d40fc41ee9) (float globalTime) |
| void | [SetForceDecalsToRender](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a1d653dc2c6f46478b905434cac396005) (bool value) |
| UIntPtr | [CreateEmptyPhysxShape](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a510d1caf32fbe2ec56c8e5c8277d6eb2) (bool isVariable, int physxMaterialIndex) |
| void | [SetForceNotAffectedBySeason](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#abad005833e778a45b125dee18a2733f8) (bool value) |
| bool | [CheckIsPrefabLinkRootPrefab](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ae944e44c0271e6ecd612caffa1f96a8e) (int depth) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static bool | [operator==](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#abd20d8810a33fe9a8b2340533ce33605) (WeakGameEntity weakGameEntity, [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) entity) |
| static bool | [operator!=](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a914f0bd5878f658a6004e2cd02d96468) (WeakGameEntity weakGameEntity, [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) entity) |
| static bool | [operator==](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a75717fbde02d5f677d88ba94baeda8ce) (WeakGameEntity weakGameEntity1, WeakGameEntity weakGameEntity2) |
| static bool | [operator!=](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aa4c6f89d67b263512bea2a0f3909f011) (WeakGameEntity weakGameEntity1, WeakGameEntity weakGameEntity2) |

|  |  |
| --- | --- |
| Public Attributes | |
|  | [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static readonly WeakGameEntity | [Invalid](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a17f94095d4589038ab51c92ee657eb99) = new WeakGameEntity(UIntPtr.Zero) |

|  |  |
| --- | --- |
| Properties | |
| UIntPtr | [Pointer](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a9396e1a24b2c0308f5210e146295e256) `[get]` |
| bool | [IsValid](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a2b040704f579d10dd2823fc01b3a5b19) `[get]` |
| string | [Name](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a20a1883ba44a36f127479fb7dfde45c2) `[get]` |
| Scene | [Scene](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ab278f9d0be6def2080c32c429b97e5fe) `[get]` |
| [EntityFlags](namespace_tale_worlds_1_1_engine.html#ac9a5b603c15afe87f8ec5f36d2e73285) | [EntityFlags](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a007686f4d4cedf1c76bfa8cb71bb75c7) `[get]` |
| [EntityVisibilityFlags](namespace_tale_worlds_1_1_engine.html#abd0987b9b449d071edb76504a2e737f8) | [EntityVisibilityFlags](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aee5fa8196f75c09ce2a80fb11e81fca7) `[get]` |
| [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) | [BodyFlag](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#afdaca67f82dd7e0313025c4ac0a90107) `[get]` |
| [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) | [PhysicsDescBodyFlag](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#abcbba99ba8f224e81a209e65e038044b) `[get]` |
| float | [Mass](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a6a134321fb7dcf628ec24e7fa2bae572) `[get]` |
| [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) | [CenterOfMass](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a94c60bb58fe545a63a855059bd24fc2d) `[get]` |
| [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) | [GlobalPosition](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#af604f4aa7c9bd90276ddd92b12f7f1e4) `[get]` |
| string[] | [Tags](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a399bf27db53a2151807bc299cab91a9f) `[get]` |
|  | Gets the tags of the entity, which can only be set in the edit mode. |
| int | [ChildCount](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#afa172bdde33deee171eaf43fb754a6e3) `[get]` |
| WeakGameEntity | [Parent](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aaa7af452d35452b39977335673612f80) `[get]` |
| WeakGameEntity | [Root](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a6af5aabd7dea81c335deb7435e86ce6b) `[get]` |
|  | Gets the top most parent of this entity. |
| int | [MultiMeshComponentCount](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aabf05d8e08e6678e32983c23075f01ea) `[get]` |
| int | [ClothSimulatorComponentCount](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a132b834d66772f594bc57723b9d8cbc5) `[get]` |
| [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) | [GlobalBoxMax](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a58674645fffa8375709c93b63cc040f6) `[get]` |
| [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) | [GlobalBoxMin](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a76525e2a2541f3ace4e5c48e4adf9f50) `[get]` |
| Skeleton | [Skeleton](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a2e4594091eab738c65a434b6d1e9cc69) `[get, set]` |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#abc384e72ad9db6f2431646cacba1287b)Invalidate()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.Invalidate | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#af7bb74fa9fc7b4af1d7179bf10c005e2)GetScenePointer()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| UIntPtr TaleWorlds.Engine.WeakGameEntity.GetScenePointer | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a3bc3af06281f292e15cb841d7bd09662)ToString()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.Engine.WeakGameEntity.ToString | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ae221fe6bdf1547235d5af989d141d7b5)ClearEntityComponents()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.ClearEntityComponents | ( | bool | *resetAll*, |
|  |  | bool | *removeScripts*, |
|  |  | bool | *deleteChildEntities* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a9b42999413069700a025143ef13026af)ClearComponents()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.ClearComponents | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aa83752279cc7a0c0657781590fac72d5)ClearOnlyOwnComponents()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.ClearOnlyOwnComponents | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a41fbc4fe1b662da8603c7d8c40569d05)CheckResources()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Engine.WeakGameEntity.CheckResources | ( | bool | *addToQueue*, |
|  |  | bool | *checkFaceResources* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a4ec044f88d50616ee4f0a8e0234495c8)SetMobility()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetMobility | ( | [GameEntity.Mobility](class_tale_worlds_1_1_engine_1_1_game_entity.html#ae93c67956cedcdb3da1cb8776e7792ed) | *mobility* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a8857f3e373cee3b9f582970a1bd4d04c)GetMobility()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [GameEntity.Mobility](class_tale_worlds_1_1_engine_1_1_game_entity.html#ae93c67956cedcdb3da1cb8776e7792ed) TaleWorlds.Engine.WeakGameEntity.GetMobility | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a564cea1d38bc5ce34c9c75d1185b7298)AddMesh()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.AddMesh | ( | [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) | *mesh*, |
|  |  | bool | *recomputeBoundingBox* = true ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a0441a72e0081afb8cff72fae4ed70947)AddMultiMeshToSkeleton()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.AddMultiMeshToSkeleton | ( | [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | *metaMesh* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#abbc686db851a7e704a86fff423a2be6d)AddMultiMeshToSkeletonBone()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.AddMultiMeshToSkeletonBone | ( | [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | *metaMesh*, |
|  |  | sbyte | *boneIndex* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a09044c664d0b5e1d163c8e18e2bbe99c)SetColorToAllMeshesWithTagRecursive()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetColorToAllMeshesWithTagRecursive | ( | uint | *color*, |
|  |  | string | *tag* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a204e72fc5255142a9df38de23afd0a70)GetAllMeshesWithTag()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| IEnumerable< [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) > TaleWorlds.Engine.WeakGameEntity.GetAllMeshesWithTag | ( | string | *tag* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a530f052665399670613c9f9aaa84e3ec)SetName()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetName | ( | string | *name* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a77ba2e75403d682d2e2de39a4f01440d)SetEntityFlags()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetEntityFlags | ( | [EntityFlags](namespace_tale_worlds_1_1_engine.html#ac9a5b603c15afe87f8ec5f36d2e73285) | *flags* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a605d9c65b3d974f88784d2d4dcfab0a7)SetEntityVisibilityFlags()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetEntityVisibilityFlags | ( | [EntityVisibilityFlags](namespace_tale_worlds_1_1_engine.html#abd0987b9b449d071edb76504a2e737f8) | *flags* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ac869d01dd270f20b9248276df3b01e0d)GetPhysicsMaterial()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [PhysicsMaterial](struct_tale_worlds_1_1_engine_1_1_physics_material.html) TaleWorlds.Engine.WeakGameEntity.GetPhysicsMaterial | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a3d7dd7bf8b36588199d54d65651485b0)SetBodyFlags()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetBodyFlags | ( | [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) | *flags* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a17420cc0094951e60d91a7e97379e156)SetBodyFlagsRecursive()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetBodyFlagsRecursive | ( | [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) | *bodyFlags* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ae196d678fc214c57a1fe27c1a5a07c1e)AddBodyFlags()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.AddBodyFlags | ( | [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) | *bodyFlags*, |
|  |  | bool | *applyToChildren* = true ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a23a1db799920af71089658daa29cf8be)RemoveBodyFlags()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.RemoveBodyFlags | ( | [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) | *bodyFlags*, |
|  |  | bool | *applyToChildren* = true ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a4a1c8f8d6d6cac3462b8219167a14982)SetLocalPosition()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetLocalPosition | ( | [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) | *position* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a8f33e0a6398a4a69c9009e63df8afd24)SetGlobalPosition()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetGlobalPosition | ( | [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) | *position* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a396d91639de3c2769706095dbf5ff38f)SetColor()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetColor | ( | uint | *color1*, |
|  |  | uint | *color2*, |
|  |  | string | *meshTag* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a6b4f98c80d077f98909b74a56750db98)GetFactorColor()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| uint TaleWorlds.Engine.WeakGameEntity.GetFactorColor | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a51f69b359b7e3c7349cf2d40cbadaadf)SetFactorColor()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetFactorColor | ( | uint | *color* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#abea2b4a67cea127d86cecb3afd06dd04)SetAsReplayEntity()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetAsReplayEntity | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a554205f499778eef48e814d678ddbd72)SetClothMaxDistanceMultiplier()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetClothMaxDistanceMultiplier | ( | float | *multiplier* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a4e62f8500600b86d48ce463fadcc8a0a)RemoveMultiMeshFromSkeleton()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.RemoveMultiMeshFromSkeleton | ( | [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | *metaMesh* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a3def6703f6c2885c721c3244600e477e)RemoveMultiMeshFromSkeletonBone()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.RemoveMultiMeshFromSkeletonBone | ( | [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | *metaMesh*, |
|  |  | sbyte | *boneIndex* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a2b4679cadfc1f8a100f858f43d1a7b4c)RemoveComponentWithMesh()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.WeakGameEntity.RemoveComponentWithMesh | ( | [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) | *mesh* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a13c39cf979304cde503ddfb75109ec23)AddComponent()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.AddComponent | ( | [GameEntityComponent](class_tale_worlds_1_1_engine_1_1_game_entity_component.html) | *component* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ae094621c2bdbe394b9c8427658cd274a)HasComponent()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.WeakGameEntity.HasComponent | ( | [GameEntityComponent](class_tale_worlds_1_1_engine_1_1_game_entity_component.html) | *component* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a69a95f2d31b815da0641bcf1c54f67f6)IsInEditorScene()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.WeakGameEntity.IsInEditorScene | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a0fec375bdc091e80b63abfbb64b8973f)RemoveComponent()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.WeakGameEntity.RemoveComponent | ( | [GameEntityComponent](class_tale_worlds_1_1_engine_1_1_game_entity_component.html) | *component* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a5882a28ab6c17ca190c548c246bce319)GetGuid()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.Engine.WeakGameEntity.GetGuid | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a806630c5fc3fa72e915f0190367b9382)IsGuidValid()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.WeakGameEntity.IsGuidValid | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a71ffd93f1040fdff909f1bce440c46ac)SetEnforcedMaximumLodLevel()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetEnforcedMaximumLodLevel | ( | int | *lodLevel* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ab337c2e7d4608d2773eea0380f48b2dc)GetLodLevelForDistanceSq()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.Engine.WeakGameEntity.GetLodLevelForDistanceSq | ( | float | *distSq* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#af78b99225cf6712379af2802f0c2a076)GetQuickBoneEntitialFrame()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.GetQuickBoneEntitialFrame | ( | sbyte | *index*, |
|  |  | out [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a2fad582520fbd1e57e1c2cbf25cb386f)UpdateVisibilityMask()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.UpdateVisibilityMask | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a3c7b3eb64647f2efb28709442ea45f38)CallScriptCallbacks()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.CallScriptCallbacks | ( | bool | *registerScriptComponents* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a002f9add8c7f539f50cfe82691b3a4ce)IsGhostObject()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.WeakGameEntity.IsGhostObject | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ad3960067f48a3a69f794e6e5a679387c)CreateAndAddScriptComponent()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.CreateAndAddScriptComponent | ( | string | *name*, |
|  |  | bool | *callScriptCallbacks* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aa5d03b7d97a9c86d5edcc833c83f7b59)RemoveScriptComponent()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.RemoveScriptComponent | ( | UIntPtr | *scriptComponent*, |
|  |  | int | *removeReason* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a587e1c8b54864b912987480c440a5113)SetEntityEnvMapVisibility()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetEntityEnvMapVisibility | ( | bool | *value* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a0273bd559e43796ce094c69e8f03128f)HasScene()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.WeakGameEntity.HasScene | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a578075f6fe1d503b86b71f6595328343)HasScriptComponent() [1/2]
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.WeakGameEntity.HasScriptComponent | ( | string | *scName* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ab00d351f38ba27df32dfe95433e7cca1)HasScriptComponent() [2/2]
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.WeakGameEntity.HasScriptComponent | ( | UInt32 | *scNameHash* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ad02859dcaf2889640035b8ce84f718d7)GetScriptComponents()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< [ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) > TaleWorlds.Engine.WeakGameEntity.GetScriptComponents | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a615cd9dec80e859736d25f3eb6ceeefc)GetScriptComponents< T >()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< T > [TaleWorlds.Engine.WeakGameEntity.GetScriptComponents](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ad02859dcaf2889640035b8ce84f718d7)< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html)* |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aedfa41d44d256ae2c72df180c48ca597)HasScriptOfType< T >()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool [TaleWorlds.Engine.WeakGameEntity.HasScriptOfType](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a9b5bde79053cb1d66b6fa5bfc9c3d221)< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html)* |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a9b5bde79053cb1d66b6fa5bfc9c3d221)HasScriptOfType()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.WeakGameEntity.HasScriptOfType | ( | Type | *t* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a72ae54e418b692947098294399127108)GetFirstScriptOfTypeInFamily< T >()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| T TaleWorlds.Engine.WeakGameEntity.GetFirstScriptOfTypeInFamily< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html)* |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aadb69a6381840628756d90c0d745ae26)GetFirstScriptWithNameHash()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) TaleWorlds.Engine.WeakGameEntity.GetFirstScriptWithNameHash | ( | UInt32 | *nameHash* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ad29d2220a41efebea41df2dc5682cfa5)GetFirstScriptOfType< T >()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| T TaleWorlds.Engine.WeakGameEntity.GetFirstScriptOfType< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html)* |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a60ddbbf2021ba1cb0c655a83c0a93910)GetFirstScriptOfTypeRecursive< T >()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| T TaleWorlds.Engine.WeakGameEntity.GetFirstScriptOfTypeRecursive< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html)* |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a71d8286fb62e694276cd386d09e5af65)GetFirstChildEntityWithTag()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| WeakGameEntity TaleWorlds.Engine.WeakGameEntity.GetFirstChildEntityWithTag | ( | string | *tag* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a8718909874338b71adbab9b524e9ade1)GetScriptCountOfTypeRecursive< T >()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.Engine.WeakGameEntity.GetScriptCountOfTypeRecursive< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html)* |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a742178c22351e09284ef2cb3abb33ff8)SetAlpha()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetAlpha | ( | float | *alpha* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a30b6db9778f1f0972199032e008dbcad)SetVisibilityExcludeParents()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetVisibilityExcludeParents | ( | bool | *visible* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ac1d3664e3180e520f1377a11b980710e)SetReadyToRender()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetReadyToRender | ( | bool | *ready* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a352db2b0ee48b702b09d217e91f465be)GetVisibilityExcludeParents()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.WeakGameEntity.GetVisibilityExcludeParents | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a802dfdfd603be7f544e2f878e465befe)IsVisibleIncludeParents()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.WeakGameEntity.IsVisibleIncludeParents | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ad2aae30383ee4839dc36c21b1ff0caf1)GetVisibilityLevelMaskIncludingParents()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| UInt32 TaleWorlds.Engine.WeakGameEntity.GetVisibilityLevelMaskIncludingParents | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#abe7581001d2686757454f0b345bea1e3)GetEditModeLevelVisibility()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.WeakGameEntity.GetEditModeLevelVisibility | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a4ebc1ce7f545f1ee7a25d9476fe0a7aa)Remove()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.Remove | ( | int | *removeReason* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a5ff75b24327afcda1dc547391d0ad5fc)SetUpgradeLevelMask()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetUpgradeLevelMask | ( | [GameEntity.UpgradeLevelMask](class_tale_worlds_1_1_engine_1_1_game_entity.html#a3982fe736aa4855ea8106d6d16348768) | *mask* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a4504fb110ab4cd8f4210e295fb9b5c4f)GetUpgradeLevelMask()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [GameEntity.UpgradeLevelMask](class_tale_worlds_1_1_engine_1_1_game_entity.html#a3982fe736aa4855ea8106d6d16348768) TaleWorlds.Engine.WeakGameEntity.GetUpgradeLevelMask | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ab3506604898ab8829b52e5b340718e85)GetUpgradeLevelMaskCumulative()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [GameEntity.UpgradeLevelMask](class_tale_worlds_1_1_engine_1_1_game_entity.html#a3982fe736aa4855ea8106d6d16348768) TaleWorlds.Engine.WeakGameEntity.GetUpgradeLevelMaskCumulative | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#af750f9c2d569731e7dcab5125bbeada6)GetUpgradeLevelOfEntity()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.Engine.WeakGameEntity.GetUpgradeLevelOfEntity | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a1b4d68596b70a7e1327c31702a219796)GetOldPrefabName()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.Engine.WeakGameEntity.GetOldPrefabName | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a64dad0f75b11b678071622265d66301b)GetPrefabName()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.Engine.WeakGameEntity.GetPrefabName | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ad7be9fbd6046344ad937d69ca0f66e42)RefreshMeshesToRenderToHullWater()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.RefreshMeshesToRenderToHullWater | ( | UIntPtr | *visualRecord*, |
|  |  | string | *entityTag* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a13977d030f383564f8509244c726c632)DeRegisterWaterMeshMaterials()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.DeRegisterWaterMeshMaterials | ( | UIntPtr | *visualRecord* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a84a92209d59fb50be3a78d0101ad3afe)SetVisualRecordWakeParams()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetVisualRecordWakeParams | ( | UIntPtr | *visualRecord*, |
|  |  | [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) | *wakeParams* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a3effc436a3ab69446c377c1e03b5dceb)ChangeResolutionMultiplierOfWaterVisual()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.ChangeResolutionMultiplierOfWaterVisual | ( | UIntPtr | *visualRecord*, |
|  |  | float | *multiplier*, |
|  |  | in [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) | *waterEffectsBB* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ae23e233d299a35d435076b30255687d0)ResetHullWater()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.ResetHullWater | ( | UIntPtr | *visualRecord* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#addb31f2b3e8125ff2b17f3652f74b0fe)SetWaterVisualRecordFrameAndDt()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetWaterVisualRecordFrameAndDt | ( | UIntPtr | *visualRecord*, |
|  |  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame*, |
|  |  | float | *dt* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a1becbe45f4bf7c3d154baf18528b4138)AddSplashPositionToWaterVisualRecord()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.AddSplashPositionToWaterVisualRecord | ( | UIntPtr | *visualRecord*, |
|  |  | [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) | *position* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a9b8b7f995bd5654dbd8d1d5bf96ae179)UpdateHullWaterEffectFrames()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.UpdateHullWaterEffectFrames | ( | UIntPtr | *visualRecord* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#afa8b7cfe7b470e17638a4d9b2929b3be)CopyScriptComponentFromAnotherEntity()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.CopyScriptComponentFromAnotherEntity | ( | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *otherEntity*, |
|  |  | string | *scriptName* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#af9c0c48d6f10074a3e9c1cfdf9e14a7d)SetFrame()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetFrame | ( | ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame*, |
|  |  | bool | *isTeleportation* = true ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aabb7414decdfa6cc8806eacdd2815f51)SetLocalFrame()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetLocalFrame | ( | ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame*, |
|  |  | bool | *isTeleportation* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a95382e25c970fe0258bd37e11311dd30)SetClothComponentKeepState()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetClothComponentKeepState | ( | [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | *metaMesh*, |
|  |  | bool | *state* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a9bf2b2f667e3d2ccb400d0b502a75740)SetClothComponentKeepStateOfAllMeshes()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetClothComponentKeepStateOfAllMeshes | ( | bool | *state* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#adab4845045d8f152e9ee04682b220b39)SetPreviousFrameInvalid()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetPreviousFrameInvalid | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a97b715f56c0a3a18e00d4ce016198615)GetFrame()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.Engine.WeakGameEntity.GetFrame | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a651a9c5b51e443fa5869009349fdad93)GetLocalFrame() [1/2]
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.GetLocalFrame | ( | out [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef1195ee871853e31822ed615ad396b9)HasBatchedKinematicPhysicsFlag()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.WeakGameEntity.HasBatchedKinematicPhysicsFlag | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a73a1fa55bd11e0ae95141370580ce394)HasBatchedRayCastPhysicsFlag()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.WeakGameEntity.HasBatchedRayCastPhysicsFlag | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a5234ab0d85741131eeed5a33fd5c15b6)GetLocalFrame() [2/2]
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.Engine.WeakGameEntity.GetLocalFrame | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a104abc7d3cdcc4f271c19320e630c7c0)GetGlobalFrame()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.Engine.WeakGameEntity.GetGlobalFrame | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a5cde2c0d486f67c1cd5a14e2694b9d67)SetWaterSDFClipData()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetWaterSDFClipData | ( | int | *slotIndex*, |
|  |  | in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame*, |
|  |  | bool | *visibility* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aa181d790b83aeb23fe203f74a57924bd)RegisterWaterSDFClip()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.Engine.WeakGameEntity.RegisterWaterSDFClip | ( | [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) | *sdfTexture* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aa70b3042c30ded895c4c7c8b57ac5c11)DeRegisterWaterSDFClip()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.DeRegisterWaterSDFClip | ( | int | *slot* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aba1348819c16f68e3ae387ca8ed22003)GetGlobalFrameImpreciseForFixedTick()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.Engine.WeakGameEntity.GetGlobalFrameImpreciseForFixedTick | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a8a42d7a07b1cd1165771734b573529fe)ComputePreciseGlobalFrameForFixedTickSlow()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.Engine.WeakGameEntity.ComputePreciseGlobalFrameForFixedTickSlow | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a1c79cb6db05481dc67c0eb24b399f709)SetGlobalFrame()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetGlobalFrame | ( | in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame*, |
|  |  | bool | *isTeleportation* = true ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ac2d14f96dc0af7dc7814335308fb11c2)GetPreviousGlobalFrame()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.Engine.WeakGameEntity.GetPreviousGlobalFrame | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ac316680536403201eb3a96a7d8b99997)GetBodyWorldTransform()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.Engine.WeakGameEntity.GetBodyWorldTransform | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ab55417b61861f3f0277af46d84d3738c)GetBodyVisualWorldTransform()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.Engine.WeakGameEntity.GetBodyVisualWorldTransform | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a17a8170d997aaae6245788313d5533e6)UpdateTriadFrameForEditor()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.UpdateTriadFrameForEditor | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ac053507a801cacde783a50284cb8bb4c)UpdateTriadFrameForEditorForAllChildren()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.UpdateTriadFrameForEditorForAllChildren | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aed47a601be90b54cbe1a1f15c75d72cf)GetGlobalScale()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) TaleWorlds.Engine.WeakGameEntity.GetGlobalScale | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a5e293d2265dea9f3ecf9dc8835a2f076)GetLocalScale()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) TaleWorlds.Engine.WeakGameEntity.GetLocalScale | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ac3ee1fc165ed32359637bbdadb23086c)SetAnimationSoundActivation()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetAnimationSoundActivation | ( | bool | *activate* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aad4fb00827c97c01346b6e456769af53)CopyComponentsToSkeleton()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.CopyComponentsToSkeleton | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aff5a131d6e1b81355f07f90598309756)AddMeshToBone()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.AddMeshToBone | ( | sbyte | *boneIndex*, |
|  |  | [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) | *mesh* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a6857faa0a2472959b2217931ba90e7f9)ActivateRagdoll()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.ActivateRagdoll | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a29877295d7a92fb95cf9d520e53ec16a)PauseSkeletonAnimation()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.PauseSkeletonAnimation | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a72ea83794ab1950abc0df334783322eb)ResumeSkeletonAnimation()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.ResumeSkeletonAnimation | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a4b51704d53796c3a55d6249ffbed8a91)IsSkeletonAnimationPaused()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.WeakGameEntity.IsSkeletonAnimationPaused | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a877bd5ac429cf5e9e651641deecaaec9)GetBoneCount()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| sbyte TaleWorlds.Engine.WeakGameEntity.GetBoneCount | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#af68f3873cda7cc25291b32936b937f0b)GetWaterLevelAtPosition()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.Engine.WeakGameEntity.GetWaterLevelAtPosition | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position*, |
|  |  | bool | *useWaterRenderer*, |
|  |  | bool | *checkWaterBodyEntities* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a535a5a55d11f33465820c884fa34508d)GetBoneEntitialFrameWithIndex()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.Engine.WeakGameEntity.GetBoneEntitialFrameWithIndex | ( | sbyte | *boneIndex* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#af80464a0b5bdb60a253f8f63c347c07a)GetBoneEntitialFrameWithName()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.Engine.WeakGameEntity.GetBoneEntitialFrameWithName | ( | string | *boneName* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ae12bae9724a72dfc088228d92fb63c83)AddTag()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.AddTag | ( | string | *tag* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a372164ac5320e1e96502e809512e35f6)RemoveTag()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.RemoveTag | ( | string | *tag* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ab58271b2c309c5f3f41e2e3d569a3b1f)HasTag()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.WeakGameEntity.HasTag | ( | string | *tag* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ac2a90bb5279e05401ac193b9207c76d0)AddChild()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.AddChild | ( | WeakGameEntity | *gameEntity*, |
|  |  | bool | *autoLocalizeFrame* = false ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a94ee5c5f6bf83b9e3532a07f33f76493)RemoveChild()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.RemoveChild | ( | WeakGameEntity | *childEntity*, |
|  |  | bool | *keepPhysics*, |
|  |  | bool | *keepScenePointer*, |
|  |  | bool | *callScriptCallbacks*, |
|  |  | int | *removeReason* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a120372a4a916813d070b143e17bb1a88)BreakPrefab()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.BreakPrefab | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#acf584a3019e60e844de8df7fca30621b)GetChild()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| WeakGameEntity TaleWorlds.Engine.WeakGameEntity.GetChild | ( | int | *index* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a7afff22b33cb6df0c68fe9b21749bee3)HasComplexAnimTree()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.WeakGameEntity.HasComplexAnimTree | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a31cb74dff1da3fe4313423d87d467a68)AddMultiMesh()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.AddMultiMesh | ( | [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | *metaMesh*, |
|  |  | bool | *updateVisMask* = true ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a3c68cfa3a1b1d86f7fd51712e990d6d6)RemoveMultiMesh()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.WeakGameEntity.RemoveMultiMesh | ( | [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | *metaMesh* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a41cb9bd241c84017ed739b735faa6c49)GetComponentCount()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.Engine.WeakGameEntity.GetComponentCount | ( | [GameEntity.ComponentType](class_tale_worlds_1_1_engine_1_1_game_entity.html#ac6f57c8912eaaf5a59c14ec2f153350b) | *componentType* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aae608e73e2eff7546413856f32d8a0d8)AddAllMeshesOfGameEntity()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.AddAllMeshesOfGameEntity | ( | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a83695d47becda8d7d78bdb9b508f731a)SetFrameChanged()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetFrameChanged | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a7100b74525b8a90518b9bd0f5b595f19)GetComponentAtIndex()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [GameEntityComponent](class_tale_worlds_1_1_engine_1_1_game_entity_component.html) TaleWorlds.Engine.WeakGameEntity.GetComponentAtIndex | ( | int | *index*, |
|  |  | [GameEntity.ComponentType](class_tale_worlds_1_1_engine_1_1_game_entity.html#ac6f57c8912eaaf5a59c14ec2f153350b) | *componentType* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a70dd627b6143ddff33fa9862d63af1c8)GetMetaMesh()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) TaleWorlds.Engine.WeakGameEntity.GetMetaMesh | ( | int | *metaMeshIndex* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a92ff87be9b778ccd40ed8e2114284dca)GetClothSimulator()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [ClothSimulatorComponent](class_tale_worlds_1_1_engine_1_1_cloth_simulator_component.html) TaleWorlds.Engine.WeakGameEntity.GetClothSimulator | ( | int | *clothSimulatorIndex* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a893db5bfb352b535f2922ec2c7f2a6f8)SetVectorArgument()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetVectorArgument | ( | float | *vectorArgument0*, |
|  |  | float | *vectorArgument1*, |
|  |  | float | *vectorArgument2*, |
|  |  | float | *vectorArgument3* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a51695f7c1ea206b28d53531fe9247f0f)SetMaterialForAllMeshes()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetMaterialForAllMeshes | ( | [Material](class_tale_worlds_1_1_engine_1_1_material.html) | *material* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aeb03ca93bc716bef9b485cf743714de7)AddLight()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.WeakGameEntity.AddLight | ( | [Light](class_tale_worlds_1_1_engine_1_1_light.html) | *light* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ac7c4371ef32c1510dc670424aeee875e)GetLight()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Light](class_tale_worlds_1_1_engine_1_1_light.html) TaleWorlds.Engine.WeakGameEntity.GetLight | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a3ac26ff2c7edf382750fb19a6588057e)AddParticleSystemComponent()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.AddParticleSystemComponent | ( | string | *particleid* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#af9ee7a445e78ecfa0d62ff51a5151e50)RemoveAllParticleSystems()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.RemoveAllParticleSystems | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a51c9c5e0297be966fac060e79aacd710)CheckPointWithOrientedBoundingBox()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.WeakGameEntity.CheckPointWithOrientedBoundingBox | ( | [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) | *point* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a29b6f3eb6df594fca140fafbe2ac46d2)PauseParticleSystem()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.PauseParticleSystem | ( | bool | *doChildren* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a1cf03535210707689fd53cec618e2270)ResumeParticleSystem()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.ResumeParticleSystem | ( | bool | *doChildren* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a04b443313870cfadb3eff867959ac0bf)BurstEntityParticle()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.BurstEntityParticle | ( | bool | *doChildren* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aaf6f31fcbd26edec1a4102baaa8a5804)SetRuntimeEmissionRateMultiplier()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetRuntimeEmissionRateMultiplier | ( | float | *emissionRateMultiplier* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a4066c26603f14331a73e6b8e4bf8c415)GetLocalBoundingBox()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [BoundingBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html) TaleWorlds.Engine.WeakGameEntity.GetLocalBoundingBox | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a90f171a910b9d0f6bcb6ac024d4d5214)GetGlobalBoundingBox()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [BoundingBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html) TaleWorlds.Engine.WeakGameEntity.GetGlobalBoundingBox | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a30d50e65f82da10a81f808404022af2d)GetBoundingBoxMin()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) TaleWorlds.Engine.WeakGameEntity.GetBoundingBoxMin | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ab1a5c6771e5fb6ec128d825499814649)SetHasCustomBoundingBoxValidationSystem()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetHasCustomBoundingBoxValidationSystem | ( | bool | *hasCustomBoundingBox* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a8bb95d7147b0d3c5f94b282b16e35c78)ValidateBoundingBox()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.ValidateBoundingBox | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ab87887f2d90bf4386c34dc43b8d35a7e)GetBoundingBoxMax()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) TaleWorlds.Engine.WeakGameEntity.GetBoundingBoxMax | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ac2e54a532e4fbf4c5cfa8b37472581db)UpdateGlobalBounds()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.UpdateGlobalBounds | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a4c662c851cdd6c09bdb7de02e2526822)RecomputeBoundingBox()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.RecomputeBoundingBox | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a2fa5260c67311446f89fa00d54cd69fd)GetBoundingBoxRadius()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Engine.WeakGameEntity.GetBoundingBoxRadius | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a0725e43f2611e5f78db77748f6921c75)SetBoundingboxDirty()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetBoundingboxDirty | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ae2bb76de7e44a405248c1cf20c560cce)ComputeGlobalPhysicsBoundingBoxMinMax()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) TaleWorlds.Engine.WeakGameEntity.ComputeGlobalPhysicsBoundingBoxMinMax | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a083e3dd76b4d0da400be5c402d23699e)ComputeGlobalPhysicsBoundingBoxCenter()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) TaleWorlds.Engine.WeakGameEntity.ComputeGlobalPhysicsBoundingBoxCenter | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a1ca08f290f742a5f7b3384d7db64c692)SetContourColor()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetContourColor | ( | uint? | *color*, |
|  |  | bool | *alwaysVisible* = true ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a703e710a3bb72a1ceb20bb9d04aeb50e)GetHasFrameChanged()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.WeakGameEntity.GetHasFrameChanged | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#af4104387783383785ba439f20ae12bc7)GetFirstMesh()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) TaleWorlds.Engine.WeakGameEntity.GetFirstMesh | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a84523c2b5af0d463d6ae9214911c4a6a)GetAttachedNavmeshFaceCount()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.Engine.WeakGameEntity.GetAttachedNavmeshFaceCount | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a134f3974928deed46fb6e697fa9b93fe)GetAttachedNavmeshFaceRecords()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.GetAttachedNavmeshFaceRecords | ( | [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html)[] | *faceRecords* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a07cf6b22a2586bbe47775cfc29700c0a)GetAttachedNavmeshFaceVertexIndices()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.GetAttachedNavmeshFaceVertexIndices | ( | in [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | *faceRecord*, |
|  |  | int[] | *indices* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a9ee85fa1f76d0eda214c5135fb3f5b2d)SetCustomVertexPositionEnabled()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetCustomVertexPositionEnabled | ( | bool | *customVertexPositionEnabled* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a1d8284c6b7ebc48c769f040768d9f6c7)SetPositionsForAttachedNavmeshVertices()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetPositionsForAttachedNavmeshVertices | ( | int[] | *vertices*, |
|  |  | int | *indexCount*, |
|  |  | [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e)[] | *positions* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a149d1770de98c8a79643f34440efcd69)SetCostAdderForAttachedFaces()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetCostAdderForAttachedFaces | ( | float | *costs* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a03607aac183116a5cc5d8979560d8d79)SetExternalReferencesUsage()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetExternalReferencesUsage | ( | bool | *value* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a21d994094926951da369eac87e5c863b)SetMorphFrameOfComponents()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetMorphFrameOfComponents | ( | float | *value* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a34f55ceb9668e8cc60c04001c32f7831)AddEditDataUserToAllMeshes()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.AddEditDataUserToAllMeshes | ( | bool | *entityComponents*, |
|  |  | bool | *skeletonComponents* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ac6e201a4274435f14813aa58670b3ada)ReleaseEditDataUserToAllMeshes()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.ReleaseEditDataUserToAllMeshes | ( | bool | *entityComponents*, |
|  |  | bool | *skeletonComponents* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a8116a7084338911e48b65ddd5c4d8e5e)GetCameraParamsFromCameraScript()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.GetCameraParamsFromCameraScript | ( | [Camera](class_tale_worlds_1_1_engine_1_1_camera.html) | *cam*, |
|  |  | ref [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) | *dofParams* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ac025b3a86e69283937a0736acfc73f1a)GetMeshBendedFrame()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.GetMeshBendedFrame | ( | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *worldSpacePosition*, |
|  |  | ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *output* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#af1f4f70fc25473c1a1e0b98ef14a4e28)ComputeTrajectoryVolume()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.ComputeTrajectoryVolume | ( | float | *missileSpeed*, |
|  |  | float | *verticalAngleMaxInDegrees*, |
|  |  | float | *verticalAngleMinInDegrees*, |
|  |  | float | *horizontalAngleRangeInDegrees*, |
|  |  | float | *airFrictionConstant* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a36a59c20071570018538cc4191cd5480)SetAnimTreeChannelParameterForceUpdate()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetAnimTreeChannelParameterForceUpdate | ( | float | *phase*, |
|  |  | int | *channelNo* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aa7003edb0e4d6bcedfa6edd359350cae)ChangeMetaMeshOrRemoveItIfNotExists()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.ChangeMetaMeshOrRemoveItIfNotExists | ( | [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | *entityMetaMesh*, |
|  |  | [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | *newMetaMesh* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a5fb2078b0950a0a746e476f98d73f6f1)SetUpdateValidtyOnFrameChangedOfFacesWithId()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetUpdateValidtyOnFrameChangedOfFacesWithId | ( | int | *faceGroupId*, |
|  |  | bool | *updateValidity* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a25ad67c1aaf68b086271ca1b3af15511)AttachNavigationMeshFaces()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.AttachNavigationMeshFaces | ( | int | *faceGroupId*, |
|  |  | bool | *isConnected*, |
|  |  | bool | *isBlocker* = false, |
|  |  | bool | *autoLocalize* = false, |
|  |  | bool | *finalizeBlockerConvexHullComputation* = false, |
|  |  | bool | *updateEntityFrame* = true ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#abd680d13dabed8ac8d31dfe3d960f888)DetachAllAttachedNavigationMeshFaces()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.DetachAllAttachedNavigationMeshFaces | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a98605ba80773cee262c1a8df39c3991e)UpdateAttachedNavigationMeshFaces()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.UpdateAttachedNavigationMeshFaces | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#af36fd42a8ac4b43bb0d53b8cb49fafe6)RemoveSkeleton()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.RemoveSkeleton | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aae5d201fce712e82937efffd69330f10)RemoveAllChildren()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.RemoveAllChildren | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aa749edeffae78bfde2760a86a8e0848e)GetChildren()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< WeakGameEntity > TaleWorlds.Engine.WeakGameEntity.GetChildren | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a769179e297f8f7711e8e08772c704ba6)GetEntityAndChildren()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< WeakGameEntity > TaleWorlds.Engine.WeakGameEntity.GetEntityAndChildren | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a31174107843c7650ba6c12d487c4372a)GetChildrenRecursive()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.GetChildrenRecursive | ( | ref List< WeakGameEntity > | *children* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ae7b6ae471a8fdcff594ad7ffab2b3661)GetChildrenWithTagRecursive()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.GetChildrenWithTagRecursive | ( | List< WeakGameEntity > | *children*, |
|  |  | string | *tag* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#abfe75ab41ff25b623ad447bcbf794fbf)IsSelectedOnEditor()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.WeakGameEntity.IsSelectedOnEditor | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ab62829af6988dc0c4f6ce9ea0a0e1fc1)SelectEntityOnEditor()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SelectEntityOnEditor | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a53346ea2d4d5de0aceed4a433940e876)DeselectEntityOnEditor()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.DeselectEntityOnEditor | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ac6ed61ca27241921f58b5e464ffdb356)SetAsPredisplayEntity()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetAsPredisplayEntity | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a5c9618d8a8aa3936b1054b69cc26c774)RemoveFromPredisplayEntity()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.RemoveFromPredisplayEntity | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a78ff4d94979b4e14336b776b3efd5c20)SetNativeScriptComponentVariable()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetNativeScriptComponentVariable | ( | string | *className*, |
|  |  | string | *fieldName*, |
|  |  | ref [ScriptComponentFieldHolder](struct_tale_worlds_1_1_engine_1_1_script_component_field_holder.html) | *data*, |
|  |  | [RglScriptFieldType](namespace_tale_worlds_1_1_engine.html#adf2b4fe3d75a4a2c03eaf8620c096933) | *variableType* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a760b1d8fc07628dec2e9b64115cd0899)SetManualGlobalBoundingBox()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetManualGlobalBoundingBox | ( | [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) | *boundingBoxStartGlobal*, |
|  |  | [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) | *boundingBoxEndGlobal* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a7daa84a67cb755c53c33923439468029)RayHitEntityWithNormal()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Engine.WeakGameEntity.RayHitEntityWithNormal | ( | [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) | *rayOrigin*, |
|  |  | [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) | *rayDirection*, |
|  |  | float | *maxLength*, |
|  |  | ref [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) | *resultNormal*, |
|  |  | ref float | *resultLength* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ad7016da8b129a86eb355e70ba6d93046)RayHitEntity()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Engine.WeakGameEntity.RayHitEntity | ( | [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) | *rayOrigin*, |
|  |  | [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) | *rayDirection*, |
|  |  | float | *maxLength*, |
|  |  | ref float | *resultLength* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a683d55a536733e1dbddbda675e9f01f1)GetNativeScriptComponentVariable()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.GetNativeScriptComponentVariable | ( | string | *className*, |
|  |  | string | *fieldName*, |
|  |  | ref [ScriptComponentFieldHolder](struct_tale_worlds_1_1_engine_1_1_script_component_field_holder.html) | *data*, |
|  |  | [RglScriptFieldType](namespace_tale_worlds_1_1_engine.html#adf2b4fe3d75a4a2c03eaf8620c096933) | *variableType* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a4515ba97989530812a1de7b4b3aa658e)SetCustomClipPlane()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetCustomClipPlane | ( | [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) | *clipPosition*, |
|  |  | [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) | *clipNormal*, |
|  |  | bool | *setForChildren* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a6bf4a93fd6b4aac25683174e5d37c25b)GetBoundingBoxLongestHalfDimension()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Engine.WeakGameEntity.GetBoundingBoxLongestHalfDimension | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aeb42497860ea66d3b900305289a45dd3)ComputeBoundingBoxFromLongestHalfDimension()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [BoundingBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html) TaleWorlds.Engine.WeakGameEntity.ComputeBoundingBoxFromLongestHalfDimension | ( | float | *longestHalfDimensionCoefficient* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a71df47b2dd743c7b729f4271e698107a)ComputeBoundingBoxIncludeChildren()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [BoundingBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html) TaleWorlds.Engine.WeakGameEntity.ComputeBoundingBoxIncludeChildren | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#adc3d7a9caa1a972bace69b2d493cf6c1)SetManualLocalBoundingBox()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetManualLocalBoundingBox | ( | in [BoundingBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html) | *boundingBox* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a20739aff98c2f0ba55e096484ba26f25)RelaxLocalBoundingBox()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.RelaxLocalBoundingBox | ( | in [BoundingBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html) | *boundingBox* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a4ed581ab942d907fbf67ccae3fe8023a)SetCullMode()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetCullMode | ( | [MBMeshCullingMode](namespace_tale_worlds_1_1_engine.html#a8363ee42e6331c6a31ed88216accec29) | *cullMode* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a0dab051cadaf0685f997386dbbb6092e)GetFirstChildEntityWithTagRecursive()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| WeakGameEntity TaleWorlds.Engine.WeakGameEntity.GetFirstChildEntityWithTagRecursive | ( | string | *tag* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a1e25f0115b9c2808eead5b89b608dbaf)Equals()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.Engine.WeakGameEntity.Equals | ( | object | *obj* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a7f2c84e8f9a96b8bbef86f4a1917e66d)GetHashCode()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.Engine.WeakGameEntity.GetHashCode | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#abd20d8810a33fe9a8b2340533ce33605)operator==() [1/2]
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Engine.WeakGameEntity.operator== | ( | WeakGameEntity | *weakGameEntity*, | |  |  | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *entity* ) | | static |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a914f0bd5878f658a6004e2cd02d96468)operator!=() [1/2]
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Engine.WeakGameEntity.operator!= | ( | WeakGameEntity | *weakGameEntity*, | |  |  | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *entity* ) | | static |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a75717fbde02d5f677d88ba94baeda8ce)operator==() [2/2]
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Engine.WeakGameEntity.operator== | ( | WeakGameEntity | *weakGameEntity1*, | |  |  | WeakGameEntity | *weakGameEntity2* ) | | static |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aa4c6f89d67b263512bea2a0f3909f011)operator!=() [2/2]
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Engine.WeakGameEntity.operator!= | ( | WeakGameEntity | *weakGameEntity1*, | |  |  | WeakGameEntity | *weakGameEntity2* ) | | static |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ae663acc114dc8951df2ad25f5099c3b9)CollectChildrenEntitiesWithTag()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| List< WeakGameEntity > TaleWorlds.Engine.WeakGameEntity.CollectChildrenEntitiesWithTag | ( | string | *tag* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a46823156249ab501b389a65ddeb925be)CollectChildrenEntitiesWithTagAsEnumarable()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| IEnumerable< WeakGameEntity > TaleWorlds.Engine.WeakGameEntity.CollectChildrenEntitiesWithTagAsEnumarable | ( | string | *tag* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a148bedef84757838e33de6e1886d54d2)SetDoNotCheckVisibility()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetDoNotCheckVisibility | ( | bool | *value* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ae3e5f8152461cf24867b9b25b4ee3b50)SetBoneFrameToAllMeshes()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetBoneFrameToAllMeshes | ( | int | *boneIndex*, |
|  |  | in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ab6a9e31b725d439566ed31987bdad482)GetGlobalWindStrengthVectorOfScene()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.Engine.WeakGameEntity.GetGlobalWindStrengthVectorOfScene | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aeef5c8b33fae2ff211217fd8bf5305bc)GetGlobalWindVelocityOfScene()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.Engine.WeakGameEntity.GetGlobalWindVelocityOfScene | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a870978157cf80b630412b41881164610)GetLastFinalRenderCameraPositionOfScene()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) TaleWorlds.Engine.WeakGameEntity.GetLastFinalRenderCameraPositionOfScene | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a4e6fc3f5cb8976d4cb1242d40fc41ee9)GetGlobalWindVelocityWithGustNoiseOfScene()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.Engine.WeakGameEntity.GetGlobalWindVelocityWithGustNoiseOfScene | ( | float | *globalTime* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a1d653dc2c6f46478b905434cac396005)SetForceDecalsToRender()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetForceDecalsToRender | ( | bool | *value* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a510d1caf32fbe2ec56c8e5c8277d6eb2)CreateEmptyPhysxShape()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| UIntPtr TaleWorlds.Engine.WeakGameEntity.CreateEmptyPhysxShape | ( | bool | *isVariable*, |
|  |  | int | *physxMaterialIndex* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#abad005833e778a45b125dee18a2733f8)SetForceNotAffectedBySeason()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakGameEntity.SetForceNotAffectedBySeason | ( | bool | *value* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ae944e44c0271e6ecd612caffa1f96a8e)CheckIsPrefabLinkRootPrefab()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.WeakGameEntity.CheckIsPrefabLinkRootPrefab | ( | int | *depth* | ) |  |

Member Data Documentation
-------------------------

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a17f94095d4589038ab51c92ee657eb99)Invalid
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly WeakGameEntity TaleWorlds.Engine.WeakGameEntity.Invalid = new WeakGameEntity(UIntPtr.Zero) | | static |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e)Vec3
--------------------------------------------------------------------------------------------------

|  |
| --- |
| TaleWorlds.Engine.WeakGameEntity.Vec3 |

Property Documentation
----------------------

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a9396e1a24b2c0308f5210e146295e256)Pointer
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | UIntPtr TaleWorlds.Engine.WeakGameEntity.Pointer | | get |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a2b040704f579d10dd2823fc01b3a5b19)IsValid
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Engine.WeakGameEntity.IsValid | | get |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a20a1883ba44a36f127479fb7dfde45c2)Name
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Engine.WeakGameEntity.Name | | get |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ab278f9d0be6def2080c32c429b97e5fe)Scene
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Scene TaleWorlds.Engine.WeakGameEntity.Scene | | get |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a007686f4d4cedf1c76bfa8cb71bb75c7)EntityFlags
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [EntityFlags](namespace_tale_worlds_1_1_engine.html#ac9a5b603c15afe87f8ec5f36d2e73285) TaleWorlds.Engine.WeakGameEntity.EntityFlags | | get |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aee5fa8196f75c09ce2a80fb11e81fca7)EntityVisibilityFlags
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [EntityVisibilityFlags](namespace_tale_worlds_1_1_engine.html#abd0987b9b449d071edb76504a2e737f8) TaleWorlds.Engine.WeakGameEntity.EntityVisibilityFlags | | get |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#afdaca67f82dd7e0313025c4ac0a90107)BodyFlag
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) TaleWorlds.Engine.WeakGameEntity.BodyFlag | | get |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#abcbba99ba8f224e81a209e65e038044b)PhysicsDescBodyFlag
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) TaleWorlds.Engine.WeakGameEntity.PhysicsDescBodyFlag | | get |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a6a134321fb7dcf628ec24e7fa2bae572)Mass
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Engine.WeakGameEntity.Mass | | get |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a94c60bb58fe545a63a855059bd24fc2d)CenterOfMass
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) TaleWorlds.Engine.WeakGameEntity.CenterOfMass | | get |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#af604f4aa7c9bd90276ddd92b12f7f1e4)GlobalPosition
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) TaleWorlds.Engine.WeakGameEntity.GlobalPosition | | get |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a399bf27db53a2151807bc299cab91a9f)Tags
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string [] TaleWorlds.Engine.WeakGameEntity.Tags | | get |

See also
:   [AddTag](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ae12bae9724a72dfc088228d92fb63c83), [HasTag](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#ab58271b2c309c5f3f41e2e3d569a3b1f)

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#afa172bdde33deee171eaf43fb754a6e3)ChildCount
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Engine.WeakGameEntity.ChildCount | | get |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aaa7af452d35452b39977335673612f80)Parent
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | WeakGameEntity TaleWorlds.Engine.WeakGameEntity.Parent | | get |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a6af5aabd7dea81c335deb7435e86ce6b)Root
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | WeakGameEntity TaleWorlds.Engine.WeakGameEntity.Root | | get |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aabf05d8e08e6678e32983c23075f01ea)MultiMeshComponentCount
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Engine.WeakGameEntity.MultiMeshComponentCount | | get |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a132b834d66772f594bc57723b9d8cbc5)ClothSimulatorComponentCount
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Engine.WeakGameEntity.ClothSimulatorComponentCount | | get |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a58674645fffa8375709c93b63cc040f6)GlobalBoxMax
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) TaleWorlds.Engine.WeakGameEntity.GlobalBoxMax | | get |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a76525e2a2541f3ace4e5c48e4adf9f50)GlobalBoxMin
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#aef24a3e5fc42c8f7c65fa9e6e740a41e) TaleWorlds.Engine.WeakGameEntity.GlobalBoxMin | | get |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html#a2e4594091eab738c65a434b6d1e9cc69)Skeleton
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Skeleton TaleWorlds.Engine.WeakGameEntity.Skeleton | | getset |

