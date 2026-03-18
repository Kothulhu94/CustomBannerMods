--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html ---

TaleWorlds.CampaignSystem.Incidents.IncidentEffect Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
| bool | [Condition](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#acf5e0c686b839a6e9df506a34a86e55c) () |
| List< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > | [Consequence](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a50ef031b34e4bbc9553ce2bb57ced100) () |
| List< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > | [GetHint](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a04b4decff6fec2ef9e2cf979f4b9c1fc) () |
| IncidentEffect | [WithChance](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#abcc602963d26679220216c9bf100f708) (float chance) |
| IncidentEffect | [WithCustomInformation](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a74650c36af508c04a69b63faf254e2c0) (Func< List< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > > customInformation) |
| IncidentEffect | [WithHint](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a1e2c6e42f3c8979556bbea3069747400) (Func< IncidentEffect, List< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > > hint) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static IncidentEffect | [GoldChange](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#adeebc137df1972bcb0cab925b9e8e2cf) (Func< int > amountGetter) |
| static IncidentEffect | [TraitChange](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#aa9a586ea30845f109f5b2bb7843b15c3) ([TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html) trait, int amount) |
| static IncidentEffect | [BuildingLevelChange](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#aeb8eab60ff83809bad8f19122c4c99e0) (Func< [Building](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html) > buildingGetter, Func< int > amountGetter) |
| static IncidentEffect | [SiegeProgressChange](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a6df0f7202cd41f566594199f4fbff6a9) (Func< float > amountGetter) |
| static IncidentEffect | [WorkshopProfitabilityChange](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#ae02ef84e725d47bc451d9f261ec9f5a6) (Func< [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) > workshopGetter, float percentage) |
| static IncidentEffect | [SkillChange](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a5e9d3acad6f7d55d1c9e837cd4f8ad14) ([SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill, float amount) |
| static IncidentEffect | [MoraleChange](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a0693481d91276287bc66e6d6ef8759d5) (float amount) |
| static IncidentEffect | [HealthChance](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a59cb6f1cbb327b0cf671cc693a47801d) (int amount) |
| static IncidentEffect | [RenownChange](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#aca92166898e7d68a02c0d1dbea93da4c) (float amount) |
| static IncidentEffect | [CrimeRatingChange](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a4107a0df575af0757fd12ed93cf7ec68) (Func< [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) > factionGetter, float amount) |
| static IncidentEffect | [InfluenceChange](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a1c1c3734bdea16b8975feae37d543ee6) (float amount) |
| static IncidentEffect | [SettlementRelationChange](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a75ecf642a320f2d9e4b018b40f482d03) (Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) > settlementGetter, int amount) |
| static IncidentEffect | [TownBoundVillageRelationChange](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#abd37b1c61fd6a7935cf580a52377e60e) (Func< [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) > townGetter, int amount) |
| static IncidentEffect | [TownBoundVillageHearthChange](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a90e05836576a096762aa439faf9c00a5) (Func< [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) > townGetter, int amount) |
| static IncidentEffect | [VillageHearthChange](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a5b7239abeb8629c52e372c914284e3b5) (Func< [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) > villageGetter, int amount) |
| static IncidentEffect | [TownSecurityChange](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#ad0e9cf958b05212e2ef9983a4df1d262) (Func< [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) > townGetter, int amount) |
| static IncidentEffect | [HeroRelationChange](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#ac1252ef8114cba300a6b7c4b8f05a082) (Func< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > heroGetter, int amount) |
| static IncidentEffect | [TownProsperityChange](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a5b02b29462e9329de8b4d26d6532ce96) (Func< [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) > townGetter, int amount) |
| static IncidentEffect | [SettlementMilitiaChange](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a5ff0ccf3e48366d2525643703ef365d2) (Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) > settlementGetter, int amount) |
| static IncidentEffect | [InfestNearbyHideout](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a722a4496ab29389e638f5257194d0811) (Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) > settlementGetter) |
| static IncidentEffect | [WoundTroopsRandomly](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#ac9a56c7d283e0dac1e3a6e8195f983e1) (float percentage) |
| static IncidentEffect | [WoundTroopsRandomly](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a563482e1405ad9982ce0ec4c3dde5c5c) (Func< [TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html), bool > predicate, Func< int > amountGetter, bool specifyUnitTypeOnHint=true) |
| static IncidentEffect | [WoundTroopsRandomlyWithChanceOfDeath](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#aa00e770007735f02565ca39caaabd5fe) (float percentage, float chanceOfDeathPerUnit) |
| static IncidentEffect | [BreachSiegeWall](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#ac7fdbe2d29c14dbadaa2f120896b71df) (int amount) |
| static IncidentEffect | [WoundTroopsRandomly](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a653b67cce6866f084302c0a319e4fef0) (int amount) |
| static IncidentEffect | [WoundTroopsRandomlyWithChanceOfDeath](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a52acc8823ffb08f323084cbd9d9b7db0) (int amount, float chanceOfDeathPerUnit) |
| static IncidentEffect | [WoundTroop](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a4b17478dfdd0178b2cf8c44cd642f71f) (Func< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > characterGetter, int amount) |
| static IncidentEffect | [WoundTroopsRandomlyByChance](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#ad053f31131bc0f3a110f727a96d3ac8b) (float chancePerUnit) |
| static IncidentEffect | [KillTroopsRandomlyOrderedByTier](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#aab77af6807c7067c227f46e23a8a0829) (Func< [TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html), bool > predicate, Func< int > amountGetter) |
| static IncidentEffect | [KillTroopsRandomly](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#ac9e873e0a5a07bdcab10f7877ee802ea) (Func< [TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html), bool > predicate, Func< int > amountGetter) |
| static IncidentEffect | [KillTroopsRandomlyByChance](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#ae3b38cde855974fc0d6d3bc50108e7ea) (float chancePerUnit) |
| static IncidentEffect | [KillTroop](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a94e6580ad5182ef03d06eaa0a0d997f1) (Func< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > characterGetter, int amount) |
| static IncidentEffect | [ChangeTroopAmount](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a6d86761bd0433ba936a364bece4af140) (Func< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > characterGetter, int amount) |
| static IncidentEffect | [UpgradeTroop](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a1471bd1dedd162492297157f990c4e21) (Func< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > characterGetter, Func< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), bool > upgradePredicate, int amount, Func< long > incidentSeedGetter) |
| static IncidentEffect | [UpgradeTroop](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a2aeae55aee6c3ad4e3186d2c0029d3bd) (Func< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > characterGetter, Func< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > upgradedCharacterGetter, int amount, Func< long > incidentSeedGetter) |
| static IncidentEffect | [RemovePrisonersRandomlyWithPredicate](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#ae04aff3890c59953d80582e23aae0d82) (Func< [TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html), bool > predicate, int amount) |
| static IncidentEffect | [ChangeItemsAmount](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a501aa57a35f7fcf71909fe1924baa3c5) (Func< List< [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) > > itemsGetter, int amount) |
| static IncidentEffect | [ChangeItemAmount](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#aa86ffa40598377c6357db05479142374) (Func< [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) > itemGetter, Func< int > amountGetter) |
| static IncidentEffect | [PartyExperienceChance](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#acc196c987f156872c377c23d82f14ac1) (int amount) |
| static IncidentEffect | [DisorganizeParty](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a6733196ed558c2fd0f7cc21c8d9a9d44) () |
| static IncidentEffect | [HealTroopsRandomly](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a7d85211cb3f303a01171724feb4bd776) (int amount) |
| static IncidentEffect | [DemoteTroopsRandomlyWithPredicate](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#ab73368c0526ba91d682608218e3cc3a0) (Func< [TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html), bool > predicate, Func< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), bool > demotionPredicate, int amount, bool specifyUnitTypeOnHint=true) |
| static IncidentEffect | [Group](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#aac0f1265f0a5ccc8ff1fb6c9524c0aec) (params IncidentEffect[] effects) |
| static IncidentEffect | [Select](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a67df009ae1f71a8d8460de4d5b724f01) (IncidentEffect effectOne, IncidentEffect effectTwo, float chanceOfFirstOne) |
| static IncidentEffect | [Custom](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a39fb849dc015c6c895db2a926f997989) (Func< bool > condition, Func< List< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > > consequence, Func< IncidentEffect, List< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > > hint) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#acf5e0c686b839a6e9df506a34a86e55c)Condition()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Incidents.IncidentEffect.Condition | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a50ef031b34e4bbc9553ce2bb57ced100)Consequence()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| List< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > TaleWorlds.CampaignSystem.Incidents.IncidentEffect.Consequence | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a04b4decff6fec2ef9e2cf979f4b9c1fc)GetHint()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| List< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > TaleWorlds.CampaignSystem.Incidents.IncidentEffect.GetHint | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#abcc602963d26679220216c9bf100f708)WithChance()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.WithChance | ( | float | *chance* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a74650c36af508c04a69b63faf254e2c0)WithCustomInformation()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.WithCustomInformation | ( | Func< List< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > > | *customInformation* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a1e2c6e42f3c8979556bbea3069747400)WithHint()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.WithHint | ( | Func< IncidentEffect, List< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > > | *hint* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#adeebc137df1972bcb0cab925b9e8e2cf)GoldChange()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.GoldChange | ( | Func< int > | *amountGetter* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#aa9a586ea30845f109f5b2bb7843b15c3)TraitChange()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.TraitChange | ( | [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html) | *trait*, | |  |  | int | *amount* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#aeb8eab60ff83809bad8f19122c4c99e0)BuildingLevelChange()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.BuildingLevelChange | ( | Func< [Building](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html) > | *buildingGetter*, | |  |  | Func< int > | *amountGetter* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a6df0f7202cd41f566594199f4fbff6a9)SiegeProgressChange()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.SiegeProgressChange | ( | Func< float > | *amountGetter* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#ae02ef84e725d47bc451d9f261ec9f5a6)WorkshopProfitabilityChange()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.WorkshopProfitabilityChange | ( | Func< [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) > | *workshopGetter*, | |  |  | float | *percentage* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a5e9d3acad6f7d55d1c9e837cd4f8ad14)SkillChange()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.SkillChange | ( | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill*, | |  |  | float | *amount* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a0693481d91276287bc66e6d6ef8759d5)MoraleChange()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.MoraleChange | ( | float | *amount* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a59cb6f1cbb327b0cf671cc693a47801d)HealthChance()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.HealthChance | ( | int | *amount* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#aca92166898e7d68a02c0d1dbea93da4c)RenownChange()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.RenownChange | ( | float | *amount* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a4107a0df575af0757fd12ed93cf7ec68)CrimeRatingChange()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.CrimeRatingChange | ( | Func< [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) > | *factionGetter*, | |  |  | float | *amount* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a1c1c3734bdea16b8975feae37d543ee6)InfluenceChange()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.InfluenceChange | ( | float | *amount* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a75ecf642a320f2d9e4b018b40f482d03)SettlementRelationChange()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.SettlementRelationChange | ( | Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) > | *settlementGetter*, | |  |  | int | *amount* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#abd37b1c61fd6a7935cf580a52377e60e)TownBoundVillageRelationChange()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.TownBoundVillageRelationChange | ( | Func< [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) > | *townGetter*, | |  |  | int | *amount* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a90e05836576a096762aa439faf9c00a5)TownBoundVillageHearthChange()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.TownBoundVillageHearthChange | ( | Func< [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) > | *townGetter*, | |  |  | int | *amount* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a5b7239abeb8629c52e372c914284e3b5)VillageHearthChange()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.VillageHearthChange | ( | Func< [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) > | *villageGetter*, | |  |  | int | *amount* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#ad0e9cf958b05212e2ef9983a4df1d262)TownSecurityChange()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.TownSecurityChange | ( | Func< [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) > | *townGetter*, | |  |  | int | *amount* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#ac1252ef8114cba300a6b7c4b8f05a082)HeroRelationChange()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.HeroRelationChange | ( | Func< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | *heroGetter*, | |  |  | int | *amount* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a5b02b29462e9329de8b4d26d6532ce96)TownProsperityChange()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.TownProsperityChange | ( | Func< [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) > | *townGetter*, | |  |  | int | *amount* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a5ff0ccf3e48366d2525643703ef365d2)SettlementMilitiaChange()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.SettlementMilitiaChange | ( | Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) > | *settlementGetter*, | |  |  | int | *amount* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a722a4496ab29389e638f5257194d0811)InfestNearbyHideout()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.InfestNearbyHideout | ( | Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) > | *settlementGetter* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#ac9a56c7d283e0dac1e3a6e8195f983e1)WoundTroopsRandomly() [1/3]
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.WoundTroopsRandomly | ( | float | *percentage* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a563482e1405ad9982ce0ec4c3dde5c5c)WoundTroopsRandomly() [2/3]
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.WoundTroopsRandomly | ( | Func< [TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html), bool > | *predicate*, | |  |  | Func< int > | *amountGetter*, | |  |  | bool | *specifyUnitTypeOnHint* = true ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#aa00e770007735f02565ca39caaabd5fe)WoundTroopsRandomlyWithChanceOfDeath() [1/2]
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.WoundTroopsRandomlyWithChanceOfDeath | ( | float | *percentage*, | |  |  | float | *chanceOfDeathPerUnit* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#ac7fdbe2d29c14dbadaa2f120896b71df)BreachSiegeWall()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.BreachSiegeWall | ( | int | *amount* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a653b67cce6866f084302c0a319e4fef0)WoundTroopsRandomly() [3/3]
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.WoundTroopsRandomly | ( | int | *amount* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a52acc8823ffb08f323084cbd9d9b7db0)WoundTroopsRandomlyWithChanceOfDeath() [2/2]
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.WoundTroopsRandomlyWithChanceOfDeath | ( | int | *amount*, | |  |  | float | *chanceOfDeathPerUnit* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a4b17478dfdd0178b2cf8c44cd642f71f)WoundTroop()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.WoundTroop | ( | Func< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > | *characterGetter*, | |  |  | int | *amount* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#ad053f31131bc0f3a110f727a96d3ac8b)WoundTroopsRandomlyByChance()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.WoundTroopsRandomlyByChance | ( | float | *chancePerUnit* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#aab77af6807c7067c227f46e23a8a0829)KillTroopsRandomlyOrderedByTier()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.KillTroopsRandomlyOrderedByTier | ( | Func< [TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html), bool > | *predicate*, | |  |  | Func< int > | *amountGetter* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#ac9e873e0a5a07bdcab10f7877ee802ea)KillTroopsRandomly()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.KillTroopsRandomly | ( | Func< [TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html), bool > | *predicate*, | |  |  | Func< int > | *amountGetter* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#ae3b38cde855974fc0d6d3bc50108e7ea)KillTroopsRandomlyByChance()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.KillTroopsRandomlyByChance | ( | float | *chancePerUnit* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a94e6580ad5182ef03d06eaa0a0d997f1)KillTroop()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.KillTroop | ( | Func< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > | *characterGetter*, | |  |  | int | *amount* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a6d86761bd0433ba936a364bece4af140)ChangeTroopAmount()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.ChangeTroopAmount | ( | Func< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > | *characterGetter*, | |  |  | int | *amount* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a1471bd1dedd162492297157f990c4e21)UpgradeTroop() [1/2]
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.UpgradeTroop | ( | Func< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > | *characterGetter*, | |  |  | Func< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), bool > | *upgradePredicate*, | |  |  | int | *amount*, | |  |  | Func< long > | *incidentSeedGetter* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a2aeae55aee6c3ad4e3186d2c0029d3bd)UpgradeTroop() [2/2]
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.UpgradeTroop | ( | Func< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > | *characterGetter*, | |  |  | Func< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > | *upgradedCharacterGetter*, | |  |  | int | *amount*, | |  |  | Func< long > | *incidentSeedGetter* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#ae04aff3890c59953d80582e23aae0d82)RemovePrisonersRandomlyWithPredicate()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.RemovePrisonersRandomlyWithPredicate | ( | Func< [TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html), bool > | *predicate*, | |  |  | int | *amount* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a501aa57a35f7fcf71909fe1924baa3c5)ChangeItemsAmount()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.ChangeItemsAmount | ( | Func< List< [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) > > | *itemsGetter*, | |  |  | int | *amount* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#aa86ffa40598377c6357db05479142374)ChangeItemAmount()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.ChangeItemAmount | ( | Func< [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) > | *itemGetter*, | |  |  | Func< int > | *amountGetter* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#acc196c987f156872c377c23d82f14ac1)PartyExperienceChance()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.PartyExperienceChance | ( | int | *amount* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a6733196ed558c2fd0f7cc21c8d9a9d44)DisorganizeParty()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.DisorganizeParty | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a7d85211cb3f303a01171724feb4bd776)HealTroopsRandomly()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.HealTroopsRandomly | ( | int | *amount* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#ab73368c0526ba91d682608218e3cc3a0)DemoteTroopsRandomlyWithPredicate()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.DemoteTroopsRandomlyWithPredicate | ( | Func< [TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html), bool > | *predicate*, | |  |  | Func< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), bool > | *demotionPredicate*, | |  |  | int | *amount*, | |  |  | bool | *specifyUnitTypeOnHint* = true ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#aac0f1265f0a5ccc8ff1fb6c9524c0aec)Group()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.Group | ( | params IncidentEffect[] | *effects* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a67df009ae1f71a8d8460de4d5b724f01)Select()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.Select | ( | IncidentEffect | *effectOne*, | |  |  | IncidentEffect | *effectTwo*, | |  |  | float | *chanceOfFirstOne* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html#a39fb849dc015c6c895db2a926f997989)Custom()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IncidentEffect TaleWorlds.CampaignSystem.Incidents.IncidentEffect.Custom | ( | Func< bool > | *condition*, | |  |  | Func< List< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > > | *consequence*, | |  |  | Func< IncidentEffect, List< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > > | *hint* ) | | static |

