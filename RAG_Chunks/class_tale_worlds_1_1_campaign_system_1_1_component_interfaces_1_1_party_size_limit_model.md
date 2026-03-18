--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_size_limit_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.PartySizeLimitModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [StoryMode.GameComponents.StoryModePartySizeLimitModel](class_story_mode_1_1_game_components_1_1_story_mode_party_size_limit_model.html), and [TaleWorlds.CampaignSystem.GameComponents.DefaultPartySizeLimitModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_size_limit_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetPartyMemberSizeLimit](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_size_limit_model.html#a03487d689c1d0ea375503b17a6e7d0c5) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, bool includeDescriptions=false) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetPartyPrisonerSizeLimit](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_size_limit_model.html#ac79317b49aa30294776be91685112626) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, bool includeDescriptions=false) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateGarrisonPartySizeLimit](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_size_limit_model.html#ae1f25a034db37729b0b4eac8afaa4c12) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, bool includeDescriptions=false) |
| int | [GetClanTierPartySizeEffectForHero](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_size_limit_model.html#a929297c08ae17c294a6913e99c3ee6ae) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| int | [GetNextClanTierPartySizeEffectChangeForHero](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_size_limit_model.html#acf9745dac5bb625cae16149bf36062f6) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| int | [GetAssumedPartySizeForLordParty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_size_limit_model.html#a722d2db75e3cf8b499a0c4ac9d28d5cd) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) leaderHero, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) partyMapFaction, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) actualClan) |
| int | [GetIdealVillagerPartySize](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_size_limit_model.html#a4971874f1d7c3c8b5e3c13ba9ea1035f) ([Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) village) |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | [FindAppropriateInitialRosterForMobileParty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_size_limit_model.html#af2910a347826c207ffa6db66e2e2ad80) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) partyTemplate) |
| List< [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) > | [FindAppropriateInitialShipsForMobileParty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_size_limit_model.html#a408619e02eccd654aa09a369d96d0191) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) partyTemplate) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| int | [MinimumNumberOfVillagersAtVillagerParty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_size_limit_model.html#acbca50103f00fb276c63646c9159a5fa) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_size_limit_model.html#a03487d689c1d0ea375503b17a6e7d0c5)GetPartyMemberSizeLimit()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.PartySizeLimitModel.GetPartyMemberSizeLimit | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, | |  |  | bool | *includeDescriptions* = false ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_size_limit_model.html#ac79317b49aa30294776be91685112626)GetPartyPrisonerSizeLimit()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.PartySizeLimitModel.GetPartyPrisonerSizeLimit | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, | |  |  | bool | *includeDescriptions* = false ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_size_limit_model.html#ae1f25a034db37729b0b4eac8afaa4c12)CalculateGarrisonPartySizeLimit()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.PartySizeLimitModel.CalculateGarrisonPartySizeLimit | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | bool | *includeDescriptions* = false ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_size_limit_model.html#a929297c08ae17c294a6913e99c3ee6ae)GetClanTierPartySizeEffectForHero()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.PartySizeLimitModel.GetClanTierPartySizeEffectForHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_size_limit_model.html#acf9745dac5bb625cae16149bf36062f6)GetNextClanTierPartySizeEffectChangeForHero()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.PartySizeLimitModel.GetNextClanTierPartySizeEffectChangeForHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_size_limit_model.html#a722d2db75e3cf8b499a0c4ac9d28d5cd)GetAssumedPartySizeForLordParty()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.PartySizeLimitModel.GetAssumedPartySizeForLordParty | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *leaderHero*, | |  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *partyMapFaction*, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *actualClan* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_size_limit_model.html#a4971874f1d7c3c8b5e3c13ba9ea1035f)GetIdealVillagerPartySize()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.PartySizeLimitModel.GetIdealVillagerPartySize | ( | [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) | *village* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_size_limit_model.html#af2910a347826c207ffa6db66e2e2ad80)FindAppropriateInitialRosterForMobileParty()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) TaleWorlds.CampaignSystem.ComponentInterfaces.PartySizeLimitModel.FindAppropriateInitialRosterForMobileParty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) | *partyTemplate* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_size_limit_model.html#a408619e02eccd654aa09a369d96d0191)FindAppropriateInitialShipsForMobileParty()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | List< [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) > TaleWorlds.CampaignSystem.ComponentInterfaces.PartySizeLimitModel.FindAppropriateInitialShipsForMobileParty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) | *partyTemplate* ) | | abstract |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_size_limit_model.html#acbca50103f00fb276c63646c9159a5fa)MinimumNumberOfVillagersAtVillagerParty
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.PartySizeLimitModel.MinimumNumberOfVillagersAtVillagerParty | | getabstract |

