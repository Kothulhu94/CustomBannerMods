--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_banner_visual.html ---

TaleWorlds.MountAndBlade.View.BannerVisual Class ReferenceInherits [TaleWorlds.Core.IBannerVisual](interface_tale_worlds_1_1_core_1_1_i_banner_visual.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [BannerVisual](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_banner_visual.html#a382b2d7945263b99aa424de8b951970e) ([Banner](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_banner_visual.html#affde6671a1fcae39afc6507120f8e313) banner) |
| void | [ValidateCreateTableauTextures](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_banner_visual.html#a864633e22b373996911fe197ac7c1640) () |
| [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) | [GetTableauTextureSmall](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_banner_visual.html#aefd6e833a5ba7029f4a75e3eba6cc5e8) (in [BannerDebugInfo](struct_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_banner_debug_info.html) debugInfo, Action< [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) > setAction, bool isTableauOrNineGrid=true) |
| [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) | [GetTableauTextureLarge](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_banner_visual.html#ab97b34d53841f0f4567692bab0718ab5) (in [BannerDebugInfo](struct_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_banner_debug_info.html) debugInfo, Action< [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) > setAction, bool isTableauOrNineGrid=true) |
| [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) | [GetTableauTextureLarge](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_banner_visual.html#a837a2e0623ee41ecbcc213e7f1661702) (in [BannerDebugInfo](struct_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_banner_debug_info.html) debugInfo, Action< [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) > setAction, out [BannerTextureCreationData](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_banner_texture_creation_data.html) creationData, bool isTableauOrNineGrid=true) |
| [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | [ConvertToMultiMesh](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_banner_visual.html#a10a62a98e20252e534af0675bc7e6697) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetMeshMatrix](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_banner_visual.html#a2248fdd5e25ae5e10126c7ceae89e0f9) (ref [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) mesh, float marginLeft, float marginTop, float width, float height, bool mirrored, float rotation, float deltaZ) |

|  |  |
| --- | --- |
| Properties | |
| Banner | [Banner](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_banner_visual.html#affde6671a1fcae39afc6507120f8e313) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_banner_visual.html#a382b2d7945263b99aa424de8b951970e)BannerVisual()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.View.BannerVisual.BannerVisual | ( | [Banner](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_banner_visual.html#affde6671a1fcae39afc6507120f8e313) | *banner* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_banner_visual.html#a864633e22b373996911fe197ac7c1640)ValidateCreateTableauTextures()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.BannerVisual.ValidateCreateTableauTextures | ( |  | ) |  |

Implements [TaleWorlds.Core.IBannerVisual](interface_tale_worlds_1_1_core_1_1_i_banner_visual.html#a8bc1ed2ef5091e1cce2f0c930b43aa93).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_banner_visual.html#aefd6e833a5ba7029f4a75e3eba6cc5e8)GetTableauTextureSmall()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) TaleWorlds.MountAndBlade.View.BannerVisual.GetTableauTextureSmall | ( | in [BannerDebugInfo](struct_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_banner_debug_info.html) | *debugInfo*, |
|  |  | Action< [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) > | *setAction*, |
|  |  | bool | *isTableauOrNineGrid* = true ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_banner_visual.html#ab97b34d53841f0f4567692bab0718ab5)GetTableauTextureLarge() [1/2]
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) TaleWorlds.MountAndBlade.View.BannerVisual.GetTableauTextureLarge | ( | in [BannerDebugInfo](struct_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_banner_debug_info.html) | *debugInfo*, |
|  |  | Action< [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) > | *setAction*, |
|  |  | bool | *isTableauOrNineGrid* = true ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_banner_visual.html#a837a2e0623ee41ecbcc213e7f1661702)GetTableauTextureLarge() [2/2]
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) TaleWorlds.MountAndBlade.View.BannerVisual.GetTableauTextureLarge | ( | in [BannerDebugInfo](struct_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_banner_debug_info.html) | *debugInfo*, |
|  |  | Action< [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) > | *setAction*, |
|  |  | out [BannerTextureCreationData](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_tableaus_1_1_thumbnails_1_1_banner_texture_creation_data.html) | *creationData*, |
|  |  | bool | *isTableauOrNineGrid* = true ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_banner_visual.html#a2248fdd5e25ae5e10126c7ceae89e0f9)GetMeshMatrix()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.View.BannerVisual.GetMeshMatrix | ( | ref [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) | *mesh*, | |  |  | float | *marginLeft*, | |  |  | float | *marginTop*, | |  |  | float | *width*, | |  |  | float | *height*, | |  |  | bool | *mirrored*, | |  |  | float | *rotation*, | |  |  | float | *deltaZ* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_banner_visual.html#a10a62a98e20252e534af0675bc7e6697)ConvertToMultiMesh()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) TaleWorlds.MountAndBlade.View.BannerVisual.ConvertToMultiMesh | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_banner_visual.html#affde6671a1fcae39afc6507120f8e313)Banner
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Banner TaleWorlds.MountAndBlade.View.BannerVisual.Banner | | get |

