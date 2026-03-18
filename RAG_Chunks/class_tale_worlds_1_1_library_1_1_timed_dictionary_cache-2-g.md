--- SOURCE: class_tale_worlds_1_1_library_1_1_timed_dictionary_cache-2-g.html ---

TaleWorlds.Library.TimedDictionaryCache< TKey, TValue > Class Template ReferenceWraps the Dictionary<TKey, TValue> class to present a time-aware data structure that prunes stale entries. This class is lightweight when idle, no events will be run periodically. Pruning of expired cache items is only done on explicit or implicit request.

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [TimedDictionaryCache](class_tale_worlds_1_1_library_1_1_timed_dictionary_cache-2-g.html#af9099b1ba0cada863a97d39bb5ae0877) (long validMilliseconds) |
|  | [TimedDictionaryCache](class_tale_worlds_1_1_library_1_1_timed_dictionary_cache-2-g.html#aa3b941ad93a1e3275fed88b67e96c45f) (TimeSpan validTimeSpan) |
| void | [PruneExpiredItems](class_tale_worlds_1_1_library_1_1_timed_dictionary_cache-2-g.html#adcf7409bdc7277ac3c919e3b86faa717) () |
|  | There is normally no need to explicitly call this method, expired items are pruned implicitly when interacting with this class. |
| void | [Clear](class_tale_worlds_1_1_library_1_1_timed_dictionary_cache-2-g.html#a338d37c5c9bd0415339d947a5485fd90) () |
| bool | [ContainsKey](class_tale_worlds_1_1_library_1_1_timed_dictionary_cache-2-g.html#a0140b00125fd9ce5f591819f09042e2b) (TKey key) |
| bool | [Remove](class_tale_worlds_1_1_library_1_1_timed_dictionary_cache-2-g.html#a382c871300195a5e1522dfb6715c573a) (TKey key) |
| bool | [TryGetValue](class_tale_worlds_1_1_library_1_1_timed_dictionary_cache-2-g.html#a2322c3a99df1f381c1c2c1133e756d25) (TKey key, out TValue value) |
| MBReadOnlyDictionary< TKey, TValue > | [AsReadOnlyDictionary](class_tale_worlds_1_1_library_1_1_timed_dictionary_cache-2-g.html#abc2ef482e40eec44d2c624f00d2f3f94) () |
|  | Beware: Relatively expensive operation. Do not use if not compulsory. |

|  |  |
| --- | --- |
| Properties | |
| TValue | [this[TKey key]](class_tale_worlds_1_1_library_1_1_timed_dictionary_cache-2-g.html#a13cf95c6d22e09aefb0bb1368dd03db9) `[get, set]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_library_1_1_timed_dictionary_cache-2-g.html#af9099b1ba0cada863a97d39bb5ae0877)TimedDictionaryCache() [1/2]
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Library.TimedDictionaryCache< TKey, TValue >.TimedDictionaryCache | ( | long | *validMilliseconds* | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_timed_dictionary_cache-2-g.html#aa3b941ad93a1e3275fed88b67e96c45f)TimedDictionaryCache() [2/2]
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Library.TimedDictionaryCache< TKey, TValue >.TimedDictionaryCache | ( | TimeSpan | *validTimeSpan* | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_timed_dictionary_cache-2-g.html#adcf7409bdc7277ac3c919e3b86faa717)PruneExpiredItems()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Library.TimedDictionaryCache< TKey, TValue >.PruneExpiredItems | ( |  | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_timed_dictionary_cache-2-g.html#a338d37c5c9bd0415339d947a5485fd90)Clear()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Library.TimedDictionaryCache< TKey, TValue >.Clear | ( |  | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_timed_dictionary_cache-2-g.html#a0140b00125fd9ce5f591819f09042e2b)ContainsKey()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Library.TimedDictionaryCache< TKey, TValue >.ContainsKey | ( | TKey | *key* | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_timed_dictionary_cache-2-g.html#a382c871300195a5e1522dfb6715c573a)Remove()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Library.TimedDictionaryCache< TKey, TValue >.Remove | ( | TKey | *key* | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_timed_dictionary_cache-2-g.html#a2322c3a99df1f381c1c2c1133e756d25)TryGetValue()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Library.TimedDictionaryCache< TKey, TValue >.TryGetValue | ( | TKey | *key*, |
|  |  | out TValue | *value* ) |

[◆](class_tale_worlds_1_1_library_1_1_timed_dictionary_cache-2-g.html#abc2ef482e40eec44d2c624f00d2f3f94)AsReadOnlyDictionary()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| MBReadOnlyDictionary< TKey, TValue > TaleWorlds.Library.TimedDictionaryCache< TKey, TValue >.AsReadOnlyDictionary | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_library_1_1_timed_dictionary_cache-2-g.html#a13cf95c6d22e09aefb0bb1368dd03db9)this[TKey key]
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | TValue TaleWorlds.Library.TimedDictionaryCache< TKey, TValue >.this[TKey key] | | getset |

