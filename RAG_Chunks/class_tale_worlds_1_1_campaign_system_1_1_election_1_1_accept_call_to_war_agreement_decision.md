--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html ---

TaleWorlds.CampaignSystem.Election.AcceptCallToWarAgreementDecision Class ReferenceInherits [TaleWorlds.CampaignSystem.Election.KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html).

|  |  |
| --- | --- |
| Classes | |
| class | [AcceptCallToWarAgreementDecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision_1_111ee14ece78d43de779f1cbdc5e0db65.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [AcceptCallToWarAgreementDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#abe2997cb34908197b07a7b00d28408a8) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) proposerClan, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a21836dcdd18325a03c202ff260a986c6) callingKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a21836dcdd18325a03c202ff260a986c6) kingdomToCallToWarAgainst) |
| override bool | [IsAllowed](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#a5911ab9b0066db2f96c7c72786d93d4a) () |
| override int | [GetProposalInfluenceCost](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#aaa286b046bff771b32710a3f1edf0545) () |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetGeneralTitle](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#ab0835f3d92cd4f5f1dfc9a494bcb6bfd) () |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetSupportTitle](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#ae26bdd72eed1b855e07149ea23396bac) () |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetChooseTitle](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#a737ec65996bce26f2da7222032ae2847) () |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetSupportDescription](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#a3da52c9ac2d15d0caa6bd51d5c4cb7cc) () |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetChooseDescription](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#a9eca447cc7ea3e3a890b61e54fb749d1) () |
| override IEnumerable< [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) > | [DetermineInitialCandidates](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#a2f7300b1780aab0c920d15bf298dd086) () |
| override [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | [DetermineChooser](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#a6243a63226b0347093e6688784b21bf1) () |
| override void | [DetermineSponsors](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#a1f4fc7c6dcef0e731729b02d274b0afb) (MBReadOnlyList< [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) > possibleOutcomes) |
| override void | [ApplyChosenOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#a11f66117438a5600de7ccad92b7340f5) ([DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) chosenOutcome) |
| override void | [ApplySecondaryEffects](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#afb89ae18ad0e502c0da6251103d4131d) (MBReadOnlyList< [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) > possibleOutcomes, [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) chosenOutcome) |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetSecondaryEffects](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#afe635e818e524eca5031297799edfcc2) () |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetChosenOutcomeText](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#a92ea5b0c6887a777960b6d0a27ba256a) ([DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) chosenOutcome, [SupportStatus](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#ab0c111711b5f0df1db95eb714536ee57) supportStatus, bool isShortVersion=false) |
| override [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) | [GetQueriedDecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#ab3ef48625e29ae151d16eca2a9e95d43) (MBReadOnlyList< [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) > possibleOutcomes) |
| float | [CalculateSupport](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#a4d401f8efd779e4e20a970536fc37ad2) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| override float | [DetermineSupport](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#ae0aa06fe5e76df05878dc601bde67b60) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) possibleOutcome) |
| override bool | [CanMakeDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#af106afdf9e5599349429def2b153befa) (out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) reason, bool includeReason=false) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.Election.KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) | |
| bool | [IsAllowed](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#acee272e7d420b2be58a04725509dc664) () |
| int | [GetInfluenceCost](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a55ed637ecdf48e9224dc8491b4609ab8) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) sponsorClan) |
| int | [GetProposalInfluenceCost](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a3c140b6f7010e10480110b4fc46c1be6) () |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetGeneralTitle](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a5f4c4822b634bd33f78350035e9de659) () |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetSupportTitle](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a124721c0d3693f781db7464abbf73bb7) () |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetChooseTitle](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#acf85d6cbcf77bd61757ff100b61f098f) () |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetSupportDescription](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a7782eef4a86018769154a25d160a1ca5) () |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetChooseDescription](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a64ba0dacb4d96ec04cf54ef073b3c91f) () |
| virtual float | [CalculateMeritOfOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a0d644d78394ecd4292829da4138a8806) ([DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) candidateOutcome) |
| IEnumerable< [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) > | [DetermineInitialCandidates](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a18f46eb6f3da322667b8ecba5540fd9d) () |
| MBList< [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) > | [NarrowDownCandidates](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#ab580e528badc1c2497a6b2d9a5a9e5bc) (MBList< [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) > initialCandidates, int maxCandidateCount) |
| [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | [DetermineChooser](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a6355702698343027c7c6b9c28efdddd8) () |
| IEnumerable< [Supporter](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_supporter.html) > | [DetermineSupporters](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a9d235a3fd895ef49dc50cb7b87021341) () |
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
| virtual [KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#ad41b9666723b512611e3ed40584eec26) | [GetFollowUpDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#abafd0dc4c377a8494b48c02c8d83d025) () |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a21836dcdd18325a03c202ff260a986c6) | [CallingKingdom](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#af37444832204ac88a837ef07f49809c2) |
| readonly [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a21836dcdd18325a03c202ff260a986c6) | [KingdomToCallToWarAgainst](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#ab5afe00b5b273e522720270c06d08b1d) |
| readonly int | [CallToWarCost](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#a9855cd7a626c8eaaef462d5197e9d884) |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.Election.KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) | |
| [SupportStatus](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#ab0c111711b5f0df1db95eb714536ee57) | [SupportStatusOfFinalDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#ab28167c07d4d8e88aca71ea5a695655f) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override bool | [ShouldBeCancelledInternal](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#af96a226f34e3b9dfea79eebea4f77249) () |
| Protected Member Functions inherited from [TaleWorlds.CampaignSystem.Election.KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) | |
|  | [KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#ad41b9666723b512611e3ed40584eec26) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) proposerClan) |
| virtual bool | [CanProposerClanChangeOpinion](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#afefd1ac119b165c2172872e51936fcad) () |
| void | [AssignDefaultSponsor](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a145193803e1862de8bcf189be50ade6d) ([DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) outcome) |
| virtual int | [GetInfluenceCostOfSupportInternal](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a79d8b66b1ba33660306423bf9c2fba2e) ([Supporter.SupportWeights](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_supporter.html#a7cb985d9da65e62c360ed3bb1ef50749) supportWeight) |

|  |  |
| --- | --- |
| Properties | |
| [IAllianceCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alliance_campaign_behavior.html) | [AllianceCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#adca407d9604581a74483434b473b2dc9) `[get]` |
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

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Types inherited from [TaleWorlds.CampaignSystem.Election.KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) | |
| enum | [SupportStatus](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#ab0c111711b5f0df1db95eb714536ee57) {     [Equal](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#ab0c111711b5f0df1db95eb714536ee57af5f286e73bda105e538310b3190f75c5) ,     [Majority](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#ab0c111711b5f0df1db95eb714536ee57abb6e3fbcfb3068381efffc7e352b5eb7) ,     [Minority](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#ab0c111711b5f0df1db95eb714536ee57aa3a5b8485089839f7084b14d62d97d20)   } |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#abe2997cb34908197b07a7b00d28408a8)AcceptCallToWarAgreementDecision()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Election.AcceptCallToWarAgreementDecision.AcceptCallToWarAgreementDecision | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *proposerClan*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a21836dcdd18325a03c202ff260a986c6) | *callingKingdom*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a21836dcdd18325a03c202ff260a986c6) | *kingdomToCallToWarAgainst* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#a5911ab9b0066db2f96c7c72786d93d4a)IsAllowed()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.Election.AcceptCallToWarAgreementDecision.IsAllowed | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#aaa286b046bff771b32710a3f1edf0545)GetProposalInfluenceCost()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.Election.AcceptCallToWarAgreementDecision.GetProposalInfluenceCost | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#ab0835f3d92cd4f5f1dfc9a494bcb6bfd)GetGeneralTitle()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Election.AcceptCallToWarAgreementDecision.GetGeneralTitle | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#ae26bdd72eed1b855e07149ea23396bac)GetSupportTitle()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Election.AcceptCallToWarAgreementDecision.GetSupportTitle | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#a737ec65996bce26f2da7222032ae2847)GetChooseTitle()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Election.AcceptCallToWarAgreementDecision.GetChooseTitle | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#a3da52c9ac2d15d0caa6bd51d5c4cb7cc)GetSupportDescription()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Election.AcceptCallToWarAgreementDecision.GetSupportDescription | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#a9eca447cc7ea3e3a890b61e54fb749d1)GetChooseDescription()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Election.AcceptCallToWarAgreementDecision.GetChooseDescription | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#a2f7300b1780aab0c920d15bf298dd086)DetermineInitialCandidates()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override IEnumerable< [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) > TaleWorlds.CampaignSystem.Election.AcceptCallToWarAgreementDecision.DetermineInitialCandidates | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#a6243a63226b0347093e6688784b21bf1)DetermineChooser()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) TaleWorlds.CampaignSystem.Election.AcceptCallToWarAgreementDecision.DetermineChooser | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#af96a226f34e3b9dfea79eebea4f77249)ShouldBeCancelledInternal()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override bool TaleWorlds.CampaignSystem.Election.AcceptCallToWarAgreementDecision.ShouldBeCancelledInternal | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.Election.KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#af696103f12985ad2b57b18462a90b923).

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#a1f4fc7c6dcef0e731729b02d274b0afb)DetermineSponsors()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.Election.AcceptCallToWarAgreementDecision.DetermineSponsors | ( | MBReadOnlyList< [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) > | *possibleOutcomes* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#a11f66117438a5600de7ccad92b7340f5)ApplyChosenOutcome()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.Election.AcceptCallToWarAgreementDecision.ApplyChosenOutcome | ( | [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) | *chosenOutcome* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#afb89ae18ad0e502c0da6251103d4131d)ApplySecondaryEffects()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.Election.AcceptCallToWarAgreementDecision.ApplySecondaryEffects | ( | MBReadOnlyList< [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) > | *possibleOutcomes*, |
|  |  | [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) | *chosenOutcome* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#afe635e818e524eca5031297799edfcc2)GetSecondaryEffects()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Election.AcceptCallToWarAgreementDecision.GetSecondaryEffects | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#a92ea5b0c6887a777960b6d0a27ba256a)GetChosenOutcomeText()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Election.AcceptCallToWarAgreementDecision.GetChosenOutcomeText | ( | [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) | *chosenOutcome*, |
|  |  | [SupportStatus](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#ab0c111711b5f0df1db95eb714536ee57) | *supportStatus*, |
|  |  | bool | *isShortVersion* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#ab3ef48625e29ae151d16eca2a9e95d43)GetQueriedDecisionOutcome()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) TaleWorlds.CampaignSystem.Election.AcceptCallToWarAgreementDecision.GetQueriedDecisionOutcome | ( | MBReadOnlyList< [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) > | *possibleOutcomes* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#a4d401f8efd779e4e20a970536fc37ad2)CalculateSupport()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.Election.AcceptCallToWarAgreementDecision.CalculateSupport | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#ae0aa06fe5e76df05878dc601bde67b60)DetermineSupport()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.Election.AcceptCallToWarAgreementDecision.DetermineSupport | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, |
|  |  | [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) | *possibleOutcome* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#af106afdf9e5599349429def2b153befa)CanMakeDecision()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override bool TaleWorlds.CampaignSystem.Election.AcceptCallToWarAgreementDecision.CanMakeDecision | ( | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *reason*, | |  |  | bool | *includeReason* = false ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Election.KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a63526f99c21cbbbac22675b53125a9b3).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#af37444832204ac88a837ef07f49809c2)CallingKingdom
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a21836dcdd18325a03c202ff260a986c6) TaleWorlds.CampaignSystem.Election.AcceptCallToWarAgreementDecision.CallingKingdom |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#ab5afe00b5b273e522720270c06d08b1d)KingdomToCallToWarAgainst
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a21836dcdd18325a03c202ff260a986c6) TaleWorlds.CampaignSystem.Election.AcceptCallToWarAgreementDecision.KingdomToCallToWarAgainst |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#a9855cd7a626c8eaaef462d5197e9d884)CallToWarCost
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly int TaleWorlds.CampaignSystem.Election.AcceptCallToWarAgreementDecision.CallToWarCost |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision.html#adca407d9604581a74483434b473b2dc9)AllianceCampaignBehavior
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IAllianceCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_alliance_campaign_behavior.html) TaleWorlds.CampaignSystem.Election.AcceptCallToWarAgreementDecision.AllianceCampaignBehavior | | get |

