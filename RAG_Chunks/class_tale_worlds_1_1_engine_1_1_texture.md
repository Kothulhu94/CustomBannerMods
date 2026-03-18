--- SOURCE: class_tale_worlds_1_1_engine_1_1_texture.html ---

TaleWorlds.Engine.Texture Class ReferencesealedRepresentation of 2D texture resource in Mono domain No means of texture copying is provided in this interface so all the accessor properties are read only.

Inherits [TaleWorlds.Engine.Resource](class_tale_worlds_1_1_engine_1_1_resource.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [GetPixelData](class_tale_worlds_1_1_engine_1_1_texture.html#a10d2369389d96ab6d7c640de16d75596) (byte[] bytes) |
| void | [TransformRenderTargetToResource](class_tale_worlds_1_1_engine_1_1_texture.html#a8a02e5c26826b8662265dbd7d63016da) (string name) |
| bool | [IsLoaded](class_tale_worlds_1_1_engine_1_1_texture.html#a22d233939b96c175bddfd424469069f1) () |
| void | [GetSDFBoundingBoxData](class_tale_worlds_1_1_engine_1_1_texture.html#a2249ad560a0de6be483359de104ceb62) (ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) min, ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) max) |
| void | [PreloadTexture](class_tale_worlds_1_1_engine_1_1_texture.html#a0e5b084cf078d7f85d331d1f2ff1c0df) (bool blocking) |
| void | [Release](class_tale_worlds_1_1_engine_1_1_texture.html#a8d72929def2be25db8f72ec96fcb5398) () |
| void | [ReleaseImmediately](class_tale_worlds_1_1_engine_1_1_texture.html#a6d057411d3ab80c58c68f2fa1e5facd7) () |
| void | [ReleaseAfterNumberOfFrames](class_tale_worlds_1_1_engine_1_1_texture.html#a22a1928420ed35f294f8fbbc6f584e97) (int frameCount) |
| void | [SaveToFile](class_tale_worlds_1_1_engine_1_1_texture.html#aa510969886d367707749b9d2358e0ae9) (string path, bool isRelativePath) |
| void | [SetTextureAsAlwaysValid](class_tale_worlds_1_1_engine_1_1_texture.html#a1ae7f20e669d9fb0167be2568b24a763) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static Texture | [CreateTextureFromPath](class_tale_worlds_1_1_engine_1_1_texture.html#a068a8aab2dda27ca158e2acf9c4453c3) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) filePath) |
| static Texture | [GetFromResource](class_tale_worlds_1_1_engine_1_1_texture.html#ab6956b8605f19b66f5349bfc3513781d) (string resourceName) |
| static Texture | [CheckAndGetFromResource](class_tale_worlds_1_1_engine_1_1_texture.html#a195c3c01538e194bd56c6a43eedf37a4) (string resourceName) |
| static void | [ScaleTextureWithRatio](class_tale_worlds_1_1_engine_1_1_texture.html#a33656966c690548e1b94100ada892eec) (ref int tableauSizeX, ref int tableauSizeY) |
| static Texture | [LoadTextureFromPath](class_tale_worlds_1_1_engine_1_1_texture.html#a79120ad68c86f562efe0af97a1574781) (string fileName, string folder) |
| static Texture | [CreateDepthTarget](class_tale_worlds_1_1_engine_1_1_texture.html#a028318e3b206f29a85a9763f7b36d337) (string name, int width, int height) |
|  | Creates a depth stencil texture. |
| static Texture | [CreateFromByteArray](class_tale_worlds_1_1_engine_1_1_texture.html#a903fc3b3f789230fea5d0c62f3f115f6) (byte[] data, int width, int height) |
| static Texture | [CreateFromMemory](class_tale_worlds_1_1_engine_1_1_texture.html#a7a311ca5e84267971c439181815673fa) (byte[] data) |
| static void | [ReleaseGpuMemories](class_tale_worlds_1_1_engine_1_1_texture.html#a69098ac3dd807bcf1466f35e121f5a7b) () |
| static Texture | [CreateTableauTexture](class_tale_worlds_1_1_engine_1_1_texture.html#a2bafe1c1c7da02fada8cc8fa3470cdba) (string name, [RenderTargetComponent.TextureUpdateEventHandler](class_tale_worlds_1_1_engine_1_1_render_target_component.html#a2a7c2ca6ce8dacf90de1d69bc65ff9d4) eventHandler, Object objectRef, int tableauSizeX, int tableauSizeY) |
| static Texture | [CreateRenderTarget](class_tale_worlds_1_1_engine_1_1_texture.html#a28775a1ac94cbd1f5399109adb1f66be) (string name, int width, int height, bool autoMipmaps, bool isTableau, bool createUninitialized=false, bool always\_valid=false) |
|  | Creates a render target texture. |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsReleased](class_tale_worlds_1_1_engine_1_1_texture.html#ab71515673cd4a173993743d75d84d613) `[get]` |
| int | [Width](class_tale_worlds_1_1_engine_1_1_texture.html#a5984cad3ce719fa7ae3f01cd723d0aaa) `[get]` |
|  | Gets the width of the texture object in pixels. |
| int | [Height](class_tale_worlds_1_1_engine_1_1_texture.html#a21ea2d485b8bba58cd3a86341ad45bfd) `[get]` |
|  | Gets the height of the texture object in pixels. |
| int | [MemorySize](class_tale_worlds_1_1_engine_1_1_texture.html#a65cb419f7fba4afc8a45d7677183b42e) `[get]` |
| bool | [IsRenderTarget](class_tale_worlds_1_1_engine_1_1_texture.html#a93f8bba20d948be6dcb1dd064570f3df) `[get]` |
|  | Gets a value indicating whether the texture is a render target texture. |
| string | [Name](class_tale_worlds_1_1_engine_1_1_texture.html#a63d9bd73d8fa2a850e2bb5b949261c8e) `[get, set]` |
|  | Gets the name of the texture. |
| RenderTargetComponent | [RenderTargetComponent](class_tale_worlds_1_1_engine_1_1_texture.html#aac40baef4b625d6df89fa10fc18d8fbe) `[get]` |
| TableauView | [TableauView](class_tale_worlds_1_1_engine_1_1_texture.html#aed36f607afd5ff72b745ac089447c754) `[get]` |
| object | [UserData](class_tale_worlds_1_1_engine_1_1_texture.html#a782de3a030353279f72c893a9881af7f) `[get]` |
| Properties inherited from [TaleWorlds.Engine.Resource](class_tale_worlds_1_1_engine_1_1_resource.html) | |
| bool | [IsValid](class_tale_worlds_1_1_engine_1_1_resource.html#ad0c94ab0bd3bcdd26b02ac6117e7662f) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Protected Member Functions inherited from [TaleWorlds.Engine.Resource](class_tale_worlds_1_1_engine_1_1_resource.html) | |
|  | [Resource](class_tale_worlds_1_1_engine_1_1_resource.html#a933e187fe65b6aebb90f58f2f44f8e13) () |
| void | [CheckResourceParameter](class_tale_worlds_1_1_engine_1_1_resource.html#acb4f0c2d802a8a8530c3813f8c7e9c5d) ([Resource](class_tale_worlds_1_1_engine_1_1_resource.html#a933e187fe65b6aebb90f58f2f44f8e13) param, string paramName="") |
|  | Check if the parameter 'param' is null or invalid and throws an exception containing 'paramName' as further information. |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_engine_1_1_texture.html#a068a8aab2dda27ca158e2acf9c4453c3)CreateTextureFromPath()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | Texture TaleWorlds.Engine.Texture.CreateTextureFromPath | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *filePath* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_texture.html#a10d2369389d96ab6d7c640de16d75596)GetPixelData()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Texture.GetPixelData | ( | byte[] | *bytes* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_texture.html#a8a02e5c26826b8662265dbd7d63016da)TransformRenderTargetToResource()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Texture.TransformRenderTargetToResource | ( | string | *name* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_texture.html#ab6956b8605f19b66f5349bfc3513781d)GetFromResource()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | Texture TaleWorlds.Engine.Texture.GetFromResource | ( | string | *resourceName* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_texture.html#a22d233939b96c175bddfd424469069f1)IsLoaded()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.Texture.IsLoaded | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_texture.html#a2249ad560a0de6be483359de104ceb62)GetSDFBoundingBoxData()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Texture.GetSDFBoundingBoxData | ( | ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *min*, |
|  |  | ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *max* ) |

[◆](class_tale_worlds_1_1_engine_1_1_texture.html#a195c3c01538e194bd56c6a43eedf37a4)CheckAndGetFromResource()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | Texture TaleWorlds.Engine.Texture.CheckAndGetFromResource | ( | string | *resourceName* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_texture.html#a33656966c690548e1b94100ada892eec)ScaleTextureWithRatio()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.Texture.ScaleTextureWithRatio | ( | ref int | *tableauSizeX*, | |  |  | ref int | *tableauSizeY* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_texture.html#a0e5b084cf078d7f85d331d1f2ff1c0df)PreloadTexture()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Texture.PreloadTexture | ( | bool | *blocking* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_texture.html#a8d72929def2be25db8f72ec96fcb5398)Release()
---------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Texture.Release | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_texture.html#a6d057411d3ab80c58c68f2fa1e5facd7)ReleaseImmediately()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Texture.ReleaseImmediately | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_texture.html#a22a1928420ed35f294f8fbbc6f584e97)ReleaseAfterNumberOfFrames()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Texture.ReleaseAfterNumberOfFrames | ( | int | *frameCount* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_texture.html#a79120ad68c86f562efe0af97a1574781)LoadTextureFromPath()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | Texture TaleWorlds.Engine.Texture.LoadTextureFromPath | ( | string | *fileName*, | |  |  | string | *folder* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_texture.html#a028318e3b206f29a85a9763f7b36d337)CreateDepthTarget()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | Texture TaleWorlds.Engine.Texture.CreateDepthTarget | ( | string | *name*, | |  |  | int | *width*, | |  |  | int | *height* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_texture.html#a903fc3b3f789230fea5d0c62f3f115f6)CreateFromByteArray()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | Texture TaleWorlds.Engine.Texture.CreateFromByteArray | ( | byte[] | *data*, | |  |  | int | *width*, | |  |  | int | *height* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_texture.html#aa510969886d367707749b9d2358e0ae9)SaveToFile()
------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Texture.SaveToFile | ( | string | *path*, |
|  |  | bool | *isRelativePath* ) |

[◆](class_tale_worlds_1_1_engine_1_1_texture.html#a1ae7f20e669d9fb0167be2568b24a763)SetTextureAsAlwaysValid()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Texture.SetTextureAsAlwaysValid | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_texture.html#a7a311ca5e84267971c439181815673fa)CreateFromMemory()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | Texture TaleWorlds.Engine.Texture.CreateFromMemory | ( | byte[] | *data* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_texture.html#a69098ac3dd807bcf1466f35e121f5a7b)ReleaseGpuMemories()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Texture.ReleaseGpuMemories | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_texture.html#a2bafe1c1c7da02fada8cc8fa3470cdba)CreateTableauTexture()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | Texture TaleWorlds.Engine.Texture.CreateTableauTexture | ( | string | *name*, | |  |  | [RenderTargetComponent.TextureUpdateEventHandler](class_tale_worlds_1_1_engine_1_1_render_target_component.html#a2a7c2ca6ce8dacf90de1d69bc65ff9d4) | *eventHandler*, | |  |  | Object | *objectRef*, | |  |  | int | *tableauSizeX*, | |  |  | int | *tableauSizeY* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_texture.html#a28775a1ac94cbd1f5399109adb1f66be)CreateRenderTarget()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | Texture TaleWorlds.Engine.Texture.CreateRenderTarget | ( | string | *name*, | |  |  | int | *width*, | |  |  | int | *height*, | |  |  | bool | *autoMipmaps*, | |  |  | bool | *isTableau*, | |  |  | bool | *createUninitialized* = false, | |  |  | bool | *always\_valid* = false ) | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_engine_1_1_texture.html#ab71515673cd4a173993743d75d84d613)IsReleased
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Engine.Texture.IsReleased | | get |

[◆](class_tale_worlds_1_1_engine_1_1_texture.html#a5984cad3ce719fa7ae3f01cd723d0aaa)Width
-----------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Engine.Texture.Width | | get |

[◆](class_tale_worlds_1_1_engine_1_1_texture.html#a21ea2d485b8bba58cd3a86341ad45bfd)Height
------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Engine.Texture.Height | | get |

[◆](class_tale_worlds_1_1_engine_1_1_texture.html#a65cb419f7fba4afc8a45d7677183b42e)MemorySize
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Engine.Texture.MemorySize | | get |

[◆](class_tale_worlds_1_1_engine_1_1_texture.html#a93f8bba20d948be6dcb1dd064570f3df)IsRenderTarget
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Engine.Texture.IsRenderTarget | | get |

[◆](class_tale_worlds_1_1_engine_1_1_texture.html#a63d9bd73d8fa2a850e2bb5b949261c8e)Name
----------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Engine.Texture.Name | | getset |

[◆](class_tale_worlds_1_1_engine_1_1_texture.html#aac40baef4b625d6df89fa10fc18d8fbe)RenderTargetComponent
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | RenderTargetComponent TaleWorlds.Engine.Texture.RenderTargetComponent | | get |

[◆](class_tale_worlds_1_1_engine_1_1_texture.html#aed36f607afd5ff72b745ac089447c754)TableauView
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | TableauView TaleWorlds.Engine.Texture.TableauView | | get |

[◆](class_tale_worlds_1_1_engine_1_1_texture.html#a782de3a030353279f72c893a9881af7f)UserData
--------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | object TaleWorlds.Engine.Texture.UserData | | get |

