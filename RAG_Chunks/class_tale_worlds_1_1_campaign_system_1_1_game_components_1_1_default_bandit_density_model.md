--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_bandit_density_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultBanditDensityModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.BanditDensityModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_bandit_density_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override int | [GetMinimumTroopCountForHideoutMission](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_bandit_density_model.html#a42a395e464f1ca784e31c1ddad734df9) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, bool isAssault) |
| override int | [GetMaxSupportedNumberOfLootersForClan](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_bandit_density_model.html#a8514e214202b586297a28e51e33062ca) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| override int | [GetMaximumTroopCountForHideoutMission](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_bandit_density_model.html#ab7dd7d48b694aa077a0f5a032186fc79) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, bool isAssault) |
| override bool | [IsPositionInsideNavalSafeZone](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_bandit_density_model.html#a5bcf01258622de2cd5af3601b58c5a79) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) position) |
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
| override int | [NumberOfMinimumBanditPartiesInAHideoutToInfestIt](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_bandit_density_model.html#aaa35530527dc0030a42672200d5b6f76) `[get]` |
| override int | [NumberOfMaximumBanditPartiesInEachHideout](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_bandit_density_model.html#a3937c7ea397d8718a6543bd9a6787514) `[get]` |
| override int | [NumberOfMaximumBanditPartiesAroundEachHideout](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_bandit_density_model.html#a358bc7389a51df72ee63b9d2bf0f7f6d) `[get]` |
| override int | [NumberOfMaximumHideoutsAtEachBanditFaction](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_bandit_density_model.html#a2198dd8919fc4d79de00cccd6741cdde) `[get]` |
| override int | [NumberOfInitialHideoutsAtEachBanditFaction](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_bandit_density_model.html#ab3c7e146bfa69d24a00280ca95dffe89) `[get]` |
| override int | [NumberOfMinimumBanditTroopsInHideoutMission](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_bandit_density_model.html#a1f59c1cc2de79f5e7a445c8a9851483c) `[get]` |
| override int | [NumberOfMaximumTroopCountForFirstFightInHideout](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_bandit_density_model.html#a80f496797aec6cb1a5a672a092f7f5a6) `[get]` |
| override int | [NumberOfMaximumTroopCountForBossFightInHideout](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_bandit_density_model.html#aaa24c7794e73dc1503baa64344d43140) `[get]` |
| override float | [SpawnPercentageForFirstFightInHideoutMission](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_bandit_density_model.html#aea17cceca9de669698095fdc8872db09) `[get]` |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_bandit_density_model.html#a42a395e464f1ca784e31c1ddad734df9)GetMinimumTroopCountForHideoutMission()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultBanditDensityModel.GetMinimumTroopCountForHideoutMission | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, |
|  |  | bool | *isAssault* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_bandit_density_model.html#a8514e214202b586297a28e51e33062ca)GetMaxSupportedNumberOfLootersForClan()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultBanditDensityModel.GetMaxSupportedNumberOfLootersForClan | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_bandit_density_model.html#ab7dd7d48b694aa077a0f5a032186fc79)GetMaximumTroopCountForHideoutMission()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultBanditDensityModel.GetMaximumTroopCountForHideoutMission | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, |
|  |  | bool | *isAssault* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_bandit_density_model.html#a5bcf01258622de2cd5af3601b58c5a79)IsPositionInsideNavalSafeZone()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultBanditDensityModel.IsPositionInsideNavalSafeZone | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *position* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_bandit_density_model.html#aaa35530527dc0030a42672200d5b6f76)NumberOfMinimumBanditPartiesInAHideoutToInfestIt
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultBanditDensityModel.NumberOfMinimumBanditPartiesInAHideoutToInfestIt | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_bandit_density_model.html#a3937c7ea397d8718a6543bd9a6787514)NumberOfMaximumBanditPartiesInEachHideout
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultBanditDensityModel.NumberOfMaximumBanditPartiesInEachHideout | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_bandit_density_model.html#a358bc7389a51df72ee63b9d2bf0f7f6d)NumberOfMaximumBanditPartiesAroundEachHideout
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultBanditDensityModel.NumberOfMaximumBanditPartiesAroundEachHideout | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_bandit_density_model.html#a2198dd8919fc4d79de00cccd6741cdde)NumberOfMaximumHideoutsAtEachBanditFaction
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultBanditDensityModel.NumberOfMaximumHideoutsAtEachBanditFaction | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_bandit_density_model.html#ab3c7e146bfa69d24a00280ca95dffe89)NumberOfInitialHideoutsAtEachBanditFaction
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultBanditDensityModel.NumberOfInitialHideoutsAtEachBanditFaction | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_bandit_density_model.html#a1f59c1cc2de79f5e7a445c8a9851483c)NumberOfMinimumBanditTroopsInHideoutMission
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultBanditDensityModel.NumberOfMinimumBanditTroopsInHideoutMission | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_bandit_density_model.html#a80f496797aec6cb1a5a672a092f7f5a6)NumberOfMaximumTroopCountForFirstFightInHideout
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultBanditDensityModel.NumberOfMaximumTroopCountForFirstFightInHideout | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_bandit_density_model.html#aaa24c7794e73dc1503baa64344d43140)NumberOfMaximumTroopCountForBossFightInHideout
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultBanditDensityModel.NumberOfMaximumTroopCountForBossFightInHideout | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_bandit_density_model.html#aea17cceca9de669698095fdc8872db09)SpawnPercentageForFirstFightInHideoutMission
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultBanditDensityModel.SpawnPercentageForFirstFightInHideoutMission | | get |

