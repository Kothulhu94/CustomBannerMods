--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html ---

TaleWorlds.MountAndBlade.MissionScoreboardComponent Class ReferenceInherits [TaleWorlds.MountAndBlade.MissionNetwork](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html).

|  |  |
| --- | --- |
| Classes | |
| struct | [ScoreboardHeader](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component_1_1_scoreboard_header.html) |
| class | [MissionScoreboardSide](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component_1_1_mission_scoreboard_side.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MissionScoreboardComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a8e97077883dbc5a8845591e37e134bc7) ([IScoreboardData](interface_tale_worlds_1_1_mount_and_blade_1_1_i_scoreboard_data.html) scoreboardData) |
| override void | [AfterStart](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a0275befb72e8251173cf14bcdc7aae79) () |
| override void | [OnRemoveBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#abb27dbe22b8905fa4a131ee1b3c433b9) () |
| void | [ResetBotScores](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#aa12b828989d0e54c8953471b44f75976) () |
| void | [ChangeTeamScore](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a4f84d4cac3e803329eb49b8e43a7084c) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, int scoreChange) |
| [MissionScoreboardSide](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component_1_1_mission_scoreboard_side.html) | [GetSideSafe](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a8646f9f17517aa6434ab3ba24c68b267) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) battleSide) |
| int | [GetRoundScore](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#aae8600d08cffce437d050f2e9062ee1d) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| void | [HandleServerUpdateRoundScoresMessage](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a45f91fa0f4d2ebde1d8e6113d2da5a6e) ([Network.Messages.GameNetworkMessage](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html) baseMessage) |
| void | [HandleServerSetRoundMVP](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#aa1c1b6fa75c3f0fae592d639e046050e) ([Network.Messages.GameNetworkMessage](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html) baseMessage) |
| void | [CalculateTotalNumbers](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#acd3c9bcd342376226cf1f4bfa059dea0) () |
| override void | [OnClearScene](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a7426a9a3dba61819fedead663c71967f) () |
| override void | [OnPlayerConnectedToServer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a3a2bb88d78287e575ac3613524e8368c) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| override void | [OnPlayerDisconnectedFromServer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a710a7b6356b8b3502770b4d1ea0db070) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| override void | [OnAgentBuild](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a767055a9368fabcde55352e2e700ec16) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [Banner](class_tale_worlds_1_1_core_1_1_banner.html) banner) |
| override void | [OnAssignPlayerAsSergeantOfFormation](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a4cf4c4c6a8f7afbecd9cf2d17f5c22af) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| void | [BotPropertiesChanged](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a3beb884c44f7dc297b33a4781a8b4954) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| void | [PlayerPropertiesChanged](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#ad10984fa453add730569731054297dc4) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) player) |
| void | [PlayerPropertiesChanged](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#acca5d8f9598389c81bf8416dbd259314) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) player) |
| void | [HandleServerEventBotDataMessage](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a1980a2b9fad2baa7977e22c6fa6fb3a6) ([Network.Messages.GameNetworkMessage](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html) baseMessage) |
| void | [OnRoundEnding](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#add3143c913e430d2978e27fe0888bda3) () |
| void | [OnMultiplayerGameClientBehaviorInitialized](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a9c507dc59bf229d559a02dd4f651c6eb) (ref Action< [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) > onBotsControlledChanged) |
| [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | [GetMatchWinnerSide](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a10c022ae6a11c434a223b5a56dba8908) () |
| override void | [OnScoreHit](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a14b110516528a697a384d6c38f40669b) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectedAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectorAgent, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, bool isBlocked, bool isSiegeEngineHit, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, float damagedHp, float hitDistance, float shotDifficulty) |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.MissionNetwork](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html) | |
| override void | [OnAfterMissionCreated](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a9d0b9e4ba2af643fef12fb7f7b648942) () |
| override void | [OnBehaviorInitialize](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a47c1b54321184cca31fde7787386c3e8) () |
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
| virtual void | [OnMissileHit](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a6d83e4fa1f6e1167b130b82a782566b1) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attacker, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victim, bool isCanceled, [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData) |
| virtual void | [OnMeleeHit](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ae67852af54716d6087e05eec594e21ef) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attacker, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victim, bool isCanceled, [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData) |
| virtual void | [OnMissileCollisionReaction](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a6dab0fd5a10bef3110a51af4176028d8) ([Mission.MissileCollisionReaction](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a235275d0a4fd9f604f19aaaf6943e494) collisionReaction, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attachedAgent, sbyte attachedBoneIndex) |
| virtual void | [OnMissionScreenPreLoad](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a9e8c61bb3fa009704236d5b9fced2c74) () |
| virtual void | [OnAgentCreated](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#af4505c65ad5f3f5ac6ec4b766f7aa203) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| virtual void | [OnAgentTeamChanged](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ae82c2110c9b50bf8c08030847c896275) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) prevTeam, [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) newTeam, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| virtual void | [OnAgentControllerSetToPlayer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a3cbbc0856767f6975fc137a83480c71a) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| virtual void | [OnAgentHit](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a2ca3ef8b8c9419285565e1443873345d) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectedAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectorAgent, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) affectorWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) attackCollisionData) |
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
| override void | [AddRemoveMessageHandlers](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a8d7688a314855d77e8b4486821ef5b5c) ([GameNetwork.NetworkMessageHandlerRegistererContainer](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer_container.html) registerer) |
| override void | [HandleLateNewClientAfterSynchronized](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a9280137702bc824ef490bfa22e429a5e) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.MissionNetwork](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html) | |
| virtual void | [AddRemoveMessageHandlers](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#abb960ab4a133c9668ea1c80ced7abfdc) ([GameNetwork.NetworkMessageHandlerRegistererContainer](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer_container.html) registerer) |
| virtual void | [OnUdpNetworkHandlerTick](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a5c53bf86327084d6b36094652f9a8076) () |
| virtual void | [OnUdpNetworkHandlerClose](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a61aab8a2bbfe2e2bfbe70eb5646b02bd) () |
| virtual void | [HandleNewClientConnect](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a684b2bb60226f55ad7752a417fbdce56) ([PlayerConnectionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_player_connection_info.html) clientConnectionInfo) |
| virtual void | [HandleEarlyNewClientAfterLoadingFinished](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#ada8d7710e31d528e4b7d7d60fee10477) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| virtual void | [HandleNewClientAfterLoadingFinished](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a2ae30190712925d7a1a02b9b76810fe9) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| virtual void | [HandleLateNewClientAfterLoadingFinished](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#aa603feaeccf8eed50a2cb893e296d9a9) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| virtual void | [HandleNewClientAfterSynchronized](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a73a47ad2db0dedde69dd82c59400e58a) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| virtual void | [HandleEarlyPlayerDisconnect](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a6ad7aa76f0bd9635689a16ecf697f24f) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| virtual void | [HandlePlayerDisconnect](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a42028d84ad1a39843cb532731fa76e14) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html) | |
| virtual void | [OnEndMission](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a2520fc88c264958b60ba7b75a4714117) () |
|  | Called right before the mission ends (i.e. after player clicks done/retreat button in battle results screen for SP missions). Preferably unregister all your [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) dependent events here. Some mission fields (like agent lists) will be deallocated after the mission ends. |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsOneSided](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a537706144660eff08e3d774701fbc4d4) `[get]` |
| [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | [RoundWinner](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a8563347c82b35841659151cc3f36ead6) `[get]` |
| [ScoreboardHeader](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component_1_1_scoreboard_header.html)[] | [Headers](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a8674be750d95d6085a17943b87286dae) `[get]` |
| IEnumerable< [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) > | [RoundWinnerList](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a0b62a6f96f7f7bcaac3c637f2c8a1df7) `[get]` |
| [MissionScoreboardSide](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component_1_1_mission_scoreboard_side.html)[] | [Sides](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a4101d9953b6fc78a82d20c90417ee26d) `[get]` |
| List< [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) > | [Spectators](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#af77e0a5c3dcb1e6dccf773f6c419529b) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.MissionLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html) | |
| override [MissionBehaviorType](namespace_tale_worlds_1_1_mount_and_blade.html#a372fbfd8b3eae375d7fd2e0dcbb76993) | [BehaviorType](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html#a22dc913ab511b0a23db3e6a09b76fcd7) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html) | |
| Mission | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aa8057eb8e1718954a667dc0c9a334281) `[get]` |
| [IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html) | [DebugInput](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ac73ea22074a4d9e10f0018fda1a4c67c) `[get]` |
| [MissionBehaviorType](namespace_tale_worlds_1_1_mount_and_blade.html#a372fbfd8b3eae375d7fd2e0dcbb76993) | [BehaviorType](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aca34f7ade7fa89aba9d51c8330684cc5) `[get]` |

|  |  |
| --- | --- |
| Events | |
| Action | [OnRoundPropertiesChanged](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a97288f983414276621c5d33fc7566b3f) |
| Action< [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) > | [OnBotPropertiesChanged](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#ae3261a342ddd89d32ea08d4312370d8d) |
| Action< [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html), [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html), [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) > | [OnPlayerSideChanged](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#afced97b968b78b24f9d0276982627089) |
| Action< [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c), [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) > | [OnPlayerPropertiesChanged](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#abc97ce0b6a6ccd995f083e5f74281ebd) |
| Action< [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html), int > | [OnMVPSelected](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#acfd119195c7f9fdf8eeb64b861bac1fa) |
| Action | [OnScoreboardInitialized](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a23bd4d6b73b76f1db20d00341f57dfc0) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a8e97077883dbc5a8845591e37e134bc7)MissionScoreboardComponent()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.MissionScoreboardComponent.MissionScoreboardComponent | ( | [IScoreboardData](interface_tale_worlds_1_1_mount_and_blade_1_1_i_scoreboard_data.html) | *scoreboardData* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a0275befb72e8251173cf14bcdc7aae79)AfterStart()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MissionScoreboardComponent.AfterStart | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a693295e26d8b0fcf634c52b1c08fd974).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a8d7688a314855d77e8b4486821ef5b5c)AddRemoveMessageHandlers()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MissionScoreboardComponent.AddRemoveMessageHandlers | ( | [GameNetwork.NetworkMessageHandlerRegistererContainer](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer_container.html) | *registerer* | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#abb27dbe22b8905fa4a131ee1b3c433b9)OnRemoveBehavior()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MissionScoreboardComponent.OnRemoveBehavior | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionNetwork](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a5a552a6c516ec896a485f06d830a7525).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#aa12b828989d0e54c8953471b44f75976)ResetBotScores()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionScoreboardComponent.ResetBotScores | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a4f84d4cac3e803329eb49b8e43a7084c)ChangeTeamScore()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionScoreboardComponent.ChangeTeamScore | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, |
|  |  | int | *scoreChange* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a8646f9f17517aa6434ab3ba24c68b267)GetSideSafe()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [MissionScoreboardSide](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component_1_1_mission_scoreboard_side.html) TaleWorlds.MountAndBlade.MissionScoreboardComponent.GetSideSafe | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *battleSide* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#aae8600d08cffce437d050f2e9062ee1d)GetRoundScore()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.MissionScoreboardComponent.GetRoundScore | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a45f91fa0f4d2ebde1d8e6113d2da5a6e)HandleServerUpdateRoundScoresMessage()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionScoreboardComponent.HandleServerUpdateRoundScoresMessage | ( | [Network.Messages.GameNetworkMessage](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html) | *baseMessage* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#aa1c1b6fa75c3f0fae592d639e046050e)HandleServerSetRoundMVP()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionScoreboardComponent.HandleServerSetRoundMVP | ( | [Network.Messages.GameNetworkMessage](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html) | *baseMessage* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#acd3c9bcd342376226cf1f4bfa059dea0)CalculateTotalNumbers()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionScoreboardComponent.CalculateTotalNumbers | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a7426a9a3dba61819fedead663c71967f)OnClearScene()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MissionScoreboardComponent.OnClearScene | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a0f6f2ae3c6e394ee12a8d394516af918).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a3a2bb88d78287e575ac3613524e8368c)OnPlayerConnectedToServer()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MissionScoreboardComponent.OnPlayerConnectedToServer | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionNetwork](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a7ae019a4fd1d6922c99a883a9fdb9ac8).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a710a7b6356b8b3502770b4d1ea0db070)OnPlayerDisconnectedFromServer()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MissionScoreboardComponent.OnPlayerDisconnectedFromServer | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionNetwork](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a331802321c1ab0c5e399a14522e49b4b).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a767055a9368fabcde55352e2e700ec16)OnAgentBuild()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MissionScoreboardComponent.OnAgentBuild | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | [Banner](class_tale_worlds_1_1_core_1_1_banner.html) | *banner* ) | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ad610eac3ce9064919cb8771652a5da4e).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a4cf4c4c6a8f7afbecd9cf2d17f5c22af)OnAssignPlayerAsSergeantOfFormation()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MissionScoreboardComponent.OnAssignPlayerAsSergeantOfFormation | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a1678389824ffac3a5dd204dc682a6676).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a3beb884c44f7dc297b33a4781a8b4954)BotPropertiesChanged()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionScoreboardComponent.BotPropertiesChanged | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#ad10984fa453add730569731054297dc4)PlayerPropertiesChanged() [1/2]
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionScoreboardComponent.PlayerPropertiesChanged | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *player* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#acca5d8f9598389c81bf8416dbd259314)PlayerPropertiesChanged() [2/2]
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionScoreboardComponent.PlayerPropertiesChanged | ( | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) | *player* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a9280137702bc824ef490bfa22e429a5e)HandleLateNewClientAfterSynchronized()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MissionScoreboardComponent.HandleLateNewClientAfterSynchronized | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionNetwork](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#ab3ff3f8b34cff3bf3179abbd858838de).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a1980a2b9fad2baa7977e22c6fa6fb3a6)HandleServerEventBotDataMessage()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionScoreboardComponent.HandleServerEventBotDataMessage | ( | [Network.Messages.GameNetworkMessage](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html) | *baseMessage* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#add3143c913e430d2978e27fe0888bda3)OnRoundEnding()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionScoreboardComponent.OnRoundEnding | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a9c507dc59bf229d559a02dd4f651c6eb)OnMultiplayerGameClientBehaviorInitialized()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionScoreboardComponent.OnMultiplayerGameClientBehaviorInitialized | ( | ref Action< [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) > | *onBotsControlledChanged* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a10c022ae6a11c434a223b5a56dba8908)GetMatchWinnerSide()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) TaleWorlds.MountAndBlade.MissionScoreboardComponent.GetMatchWinnerSide | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a14b110516528a697a384d6c38f40669b)OnScoreHit()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MissionScoreboardComponent.OnScoreHit | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *affectedAgent*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *affectorAgent*, | |  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon*, | |  |  | bool | *isBlocked*, | |  |  | bool | *isSiegeEngineHit*, | |  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow*, | |  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, | |  |  | float | *damagedHp*, | |  |  | float | *hitDistance*, | |  |  | float | *shotDifficulty* ) | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a47a0a0aafce4f2bc5bca00fa1410e539).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a537706144660eff08e3d774701fbc4d4)IsOneSided
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.MissionScoreboardComponent.IsOneSided | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a8563347c82b35841659151cc3f36ead6)RoundWinner
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) TaleWorlds.MountAndBlade.MissionScoreboardComponent.RoundWinner | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a8674be750d95d6085a17943b87286dae)Headers
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ScoreboardHeader](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component_1_1_scoreboard_header.html) [] TaleWorlds.MountAndBlade.MissionScoreboardComponent.Headers | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a0b62a6f96f7f7bcaac3c637f2c8a1df7)RoundWinnerList
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IEnumerable<[BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c)> TaleWorlds.MountAndBlade.MissionScoreboardComponent.RoundWinnerList | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a4101d9953b6fc78a82d20c90417ee26d)Sides
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MissionScoreboardSide](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component_1_1_mission_scoreboard_side.html) [] TaleWorlds.MountAndBlade.MissionScoreboardComponent.Sides | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#af77e0a5c3dcb1e6dccf773f6c419529b)Spectators
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html)> TaleWorlds.MountAndBlade.MissionScoreboardComponent.Spectators | | get |

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a97288f983414276621c5d33fc7566b3f)OnRoundPropertiesChanged
------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action TaleWorlds.MountAndBlade.MissionScoreboardComponent.OnRoundPropertiesChanged |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#ae3261a342ddd89d32ea08d4312370d8d)OnBotPropertiesChanged
----------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c)> TaleWorlds.MountAndBlade.MissionScoreboardComponent.OnBotPropertiesChanged |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#afced97b968b78b24f9d0276982627089)OnPlayerSideChanged
-------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html), [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html), [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html)> TaleWorlds.MountAndBlade.MissionScoreboardComponent.OnPlayerSideChanged |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#abc97ce0b6a6ccd995f083e5f74281ebd)OnPlayerPropertiesChanged
-------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c), [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html)> TaleWorlds.MountAndBlade.MissionScoreboardComponent.OnPlayerPropertiesChanged |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#acfd119195c7f9fdf8eeb64b861bac1fa)OnMVPSelected
-------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html), int> TaleWorlds.MountAndBlade.MissionScoreboardComponent.OnMVPSelected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a23bd4d6b73b76f1db20d00341f57dfc0)OnScoreboardInitialized
-----------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action TaleWorlds.MountAndBlade.MissionScoreboardComponent.OnScoreboardInitialized |

