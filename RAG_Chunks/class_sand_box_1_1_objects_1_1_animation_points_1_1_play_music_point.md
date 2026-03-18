--- SOURCE: class_sand_box_1_1_objects_1_1_animation_points_1_1_play_music_point.html ---

SandBox.Objects.AnimationPoints.PlayMusicPoint Class ReferenceInherits [SandBox.Objects.AnimationPoints.AnimationPoint](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [StartLoop](class_sand_box_1_1_objects_1_1_animation_points_1_1_play_music_point.html#a0210e9b3baa9f328c5beb188e6c9a5f5) ([SoundEvent](class_tale_worlds_1_1_engine_1_1_sound_event.html) trackEvent) |
| void | [EndLoop](class_sand_box_1_1_objects_1_1_animation_points_1_1_play_music_point.html#ac41eaac5f74c93394d876c8ccd3183de) () |
| override [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) | [GetTickRequirement](class_sand_box_1_1_objects_1_1_animation_points_1_1_play_music_point.html#a545c8141118c9b3befb66234ed370464) () |
| override void | [OnUseStopped](class_sand_box_1_1_objects_1_1_animation_points_1_1_play_music_point.html#af9a95801c88a868e6cd12dc29489ab23) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) userAgent, bool isSuccessful, int preferenceIndex) |
| void | [ChangeInstrument](class_sand_box_1_1_objects_1_1_animation_points_1_1_play_music_point.html#a038617e15bb813dbdfc759f83ceeabaf) (Tuple< [InstrumentData](class_sand_box_1_1_objects_1_1_instrument_data.html), float > instrument) |
| Public Member Functions inherited from [SandBox.Objects.AnimationPoints.AnimationPoint](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html) | |
|  | [AnimationPoint](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#a3e11a9b324adf2e2aba352fbd2ae1a25) () |
| void | [RequestResync](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#a9ecf9f19dad3435749a6a595ef4c776e) () |
| override void | [AfterMissionStart](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#aded015ca936e0470df140b39681960b3) () |
| override bool | [IsDisabledForAgent](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#ad79a9ff66071be8dc341af46653960e1) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| override [WorldFrame](struct_tale_worlds_1_1_engine_1_1_world_frame.html) | [GetUserFrameForAgent](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#ab80de2c42c04271d729963dd6aee47dc) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| override bool | [IsUsableByAgent](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#a8a918c0eb2dc059b860eea516f9c9c98) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) userAgent) |
| override void | [OnUse](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#ab657dfa52fa5cb14e002d2ca11c9789c) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) userAgent, sbyte agentBoneIndex) |
| override void | [SimulateTick](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#a9dabf0f4062912017cba8f71fe631331) (float dt) |
| override bool | [HasAlternative](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#a2c46f58868bcfc01294b103003e1d3f3) () |
| float | [GetRandomWaitInSeconds](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#aab9b91d745dd98cd1523e9af8a159c7e) () |
| List< [AnimationPoint](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#a3e11a9b324adf2e2aba352fbd2ae1a25) > | [GetAlternatives](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#afe814ebc33179d8e8a2144ead0f88c9a) () |
| bool | [IsRotationCorrectDuringUsage](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#a27515b647208a0bb0076d4b0faf00515) () |
| override void | [OnUserConversationStart](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#a3538553af4e3a390478a03b2a748dd26) () |
| override void | [OnUserConversationEnd](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#ad3ba321e782daa342bf6f407ac5f70a5) () |
| void | [SetAgentItemsVisibility](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#a4e7c25c329cfe655cd38800a548dd601) (bool isVisible) |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) | |
| void | [OnParentMachinePhysicsStateChanged](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html#a5f16b503927f0667dccf80b5314f47c2) () |
| override bool | [IsDisabledForAgent](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html#a78c9cc408fa5dd7a21127a039278afdd) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| override [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) | [GetTickRequirement](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html#a5bd0e2de9121087ecee96972cb250e68) () |
| override void | [OnUse](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html#a36d4261a9e6ee9c9406a08b681cf7bf1) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) userAgent, sbyte agentBoneIndex) |
| override void | [OnUseStopped](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html#a96540fc09a482d0c3069ccc4948b472b) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) userAgent, bool isSuccessful, int preferenceIndex) |
| override [WorldFrame](struct_tale_worlds_1_1_engine_1_1_world_frame.html) | [GetUserFrameForAgent](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html#a44713f88cdea20a680ae2da538b3bead) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| virtual float | [GetUsageScoreForAgent](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html#aa195c606088373472826ff39e57ead80) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| virtual float | [GetUsageScoreForAgent](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html#acbbf5d81807fbc6193ebba38578322e9) (ValueTuple< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), float > agentPair) |
| void | [SetupOnUsingStoppedBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html#a36b874e3751b2c2ec452d066dfa44b74) (bool autoAttach, Action< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), bool > action) |
| override void | [OnEndMission](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html#a99bf2fcb5563e7f9ae0d1483d2cf712b) () |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetDescriptionText](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html#ae77c920ae1c4b73188884c59a6da0d03) ([WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity) |
| override bool | [IsUsableByAgent](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html#a2b86919b2cc69e57c22cb9052b6a00d8) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) userAgent) |
| void | [SetUsableByAIOnly](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html#a7cf1d75a93bd9283a292f1bcf6e099ac) () |
| void | [SetUsableByPlayerOnly](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html#ae3713a598674ad17ccad1c05caaf2c65) () |
| void | [SetUsableByPlayerOrAI](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html#a51bd904626c7f46cc99d79457c5bbfbc) () |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) | |
| void | [SetAreUserPositionsUpdatedInTheMachineTick](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#a48ec3eb5761cf11bd2337e1495baf85b) (bool value) |
| bool | [GetIsUserPositionsUpdatedInTheMachineTick](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#abd6c8a6e39273df491181810b4421851) () |
| void | [SetIsDeactivatedSynched](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#a32c42b162947e571c935da48e3e6f75b) (bool value) |
| void | [SetIsDisabledForPlayersSynched](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#aebee75d2837748125c616e32c14a0978) (bool value) |
| void | [AddComponent](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#a14331f48de3d8d0fe476a06764fcb9d4) ([UsableMissionObjectComponent](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object_component.html) component) |
| void | [RemoveComponent](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#a82fd50f8aa3f285f027b0bc736b38d18) ([UsableMissionObjectComponent](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object_component.html) component) |
| T | [GetComponent< T >](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#a0e00b124f3526e3086f5c58610b3570e) () |
| void | [RefreshGameEntityWithWorldPosition](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#ac9f2d0db83650415bc10fe3105cf9e37) () |
| virtual void | [OnFocusGain](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#aa15a812a0128b612164af424d85ea4e6) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) userAgent) |
| virtual void | [OnFocusLose](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#af997bed64c826467232fec994242a010) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) userAgent) |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetInfoTextForBeingNotInteractable](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#aab1cbfda24ec2b6849b953b8f29e9b6a) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) userAgent) |
| virtual void | [SetUserForClient](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#ad9689dcb9fda16874047b2fc702dd49a) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) userAgent) |
| virtual void | [OnAIMoveToUse](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#ab025e5ed073d184286a532c4ad9e47bf) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) userAgent, [IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html) detachment) |
| virtual void | [OnMoveToStopped](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#a7edcbd3ef673f10964397d80e139a764) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) movingAgent) |
| virtual int | [GetMovingAgentCount](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#a6e95d941e32269c20b8485333577bdee) () |
| virtual [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [GetMovingAgentWithIndex](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#a97c2330854c2742043450ba40c13da88) (int index) |
| virtual void | [RemoveMovingAgent](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#aa6af26485f891be8e7bfd8ac5203aaf9) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) movingAgent) |
| virtual void | [AddMovingAgent](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#a6a2301259e63ca336f34ceffc7c25b73) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) movingAgent) |
| void | [OnAIDefendBegin](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#ae4fbe04f2b9b4da50f057484d0f56767) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html) detachment) |
| void | [OnAIDefendEnd](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#a0b10405802a1e7f15661dc1507d1a60e) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| void | [InitializeDefendingAgents](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#a90848d52d05fd0f37193f5d71c62ab8a) () |
| int | [GetDefendingAgentCount](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#ab5f99e9003717da86c8fcf708071f673) () |
| void | [AddDefendingAgent](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#ae7744f10bb028943355a1da1a5a03dba) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| void | [RemoveDefendingAgent](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#ad10386226cd940baf08b5e82e82172ed) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| bool | [IsAgentDefending](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#a69b4c71076412556219527a19f8a13cc) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| override [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) | [GetTickRequirement](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#a76db9b9ea560768045354a9aa3075d4b) () |
| override string | [ToString](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#af118ce91b3f883c25d1e3c8efcea299f) () |
| virtual bool | [IsAIMovingTo](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#aee056dc2704af4b37cdbac82b5d68950) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| virtual bool | [HasUserPositionsChanged](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#a5b9c91c2049fef0b4040574db8eae91b) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| override void | [WriteToNetwork](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#a1572b85fb7a1ffcb2edda4f211e7c58d) () |
|  | Sends object's data to synchronize it to clients. |
| void | [SetCustomLocalFrame](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#a2841f40a0e26e9b774775bead13721b4) (in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) customLocalFrame) |
| override void | [OnEndMission](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#aceeacd54ae263afd796366d18e0b4f94) () |
| override void | [OnAfterReadFromNetwork](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#a5f30e6603f87731fe8a990af7152caa5) (([BaseSynchedMissionObjectReadableRecord](struct_tale_worlds_1_1_mount_and_blade_1_1_base_synched_mission_object_readable_record.html), [ISynchedMissionObjectReadableRecord](interface_tale_worlds_1_1_mount_and_blade_1_1_i_synched_mission_object_readable_record.html)) synchedMissionObjectReadableRecord, bool allowVisibilityUpdate=true) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetDescriptionText](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#aa227a955dcb577a5d59ae329ec0298db) ([WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity) |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html) | |
| void | [SetLocalPositionSmoothStep](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#ac3d9c08322fdc346100bca4e4762762b) (ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) targetPosition) |
| virtual void | [SetVisibleSynched](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#adfd7b558f73221bc0026ae3537f20f87) (bool value, bool forceChildrenVisible=false) |
| virtual void | [SetPhysicsStateSynched](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a4c5c4d8e7bfcf7c1060df3b71eb690b0) (bool value, bool setChildren=true) |
| virtual void | [SetDisabledSynched](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#ae09410bb02fc8fc88fc102e8be966e0a) () |
| void | [SetFrameSynched](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a007c85e9032d6abeae67664b7041aa3b) (ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame, bool isClient=false) |
| void | [SetGlobalFrameSynched](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a807953d5b1169590b4210911e44f7a72) (ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame, bool isClient=false) |
| void | [SetFrameSynchedOverTime](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a3329b617636e9f59126e646e53428ea7) (ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame, float duration, bool isClient=false) |
| void | [SetGlobalFrameSynchedOverTime](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a3b351de7c8809172349afdbdcb4816ec) (ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame, float duration, bool isClient=false) |
| void | [SetAnimationAtChannelSynched](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#aec216ecb7efe2ffb6c35ab8cbcb7145f) (string animationName, int channelNo, float animationSpeed=1.0f) |
| void | [SetAnimationAtChannelSynched](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a4a52e17030a4c85e0c227455992fd86b) (int animationIndex, int channelNo, float animationSpeed=1.0f) |
| void | [SetAnimationChannelParameterSynched](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a9346db672221f04ae2e302f127a8deb0) (int channelNo, float parameter) |
| void | [PauseSkeletonAnimationSynched](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a0bf8bc896100e854a4d0d2ec805925cd) () |
| void | [ResumeSkeletonAnimationSynched](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a039bcbc75df8020e8da1ffe72c763eeb) () |
| void | [BurstParticlesSynched](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a2aced2f1c98005c8c6417beced585997) (bool doChildren=true) |
| void | [ApplyImpulseSynched](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#acb2120f6447949d574486f92f0c9a055) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) localPosition, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) impulse) |
| void | [AddBodyFlagsSynched](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a7be570332d3835a27b36c512b7ec652e) ([BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) flags, bool applyToChildren=true) |
| void | [RemoveBodyFlagsSynched](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a3c28a2be85209207acd98fe70eea5dbb) ([BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) flags, bool applyToChildren=true) |
| void | [SetTeamColors](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a4e57328ba7581176377d8705804d0229) (uint color, uint color2) |
| virtual void | [SetTeamColorsSynched](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#aa12c5772def937a161a7859471ef4bae) (uint color, uint color2) |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | |
|  | [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a4eaa53f5b1c5e3af4d4189e099c8e05e) () |
| virtual void | [SetAbilityOfFaces](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#ad02ae6fa04bfdc79f9fcd010afbff84e) (bool enabled) |
| override int | [GetHashCode](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a41ecc2ecbc888f99ca3b942d63503381) () |
| virtual void | [OnMissionEnded](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#aa903cd7aefee1178f7e0700031f6cbd3) () |
| virtual void | [OnDeploymentFinished](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a4e4cad37fb9742ab43c03a1c897c2e69) () |
| void | [SetEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a71e0f9570275a903e70677f952e208df) (bool isParentObject=false) |
|  | Enables the mission object script and adds it to active mission objects. |
| void | [SetEnabledAndMakeVisible](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#ac49392483340a58efd0348abc690fbed) (bool isParentObject=false, bool enableFaces=false) |
|  | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) object is enabled and added to active mission objects list, its entity is made visible and therefore its physics is turned on. |
| void | [SetDisabled](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a628c7044cb17819d62166341a4153b55) (bool isParentObject=false) |
|  | Only disables the mission object script and removes it from active mission objects list but the object entity remains visible with active physics. |
| void | [SetDisabledAndMakeInvisible](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a617290738365d2ff7e1423b194d08d34) (bool isParentObject=false, bool disableFaces=false) |
|  | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) object is disabled and removed from active mission objects list, its entity is made invisible and therefore its physics is turned off. |
| virtual void | [AddStuckMissile](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a0173366e9a2f20a2b9bb83939c3f4d2d) ([GameEntity](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0a02cc65cc567db6101ea4afa275ff36) missileEntity) |
| Public Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [SetScriptComponentToTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ae15c963749bd0f9a75bba24a333b39d4) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) tickReq) |
| void | [SetScriptComponentToTickMT](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a9b2183852eb7b70042ed82ef917022c6) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) value) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnInit](class_sand_box_1_1_objects_1_1_animation_points_1_1_play_music_point.html#a346e55d043207a3061579877d7488b31) () |
|  | This callback method is called when the object is constructed. |
| override void | [OnTick](class_sand_box_1_1_objects_1_1_animation_points_1_1_play_music_point.html#a16c23aa88948b313f2d494f2425c58fb) (float dt) |
| Protected Member Functions inherited from [SandBox.Objects.AnimationPoints.AnimationPoint](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html) | |
| override void | [OnEditModeVisibilityChanged](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#abe191f63df9d0ad3bddb4e27775f7d85) (bool currentVisibility) |
| override void | [OnEditorTick](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#ac264e28b1e33e8c09094c525a5431abe) (float dt) |
| override void | [OnEditorInit](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#af92cb9431a772e8a896469ff0997f972) () |
| override void | [OnRemoved](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#a97811270bafddb849ab5df5a052d4c2a) (int removeReason) |
| void | [ResetAnimations](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#abc456eb704898246bfc3e6c0082c9a9c) () |
| override void | [OnEditorVariableChanged](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#aae5873b65cfb93ff4e1a87fc6f2bdea0) (string variableName) |
|  | Called when an object's field has changed from the editor. |
| virtual bool | [ShouldUpdateOnEditorVariableChanged](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#a7e9e995304178b18682dd0a9cf105712) (string variableName) |
| void | [ClearAssignedItems](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#a5b76ba0f2a4ce2717d9d452262a62df7) () |
| void | [AssignItemToBone](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#a2661a90e49ad4427130d88201c3b8be5) ([ItemForBone](struct_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point_1_1_item_for_bone.html) newItem) |
| virtual void | [SetActionCodes](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#af94cfc46f0da6511983895c20c0de786) () |
| override bool | [DoesActionTypeStopUsingGameObject](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#ac23bac312d6963e4d5d6b73f549c0258) (Agent.ActionCodeType actionType) |
| bool | [CanAgentUseItem](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#a5428b578e5784769f8773e31288e58f7) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| void | [AddItemsToAgent](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#a964911a854e0beb682874900f95a823c) () |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) | |
|  | [UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#a08b05664c7dc3d686eb93633c3c3a628) (bool isInstantUse=false) |
| virtual void | [CollectChildEntity](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#a54e849eab9bac1a98974178e885ea330) ([WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) childEntity) |
| virtual bool | [VerifyChildEntities](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#acc4cab70773b018522378ed0ea7ff5ee) (ref string errorMessage) |
| override void | [OnRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#a4f1f6f103fd69340341f510b1113b215) (int removeReason) |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | |
| virtual void | [AttachDynamicNavmeshToEntity](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a96b0e630894be6b18d6395ad12f811ac) () |
| virtual [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | [GetEntityToAttachNavMeshFaces](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a91b69e394d98f64d45604ee179496bb3) () |
| Protected Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [InvalidateWeakPointersIfValid](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#af39d73d0c78790ba81a40a5a350c0526) () |
|  | [ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0bc136bb53989f2b9a4f23f12f54a332) () |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Types inherited from [TaleWorlds.MountAndBlade.SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html) | |
| enum | [SynchFlags](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5ca) : uint {     [SynchNone](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5caa2da4e8e99f2913602376d36f8089a315) = 0x00000000 ,     [SynchTransform](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5caaa2b2f6339ae0b34de079c6d36495701a) = 0x00000001 ,     [SynchAnimation](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5caa896890ac2c4ab8db6aa3d8aa54201e2f) = 0x00000002 ,     [SynchBodyFlags](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5caabe8d4d441f6ffd28e6c51f8f3c7be862) = 0x00000004 ,     [SyncColors](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5caa10774fbeeb25df50516d9b754652622a) = 0x00000008 ,     [SynchAll](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a26da6a88ac107b001aafd7eca158a5caa86cdc154b35c72e83e8b91718295bd3a) = 0xffffffff   } |
| Public Types inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| enum | [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) : uint {     [None](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da6adf97f83acf6453d4a6a4b1070f3754) = 0x00000000 ,     [TickOccasionally](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da9cee052f50afabfc1098c1aa6af80b75) = 0x00000001 ,     [Tick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0b3516a5bbb77566f904f9d3877f4710) = 0x00000002 ,     [TickParallel](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da5f5a8f4b9ce783164665db4d70e03ee3) = 0x00000004 ,     [TickParallel2](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0ea9f0c260cdfd8b20ce19a48dbc329f) = 0x00000008 ,     [FixedTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154dadd067942f0b8cc66859698bc9711ba15) = 0x00000010 ,     [FixedParallelTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daa226d712a5ffd8d400f850393ff68492) = 0x00000020 ,     [TickParallel3](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daf785c2c005d708ea434168efc10611b8) = 0x00000040   } |
| Public Attributes inherited from [SandBox.Objects.AnimationPoints.AnimationPoint](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html) | |
| string | [ArriveAction](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#a92c3e7affd52950cdbcb6639e49d4dcd) = "" |
| string | [LoopStartAction](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#af8a3de58d41fa58640922a7544d2cb0d) = "" |
| string | [PairLoopStartAction](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#a3223c132b6029867c732de39ce63dea5) = "" |
| string | [LeaveAction](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#aeb8c0e6b17769347de4eceb11c9572c8) = "" |
| int | [GroupId](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#a6060ae72ee14511704b0be22745a200e) = -1 |
| string | [RightHandItem](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#a23d40f722b7992e8d43d6781cc678dbf) = "" |
| [HumanBone](namespace_tale_worlds_1_1_core.html#a47efca28876c843963d0ab7136b2bfb0) | [RightHandItemBone](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#a8c39298534085bd522c76024147373f1) = HumanBone.ItemR |
| string | [LeftHandItem](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#a14091730cfdfc503580aab9f63620add) = "" |
| [HumanBone](namespace_tale_worlds_1_1_core.html#a47efca28876c843963d0ab7136b2bfb0) | [LeftHandItemBone](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#a7ed956cd275cbfc681c8a0af64ca8ae3) = HumanBone.ItemL |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0a02cc65cc567db6101ea4afa275ff36) | [PairEntity](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#a1b00952cc01f98a1ee46c22bee26d117) = null |
| int | [MinUserToStartInteraction](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#abb021ffb7e3c87798fe1ad20d2e54b0e) = 1 |
| bool | [ActivatePairs](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#a0531d7fd782311143c0eea5858320e47) = false |
| float | [MinWaitinSeconds](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#a21087d6464ca22cc267833fc21f882eb) = 30 |
| float | [MaxWaitInSeconds](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#abed633daeb476c3b5ba03873a5f200a9) = 120 |
| float | [ForwardDistanceToPivotPoint](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#aaf2238729474b6251386fe0efaebdfd5) = 0.0f |
| float | [SideDistanceToPivotPoint](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#abe8570d605650156dec7321f6a2742dc) = 0.0f |
| bool | [KeepOldVisibility](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#a90b71f173c1d98ba7702446383212ebd) = false |
| Public Attributes inherited from [TaleWorlds.MountAndBlade.StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) | |
| bool | [AutoSheathWeapons](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html#a9aae5294c47355394591dddf26bd2aba) = true |
| bool | [AutoEquipWeaponsOnUseStopped](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html#a57456484662141ed35ae9941e7858651) |
| bool | [AutoWieldWeapons](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html#afe8fac1bbe00581688f4d3110e768f5d) |
| readonly bool | [TranslateUser](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html#a40df46f14f43b179ef7a89d3a045a0bf) = true |
| bool | [HasRecentlyBeenRechecked](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html#a615354f67a902d8ad09c4819ea6336b8) = false |
| Public Attributes inherited from [TaleWorlds.MountAndBlade.UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) | |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [DescriptionMessage](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#a4bc4b5231ecfe5915407bd53714b99bb) = [TextObject.GetEmpty](class_tale_worlds_1_1_localization_1_1_text_object.html#a7610c7f72e75604a8fcaf95b35e020a5)() |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [ActionMessage](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#a24907803e3a26fbb3406ab305df4ca58) = [TextObject.GetEmpty](class_tale_worlds_1_1_localization_1_1_text_object.html#a7610c7f72e75604a8fcaf95b35e020a5)() |
| Static Public Attributes inherited from [TaleWorlds.MountAndBlade.MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | |
| const int | [MaxNavMeshPerDynamicObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#ad33e7f4aeb39643c81e3f22ae208d9e1) = 50 |
| Protected Types inherited from [TaleWorlds.MountAndBlade.MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | |
| enum | [DynamicNavmeshLocalIds](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90b) : int {     [Inside](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90ba9b6d3000134648fc9f1e71094ae0847d) = 1 ,     [Enter](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90baf1851d5600eae616ee802a31ac74701b) = 2 ,     [Exit](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90bafef46e5063ce3dc78b8ae64fa474241d) = 3 ,     [Blocker](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90bada32a1684e943a766fec67b13009be79) = 4 ,     [Extra1](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90ba113f84d105af2b8016b3896117c9deab) = 5 ,     [Extra2](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90ba83dca46dd08ad782e968d586375715e1) = 6 ,     [Extra3](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90bab7f54183dc84b2982ebe161b9c59f2d9) = 7 ,     [Reserved1](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90ba93876cb309016fa725517b046474c44b) = 9 ,     [Count](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a372b2aeade07bfd684abc80ae376c90bae93f994f01c537c4e2f7d8528c3eb5e9)   } |
| Protected Attributes inherited from [SandBox.Objects.AnimationPoints.AnimationPoint](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html) | |
| float | [ActionSpeed](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#a75c41061f1a6a8578c25a58574d42981) = 1f |
| [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) | [LoopStartActionCode](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#a3a35d37322cdc345e1951c201d6f1f79) |
| [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) | [PairLoopStartActionCode](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#af287c00091c30464ae75b0323aa9f230) |
| [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) | [DefaultActionCode](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#a9c2fdbac6073b5dddd65a2e9dec77a1e) |
| Protected Attributes inherited from [TaleWorlds.MountAndBlade.StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) | |
| [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | [StandingPointSide](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html#ad8e45eda4768a1966d5f802ab2cb3a3d) = BattleSideEnum.None |
| Protected Attributes inherited from [TaleWorlds.MountAndBlade.MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | |
| string | [NavMeshPrefabName](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#afbbb7a7a9d7d3196e2166a3408c30d3e) = "" |
| int | [DynamicNavmeshIdStart](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a86be6f4e676cad159e82a8803daf8d1e) = 0 |
| Properties inherited from [SandBox.Objects.AnimationPoints.AnimationPoint](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html) | |
| override bool | [PlayerStopsUsingWhenInteractsWithOther](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#afcdf02005e74976977da83d32d97c478) `[get]` |
| bool | [IsArriveActionFinished](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#a86730fb6b1d04e0cdaf6b97d45c80598) `[get]` |
| string | [SelectedRightHandItem](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#a0e4ca533cca5115411c97aa5beb46c91) `[get, set]` |
| string | [SelectedLeftHandItem](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#a43077e6309e04767f012741b375a9f1f) `[get, set]` |
| bool | [IsActive](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#a92207f80c9941d3e81440afe0408ea3c) = true `[get]` |
| override bool | [DisableCombatActionsOnUse](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#a9d545c5c35a270bf973360d35c52d2ef) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) | |
| virtual [Agent.AIScriptedFrameFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0) | [DisableScriptedFrameFlags](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html#a926e4548a78cc33bdc5b9605c771e7de) `[get]` |
| override bool | [DisableCombatActionsOnUse](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html#a398d066d52aed6f5c454c9a6466e7e63) `[get]` |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [FavoredUser](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html#ae1a3a92cfcab9275c6aaf82ef5353df4) `[get, set]` |
| virtual bool | [PlayerStopsUsingWhenInteractsWithOther](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html#a928f50a3beae2391a18f76cf20ebf855) `[get]` |
| bool | [UseOwnPositionInsteadOfWorldPosition](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html#ad3e9c5f7061240e4bac3e6969390ecfa) `[get]` |
| float | [CustomPlayerInteractionDistance](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html#a6e63c895ec06a752bbba9fe39d77cbd4) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) | |
| virtual [FocusableObjectType](namespace_tale_worlds_1_1_mount_and_blade.html#aa83361d8fb674ed9b16444d43d30d141) | [FocusableObjectType](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#ab6ff66b345c22e8dcffcd7df4c04a73f) `[get]` |
| virtual bool | [IsFocusable](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#a7675e969c6d4685bbc466c8896fd42ae) `[get]` |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [UserAgent](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#a1ec129dd974ce7bac3aca8bb132fe945) `[get]` |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [PreviousUserAgent](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#a07877cae186eaf95d31889eaf0276ba9) `[get]` |
| GameEntityWithWorldPosition | [GameEntityWithWorldPosition](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#ab19d5c2d887580f70cfbbdfe35d0f83e) `[get]` |
| virtual [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [MovingAgent](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#a4c3a94092901aee68778f407ebd1d3ad) `[get]` |
| List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | [DefendingAgents](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#a1ef1394f88a0d4e3ae92b8b63961bfc0) `[get]` |
| bool | [HasDefendingAgent](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#a7bd4faf639f5c4159ebe0707a56adcc0) `[get]` |
| virtual bool | [DisableCombatActionsOnUse](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#a5c9cc6e74fa44578efd47a33a4f44087) `[get]` |
|  | If user agent's combat actions will be disabled while using this object or not. |
| virtual bool | [LockUserFrames](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#a37ce0ac13ef6d5dd8f1044b36f06221d) `[get, set]` |
|  | If user agents' frames will stay constant or not. |
| virtual bool | [LockUserPositions](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#aee1a2bb54f9fe11a3adfdeb4a943da07) `[get, set]` |
|  | If user agents' positions will stay constant or not. |
| bool | [IsInstantUse](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#a14d913907d32a676db073c617334a668) `[get, protected set]` |
|  | Whether this object is used instantly or is used continuously over some time. |
| bool | [IsDeactivated](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#ab2237b833e50ca914985f02ef71df11e) `[get, set]` |
| bool | [IsDisabledForPlayers](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#a8f7b9637971accd6813053bb12c19aa4) `[get, set]` |
| virtual [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | [InteractionEntity](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#a357c1e02e7a357a3d367eb0b91906442) `[get]` |
| bool | [HasAIUser](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#afb8e516dfebb27e6c84290614bcb9b66) `[get]` |
| bool | [HasUser](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#a6867a99e199d34379d492a4ef649fbb5) `[get]` |
| virtual bool | [HasAIMovingTo](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#aa828d7907abf0cc8149b6722f42cda3f) `[get]` |
| bool | [IsVisible](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#a0d2d97a34c8af9bb75df02a9706431e1) `[get, set]` |
| Properties inherited from [TaleWorlds.MountAndBlade.SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html) | |
| uint | [Color](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a832ccf9e2bf604c00868fa3b15db3e55) `[get]` |
| uint | [Color2](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#ada43d051ea21ec2ed928b2850a28d1fe) `[get]` |
| bool | [SynchronizeCompleted](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html#a1db8c6d3c11f75a0a1ef610ad5bc0e71) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | |
| [MissionObjectId](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_object_id.html) | [Id](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a6fbaa061b2ba0b6d0ad628a95f2f15ab) `[get, set]` |
| bool | [IsDisabled](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a53552a096fb534b9ea90ae1527b19cf4) `[get]` |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [HitObjectName](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a157e8b8a578e378ca91fb22639741ab3) `[get]` |
| bool | [CreatedAtRuntime](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html#a4d626d05a65d1a028bd791bbeba1f723) `[get]` |
| Properties inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | [GameEntity](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0a02cc65cc567db6101ea4afa275ff36) `[get]` |
| [ManagedScriptComponent](class_tale_worlds_1_1_engine_1_1_managed_script_component.html) | [ScriptComponent](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a8d7c5772e6b456b1e22ccd46a0b391ce) `[get]` |
| ManagedScriptHolder | [ManagedScriptHolder](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a58417dd71bf3daca6eb58df177617c2d) `[get]` |
| Scene | [Scene](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a9d7d5b77582948847f1d1c532face2c8) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_objects_1_1_animation_points_1_1_play_music_point.html#a346e55d043207a3061579877d7488b31)OnInit()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.Objects.AnimationPoints.PlayMusicPoint.OnInit | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.Objects.AnimationPoints.AnimationPoint](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#a0048c79616c0df37078fe9ea6333099f).

[◆](class_sand_box_1_1_objects_1_1_animation_points_1_1_play_music_point.html#a0210e9b3baa9f328c5beb188e6c9a5f5)StartLoop()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.Objects.AnimationPoints.PlayMusicPoint.StartLoop | ( | [SoundEvent](class_tale_worlds_1_1_engine_1_1_sound_event.html) | *trackEvent* | ) |  |

[◆](class_sand_box_1_1_objects_1_1_animation_points_1_1_play_music_point.html#ac41eaac5f74c93394d876c8ccd3183de)EndLoop()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.Objects.AnimationPoints.PlayMusicPoint.EndLoop | ( |  | ) |  |

[◆](class_sand_box_1_1_objects_1_1_animation_points_1_1_play_music_point.html#a545c8141118c9b3befb66234ed370464)GetTickRequirement()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) SandBox.Objects.AnimationPoints.PlayMusicPoint.GetTickRequirement | ( |  | ) |  | | virtual |

Reimplemented from [SandBox.Objects.AnimationPoints.AnimationPoint](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#a687347a98f7ff953af44274b42b6eade).

[◆](class_sand_box_1_1_objects_1_1_animation_points_1_1_play_music_point.html#a16c23aa88948b313f2d494f2425c58fb)OnTick()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.Objects.AnimationPoints.PlayMusicPoint.OnTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented from [SandBox.Objects.AnimationPoints.AnimationPoint](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#a35ee9ceae4a4e41ff68fa01360e1c19a).

[◆](class_sand_box_1_1_objects_1_1_animation_points_1_1_play_music_point.html#af9a95801c88a868e6cd12dc29489ab23)OnUseStopped()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void SandBox.Objects.AnimationPoints.PlayMusicPoint.OnUseStopped | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *userAgent*, | |  |  | bool | *isSuccessful*, | |  |  | int | *preferenceIndex* ) | | virtual |

Reimplemented from [SandBox.Objects.AnimationPoints.AnimationPoint](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#a726503156f9d4f3d9bccd8fda4685de3).

[◆](class_sand_box_1_1_objects_1_1_animation_points_1_1_play_music_point.html#a038617e15bb813dbdfc759f83ceeabaf)ChangeInstrument()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.Objects.AnimationPoints.PlayMusicPoint.ChangeInstrument | ( | Tuple< [InstrumentData](class_sand_box_1_1_objects_1_1_instrument_data.html), float > | *instrument* | ) |  |

