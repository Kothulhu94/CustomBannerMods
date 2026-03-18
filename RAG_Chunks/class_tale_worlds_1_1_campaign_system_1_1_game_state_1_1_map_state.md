--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html ---

TaleWorlds.CampaignSystem.GameState.MapState Class ReferenceInherits [TaleWorlds.Core.GameState](class_tale_worlds_1_1_core_1_1_game_state.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [OnJoinArmy](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#aeb1443b43c3a05ee20a2812b0f7c5fa2) () |
| void | [OnLeaveArmy](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#a8cc9afa7c1905de19152a42d0c0c4e4a) () |
| void | [OnFadeInAndOut](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#a777e95b7ab498b00c2775fc4d32bb3c7) (float fadeOutTime, float blackTime, float fadeInTime) |
| void | [OnDispersePlayerLeadedArmy](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#af3761534c526137aa30aaf08a333915d) () |
| void | [OnArmyCreated](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#ab654129e47e6ed20d1ba1c7eecd1b4b1) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| void | [StartIncident](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#a2de4709b7af653c921bac58386950a0c) ([Incident](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html) incident) |
| void | [OnMainPartyEncounter](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#a543415b6f8e7dcb94d81d9840f364030) () |
| void | [ProcessTravel](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#a7ab9fe54f69647b547970fc7c730cb5a) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) moveTargetPoint) |
| void | [OnLoadingFinished](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#afeda300ca48900ea4844f49767715c41) () |
| void | [OnMapConversationStarts](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#a92aeff302283228a96da7a32f613eb83) ([ConversationCharacterData](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html) playerCharacterData, [ConversationCharacterData](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html) conversationPartnerData) |
| void | [OnMapConversationOver](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#a343fa4e23eb9311aae4390a5569e3e44) () |
| void | [EnterMenuMode](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#ac3a88b445996224abdf14400352a87c1) () |
| void | [ExitMenuMode](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#a96ca3d80f6c18d95bb4e3983f4361587) () |
| void | [StartBattleSimulation](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#a9818c738adfbc2cba018b3fbf79ebfa1) () |
| void | [EndBattleSimulation](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#a597cb1df1a2748b48709280c7bdd41c3) () |
| void | [OnPlayerSiegeActivated](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#a1d29eb1b63bcfd9d27b8e71a18e062cd) () |
| void | [OnPlayerSiegeDeactivated](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#a80fb75f7db66389ce7ad5f64232c2913) () |
| void | [OnSiegeEngineClick](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#a652aa068e2074afaeec3091a83b94ec6) ([MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) siegeEngineFrame) |
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
| Protected Member Functions | |
| override void | [OnIdleTick](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#ae2df756076dc0a24cf419018337ea432) (float dt) |
| override void | [OnTick](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#adfc00fa82fd5c628a6b06a98a7c0ac5d) (float dt) |
| override void | [OnActivate](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#ab12e677cee85cf76c41d462d4a480d2c) () |
| Protected Member Functions inherited from [TaleWorlds.Core.GameState](class_tale_worlds_1_1_core_1_1_game_state.html) | |
|  | [GameState](class_tale_worlds_1_1_core_1_1_game_state.html#ad748b43db56f0ccaeea076775562dea7) () |
| virtual void | [OnInitialize](class_tale_worlds_1_1_core_1_1_game_state.html#abdc3480ab7715670dbbac5567e1324bc) () |
| virtual void | [OnFinalize](class_tale_worlds_1_1_core_1_1_game_state.html#adad222707d0017cc15fef19e110b5e5a) () |
| virtual void | [OnDeactivate](class_tale_worlds_1_1_core_1_1_game_state.html#afd0067e44f30e46870921923db1f5296) () |
| Protected Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| virtual void | [OnBeforeLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad32c7b22bd64e771cc05ee54ae78058a) () |
| virtual void | [PreAfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aeddc87ee0703c7f37d9129d9a5e024e4) () |
| virtual void | [AfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aae8a0aa22e7a659e1edbedfe9739d413) () |

|  |  |
| --- | --- |
| Properties | |
| [Incident](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html) | [NextIncident](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#a3d69b108b9a94bfac9c36b5acc4786da) `[get, set]` |
| MenuContext | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#aea36c5502bdfb466c1fcbcd99ad2f268) `[get]` |
| string | [GameMenuId](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#afa25a67c2e7a6466def4580bb82d3b39) `[get, set]` |
| bool | [AtMenu](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#ae771d80b20ce2d65424f20f25dbb5b17) `[get]` |
| bool | [MapConversationActive](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#ac26fe6d5b5eb847dcf61fd9433ff6c12) `[get]` |
| [IMapStateHandler](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html) | [Handler](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#ad415b9c39203350cc137086c221afa08) `[get, set]` |
| bool | [IsSimulationActive](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#aa9c1640b752989d8860adb3b1dadb7b5) `[get]` |
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

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#ae2df756076dc0a24cf419018337ea432)OnIdleTick()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.GameState.MapState.OnIdleTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Core.GameState](class_tale_worlds_1_1_core_1_1_game_state.html).

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#aeb1443b43c3a05ee20a2812b0f7c5fa2)OnJoinArmy()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.MapState.OnJoinArmy | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#a8cc9afa7c1905de19152a42d0c0c4e4a)OnLeaveArmy()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.MapState.OnLeaveArmy | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#a777e95b7ab498b00c2775fc4d32bb3c7)OnFadeInAndOut()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.MapState.OnFadeInAndOut | ( | float | *fadeOutTime*, |
|  |  | float | *blackTime*, |
|  |  | float | *fadeInTime* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#af3761534c526137aa30aaf08a333915d)OnDispersePlayerLeadedArmy()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.MapState.OnDispersePlayerLeadedArmy | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#ab654129e47e6ed20d1ba1c7eecd1b4b1)OnArmyCreated()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.MapState.OnArmyCreated | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#a2de4709b7af653c921bac58386950a0c)StartIncident()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.MapState.StartIncident | ( | [Incident](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html) | *incident* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#a543415b6f8e7dcb94d81d9840f364030)OnMainPartyEncounter()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.MapState.OnMainPartyEncounter | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#a7ab9fe54f69647b547970fc7c730cb5a)ProcessTravel()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.MapState.ProcessTravel | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *moveTargetPoint* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#adfc00fa82fd5c628a6b06a98a7c0ac5d)OnTick()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.GameState.MapState.OnTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Core.GameState](class_tale_worlds_1_1_core_1_1_game_state.html).

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#afeda300ca48900ea4844f49767715c41)OnLoadingFinished()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.MapState.OnLoadingFinished | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#a92aeff302283228a96da7a32f613eb83)OnMapConversationStarts()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.MapState.OnMapConversationStarts | ( | [ConversationCharacterData](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html) | *playerCharacterData*, |
|  |  | [ConversationCharacterData](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html) | *conversationPartnerData* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#a343fa4e23eb9311aae4390a5569e3e44)OnMapConversationOver()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.MapState.OnMapConversationOver | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#ab12e677cee85cf76c41d462d4a480d2c)OnActivate()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.GameState.MapState.OnActivate | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Core.GameState](class_tale_worlds_1_1_core_1_1_game_state.html#ae61931e69edd4b200e9a056d43790d5e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#ac3a88b445996224abdf14400352a87c1)EnterMenuMode()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.MapState.EnterMenuMode | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#a96ca3d80f6c18d95bb4e3983f4361587)ExitMenuMode()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.MapState.ExitMenuMode | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#a9818c738adfbc2cba018b3fbf79ebfa1)StartBattleSimulation()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.MapState.StartBattleSimulation | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#a597cb1df1a2748b48709280c7bdd41c3)EndBattleSimulation()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.MapState.EndBattleSimulation | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#a1d29eb1b63bcfd9d27b8e71a18e062cd)OnPlayerSiegeActivated()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.MapState.OnPlayerSiegeActivated | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#a80fb75f7db66389ce7ad5f64232c2913)OnPlayerSiegeDeactivated()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.MapState.OnPlayerSiegeDeactivated | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#a652aa068e2074afaeec3091a83b94ec6)OnSiegeEngineClick()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.MapState.OnSiegeEngineClick | ( | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *siegeEngineFrame* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#a3d69b108b9a94bfac9c36b5acc4786da)NextIncident
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Incident](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html) TaleWorlds.CampaignSystem.GameState.MapState.NextIncident | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#aea36c5502bdfb466c1fcbcd99ad2f268)MenuContext
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MenuContext TaleWorlds.CampaignSystem.GameState.MapState.MenuContext | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#afa25a67c2e7a6466def4580bb82d3b39)GameMenuId
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.GameState.MapState.GameMenuId | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#ae771d80b20ce2d65424f20f25dbb5b17)AtMenu
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.GameState.MapState.AtMenu | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#ac26fe6d5b5eb847dcf61fd9433ff6c12)MapConversationActive
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.GameState.MapState.MapConversationActive | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#ad415b9c39203350cc137086c221afa08)Handler
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMapStateHandler](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html) TaleWorlds.CampaignSystem.GameState.MapState.Handler | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#aa9c1640b752989d8860adb3b1dadb7b5)IsSimulationActive
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.GameState.MapState.IsSimulationActive | | get |

