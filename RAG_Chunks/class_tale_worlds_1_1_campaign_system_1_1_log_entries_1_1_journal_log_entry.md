--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_journal_log_entry.html ---

TaleWorlds.CampaignSystem.LogEntries.JournalLogEntry Class ReferenceInherits [TaleWorlds.CampaignSystem.LogEntries.LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [JournalLogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_journal_log_entry.html#ab9d604c49b798de0361164946be26228) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) title, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) relatedHero, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) antagonist, bool isSpecial, params [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html)[] relatedObjects) |
| bool | [IsRelatedTo](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_journal_log_entry.html#a67a2cbe8f5558a54c9fb77fc707a4408) ([MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) obj) |
| IEnumerable< [JournalLog](class_tale_worlds_1_1_campaign_system_1_1_journal_log.html) > | [GetEntries](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_journal_log_entry.html#ad9023870a30677b846bbe269cad6ee67) () |
| void | [Update](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_journal_log_entry.html#ae96d703f969b6db66029a54de725ed35) (MBReadOnlyList< [JournalLog](class_tale_worlds_1_1_campaign_system_1_1_journal_log.html) > entries, [IssueBase.IssueUpdateDetails](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a5a6b26c5d1d5fad12cd7b6faffede41b) issueStatus=IssueBase.IssueUpdateDetails.None) |
| void | [Update](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_journal_log_entry.html#a2fe45e3695b133ca8c5f80830e100f50) (MBReadOnlyList< [JournalLog](class_tale_worlds_1_1_campaign_system_1_1_journal_log.html) > entries, [QuestBase.QuestCompleteDetails](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a23d16828fddb30cec76b1a8089a9e398) questCompletionDetail) |
| bool | [IsEndedUnsuccessfully](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_journal_log_entry.html#a0aeb1ce1d7432f1a1c36482c4ee523b8) () |
| bool | [IsEnded](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_journal_log_entry.html#a28f4e6fc1931c8301df0f58456a03668) () |
| override string | [ToString](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_journal_log_entry.html#aa6937db3da745827f2a764aecade8e1d) () |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.LogEntries.LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html) | |
| virtual [ImportanceEnum](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a5da9ede756ccd51196b69792411e705d) | [GetImportanceForClan](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a7c6f6efbaf5023b9ff5a327f1035eb97) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| virtual void | [GetConversationScoreAndComment](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a5908ac9bdee45378cf193ea497758ade) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) talkTroop, bool findString, out string comment, out [ImportanceEnum](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a5da9ede756ccd51196b69792411e705d) score) |
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
| readonly [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Title](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_journal_log_entry.html#aaa50f89550542d9edc7d9434af73c236) |
| readonly [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [RelatedHero](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_journal_log_entry.html#a9bceb479ea34d17e33ef944120b3f4bd) |
| readonly [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [Antagonist](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_journal_log_entry.html#aaf83c0bde7eef31b9fb529ee0211fae9) |
| readonly bool | [IsSpecial](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_journal_log_entry.html#a264e8589547f5adcc29dbf0e4184d249) |

|  |  |
| --- | --- |
| Properties | |
| override [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [KeepInHistoryTime](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_journal_log_entry.html#ab3e498886708b1cb37dfe62247e323c2) `[get]` |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_journal_log_entry.html#ab9d604c49b798de0361164946be26228)JournalLogEntry()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.LogEntries.JournalLogEntry.JournalLogEntry | ( | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *title*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *relatedHero*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *antagonist*, |
|  |  | bool | *isSpecial*, |
|  |  | params [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html)[] | *relatedObjects* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_journal_log_entry.html#a67a2cbe8f5558a54c9fb77fc707a4408)IsRelatedTo()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.LogEntries.JournalLogEntry.IsRelatedTo | ( | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | *obj* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_journal_log_entry.html#ad9023870a30677b846bbe269cad6ee67)GetEntries()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< [JournalLog](class_tale_worlds_1_1_campaign_system_1_1_journal_log.html) > TaleWorlds.CampaignSystem.LogEntries.JournalLogEntry.GetEntries | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_journal_log_entry.html#ae96d703f969b6db66029a54de725ed35)Update() [1/2]
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.LogEntries.JournalLogEntry.Update | ( | MBReadOnlyList< [JournalLog](class_tale_worlds_1_1_campaign_system_1_1_journal_log.html) > | *entries*, |
|  |  | [IssueBase.IssueUpdateDetails](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a5a6b26c5d1d5fad12cd7b6faffede41b) | *issueStatus* = IssueBase::IssueUpdateDetails::None ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_journal_log_entry.html#a2fe45e3695b133ca8c5f80830e100f50)Update() [2/2]
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.LogEntries.JournalLogEntry.Update | ( | MBReadOnlyList< [JournalLog](class_tale_worlds_1_1_campaign_system_1_1_journal_log.html) > | *entries*, |
|  |  | [QuestBase.QuestCompleteDetails](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a23d16828fddb30cec76b1a8089a9e398) | *questCompletionDetail* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_journal_log_entry.html#a0aeb1ce1d7432f1a1c36482c4ee523b8)IsEndedUnsuccessfully()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.LogEntries.JournalLogEntry.IsEndedUnsuccessfully | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_journal_log_entry.html#a28f4e6fc1931c8301df0f58456a03668)IsEnded()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.LogEntries.JournalLogEntry.IsEnded | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_journal_log_entry.html#aa6937db3da745827f2a764aecade8e1d)ToString()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.CampaignSystem.LogEntries.JournalLogEntry.ToString | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_journal_log_entry.html#aaa50f89550542d9edc7d9434af73c236)Title
----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.LogEntries.JournalLogEntry.Title |

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_journal_log_entry.html#a9bceb479ea34d17e33ef944120b3f4bd)RelatedHero
----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.LogEntries.JournalLogEntry.RelatedHero |

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_journal_log_entry.html#aaf83c0bde7eef31b9fb529ee0211fae9)Antagonist
---------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.LogEntries.JournalLogEntry.Antagonist |

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_journal_log_entry.html#a264e8589547f5adcc29dbf0e4184d249)IsSpecial
--------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly bool TaleWorlds.CampaignSystem.LogEntries.JournalLogEntry.IsSpecial |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_journal_log_entry.html#ab3e498886708b1cb37dfe62247e323c2)KeepInHistoryTime
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.LogEntries.JournalLogEntry.KeepInHistoryTime | | get |

