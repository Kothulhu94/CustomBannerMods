--- SOURCE: class_sand_box_1_1_objects_1_1_cinematics_1_1_skeleton_animated_camera.html ---

SandBox.Objects.Cinematics.SkeletonAnimatedCamera Class ReferenceInherits [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

|  |  |
| --- | --- |
| Public Attributes | |
| string | [SkeletonName](class_sand_box_1_1_objects_1_1_cinematics_1_1_skeleton_animated_camera.html#afcb5141dd27ae93400ffd4fc40206b1a) = "human\_skeleton" |
| int | [BoneIndex](class_sand_box_1_1_objects_1_1_cinematics_1_1_skeleton_animated_camera.html#a32ad8a2e7cef9459799e2c6a0dd4f175) = 0 |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [AttachmentOffset](class_sand_box_1_1_objects_1_1_cinematics_1_1_skeleton_animated_camera.html#a1ec4acd0da615ac4a0be68a5a894c8e6) = new [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html)(0, 0, 0) |
| string | [AnimationName](class_sand_box_1_1_objects_1_1_cinematics_1_1_skeleton_animated_camera.html#adaebd9e7b1d4393196ae3b5cec7d0af1) = "" |
| [SimpleButton](class_tale_worlds_1_1_engine_1_1_simple_button.html) | [Restart](class_sand_box_1_1_objects_1_1_cinematics_1_1_skeleton_animated_camera.html#a4a250faaac9adfa9d073ba3576517a79) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnInit](class_sand_box_1_1_objects_1_1_cinematics_1_1_skeleton_animated_camera.html#a3f3590f18a3219e003a4e0cda3a08fc1) () |
|  | This callback method is called when the object is constructed. |
| override void | [OnEditorInit](class_sand_box_1_1_objects_1_1_cinematics_1_1_skeleton_animated_camera.html#ad6212bf5b430a06521cc821daa755ec0) () |
| override void | [OnTick](class_sand_box_1_1_objects_1_1_cinematics_1_1_skeleton_animated_camera.html#aca40177e34e13bb2c4f1828c23a73f74) (float dt) |
| override void | [OnEditorTick](class_sand_box_1_1_objects_1_1_cinematics_1_1_skeleton_animated_camera.html#a87ea077a640e7b75ac8dccb974b1da56) (float dt) |
| override void | [OnEditorVariableChanged](class_sand_box_1_1_objects_1_1_cinematics_1_1_skeleton_animated_camera.html#a97148859a1936d7aecfe1bfc51c26d3d) (string variableName) |
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

[◆](class_sand_box_1_1_objects_1_1_cinematics_1_1_skeleton_animated_camera.html#a3f3590f18a3219e003a4e0cda3a08fc1)OnInit()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.Objects.Cinematics.SkeletonAnimatedCamera.OnInit | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

[◆](class_sand_box_1_1_objects_1_1_cinematics_1_1_skeleton_animated_camera.html#ad6212bf5b430a06521cc821daa755ec0)OnEditorInit()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.Objects.Cinematics.SkeletonAnimatedCamera.OnEditorInit | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

[◆](class_sand_box_1_1_objects_1_1_cinematics_1_1_skeleton_animated_camera.html#aca40177e34e13bb2c4f1828c23a73f74)OnTick()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.Objects.Cinematics.SkeletonAnimatedCamera.OnTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

[◆](class_sand_box_1_1_objects_1_1_cinematics_1_1_skeleton_animated_camera.html#a87ea077a640e7b75ac8dccb974b1da56)OnEditorTick()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.Objects.Cinematics.SkeletonAnimatedCamera.OnEditorTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

[◆](class_sand_box_1_1_objects_1_1_cinematics_1_1_skeleton_animated_camera.html#a97148859a1936d7aecfe1bfc51c26d3d)OnEditorVariableChanged()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.Objects.Cinematics.SkeletonAnimatedCamera.OnEditorVariableChanged | ( | string | *variableName* | ) |  | | protectedvirtual |

Parameters
:   |  |  |
    | --- | --- |
    | variableName | Name of the field which has just changed. |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_objects_1_1_cinematics_1_1_skeleton_animated_camera.html#afcb5141dd27ae93400ffd4fc40206b1a)SkeletonName
------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string SandBox.Objects.Cinematics.SkeletonAnimatedCamera.SkeletonName = "human\_skeleton" |

[◆](class_sand_box_1_1_objects_1_1_cinematics_1_1_skeleton_animated_camera.html#a32ad8a2e7cef9459799e2c6a0dd4f175)BoneIndex
---------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int SandBox.Objects.Cinematics.SkeletonAnimatedCamera.BoneIndex = 0 |

[◆](class_sand_box_1_1_objects_1_1_cinematics_1_1_skeleton_animated_camera.html#a1ec4acd0da615ac4a0be68a5a894c8e6)AttachmentOffset
----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) SandBox.Objects.Cinematics.SkeletonAnimatedCamera.AttachmentOffset = new [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html)(0, 0, 0) |

[◆](class_sand_box_1_1_objects_1_1_cinematics_1_1_skeleton_animated_camera.html#adaebd9e7b1d4393196ae3b5cec7d0af1)AnimationName
-------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string SandBox.Objects.Cinematics.SkeletonAnimatedCamera.AnimationName = "" |

[◆](class_sand_box_1_1_objects_1_1_cinematics_1_1_skeleton_animated_camera.html#a4a250faaac9adfa9d073ba3576517a79)Restart
-------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [SimpleButton](class_tale_worlds_1_1_engine_1_1_simple_button.html) SandBox.Objects.Cinematics.SkeletonAnimatedCamera.Restart |

