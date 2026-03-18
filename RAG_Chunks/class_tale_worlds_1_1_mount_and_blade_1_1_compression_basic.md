--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html ---

TaleWorlds.MountAndBlade.CompressionBasic Class Reference|  |  |
| --- | --- |
| Static Public Attributes | |
| const float | [MaxPossibleAbsValueForSecondMaxQuaternionComponent](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#ac2e35a7d2ee812da4b92611cb4133244) = 0.7071068287f |
| const float | [MaxPositionZForCompression](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a6dae4e9aaea6986aaf7d44255cd4392c) = 2521.0f |
| const float | [MaxPositionForCompression](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#aeda2cc08f44ffff7a8c0f0dcb0355a44) = 10385.0f |
| const float | [MinPositionForCompression](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#aa2bf53a8d0184c1e1449ef0bcb82eac4) = -100.0f |
| const int | [MaxPeerCount](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#ad0effea01c88887c192cf8ae2f192a25) = 511 |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [PingValueCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a13578fb2c3237c23286b2700471f24e7) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(0, NetworkMessages.FromServer.PingReplication.MaxPingToReplicate, true) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [LossValueCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a5a7f7fba5c90f241c4cf4cc015997086) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(0, 100, true) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [ServerPerformanceStateCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#aca7e99c03090ee3a1e76f19ff3c4485a) |
| static [CompressionInfo.UnsignedInteger](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_unsigned_integer.html) | [ColorCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a1d3a78ae2873f65e26ef96e62ef46646) = new [CompressionInfo.UnsignedInteger](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_unsigned_integer.html)(0, 32) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [ItemDataValueCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a4fbefb55df7f7c7f6b051b3bbc45951c) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(0, sizeof(short) \* 8) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [RandomSeedCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#ad178ebf923b8147997ed9f3331e8f442) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(0, [MBRandom.MaxSeed](class_tale_worlds_1_1_core_1_1_m_b_random.html#a0ebff9d70f30283312a3f7109542f60e), true) |
| static [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) | [PositionCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#aa850b6c9c6b10370559f9321c25b9c11) = new [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html)([MinPositionForCompression](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#aa2bf53a8d0184c1e1449ef0bcb82eac4), [MaxPositionForCompression](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#aeda2cc08f44ffff7a8c0f0dcb0355a44), 22) |
| static [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) | [LocalPositionCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#abe21c2844549d6780b70ecc25d285411) = new [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html)(-32.0f, 32.0f, 16) |
| static [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) | [LowResLocalPositionCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a11df1e7a262b5a55f1d4b17bd79574a4) = new [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html)(-32.0f, 32.0f, 12) |
| static [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) | [BigRangeLowResLocalPositionCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a11f5652fbaa6512720e875b0d47dfd48) = new [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html)(-1000.0f, 1000.0f, 16) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [PlayerCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a47a5ffe02b6729a86da1bf71c5a34217) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(-1, [GameNetwork.MaxPlayerCount](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#aedd41b818a10f10f70ea30f96f1362bc) - 1, true) |
| static [CompressionInfo.UnsignedInteger](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_unsigned_integer.html) | [PeerComponentCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#abeff72b5a2aab610c985ab25fa189ed8) = new [CompressionInfo.UnsignedInteger](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_unsigned_integer.html)(0, 32) |
| static [CompressionInfo.UnsignedInteger](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_unsigned_integer.html) | [GUIDCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#aea7d22e1bd1ded6127bad1b5d9017d17) = new [CompressionInfo.UnsignedInteger](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_unsigned_integer.html)(0, 32) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [FlagsCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a81639d7bfa400999a40b8ca86a214fe0) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(0, 30) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [GUIDIntCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a37ad17d683971a02608122bf8175fbc5) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(-1, 31) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [MissionObjectIDCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#adef7398d5cf29c8006cc89aa173c78ab) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(-1, [Mission.MaxRuntimeMissionObjects](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a7db3ac61baa64f23ab1fb609121a3a61) - 1, true) |
| static [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) | [UnitVectorCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a4cade77ef96d04157ca70991054d1b8c) = new [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html)(-1.024f, 10, 0.002f) |
| static [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) | [LowResRadianCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a90b6673b45d08d4d988695e21a91523a) = new [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html)(-MBMath.PI - 0.01f, MBMath.PI + 0.01f, 8) |
| static [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) | [RadianCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a87a087143778e11014cee97d2ae3f72c) = new [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html)(-MBMath.PI - 0.01f, MBMath.PI + 0.01f, 10) |
| static [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) | [HighResRadianCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a2304d8a60c39d1da17ec409a90a9088e) = new [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html)(-MBMath.PI - 0.01f, MBMath.PI + 0.01f, 13) |
| static [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) | [UltResRadianCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a684f143965271c1650f379a57d86af1a) = new [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html)(-MBMath.PI - 0.01f, MBMath.PI + 0.01f, 30) |
| static [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) | [ScaleCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#af96cd547f2f843717efe2283966c8c8c) = new [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html)(-0.001f, 10, 0.01f) |
| static [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) | [LowResQuaternionCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a69ce20688eb86a98865267e5058b7c24) = new [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html)(-[MaxPossibleAbsValueForSecondMaxQuaternionComponent](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#ac2e35a7d2ee812da4b92611cb4133244), [MaxPossibleAbsValueForSecondMaxQuaternionComponent](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#ac2e35a7d2ee812da4b92611cb4133244), 6) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [OmittedQuaternionComponentIndexCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#aca90a1aa4dc015b8ffc49675e1e93ae0) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(0, 3, true) |
| static [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) | [ImpulseCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a5708581654c7ae55451c9165185086b0) = new [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html)(-500.0f, 16, 0.0153f) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [AnimationKeyCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a442d5e12813f2f805701d3f1035b675e) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(0, 8000, true) |
| static [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) | [AnimationSpeedCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a470b755d05cf83513d3cb9fe4a58074b) = new [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html)(0.0f, 9, 0.01f) |
| static [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) | [AnimationProgressCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a66625f0e7b8d94b5a250b57234443a38) = new [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html)(0.0f, 1.0f, 9) |
| static [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) | [VertexAnimationSpeedCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#ae851e3ac4263d9016d992dd7d9925a1b) = new [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html)(0.0f, 9, 0.1f) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [PercentageCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a9ce4dd83d0a0f51756da17fafa1e2362) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(0, 100, true) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [EntityChildCountCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a7f04ed03461353373762e3b79765610a) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(0, 8) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [AgentHitDamageCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a99b8854d4c394c4d830b499e187812ad) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(0, [Mission.MaxDamage](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a936c40e498722db2f74aaf1305b9ec77), true) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [AgentHitModifiedDamageCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a3de93369af0304e2c991eaba93e38b76) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(-[Mission.MaxDamage](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a936c40e498722db2f74aaf1305b9ec77), [Mission.MaxDamage](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a936c40e498722db2f74aaf1305b9ec77), true) |
| static [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) | [AgentHitRelativeSpeedCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a670f01b95b436da6d4b00a2b09645e6a) = new [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html)(0f, 17, 0.01f) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [AgentHitArmorCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#af7abb0dcde8e1f153e599e40f34b3b71) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(0, 200, true) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [AgentHitBoneIndexCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#ab3a7673fbfcaddd587207e545896d964) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(-1, [Engine.Skeleton.MaxBoneCount](class_tale_worlds_1_1_engine_1_1_skeleton.html#a9977148fe283392a2ee2607dca227121) - 1, true) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [AgentHitBodyPartCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a3aeb4bfe0d9a0601d32994299fc74a00) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(-1, (int)[BoneBodyPartType.NumOfBodyPartTypes](namespace_tale_worlds_1_1_mount_and_blade.html#a88860bf2968d0069d9696746ebb47115ad7af6c3eb865e1a3d5eec472e0c9210c) - 1, true) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [AgentHitDamageTypeCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#ac65c02793912c488ed14f5b9ab5954b9) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(-1, (int)DamageTypes.NumberOfDamageTypes - 1, true) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [RoundGoldAmountCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a5c2c8a818efff390fbbab879c8b8d683) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(-1, [MissionMultiplayerGameModeBase.GoldCap](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#a3bcfe16586e4a457074927bd49f096d0), true) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [DebugIntNonCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a5b7390c2878de674d14a7dff4a826d59) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(int.MinValue, sizeof(int) \* 8) |
| static [CompressionInfo.UnsignedLongInteger](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_unsigned_long_integer.html) | [DebugULongNonCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#aa218aaf778fddfa20d216090f26d6cf0) = new [CompressionInfo.UnsignedLongInteger](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_unsigned_long_integer.html)(ulong.MinValue, sizeof(ulong) \* 8) |
| static [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) | [AgentAgeCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a1218fb14283b8bc9d3bab8be52fc6482) = new [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html)(0f, [DynamicBodyProperties.MaxAge](struct_tale_worlds_1_1_core_1_1_dynamic_body_properties.html#a13dfa5d8a6fcc0f70a51bd40feea5ebf), 10) |
| static [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) | [FaceKeyDataCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a8a6d409a217cab9f824c7b353ddab635) = new [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html)(0f, 1f, 10) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [PlayerChosenBadgeCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#ad9f319d56a5e94f1dd951451647a852b) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(-1, 8) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [MaxNumberOfPlayersCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a389329d9f067c647d80dcdbab373f515) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(MultiplayerOptions.OptionType.MaxNumberOfPlayers.GetMinimumValue(), MultiplayerOptions.OptionType.MaxNumberOfPlayers.GetMaximumValue(), true) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [MinNumberOfPlayersForMatchStartCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#ae805788176ef51adaeccfd18e39865ce) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(MultiplayerOptions.OptionType.MinNumberOfPlayersForMatchStart.GetMinimumValue(), MultiplayerOptions.OptionType.MinNumberOfPlayersForMatchStart.GetMaximumValue(), true) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [MapTimeLimitCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a4c89a39b7700940a376a36914f02629a) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(MultiplayerOptions.OptionType.MapTimeLimit.GetMinimumValue(), MultiplayerOptions.OptionType.MapTimeLimit.GetMaximumValue(), true) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [RoundTotalCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a77ef947160e4fc793c951d500b88652f) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(MultiplayerOptions.OptionType.RoundTotal.GetMinimumValue(), MultiplayerOptions.OptionType.RoundTotal.GetMaximumValue(), true) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [RoundTimeLimitCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#af1fa0938b060bf36b487fe5f406d6af6) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(MultiplayerOptions.OptionType.RoundTimeLimit.GetMinimumValue(), MultiplayerOptions.OptionType.RoundTimeLimit.GetMaximumValue(), true) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [WarmupTimeLimitCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#aa1d5e2b7319e86b9b53e7700bfaca17c) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(MultiplayerOptions.OptionType.WarmupTimeLimitInSeconds.GetMinimumValue(), MultiplayerOptions.OptionType.WarmupTimeLimitInSeconds.GetMaximumValue(), true) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [RoundPreparationTimeLimitCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a67ac9b5167f25ef5ad3e9add53f55561) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(MultiplayerOptions.OptionType.RoundPreparationTimeLimit.GetMinimumValue(), MultiplayerOptions.OptionType.RoundPreparationTimeLimit.GetMaximumValue(), true) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [RespawnPeriodCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#afc7d21baa2735ab71422819ad2e576b4) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(MultiplayerOptions.OptionType.RespawnPeriodTeam1.GetMinimumValue(), MultiplayerOptions.OptionType.RespawnPeriodTeam1.GetMaximumValue(), true) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [GoldGainChangePercentageCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#af0bf5a47ff44f2450c036e60b99208f2) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(MultiplayerOptions.OptionType.GoldGainChangePercentageTeam1.GetMinimumValue(), MultiplayerOptions.OptionType.GoldGainChangePercentageTeam1.GetMaximumValue(), true) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [SpectatorCameraTypeCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a8a5f99d34f2c9b62f55f24ee9120af5d) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)((int)SpectatorCameraTypes.Invalid, (int)SpectatorCameraTypes.Count - 1, true) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [PollAcceptThresholdCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#ab04fd499f9d74f909671a6db7ce342d2) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(MultiplayerOptions.OptionType.PollAcceptThreshold.GetMinimumValue(), MultiplayerOptions.OptionType.PollAcceptThreshold.GetMaximumValue(), true) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [NumberOfBotsTeamCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a3e46f933a42209859b2589baa9324494) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(MultiplayerOptions.OptionType.NumberOfBotsTeam1.GetMinimumValue(), MultiplayerOptions.OptionType.NumberOfBotsTeam1.GetMaximumValue(), true) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [NumberOfBotsPerFormationCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a812f008d7ded7eefd1fd96db0cb75877) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(MultiplayerOptions.OptionType.NumberOfBotsPerFormation.GetMinimumValue(), MultiplayerOptions.OptionType.NumberOfBotsPerFormation.GetMaximumValue(), true) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [AutoTeamBalanceLimitCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a950546689af961aaef40cfa02aab1884) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(MultiplayerOptions.OptionType.AutoTeamBalanceThreshold.GetMinimumValue(), MultiplayerOptions.OptionType.AutoTeamBalanceThreshold.GetMaximumValue(), true) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [FriendlyFireDamageCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a6d2c340f81fed023d60c7a4309ecc652) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(MultiplayerOptions.OptionType.FriendlyFireDamageMeleeFriendPercent.GetMinimumValue(), MultiplayerOptions.OptionType.FriendlyFireDamageMeleeFriendPercent.GetMaximumValue(), true) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [ForcedAvatarIndexCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#aa4dc1e7824beceed6c9205d1d6f3766d) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(-1, [LobbyNetworkComponent.MaxForcedAvatarIndex](class_tale_worlds_1_1_mount_and_blade_1_1_lobby_network_component.html#a28e40c7df321ca117ea78c8edce00877) - 1, true) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [IntermissionStateCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a029d6377b7997901a28fb3add625c673) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(0, Enum.GetNames(typeof([MultiplayerIntermissionState](namespace_tale_worlds_1_1_mount_and_blade.html#a2bfb5cd35ce7c8036a28d0e0c8b4d793))).Length - 1, false) |
| static [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) | [IntermissionTimerCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a51e8b993343af73821ca82b100ad1a97) = new [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html)(0, [BaseNetworkComponentData.MaxIntermissionStateTime](class_tale_worlds_1_1_mount_and_blade_1_1_base_network_component_data.html#a956ac8739054fe9f0527037bbe8f1161), 14) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [IntermissionMapVoteItemCountCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a713958eeeba8d123bf2f0838767f4f49) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(0, [MultiplayerIntermissionVotingManager.MaxAllowedMapCount](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a7bf5ed726f47999e4bc54c945ccdd3e7) - 1, true) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [IntermissionVoterCountCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a09cd8a6a0bb974bb8f2b57c17b465b98) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(0, [GameNetwork.MaxPlayerCount](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#aedd41b818a10f10f70ea30f96f1362bc) - 1, true) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [ActionCodeCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a1ca13eb5481e67e5eaa0d3abea0afe31) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [AnimationIndexCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a3409c5a5be27e654c4331d5a5cf8c569) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [CultureIndexCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#ab9ad616ec989bb6245c56cbec30340c2) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [SoundEventsCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#aedae8fda15028c1612f3bdd3404bb981) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [NetworkComponentEventTypeFromServerCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#aeac2ab5856d8bc73350c148433e468e6) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [NetworkComponentEventTypeFromClientCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#ad9660d5b0659da8a8f988459a2049e57) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [TroopTypeCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a25d9c61828e531a899a419a360052ac1) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(-1, (int)TroopType.NumberOfTroopTypes - 1, true) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [BannerDataCountCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a54c49af28b07fb28f528f2c0dba59507) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(0, [Banner.MaxIconCount](class_tale_worlds_1_1_core_1_1_banner.html#a02b3a58004f311623ea739377dc7a12b) - 1, true) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [BannerDataMeshIdCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a19cfc791dce02d87ec4b21a4e6e4f38b) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(0, 13) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [BannerDataColorIndexCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a36c595149a7fdab2a15108b2107497c0) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(0, 10) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [BannerDataSizeCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a319612f1af1958065ae082816b2328ed) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(-[Banner.MaxSize](class_tale_worlds_1_1_core_1_1_banner.html#a811cc5e35dc58567f13941dee47b2185), [Banner.MaxSize](class_tale_worlds_1_1_core_1_1_banner.html#a811cc5e35dc58567f13941dee47b2185), true) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [BannerDataRotationCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a6546dc3f3884b103b14b34afb6886255) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(0, 360, true) |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#ac2e35a7d2ee812da4b92611cb4133244)MaxPossibleAbsValueForSecondMaxQuaternionComponent
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.CompressionBasic.MaxPossibleAbsValueForSecondMaxQuaternionComponent = 0.7071068287f | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a6dae4e9aaea6986aaf7d44255cd4392c)MaxPositionZForCompression
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.CompressionBasic.MaxPositionZForCompression = 2521.0f | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#aeda2cc08f44ffff7a8c0f0dcb0355a44)MaxPositionForCompression
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.CompressionBasic.MaxPositionForCompression = 10385.0f | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#aa2bf53a8d0184c1e1449ef0bcb82eac4)MinPositionForCompression
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.CompressionBasic.MinPositionForCompression = -100.0f | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#ad0effea01c88887c192cf8ae2f192a25)MaxPeerCount
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.MountAndBlade.CompressionBasic.MaxPeerCount = 511 | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a13578fb2c3237c23286b2700471f24e7)PingValueCompressionInfo
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.PingValueCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(0, NetworkMessages.FromServer.PingReplication.MaxPingToReplicate, true) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a5a7f7fba5c90f241c4cf4cc015997086)LossValueCompressionInfo
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.LossValueCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(0, 100, true) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#aca7e99c03090ee3a1e76f19ff3c4485a)ServerPerformanceStateCompressionInfo
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.ServerPerformanceStateCompressionInfo | | static |

**Initial value:**

= new [CompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_info.html).[Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(0,

((int)NetworkMessages.FromServer.ServerPerformanceState.Count) - 1, true)

[TaleWorlds.MountAndBlade.CompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_info.html)

**Definition** CompressionInfo.cs:16

[TaleWorlds.MountAndBlade.CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)

**Definition** CompressionInfo.cs:20

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a1d3a78ae2873f65e26ef96e62ef46646)ColorCompressionInfo
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.UnsignedInteger](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_unsigned_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.ColorCompressionInfo = new [CompressionInfo.UnsignedInteger](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_unsigned_integer.html)(0, 32) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a4fbefb55df7f7c7f6b051b3bbc45951c)ItemDataValueCompressionInfo
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.ItemDataValueCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(0, sizeof(short) \* 8) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#ad178ebf923b8147997ed9f3331e8f442)RandomSeedCompressionInfo
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.RandomSeedCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(0, [MBRandom.MaxSeed](class_tale_worlds_1_1_core_1_1_m_b_random.html#a0ebff9d70f30283312a3f7109542f60e), true) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#aa850b6c9c6b10370559f9321c25b9c11)PositionCompressionInfo
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) TaleWorlds.MountAndBlade.CompressionBasic.PositionCompressionInfo = new [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html)([MinPositionForCompression](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#aa2bf53a8d0184c1e1449ef0bcb82eac4), [MaxPositionForCompression](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#aeda2cc08f44ffff7a8c0f0dcb0355a44), 22) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#abe21c2844549d6780b70ecc25d285411)LocalPositionCompressionInfo
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) TaleWorlds.MountAndBlade.CompressionBasic.LocalPositionCompressionInfo = new [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html)(-32.0f, 32.0f, 16) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a11df1e7a262b5a55f1d4b17bd79574a4)LowResLocalPositionCompressionInfo
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) TaleWorlds.MountAndBlade.CompressionBasic.LowResLocalPositionCompressionInfo = new [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html)(-32.0f, 32.0f, 12) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a11f5652fbaa6512720e875b0d47dfd48)BigRangeLowResLocalPositionCompressionInfo
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) TaleWorlds.MountAndBlade.CompressionBasic.BigRangeLowResLocalPositionCompressionInfo = new [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html)(-1000.0f, 1000.0f, 16) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a47a5ffe02b6729a86da1bf71c5a34217)PlayerCompressionInfo
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.PlayerCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(-1, [GameNetwork.MaxPlayerCount](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#aedd41b818a10f10f70ea30f96f1362bc) - 1, true) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#abeff72b5a2aab610c985ab25fa189ed8)PeerComponentCompressionInfo
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.UnsignedInteger](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_unsigned_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.PeerComponentCompressionInfo = new [CompressionInfo.UnsignedInteger](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_unsigned_integer.html)(0, 32) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#aea7d22e1bd1ded6127bad1b5d9017d17)GUIDCompressionInfo
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.UnsignedInteger](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_unsigned_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.GUIDCompressionInfo = new [CompressionInfo.UnsignedInteger](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_unsigned_integer.html)(0, 32) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a81639d7bfa400999a40b8ca86a214fe0)FlagsCompressionInfo
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.FlagsCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(0, 30) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a37ad17d683971a02608122bf8175fbc5)GUIDIntCompressionInfo
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.GUIDIntCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(-1, 31) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#adef7398d5cf29c8006cc89aa173c78ab)MissionObjectIDCompressionInfo
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.MissionObjectIDCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(-1, [Mission.MaxRuntimeMissionObjects](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a7db3ac61baa64f23ab1fb609121a3a61) - 1, true) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a4cade77ef96d04157ca70991054d1b8c)UnitVectorCompressionInfo
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) TaleWorlds.MountAndBlade.CompressionBasic.UnitVectorCompressionInfo = new [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html)(-1.024f, 10, 0.002f) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a90b6673b45d08d4d988695e21a91523a)LowResRadianCompressionInfo
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) TaleWorlds.MountAndBlade.CompressionBasic.LowResRadianCompressionInfo = new [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html)(-MBMath.PI - 0.01f, MBMath.PI + 0.01f, 8) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a87a087143778e11014cee97d2ae3f72c)RadianCompressionInfo
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) TaleWorlds.MountAndBlade.CompressionBasic.RadianCompressionInfo = new [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html)(-MBMath.PI - 0.01f, MBMath.PI + 0.01f, 10) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a2304d8a60c39d1da17ec409a90a9088e)HighResRadianCompressionInfo
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) TaleWorlds.MountAndBlade.CompressionBasic.HighResRadianCompressionInfo = new [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html)(-MBMath.PI - 0.01f, MBMath.PI + 0.01f, 13) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a684f143965271c1650f379a57d86af1a)UltResRadianCompressionInfo
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) TaleWorlds.MountAndBlade.CompressionBasic.UltResRadianCompressionInfo = new [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html)(-MBMath.PI - 0.01f, MBMath.PI + 0.01f, 30) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#af96cd547f2f843717efe2283966c8c8c)ScaleCompressionInfo
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) TaleWorlds.MountAndBlade.CompressionBasic.ScaleCompressionInfo = new [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html)(-0.001f, 10, 0.01f) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a69ce20688eb86a98865267e5058b7c24)LowResQuaternionCompressionInfo
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) TaleWorlds.MountAndBlade.CompressionBasic.LowResQuaternionCompressionInfo = new [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html)(-[MaxPossibleAbsValueForSecondMaxQuaternionComponent](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#ac2e35a7d2ee812da4b92611cb4133244), [MaxPossibleAbsValueForSecondMaxQuaternionComponent](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#ac2e35a7d2ee812da4b92611cb4133244), 6) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#aca90a1aa4dc015b8ffc49675e1e93ae0)OmittedQuaternionComponentIndexCompressionInfo
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.OmittedQuaternionComponentIndexCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(0, 3, true) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a5708581654c7ae55451c9165185086b0)ImpulseCompressionInfo
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) TaleWorlds.MountAndBlade.CompressionBasic.ImpulseCompressionInfo = new [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html)(-500.0f, 16, 0.0153f) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a442d5e12813f2f805701d3f1035b675e)AnimationKeyCompressionInfo
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.AnimationKeyCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(0, 8000, true) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a470b755d05cf83513d3cb9fe4a58074b)AnimationSpeedCompressionInfo
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) TaleWorlds.MountAndBlade.CompressionBasic.AnimationSpeedCompressionInfo = new [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html)(0.0f, 9, 0.01f) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a66625f0e7b8d94b5a250b57234443a38)AnimationProgressCompressionInfo
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) TaleWorlds.MountAndBlade.CompressionBasic.AnimationProgressCompressionInfo = new [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html)(0.0f, 1.0f, 9) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#ae851e3ac4263d9016d992dd7d9925a1b)VertexAnimationSpeedCompressionInfo
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) TaleWorlds.MountAndBlade.CompressionBasic.VertexAnimationSpeedCompressionInfo = new [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html)(0.0f, 9, 0.1f) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a9ce4dd83d0a0f51756da17fafa1e2362)PercentageCompressionInfo
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.PercentageCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(0, 100, true) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a7f04ed03461353373762e3b79765610a)EntityChildCountCompressionInfo
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.EntityChildCountCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(0, 8) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a99b8854d4c394c4d830b499e187812ad)AgentHitDamageCompressionInfo
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.AgentHitDamageCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(0, [Mission.MaxDamage](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a936c40e498722db2f74aaf1305b9ec77), true) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a3de93369af0304e2c991eaba93e38b76)AgentHitModifiedDamageCompressionInfo
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.AgentHitModifiedDamageCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(-[Mission.MaxDamage](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a936c40e498722db2f74aaf1305b9ec77), [Mission.MaxDamage](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a936c40e498722db2f74aaf1305b9ec77), true) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a670f01b95b436da6d4b00a2b09645e6a)AgentHitRelativeSpeedCompressionInfo
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) TaleWorlds.MountAndBlade.CompressionBasic.AgentHitRelativeSpeedCompressionInfo = new [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html)(0f, 17, 0.01f) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#af7abb0dcde8e1f153e599e40f34b3b71)AgentHitArmorCompressionInfo
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.AgentHitArmorCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(0, 200, true) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#ab3a7673fbfcaddd587207e545896d964)AgentHitBoneIndexCompressionInfo
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.AgentHitBoneIndexCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(-1, [Engine.Skeleton.MaxBoneCount](class_tale_worlds_1_1_engine_1_1_skeleton.html#a9977148fe283392a2ee2607dca227121) - 1, true) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a3aeb4bfe0d9a0601d32994299fc74a00)AgentHitBodyPartCompressionInfo
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.AgentHitBodyPartCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(-1, (int)[BoneBodyPartType.NumOfBodyPartTypes](namespace_tale_worlds_1_1_mount_and_blade.html#a88860bf2968d0069d9696746ebb47115ad7af6c3eb865e1a3d5eec472e0c9210c) - 1, true) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#ac65c02793912c488ed14f5b9ab5954b9)AgentHitDamageTypeCompressionInfo
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.AgentHitDamageTypeCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(-1, (int)DamageTypes.NumberOfDamageTypes - 1, true) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a5c2c8a818efff390fbbab879c8b8d683)RoundGoldAmountCompressionInfo
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.RoundGoldAmountCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(-1, [MissionMultiplayerGameModeBase.GoldCap](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#a3bcfe16586e4a457074927bd49f096d0), true) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a5b7390c2878de674d14a7dff4a826d59)DebugIntNonCompressionInfo
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.DebugIntNonCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(int.MinValue, sizeof(int) \* 8) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#aa218aaf778fddfa20d216090f26d6cf0)DebugULongNonCompressionInfo
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.UnsignedLongInteger](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_unsigned_long_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.DebugULongNonCompressionInfo = new [CompressionInfo.UnsignedLongInteger](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_unsigned_long_integer.html)(ulong.MinValue, sizeof(ulong) \* 8) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a1218fb14283b8bc9d3bab8be52fc6482)AgentAgeCompressionInfo
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) TaleWorlds.MountAndBlade.CompressionBasic.AgentAgeCompressionInfo = new [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html)(0f, [DynamicBodyProperties.MaxAge](struct_tale_worlds_1_1_core_1_1_dynamic_body_properties.html#a13dfa5d8a6fcc0f70a51bd40feea5ebf), 10) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a8a6d409a217cab9f824c7b353ddab635)FaceKeyDataCompressionInfo
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) TaleWorlds.MountAndBlade.CompressionBasic.FaceKeyDataCompressionInfo = new [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html)(0f, 1f, 10) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#ad9f319d56a5e94f1dd951451647a852b)PlayerChosenBadgeCompressionInfo
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.PlayerChosenBadgeCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(-1, 8) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a389329d9f067c647d80dcdbab373f515)MaxNumberOfPlayersCompressionInfo
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.MaxNumberOfPlayersCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(MultiplayerOptions.OptionType.MaxNumberOfPlayers.GetMinimumValue(), MultiplayerOptions.OptionType.MaxNumberOfPlayers.GetMaximumValue(), true) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#ae805788176ef51adaeccfd18e39865ce)MinNumberOfPlayersForMatchStartCompressionInfo
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.MinNumberOfPlayersForMatchStartCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(MultiplayerOptions.OptionType.MinNumberOfPlayersForMatchStart.GetMinimumValue(), MultiplayerOptions.OptionType.MinNumberOfPlayersForMatchStart.GetMaximumValue(), true) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a4c89a39b7700940a376a36914f02629a)MapTimeLimitCompressionInfo
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.MapTimeLimitCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(MultiplayerOptions.OptionType.MapTimeLimit.GetMinimumValue(), MultiplayerOptions.OptionType.MapTimeLimit.GetMaximumValue(), true) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a77ef947160e4fc793c951d500b88652f)RoundTotalCompressionInfo
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.RoundTotalCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(MultiplayerOptions.OptionType.RoundTotal.GetMinimumValue(), MultiplayerOptions.OptionType.RoundTotal.GetMaximumValue(), true) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#af1fa0938b060bf36b487fe5f406d6af6)RoundTimeLimitCompressionInfo
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.RoundTimeLimitCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(MultiplayerOptions.OptionType.RoundTimeLimit.GetMinimumValue(), MultiplayerOptions.OptionType.RoundTimeLimit.GetMaximumValue(), true) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#aa1d5e2b7319e86b9b53e7700bfaca17c)WarmupTimeLimitCompressionInfo
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.WarmupTimeLimitCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(MultiplayerOptions.OptionType.WarmupTimeLimitInSeconds.GetMinimumValue(), MultiplayerOptions.OptionType.WarmupTimeLimitInSeconds.GetMaximumValue(), true) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a67ac9b5167f25ef5ad3e9add53f55561)RoundPreparationTimeLimitCompressionInfo
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.RoundPreparationTimeLimitCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(MultiplayerOptions.OptionType.RoundPreparationTimeLimit.GetMinimumValue(), MultiplayerOptions.OptionType.RoundPreparationTimeLimit.GetMaximumValue(), true) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#afc7d21baa2735ab71422819ad2e576b4)RespawnPeriodCompressionInfo
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.RespawnPeriodCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(MultiplayerOptions.OptionType.RespawnPeriodTeam1.GetMinimumValue(), MultiplayerOptions.OptionType.RespawnPeriodTeam1.GetMaximumValue(), true) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#af0bf5a47ff44f2450c036e60b99208f2)GoldGainChangePercentageCompressionInfo
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.GoldGainChangePercentageCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(MultiplayerOptions.OptionType.GoldGainChangePercentageTeam1.GetMinimumValue(), MultiplayerOptions.OptionType.GoldGainChangePercentageTeam1.GetMaximumValue(), true) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a8a5f99d34f2c9b62f55f24ee9120af5d)SpectatorCameraTypeCompressionInfo
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.SpectatorCameraTypeCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)((int)SpectatorCameraTypes.Invalid, (int)SpectatorCameraTypes.Count - 1, true) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#ab04fd499f9d74f909671a6db7ce342d2)PollAcceptThresholdCompressionInfo
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.PollAcceptThresholdCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(MultiplayerOptions.OptionType.PollAcceptThreshold.GetMinimumValue(), MultiplayerOptions.OptionType.PollAcceptThreshold.GetMaximumValue(), true) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a3e46f933a42209859b2589baa9324494)NumberOfBotsTeamCompressionInfo
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.NumberOfBotsTeamCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(MultiplayerOptions.OptionType.NumberOfBotsTeam1.GetMinimumValue(), MultiplayerOptions.OptionType.NumberOfBotsTeam1.GetMaximumValue(), true) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a812f008d7ded7eefd1fd96db0cb75877)NumberOfBotsPerFormationCompressionInfo
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.NumberOfBotsPerFormationCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(MultiplayerOptions.OptionType.NumberOfBotsPerFormation.GetMinimumValue(), MultiplayerOptions.OptionType.NumberOfBotsPerFormation.GetMaximumValue(), true) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a950546689af961aaef40cfa02aab1884)AutoTeamBalanceLimitCompressionInfo
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.AutoTeamBalanceLimitCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(MultiplayerOptions.OptionType.AutoTeamBalanceThreshold.GetMinimumValue(), MultiplayerOptions.OptionType.AutoTeamBalanceThreshold.GetMaximumValue(), true) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a6d2c340f81fed023d60c7a4309ecc652)FriendlyFireDamageCompressionInfo
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.FriendlyFireDamageCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(MultiplayerOptions.OptionType.FriendlyFireDamageMeleeFriendPercent.GetMinimumValue(), MultiplayerOptions.OptionType.FriendlyFireDamageMeleeFriendPercent.GetMaximumValue(), true) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#aa4dc1e7824beceed6c9205d1d6f3766d)ForcedAvatarIndexCompressionInfo
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.ForcedAvatarIndexCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(-1, [LobbyNetworkComponent.MaxForcedAvatarIndex](class_tale_worlds_1_1_mount_and_blade_1_1_lobby_network_component.html#a28e40c7df321ca117ea78c8edce00877) - 1, true) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a029d6377b7997901a28fb3add625c673)IntermissionStateCompressionInfo
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.IntermissionStateCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(0, Enum.GetNames(typeof([MultiplayerIntermissionState](namespace_tale_worlds_1_1_mount_and_blade.html#a2bfb5cd35ce7c8036a28d0e0c8b4d793))).Length - 1, false) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a51e8b993343af73821ca82b100ad1a97)IntermissionTimerCompressionInfo
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) TaleWorlds.MountAndBlade.CompressionBasic.IntermissionTimerCompressionInfo = new [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html)(0, [BaseNetworkComponentData.MaxIntermissionStateTime](class_tale_worlds_1_1_mount_and_blade_1_1_base_network_component_data.html#a956ac8739054fe9f0527037bbe8f1161), 14) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a713958eeeba8d123bf2f0838767f4f49)IntermissionMapVoteItemCountCompressionInfo
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.IntermissionMapVoteItemCountCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(0, [MultiplayerIntermissionVotingManager.MaxAllowedMapCount](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a7bf5ed726f47999e4bc54c945ccdd3e7) - 1, true) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a09cd8a6a0bb974bb8f2b57c17b465b98)IntermissionVoterCountCompressionInfo
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.IntermissionVoterCountCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(0, [GameNetwork.MaxPlayerCount](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#aedd41b818a10f10f70ea30f96f1362bc) - 1, true) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a1ca13eb5481e67e5eaa0d3abea0afe31)ActionCodeCompressionInfo
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.ActionCodeCompressionInfo | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a3409c5a5be27e654c4331d5a5cf8c569)AnimationIndexCompressionInfo
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.AnimationIndexCompressionInfo | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#ab9ad616ec989bb6245c56cbec30340c2)CultureIndexCompressionInfo
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.CultureIndexCompressionInfo | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#aedae8fda15028c1612f3bdd3404bb981)SoundEventsCompressionInfo
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.SoundEventsCompressionInfo | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#aeac2ab5856d8bc73350c148433e468e6)NetworkComponentEventTypeFromServerCompressionInfo
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.NetworkComponentEventTypeFromServerCompressionInfo | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#ad9660d5b0659da8a8f988459a2049e57)NetworkComponentEventTypeFromClientCompressionInfo
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.NetworkComponentEventTypeFromClientCompressionInfo | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a25d9c61828e531a899a419a360052ac1)TroopTypeCompressionInfo
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.TroopTypeCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(-1, (int)TroopType.NumberOfTroopTypes - 1, true) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a54c49af28b07fb28f528f2c0dba59507)BannerDataCountCompressionInfo
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.BannerDataCountCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(0, [Banner.MaxIconCount](class_tale_worlds_1_1_core_1_1_banner.html#a02b3a58004f311623ea739377dc7a12b) - 1, true) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a19cfc791dce02d87ec4b21a4e6e4f38b)BannerDataMeshIdCompressionInfo
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.BannerDataMeshIdCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(0, 13) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a36c595149a7fdab2a15108b2107497c0)BannerDataColorIndexCompressionInfo
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.BannerDataColorIndexCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(0, 10) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a319612f1af1958065ae082816b2328ed)BannerDataSizeCompressionInfo
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.BannerDataSizeCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(-[Banner.MaxSize](class_tale_worlds_1_1_core_1_1_banner.html#a811cc5e35dc58567f13941dee47b2185), [Banner.MaxSize](class_tale_worlds_1_1_core_1_1_banner.html#a811cc5e35dc58567f13941dee47b2185), true) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_basic.html#a6546dc3f3884b103b14b34afb6886255)BannerDataRotationCompressionInfo
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionBasic.BannerDataRotationCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(0, 360, true) | | static |

