--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_wind_mill.html ---

TaleWorlds.MountAndBlade.WindMill Class ReferenceInherits [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) | [GetTickRequirement](class_tale_worlds_1_1_mount_and_blade_1_1_wind_mill.html#a2e2ca05727d8aa3db19c3d880fbda2bd) () |
| Public Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [SetScriptComponentToTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ae15c963749bd0f9a75bba24a333b39d4) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) tickReq) |
| void | [SetScriptComponentToTickMT](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a9b2183852eb7b70042ed82ef917022c6) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) value) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static int | [GetIntegerFromStringEnd](class_tale_worlds_1_1_mount_and_blade_1_1_wind_mill.html#a461ca1162b0f13d055f7c900dc90f24d) (string str) |

|  |  |
| --- | --- |
| Public Attributes | |
| float | [rotationSpeed](class_tale_worlds_1_1_mount_and_blade_1_1_wind_mill.html#adaa37ce217dc762c132f3c5794ae83cd) = 100 |
| float | [waterSplashPhaseOffset](class_tale_worlds_1_1_mount_and_blade_1_1_wind_mill.html#a3aa6cc6877221ba590728fc37166052b) |
| float | [waterSplashIntervalMultiplier](class_tale_worlds_1_1_mount_and_blade_1_1_wind_mill.html#a68f1196c396782d79f11a862a5c74b00) = 1.0f |
| [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | [testMesh](class_tale_worlds_1_1_mount_and_blade_1_1_wind_mill.html#a323269a924eb0ad38ad67a0fd37d09f4) |
| [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) | [testTexture](class_tale_worlds_1_1_mount_and_blade_1_1_wind_mill.html#a48c3f9b37b512af4e6a8267e9cafc687) |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0a02cc65cc567db6101ea4afa275ff36) | [testEntity](class_tale_worlds_1_1_mount_and_blade_1_1_wind_mill.html#af0180ed94bf606305a1d961a750b47af) |
| bool | [isWaterMill](class_tale_worlds_1_1_mount_and_blade_1_1_wind_mill.html#ae68962074635a748c65495104b460263) = false |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Types inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| enum | [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) : uint {     [None](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da6adf97f83acf6453d4a6a4b1070f3754) = 0x00000000 ,     [TickOccasionally](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da9cee052f50afabfc1098c1aa6af80b75) = 0x00000001 ,     [Tick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0b3516a5bbb77566f904f9d3877f4710) = 0x00000002 ,     [TickParallel](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da5f5a8f4b9ce783164665db4d70e03ee3) = 0x00000004 ,     [TickParallel2](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0ea9f0c260cdfd8b20ce19a48dbc329f) = 0x00000008 ,     [FixedTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154dadd067942f0b8cc66859698bc9711ba15) = 0x00000010 ,     [FixedParallelTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daa226d712a5ffd8d400f850393ff68492) = 0x00000020 ,     [TickParallel3](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daf785c2c005d708ea434168efc10611b8) = 0x00000040   } |
| Protected Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [InvalidateWeakPointersIfValid](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#af39d73d0c78790ba81a40a5a350c0526) () |
|  | [ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0bc136bb53989f2b9a4f23f12f54a332) () |
| virtual void | [OnRemoved](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a4778f913080fc216866daa15518c8ecd) (int removeReason) |
| Properties inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | [GameEntity](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0a02cc65cc567db6101ea4afa275ff36) `[get]` |
| [ManagedScriptComponent](class_tale_worlds_1_1_engine_1_1_managed_script_component.html) | [ScriptComponent](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a8d7c5772e6b456b1e22ccd46a0b391ce) `[get]` |
| ManagedScriptHolder | [ManagedScriptHolder](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a58417dd71bf3daca6eb58df177617c2d) `[get]` |
| Scene | [Scene](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a9d7d5b77582948847f1d1c532face2c8) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_wind_mill.html#a461ca1162b0f13d055f7c900dc90f24d)GetIntegerFromStringEnd()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.WindMill.GetIntegerFromStringEnd | ( | string | *str* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_wind_mill.html#a2e2ca05727d8aa3db19c3d880fbda2bd)GetTickRequirement()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) TaleWorlds.MountAndBlade.WindMill.GetTickRequirement | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ac17100a83d592505ed8d9ac565e512a5).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_wind_mill.html#adaa37ce217dc762c132f3c5794ae83cd)rotationSpeed
------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.WindMill.rotationSpeed = 100 |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_wind_mill.html#a3aa6cc6877221ba590728fc37166052b)waterSplashPhaseOffset
---------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.WindMill.waterSplashPhaseOffset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_wind_mill.html#a68f1196c396782d79f11a862a5c74b00)waterSplashIntervalMultiplier
----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.WindMill.waterSplashIntervalMultiplier = 1.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_wind_mill.html#a323269a924eb0ad38ad67a0fd37d09f4)testMesh
-------------------------------------------------------------------------------------------------------

|  |
| --- |
| [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) TaleWorlds.MountAndBlade.WindMill.testMesh |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_wind_mill.html#a48c3f9b37b512af4e6a8267e9cafc687)testTexture
----------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) TaleWorlds.MountAndBlade.WindMill.testTexture |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_wind_mill.html#af0180ed94bf606305a1d961a750b47af)testEntity
---------------------------------------------------------------------------------------------------------

|  |
| --- |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0a02cc65cc567db6101ea4afa275ff36) TaleWorlds.MountAndBlade.WindMill.testEntity |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_wind_mill.html#ae68962074635a748c65495104b460263)isWaterMill
----------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.WindMill.isWaterMill = false |

