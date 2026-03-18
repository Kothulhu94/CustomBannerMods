--- SOURCE: class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_score_pair.html ---

SandBox.Missions.MissionLogics.MissionPathGenerationLogic.PointOfInterestScorePair Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [PointOfInterestScorePair](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_score_pair.html#ab4ed46f0689efc94cd557d690b68f90e) ([NavigationPathData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_navigation_path_data.html) pathData, List< [PointOfInterestBaseData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html) > data, float score) |
| [PointOfInterestScorePair](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_score_pair.html#ab4ed46f0689efc94cd557d690b68f90e) | [Clone](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_score_pair.html#a42373efe93a6c018caa08c0b2bd2d789) () |
| void | [AddToData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_score_pair.html#a776718aa864aa12a6a77ce064ad92524) ([PointOfInterestBaseData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html) pointOfInterestToAdd) |
| bool | [IsDataEqualTo](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_score_pair.html#afa743c15d6a0b894309c83118e2cf7c6) ([PointOfInterestScorePair](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_score_pair.html#ab4ed46f0689efc94cd557d690b68f90e) other, [PointOfInterestBaseData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html) newDataToAdd) |
| bool | [IsBetterThan](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_score_pair.html#a78e712ff779557d4780358d80e78f277) ([PointOfInterestScorePair](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_score_pair.html#ab4ed46f0689efc94cd557d690b68f90e) other) |
| bool | [IsSufficient](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_score_pair.html#a502c3428ace1177bda13463be7ddfda4) () |
| void | [ReOrderDataAccordingToPathRatios](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_score_pair.html#a450027e5f21d7d2ebf596f4d86016377) () |

|  |  |
| --- | --- |
| Public Attributes | |
| [NavigationPathData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_navigation_path_data.html) | [PathData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_score_pair.html#aadec15ee738838428e014ce3b3a6fe5f) |
| Dictionary< [PointOfInterests](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a843e89bb9ec59f2f496028dd6b4ef921), int > | [PointOfInterestCount](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_score_pair.html#ab923ec86a9bfe3496d108505d6b7a648) |
| float | [Score](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_score_pair.html#a82c79883672ac232978bdf836f6328b8) |

|  |  |
| --- | --- |
| Properties | |
| List< [PointOfInterestBaseData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html) > | [Data](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_score_pair.html#aed555b910c3204e91d3ce609dc7a56cd) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_score_pair.html#ab4ed46f0689efc94cd557d690b68f90e)PointOfInterestScorePair()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| SandBox.Missions.MissionLogics.MissionPathGenerationLogic.PointOfInterestScorePair.PointOfInterestScorePair | ( | [NavigationPathData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_navigation_path_data.html) | *pathData*, |
|  |  | List< [PointOfInterestBaseData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html) > | *data*, |
|  |  | float | *score* ) |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_score_pair.html#a42373efe93a6c018caa08c0b2bd2d789)Clone()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [PointOfInterestScorePair](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_score_pair.html#ab4ed46f0689efc94cd557d690b68f90e) SandBox.Missions.MissionLogics.MissionPathGenerationLogic.PointOfInterestScorePair.Clone | ( |  | ) |  |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_score_pair.html#a776718aa864aa12a6a77ce064ad92524)AddToData()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.Missions.MissionLogics.MissionPathGenerationLogic.PointOfInterestScorePair.AddToData | ( | [PointOfInterestBaseData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html) | *pointOfInterestToAdd* | ) |  |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_score_pair.html#afa743c15d6a0b894309c83118e2cf7c6)IsDataEqualTo()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool SandBox.Missions.MissionLogics.MissionPathGenerationLogic.PointOfInterestScorePair.IsDataEqualTo | ( | [PointOfInterestScorePair](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_score_pair.html#ab4ed46f0689efc94cd557d690b68f90e) | *other*, |
|  |  | [PointOfInterestBaseData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html) | *newDataToAdd* ) |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_score_pair.html#a78e712ff779557d4780358d80e78f277)IsBetterThan()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool SandBox.Missions.MissionLogics.MissionPathGenerationLogic.PointOfInterestScorePair.IsBetterThan | ( | [PointOfInterestScorePair](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_score_pair.html#ab4ed46f0689efc94cd557d690b68f90e) | *other* | ) |  |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_score_pair.html#a502c3428ace1177bda13463be7ddfda4)IsSufficient()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool SandBox.Missions.MissionLogics.MissionPathGenerationLogic.PointOfInterestScorePair.IsSufficient | ( |  | ) |  |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_score_pair.html#a450027e5f21d7d2ebf596f4d86016377)ReOrderDataAccordingToPathRatios()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.Missions.MissionLogics.MissionPathGenerationLogic.PointOfInterestScorePair.ReOrderDataAccordingToPathRatios | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_score_pair.html#aadec15ee738838428e014ce3b3a6fe5f)PathData
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [NavigationPathData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_navigation_path_data.html) SandBox.Missions.MissionLogics.MissionPathGenerationLogic.PointOfInterestScorePair.PathData |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_score_pair.html#ab923ec86a9bfe3496d108505d6b7a648)PointOfInterestCount
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Dictionary<[PointOfInterests](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a843e89bb9ec59f2f496028dd6b4ef921), int> SandBox.Missions.MissionLogics.MissionPathGenerationLogic.PointOfInterestScorePair.PointOfInterestCount |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_score_pair.html#a82c79883672ac232978bdf836f6328b8)Score
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float SandBox.Missions.MissionLogics.MissionPathGenerationLogic.PointOfInterestScorePair.Score |

Property Documentation
----------------------

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_score_pair.html#aed555b910c3204e91d3ce609dc7a56cd)Data
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[PointOfInterestBaseData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html)> SandBox.Missions.MissionLogics.MissionPathGenerationLogic.PointOfInterestScorePair.Data | | get |

