--- SOURCE: class_tale_worlds_1_1_engine_1_1_particle_system.html ---

TaleWorlds.Engine.ParticleSystem Class ReferencesealedInherits [TaleWorlds.Engine.GameEntityComponent](class_tale_worlds_1_1_engine_1_1_game_entity_component.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [AddMesh](class_tale_worlds_1_1_engine_1_1_particle_system.html#a2dcf0310d34a8c605f9b043dceda2469) ([Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) mesh) |
| void | [SetEnable](class_tale_worlds_1_1_engine_1_1_particle_system.html#ad80b68af4979848b572b61cdae9619b3) (bool enable) |
| void | [SetRuntimeEmissionRateMultiplier](class_tale_worlds_1_1_engine_1_1_particle_system.html#a99c0008214a720bb14e9e78a3b23ebc5) (float multiplier) |
| void | [Restart](class_tale_worlds_1_1_engine_1_1_particle_system.html#a11a0cd9ef6fd157dd4f9967a478cc35e) () |
| void | [SetLocalFrame](class_tale_worlds_1_1_engine_1_1_particle_system.html#ad10978f862651a2c47ad248047b13ef8) (in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) newLocalFrame) |
| void | [SetPreviousGlobalFrame](class_tale_worlds_1_1_engine_1_1_particle_system.html#aa4c15e8404e1273db683567f5f8d2534) (in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) globalFrame) |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetLocalFrame](class_tale_worlds_1_1_engine_1_1_particle_system.html#a093d18b4d7c88ed7f59ff0e60a84c37b) () |
| bool | [HasAliveParticles](class_tale_worlds_1_1_engine_1_1_particle_system.html#af84e0d9b89e25d79b01e3fbd56e25b84) () |
| void | [SetDontRemoveFromEntity](class_tale_worlds_1_1_engine_1_1_particle_system.html#aec23048a2bc88b879815564df9782d68) (bool value) |
| void | [SetParticleEffectByName](class_tale_worlds_1_1_engine_1_1_particle_system.html#a07136df96812d6d593bb72c05ea90002) (string effectName) |
| Public Member Functions inherited from [TaleWorlds.Engine.GameEntityComponent](class_tale_worlds_1_1_engine_1_1_game_entity_component.html) | |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | [GetEntity](class_tale_worlds_1_1_engine_1_1_game_entity_component.html#aa0b6323b87a63cb1e3ecba9b07328583) () |
| virtual [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | [GetFirstMetaMesh](class_tale_worlds_1_1_engine_1_1_game_entity_component.html#aa70e6c4e14725db6c11c3638d4336c03) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static ParticleSystem | [CreateParticleSystemAttachedToBone](class_tale_worlds_1_1_engine_1_1_particle_system.html#a72200c9138312ff691261ac1aff451e5) (string systemName, [Skeleton](class_tale_worlds_1_1_engine_1_1_skeleton.html) skeleton, sbyte boneIndex, ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) boneLocalFrame) |
|  | WARNING! DONT USE THIS FUNCTION FOR AGENT SKELETONS.  AgentVisuals.CreateParticleSystemAttachedToBone(). |
| static ParticleSystem | [CreateParticleSystemAttachedToBone](class_tale_worlds_1_1_engine_1_1_particle_system.html#aff36d6d5060bd065dd099cdeef0ba025) (int systemRuntimeId, [Skeleton](class_tale_worlds_1_1_engine_1_1_skeleton.html) skeleton, sbyte boneIndex, ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) boneLocalFrame) |
|  | WARNING! DONT USE THIS FUNCTION FOR AGENT SKELETONS.  AgentVisuals.CreateParticleSystemAttachedToBone(). |
| static ParticleSystem | [CreateParticleSystemAttachedToEntity](class_tale_worlds_1_1_engine_1_1_particle_system.html#a196f7930e449b3d8a8e7cf7fb56ba81c) (string systemName, [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) parentEntity, ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) boneLocalFrame) |
| static ParticleSystem | [CreateParticleSystemAttachedToEntity](class_tale_worlds_1_1_engine_1_1_particle_system.html#ae3ef122351396ae268303ee20b2b1cf3) (string systemName, [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) parentEntity, ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) boneLocalFrame) |
| static ParticleSystem | [CreateParticleSystemAttachedToEntity](class_tale_worlds_1_1_engine_1_1_particle_system.html#a2723d250bd8e3022518c6d568e1cbf9f) (int systemRuntimeId, [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) parentEntity, ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) boneLocalFrame) |
| static ParticleSystem | [CreateParticleSystemAttachedToEntity](class_tale_worlds_1_1_engine_1_1_particle_system.html#aabfa311d0d023983e91c136b523303c4) (int systemRuntimeId, [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) parentEntity, ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) boneLocalFrame) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_engine_1_1_particle_system.html#a72200c9138312ff691261ac1aff451e5)CreateParticleSystemAttachedToBone() [1/2]
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | ParticleSystem TaleWorlds.Engine.ParticleSystem.CreateParticleSystemAttachedToBone | ( | string | *systemName*, | |  |  | [Skeleton](class_tale_worlds_1_1_engine_1_1_skeleton.html) | *skeleton*, | |  |  | sbyte | *boneIndex*, | |  |  | ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *boneLocalFrame* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_particle_system.html#aff36d6d5060bd065dd099cdeef0ba025)CreateParticleSystemAttachedToBone() [2/2]
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | ParticleSystem TaleWorlds.Engine.ParticleSystem.CreateParticleSystemAttachedToBone | ( | int | *systemRuntimeId*, | |  |  | [Skeleton](class_tale_worlds_1_1_engine_1_1_skeleton.html) | *skeleton*, | |  |  | sbyte | *boneIndex*, | |  |  | ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *boneLocalFrame* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_particle_system.html#a196f7930e449b3d8a8e7cf7fb56ba81c)CreateParticleSystemAttachedToEntity() [1/4]
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | ParticleSystem TaleWorlds.Engine.ParticleSystem.CreateParticleSystemAttachedToEntity | ( | string | *systemName*, | |  |  | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *parentEntity*, | |  |  | ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *boneLocalFrame* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_particle_system.html#ae3ef122351396ae268303ee20b2b1cf3)CreateParticleSystemAttachedToEntity() [2/4]
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | ParticleSystem TaleWorlds.Engine.ParticleSystem.CreateParticleSystemAttachedToEntity | ( | string | *systemName*, | |  |  | [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *parentEntity*, | |  |  | ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *boneLocalFrame* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_particle_system.html#a2723d250bd8e3022518c6d568e1cbf9f)CreateParticleSystemAttachedToEntity() [3/4]
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | ParticleSystem TaleWorlds.Engine.ParticleSystem.CreateParticleSystemAttachedToEntity | ( | int | *systemRuntimeId*, | |  |  | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *parentEntity*, | |  |  | ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *boneLocalFrame* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_particle_system.html#aabfa311d0d023983e91c136b523303c4)CreateParticleSystemAttachedToEntity() [4/4]
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | ParticleSystem TaleWorlds.Engine.ParticleSystem.CreateParticleSystemAttachedToEntity | ( | int | *systemRuntimeId*, | |  |  | [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *parentEntity*, | |  |  | ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *boneLocalFrame* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_particle_system.html#a2dcf0310d34a8c605f9b043dceda2469)AddMesh()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.ParticleSystem.AddMesh | ( | [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) | *mesh* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_particle_system.html#ad80b68af4979848b572b61cdae9619b3)SetEnable()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.ParticleSystem.SetEnable | ( | bool | *enable* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_particle_system.html#a99c0008214a720bb14e9e78a3b23ebc5)SetRuntimeEmissionRateMultiplier()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.ParticleSystem.SetRuntimeEmissionRateMultiplier | ( | float | *multiplier* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_particle_system.html#a11a0cd9ef6fd157dd4f9967a478cc35e)Restart()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.ParticleSystem.Restart | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_particle_system.html#ad10978f862651a2c47ad248047b13ef8)SetLocalFrame()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.ParticleSystem.SetLocalFrame | ( | in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *newLocalFrame* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_particle_system.html#aa4c15e8404e1273db683567f5f8d2534)SetPreviousGlobalFrame()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.ParticleSystem.SetPreviousGlobalFrame | ( | in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *globalFrame* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_particle_system.html#a093d18b4d7c88ed7f59ff0e60a84c37b)GetLocalFrame()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.Engine.ParticleSystem.GetLocalFrame | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_particle_system.html#af84e0d9b89e25d79b01e3fbd56e25b84)HasAliveParticles()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.ParticleSystem.HasAliveParticles | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_particle_system.html#aec23048a2bc88b879815564df9782d68)SetDontRemoveFromEntity()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.ParticleSystem.SetDontRemoveFromEntity | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_particle_system.html#a07136df96812d6d593bb72c05ea90002)SetParticleEffectByName()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.ParticleSystem.SetParticleEffectByName | ( | string | *effectName* | ) |  |

