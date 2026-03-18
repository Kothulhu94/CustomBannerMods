--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html ---

TaleWorlds.CampaignSystem.Settlements.Locations.Location Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#ad629385befe8bd0791e4852078d7f07b) (string stringId, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) name, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) doorName, int prosperityMax, bool isIndoor, bool canBeReserved, string playerCanEnter, string playerCanSee, string aiCanExit, string aiCanEnter, string[] sceneNames, [LocationComplex](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html) locationComplex) |
|  | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#ad07a3814fcbb368b1c99f300562cba18) (Location location, [LocationComplex](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html) locationComplex) |
| void | [Initialize](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a60eafd6f3f5bd6e68b0aa40399b37f21) ([Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#ad629385befe8bd0791e4852078d7f07b) locationTemplate, [LocationComplex](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html) ownerComplex) |
| bool | [CanAIExit](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#af22364210296b63f17c9464f528abb62) ([LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) character) |
| bool | [CanAIEnter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#ae347d6b77563c5aca63983c92a6ff9e0) ([LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) character) |
| bool | [CanPlayerEnter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a4c77efac0895f574d5769b610267e221) () |
| bool | [CanPlayerSee](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#aeed650572af488258cafa19c024b4957) () |
| void | [ReserveLocation](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#ab756f732bee79d0133fc283cf2fa49b3) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) locationName, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) doorName) |
| void | [RemoveReservation](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#aff59b4f3435ab4c3d1f4f79343063d50) () |
| void | [SetOwnerComplex](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#aad2df5b136da88d1fcbf6bdac2b8836a) ([LocationComplex](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html) locationComplex) |
| void | [AddCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#ac4449923876edd5adbaef578b6bcac37) ([LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) locationCharacter) |
| void | [AddLocationCharacters](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a7f5c131c03944b32b241bf374181521e) ([CreateLocationCharacterDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations.html#af554b790647dedcb88b21d2f1425d55b) createDelegate, [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) culture, [LocationCharacter.CharacterRelations](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a5cc4c10a0f04872bb92edfb9363e1f67) relation, int count) |
| [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) | [AddLocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a095345b485a3fc0bb3f784e2ebbcaab3) ([CreateLocationCharacterDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations.html#af554b790647dedcb88b21d2f1425d55b) createDelegate, [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) culture, [LocationCharacter.CharacterRelations](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a5cc4c10a0f04872bb92edfb9363e1f67) relation) |
| void | [AddSpecialItem](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a22b53dcb27edde1967a336f00bba9588) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) itemObject) |
| string | [GetSceneName](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a9a571b2c1b5cafab2c9021c55bbdd8f4) (int upgradeLevel) |
| void | [SetSceneName](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a4259b6a8924c10e177b60c06d70655f4) (int upgradeLevel, string sceneName) |
| int | [GetSceneCount](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#ae660210dae3f8da39386077eb40c80b3) () |
| void | [RemoveAllHeroCharactersFromPrison](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#aa5818cdce95c4b63b2c513ab1e1e1595) () |
| void | [RemoveAllCharacters](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#ad97cb34761349f1a9166c05e400adff6) () |
| void | [RemoveAllCharacters](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a24947906ee6d69c864dfab1420502667) (Predicate< [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) > predicate) |
| void | [RemoveLocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#ac274365a54387ce71a5ec2c9cbe26983) ([LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) locationCharacter) |
| void | [RemoveCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a1e016274a32b3a0a2e99befdc36a9a8c) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| bool | [ContainsCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a8919d6c678bd8b339715d4207dbba2b7) ([LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) locationCharacter) |
| bool | [ContainsCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a7067bb2e3188477c042b8d0f56bfb21e) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| void | [AddPassageToLocation](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a0f0a0e532da73d06a9d5b57e80086867) ([Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#ad629385befe8bd0791e4852078d7f07b) passageToLocation) |
| IEnumerable< [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) > | [GetCharacterList](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a8d8ab8894f4882f67be96debe4ae5474) () |
| [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#ad629385befe8bd0791e4852078d7f07b) | [GetPassageToLocation](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a00f5b426cd666404d965cd7b89193ceb) (string locationId) |
| void | [OnAIChangeLocation](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a8581183fe5c879254406a96f7709c34c) ([Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#ad629385befe8bd0791e4852078d7f07b) previousLocation) |
| [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) | [GetLocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a360a90a30688ddd5d29718da1057becf) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) | [GetLocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a7f5b08de691f0b0695a2ffb3bada6033) ([IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) agentOrigin) |

|  |  |
| --- | --- |
| Public Attributes | |
| int | [ProsperityMax](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a955204ed4855b10cd4c26b3b8cc68e03) |

|  |  |
| --- | --- |
| Properties | |
| string | [StringId](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a1d13bfc81d08206e70cb59a00a0444f5) `[get]` |
| List< [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) > | [SpecialItems](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a75b49674fbdae476c82640b04c79d3c1) `[get]` |
| bool | [IsReserved](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#ab2345085f89d8d40a6bf8b1d00d8ec04) `[get]` |
| List< [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#ad629385befe8bd0791e4852078d7f07b) > | [LocationsOfPassages](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a690f1187f81017a98e3f086c8b333f04) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a3f7edd246937c6eb076fbacdb19fc85c) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [DoorName](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a0d47056f6073e6bcac6cb2263fb0819b) `[get]` |
| bool | [IsIndoor](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#adf7358f812b105f598e2fbb301e43870) `[get]` |
| bool | [CanBeReserved](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#acc22aeb15266dc88e652825ebe693325) `[get]` |
| bool | [IsInitialized](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a69238311453fd0b06d90c7e7dc9d8e74) `[get]` |
| int | [CharacterCount](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a3c63e13ca161fab89b67256a1c11efcc) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#ad629385befe8bd0791e4852078d7f07b)Location() [1/2]
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Settlements.Locations.Location.Location | ( | string | *stringId*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *name*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *doorName*, |
|  |  | int | *prosperityMax*, |
|  |  | bool | *isIndoor*, |
|  |  | bool | *canBeReserved*, |
|  |  | string | *playerCanEnter*, |
|  |  | string | *playerCanSee*, |
|  |  | string | *aiCanExit*, |
|  |  | string | *aiCanEnter*, |
|  |  | string[] | *sceneNames*, |
|  |  | [LocationComplex](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html) | *locationComplex* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#ad07a3814fcbb368b1c99f300562cba18)Location() [2/2]
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Settlements.Locations.Location.Location | ( | Location | *location*, |
|  |  | [LocationComplex](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html) | *locationComplex* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a60eafd6f3f5bd6e68b0aa40399b37f21)Initialize()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Locations.Location.Initialize | ( | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#ad629385befe8bd0791e4852078d7f07b) | *locationTemplate*, |
|  |  | [LocationComplex](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html) | *ownerComplex* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#af22364210296b63f17c9464f528abb62)CanAIExit()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Settlements.Locations.Location.CanAIExit | ( | [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) | *character* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#ae347d6b77563c5aca63983c92a6ff9e0)CanAIEnter()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Settlements.Locations.Location.CanAIEnter | ( | [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) | *character* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a4c77efac0895f574d5769b610267e221)CanPlayerEnter()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Settlements.Locations.Location.CanPlayerEnter | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#aeed650572af488258cafa19c024b4957)CanPlayerSee()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Settlements.Locations.Location.CanPlayerSee | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#ab756f732bee79d0133fc283cf2fa49b3)ReserveLocation()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Locations.Location.ReserveLocation | ( | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *locationName*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *doorName* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#aff59b4f3435ab4c3d1f4f79343063d50)RemoveReservation()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Locations.Location.RemoveReservation | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#aad2df5b136da88d1fcbf6bdac2b8836a)SetOwnerComplex()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Locations.Location.SetOwnerComplex | ( | [LocationComplex](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex.html) | *locationComplex* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#ac4449923876edd5adbaef578b6bcac37)AddCharacter()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Locations.Location.AddCharacter | ( | [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) | *locationCharacter* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a7f5c131c03944b32b241bf374181521e)AddLocationCharacters()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Locations.Location.AddLocationCharacters | ( | [CreateLocationCharacterDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations.html#af554b790647dedcb88b21d2f1425d55b) | *createDelegate*, |
|  |  | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | *culture*, |
|  |  | [LocationCharacter.CharacterRelations](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a5cc4c10a0f04872bb92edfb9363e1f67) | *relation*, |
|  |  | int | *count* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a095345b485a3fc0bb3f784e2ebbcaab3)AddLocationCharacter()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) TaleWorlds.CampaignSystem.Settlements.Locations.Location.AddLocationCharacter | ( | [CreateLocationCharacterDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations.html#af554b790647dedcb88b21d2f1425d55b) | *createDelegate*, |
|  |  | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | *culture*, |
|  |  | [LocationCharacter.CharacterRelations](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a5cc4c10a0f04872bb92edfb9363e1f67) | *relation* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a22b53dcb27edde1967a336f00bba9588)AddSpecialItem()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Locations.Location.AddSpecialItem | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *itemObject* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a9a571b2c1b5cafab2c9021c55bbdd8f4)GetSceneName()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| string TaleWorlds.CampaignSystem.Settlements.Locations.Location.GetSceneName | ( | int | *upgradeLevel* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a4259b6a8924c10e177b60c06d70655f4)SetSceneName()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Locations.Location.SetSceneName | ( | int | *upgradeLevel*, |
|  |  | string | *sceneName* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#ae660210dae3f8da39386077eb40c80b3)GetSceneCount()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Settlements.Locations.Location.GetSceneCount | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#aa5818cdce95c4b63b2c513ab1e1e1595)RemoveAllHeroCharactersFromPrison()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Locations.Location.RemoveAllHeroCharactersFromPrison | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#ad97cb34761349f1a9166c05e400adff6)RemoveAllCharacters() [1/2]
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Locations.Location.RemoveAllCharacters | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a24947906ee6d69c864dfab1420502667)RemoveAllCharacters() [2/2]
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Locations.Location.RemoveAllCharacters | ( | Predicate< [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) > | *predicate* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#ac274365a54387ce71a5ec2c9cbe26983)RemoveLocationCharacter()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Locations.Location.RemoveLocationCharacter | ( | [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) | *locationCharacter* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a1e016274a32b3a0a2e99befdc36a9a8c)RemoveCharacter()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Locations.Location.RemoveCharacter | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a8919d6c678bd8b339715d4207dbba2b7)ContainsCharacter() [1/2]
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Settlements.Locations.Location.ContainsCharacter | ( | [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) | *locationCharacter* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a7067bb2e3188477c042b8d0f56bfb21e)ContainsCharacter() [2/2]
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Settlements.Locations.Location.ContainsCharacter | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a0f0a0e532da73d06a9d5b57e80086867)AddPassageToLocation()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Locations.Location.AddPassageToLocation | ( | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#ad629385befe8bd0791e4852078d7f07b) | *passageToLocation* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a8d8ab8894f4882f67be96debe4ae5474)GetCharacterList()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) > TaleWorlds.CampaignSystem.Settlements.Locations.Location.GetCharacterList | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a00f5b426cd666404d965cd7b89193ceb)GetPassageToLocation()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#ad629385befe8bd0791e4852078d7f07b) TaleWorlds.CampaignSystem.Settlements.Locations.Location.GetPassageToLocation | ( | string | *locationId* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a8581183fe5c879254406a96f7709c34c)OnAIChangeLocation()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Locations.Location.OnAIChangeLocation | ( | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#ad629385befe8bd0791e4852078d7f07b) | *previousLocation* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a360a90a30688ddd5d29718da1057becf)GetLocationCharacter() [1/2]
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) TaleWorlds.CampaignSystem.Settlements.Locations.Location.GetLocationCharacter | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a7f5b08de691f0b0695a2ffb3bada6033)GetLocationCharacter() [2/2]
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) TaleWorlds.CampaignSystem.Settlements.Locations.Location.GetLocationCharacter | ( | [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) | *agentOrigin* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a955204ed4855b10cd4c26b3b8cc68e03)ProsperityMax
-----------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.CampaignSystem.Settlements.Locations.Location.ProsperityMax |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a1d13bfc81d08206e70cb59a00a0444f5)StringId
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.Settlements.Locations.Location.StringId | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a75b49674fbdae476c82640b04c79d3c1)SpecialItems
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html)> TaleWorlds.CampaignSystem.Settlements.Locations.Location.SpecialItems | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#ab2345085f89d8d40a6bf8b1d00d8ec04)IsReserved
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Settlements.Locations.Location.IsReserved | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a690f1187f81017a98e3f086c8b333f04)LocationsOfPassages
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#ad629385befe8bd0791e4852078d7f07b)> TaleWorlds.CampaignSystem.Settlements.Locations.Location.LocationsOfPassages | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a3f7edd246937c6eb076fbacdb19fc85c)Name
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Settlements.Locations.Location.Name | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a0d47056f6073e6bcac6cb2263fb0819b)DoorName
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Settlements.Locations.Location.DoorName | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#adf7358f812b105f598e2fbb301e43870)IsIndoor
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Settlements.Locations.Location.IsIndoor | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#acc22aeb15266dc88e652825ebe693325)CanBeReserved
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Settlements.Locations.Location.CanBeReserved | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a69238311453fd0b06d90c7e7dc9d8e74)IsInitialized
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Settlements.Locations.Location.IsInitialized | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html#a3c63e13ca161fab89b67256a1c11efcc)CharacterCount
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Settlements.Locations.Location.CharacterCount | | get |

