--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry_history.html ---

TaleWorlds.CampaignSystem.LogEntries.LogEntryHistory Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
| void | [DeleteOutdatedLogs](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry_history.html#aaf7034d59d4fa1da573061aa7075eebd) () |
| IEnumerable< T > | [GetGameActionLogs< T >](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry_history.html#ab38620cf3e1e8c2e08ff550b3af85308) (Func< T, bool > predicate) |
| T | [FindLastGameActionLog< T >](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry_history.html#a5424a845eca4997ebde0efcd335ec17d) (Func< T, bool > predicate) |
| int | [GetStartIndexForComments](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry_history.html#a69765ff7128ba24576334d32ae0c5e39) () |
| [LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html) | [GetRelevantComment](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry_history.html#aaa50af68136ff6bd5a9ecd9c793841b8) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) conversationHero, out int bestScore, out string bestRelatedLogEntryTag) |

|  |  |
| --- | --- |
| Properties | |
| MBReadOnlyList< [LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html) > | [GameActionLogs](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry_history.html#a817f1be79b1df448d0a7c66091865081) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry_history.html#aaf7034d59d4fa1da573061aa7075eebd)DeleteOutdatedLogs()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.LogEntries.LogEntryHistory.DeleteOutdatedLogs | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry_history.html#ab38620cf3e1e8c2e08ff550b3af85308)GetGameActionLogs< T >()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| IEnumerable< T > TaleWorlds.CampaignSystem.LogEntries.LogEntryHistory.GetGameActionLogs< T > | ( | Func< T, bool > | *predicate* | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html)* |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry_history.html#a5424a845eca4997ebde0efcd335ec17d)FindLastGameActionLog< T >()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| T TaleWorlds.CampaignSystem.LogEntries.LogEntryHistory.FindLastGameActionLog< T > | ( | Func< T, bool > | *predicate* | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html)* |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry_history.html#a69765ff7128ba24576334d32ae0c5e39)GetStartIndexForComments()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.LogEntries.LogEntryHistory.GetStartIndexForComments | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry_history.html#aaa50af68136ff6bd5a9ecd9c793841b8)GetRelevantComment()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html) TaleWorlds.CampaignSystem.LogEntries.LogEntryHistory.GetRelevantComment | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *conversationHero*, |
|  |  | out int | *bestScore*, |
|  |  | out string | *bestRelatedLogEntryTag* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry_history.html#a817f1be79b1df448d0a7c66091865081)GameActionLogs
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html)> TaleWorlds.CampaignSystem.LogEntries.LogEntryHistory.GameActionLogs | | get |

