--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html ---

TaleWorlds.CampaignSystem.GameState.MenuContext Class ReferenceInherits [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [Refresh](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#a44a5e8a15ac2457f9c18531032a34824) () |
| void | [SwitchToMenu](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#ad76bb4824e909fcdbc6dd1dea7359f65) (string menuId) |
| void | [Destroy](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#aa35d5cb65d998d9fc8714856c9a9b48d) () |
| void | [OnTick](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#ae36c6f2e5cd61f8ad3602bc28aa9ecb1) (float dt) |
| void | [OnHourlyTick](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#adff71ddcd20b3c306b80eddb720e9ca6) () |
| Object | [GetCurrentRepeatableObject](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#a9c1bd0090c06ea7dee76a8829a5e855a) () |
| Object | [GetSelectedObject](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#a663542e14d037208b866e10edb69ddf1) () |
| Object | [GetSelectedRepeatableObject](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#a9e644e0be9099ccfc330b3f472a22f19) () |
| void | [SetRepeatObjectList](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#aa2012d3056f67d1c7d39165bfa60f51e) (IEnumerable< Object > list) |
| void | [OnConsequence](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#a60ee68a9d4cf6ba2c1aea470d46aa81d) ([GameMenuOption](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html) gameMenuOption) |
| void | [InvokeConsequence](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#a99be021645a3e0d5dba0b4b85e8b8d51) (int index) |
| void | [SetBackgroundMeshName](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#afcab1a410c0d2ab722bbfe43dc562ca5) (string name) |
| void | [SetPanelSound](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#a563fa4329a0fb169da377cb5ca76e53d) (string panelSoundID) |
| void | [SetAmbientSound](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#a2dd4fbc9e59e086ccec6fa182b1f561a) (string ambientSoundID) |
| void | [OpenTownManagement](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#aab89fa271f1d62bf453aa14fee52665d) () |
| void | [OpenRecruitVolunteers](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#a414a8a560ef0edcfe39d06076cd02b95) () |
| void | [OpenTournamentLeaderboards](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#a40e00672aa90cac4318c04fb7bd8de66) () |
| void | [OpenTroopSelection](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#a00875b8d486cd26f76200b6b772ad69c) ([TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) fullRoster, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) initialSelections, Func< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), bool > canChangeStatusOfTroop, Action< [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) > onDone, int maxSelectableTroopCount, int minSelectableTroopCount=1) |
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
| GameMenu | [GameMenu](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#a60db0ce1706b578a1f842dec24a87248) `[get]` |
| [IMenuContextHandler](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_menu_context_handler.html) | [Handler](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#a9a8158c41d602446888636f66b94f397) `[get, set]` |
| string | [CurrentBackgroundMeshName](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#a6ebcea7e8e6b160a420f84112cce2bfd) `[get]` |
| string | [CurrentAmbientSoundID](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#a186e81d228a81bf454da4030c1ab1082) `[get]` |
| string | [CurrentPanelSoundID](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#adfbbffa79f8b6911841037ad54bf6021) `[get]` |
| Properties inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| string | [StringId](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8f7cc0266861eb249963e5ead3ab93f1) `[get, set]` |
| [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html) | [Id](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af97fbe63c015ee5f4958ab6946b7f69a) `[get, set]` |
| bool | [IsInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aa6b3602c7cfd678c75bf91e1c3073606) `[get]` |
| bool | [IsReady](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#abc67abca4d8d58d34835693808c0aa14) `[get, set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Protected Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| virtual void | [OnBeforeLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad32c7b22bd64e771cc05ee54ae78058a) () |
| virtual void | [PreAfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aeddc87ee0703c7f37d9129d9a5e024e4) () |
| virtual void | [AfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aae8a0aa22e7a659e1edbedfe9739d413) () |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#a44a5e8a15ac2457f9c18531032a34824)Refresh()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.MenuContext.Refresh | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#ad76bb4824e909fcdbc6dd1dea7359f65)SwitchToMenu()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.MenuContext.SwitchToMenu | ( | string | *menuId* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#aa35d5cb65d998d9fc8714856c9a9b48d)Destroy()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.MenuContext.Destroy | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#ae36c6f2e5cd61f8ad3602bc28aa9ecb1)OnTick()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.MenuContext.OnTick | ( | float | *dt* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#adff71ddcd20b3c306b80eddb720e9ca6)OnHourlyTick()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.MenuContext.OnHourlyTick | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#a9c1bd0090c06ea7dee76a8829a5e855a)GetCurrentRepeatableObject()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| Object TaleWorlds.CampaignSystem.GameState.MenuContext.GetCurrentRepeatableObject | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#a663542e14d037208b866e10edb69ddf1)GetSelectedObject()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| Object TaleWorlds.CampaignSystem.GameState.MenuContext.GetSelectedObject | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#a9e644e0be9099ccfc330b3f472a22f19)GetSelectedRepeatableObject()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| Object TaleWorlds.CampaignSystem.GameState.MenuContext.GetSelectedRepeatableObject | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#aa2012d3056f67d1c7d39165bfa60f51e)SetRepeatObjectList()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.MenuContext.SetRepeatObjectList | ( | IEnumerable< Object > | *list* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#a60ee68a9d4cf6ba2c1aea470d46aa81d)OnConsequence()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.MenuContext.OnConsequence | ( | [GameMenuOption](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html) | *gameMenuOption* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#a99be021645a3e0d5dba0b4b85e8b8d51)InvokeConsequence()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.MenuContext.InvokeConsequence | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#afcab1a410c0d2ab722bbfe43dc562ca5)SetBackgroundMeshName()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.MenuContext.SetBackgroundMeshName | ( | string | *name* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#a563fa4329a0fb169da377cb5ca76e53d)SetPanelSound()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.MenuContext.SetPanelSound | ( | string | *panelSoundID* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#a2dd4fbc9e59e086ccec6fa182b1f561a)SetAmbientSound()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.MenuContext.SetAmbientSound | ( | string | *ambientSoundID* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#aab89fa271f1d62bf453aa14fee52665d)OpenTownManagement()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.MenuContext.OpenTownManagement | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#a414a8a560ef0edcfe39d06076cd02b95)OpenRecruitVolunteers()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.MenuContext.OpenRecruitVolunteers | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#a40e00672aa90cac4318c04fb7bd8de66)OpenTournamentLeaderboards()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.MenuContext.OpenTournamentLeaderboards | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#a00875b8d486cd26f76200b6b772ad69c)OpenTroopSelection()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameState.MenuContext.OpenTroopSelection | ( | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *fullRoster*, |
|  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *initialSelections*, |
|  |  | Func< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), bool > | *canChangeStatusOfTroop*, |
|  |  | Action< [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) > | *onDone*, |
|  |  | int | *maxSelectableTroopCount*, |
|  |  | int | *minSelectableTroopCount* = 1 ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#a60db0ce1706b578a1f842dec24a87248)GameMenu
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | GameMenu TaleWorlds.CampaignSystem.GameState.MenuContext.GameMenu | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#a9a8158c41d602446888636f66b94f397)Handler
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMenuContextHandler](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_menu_context_handler.html) TaleWorlds.CampaignSystem.GameState.MenuContext.Handler | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#a6ebcea7e8e6b160a420f84112cce2bfd)CurrentBackgroundMeshName
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.GameState.MenuContext.CurrentBackgroundMeshName | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#a186e81d228a81bf454da4030c1ab1082)CurrentAmbientSoundID
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.GameState.MenuContext.CurrentAmbientSoundID | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html#adfbbffa79f8b6911841037ad54bf6021)CurrentPanelSoundID
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.GameState.MenuContext.CurrentPanelSoundID | | get |

