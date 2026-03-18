--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html ---

TaleWorlds.MountAndBlade.View.Scripts.PopupSceneSwitchItemSequence Class ReferenceInherits [TaleWorlds.MountAndBlade.View.Scripts.PopupSceneSequence](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_sequence.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [BodyPartIndex](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#ad5ee2584610f2cf7d50a38657cf70f4c) {     [None](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#ad5ee2584610f2cf7d50a38657cf70f4ca6adf97f83acf6453d4a6a4b1070f3754) ,     [Weapon0](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#ad5ee2584610f2cf7d50a38657cf70f4cae3aaf2f7d6899cccd7b074b95bfd3f55) ,     [Weapon1](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#ad5ee2584610f2cf7d50a38657cf70f4ca45b8e35ca0d193d01df2cf1858e27e55) ,     [Weapon2](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#ad5ee2584610f2cf7d50a38657cf70f4ca2905fb91ecc7d7758ecfd869b369428d) ,     [Weapon3](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#ad5ee2584610f2cf7d50a38657cf70f4ca3e0d5c63a23464e75ff485bbf6fa34ce) ,     [ExtraWeaponSlot](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#ad5ee2584610f2cf7d50a38657cf70f4ca98133612b9f36e4d74aaa56246d30161) ,     [Head](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#ad5ee2584610f2cf7d50a38657cf70f4ca98921133d10fbdb0fb6dbb7b2648befe) ,     [Body](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#ad5ee2584610f2cf7d50a38657cf70f4caac101b32dda4448cf13a93fe283dddd8) ,     [Leg](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#ad5ee2584610f2cf7d50a38657cf70f4cacacda5f1cfd4d67ed61e3befe20a63d7) ,     [Gloves](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#ad5ee2584610f2cf7d50a38657cf70f4ca643fdaf1fef54e8def751f54b706cd60) ,     [Cape](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#ad5ee2584610f2cf7d50a38657cf70f4ca679355c6c670c65aeddd96d9724159f2) ,     [Horse](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#ad5ee2584610f2cf7d50a38657cf70f4ca38069b4eb64e325cb7ac65bd641b2188) ,     [HorseHarness](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#ad5ee2584610f2cf7d50a38657cf70f4ca4c2ce960d67fa946e5de7d3a1748ac47)   } |
| Public Types inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| enum | [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) : uint {     [None](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da6adf97f83acf6453d4a6a4b1070f3754) = 0x00000000 ,     [TickOccasionally](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da9cee052f50afabfc1098c1aa6af80b75) = 0x00000001 ,     [Tick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0b3516a5bbb77566f904f9d3877f4710) = 0x00000002 ,     [TickParallel](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da5f5a8f4b9ce783164665db4d70e03ee3) = 0x00000004 ,     [TickParallel2](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0ea9f0c260cdfd8b20ce19a48dbc329f) = 0x00000008 ,     [FixedTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154dadd067942f0b8cc66859698bc9711ba15) = 0x00000010 ,     [FixedParallelTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daa226d712a5ffd8d400f850393ff68492) = 0x00000020 ,     [TickParallel3](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daf785c2c005d708ea434168efc10611b8) = 0x00000040   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [OnInitialState](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#a9d5fa0cd7a3941e7105eb9e4fbdacbb3) () |
| override void | [OnPositiveState](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#a52bb08648b5646bbe3687859a5fa8d4f) () |
| override void | [OnNegativeState](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#a9b35c01ac252e1670131c9aa8859e712) () |
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
| string | [InitialItem](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#aa98d10e50dea9bf301dd0fc0e3b54828) |
| string | [PositiveItem](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#ad38da0d6d0ef1bdee69cbc44129bc971) |
| string | [NegativeItem](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#a8cd5b8e5166a7e2612ebeaaf7c0ee6b2) |
| [BodyPartIndex](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#ad5ee2584610f2cf7d50a38657cf70f4c) | [InitialBodyPart](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#a6f50f7905354563584a8ce99b1dccaf6) = [BodyPartIndex.None](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#ad5ee2584610f2cf7d50a38657cf70f4ca6adf97f83acf6453d4a6a4b1070f3754) |
| [BodyPartIndex](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#ad5ee2584610f2cf7d50a38657cf70f4c) | [PositiveBodyPart](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#a1668ee7ca58207d1abe759b3c51b322f) = [BodyPartIndex.None](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#ad5ee2584610f2cf7d50a38657cf70f4ca6adf97f83acf6453d4a6a4b1070f3754) |
| [BodyPartIndex](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#ad5ee2584610f2cf7d50a38657cf70f4c) | [NegativeBodyPart](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#a5f25644a71d18dd4fcc86673fa19ed9f) = [BodyPartIndex.None](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#ad5ee2584610f2cf7d50a38657cf70f4ca6adf97f83acf6453d4a6a4b1070f3754) |
| Public Attributes inherited from [TaleWorlds.MountAndBlade.View.Scripts.PopupSceneSequence](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_sequence.html) | |
| float | [InitialActivationTime](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_sequence.html#ae38ba972216272c780466804ed3b52ce) |
| float | [PositiveActivationTime](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_sequence.html#aec155073e5bffb14b5d8b61bb8157633) |
| float | [NegativeActivationTime](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_sequence.html#afcc7046b2a58717bce9964f602d437e4) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.View.Scripts.PopupSceneSequence](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_sequence.html) | |
| override void | [OnInit](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_sequence.html#a1868fef1ac8e54b4df863827edab7312) () |
|  | This callback method is called when the object is constructed. |
| override void | [OnTick](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_sequence.html#a694ea7838fe5d7452c178165b2ca1d25) (float dt) |
| Protected Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [InvalidateWeakPointersIfValid](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#af39d73d0c78790ba81a40a5a350c0526) () |
|  | [ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0bc136bb53989f2b9a4f23f12f54a332) () |
| virtual void | [OnRemoved](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a4778f913080fc216866daa15518c8ecd) (int removeReason) |
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

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#ad5ee2584610f2cf7d50a38657cf70f4c)BodyPartIndex
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.View.Scripts.PopupSceneSwitchItemSequence.BodyPartIndex](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#ad5ee2584610f2cf7d50a38657cf70f4c) |

| Enumerator | |
| --- | --- |
| None |  |
| Weapon0 |  |
| Weapon1 |  |
| Weapon2 |  |
| Weapon3 |  |
| ExtraWeaponSlot |  |
| Head |  |
| Body |  |
| Leg |  |
| Gloves |  |
| Cape |  |
| Horse |  |
| HorseHarness |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#a9d5fa0cd7a3941e7105eb9e4fbdacbb3)OnInitialState()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.Scripts.PopupSceneSwitchItemSequence.OnInitialState | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.View.Scripts.PopupSceneSequence](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_sequence.html#a878325893be2cc5eedd73401b552e704).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#a52bb08648b5646bbe3687859a5fa8d4f)OnPositiveState()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.Scripts.PopupSceneSwitchItemSequence.OnPositiveState | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.View.Scripts.PopupSceneSequence](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_sequence.html#a2faf5a37f022625333058dfbd7c9d2f4).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#a9b35c01ac252e1670131c9aa8859e712)OnNegativeState()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.Scripts.PopupSceneSwitchItemSequence.OnNegativeState | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.View.Scripts.PopupSceneSequence](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_sequence.html#a057227ca97ad8543ce93edf4080d6a7f).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#aa98d10e50dea9bf301dd0fc0e3b54828)InitialItem
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.View.Scripts.PopupSceneSwitchItemSequence.InitialItem |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#ad38da0d6d0ef1bdee69cbc44129bc971)PositiveItem
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.View.Scripts.PopupSceneSwitchItemSequence.PositiveItem |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#a8cd5b8e5166a7e2612ebeaaf7c0ee6b2)NegativeItem
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.View.Scripts.PopupSceneSwitchItemSequence.NegativeItem |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#a6f50f7905354563584a8ce99b1dccaf6)InitialBodyPart
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [BodyPartIndex](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#ad5ee2584610f2cf7d50a38657cf70f4c) TaleWorlds.MountAndBlade.View.Scripts.PopupSceneSwitchItemSequence.InitialBodyPart = [BodyPartIndex.None](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#ad5ee2584610f2cf7d50a38657cf70f4ca6adf97f83acf6453d4a6a4b1070f3754) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#a1668ee7ca58207d1abe759b3c51b322f)PositiveBodyPart
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [BodyPartIndex](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#ad5ee2584610f2cf7d50a38657cf70f4c) TaleWorlds.MountAndBlade.View.Scripts.PopupSceneSwitchItemSequence.PositiveBodyPart = [BodyPartIndex.None](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#ad5ee2584610f2cf7d50a38657cf70f4ca6adf97f83acf6453d4a6a4b1070f3754) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#a5f25644a71d18dd4fcc86673fa19ed9f)NegativeBodyPart
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [BodyPartIndex](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#ad5ee2584610f2cf7d50a38657cf70f4c) TaleWorlds.MountAndBlade.View.Scripts.PopupSceneSwitchItemSequence.NegativeBodyPart = [BodyPartIndex.None](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_switch_item_sequence.html#ad5ee2584610f2cf7d50a38657cf70f4ca6adf97f83acf6453d4a6a4b1070f3754) |

