--- SOURCE: class_tale_worlds_1_1_core_1_1_banner_data.html ---

TaleWorlds.Core.BannerData Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [BannerData](class_tale_worlds_1_1_core_1_1_banner_data.html#aeffbf0bdff8b58417a1b22d2b68bff05) (int meshId, int colorId, int colorId2, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) size, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position, bool drawStroke, bool mirror, float rotationValue) |
|  | [BannerData](class_tale_worlds_1_1_core_1_1_banner_data.html#a6b1b2d4e6226f7e6248d2dada689d6e2) (BannerData bannerData) |
| override bool | [Equals](class_tale_worlds_1_1_core_1_1_banner_data.html#a31778d141792ef61dacf90a568ce8ff3) (object obj) |
| override int | [GetHashCode](class_tale_worlds_1_1_core_1_1_banner_data.html#a8a39c6e5aecbbba4e06d056884f436a2) () |

|  |  |
| --- | --- |
| Public Attributes | |
| int | [\_colorId2](class_tale_worlds_1_1_core_1_1_banner_data.html#af03a285f3e81d27a35d94cf311e0d0e4) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [\_size](class_tale_worlds_1_1_core_1_1_banner_data.html#a7b58c052f9c254078f7bae6bd055c919) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [\_position](class_tale_worlds_1_1_core_1_1_banner_data.html#a9d4eae82fdf40f66fd8c4d9c736baa03) |
| bool | [\_drawStroke](class_tale_worlds_1_1_core_1_1_banner_data.html#aacf084d1c1bb62df57fc77390a692a85) |
| bool | [\_mirror](class_tale_worlds_1_1_core_1_1_banner_data.html#a6f9468088e005a7e86c42f8f3d4dd4a3) |
| float | [\_rotationValue](class_tale_worlds_1_1_core_1_1_banner_data.html#ac69ec613ecba14fa3d844d63e661909a) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const float | [RotationPrecision](class_tale_worlds_1_1_core_1_1_banner_data.html#add69abe7303c2fb49904abf70e32aedc) = 1f / 360f |

|  |  |
| --- | --- |
| Properties | |
| int | [LocalVersion](class_tale_worlds_1_1_core_1_1_banner_data.html#a0900d9d23a25c697e06097b9cdae22ac) `[get]` |
|  | Version number of the [BannerData](class_tale_worlds_1_1_core_1_1_banner_data.html). Gets incremented on every change. |
| int | [MeshId](class_tale_worlds_1_1_core_1_1_banner_data.html#ae0555b7ceca8a4e0135d07aafa3d6e50) `[get, set]` |
| int | [ColorId](class_tale_worlds_1_1_core_1_1_banner_data.html#aa3887ce9ed8e4975b88cc458302f2bae) `[get, set]` |
| int | [ColorId2](class_tale_worlds_1_1_core_1_1_banner_data.html#acb3d722f98f44fcf0f68d429cfa76e34) `[get, set]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [Size](class_tale_worlds_1_1_core_1_1_banner_data.html#ab6eeb5c9f64522321a23f00a9b5d5eb3) `[get, set]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [Position](class_tale_worlds_1_1_core_1_1_banner_data.html#a8118158ef23944fc4a4874eee1d36661) `[get, set]` |
| bool | [DrawStroke](class_tale_worlds_1_1_core_1_1_banner_data.html#a8e4592e781678d66aca90cc6d12a84d4) `[get, set]` |
| bool | [Mirror](class_tale_worlds_1_1_core_1_1_banner_data.html#af2de3364bd8f10191f9f8c9280b16070) `[get, set]` |
| float | [RotationValue](class_tale_worlds_1_1_core_1_1_banner_data.html#ab09120b95effb26bda8fa735fe075a85) `[get, set]` |
| float | [Rotation](class_tale_worlds_1_1_core_1_1_banner_data.html#afe6d423c0ef66d550e7d03f520dac0f1) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_core_1_1_banner_data.html#aeffbf0bdff8b58417a1b22d2b68bff05)BannerData() [1/2]
--------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Core.BannerData.BannerData | ( | int | *meshId*, |
|  |  | int | *colorId*, |
|  |  | int | *colorId2*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *size*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position*, |
|  |  | bool | *drawStroke*, |
|  |  | bool | *mirror*, |
|  |  | float | *rotationValue* ) |

[◆](class_tale_worlds_1_1_core_1_1_banner_data.html#a6b1b2d4e6226f7e6248d2dada689d6e2)BannerData() [2/2]
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Core.BannerData.BannerData | ( | BannerData | *bannerData* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_banner_data.html#a31778d141792ef61dacf90a568ce8ff3)Equals()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.Core.BannerData.Equals | ( | object | *obj* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_banner_data.html#a8a39c6e5aecbbba4e06d056884f436a2)GetHashCode()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.Core.BannerData.GetHashCode | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_core_1_1_banner_data.html#add69abe7303c2fb49904abf70e32aedc)RotationPrecision
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.Core.BannerData.RotationPrecision = 1f / 360f | | static |

[◆](class_tale_worlds_1_1_core_1_1_banner_data.html#af03a285f3e81d27a35d94cf311e0d0e4)\_colorId2
------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.Core.BannerData.\_colorId2 |

[◆](class_tale_worlds_1_1_core_1_1_banner_data.html#a7b58c052f9c254078f7bae6bd055c919)\_size
--------------------------------------------------------------------------------------------

|  |
| --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.Core.BannerData.\_size |

[◆](class_tale_worlds_1_1_core_1_1_banner_data.html#a9d4eae82fdf40f66fd8c4d9c736baa03)\_position
------------------------------------------------------------------------------------------------

|  |
| --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.Core.BannerData.\_position |

[◆](class_tale_worlds_1_1_core_1_1_banner_data.html#aacf084d1c1bb62df57fc77390a692a85)\_drawStroke
--------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.Core.BannerData.\_drawStroke |

[◆](class_tale_worlds_1_1_core_1_1_banner_data.html#a6f9468088e005a7e86c42f8f3d4dd4a3)\_mirror
----------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.Core.BannerData.\_mirror |

[◆](class_tale_worlds_1_1_core_1_1_banner_data.html#ac69ec613ecba14fa3d844d63e661909a)\_rotationValue
-----------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.Core.BannerData.\_rotationValue |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_banner_data.html#a0900d9d23a25c697e06097b9cdae22ac)LocalVersion
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.BannerData.LocalVersion | | get |

[◆](class_tale_worlds_1_1_core_1_1_banner_data.html#ae0555b7ceca8a4e0135d07aafa3d6e50)MeshId
--------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.BannerData.MeshId | | getset |

[◆](class_tale_worlds_1_1_core_1_1_banner_data.html#aa3887ce9ed8e4975b88cc458302f2bae)ColorId
---------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.BannerData.ColorId | | getset |

[◆](class_tale_worlds_1_1_core_1_1_banner_data.html#acb3d722f98f44fcf0f68d429cfa76e34)ColorId2
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.BannerData.ColorId2 | | getset |

[◆](class_tale_worlds_1_1_core_1_1_banner_data.html#ab6eeb5c9f64522321a23f00a9b5d5eb3)Size
------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.Core.BannerData.Size | | getset |

[◆](class_tale_worlds_1_1_core_1_1_banner_data.html#a8118158ef23944fc4a4874eee1d36661)Position
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.Core.BannerData.Position | | getset |

[◆](class_tale_worlds_1_1_core_1_1_banner_data.html#a8e4592e781678d66aca90cc6d12a84d4)DrawStroke
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.BannerData.DrawStroke | | getset |

[◆](class_tale_worlds_1_1_core_1_1_banner_data.html#af2de3364bd8f10191f9f8c9280b16070)Mirror
--------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.BannerData.Mirror | | getset |

[◆](class_tale_worlds_1_1_core_1_1_banner_data.html#ab09120b95effb26bda8fa735fe075a85)RotationValue
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.BannerData.RotationValue | | getset |

[◆](class_tale_worlds_1_1_core_1_1_banner_data.html#afe6d423c0ef66d550e7d03f520dac0f1)Rotation
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.BannerData.Rotation | | get |

