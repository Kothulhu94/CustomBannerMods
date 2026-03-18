--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html ---

TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.ThumbnailCache< T > Class Template ReferenceabstractInherits [TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.IThumbnailCache](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_i_thumbnail_cache.html).

Inherited by [TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.AvatarThumbnailCache](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_avatar_thumbnail_cache.html), [TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.BannerEditorTextureCache](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_banner_editor_texture_cache.html), [TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.BannerPersistentTextureCache](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_banner_persistent_texture_cache.html), [TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.BannerThumbnailCache](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_banner_thumbnail_cache.html), [TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.CharacterThumbnailCache](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_character_thumbnail_cache.html), [TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.CraftingPieceThumbnailCache](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_crafting_piece_thumbnail_cache.html), and [TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.ItemThumbnailCache](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_item_thumbnail_cache.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ThumbnailCache](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#a5af704db84931d262883fe35801d5f42) (int capacity) |
| [TextureCreationInfo](struct_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_texture_creation_info.html) | [CreateTexture](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#a06d7b9ba924cd4d5151fe8f688196ba1) ([ThumbnailCreationData](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_creation_data.html) thumbnailCreationData) |
| bool | [ReleaseTexture](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#af2a8f5e81a0e5618e2a49fb16f6fa987) ([ThumbnailCreationData](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_creation_data.html) thumbnailCreationData) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| virtual void | [OnInitialize](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#af64a0fb455ca05a0e8fae6f90b367bd4) () |
| virtual void | [OnFinalize](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#a3107172ffeac7d250b18dd253909314c) () |
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
| Static Protected Member Functions | |
| static [Camera](class_tale_worlds_1_1_engine_1_1_camera.html) | [CreateCamera](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#a0695cc4bdc635bfb00decfb9da624ae1) (float left, float right, float bottom, float top, float near, float far) |
| static string | [CreateDebugIdFrom](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#af7553232b2a09e1d43acdd98fd1e5e59) (string renderId, string typeId, string additionalInfo="") |
| static string | [ByteWidthToString](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#af6be743c6687c6bb864ced5b9d41f214) (int bytes) |

|  |  |
| --- | --- |
| Protected Attributes | |
| int | [\_capacity](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#abb0e4ea9d453350b563ea46bebe699dd) |
| [ThumbnailCreatorView](class_tale_worlds_1_1_engine_1_1_thumbnail_creator_view.html) | [\_thumbnailCreatorView](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#a1904a5fbde3812e2ba20b92e49cc280d) |
| Dictionary< string, [ThumbnailCacheNode](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache_node.html) > | [\_map](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#ad2814c997a63ab4fde8b6d556bde0c77) |
| [NodeComparer](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_node_comparer.html) | [\_nodeComparer](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#a8429a492c904002209ed22ab37ef09a7) = new [NodeComparer](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_node_comparer.html)() |
| Dictionary< string, [RenderCallbackCollection](struct_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_render_callback_collection.html) > | [\_renderCallbacks](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#adce969835b9805c8ea71f12bcfdeba06) |

|  |  |
| --- | --- |
| Properties | |
| int | [Count](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#a0edbbb89e2e6a4c9137a6b7e07ea11cb) `[get]` |
| int | [RenderCallbackCount](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#adedb515d0cb24611cb3f91fc6598ea3a) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#a5af704db84931d262883fe35801d5f42)ThumbnailCache()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.ThumbnailCache< T >.ThumbnailCache | ( | int | *capacity* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#af64a0fb455ca05a0e8fae6f90b367bd4)OnInitialize()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.ThumbnailCache< T >.OnInitialize | ( |  | ) |  | | protectedvirtual |

Reimplemented in [TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.BannerThumbnailCache](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_banner_thumbnail_cache.html#ab1249a2b391f68e0600ddc2d9f920e44), [TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.CharacterThumbnailCache](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_character_thumbnail_cache.html#a37e9fa89e347adb7335c3e3a1e731a9b), [TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.CraftingPieceThumbnailCache](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_crafting_piece_thumbnail_cache.html#a7decc0bbc24b5375a9eb54824d04ed96), and [TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.ItemThumbnailCache](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_item_thumbnail_cache.html#ac3eff08156548cb4b7440fcc5d6444bc).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#a3107172ffeac7d250b18dd253909314c)OnFinalize()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.ThumbnailCache< T >.OnFinalize | ( |  | ) |  | | protectedvirtual |

Reimplemented in [TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.AvatarThumbnailCache](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_avatar_thumbnail_cache.html#a3ea3ff0bfe370653e71653772ec3edb6), [TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.BannerEditorTextureCache](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_banner_editor_texture_cache.html#ac7f94c11cf926c5a665f40be5ff6f822), [TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.BannerPersistentTextureCache](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_banner_persistent_texture_cache.html#a3fd62fdf3bb351e1279f509f4c6140b3), [TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.BannerThumbnailCache](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_banner_thumbnail_cache.html#acfa43d21ddaccd52e429acc3cc240bb5), [TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.CharacterThumbnailCache](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_character_thumbnail_cache.html#a5f3aa18dc18f2850e899e3da7088f3a1), [TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.CraftingPieceThumbnailCache](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_crafting_piece_thumbnail_cache.html#a19f1fab80314b716eb40314601beb63f), and [TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.ItemThumbnailCache](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_item_thumbnail_cache.html#a3e49678f0e526c29b2fadaba4f0f5425).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#aead1c1b7101024a0e1cdf502168ed2a7)OnTick()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.ThumbnailCache< T >.OnTick | ( | float | *dt* | ) |  | | protectedvirtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#a0ed3a3ceb979d40331072c2f55bf9bcd)OnClear()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.ThumbnailCache< T >.OnClear | ( |  | ) |  | | protectedvirtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#acdd71c3e2f38d348bdad7425df6fa948)OnImguiTick()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.ThumbnailCache< T >.OnImguiTick | ( |  | ) |  | | protectedvirtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#a5d40b304fd2996b7f4a6b937a4486c28)OnRequestCancelled()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.ThumbnailCache< T >.OnRequestCancelled | ( | string | *renderId* | ) |  | | protectedvirtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#a6d92c900d14f2f8fc8b0fb8007809f84)OnCreateTexture()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [TextureCreationInfo](struct_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_texture_creation_info.html) TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.ThumbnailCache< T >.OnCreateTexture | ( | T | *thumbnailCreationData* | ) |  | | abstractprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#ab4b9353381ef8264a7a1378d5d4a84f9)OnReleaseTexture()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.ThumbnailCache< T >.OnReleaseTexture | ( | T | *thumbnailCreationData* | ) |  | | abstractprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#a06d7b9ba924cd4d5151fe8f688196ba1)CreateTexture()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [TextureCreationInfo](struct_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_texture_creation_info.html) TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.ThumbnailCache< T >.CreateTexture | ( | [ThumbnailCreationData](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_creation_data.html) | *thumbnailCreationData* | ) |  |

Implements [TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.IThumbnailCache](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_i_thumbnail_cache.html#acc2d940ddea1ee455040471d6e6a2a36).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#af2a8f5e81a0e5618e2a49fb16f6fa987)ReleaseTexture()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.ThumbnailCache< T >.ReleaseTexture | ( | [ThumbnailCreationData](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_creation_data.html) | *thumbnailCreationData* | ) |  |

Implements [TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.IThumbnailCache](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_i_thumbnail_cache.html#af810275bf9b7f45326ef0ebeda84f675).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#af966f9d82572b80a8dff10c4186701c5)RemoveThumbnailCacheNode()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.ThumbnailCache< T >.RemoveThumbnailCacheNode | ( | [ThumbnailCacheNode](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache_node.html) | *node*, | |  |  | bool | *releaseTexture* = true ) | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#a0695cc4bdc635bfb00decfb9da624ae1)CreateCamera()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Camera](class_tale_worlds_1_1_engine_1_1_camera.html) TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.ThumbnailCache< T >.CreateCamera | ( | float | *left*, | |  |  | float | *right*, | |  |  | float | *bottom*, | |  |  | float | *top*, | |  |  | float | *near*, | |  |  | float | *far* ) | | staticprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#af7553232b2a09e1d43acdd98fd1e5e59)CreateDebugIdFrom()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.ThumbnailCache< T >.CreateDebugIdFrom | ( | string | *renderId*, | |  |  | string | *typeId*, | |  |  | string | *additionalInfo* = "" ) | | staticprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#af6e0b26c931f7c136ef6966cf58c8716)GetTotalMemorySize()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.ThumbnailCache< T >.GetTotalMemorySize | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#af6be743c6687c6bb864ced5b9d41f214)ByteWidthToString()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.ThumbnailCache< T >.ByteWidthToString | ( | int | *bytes* | ) |  | | staticprotected |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#abb0e4ea9d453350b563ea46bebe699dd)\_capacity
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.ThumbnailCache< T >.\_capacity | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#a1904a5fbde3812e2ba20b92e49cc280d)\_thumbnailCreatorView
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ThumbnailCreatorView](class_tale_worlds_1_1_engine_1_1_thumbnail_creator_view.html) TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.ThumbnailCache< T >.\_thumbnailCreatorView | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#ad2814c997a63ab4fde8b6d556bde0c77)\_map
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Dictionary<string, [ThumbnailCacheNode](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache_node.html)> TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.ThumbnailCache< T >.\_map | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#a8429a492c904002209ed22ab37ef09a7)\_nodeComparer
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [NodeComparer](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_node_comparer.html) TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.ThumbnailCache< T >.\_nodeComparer = new [NodeComparer](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_node_comparer.html)() | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#adce969835b9805c8ea71f12bcfdeba06)\_renderCallbacks
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Dictionary<string, [RenderCallbackCollection](struct_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_render_callback_collection.html)> TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.ThumbnailCache< T >.\_renderCallbacks | | protected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#a0edbbb89e2e6a4c9137a6b7e07ea11cb)Count
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.ThumbnailCache< T >.Count | | get |

Implements [TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.IThumbnailCache](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_i_thumbnail_cache.html#a0ad9276e0fa6e667966a8ee03fa8eab2).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_cache-1-g.html#adedb515d0cb24611cb3f91fc6598ea3a)RenderCallbackCount
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.ThumbnailCache< T >.RenderCallbackCount | | get |

Implements [TaleWorlds.MountAndBlade.View.Tableaus.Thumbnails.IThumbnailCache](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_i_thumbnail_cache.html#a72a317987cd55f822bf58ebeef678363).

