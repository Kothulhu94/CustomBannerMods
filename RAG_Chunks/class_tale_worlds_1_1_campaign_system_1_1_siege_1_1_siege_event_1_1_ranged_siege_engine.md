--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_ranged_siege_engine.html ---

TaleWorlds.CampaignSystem.Siege.SiegeEvent.RangedSiegeEngine Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [RangedSiegeEngine](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_ranged_siege_engine.html#af57ec6dc8466f5caef58f253f55549fe) ([SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) engineType, [ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html) siegeSide) |
| void | [Hold](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_ranged_siege_engine.html#a3a19c3598dc66d2cd0720142cb021f77) () |
| void | [Reload](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_ranged_siege_engine.html#a3f6a79e407286a751f008ebc4a4f92fe) () |
| void | [OnFireDecisionTaken](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_ranged_siege_engine.html#a4561860e9ea9be2ad5c17bf4c16ee745) ([SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#a720bf52bf173c646e724fce033925507) siegeEvent, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) battleSide, int targetSlotIndex, [SiegeBombardTargets](namespace_tale_worlds_1_1_campaign_system_1_1_siege.html#acf175cba0ae0d92d36103f5606dda4f6) targetType) |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | [EngineType](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_ranged_siege_engine.html#a3a00b1086f42df1624011e60e09d19b2) |

|  |  |
| --- | --- |
| Properties | |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [NextTimeEngineCanBombard](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_ranged_siege_engine.html#a9ac57e5e0a7e64144bb9311d380baec7) `[get]` |
| bool | [AlreadyFired](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_ranged_siege_engine.html#a10a6e7d66c7c26886f2eda2e1b0f6383) `[get]` |
| [SiegeBombardTargets](namespace_tale_worlds_1_1_campaign_system_1_1_siege.html#acf175cba0ae0d92d36103f5606dda4f6) | [CurrentTargetType](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_ranged_siege_engine.html#a0855ed1931ef3c15436b617d0d5565c3) `[get]` |
| int | [CurrentTargetIndex](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_ranged_siege_engine.html#a69e24905f395b75c786f33d019016bcf) `[get]` |
| [SiegeBombardTargets](namespace_tale_worlds_1_1_campaign_system_1_1_siege.html#acf175cba0ae0d92d36103f5606dda4f6) | [PreviousDamagedTargetType](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_ranged_siege_engine.html#a70a59927cf1de43eeac7285a1215d9bf) `[get]` |
| int | [PreviousTargetIndex](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_ranged_siege_engine.html#a1684136ff851a353617ae21437110131) `[get]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [LastBombardTime](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_ranged_siege_engine.html#a5cf63d2b234a185c4dea5ad84d8692f1) `[get]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [NextProjectileCollisionTime](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_ranged_siege_engine.html#ae482e0bec5135bd45680463f2b1d0d77) `[get]` |
| bool | [IsReadyToFire](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_ranged_siege_engine.html#a75f7021de43c7793240426269b1253e1) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_ranged_siege_engine.html#af57ec6dc8466f5caef58f253f55549fe)RangedSiegeEngine()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Siege.SiegeEvent.RangedSiegeEngine.RangedSiegeEngine | ( | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *engineType*, |
|  |  | [ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html) | *siegeSide* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_ranged_siege_engine.html#a3a19c3598dc66d2cd0720142cb021f77)Hold()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Siege.SiegeEvent.RangedSiegeEngine.Hold | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_ranged_siege_engine.html#a3f6a79e407286a751f008ebc4a4f92fe)Reload()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Siege.SiegeEvent.RangedSiegeEngine.Reload | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_ranged_siege_engine.html#a4561860e9ea9be2ad5c17bf4c16ee745)OnFireDecisionTaken()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Siege.SiegeEvent.RangedSiegeEngine.OnFireDecisionTaken | ( | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#a720bf52bf173c646e724fce033925507) | *siegeEvent*, |
|  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *battleSide*, |
|  |  | int | *targetSlotIndex*, |
|  |  | [SiegeBombardTargets](namespace_tale_worlds_1_1_campaign_system_1_1_siege.html#acf175cba0ae0d92d36103f5606dda4f6) | *targetType* ) |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_ranged_siege_engine.html#a3a00b1086f42df1624011e60e09d19b2)EngineType
---------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) TaleWorlds.CampaignSystem.Siege.SiegeEvent.RangedSiegeEngine.EngineType |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_ranged_siege_engine.html#a9ac57e5e0a7e64144bb9311d380baec7)NextTimeEngineCanBombard
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.Siege.SiegeEvent.RangedSiegeEngine.NextTimeEngineCanBombard | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_ranged_siege_engine.html#a10a6e7d66c7c26886f2eda2e1b0f6383)AlreadyFired
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Siege.SiegeEvent.RangedSiegeEngine.AlreadyFired | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_ranged_siege_engine.html#a0855ed1931ef3c15436b617d0d5565c3)CurrentTargetType
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SiegeBombardTargets](namespace_tale_worlds_1_1_campaign_system_1_1_siege.html#acf175cba0ae0d92d36103f5606dda4f6) TaleWorlds.CampaignSystem.Siege.SiegeEvent.RangedSiegeEngine.CurrentTargetType | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_ranged_siege_engine.html#a69e24905f395b75c786f33d019016bcf)CurrentTargetIndex
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Siege.SiegeEvent.RangedSiegeEngine.CurrentTargetIndex | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_ranged_siege_engine.html#a70a59927cf1de43eeac7285a1215d9bf)PreviousDamagedTargetType
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SiegeBombardTargets](namespace_tale_worlds_1_1_campaign_system_1_1_siege.html#acf175cba0ae0d92d36103f5606dda4f6) TaleWorlds.CampaignSystem.Siege.SiegeEvent.RangedSiegeEngine.PreviousDamagedTargetType | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_ranged_siege_engine.html#a1684136ff851a353617ae21437110131)PreviousTargetIndex
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Siege.SiegeEvent.RangedSiegeEngine.PreviousTargetIndex | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_ranged_siege_engine.html#a5cf63d2b234a185c4dea5ad84d8692f1)LastBombardTime
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.Siege.SiegeEvent.RangedSiegeEngine.LastBombardTime | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_ranged_siege_engine.html#ae482e0bec5135bd45680463f2b1d0d77)NextProjectileCollisionTime
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.Siege.SiegeEvent.RangedSiegeEngine.NextProjectileCollisionTime | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_ranged_siege_engine.html#a75f7021de43c7793240426269b1253e1)IsReadyToFire
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Siege.SiegeEvent.RangedSiegeEngine.IsReadyToFire | | get |

