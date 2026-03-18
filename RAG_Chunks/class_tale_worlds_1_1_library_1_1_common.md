--- SOURCE: class_tale_worlds_1_1_library_1_1_common.html ---

TaleWorlds.Library.Common Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static byte[] | [CombineBytes](class_tale_worlds_1_1_library_1_1_common.html#a27b929e8faa5a413292ad8075413dd8d) (byte[] arr1, byte[] arr2, byte[] arr3=null, byte[] arr4=null, byte[] arr5=null) |
| static string | [CreateNanoIdFrom](class_tale_worlds_1_1_library_1_1_common.html#afa7326c8fdcd4dc7246999bd6905d9d4) (string input) |
| static string | [CalculateMD5Hash](class_tale_worlds_1_1_library_1_1_common.html#a7433afb2f1e514132c9afe7312de4e6b) (string input) |
| static string | [ToRoman](class_tale_worlds_1_1_library_1_1_common.html#aea101ddf941feabead334eaface8d5ab) (int number) |
| static int | [GetDJB2](class_tale_worlds_1_1_library_1_1_common.html#a7a0316839e4653af70e7c6c26aa7d261) (string str) |
| static byte[] | [SerializeObjectAsJson](class_tale_worlds_1_1_library_1_1_common.html#a1622bfbd44d835602bf349f0eba2bcc7) (object o) |
| static string | [SerializeObjectAsJsonString](class_tale_worlds_1_1_library_1_1_common.html#aad1b4ca7f977c8abb42b641d32cd9252) (object o) |
| static T | [DeserializeObjectFromJson< T >](class_tale_worlds_1_1_library_1_1_common.html#ad4a01aa141ee8184e6469964f3b53cf4) (string json) |
| static byte[] | [FromUrlSafeBase64](class_tale_worlds_1_1_library_1_1_common.html#a1bfba4abe3b2468a51eea971aa0ac07c) (string base64) |
| static Type | [FindType](class_tale_worlds_1_1_library_1_1_common.html#afe8bc711965311e2c628e022c30d2f75) (string typeName) |
| static void | [MemoryCleanupGC](class_tale_worlds_1_1_library_1_1_common.html#a0a41edd364f262c0a5938ba6d3607d4c) (bool forceTimer=false) |
| static object | [DynamicInvokeWithLog](class_tale_worlds_1_1_library_1_1_common.html#ad1744441ef63654b7f8e2011055aa296) (this Delegate method, params object[] args) |
| static object | [InvokeWithLog](class_tale_worlds_1_1_library_1_1_common.html#a93d1502d3cd462e81e253a53c482edf1) (this MethodInfo methodInfo, object obj, params object[] args) |
| static object | [InvokeWithLog](class_tale_worlds_1_1_library_1_1_common.html#a30a29955aaab2c36d6433400906a0728) (this ConstructorInfo constructorInfo, params object[] args) |
| static bool | [TextContainsSpecialCharacters](class_tale_worlds_1_1_library_1_1_common.html#ad8e21d8b8c5d2225d915622bb8f0016a) (string text) |
| static uint | [ParseIpAddress](class_tale_worlds_1_1_library_1_1_common.html#a7d1287885468eae732750a5c7826a58e) (string address) |
| static bool | [IsAllLetters](class_tale_worlds_1_1_library_1_1_common.html#a81abd9e5753b18c292603992e2fa4b03) (string text) |
| static bool | [IsAllLettersOrWhiteSpaces](class_tale_worlds_1_1_library_1_1_common.html#a93f5bc768befb2cc280851171ef645f9) (string text) |
| static bool | [IsCharAsian](class_tale_worlds_1_1_library_1_1_common.html#aed5e9bbe37434f9d60af90b208ac0a41) (char character) |
| static void | [SetInvariantCulture](class_tale_worlds_1_1_library_1_1_common.html#acc47c4a348f94f8b79fd2b677dc54dba) () |
| static MethodInfo | [GetMethodInfo](class_tale_worlds_1_1_library_1_1_common.html#a9d730235eba5abc086a4da57b605fd99) (Expression< Action > expression) |
| static MethodInfo | [GetMethodInfo< T >](class_tale_worlds_1_1_library_1_1_common.html#ab1a78d657a9c8ace520e76067c0b9831) (Expression< Action< T > > expression) |
| static MethodInfo | [GetMethodInfo< T, TResult >](class_tale_worlds_1_1_library_1_1_common.html#ae76157fdd75d4c77bf81241a68ab551d) (Expression< Func< T, TResult > > expression) |
| static MethodInfo | [GetMethodInfo](class_tale_worlds_1_1_library_1_1_common.html#a948cde7596e0669df5c987e97f062004) (LambdaExpression expression) |

|  |  |
| --- | --- |
| Properties | |
| static [IPlatformFileHelper](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html) | [PlatformFileHelper](class_tale_worlds_1_1_library_1_1_common.html#ae029686e710160e06a9d8941e958f41d) `[get, set]` |
| static string | [ConfigName](class_tale_worlds_1_1_library_1_1_common.html#aeccec0155b1b05a2c91b7828171dc53c) `[get]` |
| static ParallelOptions | [ParallelOptions](class_tale_worlds_1_1_library_1_1_common.html#a6bbe06885c77ab3c0e45b038e766236d) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_library_1_1_common.html#a27b929e8faa5a413292ad8075413dd8d)CombineBytes()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | byte[] TaleWorlds.Library.Common.CombineBytes | ( | byte[] | *arr1*, | |  |  | byte[] | *arr2*, | |  |  | byte[] | *arr3* = null, | |  |  | byte[] | *arr4* = null, | |  |  | byte[] | *arr5* = null ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_common.html#afa7326c8fdcd4dc7246999bd6905d9d4)CreateNanoIdFrom()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.Library.Common.CreateNanoIdFrom | ( | string | *input* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_common.html#a7433afb2f1e514132c9afe7312de4e6b)CalculateMD5Hash()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.Library.Common.CalculateMD5Hash | ( | string | *input* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_common.html#aea101ddf941feabead334eaface8d5ab)ToRoman()
---------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.Library.Common.ToRoman | ( | int | *number* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_common.html#a7a0316839e4653af70e7c6c26aa7d261)GetDJB2()
---------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.Library.Common.GetDJB2 | ( | string | *str* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_common.html#a1622bfbd44d835602bf349f0eba2bcc7)SerializeObjectAsJson()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | byte[] TaleWorlds.Library.Common.SerializeObjectAsJson | ( | object | *o* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_common.html#aad1b4ca7f977c8abb42b641d32cd9252)SerializeObjectAsJsonString()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.Library.Common.SerializeObjectAsJsonString | ( | object | *o* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_common.html#ad4a01aa141ee8184e6469964f3b53cf4)DeserializeObjectFromJson< T >()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | T TaleWorlds.Library.Common.DeserializeObjectFromJson< T > | ( | string | *json* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_common.html#a1bfba4abe3b2468a51eea971aa0ac07c)FromUrlSafeBase64()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | byte[] TaleWorlds.Library.Common.FromUrlSafeBase64 | ( | string | *base64* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_common.html#afe8bc711965311e2c628e022c30d2f75)FindType()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | Type TaleWorlds.Library.Common.FindType | ( | string | *typeName* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_common.html#a0a41edd364f262c0a5938ba6d3607d4c)MemoryCleanupGC()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Library.Common.MemoryCleanupGC | ( | bool | *forceTimer* = false | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_common.html#ad1744441ef63654b7f8e2011055aa296)DynamicInvokeWithLog()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | object TaleWorlds.Library.Common.DynamicInvokeWithLog | ( | this Delegate | *method*, | |  |  | params object[] | *args* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_common.html#a93d1502d3cd462e81e253a53c482edf1)InvokeWithLog() [1/2]
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | object TaleWorlds.Library.Common.InvokeWithLog | ( | this MethodInfo | *methodInfo*, | |  |  | object | *obj*, | |  |  | params object[] | *args* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_common.html#a30a29955aaab2c36d6433400906a0728)InvokeWithLog() [2/2]
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | object TaleWorlds.Library.Common.InvokeWithLog | ( | this ConstructorInfo | *constructorInfo*, | |  |  | params object[] | *args* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_common.html#ad8e21d8b8c5d2225d915622bb8f0016a)TextContainsSpecialCharacters()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Library.Common.TextContainsSpecialCharacters | ( | string | *text* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_common.html#a7d1287885468eae732750a5c7826a58e)ParseIpAddress()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | uint TaleWorlds.Library.Common.ParseIpAddress | ( | string | *address* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_common.html#a81abd9e5753b18c292603992e2fa4b03)IsAllLetters()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Library.Common.IsAllLetters | ( | string | *text* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_common.html#a93f5bc768befb2cc280851171ef645f9)IsAllLettersOrWhiteSpaces()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Library.Common.IsAllLettersOrWhiteSpaces | ( | string | *text* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_common.html#aed5e9bbe37434f9d60af90b208ac0a41)IsCharAsian()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Library.Common.IsCharAsian | ( | char | *character* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_common.html#acc47c4a348f94f8b79fd2b677dc54dba)SetInvariantCulture()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Library.Common.SetInvariantCulture | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_common.html#a9d730235eba5abc086a4da57b605fd99)GetMethodInfo() [1/2]
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | MethodInfo TaleWorlds.Library.Common.GetMethodInfo | ( | Expression< Action > | *expression* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_common.html#ab1a78d657a9c8ace520e76067c0b9831)GetMethodInfo< T >()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | MethodInfo [TaleWorlds.Library.Common.GetMethodInfo](class_tale_worlds_1_1_library_1_1_common.html#a9d730235eba5abc086a4da57b605fd99)< T > | ( | Expression< Action< T > > | *expression* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_common.html#ae76157fdd75d4c77bf81241a68ab551d)GetMethodInfo< T, TResult >()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | MethodInfo [TaleWorlds.Library.Common.GetMethodInfo](class_tale_worlds_1_1_library_1_1_common.html#a9d730235eba5abc086a4da57b605fd99)< T, TResult > | ( | Expression< Func< T, TResult > > | *expression* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_common.html#a948cde7596e0669df5c987e97f062004)GetMethodInfo() [2/2]
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | MethodInfo TaleWorlds.Library.Common.GetMethodInfo | ( | LambdaExpression | *expression* | ) |  | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_library_1_1_common.html#ae029686e710160e06a9d8941e958f41d)PlatformFileHelper
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IPlatformFileHelper](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html) TaleWorlds.Library.Common.PlatformFileHelper | | staticgetset |

[◆](class_tale_worlds_1_1_library_1_1_common.html#aeccec0155b1b05a2c91b7828171dc53c)ConfigName
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Library.Common.ConfigName | | staticget |

[◆](class_tale_worlds_1_1_library_1_1_common.html#a6bbe06885c77ab3c0e45b038e766236d)ParallelOptions
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ParallelOptions TaleWorlds.Library.Common.ParallelOptions | | staticget |

