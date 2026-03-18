--- SOURCE: interface_tale_worlds_1_1_library_1_1_i_cache.html ---

TaleWorlds.Library.ICache Interface Reference|  |  |
| --- | --- |
| Public Member Functions | |
| Task< TItem > | [GetOrUpdate< TItem >](interface_tale_worlds_1_1_library_1_1_i_cache.html#aa791752262c916035ecb49d3e7604b9d) (string key, Func< Task< TItem > > factory, TimeSpan absoluteExpirationRelativeToNow, bool getFromFactoryIfCacheFails=true) |
| Task | [SetString](interface_tale_worlds_1_1_library_1_1_i_cache.html#a7f49c405c3934d8bdd333589bbc507fc) (string key, string value, TimeSpan? absoluteExpirationRelativeToNow) |
| Task< string > | [GetString](interface_tale_worlds_1_1_library_1_1_i_cache.html#a3ca51fcbcb4cd429a36b619998e0fc0c) (string key) |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_library_1_1_i_cache.html#aa791752262c916035ecb49d3e7604b9d)GetOrUpdate< TItem >()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| Task< TItem > TaleWorlds.Library.ICache.GetOrUpdate< TItem > | ( | string | *key*, |
|  |  | Func< Task< TItem > > | *factory*, |
|  |  | TimeSpan | *absoluteExpirationRelativeToNow*, |
|  |  | bool | *getFromFactoryIfCacheFails* = true ) |

[◆](interface_tale_worlds_1_1_library_1_1_i_cache.html#a7f49c405c3934d8bdd333589bbc507fc)SetString()
----------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| Task TaleWorlds.Library.ICache.SetString | ( | string | *key*, |
|  |  | string | *value*, |
|  |  | TimeSpan? | *absoluteExpirationRelativeToNow* ) |

[◆](interface_tale_worlds_1_1_library_1_1_i_cache.html#a3ca51fcbcb4cd429a36b619998e0fc0c)GetString()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| Task< string > TaleWorlds.Library.ICache.GetString | ( | string | *key* | ) |  |

