--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_teleportation_campaign_behavior.html ---

TaleWorlds.CampaignSystem.CampaignBehaviors.TeleportationCampaignBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html), and [TaleWorlds.CampaignSystem.CampaignBehaviors.ITeleportationCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_teleportation_campaign_behavior.html).

|  |  |
| --- | --- |
| Classes | |
| class | [TeleportationCampaignBehaviorTypeDefiner](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_teleportation_campaign_behavior814c2f2df7890f3c71e1ef01bf83ea8b.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_teleportation_campaign_behavior.html#ac0879407fe86b01bb8e1674ae31046e6) () |
| override void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_teleportation_campaign_behavior.html#a9f21cde98292d04377cfbdcd75d43217) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| bool | [GetTargetOfTeleportingHero](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_teleportation_campaign_behavior.html#a7ee27b0a9b862824f98de526fca52ddd) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) teleportingHero, out bool isGovernor, out bool isPartyLeader, out [IMapPoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html) target) |
|  | Returns if a hero is teleporting with teleportation data. |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [GetHeroArrivalTimeToDestination](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_teleportation_campaign_behavior.html#af26a12ef4b091887c9f7c41c963b056c) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) teleportingHero) |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_teleportation_campaign_behavior.html#ac0879407fe86b01bb8e1674ae31046e6)RegisterEvents()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.TeleportationCampaignBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_teleportation_campaign_behavior.html#a9f21cde98292d04377cfbdcd75d43217)SyncData()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.TeleportationCampaignBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_teleportation_campaign_behavior.html#a7ee27b0a9b862824f98de526fca52ddd)GetTargetOfTeleportingHero()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CampaignBehaviors.TeleportationCampaignBehavior.GetTargetOfTeleportingHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *teleportingHero*, |
|  |  | out bool | *isGovernor*, |
|  |  | out bool | *isPartyLeader*, |
|  |  | out [IMapPoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html) | *target* ) |

Parameters
:   |  |  |
    | --- | --- |
    | teleportingHero |  |
    | isGovernor |  |
    | isPartyLeader |  |
    | target |  |

Returns

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.ITeleportationCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_teleportation_campaign_behavior.html#a10c84441327696fb4dbe151fba0ca370).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_teleportation_campaign_behavior.html#af26a12ef4b091887c9f7c41c963b056c)GetHeroArrivalTimeToDestination()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.CampaignBehaviors.TeleportationCampaignBehavior.GetHeroArrivalTimeToDestination | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *teleportingHero* | ) |  |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.ITeleportationCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_teleportation_campaign_behavior.html#a67b3178036aa7f7cbcb63a3b66454f0a).

