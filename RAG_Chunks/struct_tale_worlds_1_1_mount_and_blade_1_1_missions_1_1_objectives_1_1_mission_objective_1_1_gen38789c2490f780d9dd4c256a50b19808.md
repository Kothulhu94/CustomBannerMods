--- SOURCE: struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_gen38789c2490f780d9dd4c256a50b19808.html ---

TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.GenericMissionObjectiveTargetBuilder< T > Struct Template Reference|  |  |
| --- | --- |
| Public Member Functions | |
| GenericMissionObjectiveTargetBuilder< T > | [SetIsActiveCallback](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_gen38789c2490f780d9dd4c256a50b19808.html#a0d489fc6f7f886441ee7cdd6beb50e7e) (Func< T, bool > callback) |
|  | Always true if null. |
| GenericMissionObjectiveTargetBuilder< T > | [SetGetGlobalPositionCallback](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_gen38789c2490f780d9dd4c256a50b19808.html#a2c2f7ca1ab0cad8ccd0c053979f16054) (Func< T, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) > callback) |
|  | Callback is preferred over static position. |
| GenericMissionObjectiveTargetBuilder< T > | [SetGetNameCallback](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_gen38789c2490f780d9dd4c256a50b19808.html#a19776ff115748609c8729d4974730d38) (Func< T, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > callback) |
|  | Callback is preferred over initial name. |
| [MissionObjectiveTarget](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_target.html)< T > | [Build](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_gen38789c2490f780d9dd4c256a50b19808.html#af11edc221300ea1b730cc89fb2cb9d92) () |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_gen38789c2490f780d9dd4c256a50b19808.html#a0d489fc6f7f886441ee7cdd6beb50e7e)SetIsActiveCallback()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| GenericMissionObjectiveTargetBuilder< T > TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.GenericMissionObjectiveTargetBuilder< T >.SetIsActiveCallback | ( | Func< T, bool > | *callback* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | callback |  |

Returns

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_gen38789c2490f780d9dd4c256a50b19808.html#a2c2f7ca1ab0cad8ccd0c053979f16054)SetGetGlobalPositionCallback()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| GenericMissionObjectiveTargetBuilder< T > TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.GenericMissionObjectiveTargetBuilder< T >.SetGetGlobalPositionCallback | ( | Func< T, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) > | *callback* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | callback |  |

Returns

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_gen38789c2490f780d9dd4c256a50b19808.html#a19776ff115748609c8729d4974730d38)SetGetNameCallback()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| GenericMissionObjectiveTargetBuilder< T > TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.GenericMissionObjectiveTargetBuilder< T >.SetGetNameCallback | ( | Func< T, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > | *callback* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | callback |  |

Returns

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_gen38789c2490f780d9dd4c256a50b19808.html#af11edc221300ea1b730cc89fb2cb9d92)Build()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MissionObjectiveTarget](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_target.html)< T > TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.GenericMissionObjectiveTargetBuilder< T >.Build | ( |  | ) |  |

