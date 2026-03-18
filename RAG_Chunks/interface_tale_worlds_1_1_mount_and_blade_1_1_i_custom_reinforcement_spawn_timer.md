--- SOURCE: interface_tale_worlds_1_1_mount_and_blade_1_1_i_custom_reinforcement_spawn_timer.html ---

TaleWorlds.MountAndBlade.ICustomReinforcementSpawnTimer Interface ReferenceInterface to provide a custom reinforcement timer to [MissionAgentSpawnLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html) Custom timer can be preferred if [MissionAgentSpawnLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html)'s default global timer is to be changed by the mission This supports keeping more than one timer for different battle sides.

Inherited by [TaleWorlds.MountAndBlade.SallyOutReinforcementSpawnTimer](class_tale_worlds_1_1_mount_and_blade_1_1_sally_out_reinforcement_spawn_timer.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| bool | [Check](interface_tale_worlds_1_1_mount_and_blade_1_1_i_custom_reinforcement_spawn_timer.html#a6a865cb2bf92ec2ee64c6b9fe825af6a) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| void | [ResetTimer](interface_tale_worlds_1_1_mount_and_blade_1_1_i_custom_reinforcement_spawn_timer.html#ab45ac1b3e6dcab931c901e5425786a61) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_custom_reinforcement_spawn_timer.html#a6a865cb2bf92ec2ee64c6b9fe825af6a)Check()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.ICustomReinforcementSpawnTimer.Check | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.SallyOutReinforcementSpawnTimer](class_tale_worlds_1_1_mount_and_blade_1_1_sally_out_reinforcement_spawn_timer.html#ae3c4f4b246e3bf6d0b4544a2da0adf5d).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_custom_reinforcement_spawn_timer.html#ab45ac1b3e6dcab931c901e5425786a61)ResetTimer()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ICustomReinforcementSpawnTimer.ResetTimer | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.SallyOutReinforcementSpawnTimer](class_tale_worlds_1_1_mount_and_blade_1_1_sally_out_reinforcement_spawn_timer.html#ac0264cdeb83800f6a5d01a3ed541261b).

