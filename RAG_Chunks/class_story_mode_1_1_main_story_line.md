--- SOURCE: class_story_mode_1_1_main_story_line.html ---

StoryMode.MainStoryLine Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MainStoryLine](class_story_mode_1_1_main_story_line.html#a476188a3a95570d2aa13224ac18ab83a) () |
| void | [OnSessionLaunched](class_story_mode_1_1_main_story_line.html#acb5d6777ac69a1e7b0da33d0dd3502a0) () |
| void | [SetTutorialScores](class_story_mode_1_1_main_story_line.html#ab9627af00f7423d8b28f9ba34d1e55a0) (Dictionary< string, float > scores) |
| Dictionary< string, float > | [GetTutorialScores](class_story_mode_1_1_main_story_line.html#a6541e24568aa8615c9eb5fc4f38b93ed) () |
| void | [SetStoryLineSide](class_story_mode_1_1_main_story_line.html#adfc789beb27a68df3876dfc52e650295) ([MainStoryLineSide](namespace_story_mode.html#ada106a624ba015e501ee174cb0cdf911) side) |
| void | [SetMentorSettlements](class_story_mode_1_1_main_story_line.html#a390976cf9501171698112d98e9d3eb44) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) imperialMentorSettlement, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) antiImperialMentorSettlement) |
| void | [CompleteTutorialPhase](class_story_mode_1_1_main_story_line.html#a287842dca89c51171cc7cb64c60ff26b) (bool isSkipped) |
| void | [CompleteFirstPhase](class_story_mode_1_1_main_story_line.html#a939819192b85cd01c9f4c63894d8d674) () |
| void | [CompleteSecondPhase](class_story_mode_1_1_main_story_line.html#a0484c24070cc3baf7c3e37bad9b5ae0e) () |
| void | [CancelSecondAndThirdPhase](class_story_mode_1_1_main_story_line.html#aa6de64853e7186c76fe12e2c7d21054d) () |

|  |  |
| --- | --- |
| Public Attributes | |
| [MainStoryLineSide](namespace_story_mode.html#ada106a624ba015e501ee174cb0cdf911) | [MainStoryLineSide](class_story_mode_1_1_main_story_line.html#ae4c1dbf39c3fdbe7288610290a6f6653) |
| [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [ImperialMentorSettlement](class_story_mode_1_1_main_story_line.html#a8a9afb8f4e7d150bf188e02f4fb42f33) |
| [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [AntiImperialMentorSettlement](class_story_mode_1_1_main_story_line.html#ae0fdc651a514733d1b513fc898e957f3) |
| bool | [FamilyRescued](class_story_mode_1_1_main_story_line.html#a23e322f0c455b112d2a58f3270558a3f) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const int | [MainStoryLineDialogOptionPriority](class_story_mode_1_1_main_story_line.html#a734e02086cc75b9eb8da924ec8899900) = 150 |
| const string | [DragonBannerItemStringId](class_story_mode_1_1_main_story_line.html#a49ccc5dd50888a3a7d4afbb173b68872) = "dragon\_banner" |
| const string | [DragonBannerPart1ItemStringId](class_story_mode_1_1_main_story_line.html#a5557c8f1ff7180a39b57eda5255e4d6a) = "dragon\_banner\_center" |
| const string | [DragonBannerPart2ItemStringId](class_story_mode_1_1_main_story_line.html#ad2d3cb7786af2665a05fad7eda4fa30e) = "dragon\_banner\_dragonhead" |
| const string | [DragonBannerPart3ItemStringId](class_story_mode_1_1_main_story_line.html#a9706ccdefe717219c2d48a14eae2ac2f) = "dragon\_banner\_handle" |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsPlayerInteractionRestricted](class_story_mode_1_1_main_story_line.html#afe5cc53a04f707198bac53cedf1658de) `[get]` |
| bool | [IsOnImperialQuestLine](class_story_mode_1_1_main_story_line.html#a6a22b973f98c2041ca5cda94f38c0601) `[get]` |
| bool | [IsOnAntiImperialQuestLine](class_story_mode_1_1_main_story_line.html#a6f46c5ede1a62ea3b6da07161a560cb6) `[get]` |
| TutorialPhase | [TutorialPhase](class_story_mode_1_1_main_story_line.html#a196ed3725d41c137a005211d718aaf0a) `[get]` |
| FirstPhase | [FirstPhase](class_story_mode_1_1_main_story_line.html#a0dfe2e338e27f692b6f91177bc16b3d1) `[get]` |
| SecondPhase | [SecondPhase](class_story_mode_1_1_main_story_line.html#a041bb83a0ee26fe5001813b1fc68f7dd) `[get]` |
| ThirdPhase | [ThirdPhase](class_story_mode_1_1_main_story_line.html#aecee67ac229b0f5f1728afe32f7bab68) `[get]` |
| [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | [PlayerSupportedKingdom](class_story_mode_1_1_main_story_line.html#a3f6564be6f54299233425ba897708c6c) `[get]` |
| bool | [IsCompleted](class_story_mode_1_1_main_story_line.html#af21b00760f71f8a5dfe13eb310216135) `[get]` |
| [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | [DragonBanner](class_story_mode_1_1_main_story_line.html#a18cc7b20be56e173f7fed38f5368648d) `[get]` |
| bool | [IsFirstPhaseCompleted](class_story_mode_1_1_main_story_line.html#a844e031548838b26742a77eed3cd77cd) `[get]` |
| bool | [IsSecondPhaseCompleted](class_story_mode_1_1_main_story_line.html#a44c92333fdacf5dfff192113a18d23c5) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_story_mode_1_1_main_story_line.html#a476188a3a95570d2aa13224ac18ab83a)MainStoryLine()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| StoryMode.MainStoryLine.MainStoryLine | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_story_mode_1_1_main_story_line.html#acb5d6777ac69a1e7b0da33d0dd3502a0)OnSessionLaunched()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void StoryMode.MainStoryLine.OnSessionLaunched | ( |  | ) |  |

[◆](class_story_mode_1_1_main_story_line.html#ab9627af00f7423d8b28f9ba34d1e55a0)SetTutorialScores()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void StoryMode.MainStoryLine.SetTutorialScores | ( | Dictionary< string, float > | *scores* | ) |  |

[◆](class_story_mode_1_1_main_story_line.html#a6541e24568aa8615c9eb5fc4f38b93ed)GetTutorialScores()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| Dictionary< string, float > StoryMode.MainStoryLine.GetTutorialScores | ( |  | ) |  |

[◆](class_story_mode_1_1_main_story_line.html#adfc789beb27a68df3876dfc52e650295)SetStoryLineSide()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void StoryMode.MainStoryLine.SetStoryLineSide | ( | [MainStoryLineSide](namespace_story_mode.html#ada106a624ba015e501ee174cb0cdf911) | *side* | ) |  |

[◆](class_story_mode_1_1_main_story_line.html#a390976cf9501171698112d98e9d3eb44)SetMentorSettlements()
------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void StoryMode.MainStoryLine.SetMentorSettlements | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *imperialMentorSettlement*, |
|  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *antiImperialMentorSettlement* ) |

[◆](class_story_mode_1_1_main_story_line.html#a287842dca89c51171cc7cb64c60ff26b)CompleteTutorialPhase()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void StoryMode.MainStoryLine.CompleteTutorialPhase | ( | bool | *isSkipped* | ) |  |

[◆](class_story_mode_1_1_main_story_line.html#a939819192b85cd01c9f4c63894d8d674)CompleteFirstPhase()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void StoryMode.MainStoryLine.CompleteFirstPhase | ( |  | ) |  |

[◆](class_story_mode_1_1_main_story_line.html#a0484c24070cc3baf7c3e37bad9b5ae0e)CompleteSecondPhase()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void StoryMode.MainStoryLine.CompleteSecondPhase | ( |  | ) |  |

[◆](class_story_mode_1_1_main_story_line.html#aa6de64853e7186c76fe12e2c7d21054d)CancelSecondAndThirdPhase()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void StoryMode.MainStoryLine.CancelSecondAndThirdPhase | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_story_mode_1_1_main_story_line.html#a734e02086cc75b9eb8da924ec8899900)MainStoryLineDialogOptionPriority
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int StoryMode.MainStoryLine.MainStoryLineDialogOptionPriority = 150 | | static |

[◆](class_story_mode_1_1_main_story_line.html#a49ccc5dd50888a3a7d4afbb173b68872)DragonBannerItemStringId
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string StoryMode.MainStoryLine.DragonBannerItemStringId = "dragon\_banner" | | static |

[◆](class_story_mode_1_1_main_story_line.html#a5557c8f1ff7180a39b57eda5255e4d6a)DragonBannerPart1ItemStringId
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string StoryMode.MainStoryLine.DragonBannerPart1ItemStringId = "dragon\_banner\_center" | | static |

[◆](class_story_mode_1_1_main_story_line.html#ad2d3cb7786af2665a05fad7eda4fa30e)DragonBannerPart2ItemStringId
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string StoryMode.MainStoryLine.DragonBannerPart2ItemStringId = "dragon\_banner\_dragonhead" | | static |

[◆](class_story_mode_1_1_main_story_line.html#a9706ccdefe717219c2d48a14eae2ac2f)DragonBannerPart3ItemStringId
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string StoryMode.MainStoryLine.DragonBannerPart3ItemStringId = "dragon\_banner\_handle" | | static |

[◆](class_story_mode_1_1_main_story_line.html#ae4c1dbf39c3fdbe7288610290a6f6653)MainStoryLineSide
-------------------------------------------------------------------------------------------------

|  |
| --- |
| [MainStoryLineSide](namespace_story_mode.html#ada106a624ba015e501ee174cb0cdf911) StoryMode.MainStoryLine.MainStoryLineSide |

[◆](class_story_mode_1_1_main_story_line.html#a8a9afb8f4e7d150bf188e02f4fb42f33)ImperialMentorSettlement
--------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) StoryMode.MainStoryLine.ImperialMentorSettlement |

[◆](class_story_mode_1_1_main_story_line.html#ae0fdc651a514733d1b513fc898e957f3)AntiImperialMentorSettlement
------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) StoryMode.MainStoryLine.AntiImperialMentorSettlement |

[◆](class_story_mode_1_1_main_story_line.html#a23e322f0c455b112d2a58f3270558a3f)FamilyRescued
---------------------------------------------------------------------------------------------

|  |
| --- |
| bool StoryMode.MainStoryLine.FamilyRescued |

Property Documentation
----------------------

[◆](class_story_mode_1_1_main_story_line.html#afe5cc53a04f707198bac53cedf1658de)IsPlayerInteractionRestricted
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool StoryMode.MainStoryLine.IsPlayerInteractionRestricted | | get |

[◆](class_story_mode_1_1_main_story_line.html#a6a22b973f98c2041ca5cda94f38c0601)IsOnImperialQuestLine
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool StoryMode.MainStoryLine.IsOnImperialQuestLine | | get |

[◆](class_story_mode_1_1_main_story_line.html#a6f46c5ede1a62ea3b6da07161a560cb6)IsOnAntiImperialQuestLine
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool StoryMode.MainStoryLine.IsOnAntiImperialQuestLine | | get |

[◆](class_story_mode_1_1_main_story_line.html#a196ed3725d41c137a005211d718aaf0a)TutorialPhase
---------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | TutorialPhase StoryMode.MainStoryLine.TutorialPhase | | get |

[◆](class_story_mode_1_1_main_story_line.html#a0dfe2e338e27f692b6f91177bc16b3d1)FirstPhase
------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | FirstPhase StoryMode.MainStoryLine.FirstPhase | | get |

[◆](class_story_mode_1_1_main_story_line.html#a041bb83a0ee26fe5001813b1fc68f7dd)SecondPhase
-------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | SecondPhase StoryMode.MainStoryLine.SecondPhase | | get |

[◆](class_story_mode_1_1_main_story_line.html#aecee67ac229b0f5f1728afe32f7bab68)ThirdPhase
------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ThirdPhase StoryMode.MainStoryLine.ThirdPhase | | get |

[◆](class_story_mode_1_1_main_story_line.html#a3f6564be6f54299233425ba897708c6c)PlayerSupportedKingdom
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) StoryMode.MainStoryLine.PlayerSupportedKingdom | | get |

[◆](class_story_mode_1_1_main_story_line.html#af21b00760f71f8a5dfe13eb310216135)IsCompleted
-------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool StoryMode.MainStoryLine.IsCompleted | | get |

[◆](class_story_mode_1_1_main_story_line.html#a18cc7b20be56e173f7fed38f5368648d)DragonBanner
--------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) StoryMode.MainStoryLine.DragonBanner | | get |

[◆](class_story_mode_1_1_main_story_line.html#a844e031548838b26742a77eed3cd77cd)IsFirstPhaseCompleted
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool StoryMode.MainStoryLine.IsFirstPhaseCompleted | | get |

[◆](class_story_mode_1_1_main_story_line.html#a44c92333fdacf5dfff192113a18d23c5)IsSecondPhaseCompleted
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool StoryMode.MainStoryLine.IsSecondPhaseCompleted | | get |

