--- SOURCE: class_tale_worlds_1_1_engine_1_1_sound_event.html ---

TaleWorlds.Engine.SoundEvent Class ReferenceDefines any sound instance, used with events.

|  |  |
| --- | --- |
| Public Member Functions | |
| int | [GetSoundId](class_tale_worlds_1_1_engine_1_1_sound_event.html#a84ee558f84ca071f920b71bd9cfafa31) () |
| void | [SetEventMinMaxDistance](class_tale_worlds_1_1_engine_1_1_sound_event.html#a9feca32122f41e71f47cba76bc06b2d0) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) newRadius) |
| bool | [IsNullSoundEvent](class_tale_worlds_1_1_engine_1_1_sound_event.html#a37e72a0cafc3633e5fdd3f509050d550) () |
| bool | [Play](class_tale_worlds_1_1_engine_1_1_sound_event.html#a9b3dbdd44d8d3b70d5be2ef1b6760f70) () |
|  | Plays this instance. |
| void | [Pause](class_tale_worlds_1_1_engine_1_1_sound_event.html#a9889f10c61f5b6bc376da688e7cafde0) () |
|  | Pauses this instance. |
| void | [Resume](class_tale_worlds_1_1_engine_1_1_sound_event.html#ad7307c38ac39e7040d67233c2a407410) () |
|  | Resumes this instance. |
| void | [PlayExtraEvent](class_tale_worlds_1_1_engine_1_1_sound_event.html#a485a7b5c431c9e3c6d32a508fe116841) (string eventName) |
| void | [SetSwitch](class_tale_worlds_1_1_engine_1_1_sound_event.html#a679490824823ea2b7e273772d6767e49) (string switchGroupName, string newSwitchStateName) |
| void | [TriggerCue](class_tale_worlds_1_1_engine_1_1_sound_event.html#a4506fa5c8fe32d6e01bbd69b982fb687) () |
| bool | [PlayInPosition](class_tale_worlds_1_1_engine_1_1_sound_event.html#a496fbdde886beafa075f2e3f11c2faee) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position) |
|  | Sets the position first and plays this instance. Danger: sets the position permanently! any other StartEvent calls after this call, will be in this position. |
| void | [Stop](class_tale_worlds_1_1_engine_1_1_sound_event.html#aa593cf73d39f5e4cd4d161650da45061) () |
|  | Stops this instance. |
| void | [SetParameter](class_tale_worlds_1_1_engine_1_1_sound_event.html#a2fc2d9813676e53519c67690d2b3a507) (string parameterName, float value) |
|  | Sets the parameter. |
| void | [SetParameter](class_tale_worlds_1_1_engine_1_1_sound_event.html#a9fc7c7caed5b5f4bd3aa1de625052a1c) (int parameterIndex, float value) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetEventMinMaxDistance](class_tale_worlds_1_1_engine_1_1_sound_event.html#a908e61409bfb996a0341546691bcb89a) () |
| void | [SetPosition](class_tale_worlds_1_1_engine_1_1_sound_event.html#a7188f57bd1a088a3632bf1c97aa9b255) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) vec) |
|  | Sets the position. |
| void | [SetVelocity](class_tale_worlds_1_1_engine_1_1_sound_event.html#ad90d4bfe86d709edb0d061bf85ec8b2e) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) vec) |
|  | Sets the velocity. |
| void | [Release](class_tale_worlds_1_1_engine_1_1_sound_event.html#a0237856da0c83a04a7c80d075a9911cc) () |
|  | Releases this instance. |
| bool | [IsPlaying](class_tale_worlds_1_1_engine_1_1_sound_event.html#a33d21893199cd6d8f89ad2c73155f37d) () |
| bool | [IsPaused](class_tale_worlds_1_1_engine_1_1_sound_event.html#a84078ce94358e94486a8702272482b57) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static SoundEvent | [CreateEventFromString](class_tale_worlds_1_1_engine_1_1_sound_event.html#a522757ea94a5978c07127551ae7ffc4d) (string eventId, [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) scene) |
|  | Creates the event from fmod a fev file. |
| static int | [GetEventIdFromString](class_tale_worlds_1_1_engine_1_1_sound_event.html#afeb95e7fcd46a003ef865923f7c7e0e6) (string name) |
| static bool | [PlaySound2D](class_tale_worlds_1_1_engine_1_1_sound_event.html#a133f249fcec5881cdb4074c8f6e31f27) (int soundCodeId) |
| static bool | [PlaySound2D](class_tale_worlds_1_1_engine_1_1_sound_event.html#aad69db421b374616cf9a1e24bc91bb58) (string soundName) |
| static int | [GetTotalEventCount](class_tale_worlds_1_1_engine_1_1_sound_event.html#a41a58891f665a847dbfaf36aa478ed45) () |
|  | Get the total amount of sound events. |
| static SoundEvent | [CreateEvent](class_tale_worlds_1_1_engine_1_1_sound_event.html#a302c933e5530c9045e900789f55f498f) (int soundCodeId, [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) scene) |
|  | Creates the event from fmod a fev file. |
| static SoundEvent | [CreateEventFromSoundBuffer](class_tale_worlds_1_1_engine_1_1_sound_event.html#abef5f1c9f217105faff77e3d18585f8c) (string eventId, byte[] soundData, [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) scene, bool is3d, bool isBlocking) |
| static SoundEvent | [CreateEventFromExternalFile](class_tale_worlds_1_1_engine_1_1_sound_event.html#a06f4c3df153d2ea70904ccdc88d7d62a) (string programmerEventName, string soundFilePath, [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) scene, bool is3d, bool isBlocking) |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsValid](class_tale_worlds_1_1_engine_1_1_sound_event.html#a658fa1e9c7ff93ea90598ad6972ff849) `[get]` |
|  | Gets a value indicating whether this instance is valid. |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_engine_1_1_sound_event.html#a84ee558f84ca071f920b71bd9cfafa31)GetSoundId()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.Engine.SoundEvent.GetSoundId | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_sound_event.html#a522757ea94a5978c07127551ae7ffc4d)CreateEventFromString()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | SoundEvent TaleWorlds.Engine.SoundEvent.CreateEventFromString | ( | string | *eventId*, | |  |  | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *scene* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | groupId | The group \_soundId. |
    | eventId | The event \_soundId. |

Returns
:   MBSound instance containing the sound data

[◆](class_tale_worlds_1_1_engine_1_1_sound_event.html#a9feca32122f41e71f47cba76bc06b2d0)SetEventMinMaxDistance()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.SoundEvent.SetEventMinMaxDistance | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *newRadius* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_sound_event.html#afeb95e7fcd46a003ef865923f7c7e0e6)GetEventIdFromString()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.Engine.SoundEvent.GetEventIdFromString | ( | string | *name* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_sound_event.html#a133f249fcec5881cdb4074c8f6e31f27)PlaySound2D() [1/2]
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.SoundEvent.PlaySound2D | ( | int | *soundCodeId* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_sound_event.html#aad69db421b374616cf9a1e24bc91bb58)PlaySound2D() [2/2]
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.SoundEvent.PlaySound2D | ( | string | *soundName* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_sound_event.html#a41a58891f665a847dbfaf36aa478ed45)GetTotalEventCount()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.Engine.SoundEvent.GetTotalEventCount | ( |  | ) |  | | static |

Returns
:   returns the amount

[◆](class_tale_worlds_1_1_engine_1_1_sound_event.html#a302c933e5530c9045e900789f55f498f)CreateEvent()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | SoundEvent TaleWorlds.Engine.SoundEvent.CreateEvent | ( | int | *soundCodeId*, | |  |  | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *scene* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | soundCodeId | ID of the sound |

Returns
:   MBSound instance containing the sound data

[◆](class_tale_worlds_1_1_engine_1_1_sound_event.html#a37e72a0cafc3633e5fdd3f509050d550)IsNullSoundEvent()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.SoundEvent.IsNullSoundEvent | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_sound_event.html#a9b3dbdd44d8d3b70d5be2ef1b6760f70)Play()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.SoundEvent.Play | ( |  | ) |  |

Returns
:   True if played successfully, otherwise, false.

[◆](class_tale_worlds_1_1_engine_1_1_sound_event.html#a9889f10c61f5b6bc376da688e7cafde0)Pause()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.SoundEvent.Pause | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_sound_event.html#ad7307c38ac39e7040d67233c2a407410)Resume()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.SoundEvent.Resume | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_sound_event.html#a485a7b5c431c9e3c6d32a508fe116841)PlayExtraEvent()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.SoundEvent.PlayExtraEvent | ( | string | *eventName* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_sound_event.html#a679490824823ea2b7e273772d6767e49)SetSwitch()
---------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.SoundEvent.SetSwitch | ( | string | *switchGroupName*, |
|  |  | string | *newSwitchStateName* ) |

[◆](class_tale_worlds_1_1_engine_1_1_sound_event.html#a4506fa5c8fe32d6e01bbd69b982fb687)TriggerCue()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.SoundEvent.TriggerCue | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_sound_event.html#a496fbdde886beafa075f2e3f11c2faee)PlayInPosition()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.SoundEvent.PlayInPosition | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | position | Sets the events position to this parameter permanently |

Returns
:   True if played successfully, otherwise, false.

[◆](class_tale_worlds_1_1_engine_1_1_sound_event.html#aa593cf73d39f5e4cd4d161650da45061)Stop()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.SoundEvent.Stop | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_sound_event.html#a2fc2d9813676e53519c67690d2b3a507)SetParameter() [1/2]
------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.SoundEvent.SetParameter | ( | string | *parameterName*, |
|  |  | float | *value* ) |

Parameters
:   |  |  |
    | --- | --- |
    | parameterName | Name of the parameter. |
    | value | Value of the parameter. |

[◆](class_tale_worlds_1_1_engine_1_1_sound_event.html#a9fc7c7caed5b5f4bd3aa1de625052a1c)SetParameter() [2/2]
------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.SoundEvent.SetParameter | ( | int | *parameterIndex*, |
|  |  | float | *value* ) |

[◆](class_tale_worlds_1_1_engine_1_1_sound_event.html#a908e61409bfb996a0341546691bcb89a)GetEventMinMaxDistance()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.SoundEvent.GetEventMinMaxDistance | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_sound_event.html#a7188f57bd1a088a3632bf1c97aa9b255)SetPosition()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.SoundEvent.SetPosition | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *vec* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | vec | New position |

[◆](class_tale_worlds_1_1_engine_1_1_sound_event.html#ad90d4bfe86d709edb0d061bf85ec8b2e)SetVelocity()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.SoundEvent.SetVelocity | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *vec* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | vec | The vec. |

[◆](class_tale_worlds_1_1_engine_1_1_sound_event.html#a0237856da0c83a04a7c80d075a9911cc)Release()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.SoundEvent.Release | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_sound_event.html#a33d21893199cd6d8f89ad2c73155f37d)IsPlaying()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.SoundEvent.IsPlaying | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_sound_event.html#a84078ce94358e94486a8702272482b57)IsPaused()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.SoundEvent.IsPaused | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_sound_event.html#abef5f1c9f217105faff77e3d18585f8c)CreateEventFromSoundBuffer()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | SoundEvent TaleWorlds.Engine.SoundEvent.CreateEventFromSoundBuffer | ( | string | *eventId*, | |  |  | byte[] | *soundData*, | |  |  | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *scene*, | |  |  | bool | *is3d*, | |  |  | bool | *isBlocking* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_sound_event.html#a06f4c3df153d2ea70904ccdc88d7d62a)CreateEventFromExternalFile()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | SoundEvent TaleWorlds.Engine.SoundEvent.CreateEventFromExternalFile | ( | string | *programmerEventName*, | |  |  | string | *soundFilePath*, | |  |  | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *scene*, | |  |  | bool | *is3d*, | |  |  | bool | *isBlocking* ) | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_engine_1_1_sound_event.html#a658fa1e9c7ff93ea90598ad6972ff849)IsValid
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Engine.SoundEvent.IsValid | | get |

`true` if this instance is valid; otherwise, `false`.

