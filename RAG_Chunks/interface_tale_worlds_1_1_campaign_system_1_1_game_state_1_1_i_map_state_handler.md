--- SOURCE: interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html ---

TaleWorlds.CampaignSystem.GameState.IMapStateHandler Interface ReferenceInherited by [SandBox.View.Map.MapScreen](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [OnRefreshState](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#a9549b5f47ada50acc0a8b223e1807429) () |
| void | [OnMainPartyEncounter](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#a0f2f31a63376fc269565565016d846a0) () |
| void | [OnIncidentStarted](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#a262fe9020f555dd66fe7c6585eb37e1e) ([Incident](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html) incident) |
| void | [BeforeTick](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#a3b4be82d0ba34946f9674ebe58a8db14) (float dt) |
| void | [Tick](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#acd3e8bed164f6e378a2b83414e983be3) (float dt) |
| void | [AfterTick](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#a4d1f9776fd87be4cd9bc06ed07561bfe) (float dt) |
| void | [AfterWaitTick](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#abfa0a3f9ac27411c7bcb656df4fca3b9) (float dt) |
| void | [OnIdleTick](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#ad889a762a1e99157b903cdd3b3f7a182) (float dt) |
| void | [OnSignalPeriodicEvents](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#aae3c3819fb032d18590e0f692a50c951) () |
| void | [OnExit](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#a22b6bea6dbc2b4ea3bbb07b114c90a6e) () |
| void | [ResetCamera](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#a07ea89baa9f0b82d361cc9cc5bf7eef1) (bool resetDistance, bool teleportToMainParty) |
| void | [TeleportCameraToMainParty](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#a1a23d7759de0dac94eed4ba534ca5574) () |
| void | [FastMoveCameraToMainParty](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#a9bbebde55503e8225a828da68fd23388) () |
| bool | [IsCameraLockedToPlayerParty](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#a0de4e1c6b4657c91a320e2410f49c8aa) () |
| void | [StartCameraAnimation](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#a8e4d64c2c7b23c8272613a8b8c78fa1e) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) targetPosition, float animationStopDuration) |
| void | [OnHourlyTick](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#ae5039a32bb1a20760e4051da25fa4427) () |
| void | [OnMenuModeTick](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#abd83c99e47f9a11f71583feb13455b32) (float dt) |
| void | [OnEnteringMenuMode](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#a17f2439eb31cfd827c0f1795edbe5d72) ([MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) menuContext) |
| void | [OnExitingMenuMode](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#a579222c7ffe9bff3ebed9265f9476455) () |
| void | [OnBattleSimulationStarted](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#a8a257c8a79a859869bac4fcf3f255bc0) ([BattleSimulation](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html) battleSimulation) |
| void | [OnBattleSimulationEnded](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#ad46f70fbc8ba06fef0422f67e81dd54c) () |
| void | [OnGameplayCheatsEnabled](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#af3dcef68412b9676806475d283bffd57) () |
| void | [OnMapConversationStarts](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#ace9dcd4435f0ee70767d2e7e50844d8f) ([ConversationCharacterData](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html) playerCharacterData, [ConversationCharacterData](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html) conversationPartnerData) |
| void | [OnMapConversationOver](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#ab23ac33ca5d20d255e28ab9bf5382fae) () |
| void | [OnPlayerSiegeActivated](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#a3bd22e35d48c93a9ca69173c1fff7411) () |
| void | [OnPlayerSiegeDeactivated](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#ace6aea538275bf4b2ed168aa5d485f31) () |
| void | [OnSiegeEngineClick](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#a0024f4a36c9d5f4c0b56b0321316cb4c) ([MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) siegeEngineFrame) |
| void | [OnGameLoadFinished](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#a7c977451fea38841609926b0f541c79f) () |
| void | [OnFadeInAndOut](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#a4ebc3308c5717b092f2ff177f5d412fe) (float fadeOutTime, float blackTime, float fadeInTime) |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#a9549b5f47ada50acc0a8b223e1807429)OnRefreshState()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.IMapStateHandler.OnRefreshState | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#a0f2f31a63376fc269565565016d846a0)OnMainPartyEncounter()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.IMapStateHandler.OnMainPartyEncounter | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#a262fe9020f555dd66fe7c6585eb37e1e)OnIncidentStarted()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.IMapStateHandler.OnIncidentStarted | ( | [Incident](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html) | *incident* | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#a3b4be82d0ba34946f9674ebe58a8db14)BeforeTick()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.IMapStateHandler.BeforeTick | ( | float | *dt* | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#acd3e8bed164f6e378a2b83414e983be3)Tick()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.IMapStateHandler.Tick | ( | float | *dt* | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#a4d1f9776fd87be4cd9bc06ed07561bfe)AfterTick()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.IMapStateHandler.AfterTick | ( | float | *dt* | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#abfa0a3f9ac27411c7bcb656df4fca3b9)AfterWaitTick()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.IMapStateHandler.AfterWaitTick | ( | float | *dt* | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#ad889a762a1e99157b903cdd3b3f7a182)OnIdleTick()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.IMapStateHandler.OnIdleTick | ( | float | *dt* | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#aae3c3819fb032d18590e0f692a50c951)OnSignalPeriodicEvents()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.IMapStateHandler.OnSignalPeriodicEvents | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#a22b6bea6dbc2b4ea3bbb07b114c90a6e)OnExit()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.IMapStateHandler.OnExit | ( |  | ) |  |

Implemented in [SandBox.View.Map.MapScreen](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a500c4aabce041edd365897e5fdb18df7).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#a07ea89baa9f0b82d361cc9cc5bf7eef1)ResetCamera()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.IMapStateHandler.ResetCamera | ( | bool | *resetDistance*, |
|  |  | bool | *teleportToMainParty* ) |

Implemented in [SandBox.View.Map.MapScreen](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a468c3d838cdfba79f3441db148c98feb).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#a1a23d7759de0dac94eed4ba534ca5574)TeleportCameraToMainParty()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.IMapStateHandler.TeleportCameraToMainParty | ( |  | ) |  |

Implemented in [SandBox.View.Map.MapScreen](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a9920557f7b12ef91c260733e912c338b).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#a9bbebde55503e8225a828da68fd23388)FastMoveCameraToMainParty()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.IMapStateHandler.FastMoveCameraToMainParty | ( |  | ) |  |

Implemented in [SandBox.View.Map.MapScreen](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#ab824194cbaaf0de3c93dfddd59d06f7c).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#a0de4e1c6b4657c91a320e2410f49c8aa)IsCameraLockedToPlayerParty()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.GameState.IMapStateHandler.IsCameraLockedToPlayerParty | ( |  | ) |  |

Implemented in [SandBox.View.Map.MapScreen](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a814680010cf75a96ef7a0216baf2dad0).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#a8e4d64c2c7b23c8272613a8b8c78fa1e)StartCameraAnimation()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.IMapStateHandler.StartCameraAnimation | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *targetPosition*, |
|  |  | float | *animationStopDuration* ) |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#ae5039a32bb1a20760e4051da25fa4427)OnHourlyTick()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.IMapStateHandler.OnHourlyTick | ( |  | ) |  |

Implemented in [SandBox.View.Map.MapScreen](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a710f2f861c6ea590ab5052587b03c308).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#abd83c99e47f9a11f71583feb13455b32)OnMenuModeTick()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.IMapStateHandler.OnMenuModeTick | ( | float | *dt* | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#a17f2439eb31cfd827c0f1795edbe5d72)OnEnteringMenuMode()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.IMapStateHandler.OnEnteringMenuMode | ( | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) | *menuContext* | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#a579222c7ffe9bff3ebed9265f9476455)OnExitingMenuMode()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.IMapStateHandler.OnExitingMenuMode | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#a8a257c8a79a859869bac4fcf3f255bc0)OnBattleSimulationStarted()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.IMapStateHandler.OnBattleSimulationStarted | ( | [BattleSimulation](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html) | *battleSimulation* | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#ad46f70fbc8ba06fef0422f67e81dd54c)OnBattleSimulationEnded()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.IMapStateHandler.OnBattleSimulationEnded | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#af3dcef68412b9676806475d283bffd57)OnGameplayCheatsEnabled()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.IMapStateHandler.OnGameplayCheatsEnabled | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#ace9dcd4435f0ee70767d2e7e50844d8f)OnMapConversationStarts()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.IMapStateHandler.OnMapConversationStarts | ( | [ConversationCharacterData](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html) | *playerCharacterData*, |
|  |  | [ConversationCharacterData](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html) | *conversationPartnerData* ) |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#ab23ac33ca5d20d255e28ab9bf5382fae)OnMapConversationOver()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.IMapStateHandler.OnMapConversationOver | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#a3bd22e35d48c93a9ca69173c1fff7411)OnPlayerSiegeActivated()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.IMapStateHandler.OnPlayerSiegeActivated | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#ace6aea538275bf4b2ed168aa5d485f31)OnPlayerSiegeDeactivated()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.IMapStateHandler.OnPlayerSiegeDeactivated | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#a0024f4a36c9d5f4c0b56b0321316cb4c)OnSiegeEngineClick()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.IMapStateHandler.OnSiegeEngineClick | ( | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *siegeEngineFrame* | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#a7c977451fea38841609926b0f541c79f)OnGameLoadFinished()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.IMapStateHandler.OnGameLoadFinished | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#a4ebc3308c5717b092f2ff177f5d412fe)OnFadeInAndOut()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.IMapStateHandler.OnFadeInAndOut | ( | float | *fadeOutTime*, |
|  |  | float | *blackTime*, |
|  |  | float | *fadeInTime* ) |

Implemented in [SandBox.View.Map.MapScreen](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a7f420949e57793e7d5536483d52ae1c0).

