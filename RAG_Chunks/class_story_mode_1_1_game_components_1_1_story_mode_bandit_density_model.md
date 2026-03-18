--- SOURCE: class_story_mode_1_1_game_components_1_1_story_mode_bandit_density_model.html ---

StoryMode.GameComponents.StoryModeBanditDensityModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.BanditDensityModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_bandit_density_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override int | [GetMaximumTroopCountForHideoutMission](class_story_mode_1_1_game_components_1_1_story_mode_bandit_density_model.html#ab2bc852ed8138af9bbbc61577084ec43) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, bool isAssault) |
| override bool | [IsPositionInsideNavalSafeZone](class_story_mode_1_1_game_components_1_1_story_mode_bandit_density_model.html#afd926ec8632bd646a23f1de10bf0c730) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) position) |
| override int | [GetMaxSupportedNumberOfLootersForClan](class_story_mode_1_1_game_components_1_1_story_mode_bandit_density_model.html#af2301e566657b886f4f217afa1e4a1d4) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| override int | [GetMinimumTroopCountForHideoutMission](class_story_mode_1_1_game_components_1_1_story_mode_bandit_density_model.html#a6e8ea617eaa322c2990796242d69a367) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, bool isAssault) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.BanditDensityModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_bandit_density_model.html) | |
| int | [GetMaxSupportedNumberOfLootersForClan](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_bandit_density_model.html#a4dbaea459d3d2532387c66683c5190e0) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| int | [GetMinimumTroopCountForHideoutMission](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_bandit_density_model.html#a037ea75a481a6c11763a61bb77234b4e) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, bool isAssault) |
| int | [GetMaximumTroopCountForHideoutMission](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_bandit_density_model.html#a1c81ab547a237677a04dd88b644b3dc7) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, bool isAssault) |
| bool | [IsPositionInsideNavalSafeZone](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_bandit_density_model.html#a6bb62a7c92979d299b4abef01383122f) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) position) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| override int | [NumberOfMaximumBanditPartiesAroundEachHideout](class_story_mode_1_1_game_components_1_1_story_mode_bandit_density_model.html#a8a749378be5444a8bd12035330c2f4ee) `[get]` |
| override int | [NumberOfMaximumBanditPartiesInEachHideout](class_story_mode_1_1_game_components_1_1_story_mode_bandit_density_model.html#a1c0b3cd84955595d36328f3a6d08bd41) `[get]` |
| override int | [NumberOfMaximumHideoutsAtEachBanditFaction](class_story_mode_1_1_game_components_1_1_story_mode_bandit_density_model.html#a3f2f9eb9c6c3daffe54d83f0077040ea) `[get]` |
| override int | [NumberOfInitialHideoutsAtEachBanditFaction](class_story_mode_1_1_game_components_1_1_story_mode_bandit_density_model.html#ab5bf65012df5aea9ea83531f5aab3311) `[get]` |
| override int | [NumberOfMinimumBanditPartiesInAHideoutToInfestIt](class_story_mode_1_1_game_components_1_1_story_mode_bandit_density_model.html#a3482bb52077cf1ad8bac4c71d5bb4db8) `[get]` |
| override int | [NumberOfMinimumBanditTroopsInHideoutMission](class_story_mode_1_1_game_components_1_1_story_mode_bandit_density_model.html#a943eed187f2e3a99fdc6ed1c57f5a35d) `[get]` |
| override int | [NumberOfMaximumTroopCountForFirstFightInHideout](class_story_mode_1_1_game_components_1_1_story_mode_bandit_density_model.html#aed824fff50c70a8309fc5ecaebb410fb) `[get]` |
| override int | [NumberOfMaximumTroopCountForBossFightInHideout](class_story_mode_1_1_game_components_1_1_story_mode_bandit_density_model.html#a2ec2f8ddd32a6ee77071bd4f8e5b12d3) `[get]` |
| override float | [SpawnPercentageForFirstFightInHideoutMission](class_story_mode_1_1_game_components_1_1_story_mode_bandit_density_model.html#a3547cd394adeb697fe0f6ff528bca331) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.BanditDensityModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_bandit_density_model.html) | |
| int | [NumberOfMinimumBanditPartiesInAHideoutToInfestIt](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_bandit_density_model.html#a8651db5efa291c3ecce5e223f3245515) `[get]` |
| int | [NumberOfMaximumBanditPartiesInEachHideout](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_bandit_density_model.html#adb3c532ab76725b9a39d2bf66c165a73) `[get]` |
| int | [NumberOfMaximumBanditPartiesAroundEachHideout](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_bandit_density_model.html#abcebff8e21c726fdcb0ff0f0c0a415d6) `[get]` |
| int | [NumberOfMaximumHideoutsAtEachBanditFaction](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_bandit_density_model.html#a35905aaf85055423b8241160415053f6) `[get]` |
| int | [NumberOfInitialHideoutsAtEachBanditFaction](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_bandit_density_model.html#ad5817e8c19c7043a5396add4634e3592) `[get]` |
| int | [NumberOfMinimumBanditTroopsInHideoutMission](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_bandit_density_model.html#a71dca29c32db9842c0a05fa7773faa7d) `[get]` |
| int | [NumberOfMaximumTroopCountForFirstFightInHideout](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_bandit_density_model.html#af81698b67cf089213cd004d43c59dd3c) `[get]` |
| int | [NumberOfMaximumTroopCountForBossFightInHideout](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_bandit_density_model.html#ac76fac2fdaa5d87c5c50493af1d9f369) `[get]` |
| float | [SpawnPercentageForFirstFightInHideoutMission](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_bandit_density_model.html#a7a179176a28f1d0b1d075a3c834af8b1) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_story_mode_1_1_game_components_1_1_story_mode_bandit_density_model.html#ab2bc852ed8138af9bbbc61577084ec43)GetMaximumTroopCountForHideoutMission()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int StoryMode.GameComponents.StoryModeBanditDensityModel.GetMaximumTroopCountForHideoutMission | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, |
|  |  | bool | *isAssault* ) |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_bandit_density_model.html#afd926ec8632bd646a23f1de10bf0c730)IsPositionInsideNavalSafeZone()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool StoryMode.GameComponents.StoryModeBanditDensityModel.IsPositionInsideNavalSafeZone | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *position* | ) |  |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_bandit_density_model.html#af2301e566657b886f4f217afa1e4a1d4)GetMaxSupportedNumberOfLootersForClan()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int StoryMode.GameComponents.StoryModeBanditDensityModel.GetMaxSupportedNumberOfLootersForClan | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* | ) |  |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_bandit_density_model.html#a6e8ea617eaa322c2990796242d69a367)GetMinimumTroopCountForHideoutMission()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int StoryMode.GameComponents.StoryModeBanditDensityModel.GetMinimumTroopCountForHideoutMission | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, |
|  |  | bool | *isAssault* ) |

Property Documentation
----------------------

[◆](class_story_mode_1_1_game_components_1_1_story_mode_bandit_density_model.html#a8a749378be5444a8bd12035330c2f4ee)NumberOfMaximumBanditPartiesAroundEachHideout
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int StoryMode.GameComponents.StoryModeBanditDensityModel.NumberOfMaximumBanditPartiesAroundEachHideout | | get |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_bandit_density_model.html#a1c0b3cd84955595d36328f3a6d08bd41)NumberOfMaximumBanditPartiesInEachHideout
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int StoryMode.GameComponents.StoryModeBanditDensityModel.NumberOfMaximumBanditPartiesInEachHideout | | get |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_bandit_density_model.html#a3f2f9eb9c6c3daffe54d83f0077040ea)NumberOfMaximumHideoutsAtEachBanditFaction
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int StoryMode.GameComponents.StoryModeBanditDensityModel.NumberOfMaximumHideoutsAtEachBanditFaction | | get |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_bandit_density_model.html#ab5bf65012df5aea9ea83531f5aab3311)NumberOfInitialHideoutsAtEachBanditFaction
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int StoryMode.GameComponents.StoryModeBanditDensityModel.NumberOfInitialHideoutsAtEachBanditFaction | | get |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_bandit_density_model.html#a3482bb52077cf1ad8bac4c71d5bb4db8)NumberOfMinimumBanditPartiesInAHideoutToInfestIt
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int StoryMode.GameComponents.StoryModeBanditDensityModel.NumberOfMinimumBanditPartiesInAHideoutToInfestIt | | get |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_bandit_density_model.html#a943eed187f2e3a99fdc6ed1c57f5a35d)NumberOfMinimumBanditTroopsInHideoutMission
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int StoryMode.GameComponents.StoryModeBanditDensityModel.NumberOfMinimumBanditTroopsInHideoutMission | | get |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_bandit_density_model.html#aed824fff50c70a8309fc5ecaebb410fb)NumberOfMaximumTroopCountForFirstFightInHideout
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int StoryMode.GameComponents.StoryModeBanditDensityModel.NumberOfMaximumTroopCountForFirstFightInHideout | | get |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_bandit_density_model.html#a2ec2f8ddd32a6ee77071bd4f8e5b12d3)NumberOfMaximumTroopCountForBossFightInHideout
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int StoryMode.GameComponents.StoryModeBanditDensityModel.NumberOfMaximumTroopCountForBossFightInHideout | | get |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_bandit_density_model.html#a3547cd394adeb697fe0f6ff528bca331)SpawnPercentageForFirstFightInHideoutMission
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float StoryMode.GameComponents.StoryModeBanditDensityModel.SpawnPercentageForFirstFightInHideoutMission | | get |

