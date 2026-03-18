--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_hero_agent_location_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultHeroAgentLocationModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.HeroAgentLocationModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_agent_location_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override bool | [WillBeListedInOverlay](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_hero_agent_location_model.html#a0b65770b83198078950e908eb824acb1) ([LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) locationCharacter) |
| override [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | [GetLocationForHero](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_hero_agent_location_model.html#a64e4881a66ef17aa54b0fbb2b0887d95) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, out [HeroLocationDetail](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_agent_location_model.html#a6c96e1d24cc1ca4b02714a046bc68f6c) heroLocationDetail) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.HeroAgentLocationModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_agent_location_model.html) | |
| bool | [WillBeListedInOverlay](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_agent_location_model.html#acd46e22f6afffa8356c79b6720c93cbe) ([LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) locationCharacter) |
| [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | [GetLocationForHero](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_agent_location_model.html#a488be48a31c098c8edb4601a5ecf0fae) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, out [HeroLocationDetail](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_agent_location_model.html#a6c96e1d24cc1ca4b02714a046bc68f6c) heroSpawnDetail) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Types inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.HeroAgentLocationModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_agent_location_model.html) | |
| enum | [HeroLocationDetail](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_agent_location_model.html#a6c96e1d24cc1ca4b02714a046bc68f6c) {     [None](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_agent_location_model.html#a6c96e1d24cc1ca4b02714a046bc68f6ca6adf97f83acf6453d4a6a4b1070f3754) ,     [SettlementKingQueen](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_agent_location_model.html#a6c96e1d24cc1ca4b02714a046bc68f6ca8f84b24165af0593f7e136e528807eb9) ,     [NobleBelongingToNoParty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_agent_location_model.html#a6c96e1d24cc1ca4b02714a046bc68f6ca8c57bd1f69610f62523e05b97149c6cd) ,     [Prisoner](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_agent_location_model.html#a6c96e1d24cc1ca4b02714a046bc68f6ca0862a78e358ab0a158439d23cae77e2c) ,     [PlayerClanMember](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_agent_location_model.html#a6c96e1d24cc1ca4b02714a046bc68f6ca53742e285acf12378e15706d6aeab45a) ,     [MainPartyCompanion](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_agent_location_model.html#a6c96e1d24cc1ca4b02714a046bc68f6cac64b9823d4a12999313b100948973ddf) ,     [Notable](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_agent_location_model.html#a6c96e1d24cc1ca4b02714a046bc68f6ca8cf4ab2a6a691b26fda07a06184a5dd1) ,     [Wanderer](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_agent_location_model.html#a6c96e1d24cc1ca4b02714a046bc68f6cab8e97e517357b5e3ea61bd79a250a22a) ,     [PartyLeader](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_agent_location_model.html#a6c96e1d24cc1ca4b02714a046bc68f6cade0a2907c0b9adeab9ddbcc90483453d) ,     [PartylessHeroInsideVillage](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_agent_location_model.html#a6c96e1d24cc1ca4b02714a046bc68f6ca2cf67f1b23fdc2835f753ab71fdd675f)   } |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_hero_agent_location_model.html#a0b65770b83198078950e908eb824acb1)WillBeListedInOverlay()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultHeroAgentLocationModel.WillBeListedInOverlay | ( | [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) | *locationCharacter* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_hero_agent_location_model.html#a64e4881a66ef17aa54b0fbb2b0887d95)GetLocationForHero()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) TaleWorlds.CampaignSystem.GameComponents.DefaultHeroAgentLocationModel.GetLocationForHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | out [HeroLocationDetail](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_hero_agent_location_model.html#a6c96e1d24cc1ca4b02714a046bc68f6c) | *heroLocationDetail* ) |

