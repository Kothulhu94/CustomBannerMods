--- SOURCE: class_sand_box_1_1_view_1_1_map_1_1_blockade_position_script.html ---

SandBox.View.Map.BlockadePositionScript Class ReferenceInherits [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| List< List< [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) > > | [GetBlockadeArc](class_sand_box_1_1_view_1_1_map_1_1_blockade_position_script.html#adc16d6192cd8b99937df29b9a9085cca) (int totalNumberOfShips, out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) center) |
| Public Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [SetScriptComponentToTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ae15c963749bd0f9a75bba24a333b39d4) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) tickReq) |
| void | [SetScriptComponentToTickMT](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a9b2183852eb7b70042ed82ef917022c6) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) value) |
| virtual [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) | [GetTickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ac17100a83d592505ed8d9ac565e512a5) () |

|  |  |
| --- | --- |
| Public Attributes | |
| int | [MaximumNumberOfShips](class_sand_box_1_1_view_1_1_map_1_1_blockade_position_script.html#aafbf617dc5cc62e193c7a7ed1d4324a0) = 12 |
| int | [NumberOfArcs](class_sand_box_1_1_view_1_1_map_1_1_blockade_position_script.html#a9e21b2a8e1d4f167598623ed41f0995c) = 4 |
| float | [DistanceBetweenShips](class_sand_box_1_1_view_1_1_map_1_1_blockade_position_script.html#a474abc0ac43e622d35cb268d54246d76) = MBMath.HalfPI / 2 |
| float | [DistanceRandomizationOnArcs](class_sand_box_1_1_view_1_1_map_1_1_blockade_position_script.html#a178d3381fb1e65951a59c57801689059) = 0.1f |
| float | [DistanceRandomizationBetweenArcs](class_sand_box_1_1_view_1_1_map_1_1_blockade_position_script.html#a7533d4480ea6567c411aa2297bc7e117) = 0.1f |
| float | [Angle](class_sand_box_1_1_view_1_1_map_1_1_blockade_position_script.html#a54250b8acfaab605ec54bbefe183a426) = MBMath.HalfPI |
| string | [MissionShipId](class_sand_box_1_1_view_1_1_map_1_1_blockade_position_script.html#a84634da744d04dfbc3072aa0b67a0bb3) = "dromon\_ship\_nested" |
| float | [ShipScaleFactor](class_sand_box_1_1_view_1_1_map_1_1_blockade_position_script.html#a22a052b6a6029e990ed28c1c2a964f18) = 0.052f |
| bool | [IsVisualizationEnabled](class_sand_box_1_1_view_1_1_map_1_1_blockade_position_script.html#a4ae8bee536c741e4eb062808105bd9b3) = false |
| bool | [IsRandomizationEnabled](class_sand_box_1_1_view_1_1_map_1_1_blockade_position_script.html#a16cb8c3aa7220a0fd7dd85dd574da50b) = false |
| bool | [IsShipVisualizationEnabled](class_sand_box_1_1_view_1_1_map_1_1_blockade_position_script.html#a2549f4bd6ea4c2ae4eccab3586b97a1b) = false |
| [SimpleButton](class_tale_worlds_1_1_engine_1_1_simple_button.html) | [RefreshVisualization](class_sand_box_1_1_view_1_1_map_1_1_blockade_position_script.html#aace0c55a90aa170370d807c5075d49b6) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnEditorTick](class_sand_box_1_1_view_1_1_map_1_1_blockade_position_script.html#aa825cd8c14186b3d4b0c69dcd9c5bafc) (float dt) |
| override void | [OnEditorVariableChanged](class_sand_box_1_1_view_1_1_map_1_1_blockade_position_script.html#aed71408c90f8ce7df23fd4399aa6a1f8) (string variableName) |
|  | Called when an object's field has changed from the editor. |
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

[◆](class_sand_box_1_1_view_1_1_map_1_1_blockade_position_script.html#aa825cd8c14186b3d4b0c69dcd9c5bafc)OnEditorTick()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.View.Map.BlockadePositionScript.OnEditorTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

[◆](class_sand_box_1_1_view_1_1_map_1_1_blockade_position_script.html#aed71408c90f8ce7df23fd4399aa6a1f8)OnEditorVariableChanged()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.View.Map.BlockadePositionScript.OnEditorVariableChanged | ( | string | *variableName* | ) |  | | protectedvirtual |

Parameters
:   |  |  |
    | --- | --- |
    | variableName | Name of the field which has just changed. |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

[◆](class_sand_box_1_1_view_1_1_map_1_1_blockade_position_script.html#adc16d6192cd8b99937df29b9a9085cca)GetBlockadeArc()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| List< List< [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) > > SandBox.View.Map.BlockadePositionScript.GetBlockadeArc | ( | int | *totalNumberOfShips*, |
|  |  | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *center* ) |

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_blockade_position_script.html#aafbf617dc5cc62e193c7a7ed1d4324a0)MaximumNumberOfShips
----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int SandBox.View.Map.BlockadePositionScript.MaximumNumberOfShips = 12 |

[◆](class_sand_box_1_1_view_1_1_map_1_1_blockade_position_script.html#a9e21b2a8e1d4f167598623ed41f0995c)NumberOfArcs
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int SandBox.View.Map.BlockadePositionScript.NumberOfArcs = 4 |

[◆](class_sand_box_1_1_view_1_1_map_1_1_blockade_position_script.html#a474abc0ac43e622d35cb268d54246d76)DistanceBetweenShips
----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float SandBox.View.Map.BlockadePositionScript.DistanceBetweenShips = MBMath.HalfPI / 2 |

[◆](class_sand_box_1_1_view_1_1_map_1_1_blockade_position_script.html#a178d3381fb1e65951a59c57801689059)DistanceRandomizationOnArcs
-----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float SandBox.View.Map.BlockadePositionScript.DistanceRandomizationOnArcs = 0.1f |

[◆](class_sand_box_1_1_view_1_1_map_1_1_blockade_position_script.html#a7533d4480ea6567c411aa2297bc7e117)DistanceRandomizationBetweenArcs
----------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float SandBox.View.Map.BlockadePositionScript.DistanceRandomizationBetweenArcs = 0.1f |

[◆](class_sand_box_1_1_view_1_1_map_1_1_blockade_position_script.html#a54250b8acfaab605ec54bbefe183a426)Angle
-------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float SandBox.View.Map.BlockadePositionScript.Angle = MBMath.HalfPI |

[◆](class_sand_box_1_1_view_1_1_map_1_1_blockade_position_script.html#a84634da744d04dfbc3072aa0b67a0bb3)MissionShipId
---------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string SandBox.View.Map.BlockadePositionScript.MissionShipId = "dromon\_ship\_nested" |

[◆](class_sand_box_1_1_view_1_1_map_1_1_blockade_position_script.html#a22a052b6a6029e990ed28c1c2a964f18)ShipScaleFactor
-----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float SandBox.View.Map.BlockadePositionScript.ShipScaleFactor = 0.052f |

[◆](class_sand_box_1_1_view_1_1_map_1_1_blockade_position_script.html#a4ae8bee536c741e4eb062808105bd9b3)IsVisualizationEnabled
------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool SandBox.View.Map.BlockadePositionScript.IsVisualizationEnabled = false |

[◆](class_sand_box_1_1_view_1_1_map_1_1_blockade_position_script.html#a16cb8c3aa7220a0fd7dd85dd574da50b)IsRandomizationEnabled
------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool SandBox.View.Map.BlockadePositionScript.IsRandomizationEnabled = false |

[◆](class_sand_box_1_1_view_1_1_map_1_1_blockade_position_script.html#a2549f4bd6ea4c2ae4eccab3586b97a1b)IsShipVisualizationEnabled
----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool SandBox.View.Map.BlockadePositionScript.IsShipVisualizationEnabled = false |

[◆](class_sand_box_1_1_view_1_1_map_1_1_blockade_position_script.html#aace0c55a90aa170370d807c5075d49b6)RefreshVisualization
----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [SimpleButton](class_tale_worlds_1_1_engine_1_1_simple_button.html) SandBox.View.Map.BlockadePositionScript.RefreshVisualization |

