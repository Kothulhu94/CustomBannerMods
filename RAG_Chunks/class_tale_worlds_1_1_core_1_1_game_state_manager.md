--- SOURCE: class_tale_worlds_1_1_core_1_1_game_state_manager.html ---

TaleWorlds.Core.GameStateManager Class Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [GameStateManagerType](class_tale_worlds_1_1_core_1_1_game_state_manager.html#aee6defe100c30a16b2550648426c2fca) {     [Game](class_tale_worlds_1_1_core_1_1_game_state_manager.html#aee6defe100c30a16b2550648426c2fcaa63d72051e901c069f8aa1b32aa0c43bb) ,     [Global](class_tale_worlds_1_1_core_1_1_game_state_manager.html#aee6defe100c30a16b2550648426c2fcaa4cc6684df7b4a92b1dec6fce3264fac8)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [GameStateManager](class_tale_worlds_1_1_core_1_1_game_state_manager.html#af226ea081b49d5fcbe6990521b361616) ([IGameStateManagerOwner](interface_tale_worlds_1_1_core_1_1_i_game_state_manager_owner.html) owner, [GameStateManagerType](class_tale_worlds_1_1_core_1_1_game_state_manager.html#aee6defe100c30a16b2550648426c2fca) gameStateManagerType) |
| bool | [RegisterListener](class_tale_worlds_1_1_core_1_1_game_state_manager.html#a834e11d20aa67eaf7f185bebab385ab5) ([IGameStateManagerListener](interface_tale_worlds_1_1_core_1_1_i_game_state_manager_listener.html) listener) |
| bool | [UnregisterListener](class_tale_worlds_1_1_core_1_1_game_state_manager.html#aeeadee4167b3c2cc365fa410224a1a2c) ([IGameStateManagerListener](interface_tale_worlds_1_1_core_1_1_i_game_state_manager_listener.html) listener) |
| T | [GetListenerOfType< T >](class_tale_worlds_1_1_core_1_1_game_state_manager.html#a94d163b9480a45ad55c2d6e75e78b4bf) () |
| void | [RegisterActiveStateDisableRequest](class_tale_worlds_1_1_core_1_1_game_state_manager.html#abb3e2e33e090e3b8ed8bfa58a128eca6) (object requestingInstance) |
|  | Register a request to disable the active state. If any requests exist, the active state will be paused. |
| void | [UnregisterActiveStateDisableRequest](class_tale_worlds_1_1_core_1_1_game_state_manager.html#afd39fb4b2bb0a7f80a17147ec799c861) (object requestingInstance) |
|  | Unregister the request made by the given instance to disable the active state. |
| void | [OnSavedGameLoadFinished](class_tale_worlds_1_1_core_1_1_game_state_manager.html#aadc10cb34605686cc3b4a53367a94537) () |
| T | [LastOrDefault< T >](class_tale_worlds_1_1_core_1_1_game_state_manager.html#a08876c15f00e17d60786e86d52797064) () |
| T | [CreateState< T >](class_tale_worlds_1_1_core_1_1_game_state_manager.html#aa6f777fed5652026a37bb2e47f258135) () |
| T | [CreateState< T >](class_tale_worlds_1_1_core_1_1_game_state_manager.html#a7dba66e88d00208f6c84395b1037144d) (params object[] parameters) |
| void | [OnTick](class_tale_worlds_1_1_core_1_1_game_state_manager.html#a1276a8560e7a473a2e22cd376448c123) (float dt) |
| void | [PushState](class_tale_worlds_1_1_core_1_1_game_state_manager.html#aa6df5e60db99fe9ea8b49bbf25f23044) ([GameState](class_tale_worlds_1_1_core_1_1_game_state.html) gameState, int level=0) |
| void | [PopState](class_tale_worlds_1_1_core_1_1_game_state_manager.html#ace36a751a56981bca8d450a6cdb55a68) (int level=0) |
| void | [CleanAndPushState](class_tale_worlds_1_1_core_1_1_game_state_manager.html#a10148e222712a804b599f7802a4eb02a) ([GameState](class_tale_worlds_1_1_core_1_1_game_state.html) gameState, int level=0) |
| void | [CleanStates](class_tale_worlds_1_1_core_1_1_game_state_manager.html#a03d3150d101a5c411141407fbcd25549) (int level=0) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static string | [StateActivateCommand](class_tale_worlds_1_1_core_1_1_game_state_manager.html#a1d1471d76431e79388a88dda98ba4922) |

|  |  |
| --- | --- |
| Properties | |
| static [GameStateManager](class_tale_worlds_1_1_core_1_1_game_state_manager.html#af226ea081b49d5fcbe6990521b361616) | [Current](class_tale_worlds_1_1_core_1_1_game_state_manager.html#aabc1b1c24290f73416fd1d6c9551c3b7) `[get, set]` |
| IReadOnlyCollection< [IGameStateManagerListener](interface_tale_worlds_1_1_core_1_1_i_game_state_manager_listener.html) > | [Listeners](class_tale_worlds_1_1_core_1_1_game_state_manager.html#a212422bdb9d82b05f009489af824caa1) `[get]` |
| [GameStateManagerType](class_tale_worlds_1_1_core_1_1_game_state_manager.html#aee6defe100c30a16b2550648426c2fca) | [CurrentType](class_tale_worlds_1_1_core_1_1_game_state_manager.html#ad4328377f9700f8881a4ae0893e40e05) `[get]` |
| [IGameStateManagerOwner](interface_tale_worlds_1_1_core_1_1_i_game_state_manager_owner.html) | [Owner](class_tale_worlds_1_1_core_1_1_game_state_manager.html#ae620c1a1c636d56328da2fea3d67f13f) `[get]` |
| IEnumerable< [GameState](class_tale_worlds_1_1_core_1_1_game_state.html) > | [GameStates](class_tale_worlds_1_1_core_1_1_game_state_manager.html#ad3e23140a64138019c2a1db37e0746dc) `[get]` |
| bool | [ActiveStateDisabledByUser](class_tale_worlds_1_1_core_1_1_game_state_manager.html#a69feb731811096cdea81aa5c4bd1a56e) `[get]` |
| [GameState](class_tale_worlds_1_1_core_1_1_game_state.html) | [ActiveState](class_tale_worlds_1_1_core_1_1_game_state_manager.html#ae54d6f6b33624081753137199013155e) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_core_1_1_game_state_manager.html#aee6defe100c30a16b2550648426c2fca)GameStateManagerType
-----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.Core.GameStateManager.GameStateManagerType](class_tale_worlds_1_1_core_1_1_game_state_manager.html#aee6defe100c30a16b2550648426c2fca) |

| Enumerator | |
| --- | --- |
| Game |  |
| Global |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_core_1_1_game_state_manager.html#af226ea081b49d5fcbe6990521b361616)GameStateManager()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Core.GameStateManager.GameStateManager | ( | [IGameStateManagerOwner](interface_tale_worlds_1_1_core_1_1_i_game_state_manager_owner.html) | *owner*, |
|  |  | [GameStateManagerType](class_tale_worlds_1_1_core_1_1_game_state_manager.html#aee6defe100c30a16b2550648426c2fca) | *gameStateManagerType* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_game_state_manager.html#a834e11d20aa67eaf7f185bebab385ab5)RegisterListener()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Core.GameStateManager.RegisterListener | ( | [IGameStateManagerListener](interface_tale_worlds_1_1_core_1_1_i_game_state_manager_listener.html) | *listener* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_game_state_manager.html#aeeadee4167b3c2cc365fa410224a1a2c)UnregisterListener()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Core.GameStateManager.UnregisterListener | ( | [IGameStateManagerListener](interface_tale_worlds_1_1_core_1_1_i_game_state_manager_listener.html) | *listener* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_game_state_manager.html#a94d163b9480a45ad55c2d6e75e78b4bf)GetListenerOfType< T >()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| T TaleWorlds.Core.GameStateManager.GetListenerOfType< T > | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_game_state_manager.html#abb3e2e33e090e3b8ed8bfa58a128eca6)RegisterActiveStateDisableRequest()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.GameStateManager.RegisterActiveStateDisableRequest | ( | object | *requestingInstance* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_game_state_manager.html#afd39fb4b2bb0a7f80a17147ec799c861)UnregisterActiveStateDisableRequest()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.GameStateManager.UnregisterActiveStateDisableRequest | ( | object | *requestingInstance* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_game_state_manager.html#aadc10cb34605686cc3b4a53367a94537)OnSavedGameLoadFinished()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.GameStateManager.OnSavedGameLoadFinished | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_game_state_manager.html#a08876c15f00e17d60786e86d52797064)LastOrDefault< T >()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| T TaleWorlds.Core.GameStateManager.LastOrDefault< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[GameState](class_tale_worlds_1_1_core_1_1_game_state.html)* |  |

[◆](class_tale_worlds_1_1_core_1_1_game_state_manager.html#aa6f777fed5652026a37bb2e47f258135)CreateState< T >() [1/2]
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| T TaleWorlds.Core.GameStateManager.CreateState< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[GameState](class_tale_worlds_1_1_core_1_1_game_state.html)* |  |
    | *T* | : | *new()* |  |

[◆](class_tale_worlds_1_1_core_1_1_game_state_manager.html#a7dba66e88d00208f6c84395b1037144d)CreateState< T >() [2/2]
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| T TaleWorlds.Core.GameStateManager.CreateState< T > | ( | params object[] | *parameters* | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[GameState](class_tale_worlds_1_1_core_1_1_game_state.html)* |  |
    | *T* | : | *new()* |  |

[◆](class_tale_worlds_1_1_core_1_1_game_state_manager.html#a1276a8560e7a473a2e22cd376448c123)OnTick()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.GameStateManager.OnTick | ( | float | *dt* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_game_state_manager.html#aa6df5e60db99fe9ea8b49bbf25f23044)PushState()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.GameStateManager.PushState | ( | [GameState](class_tale_worlds_1_1_core_1_1_game_state.html) | *gameState*, |
|  |  | int | *level* = 0 ) |

[◆](class_tale_worlds_1_1_core_1_1_game_state_manager.html#ace36a751a56981bca8d450a6cdb55a68)PopState()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.GameStateManager.PopState | ( | int | *level* = 0 | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_game_state_manager.html#a10148e222712a804b599f7802a4eb02a)CleanAndPushState()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.GameStateManager.CleanAndPushState | ( | [GameState](class_tale_worlds_1_1_core_1_1_game_state.html) | *gameState*, |
|  |  | int | *level* = 0 ) |

[◆](class_tale_worlds_1_1_core_1_1_game_state_manager.html#a03d3150d101a5c411141407fbcd25549)CleanStates()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.GameStateManager.CleanStates | ( | int | *level* = 0 | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_core_1_1_game_state_manager.html#a1d1471d76431e79388a88dda98ba4922)StateActivateCommand
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.GameStateManager.StateActivateCommand | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_game_state_manager.html#aabc1b1c24290f73416fd1d6c9551c3b7)Current
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GameStateManager](class_tale_worlds_1_1_core_1_1_game_state_manager.html#af226ea081b49d5fcbe6990521b361616) TaleWorlds.Core.GameStateManager.Current | | staticgetset |

[◆](class_tale_worlds_1_1_core_1_1_game_state_manager.html#a212422bdb9d82b05f009489af824caa1)Listeners
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IReadOnlyCollection<[IGameStateManagerListener](interface_tale_worlds_1_1_core_1_1_i_game_state_manager_listener.html)> TaleWorlds.Core.GameStateManager.Listeners | | get |

[◆](class_tale_worlds_1_1_core_1_1_game_state_manager.html#ad4328377f9700f8881a4ae0893e40e05)CurrentType
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GameStateManagerType](class_tale_worlds_1_1_core_1_1_game_state_manager.html#aee6defe100c30a16b2550648426c2fca) TaleWorlds.Core.GameStateManager.CurrentType | | get |

[◆](class_tale_worlds_1_1_core_1_1_game_state_manager.html#ae620c1a1c636d56328da2fea3d67f13f)Owner
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IGameStateManagerOwner](interface_tale_worlds_1_1_core_1_1_i_game_state_manager_owner.html) TaleWorlds.Core.GameStateManager.Owner | | get |

[◆](class_tale_worlds_1_1_core_1_1_game_state_manager.html#ad3e23140a64138019c2a1db37e0746dc)GameStates
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IEnumerable<[GameState](class_tale_worlds_1_1_core_1_1_game_state.html)> TaleWorlds.Core.GameStateManager.GameStates | | get |

[◆](class_tale_worlds_1_1_core_1_1_game_state_manager.html#a69feb731811096cdea81aa5c4bd1a56e)ActiveStateDisabledByUser
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.GameStateManager.ActiveStateDisabledByUser | | get |

[◆](class_tale_worlds_1_1_core_1_1_game_state_manager.html#ae54d6f6b33624081753137199013155e)ActiveState
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GameState](class_tale_worlds_1_1_core_1_1_game_state.html) TaleWorlds.Core.GameStateManager.ActiveState | | get |

