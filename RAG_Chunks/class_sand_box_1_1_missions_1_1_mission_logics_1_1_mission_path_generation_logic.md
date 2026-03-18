--- SOURCE: class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html ---

SandBox.Missions.MissionLogics.MissionPathGenerationLogic Class ReferenceInherits [TaleWorlds.MountAndBlade.MissionLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html).

|  |  |
| --- | --- |
| Classes | |
| class | [UsableMachineData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_usable_machine_data.html) |
| class | [NavigationPathData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_navigation_path_data.html) |
| class | [PointOfInterestBaseData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html) |
| class | [LookBackPointData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_look_back_point_data.html) |
| class | [VisitPointNodeScoreData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_visit_point_node_score_data.html) |
| class | [CrossRoadScoreData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_cross_road_score_data.html) |
| class | [StandingGuardSpawnData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_standing_guard_spawn_data.html) |
| class | [PointOfInterestScorePair](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_score_pair.html) |

|  |  |
| --- | --- |
| Public Types | |
| enum | [PointOfInterests](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a843e89bb9ec59f2f496028dd6b4ef921) {     [VisitPoint](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a843e89bb9ec59f2f496028dd6b4ef921a6989297c66694b8dcca25cc21852f2c7) ,     [CrossRoadPoint](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a843e89bb9ec59f2f496028dd6b4ef921a2e0df1206b092ff35a8d786f4faea45a) ,     [GuardSpawnPoint](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a843e89bb9ec59f2f496028dd6b4ef921ae9ca98c4c2bd86e4953b7adaa4a4f43c) ,     [LookBackPoint](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a843e89bb9ec59f2f496028dd6b4ef921a430d8e3f935ad225548737398f196a3e)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MissionPathGenerationLogic](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a3dd170505da09aaca6734d05eee5df96) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) defaultDisguiseCharacter) |
| override void | [OnObjectUsed](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a48270f969c3946371786e2b9ab51cb24) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) userAgent, [UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) usedObject) |
| void | [InitializeBehavior](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#aa5632ef50306117731547180945477fe) () |
| override void | [OnMissionTick](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a0e6d4f00f17fa30e8492eaca02841760) (float dt) |
| List< [PointOfInterestScorePair](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_score_pair.html) > | [GetAllPossiblePaths](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#ad6e205580990efbead2df2d55b3d74bc) () |
| bool | [IsOnLeftSide](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a2f15bcd8fda995ab5931f8d6e83fe403) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) lineA, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) lineB, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) point) |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.MissionLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html) | |
| virtual [InquiryData](class_tale_worlds_1_1_library_1_1_inquiry_data.html) | [OnEndMissionRequest](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html#a9373241b87874466fbb93f73f44acc83) (out bool canLeave) |
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
| virtual void | [AfterStart](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a693295e26d8b0fcf634c52b1c08fd974) () |
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
| Public Attributes | |
| float | [MinimumDistanceToBlendPointToVisitPoint](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#aaf15d8fac232110d3539bbc89cc2e2b5) = 5.0f |
| List< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > | [\_startAndFinishPointPool](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#ace1530e23ef0c0d33c477c976cf3de89) |
| int | [CrossRoadMaximumDistance](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a062cb7507d566679e8dd98dd8a98e68b) = 30 |
| int | [CrossRoadMinimumDistance](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a408e98716e5ba986e77a28b77c5d4d74) = 10 |
| int | [MinimumVisitPointDistance](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#ac55df0e65e49bdaa31846ad08e5c0ef9) = 10 |
| int | [MaximumVisitPointDistance](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a7716bd81afb47845911d5d41b4142e23) = 40 |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static int | [MinimumPathDistance](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a6dd5f5e2e2282c0b16a70b0e538b84f2) = 200 |
| static int | [MaximumPathDistance](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#adfe73089eeb5aa615ed6cd01637e03aa) = 600 |
| static int | [MinimumVisitPointCountInPath](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a000ab76608666404bbdc412d38e2a58f) = 2 |
| static int | [MaximumVisitPointCountInPath](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a6d89d0befb82d2e59836ae7538a9cf4b) = 10 |
| static int | [MinimumCrossRoadCountInPath](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#ab1eb4c282d20c3b911f5df9214b829cd) = 2 |
| static int | [MaximumCrossRoadCountInPath](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a09d80a24a5d67ed0cbe6f1ca9bd4081b) = 10 |
| static int | [MinimumStandingGuardCountInPath](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a16917c78ea0f240f8b56747493feb859) = 5 |
| static int | [MaximumStandingGuardCountInPath](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a0d1f9c45f7e83e3c3981948fa8b6d696) = 50 |
| static float | [MinimumGuardSpawnPathRatio](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a985723f552c4ce0b6959a256ff0cd1bb) = 0.15f |
| static int | [MaximumLookBackPointCountInPath](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a64f91a4ca035d44cf69db9327e1d5fbe) |
| static int | [ScoreToAchieve](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#ad4c401deaea5f540a7da5973cdf1451b) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnEndMission](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a20e13a061e2d031c9c6e5ce323d22b80) () |
|  | Called right before the mission ends (i.e. after player clicks done/retreat button in battle results screen for SP missions). Preferably unregister all your Mission dependent events here. Some mission fields (like agent lists) will be deallocated after the mission ends. |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.MountAndBlade.MissionLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html) | |
| override [MissionBehaviorType](namespace_tale_worlds_1_1_mount_and_blade.html#a372fbfd8b3eae375d7fd2e0dcbb76993) | [BehaviorType](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html#a22dc913ab511b0a23db3e6a09b76fcd7) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html) | |
| Mission | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aa8057eb8e1718954a667dc0c9a334281) `[get]` |
| [IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html) | [DebugInput](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ac73ea22074a4d9e10f0018fda1a4c67c) `[get]` |
| [MissionBehaviorType](namespace_tale_worlds_1_1_mount_and_blade.html#a372fbfd8b3eae375d7fd2e0dcbb76993) | [BehaviorType](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aca34f7ade7fa89aba9d51c8330684cc5) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a843e89bb9ec59f2f496028dd6b4ef921)PointOfInterests
--------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [SandBox.Missions.MissionLogics.MissionPathGenerationLogic.PointOfInterests](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a843e89bb9ec59f2f496028dd6b4ef921) |

| Enumerator | |
| --- | --- |
| VisitPoint |  |
| CrossRoadPoint |  |
| GuardSpawnPoint |  |
| LookBackPoint |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a3dd170505da09aaca6734d05eee5df96)MissionPathGenerationLogic()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| SandBox.Missions.MissionLogics.MissionPathGenerationLogic.MissionPathGenerationLogic | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *defaultDisguiseCharacter* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a48270f969c3946371786e2b9ab51cb24)OnObjectUsed()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void SandBox.Missions.MissionLogics.MissionPathGenerationLogic.OnObjectUsed | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *userAgent*, | |  |  | [UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) | *usedObject* ) | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a3d381cb580df73e192ed90ca3b5748aa).

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a20e13a061e2d031c9c6e5ce323d22b80)OnEndMission()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.Missions.MissionLogics.MissionPathGenerationLogic.OnEndMission | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a2520fc88c264958b60ba7b75a4714117).

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#aa5632ef50306117731547180945477fe)InitializeBehavior()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.Missions.MissionLogics.MissionPathGenerationLogic.InitializeBehavior | ( |  | ) |  |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a0e6d4f00f17fa30e8492eaca02841760)OnMissionTick()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.Missions.MissionLogics.MissionPathGenerationLogic.OnMissionTick | ( | float | *dt* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a006b322c9ef8b55a1897419394c0a1e4).

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#ad6e205580990efbead2df2d55b3d74bc)GetAllPossiblePaths()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| List< [PointOfInterestScorePair](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_score_pair.html) > SandBox.Missions.MissionLogics.MissionPathGenerationLogic.GetAllPossiblePaths | ( |  | ) |  |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a2f15bcd8fda995ab5931f8d6e83fe403)IsOnLeftSide()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool SandBox.Missions.MissionLogics.MissionPathGenerationLogic.IsOnLeftSide | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *lineA*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *lineB*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *point* ) |

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a6dd5f5e2e2282c0b16a70b0e538b84f2)MinimumPathDistance
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.Missions.MissionLogics.MissionPathGenerationLogic.MinimumPathDistance = 200 | | static |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#adfe73089eeb5aa615ed6cd01637e03aa)MaximumPathDistance
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.Missions.MissionLogics.MissionPathGenerationLogic.MaximumPathDistance = 600 | | static |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#aaf15d8fac232110d3539bbc89cc2e2b5)MinimumDistanceToBlendPointToVisitPoint
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float SandBox.Missions.MissionLogics.MissionPathGenerationLogic.MinimumDistanceToBlendPointToVisitPoint = 5.0f |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a000ab76608666404bbdc412d38e2a58f)MinimumVisitPointCountInPath
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.Missions.MissionLogics.MissionPathGenerationLogic.MinimumVisitPointCountInPath = 2 | | static |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a6d89d0befb82d2e59836ae7538a9cf4b)MaximumVisitPointCountInPath
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.Missions.MissionLogics.MissionPathGenerationLogic.MaximumVisitPointCountInPath = 10 | | static |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#ab1eb4c282d20c3b911f5df9214b829cd)MinimumCrossRoadCountInPath
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.Missions.MissionLogics.MissionPathGenerationLogic.MinimumCrossRoadCountInPath = 2 | | static |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a09d80a24a5d67ed0cbe6f1ca9bd4081b)MaximumCrossRoadCountInPath
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.Missions.MissionLogics.MissionPathGenerationLogic.MaximumCrossRoadCountInPath = 10 | | static |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a16917c78ea0f240f8b56747493feb859)MinimumStandingGuardCountInPath
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.Missions.MissionLogics.MissionPathGenerationLogic.MinimumStandingGuardCountInPath = 5 | | static |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a0d1f9c45f7e83e3c3981948fa8b6d696)MaximumStandingGuardCountInPath
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.Missions.MissionLogics.MissionPathGenerationLogic.MaximumStandingGuardCountInPath = 50 | | static |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a985723f552c4ce0b6959a256ff0cd1bb)MinimumGuardSpawnPathRatio
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float SandBox.Missions.MissionLogics.MissionPathGenerationLogic.MinimumGuardSpawnPathRatio = 0.15f | | static |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a64f91a4ca035d44cf69db9327e1d5fbe)MaximumLookBackPointCountInPath
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.Missions.MissionLogics.MissionPathGenerationLogic.MaximumLookBackPointCountInPath | | static |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#ad4c401deaea5f540a7da5973cdf1451b)ScoreToAchieve
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.Missions.MissionLogics.MissionPathGenerationLogic.ScoreToAchieve | | static |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#ace1530e23ef0c0d33c477c976cf3de89)\_startAndFinishPointPool
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| List<[GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html)> SandBox.Missions.MissionLogics.MissionPathGenerationLogic.\_startAndFinishPointPool |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a062cb7507d566679e8dd98dd8a98e68b)CrossRoadMaximumDistance
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int SandBox.Missions.MissionLogics.MissionPathGenerationLogic.CrossRoadMaximumDistance = 30 |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a408e98716e5ba986e77a28b77c5d4d74)CrossRoadMinimumDistance
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int SandBox.Missions.MissionLogics.MissionPathGenerationLogic.CrossRoadMinimumDistance = 10 |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#ac55df0e65e49bdaa31846ad08e5c0ef9)MinimumVisitPointDistance
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int SandBox.Missions.MissionLogics.MissionPathGenerationLogic.MinimumVisitPointDistance = 10 |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a7716bd81afb47845911d5d41b4142e23)MaximumVisitPointDistance
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int SandBox.Missions.MissionLogics.MissionPathGenerationLogic.MaximumVisitPointDistance = 40 |

