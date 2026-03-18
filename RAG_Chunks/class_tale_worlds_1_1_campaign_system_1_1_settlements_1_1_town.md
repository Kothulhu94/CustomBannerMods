--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html ---

TaleWorlds.CampaignSystem.Settlements.Town Class ReferenceInherits [TaleWorlds.CampaignSystem.Settlements.Fief](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_fief.html).

|  |  |
| --- | --- |
| Classes | |
| struct | [SellLog](struct_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town_1_1_sell_log.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
| IEnumerable< [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > | [GetDefenderParties](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a64bd341f6a87faeaa16a153e9feb3d8d) (MapEvent.BattleTypes battleType) |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | [GetNextDefenderParty](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a4a23afdf24f63dbef0f7937b777b3beb) (ref int partyIndex, MapEvent.BattleTypes battleType) |
| int | [FoodStocksUpperLimit](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a652717ffe6fe21d650ff6b045184fd41) () |
|  | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a92bbd138a41b0eca8c2a01a14f57ad0c) () |
| override void | [OnInit](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#ac9b86f3bc425b386f547a1833e92681e) () |
| override void | [OnSessionStart](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#ac434fd42e40ee754003b8a9940dbb3b0) () |
| void | [InitializeWorkshops](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#acce62577a8cb081c38fea4f848bd81f5) (int count) |
| void | [AddEffectOfBuildings](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#ac44015a83c907c800764c8bb98d2ade2) ([BuildingEffectEnum](namespace_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings.html#a7f02dad2387baa3164a3eba973b863f7) buildingEffect, ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) result) |
| int | [GetWallLevel](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a2b1ed316180814dee11d6a4db94e5ed8) () |
| override string | [ToString](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#abd9661748545a9c1e5beda4bf22a8a04) () |
| override void | [Deserialize](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a4f22d83112673df4c4846648e23eda35) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
| void | [SetSoldItems](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#aed0367bed7d91f148a12d0dc7010b08d) (IEnumerable< [SellLog](struct_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town_1_1_sell_log.html) > logList) |
| override int | [GetItemPrice](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a37fc1b631438a3981998c98547f753ff) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) tradingParty=null, bool isSelling=false) |
| override int | [GetItemPrice](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a882bd7f2cd84d67afbe70fb33a7fe18d) ([EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) itemRosterElement, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) tradingParty=null, bool isSelling=false) |
| override [ProsperityLevel](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ae30632ba32887c9c0ab8dab569115a7b) | [GetProsperityLevel](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#aa24ad6a3fa9cb54ae3c894da16db8c93) () |
| float | [GetItemCategoryPriceIndex](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#ab091ef33d2b11fc4a70d1e05dab59c35) ([ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) itemCategory) |
| MBReadOnlyList< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) > | [GetNeighborFortifications](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#ad483440b4ce13381717369ea17a03e0a) (MobileParty.NavigationType navigationType) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.Settlements.SettlementComponent](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html) | |
| virtual [Banner](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a19ddd822f9886170d976fc7710e30808) | [GetDefaultComponentBanner](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a5c6eaac236fefeb5fa9d53b2bbb79807) () |
| virtual void | [OnPartyEntered](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a66828262ea64df8e73e7535dc785b436) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| virtual void | [OnPartyLeft](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a5441174fb66ec365807bde68a3d20c55) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
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
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html)[] | [BesiegerCampPositions1](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#acdd5615f50954867fe12f342a8974343) |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html)[] | [BesiegerCampPositions2](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#ad29f2fee314a1bc268a10947b3d8733e) |
| bool | [GarrisonAutoRecruitmentIsEnabled](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#acb719722afe5bf13ac4b23bbec18377b) = true |
| MBList< [Building](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html) > | [Buildings](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#acfdfbf61850f21751f0c5def4270795e) |
| Queue< [Building](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html) > | [BuildingsInProgress](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#aa73c13c5bdc92f5ef8d37f45e2dfdee8) |
| int | [BoostBuildingProcess](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#aa40ba1a1528c1d836c2b15a1fb63c20a) = 0 |
| bool | [InRebelliousState](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a3862238f2d9749d40c72d8190b696b86) = false |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.Settlements.Fief](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_fief.html) | |
| GarrisonPartyComponent | [GarrisonPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_fief.html#afdfc6f0370ff0859a5a1b025c387a59a) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [PreAfterLoad](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#add3f0bd7d2df0543090b93c64dfe2878) () |
| override void | [AfterLoad](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#ad29c0437818f9be66356962ec4f037b2) () |
| override void | [OnInventoryUpdated](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#aa8029eb07b4e81e8ff2df34ed284d14f) ([ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) item, int count) |
| Protected Member Functions inherited from [TaleWorlds.CampaignSystem.Settlements.SettlementComponent](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html) | |
|  | [SettlementComponent](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a11fbeb0e8248fdfd63c62ba31104962f) () |
| Protected Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| virtual void | [OnBeforeLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad32c7b22bd64e771cc05ee54ae78058a) () |

|  |  |
| --- | --- |
| Properties | |
| float | [Prosperity](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a062221c25bc7dedb37548138e25d21b9) `[get, set]` |
| [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | [Culture](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#aa12baf1d53ce70afaaea3d0310f4a008) `[get]` |
| float | [ProsperityChange](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a9f1d90cfb66fdaad578b5ccbd8b4fc6e) `[get]` |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [ProsperityChangeExplanation](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a3f2b27ec1e6df37ab0bc1e6e72f34f46) `[get]` |
| float | [FoodChange](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a0914c0b25d4722c4e8def946a7b8aa6d) `[get]` |
| float | [FoodChangeWithoutMarketStocks](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a20bcfe5bc73765f450f3695d000ee3fe) `[get]` |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [FoodChangeExplanation](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a2d812e712dd8f875ff311c9418c73b04) `[get]` |
| float | [LoyaltyChange](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a6be88658aab0a69240c13cea0094406e) `[get]` |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [LoyaltyChangeExplanation](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a546a8a7dd36da6883c839f013632490f) `[get]` |
| float | [SecurityChange](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a09e28e93f066725c899915f325657dc8) `[get]` |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [SecurityChangeExplanation](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a7e9acb9497de73617f234fdd192074e3) `[get]` |
| float | [MilitiaChange](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a8fc7221fbad74426c54bc493570122b5) `[get]` |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [MilitiaChangeExplanation](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#ac912654ce9ef0981688a7e922eef4138) `[get]` |
| float | [Construction](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a7658b2ae919672ede52caf5c627ed751) `[get]` |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [ConstructionExplanation](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#ae5ea6af17063438d0ad86f6ea797664f) `[get]` |
| [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | [OwnerClan](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a364a14ca5420b499f602340188d5d9de) `[get, set]` |
| float | [Security](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a15f01c9ff86ac64853d89acbf1fa30bd) `[get, set]` |
| float | [Loyalty](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a8db4dd086aa887dd4e666510433ba715) `[get, set]` |
| MBReadOnlyList< [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) > | [TradeBoundVillages](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a2428254da574aca5a0f8170321a5a087) `[get]` |
| [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html)[] | [Workshops](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a70689b7ec1872313c6eedeff01608ed6) `[get, protected set]` |
| [Building](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html) | [CurrentBuilding](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a3d1ea4626ea3200477216f679cef5592) `[get]` |
| [Building](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html) | [CurrentDefaultBuilding](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#ae5d9b93359840b770975b69c834cc481) `[get]` |
| [TownMarketData](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town_market_data.html) | [MarketData](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#ab3b3b45550c57cbe026cd55a4bd34491) `[get]` |
| int | [TradeTaxAccumulated](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#afc02147993664de7cb683a670cebd1f4) `[get, set]` |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [Governor](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#aca4dfb42c6d6ae88eb9df49f1135039c) `[get, set]` |
| MBReadOnlyList< [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) > | [AvailableShips](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#ace9870ae7e35a0aaea3ee1925ebad2de) `[get]` |
| static IEnumerable< [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a92bbd138a41b0eca8c2a01a14f57ad0c) > | [AllFiefs](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a0903424f16f3fb06107baf7c4f02a02f) `[get]` |
| static MBReadOnlyList< [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a92bbd138a41b0eca8c2a01a14f57ad0c) > | [AllTowns](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a710a30adf062b077e15184b19f58e19e) `[get]` |
| static MBReadOnlyList< [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a92bbd138a41b0eca8c2a01a14f57ad0c) > | [AllCastles](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a2f1fe4a9610412edfa115d205bb82885) `[get]` |
| override bool | [IsTown](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a70a914b04dcffde8bcd2a3f1c56b224e) `[get]` |
| override bool | [IsCastle](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a82dfa77a9e95a87616695e19aa660647) `[get]` |
| IReadOnlyCollection< [SellLog](struct_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town_1_1_sell_log.html) > | [SoldItems](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a779ce14c4175aa639448ad41d66564ee) `[get]` |
| override [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | [MapFaction](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#ac1d5cb1192521e71a85abd41b59a91b0) `[get]` |
| bool | [IsUnderSiege](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a3cbf01bcbe2a87a9a39e65609e96fb10) `[get]` |
| MBReadOnlyList< [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) > | [Villages](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a47a274a108fdd8f491b3f6e9ebcd807e) `[get]` |
| [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | [LastCapturedBy](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a066a8b5fbbdcbfe5bf35aee5e89c1da0) `[get, set]` |
| bool | [HasTournament](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a2ccd3227bf5842002d1a45ce3b97a477) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.Settlements.Fief](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_fief.html) | |
| float | [FoodStocks](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_fief.html#aef5a7157f0f1c3515916d53a941ac4c5) `[get, set]` |
| float | [Militia](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_fief.html#a9d7d18b078b9ab625bf096946656a00e) `[get]` |
| [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | [GarrisonParty](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_fief.html#a85a33b3221adee832aafe546709f044a) `[get]` |
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
| Public Types inherited from [TaleWorlds.CampaignSystem.Settlements.SettlementComponent](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html) | |
| enum | [ProsperityLevel](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ae30632ba32887c9c0ab8dab569115a7b) {     [Low](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ae30632ba32887c9c0ab8dab569115a7ba28d0edd045e05cf5af64e35ae0c4c6ef) ,     [Mid](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ae30632ba32887c9c0ab8dab569115a7ba55c6b09cbca39ef0cdb728eb112a5049) ,     [High](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ae30632ba32887c9c0ab8dab569115a7ba655d20c1ca69519ca647684edbb2db35) ,     [NumberOfLevels](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ae30632ba32887c9c0ab8dab569115a7baed0c129a39c54d57454d41af37becc40)   } |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a92bbd138a41b0eca8c2a01a14f57ad0c)Town()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Settlements.Town.Town | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a64bd341f6a87faeaa16a153e9feb3d8d)GetDefenderParties()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| IEnumerable< [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > TaleWorlds.CampaignSystem.Settlements.Town.GetDefenderParties | ( | MapEvent.BattleTypes | *battleType* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a4a23afdf24f63dbef0f7937b777b3beb)GetNextDefenderParty()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) TaleWorlds.CampaignSystem.Settlements.Town.GetNextDefenderParty | ( | ref int | *partyIndex*, |
|  |  | MapEvent.BattleTypes | *battleType* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a652717ffe6fe21d650ff6b045184fd41)FoodStocksUpperLimit()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Settlements.Town.FoodStocksUpperLimit | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#ac9b86f3bc425b386f547a1833e92681e)OnInit()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Settlements.Town.OnInit | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Settlements.SettlementComponent](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a730c0c635a6fef21752439eccd5b219f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#ac434fd42e40ee754003b8a9940dbb3b0)OnSessionStart()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Settlements.Town.OnSessionStart | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Settlements.SettlementComponent](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a8ae1cd2fa6596915ebae54770ac53100).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#acce62577a8cb081c38fea4f848bd81f5)InitializeWorkshops()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Town.InitializeWorkshops | ( | int | *count* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#add3f0bd7d2df0543090b93c64dfe2878)PreAfterLoad()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Settlements.Town.PreAfterLoad | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aeddc87ee0703c7f37d9129d9a5e024e4).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#ad29c0437818f9be66356962ec4f037b2)AfterLoad()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Settlements.Town.AfterLoad | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aae8a0aa22e7a659e1edbedfe9739d413).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#ac44015a83c907c800764c8bb98d2ade2)AddEffectOfBuildings()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Town.AddEffectOfBuildings | ( | [BuildingEffectEnum](namespace_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings.html#a7f02dad2387baa3164a3eba973b863f7) | *buildingEffect*, |
|  |  | ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | *result* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a2b1ed316180814dee11d6a4db94e5ed8)GetWallLevel()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Settlements.Town.GetWallLevel | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#abd9661748545a9c1e5beda4bf22a8a04)ToString()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.CampaignSystem.Settlements.Town.ToString | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a4f22d83112673df4c4846648e23eda35)Deserialize()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Settlements.Town.Deserialize | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, | |  |  | XmlNode | *node* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Settlements.SettlementComponent](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a7600ea03f492648851ba09a3d0338fc4).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#aed0367bed7d91f148a12d0dc7010b08d)SetSoldItems()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Town.SetSoldItems | ( | IEnumerable< [SellLog](struct_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town_1_1_sell_log.html) > | *logList* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a37fc1b631438a3981998c98547f753ff)GetItemPrice() [1/2]
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override int TaleWorlds.CampaignSystem.Settlements.Town.GetItemPrice | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *tradingParty* = null, | |  |  | bool | *isSelling* = false ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Settlements.SettlementComponent](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#abe6b3d07ce4395232564403f71d3c648).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a882bd7f2cd84d67afbe70fb33a7fe18d)GetItemPrice() [2/2]
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override int TaleWorlds.CampaignSystem.Settlements.Town.GetItemPrice | ( | [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) | *itemRosterElement*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *tradingParty* = null, | |  |  | bool | *isSelling* = false ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Settlements.SettlementComponent](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#afd251ebd474f348160cd04487ac8719c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#aa24ad6a3fa9cb54ae3c894da16db8c93)GetProsperityLevel()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [ProsperityLevel](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ae30632ba32887c9c0ab8dab569115a7b) TaleWorlds.CampaignSystem.Settlements.Town.GetProsperityLevel | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Settlements.SettlementComponent](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ae17bedb053031eada832711471355c55).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#aa8029eb07b4e81e8ff2df34ed284d14f)OnInventoryUpdated()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Settlements.Town.OnInventoryUpdated | ( | [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) | *item*, | |  |  | int | *count* ) | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.Settlements.SettlementComponent](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ad24ee0fc19f2808a49ab35bfe2d42b57).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#ab091ef33d2b11fc4a70d1e05dab59c35)GetItemCategoryPriceIndex()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.Settlements.Town.GetItemCategoryPriceIndex | ( | [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) | *itemCategory* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#ad483440b4ce13381717369ea17a03e0a)GetNeighborFortifications()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| MBReadOnlyList< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) > TaleWorlds.CampaignSystem.Settlements.Town.GetNeighborFortifications | ( | MobileParty.NavigationType | *navigationType* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#acdd5615f50954867fe12f342a8974343)BesiegerCampPositions1
--------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) [] TaleWorlds.CampaignSystem.Settlements.Town.BesiegerCampPositions1 |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#ad29f2fee314a1bc268a10947b3d8733e)BesiegerCampPositions2
--------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) [] TaleWorlds.CampaignSystem.Settlements.Town.BesiegerCampPositions2 |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#acb719722afe5bf13ac4b23bbec18377b)GarrisonAutoRecruitmentIsEnabled
------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.Settlements.Town.GarrisonAutoRecruitmentIsEnabled = true |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#acfdfbf61850f21751f0c5def4270795e)Buildings
-------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| MBList<[Building](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html)> TaleWorlds.CampaignSystem.Settlements.Town.Buildings |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#aa73c13c5bdc92f5ef8d37f45e2dfdee8)BuildingsInProgress
-----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Queue<[Building](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html)> TaleWorlds.CampaignSystem.Settlements.Town.BuildingsInProgress |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#aa40ba1a1528c1d836c2b15a1fb63c20a)BoostBuildingProcess
------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.CampaignSystem.Settlements.Town.BoostBuildingProcess = 0 |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a3862238f2d9749d40c72d8190b696b86)InRebelliousState
---------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.Settlements.Town.InRebelliousState = false |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a062221c25bc7dedb37548138e25d21b9)Prosperity
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Settlements.Town.Prosperity | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#aa12baf1d53ce70afaaea3d0310f4a008)Culture
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) TaleWorlds.CampaignSystem.Settlements.Town.Culture | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a9f1d90cfb66fdaad578b5ccbd8b4fc6e)ProsperityChange
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Settlements.Town.ProsperityChange | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a3f2b27ec1e6df37ab0bc1e6e72f34f46)ProsperityChangeExplanation
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.Settlements.Town.ProsperityChangeExplanation | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a0914c0b25d4722c4e8def946a7b8aa6d)FoodChange
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Settlements.Town.FoodChange | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a20bcfe5bc73765f450f3695d000ee3fe)FoodChangeWithoutMarketStocks
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Settlements.Town.FoodChangeWithoutMarketStocks | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a2d812e712dd8f875ff311c9418c73b04)FoodChangeExplanation
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.Settlements.Town.FoodChangeExplanation | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a6be88658aab0a69240c13cea0094406e)LoyaltyChange
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Settlements.Town.LoyaltyChange | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a546a8a7dd36da6883c839f013632490f)LoyaltyChangeExplanation
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.Settlements.Town.LoyaltyChangeExplanation | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a09e28e93f066725c899915f325657dc8)SecurityChange
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Settlements.Town.SecurityChange | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a7e9acb9497de73617f234fdd192074e3)SecurityChangeExplanation
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.Settlements.Town.SecurityChangeExplanation | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a8fc7221fbad74426c54bc493570122b5)MilitiaChange
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Settlements.Town.MilitiaChange | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#ac912654ce9ef0981688a7e922eef4138)MilitiaChangeExplanation
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.Settlements.Town.MilitiaChangeExplanation | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a7658b2ae919672ede52caf5c627ed751)Construction
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Settlements.Town.Construction | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#ae5ea6af17063438d0ad86f6ea797664f)ConstructionExplanation
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.Settlements.Town.ConstructionExplanation | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a364a14ca5420b499f602340188d5d9de)OwnerClan
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) TaleWorlds.CampaignSystem.Settlements.Town.OwnerClan | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a15f01c9ff86ac64853d89acbf1fa30bd)Security
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Settlements.Town.Security | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a8db4dd086aa887dd4e666510433ba715)Loyalty
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Settlements.Town.Loyalty | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a2428254da574aca5a0f8170321a5a087)TradeBoundVillages
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html)> TaleWorlds.CampaignSystem.Settlements.Town.TradeBoundVillages | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a70689b7ec1872313c6eedeff01608ed6)Workshops
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) [] TaleWorlds.CampaignSystem.Settlements.Town.Workshops | | getprotected set |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a3d1ea4626ea3200477216f679cef5592)CurrentBuilding
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Building](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html) TaleWorlds.CampaignSystem.Settlements.Town.CurrentBuilding | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#ae5d9b93359840b770975b69c834cc481)CurrentDefaultBuilding
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Building](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html) TaleWorlds.CampaignSystem.Settlements.Town.CurrentDefaultBuilding | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#ab3b3b45550c57cbe026cd55a4bd34491)MarketData
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TownMarketData](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town_market_data.html) TaleWorlds.CampaignSystem.Settlements.Town.MarketData | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#afc02147993664de7cb683a670cebd1f4)TradeTaxAccumulated
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Settlements.Town.TradeTaxAccumulated | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#aca4dfb42c6d6ae88eb9df49f1135039c)Governor
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.Settlements.Town.Governor | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#ace9870ae7e35a0aaea3ee1925ebad2de)AvailableShips
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html)> TaleWorlds.CampaignSystem.Settlements.Town.AvailableShips | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a0903424f16f3fb06107baf7c4f02a02f)AllFiefs
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IEnumerable<[Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a92bbd138a41b0eca8c2a01a14f57ad0c)> TaleWorlds.CampaignSystem.Settlements.Town.AllFiefs | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a710a30adf062b077e15184b19f58e19e)AllTowns
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a92bbd138a41b0eca8c2a01a14f57ad0c)> TaleWorlds.CampaignSystem.Settlements.Town.AllTowns | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a2f1fe4a9610412edfa115d205bb82885)AllCastles
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a92bbd138a41b0eca8c2a01a14f57ad0c)> TaleWorlds.CampaignSystem.Settlements.Town.AllCastles | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a70a914b04dcffde8bcd2a3f1c56b224e)IsTown
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override bool TaleWorlds.CampaignSystem.Settlements.Town.IsTown | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a82dfa77a9e95a87616695e19aa660647)IsCastle
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override bool TaleWorlds.CampaignSystem.Settlements.Town.IsCastle | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a779ce14c4175aa639448ad41d66564ee)SoldItems
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IReadOnlyCollection<[SellLog](struct_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town_1_1_sell_log.html)> TaleWorlds.CampaignSystem.Settlements.Town.SoldItems | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#ac1d5cb1192521e71a85abd41b59a91b0)MapFaction
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) TaleWorlds.CampaignSystem.Settlements.Town.MapFaction | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a3cbf01bcbe2a87a9a39e65609e96fb10)IsUnderSiege
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Settlements.Town.IsUnderSiege | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a47a274a108fdd8f491b3f6e9ebcd807e)Villages
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html)> TaleWorlds.CampaignSystem.Settlements.Town.Villages | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a066a8b5fbbdcbfe5bf35aee5e89c1da0)LastCapturedBy
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) TaleWorlds.CampaignSystem.Settlements.Town.LastCapturedBy | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a2ccd3227bf5842002d1a45ce3b97a477)HasTournament
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Settlements.Town.HasTournament | | get |

