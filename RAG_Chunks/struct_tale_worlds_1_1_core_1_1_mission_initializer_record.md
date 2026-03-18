--- SOURCE: struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html ---

TaleWorlds.Core.MissionInitializerRecord Struct ReferenceInherits [TaleWorlds.Library.ISerializableObject](interface_tale_worlds_1_1_library_1_1_i_serializable_object.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MissionInitializerRecord](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#a4a69d324c34fc6281771e2b057e04730) (string name) |
| void ISerializableObject. | [DeserializeFrom](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#afb652aa531dc2ed1c8a0fdb18b4a542f) ([IReader](interface_tale_worlds_1_1_library_1_1_i_reader.html) reader) |
| void ISerializableObject. | [SerializeTo](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#a100b6f27b2b7023660bc61ba107a0fa5) ([IWriter](interface_tale_worlds_1_1_library_1_1_i_writer.html) writer) |

|  |  |
| --- | --- |
| Public Attributes | |
| int | [TerrainType](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#a51e46848a9913319e36af5cffe763a9c) |
| float | [DamageToFriendsMultiplier](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#a9fbde4458f3a692f2c915dacf46366c2) |
| float | [DamageFromPlayerToFriendsMultiplier](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#ac7aa66128e5975c164b303081e39e61d) |
| bool | [NeedsRandomTerrain](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#a51ede46d06805a96efa0da5384d61a05) |
| int | [RandomTerrainSeed](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#a6aba436871034110f9628d4c12d69f74) |
| string | [SceneName](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#ac4390e6271c5f0dd5f4230079b4d3cf6) |
| string | [SceneLevels](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#a190a06eebc08e0d9d15994e5a6bcb846) |
| bool | [PlayingInCampaignMode](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#aeecb407ec1a0710f86735147da3e96f4) |
| bool | [EnableSceneRecording](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#a17715ef78555c569639cb9a364a33fe3) |
| int | [SceneUpgradeLevel](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#a862edc8271e6e301aae47c3c2c375890) |
| bool | [SceneHasMapPatch](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#a05045e09dd0e113d2a64a65154f0d4a9) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [PatchCoordinates](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#a99fb30a64c8fab3817a579d57f5ed746) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [PatchEncounterDir](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#a64d6082f295c5a5bcfbc47c4911ff93e) |
| bool | [DoNotUseLoadingScreen](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#a8bf72e39992e40470a04b006a74cd58d) |
| bool | [DisableDynamicPointlightShadows](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#a822f326aaac568e887f406c630aca5c3) |
| bool | [DisableCorpseFadeOut](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#a08cc88e6c6ca8b322f1efe363842e7a9) |
| int | [DecalAtlasGroup](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#ae264eeb6b030ac76f1799eda68882e63) |
| [AtmosphereInfo](struct_tale_worlds_1_1_library_1_1_atmosphere_info.html) | [AtmosphereOnCampaign](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#a8385c04a66cb4f957dd2ec53416f0bd0) |

Constructor & Destructor Documentation
--------------------------------------

[◆](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#a4a69d324c34fc6281771e2b057e04730)MissionInitializerRecord()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Core.MissionInitializerRecord.MissionInitializerRecord | ( | string | *name* | ) |  |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#afb652aa531dc2ed1c8a0fdb18b4a542f)DeserializeFrom()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void ISerializableObject. TaleWorlds.Core.MissionInitializerRecord.DeserializeFrom | ( | [IReader](interface_tale_worlds_1_1_library_1_1_i_reader.html) | *reader* | ) |  |

Implements [TaleWorlds.Library.ISerializableObject](interface_tale_worlds_1_1_library_1_1_i_serializable_object.html#aaaf5181fea51c7c2d4e365efe82bc703).

[◆](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#a100b6f27b2b7023660bc61ba107a0fa5)SerializeTo()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void ISerializableObject. TaleWorlds.Core.MissionInitializerRecord.SerializeTo | ( | [IWriter](interface_tale_worlds_1_1_library_1_1_i_writer.html) | *writer* | ) |  |

Implements [TaleWorlds.Library.ISerializableObject](interface_tale_worlds_1_1_library_1_1_i_serializable_object.html#aac913af86c2a4128993048fc2023b4de).

Member Data Documentation
-------------------------

[◆](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#a51e46848a9913319e36af5cffe763a9c)TerrainType
-----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.Core.MissionInitializerRecord.TerrainType |

[◆](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#a9fbde4458f3a692f2c915dacf46366c2)DamageToFriendsMultiplier
-------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.Core.MissionInitializerRecord.DamageToFriendsMultiplier |

[◆](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#ac7aa66128e5975c164b303081e39e61d)DamageFromPlayerToFriendsMultiplier
-----------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.Core.MissionInitializerRecord.DamageFromPlayerToFriendsMultiplier |

[◆](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#a51ede46d06805a96efa0da5384d61a05)NeedsRandomTerrain
------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.Core.MissionInitializerRecord.NeedsRandomTerrain |

[◆](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#a6aba436871034110f9628d4c12d69f74)RandomTerrainSeed
-----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.Core.MissionInitializerRecord.RandomTerrainSeed |

[◆](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#ac4390e6271c5f0dd5f4230079b4d3cf6)SceneName
---------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.Core.MissionInitializerRecord.SceneName |

[◆](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#a190a06eebc08e0d9d15994e5a6bcb846)SceneLevels
-----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.Core.MissionInitializerRecord.SceneLevels |

[◆](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#aeecb407ec1a0710f86735147da3e96f4)PlayingInCampaignMode
---------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.Core.MissionInitializerRecord.PlayingInCampaignMode |

[◆](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#a17715ef78555c569639cb9a364a33fe3)EnableSceneRecording
--------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.Core.MissionInitializerRecord.EnableSceneRecording |

[◆](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#a862edc8271e6e301aae47c3c2c375890)SceneUpgradeLevel
-----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.Core.MissionInitializerRecord.SceneUpgradeLevel |

[◆](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#a05045e09dd0e113d2a64a65154f0d4a9)SceneHasMapPatch
----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.Core.MissionInitializerRecord.SceneHasMapPatch |

[◆](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#a99fb30a64c8fab3817a579d57f5ed746)PatchCoordinates
----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.Core.MissionInitializerRecord.PatchCoordinates |

[◆](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#a64d6082f295c5a5bcfbc47c4911ff93e)PatchEncounterDir
-----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.Core.MissionInitializerRecord.PatchEncounterDir |

[◆](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#a8bf72e39992e40470a04b006a74cd58d)DoNotUseLoadingScreen
---------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.Core.MissionInitializerRecord.DoNotUseLoadingScreen |

[◆](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#a822f326aaac568e887f406c630aca5c3)DisableDynamicPointlightShadows
-------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.Core.MissionInitializerRecord.DisableDynamicPointlightShadows |

[◆](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#a08cc88e6c6ca8b322f1efe363842e7a9)DisableCorpseFadeOut
--------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.Core.MissionInitializerRecord.DisableCorpseFadeOut |

[◆](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#ae264eeb6b030ac76f1799eda68882e63)DecalAtlasGroup
---------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.Core.MissionInitializerRecord.DecalAtlasGroup |

[◆](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#a8385c04a66cb4f957dd2ec53416f0bd0)AtmosphereOnCampaign
--------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [AtmosphereInfo](struct_tale_worlds_1_1_library_1_1_atmosphere_info.html) TaleWorlds.Core.MissionInitializerRecord.AtmosphereOnCampaign |

