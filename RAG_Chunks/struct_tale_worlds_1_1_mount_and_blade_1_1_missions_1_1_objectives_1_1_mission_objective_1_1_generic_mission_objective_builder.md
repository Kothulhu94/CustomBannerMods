--- SOURCE: struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html ---

TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.GenericMissionObjectiveBuilder Struct Reference|  |  |
| --- | --- |
| Public Member Functions | |
| [GenericMissionObjectiveBuilder](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html) | [SetName](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html#accd49a2c48193f83cc038e4838ac19f5) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) name) |
| [GenericMissionObjectiveBuilder](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html) | [SetDescription](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html#a010d4f4519adaebc15b68de309d4485a) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) description) |
| [GenericMissionObjectiveBuilder](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html) | [SetObjectiveGiver](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html#a9be91494be4c5575fe92e2f7f603a7ac) ([BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) objectiveGiver) |
| [GenericMissionObjectiveBuilder](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html) | [SetInitialTargets](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html#ab6cb2198e0e83d4f5fb30051d2684674) (params [MissionObjectiveTarget](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_target.html)[] targets) |
| [GenericMissionObjectiveBuilder](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html) | [SetIsActivationRequirementsMetCallback](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html#a9a15cc1b0a83fa64b23ff378770c81b6) (Func< [MissionObjective](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a563cf0b107546a91641b009b57297006), bool > callback) |
|  | Always true if null. |
| [GenericMissionObjectiveBuilder](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html) | [SetIsCompletionRequirementsMetCallback](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html#a1ac8808d0f5f1357e0e63795d7cd7946) (Func< [MissionObjective](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a563cf0b107546a91641b009b57297006), bool > callback) |
|  | Always true if null. |
| [GenericMissionObjectiveBuilder](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html) | [SetOnStartCallback](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html#af5c27e3fa690a986a6d99312202aa909) (Action< [MissionObjective](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a563cf0b107546a91641b009b57297006) > callback) |
|  | Can be null. |
| [GenericMissionObjectiveBuilder](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html) | [SetOnCompleteCallback](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html#a5c201437b22e25636c2961f23d7d5de5) (Action< [MissionObjective](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a563cf0b107546a91641b009b57297006) > callback) |
|  | Can be null. |
| [GenericMissionObjectiveBuilder](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html) | [SetOnTickCallback](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html#a86666da64efe62546e1f9cdf9862fa1e) (Action< [MissionObjective](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a563cf0b107546a91641b009b57297006), float > callback) |
|  | Can be null. |
| [GenericMissionObjectiveBuilder](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html) | [SetProgressCallback](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html#a137e0712149ae0743005e61680d6402f) (Func< [MissionObjective](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a563cf0b107546a91641b009b57297006), [MissionObjectiveProgressInfo](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_progress_info.html) > callback) |
|  | Can be null. |
| [MissionObjective](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a563cf0b107546a91641b009b57297006) | [Build](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html#ae299f91f831424812ea4eb729b03617b) () |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html#accd49a2c48193f83cc038e4838ac19f5)SetName()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [GenericMissionObjectiveBuilder](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html) TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.GenericMissionObjectiveBuilder.SetName | ( | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *name* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html#a010d4f4519adaebc15b68de309d4485a)SetDescription()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [GenericMissionObjectiveBuilder](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html) TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.GenericMissionObjectiveBuilder.SetDescription | ( | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *description* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html#a9be91494be4c5575fe92e2f7f603a7ac)SetObjectiveGiver()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [GenericMissionObjectiveBuilder](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html) TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.GenericMissionObjectiveBuilder.SetObjectiveGiver | ( | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *objectiveGiver* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html#ab6cb2198e0e83d4f5fb30051d2684674)SetInitialTargets()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [GenericMissionObjectiveBuilder](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html) TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.GenericMissionObjectiveBuilder.SetInitialTargets | ( | params [MissionObjectiveTarget](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_target.html)[] | *targets* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html#a9a15cc1b0a83fa64b23ff378770c81b6)SetIsActivationRequirementsMetCallback()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [GenericMissionObjectiveBuilder](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html) TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.GenericMissionObjectiveBuilder.SetIsActivationRequirementsMetCallback | ( | Func< [MissionObjective](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a563cf0b107546a91641b009b57297006), bool > | *callback* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | callback |  |

Returns

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html#a1ac8808d0f5f1357e0e63795d7cd7946)SetIsCompletionRequirementsMetCallback()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [GenericMissionObjectiveBuilder](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html) TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.GenericMissionObjectiveBuilder.SetIsCompletionRequirementsMetCallback | ( | Func< [MissionObjective](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a563cf0b107546a91641b009b57297006), bool > | *callback* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | callback |  |

Returns

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html#af5c27e3fa690a986a6d99312202aa909)SetOnStartCallback()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [GenericMissionObjectiveBuilder](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html) TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.GenericMissionObjectiveBuilder.SetOnStartCallback | ( | Action< [MissionObjective](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a563cf0b107546a91641b009b57297006) > | *callback* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | callback |  |

Returns

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html#a5c201437b22e25636c2961f23d7d5de5)SetOnCompleteCallback()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [GenericMissionObjectiveBuilder](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html) TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.GenericMissionObjectiveBuilder.SetOnCompleteCallback | ( | Action< [MissionObjective](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a563cf0b107546a91641b009b57297006) > | *callback* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | callback |  |

Returns

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html#a86666da64efe62546e1f9cdf9862fa1e)SetOnTickCallback()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [GenericMissionObjectiveBuilder](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html) TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.GenericMissionObjectiveBuilder.SetOnTickCallback | ( | Action< [MissionObjective](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a563cf0b107546a91641b009b57297006), float > | *callback* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | callback |  |

Returns

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html#a137e0712149ae0743005e61680d6402f)SetProgressCallback()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [GenericMissionObjectiveBuilder](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html) TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.GenericMissionObjectiveBuilder.SetProgressCallback | ( | Func< [MissionObjective](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a563cf0b107546a91641b009b57297006), [MissionObjectiveProgressInfo](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_progress_info.html) > | *callback* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | callback |  |

Returns

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html#ae299f91f831424812ea4eb729b03617b)Build()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MissionObjective](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a563cf0b107546a91641b009b57297006) TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.GenericMissionObjectiveBuilder.Build | ( |  | ) |  |

