--- SOURCE: class_sand_box_1_1_objects_1_1_cinematics_1_1_hideout_boss_fight_behavior.html ---

SandBox.Objects.Cinematics.HideoutBossFightBehavior Class ReferenceInherits [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [GetPlayerFrames](class_sand_box_1_1_objects_1_1_cinematics_1_1_hideout_boss_fight_behavior.html#a89b93a3c104ad3749ea83713d3b851a4) (out [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) initialFrame, out [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) targetFrame, float perturbAmount=0.0f) |
| void | [GetBossFrames](class_sand_box_1_1_objects_1_1_cinematics_1_1_hideout_boss_fight_behavior.html#a5e2ceec46b0ad89b4cbefe0fb0226361) (out [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) initialFrame, out [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) targetFrame, float perturbAmount=0.0f) |
| void | [GetAllyFrames](class_sand_box_1_1_objects_1_1_cinematics_1_1_hideout_boss_fight_behavior.html#aa8fec07cdd0c34b1f452b0acb20d37be) (out List< [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) > initialFrames, out List< [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) > targetFrames, int agentCount=PreviewTroopCount, float agentOffsetAngle=PreviewPlacementAngle, float perturbAmount=0.0f) |
| void | [GetBanditFrames](class_sand_box_1_1_objects_1_1_cinematics_1_1_hideout_boss_fight_behavior.html#a6955813c887eeeb9c244055b8b10b18a) (out List< [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) > initialFrames, out List< [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) > targetFrames, int agentCount=PreviewTroopCount, float agentOffsetAngle=PreviewPlacementAngle, float perturbAmount=0.0f) |
| void | [GetAlliesInitialFrame](class_sand_box_1_1_objects_1_1_cinematics_1_1_hideout_boss_fight_behavior.html#a4d4c13f797f15655089b11f776477d04) (out [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame) |
| void | [GetBanditsInitialFrame](class_sand_box_1_1_objects_1_1_cinematics_1_1_hideout_boss_fight_behavior.html#aa5581221e906392f690a5f1283d34f52) (out [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame) |
| bool | [IsWorldPointInsideCameraVolume](class_sand_box_1_1_objects_1_1_cinematics_1_1_hideout_boss_fight_behavior.html#a1ae4787d3b68393e2920748a73bbf34a) (in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) worldPoint) |
| bool | [ClampWorldPointToCameraVolume](class_sand_box_1_1_objects_1_1_cinematics_1_1_hideout_boss_fight_behavior.html#ad4a53339fdf4de4495b7a7d819fdc1ed) (in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) worldPoint, out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) clampedPoint) |
| Public Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [SetScriptComponentToTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ae15c963749bd0f9a75bba24a333b39d4) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) tickReq) |
| void | [SetScriptComponentToTickMT](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a9b2183852eb7b70042ed82ef917022c6) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) value) |
| virtual [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) | [GetTickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ac17100a83d592505ed8d9ac565e512a5) () |

|  |  |
| --- | --- |
| Public Attributes | |
| float | [InnerRadius](class_sand_box_1_1_objects_1_1_cinematics_1_1_hideout_boss_fight_behavior.html#a01550967e757a7442bfe37fd53020241) = 2.5f |
| float | [OuterRadius](class_sand_box_1_1_objects_1_1_cinematics_1_1_hideout_boss_fight_behavior.html#aa9abfce12bf45fb63c70c46014e5b9b6) = 6.0f |
| float | [WalkDistance](class_sand_box_1_1_objects_1_1_cinematics_1_1_hideout_boss_fight_behavior.html#a9ca70ef7809ca86d3d11133e7a9f47f3) = 3.0f |
| bool | [ShowPreview](class_sand_box_1_1_objects_1_1_cinematics_1_1_hideout_boss_fight_behavior.html#ae4e0fd536df7aa9010170f39348c326d) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const float | [MaxCameraHeight](class_sand_box_1_1_objects_1_1_cinematics_1_1_hideout_boss_fight_behavior.html#ad95eb4e37924e6537aa07d3adfb3d875) = 5.0f |
| const float | [MaxCameraWidth](class_sand_box_1_1_objects_1_1_cinematics_1_1_hideout_boss_fight_behavior.html#a95858ff86196cd3f52bdd9377e78fe24) = 10.0f |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnEditorVariableChanged](class_sand_box_1_1_objects_1_1_cinematics_1_1_hideout_boss_fight_behavior.html#ac10ff2c60b092a4e1d28cb5946e02691) (string variableName) |
|  | Called when an object's field has changed from the editor. |
| override void | [OnEditorTick](class_sand_box_1_1_objects_1_1_cinematics_1_1_hideout_boss_fight_behavior.html#a82c5512650536a9b11f8bd4d2e11d442) (float dt) |
| override void | [OnRemoved](class_sand_box_1_1_objects_1_1_cinematics_1_1_hideout_boss_fight_behavior.html#acda5aee2778020314944ea8591a26640) (int removeReason) |
| Protected Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [InvalidateWeakPointersIfValid](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#af39d73d0c78790ba81a40a5a350c0526) () |
|  | [ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0bc136bb53989f2b9a4f23f12f54a332) () |

|  |  |
| --- | --- |
| Properties | |
| int | [PerturbSeed](class_sand_box_1_1_objects_1_1_cinematics_1_1_hideout_boss_fight_behavior.html#a457a758f13489ba1b8171dee71bc637d) `[get]` |
| Properties inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | [GameEntity](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0a02cc65cc567db6101ea4afa275ff36) `[get]` |
| [ManagedScriptComponent](class_tale_worlds_1_1_engine_1_1_managed_script_component.html) | [ScriptComponent](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a8d7c5772e6b456b1e22ccd46a0b391ce) `[get]` |
| ManagedScriptHolder | [ManagedScriptHolder](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a58417dd71bf3daca6eb58df177617c2d) `[get]` |
| Scene | [Scene](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a9d7d5b77582948847f1d1c532face2c8) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Types inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| enum | [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) : uint {     [None](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da6adf97f83acf6453d4a6a4b1070f3754) = 0x00000000 ,     [TickOccasionally](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da9cee052f50afabfc1098c1aa6af80b75) = 0x00000001 ,     [Tick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0b3516a5bbb77566f904f9d3877f4710) = 0x00000002 ,     [TickParallel](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da5f5a8f4b9ce783164665db4d70e03ee3) = 0x00000004 ,     [TickParallel2](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0ea9f0c260cdfd8b20ce19a48dbc329f) = 0x00000008 ,     [FixedTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154dadd067942f0b8cc66859698bc9711ba15) = 0x00000010 ,     [FixedParallelTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daa226d712a5ffd8d400f850393ff68492) = 0x00000020 ,     [TickParallel3](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daf785c2c005d708ea434168efc10611b8) = 0x00000040   } |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_objects_1_1_cinematics_1_1_hideout_boss_fight_behavior.html#a89b93a3c104ad3749ea83713d3b851a4)GetPlayerFrames()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.Objects.Cinematics.HideoutBossFightBehavior.GetPlayerFrames | ( | out [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *initialFrame*, |
|  |  | out [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *targetFrame*, |
|  |  | float | *perturbAmount* = 0::0f ) |

[◆](class_sand_box_1_1_objects_1_1_cinematics_1_1_hideout_boss_fight_behavior.html#a5e2ceec46b0ad89b4cbefe0fb0226361)GetBossFrames()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.Objects.Cinematics.HideoutBossFightBehavior.GetBossFrames | ( | out [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *initialFrame*, |
|  |  | out [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *targetFrame*, |
|  |  | float | *perturbAmount* = 0::0f ) |

[◆](class_sand_box_1_1_objects_1_1_cinematics_1_1_hideout_boss_fight_behavior.html#aa8fec07cdd0c34b1f452b0acb20d37be)GetAllyFrames()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.Objects.Cinematics.HideoutBossFightBehavior.GetAllyFrames | ( | out List< [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) > | *initialFrames*, |
|  |  | out List< [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) > | *targetFrames*, |
|  |  | int | *agentCount* = PreviewTroopCount, |
|  |  | float | *agentOffsetAngle* = PreviewPlacementAngle, |
|  |  | float | *perturbAmount* = 0::0f ) |

[◆](class_sand_box_1_1_objects_1_1_cinematics_1_1_hideout_boss_fight_behavior.html#a6955813c887eeeb9c244055b8b10b18a)GetBanditFrames()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.Objects.Cinematics.HideoutBossFightBehavior.GetBanditFrames | ( | out List< [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) > | *initialFrames*, |
|  |  | out List< [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) > | *targetFrames*, |
|  |  | int | *agentCount* = PreviewTroopCount, |
|  |  | float | *agentOffsetAngle* = PreviewPlacementAngle, |
|  |  | float | *perturbAmount* = 0::0f ) |

[◆](class_sand_box_1_1_objects_1_1_cinematics_1_1_hideout_boss_fight_behavior.html#a4d4c13f797f15655089b11f776477d04)GetAlliesInitialFrame()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.Objects.Cinematics.HideoutBossFightBehavior.GetAlliesInitialFrame | ( | out [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame* | ) |  |

[◆](class_sand_box_1_1_objects_1_1_cinematics_1_1_hideout_boss_fight_behavior.html#aa5581221e906392f690a5f1283d34f52)GetBanditsInitialFrame()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.Objects.Cinematics.HideoutBossFightBehavior.GetBanditsInitialFrame | ( | out [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame* | ) |  |

[◆](class_sand_box_1_1_objects_1_1_cinematics_1_1_hideout_boss_fight_behavior.html#a1ae4787d3b68393e2920748a73bbf34a)IsWorldPointInsideCameraVolume()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool SandBox.Objects.Cinematics.HideoutBossFightBehavior.IsWorldPointInsideCameraVolume | ( | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *worldPoint* | ) |  |

[◆](class_sand_box_1_1_objects_1_1_cinematics_1_1_hideout_boss_fight_behavior.html#ad4a53339fdf4de4495b7a7d819fdc1ed)ClampWorldPointToCameraVolume()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool SandBox.Objects.Cinematics.HideoutBossFightBehavior.ClampWorldPointToCameraVolume | ( | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *worldPoint*, |
|  |  | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *clampedPoint* ) |

[◆](class_sand_box_1_1_objects_1_1_cinematics_1_1_hideout_boss_fight_behavior.html#ac10ff2c60b092a4e1d28cb5946e02691)OnEditorVariableChanged()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.Objects.Cinematics.HideoutBossFightBehavior.OnEditorVariableChanged | ( | string | *variableName* | ) |  | | protectedvirtual |

Parameters
:   |  |  |
    | --- | --- |
    | variableName | Name of the field which has just changed. |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

[◆](class_sand_box_1_1_objects_1_1_cinematics_1_1_hideout_boss_fight_behavior.html#a82c5512650536a9b11f8bd4d2e11d442)OnEditorTick()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.Objects.Cinematics.HideoutBossFightBehavior.OnEditorTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

[◆](class_sand_box_1_1_objects_1_1_cinematics_1_1_hideout_boss_fight_behavior.html#acda5aee2778020314944ea8591a26640)OnRemoved()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.Objects.Cinematics.HideoutBossFightBehavior.OnRemoved | ( | int | *removeReason* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a4778f913080fc216866daa15518c8ecd).

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_objects_1_1_cinematics_1_1_hideout_boss_fight_behavior.html#ad95eb4e37924e6537aa07d3adfb3d875)MaxCameraHeight
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float SandBox.Objects.Cinematics.HideoutBossFightBehavior.MaxCameraHeight = 5.0f | | static |

[◆](class_sand_box_1_1_objects_1_1_cinematics_1_1_hideout_boss_fight_behavior.html#a95858ff86196cd3f52bdd9377e78fe24)MaxCameraWidth
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float SandBox.Objects.Cinematics.HideoutBossFightBehavior.MaxCameraWidth = 10.0f | | static |

[◆](class_sand_box_1_1_objects_1_1_cinematics_1_1_hideout_boss_fight_behavior.html#a01550967e757a7442bfe37fd53020241)InnerRadius
--------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float SandBox.Objects.Cinematics.HideoutBossFightBehavior.InnerRadius = 2.5f |

[◆](class_sand_box_1_1_objects_1_1_cinematics_1_1_hideout_boss_fight_behavior.html#aa9abfce12bf45fb63c70c46014e5b9b6)OuterRadius
--------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float SandBox.Objects.Cinematics.HideoutBossFightBehavior.OuterRadius = 6.0f |

[◆](class_sand_box_1_1_objects_1_1_cinematics_1_1_hideout_boss_fight_behavior.html#a9ca70ef7809ca86d3d11133e7a9f47f3)WalkDistance
---------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float SandBox.Objects.Cinematics.HideoutBossFightBehavior.WalkDistance = 3.0f |

[◆](class_sand_box_1_1_objects_1_1_cinematics_1_1_hideout_boss_fight_behavior.html#ae4e0fd536df7aa9010170f39348c326d)ShowPreview
--------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool SandBox.Objects.Cinematics.HideoutBossFightBehavior.ShowPreview |

Property Documentation
----------------------

[◆](class_sand_box_1_1_objects_1_1_cinematics_1_1_hideout_boss_fight_behavior.html#a457a758f13489ba1b8171dee71bc637d)PerturbSeed
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.Objects.Cinematics.HideoutBossFightBehavior.PerturbSeed | | get |

