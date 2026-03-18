--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html ---

TaleWorlds.CampaignSystem.Election.SettlementClaimantPreliminaryDecision Class ReferenceInherits [TaleWorlds.CampaignSystem.Election.KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html).

|  |  |
| --- | --- |
| Classes | |
| class | [SettlementClaimantPreliminaryOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision_3e3ea864bc18374c0522da1988f5dae4.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [SettlementClaimantPreliminaryDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#a4d0a919c695a2f8c51379fcce0b399da) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) proposerClan, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#abb0e86e9809e295e38c56c187d02a983) settlement) |
| override bool | [IsAllowed](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#a7d3027b5d735c0f5512a14a9654a6996) () |
| override int | [GetProposalInfluenceCost](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#a52f617e44f2d06f27dfa4d0715f64cc2) () |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetGeneralTitle](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#a252f838dc6dd33729791edd29780059f) () |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetSupportTitle](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#ab942d10a182b4cb820a49079b0fca751) () |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetChooseTitle](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#a3bc6101543a399c346daaff772205c87) () |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetSupportDescription](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#a4aea550887665a3b6094119b97fd8d4a) () |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetChooseDescription](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#a4120d3544eecd217404ccd32480261da) () |
| override float | [CalculateMeritOfOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#a9e3f8b7a0d25a208deb544acb6f3f1f4) ([DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) candidateOutcome) |
| override IEnumerable< [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) > | [DetermineInitialCandidates](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#af1a4e76c0deb9973090cb3ecf3fac4dc) () |
| override [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | [DetermineChooser](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#afcada4f07e2e36a6ee5731df5cf6a0be) () |
| float | [CalculateSupport](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#ab6b71f6ee9c43aaa68730bed081969d2) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| override float | [DetermineSupport](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#abd0f77a1076a2566e1c7d933e9ee2b5b) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) possibleOutcome) |
| override void | [DetermineSponsors](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#a996b04672c7115c07e603ef3899a6267) (MBReadOnlyList< [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) > possibleOutcomes) |
| override void | [ApplyChosenOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#a99fb3c1333d6db377c7d605176b85bea) ([DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) chosenOutcome) |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetSecondaryEffects](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#a0c481ede5a23cc9e8217d379c029eeb5) () |
| override void | [ApplySecondaryEffects](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#a51b7548c02470f80bac335762dfa5c30) (MBReadOnlyList< [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) > possibleOutcomes, [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) chosenOutcome) |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetChosenOutcomeText](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#a48c275ba873794d5a53638105282b1f2) ([DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) chosenOutcome, [SupportStatus](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#ab0c111711b5f0df1db95eb714536ee57) supportStatus, bool isShortVersion=false) |
| override [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) | [GetQueriedDecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#a7940588ea8c373265580ac652b84ea49) (MBReadOnlyList< [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) > possibleOutcomes) |
| override [KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#ad41b9666723b512611e3ed40584eec26) | [GetFollowUpDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#a5a74a2b9b15317f1b730e05655fb2037) () |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.Election.KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) | |
| bool | [IsAllowed](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#acee272e7d420b2be58a04725509dc664) () |
| int | [GetInfluenceCost](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a55ed637ecdf48e9224dc8491b4609ab8) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) sponsorClan) |
| int | [GetProposalInfluenceCost](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a3c140b6f7010e10480110b4fc46c1be6) () |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetGeneralTitle](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a5f4c4822b634bd33f78350035e9de659) () |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetSupportTitle](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a124721c0d3693f781db7464abbf73bb7) () |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetChooseTitle](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#acf85d6cbcf77bd61757ff100b61f098f) () |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetSupportDescription](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a7782eef4a86018769154a25d160a1ca5) () |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetChooseDescription](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a64ba0dacb4d96ec04cf54ef073b3c91f) () |
| IEnumerable< [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) > | [DetermineInitialCandidates](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a18f46eb6f3da322667b8ecba5540fd9d) () |
| MBList< [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) > | [NarrowDownCandidates](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#ab580e528badc1c2497a6b2d9a5a9e5bc) (MBList< [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) > initialCandidates, int maxCandidateCount) |
| [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | [DetermineChooser](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a6355702698343027c7c6b9c28efdddd8) () |
| IEnumerable< [Supporter](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_supporter.html) > | [DetermineSupporters](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a9d235a3fd895ef49dc50cb7b87021341) () |
| virtual bool | [CanMakeDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a63526f99c21cbbbac22675b53125a9b3) (out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) reason, bool includeReason=false) |
| bool | [ShouldBeCancelled](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a10958b0e7717f0eb0bb401afde593de3) () |
| [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) | [DetermineSupportOption](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#aab9bdfe851f5257549e8d0fd770c4984) ([Supporter](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_supporter.html) supporter, MBReadOnlyList< [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) > possibleOutcomes, out [Supporter.SupportWeights](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_supporter.html#a7cb985d9da65e62c360ed3bb1ef50749) supportWeightOfSelectedOutcome, bool calculateRelationshipEffect) |
| float | [DetermineSupport](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#ac5e71b507e144caa72a87698645e4a36) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) possibleOutcome) |
| void | [DetermineSponsors](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a8564f61dedcfb83c66908a4a34fc2bba) (MBReadOnlyList< [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) > possibleOutcomes) |
| void | [ApplyChosenOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a58a87b9d43c98ed6a2d0efe7aec0e9dc) ([DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) chosenOutcome) |
| int | [GetInfluenceCost](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#adf7399df09f4baf11fbd3e42b663c9a6) ([DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) decisionOutcome, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, [Supporter.SupportWeights](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_supporter.html#a7cb985d9da65e62c360ed3bb1ef50749) supportWeight) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetSecondaryEffects](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#ab4250dcabe26791e84bc0c6757cf1edf) () |
| void | [ApplySecondaryEffects](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a4dafed2646804d010fd76db06d6690c8) (MBReadOnlyList< [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) > possibleOutcomes, [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) chosenOutcome) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetChosenOutcomeText](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#ac1fba066646e239ac9f55c0d6aac5de4) ([DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) chosenOutcome, [SupportStatus](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#ab0c111711b5f0df1db95eb714536ee57) supportStatus, bool isShortVersion=false) |
| MBList< [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) > | [SortDecisionOutcomes](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a0233a0aa114cbb2b8ef0737bdfc4c096) (MBReadOnlyList< [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) > possibleOutcomes) |
| [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) | [GetQueriedDecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#aae09377fed4aa5e36e554e5c76dc61b9) (MBReadOnlyList< [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) > possibleOutcomes) |
| bool | [IsSingleClanDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#ac2244f0226913ebd4c763cba206210fe) () |
| virtual float | [CalculateRelationshipEffectWithSponsor](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#ad5d4b8a684be3ae599f19b1da4058f06) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| int | [GetInfluenceCostOfSupport](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#adca5ef9e37d0b12561ea23f68ce5ee19) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, [Supporter.SupportWeights](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_supporter.html#a7cb985d9da65e62c360ed3bb1ef50749) supportWeight) |
| virtual bool | [OnShowDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a26c3c4adc4d9b5ba28074485dd5e5d01) () |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly Settlement | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#abb0e86e9809e295e38c56c187d02a983) |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.Election.KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) | |
| [SupportStatus](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#ab0c111711b5f0df1db95eb714536ee57) | [SupportStatusOfFinalDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#ab28167c07d4d8e88aca71ea5a695655f) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override bool | [ShouldBeCancelledInternal](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#af85f294a60afd31714836d34870166e0) () |
| override int | [GetInfluenceCostOfSupportInternal](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#a61bcf14afb47ef50fab5ad62e34cc1e7) ([Supporter.SupportWeights](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_supporter.html#a7cb985d9da65e62c360ed3bb1ef50749) supportWeight) |
| Protected Member Functions inherited from [TaleWorlds.CampaignSystem.Election.KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) | |
|  | [KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#ad41b9666723b512611e3ed40584eec26) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) proposerClan) |
| virtual bool | [CanProposerClanChangeOpinion](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#afefd1ac119b165c2172872e51936fcad) () |
| void | [AssignDefaultSponsor](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a145193803e1862de8bcf189be50ade6d) ([DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) outcome) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Types inherited from [TaleWorlds.CampaignSystem.Election.KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) | |
| enum | [SupportStatus](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#ab0c111711b5f0df1db95eb714536ee57) {     [Equal](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#ab0c111711b5f0df1db95eb714536ee57af5f286e73bda105e538310b3190f75c5) ,     [Majority](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#ab0c111711b5f0df1db95eb714536ee57abb6e3fbcfb3068381efffc7e352b5eb7) ,     [Minority](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#ab0c111711b5f0df1db95eb714536ee57aa3a5b8485089839f7084b14d62d97d20)   } |
| Properties inherited from [TaleWorlds.CampaignSystem.Election.KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) | |
| Kingdom | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a21836dcdd18325a03c202ff260a986c6) `[get]` |
| [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | [ProposerClan](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a8d3d6e561eb7c644562b5c43139a97a8) `[get]` |
| bool | [IsEnforced](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a909813e99499de1d4ebae0edac34bfe3) `[get, set]` |
| bool | [PlayerExamined](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a09b5a082f6c404d7dfda94ee7770d4ff) `[get, set]` |
| bool | [NotifyPlayer](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a3b9f052e6f9074e1f9880acd3de48684) `[get, set]` |
| bool | [IsPlayerParticipant](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#ad7c7a8e9daebfa2538f040acf1b82a74) `[get]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [TriggerTime](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a8c8cd4cb873905120f9391687abc4223) `[get, protected set]` |
| virtual bool | [IsKingsVoteAllowed](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a3b9f386ccedde63edb753a318f619185) `[get]` |
| virtual int | [HoursToWait](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a7eb4e150e388f83414a9d975ab17c61c) `[get]` |
| bool | [NeedsPlayerResolution](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a90be26ffeea267bc3931a0a4885e03af) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#a4d0a919c695a2f8c51379fcce0b399da)SettlementClaimantPreliminaryDecision()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Election.SettlementClaimantPreliminaryDecision.SettlementClaimantPreliminaryDecision | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *proposerClan*, |
|  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#abb0e86e9809e295e38c56c187d02a983) | *settlement* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#a7d3027b5d735c0f5512a14a9654a6996)IsAllowed()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.Election.SettlementClaimantPreliminaryDecision.IsAllowed | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#a52f617e44f2d06f27dfa4d0715f64cc2)GetProposalInfluenceCost()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.Election.SettlementClaimantPreliminaryDecision.GetProposalInfluenceCost | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#a252f838dc6dd33729791edd29780059f)GetGeneralTitle()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Election.SettlementClaimantPreliminaryDecision.GetGeneralTitle | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#ab942d10a182b4cb820a49079b0fca751)GetSupportTitle()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Election.SettlementClaimantPreliminaryDecision.GetSupportTitle | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#a3bc6101543a399c346daaff772205c87)GetChooseTitle()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Election.SettlementClaimantPreliminaryDecision.GetChooseTitle | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#a4aea550887665a3b6094119b97fd8d4a)GetSupportDescription()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Election.SettlementClaimantPreliminaryDecision.GetSupportDescription | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#a4120d3544eecd217404ccd32480261da)GetChooseDescription()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Election.SettlementClaimantPreliminaryDecision.GetChooseDescription | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#a9e3f8b7a0d25a208deb544acb6f3f1f4)CalculateMeritOfOutcome()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override float TaleWorlds.CampaignSystem.Election.SettlementClaimantPreliminaryDecision.CalculateMeritOfOutcome | ( | [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) | *candidateOutcome* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Election.KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a0d644d78394ecd4292829da4138a8806).

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#af1a4e76c0deb9973090cb3ecf3fac4dc)DetermineInitialCandidates()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override IEnumerable< [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) > TaleWorlds.CampaignSystem.Election.SettlementClaimantPreliminaryDecision.DetermineInitialCandidates | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#afcada4f07e2e36a6ee5731df5cf6a0be)DetermineChooser()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) TaleWorlds.CampaignSystem.Election.SettlementClaimantPreliminaryDecision.DetermineChooser | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#af85f294a60afd31714836d34870166e0)ShouldBeCancelledInternal()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override bool TaleWorlds.CampaignSystem.Election.SettlementClaimantPreliminaryDecision.ShouldBeCancelledInternal | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.Election.KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#af696103f12985ad2b57b18462a90b923).

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#ab6b71f6ee9c43aaa68730bed081969d2)CalculateSupport()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.Election.SettlementClaimantPreliminaryDecision.CalculateSupport | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#abd0f77a1076a2566e1c7d933e9ee2b5b)DetermineSupport()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.Election.SettlementClaimantPreliminaryDecision.DetermineSupport | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, |
|  |  | [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) | *possibleOutcome* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#a996b04672c7115c07e603ef3899a6267)DetermineSponsors()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.Election.SettlementClaimantPreliminaryDecision.DetermineSponsors | ( | MBReadOnlyList< [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) > | *possibleOutcomes* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#a61bcf14afb47ef50fab5ad62e34cc1e7)GetInfluenceCostOfSupportInternal()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override int TaleWorlds.CampaignSystem.Election.SettlementClaimantPreliminaryDecision.GetInfluenceCostOfSupportInternal | ( | [Supporter.SupportWeights](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_supporter.html#a7cb985d9da65e62c360ed3bb1ef50749) | *supportWeight* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.Election.KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a79d8b66b1ba33660306423bf9c2fba2e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#a99fb3c1333d6db377c7d605176b85bea)ApplyChosenOutcome()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.Election.SettlementClaimantPreliminaryDecision.ApplyChosenOutcome | ( | [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) | *chosenOutcome* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#a0c481ede5a23cc9e8217d379c029eeb5)GetSecondaryEffects()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Election.SettlementClaimantPreliminaryDecision.GetSecondaryEffects | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#a51b7548c02470f80bac335762dfa5c30)ApplySecondaryEffects()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.Election.SettlementClaimantPreliminaryDecision.ApplySecondaryEffects | ( | MBReadOnlyList< [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) > | *possibleOutcomes*, |
|  |  | [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) | *chosenOutcome* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#a48c275ba873794d5a53638105282b1f2)GetChosenOutcomeText()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Election.SettlementClaimantPreliminaryDecision.GetChosenOutcomeText | ( | [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) | *chosenOutcome*, |
|  |  | [SupportStatus](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#ab0c111711b5f0df1db95eb714536ee57) | *supportStatus*, |
|  |  | bool | *isShortVersion* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#a7940588ea8c373265580ac652b84ea49)GetQueriedDecisionOutcome()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) TaleWorlds.CampaignSystem.Election.SettlementClaimantPreliminaryDecision.GetQueriedDecisionOutcome | ( | MBReadOnlyList< [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) > | *possibleOutcomes* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#a5a74a2b9b15317f1b730e05655fb2037)GetFollowUpDecision()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#ad41b9666723b512611e3ed40584eec26) TaleWorlds.CampaignSystem.Election.SettlementClaimantPreliminaryDecision.GetFollowUpDecision | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Election.KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#abafd0dc4c377a8494b48c02c8d83d025).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision.html#abb0e86e9809e295e38c56c187d02a983)Settlement
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly Settlement TaleWorlds.CampaignSystem.Election.SettlementClaimantPreliminaryDecision.Settlement |

