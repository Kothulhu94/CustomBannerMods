--- SOURCE: class_tale_worlds_1_1_library_1_1_binding_path.html ---

TaleWorlds.Library.BindingPath Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [BindingPath](class_tale_worlds_1_1_library_1_1_binding_path.html#a1da27077d7375a875e9b8e777620766b) (string path) |
|  | [BindingPath](class_tale_worlds_1_1_library_1_1_binding_path.html#a1962e248417bb6aff5c90d27e8b10bc6) (int path) |
|  | [BindingPath](class_tale_worlds_1_1_library_1_1_binding_path.html#a5e35ec23b783f5cae69201b642b31e77) (IEnumerable< string > nodes) |
| override int | [GetHashCode](class_tale_worlds_1_1_library_1_1_binding_path.html#abe884039059abffcc56f3dbb8c9567c7) () |
| override bool | [Equals](class_tale_worlds_1_1_library_1_1_binding_path.html#a85ce862349d2aa0b19b0f3bb1030e999) (object obj) |
| bool | [IsRelatedWith](class_tale_worlds_1_1_library_1_1_binding_path.html#a2926aa2c554dc11f0d63bc82b47ae09c) ([BindingPath](class_tale_worlds_1_1_library_1_1_binding_path.html#a1da27077d7375a875e9b8e777620766b) referencePath) |
| void | [DecrementIfRelatedWith](class_tale_worlds_1_1_library_1_1_binding_path.html#a59ce095615d67d94539f025abf2d39ee) ([BindingPath](class_tale_worlds_1_1_library_1_1_binding_path.html#a1da27077d7375a875e9b8e777620766b) path, int startIndex) |
| [BindingPath](class_tale_worlds_1_1_library_1_1_binding_path.html#a1da27077d7375a875e9b8e777620766b) | [Simplify](class_tale_worlds_1_1_library_1_1_binding_path.html#a9de487b66a26200ab1d1a50ff1850032) () |
| [BindingPath](class_tale_worlds_1_1_library_1_1_binding_path.html#a1da27077d7375a875e9b8e777620766b) | [Append](class_tale_worlds_1_1_library_1_1_binding_path.html#adb84bbe9564d780892153dad8c1b98ac) ([BindingPath](class_tale_worlds_1_1_library_1_1_binding_path.html#a1da27077d7375a875e9b8e777620766b) bindingPath) |
| override string | [ToString](class_tale_worlds_1_1_library_1_1_binding_path.html#aa5debae635c44532ed2dafa37bb6cb32) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [BindingPath](class_tale_worlds_1_1_library_1_1_binding_path.html#a1da27077d7375a875e9b8e777620766b) | [CreateFromProperty](class_tale_worlds_1_1_library_1_1_binding_path.html#a65533f63809b2415bcfa1252374ef856) (string propertyName) |
| static bool | [operator==](class_tale_worlds_1_1_library_1_1_binding_path.html#ae3c998e1b1be9fd3dcdae7be7aea3ab9) ([BindingPath](class_tale_worlds_1_1_library_1_1_binding_path.html#a1da27077d7375a875e9b8e777620766b) a, [BindingPath](class_tale_worlds_1_1_library_1_1_binding_path.html#a1da27077d7375a875e9b8e777620766b) b) |
| static bool | [operator!=](class_tale_worlds_1_1_library_1_1_binding_path.html#a345ad8887f70fd6c162e11e2c0857a40) ([BindingPath](class_tale_worlds_1_1_library_1_1_binding_path.html#a1da27077d7375a875e9b8e777620766b) a, [BindingPath](class_tale_worlds_1_1_library_1_1_binding_path.html#a1da27077d7375a875e9b8e777620766b) b) |
| static bool | [IsRelatedWithPathAsString](class_tale_worlds_1_1_library_1_1_binding_path.html#a2730c35fff5f68f796dad25f946456d3) (string path, string referencePath) |
| static bool | [IsRelatedWithPath](class_tale_worlds_1_1_library_1_1_binding_path.html#a375a1907ea594a3f65aa892a4f9e1835) (string path, [BindingPath](class_tale_worlds_1_1_library_1_1_binding_path.html#a1da27077d7375a875e9b8e777620766b) referencePath) |

|  |  |
| --- | --- |
| Properties | |
| string | [Path](class_tale_worlds_1_1_library_1_1_binding_path.html#ab20cefec552d564e82caaeb4c8a3f53f) `[get]` |
| string[] | [Nodes](class_tale_worlds_1_1_library_1_1_binding_path.html#a558041a47365f39edbc310d4df07a119) `[get]` |
| string | [FirstNode](class_tale_worlds_1_1_library_1_1_binding_path.html#a8ea58a9e97ab06db155add48b9660ec4) `[get]` |
| string | [LastNode](class_tale_worlds_1_1_library_1_1_binding_path.html#abc5cf251453b60fc62a745a2d37b7d69) `[get]` |
| [BindingPath](class_tale_worlds_1_1_library_1_1_binding_path.html#a1da27077d7375a875e9b8e777620766b) | [SubPath](class_tale_worlds_1_1_library_1_1_binding_path.html#a079f6cb6d94b37d46509cfa849285683) `[get]` |
| [BindingPath](class_tale_worlds_1_1_library_1_1_binding_path.html#a1da27077d7375a875e9b8e777620766b) | [ParentPath](class_tale_worlds_1_1_library_1_1_binding_path.html#a41b0c4c0a6bb30757e85ee1a68272b3d) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_library_1_1_binding_path.html#a1da27077d7375a875e9b8e777620766b)BindingPath() [1/3]
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Library.BindingPath.BindingPath | ( | string | *path* | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_binding_path.html#a1962e248417bb6aff5c90d27e8b10bc6)BindingPath() [2/3]
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Library.BindingPath.BindingPath | ( | int | *path* | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_binding_path.html#a5e35ec23b783f5cae69201b642b31e77)BindingPath() [3/3]
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Library.BindingPath.BindingPath | ( | IEnumerable< string > | *nodes* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_library_1_1_binding_path.html#a65533f63809b2415bcfa1252374ef856)CreateFromProperty()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [BindingPath](class_tale_worlds_1_1_library_1_1_binding_path.html#a1da27077d7375a875e9b8e777620766b) TaleWorlds.Library.BindingPath.CreateFromProperty | ( | string | *propertyName* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_binding_path.html#abe884039059abffcc56f3dbb8c9567c7)GetHashCode()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.Library.BindingPath.GetHashCode | ( |  | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_binding_path.html#a85ce862349d2aa0b19b0f3bb1030e999)Equals()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.Library.BindingPath.Equals | ( | object | *obj* | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_binding_path.html#ae3c998e1b1be9fd3dcdae7be7aea3ab9)operator==()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Library.BindingPath.operator== | ( | [BindingPath](class_tale_worlds_1_1_library_1_1_binding_path.html#a1da27077d7375a875e9b8e777620766b) | *a*, | |  |  | [BindingPath](class_tale_worlds_1_1_library_1_1_binding_path.html#a1da27077d7375a875e9b8e777620766b) | *b* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_binding_path.html#a345ad8887f70fd6c162e11e2c0857a40)operator!=()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Library.BindingPath.operator!= | ( | [BindingPath](class_tale_worlds_1_1_library_1_1_binding_path.html#a1da27077d7375a875e9b8e777620766b) | *a*, | |  |  | [BindingPath](class_tale_worlds_1_1_library_1_1_binding_path.html#a1da27077d7375a875e9b8e777620766b) | *b* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_binding_path.html#a2730c35fff5f68f796dad25f946456d3)IsRelatedWithPathAsString()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Library.BindingPath.IsRelatedWithPathAsString | ( | string | *path*, | |  |  | string | *referencePath* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_binding_path.html#a375a1907ea594a3f65aa892a4f9e1835)IsRelatedWithPath()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Library.BindingPath.IsRelatedWithPath | ( | string | *path*, | |  |  | [BindingPath](class_tale_worlds_1_1_library_1_1_binding_path.html#a1da27077d7375a875e9b8e777620766b) | *referencePath* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_binding_path.html#a2926aa2c554dc11f0d63bc82b47ae09c)IsRelatedWith()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Library.BindingPath.IsRelatedWith | ( | [BindingPath](class_tale_worlds_1_1_library_1_1_binding_path.html#a1da27077d7375a875e9b8e777620766b) | *referencePath* | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_binding_path.html#a59ce095615d67d94539f025abf2d39ee)DecrementIfRelatedWith()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.BindingPath.DecrementIfRelatedWith | ( | [BindingPath](class_tale_worlds_1_1_library_1_1_binding_path.html#a1da27077d7375a875e9b8e777620766b) | *path*, |
|  |  | int | *startIndex* ) |

[◆](class_tale_worlds_1_1_library_1_1_binding_path.html#a9de487b66a26200ab1d1a50ff1850032)Simplify()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [BindingPath](class_tale_worlds_1_1_library_1_1_binding_path.html#a1da27077d7375a875e9b8e777620766b) TaleWorlds.Library.BindingPath.Simplify | ( |  | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_binding_path.html#adb84bbe9564d780892153dad8c1b98ac)Append()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [BindingPath](class_tale_worlds_1_1_library_1_1_binding_path.html#a1da27077d7375a875e9b8e777620766b) TaleWorlds.Library.BindingPath.Append | ( | [BindingPath](class_tale_worlds_1_1_library_1_1_binding_path.html#a1da27077d7375a875e9b8e777620766b) | *bindingPath* | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_binding_path.html#aa5debae635c44532ed2dafa37bb6cb32)ToString()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.Library.BindingPath.ToString | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_library_1_1_binding_path.html#ab20cefec552d564e82caaeb4c8a3f53f)Path
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Library.BindingPath.Path | | get |

[◆](class_tale_worlds_1_1_library_1_1_binding_path.html#a558041a47365f39edbc310d4df07a119)Nodes
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string [] TaleWorlds.Library.BindingPath.Nodes | | get |

[◆](class_tale_worlds_1_1_library_1_1_binding_path.html#a8ea58a9e97ab06db155add48b9660ec4)FirstNode
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Library.BindingPath.FirstNode | | get |

[◆](class_tale_worlds_1_1_library_1_1_binding_path.html#abc5cf251453b60fc62a745a2d37b7d69)LastNode
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Library.BindingPath.LastNode | | get |

[◆](class_tale_worlds_1_1_library_1_1_binding_path.html#a079f6cb6d94b37d46509cfa849285683)SubPath
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BindingPath](class_tale_worlds_1_1_library_1_1_binding_path.html#a1da27077d7375a875e9b8e777620766b) TaleWorlds.Library.BindingPath.SubPath | | get |

[◆](class_tale_worlds_1_1_library_1_1_binding_path.html#a41b0c4c0a6bb30757e85ee1a68272b3d)ParentPath
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BindingPath](class_tale_worlds_1_1_library_1_1_binding_path.html#a1da27077d7375a875e9b8e777620766b) TaleWorlds.Library.BindingPath.ParentPath | | get |

