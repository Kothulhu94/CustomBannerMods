--- SOURCE: struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html ---

TaleWorlds.CampaignSystem.Roster.FlattenedTroopRosterElement Struct ReferenceInherits ISavedStruct.

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [FlattenedTroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html#a575b46c50827aca31a4462c8da4c309b) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) troop, [RosterTroopState](namespace_tale_worlds_1_1_campaign_system_1_1_roster.html#a36e8f9e538bd39b1bc74cc15ef0deae4) state=[RosterTroopState.Active](namespace_tale_worlds_1_1_campaign_system_1_1_roster.html#a36e8f9e538bd39b1bc74cc15ef0deae4a4d3d769b812b6faa6b76e1a8abaece2d), int xp=0, [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) uniqueNo=default([UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html)), int xpGain=0) |
|  | [FlattenedTroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html#a9748f0397b783bc7bb37ddb08b0c4902) (FlattenedTroopRosterElement rosterElement, [RosterTroopState](namespace_tale_worlds_1_1_campaign_system_1_1_roster.html#a36e8f9e538bd39b1bc74cc15ef0deae4) state) |
| override string | [ToString](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html#abde748f9c58177ca8c10daa15f7c3d41) () |
| bool ISavedStruct. | [IsDefault](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html#a23030d217ca1426851bc1f6a1548f137) () |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static readonly [FlattenedTroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html#a575b46c50827aca31a4462c8da4c309b) | [DefaultFlattenedTroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html#ac666be472fcb3d09423ceb52b0fe940c) = new [FlattenedTroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html#a575b46c50827aca31a4462c8da4c309b)() |

|  |  |
| --- | --- |
| Properties | |
| [RosterTroopState](namespace_tale_worlds_1_1_campaign_system_1_1_roster.html#a36e8f9e538bd39b1bc74cc15ef0deae4) | [State](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html#a1f958d1a85985940fb1cbd537c6d4fcf) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [Troop](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html#a929209c4a8433d16095107ca2861481b) `[get]` |
| bool | [IsWounded](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html#a76e693616a0ec19d7fa99a4a78eee37f) `[get, set]` |
| bool | [IsRouted](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html#ab3535da1df67ee8d21abc70978d61df2) `[get, set]` |
| bool | [IsKilled](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html#ad51dd82b78fa00709923718044227e4b) `[get, set]` |
| int | [Xp](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html#abb394c24748046a3e7bcbb2fac862903) `[get]` |
| int | [XpGained](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html#a236bb52d690cfcd083c0ed898136566b) `[get]` |
| [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) | [Descriptor](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html#a372dfd4a5568950012abee2363a5b2be) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html#a575b46c50827aca31a4462c8da4c309b)FlattenedTroopRosterElement() [1/2]
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Roster.FlattenedTroopRosterElement.FlattenedTroopRosterElement | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *troop*, |
|  |  | [RosterTroopState](namespace_tale_worlds_1_1_campaign_system_1_1_roster.html#a36e8f9e538bd39b1bc74cc15ef0deae4) | *state* = [RosterTroopState::Active](namespace_tale_worlds_1_1_campaign_system_1_1_roster.html#a36e8f9e538bd39b1bc74cc15ef0deae4a4d3d769b812b6faa6b76e1a8abaece2d), |
|  |  | int | *xp* = 0, |
|  |  | [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) | *uniqueNo* = default([UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html)), |
|  |  | int | *xpGain* = 0 ) |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html#a9748f0397b783bc7bb37ddb08b0c4902)FlattenedTroopRosterElement() [2/2]
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Roster.FlattenedTroopRosterElement.FlattenedTroopRosterElement | ( | FlattenedTroopRosterElement | *rosterElement*, |
|  |  | [RosterTroopState](namespace_tale_worlds_1_1_campaign_system_1_1_roster.html#a36e8f9e538bd39b1bc74cc15ef0deae4) | *state* ) |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html#abde748f9c58177ca8c10daa15f7c3d41)ToString()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.CampaignSystem.Roster.FlattenedTroopRosterElement.ToString | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html#a23030d217ca1426851bc1f6a1548f137)IsDefault()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool ISavedStruct. TaleWorlds.CampaignSystem.Roster.FlattenedTroopRosterElement.IsDefault | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html#ac666be472fcb3d09423ceb52b0fe940c)DefaultFlattenedTroopRosterElement
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [FlattenedTroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html#a575b46c50827aca31a4462c8da4c309b) TaleWorlds.CampaignSystem.Roster.FlattenedTroopRosterElement.DefaultFlattenedTroopRosterElement = new [FlattenedTroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html#a575b46c50827aca31a4462c8da4c309b)() | | static |

Property Documentation
----------------------

[◆](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html#a1f958d1a85985940fb1cbd537c6d4fcf)State
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [RosterTroopState](namespace_tale_worlds_1_1_campaign_system_1_1_roster.html#a36e8f9e538bd39b1bc74cc15ef0deae4) TaleWorlds.CampaignSystem.Roster.FlattenedTroopRosterElement.State | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html#a929209c4a8433d16095107ca2861481b)Troop
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.Roster.FlattenedTroopRosterElement.Troop | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html#a76e693616a0ec19d7fa99a4a78eee37f)IsWounded
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Roster.FlattenedTroopRosterElement.IsWounded | | getset |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html#ab3535da1df67ee8d21abc70978d61df2)IsRouted
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Roster.FlattenedTroopRosterElement.IsRouted | | getset |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html#ad51dd82b78fa00709923718044227e4b)IsKilled
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Roster.FlattenedTroopRosterElement.IsKilled | | getset |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html#abb394c24748046a3e7bcbb2fac862903)Xp
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Roster.FlattenedTroopRosterElement.Xp | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html#a236bb52d690cfcd083c0ed898136566b)XpGained
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Roster.FlattenedTroopRosterElement.XpGained | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html#a372dfd4a5568950012abee2363a5b2be)Descriptor
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) TaleWorlds.CampaignSystem.Roster.FlattenedTroopRosterElement.Descriptor | | get |

