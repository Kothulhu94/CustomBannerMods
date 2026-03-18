--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_navigation_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.PartyNavigationModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultPartyNavigationModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_navigation_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| bool | [CanPlayerNavigateToPosition](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_navigation_model.html#ae9883fd85150744851e4d89272d06deb) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) vec2, out NavigationType navigationType) |
| float | [GetEmbarkDisembarkThresholdDistance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_navigation_model.html#a8df95afbd3cfade76041715d6bdce968) () |
| bool | [IsTerrainTypeValidForNavigationType](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_navigation_model.html#ac03ac55bf3b417599d97aca4b805fc29) ([TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) terrainType, NavigationType navigationType) |
| int[] | [GetInvalidTerrainTypesForNavigationType](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_navigation_model.html#a5870efef8ed829c434aa11afe4a1434b) (NavigationType navigationType) |
| bool | [HasNavalNavigationCapability](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_navigation_model.html#a67444cf4a2db6a9f525d670b3d11c806) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_navigation_model.html#ae9883fd85150744851e4d89272d06deb)CanPlayerNavigateToPosition()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.PartyNavigationModel.CanPlayerNavigateToPosition | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *vec2*, | |  |  | out NavigationType | *navigationType* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_navigation_model.html#a8df95afbd3cfade76041715d6bdce968)GetEmbarkDisembarkThresholdDistance()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.PartyNavigationModel.GetEmbarkDisembarkThresholdDistance | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_navigation_model.html#ac03ac55bf3b417599d97aca4b805fc29)IsTerrainTypeValidForNavigationType()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.PartyNavigationModel.IsTerrainTypeValidForNavigationType | ( | [TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) | *terrainType*, | |  |  | NavigationType | *navigationType* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_navigation_model.html#a5870efef8ed829c434aa11afe4a1434b)GetInvalidTerrainTypesForNavigationType()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int[] TaleWorlds.CampaignSystem.ComponentInterfaces.PartyNavigationModel.GetInvalidTerrainTypesForNavigationType | ( | NavigationType | *navigationType* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_navigation_model.html#a67444cf4a2db6a9f525d670b3d11c806)HasNavalNavigationCapability()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.PartyNavigationModel.HasNavalNavigationCapability | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | abstract |

