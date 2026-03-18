--- SOURCE: interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html ---

TaleWorlds.CampaignSystem.IFaction Interface ReferenceInherited by [TaleWorlds.CampaignSystem.Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html), and [TaleWorlds.CampaignSystem.Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| bool | [IsAtWarWith](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a6c6fed23bd3c74fc7052ca32212f989b) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) other) |
| [StanceLink](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html) | [GetStanceWith](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a31cfaab163c703983101158c374817bd) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) other) |
| void | [UpdateFactionsAtWarWith](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a9eb41938db901f83224cf4de4c10d65d) () |

|  |  |
| --- | --- |
| Properties | |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a5f784ac1ad0d6f6f35be72e6046ed141) `[get]` |
| string | [StringId](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a63f07d9b261a337398089def512aa650) `[get]` |
| [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html) | [Id](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#acb2318a9caabaee60af3433cf9097e42) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [InformalName](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a4cf3bbc379619694517857dc652b7e7c) `[get]` |
| string | [EncyclopediaLink](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a986ddce5831d5d053c13721a7eef7cfb) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [EncyclopediaLinkWithName](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a9864d4ab6d4c973ba8d922759d97ef37) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [EncyclopediaText](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a88f874d82b9e917c9d409e0088b87c37) `[get]` |
| [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | [Culture](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#ae2410f96ee8c7b30f1e52b3d2ee81f16) `[get]` |
| [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [InitialHomeSettlement](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a63679ff6ee7ea0b404f345a70751319f) `[get]` |
|  | Point to spawn around if no settlement remained. |
| uint | [Color](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a6e2ed7c768fae2b87e044da226d93563) `[get]` |
| uint | [Color2](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a56e2229912dd58aaf4b299c4d984a62c) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [BasicTroop](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#aa55cb1d9700f0221f010ea419aacf04c) `[get]` |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [Leader](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a861dcc20e19e6cff88df2fbf3179ae21) `[get]` |
| Banner | [Banner](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a4bea19ae8ce9e5dd579aa6a442b8199f) `[get]` |
| MBReadOnlyList< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) > | [Settlements](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a70a79e7493da2c485091613765a2e393) `[get]` |
| MBReadOnlyList< [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) > | [Fiefs](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a8f01e78bf362dde0be33ecbfe981e2bc) `[get]` |
| MBReadOnlyList< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [AliveLords](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a1d500e13b5fc9ba908e86fca15d17479) `[get]` |
| MBReadOnlyList< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [DeadLords](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a104b43add616b8c1971278024d17e1fb) `[get]` |
| MBReadOnlyList< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [Heroes](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a08d0e35922305b50a4d164dbda13f69b) `[get]` |
| MBReadOnlyList< [WarPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_war_party_component.html) > | [WarPartyComponents](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a7d4417c64aef6853c03ff9914ca366a9) `[get]` |
| bool | [IsBanditFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a2120a9dbeb33a301dbd0ed4992e27f6b) `[get]` |
| bool | [IsMinorFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#af634d54fdfb210a30b6d8f2adc004aee) `[get]` |
| bool | [IsKingdomFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#ac922c3656db1f24bab6d282b27f16262) `[get]` |
| bool | [IsRebelClan](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a7394d297c6dc0c8a6eee33568d0a3660) `[get]` |
| bool | [IsClan](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a8e9290608de17adde9670f3f20f4e23f) `[get]` |
| bool | [IsOutlaw](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a8a33a52e72b116d3f18a69e8d1630878) `[get]` |
| bool | [IsMapFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a9b4e8d3c6f24bc9f39bc6f94e1282b00) `[get]` |
| bool | [HasNavalNavigationCapability](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#aad52f8f4cbf0a72e71763dd91b9a85f3) `[get]` |
| [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | [MapFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a8b7d4e71d6c714913c63d8d0836ab17e) `[get]` |
| float | [CurrentTotalStrength](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#aee73fdfa11867859e81d4113e928882e) `[get]` |
| [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [FactionMidSettlement](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#abfa070fa70132450d9796c1ccbcdb4de) `[get]` |
| float | [DistanceToClosestNonAllyFortification](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#ad855c7ce40acb58def67c1f6d078b91f) `[get]` |
| MBReadOnlyList< [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) > | [FactionsAtWarWith](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a6f8fa8bfd88d5de9108d92b5001c132b) `[get]` |
| int | [TributeWallet](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#afc3ee078ff477a91a33bb3faf091b6c5) `[get, set]` |
|  | Gold for spending on tributes. Can be negative which means tribute debt. |
| float | [MainHeroCrimeRating](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#aa1d37a376a80a9ca6ed1fe72ae13aca3) `[get, set]` |
| float | [DailyCrimeRatingChange](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a10b0e5dd46137f2cb69a3d911ab18de0) `[get]` |
| float | [Aggressiveness](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a0e7ac0db51bcf9d094fba4ae663eb8cc) `[get]` |
| bool | [IsEliminated](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a4bd43be4f4ad1ee51589462a49b6b845) `[get]` |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [DailyCrimeRatingChangeExplained](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a2778102953d812a716878a620f155ec6) `[get]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [NotAttackableByPlayerUntilTime](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a31a3af7d7204cce806d98556e1c90ea6) `[get, set]` |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a6c6fed23bd3c74fc7052ca32212f989b)IsAtWarWith()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.IFaction.IsAtWarWith | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *other* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a6612bfd19567291fdf358d6656c0be9c), and [TaleWorlds.CampaignSystem.Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a8a7c0f795a5fbecc966957739454efc5).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a31cfaab163c703983101158c374817bd)GetStanceWith()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [StanceLink](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html) TaleWorlds.CampaignSystem.IFaction.GetStanceWith | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *other* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ab9ec5fc4ba75197819a991a11cb1f942), and [TaleWorlds.CampaignSystem.Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a6603d9a85b1ef6e8c041ed170672d410).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a9eb41938db901f83224cf4de4c10d65d)UpdateFactionsAtWarWith()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.IFaction.UpdateFactionsAtWarWith | ( |  | ) |  |

Implemented in [TaleWorlds.CampaignSystem.Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a2a87fda3a66f055dd9ea777207a3c29e), and [TaleWorlds.CampaignSystem.Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a99350b0d3f8dc7688c44e9188605580b).

Property Documentation
----------------------

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a5f784ac1ad0d6f6f35be72e6046ed141)Name
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.IFaction.Name | | get |

Implemented in [TaleWorlds.CampaignSystem.Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a613b28fead72df2d9308cd4d75513c94), and [TaleWorlds.CampaignSystem.Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#aff8bed440c8a9d7be0645f215712044c).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a63f07d9b261a337398089def512aa650)StringId
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.IFaction.StringId | | get |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#acb2318a9caabaee60af3433cf9097e42)Id
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html) TaleWorlds.CampaignSystem.IFaction.Id | | get |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a4cf3bbc379619694517857dc652b7e7c)InformalName
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.IFaction.InformalName | | get |

Implemented in [TaleWorlds.CampaignSystem.Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a40ff2eba76240b1099d3fd775e447b34), and [TaleWorlds.CampaignSystem.Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#ae0ac4f1f4b39c718266eb9fb3cfbb592).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a986ddce5831d5d053c13721a7eef7cfb)EncyclopediaLink
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.IFaction.EncyclopediaLink | | get |

Implemented in [TaleWorlds.CampaignSystem.Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ae10486f524fe189b7fed0d51d4c260d2), and [TaleWorlds.CampaignSystem.Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#acb0aa5aaa20d0239bd1c0563e28ebe5e).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a9864d4ab6d4c973ba8d922759d97ef37)EncyclopediaLinkWithName
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.IFaction.EncyclopediaLinkWithName | | get |

Implemented in [TaleWorlds.CampaignSystem.Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a5df2646e564887ff64e1ea2e55fb1af2), and [TaleWorlds.CampaignSystem.Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a2feb5cd3120b37252f4178d5dfa32bd3).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a88f874d82b9e917c9d409e0088b87c37)EncyclopediaText
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.IFaction.EncyclopediaText | | get |

Implemented in [TaleWorlds.CampaignSystem.Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a63d71b6e31c7f569020009d5f65d739e), and [TaleWorlds.CampaignSystem.Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a91cb4b8ee56727fd1fc0be53efe1b99c).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#ae2410f96ee8c7b30f1e52b3d2ee81f16)Culture
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) TaleWorlds.CampaignSystem.IFaction.Culture | | get |

Implemented in [TaleWorlds.CampaignSystem.Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ad7aeb44daeb9526272fbfd6f299f500a), and [TaleWorlds.CampaignSystem.Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#aa1839c63aa74f2a15a74a3f374d668c3).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a63679ff6ee7ea0b404f345a70751319f)InitialHomeSettlement
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) TaleWorlds.CampaignSystem.IFaction.InitialHomeSettlement | | get |

Implemented in [TaleWorlds.CampaignSystem.Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a577f418937a1487b4493f55ab81a465c), and [TaleWorlds.CampaignSystem.Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a88b6ea5fc8e53b1e90d4da39282b6e42).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a6e2ed7c768fae2b87e044da226d93563)Color
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.CampaignSystem.IFaction.Color | | get |

Implemented in [TaleWorlds.CampaignSystem.Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ac33d3998b0d249872fb3e7b325374644), and [TaleWorlds.CampaignSystem.Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a88a5e104eac12d94c60ff8701be0369f).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a56e2229912dd58aaf4b299c4d984a62c)Color2
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.CampaignSystem.IFaction.Color2 | | get |

Implemented in [TaleWorlds.CampaignSystem.Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a2947d54ee9f2355323b584ad362d857d), and [TaleWorlds.CampaignSystem.Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a7f20e79358d5ecfaa28b9880b4100731).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#aa55cb1d9700f0221f010ea419aacf04c)BasicTroop
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.IFaction.BasicTroop | | get |

Implemented in [TaleWorlds.CampaignSystem.Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a7a288a05803dcd5c0d46ceafe6c105a6), and [TaleWorlds.CampaignSystem.Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a56f97e214750523d045d37509876a3ac).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a861dcc20e19e6cff88df2fbf3179ae21)Leader
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.IFaction.Leader | | get |

Implemented in [TaleWorlds.CampaignSystem.Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a20cbcf84cf1e53d517e7b4b987c8f9a8), and [TaleWorlds.CampaignSystem.Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a57f60051f5dcc8b50b825282d3e9e087).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a4bea19ae8ce9e5dd579aa6a442b8199f)Banner
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Banner TaleWorlds.CampaignSystem.IFaction.Banner | | get |

Implemented in [TaleWorlds.CampaignSystem.Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a67db2832981b1969e1e04c1f486ebff5), and [TaleWorlds.CampaignSystem.Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#aea517699592941bff83f50339fd93de2).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a70a79e7493da2c485091613765a2e393)Settlements
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html)> TaleWorlds.CampaignSystem.IFaction.Settlements | | get |

Implemented in [TaleWorlds.CampaignSystem.Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#aaa272c580fc53756028cbfe906b7b4c1), and [TaleWorlds.CampaignSystem.Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a791e435e94eb4df1265a5721d51950bc).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a8f01e78bf362dde0be33ecbfe981e2bc)Fiefs
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html)> TaleWorlds.CampaignSystem.IFaction.Fiefs | | get |

Implemented in [TaleWorlds.CampaignSystem.Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a524639ce6cecd78e312ace77e9669c19), and [TaleWorlds.CampaignSystem.Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a405f907f00ea270f3d932ad606cfc630).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a1d500e13b5fc9ba908e86fca15d17479)AliveLords
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.IFaction.AliveLords | | get |

Implemented in [TaleWorlds.CampaignSystem.Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a30c856aae9855a02e5ee1b1f242b1e23), and [TaleWorlds.CampaignSystem.Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a7c1f8bde16e8bc3dbafe80b2490def5b).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a104b43add616b8c1971278024d17e1fb)DeadLords
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.IFaction.DeadLords | | get |

Implemented in [TaleWorlds.CampaignSystem.Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a0a46b7feaff8d6cabcd7ab1bdd2c926d), and [TaleWorlds.CampaignSystem.Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#adb42006d2148634cabb6778c187721d7).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a08d0e35922305b50a4d164dbda13f69b)Heroes
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.IFaction.Heroes | | get |

Implemented in [TaleWorlds.CampaignSystem.Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a3cd7ce3909da67077900be6ebc4d9626), and [TaleWorlds.CampaignSystem.Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a04ab4d0ceb1bdc02596d5967b1ed5b12).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a7d4417c64aef6853c03ff9914ca366a9)WarPartyComponents
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[WarPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_war_party_component.html)> TaleWorlds.CampaignSystem.IFaction.WarPartyComponents | | get |

Implemented in [TaleWorlds.CampaignSystem.Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ab906a7412f9cc36ea522ecfe69454124), and [TaleWorlds.CampaignSystem.Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a325b2dc7186e2bed522decde2462cc48).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a2120a9dbeb33a301dbd0ed4992e27f6b)IsBanditFaction
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.IFaction.IsBanditFaction | | get |

Implemented in [TaleWorlds.CampaignSystem.Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#aa8577c3151ba71c3b1ed1cd77704529d), and [TaleWorlds.CampaignSystem.Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a1521fca91f795d8e359ee4387f898323).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#af634d54fdfb210a30b6d8f2adc004aee)IsMinorFaction
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.IFaction.IsMinorFaction | | get |

Implemented in [TaleWorlds.CampaignSystem.Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a2517c04f45eef6471e604767a3ca3fb2), and [TaleWorlds.CampaignSystem.Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#aeeb66450a7a3a82f14b40683ddf618fa).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#ac922c3656db1f24bab6d282b27f16262)IsKingdomFaction
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.IFaction.IsKingdomFaction | | get |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a7394d297c6dc0c8a6eee33568d0a3660)IsRebelClan
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.IFaction.IsRebelClan | | get |

Implemented in [TaleWorlds.CampaignSystem.Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a0188acf7497858b630b9d5f5b78faad1), and [TaleWorlds.CampaignSystem.Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a0876480a7ca89ded755deda4d72ae450).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a8e9290608de17adde9670f3f20f4e23f)IsClan
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.IFaction.IsClan | | get |

Implemented in [TaleWorlds.CampaignSystem.Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a59e601d02d47ea07efcddb423e37779d), and [TaleWorlds.CampaignSystem.Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#ac1d3e239df64933f2f6f7fae1af3e944).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a8a33a52e72b116d3f18a69e8d1630878)IsOutlaw
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.IFaction.IsOutlaw | | get |

Implemented in [TaleWorlds.CampaignSystem.Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a91b874d30a85b09cf032507f4cae9298), and [TaleWorlds.CampaignSystem.Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a2097f2411dd40f03fc7ef5fc1b67c89b).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a9b4e8d3c6f24bc9f39bc6f94e1282b00)IsMapFaction
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.IFaction.IsMapFaction | | get |

Implemented in [TaleWorlds.CampaignSystem.Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a5f0227221d43db30a9bfa6e8f7075027), and [TaleWorlds.CampaignSystem.Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a1f167267b8c8e999b48eaad1cdea440e).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#aad52f8f4cbf0a72e71763dd91b9a85f3)HasNavalNavigationCapability
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.IFaction.HasNavalNavigationCapability | | get |

Implemented in [TaleWorlds.CampaignSystem.Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a8ed4a7e849e66cb0174823bf4753b7cb), and [TaleWorlds.CampaignSystem.Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a4d2953c2db88377d8a3904e8046dc20d).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a8b7d4e71d6c714913c63d8d0836ab17e)MapFaction
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) TaleWorlds.CampaignSystem.IFaction.MapFaction | | get |

Implemented in [TaleWorlds.CampaignSystem.Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a86874a2431a62fb7e4bf34635ba67e76), and [TaleWorlds.CampaignSystem.Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a50ac0e63494b70d48c22b261bfeb83f7).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#aee73fdfa11867859e81d4113e928882e)CurrentTotalStrength
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.IFaction.CurrentTotalStrength | | get |

Implemented in [TaleWorlds.CampaignSystem.Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#abc6a580c7d54b5a6853c23c973115c50), and [TaleWorlds.CampaignSystem.Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a08884a7d24a5d3d52438aafb6de40564).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#abfa070fa70132450d9796c1ccbcdb4de)FactionMidSettlement
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) TaleWorlds.CampaignSystem.IFaction.FactionMidSettlement | | get |

Implemented in [TaleWorlds.CampaignSystem.Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ad11725cfcb820a8ed3419a28551647dd), and [TaleWorlds.CampaignSystem.Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a5db8289fb2835d6b4c6f7c7497cff93f).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#ad855c7ce40acb58def67c1f6d078b91f)DistanceToClosestNonAllyFortification
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.IFaction.DistanceToClosestNonAllyFortification | | get |

Implemented in [TaleWorlds.CampaignSystem.Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#af86e0da42e2def75da5f0c560b560c4b), and [TaleWorlds.CampaignSystem.Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a3c04ac62faedae168ba97afa9eabf0ca).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a6f8fa8bfd88d5de9108d92b5001c132b)FactionsAtWarWith
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html)> TaleWorlds.CampaignSystem.IFaction.FactionsAtWarWith | | get |

Implemented in [TaleWorlds.CampaignSystem.Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ad2378153a6497ca423be6d64464e8493), and [TaleWorlds.CampaignSystem.Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#ae1a4cff6885982e1a97fcd8204f85c35).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#afc3ee078ff477a91a33bb3faf091b6c5)TributeWallet
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.IFaction.TributeWallet | | getset |

Implemented in [TaleWorlds.CampaignSystem.Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a87137d2e0942f8794a460776ab79b120), and [TaleWorlds.CampaignSystem.Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a25275faa070219bc98144de499861d3a).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#aa1d37a376a80a9ca6ed1fe72ae13aca3)MainHeroCrimeRating
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.IFaction.MainHeroCrimeRating | | getset |

Implemented in [TaleWorlds.CampaignSystem.Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#ad8aa84e52914e8b8af74c41480dd7449), and [TaleWorlds.CampaignSystem.Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a96554cc32fba8b6819a0737785dddc03).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a10b0e5dd46137f2cb69a3d911ab18de0)DailyCrimeRatingChange
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.IFaction.DailyCrimeRatingChange | | get |

Implemented in [TaleWorlds.CampaignSystem.Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#acfdd91715f733fe88896897c2d14710f), and [TaleWorlds.CampaignSystem.Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#ae5ebaa126cf1fc0380069a4bb6b42274).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a0e7ac0db51bcf9d094fba4ae663eb8cc)Aggressiveness
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.IFaction.Aggressiveness | | get |

Implemented in [TaleWorlds.CampaignSystem.Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a9a9a22f80ea38134a7aa2276731d091f), and [TaleWorlds.CampaignSystem.Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a8ab549bd07af3896d7553a986a68135e).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a4bd43be4f4ad1ee51589462a49b6b845)IsEliminated
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.IFaction.IsEliminated | | get |

Implemented in [TaleWorlds.CampaignSystem.Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a1aa5892ad2dac251b076b820558cc78b), and [TaleWorlds.CampaignSystem.Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a37c442c544a7815c37088e25c00c0831).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a2778102953d812a716878a620f155ec6)DailyCrimeRatingChangeExplained
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.IFaction.DailyCrimeRatingChangeExplained | | get |

Implemented in [TaleWorlds.CampaignSystem.Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a00194817c65bcd6de4e05dc1c72885c9), and [TaleWorlds.CampaignSystem.Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#ae84b9ec4ac858f2b051a585dc810e344).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html#a31a3af7d7204cce806d98556e1c90ea6)NotAttackableByPlayerUntilTime
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.IFaction.NotAttackableByPlayerUntilTime | | getset |

Implemented in [TaleWorlds.CampaignSystem.Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html#a91346e271a583674c79660ca125df613), and [TaleWorlds.CampaignSystem.Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html#a13e63dba7940e472f46ae09028e7d918).

