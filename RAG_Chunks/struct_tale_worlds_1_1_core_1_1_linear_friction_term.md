--- SOURCE: struct_tale_worlds_1_1_core_1_1_linear_friction_term.html ---

TaleWorlds.Core.LinearFrictionTerm Struct ReferenceKeeps per direction values of the linear drag and damping term of the ship (in kg/m).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [LinearFrictionTerm](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html#aaa722a152b1d14df9345f405306e8005) (float right, float left, float forward, float backward, float up, float down) |
| [LinearFrictionTerm](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html#aaa722a152b1d14df9345f405306e8005) | [ElementWiseProduct](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html#aa7da174474612897a9232b53a6687b77) ([LinearFrictionTerm](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html#aaa722a152b1d14df9345f405306e8005) o) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [LinearFrictionTerm](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html#aaa722a152b1d14df9345f405306e8005) | [operator/](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html#af905fa418723cf2dcba1ec9e932e783d) ([LinearFrictionTerm](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html#aaa722a152b1d14df9345f405306e8005) o, float f) |
| static [LinearFrictionTerm](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html#aaa722a152b1d14df9345f405306e8005) | [operator\*](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html#a2b3e6821f862df9a5d9d6a17df314198) ([LinearFrictionTerm](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html#aaa722a152b1d14df9345f405306e8005) o, float f) |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly float | [Right](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html#a3153f6bfae2832c5d07b5431dfa64d74) |
| readonly float | [Left](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html#af7134e31c3b21991ccd23d8c16c0220e) |
| readonly float | [Forward](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html#aab8184bed45c58ce64fba81833db37d8) |
| readonly float | [Backward](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html#a9d2cc6e18832eb90e1c3e6cc3ef5c45b) |
| readonly float | [Up](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html#a957e3a64fa1e45bd897e9875a65fccc1) |
| readonly float | [Down](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html#aabd8b4a407171f5040a48fa2304330a8) |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsValid](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html#a5890e4eaa91639a3f8107295946bdcee) `[get]` |
| static [LinearFrictionTerm](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html#aaa722a152b1d14df9345f405306e8005) | [Invalid](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html#ab98ae4f6a77aa93bb67382d5e99b9845) `[get]` |
| static [LinearFrictionTerm](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html#aaa722a152b1d14df9345f405306e8005) | [One](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html#a3cb467bdb6b2e47692d9a13c0f0364ae) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html#aaa722a152b1d14df9345f405306e8005)LinearFrictionTerm()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Core.LinearFrictionTerm.LinearFrictionTerm | ( | float | *right*, |
|  |  | float | *left*, |
|  |  | float | *forward*, |
|  |  | float | *backward*, |
|  |  | float | *up*, |
|  |  | float | *down* ) |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html#af905fa418723cf2dcba1ec9e932e783d)operator/()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [LinearFrictionTerm](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html#aaa722a152b1d14df9345f405306e8005) TaleWorlds.Core.LinearFrictionTerm.operator/ | ( | [LinearFrictionTerm](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html#aaa722a152b1d14df9345f405306e8005) | *o*, | |  |  | float | *f* ) | | static |

[◆](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html#a2b3e6821f862df9a5d9d6a17df314198)operator\*()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [LinearFrictionTerm](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html#aaa722a152b1d14df9345f405306e8005) TaleWorlds.Core.LinearFrictionTerm.operator\* | ( | [LinearFrictionTerm](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html#aaa722a152b1d14df9345f405306e8005) | *o*, | |  |  | float | *f* ) | | static |

[◆](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html#aa7da174474612897a9232b53a6687b77)ElementWiseProduct()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [LinearFrictionTerm](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html#aaa722a152b1d14df9345f405306e8005) TaleWorlds.Core.LinearFrictionTerm.ElementWiseProduct | ( | [LinearFrictionTerm](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html#aaa722a152b1d14df9345f405306e8005) | *o* | ) |  |

Member Data Documentation
-------------------------

[◆](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html#a3153f6bfae2832c5d07b5431dfa64d74)Right
-----------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly float TaleWorlds.Core.LinearFrictionTerm.Right |

[◆](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html#af7134e31c3b21991ccd23d8c16c0220e)Left
----------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly float TaleWorlds.Core.LinearFrictionTerm.Left |

[◆](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html#aab8184bed45c58ce64fba81833db37d8)Forward
-------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly float TaleWorlds.Core.LinearFrictionTerm.Forward |

[◆](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html#a9d2cc6e18832eb90e1c3e6cc3ef5c45b)Backward
--------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly float TaleWorlds.Core.LinearFrictionTerm.Backward |

[◆](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html#a957e3a64fa1e45bd897e9875a65fccc1)Up
--------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly float TaleWorlds.Core.LinearFrictionTerm.Up |

[◆](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html#aabd8b4a407171f5040a48fa2304330a8)Down
----------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly float TaleWorlds.Core.LinearFrictionTerm.Down |

Property Documentation
----------------------

[◆](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html#a5890e4eaa91639a3f8107295946bdcee)IsValid
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.LinearFrictionTerm.IsValid | | get |

[◆](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html#ab98ae4f6a77aa93bb67382d5e99b9845)Invalid
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [LinearFrictionTerm](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html#aaa722a152b1d14df9345f405306e8005) TaleWorlds.Core.LinearFrictionTerm.Invalid | | staticget |

[◆](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html#a3cb467bdb6b2e47692d9a13c0f0364ae)One
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [LinearFrictionTerm](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html#aaa722a152b1d14df9345f405306e8005) TaleWorlds.Core.LinearFrictionTerm.One | | staticget |

