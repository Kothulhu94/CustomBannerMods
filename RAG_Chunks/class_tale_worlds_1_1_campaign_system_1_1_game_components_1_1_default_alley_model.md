--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultAlleyModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.AlleyModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alley_model.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [AlleyMemberAvailabilityDetail](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a1c81258fc9bb3318594dd6939b2a117b) {     [Available](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a1c81258fc9bb3318594dd6939b2a117ba78945de8de090e90045d299651a68a9b) ,     [AvailableWithDelay](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a1c81258fc9bb3318594dd6939b2a117baba9d578f82a79fea6ba8f4d149f3e39c) ,     [NotEnoughRoguerySkill](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a1c81258fc9bb3318594dd6939b2a117baa940d7fb457c43969f894b852eafc0f2) ,     [NotEnoughMercyTrait](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a1c81258fc9bb3318594dd6939b2a117ba64632a3c3b6ee6d88a0a73e98c4bbd21) ,     [CanNotLeadParty](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a1c81258fc9bb3318594dd6939b2a117ba78c5fd0bf69bbb28f29e450054baf04c) ,     [AlreadyAlleyLeader](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a1c81258fc9bb3318594dd6939b2a117bac33bef1c9c9a87632f43256677eff984) ,     [Prisoner](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a1c81258fc9bb3318594dd6939b2a117ba0862a78e358ab0a158439d23cae77e2c) ,     [SolvingIssue](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a1c81258fc9bb3318594dd6939b2a117ba6cec79d75e73ef5b5c25751def1eec4a) ,     [Traveling](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a1c81258fc9bb3318594dd6939b2a117ba534ae0202dfc1e2f430fe1a1e7fb1dc7) ,     [Busy](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a1c81258fc9bb3318594dd6939b2a117bad8a942ef2b04672adfafef0ad817a407) ,     [Fugutive](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a1c81258fc9bb3318594dd6939b2a117bae4a9ba836762552bf691750018cda686) ,     [Governor](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a1c81258fc9bb3318594dd6939b2a117ba511dedda590b2ded1572c99caee392ba) ,     [AlleyUnderAttack](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a1c81258fc9bb3318594dd6939b2a117ba2c4261f269a755b9b12dbeded5787003)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| override float | [GetDailyXpGainForAssignedClanMember](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a8bc93cc0074428a6d284543b72d002ca) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) assignedHero) |
| override float | [GetDailyXpGainForMainHero](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#af134cde54a175a90c7bb89a7b6494fe2) () |
| override float | [GetInitialXpGainForMainHero](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#aa82d003637664fdb8428ef239e09bd0a) () |
| override float | [GetXpGainAfterSuccessfulAlleyDefenseForMainHero](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a34d1d36567c49da4147ae71fdcd0938a) () |
| override [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | [GetTroopsOfAIOwnedAlley](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#ae1571f806eaa398e6a91b8440a64cb47) ([Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) alley) |
| override [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | [GetTroopsOfAlleyForBattleMission](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a8d23b9e109d6ea3fd61f115038632639) ([Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) alley) |
| override List<([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [AlleyMemberAvailabilityDetail](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a1c81258fc9bb3318594dd6939b2a117b))> | [GetClanMembersAndAvailabilityDetailsForLeadingAnAlley](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#af3d8f4492f89bca5ed2d302d5818b253) ([Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) alley) |
| override [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | [GetTroopsToRecruitFromAlleyDependingOnAlleyRandom](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a9cab14401314d1cb9cc7b4e5b55a53ee) ([Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) alley, float random) |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetDisabledReasonTextForHero](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a38c7392f05e5c44d16805696eb73aafc) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) alley, [AlleyMemberAvailabilityDetail](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a1c81258fc9bb3318594dd6939b2a117b) detail) |
| override float | [GetAlleyAttackResponseTimeInDays](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a040fa007c030c21efb73538cdc449fd6) ([TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) troopRoster) |
| override int | [GetDailyIncomeOfAlley](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#adf21550babf5a229c6443b170d8d89f0) ([Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) alley) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.AlleyModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alley_model.html) | |
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
| Static Public Attributes | |
| const int | [MinimumRoguerySkillNeededForLeadingAnAlley](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a41a08e642036ac164f2249ccca35e7ee) = 30 |
| const int | [MaximumMercyTraitNeededForLeadingAnAlley](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a8cccc794fbcb98ac94886a73b97aecff) = 0 |

|  |  |
| --- | --- |
| Properties | |
| override [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [DestroyAlleyAfterDaysWhenLeaderIsDeath](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a52375af0ada879b2c1fd42ce8617832f) `[get]` |
| override int | [MinimumTroopCountInPlayerOwnedAlley](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a937f32a0fec641b80628972941a92bd0) `[get]` |
| override int | [MaximumTroopCountInPlayerOwnedAlley](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a9ae71c7bb95806f5e789b62390b2508d) `[get]` |
| override float | [GetDailyCrimeRatingOfAlley](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#ac9484263aa67abbc0bccc5ab28c5064d) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.AlleyModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alley_model.html) | |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [DestroyAlleyAfterDaysWhenLeaderIsDeath](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alley_model.html#ac788fdb4db93082d8b5529b7e84f7fd8) `[get]` |
| int | [MinimumTroopCountInPlayerOwnedAlley](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alley_model.html#af7f89abd79683e0dc248b1ee6e0e1282) `[get]` |
| int | [MaximumTroopCountInPlayerOwnedAlley](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alley_model.html#a2afaedac697fb6b265746a548f53f13a) `[get]` |
| float | [GetDailyCrimeRatingOfAlley](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_alley_model.html#a6c04a20d4d3538999c6bdaef340e50cb) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a1c81258fc9bb3318594dd6939b2a117b)AlleyMemberAvailabilityDetail
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.GameComponents.DefaultAlleyModel.AlleyMemberAvailabilityDetail](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a1c81258fc9bb3318594dd6939b2a117b) |

| Enumerator | |
| --- | --- |
| Available |  |
| AvailableWithDelay |  |
| NotEnoughRoguerySkill |  |
| NotEnoughMercyTrait |  |
| CanNotLeadParty |  |
| AlreadyAlleyLeader |  |
| Prisoner |  |
| SolvingIssue |  |
| Traveling |  |
| Busy |  |
| Fugutive |  |
| Governor |  |
| AlleyUnderAttack |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a8bc93cc0074428a6d284543b72d002ca)GetDailyXpGainForAssignedClanMember()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultAlleyModel.GetDailyXpGainForAssignedClanMember | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *assignedHero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#af134cde54a175a90c7bb89a7b6494fe2)GetDailyXpGainForMainHero()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultAlleyModel.GetDailyXpGainForMainHero | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#aa82d003637664fdb8428ef239e09bd0a)GetInitialXpGainForMainHero()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultAlleyModel.GetInitialXpGainForMainHero | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a34d1d36567c49da4147ae71fdcd0938a)GetXpGainAfterSuccessfulAlleyDefenseForMainHero()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultAlleyModel.GetXpGainAfterSuccessfulAlleyDefenseForMainHero | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#ae1571f806eaa398e6a91b8440a64cb47)GetTroopsOfAIOwnedAlley()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) TaleWorlds.CampaignSystem.GameComponents.DefaultAlleyModel.GetTroopsOfAIOwnedAlley | ( | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | *alley* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a8d23b9e109d6ea3fd61f115038632639)GetTroopsOfAlleyForBattleMission()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) TaleWorlds.CampaignSystem.GameComponents.DefaultAlleyModel.GetTroopsOfAlleyForBattleMission | ( | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | *alley* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#af3d8f4492f89bca5ed2d302d5818b253)GetClanMembersAndAvailabilityDetailsForLeadingAnAlley()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override List<([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [AlleyMemberAvailabilityDetail](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a1c81258fc9bb3318594dd6939b2a117b))> TaleWorlds.CampaignSystem.GameComponents.DefaultAlleyModel.GetClanMembersAndAvailabilityDetailsForLeadingAnAlley | ( | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | *alley* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a9cab14401314d1cb9cc7b4e5b55a53ee)GetTroopsToRecruitFromAlleyDependingOnAlleyRandom()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) TaleWorlds.CampaignSystem.GameComponents.DefaultAlleyModel.GetTroopsToRecruitFromAlleyDependingOnAlleyRandom | ( | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | *alley*, |
|  |  | float | *random* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a38c7392f05e5c44d16805696eb73aafc)GetDisabledReasonTextForHero()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.GameComponents.DefaultAlleyModel.GetDisabledReasonTextForHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | *alley*, |
|  |  | [AlleyMemberAvailabilityDetail](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a1c81258fc9bb3318594dd6939b2a117b) | *detail* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a040fa007c030c21efb73538cdc449fd6)GetAlleyAttackResponseTimeInDays()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultAlleyModel.GetAlleyAttackResponseTimeInDays | ( | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *troopRoster* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#adf21550babf5a229c6443b170d8d89f0)GetDailyIncomeOfAlley()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultAlleyModel.GetDailyIncomeOfAlley | ( | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | *alley* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a41a08e642036ac164f2249ccca35e7ee)MinimumRoguerySkillNeededForLeadingAnAlley
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.CampaignSystem.GameComponents.DefaultAlleyModel.MinimumRoguerySkillNeededForLeadingAnAlley = 30 | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a8cccc794fbcb98ac94886a73b97aecff)MaximumMercyTraitNeededForLeadingAnAlley
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.CampaignSystem.GameComponents.DefaultAlleyModel.MaximumMercyTraitNeededForLeadingAnAlley = 0 | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a52375af0ada879b2c1fd42ce8617832f)DestroyAlleyAfterDaysWhenLeaderIsDeath
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.GameComponents.DefaultAlleyModel.DestroyAlleyAfterDaysWhenLeaderIsDeath | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a937f32a0fec641b80628972941a92bd0)MinimumTroopCountInPlayerOwnedAlley
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultAlleyModel.MinimumTroopCountInPlayerOwnedAlley | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#a9ae71c7bb95806f5e789b62390b2508d)MaximumTroopCountInPlayerOwnedAlley
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultAlleyModel.MaximumTroopCountInPlayerOwnedAlley | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_alley_model.html#ac9484263aa67abbc0bccc5ab28c5064d)GetDailyCrimeRatingOfAlley
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultAlleyModel.GetDailyCrimeRatingOfAlley | | get |

