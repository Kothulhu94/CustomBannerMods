--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_events_1_1_parad43c872c86c735ae3bd6939579076a0.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Events.PartyScreenCharacterTalkPermissionEvent Class ReferenceAn event that is triggered before calculating if the character is talk-able from the party screen UI. Any objecting systems will register this event and give reasoning for it's deactivation.

Inherits [TaleWorlds.Library.EventSystem.EventBase](class_tale_worlds_1_1_library_1_1_event_system_1_1_event_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [PartyScreenCharacterTalkPermissionEvent](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_events_1_1_parad43c872c86c735ae3bd6939579076a0.html#a5dce0646f7dd02439614399ede1f5dd0) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) heroToTalkTo, Action< bool, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > isTalkAvailable) |

|  |  |
| --- | --- |
| Public Attributes | |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [HeroToTalkTo](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_events_1_1_parad43c872c86c735ae3bd6939579076a0.html#a6f44068519ab785106f1d8b58a039cd2) |

|  |  |
| --- | --- |
| Properties | |
| Action< bool, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > | [IsTalkAvailable](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_events_1_1_parad43c872c86c735ae3bd6939579076a0.html#a050d5d95f6a9109c692dba109449b9c8) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_events_1_1_parad43c872c86c735ae3bd6939579076a0.html#a5dce0646f7dd02439614399ede1f5dd0)PartyScreenCharacterTalkPermissionEvent()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Events.PartyScreenCharacterTalkPermissionEvent.PartyScreenCharacterTalkPermissionEvent | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *heroToTalkTo*, |
|  |  | Action< bool, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > | *isTalkAvailable* ) |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_events_1_1_parad43c872c86c735ae3bd6939579076a0.html#a6f44068519ab785106f1d8b58a039cd2)HeroToTalkTo
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Events.PartyScreenCharacterTalkPermissionEvent.HeroToTalkTo |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_events_1_1_parad43c872c86c735ae3bd6939579076a0.html#a050d5d95f6a9109c692dba109449b9c8)IsTalkAvailable
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<bool, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html)> TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Events.PartyScreenCharacterTalkPermissionEvent.IsTalkAvailable | | get |

