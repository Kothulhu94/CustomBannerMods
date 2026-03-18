--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_agent_proximity_map.html ---

TaleWorlds.MountAndBlade.AgentProximityMap Class Reference|  |  |
| --- | --- |
| Classes | |
| struct | [ProximityMapSearchStruct](struct_tale_worlds_1_1_mount_and_blade_1_1_agent_proximity_map_1_1_proximity_map_search_struct.html) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static bool | [CanSearchRadius](class_tale_worlds_1_1_mount_and_blade_1_1_agent_proximity_map.html#ac6cf3f37bc5708c4a87195ab4421fa50) (float searchRadius) |
| static [ProximityMapSearchStruct](struct_tale_worlds_1_1_mount_and_blade_1_1_agent_proximity_map_1_1_proximity_map_search_struct.html) | [BeginSearch](class_tale_worlds_1_1_mount_and_blade_1_1_agent_proximity_map.html#a9fc95cda7a839b1ee6c55c97945ab049) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) searchPos, float searchRadius, bool extendRangeByBiggestAgentCollisionPadding=false) |
| static void | [FindNext](class_tale_worlds_1_1_mount_and_blade_1_1_agent_proximity_map.html#a93108b296709969313645e715525f853) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission, ref [ProximityMapSearchStruct](struct_tale_worlds_1_1_mount_and_blade_1_1_agent_proximity_map_1_1_proximity_map_search_struct.html) searchStruct) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_proximity_map.html#ac6cf3f37bc5708c4a87195ab4421fa50)CanSearchRadius()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.AgentProximityMap.CanSearchRadius | ( | float | *searchRadius* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_proximity_map.html#a9fc95cda7a839b1ee6c55c97945ab049)BeginSearch()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ProximityMapSearchStruct](struct_tale_worlds_1_1_mount_and_blade_1_1_agent_proximity_map_1_1_proximity_map_search_struct.html) TaleWorlds.MountAndBlade.AgentProximityMap.BeginSearch | ( | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | *mission*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *searchPos*, | |  |  | float | *searchRadius*, | |  |  | bool | *extendRangeByBiggestAgentCollisionPadding* = false ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_proximity_map.html#a93108b296709969313645e715525f853)FindNext()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.AgentProximityMap.FindNext | ( | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | *mission*, | |  |  | ref [ProximityMapSearchStruct](struct_tale_worlds_1_1_mount_and_blade_1_1_agent_proximity_map_1_1_proximity_map_search_struct.html) | *searchStruct* ) | | static |

