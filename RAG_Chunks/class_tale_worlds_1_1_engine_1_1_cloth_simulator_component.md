--- SOURCE: class_tale_worlds_1_1_engine_1_1_cloth_simulator_component.html ---

TaleWorlds.Engine.ClothSimulatorComponent Class ReferencesealedInherits [TaleWorlds.Engine.GameEntityComponent](class_tale_worlds_1_1_engine_1_1_game_entity_component.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [SetMaxDistanceMultiplier](class_tale_worlds_1_1_engine_1_1_cloth_simulator_component.html#a230ca1f10e189bd7be5695d3db36d1cd) (float multiplier) |
| void | [SetForcedWind](class_tale_worlds_1_1_engine_1_1_cloth_simulator_component.html#a348c0c9d8b347b673131b2645a89da71) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) windVector, bool isLocal) |
| void | [DisableForcedWind](class_tale_worlds_1_1_engine_1_1_cloth_simulator_component.html#a02f58cd44cb06bb0009a34cd70238b98) () |
| void | [SetForcedGustStrength](class_tale_worlds_1_1_engine_1_1_cloth_simulator_component.html#a5327ef69056e0e6f5186e45fcbab8989) (float gustStrength) |
| void | [SetResetRequired](class_tale_worlds_1_1_engine_1_1_cloth_simulator_component.html#a528bfc9a4364fe8d29645994807119ca) () |
| void | [DisableMorphAnimation](class_tale_worlds_1_1_engine_1_1_cloth_simulator_component.html#a0da51fc1ec2cfabbc06461ee2009732a) () |
| void | [SetMorphBuffer](class_tale_worlds_1_1_engine_1_1_cloth_simulator_component.html#a6888f7ace49780134d64ef789eec15d3) (float morphKey) |
| int | [GetNumberOfMorphKeys](class_tale_worlds_1_1_engine_1_1_cloth_simulator_component.html#a6a774e61b9dff25deaab286a6f4696c5) () |
| void | [SetVectorArgument](class_tale_worlds_1_1_engine_1_1_cloth_simulator_component.html#a2881bdae1654dc3e9a124e919a8f5e9d) (float x, float y, float z, float w) |
| void | [GetMorphAnimLeftPoints](class_tale_worlds_1_1_engine_1_1_cloth_simulator_component.html#a2f1df8a2e769e76f0000163f747eeb60) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html)[] leftPoints) |
| void | [GetMorphAnimRightPoints](class_tale_worlds_1_1_engine_1_1_cloth_simulator_component.html#a6ed98aea446cdcaf93ed8ed46a3c37f5) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html)[] rightPoints) |
| void | [GetMorphAnimCenterPoints](class_tale_worlds_1_1_engine_1_1_cloth_simulator_component.html#af6c96e0d4abee1916e9f71fb19a86f5c) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html)[] centerPoints) |
| void | [SetForcedVelocity](class_tale_worlds_1_1_engine_1_1_cloth_simulator_component.html#a4929a2f5f54d8136401a003e9f90bc4b) (in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) forcedVelocity) |
| Public Member Functions inherited from [TaleWorlds.Engine.GameEntityComponent](class_tale_worlds_1_1_engine_1_1_game_entity_component.html) | |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | [GetEntity](class_tale_worlds_1_1_engine_1_1_game_entity_component.html#aa0b6323b87a63cb1e3ecba9b07328583) () |
| virtual [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | [GetFirstMetaMesh](class_tale_worlds_1_1_engine_1_1_game_entity_component.html#aa70e6c4e14725db6c11c3638d4336c03) () |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_engine_1_1_cloth_simulator_component.html#a230ca1f10e189bd7be5695d3db36d1cd)SetMaxDistanceMultiplier()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.ClothSimulatorComponent.SetMaxDistanceMultiplier | ( | float | *multiplier* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_cloth_simulator_component.html#a348c0c9d8b347b673131b2645a89da71)SetForcedWind()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.ClothSimulatorComponent.SetForcedWind | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *windVector*, |
|  |  | bool | *isLocal* ) |

[◆](class_tale_worlds_1_1_engine_1_1_cloth_simulator_component.html#a02f58cd44cb06bb0009a34cd70238b98)DisableForcedWind()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.ClothSimulatorComponent.DisableForcedWind | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_cloth_simulator_component.html#a5327ef69056e0e6f5186e45fcbab8989)SetForcedGustStrength()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.ClothSimulatorComponent.SetForcedGustStrength | ( | float | *gustStrength* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_cloth_simulator_component.html#a528bfc9a4364fe8d29645994807119ca)SetResetRequired()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.ClothSimulatorComponent.SetResetRequired | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_cloth_simulator_component.html#a0da51fc1ec2cfabbc06461ee2009732a)DisableMorphAnimation()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.ClothSimulatorComponent.DisableMorphAnimation | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_cloth_simulator_component.html#a6888f7ace49780134d64ef789eec15d3)SetMorphBuffer()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.ClothSimulatorComponent.SetMorphBuffer | ( | float | *morphKey* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_cloth_simulator_component.html#a6a774e61b9dff25deaab286a6f4696c5)GetNumberOfMorphKeys()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.Engine.ClothSimulatorComponent.GetNumberOfMorphKeys | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_cloth_simulator_component.html#a2881bdae1654dc3e9a124e919a8f5e9d)SetVectorArgument()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.ClothSimulatorComponent.SetVectorArgument | ( | float | *x*, |
|  |  | float | *y*, |
|  |  | float | *z*, |
|  |  | float | *w* ) |

[◆](class_tale_worlds_1_1_engine_1_1_cloth_simulator_component.html#a2f1df8a2e769e76f0000163f747eeb60)GetMorphAnimLeftPoints()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.ClothSimulatorComponent.GetMorphAnimLeftPoints | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html)[] | *leftPoints* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_cloth_simulator_component.html#a6ed98aea446cdcaf93ed8ed46a3c37f5)GetMorphAnimRightPoints()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.ClothSimulatorComponent.GetMorphAnimRightPoints | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html)[] | *rightPoints* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_cloth_simulator_component.html#af6c96e0d4abee1916e9f71fb19a86f5c)GetMorphAnimCenterPoints()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.ClothSimulatorComponent.GetMorphAnimCenterPoints | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html)[] | *centerPoints* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_cloth_simulator_component.html#a4929a2f5f54d8136401a003e9f90bc4b)SetForcedVelocity()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.ClothSimulatorComponent.SetForcedVelocity | ( | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *forcedVelocity* | ) |  |

