--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_bandit_spawn_campaign_behavior.html ---

TaleWorlds.CampaignSystem.CampaignBehaviors.BanditSpawnCampaignBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_bandit_spawn_campaign_behavior.html#a9eb873971f70b327435c1d80c39a7bbc) () |
| override void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_bandit_spawn_campaign_behavior.html#afb1a27cde17194edc6a9f5e592ab11ef) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| void | [InitializeInitialHideouts](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_bandit_spawn_campaign_behavior.html#a043f20c5b1355d1aed250443f6b6b9b9) () |
| void | [OnSettlementEntered](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_bandit_spawn_campaign_behavior.html#a8c344bec9f5b19f3162ba7fe045d0346) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| void | [DailyTick](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_bandit_spawn_campaign_behavior.html#acc910410d213fe08a1f573623aba5898) () |
| [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | [AddBanditToHideout](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_bandit_spawn_campaign_behavior.html#aa0494d19ba1edb0c7a0347a89ae2c18d) ([Hideout](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_hideout.html) hideoutComponent, [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) overridenPartyTemplate=null, bool isBanditBossParty=false) |
| void | [SpawnBanditsAroundHideoutAtNewGame](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_bandit_spawn_campaign_behavior.html#a45a9f583747b557b7ee9d37f82a54b4f) () |
| void | [SpawnLootersAtNewGame](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_bandit_spawn_campaign_behavior.html#a5731a446d5b792029e29af8623a1e45e) () |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a053965730807cc40179cb1ee0495c376) (string stringId) |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab8914958880a708aaf68f676e6c29df1) () |
| void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a402e03be483527df560a46a7a01004a6) () |
| void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a5f2a833b5a67619021c6c437a1232877) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| static T | [GetCampaignBehavior< T >](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#af9fd34472faff4ae39b627e8d3091b7e) () |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| readonly string | [StringId](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab1c3b0a4161f58781148a9499be70fa3) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_bandit_spawn_campaign_behavior.html#a9eb873971f70b327435c1d80c39a7bbc)RegisterEvents()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.BanditSpawnCampaignBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_bandit_spawn_campaign_behavior.html#afb1a27cde17194edc6a9f5e592ab11ef)SyncData()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.BanditSpawnCampaignBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_bandit_spawn_campaign_behavior.html#a043f20c5b1355d1aed250443f6b6b9b9)InitializeInitialHideouts()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.BanditSpawnCampaignBehavior.InitializeInitialHideouts | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_bandit_spawn_campaign_behavior.html#a8c344bec9f5b19f3162ba7fe045d0346)OnSettlementEntered()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.BanditSpawnCampaignBehavior.OnSettlementEntered | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, |
|  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_bandit_spawn_campaign_behavior.html#acc910410d213fe08a1f573623aba5898)DailyTick()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.BanditSpawnCampaignBehavior.DailyTick | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_bandit_spawn_campaign_behavior.html#aa0494d19ba1edb0c7a0347a89ae2c18d)AddBanditToHideout()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) TaleWorlds.CampaignSystem.CampaignBehaviors.BanditSpawnCampaignBehavior.AddBanditToHideout | ( | [Hideout](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_hideout.html) | *hideoutComponent*, |
|  |  | [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) | *overridenPartyTemplate* = null, |
|  |  | bool | *isBanditBossParty* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_bandit_spawn_campaign_behavior.html#a45a9f583747b557b7ee9d37f82a54b4f)SpawnBanditsAroundHideoutAtNewGame()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.BanditSpawnCampaignBehavior.SpawnBanditsAroundHideoutAtNewGame | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_bandit_spawn_campaign_behavior.html#a5731a446d5b792029e29af8623a1e45e)SpawnLootersAtNewGame()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.BanditSpawnCampaignBehavior.SpawnLootersAtNewGame | ( |  | ) |  |

