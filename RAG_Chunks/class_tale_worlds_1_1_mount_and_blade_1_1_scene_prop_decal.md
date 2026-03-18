--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_decal.html ---

TaleWorlds.MountAndBlade.ScenePropDecal Class ReferenceInherits [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

|  |  |
| --- | --- |
| Public Attributes | |
| string | [DiffuseTexture](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_decal.html#a1fc760868c62a942b5e628fe1680de81) |
| string | [NormalTexture](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_decal.html#a486b02027f07a042017355aab07dfeae) |
| string | [SpecularTexture](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_decal.html#aa943d4d0d053fb9208813b3315830000) |
| string | [MaskTexture](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_decal.html#ac08a1d4c02c3a9349043cf5395a9e6d6) |
| bool | [UseBaseNormals](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_decal.html#a580e98fc75b717ebcfeca9036006d9d1) |
| float | [TilingSize](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_decal.html#a102defbbfc6456256e1371ba5e7543ea) = 1 |
| float | [TilingOffset](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_decal.html#a68aeb2e41016e5e2322e48095bb4905e) = 0 |
| float | [AlphaTestValue](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_decal.html#a86c184bc56f39eb9b995bbf85de9bd92) = 0 |
| float | [TextureSweepX](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_decal.html#a8071e6c2c04a3f60f19f1e932909c2ed) |
| float | [TextureSweepY](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_decal.html#aca3aa5ce2db39bf409141fa04bdb2d37) |
| string | [MaterialName](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_decal.html#af7f182d3d59e61dd1365228e40e506b9) = "deferred\_decal\_material" |

|  |  |
| --- | --- |
| Protected Attributes | |
| [Material](class_tale_worlds_1_1_engine_1_1_material.html) | [UniqueMaterial](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_decal.html#ab38705a8523c1af300010d6922052043) |

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

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_decal.html#a1fc760868c62a942b5e628fe1680de81)DiffuseTexture
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.ScenePropDecal.DiffuseTexture |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_decal.html#a486b02027f07a042017355aab07dfeae)NormalTexture
-------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.ScenePropDecal.NormalTexture |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_decal.html#aa943d4d0d053fb9208813b3315830000)SpecularTexture
---------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.ScenePropDecal.SpecularTexture |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_decal.html#ac08a1d4c02c3a9349043cf5395a9e6d6)MaskTexture
-----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.ScenePropDecal.MaskTexture |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_decal.html#a580e98fc75b717ebcfeca9036006d9d1)UseBaseNormals
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.ScenePropDecal.UseBaseNormals |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_decal.html#a102defbbfc6456256e1371ba5e7543ea)TilingSize
----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.ScenePropDecal.TilingSize = 1 |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_decal.html#a68aeb2e41016e5e2322e48095bb4905e)TilingOffset
------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.ScenePropDecal.TilingOffset = 0 |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_decal.html#a86c184bc56f39eb9b995bbf85de9bd92)AlphaTestValue
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.ScenePropDecal.AlphaTestValue = 0 |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_decal.html#a8071e6c2c04a3f60f19f1e932909c2ed)TextureSweepX
-------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.ScenePropDecal.TextureSweepX |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_decal.html#aca3aa5ce2db39bf409141fa04bdb2d37)TextureSweepY
-------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.ScenePropDecal.TextureSweepY |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_decal.html#af7f182d3d59e61dd1365228e40e506b9)MaterialName
------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.ScenePropDecal.MaterialName = "deferred\_decal\_material" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_scene_prop_decal.html#ab38705a8523c1af300010d6922052043)UniqueMaterial
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Material](class_tale_worlds_1_1_engine_1_1_material.html) TaleWorlds.MountAndBlade.ScenePropDecal.UniqueMaterial | | protected |

