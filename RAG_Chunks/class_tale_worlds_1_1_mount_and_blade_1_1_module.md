--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_module.html ---

TaleWorlds.MountAndBlade.Module Class ReferencesealedInherits DotNetObject, and [TaleWorlds.Core.IGameStateManagerOwner](interface_tale_worlds_1_1_core_1_1_i_game_state_manager_owner.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [XmlInformationType](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a3f365e5bf87bb75a810a1fa0b53eb682) {     [Parameters](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a3f365e5bf87bb75a810a1fa0b53eb682a3225a10b07f1580f10dee4abc3779e6c) ,     [MbObjectType](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a3f365e5bf87bb75a810a1fa0b53eb682aeeea7504d7e8dc1939522a300a06634a)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| MBReadOnlyList< [MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html) > | [CollectSubModules](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a422764898b6a03f5cbd214f5cd2a8ad5) () |
| void | [SetInitialModuleScreenAsRootScreen](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a69189038b685df34861b1b86353d7a88) () |
| Type | [GetSubModuleType](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a12867643c46e00b7fda56b6b47928932) (string name) |
| bool | [CheckIfSubmoduleCanBeLoadable](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a9c7ae3c1ccb4c161eaa71edd9d2b5d1d) ([SubModuleInfo](class_tale_worlds_1_1_module_manager_1_1_sub_module_info.html) subModuleInfo) |
| void | [ClearStateOptions](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a7f056ef2627bf3295e173ba13e72fb3a) () |
| void | [AddInitialStateOption](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a4a335baca03f15c2fc00d399976c4bee) ([InitialStateOption](class_tale_worlds_1_1_mount_and_blade_1_1_initial_state_option.html) initialStateOption) |
| void | [OverrideInitialStateOption](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a580745bbff37b351533a8799a9b59224) (string id, [InitialStateOption](class_tale_worlds_1_1_mount_and_blade_1_1_initial_state_option.html) newInitialStateOption) |
| IEnumerable< [InitialStateOption](class_tale_worlds_1_1_mount_and_blade_1_1_initial_state_option.html) > | [GetInitialStateOptions](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a66a604d4b20314009347ff2cab89a3c7) () |
| [InitialStateOption](class_tale_worlds_1_1_mount_and_blade_1_1_initial_state_option.html) | [GetInitialStateOptionWithId](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a6e3180516e89e924d6ad9b89b40d30d4) (string id) |
| void | [ExecuteInitialStateOptionWithId](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a4a9d90a5e7cb877fe911a842f5547181) (string id) |
| void | [SetCanLoadModules](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a9058b5735bd9f25ca9e5ce17532e1ede) (bool canLoadModules) |
| void | [SetEditorMissionTester](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#abdc31650c0cf52317c436ef50c1c57ad) ([IEditorMissionTester](interface_tale_worlds_1_1_mount_and_blade_1_1_i_editor_mission_tester.html) editorMissionTester) |
| void | [StartMissionForEditorAux](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a0401589cd6783cc37c9fc6cd2654b319) (string missionName, string sceneName, string levels, bool forReplay, string replayFileName, bool isRecord) |
| [MultiplayerGameMode](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_game_mode.html) | [GetMultiplayerGameMode](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a3c9a6d620b307283b55f127529a72bef) (string gameType) |
| void | [AddMultiplayerGameMode](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a1c10f07f213b96262321ce093cc4acf1) ([MultiplayerGameMode](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_game_mode.html) multiplayerGameMode) |
| MBReadOnlyList< [MultiplayerGameTypeInfo](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_game_type_info.html) > | [GetMultiplayerGameTypes](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a2f57036d0db43718d60db66b265ca6f0) () |
| bool | [StartMultiplayerGame](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#ae9553912535175385c2bde57badd1def) (string multiplayerGameType, string scene) |
| async void | [ShutDownWithDelay](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a28696a0e6099cd626ef6748199d17807) (string reason, int seconds) |
| void | [DeactiveModule](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a63f7156c29d5ce956b9e8eb97f1c0c1a) (string moduleId) |
| void | [ActivateModule](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#af0187823605246b4576c346125a7578c) (string moduleId) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [GetMetaMeshPackageMapping](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a7fd6989934ac4ef26f30789309db7083) (Dictionary< string, string > metaMeshPackageMappings) |
| static void | [GetItemMeshNames](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a009de22afa3cb3151242e19aefa47df9) (HashSet< string > itemMeshNames) |
| static string | [GetCraftedItemMeshNames](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a670561e7e751327023b98d930183ae77) (List< string > arguments) |

|  |  |
| --- | --- |
| Properties | |
| static Module | [CurrentModule](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a1daa981c05fe7f8c2c6cafae2e6bced3) `[get]` |
| [GameStateManager](class_tale_worlds_1_1_core_1_1_game_state_manager.html) | [GlobalGameStateManager](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a442fdd07a5c1591a0890ca0a851bc50c) `[get]` |
| bool | [MultiplayerRequested](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a2eb9ada11751ee90ae34990cbcdbd325) `[get]` |
| bool | [ReturnToEditorState](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a604d10b001356add9b082f571be2449a) `[get]` |
| bool | [LoadingFinished](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a975d0ac835febd91b76d91c1fd866bcc) `[get]` |
| [GameTextManager](class_tale_worlds_1_1_core_1_1_game_text_manager.html) | [GlobalTextManager](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a304fdcc0d000aae1e3a2ad3920adb029) `[get]` |
| bool | [IsOnlyCoreContentEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#abb684f2991f46888d43d8a46f96e117f) `[get]` |
| JobManager | [JobManager](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a463426361d6fd46534c2ffdaf28f6ae3) `[get]` |
| [GameStartupInfo](class_tale_worlds_1_1_mount_and_blade_1_1_game_startup_info.html) | [StartupInfo](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a2e6656b0e8765c7ae1742587e69e4c03) `[get]` |

|  |  |
| --- | --- |
| Events | |
| Action | [SkinsXMLHasChanged](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a8e1fb6626537aa0f8a6d0b0199aedd1d) |
| Action | [ImguiProfilerTick](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#ae6c8f7190ea8d2350e79099f5e6e0e6a) |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a3f365e5bf87bb75a810a1fa0b53eb682)XmlInformationType
--------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.Module.XmlInformationType](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a3f365e5bf87bb75a810a1fa0b53eb682) |

| Enumerator | |
| --- | --- |
| Parameters |  |
| MbObjectType |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a422764898b6a03f5cbd214f5cd2a8ad5)CollectSubModules()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| MBReadOnlyList< [MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html) > TaleWorlds.MountAndBlade.Module.CollectSubModules | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a7fd6989934ac4ef26f30789309db7083)GetMetaMeshPackageMapping()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.Module.GetMetaMeshPackageMapping | ( | Dictionary< string, string > | *metaMeshPackageMappings* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a009de22afa3cb3151242e19aefa47df9)GetItemMeshNames()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.Module.GetItemMeshNames | ( | HashSet< string > | *itemMeshNames* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a670561e7e751327023b98d930183ae77)GetCraftedItemMeshNames()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.Module.GetCraftedItemMeshNames | ( | List< string > | *arguments* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a69189038b685df34861b1b86353d7a88)SetInitialModuleScreenAsRootScreen()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Module.SetInitialModuleScreenAsRootScreen | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a12867643c46e00b7fda56b6b47928932)GetSubModuleType()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| Type TaleWorlds.MountAndBlade.Module.GetSubModuleType | ( | string | *name* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a9c7ae3c1ccb4c161eaa71edd9d2b5d1d)CheckIfSubmoduleCanBeLoadable()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Module.CheckIfSubmoduleCanBeLoadable | ( | [SubModuleInfo](class_tale_worlds_1_1_module_manager_1_1_sub_module_info.html) | *subModuleInfo* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a7f056ef2627bf3295e173ba13e72fb3a)ClearStateOptions()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Module.ClearStateOptions | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a4a335baca03f15c2fc00d399976c4bee)AddInitialStateOption()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Module.AddInitialStateOption | ( | [InitialStateOption](class_tale_worlds_1_1_mount_and_blade_1_1_initial_state_option.html) | *initialStateOption* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a580745bbff37b351533a8799a9b59224)OverrideInitialStateOption()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Module.OverrideInitialStateOption | ( | string | *id*, |
|  |  | [InitialStateOption](class_tale_worlds_1_1_mount_and_blade_1_1_initial_state_option.html) | *newInitialStateOption* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a66a604d4b20314009347ff2cab89a3c7)GetInitialStateOptions()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< [InitialStateOption](class_tale_worlds_1_1_mount_and_blade_1_1_initial_state_option.html) > TaleWorlds.MountAndBlade.Module.GetInitialStateOptions | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a6e3180516e89e924d6ad9b89b40d30d4)GetInitialStateOptionWithId()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [InitialStateOption](class_tale_worlds_1_1_mount_and_blade_1_1_initial_state_option.html) TaleWorlds.MountAndBlade.Module.GetInitialStateOptionWithId | ( | string | *id* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a4a9d90a5e7cb877fe911a842f5547181)ExecuteInitialStateOptionWithId()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Module.ExecuteInitialStateOptionWithId | ( | string | *id* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a9058b5735bd9f25ca9e5ce17532e1ede)SetCanLoadModules()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Module.SetCanLoadModules | ( | bool | *canLoadModules* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#abdc31650c0cf52317c436ef50c1c57ad)SetEditorMissionTester()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Module.SetEditorMissionTester | ( | [IEditorMissionTester](interface_tale_worlds_1_1_mount_and_blade_1_1_i_editor_mission_tester.html) | *editorMissionTester* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a0401589cd6783cc37c9fc6cd2654b319)StartMissionForEditorAux()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Module.StartMissionForEditorAux | ( | string | *missionName*, |
|  |  | string | *sceneName*, |
|  |  | string | *levels*, |
|  |  | bool | *forReplay*, |
|  |  | string | *replayFileName*, |
|  |  | bool | *isRecord* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a3c9a6d620b307283b55f127529a72bef)GetMultiplayerGameMode()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [MultiplayerGameMode](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_game_mode.html) TaleWorlds.MountAndBlade.Module.GetMultiplayerGameMode | ( | string | *gameType* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a1c10f07f213b96262321ce093cc4acf1)AddMultiplayerGameMode()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Module.AddMultiplayerGameMode | ( | [MultiplayerGameMode](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_game_mode.html) | *multiplayerGameMode* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a2f57036d0db43718d60db66b265ca6f0)GetMultiplayerGameTypes()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| MBReadOnlyList< [MultiplayerGameTypeInfo](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_game_type_info.html) > TaleWorlds.MountAndBlade.Module.GetMultiplayerGameTypes | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#ae9553912535175385c2bde57badd1def)StartMultiplayerGame()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Module.StartMultiplayerGame | ( | string | *multiplayerGameType*, |
|  |  | string | *scene* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a28696a0e6099cd626ef6748199d17807)ShutDownWithDelay()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| async void TaleWorlds.MountAndBlade.Module.ShutDownWithDelay | ( | string | *reason*, |
|  |  | int | *seconds* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a63f7156c29d5ce956b9e8eb97f1c0c1a)DeactiveModule()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Module.DeactiveModule | ( | string | *moduleId* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#af0187823605246b4576c346125a7578c)ActivateModule()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Module.ActivateModule | ( | string | *moduleId* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a1daa981c05fe7f8c2c6cafae2e6bced3)CurrentModule
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Module TaleWorlds.MountAndBlade.Module.CurrentModule | | staticget |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a442fdd07a5c1591a0890ca0a851bc50c)GlobalGameStateManager
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GameStateManager](class_tale_worlds_1_1_core_1_1_game_state_manager.html) TaleWorlds.MountAndBlade.Module.GlobalGameStateManager | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a2eb9ada11751ee90ae34990cbcdbd325)MultiplayerRequested
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Module.MultiplayerRequested | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a604d10b001356add9b082f571be2449a)ReturnToEditorState
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Module.ReturnToEditorState | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a975d0ac835febd91b76d91c1fd866bcc)LoadingFinished
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Module.LoadingFinished | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a304fdcc0d000aae1e3a2ad3920adb029)GlobalTextManager
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GameTextManager](class_tale_worlds_1_1_core_1_1_game_text_manager.html) TaleWorlds.MountAndBlade.Module.GlobalTextManager | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#abb684f2991f46888d43d8a46f96e117f)IsOnlyCoreContentEnabled
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Module.IsOnlyCoreContentEnabled | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a463426361d6fd46534c2ffdaf28f6ae3)JobManager
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | JobManager TaleWorlds.MountAndBlade.Module.JobManager | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a2e6656b0e8765c7ae1742587e69e4c03)StartupInfo
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GameStartupInfo](class_tale_worlds_1_1_mount_and_blade_1_1_game_startup_info.html) TaleWorlds.MountAndBlade.Module.StartupInfo | | get |

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#a8e1fb6626537aa0f8a6d0b0199aedd1d)SkinsXMLHasChanged
--------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action TaleWorlds.MountAndBlade.Module.SkinsXMLHasChanged |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_module.html#ae6c8f7190ea8d2350e79099f5e6e0e6a)ImguiProfilerTick
-------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action TaleWorlds.MountAndBlade.Module.ImguiProfilerTick |

