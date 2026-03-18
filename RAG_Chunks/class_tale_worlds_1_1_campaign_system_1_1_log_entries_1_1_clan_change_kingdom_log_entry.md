--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_clan_change_kingdom_log_entry.html ---

TaleWorlds.CampaignSystem.LogEntries.ClanChangeKingdomLogEntry Class ReferenceInherits [TaleWorlds.CampaignSystem.LogEntries.LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html), [TaleWorlds.CampaignSystem.LogEntries.IChatNotification](interface_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_i_chat_notification.html), and [TaleWorlds.CampaignSystem.LogEntries.IWarLog](interface_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_i_war_log.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ClanChangeKingdomLogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_clan_change_kingdom_log_entry.html#a9c4aab97a2124f47b4da6f4345615ddf) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_clan_change_kingdom_log_entry.html#a551f984ef4d838b0679afb33af5132ee) clan, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) oldKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) newKingdom, bool byRebellion) |
| bool | [IsRelatedToWar](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_clan_change_kingdom_log_entry.html#a08dc714ed15ceed8373f5a60b31623c1) ([StanceLink](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html) stance, out [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) effector, out [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) effected) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetNotificationText](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_clan_change_kingdom_log_entry.html#a8d5b6cffb247b12dd3e240816e56505d) () |
| override [ImportanceEnum](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a5da9ede756ccd51196b69792411e705d) | [GetImportanceForClan](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_clan_change_kingdom_log_entry.html#a2c9229aa3e1ff8ffad84e347edeac429) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_clan_change_kingdom_log_entry.html#a551f984ef4d838b0679afb33af5132ee) clan) |
| override void | [GetConversationScoreAndComment](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_clan_change_kingdom_log_entry.html#a3eda05a479449f57424d87d7f23d092d) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) talkTroop, bool findString, out string comment, out [ImportanceEnum](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a5da9ede756ccd51196b69792411e705d) score) |
| override string | [ToString](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_clan_change_kingdom_log_entry.html#a5342f74848529f354b56c9d09c9046c1) () |
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
| readonly Clan | [Clan](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_clan_change_kingdom_log_entry.html#a551f984ef4d838b0679afb33af5132ee) |
| readonly [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | [OldKingdom](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_clan_change_kingdom_log_entry.html#a97a95e9f75bd8e2a5ef9f5ea6e6e538f) |
| readonly [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | [NewKingdom](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_clan_change_kingdom_log_entry.html#a229f479c4abca3ddd106d41f075f5d2d) |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsVisibleNotification](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_clan_change_kingdom_log_entry.html#a84ebad5f1f93f4d762abab4a60cbbe1e) `[get]` |
| override [ChatNotificationType](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a628fd036253f36676e3955c26502d24b) | [NotificationType](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_clan_change_kingdom_log_entry.html#aaa072afc8ed3d33b05dac517ded8b31f) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.LogEntries.LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html) | |
| long | [Id](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#ab64d6317b6b3da5d89b28dfe0af32d49) `[get]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [GameTime](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a7a261f8d5d25128f503a53c5951d6f6b) `[get]` |
| virtual [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [KeepInHistoryTime](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#ae6e768fe50e4094d5dcc21a5c3c2cd3c) `[get]` |
| virtual [ChatNotificationType](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a628fd036253f36676e3955c26502d24b) | [NotificationType](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a8af557fe13d2e1e14039485a2a79068f) `[get]` |

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

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_clan_change_kingdom_log_entry.html#a9c4aab97a2124f47b4da6f4345615ddf)ClanChangeKingdomLogEntry()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.LogEntries.ClanChangeKingdomLogEntry.ClanChangeKingdomLogEntry | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_clan_change_kingdom_log_entry.html#a551f984ef4d838b0679afb33af5132ee) | *clan*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *oldKingdom*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *newKingdom*, |
|  |  | bool | *byRebellion* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_clan_change_kingdom_log_entry.html#a08dc714ed15ceed8373f5a60b31623c1)IsRelatedToWar()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.LogEntries.ClanChangeKingdomLogEntry.IsRelatedToWar | ( | [StanceLink](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html) | *stance*, |
|  |  | out [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *effector*, |
|  |  | out [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *effected* ) |

Implements [TaleWorlds.CampaignSystem.LogEntries.IWarLog](interface_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_i_war_log.html#a4799c9a434b9dbe96dc78274b5452db6).

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_clan_change_kingdom_log_entry.html#a8d5b6cffb247b12dd3e240816e56505d)GetNotificationText()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.LogEntries.ClanChangeKingdomLogEntry.GetNotificationText | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.LogEntries.IChatNotification](interface_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_i_chat_notification.html#ad0ca18e30c997ff99ddc61253e7723c4).

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_clan_change_kingdom_log_entry.html#a2c9229aa3e1ff8ffad84e347edeac429)GetImportanceForClan()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override [ImportanceEnum](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a5da9ede756ccd51196b69792411e705d) TaleWorlds.CampaignSystem.LogEntries.ClanChangeKingdomLogEntry.GetImportanceForClan | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_clan_change_kingdom_log_entry.html#a551f984ef4d838b0679afb33af5132ee) | *clan* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.LogEntries.LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a7c6f6efbaf5023b9ff5a327f1035eb97).

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_clan_change_kingdom_log_entry.html#a3eda05a479449f57424d87d7f23d092d)GetConversationScoreAndComment()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.LogEntries.ClanChangeKingdomLogEntry.GetConversationScoreAndComment | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *talkTroop*, | |  |  | bool | *findString*, | |  |  | out string | *comment*, | |  |  | out [ImportanceEnum](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a5da9ede756ccd51196b69792411e705d) | *score* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.LogEntries.LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a5908ac9bdee45378cf193ea497758ade).

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_clan_change_kingdom_log_entry.html#a5342f74848529f354b56c9d09c9046c1)ToString()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.CampaignSystem.LogEntries.ClanChangeKingdomLogEntry.ToString | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_clan_change_kingdom_log_entry.html#a551f984ef4d838b0679afb33af5132ee)Clan
---------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly Clan TaleWorlds.CampaignSystem.LogEntries.ClanChangeKingdomLogEntry.Clan |

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_clan_change_kingdom_log_entry.html#a97a95e9f75bd8e2a5ef9f5ea6e6e538f)OldKingdom
---------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) TaleWorlds.CampaignSystem.LogEntries.ClanChangeKingdomLogEntry.OldKingdom |

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_clan_change_kingdom_log_entry.html#a229f479c4abca3ddd106d41f075f5d2d)NewKingdom
---------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) TaleWorlds.CampaignSystem.LogEntries.ClanChangeKingdomLogEntry.NewKingdom |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_clan_change_kingdom_log_entry.html#a84ebad5f1f93f4d762abab4a60cbbe1e)IsVisibleNotification
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.LogEntries.ClanChangeKingdomLogEntry.IsVisibleNotification | | get |

Implements [TaleWorlds.CampaignSystem.LogEntries.IChatNotification](interface_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_i_chat_notification.html#a64a4d03f831c60e5c92e9a00bf0b085b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_clan_change_kingdom_log_entry.html#aaa072afc8ed3d33b05dac517ded8b31f)NotificationType
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [ChatNotificationType](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a628fd036253f36676e3955c26502d24b) TaleWorlds.CampaignSystem.LogEntries.ClanChangeKingdomLogEntry.NotificationType | | get |

Implements [TaleWorlds.CampaignSystem.LogEntries.IChatNotification](interface_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_i_chat_notification.html#a7252674b27d15922f8d17a18d573ec44).

