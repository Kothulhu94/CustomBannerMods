--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_siege_deployment_handler.html ---

TaleWorlds.MountAndBlade.Missions.Handlers.SiegeDeploymentHandler Class ReferenceInherits [TaleWorlds.MountAndBlade.Missions.Handlers.BattleDeploymentHandler](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_battle_deployment_handler.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [SiegeDeploymentHandler](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_siege_deployment_handler.html#a1f11cb74a2f4fa18e94a09b64c19dcf7) (bool isPlayerAttacker) |
| override void | [OnBehaviorInitialize](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_siege_deployment_handler.html#abede45ae2a44a4db9400698d744fe780) () |
| override void | [OnRemoveBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_siege_deployment_handler.html#a2e39dafe39e450aab16a9e88c55b0b60) () |
| override void | [AfterStart](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_siege_deployment_handler.html#a95704d42b7c830dc8aeca7a5807367ea) () |
| override void | [FinishDeployment](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_siege_deployment_handler.html#a11665ff061b256ac552d4769fd66f2ed) () |
| void | [DeployAllSiegeWeaponsOfPlayer](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_siege_deployment_handler.html#ab5c925f5b4e6e8f148c5189a282cea1c) () |
| int | [GetMaxDeployableWeaponCountOfPlayer](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_siege_deployment_handler.html#a16d28506093db6143267a7e5ce66af0e) (Type weapon) |
| void | [DeployAllSiegeWeaponsOfAi](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_siege_deployment_handler.html#a8223ce8a41e8eb2eb7a2864ca2039982) () |
| void | [RemoveDeploymentPoints](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_siege_deployment_handler.html#a6448a5ef9752c50a5481d9f2ae6935a9) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| void | [RemoveUnavailableDeploymentPoints](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_siege_deployment_handler.html#a957d103cc0e4fe9d2d8d6fb45c594d95) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| void | [UnHideDeploymentPoints](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_siege_deployment_handler.html#ae6d321c403f7bbf9f0d651b260b87535) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| int | [GetDeployableWeaponCountOfPlayer](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_siege_deployment_handler.html#a53c2c4aa8b1a157ab216a4597bd6d76a) (Type weapon) |
| void | [AutoDeployTeamUsingTeamAI](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_siege_deployment_handler.html#a217d26949f2194971fa79585b6d60bb8) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, bool autoAssignDetachments=true) |
|  | Delivers the team to [AI](namespace_tale_worlds_1_1_mount_and_blade_1_1_a_i.html) control for one tick and lets team [AI](namespace_tale_worlds_1_1_mount_and_blade_1_1_a_i.html) auto deploy the team. Transfering troops within formations and carrying formations to their Locations w.r.t. mission type (i.e. archer formations will be moved to walls). |
| void | [AutoAssignDetachmentsForDeployment](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_siege_deployment_handler.html#a084c4aceb0e7746a6d601767b5fd9600) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
|  | Automatically assigns and teleports agents to their detachments during OOB deployment. |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetEstimatedAverageDefenderPosition](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_siege_deployment_handler.html#a5409aa42f19f906809d78eded79ff118) () |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.Missions.Handlers.BattleDeploymentHandler](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_battle_deployment_handler.html) | |
|  | [BattleDeploymentHandler](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_battle_deployment_handler.html#a03763e3fc79138ad2e82bc9aeacd40bc) (bool isPlayerAttacker) |
| override void | [AutoDeployTeamUsingDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_battle_deployment_handler.html#a3db22b6a56ddc9a2103b4d8b95bbdb3d) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
|  | Auto-Deploys a team by teleporting all of its formations to frames specified by the current deployment plan. |
| override void | [ForceUpdateAllUnits](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_battle_deployment_handler.html#a3a125318cce189f6ad0501211bc04d21) () |
| void | [SetDefaultFormationOrders](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_battle_deployment_handler.html#af77a0d75f291c722754f0a4ac25d24c5) ([OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html) orderController) |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.DeploymentHandler](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_handler.html) | |
|  | [DeploymentHandler](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_handler.html#a0b7f6cb1aa8e410d3e3d1468721d15a1) (bool isPlayerAttacker) |
| override void | [EarlyStart](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_handler.html#a619d9b9d9d6df3bc7ba360770efd194e) () |
| override void | [OnBattleSideDeployed](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_handler.html#ab85a317a3dac1679c1a2774e74078b0e) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| void | [AutoDeployTeamUsingDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_handler.html#aa113034e8e414e1adeb22688d599ed3c) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) playerTeam) |
| void | [ForceUpdateAllUnits](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_handler.html#ad4141895c122cbccf04c32ddcac37fc3) () |
| void | [InitializeDeploymentPoints](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_handler.html#a75a0e8a6db6320aea9933631d0103dca) () |
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
| virtual void | [OnCreated](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a29e57cd652228fc81feee9a78a31121f) () |
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
| virtual void | [OnAgentAlarmedStateChanged](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a5a44a2daafc6b4a8b478e3dd2309ac20) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [Agent.AIStateFlag](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a9bf7959dd8d468ef55afa4b4a53e0995) flag) |
| virtual void | [OnMissionModeChange](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a11fc0970636713f77872610dd41fdf4f) ([MissionMode](namespace_tale_worlds_1_1_core.html#a34f0ac611df16851fc92e4523aa834e1) oldMissionMode, bool atStart) |
| virtual void | [OnRegisterBlow](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#afc94274b34e25df5c68187631baa9a4b) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attacker, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victim, [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) realHitEntity, [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) b, ref [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) attackerWeapon) |
| virtual void | [OnAgentShootMissile](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a1bbc0267645d0d331b951ec340f5e01c) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) shooterAgent, [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) weaponIndex, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) velocity, [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html) orientation, bool hasRigidBody, int forcedMissileIndex) |
| virtual void | [OnMissileRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a0353cba934ad1a0fe6e72ca6555f1f7c) (int MissileIndex) |
| virtual void | [OnTutorialCompleted](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a64007b92eb1f373cf2b66dcf901ffe43) (string completedTutorialIdentifier) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| bool | [Mission\_IsFormationUnitPositionAvailable\_AdditionalCondition](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_siege_deployment_handler.html#afc77d94059705971250b1f0fbe293cfe) ([WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) position, [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html) | |
| virtual void | [OnEndMission](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a2520fc88c264958b60ba7b75a4714117) () |
|  | Called right before the mission ends (i.e. after player clicks done/retreat button in battle results screen for SP missions). Preferably unregister all your [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) dependent events here. Some mission fields (like agent lists) will be deallocated after the mission ends. |

|  |  |
| --- | --- |
| Properties | |
| IEnumerable< [DeploymentPoint](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html) > | [PlayerDeploymentPoints](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_siege_deployment_handler.html#a83cf406a4b5fc62d3eff800ff3d910fb) `[get]` |
| IEnumerable< [DeploymentPoint](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html) > | [AllDeploymentPoints](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_siege_deployment_handler.html#aa8cf25d7b4043830f11f51415ae48b08) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.DeploymentHandler](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_handler.html) | |
| [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | [PlayerTeam](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_handler.html#a0eb30524153b0db40acae2b82c452440) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.MissionLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html) | |
| override [MissionBehaviorType](namespace_tale_worlds_1_1_mount_and_blade.html#a372fbfd8b3eae375d7fd2e0dcbb76993) | [BehaviorType](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html#a22dc913ab511b0a23db3e6a09b76fcd7) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html) | |
| Mission | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aa8057eb8e1718954a667dc0c9a334281) `[get]` |
| [IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html) | [DebugInput](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ac73ea22074a4d9e10f0018fda1a4c67c) `[get]` |
| [MissionBehaviorType](namespace_tale_worlds_1_1_mount_and_blade.html#a372fbfd8b3eae375d7fd2e0dcbb76993) | [BehaviorType](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aca34f7ade7fa89aba9d51c8330684cc5) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Protected Attributes inherited from [TaleWorlds.MountAndBlade.DeploymentHandler](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_handler.html) | |
| [MissionMode](namespace_tale_worlds_1_1_core.html#a34f0ac611df16851fc92e4523aa834e1) | [PreviousMissionMode](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_handler.html#a5b9481040082bcd3a4ffce8566be466c) |
| readonly bool | [IsPlayerAttacker](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_handler.html#acea83eb4e4fe7f6c54834e8c49b75736) |
| [DeploymentMissionController](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_mission_controller.html) | [\_deploymentMissionController](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_handler.html#a2a67dda6072aa72cae58152de70989be) |
| Events inherited from [TaleWorlds.MountAndBlade.DeploymentHandler](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_handler.html) | |
| Action | [OnPlayerSideDeploymentReady](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_handler.html#a148faf2e15c1ba0deed145a6ea9d07c2) |
| Action | [OnEnemySideDeploymentReady](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_handler.html#afcf6c41e3631ba9964996c3ef131ebf4) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_siege_deployment_handler.html#a1f11cb74a2f4fa18e94a09b64c19dcf7)SiegeDeploymentHandler()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.Missions.Handlers.SiegeDeploymentHandler.SiegeDeploymentHandler | ( | bool | *isPlayerAttacker* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_siege_deployment_handler.html#abede45ae2a44a4db9400698d744fe780)OnBehaviorInitialize()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.Missions.Handlers.SiegeDeploymentHandler.OnBehaviorInitialize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.DeploymentHandler](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_handler.html#a05a7e541e25e3990627d808c74a1c997).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_siege_deployment_handler.html#a2e39dafe39e450aab16a9e88c55b0b60)OnRemoveBehavior()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.Missions.Handlers.SiegeDeploymentHandler.OnRemoveBehavior | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.Missions.Handlers.BattleDeploymentHandler](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_battle_deployment_handler.html#ac098d23010a058e88a195c8f7ac4e246).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_siege_deployment_handler.html#a95704d42b7c830dc8aeca7a5807367ea)AfterStart()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.Missions.Handlers.SiegeDeploymentHandler.AfterStart | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.Missions.Handlers.BattleDeploymentHandler](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_battle_deployment_handler.html#a825e612b31911e3625cb32e4086ccd53).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_siege_deployment_handler.html#a11665ff061b256ac552d4769fd66f2ed)FinishDeployment()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.Missions.Handlers.SiegeDeploymentHandler.FinishDeployment | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.DeploymentHandler](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_handler.html#a50a3111a9ba69ff239790149f3351d26).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_siege_deployment_handler.html#ab5c925f5b4e6e8f148c5189a282cea1c)DeployAllSiegeWeaponsOfPlayer()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Missions.Handlers.SiegeDeploymentHandler.DeployAllSiegeWeaponsOfPlayer | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_siege_deployment_handler.html#a16d28506093db6143267a7e5ce66af0e)GetMaxDeployableWeaponCountOfPlayer()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.Missions.Handlers.SiegeDeploymentHandler.GetMaxDeployableWeaponCountOfPlayer | ( | Type | *weapon* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_siege_deployment_handler.html#a8223ce8a41e8eb2eb7a2864ca2039982)DeployAllSiegeWeaponsOfAi()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Missions.Handlers.SiegeDeploymentHandler.DeployAllSiegeWeaponsOfAi | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_siege_deployment_handler.html#a6448a5ef9752c50a5481d9f2ae6935a9)RemoveDeploymentPoints()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Missions.Handlers.SiegeDeploymentHandler.RemoveDeploymentPoints | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_siege_deployment_handler.html#a957d103cc0e4fe9d2d8d6fb45c594d95)RemoveUnavailableDeploymentPoints()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Missions.Handlers.SiegeDeploymentHandler.RemoveUnavailableDeploymentPoints | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_siege_deployment_handler.html#ae6d321c403f7bbf9f0d651b260b87535)UnHideDeploymentPoints()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Missions.Handlers.SiegeDeploymentHandler.UnHideDeploymentPoints | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_siege_deployment_handler.html#a53c2c4aa8b1a157ab216a4597bd6d76a)GetDeployableWeaponCountOfPlayer()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.Missions.Handlers.SiegeDeploymentHandler.GetDeployableWeaponCountOfPlayer | ( | Type | *weapon* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_siege_deployment_handler.html#a217d26949f2194971fa79585b6d60bb8)AutoDeployTeamUsingTeamAI()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Missions.Handlers.SiegeDeploymentHandler.AutoDeployTeamUsingTeamAI | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, |
|  |  | bool | *autoAssignDetachments* = true ) |

Parameters
:   |  |  |
    | --- | --- |
    | team | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) to be deployed |
    | enforceNotSplittableByAI | If set [AI](namespace_tale_worlds_1_1_mount_and_blade_1_1_a_i.html) can never split formations (i.e. transfer troops in between them) during deployment. |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_siege_deployment_handler.html#a084c4aceb0e7746a6d601767b5fd9600)AutoAssignDetachmentsForDeployment()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Missions.Handlers.SiegeDeploymentHandler.AutoAssignDetachmentsForDeployment | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | team | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) for which assignment will be made |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_siege_deployment_handler.html#afc77d94059705971250b1f0fbe293cfe)Mission\_IsFormationUnitPositionAvailable\_AdditionalCondition()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.Missions.Handlers.SiegeDeploymentHandler.Mission\_IsFormationUnitPositionAvailable\_AdditionalCondition | ( | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *position*, | |  |  | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team* ) | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_siege_deployment_handler.html#a5409aa42f19f906809d78eded79ff118)GetEstimatedAverageDefenderPosition()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.Missions.Handlers.SiegeDeploymentHandler.GetEstimatedAverageDefenderPosition | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_siege_deployment_handler.html#a83cf406a4b5fc62d3eff800ff3d910fb)PlayerDeploymentPoints
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IEnumerable<[DeploymentPoint](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html)> TaleWorlds.MountAndBlade.Missions.Handlers.SiegeDeploymentHandler.PlayerDeploymentPoints | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_siege_deployment_handler.html#aa8cf25d7b4043830f11f51415ae48b08)AllDeploymentPoints
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IEnumerable<[DeploymentPoint](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html)> TaleWorlds.MountAndBlade.Missions.Handlers.SiegeDeploymentHandler.AllDeploymentPoints | | get |

