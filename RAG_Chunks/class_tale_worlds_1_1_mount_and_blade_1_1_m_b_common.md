--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_m_b_common.html ---

TaleWorlds.MountAndBlade.MBCommon Class Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [GameType](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_common.html#a917433ad02d4b2d030f065fdf0cc8570) {     [Single](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_common.html#a917433ad02d4b2d030f065fdf0cc8570a66ba162102bbf6ae31b522aec561735e) = 0 ,     [MultiClient](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_common.html#a917433ad02d4b2d030f065fdf0cc8570a6b5f1d8b255157327391d98ab5e74178) = 1 ,     [MultiServer](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_common.html#a917433ad02d4b2d030f065fdf0cc8570a4d01eff82a5ce84c88b212880f5e3279) = 2 ,     [MultiClientServer](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_common.html#a917433ad02d4b2d030f065fdf0cc8570a1670473198856ec6ee3cba8189aa5e66) = 3 ,     [SingleReplay](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_common.html#a917433ad02d4b2d030f065fdf0cc8570a59a7807654dc8df3ccc34b1a02b240b2) = 4 ,     [SingleRecord](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_common.html#a917433ad02d4b2d030f065fdf0cc8570a5a919a01a37ac10fa38264e81a4f3604) = 5   } |
| enum | [TimeType](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_common.html#a124d18979a7825ee77f6888b92dbd72f) {     [Application](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_common.html#a124d18979a7825ee77f6888b92dbd72fae498749f3c42246d50b15c81c101d988) = 0 ,     [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_common.html#a124d18979a7825ee77f6888b92dbd72fa70d529695c253d17e992cb9265abc57f) = 1   } |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [PauseGameEngine](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_common.html#adf022c50fc1da068a5b85d8bdca31698) () |
| static void | [UnPauseGameEngine](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_common.html#a7004d7241f43d0377cc3725394e4c4d5) () |
| static float | [GetApplicationTime](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_common.html#a15c4cd162e2aff9dfd698022dd62e690) () |
|  | Gets the time since application start. |
| static float | [GetTotalMissionTime](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_common.html#a9fe4bf9b75e0cdc91ca96d12e830de4d) () |
|  | Gets the time sum of all missions since application start. |
| static void | [FixSkeletons](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_common.html#a7602cdf26e9ba8f87022dc31d38a91be) () |
| static void | [CheckResourceModifications](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_common.html#a1685f5876b6c316e9d579b2b084ec1ca) () |
| static int | [Hash](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_common.html#aede237cb09efcabe7c130654a2c660fb) (int i, object o) |

|  |  |
| --- | --- |
| Properties | |
| static [GameType](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_common.html#a917433ad02d4b2d030f065fdf0cc8570) | [CurrentGameType](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_common.html#ae412ba2da184afa602354155510a1015) `[get, set]` |
| static bool | [IsDebugMode](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_common.html#aa53a21ed39234f537a4a15b3124bf333) `[get]` |
| static bool | [IsPaused](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_common.html#a2756b922d53a939743c50f0461638322) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_common.html#a917433ad02d4b2d030f065fdf0cc8570)GameType
--------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.MBCommon.GameType](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_common.html#a917433ad02d4b2d030f065fdf0cc8570) |

| Enumerator | |
| --- | --- |
| Single |  |
| MultiClient |  |
| MultiServer |  |
| MultiClientServer |  |
| SingleReplay |  |
| SingleRecord |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_common.html#a124d18979a7825ee77f6888b92dbd72f)TimeType
--------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.MBCommon.TimeType](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_common.html#a124d18979a7825ee77f6888b92dbd72f) |

| Enumerator | |
| --- | --- |
| Application |  |
| Mission |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_common.html#adf022c50fc1da068a5b85d8bdca31698)PauseGameEngine()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBCommon.PauseGameEngine | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_common.html#a7004d7241f43d0377cc3725394e4c4d5)UnPauseGameEngine()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBCommon.UnPauseGameEngine | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_common.html#a15c4cd162e2aff9dfd698022dd62e690)GetApplicationTime()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.MBCommon.GetApplicationTime | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_common.html#a9fe4bf9b75e0cdc91ca96d12e830de4d)GetTotalMissionTime()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.MBCommon.GetTotalMissionTime | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_common.html#a7602cdf26e9ba8f87022dc31d38a91be)FixSkeletons()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBCommon.FixSkeletons | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_common.html#a1685f5876b6c316e9d579b2b084ec1ca)CheckResourceModifications()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBCommon.CheckResourceModifications | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_common.html#aede237cb09efcabe7c130654a2c660fb)Hash()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.MBCommon.Hash | ( | int | *i*, | |  |  | object | *o* ) | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_common.html#ae412ba2da184afa602354155510a1015)CurrentGameType
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GameType](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_common.html#a917433ad02d4b2d030f065fdf0cc8570) TaleWorlds.MountAndBlade.MBCommon.CurrentGameType | | staticgetset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_common.html#aa53a21ed39234f537a4a15b3124bf333)IsDebugMode
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.MBCommon.IsDebugMode | | staticget |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_common.html#a2756b922d53a939743c50f0461638322)IsPaused
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.MBCommon.IsPaused | | staticget |

