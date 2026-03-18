--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component_1_1_initialization_args.html ---

TaleWorlds.CampaignSystem.Party.PartyComponents.CustomPartyComponent.InitializationArgs Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [InitializationArgs](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component_1_1_initialization_args.html#ab79e032b54d45db9c2aebf8adbdc777a) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) position, float spawnRadius, [Clan](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component_1_1_initialization_args.html#a346923d733b3722e4cfe95369a0674ff) clan, [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) partyTemplate) |
|  | [InitializationArgs](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component_1_1_initialization_args.html#a9dff6330489381c259a32ae88e295ed8) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) position, float spawnRadius, [Clan](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component_1_1_initialization_args.html#a346923d733b3722e4cfe95369a0674ff) clan, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component_1_1_initialization_args.html#afa95f178a814d40cfa7fb59c54a9c724) troopRoster, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component_1_1_initialization_args.html#afa95f178a814d40cfa7fb59c54a9c724) prisonerRoster) |
| void | [InitializeCustomPartyPropertiesWithPartyTemplate](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component_1_1_initialization_args.html#a9ee9eb03217bc699c3c20919be9ff650) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad5cbd620a7b099133277449ef021ba32) mobileParty) |
| void | [InitializeCustomPartyPropertiesWithTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component_1_1_initialization_args.html#a51299b99e34df236dabe606307dfdfef) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad5cbd620a7b099133277449ef021ba32) mobileParty) |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | [Position](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component_1_1_initialization_args.html#a9642375d5a03b68ccb98e1e80cf28627) |
| readonly float | [SpawnRadius](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component_1_1_initialization_args.html#adc49c0d5d33eb7f137516d200828710a) |
| readonly Clan | [Clan](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component_1_1_initialization_args.html#a346923d733b3722e4cfe95369a0674ff) |
| readonly TroopRoster | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component_1_1_initialization_args.html#afa95f178a814d40cfa7fb59c54a9c724) |
| readonly [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component_1_1_initialization_args.html#afa95f178a814d40cfa7fb59c54a9c724) | [PrisonerRoster](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component_1_1_initialization_args.html#a0675fd5bc4ea2aff14bb8797831c347f) |
| readonly [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) | [PartyTemplate](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component_1_1_initialization_args.html#aa4c99ed294b9157f4f3e47d6000682c4) |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsCreatedWithPartyTemplate](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component_1_1_initialization_args.html#a859bf4e6640d1b0af9c86553dd7f16ed) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component_1_1_initialization_args.html#ab79e032b54d45db9c2aebf8adbdc777a)InitializationArgs() [1/2]
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Party.PartyComponents.CustomPartyComponent.InitializationArgs.InitializationArgs | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *position*, |
|  |  | float | *spawnRadius*, |
|  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component_1_1_initialization_args.html#a346923d733b3722e4cfe95369a0674ff) | *clan*, |
|  |  | [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) | *partyTemplate* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component_1_1_initialization_args.html#a9dff6330489381c259a32ae88e295ed8)InitializationArgs() [2/2]
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Party.PartyComponents.CustomPartyComponent.InitializationArgs.InitializationArgs | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *position*, |
|  |  | float | *spawnRadius*, |
|  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component_1_1_initialization_args.html#a346923d733b3722e4cfe95369a0674ff) | *clan*, |
|  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component_1_1_initialization_args.html#afa95f178a814d40cfa7fb59c54a9c724) | *troopRoster*, |
|  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component_1_1_initialization_args.html#afa95f178a814d40cfa7fb59c54a9c724) | *prisonerRoster* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component_1_1_initialization_args.html#a9ee9eb03217bc699c3c20919be9ff650)InitializeCustomPartyPropertiesWithPartyTemplate()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.PartyComponents.CustomPartyComponent.InitializationArgs.InitializeCustomPartyPropertiesWithPartyTemplate | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad5cbd620a7b099133277449ef021ba32) | *mobileParty* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component_1_1_initialization_args.html#a51299b99e34df236dabe606307dfdfef)InitializeCustomPartyPropertiesWithTroopRoster()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.PartyComponents.CustomPartyComponent.InitializationArgs.InitializeCustomPartyPropertiesWithTroopRoster | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad5cbd620a7b099133277449ef021ba32) | *mobileParty* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component_1_1_initialization_args.html#a9642375d5a03b68ccb98e1e80cf28627)Position
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) TaleWorlds.CampaignSystem.Party.PartyComponents.CustomPartyComponent.InitializationArgs.Position |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component_1_1_initialization_args.html#adc49c0d5d33eb7f137516d200828710a)SpawnRadius
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly float TaleWorlds.CampaignSystem.Party.PartyComponents.CustomPartyComponent.InitializationArgs.SpawnRadius |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component_1_1_initialization_args.html#a346923d733b3722e4cfe95369a0674ff)Clan
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly Clan TaleWorlds.CampaignSystem.Party.PartyComponents.CustomPartyComponent.InitializationArgs.Clan |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component_1_1_initialization_args.html#afa95f178a814d40cfa7fb59c54a9c724)TroopRoster
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly TroopRoster TaleWorlds.CampaignSystem.Party.PartyComponents.CustomPartyComponent.InitializationArgs.TroopRoster |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component_1_1_initialization_args.html#a0675fd5bc4ea2aff14bb8797831c347f)PrisonerRoster
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component_1_1_initialization_args.html#afa95f178a814d40cfa7fb59c54a9c724) TaleWorlds.CampaignSystem.Party.PartyComponents.CustomPartyComponent.InitializationArgs.PrisonerRoster |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component_1_1_initialization_args.html#aa4c99ed294b9157f4f3e47d6000682c4)PartyTemplate
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) TaleWorlds.CampaignSystem.Party.PartyComponents.CustomPartyComponent.InitializationArgs.PartyTemplate |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component_1_1_initialization_args.html#a859bf4e6640d1b0af9c86553dd7f16ed)IsCreatedWithPartyTemplate
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.PartyComponents.CustomPartyComponent.InitializationArgs.IsCreatedWithPartyTemplate | | get |

