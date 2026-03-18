--- SOURCE: class_tale_worlds_1_1_core_1_1_banner.html ---

TaleWorlds.Core.Banner Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [Banner](class_tale_worlds_1_1_core_1_1_banner.html#a5fbd6747d1f0940c61fd0380d6a8430b) () |
|  | [Banner](class_tale_worlds_1_1_core_1_1_banner.html#ab15800f5f8e8ef2197ec8f49cbe542f8) (Banner banner) |
|  | [Banner](class_tale_worlds_1_1_core_1_1_banner.html#a2dffc67ce2a839d2bb68a8d4e4cb6e69) (Banner banner, uint color1, uint color2) |
|  | [Banner](class_tale_worlds_1_1_core_1_1_banner.html#a88223c9ff60dd1b0628302fcfeb2d51c) (string bannerKey) |
|  | [Banner](class_tale_worlds_1_1_core_1_1_banner.html#a020842319fd5efc54961565284be5f0c) (string bannerKey, uint color1, uint color2) |
| void | [SetBannerVisual](class_tale_worlds_1_1_core_1_1_banner.html#a66181d86061dda60009d9e861b92b265) ([IBannerVisual](interface_tale_worlds_1_1_core_1_1_i_banner_visual.html) visual) |
| [BannerData](class_tale_worlds_1_1_core_1_1_banner_data.html) | [GetBannerDataAtIndex](class_tale_worlds_1_1_core_1_1_banner.html#a3a31ba7027f553c1eb3c828cb9eaa905) (int index) |
| int | [GetBannerDataListCount](class_tale_worlds_1_1_core_1_1_banner.html#a7eea36c6c742ffb1aaf52136de29e8f8) () |
| bool | [IsBannerDataListEmpty](class_tale_worlds_1_1_core_1_1_banner.html#ae4d79a9fcf0e06fd4eae1e98398453c3) () |
| int | [GetPrimaryColorId](class_tale_worlds_1_1_core_1_1_banner.html#a0d22dd924334f321240d7135ead6c83a) () |
| int | [GetSecondaryColorId](class_tale_worlds_1_1_core_1_1_banner.html#adae848c39a9fa00239638926774cfe72) () |
| int | [GetIconColorId](class_tale_worlds_1_1_core_1_1_banner.html#ac7f5ad49b3170f40982a35dd5b40ab40) () |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetIconSize](class_tale_worlds_1_1_core_1_1_banner.html#a38fd0f6f77481dd0a21277e196cb6534) () |
| void | [SetPrimaryColorId](class_tale_worlds_1_1_core_1_1_banner.html#a8b6e7cd15d3ab900cfba7aec44d54ccb) (int colorId) |
| void | [SetSecondaryColorId](class_tale_worlds_1_1_core_1_1_banner.html#a8fcf097fbb58693b9f86ef7c0b49460f) (int colorId) |
| void | [SetIconColorId](class_tale_worlds_1_1_core_1_1_banner.html#a777c38358be061309da9e9dcbddc34b0) (int colorId) |
| void | [SetIconSize](class_tale_worlds_1_1_core_1_1_banner.html#aec3b39e329c7843816503bad83461a41) (int newSize) |
| void | [ChangePrimaryColor](class_tale_worlds_1_1_core_1_1_banner.html#a1a3986521b527e4f83445d309af64bf6) (UInt32 mainColor) |
| void | [ChangeBackgroundColor](class_tale_worlds_1_1_core_1_1_banner.html#a0f362076c2ac55e431f61e1a5c8073fb) (UInt32 primaryColor, UInt32 secondaryColor) |
| void | [ChangeIconColors](class_tale_worlds_1_1_core_1_1_banner.html#ae4988b96fad1d65b4f075fc12a1fbd66) (UInt32 color) |
| void | [RotateBackgroundToRight](class_tale_worlds_1_1_core_1_1_banner.html#ab4b6238ae6323ee0f2f8ad2af775eabb) () |
| void | [RotateBackgroundToLeft](class_tale_worlds_1_1_core_1_1_banner.html#a40338fb9260e62c206f59769b5b63bb6) () |
| int | [GetBackgroundMeshId](class_tale_worlds_1_1_core_1_1_banner.html#aa25587f524e36c875462d94ce7d544dd) () |
| int | [GetIconMeshId](class_tale_worlds_1_1_core_1_1_banner.html#a1ed4784a4caf2e8fd23dcf93f844c58c) () |
| void | [SetBackgroundMeshId](class_tale_worlds_1_1_core_1_1_banner.html#a57a404107e9972f0a17be38cb3e34199) (int meshId) |
| void | [SetIconMeshId](class_tale_worlds_1_1_core_1_1_banner.html#a43ab8badd58233c019af0e2067aada7d) (int meshId) |
| string | [Serialize](class_tale_worlds_1_1_core_1_1_banner.html#a270f9182249d3e079d404696cf4755cd) () |
| void | [Deserialize](class_tale_worlds_1_1_core_1_1_banner.html#a6fbe53249c9d0b4afa00b8c35c1a0bc9) (string message) |
| void | [ClearAllIcons](class_tale_worlds_1_1_core_1_1_banner.html#a0016cea53442ead8a7636121d8a4d166) () |
| void | [AddIconData](class_tale_worlds_1_1_core_1_1_banner.html#a09e1d70ab78066c83723e96ebf43cd50) ([BannerData](class_tale_worlds_1_1_core_1_1_banner_data.html) iconData) |
| void | [AddIconData](class_tale_worlds_1_1_core_1_1_banner.html#a73a1e19fb475d77bc44061ee2617f491) ([BannerData](class_tale_worlds_1_1_core_1_1_banner_data.html) iconData, int index) |
| void | [RemoveIconDataAtIndex](class_tale_worlds_1_1_core_1_1_banner.html#a2bccb15350c7eeba32185c3e09ccb36e) (int index) |
| uint | [GetPrimaryColor](class_tale_worlds_1_1_core_1_1_banner.html#ae6262b2f9dbdac858d54460cab8364d6) () |
| uint | [GetSecondaryColor](class_tale_worlds_1_1_core_1_1_banner.html#aa40fc3167e6cff53dd14f88dd4511f24) () |
| uint | [GetFirstIconColor](class_tale_worlds_1_1_core_1_1_banner.html#a45573612a343d878c9b854065b43678f) () |
| int | [GetVersionNo](class_tale_worlds_1_1_core_1_1_banner.html#a0acf60e481442f6752ab09a9e589813d) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [Banner](class_tale_worlds_1_1_core_1_1_banner.html#a5fbd6747d1f0940c61fd0380d6a8430b) | [CreateRandomClanBanner](class_tale_worlds_1_1_core_1_1_banner.html#a7f553d8e169d9fe1cb6a3d92e1a0ef6a) (int seed=-1) |
| static [Banner](class_tale_worlds_1_1_core_1_1_banner.html#a5fbd6747d1f0940c61fd0380d6a8430b) | [CreateRandomBanner](class_tale_worlds_1_1_core_1_1_banner.html#ac39c3e71ccaa3fc5a8c50458f0e09a8e) () |
| static [Banner](class_tale_worlds_1_1_core_1_1_banner.html#a5fbd6747d1f0940c61fd0380d6a8430b) | [CreateOneColoredEmptyBanner](class_tale_worlds_1_1_core_1_1_banner.html#a9d29b5ff5c8cc9545c6dcd0bcc12c7ed) (int colorIndex) |
| static [Banner](class_tale_worlds_1_1_core_1_1_banner.html#a5fbd6747d1f0940c61fd0380d6a8430b) | [CreateOneColoredBannerWithOneIcon](class_tale_worlds_1_1_core_1_1_banner.html#a4cc89423358dac48ce572d27631a60fe) (uint backgroundColor, uint iconColor, int iconMeshId) |
| static string | [GetBannerCodeFromBannerDataList](class_tale_worlds_1_1_core_1_1_banner.html#a7b27592e102f6706b737ad1527f019a8) (MBList< [BannerData](class_tale_worlds_1_1_core_1_1_banner_data.html) > bannerDataList) |
| static bool | [IsValidBannerCode](class_tale_worlds_1_1_core_1_1_banner.html#af7b0031e611b916fbbf8df3e098a2037) (string bannerCode) |
| static bool | [TryGetBannerDataFromCode](class_tale_worlds_1_1_core_1_1_banner.html#a50aabf8205de0cb6a90a4b79232c8a76) (string bannerCode, out List< [BannerData](class_tale_worlds_1_1_core_1_1_banner_data.html) > bannerDataList) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const int | [MaxSize](class_tale_worlds_1_1_core_1_1_banner.html#a811cc5e35dc58567f13941dee47b2185) = 8000 |
| const int | [BannerFullSize](class_tale_worlds_1_1_core_1_1_banner.html#a7e7c26329ee04b3a6e01310ad8c4b833) = 1528 |
| const int | [BannerEditableAreaSize](class_tale_worlds_1_1_core_1_1_banner.html#ad2ea8f6667a284cfe979b89edb3b8fce) = 512 |
| const int | [MaxIconCount](class_tale_worlds_1_1_core_1_1_banner.html#a02b3a58004f311623ea739377dc7a12b) = 32 |
| const int | [BackgroundDataIndex](class_tale_worlds_1_1_core_1_1_banner.html#acdd3abdd08081d44a6cae08384f06864) = 0 |
| const int | [BannerIconDataIndex](class_tale_worlds_1_1_core_1_1_banner.html#a114a96c4f1b3b487b83781f991e2f341) = 1 |

|  |  |
| --- | --- |
| Properties | |
| string | [BannerCode](class_tale_worlds_1_1_core_1_1_banner.html#a1e00a2ed70be585b801cdda59b9f9a10) `[get]` |
| MBReadOnlyList< [BannerData](class_tale_worlds_1_1_core_1_1_banner_data.html) > | [BannerDataList](class_tale_worlds_1_1_core_1_1_banner.html#a408e803714c8f0875401b9a39e886759) `[get]` |
| [IBannerVisual](interface_tale_worlds_1_1_core_1_1_i_banner_visual.html) | [BannerVisual](class_tale_worlds_1_1_core_1_1_banner.html#a99517337a200438a593c574718709e10) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_core_1_1_banner.html#a5fbd6747d1f0940c61fd0380d6a8430b)Banner() [1/5]
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Core.Banner.Banner | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#ab15800f5f8e8ef2197ec8f49cbe542f8)Banner() [2/5]
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Core.Banner.Banner | ( | Banner | *banner* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#a2dffc67ce2a839d2bb68a8d4e4cb6e69)Banner() [3/5]
-----------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Core.Banner.Banner | ( | Banner | *banner*, |
|  |  | uint | *color1*, |
|  |  | uint | *color2* ) |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#a88223c9ff60dd1b0628302fcfeb2d51c)Banner() [4/5]
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Core.Banner.Banner | ( | string | *bannerKey* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#a020842319fd5efc54961565284be5f0c)Banner() [5/5]
-----------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Core.Banner.Banner | ( | string | *bannerKey*, |
|  |  | uint | *color1*, |
|  |  | uint | *color2* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_banner.html#a66181d86061dda60009d9e861b92b265)SetBannerVisual()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.Banner.SetBannerVisual | ( | [IBannerVisual](interface_tale_worlds_1_1_core_1_1_i_banner_visual.html) | *visual* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#a3a31ba7027f553c1eb3c828cb9eaa905)GetBannerDataAtIndex()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [BannerData](class_tale_worlds_1_1_core_1_1_banner_data.html) TaleWorlds.Core.Banner.GetBannerDataAtIndex | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#a7eea36c6c742ffb1aaf52136de29e8f8)GetBannerDataListCount()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.Core.Banner.GetBannerDataListCount | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#ae4d79a9fcf0e06fd4eae1e98398453c3)IsBannerDataListEmpty()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Core.Banner.IsBannerDataListEmpty | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#a0d22dd924334f321240d7135ead6c83a)GetPrimaryColorId()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.Core.Banner.GetPrimaryColorId | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#adae848c39a9fa00239638926774cfe72)GetSecondaryColorId()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.Core.Banner.GetSecondaryColorId | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#ac7f5ad49b3170f40982a35dd5b40ab40)GetIconColorId()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.Core.Banner.GetIconColorId | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#a38fd0f6f77481dd0a21277e196cb6534)GetIconSize()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.Core.Banner.GetIconSize | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#a8b6e7cd15d3ab900cfba7aec44d54ccb)SetPrimaryColorId()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.Banner.SetPrimaryColorId | ( | int | *colorId* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#a8fcf097fbb58693b9f86ef7c0b49460f)SetSecondaryColorId()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.Banner.SetSecondaryColorId | ( | int | *colorId* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#a777c38358be061309da9e9dcbddc34b0)SetIconColorId()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.Banner.SetIconColorId | ( | int | *colorId* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#aec3b39e329c7843816503bad83461a41)SetIconSize()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.Banner.SetIconSize | ( | int | *newSize* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#a1a3986521b527e4f83445d309af64bf6)ChangePrimaryColor()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.Banner.ChangePrimaryColor | ( | UInt32 | *mainColor* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#a0f362076c2ac55e431f61e1a5c8073fb)ChangeBackgroundColor()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.Banner.ChangeBackgroundColor | ( | UInt32 | *primaryColor*, |
|  |  | UInt32 | *secondaryColor* ) |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#ae4988b96fad1d65b4f075fc12a1fbd66)ChangeIconColors()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.Banner.ChangeIconColors | ( | UInt32 | *color* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#ab4b6238ae6323ee0f2f8ad2af775eabb)RotateBackgroundToRight()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.Banner.RotateBackgroundToRight | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#a40338fb9260e62c206f59769b5b63bb6)RotateBackgroundToLeft()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.Banner.RotateBackgroundToLeft | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#aa25587f524e36c875462d94ce7d544dd)GetBackgroundMeshId()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.Core.Banner.GetBackgroundMeshId | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#a1ed4784a4caf2e8fd23dcf93f844c58c)GetIconMeshId()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.Core.Banner.GetIconMeshId | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#a57a404107e9972f0a17be38cb3e34199)SetBackgroundMeshId()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.Banner.SetBackgroundMeshId | ( | int | *meshId* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#a43ab8badd58233c019af0e2067aada7d)SetIconMeshId()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.Banner.SetIconMeshId | ( | int | *meshId* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#a270f9182249d3e079d404696cf4755cd)Serialize()
--------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.Core.Banner.Serialize | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#a6fbe53249c9d0b4afa00b8c35c1a0bc9)Deserialize()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.Banner.Deserialize | ( | string | *message* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#a0016cea53442ead8a7636121d8a4d166)ClearAllIcons()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.Banner.ClearAllIcons | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#a09e1d70ab78066c83723e96ebf43cd50)AddIconData() [1/2]
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.Banner.AddIconData | ( | [BannerData](class_tale_worlds_1_1_core_1_1_banner_data.html) | *iconData* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#a73a1e19fb475d77bc44061ee2617f491)AddIconData() [2/2]
----------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.Banner.AddIconData | ( | [BannerData](class_tale_worlds_1_1_core_1_1_banner_data.html) | *iconData*, |
|  |  | int | *index* ) |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#a2bccb15350c7eeba32185c3e09ccb36e)RemoveIconDataAtIndex()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.Banner.RemoveIconDataAtIndex | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#a7f553d8e169d9fe1cb6a3d92e1a0ef6a)CreateRandomClanBanner()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Banner](class_tale_worlds_1_1_core_1_1_banner.html#a5fbd6747d1f0940c61fd0380d6a8430b) TaleWorlds.Core.Banner.CreateRandomClanBanner | ( | int | *seed* = -1 | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#ac39c3e71ccaa3fc5a8c50458f0e09a8e)CreateRandomBanner()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [Banner](class_tale_worlds_1_1_core_1_1_banner.html#a5fbd6747d1f0940c61fd0380d6a8430b) TaleWorlds.Core.Banner.CreateRandomBanner | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#a9d29b5ff5c8cc9545c6dcd0bcc12c7ed)CreateOneColoredEmptyBanner()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Banner](class_tale_worlds_1_1_core_1_1_banner.html#a5fbd6747d1f0940c61fd0380d6a8430b) TaleWorlds.Core.Banner.CreateOneColoredEmptyBanner | ( | int | *colorIndex* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#a4cc89423358dac48ce572d27631a60fe)CreateOneColoredBannerWithOneIcon()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Banner](class_tale_worlds_1_1_core_1_1_banner.html#a5fbd6747d1f0940c61fd0380d6a8430b) TaleWorlds.Core.Banner.CreateOneColoredBannerWithOneIcon | ( | uint | *backgroundColor*, | |  |  | uint | *iconColor*, | |  |  | int | *iconMeshId* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#ae6262b2f9dbdac858d54460cab8364d6)GetPrimaryColor()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| uint TaleWorlds.Core.Banner.GetPrimaryColor | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#aa40fc3167e6cff53dd14f88dd4511f24)GetSecondaryColor()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| uint TaleWorlds.Core.Banner.GetSecondaryColor | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#a45573612a343d878c9b854065b43678f)GetFirstIconColor()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| uint TaleWorlds.Core.Banner.GetFirstIconColor | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#a0acf60e481442f6752ab09a9e589813d)GetVersionNo()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.Core.Banner.GetVersionNo | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#a7b27592e102f6706b737ad1527f019a8)GetBannerCodeFromBannerDataList()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.Core.Banner.GetBannerCodeFromBannerDataList | ( | MBList< [BannerData](class_tale_worlds_1_1_core_1_1_banner_data.html) > | *bannerDataList* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#af7b0031e611b916fbbf8df3e098a2037)IsValidBannerCode()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Core.Banner.IsValidBannerCode | ( | string | *bannerCode* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#a50aabf8205de0cb6a90a4b79232c8a76)TryGetBannerDataFromCode()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Core.Banner.TryGetBannerDataFromCode | ( | string | *bannerCode*, | |  |  | out List< [BannerData](class_tale_worlds_1_1_core_1_1_banner_data.html) > | *bannerDataList* ) | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_core_1_1_banner.html#a811cc5e35dc58567f13941dee47b2185)MaxSize
----------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.Core.Banner.MaxSize = 8000 | | static |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#a7e7c26329ee04b3a6e01310ad8c4b833)BannerFullSize
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.Core.Banner.BannerFullSize = 1528 | | static |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#ad2ea8f6667a284cfe979b89edb3b8fce)BannerEditableAreaSize
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.Core.Banner.BannerEditableAreaSize = 512 | | static |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#a02b3a58004f311623ea739377dc7a12b)MaxIconCount
---------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.Core.Banner.MaxIconCount = 32 | | static |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#acdd3abdd08081d44a6cae08384f06864)BackgroundDataIndex
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.Core.Banner.BackgroundDataIndex = 0 | | static |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#a114a96c4f1b3b487b83781f991e2f341)BannerIconDataIndex
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.Core.Banner.BannerIconDataIndex = 1 | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_banner.html#a1e00a2ed70be585b801cdda59b9f9a10)BannerCode
-------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.Banner.BannerCode | | get |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#a408e803714c8f0875401b9a39e886759)BannerDataList
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[BannerData](class_tale_worlds_1_1_core_1_1_banner_data.html)> TaleWorlds.Core.Banner.BannerDataList | | get |

[◆](class_tale_worlds_1_1_core_1_1_banner.html#a99517337a200438a593c574718709e10)BannerVisual
---------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IBannerVisual](interface_tale_worlds_1_1_core_1_1_i_banner_visual.html) TaleWorlds.Core.Banner.BannerVisual | | get |

