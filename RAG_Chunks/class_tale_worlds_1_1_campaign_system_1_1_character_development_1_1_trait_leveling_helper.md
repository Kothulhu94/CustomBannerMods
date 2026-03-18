--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_leveling_helper.html ---

TaleWorlds.CampaignSystem.CharacterDevelopment.TraitLevelingHelper Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [UpdateTraitXPAccordingToTraitLevels](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_leveling_helper.html#a150f5ad83c5497993ab93c8cec145050) () |
| static void | [OnBattleWon](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_leveling_helper.html#a1e00ec9ec3ff2aa7bd79f9cc70cdc637) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) mapEvent, float contribution) |
| static void | [OnTroopsSacrificed](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_leveling_helper.html#a05aba825b8184b692d30c8fbe85cd70b) () |
| static void | [OnLordExecuted](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_leveling_helper.html#a8d6def8b7755bc3c1281e21fb3e2f40c) () |
| static void | [OnVillageRaided](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_leveling_helper.html#a4bef623b90ab0b0396a68133afc1f395) () |
| static void | [OnHostileAction](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_leveling_helper.html#ab34c1f59b505df97e0fd61992da76c2a) (int amount) |
| static void | [OnPartyTreatedWell](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_leveling_helper.html#a93586585f26edef6fe14eb5bd9c43828) () |
| static void | [OnPartyStarved](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_leveling_helper.html#a338fd2d56d05424fe8be9bd62139641d) () |
| static void | [OnIssueFailed](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_leveling_helper.html#a3d6fc87f3297c7ff4559d64b43085de5) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) targetHero, Tuple< [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html), int >[] effectedTraits) |
| static void | [OnIssueSolvedThroughQuest](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_leveling_helper.html#acdba2ff858a2bfca1694484244ac1399) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) targetHero, Tuple< [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html), int >[] effectedTraits) |
| static void | [OnIssueSolvedThroughQuest](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_leveling_helper.html#a1f673f5b61544cc28ff58de4b499042b) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) targetHero, [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html) trait, int xp) |
| static void | [OnIssueSolvedThroughAlternativeSolution](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_leveling_helper.html#ae618940725909f029553c87c578fd450) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) targetHero, Tuple< [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html), int >[] effectedTraits) |
| static void | [OnIssueSolvedThroughBetrayal](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_leveling_helper.html#adaf33610f5e9186618af83f08b57df8e) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) targetHero, Tuple< [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html), int >[] effectedTraits) |
| static void | [OnLordFreed](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_leveling_helper.html#ade3987a86436483526633fc76c979105) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) targetHero) |
| static void | [OnPersuasionDefection](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_leveling_helper.html#a1edb4ec0c2ffc628d803c2def80cc3a2) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) targetHero) |
| static void | [OnSiegeAftermathApplied](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_leveling_helper.html#ac874faef285c3a547b3552dfee0697b2) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [Actions.SiegeAftermathAction.SiegeAftermath](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_siege_aftermath_action.html#a3bd284e7ec4fee476a7dbe532785b1ec) aftermathType, [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html)[] effectedTraits) |
| static void | [OnIncidentResolved](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_leveling_helper.html#ac74a5a689f1d0fb2ab61df58250e1c62) ([TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html) trait, int xpValue) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_leveling_helper.html#a150f5ad83c5497993ab93c8cec145050)UpdateTraitXPAccordingToTraitLevels()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.TraitLevelingHelper.UpdateTraitXPAccordingToTraitLevels | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_leveling_helper.html#a1e00ec9ec3ff2aa7bd79f9cc70cdc637)OnBattleWon()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.TraitLevelingHelper.OnBattleWon | ( | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *mapEvent*, | |  |  | float | *contribution* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_leveling_helper.html#a05aba825b8184b692d30c8fbe85cd70b)OnTroopsSacrificed()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.TraitLevelingHelper.OnTroopsSacrificed | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_leveling_helper.html#a8d6def8b7755bc3c1281e21fb3e2f40c)OnLordExecuted()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.TraitLevelingHelper.OnLordExecuted | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_leveling_helper.html#a4bef623b90ab0b0396a68133afc1f395)OnVillageRaided()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.TraitLevelingHelper.OnVillageRaided | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_leveling_helper.html#ab34c1f59b505df97e0fd61992da76c2a)OnHostileAction()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.TraitLevelingHelper.OnHostileAction | ( | int | *amount* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_leveling_helper.html#a93586585f26edef6fe14eb5bd9c43828)OnPartyTreatedWell()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.TraitLevelingHelper.OnPartyTreatedWell | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_leveling_helper.html#a338fd2d56d05424fe8be9bd62139641d)OnPartyStarved()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.TraitLevelingHelper.OnPartyStarved | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_leveling_helper.html#a3d6fc87f3297c7ff4559d64b43085de5)OnIssueFailed()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.TraitLevelingHelper.OnIssueFailed | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *targetHero*, | |  |  | Tuple< [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html), int >[] | *effectedTraits* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_leveling_helper.html#acdba2ff858a2bfca1694484244ac1399)OnIssueSolvedThroughQuest() [1/2]
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.TraitLevelingHelper.OnIssueSolvedThroughQuest | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *targetHero*, | |  |  | Tuple< [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html), int >[] | *effectedTraits* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_leveling_helper.html#a1f673f5b61544cc28ff58de4b499042b)OnIssueSolvedThroughQuest() [2/2]
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.TraitLevelingHelper.OnIssueSolvedThroughQuest | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *targetHero*, | |  |  | [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html) | *trait*, | |  |  | int | *xp* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_leveling_helper.html#ae618940725909f029553c87c578fd450)OnIssueSolvedThroughAlternativeSolution()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.TraitLevelingHelper.OnIssueSolvedThroughAlternativeSolution | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *targetHero*, | |  |  | Tuple< [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html), int >[] | *effectedTraits* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_leveling_helper.html#adaf33610f5e9186618af83f08b57df8e)OnIssueSolvedThroughBetrayal()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.TraitLevelingHelper.OnIssueSolvedThroughBetrayal | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *targetHero*, | |  |  | Tuple< [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html), int >[] | *effectedTraits* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_leveling_helper.html#ade3987a86436483526633fc76c979105)OnLordFreed()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.TraitLevelingHelper.OnLordFreed | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *targetHero* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_leveling_helper.html#a1edb4ec0c2ffc628d803c2def80cc3a2)OnPersuasionDefection()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.TraitLevelingHelper.OnPersuasionDefection | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *targetHero* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_leveling_helper.html#ac874faef285c3a547b3552dfee0697b2)OnSiegeAftermathApplied()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.TraitLevelingHelper.OnSiegeAftermathApplied | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | [Actions.SiegeAftermathAction.SiegeAftermath](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_siege_aftermath_action.html#a3bd284e7ec4fee476a7dbe532785b1ec) | *aftermathType*, | |  |  | [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html)[] | *effectedTraits* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_leveling_helper.html#ac74a5a689f1d0fb2ab61df58250e1c62)OnIncidentResolved()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.TraitLevelingHelper.OnIncidentResolved | ( | [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html) | *trait*, | |  |  | int | *xpValue* ) | | static |

