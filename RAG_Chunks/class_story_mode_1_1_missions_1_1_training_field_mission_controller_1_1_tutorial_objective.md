--- SOURCE: class_story_mode_1_1_missions_1_1_training_field_mission_controller_1_1_tutorial_objective.html ---

StoryMode.Missions.TrainingFieldMissionController.TutorialObjective Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [TutorialObjective](class_story_mode_1_1_missions_1_1_training_field_mission_controller_1_1_tutorial_objective.html#a5d8263c6e66bdd364908a28dff4285d5) (string id, bool isFinished=false, bool isActive=false, bool hasBackground=false) |
| void | [SetTextVariableOfName](class_story_mode_1_1_missions_1_1_training_field_mission_controller_1_1_tutorial_objective.html#aaf7aa511386b17ac72d15238f95b91c8) (string tag, int variable) |
| string | [GetNameString](class_story_mode_1_1_missions_1_1_training_field_mission_controller_1_1_tutorial_objective.html#a0578194ee6e105849795a4632f9ae638) () |
| bool | [SetActive](class_story_mode_1_1_missions_1_1_training_field_mission_controller_1_1_tutorial_objective.html#a4c1b76dccfa25798b1862cac2cc31bb1) (bool isActive) |
| bool | [FinishTask](class_story_mode_1_1_missions_1_1_training_field_mission_controller_1_1_tutorial_objective.html#a33e631fdd63a9ff37a92f18ab4c5de71) () |
| void | [FinishSubTask](class_story_mode_1_1_missions_1_1_training_field_mission_controller_1_1_tutorial_objective.html#aa99c4218b3a7ba9927ae9f769acdcf93) (string subTaskName, float score) |
| bool | [SetAllSubTasksInactive](class_story_mode_1_1_missions_1_1_training_field_mission_controller_1_1_tutorial_objective.html#a8ff2bc45b88eb194aab0f13b63983a32) () |
| void | [AddSubTask](class_story_mode_1_1_missions_1_1_training_field_mission_controller_1_1_tutorial_objective.html#a2e5002dd9d3150466a045c9935d87d4a) ([TutorialObjective](class_story_mode_1_1_missions_1_1_training_field_mission_controller_1_1_tutorial_objective.html#a5d8263c6e66bdd364908a28dff4285d5) newSubTask) |
| void | [RestoreScoreFromSave](class_story_mode_1_1_missions_1_1_training_field_mission_controller_1_1_tutorial_objective.html#a8e85b315da347ddb5d28c2bb4b1324d6) (float score) |

|  |  |
| --- | --- |
| Properties | |
| string | [Id](class_story_mode_1_1_missions_1_1_training_field_mission_controller_1_1_tutorial_objective.html#ae9ce41c14fa07de68b3cadf9f79fcc74) `[get]` |
| bool | [IsFinished](class_story_mode_1_1_missions_1_1_training_field_mission_controller_1_1_tutorial_objective.html#ad1b431d505cc22d75978547587d34a4d) `[get]` |
| bool | [HasBackground](class_story_mode_1_1_missions_1_1_training_field_mission_controller_1_1_tutorial_objective.html#a1679df2a10090dfdb3ab825f69065c85) `[get]` |
| bool | [IsActive](class_story_mode_1_1_missions_1_1_training_field_mission_controller_1_1_tutorial_objective.html#a78e124b010849f0929790b9f47cfb94e) `[get]` |
| List< [TutorialObjective](class_story_mode_1_1_missions_1_1_training_field_mission_controller_1_1_tutorial_objective.html#a5d8263c6e66bdd364908a28dff4285d5) > | [SubTasks](class_story_mode_1_1_missions_1_1_training_field_mission_controller_1_1_tutorial_objective.html#a57d08459af5859b554402ede113c725c) `[get]` |
| float | [Score](class_story_mode_1_1_missions_1_1_training_field_mission_controller_1_1_tutorial_objective.html#ad7e1c739f5d93ef338add4b368317bd8) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_story_mode_1_1_missions_1_1_training_field_mission_controller_1_1_tutorial_objective.html#a5d8263c6e66bdd364908a28dff4285d5)TutorialObjective()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| StoryMode.Missions.TrainingFieldMissionController.TutorialObjective.TutorialObjective | ( | string | *id*, |
|  |  | bool | *isFinished* = false, |
|  |  | bool | *isActive* = false, |
|  |  | bool | *hasBackground* = false ) |

Member Function Documentation
-----------------------------

[◆](class_story_mode_1_1_missions_1_1_training_field_mission_controller_1_1_tutorial_objective.html#aaf7aa511386b17ac72d15238f95b91c8)SetTextVariableOfName()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void StoryMode.Missions.TrainingFieldMissionController.TutorialObjective.SetTextVariableOfName | ( | string | *tag*, |
|  |  | int | *variable* ) |

[◆](class_story_mode_1_1_missions_1_1_training_field_mission_controller_1_1_tutorial_objective.html#a0578194ee6e105849795a4632f9ae638)GetNameString()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string StoryMode.Missions.TrainingFieldMissionController.TutorialObjective.GetNameString | ( |  | ) |  |

[◆](class_story_mode_1_1_missions_1_1_training_field_mission_controller_1_1_tutorial_objective.html#a4c1b76dccfa25798b1862cac2cc31bb1)SetActive()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool StoryMode.Missions.TrainingFieldMissionController.TutorialObjective.SetActive | ( | bool | *isActive* | ) |  |

[◆](class_story_mode_1_1_missions_1_1_training_field_mission_controller_1_1_tutorial_objective.html#a33e631fdd63a9ff37a92f18ab4c5de71)FinishTask()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool StoryMode.Missions.TrainingFieldMissionController.TutorialObjective.FinishTask | ( |  | ) |  |

[◆](class_story_mode_1_1_missions_1_1_training_field_mission_controller_1_1_tutorial_objective.html#aa99c4218b3a7ba9927ae9f769acdcf93)FinishSubTask()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void StoryMode.Missions.TrainingFieldMissionController.TutorialObjective.FinishSubTask | ( | string | *subTaskName*, |
|  |  | float | *score* ) |

[◆](class_story_mode_1_1_missions_1_1_training_field_mission_controller_1_1_tutorial_objective.html#a8ff2bc45b88eb194aab0f13b63983a32)SetAllSubTasksInactive()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool StoryMode.Missions.TrainingFieldMissionController.TutorialObjective.SetAllSubTasksInactive | ( |  | ) |  |

[◆](class_story_mode_1_1_missions_1_1_training_field_mission_controller_1_1_tutorial_objective.html#a2e5002dd9d3150466a045c9935d87d4a)AddSubTask()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void StoryMode.Missions.TrainingFieldMissionController.TutorialObjective.AddSubTask | ( | [TutorialObjective](class_story_mode_1_1_missions_1_1_training_field_mission_controller_1_1_tutorial_objective.html#a5d8263c6e66bdd364908a28dff4285d5) | *newSubTask* | ) |  |

[◆](class_story_mode_1_1_missions_1_1_training_field_mission_controller_1_1_tutorial_objective.html#a8e85b315da347ddb5d28c2bb4b1324d6)RestoreScoreFromSave()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void StoryMode.Missions.TrainingFieldMissionController.TutorialObjective.RestoreScoreFromSave | ( | float | *score* | ) |  |

Property Documentation
----------------------

[◆](class_story_mode_1_1_missions_1_1_training_field_mission_controller_1_1_tutorial_objective.html#ae9ce41c14fa07de68b3cadf9f79fcc74)Id
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string StoryMode.Missions.TrainingFieldMissionController.TutorialObjective.Id | | get |

[◆](class_story_mode_1_1_missions_1_1_training_field_mission_controller_1_1_tutorial_objective.html#ad1b431d505cc22d75978547587d34a4d)IsFinished
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool StoryMode.Missions.TrainingFieldMissionController.TutorialObjective.IsFinished | | get |

[◆](class_story_mode_1_1_missions_1_1_training_field_mission_controller_1_1_tutorial_objective.html#a1679df2a10090dfdb3ab825f69065c85)HasBackground
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool StoryMode.Missions.TrainingFieldMissionController.TutorialObjective.HasBackground | | get |

[◆](class_story_mode_1_1_missions_1_1_training_field_mission_controller_1_1_tutorial_objective.html#a78e124b010849f0929790b9f47cfb94e)IsActive
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool StoryMode.Missions.TrainingFieldMissionController.TutorialObjective.IsActive | | get |

[◆](class_story_mode_1_1_missions_1_1_training_field_mission_controller_1_1_tutorial_objective.html#a57d08459af5859b554402ede113c725c)SubTasks
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[TutorialObjective](class_story_mode_1_1_missions_1_1_training_field_mission_controller_1_1_tutorial_objective.html#a5d8263c6e66bdd364908a28dff4285d5)> StoryMode.Missions.TrainingFieldMissionController.TutorialObjective.SubTasks | | get |

[◆](class_story_mode_1_1_missions_1_1_training_field_mission_controller_1_1_tutorial_objective.html#ad7e1c739f5d93ef338add4b368317bd8)Score
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float StoryMode.Missions.TrainingFieldMissionController.TutorialObjective.Score | | get |

