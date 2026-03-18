--- SOURCE: class_tale_worlds_1_1_core_1_1_mission_siege_weapon.html ---

TaleWorlds.Core.MissionSiegeWeapon Class ReferenceRepresents a unique mission siege weapon. Matches to a campaign/sandbox weapon for campaign/sandbox mode.

Inherits [TaleWorlds.Core.IMissionSiegeWeapon](interface_tale_worlds_1_1_core_1_1_i_mission_siege_weapon.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [SetHealth](class_tale_worlds_1_1_core_1_1_mission_siege_weapon.html#af1f0ffe465de4396e8ee9ee4ae580e1d) (float health) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static MissionSiegeWeapon | [CreateDefaultWeapon](class_tale_worlds_1_1_core_1_1_mission_siege_weapon.html#ad4c4c01880f8e5d390e1ebcc608d94e4) ([SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) type) |
| static MissionSiegeWeapon | [CreateCampaignWeapon](class_tale_worlds_1_1_core_1_1_mission_siege_weapon.html#a483ae5712af60561a8b1a9c2629d822f) ([SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) type, int index, float health, float maxHealth) |

|  |  |
| --- | --- |
| Properties | |
| int | [Index](class_tale_worlds_1_1_core_1_1_mission_siege_weapon.html#a40770aeb415639c96364e8f480ba9b5f) `[get]` |
| [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | [Type](class_tale_worlds_1_1_core_1_1_mission_siege_weapon.html#aeef3edec4281c335d3ca059dcf06826d) `[get]` |
| float | [Health](class_tale_worlds_1_1_core_1_1_mission_siege_weapon.html#a31d467c9100c59586e89579ce1d2b2d0) `[get]` |
| float | [InitialHealth](class_tale_worlds_1_1_core_1_1_mission_siege_weapon.html#ae09654444a7c0be3a583a699394d8d04) `[get]` |
| float | [MaxHealth](class_tale_worlds_1_1_core_1_1_mission_siege_weapon.html#a703c7db6fe5f472b11fceb0b304e7565) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_mission_siege_weapon.html#ad4c4c01880f8e5d390e1ebcc608d94e4)CreateDefaultWeapon()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | MissionSiegeWeapon TaleWorlds.Core.MissionSiegeWeapon.CreateDefaultWeapon | ( | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *type* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_mission_siege_weapon.html#a483ae5712af60561a8b1a9c2629d822f)CreateCampaignWeapon()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | MissionSiegeWeapon TaleWorlds.Core.MissionSiegeWeapon.CreateCampaignWeapon | ( | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *type*, | |  |  | int | *index*, | |  |  | float | *health*, | |  |  | float | *maxHealth* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_mission_siege_weapon.html#af1f0ffe465de4396e8ee9ee4ae580e1d)SetHealth()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.MissionSiegeWeapon.SetHealth | ( | float | *health* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_mission_siege_weapon.html#a40770aeb415639c96364e8f480ba9b5f)Index
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.MissionSiegeWeapon.Index | | get |

Implements [TaleWorlds.Core.IMissionSiegeWeapon](interface_tale_worlds_1_1_core_1_1_i_mission_siege_weapon.html#a304ac8dca52a2e59d7e16e32adef929c).

[◆](class_tale_worlds_1_1_core_1_1_mission_siege_weapon.html#aeef3edec4281c335d3ca059dcf06826d)Type
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) TaleWorlds.Core.MissionSiegeWeapon.Type | | get |

Implements [TaleWorlds.Core.IMissionSiegeWeapon](interface_tale_worlds_1_1_core_1_1_i_mission_siege_weapon.html#a3122095d303f85f466fc1dfef534de03).

[◆](class_tale_worlds_1_1_core_1_1_mission_siege_weapon.html#a31d467c9100c59586e89579ce1d2b2d0)Health
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.MissionSiegeWeapon.Health | | get |

Implements [TaleWorlds.Core.IMissionSiegeWeapon](interface_tale_worlds_1_1_core_1_1_i_mission_siege_weapon.html#a7e72cb920d96d0e8d514f82bfbca0e07).

[◆](class_tale_worlds_1_1_core_1_1_mission_siege_weapon.html#ae09654444a7c0be3a583a699394d8d04)InitialHealth
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.MissionSiegeWeapon.InitialHealth | | get |

Implements [TaleWorlds.Core.IMissionSiegeWeapon](interface_tale_worlds_1_1_core_1_1_i_mission_siege_weapon.html#ae24bdd54493a8b400560ae860442fe10).

[◆](class_tale_worlds_1_1_core_1_1_mission_siege_weapon.html#a703c7db6fe5f472b11fceb0b304e7565)MaxHealth
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.MissionSiegeWeapon.MaxHealth | | get |

Implements [TaleWorlds.Core.IMissionSiegeWeapon](interface_tale_worlds_1_1_core_1_1_i_mission_siege_weapon.html#a251fa978e80877ac412605eab8794d6f).

