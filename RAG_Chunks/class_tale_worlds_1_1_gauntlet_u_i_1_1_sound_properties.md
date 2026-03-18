--- SOURCE: class_tale_worlds_1_1_gauntlet_u_i_1_1_sound_properties.html ---

TaleWorlds.GauntletUI.SoundProperties Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [SoundProperties](class_tale_worlds_1_1_gauntlet_u_i_1_1_sound_properties.html#ab4edb0dc03481e18e8683ff4f9dccb73) () |
| void | [AddStateSound](class_tale_worlds_1_1_gauntlet_u_i_1_1_sound_properties.html#a80fb12a26a8c14b4c46a49a997525d00) (string state, [AudioProperty](class_tale_worlds_1_1_gauntlet_u_i_1_1_audio_property.html) audioProperty) |
| void | [AddEventSound](class_tale_worlds_1_1_gauntlet_u_i_1_1_sound_properties.html#a0afb401b66539c97df06c1d1b2a83617) (string state, [AudioProperty](class_tale_worlds_1_1_gauntlet_u_i_1_1_audio_property.html) audioProperty) |
| void | [FillFrom](class_tale_worlds_1_1_gauntlet_u_i_1_1_sound_properties.html#ad35a09e5113bf34625465566c2c2107f) ([SoundProperties](class_tale_worlds_1_1_gauntlet_u_i_1_1_sound_properties.html#ab4edb0dc03481e18e8683ff4f9dccb73) soundProperties) |
| [AudioProperty](class_tale_worlds_1_1_gauntlet_u_i_1_1_audio_property.html) | [GetEventAudioProperty](class_tale_worlds_1_1_gauntlet_u_i_1_1_sound_properties.html#a6818611fffddec6b1e899a82fc0556c3) (string eventName) |
| [AudioProperty](class_tale_worlds_1_1_gauntlet_u_i_1_1_audio_property.html) | [GetStateAudioProperty](class_tale_worlds_1_1_gauntlet_u_i_1_1_sound_properties.html#a558ed2ec1a8e2e4290584633a210396b) (string stateName) |

|  |  |
| --- | --- |
| Properties | |
| IEnumerable< KeyValuePair< string, [AudioProperty](class_tale_worlds_1_1_gauntlet_u_i_1_1_audio_property.html) > > | [RegisteredStateSounds](class_tale_worlds_1_1_gauntlet_u_i_1_1_sound_properties.html#a1c96ef70c14d8b89e2e6fe4309687fbd) `[get]` |
| IEnumerable< KeyValuePair< string, [AudioProperty](class_tale_worlds_1_1_gauntlet_u_i_1_1_audio_property.html) > > | [RegisteredEventSounds](class_tale_worlds_1_1_gauntlet_u_i_1_1_sound_properties.html#af55b708a5a21c22664ce3d6852b116b8) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_sound_properties.html#ab4edb0dc03481e18e8683ff4f9dccb73)SoundProperties()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.GauntletUI.SoundProperties.SoundProperties | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_sound_properties.html#a80fb12a26a8c14b4c46a49a997525d00)AddStateSound()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.SoundProperties.AddStateSound | ( | string | *state*, |
|  |  | [AudioProperty](class_tale_worlds_1_1_gauntlet_u_i_1_1_audio_property.html) | *audioProperty* ) |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_sound_properties.html#a0afb401b66539c97df06c1d1b2a83617)AddEventSound()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.SoundProperties.AddEventSound | ( | string | *state*, |
|  |  | [AudioProperty](class_tale_worlds_1_1_gauntlet_u_i_1_1_audio_property.html) | *audioProperty* ) |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_sound_properties.html#ad35a09e5113bf34625465566c2c2107f)FillFrom()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.SoundProperties.FillFrom | ( | [SoundProperties](class_tale_worlds_1_1_gauntlet_u_i_1_1_sound_properties.html#ab4edb0dc03481e18e8683ff4f9dccb73) | *soundProperties* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_sound_properties.html#a6818611fffddec6b1e899a82fc0556c3)GetEventAudioProperty()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [AudioProperty](class_tale_worlds_1_1_gauntlet_u_i_1_1_audio_property.html) TaleWorlds.GauntletUI.SoundProperties.GetEventAudioProperty | ( | string | *eventName* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_sound_properties.html#a558ed2ec1a8e2e4290584633a210396b)GetStateAudioProperty()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [AudioProperty](class_tale_worlds_1_1_gauntlet_u_i_1_1_audio_property.html) TaleWorlds.GauntletUI.SoundProperties.GetStateAudioProperty | ( | string | *stateName* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_sound_properties.html#a1c96ef70c14d8b89e2e6fe4309687fbd)RegisteredStateSounds
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IEnumerable<KeyValuePair<string, [AudioProperty](class_tale_worlds_1_1_gauntlet_u_i_1_1_audio_property.html)> > TaleWorlds.GauntletUI.SoundProperties.RegisteredStateSounds | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_sound_properties.html#af55b708a5a21c22664ce3d6852b116b8)RegisteredEventSounds
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IEnumerable<KeyValuePair<string, [AudioProperty](class_tale_worlds_1_1_gauntlet_u_i_1_1_audio_property.html)> > TaleWorlds.GauntletUI.SoundProperties.RegisteredEventSounds | | get |

