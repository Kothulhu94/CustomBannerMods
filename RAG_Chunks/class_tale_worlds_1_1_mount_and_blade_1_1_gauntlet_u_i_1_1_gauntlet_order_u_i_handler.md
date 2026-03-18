--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html ---

TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler Class ReferenceabstractInherits [TaleWorlds.MountAndBlade.View.MissionViews.MissionView](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html).

Inherited by [TaleWorlds.MountAndBlade.GauntletUI.Mission.Singleplayer.MissionGauntletSingleplayerOrderUIHandler](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_mission_1_1_singleplayer_1_1_mission_dab7f785a54299a7a5664ea3cc8a236a.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [GauntletOrderUIHandler](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a1bb968c0daf4cb97f3d8b02dc9dd200b) () |
| virtual void | [SelectFormationAtIndex](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a8ebe28ecf43c826b962bffc1751fba12) (int index) |
| virtual void | [DeselectFormationAtIndex](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#aa27fc33ff5774b5e3cd7410c84c3656c) (int index) |
| override void | [OnMissionScreenActivate](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#ad257a509592e358a15738e3d71c56ba5) () |
| override void | [OnMissionScreenDeactivate](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#ad4aecec1f1fb46997bce8329be4da213) () |
| override void | [OnMissionScreenTick](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a48e910a0ef482c23339d1928986ebb3d) (float dt) |
| override void | [OnAgentBuild](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a2058be971d5b39c8d7b7d5cde786ecf3) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [Banner](class_tale_worlds_1_1_core_1_1_banner.html) banner) |
| override void | [OnAgentRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a42d584bc3ac13ec55194619ce2356261) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectedAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectorAgent, [AgentState](namespace_tale_worlds_1_1_core.html#a799bcc77ddb6372c7383f3340ed4d1c0) agentState, [KillingBlow](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html) killingBlow) |
| override bool | [OnEscape](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#aab51d50303e54681e42922b0e9155e8d) () |
| override bool | [IsReady](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#afeed6cbdb3af0ca0c4cd28131410af38) () |
|  | Represents if view is ready for render Gets asked during initial loading If anyone returns false, loading screen continues. |
| void | [OnActivateToggleOrder](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#ae1a7a9a49f1e56115af96f121196362c) () |
| void | [OnDeactivateToggleOrder](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a072de9a6ea38396ec976ec450635ec0d) () |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.View.MissionViews.MissionView](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html) | |
| virtual bool | [IsOpeningEscapeMenuOnFocusChangeAllowed](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#aa129050f90d3b44ce1869a2751505b4b) () |
|  | Represents if any of the current mission views object to opening escape on focus change. |
| virtual bool | [IsPhotoModeAllowed](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#a8469147fc3bbc46682fb862ab85850d7) () |
| virtual void | [OnFocusChangeOnGameWindow](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#aee96ad01e0ebc9449debbabaa9048ba8) (bool focusGained) |
| virtual void | [OnSceneRenderingStarted](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#a06c0312c31f7cdad8bfba57086bdc135) () |
| virtual void | [OnMissionScreenInitialize](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#af545340c14138b897324e3bc62598282) () |
| virtual void | [OnMissionScreenFinalize](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#a90af64e54fbbb4622003f634b235cfc0) () |
| virtual bool | [UpdateOverridenCamera](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#af717d6a9dcd62c087c29f95c57aaa82c) (float dt) |
| virtual void | [OnPhotoModeActivated](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#a3174eca8bc3c6a5c396ed476ed275d98) () |
| virtual void | [OnPhotoModeDeactivated](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#a1766da1456264ab7fcf77b2356a92aa2) () |
| virtual void | [OnConversationBegin](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#ac0c09b217b4ba818d93cdb097629ed48) () |
| virtual void | [OnConversationEnd](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#a2a4eec315e4642d78b0e9473d5ae42e2) () |
| virtual void | [OnDeploymentPlanMade](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#ae772bcfddc756d0f6bcc9ff231918209) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, bool isFirstPlan) |
| void | [SuspendView](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#adff40a4ab22d4e7ba4323bfe16614ba2) () |
| void | [ResumeView](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#aa0540320e6db8e75041a268a12030977) () |
| override void | [OnEndMissionInternal](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#ad6d2ce27a1e8325ca5fd3ac8430dc623) () |
|  | Do not override this. |
| override void | [OnRemoveBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#a6e7196a119e34585e6e966c7af4eba42) () |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html) | |
| virtual void | [OnAfterMissionCreated](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ad5b64f9606fcf2f88f9d2088d49de3d6) () |
| virtual void | [OnBehaviorInitialize](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a94e4fe46fad26b2a84dbbf3a4a5cc14c) () |
| virtual void | [OnCreated](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a29e57cd652228fc81feee9a78a31121f) () |
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
| void | [OnTransferFinished](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#ac0f5a45fbb75154718699051bebf448c) () |
| void | [SetLayerEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a5d7113fcb07dd9dbf460d7cf6967c070) (bool isEnabled) |
| virtual void | [SetSuspendTroopPlacer](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#ad58163e1a8e7ec79080c28ab08bc6f96) (bool value) |
| virtual [IOrderable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_orderable.html) | [GetFocusedOrderableObject](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a84cb3397eeb652b94c02a3c453411fad) () |
| [VisualOrderExecutionParameters](struct_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order_execution_parameters.html) | [GetVisualOrderExecutionParameters](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a50d6c0f8cb124c59434dde6a07aa51b0) () |
| virtual void | [TickInput](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a9ca78633b1d9895e086c99a2d7a7ca55) (float dt) |
| virtual [OrderItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_item_v_m.html) | [GetChargeOrder](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a5090f856b17bedd6a837c2296a57d93b) () |
| void | [OnBeforeOrder](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a7712b964d4726115e676168b25a35ba0) () |
| void | [TickOrderFlag](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a8a5a09ad1419f65e57ba02c3f038dc59) (float dt, bool forceUpdate) |
| void | [ToggleScreenRotation](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#aae528da11bce9328508b4e47df6fb080) (bool isLocked) |
| override void | [OnSuspendView](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a1f14c175181983a8bb6b3e9b337b6fa9) () |
| override void | [OnResumeView](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a88b018ce95d8af15cbe03300253f62fd) () |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html) | |
| virtual void | [OnEndMission](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a2520fc88c264958b60ba7b75a4714117) () |
|  | Called right before the mission ends (i.e. after player clicks done/retreat button in battle results screen for SP missions). Preferably unregister all your [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) dependent events here. Some mission fields (like agent lists) will be deallocated after the mission ends. |

|  |  |
| --- | --- |
| Protected Attributes | |
| MBReadOnlyList< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > | [\_focusedFormationsCache](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#aadcbf6b4794f7613d514be8eec06fdd6) |
| string | [\_radialOrderMovieName](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#add9942732e25cc5c869e2172d1332f45) = "OrderRadial" |
| string | [\_barOrderMovieName](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a40e6624567f74323da9fc672bbacd9ea) = "OrderBar" |
| float | [\_holdTime](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a9f4fa6da742f465db5b574743126d665) |
| bool | [\_holdHandled](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#afd80b85b83974af177bb0c6fa5440752) |
| [OrderTroopPlacer](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_order_1_1_order_troop_placer.html) | [\_orderTroopPlacer](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a195c2a70775567df2c2f7fb24b1c16c5) |
| [GauntletLayer](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html) | [\_gauntletLayer](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a94030c1d3ee3961b233d29a101bfec2e) |
| [GauntletMovieIdentifier](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_movie_identifier.html) | [\_movie](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a33178fcf8e15919119825fdc8e1d4512) |
| [SpriteCategory](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html) | [\_spriteCategory](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#af26451673940d671dbc80eb0f2fac220) |
| [MissionOrderVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html) | [\_dataSource](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#ae5451ffd20531fda535e17a8a795d7f2) |
| [SiegeDeploymentHandler](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_siege_deployment_handler.html) | [\_siegeDeploymentHandler](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#ad9cfa1a6769f76c425381a060b1a127b) |
| [MissionFormationTargetSelectionHandler](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_formation_target_selection_handler.html) | [\_formationTargetHandler](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a42f71386b88229f7cc0b5ce1bdd3a4e1) |
| bool | [\_isOrderRadialEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a0350993d7b30529231260cdf3cf8515f) |
| bool | [\_isReceivingInput](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#ad4d9f79a595ec97f3fa3db56ffa0d045) |
| bool | [\_isInitialized](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#acda81d8560da2d448496b6c9b4ebac4a) = false |
| bool | [\_slowedDownMission](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a5b01e2347a1298383e1402ca3277df45) = false |
| float | [\_latestDt](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a859a6f18a16442d788d9456e69729f32) |
| bool | [\_targetFormationOrderGivenWithActionButton](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#aa4c05bb12072c084d7964c21140e29b3) |
| bool | [\_isTransferEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a542559a76c1b89cf0fb7846120744c8f) = false |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsDeployment](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a5e38ce506af9855958f1c43d0dcdc74a) `[get]` |
| bool | [IsSiegeDeployment](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a2bd948a85a2b33a4627b26d1ee725692) `[get]` |
| bool | [IsValidForTick](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#ae8eb56f5fe2271350ac7ffe6880d5a7c) `[get]` |
| MissionOrderVM.CursorStates | [CursorState](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a5cca01fc4d6de61bedb0fd1fab9f2a09) `[get]` |
| float | [\_minHoldTimeForActivation](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#afc7eea3a2021fe524eb82562d4138e6d) `[get]` |
| bool | [IsOrderMenuActive](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#aebdfed095d8a34f2677e06cff34445ff) `[get]` |
| bool | [IsAnyOrderSetActive](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a0e5fb04316a8f9d0e43ada2ab28ebc78) `[get]` |
| bool | [IsViewCreated](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a5ca60052a000f9225b36fafb5294e320) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.View.MissionViews.MissionView](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html) | |
| MissionScreen | [MissionScreen](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#acc921743883dcb282259c2ea6630698d) `[get]` |
| [IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html) | [Input](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#a6ba84d0544e9d9cacca9fe601403f4cf) `[get]` |
| bool | [IsViewSuspended](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#acd843b44eb98a8f55b1317455a7c572b) `[get]` |
| override [MissionBehaviorType](namespace_tale_worlds_1_1_mount_and_blade.html#a372fbfd8b3eae375d7fd2e0dcbb76993) | [BehaviorType](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#a104b3b83da4d3d463b2a24d5c64c9ddf) `[get]` |
| bool | [IsFinalized](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#aa23c1bea9228835e37760941802fa5bc) = false `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html) | |
| Mission | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aa8057eb8e1718954a667dc0c9a334281) `[get]` |
| [IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html) | [DebugInput](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ac73ea22074a4d9e10f0018fda1a4c67c) `[get]` |
| [MissionBehaviorType](namespace_tale_worlds_1_1_mount_and_blade.html#a372fbfd8b3eae375d7fd2e0dcbb76993) | [BehaviorType](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aca34f7ade7fa89aba9d51c8330684cc5) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Attributes inherited from [TaleWorlds.MountAndBlade.View.MissionViews.MissionView](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html) | |
| int | [ViewOrderPriority](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#a0b97cdfa0959fe6808f1bdae97796363) = 0 |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a1bb968c0daf4cb97f3d8b02dc9dd200b)GauntletOrderUIHandler()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.GauntletOrderUIHandler | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#ac0f5a45fbb75154718699051bebf448c)OnTransferFinished()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.OnTransferFinished | ( |  | ) |  | | abstractprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a5d7113fcb07dd9dbf460d7cf6967c070)SetLayerEnabled()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.SetLayerEnabled | ( | bool | *isEnabled* | ) |  | | abstractprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#ad58163e1a8e7ec79080c28ab08bc6f96)SetSuspendTroopPlacer()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.SetSuspendTroopPlacer | ( | bool | *value* | ) |  | | protectedvirtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a8ebe28ecf43c826b962bffc1751fba12)SelectFormationAtIndex()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.SelectFormationAtIndex | ( | int | *index* | ) |  | | virtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#aa27fc33ff5774b5e3cd7410c84c3656c)DeselectFormationAtIndex()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.DeselectFormationAtIndex | ( | int | *index* | ) |  | | virtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a84cb3397eeb652b94c02a3c453411fad)GetFocusedOrderableObject()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual [IOrderable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_orderable.html) TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.GetFocusedOrderableObject | ( |  | ) |  | | protectedvirtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a50d6c0f8cb124c59434dde6a07aa51b0)GetVisualOrderExecutionParameters()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [VisualOrderExecutionParameters](struct_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order_execution_parameters.html) TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.GetVisualOrderExecutionParameters | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#ad257a509592e358a15738e3d71c56ba5)OnMissionScreenActivate()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.OnMissionScreenActivate | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.View.MissionViews.MissionView](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#a47d4c3e8d47016f3ce31ea6d48f7582f).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#ad4aecec1f1fb46997bce8329be4da213)OnMissionScreenDeactivate()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.OnMissionScreenDeactivate | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.View.MissionViews.MissionView](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#a898fbeed356e0427990e7fc72cc05806).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a48e910a0ef482c23339d1928986ebb3d)OnMissionScreenTick()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.OnMissionScreenTick | ( | float | *dt* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.View.MissionViews.MissionView](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#a0ce85fa8194e51ea10af1cdd31077d24).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a9ca78633b1d9895e086c99a2d7a7ca55)TickInput()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.TickInput | ( | float | *dt* | ) |  | | protectedvirtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a5090f856b17bedd6a837c2296a57d93b)GetChargeOrder()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual [OrderItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_item_v_m.html) TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.GetChargeOrder | ( |  | ) |  | | protectedvirtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a2058be971d5b39c8d7b7d5cde786ecf3)OnAgentBuild()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.OnAgentBuild | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | [Banner](class_tale_worlds_1_1_core_1_1_banner.html) | *banner* ) | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ad610eac3ce9064919cb8771652a5da4e).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a42d584bc3ac13ec55194619ce2356261)OnAgentRemoved()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.OnAgentRemoved | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *affectedAgent*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *affectorAgent*, | |  |  | [AgentState](namespace_tale_worlds_1_1_core.html#a799bcc77ddb6372c7383f3340ed4d1c0) | *agentState*, | |  |  | [KillingBlow](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html) | *killingBlow* ) | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ad4987b5b5e719f90cad1856b8c0b7976).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#aab51d50303e54681e42922b0e9155e8d)OnEscape()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override bool TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.OnEscape | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.View.MissionViews.MissionView](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#a13dd6aaa04323af946c7207c3f7426da).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#afeed6cbdb3af0ca0c4cd28131410af38)IsReady()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override bool TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.IsReady | ( |  | ) |  | | virtual |

Returns

Reimplemented from [TaleWorlds.MountAndBlade.View.MissionViews.MissionView](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#a4a87a06ac852399c6d5efbe35f9e4b15).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#ae1a7a9a49f1e56115af96f121196362c)OnActivateToggleOrder()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.OnActivateToggleOrder | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a072de9a6ea38396ec976ec450635ec0d)OnDeactivateToggleOrder()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.OnDeactivateToggleOrder | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a7712b964d4726115e676168b25a35ba0)OnBeforeOrder()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.OnBeforeOrder | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a8a5a09ad1419f65e57ba02c3f038dc59)TickOrderFlag()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.TickOrderFlag | ( | float | *dt*, | |  |  | bool | *forceUpdate* ) | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#aae528da11bce9328508b4e47df6fb080)ToggleScreenRotation()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.ToggleScreenRotation | ( | bool | *isLocked* | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a1f14c175181983a8bb6b3e9b337b6fa9)OnSuspendView()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.OnSuspendView | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.View.MissionViews.MissionView](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#a4365e8616935a1e78c574ba3ba156393).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a88b018ce95d8af15cbe03300253f62fd)OnResumeView()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.OnResumeView | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.View.MissionViews.MissionView](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#ab609548f5e9727e54078441187cec3a4).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#aadcbf6b4794f7613d514be8eec06fdd6)\_focusedFormationsCache
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html)> TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.\_focusedFormationsCache | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#add9942732e25cc5c869e2172d1332f45)\_radialOrderMovieName
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.\_radialOrderMovieName = "OrderRadial" | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a40e6624567f74323da9fc672bbacd9ea)\_barOrderMovieName
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.\_barOrderMovieName = "OrderBar" | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a9f4fa6da742f465db5b574743126d665)\_holdTime
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.\_holdTime | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#afd80b85b83974af177bb0c6fa5440752)\_holdHandled
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.\_holdHandled | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a195c2a70775567df2c2f7fb24b1c16c5)\_orderTroopPlacer
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [OrderTroopPlacer](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_order_1_1_order_troop_placer.html) TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.\_orderTroopPlacer | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a94030c1d3ee3961b233d29a101bfec2e)\_gauntletLayer
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GauntletLayer](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html) TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.\_gauntletLayer | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a33178fcf8e15919119825fdc8e1d4512)\_movie
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GauntletMovieIdentifier](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_movie_identifier.html) TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.\_movie | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#af26451673940d671dbc80eb0f2fac220)\_spriteCategory
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SpriteCategory](class_tale_worlds_1_1_two_dimension_1_1_sprite_category.html) TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.\_spriteCategory | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#ae5451ffd20531fda535e17a8a795d7f2)\_dataSource
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MissionOrderVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html) TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.\_dataSource | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#ad9cfa1a6769f76c425381a060b1a127b)\_siegeDeploymentHandler
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SiegeDeploymentHandler](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_handlers_1_1_siege_deployment_handler.html) TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.\_siegeDeploymentHandler | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a42f71386b88229f7cc0b5ce1bdd3a4e1)\_formationTargetHandler
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MissionFormationTargetSelectionHandler](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_formation_target_selection_handler.html) TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.\_formationTargetHandler | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a0350993d7b30529231260cdf3cf8515f)\_isOrderRadialEnabled
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.\_isOrderRadialEnabled | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#ad4d9f79a595ec97f3fa3db56ffa0d045)\_isReceivingInput
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.\_isReceivingInput | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#acda81d8560da2d448496b6c9b4ebac4a)\_isInitialized
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.\_isInitialized = false | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a5b01e2347a1298383e1402ca3277df45)\_slowedDownMission
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.\_slowedDownMission = false | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a859a6f18a16442d788d9456e69729f32)\_latestDt
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.\_latestDt | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#aa4c05bb12072c084d7964c21140e29b3)\_targetFormationOrderGivenWithActionButton
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.\_targetFormationOrderGivenWithActionButton | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a542559a76c1b89cf0fb7846120744c8f)\_isTransferEnabled
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.\_isTransferEnabled = false | | protected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a5e38ce506af9855958f1c43d0dcdc74a)IsDeployment
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.IsDeployment | | getabstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a2bd948a85a2b33a4627b26d1ee725692)IsSiegeDeployment
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.IsSiegeDeployment | | getabstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#ae8eb56f5fe2271350ac7ffe6880d5a7c)IsValidForTick
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.IsValidForTick | | getabstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a5cca01fc4d6de61bedb0fd1fab9f2a09)CursorState
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MissionOrderVM.CursorStates TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.CursorState | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#afc7eea3a2021fe524eb82562d4138e6d)\_minHoldTimeForActivation
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.\_minHoldTimeForActivation | | getprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#aebdfed095d8a34f2677e06cff34445ff)IsOrderMenuActive
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.IsOrderMenuActive | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a0e5fb04316a8f9d0e43ada2ab28ebc78)IsAnyOrderSetActive
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.IsAnyOrderSetActive | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_order_u_i_handler.html#a5ca60052a000f9225b36fafb5294e320)IsViewCreated
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.GauntletUI.GauntletOrderUIHandler.IsViewCreated | | get |

