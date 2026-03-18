--- SOURCE: class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_party_screen.html ---

SandBox.GauntletUI.GauntletPartyScreen Class ReferenceInherits ScreenBase, [TaleWorlds.Core.IGameStateListener](interface_tale_worlds_1_1_core_1_1_i_game_state_listener.html), [SandBox.View.IChangeableScreen](interface_sand_box_1_1_view_1_1_i_changeable_screen.html), [TaleWorlds.CampaignSystem.GameState.IPartyScreenLogicHandler](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_party_screen_logic_handler.html), [TaleWorlds.CampaignSystem.GameState.IPartyScreenPrisonHandler](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_party_screen_prison_handler.html), and [TaleWorlds.CampaignSystem.GameState.IPartyScreenTroopHandler](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_party_screen_troop_handler.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [GauntletPartyScreen](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_party_screen.html#aa67d2d0b813e4228fb2ec83ad84eeb6f) ([PartyState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_party_state.html) partyState) |
| void | [RequestUserInput](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_party_screen.html#ad6763104b1a925287e9b5dd30877e355) (string text, Action accept, Action cancel) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnInitialize](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_party_screen.html#a59e123ca3b4bd4143e5f5a3b96bdfb33) () |
| override void | [OnFrameTick](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_party_screen.html#aa4c9ec27e4539c1afff1e90ef951ca2b) (float dt) |
| override void | [OnResume](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_party_screen.html#ac4283fa5a4ca7cdb49ebb8f7b63da831) () |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsTroopUpgradesDisabled](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_party_screen.html#a3cc3def908b230ac861d751927da35ee) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_party_screen.html#aa67d2d0b813e4228fb2ec83ad84eeb6f)GauntletPartyScreen()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| SandBox.GauntletUI.GauntletPartyScreen.GauntletPartyScreen | ( | [PartyState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_party_state.html) | *partyState* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_party_screen.html#a59e123ca3b4bd4143e5f5a3b96bdfb33)OnInitialize()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.GauntletPartyScreen.OnInitialize | ( |  | ) |  | | protected |

Implements [TaleWorlds.Core.IGameStateListener](interface_tale_worlds_1_1_core_1_1_i_game_state_listener.html#a8df8104360d9c66aedb341b13367b8e5).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_party_screen.html#aa4c9ec27e4539c1afff1e90ef951ca2b)OnFrameTick()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.GauntletPartyScreen.OnFrameTick | ( | float | *dt* | ) |  | | protected |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_party_screen.html#ac4283fa5a4ca7cdb49ebb8f7b63da831)OnResume()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.GauntletPartyScreen.OnResume | ( |  | ) |  | | protected |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_party_screen.html#ad6763104b1a925287e9b5dd30877e355)RequestUserInput()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.GauntletUI.GauntletPartyScreen.RequestUserInput | ( | string | *text*, |
|  |  | Action | *accept*, |
|  |  | Action | *cancel* ) |

Implements [TaleWorlds.CampaignSystem.GameState.IPartyScreenLogicHandler](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_party_screen_logic_handler.html#a164f0973c6acb21ecd94b89d9e1236d9).

Property Documentation
----------------------

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_party_screen.html#a3cc3def908b230ac861d751927da35ee)IsTroopUpgradesDisabled
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.GauntletUI.GauntletPartyScreen.IsTroopUpgradesDisabled | | get |

