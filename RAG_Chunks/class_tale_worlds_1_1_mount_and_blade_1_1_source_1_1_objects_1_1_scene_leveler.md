--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_source_1_1_objects_1_1_scene_leveler.html ---

TaleWorlds.MountAndBlade.Source.Objects.SceneLeveler Class ReferenceInherits [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

|  |  |
| --- | --- |
| Public Attributes | |
| string | [SourceSelectionSetName](class_tale_worlds_1_1_mount_and_blade_1_1_source_1_1_objects_1_1_scene_leveler.html#a4d88cc2b094d50afef235ca1871da1cd) = "" |
| string | [TargetSelectionSetName](class_tale_worlds_1_1_mount_and_blade_1_1_source_1_1_objects_1_1_scene_leveler.html#aac4c94ec84c8de9a9021d1ab55821e88) = "" |
| [SimpleButton](class_tale_worlds_1_1_engine_1_1_simple_button.html) | [CreateLevel1](class_tale_worlds_1_1_mount_and_blade_1_1_source_1_1_objects_1_1_scene_leveler.html#abe6efd48c5fecbed42b6cb085a6003a3) |
| [SimpleButton](class_tale_worlds_1_1_engine_1_1_simple_button.html) | [CreateLevel2](class_tale_worlds_1_1_mount_and_blade_1_1_source_1_1_objects_1_1_scene_leveler.html#ac658e3b98585563dd8718019c2bde044) |
| [SimpleButton](class_tale_worlds_1_1_engine_1_1_simple_button.html) | [CreateLevel3](class_tale_worlds_1_1_mount_and_blade_1_1_source_1_1_objects_1_1_scene_leveler.html#aa4963378228765d42de03aabdfa4ff0e) |
| [SimpleButton](class_tale_worlds_1_1_engine_1_1_simple_button.html) | [DeleteLevel1](class_tale_worlds_1_1_mount_and_blade_1_1_source_1_1_objects_1_1_scene_leveler.html#a03ae415e7a3ca72616f10ebaf8dc3f10) |
| [SimpleButton](class_tale_worlds_1_1_engine_1_1_simple_button.html) | [DeleteLevel2](class_tale_worlds_1_1_mount_and_blade_1_1_source_1_1_objects_1_1_scene_leveler.html#ab2b0026ca89c34c338c6eccd4c2159e3) |
| [SimpleButton](class_tale_worlds_1_1_engine_1_1_simple_button.html) | [DeleteLevel3](class_tale_worlds_1_1_mount_and_blade_1_1_source_1_1_objects_1_1_scene_leveler.html#a267a73faa4eb31b5f4284761213015a4) |
| [SimpleButton](class_tale_worlds_1_1_engine_1_1_simple_button.html) | [SelectEntitiesWithoutLevel](class_tale_worlds_1_1_mount_and_blade_1_1_source_1_1_objects_1_1_scene_leveler.html#a3239a92df7c886daa4f5b4bc5b00afcc) |

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

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_source_1_1_objects_1_1_scene_leveler.html#a4d88cc2b094d50afef235ca1871da1cd)SourceSelectionSetName
------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.Source.Objects.SceneLeveler.SourceSelectionSetName = "" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_source_1_1_objects_1_1_scene_leveler.html#aac4c94ec84c8de9a9021d1ab55821e88)TargetSelectionSetName
------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.Source.Objects.SceneLeveler.TargetSelectionSetName = "" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_source_1_1_objects_1_1_scene_leveler.html#abe6efd48c5fecbed42b6cb085a6003a3)CreateLevel1
--------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [SimpleButton](class_tale_worlds_1_1_engine_1_1_simple_button.html) TaleWorlds.MountAndBlade.Source.Objects.SceneLeveler.CreateLevel1 |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_source_1_1_objects_1_1_scene_leveler.html#ac658e3b98585563dd8718019c2bde044)CreateLevel2
--------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [SimpleButton](class_tale_worlds_1_1_engine_1_1_simple_button.html) TaleWorlds.MountAndBlade.Source.Objects.SceneLeveler.CreateLevel2 |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_source_1_1_objects_1_1_scene_leveler.html#aa4963378228765d42de03aabdfa4ff0e)CreateLevel3
--------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [SimpleButton](class_tale_worlds_1_1_engine_1_1_simple_button.html) TaleWorlds.MountAndBlade.Source.Objects.SceneLeveler.CreateLevel3 |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_source_1_1_objects_1_1_scene_leveler.html#a03ae415e7a3ca72616f10ebaf8dc3f10)DeleteLevel1
--------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [SimpleButton](class_tale_worlds_1_1_engine_1_1_simple_button.html) TaleWorlds.MountAndBlade.Source.Objects.SceneLeveler.DeleteLevel1 |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_source_1_1_objects_1_1_scene_leveler.html#ab2b0026ca89c34c338c6eccd4c2159e3)DeleteLevel2
--------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [SimpleButton](class_tale_worlds_1_1_engine_1_1_simple_button.html) TaleWorlds.MountAndBlade.Source.Objects.SceneLeveler.DeleteLevel2 |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_source_1_1_objects_1_1_scene_leveler.html#a267a73faa4eb31b5f4284761213015a4)DeleteLevel3
--------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [SimpleButton](class_tale_worlds_1_1_engine_1_1_simple_button.html) TaleWorlds.MountAndBlade.Source.Objects.SceneLeveler.DeleteLevel3 |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_source_1_1_objects_1_1_scene_leveler.html#a3239a92df7c886daa4f5b4bc5b00afcc)SelectEntitiesWithoutLevel
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [SimpleButton](class_tale_worlds_1_1_engine_1_1_simple_button.html) TaleWorlds.MountAndBlade.Source.Objects.SceneLeveler.SelectEntitiesWithoutLevel |

