--- SOURCE: class_helpers_1_1_settlement_helper.html ---

Helpers.SettlementHelper Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static string | [GetRandomStuff](class_helpers_1_1_settlement_helper.html#aedae396aef4408c4d50e791efb82b178) (bool isFemale) |
| static [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [FindNearestSettlementToSettlement](class_helpers_1_1_settlement_helper.html#a8943fe5e3f475db97d5370df2ca6af98) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) fromSettlement, [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) navCapabilities, Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), bool > condition=null) |
| static [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [FindNearestSettlementToMobileParty](class_helpers_1_1_settlement_helper.html#a97da6323baa934a40d9638faecfb4f0f) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) navCapabilities, Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), bool > condition=null) |
| static [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [FindNearestSettlementToPoint](class_helpers_1_1_settlement_helper.html#ae7fe41f91c14d341fa6b68d6370baf8b) (in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) point, Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), bool > condition=null) |
|  | Finds the closest settlement to given *point* without considering if it's possible to go there. |
| static [Hideout](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_hideout.html) | [FindNearestHideoutToSettlement](class_helpers_1_1_settlement_helper.html#ac1b84bd406ce0d1380e9fdfe05dc80c9) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) fromSettlement, [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) navCapabilities, Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), bool > condition=null) |
| static [Hideout](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_hideout.html) | [FindNearestHideoutToMobileParty](class_helpers_1_1_settlement_helper.html#ae049ffa6f34d716cb5f3282b23fdec3a) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) fromMobileParty, [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) navCapabilities, Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), bool > condition=null) |
| static [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | [FindNearestTownToSettlement](class_helpers_1_1_settlement_helper.html#aeeb9737da46ab9b5c1172962f708d256) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) fromSettlement, [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) navCapabilities, Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), bool > condition=null) |
| static [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | [FindNearestTownToMobileParty](class_helpers_1_1_settlement_helper.html#abc1d06513667b83f8dab70d20400c446) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, NavigationType navCapabilities, Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), bool > condition=null) |
| static int | [FindNextSettlementAroundMobileParty](class_helpers_1_1_settlement_helper.html#a9a0c046f0e0f6ec389e0e09a47ed09c9) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) navCapabilities, float maxDistance, int lastIndex, Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), bool > condition=null) |
| static [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [FindNearestCastleToSettlement](class_helpers_1_1_settlement_helper.html#a1241c7fdaedb792a2f10a0de136d1b30) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) fromSettlement, [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) navCapabilities, Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), bool > condition=null) |
| static [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [FindNearestCastleToMobileParty](class_helpers_1_1_settlement_helper.html#a710ea7497e7c7b53300c44079230c7e6) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, NavigationType navCapabilities, Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), bool > condition=null) |
| static [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [FindNearestFortificationToSettlement](class_helpers_1_1_settlement_helper.html#a5522b6df8a1e53cde511901743849090) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) fromSettlement, [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) navCapabilities, Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), bool > condition=null) |
| static [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [FindNearestFortificationToMobileParty](class_helpers_1_1_settlement_helper.html#aa79129f8941f5dd6ad8bef7b58c1dc35) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, NavigationType navCapabilities, Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), bool > condition=null) |
| static [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [FindFurthestFortificationToSettlement](class_helpers_1_1_settlement_helper.html#a0398b93faf3b10d54f919eca3a05cb0a) (MBReadOnlyList< [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) > candidates, [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) navCapabilities, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) fromSettlement, out float furthestDistance) |
| static [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) | [FindNearestVillageToSettlement](class_helpers_1_1_settlement_helper.html#a1a5c1da14a6259334046a791eed2452e) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) fromSettlement, [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) navCapabilities, Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), bool > condition=null) |
| static [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) | [FindNearestVillageToMobileParty](class_helpers_1_1_settlement_helper.html#ab82b45ecf99ad74be347137e10cd68bc) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) fromParty, NavigationType navCapabilities, Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), bool > condition=null) |
| static [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [FindRandomSettlement](class_helpers_1_1_settlement_helper.html#ac65871513cfabe2c8df75fa2da5eecda) (Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), bool > condition=null) |
| static [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [FindRandomHideout](class_helpers_1_1_settlement_helper.html#ac99205067ee079dab3c318815ff8c422) (Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), bool > condition=null) |
| static void | [TakeEnemyVillagersOutsideSettlements](class_helpers_1_1_settlement_helper.html#a95e327fab040a1c2cc935d2001df5d69) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlementWhichChangedFaction) |
| static [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [GetRandomTown](class_helpers_1_1_settlement_helper.html#a9a04818876c8836b842d397d6d13ab01) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) fromFaction=null) |
| static [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [GetBestSettlementToSpawnAround](class_helpers_1_1_settlement_helper.html#affc3f3e7225f8960ceb877d5abaa8d53) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| static IEnumerable< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [GetAllHeroesOfSettlement](class_helpers_1_1_settlement_helper.html#a70372fe88709b6308f67b295285328a5) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, bool includePrisoners) |
| static bool | [IsGarrisonStarving](class_helpers_1_1_settlement_helper.html#a17fe7b9a4f8f40ae848cc3cb2fa89055) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| static void | [SpawnNotablesIfNeeded](class_helpers_1_1_settlement_helper.html#ac8817c24d751b50f8188cf58ea9370de) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| static [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetGarrisonChangeExplainedNumber](class_helpers_1_1_settlement_helper.html#aa252b0dbadebc0b32b90b15c9b4a6474) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| static float | [GetNeighborScoreForConsideringClan](class_helpers_1_1_settlement_helper.html#a0e868f585a654f7f60967d91b3ad59d3) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) consideringClan) |

Member Function Documentation
-----------------------------

[◆](class_helpers_1_1_settlement_helper.html#aedae396aef4408c4d50e791efb82b178)GetRandomStuff()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string Helpers.SettlementHelper.GetRandomStuff | ( | bool | *isFemale* | ) |  | | static |

[◆](class_helpers_1_1_settlement_helper.html#a8943fe5e3f475db97d5370df2ca6af98)FindNearestSettlementToSettlement()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) Helpers.SettlementHelper.FindNearestSettlementToSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *fromSettlement*, | |  |  | [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) | *navCapabilities*, | |  |  | Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), bool > | *condition* = null ) | | static |

[◆](class_helpers_1_1_settlement_helper.html#a97da6323baa934a40d9638faecfb4f0f)FindNearestSettlementToMobileParty()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) Helpers.SettlementHelper.FindNearestSettlementToMobileParty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, | |  |  | [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) | *navCapabilities*, | |  |  | Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), bool > | *condition* = null ) | | static |

[◆](class_helpers_1_1_settlement_helper.html#ae7fe41f91c14d341fa6b68d6370baf8b)FindNearestSettlementToPoint()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) Helpers.SettlementHelper.FindNearestSettlementToPoint | ( | in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *point*, | |  |  | Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), bool > | *condition* = null ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | point |  |
    | condition |  |

Returns

[◆](class_helpers_1_1_settlement_helper.html#ac1b84bd406ce0d1380e9fdfe05dc80c9)FindNearestHideoutToSettlement()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Hideout](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_hideout.html) Helpers.SettlementHelper.FindNearestHideoutToSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *fromSettlement*, | |  |  | [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) | *navCapabilities*, | |  |  | Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), bool > | *condition* = null ) | | static |

[◆](class_helpers_1_1_settlement_helper.html#ae049ffa6f34d716cb5f3282b23fdec3a)FindNearestHideoutToMobileParty()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Hideout](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_hideout.html) Helpers.SettlementHelper.FindNearestHideoutToMobileParty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *fromMobileParty*, | |  |  | [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) | *navCapabilities*, | |  |  | Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), bool > | *condition* = null ) | | static |

[◆](class_helpers_1_1_settlement_helper.html#aeeb9737da46ab9b5c1172962f708d256)FindNearestTownToSettlement()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) Helpers.SettlementHelper.FindNearestTownToSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *fromSettlement*, | |  |  | [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) | *navCapabilities*, | |  |  | Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), bool > | *condition* = null ) | | static |

[◆](class_helpers_1_1_settlement_helper.html#abc1d06513667b83f8dab70d20400c446)FindNearestTownToMobileParty()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) Helpers.SettlementHelper.FindNearestTownToMobileParty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, | |  |  | NavigationType | *navCapabilities*, | |  |  | Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), bool > | *condition* = null ) | | static |

[◆](class_helpers_1_1_settlement_helper.html#a9a0c046f0e0f6ec389e0e09a47ed09c9)FindNextSettlementAroundMobileParty()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int Helpers.SettlementHelper.FindNextSettlementAroundMobileParty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, | |  |  | [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) | *navCapabilities*, | |  |  | float | *maxDistance*, | |  |  | int | *lastIndex*, | |  |  | Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), bool > | *condition* = null ) | | static |

[◆](class_helpers_1_1_settlement_helper.html#a1241c7fdaedb792a2f10a0de136d1b30)FindNearestCastleToSettlement()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) Helpers.SettlementHelper.FindNearestCastleToSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *fromSettlement*, | |  |  | [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) | *navCapabilities*, | |  |  | Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), bool > | *condition* = null ) | | static |

[◆](class_helpers_1_1_settlement_helper.html#a710ea7497e7c7b53300c44079230c7e6)FindNearestCastleToMobileParty()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) Helpers.SettlementHelper.FindNearestCastleToMobileParty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, | |  |  | NavigationType | *navCapabilities*, | |  |  | Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), bool > | *condition* = null ) | | static |

[◆](class_helpers_1_1_settlement_helper.html#a5522b6df8a1e53cde511901743849090)FindNearestFortificationToSettlement()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) Helpers.SettlementHelper.FindNearestFortificationToSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *fromSettlement*, | |  |  | [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) | *navCapabilities*, | |  |  | Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), bool > | *condition* = null ) | | static |

[◆](class_helpers_1_1_settlement_helper.html#aa79129f8941f5dd6ad8bef7b58c1dc35)FindNearestFortificationToMobileParty()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) Helpers.SettlementHelper.FindNearestFortificationToMobileParty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, | |  |  | NavigationType | *navCapabilities*, | |  |  | Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), bool > | *condition* = null ) | | static |

[◆](class_helpers_1_1_settlement_helper.html#a0398b93faf3b10d54f919eca3a05cb0a)FindFurthestFortificationToSettlement()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) Helpers.SettlementHelper.FindFurthestFortificationToSettlement | ( | MBReadOnlyList< [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) > | *candidates*, | |  |  | [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) | *navCapabilities*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *fromSettlement*, | |  |  | out float | *furthestDistance* ) | | static |

[◆](class_helpers_1_1_settlement_helper.html#a1a5c1da14a6259334046a791eed2452e)FindNearestVillageToSettlement()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) Helpers.SettlementHelper.FindNearestVillageToSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *fromSettlement*, | |  |  | [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) | *navCapabilities*, | |  |  | Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), bool > | *condition* = null ) | | static |

[◆](class_helpers_1_1_settlement_helper.html#ab82b45ecf99ad74be347137e10cd68bc)FindNearestVillageToMobileParty()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) Helpers.SettlementHelper.FindNearestVillageToMobileParty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *fromParty*, | |  |  | NavigationType | *navCapabilities*, | |  |  | Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), bool > | *condition* = null ) | | static |

[◆](class_helpers_1_1_settlement_helper.html#ac65871513cfabe2c8df75fa2da5eecda)FindRandomSettlement()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) Helpers.SettlementHelper.FindRandomSettlement | ( | Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), bool > | *condition* = null | ) |  | | static |

[◆](class_helpers_1_1_settlement_helper.html#ac99205067ee079dab3c318815ff8c422)FindRandomHideout()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) Helpers.SettlementHelper.FindRandomHideout | ( | Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), bool > | *condition* = null | ) |  | | static |

[◆](class_helpers_1_1_settlement_helper.html#a95e327fab040a1c2cc935d2001df5d69)TakeEnemyVillagersOutsideSettlements()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void Helpers.SettlementHelper.TakeEnemyVillagersOutsideSettlements | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlementWhichChangedFaction* | ) |  | | static |

[◆](class_helpers_1_1_settlement_helper.html#a9a04818876c8836b842d397d6d13ab01)GetRandomTown()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) Helpers.SettlementHelper.GetRandomTown | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *fromFaction* = null | ) |  | | static |

[◆](class_helpers_1_1_settlement_helper.html#affc3f3e7225f8960ceb877d5abaa8d53)GetBestSettlementToSpawnAround()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) Helpers.SettlementHelper.GetBestSettlementToSpawnAround | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | static |

[◆](class_helpers_1_1_settlement_helper.html#a70372fe88709b6308f67b295285328a5)GetAllHeroesOfSettlement()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IEnumerable< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > Helpers.SettlementHelper.GetAllHeroesOfSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | bool | *includePrisoners* ) | | static |

[◆](class_helpers_1_1_settlement_helper.html#a17fe7b9a4f8f40ae848cc3cb2fa89055)IsGarrisonStarving()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool Helpers.SettlementHelper.IsGarrisonStarving | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  | | static |

[◆](class_helpers_1_1_settlement_helper.html#ac8817c24d751b50f8188cf58ea9370de)SpawnNotablesIfNeeded()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void Helpers.SettlementHelper.SpawnNotablesIfNeeded | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  | | static |

[◆](class_helpers_1_1_settlement_helper.html#aa252b0dbadebc0b32b90b15c9b4a6474)GetGarrisonChangeExplainedNumber()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) Helpers.SettlementHelper.GetGarrisonChangeExplainedNumber | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* | ) |  | | static |

[◆](class_helpers_1_1_settlement_helper.html#a0e868f585a654f7f60967d91b3ad59d3)GetNeighborScoreForConsideringClan()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float Helpers.SettlementHelper.GetNeighborScoreForConsideringClan | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *consideringClan* ) | | static |

