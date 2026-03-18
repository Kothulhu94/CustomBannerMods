--- SOURCE: interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_i_thumbnail_cache.html ---

TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.IThumbnailCache Interface ReferenceInherited by [TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.ThumbnailCache< T >](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [Initialize](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_i_thumbnail_cache.html#a826fc9281fc8945abf2d3ad0aa1db00a) ([ThumbnailCreatorView](class_tale_worlds_1_1_engine_1_1_thumbnail_creator_view.html) thumnbailCreatorView) |
| void | [Destroy](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_i_thumbnail_cache.html#a962ac7d820c5c3b2dc3ead2589e8bddc) () |
| void | [Clear](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_i_thumbnail_cache.html#a7cd04aabbfce3797ed1674f684880e15) (bool releaseImmediately) |
| bool | [GetValue](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_i_thumbnail_cache.html#a634322525aa53a33228742231c0c1409) (string key, out [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) texture) |
| bool | [AddReference](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_i_thumbnail_cache.html#a6e80ad04fad4f90d4cf9e7a83d0c1cae) (string key) |
| bool | [RemoveReference](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_i_thumbnail_cache.html#a638cb3de99230b286be75058dc5ecf13) (string key) |
| bool | [OnThumbnailRenderCompleted](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_i_thumbnail_cache.html#a908c4d4df0d6addab36e262828b5e35c) (string renderId, [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) renderTarget) |
| void | [ClearUnusedCache](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_i_thumbnail_cache.html#a6324ddcd4e66dc53306c266c0efd3754) () |
| void | [Tick](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_i_thumbnail_cache.html#a46c48cc4b725f6e7dee30de5dc7cd182) (float dt) |
| void | [Add](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_i_thumbnail_cache.html#afafeb23316ea5bcb91f61238614a7807) (string key, [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) value) |
| void | [PrintToImgui](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_i_thumbnail_cache.html#a84c90cd9cc379824549cd09baa79bd9f) () |
| [TextureCreationInfo](struct_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_texture_creation_info.html) | [CreateTexture](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_i_thumbnail_cache.html#acc2d940ddea1ee455040471d6e6a2a36) ([ThumbnailCreationData](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_creation_data.html) thumbnailCreationData) |
| bool | [ReleaseTexture](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_i_thumbnail_cache.html#af810275bf9b7f45326ef0ebeda84f675) ([ThumbnailCreationData](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_creation_data.html) thumbnailCreationData) |

|  |  |
| --- | --- |
| Properties | |
| int | [Count](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_i_thumbnail_cache.html#a0ad9276e0fa6e667966a8ee03fa8eab2) `[get]` |
| int | [RenderCallbackCount](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_i_thumbnail_cache.html#a72a317987cd55f822bf58ebeef678363) `[get]` |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_i_thumbnail_cache.html#a826fc9281fc8945abf2d3ad0aa1db00a)Initialize()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.IThumbnailCache.Initialize | ( | [ThumbnailCreatorView](class_tale_worlds_1_1_engine_1_1_thumbnail_creator_view.html) | *thumnbailCreatorView* | ) |  |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_i_thumbnail_cache.html#a962ac7d820c5c3b2dc3ead2589e8bddc)Destroy()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.IThumbnailCache.Destroy | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_i_thumbnail_cache.html#a7cd04aabbfce3797ed1674f684880e15)Clear()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.IThumbnailCache.Clear | ( | bool | *releaseImmediately* | ) |  |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_i_thumbnail_cache.html#a634322525aa53a33228742231c0c1409)GetValue()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.IThumbnailCache.GetValue | ( | string | *key*, |
|  |  | out [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) | *texture* ) |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_i_thumbnail_cache.html#a6e80ad04fad4f90d4cf9e7a83d0c1cae)AddReference()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.IThumbnailCache.AddReference | ( | string | *key* | ) |  |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_i_thumbnail_cache.html#a638cb3de99230b286be75058dc5ecf13)RemoveReference()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.IThumbnailCache.RemoveReference | ( | string | *key* | ) |  |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_i_thumbnail_cache.html#a908c4d4df0d6addab36e262828b5e35c)OnThumbnailRenderCompleted()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.IThumbnailCache.OnThumbnailRenderCompleted | ( | string | *renderId*, |
|  |  | [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) | *renderTarget* ) |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_i_thumbnail_cache.html#a6324ddcd4e66dc53306c266c0efd3754)ClearUnusedCache()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.IThumbnailCache.ClearUnusedCache | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_i_thumbnail_cache.html#a46c48cc4b725f6e7dee30de5dc7cd182)Tick()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.IThumbnailCache.Tick | ( | float | *dt* | ) |  |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_i_thumbnail_cache.html#afafeb23316ea5bcb91f61238614a7807)Add()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.IThumbnailCache.Add | ( | string | *key*, |
|  |  | [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) | *value* ) |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_i_thumbnail_cache.html#a84c90cd9cc379824549cd09baa79bd9f)PrintToImgui()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.IThumbnailCache.PrintToImgui | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_i_thumbnail_cache.html#acc2d940ddea1ee455040471d6e6a2a36)CreateTexture()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [TextureCreationInfo](struct_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_texture_creation_info.html) TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.IThumbnailCache.CreateTexture | ( | [ThumbnailCreationData](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_creation_data.html) | *thumbnailCreationData* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.ThumbnailCache< T >](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#a06d7b9ba924cd4d5151fe8f688196ba1).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_i_thumbnail_cache.html#af810275bf9b7f45326ef0ebeda84f675)ReleaseTexture()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.IThumbnailCache.ReleaseTexture | ( | [ThumbnailCreationData](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_creation_data.html) | *thumbnailCreationData* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.ThumbnailCache< T >](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#af2a8f5e81a0e5618e2a49fb16f6fa987).

Property Documentation
----------------------

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_i_thumbnail_cache.html#a0ad9276e0fa6e667966a8ee03fa8eab2)Count
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.IThumbnailCache.Count | | get |

Implemented in [TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.ThumbnailCache< T >](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#a0edbbb89e2e6a4c9137a6b7e07ea11cb).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_i_thumbnail_cache.html#a72a317987cd55f822bf58ebeef678363)RenderCallbackCount
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.IThumbnailCache.RenderCallbackCount | | get |

Implemented in [TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.ThumbnailCache< T >](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#adedb515d0cb24611cb3f91fc6598ea3a).

