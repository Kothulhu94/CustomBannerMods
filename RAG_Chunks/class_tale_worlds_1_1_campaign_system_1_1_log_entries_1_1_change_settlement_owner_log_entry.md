--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_change_settlement_owner_log_entry.html ---

TaleWorlds.CampaignSystem.LogEntries.ChangeSettlementOwnerLogEntry Class ReferenceInherits [TaleWorlds.CampaignSystem.LogEntries.LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html), [TaleWorlds.CampaignSystem.LogEntries.IEncyclopediaLog](interface_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_i_encyclopedia_log.html), and [TaleWorlds.CampaignSystem.LogEntries.IWarLog](interface_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_i_war_log.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ChangeSettlementOwnerLogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_change_settlement_owner_log_entry.html#a65f7dde92a9e926d2ffc3ef9e2300b2c) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_change_settlement_owner_log_entry.html#a222f9c2f3ffff48c0adbf9396c3d8fc7) settlement, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newOwner, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) previousOwner, bool bySiege) |
| override [ImportanceEnum](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a5da9ede756ccd51196b69792411e705d) | [GetImportanceForClan](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_change_settlement_owner_log_entry.html#a172b0c5eb72e54d2671d7f7d4fd75382) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| bool | [IsRelatedToWar](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_change_settlement_owner_log_entry.html#af4ce59ec7fdac79bf4a103b1b3543d0c) ([StanceLink](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html) stance, out [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) effector, out [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) effected) |
| override void | [GetConversationScoreAndComment](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_change_settlement_owner_log_entry.html#af7e41a08aea5016ba25ef150c069ba97) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) talkTroop, bool findString, out string comment, out [ImportanceEnum](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a5da9ede756ccd51196b69792411e705d) score) |
| override int | [GetAsRumor](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_change_settlement_owner_log_entry.html#a51f28b929e82665c0e47c3eb060086a2) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_change_settlement_owner_log_entry.html#a222f9c2f3ffff48c0adbf9396c3d8fc7) talkSettlement, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) comment) |
| override string | [ToString](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_change_settlement_owner_log_entry.html#addf47fe5ae7c417d90799254bfc5b64a) () |
| bool | [IsVisibleInEncyclopediaPageOf< T >](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_change_settlement_owner_log_entry.html#a2da567e511ca3f7c905d863366f2f24b) (T obj) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetEncyclopediaText](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_change_settlement_owner_log_entry.html#a2bdbb5179f22af021972c71dd6053895) () |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.LogEntries.LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html) | |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetHistoricComment](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a3e6d93f7728dbe250d7f7d374f4a4598) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) talkTroop) |
| virtual int | [AsReasonForEnmity](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a923b525085ea88a16913013269aced27) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) referenceHero1, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) referenceHero2) |
| virtual int | [GetValueAsPoliticsAbuseOfPower](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#ae5596b47b211f9a3ad0416a9054a44f9) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) referenceTroop, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) liege) |
| virtual int | [GetValueAsPoliticsSlightedClan](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a8c6212c66ff1f49f35d48b748dff0e38) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) referenceTroop, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) liege) |
| virtual int | [GetValueAsPoliticsShowedWeakness](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#acbfa8603d87b10253b9670ff7aa1fa20) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) referenceTroop, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) liege) |
| virtual bool | [IsValid](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a83f43de30ed08ab699fec650be10a21e) () |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly Settlement | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_change_settlement_owner_log_entry.html#a222f9c2f3ffff48c0adbf9396c3d8fc7) |
| readonly [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | [PreviousClan](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_change_settlement_owner_log_entry.html#a019e17c9e663d1eb3eb4b422dd5c20a8) |
| readonly [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | [NewClan](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_change_settlement_owner_log_entry.html#a1a1927854034c9ee3a04e7617d9e5143) |

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
| Properties inherited from [TaleWorlds.CampaignSystem.LogEntries.LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html) | |
| long | [Id](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#ab64d6317b6b3da5d89b28dfe0af32d49) `[get]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [GameTime](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a7a261f8d5d25128f503a53c5951d6f6b) `[get]` |
| virtual [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [KeepInHistoryTime](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#ae6e768fe50e4094d5dcc21a5c3c2cd3c) `[get]` |
| virtual [ChatNotificationType](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a628fd036253f36676e3955c26502d24b) | [NotificationType](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a8af557fe13d2e1e14039485a2a79068f) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.LogEntries.IEncyclopediaLog](interface_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_i_encyclopedia_log.html) | |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [GameTime](interface_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_i_encyclopedia_log.html#a60f61b986654611cdc63737996d9ecdc) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_change_settlement_owner_log_entry.html#a65f7dde92a9e926d2ffc3ef9e2300b2c)ChangeSettlementOwnerLogEntry()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.LogEntries.ChangeSettlementOwnerLogEntry.ChangeSettlementOwnerLogEntry | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_change_settlement_owner_log_entry.html#a222f9c2f3ffff48c0adbf9396c3d8fc7) | *settlement*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newOwner*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *previousOwner*, |
|  |  | bool | *bySiege* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_change_settlement_owner_log_entry.html#a172b0c5eb72e54d2671d7f7d4fd75382)GetImportanceForClan()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override [ImportanceEnum](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a5da9ede756ccd51196b69792411e705d) TaleWorlds.CampaignSystem.LogEntries.ChangeSettlementOwnerLogEntry.GetImportanceForClan | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.LogEntries.LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a7c6f6efbaf5023b9ff5a327f1035eb97).

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_change_settlement_owner_log_entry.html#af4ce59ec7fdac79bf4a103b1b3543d0c)IsRelatedToWar()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.LogEntries.ChangeSettlementOwnerLogEntry.IsRelatedToWar | ( | [StanceLink](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html) | *stance*, |
|  |  | out [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *effector*, |
|  |  | out [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *effected* ) |

Implements [TaleWorlds.CampaignSystem.LogEntries.IWarLog](interface_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_i_war_log.html#a4799c9a434b9dbe96dc78274b5452db6).

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_change_settlement_owner_log_entry.html#af7e41a08aea5016ba25ef150c069ba97)GetConversationScoreAndComment()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.LogEntries.ChangeSettlementOwnerLogEntry.GetConversationScoreAndComment | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *talkTroop*, | |  |  | bool | *findString*, | |  |  | out string | *comment*, | |  |  | out [ImportanceEnum](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a5da9ede756ccd51196b69792411e705d) | *score* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.LogEntries.LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a5908ac9bdee45378cf193ea497758ade).

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_change_settlement_owner_log_entry.html#a51f28b929e82665c0e47c3eb060086a2)GetAsRumor()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override int TaleWorlds.CampaignSystem.LogEntries.ChangeSettlementOwnerLogEntry.GetAsRumor | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_change_settlement_owner_log_entry.html#a222f9c2f3ffff48c0adbf9396c3d8fc7) | *talkSettlement*, | |  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *comment* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.LogEntries.LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#aec025534c9341d340f1f05a8dce17bfa).

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_change_settlement_owner_log_entry.html#addf47fe5ae7c417d90799254bfc5b64a)ToString()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.CampaignSystem.LogEntries.ChangeSettlementOwnerLogEntry.ToString | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_change_settlement_owner_log_entry.html#a2da567e511ca3f7c905d863366f2f24b)IsVisibleInEncyclopediaPageOf< T >()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.LogEntries.ChangeSettlementOwnerLogEntry.IsVisibleInEncyclopediaPageOf< T > | ( | T | *obj* | ) |  |

Implements [TaleWorlds.CampaignSystem.LogEntries.IEncyclopediaLog](interface_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_i_encyclopedia_log.html#aee91f5813bc1eef50d1fd09283b14b25).

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *MBObjectBase* |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_change_settlement_owner_log_entry.html#a2bdbb5179f22af021972c71dd6053895)GetEncyclopediaText()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.LogEntries.ChangeSettlementOwnerLogEntry.GetEncyclopediaText | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.LogEntries.IEncyclopediaLog](interface_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_i_encyclopedia_log.html#aac42e34a08f13f49ef820e5043c627ca).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_change_settlement_owner_log_entry.html#a222f9c2f3ffff48c0adbf9396c3d8fc7)Settlement
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly Settlement TaleWorlds.CampaignSystem.LogEntries.ChangeSettlementOwnerLogEntry.Settlement |

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_change_settlement_owner_log_entry.html#a019e17c9e663d1eb3eb4b422dd5c20a8)PreviousClan
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) TaleWorlds.CampaignSystem.LogEntries.ChangeSettlementOwnerLogEntry.PreviousClan |

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_change_settlement_owner_log_entry.html#a1a1927854034c9ee3a04e7617d9e5143)NewClan
----------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) TaleWorlds.CampaignSystem.LogEntries.ChangeSettlementOwnerLogEntry.NewClan |

