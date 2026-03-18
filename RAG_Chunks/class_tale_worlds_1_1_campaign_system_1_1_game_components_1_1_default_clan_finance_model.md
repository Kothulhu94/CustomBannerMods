--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_finance_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultClanFinanceModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.ClanFinanceModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_finance_model.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [AssetIncomeType](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_finance_model.html#a159462a38a47083df801bdfad2d24e50) {     [Workshop](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_finance_model.html#a159462a38a47083df801bdfad2d24e50a8e5d9dbc85b2f11b4b8bed57cadf53e5) ,     [Caravan](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_finance_model.html#a159462a38a47083df801bdfad2d24e50ad7f8c7a175f2cf745cc3ff4bd05663ad) ,     [Taxes](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_finance_model.html#a159462a38a47083df801bdfad2d24e50a719fec04166d6fa75f89cd29ad61fa8c) ,     [TributesEarned](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_finance_model.html#a159462a38a47083df801bdfad2d24e50aec3483a79b45f3f328ce389abb250b7c)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateClanGoldChange](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_finance_model.html#a11ffbfd1200ec6bbb358c542e3efa19e) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, bool includeDescriptions=false, bool applyWithdrawals=false, bool includeDetails=false) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateClanIncome](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_finance_model.html#afec9e0aa9c77421539b2177e658b6d71) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, bool includeDescriptions=false, bool applyWithdrawals=false, bool includeDetails=false) |
| void | [CalculateClanExpensesInternal](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_finance_model.html#af9a81dcd4f3df9bcae401bdf579e200a) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) goldChange, bool applyWithdrawals=false, bool includeDetails=false) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateClanExpenses](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_finance_model.html#affd033ce110c547e0e7378ce026a52eb) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, bool includeDescriptions=false, bool applyWithdrawals=false, bool includeDetails=false) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateTownIncomeFromTariffs](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_finance_model.html#a81577623a224be8bec6c874d0c30a8a5) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, bool applyWithdrawals=false) |
| override int | [CalculateTownIncomeFromProjects](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_finance_model.html#a51d7e90007f150b757e62c9bf42d615a) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| override int | [CalculateVillageIncome](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_finance_model.html#a47107ab4d929545a89b2da916d27d9a7) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) village, bool applyWithdrawals=false) |
| override int | [CalculateOwnerIncomeFromCaravan](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_finance_model.html#aa7a612e44a7a9b9cd523605a8fecea3f) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) caravan) |
| override int | [CalculateOwnerIncomeFromWorkshop](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_finance_model.html#aedebb39b7eabf9acb4b7888c128c5f37) ([Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) workshop) |
| override float | [RevenueSmoothenFraction](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_finance_model.html#a60933fd07ff9ff8875a247e3dc6570da) () |
| override int | [CalculateNotableDailyGoldChange](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_finance_model.html#a7e70c87af367691f31e4ce79edfab9f1) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, bool applyWithdrawals) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.ClanFinanceModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_finance_model.html) | |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateClanGoldChange](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_finance_model.html#af6a8d469da4b605242c1344d58ef5912) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, bool includeDescriptions=false, bool applyWithdrawals=false, bool includeDetails=false) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateClanIncome](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_finance_model.html#aea92bfdf2fc0fe3a0d3c1a5f774bc7ca) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, bool includeDescriptions=false, bool applyWithdrawals=false, bool includeDetails=false) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateClanExpenses](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_finance_model.html#a586115cb6a3f7cba2b95c988bc2c9303) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, bool includeDescriptions=false, bool applyWithdrawals=false, bool includeDetails=false) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateTownIncomeFromTariffs](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_finance_model.html#a98be1ae594800f2447c7b75bba68ec29) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, bool applyWithdrawals=false) |
| int | [CalculateTownIncomeFromProjects](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_finance_model.html#a604b737996b0cbdaee16e554a997340d) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| int | [CalculateNotableDailyGoldChange](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_finance_model.html#a8ddc939f0a4df879a1e891337093ec55) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, bool applyWithdrawals) |
| int | [CalculateVillageIncome](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_finance_model.html#ac38b348d661f45fc4ea767c323b4e5c2) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) village, bool applyWithdrawals=false) |
| int | [CalculateOwnerIncomeFromCaravan](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_finance_model.html#a90fd257e8ee63f4e58bb0527a00a096b) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) caravan) |
| int | [CalculateOwnerIncomeFromWorkshop](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_finance_model.html#a4f326227aa26aefe0ec8bc800145dab3) ([Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) workshop) |
| float | [RevenueSmoothenFraction](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_finance_model.html#a5de17fd4fe5f591dd28cfca51a397c6d) () |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| override int | [PartyGoldLowerThreshold](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_finance_model.html#aeaf07b6af4bf5ecb9ff9c5f155a931f5) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.ClanFinanceModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_finance_model.html) | |
| int | [PartyGoldLowerThreshold](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_finance_model.html#ae6919b055a901d3b208c752bc72b7ccb) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_finance_model.html#a159462a38a47083df801bdfad2d24e50)AssetIncomeType
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.GameComponents.DefaultClanFinanceModel.AssetIncomeType](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_finance_model.html#a159462a38a47083df801bdfad2d24e50) |

| Enumerator | |
| --- | --- |
| Workshop |  |
| Caravan |  |
| Taxes |  |
| TributesEarned |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_finance_model.html#a11ffbfd1200ec6bbb358c542e3efa19e)CalculateClanGoldChange()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultClanFinanceModel.CalculateClanGoldChange | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, |
|  |  | bool | *includeDescriptions* = false, |
|  |  | bool | *applyWithdrawals* = false, |
|  |  | bool | *includeDetails* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_finance_model.html#afec9e0aa9c77421539b2177e658b6d71)CalculateClanIncome()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultClanFinanceModel.CalculateClanIncome | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, |
|  |  | bool | *includeDescriptions* = false, |
|  |  | bool | *applyWithdrawals* = false, |
|  |  | bool | *includeDetails* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_finance_model.html#af9a81dcd4f3df9bcae401bdf579e200a)CalculateClanExpensesInternal()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameComponents.DefaultClanFinanceModel.CalculateClanExpensesInternal | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, |
|  |  | ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | *goldChange*, |
|  |  | bool | *applyWithdrawals* = false, |
|  |  | bool | *includeDetails* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_finance_model.html#affd033ce110c547e0e7378ce026a52eb)CalculateClanExpenses()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultClanFinanceModel.CalculateClanExpenses | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, |
|  |  | bool | *includeDescriptions* = false, |
|  |  | bool | *applyWithdrawals* = false, |
|  |  | bool | *includeDetails* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_finance_model.html#a81577623a224be8bec6c874d0c30a8a5)CalculateTownIncomeFromTariffs()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultClanFinanceModel.CalculateTownIncomeFromTariffs | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, |
|  |  | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, |
|  |  | bool | *applyWithdrawals* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_finance_model.html#a51d7e90007f150b757e62c9bf42d615a)CalculateTownIncomeFromProjects()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultClanFinanceModel.CalculateTownIncomeFromProjects | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_finance_model.html#a47107ab4d929545a89b2da916d27d9a7)CalculateVillageIncome()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultClanFinanceModel.CalculateVillageIncome | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, |
|  |  | [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) | *village*, |
|  |  | bool | *applyWithdrawals* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_finance_model.html#aa7a612e44a7a9b9cd523605a8fecea3f)CalculateOwnerIncomeFromCaravan()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultClanFinanceModel.CalculateOwnerIncomeFromCaravan | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *caravan* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_finance_model.html#aedebb39b7eabf9acb4b7888c128c5f37)CalculateOwnerIncomeFromWorkshop()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultClanFinanceModel.CalculateOwnerIncomeFromWorkshop | ( | [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) | *workshop* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_finance_model.html#a60933fd07ff9ff8875a247e3dc6570da)RevenueSmoothenFraction()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultClanFinanceModel.RevenueSmoothenFraction | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_finance_model.html#a7e70c87af367691f31e4ce79edfab9f1)CalculateNotableDailyGoldChange()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultClanFinanceModel.CalculateNotableDailyGoldChange | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | bool | *applyWithdrawals* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_finance_model.html#aeaf07b6af4bf5ecb9ff9c5f155a931f5)PartyGoldLowerThreshold
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultClanFinanceModel.PartyGoldLowerThreshold | | get |

