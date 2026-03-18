--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html ---

TaleWorlds.CampaignSystem.Roster.ItemRoster Class ReferenceInherits IReadOnlyList, and [TaleWorlds.Library.ISerializableObject](interface_tale_worlds_1_1_library_1_1_i_serializable_object.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a157e0d6162c86702891d0c1dcc6de73f) () |
|  | [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a88aac9de7e4d06371bcd755468279db4) (ItemRoster other) |
| int | [FindIndexOfItem](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a8120b48dca09fe0faa43e10f48868529) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item) |
| int | [FindIndex](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#ae014b82f709c75a026c6461bb96efe84) (Predicate< [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) > predicate) |
| int | [FindIndexFirstAfterXthElement](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a64fa17e9df3b741d3d50d28d95c8772b) (Predicate< [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) > predicate, int x) |
| int | [FindIndexOfElement](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a6a09a493d3c0c3073129675e2c3e6012) ([EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) rosterElement) |
| int | [AddToCounts](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#ab4dab2a2193ac311b1f251612db00a65) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item, int number) |
| int | [AddToCounts](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a4a0f84c23e9d6eaa071e0a549749276d) ([EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) rosterElement, int number) |
| [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) | [GetElementCopyAtIndex](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#ad0f44c0c94f882d2bf63d15028996526) (int index) |
| [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | [GetItemAtIndex](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a45c7e5f782d020276acb88da21ea350d) (int index) |
| int | [GetElementNumber](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a7626048e096b6fecc34d3f5967bb06ec) (int index) |
| int | [GetElementUnitCost](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#ab89c2e8ab44bc067f4b3f306019f92ab) (int index) |
| int | [GetItemNumber](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a9f44d2b96fa3677efad39a1d5406512d) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item) |
| void | [Clear](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#ae491c9696cb6da6db8da520b21c7b230) () |
| IEnumerator< [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) > | [GetEnumerator](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a99390e8235c48667f5b2f437535e2157) () |
| int | [SelectRandomIndex](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a3705508da095a3e41e6cf4a444fdeaa1) (Func< [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html), float > weightFunction) |
| IEnumerable< [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) > | [RemoveIf](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a2eb58fe4059e179dd988046cb5a7dc1c) (Func< [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html), int > match) |
| void | [Add](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a4cc764f2f85931be8209d9d375b39658) (IEnumerable< [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) > rosterElementList) |
| void | [Add](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a1faf62e47c04a07781206cad89be460d) ([ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) itemRosterElement) |
| void | [Remove](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a9da4b758120c91b2c848bb9d3c9bd864) ([ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) itemRosterElement) |
| delegate void | [RosterUpdatedEventDelegate](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a800b1be706991d7a0efc8328561f2ce5) ([ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) item, int count) |
| void | [UpdateVersion](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#ab6718b08c072d7c944f25513a22284db) () |
| void | [OnLoadStarted](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#aebc9dfe26364837aef7ff3fbc986eb6e) (MetaData metaData) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static bool | [RostersAreIdentical](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a88b65c5af299cebdefc1d8240b10d335) ([ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a157e0d6162c86702891d0c1dcc6de73f) a, [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a157e0d6162c86702891d0c1dcc6de73f) b) |
| static void | [CalculateCachedStatsOnLoad](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a21ec259c8bf753aa86b642d7792ad56b) () |

|  |  |
| --- | --- |
| Properties | |
| [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) | [this[int index]](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a4147424a11a55994f5f1eb39a8403a8f) `[get]` |
| int | [Count](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a8e2fc152bcac2f4bcf7379e1ff8d6b27) `[get]` |
| int | [VersionNo](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#aac124cfac5014ea4935959ad4bfe0cdb) `[get]` |
| int | [TotalFood](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#ac15ad293bcfacf4d6064fadfe89a869e) `[get]` |
| int | [FoodVariety](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a608926e6739ca7db31268c357059c66f) `[get]` |
| int | [TotalValue](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#ab8321e3e6aed099adbcd981986e3f552) `[get]` |
| int | [TradeGoodsTotalValue](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a049d2410bee34a5f202388e934967393) `[get]` |
| int | [NumberOfPackAnimals](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#af6972c3f5ab4502c33ff76447505ed57) `[get]` |
| int | [NumberOfLivestockAnimals](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#ae58081e047e23bd43af55f88e41405f9) `[get]` |
| int | [NumberOfMounts](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#ad94b28794a396fcd717b6e6c24b14d17) `[get]` |

|  |  |
| --- | --- |
| Events | |
| [RosterUpdatedEventDelegate](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a800b1be706991d7a0efc8328561f2ce5) | [RosterUpdatedEvent](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a83e8df07cd817d9dd3730ee74c5f14fb) `[add, remove]` |
|  | Use this event to listen to roster updates. When roster is cleared, this event is fired with an empty roster element and with count = 0. |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a157e0d6162c86702891d0c1dcc6de73f)ItemRoster() [1/2]
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Roster.ItemRoster.ItemRoster | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a88aac9de7e4d06371bcd755468279db4)ItemRoster() [2/2]
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Roster.ItemRoster.ItemRoster | ( | ItemRoster | *other* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a8120b48dca09fe0faa43e10f48868529)FindIndexOfItem()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Roster.ItemRoster.FindIndexOfItem | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#ae014b82f709c75a026c6461bb96efe84)FindIndex()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Roster.ItemRoster.FindIndex | ( | Predicate< [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) > | *predicate* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a64fa17e9df3b741d3d50d28d95c8772b)FindIndexFirstAfterXthElement()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Roster.ItemRoster.FindIndexFirstAfterXthElement | ( | Predicate< [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) > | *predicate*, |
|  |  | int | *x* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a6a09a493d3c0c3073129675e2c3e6012)FindIndexOfElement()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Roster.ItemRoster.FindIndexOfElement | ( | [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) | *rosterElement* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#ab4dab2a2193ac311b1f251612db00a65)AddToCounts() [1/2]
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Roster.ItemRoster.AddToCounts | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item*, |
|  |  | int | *number* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a4a0f84c23e9d6eaa071e0a549749276d)AddToCounts() [2/2]
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Roster.ItemRoster.AddToCounts | ( | [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) | *rosterElement*, |
|  |  | int | *number* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#ad0f44c0c94f882d2bf63d15028996526)GetElementCopyAtIndex()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) TaleWorlds.CampaignSystem.Roster.ItemRoster.GetElementCopyAtIndex | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a45c7e5f782d020276acb88da21ea350d)GetItemAtIndex()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) TaleWorlds.CampaignSystem.Roster.ItemRoster.GetItemAtIndex | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a7626048e096b6fecc34d3f5967bb06ec)GetElementNumber()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Roster.ItemRoster.GetElementNumber | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#ab89c2e8ab44bc067f4b3f306019f92ab)GetElementUnitCost()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Roster.ItemRoster.GetElementUnitCost | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a9f44d2b96fa3677efad39a1d5406512d)GetItemNumber()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Roster.ItemRoster.GetItemNumber | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#ae491c9696cb6da6db8da520b21c7b230)Clear()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Roster.ItemRoster.Clear | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a88b65c5af299cebdefc1d8240b10d335)RostersAreIdentical()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.Roster.ItemRoster.RostersAreIdentical | ( | [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a157e0d6162c86702891d0c1dcc6de73f) | *a*, | |  |  | [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a157e0d6162c86702891d0c1dcc6de73f) | *b* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a99390e8235c48667f5b2f437535e2157)GetEnumerator()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerator< [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) > TaleWorlds.CampaignSystem.Roster.ItemRoster.GetEnumerator | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a3705508da095a3e41e6cf4a444fdeaa1)SelectRandomIndex()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Roster.ItemRoster.SelectRandomIndex | ( | Func< [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html), float > | *weightFunction* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a2eb58fe4059e179dd988046cb5a7dc1c)RemoveIf()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| IEnumerable< [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) > TaleWorlds.CampaignSystem.Roster.ItemRoster.RemoveIf | ( | Func< [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html), int > | *match* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a4cc764f2f85931be8209d9d375b39658)Add() [1/2]
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Roster.ItemRoster.Add | ( | IEnumerable< [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) > | *rosterElementList* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a1faf62e47c04a07781206cad89be460d)Add() [2/2]
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Roster.ItemRoster.Add | ( | [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) | *itemRosterElement* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a9da4b758120c91b2c848bb9d3c9bd864)Remove()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Roster.ItemRoster.Remove | ( | [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) | *itemRosterElement* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a800b1be706991d7a0efc8328561f2ce5)RosterUpdatedEventDelegate()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate void TaleWorlds.CampaignSystem.Roster.ItemRoster.RosterUpdatedEventDelegate | ( | [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) | *item*, |
|  |  | int | *count* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#ab6718b08c072d7c944f25513a22284db)UpdateVersion()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Roster.ItemRoster.UpdateVersion | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#aebc9dfe26364837aef7ff3fbc986eb6e)OnLoadStarted()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Roster.ItemRoster.OnLoadStarted | ( | MetaData | *metaData* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a21ec259c8bf753aa86b642d7792ad56b)CalculateCachedStatsOnLoad()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Roster.ItemRoster.CalculateCachedStatsOnLoad | ( |  | ) |  | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a4147424a11a55994f5f1eb39a8403a8f)this[int index]
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) TaleWorlds.CampaignSystem.Roster.ItemRoster.this[int index] | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a8e2fc152bcac2f4bcf7379e1ff8d6b27)Count
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Roster.ItemRoster.Count | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#aac124cfac5014ea4935959ad4bfe0cdb)VersionNo
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Roster.ItemRoster.VersionNo | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#ac15ad293bcfacf4d6064fadfe89a869e)TotalFood
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Roster.ItemRoster.TotalFood | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a608926e6739ca7db31268c357059c66f)FoodVariety
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Roster.ItemRoster.FoodVariety | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#ab8321e3e6aed099adbcd981986e3f552)TotalValue
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Roster.ItemRoster.TotalValue | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a049d2410bee34a5f202388e934967393)TradeGoodsTotalValue
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Roster.ItemRoster.TradeGoodsTotalValue | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#af6972c3f5ab4502c33ff76447505ed57)NumberOfPackAnimals
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Roster.ItemRoster.NumberOfPackAnimals | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#ae58081e047e23bd43af55f88e41405f9)NumberOfLivestockAnimals
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Roster.ItemRoster.NumberOfLivestockAnimals | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#ad94b28794a396fcd717b6e6c24b14d17)NumberOfMounts
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Roster.ItemRoster.NumberOfMounts | | get |

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a83e8df07cd817d9dd3730ee74c5f14fb)RosterUpdatedEvent
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [RosterUpdatedEventDelegate](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html#a800b1be706991d7a0efc8328561f2ce5) TaleWorlds.CampaignSystem.Roster.ItemRoster.RosterUpdatedEvent | | addremove |

