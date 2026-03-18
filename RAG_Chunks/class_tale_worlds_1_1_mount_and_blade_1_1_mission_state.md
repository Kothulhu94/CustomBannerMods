--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html ---

TaleWorlds.MountAndBlade.MissionState Class ReferenceInherits [TaleWorlds.Core.GameState](class_tale_worlds_1_1_core_1_1_game_state.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [BeginDelayedDisconnectFromMission](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html#aaa24a46d032f46407801a50f008705f3) () |
| Public Member Functions inherited from [TaleWorlds.Core.GameState](class_tale_worlds_1_1_core_1_1_game_state.html) | |
| bool | [RegisterListener](class_tale_worlds_1_1_core_1_1_game_state.html#a5de0596109748cd2cc9cfa28959f8f96) ([IGameStateListener](interface_tale_worlds_1_1_core_1_1_i_game_state_listener.html) listener) |
| bool | [UnregisterListener](class_tale_worlds_1_1_core_1_1_game_state.html#ae56aad1d9d2a21f72df2302e198c993a) ([IGameStateListener](interface_tale_worlds_1_1_core_1_1_i_game_state_listener.html) listener) |
| T | [GetListenerOfType< T >](class_tale_worlds_1_1_core_1_1_game_state.html#a6c13c32468bbc05927f4b592c7682b47) () |
| Public Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a520e657fd5a750c8b7e2154b0f5629ea) () |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a134c5e806ba735219710d773e7075b00) (MBObjectBase other) |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8e3c1b47f5d928e64d9d67fa7864c364) (string stringId) |
| void | [AfterInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab67141737ce51fe724e4a5b8026a973b) () |
| virtual void | [AfterRegister](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab15f91cc9dbb7ff8763eec828c179216) () |
| virtual void | [Initialize](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aad39d5ca82d85853a9879e2670dd036e) () |
| virtual void | [Deserialize](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad1364026109401ca16d5a450d8b8f178) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
| override int | [GetHashCode](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a68e79a07f136aae5be4fe9eadb612def) () |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetName](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a0b72f9e386b6cefc4e6bfb52642b98db) () |
| void | [PreAfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af26d64a79291c4f6328fc151d2569ebf) () |
| void | [AfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a277b54134c76732e443019a7862cf388) () |
| void | [OnRegistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a586208e92e5041fd432127305aa8af16) () |
| void | [OnUnregistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a71bef09af9a896246fa7b18c324e565c) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | [OpenNew](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html#ab8dc98c3c6c6140b3385542a9fc2b5b5) (string missionName, [MissionInitializerRecord](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html) rec, [InitializeMissionBehaviorsDelegate](namespace_tale_worlds_1_1_mount_and_blade.html#ae4f9b0c8d79cc23031757e6e243c3afd) handler, bool addDefaultMissionBehaviors=true, bool needsMemoryCleanup=true) |

|  |  |
| --- | --- |
| Public Attributes | |
| float | [MissionReplayStartTime](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html#aed55151865ce9533f5101f340cfcf629) = 0 |
| float | [MissionEndTime](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html#aeef416b8a654b7e97456b6966a60d42a) = 0 |
| Public Attributes inherited from [TaleWorlds.Core.GameState](class_tale_worlds_1_1_core_1_1_game_state.html) | |
| int | [Level](class_tale_worlds_1_1_core_1_1_game_state.html#a257542858722d2e5d32b3f324c266c65) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static bool | [RecordMission](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html#aaf8179b3e7970f1de923df97d8beaa8d) |
| Static Public Attributes inherited from [TaleWorlds.Core.GameState](class_tale_worlds_1_1_core_1_1_game_state.html) | |
| static int | [NumberOfListenerActivations](class_tale_worlds_1_1_core_1_1_game_state.html#abac4e06c768e9cb629baa328044896c9) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnInitialize](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html#a2f4cb37108b5faf8cde57f15995b525f) () |
| override void | [OnFinalize](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html#a1b518e38cb5bebe2a7a8f9e188e4bb80) () |
| override void | [OnActivate](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html#ac58e91dec194b4027b02976876a3929c) () |
| override void | [OnDeactivate](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html#a7962b0eb6473bac8fd786d30db63b4ff) () |
| override void | [OnIdleTick](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html#aba7780c53800c1ebfcd191da7e2d8ac8) (float dt) |
| override void | [OnTick](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html#a5303a3c4c1d2362e73484eb3a47a1845) (float realDt) |
| [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | [HandleOpenNew](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html#a25de36dcbe920393de4d34a4d7d73151) (string missionName, [MissionInitializerRecord](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html) rec, [InitializeMissionBehaviorsDelegate](namespace_tale_worlds_1_1_mount_and_blade.html#ae4f9b0c8d79cc23031757e6e243c3afd) handler, bool addDefaultMissionBehaviors, bool needsMemoryCleanup) |
| Protected Member Functions inherited from [TaleWorlds.Core.GameState](class_tale_worlds_1_1_core_1_1_game_state.html) | |
|  | [GameState](class_tale_worlds_1_1_core_1_1_game_state.html#ad748b43db56f0ccaeea076775562dea7) () |
| Protected Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| virtual void | [OnBeforeLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad32c7b22bd64e771cc05ee54ae78058a) () |
| virtual void | [PreAfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aeddc87ee0703c7f37d9129d9a5e024e4) () |
| virtual void | [AfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aae8a0aa22e7a659e1edbedfe9739d413) () |

|  |  |
| --- | --- |
| Static Protected Member Functions | |
| static bool | [IsRecordingActive](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html#abb3c3fcd1a3a9384c2786daade802dc9) () |

|  |  |
| --- | --- |
| Properties | |
| [IMissionSystemHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_system_handler.html) | [Handler](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html#a4a27ad5763b09317ee6ef2d8561c7ef2) `[get, set]` |
| static [MissionState](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html) | [Current](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html#a9d058689ddb8889aadf10f483f2cf77b) `[get]` |
| [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | [CurrentMission](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html#a1687947257957ef1659968d1d19686e6) `[get]` |
| string | [MissionName](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html#ad6ee38eb3b8e24b9c941927a6a2fac08) `[get]` |
| bool | [FirstMissionTickAfterLoading](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html#aaeb1eeb0a0c87fefa5ea4b32044f0e37) `[get]` |
| bool | [Paused](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html#af012431f7806ab6d6fd195b5f408b7b1) `[get, set]` |
| Properties inherited from [TaleWorlds.Core.GameState](class_tale_worlds_1_1_core_1_1_game_state.html) | |
| [GameState](class_tale_worlds_1_1_core_1_1_game_state.html#ad748b43db56f0ccaeea076775562dea7) | [Predecessor](class_tale_worlds_1_1_core_1_1_game_state.html#a8c58eba46626705436b1f6e6438fe4b3) `[get]` |
| bool | [IsActive](class_tale_worlds_1_1_core_1_1_game_state.html#ae98283dc0dbf0a4a7ac2f2703df0556a) `[get]` |
| IReadOnlyCollection< [IGameStateListener](interface_tale_worlds_1_1_core_1_1_i_game_state_listener.html) > | [Listeners](class_tale_worlds_1_1_core_1_1_game_state.html#a169c050b0c9fc4f75ebc22077e0e1dcc) `[get]` |
| GameStateManager | [GameStateManager](class_tale_worlds_1_1_core_1_1_game_state.html#a49046697eb0faecb2ae348a9fb53164c) `[get]` |
| virtual bool | [IsMusicMenuState](class_tale_worlds_1_1_core_1_1_game_state.html#af8d01b71fa319594b32292b3cbb5f353) `[get]` |
|  | Whether or not if this state should be treated as a menu state for the music manager. |
| virtual bool | [IsMenuState](class_tale_worlds_1_1_core_1_1_game_state.html#ac5c37d14282c0d21df2371d6d30fa2b8) `[get]` |
|  | Whether or not if this state is a screen/menu state for GUI. |
| bool | [Activated](class_tale_worlds_1_1_core_1_1_game_state.html#a1dabaff4645c2338168cdfed9f4bae95) `[get]` |
| Properties inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| string | [StringId](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8f7cc0266861eb249963e5ead3ab93f1) `[get, set]` |
| [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html) | [Id](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af97fbe63c015ee5f4958ab6946b7f69a) `[get, set]` |
| bool | [IsInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aa6b3602c7cfd678c75bf91e1c3073606) `[get]` |
| bool | [IsReady](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#abc67abca4d8d58d34835693808c0aa14) `[get, set]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html#a2f4cb37108b5faf8cde57f15995b525f)OnInitialize()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MissionState.OnInitialize | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Core.GameState](class_tale_worlds_1_1_core_1_1_game_state.html#abdc3480ab7715670dbbac5567e1324bc).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html#a1b518e38cb5bebe2a7a8f9e188e4bb80)OnFinalize()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MissionState.OnFinalize | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Core.GameState](class_tale_worlds_1_1_core_1_1_game_state.html#adad222707d0017cc15fef19e110b5e5a).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html#ac58e91dec194b4027b02976876a3929c)OnActivate()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MissionState.OnActivate | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Core.GameState](class_tale_worlds_1_1_core_1_1_game_state.html#ae61931e69edd4b200e9a056d43790d5e).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html#a7962b0eb6473bac8fd786d30db63b4ff)OnDeactivate()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MissionState.OnDeactivate | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Core.GameState](class_tale_worlds_1_1_core_1_1_game_state.html#afd0067e44f30e46870921923db1f5296).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html#aba7780c53800c1ebfcd191da7e2d8ac8)OnIdleTick()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MissionState.OnIdleTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Core.GameState](class_tale_worlds_1_1_core_1_1_game_state.html).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html#a5303a3c4c1d2362e73484eb3a47a1845)OnTick()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MissionState.OnTick | ( | float | *realDt* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Core.GameState](class_tale_worlds_1_1_core_1_1_game_state.html).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html#a25de36dcbe920393de4d34a4d7d73151)HandleOpenNew()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) TaleWorlds.MountAndBlade.MissionState.HandleOpenNew | ( | string | *missionName*, | |  |  | [MissionInitializerRecord](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html) | *rec*, | |  |  | [InitializeMissionBehaviorsDelegate](namespace_tale_worlds_1_1_mount_and_blade.html#ae4f9b0c8d79cc23031757e6e243c3afd) | *handler*, | |  |  | bool | *addDefaultMissionBehaviors*, | |  |  | bool | *needsMemoryCleanup* ) | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html#abb3c3fcd1a3a9384c2786daade802dc9)IsRecordingActive()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.MissionState.IsRecordingActive | ( |  | ) |  | | staticprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html#ab8dc98c3c6c6140b3385542a9fc2b5b5)OpenNew()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) TaleWorlds.MountAndBlade.MissionState.OpenNew | ( | string | *missionName*, | |  |  | [MissionInitializerRecord](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html) | *rec*, | |  |  | [InitializeMissionBehaviorsDelegate](namespace_tale_worlds_1_1_mount_and_blade.html#ae4f9b0c8d79cc23031757e6e243c3afd) | *handler*, | |  |  | bool | *addDefaultMissionBehaviors* = true, | |  |  | bool | *needsMemoryCleanup* = true ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html#aaa24a46d032f46407801a50f008705f3)BeginDelayedDisconnectFromMission()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionState.BeginDelayedDisconnectFromMission | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html#aaf8179b3e7970f1de923df97d8beaa8d)RecordMission
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.MissionState.RecordMission | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html#aed55151865ce9533f5101f340cfcf629)MissionReplayStartTime
-------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.MissionState.MissionReplayStartTime = 0 |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html#aeef416b8a654b7e97456b6966a60d42a)MissionEndTime
-----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.MissionState.MissionEndTime = 0 |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html#a4a27ad5763b09317ee6ef2d8561c7ef2)Handler
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMissionSystemHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_system_handler.html) TaleWorlds.MountAndBlade.MissionState.Handler | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html#a9d058689ddb8889aadf10f483f2cf77b)Current
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MissionState](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html) TaleWorlds.MountAndBlade.MissionState.Current | | staticget |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html#a1687947257957ef1659968d1d19686e6)CurrentMission
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) TaleWorlds.MountAndBlade.MissionState.CurrentMission | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html#ad6ee38eb3b8e24b9c941927a6a2fac08)MissionName
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.MissionState.MissionName | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html#aaeb1eeb0a0c87fefa5ea4b32044f0e37)FirstMissionTickAfterLoading
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.MissionState.FirstMissionTickAfterLoading | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html#af012431f7806ab6d6fd195b5f408b7b1)Paused
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.MissionState.Paused | | getset |

