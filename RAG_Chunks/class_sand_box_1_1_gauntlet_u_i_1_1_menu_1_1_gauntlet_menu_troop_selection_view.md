--- SOURCE: class_sand_box_1_1_gauntlet_u_i_1_1_menu_1_1_gauntlet_menu_troop_selection_view.html ---

SandBox.GauntletUI.Menu.GauntletMenuTroopSelectionView Class ReferenceInherits [SandBox.View.Menu.MenuView](class_sand_box_1_1_view_1_1_menu_1_1_menu_view.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [GauntletMenuTroopSelectionView](class_sand_box_1_1_gauntlet_u_i_1_1_menu_1_1_gauntlet_menu_troop_selection_view.html#a856535d1c275400b9fcdbed77a6e71fa) ([TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) fullRoster, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) initialSelections, Func< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), bool > changeChangeStatusOfTroop, Action< [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) > onDone, int maxSelectableTroopCount, int minSelectableTroopCount) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnInitialize](class_sand_box_1_1_gauntlet_u_i_1_1_menu_1_1_gauntlet_menu_troop_selection_view.html#a71cdf01aab0181d4289c6991fb5f0349) () |
| override void | [OnFinalize](class_sand_box_1_1_gauntlet_u_i_1_1_menu_1_1_gauntlet_menu_troop_selection_view.html#a54df228b9d4efcd4b0194c9d73a2dcb2) () |
| override void | [OnFrameTick](class_sand_box_1_1_gauntlet_u_i_1_1_menu_1_1_gauntlet_menu_troop_selection_view.html#a5a4165dad0307e818b5ab1d30d6c4647) (float dt) |
| override void | [OnMapConversationActivated](class_sand_box_1_1_gauntlet_u_i_1_1_menu_1_1_gauntlet_menu_troop_selection_view.html#ab44d235db62ace76d05b61723eb95bea) () |
| override void | [OnMapConversationDeactivated](class_sand_box_1_1_gauntlet_u_i_1_1_menu_1_1_gauntlet_menu_troop_selection_view.html#a7d229164592e7fb061f1fb781ccd02ee) () |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Protected Attributes inherited from [SandBox.View.Menu.MenuView](class_sand_box_1_1_view_1_1_menu_1_1_menu_view.html) | |
| const float | [ContextAlphaModifier](class_sand_box_1_1_view_1_1_menu_1_1_menu_view.html#a29345cc9cb09e3dacc1cd01986e00050) = 8.5f |
| Properties inherited from [SandBox.View.Menu.MenuView](class_sand_box_1_1_view_1_1_menu_1_1_menu_view.html) | |
| virtual bool | [ShouldUpdateMenuAfterRemoved](class_sand_box_1_1_view_1_1_menu_1_1_menu_view.html#a94dc1ff8d31211f07f77d72acb69f287) `[get]` |
| MenuViewContext | [MenuViewContext](class_sand_box_1_1_view_1_1_menu_1_1_menu_view.html#a6f0b85a8a13e58673f56ae8d6014a682) `[get]` |
| MenuContext | [MenuContext](class_sand_box_1_1_view_1_1_menu_1_1_menu_view.html#af9f746d2633f2cf9944e3450b8406482) `[get]` |
| Properties inherited from [SandBox.View.SandboxView](class_sand_box_1_1_view_1_1_sandbox_view.html) | |
| bool | [IsFinalized](class_sand_box_1_1_view_1_1_sandbox_view.html#a5807fb2c109c6715d7fae1a6cf2f4693) `[get, protected set]` |
| ScreenLayer | [Layer](class_sand_box_1_1_view_1_1_sandbox_view.html#a070dec1267ecf8ff4afadffc12374024) `[get, protected set]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_menu_1_1_gauntlet_menu_troop_selection_view.html#a856535d1c275400b9fcdbed77a6e71fa)GauntletMenuTroopSelectionView()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| SandBox.GauntletUI.Menu.GauntletMenuTroopSelectionView.GauntletMenuTroopSelectionView | ( | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *fullRoster*, |
|  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *initialSelections*, |
|  |  | Func< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), bool > | *changeChangeStatusOfTroop*, |
|  |  | Action< [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) > | *onDone*, |
|  |  | int | *maxSelectableTroopCount*, |
|  |  | int | *minSelectableTroopCount* ) |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_menu_1_1_gauntlet_menu_troop_selection_view.html#a71cdf01aab0181d4289c6991fb5f0349)OnInitialize()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Menu.GauntletMenuTroopSelectionView.OnInitialize | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.SandboxView](class_sand_box_1_1_view_1_1_sandbox_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_menu_1_1_gauntlet_menu_troop_selection_view.html#a54df228b9d4efcd4b0194c9d73a2dcb2)OnFinalize()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Menu.GauntletMenuTroopSelectionView.OnFinalize | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.SandboxView](class_sand_box_1_1_view_1_1_sandbox_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_menu_1_1_gauntlet_menu_troop_selection_view.html#a5a4165dad0307e818b5ab1d30d6c4647)OnFrameTick()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Menu.GauntletMenuTroopSelectionView.OnFrameTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.SandboxView](class_sand_box_1_1_view_1_1_sandbox_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_menu_1_1_gauntlet_menu_troop_selection_view.html#ab44d235db62ace76d05b61723eb95bea)OnMapConversationActivated()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Menu.GauntletMenuTroopSelectionView.OnMapConversationActivated | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Menu.MenuView](class_sand_box_1_1_view_1_1_menu_1_1_menu_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_menu_1_1_gauntlet_menu_troop_selection_view.html#a7d229164592e7fb061f1fb781ccd02ee)OnMapConversationDeactivated()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Menu.GauntletMenuTroopSelectionView.OnMapConversationDeactivated | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Menu.MenuView](class_sand_box_1_1_view_1_1_menu_1_1_menu_view.html).

