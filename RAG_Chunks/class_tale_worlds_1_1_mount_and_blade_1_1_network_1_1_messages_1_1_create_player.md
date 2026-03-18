--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_create_player.html ---

TaleWorlds.MountAndBlade.Network.Messages.CreatePlayer Class ReferencesealedInherits [TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [CreatePlayer](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_create_player.html#a8a65ea5c334a023dd50f05679d1909c8) (int playerIndex, string playerName, int disconnectedPeerIndex, bool isNonExistingDisconnectedPeer=false, bool isReceiverPeer=false) |
|  | [CreatePlayer](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_create_player.html#a3198186e7a619328ab726d2ed04da0b2) () |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html) | |
| delegate bool | [ClientMessageHandlerDelegate< T >](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a4f7293e681262dfd60d19aad41597a73) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) peer, T message) |
| delegate void | [ServerMessageHandlerDelegate< T >](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a93e96581e3109e4d4182ff1b5f953aac) (T message) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnWrite](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_create_player.html#a074f399a04eeb696e56bc7fadc05d507) () |
| override bool | [OnRead](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_create_player.html#a3c8896371c2df4cc5676bfd1f31e7a93) () |
| override [MultiplayerMessageFilter](namespace_tale_worlds_1_1_mount_and_blade.html#a02a2c4373d544bcfecd2a1936115df67) | [OnGetLogFilter](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_create_player.html#a33bac8f93dfd109d5591b74c7587ae23) () |
| override string | [OnGetLogFormat](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_create_player.html#ab45d6b7be42f2305a3ff45899bc0205d) () |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html) | |
| void | [OnWrite](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#aaab6ad4710548cbe4f1db0cd5b19aa14) () |
| bool | [OnRead](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a80aaf6eb516112d1fe191b528f4b243f) () |
| [MultiplayerMessageFilter](namespace_tale_worlds_1_1_mount_and_blade.html#a02a2c4373d544bcfecd2a1936115df67) | [OnGetLogFilter](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#ae2945546170dcb56934aa30cfcabe8ee) () |
| string | [OnGetLogFormat](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a033dd144d5fbe46fd2e4e0a409f2c719) () |

|  |  |
| --- | --- |
| Properties | |
| int | [PlayerIndex](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_create_player.html#a6a22ea1ade8f16340e02b14ac3534867) `[get]` |
| string | [PlayerName](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_create_player.html#a7a5ce9fa7dd146f773f5ed0bc816aefd) `[get]` |
| int | [DisconnectedPeerIndex](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_create_player.html#a2bd7b3b13150043f6bdb56129cb515e2) `[get]` |
| bool | [IsNonExistingDisconnectedPeer](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_create_player.html#aa342dfa79758d945f9bdf71d5c2bdf23) `[get]` |
| bool | [IsReceiverPeer](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_create_player.html#aaf01a894d8c70c209853bdaeb50233c3) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html) | |
| int | [MessageId](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#aa79a286c60ce92e0bbf0b6ee4c4cd070) `[get, set]` |
| static bool | [IsClientMissionOver](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a74c3915f66963abc7fabf91e32637b88) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html) | |
| static bool | [ReadBoolFromPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#ac0abcbbfa3d9f7681b80d0a49bf1bca1) (ref bool bufferReadValid) |
| static void | [WriteBoolToPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#aca0fe86eb4de45f80c93ef6dfd4b198f) (bool value) |
| static int | [ReadIntFromPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#aa899814bc64fdaa645e01a765d33d1ef) ([CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) compressionInfo, ref bool bufferReadValid) |
| static void | [WriteIntToPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#ab9e2f7b96e8010ee8e2e61f8e40ec061) (int value, [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) compressionInfo) |
| static uint | [ReadUintFromPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a42c9e00f18965f8c1fbffdd1e2af6022) ([CompressionInfo.UnsignedInteger](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_unsigned_integer.html) compressionInfo, ref bool bufferReadValid) |
| static void | [WriteUintToPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a44bd803a46233197ea5c38b13c586429) (uint value, [CompressionInfo.UnsignedInteger](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_unsigned_integer.html) compressionInfo) |
| static long | [ReadLongFromPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a8af8c2f25a3523a76cf76640e1f43402) ([CompressionInfo.LongInteger](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_long_integer.html) compressionInfo, ref bool bufferReadValid) |
| static void | [WriteLongToPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a7cab426fa6b8286340aa9a250ae0a192) (long value, [CompressionInfo.LongInteger](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_long_integer.html) compressionInfo) |
| static ulong | [ReadUlongFromPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a2da7e66d07370a2ecd913a0cb4f12d28) ([CompressionInfo.UnsignedLongInteger](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_unsigned_long_integer.html) compressionInfo, ref bool bufferReadValid) |
| static void | [WriteUlongToPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a20c1540a71bb61cc936d85fb1f891ea6) (ulong value, [CompressionInfo.UnsignedLongInteger](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_unsigned_long_integer.html) compressionInfo) |
| static float | [ReadFloatFromPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a06b65d90a0fc0157f6d5c2d0d43ced25) ([CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) compressionInfo, ref bool bufferReadValid) |
| static void | [WriteFloatToPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#acfdcc279ceb17c244cef33897ec41dc1) (float value, [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) compressionInfo) |
| static string | [ReadStringFromPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a4f50b3891336bdfdeae1b8ca9cda33b3) (ref bool bufferReadValid) |
| static void | [WriteStringToPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a51c749da77a7466944fcd055926a2074) (string value) |
| static int | [ReadByteArrayFromPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a0da5e2630477d8fe51915412a448740f) (byte[] buffer, int offset, int bufferCapacity, ref bool bufferReadValid) |
| static void | [WriteBannerCodeToPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#afa81227e7ccbeff9cfda3c4f2046edcb) (string bannerCode) |
| static string | [ReadBannerCodeFromPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a8bcda8dc6957437df1cbfe69e4cda2c7) (ref bool bufferReadValid) |
| static void | [WriteByteArrayToPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a859d74724555dee6c4aa3032dc52ac5b) (byte[] value, int offset, int size) |
| static [MBActionSet](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html) | [ReadActionSetReferenceFromPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a2df259c3943af768fd78cdf49ec8bcef) ([CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) compressionInfo, ref bool bufferReadValid) |
| static void | [WriteActionSetReferenceToPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a873d2ddf8acfafeeccaf64ef1b757f22) ([MBActionSet](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html) actionSet, [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) compressionInfo) |
| static int | [ReadAgentIndexFromPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#af316b3faef3307c3296a964b791f5c29) (ref bool bufferReadValid) |
| static void | [WriteAgentIndexToPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a683d3fb9c11459ca3309d297170e4179) (int agentIndex) |
| static [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | [ReadObjectReferenceFromPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#aac197a2fa3b5419cb4ab1afee160f44c) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, [CompressionInfo.UnsignedInteger](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_unsigned_integer.html) compressionInfo, ref bool bufferReadValid) |
| static void | [WriteObjectReferenceToPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a93e1564f3cd8dc2f918e04f5d157f10f) ([MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) value, [CompressionInfo.UnsignedInteger](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_unsigned_integer.html) compressionInfo) |
| static [VirtualPlayer](class_tale_worlds_1_1_core_1_1_virtual_player.html) | [ReadVirtualPlayerReferenceToPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#aebecc152214282a0f432153827204a77) (ref bool bufferReadValid, bool canReturnNull=false) |
| static [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | [ReadNetworkPeerReferenceFromPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a92f18c716b0dc3ba81088b43ccfd58aa) (ref bool bufferReadValid, bool canReturnNull=false) |
| static void | [WriteVirtualPlayerReferenceToPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#afa90995513b08e6110da4bc4fa0d41f1) ([VirtualPlayer](class_tale_worlds_1_1_core_1_1_virtual_player.html) virtualPlayer) |
| static void | [WriteNetworkPeerReferenceToPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#aa58b7c6bcecfdee2276df7968116118a) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkCommunicator) |
| static int | [ReadTeamIndexFromPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a7c7f1da4316a5b8999258635d07868f8) (ref bool bufferReadValid) |
| static void | [WriteTeamIndexToPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a5f04d184f424c21c4142c38d94ea5ef3) (int teamIndex) |
| static [MissionObjectId](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_object_id.html) | [ReadMissionObjectIdFromPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a7075c7bb131b81b2762bad2fbd9fb5de) (ref bool bufferReadValid) |
| static void | [WriteMissionObjectIdToPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a6cf2cf20eed667ee3ee49bfa9c5e20a0) ([MissionObjectId](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_object_id.html) value) |
| static [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [ReadVec3FromPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#ae516cf18998576e58a8c790f5304f867) ([CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) compressionInfo, ref bool bufferReadValid) |
| static void | [WriteVec3ToPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a6007ce95afa32d6f415f0b32827c40d4) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) value, [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) compressionInfo) |
| static [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [ReadVec2FromPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a6b562058ae596252f53fd555895e7b45) ([CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) compressionInfo, ref bool bufferReadValid) |
| static void | [WriteVec2ToPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a2a501fc37586117dd2aa9e9007d0b6ad) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) value, [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) compressionInfo) |
| static [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html) | [ReadRotationMatrixFromPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#adcecf52aa5213c0cbc545cd79c18b321) (ref bool bufferReadValid) |
| static void | [WriteRotationMatrixToPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a9d9b840a85fbd858241e0acd8229adbe) ([Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html) value) |
| static [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [ReadMatrixFrameFromPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a68acb5d4bb78368747347f532cf530a6) (ref bool bufferReadValid) |
| static void | [WriteMatrixFrameToPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#ad9ce21f7334114bbb1220a5d9f80d9b0) ([MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame) |
| static [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [ReadNonUniformTransformFromPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#ab19b2782d2cebf472307b33203fff38a) ([CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) positionCompressionInfo, [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) quaternionCompressionInfo, ref bool bufferReadValid) |
| static void | [WriteNonUniformTransformToPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#ad43e9b5c74fd20496f0b41d8d9e9e85d) ([MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame, [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) positionCompressionInfo, [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) quaternionCompressionInfo) |
| static [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [ReadTransformFromPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a0a3d7d3b37917056c66d2d9d5de6d6d3) ([CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) positionCompressionInfo, [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) quaternionCompressionInfo, ref bool bufferReadValid) |
| static void | [WriteTransformToPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#ab5f801c00babdf34da50a9582705789d) ([MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame, [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) positionCompressionInfo, [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) quaternionCompressionInfo) |
| static [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [ReadUnitTransformFromPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a913ad55129af4c3ef0e74b6dcace8ce5) ([CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) positionCompressionInfo, [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) quaternionCompressionInfo, ref bool bufferReadValid) |
| static void | [WriteUnitTransformToPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a65e3c0486451983c324ae68db403554b) ([MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame, [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) positionCompressionInfo, [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) quaternionCompressionInfo) |
| static [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html) | [ReadQuaternionFromPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#afbbd4d763ae46b4864f76d4cc11dbbf3) ([CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) compressionInfo, ref bool bufferReadValid) |
| static void | [WriteQuaternionToPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#acac6133ee44f43ca4e328c9c18e828a6) ([Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html) q, [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) compressionInfo) |
| static void | [WriteBodyPropertiesToPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#afefdc8060ddade38e108ebf9f6f25bdf) ([BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) bodyProperties) |
| static [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | [ReadBodyPropertiesFromPacket](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a3980214aca8ca472e4be38faa1ad2f5c) (ref bool bufferReadValid) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_create_player.html#a8a65ea5c334a023dd50f05679d1909c8)CreatePlayer() [1/2]
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.Network.Messages.CreatePlayer.CreatePlayer | ( | int | *playerIndex*, |
|  |  | string | *playerName*, |
|  |  | int | *disconnectedPeerIndex*, |
|  |  | bool | *isNonExistingDisconnectedPeer* = false, |
|  |  | bool | *isReceiverPeer* = false ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_create_player.html#a3198186e7a619328ab726d2ed04da0b2)CreatePlayer() [2/2]
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.Network.Messages.CreatePlayer.CreatePlayer | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_create_player.html#a074f399a04eeb696e56bc7fadc05d507)OnWrite()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.Network.Messages.CreatePlayer.OnWrite | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_create_player.html#a3c8896371c2df4cc5676bfd1f31e7a93)OnRead()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override bool TaleWorlds.MountAndBlade.Network.Messages.CreatePlayer.OnRead | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_create_player.html#a33bac8f93dfd109d5591b74c7587ae23)OnGetLogFilter()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [MultiplayerMessageFilter](namespace_tale_worlds_1_1_mount_and_blade.html#a02a2c4373d544bcfecd2a1936115df67) TaleWorlds.MountAndBlade.Network.Messages.CreatePlayer.OnGetLogFilter | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_create_player.html#ab45d6b7be42f2305a3ff45899bc0205d)OnGetLogFormat()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override string TaleWorlds.MountAndBlade.Network.Messages.CreatePlayer.OnGetLogFormat | ( |  | ) |  | | protected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_create_player.html#a6a22ea1ade8f16340e02b14ac3534867)PlayerIndex
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.Network.Messages.CreatePlayer.PlayerIndex | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_create_player.html#a7a5ce9fa7dd146f773f5ed0bc816aefd)PlayerName
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.Network.Messages.CreatePlayer.PlayerName | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_create_player.html#a2bd7b3b13150043f6bdb56129cb515e2)DisconnectedPeerIndex
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.Network.Messages.CreatePlayer.DisconnectedPeerIndex | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_create_player.html#aa342dfa79758d945f9bdf71d5c2bdf23)IsNonExistingDisconnectedPeer
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Network.Messages.CreatePlayer.IsNonExistingDisconnectedPeer | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_create_player.html#aaf01a894d8c70c209853bdaeb50233c3)IsReceiverPeer
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Network.Messages.CreatePlayer.IsReceiverPeer | | get |

