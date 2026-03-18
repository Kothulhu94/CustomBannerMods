--- SOURCE: class_helpers_1_1_mobile_party_helper.html ---

Helpers.MobilePartyHelper Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
| delegate void | [ResumePartyEscortBehaviorDelegate](class_helpers_1_1_mobile_party_helper.html#a31a30e280695e8ccd331211d6a80dad6) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | [SpawnLordParty](class_helpers_1_1_mobile_party_helper.html#aa39ab758db0d744c08f5e89c4e7cc885) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) spawnSettlement) |
| static [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | [SpawnLordParty](class_helpers_1_1_mobile_party_helper.html#a8cdf938735b509ab4391374a45fc7d80) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) position, float spawnRadius) |
| static [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | [CreateNewClanMobileParty](class_helpers_1_1_mobile_party_helper.html#aa901f3a8c4e4e0e87a79510ef23b40fa) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| static bool | [IsHeroAssignableForScoutInParty](class_helpers_1_1_mobile_party_helper.html#a884a473bef6f006a4f779ec5440cb872) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |
| static bool | [IsHeroAssignableForEngineerInParty](class_helpers_1_1_mobile_party_helper.html#a6e807f72aa3a5db86d4e2860994a6fa0) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |
| static bool | [IsHeroAssignableForSurgeonInParty](class_helpers_1_1_mobile_party_helper.html#a267484d12c6ceb1d2b11a62987afd8d7) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |
| static bool | [IsHeroAssignableForQuartermasterInParty](class_helpers_1_1_mobile_party_helper.html#a7035c9454ff333f296cfac72a371b342) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |
| static [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [GetHeroWithHighestSkill](class_helpers_1_1_mobile_party_helper.html#aca789ee17bfc24439f680f3c934ca52f) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill) |
| static [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | [GetStrongestAndPriorTroops](class_helpers_1_1_mobile_party_helper.html#ad2214babe6e19a7108276abc35d2ec51) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, int maxTroopCount, bool includePlayer) |
| static [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | [GetStrongestAndPriorTroops](class_helpers_1_1_mobile_party_helper.html#a26bf81b731666c61e5c5869130294c25) ([FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) roster, int maxTroopCount, bool includePlayer) |
| static int | [GetMaximumXpAmountPartyCanGet](class_helpers_1_1_mobile_party_helper.html#a6f33543437c63bcd17dd309d913ac62c) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |
| static void | [PartyAddSharedXp](class_helpers_1_1_mobile_party_helper.html#a81787cd69e17b5c4212bcd86a113fa4a) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, float xpToDistribute) |
| static void | [WoundNumberOfNonHeroTroopsRandomlyWithChanceOfDeath](class_helpers_1_1_mobile_party_helper.html#aea97ead8f7be2034f1be57f8e8969a8a) ([TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) roster, int numberOfMen, float chanceOfDeathPerUnit, out int deathAmount) |
| static bool | [CanTroopGainXp](class_helpers_1_1_mobile_party_helper.html#ae9a8399d85712f387dae0ef60f53a2a8) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) owner, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, out int gainableMaxXp) |
| static void | [TryMatchPartySpeedWithItemWeight](class_helpers_1_1_mobile_party_helper.html#a2173c668d7f7de83c1fb78a87d2d6c3f) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, float targetPartySpeed, [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) itemToUse=null) |
|  | Adds or removes counts of the specified or default item object in an effort to match target party speed. |
| static [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [GetMainPartySkillCounsellor](class_helpers_1_1_mobile_party_helper.html#a7a3779436acff67b3551439bf40420ff) ([SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill) |
| static [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [GetCurrentSettlementOfMobilePartyForAICalculation](class_helpers_1_1_mobile_party_helper.html#a2b304c6274a5d9644c85839bd71005e4) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| static [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | [GetPlayerPrisonersPlayerCanSell](class_helpers_1_1_mobile_party_helper.html#a15618563a0063c634b7f68f244b6db45) () |
| static void | [FillPartyManuallyAfterCreation](class_helpers_1_1_mobile_party_helper.html#a9d1151af2e6ad5d2777e7e46b5f36a5e) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) partyTemplate, int desiredMenCount) |
| static bool | [CanPartyAttackWithCurrentMorale](class_helpers_1_1_mobile_party_helper.html#a80d00b21a6cae6ed6a7575d14fbf8213) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |

Member Function Documentation
-----------------------------

[◆](class_helpers_1_1_mobile_party_helper.html#a31a30e280695e8ccd331211d6a80dad6)ResumePartyEscortBehaviorDelegate()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| delegate void Helpers.MobilePartyHelper.ResumePartyEscortBehaviorDelegate | ( |  | ) |  |

[◆](class_helpers_1_1_mobile_party_helper.html#aa39ab758db0d744c08f5e89c4e7cc885)SpawnLordParty() [1/2]
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) Helpers.MobilePartyHelper.SpawnLordParty | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *spawnSettlement* ) | | static |

[◆](class_helpers_1_1_mobile_party_helper.html#a8cdf938735b509ab4391374a45fc7d80)SpawnLordParty() [2/2]
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) Helpers.MobilePartyHelper.SpawnLordParty | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *position*, | |  |  | float | *spawnRadius* ) | | static |

[◆](class_helpers_1_1_mobile_party_helper.html#aa901f3a8c4e4e0e87a79510ef23b40fa)CreateNewClanMobileParty()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) Helpers.MobilePartyHelper.CreateNewClanMobileParty | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* ) | | static |

[◆](class_helpers_1_1_mobile_party_helper.html#a884a473bef6f006a4f779ec5440cb872)IsHeroAssignableForScoutInParty()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool Helpers.MobilePartyHelper.IsHeroAssignableForScoutInParty | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* ) | | static |

[◆](class_helpers_1_1_mobile_party_helper.html#a6e807f72aa3a5db86d4e2860994a6fa0)IsHeroAssignableForEngineerInParty()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool Helpers.MobilePartyHelper.IsHeroAssignableForEngineerInParty | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* ) | | static |

[◆](class_helpers_1_1_mobile_party_helper.html#a267484d12c6ceb1d2b11a62987afd8d7)IsHeroAssignableForSurgeonInParty()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool Helpers.MobilePartyHelper.IsHeroAssignableForSurgeonInParty | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* ) | | static |

[◆](class_helpers_1_1_mobile_party_helper.html#a7035c9454ff333f296cfac72a371b342)IsHeroAssignableForQuartermasterInParty()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool Helpers.MobilePartyHelper.IsHeroAssignableForQuartermasterInParty | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* ) | | static |

[◆](class_helpers_1_1_mobile_party_helper.html#aca789ee17bfc24439f680f3c934ca52f)GetHeroWithHighestSkill()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) Helpers.MobilePartyHelper.GetHeroWithHighestSkill | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill* ) | | static |

[◆](class_helpers_1_1_mobile_party_helper.html#ad2214babe6e19a7108276abc35d2ec51)GetStrongestAndPriorTroops() [1/2]
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) Helpers.MobilePartyHelper.GetStrongestAndPriorTroops | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, | |  |  | int | *maxTroopCount*, | |  |  | bool | *includePlayer* ) | | static |

[◆](class_helpers_1_1_mobile_party_helper.html#a26bf81b731666c61e5c5869130294c25)GetStrongestAndPriorTroops() [2/2]
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) Helpers.MobilePartyHelper.GetStrongestAndPriorTroops | ( | [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) | *roster*, | |  |  | int | *maxTroopCount*, | |  |  | bool | *includePlayer* ) | | static |

[◆](class_helpers_1_1_mobile_party_helper.html#a6f33543437c63bcd17dd309d913ac62c)GetMaximumXpAmountPartyCanGet()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int Helpers.MobilePartyHelper.GetMaximumXpAmountPartyCanGet | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* | ) |  | | static |

[◆](class_helpers_1_1_mobile_party_helper.html#a81787cd69e17b5c4212bcd86a113fa4a)PartyAddSharedXp()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.MobilePartyHelper.PartyAddSharedXp | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | float | *xpToDistribute* ) | | static |

[◆](class_helpers_1_1_mobile_party_helper.html#aea97ead8f7be2034f1be57f8e8969a8a)WoundNumberOfNonHeroTroopsRandomlyWithChanceOfDeath()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.MobilePartyHelper.WoundNumberOfNonHeroTroopsRandomlyWithChanceOfDeath | ( | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *roster*, | |  |  | int | *numberOfMen*, | |  |  | float | *chanceOfDeathPerUnit*, | |  |  | out int | *deathAmount* ) | | static |

[◆](class_helpers_1_1_mobile_party_helper.html#ae9a8399d85712f387dae0ef60f53a2a8)CanTroopGainXp()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool Helpers.MobilePartyHelper.CanTroopGainXp | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *owner*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, | |  |  | out int | *gainableMaxXp* ) | | static |

[◆](class_helpers_1_1_mobile_party_helper.html#a2173c668d7f7de83c1fb78a87d2d6c3f)TryMatchPartySpeedWithItemWeight()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.MobilePartyHelper.TryMatchPartySpeedWithItemWeight | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | float | *targetPartySpeed*, | |  |  | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *itemToUse* = null ) | | static |

[◆](class_helpers_1_1_mobile_party_helper.html#a7a3779436acff67b3551439bf40420ff)GetMainPartySkillCounsellor()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) Helpers.MobilePartyHelper.GetMainPartySkillCounsellor | ( | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill* | ) |  | | static |

[◆](class_helpers_1_1_mobile_party_helper.html#a2b304c6274a5d9644c85839bd71005e4)GetCurrentSettlementOfMobilePartyForAICalculation()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) Helpers.MobilePartyHelper.GetCurrentSettlementOfMobilePartyForAICalculation | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | static |

[◆](class_helpers_1_1_mobile_party_helper.html#a15618563a0063c634b7f68f244b6db45)GetPlayerPrisonersPlayerCanSell()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) Helpers.MobilePartyHelper.GetPlayerPrisonersPlayerCanSell | ( |  | ) |  | | static |

[◆](class_helpers_1_1_mobile_party_helper.html#a9d1151af2e6ad5d2777e7e46b5f36a5e)FillPartyManuallyAfterCreation()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.MobilePartyHelper.FillPartyManuallyAfterCreation | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, | |  |  | [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) | *partyTemplate*, | |  |  | int | *desiredMenCount* ) | | static |

[◆](class_helpers_1_1_mobile_party_helper.html#a80d00b21a6cae6ed6a7575d14fbf8213)CanPartyAttackWithCurrentMorale()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool Helpers.MobilePartyHelper.CanPartyAttackWithCurrentMorale | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | static |

