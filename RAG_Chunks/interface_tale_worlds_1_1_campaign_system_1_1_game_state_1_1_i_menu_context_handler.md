--- SOURCE: interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_menu_context_handler.html ---

TaleWorlds.CampaignSystem.GameState.IMenuContextHandler Interface ReferenceInherited by [SandBox.View.Menu.MenuViewContext](class_sand_box_1_1_view_1_1_menu_1_1_menu_view_context.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [OnBackgroundMeshNameSet](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_menu_context_handler.html#a0c3e1cd4140394b8f829283419aa9552) (string name) |
| void | [OnOpenTownManagement](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_menu_context_handler.html#aa7bd9f18b66738b8bab0860bd690844e) () |
| void | [OnOpenRecruitVolunteers](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_menu_context_handler.html#ab348fb2fb9fcdd9e2b150bfde2b6484d) () |
| void | [OnOpenTournamentLeaderboard](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_menu_context_handler.html#ad44417f5fee0b8b47ad1e66ff34f8752) () |
| void | [OnOpenTroopSelection](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_menu_context_handler.html#a1ed0e43fe44bf42db5cfb9bb0337884c) ([TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) fullRoster, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) initialSelections, Func< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), bool > canChangeStatusOfTroop, Action< [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) > onDone, int maxSelectableTroopCount, int minSelectableTroopCount) |
| void | [OnMenuCreate](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_menu_context_handler.html#ae4068789029678f82b723b876f33e628) () |
| void | [OnMenuActivate](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_menu_context_handler.html#a30974fdc2978e6727c89f39209ad6299) () |
| void | [OnMenuRefresh](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_menu_context_handler.html#a457df8c7ffcc1f40af9f3e6441456723) () |
| void | [OnHourlyTick](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_menu_context_handler.html#a1652cdb9001fc39d67e1c95c97332827) () |
| void | [OnPanelSoundIDSet](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_menu_context_handler.html#a50cc6cf647e972d29ac26ceaaaf89d57) (string panelSoundID) |
| void | [OnAmbientSoundIDSet](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_menu_context_handler.html#ac8cd9b07e65bc9b5f34e515379c555e7) (string ambientSoundID) |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_menu_context_handler.html#a0c3e1cd4140394b8f829283419aa9552)OnBackgroundMeshNameSet()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.IMenuContextHandler.OnBackgroundMeshNameSet | ( | string | *name* | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_menu_context_handler.html#aa7bd9f18b66738b8bab0860bd690844e)OnOpenTownManagement()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.IMenuContextHandler.OnOpenTownManagement | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_menu_context_handler.html#ab348fb2fb9fcdd9e2b150bfde2b6484d)OnOpenRecruitVolunteers()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.IMenuContextHandler.OnOpenRecruitVolunteers | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_menu_context_handler.html#ad44417f5fee0b8b47ad1e66ff34f8752)OnOpenTournamentLeaderboard()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.IMenuContextHandler.OnOpenTournamentLeaderboard | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_menu_context_handler.html#a1ed0e43fe44bf42db5cfb9bb0337884c)OnOpenTroopSelection()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.IMenuContextHandler.OnOpenTroopSelection | ( | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *fullRoster*, |
|  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *initialSelections*, |
|  |  | Func< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), bool > | *canChangeStatusOfTroop*, |
|  |  | Action< [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) > | *onDone*, |
|  |  | int | *maxSelectableTroopCount*, |
|  |  | int | *minSelectableTroopCount* ) |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_menu_context_handler.html#ae4068789029678f82b723b876f33e628)OnMenuCreate()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.IMenuContextHandler.OnMenuCreate | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_menu_context_handler.html#a30974fdc2978e6727c89f39209ad6299)OnMenuActivate()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.IMenuContextHandler.OnMenuActivate | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_menu_context_handler.html#a457df8c7ffcc1f40af9f3e6441456723)OnMenuRefresh()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.IMenuContextHandler.OnMenuRefresh | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_menu_context_handler.html#a1652cdb9001fc39d67e1c95c97332827)OnHourlyTick()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.IMenuContextHandler.OnHourlyTick | ( |  | ) |  |

Implemented in [SandBox.View.Menu.MenuViewContext](class_sand_box_1_1_view_1_1_menu_1_1_menu_view_context.html#a87eb5c3ce2e666d106b2bbc4211ae9bf).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_menu_context_handler.html#a50cc6cf647e972d29ac26ceaaaf89d57)OnPanelSoundIDSet()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.IMenuContextHandler.OnPanelSoundIDSet | ( | string | *panelSoundID* | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_menu_context_handler.html#ac8cd9b07e65bc9b5f34e515379c555e7)OnAmbientSoundIDSet()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.IMenuContextHandler.OnAmbientSoundIDSet | ( | string | *ambientSoundID* | ) |  |

