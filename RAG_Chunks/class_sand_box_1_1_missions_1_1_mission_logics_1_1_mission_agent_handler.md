--- SOURCE: class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html ---

SandBox.Missions.MissionLogics.MissionAgentHandler Class ReferenceInherits [TaleWorlds.MountAndBlade.MissionLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| bool | [HasPassages](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#a5688d6f181447c0e9c59f3815feccb03) () |
|  | [MissionAgentHandler](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#ac43c82811ac2374594b1dca2f40043ad) () |
| override void | [EarlyStart](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#af6644120e55736b8185aaeb7366b8132) () |
| override void | [OnRenderingStarted](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#a667752161b8e96a31095b8370440d994) () |
| override void | [OnMissionTick](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#a49484ea8f74536034224f3b483c6a9db) (float dt) |
| override void | [OnMissionModeChange](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#a0ad57fb88028b0910bdc5862f13c6fa1) ([MissionMode](namespace_tale_worlds_1_1_core.html#a34f0ac611df16851fc92e4523aa834e1) oldMissionMode, bool atStart) |
| override void | [OnAgentRemoved](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#aec2d7cce4c1b3ebbaeef4089e8593918) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectedAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectorAgent, [AgentState](namespace_tale_worlds_1_1_core.html#a799bcc77ddb6372c7383f3340ed4d1c0) agentState, [KillingBlow](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html) killingBlow) |
| void | [DetectMissingEntities](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#a5a327a4a1767946722217eb73ec1acf8) () |
| Dictionary< string, int > | [FindUnusedUsablePointCount](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#a6c7ea27398bfc36dbd72787fa5cdcc77) () |
| void | [SpawnLocationCharacters](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#a7a218de9744a75abcbc3be7e6e24943f) (string overridenTagValue=null) |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [SpawnDefaultLocationCharacter](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#a92443ed2198313ce7ed4fc1c7de50ff6) ([LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) locationCharacter, bool simulateAgentAfterSpawn=false) |
| void | [SimulateAgent](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#ac98ac793a1daa18483e034c4f8284765) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| void | [FadeoutExitingLocationCharacter](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#a71b3181300bffbdd1f379651f0920f40) ([LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) locationCharacter) |
| void | [SpawnEnteringLocationCharacter](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#afaae81c76d0043440c6bc9d62881d219) ([LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) locationCharacter, [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) fromLocation) |
| bool | [HasUsablePointWithTag](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#afee45f97b1be49917911e7cd8ea8d606) (string tag) |
| IEnumerable< string > | [GetAllSpawnTags](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#a2bfe7e2452267f51b3ff90ce9ac3aab2) () |
| List< [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) > | [GetAllUsablePointsWithTag](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#ac4b8ace2ad5852a08eb9498580ecb174) (string tag) |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [SpawnWanderingAgent](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#aab0927f46e8d7c057dde4048e745a7f2) ([LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) locationCharacter) |
| void | [SpawnWanderingAgentWithDelay](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#a447e576247faa6b970534da3052d310e) ([LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) locationCharacter, [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) matrixFrame, [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) spawnEntity, bool noHorses=true, bool hasTorch=false, float delay=3f) |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [SpawnWanderingAgentWithInitialFrame](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#a6f0c54a357e07cc931a02e5dc1406cba) ([LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) locationCharacter, [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) spawnPointFrame, [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) spawnEntity, bool noHorses=true, bool hasTorch=false) |
| [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) | [FindUnusedPointWithTagForAgent](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#a0a81cac0ff9325b9f7781cb4d7b42393) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, string tag) |
| List< [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) > | [FindUnusedPoints](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#a7f812141a5cf542e67db69f27c874f48) (string tag) |
| List< [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) > | [FindAllUnusedPoints](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#ab530ead5e51d7d739db3daf9b8a6c49b) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, string primaryTag) |
| void | [TeleportTargetAgentNearReferenceAgent](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#a46829cbe4b97632bc6406a2e2e69dfdf) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) referenceAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) teleportAgent, bool teleportFollowers, bool teleportOpposite) |
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
| virtual void | [OnRegisterBlow](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#afc94274b34e25df5c68187631baa9a4b) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attacker, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victim, [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) realHitEntity, [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) b, ref [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) attackerWeapon) |
| virtual void | [OnAgentShootMissile](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a1bbc0267645d0d331b951ec340f5e01c) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) shooterAgent, [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) weaponIndex, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) velocity, [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html) orientation, bool hasRigidBody, int forcedMissileIndex) |
| virtual void | [OnMissileRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a0353cba934ad1a0fe6e72ca6555f1f7c) (int MissileIndex) |
| virtual void | [OnTutorialCompleted](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a64007b92eb1f373cf2b66dcf901ffe43) (string completedTutorialIdentifier) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static uint | [GetRandomTournamentTeamColor](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#adcf5a05c5e688fc4d94cc3ba8bb68ecc) (int teamIndex) |
| static uint uint color2 | [GetAgentSettlementColors](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#ab102f0bbe93903f96e17c12236ed93f9) ([LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) locationCharacter) |
| static int | [GetPointCountOfUsableMachine](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#a3416c00a7f77fa7c8d399cae2149659f) ([UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) usableMachine, bool checkForUnusedOnes) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static uint | [color1](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#ab37a02b41a7f6e9b5d9edd7a538138f5) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnEndMission](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#ab8f6dd190cd4655a96ef20d9bebe5c84) () |
|  | Called right before the mission ends (i.e. after player clicks done/retreat button in battle results screen for SP missions). Preferably unregister all your Mission dependent events here. Some mission fields (like agent lists) will be deallocated after the mission ends. |

|  |  |
| --- | --- |
| Properties | |
| List< [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) > | [TownPassageProps](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#aea03287993faebe8fb4700cc2065dfa6) `[get]` |
| List< [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) > | [DisabledPassages](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#aebdc75008bddaced8d87ad52cb44bee2) `[get]` |
| List< [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) > | [UsablePoints](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#a915d6ea52e7947224f0a574198db2787) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.MissionLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html) | |
| override [MissionBehaviorType](namespace_tale_worlds_1_1_mount_and_blade.html#a372fbfd8b3eae375d7fd2e0dcbb76993) | [BehaviorType](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html#a22dc913ab511b0a23db3e6a09b76fcd7) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html) | |
| Mission | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aa8057eb8e1718954a667dc0c9a334281) `[get]` |
| [IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html) | [DebugInput](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ac73ea22074a4d9e10f0018fda1a4c67c) `[get]` |
| [MissionBehaviorType](namespace_tale_worlds_1_1_mount_and_blade.html#a372fbfd8b3eae375d7fd2e0dcbb76993) | [BehaviorType](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aca34f7ade7fa89aba9d51c8330684cc5) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#ac43c82811ac2374594b1dca2f40043ad)MissionAgentHandler()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| SandBox.Missions.MissionLogics.MissionAgentHandler.MissionAgentHandler | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#a5688d6f181447c0e9c59f3815feccb03)HasPassages()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool SandBox.Missions.MissionLogics.MissionAgentHandler.HasPassages | ( |  | ) |  |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#af6644120e55736b8185aaeb7366b8132)EarlyStart()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.Missions.MissionLogics.MissionAgentHandler.EarlyStart | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a3bd04d1aa2eb7f76f6c269d9f97e3fbd).

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#a667752161b8e96a31095b8370440d994)OnRenderingStarted()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.Missions.MissionLogics.MissionAgentHandler.OnRenderingStarted | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aef2c8257a1dd922df89563d876bcd6eb).

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#a49484ea8f74536034224f3b483c6a9db)OnMissionTick()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.Missions.MissionLogics.MissionAgentHandler.OnMissionTick | ( | float | *dt* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a006b322c9ef8b55a1897419394c0a1e4).

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#ab8f6dd190cd4655a96ef20d9bebe5c84)OnEndMission()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.Missions.MissionLogics.MissionAgentHandler.OnEndMission | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a2520fc88c264958b60ba7b75a4714117).

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#a0ad57fb88028b0910bdc5862f13c6fa1)OnMissionModeChange()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void SandBox.Missions.MissionLogics.MissionAgentHandler.OnMissionModeChange | ( | [MissionMode](namespace_tale_worlds_1_1_core.html#a34f0ac611df16851fc92e4523aa834e1) | *oldMissionMode*, | |  |  | bool | *atStart* ) | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a11fc0970636713f77872610dd41fdf4f).

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#aec2d7cce4c1b3ebbaeef4089e8593918)OnAgentRemoved()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void SandBox.Missions.MissionLogics.MissionAgentHandler.OnAgentRemoved | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *affectedAgent*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *affectorAgent*, | |  |  | [AgentState](namespace_tale_worlds_1_1_core.html#a799bcc77ddb6372c7383f3340ed4d1c0) | *agentState*, | |  |  | [KillingBlow](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html) | *killingBlow* ) | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ad4987b5b5e719f90cad1856b8c0b7976).

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#a5a327a4a1767946722217eb73ec1acf8)DetectMissingEntities()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.Missions.MissionLogics.MissionAgentHandler.DetectMissingEntities | ( |  | ) |  |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#a6c7ea27398bfc36dbd72787fa5cdcc77)FindUnusedUsablePointCount()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| Dictionary< string, int > SandBox.Missions.MissionLogics.MissionAgentHandler.FindUnusedUsablePointCount | ( |  | ) |  |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#a7a218de9744a75abcbc3be7e6e24943f)SpawnLocationCharacters()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.Missions.MissionLogics.MissionAgentHandler.SpawnLocationCharacters | ( | string | *overridenTagValue* = null | ) |  |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#a92443ed2198313ce7ed4fc1c7de50ff6)SpawnDefaultLocationCharacter()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) SandBox.Missions.MissionLogics.MissionAgentHandler.SpawnDefaultLocationCharacter | ( | [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) | *locationCharacter*, |
|  |  | bool | *simulateAgentAfterSpawn* = false ) |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#ac98ac793a1daa18483e034c4f8284765)SimulateAgent()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.Missions.MissionLogics.MissionAgentHandler.SimulateAgent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#a71b3181300bffbdd1f379651f0920f40)FadeoutExitingLocationCharacter()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.Missions.MissionLogics.MissionAgentHandler.FadeoutExitingLocationCharacter | ( | [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) | *locationCharacter* | ) |  |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#afaae81c76d0043440c6bc9d62881d219)SpawnEnteringLocationCharacter()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.Missions.MissionLogics.MissionAgentHandler.SpawnEnteringLocationCharacter | ( | [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) | *locationCharacter*, |
|  |  | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | *fromLocation* ) |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#afee45f97b1be49917911e7cd8ea8d606)HasUsablePointWithTag()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool SandBox.Missions.MissionLogics.MissionAgentHandler.HasUsablePointWithTag | ( | string | *tag* | ) |  |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#a2bfe7e2452267f51b3ff90ce9ac3aab2)GetAllSpawnTags()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< string > SandBox.Missions.MissionLogics.MissionAgentHandler.GetAllSpawnTags | ( |  | ) |  |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#ac4b8ace2ad5852a08eb9498580ecb174)GetAllUsablePointsWithTag()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| List< [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) > SandBox.Missions.MissionLogics.MissionAgentHandler.GetAllUsablePointsWithTag | ( | string | *tag* | ) |  |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#aab0927f46e8d7c057dde4048e745a7f2)SpawnWanderingAgent()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) SandBox.Missions.MissionLogics.MissionAgentHandler.SpawnWanderingAgent | ( | [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) | *locationCharacter* | ) |  |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#a447e576247faa6b970534da3052d310e)SpawnWanderingAgentWithDelay()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.Missions.MissionLogics.MissionAgentHandler.SpawnWanderingAgentWithDelay | ( | [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) | *locationCharacter*, |
|  |  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *matrixFrame*, |
|  |  | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *spawnEntity*, |
|  |  | bool | *noHorses* = true, |
|  |  | bool | *hasTorch* = false, |
|  |  | float | *delay* = 3f ) |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#a6f0c54a357e07cc931a02e5dc1406cba)SpawnWanderingAgentWithInitialFrame()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) SandBox.Missions.MissionLogics.MissionAgentHandler.SpawnWanderingAgentWithInitialFrame | ( | [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) | *locationCharacter*, |
|  |  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *spawnPointFrame*, |
|  |  | [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *spawnEntity*, |
|  |  | bool | *noHorses* = true, |
|  |  | bool | *hasTorch* = false ) |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#adcf5a05c5e688fc4d94cc3ba8bb68ecc)GetRandomTournamentTeamColor()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | uint SandBox.Missions.MissionLogics.MissionAgentHandler.GetRandomTournamentTeamColor | ( | int | *teamIndex* | ) |  | | static |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#ab102f0bbe93903f96e17c12236ed93f9)GetAgentSettlementColors()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | uint uint color2 SandBox.Missions.MissionLogics.MissionAgentHandler.GetAgentSettlementColors | ( | [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) | *locationCharacter* | ) |  | | static |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#a0a81cac0ff9325b9f7781cb4d7b42393)FindUnusedPointWithTagForAgent()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) SandBox.Missions.MissionLogics.MissionAgentHandler.FindUnusedPointWithTagForAgent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | string | *tag* ) |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#a7f812141a5cf542e67db69f27c874f48)FindUnusedPoints()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| List< [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) > SandBox.Missions.MissionLogics.MissionAgentHandler.FindUnusedPoints | ( | string | *tag* | ) |  |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#ab530ead5e51d7d739db3daf9b8a6c49b)FindAllUnusedPoints()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| List< [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) > SandBox.Missions.MissionLogics.MissionAgentHandler.FindAllUnusedPoints | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | string | *primaryTag* ) |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#a46829cbe4b97632bc6406a2e2e69dfdf)TeleportTargetAgentNearReferenceAgent()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.Missions.MissionLogics.MissionAgentHandler.TeleportTargetAgentNearReferenceAgent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *referenceAgent*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *teleportAgent*, |
|  |  | bool | *teleportFollowers*, |
|  |  | bool | *teleportOpposite* ) |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#a3416c00a7f77fa7c8d399cae2149659f)GetPointCountOfUsableMachine()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int SandBox.Missions.MissionLogics.MissionAgentHandler.GetPointCountOfUsableMachine | ( | [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) | *usableMachine*, | |  |  | bool | *checkForUnusedOnes* ) | | static |

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#ab37a02b41a7f6e9b5d9edd7a538138f5)color1
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint SandBox.Missions.MissionLogics.MissionAgentHandler.color1 | | static |

Property Documentation
----------------------

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#aea03287993faebe8fb4700cc2065dfa6)TownPassageProps
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html)> SandBox.Missions.MissionLogics.MissionAgentHandler.TownPassageProps | | get |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#aebdc75008bddaced8d87ad52cb44bee2)DisabledPassages
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html)> SandBox.Missions.MissionLogics.MissionAgentHandler.DisabledPassages | | get |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_agent_handler.html#a915d6ea52e7947224f0a574198db2787)UsablePoints
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html)> SandBox.Missions.MissionLogics.MissionAgentHandler.UsablePoints | | get |

