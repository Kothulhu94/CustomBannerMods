--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_politics_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultClanPoliticsModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.ClanPoliticsModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_politics_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateInfluenceChange](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_politics_model.html#ab86e428d0546c9cb006b04ddc5ac2bef) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, bool includeDescriptions=false) |
| override float | [CalculateSupportForPolicyInClan](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_politics_model.html#ae132e6dc0fefc3339a5b7bfbe55424e5) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, [PolicyObject](class_tale_worlds_1_1_campaign_system_1_1_policy_object.html) policy) |
| override float | [CalculateRelationshipChangeWithSponsor](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_politics_model.html#a8844baeccc3d7cf121e7bdbca691426b) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) sponsorClan) |
| override int | [GetInfluenceRequiredToOverrideKingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_politics_model.html#aa25aa56fe28649ed2c1bd2758a9216d8) ([DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) popularOption, [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) overridingOption, [KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) decision) |
| override bool | [CanHeroBeGovernor](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_politics_model.html#a1feb7838cb8e4d40cae76ecaa955bbaf) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.ClanPoliticsModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_politics_model.html) | |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_politics_model.html#ab86e428d0546c9cb006b04ddc5ac2bef)CalculateInfluenceChange()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultClanPoliticsModel.CalculateInfluenceChange | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, |
|  |  | bool | *includeDescriptions* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_politics_model.html#ae132e6dc0fefc3339a5b7bfbe55424e5)CalculateSupportForPolicyInClan()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultClanPoliticsModel.CalculateSupportForPolicyInClan | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, |
|  |  | [PolicyObject](class_tale_worlds_1_1_campaign_system_1_1_policy_object.html) | *policy* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_politics_model.html#a8844baeccc3d7cf121e7bdbca691426b)CalculateRelationshipChangeWithSponsor()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultClanPoliticsModel.CalculateRelationshipChangeWithSponsor | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, |
|  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *sponsorClan* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_politics_model.html#aa25aa56fe28649ed2c1bd2758a9216d8)GetInfluenceRequiredToOverrideKingdomDecision()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultClanPoliticsModel.GetInfluenceRequiredToOverrideKingdomDecision | ( | [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) | *popularOption*, |
|  |  | [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) | *overridingOption*, |
|  |  | [KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) | *decision* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_politics_model.html#a1feb7838cb8e4d40cae76ecaa955bbaf)CanHeroBeGovernor()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultClanPoliticsModel.CanHeroBeGovernor | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

