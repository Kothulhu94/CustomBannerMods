--- SOURCE: class_tale_worlds_1_1_library_1_1_path_finder.html ---

TaleWorlds.Library.PathFinder Class Referenceabstract|  |  |
| --- | --- |
| Public Member Functions | |
|  | [PathFinder](class_tale_worlds_1_1_library_1_1_path_finder.html#abbd253f51ae4fd2acf8607d7fbb9893d) () |
| virtual void | [Destroy](class_tale_worlds_1_1_library_1_1_path_finder.html#a70de367b7ee6e0fbce6bcc76eb7e347a) () |
| void | [Initialize](class_tale_worlds_1_1_library_1_1_path_finder.html#afb3823defb01caa2e566b5e43cb1c907) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) bbSize) |
| bool | [FindPath](class_tale_worlds_1_1_library_1_1_path_finder.html#a7294ec3a16cfe72f1b5a4e2bdcbe4e92) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) wSource, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) wDestination, List< [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) > path, float craftWidth=5.0f) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static float | [BuildingCost](class_tale_worlds_1_1_library_1_1_path_finder.html#acf8a07c992afcb509ce0f2a8805d5d02) = 5000.0f |
| static float | [WaterCost](class_tale_worlds_1_1_library_1_1_path_finder.html#a07c1f87d9b4606a96994a2e158a12f3e) = 400.0f |
| static float | [ShallowWaterCost](class_tale_worlds_1_1_library_1_1_path_finder.html#a8cf20766163313982e2709ddd1535e54) = 100.0f |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_library_1_1_path_finder.html#abbd253f51ae4fd2acf8607d7fbb9893d)PathFinder()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Library.PathFinder.PathFinder | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_library_1_1_path_finder.html#a70de367b7ee6e0fbce6bcc76eb7e347a)Destroy()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.Library.PathFinder.Destroy | ( |  | ) |  | | virtual |

[◆](class_tale_worlds_1_1_library_1_1_path_finder.html#afb3823defb01caa2e566b5e43cb1c907)Initialize()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Library.PathFinder.Initialize | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *bbSize* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_library_1_1_path_finder.html#a7294ec3a16cfe72f1b5a4e2bdcbe4e92)FindPath()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Library.PathFinder.FindPath | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *wSource*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *wDestination*, | |  |  | List< [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) > | *path*, | |  |  | float | *craftWidth* = 5.0f ) | | abstract |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_library_1_1_path_finder.html#acf8a07c992afcb509ce0f2a8805d5d02)BuildingCost
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Library.PathFinder.BuildingCost = 5000.0f | | static |

[◆](class_tale_worlds_1_1_library_1_1_path_finder.html#a07c1f87d9b4606a96994a2e158a12f3e)WaterCost
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Library.PathFinder.WaterCost = 400.0f | | static |

[◆](class_tale_worlds_1_1_library_1_1_path_finder.html#a8cf20766163313982e2709ddd1535e54)ShallowWaterCost
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Library.PathFinder.ShallowWaterCost = 100.0f | | static |

