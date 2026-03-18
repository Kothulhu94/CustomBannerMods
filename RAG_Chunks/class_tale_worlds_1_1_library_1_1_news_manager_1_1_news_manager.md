--- SOURCE: class_tale_worlds_1_1_library_1_1_news_manager_1_1_news_manager.html ---

TaleWorlds.Library.NewsManager.NewsManager Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [NewsManager](class_tale_worlds_1_1_library_1_1_news_manager_1_1_news_manager.html#a7adf2e10aa553e662199be4b51d03c08) () |
| async Task< MBReadOnlyList< [NewsItem](struct_tale_worlds_1_1_library_1_1_news_manager_1_1_news_item.html) > > | [GetNewsItems](class_tale_worlds_1_1_library_1_1_news_manager_1_1_news_manager.html#a2362191c652589668d1320721f317613) (bool forceRefresh) |
|  | Gets NewsItems async. |
| void | [SetNewsSourceURL](class_tale_worlds_1_1_library_1_1_news_manager_1_1_news_manager.html#a8bd1962cdb09d83cdbadd9785c8fc3a6) (string url) |
|  | Sets the source url for the news items. File that it returns should be compliant with the JSon structure of the Array of [NewsItem](struct_tale_worlds_1_1_library_1_1_news_manager_1_1_news_item.html) structure(for deserializing). |
| async Task | [UpdateNewsItems](class_tale_worlds_1_1_library_1_1_news_manager_1_1_news_manager.html#acd9c3ed0117c385931a09c105ef32bb8) (bool forceRefresh) |
|  | Updates NewsItems async locally. |
| void | [UpdateLocalizationID](class_tale_worlds_1_1_library_1_1_news_manager_1_1_news_manager.html#a33514bc650423df4b33fef6029d7c1c3) (string localizationID) |
| void | [OnFinalize](class_tale_worlds_1_1_library_1_1_news_manager_1_1_news_manager.html#a4771a663016d851d2d1907fdcda9780f) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static Task< T > | [DeserializeObjectAsync< T >](class_tale_worlds_1_1_library_1_1_news_manager_1_1_news_manager.html#a66393c2cbbbd1bc5ec4b60cb2a52f7f5) (string json) |

|  |  |
| --- | --- |
| Properties | |
| MBReadOnlyList< [NewsItem](struct_tale_worlds_1_1_library_1_1_news_manager_1_1_news_item.html) > | [NewsItems](class_tale_worlds_1_1_library_1_1_news_manager_1_1_news_manager.html#a7301820a28c6e6087501cd8e146e4c33) `[get]` |
| bool | [IsInPreviewMode](class_tale_worlds_1_1_library_1_1_news_manager_1_1_news_manager.html#a164a50779b1491e77f34a5f01905e4f4) `[get]` |
| string | [LocalizationID](class_tale_worlds_1_1_library_1_1_news_manager_1_1_news_manager.html#a7173198adc2f59c8965d483df9181af4) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_library_1_1_news_manager_1_1_news_manager.html#a7adf2e10aa553e662199be4b51d03c08)NewsManager()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Library.NewsManager.NewsManager.NewsManager | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_library_1_1_news_manager_1_1_news_manager.html#a2362191c652589668d1320721f317613)GetNewsItems()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| async Task< MBReadOnlyList< [NewsItem](struct_tale_worlds_1_1_library_1_1_news_manager_1_1_news_item.html) > > TaleWorlds.Library.NewsManager.NewsManager.GetNewsItems | ( | bool | *forceRefresh* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | forceRefresh | Represents if system should get items again, fresh |

Returns
:   Returns News Items

[◆](class_tale_worlds_1_1_library_1_1_news_manager_1_1_news_manager.html#a8bd1962cdb09d83cdbadd9785c8fc3a6)SetNewsSourceURL()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.NewsManager.NewsManager.SetNewsSourceURL | ( | string | *url* | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_news_manager_1_1_news_manager.html#acd9c3ed0117c385931a09c105ef32bb8)UpdateNewsItems()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| async Task TaleWorlds.Library.NewsManager.NewsManager.UpdateNewsItems | ( | bool | *forceRefresh* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | forceRefresh | Determines if the manager should reset the cache or not |

Returns
:   Returns News Items

[◆](class_tale_worlds_1_1_library_1_1_news_manager_1_1_news_manager.html#a66393c2cbbbd1bc5ec4b60cb2a52f7f5)DeserializeObjectAsync< T >()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | Task< T > TaleWorlds.Library.NewsManager.NewsManager.DeserializeObjectAsync< T > | ( | string | *json* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_news_manager_1_1_news_manager.html#a33514bc650423df4b33fef6029d7c1c3)UpdateLocalizationID()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.NewsManager.NewsManager.UpdateLocalizationID | ( | string | *localizationID* | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_news_manager_1_1_news_manager.html#a4771a663016d851d2d1907fdcda9780f)OnFinalize()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Library.NewsManager.NewsManager.OnFinalize | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_library_1_1_news_manager_1_1_news_manager.html#a7301820a28c6e6087501cd8e146e4c33)NewsItems
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[NewsItem](struct_tale_worlds_1_1_library_1_1_news_manager_1_1_news_item.html)> TaleWorlds.Library.NewsManager.NewsManager.NewsItems | | get |

[◆](class_tale_worlds_1_1_library_1_1_news_manager_1_1_news_manager.html#a164a50779b1491e77f34a5f01905e4f4)IsInPreviewMode
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Library.NewsManager.NewsManager.IsInPreviewMode | | get |

[◆](class_tale_worlds_1_1_library_1_1_news_manager_1_1_news_manager.html#a7173198adc2f59c8965d483df9181af4)LocalizationID
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Library.NewsManager.NewsManager.LocalizationID | | get |

