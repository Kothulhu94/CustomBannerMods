--- SOURCE: class_tale_worlds_1_1_core_1_1_game_manager_base.html ---

TaleWorlds.Core.GameManagerBase Class ReferenceabstractInherited by [TaleWorlds.MountAndBlade.MBGameManager](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a5412492e7f9865932e180d88e50ddd59) () |
| [GameManagerComponent](class_tale_worlds_1_1_core_1_1_game_manager_component.html) | [AddComponent](class_tale_worlds_1_1_core_1_1_game_manager_base.html#adb3a3a160f0d5cfc55ead16712a3c5c5) (Type componentType) |
| T | [AddComponent< T >](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a05a31dacb49c52feef8be8476b1e863e) () |
| [GameManagerComponent](class_tale_worlds_1_1_core_1_1_game_manager_component.html) | [GetComponent](class_tale_worlds_1_1_core_1_1_game_manager_base.html#ad5ec4b03388b3f9f1f83504fc57031b8) (Type componentType) |
| T | [GetComponent< T >](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a901452be35779cdbd569dd1377f4da4c) () |
| IEnumerable< T > | [GetComponents< T >](class_tale_worlds_1_1_core_1_1_game_manager_base.html#ad9f3e2271c73ede498a7fa903dfa3a99) () |
| void | [RemoveComponent< T >](class_tale_worlds_1_1_core_1_1_game_manager_base.html#ae01ef06fc908c7a9b0b26ca46d8d7b0c) () |
| void | [RemoveComponent](class_tale_worlds_1_1_core_1_1_game_manager_base.html#ad932dddaca2656353a71b4e691a6a96a) ([GameManagerComponent](class_tale_worlds_1_1_core_1_1_game_manager_component.html) component) |
| void | [OnTick](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a2a496e8bccfeafc9e034c170c0d25a2e) (float dt) |
| void | [OnGameNetworkBegin](class_tale_worlds_1_1_core_1_1_game_manager_base.html#ac4e7f03fca2830c56138164cf922d554) () |
| void | [OnGameNetworkEnd](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a767ddba9c38a12f0234271d053e54321) () |
| void | [OnPlayerConnect](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a3a28c1eda41502b6175b574eb3e65af3) ([VirtualPlayer](class_tale_worlds_1_1_core_1_1_virtual_player.html) peer) |
| void | [OnPlayerDisconnect](class_tale_worlds_1_1_core_1_1_game_manager_base.html#aedfeb96e09996990ae6b22bbe7e568b3) ([VirtualPlayer](class_tale_worlds_1_1_core_1_1_virtual_player.html) peer) |
| virtual void | [OnGameEnd](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a6bb1db24e3e61c08063e87f70fc4f2d7) ([Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) game) |
| bool | [DoLoadingForGameManager](class_tale_worlds_1_1_core_1_1_game_manager_base.html#ade2d2cd3253b44b645e1ae99c1cbe8ec) () |
| virtual void | [OnLoadFinished](class_tale_worlds_1_1_core_1_1_game_manager_base.html#ac39d7eba0fd328427a2fa8ed67298887) () |
| virtual void | [InitializeGameStarter](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a86819a0bd8acfd21ed7dbbe59939b4ed) ([Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) game, [IGameStarter](interface_tale_worlds_1_1_core_1_1_i_game_starter.html) starterObject) |
| void | [OnGameStart](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a0651e24937ddb088cf84a698dd44da24) ([Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) game, [IGameStarter](interface_tale_worlds_1_1_core_1_1_i_game_starter.html) gameStarter) |
| void | [BeginGameStart](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a207668a1d8a69818c14910bda9f3fbc1) ([Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) game) |
| void | [OnNewCampaignStart](class_tale_worlds_1_1_core_1_1_game_manager_base.html#aea4ed6403292a8ea2a235ebe5f1e6cbe) ([Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) game, object starterObject) |
| void | [OnAfterCampaignStart](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a3a4055559f7bd6a0587f9668330bbc2c) ([Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) game) |
| void | [RegisterSubModuleObjects](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a9133336de96df402572fd693c0332e55) (bool isSavedCampaign) |
| void | [AfterRegisterSubModuleObjects](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a402b4f951a5c255617b0217aaf5a1308) (bool isSavedCampaign) |
| void | [OnGameInitializationFinished](class_tale_worlds_1_1_core_1_1_game_manager_base.html#afb4ac6e48013de272b8e550e11d2652b) ([Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) game) |
| void | [OnNewGameCreated](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a4bb9d985deca24f6760438cb159477c6) ([Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) game, object initializerObject) |
| void | [OnGameLoaded](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a2538c6d849b9277d8c3602d1e7b51798) ([Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) game, object initializerObject) |
| void | [OnAfterGameLoaded](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a3461e3199747170818145640b179e081) ([Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) game) |
| void | [OnAfterGameInitializationFinished](class_tale_worlds_1_1_core_1_1_game_manager_base.html#accfe04dbb603d0bd4d58e151e52e3453) ([Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) game, object initializerObject) |
| void | [RegisterSubModuleTypes](class_tale_worlds_1_1_core_1_1_game_manager_base.html#af443cb912b27377de884b7a18f029094) () |
| virtual void | [InitializeSubModuleGameObjects](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a3fea4e9e7a27b4be0b92ade1dccb8fc7) ([Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) game) |
|  | Initializes and registers GameObjects that are introduced by sub modules to the MBObjectManager before creating default lists (e.g. [DefaultSkills](class_tale_worlds_1_1_core_1_1_default_skills.html)). |

|  |  |
| --- | --- |
| Protected Member Functions | |
|  | [GameManagerBase](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a8590149dd62068a7ccedfffe88ce6956) () |
| virtual void | [DoLoadingForGameManager](class_tale_worlds_1_1_core_1_1_game_manager_base.html#ad6bc40b6ff997da52454739505927d66) ([GameManagerLoadingSteps](namespace_tale_worlds_1_1_core.html#ad2f1a9f98ff147ac5dd5bfb12afffb1c) gameManagerLoadingStep, out [GameManagerLoadingSteps](namespace_tale_worlds_1_1_core.html#ad2f1a9f98ff147ac5dd5bfb12afffb1c) nextStep) |

|  |  |
| --- | --- |
| Properties | |
| static [GameManagerBase](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a8590149dd62068a7ccedfffe88ce6956) | [Current](class_tale_worlds_1_1_core_1_1_game_manager_base.html#ab99a10fc5c651a23647be377b85c2917) `[get]` |
| Game | [Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) `[get]` |
| IEnumerable< [GameManagerComponent](class_tale_worlds_1_1_core_1_1_game_manager_component.html) > | [Components](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a979ec3a643bfc6f1be5a9d9d6c66073e) `[get]` |
| float | [ApplicationTime](class_tale_worlds_1_1_core_1_1_game_manager_base.html#aca5e12d05df0840329d41bc276920830) `[get]` |
| bool | [CheatMode](class_tale_worlds_1_1_core_1_1_game_manager_base.html#adc75780f4d5f49e7233dad9c494b9de4) `[get]` |
| bool | [IsDevelopmentMode](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a0eea523a503f286bfbc0d4a16439a221) `[get]` |
| bool | [IsEditModeOn](class_tale_worlds_1_1_core_1_1_game_manager_base.html#ab11f68a4e436f25274977d8bba677618) `[get]` |
| [UnitSpawnPrioritizations](namespace_tale_worlds_1_1_core.html#a175469225c40d109f12d59fffaafa604) | [UnitSpawnPrioritization](class_tale_worlds_1_1_core_1_1_game_manager_base.html#afe833801b9cfc50cc3bd65abae4eebc1) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a8590149dd62068a7ccedfffe88ce6956)GameManagerBase()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | TaleWorlds.Core.GameManagerBase.GameManagerBase | ( |  | ) |  | | protected |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a5412492e7f9865932e180d88e50ddd59)Initialize()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.GameManagerBase.Initialize | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_game_manager_base.html#adb3a3a160f0d5cfc55ead16712a3c5c5)AddComponent()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [GameManagerComponent](class_tale_worlds_1_1_core_1_1_game_manager_component.html) TaleWorlds.Core.GameManagerBase.AddComponent | ( | Type | *componentType* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a05a31dacb49c52feef8be8476b1e863e)AddComponent< T >()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| T [TaleWorlds.Core.GameManagerBase.AddComponent](class_tale_worlds_1_1_core_1_1_game_manager_base.html#adb3a3a160f0d5cfc55ead16712a3c5c5)< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[GameManagerComponent](class_tale_worlds_1_1_core_1_1_game_manager_component.html)* |  |
    | *T* | : | *new()* |  |

[◆](class_tale_worlds_1_1_core_1_1_game_manager_base.html#ad5ec4b03388b3f9f1f83504fc57031b8)GetComponent()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [GameManagerComponent](class_tale_worlds_1_1_core_1_1_game_manager_component.html) TaleWorlds.Core.GameManagerBase.GetComponent | ( | Type | *componentType* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a901452be35779cdbd569dd1377f4da4c)GetComponent< T >()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| T [TaleWorlds.Core.GameManagerBase.GetComponent](class_tale_worlds_1_1_core_1_1_game_manager_base.html#ad5ec4b03388b3f9f1f83504fc57031b8)< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[GameManagerComponent](class_tale_worlds_1_1_core_1_1_game_manager_component.html)* |  |

[◆](class_tale_worlds_1_1_core_1_1_game_manager_base.html#ad9f3e2271c73ede498a7fa903dfa3a99)GetComponents< T >()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< T > TaleWorlds.Core.GameManagerBase.GetComponents< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[GameManagerComponent](class_tale_worlds_1_1_core_1_1_game_manager_component.html)* |  |

[◆](class_tale_worlds_1_1_core_1_1_game_manager_base.html#ae01ef06fc908c7a9b0b26ca46d8d7b0c)RemoveComponent< T >()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void [TaleWorlds.Core.GameManagerBase.RemoveComponent](class_tale_worlds_1_1_core_1_1_game_manager_base.html#ad932dddaca2656353a71b4e691a6a96a)< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[GameManagerComponent](class_tale_worlds_1_1_core_1_1_game_manager_component.html)* |  |

[◆](class_tale_worlds_1_1_core_1_1_game_manager_base.html#ad932dddaca2656353a71b4e691a6a96a)RemoveComponent()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.GameManagerBase.RemoveComponent | ( | [GameManagerComponent](class_tale_worlds_1_1_core_1_1_game_manager_component.html) | *component* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a2a496e8bccfeafc9e034c170c0d25a2e)OnTick()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.GameManagerBase.OnTick | ( | float | *dt* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_game_manager_base.html#ac4e7f03fca2830c56138164cf922d554)OnGameNetworkBegin()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.GameManagerBase.OnGameNetworkBegin | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a767ddba9c38a12f0234271d053e54321)OnGameNetworkEnd()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.GameManagerBase.OnGameNetworkEnd | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a3a28c1eda41502b6175b574eb3e65af3)OnPlayerConnect()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.GameManagerBase.OnPlayerConnect | ( | [VirtualPlayer](class_tale_worlds_1_1_core_1_1_virtual_player.html) | *peer* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_game_manager_base.html#aedfeb96e09996990ae6b22bbe7e568b3)OnPlayerDisconnect()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.GameManagerBase.OnPlayerDisconnect | ( | [VirtualPlayer](class_tale_worlds_1_1_core_1_1_virtual_player.html) | *peer* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a6bb1db24e3e61c08063e87f70fc4f2d7)OnGameEnd()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.Core.GameManagerBase.OnGameEnd | ( | [Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) | *game* | ) |  | | virtual |

Reimplemented in [SandBox.SandBoxGameManager](class_sand_box_1_1_sand_box_game_manager.html#a94dd83d194ae1bf57ac05ec38eacf4f5), and [TaleWorlds.MountAndBlade.MBGameManager](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#abe9787054f0742a4c4093845736fd951).

[◆](class_tale_worlds_1_1_core_1_1_game_manager_base.html#ad6bc40b6ff997da52454739505927d66)DoLoadingForGameManager() [1/2]
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.Core.GameManagerBase.DoLoadingForGameManager | ( | [GameManagerLoadingSteps](namespace_tale_worlds_1_1_core.html#ad2f1a9f98ff147ac5dd5bfb12afffb1c) | *gameManagerLoadingStep*, | |  |  | out [GameManagerLoadingSteps](namespace_tale_worlds_1_1_core.html#ad2f1a9f98ff147ac5dd5bfb12afffb1c) | *nextStep* ) | | protectedvirtual |

Reimplemented in [SandBox.EditorSceneMissionManager](class_sand_box_1_1_editor_scene_mission_manager.html#a39112604a3f648326c626a5cd8b40316), [SandBox.SandBoxGameManager](class_sand_box_1_1_sand_box_game_manager.html#ad92d3be7340a1ae0975f520b301c10e0), and [TaleWorlds.MountAndBlade.EditorGameManager](class_tale_worlds_1_1_mount_and_blade_1_1_editor_game_manager.html#a700fec9229e3681cebe8b41674adff54).

[◆](class_tale_worlds_1_1_core_1_1_game_manager_base.html#ade2d2cd3253b44b645e1ae99c1cbe8ec)DoLoadingForGameManager() [2/2]
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Core.GameManagerBase.DoLoadingForGameManager | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_game_manager_base.html#ac39d7eba0fd328427a2fa8ed67298887)OnLoadFinished()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.Core.GameManagerBase.OnLoadFinished | ( |  | ) |  | | virtual |

Reimplemented in [SandBox.EditorSceneMissionManager](class_sand_box_1_1_editor_scene_mission_manager.html#a158ba3123a28a289fce2897791595b28), [SandBox.SandBoxGameManager](class_sand_box_1_1_sand_box_game_manager.html#a624cf10e2177488ea02fe54cf997eb1e), [TaleWorlds.MountAndBlade.EditorGameManager](class_tale_worlds_1_1_mount_and_blade_1_1_editor_game_manager.html#a9e0d8743e847683e5942799f7105a51d), and [TaleWorlds.MountAndBlade.MBGameManager](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#aa2c7f5b3f56798048caad9a4294f24c2).

[◆](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a86819a0bd8acfd21ed7dbbe59939b4ed)InitializeGameStarter()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.Core.GameManagerBase.InitializeGameStarter | ( | [Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) | *game*, | |  |  | [IGameStarter](interface_tale_worlds_1_1_core_1_1_i_game_starter.html) | *starterObject* ) | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.MBGameManager](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#ac54b4311bf4e836248fa7f0cc845c0bc).

[◆](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a0651e24937ddb088cf84a698dd44da24)OnGameStart()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Core.GameManagerBase.OnGameStart | ( | [Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) | *game*, | |  |  | [IGameStarter](interface_tale_worlds_1_1_core_1_1_i_game_starter.html) | *gameStarter* ) | | abstract |

[◆](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a207668a1d8a69818c14910bda9f3fbc1)BeginGameStart()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Core.GameManagerBase.BeginGameStart | ( | [Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) | *game* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_core_1_1_game_manager_base.html#aea4ed6403292a8ea2a235ebe5f1e6cbe)OnNewCampaignStart()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Core.GameManagerBase.OnNewCampaignStart | ( | [Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) | *game*, | |  |  | object | *starterObject* ) | | abstract |

[◆](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a3a4055559f7bd6a0587f9668330bbc2c)OnAfterCampaignStart()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Core.GameManagerBase.OnAfterCampaignStart | ( | [Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) | *game* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a9133336de96df402572fd693c0332e55)RegisterSubModuleObjects()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Core.GameManagerBase.RegisterSubModuleObjects | ( | bool | *isSavedCampaign* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a402b4f951a5c255617b0217aaf5a1308)AfterRegisterSubModuleObjects()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Core.GameManagerBase.AfterRegisterSubModuleObjects | ( | bool | *isSavedCampaign* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_core_1_1_game_manager_base.html#afb4ac6e48013de272b8e550e11d2652b)OnGameInitializationFinished()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Core.GameManagerBase.OnGameInitializationFinished | ( | [Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) | *game* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a4bb9d985deca24f6760438cb159477c6)OnNewGameCreated()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Core.GameManagerBase.OnNewGameCreated | ( | [Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) | *game*, | |  |  | object | *initializerObject* ) | | abstract |

[◆](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a2538c6d849b9277d8c3602d1e7b51798)OnGameLoaded()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Core.GameManagerBase.OnGameLoaded | ( | [Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) | *game*, | |  |  | object | *initializerObject* ) | | abstract |

[◆](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a3461e3199747170818145640b179e081)OnAfterGameLoaded()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Core.GameManagerBase.OnAfterGameLoaded | ( | [Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) | *game* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_core_1_1_game_manager_base.html#accfe04dbb603d0bd4d58e151e52e3453)OnAfterGameInitializationFinished()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Core.GameManagerBase.OnAfterGameInitializationFinished | ( | [Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) | *game*, | |  |  | object | *initializerObject* ) | | abstract |

[◆](class_tale_worlds_1_1_core_1_1_game_manager_base.html#af443cb912b27377de884b7a18f029094)RegisterSubModuleTypes()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Core.GameManagerBase.RegisterSubModuleTypes | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a3fea4e9e7a27b4be0b92ade1dccb8fc7)InitializeSubModuleGameObjects()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.Core.GameManagerBase.InitializeSubModuleGameObjects | ( | [Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) | *game* | ) |  | | virtual |

Parameters
:   |  |  |
    | --- | --- |
    | game | Current game object to register the GameObjects |

Reimplemented in [TaleWorlds.MountAndBlade.MBGameManager](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#a8a70a1240b4d9fbd6ca9e209a63f93b0).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_game_manager_base.html#ab99a10fc5c651a23647be377b85c2917)Current
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GameManagerBase](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a8590149dd62068a7ccedfffe88ce6956) TaleWorlds.Core.GameManagerBase.Current | | staticget |

[◆](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531)Game
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Game TaleWorlds.Core.GameManagerBase.Game | | get |

[◆](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a979ec3a643bfc6f1be5a9d9d6c66073e)Components
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IEnumerable<[GameManagerComponent](class_tale_worlds_1_1_core_1_1_game_manager_component.html)> TaleWorlds.Core.GameManagerBase.Components | | get |

[◆](class_tale_worlds_1_1_core_1_1_game_manager_base.html#aca5e12d05df0840329d41bc276920830)ApplicationTime
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.GameManagerBase.ApplicationTime | | getabstract |

[◆](class_tale_worlds_1_1_core_1_1_game_manager_base.html#adc75780f4d5f49e7233dad9c494b9de4)CheatMode
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.GameManagerBase.CheatMode | | getabstract |

[◆](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a0eea523a503f286bfbc0d4a16439a221)IsDevelopmentMode
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.GameManagerBase.IsDevelopmentMode | | getabstract |

[◆](class_tale_worlds_1_1_core_1_1_game_manager_base.html#ab11f68a4e436f25274977d8bba677618)IsEditModeOn
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.GameManagerBase.IsEditModeOn | | getabstract |

[◆](class_tale_worlds_1_1_core_1_1_game_manager_base.html#afe833801b9cfc50cc3bd65abae4eebc1)UnitSpawnPrioritization
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [UnitSpawnPrioritizations](namespace_tale_worlds_1_1_core.html#a175469225c40d109f12d59fffaafa604) TaleWorlds.Core.GameManagerBase.UnitSpawnPrioritization | | getabstract |

