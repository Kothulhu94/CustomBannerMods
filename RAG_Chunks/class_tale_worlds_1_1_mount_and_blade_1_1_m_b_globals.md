--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_m_b_globals.html ---

TaleWorlds.MountAndBlade.MBGlobals Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [InitializeReferences](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_globals.html#a20d05273f3876478aafa4896b32ddf9b) () |
| static [MBActionSet](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html) | [GetActionSetWithSuffix](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_globals.html#a307b724ec31866ea9c7fbc41884c9a6c) ([Monster](class_tale_worlds_1_1_core_1_1_monster.html) monster, bool isFemale, string suffix) |
| static [MBActionSet](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html) | [GetActionSet](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_globals.html#ad24bf10719a8f6dafcd1880b11419e8a) (string actionSetCode) |
| static string | [GetMemberName< T >](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_globals.html#ac14f5a3da8e96129ab976258899358e5) (System.Linq.Expressions.Expression< Func< T > > memberExpression) |
| static string | [GetMethodName< T >](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_globals.html#ad93d6ae2b69b3bd0427dfb84e19814d6) (System.Linq.Expressions.Expression< Func< T > > memberExpression) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const float | [Gravity](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_globals.html#a31e7e86532198f85ce190c5d3292a23b) = 9.806f |
| static readonly [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GravitationalAcceleration](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_globals.html#a5ebaae03f4f8e86825aaf85d9315c7d2) = new [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html)(0, 0, -[Gravity](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_globals.html#a31e7e86532198f85ce190c5d3292a23b)) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_globals.html#a20d05273f3876478aafa4896b32ddf9b)InitializeReferences()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBGlobals.InitializeReferences | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_globals.html#a307b724ec31866ea9c7fbc41884c9a6c)GetActionSetWithSuffix()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MBActionSet](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html) TaleWorlds.MountAndBlade.MBGlobals.GetActionSetWithSuffix | ( | [Monster](class_tale_worlds_1_1_core_1_1_monster.html) | *monster*, | |  |  | bool | *isFemale*, | |  |  | string | *suffix* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_globals.html#ad24bf10719a8f6dafcd1880b11419e8a)GetActionSet()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [MBActionSet](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html) TaleWorlds.MountAndBlade.MBGlobals.GetActionSet | ( | string | *actionSetCode* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_globals.html#ac14f5a3da8e96129ab976258899358e5)GetMemberName< T >()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.MBGlobals.GetMemberName< T > | ( | System.Linq.Expressions.Expression< Func< T > > | *memberExpression* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_globals.html#ad93d6ae2b69b3bd0427dfb84e19814d6)GetMethodName< T >()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.MBGlobals.GetMethodName< T > | ( | System.Linq.Expressions.Expression< Func< T > > | *memberExpression* | ) |  | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_globals.html#a31e7e86532198f85ce190c5d3292a23b)Gravity
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.MBGlobals.Gravity = 9.806f | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_globals.html#a5ebaae03f4f8e86825aaf85d9315c7d2)GravitationalAcceleration
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.MBGlobals.GravitationalAcceleration = new [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html)(0, 0, -[Gravity](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_globals.html#a31e7e86532198f85ce190c5d3292a23b)) | | static |

