--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_declare_war_log_entry.html ---

TaleWorlds.CampaignSystem.LogEntries.DeclareWarLogEntry Class ReferenceInherits [TaleWorlds.CampaignSystem.LogEntries.LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html), [TaleWorlds.CampaignSystem.LogEntries.IEncyclopediaLog](interface_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_i_encyclopedia_log.html), [TaleWorlds.CampaignSystem.LogEntries.IChatNotification](interface_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_i_chat_notification.html), and [TaleWorlds.CampaignSystem.LogEntries.IWarLog](interface_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_i_war_log.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [DeclareWarLogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_declare_war_log_entry.html#a472d1b99bf19816c311a3fed0077c9d2) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction1, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction2) |
| bool | [IsRelatedToWar](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_declare_war_log_entry.html#ae640ef6c4e8e5e5b30936729792bc9b4) ([StanceLink](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html) stance, out [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) effector, out [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) effected) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetNotificationText](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_declare_war_log_entry.html#a790041b5188418c537cfc29b444c994b) () |
| override void | [GetConversationScoreAndComment](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_declare_war_log_entry.html#a68cd3dc5f1178a4371ba91c6af8b587b) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) talkTroop, bool findString, out string comment, out [ImportanceEnum](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a5da9ede756ccd51196b69792411e705d) score) |
| override int | [GetAsRumor](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_declare_war_log_entry.html#ae188229673bdbc55bfb2f0d3c524a6b1) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) talkSettlement, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) comment) |
| override string | [ToString](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_declare_war_log_entry.html#af13c56d2402aba08232c73d7de68038a) () |
| bool | [IsVisibleInEncyclopediaPageOf< T >](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_declare_war_log_entry.html#a6f7c71ce34af24c32c3a90aa6856db19) (T obj) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetEncyclopediaText](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_declare_war_log_entry.html#acb4502b6f3b16ddc7789788e6bcdac63) () |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.LogEntries.LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html) | |
| virtual [ImportanceEnum](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a5da9ede756ccd51196b69792411e705d) | [GetImportanceForClan](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a7c6f6efbaf5023b9ff5a327f1035eb97) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetHistoricComment](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a3e6d93f7728dbe250d7f7d374f4a4598) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) talkTroop) |
| virtual int | [AsReasonForEnmity](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a923b525085ea88a16913013269aced27) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) referenceHero1, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) referenceHero2) |
| virtual int | [GetValueAsPoliticsAbuseOfPower](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#ae5596b47b211f9a3ad0416a9054a44f9) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) referenceTroop, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) liege) |
| virtual int | [GetValueAsPoliticsSlightedClan](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a8c6212c66ff1f49f35d48b748dff0e38) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) referenceTroop, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) liege) |
| virtual int | [GetValueAsPoliticsShowedWeakness](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#acbfa8603d87b10253b9670ff7aa1fa20) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) referenceTroop, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) liege) |
| virtual bool | [IsValid](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a83f43de30ed08ab699fec650be10a21e) () |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | [Faction1](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_declare_war_log_entry.html#a66ea8eebef7136eb2533dd0eaa733964) |
| readonly [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | [Faction2](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_declare_war_log_entry.html#ae92429ee0c51d7df26ae27d8de8efd9b) |
| readonly [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [Faction1Leader](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_declare_war_log_entry.html#a88d01481d6776ace7b4df3af6c995a5f) |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsVisibleNotification](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_declare_war_log_entry.html#a3fcb208c1ae612a500b8fe6aefb3d05a) `[get]` |
| override [ChatNotificationType](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a628fd036253f36676e3955c26502d24b) | [NotificationType](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_declare_war_log_entry.html#ab0504e195c0e40dac01c2109fb44ab8f) `[get]` |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_declare_war_log_entry.html#a472d1b99bf19816c311a3fed0077c9d2)DeclareWarLogEntry()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.LogEntries.DeclareWarLogEntry.DeclareWarLogEntry | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction1*, |
|  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction2* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_declare_war_log_entry.html#ae640ef6c4e8e5e5b30936729792bc9b4)IsRelatedToWar()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.LogEntries.DeclareWarLogEntry.IsRelatedToWar | ( | [StanceLink](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html) | *stance*, |
|  |  | out [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *effector*, |
|  |  | out [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *effected* ) |

Implements [TaleWorlds.CampaignSystem.LogEntries.IWarLog](interface_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_i_war_log.html#a4799c9a434b9dbe96dc78274b5452db6).

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_declare_war_log_entry.html#a790041b5188418c537cfc29b444c994b)GetNotificationText()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.LogEntries.DeclareWarLogEntry.GetNotificationText | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.LogEntries.IChatNotification](interface_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_i_chat_notification.html#ad0ca18e30c997ff99ddc61253e7723c4).

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_declare_war_log_entry.html#a68cd3dc5f1178a4371ba91c6af8b587b)GetConversationScoreAndComment()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.LogEntries.DeclareWarLogEntry.GetConversationScoreAndComment | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *talkTroop*, | |  |  | bool | *findString*, | |  |  | out string | *comment*, | |  |  | out [ImportanceEnum](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a5da9ede756ccd51196b69792411e705d) | *score* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.LogEntries.LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a5908ac9bdee45378cf193ea497758ade).

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_declare_war_log_entry.html#ae188229673bdbc55bfb2f0d3c524a6b1)GetAsRumor()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override int TaleWorlds.CampaignSystem.LogEntries.DeclareWarLogEntry.GetAsRumor | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *talkSettlement*, | |  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *comment* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.LogEntries.LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#aec025534c9341d340f1f05a8dce17bfa).

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_declare_war_log_entry.html#af13c56d2402aba08232c73d7de68038a)ToString()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.CampaignSystem.LogEntries.DeclareWarLogEntry.ToString | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_declare_war_log_entry.html#a6f7c71ce34af24c32c3a90aa6856db19)IsVisibleInEncyclopediaPageOf< T >()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.LogEntries.DeclareWarLogEntry.IsVisibleInEncyclopediaPageOf< T > | ( | T | *obj* | ) |  |

Implements [TaleWorlds.CampaignSystem.LogEntries.IEncyclopediaLog](interface_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_i_encyclopedia_log.html#aee91f5813bc1eef50d1fd09283b14b25).

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *MBObjectBase* |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_declare_war_log_entry.html#acb4502b6f3b16ddc7789788e6bcdac63)GetEncyclopediaText()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.LogEntries.DeclareWarLogEntry.GetEncyclopediaText | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.LogEntries.IEncyclopediaLog](interface_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_i_encyclopedia_log.html#aac42e34a08f13f49ef820e5043c627ca).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_declare_war_log_entry.html#a66ea8eebef7136eb2533dd0eaa733964)Faction1
-----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) TaleWorlds.CampaignSystem.LogEntries.DeclareWarLogEntry.Faction1 |

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_declare_war_log_entry.html#ae92429ee0c51d7df26ae27d8de8efd9b)Faction2
-----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) TaleWorlds.CampaignSystem.LogEntries.DeclareWarLogEntry.Faction2 |

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_declare_war_log_entry.html#a88d01481d6776ace7b4df3af6c995a5f)Faction1Leader
-----------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.LogEntries.DeclareWarLogEntry.Faction1Leader |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_declare_war_log_entry.html#a3fcb208c1ae612a500b8fe6aefb3d05a)IsVisibleNotification
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.LogEntries.DeclareWarLogEntry.IsVisibleNotification | | get |

Implements [TaleWorlds.CampaignSystem.LogEntries.IChatNotification](interface_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_i_chat_notification.html#a64a4d03f831c60e5c92e9a00bf0b085b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_declare_war_log_entry.html#ab0504e195c0e40dac01c2109fb44ab8f)NotificationType
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [ChatNotificationType](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a628fd036253f36676e3955c26502d24b) TaleWorlds.CampaignSystem.LogEntries.DeclareWarLogEntry.NotificationType | | get |

Implements [TaleWorlds.CampaignSystem.LogEntries.IChatNotification](interface_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_i_chat_notification.html#a7252674b27d15922f8d17a18d573ec44).

