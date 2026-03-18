--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html ---

TaleWorlds.MountAndBlade.MBAgentVisuals Class ReferencesealedInherits NativeObject.

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [Tick](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a0a12b6f13c9d1ee682bf039544712c95) (MBAgentVisuals parentAgentVisuals, float dt, bool entityMoving, float speed) |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetGlobalFrame](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#aecc1a9fc6009772e1a3c82d1d9b9690d) () |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetFrame](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a99b1367a085d31b9928ca53ba6004efe) () |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [GetEntity](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a7698f3d5d07441a39abcc5801ed83a54) () |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | [GetWeakEntity](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a6e9cae739e803fd7cd23652e64e88375) () |
| bool | [IsValid](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a197648f6aaf0183a469565638346cb90) () |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetGlobalStableEyePoint](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a0c357e753754505314561e251501b9dd) (bool isHumanoid) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetGlobalStableNeckPoint](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a2163c4a40a8ac9921209f6b08519b289) (bool isHumanoid) |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetBoneEntitialFrame](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a15ae0fb39da8d77acae8f024368172e1) (sbyte bone, bool useBoneMapping) |
| void | [SetAttachedPositionForMeshAfterAnimationPostIntegrate](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a41e8c4c690d0d182a5fc0c4b19cdd767) ([WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) ropeEntity, sbyte bone) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetCurrentHeadLookDirection](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a906a537216f9e89068c3105e81925fb9) () |
| [HumanWalkingMovementMode](namespace_tale_worlds_1_1_mount_and_blade.html#a3eaf3559cd0e59c9db2924e7b22d5046) | [GetMovementMode](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a08f4c317efd5d341526ba0e1aeb2244e) () |
| float | [GetVisualStrengthOfAgentVisual](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#af06ce270718c574337636c755d2bd6f1) (MBAgentVisuals targetAgentVisual, [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission, float ambientLightStrength, float sunMoonLightStrength, int agentIndexToIgnore) |
| [RagdollState](namespace_tale_worlds_1_1_engine.html#aa91e9ce98f5025cfa023318f053636ae) | [GetCurrentRagdollState](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a99c693371c4336b3cbf26d809c725944) () |
| sbyte | [GetRealBoneIndex](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a4ad91e53b4cba120dc3a07109acadaa9) ([HumanBone](namespace_tale_worlds_1_1_core.html#a47efca28876c843963d0ab7136b2bfb0) boneType) |
| [CompositeComponent](class_tale_worlds_1_1_engine_1_1_composite_component.html) | [AddPrefabToAgentVisualBoneByBoneType](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a8d36fd2e4307d7b90a76973ea65a2522) (string prefabName, [HumanBone](namespace_tale_worlds_1_1_core.html#a47efca28876c843963d0ab7136b2bfb0) boneType) |
| [CompositeComponent](class_tale_worlds_1_1_engine_1_1_composite_component.html) | [AddPrefabToAgentVisualBoneByRealBoneIndex](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a80f3bf61e7b03b7282d005da14fa15d3) (string prefabName, sbyte realBoneIndex) |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [GetAttachedWeaponEntity](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#af46a7fe3dcbab89fb448bd26765d98c3) (int attachedWeaponIndex) |
| void | [SetFrame](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#acd64762d793261928dbe29dfb1d0897c) (ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame) |
| void | [SetEntity](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#af5a1caa101afe6210078895115755626) ([GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) value) |
| [BoneBodyTypeData](struct_tale_worlds_1_1_mount_and_blade_1_1_bone_body_type_data.html) | [GetBoneTypeData](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#ac1f597333d929866ecb5b0f42b08cd82) (sbyte boneIndex) |
| [Skeleton](class_tale_worlds_1_1_engine_1_1_skeleton.html) | [GetSkeleton](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a2e5791b863cec008441021cb8e528175) () |
| void | [SetSkeleton](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#ac6fa02b538422eaa824f2c79f1b3c515) ([Skeleton](class_tale_worlds_1_1_engine_1_1_skeleton.html) newSkeleton) |
| void | [CreateParticleSystemAttachedToBone](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#ab076ccc8f95c0c8d160b32b4f06331fd) (string particleName, sbyte boneIndex, ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) boneLocalParticleFrame) |
| void | [CreateParticleSystemAttachedToBone](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a94fcce12d7de633e4fdb0dcb660aea74) (int runtimeParticleindex, sbyte boneIndex, ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) boneLocalParticleFrame) |
| void | [SetVisible](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a76809b3a8407a3bed03af0fa7c228248) (bool value) |
| bool | [GetVisible](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a3327a05d46334dd173006c39f2036af6) () |
| void | [AddChildEntity](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#ab468537d7c887c2d69c4600c90af840f) ([GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) entity) |
| void | [SetClothWindToWeaponAtIndex](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#ae3c02b6d34e86ffef2cc3f8def77785c) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) windVector, bool isLocal, [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) weaponIndex) |
| void | [RemoveChildEntity](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a0c24486a7f36335c52be7565b27160d2) ([GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) entity, int removeReason) |
| bool | [CheckResources](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#aada4632b67c4e796eb670a4a8169f5b7) (bool addToQueue) |
| void | [AddSkinMeshes](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a809f308e706e5f9c7470dbdceef45ac7) ([SkinGenerationParams](struct_tale_worlds_1_1_mount_and_blade_1_1_skin_generation_params.html) skinParams, [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) bodyProperties, bool useGPUMorph, bool useFaceCache) |
| void | [SetFaceGenerationParams](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#aa95f4d0138cc8063987117a202dbceb1) ([FaceGenerationParams](struct_tale_worlds_1_1_mount_and_blade_1_1_face_generation_params.html) faceGenerationParams) |
| void | [SetLodAtlasShadingIndex](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a168ee017a6595907349db22a530ecb04) (int index, bool useTeamColor, uint teamColor1, uint teamColor2) |
| void | [ClearVisualComponents](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#ab2b19883e2fb70d28e64954ea8c2b141) (bool removeSkeleton) |
| void | [LazyUpdateAgentRendererData](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a671a2010089cbae4310535f4fcc533b0) () |
| void | [AddMultiMesh](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a2e4bf5533bb349f1e2219494e033d7c0) ([MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) metaMesh, [BodyMeshTypes](namespace_tale_worlds_1_1_mount_and_blade.html#a00049fbdc83fd35c8e96379433ae1550) bodyMeshIndex) |
| void | [ApplySkeletonScale](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a06207b9fdad103e45e24e266669af44c) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) mountSitBoneScale, float mountRadiusAdder, sbyte[] boneIndices, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html)[] boneScales) |
| void | [UpdateSkeletonScale](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#ac395b7e87eaf6f23c014ad866ce39066) (int bodyDeformType) |
| void | [AddHorseReinsClothMesh](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a73e6efbd85408cdc2264ff02b0ea8b0d) ([MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) reinMesh, [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) ropeMesh) |
| void | [BatchLastLodMeshes](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a51086b2355be0dc6dafad6083d6c9ab1) () |
| void | [AddWeaponToAgentEntity](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a60fd359618f16047b46d8ea154fb9994) (int slotIndex, in [WeaponData](struct_tale_worlds_1_1_mount_and_blade_1_1_weapon_data.html) weaponData, [WeaponStatsData](struct_tale_worlds_1_1_mount_and_blade_1_1_weapon_stats_data.html)[] weaponStatsData, in [WeaponData](struct_tale_worlds_1_1_mount_and_blade_1_1_weapon_data.html) ammoWeaponData, [WeaponStatsData](struct_tale_worlds_1_1_mount_and_blade_1_1_weapon_stats_data.html)[] ammoWeaponStatsData, [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) cachedEntity) |
| void | [UpdateQuiverMeshesWithoutAgent](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a8d882af4cd9e6a86d9633468ab6964ae) (int weaponIndex, int ammoCount) |
| void | [SetWieldedWeaponIndices](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a52a49673e1b74d0fef929c121bba48e5) (int slotIndexRightHand, int slotIndexLeftHand) |
| void | [ClearAllWeaponMeshes](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a0773fed92c1b2b1e30199a6dc9bccc70) () |
| void | [ClearWeaponMeshes](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a7cdaf0e7dc4a9fc23b5d69479160d1ce) ([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) index) |
| void | [MakeVoice](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#ae456061849b2e685269b7eba6ddf194a) (int voiceId, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position) |
| void | [SetSetupMorphNode](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a1bb10560887e0aa34ce2d58463bfb63d) (bool value) |
| void | [UseScaledWeapons](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#af539a70a16f644bc4870127e1b4df1de) (bool value) |
| void | [SetClothComponentKeepStateOfAllMeshes](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a4ef740605649af0ef57bf8d535e20f06) (bool keepState) |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetFacegenScalingMatrix](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a9a2b4e56cc1c34679b4e60efe27d4ddc) () |
| void | [ReplaceMeshWithMesh](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a21355228ebf6f21549a08c94ccac604b) ([MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) oldMetaMesh, [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) newMetaMesh, [BodyMeshTypes](namespace_tale_worlds_1_1_mount_and_blade.html#a00049fbdc83fd35c8e96379433ae1550) bodyMeshIndex) |
| void | [SetAgentActionChannel](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a9cb5dd50d6d70bc3061e3dc29ec128f7) (int actionChannelNo, int actionIndex, float channelParameter=0.0f, float blendPeriodOverride=-0.2f, bool forceFaceMorphRestart=true, float blendWithNextActionFactor=0.0f) |
| void | [SetVoiceDefinitionIndex](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a3e8fe27ed26dfd6d8cffb3d39846ed2f) (int voiceDefinitionIndex, float voicePitch) |
| void | [StartRhubarbRecord](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#aa4a5b58e0a6097838a974e32a36e0d32) (string path, int soundId) |
|  | Works only for humanoid animation systems. |
| void | [SetContourColor](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#ad671f60b9e92f1308f8fd55d3888ea0d) (uint? color, bool alwaysVisible=true) |
| void | [SetEnableOcclusionCulling](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a78d285f27f6c150f30182f6a3991b874) (bool enable) |
| void | [SetAgentLodZeroOrMax](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a6c82af83b906f7a419e2fb8f83b98af4) (bool makeZero) |
| void | [SetAgentLocalSpeed](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a0903dd598f2ebc3298385bc4225cbb24) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) speed) |
| void | [SetLookDirection](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a1ea3c864eb3c880ae9ff75c3d4fea491) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) direction) |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetBoneEntitialFrameAtAnimationProgress](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#aa5b69682f49755905ed564e111a44485) (sbyte boneIndex, int animationIndex, float progress) |
| void | [Reset](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a3482b63fb5ca584c0f87db5a39ee525e) () |
| void | [ResetNextFrame](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a2addde0719d7b11965cb6879a6394414) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static MBAgentVisuals | [CreateAgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#ac45d88e434a01d125f6ff2a3e6030695) ([Scene](class_tale_worlds_1_1_engine_1_1_scene.html) scene, string ownerName, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) eyeOffset) |
| static void | [FillEntityWithBodyMeshesWithoutAgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a05d81aa3f0a8e695f956314b7a80a236) ([GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) entity, [SkinGenerationParams](struct_tale_worlds_1_1_mount_and_blade_1_1_skin_generation_params.html) skinParams, [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) bodyProperties, [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) glovesMesh) |
| static [BodyMeshTypes](namespace_tale_worlds_1_1_mount_and_blade.html#a00049fbdc83fd35c8e96379433ae1550) | [GetBodyMeshIndex](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#acfc95e140d3ee2c31b4b63bf2608b7e9) ([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) equipmentIndex) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#ac45d88e434a01d125f6ff2a3e6030695)CreateAgentVisuals()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | MBAgentVisuals TaleWorlds.MountAndBlade.MBAgentVisuals.CreateAgentVisuals | ( | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *scene*, | |  |  | string | *ownerName*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *eyeOffset* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a0a12b6f13c9d1ee682bf039544712c95)Tick()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBAgentVisuals.Tick | ( | MBAgentVisuals | *parentAgentVisuals*, |
|  |  | float | *dt*, |
|  |  | bool | *entityMoving*, |
|  |  | float | *speed* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#aecc1a9fc6009772e1a3c82d1d9b9690d)GetGlobalFrame()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.MBAgentVisuals.GetGlobalFrame | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a99b1367a085d31b9928ca53ba6004efe)GetFrame()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.MBAgentVisuals.GetFrame | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a7698f3d5d07441a39abcc5801ed83a54)GetEntity()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) TaleWorlds.MountAndBlade.MBAgentVisuals.GetEntity | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a6e9cae739e803fd7cd23652e64e88375)GetWeakEntity()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) TaleWorlds.MountAndBlade.MBAgentVisuals.GetWeakEntity | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a197648f6aaf0183a469565638346cb90)IsValid()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MBAgentVisuals.IsValid | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a0c357e753754505314561e251501b9dd)GetGlobalStableEyePoint()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.MBAgentVisuals.GetGlobalStableEyePoint | ( | bool | *isHumanoid* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a2163c4a40a8ac9921209f6b08519b289)GetGlobalStableNeckPoint()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.MBAgentVisuals.GetGlobalStableNeckPoint | ( | bool | *isHumanoid* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a15ae0fb39da8d77acae8f024368172e1)GetBoneEntitialFrame()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.MBAgentVisuals.GetBoneEntitialFrame | ( | sbyte | *bone*, |
|  |  | bool | *useBoneMapping* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a41e8c4c690d0d182a5fc0c4b19cdd767)SetAttachedPositionForMeshAfterAnimationPostIntegrate()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBAgentVisuals.SetAttachedPositionForMeshAfterAnimationPostIntegrate | ( | [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *ropeEntity*, |
|  |  | sbyte | *bone* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a906a537216f9e89068c3105e81925fb9)GetCurrentHeadLookDirection()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.MBAgentVisuals.GetCurrentHeadLookDirection | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a08f4c317efd5d341526ba0e1aeb2244e)GetMovementMode()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [HumanWalkingMovementMode](namespace_tale_worlds_1_1_mount_and_blade.html#a3eaf3559cd0e59c9db2924e7b22d5046) TaleWorlds.MountAndBlade.MBAgentVisuals.GetMovementMode | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#af06ce270718c574337636c755d2bd6f1)GetVisualStrengthOfAgentVisual()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.MBAgentVisuals.GetVisualStrengthOfAgentVisual | ( | MBAgentVisuals | *targetAgentVisual*, |
|  |  | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | *mission*, |
|  |  | float | *ambientLightStrength*, |
|  |  | float | *sunMoonLightStrength*, |
|  |  | int | *agentIndexToIgnore* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a99c693371c4336b3cbf26d809c725944)GetCurrentRagdollState()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [RagdollState](namespace_tale_worlds_1_1_engine.html#aa91e9ce98f5025cfa023318f053636ae) TaleWorlds.MountAndBlade.MBAgentVisuals.GetCurrentRagdollState | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a4ad91e53b4cba120dc3a07109acadaa9)GetRealBoneIndex()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| sbyte TaleWorlds.MountAndBlade.MBAgentVisuals.GetRealBoneIndex | ( | [HumanBone](namespace_tale_worlds_1_1_core.html#a47efca28876c843963d0ab7136b2bfb0) | *boneType* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a8d36fd2e4307d7b90a76973ea65a2522)AddPrefabToAgentVisualBoneByBoneType()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [CompositeComponent](class_tale_worlds_1_1_engine_1_1_composite_component.html) TaleWorlds.MountAndBlade.MBAgentVisuals.AddPrefabToAgentVisualBoneByBoneType | ( | string | *prefabName*, |
|  |  | [HumanBone](namespace_tale_worlds_1_1_core.html#a47efca28876c843963d0ab7136b2bfb0) | *boneType* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a80f3bf61e7b03b7282d005da14fa15d3)AddPrefabToAgentVisualBoneByRealBoneIndex()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [CompositeComponent](class_tale_worlds_1_1_engine_1_1_composite_component.html) TaleWorlds.MountAndBlade.MBAgentVisuals.AddPrefabToAgentVisualBoneByRealBoneIndex | ( | string | *prefabName*, |
|  |  | sbyte | *realBoneIndex* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#af46a7fe3dcbab89fb448bd26765d98c3)GetAttachedWeaponEntity()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) TaleWorlds.MountAndBlade.MBAgentVisuals.GetAttachedWeaponEntity | ( | int | *attachedWeaponIndex* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#acd64762d793261928dbe29dfb1d0897c)SetFrame()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBAgentVisuals.SetFrame | ( | ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#af5a1caa101afe6210078895115755626)SetEntity()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBAgentVisuals.SetEntity | ( | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *value* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a05d81aa3f0a8e695f956314b7a80a236)FillEntityWithBodyMeshesWithoutAgentVisuals()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBAgentVisuals.FillEntityWithBodyMeshesWithoutAgentVisuals | ( | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *entity*, | |  |  | [SkinGenerationParams](struct_tale_worlds_1_1_mount_and_blade_1_1_skin_generation_params.html) | *skinParams*, | |  |  | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *bodyProperties*, | |  |  | [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | *glovesMesh* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#ac1f597333d929866ecb5b0f42b08cd82)GetBoneTypeData()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [BoneBodyTypeData](struct_tale_worlds_1_1_mount_and_blade_1_1_bone_body_type_data.html) TaleWorlds.MountAndBlade.MBAgentVisuals.GetBoneTypeData | ( | sbyte | *boneIndex* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a2e5791b863cec008441021cb8e528175)GetSkeleton()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Skeleton](class_tale_worlds_1_1_engine_1_1_skeleton.html) TaleWorlds.MountAndBlade.MBAgentVisuals.GetSkeleton | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#ac6fa02b538422eaa824f2c79f1b3c515)SetSkeleton()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBAgentVisuals.SetSkeleton | ( | [Skeleton](class_tale_worlds_1_1_engine_1_1_skeleton.html) | *newSkeleton* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#ab076ccc8f95c0c8d160b32b4f06331fd)CreateParticleSystemAttachedToBone() [1/2]
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBAgentVisuals.CreateParticleSystemAttachedToBone | ( | string | *particleName*, |
|  |  | sbyte | *boneIndex*, |
|  |  | ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *boneLocalParticleFrame* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a94fcce12d7de633e4fdb0dcb660aea74)CreateParticleSystemAttachedToBone() [2/2]
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBAgentVisuals.CreateParticleSystemAttachedToBone | ( | int | *runtimeParticleindex*, |
|  |  | sbyte | *boneIndex*, |
|  |  | ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *boneLocalParticleFrame* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a76809b3a8407a3bed03af0fa7c228248)SetVisible()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBAgentVisuals.SetVisible | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a3327a05d46334dd173006c39f2036af6)GetVisible()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MBAgentVisuals.GetVisible | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#ab468537d7c887c2d69c4600c90af840f)AddChildEntity()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBAgentVisuals.AddChildEntity | ( | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *entity* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#ae3c02b6d34e86ffef2cc3f8def77785c)SetClothWindToWeaponAtIndex()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBAgentVisuals.SetClothWindToWeaponAtIndex | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *windVector*, |
|  |  | bool | *isLocal*, |
|  |  | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *weaponIndex* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a0c24486a7f36335c52be7565b27160d2)RemoveChildEntity()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBAgentVisuals.RemoveChildEntity | ( | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *entity*, |
|  |  | int | *removeReason* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#aada4632b67c4e796eb670a4a8169f5b7)CheckResources()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MBAgentVisuals.CheckResources | ( | bool | *addToQueue* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a809f308e706e5f9c7470dbdceef45ac7)AddSkinMeshes()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBAgentVisuals.AddSkinMeshes | ( | [SkinGenerationParams](struct_tale_worlds_1_1_mount_and_blade_1_1_skin_generation_params.html) | *skinParams*, |
|  |  | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *bodyProperties*, |
|  |  | bool | *useGPUMorph*, |
|  |  | bool | *useFaceCache* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#aa95f4d0138cc8063987117a202dbceb1)SetFaceGenerationParams()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBAgentVisuals.SetFaceGenerationParams | ( | [FaceGenerationParams](struct_tale_worlds_1_1_mount_and_blade_1_1_face_generation_params.html) | *faceGenerationParams* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a168ee017a6595907349db22a530ecb04)SetLodAtlasShadingIndex()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBAgentVisuals.SetLodAtlasShadingIndex | ( | int | *index*, |
|  |  | bool | *useTeamColor*, |
|  |  | uint | *teamColor1*, |
|  |  | uint | *teamColor2* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#ab2b19883e2fb70d28e64954ea8c2b141)ClearVisualComponents()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBAgentVisuals.ClearVisualComponents | ( | bool | *removeSkeleton* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a671a2010089cbae4310535f4fcc533b0)LazyUpdateAgentRendererData()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBAgentVisuals.LazyUpdateAgentRendererData | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a2e4bf5533bb349f1e2219494e033d7c0)AddMultiMesh()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBAgentVisuals.AddMultiMesh | ( | [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | *metaMesh*, |
|  |  | [BodyMeshTypes](namespace_tale_worlds_1_1_mount_and_blade.html#a00049fbdc83fd35c8e96379433ae1550) | *bodyMeshIndex* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a06207b9fdad103e45e24e266669af44c)ApplySkeletonScale()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBAgentVisuals.ApplySkeletonScale | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *mountSitBoneScale*, |
|  |  | float | *mountRadiusAdder*, |
|  |  | sbyte[] | *boneIndices*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html)[] | *boneScales* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#ac395b7e87eaf6f23c014ad866ce39066)UpdateSkeletonScale()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBAgentVisuals.UpdateSkeletonScale | ( | int | *bodyDeformType* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a73e6efbd85408cdc2264ff02b0ea8b0d)AddHorseReinsClothMesh()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBAgentVisuals.AddHorseReinsClothMesh | ( | [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | *reinMesh*, |
|  |  | [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | *ropeMesh* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a51086b2355be0dc6dafad6083d6c9ab1)BatchLastLodMeshes()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBAgentVisuals.BatchLastLodMeshes | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a60fd359618f16047b46d8ea154fb9994)AddWeaponToAgentEntity()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBAgentVisuals.AddWeaponToAgentEntity | ( | int | *slotIndex*, |
|  |  | in [WeaponData](struct_tale_worlds_1_1_mount_and_blade_1_1_weapon_data.html) | *weaponData*, |
|  |  | [WeaponStatsData](struct_tale_worlds_1_1_mount_and_blade_1_1_weapon_stats_data.html)[] | *weaponStatsData*, |
|  |  | in [WeaponData](struct_tale_worlds_1_1_mount_and_blade_1_1_weapon_data.html) | *ammoWeaponData*, |
|  |  | [WeaponStatsData](struct_tale_worlds_1_1_mount_and_blade_1_1_weapon_stats_data.html)[] | *ammoWeaponStatsData*, |
|  |  | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *cachedEntity* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a8d882af4cd9e6a86d9633468ab6964ae)UpdateQuiverMeshesWithoutAgent()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBAgentVisuals.UpdateQuiverMeshesWithoutAgent | ( | int | *weaponIndex*, |
|  |  | int | *ammoCount* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a52a49673e1b74d0fef929c121bba48e5)SetWieldedWeaponIndices()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBAgentVisuals.SetWieldedWeaponIndices | ( | int | *slotIndexRightHand*, |
|  |  | int | *slotIndexLeftHand* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a0773fed92c1b2b1e30199a6dc9bccc70)ClearAllWeaponMeshes()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBAgentVisuals.ClearAllWeaponMeshes | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a7cdaf0e7dc4a9fc23b5d69479160d1ce)ClearWeaponMeshes()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBAgentVisuals.ClearWeaponMeshes | ( | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *index* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#ae456061849b2e685269b7eba6ddf194a)MakeVoice()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBAgentVisuals.MakeVoice | ( | int | *voiceId*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a1bb10560887e0aa34ce2d58463bfb63d)SetSetupMorphNode()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBAgentVisuals.SetSetupMorphNode | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#af539a70a16f644bc4870127e1b4df1de)UseScaledWeapons()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBAgentVisuals.UseScaledWeapons | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a4ef740605649af0ef57bf8d535e20f06)SetClothComponentKeepStateOfAllMeshes()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBAgentVisuals.SetClothComponentKeepStateOfAllMeshes | ( | bool | *keepState* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a9a2b4e56cc1c34679b4e60efe27d4ddc)GetFacegenScalingMatrix()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.MBAgentVisuals.GetFacegenScalingMatrix | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a21355228ebf6f21549a08c94ccac604b)ReplaceMeshWithMesh()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBAgentVisuals.ReplaceMeshWithMesh | ( | [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | *oldMetaMesh*, |
|  |  | [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | *newMetaMesh*, |
|  |  | [BodyMeshTypes](namespace_tale_worlds_1_1_mount_and_blade.html#a00049fbdc83fd35c8e96379433ae1550) | *bodyMeshIndex* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a9cb5dd50d6d70bc3061e3dc29ec128f7)SetAgentActionChannel()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBAgentVisuals.SetAgentActionChannel | ( | int | *actionChannelNo*, |
|  |  | int | *actionIndex*, |
|  |  | float | *channelParameter* = 0::0f, |
|  |  | float | *blendPeriodOverride* = -0::2f, |
|  |  | bool | *forceFaceMorphRestart* = true, |
|  |  | float | *blendWithNextActionFactor* = 0::0f ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a3e8fe27ed26dfd6d8cffb3d39846ed2f)SetVoiceDefinitionIndex()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBAgentVisuals.SetVoiceDefinitionIndex | ( | int | *voiceDefinitionIndex*, |
|  |  | float | *voicePitch* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#aa4a5b58e0a6097838a974e32a36e0d32)StartRhubarbRecord()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBAgentVisuals.StartRhubarbRecord | ( | string | *path*, |
|  |  | int | *soundId* ) |

Parameters
:   |  |  |
    | --- | --- |
    | path |  |
    | soundId |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#ad671f60b9e92f1308f8fd55d3888ea0d)SetContourColor()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBAgentVisuals.SetContourColor | ( | uint? | *color*, |
|  |  | bool | *alwaysVisible* = true ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a78d285f27f6c150f30182f6a3991b874)SetEnableOcclusionCulling()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBAgentVisuals.SetEnableOcclusionCulling | ( | bool | *enable* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a6c82af83b906f7a419e2fb8f83b98af4)SetAgentLodZeroOrMax()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBAgentVisuals.SetAgentLodZeroOrMax | ( | bool | *makeZero* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | makeZero | If false agent lod will be set to max. |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a0903dd598f2ebc3298385bc4225cbb24)SetAgentLocalSpeed()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBAgentVisuals.SetAgentLocalSpeed | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *speed* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a1ea3c864eb3c880ae9ff75c3d4fea491)SetLookDirection()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBAgentVisuals.SetLookDirection | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *direction* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#acfc95e140d3ee2c31b4b63bf2608b7e9)GetBodyMeshIndex()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [BodyMeshTypes](namespace_tale_worlds_1_1_mount_and_blade.html#a00049fbdc83fd35c8e96379433ae1550) TaleWorlds.MountAndBlade.MBAgentVisuals.GetBodyMeshIndex | ( | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *equipmentIndex* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#aa5b69682f49755905ed564e111a44485)GetBoneEntitialFrameAtAnimationProgress()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.MBAgentVisuals.GetBoneEntitialFrameAtAnimationProgress | ( | sbyte | *boneIndex*, |
|  |  | int | *animationIndex*, |
|  |  | float | *progress* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a3482b63fb5ca584c0f87db5a39ee525e)Reset()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBAgentVisuals.Reset | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html#a2addde0719d7b11965cb6879a6394414)ResetNextFrame()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBAgentVisuals.ResetNextFrame | ( |  | ) |  |

