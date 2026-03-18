--- SOURCE: class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html ---

TaleWorlds.Library.MBSortedMultiList< TKey, TValue > Class Template ReferenceA sorted list variant which can contain multiple items with the same key Implementation is based on the classic list Time Complexities: Add, Remove: O(n).
[More...](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#details)

Inherits IReadOnlyList, and [TaleWorlds.Library.IMBCollection](interface_tale_worlds_1_1_library_1_1_i_m_b_collection.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [ComparerType](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a4aa5a9a03d16631172790526ece49b27) {     [None](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a4aa5a9a03d16631172790526ece49b27a6adf97f83acf6453d4a6a4b1070f3754) ,     [Custom](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a4aa5a9a03d16631172790526ece49b27a90589c47f06eb971d548591f23c285af) ,     [Ascending](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a4aa5a9a03d16631172790526ece49b27acf3fb1ff52ea1eed3347ac5401ee7f0c) ,     [Descending](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a4aa5a9a03d16631172790526ece49b27ae3cf5ac19407b1a62c6fccaff675a53b)   } |
|  | Comparer type for the list. [More...](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a4aa5a9a03d16631172790526ece49b27) |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [SMLValueEnumerator](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#aa47422c1352d7bb459cacc2b82bfbb79) (List< KeyValuePair< TKey, TValue > > list) |
| bool | [MoveNext](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a20d0cf2a7f2395a96273a040312dd48a) () |
| void | [Dispose](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a09a6380df1e62b5ebfe117d228b23a24) () |
| void | [Reset](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a58fd1d7ad3b643ba47a02a452912710f) () |
|  | [SMLKeyValueEnumerator](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a277c4ff86bb10cec477bcf37e93b30f6) (List< KeyValuePair< TKey, TValue > > list, TKey key, int startIndex) |
| bool | [MoveNext](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a20d0cf2a7f2395a96273a040312dd48a) () |
| void | [Dispose](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a09a6380df1e62b5ebfe117d228b23a24) () |
| void | [Reset](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a58fd1d7ad3b643ba47a02a452912710f) () |
|  | [MBSortedMultiList](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a728e3d90a8b3719dbf8bb8223f742430) (IComparer< TKey > customComparer) |
|  | Constructor. |
|  | [MBSortedMultiList](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#ae5536738b0eff65e2ce644a850cafb91) (bool isAscending=true) |
|  | Constructor. |
| bool | [Contains](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#ad0024704f85b8f77f5e66edc63da8871) (TKey key) |
|  | Checks if an item with the given key exists. |
| bool | [Contains](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#aad9526ac8aa7f2284cb497b9d38d1cdd) (TKey key, TValue value) |
|  | Checks if an item with the given key and data exists. |
| KeyValuePair< TKey, TValue > | [Get](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a1f91872c79869326b090ea0412c0ebbe) (int index) |
|  | Gets the key value tuple at the given index. |
| int | [FirstIndexOf](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a1767b3203b52fa72a759f664b7245534) (TKey key) |
|  | Returns the index of the first item with the given key. |
| int | [FirstIndexOf](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a63d249e47eba83dbb969fdf7b181d828) (TKey key, TValue value) |
|  | Returns the index of the item with the given key and value. |
| int | [LastIndexOf](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#ae9b947a3ef18d906634c24d532be7ad6) (TKey key) |
|  | Returns the index of the last item with the given key. |
| int | [LastIndexOf](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a218d636b29150fa32eba3e3f7614b5df) (TKey key, TValue value) |
|  | Returns the index of the last item with the given key and value. |
| bool | [All](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a66853f7d0e799db126f78e104f9b0530) (Predicate< KeyValuePair< TKey, TValue > > predicate) |
|  | Checks if the given predicate is true for all values. |
| bool | [Any](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#afdbd5d7204195dd0ba639b4a37467f3b) (Predicate< KeyValuePair< TKey, TValue > > predicate) |
|  | Checks if there exists any item for which the predicate returns true. |
| IEnumerator< TValue > | [GetValues](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a2a6e8b48fba617d7cc6a305627167c89) (TKey key) |
|  | Returns an enumerator traversing over all values having the specified key. |
| bool | [Find](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a73d0f888bc50f33b9b795cca6a226ef6) (Predicate< KeyValuePair< TKey, TValue > > predicate, out KeyValuePair< TKey, TValue > found, bool searchForward=true) |
|  | Find the first item that matches the given predicate. |
| int | [FindIndex](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#ae482a9d015097d985c9de1d50fdd16b5) (Predicate< KeyValuePair< TKey, TValue > > predicate, bool searchForward=true) |
|  | Find the index of the first item that matches the given predicate. |
| MBList< KeyValuePair< TKey, TValue > > | [FindAll](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a5ee3045be2090ef448fabd148bc7a387) (Predicate< KeyValuePair< TKey, TValue > > predicate) |
|  | Finds all items that match the given predicate. |
| void | [Add](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#ab981b0855fea0024bbaaa99000c92c9a) (TKey key, TValue value) |
|  | Adds a new value with the given key. |
| void | [AddRange](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a7aaef5ce023d4af03a45dcadc418e30d) (IEnumerable< KeyValuePair< TKey, TValue > > items) |
|  | Adds multiple key value pairs. |
| bool | [Remove](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#aa69b7db570f91c0a7455749dedf93008) (TKey key, TValue value) |
|  | Removes the last item with the given key and value. |
| bool | [Remove](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#acc4dba27f1c18fc296e43badcbb5b19d) (TKey key) |
|  | Removes the last item with the given key. |
| int | [RemoveAll](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#af7a7b92aaca5c1f44fb7d98dae07bb7d) (Predicate< KeyValuePair< TKey, TValue > > predicate) |
|  | Removes all items in the list that matches the given predicate. |
| void | [RemoveAt](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#aeb7fdefe241d6b8712e918d91b5c7946) (int index) |
|  | Removes the item at the specified index. |
| void | [RemoveLast](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#aa84784492841850528da30adbac91ff5) () |
|  | Removes the last item of the list. |
| void | [Clear](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#ab939107a8ed4903915c02fdf15ae18bc) () |
|  | Clears the sorted list. |
| void | [SetCustomComparer](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a7f6b23b5511eedee7a32213d25fc1cfb) (IComparer< TKey > customComparer) |
|  | Sets a custom comparer for the sorted multi list and re-sorts it. |
| void | [SetDefaultComparer](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a7c1db252b92484043452bf653adfd932) (bool isAscending=true) |
|  | Sets default ascending or descending comparer for the sorted multi list and re-sorts it. |
| void | [Reverse](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a0c0519306fa6a6459f2c595b3b19d856) () |
|  | Reverses the order of the list. |
| override string | [ToString](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a6f505dac0408e68fe669caa591e767cd) () |
|  | Default to string override. |
| IEnumerator< TValue > | [GetEnumerator](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#ae5d7b7f4ca76b2e5afb2673f1bd4eb3e) () |

|  |  |
| --- | --- |
| Properties | |
| TValue | [Current](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#ac6af3425f9bf8fcb1519f17546b50188) `[get]` |
| object IEnumerator. | [Current](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a587bd2d5062f89a4c6a42ee4f643b347) `[get]` |
| [ComparerType](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a4aa5a9a03d16631172790526ece49b27) | [Comparer](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#aa8c8ab5759b10aa21aadfd186e924377) `[get]` |
| int | [Count](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a6317a3f5b7468c88d40a473bb6935ae9) `[get]` |
| TValue | [this[int index]](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a0a37a5ef2fdbe666f0f69d91aadfd36b) `[get]` |
|  | Accessor which returns the value at the given index. |
| TValue | [FirstValue](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#ad63d82e1979a854e1cabb1620ae37ce1) `[get]` |
|  | Gets the first value of the list. |
| TValue | [LastValue](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a2050d148829bafc9400701797888d6b6) `[get]` |
|  | Gets the last value of the list. |

Detailed Description
--------------------

* due to array shifting
* last element addition & removal is still constant time
* additions and removal are made from the last entry having the specified key (and value if exists). Reducing shifting time. IndexOf(key), Contains(key): O(logn) IndexOf(key, value), Contains(key, value): O(logn + m)

m being count of values having the same key Find, Exists, TrueForAll: O(n) AddRange: O(nlogn)

* due to sorting

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *TKey* | : | *IComparable<TKey>* |  |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a4aa5a9a03d16631172790526ece49b27)ComparerType
-------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum TaleWorlds.Library.MBSortedMultiList-2-g.ComparerType |

| Enumerator | |
| --- | --- |
| None |  |
| Custom |  |
| Ascending |  |
| Descending |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#aa47422c1352d7bb459cacc2b82bfbb79)SMLValueEnumerator()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Library.MBSortedMultiList< TKey, TValue >.SMLValueEnumerator | ( | List< KeyValuePair< TKey, TValue > > | *list* | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a20d0cf2a7f2395a96273a040312dd48a)MoveNext() [1/2]
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Library.MBSortedMultiList< TKey, TValue >.MoveNext | ( |  | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a09a6380df1e62b5ebfe117d228b23a24)Dispose() [1/2]
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Library.MBSortedMultiList< TKey, TValue >.Dispose | ( |  | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a58fd1d7ad3b643ba47a02a452912710f)Reset() [1/2]
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Library.MBSortedMultiList< TKey, TValue >.Reset | ( |  | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a277c4ff86bb10cec477bcf37e93b30f6)SMLKeyValueEnumerator()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Library.MBSortedMultiList< TKey, TValue >.SMLKeyValueEnumerator | ( | List< KeyValuePair< TKey, TValue > > | *list*, |
|  |  | TKey | *key*, |
|  |  | int | *startIndex* ) |

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a20d0cf2a7f2395a96273a040312dd48a)MoveNext() [2/2]
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Library.MBSortedMultiList< TKey, TValue >.MoveNext | ( |  | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a09a6380df1e62b5ebfe117d228b23a24)Dispose() [2/2]
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Library.MBSortedMultiList< TKey, TValue >.Dispose | ( |  | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a58fd1d7ad3b643ba47a02a452912710f)Reset() [2/2]
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Library.MBSortedMultiList< TKey, TValue >.Reset | ( |  | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a728e3d90a8b3719dbf8bb8223f742430)MBSortedMultiList() [1/2]
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Library.MBSortedMultiList< TKey, TValue >.MBSortedMultiList | ( | IComparer< TKey > | *customComparer* | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#ae5536738b0eff65e2ce644a850cafb91)MBSortedMultiList() [2/2]
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Library.MBSortedMultiList< TKey, TValue >.MBSortedMultiList | ( | bool | *isAscending* = true | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#ad0024704f85b8f77f5e66edc63da8871)Contains() [1/2]
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Library.MBSortedMultiList< TKey, TValue >.Contains | ( | TKey | *key* | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#aad9526ac8aa7f2284cb497b9d38d1cdd)Contains() [2/2]
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Library.MBSortedMultiList< TKey, TValue >.Contains | ( | TKey | *key*, |
|  |  | TValue | *value* ) |

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a1f91872c79869326b090ea0412c0ebbe)Get()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| KeyValuePair< TKey, TValue > TaleWorlds.Library.MBSortedMultiList< TKey, TValue >.Get | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a1767b3203b52fa72a759f664b7245534)FirstIndexOf() [1/2]
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.Library.MBSortedMultiList< TKey, TValue >.FirstIndexOf | ( | TKey | *key* | ) |  |

Returns
:   Returns a non-negative index if the item is found. Negative otherwise

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a63d249e47eba83dbb969fdf7b181d828)FirstIndexOf() [2/2]
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.Library.MBSortedMultiList< TKey, TValue >.FirstIndexOf | ( | TKey | *key*, |
|  |  | TValue | *value* ) |

Returns
:   Returns a non-negative index if the item is found. Negative otherwise

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#ae9b947a3ef18d906634c24d532be7ad6)LastIndexOf() [1/2]
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.Library.MBSortedMultiList< TKey, TValue >.LastIndexOf | ( | TKey | *key* | ) |  |

Returns
:   Returns a non-negative index if the item is found. Negative otherwise

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a218d636b29150fa32eba3e3f7614b5df)LastIndexOf() [2/2]
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.Library.MBSortedMultiList< TKey, TValue >.LastIndexOf | ( | TKey | *key*, |
|  |  | TValue | *value* ) |

Returns
:   Returns a non-negative index if the item is found. Negative otherwise

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a66853f7d0e799db126f78e104f9b0530)All()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Library.MBSortedMultiList< TKey, TValue >.All | ( | Predicate< KeyValuePair< TKey, TValue > > | *predicate* | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#afdbd5d7204195dd0ba639b4a37467f3b)Any()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Library.MBSortedMultiList< TKey, TValue >.Any | ( | Predicate< KeyValuePair< TKey, TValue > > | *predicate* | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a2a6e8b48fba617d7cc6a305627167c89)GetValues()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| IEnumerator< TValue > TaleWorlds.Library.MBSortedMultiList< TKey, TValue >.GetValues | ( | TKey | *key* | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a73d0f888bc50f33b9b795cca6a226ef6)Find()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Library.MBSortedMultiList< TKey, TValue >.Find | ( | Predicate< KeyValuePair< TKey, TValue > > | *predicate*, |
|  |  | out KeyValuePair< TKey, TValue > | *found*, |
|  |  | bool | *searchForward* = true ) |

Parameters
:   |  |  |
    | --- | --- |
    | predicate | Bool predicate to be checked |
    | found | Outputted found value |
    | searchForward | If set, search is performed using forward traversal (i.e. from the front of the list to back). Otherwise it is performed backwards/param> Returns  True if found false otherwise |

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#ae482a9d015097d985c9de1d50fdd16b5)FindIndex()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.Library.MBSortedMultiList< TKey, TValue >.FindIndex | ( | Predicate< KeyValuePair< TKey, TValue > > | *predicate*, |
|  |  | bool | *searchForward* = true ) |

Parameters
:   |  |  |
    | --- | --- |
    | predicate | Bool predicate to be checked |
    | searchForward | If set, search is performed using forward traversal (i.e. from the front of the list to back). Otherwise it is performed backwards/param> Returns  Non-negative index if a matching item is found. Negative otherwise |

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a5ee3045be2090ef448fabd148bc7a387)FindAll()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| MBList< KeyValuePair< TKey, TValue > > TaleWorlds.Library.MBSortedMultiList< TKey, TValue >.FindAll | ( | Predicate< KeyValuePair< TKey, TValue > > | *predicate* | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#ab981b0855fea0024bbaaa99000c92c9a)Add()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.MBSortedMultiList< TKey, TValue >.Add | ( | TKey | *key*, |
|  |  | TValue | *value* ) |

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a7aaef5ce023d4af03a45dcadc418e30d)AddRange()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.MBSortedMultiList< TKey, TValue >.AddRange | ( | IEnumerable< KeyValuePair< TKey, TValue > > | *items* | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#aa69b7db570f91c0a7455749dedf93008)Remove() [1/2]
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Library.MBSortedMultiList< TKey, TValue >.Remove | ( | TKey | *key*, |
|  |  | TValue | *value* ) |

Returns
:   true if an item is found and removed. False otherwise

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#acc4dba27f1c18fc296e43badcbb5b19d)Remove() [2/2]
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Library.MBSortedMultiList< TKey, TValue >.Remove | ( | TKey | *key* | ) |  |

Returns
:   true if an item is found and removed. False otherwise

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#af7a7b92aaca5c1f44fb7d98dae07bb7d)RemoveAll()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.Library.MBSortedMultiList< TKey, TValue >.RemoveAll | ( | Predicate< KeyValuePair< TKey, TValue > > | *predicate* | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#aeb7fdefe241d6b8712e918d91b5c7946)RemoveAt()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.MBSortedMultiList< TKey, TValue >.RemoveAt | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#aa84784492841850528da30adbac91ff5)RemoveLast()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Library.MBSortedMultiList< TKey, TValue >.RemoveLast | ( |  | ) |  |

This is O(1) operation

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#ab939107a8ed4903915c02fdf15ae18bc)Clear()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Library.MBSortedMultiList< TKey, TValue >.Clear | ( |  | ) |  |

Implements [TaleWorlds.Library.IMBCollection](interface_tale_worlds_1_1_library_1_1_i_m_b_collection.html#a18069698dc26aa22a52a5d0b9f98f2fd).

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a7f6b23b5511eedee7a32213d25fc1cfb)SetCustomComparer()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.MBSortedMultiList< TKey, TValue >.SetCustomComparer | ( | IComparer< TKey > | *customComparer* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | customComparer |  |

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a7c1db252b92484043452bf653adfd932)SetDefaultComparer()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.MBSortedMultiList< TKey, TValue >.SetDefaultComparer | ( | bool | *isAscending* = true | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a0c0519306fa6a6459f2c595b3b19d856)Reverse()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Library.MBSortedMultiList< TKey, TValue >.Reverse | ( |  | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a6f505dac0408e68fe669caa591e767cd)ToString()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.Library.MBSortedMultiList< TKey, TValue >.ToString | ( |  | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#ae5d7b7f4ca76b2e5afb2673f1bd4eb3e)GetEnumerator()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerator< TValue > TaleWorlds.Library.MBSortedMultiList< TKey, TValue >.GetEnumerator | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#ac6af3425f9bf8fcb1519f17546b50188)Current [1/2]
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | TValue TaleWorlds.Library.MBSortedMultiList< TKey, TValue >.Current | | get |

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a587bd2d5062f89a4c6a42ee4f643b347)Current [2/2]
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | object IEnumerator. TaleWorlds.Library.MBSortedMultiList< TKey, TValue >.Current | | get |

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#aa8c8ab5759b10aa21aadfd186e924377)Comparer
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ComparerType](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a4aa5a9a03d16631172790526ece49b27) TaleWorlds.Library.MBSortedMultiList< TKey, TValue >.Comparer | | get |

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a6317a3f5b7468c88d40a473bb6935ae9)Count
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Library.MBSortedMultiList< TKey, TValue >.Count | | get |

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a0a37a5ef2fdbe666f0f69d91aadfd36b)this[int index]
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | TValue TaleWorlds.Library.MBSortedMultiList< TKey, TValue >.this[int index] | | get |

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#ad63d82e1979a854e1cabb1620ae37ce1)FirstValue
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | TValue TaleWorlds.Library.MBSortedMultiList< TKey, TValue >.FirstValue | | get |

[◆](class_tale_worlds_1_1_library_1_1_m_b_sorted_multi_list-2-g.html#a2050d148829bafc9400701797888d6b6)LastValue
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | TValue TaleWorlds.Library.MBSortedMultiList< TKey, TValue >.LastValue | | get |

