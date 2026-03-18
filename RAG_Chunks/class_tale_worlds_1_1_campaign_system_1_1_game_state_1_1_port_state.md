--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_port_state.html ---

TaleWorlds.CampaignSystem.GameState.PortState Class ReferenceInherits [TaleWorlds.Core.GameState](class_tale_worlds_1_1_core_1_1_game_state.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [PortState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_port_state.html#a70ffc4c93b23f59b895dc01209deff6d) () |
|  | [PortState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_port_state.html#a0d750dfab9ea646b81ab9ae27879c614) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) leftOwner, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) rightOwner, [PortScreenModes](namespace_tale_worlds_1_1_campaign_system_1_1_game_state.html#af89d7f67d4947bfd52b5dc0451cce578) portScreenMode) |
|  | [PortState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_port_state.html#a59ccd4b2a5a35d68b2ddddcce0a90005) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) leftOwner, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) rightOwner, Action onEndAction, [PortScreenModes](namespace_tale_worlds_1_1_campaign_system_1_1_game_state.html#af89d7f67d4947bfd52b5dc0451cce578) portScreenMode) |
|  | [PortState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_port_state.html#ae781cab18dfb408f4d7339efda736c08) (MBReadOnlyList< [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) > leftShips, MBReadOnlyList< [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) > rightShips, [PortScreenModes](namespace_tale_worlds_1_1_campaign_system_1_1_game_state.html#af89d7f67d4947bfd52b5dc0451cce578) portScreenMode) |
|  | [PortState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_port_state.html#af0c38da4c3ae7b12644dea83e890a4e1) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) leftOwner, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) rightOwner, MBReadOnlyList< [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) > leftShips, MBReadOnlyList< [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) > rightShips, [PortScreenModes](namespace_tale_worlds_1_1_campaign_system_1_1_game_state.html#af89d7f67d4947bfd52b5dc0451cce578) portScreenMode) |
|  | [PortState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_port_state.html#a1cfb8ca0c32b47ed6ae494838c70ca7f) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) rightOwner, [PortScreenModes](namespace_tale_worlds_1_1_campaign_system_1_1_game_state.html#af89d7f67d4947bfd52b5dc0451cce578) portScreenMode) |
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
| Public Attributes | |
| readonly [PortScreenModes](namespace_tale_worlds_1_1_campaign_system_1_1_game_state.html#af89d7f67d4947bfd52b5dc0451cce578) | [PortScreenMode](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_port_state.html#a466db30fa1cbb6a11b1a0e367de1af33) |
| readonly [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | [LeftOwner](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_port_state.html#a50c589ae8b67464344ca30e446e4a883) |
| readonly [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | [RightOwner](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_port_state.html#a803d29644fe312e9207ee71a48e9b241) |
| readonly MBReadOnlyList< [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) > | [LeftShips](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_port_state.html#a888d337ed4042ba7402e70f726a9eb8d) |
| readonly MBReadOnlyList< [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) > | [RightShips](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_port_state.html#adfb850260e18be278c39dfac3a6299b9) |
| readonly Action | [OnEndAction](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_port_state.html#a7715243a843294dd40fc88fb5ce5a68f) |
| Public Attributes inherited from [TaleWorlds.Core.GameState](class_tale_worlds_1_1_core_1_1_game_state.html) | |
| int | [Level](class_tale_worlds_1_1_core_1_1_game_state.html#a257542858722d2e5d32b3f324c266c65) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_port_state.html#a4723f501579120787b9d1ec201f145bb) () |
| Protected Member Functions inherited from [TaleWorlds.Core.GameState](class_tale_worlds_1_1_core_1_1_game_state.html) | |
|  | [GameState](class_tale_worlds_1_1_core_1_1_game_state.html#ad748b43db56f0ccaeea076775562dea7) () |
| virtual void | [OnInitialize](class_tale_worlds_1_1_core_1_1_game_state.html#abdc3480ab7715670dbbac5567e1324bc) () |
| virtual void | [OnActivate](class_tale_worlds_1_1_core_1_1_game_state.html#ae61931e69edd4b200e9a056d43790d5e) () |
| virtual void | [OnDeactivate](class_tale_worlds_1_1_core_1_1_game_state.html#afd0067e44f30e46870921923db1f5296) () |
| Protected Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| virtual void | [OnBeforeLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad32c7b22bd64e771cc05ee54ae78058a) () |
| virtual void | [PreAfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aeddc87ee0703c7f37d9129d9a5e024e4) () |
| virtual void | [AfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aae8a0aa22e7a659e1edbedfe9739d413) () |

|  |  |
| --- | --- |
| Properties | |
| static bool | [IsCheatMode](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_port_state.html#a5966063b4c10ed17b66268980e63aa43) `[get, set]` |
| override bool | [IsMenuState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_port_state.html#a63637fb120ac00dbd1aff4ebf2ea324f) `[get]` |
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
| Static Public Attributes inherited from [TaleWorlds.Core.GameState](class_tale_worlds_1_1_core_1_1_game_state.html) | |
| static int | [NumberOfListenerActivations](class_tale_worlds_1_1_core_1_1_game_state.html#abac4e06c768e9cb629baa328044896c9) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_port_state.html#a70ffc4c93b23f59b895dc01209deff6d)PortState() [1/6]
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.GameState.PortState.PortState | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_port_state.html#a0d750dfab9ea646b81ab9ae27879c614)PortState() [2/6]
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.GameState.PortState.PortState | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *leftOwner*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *rightOwner*, |
|  |  | [PortScreenModes](namespace_tale_worlds_1_1_campaign_system_1_1_game_state.html#af89d7f67d4947bfd52b5dc0451cce578) | *portScreenMode* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_port_state.html#a59ccd4b2a5a35d68b2ddddcce0a90005)PortState() [3/6]
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.GameState.PortState.PortState | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *leftOwner*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *rightOwner*, |
|  |  | Action | *onEndAction*, |
|  |  | [PortScreenModes](namespace_tale_worlds_1_1_campaign_system_1_1_game_state.html#af89d7f67d4947bfd52b5dc0451cce578) | *portScreenMode* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_port_state.html#ae781cab18dfb408f4d7339efda736c08)PortState() [4/6]
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.GameState.PortState.PortState | ( | MBReadOnlyList< [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) > | *leftShips*, |
|  |  | MBReadOnlyList< [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) > | *rightShips*, |
|  |  | [PortScreenModes](namespace_tale_worlds_1_1_campaign_system_1_1_game_state.html#af89d7f67d4947bfd52b5dc0451cce578) | *portScreenMode* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_port_state.html#af0c38da4c3ae7b12644dea83e890a4e1)PortState() [5/6]
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.GameState.PortState.PortState | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *leftOwner*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *rightOwner*, |
|  |  | MBReadOnlyList< [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) > | *leftShips*, |
|  |  | MBReadOnlyList< [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) > | *rightShips*, |
|  |  | [PortScreenModes](namespace_tale_worlds_1_1_campaign_system_1_1_game_state.html#af89d7f67d4947bfd52b5dc0451cce578) | *portScreenMode* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_port_state.html#a1cfb8ca0c32b47ed6ae494838c70ca7f)PortState() [6/6]
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.GameState.PortState.PortState | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *rightOwner*, |
|  |  | [PortScreenModes](namespace_tale_worlds_1_1_campaign_system_1_1_game_state.html#af89d7f67d4947bfd52b5dc0451cce578) | *portScreenMode* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_port_state.html#a4723f501579120787b9d1ec201f145bb)OnFinalize()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.GameState.PortState.OnFinalize | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Core.GameState](class_tale_worlds_1_1_core_1_1_game_state.html#adad222707d0017cc15fef19e110b5e5a).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_port_state.html#a466db30fa1cbb6a11b1a0e367de1af33)PortScreenMode
-----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [PortScreenModes](namespace_tale_worlds_1_1_campaign_system_1_1_game_state.html#af89d7f67d4947bfd52b5dc0451cce578) TaleWorlds.CampaignSystem.GameState.PortState.PortScreenMode |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_port_state.html#a50c589ae8b67464344ca30e446e4a883)LeftOwner
------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) TaleWorlds.CampaignSystem.GameState.PortState.LeftOwner |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_port_state.html#a803d29644fe312e9207ee71a48e9b241)RightOwner
-------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) TaleWorlds.CampaignSystem.GameState.PortState.RightOwner |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_port_state.html#a888d337ed4042ba7402e70f726a9eb8d)LeftShips
------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly MBReadOnlyList<[Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html)> TaleWorlds.CampaignSystem.GameState.PortState.LeftShips |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_port_state.html#adfb850260e18be278c39dfac3a6299b9)RightShips
-------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly MBReadOnlyList<[Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html)> TaleWorlds.CampaignSystem.GameState.PortState.RightShips |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_port_state.html#a7715243a843294dd40fc88fb5ce5a68f)OnEndAction
--------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly Action TaleWorlds.CampaignSystem.GameState.PortState.OnEndAction |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_port_state.html#a5966063b4c10ed17b66268980e63aa43)IsCheatMode
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.GameState.PortState.IsCheatMode | | staticgetset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_port_state.html#a63637fb120ac00dbd1aff4ebf2ea324f)IsMenuState
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override bool TaleWorlds.CampaignSystem.GameState.PortState.IsMenuState | | get |

