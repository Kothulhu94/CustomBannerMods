--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_mission.html ---

TaleWorlds.MountAndBlade.Mission Class ReferencesealedInherits DotNetObject, and [TaleWorlds.Core.IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html).

|  |  |
| --- | --- |
| Classes | |
| class | [MBBoundaryCollection](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_m_b_boundary_collection.html) |
| class | [DynamicallyCreatedEntity](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_dynamically_created_entity.html) |
| struct | [TimeSpeedRequest](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_time_speed_request.html) |
| class | [MissionNetworkHelper](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_mission_network_helper.html) |
| class | [Missile](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_missile.html) |
| struct | [SpectatorData](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_spectator_data.html) |
| class | [TeamCollection](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_team_collection.html) |

|  |  |
| --- | --- |
| Public Types | |
| enum | [WeaponSpawnFlags](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a13b99667142577320096a9f09f129f63) : uint {     [None](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a13b99667142577320096a9f09f129f63a6adf97f83acf6453d4a6a4b1070f3754) = 0x00000000 ,     [WithHolster](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a13b99667142577320096a9f09f129f63ac70c1389f75bfb7583497de7288a26ec) = 0x00000001 ,     [WithoutHolster](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a13b99667142577320096a9f09f129f63aeb0775f5db977c13dbcb3ad2aa3059e5) = 0x00000002 ,     [AsMissile](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a13b99667142577320096a9f09f129f63a16018cb369fdfa2e17c683a423ce2758) = 0x00000004 ,     [WithPhysics](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a13b99667142577320096a9f09f129f63a05fbc44a43e1325665fc08117b275d96) = 0x00000008 ,     [WithStaticPhysics](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a13b99667142577320096a9f09f129f63a69d867e0efd5c765ec2add65c0928734) = 0x00000010 ,     [UseAnimationSpeed](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a13b99667142577320096a9f09f129f63aa2d907dc0e62c26ea8c7d568a528d630) = 0x00000020 ,     [CannotBePickedUp](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a13b99667142577320096a9f09f129f63a46c4d3e50dcf7bba0613feb62ba1563c) = 0x00000040   } |
| enum | [MissionCombatType](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a2d209a484eef9303f04737652fa2602d) : int {     [Combat](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a2d209a484eef9303f04737652fa2602da30ad1054cf7ad7636a26844a6f782e1f) = 0 ,     [ArenaCombat](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a2d209a484eef9303f04737652fa2602dabcd7e33b1dc09fc4045f28fed86ded0d) = 1 ,     [NoCombat](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a2d209a484eef9303f04737652fa2602dabea3aed299334e37a2ccd527ffefe7e0) = 2   } |
|  | Combat type of the mission. [More...](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a2d209a484eef9303f04737652fa2602d) |
| enum | [BattleSizeType](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a4e0efc500dfb2fe7ca70dfb58ff7e1c5) {     [Battle](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a4e0efc500dfb2fe7ca70dfb58ff7e1c5a747d99f92ee9c080ba26108ac5d26488) ,     [Siege](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a4e0efc500dfb2fe7ca70dfb58ff7e1c5a7e86b036c23f9a7df08bff9baeaf98ad) ,     [SallyOut](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a4e0efc500dfb2fe7ca70dfb58ff7e1c5a3d6806e222f143afc07bd405190644b7)   } |
| enum | [State](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a09888b586108ef6c430ecc8fed801f9d) {     [NewlyCreated](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a09888b586108ef6c430ecc8fed801f9da19bcc286d3e0b1420f57a08c2cb4e26c) ,     [Initializing](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a09888b586108ef6c430ecc8fed801f9da32b169f72b293ef80d35435e9894f8e2) ,     [Continuing](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a09888b586108ef6c430ecc8fed801f9da481c481246e60dab7fec4c802d56fee9) ,     [EndingNextFrame](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a09888b586108ef6c430ecc8fed801f9daf1db5969ebaa8ee5d87c5fd2cdbc17ab) ,     [Over](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a09888b586108ef6c430ecc8fed801f9daef087651eb482bae4624478696f4ad4f)   } |
| enum | [BattleSizeQualifier](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aa88817ab1e39e376b791dbc915bcc1c5) {     [Small](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aa88817ab1e39e376b791dbc915bcc1c5a2660064e68655415da2628c2ae2f7592) ,     [Medium](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aa88817ab1e39e376b791dbc915bcc1c5a87f8a6ab85c9ced3702b4ea641ad4bb5)   } |
| enum | [MissionTeamAITypeEnum](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#abaf2994f3d6a2d3282a79078c16c2bfe) {     [NoTeamAI](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#abaf2994f3d6a2d3282a79078c16c2bfea69fa6f0b3ec60caee44eb90ac5911da1) = 0 ,     [FieldBattle](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#abaf2994f3d6a2d3282a79078c16c2bfea91342baa157f7211d22515fb9e3e28c5) = 1 ,     [Siege](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#abaf2994f3d6a2d3282a79078c16c2bfea7e86b036c23f9a7df08bff9baeaf98ad) = 2 ,     [SallyOut](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#abaf2994f3d6a2d3282a79078c16c2bfea3d6806e222f143afc07bd405190644b7) = 3 ,     [NavalBattle](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#abaf2994f3d6a2d3282a79078c16c2bfea58bfd1193b994f8e428ef9841f040c54) = 4   } |
| enum | [MissileCollisionReaction](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a235275d0a4fd9f604f19aaaf6943e494) {     [Invalid](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a235275d0a4fd9f604f19aaaf6943e494a4bbb8f967da6d1a610596d7257179c2b) = -1 ,     [Stick](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a235275d0a4fd9f604f19aaaf6943e494abf865bdc779ea87d172a8b1e5adc01b8) ,     [PassThrough](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a235275d0a4fd9f604f19aaaf6943e494ae1ff6a7360e99cb46db6bb5d3ff8e2eb) ,     [BounceBack](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a235275d0a4fd9f604f19aaaf6943e494a21fbab5ff309a17315a1862a2fd54d2d) ,     [BecomeInvisible](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a235275d0a4fd9f604f19aaaf6943e494abd91fb9ad9371dc6cbcc3c13a254593a) ,     [Count](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a235275d0a4fd9f604f19aaaf6943e494ae93f994f01c537c4e2f7d8528c3eb5e9)   } |
| enum | [MissionTickAction](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aeaac3485578af13b00618383e6f0264e) {     [TryToSheathWeaponInHand](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aeaac3485578af13b00618383e6f0264ea0929ef0d2f225226129d174b37ecba7f) ,     [RemoveEquippedWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aeaac3485578af13b00618383e6f0264ea13929770379c335cfef225415e862149) ,     [TryToWieldWeaponInSlot](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aeaac3485578af13b00618383e6f0264ea501debe5750a371338e4776d9967a5cb) ,     [DropItem](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aeaac3485578af13b00618383e6f0264ea235400933cc661b97aa57f2e40c8b3cd) ,     [RegisterDrownBlow](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aeaac3485578af13b00618383e6f0264ea73b2e38797438b7f1a81dbb36fbad112)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| IEnumerable< [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) > | [GetActiveEntitiesWithScriptComponentOfType< T >](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#add3c8fe5288aa1616067590c8ecd82a5) () |
| void | [AddActiveMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a3808db7dce9772b867fbb8baf09bc46c) ([MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) missionObject) |
| void | [ActivateMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#af5099d99a8d5b7c7dc24449bd431cd2a) ([MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) missionObject) |
| void | [DeactivateMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a347a1d416740275d3902cd51067ecbc4) ([MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) missionObject) |
| void | [SetMissionCombatType](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#af55f8d8154425ee704c361f0812bb372) ([MissionCombatType](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a2d209a484eef9303f04737652fa2602d) missionCombatType) |
| void | [ConversationCharacterChanged](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a31721342b0e5b8365fc98a2b18128de0) () |
| void | [SetMissionMode](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aec2afab7c5dad2ecdce415494c96f3fa) ([MissionMode](namespace_tale_worlds_1_1_core.html#a34f0ac611df16851fc92e4523aa834e1) newMode, bool atStart) |
| float | [GetAverageFps](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ace924e29975e9c3d454db6d2ecc703a4) () |
| bool | [GetFallAvoidSystemActive](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#af5d09e64d929a4d67a81495b3d825729) () |
| void | [SetFallAvoidSystemActive](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a6f2249bba7b12262caa9351e04990d17) (bool fallAvoidActive) |
| bool | [IsPositionInsideBoundaries](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ad21c639684758e663af6a494b18b02f2) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position) |
|  | Checks if the given position is inside or outside of the mission boundaries. |
| bool | [IsPositionInsideHardBoundaries](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aa7e1c76655e2e2e41fd529f73f112ed6) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position) |
| bool | [IsPositionInsideAnyBlockerNavMeshFace2D](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a4757ee726a28cc8aba099f49a36d61ac) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position) |
| bool | [IsPositionOnAnyBlockerNavMeshFace](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a1dd2827a8549eacc526b17b0af9b5e03) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position) |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [RayCastForClosestAgent](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a704eb891e031b138d8699e2a602a2cde) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) sourcePoint, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) targetPoint, int excludedAgentIndex, float rayThickness, out float collisionDistance) |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [RayCastForClosestAgentsLimbs](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a0f550523ea29371d5b0f00f1b8e5abb6) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) sourcePoint, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) targetPoint, int excludedAgentIndex, float rayThickness, out float collisionDistance, out sbyte boneIndex) |
| bool | [RayCastForGivenAgentsLimbs](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a54b0769971691f19390039e0a9f5d25b) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) sourcePoint, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) rayFinishPoint, int givenAgentIndex, float rayThickness, out float collisionDistance, out sbyte boneIndex) |
| float | [GetBiggestAgentCollisionPadding](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#af152fc3724e78abfa96df4c4eedeeb30) () |
| void | [SetMissionCorpseFadeOutTimeInSeconds](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a395a9b2b99bdf97c70756c36c04dff40) (float corpseFadeOutTimeInSeconds) |
| void | [SetOverrideCorpseCount](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#af8874ecb122448dccdc9a93670b82c9c) (int overrideCorpseCount) |
| void | [SetReportStuckAgentsMode](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aa2d62703b6cb0ae4f1bfc583164cecdc) (bool value) |
| void | [ResetMission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a03868ea4754f852e2f456c6a79f31a3a) () |
| void | [Initialize](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a2479938012a123e62f6b47ca25b26a30) () |
| void | [TickAgentsAndTeamsAsync](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a2abae4c06e93f628a4ea1f12a9b06a9a) (float dt) |
| void | [MakeSound](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aceffa04e390ed1ff43f43b931a858dd5) (int soundIndex, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position, bool soundCanBePredicted, bool isReliable, int relatedAgent1, int relatedAgent2) |
| void | [MakeSound](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a487b57dd2772de7564e74a5781257781) (int soundIndex, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position, bool soundCanBePredicted, bool isReliable, int relatedAgent1, int relatedAgent2, ref [SoundEventParameter](struct_tale_worlds_1_1_engine_1_1_sound_event_parameter.html) parameter) |
| void | [MakeSoundOnlyOnRelatedPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a77d5c7dca45a7067b8bceb85e4f5b621) (int soundIndex, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position, int relatedAgent) |
| void | [AddDynamicallySpawnedMissionObjectInfo](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a5005488478b9ef0b6864f18b00fa63af) ([DynamicallyCreatedEntity](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_dynamically_created_entity.html) entityInfo) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetMissileCollisionPoint](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#afa37694f604b5ebdc956f9ac6814fab7) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) missileStartingPosition, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) missileDirection, float missileSpeed, in [WeaponData](struct_tale_worlds_1_1_mount_and_blade_1_1_weapon_data.html) weaponData) |
| void | [RemoveMissileAsClient](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a01b2488226358e563267324019ece076) (int missileIndex) |
| void | [PrepareMissileWeaponForDrop](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a41c8e2de4d5ebdce92f477030a2a1752) (int missileIndex) |
| void | [AddParticleSystemBurstByName](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ada61bffb03d0324a656162313d364849) (string particleSystem, [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame, bool synchThroughNetwork) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetClosestBoundaryPosition](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a4dff2e92389a31325671b78e7577e297) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position) |
| int | [GetFreeRuntimeMissionObjectId](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ae2ee69525d2f7727de18e74110479d80) () |
| int | [GetFreeSceneMissionObjectId](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ac330c1fa4d60d57fd20b1195fdf9b134) () |
| void | [SetCameraFrame](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a74ff3f122ea6162ec048432684cfd9d5) (ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) cameraFrame, float zoomFactor) |
| void | [SetCameraFrame](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aab13c291bab5b3e8ab8130214431ef4c) (ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) cameraFrame, float zoomFactor, ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) attenuationPosition) |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetCameraFrame](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a53106e6003335cd67db28ad446b816dd) () |
| void | [ResetFirstThirdPersonView](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ac9ea4e73b8522ed0a065f740e0cc4c2d) () |
| void | [SetCustomCameraLocalOffset](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aa0c4239057aa3c59e6b6a449a073244d) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) newCameraOffset) |
| void | [SetCustomCameraTargetLocalOffset](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a726a48b193493d84589d49dbf3341ac4) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) newTargetLocalOffset) |
| void | [SetCustomCameraLocalOffset2](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ad3212d0ceea59eca6a7e6588a663686a) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) newCameraOffset) |
| void | [SetCustomCameraLocalRotationalOffset](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#abedbf126781aa8bf96c538121c9160a8) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) newCameraRotationalOffset) |
| void | [SetCustomCameraGlobalOffset](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#af00fed51550fd77ae6648220f5411811) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) newCameraOffset) |
| void | [SetCustomCameraFovMultiplier](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a9c7a4d298495f73e8cc4d82c99935430) (float newFovMultiplier) |
| void | [SetCustomCameraFixedDistance](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a5eba433d287fb23cb5a5f1b92e9571fb) (float distance) |
| void | [SetIgnoredEntityForCamera](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a6dcf0b6cf2f4b18b2bb59ca202d941f0) ([GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) ignoredEntity) |
| void | [SetCustomCameraIgnoreCollision](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ab09f4cd83ccf9bea0625492df1120e2e) (bool ignoreCollision) |
| void | [SetListenerAndAttenuationPosBlendFactor](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ad53eb76118c0cd4777713d0e920d555e) (float factor) |
| void | [AddTimeSpeedRequest](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aa76d73175f176044b088f760abdf5968) ([TimeSpeedRequest](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_time_speed_request.html) request) |
| void | [RemoveTimeSpeedRequest](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a4bb549fe59cc632cb13f4120c36804f5) (int timeSpeedRequestID) |
| bool | [GetRequestedTimeSpeed](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ae1d92449e78a79a52bd8612a8d311817) (int timeSpeedRequestID, out float requestedTime) |
| void | [ClearAgentActions](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ac643df653bb179421cdf258eb9fa14f7) () |
| void | [ClearMissiles](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a98758d684d360f461921fc4dab52d72c) () |
| void | [ClearCorpses](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aed614f5fe20b2b65ec41ba5a6d38bc82) (bool isMissionReset) |
| bool | [IsAgentInProximityMap](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a37e566bfd44470f006cb260e0a3310e6) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| void | [OnMissionStateActivate](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ab3e9046a20b6c745cabbb18bf2edd47e) () |
|  | This routine is called when mission state is activated This happens right after mission is first initialized or when another state is popped out (such as when player enters inventory in mission). |
| void | [OnMissionStateDeactivate](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a3c0814ce6e27b3741c7406392c70ea4a) () |
|  | This function is to be called when mission state is deactivated. This happens either before mission state is finalized or when another state is pushed in (such as when player enters inventory in mission). |
| void | [OnMissionStateFinalize](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a21b47d7f7d6195c5537728ae86b11749) (bool forceClearGPUResources) |
|  | This routine is called when mission state is finalized. [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) will be destroyed after this call and any remaining mission resources will be cleaned up. |
| void | [ClearUnreferencedResources](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aba5b07d95b5b70b8974e9b4df02397cc) (bool forceClearGPUResources) |
| float | [GetMainAgentMaxCameraZoom](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a6a1b23b99af6477bb44ce43f1d00dc10) () |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | [GetBestSlopeTowardsDirection](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a6ca2d8c89429973ac43b104b3843dc08) (ref [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) centerPosition, float halfSize, ref [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) referencePosition) |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | [GetBestSlopeAngleHeightPosForDefending](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a7dc783885e0b7fac5c19a88cd96aeb54) ([WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) enemyPosition, [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) defendingPosition, int sampleSize, float distanceRatioAllowedFromDefendedPos, float distanceSqrdAllowedFromBoundary, float cosinusOfBestSlope, float cosinusOfMaxAcceptedSlope, float minSlopeScore, float maxSlopeScore, float excessiveSlopePenalty, float nearConeCenterRatio, float nearConeCenterBonus, float heightDifferenceCeiling, float maxDisplacementPenalty) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetAveragePositionOfAgents](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a9c894b7fc1191f51b73ae05f041e0db1) (List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > agents) |
| void | [SetRandomDecideTimeOfAgentsWithIndices](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ab382f22be6a3d3e15f1973885ff8d339) (int[] agentIndices, float? minAIReactionTime=null, float? maxAIReactionTime=null) |
| void | [SetBowMissileSpeedModifier](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#af620893f20b479b9dda13428a73d1803) (float modifier) |
| void | [SetCrossbowMissileSpeedModifier](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ac46f7ec4867aac3d0c9fd85f3ad6e546) (float modifier) |
| void | [SetThrowingMissileSpeedModifier](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a9d8dbbc95a22e1c718e7e3ecc17f3f89) (float modifier) |
| void | [SetMissileRangeModifier](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a237a757ecf9c72aee1aa986f0a1a81ea) (float modifier) |
| void | [SetLastMovementKeyPressed](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a0160bdbf199081bdc705f4a928f1206f) ([Agent.MovementControlFlag](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a81bece812eef7b0170864a38f387e797) lastMovementKeyPressed) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetWeightedPointOfEnemies](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a6d36564352771c05f7442838f1e39944) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) basePoint) |
| bool | [GetPathBetweenPositions](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a6e9f74c8d717b0bdf27df3b3d768d2ff) (ref [NavigationData](struct_tale_worlds_1_1_mount_and_blade_1_1_navigation_data.html) navData) |
| void | [SetNavigationFaceCostWithIdAroundPosition](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ab14091a3255e2db5ff347be35bff8952) (int navigationFaceId, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position, float cost) |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | [GetStraightPathToTarget](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a2f59a2ee0457dc49f7670c389643ae71) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) targetPosition, [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) startingPosition, float samplingDistance=1f, bool stopAtObstacle=true) |
| void | [SkipForwardMissionReplay](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a30e2d9a10a5e8545948af437b73a8464) (float startTime, float endTime) |
| int | [GetDebugAgent](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a7f04c606f2afb66932e8633c2baa0676) () |
| void | [AddAiDebugText](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a14210ed556464c0383942543e9cd01d2) (string str) |
| void | [SetDebugAgent](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a42557be75f1452d0ec3a2a26cb0ef41d) (int index) |
| float | [GetWaterLevelAtPosition](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a7361dc1a5e5197766fcdfc31bea5a052) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position, bool useWaterRenderer) |
| float | [GetWaterLevelAtPositionMT](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a122a00549090157207f3e19ae389d98b) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position, bool useWaterRenderer) |
| bool | [CanPhysicsCollideBetweenTwoEntities](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a7cc7b3a1aa4f7bf9d8335e7dedb3be52) (UIntPtr entity0Ptr, UIntPtr entity1Ptr) |
| delegate void | [OnBeforeAgentRemovedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a92ec14adf8994c29e1f782be658f5a5a) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectedAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectorAgent, [AgentState](namespace_tale_worlds_1_1_core.html#a799bcc77ddb6372c7383f3340ed4d1c0) agentState, [KillingBlow](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html) killingBlow) |
| delegate void | [OnAddSoundAlarmFactorToAgentsDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#acc03845f8ec54d33daa5cd63d309a73b) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) alarmCreatorAgent, in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) soundPosition, float soundLevelSquareRoot) |
| delegate void | [OnMainAgentChangedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ae158b35a2eb37fcf6aab7e03efa53df0) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) oldAgent) |
| delegate [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | [ComputeTroopBodyPropertiesDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a8313f05ca1c550498be0554af2e13335) ([AgentBuildData](class_tale_worlds_1_1_mount_and_blade_1_1_agent_build_data.html) agentBuildData, [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) characterObject, [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) equipment, int seed) |
| bool | [GetDeploymentPlan< T >](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a67e7bfabc08d34be5a4746c390c865e2) (out T deploymentPlan) |
| float | [GetRemovedAgentRatioForSide](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aff19e379f95fae615e0e654a42226694) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| ref readonly List< [SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html) > | [GetAttackerWeaponsForFriendlyFirePreventing](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a085b4c96df0484efce6909a026f56661) () |
| void | [OnDeploymentPlanMade](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a20e7ebcae092efc76cc94fd41b5b30d2) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, bool isFirstPlan) |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | [GetAlternatePositionForNavmeshlessOrOutOfBoundsPosition](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aa8e876f490a22e36cbbd148e57128fb6) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) directionTowards, [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) originalPosition, ref float positionPenalty) |
| int | [GetNextDynamicNavMeshIdStart](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ae7ec33c2c1d9693818f82d45cd871a89) () |
| [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | [GetAgentTroopClass](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a188c476feab8b00463811b130fb47030) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) battleSide, [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) agentCharacter) |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | [GetClosestFleePositionForAgent](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a2239b0a22bc33ba0ba0d4091c67ea05d) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | [GetClosestFleePositionForFormation](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a0ef302300a6df3f4f610561d343e651b) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| MBReadOnlyList< [FleePosition](class_tale_worlds_1_1_mount_and_blade_1_1_flee_position.html) > | [GetFleePositionsForSide](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a77b5d8baeda1ed68cbbf95f9b0db8f57) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| void | [AddToWeaponListForFriendlyFirePreventing](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a79837579468bf2162fc136aab5309438) ([SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html) weapon) |
|  | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#adfc400efb4da1f8dfb2cffaa4fbb4758) ([MissionInitializerRecord](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html) rec, [MissionState](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html) missionState, bool needsMemoryCleanup) |
|  | Initializes a new instance of the [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) class. |
| void | [SetCloseProximityWaveSoundsEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aeced4ce28c04d2c73bd7d108ee1ec2a5) (bool value) |
| void | [ForceDisableOcclusion](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a6cdb89540bc0425e1b3170aa9fe4d6d3) (bool value) |
| void | [AddFleePosition](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#acb4888a52258f725d2027cb4f61dec32) ([FleePosition](class_tale_worlds_1_1_mount_and_blade_1_1_flee_position.html) fleePosition) |
| void | [RetreatMission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a970c16c53d16a11ad7e7909764a58bb7) () |
| void | [SurrenderMission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a360527ae0599849bad9f36fb38286ec8) () |
| bool | [HasMissionBehavior< T >](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a0d56f7829a8f63978946d323c6753328) () |
| [SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html) | [SpawnAttachedWeaponOnCorpse](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a292b0040f8ce65309da9fa4121a1d340) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, int attachedWeaponIndex, int forcedSpawnIndex) |
| void | [AddMountWithoutRider](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a3483e60b9248aeb89abd244729d33ba2) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) mount) |
| void | [RemoveMountWithoutRider](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a8aaba7b4e298b284cf7470c0715f3a11) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) mount) |
| void | [UpdateMountReservationsAfterRiderMounts](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ae696b14f4044047bf1a141e2a0c93de9) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) rider, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) mount) |
| void | [OnObjectDisabled](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#acc91dcc396cb2ca01ecac0f652dee549) ([DestructableComponent](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html) destructionComponent) |
| [MissionObjectId](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_object_id.html) | [SpawnWeaponAsDropFromMissile](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ad1d3d2e5b7dd2ea85bb3137eea9aaacb) (int missileIndex, [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) attachedMissionObject, in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) attachLocalFrame, [WeaponSpawnFlags](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a13b99667142577320096a9f09f129f63) spawnFlags, in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) velocity, in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) angularVelocity, int forcedSpawnIndex) |
| void | [SpawnWeaponAsDropFromAgentAux](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a3d1858bc3aca344855a9c556fd3005c7) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) equipmentIndex, ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) globalVelocity, ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) globalAngularVelocity, [WeaponSpawnFlags](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a13b99667142577320096a9f09f129f63) spawnFlags, int forcedSpawnIndex) |
| void | [SpawnAttachedWeaponOnSpawnedWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#af766a89d3caf901ff4ab3d75e9e65e5b) ([SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html) spawnedWeapon, int attachmentIndex, int forcedSpawnIndex) |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [SpawnWeaponWithNewEntity](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a534160ed2f94baeb9efcbe1c5c57045a) (ref [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) weapon, [WeaponSpawnFlags](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a13b99667142577320096a9f09f129f63) spawnFlags, [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame) |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [SpawnWeaponWithNewEntityAux](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aa242dd0a3e7cb70c6c9c253781ba245b) ([MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) weapon, [WeaponSpawnFlags](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a13b99667142577320096a9f09f129f63) spawnFlags, [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame, int forcedSpawnIndex, [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) attachedMissionObject, bool hasLifeTime, bool spawnedOnACorpse=false) |
| void | [AttachWeaponWithNewEntityToSpawnedWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a0e33051558c959e6257d00ec0315439c) ([MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) weapon, [SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html) spawnedItem, [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) attachLocalFrame) |
| void | [OnEquipItemsFromSpawnEquipmentBegin](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a4f661a2dea06c5a85d3ab0f8d888150c) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [Agent.CreationType](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a98ba61b43dff1b7e80a874e6d42a4938) creationType) |
| void | [OnEquipItemsFromSpawnEquipment](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a3bfabf9681c8a69138e9aae7fd4073cb) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [Agent.CreationType](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a98ba61b43dff1b7e80a874e6d42a4938) creationType) |
| void | [RecalculateBody](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a168386afb35c2ee8014330259c02f00f) (ref [WeaponData](struct_tale_worlds_1_1_mount_and_blade_1_1_weapon_data.html) weaponData, [ItemComponent](class_tale_worlds_1_1_core_1_1_item_component.html) itemComponent, [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) craftedWeaponData, ref [WeaponSpawnFlags](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a13b99667142577320096a9f09f129f63) spawnFlags) |
|  | This method will take the body and recalculate it if WeaponData::RecalculateBody is true. RecalculateBody (recalculate\_body) is an optional bool (default false) set in spitems.xml for each weapon, along with a starting body (body\_name) Recalculating works differently for each item: |
| void | [TickAgentsAndTeamsImp](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a4558532dfe569f9c2f0c0c4569405b23) (float dt, bool tickPaused) |
| void | [OnTick](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a5bb064ad6e41636241a7747aa96ff097) (float dt, float realDt, bool updateCamera, bool doAsyncAITick) |
|  | This callback method is called by the engine once in every frame. |
| void | [AddTickAction](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a22f2e53b454390e88c515a7ca336a7b8) ([MissionTickAction](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aeaac3485578af13b00618383e6f0264e) action, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, int param1, int param2) |
| void | [AddTickActionMT](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a29588b4f6eb2f05e22e576ec44299d37) ([MissionTickAction](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aeaac3485578af13b00618383e6f0264e) action, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, int param1, int param2) |
| void | [RemoveSpawnedItemsAndMissiles](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a3d2c2c5ce53de3229c4431ee55087079) () |
| void | [AfterStart](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a32934324952a083bae00b265b28e9656) () |
|  | This function is called by the engine right after a mission is started at the engine side. |
| void | [OnEndMissionRequest](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ade48e75645182ee1f1e194b8a1bf9078) () |
| float | [GetMissionEndTimeInSeconds](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a82608f1e64ceef8455d69e8593028b94) () |
| float | [GetMissionEndTimerValue](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ab4164564b5845f08c95487dfeeac9138) () |
| int | [GetMemberCountOfSide](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a148a23bb92e3928268c2b05102ebcb39) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| [Path](class_tale_worlds_1_1_engine_1_1_path.html) | [GetInitialSpawnPath](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a06cbd857b5e0c6b8d13577e3dd098209) () |
| [SpawnPathData](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html) | [GetInitialSpawnPathData](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#adb90179d011306386ce9d0c4b2048c5e) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) battleSide) |
| MBReadOnlyList< [SpawnPathData](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html) > | [GetReinforcementPathsDataOfSide](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a537be1bcc04f8a23c1d3104ac998a83b) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) battleSide) |
| void | [GetTroopSpawnFrameWithIndex](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ac63d64400f0df7e53f368355db687c6c) ([AgentBuildData](class_tale_worlds_1_1_mount_and_blade_1_1_agent_build_data.html) buildData, int troopSpawnIndex, int troopSpawnCount, out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) troopSpawnPosition, out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) troopSpawnDirection) |
|  | Returns a troop's world spawn frame (position & direction) w.r.t. its formation's (or a relevant formation's) spawn position. If the troop spawns into its own formation, then formation's spawn position will be considered as its current position. Troop's spawn position is offset by an amount regarding troop's index within the formation. Troop must have a valid formation. |
| void | [GetFormationSpawnFrame](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a3ee96cc55f5f5f4040364b52f6586015) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) formationClass, bool isReinforcement, out [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) spawnPosition, out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) spawnDirection) |
| [WorldFrame](struct_tale_worlds_1_1_engine_1_1_world_frame.html) | [GetSpawnPathFrame](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ab9ea0b2145f5a76f84fbe454cde03596) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) battleSide, float pathOffset=0f, float targetOffset=0f) |
| void | [SetBattleAgentCount](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a4715501fc972f8dd15c947f03a4379c4) (int agentCount) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetFormationSpawnPosition](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a49fc4f34ec6145e6cbe28d2a6672cf52) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) formationClass) |
| [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | [GetFormationSpawnClass](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a5a9b35761616d8751346de4fac81ab55) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) formationClass, bool isReinforcement=false) |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [SpawnAgent](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aac35b7a2ab6f555a3448eb118f372f3e) ([AgentBuildData](class_tale_worlds_1_1_mount_and_blade_1_1_agent_build_data.html) agentBuildData, bool spawnFromAgentVisuals=false) |
| void | [SetInitialAgentCountForSide](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ab64251449d200ac93a813fad560e32e9) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, int agentCount) |
| void | [SetFormationPositioningFromDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a8d7d8d61977afe56fabb53f27ed96dff) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [SpawnMonster](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a9132c1d87694c39140fc3297887ab2b0) ([ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) rosterElement, [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) harnessRosterElement, in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) initialPosition, in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) initialDirection, int forcedAgentIndex=-1) |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [SpawnMonster](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a74246eb4f6edf8e1cc743c4a55c545ac) ([EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) equipmentElement, [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) harnessRosterElement, in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) initialPosition, in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) initialDirection, int forcedAgentIndex=-1) |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [SpawnTroop](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a0b63e06ca515d4f044a6c83922e317c5) ([IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) troopOrigin, bool isPlayerSide, bool hasFormation, bool spawnWithHorse, bool isReinforcement, int formationTroopCount, int formationTroopIndex, bool isAlarmed, bool wieldInitialWeapons, bool forceDismounted, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html)? initialPosition, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? initialDirection, string specialActionSetSuffix=null, [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) bannerItem=null, [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) formationIndex=FormationClass.Unset, bool useTroopClassForSpawn=false) |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [ReplaceBotWithPlayer](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a88ffe54d94ba708e2fde45d0af3b44c8) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) botAgent, [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) missionPeer) |
| void | [OnAgentInteraction](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a7493ac8cd6856e3d93f4505304ba320d) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) requesterAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) targetAgent, sbyte agentBoneIndex) |
|  | Triggered when the player interacts with an agent. |
| void | [EndMission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#abcd28ccb949c1b3cb2cc4969c40795ef) () |
| void | [AddMissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a7a6bc9250b9dc600d4de3312d4f0b3a3) ([MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html) missionBehavior) |
| T | [GetMissionBehavior< T >](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a22e75fd9f15576c8215596f516063f4c) () |
| void | [RemoveMissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a1ae2aa06eca35e6b96007afe2a295ac1) ([MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html) missionBehavior) |
| void | [JoinEnemyTeam](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a2d1862434f3f752c344b2d0758a830e1) () |
| void | [OnEndMissionResult](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aa1f94efc51c6728fab1d37bf4ca8c1e7) () |
| bool | [IsAgentInteractionAllowed](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a6a94f7e73a797e362582cfb9085b4943) () |
| bool | [IsOrderGesturesEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a2b1b7c0f1bdc181f99f9a6b213daeb4f) () |
| List< [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) > | [GetExtraEquipmentElementsForCharacter](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ad5a41e297c5a592abd3e7905336686b4) ([BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) character, bool getAllEquipments=false) |
| bool | [IsPlayerCloseToAnEnemy](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a5e639f25fc1bbf81a93c22cbb04573c2) (float distance=5) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetRandomPositionAroundPoint](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a47274e6bdc8926c257520bfd8affbf6b) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) center, float minDistance, float maxDistance, bool nearFirst=false) |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | [FindBestDefendingPosition](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a76ba1e594418ed3183d53103861d2894) ([WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) enemyPosition, [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) defendedPosition) |
|  | Finds the best position taking into consideration slope, height and angle wrt the enemy position given and the defended position. |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | [FindPositionWithBiggestSlopeTowardsDirectionInSquare](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a8a37ef33096d8f16b5ef44d2a0fc37d6) (ref [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) center, float halfSize, ref [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) referencePosition) |
| [Missile](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_missile.html) | [AddCustomMissile](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a3382fe877b6aadc50ee5c1be78c73c2a) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) shooterAgent, [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) missileWeapon, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) direction, [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html) orientation, float baseSpeed, float speed, bool addRigidBody, [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) missionObjectToIgnore, int forcedMissileIndex=-1) |
| void | [OnAgentMount](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a0e389c56777e13a108cf1ce3799dde53) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| void | [OnAgentDismount](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a85e312908b85556e52322ef07f574eaa) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| void | [OnObjectUsed](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a4464f9c1d97305c0a601158c31a2a83c) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) userAgent, [UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) usableGameObject) |
| void | [OnObjectStoppedBeingUsed](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#af0eb5902fd471c0b693ec301c39f0637) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) userAgent, [UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) usableGameObject) |
| void | [InitializeStartingBehaviors](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a384185697fe11cfa0be287b6007f6989) ([MissionLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html)[] logicBehaviors, [MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html)[] otherBehaviors, [MissionNetwork](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html)[] networkBehaviors) |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [GetClosestEnemyAgent](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a29c9ce6f807c20425ab1792fa20d59fb) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position, float radius) |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [GetClosestAllyAgent](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#af706d18c316ea91be757f177b423158e) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position, float radius) |
| int | [GetNearbyEnemyAgentCount](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a62aae51cdc1f67df9dfaeb60d7fde9c3) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position, float radius) |
| bool | [HasAnyAgentsOfSideInRange](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a265dd0582c05e751134ab25c160fc54e) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) origin, float radius, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| void | [AddSoundAlarmFactorToAgents](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a094c0c83dfec9ad81a6318dab4217c55) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) alarmCreatorAgent, in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) soundPosition, float soundLevelSquareRoot) |
| bool | [OnMissionObjectRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a04368d0fe0ce5cd372563fb906117fb8) ([MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) missionObject, int removeReason) |
| bool | [AgentLookingAtAgent](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#af08d86d4b6b8a310593651a2c55978e2) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent1, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent2) |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [FindAgentWithIndex](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a625b3fdf40f60f97ab4372556fa0ca7c) (int agentId) |
| void | [OnRenderingStarted](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ab906cfc900a1bdf9550b794b1062a508) () |
| [Agent.MovementBehaviorType](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aae8de26b7a3c90f2606b38ac9e062cac) | [GetMovementTypeOfAgents](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a2a3196ad9b11133efefcb6e883bd8223) (IEnumerable< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > agents) |
| void | [ShowInMissionLoadingScreen](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a87187c725daf81bfd5e027c7633089d8) (int durationInSecond, Action onLoadingEndedAction) |
| bool | [CanAgentRout](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ad11a77753a40e40d2757caa476ae224b) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| void | [HandleMissileCollisionReaction](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a3820b1758c559080bb3b2fe41834a645) (int missileIndex, [MissileCollisionReaction](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a235275d0a4fd9f604f19aaaf6943e494) collisionReaction, [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) attachLocalFrame, bool isAttachedFrameLocal, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attachedAgent, bool attachedToShield, sbyte attachedBoneIndex, [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) attachedMissionObject, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) bounceBackVelocity, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) bounceBackAngularVelocity, int forcedSpawnIndex) |
| void | [KillAgentsOnEntity](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a3bc7a95970d3e823de84edb935f5fc0f) ([GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) entity, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) destroyerAgent, bool burnAgents) |
| void | [KillAgentCheat](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a55d828bb2d151bfac5da29b23649a4bd) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| bool | [KillCheats](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aa2c64c80e10039de024b867f681a0ac3) (bool killAll, bool killEnemy, bool killHorse, bool killYourself) |
| bool | [CanTakeControlOfAgent](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a109584004dd49aeaed05b1ce4b1e848a) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agentToTakeControlOf) |
| void | [SetPlayerCanTakeControlOfAnotherAgentWhenDead](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aa27e944910df054df5d91dc09c1835be) () |
| void | [TakeControlOfAgent](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a70a57d14602595319d7702f1d5c32549) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agentToTakeControlOf) |
| float | [GetDamageMultiplierOfCombatDifficulty](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a6899e53dd3e2dcff5bc782f93ea79aaf) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victimAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent=null) |
| float | [GetShootDifficulty](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a0fdca78d2e0f386eab22e298a715291c) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectedAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectorAgent, bool isHeadShot) |
| void | [AddCombatLogSafe](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a95894aa71302a3fe1366d11dc8f7f25a) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victimAgent, [CombatLogData](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html) combatLog) |
|  | This function stores combat logs to be created. These stored combat logs will be applied in [Mission.OnTick](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a5bb064ad6e41636241a7747aa96ff097 "This callback method is called by the engine once in every frame.") function. This function is thread safe. |
| [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | [CreateMissionObjectFromPrefab](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aa5ba91bfefea8166e49778d640ff1c14) (string prefab, [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame, Action< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > actionAppliedBeforeScriptInitialization) |
| int | [GetNearbyAllyAgentsCount](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ab2bc1f00a8a6ff14d3ce88a8f77c3143) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) center, float radius, [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
| MBList< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | [GetNearbyAllyAgents](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a08369c67e8ec526e8705110d75f8f108) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) center, float radius, [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, MBList< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > agents) |
| MBList< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | [GetNearbyEnemyAgents](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a0a43929a80094c81ae28f81c77bddfd4) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) center, float radius, [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, MBList< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > agents) |
| MBList< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | [GetNearbyAgents](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a26f8e551e713eeaa603ae28a0cb22955) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) center, float radius, MBList< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > agents) |
| bool | [IsFormationUnitPositionAvailableMT](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a560ca5054d0a88a0c69148be752ea59a) (ref [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) formationPosition, ref [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) unitPosition, ref [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) nearestAvailableUnitPosition, float manhattanDistance, [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
| bool | [IsOrderPositionAvailable](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a1ff64ed4cff320536d6bc8efbb343f09) (in [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) orderPosition, [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
| bool | [IsFormationUnitPositionAvailable](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a3663e2d3f37c4583c976e84b68d18eb4) (ref [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) unitPosition, [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
| bool | [HasSceneMapPatch](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a8460f602a3b00e1b46bceee187c47deb) () |
| bool | [GetPatchSceneEncounterPosition](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#adbc0777db5b8772d73bcb82dd1ea0c63) (out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position) |
| bool | [GetPatchSceneEncounterDirection](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a9bac139e1251fbe7910a9e7453161248) (out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) direction) |
| void | [AddTimerToDynamicEntity](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a42c7369588ccb302694990278f6b1eb6) ([GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity, float timeToKill=10.0f) |
| void | [AddListener](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a9c5493635ce5ce218ee5ce785fa67cf8) ([IMissionListener](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_listener.html) listener) |
| void | [RemoveListener](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a482c376c90a9ccea6dc3b6395848ff61) ([IMissionListener](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_listener.html) listener) |
| void | [OnAgentFleeing](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a8926dbddb0b9450a94e611b6f7ef7f04) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| void | [OnAgentPanicked](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a17528a007cf2e831a9a500fbab40b767) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| void | [OnTeamDeployed](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a708fdac5eb7fcb504bf317158a663ef5) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
|  | Called when a team had finished deployment. |
| void | [OnBattleSideDeployed](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ac09ddee123117368c0141e9b20d337b8) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
|  | Called when a battle side had finished deployment of all of its teams. |
| void | [OnDeploymentFinished](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a2cfc38973aea7ba5838e54bdc0ffca1d) () |
|  | Called when all deployment is finished (all teams and battle sides have deployed) and when order of battle is finalized (i.e. player clicked start button). |
| void | [OnAfterDeploymentFinished](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ad08455f82b55543526d83588c7c779fb) () |
| void | [OnFormationCaptainChanged](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a55017498629ddf284c4f206f660f0082) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| void | [SetFastForwardingFromUI](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#afcf07e344625561b560cc5f7f4a98c0e) (bool fastForwarding) |
| bool | [CheckIfBattleInRetreat](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a8ea513178a76af99b1c67509929c3c88) () |
| void | [AddSpawnedItemEntityCreatedAtRuntime](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a74f726ccbc9b6181bb92f68d78f435c5) ([SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html) spawnedItemEntity) |
| void | [TriggerOnItemPickUpEvent](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a326b2819c6d6122d6a6f68decff47a33) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html) spawnedItemEntity) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static float | [GetMissileVerticalAimCorrection](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aac6d6827a48a5467ed244c8cf862aab8) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) vecToTarget, float missileStartingSpeed, ref [WeaponStatsData](struct_tale_worlds_1_1_mount_and_blade_1_1_weapon_stats_data.html) weaponStatsData, float airFrictionConstant) |
|  | Return corrected angle. |
| static float | [GetMissileRange](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a365373462b04b9caf77ea6eb0e115c29) (float missileStartingSpeed, float heightDifference) |
| static float | [GetFirstPersonFov](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a11db8684b3a4ad91db7e1117d69c33ca) () |
| static int | [GetCurrentVolumeGeneratorVersion](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a6aad51c1139eec04fc3c5d4c46a5bc85) () |
| static string | [MakeEnemiesFleeCheat](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a8e0bbba2c2dee7afab390b6c7b78cda7) (List< string > strings) |
| static string | [MakeTeamFleeCheat](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aeeda361c0e002ec18564573a3ef0ad3b) (List< string > strings) |
| static string | [SetFacialAnimToAgent](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#acebb72451edf12daa56e49df56794d35) (List< String > strings) |
| static string | [EnableSpeedAdjustmentCommand](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a5655fd2bc7570aad3983145182ddbfaa) (List< string > strings) |
| static [Agent.UnderAttackType](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa6bf6f204fa49aaa08ddab2434120d27) | [GetUnderAttackTypeOfAgents](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a90becb0b506ab7367567088551cc0fbb) (IEnumerable< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > agents, float timeLimit=3.0f) |
| static [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | [GetAgentTeam](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ae5384420d9633f816a050785266843f0) ([IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) troopOrigin, bool isPlayerSide) |
| static [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | [GetTeam](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ac56d59aff606ed3d57ce3424a9c80de2) ([TeamSideEnum](namespace_tale_worlds_1_1_core.html#a15c7283e7d5f7d4abc93f22069624726) teamSide) |
| static IEnumerable< [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) > | [GetTeamsOfSide](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a1c8b432382713d14fd6aaf6eb66b8091) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| static float | [GetBattleSizeOffset](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#af18a5070410eb07ea104f0fb3532babe) (int battleSize, [Path](class_tale_worlds_1_1_engine_1_1_path.html) path) |
| static float | [GetPathOffsetFromDistance](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aba16ea801396a8268b8bf6628ec961d3) (float distance, [Path](class_tale_worlds_1_1_engine_1_1_path.html) path) |
| static float | [GetBattleSizeFactor](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a7b5608159823d4f849559ac6e3bbc1c9) (int battleSize, float normalizationFactor) |
| static string | [KillNAllies](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aa13e7c90bd899265c3f416be14e0b093) (List< string > strings) |
| static string | [KillAllAllies](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a0b3b519c1f076fa69933516b0e8a29ee) (List< string > strings) |
| static string | [ToggleDisableDying](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a344b7a7a048a89cbbba2c7b38d554f9b) (List< string > strings) |
| static string | [ToggleDisableDyingTeam](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a20348a4bf370c13b40e69b5bfa3a0b6e) (List< string > strings) |
| static string | [KillAgent](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a5a5bd8377d5f123b872522dbf18d069a) (List< String > strings) |
| static string | [IncreaseBatteringRamSpeeds](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a1a1079603c72775061a17db8d08766a4) (List< String > strings) |
| static string | [IncreaseSiegeTowerSpeed](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ab6eadf322a4f8b495bffb01baddfb682) (List< string > strings) |
| static string | [LoadParamsDebug](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aa8f07b11d6ca27727b3687a71d657a63) (List< string > strings) |

|  |  |
| --- | --- |
| Public Attributes | |
| bool | [DisableDying](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aad592c11fe2fd13c7c5c6fac5cba650a) = false |
| bool | [ForceNoFriendlyFire](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a4b4269e1cc700a9804f7c2cb6cd7afb9) = false |
| bool | [IsFriendlyMission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ae7232b76c93e887ab56bcf6497c07ece) = true |
| [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) | [MusicCulture](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a792ea78881c8c40096fac9669c9180a8) |
| bool | [IsOrderMenuOpen](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ae61b9118298f60372d1705e3b3760aec) |
| bool | [IsTransferMenuOpen](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#abfcc26923f24744560a6e40014a64a15) |
| bool | [IsInPhotoMode](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a5448119a9e4d4cee27e1738e65f111ae) |
| bool | [AllowAiTicking](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a33ef6a2beb4d696d4c4284a36fbe9f6c) = true |
| [IAgentVisualCreator](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual_creator.html) | [AgentVisualCreator](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ab168357ed1cbfd7ab67de459d44b0a84) |
| float | [MissionCloseTimeAfterFinish](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aa8f98e82ee900cc123528888992bae98) = 30.0f |
| float | [NextCheckTimeEndMission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a1deb5acd96e62413f2a36a52fdc893f4) = 10.0f |
|  | [Time](class_tale_worlds_1_1_engine_1_1_time.html) in seconds for specifying the next check for the conditions of ending the current mission. |
| int | [NumOfFormationsSpawnedTeamOne](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#acd3aa774e3773eadbdf89c87674524d8) |
| int | [NumOfFormationsSpawnedTeamTwo](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a17c11ffda91423d9d229e7da2d641dd6) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const int | [MaxRuntimeMissionObjects](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a7db3ac61baa64f23ab1fb609121a3a61) = 8191 |
| const int | [MaxNavMeshId](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a283dce3fd3e5f738fcfd28f938c0decc) = 1000000 |
| const int | [MaxDamage](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a936c40e498722db2f74aaf1305b9ec77) = 2000 |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsFinalized](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#addd10e6a6f4095a364d9d287996b6501) `[get]` |
| static [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#adfc400efb4da1f8dfb2cffaa4fbb4758) | [Current](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a9a140f1e4f9e4ca1f10fabd0d12b59ef) `[get]` |
| string | [SceneName](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ab12c35ce30bf7b753bd42833815542fa) `[get]` |
| string | [SceneLevels](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a5c1dc1af88878a185d14a0e97450f664) `[get]` |
| float | [DamageToPlayerMultiplier](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ac6df464ade2bb3cda0e12f944f405fc6) `[get]` |
| float | [DamageToFriendsMultiplier](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a93d82175778f35b1b29a4ce0bca6d435) `[get]` |
| float | [DamageFromPlayerToFriendsMultiplier](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#adfcd52e15a9d3297de7dcafbf07a4f9e) `[get]` |
| bool | [HasValidTerrainType](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a94774624ee03619222153661d065f904) `[get]` |
| [TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) | [TerrainType](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a6ac3565cd204feeebfb48114d8f68619) `[get]` |
| Scene | [Scene](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aa7953b48f8546ffd927bef0ab2a2ec9b) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [CustomCameraTargetLocalOffset](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#af6b5cd417713e3ec4294e00078361031) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [CustomCameraLocalOffset](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aff9badeb47a90fdec66e6aa6fc7dd02c) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [CustomCameraLocalOffset2](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#afae1af8871222b960faff838abc20c3d) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [CustomCameraGlobalOffset](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a19ce83bb8518a56e2d44d07f50a5e322) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [CustomCameraLocalRotationalOffset](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#acc5491efd78758aa1b10eaf3b459136f) `[get]` |
| bool | [CustomCameraIgnoreCollision](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a618b3696c10938348df8f6bd2891daf3) `[get]` |
| float | [CustomCameraFovMultiplier](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#adf371c41b8c37468e038722f2a693f03) = 1.0f `[get]` |
| float | [CustomCameraFixedDistance](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ab6617e724707d4032ca9a528150aca97) = float.MinValue `[get]` |
| float | [ListenerAndAttenuationPosBlendFactor](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a547be88ba6b01842133a4e28f1906ac8) = 0.0f `[get]` |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [IgnoredEntityForCamera](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a41bbc61c925efd6de3bd4bb4f8c95919) `[get]` |
| MBReadOnlyList< [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) > | [ActiveMissionObjects](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a203528a59bd6c04a3530d94f12bf9c59) `[get]` |
| MBReadOnlyList< [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) > | [MissionObjects](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a7ad29b0d05914af5e744890d41176ac9) `[get]` |
| MBReadOnlyList< [DynamicallyCreatedEntity](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_dynamically_created_entity.html) > | [AddedEntitiesInfo](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#affc0a1daf19aa31bb58f568d7a6105ef) `[get]` |
| [MBBoundaryCollection](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_m_b_boundary_collection.html) | [Boundaries](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#af9c79fcf2fca5f07cf58bf8250a753e8) `[get]` |
| bool | [IsMainAgentObjectInteractionEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a699738b09ba8bdafe0411ad742640725) `[get, set]` |
| bool | [IsMainAgentItemInteractionEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aa9f15f4d8dbc127d77f1938cb94a4ec8) `[get, set]` |
| bool | [IsTeleportingAgents](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ac55809612447ef1e66c403c72ed047a0) `[get, set]` |
| bool | [ForceTickOccasionally](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a6fe930eb6033dc12cd5c93c11d130888) `[get, set]` |
|  | Should be used when mission is paused but occasional ticks need to be ticked. |
| [MissionCombatType](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a2d209a484eef9303f04737652fa2602d) | [CombatType](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a7c8092e09a05e1461fd5f9d9862f1dcd) `[get, set]` |
| [MissionMode](namespace_tale_worlds_1_1_core.html#a34f0ac611df16851fc92e4523aa834e1) | [Mode](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#af168e23366b26a92cc7e239cb46646b0) `[get]` |
| float | [CurrentTime](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a40cb5ef2062b0cd500813aa5b348591a) `[get]` |
|  | Gets the current mission time. |
| bool | [PauseAITick](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aa0956ff8ef3f77c8fa8afed9df984b5e) `[get, set]` |
| bool | [IsLoadingFinished](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a2791b3aca0b1e7039f44bd08560c0b45) `[get]` |
| bool | [CameraIsFirstPerson](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a963ec247adf3fb03badee5fdba5f14a6) `[get, set]` |
| static float | [CameraAddedDistance](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a1fbd240b434444f2f392fbda7802a261) `[get, set]` |
| float | [ClearSceneTimerElapsedTime](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#adf7b8e418807ccf326de411007ae6e4c) `[get]` |
| MBReadOnlyList< [Missile](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_missile.html) > | [MissilesList](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a3a71fa12c5d93dc14318f7aff418b4e2) `[get]` |
| bool | [MissionEnded](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a53768f31eca7b26479af5d4f2152d32a) `[get]` |
| MBReadOnlyList< KeyValuePair< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), [MissionTime](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_time.html) > > | [MountsWithoutRiders](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a3fb05eac34e142f3d7202e6660c91f9e) `[get]` |
| bool | [MissionIsEnding](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a5cf4d6165a46c604d6f6016fff0c9c3b) = false `[get]` |
| bool | [IsDeploymentFinished](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aed6523d05551bab58f008c42755cdbe3) = false `[get]` |
| [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | [RetreatSide](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ab90f532e45e896eca2ae851432573356) = BattleSideEnum.None `[get]` |
| bool | [IsFastForward](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a8fcb6bdedeb6f3d645f923b02a47a3dd) `[get]` |
| bool | [FixedDeltaTimeMode](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ad9e533224b2444e8ff8166e08294a92a) `[get, set]` |
| float | [FixedDeltaTime](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aef779fbc7d0e2808362b59efec242e0c) `[get, set]` |
| [State](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a09888b586108ef6c430ecc8fed801f9d) | [CurrentState](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a3b8484111a0833d21284ef4a8dbf72fc) `[get]` |
| [TeamCollection](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_team_collection.html) | [Teams](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a96674c3f79024f5190b7d7ac867c0246) `[get]` |
| [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | [AttackerTeam](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ade2c0c1c8ceb6acc96af90a93f486676) `[get]` |
| [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | [DefenderTeam](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a7cc9700dc60c3ad6564601b362a45de4) `[get]` |
| [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | [AttackerAllyTeam](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ab70b65b0dedfcd72015be223f6bebc0c) `[get]` |
| [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | [DefenderAllyTeam](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ac2da4e17578e49d6db101730e56427de) `[get]` |
| [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | [PlayerTeam](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a3ba0208253e209b330fe82d1d627ac2c) `[get, set]` |
| [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | [PlayerEnemyTeam](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a9266b530fc6cc3d7cf0d8c894cbe38c9) `[get]` |
| [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | [PlayerAllyTeam](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a82a6e9499ecdb85cda68b72eecf9070b) `[get]` |
| [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | [SpectatorTeam](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ad5d2fce75f936e955f7e0614a1b2e992) `[get, set]` |
| bool | [IsMissionEnding](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a292d2ad3fdfa4e916d642bb2a10c0734) `[get]` |
| List< [MissionLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html) > | [MissionLogics](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a9f171f1ba98ccde589cf32560fad0219) `[get]` |
| List< [MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html) > | [MissionBehaviors](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ae6b2124209c49b3194106e9a0032cad5) `[get]` |
| [IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html) | [InputManager](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a2bd1d47adfb32f556f571f04af15a9ab) `[get, set]` |
| bool | [NeedsMemoryCleanup](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ad82455bfa2fad92e9abd7a1b8e04ef18) `[get]` |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [MainAgent](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ad783055c6c702d393b66cd52f165c9ee) `[get, set]` |
|  | Main agent that player controls. |
| [IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html) | [DeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ae9e1da6580032b1b6d0da07ec33d5a63) `[get]` |
| bool | [IsBattleSpawnPathSelectorInitialized](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a944797a3874e40c2e3cef462b12191d9) `[get]` |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [MainAgentServer](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a7080497cc38f8be6ec2aa627b7f9bbad) `[get, set]` |
| bool | [HasSpawnPath](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a3104ec5e99bfc27dc8d0bcc15e95ca04) `[get]` |
| bool | [IsFieldBattle](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a26171bb035eefd79932046877507b965) `[get]` |
| bool | [IsSiegeBattle](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a651852bebc89a464fe0a1397dcbf5633) `[get]` |
| bool | [IsSallyOutBattle](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a4866ab49d5f6ba2cd9322d72a6c8b5fd) `[get]` |
| bool | [IsNavalBattle](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a66050e6c40112ac57b49efb1941e4e06) `[get]` |
| [AgentReadOnlyList](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_agent_read_only_list.html) | [AllAgents](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a2189f352056607ad99729ddf7f71a75e) `[get]` |
| [AgentReadOnlyList](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_agent_read_only_list.html) | [Agents](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a4344427bdd332a84d8f9ac5f77134a94) `[get]` |
|  | Agents that have been loaded in the current mission. |
| bool | [IsInventoryAccessAllowed](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ae0799693ee2962ea2a5c163a0cf543fd) `[get]` |
| bool | [IsInventoryAccessible](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a95b1f09de1288d988e73a52d492ec999) `[set]` |
|  | Prerequisite for [IsInventoryAccessAllowed](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ae0799693ee2962ea2a5c163a0cf543fd). |
| MissionResult | [MissionResult](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a262de0372bcaadc609e53e5be83972dc) `[get]` |
| [MissionFocusableObjectInformationProvider](class_tale_worlds_1_1_mount_and_blade_1_1_mission_focusable_object_information_provider.html) | [FocusableObjectInformationProvider](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a4f2c55e8a5c303e1373a8c7a81512bd0) `[get]` |
| bool | [IsQuestScreenAccessible](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aed78dce90af02c0a65955c1c9af3844b) `[set]` |
| bool | [IsQuestScreenAccessAllowed](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a5e8028aae4551c6b5a3fe3109be716fe) `[get]` |
| bool | [IsCharacterWindowAccessible](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ab606ce2911ebf94cd6cda57e3f28a328) `[set]` |
| bool | [IsCharacterWindowAccessAllowed](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ace57ed02c4bb5dad93940de18b48af32) `[get]` |
| bool | [IsPartyWindowAccessible](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ad752147735c600d44fbef937d794d210) `[set]` |
| bool | [IsPartyWindowAccessAllowed](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a0824972a61ada9b23d04dff8183b1741) `[get]` |
| bool | [IsKingdomWindowAccessible](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#acaa435b342b3c9dd011368c8b4540e31) `[set]` |
| bool | [IsKingdomWindowAccessAllowed](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a9ad7275ca1109ec33193169aabd604d6) `[get]` |
| bool | [IsClanWindowAccessible](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a3a6e9dced913fbe93df074bb50cc11ec) `[set]` |
| bool | [IsClanWindowAccessAllowed](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aa0b018b46bb49efe3dfc835ee228f497) `[get]` |
| bool | [IsEncyclopediaWindowAccessible](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a785f0425f82f1de3aa7a0bb320c04158) `[set]` |
| bool | [IsEncyclopediaWindowAccessAllowed](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a175cb588eed72e473fd52482eddf6310) `[get]` |
| bool | [IsBannerWindowAccessible](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#af731da3c6b984348cefef43dd7a80321) `[set]` |
| bool | [IsBannerWindowAccessAllowed](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a271dc10b8cdf38f5c8dc836980dd2055) `[get]` |
| bool? | [DoesMissionRequireCivilianEquipment](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a82b5b9b9661ccc987ebb7b8118bc7b2a) `[get, set]` |
|  | Set this to true in missions that require civillian equipment. (For example town missions, back alley missions etc.) This is required to be set before behavior initialization in order to avoid preloading of any civillian gear into the missions. For example one can override OnCreated() callback of mission behavior to set this. |
| [MissionTeamAITypeEnum](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#abaf2994f3d6a2d3282a79078c16c2bfe) | [MissionTeamAIType](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a872f5c8f04fb293048c650c57de0ba82) `[get, set]` |
| [MissionRecorder](class_tale_worlds_1_1_mount_and_blade_1_1_mission_recorder.html) | [Recorder](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a818740c7002ee8eed888e54df38a30ed) `[get]` |
| bool | [CanPlayerTakeControlOfAnotherAgentWhenDead](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#acf5fdb02b634efe752f3b910ff0cde13) `[get]` |
| MissionTimeTracker | [MissionTimeTracker](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ae84cb369eab061ddce00b59a73d7c446) `[get]` |

|  |  |
| --- | --- |
| Events | |
| System.ComponentModel.PropertyChangedEventHandler | [OnMissionReset](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a159dbbaa0ed788bd0186f0246c7cdf00) |
| [OnBeforeAgentRemovedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a92ec14adf8994c29e1f782be658f5a5a) | [OnBeforeAgentRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a08bdc349fea6e8fb3bd4eb1ead4448ae) |
| Func< [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html), [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html), bool > | [IsFormationUnitPositionAvailable\_AdditionalCondition](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aabe7e21cf00bc3c31826bddf2c620a5a) |
| Func< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), bool > | [CanAgentRout\_AdditionalCondition](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a68cf27f3ac809c7792e423be5b5f9ec5) |
| [OnAddSoundAlarmFactorToAgentsDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#acc03845f8ec54d33daa5cd63d309a73b) | [OnAddSoundAlarmFactorToAgents](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a780b20a0d6e0b662e53e8724ca20b1bf) |
| Func< bool > | [IsAgentInteractionAllowed\_AdditionalCondition](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a9b535532029f8ee00385d27380315233) |
| [OnMainAgentChangedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ae158b35a2eb37fcf6aab7e03efa53df0) | [OnMainAgentChanged](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#afb2c69d4aa9a157023741cd1f483551c) |
| [ComputeTroopBodyPropertiesDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a8313f05ca1c550498be0554af2e13335) | [OnComputeTroopBodyProperties](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aeeca9c95101a65a843e84be5264dc393) |
| Func< [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c), [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html), [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) > | [GetAgentTroopClass\_Override](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a07ec32a0d8f5d7f718002483457ede6f) |
| Action< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), [SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html) > | [OnItemPickUp](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a6635a1d313eaaf46aabf22dc893b2d8f) |
| Action< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), [SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html) > | [OnItemDrop](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a3d33c4a300b0cbc25be74f26ed19ec64) |
| Action< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > | [FormationCaptainChanged](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a889763d0c9da5c6382ba77305b5d2c8f) |
| Func< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html)?> | [GetOverriddenFleePositionForAgent](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a21b800e5edc64254e1c95ba3abc2ab89) |
| Func< bool > | [AreOrderGesturesEnabled\_AdditionalCondition](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#abd5f2d23392b8a4b5921b4bd64d09e38) |
| Func< bool > | [IsBattleInRetreatEvent](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a37da117010925d208200cfaddef8b8eb) |
| Action< int > | [OnMissileRemovedEvent](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a89dc767a01e311bfecf10c96744645d2) |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a13b99667142577320096a9f09f129f63)WeaponSpawnFlags
-------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.Mission.WeaponSpawnFlags](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a13b99667142577320096a9f09f129f63) : uint |

| Enumerator | |
| --- | --- |
| None |  |
| WithHolster |  |
| WithoutHolster |  |
| AsMissile |  |
| WithPhysics |  |
| WithStaticPhysics |  |
| UseAnimationSpeed |  |
| CannotBePickedUp |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a2d209a484eef9303f04737652fa2602d)MissionCombatType
--------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.Mission.MissionCombatType](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a2d209a484eef9303f04737652fa2602d) : int |

| Enumerator | |
| --- | --- |
| Combat | Normal combat type. |
| ArenaCombat | Arena combat type. |
| NoCombat | No combat in the mission. |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a4e0efc500dfb2fe7ca70dfb58ff7e1c5)BattleSizeType
-----------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.Mission.BattleSizeType](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a4e0efc500dfb2fe7ca70dfb58ff7e1c5) |

| Enumerator | |
| --- | --- |
| Battle |  |
| Siege |  |
| SallyOut |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a09888b586108ef6c430ecc8fed801f9d)State
--------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.Mission.State](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a09888b586108ef6c430ecc8fed801f9d) |

| Enumerator | |
| --- | --- |
| NewlyCreated |  |
| Initializing |  |
| Continuing |  |
| EndingNextFrame |  |
| Over |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aa88817ab1e39e376b791dbc915bcc1c5)BattleSizeQualifier
----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.Mission.BattleSizeQualifier](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aa88817ab1e39e376b791dbc915bcc1c5) |

| Enumerator | |
| --- | --- |
| Small |  |
| Medium |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#abaf2994f3d6a2d3282a79078c16c2bfe)MissionTeamAITypeEnum
------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.Mission.MissionTeamAITypeEnum](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#abaf2994f3d6a2d3282a79078c16c2bfe) |

| Enumerator | |
| --- | --- |
| NoTeamAI |  |
| FieldBattle |  |
| Siege |  |
| SallyOut |  |
| NavalBattle |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a235275d0a4fd9f604f19aaaf6943e494)MissileCollisionReaction
---------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.Mission.MissileCollisionReaction](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a235275d0a4fd9f604f19aaaf6943e494) |

| Enumerator | |
| --- | --- |
| Invalid |  |
| Stick |  |
| PassThrough |  |
| BounceBack |  |
| BecomeInvisible |  |
| Count |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aeaac3485578af13b00618383e6f0264e)MissionTickAction
--------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.Mission.MissionTickAction](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aeaac3485578af13b00618383e6f0264e) |

| Enumerator | |
| --- | --- |
| TryToSheathWeaponInHand |  |
| RemoveEquippedWeapon |  |
| TryToWieldWeaponInSlot |  |
| DropItem |  |
| RegisterDrownBlow |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#adfc400efb4da1f8dfb2cffaa4fbb4758)Mission()
------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.Mission.Mission | ( | [MissionInitializerRecord](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html) | *rec*, |
|  |  | [MissionState](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html) | *missionState*, |
|  |  | bool | *needsMemoryCleanup* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#add3c8fe5288aa1616067590c8ecd82a5)GetActiveEntitiesWithScriptComponentOfType< T >()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) > TaleWorlds.MountAndBlade.Mission.GetActiveEntitiesWithScriptComponentOfType< T > | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a3808db7dce9772b867fbb8baf09bc46c)AddActiveMissionObject()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.AddActiveMissionObject | ( | [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | *missionObject* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#af5099d99a8d5b7c7dc24449bd431cd2a)ActivateMissionObject()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.ActivateMissionObject | ( | [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | *missionObject* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a347a1d416740275d3902cd51067ecbc4)DeactivateMissionObject()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.DeactivateMissionObject | ( | [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | *missionObject* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#af55f8d8154425ee704c361f0812bb372)SetMissionCombatType()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.SetMissionCombatType | ( | [MissionCombatType](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a2d209a484eef9303f04737652fa2602d) | *missionCombatType* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a31721342b0e5b8365fc98a2b18128de0)ConversationCharacterChanged()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.ConversationCharacterChanged | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aec2afab7c5dad2ecdce415494c96f3fa)SetMissionMode()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.SetMissionMode | ( | [MissionMode](namespace_tale_worlds_1_1_core.html#a34f0ac611df16851fc92e4523aa834e1) | *newMode*, |
|  |  | bool | *atStart* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ace924e29975e9c3d454db6d2ecc703a4)GetAverageFps()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Mission.GetAverageFps | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#af5d09e64d929a4d67a81495b3d825729)GetFallAvoidSystemActive()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Mission.GetFallAvoidSystemActive | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a6f2249bba7b12262caa9351e04990d17)SetFallAvoidSystemActive()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.SetFallAvoidSystemActive | ( | bool | *fallAvoidActive* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ad21c639684758e663af6a494b18b02f2)IsPositionInsideBoundaries()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Mission.IsPositionInsideBoundaries | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | position |  |

Returns

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aa7e1c76655e2e2e41fd529f73f112ed6)IsPositionInsideHardBoundaries()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Mission.IsPositionInsideHardBoundaries | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a4757ee726a28cc8aba099f49a36d61ac)IsPositionInsideAnyBlockerNavMeshFace2D()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Mission.IsPositionInsideAnyBlockerNavMeshFace2D | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a1dd2827a8549eacc526b17b0af9b5e03)IsPositionOnAnyBlockerNavMeshFace()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Mission.IsPositionOnAnyBlockerNavMeshFace | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a704eb891e031b138d8699e2a602a2cde)RayCastForClosestAgent()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) TaleWorlds.MountAndBlade.Mission.RayCastForClosestAgent | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *sourcePoint*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *targetPoint*, |
|  |  | int | *excludedAgentIndex*, |
|  |  | float | *rayThickness*, |
|  |  | out float | *collisionDistance* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a0f550523ea29371d5b0f00f1b8e5abb6)RayCastForClosestAgentsLimbs()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) TaleWorlds.MountAndBlade.Mission.RayCastForClosestAgentsLimbs | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *sourcePoint*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *targetPoint*, |
|  |  | int | *excludedAgentIndex*, |
|  |  | float | *rayThickness*, |
|  |  | out float | *collisionDistance*, |
|  |  | out sbyte | *boneIndex* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a54b0769971691f19390039e0a9f5d25b)RayCastForGivenAgentsLimbs()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Mission.RayCastForGivenAgentsLimbs | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *sourcePoint*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *rayFinishPoint*, |
|  |  | int | *givenAgentIndex*, |
|  |  | float | *rayThickness*, |
|  |  | out float | *collisionDistance*, |
|  |  | out sbyte | *boneIndex* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#af152fc3724e78abfa96df4c4eedeeb30)GetBiggestAgentCollisionPadding()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Mission.GetBiggestAgentCollisionPadding | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a395a9b2b99bdf97c70756c36c04dff40)SetMissionCorpseFadeOutTimeInSeconds()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.SetMissionCorpseFadeOutTimeInSeconds | ( | float | *corpseFadeOutTimeInSeconds* | ) |  |

Set to -1 to disable the override and use the default value.

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#af8874ecb122448dccdc9a93670b82c9c)SetOverrideCorpseCount()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.SetOverrideCorpseCount | ( | int | *overrideCorpseCount* | ) |  |

Set to -1 to disable the override and use the value from config.

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aa2d62703b6cb0ae4f1bfc583164cecdc)SetReportStuckAgentsMode()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.SetReportStuckAgentsMode | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a03868ea4754f852e2f456c6a79f31a3a)ResetMission()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.ResetMission | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a2479938012a123e62f6b47ca25b26a30)Initialize()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.Initialize | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a2abae4c06e93f628a4ea1f12a9b06a9a)TickAgentsAndTeamsAsync()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.TickAgentsAndTeamsAsync | ( | float | *dt* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aceffa04e390ed1ff43f43b931a858dd5)MakeSound() [1/2]
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.MakeSound | ( | int | *soundIndex*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position*, |
|  |  | bool | *soundCanBePredicted*, |
|  |  | bool | *isReliable*, |
|  |  | int | *relatedAgent1*, |
|  |  | int | *relatedAgent2* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a487b57dd2772de7564e74a5781257781)MakeSound() [2/2]
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.MakeSound | ( | int | *soundIndex*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position*, |
|  |  | bool | *soundCanBePredicted*, |
|  |  | bool | *isReliable*, |
|  |  | int | *relatedAgent1*, |
|  |  | int | *relatedAgent2*, |
|  |  | ref [SoundEventParameter](struct_tale_worlds_1_1_engine_1_1_sound_event_parameter.html) | *parameter* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a77d5c7dca45a7067b8bceb85e4f5b621)MakeSoundOnlyOnRelatedPeer()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.MakeSoundOnlyOnRelatedPeer | ( | int | *soundIndex*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position*, |
|  |  | int | *relatedAgent* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a5005488478b9ef0b6864f18b00fa63af)AddDynamicallySpawnedMissionObjectInfo()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.AddDynamicallySpawnedMissionObjectInfo | ( | [DynamicallyCreatedEntity](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_dynamically_created_entity.html) | *entityInfo* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#afa37694f604b5ebdc956f9ac6814fab7)GetMissileCollisionPoint()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.Mission.GetMissileCollisionPoint | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *missileStartingPosition*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *missileDirection*, |
|  |  | float | *missileSpeed*, |
|  |  | in [WeaponData](struct_tale_worlds_1_1_mount_and_blade_1_1_weapon_data.html) | *weaponData* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a01b2488226358e563267324019ece076)RemoveMissileAsClient()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.RemoveMissileAsClient | ( | int | *missileIndex* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aac6d6827a48a5467ed244c8cf862aab8)GetMissileVerticalAimCorrection()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.Mission.GetMissileVerticalAimCorrection | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *vecToTarget*, | |  |  | float | *missileStartingSpeed*, | |  |  | ref [WeaponStatsData](struct_tale_worlds_1_1_mount_and_blade_1_1_weapon_stats_data.html) | *weaponStatsData*, | |  |  | float | *airFrictionConstant* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a365373462b04b9caf77ea6eb0e115c29)GetMissileRange()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.Mission.GetMissileRange | ( | float | *missileStartingSpeed*, | |  |  | float | *heightDifference* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a41c8e2de4d5ebdce92f477030a2a1752)PrepareMissileWeaponForDrop()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.PrepareMissileWeaponForDrop | ( | int | *missileIndex* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ada61bffb03d0324a656162313d364849)AddParticleSystemBurstByName()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.AddParticleSystemBurstByName | ( | string | *particleSystem*, |
|  |  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame*, |
|  |  | bool | *synchThroughNetwork* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a4dff2e92389a31325671b78e7577e297)GetClosestBoundaryPosition()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.Mission.GetClosestBoundaryPosition | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ae2ee69525d2f7727de18e74110479d80)GetFreeRuntimeMissionObjectId()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.Mission.GetFreeRuntimeMissionObjectId | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ac330c1fa4d60d57fd20b1195fdf9b134)GetFreeSceneMissionObjectId()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.Mission.GetFreeSceneMissionObjectId | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a74ff3f122ea6162ec048432684cfd9d5)SetCameraFrame() [1/2]
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.SetCameraFrame | ( | ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *cameraFrame*, |
|  |  | float | *zoomFactor* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aab13c291bab5b3e8ab8130214431ef4c)SetCameraFrame() [2/2]
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.SetCameraFrame | ( | ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *cameraFrame*, |
|  |  | float | *zoomFactor*, |
|  |  | ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *attenuationPosition* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a53106e6003335cd67db28ad446b816dd)GetCameraFrame()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.Mission.GetCameraFrame | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ac9ea4e73b8522ed0a065f740e0cc4c2d)ResetFirstThirdPersonView()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.ResetFirstThirdPersonView | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aa0c4239057aa3c59e6b6a449a073244d)SetCustomCameraLocalOffset()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.SetCustomCameraLocalOffset | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *newCameraOffset* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a726a48b193493d84589d49dbf3341ac4)SetCustomCameraTargetLocalOffset()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.SetCustomCameraTargetLocalOffset | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *newTargetLocalOffset* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ad3212d0ceea59eca6a7e6588a663686a)SetCustomCameraLocalOffset2()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.SetCustomCameraLocalOffset2 | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *newCameraOffset* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#abedbf126781aa8bf96c538121c9160a8)SetCustomCameraLocalRotationalOffset()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.SetCustomCameraLocalRotationalOffset | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *newCameraRotationalOffset* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#af00fed51550fd77ae6648220f5411811)SetCustomCameraGlobalOffset()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.SetCustomCameraGlobalOffset | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *newCameraOffset* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a9c7a4d298495f73e8cc4d82c99935430)SetCustomCameraFovMultiplier()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.SetCustomCameraFovMultiplier | ( | float | *newFovMultiplier* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a5eba433d287fb23cb5a5f1b92e9571fb)SetCustomCameraFixedDistance()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.SetCustomCameraFixedDistance | ( | float | *distance* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a6dcf0b6cf2f4b18b2bb59ca202d941f0)SetIgnoredEntityForCamera()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.SetIgnoredEntityForCamera | ( | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *ignoredEntity* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ab09f4cd83ccf9bea0625492df1120e2e)SetCustomCameraIgnoreCollision()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.SetCustomCameraIgnoreCollision | ( | bool | *ignoreCollision* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ad53eb76118c0cd4777713d0e920d555e)SetListenerAndAttenuationPosBlendFactor()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.SetListenerAndAttenuationPosBlendFactor | ( | float | *factor* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aa76d73175f176044b088f760abdf5968)AddTimeSpeedRequest()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.AddTimeSpeedRequest | ( | [TimeSpeedRequest](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_time_speed_request.html) | *request* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a4bb549fe59cc632cb13f4120c36804f5)RemoveTimeSpeedRequest()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.RemoveTimeSpeedRequest | ( | int | *timeSpeedRequestID* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ae1d92449e78a79a52bd8612a8d311817)GetRequestedTimeSpeed()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Mission.GetRequestedTimeSpeed | ( | int | *timeSpeedRequestID*, |
|  |  | out float | *requestedTime* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ac643df653bb179421cdf258eb9fa14f7)ClearAgentActions()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.ClearAgentActions | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a98758d684d360f461921fc4dab52d72c)ClearMissiles()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.ClearMissiles | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aed614f5fe20b2b65ec41ba5a6d38bc82)ClearCorpses()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.ClearCorpses | ( | bool | *isMissionReset* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a37e566bfd44470f006cb260e0a3310e6)IsAgentInProximityMap()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Mission.IsAgentInProximityMap | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ab3e9046a20b6c745cabbb18bf2edd47e)OnMissionStateActivate()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.OnMissionStateActivate | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a3c0814ce6e27b3741c7406392c70ea4a)OnMissionStateDeactivate()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.OnMissionStateDeactivate | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a21b47d7f7d6195c5537728ae86b11749)OnMissionStateFinalize()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.OnMissionStateFinalize | ( | bool | *forceClearGPUResources* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | forceClearGPUResources |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aba5b07d95b5b70b8974e9b4df02397cc)ClearUnreferencedResources()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.ClearUnreferencedResources | ( | bool | *forceClearGPUResources* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a6a1b23b99af6477bb44ce43f1d00dc10)GetMainAgentMaxCameraZoom()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Mission.GetMainAgentMaxCameraZoom | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a6ca2d8c89429973ac43b104b3843dc08)GetBestSlopeTowardsDirection()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) TaleWorlds.MountAndBlade.Mission.GetBestSlopeTowardsDirection | ( | ref [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *centerPosition*, |
|  |  | float | *halfSize*, |
|  |  | ref [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *referencePosition* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a7dc783885e0b7fac5c19a88cd96aeb54)GetBestSlopeAngleHeightPosForDefending()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) TaleWorlds.MountAndBlade.Mission.GetBestSlopeAngleHeightPosForDefending | ( | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *enemyPosition*, |
|  |  | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *defendingPosition*, |
|  |  | int | *sampleSize*, |
|  |  | float | *distanceRatioAllowedFromDefendedPos*, |
|  |  | float | *distanceSqrdAllowedFromBoundary*, |
|  |  | float | *cosinusOfBestSlope*, |
|  |  | float | *cosinusOfMaxAcceptedSlope*, |
|  |  | float | *minSlopeScore*, |
|  |  | float | *maxSlopeScore*, |
|  |  | float | *excessiveSlopePenalty*, |
|  |  | float | *nearConeCenterRatio*, |
|  |  | float | *nearConeCenterBonus*, |
|  |  | float | *heightDifferenceCeiling*, |
|  |  | float | *maxDisplacementPenalty* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a9c894b7fc1191f51b73ae05f041e0db1)GetAveragePositionOfAgents()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.Mission.GetAveragePositionOfAgents | ( | List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | *agents* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ab382f22be6a3d3e15f1973885ff8d339)SetRandomDecideTimeOfAgentsWithIndices()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.SetRandomDecideTimeOfAgentsWithIndices | ( | int[] | *agentIndices*, |
|  |  | float? | *minAIReactionTime* = null, |
|  |  | float? | *maxAIReactionTime* = null ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#af620893f20b479b9dda13428a73d1803)SetBowMissileSpeedModifier()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.SetBowMissileSpeedModifier | ( | float | *modifier* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ac46f7ec4867aac3d0c9fd85f3ad6e546)SetCrossbowMissileSpeedModifier()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.SetCrossbowMissileSpeedModifier | ( | float | *modifier* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a9d8dbbc95a22e1c718e7e3ecc17f3f89)SetThrowingMissileSpeedModifier()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.SetThrowingMissileSpeedModifier | ( | float | *modifier* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a237a757ecf9c72aee1aa986f0a1a81ea)SetMissileRangeModifier()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.SetMissileRangeModifier | ( | float | *modifier* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a0160bdbf199081bdc705f4a928f1206f)SetLastMovementKeyPressed()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.SetLastMovementKeyPressed | ( | [Agent.MovementControlFlag](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a81bece812eef7b0170864a38f387e797) | *lastMovementKeyPressed* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a6d36564352771c05f7442838f1e39944)GetWeightedPointOfEnemies()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.Mission.GetWeightedPointOfEnemies | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *basePoint* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a6e9f74c8d717b0bdf27df3b3d768d2ff)GetPathBetweenPositions()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Mission.GetPathBetweenPositions | ( | ref [NavigationData](struct_tale_worlds_1_1_mount_and_blade_1_1_navigation_data.html) | *navData* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ab14091a3255e2db5ff347be35bff8952)SetNavigationFaceCostWithIdAroundPosition()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.SetNavigationFaceCostWithIdAroundPosition | ( | int | *navigationFaceId*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position*, |
|  |  | float | *cost* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a2f59a2ee0457dc49f7670c389643ae71)GetStraightPathToTarget()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) TaleWorlds.MountAndBlade.Mission.GetStraightPathToTarget | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *targetPosition*, |
|  |  | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *startingPosition*, |
|  |  | float | *samplingDistance* = 1f, |
|  |  | bool | *stopAtObstacle* = true ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a30e2d9a10a5e8545948af437b73a8464)SkipForwardMissionReplay()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.SkipForwardMissionReplay | ( | float | *startTime*, |
|  |  | float | *endTime* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a7f04c606f2afb66932e8633c2baa0676)GetDebugAgent()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.Mission.GetDebugAgent | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a14210ed556464c0383942543e9cd01d2)AddAiDebugText()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.AddAiDebugText | ( | string | *str* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a42557be75f1452d0ec3a2a26cb0ef41d)SetDebugAgent()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.SetDebugAgent | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a11db8684b3a4ad91db7e1117d69c33ca)GetFirstPersonFov()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.Mission.GetFirstPersonFov | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a7361dc1a5e5197766fcdfc31bea5a052)GetWaterLevelAtPosition()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Mission.GetWaterLevelAtPosition | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position*, |
|  |  | bool | *useWaterRenderer* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a122a00549090157207f3e19ae389d98b)GetWaterLevelAtPositionMT()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Mission.GetWaterLevelAtPositionMT | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position*, |
|  |  | bool | *useWaterRenderer* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a7cc7b3a1aa4f7bf9d8335e7dedb3be52)CanPhysicsCollideBetweenTwoEntities()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Mission.CanPhysicsCollideBetweenTwoEntities | ( | UIntPtr | *entity0Ptr*, |
|  |  | UIntPtr | *entity1Ptr* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a92ec14adf8994c29e1f782be658f5a5a)OnBeforeAgentRemovedDelegate()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate void TaleWorlds.MountAndBlade.Mission.OnBeforeAgentRemovedDelegate | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *affectedAgent*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *affectorAgent*, |
|  |  | [AgentState](namespace_tale_worlds_1_1_core.html#a799bcc77ddb6372c7383f3340ed4d1c0) | *agentState*, |
|  |  | [KillingBlow](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html) | *killingBlow* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#acc03845f8ec54d33daa5cd63d309a73b)OnAddSoundAlarmFactorToAgentsDelegate()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate void TaleWorlds.MountAndBlade.Mission.OnAddSoundAlarmFactorToAgentsDelegate | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *alarmCreatorAgent*, |
|  |  | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *soundPosition*, |
|  |  | float | *soundLevelSquareRoot* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ae158b35a2eb37fcf6aab7e03efa53df0)OnMainAgentChangedDelegate()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| delegate void TaleWorlds.MountAndBlade.Mission.OnMainAgentChangedDelegate | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *oldAgent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a8313f05ca1c550498be0554af2e13335)ComputeTroopBodyPropertiesDelegate()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) TaleWorlds.MountAndBlade.Mission.ComputeTroopBodyPropertiesDelegate | ( | [AgentBuildData](class_tale_worlds_1_1_mount_and_blade_1_1_agent_build_data.html) | *agentBuildData*, |
|  |  | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *characterObject*, |
|  |  | [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) | *equipment*, |
|  |  | int | *seed* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a67e7bfabc08d34be5a4746c390c865e2)GetDeploymentPlan< T >()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Mission.GetDeploymentPlan< T > | ( | out T | *deploymentPlan* | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html)* |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aff19e379f95fae615e0e654a42226694)GetRemovedAgentRatioForSide()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Mission.GetRemovedAgentRatioForSide | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a085b4c96df0484efce6909a026f56661)GetAttackerWeaponsForFriendlyFirePreventing()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| ref readonly List< [SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html) > TaleWorlds.MountAndBlade.Mission.GetAttackerWeaponsForFriendlyFirePreventing | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a20e7ebcae092efc76cc94fd41b5b30d2)OnDeploymentPlanMade()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.OnDeploymentPlanMade | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, |
|  |  | bool | *isFirstPlan* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aa8e876f490a22e36cbbd148e57128fb6)GetAlternatePositionForNavmeshlessOrOutOfBoundsPosition()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) TaleWorlds.MountAndBlade.Mission.GetAlternatePositionForNavmeshlessOrOutOfBoundsPosition | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *directionTowards*, |
|  |  | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *originalPosition*, |
|  |  | ref float | *positionPenalty* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ae7ec33c2c1d9693818f82d45cd871a89)GetNextDynamicNavMeshIdStart()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.Mission.GetNextDynamicNavMeshIdStart | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a188c476feab8b00463811b130fb47030)GetAgentTroopClass()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) TaleWorlds.MountAndBlade.Mission.GetAgentTroopClass | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *battleSide*, |
|  |  | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *agentCharacter* ) |

Returns context (mission) dependent troop class for an agent character i.e. Mounted class can be forbidden in certain missions (such as siege missions). In such cases this should return their dismounted class correspondence.

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a2239b0a22bc33ba0ba0d4091c67ea05d)GetClosestFleePositionForAgent()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) TaleWorlds.MountAndBlade.Mission.GetClosestFleePositionForAgent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a0ef302300a6df3f4f610561d343e651b)GetClosestFleePositionForFormation()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) TaleWorlds.MountAndBlade.Mission.GetClosestFleePositionForFormation | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a77b5d8baeda1ed68cbbf95f9b0db8f57)GetFleePositionsForSide()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| MBReadOnlyList< [FleePosition](class_tale_worlds_1_1_mount_and_blade_1_1_flee_position.html) > TaleWorlds.MountAndBlade.Mission.GetFleePositionsForSide | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a79837579468bf2162fc136aab5309438)AddToWeaponListForFriendlyFirePreventing()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.AddToWeaponListForFriendlyFirePreventing | ( | [SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html) | *weapon* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aeced4ce28c04d2c73bd7d108ee1ec2a5)SetCloseProximityWaveSoundsEnabled()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.SetCloseProximityWaveSoundsEnabled | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a6cdb89540bc0425e1b3170aa9fe4d6d3)ForceDisableOcclusion()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.ForceDisableOcclusion | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#acb4888a52258f725d2027cb4f61dec32)AddFleePosition()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.AddFleePosition | ( | [FleePosition](class_tale_worlds_1_1_mount_and_blade_1_1_flee_position.html) | *fleePosition* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a970c16c53d16a11ad7e7909764a58bb7)RetreatMission()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.RetreatMission | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a360527ae0599849bad9f36fb38286ec8)SurrenderMission()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.SurrenderMission | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a0d56f7829a8f63978946d323c6753328)HasMissionBehavior< T >()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Mission.HasMissionBehavior< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html)* |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a292b0040f8ce65309da9fa4121a1d340)SpawnAttachedWeaponOnCorpse()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html) TaleWorlds.MountAndBlade.Mission.SpawnAttachedWeaponOnCorpse | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | int | *attachedWeaponIndex*, |
|  |  | int | *forcedSpawnIndex* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a3483e60b9248aeb89abd244729d33ba2)AddMountWithoutRider()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.AddMountWithoutRider | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *mount* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a8aaba7b4e298b284cf7470c0715f3a11)RemoveMountWithoutRider()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.RemoveMountWithoutRider | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *mount* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ae696b14f4044047bf1a141e2a0c93de9)UpdateMountReservationsAfterRiderMounts()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.UpdateMountReservationsAfterRiderMounts | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *rider*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *mount* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#acc91dcc396cb2ca01ecac0f652dee549)OnObjectDisabled()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.OnObjectDisabled | ( | [DestructableComponent](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html) | *destructionComponent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ad1d3d2e5b7dd2ea85bb3137eea9aaacb)SpawnWeaponAsDropFromMissile()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [MissionObjectId](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_object_id.html) TaleWorlds.MountAndBlade.Mission.SpawnWeaponAsDropFromMissile | ( | int | *missileIndex*, |
|  |  | [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | *attachedMissionObject*, |
|  |  | in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *attachLocalFrame*, |
|  |  | [WeaponSpawnFlags](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a13b99667142577320096a9f09f129f63) | *spawnFlags*, |
|  |  | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *velocity*, |
|  |  | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *angularVelocity*, |
|  |  | int | *forcedSpawnIndex* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a3d1858bc3aca344855a9c556fd3005c7)SpawnWeaponAsDropFromAgentAux()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.SpawnWeaponAsDropFromAgentAux | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *equipmentIndex*, |
|  |  | ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *globalVelocity*, |
|  |  | ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *globalAngularVelocity*, |
|  |  | [WeaponSpawnFlags](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a13b99667142577320096a9f09f129f63) | *spawnFlags*, |
|  |  | int | *forcedSpawnIndex* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#af766a89d3caf901ff4ab3d75e9e65e5b)SpawnAttachedWeaponOnSpawnedWeapon()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.SpawnAttachedWeaponOnSpawnedWeapon | ( | [SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html) | *spawnedWeapon*, |
|  |  | int | *attachmentIndex*, |
|  |  | int | *forcedSpawnIndex* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a534160ed2f94baeb9efcbe1c5c57045a)SpawnWeaponWithNewEntity()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) TaleWorlds.MountAndBlade.Mission.SpawnWeaponWithNewEntity | ( | ref [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *weapon*, |
|  |  | [WeaponSpawnFlags](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a13b99667142577320096a9f09f129f63) | *spawnFlags*, |
|  |  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aa242dd0a3e7cb70c6c9c253781ba245b)SpawnWeaponWithNewEntityAux()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) TaleWorlds.MountAndBlade.Mission.SpawnWeaponWithNewEntityAux | ( | [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *weapon*, |
|  |  | [WeaponSpawnFlags](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a13b99667142577320096a9f09f129f63) | *spawnFlags*, |
|  |  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame*, |
|  |  | int | *forcedSpawnIndex*, |
|  |  | [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | *attachedMissionObject*, |
|  |  | bool | *hasLifeTime*, |
|  |  | bool | *spawnedOnACorpse* = false ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a0e33051558c959e6257d00ec0315439c)AttachWeaponWithNewEntityToSpawnedWeapon()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.AttachWeaponWithNewEntityToSpawnedWeapon | ( | [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *weapon*, |
|  |  | [SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html) | *spawnedItem*, |
|  |  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *attachLocalFrame* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a4f661a2dea06c5a85d3ab0f8d888150c)OnEquipItemsFromSpawnEquipmentBegin()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.OnEquipItemsFromSpawnEquipmentBegin | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | [Agent.CreationType](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a98ba61b43dff1b7e80a874e6d42a4938) | *creationType* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a3bfabf9681c8a69138e9aae7fd4073cb)OnEquipItemsFromSpawnEquipment()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.OnEquipItemsFromSpawnEquipment | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | [Agent.CreationType](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a98ba61b43dff1b7e80a874e6d42a4938) | *creationType* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a6aad51c1139eec04fc3c5d4c46a5bc85)GetCurrentVolumeGeneratorVersion()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.Mission.GetCurrentVolumeGeneratorVersion | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a8e0bbba2c2dee7afab390b6c7b78cda7)MakeEnemiesFleeCheat()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.Mission.MakeEnemiesFleeCheat | ( | List< string > | *strings* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aeeda361c0e002ec18564573a3ef0ad3b)MakeTeamFleeCheat()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.Mission.MakeTeamFleeCheat | ( | List< string > | *strings* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a168386afb35c2ee8014330259c02f00f)RecalculateBody()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.RecalculateBody | ( | ref [WeaponData](struct_tale_worlds_1_1_mount_and_blade_1_1_weapon_data.html) | *weaponData*, |
|  |  | [ItemComponent](class_tale_worlds_1_1_core_1_1_item_component.html) | *itemComponent*, |
|  |  | [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) | *craftedWeaponData*, |
|  |  | ref [WeaponSpawnFlags](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a13b99667142577320096a9f09f129f63) | *spawnFlags* ) |

* For swords, it will take the tip of the blade and move it up (scale along z-axis)
* For spears, it will take the tip of the shaft and move it up. It will also move the horizontal tip along the same axis
* For round shields, it will scale all points along the XZ-axis
* .. There are some weapons that will never be scaled:
* There are a couple of bodies for bows, they fit well enough without scaling
* Unique items like scythes and sickles will have unique bodies, they're just too different

IMPORTANT: When scaling capsules, make sure that the blade/shaft is the first bodypart in the list! The order is defined by the hierarchy in 3dsMax

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#acebb72451edf12daa56e49df56794d35)SetFacialAnimToAgent()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.Mission.SetFacialAnimToAgent | ( | List< String > | *strings* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a4558532dfe569f9c2f0c0c4569405b23)TickAgentsAndTeamsImp()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.TickAgentsAndTeamsImp | ( | float | *dt*, |
|  |  | bool | *tickPaused* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a5655fd2bc7570aad3983145182ddbfaa)EnableSpeedAdjustmentCommand()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.Mission.EnableSpeedAdjustmentCommand | ( | List< string > | *strings* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a5bb064ad6e41636241a7747aa96ff097)OnTick()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.OnTick | ( | float | *dt*, |
|  |  | float | *realDt*, |
|  |  | bool | *updateCamera*, |
|  |  | bool | *doAsyncAITick* ) |

Parameters
:   |  |  |
    | --- | --- |
    | dt | [Time](class_tale_worlds_1_1_engine_1_1_time.html) passed since the last call to OnTick. |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a22f2e53b454390e88c515a7ca336a7b8)AddTickAction()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.AddTickAction | ( | [MissionTickAction](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aeaac3485578af13b00618383e6f0264e) | *action*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | int | *param1*, |
|  |  | int | *param2* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a29588b4f6eb2f05e22e576ec44299d37)AddTickActionMT()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.AddTickActionMT | ( | [MissionTickAction](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aeaac3485578af13b00618383e6f0264e) | *action*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | int | *param1*, |
|  |  | int | *param2* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a3d2c2c5ce53de3229c4431ee55087079)RemoveSpawnedItemsAndMissiles()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.RemoveSpawnedItemsAndMissiles | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a32934324952a083bae00b265b28e9656)AfterStart()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.AfterStart | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ade48e75645182ee1f1e194b8a1bf9078)OnEndMissionRequest()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.OnEndMissionRequest | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a82608f1e64ceef8455d69e8593028b94)GetMissionEndTimeInSeconds()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Mission.GetMissionEndTimeInSeconds | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ab4164564b5845f08c95487dfeeac9138)GetMissionEndTimerValue()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Mission.GetMissionEndTimerValue | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a148a23bb92e3928268c2b05102ebcb39)GetMemberCountOfSide()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.Mission.GetMemberCountOfSide | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a06cbd857b5e0c6b8d13577e3dd098209)GetInitialSpawnPath()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Path](class_tale_worlds_1_1_engine_1_1_path.html) TaleWorlds.MountAndBlade.Mission.GetInitialSpawnPath | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#adb90179d011306386ce9d0c4b2048c5e)GetInitialSpawnPathData()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [SpawnPathData](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html) TaleWorlds.MountAndBlade.Mission.GetInitialSpawnPathData | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *battleSide* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a537be1bcc04f8a23c1d3104ac998a83b)GetReinforcementPathsDataOfSide()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| MBReadOnlyList< [SpawnPathData](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html) > TaleWorlds.MountAndBlade.Mission.GetReinforcementPathsDataOfSide | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *battleSide* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ac63d64400f0df7e53f368355db687c6c)GetTroopSpawnFrameWithIndex()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.GetTroopSpawnFrameWithIndex | ( | [AgentBuildData](class_tale_worlds_1_1_mount_and_blade_1_1_agent_build_data.html) | *buildData*, |
|  |  | int | *troopSpawnIndex*, |
|  |  | int | *troopSpawnCount*, |
|  |  | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *troopSpawnPosition*, |
|  |  | out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *troopSpawnDirection* ) |

Parameters
:   |  |  |
    | --- | --- |
    | buildData | Troop's build data |
    | troopSpawnIndex | The index of the troop within its formation for determining spawn position |
    | troopSpawnCount | The total count of troops to be spawned with this troop. This specifies maximum troop index for determining troop spawn position |
    | troopSpawnPosition | Output parameter set to troop's world spawn position |
    | troopSpawnDirection | Output parameter set to troop's world direction |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a3ee96cc55f5f5f4040364b52f6586015)GetFormationSpawnFrame()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.GetFormationSpawnFrame | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, |
|  |  | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | *formationClass*, |
|  |  | bool | *isReinforcement*, |
|  |  | out [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *spawnPosition*, |
|  |  | out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *spawnDirection* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ab9ea0b2145f5a76f84fbe454cde03596)GetSpawnPathFrame()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [WorldFrame](struct_tale_worlds_1_1_engine_1_1_world_frame.html) TaleWorlds.MountAndBlade.Mission.GetSpawnPathFrame | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *battleSide*, |
|  |  | float | *pathOffset* = 0f, |
|  |  | float | *targetOffset* = 0f ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a4715501fc972f8dd15c947f03a4379c4)SetBattleAgentCount()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.SetBattleAgentCount | ( | int | *agentCount* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a49fc4f34ec6145e6cbe28d2a6672cf52)GetFormationSpawnPosition()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.Mission.GetFormationSpawnPosition | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, |
|  |  | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | *formationClass* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a5a9b35761616d8751346de4fac81ab55)GetFormationSpawnClass()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) TaleWorlds.MountAndBlade.Mission.GetFormationSpawnClass | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, |
|  |  | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | *formationClass*, |
|  |  | bool | *isReinforcement* = false ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aac35b7a2ab6f555a3448eb118f372f3e)SpawnAgent()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) TaleWorlds.MountAndBlade.Mission.SpawnAgent | ( | [AgentBuildData](class_tale_worlds_1_1_mount_and_blade_1_1_agent_build_data.html) | *agentBuildData*, |
|  |  | bool | *spawnFromAgentVisuals* = false ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ab64251449d200ac93a813fad560e32e9)SetInitialAgentCountForSide()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.SetInitialAgentCountForSide | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side*, |
|  |  | int | *agentCount* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a8d7d8d61977afe56fabb53f27ed96dff)SetFormationPositioningFromDeploymentPlan()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.SetFormationPositioningFromDeploymentPlan | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a9132c1d87694c39140fc3297887ab2b0)SpawnMonster() [1/2]
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) TaleWorlds.MountAndBlade.Mission.SpawnMonster | ( | [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) | *rosterElement*, |
|  |  | [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) | *harnessRosterElement*, |
|  |  | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *initialPosition*, |
|  |  | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *initialDirection*, |
|  |  | int | *forcedAgentIndex* = -1 ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a74246eb4f6edf8e1cc743c4a55c545ac)SpawnMonster() [2/2]
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) TaleWorlds.MountAndBlade.Mission.SpawnMonster | ( | [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) | *equipmentElement*, |
|  |  | [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) | *harnessRosterElement*, |
|  |  | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *initialPosition*, |
|  |  | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *initialDirection*, |
|  |  | int | *forcedAgentIndex* = -1 ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a0b63e06ca515d4f044a6c83922e317c5)SpawnTroop()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) TaleWorlds.MountAndBlade.Mission.SpawnTroop | ( | [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) | *troopOrigin*, |
|  |  | bool | *isPlayerSide*, |
|  |  | bool | *hasFormation*, |
|  |  | bool | *spawnWithHorse*, |
|  |  | bool | *isReinforcement*, |
|  |  | int | *formationTroopCount*, |
|  |  | int | *formationTroopIndex*, |
|  |  | bool | *isAlarmed*, |
|  |  | bool | *wieldInitialWeapons*, |
|  |  | bool | *forceDismounted*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html)? | *initialPosition*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? | *initialDirection*, |
|  |  | string | *specialActionSetSuffix* = null, |
|  |  | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *bannerItem* = null, |
|  |  | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | *formationIndex* = FormationClass::Unset, |
|  |  | bool | *useTroopClassForSpawn* = false ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a88ffe54d94ba708e2fde45d0af3b44c8)ReplaceBotWithPlayer()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) TaleWorlds.MountAndBlade.Mission.ReplaceBotWithPlayer | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *botAgent*, |
|  |  | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) | *missionPeer* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a7493ac8cd6856e3d93f4505304ba320d)OnAgentInteraction()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.OnAgentInteraction | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *requesterAgent*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *targetAgent*, |
|  |  | sbyte | *agentBoneIndex* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#abcd28ccb949c1b3cb2cc4969c40795ef)EndMission()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.EndMission | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a7a6bc9250b9dc600d4de3312d4f0b3a3)AddMissionBehavior()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.AddMissionBehavior | ( | [MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html) | *missionBehavior* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a22e75fd9f15576c8215596f516063f4c)GetMissionBehavior< T >()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| T TaleWorlds.MountAndBlade.Mission.GetMissionBehavior< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *class* |  |
    | *T* | : | *[IMissionBehavior](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_behavior.html)* |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a1ae2aa06eca35e6b96007afe2a295ac1)RemoveMissionBehavior()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.RemoveMissionBehavior | ( | [MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html) | *missionBehavior* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a2d1862434f3f752c344b2d0758a830e1)JoinEnemyTeam()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.JoinEnemyTeam | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aa1f94efc51c6728fab1d37bf4ca8c1e7)OnEndMissionResult()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.OnEndMissionResult | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a6a94f7e73a797e362582cfb9085b4943)IsAgentInteractionAllowed()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Mission.IsAgentInteractionAllowed | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a2b1b7c0f1bdc181f99f9a6b213daeb4f)IsOrderGesturesEnabled()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Mission.IsOrderGesturesEnabled | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ad5a41e297c5a592abd3e7905336686b4)GetExtraEquipmentElementsForCharacter()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| List< [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) > TaleWorlds.MountAndBlade.Mission.GetExtraEquipmentElementsForCharacter | ( | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *character*, |
|  |  | bool | *getAllEquipments* = false ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a5e639f25fc1bbf81a93c22cbb04573c2)IsPlayerCloseToAnEnemy()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Mission.IsPlayerCloseToAnEnemy | ( | float | *distance* = 5 | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a47274e6bdc8926c257520bfd8affbf6b)GetRandomPositionAroundPoint()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.Mission.GetRandomPositionAroundPoint | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *center*, |
|  |  | float | *minDistance*, |
|  |  | float | *maxDistance*, |
|  |  | bool | *nearFirst* = false ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a76ba1e594418ed3183d53103861d2894)FindBestDefendingPosition()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) TaleWorlds.MountAndBlade.Mission.FindBestDefendingPosition | ( | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *enemyPosition*, |
|  |  | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *defendedPosition* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a8a37ef33096d8f16b5ef44d2a0fc37d6)FindPositionWithBiggestSlopeTowardsDirectionInSquare()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) TaleWorlds.MountAndBlade.Mission.FindPositionWithBiggestSlopeTowardsDirectionInSquare | ( | ref [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *center*, |
|  |  | float | *halfSize*, |
|  |  | ref [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *referencePosition* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a3382fe877b6aadc50ee5c1be78c73c2a)AddCustomMissile()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Missile](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_missile.html) TaleWorlds.MountAndBlade.Mission.AddCustomMissile | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *shooterAgent*, |
|  |  | [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *missileWeapon*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *direction*, |
|  |  | [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html) | *orientation*, |
|  |  | float | *baseSpeed*, |
|  |  | float | *speed*, |
|  |  | bool | *addRigidBody*, |
|  |  | [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | *missionObjectToIgnore*, |
|  |  | int | *forcedMissileIndex* = -1 ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a0e389c56777e13a108cf1ce3799dde53)OnAgentMount()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.OnAgentMount | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a85e312908b85556e52322ef07f574eaa)OnAgentDismount()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.OnAgentDismount | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a4464f9c1d97305c0a601158c31a2a83c)OnObjectUsed()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.OnObjectUsed | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *userAgent*, |
|  |  | [UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) | *usableGameObject* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#af0eb5902fd471c0b693ec301c39f0637)OnObjectStoppedBeingUsed()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.OnObjectStoppedBeingUsed | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *userAgent*, |
|  |  | [UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) | *usableGameObject* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a384185697fe11cfa0be287b6007f6989)InitializeStartingBehaviors()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.InitializeStartingBehaviors | ( | [MissionLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html)[] | *logicBehaviors*, |
|  |  | [MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html)[] | *otherBehaviors*, |
|  |  | [MissionNetwork](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html)[] | *networkBehaviors* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a29c9ce6f807c20425ab1792fa20d59fb)GetClosestEnemyAgent()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) TaleWorlds.MountAndBlade.Mission.GetClosestEnemyAgent | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position*, |
|  |  | float | *radius* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#af706d18c316ea91be757f177b423158e)GetClosestAllyAgent()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) TaleWorlds.MountAndBlade.Mission.GetClosestAllyAgent | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position*, |
|  |  | float | *radius* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a62aae51cdc1f67df9dfaeb60d7fde9c3)GetNearbyEnemyAgentCount()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.Mission.GetNearbyEnemyAgentCount | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position*, |
|  |  | float | *radius* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a265dd0582c05e751134ab25c160fc54e)HasAnyAgentsOfSideInRange()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Mission.HasAnyAgentsOfSideInRange | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *origin*, |
|  |  | float | *radius*, |
|  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a094c0c83dfec9ad81a6318dab4217c55)AddSoundAlarmFactorToAgents()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.AddSoundAlarmFactorToAgents | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *alarmCreatorAgent*, |
|  |  | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *soundPosition*, |
|  |  | float | *soundLevelSquareRoot* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a04368d0fe0ce5cd372563fb906117fb8)OnMissionObjectRemoved()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Mission.OnMissionObjectRemoved | ( | [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | *missionObject*, |
|  |  | int | *removeReason* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#af08d86d4b6b8a310593651a2c55978e2)AgentLookingAtAgent()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Mission.AgentLookingAtAgent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent1*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent2* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a625b3fdf40f60f97ab4372556fa0ca7c)FindAgentWithIndex()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) TaleWorlds.MountAndBlade.Mission.FindAgentWithIndex | ( | int | *agentId* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a90becb0b506ab7367567088551cc0fbb)GetUnderAttackTypeOfAgents()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Agent.UnderAttackType](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa6bf6f204fa49aaa08ddab2434120d27) TaleWorlds.MountAndBlade.Mission.GetUnderAttackTypeOfAgents | ( | IEnumerable< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | *agents*, | |  |  | float | *timeLimit* = 3::0f ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ae5384420d9633f816a050785266843f0)GetAgentTeam()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) TaleWorlds.MountAndBlade.Mission.GetAgentTeam | ( | [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) | *troopOrigin*, | |  |  | bool | *isPlayerSide* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ac56d59aff606ed3d57ce3424a9c80de2)GetTeam()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) TaleWorlds.MountAndBlade.Mission.GetTeam | ( | [TeamSideEnum](namespace_tale_worlds_1_1_core.html#a15c7283e7d5f7d4abc93f22069624726) | *teamSide* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a1c8b432382713d14fd6aaf6eb66b8091)GetTeamsOfSide()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IEnumerable< [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) > TaleWorlds.MountAndBlade.Mission.GetTeamsOfSide | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#af18a5070410eb07ea104f0fb3532babe)GetBattleSizeOffset()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.Mission.GetBattleSizeOffset | ( | int | *battleSize*, | |  |  | [Path](class_tale_worlds_1_1_engine_1_1_path.html) | *path* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aba16ea801396a8268b8bf6628ec961d3)GetPathOffsetFromDistance()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.Mission.GetPathOffsetFromDistance | ( | float | *distance*, | |  |  | [Path](class_tale_worlds_1_1_engine_1_1_path.html) | *path* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ab906cfc900a1bdf9550b794b1062a508)OnRenderingStarted()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.OnRenderingStarted | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a7b5608159823d4f849559ac6e3bbc1c9)GetBattleSizeFactor()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.Mission.GetBattleSizeFactor | ( | int | *battleSize*, | |  |  | float | *normalizationFactor* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a2a3196ad9b11133efefcb6e883bd8223)GetMovementTypeOfAgents()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Agent.MovementBehaviorType](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aae8de26b7a3c90f2606b38ac9e062cac) TaleWorlds.MountAndBlade.Mission.GetMovementTypeOfAgents | ( | IEnumerable< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | *agents* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a87187c725daf81bfd5e027c7633089d8)ShowInMissionLoadingScreen()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.ShowInMissionLoadingScreen | ( | int | *durationInSecond*, |
|  |  | Action | *onLoadingEndedAction* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ad11a77753a40e40d2757caa476ae224b)CanAgentRout()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Mission.CanAgentRout | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a3820b1758c559080bb3b2fe41834a645)HandleMissileCollisionReaction()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.HandleMissileCollisionReaction | ( | int | *missileIndex*, |
|  |  | [MissileCollisionReaction](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a235275d0a4fd9f604f19aaaf6943e494) | *collisionReaction*, |
|  |  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *attachLocalFrame*, |
|  |  | bool | *isAttachedFrameLocal*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attachedAgent*, |
|  |  | bool | *attachedToShield*, |
|  |  | sbyte | *attachedBoneIndex*, |
|  |  | [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | *attachedMissionObject*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *bounceBackVelocity*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *bounceBackAngularVelocity*, |
|  |  | int | *forcedSpawnIndex* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a3bc7a95970d3e823de84edb935f5fc0f)KillAgentsOnEntity()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.KillAgentsOnEntity | ( | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *entity*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *destroyerAgent*, |
|  |  | bool | *burnAgents* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a55d828bb2d151bfac5da29b23649a4bd)KillAgentCheat()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.KillAgentCheat | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aa2c64c80e10039de024b867f681a0ac3)KillCheats()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Mission.KillCheats | ( | bool | *killAll*, |
|  |  | bool | *killEnemy*, |
|  |  | bool | *killHorse*, |
|  |  | bool | *killYourself* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a109584004dd49aeaed05b1ce4b1e848a)CanTakeControlOfAgent()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Mission.CanTakeControlOfAgent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agentToTakeControlOf* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aa27e944910df054df5d91dc09c1835be)SetPlayerCanTakeControlOfAnotherAgentWhenDead()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.SetPlayerCanTakeControlOfAnotherAgentWhenDead | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a70a57d14602595319d7702f1d5c32549)TakeControlOfAgent()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.TakeControlOfAgent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agentToTakeControlOf* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a6899e53dd3e2dcff5bc782f93ea79aaf)GetDamageMultiplierOfCombatDifficulty()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Mission.GetDamageMultiplierOfCombatDifficulty | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *victimAgent*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent* = null ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a0fdca78d2e0f386eab22e298a715291c)GetShootDifficulty()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Mission.GetShootDifficulty | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *affectedAgent*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *affectorAgent*, |
|  |  | bool | *isHeadShot* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a95894aa71302a3fe1366d11dc8f7f25a)AddCombatLogSafe()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.AddCombatLogSafe | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *victimAgent*, |
|  |  | [CombatLogData](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html) | *combatLog* ) |

Parameters
:   |  |  |
    | --- | --- |
    | attackerAgent |  |
    | victimAgent |  |
    | combatLog |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aa5ba91bfefea8166e49778d640ff1c14)CreateMissionObjectFromPrefab()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) TaleWorlds.MountAndBlade.Mission.CreateMissionObjectFromPrefab | ( | string | *prefab*, |
|  |  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame*, |
|  |  | Action< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > | *actionAppliedBeforeScriptInitialization* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ab2bc1f00a8a6ff14d3ce88a8f77c3143)GetNearbyAllyAgentsCount()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.Mission.GetNearbyAllyAgentsCount | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *center*, |
|  |  | float | *radius*, |
|  |  | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a08369c67e8ec526e8705110d75f8f108)GetNearbyAllyAgents()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| MBList< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > TaleWorlds.MountAndBlade.Mission.GetNearbyAllyAgents | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *center*, |
|  |  | float | *radius*, |
|  |  | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, |
|  |  | MBList< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | *agents* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a0a43929a80094c81ae28f81c77bddfd4)GetNearbyEnemyAgents()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| MBList< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > TaleWorlds.MountAndBlade.Mission.GetNearbyEnemyAgents | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *center*, |
|  |  | float | *radius*, |
|  |  | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, |
|  |  | MBList< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | *agents* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a26f8e551e713eeaa603ae28a0cb22955)GetNearbyAgents()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| MBList< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > TaleWorlds.MountAndBlade.Mission.GetNearbyAgents | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *center*, |
|  |  | float | *radius*, |
|  |  | MBList< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | *agents* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a560ca5054d0a88a0c69148be752ea59a)IsFormationUnitPositionAvailableMT()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Mission.IsFormationUnitPositionAvailableMT | ( | ref [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *formationPosition*, |
|  |  | ref [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *unitPosition*, |
|  |  | ref [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *nearestAvailableUnitPosition*, |
|  |  | float | *manhattanDistance*, |
|  |  | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a1ff64ed4cff320536d6bc8efbb343f09)IsOrderPositionAvailable()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Mission.IsOrderPositionAvailable | ( | in [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *orderPosition*, |
|  |  | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a3663e2d3f37c4583c976e84b68d18eb4)IsFormationUnitPositionAvailable()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Mission.IsFormationUnitPositionAvailable | ( | ref [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *unitPosition*, |
|  |  | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a8460f602a3b00e1b46bceee187c47deb)HasSceneMapPatch()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Mission.HasSceneMapPatch | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#adbc0777db5b8772d73bcb82dd1ea0c63)GetPatchSceneEncounterPosition()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Mission.GetPatchSceneEncounterPosition | ( | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a9bac139e1251fbe7910a9e7453161248)GetPatchSceneEncounterDirection()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Mission.GetPatchSceneEncounterDirection | ( | out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *direction* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a42c7369588ccb302694990278f6b1eb6)AddTimerToDynamicEntity()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.AddTimerToDynamicEntity | ( | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity*, |
|  |  | float | *timeToKill* = 10::0f ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a9c5493635ce5ce218ee5ce785fa67cf8)AddListener()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.AddListener | ( | [IMissionListener](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_listener.html) | *listener* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a482c376c90a9ccea6dc3b6395848ff61)RemoveListener()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.RemoveListener | ( | [IMissionListener](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_listener.html) | *listener* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a8926dbddb0b9450a94e611b6f7ef7f04)OnAgentFleeing()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.OnAgentFleeing | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a17528a007cf2e831a9a500fbab40b767)OnAgentPanicked()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.OnAgentPanicked | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a708fdac5eb7fcb504bf317158a663ef5)OnTeamDeployed()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.OnTeamDeployed | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ac09ddee123117368c0141e9b20d337b8)OnBattleSideDeployed()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.OnBattleSideDeployed | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | side |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a2cfc38973aea7ba5838e54bdc0ffca1d)OnDeploymentFinished()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.OnDeploymentFinished | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ad08455f82b55543526d83588c7c779fb)OnAfterDeploymentFinished()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.OnAfterDeploymentFinished | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a55017498629ddf284c4f206f660f0082)OnFormationCaptainChanged()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.OnFormationCaptainChanged | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#afcf07e344625561b560cc5f7f4a98c0e)SetFastForwardingFromUI()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.SetFastForwardingFromUI | ( | bool | *fastForwarding* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a8ea513178a76af99b1c67509929c3c88)CheckIfBattleInRetreat()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Mission.CheckIfBattleInRetreat | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a74f726ccbc9b6181bb92f68d78f435c5)AddSpawnedItemEntityCreatedAtRuntime()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.AddSpawnedItemEntityCreatedAtRuntime | ( | [SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html) | *spawnedItemEntity* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a326b2819c6d6122d6a6f68decff47a33)TriggerOnItemPickUpEvent()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.TriggerOnItemPickUpEvent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | [SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html) | *spawnedItemEntity* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aa13e7c90bd899265c3f416be14e0b093)KillNAllies()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.Mission.KillNAllies | ( | List< string > | *strings* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a0b3b519c1f076fa69933516b0e8a29ee)KillAllAllies()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.Mission.KillAllAllies | ( | List< string > | *strings* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a344b7a7a048a89cbbba2c7b38d554f9b)ToggleDisableDying()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.Mission.ToggleDisableDying | ( | List< string > | *strings* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a20348a4bf370c13b40e69b5bfa3a0b6e)ToggleDisableDyingTeam()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.Mission.ToggleDisableDyingTeam | ( | List< string > | *strings* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a5a5bd8377d5f123b872522dbf18d069a)KillAgent()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.Mission.KillAgent | ( | List< String > | *strings* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a1a1079603c72775061a17db8d08766a4)IncreaseBatteringRamSpeeds()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.Mission.IncreaseBatteringRamSpeeds | ( | List< String > | *strings* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ab6eadf322a4f8b495bffb01baddfb682)IncreaseSiegeTowerSpeed()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.Mission.IncreaseSiegeTowerSpeed | ( | List< string > | *strings* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aa8f07b11d6ca27727b3687a71d657a63)LoadParamsDebug()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.Mission.LoadParamsDebug | ( | List< string > | *strings* | ) |  | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a7db3ac61baa64f23ab1fb609121a3a61)MaxRuntimeMissionObjects
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.MountAndBlade.Mission.MaxRuntimeMissionObjects = 8191 | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a283dce3fd3e5f738fcfd28f938c0decc)MaxNavMeshId
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.MountAndBlade.Mission.MaxNavMeshId = 1000000 | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aad592c11fe2fd13c7c5c6fac5cba650a)DisableDying
---------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.Mission.DisableDying = false |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a4b4269e1cc700a9804f7c2cb6cd7afb9)ForceNoFriendlyFire
----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.Mission.ForceNoFriendlyFire = false |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a936c40e498722db2f74aaf1305b9ec77)MaxDamage
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.MountAndBlade.Mission.MaxDamage = 2000 | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ae7232b76c93e887ab56bcf6497c07ece)IsFriendlyMission
--------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.Mission.IsFriendlyMission = true |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a792ea78881c8c40096fac9669c9180a8)MusicCulture
---------------------------------------------------------------------------------------------------------

|  |
| --- |
| [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) TaleWorlds.MountAndBlade.Mission.MusicCulture |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ae61b9118298f60372d1705e3b3760aec)IsOrderMenuOpen
------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.Mission.IsOrderMenuOpen |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#abfcc26923f24744560a6e40014a64a15)IsTransferMenuOpen
---------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.Mission.IsTransferMenuOpen |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a5448119a9e4d4cee27e1738e65f111ae)IsInPhotoMode
----------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.Mission.IsInPhotoMode |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a33ef6a2beb4d696d4c4284a36fbe9f6c)AllowAiTicking
-----------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.Mission.AllowAiTicking = true |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ab168357ed1cbfd7ab67de459d44b0a84)AgentVisualCreator
---------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [IAgentVisualCreator](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual_creator.html) TaleWorlds.MountAndBlade.Mission.AgentVisualCreator |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aa8f98e82ee900cc123528888992bae98)MissionCloseTimeAfterFinish
------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.Mission.MissionCloseTimeAfterFinish = 30.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a1deb5acd96e62413f2a36a52fdc893f4)NextCheckTimeEndMission
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.Mission.NextCheckTimeEndMission = 10.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#acd3aa774e3773eadbdf89c87674524d8)NumOfFormationsSpawnedTeamOne
--------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.Mission.NumOfFormationsSpawnedTeamOne |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a17c11ffda91423d9d229e7da2d641dd6)NumOfFormationsSpawnedTeamTwo
--------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.Mission.NumOfFormationsSpawnedTeamTwo |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#addd10e6a6f4095a364d9d287996b6501)IsFinalized
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Mission.IsFinalized | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a9a140f1e4f9e4ca1f10fabd0d12b59ef)Current
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#adfc400efb4da1f8dfb2cffaa4fbb4758) TaleWorlds.MountAndBlade.Mission.Current | | staticget |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ab12c35ce30bf7b753bd42833815542fa)SceneName
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.Mission.SceneName | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a5c1dc1af88878a185d14a0e97450f664)SceneLevels
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.Mission.SceneLevels | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ac6df464ade2bb3cda0e12f944f405fc6)DamageToPlayerMultiplier
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Mission.DamageToPlayerMultiplier | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a93d82175778f35b1b29a4ce0bca6d435)DamageToFriendsMultiplier
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Mission.DamageToFriendsMultiplier | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#adfcd52e15a9d3297de7dcafbf07a4f9e)DamageFromPlayerToFriendsMultiplier
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Mission.DamageFromPlayerToFriendsMultiplier | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a94774624ee03619222153661d065f904)HasValidTerrainType
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Mission.HasValidTerrainType | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a6ac3565cd204feeebfb48114d8f68619)TerrainType
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) TaleWorlds.MountAndBlade.Mission.TerrainType | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aa7953b48f8546ffd927bef0ab2a2ec9b)Scene
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Scene TaleWorlds.MountAndBlade.Mission.Scene | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#af6b5cd417713e3ec4294e00078361031)CustomCameraTargetLocalOffset
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.Mission.CustomCameraTargetLocalOffset | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aff9badeb47a90fdec66e6aa6fc7dd02c)CustomCameraLocalOffset
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.Mission.CustomCameraLocalOffset | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#afae1af8871222b960faff838abc20c3d)CustomCameraLocalOffset2
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.Mission.CustomCameraLocalOffset2 | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a19ce83bb8518a56e2d44d07f50a5e322)CustomCameraGlobalOffset
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.Mission.CustomCameraGlobalOffset | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#acc5491efd78758aa1b10eaf3b459136f)CustomCameraLocalRotationalOffset
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.Mission.CustomCameraLocalRotationalOffset | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a618b3696c10938348df8f6bd2891daf3)CustomCameraIgnoreCollision
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Mission.CustomCameraIgnoreCollision | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#adf371c41b8c37468e038722f2a693f03)CustomCameraFovMultiplier
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Mission.CustomCameraFovMultiplier = 1.0f | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ab6617e724707d4032ca9a528150aca97)CustomCameraFixedDistance
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Mission.CustomCameraFixedDistance = float.MinValue | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a547be88ba6b01842133a4e28f1906ac8)ListenerAndAttenuationPosBlendFactor
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Mission.ListenerAndAttenuationPosBlendFactor = 0.0f | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a41bbc61c925efd6de3bd4bb4f8c95919)IgnoredEntityForCamera
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) TaleWorlds.MountAndBlade.Mission.IgnoredEntityForCamera | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a203528a59bd6c04a3530d94f12bf9c59)ActiveMissionObjects
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html)> TaleWorlds.MountAndBlade.Mission.ActiveMissionObjects | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a7ad29b0d05914af5e744890d41176ac9)MissionObjects
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html)> TaleWorlds.MountAndBlade.Mission.MissionObjects | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#affc0a1daf19aa31bb58f568d7a6105ef)AddedEntitiesInfo
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[DynamicallyCreatedEntity](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_dynamically_created_entity.html)> TaleWorlds.MountAndBlade.Mission.AddedEntitiesInfo | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#af9c79fcf2fca5f07cf58bf8250a753e8)Boundaries
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MBBoundaryCollection](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_m_b_boundary_collection.html) TaleWorlds.MountAndBlade.Mission.Boundaries | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a699738b09ba8bdafe0411ad742640725)IsMainAgentObjectInteractionEnabled
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Mission.IsMainAgentObjectInteractionEnabled | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aa9f15f4d8dbc127d77f1938cb94a4ec8)IsMainAgentItemInteractionEnabled
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Mission.IsMainAgentItemInteractionEnabled | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ac55809612447ef1e66c403c72ed047a0)IsTeleportingAgents
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Mission.IsTeleportingAgents | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a6fe930eb6033dc12cd5c93c11d130888)ForceTickOccasionally
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Mission.ForceTickOccasionally | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a7c8092e09a05e1461fd5f9d9862f1dcd)CombatType
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MissionCombatType](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a2d209a484eef9303f04737652fa2602d) TaleWorlds.MountAndBlade.Mission.CombatType | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#af168e23366b26a92cc7e239cb46646b0)Mode
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MissionMode](namespace_tale_worlds_1_1_core.html#a34f0ac611df16851fc92e4523aa834e1) TaleWorlds.MountAndBlade.Mission.Mode | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a40cb5ef2062b0cd500813aa5b348591a)CurrentTime
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Mission.CurrentTime | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aa0956ff8ef3f77c8fa8afed9df984b5e)PauseAITick
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Mission.PauseAITick | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a2791b3aca0b1e7039f44bd08560c0b45)IsLoadingFinished
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Mission.IsLoadingFinished | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a963ec247adf3fb03badee5fdba5f14a6)CameraIsFirstPerson
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Mission.CameraIsFirstPerson | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a1fbd240b434444f2f392fbda7802a261)CameraAddedDistance
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Mission.CameraAddedDistance | | staticgetset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#adf7b8e418807ccf326de411007ae6e4c)ClearSceneTimerElapsedTime
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Mission.ClearSceneTimerElapsedTime | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a3a71fa12c5d93dc14318f7aff418b4e2)MissilesList
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Missile](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_missile.html)> TaleWorlds.MountAndBlade.Mission.MissilesList | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a53768f31eca7b26479af5d4f2152d32a)MissionEnded
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Mission.MissionEnded | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a3fb05eac34e142f3d7202e6660c91f9e)MountsWithoutRiders
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<KeyValuePair<[Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), [MissionTime](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_time.html)> > TaleWorlds.MountAndBlade.Mission.MountsWithoutRiders | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a5cf4d6165a46c604d6f6016fff0c9c3b)MissionIsEnding
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Mission.MissionIsEnding = false | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aed6523d05551bab58f008c42755cdbe3)IsDeploymentFinished
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Mission.IsDeploymentFinished = false | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ab90f532e45e896eca2ae851432573356)RetreatSide
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) TaleWorlds.MountAndBlade.Mission.RetreatSide = BattleSideEnum.None | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a8fcb6bdedeb6f3d645f923b02a47a3dd)IsFastForward
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Mission.IsFastForward | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ad9e533224b2444e8ff8166e08294a92a)FixedDeltaTimeMode
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Mission.FixedDeltaTimeMode | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aef779fbc7d0e2808362b59efec242e0c)FixedDeltaTime
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Mission.FixedDeltaTime | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a3b8484111a0833d21284ef4a8dbf72fc)CurrentState
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [State](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a09888b586108ef6c430ecc8fed801f9d) TaleWorlds.MountAndBlade.Mission.CurrentState | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a96674c3f79024f5190b7d7ac867c0246)Teams
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TeamCollection](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_team_collection.html) TaleWorlds.MountAndBlade.Mission.Teams | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ade2c0c1c8ceb6acc96af90a93f486676)AttackerTeam
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) TaleWorlds.MountAndBlade.Mission.AttackerTeam | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a7cc9700dc60c3ad6564601b362a45de4)DefenderTeam
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) TaleWorlds.MountAndBlade.Mission.DefenderTeam | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ab70b65b0dedfcd72015be223f6bebc0c)AttackerAllyTeam
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) TaleWorlds.MountAndBlade.Mission.AttackerAllyTeam | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ac2da4e17578e49d6db101730e56427de)DefenderAllyTeam
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) TaleWorlds.MountAndBlade.Mission.DefenderAllyTeam | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a3ba0208253e209b330fe82d1d627ac2c)PlayerTeam
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) TaleWorlds.MountAndBlade.Mission.PlayerTeam | | getset |

Implements [TaleWorlds.Core.IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html#a14d9861cbb1c076302d92e9456a2cbf2).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a9266b530fc6cc3d7cf0d8c894cbe38c9)PlayerEnemyTeam
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) TaleWorlds.MountAndBlade.Mission.PlayerEnemyTeam | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a82a6e9499ecdb85cda68b72eecf9070b)PlayerAllyTeam
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) TaleWorlds.MountAndBlade.Mission.PlayerAllyTeam | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ad5d2fce75f936e955f7e0614a1b2e992)SpectatorTeam
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) TaleWorlds.MountAndBlade.Mission.SpectatorTeam | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a292d2ad3fdfa4e916d642bb2a10c0734)IsMissionEnding
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Mission.IsMissionEnding | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a9f171f1ba98ccde589cf32560fad0219)MissionLogics
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[MissionLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html)> TaleWorlds.MountAndBlade.Mission.MissionLogics | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ae6b2124209c49b3194106e9a0032cad5)MissionBehaviors
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html)> TaleWorlds.MountAndBlade.Mission.MissionBehaviors | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a2bd1d47adfb32f556f571f04af15a9ab)InputManager
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html) TaleWorlds.MountAndBlade.Mission.InputManager | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ad82455bfa2fad92e9abd7a1b8e04ef18)NeedsMemoryCleanup
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Mission.NeedsMemoryCleanup | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ad783055c6c702d393b66cd52f165c9ee)MainAgent
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) TaleWorlds.MountAndBlade.Mission.MainAgent | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ae9e1da6580032b1b6d0da07ec33d5a63)DeploymentPlan
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html) TaleWorlds.MountAndBlade.Mission.DeploymentPlan | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a944797a3874e40c2e3cef462b12191d9)IsBattleSpawnPathSelectorInitialized
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Mission.IsBattleSpawnPathSelectorInitialized | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a7080497cc38f8be6ec2aa627b7f9bbad)MainAgentServer
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) TaleWorlds.MountAndBlade.Mission.MainAgentServer | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a3104ec5e99bfc27dc8d0bcc15e95ca04)HasSpawnPath
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Mission.HasSpawnPath | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a26171bb035eefd79932046877507b965)IsFieldBattle
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Mission.IsFieldBattle | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a651852bebc89a464fe0a1397dcbf5633)IsSiegeBattle
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Mission.IsSiegeBattle | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a4866ab49d5f6ba2cd9322d72a6c8b5fd)IsSallyOutBattle
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Mission.IsSallyOutBattle | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a66050e6c40112ac57b49efb1941e4e06)IsNavalBattle
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Mission.IsNavalBattle | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a2189f352056607ad99729ddf7f71a75e)AllAgents
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [AgentReadOnlyList](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_agent_read_only_list.html) TaleWorlds.MountAndBlade.Mission.AllAgents | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a4344427bdd332a84d8f9ac5f77134a94)Agents
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [AgentReadOnlyList](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_agent_read_only_list.html) TaleWorlds.MountAndBlade.Mission.Agents | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ae0799693ee2962ea2a5c163a0cf543fd)IsInventoryAccessAllowed
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Mission.IsInventoryAccessAllowed | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a95b1f09de1288d988e73a52d492ec999)IsInventoryAccessible
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Mission.IsInventoryAccessible | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a262de0372bcaadc609e53e5be83972dc)MissionResult
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MissionResult TaleWorlds.MountAndBlade.Mission.MissionResult | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a4f2c55e8a5c303e1373a8c7a81512bd0)FocusableObjectInformationProvider
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MissionFocusableObjectInformationProvider](class_tale_worlds_1_1_mount_and_blade_1_1_mission_focusable_object_information_provider.html) TaleWorlds.MountAndBlade.Mission.FocusableObjectInformationProvider | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aed78dce90af02c0a65955c1c9af3844b)IsQuestScreenAccessible
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Mission.IsQuestScreenAccessible | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a5e8028aae4551c6b5a3fe3109be716fe)IsQuestScreenAccessAllowed
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Mission.IsQuestScreenAccessAllowed | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ab606ce2911ebf94cd6cda57e3f28a328)IsCharacterWindowAccessible
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Mission.IsCharacterWindowAccessible | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ace57ed02c4bb5dad93940de18b48af32)IsCharacterWindowAccessAllowed
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Mission.IsCharacterWindowAccessAllowed | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ad752147735c600d44fbef937d794d210)IsPartyWindowAccessible
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Mission.IsPartyWindowAccessible | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a0824972a61ada9b23d04dff8183b1741)IsPartyWindowAccessAllowed
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Mission.IsPartyWindowAccessAllowed | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#acaa435b342b3c9dd011368c8b4540e31)IsKingdomWindowAccessible
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Mission.IsKingdomWindowAccessible | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a9ad7275ca1109ec33193169aabd604d6)IsKingdomWindowAccessAllowed
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Mission.IsKingdomWindowAccessAllowed | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a3a6e9dced913fbe93df074bb50cc11ec)IsClanWindowAccessible
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Mission.IsClanWindowAccessible | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aa0b018b46bb49efe3dfc835ee228f497)IsClanWindowAccessAllowed
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Mission.IsClanWindowAccessAllowed | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a785f0425f82f1de3aa7a0bb320c04158)IsEncyclopediaWindowAccessible
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Mission.IsEncyclopediaWindowAccessible | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a175cb588eed72e473fd52482eddf6310)IsEncyclopediaWindowAccessAllowed
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Mission.IsEncyclopediaWindowAccessAllowed | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#af731da3c6b984348cefef43dd7a80321)IsBannerWindowAccessible
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Mission.IsBannerWindowAccessible | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a271dc10b8cdf38f5c8dc836980dd2055)IsBannerWindowAccessAllowed
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Mission.IsBannerWindowAccessAllowed | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a82b5b9b9661ccc987ebb7b8118bc7b2a)DoesMissionRequireCivilianEquipment
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool? TaleWorlds.MountAndBlade.Mission.DoesMissionRequireCivilianEquipment | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a872f5c8f04fb293048c650c57de0ba82)MissionTeamAIType
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MissionTeamAITypeEnum](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#abaf2994f3d6a2d3282a79078c16c2bfe) TaleWorlds.MountAndBlade.Mission.MissionTeamAIType | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a818740c7002ee8eed888e54df38a30ed)Recorder
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MissionRecorder](class_tale_worlds_1_1_mount_and_blade_1_1_mission_recorder.html) TaleWorlds.MountAndBlade.Mission.Recorder | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#acf5fdb02b634efe752f3b910ff0cde13)CanPlayerTakeControlOfAnotherAgentWhenDead
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Mission.CanPlayerTakeControlOfAnotherAgentWhenDead | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ae84cb369eab061ddce00b59a73d7c446)MissionTimeTracker
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MissionTimeTracker TaleWorlds.MountAndBlade.Mission.MissionTimeTracker | | get |

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a159dbbaa0ed788bd0186f0246c7cdf00)OnMissionReset
-----------------------------------------------------------------------------------------------------------

|  |
| --- |
| System.ComponentModel.PropertyChangedEventHandler TaleWorlds.MountAndBlade.Mission.OnMissionReset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a08bdc349fea6e8fb3bd4eb1ead4448ae)OnBeforeAgentRemoved
-----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [OnBeforeAgentRemovedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a92ec14adf8994c29e1f782be658f5a5a) TaleWorlds.MountAndBlade.Mission.OnBeforeAgentRemoved |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aabe7e21cf00bc3c31826bddf2c620a5a)IsFormationUnitPositionAvailable\_AdditionalCondition
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Func<[WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) , [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) , bool > TaleWorlds.MountAndBlade.Mission.IsFormationUnitPositionAvailable\_AdditionalCondition |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a68cf27f3ac809c7792e423be5b5f9ec5)CanAgentRout\_AdditionalCondition
------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Func<[Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), bool > TaleWorlds.MountAndBlade.Mission.CanAgentRout\_AdditionalCondition |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a780b20a0d6e0b662e53e8724ca20b1bf)OnAddSoundAlarmFactorToAgents
--------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [OnAddSoundAlarmFactorToAgentsDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#acc03845f8ec54d33daa5cd63d309a73b) TaleWorlds.MountAndBlade.Mission.OnAddSoundAlarmFactorToAgents |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a9b535532029f8ee00385d27380315233)IsAgentInteractionAllowed\_AdditionalCondition
-------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Func<bool> TaleWorlds.MountAndBlade.Mission.IsAgentInteractionAllowed\_AdditionalCondition |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#afb2c69d4aa9a157023741cd1f483551c)OnMainAgentChanged
---------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [OnMainAgentChangedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#ae158b35a2eb37fcf6aab7e03efa53df0) TaleWorlds.MountAndBlade.Mission.OnMainAgentChanged |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#aeeca9c95101a65a843e84be5264dc393)OnComputeTroopBodyProperties
-------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [ComputeTroopBodyPropertiesDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a8313f05ca1c550498be0554af2e13335) TaleWorlds.MountAndBlade.Mission.OnComputeTroopBodyProperties |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a07ec32a0d8f5d7f718002483457ede6f)GetAgentTroopClass\_Override
-------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Func<[BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c), [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html), [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90)> TaleWorlds.MountAndBlade.Mission.GetAgentTroopClass\_Override |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a6635a1d313eaaf46aabf22dc893b2d8f)OnItemPickUp
---------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), [SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html)> TaleWorlds.MountAndBlade.Mission.OnItemPickUp |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a3d33c4a300b0cbc25be74f26ed19ec64)OnItemDrop
-------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), [SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html)> TaleWorlds.MountAndBlade.Mission.OnItemDrop |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a889763d0c9da5c6382ba77305b5d2c8f)FormationCaptainChanged
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html)> TaleWorlds.MountAndBlade.Mission.FormationCaptainChanged |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a21b800e5edc64254e1c95ba3abc2ab89)GetOverriddenFleePositionForAgent
------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Func<[Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html)?> TaleWorlds.MountAndBlade.Mission.GetOverriddenFleePositionForAgent |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#abd5f2d23392b8a4b5921b4bd64d09e38)AreOrderGesturesEnabled\_AdditionalCondition
-----------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Func<bool> TaleWorlds.MountAndBlade.Mission.AreOrderGesturesEnabled\_AdditionalCondition |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a37da117010925d208200cfaddef8b8eb)IsBattleInRetreatEvent
-------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Func<bool> TaleWorlds.MountAndBlade.Mission.IsBattleInRetreatEvent |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a89dc767a01e311bfecf10c96744645d2)OnMissileRemovedEvent
------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<int> TaleWorlds.MountAndBlade.Mission.OnMissileRemovedEvent |

