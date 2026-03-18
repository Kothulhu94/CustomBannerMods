--- SOURCE: class_tale_worlds_1_1_core_1_1_m_b_save_load.html ---

TaleWorlds.Core.MBSaveLoad Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [SetSaveDriver](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#a8d7aa4708b61079311f902e59efd801f) (ISaveDriver saveDriver) |
| static SaveGameFileInfo[] | [GetSaveFiles](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#a6ee73009e1c6f729ebc2e10bd739da71) (Func< SaveGameFileInfo, bool > condition=null) |
| static bool | [IsSaveGameFileExists](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#a62442d7fde4a258c22c307e7fe5e0ec5) (string saveFileName) |
| static string[] | [GetSaveFileNames](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#a8d810c0f16ad6d9831ebfb0c8e6f0a7d) () |
| static LoadResult | [LoadSaveGameData](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#a3d2cd392611b1b74ec40e285dfefd37a) (string saveName) |
| static SaveGameFileInfo | [GetSaveFileWithName](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#a8f6a2479932213ab6b8f963d1a918bc1) (string saveName) |
| static void | [QuickSaveCurrentGame](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#a2f5b17d27e760c70241f3ecdf4f75fca) ([CampaignSaveMetaDataArgs](struct_tale_worlds_1_1_core_1_1_campaign_save_meta_data_args.html) campaignMetaData, Action<([SaveResult](namespace_tale_worlds_1_1_library.html#a1fede41b93a35a4b6f9d87fcab58a5bc), string)> onSaveCompleted) |
| static void | [AutoSaveCurrentGame](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#ad0a3105334df7b85dfad1a00a9c70c06) ([CampaignSaveMetaDataArgs](struct_tale_worlds_1_1_core_1_1_campaign_save_meta_data_args.html) campaignMetaData, Action<([SaveResult](namespace_tale_worlds_1_1_library.html#a1fede41b93a35a4b6f9d87fcab58a5bc), string)> onSaveCompleted) |
| static void | [SaveAsCurrentGame](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#a0d50858aee1883315ce2083c98c0f71c) ([CampaignSaveMetaDataArgs](struct_tale_worlds_1_1_core_1_1_campaign_save_meta_data_args.html) campaignMetaData, string saveName, Action<([SaveResult](namespace_tale_worlds_1_1_library.html#a1fede41b93a35a4b6f9d87fcab58a5bc), string)> onSaveCompleted) |
| static bool | [DeleteSaveGame](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#ac08d1315f080185023400a75581a0862) (string saveName) |
| static void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#aaeca4f97784f7c5b4390fc445207faa3) ([GameTextManager](class_tale_worlds_1_1_core_1_1_game_text_manager.html) localizedTextProvider) |
| static void | [OnNewGame](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#ab5e7d9afac3ece5ec210a2d4641c1a2c) () |
| static void | [OnGameDestroy](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#a74484a94a29b3e7e7d23ee38c764c4fa) () |
| static void | [OnStartGame](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#abdf4e3716b301de4527788180dc0f500) (LoadResult loadResult) |
| static bool | [IsSaveFileNameReserved](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#a999042b0816a3ec9c784f5542011238e) (string name) |
| static int | [GetMaxNumberOfSaves](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#ae0e4c0947e154604445699ae485f0a0b) () |
| static bool | [IsMaxNumberOfSavesReached](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#a8ad1a5dfe459ce189f4cbd096d5ab319) () |

|  |  |
| --- | --- |
| Properties | |
| static char | [ModuleVersionSeperator](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#ae16428938cffdc1ed154d8706b45dd91) `[get]` |
| static char | [ModuleCodeSeperator](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#a6dfee0d70f2a3ad9b9ab15ec3467eb4d) `[get]` |
| static [ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html) | [LastLoadedGameVersion](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#a174471223fd5a90cf8311bc6cbae7f0e) `[get]` |
| static [ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html) | [CurrentVersion](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#a9e9abccb45466be0ab34f6c1b02e2309) = [ApplicationVersion.FromParametersFile](struct_tale_worlds_1_1_library_1_1_application_version.html#a20d20d577ddb19b5041d27d6ba55185a)() `[get]` |
| static bool | [IsUpdatingGameVersion](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#a4c76c748dbb0fd7491a2636f4c8f148f) `[get]` |
| static int | [NumberOfCurrentSaves](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#ace2ac4ece213feb7ed5d79742e4d87b5) `[get]` |
| static string | [ActiveSaveSlotName](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#a2b913c62d397f3d974de941e347d4601) = null `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#a8d7aa4708b61079311f902e59efd801f)SetSaveDriver()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Core.MBSaveLoad.SetSaveDriver | ( | ISaveDriver | *saveDriver* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#a6ee73009e1c6f729ebc2e10bd739da71)GetSaveFiles()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | SaveGameFileInfo[] TaleWorlds.Core.MBSaveLoad.GetSaveFiles | ( | Func< SaveGameFileInfo, bool > | *condition* = null | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#a62442d7fde4a258c22c307e7fe5e0ec5)IsSaveGameFileExists()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Core.MBSaveLoad.IsSaveGameFileExists | ( | string | *saveFileName* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#a8d810c0f16ad6d9831ebfb0c8e6f0a7d)GetSaveFileNames()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | string[] TaleWorlds.Core.MBSaveLoad.GetSaveFileNames | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#a3d2cd392611b1b74ec40e285dfefd37a)LoadSaveGameData()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | LoadResult TaleWorlds.Core.MBSaveLoad.LoadSaveGameData | ( | string | *saveName* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#a8f6a2479932213ab6b8f963d1a918bc1)GetSaveFileWithName()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | SaveGameFileInfo TaleWorlds.Core.MBSaveLoad.GetSaveFileWithName | ( | string | *saveName* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#a2f5b17d27e760c70241f3ecdf4f75fca)QuickSaveCurrentGame()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Core.MBSaveLoad.QuickSaveCurrentGame | ( | [CampaignSaveMetaDataArgs](struct_tale_worlds_1_1_core_1_1_campaign_save_meta_data_args.html) | *campaignMetaData*, | |  |  | Action<([SaveResult](namespace_tale_worlds_1_1_library.html#a1fede41b93a35a4b6f9d87fcab58a5bc), string)> | *onSaveCompleted* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#ad0a3105334df7b85dfad1a00a9c70c06)AutoSaveCurrentGame()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Core.MBSaveLoad.AutoSaveCurrentGame | ( | [CampaignSaveMetaDataArgs](struct_tale_worlds_1_1_core_1_1_campaign_save_meta_data_args.html) | *campaignMetaData*, | |  |  | Action<([SaveResult](namespace_tale_worlds_1_1_library.html#a1fede41b93a35a4b6f9d87fcab58a5bc), string)> | *onSaveCompleted* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#a0d50858aee1883315ce2083c98c0f71c)SaveAsCurrentGame()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Core.MBSaveLoad.SaveAsCurrentGame | ( | [CampaignSaveMetaDataArgs](struct_tale_worlds_1_1_core_1_1_campaign_save_meta_data_args.html) | *campaignMetaData*, | |  |  | string | *saveName*, | |  |  | Action<([SaveResult](namespace_tale_worlds_1_1_library.html#a1fede41b93a35a4b6f9d87fcab58a5bc), string)> | *onSaveCompleted* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#ac08d1315f080185023400a75581a0862)DeleteSaveGame()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Core.MBSaveLoad.DeleteSaveGame | ( | string | *saveName* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#aaeca4f97784f7c5b4390fc445207faa3)Initialize()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Core.MBSaveLoad.Initialize | ( | [GameTextManager](class_tale_worlds_1_1_core_1_1_game_text_manager.html) | *localizedTextProvider* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#ab5e7d9afac3ece5ec210a2d4641c1a2c)OnNewGame()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Core.MBSaveLoad.OnNewGame | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#a74484a94a29b3e7e7d23ee38c764c4fa)OnGameDestroy()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Core.MBSaveLoad.OnGameDestroy | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#abdf4e3716b301de4527788180dc0f500)OnStartGame()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Core.MBSaveLoad.OnStartGame | ( | LoadResult | *loadResult* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#a999042b0816a3ec9c784f5542011238e)IsSaveFileNameReserved()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Core.MBSaveLoad.IsSaveFileNameReserved | ( | string | *name* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#ae0e4c0947e154604445699ae485f0a0b)GetMaxNumberOfSaves()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.Core.MBSaveLoad.GetMaxNumberOfSaves | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#a8ad1a5dfe459ce189f4cbd096d5ab319)IsMaxNumberOfSavesReached()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.Core.MBSaveLoad.IsMaxNumberOfSavesReached | ( |  | ) |  | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#ae16428938cffdc1ed154d8706b45dd91)ModuleVersionSeperator
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | char TaleWorlds.Core.MBSaveLoad.ModuleVersionSeperator | | staticget |

[◆](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#a6dfee0d70f2a3ad9b9ab15ec3467eb4d)ModuleCodeSeperator
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | char TaleWorlds.Core.MBSaveLoad.ModuleCodeSeperator | | staticget |

[◆](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#a174471223fd5a90cf8311bc6cbae7f0e)LastLoadedGameVersion
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html) TaleWorlds.Core.MBSaveLoad.LastLoadedGameVersion | | staticget |

[◆](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#a9e9abccb45466be0ab34f6c1b02e2309)CurrentVersion
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html) TaleWorlds.Core.MBSaveLoad.CurrentVersion = [ApplicationVersion.FromParametersFile](struct_tale_worlds_1_1_library_1_1_application_version.html#a20d20d577ddb19b5041d27d6ba55185a)() | | staticget |

[◆](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#a4c76c748dbb0fd7491a2636f4c8f148f)IsUpdatingGameVersion
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.MBSaveLoad.IsUpdatingGameVersion | | staticget |

[◆](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#ace2ac4ece213feb7ed5d79742e4d87b5)NumberOfCurrentSaves
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.MBSaveLoad.NumberOfCurrentSaves | | staticget |

[◆](class_tale_worlds_1_1_core_1_1_m_b_save_load.html#a2b913c62d397f3d974de941e347d4601)ActiveSaveSlotName
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.MBSaveLoad.ActiveSaveSlotName = null | | staticget |

