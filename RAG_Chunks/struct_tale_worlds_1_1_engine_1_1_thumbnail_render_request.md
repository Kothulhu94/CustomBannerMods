--- SOURCE: struct_tale_worlds_1_1_engine_1_1_thumbnail_render_request.html ---

TaleWorlds.Engine.ThumbnailRenderRequest Struct Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [ThumbnailRenderRequest](struct_tale_worlds_1_1_engine_1_1_thumbnail_render_request.html) | [CreateWithTexture](struct_tale_worlds_1_1_engine_1_1_thumbnail_render_request.html#ace3803ef086e737b5add2380dcf67e54) ([Scene](class_tale_worlds_1_1_engine_1_1_scene.html) scene, [Camera](class_tale_worlds_1_1_engine_1_1_camera.html) camera, [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) texture, [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) entity, string renderId, string debugName, int allocationGroupIndex) |
| static [ThumbnailRenderRequest](struct_tale_worlds_1_1_engine_1_1_thumbnail_render_request.html) | [CreateWithoutTexture](struct_tale_worlds_1_1_engine_1_1_thumbnail_render_request.html#addf2c4b47fac1b2ec02a0a48e24bc16a) ([Scene](class_tale_worlds_1_1_engine_1_1_scene.html) scene, [Camera](class_tale_worlds_1_1_engine_1_1_camera.html) camera, [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) entity, string renderId, int width, int height, string debugName, int allocationGroupIndex) |
| static [ThumbnailRenderRequest](struct_tale_worlds_1_1_engine_1_1_thumbnail_render_request.html) | [CreateForCachedEntity](struct_tale_worlds_1_1_engine_1_1_thumbnail_render_request.html#a443749fe603e85bcee190aa353f96454) ([Scene](class_tale_worlds_1_1_engine_1_1_scene.html) scene, [Camera](class_tale_worlds_1_1_engine_1_1_camera.html) camera, [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) texture, string cachedEntityId, string renderId, string debugName, int allocationGroupIndex) |
| static [ThumbnailRenderRequest](struct_tale_worlds_1_1_engine_1_1_thumbnail_render_request.html) | [CreateForCachedEntityWithoutTexture](struct_tale_worlds_1_1_engine_1_1_thumbnail_render_request.html#ab70d0340e417d6a5b037c5bfa103d66f) ([Scene](class_tale_worlds_1_1_engine_1_1_scene.html) scene, [Camera](class_tale_worlds_1_1_engine_1_1_camera.html) camera, string cachedEntityId, string renderId, int width, int height, string debugName, int allocationGroupIndex) |

|  |  |
| --- | --- |
| Public Attributes | |
| UIntPtr | [ScenePointer](struct_tale_worlds_1_1_engine_1_1_thumbnail_render_request.html#af3cc1c6bd30c1605062ce8b85d49f573) |
| UIntPtr | [CameraPointer](struct_tale_worlds_1_1_engine_1_1_thumbnail_render_request.html#af32f1fca94ff01cba99f564c5b2d7df1) |
| UIntPtr | [TexturePointer](struct_tale_worlds_1_1_engine_1_1_thumbnail_render_request.html#ac7705d304f4f6e8b9b0c6e8ca310970d) |
| string | [CachedEntityId](struct_tale_worlds_1_1_engine_1_1_thumbnail_render_request.html#a7168cc07c2991bb919495510151086d1) |
| UIntPtr | [EntityPointer](struct_tale_worlds_1_1_engine_1_1_thumbnail_render_request.html#ad7b85fc8da737ad2e77a9122a45d233e) |
| int | [Width](struct_tale_worlds_1_1_engine_1_1_thumbnail_render_request.html#a449877e0dcbb8a4197cb829b556f8f1c) |
| int | [Height](struct_tale_worlds_1_1_engine_1_1_thumbnail_render_request.html#ac42a3ae2565adbbac7b2282d2644c381) |
| string | [RenderId](struct_tale_worlds_1_1_engine_1_1_thumbnail_render_request.html#a9e694f33f6b4c1471fa36d8f1560e010) |
| string | [DebugName](struct_tale_worlds_1_1_engine_1_1_thumbnail_render_request.html#a5efced6887f263be2dd11dab055c7547) |
| int | [AllocationGroupIndex](struct_tale_worlds_1_1_engine_1_1_thumbnail_render_request.html#a84e2748a3254da1b057bbbeca2b9956b) |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_engine_1_1_thumbnail_render_request.html#ace3803ef086e737b5add2380dcf67e54)CreateWithTexture()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ThumbnailRenderRequest](struct_tale_worlds_1_1_engine_1_1_thumbnail_render_request.html) TaleWorlds.Engine.ThumbnailRenderRequest.CreateWithTexture | ( | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *scene*, | |  |  | [Camera](class_tale_worlds_1_1_engine_1_1_camera.html) | *camera*, | |  |  | [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) | *texture*, | |  |  | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *entity*, | |  |  | string | *renderId*, | |  |  | string | *debugName*, | |  |  | int | *allocationGroupIndex* ) | | static |

[◆](struct_tale_worlds_1_1_engine_1_1_thumbnail_render_request.html#addf2c4b47fac1b2ec02a0a48e24bc16a)CreateWithoutTexture()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ThumbnailRenderRequest](struct_tale_worlds_1_1_engine_1_1_thumbnail_render_request.html) TaleWorlds.Engine.ThumbnailRenderRequest.CreateWithoutTexture | ( | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *scene*, | |  |  | [Camera](class_tale_worlds_1_1_engine_1_1_camera.html) | *camera*, | |  |  | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *entity*, | |  |  | string | *renderId*, | |  |  | int | *width*, | |  |  | int | *height*, | |  |  | string | *debugName*, | |  |  | int | *allocationGroupIndex* ) | | static |

[◆](struct_tale_worlds_1_1_engine_1_1_thumbnail_render_request.html#a443749fe603e85bcee190aa353f96454)CreateForCachedEntity()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ThumbnailRenderRequest](struct_tale_worlds_1_1_engine_1_1_thumbnail_render_request.html) TaleWorlds.Engine.ThumbnailRenderRequest.CreateForCachedEntity | ( | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *scene*, | |  |  | [Camera](class_tale_worlds_1_1_engine_1_1_camera.html) | *camera*, | |  |  | [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) | *texture*, | |  |  | string | *cachedEntityId*, | |  |  | string | *renderId*, | |  |  | string | *debugName*, | |  |  | int | *allocationGroupIndex* ) | | static |

[◆](struct_tale_worlds_1_1_engine_1_1_thumbnail_render_request.html#ab70d0340e417d6a5b037c5bfa103d66f)CreateForCachedEntityWithoutTexture()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ThumbnailRenderRequest](struct_tale_worlds_1_1_engine_1_1_thumbnail_render_request.html) TaleWorlds.Engine.ThumbnailRenderRequest.CreateForCachedEntityWithoutTexture | ( | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *scene*, | |  |  | [Camera](class_tale_worlds_1_1_engine_1_1_camera.html) | *camera*, | |  |  | string | *cachedEntityId*, | |  |  | string | *renderId*, | |  |  | int | *width*, | |  |  | int | *height*, | |  |  | string | *debugName*, | |  |  | int | *allocationGroupIndex* ) | | static |

Member Data Documentation
-------------------------

[◆](struct_tale_worlds_1_1_engine_1_1_thumbnail_render_request.html#af3cc1c6bd30c1605062ce8b85d49f573)ScenePointer
------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| UIntPtr TaleWorlds.Engine.ThumbnailRenderRequest.ScenePointer |

[◆](struct_tale_worlds_1_1_engine_1_1_thumbnail_render_request.html#af32f1fca94ff01cba99f564c5b2d7df1)CameraPointer
-------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| UIntPtr TaleWorlds.Engine.ThumbnailRenderRequest.CameraPointer |

[◆](struct_tale_worlds_1_1_engine_1_1_thumbnail_render_request.html#ac7705d304f4f6e8b9b0c6e8ca310970d)TexturePointer
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| UIntPtr TaleWorlds.Engine.ThumbnailRenderRequest.TexturePointer |

[◆](struct_tale_worlds_1_1_engine_1_1_thumbnail_render_request.html#a7168cc07c2991bb919495510151086d1)CachedEntityId
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.Engine.ThumbnailRenderRequest.CachedEntityId |

[◆](struct_tale_worlds_1_1_engine_1_1_thumbnail_render_request.html#ad7b85fc8da737ad2e77a9122a45d233e)EntityPointer
-------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| UIntPtr TaleWorlds.Engine.ThumbnailRenderRequest.EntityPointer |

[◆](struct_tale_worlds_1_1_engine_1_1_thumbnail_render_request.html#a449877e0dcbb8a4197cb829b556f8f1c)Width
-----------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.Engine.ThumbnailRenderRequest.Width |

[◆](struct_tale_worlds_1_1_engine_1_1_thumbnail_render_request.html#ac42a3ae2565adbbac7b2282d2644c381)Height
------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.Engine.ThumbnailRenderRequest.Height |

[◆](struct_tale_worlds_1_1_engine_1_1_thumbnail_render_request.html#a9e694f33f6b4c1471fa36d8f1560e010)RenderId
--------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.Engine.ThumbnailRenderRequest.RenderId |

[◆](struct_tale_worlds_1_1_engine_1_1_thumbnail_render_request.html#a5efced6887f263be2dd11dab055c7547)DebugName
---------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.Engine.ThumbnailRenderRequest.DebugName |

[◆](struct_tale_worlds_1_1_engine_1_1_thumbnail_render_request.html#a84e2748a3254da1b057bbbeca2b9956b)AllocationGroupIndex
--------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.Engine.ThumbnailRenderRequest.AllocationGroupIndex |

