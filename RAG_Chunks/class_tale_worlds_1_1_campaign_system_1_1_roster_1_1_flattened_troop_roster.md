--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html ---

TaleWorlds.CampaignSystem.Roster.FlattenedTroopRoster Class ReferenceInherits IEnumerable.

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html#af455bbece47c183aa8976d8b1fbf4b86) (int count=4) |
|  | [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html#a5199beb0c73f808c65a12c89e8ca5ccb) ([TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) roster) |
|  | [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html#a572d4f1e05725dc37af37032e8243f12) (FlattenedTroopRoster other) |
| void | [Add](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html#a7d45f5225fd46c28feeab10f0733d774) (MBList< [TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html) > roster) |
| void | [Add](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html#a0b965b11550702fdbea3d572c2c47595) ([TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html) troop) |
| void | [Add](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html#a9a606fa4fd5c0e14b01e61d883875d53) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) troop, int number, int woundedNumber=0) |
| [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) | [Add](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html#aa46b9cc68cee7aa61a470b5369cb8c08) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) troop, bool isWounded=false, int xp=0) |
| void | [Remove](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html#aa24372a027e919b599b4c507b8b9cd52) ([UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) descriptor) |
| void | [Clear](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html#a9b8e8595e05b50bace86a5048a805426) () |
| ICollection< [FlattenedTroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html) > | [RemoveIf](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html#a703eb58e6dcbc7ac3c4833442172f79a) (Predicate< [FlattenedTroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html) > match) |
| [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) | [FindIndexOfCharacter](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html#a666a5db98d22e5307a16757bce7b04de) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| IEnumerator< [FlattenedTroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html) > | [GetEnumerator](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html#a004af90c861b232296f543ecff5fc4bd) () |
| void | [OnTroopKilled](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html#af0bc571540c1a2a22edad944d2c876f9) ([UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) troopSeed) |
| void | [OnTroopWounded](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html#af1c77204f101b50bf93fd21f2adcdec5) ([UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) troopSeed) |
| void | [OnTroopRouted](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html#afa07188d84d556abcbc384c6d191d16f) ([UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) troopSeed) |
| void | [OnTroopGainXp](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html#afeebe2b7b09e90111c6aa4f5cf8566c4) ([UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) troopSeed, int xpGained) |
| void | [ResetTroopXP](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html#aa453c37e08463280ab329a73a06dc0b3) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static int | [GenerateUniqueNoFromParty](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html#a49d4c73eb431f5b69893de2209336f65) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, int troopIndex) |

|  |  |
| --- | --- |
| Properties | |
| [FlattenedTroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html) | [this[UniqueTroopDescriptor index]](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html#a360c32e9381eaf40ec1c6e1c1a532cce) `[get, set]` |
| IEnumerable< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > | [Troops](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html#afe3b7387c8ad0b947fb96c2953e0bab5) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html#af455bbece47c183aa8976d8b1fbf4b86)FlattenedTroopRoster() [1/3]
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Roster.FlattenedTroopRoster.FlattenedTroopRoster | ( | int | *count* = 4 | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html#a5199beb0c73f808c65a12c89e8ca5ccb)FlattenedTroopRoster() [2/3]
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Roster.FlattenedTroopRoster.FlattenedTroopRoster | ( | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *roster* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html#a572d4f1e05725dc37af37032e8243f12)FlattenedTroopRoster() [3/3]
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Roster.FlattenedTroopRoster.FlattenedTroopRoster | ( | FlattenedTroopRoster | *other* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html#a7d45f5225fd46c28feeab10f0733d774)Add() [1/4]
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Roster.FlattenedTroopRoster.Add | ( | MBList< [TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html) > | *roster* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html#a0b965b11550702fdbea3d572c2c47595)Add() [2/4]
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Roster.FlattenedTroopRoster.Add | ( | [TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html) | *troop* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html#a9a606fa4fd5c0e14b01e61d883875d53)Add() [3/4]
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Roster.FlattenedTroopRoster.Add | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *troop*, |
|  |  | int | *number*, |
|  |  | int | *woundedNumber* = 0 ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html#aa46b9cc68cee7aa61a470b5369cb8c08)Add() [4/4]
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) TaleWorlds.CampaignSystem.Roster.FlattenedTroopRoster.Add | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *troop*, |
|  |  | bool | *isWounded* = false, |
|  |  | int | *xp* = 0 ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html#a49d4c73eb431f5b69893de2209336f65)GenerateUniqueNoFromParty()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.Roster.FlattenedTroopRoster.GenerateUniqueNoFromParty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | int | *troopIndex* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html#aa24372a027e919b599b4c507b8b9cd52)Remove()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Roster.FlattenedTroopRoster.Remove | ( | [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) | *descriptor* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html#a9b8e8595e05b50bace86a5048a805426)Clear()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Roster.FlattenedTroopRoster.Clear | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html#a703eb58e6dcbc7ac3c4833442172f79a)RemoveIf()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| ICollection< [FlattenedTroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html) > TaleWorlds.CampaignSystem.Roster.FlattenedTroopRoster.RemoveIf | ( | Predicate< [FlattenedTroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html) > | *match* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html#a666a5db98d22e5307a16757bce7b04de)FindIndexOfCharacter()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) TaleWorlds.CampaignSystem.Roster.FlattenedTroopRoster.FindIndexOfCharacter | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html#a004af90c861b232296f543ecff5fc4bd)GetEnumerator()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerator< [FlattenedTroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html) > TaleWorlds.CampaignSystem.Roster.FlattenedTroopRoster.GetEnumerator | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html#af0bc571540c1a2a22edad944d2c876f9)OnTroopKilled()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Roster.FlattenedTroopRoster.OnTroopKilled | ( | [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) | *troopSeed* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html#af1c77204f101b50bf93fd21f2adcdec5)OnTroopWounded()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Roster.FlattenedTroopRoster.OnTroopWounded | ( | [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) | *troopSeed* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html#afa07188d84d556abcbc384c6d191d16f)OnTroopRouted()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Roster.FlattenedTroopRoster.OnTroopRouted | ( | [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) | *troopSeed* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html#afeebe2b7b09e90111c6aa4f5cf8566c4)OnTroopGainXp()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Roster.FlattenedTroopRoster.OnTroopGainXp | ( | [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) | *troopSeed*, |
|  |  | int | *xpGained* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html#aa453c37e08463280ab329a73a06dc0b3)ResetTroopXP()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Roster.FlattenedTroopRoster.ResetTroopXP | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html#a360c32e9381eaf40ec1c6e1c1a532cce)this[UniqueTroopDescriptor index]
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [FlattenedTroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html) TaleWorlds.CampaignSystem.Roster.FlattenedTroopRoster.this[[UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) index] | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html#afe3b7387c8ad0b947fb96c2953e0bab5)Troops
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IEnumerable<[CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html)> TaleWorlds.CampaignSystem.Roster.FlattenedTroopRoster.Troops | | get |

