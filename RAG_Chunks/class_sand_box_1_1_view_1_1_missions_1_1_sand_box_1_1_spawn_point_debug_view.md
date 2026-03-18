--- SOURCE: class_sand_box_1_1_view_1_1_missions_1_1_sand_box_1_1_spawn_point_debug_view.html ---

SandBox.View.Missions.SandBox.SpawnPointDebugView Class ReferenceInherits [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) | [GetTickRequirement](class_sand_box_1_1_view_1_1_missions_1_1_sand_box_1_1_spawn_point_debug_view.html#ad8bd419e158a730ed2a64302a0fbde59) () |
| Public Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [SetScriptComponentToTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ae15c963749bd0f9a75bba24a333b39d4) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) tickReq) |
| void | [SetScriptComponentToTickMT](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a9b2183852eb7b70042ed82ef917022c6) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) value) |

|  |  |
| --- | --- |
| Public Attributes | |
| bool | [ActivateDebugUIEditor](class_sand_box_1_1_view_1_1_missions_1_1_sand_box_1_1_spawn_point_debug_view.html#a606e980921bfbd7a137b82f265f33ee5) = false |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static bool | [ActivateDebugUI](class_sand_box_1_1_view_1_1_missions_1_1_sand_box_1_1_spawn_point_debug_view.html#a8ff42f93e8128c7dc1ebe470c9f86a03) = false |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnEditorInit](class_sand_box_1_1_view_1_1_missions_1_1_sand_box_1_1_spawn_point_debug_view.html#a854de724dd4c18ecfe09a2db0038fdc6) () |
| override void | [OnInit](class_sand_box_1_1_view_1_1_missions_1_1_sand_box_1_1_spawn_point_debug_view.html#a99226c4e6e58d76ffaf490fb59a7d323) () |
|  | This callback method is called when the object is constructed. |
| override void | [OnTick](class_sand_box_1_1_view_1_1_missions_1_1_sand_box_1_1_spawn_point_debug_view.html#a9757a724340463fedc172cffc01ab5b9) (float dt) |
| override void | [OnEditorTick](class_sand_box_1_1_view_1_1_missions_1_1_sand_box_1_1_spawn_point_debug_view.html#a34027b5d37495c13b39a6650609c1cdf) (float dt) |
| override void | [OnSceneSave](class_sand_box_1_1_view_1_1_missions_1_1_sand_box_1_1_spawn_point_debug_view.html#a2089936706231fcc8a6b76f1243917d0) (string saveFolder) |
|  | Called before the scene of object is being saved in editor. |
| override bool | [OnCheckForProblems](class_sand_box_1_1_view_1_1_missions_1_1_sand_box_1_1_spawn_point_debug_view.html#af805111a7e53e0fa1fe231da7c8a9463) () |
|  | Called before the scene of object is being saved in editor. |
| Protected Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [InvalidateWeakPointersIfValid](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#af39d73d0c78790ba81a40a5a350c0526) () |
|  | [ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0bc136bb53989f2b9a4f23f12f54a332) () |
| virtual void | [OnRemoved](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a4778f913080fc216866daa15518c8ecd) (int removeReason) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Types inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| enum | [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) : uint {     [None](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da6adf97f83acf6453d4a6a4b1070f3754) = 0x00000000 ,     [TickOccasionally](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da9cee052f50afabfc1098c1aa6af80b75) = 0x00000001 ,     [Tick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0b3516a5bbb77566f904f9d3877f4710) = 0x00000002 ,     [TickParallel](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da5f5a8f4b9ce783164665db4d70e03ee3) = 0x00000004 ,     [TickParallel2](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0ea9f0c260cdfd8b20ce19a48dbc329f) = 0x00000008 ,     [FixedTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154dadd067942f0b8cc66859698bc9711ba15) = 0x00000010 ,     [FixedParallelTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daa226d712a5ffd8d400f850393ff68492) = 0x00000020 ,     [TickParallel3](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daf785c2c005d708ea434168efc10611b8) = 0x00000040   } |
| Properties inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | [GameEntity](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0a02cc65cc567db6101ea4afa275ff36) `[get]` |
| [ManagedScriptComponent](class_tale_worlds_1_1_engine_1_1_managed_script_component.html) | [ScriptComponent](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a8d7c5772e6b456b1e22ccd46a0b391ce) `[get]` |
| ManagedScriptHolder | [ManagedScriptHolder](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a58417dd71bf3daca6eb58df177617c2d) `[get]` |
| Scene | [Scene](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a9d7d5b77582948847f1d1c532face2c8) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_view_1_1_missions_1_1_sand_box_1_1_spawn_point_debug_view.html#a854de724dd4c18ecfe09a2db0038fdc6)OnEditorInit()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.View.Missions.SandBox.SpawnPointDebugView.OnEditorInit | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

[◆](class_sand_box_1_1_view_1_1_missions_1_1_sand_box_1_1_spawn_point_debug_view.html#a99226c4e6e58d76ffaf490fb59a7d323)OnInit()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.View.Missions.SandBox.SpawnPointDebugView.OnInit | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

[◆](class_sand_box_1_1_view_1_1_missions_1_1_sand_box_1_1_spawn_point_debug_view.html#ad8bd419e158a730ed2a64302a0fbde59)GetTickRequirement()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) SandBox.View.Missions.SandBox.SpawnPointDebugView.GetTickRequirement | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ac17100a83d592505ed8d9ac565e512a5).

[◆](class_sand_box_1_1_view_1_1_missions_1_1_sand_box_1_1_spawn_point_debug_view.html#a9757a724340463fedc172cffc01ab5b9)OnTick()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.View.Missions.SandBox.SpawnPointDebugView.OnTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

[◆](class_sand_box_1_1_view_1_1_missions_1_1_sand_box_1_1_spawn_point_debug_view.html#a34027b5d37495c13b39a6650609c1cdf)OnEditorTick()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.View.Missions.SandBox.SpawnPointDebugView.OnEditorTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

[◆](class_sand_box_1_1_view_1_1_missions_1_1_sand_box_1_1_spawn_point_debug_view.html#a2089936706231fcc8a6b76f1243917d0)OnSceneSave()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.View.Missions.SandBox.SpawnPointDebugView.OnSceneSave | ( | string | *saveFolder* | ) |  | | protectedvirtual |

Parameters
:   |  |  |
    | --- | --- |
    | variableName | Name of the field which has just changed. |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

[◆](class_sand_box_1_1_view_1_1_missions_1_1_sand_box_1_1_spawn_point_debug_view.html#af805111a7e53e0fa1fe231da7c8a9463)OnCheckForProblems()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override bool SandBox.View.Missions.SandBox.SpawnPointDebugView.OnCheckForProblems | ( |  | ) |  | | protectedvirtual |

Parameters
:   |  |  |
    | --- | --- |
    | variableName | Name of the field which has just changed. |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_view_1_1_missions_1_1_sand_box_1_1_spawn_point_debug_view.html#a8ff42f93e8128c7dc1ebe470c9f86a03)ActivateDebugUI
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.View.Missions.SandBox.SpawnPointDebugView.ActivateDebugUI = false | | static |

[◆](class_sand_box_1_1_view_1_1_missions_1_1_sand_box_1_1_spawn_point_debug_view.html#a606e980921bfbd7a137b82f265f33ee5)ActivateDebugUIEditor
---------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool SandBox.View.Missions.SandBox.SpawnPointDebugView.ActivateDebugUIEditor = false |

