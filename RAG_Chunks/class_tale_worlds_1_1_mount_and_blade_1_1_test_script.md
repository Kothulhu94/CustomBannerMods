--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_test_script.html ---

TaleWorlds.MountAndBlade.TestScript Class ReferenceInherits [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) | [GetTickRequirement](class_tale_worlds_1_1_mount_and_blade_1_1_test_script.html#ad8488f5c72cd507af94460f94d9a78a9) () |
| Public Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [SetScriptComponentToTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ae15c963749bd0f9a75bba24a333b39d4) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) tickReq) |
| void | [SetScriptComponentToTickMT](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a9b2183852eb7b70042ed82ef917022c6) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) value) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static int | [GetIntegerFromStringEnd](class_tale_worlds_1_1_mount_and_blade_1_1_test_script.html#ab1d6b6b2891d7dea45e551e82b4ebe1f) (string str) |

|  |  |
| --- | --- |
| Public Attributes | |
| string | [testString](class_tale_worlds_1_1_mount_and_blade_1_1_test_script.html#a97163e6f983cc9411d91f9e1affcfb4d) |
| float | [rotationSpeed](class_tale_worlds_1_1_mount_and_blade_1_1_test_script.html#a2cf55a598cd35376b4bbf4ca6cb04255) = 0 |
| float | [waterSplashPhaseOffset](class_tale_worlds_1_1_mount_and_blade_1_1_test_script.html#a55b5a617608c09d3177a44a9457da0ac) |
| float | [waterSplashIntervalMultiplier](class_tale_worlds_1_1_mount_and_blade_1_1_test_script.html#acf7c6d1a5783a411d78eab452cf3dfd8) = 1.0f |
| bool | [isWaterMill](class_tale_worlds_1_1_mount_and_blade_1_1_test_script.html#a28cb7764de05eab33f3877370adc52dd) = false |
| float | [MoveAxisX](class_tale_worlds_1_1_mount_and_blade_1_1_test_script.html#ac7022e5cc6b781856e181d88c273f0e5) = 1.0f |
| float | [MoveAxisY](class_tale_worlds_1_1_mount_and_blade_1_1_test_script.html#a4582725366898e8c7eff13035c197abc) = 0.0f |
| float | [MoveAxisZ](class_tale_worlds_1_1_mount_and_blade_1_1_test_script.html#ae5cc67e2ec8644558513ed5f6006699f) = 0.0f |
| float | [MoveSpeed](class_tale_worlds_1_1_mount_and_blade_1_1_test_script.html#aba026704cfae1ec7cdac269a0750db8a) = 0.0001f |
| float | [MoveDistance](class_tale_worlds_1_1_mount_and_blade_1_1_test_script.html#a8848739e76da271e69f61899de335c23) = 10.0f |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0a02cc65cc567db6101ea4afa275ff36) | [sideRotatingEntity](class_tale_worlds_1_1_mount_and_blade_1_1_test_script.html#afd19fe6bcf9182d7082ae4483686c42e) |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0a02cc65cc567db6101ea4afa275ff36) | [forwardRotatingEntity](class_tale_worlds_1_1_mount_and_blade_1_1_test_script.html#a1b11f11f9686e3dc0a2dd2ef4e325e04) |

|  |  |
| --- | --- |
| Protected Attributes | |
| float | [MoveDirection](class_tale_worlds_1_1_mount_and_blade_1_1_test_script.html#afb0e0bd283b75ab5360841edf0d1ca21) = 1.0f |
| float | [CurrentDistance](class_tale_worlds_1_1_mount_and_blade_1_1_test_script.html#a64cecbed011220db4b18badcea1a5470) = 0.0f |

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

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_test_script.html#ab1d6b6b2891d7dea45e551e82b4ebe1f)GetIntegerFromStringEnd()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.TestScript.GetIntegerFromStringEnd | ( | string | *str* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_test_script.html#ad8488f5c72cd507af94460f94d9a78a9)GetTickRequirement()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) TaleWorlds.MountAndBlade.TestScript.GetTickRequirement | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ac17100a83d592505ed8d9ac565e512a5).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_test_script.html#a97163e6f983cc9411d91f9e1affcfb4d)testString
-----------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.TestScript.testString |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_test_script.html#a2cf55a598cd35376b4bbf4ca6cb04255)rotationSpeed
--------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.TestScript.rotationSpeed = 0 |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_test_script.html#a55b5a617608c09d3177a44a9457da0ac)waterSplashPhaseOffset
-----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.TestScript.waterSplashPhaseOffset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_test_script.html#acf7c6d1a5783a411d78eab452cf3dfd8)waterSplashIntervalMultiplier
------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.TestScript.waterSplashIntervalMultiplier = 1.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_test_script.html#a28cb7764de05eab33f3877370adc52dd)isWaterMill
------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.TestScript.isWaterMill = false |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_test_script.html#ac7022e5cc6b781856e181d88c273f0e5)MoveAxisX
----------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.TestScript.MoveAxisX = 1.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_test_script.html#a4582725366898e8c7eff13035c197abc)MoveAxisY
----------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.TestScript.MoveAxisY = 0.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_test_script.html#ae5cc67e2ec8644558513ed5f6006699f)MoveAxisZ
----------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.TestScript.MoveAxisZ = 0.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_test_script.html#aba026704cfae1ec7cdac269a0750db8a)MoveSpeed
----------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.TestScript.MoveSpeed = 0.0001f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_test_script.html#a8848739e76da271e69f61899de335c23)MoveDistance
-------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.TestScript.MoveDistance = 10.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_test_script.html#afb0e0bd283b75ab5360841edf0d1ca21)MoveDirection
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.TestScript.MoveDirection = 1.0f | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_test_script.html#a64cecbed011220db4b18badcea1a5470)CurrentDistance
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.TestScript.CurrentDistance = 0.0f | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_test_script.html#afd19fe6bcf9182d7082ae4483686c42e)sideRotatingEntity
-------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0a02cc65cc567db6101ea4afa275ff36) TaleWorlds.MountAndBlade.TestScript.sideRotatingEntity |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_test_script.html#a1b11f11f9686e3dc0a2dd2ef4e325e04)forwardRotatingEntity
----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0a02cc65cc567db6101ea4afa275ff36) TaleWorlds.MountAndBlade.TestScript.forwardRotatingEntity |

