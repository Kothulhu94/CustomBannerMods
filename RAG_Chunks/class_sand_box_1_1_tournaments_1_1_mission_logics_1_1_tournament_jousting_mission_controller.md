--- SOURCE: class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html ---

SandBox.Tournaments.MissionLogics.TournamentJoustingMissionController Class ReferenceInherits [TaleWorlds.MountAndBlade.MissionLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html), and [SandBox.Tournaments.ITournamentGameBehavior](interface_sand_box_1_1_tournaments_1_1_i_tournament_game_behavior.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| delegate void | [JoustingEventDelegate](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#aac6b496599990dab5ad6fab92f8906bb) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectedAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectorAgent) |
| delegate void | [JoustingAgentStateChangedEventDelegate](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#aa7fa38522942b0f256a290670d36b3ad) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [JoustingAgentController.JoustingAgentState](class_sand_box_1_1_tournaments_1_1_agent_controllers_1_1_jousting_agent_controller.html#af7e9f905aa6c13554518cbc682cb920f) state) |
|  | [TournamentJoustingMissionController](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#a6bc81a57a53a4fba0b356ba23166352f) ([CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) culture) |
| override void | [AfterStart](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#a289370ed1c9007fde2b0dde204dd0afc) () |
| void | [StartMatch](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#aa7e0a5e65c3b386aa86c51c8faf2e054) ([TournamentMatch](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html) match, bool isLastRound) |
| void | [SkipMatch](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#a72cc3d072563d41210015f87141005cc) ([TournamentMatch](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html) match) |
| bool | [IsMatchEnded](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#ae6f7b75b0862ccd84e29f46538ff2435) () |
| void | [OnMatchEnded](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#a147c9dce4514ed816a830a18938c2593) () |
| bool | [IsAgentInTheTrack](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#a7ddc72c6bb0533ff89975a409f246dc3) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, bool inCurrentTrack=true) |
| override void | [OnMissionTick](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#a1b9600dcc75815219052109165c2f1c3) (float dt) |
|  | This function is called once in every frame. |
| override void | [OnAgentHit](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#a37bc75d519b70e365197567f61fd0337) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectedAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectorAgent, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) attackerWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) attackCollisionData) |
| override void | [OnAgentRemoved](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#a266da7f0b27ac5447d6f73ca210720e3) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectedAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectorAgent, [AgentState](namespace_tale_worlds_1_1_core.html#a799bcc77ddb6372c7383f3340ed4d1c0) agentState, [KillingBlow](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html) killingBlow) |
| void | [OnJoustingAgentStateChanged](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#a06524c8c3961ef8859193544019ea6c3) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [JoustingAgentController.JoustingAgentState](class_sand_box_1_1_tournaments_1_1_agent_controllers_1_1_jousting_agent_controller.html#af7e9f905aa6c13554518cbc682cb920f) state) |
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
| virtual void | [OnMissileHit](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a6d83e4fa1f6e1167b130b82a782566b1) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attacker, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victim, bool isCanceled, [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData) |
| virtual void | [OnMeleeHit](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ae67852af54716d6087e05eec594e21ef) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attacker, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victim, bool isCanceled, [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData) |
| virtual void | [OnMissileCollisionReaction](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a6dab0fd5a10bef3110a51af4176028d8) ([Mission.MissileCollisionReaction](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a235275d0a4fd9f604f19aaaf6943e494) collisionReaction, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attachedAgent, sbyte attachedBoneIndex) |
| virtual void | [OnMissionScreenPreLoad](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a9e8c61bb3fa009704236d5b9fced2c74) () |
| virtual void | [OnAgentCreated](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#af4505c65ad5f3f5ac6ec4b766f7aa203) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| virtual void | [OnAgentBuild](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ad610eac3ce9064919cb8771652a5da4e) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [Banner](class_tale_worlds_1_1_core_1_1_banner.html) banner) |
| virtual void | [OnAgentTeamChanged](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ae82c2110c9b50bf8c08030847c896275) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) prevTeam, [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) newTeam, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| virtual void | [OnAgentControllerSetToPlayer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a3cbbc0856767f6975fc137a83480c71a) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| virtual void | [OnScoreHit](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a47a0a0aafce4f2bc5bca00fa1410e539) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectedAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectorAgent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, bool isBlocked, bool isSiegeEngineHit, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, float damagedHp, float hitDistance, float shotDifficulty) |
| virtual void | [OnEarlyAgentRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a2357313c6773cd404fea1d097c94a165) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectedAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectorAgent, [AgentState](namespace_tale_worlds_1_1_core.html#a799bcc77ddb6372c7383f3340ed4d1c0) agentState, [KillingBlow](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html) blow) |
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
| Public Attributes | |
| List< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > | [RegionBoxList](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#a97c41a7c0dbc4d5f80585923fdae341c) |
| List< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > | [RegionExitBoxList](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#a0f626c7cc150a9222b1ea5fe4229e7f0) |
| List< [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) > | [CornerBackStartList](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#a5ae9c88d793f2deeced9b69a94699fa4) |
| List< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > | [CornerStartList](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#a09028fe87042c44f9bb1442b669b6197) |
| List< [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) > | [CornerMiddleList](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#a9f089f2490ff1a2a82f0b4765c26dc39) |
| List< [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) > | [CornerFinishList](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#a84dec69ad0a4e138a1ff2f6eb97016dd) |
| bool | [IsSwordDuelStarted](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#a38c55d108e9e575205a70210686f7fe0) |

|  |  |
| --- | --- |
| Events | |
| [JoustingEventDelegate](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#aac6b496599990dab5ad6fab92f8906bb) | [VictoryAchieved](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#a54470743429f2437ff3ee901bddd8970) |
| [JoustingEventDelegate](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#aac6b496599990dab5ad6fab92f8906bb) | [PointGanied](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#a516bc65dd2f47da7826f36c69769c3b6) |
| [JoustingEventDelegate](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#aac6b496599990dab5ad6fab92f8906bb) | [Disqualified](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#a7aee33922196e6abdbab4bfbbbc80fb7) |
| [JoustingEventDelegate](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#aac6b496599990dab5ad6fab92f8906bb) | [Unconscious](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#a16ca6a3a9ab0ebfe2e2a152b2cc515b9) |
| [JoustingAgentStateChangedEventDelegate](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#aa7fa38522942b0f256a290670d36b3ad) | [AgentStateChanged](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#ae223573439cec17b0b9f0f348ccf7f04) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html) | |
| virtual void | [OnEndMission](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a2520fc88c264958b60ba7b75a4714117) () |
|  | Called right before the mission ends (i.e. after player clicks done/retreat button in battle results screen for SP missions). Preferably unregister all your [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) dependent events here. Some mission fields (like agent lists) will be deallocated after the mission ends. |
| Properties inherited from [TaleWorlds.MountAndBlade.MissionLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html) | |
| override [MissionBehaviorType](namespace_tale_worlds_1_1_mount_and_blade.html#a372fbfd8b3eae375d7fd2e0dcbb76993) | [BehaviorType](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html#a22dc913ab511b0a23db3e6a09b76fcd7) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html) | |
| Mission | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aa8057eb8e1718954a667dc0c9a334281) `[get]` |
| [IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html) | [DebugInput](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ac73ea22074a4d9e10f0018fda1a4c67c) `[get]` |
| [MissionBehaviorType](namespace_tale_worlds_1_1_mount_and_blade.html#a372fbfd8b3eae375d7fd2e0dcbb76993) | [BehaviorType](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aca34f7ade7fa89aba9d51c8330684cc5) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#a6bc81a57a53a4fba0b356ba23166352f)TournamentJoustingMissionController()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| SandBox.Tournaments.MissionLogics.TournamentJoustingMissionController.TournamentJoustingMissionController | ( | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | *culture* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#aac6b496599990dab5ad6fab92f8906bb)JoustingEventDelegate()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate void SandBox.Tournaments.MissionLogics.TournamentJoustingMissionController.JoustingEventDelegate | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *affectedAgent*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *affectorAgent* ) |

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#aa7fa38522942b0f256a290670d36b3ad)JoustingAgentStateChangedEventDelegate()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate void SandBox.Tournaments.MissionLogics.TournamentJoustingMissionController.JoustingAgentStateChangedEventDelegate | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | [JoustingAgentController.JoustingAgentState](class_sand_box_1_1_tournaments_1_1_agent_controllers_1_1_jousting_agent_controller.html#af7e9f905aa6c13554518cbc682cb920f) | *state* ) |

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#a289370ed1c9007fde2b0dde204dd0afc)AfterStart()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.Tournaments.MissionLogics.TournamentJoustingMissionController.AfterStart | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a693295e26d8b0fcf634c52b1c08fd974).

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#aa7e0a5e65c3b386aa86c51c8faf2e054)StartMatch()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.Tournaments.MissionLogics.TournamentJoustingMissionController.StartMatch | ( | [TournamentMatch](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html) | *match*, |
|  |  | bool | *isLastRound* ) |

Implements [SandBox.Tournaments.ITournamentGameBehavior](interface_sand_box_1_1_tournaments_1_1_i_tournament_game_behavior.html#ac5643da94fdafc656b12114f3ceef49b).

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#a72cc3d072563d41210015f87141005cc)SkipMatch()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.Tournaments.MissionLogics.TournamentJoustingMissionController.SkipMatch | ( | [TournamentMatch](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html) | *match* | ) |  |

Implements [SandBox.Tournaments.ITournamentGameBehavior](interface_sand_box_1_1_tournaments_1_1_i_tournament_game_behavior.html#a7a0ee090e74a072417c9f3ce00bc653f).

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#ae6f7b75b0862ccd84e29f46538ff2435)IsMatchEnded()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool SandBox.Tournaments.MissionLogics.TournamentJoustingMissionController.IsMatchEnded | ( |  | ) |  |

Implements [SandBox.Tournaments.ITournamentGameBehavior](interface_sand_box_1_1_tournaments_1_1_i_tournament_game_behavior.html#ad30da905f5159eb7cb5553a415bcc9eb).

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#a147c9dce4514ed816a830a18938c2593)OnMatchEnded()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.Tournaments.MissionLogics.TournamentJoustingMissionController.OnMatchEnded | ( |  | ) |  |

Implements [SandBox.Tournaments.ITournamentGameBehavior](interface_sand_box_1_1_tournaments_1_1_i_tournament_game_behavior.html#a0c303ce7e640229731602a6f945a5a45).

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#a7ddc72c6bb0533ff89975a409f246dc3)IsAgentInTheTrack()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool SandBox.Tournaments.MissionLogics.TournamentJoustingMissionController.IsAgentInTheTrack | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | bool | *inCurrentTrack* = true ) |

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#a1b9600dcc75815219052109165c2f1c3)OnMissionTick()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.Tournaments.MissionLogics.TournamentJoustingMissionController.OnMissionTick | ( | float | *dt* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a006b322c9ef8b55a1897419394c0a1e4).

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#a37bc75d519b70e365197567f61fd0337)OnAgentHit()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void SandBox.Tournaments.MissionLogics.TournamentJoustingMissionController.OnAgentHit | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *affectedAgent*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *affectorAgent*, | |  |  | in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *attackerWeapon*, | |  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow*, | |  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *attackCollisionData* ) | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a2ca3ef8b8c9419285565e1443873345d).

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#a266da7f0b27ac5447d6f73ca210720e3)OnAgentRemoved()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void SandBox.Tournaments.MissionLogics.TournamentJoustingMissionController.OnAgentRemoved | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *affectedAgent*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *affectorAgent*, | |  |  | [AgentState](namespace_tale_worlds_1_1_core.html#a799bcc77ddb6372c7383f3340ed4d1c0) | *agentState*, | |  |  | [KillingBlow](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html) | *killingBlow* ) | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ad4987b5b5e719f90cad1856b8c0b7976).

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#a06524c8c3961ef8859193544019ea6c3)OnJoustingAgentStateChanged()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.Tournaments.MissionLogics.TournamentJoustingMissionController.OnJoustingAgentStateChanged | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | [JoustingAgentController.JoustingAgentState](class_sand_box_1_1_tournaments_1_1_agent_controllers_1_1_jousting_agent_controller.html#af7e9f905aa6c13554518cbc682cb920f) | *state* ) |

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#a97c41a7c0dbc4d5f80585923fdae341c)RegionBoxList
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| List<[GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html)> SandBox.Tournaments.MissionLogics.TournamentJoustingMissionController.RegionBoxList |

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#a0f626c7cc150a9222b1ea5fe4229e7f0)RegionExitBoxList
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| List<[GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html)> SandBox.Tournaments.MissionLogics.TournamentJoustingMissionController.RegionExitBoxList |

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#a5ae9c88d793f2deeced9b69a94699fa4)CornerBackStartList
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| List<[MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html)> SandBox.Tournaments.MissionLogics.TournamentJoustingMissionController.CornerBackStartList |

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#a09028fe87042c44f9bb1442b669b6197)CornerStartList
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| List<[GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html)> SandBox.Tournaments.MissionLogics.TournamentJoustingMissionController.CornerStartList |

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#a9f089f2490ff1a2a82f0b4765c26dc39)CornerMiddleList
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| List<[MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html)> SandBox.Tournaments.MissionLogics.TournamentJoustingMissionController.CornerMiddleList |

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#a84dec69ad0a4e138a1ff2f6eb97016dd)CornerFinishList
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| List<[MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html)> SandBox.Tournaments.MissionLogics.TournamentJoustingMissionController.CornerFinishList |

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#a38c55d108e9e575205a70210686f7fe0)IsSwordDuelStarted
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool SandBox.Tournaments.MissionLogics.TournamentJoustingMissionController.IsSwordDuelStarted |

Event Documentation
-------------------

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#a54470743429f2437ff3ee901bddd8970)VictoryAchieved
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [JoustingEventDelegate](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#aac6b496599990dab5ad6fab92f8906bb) SandBox.Tournaments.MissionLogics.TournamentJoustingMissionController.VictoryAchieved |

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#a516bc65dd2f47da7826f36c69769c3b6)PointGanied
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [JoustingEventDelegate](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#aac6b496599990dab5ad6fab92f8906bb) SandBox.Tournaments.MissionLogics.TournamentJoustingMissionController.PointGanied |

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#a7aee33922196e6abdbab4bfbbbc80fb7)Disqualified
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [JoustingEventDelegate](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#aac6b496599990dab5ad6fab92f8906bb) SandBox.Tournaments.MissionLogics.TournamentJoustingMissionController.Disqualified |

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#a16ca6a3a9ab0ebfe2e2a152b2cc515b9)Unconscious
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [JoustingEventDelegate](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#aac6b496599990dab5ad6fab92f8906bb) SandBox.Tournaments.MissionLogics.TournamentJoustingMissionController.Unconscious |

[◆](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#ae223573439cec17b0b9f0f348ccf7f04)AgentStateChanged
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [JoustingAgentStateChangedEventDelegate](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#aa7fa38522942b0f256a290670d36b3ad) SandBox.Tournaments.MissionLogics.TournamentJoustingMissionController.AgentStateChanged |

