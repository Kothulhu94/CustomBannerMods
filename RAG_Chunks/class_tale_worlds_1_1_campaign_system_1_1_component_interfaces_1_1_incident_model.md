--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_incident_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.IncidentModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [StoryMode.GameComponents.StoryModeIncidentModel](class_story_mode_1_1_game_components_1_1_story_mode_incident_model.html), and [TaleWorlds.CampaignSystem.GameComponents.DefaultIncidentModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_incident_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [GetMinGlobalCooldownTime](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_incident_model.html#a3211d4d4eda527e12ee8c154fe283a80) () |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [GetMaxGlobalCooldownTime](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_incident_model.html#a554930a79e46eac32c54a208fbdfca5e) () |
| float | [GetIncidentTriggerGlobalProbability](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_incident_model.html#a7eec7be9d959670b9269bc25fae2fc71) () |
| float | [GetIncidentTriggerProbabilityDuringSiege](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_incident_model.html#acf6aa3ea8aab8d0e0dee4ff858359ea7) () |
| float | [GetIncidentTriggerProbabilityDuringWait](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_incident_model.html#abd8a2b780b3497a39d19f6e9afad4021) () |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_incident_model.html#a3211d4d4eda527e12ee8c154fe283a80)GetMinGlobalCooldownTime()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.ComponentInterfaces.IncidentModel.GetMinGlobalCooldownTime | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_incident_model.html#a554930a79e46eac32c54a208fbdfca5e)GetMaxGlobalCooldownTime()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.ComponentInterfaces.IncidentModel.GetMaxGlobalCooldownTime | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_incident_model.html#a7eec7be9d959670b9269bc25fae2fc71)GetIncidentTriggerGlobalProbability()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.IncidentModel.GetIncidentTriggerGlobalProbability | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_incident_model.html#acf6aa3ea8aab8d0e0dee4ff858359ea7)GetIncidentTriggerProbabilityDuringSiege()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.IncidentModel.GetIncidentTriggerProbabilityDuringSiege | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_incident_model.html#abd8a2b780b3497a39d19f6e9afad4021)GetIncidentTriggerProbabilityDuringWait()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.IncidentModel.GetIncidentTriggerProbabilityDuringWait | ( |  | ) |  | | abstract |

