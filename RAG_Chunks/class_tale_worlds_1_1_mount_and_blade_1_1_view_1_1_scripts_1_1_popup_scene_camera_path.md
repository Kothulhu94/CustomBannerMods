--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html ---

TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath Class ReferenceInherits [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

|  |  |
| --- | --- |
| Classes | |
| struct | [PathAnimationState](struct_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path_1_1_path_animation_state.html) |

|  |  |
| --- | --- |
| Public Types | |
| enum | [InterpolationType](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a63a5bb88d6e06c69f444c0a9fb3f6eab) {     [Linear](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a63a5bb88d6e06c69f444c0a9fb3f6eaba32a843da6ea40ab3b17a3421ccdf671b) ,     [EaseIn](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a63a5bb88d6e06c69f444c0a9fb3f6eaba477b68e0e4cd72802355d52831fee0ca) ,     [EaseOut](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a63a5bb88d6e06c69f444c0a9fb3f6eaba4d8256186c9d4f47eb7e7b7766812bd9) ,     [EaseInOut](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a63a5bb88d6e06c69f444c0a9fb3f6eabab5a2f8abee775e5f5f4c30e031739365)   } |
| Public Types inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| enum | [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) : uint {     [None](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da6adf97f83acf6453d4a6a4b1070f3754) = 0x00000000 ,     [TickOccasionally](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da9cee052f50afabfc1098c1aa6af80b75) = 0x00000001 ,     [Tick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0b3516a5bbb77566f904f9d3877f4710) = 0x00000002 ,     [TickParallel](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da5f5a8f4b9ce783164665db4d70e03ee3) = 0x00000004 ,     [TickParallel2](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0ea9f0c260cdfd8b20ce19a48dbc329f) = 0x00000008 ,     [FixedTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154dadd067942f0b8cc66859698bc9711ba15) = 0x00000010 ,     [FixedParallelTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daa226d712a5ffd8d400f850393ff68492) = 0x00000020 ,     [TickParallel3](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daf785c2c005d708ea434168efc10611b8) = 0x00000040   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [Initialize](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a924c95d3ebc1d006dc869577b51397eb) () |
| void | [SetInitialState](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a751c22adc3d90c8815f2b974699df586) () |
| void | [SetPositiveState](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#ab013c48cdfd4814884e0aa399632cc3e) () |
| void | [SetNegativeState](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a3623d5117c4eb0dc35da892dcfb722ea) () |
| void | [SetIsReady](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a9f4443c61b394e54133a78653cd59251) (bool isReady) |
| float | [GetCameraFade](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#afe2cb791050fce9d267045277dd45715) () |
| void | [Destroy](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a138b04fcf4cb18123bd1fddcf5adc4f8) () |
| override [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) | [GetTickRequirement](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#ad4fed1f9a176093d174c0132fc27b95b) () |
| Public Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [SetScriptComponentToTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ae15c963749bd0f9a75bba24a333b39d4) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) tickReq) |
| void | [SetScriptComponentToTickMT](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a9b2183852eb7b70042ed82ef917022c6) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) value) |

|  |  |
| --- | --- |
| Public Attributes | |
| string | [LookAtEntity](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a49f114265fb1d2f80a1a94ba7ff30126) = "" |
| string | [SkeletonName](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a56bc8bdf12bf04f2de4f6242d01213f8) = "" |
| int | [BoneIndex](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a97d1527a249451ab3a836dd135bef961) = 0 |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [AttachmentOffset](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#aa600458263c95d9059a0f60ac2d5b0ec) = new [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html)(0, 0, 0) |
| string | [InitialPath](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a55c9fd695f8f3a3cf9fcdad3b3e42b85) = "" |
| string | [InitialAnimationClip](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a00cea891b0773b9661a69143b061b3ba) = "" |
| string | [InitialSound](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#aef58b4c343f000c0c4b011fc9d4413e0) = "event:/mission/siege/siegetower/doorland" |
| float | [InitialPathStartTime](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a7f7bc4d352a86b4793716bbdc61eab02) = 0.0f |
| float | [InitialPathDuration](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a2f172e8c90ded077d634bdcac3124d1c) = 1.0f |
| [InterpolationType](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a63a5bb88d6e06c69f444c0a9fb3f6eab) | [InitialInterpolation](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#af793917aea87e6c8feee6fe3a84d82f6) = [InterpolationType.Linear](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a63a5bb88d6e06c69f444c0a9fb3f6eaba32a843da6ea40ab3b17a3421ccdf671b) |
| bool | [InitialFadeOut](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#abb5c554f192c92b69029511d756675d3) = false |
| string | [PositivePath](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a0453c8483723552359f6162f736e60d1) = "" |
| string | [PositiveAnimationClip](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a69f70a6cbaed48db3e90468acff66b08) = "" |
| string | [PositiveSound](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#aa7d97a962c9bd3dcede3abb76c2c71dc) = "" |
| float | [PositivePathStartTime](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a3decbfcc493630eee8af31a34d3b0eb1) = 0.0f |
| float | [PositivePathDuration](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a44b77ba7bab466a3cce0492f815ee97c) = 1.0f |
| [InterpolationType](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a63a5bb88d6e06c69f444c0a9fb3f6eab) | [PositiveInterpolation](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a25cb3bed4126d466f0fd8c9a50aa56a1) = [InterpolationType.Linear](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a63a5bb88d6e06c69f444c0a9fb3f6eaba32a843da6ea40ab3b17a3421ccdf671b) |
| bool | [PositiveFadeOut](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a027335d58f1bac4c8704fd5549890aa1) = false |
| string | [NegativePath](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#acba31e84bf2be9362046648a6b0c5fc4) = "" |
| string | [NegativeAnimationClip](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#ab6b34a633e8c88de8abedb7ce15ea9bf) = "" |
| string | [NegativeSound](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#ac0a58639ffa3f9aac38c13fd69373da1) = "" |
| float | [NegativePathStartTime](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a150ec112c93d79a433d2ae3375e6e2a8) = 0.0f |
| float | [NegativePathDuration](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a0e91a268a6cc68ee2077a95e2b15d774) = 1.0f |
| [InterpolationType](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a63a5bb88d6e06c69f444c0a9fb3f6eab) | [NegativeInterpolation](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#ad28115a8f017d0d44cad40cd4b6f20a3) = [InterpolationType.Linear](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a63a5bb88d6e06c69f444c0a9fb3f6eaba32a843da6ea40ab3b17a3421ccdf671b) |
| bool | [NegativeFadeOut](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#afff510afc9dc838ed0ad78fc2b9ad7f0) = false |
| [SimpleButton](class_tale_worlds_1_1_engine_1_1_simple_button.html) | [TestInitial](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a9aeb4a43ed3d731543f376662e590bf9) |
| [SimpleButton](class_tale_worlds_1_1_engine_1_1_simple_button.html) | [TestPositive](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#ab2ca0c5c5d3fd8653c009a79dcac060c) |
| [SimpleButton](class_tale_worlds_1_1_engine_1_1_simple_button.html) | [TestNegative](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#af3cce91dfccf92a80ceb7392cb80031c) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnInit](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a54beb0e6c8056e986217879120e5fa15) () |
|  | This callback method is called when the object is constructed. |
| override void | [OnEditorInit](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a829a7110f674a1deaede3017cc5c9033) () |
| override void | [OnTick](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a0749c942ab47a61e906e85b41b0be145) (float dt) |
| override void | [OnEditorTick](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a84dc0f2a1db210c7ef92c79bea8fb3c8) (float dt) |
| override void | [OnEditorVariableChanged](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#aa18a03afeb254fafe1b444f4898c71cf) (string variableName) |
|  | Called when an object's field has changed from the editor. |
| Protected Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [InvalidateWeakPointersIfValid](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#af39d73d0c78790ba81a40a5a350c0526) () |
|  | [ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0bc136bb53989f2b9a4f23f12f54a332) () |
| virtual void | [OnRemoved](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a4778f913080fc216866daa15518c8ecd) (int removeReason) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | [GameEntity](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0a02cc65cc567db6101ea4afa275ff36) `[get]` |
| [ManagedScriptComponent](class_tale_worlds_1_1_engine_1_1_managed_script_component.html) | [ScriptComponent](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a8d7c5772e6b456b1e22ccd46a0b391ce) `[get]` |
| ManagedScriptHolder | [ManagedScriptHolder](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a58417dd71bf3daca6eb58df177617c2d) `[get]` |
| Scene | [Scene](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a9d7d5b77582948847f1d1c532face2c8) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a63a5bb88d6e06c69f444c0a9fb3f6eab)InterpolationType
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath.InterpolationType](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a63a5bb88d6e06c69f444c0a9fb3f6eab) |

| Enumerator | |
| --- | --- |
| Linear |  |
| EaseIn |  |
| EaseOut |  |
| EaseInOut |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a54beb0e6c8056e986217879120e5fa15)OnInit()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath.OnInit | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a829a7110f674a1deaede3017cc5c9033)OnEditorInit()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath.OnEditorInit | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a924c95d3ebc1d006dc869577b51397eb)Initialize()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath.Initialize | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a751c22adc3d90c8815f2b974699df586)SetInitialState()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath.SetInitialState | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#ab013c48cdfd4814884e0aa399632cc3e)SetPositiveState()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath.SetPositiveState | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a3623d5117c4eb0dc35da892dcfb722ea)SetNegativeState()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath.SetNegativeState | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a9f4443c61b394e54133a78653cd59251)SetIsReady()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath.SetIsReady | ( | bool | *isReady* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#afe2cb791050fce9d267045277dd45715)GetCameraFade()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath.GetCameraFade | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a138b04fcf4cb18123bd1fddcf5adc4f8)Destroy()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath.Destroy | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#ad4fed1f9a176093d174c0132fc27b95b)GetTickRequirement()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath.GetTickRequirement | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ac17100a83d592505ed8d9ac565e512a5).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a0749c942ab47a61e906e85b41b0be145)OnTick()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath.OnTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a84dc0f2a1db210c7ef92c79bea8fb3c8)OnEditorTick()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath.OnEditorTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#aa18a03afeb254fafe1b444f4898c71cf)OnEditorVariableChanged()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath.OnEditorVariableChanged | ( | string | *variableName* | ) |  | | protectedvirtual |

Parameters
:   |  |  |
    | --- | --- |
    | variableName | Name of the field which has just changed. |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a49f114265fb1d2f80a1a94ba7ff30126)LookAtEntity
----------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath.LookAtEntity = "" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a56bc8bdf12bf04f2de4f6242d01213f8)SkeletonName
----------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath.SkeletonName = "" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a97d1527a249451ab3a836dd135bef961)BoneIndex
-------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath.BoneIndex = 0 |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#aa600458263c95d9059a0f60ac2d5b0ec)AttachmentOffset
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath.AttachmentOffset = new [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html)(0, 0, 0) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a55c9fd695f8f3a3cf9fcdad3b3e42b85)InitialPath
---------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath.InitialPath = "" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a00cea891b0773b9661a69143b061b3ba)InitialAnimationClip
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath.InitialAnimationClip = "" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#aef58b4c343f000c0c4b011fc9d4413e0)InitialSound
----------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath.InitialSound = "event:/mission/siege/siegetower/doorland" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a7f7bc4d352a86b4793716bbdc61eab02)InitialPathStartTime
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath.InitialPathStartTime = 0.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a2f172e8c90ded077d634bdcac3124d1c)InitialPathDuration
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath.InitialPathDuration = 1.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#af793917aea87e6c8feee6fe3a84d82f6)InitialInterpolation
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [InterpolationType](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a63a5bb88d6e06c69f444c0a9fb3f6eab) TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath.InitialInterpolation = [InterpolationType.Linear](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a63a5bb88d6e06c69f444c0a9fb3f6eaba32a843da6ea40ab3b17a3421ccdf671b) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#abb5c554f192c92b69029511d756675d3)InitialFadeOut
------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath.InitialFadeOut = false |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a0453c8483723552359f6162f736e60d1)PositivePath
----------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath.PositivePath = "" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a69f70a6cbaed48db3e90468acff66b08)PositiveAnimationClip
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath.PositiveAnimationClip = "" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#aa7d97a962c9bd3dcede3abb76c2c71dc)PositiveSound
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath.PositiveSound = "" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a3decbfcc493630eee8af31a34d3b0eb1)PositivePathStartTime
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath.PositivePathStartTime = 0.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a44b77ba7bab466a3cce0492f815ee97c)PositivePathDuration
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath.PositivePathDuration = 1.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a25cb3bed4126d466f0fd8c9a50aa56a1)PositiveInterpolation
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [InterpolationType](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a63a5bb88d6e06c69f444c0a9fb3f6eab) TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath.PositiveInterpolation = [InterpolationType.Linear](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a63a5bb88d6e06c69f444c0a9fb3f6eaba32a843da6ea40ab3b17a3421ccdf671b) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a027335d58f1bac4c8704fd5549890aa1)PositiveFadeOut
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath.PositiveFadeOut = false |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#acba31e84bf2be9362046648a6b0c5fc4)NegativePath
----------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath.NegativePath = "" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#ab6b34a633e8c88de8abedb7ce15ea9bf)NegativeAnimationClip
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath.NegativeAnimationClip = "" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#ac0a58639ffa3f9aac38c13fd69373da1)NegativeSound
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath.NegativeSound = "" |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a150ec112c93d79a433d2ae3375e6e2a8)NegativePathStartTime
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath.NegativePathStartTime = 0.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a0e91a268a6cc68ee2077a95e2b15d774)NegativePathDuration
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath.NegativePathDuration = 1.0f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#ad28115a8f017d0d44cad40cd4b6f20a3)NegativeInterpolation
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [InterpolationType](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a63a5bb88d6e06c69f444c0a9fb3f6eab) TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath.NegativeInterpolation = [InterpolationType.Linear](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a63a5bb88d6e06c69f444c0a9fb3f6eaba32a843da6ea40ab3b17a3421ccdf671b) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#afff510afc9dc838ed0ad78fc2b9ad7f0)NegativeFadeOut
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath.NegativeFadeOut = false |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#a9aeb4a43ed3d731543f376662e590bf9)TestInitial
---------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [SimpleButton](class_tale_worlds_1_1_engine_1_1_simple_button.html) TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath.TestInitial |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#ab2ca0c5c5d3fd8653c009a79dcac060c)TestPositive
----------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [SimpleButton](class_tale_worlds_1_1_engine_1_1_simple_button.html) TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath.TestPositive |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_scripts_1_1_popup_scene_camera_path.html#af3cce91dfccf92a80ceb7392cb80031c)TestNegative
----------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [SimpleButton](class_tale_worlds_1_1_engine_1_1_simple_button.html) TaleWorlds.MountAndBlade.View.Scripts.PopupSceneCameraPath.TestNegative |

