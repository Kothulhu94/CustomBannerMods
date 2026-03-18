--- SOURCE: class_tale_worlds_1_1_engine_1_1_sound_manager.html ---

TaleWorlds.Engine.SoundManager Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [SetListenerFrame](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a985aeb6e643ac75fbfdf2246c1992aa3) ([MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame) |
| static void | [SetListenerFrame](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a124661852dc205a1511dd9a06e25f795) ([MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) attenuationPosition) |
| static [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetListenerFrame](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a3a5465623584603be0653e05efd2ebec) () |
| static [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetAttenuationPosition](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a00519a1e16e32e3afe7801f3b5e91191) () |
| static void | [Reset](class_tale_worlds_1_1_engine_1_1_sound_manager.html#ab47e053d55b22ab118ff7cb69f15743e) () |
| static bool | [StartOneShotEvent](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a893d5a0a68c52e1d4f5ffc99656c16b8) (string eventFullName, in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position, string paramName, float paramValue) |
| static bool | [StartOneShotEvent](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a5b6097601d9d9f3301d719b58c475733) (string eventFullName, in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position) |
| static bool | [StartOneShotEventWithIndex](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a1ef6096f4b747d50383ab11a56e70258) (int index, in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position) |
| static void | [SetState](class_tale_worlds_1_1_engine_1_1_sound_manager.html#ac1c2584eb2854c3898e97695c7d6d46e) (string stateGroup, string state) |
| static [SoundEvent](class_tale_worlds_1_1_engine_1_1_sound_event.html) | [CreateEvent](class_tale_worlds_1_1_engine_1_1_sound_manager.html#ac8d6a73dd3a53aa168227f81872f8666) (string eventFullName, [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) scene) |
| static void | [LoadEventFileAux](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a86f94d310aed745345ad22087ebf7220) (string soundBank, bool decompressSamples) |
| static void | [AddSoundClientWithId](class_tale_worlds_1_1_engine_1_1_sound_manager.html#abbc22a959e3cf1962227ced3b5bf0e8f) (ulong clientId) |
| static void | [DeleteSoundClientWithId](class_tale_worlds_1_1_engine_1_1_sound_manager.html#aaa9102bc979b57217c89c639fcea8c92) (ulong clientId) |
| static void | [SetGlobalParameter](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a124213c1d38923f90729415f0caa5c7d) (string parameterName, float value) |
| static int | [GetEventGlobalIndex](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a656410ca5e951f17c1d1621314178f21) (string eventFullName) |
| static void | [PauseBus](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a56ad1a47fac4299815feff62965f0858) (string busName) |
| static void | [UnpauseBus](class_tale_worlds_1_1_engine_1_1_sound_manager.html#aa6f6f658a42d4d1e8acdd88da13ec279) (string busName) |
| static void | [InitializeVoicePlayEvent](class_tale_worlds_1_1_engine_1_1_sound_manager.html#ab97fe958aa68a8564dd2d623e808deba) () |
| static void | [CreateVoiceEvent](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a17b1283e33b4266df57d7a6612542658) () |
| static void | [DestroyVoiceEvent](class_tale_worlds_1_1_engine_1_1_sound_manager.html#ae9203679e3f670bcafe34be0ae228889) (int id) |
| static void | [FinalizeVoicePlayEvent](class_tale_worlds_1_1_engine_1_1_sound_manager.html#afc2660c016b2f3dae57824bfaabf22db) () |
| static void | [StartVoiceRecording](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a7d3226cef529c4263f7044ce21cd77b3) () |
| static void | [StopVoiceRecording](class_tale_worlds_1_1_engine_1_1_sound_manager.html#acd6d0322a6878727f2172a65ec7b28d2) () |
| static void | [GetVoiceData](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a6e44df9789a42837e7af96b4509e9a0f) (byte[] voiceBuffer, int chunkSize, out int readBytesLength) |
| static void | [UpdateVoiceToPlay](class_tale_worlds_1_1_engine_1_1_sound_manager.html#ac231825d278d43dd794b91e2bafed039) (byte[] voiceBuffer, int length, int index) |
| static void | [AddXBOXRemoteUser](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a4f0609fa33730b3b972223e9edcdafb7) (System.UInt64 XUID, System.UInt64 deviceID, bool canSendMicSound, bool canSendTextSound, bool canSendText, bool canReceiveSound, bool canReceiveText) |
| static void | [InitializeXBOXSoundManager](class_tale_worlds_1_1_engine_1_1_sound_manager.html#ae131b4d4c51da7287dc571fa75ca7503) () |
| static void | [ApplyPushToTalk](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a600bb2fe13bf9cb9e2185869587d9d09) (bool pushed) |
| static void | [ClearXBOXSoundManager](class_tale_worlds_1_1_engine_1_1_sound_manager.html#aedc16034d2810285fb4cdfe173c60686) () |
| static void | [UpdateXBOXLocalUser](class_tale_worlds_1_1_engine_1_1_sound_manager.html#ade7e7ea4106f50456ef9c6ec5dd13404) () |
| static void | [UpdateXBOXChatCommunicationFlags](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a1309bfd29c559830c0ac9f1497699cd4) (System.UInt64 XUID, bool canSendMicSound, bool canSendTextSound, bool canSendText, bool canReceiveSound, bool canReceiveText) |
| static void | [RemoveXBOXRemoteUser](class_tale_worlds_1_1_engine_1_1_sound_manager.html#ae8cd5841c89eb8b41ad444510ca4b05b) (System.UInt64 XUID) |
| static void | [ProcessDataToBeReceived](class_tale_worlds_1_1_engine_1_1_sound_manager.html#acf6649d5675436381717408a427d9e8f) (System.UInt64 senderDeviceID, byte[] data, System.UInt32 dataSize) |
| static void | [ProcessDataToBeSent](class_tale_worlds_1_1_engine_1_1_sound_manager.html#ae555197377f4c0685f77b616209f4438) (ref int numData) |
| static void | [HandleStateChanges](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a5e42a9153ce26fb275ad4e6c744d76fd) () |
| static void | [GetSizeOfDataToBeSentAt](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a6ad61e0fde4ea315e7cd3b8f2739874f) (int index, ref System.UInt32 byteCount, ref System.UInt32 numReceivers) |
| static bool | [GetDataToBeSentAt](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a31a59b1ba5892edee907bc3bcc2b3eeb) (int index, byte[] buffer, System.UInt64[] receivers, ref bool transportGuaranteed) |
| static void | [ClearDataToBeSent](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a6e543fe31535b5d0c2c76ad930b76bda) () |
| static void | [CompressData](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a4af5906763162b4bc99e7516c215f7bb) (int clientID, byte[] buffer, int length, byte[] compressedBuffer, out int compressedBufferLength) |
| static void | [DecompressData](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a2fdd6bce000f88ee614b3e03ad49bd71) (int clientID, byte[] compressedBuffer, int compressedBufferLength, byte[] decompressedBuffer, out int decompressedBufferLength) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a985aeb6e643ac75fbfdf2246c1992aa3)SetListenerFrame() [1/2]
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.SoundManager.SetListenerFrame | ( | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a124661852dc205a1511dd9a06e25f795)SetListenerFrame() [2/2]
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.SoundManager.SetListenerFrame | ( | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *attenuationPosition* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a3a5465623584603be0653e05efd2ebec)GetListenerFrame()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.Engine.SoundManager.GetListenerFrame | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a00519a1e16e32e3afe7801f3b5e91191)GetAttenuationPosition()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.SoundManager.GetAttenuationPosition | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_sound_manager.html#ab47e053d55b22ab118ff7cb69f15743e)Reset()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.SoundManager.Reset | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a893d5a0a68c52e1d4f5ffc99656c16b8)StartOneShotEvent() [1/2]
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Engine.SoundManager.StartOneShotEvent | ( | string | *eventFullName*, | |  |  | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position*, | |  |  | string | *paramName*, | |  |  | float | *paramValue* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a5b6097601d9d9f3301d719b58c475733)StartOneShotEvent() [2/2]
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Engine.SoundManager.StartOneShotEvent | ( | string | *eventFullName*, | |  |  | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a1ef6096f4b747d50383ab11a56e70258)StartOneShotEventWithIndex()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Engine.SoundManager.StartOneShotEventWithIndex | ( | int | *index*, | |  |  | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_sound_manager.html#ac1c2584eb2854c3898e97695c7d6d46e)SetState()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.SoundManager.SetState | ( | string | *stateGroup*, | |  |  | string | *state* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_sound_manager.html#ac8d6a73dd3a53aa168227f81872f8666)CreateEvent()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [SoundEvent](class_tale_worlds_1_1_engine_1_1_sound_event.html) TaleWorlds.Engine.SoundManager.CreateEvent | ( | string | *eventFullName*, | |  |  | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *scene* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a86f94d310aed745345ad22087ebf7220)LoadEventFileAux()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.SoundManager.LoadEventFileAux | ( | string | *soundBank*, | |  |  | bool | *decompressSamples* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_sound_manager.html#abbc22a959e3cf1962227ced3b5bf0e8f)AddSoundClientWithId()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.SoundManager.AddSoundClientWithId | ( | ulong | *clientId* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_sound_manager.html#aaa9102bc979b57217c89c639fcea8c92)DeleteSoundClientWithId()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.SoundManager.DeleteSoundClientWithId | ( | ulong | *clientId* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a124213c1d38923f90729415f0caa5c7d)SetGlobalParameter()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.SoundManager.SetGlobalParameter | ( | string | *parameterName*, | |  |  | float | *value* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a656410ca5e951f17c1d1621314178f21)GetEventGlobalIndex()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.Engine.SoundManager.GetEventGlobalIndex | ( | string | *eventFullName* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a56ad1a47fac4299815feff62965f0858)PauseBus()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.SoundManager.PauseBus | ( | string | *busName* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_sound_manager.html#aa6f6f658a42d4d1e8acdd88da13ec279)UnpauseBus()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.SoundManager.UnpauseBus | ( | string | *busName* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_sound_manager.html#ab97fe958aa68a8564dd2d623e808deba)InitializeVoicePlayEvent()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.SoundManager.InitializeVoicePlayEvent | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a17b1283e33b4266df57d7a6612542658)CreateVoiceEvent()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.SoundManager.CreateVoiceEvent | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_sound_manager.html#ae9203679e3f670bcafe34be0ae228889)DestroyVoiceEvent()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.SoundManager.DestroyVoiceEvent | ( | int | *id* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_sound_manager.html#afc2660c016b2f3dae57824bfaabf22db)FinalizeVoicePlayEvent()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.SoundManager.FinalizeVoicePlayEvent | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a7d3226cef529c4263f7044ce21cd77b3)StartVoiceRecording()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.SoundManager.StartVoiceRecording | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_sound_manager.html#acd6d0322a6878727f2172a65ec7b28d2)StopVoiceRecording()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.SoundManager.StopVoiceRecording | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a6e44df9789a42837e7af96b4509e9a0f)GetVoiceData()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.SoundManager.GetVoiceData | ( | byte[] | *voiceBuffer*, | |  |  | int | *chunkSize*, | |  |  | out int | *readBytesLength* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_sound_manager.html#ac231825d278d43dd794b91e2bafed039)UpdateVoiceToPlay()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.SoundManager.UpdateVoiceToPlay | ( | byte[] | *voiceBuffer*, | |  |  | int | *length*, | |  |  | int | *index* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a4f0609fa33730b3b972223e9edcdafb7)AddXBOXRemoteUser()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.SoundManager.AddXBOXRemoteUser | ( | System.UInt64 | *XUID*, | |  |  | System.UInt64 | *deviceID*, | |  |  | bool | *canSendMicSound*, | |  |  | bool | *canSendTextSound*, | |  |  | bool | *canSendText*, | |  |  | bool | *canReceiveSound*, | |  |  | bool | *canReceiveText* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_sound_manager.html#ae131b4d4c51da7287dc571fa75ca7503)InitializeXBOXSoundManager()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.SoundManager.InitializeXBOXSoundManager | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a600bb2fe13bf9cb9e2185869587d9d09)ApplyPushToTalk()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.SoundManager.ApplyPushToTalk | ( | bool | *pushed* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_sound_manager.html#aedc16034d2810285fb4cdfe173c60686)ClearXBOXSoundManager()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.SoundManager.ClearXBOXSoundManager | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_sound_manager.html#ade7e7ea4106f50456ef9c6ec5dd13404)UpdateXBOXLocalUser()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.SoundManager.UpdateXBOXLocalUser | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a1309bfd29c559830c0ac9f1497699cd4)UpdateXBOXChatCommunicationFlags()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.SoundManager.UpdateXBOXChatCommunicationFlags | ( | System.UInt64 | *XUID*, | |  |  | bool | *canSendMicSound*, | |  |  | bool | *canSendTextSound*, | |  |  | bool | *canSendText*, | |  |  | bool | *canReceiveSound*, | |  |  | bool | *canReceiveText* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_sound_manager.html#ae8cd5841c89eb8b41ad444510ca4b05b)RemoveXBOXRemoteUser()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.SoundManager.RemoveXBOXRemoteUser | ( | System.UInt64 | *XUID* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_sound_manager.html#acf6649d5675436381717408a427d9e8f)ProcessDataToBeReceived()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.SoundManager.ProcessDataToBeReceived | ( | System.UInt64 | *senderDeviceID*, | |  |  | byte[] | *data*, | |  |  | System.UInt32 | *dataSize* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_sound_manager.html#ae555197377f4c0685f77b616209f4438)ProcessDataToBeSent()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.SoundManager.ProcessDataToBeSent | ( | ref int | *numData* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a5e42a9153ce26fb275ad4e6c744d76fd)HandleStateChanges()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.SoundManager.HandleStateChanges | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a6ad61e0fde4ea315e7cd3b8f2739874f)GetSizeOfDataToBeSentAt()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.SoundManager.GetSizeOfDataToBeSentAt | ( | int | *index*, | |  |  | ref System.UInt32 | *byteCount*, | |  |  | ref System.UInt32 | *numReceivers* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a31a59b1ba5892edee907bc3bcc2b3eeb)GetDataToBeSentAt()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Engine.SoundManager.GetDataToBeSentAt | ( | int | *index*, | |  |  | byte[] | *buffer*, | |  |  | System.UInt64[] | *receivers*, | |  |  | ref bool | *transportGuaranteed* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a6e543fe31535b5d0c2c76ad930b76bda)ClearDataToBeSent()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.SoundManager.ClearDataToBeSent | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a4af5906763162b4bc99e7516c215f7bb)CompressData()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.SoundManager.CompressData | ( | int | *clientID*, | |  |  | byte[] | *buffer*, | |  |  | int | *length*, | |  |  | byte[] | *compressedBuffer*, | |  |  | out int | *compressedBufferLength* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_sound_manager.html#a2fdd6bce000f88ee614b3e03ad49bd71)DecompressData()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.SoundManager.DecompressData | ( | int | *clientID*, | |  |  | byte[] | *compressedBuffer*, | |  |  | int | *compressedBufferLength*, | |  |  | byte[] | *decompressedBuffer*, | |  |  | out int | *decompressedBufferLength* ) | | static |

