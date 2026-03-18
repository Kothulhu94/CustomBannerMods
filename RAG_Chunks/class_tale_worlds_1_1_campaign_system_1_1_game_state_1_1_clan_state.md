--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_clan_state.html ---

TaleWorlds.CampaignSystem.GameState.ClanState Class ReferenceInherits [TaleWorlds.Core.GameState](class_tale_worlds_1_1_core_1_1_game_state.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ClanState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_clan_state.html#a4c8393ae1d517146bf476f47fd38b3a3) () |
|  | [ClanState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_clan_state.html#a4305c801cbd4c30d7ecdf7b67665fc6e) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) initialSelectedHero) |
|  | [ClanState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_clan_state.html#a9b2c175f59889fd1831e663c69283f24) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) initialSelectedParty) |
|  | [ClanState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_clan_state.html#aa3c83bef8a2044db9bf49d3f22e2d5fa) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) initialSelectedSettlement) |
|  | [ClanState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_clan_state.html#aba35fc9cd51f7352315b44e139a56d62) ([Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) initialSelectedWorkshop) |
|  | [ClanState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_clan_state.html#a01ff88553d4787b5731b5fa14ab1bb8e) ([Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) initialSelectedAlley) |
| Public Member Functions inherited from [TaleWorlds.Core.GameState](class_tale_worlds_1_1_core_1_1_game_state.html) | |
| bool | [RegisterListener](class_tale_worlds_1_1_core_1_1_game_state.html#a5de0596109748cd2cc9cfa28959f8f96) ([IGameStateListener](interface_tale_worlds_1_1_core_1_1_i_game_state_listener.html) listener) |
| bool | [UnregisterListener](class_tale_worlds_1_1_core_1_1_game_state.html#ae56aad1d9d2a21f72df2302e198c993a) ([IGameStateListener](interface_tale_worlds_1_1_core_1_1_i_game_state_listener.html) listener) |
| T | [GetListenerOfType< T >](class_tale_worlds_1_1_core_1_1_game_state.html#a6c13c32468bbc05927f4b592c7682b47) () |
| Public Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a520e657fd5a750c8b7e2154b0f5629ea) () |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a134c5e806ba735219710d773e7075b00) (MBObjectBase other) |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8e3c1b47f5d928e64d9d67fa7864c364) (string stringId) |
| void | [AfterInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab67141737ce51fe724e4a5b8026a973b) () |
| virtual void | [AfterRegister](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab15f91cc9dbb7ff8763eec828c179216) () |
| virtual void | [Initialize](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aad39d5ca82d85853a9879e2670dd036e) () |
| virtual void | [Deserialize](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad1364026109401ca16d5a450d8b8f178) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
| override int | [GetHashCode](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a68e79a07f136aae5be4fe9eadb612def) () |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetName](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a0b72f9e386b6cefc4e6bfb52642b98db) () |
| void | [PreAfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af26d64a79291c4f6328fc151d2569ebf) () |
| void | [AfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a277b54134c76732e443019a7862cf388) () |
| void | [OnRegistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a586208e92e5041fd432127305aa8af16) () |
| void | [OnUnregistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a71bef09af9a896246fa7b18c324e565c) () |

|  |  |
| --- | --- |
| Properties | |
| override bool | [IsMenuState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_clan_state.html#af0e397354cb673f8bfe179cf3d43e336) `[get]` |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [InitialSelectedHero](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_clan_state.html#a8b3444cd23fee2951aae164133a3dec8) `[get]` |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | [InitialSelectedParty](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_clan_state.html#a6d144d3c04242ec71c834fa56e5bfcea) `[get]` |
| [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [InitialSelectedSettlement](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_clan_state.html#abd2938591d10c1dcc8c69ac2f9cc2ffc) `[get]` |
| [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) | [InitialSelectedWorkshop](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_clan_state.html#a29001ae9bc6a2039961064a5dc8b8b0a) `[get]` |
| [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | [InitialSelectedAlley](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_clan_state.html#aa13d12339f1f273f763f409e2b16a84b) `[get]` |
| [IClanStateHandler](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_clan_state_handler.html) | [Handler](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_clan_state.html#ae2d67e33b189c59662354eb8ffba12b4) `[get, set]` |
| Properties inherited from [TaleWorlds.Core.GameState](class_tale_worlds_1_1_core_1_1_game_state.html) | |
| [GameState](class_tale_worlds_1_1_core_1_1_game_state.html#ad748b43db56f0ccaeea076775562dea7) | [Predecessor](class_tale_worlds_1_1_core_1_1_game_state.html#a8c58eba46626705436b1f6e6438fe4b3) `[get]` |
| bool | [IsActive](class_tale_worlds_1_1_core_1_1_game_state.html#ae98283dc0dbf0a4a7ac2f2703df0556a) `[get]` |
| IReadOnlyCollection< [IGameStateListener](interface_tale_worlds_1_1_core_1_1_i_game_state_listener.html) > | [Listeners](class_tale_worlds_1_1_core_1_1_game_state.html#a169c050b0c9fc4f75ebc22077e0e1dcc) `[get]` |
| GameStateManager | [GameStateManager](class_tale_worlds_1_1_core_1_1_game_state.html#a49046697eb0faecb2ae348a9fb53164c) `[get]` |
| virtual bool | [IsMusicMenuState](class_tale_worlds_1_1_core_1_1_game_state.html#af8d01b71fa319594b32292b3cbb5f353) `[get]` |
|  | Whether or not if this state should be treated as a menu state for the music manager. |
| virtual bool | [IsMenuState](class_tale_worlds_1_1_core_1_1_game_state.html#ac5c37d14282c0d21df2371d6d30fa2b8) `[get]` |
|  | Whether or not if this state is a screen/menu state for GUI. |
| bool | [Activated](class_tale_worlds_1_1_core_1_1_game_state.html#a1dabaff4645c2338168cdfed9f4bae95) `[get]` |
| Properties inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| string | [StringId](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8f7cc0266861eb249963e5ead3ab93f1) `[get, set]` |
| [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html) | [Id](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af97fbe63c015ee5f4958ab6946b7f69a) `[get, set]` |
| bool | [IsInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aa6b3602c7cfd678c75bf91e1c3073606) `[get]` |
| bool | [IsReady](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#abc67abca4d8d58d34835693808c0aa14) `[get, set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Attributes inherited from [TaleWorlds.Core.GameState](class_tale_worlds_1_1_core_1_1_game_state.html) | |
| int | [Level](class_tale_worlds_1_1_core_1_1_game_state.html#a257542858722d2e5d32b3f324c266c65) |
| Static Public Attributes inherited from [TaleWorlds.Core.GameState](class_tale_worlds_1_1_core_1_1_game_state.html) | |
| static int | [NumberOfListenerActivations](class_tale_worlds_1_1_core_1_1_game_state.html#abac4e06c768e9cb629baa328044896c9) |
| Protected Member Functions inherited from [TaleWorlds.Core.GameState](class_tale_worlds_1_1_core_1_1_game_state.html) | |
|  | [GameState](class_tale_worlds_1_1_core_1_1_game_state.html#ad748b43db56f0ccaeea076775562dea7) () |
| virtual void | [OnInitialize](class_tale_worlds_1_1_core_1_1_game_state.html#abdc3480ab7715670dbbac5567e1324bc) () |
| virtual void | [OnFinalize](class_tale_worlds_1_1_core_1_1_game_state.html#adad222707d0017cc15fef19e110b5e5a) () |
| virtual void | [OnActivate](class_tale_worlds_1_1_core_1_1_game_state.html#ae61931e69edd4b200e9a056d43790d5e) () |
| virtual void | [OnDeactivate](class_tale_worlds_1_1_core_1_1_game_state.html#afd0067e44f30e46870921923db1f5296) () |
| Protected Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| virtual void | [OnBeforeLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad32c7b22bd64e771cc05ee54ae78058a) () |
| virtual void | [PreAfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aeddc87ee0703c7f37d9129d9a5e024e4) () |
| virtual void | [AfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aae8a0aa22e7a659e1edbedfe9739d413) () |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_clan_state.html#a4c8393ae1d517146bf476f47fd38b3a3)ClanState() [1/6]
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.GameState.ClanState.ClanState | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_clan_state.html#a4305c801cbd4c30d7ecdf7b67665fc6e)ClanState() [2/6]
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.GameState.ClanState.ClanState | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *initialSelectedHero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_clan_state.html#a9b2c175f59889fd1831e663c69283f24)ClanState() [3/6]
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.GameState.ClanState.ClanState | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *initialSelectedParty* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_clan_state.html#aa3c83bef8a2044db9bf49d3f22e2d5fa)ClanState() [4/6]
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.GameState.ClanState.ClanState | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *initialSelectedSettlement* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_clan_state.html#aba35fc9cd51f7352315b44e139a56d62)ClanState() [5/6]
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.GameState.ClanState.ClanState | ( | [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) | *initialSelectedWorkshop* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_clan_state.html#a01ff88553d4787b5731b5fa14ab1bb8e)ClanState() [6/6]
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.GameState.ClanState.ClanState | ( | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | *initialSelectedAlley* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_clan_state.html#af0e397354cb673f8bfe179cf3d43e336)IsMenuState
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override bool TaleWorlds.CampaignSystem.GameState.ClanState.IsMenuState | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_clan_state.html#a8b3444cd23fee2951aae164133a3dec8)InitialSelectedHero
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.GameState.ClanState.InitialSelectedHero | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_clan_state.html#a6d144d3c04242ec71c834fa56e5bfcea)InitialSelectedParty
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) TaleWorlds.CampaignSystem.GameState.ClanState.InitialSelectedParty | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_clan_state.html#abd2938591d10c1dcc8c69ac2f9cc2ffc)InitialSelectedSettlement
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) TaleWorlds.CampaignSystem.GameState.ClanState.InitialSelectedSettlement | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_clan_state.html#a29001ae9bc6a2039961064a5dc8b8b0a)InitialSelectedWorkshop
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) TaleWorlds.CampaignSystem.GameState.ClanState.InitialSelectedWorkshop | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_clan_state.html#aa13d12339f1f273f763f409e2b16a84b)InitialSelectedAlley
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) TaleWorlds.CampaignSystem.GameState.ClanState.InitialSelectedAlley | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_clan_state.html#ae2d67e33b189c59662354eb8ffba12b4)Handler
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IClanStateHandler](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_clan_state_handler.html) TaleWorlds.CampaignSystem.GameState.ClanState.Handler | | getset |

