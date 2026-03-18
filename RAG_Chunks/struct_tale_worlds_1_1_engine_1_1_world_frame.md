--- SOURCE: struct_tale_worlds_1_1_engine_1_1_world_frame.html ---

TaleWorlds.Engine.WorldFrame Struct Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [WorldFrame](struct_tale_worlds_1_1_engine_1_1_world_frame.html#a5ffd120b1560687d21e2c6d38d02f631) ([Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html) rotation, [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) origin) |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [ToGroundMatrixFrame](struct_tale_worlds_1_1_engine_1_1_world_frame.html#ab76781e4edc339cc0358632ef1e60bc3) () |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [ToGroundMatrixFrameMT](struct_tale_worlds_1_1_engine_1_1_world_frame.html#a38e301205cb57e25d00a1112db88585f) () |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [ToNavMeshMatrixFrame](struct_tale_worlds_1_1_engine_1_1_world_frame.html#a7ef10ed160f505b1fc514abb0a7c21e6) () |

|  |  |
| --- | --- |
| Public Attributes | |
| [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html) | [Rotation](struct_tale_worlds_1_1_engine_1_1_world_frame.html#a480dd33cc89a6ad66ae0f4e9902abe67) |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | [Origin](struct_tale_worlds_1_1_engine_1_1_world_frame.html#a0184b524db59c633f893522e3dcc0353) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static readonly [WorldFrame](struct_tale_worlds_1_1_engine_1_1_world_frame.html#a5ffd120b1560687d21e2c6d38d02f631) | [Invalid](struct_tale_worlds_1_1_engine_1_1_world_frame.html#a2be2da2b3b7c05b5c1c96dff6a92b49d) = new [WorldFrame](struct_tale_worlds_1_1_engine_1_1_world_frame.html#a5ffd120b1560687d21e2c6d38d02f631)([Mat3.Identity](struct_tale_worlds_1_1_library_1_1_mat3.html#ae7f29f86be4d8d25cbd335d90ffdf725), [WorldPosition.Invalid](struct_tale_worlds_1_1_engine_1_1_world_position.html#a4b77e3d5dafdd36de2873f0626237525)) |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsValid](struct_tale_worlds_1_1_engine_1_1_world_frame.html#a10055ffaaf4bdac0a62089c021405627) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](struct_tale_worlds_1_1_engine_1_1_world_frame.html#a5ffd120b1560687d21e2c6d38d02f631)WorldFrame()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Engine.WorldFrame.WorldFrame | ( | [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html) | *rotation*, |
|  |  | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *origin* ) |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_engine_1_1_world_frame.html#ab76781e4edc339cc0358632ef1e60bc3)ToGroundMatrixFrame()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.Engine.WorldFrame.ToGroundMatrixFrame | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_world_frame.html#a38e301205cb57e25d00a1112db88585f)ToGroundMatrixFrameMT()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.Engine.WorldFrame.ToGroundMatrixFrameMT | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_world_frame.html#a7ef10ed160f505b1fc514abb0a7c21e6)ToNavMeshMatrixFrame()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.Engine.WorldFrame.ToNavMeshMatrixFrame | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](struct_tale_worlds_1_1_engine_1_1_world_frame.html#a480dd33cc89a6ad66ae0f4e9902abe67)Rotation
-------------------------------------------------------------------------------------------------

|  |
| --- |
| [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html) TaleWorlds.Engine.WorldFrame.Rotation |

[◆](struct_tale_worlds_1_1_engine_1_1_world_frame.html#a0184b524db59c633f893522e3dcc0353)Origin
-----------------------------------------------------------------------------------------------

|  |
| --- |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) TaleWorlds.Engine.WorldFrame.Origin |

[◆](struct_tale_worlds_1_1_engine_1_1_world_frame.html#a2be2da2b3b7c05b5c1c96dff6a92b49d)Invalid
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [WorldFrame](struct_tale_worlds_1_1_engine_1_1_world_frame.html#a5ffd120b1560687d21e2c6d38d02f631) TaleWorlds.Engine.WorldFrame.Invalid = new [WorldFrame](struct_tale_worlds_1_1_engine_1_1_world_frame.html#a5ffd120b1560687d21e2c6d38d02f631)([Mat3.Identity](struct_tale_worlds_1_1_library_1_1_mat3.html#ae7f29f86be4d8d25cbd335d90ffdf725), [WorldPosition.Invalid](struct_tale_worlds_1_1_engine_1_1_world_position.html#a4b77e3d5dafdd36de2873f0626237525)) | | static |

Property Documentation
----------------------

[◆](struct_tale_worlds_1_1_engine_1_1_world_frame.html#a10055ffaaf4bdac0a62089c021405627)IsValid
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Engine.WorldFrame.IsValid | | get |

