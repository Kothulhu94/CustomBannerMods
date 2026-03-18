--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_navigation_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultPartyNavigationModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.PartyNavigationModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_navigation_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override float | [GetEmbarkDisembarkThresholdDistance](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_navigation_model.html#a16dda0cc89c190b082bf04af383bfc61) () |
|  | [DefaultPartyNavigationModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_navigation_model.html#ab774d68df5327431a79cb4dfb2c3666a) () |
| override int[] | [GetInvalidTerrainTypesForNavigationType](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_navigation_model.html#afaef116095e94389bc90434e4cfb05c2) (NavigationType navigationType) |
| override bool | [IsTerrainTypeValidForNavigationType](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_navigation_model.html#a561f0aab9dd49dbe4958c9adafc543c1) ([TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) terrainType, NavigationType navigationType) |
| override bool | [HasNavalNavigationCapability](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_navigation_model.html#a00e24178639d0471dfd57c083cb4df4e) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| override bool | [CanPlayerNavigateToPosition](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_navigation_model.html#a4ff8b3bef0562d5037fd40d0333ef971) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) vec2, out NavigationType navigationType) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.PartyNavigationModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_navigation_model.html) | |
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

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_navigation_model.html#ab774d68df5327431a79cb4dfb2c3666a)DefaultPartyNavigationModel()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.GameComponents.DefaultPartyNavigationModel.DefaultPartyNavigationModel | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_navigation_model.html#a16dda0cc89c190b082bf04af383bfc61)GetEmbarkDisembarkThresholdDistance()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultPartyNavigationModel.GetEmbarkDisembarkThresholdDistance | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_navigation_model.html#afaef116095e94389bc90434e4cfb05c2)GetInvalidTerrainTypesForNavigationType()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int[] TaleWorlds.CampaignSystem.GameComponents.DefaultPartyNavigationModel.GetInvalidTerrainTypesForNavigationType | ( | NavigationType | *navigationType* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_navigation_model.html#a561f0aab9dd49dbe4958c9adafc543c1)IsTerrainTypeValidForNavigationType()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultPartyNavigationModel.IsTerrainTypeValidForNavigationType | ( | [TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) | *terrainType*, |
|  |  | NavigationType | *navigationType* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_navigation_model.html#a00e24178639d0471dfd57c083cb4df4e)HasNavalNavigationCapability()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultPartyNavigationModel.HasNavalNavigationCapability | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_navigation_model.html#a4ff8b3bef0562d5037fd40d0333ef971)CanPlayerNavigateToPosition()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultPartyNavigationModel.CanPlayerNavigateToPosition | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *vec2*, |
|  |  | out NavigationType | *navigationType* ) |

