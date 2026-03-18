--- SOURCE: class_tale_worlds_1_1_engine_1_1_composite_component.html ---

TaleWorlds.Engine.CompositeComponent Class ReferencesealedInherits [TaleWorlds.Engine.GameEntityComponent](class_tale_worlds_1_1_engine_1_1_game_entity_component.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| CompositeComponent | [CreateCopy](class_tale_worlds_1_1_engine_1_1_composite_component.html#aa21e2161f19f4e4a1316c028a671fe92) () |
| void | [AddComponent](class_tale_worlds_1_1_engine_1_1_composite_component.html#a10aaa38afb4fce856f043a907f838639) (GameEntityComponent component) |
| void | [AddPrefabEntity](class_tale_worlds_1_1_engine_1_1_composite_component.html#a3c8ea681f8562f6180108155cb4e2e7d) (string prefabName, [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) scene) |
| void | [Dispose](class_tale_worlds_1_1_engine_1_1_composite_component.html#aedccc3d664d4a8e759199ba3b35eaaa2) () |
| uint | [GetFactor1](class_tale_worlds_1_1_engine_1_1_composite_component.html#a908814c1c1a74a0f05281646d5463a4b) () |
| uint | [GetFactor2](class_tale_worlds_1_1_engine_1_1_composite_component.html#aa928362d6a7f71e1f545d57b34ef3102) () |
| void | [SetFactor1](class_tale_worlds_1_1_engine_1_1_composite_component.html#add8308bdf79536d6f2084977b17cbe4d) (uint factorColor1) |
| void | [SetFactor2](class_tale_worlds_1_1_engine_1_1_composite_component.html#a2d4bf620967f8c947b48f7ca140bd271) (uint factorColor2) |
| void | [SetVectorArgument](class_tale_worlds_1_1_engine_1_1_composite_component.html#a15ca4533733534025f902dda2890c93f) (float vectorArgument0, float vectorArgument1, float vectorArgument2, float vectorArgument3) |
| void | [SetMaterial](class_tale_worlds_1_1_engine_1_1_composite_component.html#a2f96a10c21d0c3733bf106473a4fca4c) ([Material](class_tale_worlds_1_1_engine_1_1_material.html) material) |
| void | [SetVisibilityMask](class_tale_worlds_1_1_engine_1_1_composite_component.html#a0293bd2a0ea2d38eebbc7d9fe5c0dca8) ([VisibilityMaskFlags](namespace_tale_worlds_1_1_engine.html#a4f08a181fb3293a5be29538dca70d788) visibilityMask) |
| override [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | [GetFirstMetaMesh](class_tale_worlds_1_1_engine_1_1_composite_component.html#a91e8ff1964a6a0f2987d4fefb59b638c) () |
| void | [AddMultiMesh](class_tale_worlds_1_1_engine_1_1_composite_component.html#ab3c37926d14c021f3600d859ecd8406f) (string MultiMeshName) |
| void | [SetVisible](class_tale_worlds_1_1_engine_1_1_composite_component.html#a2a26495174be58f7082e6c9a0b70ddc1) (bool visible) |
| bool | [GetVisible](class_tale_worlds_1_1_engine_1_1_composite_component.html#abeb3aacff150a267541865a2574540f5) () |
| Public Member Functions inherited from [TaleWorlds.Engine.GameEntityComponent](class_tale_worlds_1_1_engine_1_1_game_entity_component.html) | |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | [GetEntity](class_tale_worlds_1_1_engine_1_1_game_entity_component.html#aa0b6323b87a63cb1e3ecba9b07328583) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static bool | [IsNull](class_tale_worlds_1_1_engine_1_1_composite_component.html#a1e6fa07864204a8d5e910f677da95f27) (CompositeComponent component) |
| static CompositeComponent | [CreateCompositeComponent](class_tale_worlds_1_1_engine_1_1_composite_component.html#a5de3a61f3a0c7ecbb286d417678ed19a) () |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsValid](class_tale_worlds_1_1_engine_1_1_composite_component.html#a6a87f849224098989e3079b7dbd6c2cc) `[get]` |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [Frame](class_tale_worlds_1_1_engine_1_1_composite_component.html#ad7b61284ffc1bed238244c446c4139a0) `[get, set]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [VectorUserData](class_tale_worlds_1_1_engine_1_1_composite_component.html#a4b17d22ad407f71a8ce42667931264b8) `[get, set]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_engine_1_1_composite_component.html#a1e6fa07864204a8d5e910f677da95f27)IsNull()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.CompositeComponent.IsNull | ( | CompositeComponent | *component* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_composite_component.html#a5de3a61f3a0c7ecbb286d417678ed19a)CreateCompositeComponent()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | CompositeComponent TaleWorlds.Engine.CompositeComponent.CreateCompositeComponent | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_composite_component.html#aa21e2161f19f4e4a1316c028a671fe92)CreateCopy()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| CompositeComponent TaleWorlds.Engine.CompositeComponent.CreateCopy | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_composite_component.html#a10aaa38afb4fce856f043a907f838639)AddComponent()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.CompositeComponent.AddComponent | ( | GameEntityComponent | *component* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_composite_component.html#a3c8ea681f8562f6180108155cb4e2e7d)AddPrefabEntity()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.CompositeComponent.AddPrefabEntity | ( | string | *prefabName*, |
|  |  | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *scene* ) |

[◆](class_tale_worlds_1_1_engine_1_1_composite_component.html#aedccc3d664d4a8e759199ba3b35eaaa2)Dispose()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.CompositeComponent.Dispose | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_composite_component.html#a908814c1c1a74a0f05281646d5463a4b)GetFactor1()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| uint TaleWorlds.Engine.CompositeComponent.GetFactor1 | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_composite_component.html#aa928362d6a7f71e1f545d57b34ef3102)GetFactor2()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| uint TaleWorlds.Engine.CompositeComponent.GetFactor2 | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_composite_component.html#add8308bdf79536d6f2084977b17cbe4d)SetFactor1()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.CompositeComponent.SetFactor1 | ( | uint | *factorColor1* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_composite_component.html#a2d4bf620967f8c947b48f7ca140bd271)SetFactor2()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.CompositeComponent.SetFactor2 | ( | uint | *factorColor2* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_composite_component.html#a15ca4533733534025f902dda2890c93f)SetVectorArgument()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.CompositeComponent.SetVectorArgument | ( | float | *vectorArgument0*, |
|  |  | float | *vectorArgument1*, |
|  |  | float | *vectorArgument2*, |
|  |  | float | *vectorArgument3* ) |

[◆](class_tale_worlds_1_1_engine_1_1_composite_component.html#a2f96a10c21d0c3733bf106473a4fca4c)SetMaterial()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.CompositeComponent.SetMaterial | ( | [Material](class_tale_worlds_1_1_engine_1_1_material.html) | *material* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_composite_component.html#a0293bd2a0ea2d38eebbc7d9fe5c0dca8)SetVisibilityMask()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.CompositeComponent.SetVisibilityMask | ( | [VisibilityMaskFlags](namespace_tale_worlds_1_1_engine.html#a4f08a181fb3293a5be29538dca70d788) | *visibilityMask* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_composite_component.html#a91e8ff1964a6a0f2987d4fefb59b638c)GetFirstMetaMesh()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) TaleWorlds.Engine.CompositeComponent.GetFirstMetaMesh | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Engine.GameEntityComponent](class_tale_worlds_1_1_engine_1_1_game_entity_component.html#aa70e6c4e14725db6c11c3638d4336c03).

[◆](class_tale_worlds_1_1_engine_1_1_composite_component.html#ab3c37926d14c021f3600d859ecd8406f)AddMultiMesh()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.CompositeComponent.AddMultiMesh | ( | string | *MultiMeshName* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_composite_component.html#a2a26495174be58f7082e6c9a0b70ddc1)SetVisible()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.CompositeComponent.SetVisible | ( | bool | *visible* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_composite_component.html#abeb3aacff150a267541865a2574540f5)GetVisible()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.CompositeComponent.GetVisible | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_engine_1_1_composite_component.html#a6a87f849224098989e3079b7dbd6c2cc)IsValid
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Engine.CompositeComponent.IsValid | | get |

[◆](class_tale_worlds_1_1_engine_1_1_composite_component.html#ad7b61284ffc1bed238244c446c4139a0)Frame
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.Engine.CompositeComponent.Frame | | getset |

[◆](class_tale_worlds_1_1_engine_1_1_composite_component.html#a4b17d22ad407f71a8ce42667931264b8)VectorUserData
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.CompositeComponent.VectorUserData | | getset |

