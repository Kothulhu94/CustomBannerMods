--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_hand_morph_test.html ---

TaleWorlds.MountAndBlade.View.Scripts.HandMorphTest Class ReferenceInherits [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [SpawnCharacter](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_hand_morph_test.html#a19b4fed34b575139a518927f06fcf1c4) () |
| void | [Reset](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_hand_morph_test.html#ac6b16c3f70f815378e4d1cfa4d89c240) () |
| void | [InitWithCharacter](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_hand_morph_test.html#a039f0eec079fb2889c566783eb53f42a) ([CharacterCode](class_tale_worlds_1_1_core_1_1_character_code.html) characterCode) |
| Public Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [SetScriptComponentToTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ae15c963749bd0f9a75bba24a333b39d4) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) tickReq) |
| void | [SetScriptComponentToTickMT](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a9b2183852eb7b70042ed82ef917022c6) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) value) |
| virtual [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) | [GetTickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ac17100a83d592505ed8d9ac565e512a5) () |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnInit](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_hand_morph_test.html#a50fb6bbe13e5b9d616d46faa4efff7ba) () |
|  | This callback method is called when the object is constructed. |
| override void | [OnEditorInit](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_hand_morph_test.html#a727f489c765c1180e598bb9764f3df30) () |
| override void | [OnEditorTick](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_hand_morph_test.html#a6665d8138c007c2d70f333a5de08ca26) (float dt) |
| override void | [OnRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_hand_morph_test.html#a46b9857ce3035c24f064cd031a4cd236) (int removeReason) |
| Protected Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [InvalidateWeakPointersIfValid](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#af39d73d0c78790ba81a40a5a350c0526) () |
|  | [ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0bc136bb53989f2b9a4f23f12f54a332) () |

|  |  |
| --- | --- |
| Properties | |
| uint | [ClothColor1](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_hand_morph_test.html#ae8dfcb4ac7a00f40cef1074111ea5359) `[get]` |
| uint | [ClothColor2](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_hand_morph_test.html#a3839a08f8c325be0505b591b5e13f9c4) `[get]` |
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

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_hand_morph_test.html#a50fb6bbe13e5b9d616d46faa4efff7ba)OnInit()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.Scripts.HandMorphTest.OnInit | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_hand_morph_test.html#a727f489c765c1180e598bb9764f3df30)OnEditorInit()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.Scripts.HandMorphTest.OnEditorInit | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_hand_morph_test.html#a6665d8138c007c2d70f333a5de08ca26)OnEditorTick()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.Scripts.HandMorphTest.OnEditorTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_hand_morph_test.html#a19b4fed34b575139a518927f06fcf1c4)SpawnCharacter()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Scripts.HandMorphTest.SpawnCharacter | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_hand_morph_test.html#ac6b16c3f70f815378e4d1cfa4d89c240)Reset()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Scripts.HandMorphTest.Reset | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_hand_morph_test.html#a039f0eec079fb2889c566783eb53f42a)InitWithCharacter()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Scripts.HandMorphTest.InitWithCharacter | ( | [CharacterCode](class_tale_worlds_1_1_core_1_1_character_code.html) | *characterCode* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_hand_morph_test.html#a46b9857ce3035c24f064cd031a4cd236)OnRemoved()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.Scripts.HandMorphTest.OnRemoved | ( | int | *removeReason* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a4778f913080fc216866daa15518c8ecd).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_hand_morph_test.html#ae8dfcb4ac7a00f40cef1074111ea5359)ClothColor1
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.MountAndBlade.View.Scripts.HandMorphTest.ClothColor1 | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_hand_morph_test.html#a3839a08f8c325be0505b591b5e13f9c4)ClothColor2
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.MountAndBlade.View.Scripts.HandMorphTest.ClothColor2 | | get |

