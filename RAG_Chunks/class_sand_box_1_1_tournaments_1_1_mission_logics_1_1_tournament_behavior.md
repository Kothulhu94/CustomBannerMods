--- SOURCE: class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html ---

SandBox.Tournaments.MissionLogics.TournamentBehavior Class ReferenceInherits [TaleWorlds.MountAndBlade.MissionLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html), and [TaleWorlds.Core.ICameraModeLogic](interface_tale_worlds_1_1_core_1_1_i_camera_mode_logic.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| [SpectatorCameraTypes](namespace_tale_worlds_1_1_core.html#a92fd4c9a27d27dc932f836e1c57fd22c) | [GetMissionCameraLockMode](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a2bfd166882641c2a4ca3eec370dc2389) (bool lockedToMainPlayer) |
|  | [TournamentBehavior](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a0589491cb2b603b815f73710931c795e) ([TournamentGame](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a01cf8ab26fbba12226144457d66c8367) tournamentGame, [Settlement](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a235cf9d4657a6a160647451df1d0b394) settlement, [ITournamentGameBehavior](interface_sand_box_1_1_tournaments_1_1_i_tournament_game_behavior.html) gameBehavior, bool isPlayerParticipating) |
| MBList< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > | [GetAllPossibleParticipants](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a7fe2445a02c5ddee78bd00f97786d02d) () |
| override void | [AfterStart](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#abc33d33b6ca14acc6d6545203314c4e5) () |
| override void | [OnMissionTick](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#ab54b94f9277ccc50a5cb82e16ef1fe39) (float dt) |
| void | [StartMatch](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a000e639e1c37de994942d66f6ff6be3f) () |
| void | [SkipMatch](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#afa41b3c43ac151c169e351061d976574) (bool isLeave=false) |
| void | [EndTournamentViaLeave](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a215675655b6eb156fd33735e4a9ad458) () |
| override [InquiryData](class_tale_worlds_1_1_library_1_1_inquiry_data.html) | [OnEndMissionRequest](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#abca287895f0f1dc422ce15cf259c2ec2) (out bool canPlayerLeave) |
| void | [PlaceABet](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a9fa4d2ef89bc8ad100ba96092afb71ed) (int bet) |
| int | [GetExpectedDenarsForBet](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a2b169bcd345137d68c9f10af34f39711) (int bet) |
| int | [GetMaximumBet](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#ae29504f52a8dc182a79dacc97cb167ca) () |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.MissionLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html) | |
| virtual bool | [MissionEnded](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html#a29b13e42f227a4e3db7b122432828a5d) (ref [MissionResult](class_tale_worlds_1_1_core_1_1_mission_result.html) missionResult) |
| virtual void | [OnBattleEnded](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html#a22ce0847d249cacf3e3eb0fc7e42418e) () |
| virtual void | [ShowBattleResults](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html#aa136b81e5789a5751dc40747f06729d0) () |
| virtual void | [OnRetreatMission](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html#a5dfd6571818a82e84e6bde5c3f6e230c) () |
| virtual void | [OnSurrenderMission](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html#a82312204a645c7111da9fd681db58071) () |
| virtual void | [OnAutoDeployTeam](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html#a93f966936c3279a2ab6c75b6cbefdbcd) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
| virtual List< [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) > | [GetExtraEquipmentElementsForCharacter](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html#a0d9f573268c0340b82f5f14ae6d2907c) ([BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) character, bool getAllEquipments=false) |
| virtual void | [OnMissionResultReady](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html#a71604faff850780ba619d76d4e861e1f) ([MissionResult](class_tale_worlds_1_1_core_1_1_mission_result.html) missionResult) |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html) | |
| virtual void | [OnAfterMissionCreated](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ad5b64f9606fcf2f88f9d2088d49de3d6) () |
| virtual void | [OnBehaviorInitialize](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a94e4fe46fad26b2a84dbbf3a4a5cc14c) () |
| virtual void | [OnCreated](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a29e57cd652228fc81feee9a78a31121f) () |
| virtual void | [EarlyStart](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a3bd04d1aa2eb7f76f6c269d9f97e3fbd) () |
| virtual void | [OnMissileHit](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a6d83e4fa1f6e1167b130b82a782566b1) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attacker, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victim, bool isCanceled, [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData) |
| virtual void | [OnMeleeHit](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ae67852af54716d6087e05eec594e21ef) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attacker, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victim, bool isCanceled, [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData) |
| virtual void | [OnMissileCollisionReaction](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a6dab0fd5a10bef3110a51af4176028d8) ([Mission.MissileCollisionReaction](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a235275d0a4fd9f604f19aaaf6943e494) collisionReaction, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attachedAgent, sbyte attachedBoneIndex) |
| virtual void | [OnMissionScreenPreLoad](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a9e8c61bb3fa009704236d5b9fced2c74) () |
| virtual void | [OnAgentCreated](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#af4505c65ad5f3f5ac6ec4b766f7aa203) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| virtual void | [OnAgentBuild](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ad610eac3ce9064919cb8771652a5da4e) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [Banner](class_tale_worlds_1_1_core_1_1_banner.html) banner) |
| virtual void | [OnAgentTeamChanged](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ae82c2110c9b50bf8c08030847c896275) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) prevTeam, [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) newTeam, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| virtual void | [OnAgentControllerSetToPlayer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a3cbbc0856767f6975fc137a83480c71a) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| virtual void | [OnAgentHit](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a2ca3ef8b8c9419285565e1443873345d) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectedAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectorAgent, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) affectorWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) attackCollisionData) |
| virtual void | [OnScoreHit](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a47a0a0aafce4f2bc5bca00fa1410e539) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectedAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectorAgent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, bool isBlocked, bool isSiegeEngineHit, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, float damagedHp, float hitDistance, float shotDifficulty) |
| virtual void | [OnEarlyAgentRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a2357313c6773cd404fea1d097c94a165) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectedAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectorAgent, [AgentState](namespace_tale_worlds_1_1_core.html#a799bcc77ddb6372c7383f3340ed4d1c0) agentState, [KillingBlow](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html) blow) |
| virtual void | [OnAgentRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ad4987b5b5e719f90cad1856b8c0b7976) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectedAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectorAgent, [AgentState](namespace_tale_worlds_1_1_core.html#a799bcc77ddb6372c7383f3340ed4d1c0) agentState, [KillingBlow](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html) blow) |
| virtual void | [OnAgentDeleted](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a7eba548023bf92a07eb6254ec4241596) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectedAgent) |
| virtual void | [OnAgentFleeing](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aaa554af0ef2506421c75dd30447f874e) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectedAgent) |
| virtual void | [OnAgentPanicked](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a5dd187c2f799d75a81280387da848a52) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectedAgent) |
| virtual void | [OnFocusGained](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a2194f733a9135726d66e837955aba53b) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html) focusableObject, bool isInteractable) |
| virtual void | [OnFocusLost](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#af2849b7ea639493ffca4702bb6bcfb03) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html) focusableObject) |
| virtual void | [OnAddTeam](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a7a49d143b51cf0f72d20b13b0a571884) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
| virtual void | [AfterAddTeam](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a1a84dd234ff93d804a4094f9876df166) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
| virtual void | [OnAgentInteraction](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a813d13ba2cdf3ad40dd5ab055e6c5bf2) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) userAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, sbyte agentBoneIndex) |
| virtual void | [OnClearScene](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a0f6f2ae3c6e394ee12a8d394516af918) () |
| virtual void | [OnEndMissionInternal](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a49e74ba30248db4bac7d78be3039ded9) () |
|  | Do not override this. |
| virtual void | [OnRemoveBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a80cb93b393ebaa09e4fd5fbab467556f) () |
| virtual void | [OnFixedMissionTick](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aee013ab26ac67f4043a1b839112572a3) (float fixedDt) |
| virtual void | [OnPreMissionTick](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ac5f9da64f58e30eb4ef62a39596e1af7) (float dt) |
| virtual void | [OnPreDisplayMissionTick](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aca165ecaaa9e2c3e2c96219353678a3c) (float dt) |
| virtual void | [OnAgentMount](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#acd50c486f7723094db2816a6628b43fd) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| virtual void | [OnAgentDismount](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a0b9976fba83dd53e5936601bf4ee976b) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| virtual bool | [IsThereAgentAction](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a7624ad654b98307d9787ea0306201eee) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) userAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) otherAgent) |
| virtual void | [OnEntityRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a57fadca1dc84db12184b4b565f9c80ca) ([GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) entity) |
| virtual void | [OnObjectUsed](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a3d381cb580df73e192ed90ca3b5748aa) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) userAgent, [UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) usedObject) |
| virtual void | [OnObjectStoppedBeingUsed](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aaf907078513d7e3df38abf8dc200b799) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) userAgent, [UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) usedObject) |
| virtual void | [OnRenderingStarted](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aef2c8257a1dd922df89563d876bcd6eb) () |
| virtual void | [OnMissionStateActivated](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a8423ba3337a74876d8302cde746cda7b) () |
|  | Called either after the mission is first initialized or the mission state is re-activated when a prior state (like inventory) is popped out of [GameState](class_tale_worlds_1_1_core_1_1_game_state.html) stack. |
| virtual void | [OnMissionStateFinalized](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ab8cc901fb3a6f33ad640c4b7f1ca0a35) () |
|  | Called right before the mission state is finalized and any remaining allocated mission resources are released. This is not the same as OnMissionEnd callback which is called after the player clicks end/retreat button on battle results screen. [MissionState](class_tale_worlds_1_1_mount_and_blade_1_1_mission_state.html) is deallocated some time after OnMissionEnd to let MissionBehaviors to correctly deallocated themselves. Certain data structures (like [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html)'s agent list) are emptied here so do not depend on them. This is the final callback mission behaviors will receive before they are removed entirely. |
| virtual void | [OnMissionStateDeactivated](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a6c56791473ed920b83b0e13c201ed810) () |
|  | Called either before mission is finalized or the mission state is deactivated due to another state (like inventory) being pushed into GameStates stack. |
| virtual List< [CompassItemUpdateParams](struct_tale_worlds_1_1_mount_and_blade_1_1_compass_item_update_params.html) > | [GetCompassTargets](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aff6cbeabac7505c9409a5ecf6af55724) () |
| virtual void | [OnAssignPlayerAsSergeantOfFormation](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a1678389824ffac3a5dd204dc682a6676) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| virtual void | [OnDeploymentFinished](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a01f07236b3998c09e045cfa1462713a6) () |
| virtual void | [OnAfterDeploymentFinished](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a13c26f6fe5fd5cbb88b821e39067b3cc) () |
| virtual void | [OnTeamDeployed](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a196646b682434cdd6e49df0e0781f3f0) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
| virtual void | [OnBattleSideDeployed](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aad994e022ad060313ab0f605d8f1eebe) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| virtual void | [OnAgentAlarmedStateChanged](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a5a44a2daafc6b4a8b478e3dd2309ac20) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [Agent.AIStateFlag](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a9bf7959dd8d468ef55afa4b4a53e0995) flag) |
| virtual void | [OnMissionModeChange](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a11fc0970636713f77872610dd41fdf4f) ([MissionMode](namespace_tale_worlds_1_1_core.html#a34f0ac611df16851fc92e4523aa834e1) oldMissionMode, bool atStart) |
| virtual void | [OnRegisterBlow](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#afc94274b34e25df5c68187631baa9a4b) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attacker, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victim, [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) realHitEntity, [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) b, ref [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) attackerWeapon) |
| virtual void | [OnAgentShootMissile](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a1bbc0267645d0d331b951ec340f5e01c) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) shooterAgent, [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) weaponIndex, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) velocity, [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html) orientation, bool hasRigidBody, int forcedMissileIndex) |
| virtual void | [OnMissileRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a0353cba934ad1a0fe6e72ca6555f1f7c) (int MissileIndex) |
| virtual void | [OnTutorialCompleted](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a64007b92eb1f373cf2b66dcf901ffe43) (string completedTutorialIdentifier) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [DeleteTournamentSetsExcept](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#accceb1e51d8bd7dad6083ddeaca1bdb8) ([GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) selectedSetEntity) |
| static void | [DeleteAllTournamentSets](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a73eff6000f9fd7d1eb470ca7399f0f00) () |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const int | [RoundCount](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a36bcbb3d5c9497ca3dce0055a59eb37d) = 4 |
| const int | [ParticipantCount](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a283e8025e0f9bd258926e7cdd5c5f1ee) = 16 |
| const float | [EndMatchTimerDuration](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#aec048fbe76d49829967091dce7236905) = 6 |
| const float | [CheerTimerDuration](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a5ce7f4d861ee542b7131d25f5b6ae9ae) = 1 |
| const float | [MaximumOdd](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a413b57e43871410250395817d69086d4) = 4.0f |

|  |  |
| --- | --- |
| Properties | |
| TournamentGame | [TournamentGame](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a01cf8ab26fbba12226144457d66c8367) `[get]` |
| [TournamentRound](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_round.html)[] | [Rounds](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#ae06709cfff88b1404d356a71a4d5c24e) `[get]` |
| bool | [IsPlayerEliminated](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#ac029069075d5fb6d927f29d1f90c20de) `[get]` |
| int | [CurrentRoundIndex](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a71454efc49ce6b1711ab30cdc7d19538) `[get]` |
| [TournamentMatch](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html) | [LastMatch](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a74dbdfddb832298626c8e50fa3eaf7bd) `[get]` |
| [TournamentRound](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_round.html) | [CurrentRound](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a9a57d97fa490b26780b55e93d32e61ee) `[get]` |
| [TournamentRound](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_round.html) | [NextRound](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#af1eed72e7033a9c3d712e0778848ca6c) `[get]` |
| [TournamentMatch](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html) | [CurrentMatch](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a938df6e8ea6a940bcbc1e215ae8c26ad) `[get]` |
| [TournamentParticipant](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_participant.html) | [Winner](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a7053cf86977c4f0058229c0baae3b7d8) `[get]` |
| bool | [IsPlayerParticipating](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a0292f3b0b89ef7de9741a09ead6ac7d1) `[get]` |
| Settlement | [Settlement](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a235cf9d4657a6a160647451df1d0b394) `[get]` |
| float | [BetOdd](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#aa99d2cc6957da9d95cdfac044bd28dc2) `[get]` |
| int | [MaximumBetInstance](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a1b8af545d98b28f34a08dd9ef04ef3d7) `[get]` |
| int | [BettedDenars](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a21649b77c38a6c630cff2d0f01ea9805) `[get]` |
| int | [OverallExpectedDenars](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a85af348d1c48660b0c9f967d0bc93354) `[get]` |
| int | [PlayerDenars](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a70783c6f3a7f43a804f7a517c181641b) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.MissionLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html) | |
| override [MissionBehaviorType](namespace_tale_worlds_1_1_mount_and_blade.html#a372fbfd8b3eae375d7fd2e0dcbb76993) | [BehaviorType](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html#a22dc913ab511b0a23db3e6a09b76fcd7) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html) | |
| Mission | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aa8057eb8e1718954a667dc0c9a334281) `[get]` |
| [IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html) | [DebugInput](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ac73ea22074a4d9e10f0018fda1a4c67c) `[get]` |
| [MissionBehaviorType](namespace_tale_worlds_1_1_mount_and_blade.html#a372fbfd8b3eae375d7fd2e0dcbb76993) | [BehaviorType](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aca34f7ade7fa89aba9d51c8330684cc5) `[get]` |

|  |  |
| --- | --- |
| Events | |
| Action | [TournamentEnd](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#afe8fad055b18ad9393f863d567e9428d) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html) | |
| virtual void | [OnEndMission](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a2520fc88c264958b60ba7b75a4714117) () |
|  | Called right before the mission ends (i.e. after player clicks done/retreat button in battle results screen for SP missions). Preferably unregister all your [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) dependent events here. Some mission fields (like agent lists) will be deallocated after the mission ends. |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a0589491cb2b603b815f73710931c795e)TournamentBehavior()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| SandBox.Tournaments.MissionLogics.TournamentBehavior.TournamentBehavior | ( | [TournamentGame](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a01cf8ab26fbba12226144457d66c8367) | *tournamentGame*, |
|  |  | [Settlement](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a235cf9d4657a6a160647451df1d0b394) | *settlement*, |
|  |  | [ITournamentGameBehavior](interface_sand_box_1_1_tournaments_1_1_i_tournament_game_behavior.html) | *gameBehavior*, |
|  |  | bool | *isPlayerParticipating* ) |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a2bfd166882641c2a4ca3eec370dc2389)GetMissionCameraLockMode()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [SpectatorCameraTypes](namespace_tale_worlds_1_1_core.html#a92fd4c9a27d27dc932f836e1c57fd22c) SandBox.Tournaments.MissionLogics.TournamentBehavior.GetMissionCameraLockMode | ( | bool | *lockedToMainPlayer* | ) |  |

Implements [TaleWorlds.Core.ICameraModeLogic](interface_tale_worlds_1_1_core_1_1_i_camera_mode_logic.html#a4d927634812cb9e1e85562652898665c).

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a7fe2445a02c5ddee78bd00f97786d02d)GetAllPossibleParticipants()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| MBList< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > SandBox.Tournaments.MissionLogics.TournamentBehavior.GetAllPossibleParticipants | ( |  | ) |  |

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#accceb1e51d8bd7dad6083ddeaca1bdb8)DeleteTournamentSetsExcept()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void SandBox.Tournaments.MissionLogics.TournamentBehavior.DeleteTournamentSetsExcept | ( | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *selectedSetEntity* | ) |  | | static |

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a73eff6000f9fd7d1eb470ca7399f0f00)DeleteAllTournamentSets()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void SandBox.Tournaments.MissionLogics.TournamentBehavior.DeleteAllTournamentSets | ( |  | ) |  | | static |

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#abc33d33b6ca14acc6d6545203314c4e5)AfterStart()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.Tournaments.MissionLogics.TournamentBehavior.AfterStart | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a693295e26d8b0fcf634c52b1c08fd974).

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#ab54b94f9277ccc50a5cb82e16ef1fe39)OnMissionTick()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.Tournaments.MissionLogics.TournamentBehavior.OnMissionTick | ( | float | *dt* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a006b322c9ef8b55a1897419394c0a1e4).

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a000e639e1c37de994942d66f6ff6be3f)StartMatch()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.Tournaments.MissionLogics.TournamentBehavior.StartMatch | ( |  | ) |  |

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#afa41b3c43ac151c169e351061d976574)SkipMatch()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.Tournaments.MissionLogics.TournamentBehavior.SkipMatch | ( | bool | *isLeave* = false | ) |  |

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a215675655b6eb156fd33735e4a9ad458)EndTournamentViaLeave()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.Tournaments.MissionLogics.TournamentBehavior.EndTournamentViaLeave | ( |  | ) |  |

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#abca287895f0f1dc422ce15cf259c2ec2)OnEndMissionRequest()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override [InquiryData](class_tale_worlds_1_1_library_1_1_inquiry_data.html) SandBox.Tournaments.MissionLogics.TournamentBehavior.OnEndMissionRequest | ( | out bool | *canPlayerLeave* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html#a9373241b87874466fbb93f73f44acc83).

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a9fa4d2ef89bc8ad100ba96092afb71ed)PlaceABet()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.Tournaments.MissionLogics.TournamentBehavior.PlaceABet | ( | int | *bet* | ) |  |

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a2b169bcd345137d68c9f10af34f39711)GetExpectedDenarsForBet()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int SandBox.Tournaments.MissionLogics.TournamentBehavior.GetExpectedDenarsForBet | ( | int | *bet* | ) |  |

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#ae29504f52a8dc182a79dacc97cb167ca)GetMaximumBet()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int SandBox.Tournaments.MissionLogics.TournamentBehavior.GetMaximumBet | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a36bcbb3d5c9497ca3dce0055a59eb37d)RoundCount
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int SandBox.Tournaments.MissionLogics.TournamentBehavior.RoundCount = 4 | | static |

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a283e8025e0f9bd258926e7cdd5c5f1ee)ParticipantCount
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int SandBox.Tournaments.MissionLogics.TournamentBehavior.ParticipantCount = 16 | | static |

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#aec048fbe76d49829967091dce7236905)EndMatchTimerDuration
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float SandBox.Tournaments.MissionLogics.TournamentBehavior.EndMatchTimerDuration = 6 | | static |

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a5ce7f4d861ee542b7131d25f5b6ae9ae)CheerTimerDuration
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float SandBox.Tournaments.MissionLogics.TournamentBehavior.CheerTimerDuration = 1 | | static |

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a413b57e43871410250395817d69086d4)MaximumOdd
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float SandBox.Tournaments.MissionLogics.TournamentBehavior.MaximumOdd = 4.0f | | static |

Property Documentation
----------------------

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a01cf8ab26fbba12226144457d66c8367)TournamentGame
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | TournamentGame SandBox.Tournaments.MissionLogics.TournamentBehavior.TournamentGame | | get |

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#ae06709cfff88b1404d356a71a4d5c24e)Rounds
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TournamentRound](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_round.html) [] SandBox.Tournaments.MissionLogics.TournamentBehavior.Rounds | | get |

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#ac029069075d5fb6d927f29d1f90c20de)IsPlayerEliminated
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.Tournaments.MissionLogics.TournamentBehavior.IsPlayerEliminated | | get |

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a71454efc49ce6b1711ab30cdc7d19538)CurrentRoundIndex
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.Tournaments.MissionLogics.TournamentBehavior.CurrentRoundIndex | | get |

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a74dbdfddb832298626c8e50fa3eaf7bd)LastMatch
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TournamentMatch](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html) SandBox.Tournaments.MissionLogics.TournamentBehavior.LastMatch | | get |

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a9a57d97fa490b26780b55e93d32e61ee)CurrentRound
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TournamentRound](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_round.html) SandBox.Tournaments.MissionLogics.TournamentBehavior.CurrentRound | | get |

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#af1eed72e7033a9c3d712e0778848ca6c)NextRound
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TournamentRound](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_round.html) SandBox.Tournaments.MissionLogics.TournamentBehavior.NextRound | | get |

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a938df6e8ea6a940bcbc1e215ae8c26ad)CurrentMatch
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TournamentMatch](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html) SandBox.Tournaments.MissionLogics.TournamentBehavior.CurrentMatch | | get |

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a7053cf86977c4f0058229c0baae3b7d8)Winner
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TournamentParticipant](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_participant.html) SandBox.Tournaments.MissionLogics.TournamentBehavior.Winner | | get |

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a0292f3b0b89ef7de9741a09ead6ac7d1)IsPlayerParticipating
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.Tournaments.MissionLogics.TournamentBehavior.IsPlayerParticipating | | get |

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a235cf9d4657a6a160647451df1d0b394)Settlement
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Settlement SandBox.Tournaments.MissionLogics.TournamentBehavior.Settlement | | get |

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#aa99d2cc6957da9d95cdfac044bd28dc2)BetOdd
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float SandBox.Tournaments.MissionLogics.TournamentBehavior.BetOdd | | get |

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a1b8af545d98b28f34a08dd9ef04ef3d7)MaximumBetInstance
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.Tournaments.MissionLogics.TournamentBehavior.MaximumBetInstance | | get |

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a21649b77c38a6c630cff2d0f01ea9805)BettedDenars
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.Tournaments.MissionLogics.TournamentBehavior.BettedDenars | | get |

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a85af348d1c48660b0c9f967d0bc93354)OverallExpectedDenars
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.Tournaments.MissionLogics.TournamentBehavior.OverallExpectedDenars | | get |

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#a70783c6f3a7f43a804f7a517c181641b)PlayerDenars
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.Tournaments.MissionLogics.TournamentBehavior.PlayerDenars | | get |

Event Documentation
-------------------

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html#afe8fad055b18ad9393f863d567e9428d)TournamentEnd
----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action SandBox.Tournaments.MissionLogics.TournamentBehavior.TournamentEnd |

