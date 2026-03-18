--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html ---

TaleWorlds.CampaignSystem.Settlements.Village Class ReferenceInherits [TaleWorlds.CampaignSystem.Settlements.SettlementComponent](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [VillageStates](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ac15d9b68ef9ed2cc6fee07fd243c46e1) {     [Normal](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ac15d9b68ef9ed2cc6fee07fd243c46e1a960b44c579bc2f6818d2daaf9e4c16f0) ,     [BeingRaided](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ac15d9b68ef9ed2cc6fee07fd243c46e1af09794e7f4311fed0fcab0a2cb86a320) ,     [ForcedForVolunteers](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ac15d9b68ef9ed2cc6fee07fd243c46e1ad16401c2801fe12ddb4e6db9f5c6ffa4) ,     [ForcedForSupplies](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ac15d9b68ef9ed2cc6fee07fd243c46e1ab5720656f6804d47bcf3a6e2ae50bd6e) ,     [Looted](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ac15d9b68ef9ed2cc6fee07fd243c46e1a0c4627cbdcf2f679c3c6384e693e8c7c)   } |
| Public Types inherited from [TaleWorlds.CampaignSystem.Settlements.SettlementComponent](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html) | |
| enum | [ProsperityLevel](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ae30632ba32887c9c0ab8dab569115a7b) {     [Low](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ae30632ba32887c9c0ab8dab569115a7ba28d0edd045e05cf5af64e35ae0c4c6ef) ,     [Mid](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ae30632ba32887c9c0ab8dab569115a7ba55c6b09cbca39ef0cdb728eb112a5049) ,     [High](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ae30632ba32887c9c0ab8dab569115a7ba655d20c1ca69519ca647684edbb2db35) ,     [NumberOfLevels](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ae30632ba32887c9c0ab8dab569115a7baed0c129a39c54d57454d41af37becc40)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| IEnumerable< [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > | [GetDefenderParties](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a85eac4c8b23db82e4590089ff934e2f5) (MapEvent.BattleTypes battleType) |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | [GetNextDefenderParty](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a271ac774b35443b79ac470a2c41636df) (ref int partyIndex, MapEvent.BattleTypes battleType) |
|  | [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ab9a26b54b78686ffcf3593984a7b8a9e) () |
| void | [DailyTick](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ad193b346e982c162b0369f236badb63c) () |
| override void | [OnInit](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a533a97db06948dc5077aabadec534e1e) () |
| int | [GetWarehouseCapacity](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a7969cad3418945d93763d6711553f9e7) () |
| override int | [GetItemPrice](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a0e7ce7e21d83dbd2b081ca871f9fe62d) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) tradingParty=null, bool isSelling=false) |
| override int | [GetItemPrice](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a20a59806ca3a21147e7567ec9c9ae583) ([EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) itemRosterElement, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) tradingParty=null, bool isSelling=false) |
| override string | [ToString](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#af64f5fb07fd05941492082eb183535ec) () |
| override void | [Deserialize](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a1b3ecd9b3135fb5999e061d34782bcb1) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
| bool | [IsProducing](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a740d9e891c1757080b8418c9a1ecd855) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item) |
| int | [GetHearthLevel](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ad23fdacbaeae1949fb8c353a6edf2b72) () |
| override [ProsperityLevel](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ae30632ba32887c9c0ab8dab569115a7b) | [GetProsperityLevel](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#afe6ab43610f47871f344e402a423f583) () |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.Settlements.SettlementComponent](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html) | |
| virtual [Banner](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a19ddd822f9886170d976fc7710e30808) | [GetDefaultComponentBanner](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a5c6eaac236fefeb5fa9d53b2bbb79807) () |
| virtual void | [OnPartyEntered](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a66828262ea64df8e73e7535dc785b436) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| virtual void | [OnPartyLeft](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a5441174fb66ec365807bde68a3d20c55) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| virtual void | [OnSessionStart](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a8ae1cd2fa6596915ebae54770ac53100) () |
| void | [ChangeGold](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a7d3a0c0342730ed899e6b2fbbeb3a2f5) (int changeAmount) |
| int | [GetNumberOfTroops](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#af1ecbfef4b80916a688e8cd1aaae1476) () |
| virtual void | [OnRelatedPartyRemoved](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a0f59e449ec0b48c740b36c7542e3d9a9) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| List< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > | [GetPrisonerHeroes](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ab0a2a9a2eb647064853ee4e1556276c4) () |
| Public Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a520e657fd5a750c8b7e2154b0f5629ea) () |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a134c5e806ba735219710d773e7075b00) (MBObjectBase other) |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8e3c1b47f5d928e64d9d67fa7864c364) (string stringId) |
| void | [AfterInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab67141737ce51fe724e4a5b8026a973b) () |
| virtual void | [AfterRegister](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab15f91cc9dbb7ff8763eec828c179216) () |
| virtual void | [Initialize](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aad39d5ca82d85853a9879e2670dd036e) () |
| override int | [GetHashCode](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a68e79a07f136aae5be4fe9eadb612def) () |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetName](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a0b72f9e386b6cefc4e6bfb52642b98db) () |
| void | [PreAfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af26d64a79291c4f6328fc151d2569ebf) () |
| void | [AfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a277b54134c76732e443019a7862cf388) () |
| void | [OnRegistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a586208e92e5041fd432127305aa8af16) () |
| void | [OnUnregistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a71bef09af9a896246fa7b18c324e565c) () |

|  |  |
| --- | --- |
| Public Attributes | |
| VillagerPartyComponent | [VillagerPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ab058d58fab70ff5c85722168c3246e3a) |
| VillageType | [VillageType](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#acc3fee343e51b98d9a0037cb9b304099) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const int | [MidHearthThreshold](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a75ba47bd4850a9ad61dd43a0edcc3727) = 600 |
| const int | [LowHearthThreshold](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a477402dcd598dad64676cc5f06b4d3f6) = 200 |
| const int | [NumberOfDaysToFillVillageStocks](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a6a4d4ce3d5a9115b300cca74e077510e) = 5 |

|  |  |
| --- | --- |
| Properties | |
| static MBReadOnlyList< [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ab9a26b54b78686ffcf3593984a7b8a9e) > | [All](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a3b6d08ea24c3693d4e1d06f907ba37f6) `[get]` |
| [VillageStates](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ac15d9b68ef9ed2cc6fee07fd243c46e1) | [VillageState](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a40ec421955752ca69b49b2aa32fda178) `[get, set]` |
| bool | [IsDeserted](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a36bd84c06527d8e392150090a000ca14) `[get]` |
| float | [LastDemandSatisfiedTime](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a5de074c2c14b86b61071128d086f8989) `[get]` |
| [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a0bfa0435170396579fed99c5eb2abff2) | [Bound](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a8d5eba7d889f4cdbec61361e2edbe726) `[get]` |
| [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a0bfa0435170396579fed99c5eb2abff2) | [TradeBound](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ae04ad61bfd87017b57860e93bdd1a191) `[get, set]` |
| override [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | [MapFaction](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a834e3fbd6066ad71fec07abb8b3f09d5) `[get]` |
| [VillageMarketData](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village_market_data.html) | [MarketData](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#aaf49e5a18420f985b5985733926e505a) `[get]` |
| float | [Hearth](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a470f0eee6629bc0f904ef5f9a1063628) `[get, set]` |
| int | [TradeTaxAccumulated](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a76f62ab120a971e1109af7a11c4d7d40) `[get, set]` |
| float | [HearthChange](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a77d79cd0e4a74c51677c37d924cbbfd0) `[get]` |
| float | [Militia](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a39579b2f844c171ec47d6003bec4f300) `[get]` |
| float | [MilitiaChange](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a8e9357e063b87ee13b507fa85a0ad5af) `[get]` |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [MilitiaChangeExplanation](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ad0b338e7e35f4b3d6e71cf185c76589c) `[get]` |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [HearthChangeExplanation](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a6a9cecf739e24bbbbc867f8d63059550) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.Settlements.SettlementComponent](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html) | |
| int | [Gold](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#aa974492ebf10d1b34aaf0cc558994edb) `[get]` |
| float | [BackgroundCropPosition](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ad3b80b27f7a0f9ee5ec05909928ecdb7) `[get, protected set]` |
| string | [BackgroundMeshName](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a02260204c134e5b5a071f78b1f98f0cb) `[get, protected set]` |
| string | [WaitMeshName](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ad2330ad8b724bf54ed086c9db8a7fd3b) `[get, protected set]` |
| string | [CastleBackgroundMeshName](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ab65efca0f050522b4f38a88c691c54ba) `[get, protected set]` |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | [Owner](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a518303d4d6a6378d597df3db688fb41d) `[get]` |
| Settlement | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a0bfa0435170396579fed99c5eb2abff2) `[get]` |
| Banner | [Banner](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a19ddd822f9886170d976fc7710e30808) `[get]` |
| [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | [MapFaction](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a2aabf9a4f16d98d1048637d5cbb4e56a) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a2e896c5eb08141ad2d6b9490243f7b74) `[get]` |
| bool | [IsOwnerUnassigned](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a4e387d93fb228e73dd7200e919c6c9ee) `[get, set]` |
| virtual bool | [IsTown](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#af081aba39edd74a5396ab2fd9ca9c379) `[get]` |
| virtual bool | [IsCastle](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ad06143543c44cae86573f5fd25dc29cd) `[get]` |
| Properties inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| string | [StringId](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8f7cc0266861eb249963e5ead3ab93f1) `[get, set]` |
| [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html) | [Id](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af97fbe63c015ee5f4958ab6946b7f69a) `[get, set]` |
| bool | [IsInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aa6b3602c7cfd678c75bf91e1c3073606) `[get]` |
| bool | [IsReady](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#abc67abca4d8d58d34835693808c0aa14) `[get, set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Protected Member Functions inherited from [TaleWorlds.CampaignSystem.Settlements.SettlementComponent](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html) | |
| virtual void | [OnInventoryUpdated](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ad24ee0fc19f2808a49ab35bfe2d42b57) ([ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) item, int count) |
|  | [SettlementComponent](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a11fbeb0e8248fdfd63c62ba31104962f) () |
| Protected Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| virtual void | [OnBeforeLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad32c7b22bd64e771cc05ee54ae78058a) () |
| virtual void | [PreAfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aeddc87ee0703c7f37d9129d9a5e024e4) () |
| virtual void | [AfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aae8a0aa22e7a659e1edbedfe9739d413) () |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ac15d9b68ef9ed2cc6fee07fd243c46e1)VillageStates
--------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.Settlements.Village.VillageStates](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ac15d9b68ef9ed2cc6fee07fd243c46e1) |

| Enumerator | |
| --- | --- |
| Normal |  |
| BeingRaided |  |
| ForcedForVolunteers |  |
| ForcedForSupplies |  |
| Looted |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ab9a26b54b78686ffcf3593984a7b8a9e)Village()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Settlements.Village.Village | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a85eac4c8b23db82e4590089ff934e2f5)GetDefenderParties()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| IEnumerable< [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > TaleWorlds.CampaignSystem.Settlements.Village.GetDefenderParties | ( | MapEvent.BattleTypes | *battleType* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a271ac774b35443b79ac470a2c41636df)GetNextDefenderParty()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) TaleWorlds.CampaignSystem.Settlements.Village.GetNextDefenderParty | ( | ref int | *partyIndex*, |
|  |  | MapEvent.BattleTypes | *battleType* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ad193b346e982c162b0369f236badb63c)DailyTick()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Village.DailyTick | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a533a97db06948dc5077aabadec534e1e)OnInit()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Settlements.Village.OnInit | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Settlements.SettlementComponent](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a730c0c635a6fef21752439eccd5b219f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a7969cad3418945d93763d6711553f9e7)GetWarehouseCapacity()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Settlements.Village.GetWarehouseCapacity | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a0e7ce7e21d83dbd2b081ca871f9fe62d)GetItemPrice() [1/2]
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override int TaleWorlds.CampaignSystem.Settlements.Village.GetItemPrice | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *tradingParty* = null, | |  |  | bool | *isSelling* = false ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Settlements.SettlementComponent](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#abe6b3d07ce4395232564403f71d3c648).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a20a59806ca3a21147e7567ec9c9ae583)GetItemPrice() [2/2]
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override int TaleWorlds.CampaignSystem.Settlements.Village.GetItemPrice | ( | [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) | *itemRosterElement*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *tradingParty* = null, | |  |  | bool | *isSelling* = false ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Settlements.SettlementComponent](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#afd251ebd474f348160cd04487ac8719c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#af64f5fb07fd05941492082eb183535ec)ToString()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.CampaignSystem.Settlements.Village.ToString | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a1b3ecd9b3135fb5999e061d34782bcb1)Deserialize()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Settlements.Village.Deserialize | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, | |  |  | XmlNode | *node* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Settlements.SettlementComponent](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a7600ea03f492648851ba09a3d0338fc4).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a740d9e891c1757080b8418c9a1ecd855)IsProducing()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Settlements.Village.IsProducing | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ad23fdacbaeae1949fb8c353a6edf2b72)GetHearthLevel()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Settlements.Village.GetHearthLevel | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#afe6ab43610f47871f344e402a423f583)GetProsperityLevel()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [ProsperityLevel](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ae30632ba32887c9c0ab8dab569115a7b) TaleWorlds.CampaignSystem.Settlements.Village.GetProsperityLevel | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Settlements.SettlementComponent](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ae17bedb053031eada832711471355c55).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a75ba47bd4850a9ad61dd43a0edcc3727)MidHearthThreshold
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.CampaignSystem.Settlements.Village.MidHearthThreshold = 600 | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a477402dcd598dad64676cc5f06b4d3f6)LowHearthThreshold
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.CampaignSystem.Settlements.Village.LowHearthThreshold = 200 | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a6a4d4ce3d5a9115b300cca74e077510e)NumberOfDaysToFillVillageStocks
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.CampaignSystem.Settlements.Village.NumberOfDaysToFillVillageStocks = 5 | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ab058d58fab70ff5c85722168c3246e3a)VillagerPartyComponent
-----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| VillagerPartyComponent TaleWorlds.CampaignSystem.Settlements.Village.VillagerPartyComponent |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#acc3fee343e51b98d9a0037cb9b304099)VillageType
------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| VillageType TaleWorlds.CampaignSystem.Settlements.Village.VillageType |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a3b6d08ea24c3693d4e1d06f907ba37f6)All
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ab9a26b54b78686ffcf3593984a7b8a9e)> TaleWorlds.CampaignSystem.Settlements.Village.All | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a40ec421955752ca69b49b2aa32fda178)VillageState
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [VillageStates](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ac15d9b68ef9ed2cc6fee07fd243c46e1) TaleWorlds.CampaignSystem.Settlements.Village.VillageState | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a36bd84c06527d8e392150090a000ca14)IsDeserted
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Settlements.Village.IsDeserted | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a5de074c2c14b86b61071128d086f8989)LastDemandSatisfiedTime
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Settlements.Village.LastDemandSatisfiedTime | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a8d5eba7d889f4cdbec61361e2edbe726)Bound
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a0bfa0435170396579fed99c5eb2abff2) TaleWorlds.CampaignSystem.Settlements.Village.Bound | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ae04ad61bfd87017b57860e93bdd1a191)TradeBound
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a0bfa0435170396579fed99c5eb2abff2) TaleWorlds.CampaignSystem.Settlements.Village.TradeBound | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a834e3fbd6066ad71fec07abb8b3f09d5)MapFaction
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) TaleWorlds.CampaignSystem.Settlements.Village.MapFaction | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#aaf49e5a18420f985b5985733926e505a)MarketData
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [VillageMarketData](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village_market_data.html) TaleWorlds.CampaignSystem.Settlements.Village.MarketData | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a470f0eee6629bc0f904ef5f9a1063628)Hearth
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Settlements.Village.Hearth | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a76f62ab120a971e1109af7a11c4d7d40)TradeTaxAccumulated
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Settlements.Village.TradeTaxAccumulated | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a77d79cd0e4a74c51677c37d924cbbfd0)HearthChange
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Settlements.Village.HearthChange | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a39579b2f844c171ec47d6003bec4f300)Militia
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Settlements.Village.Militia | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a8e9357e063b87ee13b507fa85a0ad5af)MilitiaChange
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Settlements.Village.MilitiaChange | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ad0b338e7e35f4b3d6e71cf185c76589c)MilitiaChangeExplanation
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.Settlements.Village.MilitiaChangeExplanation | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a6a9cecf739e24bbbbc867f8d63059550)HearthChangeExplanation
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.Settlements.Village.HearthChangeExplanation | | get |

