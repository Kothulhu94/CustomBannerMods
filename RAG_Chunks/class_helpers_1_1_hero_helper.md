--- SOURCE: class_helpers_1_1_hero_helper.html ---

Helpers.HeroHelper Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetLastSeenText](class_helpers_1_1_hero_helper.html#ae7d57acb29552d709b62956d67bec892) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| static [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [GetClosestSettlement](class_helpers_1_1_hero_helper.html#a13d2cb749ee5833c52ea669c918ebd81) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| static bool | [LordWillConspireWithLord](class_helpers_1_1_hero_helper.html#a9a8dfed3d8616cf7a9f0f7aff25bbb3b) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) lord, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) otherLord, bool suggestingBetrayal) |
| static bool | [UnderPlayerCommand](class_helpers_1_1_hero_helper.html#a6ab1be479931befbe8d21a70d045046c) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| static [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetTitleInIndefiniteCase](class_helpers_1_1_hero_helper.html#ab10b8abfc9345bc2f56e8ac41298061d) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| static [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetCharacterTypeName](class_helpers_1_1_hero_helper.html#a02f74dfb3a42bdf62e8554e511f56849) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| static [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetOccupiedEventReasonText](class_helpers_1_1_hero_helper.html#aeded00d5bdaa68e019f7862e5c5f4981) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| static List< string > | [OrderHeroesOnPlayerSideByPriority](class_helpers_1_1_hero_helper.html#ad23c462d2efc273a2a6f0fba88ca67dc) (bool includeArmyLeader=false, bool includePlayerCompanions=false) |
| static bool | [WillLordAttack](class_helpers_1_1_hero_helper.html#ab29212f90fd05026f6c4bb949a6ea248) () |
| static void | [SetPlayerSalutation](class_helpers_1_1_hero_helper.html#a5ffe577e7799c4ca3c75c7636022cb72) () |
| static void | [SpawnHeroForTheFirstTime](class_helpers_1_1_hero_helper.html#ae672aa23ea7cf417453756b1b7366e5f) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) spawnSettlement) |
| static int | [DefaultRelation](class_helpers_1_1_hero_helper.html#aabbdbb490c735b390227c9da0950baab) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) otherHero) |
| static bool | [IsCompanionInPlayerParty](class_helpers_1_1_hero_helper.html#a676f1261f06bd229e9e47179ad3abb4e) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| static bool | [NPCPoliticalDifferencesWithNPC](class_helpers_1_1_hero_helper.html#a460ebee5f31455b4686d323ae19adeef) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) firstNPC, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) secondNPC) |
| static int | [NPCPersonalityClashWithNPC](class_helpers_1_1_hero_helper.html#ab3a9f2d5a7cdb35b8c84698dc7934e52) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) firstNPC, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) secondNPC) |
| static int | [TraitHarmony](class_helpers_1_1_hero_helper.html#a0706dda59ec8db4b8f13a24231fc20cd) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) considerer, [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html) trait, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) consideree, bool sensitive) |
| static float | [CalculateReliabilityConstant](class_helpers_1_1_hero_helper.html#af07d5f3d51dfdd59623648488ad3f652) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, float maxValueConstant=1.0f) |
| static void | [SetPropertiesToTextObject](class_helpers_1_1_hero_helper.html#a113b0b6464ffce3afce198c599901b60) (this [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) textObject, string tagName) |
| static void | [SetPropertiesToTextObject](class_helpers_1_1_hero_helper.html#a2ccd2df78feef492e3b5413b02456d16) (this [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) textObject, string tagName) |
| static bool | [HeroCanRecruitFromHero](class_helpers_1_1_hero_helper.html#ac57189f8a4d303633b8c259b54e5350b) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) buyerHero, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) sellerHero, int index) |
| static List< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > | [GetVolunteerTroopsOfHeroForRecruitment](class_helpers_1_1_hero_helper.html#a5369b12fe9e44255f280e4fe58c8f142) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| static [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | [GetRandomClanForNotable](class_helpers_1_1_hero_helper.html#ae3e0bcf7ffeab4c850e43db939159479) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) notable) |
| static [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [GetRandomBirthDayForAge](class_helpers_1_1_hero_helper.html#a8212ccbee9f622e4ab3a7a1586364c14) (float age) |
| static void | [GetRandomDeathDayAndBirthDay](class_helpers_1_1_hero_helper.html#a2c7d894d249370c15b8934cc95ab8250) (int deathAge, out [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) birthday, out [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) deathday) |
| static float | [StartRecruitingMoneyLimit](class_helpers_1_1_hero_helper.html#a991c32ca4de106ab29450be67c1fa578) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| static float | [StartRecruitingMoneyLimitForClanLeader](class_helpers_1_1_hero_helper.html#add4d4a42f1a5226577e6187c2a09aabd) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| static [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetPersonalityTraitChangeName](class_helpers_1_1_hero_helper.html#add1093c6c7808a5c04d70ce6cd0c37e8) ([TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html) traitObject, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, bool isPositive) |
| static [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [FindASuitableSettlementToTeleportForHero](class_helpers_1_1_hero_helper.html#a3c45397f6197ecdd0e43bf1a1c2d0a41) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, float minimumScore=0) |

Member Function Documentation
-----------------------------

[◆](class_helpers_1_1_hero_helper.html#ae7d57acb29552d709b62956d67bec892)GetLastSeenText()
------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) Helpers.HeroHelper.GetLastSeenText | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | static |

[◆](class_helpers_1_1_hero_helper.html#a13d2cb749ee5833c52ea669c918ebd81)GetClosestSettlement()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) Helpers.HeroHelper.GetClosestSettlement | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | static |

[◆](class_helpers_1_1_hero_helper.html#a9a8dfed3d8616cf7a9f0f7aff25bbb3b)LordWillConspireWithLord()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool Helpers.HeroHelper.LordWillConspireWithLord | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *lord*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *otherLord*, | |  |  | bool | *suggestingBetrayal* ) | | static |

[◆](class_helpers_1_1_hero_helper.html#a6ab1be479931befbe8d21a70d045046c)UnderPlayerCommand()
---------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool Helpers.HeroHelper.UnderPlayerCommand | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | static |

[◆](class_helpers_1_1_hero_helper.html#ab10b8abfc9345bc2f56e8ac41298061d)GetTitleInIndefiniteCase()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) Helpers.HeroHelper.GetTitleInIndefiniteCase | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | static |

[◆](class_helpers_1_1_hero_helper.html#a02f74dfb3a42bdf62e8554e511f56849)GetCharacterTypeName()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) Helpers.HeroHelper.GetCharacterTypeName | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | static |

[◆](class_helpers_1_1_hero_helper.html#aeded00d5bdaa68e019f7862e5c5f4981)GetOccupiedEventReasonText()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) Helpers.HeroHelper.GetOccupiedEventReasonText | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | static |

[◆](class_helpers_1_1_hero_helper.html#ad23c462d2efc273a2a6f0fba88ca67dc)OrderHeroesOnPlayerSideByPriority()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | List< string > Helpers.HeroHelper.OrderHeroesOnPlayerSideByPriority | ( | bool | *includeArmyLeader* = false, | |  |  | bool | *includePlayerCompanions* = false ) | | static |

[◆](class_helpers_1_1_hero_helper.html#ab29212f90fd05026f6c4bb949a6ea248)WillLordAttack()
-----------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool Helpers.HeroHelper.WillLordAttack | ( |  | ) |  | | static |

[◆](class_helpers_1_1_hero_helper.html#a5ffe577e7799c4ca3c75c7636022cb72)SetPlayerSalutation()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void Helpers.HeroHelper.SetPlayerSalutation | ( |  | ) |  | | static |

[◆](class_helpers_1_1_hero_helper.html#ae672aa23ea7cf417453756b1b7366e5f)SpawnHeroForTheFirstTime()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.HeroHelper.SpawnHeroForTheFirstTime | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *spawnSettlement* ) | | static |

[◆](class_helpers_1_1_hero_helper.html#aabbdbb490c735b390227c9da0950baab)DefaultRelation()
------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int Helpers.HeroHelper.DefaultRelation | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *otherHero* ) | | static |

[◆](class_helpers_1_1_hero_helper.html#a676f1261f06bd229e9e47179ad3abb4e)IsCompanionInPlayerParty()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool Helpers.HeroHelper.IsCompanionInPlayerParty | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | static |

[◆](class_helpers_1_1_hero_helper.html#a460ebee5f31455b4686d323ae19adeef)NPCPoliticalDifferencesWithNPC()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool Helpers.HeroHelper.NPCPoliticalDifferencesWithNPC | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *firstNPC*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *secondNPC* ) | | static |

[◆](class_helpers_1_1_hero_helper.html#ab3a9f2d5a7cdb35b8c84698dc7934e52)NPCPersonalityClashWithNPC()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int Helpers.HeroHelper.NPCPersonalityClashWithNPC | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *firstNPC*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *secondNPC* ) | | static |

[◆](class_helpers_1_1_hero_helper.html#a0706dda59ec8db4b8f13a24231fc20cd)TraitHarmony()
---------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int Helpers.HeroHelper.TraitHarmony | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *considerer*, | |  |  | [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html) | *trait*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *consideree*, | |  |  | bool | *sensitive* ) | | static |

[◆](class_helpers_1_1_hero_helper.html#af07d5f3d51dfdd59623648488ad3f652)CalculateReliabilityConstant()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float Helpers.HeroHelper.CalculateReliabilityConstant | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | float | *maxValueConstant* = 1::0f ) | | static |

[◆](class_helpers_1_1_hero_helper.html#a113b0b6464ffce3afce198c599901b60)SetPropertiesToTextObject() [1/2]
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.HeroHelper.SetPropertiesToTextObject | ( | this [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *textObject*, | |  |  | string | *tagName* ) | | static |

[◆](class_helpers_1_1_hero_helper.html#a2ccd2df78feef492e3b5413b02456d16)SetPropertiesToTextObject() [2/2]
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.HeroHelper.SetPropertiesToTextObject | ( | this [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *textObject*, | |  |  | string | *tagName* ) | | static |

[◆](class_helpers_1_1_hero_helper.html#ac57189f8a4d303633b8c259b54e5350b)HeroCanRecruitFromHero()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool Helpers.HeroHelper.HeroCanRecruitFromHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *buyerHero*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *sellerHero*, | |  |  | int | *index* ) | | static |

[◆](class_helpers_1_1_hero_helper.html#a5369b12fe9e44255f280e4fe58c8f142)GetVolunteerTroopsOfHeroForRecruitment()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | List< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > Helpers.HeroHelper.GetVolunteerTroopsOfHeroForRecruitment | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | static |

[◆](class_helpers_1_1_hero_helper.html#ae3e0bcf7ffeab4c850e43db939159479)GetRandomClanForNotable()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) Helpers.HeroHelper.GetRandomClanForNotable | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *notable* | ) |  | | static |

[◆](class_helpers_1_1_hero_helper.html#a8212ccbee9f622e4ab3a7a1586364c14)GetRandomBirthDayForAge()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) Helpers.HeroHelper.GetRandomBirthDayForAge | ( | float | *age* | ) |  | | static |

[◆](class_helpers_1_1_hero_helper.html#a2c7d894d249370c15b8934cc95ab8250)GetRandomDeathDayAndBirthDay()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.HeroHelper.GetRandomDeathDayAndBirthDay | ( | int | *deathAge*, | |  |  | out [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | *birthday*, | |  |  | out [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | *deathday* ) | | static |

[◆](class_helpers_1_1_hero_helper.html#a991c32ca4de106ab29450be67c1fa578)StartRecruitingMoneyLimit()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float Helpers.HeroHelper.StartRecruitingMoneyLimit | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | static |

[◆](class_helpers_1_1_hero_helper.html#add4d4a42f1a5226577e6187c2a09aabd)StartRecruitingMoneyLimitForClanLeader()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float Helpers.HeroHelper.StartRecruitingMoneyLimitForClanLeader | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | static |

[◆](class_helpers_1_1_hero_helper.html#add1093c6c7808a5c04d70ce6cd0c37e8)GetPersonalityTraitChangeName()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) Helpers.HeroHelper.GetPersonalityTraitChangeName | ( | [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html) | *traitObject*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | bool | *isPositive* ) | | static |

[◆](class_helpers_1_1_hero_helper.html#a3c45397f6197ecdd0e43bf1a1c2d0a41)FindASuitableSettlementToTeleportForHero()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) Helpers.HeroHelper.FindASuitableSettlementToTeleportForHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | float | *minimumScore* = 0 ) | | static |

