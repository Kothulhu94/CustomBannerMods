--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_politics_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.ClanPoliticsModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultClanPoliticsModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_politics_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateInfluenceChange](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_politics_model.html#acf0b3fee241e1ac555ec2aec60a44151) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, bool includeDescriptions=false) |
| float | [CalculateSupportForPolicyInClan](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_politics_model.html#a066cae31d5e5f89742c76d1f01632ad9) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, [PolicyObject](class_tale_worlds_1_1_campaign_system_1_1_policy_object.html) policy) |
| float | [CalculateRelationshipChangeWithSponsor](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_politics_model.html#a989333eceed25479e4e2aadacb38f012) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) sponsorClan) |
| int | [GetInfluenceRequiredToOverrideKingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_politics_model.html#a8d39478d1e4f4c87d42aa6c5363a2d19) ([DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) popularOption, [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) overridingOption, [KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) decision) |
| bool | [CanHeroBeGovernor](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_politics_model.html#a2e1a663de95cf504492bb05785acf887) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_politics_model.html#acf0b3fee241e1ac555ec2aec60a44151)CalculateInfluenceChange()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.ClanPoliticsModel.CalculateInfluenceChange | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, | |  |  | bool | *includeDescriptions* = false ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_politics_model.html#a066cae31d5e5f89742c76d1f01632ad9)CalculateSupportForPolicyInClan()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.ClanPoliticsModel.CalculateSupportForPolicyInClan | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, | |  |  | [PolicyObject](class_tale_worlds_1_1_campaign_system_1_1_policy_object.html) | *policy* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_politics_model.html#a989333eceed25479e4e2aadacb38f012)CalculateRelationshipChangeWithSponsor()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.ClanPoliticsModel.CalculateRelationshipChangeWithSponsor | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *sponsorClan* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_politics_model.html#a8d39478d1e4f4c87d42aa6c5363a2d19)GetInfluenceRequiredToOverrideKingdomDecision()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ClanPoliticsModel.GetInfluenceRequiredToOverrideKingdomDecision | ( | [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) | *popularOption*, | |  |  | [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) | *overridingOption*, | |  |  | [KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) | *decision* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_politics_model.html#a2e1a663de95cf504492bb05785acf887)CanHeroBeGovernor()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.ClanPoliticsModel.CanHeroBeGovernor | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | abstract |

