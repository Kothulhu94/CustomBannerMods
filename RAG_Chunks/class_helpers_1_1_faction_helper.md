--- SOURCE: class_helpers_1_1_faction_helper.html ---

Helpers.FactionHelper Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static float | [FindPotentialStrength](class_helpers_1_1_faction_helper.html#aa947937953deaa43e54f39ae624f7366) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| static IEnumerable< [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) > | [GetEnemyKingdoms](class_helpers_1_1_faction_helper.html#ab47f11b29d9aacae964e8136a0c9a63c) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| static IEnumerable< [StanceLink](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html) > | [GetStances](class_helpers_1_1_faction_helper.html#a4e8f7cde69c3293d2e0f8adb165b264d) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| static float | [GetPowerRatioToEnemies](class_helpers_1_1_faction_helper.html#a7e0c837ea65c0e246e544ff4e9868ea4) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom) |
| static Tuple< bool, string > | [IsClanNameApplicable](class_helpers_1_1_faction_helper.html#a3a22ce6edfd61db98f86dce4d358dd26) (string name) |
| static Tuple< bool, string > | [IsKingdomNameApplicable](class_helpers_1_1_faction_helper.html#a5c811a1b3b7b35e83ccf0f3a389339f2) (string name) |
| static float | [GetPowerRatioToTributePayedKingdoms](class_helpers_1_1_faction_helper.html#a44936621bf167ea9d307c3d4ccb3ad9a) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom) |
| static bool | [CanClanBeGrantedFief](class_helpers_1_1_faction_helper.html#aa82aead2d8a5feac293838301fdeaa1d) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| static bool | [CanPlayerEnterFaction](class_helpers_1_1_faction_helper.html#a2e69e4a0e2af02b0f2bc8db75e3d29aa) (bool asVassal=false) |
| static float | [GetTotalEnemyKingdomPower](class_helpers_1_1_faction_helper.html#adba50877dd3f5e7367488c634be56004) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom) |
| static float | [GetTotalTributePayedKingdomsPower](class_helpers_1_1_faction_helper.html#a161369450b83cdf1486cd344b00a9501) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom) |
| static IEnumerable< [Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) > | [GetKingdomArmies](class_helpers_1_1_faction_helper.html#a021a2c9c877e5dfff73ac87489d6f1d5) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) mapFaction) |
| static float | [SettlementProsperityEffectOnGarrisonSizeConstant](class_helpers_1_1_faction_helper.html#ae534f8eda8c7fbca7edf503055732d93) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| static float | [SettlementFoodPotentialEffectOnGarrisonSizeConstant](class_helpers_1_1_faction_helper.html#a234222b7176dc66db1c1848867ee1abc) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| static float | [OwnerClanEconomyEffectOnGarrisonSizeConstant](class_helpers_1_1_faction_helper.html#a6f7e6d33ab4b2b5987465c1c429e6088) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| static float | [FindIdealGarrisonStrengthPerWalledCenter](class_helpers_1_1_faction_helper.html#ac0ecffaf24fbd5fc9b76cf2dbe8d9ffb) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan=null) |
| static void | [FinishAllRelatedHostileActionsOfNobleToFaction](class_helpers_1_1_faction_helper.html#a310e93550e00295e88e9e2a460dc3411) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) noble, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| static void | [FinishAllRelatedHostileActionsOfFactionToFaction](class_helpers_1_1_faction_helper.html#adddc65707fe4f175f8f0709db4716f32) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction1, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction2) |
| static void | [FinishAllRelatedHostileActions](class_helpers_1_1_faction_helper.html#addbb246ca60dd5404c059037edd56155) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan1, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan2) |
| static void | [FinishAllRelatedHostileActions](class_helpers_1_1_faction_helper.html#a7a437dce63e3b1f4ffb767f4571950af) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom1, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom2) |
| static void | [AdjustFactionStancesForClanJoiningKingdom](class_helpers_1_1_faction_helper.html#a288cfc294fc35f06e9307554477e9e13) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) joiningClan, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdomToJoin) |
| static [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetTermUsedByOtherFaction](class_helpers_1_1_faction_helper.html#aa0d6673131b50270b8174b67e2489fe1) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) otherFaction, bool pejorative) |
| static [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetFormalNameForFactionCulture](class_helpers_1_1_faction_helper.html#a71ab14b0a8e318eae63a407be76576ac) ([CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) factionCulture) |
| static [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetInformalNameForFactionCulture](class_helpers_1_1_faction_helper.html#a97164d422a04c63b2bcee771bc8ee2ab) ([CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) factionCulture) |
| static [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetAdjectiveForFactionCulture](class_helpers_1_1_faction_helper.html#af3404a6d790dca3bd08974c98bb60d74) ([CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) factionCulture) |
| static [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetAdjectiveForFaction](class_helpers_1_1_faction_helper.html#ac1a0455762d1addcedd4bdaff2eec571) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| static [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GenerateClanNameforPlayer](class_helpers_1_1_faction_helper.html#ae778356f90f296a66de1051aa340be04) () |
| static float | [GetDistanceToClosestNonAllyFortificationOfFaction](class_helpers_1_1_faction_helper.html#a0474c55df1eb683e2102f8e5779c24b8) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| static [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [GetMidSettlementOfFaction](class_helpers_1_1_faction_helper.html#a80072f4bc0bf8ef353866ff3a776c52b) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| static List< [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) > | [GetPossibleKingdomsToDeclareWar](class_helpers_1_1_faction_helper.html#a5c27ca0d858cbfd3e85f9fa5e6251ab3) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom) |
| static List< [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) > | [GetPossibleKingdomsToDeclarePeace](class_helpers_1_1_faction_helper.html#a06589ebb3f23dd025f6136a08b258462) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom) |
| static IEnumerable< [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) > | [GetAllyMinorFactions](class_helpers_1_1_faction_helper.html#a222e76be856d2b240f439e3afbe5b173) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) otherCharacter) |
| static [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | [ChooseHeirClanForFiefs](class_helpers_1_1_faction_helper.html#a22a657c75ec1b4106ed54ff871237100) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) oldClan) |
| static bool | [CanPlayerOfferMercenaryService](class_helpers_1_1_faction_helper.html#a9fa8c3cbb6b96cb756a1a1bc3a0c8d22) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) offerKingdom, out List< [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) > playerWars, out List< [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) > warsOfFactionToJoin) |
| static bool | [CanPlayerOfferVassalage](class_helpers_1_1_faction_helper.html#acacfb21e1af8183c75b8a0cf7c852623) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) offerKingdom, out List< [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) > playerWars, out List< [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) > warsOfFactionToJoin) |
| static bool | [IsMainClanMemberAvailableForRecall](class_helpers_1_1_faction_helper.html#aebc2da7acdbe88067e8827b3195ff112) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) targetParty, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) explanation) |
| static bool | [IsMainClanMemberAvailableForPartyLeaderChange](class_helpers_1_1_faction_helper.html#acf574790e14755bc1f3790c5d5d02a5d) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, bool isSend, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) targetParty, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) explanation) |
| static bool | [IsMainClanMemberAvailableForSendingSettlement](class_helpers_1_1_faction_helper.html#a7de7b40f7df22f58d3bbea59a8e34966) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) targetSettlement, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) explanation) |
| static bool | [IsMainClanMemberAvailableForSendingSettlementAsGovernor](class_helpers_1_1_faction_helper.html#a45704ab718b62aa2ffc86ad8d8fe4f7c) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlementOfGovernor, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) explanation) |

Member Function Documentation
-----------------------------

[◆](class_helpers_1_1_faction_helper.html#aa947937953deaa43e54f39ae624f7366)FindPotentialStrength()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float Helpers.FactionHelper.FindPotentialStrength | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction* | ) |  | | static |

[◆](class_helpers_1_1_faction_helper.html#ab47f11b29d9aacae964e8136a0c9a63c)GetEnemyKingdoms()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IEnumerable< [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) > Helpers.FactionHelper.GetEnemyKingdoms | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction* | ) |  | | static |

[◆](class_helpers_1_1_faction_helper.html#a4e8f7cde69c3293d2e0f8adb165b264d)GetStances()
----------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IEnumerable< [StanceLink](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html) > Helpers.FactionHelper.GetStances | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction* | ) |  | | static |

[◆](class_helpers_1_1_faction_helper.html#a7e0c837ea65c0e246e544ff4e9868ea4)GetPowerRatioToEnemies()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float Helpers.FactionHelper.GetPowerRatioToEnemies | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom* | ) |  | | static |

[◆](class_helpers_1_1_faction_helper.html#a3a22ce6edfd61db98f86dce4d358dd26)IsClanNameApplicable()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | Tuple< bool, string > Helpers.FactionHelper.IsClanNameApplicable | ( | string | *name* | ) |  | | static |

[◆](class_helpers_1_1_faction_helper.html#a5c811a1b3b7b35e83ccf0f3a389339f2)IsKingdomNameApplicable()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | Tuple< bool, string > Helpers.FactionHelper.IsKingdomNameApplicable | ( | string | *name* | ) |  | | static |

[◆](class_helpers_1_1_faction_helper.html#a44936621bf167ea9d307c3d4ccb3ad9a)GetPowerRatioToTributePayedKingdoms()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float Helpers.FactionHelper.GetPowerRatioToTributePayedKingdoms | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom* | ) |  | | static |

[◆](class_helpers_1_1_faction_helper.html#aa82aead2d8a5feac293838301fdeaa1d)CanClanBeGrantedFief()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool Helpers.FactionHelper.CanClanBeGrantedFief | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* | ) |  | | static |

[◆](class_helpers_1_1_faction_helper.html#a2e69e4a0e2af02b0f2bc8db75e3d29aa)CanPlayerEnterFaction()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool Helpers.FactionHelper.CanPlayerEnterFaction | ( | bool | *asVassal* = false | ) |  | | static |

[◆](class_helpers_1_1_faction_helper.html#adba50877dd3f5e7367488c634be56004)GetTotalEnemyKingdomPower()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float Helpers.FactionHelper.GetTotalEnemyKingdomPower | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom* | ) |  | | static |

[◆](class_helpers_1_1_faction_helper.html#a161369450b83cdf1486cd344b00a9501)GetTotalTributePayedKingdomsPower()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float Helpers.FactionHelper.GetTotalTributePayedKingdomsPower | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom* | ) |  | | static |

[◆](class_helpers_1_1_faction_helper.html#a021a2c9c877e5dfff73ac87489d6f1d5)GetKingdomArmies()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IEnumerable< [Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) > Helpers.FactionHelper.GetKingdomArmies | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *mapFaction* | ) |  | | static |

[◆](class_helpers_1_1_faction_helper.html#ae534f8eda8c7fbca7edf503055732d93)SettlementProsperityEffectOnGarrisonSizeConstant()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float Helpers.FactionHelper.SettlementProsperityEffectOnGarrisonSizeConstant | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* | ) |  | | static |

[◆](class_helpers_1_1_faction_helper.html#a234222b7176dc66db1c1848867ee1abc)SettlementFoodPotentialEffectOnGarrisonSizeConstant()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float Helpers.FactionHelper.SettlementFoodPotentialEffectOnGarrisonSizeConstant | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  | | static |

[◆](class_helpers_1_1_faction_helper.html#a6f7e6d33ab4b2b5987465c1c429e6088)OwnerClanEconomyEffectOnGarrisonSizeConstant()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float Helpers.FactionHelper.OwnerClanEconomyEffectOnGarrisonSizeConstant | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* | ) |  | | static |

[◆](class_helpers_1_1_faction_helper.html#ac0ecffaf24fbd5fc9b76cf2dbe8d9ffb)FindIdealGarrisonStrengthPerWalledCenter()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float Helpers.FactionHelper.FindIdealGarrisonStrengthPerWalledCenter | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom*, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* = null ) | | static |

[◆](class_helpers_1_1_faction_helper.html#a310e93550e00295e88e9e2a460dc3411)FinishAllRelatedHostileActionsOfNobleToFaction()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.FactionHelper.FinishAllRelatedHostileActionsOfNobleToFaction | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *noble*, | |  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction* ) | | static |

[◆](class_helpers_1_1_faction_helper.html#adddc65707fe4f175f8f0709db4716f32)FinishAllRelatedHostileActionsOfFactionToFaction()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.FactionHelper.FinishAllRelatedHostileActionsOfFactionToFaction | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction1*, | |  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction2* ) | | static |

[◆](class_helpers_1_1_faction_helper.html#addbb246ca60dd5404c059037edd56155)FinishAllRelatedHostileActions() [1/2]
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.FactionHelper.FinishAllRelatedHostileActions | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan1*, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan2* ) | | static |

[◆](class_helpers_1_1_faction_helper.html#a7a437dce63e3b1f4ffb767f4571950af)FinishAllRelatedHostileActions() [2/2]
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.FactionHelper.FinishAllRelatedHostileActions | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom1*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom2* ) | | static |

[◆](class_helpers_1_1_faction_helper.html#a288cfc294fc35f06e9307554477e9e13)AdjustFactionStancesForClanJoiningKingdom()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.FactionHelper.AdjustFactionStancesForClanJoiningKingdom | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *joiningClan*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdomToJoin* ) | | static |

[◆](class_helpers_1_1_faction_helper.html#aa0d6673131b50270b8174b67e2489fe1)GetTermUsedByOtherFaction()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) Helpers.FactionHelper.GetTermUsedByOtherFaction | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction*, | |  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *otherFaction*, | |  |  | bool | *pejorative* ) | | static |

[◆](class_helpers_1_1_faction_helper.html#a71ab14b0a8e318eae63a407be76576ac)GetFormalNameForFactionCulture()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) Helpers.FactionHelper.GetFormalNameForFactionCulture | ( | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | *factionCulture* | ) |  | | static |

[◆](class_helpers_1_1_faction_helper.html#a97164d422a04c63b2bcee771bc8ee2ab)GetInformalNameForFactionCulture()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) Helpers.FactionHelper.GetInformalNameForFactionCulture | ( | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | *factionCulture* | ) |  | | static |

[◆](class_helpers_1_1_faction_helper.html#af3404a6d790dca3bd08974c98bb60d74)GetAdjectiveForFactionCulture()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) Helpers.FactionHelper.GetAdjectiveForFactionCulture | ( | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | *factionCulture* | ) |  | | static |

[◆](class_helpers_1_1_faction_helper.html#ac1a0455762d1addcedd4bdaff2eec571)GetAdjectiveForFaction()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) Helpers.FactionHelper.GetAdjectiveForFaction | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction* | ) |  | | static |

[◆](class_helpers_1_1_faction_helper.html#ae778356f90f296a66de1051aa340be04)GenerateClanNameforPlayer()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) Helpers.FactionHelper.GenerateClanNameforPlayer | ( |  | ) |  | | static |

[◆](class_helpers_1_1_faction_helper.html#a0474c55df1eb683e2102f8e5779c24b8)GetDistanceToClosestNonAllyFortificationOfFaction()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float Helpers.FactionHelper.GetDistanceToClosestNonAllyFortificationOfFaction | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction* | ) |  | | static |

[◆](class_helpers_1_1_faction_helper.html#a80072f4bc0bf8ef353866ff3a776c52b)GetMidSettlementOfFaction()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) Helpers.FactionHelper.GetMidSettlementOfFaction | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction* | ) |  | | static |

[◆](class_helpers_1_1_faction_helper.html#a5c27ca0d858cbfd3e85f9fa5e6251ab3)GetPossibleKingdomsToDeclareWar()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | List< [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) > Helpers.FactionHelper.GetPossibleKingdomsToDeclareWar | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom* | ) |  | | static |

[◆](class_helpers_1_1_faction_helper.html#a06589ebb3f23dd025f6136a08b258462)GetPossibleKingdomsToDeclarePeace()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | List< [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) > Helpers.FactionHelper.GetPossibleKingdomsToDeclarePeace | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom* | ) |  | | static |

[◆](class_helpers_1_1_faction_helper.html#a222e76be856d2b240f439e3afbe5b173)GetAllyMinorFactions()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IEnumerable< [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) > Helpers.FactionHelper.GetAllyMinorFactions | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *otherCharacter* | ) |  | | static |

[◆](class_helpers_1_1_faction_helper.html#a22a657c75ec1b4106ed54ff871237100)ChooseHeirClanForFiefs()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) Helpers.FactionHelper.ChooseHeirClanForFiefs | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *oldClan* | ) |  | | static |

[◆](class_helpers_1_1_faction_helper.html#a9fa8c3cbb6b96cb756a1a1bc3a0c8d22)CanPlayerOfferMercenaryService()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool Helpers.FactionHelper.CanPlayerOfferMercenaryService | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *offerKingdom*, | |  |  | out List< [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) > | *playerWars*, | |  |  | out List< [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) > | *warsOfFactionToJoin* ) | | static |

[◆](class_helpers_1_1_faction_helper.html#acacfb21e1af8183c75b8a0cf7c852623)CanPlayerOfferVassalage()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool Helpers.FactionHelper.CanPlayerOfferVassalage | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *offerKingdom*, | |  |  | out List< [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) > | *playerWars*, | |  |  | out List< [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) > | *warsOfFactionToJoin* ) | | static |

[◆](class_helpers_1_1_faction_helper.html#aebc2da7acdbe88067e8827b3195ff112)IsMainClanMemberAvailableForRecall()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool Helpers.FactionHelper.IsMainClanMemberAvailableForRecall | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *targetParty*, | |  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *explanation* ) | | static |

[◆](class_helpers_1_1_faction_helper.html#acf574790e14755bc1f3790c5d5d02a5d)IsMainClanMemberAvailableForPartyLeaderChange()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool Helpers.FactionHelper.IsMainClanMemberAvailableForPartyLeaderChange | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | bool | *isSend*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *targetParty*, | |  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *explanation* ) | | static |

[◆](class_helpers_1_1_faction_helper.html#a7de7b40f7df22f58d3bbea59a8e34966)IsMainClanMemberAvailableForSendingSettlement()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool Helpers.FactionHelper.IsMainClanMemberAvailableForSendingSettlement | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *targetSettlement*, | |  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *explanation* ) | | static |

[◆](class_helpers_1_1_faction_helper.html#a45704ab718b62aa2ffc86ad8d8fe4f7c)IsMainClanMemberAvailableForSendingSettlementAsGovernor()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool Helpers.FactionHelper.IsMainClanMemberAvailableForSendingSettlementAsGovernor | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlementOfGovernor*, | |  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *explanation* ) | | static |

