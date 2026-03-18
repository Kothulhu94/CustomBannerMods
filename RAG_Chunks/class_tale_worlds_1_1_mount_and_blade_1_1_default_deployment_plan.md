--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html ---

TaleWorlds.MountAndBlade.DefaultDeploymentPlan Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
| void | [SetSpawnWithHorses](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a8a695200f273dd0288f2fd772b77514f) (bool value) |
| void | [ClearAddedTroops](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a81a8af952717aa001a13cf38263b184b) () |
| void | [ClearPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a62aebc4979dc3e3f1d2385f7bf40d634) () |
| void | [AddTroops](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a9e4b670c07ec2467b35d6fcee18efa5b) ([FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) formationClass, int footTroopCount, int mountedTroopCount) |
| void | [PlanBattleDeployment](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a4327732bab755d6060349d7a48485ac9) ([FormationSceneSpawnEntry](struct_tale_worlds_1_1_mount_and_blade_1_1_formation_scene_spawn_entry.html)[,] formationSceneSpawnEntries, [float](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a5d3f2fceedc2eb678fc82298e7dedbc0) spawnPathOffset=0f, [float](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a5d3f2fceedc2eb678fc82298e7dedbc0) targetOffset=0f) |
| [DefaultFormationDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html) | [GetFormationPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#aa9894a6b13b22de45e23a49c68a8eaf9) ([FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) fClass) |
| bool | [GetFormationDeploymentFrame](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a8292af5326ad3c5e5300bee85869078f) ([FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) fClass, out [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame) |
| bool | [IsPlanSuitableForFormations](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a51e3f7c94e4a04f85aa631b2fabc2a2f) (ValueTuple< int, int >[] troopDataPerFormationClass) |
| void | [UpdateSafetyScore](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a123159837b4ce5f55c47fe59ded1b22a) () |
| [WorldFrame](struct_tale_worlds_1_1_engine_1_1_world_frame.html) | [GetFrameFromFormationSpawnEntity](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#ad9be6d4f04d630b0286110778efb4b15) ([GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) formationSpawnEntity, [float](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a5d3f2fceedc2eb678fc82298e7dedbc0) depthOffset=0f) |
| [float](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a5d3f2fceedc2eb678fc82298e7dedbc0) | [GetFormationSpawnWidthAndDepth](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a37e2a52792cf50cf06c36c2c66e64feb) ([FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) formationNo, int troopCount, bool hasMountedTroops, bool considerCavalryAsInfantry=false) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static DefaultDeploymentPlan | [CreateInitialPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a421c32218d4811b9392f2e1a09a187e9) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission, [Team](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#aaed869ff10c0405955e09505656a5207) team) |
| static DefaultDeploymentPlan | [CreateReinforcementPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#ac8ee55bc86fe62c2d515370c6d31ba49) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission, [Team](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#aaed869ff10c0405955e09505656a5207) team) |
| static DefaultDeploymentPlan | [CreateReinforcementPlanWithSpawnPath](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a73cf47de6919ac6617658ca9865b4d92) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission, [Team](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#aaed869ff10c0405955e09505656a5207) team, [SpawnPathData](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a40a0ae5cb0c4e5b7d277af98b4a65eba) spawnPathData) |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly Team | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#aaed869ff10c0405955e09505656a5207) |
| readonly bool | [IsReinforcement](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#aadc48922ffe87866690c612696d6899b) |
| readonly SpawnPathData | [SpawnPathData](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a40a0ae5cb0c4e5b7d277af98b4a65eba) |
|  | [float](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a5d3f2fceedc2eb678fc82298e7dedbc0) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const [float](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a5d3f2fceedc2eb678fc82298e7dedbc0) | [VerticalFormationGap](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a90a1a53543b1a9fb4f12ac3561be6b8f) = 3f |
| const [float](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a5d3f2fceedc2eb678fc82298e7dedbc0) | [HorizontalFormationGap](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a7ee88aaf14a4cea8fac88d8679867369) = 2f |
| const [float](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a5d3f2fceedc2eb678fc82298e7dedbc0) | [MaxSafetyScore](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#aece76f5386a6ca012f6e1ef5f6a19e93) = 100f |

|  |  |
| --- | --- |
| Properties | |
| bool | [SpawnWithHorses](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a5cddc06406f99a1390e37e4a4ca448ca) `[get]` |
| int | [PlanCount](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a4376de8c86d877ad8cf7fb1fc517be8c) `[get]` |
| bool | [IsPlanMade](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#ac336b351a569cb0968f6911044745d45) `[get]` |
| [float](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a5d3f2fceedc2eb678fc82298e7dedbc0) | [SpawnPathOffset](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#ad30360b1c4b57988d348e2377f2868ca) `[get]` |
| [float](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a5d3f2fceedc2eb678fc82298e7dedbc0) | [TargetOffset](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a404c393d199c5bfb6801a9346af57a5d) `[get]` |
| bool | [IsSafeToDeploy](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#aa27f29384ebea8cd1356a1f6782ee393) `[get]` |
| [float](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a5d3f2fceedc2eb678fc82298e7dedbc0) | [SafetyScore](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a2666c8bbd136d32d8c335016e0450208) `[get]` |
| int | [FootTroopCount](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a51f4ba74c409af9a6eb4620b54bf29c4) `[get]` |
| int | [MountedTroopCount](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#ad90684511696841776f435be78906f22) `[get]` |
| int | [TroopCount](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#ad93f95bbde5ca58cacd6764edfbb3be2) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [MeanPosition](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#ab12f51630c8c38a118d8bd56ebb08f8d) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a421c32218d4811b9392f2e1a09a187e9)CreateInitialPlan()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | DefaultDeploymentPlan TaleWorlds.MountAndBlade.DefaultDeploymentPlan.CreateInitialPlan | ( | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | *mission*, | |  |  | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#aaed869ff10c0405955e09505656a5207) | *team* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#ac8ee55bc86fe62c2d515370c6d31ba49)CreateReinforcementPlan()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | DefaultDeploymentPlan TaleWorlds.MountAndBlade.DefaultDeploymentPlan.CreateReinforcementPlan | ( | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | *mission*, | |  |  | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#aaed869ff10c0405955e09505656a5207) | *team* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a73cf47de6919ac6617658ca9865b4d92)CreateReinforcementPlanWithSpawnPath()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | DefaultDeploymentPlan TaleWorlds.MountAndBlade.DefaultDeploymentPlan.CreateReinforcementPlanWithSpawnPath | ( | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | *mission*, | |  |  | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#aaed869ff10c0405955e09505656a5207) | *team*, | |  |  | [SpawnPathData](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a40a0ae5cb0c4e5b7d277af98b4a65eba) | *spawnPathData* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a8a695200f273dd0288f2fd772b77514f)SetSpawnWithHorses()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DefaultDeploymentPlan.SetSpawnWithHorses | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a81a8af952717aa001a13cf38263b184b)ClearAddedTroops()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DefaultDeploymentPlan.ClearAddedTroops | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a62aebc4979dc3e3f1d2385f7bf40d634)ClearPlan()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DefaultDeploymentPlan.ClearPlan | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a9e4b670c07ec2467b35d6fcee18efa5b)AddTroops()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DefaultDeploymentPlan.AddTroops | ( | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | *formationClass*, |
|  |  | int | *footTroopCount*, |
|  |  | int | *mountedTroopCount* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a4327732bab755d6060349d7a48485ac9)PlanBattleDeployment()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DefaultDeploymentPlan.PlanBattleDeployment | ( | [FormationSceneSpawnEntry](struct_tale_worlds_1_1_mount_and_blade_1_1_formation_scene_spawn_entry.html) | *formationSceneSpawnEntries*[,], |
|  |  | [float](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a5d3f2fceedc2eb678fc82298e7dedbc0) | *spawnPathOffset* = 0f, |
|  |  | [float](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a5d3f2fceedc2eb678fc82298e7dedbc0) | *targetOffset* = 0f ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#aa9894a6b13b22de45e23a49c68a8eaf9)GetFormationPlan()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [DefaultFormationDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_formation_deployment_plan.html) TaleWorlds.MountAndBlade.DefaultDeploymentPlan.GetFormationPlan | ( | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | *fClass* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a8292af5326ad3c5e5300bee85869078f)GetFormationDeploymentFrame()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.DefaultDeploymentPlan.GetFormationDeploymentFrame | ( | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | *fClass*, |
|  |  | out [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a51e3f7c94e4a04f85aa631b2fabc2a2f)IsPlanSuitableForFormations()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.DefaultDeploymentPlan.IsPlanSuitableForFormations | ( | ValueTuple< int, int >[] | *troopDataPerFormationClass* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a123159837b4ce5f55c47fe59ded1b22a)UpdateSafetyScore()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DefaultDeploymentPlan.UpdateSafetyScore | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#ad9be6d4f04d630b0286110778efb4b15)GetFrameFromFormationSpawnEntity()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [WorldFrame](struct_tale_worlds_1_1_engine_1_1_world_frame.html) TaleWorlds.MountAndBlade.DefaultDeploymentPlan.GetFrameFromFormationSpawnEntity | ( | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *formationSpawnEntity*, |
|  |  | [float](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a5d3f2fceedc2eb678fc82298e7dedbc0) | *depthOffset* = 0f ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a37e2a52792cf50cf06c36c2c66e64feb)GetFormationSpawnWidthAndDepth()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [float](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a5d3f2fceedc2eb678fc82298e7dedbc0) TaleWorlds.MountAndBlade.DefaultDeploymentPlan.GetFormationSpawnWidthAndDepth | ( | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | *formationNo*, |
|  |  | int | *troopCount*, |
|  |  | bool | *hasMountedTroops*, |
|  |  | bool | *considerCavalryAsInfantry* = false ) |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a90a1a53543b1a9fb4f12ac3561be6b8f)VerticalFormationGap
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const [float](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a5d3f2fceedc2eb678fc82298e7dedbc0) TaleWorlds.MountAndBlade.DefaultDeploymentPlan.VerticalFormationGap = 3f | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a7ee88aaf14a4cea8fac88d8679867369)HorizontalFormationGap
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const [float](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a5d3f2fceedc2eb678fc82298e7dedbc0) TaleWorlds.MountAndBlade.DefaultDeploymentPlan.HorizontalFormationGap = 2f | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#aece76f5386a6ca012f6e1ef5f6a19e93)MaxSafetyScore
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const [float](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a5d3f2fceedc2eb678fc82298e7dedbc0) TaleWorlds.MountAndBlade.DefaultDeploymentPlan.MaxSafetyScore = 100f | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#aaed869ff10c0405955e09505656a5207)Team
-----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly Team TaleWorlds.MountAndBlade.DefaultDeploymentPlan.Team |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#aadc48922ffe87866690c612696d6899b)IsReinforcement
----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly bool TaleWorlds.MountAndBlade.DefaultDeploymentPlan.IsReinforcement |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a40a0ae5cb0c4e5b7d277af98b4a65eba)SpawnPathData
--------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly SpawnPathData TaleWorlds.MountAndBlade.DefaultDeploymentPlan.SpawnPathData |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a5d3f2fceedc2eb678fc82298e7dedbc0)float
------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| TaleWorlds.MountAndBlade.DefaultDeploymentPlan.float |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a5cddc06406f99a1390e37e4a4ca448ca)SpawnWithHorses
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.DefaultDeploymentPlan.SpawnWithHorses | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a4376de8c86d877ad8cf7fb1fc517be8c)PlanCount
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.DefaultDeploymentPlan.PlanCount | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#ac336b351a569cb0968f6911044745d45)IsPlanMade
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.DefaultDeploymentPlan.IsPlanMade | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#ad30360b1c4b57988d348e2377f2868ca)SpawnPathOffset
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [float](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a5d3f2fceedc2eb678fc82298e7dedbc0) TaleWorlds.MountAndBlade.DefaultDeploymentPlan.SpawnPathOffset | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a404c393d199c5bfb6801a9346af57a5d)TargetOffset
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [float](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a5d3f2fceedc2eb678fc82298e7dedbc0) TaleWorlds.MountAndBlade.DefaultDeploymentPlan.TargetOffset | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#aa27f29384ebea8cd1356a1f6782ee393)IsSafeToDeploy
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.DefaultDeploymentPlan.IsSafeToDeploy | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a2666c8bbd136d32d8c335016e0450208)SafetyScore
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [float](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a5d3f2fceedc2eb678fc82298e7dedbc0) TaleWorlds.MountAndBlade.DefaultDeploymentPlan.SafetyScore | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#a51f4ba74c409af9a6eb4620b54bf29c4)FootTroopCount
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.DefaultDeploymentPlan.FootTroopCount | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#ad90684511696841776f435be78906f22)MountedTroopCount
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.DefaultDeploymentPlan.MountedTroopCount | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#ad93f95bbde5ca58cacd6764edfbb3be2)TroopCount
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.DefaultDeploymentPlan.TroopCount | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_deployment_plan.html#ab12f51630c8c38a118d8bd56ebb08f8d)MeanPosition
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.DefaultDeploymentPlan.MeanPosition | | get |

