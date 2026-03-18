--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_callback_manager.html ---

TaleWorlds.CampaignSystem.GameMenus.GameMenuCallbackManager Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [GameMenuCallbackManager](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_callback_manager.html#ac6c12cabc040b7173e04dbed3d3dce2e) () |
| void | [OnGameLoad](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_callback_manager.html#a5ca18856063f3f39874c38731ddf0f0b) () |
| void | [InitializeState](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_callback_manager.html#ad8eae19d728ee82127ff692d4b82a956) (string menuId, [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) state) |
| void | [OnConsequence](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_callback_manager.html#aab38d73fc8f250bea80ea7462b6605e1) (string menuId, [GameMenuOption](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html) gameMenuOption, [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) state) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetMenuOptionTooltip](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_callback_manager.html#aff861d8e93b03d459a099cd0d279cacf) ([MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) menuContext, int menuItemNumber) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetVirtualMenuOptionTooltip](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_callback_manager.html#a2628a2eaec3c5b0eef9265994a1e1acb) ([MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) menuContext, int virtualMenuItemIndex) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetVirtualMenuOptionText](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_callback_manager.html#aca5090148323d0973530cbd12d6094a3) ([MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) menuContext, int virtualMenuItemIndex) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetMenuOptionText](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_callback_manager.html#aa4928d2ff55a4b0f3af5ceb2788e477f) ([MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) menuContext, int menuItemNumber) |

|  |  |
| --- | --- |
| Properties | |
| static [GameMenuCallbackManager](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_callback_manager.html#ac6c12cabc040b7173e04dbed3d3dce2e) | [Instance](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_callback_manager.html#aacfebe06afc021840e482cdaa97c3302) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_callback_manager.html#ac6c12cabc040b7173e04dbed3d3dce2e)GameMenuCallbackManager()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.GameMenus.GameMenuCallbackManager.GameMenuCallbackManager | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_callback_manager.html#a5ca18856063f3f39874c38731ddf0f0b)OnGameLoad()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameMenus.GameMenuCallbackManager.OnGameLoad | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_callback_manager.html#ad8eae19d728ee82127ff692d4b82a956)InitializeState()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameMenus.GameMenuCallbackManager.InitializeState | ( | string | *menuId*, |
|  |  | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) | *state* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_callback_manager.html#aab38d73fc8f250bea80ea7462b6605e1)OnConsequence()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameMenus.GameMenuCallbackManager.OnConsequence | ( | string | *menuId*, |
|  |  | [GameMenuOption](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html) | *gameMenuOption*, |
|  |  | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) | *state* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_callback_manager.html#aff861d8e93b03d459a099cd0d279cacf)GetMenuOptionTooltip()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.GameMenus.GameMenuCallbackManager.GetMenuOptionTooltip | ( | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) | *menuContext*, |
|  |  | int | *menuItemNumber* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_callback_manager.html#a2628a2eaec3c5b0eef9265994a1e1acb)GetVirtualMenuOptionTooltip()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.GameMenus.GameMenuCallbackManager.GetVirtualMenuOptionTooltip | ( | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) | *menuContext*, |
|  |  | int | *virtualMenuItemIndex* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_callback_manager.html#aca5090148323d0973530cbd12d6094a3)GetVirtualMenuOptionText()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.GameMenus.GameMenuCallbackManager.GetVirtualMenuOptionText | ( | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) | *menuContext*, |
|  |  | int | *virtualMenuItemIndex* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_callback_manager.html#aa4928d2ff55a4b0f3af5ceb2788e477f)GetMenuOptionText()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.GameMenus.GameMenuCallbackManager.GetMenuOptionText | ( | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) | *menuContext*, |
|  |  | int | *menuItemNumber* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_callback_manager.html#aacfebe06afc021840e482cdaa97c3302)Instance
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GameMenuCallbackManager](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_callback_manager.html#ac6c12cabc040b7173e04dbed3d3dce2e) TaleWorlds.CampaignSystem.GameMenus.GameMenuCallbackManager.Instance | | staticget |

