--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html ---

TaleWorlds.CampaignSystem.Settlements.Locations.LocationComplex Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [LocationComplex](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#a29cd439ce3a5eae756a659a0dfdc4897) () |
|  | [LocationComplex](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#afe35afce2e9b0568594c974c394db874) ([LocationComplexTemplate](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex_template.html) complexTemplate) |
|  | [LocationComplex](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#ac57db43ad8af9e3ce1cd50287d147cb8) (LocationComplex complex) |
| void | [Initialize](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#a5c7f60e561a552442db6c53ad42bffd4) ([LocationComplexTemplate](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex_template.html) complexTemplate) |
| void | [AddPassage](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#a1733ea37326e953404d41307583eeabe) ([Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) firstLocation, [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) secondLocation) |
| void | [ChangeLocation](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#aeab58ac65a8275b8d17da7f2ac10cde5) ([LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) locationCharacter, [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) fromLocation, [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) toLocation) |
| IEnumerable< [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) > | [GetListOfCharactersInLocation](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#a4e95f8f9b2b1546d1135f322cbbe7fc6) (string locationName) |
| IList< [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) > | [GetListOfCharacters](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#aa1cd4a32c087cca5324cf61cd46dbfbd) () |
| IEnumerable< [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) > | [GetListOfLocations](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#a84e351f3794be8afe9ef55c36f14630c) () |
| void | [AgentPassageUsageTick](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#a1e7e3465dcaab4c0b592f97e9a66b4c1) () |
| [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | [GetLocationOfCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#adc2fdd791cabb701281867126f09b7a5) ([LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) character) |
| [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | [GetLocationOfCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#a99adf31fe0e7a40e21194693b7867cab) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) | [GetLocationCharacterOfHero](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#acb15131614b2fdab62c96ef0c2b5c8c0) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) | [GetFirstLocationCharacterOfCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#adb7820550968c51b78e54a10df45e65e) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| void | [RemoveCharacterIfExists](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#a52d5102f3a2f21180e7367957aba11c7) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| void | [RemoveCharacterIfExists](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#ad7e8655ac888746752e876c2ffdd788e) ([LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) locationCharacter) |
| void | [ClearTempCharacters](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#aae00b3e829ee2aaf57e2b899f06a7cbc) () |
| [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | [GetLocationWithId](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#a3840d806a2e29f47d63d8310762e4605) (string id) |
| string | [GetScene](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#ab29e3ef6a169adc9b3b34c6d7ed028cd) (string stringId, int upgradeLevel) |
| [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) | [FindCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#a2fd42998e3b363727ea5f0a1ab425e5a) ([IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) agent) |
| IEnumerable< [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) > | [FindAll](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#a42c9378264414ec2aa5344ad3b8cc18d) (Func< string, bool > predicate) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static bool | [CanAlways](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#aa647e4c6418b8d8a762d18ed498599e3) ([LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) locationCharacter, [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) location) |
| static bool | [CanNever](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#ae38599f8567e90f43121b73a713ac628) ([LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) locationCharacter, [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) location) |
| static bool | [CanIfHero](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#a367788edd7194a153b0943e805cd1fab) ([LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) locationCharacter, [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) location) |
| static bool | [CanIfDay](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#a6c5e0cf6b7ffb0dbe31d3b967290ff68) ([LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) locationCharacter, [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) location) |
| static bool | [CanIfPriceIsPaid](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#a11f28ef5f405edd6fa1fb19c37c67444) ([LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) locationCharacter, [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) location) |
| static bool | [CanIfGrownUpMaleOrHero](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#a82f10b38b1768f8247fff5d4d7418a61) ([LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) locationCharacter, [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) location) |
| static bool | [CanIfMaleOrHero](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#afe3095874d36c38fac254299d2173394) ([LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) locationCharacter, [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) location) |
| static bool | [CanIfSettlementAccessModelLetsPlayer](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#afb9e1c6920b1dab7e4e1b85d7e1f77c4) ([LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) locationCharacter, [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) location) |

|  |  |
| --- | --- |
| Properties | |
| static [LocationComplex](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#a29cd439ce3a5eae756a659a0dfdc4897) | [Current](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#a66fd56f5df6af73bf8408a3a5817b104) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#a29cd439ce3a5eae756a659a0dfdc4897)LocationComplex() [1/3]
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Settlements.Locations.LocationComplex.LocationComplex | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#afe35afce2e9b0568594c974c394db874)LocationComplex() [2/3]
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Settlements.Locations.LocationComplex.LocationComplex | ( | [LocationComplexTemplate](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex_template.html) | *complexTemplate* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#ac57db43ad8af9e3ce1cd50287d147cb8)LocationComplex() [3/3]
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Settlements.Locations.LocationComplex.LocationComplex | ( | LocationComplex | *complex* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#aa647e4c6418b8d8a762d18ed498599e3)CanAlways()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.Settlements.Locations.LocationComplex.CanAlways | ( | [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) | *locationCharacter*, | |  |  | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | *location* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#ae38599f8567e90f43121b73a713ac628)CanNever()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.Settlements.Locations.LocationComplex.CanNever | ( | [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) | *locationCharacter*, | |  |  | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | *location* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#a367788edd7194a153b0943e805cd1fab)CanIfHero()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.Settlements.Locations.LocationComplex.CanIfHero | ( | [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) | *locationCharacter*, | |  |  | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | *location* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#a6c5e0cf6b7ffb0dbe31d3b967290ff68)CanIfDay()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.Settlements.Locations.LocationComplex.CanIfDay | ( | [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) | *locationCharacter*, | |  |  | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | *location* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#a11f28ef5f405edd6fa1fb19c37c67444)CanIfPriceIsPaid()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.Settlements.Locations.LocationComplex.CanIfPriceIsPaid | ( | [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) | *locationCharacter*, | |  |  | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | *location* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#a82f10b38b1768f8247fff5d4d7418a61)CanIfGrownUpMaleOrHero()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.Settlements.Locations.LocationComplex.CanIfGrownUpMaleOrHero | ( | [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) | *locationCharacter*, | |  |  | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | *location* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#afe3095874d36c38fac254299d2173394)CanIfMaleOrHero()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.Settlements.Locations.LocationComplex.CanIfMaleOrHero | ( | [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) | *locationCharacter*, | |  |  | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | *location* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#afb9e1c6920b1dab7e4e1b85d7e1f77c4)CanIfSettlementAccessModelLetsPlayer()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.Settlements.Locations.LocationComplex.CanIfSettlementAccessModelLetsPlayer | ( | [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) | *locationCharacter*, | |  |  | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | *location* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#a5c7f60e561a552442db6c53ad42bffd4)Initialize()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Locations.LocationComplex.Initialize | ( | [LocationComplexTemplate](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex_template.html) | *complexTemplate* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#a1733ea37326e953404d41307583eeabe)AddPassage()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Locations.LocationComplex.AddPassage | ( | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | *firstLocation*, |
|  |  | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | *secondLocation* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#aeab58ac65a8275b8d17da7f2ac10cde5)ChangeLocation()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Locations.LocationComplex.ChangeLocation | ( | [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) | *locationCharacter*, |
|  |  | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | *fromLocation*, |
|  |  | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | *toLocation* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#a4e95f8f9b2b1546d1135f322cbbe7fc6)GetListOfCharactersInLocation()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| IEnumerable< [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) > TaleWorlds.CampaignSystem.Settlements.Locations.LocationComplex.GetListOfCharactersInLocation | ( | string | *locationName* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#aa1cd4a32c087cca5324cf61cd46dbfbd)GetListOfCharacters()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IList< [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) > TaleWorlds.CampaignSystem.Settlements.Locations.LocationComplex.GetListOfCharacters | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#a84e351f3794be8afe9ef55c36f14630c)GetListOfLocations()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) > TaleWorlds.CampaignSystem.Settlements.Locations.LocationComplex.GetListOfLocations | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#a1e7e3465dcaab4c0b592f97e9a66b4c1)AgentPassageUsageTick()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Locations.LocationComplex.AgentPassageUsageTick | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#adc2fdd791cabb701281867126f09b7a5)GetLocationOfCharacter() [1/2]
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) TaleWorlds.CampaignSystem.Settlements.Locations.LocationComplex.GetLocationOfCharacter | ( | [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) | *character* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#a99adf31fe0e7a40e21194693b7867cab)GetLocationOfCharacter() [2/2]
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) TaleWorlds.CampaignSystem.Settlements.Locations.LocationComplex.GetLocationOfCharacter | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#acb15131614b2fdab62c96ef0c2b5c8c0)GetLocationCharacterOfHero()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) TaleWorlds.CampaignSystem.Settlements.Locations.LocationComplex.GetLocationCharacterOfHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#adb7820550968c51b78e54a10df45e65e)GetFirstLocationCharacterOfCharacter()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) TaleWorlds.CampaignSystem.Settlements.Locations.LocationComplex.GetFirstLocationCharacterOfCharacter | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#a52d5102f3a2f21180e7367957aba11c7)RemoveCharacterIfExists() [1/2]
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Locations.LocationComplex.RemoveCharacterIfExists | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#ad7e8655ac888746752e876c2ffdd788e)RemoveCharacterIfExists() [2/2]
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Locations.LocationComplex.RemoveCharacterIfExists | ( | [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) | *locationCharacter* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#aae00b3e829ee2aaf57e2b899f06a7cbc)ClearTempCharacters()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Locations.LocationComplex.ClearTempCharacters | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#a3840d806a2e29f47d63d8310762e4605)GetLocationWithId()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) TaleWorlds.CampaignSystem.Settlements.Locations.LocationComplex.GetLocationWithId | ( | string | *id* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#ab29e3ef6a169adc9b3b34c6d7ed028cd)GetScene()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| string TaleWorlds.CampaignSystem.Settlements.Locations.LocationComplex.GetScene | ( | string | *stringId*, |
|  |  | int | *upgradeLevel* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#a2fd42998e3b363727ea5f0a1ab425e5a)FindCharacter()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) TaleWorlds.CampaignSystem.Settlements.Locations.LocationComplex.FindCharacter | ( | [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) | *agent* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#a42c9378264414ec2aa5344ad3b8cc18d)FindAll()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| IEnumerable< [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) > TaleWorlds.CampaignSystem.Settlements.Locations.LocationComplex.FindAll | ( | Func< string, bool > | *predicate* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#a66fd56f5df6af73bf8408a3a5817b104)Current
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [LocationComplex](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html#a29cd439ce3a5eae756a659a0dfdc4897) TaleWorlds.CampaignSystem.Settlements.Locations.LocationComplex.Current | | staticget |

