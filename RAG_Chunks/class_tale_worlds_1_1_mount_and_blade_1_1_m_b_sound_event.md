--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sound_event.html ---

TaleWorlds.MountAndBlade.MBSoundEvent Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static bool | [PlaySound](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sound_event.html#a60969661ffa207208b6083c274e837c3) (int soundCodeId, in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position) |
|  | Plays the event from fmod a fev file. |
| static bool | [PlaySound](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sound_event.html#a7f33cd92250d81f3e2194ff95970aa6f) (int soundCodeId, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position) |
|  | Plays the event from fmod a fev file. |
| static bool | [PlaySound](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sound_event.html#a16f6cf1c0a02914800fe56c81c3c333b) (int soundCodeId, ref [SoundEventParameter](struct_tale_worlds_1_1_engine_1_1_sound_event_parameter.html) parameter, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position) |
|  | Plays the event from fmod a fev file. |
| static bool | [PlaySound](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sound_event.html#ae733253f0d7c764a46031817ea85e063) (string soundPath, ref [SoundEventParameter](struct_tale_worlds_1_1_engine_1_1_sound_event_parameter.html) parameter, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position) |
|  | Plays the event from fmod a fev file. |
| static bool | [PlaySound](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sound_event.html#a96c0c5e78823257c0b382bf310b2aa15) (int soundCodeId, ref [SoundEventParameter](struct_tale_worlds_1_1_engine_1_1_sound_event_parameter.html) parameter, in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position) |
|  | Plays the event from fmod a fev file. |
| static void | [PlayEventFromSoundBuffer](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sound_event.html#a847e3f9adce5114279e237dfdc446a51) (string eventId, byte[] soundData, [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) scene, bool is3d, bool isBlocking) |
| static void | [CreateEventFromExternalFile](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sound_event.html#a96ffd56f2e4eb1c127f47caf782bf331) (string programmerEventName, string soundFilePath, [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) scene, bool is3d, bool isBlocking) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sound_event.html#a60969661ffa207208b6083c274e837c3)PlaySound() [1/5]
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.MBSoundEvent.PlaySound | ( | int | *soundCodeId*, | |  |  | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | soundCodeId | ID of the sound |
    | position | Position of the sound |

Returns
:   returns true if sound has successfully played

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sound_event.html#a7f33cd92250d81f3e2194ff95970aa6f)PlaySound() [2/5]
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.MBSoundEvent.PlaySound | ( | int | *soundCodeId*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | soundCodeId | ID of the sound |
    | position | Position of the sound |

Returns
:   returns true if sound has successfully played

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sound_event.html#a16f6cf1c0a02914800fe56c81c3c333b)PlaySound() [3/5]
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.MBSoundEvent.PlaySound | ( | int | *soundCodeId*, | |  |  | ref [SoundEventParameter](struct_tale_worlds_1_1_engine_1_1_sound_event_parameter.html) | *parameter*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | soundCodeId | ID of the sound |
    | parameter | Fmod parameter for event |
    | position | Position of the sound |

Returns
:   returns true if sound has successfully played

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sound_event.html#ae733253f0d7c764a46031817ea85e063)PlaySound() [4/5]
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.MBSoundEvent.PlaySound | ( | string | *soundPath*, | |  |  | ref [SoundEventParameter](struct_tale_worlds_1_1_engine_1_1_sound_event_parameter.html) | *parameter*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | soundPath | Full path of sound |
    | parameter | Fmod parameter for event |
    | position | Position of the sound |

Returns
:   returns true if sound has successfully played

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sound_event.html#a96c0c5e78823257c0b382bf310b2aa15)PlaySound() [5/5]
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.MBSoundEvent.PlaySound | ( | int | *soundCodeId*, | |  |  | ref [SoundEventParameter](struct_tale_worlds_1_1_engine_1_1_sound_event_parameter.html) | *parameter*, | |  |  | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | soundCodeId | ID of the sound |
    | parameter | Fmod parameter for event |
    | position | Position of the sound |

Returns
:   returns true if sound has successfully played

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sound_event.html#a847e3f9adce5114279e237dfdc446a51)PlayEventFromSoundBuffer()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBSoundEvent.PlayEventFromSoundBuffer | ( | string | *eventId*, | |  |  | byte[] | *soundData*, | |  |  | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *scene*, | |  |  | bool | *is3d*, | |  |  | bool | *isBlocking* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sound_event.html#a96ffd56f2e4eb1c127f47caf782bf331)CreateEventFromExternalFile()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBSoundEvent.CreateEventFromExternalFile | ( | string | *programmerEventName*, | |  |  | string | *soundFilePath*, | |  |  | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *scene*, | |  |  | bool | *is3d*, | |  |  | bool | *isBlocking* ) | | static |

