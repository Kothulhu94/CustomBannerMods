--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultAgeModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.AgeModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_age_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [GetAgeLimitForLocation](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html#a8b8f7c05fcade633762f16cb86e65f67) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, out int minimumAge, out int maximumAge, string additionalTags="") |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.AgeModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_age_model.html) | |
| void | [GetAgeLimitForLocation](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_age_model.html#a78369c88f628baf23970df3045dfee99) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, out int minimumAge, out int maximumAge, string additionalTags="") |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const string | [TavernVisitorTag](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html#a46ff529fc6ef7801902be38704d055a9) = "TavernVisitor" |
| const string | [TavernDrinkerTag](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html#a7bd44ce83d8679b5b03d4b8cd137b21c) = "TavernDrinker" |
| const string | [SlowTownsmanTag](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html#a78c9d6075f9d84effd9738b45baad75f) = "SlowTownsman" |
| const string | [TownsfolkCarryingStuffTag](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html#a9af8f87aab69a7ab7ba59fdbd3890d0e) = "TownsfolkCarryingStuff" |
| const string | [BroomsWomanTag](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html#a50e0a02a838582687a57af86f90a21a7) = "BroomsWoman" |
| const string | [DancerTag](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html#aacd877c0551f8fffa5d35e3673696ee6) = "Dancer" |
| const string | [BeggarTag](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html#a13566b8e68c3c4a5dd2a392c45eb6a9a) = "Beggar" |
| const string | [ChildTag](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html#a1d974d797bbf48ab2b59b4ebb9c20a47) = "Child" |
| const string | [TeenagerTag](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html#af09d833ae40d6c3895917735420fa02a) = "Teenager" |
| const string | [InfantTag](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html#a41f61a7ba4e44a3b4b3e6a466687a406) = "Infant" |
| const string | [NotaryTag](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html#a8b90aaeb9889971a89daadc2bc1b91bd) = "Notary" |
| const string | [BarberTag](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html#ae614438257cad85ba98d3d8b927f52d2) = "Barber" |
| const string | [AlleyGangMemberTag](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html#aca37fe585dace7c38ff368d63f85b814) = "AlleyGangMember" |

|  |  |
| --- | --- |
| Properties | |
| override int | [BecomeInfantAge](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html#a0292575d0e537a30daa737aa18b02206) `[get]` |
| override int | [BecomeChildAge](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html#ada23358d28e17e5f8c203e7da6d6c972) `[get]` |
| override int | [BecomeTeenagerAge](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html#a07da59bf58e6b03d3864aed96a7a8cb1) `[get]` |
| override int | [HeroComesOfAge](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html#ab612b13a14a1631480b92e74a003c806) `[get]` |
| override int | [MiddleAdultHoodAge](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html#a1034fbf75c376243a10e90e486675ddc) `[get]` |
| override int | [BecomeOldAge](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html#a0298153d4d5dc2bd90ba9e2bcd162c05) `[get]` |
| override int | [MaxAge](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html#a8f0440b615a340fae191e5d9d239ed4f) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.AgeModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_age_model.html) | |
| int | [BecomeInfantAge](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_age_model.html#a4e6566d713a4797c5e453e92b68a0502) `[get]` |
| int | [BecomeChildAge](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_age_model.html#ad3112584363fc80d2998aa40aa2db53a) `[get]` |
| int | [BecomeTeenagerAge](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_age_model.html#aa9b9b78ea282b788441df20dbdc55d33) `[get]` |
| int | [HeroComesOfAge](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_age_model.html#ad81ccd688e082e71755ca6b832957e04) `[get]` |
| int | [BecomeOldAge](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_age_model.html#a4f4edff8bb4815b21c4671bf78f57d14) `[get]` |
| int | [MiddleAdultHoodAge](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_age_model.html#acde5647b8e263fd87104b1f5568e2524) `[get]` |
| int | [MaxAge](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_age_model.html#abb6afd8086422652cedc9c5bda1230b2) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html#a8b8f7c05fcade633762f16cb86e65f67)GetAgeLimitForLocation()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.GameComponents.DefaultAgeModel.GetAgeLimitForLocation | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, |
|  |  | out int | *minimumAge*, |
|  |  | out int | *maximumAge*, |
|  |  | string | *additionalTags* = "" ) |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html#a46ff529fc6ef7801902be38704d055a9)TavernVisitorTag
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.CampaignSystem.GameComponents.DefaultAgeModel.TavernVisitorTag = "TavernVisitor" | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html#a7bd44ce83d8679b5b03d4b8cd137b21c)TavernDrinkerTag
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.CampaignSystem.GameComponents.DefaultAgeModel.TavernDrinkerTag = "TavernDrinker" | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html#a78c9d6075f9d84effd9738b45baad75f)SlowTownsmanTag
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.CampaignSystem.GameComponents.DefaultAgeModel.SlowTownsmanTag = "SlowTownsman" | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html#a9af8f87aab69a7ab7ba59fdbd3890d0e)TownsfolkCarryingStuffTag
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.CampaignSystem.GameComponents.DefaultAgeModel.TownsfolkCarryingStuffTag = "TownsfolkCarryingStuff" | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html#a50e0a02a838582687a57af86f90a21a7)BroomsWomanTag
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.CampaignSystem.GameComponents.DefaultAgeModel.BroomsWomanTag = "BroomsWoman" | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html#aacd877c0551f8fffa5d35e3673696ee6)DancerTag
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.CampaignSystem.GameComponents.DefaultAgeModel.DancerTag = "Dancer" | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html#a13566b8e68c3c4a5dd2a392c45eb6a9a)BeggarTag
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.CampaignSystem.GameComponents.DefaultAgeModel.BeggarTag = "Beggar" | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html#a1d974d797bbf48ab2b59b4ebb9c20a47)ChildTag
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.CampaignSystem.GameComponents.DefaultAgeModel.ChildTag = "Child" | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html#af09d833ae40d6c3895917735420fa02a)TeenagerTag
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.CampaignSystem.GameComponents.DefaultAgeModel.TeenagerTag = "Teenager" | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html#a41f61a7ba4e44a3b4b3e6a466687a406)InfantTag
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.CampaignSystem.GameComponents.DefaultAgeModel.InfantTag = "Infant" | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html#a8b90aaeb9889971a89daadc2bc1b91bd)NotaryTag
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.CampaignSystem.GameComponents.DefaultAgeModel.NotaryTag = "Notary" | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html#ae614438257cad85ba98d3d8b927f52d2)BarberTag
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.CampaignSystem.GameComponents.DefaultAgeModel.BarberTag = "Barber" | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html#aca37fe585dace7c38ff368d63f85b814)AlleyGangMemberTag
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.CampaignSystem.GameComponents.DefaultAgeModel.AlleyGangMemberTag = "AlleyGangMember" | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html#a0292575d0e537a30daa737aa18b02206)BecomeInfantAge
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultAgeModel.BecomeInfantAge | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html#ada23358d28e17e5f8c203e7da6d6c972)BecomeChildAge
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultAgeModel.BecomeChildAge | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html#a07da59bf58e6b03d3864aed96a7a8cb1)BecomeTeenagerAge
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultAgeModel.BecomeTeenagerAge | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html#ab612b13a14a1631480b92e74a003c806)HeroComesOfAge
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultAgeModel.HeroComesOfAge | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html#a1034fbf75c376243a10e90e486675ddc)MiddleAdultHoodAge
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultAgeModel.MiddleAdultHoodAge | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html#a0298153d4d5dc2bd90ba9e2bcd162c05)BecomeOldAge
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultAgeModel.BecomeOldAge | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html#a8f0440b615a340fae191e5d9d239ed4f)MaxAge
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultAgeModel.MaxAge | | get |

