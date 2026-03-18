--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_sound_player.html ---

TaleWorlds.MountAndBlade.SoundPlayer Class ReferenceInherits [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [UpdatePlaying](class_tale_worlds_1_1_mount_and_blade_1_1_sound_player.html#aa63b652194fbd036d516e129427e7e8e) () |
| void | [PlaySound](class_tale_worlds_1_1_mount_and_blade_1_1_sound_player.html#a9089d3b4976b1679e50847976cc8db7d) () |
| void | [ResumeSound](class_tale_worlds_1_1_mount_and_blade_1_1_sound_player.html#ab055525bcb65e95822ce8e5a921e2aa6) () |
| void | [PauseSound](class_tale_worlds_1_1_mount_and_blade_1_1_sound_player.html#aa9c382d0156c4b64fa079aff2c456a1c) () |
| void | [StopSound](class_tale_worlds_1_1_mount_and_blade_1_1_sound_player.html#aaa45c4a356a0079e3c4ef65c1e42912a) () |
| override [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) | [GetTickRequirement](class_tale_worlds_1_1_mount_and_blade_1_1_sound_player.html#a6d986389f2ec637c64f1423c3205b4b6) () |
| Public Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [SetScriptComponentToTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ae15c963749bd0f9a75bba24a333b39d4) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) tickReq) |
| void | [SetScriptComponentToTickMT](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a9b2183852eb7b70042ed82ef917022c6) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) value) |

|  |  |
| --- | --- |
| Public Attributes | |
| bool | [AutoLoop](class_tale_worlds_1_1_mount_and_blade_1_1_sound_player.html#afa002fb5581548ede96362f1e7bb4fc1) |
| bool | [AutoStart](class_tale_worlds_1_1_mount_and_blade_1_1_sound_player.html#a0269543b362967a31ad7e4f9939aff8b) |
| string | [SoundName](class_tale_worlds_1_1_mount_and_blade_1_1_sound_player.html#a0382628515015ed59b9ba1eee8ea1534) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Types inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| enum | [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) : uint {     [None](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da6adf97f83acf6453d4a6a4b1070f3754) = 0x00000000 ,     [TickOccasionally](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da9cee052f50afabfc1098c1aa6af80b75) = 0x00000001 ,     [Tick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0b3516a5bbb77566f904f9d3877f4710) = 0x00000002 ,     [TickParallel](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da5f5a8f4b9ce783164665db4d70e03ee3) = 0x00000004 ,     [TickParallel2](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0ea9f0c260cdfd8b20ce19a48dbc329f) = 0x00000008 ,     [FixedTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154dadd067942f0b8cc66859698bc9711ba15) = 0x00000010 ,     [FixedParallelTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daa226d712a5ffd8d400f850393ff68492) = 0x00000020 ,     [TickParallel3](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daf785c2c005d708ea434168efc10611b8) = 0x00000040   } |
| Protected Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [InvalidateWeakPointersIfValid](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#af39d73d0c78790ba81a40a5a350c0526) () |
|  | [ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0bc136bb53989f2b9a4f23f12f54a332) () |
| virtual void | [OnRemoved](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a4778f913080fc216866daa15518c8ecd) (int removeReason) |
| Properties inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | [GameEntity](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0a02cc65cc567db6101ea4afa275ff36) `[get]` |
| [ManagedScriptComponent](class_tale_worlds_1_1_engine_1_1_managed_script_component.html) | [ScriptComponent](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a8d7c5772e6b456b1e22ccd46a0b391ce) `[get]` |
| ManagedScriptHolder | [ManagedScriptHolder](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a58417dd71bf3daca6eb58df177617c2d) `[get]` |
| Scene | [Scene](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a9d7d5b77582948847f1d1c532face2c8) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_sound_player.html#aa63b652194fbd036d516e129427e7e8e)UpdatePlaying()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SoundPlayer.UpdatePlaying | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_sound_player.html#a9089d3b4976b1679e50847976cc8db7d)PlaySound()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SoundPlayer.PlaySound | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_sound_player.html#ab055525bcb65e95822ce8e5a921e2aa6)ResumeSound()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SoundPlayer.ResumeSound | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_sound_player.html#aa9c382d0156c4b64fa079aff2c456a1c)PauseSound()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SoundPlayer.PauseSound | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_sound_player.html#aaa45c4a356a0079e3c4ef65c1e42912a)StopSound()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SoundPlayer.StopSound | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_sound_player.html#a6d986389f2ec637c64f1423c3205b4b6)GetTickRequirement()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) TaleWorlds.MountAndBlade.SoundPlayer.GetTickRequirement | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ac17100a83d592505ed8d9ac565e512a5).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_sound_player.html#afa002fb5581548ede96362f1e7bb4fc1)AutoLoop
----------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.SoundPlayer.AutoLoop |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_sound_player.html#a0269543b362967a31ad7e4f9939aff8b)AutoStart
-----------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.SoundPlayer.AutoStart |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_sound_player.html#a0382628515015ed59b9ba1eee8ea1534)SoundName
-----------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.SoundPlayer.SoundName |

