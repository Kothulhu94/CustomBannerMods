--- SOURCE: class_tale_worlds_1_1_engine_1_1_light.html ---

TaleWorlds.Engine.Light Class ReferencesealedInherits [TaleWorlds.Engine.GameEntityComponent](class_tale_worlds_1_1_engine_1_1_game_entity_component.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [ShadowType](class_tale_worlds_1_1_engine_1_1_light.html#a6511807301db43878ae4ae8ece021272) {     [NoShadow](class_tale_worlds_1_1_engine_1_1_light.html#a6511807301db43878ae4ae8ece021272a76677e8b9a173e8a4b96b7067b0153cb) ,     [StaticShadow](class_tale_worlds_1_1_engine_1_1_light.html#a6511807301db43878ae4ae8ece021272a1fc356b2e5d90d0af214243f013af1b3) ,     [DynamicShadow](class_tale_worlds_1_1_engine_1_1_light.html#a6511807301db43878ae4ae8ece021272ae8e7a8e903a57cfe60aac3da82818c73) ,     [Count](class_tale_worlds_1_1_engine_1_1_light.html#a6511807301db43878ae4ae8ece021272ae93f994f01c537c4e2f7d8528c3eb5e9)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [SetShadowType](class_tale_worlds_1_1_engine_1_1_light.html#ac75171969d3768be262494f4056dd03c) ([ShadowType](class_tale_worlds_1_1_engine_1_1_light.html#a6511807301db43878ae4ae8ece021272) type) |
| void | [SetLightFlicker](class_tale_worlds_1_1_engine_1_1_light.html#af94fee9e366193cd8266c94ce734bf76) (float magnitude, float interval) |
| void | [SetVolumetricProperties](class_tale_worlds_1_1_engine_1_1_light.html#a36ea8a5b92e2bf6f85bd23530fe6592e) (bool volumetricLightEnabled, float volumeParameters) |
| void | [Dispose](class_tale_worlds_1_1_engine_1_1_light.html#ad12cce62f6104cedfcb3d0aa3873ca39) () |
| void | [SetVisibility](class_tale_worlds_1_1_engine_1_1_light.html#a2c4761e550754ef74be2b700560037ed) (bool value) |
| Public Member Functions inherited from [TaleWorlds.Engine.GameEntityComponent](class_tale_worlds_1_1_engine_1_1_game_entity_component.html) | |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | [GetEntity](class_tale_worlds_1_1_engine_1_1_game_entity_component.html#aa0b6323b87a63cb1e3ecba9b07328583) () |
| virtual [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | [GetFirstMetaMesh](class_tale_worlds_1_1_engine_1_1_game_entity_component.html#aa70e6c4e14725db6c11c3638d4336c03) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static Light | [CreatePointLight](class_tale_worlds_1_1_engine_1_1_light.html#a62d0415f0bb58947f34c6d5569e2c2b4) (float lightRadius) |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsValid](class_tale_worlds_1_1_engine_1_1_light.html#ac80571c0fadb72ca75ab053cf565a3a6) `[get]` |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [Frame](class_tale_worlds_1_1_engine_1_1_light.html#a450f3961aae2129316cb0e76d619dd5b) `[get, set]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [LightColor](class_tale_worlds_1_1_engine_1_1_light.html#a9c9b28bf1bf5d56e063b2064d6e5475c) `[get, set]` |
| float | [Intensity](class_tale_worlds_1_1_engine_1_1_light.html#a115496e851304e49e0e8e1597ca0eccc) `[get, set]` |
| float | [Radius](class_tale_worlds_1_1_engine_1_1_light.html#a7f48f689df566e904e92eedad61a7857) `[get, set]` |
| bool | [ShadowEnabled](class_tale_worlds_1_1_engine_1_1_light.html#a8470090ae1ad43154f70e75a88457a3d) `[get, set]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_engine_1_1_light.html#a6511807301db43878ae4ae8ece021272)ShadowType
--------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.Engine.Light.ShadowType](class_tale_worlds_1_1_engine_1_1_light.html#a6511807301db43878ae4ae8ece021272) |

| Enumerator | |
| --- | --- |
| NoShadow |  |
| StaticShadow |  |
| DynamicShadow |  |
| Count |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_engine_1_1_light.html#a62d0415f0bb58947f34c6d5569e2c2b4)CreatePointLight()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | Light TaleWorlds.Engine.Light.CreatePointLight | ( | float | *lightRadius* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_light.html#ac75171969d3768be262494f4056dd03c)SetShadowType()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Light.SetShadowType | ( | [ShadowType](class_tale_worlds_1_1_engine_1_1_light.html#a6511807301db43878ae4ae8ece021272) | *type* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_light.html#af94fee9e366193cd8266c94ce734bf76)SetLightFlicker()
---------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Light.SetLightFlicker | ( | float | *magnitude*, |
|  |  | float | *interval* ) |

[◆](class_tale_worlds_1_1_engine_1_1_light.html#a36ea8a5b92e2bf6f85bd23530fe6592e)SetVolumetricProperties()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Light.SetVolumetricProperties | ( | bool | *volumetricLightEnabled*, |
|  |  | float | *volumeParameters* ) |

[◆](class_tale_worlds_1_1_engine_1_1_light.html#ad12cce62f6104cedfcb3d0aa3873ca39)Dispose()
-------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Light.Dispose | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_light.html#a2c4761e550754ef74be2b700560037ed)SetVisibility()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Light.SetVisibility | ( | bool | *value* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_engine_1_1_light.html#ac80571c0fadb72ca75ab053cf565a3a6)IsValid
-----------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Engine.Light.IsValid | | get |

[◆](class_tale_worlds_1_1_engine_1_1_light.html#a450f3961aae2129316cb0e76d619dd5b)Frame
---------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.Engine.Light.Frame | | getset |

[◆](class_tale_worlds_1_1_engine_1_1_light.html#a9c9b28bf1bf5d56e063b2064d6e5475c)LightColor
--------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.Light.LightColor | | getset |

[◆](class_tale_worlds_1_1_engine_1_1_light.html#a115496e851304e49e0e8e1597ca0eccc)Intensity
-------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Engine.Light.Intensity | | getset |

[◆](class_tale_worlds_1_1_engine_1_1_light.html#a7f48f689df566e904e92eedad61a7857)Radius
----------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Engine.Light.Radius | | getset |

[◆](class_tale_worlds_1_1_engine_1_1_light.html#a8470090ae1ad43154f70e75a88457a3d)ShadowEnabled
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Engine.Light.ShadowEnabled | | getset |

