--- SOURCE: interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_deployment_plan.html ---

TaleWorlds.MountAndBlade.IFormationDeploymentPlan Interface ReferenceInherited by [TaleWorlds.MountAndBlade.DefaultFormationDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| bool | [HasFrame](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_deployment_plan.html#a715a37949a1359b9bba8169bf8061f76) () |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetFrame](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_deployment_plan.html#a18e92cd29625dcce84f6d0671bcbb298) () |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetPosition](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_deployment_plan.html#a3014dae4bb47e78be87e9dc75d6f1e90) () |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetDirection](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_deployment_plan.html#aa650b7cfc855540ad1f76b8187c5726f) () |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | [CreateNewDeploymentWorldPosition](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_deployment_plan.html#affc0527dc96cdc7db3caba7c6c44226d) ([WorldPosition.WorldPositionEnforcedCache](struct_tale_worlds_1_1_engine_1_1_world_position.html#a329057f863819c6dea70ecaf11784df9) worldPositionEnforcedCache) |

|  |  |
| --- | --- |
| Properties | |
| [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | [Class](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_deployment_plan.html#a0ede617c5e615e226bd3aede4c524205) `[get]` |
| [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | [SpawnClass](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_deployment_plan.html#abb6fa35d304871b2e608591fcf61ae1c) `[get]` |
| float | [PlannedWidth](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_deployment_plan.html#adc768e7f3f4fa22a570fd34b2455177a) `[get]` |
| float | [PlannedDepth](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_deployment_plan.html#a640b209df839cd8072bbf123cd0f241c) `[get]` |
| int | [PlannedTroopCount](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_deployment_plan.html#a6af5ec80d902a32d80e3d83ed8680efb) `[get]` |
| bool | [HasDimensions](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_deployment_plan.html#a2e96211cf2dd47ff4c4cd7d49b831cca) `[get]` |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_deployment_plan.html#a715a37949a1359b9bba8169bf8061f76)HasFrame()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.IFormationDeploymentPlan.HasFrame | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.DefaultFormationDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#a33c19877830b94232791be606bdbf367).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_deployment_plan.html#a18e92cd29625dcce84f6d0671bcbb298)GetFrame()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.IFormationDeploymentPlan.GetFrame | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.DefaultFormationDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#a6c77ed282ee3488b1106792c6fc5d456).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_deployment_plan.html#a3014dae4bb47e78be87e9dc75d6f1e90)GetPosition()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.IFormationDeploymentPlan.GetPosition | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.DefaultFormationDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#ac65d8df27f926fe902a35e9df79f914e).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_deployment_plan.html#aa650b7cfc855540ad1f76b8187c5726f)GetDirection()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.IFormationDeploymentPlan.GetDirection | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.DefaultFormationDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#a16ecc7a8e22209c10aa3b5d567998c57).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_deployment_plan.html#affc0527dc96cdc7db3caba7c6c44226d)CreateNewDeploymentWorldPosition()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) TaleWorlds.MountAndBlade.IFormationDeploymentPlan.CreateNewDeploymentWorldPosition | ( | [WorldPosition.WorldPositionEnforcedCache](struct_tale_worlds_1_1_engine_1_1_world_position.html#a329057f863819c6dea70ecaf11784df9) | *worldPositionEnforcedCache* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.DefaultFormationDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#a9fcf9b5f24b4aa1b8333bb19d807c59a).

Property Documentation
----------------------

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_deployment_plan.html#a0ede617c5e615e226bd3aede4c524205)Class
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) TaleWorlds.MountAndBlade.IFormationDeploymentPlan.Class | | get |

Implemented in [TaleWorlds.MountAndBlade.DefaultFormationDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#a7a5e7cf7c07e56f3a42eb96154f9f255).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_deployment_plan.html#abb6fa35d304871b2e608591fcf61ae1c)SpawnClass
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) TaleWorlds.MountAndBlade.IFormationDeploymentPlan.SpawnClass | | get |

Implemented in [TaleWorlds.MountAndBlade.DefaultFormationDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#aa5bc5d919dc4e60e41dac98a34659723).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_deployment_plan.html#adc768e7f3f4fa22a570fd34b2455177a)PlannedWidth
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.IFormationDeploymentPlan.PlannedWidth | | get |

Implemented in [TaleWorlds.MountAndBlade.DefaultFormationDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#a16cf8e92492fd7cb7c71f19e30090224).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_deployment_plan.html#a640b209df839cd8072bbf123cd0f241c)PlannedDepth
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.IFormationDeploymentPlan.PlannedDepth | | get |

Implemented in [TaleWorlds.MountAndBlade.DefaultFormationDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#a7ed410016ddb49ed569066e7b0b4fc21).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_deployment_plan.html#a6af5ec80d902a32d80e3d83ed8680efb)PlannedTroopCount
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.IFormationDeploymentPlan.PlannedTroopCount | | get |

Implemented in [TaleWorlds.MountAndBlade.DefaultFormationDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#a1dcb8dc82fd102f0cd3c1521ca727ab3).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_deployment_plan.html#a2e96211cf2dd47ff4c4cd7d49b831cca)HasDimensions
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.IFormationDeploymentPlan.HasDimensions | | get |

Implemented in [TaleWorlds.MountAndBlade.DefaultFormationDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html#a68f818278aaeb1d3b07dddea6745b19c).

