--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html ---

TaleWorlds.CampaignSystem.Settlements.Locations.LocationCharacter Class Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [CharacterRelations](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a5cc4c10a0f04872bb92edfb9363e1f67) {     [Neutral](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a5cc4c10a0f04872bb92edfb9363e1f67ae9bb5320b3890b6747c91b5a71ae5a01) ,     [Friendly](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a5cc4c10a0f04872bb92edfb9363e1f67a03fdbf12e03a4cd1409b84abe2b631df) ,     [Enemy](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a5cc4c10a0f04872bb92edfb9363e1f67a8c6d21187fb58b7a079d70030686b33e)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| delegate void | [AddBehaviorsDelegate](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a9f257a4c4ac0960a0df0f91bb8059b5d) ([IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) agent) |
| delegate void | [AfterAgentCreatedDelegate](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a9598dbefdac8478527e1feba7aa08a39) ([IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) agent) |
|  | [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a8065389be6ac8238fdfc315a23105614) ([AgentData](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#ae42386c5117bed6c0fcdaf76393e739b) agentData, [AddBehaviorsDelegate](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a9f257a4c4ac0960a0df0f91bb8059b5d) addBehaviorsDelegate, string spawnTag, bool fixedLocation, [CharacterRelations](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a5cc4c10a0f04872bb92edfb9363e1f67) characterRelation, string actionSetCode, bool useCivilianEquipment, bool isFixedCharacter=false, [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) specialItem=null, bool isHidden=false, bool isVisualTracked=false, bool overrideBodyProperties=true, [AfterAgentCreatedDelegate](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a9598dbefdac8478527e1feba7aa08a39) afterAgentCreated=null, bool forceSpawnOnSpecialTargetTag=false) |
| void | [SetAlleyOfCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#ac4b073c6c60cec65ad75dda1d78b18d5) ([Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) alley) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a8065389be6ac8238fdfc315a23105614) | [CreateBodyguardHero](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a0c7a9866ea5da9405a684c9943cab1db) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [AddBehaviorsDelegate](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a9f257a4c4ac0960a0df0f91bb8059b5d) addBehaviorsDelegate) |

|  |  |
| --- | --- |
| Public Attributes | |
| bool | [IsVisualTracked](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a77b06503a11161af257bfaab743853e9) |
| Dictionary< sbyte, string > | [PrefabNamesForBones](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a6a661de4d640fd853ac8a12d6542d854) |
| [CharacterRelations](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a5cc4c10a0f04872bb92edfb9363e1f67) | [CharacterRelation](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#ab1679b1922cbca91d998050ad3dbc53a) |

|  |  |
| --- | --- |
| Properties | |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [Character](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#ac16159526560d34623b017dc6673260b) `[get]` |
| [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) | [AgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#ab8e2e2e30ba817699c9eba85f736c97b) `[get]` |
| AgentData | [AgentData](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#ae42386c5117bed6c0fcdaf76393e739b) `[get]` |
| bool | [UseCivilianEquipment](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#aaf7a9ba5d4f9101e78cb3273c62de464) `[get]` |
| string | [ActionSetCode](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a3b077202f8bc9eb1792c9815df6140c0) `[get]` |
| string | [AlarmedActionSetCode](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#acef9a0bd732b6bc911dcfcae2d0d0c39) `[get]` |
| string | [SpecialTargetTag](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#ab5523f61b3ac11717cc04e11354d6553) `[get, set]` |
| bool | [ForceSpawnInSpecialTargetTag](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a2ea7a54b91d0a24a4f5566870dfff296) `[get, set]` |
| [AddBehaviorsDelegate](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a9f257a4c4ac0960a0df0f91bb8059b5d) | [AddBehaviors](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#ab0eb283c5f60c7a6b72877fd270b73ba) `[get]` |
| [AfterAgentCreatedDelegate](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a9598dbefdac8478527e1feba7aa08a39) | [AfterAgentCreated](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a3e8298c251d4ca0d92cd65540739cd71) `[get]` |
| bool | [FixedLocation](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a527476e7a22c837453fd27e37dbbca90) `[get]` |
| [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | [MemberOfAlley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a4981acca0779121c29e7144a1611442c) `[get]` |
| [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | [SpecialItem](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#ab3e33a3386d35964fbd7d6ad4c36d7bf) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a5cc4c10a0f04872bb92edfb9363e1f67)CharacterRelations
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.Settlements.Locations.LocationCharacter.CharacterRelations](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a5cc4c10a0f04872bb92edfb9363e1f67) |

| Enumerator | |
| --- | --- |
| Neutral |  |
| Friendly |  |
| Enemy |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a8065389be6ac8238fdfc315a23105614)LocationCharacter()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Settlements.Locations.LocationCharacter.LocationCharacter | ( | [AgentData](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#ae42386c5117bed6c0fcdaf76393e739b) | *agentData*, |
|  |  | [AddBehaviorsDelegate](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a9f257a4c4ac0960a0df0f91bb8059b5d) | *addBehaviorsDelegate*, |
|  |  | string | *spawnTag*, |
|  |  | bool | *fixedLocation*, |
|  |  | [CharacterRelations](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a5cc4c10a0f04872bb92edfb9363e1f67) | *characterRelation*, |
|  |  | string | *actionSetCode*, |
|  |  | bool | *useCivilianEquipment*, |
|  |  | bool | *isFixedCharacter* = false, |
|  |  | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *specialItem* = null, |
|  |  | bool | *isHidden* = false, |
|  |  | bool | *isVisualTracked* = false, |
|  |  | bool | *overrideBodyProperties* = true, |
|  |  | [AfterAgentCreatedDelegate](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a9598dbefdac8478527e1feba7aa08a39) | *afterAgentCreated* = null, |
|  |  | bool | *forceSpawnOnSpecialTargetTag* = false ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a9f257a4c4ac0960a0df0f91bb8059b5d)AddBehaviorsDelegate()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| delegate void TaleWorlds.CampaignSystem.Settlements.Locations.LocationCharacter.AddBehaviorsDelegate | ( | [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) | *agent* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a9598dbefdac8478527e1feba7aa08a39)AfterAgentCreatedDelegate()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| delegate void TaleWorlds.CampaignSystem.Settlements.Locations.LocationCharacter.AfterAgentCreatedDelegate | ( | [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) | *agent* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#ac4b073c6c60cec65ad75dda1d78b18d5)SetAlleyOfCharacter()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Locations.LocationCharacter.SetAlleyOfCharacter | ( | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | *alley* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a0c7a9866ea5da9405a684c9943cab1db)CreateBodyguardHero()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a8065389be6ac8238fdfc315a23105614) TaleWorlds.CampaignSystem.Settlements.Locations.LocationCharacter.CreateBodyguardHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | [AddBehaviorsDelegate](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a9f257a4c4ac0960a0df0f91bb8059b5d) | *addBehaviorsDelegate* ) | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a77b06503a11161af257bfaab743853e9)IsVisualTracked
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.Settlements.Locations.LocationCharacter.IsVisualTracked |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a6a661de4d640fd853ac8a12d6542d854)PrefabNamesForBones
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Dictionary<sbyte, string> TaleWorlds.CampaignSystem.Settlements.Locations.LocationCharacter.PrefabNamesForBones |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#ab1679b1922cbca91d998050ad3dbc53a)CharacterRelation
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [CharacterRelations](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a5cc4c10a0f04872bb92edfb9363e1f67) TaleWorlds.CampaignSystem.Settlements.Locations.LocationCharacter.CharacterRelation |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#ac16159526560d34623b017dc6673260b)Character
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.Settlements.Locations.LocationCharacter.Character | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#ab8e2e2e30ba817699c9eba85f736c97b)AgentOrigin
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) TaleWorlds.CampaignSystem.Settlements.Locations.LocationCharacter.AgentOrigin | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#ae42386c5117bed6c0fcdaf76393e739b)AgentData
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | AgentData TaleWorlds.CampaignSystem.Settlements.Locations.LocationCharacter.AgentData | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#aaf7a9ba5d4f9101e78cb3273c62de464)UseCivilianEquipment
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Settlements.Locations.LocationCharacter.UseCivilianEquipment | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a3b077202f8bc9eb1792c9815df6140c0)ActionSetCode
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.Settlements.Locations.LocationCharacter.ActionSetCode | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#acef9a0bd732b6bc911dcfcae2d0d0c39)AlarmedActionSetCode
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.Settlements.Locations.LocationCharacter.AlarmedActionSetCode | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#ab5523f61b3ac11717cc04e11354d6553)SpecialTargetTag
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.Settlements.Locations.LocationCharacter.SpecialTargetTag | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a2ea7a54b91d0a24a4f5566870dfff296)ForceSpawnInSpecialTargetTag
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Settlements.Locations.LocationCharacter.ForceSpawnInSpecialTargetTag | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#ab0eb283c5f60c7a6b72877fd270b73ba)AddBehaviors
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [AddBehaviorsDelegate](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a9f257a4c4ac0960a0df0f91bb8059b5d) TaleWorlds.CampaignSystem.Settlements.Locations.LocationCharacter.AddBehaviors | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a3e8298c251d4ca0d92cd65540739cd71)AfterAgentCreated
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [AfterAgentCreatedDelegate](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a9598dbefdac8478527e1feba7aa08a39) TaleWorlds.CampaignSystem.Settlements.Locations.LocationCharacter.AfterAgentCreated | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a527476e7a22c837453fd27e37dbbca90)FixedLocation
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Settlements.Locations.LocationCharacter.FixedLocation | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#a4981acca0779121c29e7144a1611442c)MemberOfAlley
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) TaleWorlds.CampaignSystem.Settlements.Locations.LocationCharacter.MemberOfAlley | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html#ab3e33a3386d35964fbd7d6ad4c36d7bf)SpecialItem
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) TaleWorlds.CampaignSystem.Settlements.Locations.LocationCharacter.SpecialItem | | get |

