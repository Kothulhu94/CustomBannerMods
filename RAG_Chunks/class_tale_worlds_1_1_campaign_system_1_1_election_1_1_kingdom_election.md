--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_election.html ---

TaleWorlds.CampaignSystem.Election.KingdomElection Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [KingdomElection](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_election.html#a7d245697ab789a6ca1c5b90c9944891f) ([KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) decision) |
| void | [StartElection](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_election.html#a22ffc6db68bcb693dfb5f325f0aae219) () |
| void | [StartElectionWithoutPlayer](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_election.html#aa8f66856ed88e1ff2d84f344cf186fcf) () |
| float | [GetLikelihoodForSponsor](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_election.html#a948b19c777e662a17fa8a741a76beac2) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) sponsor) |
| int | [GetRelationChangeWithSponsor](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_election.html#a1ffc3088acc3b68a845385afb20ed48c) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) opposerOrSupporter, [Supporter.SupportWeights](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_supporter.html#a7cb985d9da65e62c360ed3bb1ef50749) supportWeight, bool isOpposingSides) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetChosenOutcomeText](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_election.html#a63b77225e7d2af6c920b355a1852b7ed) () |
| void | [DetermineOfficialSupport](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_election.html#a6a2fad23071424942e4ac1503b064714) () |
| int | [GetInfluenceCostOfOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_election.html#abee85b7127f0811522501397cf30f1a9) ([DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) outcome, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) supporter, [Supporter.SupportWeights](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_supporter.html#a7cb985d9da65e62c360ed3bb1ef50749) weight) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetSecondaryEffects](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_election.html#a104c8b74b5fc42e54de8f1c3eebad2a0) () |
| void | [OnPlayerSupport](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_election.html#a9f70155482e64186b05be029be9d760a) ([DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) decisionOutcome, [Supporter.SupportWeights](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_supporter.html#a7cb985d9da65e62c360ed3bb1ef50749) supportWeight) |
| void | [ApplySelection](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_election.html#a0805a5d0d279cc2b48002e489c59416e) () |
| MBList< [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) > | [GetSortedDecisionOutcomes](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_election.html#a770e32e24765a9d289a30887d4d7529f) () |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetGeneralTitle](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_election.html#a66938fdb15e4d0695a8ebcc3f8c8c063) () |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetTitle](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_election.html#a80bcbfdb81016c5c32b7f64361b90e35) () |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetDescription](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_election.html#a0fae8d02739320d3e59156c87e26d40f) () |

|  |  |
| --- | --- |
| Properties | |
| MBReadOnlyList< [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) > | [PossibleOutcomes](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_election.html#ae614c61cba2aca3dcbf37cd9c6b731d6) `[get]` |
| bool | [IsCancelled](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_election.html#a149962adf1dfd6895d93607a9612caa3) `[get]` |
| bool | [IsPlayerSupporter](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_election.html#a7a4277ff53cfac94ec6ea63479986370) `[get]` |
| bool | [IsPlayerChooser](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_election.html#a689f2c407ec684c9cf004e4603e8a35c) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_election.html#a7d245697ab789a6ca1c5b90c9944891f)KingdomElection()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Election.KingdomElection.KingdomElection | ( | [KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) | *decision* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_election.html#a22ffc6db68bcb693dfb5f325f0aae219)StartElection()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Election.KingdomElection.StartElection | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_election.html#aa8f66856ed88e1ff2d84f344cf186fcf)StartElectionWithoutPlayer()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Election.KingdomElection.StartElectionWithoutPlayer | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_election.html#a948b19c777e662a17fa8a741a76beac2)GetLikelihoodForSponsor()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.Election.KingdomElection.GetLikelihoodForSponsor | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *sponsor* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_election.html#a1ffc3088acc3b68a845385afb20ed48c)GetRelationChangeWithSponsor()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Election.KingdomElection.GetRelationChangeWithSponsor | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *opposerOrSupporter*, |
|  |  | [Supporter.SupportWeights](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_supporter.html#a7cb985d9da65e62c360ed3bb1ef50749) | *supportWeight*, |
|  |  | bool | *isOpposingSides* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_election.html#a63b77225e7d2af6c920b355a1852b7ed)GetChosenOutcomeText()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Election.KingdomElection.GetChosenOutcomeText | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_election.html#a6a2fad23071424942e4ac1503b064714)DetermineOfficialSupport()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Election.KingdomElection.DetermineOfficialSupport | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_election.html#abee85b7127f0811522501397cf30f1a9)GetInfluenceCostOfOutcome()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Election.KingdomElection.GetInfluenceCostOfOutcome | ( | [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) | *outcome*, |
|  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *supporter*, |
|  |  | [Supporter.SupportWeights](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_supporter.html#a7cb985d9da65e62c360ed3bb1ef50749) | *weight* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_election.html#a104c8b74b5fc42e54de8f1c3eebad2a0)GetSecondaryEffects()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Election.KingdomElection.GetSecondaryEffects | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_election.html#a9f70155482e64186b05be029be9d760a)OnPlayerSupport()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Election.KingdomElection.OnPlayerSupport | ( | [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) | *decisionOutcome*, |
|  |  | [Supporter.SupportWeights](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_supporter.html#a7cb985d9da65e62c360ed3bb1ef50749) | *supportWeight* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_election.html#a0805a5d0d279cc2b48002e489c59416e)ApplySelection()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Election.KingdomElection.ApplySelection | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_election.html#a770e32e24765a9d289a30887d4d7529f)GetSortedDecisionOutcomes()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| MBList< [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) > TaleWorlds.CampaignSystem.Election.KingdomElection.GetSortedDecisionOutcomes | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_election.html#a66938fdb15e4d0695a8ebcc3f8c8c063)GetGeneralTitle()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Election.KingdomElection.GetGeneralTitle | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_election.html#a80bcbfdb81016c5c32b7f64361b90e35)GetTitle()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Election.KingdomElection.GetTitle | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_election.html#a0fae8d02739320d3e59156c87e26d40f)GetDescription()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Election.KingdomElection.GetDescription | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_election.html#ae614c61cba2aca3dcbf37cd9c6b731d6)PossibleOutcomes
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html)> TaleWorlds.CampaignSystem.Election.KingdomElection.PossibleOutcomes | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_election.html#a149962adf1dfd6895d93607a9612caa3)IsCancelled
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Election.KingdomElection.IsCancelled | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_election.html#a7a4277ff53cfac94ec6ea63479986370)IsPlayerSupporter
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Election.KingdomElection.IsPlayerSupporter | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_election.html#a689f2c407ec684c9cf004e4603e8a35c)IsPlayerChooser
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Election.KingdomElection.IsPlayerChooser | | get |

