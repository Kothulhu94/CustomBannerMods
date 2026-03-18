--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html ---

TaleWorlds.CampaignSystem.CampaignBehaviors.TradeCampaignBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [TradeGoodType](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#acbf6ae9afb0d46a46ea1d3816ddfc4c4) {     [Grain](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#acbf6ae9afb0d46a46ea1d3816ddfc4c4af45f481029006e3c6e5e336582b2dc29) ,     [Wood](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#acbf6ae9afb0d46a46ea1d3816ddfc4c4a6e4dd7ce4ea3c1d4a90edb289e22da98) ,     [Meat](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#acbf6ae9afb0d46a46ea1d3816ddfc4c4ae4b662d3892f8c0c86801919f979467f) ,     [Wool](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#acbf6ae9afb0d46a46ea1d3816ddfc4c4a11c69b2a8ff1502a44e350ace6f172e4) ,     [Cheese](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#acbf6ae9afb0d46a46ea1d3816ddfc4c4aa67778b3dcc82bfaace0f8bc0061f20e) ,     [Iron](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#acbf6ae9afb0d46a46ea1d3816ddfc4c4acefa8a9606819ed409dc761ca6080887) ,     [Salt](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#acbf6ae9afb0d46a46ea1d3816ddfc4c4aaf334c7b6ef89b42a94f7932a1ee9ffe) ,     [Spice](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#acbf6ae9afb0d46a46ea1d3816ddfc4c4a69ad808a578343046a547820b491b546) ,     [Raw\_Silk](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#acbf6ae9afb0d46a46ea1d3816ddfc4c4a3fec6ac7650b9988128d2b0c5bf8108e) ,     [Fish](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#acbf6ae9afb0d46a46ea1d3816ddfc4c4a071642fa72ba780ee90ed36350d82745) ,     [Flax](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#acbf6ae9afb0d46a46ea1d3816ddfc4c4ac731a0c8df5cb9e96066c1c15154cae4) ,     [Grape](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#acbf6ae9afb0d46a46ea1d3816ddfc4c4af9edfa286f905de03053f83eb4575a59) ,     [Hides](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#acbf6ae9afb0d46a46ea1d3816ddfc4c4ae9b96d2115eae6e84bfe4dea3d53f53a) ,     [Clay](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#acbf6ae9afb0d46a46ea1d3816ddfc4c4aed5eace1bd098cdced7685864b09c291) ,     [Date\_Fruit](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#acbf6ae9afb0d46a46ea1d3816ddfc4c4a1553c2bc48c47c1aaa61400bb6b7309b) ,     [Bread](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#acbf6ae9afb0d46a46ea1d3816ddfc4c4a1296fcaab5ec71496d1ecb176f176bdf) ,     [Beer](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#acbf6ae9afb0d46a46ea1d3816ddfc4c4ac6884357e49fd6b1fdede867c96aafb1) ,     [Wine](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#acbf6ae9afb0d46a46ea1d3816ddfc4c4ab9eadba3c35f7f89e93c92eb2c8d39b0) ,     [Tools](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#acbf6ae9afb0d46a46ea1d3816ddfc4c4a8625e1de7be14c39b1d14dc03d822497) ,     [Pottery](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#acbf6ae9afb0d46a46ea1d3816ddfc4c4a4299ed4f93fc31c06e8ef148e9a99eab) ,     [Cloth](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#acbf6ae9afb0d46a46ea1d3816ddfc4c4a6eb838828b15bd5becbb96da8f979614) ,     [Linen](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#acbf6ae9afb0d46a46ea1d3816ddfc4c4a5ab518fc894c7438e44d9a035c2e970e) ,     [Leather](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#acbf6ae9afb0d46a46ea1d3816ddfc4c4abdf7ad23e89b55f904bca0304819309e) ,     [Velvet](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#acbf6ae9afb0d46a46ea1d3816ddfc4c4aeb20aad54d7c4fc89f400a5a446c48d3) ,     [Saddle\_Horse](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#acbf6ae9afb0d46a46ea1d3816ddfc4c4aba83196741adfa427d880e07103bf32f) ,     [Steppe\_Horse](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#acbf6ae9afb0d46a46ea1d3816ddfc4c4a77f76a0f4a9fa67fc69d6433a18fd2d2) ,     [Hunter](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#acbf6ae9afb0d46a46ea1d3816ddfc4c4a5e409e09f43d85c6e61301149e4f803b) ,     [Desert\_Horse](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#acbf6ae9afb0d46a46ea1d3816ddfc4c4aa0d6aae3b5378f4d06454530e8bb9553) ,     [Charger](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#acbf6ae9afb0d46a46ea1d3816ddfc4c4ab728d9571d34cd80c23104e44dff869c) ,     [War\_Horse](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#acbf6ae9afb0d46a46ea1d3816ddfc4c4a714b686d23734c4fd380ce2d72b881e8) ,     [Steppe\_Charger](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#acbf6ae9afb0d46a46ea1d3816ddfc4c4a07a9b97359356ecca3aff35e91c2288d) ,     [Desert\_War\_Horse](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#acbf6ae9afb0d46a46ea1d3816ddfc4c4ab8af2bf2462ee586842be7b66198c832) ,     [Unknown](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#acbf6ae9afb0d46a46ea1d3816ddfc4c4a88183b946cc5f0e8c96b2e66e1c74a7e) ,     [NumberOfTradeItems](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#acbf6ae9afb0d46a46ea1d3816ddfc4c4af0b93c03374dc4d4d35263611e398794)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [OnNewGameCreated](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#a982a6740bbeb5d1998a594856cb44f09) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameStarter) |
| override void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#a7a6fd2e8f2bf0e7684ceafda102102cc) () |
| override void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#a9c8b0e59bd88ccd3ba7ace09ffa9ed62) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| void | [DailyTickTown](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#a798cb99780452d7edd88bdedd519cb24) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a053965730807cc40179cb1ee0495c376) (string stringId) |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab8914958880a708aaf68f676e6c29df1) () |
| void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a402e03be483527df560a46a7a01004a6) () |
| void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a5f2a833b5a67619021c6c437a1232877) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const float | [MaximumTaxRatioForVillages](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#a0fab48f2f7d48668a1a94b5401bd91d2) = 1.00f |
| const float | [MaximumTaxRatioForTowns](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#a5ba09cf8bae774c5b918367d93d0e57c) = 0.50f |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| static T | [GetCampaignBehavior< T >](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#af9fd34472faff4ae39b627e8d3091b7e) () |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| readonly string | [StringId](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab1c3b0a4161f58781148a9499be70fa3) |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#acbf6ae9afb0d46a46ea1d3816ddfc4c4)TradeGoodType
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.CampaignBehaviors.TradeCampaignBehavior.TradeGoodType](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#acbf6ae9afb0d46a46ea1d3816ddfc4c4) |

| Enumerator | |
| --- | --- |
| Grain |  |
| Wood |  |
| Meat |  |
| Wool |  |
| Cheese |  |
| Iron |  |
| Salt |  |
| Spice |  |
| Raw\_Silk |  |
| Fish |  |
| Flax |  |
| Grape |  |
| Hides |  |
| Clay |  |
| Date\_Fruit |  |
| Bread |  |
| Beer |  |
| Wine |  |
| Tools |  |
| Pottery |  |
| Cloth |  |
| Linen |  |
| Leather |  |
| Velvet |  |
| Saddle\_Horse |  |
| Steppe\_Horse |  |
| Hunter |  |
| Desert\_Horse |  |
| Charger |  |
| War\_Horse |  |
| Steppe\_Charger |  |
| Desert\_War\_Horse |  |
| Unknown |  |
| NumberOfTradeItems |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#a982a6740bbeb5d1998a594856cb44f09)OnNewGameCreated()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.TradeCampaignBehavior.OnNewGameCreated | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *campaignGameStarter* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#a7a6fd2e8f2bf0e7684ceafda102102cc)RegisterEvents()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.TradeCampaignBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#a9c8b0e59bd88ccd3ba7ace09ffa9ed62)SyncData()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.TradeCampaignBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#a798cb99780452d7edd88bdedd519cb24)DailyTickTown()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.TradeCampaignBehavior.DailyTickTown | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#a0fab48f2f7d48668a1a94b5401bd91d2)MaximumTaxRatioForVillages
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.CampaignSystem.CampaignBehaviors.TradeCampaignBehavior.MaximumTaxRatioForVillages = 1.00f | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_trade_campaign_behavior.html#a5ba09cf8bae774c5b918367d93d0e57c)MaximumTaxRatioForTowns
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.CampaignSystem.CampaignBehaviors.TradeCampaignBehavior.MaximumTaxRatioForTowns = 0.50f | | static |

