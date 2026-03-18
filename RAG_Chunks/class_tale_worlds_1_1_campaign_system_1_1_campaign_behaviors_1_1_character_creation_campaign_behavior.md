--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html ---

TaleWorlds.CampaignSystem.CampaignBehaviors.CharacterCreationCampaignBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html), and [TaleWorlds.CampaignSystem.CharacterCreationContent.ICharacterCreationContentHandler](interface_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_i_character_creation_content_handler.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#abe3619434cef04631621ae68c79314ac) () |
| override void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#ac2f08e01d02242cad965f53a9307a30e) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| void | [InitializeCharacterCreationStages](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#abe571d4026d5ad0505e60c9b6bca0ddb) ([CharacterCreationManager](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html) characterCreationManager) |
| void | [InitializeCharacterCreationCultures](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#a2efaa56bc5afd3fddf5f8a9c24d9cf8b) ([CharacterCreationManager](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html) characterCreationManager) |
| void | [InitializeData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#ae84ab3133cafd4a7260a86fd0c3d5405) ([CharacterCreationManager](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html) characterCreationManager) |
| void | [FaceGenUpdated](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#ac1b07208cc552556581e7684c4334562) () |
| void | [UpdateParentEquipment](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#ab167f0f70935d79adc5a0126a90081ea) ([CharacterCreationManager](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html) characterCreationManager, [MBEquipmentRoster](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html) motherEquipment, [MBEquipmentRoster](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html) fatherEquipment, string motherAnimation, string fatherAnimation) |
| void | [AddEducationMenu](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#a08207b2020dc2246dbf77d0e6a9624e9) ([CharacterCreationManager](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html) characterCreationManager) |
| void | [SetHeroAge](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#ae9c8f94e2774514714d910cb8e531cb0) (float age) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a053965730807cc40179cb1ee0495c376) (string stringId) |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab8914958880a708aaf68f676e6c29df1) () |
| void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a402e03be483527df560a46a7a01004a6) () |
| void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a5f2a833b5a67619021c6c437a1232877) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const int | [FocusToAddYouthStart](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#a0a1e71c84da8f4db52058fd413c9f5b8) = 2 |
| const int | [FocusToAddAdultStart](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#a1f5a1a85893988fb4e21c1acf694618c) = 4 |
| const int | [FocusToAddMiddleAgedStart](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#afce0e17406390a84be4b64bc4336c911) = 6 |
| const int | [FocusToAddElderlyStart](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#abcd1ee10cfb714235d26f944cf692ba6) = 8 |
| const int | [AttributeToAddYouthStart](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#a207457f4dc9ab4014951819d63c5c9a8) = 1 |
| const int | [AttributeToAddAdultStart](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#a4bbb25c62a441f6fecf6e2ef4a3e4c0d) = 2 |
| const int | [AttributeToAddMiddleAgedStart](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#a5efc7000fa2bedcd85063176d08a19cf) = 3 |
| const int | [AttributeToAddElderlyStart](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#ab5597522f55f9a6d5cd578dcd48ae089) = 4 |
| const string | [MotherNarrativeCharacterStringId](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#ac7445144ec803d4fc0fa17416287401a) = "mother\_character" |
| const string | [FatherNarrativeCharacterStringId](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#a02f774f6f349997a7a8dcec82ec225ec) = "father\_character" |
| const string | [PlayerChildhoodCharacterStringId](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#a65d9e499b7bdaf18401e4fc7cfb7365a) = "player\_childhood\_character" |
| const string | [PlayerEducationCharacterStringId](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#a65b4045b18e9deeaf7c29e9d704cd965) = "player\_education\_character" |
| const string | [PlayerYouthCharacterStringId](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#abfe2f3b28b81aefb129da121cdcdb8d8) = "player\_youth\_character" |
| const string | [PlayerAdulthoodCharacterStringId](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#a755ec1b32817293c25d8a2dcd653b74e) = "player\_adulthood\_character" |
| const string | [PlayerAgeSelectionCharacterStringId](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#a34e141be722bd2f5bdcdad2caa1321ef) = "player\_age\_selection\_character" |
| const string | [HorseNarrativeCharacterStringId](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#a768958995475ca5c6fc5501b2cbe9aa2) = "narrative\_character\_horse" |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| static T | [GetCampaignBehavior< T >](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#af9fd34472faff4ae39b627e8d3091b7e) () |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| readonly string | [StringId](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab1c3b0a4161f58781148a9499be70fa3) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#abe3619434cef04631621ae68c79314ac)RegisterEvents()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.CharacterCreationCampaignBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#ac2f08e01d02242cad965f53a9307a30e)SyncData()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.CharacterCreationCampaignBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#abe571d4026d5ad0505e60c9b6bca0ddb)InitializeCharacterCreationStages()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.CharacterCreationCampaignBehavior.InitializeCharacterCreationStages | ( | [CharacterCreationManager](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html) | *characterCreationManager* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#a2efaa56bc5afd3fddf5f8a9c24d9cf8b)InitializeCharacterCreationCultures()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.CharacterCreationCampaignBehavior.InitializeCharacterCreationCultures | ( | [CharacterCreationManager](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html) | *characterCreationManager* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#ae84ab3133cafd4a7260a86fd0c3d5405)InitializeData()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.CharacterCreationCampaignBehavior.InitializeData | ( | [CharacterCreationManager](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html) | *characterCreationManager* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#ac1b07208cc552556581e7684c4334562)FaceGenUpdated()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.CharacterCreationCampaignBehavior.FaceGenUpdated | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#ab167f0f70935d79adc5a0126a90081ea)UpdateParentEquipment()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.CharacterCreationCampaignBehavior.UpdateParentEquipment | ( | [CharacterCreationManager](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html) | *characterCreationManager*, |
|  |  | [MBEquipmentRoster](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html) | *motherEquipment*, |
|  |  | [MBEquipmentRoster](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html) | *fatherEquipment*, |
|  |  | string | *motherAnimation*, |
|  |  | string | *fatherAnimation* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#a08207b2020dc2246dbf77d0e6a9624e9)AddEducationMenu()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.CharacterCreationCampaignBehavior.AddEducationMenu | ( | [CharacterCreationManager](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html) | *characterCreationManager* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#ae9c8f94e2774514714d910cb8e531cb0)SetHeroAge()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.CharacterCreationCampaignBehavior.SetHeroAge | ( | float | *age* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#a0a1e71c84da8f4db52058fd413c9f5b8)FocusToAddYouthStart
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.CampaignSystem.CampaignBehaviors.CharacterCreationCampaignBehavior.FocusToAddYouthStart = 2 | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#a1f5a1a85893988fb4e21c1acf694618c)FocusToAddAdultStart
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.CampaignSystem.CampaignBehaviors.CharacterCreationCampaignBehavior.FocusToAddAdultStart = 4 | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#afce0e17406390a84be4b64bc4336c911)FocusToAddMiddleAgedStart
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.CampaignSystem.CampaignBehaviors.CharacterCreationCampaignBehavior.FocusToAddMiddleAgedStart = 6 | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#abcd1ee10cfb714235d26f944cf692ba6)FocusToAddElderlyStart
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.CampaignSystem.CampaignBehaviors.CharacterCreationCampaignBehavior.FocusToAddElderlyStart = 8 | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#a207457f4dc9ab4014951819d63c5c9a8)AttributeToAddYouthStart
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.CampaignSystem.CampaignBehaviors.CharacterCreationCampaignBehavior.AttributeToAddYouthStart = 1 | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#a4bbb25c62a441f6fecf6e2ef4a3e4c0d)AttributeToAddAdultStart
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.CampaignSystem.CampaignBehaviors.CharacterCreationCampaignBehavior.AttributeToAddAdultStart = 2 | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#a5efc7000fa2bedcd85063176d08a19cf)AttributeToAddMiddleAgedStart
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.CampaignSystem.CampaignBehaviors.CharacterCreationCampaignBehavior.AttributeToAddMiddleAgedStart = 3 | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#ab5597522f55f9a6d5cd578dcd48ae089)AttributeToAddElderlyStart
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.CampaignSystem.CampaignBehaviors.CharacterCreationCampaignBehavior.AttributeToAddElderlyStart = 4 | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#ac7445144ec803d4fc0fa17416287401a)MotherNarrativeCharacterStringId
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.CampaignSystem.CampaignBehaviors.CharacterCreationCampaignBehavior.MotherNarrativeCharacterStringId = "mother\_character" | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#a02f774f6f349997a7a8dcec82ec225ec)FatherNarrativeCharacterStringId
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.CampaignSystem.CampaignBehaviors.CharacterCreationCampaignBehavior.FatherNarrativeCharacterStringId = "father\_character" | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#a65d9e499b7bdaf18401e4fc7cfb7365a)PlayerChildhoodCharacterStringId
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.CampaignSystem.CampaignBehaviors.CharacterCreationCampaignBehavior.PlayerChildhoodCharacterStringId = "player\_childhood\_character" | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#a65b4045b18e9deeaf7c29e9d704cd965)PlayerEducationCharacterStringId
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.CampaignSystem.CampaignBehaviors.CharacterCreationCampaignBehavior.PlayerEducationCharacterStringId = "player\_education\_character" | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#abfe2f3b28b81aefb129da121cdcdb8d8)PlayerYouthCharacterStringId
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.CampaignSystem.CampaignBehaviors.CharacterCreationCampaignBehavior.PlayerYouthCharacterStringId = "player\_youth\_character" | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#a755ec1b32817293c25d8a2dcd653b74e)PlayerAdulthoodCharacterStringId
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.CampaignSystem.CampaignBehaviors.CharacterCreationCampaignBehavior.PlayerAdulthoodCharacterStringId = "player\_adulthood\_character" | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#a34e141be722bd2f5bdcdad2caa1321ef)PlayerAgeSelectionCharacterStringId
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.CampaignSystem.CampaignBehaviors.CharacterCreationCampaignBehavior.PlayerAgeSelectionCharacterStringId = "player\_age\_selection\_character" | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_character_creation_campaign_behavior.html#a768958995475ca5c6fc5501b2cbe9aa2)HorseNarrativeCharacterStringId
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.CampaignSystem.CampaignBehaviors.CharacterCreationCampaignBehavior.HorseNarrativeCharacterStringId = "narrative\_character\_horse" | | static |

