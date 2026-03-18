--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html ---

TaleWorlds.MountAndBlade.View.PopupSceneSpawnPoint Class ReferenceInherits [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [InitializeWithAgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#ac9955c44bf64bc7665421cc4c0454a38) ([AgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html) humanVisuals, [AgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html) mountVisuals=null) |
| void | [SetInitialState](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#a7a2b2665c6b7fa80db462c8710328b89) () |
| void | [SetPositiveState](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#a29f4ffe9fe822c1aa8f87faf9b4abac2) () |
| void | [SetNegativeState](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#aef8567b077f8a9b6501850df858111dd) () |
| void | [Destroy](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#a97ae28ad819f3aee64f7840458567dc3) () |
| override [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) | [GetTickRequirement](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#a9761ce5a179c7a42b7ab6d4043e76303) () |
| Public Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [SetScriptComponentToTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ae15c963749bd0f9a75bba24a333b39d4) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) tickReq) |
| void | [SetScriptComponentToTickMT](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a9b2183852eb7b70042ed82ef917022c6) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) value) |

|  |  |
| --- | --- |
| Public Attributes | |
| string | [InitialAction](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#a348bcde7cbae1284a09a72517c6cb4d8) = "" |
| string | [NegativeAction](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#a084881a677768e811f60d8b7d3a04e5b) = "" |
| string | [InitialFaceAnimCode](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#adb65e7b2e1642156976bfeeba0aeb003) = "" |
| string | [PositiveFaceAnimCode](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#a7d2e48b3e9431b47a2278a9e091d52ae) = "" |
| string | [NegativeFaceAnimCode](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#a824843bedf752ebd81e0672d7e67063a) = "" |
| string | [PositiveAction](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#ae16791aa7a85b66f3b740e6be4260f87) = "" |
| string | [LeftHandWieldedItem](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#a2149d833fa137f0fe49a2ab8dc64b8eb) = "" |
| string | [RightHandWieldedItem](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#a03ad87345d51098437b4d0dd459f06b0) = "" |
| string | [BannerTagToUseForAddedPrefab](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#a62717c9c668c938825e557776561c16f) = "" |
|  | Use this string for banner tag. We cannot add tags to agent visual entities so we'll only use this for apply banners to added prefabs. |
| bool | [StartWithRandomProgress](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#a59d428683d95dd8d487f525cbbd1162c) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [AttachedPrefabOffset](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#a3f4322e0c2faafaead68e01c06917547) = [Vec3.Zero](struct_tale_worlds_1_1_library_1_1_vec3.html#af98ad32c26dc5c52ad2198f3a9bf1975) |
| string | [PrefabItem](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#a718cd188e221be6758f2b323174c86d2) = "" |
| [HumanBone](namespace_tale_worlds_1_1_core.html#a47efca28876c843963d0ab7136b2bfb0) | [PrefabBone](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#a15c97012d5172d9a23801434d1754c10) = HumanBone.ItemR |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnInit](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#a2d66d57f0eb27a814d4e3f07fe3d5cbf) () |
|  | This callback method is called when the object is constructed. |
| override void | [OnTick](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#a7b6146fa60395417b1ed2719283beada) (float dt) |
| Protected Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [InvalidateWeakPointersIfValid](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#af39d73d0c78790ba81a40a5a350c0526) () |
|  | [ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0bc136bb53989f2b9a4f23f12f54a332) () |
| virtual void | [OnRemoved](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a4778f913080fc216866daa15518c8ecd) (int removeReason) |

|  |  |
| --- | --- |
| Properties | |
| [CompositeComponent](class_tale_worlds_1_1_engine_1_1_composite_component.html) | [AddedPrefabComponent](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#a5c9dbab40af0e53e96f1a173742769c1) `[get]` |
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

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#a2d66d57f0eb27a814d4e3f07fe3d5cbf)OnInit()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.PopupSceneSpawnPoint.OnInit | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#ac9955c44bf64bc7665421cc4c0454a38)InitializeWithAgentVisuals()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.PopupSceneSpawnPoint.InitializeWithAgentVisuals | ( | [AgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html) | *humanVisuals*, |
|  |  | [AgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html) | *mountVisuals* = null ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#a7a2b2665c6b7fa80db462c8710328b89)SetInitialState()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.PopupSceneSpawnPoint.SetInitialState | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#a29f4ffe9fe822c1aa8f87faf9b4abac2)SetPositiveState()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.PopupSceneSpawnPoint.SetPositiveState | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#aef8567b077f8a9b6501850df858111dd)SetNegativeState()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.PopupSceneSpawnPoint.SetNegativeState | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#a97ae28ad819f3aee64f7840458567dc3)Destroy()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.PopupSceneSpawnPoint.Destroy | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#a9761ce5a179c7a42b7ab6d4043e76303)GetTickRequirement()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) TaleWorlds.MountAndBlade.View.PopupSceneSpawnPoint.GetTickRequirement | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ac17100a83d592505ed8d9ac565e512a5).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#a7b6146fa60395417b1ed2719283beada)OnTick()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.PopupSceneSpawnPoint.OnTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#a348bcde7cbae1284a09a72517c6cb4d8)InitialAction
-----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.View.PopupSceneSpawnPoint.InitialAction = "" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#a084881a677768e811f60d8b7d3a04e5b)NegativeAction
------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.View.PopupSceneSpawnPoint.NegativeAction = "" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#adb65e7b2e1642156976bfeeba0aeb003)InitialFaceAnimCode
-----------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.View.PopupSceneSpawnPoint.InitialFaceAnimCode = "" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#a7d2e48b3e9431b47a2278a9e091d52ae)PositiveFaceAnimCode
------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.View.PopupSceneSpawnPoint.PositiveFaceAnimCode = "" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#a824843bedf752ebd81e0672d7e67063a)NegativeFaceAnimCode
------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.View.PopupSceneSpawnPoint.NegativeFaceAnimCode = "" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#ae16791aa7a85b66f3b740e6be4260f87)PositiveAction
------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.View.PopupSceneSpawnPoint.PositiveAction = "" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#a2149d833fa137f0fe49a2ab8dc64b8eb)LeftHandWieldedItem
-----------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.View.PopupSceneSpawnPoint.LeftHandWieldedItem = "" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#a03ad87345d51098437b4d0dd459f06b0)RightHandWieldedItem
------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.View.PopupSceneSpawnPoint.RightHandWieldedItem = "" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#a62717c9c668c938825e557776561c16f)BannerTagToUseForAddedPrefab
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.View.PopupSceneSpawnPoint.BannerTagToUseForAddedPrefab = "" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#a59d428683d95dd8d487f525cbbd1162c)StartWithRandomProgress
---------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.View.PopupSceneSpawnPoint.StartWithRandomProgress |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#a3f4322e0c2faafaead68e01c06917547)AttachedPrefabOffset
------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.View.PopupSceneSpawnPoint.AttachedPrefabOffset = [Vec3.Zero](struct_tale_worlds_1_1_library_1_1_vec3.html#af98ad32c26dc5c52ad2198f3a9bf1975) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#a718cd188e221be6758f2b323174c86d2)PrefabItem
--------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.View.PopupSceneSpawnPoint.PrefabItem = "" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#a15c97012d5172d9a23801434d1754c10)PrefabBone
--------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [HumanBone](namespace_tale_worlds_1_1_core.html#a47efca28876c843963d0ab7136b2bfb0) TaleWorlds.MountAndBlade.View.PopupSceneSpawnPoint.PrefabBone = HumanBone.ItemR |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_popup_scene_spawn_point.html#a5c9dbab40af0e53e96f1a173742769c1)AddedPrefabComponent
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CompositeComponent](class_tale_worlds_1_1_engine_1_1_composite_component.html) TaleWorlds.MountAndBlade.View.PopupSceneSpawnPoint.AddedPrefabComponent | | get |

