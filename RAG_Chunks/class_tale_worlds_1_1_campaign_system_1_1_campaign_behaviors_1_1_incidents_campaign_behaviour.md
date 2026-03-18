--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_incidents_campaign_behaviour.html ---

TaleWorlds.CampaignSystem.CampaignBehaviors.IncidentsCampaignBehaviour Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html), and [TaleWorlds.CampaignSystem.CampaignBehaviors.INonReadyObjectHandler](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_non_ready_object_handler.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [IncidentTrigger](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_incidents_campaign_behaviour.html#ae453a5538ce9f94f7a7e677afa8621e8) {     [LeavingVillage](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_incidents_campaign_behaviour.html#ae453a5538ce9f94f7a7e677afa8621e8aa8581af0e3ef6c452831bc37a9cf74e4) = 1 ,     [LeavingTown](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_incidents_campaign_behaviour.html#ae453a5538ce9f94f7a7e677afa8621e8a989af1264cc6cded19874a543ea914e8) = 2 ,     [LeavingCastle](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_incidents_campaign_behaviour.html#ae453a5538ce9f94f7a7e677afa8621e8af5aadd014a2632ad2e7e3b581e97370f) = 4 ,     [LeavingSettlement](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_incidents_campaign_behaviour.html#ae453a5538ce9f94f7a7e677afa8621e8acb582e86c93289932d242706acd048cd) = 8 ,     [LeavingEncounter](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_incidents_campaign_behaviour.html#ae453a5538ce9f94f7a7e677afa8621e8ad974f9a3e6c9641181b2430f0ef56e7a) = 16 ,     [LeavingBattle](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_incidents_campaign_behaviour.html#ae453a5538ce9f94f7a7e677afa8621e8a0a96cc880958be48ef2a8c4b3b1ca907) = 32 ,     [EnteringVillage](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_incidents_campaign_behaviour.html#ae453a5538ce9f94f7a7e677afa8621e8a7b91d20013e1cfce3dcead60c1b7b925) = 64 ,     [EnteringTown](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_incidents_campaign_behaviour.html#ae453a5538ce9f94f7a7e677afa8621e8a079e5349208a6c57277071ab80a47fa4) = 128 ,     [EnteringCastle](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_incidents_campaign_behaviour.html#ae453a5538ce9f94f7a7e677afa8621e8ad65d1d0772e7e0465695e93c967ea189) = 256 ,     [WaitingInSettlement](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_incidents_campaign_behaviour.html#ae453a5538ce9f94f7a7e677afa8621e8aef7fbdebf5d6d8c87e9373b28e63deda) = 512 ,     [DuringSiege](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_incidents_campaign_behaviour.html#ae453a5538ce9f94f7a7e677afa8621e8ab73e88d36e6ff0614d315952265abba3) = 1024   } |
| enum | [IncidentType](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_incidents_campaign_behaviour.html#acf79a4f54bce5231ccfa35fd5b5a904b) {     [TroopSettlementRelation](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_incidents_campaign_behaviour.html#acf79a4f54bce5231ccfa35fd5b5a904baf6a2c6fd3f2065a77f7a3e7036e886c0) ,     [FoodConsumption](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_incidents_campaign_behaviour.html#acf79a4f54bce5231ccfa35fd5b5a904ba3e750b6f169e100867e1601f3996a5fe) ,     [PlightOfCivilians](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_incidents_campaign_behaviour.html#acf79a4f54bce5231ccfa35fd5b5a904ba2252c5b2980df9ce31e629620c8c83bd) ,     [PartyCampLife](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_incidents_campaign_behaviour.html#acf79a4f54bce5231ccfa35fd5b5a904bafd7da7e8d5622c5809fe7b9bca9232b9) ,     [AnimalIllness](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_incidents_campaign_behaviour.html#acf79a4f54bce5231ccfa35fd5b5a904ba4b23477edf3c347bb39031c70da8d5e6) ,     [Illness](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_incidents_campaign_behaviour.html#acf79a4f54bce5231ccfa35fd5b5a904ba8ec6de7678230eb00d4fad25289f6940) ,     [HuntingForaging](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_incidents_campaign_behaviour.html#acf79a4f54bce5231ccfa35fd5b5a904baee9dab686439fd23e3285bab1663a506) ,     [PostBattle](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_incidents_campaign_behaviour.html#acf79a4f54bce5231ccfa35fd5b5a904baea627fdd599df21f58f2bc1d9365d866) ,     [HardTravel](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_incidents_campaign_behaviour.html#acf79a4f54bce5231ccfa35fd5b5a904ba154348f0c8a6e0b5b5c4e24a43016ae3) ,     [Profit](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_incidents_campaign_behaviour.html#acf79a4f54bce5231ccfa35fd5b5a904ba182875b6c36a761f1e459624c1d93638) ,     [DreamsSongsAndSigns](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_incidents_campaign_behaviour.html#acf79a4f54bce5231ccfa35fd5b5a904ba2b38cbb43ebcebaa76d3d88d9775c64c) ,     [FiefManagement](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_incidents_campaign_behaviour.html#acf79a4f54bce5231ccfa35fd5b5a904ba1cf2526a8e4e7024b449c54c1c3038f0) ,     [Siege](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_incidents_campaign_behaviour.html#acf79a4f54bce5231ccfa35fd5b5a904ba7e86b036c23f9a7df08bff9baeaf98ad) ,     [Workshop](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_incidents_campaign_behaviour.html#acf79a4f54bce5231ccfa35fd5b5a904ba8e5d9dbc85b2f11b4b8bed57cadf53e5)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_incidents_campaign_behaviour.html#ab990f36955918ea136e71b916d010da0) () |
| override void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_incidents_campaign_behaviour.html#a8694cda98fb5b97bc27bd38d320fb947) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
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

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_incidents_campaign_behaviour.html#ae453a5538ce9f94f7a7e677afa8621e8)IncidentTrigger
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.CampaignBehaviors.IncidentsCampaignBehaviour.IncidentTrigger](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_incidents_campaign_behaviour.html#ae453a5538ce9f94f7a7e677afa8621e8) |

| Enumerator | |
| --- | --- |
| LeavingVillage |  |
| LeavingTown |  |
| LeavingCastle |  |
| LeavingSettlement |  |
| LeavingEncounter |  |
| LeavingBattle |  |
| EnteringVillage |  |
| EnteringTown |  |
| EnteringCastle |  |
| WaitingInSettlement |  |
| DuringSiege |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_incidents_campaign_behaviour.html#acf79a4f54bce5231ccfa35fd5b5a904b)IncidentType
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.CampaignBehaviors.IncidentsCampaignBehaviour.IncidentType](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_incidents_campaign_behaviour.html#acf79a4f54bce5231ccfa35fd5b5a904b) |

| Enumerator | |
| --- | --- |
| TroopSettlementRelation |  |
| FoodConsumption |  |
| PlightOfCivilians |  |
| PartyCampLife |  |
| AnimalIllness |  |
| Illness |  |
| HuntingForaging |  |
| PostBattle |  |
| HardTravel |  |
| Profit |  |
| DreamsSongsAndSigns |  |
| FiefManagement |  |
| Siege |  |
| Workshop |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_incidents_campaign_behaviour.html#ab990f36955918ea136e71b916d010da0)RegisterEvents()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.IncidentsCampaignBehaviour.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_incidents_campaign_behaviour.html#a8694cda98fb5b97bc27bd38d320fb947)SyncData()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.IncidentsCampaignBehaviour.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

