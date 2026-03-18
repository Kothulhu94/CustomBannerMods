--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_item_object_view_extensions.html ---

TaleWorlds.MountAndBlade.View.ItemObjectViewExtensions Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | [GetCraftedMultiMesh](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_item_object_view_extensions.html#afdb1503cafae698920eac7f24ef139c6) (this [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) itemObject, bool needBatchedVersion) |
| static [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | [GetMultiMeshCopy](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_item_object_view_extensions.html#a4fc4640da51d8d2a629b1b002a0f12c6) (this [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) itemObject) |
| static [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | [GetMultiMeshCopyWithGenderData](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_item_object_view_extensions.html#ab24445ec0ea697a669f30eb7806e53e6) (this [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) itemObject, bool isFemale, bool hasGloves, bool needBatchedVersion) |
| static [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetScaledFrame](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_item_object_view_extensions.html#a8c5371d775eb6442b351e73c43508fff) (this [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) itemObject, [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html) rotationMatrix, [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) metaMesh, float scaleFactor, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) positionShift) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_item_object_view_extensions.html#afdb1503cafae698920eac7f24ef139c6)GetCraftedMultiMesh()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) TaleWorlds.MountAndBlade.View.ItemObjectViewExtensions.GetCraftedMultiMesh | ( | this [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *itemObject*, | |  |  | bool | *needBatchedVersion* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_item_object_view_extensions.html#a4fc4640da51d8d2a629b1b002a0f12c6)GetMultiMeshCopy()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) TaleWorlds.MountAndBlade.View.ItemObjectViewExtensions.GetMultiMeshCopy | ( | this [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *itemObject* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_item_object_view_extensions.html#ab24445ec0ea697a669f30eb7806e53e6)GetMultiMeshCopyWithGenderData()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) TaleWorlds.MountAndBlade.View.ItemObjectViewExtensions.GetMultiMeshCopyWithGenderData | ( | this [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *itemObject*, | |  |  | bool | *isFemale*, | |  |  | bool | *hasGloves*, | |  |  | bool | *needBatchedVersion* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_item_object_view_extensions.html#a8c5371d775eb6442b351e73c43508fff)GetScaledFrame()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.View.ItemObjectViewExtensions.GetScaledFrame | ( | this [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *itemObject*, | |  |  | [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html) | *rotationMatrix*, | |  |  | [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | *metaMesh*, | |  |  | float | *scaleFactor*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *positionShift* ) | | static |

