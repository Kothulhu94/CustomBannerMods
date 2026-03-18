--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_finance_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.ClanFinanceModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultClanFinanceModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_finance_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
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
| int | [PartyGoldLowerThreshold](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_finance_model.html#ae6919b055a901d3b208c752bc72b7ccb) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_finance_model.html#af6a8d469da4b605242c1344d58ef5912)CalculateClanGoldChange()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.ClanFinanceModel.CalculateClanGoldChange | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, | |  |  | bool | *includeDescriptions* = false, | |  |  | bool | *applyWithdrawals* = false, | |  |  | bool | *includeDetails* = false ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_finance_model.html#aea92bfdf2fc0fe3a0d3c1a5f774bc7ca)CalculateClanIncome()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.ClanFinanceModel.CalculateClanIncome | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, | |  |  | bool | *includeDescriptions* = false, | |  |  | bool | *applyWithdrawals* = false, | |  |  | bool | *includeDetails* = false ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_finance_model.html#a586115cb6a3f7cba2b95c988bc2c9303)CalculateClanExpenses()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.ClanFinanceModel.CalculateClanExpenses | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, | |  |  | bool | *includeDescriptions* = false, | |  |  | bool | *applyWithdrawals* = false, | |  |  | bool | *includeDetails* = false ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_finance_model.html#a98be1ae594800f2447c7b75bba68ec29)CalculateTownIncomeFromTariffs()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.ClanFinanceModel.CalculateTownIncomeFromTariffs | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, | |  |  | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | bool | *applyWithdrawals* = false ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_finance_model.html#a604b737996b0cbdaee16e554a997340d)CalculateTownIncomeFromProjects()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ClanFinanceModel.CalculateTownIncomeFromProjects | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_finance_model.html#a8ddc939f0a4df879a1e891337093ec55)CalculateNotableDailyGoldChange()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ClanFinanceModel.CalculateNotableDailyGoldChange | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | bool | *applyWithdrawals* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_finance_model.html#ac38b348d661f45fc4ea767c323b4e5c2)CalculateVillageIncome()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ClanFinanceModel.CalculateVillageIncome | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, | |  |  | [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) | *village*, | |  |  | bool | *applyWithdrawals* = false ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_finance_model.html#a90fd257e8ee63f4e58bb0527a00a096b)CalculateOwnerIncomeFromCaravan()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ClanFinanceModel.CalculateOwnerIncomeFromCaravan | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *caravan* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_finance_model.html#a4f326227aa26aefe0ec8bc800145dab3)CalculateOwnerIncomeFromWorkshop()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ClanFinanceModel.CalculateOwnerIncomeFromWorkshop | ( | [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) | *workshop* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_finance_model.html#a5de17fd4fe5f591dd28cfca51a397c6d)RevenueSmoothenFraction()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.ClanFinanceModel.RevenueSmoothenFraction | ( |  | ) |  | | abstract |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_finance_model.html#ae6919b055a901d3b208c752bc72b7ccb)PartyGoldLowerThreshold
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ClanFinanceModel.PartyGoldLowerThreshold | | getabstract |

