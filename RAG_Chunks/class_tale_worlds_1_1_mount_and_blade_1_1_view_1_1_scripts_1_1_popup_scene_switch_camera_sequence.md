--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_camera_sequence.html ---

TaleWorlds.MountAndBlade.View.Scripts.PopupSceneSwitchCameraSequence Class ReferenceInherits [TaleWorlds.MountAndBlade.View.Scripts.PopupSceneSequence](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_sequence.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [OnInitialState](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_camera_sequence.html#a6048f02505d8a0fb7ff7c1470946bea8) () |
| override void | [OnPositiveState](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_camera_sequence.html#a408e4bd9a1bf29ca5abe5a898a8bd812) () |
| override void | [OnNegativeState](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_camera_sequence.html#af4e15bc7dc7aede5db4080cfc0105ecd) () |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.View.Scripts.PopupSceneSequence](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_sequence.html) | |
| void | [InitializeWithAgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_sequence.html#aa41770183d4ddcde097877be33a0dc18) ([AgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html) visuals) |
|  | [PopupSceneSequence](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_sequence.html#ab832e61b6bc5218c8c9047a3af41e71b) () |
| override [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) | [GetTickRequirement](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_sequence.html#acb56e5fc97e6d6c60f6f30abe06a0214) () |
| void | [SetInitialState](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_sequence.html#a50de27faf8063fbbe0e4e967b6581008) () |
| void | [SetPositiveState](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_sequence.html#a42e38f6f46d90dd93208fbc1ea89ab06) () |
| void | [SetNegativeState](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_sequence.html#a2bedc096c748be7e1775b65b50dfbac7) () |
| Public Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [SetScriptComponentToTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ae15c963749bd0f9a75bba24a333b39d4) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) tickReq) |
| void | [SetScriptComponentToTickMT](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a9b2183852eb7b70042ed82ef917022c6) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) value) |

|  |  |
| --- | --- |
| Public Attributes | |
| string | [EntityName](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_camera_sequence.html#a941cf70e13e613a8a572e86c74bf91f2) = "" |
| Public Attributes inherited from [TaleWorlds.MountAndBlade.View.Scripts.PopupSceneSequence](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_sequence.html) | |
| float | [InitialActivationTime](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_sequence.html#ae38ba972216272c780466804ed3b52ce) |
| float | [PositiveActivationTime](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_sequence.html#aec155073e5bffb14b5d8b61bb8157633) |
| float | [NegativeActivationTime](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_sequence.html#afcc7046b2a58717bce9964f602d437e4) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnInit](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_camera_sequence.html#ad266720c6c44335f85dd7304d934cc9d) () |
|  | This callback method is called when the object is constructed. |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.View.Scripts.PopupSceneSequence](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_sequence.html) | |
| override void | [OnTick](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_sequence.html#a694ea7838fe5d7452c178165b2ca1d25) (float dt) |
| Protected Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [InvalidateWeakPointersIfValid](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#af39d73d0c78790ba81a40a5a350c0526) () |
|  | [ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0bc136bb53989f2b9a4f23f12f54a332) () |
| virtual void | [OnRemoved](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a4778f913080fc216866daa15518c8ecd) (int removeReason) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Types inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| enum | [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) : uint {     [None](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da6adf97f83acf6453d4a6a4b1070f3754) = 0x00000000 ,     [TickOccasionally](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da9cee052f50afabfc1098c1aa6af80b75) = 0x00000001 ,     [Tick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0b3516a5bbb77566f904f9d3877f4710) = 0x00000002 ,     [TickParallel](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da5f5a8f4b9ce783164665db4d70e03ee3) = 0x00000004 ,     [TickParallel2](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0ea9f0c260cdfd8b20ce19a48dbc329f) = 0x00000008 ,     [FixedTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154dadd067942f0b8cc66859698bc9711ba15) = 0x00000010 ,     [FixedParallelTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daa226d712a5ffd8d400f850393ff68492) = 0x00000020 ,     [TickParallel3](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daf785c2c005d708ea434168efc10611b8) = 0x00000040   } |
| Protected Attributes inherited from [TaleWorlds.MountAndBlade.View.Scripts.PopupSceneSequence](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_sequence.html) | |
| [AgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_agent_visuals.html) | [\_agentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_sequence.html#ae06b3013956d3763146b1ce7e46d22bc) |
| float | [\_time](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_sequence.html#af84214a2545ce60feb614857035cb9d7) |
| bool | [\_triggered](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_sequence.html#a17d20c3d1382cde19a1fb1a0c66d77dc) |
| int | [\_state](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_sequence.html#ac0461ce3c4a0cc1f619eac2d6ec1f4f4) |
| Properties inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | [GameEntity](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0a02cc65cc567db6101ea4afa275ff36) `[get]` |
| [ManagedScriptComponent](class_tale_worlds_1_1_engine_1_1_managed_script_component.html) | [ScriptComponent](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a8d7c5772e6b456b1e22ccd46a0b391ce) `[get]` |
| ManagedScriptHolder | [ManagedScriptHolder](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a58417dd71bf3daca6eb58df177617c2d) `[get]` |
| Scene | [Scene](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a9d7d5b77582948847f1d1c532face2c8) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_camera_sequence.html#ad266720c6c44335f85dd7304d934cc9d)OnInit()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.Scripts.PopupSceneSwitchCameraSequence.OnInit | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.View.Scripts.PopupSceneSequence](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_sequence.html#a1868fef1ac8e54b4df863827edab7312).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_camera_sequence.html#a6048f02505d8a0fb7ff7c1470946bea8)OnInitialState()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.Scripts.PopupSceneSwitchCameraSequence.OnInitialState | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.View.Scripts.PopupSceneSequence](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_sequence.html#a878325893be2cc5eedd73401b552e704).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_camera_sequence.html#a408e4bd9a1bf29ca5abe5a898a8bd812)OnPositiveState()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.Scripts.PopupSceneSwitchCameraSequence.OnPositiveState | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.View.Scripts.PopupSceneSequence](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_sequence.html#a2faf5a37f022625333058dfbd7c9d2f4).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_camera_sequence.html#af4e15bc7dc7aede5db4080cfc0105ecd)OnNegativeState()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.Scripts.PopupSceneSwitchCameraSequence.OnNegativeState | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.View.Scripts.PopupSceneSequence](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_sequence.html#a057227ca97ad8543ce93edf4080d6a7f).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_camera_sequence.html#a941cf70e13e613a8a572e86c74bf91f2)EntityName
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.View.Scripts.PopupSceneSwitchCameraSequence.EntityName = "" |

