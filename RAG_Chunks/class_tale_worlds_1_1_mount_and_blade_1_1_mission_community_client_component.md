--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_mission_community_client_component.html ---

TaleWorlds.MountAndBlade.MissionCommunityClientComponent Class ReferenceInherits [TaleWorlds.MountAndBlade.MissionLobbyComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [OnBehaviorInitialize](class_tale_worlds_1_1_mount_and_blade_1_1_mission_community_client_component.html#a0d4001520c4763a0be2bafd90b440024) () |
| void | [SetServerEndingBeforeClientLoaded](class_tale_worlds_1_1_mount_and_blade_1_1_mission_community_client_component.html#ae58a3e01f7d379a477569358400461bb) (bool isServerEndingBeforeClientLoaded) |
| override void | [QuitMission](class_tale_worlds_1_1_mount_and_blade_1_1_mission_community_client_component.html#ab3d6857e7e325e856dfc701bc24bce03) () |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.MissionLobbyComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html) | |
| override void | [OnBehaviorInitialize](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#a0216224cd8c1f150e15a04a65fe452df) () |
| override void | [AfterStart](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#acd07108627bc31e98bc8473fc9a344d4) () |
| override void | [EarlyStart](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#a7e4e644a5dc8d7df99db61bcf73ad2aa) () |
| override void | [OnMissionTick](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#a9d0e438a35aa875858dda4c4150272fe) (float dt) |
| override void | [OnRemoveBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#a6c453d0a1ba44abb304e8fea9f5a9419) () |
| bool | [IsClassAvailable](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#aab01aae3894ed834e99469a24f40c4fd) ([FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) formationClass) |
| void | [ChangeClassRestriction](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#aca8cb5020cf6f27cfa4650a503ea601c) ([FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) classToChangeRestriction, bool value) |
| void | [DespawnPlayer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#a1de156fe73966bc7821ff9b0d441fea2) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) missionPeer) |
| override void | [OnScoreHit](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#ad3d6b306db1a1d34945aa871957216cb) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectedAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectorAgent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, bool isBlocked, bool isSiegeEngineHit, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, float damagedHp, float hitDistance, float shotDifficulty) |
| override void | [OnAgentRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#aeae05900829dacb5c2d7499d87e01506) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectedAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectorAgent, [AgentState](namespace_tale_worlds_1_1_core.html#a799bcc77ddb6372c7383f3340ed4d1c0) agentState, [KillingBlow](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html) killingBlow) |
| override void | [OnAgentBuild](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#a83d04de2fc66a4f7ce3cda813596ac03) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [Banner](class_tale_worlds_1_1_core_1_1_banner.html) banner) |
| override void | [OnClearScene](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#a86c4314d35af3894151290ca4dc81672) () |
| virtual void | [SetStateEndingAsServer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#a8a25335041e443afe3e74d7030b1c817) () |
| void | [RequestCultureSelection](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#ae77f081b8c5e4885b0c24781257295d3) () |
| void | [RequestAdminMessage](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#a011533d2bba8fd6b1e0f4b420daef746) (string message, bool isBroadcast) |
| void | [RequestTroopSelection](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#a15ad2f818194fff5c7337b77dd90c822) () |
| void | [OnCultureSelected](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#a88efd2cfc0aa2a226e19a12ec4825513) ([BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) culture) |
| int | [GetRandomFaceSeedForCharacter](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#acad986558c91011198bf2cdc7ea11908) ([BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) character, int addition=0) |
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
| virtual void | [OnMissileHit](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a6d83e4fa1f6e1167b130b82a782566b1) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attacker, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victim, bool isCanceled, [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData) |
| virtual void | [OnMeleeHit](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ae67852af54716d6087e05eec594e21ef) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attacker, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victim, bool isCanceled, [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData) |
| virtual void | [OnMissileCollisionReaction](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a6dab0fd5a10bef3110a51af4176028d8) ([Mission.MissileCollisionReaction](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a235275d0a4fd9f604f19aaaf6943e494) collisionReaction, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attachedAgent, sbyte attachedBoneIndex) |
| virtual void | [OnMissionScreenPreLoad](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a9e8c61bb3fa009704236d5b9fced2c74) () |
| virtual void | [OnAgentCreated](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#af4505c65ad5f3f5ac6ec4b766f7aa203) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| virtual void | [OnAgentTeamChanged](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ae82c2110c9b50bf8c08030847c896275) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) prevTeam, [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) newTeam, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| virtual void | [OnAgentControllerSetToPlayer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a3cbbc0856767f6975fc137a83480c71a) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| virtual void | [OnAgentHit](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a2ca3ef8b8c9419285565e1443873345d) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectedAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectorAgent, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) affectorWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) attackCollisionData) |
| virtual void | [OnEarlyAgentRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a2357313c6773cd404fea1d097c94a165) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectedAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectorAgent, [AgentState](namespace_tale_worlds_1_1_core.html#a799bcc77ddb6372c7383f3340ed4d1c0) agentState, [KillingBlow](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html) blow) |
| virtual void | [OnAgentDeleted](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a7eba548023bf92a07eb6254ec4241596) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectedAgent) |
| virtual void | [OnAgentFleeing](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aaa554af0ef2506421c75dd30447f874e) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectedAgent) |
| virtual void | [OnAgentPanicked](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a5dd187c2f799d75a81280387da848a52) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectedAgent) |
| virtual void | [OnFocusGained](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a2194f733a9135726d66e837955aba53b) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html) focusableObject, bool isInteractable) |
| virtual void | [OnFocusLost](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#af2849b7ea639493ffca4702bb6bcfb03) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html) focusableObject) |
| virtual void | [OnAddTeam](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a7a49d143b51cf0f72d20b13b0a571884) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
| virtual void | [AfterAddTeam](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a1a84dd234ff93d804a4094f9876df166) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
| virtual void | [OnAgentInteraction](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a813d13ba2cdf3ad40dd5ab055e6c5bf2) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) userAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, sbyte agentBoneIndex) |
| virtual void | [OnEndMissionInternal](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a49e74ba30248db4bac7d78be3039ded9) () |
|  | Do not override this. |
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
| Additional Inherited Members | |
| Public Types inherited from [TaleWorlds.MountAndBlade.MissionLobbyComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html) | |
| enum | [MultiplayerGameState](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#a7c92a5675e5211dbcd14d19fa28e43d9) {     [WaitingFirstPlayers](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#a7c92a5675e5211dbcd14d19fa28e43d9a055a5de88eda3948ffdd5a0c7dfc7f34) ,     [Playing](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#a7c92a5675e5211dbcd14d19fa28e43d9ac9dbb2b7c84159b632d71e512eba8428) ,     [Ending](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#a7c92a5675e5211dbcd14d19fa28e43d9a753c34bcdd8eac2abb9042f7a93c2e75)   } |
| Static Public Member Functions inherited from [TaleWorlds.MountAndBlade.MissionLobbyComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html) | |
| static void | [AddLobbyComponentType](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#a5852fda2281bdea102f8204418d9506e) (Type type, [LobbyMissionType](namespace_tale_worlds_1_1_mount_and_blade.html#a010b5b1b6c1352d134daed6ba044ce95) missionType, bool isSeverComponent) |
| static MissionLobbyComponent | [CreateBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#a05b996c99f7c8de316516c78f98d0efe) () |
| static int | [GetSpawnPeriodDurationForPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#a12af8d9f03883091d193e94ff3bcb92a) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) peer) |
| static string | [MPHostChangeParam](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#abc6dd05846c6a39435e35fc3f7507df1) (List< String > strings) |
| Static Public Attributes inherited from [TaleWorlds.MountAndBlade.MissionLobbyComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html) | |
| static readonly float | [PostMatchWaitDuration](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#a0b5df2b892754fe81297f9dca73fe81c) = 15.0f |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.MissionLobbyComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html) | |
| override void | [AddRemoveMessageHandlers](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#a6985fcf4a4d94937cae753f60a44585d) ([GameNetwork.NetworkMessageHandlerRegistererContainer](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer_container.html) registerer) |
| override void | [OnUdpNetworkHandlerClose](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#a454917317c2b983850f0e64fe7a8ca0b) () |
| override void | [OnUdpNetworkHandlerTick](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#af68224279e3716a23ad00af8aa56094d) () |
| override void | [HandleNewClientConnect](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#a57a22b29f081c799cc95de1669f209b2) ([PlayerConnectionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_player_connection_info.html) clientConnectionInfo) |
| override void | [HandleLateNewClientAfterLoadingFinished](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#a0e64052a5d2ea09cc3bafedddf3df61c) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| virtual void | [OnPlayerKills](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#a51f988b4f46c3aaceb09138fae98dad8) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) killerPeer, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) killedAgent, [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) assistorPeer) |
| virtual void | [OnPlayerDies](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#ab004d25759535756c50ffa282474ba73) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) peer, [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) affectorPeer, [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) assistorPeer) |
| virtual void | [OnBotKills](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#a460f16426bc82e25a1fa5cf742367595) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) botAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) killedAgent) |
| virtual void | [OnBotDies](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#ad0a0ff90529540fc334292c465aea8f0) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) botAgent, [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) affectorPeer, [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) assistorPeer) |
| virtual void | [EndGameAsServer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#aa0c62c3d39d5f34167eaecf68a5a8e0b) () |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.MissionNetwork](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html) | |
| virtual void | [HandleEarlyNewClientAfterLoadingFinished](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#ada8d7710e31d528e4b7d7d60fee10477) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| virtual void | [HandleNewClientAfterLoadingFinished](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a2ae30190712925d7a1a02b9b76810fe9) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| virtual void | [HandleNewClientAfterSynchronized](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a73a47ad2db0dedde69dd82c59400e58a) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| virtual void | [HandleLateNewClientAfterSynchronized](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#ab3ff3f8b34cff3bf3179abbd858838de) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| virtual void | [HandleEarlyPlayerDisconnect](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a6ad7aa76f0bd9635689a16ecf697f24f) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| virtual void | [HandlePlayerDisconnect](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a42028d84ad1a39843cb532731fa76e14) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html) | |
| virtual void | [OnEndMission](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a2520fc88c264958b60ba7b75a4714117) () |
|  | Called right before the mission ends (i.e. after player clicks done/retreat button in battle results screen for SP missions). Preferably unregister all your [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) dependent events here. Some mission fields (like agent lists) will be deallocated after the mission ends. |
| Properties inherited from [TaleWorlds.MountAndBlade.MissionLobbyComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html) | |
| bool | [IsInWarmup](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#a667eb55f02b6891ecf37b500f579b425) `[get]` |
| [MultiplayerGameType](namespace_tale_worlds_1_1_mount_and_blade.html#a53c1f5213197d059a513df159e2b79be) | [MissionType](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#a18753fded37aac962ac8f9541ab1affe) `[get, set]` |
| [MultiplayerGameState](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#a7c92a5675e5211dbcd14d19fa28e43d9) | [CurrentMultiplayerState](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#ac432148ffa686fa41e0aa208ed7175ec) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.MissionLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html) | |
| override [MissionBehaviorType](namespace_tale_worlds_1_1_mount_and_blade.html#a372fbfd8b3eae375d7fd2e0dcbb76993) | [BehaviorType](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html#a22dc913ab511b0a23db3e6a09b76fcd7) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html) | |
| Mission | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aa8057eb8e1718954a667dc0c9a334281) `[get]` |
| [IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html) | [DebugInput](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ac73ea22074a4d9e10f0018fda1a4c67c) `[get]` |
| [MissionBehaviorType](namespace_tale_worlds_1_1_mount_and_blade.html#a372fbfd8b3eae375d7fd2e0dcbb76993) | [BehaviorType](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aca34f7ade7fa89aba9d51c8330684cc5) `[get]` |
| Events inherited from [TaleWorlds.MountAndBlade.MissionLobbyComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html) | |
| Action | [OnPostMatchEnded](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#ae59b6c1d9f93e0d0afa38c54f515c636) |
| Action | [OnCultureSelectionRequested](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#a894c33e4b2aff9f29ec817f6040d2698) |
| Action< string, bool > | [OnAdminMessageRequested](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#a2c28db432f2812dc62a0f1d831e6036e) |
| Action | [OnClassRestrictionChanged](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#a8176321e5b4573be122192e88ad56f2c) |
| Action< [MultiplayerGameState](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#a7c92a5675e5211dbcd14d19fa28e43d9) > | [CurrentMultiplayerStateChanged](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#aaf6b03b8809a7cb93e4e9feaa8ae7fc7) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_community_client_component.html#a0d4001520c4763a0be2bafd90b440024)OnBehaviorInitialize()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MissionCommunityClientComponent.OnBehaviorInitialize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a94e4fe46fad26b2a84dbbf3a4a5cc14c).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_community_client_component.html#ae58a3e01f7d379a477569358400461bb)SetServerEndingBeforeClientLoaded()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionCommunityClientComponent.SetServerEndingBeforeClientLoaded | ( | bool | *isServerEndingBeforeClientLoaded* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_community_client_component.html#ab3d6857e7e325e856dfc701bc24bce03)QuitMission()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MissionCommunityClientComponent.QuitMission | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionLobbyComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#a41e776eb39a317ffd85d41ebdd4b74e0).

