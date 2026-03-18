--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_wave_floater.html ---

TaleWorlds.MountAndBlade.WaveFloater Class ReferenceInherits [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) | [GetTickRequirement](class_tale_worlds_1_1_mount_and_blade_1_1_wave_floater.html#aa8b7db2fcb7b45948e9c7a5ca519f6b0) () |
| Public Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [SetScriptComponentToTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ae15c963749bd0f9a75bba24a333b39d4) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) tickReq) |
| void | [SetScriptComponentToTickMT](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a9b2183852eb7b70042ed82ef917022c6) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) value) |

|  |  |
| --- | --- |
| Public Attributes | |
| [SimpleButton](class_tale_worlds_1_1_engine_1_1_simple_button.html) | [largeObject](class_tale_worlds_1_1_mount_and_blade_1_1_wave_floater.html#a9abb21be589e1756a67e1bbfea14d2e4) |
| [SimpleButton](class_tale_worlds_1_1_engine_1_1_simple_button.html) | [smallObject](class_tale_worlds_1_1_mount_and_blade_1_1_wave_floater.html#a4950fac88d018cab5dee3eb43054e9d0) |
| bool | [oscillateAtX](class_tale_worlds_1_1_mount_and_blade_1_1_wave_floater.html#aef6bd08255b560bb259e54b6d8907037) |
| bool | [oscillateAtY](class_tale_worlds_1_1_mount_and_blade_1_1_wave_floater.html#a75b0047fa67b7234f42c2e2d3885eeda) |
| bool | [oscillateAtZ](class_tale_worlds_1_1_mount_and_blade_1_1_wave_floater.html#aca1ec919dc72321e4984598bc3b23b71) |
| float | [oscillationFrequency](class_tale_worlds_1_1_mount_and_blade_1_1_wave_floater.html#ac32c9f9b47347d8bdcfe9f598963375f) = 1.0f |
| float | [maxOscillationAngle](class_tale_worlds_1_1_mount_and_blade_1_1_wave_floater.html#a4d44ae68b4cb23f36f8be99affc752ef) = 10f |
| bool | [bounceX](class_tale_worlds_1_1_mount_and_blade_1_1_wave_floater.html#a0ff7351537a7eee9c606676f2eec05bb) |
| float | [bounceXFrequency](class_tale_worlds_1_1_mount_and_blade_1_1_wave_floater.html#a89fd6fe9bce980cdca98923331acc8e0) = 14f |
| float | [maxBounceXDistance](class_tale_worlds_1_1_mount_and_blade_1_1_wave_floater.html#ae0619ca94dbf82dfc4a5b605a6d40f14) = 0.3f |
| bool | [bounceY](class_tale_worlds_1_1_mount_and_blade_1_1_wave_floater.html#a491814f04e7efc10485e74d04ececbe5) |
| float | [bounceYFrequency](class_tale_worlds_1_1_mount_and_blade_1_1_wave_floater.html#a01e52127586afeafb938d0ed3b59dab5) = 14f |
| float | [maxBounceYDistance](class_tale_worlds_1_1_mount_and_blade_1_1_wave_floater.html#a61b581aa5f5266487effd260f06127f8) = 0.3f |
| bool | [bounceZ](class_tale_worlds_1_1_mount_and_blade_1_1_wave_floater.html#a0f6baa8100324a13bee133e5a4d0a831) |
| float | [bounceZFrequency](class_tale_worlds_1_1_mount_and_blade_1_1_wave_floater.html#a1a83c33cca5715b0703f3221ca6c472c) = 14f |
| float | [maxBounceZDistance](class_tale_worlds_1_1_mount_and_blade_1_1_wave_floater.html#aa491a24ca0fdf50ba303da14dc2498de) = 0.3f |

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

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_wave_floater.html#aa8b7db2fcb7b45948e9c7a5ca519f6b0)GetTickRequirement()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) TaleWorlds.MountAndBlade.WaveFloater.GetTickRequirement | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ac17100a83d592505ed8d9ac565e512a5).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_wave_floater.html#a9abb21be589e1756a67e1bbfea14d2e4)largeObject
-------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [SimpleButton](class_tale_worlds_1_1_engine_1_1_simple_button.html) TaleWorlds.MountAndBlade.WaveFloater.largeObject |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_wave_floater.html#a4950fac88d018cab5dee3eb43054e9d0)smallObject
-------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [SimpleButton](class_tale_worlds_1_1_engine_1_1_simple_button.html) TaleWorlds.MountAndBlade.WaveFloater.smallObject |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_wave_floater.html#aef6bd08255b560bb259e54b6d8907037)oscillateAtX
--------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.WaveFloater.oscillateAtX |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_wave_floater.html#a75b0047fa67b7234f42c2e2d3885eeda)oscillateAtY
--------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.WaveFloater.oscillateAtY |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_wave_floater.html#aca1ec919dc72321e4984598bc3b23b71)oscillateAtZ
--------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.WaveFloater.oscillateAtZ |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_wave_floater.html#ac32c9f9b47347d8bdcfe9f598963375f)oscillationFrequency
----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.WaveFloater.oscillationFrequency = 1.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_wave_floater.html#a4d44ae68b4cb23f36f8be99affc752ef)maxOscillationAngle
---------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.WaveFloater.maxOscillationAngle = 10f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_wave_floater.html#a0ff7351537a7eee9c606676f2eec05bb)bounceX
---------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.WaveFloater.bounceX |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_wave_floater.html#a89fd6fe9bce980cdca98923331acc8e0)bounceXFrequency
------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.WaveFloater.bounceXFrequency = 14f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_wave_floater.html#ae0619ca94dbf82dfc4a5b605a6d40f14)maxBounceXDistance
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.WaveFloater.maxBounceXDistance = 0.3f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_wave_floater.html#a491814f04e7efc10485e74d04ececbe5)bounceY
---------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.WaveFloater.bounceY |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_wave_floater.html#a01e52127586afeafb938d0ed3b59dab5)bounceYFrequency
------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.WaveFloater.bounceYFrequency = 14f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_wave_floater.html#a61b581aa5f5266487effd260f06127f8)maxBounceYDistance
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.WaveFloater.maxBounceYDistance = 0.3f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_wave_floater.html#a0f6baa8100324a13bee133e5a4d0a831)bounceZ
---------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.WaveFloater.bounceZ |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_wave_floater.html#a1a83c33cca5715b0703f3221ca6c472c)bounceZFrequency
------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.WaveFloater.bounceZFrequency = 14f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_wave_floater.html#aa491a24ca0fdf50ba303da14dc2498de)maxBounceZDistance
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.WaveFloater.maxBounceZDistance = 0.3f |

