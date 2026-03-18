--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html ---

TaleWorlds.MountAndBlade.MBMusicManager Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
| void | [OnCampaignMusicHandlerInit](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#abe5bfc59e59408c28702496772fd0bc2) ([IMusicHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_music_handler.html) campaignMusicHandler) |
| void | [OnCampaignMusicHandlerFinalize](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#a51b24129c663abf071d76e7429167515) () |
| void | [OnBattleMusicHandlerInit](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#a80b972ffbca039d983cb169342e12a01) ([IMusicHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_music_handler.html) battleMusicHandler) |
| void | [OnBattleMusicHandlerFinalize](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#a04798b16243b31e2a872bf4e3d948db7) () |
| void | [OnSilencedMusicHandlerInit](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#a8047bcf53be275fa8a2d581ccbf0103f) ([IMusicHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_music_handler.html) silencedMusicHandler) |
| void | [OnSilencedMusicHandlerFinalize](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#a8c0c1b0bb5c7c3cc4ae0e262e6f0409a) () |
| void | [ActivateBattleMode](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#ad013b228e06d37be188029a8bc96721c) () |
| void | [DeactivateBattleMode](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#ad6d1b4c526c7e84099cc350c04fa58c0) () |
| void | [ActivateCampaignMode](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#ab5127069d625f872137df9d7a97d7aca) () |
| void | [DeactivateCampaignMode](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#a0477c46c0baec83eeb2fc5e328045f05) () |
| void | [DeactivateCurrentMode](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#a3b026462b1fcb97b49ef185bce57283e) () |
| void | [UnpauseMusicManagerSystem](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#af0a87847d197c52a9ae8d6e9b14d243a) () |
| void | [PauseMusicManagerSystem](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#ad6e70d7984e53775da339c832b9717f1) () |
| void | [StartTheme](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#a03b4b2b1b97a426fbe98588fa503c472) ([MusicTheme](namespace_tale_worlds_1_1_mount_and_blade.html#a6414d29697ec70a9803d25de86ef2c47) theme, float startIntensity, bool queueEndSegment=false) |
| void | [StartThemeWithConstantIntensity](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#a31f2a90c49853b198a964018e51d6ced) ([MusicTheme](namespace_tale_worlds_1_1_mount_and_blade.html#a6414d29697ec70a9803d25de86ef2c47) theme, bool queueEndSegment=false) |
| void | [ForceStopThemeWithFadeOut](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#a3aad2b70975c78257116f50377a8ac7c) () |
| void | [ChangeCurrentThemeIntensity](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#a79e246463eebc62aba4920487c300c22) (float deltaIntensity) |
| void | [Update](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#a960a3fe144a055785123d47bffdc466b) (float dt) |
| [MusicTheme](namespace_tale_worlds_1_1_mount_and_blade.html#a6414d29697ec70a9803d25de86ef2c47) | [GetSiegeTheme](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#a13323a3a49db2d0f6baf9cea29248ae3) ([BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) culture) |
| [MusicTheme](namespace_tale_worlds_1_1_mount_and_blade.html#a6414d29697ec70a9803d25de86ef2c47) | [GetBattleTheme](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#a7506fb38a3162b514128afba8199f6d9) ([BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) culture, int battleSize, out bool isPaganBattle) |
| [MusicTheme](namespace_tale_worlds_1_1_mount_and_blade.html#a6414d29697ec70a9803d25de86ef2c47) | [GetBattleEndTheme](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#a2a48e5b03d0af8a35b5ef0dd0cf991e7) ([BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) culture, bool isVictory) |
| [MusicTheme](namespace_tale_worlds_1_1_mount_and_blade.html#a6414d29697ec70a9803d25de86ef2c47) | [GetBattleTurnsOneSideTheme](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#a701fe92a06e657392e378e29699d42e0) ([BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) culture, bool isPositive, bool isPaganBattle) |
| [MusicTheme](namespace_tale_worlds_1_1_mount_and_blade.html#a6414d29697ec70a9803d25de86ef2c47) | [GetCampaignMusicTheme](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#a675e93d2750142602838edf2f84934d3) ([BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) culture, bool isDark, bool isWarMode, bool isAtSea) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static bool | [IsCreationCompleted](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#a50321fdffcc4ebe5f003e0bd35e5f8ed) () |
| static void | [Create](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#ad6f9f2582546b7a28ff7441f505c8a3e) () |
| static void | [Initialize](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#a973ad9f5cfd23be1d99864a696e1d648) () |
| static string | [MusicDebug](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#aa9d6b0b281134a5c893b5050ed3aa768) (List< String > strings) |

|  |  |
| --- | --- |
| Properties | |
| static MBMusicManager | [Current](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#a90a7c86ae8ab9c5de7a8bfed66c4e57d) `[get]` |
| [MusicMode](namespace_tale_worlds_1_1_mount_and_blade.html#a77e88820986269839b09590fedacd66f) | [CurrentMode](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#a843d23976d1042e4341355a932d1f371) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#a50321fdffcc4ebe5f003e0bd35e5f8ed)IsCreationCompleted()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.MBMusicManager.IsCreationCompleted | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#ad6f9f2582546b7a28ff7441f505c8a3e)Create()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBMusicManager.Create | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#a973ad9f5cfd23be1d99864a696e1d648)Initialize()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBMusicManager.Initialize | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#abe5bfc59e59408c28702496772fd0bc2)OnCampaignMusicHandlerInit()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBMusicManager.OnCampaignMusicHandlerInit | ( | [IMusicHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_music_handler.html) | *campaignMusicHandler* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#a51b24129c663abf071d76e7429167515)OnCampaignMusicHandlerFinalize()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBMusicManager.OnCampaignMusicHandlerFinalize | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#a80b972ffbca039d983cb169342e12a01)OnBattleMusicHandlerInit()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBMusicManager.OnBattleMusicHandlerInit | ( | [IMusicHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_music_handler.html) | *battleMusicHandler* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#a04798b16243b31e2a872bf4e3d948db7)OnBattleMusicHandlerFinalize()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBMusicManager.OnBattleMusicHandlerFinalize | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#a8047bcf53be275fa8a2d581ccbf0103f)OnSilencedMusicHandlerInit()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBMusicManager.OnSilencedMusicHandlerInit | ( | [IMusicHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_music_handler.html) | *silencedMusicHandler* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#a8c0c1b0bb5c7c3cc4ae0e262e6f0409a)OnSilencedMusicHandlerFinalize()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBMusicManager.OnSilencedMusicHandlerFinalize | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#ad013b228e06d37be188029a8bc96721c)ActivateBattleMode()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBMusicManager.ActivateBattleMode | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#ad6d1b4c526c7e84099cc350c04fa58c0)DeactivateBattleMode()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBMusicManager.DeactivateBattleMode | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#ab5127069d625f872137df9d7a97d7aca)ActivateCampaignMode()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBMusicManager.ActivateCampaignMode | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#a0477c46c0baec83eeb2fc5e328045f05)DeactivateCampaignMode()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBMusicManager.DeactivateCampaignMode | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#a3b026462b1fcb97b49ef185bce57283e)DeactivateCurrentMode()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBMusicManager.DeactivateCurrentMode | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#af0a87847d197c52a9ae8d6e9b14d243a)UnpauseMusicManagerSystem()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBMusicManager.UnpauseMusicManagerSystem | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#ad6e70d7984e53775da339c832b9717f1)PauseMusicManagerSystem()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBMusicManager.PauseMusicManagerSystem | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#a03b4b2b1b97a426fbe98588fa503c472)StartTheme()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBMusicManager.StartTheme | ( | [MusicTheme](namespace_tale_worlds_1_1_mount_and_blade.html#a6414d29697ec70a9803d25de86ef2c47) | *theme*, |
|  |  | float | *startIntensity*, |
|  |  | bool | *queueEndSegment* = false ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#a31f2a90c49853b198a964018e51d6ced)StartThemeWithConstantIntensity()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBMusicManager.StartThemeWithConstantIntensity | ( | [MusicTheme](namespace_tale_worlds_1_1_mount_and_blade.html#a6414d29697ec70a9803d25de86ef2c47) | *theme*, |
|  |  | bool | *queueEndSegment* = false ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#a3aad2b70975c78257116f50377a8ac7c)ForceStopThemeWithFadeOut()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBMusicManager.ForceStopThemeWithFadeOut | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#a79e246463eebc62aba4920487c300c22)ChangeCurrentThemeIntensity()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBMusicManager.ChangeCurrentThemeIntensity | ( | float | *deltaIntensity* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#a960a3fe144a055785123d47bffdc466b)Update()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MBMusicManager.Update | ( | float | *dt* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#a13323a3a49db2d0f6baf9cea29248ae3)GetSiegeTheme()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [MusicTheme](namespace_tale_worlds_1_1_mount_and_blade.html#a6414d29697ec70a9803d25de86ef2c47) TaleWorlds.MountAndBlade.MBMusicManager.GetSiegeTheme | ( | [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) | *culture* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#a7506fb38a3162b514128afba8199f6d9)GetBattleTheme()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [MusicTheme](namespace_tale_worlds_1_1_mount_and_blade.html#a6414d29697ec70a9803d25de86ef2c47) TaleWorlds.MountAndBlade.MBMusicManager.GetBattleTheme | ( | [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) | *culture*, |
|  |  | int | *battleSize*, |
|  |  | out bool | *isPaganBattle* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#a2a48e5b03d0af8a35b5ef0dd0cf991e7)GetBattleEndTheme()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [MusicTheme](namespace_tale_worlds_1_1_mount_and_blade.html#a6414d29697ec70a9803d25de86ef2c47) TaleWorlds.MountAndBlade.MBMusicManager.GetBattleEndTheme | ( | [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) | *culture*, |
|  |  | bool | *isVictory* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#a701fe92a06e657392e378e29699d42e0)GetBattleTurnsOneSideTheme()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [MusicTheme](namespace_tale_worlds_1_1_mount_and_blade.html#a6414d29697ec70a9803d25de86ef2c47) TaleWorlds.MountAndBlade.MBMusicManager.GetBattleTurnsOneSideTheme | ( | [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) | *culture*, |
|  |  | bool | *isPositive*, |
|  |  | bool | *isPaganBattle* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#a675e93d2750142602838edf2f84934d3)GetCampaignMusicTheme()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [MusicTheme](namespace_tale_worlds_1_1_mount_and_blade.html#a6414d29697ec70a9803d25de86ef2c47) TaleWorlds.MountAndBlade.MBMusicManager.GetCampaignMusicTheme | ( | [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) | *culture*, |
|  |  | bool | *isDark*, |
|  |  | bool | *isWarMode*, |
|  |  | bool | *isAtSea* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#aa9d6b0b281134a5c893b5050ed3aa768)MusicDebug()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.MBMusicManager.MusicDebug | ( | List< String > | *strings* | ) |  | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#a90a7c86ae8ab9c5de7a8bfed66c4e57d)Current
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBMusicManager TaleWorlds.MountAndBlade.MBMusicManager.Current | | staticget |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_music_manager.html#a843d23976d1042e4341355a932d1f371)CurrentMode
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MusicMode](namespace_tale_worlds_1_1_mount_and_blade.html#a77e88820986269839b09590fedacd66f) TaleWorlds.MountAndBlade.MBMusicManager.CurrentMode | | get |

