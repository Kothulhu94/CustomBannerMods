--- SOURCE: struct_tale_worlds_1_1_library_1_1_application_version.html ---

TaleWorlds.Library.ApplicationVersion Struct Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html#a5eebc5963124779232ec77e0164276f2) ([ApplicationVersionType](namespace_tale_worlds_1_1_library.html#a93f01b7bac5aad7b5fae70964c25efc3) applicationVersionType, int major, int minor, int revision, int changeSet) |
| bool | [IsSame](struct_tale_worlds_1_1_library_1_1_application_version.html#a326ce9d3bfe81b993563f58f4534c0f9) ([ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html#a5eebc5963124779232ec77e0164276f2) other, bool checkChangeSet) |
| bool | [IsOlderThan](struct_tale_worlds_1_1_library_1_1_application_version.html#afbffaf8d316361e641ffd333f3e54f71) ([ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html#a5eebc5963124779232ec77e0164276f2) other) |
| bool | [IsNewerThan](struct_tale_worlds_1_1_library_1_1_application_version.html#a8cd2108cedf3dbbaaaf27d51296c6fe6) ([ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html#a5eebc5963124779232ec77e0164276f2) other) |
| override string | [ToString](struct_tale_worlds_1_1_library_1_1_application_version.html#a60f58a8c07076d7c323badf2376fea8c) () |
|  | Returns formatted save version. |
| override int | [GetHashCode](struct_tale_worlds_1_1_library_1_1_application_version.html#afa7959c9b206c7c5596f644c0ea8e274) () |
| override bool | [Equals](struct_tale_worlds_1_1_library_1_1_application_version.html#a3d6ee275bffe0d4cb93df70c002d8b90) (object obj) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html#a5eebc5963124779232ec77e0164276f2) | [FromParametersFile](struct_tale_worlds_1_1_library_1_1_application_version.html#a20d20d577ddb19b5041d27d6ba55185a) (string customParameterFilePath=null) |
| static [ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html#a5eebc5963124779232ec77e0164276f2) | [FromString](struct_tale_worlds_1_1_library_1_1_application_version.html#a9391296fe6d88328a5b5eb91c2b1d073) (string versionAsString, int defaultChangeSet=0) |
| static [ApplicationVersionType](namespace_tale_worlds_1_1_library.html#a93f01b7bac5aad7b5fae70964c25efc3) | [ApplicationVersionTypeFromString](struct_tale_worlds_1_1_library_1_1_application_version.html#a95ecbdb339f68669455e4b41efdbc028) (string applicationVersionTypeAsString) |
| static string | [GetPrefix](struct_tale_worlds_1_1_library_1_1_application_version.html#a0c2d60a9188fb5739eed38947de78f21) ([ApplicationVersionType](namespace_tale_worlds_1_1_library.html#a93f01b7bac5aad7b5fae70964c25efc3) applicationVersionType) |
| static bool | [operator==](struct_tale_worlds_1_1_library_1_1_application_version.html#a3cd2cce7d4939af93d38cd7fd441ee8a) ([ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html#a5eebc5963124779232ec77e0164276f2) a, [ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html#a5eebc5963124779232ec77e0164276f2) b) |
| static bool | [operator!=](struct_tale_worlds_1_1_library_1_1_application_version.html#a5160afce1854748d59dc6def877e3b2d) ([ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html#a5eebc5963124779232ec77e0164276f2) a, [ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html#a5eebc5963124779232ec77e0164276f2) b) |
| static bool | [operator>](struct_tale_worlds_1_1_library_1_1_application_version.html#ad9bf36818490189a32d2a85c01d8397f) ([ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html#a5eebc5963124779232ec77e0164276f2) a, [ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html#a5eebc5963124779232ec77e0164276f2) b) |
| static bool | [operator<](struct_tale_worlds_1_1_library_1_1_application_version.html#a4fe4249d108cd0a6f24fec33d5e5948b) ([ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html#a5eebc5963124779232ec77e0164276f2) a, [ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html#a5eebc5963124779232ec77e0164276f2) b) |
| static bool | [operator>=](struct_tale_worlds_1_1_library_1_1_application_version.html#ac19868521da8f43a13b44f4b9d489ea5) ([ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html#a5eebc5963124779232ec77e0164276f2) a, [ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html#a5eebc5963124779232ec77e0164276f2) b) |
| static bool | [operator<=](struct_tale_worlds_1_1_library_1_1_application_version.html#a864751cb0c9aa2dde15555ff8b828273) ([ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html#a5eebc5963124779232ec77e0164276f2) a, [ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html#a5eebc5963124779232ec77e0164276f2) b) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const int | [DefaultChangeSet](struct_tale_worlds_1_1_library_1_1_application_version.html#ac64188490a367c77be0147acb6d10747) = 107738 |
|  | This is overridden during publishing. |
| static readonly [ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html#a5eebc5963124779232ec77e0164276f2) | [Empty](struct_tale_worlds_1_1_library_1_1_application_version.html#a985bb770e60ab0fba34d9925cd6e96ad) = new [ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html#a5eebc5963124779232ec77e0164276f2)([ApplicationVersionType.Invalid](namespace_tale_worlds_1_1_library.html#a93f01b7bac5aad7b5fae70964c25efc3a4bbb8f967da6d1a610596d7257179c2b), -1, -1, -1, -1) |

|  |  |
| --- | --- |
| Properties | |
| [ApplicationVersionType](namespace_tale_worlds_1_1_library.html#a93f01b7bac5aad7b5fae70964c25efc3) | [ApplicationVersionType](struct_tale_worlds_1_1_library_1_1_application_version.html#abf62b4a7b0065dae32993f41ca9721d3) `[get]` |
| int | [Major](struct_tale_worlds_1_1_library_1_1_application_version.html#a7f89f1c63b22e6a105d5b95d55d12055) `[get]` |
| int | [Minor](struct_tale_worlds_1_1_library_1_1_application_version.html#a1223de3adf2a753469ff366270b6393a) `[get]` |
| int | [Revision](struct_tale_worlds_1_1_library_1_1_application_version.html#abbab03189c9c10bc5779e76a7514c3ef) `[get]` |
| int | [ChangeSet](struct_tale_worlds_1_1_library_1_1_application_version.html#a2cb31af849091c0c71fda548460e9aac) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](struct_tale_worlds_1_1_library_1_1_application_version.html#a5eebc5963124779232ec77e0164276f2)ApplicationVersion()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Library.ApplicationVersion.ApplicationVersion | ( | [ApplicationVersionType](namespace_tale_worlds_1_1_library.html#a93f01b7bac5aad7b5fae70964c25efc3) | *applicationVersionType*, |
|  |  | int | *major*, |
|  |  | int | *minor*, |
|  |  | int | *revision*, |
|  |  | int | *changeSet* ) |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_library_1_1_application_version.html#a20d20d577ddb19b5041d27d6ba55185a)FromParametersFile()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html#a5eebc5963124779232ec77e0164276f2) TaleWorlds.Library.ApplicationVersion.FromParametersFile | ( | string | *customParameterFilePath* = null | ) |  | | static |

[◆](struct_tale_worlds_1_1_library_1_1_application_version.html#a9391296fe6d88328a5b5eb91c2b1d073)FromString()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html#a5eebc5963124779232ec77e0164276f2) TaleWorlds.Library.ApplicationVersion.FromString | ( | string | *versionAsString*, | |  |  | int | *defaultChangeSet* = 0 ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_application_version.html#a326ce9d3bfe81b993563f58f4534c0f9)IsSame()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Library.ApplicationVersion.IsSame | ( | [ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html#a5eebc5963124779232ec77e0164276f2) | *other*, |
|  |  | bool | *checkChangeSet* ) |

[◆](struct_tale_worlds_1_1_library_1_1_application_version.html#afbffaf8d316361e641ffd333f3e54f71)IsOlderThan()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Library.ApplicationVersion.IsOlderThan | ( | [ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html#a5eebc5963124779232ec77e0164276f2) | *other* | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_application_version.html#a8cd2108cedf3dbbaaaf27d51296c6fe6)IsNewerThan()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Library.ApplicationVersion.IsNewerThan | ( | [ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html#a5eebc5963124779232ec77e0164276f2) | *other* | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_application_version.html#a95ecbdb339f68669455e4b41efdbc028)ApplicationVersionTypeFromString()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [ApplicationVersionType](namespace_tale_worlds_1_1_library.html#a93f01b7bac5aad7b5fae70964c25efc3) TaleWorlds.Library.ApplicationVersion.ApplicationVersionTypeFromString | ( | string | *applicationVersionTypeAsString* | ) |  | | static |

[◆](struct_tale_worlds_1_1_library_1_1_application_version.html#a0c2d60a9188fb5739eed38947de78f21)GetPrefix()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.Library.ApplicationVersion.GetPrefix | ( | [ApplicationVersionType](namespace_tale_worlds_1_1_library.html#a93f01b7bac5aad7b5fae70964c25efc3) | *applicationVersionType* | ) |  | | static |

[◆](struct_tale_worlds_1_1_library_1_1_application_version.html#a60f58a8c07076d7c323badf2376fea8c)ToString()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.Library.ApplicationVersion.ToString | ( |  | ) |  |

Returns

[◆](struct_tale_worlds_1_1_library_1_1_application_version.html#a3cd2cce7d4939af93d38cd7fd441ee8a)operator==()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Library.ApplicationVersion.operator== | ( | [ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html#a5eebc5963124779232ec77e0164276f2) | *a*, | |  |  | [ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html#a5eebc5963124779232ec77e0164276f2) | *b* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_application_version.html#a5160afce1854748d59dc6def877e3b2d)operator!=()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Library.ApplicationVersion.operator!= | ( | [ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html#a5eebc5963124779232ec77e0164276f2) | *a*, | |  |  | [ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html#a5eebc5963124779232ec77e0164276f2) | *b* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_application_version.html#afa7959c9b206c7c5596f644c0ea8e274)GetHashCode()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.Library.ApplicationVersion.GetHashCode | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_application_version.html#a3d6ee275bffe0d4cb93df70c002d8b90)Equals()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.Library.ApplicationVersion.Equals | ( | object | *obj* | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_application_version.html#ad9bf36818490189a32d2a85c01d8397f)operator>()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Library.ApplicationVersion.operator> | ( | [ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html#a5eebc5963124779232ec77e0164276f2) | *a*, | |  |  | [ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html#a5eebc5963124779232ec77e0164276f2) | *b* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_application_version.html#a4fe4249d108cd0a6f24fec33d5e5948b)operator<()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Library.ApplicationVersion.operator< | ( | [ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html#a5eebc5963124779232ec77e0164276f2) | *a*, | |  |  | [ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html#a5eebc5963124779232ec77e0164276f2) | *b* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_application_version.html#ac19868521da8f43a13b44f4b9d489ea5)operator>=()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Library.ApplicationVersion.operator>= | ( | [ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html#a5eebc5963124779232ec77e0164276f2) | *a*, | |  |  | [ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html#a5eebc5963124779232ec77e0164276f2) | *b* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_application_version.html#a864751cb0c9aa2dde15555ff8b828273)operator<=()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Library.ApplicationVersion.operator<= | ( | [ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html#a5eebc5963124779232ec77e0164276f2) | *a*, | |  |  | [ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html#a5eebc5963124779232ec77e0164276f2) | *b* ) | | static |

Member Data Documentation
-------------------------

[◆](struct_tale_worlds_1_1_library_1_1_application_version.html#ac64188490a367c77be0147acb6d10747)DefaultChangeSet
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.Library.ApplicationVersion.DefaultChangeSet = 107738 | | static |

[◆](struct_tale_worlds_1_1_library_1_1_application_version.html#a985bb770e60ab0fba34d9925cd6e96ad)Empty
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html#a5eebc5963124779232ec77e0164276f2) TaleWorlds.Library.ApplicationVersion.Empty = new [ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html#a5eebc5963124779232ec77e0164276f2)([ApplicationVersionType.Invalid](namespace_tale_worlds_1_1_library.html#a93f01b7bac5aad7b5fae70964c25efc3a4bbb8f967da6d1a610596d7257179c2b), -1, -1, -1, -1) | | static |

Property Documentation
----------------------

[◆](struct_tale_worlds_1_1_library_1_1_application_version.html#abf62b4a7b0065dae32993f41ca9721d3)ApplicationVersionType
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ApplicationVersionType](namespace_tale_worlds_1_1_library.html#a93f01b7bac5aad7b5fae70964c25efc3) TaleWorlds.Library.ApplicationVersion.ApplicationVersionType | | get |

[◆](struct_tale_worlds_1_1_library_1_1_application_version.html#a7f89f1c63b22e6a105d5b95d55d12055)Major
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Library.ApplicationVersion.Major | | get |

[◆](struct_tale_worlds_1_1_library_1_1_application_version.html#a1223de3adf2a753469ff366270b6393a)Minor
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Library.ApplicationVersion.Minor | | get |

[◆](struct_tale_worlds_1_1_library_1_1_application_version.html#abbab03189c9c10bc5779e76a7514c3ef)Revision
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Library.ApplicationVersion.Revision | | get |

[◆](struct_tale_worlds_1_1_library_1_1_application_version.html#a2cb31af849091c0c71fda548460e9aac)ChangeSet
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Library.ApplicationVersion.ChangeSet | | get |

