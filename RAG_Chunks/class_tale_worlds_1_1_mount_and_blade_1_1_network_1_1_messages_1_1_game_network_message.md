--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html ---

TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage Class ReferenceabstractInherited by , and .

|  |  |
| --- | --- |
| Public Member Functions | |
| delegate bool | [ClientMessageHandlerDelegate< T >](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a4f7293e681262dfd60d19aad41597a73) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) peer, T message) |
| delegate void | [ServerMessageHandlerDelegate< T >](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a93e96581e3109e4d4182ff1b5f953aac) (T message) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
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

|  |  |
| --- | --- |
| Protected Member Functions | |
| void | [OnWrite](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#aaab6ad4710548cbe4f1db0cd5b19aa14) () |
| bool | [OnRead](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a80aaf6eb516112d1fe191b528f4b243f) () |
| [MultiplayerMessageFilter](namespace_tale_worlds_1_1_mount_and_blade.html#a02a2c4373d544bcfecd2a1936115df67) | [OnGetLogFilter](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#ae2945546170dcb56934aa30cfcabe8ee) () |
| string | [OnGetLogFormat](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a033dd144d5fbe46fd2e4e0a409f2c719) () |

|  |  |
| --- | --- |
| Properties | |
| int | [MessageId](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#aa79a286c60ce92e0bbf0b6ee4c4cd070) `[get, set]` |
| static bool | [IsClientMissionOver](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a74c3915f66963abc7fabf91e32637b88) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a4f7293e681262dfd60d19aad41597a73)ClientMessageHandlerDelegate< T >()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate bool TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.ClientMessageHandlerDelegate< T > | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *peer*, |
|  |  | T | *message* ) |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[GameNetworkMessage](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html)* |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a93e96581e3109e4d4182ff1b5f953aac)ServerMessageHandlerDelegate< T >()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| delegate void TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.ServerMessageHandlerDelegate< T > | ( | T | *message* | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[GameNetworkMessage](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html)* |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#aaab6ad4710548cbe4f1db0cd5b19aa14)OnWrite()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.OnWrite | ( |  | ) |  | | abstractprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a80aaf6eb516112d1fe191b528f4b243f)OnRead()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.OnRead | ( |  | ) |  | | abstractprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#ae2945546170dcb56934aa30cfcabe8ee)OnGetLogFilter()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [MultiplayerMessageFilter](namespace_tale_worlds_1_1_mount_and_blade.html#a02a2c4373d544bcfecd2a1936115df67) TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.OnGetLogFilter | ( |  | ) |  | | abstractprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a033dd144d5fbe46fd2e4e0a409f2c719)OnGetLogFormat()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.OnGetLogFormat | ( |  | ) |  | | abstractprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#ac0abcbbfa3d9f7681b80d0a49bf1bca1)ReadBoolFromPacket()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.ReadBoolFromPacket | ( | ref bool | *bufferReadValid* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#aca0fe86eb4de45f80c93ef6dfd4b198f)WriteBoolToPacket()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.WriteBoolToPacket | ( | bool | *value* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#aa899814bc64fdaa645e01a765d33d1ef)ReadIntFromPacket()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.ReadIntFromPacket | ( | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | *compressionInfo*, | |  |  | ref bool | *bufferReadValid* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#ab9e2f7b96e8010ee8e2e61f8e40ec061)WriteIntToPacket()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.WriteIntToPacket | ( | int | *value*, | |  |  | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | *compressionInfo* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a42c9e00f18965f8c1fbffdd1e2af6022)ReadUintFromPacket()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | uint TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.ReadUintFromPacket | ( | [CompressionInfo.UnsignedInteger](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_unsigned_integer.html) | *compressionInfo*, | |  |  | ref bool | *bufferReadValid* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a44bd803a46233197ea5c38b13c586429)WriteUintToPacket()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.WriteUintToPacket | ( | uint | *value*, | |  |  | [CompressionInfo.UnsignedInteger](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_unsigned_integer.html) | *compressionInfo* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a8af8c2f25a3523a76cf76640e1f43402)ReadLongFromPacket()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | long TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.ReadLongFromPacket | ( | [CompressionInfo.LongInteger](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_long_integer.html) | *compressionInfo*, | |  |  | ref bool | *bufferReadValid* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a7cab426fa6b8286340aa9a250ae0a192)WriteLongToPacket()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.WriteLongToPacket | ( | long | *value*, | |  |  | [CompressionInfo.LongInteger](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_long_integer.html) | *compressionInfo* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a2da7e66d07370a2ecd913a0cb4f12d28)ReadUlongFromPacket()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | ulong TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.ReadUlongFromPacket | ( | [CompressionInfo.UnsignedLongInteger](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_unsigned_long_integer.html) | *compressionInfo*, | |  |  | ref bool | *bufferReadValid* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a20c1540a71bb61cc936d85fb1f891ea6)WriteUlongToPacket()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.WriteUlongToPacket | ( | ulong | *value*, | |  |  | [CompressionInfo.UnsignedLongInteger](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_unsigned_long_integer.html) | *compressionInfo* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a06b65d90a0fc0157f6d5c2d0d43ced25)ReadFloatFromPacket()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.ReadFloatFromPacket | ( | [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) | *compressionInfo*, | |  |  | ref bool | *bufferReadValid* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#acfdcc279ceb17c244cef33897ec41dc1)WriteFloatToPacket()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.WriteFloatToPacket | ( | float | *value*, | |  |  | [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) | *compressionInfo* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a4f50b3891336bdfdeae1b8ca9cda33b3)ReadStringFromPacket()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.ReadStringFromPacket | ( | ref bool | *bufferReadValid* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a51c749da77a7466944fcd055926a2074)WriteStringToPacket()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.WriteStringToPacket | ( | string | *value* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a0da5e2630477d8fe51915412a448740f)ReadByteArrayFromPacket()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.ReadByteArrayFromPacket | ( | byte[] | *buffer*, | |  |  | int | *offset*, | |  |  | int | *bufferCapacity*, | |  |  | ref bool | *bufferReadValid* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#afa81227e7ccbeff9cfda3c4f2046edcb)WriteBannerCodeToPacket()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.WriteBannerCodeToPacket | ( | string | *bannerCode* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a8bcda8dc6957437df1cbfe69e4cda2c7)ReadBannerCodeFromPacket()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.ReadBannerCodeFromPacket | ( | ref bool | *bufferReadValid* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a859d74724555dee6c4aa3032dc52ac5b)WriteByteArrayToPacket()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.WriteByteArrayToPacket | ( | byte[] | *value*, | |  |  | int | *offset*, | |  |  | int | *size* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a2df259c3943af768fd78cdf49ec8bcef)ReadActionSetReferenceFromPacket()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MBActionSet](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html) TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.ReadActionSetReferenceFromPacket | ( | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | *compressionInfo*, | |  |  | ref bool | *bufferReadValid* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a873d2ddf8acfafeeccaf64ef1b757f22)WriteActionSetReferenceToPacket()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.WriteActionSetReferenceToPacket | ( | [MBActionSet](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html) | *actionSet*, | |  |  | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | *compressionInfo* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#af316b3faef3307c3296a964b791f5c29)ReadAgentIndexFromPacket()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.ReadAgentIndexFromPacket | ( | ref bool | *bufferReadValid* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a683d3fb9c11459ca3309d297170e4179)WriteAgentIndexToPacket()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.WriteAgentIndexToPacket | ( | int | *agentIndex* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#aac197a2fa3b5419cb4ab1afee160f44c)ReadObjectReferenceFromPacket()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.ReadObjectReferenceFromPacket | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, | |  |  | [CompressionInfo.UnsignedInteger](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_unsigned_integer.html) | *compressionInfo*, | |  |  | ref bool | *bufferReadValid* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a93e1564f3cd8dc2f918e04f5d157f10f)WriteObjectReferenceToPacket()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.WriteObjectReferenceToPacket | ( | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | *value*, | |  |  | [CompressionInfo.UnsignedInteger](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_unsigned_integer.html) | *compressionInfo* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#aebecc152214282a0f432153827204a77)ReadVirtualPlayerReferenceToPacket()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [VirtualPlayer](class_tale_worlds_1_1_core_1_1_virtual_player.html) TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.ReadVirtualPlayerReferenceToPacket | ( | ref bool | *bufferReadValid*, | |  |  | bool | *canReturnNull* = false ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a92f18c716b0dc3ba81088b43ccfd58aa)ReadNetworkPeerReferenceFromPacket()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.ReadNetworkPeerReferenceFromPacket | ( | ref bool | *bufferReadValid*, | |  |  | bool | *canReturnNull* = false ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#afa90995513b08e6110da4bc4fa0d41f1)WriteVirtualPlayerReferenceToPacket()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.WriteVirtualPlayerReferenceToPacket | ( | [VirtualPlayer](class_tale_worlds_1_1_core_1_1_virtual_player.html) | *virtualPlayer* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#aa58b7c6bcecfdee2276df7968116118a)WriteNetworkPeerReferenceToPacket()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.WriteNetworkPeerReferenceToPacket | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkCommunicator* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a7c7f1da4316a5b8999258635d07868f8)ReadTeamIndexFromPacket()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.ReadTeamIndexFromPacket | ( | ref bool | *bufferReadValid* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a5f04d184f424c21c4142c38d94ea5ef3)WriteTeamIndexToPacket()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.WriteTeamIndexToPacket | ( | int | *teamIndex* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a7075c7bb131b81b2762bad2fbd9fb5de)ReadMissionObjectIdFromPacket()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [MissionObjectId](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_object_id.html) TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.ReadMissionObjectIdFromPacket | ( | ref bool | *bufferReadValid* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a6cf2cf20eed667ee3ee49bfa9c5e20a0)WriteMissionObjectIdToPacket()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.WriteMissionObjectIdToPacket | ( | [MissionObjectId](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_object_id.html) | *value* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#ae516cf18998576e58a8c790f5304f867)ReadVec3FromPacket()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.ReadVec3FromPacket | ( | [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) | *compressionInfo*, | |  |  | ref bool | *bufferReadValid* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a6007ce95afa32d6f415f0b32827c40d4)WriteVec3ToPacket()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.WriteVec3ToPacket | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *value*, | |  |  | [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) | *compressionInfo* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a6b562058ae596252f53fd555895e7b45)ReadVec2FromPacket()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.ReadVec2FromPacket | ( | [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) | *compressionInfo*, | |  |  | ref bool | *bufferReadValid* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a2a501fc37586117dd2aa9e9007d0b6ad)WriteVec2ToPacket()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.WriteVec2ToPacket | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *value*, | |  |  | [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) | *compressionInfo* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#adcecf52aa5213c0cbc545cd79c18b321)ReadRotationMatrixFromPacket()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html) TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.ReadRotationMatrixFromPacket | ( | ref bool | *bufferReadValid* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a9d9b840a85fbd858241e0acd8229adbe)WriteRotationMatrixToPacket()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.WriteRotationMatrixToPacket | ( | [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html) | *value* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a68acb5d4bb78368747347f532cf530a6)ReadMatrixFrameFromPacket()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.ReadMatrixFrameFromPacket | ( | ref bool | *bufferReadValid* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#ad9ce21f7334114bbb1220a5d9f80d9b0)WriteMatrixFrameToPacket()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.WriteMatrixFrameToPacket | ( | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#ab19b2782d2cebf472307b33203fff38a)ReadNonUniformTransformFromPacket()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.ReadNonUniformTransformFromPacket | ( | [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) | *positionCompressionInfo*, | |  |  | [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) | *quaternionCompressionInfo*, | |  |  | ref bool | *bufferReadValid* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#ad43e9b5c74fd20496f0b41d8d9e9e85d)WriteNonUniformTransformToPacket()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.WriteNonUniformTransformToPacket | ( | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame*, | |  |  | [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) | *positionCompressionInfo*, | |  |  | [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) | *quaternionCompressionInfo* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a0a3d7d3b37917056c66d2d9d5de6d6d3)ReadTransformFromPacket()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.ReadTransformFromPacket | ( | [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) | *positionCompressionInfo*, | |  |  | [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) | *quaternionCompressionInfo*, | |  |  | ref bool | *bufferReadValid* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#ab5f801c00babdf34da50a9582705789d)WriteTransformToPacket()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.WriteTransformToPacket | ( | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame*, | |  |  | [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) | *positionCompressionInfo*, | |  |  | [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) | *quaternionCompressionInfo* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a913ad55129af4c3ef0e74b6dcace8ce5)ReadUnitTransformFromPacket()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.ReadUnitTransformFromPacket | ( | [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) | *positionCompressionInfo*, | |  |  | [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) | *quaternionCompressionInfo*, | |  |  | ref bool | *bufferReadValid* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a65e3c0486451983c324ae68db403554b)WriteUnitTransformToPacket()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.WriteUnitTransformToPacket | ( | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame*, | |  |  | [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) | *positionCompressionInfo*, | |  |  | [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) | *quaternionCompressionInfo* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#afbbd4d763ae46b4864f76d4cc11dbbf3)ReadQuaternionFromPacket()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html) TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.ReadQuaternionFromPacket | ( | [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) | *compressionInfo*, | |  |  | ref bool | *bufferReadValid* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#acac6133ee44f43ca4e328c9c18e828a6)WriteQuaternionToPacket()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.WriteQuaternionToPacket | ( | [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html) | *q*, | |  |  | [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) | *compressionInfo* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#afefdc8060ddade38e108ebf9f6f25bdf)WriteBodyPropertiesToPacket()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.WriteBodyPropertiesToPacket | ( | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *bodyProperties* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a3980214aca8ca472e4be38faa1ad2f5c)ReadBodyPropertiesFromPacket()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.ReadBodyPropertiesFromPacket | ( | ref bool | *bufferReadValid* | ) |  | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#aa79a286c60ce92e0bbf0b6ee4c4cd070)MessageId
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.MessageId | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html#a74c3915f66963abc7fabf91e32637b88)IsClientMissionOver
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Network.Messages.GameNetworkMessage.IsClientMissionOver | | staticget |

