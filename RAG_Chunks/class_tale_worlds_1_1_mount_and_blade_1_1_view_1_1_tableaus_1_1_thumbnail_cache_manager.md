--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html ---

TaleWorlds.MountAndBlade.View.Tableaus.ThumbnailCacheManager Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
| bool | [IsCachedInventoryTableauSceneUsed](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#aacd868b27b71ba90a2aafdd8600e9ad7) () |
| [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | [GetCachedInventoryTableauScene](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#ab9ec609b41eca4669f743e3e979c4dde) () |
| void | [ReturnCachedInventoryTableauScene](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#aebb589b0ff0d618f808c00f2315506fc) () |
| bool | [IsCachedMapConversationTableauSceneUsed](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#a51bc39b06ee4c18b5f08650ead81e247) () |
| [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | [GetCachedMapConversationTableauScene](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#aa092d4a00fd1bfaccdbb466d15073536) () |
| void | [ReturnCachedMapConversationTableauScene](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#a7ea4750151d300d4123e8f616958f43a) () |
| void | [RegisterThumbnailCache](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#a30608520eafc983a7aa7ba1db521bff9) ([IThumbnailCache](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_i_thumbnail_cache.html) thumbnailCache) |
| void | [UnregisterThumbnailCache](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#a9baf5d6fe8cb8d18fe04e7c194ac70eb) ([IThumbnailCache](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_i_thumbnail_cache.html) thumbnailCache) |
| [TextureCreationInfo](struct_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_texture_creation_info.html) | [CreateTexture](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#ae7cc2f194d37970fef9a702d67b15143) ([ThumbnailCreationData](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_creation_data.html) thumbnailCreationData) |
| bool | [DestroyTexture](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#a19d995791ddf8d04ce8c172154a26de1) ([ThumbnailCreationData](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_creation_data.html) thumbnailCreationData) |
| void | [ForceClearAllCache](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#acb2b75e2f640ff9e88b7678e52617879) (bool releaseImmediately) |
|  | This clears any cached texture and textures that are being used at the moment. |
| [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) | [GetCachedHeroSilhouetteTexture](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#a41feb4fc81e51c169b138ce006c19878) () |
| void | [ClearUnusedCache](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#aabac761bcc92a8ba761403fcf5123a17) () |
| void | [Tick](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#ac150d39f9ff8dd882958ccf6c1f3c485) (float dt) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static int | [GetNumberOfPendingRequests](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#a931ef9fb820147935d98e383ee8cbf24) () |
| static bool | [IsNativeMemoryCleared](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#aacdc96336a2c698866873863901dde9b) () |
| static void | [InitializeManager](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#a1979786de8de10efa9054e3a38053ad5) () |
| static void | [InitializeSandboxValues](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#a8011f8426938d31be75869246ff062f7) () |
| static void | [ReleaseSandboxValues](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#a215b79b59ea013365b01aef04f7ddac7) () |
| static void | [ClearManager](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#adfab30cab096036d8076d17e09bd33b6) () |

|  |  |
| --- | --- |
| Properties | |
| static [ThumbnailCacheManager](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html) | [Current](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#ade1f27080f381425c71d77065568d0fe) `[get]` |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [InventorySceneCameraFrame](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#a253245c31c385a8de8c879983a87365c) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#aacd868b27b71ba90a2aafdd8600e9ad7)IsCachedInventoryTableauSceneUsed()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.View.Tableaus.ThumbnailCacheManager.IsCachedInventoryTableauSceneUsed | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#ab9ec609b41eca4669f743e3e979c4dde)GetCachedInventoryTableauScene()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) TaleWorlds.MountAndBlade.View.Tableaus.ThumbnailCacheManager.GetCachedInventoryTableauScene | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#aebb589b0ff0d618f808c00f2315506fc)ReturnCachedInventoryTableauScene()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Tableaus.ThumbnailCacheManager.ReturnCachedInventoryTableauScene | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#a51bc39b06ee4c18b5f08650ead81e247)IsCachedMapConversationTableauSceneUsed()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.View.Tableaus.ThumbnailCacheManager.IsCachedMapConversationTableauSceneUsed | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#aa092d4a00fd1bfaccdbb466d15073536)GetCachedMapConversationTableauScene()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) TaleWorlds.MountAndBlade.View.Tableaus.ThumbnailCacheManager.GetCachedMapConversationTableauScene | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#a7ea4750151d300d4123e8f616958f43a)ReturnCachedMapConversationTableauScene()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Tableaus.ThumbnailCacheManager.ReturnCachedMapConversationTableauScene | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#a931ef9fb820147935d98e383ee8cbf24)GetNumberOfPendingRequests()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.View.Tableaus.ThumbnailCacheManager.GetNumberOfPendingRequests | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#aacdc96336a2c698866873863901dde9b)IsNativeMemoryCleared()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.View.Tableaus.ThumbnailCacheManager.IsNativeMemoryCleared | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#a1979786de8de10efa9054e3a38053ad5)InitializeManager()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.View.Tableaus.ThumbnailCacheManager.InitializeManager | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#a30608520eafc983a7aa7ba1db521bff9)RegisterThumbnailCache()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Tableaus.ThumbnailCacheManager.RegisterThumbnailCache | ( | [IThumbnailCache](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_i_thumbnail_cache.html) | *thumbnailCache* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#a9baf5d6fe8cb8d18fe04e7c194ac70eb)UnregisterThumbnailCache()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Tableaus.ThumbnailCacheManager.UnregisterThumbnailCache | ( | [IThumbnailCache](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_i_thumbnail_cache.html) | *thumbnailCache* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#a8011f8426938d31be75869246ff062f7)InitializeSandboxValues()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.View.Tableaus.ThumbnailCacheManager.InitializeSandboxValues | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#a215b79b59ea013365b01aef04f7ddac7)ReleaseSandboxValues()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.View.Tableaus.ThumbnailCacheManager.ReleaseSandboxValues | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#adfab30cab096036d8076d17e09bd33b6)ClearManager()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.View.Tableaus.ThumbnailCacheManager.ClearManager | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#ae7cc2f194d37970fef9a702d67b15143)CreateTexture()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [TextureCreationInfo](struct_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_texture_creation_info.html) TaleWorlds.MountAndBlade.View.Tableaus.ThumbnailCacheManager.CreateTexture | ( | [ThumbnailCreationData](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_creation_data.html) | *thumbnailCreationData* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#a19d995791ddf8d04ce8c172154a26de1)DestroyTexture()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.View.Tableaus.ThumbnailCacheManager.DestroyTexture | ( | [ThumbnailCreationData](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_thumbnail_creation_data.html) | *thumbnailCreationData* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#acb2b75e2f640ff9e88b7678e52617879)ForceClearAllCache()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Tableaus.ThumbnailCacheManager.ForceClearAllCache | ( | bool | *releaseImmediately* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#a41feb4fc81e51c169b138ce006c19878)GetCachedHeroSilhouetteTexture()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) TaleWorlds.MountAndBlade.View.Tableaus.ThumbnailCacheManager.GetCachedHeroSilhouetteTexture | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#aabac761bcc92a8ba761403fcf5123a17)ClearUnusedCache()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Tableaus.ThumbnailCacheManager.ClearUnusedCache | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#ac150d39f9ff8dd882958ccf6c1f3c485)Tick()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Tableaus.ThumbnailCacheManager.Tick | ( | float | *dt* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#ade1f27080f381425c71d77065568d0fe)Current
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ThumbnailCacheManager](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html) TaleWorlds.MountAndBlade.View.Tableaus.ThumbnailCacheManager.Current | | staticget |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnail_cache_manager.html#a253245c31c385a8de8c879983a87365c)InventorySceneCameraFrame
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.View.Tableaus.ThumbnailCacheManager.InventorySceneCameraFrame | | get |

