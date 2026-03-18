--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html ---

TaleWorlds.MountAndBlade.MissionAgentSpawnLogic Class ReferenceInherits [TaleWorlds.MountAndBlade.MissionLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html), and [TaleWorlds.MountAndBlade.IMissionAgentSpawnLogic](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_agent_spawn_logic.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| delegate void | [OnPhaseChangedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a42c175afef4a94b52fcb79313b3905f0) () |
| override void | [AfterStart](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a990c8a307d592320971345b605fdf0c3) () |
| int | [GetNumberOfPlayerControllableTroops](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a0530a58d837329716d00a6137ac5eda2) () |
| void | [InitWithSinglePhase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a316d5d6596788a17dc6a8b0cc38a2873) (int defenderTotalSpawn, int attackerTotalSpawn, int defenderInitialSpawn, int attackerInitialSpawn, bool spawnDefenders, bool spawnAttackers, in [MissionSpawnSettings](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html) spawnSettings) |
|  | Initializes a single phase mission spawn logic. |
| IEnumerable< [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) > | [GetAllTroopsForSide](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#ad9bc5eb99a3ad43e378a776b6325573c) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| override void | [OnMissionTick](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#ad8ca9aa0ce221a5572e860663ab6bb5c) (float dt) |
|  | [MissionAgentSpawnLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#aa4bd0195c043326906ff0b060918915a) ([IMissionTroopSupplier](interface_tale_worlds_1_1_core_1_1_i_mission_troop_supplier.html)[] suppliers, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) playerSide, [Mission.BattleSizeType](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a4e0efc500dfb2fe7ca70dfb58ff7e1c5) battleSizeType) |
| void | [SetCustomReinforcementSpawnTimer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#ae1e3b81308f14b24885e736b3014b2b1) ([ICustomReinforcementSpawnTimer](interface_tale_worlds_1_1_mount_and_blade_1_1_i_custom_reinforcement_spawn_timer.html) timer) |
| void | [SetSpawnTroops](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a2220b23f20fc3961294211f0bf06e710) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, bool spawnTroops, bool enforceSpawning=false) |
| override void | [OnBehaviorInitialize](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#af6ef7250c942e0fe3f93b0e590a89a3d) () |
| void | [SetSpawnHorses](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a01ce39716f703b2ff4ab1b5f541491cd) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, bool spawnHorses) |
| void | [StartSpawner](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#ac56087167ace1de5fa9ef38a8ab8e556) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| void | [StopSpawner](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#ad5862991906afadaa79d5cfd66846fb0) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| bool | [IsSideSpawnEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a36684cb9f9468cc226c4854519523cff) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| void | [OnSideDeploymentOver](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a7542b4e67b61c8c4d5a03cfb22e048df) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) battleSide) |
| float | [GetReinforcementInterval](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a8a862d9890b4cb578795ec9ae5e6e759) () |
| void | [SetReinforcementsSpawnEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#ae82ffda4fc72c4d67c1dc14c10a02620) (bool value, bool resetTimers=true) |
| int | [GetTotalNumberOfTroopsForSide](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a5ad06d83ca3c4013c817c9b2401308b6) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | [GetGeneralCharacterOfSide](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a9bf1fc7f2ecf5b4f860321ff988cdb3d) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| bool | [GetSpawnHorses](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a102210459342f5fdd4fb6b50e886ecce) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| bool | [IsSideDepleted](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a6498136267f72c0b0192ddf35d08c816) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| void | [AddPhaseChangeAction](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#afa8ecef91ff6ff4d1e9318add2dece32) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, [OnPhaseChangedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a42c175afef4a94b52fcb79313b3905f0) onPhaseChanged) |
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
| Protected Member Functions | |
| override void | [OnEndMission](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#abb481428cf50b081ff24b7e14e6fd49d) () |
|  | Called right before the mission ends (i.e. after player clicks done/retreat button in battle results screen for SP missions). Preferably unregister all your [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) dependent events here. Some mission fields (like agent lists) will be deallocated after the mission ends. |

|  |  |
| --- | --- |
| Properties | |
| static int | [MaxNumberOfAgentsForMission](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#ab28861efb2be3463225fbfdf44f3d187) `[get]` |
| int | [NumberOfAgents](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a90d75972772986ee0f34f90b50b16317) `[get]` |
| int | [NumberOfRemainingTroops](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#ad91f81922833255a8f90758dc55254c3) `[get]` |
| int | [NumberOfActiveDefenderTroops](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a4198540b67eb0de40eda463abce31273) `[get]` |
| int | [NumberOfActiveAttackerTroops](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#acf9248f0212ee1221db77aa2c0d424e2) `[get]` |
| int | [NumberOfRemainingDefenderTroops](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a74d41fca76c27c7f25cbb7ee57af2ee5) `[get]` |
| int | [NumberOfRemainingAttackerTroops](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#aca1ef9acac862b53165942326dcbb525) `[get]` |
| int | [BattleSize](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a813acec2ec92423768008af8daa82b64) `[get]` |
| bool | [IsInitialSpawnOver](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a9caa8e17530574e1762257e26571b3fb) `[get]` |
|  | This is true only when initial set of troops are spawned for both sides. Order of battle deployment phase may or may not be finalized yet. |
| bool | [IsDeploymentOver](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a8e922daad7771781a3fe5ae21682d432) `[get]` |
|  | This is true when initial troops are spawned and Order of Battle deployment phase is finalized by starting the mission. |
| ref readonly [MissionSpawnSettings](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html) | [ReinforcementSpawnSettings](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a6a2d1434f92242a2d283c3afedeeedc9) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.MissionLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html) | |
| override [MissionBehaviorType](namespace_tale_worlds_1_1_mount_and_blade.html#a372fbfd8b3eae375d7fd2e0dcbb76993) | [BehaviorType](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html#a22dc913ab511b0a23db3e6a09b76fcd7) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html) | |
| Mission | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aa8057eb8e1718954a667dc0c9a334281) `[get]` |
| [IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html) | [DebugInput](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ac73ea22074a4d9e10f0018fda1a4c67c) `[get]` |
| [MissionBehaviorType](namespace_tale_worlds_1_1_mount_and_blade.html#a372fbfd8b3eae375d7fd2e0dcbb76993) | [BehaviorType](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aca34f7ade7fa89aba9d51c8330684cc5) `[get]` |

|  |  |
| --- | --- |
| Events | |
| Action< [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c), int > | [OnReinforcementsSpawned](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a9a38bd4777e8d63213db44837f7af20c) |
| Action< [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c), int > | [OnInitialTroopsSpawned](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a9ca54a3573ebc7099909bacd8fcbb372) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#aa4bd0195c043326906ff0b060918915a)MissionAgentSpawnLogic()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.MissionAgentSpawnLogic.MissionAgentSpawnLogic | ( | [IMissionTroopSupplier](interface_tale_worlds_1_1_core_1_1_i_mission_troop_supplier.html)[] | *suppliers*, |
|  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *playerSide*, |
|  |  | [Mission.BattleSizeType](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#a4e0efc500dfb2fe7ca70dfb58ff7e1c5) | *battleSizeType* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a42c175afef4a94b52fcb79313b3905f0)OnPhaseChangedDelegate()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| delegate void TaleWorlds.MountAndBlade.MissionAgentSpawnLogic.OnPhaseChangedDelegate | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a990c8a307d592320971345b605fdf0c3)AfterStart()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MissionAgentSpawnLogic.AfterStart | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a693295e26d8b0fcf634c52b1c08fd974).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a0530a58d837329716d00a6137ac5eda2)GetNumberOfPlayerControllableTroops()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.MissionAgentSpawnLogic.GetNumberOfPlayerControllableTroops | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IMissionAgentSpawnLogic](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_agent_spawn_logic.html#a690a16588e26a38919348943c0f447da).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a316d5d6596788a17dc6a8b0cc38a2873)InitWithSinglePhase()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionAgentSpawnLogic.InitWithSinglePhase | ( | int | *defenderTotalSpawn*, |
|  |  | int | *attackerTotalSpawn*, |
|  |  | int | *defenderInitialSpawn*, |
|  |  | int | *attackerInitialSpawn*, |
|  |  | bool | *spawnDefenders*, |
|  |  | bool | *spawnAttackers*, |
|  |  | in [MissionSpawnSettings](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html) | *spawnSettings* ) |

Parameters
:   |  |  |
    | --- | --- |
    | defenderTotalSpawn | Total number of defenders to spawn |
    | attackerTotalSpawn | Total number of attackers to spawn |
    | defenderInitialSpawn | Number of initial defenders to spawn. Remainders will spawn as reinforcements |
    | attackerInitialSpawn | Number of initial attackers to spawn. Remainders will spawn as reinforcements |
    | spawnDefenders | Immediately spawn initial defenders within this method. If set to false mission logics will decide when to spawn them |
    | spawnAttackers | Immediately spawn attacker defenders within this method. If set to false mission logics will decide when to spawn them |
    | spawnSettings | Configuration to decide number of reinforcements and reinforcement spawn intervals |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#ad9bc5eb99a3ad43e378a776b6325573c)GetAllTroopsForSide()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| IEnumerable< [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) > TaleWorlds.MountAndBlade.MissionAgentSpawnLogic.GetAllTroopsForSide | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* | ) |  |

Implements [TaleWorlds.MountAndBlade.IMissionAgentSpawnLogic](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_agent_spawn_logic.html#a0d6f98421f0f39952e257c253843916b).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#ad8ca9aa0ce221a5572e860663ab6bb5c)OnMissionTick()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MissionAgentSpawnLogic.OnMissionTick | ( | float | *dt* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a006b322c9ef8b55a1897419394c0a1e4).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#ae1e3b81308f14b24885e736b3014b2b1)SetCustomReinforcementSpawnTimer()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionAgentSpawnLogic.SetCustomReinforcementSpawnTimer | ( | [ICustomReinforcementSpawnTimer](interface_tale_worlds_1_1_mount_and_blade_1_1_i_custom_reinforcement_spawn_timer.html) | *timer* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a2220b23f20fc3961294211f0bf06e710)SetSpawnTroops()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionAgentSpawnLogic.SetSpawnTroops | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side*, |
|  |  | bool | *spawnTroops*, |
|  |  | bool | *enforceSpawning* = false ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#af6ef7250c942e0fe3f93b0e590a89a3d)OnBehaviorInitialize()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MissionAgentSpawnLogic.OnBehaviorInitialize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a94e4fe46fad26b2a84dbbf3a4a5cc14c).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#abb481428cf50b081ff24b7e14e6fd49d)OnEndMission()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MissionAgentSpawnLogic.OnEndMission | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a2520fc88c264958b60ba7b75a4714117).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a01ce39716f703b2ff4ab1b5f541491cd)SetSpawnHorses()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionAgentSpawnLogic.SetSpawnHorses | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side*, |
|  |  | bool | *spawnHorses* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#ac56087167ace1de5fa9ef38a8ab8e556)StartSpawner()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionAgentSpawnLogic.StartSpawner | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* | ) |  |

Implements [TaleWorlds.MountAndBlade.IMissionAgentSpawnLogic](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_agent_spawn_logic.html#a884b47a1953fb9c95ec61dc9c18b6194).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#ad5862991906afadaa79d5cfd66846fb0)StopSpawner()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionAgentSpawnLogic.StopSpawner | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* | ) |  |

Implements [TaleWorlds.MountAndBlade.IMissionAgentSpawnLogic](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_agent_spawn_logic.html#a9b842b224a4befa78f5a7a724ae68a38).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a36684cb9f9468cc226c4854519523cff)IsSideSpawnEnabled()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MissionAgentSpawnLogic.IsSideSpawnEnabled | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* | ) |  |

Implements [TaleWorlds.MountAndBlade.IMissionAgentSpawnLogic](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_agent_spawn_logic.html#a13188fe80cff58187c8b9a9bb9b4e7bf).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a7542b4e67b61c8c4d5a03cfb22e048df)OnSideDeploymentOver()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionAgentSpawnLogic.OnSideDeploymentOver | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *battleSide* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a8a862d9890b4cb578795ec9ae5e6e759)GetReinforcementInterval()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.MissionAgentSpawnLogic.GetReinforcementInterval | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IMissionAgentSpawnLogic](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_agent_spawn_logic.html#a591fa1f53ff44cda88e12d85d4c7ae96).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#ae82ffda4fc72c4d67c1dc14c10a02620)SetReinforcementsSpawnEnabled()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionAgentSpawnLogic.SetReinforcementsSpawnEnabled | ( | bool | *value*, |
|  |  | bool | *resetTimers* = true ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a5ad06d83ca3c4013c817c9b2401308b6)GetTotalNumberOfTroopsForSide()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.MissionAgentSpawnLogic.GetTotalNumberOfTroopsForSide | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a9bf1fc7f2ecf5b4f860321ff988cdb3d)GetGeneralCharacterOfSide()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) TaleWorlds.MountAndBlade.MissionAgentSpawnLogic.GetGeneralCharacterOfSide | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a102210459342f5fdd4fb6b50e886ecce)GetSpawnHorses()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MissionAgentSpawnLogic.GetSpawnHorses | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* | ) |  |

Implements [TaleWorlds.MountAndBlade.IMissionAgentSpawnLogic](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_agent_spawn_logic.html#a660103f24699cf870f8172b34c5e18d2).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a6498136267f72c0b0192ddf35d08c816)IsSideDepleted()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MissionAgentSpawnLogic.IsSideDepleted | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* | ) |  |

Implements [TaleWorlds.MountAndBlade.IMissionAgentSpawnLogic](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_agent_spawn_logic.html#af226ef1e37593fedfc3b1176705994fd).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#afa8ecef91ff6ff4d1e9318add2dece32)AddPhaseChangeAction()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionAgentSpawnLogic.AddPhaseChangeAction | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side*, |
|  |  | [OnPhaseChangedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a42c175afef4a94b52fcb79313b3905f0) | *onPhaseChanged* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#ab28861efb2be3463225fbfdf44f3d187)MaxNumberOfAgentsForMission
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.MissionAgentSpawnLogic.MaxNumberOfAgentsForMission | | staticget |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a90d75972772986ee0f34f90b50b16317)NumberOfAgents
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.MissionAgentSpawnLogic.NumberOfAgents | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#ad91f81922833255a8f90758dc55254c3)NumberOfRemainingTroops
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.MissionAgentSpawnLogic.NumberOfRemainingTroops | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a4198540b67eb0de40eda463abce31273)NumberOfActiveDefenderTroops
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.MissionAgentSpawnLogic.NumberOfActiveDefenderTroops | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#acf9248f0212ee1221db77aa2c0d424e2)NumberOfActiveAttackerTroops
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.MissionAgentSpawnLogic.NumberOfActiveAttackerTroops | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a74d41fca76c27c7f25cbb7ee57af2ee5)NumberOfRemainingDefenderTroops
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.MissionAgentSpawnLogic.NumberOfRemainingDefenderTroops | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#aca1ef9acac862b53165942326dcbb525)NumberOfRemainingAttackerTroops
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.MissionAgentSpawnLogic.NumberOfRemainingAttackerTroops | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a813acec2ec92423768008af8daa82b64)BattleSize
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.MissionAgentSpawnLogic.BattleSize | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a9caa8e17530574e1762257e26571b3fb)IsInitialSpawnOver
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.MissionAgentSpawnLogic.IsInitialSpawnOver | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a8e922daad7771781a3fe5ae21682d432)IsDeploymentOver
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.MissionAgentSpawnLogic.IsDeploymentOver | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a6a2d1434f92242a2d283c3afedeeedc9)ReinforcementSpawnSettings
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ref readonly [MissionSpawnSettings](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_spawn_settings.html) TaleWorlds.MountAndBlade.MissionAgentSpawnLogic.ReinforcementSpawnSettings | | get |

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a9a38bd4777e8d63213db44837f7af20c)OnReinforcementsSpawned
--------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c), int> TaleWorlds.MountAndBlade.MissionAgentSpawnLogic.OnReinforcementsSpawned |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_agent_spawn_logic.html#a9ca54a3573ebc7099909bacd8fcbb372)OnInitialTroopsSpawned
-------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c), int> TaleWorlds.MountAndBlade.MissionAgentSpawnLogic.OnInitialTroopsSpawned |

