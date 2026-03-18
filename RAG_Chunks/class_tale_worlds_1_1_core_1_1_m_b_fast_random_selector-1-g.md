--- SOURCE: class_tale_worlds_1_1_core_1_1_m_b_fast_random_selector-1-g.html ---

TaleWorlds.Core.MBFastRandomSelector< T > Class Template ReferenceSelects distinct entries from a list in random. Does not modify the original list. But keeps a reference to it.
[More...](class_tale_worlds_1_1_core_1_1_m_b_fast_random_selector-1-g.html#details)

|  |  |
| --- | --- |
| Classes | |
| struct | [IndexEntry](struct_tale_worlds_1_1_core_1_1_m_b_fast_random_selector-1-g_1_1_index_entry.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [IndexEntry](class_tale_worlds_1_1_core_1_1_m_b_fast_random_selector-1-g.html#ac792fdb1589d9df70df949f9722d5e28) (ushort index, ushort version) |
|  | [MBFastRandomSelector](class_tale_worlds_1_1_core_1_1_m_b_fast_random_selector-1-g.html#ad3b419e15ffe6a4aadee9d1d8be011d4) (ushort capacity=[MinimumCapacity](class_tale_worlds_1_1_core_1_1_m_b_fast_random_selector-1-g.html#a9cddf4df1a860bcf319b7c68e9cadda5)) |
|  | [MBFastRandomSelector](class_tale_worlds_1_1_core_1_1_m_b_fast_random_selector-1-g.html#a79a4fa0b08dba658387b220b0b239915) (MBReadOnlyList< T > list, ushort capacity=[MinimumCapacity](class_tale_worlds_1_1_core_1_1_m_b_fast_random_selector-1-g.html#a9cddf4df1a860bcf319b7c68e9cadda5)) |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_fast_random_selector-1-g.html#ac914f092a6f52dd94788e00c7c221c77) (MBReadOnlyList< T > list) |
| void | [Reset](class_tale_worlds_1_1_core_1_1_m_b_fast_random_selector-1-g.html#aec1bbab2b669c0864322835af9732079) () |
| void | [Pack](class_tale_worlds_1_1_core_1_1_m_b_fast_random_selector-1-g.html#a1fadacaf7349284d6de7cad12342f58f) () |
|  | Reduces the capacity of the selector to list capacity if a selection list is initialized. Or minimum capacity. |
| bool | [SelectRandom](class_tale_worlds_1_1_core_1_1_m_b_fast_random_selector-1-g.html#a12e101c83dbd03ef2a4c92d75685688a) (out T selection, Predicate< T > conditions=null) |
|  | Picks the next random entry in the selection list satisfying conditions. |

|  |  |
| --- | --- |
| Public Attributes | |
| ushort | [Index](class_tale_worlds_1_1_core_1_1_m_b_fast_random_selector-1-g.html#a1d9d1fe7a3db36a3905f87d354dee302) |
| ushort | [Version](class_tale_worlds_1_1_core_1_1_m_b_fast_random_selector-1-g.html#a21583d4f5ed6e0d71660396b0a3c52b7) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const ushort | [MinimumCapacity](class_tale_worlds_1_1_core_1_1_m_b_fast_random_selector-1-g.html#a9cddf4df1a860bcf319b7c68e9cadda5) = 32 |
| const ushort | [MaximumCapacity](class_tale_worlds_1_1_core_1_1_m_b_fast_random_selector-1-g.html#ae14848a0b1e62cf9ef2edcf7db64e5fa) = ushort.MaxValue |

|  |  |
| --- | --- |
| Properties | |
| ushort | [RemainingCount](class_tale_worlds_1_1_core_1_1_m_b_fast_random_selector-1-g.html#a449533a882df2e5876fa658acc49d783) `[get]` |

Detailed Description
--------------------

REMARK\_ATES: Can operate on a list with up to 65,535 elements (max range of 16bit unsigned short) for memory/performance considerations REMARK\_ATES: Any changes to the original list will invalidate the random selector.

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_m_b_fast_random_selector-1-g.html#ac792fdb1589d9df70df949f9722d5e28)IndexEntry()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Core.MBFastRandomSelector< T >.IndexEntry | ( | ushort | *index*, |
|  |  | ushort | *version* ) |

[◆](class_tale_worlds_1_1_core_1_1_m_b_fast_random_selector-1-g.html#ad3b419e15ffe6a4aadee9d1d8be011d4)MBFastRandomSelector() [1/2]
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Core.MBFastRandomSelector< T >.MBFastRandomSelector | ( | ushort | *capacity* = [MinimumCapacity](class_tale_worlds_1_1_core_1_1_m_b_fast_random_selector-1-g.html#a9cddf4df1a860bcf319b7c68e9cadda5) | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_m_b_fast_random_selector-1-g.html#a79a4fa0b08dba658387b220b0b239915)MBFastRandomSelector() [2/2]
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Core.MBFastRandomSelector< T >.MBFastRandomSelector | ( | MBReadOnlyList< T > | *list*, |
|  |  | ushort | *capacity* = [MinimumCapacity](class_tale_worlds_1_1_core_1_1_m_b_fast_random_selector-1-g.html#a9cddf4df1a860bcf319b7c68e9cadda5) ) |

[◆](class_tale_worlds_1_1_core_1_1_m_b_fast_random_selector-1-g.html#ac914f092a6f52dd94788e00c7c221c77)Initialize()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.MBFastRandomSelector< T >.Initialize | ( | MBReadOnlyList< T > | *list* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_m_b_fast_random_selector-1-g.html#aec1bbab2b669c0864322835af9732079)Reset()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.MBFastRandomSelector< T >.Reset | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_m_b_fast_random_selector-1-g.html#a1fadacaf7349284d6de7cad12342f58f)Pack()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.MBFastRandomSelector< T >.Pack | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_m_b_fast_random_selector-1-g.html#a12e101c83dbd03ef2a4c92d75685688a)SelectRandom()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Core.MBFastRandomSelector< T >.SelectRandom | ( | out T | *selection*, |
|  |  | Predicate< T > | *conditions* = null ) |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_core_1_1_m_b_fast_random_selector-1-g.html#a1d9d1fe7a3db36a3905f87d354dee302)Index
------------------------------------------------------------------------------------------------------------

|  |
| --- |
| ushort TaleWorlds.Core.MBFastRandomSelector< T >.Index |

[◆](class_tale_worlds_1_1_core_1_1_m_b_fast_random_selector-1-g.html#a21583d4f5ed6e0d71660396b0a3c52b7)Version
--------------------------------------------------------------------------------------------------------------

|  |
| --- |
| ushort TaleWorlds.Core.MBFastRandomSelector< T >.Version |

[◆](class_tale_worlds_1_1_core_1_1_m_b_fast_random_selector-1-g.html#a9cddf4df1a860bcf319b7c68e9cadda5)MinimumCapacity
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const ushort TaleWorlds.Core.MBFastRandomSelector< T >.MinimumCapacity = 32 | | static |

[◆](class_tale_worlds_1_1_core_1_1_m_b_fast_random_selector-1-g.html#ae14848a0b1e62cf9ef2edcf7db64e5fa)MaximumCapacity
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const ushort TaleWorlds.Core.MBFastRandomSelector< T >.MaximumCapacity = ushort.MaxValue | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_m_b_fast_random_selector-1-g.html#a449533a882df2e5876fa658acc49d783)RemainingCount
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ushort TaleWorlds.Core.MBFastRandomSelector< T >.RemainingCount | | get |

