--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_random_timer.html ---

TaleWorlds.MountAndBlade.RandomTimer Class Reference[RandomTimer](class_tale_worlds_1_1_mount_and_blade_1_1_random_timer.html "RandomTimer class inherits Timer class and adds alarming at random times between minimum and maximum ...") class inherits Timer class and adds alarming at random times between minimum and maximum time limits.

Inherits [TaleWorlds.Core.Timer](class_tale_worlds_1_1_core_1_1_timer.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [RandomTimer](class_tale_worlds_1_1_mount_and_blade_1_1_random_timer.html#afb99f1d0fe3c3a6483d724c5e5aa3cd4) (float gameTime, float durationMin, float durationMax) |
|  | Initializes a new instance of the [RandomTimer](class_tale_worlds_1_1_mount_and_blade_1_1_random_timer.html "RandomTimer class inherits Timer class and adds alarming at random times between minimum and maximum ...") class. |
| override bool | [Check](class_tale_worlds_1_1_mount_and_blade_1_1_random_timer.html#aaafa3525bb5a3446f2d2167583563cf9) (float gameTime) |
|  | Checks if the required amount of time has passed or not. If it has passed, then the new random duration is set for the next alarm. |
| void | [ChangeDuration](class_tale_worlds_1_1_mount_and_blade_1_1_random_timer.html#a3431bc6527564f8e0a9f31d86a3433d0) (float min, float max) |
|  | Sets current min and max duration values and resets timer according to these values. This does not certainly main in next check this timer will tick. But next tick will be related to given min max values. |
| void | [RecomputeDuration](class_tale_worlds_1_1_mount_and_blade_1_1_random_timer.html#a8a718378cc8aed3bf6f90c393e3c9660) () |
|  | Resets duration value. |
| Public Member Functions inherited from [TaleWorlds.Core.Timer](class_tale_worlds_1_1_core_1_1_timer.html) | |
|  | [Timer](class_tale_worlds_1_1_core_1_1_timer.html#a81913628844d02e547b6b00190ef8a70) (float gameTime, float duration, bool autoReset=true) |
|  | Initializes a new instance of the [Timer](class_tale_worlds_1_1_core_1_1_timer.html "A timer class that alarms when given amount of time has passed.") class. |
| float | [ElapsedTime](class_tale_worlds_1_1_core_1_1_timer.html#ad93407bf0450cb54c747ff8924d6611b) () |
|  | Gets the amount of time that has passed since the timer has started for the next alarm. |
| void | [Reset](class_tale_worlds_1_1_core_1_1_timer.html#ac4f187367895f31301bdedb1a56160d8) (float gameTime) |
| void | [Reset](class_tale_worlds_1_1_core_1_1_timer.html#a6b818ed8e5f4dd11e5e084df584d872c) (float gameTime, float newDuration) |
| void | [AdjustStartTime](class_tale_worlds_1_1_core_1_1_timer.html#a430b8c13b0bae6302ec63cc88d0e671b) (float deltaTime) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.Timer](class_tale_worlds_1_1_core_1_1_timer.html) | |
| float | [StartTime](class_tale_worlds_1_1_core_1_1_timer.html#a29c72b14de46862b6f730d648228d08f) `[get, protected set]` |
|  | The time that timer started checking for the next alarm. |
| float | [Duration](class_tale_worlds_1_1_core_1_1_timer.html#a607a2c074b913d617f3472470e0b4108) `[get, protected set]` |
|  | Duration after which the timer alarms. |
| float | [PreviousDeltaTime](class_tale_worlds_1_1_core_1_1_timer.html#af2a55889b28c2f61a855711b84642c99) `[get]` |
|  | The time elapsed before the alarm rang. |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_random_timer.html#afb99f1d0fe3c3a6483d724c5e5aa3cd4)RandomTimer()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.RandomTimer.RandomTimer | ( | float | *gameTime*, |
|  |  | float | *durationMin*, |
|  |  | float | *durationMax* ) |

Parameters
:   |  |  |
    | --- | --- |
    | gameTime | Current time of the time type that will be used for checking. |
    | durationMin | Minimum duration value for random time selection. |
    | durationMax | Maximum duration value for random time selection. |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_random_timer.html#aaafa3525bb5a3446f2d2167583563cf9)Check()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override bool TaleWorlds.MountAndBlade.RandomTimer.Check | ( | float | *gameTime* | ) |  | | virtual |

Parameters
:   |  |  |
    | --- | --- |
    | gameTime | Current time of the time type that is used for checking. |

Returns
:   Returns true if the required amount of time has passed.

Reimplemented from [TaleWorlds.Core.Timer](class_tale_worlds_1_1_core_1_1_timer.html#a3da1eeb2f748a1ce4014e856006dc700).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_random_timer.html#a3431bc6527564f8e0a9f31d86a3433d0)ChangeDuration()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.RandomTimer.ChangeDuration | ( | float | *min*, |
|  |  | float | *max* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_random_timer.html#a8a718378cc8aed3bf6f90c393e3c9660)RecomputeDuration()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.RandomTimer.RecomputeDuration | ( |  | ) |  |

