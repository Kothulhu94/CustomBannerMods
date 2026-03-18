--- SOURCE: class_tale_worlds_1_1_core_1_1_timer.html ---

TaleWorlds.Core.Timer Class ReferenceA timer class that alarms when given amount of time has passed.

Inherited by [TaleWorlds.MountAndBlade.RandomTimer](class_tale_worlds_1_1_mount_and_blade_1_1_random_timer.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [Timer](class_tale_worlds_1_1_core_1_1_timer.html#a81913628844d02e547b6b00190ef8a70) (float gameTime, float duration, bool autoReset=true) |
|  | Initializes a new instance of the [Timer](class_tale_worlds_1_1_core_1_1_timer.html "A timer class that alarms when given amount of time has passed.") class. |
| virtual bool | [Check](class_tale_worlds_1_1_core_1_1_timer.html#a3da1eeb2f748a1ce4014e856006dc700) (float gameTime) |
|  | Checks if the required amount of time has passed or not. |
| float | [ElapsedTime](class_tale_worlds_1_1_core_1_1_timer.html#ad93407bf0450cb54c747ff8924d6611b) () |
|  | Gets the amount of time that has passed since the timer has started for the next alarm. |
| void | [Reset](class_tale_worlds_1_1_core_1_1_timer.html#ac4f187367895f31301bdedb1a56160d8) (float gameTime) |
| void | [Reset](class_tale_worlds_1_1_core_1_1_timer.html#a6b818ed8e5f4dd11e5e084df584d872c) (float gameTime, float newDuration) |
| void | [AdjustStartTime](class_tale_worlds_1_1_core_1_1_timer.html#a430b8c13b0bae6302ec63cc88d0e671b) (float deltaTime) |

|  |  |
| --- | --- |
| Properties | |
| float | [StartTime](class_tale_worlds_1_1_core_1_1_timer.html#a29c72b14de46862b6f730d648228d08f) `[get, protected set]` |
|  | The time that timer started checking for the next alarm. |
| float | [Duration](class_tale_worlds_1_1_core_1_1_timer.html#a607a2c074b913d617f3472470e0b4108) `[get, protected set]` |
|  | Duration after which the timer alarms. |
| float | [PreviousDeltaTime](class_tale_worlds_1_1_core_1_1_timer.html#af2a55889b28c2f61a855711b84642c99) `[get]` |
|  | The time elapsed before the alarm rang. |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_core_1_1_timer.html#a81913628844d02e547b6b00190ef8a70)Timer()
---------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Core.Timer.Timer | ( | float | *gameTime*, |
|  |  | float | *duration*, |
|  |  | bool | *autoReset* = true ) |

Parameters
:   |  |  |
    | --- | --- |
    | gameTime | Current time of the time type that will be used for checking. |
    | duration | Duration after which the timer alarms. |
    | autoReset | If the timer should reset after alarming or not. IMPORTANT: If true, it is impossible to check the timer multiple times in a frame (only first check will return true, and then it will reset and return false) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_timer.html#a3da1eeb2f748a1ce4014e856006dc700)Check()
---------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual bool TaleWorlds.Core.Timer.Check | ( | float | *gameTime* | ) |  | | virtual |

Parameters
:   |  |  |
    | --- | --- |
    | gameTime | Current time of the time type that is used for checking. |

Returns
:   Returns true if the required amount of time has passed.

Reimplemented in [TaleWorlds.MountAndBlade.RandomTimer](class_tale_worlds_1_1_mount_and_blade_1_1_random_timer.html#aaafa3525bb5a3446f2d2167583563cf9).

[◆](class_tale_worlds_1_1_core_1_1_timer.html#ad93407bf0450cb54c747ff8924d6611b)ElapsedTime()
---------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Core.Timer.ElapsedTime | ( |  | ) |  |

Returns
:   The amount of time that has passed since the timer has started for the next alarm.

[◆](class_tale_worlds_1_1_core_1_1_timer.html#ac4f187367895f31301bdedb1a56160d8)Reset() [1/2]
---------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.Timer.Reset | ( | float | *gameTime* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_timer.html#a6b818ed8e5f4dd11e5e084df584d872c)Reset() [2/2]
---------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.Timer.Reset | ( | float | *gameTime*, |
|  |  | float | *newDuration* ) |

[◆](class_tale_worlds_1_1_core_1_1_timer.html#a430b8c13b0bae6302ec63cc88d0e671b)AdjustStartTime()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.Timer.AdjustStartTime | ( | float | *deltaTime* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_timer.html#a29c72b14de46862b6f730d648228d08f)StartTime
-----------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.Timer.StartTime | | getprotected set |

[◆](class_tale_worlds_1_1_core_1_1_timer.html#a607a2c074b913d617f3472470e0b4108)Duration
----------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.Timer.Duration | | getprotected set |

[◆](class_tale_worlds_1_1_core_1_1_timer.html#af2a55889b28c2f61a855711b84642c99)PreviousDeltaTime
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.Timer.PreviousDeltaTime | | get |

