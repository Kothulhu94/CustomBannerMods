--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html ---

TaleWorlds.MountAndBlade.View.Scripts.CharacterSpawner Class ReferenceInherits [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [SetCreateFaceImmediately](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#a865a7b061a061a15b280b9c481d66ebe) (bool value) |
| void | [SetClothColors](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#a5db4b045be989bcaf58e0b5c5a6951ff) (uint color1, uint color2) |
| void | [SpawnCharacter](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#a0c59d3e5a76a0e421c4ff495191a20c3) () |
| void | [InitWithCharacter](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#abb2df830688a0c5f5019aeb7ca256973) ([CharacterCode](class_tale_worlds_1_1_core_1_1_character_code.html) characterCode, bool useBodyProperties=false) |
| Public Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [SetScriptComponentToTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ae15c963749bd0f9a75bba24a333b39d4) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) tickReq) |
| void | [SetScriptComponentToTickMT](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a9b2183852eb7b70042ed82ef917022c6) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) value) |
| virtual [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) | [GetTickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ac17100a83d592505ed8d9ac565e512a5) () |

|  |  |
| --- | --- |
| Public Attributes | |
| bool | [Enabled](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#a83a6741babc3d97134d6a79d01079c44) = false |
| string | [PoseAction](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#ae4917b9b796de4809a735c2b1734d582) = "act\_walk\_idle\_unarmed" |
| string | [LordName](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#a1a57b8d2736136fd88c96a6bf12ee089) = "main\_hero\_for\_perf" |
| string | [ActionSetSuffix](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#a2cbf30f94b0fb8c3a4cefdb4572c0c5d) = "\_facegen" |
| string | [PoseActionForHorse](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#af159866bda71079867409693030bc2ba) = "horse\_stand\_3" |
| string | [BodyPropertiesString](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#a6c45d725b87d72e212a42645f20b16b5) = "<BodyProperties version=\"4\" age=\"23.16\" weight=\"0.3333\" build=\"0\" key=\"00000C07000000010011111211151111000701000010000000111011000101000000500202111110000000000000000000000000000000000000000000A00000\" />" |
| bool | [IsWeaponWielded](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#a1eeb5609d58511a809913d344296ba73) = false |
| bool | [HasMount](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#af4e942922d4e919e8a2796dfbc2c97d5) = false |
| bool | [WieldOffHand](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#a02f1ca135f8e90d5e2d413095d5d0acf) = true |
| float | [AnimationProgress](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#a50add29601facb81f98e296317101d1a) = 0 |
| float | [HorseAnimationProgress](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#a33950e4e6f1a203ecb00b2c4cae226e9) = 0 |
| bool | [Active](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#af958472e21b3eecb2b342c416dd966bb) = false |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnInit](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#a9f7849d9a1bb49abc0c678862acd1121) () |
|  | This callback method is called when the object is constructed. |
| void | [Init](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#ae235f9fa55edcdbb8299b222d36eb6eb) () |
| override void | [OnEditorInit](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#a63d841e4e911a8c7915bd54a37f7016a) () |
| override void | [OnEditorTick](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#ae0f6babc975c3293d898ee90f46555e2) (float dt) |
| override void | [OnRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#ac3e658d7af936707ca155bac90a06a95) (int removeReason) |
| override void | [OnEditorVariableChanged](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#af1da6231e14401eff77349b39ab888b9) (string variableName) |
|  | Called when an object's field has changed from the editor. |
| Protected Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [InvalidateWeakPointersIfValid](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#af39d73d0c78790ba81a40a5a350c0526) () |
|  | [ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0bc136bb53989f2b9a4f23f12f54a332) () |

|  |  |
| --- | --- |
| Properties | |
| uint | [ClothColor1](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#a2c3c2356e41c9d0feaf43c4c52bf65cc) `[get]` |
| uint | [ClothColor2](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#a9f6e15c446c5f4d9ce8577912e7cd872) `[get]` |
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

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#a9f7849d9a1bb49abc0c678862acd1121)OnInit()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.Scripts.CharacterSpawner.OnInit | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#ae235f9fa55edcdbb8299b222d36eb6eb)Init()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.View.Scripts.CharacterSpawner.Init | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#a63d841e4e911a8c7915bd54a37f7016a)OnEditorInit()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.Scripts.CharacterSpawner.OnEditorInit | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#ae0f6babc975c3293d898ee90f46555e2)OnEditorTick()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.Scripts.CharacterSpawner.OnEditorTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#ac3e658d7af936707ca155bac90a06a95)OnRemoved()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.Scripts.CharacterSpawner.OnRemoved | ( | int | *removeReason* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a4778f913080fc216866daa15518c8ecd).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#a865a7b061a061a15b280b9c481d66ebe)SetCreateFaceImmediately()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Scripts.CharacterSpawner.SetCreateFaceImmediately | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#af1da6231e14401eff77349b39ab888b9)OnEditorVariableChanged()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.Scripts.CharacterSpawner.OnEditorVariableChanged | ( | string | *variableName* | ) |  | | protectedvirtual |

Parameters
:   |  |  |
    | --- | --- |
    | variableName | Name of the field which has just changed. |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#a5db4b045be989bcaf58e0b5c5a6951ff)SetClothColors()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Scripts.CharacterSpawner.SetClothColors | ( | uint | *color1*, |
|  |  | uint | *color2* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#a0c59d3e5a76a0e421c4ff495191a20c3)SpawnCharacter()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Scripts.CharacterSpawner.SpawnCharacter | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#abb2df830688a0c5f5019aeb7ca256973)InitWithCharacter()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Scripts.CharacterSpawner.InitWithCharacter | ( | [CharacterCode](class_tale_worlds_1_1_core_1_1_character_code.html) | *characterCode*, |
|  |  | bool | *useBodyProperties* = false ) |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#a83a6741babc3d97134d6a79d01079c44)Enabled
-----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.View.Scripts.CharacterSpawner.Enabled = false |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#ae4917b9b796de4809a735c2b1734d582)PoseAction
--------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.View.Scripts.CharacterSpawner.PoseAction = "act\_walk\_idle\_unarmed" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#a1a57b8d2736136fd88c96a6bf12ee089)LordName
------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.View.Scripts.CharacterSpawner.LordName = "main\_hero\_for\_perf" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#a2cbf30f94b0fb8c3a4cefdb4572c0c5d)ActionSetSuffix
-------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.View.Scripts.CharacterSpawner.ActionSetSuffix = "\_facegen" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#af159866bda71079867409693030bc2ba)PoseActionForHorse
----------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.View.Scripts.CharacterSpawner.PoseActionForHorse = "horse\_stand\_3" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#a6c45d725b87d72e212a42645f20b16b5)BodyPropertiesString
------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.View.Scripts.CharacterSpawner.BodyPropertiesString = "<BodyProperties version=\"4\" age=\"23.16\" weight=\"0.3333\" build=\"0\" key=\"00000C07000000010011111211151111000701000010000000111011000101000000500202111110000000000000000000000000000000000000000000A00000\" />" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#a1eeb5609d58511a809913d344296ba73)IsWeaponWielded
-------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.View.Scripts.CharacterSpawner.IsWeaponWielded = false |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#af4e942922d4e919e8a2796dfbc2c97d5)HasMount
------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.View.Scripts.CharacterSpawner.HasMount = false |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#a02f1ca135f8e90d5e2d413095d5d0acf)WieldOffHand
----------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.View.Scripts.CharacterSpawner.WieldOffHand = true |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#a50add29601facb81f98e296317101d1a)AnimationProgress
---------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.View.Scripts.CharacterSpawner.AnimationProgress = 0 |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#a33950e4e6f1a203ecb00b2c4cae226e9)HorseAnimationProgress
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.View.Scripts.CharacterSpawner.HorseAnimationProgress = 0 |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#af958472e21b3eecb2b342c416dd966bb)Active
----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.View.Scripts.CharacterSpawner.Active = false |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#a2c3c2356e41c9d0feaf43c4c52bf65cc)ClothColor1
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.MountAndBlade.View.Scripts.CharacterSpawner.ClothColor1 | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_character_spawner.html#a9f6e15c446c5f4d9ce8577912e7cd872)ClothColor2
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.MountAndBlade.View.Scripts.CharacterSpawner.ClothColor2 | | get |

