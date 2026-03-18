--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html ---

TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html), and [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ViewDataTrackerCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a0937a814a28b36283c828378c87e9991) () |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetPartyNotificationText](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a8bb5fcd56df0380b49713298abc0540b) () |
| void | [ClearPartyNotification](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a4ad17f7fdc0c8e97923aa7613b146999) () |
| void | [UpdatePartyNotification](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a197b7db793c397c5dc1f09e56e74ab77) () |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetQuestNotificationText](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a637d66fa69c5312baad870ac489593d3) () |
| void | [OnQuestLogExamined](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a119230f28bcabd99805b243e27d1ec2a) ([JournalLog](class_tale_worlds_1_1_campaign_system_1_1_journal_log.html) log) |
| void | [OnArmyExamined](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a6303df5599e5f1d1552965ac7e668fa4) ([Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) army) |
| void | [ClearCharacterNotification](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#aa0b56c6a67b0aa078b39611f41176ea8) () |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetCharacterNotificationText](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#ad0371957165f615c67088a903c0f0bf7) () |
| bool | [GetMapBarExtendedState](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#afbddf00550a814bcaac518006d062b03) () |
| void | [SetMapBarExtendedState](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#aabfc90364294c6116d9b59762117ac26) (bool isExtended) |
| void | [SetInventoryLocks](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#ac5830152da2f174d5b6c04da5c8e1f60) (IEnumerable< string > locks) |
| IEnumerable< string > | [GetInventoryLocks](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#ab3940da0214d21ac55d5714d241b6c63) () |
| void | [InventorySetSortPreference](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a202b6a40561b343c4f4dea164f8e9bcd) (int inventoryMode, int sortOption, int sortState) |
| Tuple< int, int > | [InventoryGetSortPreference](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#aad9ccc62a54307f293b3739084217e6e) (int inventoryMode) |
| void | [SetPartyTroopLocks](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a67a65ea7168872cf8df1e2b34178591b) (IEnumerable< string > locks) |
| void | [SetPartyPrisonerLocks](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a84f37228446125e50868fd19ea738225) (IEnumerable< string > locks) |
| void | [SetPartySortType](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a84657fb7f8bc28c83b4df862ff32c18d) (int sortType) |
| void | [SetIsPartySortAscending](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a5fe2e8d3e44319b206df23f82c6fcd82) (bool isAscending) |
| IEnumerable< string > | [GetPartyTroopLocks](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#ad8c963a40ba9f46a1f8f9731ffdbb0a6) () |
| IEnumerable< string > | [GetPartyPrisonerLocks](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#ae0e8792e359e20d801e0ee42d537689d) () |
| int | [GetPartySortType](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#aea117229750d1c04568ede8fa4a4d339) () |
| bool | [GetIsPartySortAscending](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a0280bd118ed85c844d0f0f35204c7527) () |
| void | [AddEncyclopediaBookmarkToItem](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a89f09d429b41ed0242e3344af90f4e45) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) item) |
| void | [AddEncyclopediaBookmarkToItem](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#aefb0f24d531504c1b1dce675188de885) ([ShipHull](class_tale_worlds_1_1_core_1_1_ship_hull.html) shipHull) |
| void | [AddEncyclopediaBookmarkToItem](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#ab7967cb3ecfcc370ceee17b6e99478e5) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| void | [AddEncyclopediaBookmarkToItem](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a086d77596ac2d372267b8c3f049ec3a9) ([Concept](class_tale_worlds_1_1_campaign_system_1_1_concept.html) concept) |
| void | [AddEncyclopediaBookmarkToItem](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a878025b36ce5a815e65e2296ec171cb9) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom) |
| void | [AddEncyclopediaBookmarkToItem](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#ae06d276b57bef5b12b3cd77b7e4b0dfc) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| void | [AddEncyclopediaBookmarkToItem](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#aebef11c4f80a570b303953b899ae00f8) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) unit) |
| void | [RemoveEncyclopediaBookmarkFromItem](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a5e410913c84fa5be9fbe1b5087d0d5f9) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| void | [RemoveEncyclopediaBookmarkFromItem](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a2fbb4b3346f06a3e0672abf2062f2f0d) ([ShipHull](class_tale_worlds_1_1_core_1_1_ship_hull.html) shipHull) |
| void | [RemoveEncyclopediaBookmarkFromItem](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#ad0907b5e58ddb713c6e46b86d70b18dd) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| void | [RemoveEncyclopediaBookmarkFromItem](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a7f35bbaa970cf7d0422829f215c4162f) ([Concept](class_tale_worlds_1_1_campaign_system_1_1_concept.html) concept) |
| void | [RemoveEncyclopediaBookmarkFromItem](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#aa70a598402d9b16b8822df310d536674) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom) |
| void | [RemoveEncyclopediaBookmarkFromItem](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a6b8a7de543b3af999efeb236d443f29d) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| void | [RemoveEncyclopediaBookmarkFromItem](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a78631ef363e99e0ba06ae06f6cf13b0b) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) unit) |
| bool | [IsEncyclopediaBookmarked](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a01b583e023374cbfca7dd3e97b062ca6) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| bool | [IsEncyclopediaBookmarked](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#afdd50f4fcdbf50c35995814da3fb8b80) ([ShipHull](class_tale_worlds_1_1_core_1_1_ship_hull.html) shipHull) |
| bool | [IsEncyclopediaBookmarked](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a1dd06c59c9fa6e304cac70236d05e75f) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| bool | [IsEncyclopediaBookmarked](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a1c01f3713236572a6279d72740839176) ([Concept](class_tale_worlds_1_1_campaign_system_1_1_concept.html) concept) |
| bool | [IsEncyclopediaBookmarked](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a18ac41b70140ab7939c3bbc711c3f51c) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom) |
| bool | [IsEncyclopediaBookmarked](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a4665ed8401ba58edc28d6c8cc50c18da) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| bool | [IsEncyclopediaBookmarked](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a0e1e0d2abef546629cc95354a9af80d2) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) unit) |
| void | [SetQuestSelection](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a0044e4d160e99816dd81f7f83e86228f) ([QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) selection) |
| [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) | [GetQuestSelection](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a7184e56136a4f386977da1c80eb2a9c4) () |
| MBReadOnlyList< [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) > | [GetPlunderItems](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a6edf5cf88fe06d693a971c0c2bcaac6a) () |
| void | [OnFigureheadExamined](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a2ea912db417e842bce61bca9f8d6bc86) ([Figurehead](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_figurehead.html) figurehead) |
| override void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#ae8146b5da927ef02be2d8f77587b839c) () |
| void | [SetQuestSortTypeSelection](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a39a1cb300e12ba93a99e2158323510e0) (int questSortTypeSelection) |
| int | [GetQuestSortTypeSelection](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a99667d3a0d0aa650cab1f2df7355da2f) () |
| override void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a7d707bd1853b6892351c3deac7c2efd4) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a053965730807cc40179cb1ee0495c376) (string stringId) |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab8914958880a708aaf68f676e6c29df1) () |
| void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a402e03be483527df560a46a7a01004a6) () |
| void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a5f2a833b5a67619021c6c437a1232877) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsPartyNotificationActive](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#ada562ce94548433888c1c6e67be7a7ef) `[get]` |
| bool | [IsQuestNotificationActive](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a49de0854ebdb143f47450ab47425ca78) `[get]` |
| IReadOnlyList< [JournalLog](class_tale_worlds_1_1_campaign_system_1_1_journal_log.html) > | [UnExaminedQuestLogs](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a08476065832b21785ab8f48eca9f4d1f) `[get]` |
| List< [Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) > | [UnExaminedArmies](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#af2c8404a6b47225ae6e451e897cb0d72) `[get]` |
| int | [NumOfKingdomArmyNotifications](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#ae168227e7ec6c9e584cfc1844b901809) `[get]` |
| bool | [IsCharacterNotificationActive](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a36d704eadfcf2feb93618c58f71f3980) `[get]` |
| IReadOnlyList< [Figurehead](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_figurehead.html) > | [UnexaminedFigureheads](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a9fe969c475dfc639f0e83060531309b4) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| static T | [GetCampaignBehavior< T >](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#af9fd34472faff4ae39b627e8d3091b7e) () |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| readonly string | [StringId](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab1c3b0a4161f58781148a9499be70fa3) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a0937a814a28b36283c828378c87e9991)ViewDataTrackerCampaignBehavior()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.ViewDataTrackerCampaignBehavior | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a8bb5fcd56df0380b49713298abc0540b)GetPartyNotificationText()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.GetPartyNotificationText | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#a9b7eee74b644dfb00182df9d0a8192e4).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a4ad17f7fdc0c8e97923aa7613b146999)ClearPartyNotification()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.ClearPartyNotification | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#a9d7db3f1576ff7932e7865ebcc179493).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a197b7db793c397c5dc1f09e56e74ab77)UpdatePartyNotification()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.UpdatePartyNotification | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#a442ac7f69001e3a9b92023e10b4e45b2).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a637d66fa69c5312baad870ac489593d3)GetQuestNotificationText()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.GetQuestNotificationText | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#a355f75518c6533075e263efb077219c3).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a119230f28bcabd99805b243e27d1ec2a)OnQuestLogExamined()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.OnQuestLogExamined | ( | [JournalLog](class_tale_worlds_1_1_campaign_system_1_1_journal_log.html) | *log* | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#aa0769cdd3878a6cb559165a13ade19fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a6303df5599e5f1d1552965ac7e668fa4)OnArmyExamined()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.OnArmyExamined | ( | [Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) | *army* | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#aedf0ed50949de645e0f0b47c8c0a55a8).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#aa0b56c6a67b0aa078b39611f41176ea8)ClearCharacterNotification()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.ClearCharacterNotification | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#a2c076322f25e4cd67c1ce1148086f493).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#ad0371957165f615c67088a903c0f0bf7)GetCharacterNotificationText()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.GetCharacterNotificationText | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#a7a0c65f50999d49dd67ee879e34b91c7).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#afbddf00550a814bcaac518006d062b03)GetMapBarExtendedState()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.GetMapBarExtendedState | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#a2f69d58a097d2247967255506361daf2).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#aabfc90364294c6116d9b59762117ac26)SetMapBarExtendedState()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.SetMapBarExtendedState | ( | bool | *isExtended* | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#aa3c6f669cf40785f04392999eb33860f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#ac5830152da2f174d5b6c04da5c8e1f60)SetInventoryLocks()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.SetInventoryLocks | ( | IEnumerable< string > | *locks* | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#aa9d11599eddb3cf4bcefb6d38a9a7615).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#ab3940da0214d21ac55d5714d241b6c63)GetInventoryLocks()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< string > TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.GetInventoryLocks | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#a077e24dade0c17a602fecaf47e4999b3).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a202b6a40561b343c4f4dea164f8e9bcd)InventorySetSortPreference()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.InventorySetSortPreference | ( | int | *inventoryMode*, |
|  |  | int | *sortOption*, |
|  |  | int | *sortState* ) |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#a97df13a36a681854f867f7558a053525).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#aad9ccc62a54307f293b3739084217e6e)InventoryGetSortPreference()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| Tuple< int, int > TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.InventoryGetSortPreference | ( | int | *inventoryMode* | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#a4c399d735e50070855d66f9f5407792b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a67a65ea7168872cf8df1e2b34178591b)SetPartyTroopLocks()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.SetPartyTroopLocks | ( | IEnumerable< string > | *locks* | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#a9d0eab687d4130acd52d5bf3cbfb71a3).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a84f37228446125e50868fd19ea738225)SetPartyPrisonerLocks()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.SetPartyPrisonerLocks | ( | IEnumerable< string > | *locks* | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#a65b15d606caef239c1fc0921c4c8b4b7).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a84657fb7f8bc28c83b4df862ff32c18d)SetPartySortType()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.SetPartySortType | ( | int | *sortType* | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#a56869e696ef563e536374b18980075a8).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a5fe2e8d3e44319b206df23f82c6fcd82)SetIsPartySortAscending()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.SetIsPartySortAscending | ( | bool | *isAscending* | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#a09d617c1533ce5853bdfefadc06b4d50).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#ad8c963a40ba9f46a1f8f9731ffdbb0a6)GetPartyTroopLocks()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< string > TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.GetPartyTroopLocks | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#a05c430dedccd8d377b222672f3448c1c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#ae0e8792e359e20d801e0ee42d537689d)GetPartyPrisonerLocks()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< string > TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.GetPartyPrisonerLocks | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#ae113ac0d69b2619f0ae93b8f6a7166f5).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#aea117229750d1c04568ede8fa4a4d339)GetPartySortType()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.GetPartySortType | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#a141418ef3795910691d4609c08cd17ed).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a0280bd118ed85c844d0f0f35204c7527)GetIsPartySortAscending()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.GetIsPartySortAscending | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#a95aee0d3d32e43fdb8552e1f0e476035).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a89f09d429b41ed0242e3344af90f4e45)AddEncyclopediaBookmarkToItem() [1/7]
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.AddEncyclopediaBookmarkToItem | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *item* | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#adc554434a5b043e955d8e8fc04a5885b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#aefb0f24d531504c1b1dce675188de885)AddEncyclopediaBookmarkToItem() [2/7]
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.AddEncyclopediaBookmarkToItem | ( | [ShipHull](class_tale_worlds_1_1_core_1_1_ship_hull.html) | *shipHull* | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#a61c95f6f834b08be9c1823eff6adfc67).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#ab7967cb3ecfcc370ceee17b6e99478e5)AddEncyclopediaBookmarkToItem() [3/7]
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.AddEncyclopediaBookmarkToItem | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#a63d1a25925650d68123cf109495e65e5).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a086d77596ac2d372267b8c3f049ec3a9)AddEncyclopediaBookmarkToItem() [4/7]
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.AddEncyclopediaBookmarkToItem | ( | [Concept](class_tale_worlds_1_1_campaign_system_1_1_concept.html) | *concept* | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#a1fea5f46c1528b2c336d77278f067d96).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a878025b36ce5a815e65e2296ec171cb9)AddEncyclopediaBookmarkToItem() [5/7]
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.AddEncyclopediaBookmarkToItem | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom* | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#a6956a5e260dce2fddcf8442f61ffd610).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#ae06d276b57bef5b12b3cd77b7e4b0dfc)AddEncyclopediaBookmarkToItem() [6/7]
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.AddEncyclopediaBookmarkToItem | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#a760ada9e2ee9bf3bd13c68a8b77bc18c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#aebef11c4f80a570b303953b899ae00f8)AddEncyclopediaBookmarkToItem() [7/7]
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.AddEncyclopediaBookmarkToItem | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *unit* | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#a3d6939491576e5bec7e362fd46f12c3d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a5e410913c84fa5be9fbe1b5087d0d5f9)RemoveEncyclopediaBookmarkFromItem() [1/7]
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.RemoveEncyclopediaBookmarkFromItem | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#a10d81a804b20a76e8e010d8437bbd520).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a2fbb4b3346f06a3e0672abf2062f2f0d)RemoveEncyclopediaBookmarkFromItem() [2/7]
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.RemoveEncyclopediaBookmarkFromItem | ( | [ShipHull](class_tale_worlds_1_1_core_1_1_ship_hull.html) | *shipHull* | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#a390d4831792b6defdc3ae25c547a0050).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#ad0907b5e58ddb713c6e46b86d70b18dd)RemoveEncyclopediaBookmarkFromItem() [3/7]
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.RemoveEncyclopediaBookmarkFromItem | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#acbe068649fac0cc38f82a1e8e0070c8c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a7f35bbaa970cf7d0422829f215c4162f)RemoveEncyclopediaBookmarkFromItem() [4/7]
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.RemoveEncyclopediaBookmarkFromItem | ( | [Concept](class_tale_worlds_1_1_campaign_system_1_1_concept.html) | *concept* | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#ab82bc6ac9048208a5710f566242b5b92).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#aa70a598402d9b16b8822df310d536674)RemoveEncyclopediaBookmarkFromItem() [5/7]
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.RemoveEncyclopediaBookmarkFromItem | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom* | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#a5de2ee240cd9012821144c81422251bb).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a6b8a7de543b3af999efeb236d443f29d)RemoveEncyclopediaBookmarkFromItem() [6/7]
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.RemoveEncyclopediaBookmarkFromItem | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#a3bc4ff6127c11fb848e05e1e6761e0c0).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a78631ef363e99e0ba06ae06f6cf13b0b)RemoveEncyclopediaBookmarkFromItem() [7/7]
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.RemoveEncyclopediaBookmarkFromItem | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *unit* | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#a44fe6fe8eff728d6c63af0594593634d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a01b583e023374cbfca7dd3e97b062ca6)IsEncyclopediaBookmarked() [1/7]
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.IsEncyclopediaBookmarked | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#a9a0878e81aa32f9fe485947612e897d2).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#afdd50f4fcdbf50c35995814da3fb8b80)IsEncyclopediaBookmarked() [2/7]
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.IsEncyclopediaBookmarked | ( | [ShipHull](class_tale_worlds_1_1_core_1_1_ship_hull.html) | *shipHull* | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#a0cfd6545bbf92d1f168e9e34fe25a7be).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a1dd06c59c9fa6e304cac70236d05e75f)IsEncyclopediaBookmarked() [3/7]
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.IsEncyclopediaBookmarked | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#a38c7bc12aa058acb5222fd313019cb14).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a1c01f3713236572a6279d72740839176)IsEncyclopediaBookmarked() [4/7]
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.IsEncyclopediaBookmarked | ( | [Concept](class_tale_worlds_1_1_campaign_system_1_1_concept.html) | *concept* | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#af8cc0be66c302f17580d5260ef587711).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a18ac41b70140ab7939c3bbc711c3f51c)IsEncyclopediaBookmarked() [5/7]
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.IsEncyclopediaBookmarked | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom* | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#a7e6f0ee22a0b6fa9b7700a619a365eef).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a4665ed8401ba58edc28d6c8cc50c18da)IsEncyclopediaBookmarked() [6/7]
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.IsEncyclopediaBookmarked | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#a8f18b7bf8c90e2b7210a0e4e2ce74d8f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a0e1e0d2abef546629cc95354a9af80d2)IsEncyclopediaBookmarked() [7/7]
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.IsEncyclopediaBookmarked | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *unit* | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#a1c2cee5002291c4c7ed317f1baf993fc).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a0044e4d160e99816dd81f7f83e86228f)SetQuestSelection()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.SetQuestSelection | ( | [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) | *selection* | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#a4031b822bbab6f435024275641078d12).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a7184e56136a4f386977da1c80eb2a9c4)GetQuestSelection()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.GetQuestSelection | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#ae2faceeb31b4e1db1f3c35337eec539b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a6edf5cf88fe06d693a971c0c2bcaac6a)GetPlunderItems()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| MBReadOnlyList< [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) > TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.GetPlunderItems | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#aaee5d86ffc4589032d57f4d0bb2a148b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a2ea912db417e842bce61bca9f8d6bc86)OnFigureheadExamined()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.OnFigureheadExamined | ( | [Figurehead](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_figurehead.html) | *figurehead* | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#a1dff971bbe47c191101b7d2f0cfda698).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#ae8146b5da927ef02be2d8f77587b839c)RegisterEvents()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a39a1cb300e12ba93a99e2158323510e0)SetQuestSortTypeSelection()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.SetQuestSortTypeSelection | ( | int | *questSortTypeSelection* | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#a9966b676f621e866765a2448f68eacbb).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a99667d3a0d0aa650cab1f2df7355da2f)GetQuestSortTypeSelection()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.GetQuestSortTypeSelection | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#a47727512d6ee37bfe9085fb2d8e6840b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a7d707bd1853b6892351c3deac7c2efd4)SyncData()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#ada562ce94548433888c1c6e67be7a7ef)IsPartyNotificationActive
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.IsPartyNotificationActive | | get |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#a6208af1743f34060423af786be17de41).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a49de0854ebdb143f47450ab47425ca78)IsQuestNotificationActive
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.IsQuestNotificationActive | | get |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#a75de59e687e4cdf95a068907c17e82a5).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a08476065832b21785ab8f48eca9f4d1f)UnExaminedQuestLogs
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IReadOnlyList<[JournalLog](class_tale_worlds_1_1_campaign_system_1_1_journal_log.html)> TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.UnExaminedQuestLogs | | get |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#add770d1b8ea9e0f41045169932b51ca9).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#af2c8404a6b47225ae6e451e897cb0d72)UnExaminedArmies
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[Army](class_tale_worlds_1_1_campaign_system_1_1_army.html)> TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.UnExaminedArmies | | get |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#ae78fb46f0c7b2ed24f76a1128f77e2e9).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#ae168227e7ec6c9e584cfc1844b901809)NumOfKingdomArmyNotifications
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.NumOfKingdomArmyNotifications | | get |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#a20862b17f6edc2efca93209b190dc0fa).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a36d704eadfcf2feb93618c58f71f3980)IsCharacterNotificationActive
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.IsCharacterNotificationActive | | get |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#a2155fc0910c4ce23b43210514cf9e6c4).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_view_data_tracker_campaign_behavior.html#a9fe969c475dfc639f0e83060531309b4)UnexaminedFigureheads
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IReadOnlyList<[Figurehead](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_figurehead.html)> TaleWorlds.CampaignSystem.CampaignBehaviors.ViewDataTrackerCampaignBehavior.UnexaminedFigureheads | | get |

Implements [TaleWorlds.CampaignSystem.IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html#a8c5aa4d56d5ea07f234a3c5ecc72ca88).

