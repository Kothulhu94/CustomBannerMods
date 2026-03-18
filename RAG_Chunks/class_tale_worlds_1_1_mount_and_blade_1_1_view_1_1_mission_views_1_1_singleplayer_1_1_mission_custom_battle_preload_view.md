--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_singleplayer_1_1_mission_custom_battle_preload_view.html ---

TaleWorlds.MountAndBlade.View.MissionViews.Singleplayer.MissionCustomBattlePreloadView Class ReferenceInherits [TaleWorlds.MountAndBlade.View.MissionViews.MissionView](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [OnPreMissionTick](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_singleplayer_1_1_mission_custom_battle_preload_view.html#a88dc9fba0e0d90d8c74e14950cef0ce4) (float dt) |
| override void | [OnSceneRenderingStarted](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_singleplayer_1_1_mission_custom_battle_preload_view.html#a54a7ac2409ee9b1108a6abe1e6f10eb4) () |
| override void | [OnMissionStateDeactivated](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_singleplayer_1_1_mission_custom_battle_preload_view.html#aca2dbb18ca0ab3cd1831d45fdf1b9fa6) () |
|  | Called either before mission is finalized or the mission state is deactivated due to another state (like inventory) being pushed into GameStates stack. |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.View.MissionViews.MissionView](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html) | |
| virtual void | [OnMissionScreenTick](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#a0ce85fa8194e51ea10af1cdd31077d24) (float dt) |
| virtual bool | [OnEscape](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#a13dd6aaa04323af946c7207c3f7426da) () |
| virtual bool | [IsOpeningEscapeMenuOnFocusChangeAllowed](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#aa129050f90d3b44ce1869a2751505b4b) () |
|  | Represents if any of the current mission views object to opening escape on focus change. |
| virtual bool | [IsPhotoModeAllowed](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#a8469147fc3bbc46682fb862ab85850d7) () |
| virtual void | [OnFocusChangeOnGameWindow](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#aee96ad01e0ebc9449debbabaa9048ba8) (bool focusGained) |
| virtual void | [OnMissionScreenInitialize](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#af545340c14138b897324e3bc62598282) () |
| virtual void | [OnMissionScreenFinalize](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#a90af64e54fbbb4622003f634b235cfc0) () |
| virtual void | [OnMissionScreenActivate](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#a47d4c3e8d47016f3ce31ea6d48f7582f) () |
| virtual void | [OnMissionScreenDeactivate](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#a898fbeed356e0427990e7fc72cc05806) () |
| virtual bool | [UpdateOverridenCamera](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#af717d6a9dcd62c087c29f95c57aaa82c) (float dt) |
| virtual bool | [IsReady](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#a4a87a06ac852399c6d5efbe35f9e4b15) () |
|  | Represents if view is ready for render Gets asked during initial loading If anyone returns false, loading screen continues. |
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
| virtual void | [OnFixedMissionTick](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aee013ab26ac67f4043a1b839112572a3) (float fixedDt) |
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
| Public Attributes inherited from [TaleWorlds.MountAndBlade.View.MissionViews.MissionView](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html) | |
| int | [ViewOrderPriority](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#a0b97cdfa0959fe6808f1bdae97796363) = 0 |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.View.MissionViews.MissionView](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html) | |
| virtual void | [OnSuspendView](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#a4365e8616935a1e78c574ba3ba156393) () |
| virtual void | [OnResumeView](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#ab609548f5e9727e54078441187cec3a4) () |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html) | |
| virtual void | [OnEndMission](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a2520fc88c264958b60ba7b75a4714117) () |
|  | Called right before the mission ends (i.e. after player clicks done/retreat button in battle results screen for SP missions). Preferably unregister all your [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) dependent events here. Some mission fields (like agent lists) will be deallocated after the mission ends. |
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

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_singleplayer_1_1_mission_custom_battle_preload_view.html#a88dc9fba0e0d90d8c74e14950cef0ce4)OnPreMissionTick()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.MissionViews.Singleplayer.MissionCustomBattlePreloadView.OnPreMissionTick | ( | float | *dt* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ac5f9da64f58e30eb4ef62a39596e1af7).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_singleplayer_1_1_mission_custom_battle_preload_view.html#a54a7ac2409ee9b1108a6abe1e6f10eb4)OnSceneRenderingStarted()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.MissionViews.Singleplayer.MissionCustomBattlePreloadView.OnSceneRenderingStarted | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.View.MissionViews.MissionView](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_view.html#a06c0312c31f7cdad8bfba57086bdc135).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_singleplayer_1_1_mission_custom_battle_preload_view.html#aca2dbb18ca0ab3cd1831d45fdf1b9fa6)OnMissionStateDeactivated()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.MissionViews.Singleplayer.MissionCustomBattlePreloadView.OnMissionStateDeactivated | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a6c56791473ed920b83b0e13c201ed810).

