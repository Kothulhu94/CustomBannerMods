--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_track.html ---

TaleWorlds.CampaignSystem.Track Class ReferencesealedInherits .

|  |  |
| --- | --- |
| Public Types | |
| enum | [PartyTypeEnum](class_tale_worlds_1_1_campaign_system_1_1_track.html#a0cdb2a1fa6388c7776569db8f5596962) {     [Default](class_tale_worlds_1_1_campaign_system_1_1_track.html#a0cdb2a1fa6388c7776569db8f5596962a7a1920d61156abc05a60135aefe8bc67) = 0 ,     [Lord](class_tale_worlds_1_1_campaign_system_1_1_track.html#a0cdb2a1fa6388c7776569db8f5596962af3e6ceb581a478e48c809b70e764f011) ,     [Bandit](class_tale_worlds_1_1_campaign_system_1_1_track.html#a0cdb2a1fa6388c7776569db8f5596962a7534759ceb94c0e91b13a22fe6e16980) ,     [Villager](class_tale_worlds_1_1_campaign_system_1_1_track.html#a0cdb2a1fa6388c7776569db8f5596962a98eb39147854d784623f0060f30905fd) ,     [GarrisonParty](class_tale_worlds_1_1_campaign_system_1_1_track.html#a0cdb2a1fa6388c7776569db8f5596962a847e2153bf6a527a0ae1003bfdb36526) ,     [PartyTypesCount](class_tale_worlds_1_1_campaign_system_1_1_track.html#a0cdb2a1fa6388c7776569db8f5596962a6964db1856cef33f6d27fc84c3dd90de) ,     [Caravan](class_tale_worlds_1_1_campaign_system_1_1_track.html#a0cdb2a1fa6388c7776569db8f5596962ad7f8c7a175f2cf745cc3ff4bd05663ad)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| bool | [CanPartyInteract](class_tale_worlds_1_1_campaign_system_1_1_track.html#a961ec9af1b5d7912793a73e9ba8a021d) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, float dt) |
|  | [Track](class_tale_worlds_1_1_campaign_system_1_1_track.html#ab5d2e7c6734d2ee6c407baecc097c3f4) () |
| void | [Reset](class_tale_worlds_1_1_campaign_system_1_1_track.html#ad42823c50dfebb2c7e697573f6111f67) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [PartyTypeEnum](class_tale_worlds_1_1_campaign_system_1_1_track.html#a0cdb2a1fa6388c7776569db8f5596962) | [GetPartyTypeEnum](class_tale_worlds_1_1_campaign_system_1_1_track.html#a37e4a9d0310201e23e0dfe40b543ccbd) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |

|  |  |
| --- | --- |
| Public Attributes | |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | [Position](class_tale_worlds_1_1_campaign_system_1_1_track.html#a195535f9c9d6a79dff48dc685cd9c3c3) |
| float | [Direction](class_tale_worlds_1_1_campaign_system_1_1_track.html#ad01575b53386c4091aed24948426bfc1) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [PartyName](class_tale_worlds_1_1_campaign_system_1_1_track.html#a335d6392cc2cb1b98e9ae3e61f0b5759) |
| [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | [Culture](class_tale_worlds_1_1_campaign_system_1_1_track.html#af178cb11470984a5e331b18d8be9f8fb) |
| float | [Speed](class_tale_worlds_1_1_campaign_system_1_1_track.html#a1f2b5991a08c04d70b8510ca1d57a14a) |
| int | [NumberOfAllMembers](class_tale_worlds_1_1_campaign_system_1_1_track.html#a1f0804440c53a19934192dc2111ff288) |
| int | [NumberOfHealthyMembers](class_tale_worlds_1_1_campaign_system_1_1_track.html#ae0ee999eee95a979b7a5656ac283c5bf) |
| int | [NumberOfMenWithHorse](class_tale_worlds_1_1_campaign_system_1_1_track.html#a148277a666354f27f483bbd451e64a2a) |
| int | [NumberOfMenWithoutHorse](class_tale_worlds_1_1_campaign_system_1_1_track.html#a791aeb63340d18bf8d2f947edbdac63f) |
| int | [NumberOfPackAnimals](class_tale_worlds_1_1_campaign_system_1_1_track.html#a48d2a695b604c1dac154f4c2eb29f460) |
| int | [NumberOfPrisoners](class_tale_worlds_1_1_campaign_system_1_1_track.html#a8eb6c70f8b0fdadac5cb9c456dae5190) |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [CreationTime](class_tale_worlds_1_1_campaign_system_1_1_track.html#aaddd3a8f676bb95636e778e767466b1d) |
| float | [Life](class_tale_worlds_1_1_campaign_system_1_1_track.html#a2a5969e1d5540237d68fab2434984913) |
| [PartyTypeEnum](class_tale_worlds_1_1_campaign_system_1_1_track.html#a0cdb2a1fa6388c7776569db8f5596962) | [PartyType](class_tale_worlds_1_1_campaign_system_1_1_track.html#a6e8882600464ef044ee71ff083995f7d) |

|  |  |
| --- | --- |
| Properties | |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetPosition2D](class_tale_worlds_1_1_campaign_system_1_1_track.html#ac1619626b57a00e21a58c22a0a7462ba) `[get]` |
| int | [Size](class_tale_worlds_1_1_campaign_system_1_1_track.html#ab84da8030138499bfc3f1ecfa3b0eff8) `[get]` |
| bool | [IsDetected](class_tale_worlds_1_1_campaign_system_1_1_track.html#af67b161c66524ab7aa708f898cb78480) `[get, set]` |
| bool | [IsPointer](class_tale_worlds_1_1_campaign_system_1_1_track.html#ad782c37a3c5142eae8a82c6fd2c44006) `[get, set]` |
| bool | [IsEnemy](class_tale_worlds_1_1_campaign_system_1_1_track.html#a4532221fbc0874d257b37b8eb5ea4ea2) `[get, set]` |
| bool | [IsExpired](class_tale_worlds_1_1_campaign_system_1_1_track.html#a5d0d7277cb80804afa54ea9e1c964d59) `[get]` |
| bool | [IsAlive](class_tale_worlds_1_1_campaign_system_1_1_track.html#a19075d44372cd6581744418da61416fe) `[get]` |
| float | [Scale](class_tale_worlds_1_1_campaign_system_1_1_track.html#adab83e63efcf2cfccab88ad10e48575f) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_track.html#a0cdb2a1fa6388c7776569db8f5596962)PartyTypeEnum
--------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.Track.PartyTypeEnum](class_tale_worlds_1_1_campaign_system_1_1_track.html#a0cdb2a1fa6388c7776569db8f5596962) |

| Enumerator | |
| --- | --- |
| Default |  |
| Lord |  |
| Bandit |  |
| Villager |  |
| GarrisonParty |  |
| PartyTypesCount |  |
| Caravan |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_track.html#ab5d2e7c6734d2ee6c407baecc097c3f4)Track()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Track.Track | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_track.html#a961ec9af1b5d7912793a73e9ba8a021d)CanPartyInteract()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Track.CanPartyInteract | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, |
|  |  | float | *dt* ) |

Implements [TaleWorlds.CampaignSystem.Map.IInteractablePoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_interactable_point.html#aa47ac67abc11ab368ea92ef209fbecd7).

[◆](class_tale_worlds_1_1_campaign_system_1_1_track.html#a37e4a9d0310201e23e0dfe40b543ccbd)GetPartyTypeEnum()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [PartyTypeEnum](class_tale_worlds_1_1_campaign_system_1_1_track.html#a0cdb2a1fa6388c7776569db8f5596962) TaleWorlds.CampaignSystem.Track.GetPartyTypeEnum | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_track.html#ad42823c50dfebb2c7e697573f6111f67)Reset()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Track.Reset | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_track.html#a195535f9c9d6a79dff48dc685cd9c3c3)Position
---------------------------------------------------------------------------------------------------

|  |
| --- |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) TaleWorlds.CampaignSystem.Track.Position |

[◆](class_tale_worlds_1_1_campaign_system_1_1_track.html#ad01575b53386c4091aed24948426bfc1)Direction
----------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.CampaignSystem.Track.Direction |

[◆](class_tale_worlds_1_1_campaign_system_1_1_track.html#a335d6392cc2cb1b98e9ae3e61f0b5759)PartyName
----------------------------------------------------------------------------------------------------

|  |
| --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Track.PartyName |

[◆](class_tale_worlds_1_1_campaign_system_1_1_track.html#af178cb11470984a5e331b18d8be9f8fb)Culture
--------------------------------------------------------------------------------------------------

|  |
| --- |
| [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) TaleWorlds.CampaignSystem.Track.Culture |

[◆](class_tale_worlds_1_1_campaign_system_1_1_track.html#a1f2b5991a08c04d70b8510ca1d57a14a)Speed
------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.CampaignSystem.Track.Speed |

[◆](class_tale_worlds_1_1_campaign_system_1_1_track.html#a1f0804440c53a19934192dc2111ff288)NumberOfAllMembers
-------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.CampaignSystem.Track.NumberOfAllMembers |

[◆](class_tale_worlds_1_1_campaign_system_1_1_track.html#ae0ee999eee95a979b7a5656ac283c5bf)NumberOfHealthyMembers
-----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.CampaignSystem.Track.NumberOfHealthyMembers |

[◆](class_tale_worlds_1_1_campaign_system_1_1_track.html#a148277a666354f27f483bbd451e64a2a)NumberOfMenWithHorse
---------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.CampaignSystem.Track.NumberOfMenWithHorse |

[◆](class_tale_worlds_1_1_campaign_system_1_1_track.html#a791aeb63340d18bf8d2f947edbdac63f)NumberOfMenWithoutHorse
------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.CampaignSystem.Track.NumberOfMenWithoutHorse |

[◆](class_tale_worlds_1_1_campaign_system_1_1_track.html#a48d2a695b604c1dac154f4c2eb29f460)NumberOfPackAnimals
--------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.CampaignSystem.Track.NumberOfPackAnimals |

[◆](class_tale_worlds_1_1_campaign_system_1_1_track.html#a8eb6c70f8b0fdadac5cb9c456dae5190)NumberOfPrisoners
------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.CampaignSystem.Track.NumberOfPrisoners |

[◆](class_tale_worlds_1_1_campaign_system_1_1_track.html#aaddd3a8f676bb95636e778e767466b1d)CreationTime
-------------------------------------------------------------------------------------------------------

|  |
| --- |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.Track.CreationTime |

[◆](class_tale_worlds_1_1_campaign_system_1_1_track.html#a2a5969e1d5540237d68fab2434984913)Life
-----------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.CampaignSystem.Track.Life |

[◆](class_tale_worlds_1_1_campaign_system_1_1_track.html#a6e8882600464ef044ee71ff083995f7d)PartyType
----------------------------------------------------------------------------------------------------

|  |
| --- |
| [PartyTypeEnum](class_tale_worlds_1_1_campaign_system_1_1_track.html#a0cdb2a1fa6388c7776569db8f5596962) TaleWorlds.CampaignSystem.Track.PartyType |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_track.html#ac1619626b57a00e21a58c22a0a7462ba)GetPosition2D
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.CampaignSystem.Track.GetPosition2D | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_track.html#ab84da8030138499bfc3f1ecfa3b0eff8)Size
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Track.Size | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_track.html#af67b161c66524ab7aa708f898cb78480)IsDetected
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Track.IsDetected | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_track.html#ad782c37a3c5142eae8a82c6fd2c44006)IsPointer
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Track.IsPointer | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_track.html#a4532221fbc0874d257b37b8eb5ea4ea2)IsEnemy
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Track.IsEnemy | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_track.html#a5d0d7277cb80804afa54ea9e1c964d59)IsExpired
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Track.IsExpired | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_track.html#a19075d44372cd6581744418da61416fe)IsAlive
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Track.IsAlive | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_track.html#adab83e63efcf2cfccab88ad10e48575f)Scale
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Track.Scale | | get |

