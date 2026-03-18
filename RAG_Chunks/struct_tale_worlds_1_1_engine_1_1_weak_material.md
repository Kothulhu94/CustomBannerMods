--- SOURCE: struct_tale_worlds_1_1_engine_1_1_weak_material.html ---

TaleWorlds.Engine.WeakMaterial Struct Reference|  |  |
| --- | --- |
| Public Member Functions | |
| [Shader](class_tale_worlds_1_1_engine_1_1_shader.html) | [GetShader](struct_tale_worlds_1_1_engine_1_1_weak_material.html#a0ad9aeb4d8e8723aa3bc88d1e437965d) () |
| UInt64 | [GetShaderFlags](struct_tale_worlds_1_1_engine_1_1_weak_material.html#af7e27c042f331da376f31b2b7e550a99) () |
| void | [SetShaderFlags](struct_tale_worlds_1_1_engine_1_1_weak_material.html#ab5892d4976a899d675ae01f1aaf15f1a) (UInt64 flagEntry) |
| void | [SetMeshVectorArgument](struct_tale_worlds_1_1_engine_1_1_weak_material.html#a22e2b9d00684ff1088017a02a1124bf6) (float x, float y, float z, float w) |
| void | [SetTexture](struct_tale_worlds_1_1_engine_1_1_weak_material.html#acdf3bcc95e1e421479c464a6a64bf9e6) ([Material.MBTextureType](class_tale_worlds_1_1_engine_1_1_material.html#aeaf8132ea5f9376eb525ea637f92e3ac) textureType, [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) texture) |
| void | [SetTextureAtSlot](struct_tale_worlds_1_1_engine_1_1_weak_material.html#a5ff526655d5264e8c9eb8082592327b9) (int textureSlot, [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) texture) |
| void | [SetAreaMapScale](struct_tale_worlds_1_1_engine_1_1_weak_material.html#a594bb69cf49402e9f9b9735e22f506e1) (float scale) |
| void | [SetEnableSkinning](struct_tale_worlds_1_1_engine_1_1_weak_material.html#a86520aa317c7a27fd0615962504c70cc) (bool enable) |
| bool | [UsingSkinning](struct_tale_worlds_1_1_engine_1_1_weak_material.html#a1a550897e3d672bae1a99adc007159ff) () |
| [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) | [GetTexture](struct_tale_worlds_1_1_engine_1_1_weak_material.html#af25e7e7e6d924524da1b67d3a5722b04) ([Material.MBTextureType](class_tale_worlds_1_1_engine_1_1_material.html#aeaf8132ea5f9376eb525ea637f92e3ac) textureType) |
| [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) | [GetTextureWithSlot](struct_tale_worlds_1_1_engine_1_1_weak_material.html#a217f2372b844dcbf7ae1aeaf8e1fa50c) (int textureSlot) |
| void | [AddMaterialShaderFlag](struct_tale_worlds_1_1_engine_1_1_weak_material.html#a13b2b3981f9262bfa539d089453956ec) (String flagName, bool showErrors) |
| void | [RemoveMaterialShaderFlag](struct_tale_worlds_1_1_engine_1_1_weak_material.html#af2f7ccec64366284db0a8438c7f362f7) (String flagName) |
| override bool | [Equals](struct_tale_worlds_1_1_engine_1_1_weak_material.html#aba19a439b39791927cb8f2c89ea0141e) (object obj) |
| override int | [GetHashCode](struct_tale_worlds_1_1_engine_1_1_weak_material.html#a38de357de5942f4aace41d90c3ea5ba3) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static bool | [operator==](struct_tale_worlds_1_1_engine_1_1_weak_material.html#a71aadcad38e972f42446786b76e2f5ab) (WeakMaterial weakMaterial1, WeakMaterial weakMaterial2) |
| static bool | [operator!=](struct_tale_worlds_1_1_engine_1_1_weak_material.html#af94218a564eca727d46f89659aca8cb1) (WeakMaterial weakMaterial1, WeakMaterial weakMaterial2) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static readonly WeakMaterial | [Invalid](struct_tale_worlds_1_1_engine_1_1_weak_material.html#aab9b3a472f6bbdc0826316aad6d871da) = new WeakMaterial(UIntPtr.Zero) |

|  |  |
| --- | --- |
| Properties | |
| UIntPtr | [Pointer](struct_tale_worlds_1_1_engine_1_1_weak_material.html#acab351c81019f4568b5c4ec9b3fb2b4c) `[get]` |
| bool | [IsValid](struct_tale_worlds_1_1_engine_1_1_weak_material.html#aecbd5cfc768fa66eff5de1f5e319aadf) `[get]` |
| string | [Name](struct_tale_worlds_1_1_engine_1_1_weak_material.html#a4c9272fe1c9c559f1ee1337ce034e78d) `[get, set]` |
|  | Gets Name of the material This property is read only. |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_engine_1_1_weak_material.html#a0ad9aeb4d8e8723aa3bc88d1e437965d)GetShader()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Shader](class_tale_worlds_1_1_engine_1_1_shader.html) TaleWorlds.Engine.WeakMaterial.GetShader | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_material.html#af7e27c042f331da376f31b2b7e550a99)GetShaderFlags()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| UInt64 TaleWorlds.Engine.WeakMaterial.GetShaderFlags | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_material.html#ab5892d4976a899d675ae01f1aaf15f1a)SetShaderFlags()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakMaterial.SetShaderFlags | ( | UInt64 | *flagEntry* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_material.html#a22e2b9d00684ff1088017a02a1124bf6)SetMeshVectorArgument()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakMaterial.SetMeshVectorArgument | ( | float | *x*, |
|  |  | float | *y*, |
|  |  | float | *z*, |
|  |  | float | *w* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_material.html#acdf3bcc95e1e421479c464a6a64bf9e6)SetTexture()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakMaterial.SetTexture | ( | [Material.MBTextureType](class_tale_worlds_1_1_engine_1_1_material.html#aeaf8132ea5f9376eb525ea637f92e3ac) | *textureType*, |
|  |  | [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) | *texture* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_material.html#a5ff526655d5264e8c9eb8082592327b9)SetTextureAtSlot()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakMaterial.SetTextureAtSlot | ( | int | *textureSlot*, |
|  |  | [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) | *texture* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_material.html#a594bb69cf49402e9f9b9735e22f506e1)SetAreaMapScale()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakMaterial.SetAreaMapScale | ( | float | *scale* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_material.html#a86520aa317c7a27fd0615962504c70cc)SetEnableSkinning()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakMaterial.SetEnableSkinning | ( | bool | *enable* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_material.html#a1a550897e3d672bae1a99adc007159ff)UsingSkinning()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.WeakMaterial.UsingSkinning | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_material.html#af25e7e7e6d924524da1b67d3a5722b04)GetTexture()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) TaleWorlds.Engine.WeakMaterial.GetTexture | ( | [Material.MBTextureType](class_tale_worlds_1_1_engine_1_1_material.html#aeaf8132ea5f9376eb525ea637f92e3ac) | *textureType* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_material.html#a217f2372b844dcbf7ae1aeaf8e1fa50c)GetTextureWithSlot()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) TaleWorlds.Engine.WeakMaterial.GetTextureWithSlot | ( | int | *textureSlot* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_material.html#a13b2b3981f9262bfa539d089453956ec)AddMaterialShaderFlag()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakMaterial.AddMaterialShaderFlag | ( | String | *flagName*, |
|  |  | bool | *showErrors* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_material.html#af2f7ccec64366284db0a8438c7f362f7)RemoveMaterialShaderFlag()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WeakMaterial.RemoveMaterialShaderFlag | ( | String | *flagName* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_material.html#a71aadcad38e972f42446786b76e2f5ab)operator==()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Engine.WeakMaterial.operator== | ( | WeakMaterial | *weakMaterial1*, | |  |  | WeakMaterial | *weakMaterial2* ) | | static |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_material.html#af94218a564eca727d46f89659aca8cb1)operator!=()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Engine.WeakMaterial.operator!= | ( | WeakMaterial | *weakMaterial1*, | |  |  | WeakMaterial | *weakMaterial2* ) | | static |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_material.html#aba19a439b39791927cb8f2c89ea0141e)Equals()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.Engine.WeakMaterial.Equals | ( | object | *obj* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_material.html#a38de357de5942f4aace41d90c3ea5ba3)GetHashCode()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.Engine.WeakMaterial.GetHashCode | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](struct_tale_worlds_1_1_engine_1_1_weak_material.html#aab9b3a472f6bbdc0826316aad6d871da)Invalid
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly WeakMaterial TaleWorlds.Engine.WeakMaterial.Invalid = new WeakMaterial(UIntPtr.Zero) | | static |

Property Documentation
----------------------

[◆](struct_tale_worlds_1_1_engine_1_1_weak_material.html#acab351c81019f4568b5c4ec9b3fb2b4c)Pointer
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | UIntPtr TaleWorlds.Engine.WeakMaterial.Pointer | | get |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_material.html#aecbd5cfc768fa66eff5de1f5e319aadf)IsValid
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Engine.WeakMaterial.IsValid | | get |

[◆](struct_tale_worlds_1_1_engine_1_1_weak_material.html#a4c9272fe1c9c559f1ee1337ce034e78d)Name
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Engine.WeakMaterial.Name | | getset |

