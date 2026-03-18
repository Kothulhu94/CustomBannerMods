--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html ---

TaleWorlds.MountAndBlade.MBGameManager Class ReferenceabstractInherits [TaleWorlds.Core.GameManagerBase](class_tale_worlds_1_1_core_1_1_game_manager_base.html).

Inherited by [SandBox.EditorSceneMissionManager](class_sand_box_1_1_editor_scene_mission_manager.html), [SandBox.SandBoxGameManager](class_sand_box_1_1_sand_box_game_manager.html), and [TaleWorlds.MountAndBlade.EditorGameManager](class_tale_worlds_1_1_mount_and_blade_1_1_editor_game_manager.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [BeginGameStart](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#aa3d807fe692239e3f9f88bf86df11b97) ([Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) game) |
| override void | [OnNewCampaignStart](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#a020ebf188e6e08703364d19f9151b838) ([Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) game, object starterObject) |
| override void | [InitializeSubModuleGameObjects](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#a8a70a1240b4d9fbd6ca9e209a63f93b0) ([Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) game) |
|  | Initializes and registers GameObjects that are introduced by sub modules to the MBObjectManager before creating default lists (e.g. DefaultSkills). |
| override void | [RegisterSubModuleObjects](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#a222bfbd407e3071f1f6eea4f21ca7bf6) (bool isSavedCampaign) |
| override void | [RegisterSubModuleTypes](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#ab503052cb3077a21d2c4292c1f570b71) () |
| override void | [AfterRegisterSubModuleObjects](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#af91ffc26883119140a20919e4ac632f9) (bool isSavedCampaign) |
| override void | [InitializeGameStarter](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#ac54b4311bf4e836248fa7f0cc845c0bc) ([Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) game, [IGameStarter](interface_tale_worlds_1_1_core_1_1_i_game_starter.html) starterObject) |
| override void | [OnGameInitializationFinished](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#aa7f9239d772f1d11bbf9cf7e3be4c292) ([Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) game) |
| override void | [OnAfterGameInitializationFinished](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#ada440544120dc29387b50c4388aa9b41) ([Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) game, object initializerObject) |
| override void | [OnGameLoaded](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#a859837665a7b1152b1beaf3bba801a08) ([Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) game, object initializerObject) |
| override void | [OnAfterGameLoaded](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#ade0974212a989104f178702dec2a125a) ([Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) game) |
| override void | [OnNewGameCreated](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#adf324dac0362a8562cafbd0a82da792a) ([Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) game, object initializerObject) |
| override void | [OnGameStart](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#a2e0c3a78940b22985cc2f16fefce0989) ([Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) game, [IGameStarter](interface_tale_worlds_1_1_core_1_1_i_game_starter.html) gameStarter) |
| override void | [OnGameEnd](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#abe9787054f0742a4c4093845736fd951) ([Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) game) |
| override void | [OnLoadFinished](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#aa2c7f5b3f56798048caad9a4294f24c2) () |
| bool | [CheckAndSetEnding](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#a756e630f0753a2568f52fe43fcd417b3) () |
| virtual void | [OnSessionInvitationAccepted](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#a86eb3c20271f34e9749858ac35fd2522) (PlatformService.SessionInvitationType targetGameType) |
| virtual void | [OnPlatformRequestedMultiplayer](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#ad6e2ec6ca1041a6c4f146ac3d0d9f29b) () |
| Public Member Functions inherited from [TaleWorlds.Core.GameManagerBase](class_tale_worlds_1_1_core_1_1_game_manager_base.html) | |
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
| bool | [DoLoadingForGameManager](class_tale_worlds_1_1_core_1_1_game_manager_base.html#ade2d2cd3253b44b645e1ae99c1cbe8ec) () |
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

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [StartNewGame](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#a6dfbe4a3504ed82d5864a9e742016154) ([MBGameManager](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#ad73d4b0eb357ae8a5e64d1d5e23cb8fc) gameLoader) |
| static async void | [EndGame](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#a84313f0bed9cd6cd08565ad59cc45784) () |

|  |  |
| --- | --- |
| Protected Member Functions | |
|  | [MBGameManager](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#ad73d4b0eb357ae8a5e64d1d5e23cb8fc) () |
| List< [MbObjectXmlInformation](struct_tale_worlds_1_1_object_system_1_1_mb_object_xml_information.html) > | [GetXmlInformationFromModule](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#ae748161c434cb79a7098543080909eb1) () |
| Protected Member Functions inherited from [TaleWorlds.Core.GameManagerBase](class_tale_worlds_1_1_core_1_1_game_manager_base.html) | |
|  | [GameManagerBase](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a8590149dd62068a7ccedfffe88ce6956) () |
| virtual void | [DoLoadingForGameManager](class_tale_worlds_1_1_core_1_1_game_manager_base.html#ad6bc40b6ff997da52454739505927d66) ([GameManagerLoadingSteps](namespace_tale_worlds_1_1_core.html#ad2f1a9f98ff147ac5dd5bfb12afffb1c) gameManagerLoadingStep, out [GameManagerLoadingSteps](namespace_tale_worlds_1_1_core.html#ad2f1a9f98ff147ac5dd5bfb12afffb1c) nextStep) |

|  |  |
| --- | --- |
| Static Protected Member Functions | |
| static void | [StartNewGame](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#aad6b0d35454999f0659210a63abe3aef) () |
| static void | [LoadModuleData](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#a116c11474c025a97d04ef5fd9d1c4383) (bool isLoadGame) |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsEnding](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#a8229002eb95bd1d598cb8a5e562690c7) `[get]` |
| static new [MBGameManager](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#ad73d4b0eb357ae8a5e64d1d5e23cb8fc) | [Current](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#aa8e6d79c9d47f821d7e0b2b23521337b) `[get]` |
| bool | [IsLoaded](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#a18053e69bcaff7fe258488732bb09a9f) `[get, protected set]` |
| override float | [ApplicationTime](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#ae29419831727ec98ed0a37ffcf082fa1) `[get]` |
| override bool | [CheatMode](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#af822704bc69aa4a8c0c40d3cbe7abb21) `[get]` |
| override bool | [IsDevelopmentMode](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#aedd150ecc8229f653a482e21120c84d6) `[get]` |
| override bool | [IsEditModeOn](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#a88f6f64f4f9e385471d7b17eece7f8bf) `[get]` |
| override [UnitSpawnPrioritizations](namespace_tale_worlds_1_1_core.html#a175469225c40d109f12d59fffaafa604) | [UnitSpawnPrioritization](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#adb8751e55eef721ea9b78cc4831c432f) `[get]` |
| Properties inherited from [TaleWorlds.Core.GameManagerBase](class_tale_worlds_1_1_core_1_1_game_manager_base.html) | |
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

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#ad73d4b0eb357ae8a5e64d1d5e23cb8fc)MBGameManager()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | TaleWorlds.MountAndBlade.MBGameManager.MBGameManager | ( |  | ) |  | | protected |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#aad6b0d35454999f0659210a63abe3aef)StartNewGame() [1/2]
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBGameManager.StartNewGame | ( |  | ) |  | | staticprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#a116c11474c025a97d04ef5fd9d1c4383)LoadModuleData()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBGameManager.LoadModuleData | ( | bool | *isLoadGame* | ) |  | | staticprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#a6dfbe4a3504ed82d5864a9e742016154)StartNewGame() [2/2]
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBGameManager.StartNewGame | ( | [MBGameManager](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#ad73d4b0eb357ae8a5e64d1d5e23cb8fc) | *gameLoader* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#aa3d807fe692239e3f9f88bf86df11b97)BeginGameStart()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.MountAndBlade.MBGameManager.BeginGameStart | ( | [Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) | *game* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#a020ebf188e6e08703364d19f9151b838)OnNewCampaignStart()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.MountAndBlade.MBGameManager.OnNewCampaignStart | ( | [Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) | *game*, |
|  |  | object | *starterObject* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#a8a70a1240b4d9fbd6ca9e209a63f93b0)InitializeSubModuleGameObjects()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MBGameManager.InitializeSubModuleGameObjects | ( | [Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) | *game* | ) |  | | virtual |

Parameters
:   |  |  |
    | --- | --- |
    | game | Current game object to register the GameObjects |

Reimplemented from [TaleWorlds.Core.GameManagerBase](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a3fea4e9e7a27b4be0b92ade1dccb8fc7).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#a222bfbd407e3071f1f6eea4f21ca7bf6)RegisterSubModuleObjects()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.MountAndBlade.MBGameManager.RegisterSubModuleObjects | ( | bool | *isSavedCampaign* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#ab503052cb3077a21d2c4292c1f570b71)RegisterSubModuleTypes()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.MountAndBlade.MBGameManager.RegisterSubModuleTypes | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#af91ffc26883119140a20919e4ac632f9)AfterRegisterSubModuleObjects()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.MountAndBlade.MBGameManager.AfterRegisterSubModuleObjects | ( | bool | *isSavedCampaign* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#ac54b4311bf4e836248fa7f0cc845c0bc)InitializeGameStarter()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MBGameManager.InitializeGameStarter | ( | [Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) | *game*, | |  |  | [IGameStarter](interface_tale_worlds_1_1_core_1_1_i_game_starter.html) | *starterObject* ) | | virtual |

Reimplemented from [TaleWorlds.Core.GameManagerBase](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a86819a0bd8acfd21ed7dbbe59939b4ed).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#aa7f9239d772f1d11bbf9cf7e3be4c292)OnGameInitializationFinished()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.MountAndBlade.MBGameManager.OnGameInitializationFinished | ( | [Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) | *game* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#ada440544120dc29387b50c4388aa9b41)OnAfterGameInitializationFinished()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.MountAndBlade.MBGameManager.OnAfterGameInitializationFinished | ( | [Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) | *game*, |
|  |  | object | *initializerObject* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#a859837665a7b1152b1beaf3bba801a08)OnGameLoaded()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.MountAndBlade.MBGameManager.OnGameLoaded | ( | [Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) | *game*, |
|  |  | object | *initializerObject* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#ade0974212a989104f178702dec2a125a)OnAfterGameLoaded()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.MountAndBlade.MBGameManager.OnAfterGameLoaded | ( | [Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) | *game* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#adf324dac0362a8562cafbd0a82da792a)OnNewGameCreated()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.MountAndBlade.MBGameManager.OnNewGameCreated | ( | [Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) | *game*, |
|  |  | object | *initializerObject* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#a2e0c3a78940b22985cc2f16fefce0989)OnGameStart()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.MountAndBlade.MBGameManager.OnGameStart | ( | [Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) | *game*, |
|  |  | [IGameStarter](interface_tale_worlds_1_1_core_1_1_i_game_starter.html) | *gameStarter* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#abe9787054f0742a4c4093845736fd951)OnGameEnd()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MBGameManager.OnGameEnd | ( | [Game](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a871d1e9ea60bacb2a89a5ace2eea4531) | *game* | ) |  | | virtual |

Reimplemented from [TaleWorlds.Core.GameManagerBase](class_tale_worlds_1_1_core_1_1_game_manager_base.html#a6bb1db24e3e61c08063e87f70fc4f2d7).

Reimplemented in [SandBox.SandBoxGameManager](class_sand_box_1_1_sand_box_game_manager.html#a94dd83d194ae1bf57ac05ec38eacf4f5).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#a84313f0bed9cd6cd08565ad59cc45784)EndGame()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | async void TaleWorlds.MountAndBlade.MBGameManager.EndGame | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#aa2c7f5b3f56798048caad9a4294f24c2)OnLoadFinished()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MBGameManager.OnLoadFinished | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Core.GameManagerBase](class_tale_worlds_1_1_core_1_1_game_manager_base.html#ac39d7eba0fd328427a2fa8ed67298887).

Reimplemented in [SandBox.SandBoxGameManager](class_sand_box_1_1_sand_box_game_manager.html#a624cf10e2177488ea02fe54cf997eb1e).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#a756e630f0753a2568f52fe43fcd417b3)CheckAndSetEnding()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MBGameManager.CheckAndSetEnding | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#a86eb3c20271f34e9749858ac35fd2522)OnSessionInvitationAccepted()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MBGameManager.OnSessionInvitationAccepted | ( | PlatformService.SessionInvitationType | *targetGameType* | ) |  | | virtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#ad6e2ec6ca1041a6c4f146ac3d0d9f29b)OnPlatformRequestedMultiplayer()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MBGameManager.OnPlatformRequestedMultiplayer | ( |  | ) |  | | virtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#ae748161c434cb79a7098543080909eb1)GetXmlInformationFromModule()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | List< [MbObjectXmlInformation](struct_tale_worlds_1_1_object_system_1_1_mb_object_xml_information.html) > TaleWorlds.MountAndBlade.MBGameManager.GetXmlInformationFromModule | ( |  | ) |  | | protected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#a8229002eb95bd1d598cb8a5e562690c7)IsEnding
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.MBGameManager.IsEnding | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#aa8e6d79c9d47f821d7e0b2b23521337b)Current
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | new [MBGameManager](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#ad73d4b0eb357ae8a5e64d1d5e23cb8fc) TaleWorlds.MountAndBlade.MBGameManager.Current | | staticget |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#a18053e69bcaff7fe258488732bb09a9f)IsLoaded
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.MBGameManager.IsLoaded | | getprotected set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#ae29419831727ec98ed0a37ffcf082fa1)ApplicationTime
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.MountAndBlade.MBGameManager.ApplicationTime | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#af822704bc69aa4a8c0c40d3cbe7abb21)CheatMode
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override bool TaleWorlds.MountAndBlade.MBGameManager.CheatMode | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#aedd150ecc8229f653a482e21120c84d6)IsDevelopmentMode
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override bool TaleWorlds.MountAndBlade.MBGameManager.IsDevelopmentMode | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#a88f6f64f4f9e385471d7b17eece7f8bf)IsEditModeOn
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override bool TaleWorlds.MountAndBlade.MBGameManager.IsEditModeOn | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html#adb8751e55eef721ea9b78cc4831c432f)UnitSpawnPrioritization
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [UnitSpawnPrioritizations](namespace_tale_worlds_1_1_core.html#a175469225c40d109f12d59fffaafa604) TaleWorlds.MountAndBlade.MBGameManager.UnitSpawnPrioritization | | get |

