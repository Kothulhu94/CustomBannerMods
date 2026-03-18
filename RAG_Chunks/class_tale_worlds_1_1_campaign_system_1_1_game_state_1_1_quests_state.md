--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_quests_state.html ---

TaleWorlds.CampaignSystem.GameState.QuestsState Class ReferenceInherits [TaleWorlds.Core.GameState](class_tale_worlds_1_1_core_1_1_game_state.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [QuestsState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_quests_state.html#a70b1c30643ac3d20dc9eb55a5c9b830d) () |
|  | [QuestsState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_quests_state.html#a07880c76d92f90ec7f688fc3c05dc667) ([IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) initialSelectedIssue) |
|  | [QuestsState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_quests_state.html#a3e38e27a5dd2ff0ef7bbc73af0d9e53a) ([QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) initialSelectedQuest) |
|  | [QuestsState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_quests_state.html#a7deebb3abbb2758f13093dbc8afa28fd) ([JournalLogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_journal_log_entry.html) initialSelectedLog) |
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
| [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) | [InitialSelectedIssue](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_quests_state.html#a408c1c67c88139f7885f86f0d868c353) `[get]` |
| [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) | [InitialSelectedQuest](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_quests_state.html#af1b44a6e0d11027058536d111fa79aae) `[get]` |
| [JournalLogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_journal_log_entry.html) | [InitialSelectedLog](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_quests_state.html#afd8b516a25c5678ccb0424e9883066f3) `[get]` |
| override bool | [IsMenuState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_quests_state.html#a7412b768f460781b5fec13caf1867d9b) `[get]` |
| [IQuestsStateHandler](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_quests_state_handler.html) | [Handler](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_quests_state.html#ac17a941bace7e2d91aaff364fe907882) `[get, set]` |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_quests_state.html#a70b1c30643ac3d20dc9eb55a5c9b830d)QuestsState() [1/4]
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.GameState.QuestsState.QuestsState | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_quests_state.html#a07880c76d92f90ec7f688fc3c05dc667)QuestsState() [2/4]
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.GameState.QuestsState.QuestsState | ( | [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) | *initialSelectedIssue* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_quests_state.html#a3e38e27a5dd2ff0ef7bbc73af0d9e53a)QuestsState() [3/4]
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.GameState.QuestsState.QuestsState | ( | [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) | *initialSelectedQuest* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_quests_state.html#a7deebb3abbb2758f13093dbc8afa28fd)QuestsState() [4/4]
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.GameState.QuestsState.QuestsState | ( | [JournalLogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_journal_log_entry.html) | *initialSelectedLog* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_quests_state.html#a408c1c67c88139f7885f86f0d868c353)InitialSelectedIssue
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) TaleWorlds.CampaignSystem.GameState.QuestsState.InitialSelectedIssue | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_quests_state.html#af1b44a6e0d11027058536d111fa79aae)InitialSelectedQuest
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) TaleWorlds.CampaignSystem.GameState.QuestsState.InitialSelectedQuest | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_quests_state.html#afd8b516a25c5678ccb0424e9883066f3)InitialSelectedLog
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [JournalLogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_journal_log_entry.html) TaleWorlds.CampaignSystem.GameState.QuestsState.InitialSelectedLog | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_quests_state.html#a7412b768f460781b5fec13caf1867d9b)IsMenuState
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override bool TaleWorlds.CampaignSystem.GameState.QuestsState.IsMenuState | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_quests_state.html#ac17a941bace7e2d91aaff364fe907882)Handler
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IQuestsStateHandler](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_quests_state_handler.html) TaleWorlds.CampaignSystem.GameState.QuestsState.Handler | | getset |

