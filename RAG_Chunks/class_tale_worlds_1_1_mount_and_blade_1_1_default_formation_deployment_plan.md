--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html ---

TaleWorlds.MountAndBlade.DefaultFormationDeploymentPlan Class ReferenceInherits [TaleWorlds.MountAndBlade.IFormationDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_deployment_plan.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [DefaultFormationDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#a72dc139e670b7263e671c0207e0a5357) ([FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) fClass) |
| bool | [HasFrame](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#a33c19877830b94232791be606bdbf367) () |
| [FormationDeploymentFlank](namespace_tale_worlds_1_1_mount_and_blade.html#a165ebcf3c04e8cf19d0374efbaa065ca) | [GetDefaultFlank](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#a9f96a02a60c799ce98d0ae21f979bf16) (int formationTroopCount, int infantryCount, bool spawnWithHorses=false) |
| [FormationDeploymentOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_formation_deployment_order.html) | [GetFlankDeploymentOrder](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#ab1f1148e3bec678cfb4f3491e69639e7) (int offset=0) |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetFrame](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#a6c77ed282ee3488b1106792c6fc5d456) () |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetPosition](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#ac65d8df27f926fe902a35e9df79f914e) () |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetDirection](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#a16ecc7a8e22209c10aa3b5d567998c57) () |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | [CreateNewDeploymentWorldPosition](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#a9fcf9b5f24b4aa1b8333bb19d807c59a) ([WorldPosition.WorldPositionEnforcedCache](struct_tale_worlds_1_1_engine_1_1_world_position.html#a329057f863819c6dea70ecaf11784df9) worldPositionEnforcedCache) |
| void | [Clear](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#ab984bc16479286f05cd599a7f4d126b5) () |
| void | [SetPlannedTroopCount](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#a73549bf7b6340f522a89c25ab35c06a6) (int footTroopCount, int mountedTroopCount) |
| void | [SetPlannedDimensions](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#ab2b1012b131082af38272b8752c42c41) (float width, float depth) |
| void | [SetFrame](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#a7fc3e8abe841edf58ac1a6a9bdf7835e) (in [WorldFrame](struct_tale_worlds_1_1_engine_1_1_world_frame.html) frame) |
| void | [SetSpawnClass](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#a6f2ff13dd953089cf98383bfe4d6aed8) ([FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) spawnClass) |

|  |  |
| --- | --- |
| Properties | |
| [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | [Class](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#a7a5e7cf7c07e56f3a42eb96154f9f255) `[get]` |
| [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | [SpawnClass](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#aa5bc5d919dc4e60e41dac98a34659723) `[get]` |
| float | [PlannedWidth](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#a16cf8e92492fd7cb7c71f19e30090224) `[get]` |
| float | [PlannedDepth](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#a7ed410016ddb49ed569066e7b0b4fc21) `[get]` |
| int | [PlannedTroopCount](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#a1dcb8dc82fd102f0cd3c1521ca727ab3) `[get]` |
| int | [PlannedFootTroopCount](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#a2187bd82adc6a21472d6e2682d2e3ab1) `[get]` |
| int | [PlannedMountedTroopCount](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#abbf703e89d6689fddfcdfb3a2ddfa03b) `[get]` |
| bool | [HasDimensions](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#a68f818278aaeb1d3b07dddea6745b19c) `[get]` |
| bool | [HasSignificantMountedTroops](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#ae3f9d38f2a843178d2291e118f2de7d8) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#a72dc139e670b7263e671c0207e0a5357)DefaultFormationDeploymentPlan()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.DefaultFormationDeploymentPlan.DefaultFormationDeploymentPlan | ( | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | *fClass* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#a33c19877830b94232791be606bdbf367)HasFrame()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.DefaultFormationDeploymentPlan.HasFrame | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IFormationDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_deployment_plan.html#a715a37949a1359b9bba8169bf8061f76).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#a9f96a02a60c799ce98d0ae21f979bf16)GetDefaultFlank()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [FormationDeploymentFlank](namespace_tale_worlds_1_1_mount_and_blade.html#a165ebcf3c04e8cf19d0374efbaa065ca) TaleWorlds.MountAndBlade.DefaultFormationDeploymentPlan.GetDefaultFlank | ( | int | *formationTroopCount*, |
|  |  | int | *infantryCount*, |
|  |  | bool | *spawnWithHorses* = false ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#ab1f1148e3bec678cfb4f3491e69639e7)GetFlankDeploymentOrder()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [FormationDeploymentOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_formation_deployment_order.html) TaleWorlds.MountAndBlade.DefaultFormationDeploymentPlan.GetFlankDeploymentOrder | ( | int | *offset* = 0 | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#a6c77ed282ee3488b1106792c6fc5d456)GetFrame()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.DefaultFormationDeploymentPlan.GetFrame | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IFormationDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_deployment_plan.html#a18e92cd29625dcce84f6d0671bcbb298).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#ac65d8df27f926fe902a35e9df79f914e)GetPosition()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.DefaultFormationDeploymentPlan.GetPosition | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IFormationDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_deployment_plan.html#a3014dae4bb47e78be87e9dc75d6f1e90).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#a16ecc7a8e22209c10aa3b5d567998c57)GetDirection()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.DefaultFormationDeploymentPlan.GetDirection | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IFormationDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_deployment_plan.html#aa650b7cfc855540ad1f76b8187c5726f).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#a9fcf9b5f24b4aa1b8333bb19d807c59a)CreateNewDeploymentWorldPosition()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) TaleWorlds.MountAndBlade.DefaultFormationDeploymentPlan.CreateNewDeploymentWorldPosition | ( | [WorldPosition.WorldPositionEnforcedCache](struct_tale_worlds_1_1_engine_1_1_world_position.html#a329057f863819c6dea70ecaf11784df9) | *worldPositionEnforcedCache* | ) |  |

Implements [TaleWorlds.MountAndBlade.IFormationDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_deployment_plan.html#affc0527dc96cdc7db3caba7c6c44226d).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#ab984bc16479286f05cd599a7f4d126b5)Clear()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DefaultFormationDeploymentPlan.Clear | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#a73549bf7b6340f522a89c25ab35c06a6)SetPlannedTroopCount()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DefaultFormationDeploymentPlan.SetPlannedTroopCount | ( | int | *footTroopCount*, |
|  |  | int | *mountedTroopCount* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#ab2b1012b131082af38272b8752c42c41)SetPlannedDimensions()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DefaultFormationDeploymentPlan.SetPlannedDimensions | ( | float | *width*, |
|  |  | float | *depth* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#a7fc3e8abe841edf58ac1a6a9bdf7835e)SetFrame()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DefaultFormationDeploymentPlan.SetFrame | ( | in [WorldFrame](struct_tale_worlds_1_1_engine_1_1_world_frame.html) | *frame* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#a6f2ff13dd953089cf98383bfe4d6aed8)SetSpawnClass()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DefaultFormationDeploymentPlan.SetSpawnClass | ( | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | *spawnClass* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#a7a5e7cf7c07e56f3a42eb96154f9f255)Class
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) TaleWorlds.MountAndBlade.DefaultFormationDeploymentPlan.Class | | get |

Implements [TaleWorlds.MountAndBlade.IFormationDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_deployment_plan.html#a0ede617c5e615e226bd3aede4c524205).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#aa5bc5d919dc4e60e41dac98a34659723)SpawnClass
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) TaleWorlds.MountAndBlade.DefaultFormationDeploymentPlan.SpawnClass | | get |

Implements [TaleWorlds.MountAndBlade.IFormationDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_deployment_plan.html#abb6fa35d304871b2e608591fcf61ae1c).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#a16cf8e92492fd7cb7c71f19e30090224)PlannedWidth
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.DefaultFormationDeploymentPlan.PlannedWidth | | get |

Implements [TaleWorlds.MountAndBlade.IFormationDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_deployment_plan.html#adc768e7f3f4fa22a570fd34b2455177a).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#a7ed410016ddb49ed569066e7b0b4fc21)PlannedDepth
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.DefaultFormationDeploymentPlan.PlannedDepth | | get |

Implements [TaleWorlds.MountAndBlade.IFormationDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_deployment_plan.html#a640b209df839cd8072bbf123cd0f241c).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#a1dcb8dc82fd102f0cd3c1521ca727ab3)PlannedTroopCount
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.DefaultFormationDeploymentPlan.PlannedTroopCount | | get |

Implements [TaleWorlds.MountAndBlade.IFormationDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_deployment_plan.html#a6af5ec80d902a32d80e3d83ed8680efb).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#a2187bd82adc6a21472d6e2682d2e3ab1)PlannedFootTroopCount
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.DefaultFormationDeploymentPlan.PlannedFootTroopCount | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#abbf703e89d6689fddfcdfb3a2ddfa03b)PlannedMountedTroopCount
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.DefaultFormationDeploymentPlan.PlannedMountedTroopCount | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#a68f818278aaeb1d3b07dddea6745b19c)HasDimensions
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.DefaultFormationDeploymentPlan.HasDimensions | | get |

Implements [TaleWorlds.MountAndBlade.IFormationDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_deployment_plan.html#a2e96211cf2dd47ff4c4cd7d49b831cca).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#ae3f9d38f2a843178d2291e118f2de7d8)HasSignificantMountedTroops
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.DefaultFormationDeploymentPlan.HasSignificantMountedTroops | | get |

