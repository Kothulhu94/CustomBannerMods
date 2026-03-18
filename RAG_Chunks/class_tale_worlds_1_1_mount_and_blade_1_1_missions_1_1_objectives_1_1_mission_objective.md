--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html ---

TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective Class Referenceabstract|  |  |
| --- | --- |
| Classes | |
| struct | [GenericMissionObjectiveBuilder](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html) |
| struct | [GenericMissionObjectiveTargetBuilder< T >](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_gen38789c2490f780d9dd4c256a50b19808.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MissionObjective](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a563cf0b107546a91641b009b57297006) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a0a1e038618579372672355f8f5262a22) mission) |
| virtual [MissionObjectiveProgressInfo](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_progress_info.html) | [GetCurrentProgress](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#ad3719dd067356acb8da87a2592d684ea) () |
| void | [SetObjectiveGiver](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a8307150c731454117b8b547e859ca1a5) ([BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) objectiveGiver) |
| void | [AddTarget](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a8a91285040602c22d9ebf66e0265c8ba) ([MissionObjectiveTarget](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_target.html) target) |
| void | [RemoveTarget](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a69c87350ea7cf1a87793d6e3238ba3fa) ([MissionObjectiveTarget](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_target.html) target) |
| void | [ClearTargets](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#ae71caf9db29ac55ec88765f9c5577beb) () |
| MBReadOnlyList< [MissionObjectiveTarget](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_target.html) > | [GetTargetsCopy](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#aa798f09d956dae0769e89ccf27ff116d) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [GenericMissionObjectiveBuilder](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html) | [CreateGenericObjectiveBuilder](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#ab65092d4e533d8006f11e45ee06c8985) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a0a1e038618579372672355f8f5262a22) mission, string id, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) name=null, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) description=null) |
| static GenericMissionObjectiveTargetBuilder< T > | [CreateGenericTargetBuilder< T >](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#ac4fd8d77b18bc99b5ab1a0461dff56b4) (T target, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) name, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) staticPosition) |
| static GenericMissionObjectiveTargetBuilder< T > | [CreateGenericTargetBuilder< T >](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#ab5d700ca4d00ca6efd13e76ca124a226) (T target) |
| static GenericMissionObjectiveTargetBuilder< T > | [CreateGenericTargetBuilder< T >](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#abcc93c2998ca954840168fc9e13af8ac) (T target, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) name) |
| static GenericMissionObjectiveTargetBuilder< T > | [CreateGenericTargetBuilder< T >](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a9db393f08e1374922655546f4a9a513f) (T target, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) staticPosition) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| MBReadOnlyList< TTarget > | [GetTargetsCopy< TTarget >](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a5353c7f0587d7c901dc30507cd6bb8ee) () |
| virtual bool | [IsActivationRequirementsMet](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a3ec22dd702b83221cb4e9b6b875b9c40) () |
| virtual bool | [IsCompletionRequirementsMet](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a509cd93d151489ca9bbe633f42f6e62e) () |
| virtual void | [OnStart](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a5e28ffded3537176c8bff4df81028681) () |
| virtual void | [OnComplete](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a64840ffa27447f7aca3efcda1a55a255) () |
| virtual void | [OnTick](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#af446c78f6e001f8e4d71bbf9ce46d888) (float dt) |
| virtual void | [OnTargetAdded](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a8fce940fdfa7a837681dcc6a21381a39) ([MissionObjectiveTarget](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_target.html) target) |
| virtual void | [OnTargetRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#ae87f6bdc9f0a35ff01c232c914699421) ([MissionObjectiveTarget](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_target.html) target) |
| virtual void | [OnTargetsCleared](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#af5846737e7e3010040632d31f1c08f21) () |

|  |  |
| --- | --- |
| Properties | |
| string | [UniqueId](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a8684b6a4f29b2fb14f677b381849fe98) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a14c3650bc08c70c255443f4698937418) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Description](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#aa80b8049dfff486daea32ad5ed7a4ce8) `[get]` |
| bool | [IsActive](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a12742cc55c8f3cd30262c8caa53dcf6e) `[get]` |
| bool | [IsStarted](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a818bd739fee18dd76bccebb6ce0e5152) `[get]` |
| bool | [IsCompleted](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#ac2965f6ae8d519ce6fdfa080a7486418) `[get]` |
| Mission | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a0a1e038618579372672355f8f5262a22) `[get]` |
| [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | [ObjectiveGiver](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a9d7da5ec3e089f8c5b22b877aad1ca74) `[get]` |

|  |  |
| --- | --- |
| Events | |
| Action | [OnUpdated](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#aab3b8faf472f98f2256e8ec59f026e7a) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a563cf0b107546a91641b009b57297006)MissionObjective()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.MissionObjective | ( | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a0a1e038618579372672355f8f5262a22) | *mission* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#ad3719dd067356acb8da87a2592d684ea)GetCurrentProgress()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual [MissionObjectiveProgressInfo](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_progress_info.html) TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.GetCurrentProgress | ( |  | ) |  | | virtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a8307150c731454117b8b547e859ca1a5)SetObjectiveGiver()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.SetObjectiveGiver | ( | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *objectiveGiver* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a8a91285040602c22d9ebf66e0265c8ba)AddTarget()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.AddTarget | ( | [MissionObjectiveTarget](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_target.html) | *target* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a69c87350ea7cf1a87793d6e3238ba3fa)RemoveTarget()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.RemoveTarget | ( | [MissionObjectiveTarget](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_target.html) | *target* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#ae71caf9db29ac55ec88765f9c5577beb)ClearTargets()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.ClearTargets | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#aa798f09d956dae0769e89ccf27ff116d)GetTargetsCopy()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| MBReadOnlyList< [MissionObjectiveTarget](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_target.html) > TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.GetTargetsCopy | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a5353c7f0587d7c901dc30507cd6bb8ee)GetTargetsCopy< TTarget >()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | MBReadOnlyList< TTarget > [TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.GetTargetsCopy](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#aa798f09d956dae0769e89ccf27ff116d)< TTarget > | ( |  | ) |  | | protected |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *TTarget* | : | *[MissionObjectiveTarget](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_target.html)* |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a3ec22dd702b83221cb4e9b6b875b9c40)IsActivationRequirementsMet()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual bool TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.IsActivationRequirementsMet | ( |  | ) |  | | protectedvirtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a509cd93d151489ca9bbe633f42f6e62e)IsCompletionRequirementsMet()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual bool TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.IsCompletionRequirementsMet | ( |  | ) |  | | protectedvirtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a5e28ffded3537176c8bff4df81028681)OnStart()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.OnStart | ( |  | ) |  | | protectedvirtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a64840ffa27447f7aca3efcda1a55a255)OnComplete()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.OnComplete | ( |  | ) |  | | protectedvirtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#af446c78f6e001f8e4d71bbf9ce46d888)OnTick()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.OnTick | ( | float | *dt* | ) |  | | protectedvirtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a8fce940fdfa7a837681dcc6a21381a39)OnTargetAdded()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.OnTargetAdded | ( | [MissionObjectiveTarget](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_target.html) | *target* | ) |  | | protectedvirtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#ae87f6bdc9f0a35ff01c232c914699421)OnTargetRemoved()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.OnTargetRemoved | ( | [MissionObjectiveTarget](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_target.html) | *target* | ) |  | | protectedvirtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#af5846737e7e3010040632d31f1c08f21)OnTargetsCleared()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.OnTargetsCleared | ( |  | ) |  | | protectedvirtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#ab65092d4e533d8006f11e45ee06c8985)CreateGenericObjectiveBuilder()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [GenericMissionObjectiveBuilder](struct_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective_1_1_generic_mission_objective_builder.html) TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.CreateGenericObjectiveBuilder | ( | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a0a1e038618579372672355f8f5262a22) | *mission*, | |  |  | string | *id*, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *name* = null, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *description* = null ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#ac4fd8d77b18bc99b5ab1a0461dff56b4)CreateGenericTargetBuilder< T >() [1/4]
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | GenericMissionObjectiveTargetBuilder< T > TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.CreateGenericTargetBuilder< T > | ( | T | *target*, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *name*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *staticPosition* ) | | static |

Template Parameters
:   |  |  |
    | --- | --- |
    | T |  |

Parameters
:   |  |  |
    | --- | --- |
    | target | Can be null. |
    | name | Name should be set if there is no name getter callback |
    | staticPosition | Static position should be set if there is no position getter callback |

Returns

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#ab5d700ca4d00ca6efd13e76ca124a226)CreateGenericTargetBuilder< T >() [2/4]
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | GenericMissionObjectiveTargetBuilder< T > TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.CreateGenericTargetBuilder< T > | ( | T | *target* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#abcc93c2998ca954840168fc9e13af8ac)CreateGenericTargetBuilder< T >() [3/4]
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | GenericMissionObjectiveTargetBuilder< T > TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.CreateGenericTargetBuilder< T > | ( | T | *target*, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *name* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a9db393f08e1374922655546f4a9a513f)CreateGenericTargetBuilder< T >() [4/4]
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | GenericMissionObjectiveTargetBuilder< T > TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.CreateGenericTargetBuilder< T > | ( | T | *target*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *staticPosition* ) | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a8684b6a4f29b2fb14f677b381849fe98)UniqueId
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.UniqueId | | getabstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a14c3650bc08c70c255443f4698937418)Name
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.Name | | getabstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#aa80b8049dfff486daea32ad5ed7a4ce8)Description
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.Description | | getabstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a12742cc55c8f3cd30262c8caa53dcf6e)IsActive
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.IsActive | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a818bd739fee18dd76bccebb6ce0e5152)IsStarted
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.IsStarted | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#ac2965f6ae8d519ce6fdfa080a7486418)IsCompleted
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.IsCompleted | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a0a1e038618579372672355f8f5262a22)Mission
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Mission TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.Mission | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#a9d7da5ec3e089f8c5b22b877aad1ca74)ObjectiveGiver
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.ObjectiveGiver | | get |

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives_1_1_mission_objective.html#aab3b8faf472f98f2256e8ec59f026e7a)OnUpdated
--------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action TaleWorlds.MountAndBlade.Missions.Objectives.MissionObjective.OnUpdated |

