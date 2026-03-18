--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu.html ---

TaleWorlds.CampaignSystem.CharacterCreationContent.NarrativeMenu Class Referencesealed|  |  |
| --- | --- |
| Public Member Functions | |
| delegate List< [NarrativeMenuCharacterArgs](struct_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_character_args.html) > | [GetNarrativeMenuCharacterArgsDelegate](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu.html#a3f7562b82ca00952fef5aaee495beff3) ([CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) culture, string occupationType, [CharacterCreationManager](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html) characterCreationManager) |
|  | [NarrativeMenu](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu.html#a620cf6515aaa75825766f1d1abe915ea) (string stringId, string inputMenuId, string outputMenuId, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) title, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) description, List< [NarrativeMenuCharacter](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_character.html) > characters, [GetNarrativeMenuCharacterArgsDelegate](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu.html#a3f7562b82ca00952fef5aaee495beff3) getNarrativeMenuCharacterArgs) |
| void | [AddNarrativeMenuOption](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu.html#a4c06296cb29e38fa46e48b5d98e82dc3) ([NarrativeMenuOption](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_option.html) narrativeMenuOption) |
| void | [RemoveNarrativeMenuOption](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu.html#a2e6b48eb8571c56d4ae192a50b591234) ([NarrativeMenuOption](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_option.html) narrativeMenuOption) |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly string | [StringId](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu.html#a1f8fdc1f1693b15abbe1ec52972b2569) |
| readonly string | [InputMenuId](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu.html#a0a8ca0c616b7686fce478c6f9f404e19) |
| readonly string | [OutputMenuId](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu.html#a8168ff18d80b45df02c25b328e598921) |
| readonly [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Title](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu.html#a44701be670c53a09f7622682fd1dcfc6) |
| readonly [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Description](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu.html#a4bf77ae6b3347b914e13476e61944472) |
| readonly [GetNarrativeMenuCharacterArgsDelegate](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu.html#a3f7562b82ca00952fef5aaee495beff3) | [GetNarrativeMenuCharacterArgs](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu.html#ab9d879311f23515cb63afd476fa54509) |

|  |  |
| --- | --- |
| Properties | |
| List< [NarrativeMenuCharacter](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_character.html) > | [Characters](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu.html#af51001228bf4e1462eaa7add304f8521) `[get]` |
| MBReadOnlyList< [NarrativeMenuOption](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_option.html) > | [CharacterCreationMenuOptions](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu.html#ac47d929797b5a149b5b4ccaa53c5bdfe) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu.html#a620cf6515aaa75825766f1d1abe915ea)NarrativeMenu()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.CharacterCreationContent.NarrativeMenu.NarrativeMenu | ( | string | *stringId*, |
|  |  | string | *inputMenuId*, |
|  |  | string | *outputMenuId*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *title*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *description*, |
|  |  | List< [NarrativeMenuCharacter](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_character.html) > | *characters*, |
|  |  | [GetNarrativeMenuCharacterArgsDelegate](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu.html#a3f7562b82ca00952fef5aaee495beff3) | *getNarrativeMenuCharacterArgs* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu.html#a3f7562b82ca00952fef5aaee495beff3)GetNarrativeMenuCharacterArgsDelegate()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate List< [NarrativeMenuCharacterArgs](struct_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_character_args.html) > TaleWorlds.CampaignSystem.CharacterCreationContent.NarrativeMenu.GetNarrativeMenuCharacterArgsDelegate | ( | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | *culture*, |
|  |  | string | *occupationType*, |
|  |  | [CharacterCreationManager](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html) | *characterCreationManager* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu.html#a4c06296cb29e38fa46e48b5d98e82dc3)AddNarrativeMenuOption()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterCreationContent.NarrativeMenu.AddNarrativeMenuOption | ( | [NarrativeMenuOption](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_option.html) | *narrativeMenuOption* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu.html#a2e6b48eb8571c56d4ae192a50b591234)RemoveNarrativeMenuOption()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterCreationContent.NarrativeMenu.RemoveNarrativeMenuOption | ( | [NarrativeMenuOption](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_option.html) | *narrativeMenuOption* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu.html#a1f8fdc1f1693b15abbe1ec52972b2569)StringId
-------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly string TaleWorlds.CampaignSystem.CharacterCreationContent.NarrativeMenu.StringId |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu.html#a0a8ca0c616b7686fce478c6f9f404e19)InputMenuId
----------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly string TaleWorlds.CampaignSystem.CharacterCreationContent.NarrativeMenu.InputMenuId |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu.html#a8168ff18d80b45df02c25b328e598921)OutputMenuId
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly string TaleWorlds.CampaignSystem.CharacterCreationContent.NarrativeMenu.OutputMenuId |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu.html#a44701be670c53a09f7622682fd1dcfc6)Title
----------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.CharacterCreationContent.NarrativeMenu.Title |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu.html#a4bf77ae6b3347b914e13476e61944472)Description
----------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.CharacterCreationContent.NarrativeMenu.Description |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu.html#ab9d879311f23515cb63afd476fa54509)GetNarrativeMenuCharacterArgs
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [GetNarrativeMenuCharacterArgsDelegate](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu.html#a3f7562b82ca00952fef5aaee495beff3) TaleWorlds.CampaignSystem.CharacterCreationContent.NarrativeMenu.GetNarrativeMenuCharacterArgs |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu.html#af51001228bf4e1462eaa7add304f8521)Characters
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[NarrativeMenuCharacter](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_character.html)> TaleWorlds.CampaignSystem.CharacterCreationContent.NarrativeMenu.Characters | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu.html#ac47d929797b5a149b5b4ccaa53c5bdfe)CharacterCreationMenuOptions
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[NarrativeMenuOption](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_option.html)> TaleWorlds.CampaignSystem.CharacterCreationContent.NarrativeMenu.CharacterCreationMenuOptions | | get |

