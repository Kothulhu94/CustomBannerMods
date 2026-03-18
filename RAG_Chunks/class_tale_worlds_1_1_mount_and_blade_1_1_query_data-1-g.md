--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_query_data-1-g.html ---

TaleWorlds.MountAndBlade.QueryData< T > Class Template ReferenceInherits [TaleWorlds.MountAndBlade.IQueryData](interface_tale_worlds_1_1_mount_and_blade_1_1_i_query_data.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [QueryData](class_tale_worlds_1_1_mount_and_blade_1_1_query_data-1-g.html#ac59ae189cbf45d22c1c12491d212a6f4) (Func< T > valueFunc, float lifetime) |
|  | [QueryData](class_tale_worlds_1_1_mount_and_blade_1_1_query_data-1-g.html#afb6cbc187833a7df13de5b5b380f881b) (Func< T > valueFunc, float lifetime, T defaultCachedValue) |
| void | [Evaluate](class_tale_worlds_1_1_mount_and_blade_1_1_query_data-1-g.html#a066e6c7bdd465d5eef61f4a7426f60bb) (float currentTime) |
| void | [SetValue](class_tale_worlds_1_1_mount_and_blade_1_1_query_data-1-g.html#a551f993e9b1da7dd22eeec63cbb7dc80) (T value, float currentTime) |
| T | [GetCachedValue](class_tale_worlds_1_1_mount_and_blade_1_1_query_data-1-g.html#a3888bcf9e8482234cd706b870115039e) () |
| T | [GetCachedValueUnlessTooOld](class_tale_worlds_1_1_mount_and_blade_1_1_query_data-1-g.html#ae2e3003375b0ce3627d24078c53e2fd4) () |
| T | [GetCachedValueWithMaxAge](class_tale_worlds_1_1_mount_and_blade_1_1_query_data-1-g.html#a6ef82ce66191aaac9b9cefd4f6d4c0a4) (float age) |
| void | [Expire](class_tale_worlds_1_1_mount_and_blade_1_1_query_data-1-g.html#a1fc4f2dc150a73879a1e28ab78b8ed2e) () |
| void | [SetSyncGroup](class_tale_worlds_1_1_mount_and_blade_1_1_query_data-1-g.html#ac9c204def882926e385a496936d864aa) ([IQueryData](interface_tale_worlds_1_1_mount_and_blade_1_1_i_query_data.html)[] syncGroup) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [SetupSyncGroup](class_tale_worlds_1_1_mount_and_blade_1_1_query_data-1-g.html#a5ad619224aafa92a48e8d55f33054e37) (params [IQueryData](interface_tale_worlds_1_1_mount_and_blade_1_1_i_query_data.html)[] groupItems) |

|  |  |
| --- | --- |
| Properties | |
| T | [Value](class_tale_worlds_1_1_mount_and_blade_1_1_query_data-1-g.html#ac3c1368e2d4ffd66b73893e88ef9562a) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_query_data-1-g.html#ac59ae189cbf45d22c1c12491d212a6f4)QueryData() [1/2]
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.QueryData< T >.QueryData | ( | Func< T > | *valueFunc*, |
|  |  | float | *lifetime* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_query_data-1-g.html#afb6cbc187833a7df13de5b5b380f881b)QueryData() [2/2]
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.QueryData< T >.QueryData | ( | Func< T > | *valueFunc*, |
|  |  | float | *lifetime*, |
|  |  | T | *defaultCachedValue* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_query_data-1-g.html#a066e6c7bdd465d5eef61f4a7426f60bb)Evaluate()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.QueryData< T >.Evaluate | ( | float | *currentTime* | ) |  |

Implements [TaleWorlds.MountAndBlade.IQueryData](interface_tale_worlds_1_1_mount_and_blade_1_1_i_query_data.html#a0a9ed5467f5a26f12a487919db78c153).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_query_data-1-g.html#a551f993e9b1da7dd22eeec63cbb7dc80)SetValue()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.QueryData< T >.SetValue | ( | T | *value*, |
|  |  | float | *currentTime* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_query_data-1-g.html#a3888bcf9e8482234cd706b870115039e)GetCachedValue()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| T TaleWorlds.MountAndBlade.QueryData< T >.GetCachedValue | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_query_data-1-g.html#ae2e3003375b0ce3627d24078c53e2fd4)GetCachedValueUnlessTooOld()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| T TaleWorlds.MountAndBlade.QueryData< T >.GetCachedValueUnlessTooOld | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_query_data-1-g.html#a6ef82ce66191aaac9b9cefd4f6d4c0a4)GetCachedValueWithMaxAge()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| T TaleWorlds.MountAndBlade.QueryData< T >.GetCachedValueWithMaxAge | ( | float | *age* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_query_data-1-g.html#a1fc4f2dc150a73879a1e28ab78b8ed2e)Expire()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.QueryData< T >.Expire | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IQueryData](interface_tale_worlds_1_1_mount_and_blade_1_1_i_query_data.html#a12b062961e2e260b99f76180d3a633bc).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_query_data-1-g.html#a5ad619224aafa92a48e8d55f33054e37)SetupSyncGroup()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.QueryData< T >.SetupSyncGroup | ( | params [IQueryData](interface_tale_worlds_1_1_mount_and_blade_1_1_i_query_data.html)[] | *groupItems* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_query_data-1-g.html#ac9c204def882926e385a496936d864aa)SetSyncGroup()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.QueryData< T >.SetSyncGroup | ( | [IQueryData](interface_tale_worlds_1_1_mount_and_blade_1_1_i_query_data.html)[] | *syncGroup* | ) |  |

Implements [TaleWorlds.MountAndBlade.IQueryData](interface_tale_worlds_1_1_mount_and_blade_1_1_i_query_data.html#ad1dab7f37a7aa58a5e3523f1dd05b6e4).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_query_data-1-g.html#ac3c1368e2d4ffd66b73893e88ef9562a)Value
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | T TaleWorlds.MountAndBlade.QueryData< T >.Value | | get |

