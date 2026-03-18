--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_age_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.AgeModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultAgeModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_age_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [GetAgeLimitForLocation](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_age_model.html#a78369c88f628baf23970df3045dfee99) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, out int minimumAge, out int maximumAge, string additionalTags="") |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_age_model.html#a78369c88f628baf23970df3045dfee99)GetAgeLimitForLocation()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.ComponentInterfaces.AgeModel.GetAgeLimitForLocation | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, | |  |  | out int | *minimumAge*, | |  |  | out int | *maximumAge*, | |  |  | string | *additionalTags* = "" ) | | abstract |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_age_model.html#a4e6566d713a4797c5e453e92b68a0502)BecomeInfantAge
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.AgeModel.BecomeInfantAge | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_age_model.html#ad3112584363fc80d2998aa40aa2db53a)BecomeChildAge
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.AgeModel.BecomeChildAge | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_age_model.html#aa9b9b78ea282b788441df20dbdc55d33)BecomeTeenagerAge
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.AgeModel.BecomeTeenagerAge | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_age_model.html#ad81ccd688e082e71755ca6b832957e04)HeroComesOfAge
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.AgeModel.HeroComesOfAge | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_age_model.html#a4f4edff8bb4815b21c4671bf78f57d14)BecomeOldAge
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.AgeModel.BecomeOldAge | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_age_model.html#acde5647b8e263fd87104b1f5568e2524)MiddleAdultHoodAge
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.AgeModel.MiddleAdultHoodAge | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_age_model.html#abb6afd8086422652cedc9c5bda1230b2)MaxAge
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.AgeModel.MaxAge | | getabstract |

