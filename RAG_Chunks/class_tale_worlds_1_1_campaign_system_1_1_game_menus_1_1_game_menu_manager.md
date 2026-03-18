--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html ---

TaleWorlds.CampaignSystem.GameMenus.GameMenuManager Class ReferenceLayer class between [GameMenus](namespace_tale_worlds_1_1_campaign_system_1_1_game_menus.html) and [Game](class_tale_worlds_1_1_core_1_1_game.html) itself. Managing informations of [GameMenus](namespace_tale_worlds_1_1_campaign_system_1_1_game_menus.html) with functions. There is not any direct access to [GameMenus](namespace_tale_worlds_1_1_campaign_system_1_1_game_menus.html) for increasing stability.

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [GameMenuManager](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#ac16d6ebd4f55b79e563b6cc07cc65b18) () |
| void | [SetNextMenu](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#a4bcbeacdf752d545085a8c7c77e31c6e) (String name) |
| void | [ExitToLast](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#ad4baf5e739eb16a9f309bf60cd977762) () |
| void | [SetCurrentRepeatableIndex](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#acf83712eb59bf46c831feb5bc265693e) ([MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) menuContext, int index) |
| bool | [GetMenuOptionConditionsHold](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#a5bf35c12410786a1e9294b447788374b) ([MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) menuContext, int menuItemNumber) |
| void | [RefreshMenuOptions](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#abdc2122e18d7659189f8da31791df204) ([MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) menuContext) |
| void | [RefreshMenuOptionConditions](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#a7f371374ade9f60165c3f729ff33f043) ([MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) menuContext) |
| string | [GetMenuOptionIdString](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#a62ff2c542a219251a094a66cce913e42) ([MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) menuContext, int menuItemNumber) |
| void | [RunConsequencesOfMenuOption](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#af3202393e402b2edb62b1cc86012c68c) ([MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) menuContext, int menuItemNumber) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetVirtualMenuOptionTooltip](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#a9acd7a461bb952b7ddb17cec40fb57c9) ([MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) menuContext, int virtualMenuItemIndex) |
| [GameMenu.MenuOverlayType](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a105216128b909e180a28a34f96df0b78) | [GetMenuOverlayType](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#af2fe70f0d42699bd13e05334502aa36a) ([MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) menuContext) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetVirtualMenuOptionText](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#ab05fea59457cd8a8396895ac82902d88) ([MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) menuContext, int virtualMenuItemIndex) |
| [GameMenuOption](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html) | [GetVirtualGameMenuOption](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#a9439009157ad4418c4c36bec6fcfb5c0) ([MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) menuContext, int virtualMenuItemIndex) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetVirtualMenuOptionText2](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#a12d9d1079b4e806bc8e7e3104474c1d7) ([MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) menuContext, int virtualMenuItemIndex) |
| float | [GetVirtualMenuProgress](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#a8a3220f6546771191c1834dfa6e876e7) ([MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) menuContext) |
| [GameMenu.MenuAndOptionType](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a75a6de1769953ede245660ef2358933e) | [GetVirtualMenuAndOptionType](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#ad587ba697580ba98b1d7191651a40089) ([MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) menuContext) |
| bool | [GetVirtualMenuIsWaitActive](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#a59405da7ced2c27c82c4ff2fd150622b) ([MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) menuContext) |
| float | [GetVirtualMenuTargetWaitHours](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#a9d4ecb82be289164cd5a99692abd88b3) ([MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) menuContext) |
| bool | [GetVirtualMenuOptionIsEnabled](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#a71097c39671291a6228121634ae7b09d) ([MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) menuContext, int virtualMenuItemIndex) |
| int | [GetVirtualMenuOptionAmount](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#a3285d9fd804ad410d9bef6f03538a17e) ([MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) menuContext) |
| bool | [GetVirtualMenuOptionIsLeave](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#af8bd92115b2caf3b61f2e954db43bf1b) ([MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) menuContext, int virtualMenuItemIndex) |
| [GameMenuOption](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html) | [GetLeaveMenuOption](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#aec337578c2be838e29477297051e1590) ([MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) menuContext) |
| bool | [GetVirtualMenuOptionConditionsHold](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#ade1c66270d957042c5e62f7548545879) ([MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) menuContext, int virtualMenuItemIndex) |
| void | [OnFrameTick](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#a85f4f6a86a87957231ff05881b687e8a) ([MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) menuContext, float dt) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetMenuText](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#a12b09edff3e23d079674a9aa3427e511) ([MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) menuContext) |
| void | [AddGameMenu](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#abafb2bdd1aab2a7a5cdd9a769a14bc0a) ([GameMenu](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html) gameMenu) |
| void | [RemoveRelatedGameMenus](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#aa1ddd1566ee396ebbc4d3d5eef410092) (object relatedObject) |
| void | [RemoveRelatedGameMenuOptions](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#a5b2b650c88af66cc41ba9c5c3f348dee) (object relatedObject) |
| [GameMenu](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html) | [GetGameMenu](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#a5b61f385301a35cff2a5d2e919f2c5da) (string menuId) |

|  |  |
| --- | --- |
| Public Attributes | |
| int | [PreviouslySelectedGameMenuItem](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#af529b6e82c1079dbfaa5e5d061b505dc) = -1 |
| [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | [NextLocation](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#aa1bc14f4cde5925da4ebd2ad1ada22c0) |
| [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | [PreviousLocation](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#a5851f6e0c2235718571766594e9c8ae0) |
| List< [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) > | [MenuLocations](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#a89150ccc8afb241783eb8fbf25d72966) = new List<[Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html)>() |
| Object | [PreviouslySelectedGameMenuObject](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#af43bf76a8667cda32ff15e11922eec78) |

|  |  |
| --- | --- |
| Properties | |
| string | [NextGameMenuId](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#a3e222e38e0b07cbf5a308ffccd7549af) `[get]` |
| [GameMenu](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html) | [NextMenu](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#ab2f38a45910387c01fef0120c9af5df3) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#ac16d6ebd4f55b79e563b6cc07cc65b18)GameMenuManager()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.GameMenus.GameMenuManager.GameMenuManager | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#a4bcbeacdf752d545085a8c7c77e31c6e)SetNextMenu()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameMenus.GameMenuManager.SetNextMenu | ( | String | *name* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#ad4baf5e739eb16a9f309bf60cd977762)ExitToLast()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameMenus.GameMenuManager.ExitToLast | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#acf83712eb59bf46c831feb5bc265693e)SetCurrentRepeatableIndex()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameMenus.GameMenuManager.SetCurrentRepeatableIndex | ( | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) | *menuContext*, |
|  |  | int | *index* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#a5bf35c12410786a1e9294b447788374b)GetMenuOptionConditionsHold()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.GameMenus.GameMenuManager.GetMenuOptionConditionsHold | ( | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) | *menuContext*, |
|  |  | int | *menuItemNumber* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#abdc2122e18d7659189f8da31791df204)RefreshMenuOptions()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameMenus.GameMenuManager.RefreshMenuOptions | ( | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) | *menuContext* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#a7f371374ade9f60165c3f729ff33f043)RefreshMenuOptionConditions()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameMenus.GameMenuManager.RefreshMenuOptionConditions | ( | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) | *menuContext* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#a62ff2c542a219251a094a66cce913e42)GetMenuOptionIdString()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| string TaleWorlds.CampaignSystem.GameMenus.GameMenuManager.GetMenuOptionIdString | ( | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) | *menuContext*, |
|  |  | int | *menuItemNumber* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#af3202393e402b2edb62b1cc86012c68c)RunConsequencesOfMenuOption()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameMenus.GameMenuManager.RunConsequencesOfMenuOption | ( | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) | *menuContext*, |
|  |  | int | *menuItemNumber* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#a9acd7a461bb952b7ddb17cec40fb57c9)GetVirtualMenuOptionTooltip()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.GameMenus.GameMenuManager.GetVirtualMenuOptionTooltip | ( | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) | *menuContext*, |
|  |  | int | *virtualMenuItemIndex* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#af2fe70f0d42699bd13e05334502aa36a)GetMenuOverlayType()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [GameMenu.MenuOverlayType](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a105216128b909e180a28a34f96df0b78) TaleWorlds.CampaignSystem.GameMenus.GameMenuManager.GetMenuOverlayType | ( | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) | *menuContext* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#ab05fea59457cd8a8396895ac82902d88)GetVirtualMenuOptionText()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.GameMenus.GameMenuManager.GetVirtualMenuOptionText | ( | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) | *menuContext*, |
|  |  | int | *virtualMenuItemIndex* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#a9439009157ad4418c4c36bec6fcfb5c0)GetVirtualGameMenuOption()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [GameMenuOption](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html) TaleWorlds.CampaignSystem.GameMenus.GameMenuManager.GetVirtualGameMenuOption | ( | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) | *menuContext*, |
|  |  | int | *virtualMenuItemIndex* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#a12d9d1079b4e806bc8e7e3104474c1d7)GetVirtualMenuOptionText2()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.GameMenus.GameMenuManager.GetVirtualMenuOptionText2 | ( | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) | *menuContext*, |
|  |  | int | *virtualMenuItemIndex* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#a8a3220f6546771191c1834dfa6e876e7)GetVirtualMenuProgress()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.GameMenus.GameMenuManager.GetVirtualMenuProgress | ( | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) | *menuContext* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#ad587ba697580ba98b1d7191651a40089)GetVirtualMenuAndOptionType()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [GameMenu.MenuAndOptionType](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a75a6de1769953ede245660ef2358933e) TaleWorlds.CampaignSystem.GameMenus.GameMenuManager.GetVirtualMenuAndOptionType | ( | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) | *menuContext* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#a59405da7ced2c27c82c4ff2fd150622b)GetVirtualMenuIsWaitActive()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.GameMenus.GameMenuManager.GetVirtualMenuIsWaitActive | ( | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) | *menuContext* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#a9d4ecb82be289164cd5a99692abd88b3)GetVirtualMenuTargetWaitHours()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.GameMenus.GameMenuManager.GetVirtualMenuTargetWaitHours | ( | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) | *menuContext* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#a71097c39671291a6228121634ae7b09d)GetVirtualMenuOptionIsEnabled()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.GameMenus.GameMenuManager.GetVirtualMenuOptionIsEnabled | ( | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) | *menuContext*, |
|  |  | int | *virtualMenuItemIndex* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#a3285d9fd804ad410d9bef6f03538a17e)GetVirtualMenuOptionAmount()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.GameMenus.GameMenuManager.GetVirtualMenuOptionAmount | ( | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) | *menuContext* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#af8bd92115b2caf3b61f2e954db43bf1b)GetVirtualMenuOptionIsLeave()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.GameMenus.GameMenuManager.GetVirtualMenuOptionIsLeave | ( | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) | *menuContext*, |
|  |  | int | *virtualMenuItemIndex* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#aec337578c2be838e29477297051e1590)GetLeaveMenuOption()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [GameMenuOption](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html) TaleWorlds.CampaignSystem.GameMenus.GameMenuManager.GetLeaveMenuOption | ( | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) | *menuContext* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#ade1c66270d957042c5e62f7548545879)GetVirtualMenuOptionConditionsHold()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.GameMenus.GameMenuManager.GetVirtualMenuOptionConditionsHold | ( | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) | *menuContext*, |
|  |  | int | *virtualMenuItemIndex* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#a85f4f6a86a87957231ff05881b687e8a)OnFrameTick()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameMenus.GameMenuManager.OnFrameTick | ( | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) | *menuContext*, |
|  |  | float | *dt* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#a12b09edff3e23d079674a9aa3427e511)GetMenuText()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.GameMenus.GameMenuManager.GetMenuText | ( | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) | *menuContext* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#abafb2bdd1aab2a7a5cdd9a769a14bc0a)AddGameMenu()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameMenus.GameMenuManager.AddGameMenu | ( | [GameMenu](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html) | *gameMenu* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#aa1ddd1566ee396ebbc4d3d5eef410092)RemoveRelatedGameMenus()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameMenus.GameMenuManager.RemoveRelatedGameMenus | ( | object | *relatedObject* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#a5b2b650c88af66cc41ba9c5c3f348dee)RemoveRelatedGameMenuOptions()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameMenus.GameMenuManager.RemoveRelatedGameMenuOptions | ( | object | *relatedObject* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#a5b61f385301a35cff2a5d2e919f2c5da)GetGameMenu()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [GameMenu](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html) TaleWorlds.CampaignSystem.GameMenus.GameMenuManager.GetGameMenu | ( | string | *menuId* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#af529b6e82c1079dbfaa5e5d061b505dc)PreviouslySelectedGameMenuItem
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.CampaignSystem.GameMenus.GameMenuManager.PreviouslySelectedGameMenuItem = -1 |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#aa1bc14f4cde5925da4ebd2ad1ada22c0)NextLocation
----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) TaleWorlds.CampaignSystem.GameMenus.GameMenuManager.NextLocation |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#a5851f6e0c2235718571766594e9c8ae0)PreviousLocation
--------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) TaleWorlds.CampaignSystem.GameMenus.GameMenuManager.PreviousLocation |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#a89150ccc8afb241783eb8fbf25d72966)MenuLocations
-----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| List<[Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html)> TaleWorlds.CampaignSystem.GameMenus.GameMenuManager.MenuLocations = new List<[Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html)>() |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#af43bf76a8667cda32ff15e11922eec78)PreviouslySelectedGameMenuObject
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Object TaleWorlds.CampaignSystem.GameMenus.GameMenuManager.PreviouslySelectedGameMenuObject |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#a3e222e38e0b07cbf5a308ffccd7549af)NextGameMenuId
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.GameMenus.GameMenuManager.NextGameMenuId | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html#ab2f38a45910387c01fef0120c9af5df3)NextMenu
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GameMenu](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html) TaleWorlds.CampaignSystem.GameMenus.GameMenuManager.NextMenu | | get |

