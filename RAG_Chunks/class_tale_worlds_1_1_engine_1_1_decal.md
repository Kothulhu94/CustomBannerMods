--- SOURCE: class_tale_worlds_1_1_engine_1_1_decal.html ---

TaleWorlds.Engine.Decal Class ReferencesealedInherits [TaleWorlds.Engine.GameEntityComponent](class_tale_worlds_1_1_engine_1_1_game_entity_component.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| Decal | [CreateCopy](class_tale_worlds_1_1_engine_1_1_decal.html#afe24a14e7483b7f1d9805c44e4505766) () |
| void | [CheckAndRegisterToDecalSet](class_tale_worlds_1_1_engine_1_1_decal.html#a412601d13a8fa1626201f361234a6231) () |
| void | [SetIsVisible](class_tale_worlds_1_1_engine_1_1_decal.html#a88e6cb4289c8a63922fcab116b5615b1) (bool value) |
| uint | [GetFactor1](class_tale_worlds_1_1_engine_1_1_decal.html#ad0c62610cf6fd021081da399617ae3b4) () |
| void | [OverrideRoadBoundaryP0](class_tale_worlds_1_1_engine_1_1_decal.html#a38a1c6e434cac11243660b034db69331) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) data) |
| void | [OverrideRoadBoundaryP1](class_tale_worlds_1_1_engine_1_1_decal.html#a1ef603e4dd9ad3e23f774b1bcb6698c5) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) data) |
| void | [SetFactor1Linear](class_tale_worlds_1_1_engine_1_1_decal.html#abdbb0c5d9d2765f236f39f2579aa3429) (uint linearFactorColor1) |
| void | [SetFactor1](class_tale_worlds_1_1_engine_1_1_decal.html#aaa0df055a08478895311f522f1d22426) (uint factorColor1) |
| void | [SetAlpha](class_tale_worlds_1_1_engine_1_1_decal.html#a5bd2abadb14be11915ef41d75aed0d52) (float alpha) |
| void | [SetVectorArgument](class_tale_worlds_1_1_engine_1_1_decal.html#aadacb89863fbf716eace572139ddb38c) (float vectorArgument0, float vectorArgument1, float vectorArgument2, float vectorArgument3) |
| void | [SetVectorArgument2](class_tale_worlds_1_1_engine_1_1_decal.html#a53f0b7f37f6651069dd121b551361b30) (float vectorArgument0, float vectorArgument1, float vectorArgument2, float vectorArgument3) |
| [Material](class_tale_worlds_1_1_engine_1_1_material.html) | [GetMaterial](class_tale_worlds_1_1_engine_1_1_decal.html#a42ca1389dd400f2c42f8404b7b8bea6c) () |
| void | [SetMaterial](class_tale_worlds_1_1_engine_1_1_decal.html#ac2d72aa4f23087f80f75fa4143619b3a) ([Material](class_tale_worlds_1_1_engine_1_1_material.html) material) |
| void | [SetFrame](class_tale_worlds_1_1_engine_1_1_decal.html#ab19201aceff3a6fd05ea4f9c065d82e9) ([MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) [Frame](class_tale_worlds_1_1_engine_1_1_decal.html#a7801bdaca3607b05f11cfe55d8cf1d24)) |
| Public Member Functions inherited from [TaleWorlds.Engine.GameEntityComponent](class_tale_worlds_1_1_engine_1_1_game_entity_component.html) | |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | [GetEntity](class_tale_worlds_1_1_engine_1_1_game_entity_component.html#aa0b6323b87a63cb1e3ecba9b07328583) () |
| virtual [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | [GetFirstMetaMesh](class_tale_worlds_1_1_engine_1_1_game_entity_component.html#aa70e6c4e14725db6c11c3638d4336c03) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static Decal | [CreateDecal](class_tale_worlds_1_1_engine_1_1_decal.html#a1fd32e07df1f5f3ff67527821b3f5863) (string name=null) |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsValid](class_tale_worlds_1_1_engine_1_1_decal.html#afc8c600cae4aa33d6d5cf58fe21b0049) `[get]` |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [Frame](class_tale_worlds_1_1_engine_1_1_decal.html#a7801bdaca3607b05f11cfe55d8cf1d24) `[get, set]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_engine_1_1_decal.html#a1fd32e07df1f5f3ff67527821b3f5863)CreateDecal()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | Decal TaleWorlds.Engine.Decal.CreateDecal | ( | string | *name* = null | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_decal.html#afe24a14e7483b7f1d9805c44e4505766)CreateCopy()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| Decal TaleWorlds.Engine.Decal.CreateCopy | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_decal.html#a412601d13a8fa1626201f361234a6231)CheckAndRegisterToDecalSet()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Decal.CheckAndRegisterToDecalSet | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_decal.html#a88e6cb4289c8a63922fcab116b5615b1)SetIsVisible()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Decal.SetIsVisible | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_decal.html#ad0c62610cf6fd021081da399617ae3b4)GetFactor1()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| uint TaleWorlds.Engine.Decal.GetFactor1 | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_decal.html#a38a1c6e434cac11243660b034db69331)OverrideRoadBoundaryP0()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Decal.OverrideRoadBoundaryP0 | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *data* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_decal.html#a1ef603e4dd9ad3e23f774b1bcb6698c5)OverrideRoadBoundaryP1()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Decal.OverrideRoadBoundaryP1 | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *data* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_decal.html#abdbb0c5d9d2765f236f39f2579aa3429)SetFactor1Linear()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Decal.SetFactor1Linear | ( | uint | *linearFactorColor1* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_decal.html#aaa0df055a08478895311f522f1d22426)SetFactor1()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Decal.SetFactor1 | ( | uint | *factorColor1* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_decal.html#a5bd2abadb14be11915ef41d75aed0d52)SetAlpha()
--------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Decal.SetAlpha | ( | float | *alpha* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_decal.html#aadacb89863fbf716eace572139ddb38c)SetVectorArgument()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Decal.SetVectorArgument | ( | float | *vectorArgument0*, |
|  |  | float | *vectorArgument1*, |
|  |  | float | *vectorArgument2*, |
|  |  | float | *vectorArgument3* ) |

[◆](class_tale_worlds_1_1_engine_1_1_decal.html#a53f0b7f37f6651069dd121b551361b30)SetVectorArgument2()
------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Decal.SetVectorArgument2 | ( | float | *vectorArgument0*, |
|  |  | float | *vectorArgument1*, |
|  |  | float | *vectorArgument2*, |
|  |  | float | *vectorArgument3* ) |

[◆](class_tale_worlds_1_1_engine_1_1_decal.html#a42ca1389dd400f2c42f8404b7b8bea6c)GetMaterial()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Material](class_tale_worlds_1_1_engine_1_1_material.html) TaleWorlds.Engine.Decal.GetMaterial | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_decal.html#ac2d72aa4f23087f80f75fa4143619b3a)SetMaterial()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Decal.SetMaterial | ( | [Material](class_tale_worlds_1_1_engine_1_1_material.html) | *material* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_decal.html#ab19201aceff3a6fd05ea4f9c065d82e9)SetFrame()
--------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Decal.SetFrame | ( | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *Frame* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_engine_1_1_decal.html#afc8c600cae4aa33d6d5cf58fe21b0049)IsValid
-----------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Engine.Decal.IsValid | | get |

[◆](class_tale_worlds_1_1_engine_1_1_decal.html#a7801bdaca3607b05f11cfe55d8cf1d24)Frame
---------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.Engine.Decal.Frame | | getset |

