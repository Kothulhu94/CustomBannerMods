--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html ---

TaleWorlds.MountAndBlade.MissionNetwork Class ReferenceabstractInherits [TaleWorlds.MountAndBlade.MissionLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html), and [TaleWorlds.MountAndBlade.IUdpNetworkHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html).

Inherited by [TaleWorlds.MountAndBlade.MissionLobbyComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html), [TaleWorlds.MountAndBlade.MissionLobbyEquipmentNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_equipment_network_component.html), [TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html), [TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBaseClient](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html), [TaleWorlds.MountAndBlade.MissionNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network_component.html), [TaleWorlds.MountAndBlade.MissionScoreboardComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html), [TaleWorlds.MountAndBlade.MultiplayerGameNotificationsComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_game_notifications_component.html), [TaleWorlds.MountAndBlade.MultiplayerMissionAgentVisualSpawnComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_mission_agent_visual_spawn_component.html), [TaleWorlds.MountAndBlade.MultiplayerPollComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_poll_component.html), [TaleWorlds.MountAndBlade.MultiplayerRoundComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_round_component.html), [TaleWorlds.MountAndBlade.MultiplayerRoundController](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_round_controller.html), [TaleWorlds.MountAndBlade.MultiplayerTeamSelectComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_team_select_component.html), [TaleWorlds.MountAndBlade.MultiplayerTimerComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_timer_component.html), [TaleWorlds.MountAndBlade.MultiplayerWarmupComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_warmup_component.html), and [TaleWorlds.MountAndBlade.VoiceChatHandler](class_tale_worlds_1_1_mount_and_blade_1_1_voice_chat_handler.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [OnAfterMissionCreated](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a9d0b9e4ba2af643fef12fb7f7b648942) () |
| override void | [OnBehaviorInitialize](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a47c1b54321184cca31fde7787386c3e8) () |
| override void | [OnRemoveBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a5a552a6c516ec896a485f06d830a7525) () |
| virtual void | [OnPlayerConnectedToServer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a7ae019a4fd1d6922c99a883a9fdb9ac8) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| virtual void | [OnPlayerDisconnectedFromServer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a331802321c1ab0c5e399a14522e49b4b) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
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
| virtual void | [OnFixedMissionTick](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aee013ab26ac67f4043a1b839112572a3) (float fixedDt) |
| virtual void | [OnPreMissionTick](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ac5f9da64f58e30eb4ef62a39596e1af7) (float dt) |
| virtual void | [OnPreDisplayMissionTick](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aca165ecaaa9e2c3e2c96219353678a3c) (float dt) |
| virtual void | [OnMissionTick](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a006b322c9ef8b55a1897419394c0a1e4) (float dt) |
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
| Protected Member Functions | |
| virtual void | [AddRemoveMessageHandlers](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#abb960ab4a133c9668ea1c80ced7abfdc) ([GameNetwork.NetworkMessageHandlerRegistererContainer](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer_container.html) registerer) |
| virtual void | [OnUdpNetworkHandlerTick](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a5c53bf86327084d6b36094652f9a8076) () |
| virtual void | [OnUdpNetworkHandlerClose](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a61aab8a2bbfe2e2bfbe70eb5646b02bd) () |
| virtual void | [HandleNewClientConnect](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a684b2bb60226f55ad7752a417fbdce56) ([PlayerConnectionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_player_connection_info.html) clientConnectionInfo) |
| virtual void | [HandleEarlyNewClientAfterLoadingFinished](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#ada8d7710e31d528e4b7d7d60fee10477) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| virtual void | [HandleNewClientAfterLoadingFinished](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a2ae30190712925d7a1a02b9b76810fe9) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| virtual void | [HandleLateNewClientAfterLoadingFinished](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#aa603feaeccf8eed50a2cb893e296d9a9) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| virtual void | [HandleNewClientAfterSynchronized](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a73a47ad2db0dedde69dd82c59400e58a) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| virtual void | [HandleLateNewClientAfterSynchronized](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#ab3ff3f8b34cff3bf3179abbd858838de) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| virtual void | [HandleEarlyPlayerDisconnect](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a6ad7aa76f0bd9635689a16ecf697f24f) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| virtual void | [HandlePlayerDisconnect](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a42028d84ad1a39843cb532731fa76e14) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html) | |
| virtual void | [OnEndMission](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a2520fc88c264958b60ba7b75a4714117) () |
|  | Called right before the mission ends (i.e. after player clicks done/retreat button in battle results screen for SP missions). Preferably unregister all your [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) dependent events here. Some mission fields (like agent lists) will be deallocated after the mission ends. |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.MountAndBlade.MissionLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html) | |
| override [MissionBehaviorType](namespace_tale_worlds_1_1_mount_and_blade.html#a372fbfd8b3eae375d7fd2e0dcbb76993) | [BehaviorType](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html#a22dc913ab511b0a23db3e6a09b76fcd7) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html) | |
| Mission | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aa8057eb8e1718954a667dc0c9a334281) `[get]` |
| [IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html) | [DebugInput](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ac73ea22074a4d9e10f0018fda1a4c67c) `[get]` |
| [MissionBehaviorType](namespace_tale_worlds_1_1_mount_and_blade.html#a372fbfd8b3eae375d7fd2e0dcbb76993) | [BehaviorType](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aca34f7ade7fa89aba9d51c8330684cc5) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a9d0b9e4ba2af643fef12fb7f7b648942)OnAfterMissionCreated()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MissionNetwork.OnAfterMissionCreated | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ad5b64f9606fcf2f88f9d2088d49de3d6).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a47c1b54321184cca31fde7787386c3e8)OnBehaviorInitialize()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MissionNetwork.OnBehaviorInitialize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a94e4fe46fad26b2a84dbbf3a4a5cc14c).

Reimplemented in [TaleWorlds.MountAndBlade.MissionNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network_component.html#a743c8cd9d1e126a85096744bbcb2ebd4), [TaleWorlds.MountAndBlade.MultiplayerPollComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_poll_component.html#ab687c843e0ab6dd04946036a848ed1b2), [TaleWorlds.MountAndBlade.MultiplayerTeamSelectComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_team_select_component.html#acf59ed62e4b00117aa79f3199afc44b8), [TaleWorlds.MountAndBlade.MultiplayerWarmupComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_warmup_component.html#afb95c3d1ee01a6033b129a924b21f5e7), and [TaleWorlds.MountAndBlade.VoiceChatHandler](class_tale_worlds_1_1_mount_and_blade_1_1_voice_chat_handler.html#a46dc937ca11c59bffbc91802360697f2).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a5a552a6c516ec896a485f06d830a7525)OnRemoveBehavior()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MissionNetwork.OnRemoveBehavior | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a80cb93b393ebaa09e4fd5fbab467556f).

Reimplemented in [TaleWorlds.MountAndBlade.MissionNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network_component.html#ab77b735680dc4bd7b27fd7ab2983150e), [TaleWorlds.MountAndBlade.MissionScoreboardComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#abb27dbe22b8905fa4a131ee1b3c433b9), [TaleWorlds.MountAndBlade.MultiplayerRoundController](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_round_controller.html#ae7ca0cfa695a1d23b6824fc5e4168aa0), [TaleWorlds.MountAndBlade.MultiplayerTeamSelectComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_team_select_component.html#ab138685ba8e03209aba8103abf0781c2), [TaleWorlds.MountAndBlade.MultiplayerWarmupComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_warmup_component.html#a343a4e0f8f1cd5b629c7e616118e886a), and [TaleWorlds.MountAndBlade.VoiceChatHandler](class_tale_worlds_1_1_mount_and_blade_1_1_voice_chat_handler.html#a749359aba5a20e047117e61fd77d8f9c).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#abb960ab4a133c9668ea1c80ced7abfdc)AddRemoveMessageHandlers()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MissionNetwork.AddRemoveMessageHandlers | ( | [GameNetwork.NetworkMessageHandlerRegistererContainer](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer_container.html) | *registerer* | ) |  | | protectedvirtual |

Reimplemented in [TaleWorlds.MountAndBlade.MissionLobbyComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#a6985fcf4a4d94937cae753f60a44585d), [TaleWorlds.MountAndBlade.MissionLobbyEquipmentNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_equipment_network_component.html#a49f19798debc4483db801d99f002d0df), [TaleWorlds.MountAndBlade.MissionMultiplayerDuel](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_duel.html#a775c1edce3027ad6bd35178bb277bf97), [TaleWorlds.MountAndBlade.MissionMultiplayerFlagDomination](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_flag_domination.html#a4291c3dcbab2df76fdedce3c50812c28), [TaleWorlds.MountAndBlade.MissionMultiplayerGameModeFlagDominationClient](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_flag_domination_client.html#ae8fd5c0e0d83ccbf687cf51e10779383), [TaleWorlds.MountAndBlade.MissionMultiplayerSiegeClient](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege_client.html#ab24bbc0a5ff06286592f519bdd8c1e95), [TaleWorlds.MountAndBlade.MissionMultiplayerTeamDeathmatchClient](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_team_deathmatch_client.html#a1c1032acbe06e801c70ddc3e814e46ba), [TaleWorlds.MountAndBlade.MissionNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network_component.html#a735c02b48c354dbfcde0814150386838), [TaleWorlds.MountAndBlade.MultiplayerGameNotificationsComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_game_notifications_component.html#a3fe0d9a1f8d2d407de95792fd1e0aae6), [TaleWorlds.MountAndBlade.MultiplayerPollComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_poll_component.html#aa2eb99d95c32d2761d7e9fda5998205f), [TaleWorlds.MountAndBlade.MultiplayerTeamSelectComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_team_select_component.html#a0607d9968145cdf4f5e12808c7991954), and [TaleWorlds.MountAndBlade.VoiceChatHandler](class_tale_worlds_1_1_mount_and_blade_1_1_voice_chat_handler.html#a97968b23caccceb6d8c043d91daba002).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a7ae019a4fd1d6922c99a883a9fdb9ac8)OnPlayerConnectedToServer()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MissionNetwork.OnPlayerConnectedToServer | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer* | ) |  | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.MissionScoreboardComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a3a2bb88d78287e575ac3613524e8368c).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a331802321c1ab0c5e399a14522e49b4b)OnPlayerDisconnectedFromServer()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MissionNetwork.OnPlayerDisconnectedFromServer | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer* | ) |  | | virtual |

Implements [TaleWorlds.MountAndBlade.IUdpNetworkHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#aa245a146f553ef5be8c85c57b64e9946).

Reimplemented in [TaleWorlds.MountAndBlade.MissionNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network_component.html#ab0b3ab12f5e25c5d481b83a5fb45681b), [TaleWorlds.MountAndBlade.MissionScoreboardComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a710a7b6356b8b3502770b4d1ea0db070), and [TaleWorlds.MountAndBlade.VoiceChatHandler](class_tale_worlds_1_1_mount_and_blade_1_1_voice_chat_handler.html#a7bd9c738aa0412bfc2c6b32de25bf264).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a5c53bf86327084d6b36094652f9a8076)OnUdpNetworkHandlerTick()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MissionNetwork.OnUdpNetworkHandlerTick | ( |  | ) |  | | protectedvirtual |

Reimplemented in [TaleWorlds.MountAndBlade.MissionLobbyComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#af68224279e3716a23ad00af8aa56094d).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a61aab8a2bbfe2e2bfbe70eb5646b02bd)OnUdpNetworkHandlerClose()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MissionNetwork.OnUdpNetworkHandlerClose | ( |  | ) |  | | protectedvirtual |

Implements [TaleWorlds.MountAndBlade.IUdpNetworkHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#ae3fc906a54e62648f39d1e157a706a09).

Reimplemented in [TaleWorlds.MountAndBlade.MissionLobbyComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#a454917317c2b983850f0e64fe7a8ca0b), [TaleWorlds.MountAndBlade.MultiplayerRoundComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_round_component.html#aa80b1e58206fcfb829fa68b55cdc48ba), [TaleWorlds.MountAndBlade.MultiplayerRoundController](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_round_controller.html#af8c93f99a5ddfafbf7cf4364b6e4741e), and [TaleWorlds.MountAndBlade.MultiplayerWarmupComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_warmup_component.html#af41bfa6d49f6f82a9eacadc9b85e02ce).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a684b2bb60226f55ad7752a417fbdce56)HandleNewClientConnect()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MissionNetwork.HandleNewClientConnect | ( | [PlayerConnectionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_player_connection_info.html) | *clientConnectionInfo* | ) |  | | protectedvirtual |

Implements [TaleWorlds.MountAndBlade.IUdpNetworkHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#a2577e2329e028a06ff6fe4deb3c5b06f).

Reimplemented in [TaleWorlds.MountAndBlade.MissionLobbyComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#a57a22b29f081c799cc95de1669f209b2), and [TaleWorlds.MountAndBlade.MultiplayerGameNotificationsComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_game_notifications_component.html#ace06bdc251cf4b606c005fb003e56591).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#ada8d7710e31d528e4b7d7d60fee10477)HandleEarlyNewClientAfterLoadingFinished()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MissionNetwork.HandleEarlyNewClientAfterLoadingFinished | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer* | ) |  | | protectedvirtual |

Implements [TaleWorlds.MountAndBlade.IUdpNetworkHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#a4c381999e9264f3c0c95dcf609d594ba).

Reimplemented in [TaleWorlds.MountAndBlade.MissionMultiplayerDuel](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_duel.html#afed58b68447f15d604fda7730ed32651), [TaleWorlds.MountAndBlade.MissionMultiplayerFlagDomination](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_flag_domination.html#ada3d0236ba5226c1b8e365c0bb4935e7), [TaleWorlds.MountAndBlade.MissionMultiplayerSiege](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#ab601a5921633cb2fc2fac8c1082307ce), [TaleWorlds.MountAndBlade.MissionMultiplayerTeamDeathmatch](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_team_deathmatch.html#aede172103e06028cc584b2e632dc44b1), and [TaleWorlds.MountAndBlade.MissionNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network_component.html#abf530eccd6698792eee860a641ba18db).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a2ae30190712925d7a1a02b9b76810fe9)HandleNewClientAfterLoadingFinished()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MissionNetwork.HandleNewClientAfterLoadingFinished | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer* | ) |  | | protectedvirtual |

Implements [TaleWorlds.MountAndBlade.IUdpNetworkHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#a9a8829a2fd74b36209b4dcc787828da9).

Reimplemented in [TaleWorlds.MountAndBlade.MissionMultiplayerFlagDomination](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_flag_domination.html#a2cdf8faa59502be4374ee1e8ba15ac18), and [TaleWorlds.MountAndBlade.MissionMultiplayerSiege](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#ac79fafd46c6ee8193eabdbd74f60ec4f).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#aa603feaeccf8eed50a2cb893e296d9a9)HandleLateNewClientAfterLoadingFinished()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MissionNetwork.HandleLateNewClientAfterLoadingFinished | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer* | ) |  | | protectedvirtual |

Implements [TaleWorlds.MountAndBlade.IUdpNetworkHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#a00899e99b4f3d538040e38c98963d272).

Reimplemented in [TaleWorlds.MountAndBlade.MissionLobbyComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#a0e64052a5d2ea09cc3bafedddf3df61c), [TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#a62f7c0c25923498d662dc865ea95fed1), [TaleWorlds.MountAndBlade.MissionNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network_component.html#a0b57e2b28835c73fc66d797777b79801), and [TaleWorlds.MountAndBlade.MultiplayerRoundController](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_round_controller.html#a8d40429a3a7f0af8b9508c0ac612bed3).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a73a47ad2db0dedde69dd82c59400e58a)HandleNewClientAfterSynchronized()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MissionNetwork.HandleNewClientAfterSynchronized | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer* | ) |  | | protectedvirtual |

Implements [TaleWorlds.MountAndBlade.IUdpNetworkHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#ac2ef1acaf956501169a85e41aa58b369).

Reimplemented in [TaleWorlds.MountAndBlade.MissionMultiplayerDuel](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_duel.html#ab0e01d5b2cdd9d803dde5dbadf2ab794), [TaleWorlds.MountAndBlade.MissionMultiplayerFlagDomination](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_flag_domination.html#a5b2c6c22bf6f2ede034461d85c2604b6), [TaleWorlds.MountAndBlade.MissionMultiplayerSiege](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#aaa0e8b299d8786d8b1372881a45362e8), [TaleWorlds.MountAndBlade.MissionMultiplayerTeamDeathmatch](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_team_deathmatch.html#a073731555c881e842a521ea52d4838f5), [TaleWorlds.MountAndBlade.MultiplayerRoundController](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_round_controller.html#a78651e487efe4a9e2ff6e5704230a9d5), [TaleWorlds.MountAndBlade.MultiplayerWarmupComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_warmup_component.html#ae7e4da04dfdcbc81dc9d08a2b1a92a15), and [TaleWorlds.MountAndBlade.VoiceChatHandler](class_tale_worlds_1_1_mount_and_blade_1_1_voice_chat_handler.html#a078505a90cd2c16df103b450b606d9f3).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#ab3ff3f8b34cff3bf3179abbd858838de)HandleLateNewClientAfterSynchronized()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MissionNetwork.HandleLateNewClientAfterSynchronized | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer* | ) |  | | protectedvirtual |

Implements [TaleWorlds.MountAndBlade.IUdpNetworkHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#ac061ef8f78a1583556d9a5d665a6a2e3).

Reimplemented in [TaleWorlds.MountAndBlade.MissionMultiplayerDuel](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_duel.html#acde723ea5ce90d93d8bcb1adbd916249), and [TaleWorlds.MountAndBlade.MissionScoreboardComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a9280137702bc824ef490bfa22e429a5e).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a6ad7aa76f0bd9635689a16ecf697f24f)HandleEarlyPlayerDisconnect()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MissionNetwork.HandleEarlyPlayerDisconnect | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer* | ) |  | | protectedvirtual |

Implements [TaleWorlds.MountAndBlade.IUdpNetworkHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#a3ef5a3685329e9e47e0d95a91dd449b1).

Reimplemented in [TaleWorlds.MountAndBlade.MissionMultiplayerDuel](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_duel.html#a18000e1a9d2457ff4ac960fad37f1907), [TaleWorlds.MountAndBlade.MissionMultiplayerFlagDomination](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_flag_domination.html#a812a55b6cb5a010f5f5cc6244ddc377d), and [TaleWorlds.MountAndBlade.MissionNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network_component.html#a113618bb716c8bb74ce41367cd4436af).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a42028d84ad1a39843cb532731fa76e14)HandlePlayerDisconnect()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MissionNetwork.HandlePlayerDisconnect | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer* | ) |  | | protectedvirtual |

Implements [TaleWorlds.MountAndBlade.IUdpNetworkHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#a415d85f8a29658fc85163947b9c70a6d).

Reimplemented in [TaleWorlds.MountAndBlade.MissionMultiplayerDuel](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_duel.html#aea9cfee6a622fa4078c7f6d0d675a1ec), [TaleWorlds.MountAndBlade.MissionNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network_component.html#af226ba628ba092b6bcd2c5e3e927527d), and [TaleWorlds.MountAndBlade.MultiplayerGameNotificationsComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_game_notifications_component.html#a97b22c8c2862e953a97b3fc4b38e7081).

