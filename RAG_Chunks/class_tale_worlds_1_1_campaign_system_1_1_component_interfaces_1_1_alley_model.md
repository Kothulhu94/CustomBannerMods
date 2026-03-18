--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alley_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.AlleyModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultAlleyModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| float | [GetDailyXpGainForAssignedClanMember](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alley_model.html#a71c3c09e89c0da31ccd61893a4da9f72) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) assignedHero) |
| float | [GetDailyXpGainForMainHero](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alley_model.html#a92f991c780508fa1a22fb98927fe8f3b) () |
| float | [GetInitialXpGainForMainHero](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alley_model.html#ae611bb9a697302fed12f0310b1b5cc3e) () |
| float | [GetXpGainAfterSuccessfulAlleyDefenseForMainHero](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alley_model.html#a88071493430ce3385aa55e337da70307) () |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | [GetTroopsOfAIOwnedAlley](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alley_model.html#afe984cd82093251be65a9746ba9e9e75) ([Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) alley) |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | [GetTroopsOfAlleyForBattleMission](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alley_model.html#ab1526cbee2e7033af9e192627f93fc15) ([Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) alley) |
| int | [GetDailyIncomeOfAlley](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alley_model.html#ac656939669bf8ef467300053c3cdb47b) ([Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) alley) |
| List<([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [DefaultAlleyModel.AlleyMemberAvailabilityDetail](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a1c81258fc9bb3318594dd6939b2a117b))> | [GetClanMembersAndAvailabilityDetailsForLeadingAnAlley](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alley_model.html#af66d8cae0b680132c82841601039a670) ([Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) alley) |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | [GetTroopsToRecruitFromAlleyDependingOnAlleyRandom](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alley_model.html#a28b3262546f9a7552ac747412e09d2c5) ([Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) alley, float random) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetDisabledReasonTextForHero](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alley_model.html#a412b048f3c168d9309a2fbf7cbf2c907) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) alley, [DefaultAlleyModel.AlleyMemberAvailabilityDetail](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a1c81258fc9bb3318594dd6939b2a117b) detail) |
| float | [GetAlleyAttackResponseTimeInDays](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alley_model.html#a5cb7bac5ae44593916f684a6ad15d608) ([TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) troopRoster) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [DestroyAlleyAfterDaysWhenLeaderIsDeath](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alley_model.html#ac788fdb4db93082d8b5529b7e84f7fd8) `[get]` |
| int | [MinimumTroopCountInPlayerOwnedAlley](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alley_model.html#af7f89abd79683e0dc248b1ee6e0e1282) `[get]` |
| int | [MaximumTroopCountInPlayerOwnedAlley](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alley_model.html#a2afaedac697fb6b265746a548f53f13a) `[get]` |
| float | [GetDailyCrimeRatingOfAlley](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alley_model.html#a6c04a20d4d3538999c6bdaef340e50cb) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alley_model.html#a71c3c09e89c0da31ccd61893a4da9f72)GetDailyXpGainForAssignedClanMember()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.AlleyModel.GetDailyXpGainForAssignedClanMember | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *assignedHero* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alley_model.html#a92f991c780508fa1a22fb98927fe8f3b)GetDailyXpGainForMainHero()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.AlleyModel.GetDailyXpGainForMainHero | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alley_model.html#ae611bb9a697302fed12f0310b1b5cc3e)GetInitialXpGainForMainHero()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.AlleyModel.GetInitialXpGainForMainHero | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alley_model.html#a88071493430ce3385aa55e337da70307)GetXpGainAfterSuccessfulAlleyDefenseForMainHero()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.AlleyModel.GetXpGainAfterSuccessfulAlleyDefenseForMainHero | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alley_model.html#afe984cd82093251be65a9746ba9e9e75)GetTroopsOfAIOwnedAlley()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) TaleWorlds.CampaignSystem.ComponentInterfaces.AlleyModel.GetTroopsOfAIOwnedAlley | ( | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | *alley* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alley_model.html#ab1526cbee2e7033af9e192627f93fc15)GetTroopsOfAlleyForBattleMission()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) TaleWorlds.CampaignSystem.ComponentInterfaces.AlleyModel.GetTroopsOfAlleyForBattleMission | ( | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | *alley* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alley_model.html#ac656939669bf8ef467300053c3cdb47b)GetDailyIncomeOfAlley()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.AlleyModel.GetDailyIncomeOfAlley | ( | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | *alley* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alley_model.html#af66d8cae0b680132c82841601039a670)GetClanMembersAndAvailabilityDetailsForLeadingAnAlley()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | List<([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [DefaultAlleyModel.AlleyMemberAvailabilityDetail](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a1c81258fc9bb3318594dd6939b2a117b))> TaleWorlds.CampaignSystem.ComponentInterfaces.AlleyModel.GetClanMembersAndAvailabilityDetailsForLeadingAnAlley | ( | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | *alley* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alley_model.html#a28b3262546f9a7552ac747412e09d2c5)GetTroopsToRecruitFromAlleyDependingOnAlleyRandom()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) TaleWorlds.CampaignSystem.ComponentInterfaces.AlleyModel.GetTroopsToRecruitFromAlleyDependingOnAlleyRandom | ( | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | *alley*, | |  |  | float | *random* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alley_model.html#a412b048f3c168d9309a2fbf7cbf2c907)GetDisabledReasonTextForHero()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.ComponentInterfaces.AlleyModel.GetDisabledReasonTextForHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | *alley*, | |  |  | [DefaultAlleyModel.AlleyMemberAvailabilityDetail](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a1c81258fc9bb3318594dd6939b2a117b) | *detail* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alley_model.html#a5cb7bac5ae44593916f684a6ad15d608)GetAlleyAttackResponseTimeInDays()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.AlleyModel.GetAlleyAttackResponseTimeInDays | ( | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *troopRoster* | ) |  | | abstract |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alley_model.html#ac788fdb4db93082d8b5529b7e84f7fd8)DestroyAlleyAfterDaysWhenLeaderIsDeath
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.ComponentInterfaces.AlleyModel.DestroyAlleyAfterDaysWhenLeaderIsDeath | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alley_model.html#af7f89abd79683e0dc248b1ee6e0e1282)MinimumTroopCountInPlayerOwnedAlley
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.AlleyModel.MinimumTroopCountInPlayerOwnedAlley | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alley_model.html#a2afaedac697fb6b265746a548f53f13a)MaximumTroopCountInPlayerOwnedAlley
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.AlleyModel.MaximumTroopCountInPlayerOwnedAlley | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alley_model.html#a6c04a20d4d3538999c6bdaef340e50cb)GetDailyCrimeRatingOfAlley
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.AlleyModel.GetDailyCrimeRatingOfAlley | | getabstract |

