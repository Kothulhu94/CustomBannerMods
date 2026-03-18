--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_romance.html ---

TaleWorlds.CampaignSystem.Romance Class Reference|  |  |
| --- | --- |
| Classes | |
| class | [RomanticState](class_tale_worlds_1_1_campaign_system_1_1_romance_1_1_romantic_state.html) |

|  |  |
| --- | --- |
| Public Types | |
| enum | [RomanceLevelEnum](class_tale_worlds_1_1_campaign_system_1_1_romance.html#ad42c0267fbc71f2db0cd6f26841f9d5a) {     [Ended](class_tale_worlds_1_1_campaign_system_1_1_romance.html#ad42c0267fbc71f2db0cd6f26841f9d5aa0157fbb99be9622bdaa6e544270c0622) = -2 ,     [Rejection](class_tale_worlds_1_1_campaign_system_1_1_romance.html#ad42c0267fbc71f2db0cd6f26841f9d5aaaf7ef717dc1ce4677e04b5605b132240) = -1 ,     [Untested](class_tale_worlds_1_1_campaign_system_1_1_romance.html#ad42c0267fbc71f2db0cd6f26841f9d5aacade351511c38951fd65431cb4b5e17e) = 0 ,     [FailedInCompatibility](class_tale_worlds_1_1_campaign_system_1_1_romance.html#ad42c0267fbc71f2db0cd6f26841f9d5aaebafe6bb4af92ed1408e6855405e0ed5) = 1 ,     [FailedInPracticalities](class_tale_worlds_1_1_campaign_system_1_1_romance.html#ad42c0267fbc71f2db0cd6f26841f9d5aac4286dd3ac332d1f38446df440f8989f) = 2 ,     [MatchMadeByFamily](class_tale_worlds_1_1_campaign_system_1_1_romance.html#ad42c0267fbc71f2db0cd6f26841f9d5aa45d8ab537e0187eaeacf26893e4d2a6e) = 3 ,     [CourtshipStarted](class_tale_worlds_1_1_campaign_system_1_1_romance.html#ad42c0267fbc71f2db0cd6f26841f9d5aab32b61f5c5441e4094ead8927ac4db5b) = 4 ,     [CoupleDecidedThatTheyAreCompatible](class_tale_worlds_1_1_campaign_system_1_1_romance.html#ad42c0267fbc71f2db0cd6f26841f9d5aa180b2cf78198547c9732f59a233feb3f) = 5 ,     [CoupleAgreedOnMarriage](class_tale_worlds_1_1_campaign_system_1_1_romance.html#ad42c0267fbc71f2db0cd6f26841f9d5aa26e44e259a20eac0b0ed51c40a755813) = 6 ,     [Marriage](class_tale_worlds_1_1_campaign_system_1_1_romance.html#ad42c0267fbc71f2db0cd6f26841f9d5aa2e9f93233580ec886416786b61de35a7) = 7   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [Romance](class_tale_worlds_1_1_campaign_system_1_1_romance.html#a16bfdbf96d0b510dab51811f4f5a0a4c) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [GetCourtedHeroInOtherClan](class_tale_worlds_1_1_campaign_system_1_1_romance.html#a01967c4d60ae8fc4af846b394803523c) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) person1, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) person2) |
| static [RomanceLevelEnum](class_tale_worlds_1_1_campaign_system_1_1_romance.html#ad42c0267fbc71f2db0cd6f26841f9d5a) | [GetRomanticLevel](class_tale_worlds_1_1_campaign_system_1_1_romance.html#adce9c5864762f1a342b4ead8c063a6fc) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) person1, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) person2) |
| static [RomanticState](class_tale_worlds_1_1_campaign_system_1_1_romance_1_1_romantic_state.html) | [GetRomanticState](class_tale_worlds_1_1_campaign_system_1_1_romance.html#a92465d9b8ce3864d7b1b663967ad8052) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) person1, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) person2) |

|  |  |
| --- | --- |
| Properties | |
| static List< [RomanticState](class_tale_worlds_1_1_campaign_system_1_1_romance_1_1_romantic_state.html) > | [RomanticStateList](class_tale_worlds_1_1_campaign_system_1_1_romance.html#a667acf41698d7d9ad8861fad7283fb01) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_romance.html#ad42c0267fbc71f2db0cd6f26841f9d5a)RomanceLevelEnum
-------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.Romance.RomanceLevelEnum](class_tale_worlds_1_1_campaign_system_1_1_romance.html#ad42c0267fbc71f2db0cd6f26841f9d5a) |

| Enumerator | |
| --- | --- |
| Ended |  |
| Rejection |  |
| Untested |  |
| FailedInCompatibility |  |
| FailedInPracticalities |  |
| MatchMadeByFamily |  |
| CourtshipStarted |  |
| CoupleDecidedThatTheyAreCompatible |  |
| CoupleAgreedOnMarriage |  |
| Marriage |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_romance.html#a16bfdbf96d0b510dab51811f4f5a0a4c)Romance()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Romance.Romance | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_romance.html#a01967c4d60ae8fc4af846b394803523c)GetCourtedHeroInOtherClan()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.Romance.GetCourtedHeroInOtherClan | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *person1*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *person2* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_romance.html#adce9c5864762f1a342b4ead8c063a6fc)GetRomanticLevel()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [RomanceLevelEnum](class_tale_worlds_1_1_campaign_system_1_1_romance.html#ad42c0267fbc71f2db0cd6f26841f9d5a) TaleWorlds.CampaignSystem.Romance.GetRomanticLevel | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *person1*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *person2* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_romance.html#a92465d9b8ce3864d7b1b663967ad8052)GetRomanticState()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [RomanticState](class_tale_worlds_1_1_campaign_system_1_1_romance_1_1_romantic_state.html) TaleWorlds.CampaignSystem.Romance.GetRomanticState | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *person1*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *person2* ) | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_romance.html#a667acf41698d7d9ad8861fad7283fb01)RomanticStateList
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[RomanticState](class_tale_worlds_1_1_campaign_system_1_1_romance_1_1_romantic_state.html)> TaleWorlds.CampaignSystem.Romance.RomanticStateList | | staticget |

