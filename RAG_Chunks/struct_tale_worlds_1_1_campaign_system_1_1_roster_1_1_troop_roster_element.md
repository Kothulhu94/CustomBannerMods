--- SOURCE: struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html ---

TaleWorlds.CampaignSystem.Roster.TroopRosterElement Struct ReferenceInherits [TaleWorlds.Library.ISerializableObject](interface_tale_worlds_1_1_library_1_1_i_serializable_object.html), and ISavedStruct.

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html#a7e1b3eca1450eddd1084ceac2f48ab12) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| void ISerializableObject. | [SerializeTo](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html#acf17971ce0cf5d2e93ea7a70069db5bb) ([IWriter](interface_tale_worlds_1_1_library_1_1_i_writer.html) writer) |
| void ISerializableObject. | [DeserializeFrom](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html#a081216b4559cf54585841a5a408a6322) ([IReader](interface_tale_worlds_1_1_library_1_1_i_reader.html) reader) |
| override string | [ToString](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html#a32f8356d37b94526dbbdb7e8376eb6d6) () |
| override bool | [Equals](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html#a93086217a743566d6e87801cfa7b1948) (object obj) |
| bool | [Equals](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html#a4b1890780b3965c9e2bd750ce8332e16) ([TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html#a7e1b3eca1450eddd1084ceac2f48ab12) other) |
| override int | [GetHashCode](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html#a954063ebebf3b24f2fc9acb91dcc3029) () |
| bool ISavedStruct. | [IsDefault](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html#a35d075f239bd46abf0377b6f1bbb2f1b) () |

|  |  |
| --- | --- |
| Public Attributes | |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [Character](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html#adb2a13f574df13a15df5ab876ebfaeec) |

|  |  |
| --- | --- |
| Properties | |
| static [TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html#a7e1b3eca1450eddd1084ceac2f48ab12) | [Invalid](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html#a8205c47721604a16010938ef27b1d43b) `[get]` |
| int | [Number](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html#ac4d62a5846e0be3649394f16862d78b3) `[get, set]` |
| int | [WoundedNumber](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html#a3e90dd77814ad42058792e08a02ef9d2) `[get, set]` |
| int | [Xp](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html#a18536889b4d9751cdc870b3b2d986929) `[get, set]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html#a7e1b3eca1450eddd1084ceac2f48ab12)TroopRosterElement()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Roster.TroopRosterElement.TroopRosterElement | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character* | ) |  |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html#acf17971ce0cf5d2e93ea7a70069db5bb)SerializeTo()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void ISerializableObject. TaleWorlds.CampaignSystem.Roster.TroopRosterElement.SerializeTo | ( | [IWriter](interface_tale_worlds_1_1_library_1_1_i_writer.html) | *writer* | ) |  |

Implements [TaleWorlds.Library.ISerializableObject](interface_tale_worlds_1_1_library_1_1_i_serializable_object.html#aac913af86c2a4128993048fc2023b4de).

[◆](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html#a081216b4559cf54585841a5a408a6322)DeserializeFrom()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void ISerializableObject. TaleWorlds.CampaignSystem.Roster.TroopRosterElement.DeserializeFrom | ( | [IReader](interface_tale_worlds_1_1_library_1_1_i_reader.html) | *reader* | ) |  |

Implements [TaleWorlds.Library.ISerializableObject](interface_tale_worlds_1_1_library_1_1_i_serializable_object.html#aaaf5181fea51c7c2d4e365efe82bc703).

[◆](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html#a32f8356d37b94526dbbdb7e8376eb6d6)ToString()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.CampaignSystem.Roster.TroopRosterElement.ToString | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html#a93086217a743566d6e87801cfa7b1948)Equals() [1/2]
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.Roster.TroopRosterElement.Equals | ( | object | *obj* | ) |  |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html#a4b1890780b3965c9e2bd750ce8332e16)Equals() [2/2]
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Roster.TroopRosterElement.Equals | ( | [TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html#a7e1b3eca1450eddd1084ceac2f48ab12) | *other* | ) |  |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html#a954063ebebf3b24f2fc9acb91dcc3029)GetHashCode()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.Roster.TroopRosterElement.GetHashCode | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html#a35d075f239bd46abf0377b6f1bbb2f1b)IsDefault()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool ISavedStruct. TaleWorlds.CampaignSystem.Roster.TroopRosterElement.IsDefault | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html#adb2a13f574df13a15df5ab876ebfaeec)Character
-------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.Roster.TroopRosterElement.Character |

Property Documentation
----------------------

[◆](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html#a8205c47721604a16010938ef27b1d43b)Invalid
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html#a7e1b3eca1450eddd1084ceac2f48ab12) TaleWorlds.CampaignSystem.Roster.TroopRosterElement.Invalid | | staticget |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html#ac4d62a5846e0be3649394f16862d78b3)Number
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Roster.TroopRosterElement.Number | | getset |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html#a3e90dd77814ad42058792e08a02ef9d2)WoundedNumber
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Roster.TroopRosterElement.WoundedNumber | | getset |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html#a18536889b4d9751cdc870b3b2d986929)Xp
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Roster.TroopRosterElement.Xp | | getset |

