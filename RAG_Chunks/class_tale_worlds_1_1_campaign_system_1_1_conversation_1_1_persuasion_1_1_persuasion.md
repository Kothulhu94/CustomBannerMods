--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion.html ---

TaleWorlds.CampaignSystem.Conversation.Persuasion.Persuasion Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [Persuasion](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion.html#a7d2c0c8ef7cd9257ebc4d7dafec7e2b4) (float goalValue, float successValue, float failValue, float criticalSuccessValue, float criticalFailValue, float initialProgress, [PersuasionDifficulty](namespace_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion.html#ae8284e7d59bf7ae3a6c134ddc77c2a4f) difficulty) |
| void | [CommitProgress](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion.html#a796b582e9d24f914c582a8c87ddc1f9b) ([PersuasionOptionArgs](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html) persuasionOptionArgs) |
| IEnumerable< Tuple< [PersuasionOptionArgs](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html), [PersuasionOptionResult](namespace_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion.html#af96cf6cbd7b80fb4690c9143ff5841c1) > > | [GetChosenOptions](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion.html#a0529f977c8ffc21a2b55d5a1bedaa78c) () |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly float | [SuccessValue](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion.html#ac59e0da2d610560534be2d51ad25c723) |
| readonly float | [FailValue](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion.html#ad379ffb47199d73f61f7e388d10043b1) |
| readonly float | [CriticalSuccessValue](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion.html#ada6bbcca4afcb801879e49ca85444398) |
| readonly float | [CriticalFailValue](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion.html#aeda61e496f5293bee6f0d76b1e0a5c82) |
| readonly float | [GoalValue](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion.html#ae48f87df3c170cf443df62a613dffc49) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static ? [PersuasionOptionResult](namespace_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion.html#af96cf6cbd7b80fb4690c9143ff5841c1) | [CheatResult](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion.html#a6a813e15db72cecdce7a108d915b622a) = null |

|  |  |
| --- | --- |
| Properties | |
| float | [DifficultyMultiplier](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion.html#a71f54ea3d1dd6e7de086ae5796a0d68a) `[get]` |
| float | [Progress](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion.html#a60b7b7f7b3ed581220a612d91def71fc) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion.html#a7d2c0c8ef7cd9257ebc4d7dafec7e2b4)Persuasion()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Conversation.Persuasion.Persuasion.Persuasion | ( | float | *goalValue*, |
|  |  | float | *successValue*, |
|  |  | float | *failValue*, |
|  |  | float | *criticalSuccessValue*, |
|  |  | float | *criticalFailValue*, |
|  |  | float | *initialProgress*, |
|  |  | [PersuasionDifficulty](namespace_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion.html#ae8284e7d59bf7ae3a6c134ddc77c2a4f) | *difficulty* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion.html#a796b582e9d24f914c582a8c87ddc1f9b)CommitProgress()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Conversation.Persuasion.Persuasion.CommitProgress | ( | [PersuasionOptionArgs](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html) | *persuasionOptionArgs* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion.html#a0529f977c8ffc21a2b55d5a1bedaa78c)GetChosenOptions()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< Tuple< [PersuasionOptionArgs](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html), [PersuasionOptionResult](namespace_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion.html#af96cf6cbd7b80fb4690c9143ff5841c1) > > TaleWorlds.CampaignSystem.Conversation.Persuasion.Persuasion.GetChosenOptions | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion.html#ac59e0da2d610560534be2d51ad25c723)SuccessValue
--------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly float TaleWorlds.CampaignSystem.Conversation.Persuasion.Persuasion.SuccessValue |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion.html#ad379ffb47199d73f61f7e388d10043b1)FailValue
-----------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly float TaleWorlds.CampaignSystem.Conversation.Persuasion.Persuasion.FailValue |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion.html#ada6bbcca4afcb801879e49ca85444398)CriticalSuccessValue
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly float TaleWorlds.CampaignSystem.Conversation.Persuasion.Persuasion.CriticalSuccessValue |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion.html#aeda61e496f5293bee6f0d76b1e0a5c82)CriticalFailValue
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly float TaleWorlds.CampaignSystem.Conversation.Persuasion.Persuasion.CriticalFailValue |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion.html#ae48f87df3c170cf443df62a613dffc49)GoalValue
-----------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly float TaleWorlds.CampaignSystem.Conversation.Persuasion.Persuasion.GoalValue |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion.html#a6a813e15db72cecdce7a108d915b622a)CheatResult
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ? [PersuasionOptionResult](namespace_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion.html#af96cf6cbd7b80fb4690c9143ff5841c1) TaleWorlds.CampaignSystem.Conversation.Persuasion.Persuasion.CheatResult = null | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion.html#a71f54ea3d1dd6e7de086ae5796a0d68a)DifficultyMultiplier
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Conversation.Persuasion.Persuasion.DifficultyMultiplier | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion.html#a60b7b7f7b3ed581220a612d91def71fc)Progress
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Conversation.Persuasion.Persuasion.Progress | | get |

