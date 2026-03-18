--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_debug_spawner.html ---

TaleWorlds.MountAndBlade.View.Scripts.CharacterDebugSpawner Class ReferenceInherits [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [SetClothColors](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_debug_spawner.html#a0e16aad5286e457b77ea83bac3fc4d33) (uint color1, uint color2) |
| void | [SpawnCharacter](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_debug_spawner.html#ad8f9620ccb720c418af25f4b5e7f2aa6) () |
| void | [Reset](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_debug_spawner.html#a3e58c47e937cb16e65fc3238e5b714b0) () |
| void | [InitWithCharacter](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_debug_spawner.html#ac1e131bf66fee19cc2447269f7c2b86b) ([CharacterCode](class_tale_worlds_1_1_core_1_1_character_code.html) characterCode) |
| void | [WieldWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_debug_spawner.html#aad98d50618ac96c727ae098a770a800c) ([CharacterCode](class_tale_worlds_1_1_core_1_1_character_code.html) characterCode) |
| Public Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [SetScriptComponentToTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ae15c963749bd0f9a75bba24a333b39d4) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) tickReq) |
| void | [SetScriptComponentToTickMT](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a9b2183852eb7b70042ed82ef917022c6) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) value) |
| virtual [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) | [GetTickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ac17100a83d592505ed8d9ac565e512a5) () |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) | [PoseAction](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_debug_spawner.html#af64bbc392ab26876a90b00965e0df987) = [ActionIndexCache.act\_walk\_idle\_unarmed](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html#a859f3af3f9aae7f7cad505f427fa12d4) |
| string | [LordName](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_debug_spawner.html#a253d5501806d5c37bf6dc96de663b3a2) = "main\_hero" |
| bool | [IsWeaponWielded](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_debug_spawner.html#ac623a49a5484f987aee603e2cc62a0d3) = false |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnInit](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_debug_spawner.html#a9a5733c731b2847fc1669d8bb08b9493) () |
|  | This callback method is called when the object is constructed. |
| override void | [OnEditorInit](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_debug_spawner.html#ad7ee30176ac7b6b13fc8d9ba7c450143) () |
| override void | [OnEditorTick](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_debug_spawner.html#aa3fa33c4f4ccae600dff77e6202317d4) (float dt) |
| override void | [OnRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_debug_spawner.html#a8b752f5d02c677045592e8decf36bb25) (int removeReason) |
| override void | [OnEditorVariableChanged](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_debug_spawner.html#ae249cb9d24ef733e425a4830c93df258) (string variableName) |
|  | Called when an object's field has changed from the editor. |
| Protected Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [InvalidateWeakPointersIfValid](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#af39d73d0c78790ba81a40a5a350c0526) () |
|  | [ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0bc136bb53989f2b9a4f23f12f54a332) () |

|  |  |
| --- | --- |
| Properties | |
| uint | [ClothColor1](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_debug_spawner.html#a4e02a255b13679999247f55955e97b64) `[get]` |
| uint | [ClothColor2](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_debug_spawner.html#a9d6312ba8a7158379c48822524d46f66) `[get]` |
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

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_debug_spawner.html#a9a5733c731b2847fc1669d8bb08b9493)OnInit()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.Scripts.CharacterDebugSpawner.OnInit | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_debug_spawner.html#ad7ee30176ac7b6b13fc8d9ba7c450143)OnEditorInit()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.Scripts.CharacterDebugSpawner.OnEditorInit | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_debug_spawner.html#aa3fa33c4f4ccae600dff77e6202317d4)OnEditorTick()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.Scripts.CharacterDebugSpawner.OnEditorTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_debug_spawner.html#a8b752f5d02c677045592e8decf36bb25)OnRemoved()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.Scripts.CharacterDebugSpawner.OnRemoved | ( | int | *removeReason* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a4778f913080fc216866daa15518c8ecd).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_debug_spawner.html#ae249cb9d24ef733e425a4830c93df258)OnEditorVariableChanged()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.Scripts.CharacterDebugSpawner.OnEditorVariableChanged | ( | string | *variableName* | ) |  | | protectedvirtual |

Parameters
:   |  |  |
    | --- | --- |
    | variableName | Name of the field which has just changed. |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_debug_spawner.html#a0e16aad5286e457b77ea83bac3fc4d33)SetClothColors()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Scripts.CharacterDebugSpawner.SetClothColors | ( | uint | *color1*, |
|  |  | uint | *color2* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_debug_spawner.html#ad8f9620ccb720c418af25f4b5e7f2aa6)SpawnCharacter()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Scripts.CharacterDebugSpawner.SpawnCharacter | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_debug_spawner.html#a3e58c47e937cb16e65fc3238e5b714b0)Reset()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Scripts.CharacterDebugSpawner.Reset | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_debug_spawner.html#ac1e131bf66fee19cc2447269f7c2b86b)InitWithCharacter()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Scripts.CharacterDebugSpawner.InitWithCharacter | ( | [CharacterCode](class_tale_worlds_1_1_core_1_1_character_code.html) | *characterCode* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_debug_spawner.html#aad98d50618ac96c727ae098a770a800c)WieldWeapon()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Scripts.CharacterDebugSpawner.WieldWeapon | ( | [CharacterCode](class_tale_worlds_1_1_core_1_1_character_code.html) | *characterCode* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_debug_spawner.html#af64bbc392ab26876a90b00965e0df987)PoseAction
--------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) TaleWorlds.MountAndBlade.View.Scripts.CharacterDebugSpawner.PoseAction = [ActionIndexCache.act\_walk\_idle\_unarmed](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html#a859f3af3f9aae7f7cad505f427fa12d4) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_debug_spawner.html#a253d5501806d5c37bf6dc96de663b3a2)LordName
------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.View.Scripts.CharacterDebugSpawner.LordName = "main\_hero" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_debug_spawner.html#ac623a49a5484f987aee603e2cc62a0d3)IsWeaponWielded
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.View.Scripts.CharacterDebugSpawner.IsWeaponWielded = false |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_debug_spawner.html#a4e02a255b13679999247f55955e97b64)ClothColor1
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.MountAndBlade.View.Scripts.CharacterDebugSpawner.ClothColor1 | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_debug_spawner.html#a9d6312ba8a7158379c48822524d46f66)ClothColor2
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.MountAndBlade.View.Scripts.CharacterDebugSpawner.ClothColor2 | | get |

