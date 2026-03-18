--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_crafting_piece_thumbnail_cache.html ---

TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.CraftingPieceThumbnailCache Class ReferenceInherits [TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.ThumbnailCache< T >](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [CraftingPieceThumbnailCache](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_crafting_piece_thumbnail_cache.html#ae439ec8bd360e4d661006395d086cd4c) (int capacity) |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.ThumbnailCache< T >](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html) | |
|  | [ThumbnailCache](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#a5af704db84931d262883fe35801d5f42) (int capacity) |
| [TextureCreationInfo](struct_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_texture_creation_info.html) | [CreateTexture](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#a06d7b9ba924cd4d5151fe8f688196ba1) ([ThumbnailCreationData](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_creation_data.html) thumbnailCreationData) |
| bool | [ReleaseTexture](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#af2a8f5e81a0e5618e2a49fb16f6fa987) ([ThumbnailCreationData](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_creation_data.html) thumbnailCreationData) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnInitialize](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_crafting_piece_thumbnail_cache.html#a7decc0bbc24b5375a9eb54824d04ed96) () |
| override void | [OnFinalize](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_crafting_piece_thumbnail_cache.html#a19f1fab80314b716eb40314601beb63f) () |
| override [TextureCreationInfo](struct_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_texture_creation_info.html) | [OnCreateTexture](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_crafting_piece_thumbnail_cache.html#a3297869d5142b5338a4e4774770fbf2a) ([CraftingPieceCreationData](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_crafting_piece_creation_data.html) thumbnailCreationData) |
| override bool | [OnReleaseTexture](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_crafting_piece_thumbnail_cache.html#aaf3a766544f5310f368990c71b55dc53) ([CraftingPieceCreationData](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_crafting_piece_creation_data.html) thumbnailCreationData) |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.ThumbnailCache< T >](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html) | |
| virtual void | [OnTick](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#aead1c1b7101024a0e1cdf502168ed2a7) (float dt) |
| virtual void | [OnClear](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#a0ed3a3ceb979d40331072c2f55bf9bcd) () |
| virtual void | [OnImguiTick](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#acdd71c3e2f38d348bdad7425df6fa948) () |
| virtual void | [OnRequestCancelled](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#a5d40b304fd2996b7f4a6b937a4486c28) (string renderId) |
| [TextureCreationInfo](struct_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_texture_creation_info.html) | [OnCreateTexture](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#a6d92c900d14f2f8fc8b0fb8007809f84) (T thumbnailCreationData) |
| bool | [OnReleaseTexture](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#ab4b9353381ef8264a7a1378d5d4a84f9) (T thumbnailCreationData) |
| void | [RemoveThumbnailCacheNode](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#af966f9d82572b80a8dff10c4186701c5) ([ThumbnailCacheNode](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache_node.html) node, bool releaseTexture=true) |
| int | [GetTotalMemorySize](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#af6e0b26c931f7c136ef6966cf58c8716) () |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Protected Member Functions inherited from [TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.ThumbnailCache< T >](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html) | |
| static [Camera](class_tale_worlds_1_1_engine_1_1_camera.html) | [CreateCamera](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#a0695cc4bdc635bfb00decfb9da624ae1) (float left, float right, float bottom, float top, float near, float far) |
| static string | [CreateDebugIdFrom](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#af7553232b2a09e1d43acdd98fd1e5e59) (string renderId, string typeId, string additionalInfo="") |
| static string | [ByteWidthToString](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#af6be743c6687c6bb864ced5b9d41f214) (int bytes) |
| Protected Attributes inherited from [TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.ThumbnailCache< T >](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html) | |
| int | [\_capacity](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#abb0e4ea9d453350b563ea46bebe699dd) |
| [ThumbnailCreatorView](class_tale_worlds_1_1_engine_1_1_thumbnail_creator_view.html) | [\_thumbnailCreatorView](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#a1904a5fbde3812e2ba20b92e49cc280d) |
| Dictionary< string, [ThumbnailCacheNode](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache_node.html) > | [\_map](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#ad2814c997a63ab4fde8b6d556bde0c77) |
| [NodeComparer](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_node_comparer.html) | [\_nodeComparer](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#a8429a492c904002209ed22ab37ef09a7) = new [NodeComparer](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_node_comparer.html)() |
| Dictionary< string, [RenderCallbackCollection](struct_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_render_callback_collection.html) > | [\_renderCallbacks](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#adce969835b9805c8ea71f12bcfdeba06) |
| Properties inherited from [TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.ThumbnailCache< T >](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html) | |
| int | [Count](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#a0edbbb89e2e6a4c9137a6b7e07ea11cb) `[get]` |
| int | [RenderCallbackCount](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#adedb515d0cb24611cb3f91fc6598ea3a) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_crafting_piece_thumbnail_cache.html#ae439ec8bd360e4d661006395d086cd4c)CraftingPieceThumbnailCache()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.CraftingPieceThumbnailCache.CraftingPieceThumbnailCache | ( | int | *capacity* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_crafting_piece_thumbnail_cache.html#a7decc0bbc24b5375a9eb54824d04ed96)OnInitialize()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.CraftingPieceThumbnailCache.OnInitialize | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.ThumbnailCache< T >](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#af64a0fb455ca05a0e8fae6f90b367bd4).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_crafting_piece_thumbnail_cache.html#a19f1fab80314b716eb40314601beb63f)OnFinalize()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.CraftingPieceThumbnailCache.OnFinalize | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.ThumbnailCache< T >](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#a3107172ffeac7d250b18dd253909314c).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_crafting_piece_thumbnail_cache.html#a3297869d5142b5338a4e4774770fbf2a)OnCreateTexture()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override [TextureCreationInfo](struct_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_texture_creation_info.html) TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.CraftingPieceThumbnailCache.OnCreateTexture | ( | [CraftingPieceCreationData](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_crafting_piece_creation_data.html) | *thumbnailCreationData* | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_crafting_piece_thumbnail_cache.html#aaf3a766544f5310f368990c71b55dc53)OnReleaseTexture()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override bool TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.CraftingPieceThumbnailCache.OnReleaseTexture | ( | [CraftingPieceCreationData](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_crafting_piece_creation_data.html) | *thumbnailCreationData* | ) |  | | protected |

