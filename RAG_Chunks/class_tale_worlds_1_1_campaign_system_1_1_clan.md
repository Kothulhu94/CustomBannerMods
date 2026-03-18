--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_clan.html ---

TaleWorlds.CampaignSystem.Clan Class ReferencesealedA Faction Object.

Inherits [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html), and [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [UpdateFactionsAtWarWith](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a2a87fda3a66f055dd9ea777207a3c29e) () |
| void | [UpdateCurrentStrength](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ac2f6c8e4e12282c87f4e4af736d76d5d) () |
| bool | [IsAtWarWith](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a6612bfd19567291fdf358d6656c0be9c) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) other) |
|  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ad6b3f147a92fce5e916e5a6ed594f06c) () |
| override void | [Deserialize](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a17886367e21588e02bbccbd3b1dfb733) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
|  | De-serializes the object from an XmlNode. |
| int | [GetRelationWithClan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#aee7b0a10f60344ccc76fbb87692708bf) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ad6b3f147a92fce5e916e5a6ed594f06c) other) |
| void | [SetLeader](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a197b90896a0ffdfb1cf1e895261b8b7e) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) leader) |
| void | [SetInitialHomeSettlement](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ac095872b688869446c45675250d25895) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) initialHomeSettlement) |
| void | [ConsiderAndUpdateHomeSettlement](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a33823f77e4b4c0dbd7087e8f354cbd19) () |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetName](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a7d3414f42d1c1ca7752f34a408217c40) () |
| void | [ChangeClanName](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ab9723f6e30b910bc20dcfd7f30e32bce) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) name, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) informalName) |
| override string | [ToString](class_tale_worlds_1_1_campaign_system_1_1_clan.html#aad92abbb3eb80d401c1dfacbee7673a1) () |
| [StanceLink](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html) | [GetStanceWith](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ab9ec5fc4ba75197819a991a11cb1f942) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) other) |
| void | [ClanLeaveKingdom](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a662455d896bb675c4aeb112d82a4be18) (bool giveBackFiefs=false) |
| float | [CalculateTotalSettlementBaseValue](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a04e0c415248a3130290314c485f82619) () |
| void | [StartMercenaryService](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a3ae9b1e4e5d2faf17db37369bda4f87f) () |
| void | [ResetPlayerHomeAndFactionMidSettlement](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a8832d8cd67ad777471e64da347e1a0ac) () |
| void | [EndMercenaryService](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a63d3d4c87fd758c0b393423e9227fce5) (bool isByLeavingKingdom) |
| float | [CalculateTotalSettlementValueForFaction](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a59629d72bbb214378fe150545f32eb40) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ac36402c3946cf25ed53a5b5d2c97225f) kingdom) |
| void | [OnHeroChangedState](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a9bdd366a6be117dc65338bb423f00a85) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [Hero.CharacterStates](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a5d97848f11b7de5bae4abd3ddaf54157) oldState) |
| void | [AddRenown](class_tale_worlds_1_1_campaign_system_1_1_clan.html#af696935c7ca989c7368e96e3789ce252) (float value, bool shouldNotify=true) |
| void | [ResetClanRenown](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a5a87064b357c26c597eafa5bb7ecafb4) () |
| void | [OnSupportedByClan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ae286c3a38c04ff0b09624d55ca6c3464) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ad6b3f147a92fce5e916e5a6ed594f06c) supporterClan) |
| void | [CalculateMidSettlement](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ab5af1aed4464197f507717257834dce1) () |
| Dictionary< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), int > | [GetHeirApparents](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a21db119d2fb8bf9a2ee3265da3d37acd) () |
| void | [UpdateBannerColor](class_tale_worlds_1_1_campaign_system_1_1_clan.html#aa1108b71ce4f929ca9954b870f8173c5) (uint backgroundColor, uint iconColor) |
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
| static [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ad6b3f147a92fce5e916e5a6ed594f06c) | [CreateClan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a2a5b437d6f450437caeaa9c51a3b4d97) (string stringID) |
| static [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ad6b3f147a92fce5e916e5a6ed594f06c) | [FindFirst](class_tale_worlds_1_1_campaign_system_1_1_clan.html#add3b6979becb23f5261814b0dc68b5d7) (Predicate< [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ad6b3f147a92fce5e916e5a6ed594f06c) > predicate) |
| static IEnumerable< [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ad6b3f147a92fce5e916e5a6ed594f06c) > | [FindAll](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a0594cce57521fa34e85b54c1f5dbf764) (Predicate< [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ad6b3f147a92fce5e916e5a6ed594f06c) > predicate) |
| static [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ad6b3f147a92fce5e916e5a6ed594f06c) | [CreateSettlementRebelClan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a3e50b6525d07e1b9678155a3d773075a) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) owner, int iconMeshId=-1) |
| static [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ad6b3f147a92fce5e916e5a6ed594f06c) | [CreateCompanionToLordClan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a6ba760d41554598a39f44a9f6f4d1602) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) clanName, int newClanIconId) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [PreAfterLoad](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a6c96ffd7de036878c352409c94e92b48) () |
| override void | [AfterLoad](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a1e0ca00d0eac281c0b5696d6dbcf07db) () |
| override void | [OnBeforeLoad](class_tale_worlds_1_1_campaign_system_1_1_clan.html#aaaddc59b4e9742c158ea43e77b3de7df) () |

|  |  |
| --- | --- |
| Properties | |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a613b28fead72df2d9308cd4d75513c94) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [InformalName](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a40ff2eba76240b1099d3fd775e447b34) `[get]` |
| [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | [Culture](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ad7aeb44daeb9526272fbfd6f299f500a) `[get, set]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [LastFactionChangeTime](class_tale_worlds_1_1_campaign_system_1_1_clan.html#aba2909eb2376731011ef40653dcab21c) `[get, set]` |
| [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) | [DefaultPartyTemplate](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a904df781218f48bbe87171d86b5d6dc1) `[get]` |
| bool | [HasNavalNavigationCapability](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a8ed4a7e849e66cb0174823bf4753b7cb) `[get]` |
| int | [AutoRecruitmentExpenses](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a1c8779cefd7c6bac1c0c284000f8b1a9) `[get, set]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [EncyclopediaText](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a63d71b6e31c7f569020009d5f65d739e) `[get]` |
| bool | [IsNoble](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a3aaa092e0bd06ca10f6e8f43ff6010e3) `[get, set]` |
| bool | [IsEliminated](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a1aa5892ad2dac251b076b820558cc78b) `[get]` |
| IList< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > | [MinorFactionCharacterTemplates](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a3bc4cec52ac1cd66e3760afae5c298e0) `[get]` |
| string | [EncyclopediaLink](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ae10486f524fe189b7fed0d51d4c260d2) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [EncyclopediaLinkWithName](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a5df2646e564887ff64e1ea2e55fb1af2) `[get]` |
| Kingdom | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ac36402c3946cf25ed53a5b5d2c97225f) `[get, set]` |
|  | Gets kingdom of this clan. |
| IEnumerable< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > | [DungeonPrisonersOfClan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a94b5a97765809814b3ec8686d78e4829) `[get]` |
| MBReadOnlyList< [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) > | [Fiefs](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a524639ce6cecd78e312ace77e9669c19) `[get]` |
| MBReadOnlyList< [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) > | [Villages](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a7306864ec4a300b053a42b41a46d1add) `[get]` |
| MBReadOnlyList< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) > | [Settlements](class_tale_worlds_1_1_campaign_system_1_1_clan.html#aaa272c580fc53756028cbfe906b7b4c1) `[get]` |
| MBReadOnlyList< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [SupporterNotables](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a39244b75d050af102700f9c62eff7963) `[get]` |
| MBReadOnlyList< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [AliveLords](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a30c856aae9855a02e5ee1b1f242b1e23) `[get]` |
| MBReadOnlyList< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [DeadLords](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a0a46b7feaff8d6cabcd7ab1bdd2c926d) `[get]` |
| MBReadOnlyList< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [Heroes](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a3cd7ce3909da67077900be6ebc4d9626) `[get]` |
| MBReadOnlyList< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [Companions](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a552541a17153640ae27e672b368701c0) `[get]` |
| MBReadOnlyList< [WarPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_war_party_component.html) > | [WarPartyComponents](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ab906a7412f9cc36ea522ecfe69454124) `[get]` |
| float | [Influence](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a3d9b7a061d831d18a60de0e1112ecd4d) `[get, set]` |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [InfluenceChangeExplained](class_tale_worlds_1_1_campaign_system_1_1_clan.html#af0b2aca46c79de9ee4cae39428a5ef07) `[get]` |
| float | [CurrentTotalStrength](class_tale_worlds_1_1_campaign_system_1_1_clan.html#abc6a580c7d54b5a6853c23c973115c50) `[get]` |
| int | [MercenaryAwardMultiplier](class_tale_worlds_1_1_campaign_system_1_1_clan.html#abc4d7d4973037fb995c0f441934f3f99) `[get, set]` |
| bool | [IsMapFaction](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a5f0227221d43db30a9bfa6e8f7075027) `[get]` |
| [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [InitialHomeSettlement](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a577f418937a1487b4493f55ab81a465c) `[get]` |
|  | Point to spawn around if no settlement remained. |
| bool | [IsRebelClan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a0188acf7497858b630b9d5f5b78faad1) `[get, set]` |
| bool | [IsMinorFaction](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a2517c04f45eef6471e604767a3ca3fb2) `[get]` |
| bool | [IsOutlaw](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a91b874d30a85b09cf032507f4cae9298) `[get]` |
| bool | [IsNomad](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ab00453b9991bea59637e0ed08df96b5f) `[get]` |
| bool | [IsMafia](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ace71a044c7ff3d2d990d91baf63a3ef1) `[get]` |
| bool | [IsClanTypeMercenary](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a6fdd0a7f51a80a1e297bcdce7a37e13b) `[get]` |
| bool | [IsSect](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ac6721a9f416bb1061c598d1dd3cda272) `[get]` |
| bool | [IsUnderMercenaryService](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a1005354445ac3381dd925f80b4238c1e) `[get]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [ShouldStayInKingdomUntil](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a11180bc9e29d2dc57fb80d6df7cb6801) `[get, set]` |
| uint | [Color](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ac33d3998b0d249872fb3e7b325374644) `[get, set]` |
|  | Primary color. |
| uint | [Color2](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a2947d54ee9f2355323b584ad362d857d) `[get, set]` |
|  | Secondary color. |
| [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [FactionMidSettlement](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ad11725cfcb820a8ed3419a28551647dd) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [BasicTroop](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a7a288a05803dcd5c0d46ceafe6c105a6) `[get, set]` |
| static [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ad6b3f147a92fce5e916e5a6ed594f06c) | [PlayerClan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#aaed8dfc0f0634146653f37ba5b6051cd) `[get]` |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [Leader](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a20cbcf84cf1e53d517e7b4b987c8f9a8) `[get]` |
| int | [Gold](class_tale_worlds_1_1_campaign_system_1_1_clan.html#adadad46ccb699552dcc558267625191d) `[get]` |
| Banner | [Banner](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a67db2832981b1969e1e04c1f486ebff5) `[get, set]` |
| [Banner](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a67db2832981b1969e1e04c1f486ebff5) | [ClanOriginalBanner](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a62ee20d1e2e1c4513a1c7536ac0e2fff) `[get]` |
| bool | [IsBanditFaction](class_tale_worlds_1_1_campaign_system_1_1_clan.html#aa8577c3151ba71c3b1ed1cd77704529d) `[get]` |
| bool | [IsClan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a59e601d02d47ea07efcddb423e37779d) `[get]` |
| float | [Renown](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ad2761ad2d13ed2c79179c823518480ed) `[get, set]` |
| float | [MainHeroCrimeRating](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ad8aa84e52914e8b8af74c41480dd7449) `[get, set]` |
| float | [DailyCrimeRatingChange](class_tale_worlds_1_1_campaign_system_1_1_clan.html#acfdd91715f733fe88896897c2d14710f) `[get]` |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [DailyCrimeRatingChangeExplained](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a00194817c65bcd6de4e05dc1c72885c9) `[get]` |
| int | [Tier](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a2cbe93fb4095030f6171950ef8f0d8a9) `[get]` |
| [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | [MapFaction](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a86874a2431a62fb7e4bf34635ba67e76) `[get]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [NotAttackableByPlayerUntilTime](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a91346e271a583674c79660ca125df613) `[get, set]` |
| float | [Aggressiveness](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a9a9a22f80ea38134a7aa2276731d091f) `[get]` |
|  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) Aggressiveness between 0 and 100 This is used for AI in evaluating peace offers and war proposals A kingdom with high aggressiveness can be declared war at without penalty. |
| int | [TributeWallet](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a87137d2e0942f8794a460776ab79b120) `[get, set]` |
|  | Gold for spending on tributes. Can be negative which means tribute debt. |
| [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [HomeSettlement](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a0a1ed05fc8010353eb8fdafe5fbca639) `[get]` |
| int | [DebtToKingdom](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a740f486d88d182ceba97c4d772a6ac77) `[get, set]` |
| MBReadOnlyList< [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) > | [FactionsAtWarWith](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ad2378153a6497ca423be6d64464e8493) `[get]` |
| int | [RenownRequirementForNextTier](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a8b2ee85bf82dbfba21b00d6ebde64a93) `[get]` |
| int | [CompanionLimit](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a84b3cffd177bec3716749c526e734301) `[get]` |
| float | [DistanceToClosestNonAllyFortification](class_tale_worlds_1_1_campaign_system_1_1_clan.html#af86e0da42e2def75da5f0c560b560c4b) `[get]` |
| int | [CommanderLimit](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a827b6c7a5cf93e92d32c33743e71db29) `[get]` |
| static MBReadOnlyList< [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ad6b3f147a92fce5e916e5a6ed594f06c) > | [All](class_tale_worlds_1_1_campaign_system_1_1_clan.html#aee465ca1dee1b751ed9bce5bbac02a71) `[get]` |
| static IEnumerable< [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ad6b3f147a92fce5e916e5a6ed594f06c) > | [NonBanditFactions](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ae819c58b17ec4c622fa1ee9628260dab) `[get]` |
| static IEnumerable< [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ad6b3f147a92fce5e916e5a6ed594f06c) > | [BanditFactions](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a623968012dd4a57207607e76e409f5bf) `[get]` |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ad6b3f147a92fce5e916e5a6ed594f06c)Clan()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Clan.Clan | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a2a87fda3a66f055dd9ea777207a3c29e)UpdateFactionsAtWarWith()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Clan.UpdateFactionsAtWarWith | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a9eb41938db901f83224cf4de4c10d65d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ac2f6c8e4e12282c87f4e4af736d76d5d)UpdateCurrentStrength()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Clan.UpdateCurrentStrength | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a6612bfd19567291fdf358d6656c0be9c)IsAtWarWith()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Clan.IsAtWarWith | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *other* | ) |  |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a6c6fed23bd3c74fc7052ca32212f989b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a2a5b437d6f450437caeaa9c51a3b4d97)CreateClan()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ad6b3f147a92fce5e916e5a6ed594f06c) TaleWorlds.CampaignSystem.Clan.CreateClan | ( | string | *stringID* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a6c96ffd7de036878c352409c94e92b48)PreAfterLoad()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Clan.PreAfterLoad | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aeddc87ee0703c7f37d9129d9a5e024e4).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a1e0ca00d0eac281c0b5696d6dbcf07db)AfterLoad()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Clan.AfterLoad | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aae8a0aa22e7a659e1edbedfe9739d413).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a17886367e21588e02bbccbd3b1dfb733)Deserialize()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Clan.Deserialize | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, | |  |  | XmlNode | *node* ) | | virtual |

Parameters
:   |  |  |
    | --- | --- |
    | objectManager | Object manager |
    | node | XmlNode to be de-serialized from. |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad1364026109401ca16d5a450d8b8f178).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#aaaddc59b4e9742c158ea43e77b3de7df)OnBeforeLoad()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Clan.OnBeforeLoad | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad32c7b22bd64e771cc05ee54ae78058a).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#aee7b0a10f60344ccc76fbb87692708bf)GetRelationWithClan()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Clan.GetRelationWithClan | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ad6b3f147a92fce5e916e5a6ed594f06c) | *other* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a197b90896a0ffdfb1cf1e895261b8b7e)SetLeader()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Clan.SetLeader | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *leader* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ac095872b688869446c45675250d25895)SetInitialHomeSettlement()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Clan.SetInitialHomeSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *initialHomeSettlement* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a33823f77e4b4c0dbd7087e8f354cbd19)ConsiderAndUpdateHomeSettlement()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Clan.ConsiderAndUpdateHomeSettlement | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a7d3414f42d1c1ca7752f34a408217c40)GetName()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Clan.GetName | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a0b72f9e386b6cefc4e6bfb52642b98db).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ab9723f6e30b910bc20dcfd7f30e32bce)ChangeClanName()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Clan.ChangeClanName | ( | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *name*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *informalName* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#aad92abbb3eb80d401c1dfacbee7673a1)ToString()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.CampaignSystem.Clan.ToString | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ab9ec5fc4ba75197819a991a11cb1f942)GetStanceWith()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [StanceLink](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html) TaleWorlds.CampaignSystem.Clan.GetStanceWith | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *other* | ) |  |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a31cfaab163c703983101158c374817bd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a662455d896bb675c4aeb112d82a4be18)ClanLeaveKingdom()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Clan.ClanLeaveKingdom | ( | bool | *giveBackFiefs* = false | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a04e0c415248a3130290314c485f82619)CalculateTotalSettlementBaseValue()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.Clan.CalculateTotalSettlementBaseValue | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a3ae9b1e4e5d2faf17db37369bda4f87f)StartMercenaryService()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Clan.StartMercenaryService | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a8832d8cd67ad777471e64da347e1a0ac)ResetPlayerHomeAndFactionMidSettlement()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Clan.ResetPlayerHomeAndFactionMidSettlement | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#add3b6979becb23f5261814b0dc68b5d7)FindFirst()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ad6b3f147a92fce5e916e5a6ed594f06c) TaleWorlds.CampaignSystem.Clan.FindFirst | ( | Predicate< [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ad6b3f147a92fce5e916e5a6ed594f06c) > | *predicate* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a63d3d4c87fd758c0b393423e9227fce5)EndMercenaryService()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Clan.EndMercenaryService | ( | bool | *isByLeavingKingdom* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a0594cce57521fa34e85b54c1f5dbf764)FindAll()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IEnumerable< [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ad6b3f147a92fce5e916e5a6ed594f06c) > TaleWorlds.CampaignSystem.Clan.FindAll | ( | Predicate< [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ad6b3f147a92fce5e916e5a6ed594f06c) > | *predicate* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a59629d72bbb214378fe150545f32eb40)CalculateTotalSettlementValueForFaction()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.Clan.CalculateTotalSettlementValueForFaction | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ac36402c3946cf25ed53a5b5d2c97225f) | *kingdom* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a9bdd366a6be117dc65338bb423f00a85)OnHeroChangedState()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Clan.OnHeroChangedState | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | [Hero.CharacterStates](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a5d97848f11b7de5bae4abd3ddaf54157) | *oldState* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#af696935c7ca989c7368e96e3789ce252)AddRenown()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Clan.AddRenown | ( | float | *value*, |
|  |  | bool | *shouldNotify* = true ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a5a87064b357c26c597eafa5bb7ecafb4)ResetClanRenown()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Clan.ResetClanRenown | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ae286c3a38c04ff0b09624d55ca6c3464)OnSupportedByClan()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Clan.OnSupportedByClan | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ad6b3f147a92fce5e916e5a6ed594f06c) | *supporterClan* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a3e50b6525d07e1b9678155a3d773075a)CreateSettlementRebelClan()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ad6b3f147a92fce5e916e5a6ed594f06c) TaleWorlds.CampaignSystem.Clan.CreateSettlementRebelClan | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *owner*, | |  |  | int | *iconMeshId* = -1 ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ab5af1aed4464197f507717257834dce1)CalculateMidSettlement()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Clan.CalculateMidSettlement | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a6ba760d41554598a39f44a9f6f4d1602)CreateCompanionToLordClan()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ad6b3f147a92fce5e916e5a6ed594f06c) TaleWorlds.CampaignSystem.Clan.CreateCompanionToLordClan | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *clanName*, | |  |  | int | *newClanIconId* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a21db119d2fb8bf9a2ee3265da3d37acd)GetHeirApparents()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| Dictionary< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), int > TaleWorlds.CampaignSystem.Clan.GetHeirApparents | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#aa1108b71ce4f929ca9954b870f8173c5)UpdateBannerColor()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Clan.UpdateBannerColor | ( | uint | *backgroundColor*, |
|  |  | uint | *iconColor* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a613b28fead72df2d9308cd4d75513c94)Name
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Clan.Name | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a5f784ac1ad0d6f6f35be72e6046ed141).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a40ff2eba76240b1099d3fd775e447b34)InformalName
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Clan.InformalName | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a4cf3bbc379619694517857dc652b7e7c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ad7aeb44daeb9526272fbfd6f299f500a)Culture
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) TaleWorlds.CampaignSystem.Clan.Culture | | getset |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#ae2410f96ee8c7b30f1e52b3d2ee81f16).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#aba2909eb2376731011ef40653dcab21c)LastFactionChangeTime
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.Clan.LastFactionChangeTime | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a904df781218f48bbe87171d86b5d6dc1)DefaultPartyTemplate
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) TaleWorlds.CampaignSystem.Clan.DefaultPartyTemplate | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a8ed4a7e849e66cb0174823bf4753b7cb)HasNavalNavigationCapability
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Clan.HasNavalNavigationCapability | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#aad52f8f4cbf0a72e71763dd91b9a85f3).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a1c8779cefd7c6bac1c0c284000f8b1a9)AutoRecruitmentExpenses
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Clan.AutoRecruitmentExpenses | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a63d71b6e31c7f569020009d5f65d739e)EncyclopediaText
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Clan.EncyclopediaText | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a88f874d82b9e917c9d409e0088b87c37).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a3aaa092e0bd06ca10f6e8f43ff6010e3)IsNoble
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Clan.IsNoble | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a1aa5892ad2dac251b076b820558cc78b)IsEliminated
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Clan.IsEliminated | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a4bd43be4f4ad1ee51589462a49b6b845).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a3bc4cec52ac1cd66e3760afae5c298e0)MinorFactionCharacterTemplates
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IList<[CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html)> TaleWorlds.CampaignSystem.Clan.MinorFactionCharacterTemplates | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ae10486f524fe189b7fed0d51d4c260d2)EncyclopediaLink
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.Clan.EncyclopediaLink | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a986ddce5831d5d053c13721a7eef7cfb).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a5df2646e564887ff64e1ea2e55fb1af2)EncyclopediaLinkWithName
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Clan.EncyclopediaLinkWithName | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a9864d4ab6d4c973ba8d922759d97ef37).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ac36402c3946cf25ed53a5b5d2c97225f)Kingdom
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Kingdom TaleWorlds.CampaignSystem.Clan.Kingdom | | getset |

Returns
:   [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) of this clan

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a94b5a97765809814b3ec8686d78e4829)DungeonPrisonersOfClan
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IEnumerable<[CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html)> TaleWorlds.CampaignSystem.Clan.DungeonPrisonersOfClan | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a524639ce6cecd78e312ace77e9669c19)Fiefs
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html)> TaleWorlds.CampaignSystem.Clan.Fiefs | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a8f01e78bf362dde0be33ecbfe981e2bc).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a7306864ec4a300b053a42b41a46d1add)Villages
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html)> TaleWorlds.CampaignSystem.Clan.Villages | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#aaa272c580fc53756028cbfe906b7b4c1)Settlements
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html)> TaleWorlds.CampaignSystem.Clan.Settlements | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a70a79e7493da2c485091613765a2e393).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a39244b75d050af102700f9c62eff7963)SupporterNotables
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.Clan.SupporterNotables | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a30c856aae9855a02e5ee1b1f242b1e23)AliveLords
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.Clan.AliveLords | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a1d500e13b5fc9ba908e86fca15d17479).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a0a46b7feaff8d6cabcd7ab1bdd2c926d)DeadLords
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.Clan.DeadLords | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a104b43add616b8c1971278024d17e1fb).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a3cd7ce3909da67077900be6ebc4d9626)Heroes
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.Clan.Heroes | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a08d0e35922305b50a4d164dbda13f69b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a552541a17153640ae27e672b368701c0)Companions
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.Clan.Companions | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ab906a7412f9cc36ea522ecfe69454124)WarPartyComponents
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[WarPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_war_party_component.html)> TaleWorlds.CampaignSystem.Clan.WarPartyComponents | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a7d4417c64aef6853c03ff9914ca366a9).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a3d9b7a061d831d18a60de0e1112ecd4d)Influence
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Clan.Influence | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#af0b2aca46c79de9ee4cae39428a5ef07)InfluenceChangeExplained
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.Clan.InfluenceChangeExplained | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#abc6a580c7d54b5a6853c23c973115c50)CurrentTotalStrength
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Clan.CurrentTotalStrength | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#aee73fdfa11867859e81d4113e928882e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#abc4d7d4973037fb995c0f441934f3f99)MercenaryAwardMultiplier
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Clan.MercenaryAwardMultiplier | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a5f0227221d43db30a9bfa6e8f7075027)IsMapFaction
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Clan.IsMapFaction | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a9b4e8d3c6f24bc9f39bc6f94e1282b00).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a577f418937a1487b4493f55ab81a465c)InitialHomeSettlement
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) TaleWorlds.CampaignSystem.Clan.InitialHomeSettlement | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a63679ff6ee7ea0b404f345a70751319f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a0188acf7497858b630b9d5f5b78faad1)IsRebelClan
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Clan.IsRebelClan | | getset |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a7394d297c6dc0c8a6eee33568d0a3660).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a2517c04f45eef6471e604767a3ca3fb2)IsMinorFaction
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Clan.IsMinorFaction | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#af634d54fdfb210a30b6d8f2adc004aee).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a91b874d30a85b09cf032507f4cae9298)IsOutlaw
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Clan.IsOutlaw | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a8a33a52e72b116d3f18a69e8d1630878).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ab00453b9991bea59637e0ed08df96b5f)IsNomad
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Clan.IsNomad | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ace71a044c7ff3d2d990d91baf63a3ef1)IsMafia
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Clan.IsMafia | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a6fdd0a7f51a80a1e297bcdce7a37e13b)IsClanTypeMercenary
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Clan.IsClanTypeMercenary | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ac6721a9f416bb1061c598d1dd3cda272)IsSect
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Clan.IsSect | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a1005354445ac3381dd925f80b4238c1e)IsUnderMercenaryService
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Clan.IsUnderMercenaryService | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a11180bc9e29d2dc57fb80d6df7cb6801)ShouldStayInKingdomUntil
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.Clan.ShouldStayInKingdomUntil | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ac33d3998b0d249872fb3e7b325374644)Color
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.CampaignSystem.Clan.Color | | getset |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a6e2ed7c768fae2b87e044da226d93563).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a2947d54ee9f2355323b584ad362d857d)Color2
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.CampaignSystem.Clan.Color2 | | getset |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a56e2229912dd58aaf4b299c4d984a62c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ad11725cfcb820a8ed3419a28551647dd)FactionMidSettlement
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) TaleWorlds.CampaignSystem.Clan.FactionMidSettlement | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#abfa070fa70132450d9796c1ccbcdb4de).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a7a288a05803dcd5c0d46ceafe6c105a6)BasicTroop
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.Clan.BasicTroop | | getset |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#aa55cb1d9700f0221f010ea419aacf04c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#aaed8dfc0f0634146653f37ba5b6051cd)PlayerClan
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ad6b3f147a92fce5e916e5a6ed594f06c) TaleWorlds.CampaignSystem.Clan.PlayerClan | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a20cbcf84cf1e53d517e7b4b987c8f9a8)Leader
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.Clan.Leader | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a861dcc20e19e6cff88df2fbf3179ae21).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#adadad46ccb699552dcc558267625191d)Gold
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Clan.Gold | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a67db2832981b1969e1e04c1f486ebff5)Banner
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Banner TaleWorlds.CampaignSystem.Clan.Banner | | getset |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a4bea19ae8ce9e5dd579aa6a442b8199f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a62ee20d1e2e1c4513a1c7536ac0e2fff)ClanOriginalBanner
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Banner](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a67db2832981b1969e1e04c1f486ebff5) TaleWorlds.CampaignSystem.Clan.ClanOriginalBanner | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#aa8577c3151ba71c3b1ed1cd77704529d)IsBanditFaction
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Clan.IsBanditFaction | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a2120a9dbeb33a301dbd0ed4992e27f6b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a59e601d02d47ea07efcddb423e37779d)IsClan
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Clan.IsClan | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a8e9290608de17adde9670f3f20f4e23f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ad2761ad2d13ed2c79179c823518480ed)Renown
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Clan.Renown | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ad8aa84e52914e8b8af74c41480dd7449)MainHeroCrimeRating
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Clan.MainHeroCrimeRating | | getset |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#aa1d37a376a80a9ca6ed1fe72ae13aca3).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#acfdd91715f733fe88896897c2d14710f)DailyCrimeRatingChange
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Clan.DailyCrimeRatingChange | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a10b0e5dd46137f2cb69a3d911ab18de0).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a00194817c65bcd6de4e05dc1c72885c9)DailyCrimeRatingChangeExplained
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.Clan.DailyCrimeRatingChangeExplained | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a2778102953d812a716878a620f155ec6).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a2cbe93fb4095030f6171950ef8f0d8a9)Tier
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Clan.Tier | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a86874a2431a62fb7e4bf34635ba67e76)MapFaction
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) TaleWorlds.CampaignSystem.Clan.MapFaction | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a8b7d4e71d6c714913c63d8d0836ab17e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a91346e271a583674c79660ca125df613)NotAttackableByPlayerUntilTime
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.Clan.NotAttackableByPlayerUntilTime | | getset |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a31a3af7d7204cce806d98556e1c90ea6).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a9a9a22f80ea38134a7aa2276731d091f)Aggressiveness
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Clan.Aggressiveness | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a0e7ac0db51bcf9d094fba4ae663eb8cc).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a87137d2e0942f8794a460776ab79b120)TributeWallet
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Clan.TributeWallet | | getset |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#afc3ee078ff477a91a33bb3faf091b6c5).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a0a1ed05fc8010353eb8fdafe5fbca639)HomeSettlement
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) TaleWorlds.CampaignSystem.Clan.HomeSettlement | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a740f486d88d182ceba97c4d772a6ac77)DebtToKingdom
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Clan.DebtToKingdom | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ad2378153a6497ca423be6d64464e8493)FactionsAtWarWith
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html)> TaleWorlds.CampaignSystem.Clan.FactionsAtWarWith | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a6f8fa8bfd88d5de9108d92b5001c132b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a8b2ee85bf82dbfba21b00d6ebde64a93)RenownRequirementForNextTier
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Clan.RenownRequirementForNextTier | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a84b3cffd177bec3716749c526e734301)CompanionLimit
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Clan.CompanionLimit | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#af86e0da42e2def75da5f0c560b560c4b)DistanceToClosestNonAllyFortification
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Clan.DistanceToClosestNonAllyFortification | | get |

Implements [TaleWorlds.CampaignSystem.IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#ad855c7ce40acb58def67c1f6d078b91f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a827b6c7a5cf93e92d32c33743e71db29)CommanderLimit
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Clan.CommanderLimit | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#aee465ca1dee1b751ed9bce5bbac02a71)All
---------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ad6b3f147a92fce5e916e5a6ed594f06c)> TaleWorlds.CampaignSystem.Clan.All | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ae819c58b17ec4c622fa1ee9628260dab)NonBanditFactions
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IEnumerable<[Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ad6b3f147a92fce5e916e5a6ed594f06c)> TaleWorlds.CampaignSystem.Clan.NonBanditFactions | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a623968012dd4a57207607e76e409f5bf)BanditFactions
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IEnumerable<[Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ad6b3f147a92fce5e916e5a6ed594f06c)> TaleWorlds.CampaignSystem.Clan.BanditFactions | | staticget |

