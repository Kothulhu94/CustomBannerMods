--- SOURCE: class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html ---

StoryMode.StoryModePhases.TutorialPhase Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [TutorialPhase](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#a79a94a8606b8111c9af3bdb66dbbfd14) () |
| void | [PlayerTalkedWithBrotherForTheFirstTime](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#a7ff98dc36551281171fcaeecaae50478) () |
| void | [SetLockTutorialVillageEnter](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#a2821391ebf23b75d262facdb8c6c0035) (bool value) |
| void | [CompleteTutorial](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#af2a452b5b586df50fe1aecc659f96604) (bool isSkipped) |
| void | [SetTutorialFocusSettlement](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#afa8d565cd560798831afb87433a8679a) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| void | [RemoveTutorialFocusSettlement](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#acf1a66602833824561f07967a55af166) () |
| void | [RemoveTutorialFocusMobileParty](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#a51be2f8c7d6ce151417d138c08f88207) () |
| void | [PrepareRecruitOptionForTutorial](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#a7eac909bc97a80d2ccbcad712d8b4f4b) () |
| [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) | [GetAndPrepareBuyProductsOptionForTutorial](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#a54afe304fad4989215cbb9c2950dd4c3) ([Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) village) |
| void | [SetTutorialQuestPhase](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#a83a4650245073a831a8fca5615109d2b) ([TutorialQuestPhase](namespace_story_mode_1_1_story_mode_phases.html#acd07062caf9d080128eb2a0150e56802) tutorialQuestPhase) |
| void | [InitializeTutorialVillageItemRoster](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#a5f641e67fc2663310de70668247dcd14) () |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const int | [RestrictedModePriority](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#ac8da2f3939bad194239008bf22a36dfa) = 1000000 |
| const string | [QuestVillageStringId](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#aab0c7716f3ae945d5bfcf1c3b7582e77) = "village\_ES3\_2" |
| const string | [TrainingFieldStringId](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#ad02ac9d6df5b5a40e5ffc60a8aae5b11) = "tutorial\_training\_field" |
| const string | [RadagosRaidersStringId](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#aaa3de07ad54e361212cc1d2f16f7c797) = "storymode\_quest\_raider" |
| const string | [TutorialVolunteerStringId](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#a74ce82362eacb9fba57508f15cd23ab2) = "tutorial\_placeholder\_volunteer" |
| const string | [TutorialFemaleRefugeeStringId](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#ac9923adbde13ebbb795d29de26214a8f) = "storymode\_quest\_refugee\_female" |
| const string | [TutorialMaleRefugeeStringId](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#ac0e5a231954b37386acaca751dce2a12) = "storymode\_quest\_refugee\_male" |
| const string | [TutorialHeadmanStringId](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#ae7b13b8cbacafe34f3d770b755eaea99) = "storymode\_tutorial\_headman" |

|  |  |
| --- | --- |
| Properties | |
| static [TutorialPhase](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#a79a94a8606b8111c9af3bdb66dbbfd14) | [Instance](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#abd3da38f2d6e2be41db7355869878f93) `[get]` |
| [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [TutorialFocusSettlement](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#a45adb2ebddc67ff64cde410ff00fd9f1) `[get]` |
| [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | [TutorialFocusMobileParty](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#adaa2d5c2042680764b9373241c467d91) `[get]` |
| bool | [IsCompleted](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#aa4f9ba83ef775019672f60477d486041) `[get]` |
| bool | [TalkedWithBrotherForTheFirstTime](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#a8fa5310fbe33cb36c554eaa438b2c0d8) `[get]` |
| bool | [LockTutorialVillageEnter](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#af85eb9212e100fc9ec09453df6f8d1d0) `[get]` |
| [TutorialQuestPhase](namespace_story_mode_1_1_story_mode_phases.html#acd07062caf9d080128eb2a0150e56802) | [TutorialQuestPhase](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#a77ac32c0571574d069ada3b7fddcda3c) `[get]` |
| bool | [IsSkipped](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#aefd7d918008e2f4e34ac66e65a2d1722) `[get]` |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [TutorialVillageHeadman](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#a097fd69cc71bbdacc49b92a8dd7a6901) `[get, set]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#a79a94a8606b8111c9af3bdb66dbbfd14)TutorialPhase()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| StoryMode.StoryModePhases.TutorialPhase.TutorialPhase | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#a7ff98dc36551281171fcaeecaae50478)PlayerTalkedWithBrotherForTheFirstTime()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void StoryMode.StoryModePhases.TutorialPhase.PlayerTalkedWithBrotherForTheFirstTime | ( |  | ) |  |

[◆](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#a2821391ebf23b75d262facdb8c6c0035)SetLockTutorialVillageEnter()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void StoryMode.StoryModePhases.TutorialPhase.SetLockTutorialVillageEnter | ( | bool | *value* | ) |  |

[◆](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#af2a452b5b586df50fe1aecc659f96604)CompleteTutorial()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void StoryMode.StoryModePhases.TutorialPhase.CompleteTutorial | ( | bool | *isSkipped* | ) |  |

[◆](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#afa8d565cd560798831afb87433a8679a)SetTutorialFocusSettlement()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void StoryMode.StoryModePhases.TutorialPhase.SetTutorialFocusSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  |

[◆](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#acf1a66602833824561f07967a55af166)RemoveTutorialFocusSettlement()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void StoryMode.StoryModePhases.TutorialPhase.RemoveTutorialFocusSettlement | ( |  | ) |  |

[◆](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#a51be2f8c7d6ce151417d138c08f88207)RemoveTutorialFocusMobileParty()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void StoryMode.StoryModePhases.TutorialPhase.RemoveTutorialFocusMobileParty | ( |  | ) |  |

[◆](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#a7eac909bc97a80d2ccbcad712d8b4f4b)PrepareRecruitOptionForTutorial()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void StoryMode.StoryModePhases.TutorialPhase.PrepareRecruitOptionForTutorial | ( |  | ) |  |

[◆](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#a54afe304fad4989215cbb9c2950dd4c3)GetAndPrepareBuyProductsOptionForTutorial()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) StoryMode.StoryModePhases.TutorialPhase.GetAndPrepareBuyProductsOptionForTutorial | ( | [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) | *village* | ) |  |

[◆](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#a83a4650245073a831a8fca5615109d2b)SetTutorialQuestPhase()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void StoryMode.StoryModePhases.TutorialPhase.SetTutorialQuestPhase | ( | [TutorialQuestPhase](namespace_story_mode_1_1_story_mode_phases.html#acd07062caf9d080128eb2a0150e56802) | *tutorialQuestPhase* | ) |  |

[◆](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#a5f641e67fc2663310de70668247dcd14)InitializeTutorialVillageItemRoster()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void StoryMode.StoryModePhases.TutorialPhase.InitializeTutorialVillageItemRoster | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#ac8da2f3939bad194239008bf22a36dfa)RestrictedModePriority
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int StoryMode.StoryModePhases.TutorialPhase.RestrictedModePriority = 1000000 | | static |

[◆](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#aab0c7716f3ae945d5bfcf1c3b7582e77)QuestVillageStringId
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string StoryMode.StoryModePhases.TutorialPhase.QuestVillageStringId = "village\_ES3\_2" | | static |

[◆](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#ad02ac9d6df5b5a40e5ffc60a8aae5b11)TrainingFieldStringId
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string StoryMode.StoryModePhases.TutorialPhase.TrainingFieldStringId = "tutorial\_training\_field" | | static |

[◆](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#aaa3de07ad54e361212cc1d2f16f7c797)RadagosRaidersStringId
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string StoryMode.StoryModePhases.TutorialPhase.RadagosRaidersStringId = "storymode\_quest\_raider" | | static |

[◆](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#a74ce82362eacb9fba57508f15cd23ab2)TutorialVolunteerStringId
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string StoryMode.StoryModePhases.TutorialPhase.TutorialVolunteerStringId = "tutorial\_placeholder\_volunteer" | | static |

[◆](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#ac9923adbde13ebbb795d29de26214a8f)TutorialFemaleRefugeeStringId
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string StoryMode.StoryModePhases.TutorialPhase.TutorialFemaleRefugeeStringId = "storymode\_quest\_refugee\_female" | | static |

[◆](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#ac0e5a231954b37386acaca751dce2a12)TutorialMaleRefugeeStringId
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string StoryMode.StoryModePhases.TutorialPhase.TutorialMaleRefugeeStringId = "storymode\_quest\_refugee\_male" | | static |

[◆](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#ae7b13b8cbacafe34f3d770b755eaea99)TutorialHeadmanStringId
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string StoryMode.StoryModePhases.TutorialPhase.TutorialHeadmanStringId = "storymode\_tutorial\_headman" | | static |

Property Documentation
----------------------

[◆](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#abd3da38f2d6e2be41db7355869878f93)Instance
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TutorialPhase](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#a79a94a8606b8111c9af3bdb66dbbfd14) StoryMode.StoryModePhases.TutorialPhase.Instance | | staticget |

[◆](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#a45adb2ebddc67ff64cde410ff00fd9f1)TutorialFocusSettlement
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) StoryMode.StoryModePhases.TutorialPhase.TutorialFocusSettlement | | get |

[◆](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#adaa2d5c2042680764b9373241c467d91)TutorialFocusMobileParty
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) StoryMode.StoryModePhases.TutorialPhase.TutorialFocusMobileParty | | get |

[◆](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#aa4f9ba83ef775019672f60477d486041)IsCompleted
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool StoryMode.StoryModePhases.TutorialPhase.IsCompleted | | get |

[◆](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#a8fa5310fbe33cb36c554eaa438b2c0d8)TalkedWithBrotherForTheFirstTime
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool StoryMode.StoryModePhases.TutorialPhase.TalkedWithBrotherForTheFirstTime | | get |

[◆](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#af85eb9212e100fc9ec09453df6f8d1d0)LockTutorialVillageEnter
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool StoryMode.StoryModePhases.TutorialPhase.LockTutorialVillageEnter | | get |

[◆](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#a77ac32c0571574d069ada3b7fddcda3c)TutorialQuestPhase
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TutorialQuestPhase](namespace_story_mode_1_1_story_mode_phases.html#acd07062caf9d080128eb2a0150e56802) StoryMode.StoryModePhases.TutorialPhase.TutorialQuestPhase | | get |

[◆](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#aefd7d918008e2f4e34ac66e65a2d1722)IsSkipped
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool StoryMode.StoryModePhases.TutorialPhase.IsSkipped | | get |

[◆](class_story_mode_1_1_story_mode_phases_1_1_tutorial_phase.html#a097fd69cc71bbdacc49b92a8dd7a6901)TutorialVillageHeadman
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) StoryMode.StoryModePhases.TutorialPhase.TutorialVillageHeadman | | getset |

