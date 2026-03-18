--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html ---

TaleWorlds.MountAndBlade.MissionMultiplayerSiege Class ReferenceInherits [TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html), and [TaleWorlds.MountAndBlade.IAnalyticsFlagInfo](interface_tale_worlds_1_1_mount_and_blade_1_1_i_analytics_flag_info.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| delegate void | [OnDestructableComponentDestroyedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#ab322c7b723ba4c9753c01c71df27b61c) ([DestructableComponent](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html) destructableComponent, [ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) attackerScriptComponentBehaviour, [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html)[] contributors) |
| delegate void | [OnObjectiveGoldGainedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#ac7176db2c556c1a443968f2ac81043ec) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) peer, int goldGain) |
| override void | [OnBehaviorInitialize](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#ad6a735235c965ac361c43124e274696e) () |
| override [MultiplayerGameType](namespace_tale_worlds_1_1_mount_and_blade.html#a53c1f5213197d059a513df159e2b79be) | [GetMissionType](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#ab7febefdbe2a0dc7b99085824b92b3da) () |
| override bool | [UseRoundController](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#aeb2e4058159b3842737ab84bd54fe562) () |
| override void | [AfterStart](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#ab59f5752eb06e1aa711bfd5c728928de) () |
| override void | [OnMissionTick](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#ac3fdd12ba87fc0c452511e564e5486d1) (float dt) |
| override bool | [CheckForMatchEnd](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#ac924ff9ed5469d61fb501950d8868226) () |
| override [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | [GetWinnerTeam](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#a57843478b7d9aa4062180690c1ed6666) () |
| [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | [GetFlagOwnerTeam](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#a45d418ce3587fc39d5e34e1d2e476c1c) ([FlagCapturePoint](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_flag_capture_point.html) flag) |
| override bool | [CheckForWarmupEnd](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#a7f53e8fc0a3e7a8aca6986763486f7b1) () |
| override void | [OnPeerChangedTeam](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#a3222912a8574a7e7458ad2bf06d032cf) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) peer, [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) oldTeam, [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) newTeam) |
| override void | [OnAgentRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#a1d4e9d93a7a16ae2d1478d0f38e308e1) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectedAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectorAgent, [AgentState](namespace_tale_worlds_1_1_core.html#a799bcc77ddb6372c7383f3340ed4d1c0) agentState, [KillingBlow](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html) blow) |
| override void | [OnRemoveBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#a8f54549cf58b43183e3e5a8eff6163f9) () |
| override void | [OnClearScene](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#a6558f93067367da4eab81b98260bdaf1) () |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html) | |
| [MultiplayerGameType](namespace_tale_worlds_1_1_mount_and_blade.html#a53c1f5213197d059a513df159e2b79be) | [GetMissionType](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#ad1b9cc154b24435047f7fbdeb2a4671a) () |
| virtual bool | [CheckIfOvertime](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#ac21bc4beaedba9ad43fad36ded6b58da) () |
| virtual bool | [CheckForRoundEnd](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#aa3769dcddcc1598cbca42abcd49eb745) () |
| virtual bool | [UseCultureSelection](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#a01ecf7fb7211a7b7bb6a215571d98991) () |
| void | [ClearPeerCounts](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#ae5ccac15f7399481cc38ff0e3f46d1fc) () |
| bool | [ShouldSpawnVisualsForServer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#a16b176822425f66b595edbeaba63b13c) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) spawningNetworkPeer) |
| void | [HandleAgentVisualSpawning](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#a7bdd207f331ab9185ee585f89de79702) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) spawningNetworkPeer, [AgentBuildData](class_tale_worlds_1_1_mount_and_blade_1_1_agent_build_data.html) spawningAgentBuildData, int troopCountInFormation=0, bool useCosmetics=true) |
| virtual bool | [AllowCustomPlayerBanners](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#aa4cb2a13ce0d10c2c6b6383c21f11046) () |
| virtual int | [GetScoreForKill](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#af62ec1bd806140a30d1601ed2d1870d9) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) killedAgent) |
| virtual float | [GetTroopNumberMultiplierForMissingPlayer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#aefa9ae3a774915bf3501f9e49d318b14) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) spawningPeer) |
| int | [GetCurrentGoldForPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#a2bac6090e0c941c192a7b29b56f065a6) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) peer) |
| void | [ChangeCurrentGoldForPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#a89a3a145dada49acc327095bcb4c392b) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) peer, int newAmount) |
| virtual bool | [CheckIfPlayerCanDespawn](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#a5602280961796d7ae85c54c12825732e) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) missionPeer) |
| override void | [OnPreMissionTick](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#a842a881eae7e57138dce2e05e8dfc6f3) (float dt) |
| Dictionary< string, string > | [GetUsedCosmeticsFromPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#ae461a330ec65a00cef9bdc78029dea78) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) missionPeer, [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) selectedTroopCharacter) |
| void | [AddCosmeticItemsToEquipment](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#ac722f03dd65542cbf9402354845bfd84) ([Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) equipment, Dictionary< string, string > choosenCosmetics) |
| bool | [IsClassAvailable](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#adaec42b32621750c4a30682fe6876ebe) ([MultiplayerClassDivisions.MPHeroClass](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html) heroClass) |
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
| Static Public Attributes | |
| const int | [NumberOfFlagsInGame](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#a7c52ba9a166ebdcdc57859410600e472) = 6 + 1 |
| const int | [NumberOfFlagsAffectingMoraleInGame](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#a9b30e9d70a698d5847b71d1168f827ff) = [NumberOfFlagsInGame](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#a7c52ba9a166ebdcdc57859410600e472) - 1 |
| const int | [MaxMorale](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#acdea28f776adb4bba25c55e77e85e754) = [StartingMorale](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#a37a0d5d6d3c58fc200f3a9a5b8e588ba) + (([MaxMoraleGainPerFlag](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#a9a67d22f32f43e4c57ecb789ded7b0ce) + MoraleBoostOnFlagRemoval) \* [NumberOfFlagsAffectingMoraleInGame](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#a9b30e9d70a698d5847b71d1168f827ff)) |
| const int | [StartingMorale](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#a37a0d5d6d3c58fc200f3a9a5b8e588ba) = 360 |
| const int | [MaxMoraleGainPerFlag](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#a9a67d22f32f43e4c57ecb789ded7b0ce) = 90 |
| const int | [MoraleGainPerFlag](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#a063d86364238a252fb1d61b2e0b64261) = 1 |
| const int | [GoldBonusOnFlagRemoval](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#a5a9f7bd4ea8c5cb05ecf1c39c40f66db) = 35 |
| const string | [MasterFlagTag](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#ac4cb56bb41a999bbbda5be6eab5f5fb3) = "keep\_capture\_point" |
| Static Public Attributes inherited from [TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html) | |
| const int | [GoldCap](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#a3bcfe16586e4a457074927bd49f096d0) = 2000 |
| const float | [PerkTickPeriod](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#a4e6718057851e74bb44a2fc722fbcb84) = 1.0f |
| const float | [GameModeSystemTickPeriod](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#a205efed9c13bd8f111239fec9da1c774) = 0.25f |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [HandleEarlyNewClientAfterLoadingFinished](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#ab601a5921633cb2fc2fac8c1082307ce) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| override void | [HandleNewClientAfterSynchronized](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#aaa0e8b299d8786d8b1372881a45362e8) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| override void | [HandleNewClientAfterLoadingFinished](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#ac79fafd46c6ee8193eabdbd74f60ec4f) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html) | |
| override void | [HandleLateNewClientAfterLoadingFinished](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#a62f7c0c25923498d662dc865ea95fed1) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.MissionNetwork](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html) | |
| virtual void | [AddRemoveMessageHandlers](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#abb960ab4a133c9668ea1c80ced7abfdc) ([GameNetwork.NetworkMessageHandlerRegistererContainer](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer_container.html) registerer) |
| virtual void | [OnUdpNetworkHandlerTick](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a5c53bf86327084d6b36094652f9a8076) () |
| virtual void | [OnUdpNetworkHandlerClose](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a61aab8a2bbfe2e2bfbe70eb5646b02bd) () |
| virtual void | [HandleNewClientConnect](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a684b2bb60226f55ad7752a417fbdce56) ([PlayerConnectionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_player_connection_info.html) clientConnectionInfo) |
| virtual void | [HandleLateNewClientAfterSynchronized](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#ab3ff3f8b34cff3bf3179abbd858838de) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| virtual void | [HandleEarlyPlayerDisconnect](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a6ad7aa76f0bd9635689a16ecf697f24f) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| virtual void | [HandlePlayerDisconnect](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a42028d84ad1a39843cb532731fa76e14) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html) | |
| virtual void | [OnEndMission](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a2520fc88c264958b60ba7b75a4714117) () |
|  | Called right before the mission ends (i.e. after player clicks done/retreat button in battle results screen for SP missions). Preferably unregister all your [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) dependent events here. Some mission fields (like agent lists) will be deallocated after the mission ends. |

|  |  |
| --- | --- |
| Properties | |
| override bool | [IsGameModeHidingAllAgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#a260c57bbdacd2ef5c35c32eab29cb0b8) `[get]` |
| override bool | [IsGameModeUsingOpposingTeams](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#a9638ee122de6b1736138d97a8479e601) `[get]` |
| MBReadOnlyList< [FlagCapturePoint](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_flag_capture_point.html) > | [AllCapturePoints](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#ad4c45350469199f060eee1276d05bddb) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html) | |
| bool | [IsGameModeHidingAllAgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#a32c07bdd1bc1425c53d866c53adfbe38) `[get]` |
| bool | [IsGameModeUsingOpposingTeams](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#ad15399b6e5027f4e1941fedd1c597cd9) `[get]` |
| virtual bool | [IsGameModeAllowChargeDamageOnFriendly](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#adc0dad00d98e441df4710ccf307e5838) `[get]` |
| SpawnComponent | [SpawnComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#a2397c3d0f306e0eb961e3af5ef34e7a3) `[get]` |
| bool | [CanGameModeSystemsTickThisFrame](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#afb1d9b0ab7fbedbcb0043894b3f62e74) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.MissionLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html) | |
| override [MissionBehaviorType](namespace_tale_worlds_1_1_mount_and_blade.html#a372fbfd8b3eae375d7fd2e0dcbb76993) | [BehaviorType](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html#a22dc913ab511b0a23db3e6a09b76fcd7) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html) | |
| Mission | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aa8057eb8e1718954a667dc0c9a334281) `[get]` |
| [IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html) | [DebugInput](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ac73ea22074a4d9e10f0018fda1a4c67c) `[get]` |
| [MissionBehaviorType](namespace_tale_worlds_1_1_mount_and_blade.html#a372fbfd8b3eae375d7fd2e0dcbb76993) | [BehaviorType](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aca34f7ade7fa89aba9d51c8330684cc5) `[get]` |

|  |  |
| --- | --- |
| Events | |
| [OnDestructableComponentDestroyedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#ab322c7b723ba4c9753c01c71df27b61c) | [OnDestructableComponentDestroyed](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#a6206ae91ec593866e9e4077d8e65c986) |
| [OnObjectiveGoldGainedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#ac7176db2c556c1a443968f2ac81043ec) | [OnObjectiveGoldGained](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#a409f7ca102dbbcb5c8ea280a5d009b61) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Attributes inherited from [TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html) | |
| MultiplayerTeamSelectComponent | [MultiplayerTeamSelectComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#a880e4f4c1e0c83f652ec3151fa8ec924) |
| [MultiplayerRoundController](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_round_controller.html) | [RoundController](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#a454ee125307450a156c2b208e3703116) |
| [MultiplayerWarmupComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_warmup_component.html) | [WarmupComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#a4d7161f271f0f99fab36cff3990ea760) |
| [MultiplayerTimerComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_timer_component.html) | [TimerComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#a296fd3a1a91b6069cf34d0d437554542) |
| Protected Attributes inherited from [TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html) | |
| MissionLobbyComponent | [MissionLobbyComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#ab0f950ee4609a76738ffb65cbfaf005c) |
| [MultiplayerGameNotificationsComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_game_notifications_component.html) | [NotificationsComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#a031c8529a03b382cc4ef2851d8874118) |
| [MissionMultiplayerGameModeBaseClient](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base_client.html) | [GameModeBaseClient](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#ad807b4a04a93e0a02011bf31e030536f) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#ab322c7b723ba4c9753c01c71df27b61c)OnDestructableComponentDestroyedDelegate()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate void TaleWorlds.MountAndBlade.MissionMultiplayerSiege.OnDestructableComponentDestroyedDelegate | ( | [DestructableComponent](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html) | *destructableComponent*, |
|  |  | [ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | *attackerScriptComponentBehaviour*, |
|  |  | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html)[] | *contributors* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#ac7176db2c556c1a443968f2ac81043ec)OnObjectiveGoldGainedDelegate()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate void TaleWorlds.MountAndBlade.MissionMultiplayerSiege.OnObjectiveGoldGainedDelegate | ( | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) | *peer*, |
|  |  | int | *goldGain* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#ad6a735235c965ac361c43124e274696e)OnBehaviorInitialize()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MissionMultiplayerSiege.OnBehaviorInitialize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#a7e728d87e756e62faf89fded78a038d4).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#ab7febefdbe2a0dc7b99085824b92b3da)GetMissionType()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [MultiplayerGameType](namespace_tale_worlds_1_1_mount_and_blade.html#a53c1f5213197d059a513df159e2b79be) TaleWorlds.MountAndBlade.MissionMultiplayerSiege.GetMissionType | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#aeb2e4058159b3842737ab84bd54fe562)UseRoundController()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override bool TaleWorlds.MountAndBlade.MissionMultiplayerSiege.UseRoundController | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#a1dc1d21db21edec82a2b08e62e3a14eb).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#ab59f5752eb06e1aa711bfd5c728928de)AfterStart()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MissionMultiplayerSiege.AfterStart | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a693295e26d8b0fcf634c52b1c08fd974).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#ac3fdd12ba87fc0c452511e564e5486d1)OnMissionTick()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MissionMultiplayerSiege.OnMissionTick | ( | float | *dt* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#a272a170fa7059ae776b0a1c4ce6c153b).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#ac924ff9ed5469d61fb501950d8868226)CheckForMatchEnd()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override bool TaleWorlds.MountAndBlade.MissionMultiplayerSiege.CheckForMatchEnd | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#ab5a1a31085e85a39cc455c95a316b09c).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#a57843478b7d9aa4062180690c1ed6666)GetWinnerTeam()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) TaleWorlds.MountAndBlade.MissionMultiplayerSiege.GetWinnerTeam | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#a59efaeccfb9eb535f78dda135a8c06fe).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#a45d418ce3587fc39d5e34e1d2e476c1c)GetFlagOwnerTeam()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) TaleWorlds.MountAndBlade.MissionMultiplayerSiege.GetFlagOwnerTeam | ( | [FlagCapturePoint](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_flag_capture_point.html) | *flag* | ) |  |

Implements [TaleWorlds.MountAndBlade.IAnalyticsFlagInfo](interface_tale_worlds_1_1_mount_and_blade_1_1_i_analytics_flag_info.html#a2b515008ac2ef7c2e879963291af3c07).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#a7f53e8fc0a3e7a8aca6986763486f7b1)CheckForWarmupEnd()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override bool TaleWorlds.MountAndBlade.MissionMultiplayerSiege.CheckForWarmupEnd | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#a9d59ab9d43cbc0210ae372ceb5f7a63f).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#ab601a5921633cb2fc2fac8c1082307ce)HandleEarlyNewClientAfterLoadingFinished()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MissionMultiplayerSiege.HandleEarlyNewClientAfterLoadingFinished | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionNetwork](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#ada8d7710e31d528e4b7d7d60fee10477).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#aaa0e8b299d8786d8b1372881a45362e8)HandleNewClientAfterSynchronized()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MissionMultiplayerSiege.HandleNewClientAfterSynchronized | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionNetwork](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a73a47ad2db0dedde69dd82c59400e58a).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#a3222912a8574a7e7458ad2bf06d032cf)OnPeerChangedTeam()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MissionMultiplayerSiege.OnPeerChangedTeam | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *peer*, | |  |  | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *oldTeam*, | |  |  | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *newTeam* ) | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#ad1a4922b197251ac0bb2ebf221ed4d1d).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#a1d4e9d93a7a16ae2d1478d0f38e308e1)OnAgentRemoved()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MissionMultiplayerSiege.OnAgentRemoved | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *affectedAgent*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *affectorAgent*, | |  |  | [AgentState](namespace_tale_worlds_1_1_core.html#a799bcc77ddb6372c7383f3340ed4d1c0) | *agentState*, | |  |  | [KillingBlow](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html) | *blow* ) | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ad4987b5b5e719f90cad1856b8c0b7976).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#ac79fafd46c6ee8193eabdbd74f60ec4f)HandleNewClientAfterLoadingFinished()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MissionMultiplayerSiege.HandleNewClientAfterLoadingFinished | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionNetwork](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a2ae30190712925d7a1a02b9b76810fe9).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#a8f54549cf58b43183e3e5a8eff6163f9)OnRemoveBehavior()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MissionMultiplayerSiege.OnRemoveBehavior | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a80cb93b393ebaa09e4fd5fbab467556f).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#a6558f93067367da4eab81b98260bdaf1)OnClearScene()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MissionMultiplayerSiege.OnClearScene | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#a2209c76975dbf85d87c0085ba9b924df).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#a7c52ba9a166ebdcdc57859410600e472)NumberOfFlagsInGame
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.MountAndBlade.MissionMultiplayerSiege.NumberOfFlagsInGame = 6 + 1 | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#a9b30e9d70a698d5847b71d1168f827ff)NumberOfFlagsAffectingMoraleInGame
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.MountAndBlade.MissionMultiplayerSiege.NumberOfFlagsAffectingMoraleInGame = [NumberOfFlagsInGame](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#a7c52ba9a166ebdcdc57859410600e472) - 1 | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#acdea28f776adb4bba25c55e77e85e754)MaxMorale
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.MountAndBlade.MissionMultiplayerSiege.MaxMorale = [StartingMorale](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#a37a0d5d6d3c58fc200f3a9a5b8e588ba) + (([MaxMoraleGainPerFlag](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#a9a67d22f32f43e4c57ecb789ded7b0ce) + MoraleBoostOnFlagRemoval) \* [NumberOfFlagsAffectingMoraleInGame](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#a9b30e9d70a698d5847b71d1168f827ff)) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#a37a0d5d6d3c58fc200f3a9a5b8e588ba)StartingMorale
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.MountAndBlade.MissionMultiplayerSiege.StartingMorale = 360 | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#a9a67d22f32f43e4c57ecb789ded7b0ce)MaxMoraleGainPerFlag
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.MountAndBlade.MissionMultiplayerSiege.MaxMoraleGainPerFlag = 90 | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#a063d86364238a252fb1d61b2e0b64261)MoraleGainPerFlag
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.MountAndBlade.MissionMultiplayerSiege.MoraleGainPerFlag = 1 | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#a5a9f7bd4ea8c5cb05ecf1c39c40f66db)GoldBonusOnFlagRemoval
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.MountAndBlade.MissionMultiplayerSiege.GoldBonusOnFlagRemoval = 35 | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#ac4cb56bb41a999bbbda5be6eab5f5fb3)MasterFlagTag
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.MissionMultiplayerSiege.MasterFlagTag = "keep\_capture\_point" | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#a260c57bbdacd2ef5c35c32eab29cb0b8)IsGameModeHidingAllAgentVisuals
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override bool TaleWorlds.MountAndBlade.MissionMultiplayerSiege.IsGameModeHidingAllAgentVisuals | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#a9638ee122de6b1736138d97a8479e601)IsGameModeUsingOpposingTeams
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override bool TaleWorlds.MountAndBlade.MissionMultiplayerSiege.IsGameModeUsingOpposingTeams | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#ad4c45350469199f060eee1276d05bddb)AllCapturePoints
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[FlagCapturePoint](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_flag_capture_point.html)> TaleWorlds.MountAndBlade.MissionMultiplayerSiege.AllCapturePoints | | get |

Implements [TaleWorlds.MountAndBlade.IAnalyticsFlagInfo](interface_tale_worlds_1_1_mount_and_blade_1_1_i_analytics_flag_info.html#a1823aa55b5e7436ac8ace35afcad46d2).

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#a6206ae91ec593866e9e4077d8e65c986)OnDestructableComponentDestroyed
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [OnDestructableComponentDestroyedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#ab322c7b723ba4c9753c01c71df27b61c) TaleWorlds.MountAndBlade.MissionMultiplayerSiege.OnDestructableComponentDestroyed |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#a409f7ca102dbbcb5c8ea280a5d009b61)OnObjectiveGoldGained
------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [OnObjectiveGoldGainedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#ac7176db2c556c1a443968f2ac81043ec) TaleWorlds.MountAndBlade.MissionMultiplayerSiege.OnObjectiveGoldGained |

