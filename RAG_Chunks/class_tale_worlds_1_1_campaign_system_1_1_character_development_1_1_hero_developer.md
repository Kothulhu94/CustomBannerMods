--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html ---

TaleWorlds.CampaignSystem.CharacterDevelopment.HeroDeveloper Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
| int | [GetSkillXpProgress](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#a044dc380c00101f38af4cab791f75cfb) ([SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill) |
| float | [GetSkillXp](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#ab5b221b1a02accb4e3e012deabb66b6d) ([SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill) |
| void | [ClearUnspentPoints](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#ad3eddc2bdc6e8f7c06402fac77778836) () |
| void | [ClearHero](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#a3f1c8fec8bada2a8f049f11df541714c) () |
| void | [InitializeHeroDeveloper](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#abfa5095907dcb8e5e667d7906ae40be4) () |
|  | Make sure [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) has correct level, free focus points and free attribute points. This can be called multiple times. It shouldn't destroy any existing data. |
| void | [DevelopCharacterStats](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#ac0c032885591102756b90fe0883e5fbf) () |
| int | [GetTotalSkillPoints](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#ad8d7b85cd2d7e0632fdd3205552ff6bb) () |
| void | [ChangeSkillLevel](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#a286c9ed8a2a5c9f7fecce0e695b549be) ([SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill, int changeAmount, bool shouldNotify=true) |
| void | [SetInitialSkillLevel](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#a5771dc9076ff144645d28f21c5751332) ([SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill, int newSkillValue) |
| void | [AddSkillXp](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#ac8ca1fcc1f7c83baadf66a02f83bc057) ([SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill, float rawXp, bool isAffectedByFocusFactor=true, bool shouldNotify=true) |
| float | [GetFocusFactor](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#a2de449ff9781561fb7314240f42900d2) ([SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill) |
| void | [CheckLevel](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#a586bb18a0f6ecd26015756b8ce5704ad) (bool shouldNotify) |
| void | [SetInitialLevel](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#aa6eaf9fcceb11e2f899c940e70d81a00) (int level) |
| void | [AddPerk](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#a12d4b3f673647db8ca86c85ec90e761f) ([PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) perk) |
| int | [GetXpRequiredForLevel](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#a632db78fa142127e2f51e136d5552ad6) (int level) |
| void | [RemoveAttribute](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#ad4533620c51f7e689671e64ab1e54bfe) ([CharacterAttribute](class_tale_worlds_1_1_core_1_1_character_attribute.html) attrib, int changeAmount) |
| void | [AddAttribute](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#ac124337521f99f1f072d3fc7427b579c) ([CharacterAttribute](class_tale_worlds_1_1_core_1_1_character_attribute.html) attrib, int changeAmount, bool checkUnspentPoints=true) |
| void | [AddFocus](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#a248a2b9631e9db239f43f69d3841c6bd) ([SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill, int changeAmount, bool checkUnspentFocusPoints=true) |
| void | [RemoveFocus](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#ac27c5d0def4695301b7e31517f439608) ([SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill, int changeAmount) |
| bool | [CanAddFocusToSkill](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#a58a2866ded2e3a4909f4e648bcf6a9b7) ([SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill) |
| int | [GetRequiredFocusPointsToAddFocus](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#a9b274f327480963710fee499ca8b6629) ([SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill) |
| int | [GetFocus](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#aed14c0e7f3762b0edf28942819109c92) ([SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill) |
| bool | [GetPerkValue](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#a97e61b5e21cd88e6fcec157f824e9c9a) ([PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) perk) |
| void | [InitializeSkillXp](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#a05f5e1fc9bf1540e6a91a83a837a40bd) ([SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill) |
| void | [AfterLoad](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#ae2cbe6b52390d3756e5f3af106aa1f0b) () |

|  |  |
| --- | --- |
| Properties | |
| int | [UnspentFocusPoints](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#a9220a2f6b6cc154f8fd8f186d1af1b46) `[get, set]` |
| int | [UnspentAttributePoints](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#aa2b1067f109c7919a12131450ce931c6) `[get, set]` |
| bool | [IsDeveloperInitialized](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#a213c50cd944d15770e0fe62638e92600) `[get]` |
| Hero | [Hero](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#ababa62b1b1e7d62ae2348271496963e2) `[get]` |
| int | [TotalXp](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#a6aa6b494fe39e365949d289a54f708c8) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#a044dc380c00101f38af4cab791f75cfb)GetSkillXpProgress()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.CharacterDevelopment.HeroDeveloper.GetSkillXpProgress | ( | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#ab5b221b1a02accb4e3e012deabb66b6d)GetSkillXp()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.CharacterDevelopment.HeroDeveloper.GetSkillXp | ( | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#ad3eddc2bdc6e8f7c06402fac77778836)ClearUnspentPoints()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.HeroDeveloper.ClearUnspentPoints | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#a3f1c8fec8bada2a8f049f11df541714c)ClearHero()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.HeroDeveloper.ClearHero | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#abfa5095907dcb8e5e667d7906ae40be4)InitializeHeroDeveloper()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.HeroDeveloper.InitializeHeroDeveloper | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#ac0c032885591102756b90fe0883e5fbf)DevelopCharacterStats()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.HeroDeveloper.DevelopCharacterStats | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#ad8d7b85cd2d7e0632fdd3205552ff6bb)GetTotalSkillPoints()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.CharacterDevelopment.HeroDeveloper.GetTotalSkillPoints | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#a286c9ed8a2a5c9f7fecce0e695b549be)ChangeSkillLevel()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.HeroDeveloper.ChangeSkillLevel | ( | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill*, |
|  |  | int | *changeAmount*, |
|  |  | bool | *shouldNotify* = true ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#a5771dc9076ff144645d28f21c5751332)SetInitialSkillLevel()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.HeroDeveloper.SetInitialSkillLevel | ( | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill*, |
|  |  | int | *newSkillValue* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#ac8ca1fcc1f7c83baadf66a02f83bc057)AddSkillXp()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.HeroDeveloper.AddSkillXp | ( | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill*, |
|  |  | float | *rawXp*, |
|  |  | bool | *isAffectedByFocusFactor* = true, |
|  |  | bool | *shouldNotify* = true ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#a2de449ff9781561fb7314240f42900d2)GetFocusFactor()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.CharacterDevelopment.HeroDeveloper.GetFocusFactor | ( | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#a586bb18a0f6ecd26015756b8ce5704ad)CheckLevel()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.HeroDeveloper.CheckLevel | ( | bool | *shouldNotify* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#aa6eaf9fcceb11e2f899c940e70d81a00)SetInitialLevel()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.HeroDeveloper.SetInitialLevel | ( | int | *level* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#a12d4b3f673647db8ca86c85ec90e761f)AddPerk()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.HeroDeveloper.AddPerk | ( | [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) | *perk* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#a632db78fa142127e2f51e136d5552ad6)GetXpRequiredForLevel()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.CharacterDevelopment.HeroDeveloper.GetXpRequiredForLevel | ( | int | *level* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#ad4533620c51f7e689671e64ab1e54bfe)RemoveAttribute()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.HeroDeveloper.RemoveAttribute | ( | [CharacterAttribute](class_tale_worlds_1_1_core_1_1_character_attribute.html) | *attrib*, |
|  |  | int | *changeAmount* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#ac124337521f99f1f072d3fc7427b579c)AddAttribute()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.HeroDeveloper.AddAttribute | ( | [CharacterAttribute](class_tale_worlds_1_1_core_1_1_character_attribute.html) | *attrib*, |
|  |  | int | *changeAmount*, |
|  |  | bool | *checkUnspentPoints* = true ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#a248a2b9631e9db239f43f69d3841c6bd)AddFocus()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.HeroDeveloper.AddFocus | ( | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill*, |
|  |  | int | *changeAmount*, |
|  |  | bool | *checkUnspentFocusPoints* = true ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#ac27c5d0def4695301b7e31517f439608)RemoveFocus()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.HeroDeveloper.RemoveFocus | ( | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill*, |
|  |  | int | *changeAmount* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#a58a2866ded2e3a4909f4e648bcf6a9b7)CanAddFocusToSkill()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CharacterDevelopment.HeroDeveloper.CanAddFocusToSkill | ( | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#a9b274f327480963710fee499ca8b6629)GetRequiredFocusPointsToAddFocus()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.CharacterDevelopment.HeroDeveloper.GetRequiredFocusPointsToAddFocus | ( | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#aed14c0e7f3762b0edf28942819109c92)GetFocus()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.CharacterDevelopment.HeroDeveloper.GetFocus | ( | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#a97e61b5e21cd88e6fcec157f824e9c9a)GetPerkValue()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CharacterDevelopment.HeroDeveloper.GetPerkValue | ( | [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) | *perk* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#a05f5e1fc9bf1540e6a91a83a837a40bd)InitializeSkillXp()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.HeroDeveloper.InitializeSkillXp | ( | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#ae2cbe6b52390d3756e5f3af106aa1f0b)AfterLoad()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.HeroDeveloper.AfterLoad | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#a9220a2f6b6cc154f8fd8f186d1af1b46)UnspentFocusPoints
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.CharacterDevelopment.HeroDeveloper.UnspentFocusPoints | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#aa2b1067f109c7919a12131450ce931c6)UnspentAttributePoints
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.CharacterDevelopment.HeroDeveloper.UnspentAttributePoints | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#a213c50cd944d15770e0fe62638e92600)IsDeveloperInitialized
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.CharacterDevelopment.HeroDeveloper.IsDeveloperInitialized | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#ababa62b1b1e7d62ae2348271496963e2)Hero
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Hero TaleWorlds.CampaignSystem.CharacterDevelopment.HeroDeveloper.Hero | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_hero_developer.html#a6aa6b494fe39e365949d289a54f708c8)TotalXp
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.CharacterDevelopment.HeroDeveloper.TotalXp | | get |

