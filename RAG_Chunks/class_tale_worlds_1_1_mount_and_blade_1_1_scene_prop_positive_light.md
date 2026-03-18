--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_positive_light.html ---

TaleWorlds.MountAndBlade.ScenePropPositiveLight Class ReferenceInherits [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

|  |  |
| --- | --- |
| Public Attributes | |
| float | [Flatness\_X](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_positive_light.html#a3d5ed2e4791575498706627a26dbdf19) = 0.0f |
| float | [Flatness\_Y](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_positive_light.html#ae613ba5db1819959c6fa1d6cb6390651) = 0.0f |
| float | [Flatness\_Z](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_positive_light.html#a01ed1c9474680c762041f72463578037) = 0.0f |
| float | [DirectLightRed](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_positive_light.html#a446f6fd45e932ba053e9ca7cc00ef3f8) = 1.0f |
| float | [DirectLightGreen](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_positive_light.html#ae59591deea24efb4e1712665a8da0f08) = 1.0f |
| float | [DirectLightBlue](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_positive_light.html#a5028ff0bb3907c1678bfd1f2bb92d511) = 1.0f |
| float | [DirectLightIntensity](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_positive_light.html#ac5b63824cd1234d92ef3036d9eb3e377) = 1.0f |
| float | [AmbientLightRed](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_positive_light.html#a917e9d721d99011313358cf75127f9cc) = 0.0f |
| float | [AmbientLightGreen](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_positive_light.html#aae01b07f96d39211a79fe5835d9387d5) = 0.0f |
| float | [AmbientLightBlue](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_positive_light.html#a3726265f3a7c785284dea0cb406e70c6) = 1.0f |
| float | [AmbientLightIntensity](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_positive_light.html#a1b84e969fa1cf0d71258e955799c0362) = 1.0f |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Types inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| enum | [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) : uint {     [None](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da6adf97f83acf6453d4a6a4b1070f3754) = 0x00000000 ,     [TickOccasionally](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da9cee052f50afabfc1098c1aa6af80b75) = 0x00000001 ,     [Tick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0b3516a5bbb77566f904f9d3877f4710) = 0x00000002 ,     [TickParallel](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da5f5a8f4b9ce783164665db4d70e03ee3) = 0x00000004 ,     [TickParallel2](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0ea9f0c260cdfd8b20ce19a48dbc329f) = 0x00000008 ,     [FixedTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154dadd067942f0b8cc66859698bc9711ba15) = 0x00000010 ,     [FixedParallelTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daa226d712a5ffd8d400f850393ff68492) = 0x00000020 ,     [TickParallel3](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daf785c2c005d708ea434168efc10611b8) = 0x00000040   } |
| Public Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [SetScriptComponentToTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ae15c963749bd0f9a75bba24a333b39d4) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) tickReq) |
| void | [SetScriptComponentToTickMT](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a9b2183852eb7b70042ed82ef917022c6) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) value) |
| virtual [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) | [GetTickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ac17100a83d592505ed8d9ac565e512a5) () |
| Protected Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [InvalidateWeakPointersIfValid](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#af39d73d0c78790ba81a40a5a350c0526) () |
|  | [ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0bc136bb53989f2b9a4f23f12f54a332) () |
| virtual void | [OnRemoved](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a4778f913080fc216866daa15518c8ecd) (int removeReason) |
| Properties inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | [GameEntity](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0a02cc65cc567db6101ea4afa275ff36) `[get]` |
| [ManagedScriptComponent](class_tale_worlds_1_1_engine_1_1_managed_script_component.html) | [ScriptComponent](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a8d7c5772e6b456b1e22ccd46a0b391ce) `[get]` |
| ManagedScriptHolder | [ManagedScriptHolder](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a58417dd71bf3daca6eb58df177617c2d) `[get]` |
| Scene | [Scene](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a9d7d5b77582948847f1d1c532face2c8) `[get]` |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_positive_light.html#a3d5ed2e4791575498706627a26dbdf19)Flatness\_X
--------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.ScenePropPositiveLight.Flatness\_X = 0.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_positive_light.html#ae613ba5db1819959c6fa1d6cb6390651)Flatness\_Y
--------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.ScenePropPositiveLight.Flatness\_Y = 0.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_positive_light.html#a01ed1c9474680c762041f72463578037)Flatness\_Z
--------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.ScenePropPositiveLight.Flatness\_Z = 0.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_positive_light.html#a446f6fd45e932ba053e9ca7cc00ef3f8)DirectLightRed
-----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.ScenePropPositiveLight.DirectLightRed = 1.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_positive_light.html#ae59591deea24efb4e1712665a8da0f08)DirectLightGreen
-------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.ScenePropPositiveLight.DirectLightGreen = 1.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_positive_light.html#a5028ff0bb3907c1678bfd1f2bb92d511)DirectLightBlue
------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.ScenePropPositiveLight.DirectLightBlue = 1.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_positive_light.html#ac5b63824cd1234d92ef3036d9eb3e377)DirectLightIntensity
-----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.ScenePropPositiveLight.DirectLightIntensity = 1.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_positive_light.html#a917e9d721d99011313358cf75127f9cc)AmbientLightRed
------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.ScenePropPositiveLight.AmbientLightRed = 0.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_positive_light.html#aae01b07f96d39211a79fe5835d9387d5)AmbientLightGreen
--------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.ScenePropPositiveLight.AmbientLightGreen = 0.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_positive_light.html#a3726265f3a7c785284dea0cb406e70c6)AmbientLightBlue
-------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.ScenePropPositiveLight.AmbientLightBlue = 1.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_positive_light.html#a1b84e969fa1cf0d71258e955799c0362)AmbientLightIntensity
------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.ScenePropPositiveLight.AmbientLightIntensity = 1.0f |

