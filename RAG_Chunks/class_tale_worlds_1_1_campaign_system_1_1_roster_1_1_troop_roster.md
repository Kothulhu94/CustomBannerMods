--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html ---

TaleWorlds.CampaignSystem.Roster.TroopRoster Class ReferenceInherits [TaleWorlds.Library.ISerializableObject](interface_tale_worlds_1_1_library_1_1_i_serializable_object.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a79fcc89606f6c93cfdd67a4c423294de) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) ownerParty) |
| override int | [GetHashCode](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a13c5edca89a29fc0acbc1c9863679fc0) () |
| [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) | [ToFlattenedRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#abd11a05a1e22281eb78533c64425d871) () |
| void | [Add](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a24e7260e1b02e9d5cdb8baa049a6fcff) ([TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a79fcc89606f6c93cfdd67a4c423294de) troopRoster) |
| void | [Add](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a77dc5c7b36852a81452558bc797ac077) ([TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html) troopRosterElement) |
| ICollection< [TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html) > | [RemoveIf](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a3d245e66991fdc28e00eb738d50fb020) (Predicate< [TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html) > match) |
| int | [FindIndexOfTroop](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a6aec9089861b8531ef5e0cf92f21aedf) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
|  | Finds index of specified character in the roster. Returns a negative number if not found. |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a79fcc89606f6c93cfdd67a4c423294de) | [RemoveNumberOfNonHeroTroopsRandomly](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a858f5c1aa4b5fa16c42186af2538c285) (int numberOfMen) |
| void | [WoundNumberOfNonHeroTroopsRandomly](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a3a33b76ad09e7cf8e79d4d53c26aaf65) (int numberOfMen) |
| void | [SwapTroopsAtIndices](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a7c12e0162341cdf06e822866df696054) (int firstIndex, int secondIndex) |
| void | [ShiftTroopToIndex](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a1edebc9a65ca17a25d5d050eccfc85bc) (int troopIndex, int targetIndex) |
| int | [AddToCountsAtIndex](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a7c53a52b218bf7cc0f606315d6c7ddb1) (int index, int countChange, int woundedCountChange=0, int xpChange=0, bool removeDepleted=true) |
| void | [CheckValidity](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a9714d3019f0f05de476c4be86204f427) () |
| int | [AddToCounts](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#ab4d95f50b52c0081fc84535d556711b6) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, int count, bool insertAtFront=false, int woundedCount=0, int xpChange=0, bool removeDepleted=true, int index=-1) |
| int | [GetTroopCount](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#ae2a2519b1b89d7a38e3523c90eb598b7) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) troop) |
| void | [RemoveZeroCounts](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a37645c385290e358063b10d4510ca91c) () |
| [TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html) | [GetElementCopyAtIndex](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a554f55f587ed2bf183ae9d1b83e7bf29) (int index) |
| void | [SetElementNumber](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a16ae0a1f922ba4ad9492a5be02f7d503) (int index, int number) |
| int | [GetElementNumber](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a30cb2df4c5be255ac884101c485880ee) (int index) |
| int | [GetElementNumber](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#aa6b82a91ed5bf455a42df9c7e58ca22d) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| void | [SetElementWoundedNumber](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a47dfb60baca7bda1d3de5844d5cea976) (int index, int number) |
| int | [GetElementWoundedNumber](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a6a90ea4553a26dab7bde073226de6ad3) (int index) |
| void | [SetElementXp](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a6f37591190c3a7abe64e45339831bbeb) (int index, int number) |
| int | [GetElementXp](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#ac8b1e5a63d9f7af6b7a41fddfcce0ad6) (int index) |
| int | [GetElementXp](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#ad7cc28d9f6532e2545b338f9ab11e779) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [GetCharacterAtIndex](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a609bbbf432badfd4c73f7c71d6f9e67c) (int index) |
| override bool | [Equals](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a567c6ed6f71bc03ecb8859e20b9a4ec7) (object obj) |
| bool | [Contains](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#af854a599009063a0623f0eca487a22ff) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| void | [ValidateTroopListCache](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a2abc609244003af0f6567cdffaa3dc43) () |
| MBList< [TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html) > | [GetTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a505a14ab9dd64c6a2683eabcab2d3c7d) () |
| void | [Clear](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a07a4a5601f61bfe910ee100a3cdbcc41) () |
| void | [RemoveTroop](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#aa527587330d32a2b3b39d94e7dd7d2ac) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) troop, int numberToRemove=1, [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) troopSeed=default([UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html)), int xp=0) |
| void | [WoundTroop](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#ac4a29e26f15ef96d453cd7b9087861a0) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) troop, int numberToWound=1, [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) troopSeed=default([UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html))) |
| int | [Sum](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a7fd81436d91bad8ead30a4e4ce09d33e) (Func< [TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html), int > selector) |
| void | [OnHeroHealthStatusChanged](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a5cf0afae3f747342b26d6fe15446d9af) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| void | [UpdateVersion](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a336bb73d9b1a5ddf331e053265fa93b5) () |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a79fcc89606f6c93cfdd67a4c423294de) | [CloneRosterData](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a0bb809d8d1b909743d7be9881e5807b3) () |
| void | [AddXpToTroop](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a1ed3ba0d1a764b3b7afedf7e6618da3c) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) troop, int xpAmount) |
| void | [AddXpToTroopAtIndex](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a6040595f6dba5c540887d2b05aa94f14) (int index, int xpAmount) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a79fcc89606f6c93cfdd67a4c423294de) | [CreateDummyTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a4cc5ba259d9ecd4a2d5420dc238e427b) () |
| static void | [CalculateCachedStatsOnLoad](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a8ff2d9955705b8c4dea165abd7b242de) () |
| static bool | [RostersAreIdentical](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a88d1dd330fb1cee41ebbcfbd61880842) ([TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a79fcc89606f6c93cfdd67a4c423294de) a, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a79fcc89606f6c93cfdd67a4c423294de) b) |

|  |  |
| --- | --- |
| Properties | |
| int | [Count](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a06ef44046c122e4817f10b47b2ba6d0c) `[get]` |
| int | [VersionNo](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a9f51631815388c9adfe8c53638ad129a) `[get]` |
| int | [TotalRegulars](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a0426d45dd476bd6d0cf94e842568f118) `[get]` |
| int | [TotalWoundedRegulars](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#afd614174dd297b183507c66b073dbf95) `[get]` |
| int | [TotalWoundedHeroes](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a7fbe38062a428f3b2f357dc9f326363b) `[get]` |
| int | [TotalHeroes](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#ac02e429d085efddb10172077fac777a8) `[get]` |
| int | [TotalWounded](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a64efc3acff508260b60fc55fee3b2515) `[get]` |
| int | [TotalManCount](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a20b074185b11dff3d43e15f98ae05ebf) `[get]` |
| int | [TotalHealthyCount](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a469bdc05646576cdc321825214a55f94) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a79fcc89606f6c93cfdd67a4c423294de)TroopRoster()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Roster.TroopRoster.TroopRoster | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *ownerParty* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a4cc5ba259d9ecd4a2d5420dc238e427b)CreateDummyTroopRoster()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a79fcc89606f6c93cfdd67a4c423294de) TaleWorlds.CampaignSystem.Roster.TroopRoster.CreateDummyTroopRoster | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a13c5edca89a29fc0acbc1c9863679fc0)GetHashCode()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.Roster.TroopRoster.GetHashCode | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a8ff2d9955705b8c4dea165abd7b242de)CalculateCachedStatsOnLoad()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Roster.TroopRoster.CalculateCachedStatsOnLoad | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#abd11a05a1e22281eb78533c64425d871)ToFlattenedRoster()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) TaleWorlds.CampaignSystem.Roster.TroopRoster.ToFlattenedRoster | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a24e7260e1b02e9d5cdb8baa049a6fcff)Add() [1/2]
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Roster.TroopRoster.Add | ( | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a79fcc89606f6c93cfdd67a4c423294de) | *troopRoster* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a77dc5c7b36852a81452558bc797ac077)Add() [2/2]
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Roster.TroopRoster.Add | ( | [TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html) | *troopRosterElement* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a3d245e66991fdc28e00eb738d50fb020)RemoveIf()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| ICollection< [TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html) > TaleWorlds.CampaignSystem.Roster.TroopRoster.RemoveIf | ( | Predicate< [TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html) > | *match* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a6aec9089861b8531ef5e0cf92f21aedf)FindIndexOfTroop()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Roster.TroopRoster.FindIndexOfTroop | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | character |  |

Returns
:   index of specified character

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a858f5c1aa4b5fa16c42186af2538c285)RemoveNumberOfNonHeroTroopsRandomly()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a79fcc89606f6c93cfdd67a4c423294de) TaleWorlds.CampaignSystem.Roster.TroopRoster.RemoveNumberOfNonHeroTroopsRandomly | ( | int | *numberOfMen* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a3a33b76ad09e7cf8e79d4d53c26aaf65)WoundNumberOfNonHeroTroopsRandomly()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Roster.TroopRoster.WoundNumberOfNonHeroTroopsRandomly | ( | int | *numberOfMen* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a7c12e0162341cdf06e822866df696054)SwapTroopsAtIndices()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Roster.TroopRoster.SwapTroopsAtIndices | ( | int | *firstIndex*, |
|  |  | int | *secondIndex* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a1edebc9a65ca17a25d5d050eccfc85bc)ShiftTroopToIndex()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Roster.TroopRoster.ShiftTroopToIndex | ( | int | *troopIndex*, |
|  |  | int | *targetIndex* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a7c53a52b218bf7cc0f606315d6c7ddb1)AddToCountsAtIndex()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Roster.TroopRoster.AddToCountsAtIndex | ( | int | *index*, |
|  |  | int | *countChange*, |
|  |  | int | *woundedCountChange* = 0, |
|  |  | int | *xpChange* = 0, |
|  |  | bool | *removeDepleted* = true ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a9714d3019f0f05de476c4be86204f427)CheckValidity()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Roster.TroopRoster.CheckValidity | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#ab4d95f50b52c0081fc84535d556711b6)AddToCounts()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Roster.TroopRoster.AddToCounts | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, |
|  |  | int | *count*, |
|  |  | bool | *insertAtFront* = false, |
|  |  | int | *woundedCount* = 0, |
|  |  | int | *xpChange* = 0, |
|  |  | bool | *removeDepleted* = true, |
|  |  | int | *index* = -1 ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#ae2a2519b1b89d7a38e3523c90eb598b7)GetTroopCount()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Roster.TroopRoster.GetTroopCount | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *troop* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a37645c385290e358063b10d4510ca91c)RemoveZeroCounts()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Roster.TroopRoster.RemoveZeroCounts | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a554f55f587ed2bf183ae9d1b83e7bf29)GetElementCopyAtIndex()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html) TaleWorlds.CampaignSystem.Roster.TroopRoster.GetElementCopyAtIndex | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a16ae0a1f922ba4ad9492a5be02f7d503)SetElementNumber()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Roster.TroopRoster.SetElementNumber | ( | int | *index*, |
|  |  | int | *number* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a30cb2df4c5be255ac884101c485880ee)GetElementNumber() [1/2]
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Roster.TroopRoster.GetElementNumber | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#aa6b82a91ed5bf455a42df9c7e58ca22d)GetElementNumber() [2/2]
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Roster.TroopRoster.GetElementNumber | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a47dfb60baca7bda1d3de5844d5cea976)SetElementWoundedNumber()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Roster.TroopRoster.SetElementWoundedNumber | ( | int | *index*, |
|  |  | int | *number* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a6a90ea4553a26dab7bde073226de6ad3)GetElementWoundedNumber()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Roster.TroopRoster.GetElementWoundedNumber | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a6f37591190c3a7abe64e45339831bbeb)SetElementXp()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Roster.TroopRoster.SetElementXp | ( | int | *index*, |
|  |  | int | *number* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#ac8b1e5a63d9f7af6b7a41fddfcce0ad6)GetElementXp() [1/2]
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Roster.TroopRoster.GetElementXp | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#ad7cc28d9f6532e2545b338f9ab11e779)GetElementXp() [2/2]
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Roster.TroopRoster.GetElementXp | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a609bbbf432badfd4c73f7c71d6f9e67c)GetCharacterAtIndex()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.Roster.TroopRoster.GetCharacterAtIndex | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a567c6ed6f71bc03ecb8859e20b9a4ec7)Equals()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.Roster.TroopRoster.Equals | ( | object | *obj* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a88d1dd330fb1cee41ebbcfbd61880842)RostersAreIdentical()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.Roster.TroopRoster.RostersAreIdentical | ( | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a79fcc89606f6c93cfdd67a4c423294de) | *a*, | |  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a79fcc89606f6c93cfdd67a4c423294de) | *b* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#af854a599009063a0623f0eca487a22ff)Contains()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Roster.TroopRoster.Contains | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a2abc609244003af0f6567cdffaa3dc43)ValidateTroopListCache()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Roster.TroopRoster.ValidateTroopListCache | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a505a14ab9dd64c6a2683eabcab2d3c7d)GetTroopRoster()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| MBList< [TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html) > TaleWorlds.CampaignSystem.Roster.TroopRoster.GetTroopRoster | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a07a4a5601f61bfe910ee100a3cdbcc41)Clear()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Roster.TroopRoster.Clear | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#aa527587330d32a2b3b39d94e7dd7d2ac)RemoveTroop()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Roster.TroopRoster.RemoveTroop | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *troop*, |
|  |  | int | *numberToRemove* = 1, |
|  |  | [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) | *troopSeed* = default([UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html)), |
|  |  | int | *xp* = 0 ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#ac4a29e26f15ef96d453cd7b9087861a0)WoundTroop()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Roster.TroopRoster.WoundTroop | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *troop*, |
|  |  | int | *numberToWound* = 1, |
|  |  | [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) | *troopSeed* = default([UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html)) ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a7fd81436d91bad8ead30a4e4ce09d33e)Sum()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Roster.TroopRoster.Sum | ( | Func< [TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html), int > | *selector* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a5cf0afae3f747342b26d6fe15446d9af)OnHeroHealthStatusChanged()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Roster.TroopRoster.OnHeroHealthStatusChanged | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a336bb73d9b1a5ddf331e053265fa93b5)UpdateVersion()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Roster.TroopRoster.UpdateVersion | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a0bb809d8d1b909743d7be9881e5807b3)CloneRosterData()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a79fcc89606f6c93cfdd67a4c423294de) TaleWorlds.CampaignSystem.Roster.TroopRoster.CloneRosterData | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a1ed3ba0d1a764b3b7afedf7e6618da3c)AddXpToTroop()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Roster.TroopRoster.AddXpToTroop | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *troop*, |
|  |  | int | *xpAmount* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a6040595f6dba5c540887d2b05aa94f14)AddXpToTroopAtIndex()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Roster.TroopRoster.AddXpToTroopAtIndex | ( | int | *index*, |
|  |  | int | *xpAmount* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a06ef44046c122e4817f10b47b2ba6d0c)Count
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Roster.TroopRoster.Count | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a9f51631815388c9adfe8c53638ad129a)VersionNo
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Roster.TroopRoster.VersionNo | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a0426d45dd476bd6d0cf94e842568f118)TotalRegulars
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Roster.TroopRoster.TotalRegulars | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#afd614174dd297b183507c66b073dbf95)TotalWoundedRegulars
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Roster.TroopRoster.TotalWoundedRegulars | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a7fbe38062a428f3b2f357dc9f326363b)TotalWoundedHeroes
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Roster.TroopRoster.TotalWoundedHeroes | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#ac02e429d085efddb10172077fac777a8)TotalHeroes
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Roster.TroopRoster.TotalHeroes | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a64efc3acff508260b60fc55fee3b2515)TotalWounded
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Roster.TroopRoster.TotalWounded | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a20b074185b11dff3d43e15f98ae05ebf)TotalManCount
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Roster.TroopRoster.TotalManCount | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html#a469bdc05646576cdc321825214a55f94)TotalHealthyCount
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Roster.TroopRoster.TotalHealthyCount | | get |

