--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_size_limit_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultPartySizeLimitModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.PartySizeLimitModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_size_limit_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [DefaultPartySizeLimitModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_size_limit_model.html#aded355aa631533c29e7de87f5121a003) () |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetPartyMemberSizeLimit](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_size_limit_model.html#a9f0d3c22cfd5e5a6699e41f3f2ef83a8) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, bool includeDescriptions=false) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetPartyPrisonerSizeLimit](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_size_limit_model.html#aaace0a452329395644e4574257972225) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, bool includeDescriptions=false) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateGarrisonPartySizeLimit](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_size_limit_model.html#ae68f08c4b47f19ce8fe4f68a6d6a2077) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, bool includeDescriptions=false) |
| override int | [GetNextClanTierPartySizeEffectChangeForHero](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_size_limit_model.html#ad148d1cefd9051ab7017fa4c04666171) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override int | [GetAssumedPartySizeForLordParty](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_size_limit_model.html#a47ec4ecf9e6ad27d079e3ea18d525da2) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) leaderHero, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) partyMapFaction, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) actualClan) |
| override int | [GetClanTierPartySizeEffectForHero](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_size_limit_model.html#a79830ba9b507b088057ffdf1d144ad17) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override int | [GetIdealVillagerPartySize](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_size_limit_model.html#a44e3fc667e916646ed5f36abebb5bfbb) ([Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) village) |
| override [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | [FindAppropriateInitialRosterForMobileParty](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_size_limit_model.html#a63c7c7db3f7dc2a246f6d7ba8d662ea3) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) partyTemplate) |
| override List< [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) > | [FindAppropriateInitialShipsForMobileParty](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_size_limit_model.html#a00fbd870584607bd4f21f918e85456aa) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) partyTemplate) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.PartySizeLimitModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_size_limit_model.html) | |
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
| override int | [MinimumNumberOfVillagersAtVillagerParty](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_size_limit_model.html#a922a59031d8c86bd0a7d7335c9519feb) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.PartySizeLimitModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_size_limit_model.html) | |
| int | [MinimumNumberOfVillagersAtVillagerParty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_size_limit_model.html#acbca50103f00fb276c63646c9159a5fa) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_size_limit_model.html#aded355aa631533c29e7de87f5121a003)DefaultPartySizeLimitModel()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.GameComponents.DefaultPartySizeLimitModel.DefaultPartySizeLimitModel | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_size_limit_model.html#a9f0d3c22cfd5e5a6699e41f3f2ef83a8)GetPartyMemberSizeLimit()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultPartySizeLimitModel.GetPartyMemberSizeLimit | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, |
|  |  | bool | *includeDescriptions* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_size_limit_model.html#aaace0a452329395644e4574257972225)GetPartyPrisonerSizeLimit()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultPartySizeLimitModel.GetPartyPrisonerSizeLimit | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, |
|  |  | bool | *includeDescriptions* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_size_limit_model.html#ae68f08c4b47f19ce8fe4f68a6d6a2077)CalculateGarrisonPartySizeLimit()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultPartySizeLimitModel.CalculateGarrisonPartySizeLimit | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | bool | *includeDescriptions* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_size_limit_model.html#ad148d1cefd9051ab7017fa4c04666171)GetNextClanTierPartySizeEffectChangeForHero()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultPartySizeLimitModel.GetNextClanTierPartySizeEffectChangeForHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_size_limit_model.html#a47ec4ecf9e6ad27d079e3ea18d525da2)GetAssumedPartySizeForLordParty()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultPartySizeLimitModel.GetAssumedPartySizeForLordParty | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *leaderHero*, |
|  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *partyMapFaction*, |
|  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *actualClan* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_size_limit_model.html#a79830ba9b507b088057ffdf1d144ad17)GetClanTierPartySizeEffectForHero()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultPartySizeLimitModel.GetClanTierPartySizeEffectForHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_size_limit_model.html#a44e3fc667e916646ed5f36abebb5bfbb)GetIdealVillagerPartySize()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultPartySizeLimitModel.GetIdealVillagerPartySize | ( | [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) | *village* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_size_limit_model.html#a63c7c7db3f7dc2a246f6d7ba8d662ea3)FindAppropriateInitialRosterForMobileParty()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) TaleWorlds.CampaignSystem.GameComponents.DefaultPartySizeLimitModel.FindAppropriateInitialRosterForMobileParty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, |
|  |  | [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) | *partyTemplate* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_size_limit_model.html#a00fbd870584607bd4f21f918e85456aa)FindAppropriateInitialShipsForMobileParty()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override List< [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) > TaleWorlds.CampaignSystem.GameComponents.DefaultPartySizeLimitModel.FindAppropriateInitialShipsForMobileParty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, |
|  |  | [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) | *partyTemplate* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_size_limit_model.html#a922a59031d8c86bd0a7d7335c9519feb)MinimumNumberOfVillagersAtVillagerParty
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultPartySizeLimitModel.MinimumNumberOfVillagersAtVillagerParty | | get |

