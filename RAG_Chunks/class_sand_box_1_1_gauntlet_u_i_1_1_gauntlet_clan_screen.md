--- SOURCE: class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_clan_screen.html ---

SandBox.GauntletUI.GauntletClanScreen Class ReferenceInherits ScreenBase, and [TaleWorlds.Core.IGameStateListener](interface_tale_worlds_1_1_core_1_1_i_game_state_listener.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [GauntletClanScreen](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_clan_screen.html#aa5491c9cd1537fc2ab690b6032ec1f7a) ([ClanState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_clan_state.html) clanState) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| virtual [ClanManagementVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_management_v_m.html) | [CreateDataSource](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_clan_screen.html#a4e67936661579ea9cf5b94ba25193848) () |
| override void | [OnInitialize](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_clan_screen.html#a90267cab899fb33dcbfce0e42c87485e) () |
| override void | [OnFrameTick](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_clan_screen.html#a1a3d4aac155047ff99d8b33490601847) (float dt) |
| bool | [IsRoleSelectionPopupActive](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_clan_screen.html#a5b2886cd4591c812971bb131d93b6972) () |
| void | [OpenPartyScreenForNewClanParty](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_clan_screen.html#a21daa8e97f6a5f632a0b5e67598ca2c6) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| void | [OpenBannerEditorWithPlayerClan](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_clan_screen.html#adb019dd94fe497a6259c75f15c0478d8) () |
| void | [ShowHeroOnMap](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_clan_screen.html#a734f358f22548f7e48c3fe9edd09004a) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override void | [OnActivate](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_clan_screen.html#a88ae7764e7b0bab4ad9dbca51b618873) () |
| void | [CloseClanScreen](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_clan_screen.html#a031eb0421c9dd874c4ff24978d6efddd) () |

|  |  |
| --- | --- |
| Protected Attributes | |
| [GauntletLayer](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html) | [\_gauntletLayer](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_clan_screen.html#afa0c57e61d60bd707eae3bf22a11f20e) |
| [SpriteCategory](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html) | [\_clanCategory](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_clan_screen.html#a77d00c66e0cdd1a80b2174561965cfba) |
| readonly [ClanState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_clan_state.html) | [\_clanState](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_clan_screen.html#a945cc180b33764916ccc0d20c429c3e9) |
| bool | [\_isCreatingPartyWithMembers](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_clan_screen.html#a9ee6eab652e97f02f27ef8a8fa5a7f1f) = false |

|  |  |
| --- | --- |
| Properties | |
| [ClanManagementVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_management_v_m.html) | [\_dataSource](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_clan_screen.html#aa2bb0be0ef0e880cfb95948d4e3a2a91) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_clan_screen.html#aa5491c9cd1537fc2ab690b6032ec1f7a)GauntletClanScreen()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| SandBox.GauntletUI.GauntletClanScreen.GauntletClanScreen | ( | [ClanState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_clan_state.html) | *clanState* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_clan_screen.html#a4e67936661579ea9cf5b94ba25193848)CreateDataSource()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual [ClanManagementVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_management_v_m.html) SandBox.GauntletUI.GauntletClanScreen.CreateDataSource | ( |  | ) |  | | protectedvirtual |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_clan_screen.html#a90267cab899fb33dcbfce0e42c87485e)OnInitialize()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.GauntletClanScreen.OnInitialize | ( |  | ) |  | | protected |

Implements [TaleWorlds.Core.IGameStateListener](interface_tale_worlds_1_1_core_1_1_i_game_state_listener.html#a8df8104360d9c66aedb341b13367b8e5).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_clan_screen.html#a1a3d4aac155047ff99d8b33490601847)OnFrameTick()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.GauntletClanScreen.OnFrameTick | ( | float | *dt* | ) |  | | protected |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_clan_screen.html#a5b2886cd4591c812971bb131d93b6972)IsRoleSelectionPopupActive()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool SandBox.GauntletUI.GauntletClanScreen.IsRoleSelectionPopupActive | ( |  | ) |  | | protected |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_clan_screen.html#a21daa8e97f6a5f632a0b5e67598ca2c6)OpenPartyScreenForNewClanParty()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void SandBox.GauntletUI.GauntletClanScreen.OpenPartyScreenForNewClanParty | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | protected |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_clan_screen.html#adb019dd94fe497a6259c75f15c0478d8)OpenBannerEditorWithPlayerClan()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void SandBox.GauntletUI.GauntletClanScreen.OpenBannerEditorWithPlayerClan | ( |  | ) |  | | protected |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_clan_screen.html#a734f358f22548f7e48c3fe9edd09004a)ShowHeroOnMap()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void SandBox.GauntletUI.GauntletClanScreen.ShowHeroOnMap | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | protected |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_clan_screen.html#a88ae7764e7b0bab4ad9dbca51b618873)OnActivate()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.GauntletClanScreen.OnActivate | ( |  | ) |  | | protected |

Implements [TaleWorlds.Core.IGameStateListener](interface_tale_worlds_1_1_core_1_1_i_game_state_listener.html#aa8b05eeab9e1f4691b9ef1ac12a05b77).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_clan_screen.html#a031eb0421c9dd874c4ff24978d6efddd)CloseClanScreen()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void SandBox.GauntletUI.GauntletClanScreen.CloseClanScreen | ( |  | ) |  | | protected |

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_clan_screen.html#afa0c57e61d60bd707eae3bf22a11f20e)\_gauntletLayer
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GauntletLayer](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html) SandBox.GauntletUI.GauntletClanScreen.\_gauntletLayer | | protected |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_clan_screen.html#a77d00c66e0cdd1a80b2174561965cfba)\_clanCategory
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SpriteCategory](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html) SandBox.GauntletUI.GauntletClanScreen.\_clanCategory | | protected |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_clan_screen.html#a945cc180b33764916ccc0d20c429c3e9)\_clanState
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [ClanState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_clan_state.html) SandBox.GauntletUI.GauntletClanScreen.\_clanState | | protected |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_clan_screen.html#a9ee6eab652e97f02f27ef8a8fa5a7f1f)\_isCreatingPartyWithMembers
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.GauntletUI.GauntletClanScreen.\_isCreatingPartyWithMembers = false | | protected |

Property Documentation
----------------------

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_clan_screen.html#aa2bb0be0ef0e880cfb95948d4e3a2a91)\_dataSource
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ClanManagementVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_management_v_m.html) SandBox.GauntletUI.GauntletClanScreen.\_dataSource | | get |

