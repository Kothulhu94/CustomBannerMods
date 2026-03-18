--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_journal_log.html ---

TaleWorlds.CampaignSystem.JournalLog Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [JournalLog](class_tale_worlds_1_1_campaign_system_1_1_journal_log.html#a9bda1040fea3184c698ef23f85b7aad0) ([CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) logTime, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) logText, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) taskName=null, int currentProgress=0, int range=0, [LogType](namespace_tale_worlds_1_1_campaign_system.html#a4bf95a9678e6e4b1cd64547db184d391) type=[LogType.Text](namespace_tale_worlds_1_1_campaign_system.html#a4bf95a9678e6e4b1cd64547db184d391a9dffbf69ffba8bc38bc4e01abf4b1675)) |
| void | [UpdateCurrentProgress](class_tale_worlds_1_1_campaign_system_1_1_journal_log.html#aff0f6ba685a08a0bf1b66f9846d7ba25) (int progress) |
| bool | [HasBeenCompleted](class_tale_worlds_1_1_campaign_system_1_1_journal_log.html#a22e5dbff3bf4cb2c26440c2537c2309e) () |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetTimeText](class_tale_worlds_1_1_campaign_system_1_1_journal_log.html#a28034b8b7d89b847432882894cb098e3) () |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [LogTime](class_tale_worlds_1_1_campaign_system_1_1_journal_log.html#ab1f43ce97ad120e646ccb9a15074d8eb) |
| readonly [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [LogText](class_tale_worlds_1_1_campaign_system_1_1_journal_log.html#a1ad1bdfaeb45018b26fbd50574850fb3) |
| readonly [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [TaskName](class_tale_worlds_1_1_campaign_system_1_1_journal_log.html#a8c57d52de72f3ba1a622c93d43dd0bd8) |
| readonly int | [Range](class_tale_worlds_1_1_campaign_system_1_1_journal_log.html#aa7facfebea6edd5dd6d32bfb348af8da) |
| readonly [LogType](namespace_tale_worlds_1_1_campaign_system.html#a4bf95a9678e6e4b1cd64547db184d391) | [Type](class_tale_worlds_1_1_campaign_system_1_1_journal_log.html#a8fbffe4896de57ebef96eb24e12f0d85) |

|  |  |
| --- | --- |
| Properties | |
| int | [CurrentProgress](class_tale_worlds_1_1_campaign_system_1_1_journal_log.html#a1e8f4cc1e52aac5a6ae5b8fd10e0bf05) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_journal_log.html#a9bda1040fea3184c698ef23f85b7aad0)JournalLog()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.JournalLog.JournalLog | ( | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | *logTime*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *logText*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *taskName* = null, |
|  |  | int | *currentProgress* = 0, |
|  |  | int | *range* = 0, |
|  |  | [LogType](namespace_tale_worlds_1_1_campaign_system.html#a4bf95a9678e6e4b1cd64547db184d391) | *type* = [LogType::Text](namespace_tale_worlds_1_1_campaign_system.html#a4bf95a9678e6e4b1cd64547db184d391a9dffbf69ffba8bc38bc4e01abf4b1675) ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_journal_log.html#aff0f6ba685a08a0bf1b66f9846d7ba25)UpdateCurrentProgress()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.JournalLog.UpdateCurrentProgress | ( | int | *progress* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_journal_log.html#a22e5dbff3bf4cb2c26440c2537c2309e)HasBeenCompleted()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.JournalLog.HasBeenCompleted | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_journal_log.html#a28034b8b7d89b847432882894cb098e3)GetTimeText()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.JournalLog.GetTimeText | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_journal_log.html#ab1f43ce97ad120e646ccb9a15074d8eb)LogTime
--------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.JournalLog.LogTime |

[◆](class_tale_worlds_1_1_campaign_system_1_1_journal_log.html#a1ad1bdfaeb45018b26fbd50574850fb3)LogText
--------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.JournalLog.LogText |

[◆](class_tale_worlds_1_1_campaign_system_1_1_journal_log.html#a8c57d52de72f3ba1a622c93d43dd0bd8)TaskName
---------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.JournalLog.TaskName |

[◆](class_tale_worlds_1_1_campaign_system_1_1_journal_log.html#aa7facfebea6edd5dd6d32bfb348af8da)Range
------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly int TaleWorlds.CampaignSystem.JournalLog.Range |

[◆](class_tale_worlds_1_1_campaign_system_1_1_journal_log.html#a8fbffe4896de57ebef96eb24e12f0d85)Type
-----------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [LogType](namespace_tale_worlds_1_1_campaign_system.html#a4bf95a9678e6e4b1cd64547db184d391) TaleWorlds.CampaignSystem.JournalLog.Type |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_journal_log.html#a1e8f4cc1e52aac5a6ae5b8fd10e0bf05)CurrentProgress
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.JournalLog.CurrentProgress | | get |

