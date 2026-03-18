--- SOURCE: class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html ---

SandBox.Missions.MissionLogics.DisguiseMissionLogic Class ReferenceInherits [TaleWorlds.MountAndBlade.MissionLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html), and [TaleWorlds.MountAndBlade.IPlayerInputEffector](interface_tale_worlds_1_1_mount_and_blade_1_1_i_player_input_effector.html).

|  |  |
| --- | --- |
| Classes | |
| class | [ShadowingAgentOffenseInfo](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic_1_1_shadowing_agent_offense_info.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [DisguiseMissionLogic](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#a04c0eb409d37f6de786c9af4e9bddfc6) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) contractorCharacter, [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) fromLocation, bool willSetUpContact) |
| override void | [OnCreated](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#a3529222110d913fd60c99d7cc5f1370b) () |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetSpawnFrameOfPassage](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#ab4cb947805b8c098c7b1429964439f99) ([Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) location) |
| bool | [IsContactAgentTracked](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#a3cc0710662f52365801ffa26e4966f75) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| bool | [CanCommonAreaFightBeTriggered](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#ae58b3f747b0d542c9376232465bb62f4) () |
| bool | [IsOnLeftSide](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#a3d0bc6b1d2a85b7be7b3e2a3381ac402) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) lineA, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) lineB, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) point) |
| override void | [OnAgentBuild](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#a812119e322b470f82beafd59b122a8fb) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [Banner](class_tale_worlds_1_1_core_1_1_banner.html) banner) |
| override void | [OnAgentRemoved](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#a0dbb0c313ac4352d547f75a57aa8a07f) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectedAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectorAgent, [AgentState](namespace_tale_worlds_1_1_core.html#a799bcc77ddb6372c7383f3340ed4d1c0) agentState, [KillingBlow](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html) blow) |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [SpawnDisguiseMissionAgentInternal](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#a1af29b20bce07d20dac9c30d7c341458) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) agentCharacter, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) initialPosition, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) initialDirection, string actionSetId, bool isEnemy=true) |
| override void | [OnMissionTick](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#a50dc33f5e034a03c094d8863754b1bb5) (float dt) |
| [ShadowingAgentOffenseInfo](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic_1_1_shadowing_agent_offense_info.html) | [GetAgentOffenseInfo](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#a89e9df8cf084adcdc1d6b1f6a0b31e4d) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| bool | [IsAgentInDetectionRadius](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#a6a9eff5c06ed0a17e34085cd2adc4298) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) offenderAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) detectorAgent) |
| override [InquiryData](class_tale_worlds_1_1_library_1_1_inquiry_data.html) | [OnEndMissionRequest](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#a8dbaf6297e63c4aec01eed4b58a0dcbb) (out bool canPlayerLeave) |
| EventControlFlag | [OnCollectPlayerEventControlFlags](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#a44284aaf3773e32ec67898a939256dfd) () |
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
| virtual void | [EarlyStart](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a3bd04d1aa2eb7f76f6c269d9f97e3fbd) () |
| virtual void | [AfterStart](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a693295e26d8b0fcf634c52b1c08fd974) () |
| virtual void | [OnMissileHit](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a6d83e4fa1f6e1167b130b82a782566b1) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attacker, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victim, bool isCanceled, [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData) |
| virtual void | [OnMeleeHit](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ae67852af54716d6087e05eec594e21ef) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attacker, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victim, bool isCanceled, [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData) |
| virtual void | [OnMissileCollisionReaction](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a6dab0fd5a10bef3110a51af4176028d8) ([Mission.MissileCollisionReaction](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a235275d0a4fd9f604f19aaaf6943e494) collisionReaction, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attachedAgent, sbyte attachedBoneIndex) |
| virtual void | [OnMissionScreenPreLoad](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a9e8c61bb3fa009704236d5b9fced2c74) () |
| virtual void | [OnAgentCreated](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#af4505c65ad5f3f5ac6ec4b766f7aa203) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| virtual void | [OnAgentTeamChanged](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ae82c2110c9b50bf8c08030847c896275) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) prevTeam, [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) newTeam, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| virtual void | [OnAgentControllerSetToPlayer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a3cbbc0856767f6975fc137a83480c71a) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| virtual void | [OnAgentHit](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a2ca3ef8b8c9419285565e1443873345d) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectedAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectorAgent, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) affectorWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) attackCollisionData) |
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
| float | [PlayerSuspiciousLevel](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#a412fd9f3c09e90ba6c97e06e47d8ac70) = 0 |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const float | [PlayerSuspiciousLevelMin](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#a8ea332087e7faef2d0b80ff8d7e92f78) = 0.0f |
| const float | [PlayerSuspiciousLevelMax](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#ab3eda095b188edb92cd60815bbab653e) = 1.0f |
| const float | [ToggleStealthModeSuspiciousThreshold](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#a08f102c54f1c1b5258447bbb4bc50821) = 0.95f |
| const float | [MissionFailDistanceToTargetAgent](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#afb2788377f997ec29029329e3d28c820) = 5000.0f |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnEndMission](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#a317386d03809b7d1215a7c29a46924ae) () |
|  | Called right before the mission ends (i.e. after player clicks done/retreat button in battle results screen for SP missions). Preferably unregister all your Mission dependent events here. Some mission fields (like agent lists) will be deallocated after the mission ends. |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsInStealthMode](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#a7e9c137958046d07e6de9b44bf0ce725) `[get]` |
| ReadOnlyDictionary< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), [ShadowingAgentOffenseInfo](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic_1_1_shadowing_agent_offense_info.html) > | [ThreatAgentInfos](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#a691bd9d282de1e6b279248e8458ebd49) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.MissionLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html) | |
| override [MissionBehaviorType](namespace_tale_worlds_1_1_mount_and_blade.html#a372fbfd8b3eae375d7fd2e0dcbb76993) | [BehaviorType](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html#a22dc913ab511b0a23db3e6a09b76fcd7) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html) | |
| Mission | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aa8057eb8e1718954a667dc0c9a334281) `[get]` |
| [IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html) | [DebugInput](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ac73ea22074a4d9e10f0018fda1a4c67c) `[get]` |
| [MissionBehaviorType](namespace_tale_worlds_1_1_mount_and_blade.html#a372fbfd8b3eae375d7fd2e0dcbb76993) | [BehaviorType](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aca34f7ade7fa89aba9d51c8330684cc5) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#a04c0eb409d37f6de786c9af4e9bddfc6)DisguiseMissionLogic()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| SandBox.Missions.MissionLogics.DisguiseMissionLogic.DisguiseMissionLogic | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *contractorCharacter*, |
|  |  | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | *fromLocation*, |
|  |  | bool | *willSetUpContact* ) |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#a3529222110d913fd60c99d7cc5f1370b)OnCreated()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.Missions.MissionLogics.DisguiseMissionLogic.OnCreated | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a29e57cd652228fc81feee9a78a31121f).

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#ab4cb947805b8c098c7b1429964439f99)GetSpawnFrameOfPassage()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) SandBox.Missions.MissionLogics.DisguiseMissionLogic.GetSpawnFrameOfPassage | ( | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | *location* | ) |  |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#a3cc0710662f52365801ffa26e4966f75)IsContactAgentTracked()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool SandBox.Missions.MissionLogics.DisguiseMissionLogic.IsContactAgentTracked | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#ae58b3f747b0d542c9376232465bb62f4)CanCommonAreaFightBeTriggered()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool SandBox.Missions.MissionLogics.DisguiseMissionLogic.CanCommonAreaFightBeTriggered | ( |  | ) |  |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#a3d0bc6b1d2a85b7be7b3e2a3381ac402)IsOnLeftSide()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool SandBox.Missions.MissionLogics.DisguiseMissionLogic.IsOnLeftSide | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *lineA*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *lineB*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *point* ) |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#a812119e322b470f82beafd59b122a8fb)OnAgentBuild()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void SandBox.Missions.MissionLogics.DisguiseMissionLogic.OnAgentBuild | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | [Banner](class_tale_worlds_1_1_core_1_1_banner.html) | *banner* ) | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ad610eac3ce9064919cb8771652a5da4e).

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#a0dbb0c313ac4352d547f75a57aa8a07f)OnAgentRemoved()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void SandBox.Missions.MissionLogics.DisguiseMissionLogic.OnAgentRemoved | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *affectedAgent*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *affectorAgent*, | |  |  | [AgentState](namespace_tale_worlds_1_1_core.html#a799bcc77ddb6372c7383f3340ed4d1c0) | *agentState*, | |  |  | [KillingBlow](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html) | *blow* ) | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ad4987b5b5e719f90cad1856b8c0b7976).

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#a317386d03809b7d1215a7c29a46924ae)OnEndMission()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.Missions.MissionLogics.DisguiseMissionLogic.OnEndMission | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a2520fc88c264958b60ba7b75a4714117).

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#a1af29b20bce07d20dac9c30d7c341458)SpawnDisguiseMissionAgentInternal()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) SandBox.Missions.MissionLogics.DisguiseMissionLogic.SpawnDisguiseMissionAgentInternal | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *agentCharacter*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *initialPosition*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *initialDirection*, |
|  |  | string | *actionSetId*, |
|  |  | bool | *isEnemy* = true ) |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#a50dc33f5e034a03c094d8863754b1bb5)OnMissionTick()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.Missions.MissionLogics.DisguiseMissionLogic.OnMissionTick | ( | float | *dt* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a006b322c9ef8b55a1897419394c0a1e4).

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#a89e9df8cf084adcdc1d6b1f6a0b31e4d)GetAgentOffenseInfo()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [ShadowingAgentOffenseInfo](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic_1_1_shadowing_agent_offense_info.html) SandBox.Missions.MissionLogics.DisguiseMissionLogic.GetAgentOffenseInfo | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#a6a9eff5c06ed0a17e34085cd2adc4298)IsAgentInDetectionRadius()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool SandBox.Missions.MissionLogics.DisguiseMissionLogic.IsAgentInDetectionRadius | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *offenderAgent*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *detectorAgent* ) |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#a8dbaf6297e63c4aec01eed4b58a0dcbb)OnEndMissionRequest()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override [InquiryData](class_tale_worlds_1_1_library_1_1_inquiry_data.html) SandBox.Missions.MissionLogics.DisguiseMissionLogic.OnEndMissionRequest | ( | out bool | *canPlayerLeave* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html#a9373241b87874466fbb93f73f44acc83).

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#a44284aaf3773e32ec67898a939256dfd)OnCollectPlayerEventControlFlags()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| EventControlFlag SandBox.Missions.MissionLogics.DisguiseMissionLogic.OnCollectPlayerEventControlFlags | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IPlayerInputEffector](interface_tale_worlds_1_1_mount_and_blade_1_1_i_player_input_effector.html#a0ccd5aa011415545ca540be38c48ae41).

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#a8ea332087e7faef2d0b80ff8d7e92f78)PlayerSuspiciousLevelMin
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float SandBox.Missions.MissionLogics.DisguiseMissionLogic.PlayerSuspiciousLevelMin = 0.0f | | static |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#ab3eda095b188edb92cd60815bbab653e)PlayerSuspiciousLevelMax
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float SandBox.Missions.MissionLogics.DisguiseMissionLogic.PlayerSuspiciousLevelMax = 1.0f | | static |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#a08f102c54f1c1b5258447bbb4bc50821)ToggleStealthModeSuspiciousThreshold
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float SandBox.Missions.MissionLogics.DisguiseMissionLogic.ToggleStealthModeSuspiciousThreshold = 0.95f | | static |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#afb2788377f997ec29029329e3d28c820)MissionFailDistanceToTargetAgent
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float SandBox.Missions.MissionLogics.DisguiseMissionLogic.MissionFailDistanceToTargetAgent = 5000.0f | | static |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#a412fd9f3c09e90ba6c97e06e47d8ac70)PlayerSuspiciousLevel
------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float SandBox.Missions.MissionLogics.DisguiseMissionLogic.PlayerSuspiciousLevel = 0 |

Property Documentation
----------------------

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#a7e9c137958046d07e6de9b44bf0ce725)IsInStealthMode
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.Missions.MissionLogics.DisguiseMissionLogic.IsInStealthMode | | get |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic.html#a691bd9d282de1e6b279248e8458ebd49)ThreatAgentInfos
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ReadOnlyDictionary<[Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), [ShadowingAgentOffenseInfo](class_sand_box_1_1_missions_1_1_mission_logics_1_1_disguise_mission_logic_1_1_shadowing_agent_offense_info.html)> SandBox.Missions.MissionLogics.DisguiseMissionLogic.ThreatAgentInfos | | get |

