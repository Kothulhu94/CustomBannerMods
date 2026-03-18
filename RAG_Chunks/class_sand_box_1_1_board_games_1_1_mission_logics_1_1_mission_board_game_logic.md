--- SOURCE: class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html ---

SandBox.BoardGames.MissionLogics.MissionBoardGameLogic Class ReferenceInherits [TaleWorlds.MountAndBlade.MissionLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [AfterStart](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#a43a0e8b0ff58b641aac24a0c810b9ca5) () |
| void | [SetStartingPlayer](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#a125848de7215bbf2b32280f45d5a61a5) (bool playerOneStarts) |
| void | [StartBoardGame](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#acc86f26c9faaf26abc55c7df58fb1614) () |
| override void | [OnMissionTick](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#a8e14f27c84cab24ad2f86bb6dde7bc0f) (float dt) |
| void | [DetectOpposingAgent](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#a0a49eb102918cdfb52282d135b8defdc) () |
| bool | [CheckIfBothSidesAreSitting](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#a25c7a2202a08f6a0ffa16c226b658c53) () |
| void | [PlayerOneWon](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#af137b45e7dc0323e2acb1e20cbed1fe1) (string message=[BoardGameBase.StringVictoryMessage](class_sand_box_1_1_board_games_1_1_board_game_base.html#a3c01aa424fd9a08275bb029cbd9fab13)) |
| void | [PlayerTwoWon](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#a498fe2bd0ab75c6a30f8d4f31659b3d3) (string message=[BoardGameBase.StringDefeatMessage](class_sand_box_1_1_board_games_1_1_board_game_base.html#a2d4a228536e2e601347d186288c1faf6)) |
| void | [GameWasDraw](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#a1b14cb041e68483116d026caddf7e39b) (string message=[BoardGameBase.StringDrawMessage](class_sand_box_1_1_board_games_1_1_board_game_base.html#a9ce0a4c6d32b55451e3c563ce2c0fe3a)) |
| void | [SetGameOver](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#ae3a14118e118da3a6576d6b8af9ac801) ([GameOverEnum](namespace_sand_box_1_1_board_games.html#ae41e8e73c4b3a94cf72401595a8cf6d6) gameOverInfo) |
| void | [ForfeitGame](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#a550beccd9705a1f28f4b836eefa81c35) () |
| void | [AIForfeitGame](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#a4b6891bce66faf16291dde5e088946bf) () |
| void | [RollDice](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#aac1423c113b51199a8d12f732da6d47d) () |
| bool | [RequiresDiceRolling](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#a83a66c0395fc8e5dd8178d7817fd51cd) () |
| void | [SetBetAmount](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#a36d2ff594885eabd8c9441e4efd3f84c) (int bet) |
| void | [SetCurrentDifficulty](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#a400fd9e68321e103ce01a74f3932749f) ([BoardGameHelper.AIDifficulty](class_helpers_1_1_board_game_helper.html#a4eae119f51c59e72692b19fd9f1cc9c8) difficulty) |
| void | [SetBoardGame](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#a6dcf754d4612cd8b673dadd693317d9a) ([CultureObject.BoardGameType](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a93a804fc17a3f89e1528215f9828e69a) game) |
| override [InquiryData](class_tale_worlds_1_1_library_1_1_inquiry_data.html) | [OnEndMissionRequest](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#a5f007d8336e08984e8e28e72d23cdf63) (out bool canLeave) |
| override void | [OnAgentInteraction](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#afbec4e46aa16d3a44677b9b439819592) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) userAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, sbyte agentBoneIndex) |
| override bool | [IsThereAgentAction](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#ad88e3e71051c89fc572a5a7fe753d4f4) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) userAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) otherAgent) |
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
| virtual void | [OnClearScene](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a0f6f2ae3c6e394ee12a8d394516af918) () |
| virtual void | [OnEndMissionInternal](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a49e74ba30248db4bac7d78be3039ded9) () |
|  | Do not override this. |
| virtual void | [OnRemoveBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a80cb93b393ebaa09e4fd5fbab467556f) () |
| virtual void | [OnFixedMissionTick](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aee013ab26ac67f4043a1b839112572a3) (float fixedDt) |
| virtual void | [OnPreMissionTick](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ac5f9da64f58e30eb4ef62a39596e1af7) (float dt) |
| virtual void | [OnPreDisplayMissionTick](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aca165ecaaa9e2c3e2c96219353678a3c) (float dt) |
| virtual void | [OnAgentMount](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#acd50c486f7723094db2816a6628b43fd) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| virtual void | [OnAgentDismount](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a0b9976fba83dd53e5936601bf4ee976b) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
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
| Static Public Member Functions | |
| static bool | [IsBoardGameAvailable](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#abbe441231fcf086e18ee71d22479e909) () |
| static bool | [IsThereActiveBoardGameWithHero](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#a14ea5763e563907f3063e754215aea41) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |

|  |  |
| --- | --- |
| Public Attributes | |
| [IBoardGameHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_source_1_1_missions_1_1_handlers_1_1_i_board_game_handler.html) | [Handler](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#a78736a11a4947e59b138a1f1d719b7b9) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnEndMission](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#ae416968d88e755e5aec44fa7f1afae73) () |
|  | Called right before the mission ends (i.e. after player clicks done/retreat button in battle results screen for SP missions). Preferably unregister all your Mission dependent events here. Some mission fields (like agent lists) will be deallocated after the mission ends. |

|  |  |
| --- | --- |
| Properties | |
| [BoardGameBase](class_sand_box_1_1_board_games_1_1_board_game_base.html) | [Board](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#a790053f4af8fbb8965db71da8b089776) `[get]` |
| [BoardGameAIBase](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html) | [AIOpponent](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#aef41b98ef821662d1c354121d784758d) `[get]` |
| bool | [IsOpposingAgentMovingToPlayingChair](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#a5523b96fa5b2ae154ee6fcd916de1a9f) `[get]` |
| bool | [IsGameInProgress](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#ae1ad7c7193967f9af982703e367a76b8) `[get]` |
| [BoardGameHelper.BoardGameState](class_helpers_1_1_board_game_helper.html#ab045b68fb522a41152b0557241b92db2) | [BoardGameFinalState](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#aef803ac1c97e079cfe75749755f50dc3) `[get]` |
| [CultureObject.BoardGameType](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a93a804fc17a3f89e1528215f9828e69a) | [CurrentBoardGame](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#ac9183e64b645c29dcc69f7eb6bbc6f85) `[get]` |
| [BoardGameHelper.AIDifficulty](class_helpers_1_1_board_game_helper.html#a4eae119f51c59e72692b19fd9f1cc9c8) | [Difficulty](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#ab9ef1c143edfd89cccc6d97c0fe65ec1) `[get]` |
| int | [BetAmount](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#ace787969e8354e1c23f61942c114821f) `[get]` |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [OpposingAgent](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#ae0f04017601c19a77114bf67f5494c0d) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.MissionLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html) | |
| override [MissionBehaviorType](namespace_tale_worlds_1_1_mount_and_blade.html#a372fbfd8b3eae375d7fd2e0dcbb76993) | [BehaviorType](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html#a22dc913ab511b0a23db3e6a09b76fcd7) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html) | |
| Mission | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aa8057eb8e1718954a667dc0c9a334281) `[get]` |
| [IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html) | [DebugInput](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ac73ea22074a4d9e10f0018fda1a4c67c) `[get]` |
| [MissionBehaviorType](namespace_tale_worlds_1_1_mount_and_blade.html#a372fbfd8b3eae375d7fd2e0dcbb76993) | [BehaviorType](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aca34f7ade7fa89aba9d51c8330684cc5) `[get]` |

|  |  |
| --- | --- |
| Events | |
| Action | [GameStarted](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#af00e62bf78fc7b6dc352788e137d406d) |
| Action | [GameEnded](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#ac8d307d347c8953ab163e8204ac65a26) |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#a43a0e8b0ff58b641aac24a0c810b9ca5)AfterStart()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.BoardGames.MissionLogics.MissionBoardGameLogic.AfterStart | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a693295e26d8b0fcf634c52b1c08fd974).

[◆](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#a125848de7215bbf2b32280f45d5a61a5)SetStartingPlayer()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.BoardGames.MissionLogics.MissionBoardGameLogic.SetStartingPlayer | ( | bool | *playerOneStarts* | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#acc86f26c9faaf26abc55c7df58fb1614)StartBoardGame()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.BoardGames.MissionLogics.MissionBoardGameLogic.StartBoardGame | ( |  | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#a8e14f27c84cab24ad2f86bb6dde7bc0f)OnMissionTick()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.BoardGames.MissionLogics.MissionBoardGameLogic.OnMissionTick | ( | float | *dt* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a006b322c9ef8b55a1897419394c0a1e4).

[◆](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#a0a49eb102918cdfb52282d135b8defdc)DetectOpposingAgent()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.BoardGames.MissionLogics.MissionBoardGameLogic.DetectOpposingAgent | ( |  | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#a25c7a2202a08f6a0ffa16c226b658c53)CheckIfBothSidesAreSitting()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool SandBox.BoardGames.MissionLogics.MissionBoardGameLogic.CheckIfBothSidesAreSitting | ( |  | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#af137b45e7dc0323e2acb1e20cbed1fe1)PlayerOneWon()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.BoardGames.MissionLogics.MissionBoardGameLogic.PlayerOneWon | ( | string | *message* = [BoardGameBase::StringVictoryMessage](class_sand_box_1_1_board_games_1_1_board_game_base.html#a3c01aa424fd9a08275bb029cbd9fab13) | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#a498fe2bd0ab75c6a30f8d4f31659b3d3)PlayerTwoWon()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.BoardGames.MissionLogics.MissionBoardGameLogic.PlayerTwoWon | ( | string | *message* = [BoardGameBase::StringDefeatMessage](class_sand_box_1_1_board_games_1_1_board_game_base.html#a2d4a228536e2e601347d186288c1faf6) | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#a1b14cb041e68483116d026caddf7e39b)GameWasDraw()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.BoardGames.MissionLogics.MissionBoardGameLogic.GameWasDraw | ( | string | *message* = [BoardGameBase::StringDrawMessage](class_sand_box_1_1_board_games_1_1_board_game_base.html#a9ce0a4c6d32b55451e3c563ce2c0fe3a) | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#ae3a14118e118da3a6576d6b8af9ac801)SetGameOver()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.BoardGames.MissionLogics.MissionBoardGameLogic.SetGameOver | ( | [GameOverEnum](namespace_sand_box_1_1_board_games.html#ae41e8e73c4b3a94cf72401595a8cf6d6) | *gameOverInfo* | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#a550beccd9705a1f28f4b836eefa81c35)ForfeitGame()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.BoardGames.MissionLogics.MissionBoardGameLogic.ForfeitGame | ( |  | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#a4b6891bce66faf16291dde5e088946bf)AIForfeitGame()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.BoardGames.MissionLogics.MissionBoardGameLogic.AIForfeitGame | ( |  | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#aac1423c113b51199a8d12f732da6d47d)RollDice()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.BoardGames.MissionLogics.MissionBoardGameLogic.RollDice | ( |  | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#a83a66c0395fc8e5dd8178d7817fd51cd)RequiresDiceRolling()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool SandBox.BoardGames.MissionLogics.MissionBoardGameLogic.RequiresDiceRolling | ( |  | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#a36d2ff594885eabd8c9441e4efd3f84c)SetBetAmount()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.BoardGames.MissionLogics.MissionBoardGameLogic.SetBetAmount | ( | int | *bet* | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#a400fd9e68321e103ce01a74f3932749f)SetCurrentDifficulty()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.BoardGames.MissionLogics.MissionBoardGameLogic.SetCurrentDifficulty | ( | [BoardGameHelper.AIDifficulty](class_helpers_1_1_board_game_helper.html#a4eae119f51c59e72692b19fd9f1cc9c8) | *difficulty* | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#a6dcf754d4612cd8b673dadd693317d9a)SetBoardGame()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.BoardGames.MissionLogics.MissionBoardGameLogic.SetBoardGame | ( | [CultureObject.BoardGameType](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a93a804fc17a3f89e1528215f9828e69a) | *game* | ) |  |

[◆](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#ae416968d88e755e5aec44fa7f1afae73)OnEndMission()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.BoardGames.MissionLogics.MissionBoardGameLogic.OnEndMission | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a2520fc88c264958b60ba7b75a4714117).

[◆](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#a5f007d8336e08984e8e28e72d23cdf63)OnEndMissionRequest()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override [InquiryData](class_tale_worlds_1_1_library_1_1_inquiry_data.html) SandBox.BoardGames.MissionLogics.MissionBoardGameLogic.OnEndMissionRequest | ( | out bool | *canLeave* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html#a9373241b87874466fbb93f73f44acc83).

[◆](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#abbe441231fcf086e18ee71d22479e909)IsBoardGameAvailable()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool SandBox.BoardGames.MissionLogics.MissionBoardGameLogic.IsBoardGameAvailable | ( |  | ) |  | | static |

[◆](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#a14ea5763e563907f3063e754215aea41)IsThereActiveBoardGameWithHero()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool SandBox.BoardGames.MissionLogics.MissionBoardGameLogic.IsThereActiveBoardGameWithHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | static |

[◆](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#afbec4e46aa16d3a44677b9b439819592)OnAgentInteraction()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void SandBox.BoardGames.MissionLogics.MissionBoardGameLogic.OnAgentInteraction | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *userAgent*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | sbyte | *agentBoneIndex* ) | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a813d13ba2cdf3ad40dd5ab055e6c5bf2).

[◆](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#ad88e3e71051c89fc572a5a7fe753d4f4)IsThereAgentAction()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override bool SandBox.BoardGames.MissionLogics.MissionBoardGameLogic.IsThereAgentAction | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *userAgent*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *otherAgent* ) | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a7624ad654b98307d9787ea0306201eee).

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#a78736a11a4947e59b138a1f1d719b7b9)Handler
---------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [IBoardGameHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_source_1_1_missions_1_1_handlers_1_1_i_board_game_handler.html) SandBox.BoardGames.MissionLogics.MissionBoardGameLogic.Handler |

Property Documentation
----------------------

[◆](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#a790053f4af8fbb8965db71da8b089776)Board
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BoardGameBase](class_sand_box_1_1_board_games_1_1_board_game_base.html) SandBox.BoardGames.MissionLogics.MissionBoardGameLogic.Board | | get |

[◆](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#aef41b98ef821662d1c354121d784758d)AIOpponent
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BoardGameAIBase](class_sand_box_1_1_board_games_1_1_a_i_1_1_board_game_a_i_base.html) SandBox.BoardGames.MissionLogics.MissionBoardGameLogic.AIOpponent | | get |

[◆](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#a5523b96fa5b2ae154ee6fcd916de1a9f)IsOpposingAgentMovingToPlayingChair
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.BoardGames.MissionLogics.MissionBoardGameLogic.IsOpposingAgentMovingToPlayingChair | | get |

[◆](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#ae1ad7c7193967f9af982703e367a76b8)IsGameInProgress
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.BoardGames.MissionLogics.MissionBoardGameLogic.IsGameInProgress | | get |

[◆](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#aef803ac1c97e079cfe75749755f50dc3)BoardGameFinalState
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BoardGameHelper.BoardGameState](class_helpers_1_1_board_game_helper.html#ab045b68fb522a41152b0557241b92db2) SandBox.BoardGames.MissionLogics.MissionBoardGameLogic.BoardGameFinalState | | get |

[◆](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#ac9183e64b645c29dcc69f7eb6bbc6f85)CurrentBoardGame
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CultureObject.BoardGameType](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a93a804fc17a3f89e1528215f9828e69a) SandBox.BoardGames.MissionLogics.MissionBoardGameLogic.CurrentBoardGame | | get |

[◆](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#ab9ef1c143edfd89cccc6d97c0fe65ec1)Difficulty
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BoardGameHelper.AIDifficulty](class_helpers_1_1_board_game_helper.html#a4eae119f51c59e72692b19fd9f1cc9c8) SandBox.BoardGames.MissionLogics.MissionBoardGameLogic.Difficulty | | get |

[◆](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#ace787969e8354e1c23f61942c114821f)BetAmount
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.BoardGames.MissionLogics.MissionBoardGameLogic.BetAmount | | get |

[◆](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#ae0f04017601c19a77114bf67f5494c0d)OpposingAgent
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) SandBox.BoardGames.MissionLogics.MissionBoardGameLogic.OpposingAgent | | get |

Event Documentation
-------------------

[◆](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#af00e62bf78fc7b6dc352788e137d406d)GameStarted
-------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action SandBox.BoardGames.MissionLogics.MissionBoardGameLogic.GameStarted |

[◆](class_sand_box_1_1_board_games_1_1_mission_logics_1_1_mission_board_game_logic.html#ac8d307d347c8953ab163e8204ac65a26)GameEnded
-----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action SandBox.BoardGames.MissionLogics.MissionBoardGameLogic.GameEnded |

