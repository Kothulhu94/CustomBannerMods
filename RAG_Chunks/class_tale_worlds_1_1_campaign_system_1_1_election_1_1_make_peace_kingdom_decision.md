--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html ---

TaleWorlds.CampaignSystem.Election.MakePeaceKingdomDecision Class ReferenceInherits [TaleWorlds.CampaignSystem.Election.KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html).

|  |  |
| --- | --- |
| Classes | |
| class | [MakePeaceDecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision_1_1_make_peace_decision_outcome.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MakePeaceKingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#ac226979bef0e266e740af8a68d0bcbba) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) proposerClan, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) kingdomToMakePeaceWith, int dailyTributeToBePaid=0, int dailyTributeDurationInDays=0, bool applyResults=true, bool isProposedByOpponent=false) |
| override bool | [IsAllowed](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#af4aae1427d3686670215dc277c961d53) () |
| override int | [GetProposalInfluenceCost](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#a8d25838a510a9a4b0cd16ba4d7dfd668) () |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetGeneralTitle](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#abe4b071e150333b7cc96b040efe8bebb) () |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetSupportTitle](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#a3d095277f0e66a9aa17d419bb850bd5f) () |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetChooseTitle](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#a6abf18c05f87fac5049eea2aaa93ff41) () |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetSupportDescription](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#ae13d0ab99474d29e374a7788c6435cdf) () |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetChooseDescription](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#a4a9293bf6f3ed651bad6d8bc4eb3eb64) () |
| override IEnumerable< [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) > | [DetermineInitialCandidates](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#ae68b696564422ede1bb3230a9812e35f) () |
| override [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | [DetermineChooser](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#aae4937eefd9d70d3db5463e303bd7571) () |
| override void | [DetermineSponsors](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#aac0c6f89ebc1d459d5b806f912e15cc3) (MBReadOnlyList< [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) > possibleOutcomes) |
| override void | [ApplyChosenOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#a038967fc0b755bf9e0728464b38a7348) ([DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) chosenOutcome) |
| override bool | [OnShowDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#aa160c0ecc368147458cf7db19f6fa6fb) () |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetSecondaryEffects](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#ad575a43ce63f24422f4142ef903819ab) () |
| override void | [ApplySecondaryEffects](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#a9f72023bef189fdd0ee2242c07e09d24) (MBReadOnlyList< [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) > possibleOutcomes, [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) chosenOutcome) |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetChosenOutcomeText](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#a904bf49250f0ebde26d16c23ad77e480) ([DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) chosenOutcome, [SupportStatus](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#ab0c111711b5f0df1db95eb714536ee57) supportStatus, bool isShortVersion=false) |
| override [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) | [GetQueriedDecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#a5e71d094e05b585af2aa7a82fd90cded) (MBReadOnlyList< [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) > possibleOutcomes) |
| float | [CalculateSupport](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#ae2c9d1aa88eb609e6c824ae473d5e7f6) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| override float | [DetermineSupport](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#a70e6c6565b7275897d739e27343fd897) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) possibleOutcome) |
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
| virtual [KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#ad41b9666723b512611e3ed40584eec26) | [GetFollowUpDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#abafd0dc4c377a8494b48c02c8d83d025) () |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | [FactionToMakePeaceWith](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#a1eaf2af15f107960ddb6fca8f2041dad) |
| readonly int | [DailyTributeToBePaid](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#a0915c781610df8a76a67761e1611c229) |
| readonly int | [DailyTributeDurationInDays](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#a78324b0d53b8ce63c6de28720ae30179) |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.Election.KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) | |
| [SupportStatus](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#ab0c111711b5f0df1db95eb714536ee57) | [SupportStatusOfFinalDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#ab28167c07d4d8e88aca71ea5a695655f) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override bool | [ShouldBeCancelledInternal](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#ae6b2dc41beebbaa35299f3b112e52056) () |
| Protected Member Functions inherited from [TaleWorlds.CampaignSystem.Election.KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) | |
|  | [KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#ad41b9666723b512611e3ed40584eec26) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) proposerClan) |
| virtual bool | [CanProposerClanChangeOpinion](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#afefd1ac119b165c2172872e51936fcad) () |
| void | [AssignDefaultSponsor](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a145193803e1862de8bcf189be50ade6d) ([DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) outcome) |
| virtual int | [GetInfluenceCostOfSupportInternal](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a79d8b66b1ba33660306423bf9c2fba2e) ([Supporter.SupportWeights](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_supporter.html#a7cb985d9da65e62c360ed3bb1ef50749) supportWeight) |

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

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#ac226979bef0e266e740af8a68d0bcbba)MakePeaceKingdomDecision()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Election.MakePeaceKingdomDecision.MakePeaceKingdomDecision | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *proposerClan*, |
|  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *kingdomToMakePeaceWith*, |
|  |  | int | *dailyTributeToBePaid* = 0, |
|  |  | int | *dailyTributeDurationInDays* = 0, |
|  |  | bool | *applyResults* = true, |
|  |  | bool | *isProposedByOpponent* = false ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#af4aae1427d3686670215dc277c961d53)IsAllowed()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.Election.MakePeaceKingdomDecision.IsAllowed | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#a8d25838a510a9a4b0cd16ba4d7dfd668)GetProposalInfluenceCost()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.Election.MakePeaceKingdomDecision.GetProposalInfluenceCost | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#abe4b071e150333b7cc96b040efe8bebb)GetGeneralTitle()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Election.MakePeaceKingdomDecision.GetGeneralTitle | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#a3d095277f0e66a9aa17d419bb850bd5f)GetSupportTitle()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Election.MakePeaceKingdomDecision.GetSupportTitle | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#a6abf18c05f87fac5049eea2aaa93ff41)GetChooseTitle()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Election.MakePeaceKingdomDecision.GetChooseTitle | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#ae13d0ab99474d29e374a7788c6435cdf)GetSupportDescription()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Election.MakePeaceKingdomDecision.GetSupportDescription | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#a4a9293bf6f3ed651bad6d8bc4eb3eb64)GetChooseDescription()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Election.MakePeaceKingdomDecision.GetChooseDescription | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#ae68b696564422ede1bb3230a9812e35f)DetermineInitialCandidates()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override IEnumerable< [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) > TaleWorlds.CampaignSystem.Election.MakePeaceKingdomDecision.DetermineInitialCandidates | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#aae4937eefd9d70d3db5463e303bd7571)DetermineChooser()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) TaleWorlds.CampaignSystem.Election.MakePeaceKingdomDecision.DetermineChooser | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#ae6b2dc41beebbaa35299f3b112e52056)ShouldBeCancelledInternal()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override bool TaleWorlds.CampaignSystem.Election.MakePeaceKingdomDecision.ShouldBeCancelledInternal | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.Election.KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#af696103f12985ad2b57b18462a90b923).

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#aac0c6f89ebc1d459d5b806f912e15cc3)DetermineSponsors()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.Election.MakePeaceKingdomDecision.DetermineSponsors | ( | MBReadOnlyList< [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) > | *possibleOutcomes* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#a038967fc0b755bf9e0728464b38a7348)ApplyChosenOutcome()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.Election.MakePeaceKingdomDecision.ApplyChosenOutcome | ( | [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) | *chosenOutcome* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#aa160c0ecc368147458cf7db19f6fa6fb)OnShowDecision()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override bool TaleWorlds.CampaignSystem.Election.MakePeaceKingdomDecision.OnShowDecision | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Election.KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a26c3c4adc4d9b5ba28074485dd5e5d01).

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#ad575a43ce63f24422f4142ef903819ab)GetSecondaryEffects()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Election.MakePeaceKingdomDecision.GetSecondaryEffects | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#a9f72023bef189fdd0ee2242c07e09d24)ApplySecondaryEffects()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.Election.MakePeaceKingdomDecision.ApplySecondaryEffects | ( | MBReadOnlyList< [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) > | *possibleOutcomes*, |
|  |  | [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) | *chosenOutcome* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#a904bf49250f0ebde26d16c23ad77e480)GetChosenOutcomeText()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Election.MakePeaceKingdomDecision.GetChosenOutcomeText | ( | [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) | *chosenOutcome*, |
|  |  | [SupportStatus](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#ab0c111711b5f0df1db95eb714536ee57) | *supportStatus*, |
|  |  | bool | *isShortVersion* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#a5e71d094e05b585af2aa7a82fd90cded)GetQueriedDecisionOutcome()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) TaleWorlds.CampaignSystem.Election.MakePeaceKingdomDecision.GetQueriedDecisionOutcome | ( | MBReadOnlyList< [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) > | *possibleOutcomes* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#ae2c9d1aa88eb609e6c824ae473d5e7f6)CalculateSupport()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.Election.MakePeaceKingdomDecision.CalculateSupport | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#a70e6c6565b7275897d739e27343fd897)DetermineSupport()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.Election.MakePeaceKingdomDecision.DetermineSupport | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, |
|  |  | [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) | *possibleOutcome* ) |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#a1eaf2af15f107960ddb6fca8f2041dad)FactionToMakePeaceWith
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) TaleWorlds.CampaignSystem.Election.MakePeaceKingdomDecision.FactionToMakePeaceWith |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#a0915c781610df8a76a67761e1611c229)DailyTributeToBePaid
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly int TaleWorlds.CampaignSystem.Election.MakePeaceKingdomDecision.DailyTributeToBePaid |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision.html#a78324b0d53b8ce63c6de28720ae30179)DailyTributeDurationInDays
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly int TaleWorlds.CampaignSystem.Election.MakePeaceKingdomDecision.DailyTributeDurationInDays |

