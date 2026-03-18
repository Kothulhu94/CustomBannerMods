--- SOURCE: class_tale_worlds_1_1_library_1_1_navigation_path.html ---

TaleWorlds.Library.NavigationPath Class ReferenceInherits ISerializable.

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [NavigationPath](class_tale_worlds_1_1_library_1_1_navigation_path.html#ad4577ad990bfce5927cb513b3b03615f) () |
| virtual void | [GetObjectData](class_tale_worlds_1_1_library_1_1_navigation_path.html#a73d8cd51b40573aea1ab2ef9d4b188fa) (SerializationInfo info, StreamingContext context) |
| void | [OverridePathPointAtIndex](class_tale_worlds_1_1_library_1_1_navigation_path.html#ae4607469dfbe8d0d49c189f2031caeb0) (int index, in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) newValue) |

|  |  |
| --- | --- |
| Protected Member Functions | |
|  | [NavigationPath](class_tale_worlds_1_1_library_1_1_navigation_path.html#a820b4144f38b1201e0091b88830fa129) (SerializationInfo info, StreamingContext context) |

|  |  |
| --- | --- |
| Properties | |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)[] | [PathPoints](class_tale_worlds_1_1_library_1_1_navigation_path.html#a156427bb744e63581be665f8f1a7a9a9) `[get]` |
| int | [Size](class_tale_worlds_1_1_library_1_1_navigation_path.html#ad3d68b4748a0a2791b1ef0cfcc61aaaf) `[get, set]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [this[int i]](class_tale_worlds_1_1_library_1_1_navigation_path.html#a9b432b49d75157c8fd014734c6dced33) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_library_1_1_navigation_path.html#ad4577ad990bfce5927cb513b3b03615f)NavigationPath() [1/2]
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Library.NavigationPath.NavigationPath | ( |  | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_navigation_path.html#a820b4144f38b1201e0091b88830fa129)NavigationPath() [2/2]
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | TaleWorlds.Library.NavigationPath.NavigationPath | ( | SerializationInfo | *info*, | |  |  | StreamingContext | *context* ) | | protected |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_library_1_1_navigation_path.html#a73d8cd51b40573aea1ab2ef9d4b188fa)GetObjectData()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.Library.NavigationPath.GetObjectData | ( | SerializationInfo | *info*, | |  |  | StreamingContext | *context* ) | | virtual |

[◆](class_tale_worlds_1_1_library_1_1_navigation_path.html#ae4607469dfbe8d0d49c189f2031caeb0)OverridePathPointAtIndex()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.NavigationPath.OverridePathPointAtIndex | ( | int | *index*, |
|  |  | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *newValue* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_library_1_1_navigation_path.html#a156427bb744e63581be665f8f1a7a9a9)PathPoints
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) [] TaleWorlds.Library.NavigationPath.PathPoints | | get |

[◆](class_tale_worlds_1_1_library_1_1_navigation_path.html#ad3d68b4748a0a2791b1ef0cfcc61aaaf)Size
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Library.NavigationPath.Size | | getset |

[◆](class_tale_worlds_1_1_library_1_1_navigation_path.html#a9b432b49d75157c8fd014734c6dced33)this[int i]
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.Library.NavigationPath.this[int i] | | get |

