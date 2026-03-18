--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_compression_matchmaker.html ---

TaleWorlds.MountAndBlade.CompressionMatchmaker Class Reference|  |  |
| --- | --- |
| Static Public Attributes | |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [KillDeathAssistCountCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_matchmaker.html#addaa8c83a0f239656de0d764f51af4e9) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)([MissionPeer.MinKDACount](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a72c90ee97bd4f653e04e61069b5641a2), [MissionPeer.MaxKDACount](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#af687e2a471f976126fa4ee082f1cb08f), true) |
| static [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) | [MissionTimeCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_matchmaker.html#ae8c57e794c37850d7414b787db472a60) = new [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html)(-5.0f, 60.0f \* 60.0f \* 24.0f, 20) |
| static [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) | [MissionTimeLowPrecisionCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_matchmaker.html#a3a87fcaf82174f4e327dabedf0896e5f) = new [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html)(-5.0f, 12, 4.0f) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [MissionCurrentStateCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_matchmaker.html#a33ad1fb732624cd90f8d3466bf8d1d9c) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(0, 6) |
| static [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) | [ScoreCompressionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_compression_matchmaker.html#a1602c41b4b60f5992790b89996c60075) = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(-1000000, 21) |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_matchmaker.html#addaa8c83a0f239656de0d764f51af4e9)KillDeathAssistCountCompressionInfo
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionMatchmaker.KillDeathAssistCountCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)([MissionPeer.MinKDACount](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a72c90ee97bd4f653e04e61069b5641a2), [MissionPeer.MaxKDACount](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#af687e2a471f976126fa4ee082f1cb08f), true) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_matchmaker.html#ae8c57e794c37850d7414b787db472a60)MissionTimeCompressionInfo
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) TaleWorlds.MountAndBlade.CompressionMatchmaker.MissionTimeCompressionInfo = new [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html)(-5.0f, 60.0f \* 60.0f \* 24.0f, 20) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_matchmaker.html#a3a87fcaf82174f4e327dabedf0896e5f)MissionTimeLowPrecisionCompressionInfo
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html) TaleWorlds.MountAndBlade.CompressionMatchmaker.MissionTimeLowPrecisionCompressionInfo = new [CompressionInfo.Float](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_float.html)(-5.0f, 12, 4.0f) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_matchmaker.html#a33ad1fb732624cd90f8d3466bf8d1d9c)MissionCurrentStateCompressionInfo
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionMatchmaker.MissionCurrentStateCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(0, 6) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_compression_matchmaker.html#a1602c41b4b60f5992790b89996c60075)ScoreCompressionInfo
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html) TaleWorlds.MountAndBlade.CompressionMatchmaker.ScoreCompressionInfo = new [CompressionInfo.Integer](struct_tale_worlds_1_1_mount_and_blade_1_1_compression_info_1_1_integer.html)(-1000000, 21) | | static |

