--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_events_1_1_setf2b3b129efa35d6a31ac83773d195db2.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Events.SettlementOverylayQuickTalkPermissionEvent Class ReferenceAn event that is triggered before calculating if the character is "quick talk"-able from the settlement overlay UI. Any objecting systems will register this event and give reasoning for it's deactivation.

Inherits [TaleWorlds.Library.EventSystem.EventBase](class_tale_worlds_1_1_library_1_1_event_system_1_1_event_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [SettlementOverylayQuickTalkPermissionEvent](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_events_1_1_setf2b3b129efa35d6a31ac83773d195db2.html#a876e04f41f5d3fb2f01b3dfd5ed0becd) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) heroToTalkTo, Action< bool, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > isTalkAvailable) |

|  |  |
| --- | --- |
| Public Attributes | |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [HeroToTalkTo](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_events_1_1_setf2b3b129efa35d6a31ac83773d195db2.html#a0e0674e4e41bcf2654c62347d2f70ba6) |

|  |  |
| --- | --- |
| Properties | |
| Action< bool, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > | [IsTalkAvailable](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_events_1_1_setf2b3b129efa35d6a31ac83773d195db2.html#ac464c389b59c73739ff6cb05c864bee8) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_events_1_1_setf2b3b129efa35d6a31ac83773d195db2.html#a876e04f41f5d3fb2f01b3dfd5ed0becd)SettlementOverylayQuickTalkPermissionEvent()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Events.SettlementOverylayQuickTalkPermissionEvent.SettlementOverylayQuickTalkPermissionEvent | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *heroToTalkTo*, |
|  |  | Action< bool, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > | *isTalkAvailable* ) |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_events_1_1_setf2b3b129efa35d6a31ac83773d195db2.html#a0e0674e4e41bcf2654c62347d2f70ba6)HeroToTalkTo
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Events.SettlementOverylayQuickTalkPermissionEvent.HeroToTalkTo |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_events_1_1_setf2b3b129efa35d6a31ac83773d195db2.html#ac464c389b59c73739ff6cb05c864bee8)IsTalkAvailable
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<bool, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html)> TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Events.SettlementOverylayQuickTalkPermissionEvent.IsTalkAvailable | | get |

