--- SOURCE: interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_teleportation_campaign_behavior.html ---

TaleWorlds.CampaignSystem.CampaignBehaviors.ITeleportationCampaignBehavior Interface ReferenceInherits [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html).

Inherited by [TaleWorlds.CampaignSystem.CampaignBehaviors.TeleportationCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_teleportation_campaign_behavior.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| bool | [GetTargetOfTeleportingHero](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_teleportation_campaign_behavior.html#a10c84441327696fb4dbe151fba0ca370) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) teleportingHero, out bool isGovernor, out bool isPartyLeader, out [IMapPoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html) target) |
|  | Returns if a hero is teleporting with teleportation data. |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [GetHeroArrivalTimeToDestination](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_teleportation_campaign_behavior.html#a67b3178036aa7f7cbcb63a3b66454f0a) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) teleportingHero) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html) | |
| void | [RegisterEvents](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522) () |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_teleportation_campaign_behavior.html#a10c84441327696fb4dbe151fba0ca370)GetTargetOfTeleportingHero()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CampaignBehaviors.ITeleportationCampaignBehavior.GetTargetOfTeleportingHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *teleportingHero*, |
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

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.TeleportationCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_teleportation_campaign_behavior.html#a7ee27b0a9b862824f98de526fca52ddd).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_teleportation_campaign_behavior.html#a67b3178036aa7f7cbcb63a3b66454f0a)GetHeroArrivalTimeToDestination()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.CampaignBehaviors.ITeleportationCampaignBehavior.GetHeroArrivalTimeToDestination | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *teleportingHero* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.TeleportationCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_teleportation_campaign_behavior.html#af26a12ef4b091887c9f7c41c963b056c).

