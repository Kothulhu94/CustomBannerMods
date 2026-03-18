--- SOURCE: class_sand_box_1_1_view_1_1_map_1_1_settlement_position_script.html ---

SandBox.View.Map.SettlementPositionScript Class ReferenceInherits [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

|  |  |
| --- | --- |
| Public Attributes | |
| [SimpleButton](class_tale_worlds_1_1_engine_1_1_simple_button.html) | [CheckPositions](class_sand_box_1_1_view_1_1_map_1_1_settlement_position_script.html#ad817483e7a2f47a4c29b50e1ad41b9cc) |
| [SimpleButton](class_tale_worlds_1_1_engine_1_1_simple_button.html) | [SavePositions](class_sand_box_1_1_view_1_1_map_1_1_settlement_position_script.html#a1f3ae50d63c58a902b608ccca7ed135d) |
| [SimpleButton](class_tale_worlds_1_1_engine_1_1_simple_button.html) | [ComputeAndSaveSettlementDistanceCache](class_sand_box_1_1_view_1_1_map_1_1_settlement_position_script.html#a7edde8276ba58db54d1f05a7ac3866e8) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnInit](class_sand_box_1_1_view_1_1_map_1_1_settlement_position_script.html#aa466d6837ac6d00f9633f04c0083c382) () |
|  | This callback method is called when the object is constructed. |
| override void | [OnEditorInit](class_sand_box_1_1_view_1_1_map_1_1_settlement_position_script.html#a1c3fbcfc9acd0aaf84ef4f934d031604) () |
| override void | [OnEditorVariableChanged](class_sand_box_1_1_view_1_1_map_1_1_settlement_position_script.html#ace19bc318c80d670129663af41bc67ce) (string variableName) |
|  | Called when an object's field has changed from the editor. |
| override void | [OnSceneSave](class_sand_box_1_1_view_1_1_map_1_1_settlement_position_script.html#a91eb06845724d1de46f864b3720eb181) (string saveFolder) |
|  | Called before the scene of object is being saved in editor. |
| override bool | [IsOnlyVisual](class_sand_box_1_1_view_1_1_map_1_1_settlement_position_script.html#aec86ef1e3d9e371c2a5ab11deb8ce796) () |
| Protected Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [InvalidateWeakPointersIfValid](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#af39d73d0c78790ba81a40a5a350c0526) () |
|  | [ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0bc136bb53989f2b9a4f23f12f54a332) () |
| virtual void | [OnRemoved](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a4778f913080fc216866daa15518c8ecd) (int removeReason) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Types inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| enum | [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) : uint {     [None](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da6adf97f83acf6453d4a6a4b1070f3754) = 0x00000000 ,     [TickOccasionally](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da9cee052f50afabfc1098c1aa6af80b75) = 0x00000001 ,     [Tick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0b3516a5bbb77566f904f9d3877f4710) = 0x00000002 ,     [TickParallel](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da5f5a8f4b9ce783164665db4d70e03ee3) = 0x00000004 ,     [TickParallel2](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0ea9f0c260cdfd8b20ce19a48dbc329f) = 0x00000008 ,     [FixedTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154dadd067942f0b8cc66859698bc9711ba15) = 0x00000010 ,     [FixedParallelTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daa226d712a5ffd8d400f850393ff68492) = 0x00000020 ,     [TickParallel3](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daf785c2c005d708ea434168efc10611b8) = 0x00000040   } |
| Public Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [SetScriptComponentToTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ae15c963749bd0f9a75bba24a333b39d4) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) tickReq) |
| void | [SetScriptComponentToTickMT](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a9b2183852eb7b70042ed82ef917022c6) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) value) |
| virtual [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) | [GetTickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ac17100a83d592505ed8d9ac565e512a5) () |
| Properties inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | [GameEntity](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0a02cc65cc567db6101ea4afa275ff36) `[get]` |
| [ManagedScriptComponent](class_tale_worlds_1_1_engine_1_1_managed_script_component.html) | [ScriptComponent](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a8d7c5772e6b456b1e22ccd46a0b391ce) `[get]` |
| ManagedScriptHolder | [ManagedScriptHolder](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a58417dd71bf3daca6eb58df177617c2d) `[get]` |
| Scene | [Scene](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a9d7d5b77582948847f1d1c532face2c8) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_settlement_position_script.html#aa466d6837ac6d00f9633f04c0083c382)OnInit()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.View.Map.SettlementPositionScript.OnInit | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

[◆](class_sand_box_1_1_view_1_1_map_1_1_settlement_position_script.html#a1c3fbcfc9acd0aaf84ef4f934d031604)OnEditorInit()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.View.Map.SettlementPositionScript.OnEditorInit | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

[◆](class_sand_box_1_1_view_1_1_map_1_1_settlement_position_script.html#ace19bc318c80d670129663af41bc67ce)OnEditorVariableChanged()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.View.Map.SettlementPositionScript.OnEditorVariableChanged | ( | string | *variableName* | ) |  | | protectedvirtual |

Parameters
:   |  |  |
    | --- | --- |
    | variableName | Name of the field which has just changed. |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

[◆](class_sand_box_1_1_view_1_1_map_1_1_settlement_position_script.html#a91eb06845724d1de46f864b3720eb181)OnSceneSave()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.View.Map.SettlementPositionScript.OnSceneSave | ( | string | *saveFolder* | ) |  | | protectedvirtual |

Parameters
:   |  |  |
    | --- | --- |
    | variableName | Name of the field which has just changed. |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

[◆](class_sand_box_1_1_view_1_1_map_1_1_settlement_position_script.html#aec86ef1e3d9e371c2a5ab11deb8ce796)IsOnlyVisual()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override bool SandBox.View.Map.SettlementPositionScript.IsOnlyVisual | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_settlement_position_script.html#ad817483e7a2f47a4c29b50e1ad41b9cc)CheckPositions
------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [SimpleButton](class_tale_worlds_1_1_engine_1_1_simple_button.html) SandBox.View.Map.SettlementPositionScript.CheckPositions |

[◆](class_sand_box_1_1_view_1_1_map_1_1_settlement_position_script.html#a1f3ae50d63c58a902b608ccca7ed135d)SavePositions
-----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [SimpleButton](class_tale_worlds_1_1_engine_1_1_simple_button.html) SandBox.View.Map.SettlementPositionScript.SavePositions |

[◆](class_sand_box_1_1_view_1_1_map_1_1_settlement_position_script.html#a7edde8276ba58db54d1f05a7ac3866e8)ComputeAndSaveSettlementDistanceCache
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [SimpleButton](class_tale_worlds_1_1_engine_1_1_simple_button.html) SandBox.View.Map.SettlementPositionScript.ComputeAndSaveSettlementDistanceCache |

