--- SOURCE: class_story_mode_1_1_game_components_1_1_story_mode_party_size_limit_model.html ---

StoryMode.GameComponents.StoryModePartySizeLimitModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.PartySizeLimitModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_size_limit_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateGarrisonPartySizeLimit](class_story_mode_1_1_game_components_1_1_story_mode_party_size_limit_model.html#ad296d9157463dab250544fcd9cbbc056) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, bool includeDescriptions=false) |
| override [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | [FindAppropriateInitialRosterForMobileParty](class_story_mode_1_1_game_components_1_1_story_mode_party_size_limit_model.html#a4ee086b254e9e846e6a0aa4d1006880c) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) partyTemplate) |
| override List< [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) > | [FindAppropriateInitialShipsForMobileParty](class_story_mode_1_1_game_components_1_1_story_mode_party_size_limit_model.html#a3ede6f837fe43b22f8f25be05e854e78) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) partyTemplate) |
| override int | [GetAssumedPartySizeForLordParty](class_story_mode_1_1_game_components_1_1_story_mode_party_size_limit_model.html#a308309bffcc6f85159c42b4a3b09bc06) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) leaderHero, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) partyMapFaction, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) actualClan) |
| override int | [GetClanTierPartySizeEffectForHero](class_story_mode_1_1_game_components_1_1_story_mode_party_size_limit_model.html#aef162785f49b16020007b24de051eecc) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override int | [GetIdealVillagerPartySize](class_story_mode_1_1_game_components_1_1_story_mode_party_size_limit_model.html#a2e43272eab20cf7aa2e92b473871344a) ([Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) village) |
| override int | [GetNextClanTierPartySizeEffectChangeForHero](class_story_mode_1_1_game_components_1_1_story_mode_party_size_limit_model.html#a74b09579d143ac49332945150bd13495) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetPartyMemberSizeLimit](class_story_mode_1_1_game_components_1_1_story_mode_party_size_limit_model.html#ac5bec228f5f2967a0bf814c34ba16d7a) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, bool includeDescriptions=false) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetPartyPrisonerSizeLimit](class_story_mode_1_1_game_components_1_1_story_mode_party_size_limit_model.html#af07c3e0621055a22d8ab9ee79ee3a934) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, bool includeDescriptions=false) |
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
| override int | [MinimumNumberOfVillagersAtVillagerParty](class_story_mode_1_1_game_components_1_1_story_mode_party_size_limit_model.html#a05ccea1466176431df815b8f2d3ac871) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.PartySizeLimitModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_size_limit_model.html) | |
| int | [MinimumNumberOfVillagersAtVillagerParty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_size_limit_model.html#acbca50103f00fb276c63646c9159a5fa) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_story_mode_1_1_game_components_1_1_story_mode_party_size_limit_model.html#ad296d9157463dab250544fcd9cbbc056)CalculateGarrisonPartySizeLimit()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) StoryMode.GameComponents.StoryModePartySizeLimitModel.CalculateGarrisonPartySizeLimit | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | bool | *includeDescriptions* = false ) |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_party_size_limit_model.html#a4ee086b254e9e846e6a0aa4d1006880c)FindAppropriateInitialRosterForMobileParty()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) StoryMode.GameComponents.StoryModePartySizeLimitModel.FindAppropriateInitialRosterForMobileParty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, |
|  |  | [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) | *partyTemplate* ) |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_party_size_limit_model.html#a3ede6f837fe43b22f8f25be05e854e78)FindAppropriateInitialShipsForMobileParty()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override List< [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) > StoryMode.GameComponents.StoryModePartySizeLimitModel.FindAppropriateInitialShipsForMobileParty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, |
|  |  | [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) | *partyTemplate* ) |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_party_size_limit_model.html#a308309bffcc6f85159c42b4a3b09bc06)GetAssumedPartySizeForLordParty()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int StoryMode.GameComponents.StoryModePartySizeLimitModel.GetAssumedPartySizeForLordParty | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *leaderHero*, |
|  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *partyMapFaction*, |
|  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *actualClan* ) |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_party_size_limit_model.html#aef162785f49b16020007b24de051eecc)GetClanTierPartySizeEffectForHero()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int StoryMode.GameComponents.StoryModePartySizeLimitModel.GetClanTierPartySizeEffectForHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_party_size_limit_model.html#a2e43272eab20cf7aa2e92b473871344a)GetIdealVillagerPartySize()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int StoryMode.GameComponents.StoryModePartySizeLimitModel.GetIdealVillagerPartySize | ( | [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) | *village* | ) |  |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_party_size_limit_model.html#a74b09579d143ac49332945150bd13495)GetNextClanTierPartySizeEffectChangeForHero()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int StoryMode.GameComponents.StoryModePartySizeLimitModel.GetNextClanTierPartySizeEffectChangeForHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_party_size_limit_model.html#ac5bec228f5f2967a0bf814c34ba16d7a)GetPartyMemberSizeLimit()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) StoryMode.GameComponents.StoryModePartySizeLimitModel.GetPartyMemberSizeLimit | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, |
|  |  | bool | *includeDescriptions* = false ) |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_party_size_limit_model.html#af07c3e0621055a22d8ab9ee79ee3a934)GetPartyPrisonerSizeLimit()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) StoryMode.GameComponents.StoryModePartySizeLimitModel.GetPartyPrisonerSizeLimit | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, |
|  |  | bool | *includeDescriptions* = false ) |

Property Documentation
----------------------

[◆](class_story_mode_1_1_game_components_1_1_story_mode_party_size_limit_model.html#a05ccea1466176431df815b8f2d3ac871)MinimumNumberOfVillagersAtVillagerParty
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int StoryMode.GameComponents.StoryModePartySizeLimitModel.MinimumNumberOfVillagersAtVillagerParty | | get |

