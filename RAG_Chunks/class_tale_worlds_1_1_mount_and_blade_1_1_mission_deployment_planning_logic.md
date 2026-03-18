--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html ---

TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic Class ReferenceabstractInherits [TaleWorlds.MountAndBlade.MissionLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html), and [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| virtual void | [Initialize](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a3fc667cf74b13cdf3ad40cee118a71c8) () |
|  | Initializes deployment plans from mission. Required mission data must be set. |
| virtual void | [ClearAll](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#acd24eb707d299dc337d4521069a23fa0) () |
|  | Clears both the current deployment plan and any troops added to the plan. |
| virtual void | [MakeDefaultDeploymentPlans](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a325bee40fe020d897cb000b8b4dfacda) () |
|  | Makes default deployment plans for missions where detailed planning is not needed (i.e. alley fights, quests etc). |
| virtual void | [MakeDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a5a4d7120099dbb02b402b0e7946a7b82) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, float spawnPathOffset=0, float targetPathOffset=0f) |
|  | Plans battle deployment for the given team. |
| virtual bool | [RemakeDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a8585ee329435de403da3ca78196f4b7c) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
|  | Re-Plans battle deployment for the given team. An existing plan must be prepared. Returns true if plan is re-made, false otherwise. |
| virtual void | [ClearDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a2037eaa729778e47e67d1e3e1a4ab0c2) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
|  | Clears the deployment plan for the given team. |
| virtual bool | [IsPlanMade](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a4553e03c5c6da0f3266b3fa62825a1b9) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
|  | Returns whether if a deployment plan is made for the given team. |
| virtual bool | [IsPlanMade](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a06dab921bebe3222d50fd8c054b6ad1a) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, out bool isFirstPlan) |
|  | Returns whether if a deployment plan is made for the given team. Also outputs if the plan was the first plan that is made. |
| virtual bool | [IsPositionInsideDeploymentBoundaries](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a37452100dc51dcd368d639d07aa39a9b) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position) |
|  | Returns true if the given position is within the deployment boundaries of the given team. [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) should have its deployment made and its boundaries computed. Or the method returns false. |
| virtual bool | [HasDeploymentBoundaries](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a074841800faf3151a9f5b38d5276b631) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
|  | Returns true if the given team has its initial deployment boundaries computed. |
| virtual MBReadOnlyList<(string id, MBList< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > points)> | [GetDeploymentBoundaries](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a8ce19818130ac06d871dbc11cfa05e71) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
|  | Returns a list describing the deployment boundaries of the given team Each deployment boundary has a string id describing the boundary and its associated points vector. |
| virtual bool | [SupportsReinforcements](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#aeb0f262a0329d237c4b965e37562dc9f) () |
|  | Returns true if the deployment plan supports reinforcements. |
| virtual bool | [SupportsNavmesh](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#aa95136a5d576efa3e6a5a7aeab43127d) () |
|  | Returns true if deployment plan supports navmesh. Plans made for agent formations on land battles support this. But plans made for ships during naval battles does not as open sea battles does not have a navmesh (except certain river battles) Interface calls that make use of WorldPositions (like complex boundary intersections and position projections) will be unavailable if the plan does not support navmeshes. |
| virtual bool | [HasPlayerSpawnFrame](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a6e6df0c4db444cf4c7b1b8b62a28fd5f) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) battleSide) |
|  | Returns true if the given battle side has a pre-specified player spawn frame. |
| virtual bool | [GetPlayerSpawnFrame](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a732ed706aeaef91bd19bc60b0c82f807) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) battleSide, out [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) position, out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) direction) |
|  | Returns the pre-specified spawn frame for the player if the associated battle side has one defined. |
| virtual [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetClosestDeploymentBoundaryPosition](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#ab0197b5f8f58b829df55e4f793179d04) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position) |
|  | Returns the closest point on the deployment boundary of a team to the given position. |
| virtual void | [ProjectPositionToDeploymentBoundaries](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a46e6a2f39ec213104b60590438f51a93) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, ref [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) position) |
|  | Projects the given position onto the deployment boundary Alters the position to deployment boundary intersection if the position is not already within the boundaries Deployment plan must support navmeshes for this call to work. Caller must check this. |
| virtual bool | [GetPathDeploymentBoundaryIntersection](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#ab71fbee1853651209f8c14366715534a) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, in [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) startPosition, in [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) endPosition, out [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) foundPosition) |
|  | Searches the intersection of the navmesh path (from start position to end position) with the deployment boundaries of the specified team Deployment plan must support navmeshes for this call to work. Caller must check this. |
| virtual [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetDeploymentFrame](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#aa37d268c8721ce51cdaf4e5e43bcbade) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
|  | Returns deployment frame of the given team. |
| virtual [IFormationDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_deployment_plan.html) | [GetFormationPlan](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#acb79bfa9cfc4483662472ae0dc76fbe8) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) fClass, bool isReinforcement=false) |
|  | Returns the formation plan matching the given formation class and which belongs to the given team. |
| virtual float | [GetSpawnPathOffset](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#ae335a2ec9ad3fca37b2671d3f1cb95c2) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
|  | Returns spawn path offset for the given team and plan type. This is only valid for plans which do use a spawn path. |
| virtual [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetZoomFocusFrame](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a30280473bbf9ea9c1c150ed7a177d48f) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
|  | Returns zoom focus frame for the camera depending on where the deployment frames are located for formations. |
| virtual float | [GetZoomOffset](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a31eca9deaabe34b67d36dcc8458a827b) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, float fovAngle) |
|  | Returns zoom offset for the camera depending on how large the deployment area or unit count is. |
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
| virtual void | [OnEndMissionInternal](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a49e74ba30248db4bac7d78be3039ded9) () |
|  | Do not override this. |
| virtual void | [OnRemoveBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a80cb93b393ebaa09e4fd5fbab467556f) () |
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
| Additional Inherited Members | |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html) | |
| virtual void | [OnEndMission](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a2520fc88c264958b60ba7b75a4714117) () |
|  | Called right before the mission ends (i.e. after player clicks done/retreat button in battle results screen for SP missions). Preferably unregister all your [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) dependent events here. Some mission fields (like agent lists) will be deallocated after the mission ends. |
| Properties inherited from [TaleWorlds.MountAndBlade.MissionLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html) | |
| override [MissionBehaviorType](namespace_tale_worlds_1_1_mount_and_blade.html#a372fbfd8b3eae375d7fd2e0dcbb76993) | [BehaviorType](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html#a22dc913ab511b0a23db3e6a09b76fcd7) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html) | |
| Mission | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aa8057eb8e1718954a667dc0c9a334281) `[get]` |
| [IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html) | [DebugInput](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ac73ea22074a4d9e10f0018fda1a4c67c) `[get]` |
| [MissionBehaviorType](namespace_tale_worlds_1_1_mount_and_blade.html#a372fbfd8b3eae375d7fd2e0dcbb76993) | [BehaviorType](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aca34f7ade7fa89aba9d51c8330684cc5) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a3fc667cf74b13cdf3ad40cee118a71c8)Initialize()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic.Initialize | ( |  | ) |  | | virtual |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a1451afadddd81f21c6b1f6b50b5ad128).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#acd24eb707d299dc337d4521069a23fa0)ClearAll()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic.ClearAll | ( |  | ) |  | | virtual |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#ae663b14a405c95ee0ece79d408bf189a).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a325bee40fe020d897cb000b8b4dfacda)MakeDefaultDeploymentPlans()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic.MakeDefaultDeploymentPlans | ( |  | ) |  | | virtual |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a7762a7fffa885519a4189beffd254775).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a5a4d7120099dbb02b402b0e7946a7b82)MakeDeploymentPlan()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic.MakeDeploymentPlan | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, | |  |  | float | *spawnPathOffset* = 0, | |  |  | float | *targetPathOffset* = 0f ) | | virtual |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a5f04e04901618a0e6049fa88e01bc0d3).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a8585ee329435de403da3ca78196f4b7c)RemakeDeploymentPlan()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual bool TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic.RemakeDeploymentPlan | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team* | ) |  | | virtual |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a5a397084cfe61349e86f9a8b320975d0).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a2037eaa729778e47e67d1e3e1a4ab0c2)ClearDeploymentPlan()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic.ClearDeploymentPlan | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team* | ) |  | | virtual |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#aafbab48a0ded868281dbde98fd02abe5).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a4553e03c5c6da0f3266b3fa62825a1b9)IsPlanMade() [1/2]
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual bool TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic.IsPlanMade | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team* | ) |  | | virtual |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#ac2d5841ae4d2528a32dcbb1e17ae701f).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a06dab921bebe3222d50fd8c054b6ad1a)IsPlanMade() [2/2]
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual bool TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic.IsPlanMade | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, | |  |  | out bool | *isFirstPlan* ) | | virtual |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#af606a0b88e10c37c9c53bf213b8d1516).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a37452100dc51dcd368d639d07aa39a9b)IsPositionInsideDeploymentBoundaries()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual bool TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic.IsPositionInsideDeploymentBoundaries | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, | |  |  | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position* ) | | virtual |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#ae8cf002ac02e898508640716a1dcc574).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a074841800faf3151a9f5b38d5276b631)HasDeploymentBoundaries()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual bool TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic.HasDeploymentBoundaries | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team* | ) |  | | virtual |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#aa3f31326980a6d0b40bb16675fc3dbc8).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a8ce19818130ac06d871dbc11cfa05e71)GetDeploymentBoundaries()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual MBReadOnlyList<(string id, MBList< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > points)> TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic.GetDeploymentBoundaries | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team* | ) |  | | virtual |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#ae83569634dd1162cfa156ab2a00c7745).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#aeb0f262a0329d237c4b965e37562dc9f)SupportsReinforcements()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual bool TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic.SupportsReinforcements | ( |  | ) |  | | virtual |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a96ffeb0911939e55090b3f8b318db7ce).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#aa95136a5d576efa3e6a5a7aeab43127d)SupportsNavmesh()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual bool TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic.SupportsNavmesh | ( |  | ) |  | | virtual |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#af909348519e7c4ed33ef26b054835abf).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a6e6df0c4db444cf4c7b1b8b62a28fd5f)HasPlayerSpawnFrame()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual bool TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic.HasPlayerSpawnFrame | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *battleSide* | ) |  | | virtual |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a991108d1f3482b30c53327999c9636e1).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a732ed706aeaef91bd19bc60b0c82f807)GetPlayerSpawnFrame()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual bool TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic.GetPlayerSpawnFrame | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *battleSide*, | |  |  | out [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *position*, | |  |  | out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *direction* ) | | virtual |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#ac5fc005ee8f8960b1f2693267ba51845).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#ab0197b5f8f58b829df55e4f793179d04)GetClosestDeploymentBoundaryPosition()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic.GetClosestDeploymentBoundaryPosition | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, | |  |  | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position* ) | | virtual |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a2c5d366238cc3dd17f0b8c0f29e2e7cf).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a46e6a2f39ec213104b60590438f51a93)ProjectPositionToDeploymentBoundaries()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic.ProjectPositionToDeploymentBoundaries | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, | |  |  | ref [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *position* ) | | virtual |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a7c27be32e56c4825a226d03932a58a03).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#ab71fbee1853651209f8c14366715534a)GetPathDeploymentBoundaryIntersection()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual bool TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic.GetPathDeploymentBoundaryIntersection | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, | |  |  | in [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *startPosition*, | |  |  | in [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *endPosition*, | |  |  | out [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *foundPosition* ) | | virtual |

Start position must be within deployment boundaries. Both start and end positions must also be valid on navmesh. If the path exists entirely within deployment boundaries, method returns true and intersection will be set to endPosition

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a625757c9a4393fb9cca0e249073f81f4).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#aa37d268c8721ce51cdaf4e5e43bcbade)GetDeploymentFrame()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic.GetDeploymentFrame | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team* | ) |  | | virtual |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#ad8abe87ebe199f7e97ccd80ccca6892d).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#acb79bfa9cfc4483662472ae0dc76fbe8)GetFormationPlan()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual [IFormationDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_deployment_plan.html) TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic.GetFormationPlan | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, | |  |  | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | *fClass*, | |  |  | bool | *isReinforcement* = false ) | | virtual |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a89722c6554823d956e2ac4e8033428e2).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#ae335a2ec9ad3fca37b2671d3f1cb95c2)GetSpawnPathOffset()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual float TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic.GetSpawnPathOffset | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team* | ) |  | | virtual |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a8acb861b11280f0a680729b409dca8b2).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a30280473bbf9ea9c1c150ed7a177d48f)GetZoomFocusFrame()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic.GetZoomFocusFrame | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team* | ) |  | | virtual |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a66ced365450255006e8d86ede8076bca).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a31eca9deaabe34b67d36dcc8458a827b)GetZoomOffset()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual float TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic.GetZoomOffset | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, | |  |  | float | *fovAngle* ) | | virtual |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a1f73dfde698cfd2ba9248bae177c0513).

