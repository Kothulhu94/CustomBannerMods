--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_state.html ---

TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationState Class ReferenceInherits [TaleWorlds.Core.PlayerGameState](class_tale_worlds_1_1_core_1_1_player_game_state.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [CharacterCreationState](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_state.html#a9e98249ee47cb8297a9ec2cc578bcabc) () |
| void | [FinalizeCharacterCreationState](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_state.html#afd41ac9ea0bd80f8debe3f703dc105da) () |
| void | [Refresh](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_state.html#a2afba864261bd8cc39d1ab1861f1924f) () |
| void | [OnStageActivated](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_state.html#a0dca47b4d1bd2c8d0526948af2d83913) ([CharacterCreationStageBase](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_stage_base.html) stage) |
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
| override void | [OnInitialize](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_state.html#afa668b5a4997d3ba911d4f33aa5d86c7) () |
| override void | [OnActivate](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_state.html#a10d046b12e84c3e43c8674437362cf09) () |
| Protected Member Functions inherited from [TaleWorlds.Core.GameState](class_tale_worlds_1_1_core_1_1_game_state.html) | |
|  | [GameState](class_tale_worlds_1_1_core_1_1_game_state.html#ad748b43db56f0ccaeea076775562dea7) () |
| virtual void | [OnFinalize](class_tale_worlds_1_1_core_1_1_game_state.html#adad222707d0017cc15fef19e110b5e5a) () |
| virtual void | [OnDeactivate](class_tale_worlds_1_1_core_1_1_game_state.html#afd0067e44f30e46870921923db1f5296) () |
| Protected Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| virtual void | [OnBeforeLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad32c7b22bd64e771cc05ee54ae78058a) () |
| virtual void | [PreAfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aeddc87ee0703c7f37d9129d9a5e024e4) () |
| virtual void | [AfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aae8a0aa22e7a659e1edbedfe9739d413) () |

|  |  |
| --- | --- |
| Properties | |
| CharacterCreationManager | [CharacterCreationManager](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_state.html#a867c310fb5581b2350af93b9c30ba66d) `[get]` |
| [ICharacterCreationStateHandler](interface_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_i_character_creation_state_handler.html) | [Handler](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_state.html#a894852386d3ce68c1302aca441964746) `[get, set]` |
| Properties inherited from [TaleWorlds.Core.PlayerGameState](class_tale_worlds_1_1_core_1_1_player_game_state.html) | |
| [VirtualPlayer](class_tale_worlds_1_1_core_1_1_virtual_player.html) | [Peer](class_tale_worlds_1_1_core_1_1_player_game_state.html#a3830c21b4f1171490e3462e657e66594) `[get]` |
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

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_state.html#a9e98249ee47cb8297a9ec2cc578bcabc)CharacterCreationState()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationState.CharacterCreationState | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_state.html#afa668b5a4997d3ba911d4f33aa5d86c7)OnInitialize()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationState.OnInitialize | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Core.GameState](class_tale_worlds_1_1_core_1_1_game_state.html#abdc3480ab7715670dbbac5567e1324bc).

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_state.html#a10d046b12e84c3e43c8674437362cf09)OnActivate()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationState.OnActivate | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Core.GameState](class_tale_worlds_1_1_core_1_1_game_state.html#ae61931e69edd4b200e9a056d43790d5e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_state.html#afd41ac9ea0bd80f8debe3f703dc105da)FinalizeCharacterCreationState()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationState.FinalizeCharacterCreationState | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_state.html#a2afba864261bd8cc39d1ab1861f1924f)Refresh()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationState.Refresh | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_state.html#a0dca47b4d1bd2c8d0526948af2d83913)OnStageActivated()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationState.OnStageActivated | ( | [CharacterCreationStageBase](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_stage_base.html) | *stage* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_state.html#a867c310fb5581b2350af93b9c30ba66d)CharacterCreationManager
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | CharacterCreationManager TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationState.CharacterCreationManager | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_state.html#a894852386d3ce68c1302aca441964746)Handler
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ICharacterCreationStateHandler](interface_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_i_character_creation_state_handler.html) TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationState.Handler | | getset |

