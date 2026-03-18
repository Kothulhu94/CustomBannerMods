--- SOURCE: class_tale_worlds_1_1_library_1_1_extensions.html ---

TaleWorlds.Library.Extensions Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static List< Type > | [GetTypesSafe](class_tale_worlds_1_1_library_1_1_extensions.html#a9ad27502cbb5a238e71740fa88c3a984) (this Assembly assembly, Func< Type, bool > func=null) |
| static Assembly[] | [GetReferencingAssembliesSafe](class_tale_worlds_1_1_library_1_1_extensions.html#a5a8fa1e3c20b4d256885054cb99adcdc) (this Assembly baseAssembly, Func< Assembly, bool > func=null) |
| static object[] | [GetCustomAttributesSafe](class_tale_worlds_1_1_library_1_1_extensions.html#a6974cff8dbaeaba8c107c8cd8065fe5a) (this Type type, Type attributeType, bool inherit) |
| static object[] | [GetCustomAttributesSafe](class_tale_worlds_1_1_library_1_1_extensions.html#aaddfaca113652469dc3d2fcd56098d35) (this Type type, bool inherit) |
| static IEnumerable< Attribute > | [GetCustomAttributesSafe](class_tale_worlds_1_1_library_1_1_extensions.html#aa66c639aeb07876dbec82a724e7b55e6) (this Type type, Type attributeType) |
| static object[] | [GetCustomAttributesSafe](class_tale_worlds_1_1_library_1_1_extensions.html#a6e548441e02c317e48b8d5b03b83ea00) (this PropertyInfo property, Type attributeType, bool inherit) |
| static object[] | [GetCustomAttributesSafe](class_tale_worlds_1_1_library_1_1_extensions.html#af2471985d6b2caf01682b23cb38a44b7) (this PropertyInfo property, bool inherit) |
| static IEnumerable< Attribute > | [GetCustomAttributesSafe](class_tale_worlds_1_1_library_1_1_extensions.html#af0e77c37b33038b04d8a1288a4977e0e) (this PropertyInfo property, Type attributeType) |
| static object[] | [GetCustomAttributesSafe](class_tale_worlds_1_1_library_1_1_extensions.html#a3b7c79b6ab8b0e6e46afc5e67606d0d9) (this FieldInfo field, Type attributeType, bool inherit) |
| static object[] | [GetCustomAttributesSafe](class_tale_worlds_1_1_library_1_1_extensions.html#acaa508b9962b4e9760dbed7f800ff591) (this FieldInfo field, bool inherit) |
| static IEnumerable< Attribute > | [GetCustomAttributesSafe](class_tale_worlds_1_1_library_1_1_extensions.html#a296367bbc04bdb8787e702fa85b185f5) (this FieldInfo field, Type attributeType) |
| static object[] | [GetCustomAttributesSafe](class_tale_worlds_1_1_library_1_1_extensions.html#a9692f35b43582b642f216c9049216ad1) (this MethodInfo method, Type attributeType, bool inherit) |
| static object[] | [GetCustomAttributesSafe](class_tale_worlds_1_1_library_1_1_extensions.html#a5d4bd1c76a2cf37b68299260e8aea49d) (this MethodInfo method, bool inherit) |
| static IEnumerable< Attribute > | [GetCustomAttributesSafe](class_tale_worlds_1_1_library_1_1_extensions.html#aec541b9247aee529f47e2d75857dd9ea) (this MethodInfo method, Type attributeType) |
| static object[] | [GetCustomAttributesSafe](class_tale_worlds_1_1_library_1_1_extensions.html#ac3e7e95eadd782cca9480c265adfdc7d) (this Assembly assembly, Type attributeType, bool inherit) |
| static object[] | [GetCustomAttributesSafe](class_tale_worlds_1_1_library_1_1_extensions.html#a9d63da90ae91617fa706d392658b3c53) (this Assembly assembly, bool inherit) |
| static IEnumerable< Attribute > | [GetCustomAttributesSafe](class_tale_worlds_1_1_library_1_1_extensions.html#aa9a21302e33ec0050fb594bfe484dd0e) (this Assembly assembly, Type attributeType) |
| static MBList< T > | [ToMBList< T >](class_tale_worlds_1_1_library_1_1_extensions.html#a2bac13c5e489c2aca251e5d9f9af30ac) (this T[] source) |
| static MBList< T > | [ToMBList< T >](class_tale_worlds_1_1_library_1_1_extensions.html#a1c11bb4cd8e5760f97b18a94d5f4aa68) (this List< T > source) |
| static MBList< T > | [ToMBList< T >](class_tale_worlds_1_1_library_1_1_extensions.html#a1f43dd763a41a9ca0976fa365ef95ef5) (this IEnumerable< T > source) |
| static void | [AppendList< T >](class_tale_worlds_1_1_library_1_1_extensions.html#aaaad67c9c2fe5c7ae8b66c5e6b78db36) (this List< T > list1, List< T > list2) |
| static MBReadOnlyDictionary< TKey, TValue > | [GetReadOnlyDictionary< TKey, TValue >](class_tale_worlds_1_1_library_1_1_extensions.html#a1b385eb32bd15358412fc25447b15f91) (this Dictionary< TKey, TValue > dictionary) |
| static bool | [HasAnyFlag< T >](class_tale_worlds_1_1_library_1_1_extensions.html#aca16e0dcf5a62cdca8d4e5e9e3a4c046) (this T p1, T p2) |
|  | Returns true only if any of the bits in param:flags is set in param:e. 1001.HasAnyFlag(1000) returns true. 1001.HasAnyFlag(1111) returns true. |
| static bool | [HasAllFlags< T >](class_tale_worlds_1_1_library_1_1_extensions.html#a1f46192a73b02a67ae80d9388a73c107) (this T p1, T p2) |
|  | Behaves exactly like HasFlag. But faster (in release) because there is less check. |
| static int | [GetDeterministicHashCode](class_tale_worlds_1_1_library_1_1_extensions.html#a871aa0835083684c52a8a555dc171012) (this string text) |
| static int | [IndexOfMin< TSource >](class_tale_worlds_1_1_library_1_1_extensions.html#a16a8e7af79aa27c6f1d08b37fc11f388) (this IReadOnlyList< TSource > self, Func< TSource, int > func) |
| static int | [IndexOfMin< TSource >](class_tale_worlds_1_1_library_1_1_extensions.html#ad63775e95b16f3e3d8e285c3fbab946a) (this MBReadOnlyList< TSource > self, Func< TSource, int > func) |
| static int | [IndexOfMax< TSource >](class_tale_worlds_1_1_library_1_1_extensions.html#a3c44f4ac403b41a75766e708874ff379) (this IReadOnlyList< TSource > self, Func< TSource, int > func) |
| static int | [IndexOfMax< TSource >](class_tale_worlds_1_1_library_1_1_extensions.html#a47786acb52f9ae88916e47a5436e9a59) (this MBReadOnlyList< TSource > self, Func< TSource, int > func) |
| static int | [IndexOf< TValue >](class_tale_worlds_1_1_library_1_1_extensions.html#ab024e0be0c7f5a910096b1df98cd5a62) (this TValue[] source, TValue item) |
| static int | [FindIndex< TValue >](class_tale_worlds_1_1_library_1_1_extensions.html#ac4d1d6205067ea7656241486213fc015) (this IReadOnlyList< TValue > source, Func< TValue, bool > predicate) |
| static int | [FindIndex< TValue >](class_tale_worlds_1_1_library_1_1_extensions.html#ab18ab7b89f8a57d4b047b5ed2dec487b) (this MBReadOnlyList< TValue > source, Func< TValue, bool > predicate) |
| static int | [FindLastIndex< TValue >](class_tale_worlds_1_1_library_1_1_extensions.html#ab881764d687aa7f65a828619cd538aa6) (this IReadOnlyList< TValue > source, Func< TValue, bool > predicate) |
| static int | [FindLastIndex< TValue >](class_tale_worlds_1_1_library_1_1_extensions.html#adcb0dad7a056f6122001b2383c152b5e) (this MBReadOnlyList< TValue > source, Func< TValue, bool > predicate) |
| static void | [Randomize< T >](class_tale_worlds_1_1_library_1_1_extensions.html#a935fd57cd55db2647803f54a2941ee68) (this IList< T > array) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_library_1_1_extensions.html#a9ad27502cbb5a238e71740fa88c3a984)GetTypesSafe()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | List< Type > TaleWorlds.Library.Extensions.GetTypesSafe | ( | this Assembly | *assembly*, | |  |  | Func< Type, bool > | *func* = null ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | assembly |  |
    | func |  |

Returns
:   Returns the loaded types. May include null values in result.

[◆](class_tale_worlds_1_1_library_1_1_extensions.html#a5a8fa1e3c20b4d256885054cb99adcdc)GetReferencingAssembliesSafe()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | Assembly[] TaleWorlds.Library.Extensions.GetReferencingAssembliesSafe | ( | this Assembly | *baseAssembly*, | |  |  | Func< Assembly, bool > | *func* = null ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_extensions.html#a6974cff8dbaeaba8c107c8cd8065fe5a)GetCustomAttributesSafe() [1/15]
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | object[] TaleWorlds.Library.Extensions.GetCustomAttributesSafe | ( | this Type | *type*, | |  |  | Type | *attributeType*, | |  |  | bool | *inherit* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_extensions.html#aaddfaca113652469dc3d2fcd56098d35)GetCustomAttributesSafe() [2/15]
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | object[] TaleWorlds.Library.Extensions.GetCustomAttributesSafe | ( | this Type | *type*, | |  |  | bool | *inherit* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_extensions.html#aa66c639aeb07876dbec82a724e7b55e6)GetCustomAttributesSafe() [3/15]
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IEnumerable< Attribute > TaleWorlds.Library.Extensions.GetCustomAttributesSafe | ( | this Type | *type*, | |  |  | Type | *attributeType* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_extensions.html#a6e548441e02c317e48b8d5b03b83ea00)GetCustomAttributesSafe() [4/15]
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | object[] TaleWorlds.Library.Extensions.GetCustomAttributesSafe | ( | this PropertyInfo | *property*, | |  |  | Type | *attributeType*, | |  |  | bool | *inherit* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_extensions.html#af2471985d6b2caf01682b23cb38a44b7)GetCustomAttributesSafe() [5/15]
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | object[] TaleWorlds.Library.Extensions.GetCustomAttributesSafe | ( | this PropertyInfo | *property*, | |  |  | bool | *inherit* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_extensions.html#af0e77c37b33038b04d8a1288a4977e0e)GetCustomAttributesSafe() [6/15]
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IEnumerable< Attribute > TaleWorlds.Library.Extensions.GetCustomAttributesSafe | ( | this PropertyInfo | *property*, | |  |  | Type | *attributeType* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_extensions.html#a3b7c79b6ab8b0e6e46afc5e67606d0d9)GetCustomAttributesSafe() [7/15]
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | object[] TaleWorlds.Library.Extensions.GetCustomAttributesSafe | ( | this FieldInfo | *field*, | |  |  | Type | *attributeType*, | |  |  | bool | *inherit* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_extensions.html#acaa508b9962b4e9760dbed7f800ff591)GetCustomAttributesSafe() [8/15]
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | object[] TaleWorlds.Library.Extensions.GetCustomAttributesSafe | ( | this FieldInfo | *field*, | |  |  | bool | *inherit* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_extensions.html#a296367bbc04bdb8787e702fa85b185f5)GetCustomAttributesSafe() [9/15]
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IEnumerable< Attribute > TaleWorlds.Library.Extensions.GetCustomAttributesSafe | ( | this FieldInfo | *field*, | |  |  | Type | *attributeType* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_extensions.html#a9692f35b43582b642f216c9049216ad1)GetCustomAttributesSafe() [10/15]
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | object[] TaleWorlds.Library.Extensions.GetCustomAttributesSafe | ( | this MethodInfo | *method*, | |  |  | Type | *attributeType*, | |  |  | bool | *inherit* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_extensions.html#a5d4bd1c76a2cf37b68299260e8aea49d)GetCustomAttributesSafe() [11/15]
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | object[] TaleWorlds.Library.Extensions.GetCustomAttributesSafe | ( | this MethodInfo | *method*, | |  |  | bool | *inherit* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_extensions.html#aec541b9247aee529f47e2d75857dd9ea)GetCustomAttributesSafe() [12/15]
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IEnumerable< Attribute > TaleWorlds.Library.Extensions.GetCustomAttributesSafe | ( | this MethodInfo | *method*, | |  |  | Type | *attributeType* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_extensions.html#ac3e7e95eadd782cca9480c265adfdc7d)GetCustomAttributesSafe() [13/15]
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | object[] TaleWorlds.Library.Extensions.GetCustomAttributesSafe | ( | this Assembly | *assembly*, | |  |  | Type | *attributeType*, | |  |  | bool | *inherit* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_extensions.html#a9d63da90ae91617fa706d392658b3c53)GetCustomAttributesSafe() [14/15]
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | object[] TaleWorlds.Library.Extensions.GetCustomAttributesSafe | ( | this Assembly | *assembly*, | |  |  | bool | *inherit* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_extensions.html#aa9a21302e33ec0050fb594bfe484dd0e)GetCustomAttributesSafe() [15/15]
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IEnumerable< Attribute > TaleWorlds.Library.Extensions.GetCustomAttributesSafe | ( | this Assembly | *assembly*, | |  |  | Type | *attributeType* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_extensions.html#a2bac13c5e489c2aca251e5d9f9af30ac)ToMBList< T >() [1/3]
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | MBList< T > TaleWorlds.Library.Extensions.ToMBList< T > | ( | this T[] | *source* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_extensions.html#a1c11bb4cd8e5760f97b18a94d5f4aa68)ToMBList< T >() [2/3]
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | MBList< T > TaleWorlds.Library.Extensions.ToMBList< T > | ( | this List< T > | *source* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_extensions.html#a1f43dd763a41a9ca0976fa365ef95ef5)ToMBList< T >() [3/3]
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | MBList< T > TaleWorlds.Library.Extensions.ToMBList< T > | ( | this IEnumerable< T > | *source* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_extensions.html#aaaad67c9c2fe5c7ae8b66c5e6b78db36)AppendList< T >()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Library.Extensions.AppendList< T > | ( | this List< T > | *list1*, | |  |  | List< T > | *list2* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_extensions.html#a1b385eb32bd15358412fc25447b15f91)GetReadOnlyDictionary< TKey, TValue >()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | MBReadOnlyDictionary< TKey, TValue > TaleWorlds.Library.Extensions.GetReadOnlyDictionary< TKey, TValue > | ( | this Dictionary< TKey, TValue > | *dictionary* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_extensions.html#aca16e0dcf5a62cdca8d4e5e9e3a4c046)HasAnyFlag< T >()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Library.Extensions.HasAnyFlag< T > | ( | this T | *p1*, | |  |  | T | *p2* ) | | static |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *struct* |  |

[◆](class_tale_worlds_1_1_library_1_1_extensions.html#a1f46192a73b02a67ae80d9388a73c107)HasAllFlags< T >()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Library.Extensions.HasAllFlags< T > | ( | this T | *p1*, | |  |  | T | *p2* ) | | static |

Returns true only if all the bits in param:flags is set in param:e. 1001.HasAllFlags(1000) returns false. 1001.HasAllFlags(1111) returns true.

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *struct* |  |

[◆](class_tale_worlds_1_1_library_1_1_extensions.html#a871aa0835083684c52a8a555dc171012)GetDeterministicHashCode()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.Library.Extensions.GetDeterministicHashCode | ( | this string | *text* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_extensions.html#a16a8e7af79aa27c6f1d08b37fc11f388)IndexOfMin< TSource >() [1/2]
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.Library.Extensions.IndexOfMin< TSource > | ( | this IReadOnlyList< TSource > | *self*, | |  |  | Func< TSource, int > | *func* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_extensions.html#ad63775e95b16f3e3d8e285c3fbab946a)IndexOfMin< TSource >() [2/2]
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.Library.Extensions.IndexOfMin< TSource > | ( | this MBReadOnlyList< TSource > | *self*, | |  |  | Func< TSource, int > | *func* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_extensions.html#a3c44f4ac403b41a75766e708874ff379)IndexOfMax< TSource >() [1/2]
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.Library.Extensions.IndexOfMax< TSource > | ( | this IReadOnlyList< TSource > | *self*, | |  |  | Func< TSource, int > | *func* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_extensions.html#a47786acb52f9ae88916e47a5436e9a59)IndexOfMax< TSource >() [2/2]
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.Library.Extensions.IndexOfMax< TSource > | ( | this MBReadOnlyList< TSource > | *self*, | |  |  | Func< TSource, int > | *func* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_extensions.html#ab024e0be0c7f5a910096b1df98cd5a62)IndexOf< TValue >()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.Library.Extensions.IndexOf< TValue > | ( | this TValue[] | *source*, | |  |  | TValue | *item* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_extensions.html#ac4d1d6205067ea7656241486213fc015)FindIndex< TValue >() [1/2]
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.Library.Extensions.FindIndex< TValue > | ( | this IReadOnlyList< TValue > | *source*, | |  |  | Func< TValue, bool > | *predicate* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_extensions.html#ab18ab7b89f8a57d4b047b5ed2dec487b)FindIndex< TValue >() [2/2]
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.Library.Extensions.FindIndex< TValue > | ( | this MBReadOnlyList< TValue > | *source*, | |  |  | Func< TValue, bool > | *predicate* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_extensions.html#ab881764d687aa7f65a828619cd538aa6)FindLastIndex< TValue >() [1/2]
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.Library.Extensions.FindLastIndex< TValue > | ( | this IReadOnlyList< TValue > | *source*, | |  |  | Func< TValue, bool > | *predicate* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_extensions.html#adcb0dad7a056f6122001b2383c152b5e)FindLastIndex< TValue >() [2/2]
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.Library.Extensions.FindLastIndex< TValue > | ( | this MBReadOnlyList< TValue > | *source*, | |  |  | Func< TValue, bool > | *predicate* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_extensions.html#a935fd57cd55db2647803f54a2941ee68)Randomize< T >()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Library.Extensions.Randomize< T > | ( | this IList< T > | *array* | ) |  | | static |

