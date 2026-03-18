--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_delayed_teleportation_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultDelayedTeleportationModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.DelayedTeleportationModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_delayed_teleportation_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetTeleportationDelayAsHours](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_delayed_teleportation_model.html#ac09ecd74bdd16d2181ab10779a1df3a6) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) teleportingHero, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) target) |
| override bool | [CanPerformImmediateTeleport](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_delayed_teleportation_model.html#a4db35ca2323c1d2f893a4968e36eb05a) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) targetMobileParty, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) targetSettlement) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.DelayedTeleportationModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_delayed_teleportation_model.html) | |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetTeleportationDelayAsHours](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_delayed_teleportation_model.html#ab8fab8b7e1601794e08152a0dec573e1) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) teleportingHero, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) target) |
| bool | [CanPerformImmediateTeleport](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_delayed_teleportation_model.html#a0f9874dff727c651a023504760c09dbf) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) targetMobileParty, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) targetSettlement) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| override float | [DefaultTeleportationSpeed](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_delayed_teleportation_model.html#a9992ca63bd2b4e98b03081ecf6182e2f) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.DelayedTeleportationModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_delayed_teleportation_model.html) | |
| float | [DefaultTeleportationSpeed](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_delayed_teleportation_model.html#a02b7612dbbfb9ef8bd4eaf7e7247b08a) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_delayed_teleportation_model.html#ac09ecd74bdd16d2181ab10779a1df3a6)GetTeleportationDelayAsHours()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultDelayedTeleportationModel.GetTeleportationDelayAsHours | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *teleportingHero*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *target* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_delayed_teleportation_model.html#a4db35ca2323c1d2f893a4968e36eb05a)CanPerformImmediateTeleport()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultDelayedTeleportationModel.CanPerformImmediateTeleport | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *targetMobileParty*, |
|  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *targetSettlement* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_delayed_teleportation_model.html#a9992ca63bd2b4e98b03081ecf6182e2f)DefaultTeleportationSpeed
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultDelayedTeleportationModel.DefaultTeleportationSpeed | | get |

