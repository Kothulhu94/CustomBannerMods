--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_mission_timer.html ---

TaleWorlds.MountAndBlade.MissionTimer Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MissionTimer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_timer.html#ae66bfca5d235b3120cb908c549da60f3) (float duration) |
| [MissionTime](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_time.html) | [GetStartTime](class_tale_worlds_1_1_mount_and_blade_1_1_mission_timer.html#a28f33fd49d394280b21fd1ef04309c17) () |
| float | [GetTimerDuration](class_tale_worlds_1_1_mount_and_blade_1_1_mission_timer.html#a1bbb1c259fb614c94420a27af800dc44) () |
| float | [GetRemainingTimeInSeconds](class_tale_worlds_1_1_mount_and_blade_1_1_mission_timer.html#acc26e12a68035d3e90fe629ce8f3b345) (bool synched=false) |
| bool | [Check](class_tale_worlds_1_1_mount_and_blade_1_1_mission_timer.html#a5ae1be2f3f9528de4c4aa095b1c32702) (bool reset=false) |
| void | [Reset](class_tale_worlds_1_1_mount_and_blade_1_1_mission_timer.html#a2217672343db79984474f75538a74114) () |
| void | [Set](class_tale_worlds_1_1_mount_and_blade_1_1_mission_timer.html#a014031e91224d523ba6caf0f5873a5af) (float timeInSeconds) |
| void | [SetDuration](class_tale_worlds_1_1_mount_and_blade_1_1_mission_timer.html#ab242b5a33deb9c38e6e7a00e5feb0721) (float duration) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static MissionTimer | [CreateSynchedTimerClient](class_tale_worlds_1_1_mount_and_blade_1_1_mission_timer.html#affc676617a6795a3c94397cbc4a08761) (float startTimeInSeconds, float duration) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_timer.html#ae66bfca5d235b3120cb908c549da60f3)MissionTimer()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.MissionTimer.MissionTimer | ( | float | *duration* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_timer.html#a28f33fd49d394280b21fd1ef04309c17)GetStartTime()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MissionTime](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_time.html) TaleWorlds.MountAndBlade.MissionTimer.GetStartTime | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_timer.html#a1bbb1c259fb614c94420a27af800dc44)GetTimerDuration()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.MissionTimer.GetTimerDuration | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_timer.html#acc26e12a68035d3e90fe629ce8f3b345)GetRemainingTimeInSeconds()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.MissionTimer.GetRemainingTimeInSeconds | ( | bool | *synched* = false | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_timer.html#a5ae1be2f3f9528de4c4aa095b1c32702)Check()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MissionTimer.Check | ( | bool | *reset* = false | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_timer.html#a2217672343db79984474f75538a74114)Reset()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionTimer.Reset | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_timer.html#a014031e91224d523ba6caf0f5873a5af)Set()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionTimer.Set | ( | float | *timeInSeconds* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_timer.html#ab242b5a33deb9c38e6e7a00e5feb0721)SetDuration()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionTimer.SetDuration | ( | float | *duration* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_timer.html#affc676617a6795a3c94397cbc4a08761)CreateSynchedTimerClient()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | MissionTimer TaleWorlds.MountAndBlade.MissionTimer.CreateSynchedTimerClient | ( | float | *startTimeInSeconds*, | |  |  | float | *duration* ) | | static |

