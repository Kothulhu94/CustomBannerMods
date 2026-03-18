--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_mission_time_tracker.html ---

TaleWorlds.MountAndBlade.MissionTimeTracker Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MissionTimeTracker](class_tale_worlds_1_1_mount_and_blade_1_1_mission_time_tracker.html#a3e7b7641d628b91d97193733c1aa15d9) ([MissionTime](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_time.html) initialMapTime) |
|  | [MissionTimeTracker](class_tale_worlds_1_1_mount_and_blade_1_1_mission_time_tracker.html#abfe39d6ce919ff5ce280a7e1f8cde7d4) () |
| void | [Tick](class_tale_worlds_1_1_mount_and_blade_1_1_mission_time_tracker.html#ac6720e2d50618d8b51b7cee27d174c17) (float seconds) |
| void | [UpdateSync](class_tale_worlds_1_1_mount_and_blade_1_1_mission_time_tracker.html#aa03e7c0f396843877ff3f2b5402f41cb) (float newValue) |
|  | Only clients should be using this. |
| float | [GetLastSyncDifference](class_tale_worlds_1_1_mount_and_blade_1_1_mission_time_tracker.html#a0e3a114b928d34d2b893b1b273bc0f87) () |
|  | Only clients should be using this. |

|  |  |
| --- | --- |
| Properties | |
| long | [NumberOfTicks](class_tale_worlds_1_1_mount_and_blade_1_1_mission_time_tracker.html#ae13426431ac7dfcbd1683a9599814c74) `[get]` |
| long | [DeltaTimeInTicks](class_tale_worlds_1_1_mount_and_blade_1_1_mission_time_tracker.html#a1f73584b98982811c717d159f625393d) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_time_tracker.html#a3e7b7641d628b91d97193733c1aa15d9)MissionTimeTracker() [1/2]
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.MissionTimeTracker.MissionTimeTracker | ( | [MissionTime](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_time.html) | *initialMapTime* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_time_tracker.html#abfe39d6ce919ff5ce280a7e1f8cde7d4)MissionTimeTracker() [2/2]
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.MissionTimeTracker.MissionTimeTracker | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_time_tracker.html#ac6720e2d50618d8b51b7cee27d174c17)Tick()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionTimeTracker.Tick | ( | float | *seconds* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_time_tracker.html#aa03e7c0f396843877ff3f2b5402f41cb)UpdateSync()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionTimeTracker.UpdateSync | ( | float | *newValue* | ) |  |

Returns

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_time_tracker.html#a0e3a114b928d34d2b893b1b273bc0f87)GetLastSyncDifference()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.MissionTimeTracker.GetLastSyncDifference | ( |  | ) |  |

Returns

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_time_tracker.html#ae13426431ac7dfcbd1683a9599814c74)NumberOfTicks
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | long TaleWorlds.MountAndBlade.MissionTimeTracker.NumberOfTicks | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_time_tracker.html#a1f73584b98982811c717d159f625393d)DeltaTimeInTicks
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | long TaleWorlds.MountAndBlade.MissionTimeTracker.DeltaTimeInTicks | | get |

