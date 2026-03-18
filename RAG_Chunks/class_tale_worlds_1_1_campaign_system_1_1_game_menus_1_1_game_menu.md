--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html ---

TaleWorlds.CampaignSystem.GameMenus.GameMenu Class Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [MenuOverlayType](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a105216128b909e180a28a34f96df0b78) {     [None](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a105216128b909e180a28a34f96df0b78a6adf97f83acf6453d4a6a4b1070f3754) ,     [SettlementWithParties](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a105216128b909e180a28a34f96df0b78a6d09c45882d953f03184ae723cac4117) ,     [SettlementWithCharacters](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a105216128b909e180a28a34f96df0b78afef860de2ae9e31d81fc7318fc510b50) ,     [SettlementWithBoth](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a105216128b909e180a28a34f96df0b78ac8f1aabe98c407bc015d3be790bc9f63) ,     [Encounter](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a105216128b909e180a28a34f96df0b78ad1e9f9f891de8f9a655739a01fbf68f0)   } |
| enum | [MenuFlags](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a78b3f2b8cfeb21997df13c3389587b3d) {     [None](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a78b3f2b8cfeb21997df13c3389587b3da6adf97f83acf6453d4a6a4b1070f3754) = 0 ,     [AutoSelectFirst](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a78b3f2b8cfeb21997df13c3389587b3da0821bfbdb743fe8f714934caf3c0c92e) = 1   } |
| enum | [MenuAndOptionType](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a75a6de1769953ede245660ef2358933e) {     [RegularMenuOption](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a75a6de1769953ede245660ef2358933eac0047651b475a648c5912ec2e6dcbb7c) ,     [WaitMenuShowProgressAndHoursOption](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a75a6de1769953ede245660ef2358933ea6018052d20aca19c375882cafe126493) ,     [WaitMenuShowOnlyProgressOption](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a75a6de1769953ede245660ef2358933ea7b15a742fbb16b88c8c2c775b3906755) ,     [WaitMenuHideProgressAndHoursOption](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a75a6de1769953ede245660ef2358933ead5323c422f7eca3a04342ef638ab4c51)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [SetMenuRepeatObjects](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a702a4f00bde8e36a350f7745228ed7c4) (IEnumerable< Object > list) |
| bool | [GetMenuOptionConditionsHold](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a7f598df550c06e4c2500bdde7f173df2) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game, [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) menuContext, int menuItemNumber) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetMenuOptionText](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#ad2cacecbeeedb39f09d9524d6472cd4f) (int menuItemNumber) |
| [GameMenuOption](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html) | [GetGameMenuOption](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#ae9c87cde1f9c1bc578ce29d1c68ac7dd) (int menuItemNumber) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetMenuOptionText2](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a061f7d63a0184011e701defeff9a20b2) (int menuItemNumber) |
| string | [GetMenuOptionIdString](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#aec7321b179dd89e2210f39f8ec3343fe) (int menuItemNumber) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetMenuOptionTooltip](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a82b30cccb5320d90ec50c13c2349e9b8) (int menuItemNumber) |
| bool | [GetMenuOptionIsLeave](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a9372f372d8fbeef7b8ddcc77a753d50f) (int menuItemNumber) |
| void | [SetProgressOfWaitingInMenu](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#ae77c51b7d35be2cf87b9d62ed40722d2) (float progress) |
| void | [SetTargetedWaitingTimeAndInitialProgress](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#ae7f8a1fe17b291f5a1beda21c71541fd) (float targetedWaitingTime, float initialProgress) |
| [GameMenuOption](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html) | [GetLeaveMenuOption](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#aaac3dd656a828daf0df8284f59e37872) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game, [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) menuContext) |
| void | [RunOnTick](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a315d61a862d0c6f55fe49b53726a71c1) ([MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) menuContext, float dt) |
| bool | [RunWaitMenuCondition](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a7cccbe44c36fadb732c764bec8270846) ([MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) menuContext) |
| void | [RunWaitMenuConsequence](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a9803974e4112d992e95aae689ca7538c) ([MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) menuContext) |
| void | [RunMenuOptionConsequence](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a207de39f4edc5ccf3e5901065dc4fb79) ([MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) menuContext, int menuItemNumber) |
| void | [StartWait](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a483faed0b266603a181e4867b6fab66b) () |
| void | [EndWait](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a8776f10bc2fe6f760b90d061a3363887) () |
| void | [RunOnInit](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a7ff19cb198c0ab497869cedbd8b84a93) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game, [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) menuContext) |
| void | [PreInit](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a7dd25e2ae3b8be7c2ac9e3a6eec32fee) ([MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) menuContext) |
| void | [AfterInit](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#aaaacf8753a03f219c40af24b8c8e60e2) ([MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) menuContext) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetText](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#ace9d9b8146019444171e542751ac4b39) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [ActivateGameMenu](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#adf4875fda818baca92be7e6408f3f9d4) (string menuId) |
| static void | [SwitchToMenu](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#aa54f773cca1a012103956c8ca1cfee3e) (string menuId) |
| static void | [ExitToLast](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a6c8c5a92817aa4d65de4a0c9c76cdfbb) () |

|  |  |
| --- | --- |
| Public Attributes | |
| [OnInitDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_game_menus.html#ae01fba5e92213046937417cfab6b6ef5) | [OnInit](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#afd331d205fea00908cf8ed6e3018962a) |
| object | [LastSelectedMenuObject](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#af741227a6d4870f05c98c7d3b2799daf) |

|  |  |
| --- | --- |
| Properties | |
| [MenuAndOptionType](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a75a6de1769953ede245660ef2358933e) | [Type](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#af3d8a42f47f249250fb5b528f5d08607) `[get]` |
| String | [StringId](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a53b9290dbe3b958bd0e08806fc16e3e8) `[get]` |
| object | [RelatedObject](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#ab7d556a95acb28f48ac08d51836cf50b) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [MenuTitle](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a59c249ab265aac143c88eff5d1103058) `[get]` |
| [MenuOverlayType](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a105216128b909e180a28a34f96df0b78) | [OverlayType](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a4f4354d9c3432eb7df024f8d5371eef2) `[get]` |
| bool | [IsReady](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a59b416f731fc56651d58a4028ac1a290) = false `[get]` |
| int | [MenuItemAmount](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a73323841eca252b3fe8d1af620d25bd1) `[get]` |
| List< Object > | [MenuRepeatObjects](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#afca8d42028910c49ca3d800b1300f1ea) = new List<Object>() `[get]` |
| object | [CurrentRepeatableObject](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#aba156a0378c76e180e611bd20e590a76) `[get]` |
| bool | [IsWaitMenu](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a9a76290e9230d6ecb3baad9130fe3f5e) `[get]` |
| bool | [IsWaitActive](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a7819715c0f6947286975f68f6584ca30) `[get]` |
| bool | [IsEmpty](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a95a8e36d0d628004fad21ca4768ef239) `[get]` |
| float | [Progress](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a81b9f84dcb0b92aa79e59e771e240abb) `[get]` |
| float | [TargetWaitHours](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a0799e465aca45889260c229796b14a41) `[get]` |
| [OnTickDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_game_menus.html#a05791a312d92c840f251eb62ab268f51) | [OnTick](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a69675123aaf6094a00c0987871196fd1) `[get]` |
| [OnConditionDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_game_menus.html#a812ba69ef85df5525f772e2d4ba0158a) | [OnCondition](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#ab0ba1610265a8aa3d37d454c6e68853e) `[get]` |
| [OnConsequenceDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_game_menus.html#a639003d18b3a5d6068698217e0193265) | [OnConsequence](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#aff970ef52eac0e1c14bf494c4547755b) `[get]` |
| int | [CurrentRepeatableIndex](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a813194760ce174a344a169d47f29cb24) = 0 `[get, set]` |
| IEnumerable< [GameMenuOption](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html) > | [MenuOptions](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#aab1fa2b18d9818954a8e70fe3a0b946e) `[get]` |
| bool | [AutoSelectFirst](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a564434e922ea8be4baf757ea0761ba73) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a105216128b909e180a28a34f96df0b78)MenuOverlayType
-----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.GameMenus.GameMenu.MenuOverlayType](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a105216128b909e180a28a34f96df0b78) |

| Enumerator | |
| --- | --- |
| None |  |
| SettlementWithParties |  |
| SettlementWithCharacters |  |
| SettlementWithBoth |  |
| Encounter |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a78b3f2b8cfeb21997df13c3389587b3d)MenuFlags
-----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.GameMenus.GameMenu.MenuFlags](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a78b3f2b8cfeb21997df13c3389587b3d) |

| Enumerator | |
| --- | --- |
| None |  |
| AutoSelectFirst |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a75a6de1769953ede245660ef2358933e)MenuAndOptionType
-------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.GameMenus.GameMenu.MenuAndOptionType](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a75a6de1769953ede245660ef2358933e) |

| Enumerator | |
| --- | --- |
| RegularMenuOption |  |
| WaitMenuShowProgressAndHoursOption |  |
| WaitMenuShowOnlyProgressOption |  |
| WaitMenuHideProgressAndHoursOption |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a702a4f00bde8e36a350f7745228ed7c4)SetMenuRepeatObjects()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameMenus.GameMenu.SetMenuRepeatObjects | ( | IEnumerable< Object > | *list* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a7f598df550c06e4c2500bdde7f173df2)GetMenuOptionConditionsHold()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.GameMenus.GameMenu.GetMenuOptionConditionsHold | ( | [Game](class_tale_worlds_1_1_core_1_1_game.html) | *game*, |
|  |  | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) | *menuContext*, |
|  |  | int | *menuItemNumber* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#ad2cacecbeeedb39f09d9524d6472cd4f)GetMenuOptionText()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.GameMenus.GameMenu.GetMenuOptionText | ( | int | *menuItemNumber* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#ae9c87cde1f9c1bc578ce29d1c68ac7dd)GetGameMenuOption()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [GameMenuOption](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html) TaleWorlds.CampaignSystem.GameMenus.GameMenu.GetGameMenuOption | ( | int | *menuItemNumber* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a061f7d63a0184011e701defeff9a20b2)GetMenuOptionText2()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.GameMenus.GameMenu.GetMenuOptionText2 | ( | int | *menuItemNumber* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#aec7321b179dd89e2210f39f8ec3343fe)GetMenuOptionIdString()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| string TaleWorlds.CampaignSystem.GameMenus.GameMenu.GetMenuOptionIdString | ( | int | *menuItemNumber* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a82b30cccb5320d90ec50c13c2349e9b8)GetMenuOptionTooltip()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.GameMenus.GameMenu.GetMenuOptionTooltip | ( | int | *menuItemNumber* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a9372f372d8fbeef7b8ddcc77a753d50f)GetMenuOptionIsLeave()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.GameMenus.GameMenu.GetMenuOptionIsLeave | ( | int | *menuItemNumber* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#ae77c51b7d35be2cf87b9d62ed40722d2)SetProgressOfWaitingInMenu()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameMenus.GameMenu.SetProgressOfWaitingInMenu | ( | float | *progress* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#ae7f8a1fe17b291f5a1beda21c71541fd)SetTargetedWaitingTimeAndInitialProgress()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameMenus.GameMenu.SetTargetedWaitingTimeAndInitialProgress | ( | float | *targetedWaitingTime*, |
|  |  | float | *initialProgress* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#aaac3dd656a828daf0df8284f59e37872)GetLeaveMenuOption()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [GameMenuOption](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html) TaleWorlds.CampaignSystem.GameMenus.GameMenu.GetLeaveMenuOption | ( | [Game](class_tale_worlds_1_1_core_1_1_game.html) | *game*, |
|  |  | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) | *menuContext* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a315d61a862d0c6f55fe49b53726a71c1)RunOnTick()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameMenus.GameMenu.RunOnTick | ( | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) | *menuContext*, |
|  |  | float | *dt* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a7cccbe44c36fadb732c764bec8270846)RunWaitMenuCondition()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.GameMenus.GameMenu.RunWaitMenuCondition | ( | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) | *menuContext* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a9803974e4112d992e95aae689ca7538c)RunWaitMenuConsequence()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameMenus.GameMenu.RunWaitMenuConsequence | ( | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) | *menuContext* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a207de39f4edc5ccf3e5901065dc4fb79)RunMenuOptionConsequence()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameMenus.GameMenu.RunMenuOptionConsequence | ( | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) | *menuContext*, |
|  |  | int | *menuItemNumber* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a483faed0b266603a181e4867b6fab66b)StartWait()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameMenus.GameMenu.StartWait | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a8776f10bc2fe6f760b90d061a3363887)EndWait()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameMenus.GameMenu.EndWait | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a7ff19cb198c0ab497869cedbd8b84a93)RunOnInit()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameMenus.GameMenu.RunOnInit | ( | [Game](class_tale_worlds_1_1_core_1_1_game.html) | *game*, |
|  |  | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) | *menuContext* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a7dd25e2ae3b8be7c2ac9e3a6eec32fee)PreInit()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameMenus.GameMenu.PreInit | ( | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) | *menuContext* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#aaaacf8753a03f219c40af24b8c8e60e2)AfterInit()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameMenus.GameMenu.AfterInit | ( | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) | *menuContext* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#ace9d9b8146019444171e542751ac4b39)GetText()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.GameMenus.GameMenu.GetText | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#adf4875fda818baca92be7e6408f3f9d4)ActivateGameMenu()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.GameMenus.GameMenu.ActivateGameMenu | ( | string | *menuId* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#aa54f773cca1a012103956c8ca1cfee3e)SwitchToMenu()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.GameMenus.GameMenu.SwitchToMenu | ( | string | *menuId* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a6c8c5a92817aa4d65de4a0c9c76cdfbb)ExitToLast()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.GameMenus.GameMenu.ExitToLast | ( |  | ) |  | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#afd331d205fea00908cf8ed6e3018962a)OnInit
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [OnInitDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_game_menus.html#ae01fba5e92213046937417cfab6b6ef5) TaleWorlds.CampaignSystem.GameMenus.GameMenu.OnInit |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#af741227a6d4870f05c98c7d3b2799daf)LastSelectedMenuObject
------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| object TaleWorlds.CampaignSystem.GameMenus.GameMenu.LastSelectedMenuObject |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#af3d8a42f47f249250fb5b528f5d08607)Type
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MenuAndOptionType](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a75a6de1769953ede245660ef2358933e) TaleWorlds.CampaignSystem.GameMenus.GameMenu.Type | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a53b9290dbe3b958bd0e08806fc16e3e8)StringId
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | String TaleWorlds.CampaignSystem.GameMenus.GameMenu.StringId | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#ab7d556a95acb28f48ac08d51836cf50b)RelatedObject
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | object TaleWorlds.CampaignSystem.GameMenus.GameMenu.RelatedObject | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a59c249ab265aac143c88eff5d1103058)MenuTitle
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.GameMenus.GameMenu.MenuTitle | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a4f4354d9c3432eb7df024f8d5371eef2)OverlayType
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MenuOverlayType](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a105216128b909e180a28a34f96df0b78) TaleWorlds.CampaignSystem.GameMenus.GameMenu.OverlayType | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a59b416f731fc56651d58a4028ac1a290)IsReady
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.GameMenus.GameMenu.IsReady = false | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a73323841eca252b3fe8d1af620d25bd1)MenuItemAmount
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.GameMenus.GameMenu.MenuItemAmount | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#afca8d42028910c49ca3d800b1300f1ea)MenuRepeatObjects
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<Object> TaleWorlds.CampaignSystem.GameMenus.GameMenu.MenuRepeatObjects = new List<Object>() | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#aba156a0378c76e180e611bd20e590a76)CurrentRepeatableObject
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | object TaleWorlds.CampaignSystem.GameMenus.GameMenu.CurrentRepeatableObject | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a9a76290e9230d6ecb3baad9130fe3f5e)IsWaitMenu
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.GameMenus.GameMenu.IsWaitMenu | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a7819715c0f6947286975f68f6584ca30)IsWaitActive
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.GameMenus.GameMenu.IsWaitActive | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a95a8e36d0d628004fad21ca4768ef239)IsEmpty
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.GameMenus.GameMenu.IsEmpty | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a81b9f84dcb0b92aa79e59e771e240abb)Progress
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.GameMenus.GameMenu.Progress | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a0799e465aca45889260c229796b14a41)TargetWaitHours
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.GameMenus.GameMenu.TargetWaitHours | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a69675123aaf6094a00c0987871196fd1)OnTick
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [OnTickDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_game_menus.html#a05791a312d92c840f251eb62ab268f51) TaleWorlds.CampaignSystem.GameMenus.GameMenu.OnTick | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#ab0ba1610265a8aa3d37d454c6e68853e)OnCondition
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [OnConditionDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_game_menus.html#a812ba69ef85df5525f772e2d4ba0158a) TaleWorlds.CampaignSystem.GameMenus.GameMenu.OnCondition | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#aff970ef52eac0e1c14bf494c4547755b)OnConsequence
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [OnConsequenceDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_game_menus.html#a639003d18b3a5d6068698217e0193265) TaleWorlds.CampaignSystem.GameMenus.GameMenu.OnConsequence | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a813194760ce174a344a169d47f29cb24)CurrentRepeatableIndex
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.GameMenus.GameMenu.CurrentRepeatableIndex = 0 | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#aab1fa2b18d9818954a8e70fe3a0b946e)MenuOptions
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IEnumerable<[GameMenuOption](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html)> TaleWorlds.CampaignSystem.GameMenus.GameMenu.MenuOptions | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a564434e922ea8be4baf757ea0761ba73)AutoSelectFirst
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.GameMenus.GameMenu.AutoSelectFirst | | get |

