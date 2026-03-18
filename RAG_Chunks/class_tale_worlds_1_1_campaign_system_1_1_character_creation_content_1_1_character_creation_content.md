--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html ---

TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationContent Class Referencesealed|  |  |
| --- | --- |
| Public Member Functions | |
| delegate bool | [TryGetEquipmentIdDelegate](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#a99f41e0b544632d5774feeae02efe65e) (string occupationId, out string equipmentId) |
|  | [CharacterCreationContent](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#aef24d7a8be34a592aa7f2cdb7cb51cf3) () |
| void | [AddCharacterCreationCulture](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#a16be3c834b47d27a7bc59f6e6a593810) ([CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) culture, int focusToAddByCulture, int skillLevelToAddByCulture) |
| int | [GetFocusToAddByCulture](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#a9ea6e443af3a3d1c7aea97ec8e1e724b) ([CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) culture) |
| int | [GetSkillLevelToAddByCulture](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#aaee10559fac9f81ac8ba21182b886aea) ([CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) culture) |
| void | [ChangeReviewPageDescription](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#a88d39683aeec12225ebb12060c8348ff) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) reviewPageDescription) |
| void | [SetMainCharacterName](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#aaf4f723b2a4f03ed65ffce92072143ba) (string name) |
| void | [SetParentOccupation](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#a7d78b4a42416473bb041473cc839a07f) (string occupationType) |
| void | [ApplySkillAndAttributeEffects](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#accfb834460c6757b09babe5e97dcf6b9) (List< [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) > skills, int focusToAdd, int skillLevelToAdd, [CharacterAttribute](class_tale_worlds_1_1_core_1_1_character_attribute.html) attribute, int attributeLevelToAdd, List< [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html) > traits=null, int traitLevelToAdd=0, int renownToAdd=0, int goldToAdd=0, int unspentFocusPoints=0, int unspentAttributePoints=0) |
| void | [SetMainClanBanner](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#a053093e761d539cc5197a9909894efda) ([Banner](class_tale_worlds_1_1_core_1_1_banner.html) banner) |
| void | [SetSelectedCulture](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#af7ee540b5778405332f5d57c2bcebdc3) ([CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) culture, [CharacterCreationManager](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html) characterCreationManager) |
| void | [ApplyCulture](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#ac1a89b8d6511d0732853c5ececec552d) ([CharacterCreationManager](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html) characterCreationManager) |
| IEnumerable< [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) > | [GetCultures](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#a9a8dee91a206108b63efa3c26fd6a653) () |
| void | [AddEquipmentToUseGetter](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#a61ab1fbf7056570fd26476cef18dfbd9) ([TryGetEquipmentIdDelegate](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#a99f41e0b544632d5774feeae02efe65e) tryGetEquipmentIdDelegate) |
| bool | [TryGetEquipmentToUse](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#a555dcd7164b055c20a112f472f39efd2) (string occupationId, out string equipmentId) |

|  |  |
| --- | --- |
| Public Attributes | |
| int | [FocusToAdd](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#ad02ec69e1dd7b82eb323c3385f18acfc) = 1 |
| int | [SkillLevelToAdd](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#a60005733e50659c996fb03cb7b46b07b) = 10 |
| int | [AttributeLevelToAdd](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#a59f0409c85d3ef85ac566aa552c968cd) = 1 |
| int | [StartingAge](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#a6f8b7e8fa0d94416eea6bba472801d34) = 20 |

|  |  |
| --- | --- |
| Properties | |
| string | [SelectedTitleType](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#a22ba058bc6c16250210a323d4a082285) `[get, set]` |
| string | [SelectedParentOccupation](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#a7d3a2a86b91a3aec9e7307d8edfd460d) `[get]` |
| string | [DefaultSelectedTitleType](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#ac849a3d86e65d3b79d355fa44d572ac8) `[get, set]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [ReviewPageDescription](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#a5573abd8114e395c17c35d08a9b39cdd) `[get]` |
| string | [MainCharacterName](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#a0dd72df3f348084ea0518f6e9c617de3) `[get]` |
| [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | [SelectedCulture](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#a1a31157eb681f883612d9caccde85606) = null `[get]` |
| [Banner](class_tale_worlds_1_1_core_1_1_banner.html) | [SelectedBanner](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#a5ee8149cd8c12d5ba2c6cd9c08bc57f1) = null `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#aef24d7a8be34a592aa7f2cdb7cb51cf3)CharacterCreationContent()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationContent.CharacterCreationContent | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#a99f41e0b544632d5774feeae02efe65e)TryGetEquipmentIdDelegate()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate bool TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationContent.TryGetEquipmentIdDelegate | ( | string | *occupationId*, |
|  |  | out string | *equipmentId* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#a16be3c834b47d27a7bc59f6e6a593810)AddCharacterCreationCulture()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationContent.AddCharacterCreationCulture | ( | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | *culture*, |
|  |  | int | *focusToAddByCulture*, |
|  |  | int | *skillLevelToAddByCulture* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#a9ea6e443af3a3d1c7aea97ec8e1e724b)GetFocusToAddByCulture()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationContent.GetFocusToAddByCulture | ( | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | *culture* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#aaee10559fac9f81ac8ba21182b886aea)GetSkillLevelToAddByCulture()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationContent.GetSkillLevelToAddByCulture | ( | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | *culture* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#a88d39683aeec12225ebb12060c8348ff)ChangeReviewPageDescription()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationContent.ChangeReviewPageDescription | ( | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *reviewPageDescription* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#aaf4f723b2a4f03ed65ffce92072143ba)SetMainCharacterName()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationContent.SetMainCharacterName | ( | string | *name* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#a7d78b4a42416473bb041473cc839a07f)SetParentOccupation()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationContent.SetParentOccupation | ( | string | *occupationType* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#accfb834460c6757b09babe5e97dcf6b9)ApplySkillAndAttributeEffects()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationContent.ApplySkillAndAttributeEffects | ( | List< [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) > | *skills*, |
|  |  | int | *focusToAdd*, |
|  |  | int | *skillLevelToAdd*, |
|  |  | [CharacterAttribute](class_tale_worlds_1_1_core_1_1_character_attribute.html) | *attribute*, |
|  |  | int | *attributeLevelToAdd*, |
|  |  | List< [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html) > | *traits* = null, |
|  |  | int | *traitLevelToAdd* = 0, |
|  |  | int | *renownToAdd* = 0, |
|  |  | int | *goldToAdd* = 0, |
|  |  | int | *unspentFocusPoints* = 0, |
|  |  | int | *unspentAttributePoints* = 0 ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#a053093e761d539cc5197a9909894efda)SetMainClanBanner()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationContent.SetMainClanBanner | ( | [Banner](class_tale_worlds_1_1_core_1_1_banner.html) | *banner* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#af7ee540b5778405332f5d57c2bcebdc3)SetSelectedCulture()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationContent.SetSelectedCulture | ( | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | *culture*, |
|  |  | [CharacterCreationManager](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html) | *characterCreationManager* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#ac1a89b8d6511d0732853c5ececec552d)ApplyCulture()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationContent.ApplyCulture | ( | [CharacterCreationManager](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html) | *characterCreationManager* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#a9a8dee91a206108b63efa3c26fd6a653)GetCultures()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) > TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationContent.GetCultures | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#a61ab1fbf7056570fd26476cef18dfbd9)AddEquipmentToUseGetter()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationContent.AddEquipmentToUseGetter | ( | [TryGetEquipmentIdDelegate](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#a99f41e0b544632d5774feeae02efe65e) | *tryGetEquipmentIdDelegate* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#a555dcd7164b055c20a112f472f39efd2)TryGetEquipmentToUse()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationContent.TryGetEquipmentToUse | ( | string | *occupationId*, |
|  |  | out string | *equipmentId* ) |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#ad02ec69e1dd7b82eb323c3385f18acfc)FocusToAdd
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationContent.FocusToAdd = 1 |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#a60005733e50659c996fb03cb7b46b07b)SkillLevelToAdd
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationContent.SkillLevelToAdd = 10 |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#a59f0409c85d3ef85ac566aa552c968cd)AttributeLevelToAdd
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationContent.AttributeLevelToAdd = 1 |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#a6f8b7e8fa0d94416eea6bba472801d34)StartingAge
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationContent.StartingAge = 20 |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#a22ba058bc6c16250210a323d4a082285)SelectedTitleType
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationContent.SelectedTitleType | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#a7d3a2a86b91a3aec9e7307d8edfd460d)SelectedParentOccupation
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationContent.SelectedParentOccupation | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#ac849a3d86e65d3b79d355fa44d572ac8)DefaultSelectedTitleType
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationContent.DefaultSelectedTitleType | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#a5573abd8114e395c17c35d08a9b39cdd)ReviewPageDescription
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationContent.ReviewPageDescription | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#a0dd72df3f348084ea0518f6e9c617de3)MainCharacterName
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationContent.MainCharacterName | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#a1a31157eb681f883612d9caccde85606)SelectedCulture
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationContent.SelectedCulture = null | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_content.html#a5ee8149cd8c12d5ba2c6cd9c08bc57f1)SelectedBanner
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Banner](class_tale_worlds_1_1_core_1_1_banner.html) TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationContent.SelectedBanner = null | | get |

