--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_recruitment_campaign_behavior.html ---

TaleWorlds.CampaignSystem.CampaignBehaviors.RecruitmentCampaignBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html).

|  |  |
| --- | --- |
| Classes | |
| class | [RecruitmentCampaignBehaviorTypeDefiner](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_recruitment_campaign_behavior_1d3d4fb27952788623eddf24faf4af07b.html) |
| class | [TownMercenaryData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_recruitment_campaign_behavior_1_1_town_mercenary_data.html) |

|  |  |
| --- | --- |
| Public Types | |
| enum | [RecruitingDetail](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_recruitment_campaign_behavior.html#a04a8751153ca4e47858a8f68637400ef) {     [MercenaryFromTavern](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_recruitment_campaign_behavior.html#a04a8751153ca4e47858a8f68637400efa6ac83718199410ce2f83b69b05f523f4) ,     [VolunteerFromIndividual](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_recruitment_campaign_behavior.html#a04a8751153ca4e47858a8f68637400efa3da06a41b85120017e41ec929d4c6fd7) ,     [VolunteerFromIndividualToGarrison](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_recruitment_campaign_behavior.html#a04a8751153ca4e47858a8f68637400efa12f38b258b7114a0acfa29aeb8bb3823) ,     [VolunteerFromMap](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_recruitment_campaign_behavior.html#a04a8751153ca4e47858a8f68637400efa6d706ce3c021aadca1fad1e663df7930)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_recruitment_campaign_behavior.html#ab0f290f28aa5bef5990960dde6e89b98) () |
| override void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_recruitment_campaign_behavior.html#aa2e1249ac129e22a1c4966ec70d64647) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| [TownMercenaryData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_recruitment_campaign_behavior_1_1_town_mercenary_data.html) | [GetMercenaryData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_recruitment_campaign_behavior.html#ab1327c2e469b47323bf4bd2865d8f373) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| void | [HourlyTickParty](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_recruitment_campaign_behavior.html#ac195b6238a1fd7c0cb39399cf3ccb57a) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| void | [OnBeforeSettlementEntered](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_recruitment_campaign_behavior.html#a044f62ba8a8e7ef05c6a13c42ee3c182) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a053965730807cc40179cb1ee0495c376) (string stringId) |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab8914958880a708aaf68f676e6c29df1) () |
| void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a402e03be483527df560a46a7a01004a6) () |
| void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a5f2a833b5a67619021c6c437a1232877) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| void | [AddGameMenus](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_recruitment_campaign_behavior.html#a586f88f6cb7e5603e1f72e16c066fc35) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameSystemStarter) |
| void | [AddDialogs](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_recruitment_campaign_behavior.html#a861473b69ed42097ac446b2ff97e447a) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameStarter) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| static T | [GetCampaignBehavior< T >](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#af9fd34472faff4ae39b627e8d3091b7e) () |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| readonly string | [StringId](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab1c3b0a4161f58781148a9499be70fa3) |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_recruitment_campaign_behavior.html#a04a8751153ca4e47858a8f68637400ef)RecruitingDetail
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.CampaignBehaviors.RecruitmentCampaignBehavior.RecruitingDetail](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_recruitment_campaign_behavior.html#a04a8751153ca4e47858a8f68637400ef) |

| Enumerator | |
| --- | --- |
| MercenaryFromTavern |  |
| VolunteerFromIndividual |  |
| VolunteerFromIndividualToGarrison |  |
| VolunteerFromMap |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_recruitment_campaign_behavior.html#ab0f290f28aa5bef5990960dde6e89b98)RegisterEvents()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.RecruitmentCampaignBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_recruitment_campaign_behavior.html#aa2e1249ac129e22a1c4966ec70d64647)SyncData()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.RecruitmentCampaignBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_recruitment_campaign_behavior.html#ab1327c2e469b47323bf4bd2865d8f373)GetMercenaryData()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [TownMercenaryData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_recruitment_campaign_behavior_1_1_town_mercenary_data.html) TaleWorlds.CampaignSystem.CampaignBehaviors.RecruitmentCampaignBehavior.GetMercenaryData | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_recruitment_campaign_behavior.html#ac195b6238a1fd7c0cb39399cf3ccb57a)HourlyTickParty()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.RecruitmentCampaignBehavior.HourlyTickParty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_recruitment_campaign_behavior.html#a044f62ba8a8e7ef05c6a13c42ee3c182)OnBeforeSettlementEntered()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.RecruitmentCampaignBehavior.OnBeforeSettlementEntered | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, |
|  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_recruitment_campaign_behavior.html#a586f88f6cb7e5603e1f72e16c066fc35)AddGameMenus()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CampaignBehaviors.RecruitmentCampaignBehavior.AddGameMenus | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *campaignGameSystemStarter* | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_recruitment_campaign_behavior.html#a861473b69ed42097ac446b2ff97e447a)AddDialogs()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CampaignBehaviors.RecruitmentCampaignBehavior.AddDialogs | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *campaignGameStarter* | ) |  | | protected |

