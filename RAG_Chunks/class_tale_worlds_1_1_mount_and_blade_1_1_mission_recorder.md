--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_mission_recorder.html ---

TaleWorlds.MountAndBlade.MissionRecorder Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MissionRecorder](class_tale_worlds_1_1_mount_and_blade_1_1_mission_recorder.html#a10d2c275b6fa63ae2b3f97a5a2eabcca) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission) |
| void | [RestartRecord](class_tale_worlds_1_1_mount_and_blade_1_1_mission_recorder.html#a49283c6ac362ed7e9aac02208e4e9631) () |
| void | [ProcessRecordUntilTime](class_tale_worlds_1_1_mount_and_blade_1_1_mission_recorder.html#a612ec18db4ba6e7888145d972a2a924e) (float time) |
| bool | [IsEndOfRecord](class_tale_worlds_1_1_mount_and_blade_1_1_mission_recorder.html#adcee3d107e2992d7b5450f640556657f) () |
| void | [StartRecording](class_tale_worlds_1_1_mount_and_blade_1_1_mission_recorder.html#a7b7f48c8396fb355455c9a0ed54ca67f) () |
| void | [RecordCurrentState](class_tale_worlds_1_1_mount_and_blade_1_1_mission_recorder.html#abac41fb19a56a2744aba3017821286bf) () |
| void | [BackupRecordToFile](class_tale_worlds_1_1_mount_and_blade_1_1_mission_recorder.html#a4cf3e36fe52d7f11fe4125e1e4f0563e) (string fileName, string gameType, string sceneLevels) |
| void | [RestoreRecordFromFile](class_tale_worlds_1_1_mount_and_blade_1_1_mission_recorder.html#a61fc667338cbedba256e558ff202ba53) (string fileName) |
| void | [ClearRecordBuffers](class_tale_worlds_1_1_mount_and_blade_1_1_mission_recorder.html#a070bbbe357d57c63f440c029da144861) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static string | [GetSceneNameForReplay](class_tale_worlds_1_1_mount_and_blade_1_1_mission_recorder.html#aa7bd10dcdc63d4348ca4aa76c3f2f22b) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) fileName) |
| static string | [GetGameTypeForReplay](class_tale_worlds_1_1_mount_and_blade_1_1_mission_recorder.html#ac279a50fc4505aa697d9406796f970dc) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) fileName) |
| static string | [GetSceneLevelsForReplay](class_tale_worlds_1_1_mount_and_blade_1_1_mission_recorder.html#aaa7a011ca3d4b87236efac791eb0fc5b) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) fileName) |
| static string | [GetAtmosphereNameForReplay](class_tale_worlds_1_1_mount_and_blade_1_1_mission_recorder.html#ada1666c757e00322de870be4a7e552d7) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) fileName) |
| static int | [GetAtmosphereSeasonForReplay](class_tale_worlds_1_1_mount_and_blade_1_1_mission_recorder.html#aec5b499264c815d902ad874175063660) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) fileName) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_recorder.html#a10d2c275b6fa63ae2b3f97a5a2eabcca)MissionRecorder()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.MissionRecorder.MissionRecorder | ( | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | *mission* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_recorder.html#a49283c6ac362ed7e9aac02208e4e9631)RestartRecord()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionRecorder.RestartRecord | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_recorder.html#a612ec18db4ba6e7888145d972a2a924e)ProcessRecordUntilTime()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionRecorder.ProcessRecordUntilTime | ( | float | *time* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_recorder.html#adcee3d107e2992d7b5450f640556657f)IsEndOfRecord()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MissionRecorder.IsEndOfRecord | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_recorder.html#a7b7f48c8396fb355455c9a0ed54ca67f)StartRecording()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionRecorder.StartRecording | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_recorder.html#abac41fb19a56a2744aba3017821286bf)RecordCurrentState()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionRecorder.RecordCurrentState | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_recorder.html#a4cf3e36fe52d7f11fe4125e1e4f0563e)BackupRecordToFile()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionRecorder.BackupRecordToFile | ( | string | *fileName*, |
|  |  | string | *gameType*, |
|  |  | string | *sceneLevels* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_recorder.html#a61fc667338cbedba256e558ff202ba53)RestoreRecordFromFile()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionRecorder.RestoreRecordFromFile | ( | string | *fileName* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_recorder.html#a070bbbe357d57c63f440c029da144861)ClearRecordBuffers()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionRecorder.ClearRecordBuffers | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_recorder.html#aa7bd10dcdc63d4348ca4aa76c3f2f22b)GetSceneNameForReplay()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.MissionRecorder.GetSceneNameForReplay | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *fileName* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_recorder.html#ac279a50fc4505aa697d9406796f970dc)GetGameTypeForReplay()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.MissionRecorder.GetGameTypeForReplay | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *fileName* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_recorder.html#aaa7a011ca3d4b87236efac791eb0fc5b)GetSceneLevelsForReplay()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.MissionRecorder.GetSceneLevelsForReplay | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *fileName* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_recorder.html#ada1666c757e00322de870be4a7e552d7)GetAtmosphereNameForReplay()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.MissionRecorder.GetAtmosphereNameForReplay | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *fileName* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_recorder.html#aec5b499264c815d902ad874175063660)GetAtmosphereSeasonForReplay()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.MissionRecorder.GetAtmosphereSeasonForReplay | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *fileName* | ) |  | | static |

