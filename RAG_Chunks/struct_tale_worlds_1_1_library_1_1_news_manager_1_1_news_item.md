--- SOURCE: struct_tale_worlds_1_1_library_1_1_news_manager_1_1_news_item.html ---

TaleWorlds.Library.NewsManager.NewsItem Struct Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [NewsTypes](struct_tale_worlds_1_1_library_1_1_news_manager_1_1_news_item.html#ad2354299cf989771ad18fe7425d74a54) {     [LauncherSingleplayer](struct_tale_worlds_1_1_library_1_1_news_manager_1_1_news_item.html#ad2354299cf989771ad18fe7425d74a54af34ecc46dd5cc6356cacbe0389cad2ab) ,     [LauncherMultiplayer](struct_tale_worlds_1_1_library_1_1_news_manager_1_1_news_item.html#ad2354299cf989771ad18fe7425d74a54ac38e4403bccb4ec7661feb9b1c9df90e) ,     [MultiplayerLobby](struct_tale_worlds_1_1_library_1_1_news_manager_1_1_news_item.html#ad2354299cf989771ad18fe7425d74a54a2a2629ce178b548f7ecfda6135fd6015)   } |

|  |  |
| --- | --- |
| Properties | |
| string | [Title](struct_tale_worlds_1_1_library_1_1_news_manager_1_1_news_item.html#ac450af4288d06d935233aeabcf75bb03) `[get, set]` |
|  | Title of the news item. |
| string | [Description](struct_tale_worlds_1_1_library_1_1_news_manager_1_1_news_item.html#aeb665929a2c8d7bf83b9b4fa26b7dc49) `[get, set]` |
|  | Description of the news item. |
| string | [ImageSourcePath](struct_tale_worlds_1_1_library_1_1_news_manager_1_1_news_item.html#a4696fa710c0fc3ade8e0f1e98e0e6a81) `[get, set]` |
|  | Represents either an online image url or path of a sprite. |
| List< [NewsType](struct_tale_worlds_1_1_library_1_1_news_manager_1_1_news_type.html) > | [Feeds](struct_tale_worlds_1_1_library_1_1_news_manager_1_1_news_item.html#a783379ee096204a4c6536c09fc62922a) `[get, set]` |
|  | Determines the feeds that item will show up in. |
| string | [NewsLink](struct_tale_worlds_1_1_library_1_1_news_manager_1_1_news_item.html#a84f3a52ab1d853dd62a7df8faa8caf55) `[get, set]` |
|  | The URL that user should use to examine the news. |

Member Enumeration Documentation
--------------------------------

[◆](struct_tale_worlds_1_1_library_1_1_news_manager_1_1_news_item.html#ad2354299cf989771ad18fe7425d74a54)NewsTypes
------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.Library.NewsManager.NewsItem.NewsTypes](struct_tale_worlds_1_1_library_1_1_news_manager_1_1_news_item.html#ad2354299cf989771ad18fe7425d74a54) |

| Enumerator | |
| --- | --- |
| LauncherSingleplayer |  |
| LauncherMultiplayer |  |
| MultiplayerLobby |  |

Property Documentation
----------------------

[◆](struct_tale_worlds_1_1_library_1_1_news_manager_1_1_news_item.html#ac450af4288d06d935233aeabcf75bb03)Title
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Library.NewsManager.NewsItem.Title | | getset |

[◆](struct_tale_worlds_1_1_library_1_1_news_manager_1_1_news_item.html#aeb665929a2c8d7bf83b9b4fa26b7dc49)Description
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Library.NewsManager.NewsItem.Description | | getset |

[◆](struct_tale_worlds_1_1_library_1_1_news_manager_1_1_news_item.html#a4696fa710c0fc3ade8e0f1e98e0e6a81)ImageSourcePath
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Library.NewsManager.NewsItem.ImageSourcePath | | getset |

[◆](struct_tale_worlds_1_1_library_1_1_news_manager_1_1_news_item.html#a783379ee096204a4c6536c09fc62922a)Feeds
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[NewsType](struct_tale_worlds_1_1_library_1_1_news_manager_1_1_news_type.html)> TaleWorlds.Library.NewsManager.NewsItem.Feeds | | getset |

[◆](struct_tale_worlds_1_1_library_1_1_news_manager_1_1_news_item.html#a84f3a52ab1d853dd62a7df8faa8caf55)NewsLink
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Library.NewsManager.NewsItem.NewsLink | | getset |

