--- SOURCE: class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_conversation_view.html ---

SandBox.GauntletUI.Map.GauntletMapConversationView Class ReferenceInherits [SandBox.View.Map.MapConversationView](class_sand_box_1_1_view_1_1_map_1_1_map_conversation_view.html), and [TaleWorlds.CampaignSystem.Conversation.IConversationStateHandler](interface_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_i_conversation_state_handler.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [GauntletMapConversationView](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_conversation_view.html#a15a4dbd1784cf174538d6f999d31202a) () |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [InitializeConversation](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_conversation_view.html#ace91d46c4dcbf7912b529923416a53b0) ([ConversationCharacterData](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html) playerCharacterData, [ConversationCharacterData](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html) conversationPartnerData) |
| override void | [FinalizeConversation](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_conversation_view.html#a3b6c20c7fb116ee014aa9a9114aa7114) () |
| override void | [OnActivate](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_conversation_view.html#a18b992eea3de8200cd33863e6fab2e47) () |
| override void | [OnDeactivate](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_conversation_view.html#ad0ff5b09db6dd827f9450ade79d9cdb0) () |
| override void | [OnFinalize](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_conversation_view.html#a9ab76ba7f196f392d60ec4abf8a93fc0) () |
| override bool | [IsEscaped](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_conversation_view.html#abf36909a0c1664d51ba633332a43bfc2) () |
| override bool | [IsOpeningEscapeMenuOnFocusChangeAllowed](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_conversation_view.html#a6a085feb497849139a1efa2b12ab05f7) () |
| override void | [OnFrameTick](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_conversation_view.html#a642a4a5173906e7376c3270fcd4da1d9) (float dt) |
| override void | [OnIdleTick](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_conversation_view.html#a6d76113f9b9d256ef8596d6253b2cd81) (float dt) |
| override void | [OnMenuModeTick](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_conversation_view.html#a6a8f1493dbc1c7ef1170f2ad72a7af8f) (float dt) |
| Protected Member Functions inherited from [SandBox.View.Map.MapConversationView](class_sand_box_1_1_view_1_1_map_1_1_map_conversation_view.html) | |
| void | [CreateConversationMissionIfMissing](class_sand_box_1_1_view_1_1_map_1_1_map_conversation_view.html#a10639dda43b27227e70d151fb684781a) () |
| void | [DestroyConversationMission](class_sand_box_1_1_view_1_1_map_1_1_map_conversation_view.html#a1b253883407b323a1116ef08794f9400) () |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Attributes inherited from [SandBox.View.Map.MapConversationView](class_sand_box_1_1_view_1_1_map_1_1_map_conversation_view.html) | |
| [MapConversationMission](class_sand_box_1_1_view_1_1_map_1_1_map_conversation_view_1_1_map_conversation_mission.html) | [ConversationMission](class_sand_box_1_1_view_1_1_map_1_1_map_conversation_view.html#a0a5bbcd85971260c99f799c7d08b87c1) |
| Static Protected Attributes inherited from [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html) | |
| const float | [ContextAlphaModifier](class_sand_box_1_1_view_1_1_map_1_1_map_view.html#a9efbb55b721c1331986ba14d416c84f6) = 8.5f |
| Properties inherited from [SandBox.View.Map.MapConversationView](class_sand_box_1_1_view_1_1_map_1_1_map_conversation_view.html) | |
| bool | [IsConversationActive](class_sand_box_1_1_view_1_1_map_1_1_map_conversation_view.html#a509804889fe54a41474fca4b45181908) `[get, protected set]` |
| Properties inherited from [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html) | |
| MapScreen | [MapScreen](class_sand_box_1_1_view_1_1_map_1_1_map_view.html#af4f77c9eec549e6d57cb4667f09ea0b4) `[get]` |
| MapState | [MapState](class_sand_box_1_1_view_1_1_map_1_1_map_view.html#abf6624dfb0331164523cae87d042e691) `[get]` |
| Properties inherited from [SandBox.View.SandboxView](class_sand_box_1_1_view_1_1_sandbox_view.html) | |
| bool | [IsFinalized](class_sand_box_1_1_view_1_1_sandbox_view.html#a5807fb2c109c6715d7fae1a6cf2f4693) `[get, protected set]` |
| ScreenLayer | [Layer](class_sand_box_1_1_view_1_1_sandbox_view.html#a070dec1267ecf8ff4afadffc12374024) `[get, protected set]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_conversation_view.html#a15a4dbd1784cf174538d6f999d31202a)GauntletMapConversationView()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| SandBox.GauntletUI.Map.GauntletMapConversationView.GauntletMapConversationView | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_conversation_view.html#ace91d46c4dcbf7912b529923416a53b0)InitializeConversation()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void SandBox.GauntletUI.Map.GauntletMapConversationView.InitializeConversation | ( | [ConversationCharacterData](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html) | *playerCharacterData*, | |  |  | [ConversationCharacterData](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html) | *conversationPartnerData* ) | | protectedvirtual |

Reimplemented from [SandBox.View.Map.MapConversationView](class_sand_box_1_1_view_1_1_map_1_1_map_conversation_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_conversation_view.html#a3b6c20c7fb116ee014aa9a9114aa7114)FinalizeConversation()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Map.GauntletMapConversationView.FinalizeConversation | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Map.MapConversationView](class_sand_box_1_1_view_1_1_map_1_1_map_conversation_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_conversation_view.html#a18b992eea3de8200cd33863e6fab2e47)OnActivate()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Map.GauntletMapConversationView.OnActivate | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.SandboxView](class_sand_box_1_1_view_1_1_sandbox_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_conversation_view.html#ad0ff5b09db6dd827f9450ade79d9cdb0)OnDeactivate()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Map.GauntletMapConversationView.OnDeactivate | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.SandboxView](class_sand_box_1_1_view_1_1_sandbox_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_conversation_view.html#a9ab76ba7f196f392d60ec4abf8a93fc0)OnFinalize()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Map.GauntletMapConversationView.OnFinalize | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.SandboxView](class_sand_box_1_1_view_1_1_sandbox_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_conversation_view.html#abf36909a0c1664d51ba633332a43bfc2)IsEscaped()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override bool SandBox.GauntletUI.Map.GauntletMapConversationView.IsEscaped | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_conversation_view.html#a6a085feb497849139a1efa2b12ab05f7)IsOpeningEscapeMenuOnFocusChangeAllowed()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override bool SandBox.GauntletUI.Map.GauntletMapConversationView.IsOpeningEscapeMenuOnFocusChangeAllowed | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_conversation_view.html#a642a4a5173906e7376c3270fcd4da1d9)OnFrameTick()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Map.GauntletMapConversationView.OnFrameTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.SandboxView](class_sand_box_1_1_view_1_1_sandbox_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_conversation_view.html#a6d76113f9b9d256ef8596d6253b2cd81)OnIdleTick()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Map.GauntletMapConversationView.OnIdleTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_conversation_view.html#a6a8f1493dbc1c7ef1170f2ad72a7af8f)OnMenuModeTick()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Map.GauntletMapConversationView.OnMenuModeTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html).

