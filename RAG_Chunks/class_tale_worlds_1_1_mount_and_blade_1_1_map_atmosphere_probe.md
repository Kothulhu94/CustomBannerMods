--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_map_atmosphere_probe.html ---

TaleWorlds.MountAndBlade.MapAtmosphereProbe Class ReferenceInherits [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| float | [GetInfluenceAmount](class_tale_worlds_1_1_mount_and_blade_1_1_map_atmosphere_probe.html#a7d9502dad8134b15e764e86b58888bde) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) worldPosition) |
|  | [MapAtmosphereProbe](class_tale_worlds_1_1_mount_and_blade_1_1_map_atmosphere_probe.html#aeab2e91a904cd69b484c0b4f5469f604) () |
| Public Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [SetScriptComponentToTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ae15c963749bd0f9a75bba24a333b39d4) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) tickReq) |
| void | [SetScriptComponentToTickMT](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a9b2183852eb7b70042ed82ef917022c6) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) value) |
| virtual [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) | [GetTickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ac17100a83d592505ed8d9ac565e512a5) () |

|  |  |
| --- | --- |
| Public Attributes | |
| bool | [visualizeRadius](class_tale_worlds_1_1_mount_and_blade_1_1_map_atmosphere_probe.html#a5d9a6d3c3b7c108bac78c9bce30e2dde) = true |
| bool | [hideAllProbes](class_tale_worlds_1_1_mount_and_blade_1_1_map_atmosphere_probe.html#a837f3290d5a2535f9075edc6c11aa166) = true |
| float | [minRadius](class_tale_worlds_1_1_mount_and_blade_1_1_map_atmosphere_probe.html#a937ae74d31f12ddfa0ce1574cf37dd46) = 1 |
| float | [maxRadius](class_tale_worlds_1_1_mount_and_blade_1_1_map_atmosphere_probe.html#af9d9a053cfa62819b4bbace7d0d34462) = 2 |
| float | [rainDensity](class_tale_worlds_1_1_mount_and_blade_1_1_map_atmosphere_probe.html#a47fce370e80e36ef04d72674a495640a) = 0.0f |
| float | [temperature](class_tale_worlds_1_1_mount_and_blade_1_1_map_atmosphere_probe.html#a751f59bac57f3d67bb46d62c6770cd04) = 0.0f |
| string | [atmosphereType](class_tale_worlds_1_1_mount_and_blade_1_1_map_atmosphere_probe.html#a90cef6322c59f5b6c34129e0a8836aa3) |
| string | [colorGrade](class_tale_worlds_1_1_mount_and_blade_1_1_map_atmosphere_probe.html#a4b1fa96d9710c15fcdbe3d8246485e12) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static bool | [hideAllProbesStatic](class_tale_worlds_1_1_mount_and_blade_1_1_map_atmosphere_probe.html#a088e44060b2c45a4343334098a2bca7c) = true |

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

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_map_atmosphere_probe.html#aeab2e91a904cd69b484c0b4f5469f604)MapAtmosphereProbe()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.MapAtmosphereProbe.MapAtmosphereProbe | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_map_atmosphere_probe.html#a7d9502dad8134b15e764e86b58888bde)GetInfluenceAmount()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.MapAtmosphereProbe.GetInfluenceAmount | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *worldPosition* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_map_atmosphere_probe.html#a5d9a6d3c3b7c108bac78c9bce30e2dde)visualizeRadius
-------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.MapAtmosphereProbe.visualizeRadius = true |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_map_atmosphere_probe.html#a837f3290d5a2535f9075edc6c11aa166)hideAllProbes
-----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.MapAtmosphereProbe.hideAllProbes = true |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_map_atmosphere_probe.html#a088e44060b2c45a4343334098a2bca7c)hideAllProbesStatic
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.MapAtmosphereProbe.hideAllProbesStatic = true | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_map_atmosphere_probe.html#a937ae74d31f12ddfa0ce1574cf37dd46)minRadius
-------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.MapAtmosphereProbe.minRadius = 1 |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_map_atmosphere_probe.html#af9d9a053cfa62819b4bbace7d0d34462)maxRadius
-------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.MapAtmosphereProbe.maxRadius = 2 |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_map_atmosphere_probe.html#a47fce370e80e36ef04d72674a495640a)rainDensity
---------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.MapAtmosphereProbe.rainDensity = 0.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_map_atmosphere_probe.html#a751f59bac57f3d67bb46d62c6770cd04)temperature
---------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.MapAtmosphereProbe.temperature = 0.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_map_atmosphere_probe.html#a90cef6322c59f5b6c34129e0a8836aa3)atmosphereType
------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.MapAtmosphereProbe.atmosphereType |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_map_atmosphere_probe.html#a4b1fa96d9710c15fcdbe3d8246485e12)colorGrade
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.MapAtmosphereProbe.colorGrade |

