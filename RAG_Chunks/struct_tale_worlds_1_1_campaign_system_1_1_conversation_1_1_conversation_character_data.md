--- SOURCE: struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html ---

TaleWorlds.CampaignSystem.Conversation.ConversationCharacterData Struct ReferenceInherits [TaleWorlds.Library.ISerializableObject](interface_tale_worlds_1_1_library_1_1_i_serializable_object.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ConversationCharacterData](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html#afa640905c3b68953b7e855a98db3b325) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party=null, bool noHorse=false, bool noWeapon=false, bool spawnAfterFight=false, bool isCivilianEquipmentRequiredForLeader=false, bool isCivilianEquipmentRequiredForBodyGuardCharacters=false, bool noBodyguards=false) |
| void ISerializableObject. | [DeserializeFrom](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html#ad2f4332cc5f661dfb6fabdccf745961c) ([IReader](interface_tale_worlds_1_1_library_1_1_i_reader.html) reader) |
| void ISerializableObject. | [SerializeTo](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html#a7a897caad0355f8ee96020e59d2b1c51) ([IWriter](interface_tale_worlds_1_1_library_1_1_i_writer.html) writer) |

|  |  |
| --- | --- |
| Public Attributes | |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [Character](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html#a43b9263b7ea84cdadd58f8e713bbac98) |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | [Party](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html#a3d84ef6f8992a9337db03956d0a413bc) |
| bool | [NoHorse](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html#a61cfea92b36cbd4349234e3e0c25c67a) |
| bool | [NoWeapon](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html#ac0a7d37009b9172ff19bc8ffd624a406) |
| bool | [NoBodyguards](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html#ab92a7a2861518107f9fef984a8eb464a) |
| bool | [SpawnedAfterFight](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html#a78cf2030383fd07653f6298b807472a9) |
| bool | [IsCivilianEquipmentRequiredForLeader](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html#a341cb68236f4b5f238c0683ffffde684) |
| bool | [IsCivilianEquipmentRequiredForBodyGuardCharacters](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html#a997f6146a8cc1fbe13ae7c040c12c9f8) |

Constructor & Destructor Documentation
--------------------------------------

[◆](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html#afa640905c3b68953b7e855a98db3b325)ConversationCharacterData()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Conversation.ConversationCharacterData.ConversationCharacterData | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* = null, |
|  |  | bool | *noHorse* = false, |
|  |  | bool | *noWeapon* = false, |
|  |  | bool | *spawnAfterFight* = false, |
|  |  | bool | *isCivilianEquipmentRequiredForLeader* = false, |
|  |  | bool | *isCivilianEquipmentRequiredForBodyGuardCharacters* = false, |
|  |  | bool | *noBodyguards* = false ) |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html#ad2f4332cc5f661dfb6fabdccf745961c)DeserializeFrom()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void ISerializableObject. TaleWorlds.CampaignSystem.Conversation.ConversationCharacterData.DeserializeFrom | ( | [IReader](interface_tale_worlds_1_1_library_1_1_i_reader.html) | *reader* | ) |  |

Implements [TaleWorlds.Library.ISerializableObject](interface_tale_worlds_1_1_library_1_1_i_serializable_object.html#aaaf5181fea51c7c2d4e365efe82bc703).

[◆](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html#a7a897caad0355f8ee96020e59d2b1c51)SerializeTo()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void ISerializableObject. TaleWorlds.CampaignSystem.Conversation.ConversationCharacterData.SerializeTo | ( | [IWriter](interface_tale_worlds_1_1_library_1_1_i_writer.html) | *writer* | ) |  |

Implements [TaleWorlds.Library.ISerializableObject](interface_tale_worlds_1_1_library_1_1_i_serializable_object.html#aac913af86c2a4128993048fc2023b4de).

Member Data Documentation
-------------------------

[◆](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html#a43b9263b7ea84cdadd58f8e713bbac98)Character
--------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.Conversation.ConversationCharacterData.Character |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html#a3d84ef6f8992a9337db03956d0a413bc)Party
----------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) TaleWorlds.CampaignSystem.Conversation.ConversationCharacterData.Party |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html#a61cfea92b36cbd4349234e3e0c25c67a)NoHorse
------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.Conversation.ConversationCharacterData.NoHorse |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html#ac0a7d37009b9172ff19bc8ffd624a406)NoWeapon
-------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.Conversation.ConversationCharacterData.NoWeapon |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html#ab92a7a2861518107f9fef984a8eb464a)NoBodyguards
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.Conversation.ConversationCharacterData.NoBodyguards |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html#a78cf2030383fd07653f6298b807472a9)SpawnedAfterFight
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.Conversation.ConversationCharacterData.SpawnedAfterFight |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html#a341cb68236f4b5f238c0683ffffde684)IsCivilianEquipmentRequiredForLeader
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.Conversation.ConversationCharacterData.IsCivilianEquipmentRequiredForLeader |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html#a997f6146a8cc1fbe13ae7c040c12c9f8)IsCivilianEquipmentRequiredForBodyGuardCharacters
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.Conversation.ConversationCharacterData.IsCivilianEquipmentRequiredForBodyGuardCharacters |

