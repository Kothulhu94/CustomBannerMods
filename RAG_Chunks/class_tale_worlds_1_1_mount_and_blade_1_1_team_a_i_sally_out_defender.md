--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_sally_out_defender.html ---

TaleWorlds.MountAndBlade.TeamAISallyOutDefender Class ReferenceInherits [TaleWorlds.MountAndBlade.TeamAISiegeComponent](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_siege_component.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [TeamAISallyOutDefender](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_sally_out_defender.html#af93926aeeb5f9b2a7e06fe9d5567279b) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) currentMission, [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) currentTeam, float thinkTimerTime, float applyTimerTime) |
| override void | [OnUnitAddedToFormationForTheFirstTime](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_sally_out_defender.html#a842c2e69f3390623c2083b431321c40c) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| [Library.Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [CalculateSallyOutReferencePosition](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_sally_out_defender.html#a326d2a2b2824f891f4423d08ec869235) ([FormationAI.BehaviorSide](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#af0e557fbaea88404cb872c1bc2b7912b) side) |
| override void | [OnDeploymentFinished](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_sally_out_defender.html#adf49c994d49f4b84a07a59724fe68673) () |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.TeamAISiegeComponent](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_siege_component.html) | |
| bool | [CalculateIsChargePastWallsApplicable](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_siege_component.html#a1ec07a976f8c9460d36d9d772136ef05) ([FormationAI.BehaviorSide](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#af0e557fbaea88404cb872c1bc2b7912b) side) |
| void | [SetAreLaddersReady](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_siege_component.html#a9a44ae690c28301b815e371bd4d02d0b) (bool areLaddersReady) |
| bool | [CalculateIsAnyLaneOpenToGetInside](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_siege_component.html#a15ca887d32b440111bba865227e77c50) () |
| bool | [CalculateIsAnyLaneOpenToGoOutside](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_siege_component.html#a3709c34ef3dfeec9d9dc213f782e4ba1) () |
| bool | [IsPrimarySiegeWeaponNavmeshFaceId](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_siege_component.html#a4522d37ca9271a67371e2e6d74076ee5) (int id) |
| bool | [IsCastleBreached](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_siege_component.html#ac57c6b84b59f3b8a6daa8c36c576e2ba) () |
| override void | [OnDeploymentFinished](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_siege_component.html#a962aa7d35427e06306a5eb79861368dc) () |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.TeamAIComponent](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html) | |
| delegate void | [TacticalDecisionDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#ae941a52f414928ce324ce361f278b001) (in [TacticalDecision](struct_tale_worlds_1_1_mount_and_blade_1_1_tactical_decision.html) decision) |
| void | [AddStrategicArea](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a4f909ab6393bc8d730de5d1fabb64d39) ([StrategicArea](class_tale_worlds_1_1_mount_and_blade_1_1_strategic_area.html) strategicArea) |
| void | [RemoveStrategicArea](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#aa5080725a617db3b41ed14838a7fccf7) ([StrategicArea](class_tale_worlds_1_1_mount_and_blade_1_1_strategic_area.html) strategicArea) |
| void | [RemoveAllStrategicAreas](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a84e0221eb9008b99f9a8e0f3e563d32f) () |
| void | [AddTacticOption](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a31358c6523374570d2856b9d5e6db64f) ([TacticComponent](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html) tacticOption) |
| void | [RemoveTacticOption](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#ae13072c1b438b54a5ebeba0c9eb499a2) (Type tacticType) |
| void | [ClearTacticOptions](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a47a765fac0feaac859256c0b0579fd88) () |
| void | [AssertTeam](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a529e79db09ac7213460d0c3105ccc17a) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a1708ae0f8bafe90c6d66462a687f39b1) team) |
| void | [NotifyTacticalDecision](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a626e74ebf7afad505d728e5709b942d3) (in [TacticalDecision](struct_tale_worlds_1_1_mount_and_blade_1_1_tactical_decision.html) decision) |
|  | Notifies the registered subscribers about a tactical decision. |
| virtual void | [OnFormationFrameChanged](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a73c2b896c1b8904c48e7a38362791299) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, bool isFrameEnabled, [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) frame) |
| virtual void | [OnMissionEnded](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a63576f0227ebc97c387dd9ae1977ff4a) () |
| void | [ResetTacticalPositions](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a531b49d9e075c03a09e2e5d73ce75ec8) () |
| void | [ResetTactic](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#aff90cc58eada11e41c05a2ffff89f858) (bool keepCurrentTactic=true) |
| void | [CheckIsDefenseApplicable](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a18ede29233638d8c1e7186b1e0c7f1d4) () |
| void | [OnTacticAppliedForFirstTime](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#ad1999372f880aec09c30c88091d37cb6) () |
| void | [TickOccasionally](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a1d8dc0982e8dea5d3b1ca0288d6accf7) () |
| bool | [IsCurrentTactic](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a2ded1aa2a4a18bb006873c58261d0374) ([TacticComponent](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html) tactic) |
| void | [OnUnitAddedToFormationForTheFirstTime](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a5921f7d783bfc926e0dd059feb1dba99) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly Func< [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) > | [DefensePosition](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_sally_out_defender.html#a31d41a5a084874e41b843fd051783cb8) |
| Public Attributes inherited from [TaleWorlds.MountAndBlade.TeamAISiegeComponent](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_siege_component.html) | |
| readonly IEnumerable< [WallSegment](class_tale_worlds_1_1_mount_and_blade_1_1_wall_segment.html) > | [WallSegments](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_siege_component.html#aec9c0556a389906ea5980431d9cfc98e) |
| readonly List< [SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html) > | [SceneSiegeWeapons](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_siege_component.html#aeaff197e48ddc48971a48f8d526042ce) |
| Public Attributes inherited from [TaleWorlds.MountAndBlade.TeamAIComponent](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html) | |
| [TacticalDecisionDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#ae941a52f414928ce324ce361f278b001) | [OnNotifyTacticalDecision](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a25115ad1b1033f1d4813df25f1e7dd0b) |
| List< [TacticalPosition](class_tale_worlds_1_1_mount_and_blade_1_1_tactical_position.html) > | [TacticalPositions](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a5c7d24959b7cd3ae3ca086cf9a4cbd58) |
| List< [TacticalRegion](class_tale_worlds_1_1_mount_and_blade_1_1_tactical_region.html) > | [TacticalRegions](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#ac7ae0e0ec2a613832dfc306fec8d94d9) |

|  |  |
| --- | --- |
| Properties | |
| List< [ArcherPosition](class_tale_worlds_1_1_mount_and_blade_1_1_archer_position.html) > | [ArcherPositions](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_sally_out_defender.html#a351280c1505908d7fddae461368f0026) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.TeamAISiegeComponent](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_siege_component.html) | |
| static List< [SiegeLane](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html) > | [SiegeLanes](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_siege_component.html#a6fbd92bdfd27c4bebddf1f5335d9076a) `[get]` |
| static [SiegeQuerySystem](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html) | [QuerySystem](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_siege_component.html#ad3f5008c9417e66af4746d6322d257a2) `[get, protected set]` |
| [CastleGate](class_tale_worlds_1_1_mount_and_blade_1_1_castle_gate.html) | [OuterGate](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_siege_component.html#a8f5c6c0a798ebdda8cec6bcd9d5dce14) `[get]` |
| List< [IPrimarySiegeWeapon](interface_tale_worlds_1_1_mount_and_blade_1_1_i_primary_siege_weapon.html) > | [PrimarySiegeWeapons](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_siege_component.html#a930c3673fce5ad617b526c84ea734ee0) `[get]` |
| [CastleGate](class_tale_worlds_1_1_mount_and_blade_1_1_castle_gate.html) | [InnerGate](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_siege_component.html#abd4bbea34ab82c2974309e7ac8e97623) `[get]` |
| MBReadOnlyList< [SiegeLadder](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html) > | [Ladders](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_siege_component.html#ae56ed9acd5c34b75717a8406ec629097) `[get]` |
| bool | [AreLaddersReady](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_siege_component.html#aa1416c81a85386e8bfc281a5f3db8fe5) `[get]` |
| List< int > | [DifficultNavmeshIDs](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_siege_component.html#aebf6525bd2746176c72fe78fb8c3f7e4) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.TeamAIComponent](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html) | |
| MBReadOnlyList< [StrategicArea](class_tale_worlds_1_1_mount_and_blade_1_1_strategic_area.html) > | [StrategicAreas](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a5bb819442454d7a495da83b86fc9560f) `[get]` |
| bool | [HasStrategicAreas](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#ab6db99af3333735c59a05d1f5ce5b30c) `[get]` |
| bool | [IsDefenseApplicable](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a2f3aaaf9f02d4423fbee1a7c4a29949e) `[get]` |
| bool | [GetIsFirstTacticChosen](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a913e28be6871946f4396612342fa0ad6) = false `[get]` |
| [TacticComponent](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html) | [CurrentTactic](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a03dee2a4140f42130f784e76363a7ba8) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.MountAndBlade.TeamAISiegeComponent](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_siege_component.html) | |
| static void | [OnMissionFinalize](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_siege_component.html#ac6cb0467e0aff105043d9ebe6680f4ae) () |
| static bool | [IsFormationGroupInsideCastle](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_siege_component.html#ac8e6f92b3e2a85bd56a631f7c1465b42) (MBList< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > formationGroup, bool includeOnlyPositionedUnits, float thresholdPercentage=FormationInsideCastleThresholdPercentage) |
| static bool | [IsFormationInsideCastle](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_siege_component.html#ab419f71a7ba1ad932308f192e1aba8b2) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation, bool includeOnlyPositionedUnits, float thresholdPercentage=FormationInsideCastleThresholdPercentage) |
| Static Public Attributes inherited from [TaleWorlds.MountAndBlade.TeamAISiegeComponent](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_siege_component.html) | |
| const int | [InsideCastleNavMeshID](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_siege_component.html#a3f54e1b960cbdcc767b4e0163f9c751f) = 1 |
| const int | [SiegeTokenForceSize](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_siege_component.html#aa690182e9471300474ad4b8aa4432bdc) = 15 |
| Static Public Attributes inherited from [TaleWorlds.MountAndBlade.TeamAIComponent](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html) | |
| const int | [BattleTokenForceSize](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a128b168a2284a1851a678c190135ae1e) = 10 |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.TeamAISiegeComponent](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_siege_component.html) | |
|  | [TeamAISiegeComponent](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_siege_component.html#a94b007cda17cf13784c7487a0c8575a6) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a1aaad201847b74bb82e35cc612f1b120) currentMission, [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a1708ae0f8bafe90c6d66462a687f39b1) currentTeam, float thinkTimerTime, float applyTimerTime) |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.TeamAIComponent](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html) | |
|  | [TeamAIComponent](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a9724532a8ebf8e6bd1a8b54a2def9d51) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a1aaad201847b74bb82e35cc612f1b120) currentMission, [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a1708ae0f8bafe90c6d66462a687f39b1) currentTeam, float thinkTimerTime, float applyTimerTime) |
| virtual void | [DebugTick](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a5a09e99d1f4c59eeed88bfa75bb6c065) (float dt) |
| Protected Attributes inherited from [TaleWorlds.MountAndBlade.TeamAISiegeComponent](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_siege_component.html) | |
| readonly IEnumerable< [CastleGate](class_tale_worlds_1_1_mount_and_blade_1_1_castle_gate.html) > | [CastleGates](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_siege_component.html#a47595e5f1091e37c55da56ed24075254) |
| readonly List< [SiegeTower](class_tale_worlds_1_1_mount_and_blade_1_1_siege_tower.html) > | [SiegeTowers](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_siege_component.html#a14004e1279f96bd0b616b4b3031fe866) |
| readonly HashSet< int > | [PrimarySiegeWeaponNavMeshFaceIDs](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_siege_component.html#aa56c411fc24d88f2c5492f1c16de6a6f) |
| [BatteringRam](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html) | [Ram](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_siege_component.html#ad676330df79a7b2fa3eb99192d694209) |
| List< [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) > | [CastleKeyPositions](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_siege_component.html#a921238eaac2782821797a07b97408c5c) |
| Protected Attributes inherited from [TaleWorlds.MountAndBlade.TeamAIComponent](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html) | |
| readonly Mission | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a1aaad201847b74bb82e35cc612f1b120) |
| readonly Team | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a1708ae0f8bafe90c6d66462a687f39b1) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_sally_out_defender.html#af93926aeeb5f9b2a7e06fe9d5567279b)TeamAISallyOutDefender()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.TeamAISallyOutDefender.TeamAISallyOutDefender | ( | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | *currentMission*, |
|  |  | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *currentTeam*, |
|  |  | float | *thinkTimerTime*, |
|  |  | float | *applyTimerTime* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_sally_out_defender.html#a842c2e69f3390623c2083b431321c40c)OnUnitAddedToFormationForTheFirstTime()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.MountAndBlade.TeamAISallyOutDefender.OnUnitAddedToFormationForTheFirstTime | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_sally_out_defender.html#a326d2a2b2824f891f4423d08ec869235)CalculateSallyOutReferencePosition()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Library.Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.TeamAISallyOutDefender.CalculateSallyOutReferencePosition | ( | [FormationAI.BehaviorSide](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#af0e557fbaea88404cb872c1bc2b7912b) | *side* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_sally_out_defender.html#adf49c994d49f4b84a07a59724fe68673)OnDeploymentFinished()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.TeamAISallyOutDefender.OnDeploymentFinished | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.TeamAIComponent](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#ab06ffccff64d3de3bdb5c5180beb606c).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_sally_out_defender.html#a31d41a5a084874e41b843fd051783cb8)DefensePosition
--------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly Func<[WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html)> TaleWorlds.MountAndBlade.TeamAISallyOutDefender.DefensePosition |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_sally_out_defender.html#a351280c1505908d7fddae461368f0026)ArcherPositions
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[ArcherPosition](class_tale_worlds_1_1_mount_and_blade_1_1_archer_position.html)> TaleWorlds.MountAndBlade.TeamAISallyOutDefender.ArcherPositions | | get |

