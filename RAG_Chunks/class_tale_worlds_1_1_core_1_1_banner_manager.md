--- SOURCE: class_tale_worlds_1_1_core_1_1_banner_manager.html ---

TaleWorlds.Core.BannerManager Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
| int | [GetRandomColorId](class_tale_worlds_1_1_core_1_1_banner_manager.html#a03637877ed5ce95bc49ef47e1a030efe) ([MBFastRandom](class_tale_worlds_1_1_core_1_1_m_b_fast_random.html) random) |
| [BannerIconData](struct_tale_worlds_1_1_core_1_1_banner_icon_data.html) | [GetIconDataFromIconId](class_tale_worlds_1_1_core_1_1_banner_manager.html#a72781f917df3d6afb4574e43763b9af3) (int id) |
| int | [GetRandomBackgroundId](class_tale_worlds_1_1_core_1_1_banner_manager.html#abc6b21804c1365ab6d479a4110c7b48a) ([MBFastRandom](class_tale_worlds_1_1_core_1_1_m_b_fast_random.html) random) |
| int | [GetRandomBannerIconId](class_tale_worlds_1_1_core_1_1_banner_manager.html#a36cfc761d406e1f0af4de52e32f80b19) ([MBFastRandom](class_tale_worlds_1_1_core_1_1_m_b_fast_random.html) random) |
| string | [GetBackgroundMeshName](class_tale_worlds_1_1_core_1_1_banner_manager.html#aa77ba3f9603ce81f86723a1a3c79002a) (int id) |
| string | [GetIconSourceTextureName](class_tale_worlds_1_1_core_1_1_banner_manager.html#abcd06ae6e93e3510ec15a08e7a8e7933) (int id) |
| void | [SetBaseBackgroundId](class_tale_worlds_1_1_core_1_1_banner_manager.html#a606bfadf76e74275a1b8fed203407f96) (int id) |
| void | [SetCultureColors](class_tale_worlds_1_1_core_1_1_banner_manager.html#a140082633745f9b91862ab81f3adaab7) ([BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) culture, List< [BannerColor](struct_tale_worlds_1_1_core_1_1_banner_color.html) > color) |
| void | [LoadBannerIcons](class_tale_worlds_1_1_core_1_1_banner_manager.html#a5b7ff0b848a52fca498662d5d3b69f6b) () |
| void | [LoadBannerIcons](class_tale_worlds_1_1_core_1_1_banner_manager.html#a1ceac7bcc56a604fb75d33f8b8ccc39b) (string xmlPath) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [Initialize](class_tale_worlds_1_1_core_1_1_banner_manager.html#ac3c3272b24238bdd6ec0384919e9a749) () |
| static void | [ResetAndLoad](class_tale_worlds_1_1_core_1_1_banner_manager.html#ab05b05bd7aed4eb91d2b79b3c4fc0521) () |
| static UInt32 | [GetColor](class_tale_worlds_1_1_core_1_1_banner_manager.html#a0ffc8c06d0ddbcdc2dc2fe0cb76a79b5) (int id) |
| static int | [GetColorId](class_tale_worlds_1_1_core_1_1_banner_manager.html#a9005566ab1b517d926de338d07352763) (UInt32 color) |

|  |  |
| --- | --- |
| Public Attributes | |
| MBReadOnlyDictionary< int, [BannerColor](struct_tale_worlds_1_1_core_1_1_banner_color.html) > | [ReadOnlyColorPalette](class_tale_worlds_1_1_core_1_1_banner_manager.html#a8aae71c2cef98ad3f293fe5cafb77ed7) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const int | [DarkRed](class_tale_worlds_1_1_core_1_1_banner_manager.html#a800f93fb40fc751055c6ca65138ecd34) = 1 |
| const int | [Green](class_tale_worlds_1_1_core_1_1_banner_manager.html#ad83872364ba3086fa9748006f5a212e6) = 120 |
| const int | [Blue](class_tale_worlds_1_1_core_1_1_banner_manager.html#a09e3f754d04c167d56515c7c6927db4f) = 119 |
| const int | [Purple](class_tale_worlds_1_1_core_1_1_banner_manager.html#ab1f9dd104c9e6f9404a361523f3716e4) = 4 |
| const int | [DarkPurple](class_tale_worlds_1_1_core_1_1_banner_manager.html#ab0c581b3fb83f774318349eed7cbcc7c) = 6 |
| const int | [Orange](class_tale_worlds_1_1_core_1_1_banner_manager.html#a6baf67b65d4cd6b9eabc3deafd6244d9) = 9 |
| const int | [DarkBlue](class_tale_worlds_1_1_core_1_1_banner_manager.html#aaea55b0829c4f62fd5496ee0eef70cc5) = 12 |
| const int | [Red](class_tale_worlds_1_1_core_1_1_banner_manager.html#a98f5b60d2a76686e5bb15017bfeeb9d3) = 118 |
| const int | [Yellow](class_tale_worlds_1_1_core_1_1_banner_manager.html#a7c4cb53b1b444f63cc6d49c877fd6554) = 121 |

|  |  |
| --- | --- |
| Properties | |
| static BannerManager | [Instance](class_tale_worlds_1_1_core_1_1_banner_manager.html#a2c566c6590b756d8c83ae45c0919b1cc) `[get]` |
| MBReadOnlyList< [BannerIconGroup](class_tale_worlds_1_1_core_1_1_banner_icon_group.html) > | [BannerIconGroups](class_tale_worlds_1_1_core_1_1_banner_manager.html#a8a0f0f44dc1e84f44ac2683af2ae10f4) `[get]` |
| int | [BaseBackgroundId](class_tale_worlds_1_1_core_1_1_banner_manager.html#adc984bf732b1e42618fc4dc5734b006e) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_banner_manager.html#ac3c3272b24238bdd6ec0384919e9a749)Initialize()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Core.BannerManager.Initialize | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_banner_manager.html#ab05b05bd7aed4eb91d2b79b3c4fc0521)ResetAndLoad()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Core.BannerManager.ResetAndLoad | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_banner_manager.html#a0ffc8c06d0ddbcdc2dc2fe0cb76a79b5)GetColor()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | UInt32 TaleWorlds.Core.BannerManager.GetColor | ( | int | *id* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_banner_manager.html#a9005566ab1b517d926de338d07352763)GetColorId()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.Core.BannerManager.GetColorId | ( | UInt32 | *color* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_banner_manager.html#a03637877ed5ce95bc49ef47e1a030efe)GetRandomColorId()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.Core.BannerManager.GetRandomColorId | ( | [MBFastRandom](class_tale_worlds_1_1_core_1_1_m_b_fast_random.html) | *random* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_banner_manager.html#a72781f917df3d6afb4574e43763b9af3)GetIconDataFromIconId()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [BannerIconData](struct_tale_worlds_1_1_core_1_1_banner_icon_data.html) TaleWorlds.Core.BannerManager.GetIconDataFromIconId | ( | int | *id* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_banner_manager.html#abc6b21804c1365ab6d479a4110c7b48a)GetRandomBackgroundId()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.Core.BannerManager.GetRandomBackgroundId | ( | [MBFastRandom](class_tale_worlds_1_1_core_1_1_m_b_fast_random.html) | *random* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_banner_manager.html#a36cfc761d406e1f0af4de52e32f80b19)GetRandomBannerIconId()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.Core.BannerManager.GetRandomBannerIconId | ( | [MBFastRandom](class_tale_worlds_1_1_core_1_1_m_b_fast_random.html) | *random* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_banner_manager.html#aa77ba3f9603ce81f86723a1a3c79002a)GetBackgroundMeshName()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| string TaleWorlds.Core.BannerManager.GetBackgroundMeshName | ( | int | *id* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_banner_manager.html#abcd06ae6e93e3510ec15a08e7a8e7933)GetIconSourceTextureName()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| string TaleWorlds.Core.BannerManager.GetIconSourceTextureName | ( | int | *id* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_banner_manager.html#a606bfadf76e74275a1b8fed203407f96)SetBaseBackgroundId()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.BannerManager.SetBaseBackgroundId | ( | int | *id* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_banner_manager.html#a140082633745f9b91862ab81f3adaab7)SetCultureColors()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.BannerManager.SetCultureColors | ( | [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) | *culture*, |
|  |  | List< [BannerColor](struct_tale_worlds_1_1_core_1_1_banner_color.html) > | *color* ) |

[◆](class_tale_worlds_1_1_core_1_1_banner_manager.html#a5b7ff0b848a52fca498662d5d3b69f6b)LoadBannerIcons() [1/2]
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.BannerManager.LoadBannerIcons | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_banner_manager.html#a1ceac7bcc56a604fb75d33f8b8ccc39b)LoadBannerIcons() [2/2]
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.BannerManager.LoadBannerIcons | ( | string | *xmlPath* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_core_1_1_banner_manager.html#a800f93fb40fc751055c6ca65138ecd34)DarkRed
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.Core.BannerManager.DarkRed = 1 | | static |

[◆](class_tale_worlds_1_1_core_1_1_banner_manager.html#ad83872364ba3086fa9748006f5a212e6)Green
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.Core.BannerManager.Green = 120 | | static |

[◆](class_tale_worlds_1_1_core_1_1_banner_manager.html#a09e3f754d04c167d56515c7c6927db4f)Blue
---------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.Core.BannerManager.Blue = 119 | | static |

[◆](class_tale_worlds_1_1_core_1_1_banner_manager.html#ab1f9dd104c9e6f9404a361523f3716e4)Purple
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.Core.BannerManager.Purple = 4 | | static |

[◆](class_tale_worlds_1_1_core_1_1_banner_manager.html#ab0c581b3fb83f774318349eed7cbcc7c)DarkPurple
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.Core.BannerManager.DarkPurple = 6 | | static |

[◆](class_tale_worlds_1_1_core_1_1_banner_manager.html#a6baf67b65d4cd6b9eabc3deafd6244d9)Orange
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.Core.BannerManager.Orange = 9 | | static |

[◆](class_tale_worlds_1_1_core_1_1_banner_manager.html#aaea55b0829c4f62fd5496ee0eef70cc5)DarkBlue
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.Core.BannerManager.DarkBlue = 12 | | static |

[◆](class_tale_worlds_1_1_core_1_1_banner_manager.html#a98f5b60d2a76686e5bb15017bfeeb9d3)Red
--------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.Core.BannerManager.Red = 118 | | static |

[◆](class_tale_worlds_1_1_core_1_1_banner_manager.html#a7c4cb53b1b444f63cc6d49c877fd6554)Yellow
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.Core.BannerManager.Yellow = 121 | | static |

[◆](class_tale_worlds_1_1_core_1_1_banner_manager.html#a8aae71c2cef98ad3f293fe5cafb77ed7)ReadOnlyColorPalette
-------------------------------------------------------------------------------------------------------------

|  |
| --- |
| MBReadOnlyDictionary<int, [BannerColor](struct_tale_worlds_1_1_core_1_1_banner_color.html)> TaleWorlds.Core.BannerManager.ReadOnlyColorPalette |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_banner_manager.html#a2c566c6590b756d8c83ae45c0919b1cc)Instance
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | BannerManager TaleWorlds.Core.BannerManager.Instance | | staticget |

[◆](class_tale_worlds_1_1_core_1_1_banner_manager.html#a8a0f0f44dc1e84f44ac2683af2ae10f4)BannerIconGroups
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[BannerIconGroup](class_tale_worlds_1_1_core_1_1_banner_icon_group.html)> TaleWorlds.Core.BannerManager.BannerIconGroups | | get |

[◆](class_tale_worlds_1_1_core_1_1_banner_manager.html#adc984bf732b1e42618fc4dc5734b006e)BaseBackgroundId
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.BannerManager.BaseBackgroundId | | get |

