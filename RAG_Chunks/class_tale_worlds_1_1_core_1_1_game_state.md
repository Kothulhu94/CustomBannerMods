--- SOURCE: class_tale_worlds_1_1_core_1_1_game_state.html ---

TaleWorlds.Core.GameState Class ReferenceabstractInherits [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html).

Inherited by [TaleWorlds.CampaignSystem.GameState.BannerEditorState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_banner_editor_state.html), [TaleWorlds.CampaignSystem.GameState.BarberState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_barber_state.html), [TaleWorlds.CampaignSystem.GameState.CharacterDeveloperState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_character_developer_state.html), [TaleWorlds.CampaignSystem.GameState.ClanState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_clan_state.html), [TaleWorlds.CampaignSystem.GameState.CraftingState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_crafting_state.html), [TaleWorlds.CampaignSystem.GameState.EducationState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_education_state.html), [TaleWorlds.CampaignSystem.GameState.GameOverState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_game_over_state.html), [TaleWorlds.CampaignSystem.GameState.KingdomState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_kingdom_state.html), [TaleWorlds.CampaignSystem.GameState.MapState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html), [TaleWorlds.CampaignSystem.GameState.PortState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_port_state.html), [TaleWorlds.CampaignSystem.GameState.QuestsState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_quests_state.html), [TaleWorlds.CampaignSystem.GameState.TutorialState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_tutorial_state.html), [TaleWorlds.Core.PlayerGameState](class_tale_worlds_1_1_core_1_1_player_game_state.html), [TaleWorlds.MountAndBlade.BannerBuilderState](class_tale_worlds_1_1_mount_and_blade_1_1_banner_builder_state.html), [TaleWorlds.MountAndBlade.EditorState](class_tale_worlds_1_1_mount_and_blade_1_1_editor_state.html), [TaleWorlds.MountAndBlade.GameLoadingState](class_tale_worlds_1_1_mount_and_blade_1_1_game_loading_state.html), [TaleWorlds.MountAndBlade.InitialState](class_tale_worlds_1_1_mount_and_blade_1_1_initial_state.html), [TaleWorlds.MountAndBlade.MissionState](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html), [TaleWorlds.MountAndBlade.ProfileSelectionState](class_tale_worlds_1_1_mount_and_blade_1_1_profile_selection_state.html), [TaleWorlds.MountAndBlade.UnspecifiedDedicatedServerState](class_tale_worlds_1_1_mount_and_blade_1_1_unspecified_dedicated_server_state.html), and [TaleWorlds.MountAndBlade.VideoPlaybackState](class_tale_worlds_1_1_mount_and_blade_1_1_video_playback_state.html).

|  |  |
| --- | --- |
| Public Member Functions | |
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
| int | [Level](class_tale_worlds_1_1_core_1_1_game_state.html#a257542858722d2e5d32b3f324c266c65) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static int | [NumberOfListenerActivations](class_tale_worlds_1_1_core_1_1_game_state.html#abac4e06c768e9cb629baa328044896c9) |

|  |  |
| --- | --- |
| Protected Member Functions | |
|  | [GameState](class_tale_worlds_1_1_core_1_1_game_state.html#ad748b43db56f0ccaeea076775562dea7) () |
| virtual void | [OnInitialize](class_tale_worlds_1_1_core_1_1_game_state.html#abdc3480ab7715670dbbac5567e1324bc) () |
| virtual void | [OnFinalize](class_tale_worlds_1_1_core_1_1_game_state.html#adad222707d0017cc15fef19e110b5e5a) () |
| virtual void | [OnActivate](class_tale_worlds_1_1_core_1_1_game_state.html#ae61931e69edd4b200e9a056d43790d5e) () |
| virtual void | [OnDeactivate](class_tale_worlds_1_1_core_1_1_game_state.html#afd0067e44f30e46870921923db1f5296) () |
| Protected Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| virtual void | [OnBeforeLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad32c7b22bd64e771cc05ee54ae78058a) () |
| virtual void | [PreAfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aeddc87ee0703c7f37d9129d9a5e024e4) () |
| virtual void | [AfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aae8a0aa22e7a659e1edbedfe9739d413) () |

|  |  |
| --- | --- |
| Properties | |
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

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_core_1_1_game_state.html#ad748b43db56f0ccaeea076775562dea7)GameState()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | TaleWorlds.Core.GameState.GameState | ( |  | ) |  | | protected |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_game_state.html#a5de0596109748cd2cc9cfa28959f8f96)RegisterListener()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Core.GameState.RegisterListener | ( | [IGameStateListener](interface_tale_worlds_1_1_core_1_1_i_game_state_listener.html) | *listener* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_game_state.html#ae56aad1d9d2a21f72df2302e198c993a)UnregisterListener()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Core.GameState.UnregisterListener | ( | [IGameStateListener](interface_tale_worlds_1_1_core_1_1_i_game_state_listener.html) | *listener* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_game_state.html#a6c13c32468bbc05927f4b592c7682b47)GetListenerOfType< T >()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| T TaleWorlds.Core.GameState.GetListenerOfType< T > | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_game_state.html#abdc3480ab7715670dbbac5567e1324bc)OnInitialize()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.Core.GameState.OnInitialize | ( |  | ) |  | | protectedvirtual |

Reimplemented in [TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationState](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_state.html#afa668b5a4997d3ba911d4f33aa5d86c7), and [TaleWorlds.MountAndBlade.MissionState](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html#a2f4cb37108b5faf8cde57f15995b525f).

[◆](class_tale_worlds_1_1_core_1_1_game_state.html#adad222707d0017cc15fef19e110b5e5a)OnFinalize()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.Core.GameState.OnFinalize | ( |  | ) |  | | protectedvirtual |

Reimplemented in [TaleWorlds.CampaignSystem.GameState.BannerEditorState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_banner_editor_state.html#a57546c4ebe6e8edec4f7727a42649e4f), [TaleWorlds.CampaignSystem.GameState.PortState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_port_state.html#a4723f501579120787b9d1ec201f145bb), [TaleWorlds.CampaignSystem.GameState.TutorialState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_tutorial_state.html#afc57eb800fa79133bab0f316cf36adfe), [TaleWorlds.MountAndBlade.BannerBuilderState](class_tale_worlds_1_1_mount_and_blade_1_1_banner_builder_state.html#aac0431c5bbbcc344a44118632d10ff44), [TaleWorlds.MountAndBlade.EditorState](class_tale_worlds_1_1_mount_and_blade_1_1_editor_state.html#a4e87aa6ab7f3c0aace0dac7df253890e), and [TaleWorlds.MountAndBlade.MissionState](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html#a1b518e38cb5bebe2a7a8f9e188e4bb80).

[◆](class_tale_worlds_1_1_core_1_1_game_state.html#ae61931e69edd4b200e9a056d43790d5e)OnActivate()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.Core.GameState.OnActivate | ( |  | ) |  | | protectedvirtual |

Reimplemented in [TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationState](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_state.html#a10d046b12e84c3e43c8674437362cf09), [TaleWorlds.CampaignSystem.GameState.MapState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html#ab12e677cee85cf76c41d462d4a480d2c), [TaleWorlds.CampaignSystem.GameState.TutorialState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_tutorial_state.html#a622d9f361198f1086f1b2b6a51a0782c), [TaleWorlds.MountAndBlade.BannerBuilderState](class_tale_worlds_1_1_mount_and_blade_1_1_banner_builder_state.html#a7458e5b605e6e8e7c8818220d6afcbb9), [TaleWorlds.MountAndBlade.EditorState](class_tale_worlds_1_1_mount_and_blade_1_1_editor_state.html#a8109befe7f8a181ce4d636e51a32d131), [TaleWorlds.MountAndBlade.InitialState](class_tale_worlds_1_1_mount_and_blade_1_1_initial_state.html#a464162a5767bbf017560861307f7a5d0), and [TaleWorlds.MountAndBlade.MissionState](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html#ac58e91dec194b4027b02976876a3929c).

[◆](class_tale_worlds_1_1_core_1_1_game_state.html#afd0067e44f30e46870921923db1f5296)OnDeactivate()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.Core.GameState.OnDeactivate | ( |  | ) |  | | protectedvirtual |

Reimplemented in [TaleWorlds.MountAndBlade.MissionState](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html#a7962b0eb6473bac8fd786d30db63b4ff).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_core_1_1_game_state.html#a257542858722d2e5d32b3f324c266c65)Level
------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.Core.GameState.Level |

[◆](class_tale_worlds_1_1_core_1_1_game_state.html#abac4e06c768e9cb629baa328044896c9)NumberOfListenerActivations
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.GameState.NumberOfListenerActivations | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_game_state.html#a8c58eba46626705436b1f6e6438fe4b3)Predecessor
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GameState](class_tale_worlds_1_1_core_1_1_game_state.html#ad748b43db56f0ccaeea076775562dea7) TaleWorlds.Core.GameState.Predecessor | | get |

[◆](class_tale_worlds_1_1_core_1_1_game_state.html#ae98283dc0dbf0a4a7ac2f2703df0556a)IsActive
---------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.GameState.IsActive | | get |

[◆](class_tale_worlds_1_1_core_1_1_game_state.html#a169c050b0c9fc4f75ebc22077e0e1dcc)Listeners
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IReadOnlyCollection<[IGameStateListener](interface_tale_worlds_1_1_core_1_1_i_game_state_listener.html)> TaleWorlds.Core.GameState.Listeners | | get |

[◆](class_tale_worlds_1_1_core_1_1_game_state.html#a49046697eb0faecb2ae348a9fb53164c)GameStateManager
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | GameStateManager TaleWorlds.Core.GameState.GameStateManager | | get |

[◆](class_tale_worlds_1_1_core_1_1_game_state.html#af8d01b71fa319594b32292b3cbb5f353)IsMusicMenuState
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual bool TaleWorlds.Core.GameState.IsMusicMenuState | | get |

[◆](class_tale_worlds_1_1_core_1_1_game_state.html#ac5c37d14282c0d21df2371d6d30fa2b8)IsMenuState
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual bool TaleWorlds.Core.GameState.IsMenuState | | get |

[◆](class_tale_worlds_1_1_core_1_1_game_state.html#a1dabaff4645c2338168cdfed9f4bae95)Activated
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.GameState.Activated | | get |

