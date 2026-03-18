--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_player_battle_ended_log_entry.html ---

TaleWorlds.CampaignSystem.LogEntries.PlayerBattleEndedLogEntry Class ReferenceInherits [TaleWorlds.CampaignSystem.LogEntries.LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html), and [TaleWorlds.CampaignSystem.LogEntries.IChatNotification](interface_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_i_chat_notification.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [PlayerBattleEndedLogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_player_battle_ended_log_entry.html#adcbf3de14822b4d2db03bc170482893a) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) mapEvent) |
| override [ImportanceEnum](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a5da9ede756ccd51196b69792411e705d) | [GetImportanceForClan](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_player_battle_ended_log_entry.html#a67b7106853e81d8f82736f6fdb1cfe50) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| override void | [GetConversationScoreAndComment](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_player_battle_ended_log_entry.html#aa1234afa404d9366cac7a045f502e035) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) talkTroop, bool findString, out string comment, out [ImportanceEnum](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a5da9ede756ccd51196b69792411e705d) score) |
| override string | [ToString](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_player_battle_ended_log_entry.html#a32437c8f5221d7f26af6fe4a02ee6f8a) () |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetNotificationText](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_player_battle_ended_log_entry.html#ab1afc9d9116c084ecc2afb919a23e5c7) () |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.LogEntries.LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html) | |
| virtual int | [GetAsRumor](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#aec025534c9341d340f1f05a8dce17bfa) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) comment) |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetHistoricComment](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a3e6d93f7728dbe250d7f7d374f4a4598) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) talkTroop) |
| virtual int | [AsReasonForEnmity](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a923b525085ea88a16913013269aced27) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) referenceHero1, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) referenceHero2) |
| virtual int | [GetValueAsPoliticsAbuseOfPower](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#ae5596b47b211f9a3ad0416a9054a44f9) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) referenceTroop, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) liege) |
| virtual int | [GetValueAsPoliticsSlightedClan](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a8c6212c66ff1f49f35d48b748dff0e38) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) referenceTroop, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) liege) |
| virtual int | [GetValueAsPoliticsShowedWeakness](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#acbfa8603d87b10253b9670ff7aa1fa20) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) referenceTroop, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) liege) |
| virtual bool | [IsValid](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a83f43de30ed08ab699fec650be10a21e) () |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsNavalBattle](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_player_battle_ended_log_entry.html#a6c0fb5d8b17a6d149054a3d46f9616c9) `[get]` |
| int | [PlayerCasualties](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_player_battle_ended_log_entry.html#a66d2356aedc74ac9f25f307e6276933d) `[get]` |
| bool | [HasHeavyCausality](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_player_battle_ended_log_entry.html#a9f8fc3968f6bb45abdd9202bc9b2850b) `[get]` |
| bool | [IsAgainstGreatOdds](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_player_battle_ended_log_entry.html#af6f1c3e81fc85c320831144d74d7791d) `[get]` |
| bool | [IsVisibleNotification](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_player_battle_ended_log_entry.html#ad9e0821f35847860c549e462eb420433) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.LogEntries.LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html) | |
| long | [Id](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#ab64d6317b6b3da5d89b28dfe0af32d49) `[get]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [GameTime](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a7a261f8d5d25128f503a53c5951d6f6b) `[get]` |
| virtual [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [KeepInHistoryTime](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#ae6e768fe50e4094d5dcc21a5c3c2cd3c) `[get]` |
| virtual [ChatNotificationType](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a628fd036253f36676e3955c26502d24b) | [NotificationType](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a8af557fe13d2e1e14039485a2a79068f) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.LogEntries.IChatNotification](interface_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_i_chat_notification.html) | |
| [ChatNotificationType](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a628fd036253f36676e3955c26502d24b) | [NotificationType](interface_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_i_chat_notification.html#a7252674b27d15922f8d17a18d573ec44) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.CampaignSystem.LogEntries.LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html) | |
| static void | [AddLogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#aae352405d30de4fb59eb5c6e8bb2171b) ([LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html) logEntry) |
| static void | [AddLogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a9d8fbc79cd5d870a1e900782f1f5886b) ([LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html) logEntry, [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) gameTime) |
| Protected Member Functions inherited from [TaleWorlds.CampaignSystem.LogEntries.LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html) | |
| [ChatNotificationType](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a628fd036253f36676e3955c26502d24b) | [MilitaryNotification](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a39f60666598fff5a6618e49d91a00048) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) benefiter, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) affected) |
| [ChatNotificationType](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a628fd036253f36676e3955c26502d24b) | [DiplomaticNotification](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a23f398711eeb7a912a3d3b5943ecfd2d) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction1, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction2) |
| [ChatNotificationType](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a628fd036253f36676e3955c26502d24b) | [AdversityNotification](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a41e99acb466cc9e002331ed2015f44c6) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction1, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction2) |
| [ChatNotificationType](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a628fd036253f36676e3955c26502d24b) | [PoliticalNotification](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#ae89e1c61ac912ef306b8a81bd2e4400e) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| [ChatNotificationType](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a628fd036253f36676e3955c26502d24b) | [CivilianNotification](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a361f6f567b55859864a758fff3257ee0) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| Static Protected Attributes inherited from [TaleWorlds.CampaignSystem.LogEntries.LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html) | |
| const uint | [NotificationDefaultTextColor](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a58cdc628f53b87f73ceeefd87a484f5a) = 0x000000 |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_player_battle_ended_log_entry.html#adcbf3de14822b4d2db03bc170482893a)PlayerBattleEndedLogEntry()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.LogEntries.PlayerBattleEndedLogEntry.PlayerBattleEndedLogEntry | ( | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *mapEvent* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_player_battle_ended_log_entry.html#a67b7106853e81d8f82736f6fdb1cfe50)GetImportanceForClan()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override [ImportanceEnum](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a5da9ede756ccd51196b69792411e705d) TaleWorlds.CampaignSystem.LogEntries.PlayerBattleEndedLogEntry.GetImportanceForClan | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.LogEntries.LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a7c6f6efbaf5023b9ff5a327f1035eb97).

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_player_battle_ended_log_entry.html#aa1234afa404d9366cac7a045f502e035)GetConversationScoreAndComment()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.LogEntries.PlayerBattleEndedLogEntry.GetConversationScoreAndComment | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *talkTroop*, | |  |  | bool | *findString*, | |  |  | out string | *comment*, | |  |  | out [ImportanceEnum](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a5da9ede756ccd51196b69792411e705d) | *score* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.LogEntries.LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a5908ac9bdee45378cf193ea497758ade).

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_player_battle_ended_log_entry.html#a32437c8f5221d7f26af6fe4a02ee6f8a)ToString()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.CampaignSystem.LogEntries.PlayerBattleEndedLogEntry.ToString | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_player_battle_ended_log_entry.html#ab1afc9d9116c084ecc2afb919a23e5c7)GetNotificationText()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.LogEntries.PlayerBattleEndedLogEntry.GetNotificationText | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.LogEntries.IChatNotification](interface_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_i_chat_notification.html#ad0ca18e30c997ff99ddc61253e7723c4).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_player_battle_ended_log_entry.html#a6c0fb5d8b17a6d149054a3d46f9616c9)IsNavalBattle
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.LogEntries.PlayerBattleEndedLogEntry.IsNavalBattle | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_player_battle_ended_log_entry.html#a66d2356aedc74ac9f25f307e6276933d)PlayerCasualties
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.LogEntries.PlayerBattleEndedLogEntry.PlayerCasualties | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_player_battle_ended_log_entry.html#a9f8fc3968f6bb45abdd9202bc9b2850b)HasHeavyCausality
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.LogEntries.PlayerBattleEndedLogEntry.HasHeavyCausality | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_player_battle_ended_log_entry.html#af6f1c3e81fc85c320831144d74d7791d)IsAgainstGreatOdds
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.LogEntries.PlayerBattleEndedLogEntry.IsAgainstGreatOdds | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_player_battle_ended_log_entry.html#ad9e0821f35847860c549e462eb420433)IsVisibleNotification
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.LogEntries.PlayerBattleEndedLogEntry.IsVisibleNotification | | get |

Implements [TaleWorlds.CampaignSystem.LogEntries.IChatNotification](interface_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_i_chat_notification.html#a64a4d03f831c60e5c92e9a00bf0b085b).

