--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_player_meet_lord_log_entry.html ---

TaleWorlds.CampaignSystem.LogEntries.PlayerMeetLordLogEntry Class ReferenceInherits [TaleWorlds.CampaignSystem.LogEntries.LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html), and [TaleWorlds.CampaignSystem.LogEntries.IEncyclopediaLog](interface_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_i_encyclopedia_log.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [PlayerMeetLordLogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_player_meet_lord_log_entry.html#a50fea970f4e311db585e6c8f2ca15d41) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_player_meet_lord_log_entry.html#a0e8ea72f23b56dd7a07453c18a37d537) hero) |
| override [ImportanceEnum](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a5da9ede756ccd51196b69792411e705d) | [GetImportanceForClan](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_player_meet_lord_log_entry.html#a6cae81a05a50976b20e299304a1e7dd6) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| override void | [GetConversationScoreAndComment](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_player_meet_lord_log_entry.html#a6daf5f017cbda842d43785983f558cd6) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_player_meet_lord_log_entry.html#a0e8ea72f23b56dd7a07453c18a37d537) talkTroop, bool findString, out string comment, out [ImportanceEnum](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a5da9ede756ccd51196b69792411e705d) score) |
| override string | [ToString](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_player_meet_lord_log_entry.html#ac494cc456101d9023f7fbc63ebdf1bbc) () |
| bool | [IsVisibleInEncyclopediaPageOf< T >](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_player_meet_lord_log_entry.html#aa79db4023019dc657dd3822b1a7c1c1c) (T obj) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetEncyclopediaText](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_player_meet_lord_log_entry.html#a3d6dabaa7e355874ab3c92cc3c48b42b) () |
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
| Public Attributes | |
| readonly Hero | [Hero](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_player_meet_lord_log_entry.html#a0e8ea72f23b56dd7a07453c18a37d537) |

|  |  |
| --- | --- |
| Properties | |
| override [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [KeepInHistoryTime](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_player_meet_lord_log_entry.html#aac72fea2a2872b0241bb61362f8c8a9a) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.LogEntries.LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html) | |
| long | [Id](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#ab64d6317b6b3da5d89b28dfe0af32d49) `[get]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [GameTime](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a7a261f8d5d25128f503a53c5951d6f6b) `[get]` |
| virtual [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [KeepInHistoryTime](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#ae6e768fe50e4094d5dcc21a5c3c2cd3c) `[get]` |
| virtual [ChatNotificationType](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a628fd036253f36676e3955c26502d24b) | [NotificationType](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a8af557fe13d2e1e14039485a2a79068f) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.LogEntries.IEncyclopediaLog](interface_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_i_encyclopedia_log.html) | |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [GameTime](interface_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_i_encyclopedia_log.html#a60f61b986654611cdc63737996d9ecdc) `[get]` |

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

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_player_meet_lord_log_entry.html#a50fea970f4e311db585e6c8f2ca15d41)PlayerMeetLordLogEntry()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.LogEntries.PlayerMeetLordLogEntry.PlayerMeetLordLogEntry | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_player_meet_lord_log_entry.html#a0e8ea72f23b56dd7a07453c18a37d537) | *hero* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_player_meet_lord_log_entry.html#a6cae81a05a50976b20e299304a1e7dd6)GetImportanceForClan()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override [ImportanceEnum](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a5da9ede756ccd51196b69792411e705d) TaleWorlds.CampaignSystem.LogEntries.PlayerMeetLordLogEntry.GetImportanceForClan | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.LogEntries.LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a7c6f6efbaf5023b9ff5a327f1035eb97).

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_player_meet_lord_log_entry.html#a6daf5f017cbda842d43785983f558cd6)GetConversationScoreAndComment()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.LogEntries.PlayerMeetLordLogEntry.GetConversationScoreAndComment | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_player_meet_lord_log_entry.html#a0e8ea72f23b56dd7a07453c18a37d537) | *talkTroop*, | |  |  | bool | *findString*, | |  |  | out string | *comment*, | |  |  | out [ImportanceEnum](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a5da9ede756ccd51196b69792411e705d) | *score* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.LogEntries.LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a5908ac9bdee45378cf193ea497758ade).

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_player_meet_lord_log_entry.html#ac494cc456101d9023f7fbc63ebdf1bbc)ToString()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.CampaignSystem.LogEntries.PlayerMeetLordLogEntry.ToString | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_player_meet_lord_log_entry.html#aa79db4023019dc657dd3822b1a7c1c1c)IsVisibleInEncyclopediaPageOf< T >()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.LogEntries.PlayerMeetLordLogEntry.IsVisibleInEncyclopediaPageOf< T > | ( | T | *obj* | ) |  |

Implements [TaleWorlds.CampaignSystem.LogEntries.IEncyclopediaLog](interface_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_i_encyclopedia_log.html#aee91f5813bc1eef50d1fd09283b14b25).

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *MBObjectBase* |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_player_meet_lord_log_entry.html#a3d6dabaa7e355874ab3c92cc3c48b42b)GetEncyclopediaText()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.LogEntries.PlayerMeetLordLogEntry.GetEncyclopediaText | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.LogEntries.IEncyclopediaLog](interface_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_i_encyclopedia_log.html#aac42e34a08f13f49ef820e5043c627ca).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_player_meet_lord_log_entry.html#a0e8ea72f23b56dd7a07453c18a37d537)Hero
------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly Hero TaleWorlds.CampaignSystem.LogEntries.PlayerMeetLordLogEntry.Hero |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_player_meet_lord_log_entry.html#aac72fea2a2872b0241bb61362f8c8a9a)KeepInHistoryTime
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.LogEntries.PlayerMeetLordLogEntry.KeepInHistoryTime | | get |

