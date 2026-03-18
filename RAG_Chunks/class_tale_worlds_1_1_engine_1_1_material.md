--- SOURCE: class_tale_worlds_1_1_engine_1_1_material.html ---

TaleWorlds.Engine.Material Class ReferencesealedRepresentation of the material in the Mono domain MBMaterial provides methods related to texture, shader, and other material properties.

Inherits [TaleWorlds.Engine.Resource](class_tale_worlds_1_1_engine_1_1_resource.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [MBTextureType](class_tale_worlds_1_1_engine_1_1_material.html#aeaf8132ea5f9376eb525ea637f92e3ac) {     [DiffuseMap](class_tale_worlds_1_1_engine_1_1_material.html#aeaf8132ea5f9376eb525ea637f92e3aca9fbbb43e87f61f89399e9bebb3b6440f) ,     [DiffuseMap2](class_tale_worlds_1_1_engine_1_1_material.html#aeaf8132ea5f9376eb525ea637f92e3acaab9be5765911769e39b23fe1a341d1b4) ,     [BumpMap](class_tale_worlds_1_1_engine_1_1_material.html#aeaf8132ea5f9376eb525ea637f92e3aca987a3ee89b4d0fedaaa9befa77b7a6b8) ,     [EnvironmentMap](class_tale_worlds_1_1_engine_1_1_material.html#aeaf8132ea5f9376eb525ea637f92e3aca50099aa70b60201667f40e2bc9bc7b17) ,     [SpecularMap](class_tale_worlds_1_1_engine_1_1_material.html#aeaf8132ea5f9376eb525ea637f92e3aca7969ef3f5ea1411e8a3d82fcfd50f21f)   } |
|  | Types of texture regarding its usage in the related shader. [More...](class_tale_worlds_1_1_engine_1_1_material.html#aeaf8132ea5f9376eb525ea637f92e3ac) |
| enum | [MBAlphaBlendMode](class_tale_worlds_1_1_engine_1_1_material.html#a87a30f27a54e0ffb870981896912aff4) : byte {     [NoAlphaBlend](class_tale_worlds_1_1_engine_1_1_material.html#a87a30f27a54e0ffb870981896912aff4a9fda4a6fc2b77bd0d80bc55b27710718) ,     [Modulate](class_tale_worlds_1_1_engine_1_1_material.html#a87a30f27a54e0ffb870981896912aff4ac870e2fca2609e8077de9470fbb9ab43) ,     [AddAlpha](class_tale_worlds_1_1_engine_1_1_material.html#a87a30f27a54e0ffb870981896912aff4a696e931b95c9b91f010cf498cd42c8e6) ,     [Multiply](class_tale_worlds_1_1_engine_1_1_material.html#a87a30f27a54e0ffb870981896912aff4ae257376d913f3b53cbb4a9b19d770648) ,     [Add](class_tale_worlds_1_1_engine_1_1_material.html#a87a30f27a54e0ffb870981896912aff4aec211f7c20af43e742bf2570c3cb84f9) ,     [Max](class_tale_worlds_1_1_engine_1_1_material.html#a87a30f27a54e0ffb870981896912aff4a6a061313d22e51e0f25b7cd4dc065233) ,     [Factor](class_tale_worlds_1_1_engine_1_1_material.html#a87a30f27a54e0ffb870981896912aff4a3c3ba615798db7340cd94c6e2d59e74e) ,     [AddModulateCombined](class_tale_worlds_1_1_engine_1_1_material.html#a87a30f27a54e0ffb870981896912aff4a80152a043af157421aa0dcb07cf044c5) ,     [NoAlphaBlendNoWrite](class_tale_worlds_1_1_engine_1_1_material.html#a87a30f27a54e0ffb870981896912aff4afd869a7bf6228801279306fbb586a880) ,     [ModulateNoWrite](class_tale_worlds_1_1_engine_1_1_material.html#a87a30f27a54e0ffb870981896912aff4aac30ebc78c6f5e6d61a33c8ce5105e09) ,     [GbufferAlphaBlend](class_tale_worlds_1_1_engine_1_1_material.html#a87a30f27a54e0ffb870981896912aff4a7795142e58f4d8704fc034e4eeb23529) ,     [GbufferAlphaBlendWithVtResolve](class_tale_worlds_1_1_engine_1_1_material.html#a87a30f27a54e0ffb870981896912aff4a159197bf616587420802e43803959518) ,     [NoAlphaBlendNoAlphaWrite](class_tale_worlds_1_1_engine_1_1_material.html#a87a30f27a54e0ffb870981896912aff4aaaeea097d308f258942de7258ecb4609) ,     [Total](class_tale_worlds_1_1_engine_1_1_material.html#a87a30f27a54e0ffb870981896912aff4a96b0141273eabab320119c467cdcaf17)   } |
|  | Types of alpha blend modes available for MBMaterial. [More...](class_tale_worlds_1_1_engine_1_1_material.html#a87a30f27a54e0ffb870981896912aff4) |

|  |  |
| --- | --- |
| Public Member Functions | |
| Material | [CreateCopy](class_tale_worlds_1_1_engine_1_1_material.html#a274e106ef71e7bed6e00fe90d98faf92) () |
|  | Creates a copy this MBMaterial Added as a convenience method Same as new MBMaterial(this). |
| void | [SetShader](class_tale_worlds_1_1_engine_1_1_material.html#ad896ec74843860817d63e0c6e322f2eb) ([Shader](class_tale_worlds_1_1_engine_1_1_shader.html) shader) |
|  | Sets the material shader. |
| [Shader](class_tale_worlds_1_1_engine_1_1_shader.html) | [GetShader](class_tale_worlds_1_1_engine_1_1_material.html#a110816d39e497a71d3df8db3c08e951f) () |
|  | Returns the assigned MBShader. |
| UInt64 | [GetShaderFlags](class_tale_worlds_1_1_engine_1_1_material.html#a6295fe5f5aed29adc31bd4b528ed1edd) () |
| void | [SetShaderFlags](class_tale_worlds_1_1_engine_1_1_material.html#a8337381b5e983d8a0b92f499c49c7978) (UInt64 flagEntry) |
| void | [SetMeshVectorArgument](class_tale_worlds_1_1_engine_1_1_material.html#ac22c4818f6cce75f1791368803195bc4) (float x, float y, float z, float w) |
| void | [SetTexture](class_tale_worlds_1_1_engine_1_1_material.html#a39a5b09d35679d6f8d2de6a1e208300a) ([MBTextureType](class_tale_worlds_1_1_engine_1_1_material.html#aeaf8132ea5f9376eb525ea637f92e3ac) textureType, [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) texture) |
|  | Sets the texture to the texture slot specified by 'textureType'. |
| void | [SetTextureAtSlot](class_tale_worlds_1_1_engine_1_1_material.html#a2150872294aa93ed935a92a58779f202) (int textureSlot, [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) texture) |
| void | [SetAreaMapScale](class_tale_worlds_1_1_engine_1_1_material.html#a423a3e024162033c7c6271b1c2e972ab) (float scale) |
| void | [SetEnableSkinning](class_tale_worlds_1_1_engine_1_1_material.html#ac12908901e245844fb1f759043bf0836) (bool enable) |
| bool | [UsingSkinning](class_tale_worlds_1_1_engine_1_1_material.html#a898fb86eaae0fdbe608c0e70e0aa69b0) () |
| [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) | [GetTexture](class_tale_worlds_1_1_engine_1_1_material.html#a91443dfafdc8e783845035a4a771ca87) ([MBTextureType](class_tale_worlds_1_1_engine_1_1_material.html#aeaf8132ea5f9376eb525ea637f92e3ac) textureType) |
|  | Returns the texture assigned to 'textureType' slot. |
| [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) | [GetTextureWithSlot](class_tale_worlds_1_1_engine_1_1_material.html#a6b2e835caf2bfcc4087615ac351a6971) (int textureSlot) |
| [MBAlphaBlendMode](class_tale_worlds_1_1_engine_1_1_material.html#a87a30f27a54e0ffb870981896912aff4) | [GetAlphaBlendMode](class_tale_worlds_1_1_engine_1_1_material.html#a65637331daedb8693306afe35c9b64ee) () |
|  | Returns the alpha blend mode of the material. |
| void | [SetAlphaBlendMode](class_tale_worlds_1_1_engine_1_1_material.html#a225c215c38382c14f9cfab2f7ec1b14a) ([MBAlphaBlendMode](class_tale_worlds_1_1_engine_1_1_material.html#a87a30f27a54e0ffb870981896912aff4) alphaBlendMode) |
|  | Sets the alpha blend mode of this MBMaterial. |
| void | [SetAlphaTestValue](class_tale_worlds_1_1_engine_1_1_material.html#a7c611ce42870ae5ef2aee3220b6a056d) (float alphaTestValue) |
|  | Sets the alpha test value of this MBMaterial. |
| float | [GetAlphaTestValue](class_tale_worlds_1_1_engine_1_1_material.html#a8ac7b7a7a140794ca133fb452caecb08) () |
|  | Gets the alpha test value of this MBMaterial. |
| void | [AddMaterialShaderFlag](class_tale_worlds_1_1_engine_1_1_material.html#ae7a212e68fea98a3a0ec8105388a3386) (String flagName, bool showErrors) |
| void | [RemoveMaterialShaderFlag](class_tale_worlds_1_1_engine_1_1_material.html#aa4d05ca8ab1c3448b055ec95aa487aa3) (String flagName) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static Material | [GetDefaultMaterial](class_tale_worlds_1_1_engine_1_1_material.html#a2f517af0b4d3682309b530dd5ace1324) () |
| static Material | [GetOutlineMaterial](class_tale_worlds_1_1_engine_1_1_material.html#ac5eae23a214d1af88e6eea173b0f6d52) ([Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) mesh) |
| static Material | [GetDefaultTableauSampleMaterial](class_tale_worlds_1_1_engine_1_1_material.html#ac564479a0d757b6bf81980bd0176cde3) (bool transparency) |
| static Material | [CreateTableauMaterial](class_tale_worlds_1_1_engine_1_1_material.html#adc90b8be698eaebe1e7bbd50a33266b8) ([RenderTargetComponent.TextureUpdateEventHandler](class_tale_worlds_1_1_engine_1_1_render_target_component.html#a2a7c2ca6ce8dacf90de1d69bc65ff9d4) eventHandler, Object objectRef, Material sampleMaterial, int tableauSizeX, int tableauSizeY, bool continuousTableau=false) |
| static Material | [GetFromResource](class_tale_worlds_1_1_engine_1_1_material.html#a61336a3ab8bd9d288e33b55ac6eef82b) (string materialName) |
|  | Returns a MBMaterial instance whose name is 'materialName'. |
| static Material | [GetAlphaMaskTableauMaterial](class_tale_worlds_1_1_engine_1_1_material.html#ad22328621693859f6f1bed5778218273) () |

|  |  |
| --- | --- |
| Properties | |
| string | [Name](class_tale_worlds_1_1_engine_1_1_material.html#a2da5239094091a981b16a6d72a76ba9e) `[get, set]` |
|  | Gets Name of the material This property is read only. |
| bool | [UsingSpecular](class_tale_worlds_1_1_engine_1_1_material.html#acf09cfa26361e056b3319f553de83828) `[get, set]` |
|  | Property defining the usage of specular light component. |
| bool | [UsingSpecularMap](class_tale_worlds_1_1_engine_1_1_material.html#a228a4f1449e6fe79be0e6fe6cab4d805) `[get, set]` |
|  | Property defining the usage of specular map for specular reflection calculations UsingSpecular should be 'true' for this property to take effect. |
| bool | [UsingEnvironmentMap](class_tale_worlds_1_1_engine_1_1_material.html#a42ac3ad636208bb188b505645b35c3b1) `[get, set]` |
|  | Property defining the usage of environment map. |
| bool | [UsingSpecularAlpha](class_tale_worlds_1_1_engine_1_1_material.html#a7792245d66764401eac3735a56ca020a) `[get, set]` |
|  | Property defining the usage of specular alpha. |
| bool | [UsingDynamicLight](class_tale_worlds_1_1_engine_1_1_material.html#ad94ce3aac82aa352b156014a8707f503) `[get, set]` |
|  | Property defining whether dynamic lights will effect this material or not. |
| bool | [UsingSunLight](class_tale_worlds_1_1_engine_1_1_material.html#a51ffe888f7b289599dc4eff8ff6b7d2c) `[get, set]` |
|  | Property defining whether sun light will effect this material or not. |
| bool | [UsingFresnel](class_tale_worlds_1_1_engine_1_1_material.html#a5b80a86af693aa01cb1bfe69a9026a1d) `[get, set]` |
|  | Property defining the usage of fresnel effect on this material. |
| bool | [IsSunShadowReceiver](class_tale_worlds_1_1_engine_1_1_material.html#a83364d7a6dea946223ae5a85ce52e8d9) `[get, set]` |
|  | Property defining whether shadows due to sun light will fall on this material. |
| bool | [IsDynamicShadowReceiver](class_tale_worlds_1_1_engine_1_1_material.html#a8c58d49a4b146eae5fb98d05da6e8882) `[get, set]` |
|  | Property defining whether dynamic shadows will fall on this material. |
| bool | [UsingDiffuseAlphaMap](class_tale_worlds_1_1_engine_1_1_material.html#ac9f0ede880f27b4fe5a7859f85f961e4) `[get, set]` |
|  | Property defining the usage of diffuse alpha map. |
| bool | [UsingParallaxMapping](class_tale_worlds_1_1_engine_1_1_material.html#a664c5fbcdf1a7f2d93e00bbea35ad250) `[get, set]` |
|  | Property defining the usage of parallax mapping. |
| bool | [UsingParallaxOcclusion](class_tale_worlds_1_1_engine_1_1_material.html#a5e83b17ba83dc435f3e5d5c3cd8dd776) `[get, set]` |
|  | Property defining the usage of parallax occlusion. |
| [MaterialFlags](namespace_tale_worlds_1_1_engine.html#aea9426b8effd85f8acc0f1aaab0b29a1) | [Flags](class_tale_worlds_1_1_engine_1_1_material.html#a6d0ae6d773990cb995ea6a8991cd095c) `[get, set]` |
| Properties inherited from [TaleWorlds.Engine.Resource](class_tale_worlds_1_1_engine_1_1_resource.html) | |
| bool | [IsValid](class_tale_worlds_1_1_engine_1_1_resource.html#ad0c94ab0bd3bcdd26b02ac6117e7662f) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Protected Member Functions inherited from [TaleWorlds.Engine.Resource](class_tale_worlds_1_1_engine_1_1_resource.html) | |
|  | [Resource](class_tale_worlds_1_1_engine_1_1_resource.html#a933e187fe65b6aebb90f58f2f44f8e13) () |
| void | [CheckResourceParameter](class_tale_worlds_1_1_engine_1_1_resource.html#acb4f0c2d802a8a8530c3813f8c7e9c5d) ([Resource](class_tale_worlds_1_1_engine_1_1_resource.html#a933e187fe65b6aebb90f58f2f44f8e13) param, string paramName="") |
|  | Check if the parameter 'param' is null or invalid and throws an exception containing 'paramName' as further information. |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_engine_1_1_material.html#aeaf8132ea5f9376eb525ea637f92e3ac)MBTextureType
--------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.Engine.Material.MBTextureType](class_tale_worlds_1_1_engine_1_1_material.html#aeaf8132ea5f9376eb525ea637f92e3ac) |

| Enumerator | |
| --- | --- |
| DiffuseMap |  |
| DiffuseMap2 |  |
| BumpMap |  |
| EnvironmentMap |  |
| SpecularMap |  |

[◆](class_tale_worlds_1_1_engine_1_1_material.html#a87a30f27a54e0ffb870981896912aff4)MBAlphaBlendMode
-----------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.Engine.Material.MBAlphaBlendMode](class_tale_worlds_1_1_engine_1_1_material.html#a87a30f27a54e0ffb870981896912aff4) : byte |

| Enumerator | |
| --- | --- |
| NoAlphaBlend |  |
| Modulate |  |
| AddAlpha |  |
| Multiply |  |
| Add |  |
| Max |  |
| Factor |  |
| AddModulateCombined |  |
| NoAlphaBlendNoWrite |  |
| ModulateNoWrite |  |
| GbufferAlphaBlend |  |
| GbufferAlphaBlendWithVtResolve |  |
| NoAlphaBlendNoAlphaWrite |  |
| Total |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_engine_1_1_material.html#a2f517af0b4d3682309b530dd5ace1324)GetDefaultMaterial()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | Material TaleWorlds.Engine.Material.GetDefaultMaterial | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_material.html#ac5eae23a214d1af88e6eea173b0f6d52)GetOutlineMaterial()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | Material TaleWorlds.Engine.Material.GetOutlineMaterial | ( | [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) | *mesh* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_material.html#ac564479a0d757b6bf81980bd0176cde3)GetDefaultTableauSampleMaterial()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | Material TaleWorlds.Engine.Material.GetDefaultTableauSampleMaterial | ( | bool | *transparency* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_material.html#adc90b8be698eaebe1e7bbd50a33266b8)CreateTableauMaterial()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | Material TaleWorlds.Engine.Material.CreateTableauMaterial | ( | [RenderTargetComponent.TextureUpdateEventHandler](class_tale_worlds_1_1_engine_1_1_render_target_component.html#a2a7c2ca6ce8dacf90de1d69bc65ff9d4) | *eventHandler*, | |  |  | Object | *objectRef*, | |  |  | Material | *sampleMaterial*, | |  |  | int | *tableauSizeX*, | |  |  | int | *tableauSizeY*, | |  |  | bool | *continuousTableau* = false ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_material.html#a274e106ef71e7bed6e00fe90d98faf92)CreateCopy()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| Material TaleWorlds.Engine.Material.CreateCopy | ( |  | ) |  |

Returns

[◆](class_tale_worlds_1_1_engine_1_1_material.html#a61336a3ab8bd9d288e33b55ac6eef82b)GetFromResource()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | Material TaleWorlds.Engine.Material.GetFromResource | ( | string | *materialName* | ) |  | | static |

Parameters
:   |  |  |
    | --- | --- |
    | materialName | Name of the material to get |

Returns
:   Returns the MBMaterial representation of the material named 'materialName'. Returns the previously retrieved instance. A new instance is created if there is none previously or its has been GCed. Returns null if there is no material named 'materialName'

[◆](class_tale_worlds_1_1_engine_1_1_material.html#ad896ec74843860817d63e0c6e322f2eb)SetShader()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Material.SetShader | ( | [Shader](class_tale_worlds_1_1_engine_1_1_shader.html) | *shader* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | shader | [Shader](class_tale_worlds_1_1_engine_1_1_shader.html "Representation of shader resource in Mono domain No means of shader copying is provided in this inter...") object to be set as the material shader |

[◆](class_tale_worlds_1_1_engine_1_1_material.html#a110816d39e497a71d3df8db3c08e951f)GetShader()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Shader](class_tale_worlds_1_1_engine_1_1_shader.html) TaleWorlds.Engine.Material.GetShader | ( |  | ) |  |

Returns
:   Returns the material shader Returns null if no shader is assigned to this material

[◆](class_tale_worlds_1_1_engine_1_1_material.html#a6295fe5f5aed29adc31bd4b528ed1edd)GetShaderFlags()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| UInt64 TaleWorlds.Engine.Material.GetShaderFlags | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_material.html#a8337381b5e983d8a0b92f499c49c7978)SetShaderFlags()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Material.SetShaderFlags | ( | UInt64 | *flagEntry* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_material.html#ac22c4818f6cce75f1791368803195bc4)SetMeshVectorArgument()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Material.SetMeshVectorArgument | ( | float | *x*, |
|  |  | float | *y*, |
|  |  | float | *z*, |
|  |  | float | *w* ) |

[◆](class_tale_worlds_1_1_engine_1_1_material.html#a39a5b09d35679d6f8d2de6a1e208300a)SetTexture()
-------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Material.SetTexture | ( | [MBTextureType](class_tale_worlds_1_1_engine_1_1_material.html#aeaf8132ea5f9376eb525ea637f92e3ac) | *textureType*, |
|  |  | [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) | *texture* ) |

Parameters
:   |  |  |
    | --- | --- |
    | textureType | The texture type. |
    | texture | [Texture](class_tale_worlds_1_1_engine_1_1_texture.html "Representation of 2D texture resource in Mono domain No means of texture copying is provided in this ...") to be assigned to the texture slot specified by 'textureType' |

[◆](class_tale_worlds_1_1_engine_1_1_material.html#a2150872294aa93ed935a92a58779f202)SetTextureAtSlot()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Material.SetTextureAtSlot | ( | int | *textureSlot*, |
|  |  | [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) | *texture* ) |

[◆](class_tale_worlds_1_1_engine_1_1_material.html#a423a3e024162033c7c6271b1c2e972ab)SetAreaMapScale()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Material.SetAreaMapScale | ( | float | *scale* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_material.html#ac12908901e245844fb1f759043bf0836)SetEnableSkinning()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Material.SetEnableSkinning | ( | bool | *enable* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_material.html#a898fb86eaae0fdbe608c0e70e0aa69b0)UsingSkinning()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.Material.UsingSkinning | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_material.html#a91443dfafdc8e783845035a4a771ca87)GetTexture()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) TaleWorlds.Engine.Material.GetTexture | ( | [MBTextureType](class_tale_worlds_1_1_engine_1_1_material.html#aeaf8132ea5f9376eb525ea637f92e3ac) | *textureType* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | textureType | Defines the texture type slot whose texture assignment will be returned |

Returns
:   Returns the texture assigned to 'textureType' slot Returns null if there is no texture assigned to the specified slot

[◆](class_tale_worlds_1_1_engine_1_1_material.html#a6b2e835caf2bfcc4087615ac351a6971)GetTextureWithSlot()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) TaleWorlds.Engine.Material.GetTextureWithSlot | ( | int | *textureSlot* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_material.html#ad22328621693859f6f1bed5778218273)GetAlphaMaskTableauMaterial()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | Material TaleWorlds.Engine.Material.GetAlphaMaskTableauMaterial | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_material.html#a65637331daedb8693306afe35c9b64ee)GetAlphaBlendMode()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MBAlphaBlendMode](class_tale_worlds_1_1_engine_1_1_material.html#a87a30f27a54e0ffb870981896912aff4) TaleWorlds.Engine.Material.GetAlphaBlendMode | ( |  | ) |  |

Returns
:   Returns the alpha blend mode of the material

[◆](class_tale_worlds_1_1_engine_1_1_material.html#a225c215c38382c14f9cfab2f7ec1b14a)SetAlphaBlendMode()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Material.SetAlphaBlendMode | ( | [MBAlphaBlendMode](class_tale_worlds_1_1_engine_1_1_material.html#a87a30f27a54e0ffb870981896912aff4) | *alphaBlendMode* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | alphaBlendMode | The alpha blend mode. |

[◆](class_tale_worlds_1_1_engine_1_1_material.html#a7c611ce42870ae5ef2aee3220b6a056d)SetAlphaTestValue()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Material.SetAlphaTestValue | ( | float | *alphaTestValue* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | alphaTestValue | The alpha blend value, from 0 to 1 |

[◆](class_tale_worlds_1_1_engine_1_1_material.html#a8ac7b7a7a140794ca133fb452caecb08)GetAlphaTestValue()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Engine.Material.GetAlphaTestValue | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_material.html#ae7a212e68fea98a3a0ec8105388a3386)AddMaterialShaderFlag()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Material.AddMaterialShaderFlag | ( | String | *flagName*, |
|  |  | bool | *showErrors* ) |

[◆](class_tale_worlds_1_1_engine_1_1_material.html#aa4d05ca8ab1c3448b055ec95aa487aa3)RemoveMaterialShaderFlag()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Material.RemoveMaterialShaderFlag | ( | String | *flagName* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_engine_1_1_material.html#a2da5239094091a981b16a6d72a76ba9e)Name
-----------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Engine.Material.Name | | getset |

[◆](class_tale_worlds_1_1_engine_1_1_material.html#acf09cfa26361e056b3319f553de83828)UsingSpecular
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Engine.Material.UsingSpecular | | getset |

[◆](class_tale_worlds_1_1_engine_1_1_material.html#a228a4f1449e6fe79be0e6fe6cab4d805)UsingSpecularMap
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Engine.Material.UsingSpecularMap | | getset |

[◆](class_tale_worlds_1_1_engine_1_1_material.html#a42ac3ad636208bb188b505645b35c3b1)UsingEnvironmentMap
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Engine.Material.UsingEnvironmentMap | | getset |

[◆](class_tale_worlds_1_1_engine_1_1_material.html#a7792245d66764401eac3735a56ca020a)UsingSpecularAlpha
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Engine.Material.UsingSpecularAlpha | | getset |

[◆](class_tale_worlds_1_1_engine_1_1_material.html#ad94ce3aac82aa352b156014a8707f503)UsingDynamicLight
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Engine.Material.UsingDynamicLight | | getset |

[◆](class_tale_worlds_1_1_engine_1_1_material.html#a51ffe888f7b289599dc4eff8ff6b7d2c)UsingSunLight
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Engine.Material.UsingSunLight | | getset |

[◆](class_tale_worlds_1_1_engine_1_1_material.html#a5b80a86af693aa01cb1bfe69a9026a1d)UsingFresnel
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Engine.Material.UsingFresnel | | getset |

[◆](class_tale_worlds_1_1_engine_1_1_material.html#a83364d7a6dea946223ae5a85ce52e8d9)IsSunShadowReceiver
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Engine.Material.IsSunShadowReceiver | | getset |

[◆](class_tale_worlds_1_1_engine_1_1_material.html#a8c58d49a4b146eae5fb98d05da6e8882)IsDynamicShadowReceiver
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Engine.Material.IsDynamicShadowReceiver | | getset |

[◆](class_tale_worlds_1_1_engine_1_1_material.html#ac9f0ede880f27b4fe5a7859f85f961e4)UsingDiffuseAlphaMap
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Engine.Material.UsingDiffuseAlphaMap | | getset |

[◆](class_tale_worlds_1_1_engine_1_1_material.html#a664c5fbcdf1a7f2d93e00bbea35ad250)UsingParallaxMapping
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Engine.Material.UsingParallaxMapping | | getset |

[◆](class_tale_worlds_1_1_engine_1_1_material.html#a5e83b17ba83dc435f3e5d5c3cd8dd776)UsingParallaxOcclusion
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Engine.Material.UsingParallaxOcclusion | | getset |

[◆](class_tale_worlds_1_1_engine_1_1_material.html#a6d0ae6d773990cb995ea6a8991cd095c)Flags
------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MaterialFlags](namespace_tale_worlds_1_1_engine.html#aea9426b8effd85f8acc0f1aaab0b29a1) TaleWorlds.Engine.Material.Flags | | getset |

