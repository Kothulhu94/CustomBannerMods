--- SOURCE: struct_tale_worlds_1_1_engine_1_1_bounding_box.html ---

TaleWorlds.Engine.BoundingBox Struct Reference|  |  |
| --- | --- |
| Classes | |
| struct | [TransformedBoundingBoxPointsContainer](struct_tale_worlds_1_1_engine_1_1_bounding_box_1_1_transformed_bounding_box_points_container.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [BoundingBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#adbfda60231123e45541df7d10910e39c) (in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) point) |
| void | [RelaxMinMaxWithPoint](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#a4e91e3f0248d14247684aa7145b0bd05) (in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) point) |
| void | [RelaxMinMaxWithPointAndRadius](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#a1a353e1a7d11e1c8616bdde808dd18d0) (in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) point, float [radius](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#a483695ed9327fbc94c97456952e69f3d)) |
| void | [RecomputeRadius](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#a7758722a62216ac7df72bd868c39fb3f) () |
| [TransformedBoundingBoxPointsContainer](struct_tale_worlds_1_1_engine_1_1_bounding_box_1_1_transformed_bounding_box_points_container.html) | [GetTransformedTipPointsToParent](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#a5fe58a419d42eb0cf1364c5bdc31da44) (in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) parentFrame) |
| [TransformedBoundingBoxPointsContainer](struct_tale_worlds_1_1_engine_1_1_bounding_box_1_1_transformed_bounding_box_points_container.html) | [GetTransformedTipPointsToChild](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#a33c91102fa1bbee0b40a4e2ddf870bd6) (in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) childFrame) |
| void | [RelaxWithBoundingBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#aef19ed49ac5d65ba9edd9c0a8d332f5a) ([BoundingBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#adbfda60231123e45541df7d10910e39c) modifiedBoundingBox) |
| void | [RelaxWithArbitraryBoundingBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#a7078c938ed0a5b761629596ac2abb2bd) ([BoundingBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#adbfda60231123e45541df7d10910e39c) otherBoundingBox, [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) otherGlobalFrame, [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) globalFrameOfThisBoundingBox) |
| void | [RelaxWithChildBoundingBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#ad782bee9976db93c837a8cbaa548747c) ([BoundingBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#adbfda60231123e45541df7d10910e39c) childBoundingBox, [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) childFrame) |
| void | [BeginRelaxation](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#a03c51323d76f62a91424c8c525f527d3) () |
| bool | [PointInsideBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#a2627b54aa2460bd27c351f5ba23f06e8) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) point, float epsilon) |
| void | [RenderBoundingBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#abc20553142897ebb6f8440359063bb55) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static bool | [ArrangeWithAnotherBoundingBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#a844141d566bd18ed6b0e24951629dbf3) (ref [BoundingBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#adbfda60231123e45541df7d10910e39c) boundingBox, [BoundingBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#adbfda60231123e45541df7d10910e39c) otherBoundingBox, float changeAmount) |
| static float | [GetLongestHalfDimensionOfBoundingBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#a4506832e47b9737ae2f032435d9d62a7) ([BoundingBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#adbfda60231123e45541df7d10910e39c) boundingBox) |

|  |  |
| --- | --- |
| Public Attributes | |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [min](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#adf22464aa12b4bd183e275035d7e7f50) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [max](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#a23f3a3f2c668dd671ac822a650672461) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [center](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#a3c59ff63ea0b52d3dac529b5da0c11cc) |
| float | [radius](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#a483695ed9327fbc94c97456952e69f3d) |

|  |  |
| --- | --- |
| Properties | |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [this[int index]](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#a1054d6839a8f54d94a6a3891b182316e) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#adbfda60231123e45541df7d10910e39c)BoundingBox()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Engine.BoundingBox.BoundingBox | ( | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *point* | ) |  |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#a4e91e3f0248d14247684aa7145b0bd05)RelaxMinMaxWithPoint()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.BoundingBox.RelaxMinMaxWithPoint | ( | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *point* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#a1a353e1a7d11e1c8616bdde808dd18d0)RelaxMinMaxWithPointAndRadius()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.BoundingBox.RelaxMinMaxWithPointAndRadius | ( | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *point*, |
|  |  | float | *radius* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#a7758722a62216ac7df72bd868c39fb3f)RecomputeRadius()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.BoundingBox.RecomputeRadius | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#a5fe58a419d42eb0cf1364c5bdc31da44)GetTransformedTipPointsToParent()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [TransformedBoundingBoxPointsContainer](struct_tale_worlds_1_1_engine_1_1_bounding_box_1_1_transformed_bounding_box_points_container.html) TaleWorlds.Engine.BoundingBox.GetTransformedTipPointsToParent | ( | in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *parentFrame* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#a33c91102fa1bbee0b40a4e2ddf870bd6)GetTransformedTipPointsToChild()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [TransformedBoundingBoxPointsContainer](struct_tale_worlds_1_1_engine_1_1_bounding_box_1_1_transformed_bounding_box_points_container.html) TaleWorlds.Engine.BoundingBox.GetTransformedTipPointsToChild | ( | in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *childFrame* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#aef19ed49ac5d65ba9edd9c0a8d332f5a)RelaxWithBoundingBox()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.BoundingBox.RelaxWithBoundingBox | ( | [BoundingBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#adbfda60231123e45541df7d10910e39c) | *modifiedBoundingBox* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#a7078c938ed0a5b761629596ac2abb2bd)RelaxWithArbitraryBoundingBox()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.BoundingBox.RelaxWithArbitraryBoundingBox | ( | [BoundingBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#adbfda60231123e45541df7d10910e39c) | *otherBoundingBox*, |
|  |  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *otherGlobalFrame*, |
|  |  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *globalFrameOfThisBoundingBox* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#ad782bee9976db93c837a8cbaa548747c)RelaxWithChildBoundingBox()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.BoundingBox.RelaxWithChildBoundingBox | ( | [BoundingBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#adbfda60231123e45541df7d10910e39c) | *childBoundingBox*, |
|  |  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *childFrame* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#a03c51323d76f62a91424c8c525f527d3)BeginRelaxation()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.BoundingBox.BeginRelaxation | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#a844141d566bd18ed6b0e24951629dbf3)ArrangeWithAnotherBoundingBox()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Engine.BoundingBox.ArrangeWithAnotherBoundingBox | ( | ref [BoundingBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#adbfda60231123e45541df7d10910e39c) | *boundingBox*, | |  |  | [BoundingBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#adbfda60231123e45541df7d10910e39c) | *otherBoundingBox*, | |  |  | float | *changeAmount* ) | | static |

[◆](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#a2627b54aa2460bd27c351f5ba23f06e8)PointInsideBox()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Engine.BoundingBox.PointInsideBox | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *point*, |
|  |  | float | *epsilon* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#a4506832e47b9737ae2f032435d9d62a7)GetLongestHalfDimensionOfBoundingBox()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.Engine.BoundingBox.GetLongestHalfDimensionOfBoundingBox | ( | [BoundingBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#adbfda60231123e45541df7d10910e39c) | *boundingBox* | ) |  | | static |

[◆](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#abc20553142897ebb6f8440359063bb55)RenderBoundingBox()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.BoundingBox.RenderBoundingBox | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#adf22464aa12b4bd183e275035d7e7f50)min
---------------------------------------------------------------------------------------------

|  |
| --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.BoundingBox.min |

[◆](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#a23f3a3f2c668dd671ac822a650672461)max
---------------------------------------------------------------------------------------------

|  |
| --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.BoundingBox.max |

[◆](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#a3c59ff63ea0b52d3dac529b5da0c11cc)center
------------------------------------------------------------------------------------------------

|  |
| --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.BoundingBox.center |

[◆](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#a483695ed9327fbc94c97456952e69f3d)radius
------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.Engine.BoundingBox.radius |

Property Documentation
----------------------

[◆](struct_tale_worlds_1_1_engine_1_1_bounding_box.html#a1054d6839a8f54d94a6a3891b182316e)this[int index]
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.BoundingBox.this[int index] | | get |

