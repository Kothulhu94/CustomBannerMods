--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_wait_menu_option.html ---

TaleWorlds.CampaignSystem.GameMenus.WaitMenuOption Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
| delegate bool | [OnConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_wait_menu_option.html#aa7859be17333c9fa73e8e539ee590dbe) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| delegate void | [OnConsequenceDelegate](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_wait_menu_option.html#a4a6c4fbd400f2a259138fc51a2a769e3) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| bool | [GetConditionsHold](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_wait_menu_option.html#a8ba5173aaf5102327effda5add66972d) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game, [MapState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html) mapState) |
| void | [RunConsequence](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_wait_menu_option.html#a2c4e1dab84588c7ae787f3b89e9aaf99) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game, [MapState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html) mapState) |
| void | [Deserialize](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_wait_menu_option.html#acedc829133ffcfbaaad4cd05379dc6b5) (XmlNode node, Type typeOfWaitMenusCallbacks) |

|  |  |
| --- | --- |
| Public Attributes | |
| [OnConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_wait_menu_option.html#aa7859be17333c9fa73e8e539ee590dbe) | [OnCondition](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_wait_menu_option.html#a0ac77989559a1e4ac4a9f8d4c4f2aae4) |
| [OnConsequenceDelegate](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_wait_menu_option.html#a4a6c4fbd400f2a259138fc51a2a769e3) | [OnConsequence](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_wait_menu_option.html#a2376c167a3937c37dc5b5533eba835fe) |

|  |  |
| --- | --- |
| Properties | |
| int | [Priority](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_wait_menu_option.html#ad50d58fb9b19cb06abc4e9935ab9a5d3) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Text](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_wait_menu_option.html#a9beedcdb639720caec004854c564ec05) `[get]` |
| string | [IdString](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_wait_menu_option.html#a74964b2352563e724c4e38ab97405e5a) `[get]` |
| string | [Tooltip](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_wait_menu_option.html#ab472e2ffc177cc199b66e2ba7d6ba15a) `[get]` |
| bool | [IsLeave](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_wait_menu_option.html#ad3e509e46b8e52b572b24afcfa5d4224) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_wait_menu_option.html#aa7859be17333c9fa73e8e539ee590dbe)OnConditionDelegate()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| delegate bool TaleWorlds.CampaignSystem.GameMenus.WaitMenuOption.OnConditionDelegate | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_wait_menu_option.html#a4a6c4fbd400f2a259138fc51a2a769e3)OnConsequenceDelegate()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| delegate void TaleWorlds.CampaignSystem.GameMenus.WaitMenuOption.OnConsequenceDelegate | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_wait_menu_option.html#a8ba5173aaf5102327effda5add66972d)GetConditionsHold()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.GameMenus.WaitMenuOption.GetConditionsHold | ( | [Game](class_tale_worlds_1_1_core_1_1_game.html) | *game*, |
|  |  | [MapState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html) | *mapState* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_wait_menu_option.html#a2c4e1dab84588c7ae787f3b89e9aaf99)RunConsequence()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameMenus.WaitMenuOption.RunConsequence | ( | [Game](class_tale_worlds_1_1_core_1_1_game.html) | *game*, |
|  |  | [MapState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_map_state.html) | *mapState* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_wait_menu_option.html#acedc829133ffcfbaaad4cd05379dc6b5)Deserialize()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameMenus.WaitMenuOption.Deserialize | ( | XmlNode | *node*, |
|  |  | Type | *typeOfWaitMenusCallbacks* ) |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_wait_menu_option.html#a0ac77989559a1e4ac4a9f8d4c4f2aae4)OnCondition
--------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [OnConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_wait_menu_option.html#aa7859be17333c9fa73e8e539ee590dbe) TaleWorlds.CampaignSystem.GameMenus.WaitMenuOption.OnCondition |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_wait_menu_option.html#a2376c167a3937c37dc5b5533eba835fe)OnConsequence
----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [OnConsequenceDelegate](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_wait_menu_option.html#a4a6c4fbd400f2a259138fc51a2a769e3) TaleWorlds.CampaignSystem.GameMenus.WaitMenuOption.OnConsequence |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_wait_menu_option.html#ad50d58fb9b19cb06abc4e9935ab9a5d3)Priority
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.GameMenus.WaitMenuOption.Priority | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_wait_menu_option.html#a9beedcdb639720caec004854c564ec05)Text
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.GameMenus.WaitMenuOption.Text | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_wait_menu_option.html#a74964b2352563e724c4e38ab97405e5a)IdString
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.GameMenus.WaitMenuOption.IdString | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_wait_menu_option.html#ab472e2ffc177cc199b66e2ba7d6ba15a)Tooltip
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.GameMenus.WaitMenuOption.Tooltip | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_wait_menu_option.html#ad3e509e46b8e52b572b24afcfa5d4224)IsLeave
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.GameMenus.WaitMenuOption.IsLeave | | get |

