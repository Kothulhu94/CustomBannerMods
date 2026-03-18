--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_dividable_tasks_1_1_find_most_dangerous_threat.html ---

TaleWorlds.MountAndBlade.DividableTasks.FindMostDangerousThreat Class ReferenceInherits [TaleWorlds.MountAndBlade.DividableTask](class_tale_worlds_1_1_mount_and_blade_1_1_dividable_task.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [FindMostDangerousThreat](class_tale_worlds_1_1_mount_and_blade_1_1_dividable_tasks_1_1_find_most_dangerous_threat.html#a39fff9e6ef75d83f96358a9922572d9a) ([DividableTask](class_tale_worlds_1_1_mount_and_blade_1_1_dividable_task.html#a6af074ab20073bbd51942920c42b59c1) continueToTask=null) |
| void | [Prepare](class_tale_worlds_1_1_mount_and_blade_1_1_dividable_tasks_1_1_find_most_dangerous_threat.html#a9e104de2b6f7eecd038fde5d7a3b5123) (List< [Threat](class_tale_worlds_1_1_mount_and_blade_1_1_threat.html) > threats, [RangedSiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html) weapon) |
| [Threat](class_tale_worlds_1_1_mount_and_blade_1_1_threat.html) | [GetResult](class_tale_worlds_1_1_mount_and_blade_1_1_dividable_tasks_1_1_find_most_dangerous_threat.html#a7fc162717442b4f9b012b723fad4efaf) (out [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) targetAgent) |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.DividableTask](class_tale_worlds_1_1_mount_and_blade_1_1_dividable_task.html) | |
|  | [DividableTask](class_tale_worlds_1_1_mount_and_blade_1_1_dividable_task.html#a6af074ab20073bbd51942920c42b59c1) (DividableTask continueToTask=null) |
| void | [ResetTaskStatus](class_tale_worlds_1_1_mount_and_blade_1_1_dividable_task.html#a80c345bf94b97d1af9eeb8a766b67ddb) () |
| void | [SetTaskFinished](class_tale_worlds_1_1_mount_and_blade_1_1_dividable_task.html#a5b00a93090b125a926c08f87f0c26b39) (bool callLastAction=false) |
| bool | [Update](class_tale_worlds_1_1_mount_and_blade_1_1_dividable_task.html#a7782b46a1716d9cfb752ccd15402b3e3) () |
| void | [SetLastAction](class_tale_worlds_1_1_mount_and_blade_1_1_dividable_task.html#a30a178ce94643043226f83f76dfa25cd) (Action action) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override bool | [UpdateExtra](class_tale_worlds_1_1_mount_and_blade_1_1_dividable_tasks_1_1_find_most_dangerous_threat.html#ad7c573849701d1675492f5ee78a04df7) () |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_dividable_tasks_1_1_find_most_dangerous_threat.html#a39fff9e6ef75d83f96358a9922572d9a)FindMostDangerousThreat()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.DividableTasks.FindMostDangerousThreat.FindMostDangerousThreat | ( | [DividableTask](class_tale_worlds_1_1_mount_and_blade_1_1_dividable_task.html#a6af074ab20073bbd51942920c42b59c1) | *continueToTask* = null | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_dividable_tasks_1_1_find_most_dangerous_threat.html#ad7c573849701d1675492f5ee78a04df7)UpdateExtra()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override bool TaleWorlds.MountAndBlade.DividableTasks.FindMostDangerousThreat.UpdateExtra | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.DividableTask](class_tale_worlds_1_1_mount_and_blade_1_1_dividable_task.html#ae77470bd96e8491618bc57fcbca44f49).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_dividable_tasks_1_1_find_most_dangerous_threat.html#a9e104de2b6f7eecd038fde5d7a3b5123)Prepare()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DividableTasks.FindMostDangerousThreat.Prepare | ( | List< [Threat](class_tale_worlds_1_1_mount_and_blade_1_1_threat.html) > | *threats*, |
|  |  | [RangedSiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html) | *weapon* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_dividable_tasks_1_1_find_most_dangerous_threat.html#a7fc162717442b4f9b012b723fad4efaf)GetResult()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Threat](class_tale_worlds_1_1_mount_and_blade_1_1_threat.html) TaleWorlds.MountAndBlade.DividableTasks.FindMostDangerousThreat.GetResult | ( | out [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *targetAgent* | ) |  |

