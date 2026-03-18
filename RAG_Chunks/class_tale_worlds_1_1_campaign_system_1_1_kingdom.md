--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_kingdom.html ---

TaleWorlds.CampaignSystem.Kingdom Class ReferencesealedInherits [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html), and [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetName](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a7b3ef8672b7c94c07c41e84c61e3e709) () |
| override string | [ToString](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#acc9296c6d1f7ab983617d66e36e44786) () |
| void | [UpdateFactionsAtWarWith](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a99350b0d3f8dc7688c44e9188605580b) () |
| void | [UpdateAlliedKingdoms](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a22e0b4523aae24ea0d16928bb9e18ace) () |
|  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#aee5c208fbd67f7ddd1bda261d47df7dd) () |
| void | [InitializeKingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a8167fe2de223da52c55b9052795b4e37) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) name, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) informalName, [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) culture, [Banner](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#aea517699592941bff83f50339fd93de2) banner, uint kingdomColor1, uint kingdomColor2, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) initialHomeSettlement, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) encyclopediaText, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) encyclopediaTitle, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) encyclopediaRulerTitle) |
| void | [ChangeKingdomName](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#af531dde386ec5b9ce267b4d70ce43a86) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) name, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) informalName) |
| void | [OnHeroChangedState](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#aadaed689a3805051631f5ad07a2ad4f2) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [Hero.CharacterStates](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a5d97848f11b7de5bae4abd3ddaf54157) oldState) |
| bool | [IsAllyWith](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#ab6f32e702e26437e463f12e66d52f25b) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#aee5c208fbd67f7ddd1bda261d47df7dd) other) |
| bool | [HasCalledToWar](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a0a547db391caf32b0834860d63a1a019) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#aee5c208fbd67f7ddd1bda261d47df7dd) other) |
| bool | [IsAtWarWith](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a8a7c0f795a5fbecc966957739454efc5) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) other) |
| bool | [IsAtConstantWarWith](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a9ff6061ab0de53e9849fdb38b968ce14) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) other) |
| [StanceLink](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html) | [GetStanceWith](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a6603d9a85b1ef6e8c041ed170672d410) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) other) |
| void | [CreateArmy](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#ab936b5be56ec273c7f0903dd31be54f3) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) armyLeader, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) targetSettlement, [Army.ArmyTypes](class_tale_worlds_1_1_campaign_system_1_1_army.html#a3ac67be2f16059a5b268539b03930b4a) selectedArmyType, MBReadOnlyList< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > partiesToCallToArmy=null) |
| void | [AddDecision](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a6e1a2bd458c1dcea52956af2f0a565b6) ([KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) kingdomDecision, bool ignoreInfluenceCost=false) |
| void | [RemoveDecision](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#aab1168bfeb76ffba4d20cdd1d054beda) ([KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) kingdomDecision) |
| void | [OnKingdomDecisionConcluded](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#ad7fb4d8d5b57f74061a81f88019eca75) () |
| void | [AddPolicy](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#aba7b839d47b2e576b8aba560fb420ef4) ([PolicyObject](class_tale_worlds_1_1_campaign_system_1_1_policy_object.html) policy) |
| void | [RemovePolicy](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a9928e48173f3a45e467abb471c038a09) ([PolicyObject](class_tale_worlds_1_1_campaign_system_1_1_policy_object.html) policy) |
| bool | [HasPolicy](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a15d11a326c3c99e72764faf9ed16d7e5) ([PolicyObject](class_tale_worlds_1_1_campaign_system_1_1_policy_object.html) policy) |
| override void | [Deserialize](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#aa0e00f5eb425678ed8337f07e046cc9b) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
|  | De-serializes the object from an XmlNode. |
| void | [OnFortificationAdded](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a47aa8779ad2e9c6ac0a63aa890b1589d) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) fortification) |
| void | [OnFortificationRemoved](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#aa98c7c6ded309828cab3f7ae6be63700) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) fortification) |
| void | [OnHeroAdded](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#ac848868afaab39548fc5927a6a70b39a) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| void | [OnHeroRemoved](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a701562fcb4d4258567ecf7a60bfbd4e4) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| void | [OnWarPartyAdded](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#ada5f9b312b1f04a1e7be846e9ca46586) ([WarPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_war_party_component.html) warPartyComponent) |
| void | [OnWarPartyRemoved](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#ad9b9ef7b012dae0a8c81964c368307f6) ([WarPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_war_party_component.html) warPartyComponent) |
| void | [CalculateMidSettlement](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#acabc2d5ee9b861a15aeda83068187a78) () |
| void | [ReactivateKingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a601a6d5c5c0ce9a38b465a121dacfdd1) () |
| Public Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a520e657fd5a750c8b7e2154b0f5629ea) () |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a134c5e806ba735219710d773e7075b00) (MBObjectBase other) |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8e3c1b47f5d928e64d9d67fa7864c364) (string stringId) |
| void | [AfterInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab67141737ce51fe724e4a5b8026a973b) () |
| virtual void | [AfterRegister](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab15f91cc9dbb7ff8763eec828c179216) () |
| virtual void | [Initialize](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aad39d5ca82d85853a9879e2670dd036e) () |
| override int | [GetHashCode](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a68e79a07f136aae5be4fe9eadb612def) () |
| void | [PreAfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af26d64a79291c4f6328fc151d2569ebf) () |
| void | [AfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a277b54134c76732e443019a7862cf388) () |
| void | [OnRegistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a586208e92e5041fd432127305aa8af16) () |
| void | [OnUnregistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a71bef09af9a896246fa7b18c324e565c) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#aee5c208fbd67f7ddd1bda261d47df7dd) | [CreateKingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#ae5a4ea9025102692879e6988938737ff) (string stringID) |

|  |  |
| --- | --- |
| Public Attributes | |
| int | [PoliticalStagnation](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a71074a6eea27a79cba37ba7aab7a321d) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [AfterLoad](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#afe1c0fcaae3e0d9a44f8780660ef97c9) () |
| Protected Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| virtual void | [OnBeforeLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad32c7b22bd64e771cc05ee54ae78058a) () |
| virtual void | [PreAfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aeddc87ee0703c7f37d9129d9a5e024e4) () |

|  |  |
| --- | --- |
| Properties | |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#aff8bed440c8a9d7be0645f215712044c) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [InformalName](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#ae0ac4f1f4b39c718266eb9fb3cfbb592) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [EncyclopediaText](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a91cb4b8ee56727fd1fc0be53efe1b99c) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [EncyclopediaTitle](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#af0ac1e1fc75d83419cfbec1e42b75d77) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [EncyclopediaRulerTitle](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a0981b7cbe6836c7f449857896e33e9d3) `[get]` |
| string | [EncyclopediaLink](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#acb0aa5aaa20d0239bd1c0563e28ebe5e) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [EncyclopediaLinkWithName](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a2feb5cd3120b37252f4178d5dfa32bd3) `[get]` |
| MBReadOnlyList< [KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) > | [UnresolvedDecisions](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a036367a69611ab61d659b40b0ece945e) `[get]` |
| [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | [Culture](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#aa1839c63aa74f2a15a74a3f374d668c3) `[get]` |
| [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [InitialHomeSettlement](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a88b6ea5fc8e53b1e90d4da39282b6e42) `[get]` |
|  | Point to spawn around if no settlement remained. |
| bool | [IsMapFaction](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a1f167267b8c8e999b48eaad1cdea440e) `[get]` |
| bool | [HasNavalNavigationCapability](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a4d2953c2db88377d8a3904e8046dc20d) `[get]` |
| uint | [Color](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a88a5e104eac12d94c60ff8701be0369f) `[get]` |
| uint | [Color2](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a7f20e79358d5ecfaa28b9880b4100731) `[get]` |
| uint | [PrimaryBannerColor](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#ad610fba6292e05ab76beaaf9863ff013) `[get]` |
| uint | [SecondaryBannerColor](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a25bc280c78fc4f01da115661a4832481) `[get]` |
| float | [MainHeroCrimeRating](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a96554cc32fba8b6819a0737785dddc03) `[get, set]` |
| MBReadOnlyList< [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) > | [FactionsAtWarWith](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#ae1a4cff6885982e1a97fcd8204f85c35) `[get]` |
| MBReadOnlyList< [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#aee5c208fbd67f7ddd1bda261d47df7dd) > | [AlliedKingdoms](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a32b1ae3d29bb796d2973d5cb3b8d51a6) `[get]` |
| MBReadOnlyList< [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) > | [Fiefs](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a405f907f00ea270f3d932ad606cfc630) `[get]` |
| MBReadOnlyList< [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) > | [Villages](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a5e3e0a1a49a87394004ab1c1d1b6d69c) `[get]` |
| MBReadOnlyList< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) > | [Settlements](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a791e435e94eb4df1265a5721d51950bc) `[get]` |
| MBReadOnlyList< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [Heroes](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a04ab4d0ceb1bdc02596d5967b1ed5b12) `[get]` |
| MBReadOnlyList< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [AliveLords](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a7c1f8bde16e8bc3dbafe80b2490def5b) `[get]` |
| MBReadOnlyList< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [DeadLords](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#adb42006d2148634cabb6778c187721d7) `[get]` |
| MBReadOnlyList< [WarPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_war_party_component.html) > | [WarPartyComponents](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a325b2dc7186e2bed522decde2462cc48) `[get]` |
| float | [DailyCrimeRatingChange](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#ae5ebaa126cf1fc0380069a4bb6b42274) `[get]` |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [DailyCrimeRatingChangeExplained](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#ae84b9ec4ac858f2b051a585dc810e344) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [BasicTroop](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a56f97e214750523d045d37509876a3ac) `[get]` |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [Leader](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a57f60051f5dcc8b50b825282d3e9e087) `[get]` |
| Banner | [Banner](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#aea517699592941bff83f50339fd93de2) `[get, set]` |
| bool | [IsBanditFaction](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a1521fca91f795d8e359ee4387f898323) `[get]` |
| bool | [IsMinorFaction](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#aeeb66450a7a3a82f14b40683ddf618fa) `[get]` |
| bool | [IsRebelClan](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a0876480a7ca89ded755deda4d72ae450) `[get]` |
| bool | [IsClan](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#ac1d3e239df64933f2f6f7fae1af3e944) `[get]` |
| bool | [IsOutlaw](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a2097f2411dd40f03fc7ef5fc1b67c89b) `[get]` |
| MBReadOnlyList< [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) > | [Clans](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#ab7421b9364612686b904c107724d2d0b) `[get]` |
| [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | [RulingClan](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a15d166c35735c16043655215469f95ba) `[get, set]` |
| int | [LastArmyCreationDay](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#ae8bdc2699c6cc75f0c8dfd1421c5b644) `[get]` |
| MBReadOnlyList< [Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) > | [Armies](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a1c682b8c50b299c66a1f826aa279b669) `[get]` |
| float | [CurrentTotalStrength](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a08884a7d24a5d3d52438aafb6de40564) `[get]` |
| [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [FactionMidSettlement](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a5db8289fb2835d6b4c6f7c7497cff93f) `[get]` |
| float | [DistanceToClosestNonAllyFortification](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a3c04ac62faedae168ba97afa9eabf0ca) `[get]` |
| IList< [PolicyObject](class_tale_worlds_1_1_campaign_system_1_1_policy_object.html) > | [ActivePolicies](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a07877eb2f0bf4837c1030d273ce17c1c) `[get]` |
| static MBReadOnlyList< [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#aee5c208fbd67f7ddd1bda261d47df7dd) > | [All](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a0967256af4237780060e3bf155232832) `[get]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [LastKingdomDecisionConclusionDate](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#acd7e60c0c4c4277877032416469163ed) `[get]` |
| bool | [IsEliminated](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a37c442c544a7815c37088e25c00c0831) `[get]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [LastMercenaryOfferTime](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a0aeb0cf4d3853a9c2de4ec057a7bb784) `[get, set]` |
| [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | [MapFaction](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a50ac0e63494b70d48c22b261bfeb83f7) `[get]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [NotAttackableByPlayerUntilTime](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a13e63dba7940e472f46ae09028e7d918) `[get, set]` |
| float | [Aggressiveness](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a8ab549bd07af3896d7553a986a68135e) `[get]` |
|  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) Aggressiveness between 0 and 100 This is used for AI in evaluating peace offers and war proposals A kingdom with high aggressiveness can be declared war at without penalty. |
| IEnumerable< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | [AllParties](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#aa4789b380f085aa3bf7d491e4f06ff00) `[get]` |
| int | [MercenaryWallet](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a3ef5a029ed3b8dd874d2bc8046acf515) `[get]` |
| int | [TributeWallet](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a25275faa070219bc98144de499861d3a) `[get, set]` |
|  | Gold for spending on tributes. Can be negative which means tribute debt. |
| int | [KingdomBudgetWallet](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a07d488710effc749e3a539a374792f0c) `[get, set]` |
| int | [CallToWarWallet](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a46cf529eca76e897896aa05fe5a03626) `[get, set]` |
| Properties inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| string | [StringId](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8f7cc0266861eb249963e5ead3ab93f1) `[get, set]` |
| [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html) | [Id](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af97fbe63c015ee5f4958ab6946b7f69a) `[get, set]` |
| bool | [IsInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aa6b3602c7cfd678c75bf91e1c3073606) `[get]` |
| bool | [IsReady](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#abc67abca4d8d58d34835693808c0aa14) `[get, set]` |
| Properties inherited from [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | |
| string | [StringId](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a63f07d9b261a337398089def512aa650) `[get]` |
| [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html) | [Id](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#acb2318a9caabaee60af3433cf9097e42) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#aee5c208fbd67f7ddd1bda261d47df7dd)Kingdom()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Kingdom.Kingdom | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a7b3ef8672b7c94c07c41e84c61e3e709)GetName()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Kingdom.GetName | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a0b72f9e386b6cefc4e6bfb52642b98db).

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#acc9296c6d1f7ab983617d66e36e44786)ToString()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.CampaignSystem.Kingdom.ToString | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a99350b0d3f8dc7688c44e9188605580b)UpdateFactionsAtWarWith()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Kingdom.UpdateFactionsAtWarWith | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a9eb41938db901f83224cf4de4c10d65d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a22e0b4523aae24ea0d16928bb9e18ace)UpdateAlliedKingdoms()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Kingdom.UpdateAlliedKingdoms | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#ae5a4ea9025102692879e6988938737ff)CreateKingdom()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#aee5c208fbd67f7ddd1bda261d47df7dd) TaleWorlds.CampaignSystem.Kingdom.CreateKingdom | ( | string | *stringID* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a8167fe2de223da52c55b9052795b4e37)InitializeKingdom()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Kingdom.InitializeKingdom | ( | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *name*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *informalName*, |
|  |  | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | *culture*, |
|  |  | [Banner](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#aea517699592941bff83f50339fd93de2) | *banner*, |
|  |  | uint | *kingdomColor1*, |
|  |  | uint | *kingdomColor2*, |
|  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *initialHomeSettlement*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *encyclopediaText*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *encyclopediaTitle*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *encyclopediaRulerTitle* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#af531dde386ec5b9ce267b4d70ce43a86)ChangeKingdomName()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Kingdom.ChangeKingdomName | ( | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *name*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *informalName* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#aadaed689a3805051631f5ad07a2ad4f2)OnHeroChangedState()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Kingdom.OnHeroChangedState | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | [Hero.CharacterStates](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a5d97848f11b7de5bae4abd3ddaf54157) | *oldState* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#afe1c0fcaae3e0d9a44f8780660ef97c9)AfterLoad()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Kingdom.AfterLoad | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aae8a0aa22e7a659e1edbedfe9739d413).

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#ab6f32e702e26437e463f12e66d52f25b)IsAllyWith()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Kingdom.IsAllyWith | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#aee5c208fbd67f7ddd1bda261d47df7dd) | *other* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a0a547db391caf32b0834860d63a1a019)HasCalledToWar()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Kingdom.HasCalledToWar | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#aee5c208fbd67f7ddd1bda261d47df7dd) | *other* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a8a7c0f795a5fbecc966957739454efc5)IsAtWarWith()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Kingdom.IsAtWarWith | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *other* | ) |  |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a6c6fed23bd3c74fc7052ca32212f989b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a9ff6061ab0de53e9849fdb38b968ce14)IsAtConstantWarWith()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Kingdom.IsAtConstantWarWith | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *other* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a6603d9a85b1ef6e8c041ed170672d410)GetStanceWith()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [StanceLink](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html) TaleWorlds.CampaignSystem.Kingdom.GetStanceWith | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *other* | ) |  |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a31cfaab163c703983101158c374817bd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#ab936b5be56ec273c7f0903dd31be54f3)CreateArmy()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Kingdom.CreateArmy | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *armyLeader*, |
|  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *targetSettlement*, |
|  |  | [Army.ArmyTypes](class_tale_worlds_1_1_campaign_system_1_1_army.html#a3ac67be2f16059a5b268539b03930b4a) | *selectedArmyType*, |
|  |  | MBReadOnlyList< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | *partiesToCallToArmy* = null ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a6e1a2bd458c1dcea52956af2f0a565b6)AddDecision()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Kingdom.AddDecision | ( | [KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) | *kingdomDecision*, |
|  |  | bool | *ignoreInfluenceCost* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#aab1168bfeb76ffba4d20cdd1d054beda)RemoveDecision()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Kingdom.RemoveDecision | ( | [KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) | *kingdomDecision* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#ad7fb4d8d5b57f74061a81f88019eca75)OnKingdomDecisionConcluded()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Kingdom.OnKingdomDecisionConcluded | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#aba7b839d47b2e576b8aba560fb420ef4)AddPolicy()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Kingdom.AddPolicy | ( | [PolicyObject](class_tale_worlds_1_1_campaign_system_1_1_policy_object.html) | *policy* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a9928e48173f3a45e467abb471c038a09)RemovePolicy()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Kingdom.RemovePolicy | ( | [PolicyObject](class_tale_worlds_1_1_campaign_system_1_1_policy_object.html) | *policy* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a15d11a326c3c99e72764faf9ed16d7e5)HasPolicy()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Kingdom.HasPolicy | ( | [PolicyObject](class_tale_worlds_1_1_campaign_system_1_1_policy_object.html) | *policy* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#aa0e00f5eb425678ed8337f07e046cc9b)Deserialize()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Kingdom.Deserialize | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, | |  |  | XmlNode | *node* ) | | virtual |

Parameters
:   |  |  |
    | --- | --- |
    | objectManager | Object manager |
    | node | XmlNode to be de-serialized from. |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad1364026109401ca16d5a450d8b8f178).

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a47aa8779ad2e9c6ac0a63aa890b1589d)OnFortificationAdded()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Kingdom.OnFortificationAdded | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *fortification* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#aa98c7c6ded309828cab3f7ae6be63700)OnFortificationRemoved()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Kingdom.OnFortificationRemoved | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *fortification* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#ac848868afaab39548fc5927a6a70b39a)OnHeroAdded()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Kingdom.OnHeroAdded | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a701562fcb4d4258567ecf7a60bfbd4e4)OnHeroRemoved()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Kingdom.OnHeroRemoved | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#ada5f9b312b1f04a1e7be846e9ca46586)OnWarPartyAdded()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Kingdom.OnWarPartyAdded | ( | [WarPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_war_party_component.html) | *warPartyComponent* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#ad9b9ef7b012dae0a8c81964c368307f6)OnWarPartyRemoved()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Kingdom.OnWarPartyRemoved | ( | [WarPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_war_party_component.html) | *warPartyComponent* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#acabc2d5ee9b861a15aeda83068187a78)CalculateMidSettlement()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Kingdom.CalculateMidSettlement | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a601a6d5c5c0ce9a38b465a121dacfdd1)ReactivateKingdom()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Kingdom.ReactivateKingdom | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a71074a6eea27a79cba37ba7aab7a321d)PoliticalStagnation
----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.CampaignSystem.Kingdom.PoliticalStagnation |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#aff8bed440c8a9d7be0645f215712044c)Name
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Kingdom.Name | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a5f784ac1ad0d6f6f35be72e6046ed141).

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#ae0ac4f1f4b39c718266eb9fb3cfbb592)InformalName
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Kingdom.InformalName | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a4cf3bbc379619694517857dc652b7e7c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a91cb4b8ee56727fd1fc0be53efe1b99c)EncyclopediaText
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Kingdom.EncyclopediaText | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a88f874d82b9e917c9d409e0088b87c37).

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#af0ac1e1fc75d83419cfbec1e42b75d77)EncyclopediaTitle
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Kingdom.EncyclopediaTitle | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a0981b7cbe6836c7f449857896e33e9d3)EncyclopediaRulerTitle
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Kingdom.EncyclopediaRulerTitle | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#acb0aa5aaa20d0239bd1c0563e28ebe5e)EncyclopediaLink
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.Kingdom.EncyclopediaLink | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a986ddce5831d5d053c13721a7eef7cfb).

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a2feb5cd3120b37252f4178d5dfa32bd3)EncyclopediaLinkWithName
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Kingdom.EncyclopediaLinkWithName | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a9864d4ab6d4c973ba8d922759d97ef37).

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a036367a69611ab61d659b40b0ece945e)UnresolvedDecisions
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html)> TaleWorlds.CampaignSystem.Kingdom.UnresolvedDecisions | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#aa1839c63aa74f2a15a74a3f374d668c3)Culture
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) TaleWorlds.CampaignSystem.Kingdom.Culture | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#ae2410f96ee8c7b30f1e52b3d2ee81f16).

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a88b6ea5fc8e53b1e90d4da39282b6e42)InitialHomeSettlement
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) TaleWorlds.CampaignSystem.Kingdom.InitialHomeSettlement | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a63679ff6ee7ea0b404f345a70751319f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a1f167267b8c8e999b48eaad1cdea440e)IsMapFaction
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Kingdom.IsMapFaction | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a9b4e8d3c6f24bc9f39bc6f94e1282b00).

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a4d2953c2db88377d8a3904e8046dc20d)HasNavalNavigationCapability
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Kingdom.HasNavalNavigationCapability | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#aad52f8f4cbf0a72e71763dd91b9a85f3).

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a88a5e104eac12d94c60ff8701be0369f)Color
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.CampaignSystem.Kingdom.Color | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a6e2ed7c768fae2b87e044da226d93563).

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a7f20e79358d5ecfaa28b9880b4100731)Color2
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.CampaignSystem.Kingdom.Color2 | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a56e2229912dd58aaf4b299c4d984a62c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#ad610fba6292e05ab76beaaf9863ff013)PrimaryBannerColor
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.CampaignSystem.Kingdom.PrimaryBannerColor | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a25bc280c78fc4f01da115661a4832481)SecondaryBannerColor
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.CampaignSystem.Kingdom.SecondaryBannerColor | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a96554cc32fba8b6819a0737785dddc03)MainHeroCrimeRating
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Kingdom.MainHeroCrimeRating | | getset |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#aa1d37a376a80a9ca6ed1fe72ae13aca3).

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#ae1a4cff6885982e1a97fcd8204f85c35)FactionsAtWarWith
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html)> TaleWorlds.CampaignSystem.Kingdom.FactionsAtWarWith | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a6f8fa8bfd88d5de9108d92b5001c132b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a32b1ae3d29bb796d2973d5cb3b8d51a6)AlliedKingdoms
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#aee5c208fbd67f7ddd1bda261d47df7dd)> TaleWorlds.CampaignSystem.Kingdom.AlliedKingdoms | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a405f907f00ea270f3d932ad606cfc630)Fiefs
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html)> TaleWorlds.CampaignSystem.Kingdom.Fiefs | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a8f01e78bf362dde0be33ecbfe981e2bc).

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a5e3e0a1a49a87394004ab1c1d1b6d69c)Villages
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html)> TaleWorlds.CampaignSystem.Kingdom.Villages | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a791e435e94eb4df1265a5721d51950bc)Settlements
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html)> TaleWorlds.CampaignSystem.Kingdom.Settlements | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a70a79e7493da2c485091613765a2e393).

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a04ab4d0ceb1bdc02596d5967b1ed5b12)Heroes
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.Kingdom.Heroes | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a08d0e35922305b50a4d164dbda13f69b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a7c1f8bde16e8bc3dbafe80b2490def5b)AliveLords
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.Kingdom.AliveLords | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a1d500e13b5fc9ba908e86fca15d17479).

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#adb42006d2148634cabb6778c187721d7)DeadLords
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.Kingdom.DeadLords | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a104b43add616b8c1971278024d17e1fb).

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a325b2dc7186e2bed522decde2462cc48)WarPartyComponents
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[WarPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_war_party_component.html)> TaleWorlds.CampaignSystem.Kingdom.WarPartyComponents | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a7d4417c64aef6853c03ff9914ca366a9).

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#ae5ebaa126cf1fc0380069a4bb6b42274)DailyCrimeRatingChange
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Kingdom.DailyCrimeRatingChange | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a10b0e5dd46137f2cb69a3d911ab18de0).

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#ae84b9ec4ac858f2b051a585dc810e344)DailyCrimeRatingChangeExplained
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.Kingdom.DailyCrimeRatingChangeExplained | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a2778102953d812a716878a620f155ec6).

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a56f97e214750523d045d37509876a3ac)BasicTroop
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.Kingdom.BasicTroop | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#aa55cb1d9700f0221f010ea419aacf04c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a57f60051f5dcc8b50b825282d3e9e087)Leader
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.Kingdom.Leader | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a861dcc20e19e6cff88df2fbf3179ae21).

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#aea517699592941bff83f50339fd93de2)Banner
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Banner TaleWorlds.CampaignSystem.Kingdom.Banner | | getset |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a4bea19ae8ce9e5dd579aa6a442b8199f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a1521fca91f795d8e359ee4387f898323)IsBanditFaction
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Kingdom.IsBanditFaction | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a2120a9dbeb33a301dbd0ed4992e27f6b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#aeeb66450a7a3a82f14b40683ddf618fa)IsMinorFaction
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Kingdom.IsMinorFaction | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#af634d54fdfb210a30b6d8f2adc004aee).

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a0876480a7ca89ded755deda4d72ae450)IsRebelClan
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Kingdom.IsRebelClan | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a7394d297c6dc0c8a6eee33568d0a3660).

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#ac1d3e239df64933f2f6f7fae1af3e944)IsClan
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Kingdom.IsClan | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a8e9290608de17adde9670f3f20f4e23f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a2097f2411dd40f03fc7ef5fc1b67c89b)IsOutlaw
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Kingdom.IsOutlaw | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a8a33a52e72b116d3f18a69e8d1630878).

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#ab7421b9364612686b904c107724d2d0b)Clans
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html)> TaleWorlds.CampaignSystem.Kingdom.Clans | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a15d166c35735c16043655215469f95ba)RulingClan
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) TaleWorlds.CampaignSystem.Kingdom.RulingClan | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#ae8bdc2699c6cc75f0c8dfd1421c5b644)LastArmyCreationDay
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Kingdom.LastArmyCreationDay | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a1c682b8c50b299c66a1f826aa279b669)Armies
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Army](class_tale_worlds_1_1_campaign_system_1_1_army.html)> TaleWorlds.CampaignSystem.Kingdom.Armies | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a08884a7d24a5d3d52438aafb6de40564)CurrentTotalStrength
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Kingdom.CurrentTotalStrength | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#aee73fdfa11867859e81d4113e928882e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a5db8289fb2835d6b4c6f7c7497cff93f)FactionMidSettlement
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) TaleWorlds.CampaignSystem.Kingdom.FactionMidSettlement | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#abfa070fa70132450d9796c1ccbcdb4de).

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a3c04ac62faedae168ba97afa9eabf0ca)DistanceToClosestNonAllyFortification
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Kingdom.DistanceToClosestNonAllyFortification | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#ad855c7ce40acb58def67c1f6d078b91f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a07877eb2f0bf4837c1030d273ce17c1c)ActivePolicies
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IList<[PolicyObject](class_tale_worlds_1_1_campaign_system_1_1_policy_object.html)> TaleWorlds.CampaignSystem.Kingdom.ActivePolicies | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a0967256af4237780060e3bf155232832)All
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#aee5c208fbd67f7ddd1bda261d47df7dd)> TaleWorlds.CampaignSystem.Kingdom.All | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#acd7e60c0c4c4277877032416469163ed)LastKingdomDecisionConclusionDate
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.Kingdom.LastKingdomDecisionConclusionDate | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a37c442c544a7815c37088e25c00c0831)IsEliminated
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Kingdom.IsEliminated | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a4bd43be4f4ad1ee51589462a49b6b845).

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a0aeb0cf4d3853a9c2de4ec057a7bb784)LastMercenaryOfferTime
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.Kingdom.LastMercenaryOfferTime | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a50ac0e63494b70d48c22b261bfeb83f7)MapFaction
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) TaleWorlds.CampaignSystem.Kingdom.MapFaction | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a8b7d4e71d6c714913c63d8d0836ab17e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a13e63dba7940e472f46ae09028e7d918)NotAttackableByPlayerUntilTime
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.Kingdom.NotAttackableByPlayerUntilTime | | getset |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a31a3af7d7204cce806d98556e1c90ea6).

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a8ab549bd07af3896d7553a986a68135e)Aggressiveness
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Kingdom.Aggressiveness | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a0e7ac0db51bcf9d094fba4ae663eb8cc).

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#aa4789b380f085aa3bf7d491e4f06ff00)AllParties
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IEnumerable<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html)> TaleWorlds.CampaignSystem.Kingdom.AllParties | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a3ef5a029ed3b8dd874d2bc8046acf515)MercenaryWallet
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Kingdom.MercenaryWallet | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a25275faa070219bc98144de499861d3a)TributeWallet
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Kingdom.TributeWallet | | getset |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#afc3ee078ff477a91a33bb3faf091b6c5).

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a07d488710effc749e3a539a374792f0c)KingdomBudgetWallet
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Kingdom.KingdomBudgetWallet | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a46cf529eca76e897896aa05fe5a03626)CallToWarWallet
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Kingdom.CallToWarWallet | | getset |

