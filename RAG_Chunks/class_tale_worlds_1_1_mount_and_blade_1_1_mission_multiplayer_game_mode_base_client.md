--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html ---

TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBaseClient Class ReferenceabstractInherits [TaleWorlds.MountAndBlade.MissionNetwork](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html), and [TaleWorlds.Core.ICameraModeLogic](interface_tale_worlds_1_1_core_1_1_i_camera_mode_logic.html).

Inherited by [TaleWorlds.MountAndBlade.MissionMultiplayerGameModeDuelClient](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_duel_client.html), [TaleWorlds.MountAndBlade.MissionMultiplayerGameModeFlagDominationClient](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_flag_domination_client.html), [TaleWorlds.MountAndBlade.MissionMultiplayerSiegeClient](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege_client.html), and [TaleWorlds.MountAndBlade.MissionMultiplayerTeamDeathmatchClient](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_team_deathmatch_client.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| int | [GetGoldAmount](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#abffbcf6137e75f32ec237771f5419780) () |
| virtual [SpectatorCameraTypes](namespace_tale_worlds_1_1_core.html#a92fd4c9a27d27dc932f836e1c57fd22c) | [GetMissionCameraLockMode](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#a33337dbf5598282d56246126ba1d06cf) (bool lockedToMainPlayer) |
| override void | [OnBehaviorInitialize](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#a1b1a41f98c71e807b4dd97e1cc8ce68b) () |
| override void | [EarlyStart](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#a2161928ac9c2e25be01fa222e452381f) () |
| bool | [CheckTimer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#a89153f988cddfa2df9bc812894d43e06) (out int remainingTime, out int remainingWarningTime, bool forceUpdate=false) |
| void | [OnGoldAmountChangedForRepresentative](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#ae8e382e5b857de8f645157a9d77f516d) ([MissionRepresentativeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html) representative, int goldAmount) |
| virtual bool | [CanRequestTroopChange](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#aeb294e10fe258e6dcb6825eb70682c4a) () |
| virtual bool | [CanRequestCultureChange](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#ae52d6008d53df35fc52129b2de21df2d) () |
| bool | [IsClassAvailable](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#a3d16b5f5c33d859da2449d1805a77261) ([MultiplayerClassDivisions.MPHeroClass](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html) heroClass) |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.MissionNetwork](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html) | |
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
| virtual int | [GetWarningTimer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#ade8259b3dde2e3eadca5e9bff1e0101f) () |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.MissionNetwork](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html) | |
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
| Properties | |
| MissionLobbyComponent | [MissionLobbyComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#a47674e91011e5884f42ee96e988053bb) `[get]` |
| MissionNetworkComponent | [MissionNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#a173c8b852351f40872ce06fa35c0133d) `[get]` |
| [MissionScoreboardComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html) | [ScoreboardComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#a6c2e4f4413ecefdc24bc7334f7cde659) `[get]` |
| [MultiplayerGameNotificationsComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_game_notifications_component.html) | [NotificationsComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#a6f94c97bfb56c5826733fbe6ae0d7854) `[get]` |
| [MultiplayerWarmupComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_warmup_component.html) | [WarmupComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#aa1b00d20f9d507867053fdbed9f3f479) `[get]` |
| [IRoundComponent](interface_tale_worlds_1_1_mount_and_blade_1_1_i_round_component.html) | [RoundComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#a78828f07ea793ec7cf9bf1aab775afac) `[get]` |
| [MultiplayerTimerComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_timer_component.html) | [TimerComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#a9764c3feb031f138fe7e5a60efdbe938) `[get]` |
| bool | [IsGameModeUsingGold](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#a5bd3651cc4c2dacf70d754b3521e12f5) `[get]` |
| bool | [IsGameModeTactical](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#aebf7bd8fff3236e34e6121c51036cc7e) `[get]` |
| virtual bool | [IsGameModeUsingCasualGold](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#a931e1ef91e1cbb2a101742ae604f22f6) `[get]` |
| bool | [IsGameModeUsingRoundCountdown](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#ae5236ef760b42c532c7c967b8a7b8533) `[get]` |
| virtual bool | [IsGameModeUsingAllowCultureChange](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#a80e7346d84da64cfce4f7f2ac01d181c) `[get]` |
| virtual bool | [IsGameModeUsingAllowTroopChange](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#a6a2bb13a0a6db4f03322f0fec036a85c) `[get]` |
| [MultiplayerGameType](namespace_tale_worlds_1_1_mount_and_blade.html#a53c1f5213197d059a513df159e2b79be) | [GameType](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#a31aa8cfdf1d4e1f0248be464f011b751) `[get]` |
| bool | [IsRoundInProgress](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#ae6c7c485a34b223095cabf11935910e1) `[get]` |
| bool | [IsInWarmup](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#a588a2fab17b5665a927a9773bb6113e0) `[get]` |
| float | [RemainingTime](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#a492dbe1511a9342ae924c8bb8a531a61) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.MissionLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html) | |
| override [MissionBehaviorType](namespace_tale_worlds_1_1_mount_and_blade.html#a372fbfd8b3eae375d7fd2e0dcbb76993) | [BehaviorType](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html#a22dc913ab511b0a23db3e6a09b76fcd7) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html) | |
| Mission | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aa8057eb8e1718954a667dc0c9a334281) `[get]` |
| [IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html) | [DebugInput](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ac73ea22074a4d9e10f0018fda1a4c67c) `[get]` |
| [MissionBehaviorType](namespace_tale_worlds_1_1_mount_and_blade.html#a372fbfd8b3eae375d7fd2e0dcbb76993) | [BehaviorType](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aca34f7ade7fa89aba9d51c8330684cc5) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#abffbcf6137e75f32ec237771f5419780)GetGoldAmount()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBaseClient.GetGoldAmount | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#a33337dbf5598282d56246126ba1d06cf)GetMissionCameraLockMode()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual [SpectatorCameraTypes](namespace_tale_worlds_1_1_core.html#a92fd4c9a27d27dc932f836e1c57fd22c) TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBaseClient.GetMissionCameraLockMode | ( | bool | *lockedToMainPlayer* | ) |  | | virtual |

Implements [TaleWorlds.Core.ICameraModeLogic](interface_tale_worlds_1_1_core_1_1_i_camera_mode_logic.html#a4d927634812cb9e1e85562652898665c).

Reimplemented in [TaleWorlds.MountAndBlade.MissionMultiplayerGameModeFlagDominationClient](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_flag_domination_client.html#aff8f12ab91f50caf41f35186b3d8e594).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#a1b1a41f98c71e807b4dd97e1cc8ce68b)OnBehaviorInitialize()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBaseClient.OnBehaviorInitialize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a94e4fe46fad26b2a84dbbf3a4a5cc14c).

Reimplemented in [TaleWorlds.MountAndBlade.MissionMultiplayerGameModeDuelClient](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_duel_client.html#a53246edb2fe130696447ab814d14c4e6), [TaleWorlds.MountAndBlade.MissionMultiplayerGameModeFlagDominationClient](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_flag_domination_client.html#a5e764e74f49b8f698b3ed35888702b23), [TaleWorlds.MountAndBlade.MissionMultiplayerSiegeClient](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege_client.html#a3852fb1fe6c6ef5a9dc3f899c476d395), and [TaleWorlds.MountAndBlade.MissionMultiplayerTeamDeathmatchClient](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_team_deathmatch_client.html#a435c41a46fc74e4da7659fb34029db46).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#a2161928ac9c2e25be01fa222e452381f)EarlyStart()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBaseClient.EarlyStart | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a3bd04d1aa2eb7f76f6c269d9f97e3fbd).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#a89153f988cddfa2df9bc812894d43e06)CheckTimer()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBaseClient.CheckTimer | ( | out int | *remainingTime*, |
|  |  | out int | *remainingWarningTime*, |
|  |  | bool | *forceUpdate* = false ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#ade8259b3dde2e3eadca5e9bff1e0101f)GetWarningTimer()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual int TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBaseClient.GetWarningTimer | ( |  | ) |  | | protectedvirtual |

Reimplemented in [TaleWorlds.MountAndBlade.MissionMultiplayerGameModeFlagDominationClient](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_flag_domination_client.html#a14c136edaedeef4dcd0def8460585ad2).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#ae8e382e5b857de8f645157a9d77f516d)OnGoldAmountChangedForRepresentative()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBaseClient.OnGoldAmountChangedForRepresentative | ( | [MissionRepresentativeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html) | *representative*, | |  |  | int | *goldAmount* ) | | abstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#aeb294e10fe258e6dcb6825eb70682c4a)CanRequestTroopChange()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual bool TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBaseClient.CanRequestTroopChange | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.MissionMultiplayerGameModeDuelClient](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_duel_client.html#a993fc5ca100e1b24f21c9536ddd38ac6).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#ae52d6008d53df35fc52129b2de21df2d)CanRequestCultureChange()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual bool TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBaseClient.CanRequestCultureChange | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.MissionMultiplayerGameModeDuelClient](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_duel_client.html#aedb1399737946a2318c449dbb1029de0).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#a3d16b5f5c33d859da2449d1805a77261)IsClassAvailable()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBaseClient.IsClassAvailable | ( | [MultiplayerClassDivisions.MPHeroClass](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html) | *heroClass* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#a47674e91011e5884f42ee96e988053bb)MissionLobbyComponent
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MissionLobbyComponent TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBaseClient.MissionLobbyComponent | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#a173c8b852351f40872ce06fa35c0133d)MissionNetworkComponent
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MissionNetworkComponent TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBaseClient.MissionNetworkComponent | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#a6c2e4f4413ecefdc24bc7334f7cde659)ScoreboardComponent
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MissionScoreboardComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html) TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBaseClient.ScoreboardComponent | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#a6f94c97bfb56c5826733fbe6ae0d7854)NotificationsComponent
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MultiplayerGameNotificationsComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_game_notifications_component.html) TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBaseClient.NotificationsComponent | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#aa1b00d20f9d507867053fdbed9f3f479)WarmupComponent
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MultiplayerWarmupComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_warmup_component.html) TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBaseClient.WarmupComponent | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#a78828f07ea793ec7cf9bf1aab775afac)RoundComponent
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IRoundComponent](interface_tale_worlds_1_1_mount_and_blade_1_1_i_round_component.html) TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBaseClient.RoundComponent | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#a9764c3feb031f138fe7e5a60efdbe938)TimerComponent
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MultiplayerTimerComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_timer_component.html) TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBaseClient.TimerComponent | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#a5bd3651cc4c2dacf70d754b3521e12f5)IsGameModeUsingGold
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBaseClient.IsGameModeUsingGold | | getabstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#aebf7bd8fff3236e34e6121c51036cc7e)IsGameModeTactical
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBaseClient.IsGameModeTactical | | getabstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#a931e1ef91e1cbb2a101742ae604f22f6)IsGameModeUsingCasualGold
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual bool TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBaseClient.IsGameModeUsingCasualGold | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#ae5236ef760b42c532c7c967b8a7b8533)IsGameModeUsingRoundCountdown
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBaseClient.IsGameModeUsingRoundCountdown | | getabstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#a80e7346d84da64cfce4f7f2ac01d181c)IsGameModeUsingAllowCultureChange
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual bool TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBaseClient.IsGameModeUsingAllowCultureChange | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#a6a2bb13a0a6db4f03322f0fec036a85c)IsGameModeUsingAllowTroopChange
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual bool TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBaseClient.IsGameModeUsingAllowTroopChange | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#a31aa8cfdf1d4e1f0248be464f011b751)GameType
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MultiplayerGameType](namespace_tale_worlds_1_1_mount_and_blade.html#a53c1f5213197d059a513df159e2b79be) TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBaseClient.GameType | | getabstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#ae6c7c485a34b223095cabf11935910e1)IsRoundInProgress
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBaseClient.IsRoundInProgress | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#a588a2fab17b5665a927a9773bb6113e0)IsInWarmup
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBaseClient.IsInWarmup | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html#a492dbe1511a9342ae924c8bb8a531a61)RemainingTime
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBaseClient.RemainingTime | | get |

