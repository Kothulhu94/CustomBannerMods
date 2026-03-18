--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_events_1_1_set3c5fdc2a701850bcf310fe09ceeaa732.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Events.SettlementOverlayTalkPermissionEvent Class ReferenceAn event that is triggered before calculating if the character is talk-able from the settlement overlay UI. Any objecting systems will register this event and give reasoning for it's deactivation.

Inherits [TaleWorlds.Library.EventSystem.EventBase](class_tale_worlds_1_1_library_1_1_event_system_1_1_event_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [SettlementOverlayTalkPermissionEvent](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_events_1_1_set3c5fdc2a701850bcf310fe09ceeaa732.html#a9e994a36b77eb3dc3b9cbe16b041e4ff) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) heroToTalkTo, Action< bool, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > isTalkAvailable) |

|  |  |
| --- | --- |
| Public Attributes | |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [HeroToTalkTo](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_events_1_1_set3c5fdc2a701850bcf310fe09ceeaa732.html#a01f02abb98f1e690992f356988bffddb) |

|  |  |
| --- | --- |
| Properties | |
| Action< bool, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > | [IsTalkAvailable](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_events_1_1_set3c5fdc2a701850bcf310fe09ceeaa732.html#ad26bca4606f4e24b38c46e4a87714385) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_events_1_1_set3c5fdc2a701850bcf310fe09ceeaa732.html#a9e994a36b77eb3dc3b9cbe16b041e4ff)SettlementOverlayTalkPermissionEvent()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Events.SettlementOverlayTalkPermissionEvent.SettlementOverlayTalkPermissionEvent | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *heroToTalkTo*, |
|  |  | Action< bool, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > | *isTalkAvailable* ) |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_events_1_1_set3c5fdc2a701850bcf310fe09ceeaa732.html#a01f02abb98f1e690992f356988bffddb)HeroToTalkTo
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Events.SettlementOverlayTalkPermissionEvent.HeroToTalkTo |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_events_1_1_set3c5fdc2a701850bcf310fe09ceeaa732.html#ad26bca4606f4e24b38c46e4a87714385)IsTalkAvailable
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<bool, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html)> TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Events.SettlementOverlayTalkPermissionEvent.IsTalkAvailable | | get |

