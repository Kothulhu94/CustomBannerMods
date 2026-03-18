--- SOURCE: class_tale_worlds_1_1_core_1_1_game.html ---

TaleWorlds.Core.Game Class ReferencesealedInherits [TaleWorlds.Core.IGameStateManagerOwner](interface_tale_worlds_1_1_core_1_1_i_game_state_manager_owner.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [State](class_tale_worlds_1_1_core_1_1_game.html#a4cf3a4437279419c7c6da1a61276d64b) {     [Running](class_tale_worlds_1_1_core_1_1_game.html#a4cf3a4437279419c7c6da1a61276d64ba5bda814c4aedb126839228f1a3d92f09) ,     [Destroying](class_tale_worlds_1_1_core_1_1_game.html#a4cf3a4437279419c7c6da1a61276d64ba6971046981f88714217f40ee281d2d5b) ,     [Destroyed](class_tale_worlds_1_1_core_1_1_game.html#a4cf3a4437279419c7c6da1a61276d64baaefbd0597f1bc2493bbc18898243513b)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| T | [AddGameModelsManager< T >](class_tale_worlds_1_1_core_1_1_game.html#abf3ca3cd291dd1869df680ec34f266a0) (IEnumerable< [GameModel](class_tale_worlds_1_1_core_1_1_game_model.html) > inputComponents) |
| [IBannerVisual](interface_tale_worlds_1_1_core_1_1_i_banner_visual.html) | [CreateBannerVisual](class_tale_worlds_1_1_core_1_1_game.html#a868e31e1b2a0e3bc3ea6e421a56b8f06) ([Banner](class_tale_worlds_1_1_core_1_1_banner.html) banner) |
| [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) | [GetDefaultEquipmentWithName](class_tale_worlds_1_1_core_1_1_game.html#a2eb637e719e3790414d7d1e852a1c67f) (string equipmentName) |
| void | [SetDefaultEquipments](class_tale_worlds_1_1_core_1_1_game.html#a2ef18bd5c781aaabce2206555d2351ac) (IReadOnlyDictionary< string, [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) > defaultEquipments) |
| void | [Save](class_tale_worlds_1_1_core_1_1_game.html#a1bbcbf180f6a03c776f0bececa06c919) (MetaData metaData, string saveName, ISaveDriver driver, Action< [SaveResult](namespace_tale_worlds_1_1_library.html#a1fede41b93a35a4b6f9d87fcab58a5bc) > onSaveCompleted) |
| void | [Destroy](class_tale_worlds_1_1_core_1_1_game.html#ad1b1f106d014c4dae7f8510172078fa7) () |
| void | [CreateGameManager](class_tale_worlds_1_1_core_1_1_game.html#a7b208c847e1a2de1ee019592ff147368) () |
| void | [OnStateChanged](class_tale_worlds_1_1_core_1_1_game.html#abe7769162616e8dd3d7044a677fab252) ([GameState](class_tale_worlds_1_1_core_1_1_game_state.html) oldState) |
| T | [AddGameHandler< T >](class_tale_worlds_1_1_core_1_1_game.html#aa7e1cf08b7f11e78cbe64d4f5f919e34) () |
| T | [GetGameHandler< T >](class_tale_worlds_1_1_core_1_1_game.html#a50f72d63b6cb8df56a3f1edae45529a5) () |
| void | [RemoveGameHandler< T >](class_tale_worlds_1_1_core_1_1_game.html#acfd21164aebb46e93537db96a23432a0) () |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_game.html#a9ca2e292e6b38e170b71d124c0db5601) () |
| void | [SetBasicModels](class_tale_worlds_1_1_core_1_1_game.html#a6ff82facc43789b54e47ccd171dbc6e0) (IEnumerable< [GameModel](class_tale_worlds_1_1_core_1_1_game_model.html) > models) |
| void | [OnGameStart](class_tale_worlds_1_1_core_1_1_game.html#a9877522c8bc4a2edce4722e91303a951) () |
| bool | [DoLoading](class_tale_worlds_1_1_core_1_1_game.html#a87ab1f3f36368c646df2613d183e4638) () |
| void | [OnMissionIsStarting](class_tale_worlds_1_1_core_1_1_game.html#aeef2b8f6853a16001d8d97586ada65af) (string missionName, [MissionInitializerRecord](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html) rec) |
| void | [OnFinalize](class_tale_worlds_1_1_core_1_1_game.html#afafdc8b1d21d576249f87154a916ce40) () |
| void | [InitializeDefaultGameObjects](class_tale_worlds_1_1_core_1_1_game.html#ab4ff4d157b4d2763630182c4cc2a910a) () |
| void | [LoadBasicFiles](class_tale_worlds_1_1_core_1_1_game.html#a600b70109c5fcac610d1608fd39fa630) () |
| void | [ItemObjectDeserialized](class_tale_worlds_1_1_core_1_1_game.html#abbac8390c26b2a71a66f54464a7d1e51) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) itemObject) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static Game | [CreateGame](class_tale_worlds_1_1_core_1_1_game.html#af34c23f7f5877e01e52625462d958e73) ([GameType](class_tale_worlds_1_1_core_1_1_game.html#ac5f1278d13fbeabdd7e685e504de0dc9) gameType, [GameManagerBase](class_tale_worlds_1_1_core_1_1_game_manager_base.html) gameManager, int seed) |
| static Game | [CreateGame](class_tale_worlds_1_1_core_1_1_game.html#a8a3142f769254688f9876d78444b5dc3) ([GameType](class_tale_worlds_1_1_core_1_1_game.html#ac5f1278d13fbeabdd7e685e504de0dc9) gameType, [GameManagerBase](class_tale_worlds_1_1_core_1_1_game_manager_base.html) gameManager) |
| static Game | [LoadSaveGame](class_tale_worlds_1_1_core_1_1_game.html#a082dcda1943f5b82ca25ba6b9aae71e8) (LoadResult loadResult, [GameManagerBase](class_tale_worlds_1_1_core_1_1_game_manager_base.html) gameManager) |
| static void | [RegisterTypes](class_tale_worlds_1_1_core_1_1_game.html#a98ab72f9af22bdd3b938f70f69d2e2a9) ([GameType](class_tale_worlds_1_1_core_1_1_game.html#ac5f1278d13fbeabdd7e685e504de0dc9) gameType, [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, [GameManagerBase](class_tale_worlds_1_1_core_1_1_game_manager_base.html) gameManager) |

|  |  |
| --- | --- |
| Public Attributes | |
| Action< float > | [AfterTick](class_tale_worlds_1_1_core_1_1_game.html#a167bc6d0429dfe08dad8535feb8f60bf) |

|  |  |
| --- | --- |
| Properties | |
| [State](class_tale_worlds_1_1_core_1_1_game.html#a4cf3a4437279419c7c6da1a61276d64b) | [CurrentState](class_tale_worlds_1_1_core_1_1_game.html#aaf3ff5b67bb99b2b5492a13253849d32) = [State.Running](class_tale_worlds_1_1_core_1_1_game.html#a4cf3a4437279419c7c6da1a61276d64ba5bda814c4aedb126839228f1a3d92f09) `[get]` |
| [IMonsterMissionDataCreator](interface_tale_worlds_1_1_core_1_1_i_monster_mission_data_creator.html) | [MonsterMissionDataCreator](class_tale_worlds_1_1_core_1_1_game.html#aa69c7cdfca2db73a7fb21722681440e1) `[get, set]` |
| [Monster](class_tale_worlds_1_1_core_1_1_monster.html) | [DefaultMonster](class_tale_worlds_1_1_core_1_1_game.html#a3771667c7fed44c9268a6060ae1772d7) `[get]` |
| GameType | [GameType](class_tale_worlds_1_1_core_1_1_game.html#ac5f1278d13fbeabdd7e685e504de0dc9) `[get]` |
| DefaultSiegeEngineTypes | [DefaultSiegeEngineTypes](class_tale_worlds_1_1_core_1_1_game.html#a4ef3fb01c858d10f63b2b5b4e263f5bb) `[get]` |
| [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | [ObjectManager](class_tale_worlds_1_1_core_1_1_game.html#a23f470abada5a2ed2980f9884a41e8ae) `[get]` |
| [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | [PlayerTroop](class_tale_worlds_1_1_core_1_1_game.html#ae2b131a11ca1b337372789475957bc19) `[get, set]` |
| [BasicGameModels](class_tale_worlds_1_1_core_1_1_basic_game_models.html) | [BasicModels](class_tale_worlds_1_1_core_1_1_game.html#adb25101a9b2004ba083256336572297f) `[get]` |
| [GameManagerBase](class_tale_worlds_1_1_core_1_1_game_manager_base.html) | [GameManager](class_tale_worlds_1_1_core_1_1_game.html#aae0dbbb15dc914a4f04f9d6b119b2405) `[get]` |
| GameTextManager | [GameTextManager](class_tale_worlds_1_1_core_1_1_game.html#ac24a1ee69f4a818b86f4433d5310bf60) `[get]` |
| GameStateManager | [GameStateManager](class_tale_worlds_1_1_core_1_1_game.html#a82841b57b32b072fbbe0483a438d5e72) `[get]` |
| bool | [CheatMode](class_tale_worlds_1_1_core_1_1_game.html#aa52d760fff409ffc07b08e7f6924eb91) `[get]` |
| bool | [IsDevelopmentMode](class_tale_worlds_1_1_core_1_1_game.html#abc8dd46a83e3da0a7f498a135c63fef1) `[get]` |
| bool | [IsEditModeOn](class_tale_worlds_1_1_core_1_1_game.html#a3fd151088987b0d759d52af5d7482268) `[get]` |
| [UnitSpawnPrioritizations](namespace_tale_worlds_1_1_core.html#a175469225c40d109f12d59fffaafa604) | [UnitSpawnPrioritization](class_tale_worlds_1_1_core_1_1_game.html#a6d0fb08edb8b571b0f2826dfcca712c0) `[get]` |
| float | [ApplicationTime](class_tale_worlds_1_1_core_1_1_game.html#a11a8448944e6fdd85e1f9cd590a5f577) `[get]` |
| static Game | [Current](class_tale_worlds_1_1_core_1_1_game.html#a46166c7eb7a86aa6a0fdd20fc4840f6c) `[get]` |
| [IBannerVisualCreator](interface_tale_worlds_1_1_core_1_1_i_banner_visual_creator.html) | [BannerVisualCreator](class_tale_worlds_1_1_core_1_1_game.html#a514762491ab8bf24ea3ab614daa64c73) `[get, set]` |
| int | [NextUniqueTroopSeed](class_tale_worlds_1_1_core_1_1_game.html#a00f7c7c58d9ebb1a4fe1c724a1a5304f) `[get]` |
| DefaultCharacterAttributes | [DefaultCharacterAttributes](class_tale_worlds_1_1_core_1_1_game.html#a2d0a47e2737df7da330b9c46e749b3dd) `[get]` |
| DefaultSkills | [DefaultSkills](class_tale_worlds_1_1_core_1_1_game.html#abc904693fecde123d44d1d75503b24af) `[get]` |
| DefaultBannerEffects | [DefaultBannerEffects](class_tale_worlds_1_1_core_1_1_game.html#af97558a726ab18b5936f94436bffef29) `[get]` |
| DefaultItemCategories | [DefaultItemCategories](class_tale_worlds_1_1_core_1_1_game.html#a3e59a7892d9e2965840fbad13c796394) `[get]` |
| [TaleWorlds.Library.EventSystem.EventManager](class_tale_worlds_1_1_library_1_1_event_system_1_1_event_manager.html) | [EventManager](class_tale_worlds_1_1_core_1_1_game.html#a1e84afc74ad41bd0c9a056441b215f4c) `[get]` |

|  |  |
| --- | --- |
| Events | |
| static Action | [OnGameCreated](class_tale_worlds_1_1_core_1_1_game.html#a9352f33f6f436057224b3b635cfbbde9) |
| Action< [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) > | [OnItemDeserializedEvent](class_tale_worlds_1_1_core_1_1_game.html#a1ae525f9ebd79fe0d8d30de2a391fb2d) |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_core_1_1_game.html#a4cf3a4437279419c7c6da1a61276d64b)State
------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.Core.Game.State](class_tale_worlds_1_1_core_1_1_game.html#a4cf3a4437279419c7c6da1a61276d64b) |

| Enumerator | |
| --- | --- |
| Running |  |
| Destroying |  |
| Destroyed |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_game.html#abf3ca3cd291dd1869df680ec34f266a0)AddGameModelsManager< T >()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| T TaleWorlds.Core.Game.AddGameModelsManager< T > | ( | IEnumerable< [GameModel](class_tale_worlds_1_1_core_1_1_game_model.html) > | *inputComponents* | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[GameModelsManager](class_tale_worlds_1_1_core_1_1_game_models_manager.html)* |  |

[◆](class_tale_worlds_1_1_core_1_1_game.html#a868e31e1b2a0e3bc3ea6e421a56b8f06)CreateBannerVisual()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [IBannerVisual](interface_tale_worlds_1_1_core_1_1_i_banner_visual.html) TaleWorlds.Core.Game.CreateBannerVisual | ( | [Banner](class_tale_worlds_1_1_core_1_1_banner.html) | *banner* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_game.html#a2eb637e719e3790414d7d1e852a1c67f)GetDefaultEquipmentWithName()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) TaleWorlds.Core.Game.GetDefaultEquipmentWithName | ( | string | *equipmentName* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_game.html#a2ef18bd5c781aaabce2206555d2351ac)SetDefaultEquipments()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.Game.SetDefaultEquipments | ( | IReadOnlyDictionary< string, [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) > | *defaultEquipments* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_game.html#af34c23f7f5877e01e52625462d958e73)CreateGame() [1/2]
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | Game TaleWorlds.Core.Game.CreateGame | ( | [GameType](class_tale_worlds_1_1_core_1_1_game.html#ac5f1278d13fbeabdd7e685e504de0dc9) | *gameType*, | |  |  | [GameManagerBase](class_tale_worlds_1_1_core_1_1_game_manager_base.html) | *gameManager*, | |  |  | int | *seed* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_game.html#a8a3142f769254688f9876d78444b5dc3)CreateGame() [2/2]
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | Game TaleWorlds.Core.Game.CreateGame | ( | [GameType](class_tale_worlds_1_1_core_1_1_game.html#ac5f1278d13fbeabdd7e685e504de0dc9) | *gameType*, | |  |  | [GameManagerBase](class_tale_worlds_1_1_core_1_1_game_manager_base.html) | *gameManager* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_game.html#a082dcda1943f5b82ca25ba6b9aae71e8)LoadSaveGame()
---------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | Game TaleWorlds.Core.Game.LoadSaveGame | ( | LoadResult | *loadResult*, | |  |  | [GameManagerBase](class_tale_worlds_1_1_core_1_1_game_manager_base.html) | *gameManager* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_game.html#a1bbcbf180f6a03c776f0bececa06c919)Save()
-------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.Game.Save | ( | MetaData | *metaData*, |
|  |  | string | *saveName*, |
|  |  | ISaveDriver | *driver*, |
|  |  | Action< [SaveResult](namespace_tale_worlds_1_1_library.html#a1fede41b93a35a4b6f9d87fcab58a5bc) > | *onSaveCompleted* ) |

[◆](class_tale_worlds_1_1_core_1_1_game.html#ad1b1f106d014c4dae7f8510172078fa7)Destroy()
----------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.Game.Destroy | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_game.html#a7b208c847e1a2de1ee019592ff147368)CreateGameManager()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.Game.CreateGameManager | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_game.html#abe7769162616e8dd3d7044a677fab252)OnStateChanged()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.Game.OnStateChanged | ( | [GameState](class_tale_worlds_1_1_core_1_1_game_state.html) | *oldState* | ) |  |

Implements [TaleWorlds.Core.IGameStateManagerOwner](interface_tale_worlds_1_1_core_1_1_i_game_state_manager_owner.html#ae518df1910cf127208cf75db77b89ac7).

[◆](class_tale_worlds_1_1_core_1_1_game.html#aa7e1cf08b7f11e78cbe64d4f5f919e34)AddGameHandler< T >()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| T TaleWorlds.Core.Game.AddGameHandler< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[GameHandler](class_tale_worlds_1_1_core_1_1_game_handler.html)* |  |
    | *T* | : | *new()* |  |

[◆](class_tale_worlds_1_1_core_1_1_game.html#a50f72d63b6cb8df56a3f1edae45529a5)GetGameHandler< T >()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| T TaleWorlds.Core.Game.GetGameHandler< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[GameHandler](class_tale_worlds_1_1_core_1_1_game_handler.html)* |  |

[◆](class_tale_worlds_1_1_core_1_1_game.html#acfd21164aebb46e93537db96a23432a0)RemoveGameHandler< T >()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.Game.RemoveGameHandler< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[GameHandler](class_tale_worlds_1_1_core_1_1_game_handler.html)* |  |

[◆](class_tale_worlds_1_1_core_1_1_game.html#a9ca2e292e6b38e170b71d124c0db5601)Initialize()
-------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.Game.Initialize | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_game.html#a98ab72f9af22bdd3b938f70f69d2e2a9)RegisterTypes()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Core.Game.RegisterTypes | ( | [GameType](class_tale_worlds_1_1_core_1_1_game.html#ac5f1278d13fbeabdd7e685e504de0dc9) | *gameType*, | |  |  | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, | |  |  | [GameManagerBase](class_tale_worlds_1_1_core_1_1_game_manager_base.html) | *gameManager* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_game.html#a6ff82facc43789b54e47ccd171dbc6e0)SetBasicModels()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.Game.SetBasicModels | ( | IEnumerable< [GameModel](class_tale_worlds_1_1_core_1_1_game_model.html) > | *models* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_game.html#a9877522c8bc4a2edce4722e91303a951)OnGameStart()
--------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.Game.OnGameStart | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_game.html#a87ab1f3f36368c646df2613d183e4638)DoLoading()
------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Core.Game.DoLoading | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_game.html#aeef2b8f6853a16001d8d97586ada65af)OnMissionIsStarting()
----------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.Game.OnMissionIsStarting | ( | string | *missionName*, |
|  |  | [MissionInitializerRecord](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html) | *rec* ) |

[◆](class_tale_worlds_1_1_core_1_1_game.html#afafdc8b1d21d576249f87154a916ce40)OnFinalize()
-------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.Game.OnFinalize | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_game.html#ab4ff4d157b4d2763630182c4cc2a910a)InitializeDefaultGameObjects()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.Game.InitializeDefaultGameObjects | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_game.html#a600b70109c5fcac610d1608fd39fa630)LoadBasicFiles()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.Game.LoadBasicFiles | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_game.html#abbac8390c26b2a71a66f54464a7d1e51)ItemObjectDeserialized()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.Game.ItemObjectDeserialized | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *itemObject* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_core_1_1_game.html#a167bc6d0429dfe08dad8535feb8f60bf)AfterTick
----------------------------------------------------------------------------------------

|  |
| --- |
| Action<float> TaleWorlds.Core.Game.AfterTick |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_game.html#aaf3ff5b67bb99b2b5492a13253849d32)CurrentState
-------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [State](class_tale_worlds_1_1_core_1_1_game.html#a4cf3a4437279419c7c6da1a61276d64b) TaleWorlds.Core.Game.CurrentState = [State.Running](class_tale_worlds_1_1_core_1_1_game.html#a4cf3a4437279419c7c6da1a61276d64ba5bda814c4aedb126839228f1a3d92f09) | | get |

[◆](class_tale_worlds_1_1_core_1_1_game.html#aa69c7cdfca2db73a7fb21722681440e1)MonsterMissionDataCreator
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMonsterMissionDataCreator](interface_tale_worlds_1_1_core_1_1_i_monster_mission_data_creator.html) TaleWorlds.Core.Game.MonsterMissionDataCreator | | getset |

[◆](class_tale_worlds_1_1_core_1_1_game.html#a3771667c7fed44c9268a6060ae1772d7)DefaultMonster
---------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Monster](class_tale_worlds_1_1_core_1_1_monster.html) TaleWorlds.Core.Game.DefaultMonster | | get |

[◆](class_tale_worlds_1_1_core_1_1_game.html#ac5f1278d13fbeabdd7e685e504de0dc9)GameType
---------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | GameType TaleWorlds.Core.Game.GameType | | get |

[◆](class_tale_worlds_1_1_core_1_1_game.html#a4ef3fb01c858d10f63b2b5b4e263f5bb)DefaultSiegeEngineTypes
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | DefaultSiegeEngineTypes TaleWorlds.Core.Game.DefaultSiegeEngineTypes | | get |

[◆](class_tale_worlds_1_1_core_1_1_game.html#a23f470abada5a2ed2980f9884a41e8ae)ObjectManager
--------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) TaleWorlds.Core.Game.ObjectManager | | get |

[◆](class_tale_worlds_1_1_core_1_1_game.html#ae2b131a11ca1b337372789475957bc19)PlayerTroop
------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) TaleWorlds.Core.Game.PlayerTroop | | getset |

[◆](class_tale_worlds_1_1_core_1_1_game.html#adb25101a9b2004ba083256336572297f)BasicModels
------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicGameModels](class_tale_worlds_1_1_core_1_1_basic_game_models.html) TaleWorlds.Core.Game.BasicModels | | get |

[◆](class_tale_worlds_1_1_core_1_1_game.html#aae0dbbb15dc914a4f04f9d6b119b2405)GameManager
------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GameManagerBase](class_tale_worlds_1_1_core_1_1_game_manager_base.html) TaleWorlds.Core.Game.GameManager | | get |

[◆](class_tale_worlds_1_1_core_1_1_game.html#ac24a1ee69f4a818b86f4433d5310bf60)GameTextManager
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | GameTextManager TaleWorlds.Core.Game.GameTextManager | | get |

[◆](class_tale_worlds_1_1_core_1_1_game.html#a82841b57b32b072fbbe0483a438d5e72)GameStateManager
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | GameStateManager TaleWorlds.Core.Game.GameStateManager | | get |

[◆](class_tale_worlds_1_1_core_1_1_game.html#aa52d760fff409ffc07b08e7f6924eb91)CheatMode
----------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.Game.CheatMode | | get |

[◆](class_tale_worlds_1_1_core_1_1_game.html#abc8dd46a83e3da0a7f498a135c63fef1)IsDevelopmentMode
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.Game.IsDevelopmentMode | | get |

[◆](class_tale_worlds_1_1_core_1_1_game.html#a3fd151088987b0d759d52af5d7482268)IsEditModeOn
-------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.Game.IsEditModeOn | | get |

[◆](class_tale_worlds_1_1_core_1_1_game.html#a6d0fb08edb8b571b0f2826dfcca712c0)UnitSpawnPrioritization
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [UnitSpawnPrioritizations](namespace_tale_worlds_1_1_core.html#a175469225c40d109f12d59fffaafa604) TaleWorlds.Core.Game.UnitSpawnPrioritization | | get |

[◆](class_tale_worlds_1_1_core_1_1_game.html#a11a8448944e6fdd85e1f9cd590a5f577)ApplicationTime
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.Game.ApplicationTime | | get |

[◆](class_tale_worlds_1_1_core_1_1_game.html#a46166c7eb7a86aa6a0fdd20fc4840f6c)Current
--------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Game TaleWorlds.Core.Game.Current | | staticget |

[◆](class_tale_worlds_1_1_core_1_1_game.html#a514762491ab8bf24ea3ab614daa64c73)BannerVisualCreator
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IBannerVisualCreator](interface_tale_worlds_1_1_core_1_1_i_banner_visual_creator.html) TaleWorlds.Core.Game.BannerVisualCreator | | getset |

[◆](class_tale_worlds_1_1_core_1_1_game.html#a00f7c7c58d9ebb1a4fe1c724a1a5304f)NextUniqueTroopSeed
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.Game.NextUniqueTroopSeed | | get |

[◆](class_tale_worlds_1_1_core_1_1_game.html#a2d0a47e2737df7da330b9c46e749b3dd)DefaultCharacterAttributes
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | DefaultCharacterAttributes TaleWorlds.Core.Game.DefaultCharacterAttributes | | get |

[◆](class_tale_worlds_1_1_core_1_1_game.html#abc904693fecde123d44d1d75503b24af)DefaultSkills
--------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | DefaultSkills TaleWorlds.Core.Game.DefaultSkills | | get |

[◆](class_tale_worlds_1_1_core_1_1_game.html#af97558a726ab18b5936f94436bffef29)DefaultBannerEffects
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | DefaultBannerEffects TaleWorlds.Core.Game.DefaultBannerEffects | | get |

[◆](class_tale_worlds_1_1_core_1_1_game.html#a3e59a7892d9e2965840fbad13c796394)DefaultItemCategories
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | DefaultItemCategories TaleWorlds.Core.Game.DefaultItemCategories | | get |

[◆](class_tale_worlds_1_1_core_1_1_game.html#a1e84afc74ad41bd0c9a056441b215f4c)EventManager
-------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TaleWorlds.Library.EventSystem.EventManager](class_tale_worlds_1_1_library_1_1_event_system_1_1_event_manager.html) TaleWorlds.Core.Game.EventManager | | get |

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_core_1_1_game.html#a9352f33f6f436057224b3b635cfbbde9)OnGameCreated
--------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action TaleWorlds.Core.Game.OnGameCreated | | static |

[◆](class_tale_worlds_1_1_core_1_1_game.html#a1ae525f9ebd79fe0d8d30de2a391fb2d)OnItemDeserializedEvent
------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html)> TaleWorlds.Core.Game.OnItemDeserializedEvent |

