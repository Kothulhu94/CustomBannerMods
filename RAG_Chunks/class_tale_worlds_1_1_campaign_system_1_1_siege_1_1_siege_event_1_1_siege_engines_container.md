--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html ---

TaleWorlds.CampaignSystem.Siege.SiegeEvent.SiegeEnginesContainer Class Reference|  |  |
| --- | --- |
| Classes | |
| class | [RemovedSiegeEngine](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container_1_1_removed_siege_engine.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
| IEnumerable< [SiegeEngineConstructionProgress](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engine_construction_progress.html) > | [AllSiegeEngines](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html#a51a4023feba86a30d6f3501a040172a4) () |
|  | [SiegeEnginesContainer](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html#a1f6d0b375da236ced751833f943e0bd8) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, [SiegeEngineConstructionProgress](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engine_construction_progress.html) siegePreparations) |
| void | [AddPrebuiltEngineToReserve](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html#adf373021876a02cb38b6fd4b07336300) ([SiegeEngineConstructionProgress](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engine_construction_progress.html) siegeEngine) |
| void | [DeploySiegeEngineAtIndex](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html#a6efb9362f4cfcda28c64675a8219d3a8) ([SiegeEngineConstructionProgress](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engine_construction_progress.html) siegeEngine, int index) |
| void | [RemoveDeployedSiegeEngine](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html#a3256cdd2bd4e941bbebc8199184b0949) (int index, bool isRanged, bool moveToReserve) |
| bool | [RemovedSiegeEngineFromReservedSiegeEngines](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html#af5484705590e71e60932a14b283fe681) ([SiegeEngineConstructionProgress](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engine_construction_progress.html) siegeEngine) |
| int | [FindDeploymentIndexOfDeployedEngine](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html#a9bea137e2aea5fbe19292f52851dd38f) ([SiegeEngineConstructionProgress](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engine_construction_progress.html) deployedEngine) |
| bool | [ClearRemovedEnginesIfNecessary](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html#a4ca531440ef94245ec3649968da671f7) () |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly [SiegeEngineConstructionProgress](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engine_construction_progress.html) | [SiegePreparations](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html#af85231027872d000c62466cca52558c3) |
| readonly [SiegeEngineConstructionProgress](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engine_construction_progress.html)[] | [DeployedRangedSiegeEngines](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html#a1391cd5e32d2c4e1cb71be7214c9ca27) |
| readonly [SiegeEngineConstructionProgress](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engine_construction_progress.html)[] | [DeployedMeleeSiegeEngines](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html#a14ff677f72efe0c94597dd82285581bb) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const int | [MaximumAttackerMeleeSiegeEngineCount](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html#a66fe5d7eb342ae68e893a46d93474ca4) = 3 |
| const int | [MaximumAttackerRangedSiegeEngineCount](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html#a0285a9d1c0b607e742c076c57cef18c4) = 4 |
| const int | [MaximumDefenderMeleeSiegeEngineCount](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html#a186e57e9efe1547db47efd099242f142) = 0 |
| const int | [MaximumDefenderRangedSiegeEngineCount](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html#a7d2c38e248e93fb9737d00416c7f7e3f) = 4 |

|  |  |
| --- | --- |
| Properties | |
| MBReadOnlyList< [SiegeEngineConstructionProgress](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engine_construction_progress.html) > | [DeployedSiegeEngines](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html#a424b84c9db1049f85ab42dd070583524) `[get]` |
| MBReadOnlyList< [SiegeEngineConstructionProgress](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engine_construction_progress.html) > | [ReservedSiegeEngines](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html#ae830aca3c2a3edb94f2a8431f07c4443) `[get]` |
| MBReadOnlyDictionary< [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html), int > | [DeployedSiegeEngineTypesCount](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html#a4596b70a7d1f0035e31d379e66b0fc1d) `[get]` |
| MBReadOnlyDictionary< [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html), int > | [ReservedSiegeEngineTypesCount](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html#a9d05103736fe44bd8ff6ebe7fb383c22) `[get]` |
| MBReadOnlyList< [RemovedSiegeEngine](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container_1_1_removed_siege_engine.html) > | [RemovedSiegeEngines](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html#a08fa49cab82b3beff1d091eb9b447b74) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html#a1f6d0b375da236ced751833f943e0bd8)SiegeEnginesContainer()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Siege.SiegeEvent.SiegeEnginesContainer.SiegeEnginesContainer | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side*, |
|  |  | [SiegeEngineConstructionProgress](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engine_construction_progress.html) | *siegePreparations* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html#a51a4023feba86a30d6f3501a040172a4)AllSiegeEngines()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< [SiegeEngineConstructionProgress](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engine_construction_progress.html) > TaleWorlds.CampaignSystem.Siege.SiegeEvent.SiegeEnginesContainer.AllSiegeEngines | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html#adf373021876a02cb38b6fd4b07336300)AddPrebuiltEngineToReserve()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Siege.SiegeEvent.SiegeEnginesContainer.AddPrebuiltEngineToReserve | ( | [SiegeEngineConstructionProgress](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engine_construction_progress.html) | *siegeEngine* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html#a6efb9362f4cfcda28c64675a8219d3a8)DeploySiegeEngineAtIndex()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Siege.SiegeEvent.SiegeEnginesContainer.DeploySiegeEngineAtIndex | ( | [SiegeEngineConstructionProgress](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engine_construction_progress.html) | *siegeEngine*, |
|  |  | int | *index* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html#a3256cdd2bd4e941bbebc8199184b0949)RemoveDeployedSiegeEngine()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Siege.SiegeEvent.SiegeEnginesContainer.RemoveDeployedSiegeEngine | ( | int | *index*, |
|  |  | bool | *isRanged*, |
|  |  | bool | *moveToReserve* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html#af5484705590e71e60932a14b283fe681)RemovedSiegeEngineFromReservedSiegeEngines()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Siege.SiegeEvent.SiegeEnginesContainer.RemovedSiegeEngineFromReservedSiegeEngines | ( | [SiegeEngineConstructionProgress](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engine_construction_progress.html) | *siegeEngine* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html#a9bea137e2aea5fbe19292f52851dd38f)FindDeploymentIndexOfDeployedEngine()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Siege.SiegeEvent.SiegeEnginesContainer.FindDeploymentIndexOfDeployedEngine | ( | [SiegeEngineConstructionProgress](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engine_construction_progress.html) | *deployedEngine* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html#a4ca531440ef94245ec3649968da671f7)ClearRemovedEnginesIfNecessary()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Siege.SiegeEvent.SiegeEnginesContainer.ClearRemovedEnginesIfNecessary | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html#a66fe5d7eb342ae68e893a46d93474ca4)MaximumAttackerMeleeSiegeEngineCount
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.CampaignSystem.Siege.SiegeEvent.SiegeEnginesContainer.MaximumAttackerMeleeSiegeEngineCount = 3 | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html#a0285a9d1c0b607e742c076c57cef18c4)MaximumAttackerRangedSiegeEngineCount
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.CampaignSystem.Siege.SiegeEvent.SiegeEnginesContainer.MaximumAttackerRangedSiegeEngineCount = 4 | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html#a186e57e9efe1547db47efd099242f142)MaximumDefenderMeleeSiegeEngineCount
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.CampaignSystem.Siege.SiegeEvent.SiegeEnginesContainer.MaximumDefenderMeleeSiegeEngineCount = 0 | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html#a7d2c38e248e93fb9737d00416c7f7e3f)MaximumDefenderRangedSiegeEngineCount
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.CampaignSystem.Siege.SiegeEvent.SiegeEnginesContainer.MaximumDefenderRangedSiegeEngineCount = 4 | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html#af85231027872d000c62466cca52558c3)SiegePreparations
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [SiegeEngineConstructionProgress](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engine_construction_progress.html) TaleWorlds.CampaignSystem.Siege.SiegeEvent.SiegeEnginesContainer.SiegePreparations |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html#a1391cd5e32d2c4e1cb71be7214c9ca27)DeployedRangedSiegeEngines
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [SiegeEngineConstructionProgress](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engine_construction_progress.html) [] TaleWorlds.CampaignSystem.Siege.SiegeEvent.SiegeEnginesContainer.DeployedRangedSiegeEngines |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html#a14ff677f72efe0c94597dd82285581bb)DeployedMeleeSiegeEngines
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [SiegeEngineConstructionProgress](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engine_construction_progress.html) [] TaleWorlds.CampaignSystem.Siege.SiegeEvent.SiegeEnginesContainer.DeployedMeleeSiegeEngines |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html#a424b84c9db1049f85ab42dd070583524)DeployedSiegeEngines
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[SiegeEngineConstructionProgress](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engine_construction_progress.html)> TaleWorlds.CampaignSystem.Siege.SiegeEvent.SiegeEnginesContainer.DeployedSiegeEngines | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html#ae830aca3c2a3edb94f2a8431f07c4443)ReservedSiegeEngines
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[SiegeEngineConstructionProgress](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engine_construction_progress.html)> TaleWorlds.CampaignSystem.Siege.SiegeEvent.SiegeEnginesContainer.ReservedSiegeEngines | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html#a4596b70a7d1f0035e31d379e66b0fc1d)DeployedSiegeEngineTypesCount
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyDictionary<[SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html), int> TaleWorlds.CampaignSystem.Siege.SiegeEvent.SiegeEnginesContainer.DeployedSiegeEngineTypesCount | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html#a9d05103736fe44bd8ff6ebe7fb383c22)ReservedSiegeEngineTypesCount
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyDictionary<[SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html), int> TaleWorlds.CampaignSystem.Siege.SiegeEvent.SiegeEnginesContainer.ReservedSiegeEngineTypesCount | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html#a08fa49cab82b3beff1d091eb9b447b74)RemovedSiegeEngines
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[RemovedSiegeEngine](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container_1_1_removed_siege_engine.html)> TaleWorlds.CampaignSystem.Siege.SiegeEvent.SiegeEnginesContainer.RemovedSiegeEngines | | get |

