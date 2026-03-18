--- SOURCE: class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html ---

SandBox.Missions.MissionLogics.Hideout.HideoutCinematicController Class ReferenceInherits [TaleWorlds.MountAndBlade.MissionLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html).

|  |  |
| --- | --- |
| Classes | |
| struct | [HideoutCinematicAgentInfo](struct_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller_1_1_hideout_cinematic_agent_info.html) |

|  |  |
| --- | --- |
| Public Types | |
| enum | [HideoutCinematicState](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a93174cde7b156e66b073696d916816d0) {     [None](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a93174cde7b156e66b073696d916816d0a6adf97f83acf6453d4a6a4b1070f3754) ,     [InitialFadeOut](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a93174cde7b156e66b073696d916816d0aac5e399921086de259b937834656704f) ,     [PreCinematic](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a93174cde7b156e66b073696d916816d0ae171263f502848972be9b40df81325b8) ,     [Cinematic](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a93174cde7b156e66b073696d916816d0a8fce77fd86da3af309c0ad415d8d7952) ,     [PostCinematic](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a93174cde7b156e66b073696d916816d0ae8d147be8e547a290a5ae185013f5a14) ,     [Completed](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a93174cde7b156e66b073696d916816d0a07ca5050e697392c9ed47e6453f1453f)   } |
| enum | [HideoutAgentType](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a66ae97f59c3b886c3f2bc91a55df2214) {     [Player](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a66ae97f59c3b886c3f2bc91a55df2214a636da1d35e805b00eae0fcd8333f9234) = 0 ,     [Boss](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a66ae97f59c3b886c3f2bc91a55df2214a5859831e2b3db23528c710b1451e13fc) ,     [Ally](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a66ae97f59c3b886c3f2bc91a55df2214a0dd87782600574e2f791bcfe639d4fcc) ,     [Bandit](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a66ae97f59c3b886c3f2bc91a55df2214a7534759ceb94c0e91b13a22fe6e16980)   } |
| enum | [HideoutPreCinematicPhase](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a404c1068d5e85f938fcec6eefc164db0) {     [NotStarted](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a404c1068d5e85f938fcec6eefc164db0afa7be7845bc42b3491d9d0377958be94) ,     [InitializeFormations](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a404c1068d5e85f938fcec6eefc164db0a0cf414d051a2deb895f2d2a2c702b335) ,     [StopFormations](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a404c1068d5e85f938fcec6eefc164db0ae432e9d1d2c7fda32c2032484048a7c0) ,     [InitializeAgents](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a404c1068d5e85f938fcec6eefc164db0a630a6d0c79d63c897ef1921084466d06) ,     [MoveAgents](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a404c1068d5e85f938fcec6eefc164db0a3e1a2118e4e272c757470779a351dac6) ,     [Completed](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a404c1068d5e85f938fcec6eefc164db0a07ca5050e697392c9ed47e6453f1453f)   } |
| enum | [HideoutPostCinematicPhase](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#aea295a4407af0e768e76016423b14cb0) {     [NotStarted](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#aea295a4407af0e768e76016423b14cb0afa7be7845bc42b3491d9d0377958be94) ,     [MoveAgents](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#aea295a4407af0e768e76016423b14cb0a3e1a2118e4e272c757470779a351dac6) ,     [FinalizeAgents](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#aea295a4407af0e768e76016423b14cb0a809fe88c5e4b47ba25fe456d0f3a5f72) ,     [Completed](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#aea295a4407af0e768e76016423b14cb0a07ca5050e697392c9ed47e6453f1453f)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| delegate void | [OnInitialFadeOutFinished](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a45a281c2627083908ffe3a7da3834edc) (ref [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) playerAgent, ref List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > playerCompanions, ref [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) bossAgent, ref List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > bossCompanions, ref float placementPerturbation, ref float placementAngle) |
|  | This is called when the initial fade out phase of the cinematic is finished. The caller should supply which agents will participate to the boss fight now and their placement details. |
| delegate void | [OnHideoutCinematicFinished](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a7daf9e560dd1a2034a7d242249058545) () |
|  | [HideoutCinematicController](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a5aa226be9d1a739fba7589dab6f80387) () |
| void | [StartCinematic](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a48509146e849973793956681ceaa8613) ([OnInitialFadeOutFinished](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a45a281c2627083908ffe3a7da3834edc) initialFadeOutFinished, Action cinematicFinishedCallback, float transitionDuration=[DefaultTransitionDuration](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a8b225d48fdc60d32ad6bd7434c0778d6), float stateDuration=[DefaultStateDuration](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a6d980d05d2ace15d89434f9b38f25700), float cinematicDuration=[DefaultCinematicDuration](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a305d74e03fbd6cb73fc4edf2c85d75f9), bool forceDismountAgents=false) |
| void | [GetBossStandingEyePosition](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a4ce0e5e6bd92a3dfe1a0e6c7c60dcf86) (out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) eyePosition) |
| void | [GetPlayerStandingEyePosition](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#ac480da369a6bc02fdc9e5ac8cb723102) (out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) eyePosition) |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetBanditsInitialFrame](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a180ec3ce6c420e31e7881f1f5dc2c220) () |
| void | [GetScenePrefabParameters](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a348ca408eccdf17e23d3449b41224cf3) (out float innerRadius, out float outerRadius, out float walkDistance) |
| override void | [OnBehaviorInitialize](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a5a765552f70112ed38d3d6b672435712) () |
| override void | [OnMissionTick](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a2344c9a20b789788a344edfb64ebefe2) (float dt) |
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
| const string | [HideoutSceneEntityTag](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#aa67e3ff5fce6e2ed46bd116b580b0e33) = "hideout\_boss\_fight" |
| const float | [DefaultTransitionDuration](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a8b225d48fdc60d32ad6bd7434c0778d6) = 0.4f |
| const float | [DefaultStateDuration](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a6d980d05d2ace15d89434f9b38f25700) = 0.2f |
| const float | [DefaultCinematicDuration](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a305d74e03fbd6cb73fc4edf2c85d75f9) = 8.0f |
| const float | [DefaultPlacementPerturbation](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a7964f35d598284cb9cc6c201087f7077) = 0.25f |
| const float | [DefaultPlacementAngle](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#adc53ef26cbd231efcd466c081127875c) = 12 \* MBMath.DegreesToRadians |

|  |  |
| --- | --- |
| Properties | |
| [HideoutCinematicState](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a93174cde7b156e66b073696d916816d0) | [State](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a9cdce29655b94e8110b4046b78925d16) `[get]` |
| bool | [InStateTransition](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a0fdcdc25b2bc2f8fb94120d7070030e8) `[get]` |
| bool | [IsCinematicActive](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#af0d852f12c363fc288bbc18941a685da) `[get]` |
| float | [CinematicDuration](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a9d822e6cd48a242ca865c191c9d7795b) `[get]` |
| float | [TransitionDuration](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#af202a7815e384c2dcb119b647f350ae0) `[get]` |
| override [MissionBehaviorType](namespace_tale_worlds_1_1_mount_and_blade.html#a372fbfd8b3eae375d7fd2e0dcbb76993) | [BehaviorType](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#ad4028201fa3dc1fe42afaf0eeff9aa77) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.MissionLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html) | |
| override [MissionBehaviorType](namespace_tale_worlds_1_1_mount_and_blade.html#a372fbfd8b3eae375d7fd2e0dcbb76993) | [BehaviorType](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html#a22dc913ab511b0a23db3e6a09b76fcd7) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html) | |
| Mission | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aa8057eb8e1718954a667dc0c9a334281) `[get]` |
| [IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html) | [DebugInput](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ac73ea22074a4d9e10f0018fda1a4c67c) `[get]` |
| [MissionBehaviorType](namespace_tale_worlds_1_1_mount_and_blade.html#a372fbfd8b3eae375d7fd2e0dcbb76993) | [BehaviorType](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aca34f7ade7fa89aba9d51c8330684cc5) `[get]` |

|  |  |
| --- | --- |
| Events | |
| Action | [OnCinematicFinished](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a584d7589b3be46f407d22dc128f1fb1b) |
| Action< [HideoutCinematicState](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a93174cde7b156e66b073696d916816d0) > | [OnCinematicStateChanged](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#ad769d13f6a250d80db55c12d394a5eb3) |
| Action< [HideoutCinematicState](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a93174cde7b156e66b073696d916816d0), float > | [OnCinematicTransition](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a6f207dc153a7f72ba4c89baa78420639) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html) | |
| virtual void | [OnEndMission](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a2520fc88c264958b60ba7b75a4714117) () |
|  | Called right before the mission ends (i.e. after player clicks done/retreat button in battle results screen for SP missions). Preferably unregister all your [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) dependent events here. Some mission fields (like agent lists) will be deallocated after the mission ends. |

Member Enumeration Documentation
--------------------------------

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a93174cde7b156e66b073696d916816d0)HideoutCinematicState
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [SandBox.Missions.MissionLogics.Hideout.HideoutCinematicController.HideoutCinematicState](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a93174cde7b156e66b073696d916816d0) |

| Enumerator | |
| --- | --- |
| None |  |
| InitialFadeOut |  |
| PreCinematic |  |
| Cinematic |  |
| PostCinematic |  |
| Completed |  |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a66ae97f59c3b886c3f2bc91a55df2214)HideoutAgentType
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [SandBox.Missions.MissionLogics.Hideout.HideoutCinematicController.HideoutAgentType](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a66ae97f59c3b886c3f2bc91a55df2214) |

| Enumerator | |
| --- | --- |
| Player |  |
| Boss |  |
| Ally |  |
| Bandit |  |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a404c1068d5e85f938fcec6eefc164db0)HideoutPreCinematicPhase
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [SandBox.Missions.MissionLogics.Hideout.HideoutCinematicController.HideoutPreCinematicPhase](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a404c1068d5e85f938fcec6eefc164db0) |

| Enumerator | |
| --- | --- |
| NotStarted |  |
| InitializeFormations |  |
| StopFormations |  |
| InitializeAgents |  |
| MoveAgents |  |
| Completed |  |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#aea295a4407af0e768e76016423b14cb0)HideoutPostCinematicPhase
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [SandBox.Missions.MissionLogics.Hideout.HideoutCinematicController.HideoutPostCinematicPhase](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#aea295a4407af0e768e76016423b14cb0) |

| Enumerator | |
| --- | --- |
| NotStarted |  |
| MoveAgents |  |
| FinalizeAgents |  |
| Completed |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a5aa226be9d1a739fba7589dab6f80387)HideoutCinematicController()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| SandBox.Missions.MissionLogics.Hideout.HideoutCinematicController.HideoutCinematicController | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a45a281c2627083908ffe3a7da3834edc)OnInitialFadeOutFinished()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate void SandBox.Missions.MissionLogics.Hideout.HideoutCinematicController.OnInitialFadeOutFinished | ( | ref [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *playerAgent*, |
|  |  | ref List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | *playerCompanions*, |
|  |  | ref [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *bossAgent*, |
|  |  | ref List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | *bossCompanions*, |
|  |  | ref float | *placementPerturbation*, |
|  |  | ref float | *placementAngle* ) |

Parameters
:   |  |  |
    | --- | --- |
    | playerAgent | The player agent that will participate to the bossfight |
    | playerCompanions | Player companions that will be participating to the boss fight |
    | bossAgent | The boss agent. |
    | bossCompanions | Boss' companions that will be participating to the boss fight |
    | placementPerturbation | The amount of random position perturbation between agents when they achieve their target frames for boss fight. |
    | placementAngle | The amount of angular distance (in radians) between agents when they achieve their target frames. |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a7daf9e560dd1a2034a7d242249058545)OnHideoutCinematicFinished()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| delegate void SandBox.Missions.MissionLogics.Hideout.HideoutCinematicController.OnHideoutCinematicFinished | ( |  | ) |  |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a48509146e849973793956681ceaa8613)StartCinematic()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.Missions.MissionLogics.Hideout.HideoutCinematicController.StartCinematic | ( | [OnInitialFadeOutFinished](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a45a281c2627083908ffe3a7da3834edc) | *initialFadeOutFinished*, |
|  |  | Action | *cinematicFinishedCallback*, |
|  |  | float | *transitionDuration* = [DefaultTransitionDuration](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a8b225d48fdc60d32ad6bd7434c0778d6), |
|  |  | float | *stateDuration* = [DefaultStateDuration](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a6d980d05d2ace15d89434f9b38f25700), |
|  |  | float | *cinematicDuration* = [DefaultCinematicDuration](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a305d74e03fbd6cb73fc4edf2c85d75f9), |
|  |  | bool | *forceDismountAgents* = false ) |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a4ce0e5e6bd92a3dfe1a0e6c7c60dcf86)GetBossStandingEyePosition()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.Missions.MissionLogics.Hideout.HideoutCinematicController.GetBossStandingEyePosition | ( | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *eyePosition* | ) |  |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#ac480da369a6bc02fdc9e5ac8cb723102)GetPlayerStandingEyePosition()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.Missions.MissionLogics.Hideout.HideoutCinematicController.GetPlayerStandingEyePosition | ( | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *eyePosition* | ) |  |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a180ec3ce6c420e31e7881f1f5dc2c220)GetBanditsInitialFrame()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) SandBox.Missions.MissionLogics.Hideout.HideoutCinematicController.GetBanditsInitialFrame | ( |  | ) |  |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a348ca408eccdf17e23d3449b41224cf3)GetScenePrefabParameters()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.Missions.MissionLogics.Hideout.HideoutCinematicController.GetScenePrefabParameters | ( | out float | *innerRadius*, |
|  |  | out float | *outerRadius*, |
|  |  | out float | *walkDistance* ) |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a5a765552f70112ed38d3d6b672435712)OnBehaviorInitialize()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.Missions.MissionLogics.Hideout.HideoutCinematicController.OnBehaviorInitialize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a94e4fe46fad26b2a84dbbf3a4a5cc14c).

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a2344c9a20b789788a344edfb64ebefe2)OnMissionTick()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.Missions.MissionLogics.Hideout.HideoutCinematicController.OnMissionTick | ( | float | *dt* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a006b322c9ef8b55a1897419394c0a1e4).

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#aa67e3ff5fce6e2ed46bd116b580b0e33)HideoutSceneEntityTag
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string SandBox.Missions.MissionLogics.Hideout.HideoutCinematicController.HideoutSceneEntityTag = "hideout\_boss\_fight" | | static |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a8b225d48fdc60d32ad6bd7434c0778d6)DefaultTransitionDuration
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float SandBox.Missions.MissionLogics.Hideout.HideoutCinematicController.DefaultTransitionDuration = 0.4f | | static |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a6d980d05d2ace15d89434f9b38f25700)DefaultStateDuration
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float SandBox.Missions.MissionLogics.Hideout.HideoutCinematicController.DefaultStateDuration = 0.2f | | static |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a305d74e03fbd6cb73fc4edf2c85d75f9)DefaultCinematicDuration
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float SandBox.Missions.MissionLogics.Hideout.HideoutCinematicController.DefaultCinematicDuration = 8.0f | | static |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a7964f35d598284cb9cc6c201087f7077)DefaultPlacementPerturbation
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float SandBox.Missions.MissionLogics.Hideout.HideoutCinematicController.DefaultPlacementPerturbation = 0.25f | | static |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#adc53ef26cbd231efcd466c081127875c)DefaultPlacementAngle
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float SandBox.Missions.MissionLogics.Hideout.HideoutCinematicController.DefaultPlacementAngle = 12 \* MBMath.DegreesToRadians | | static |

Property Documentation
----------------------

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a9cdce29655b94e8110b4046b78925d16)State
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HideoutCinematicState](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a93174cde7b156e66b073696d916816d0) SandBox.Missions.MissionLogics.Hideout.HideoutCinematicController.State | | get |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a0fdcdc25b2bc2f8fb94120d7070030e8)InStateTransition
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.Missions.MissionLogics.Hideout.HideoutCinematicController.InStateTransition | | get |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#af0d852f12c363fc288bbc18941a685da)IsCinematicActive
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.Missions.MissionLogics.Hideout.HideoutCinematicController.IsCinematicActive | | get |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a9d822e6cd48a242ca865c191c9d7795b)CinematicDuration
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float SandBox.Missions.MissionLogics.Hideout.HideoutCinematicController.CinematicDuration | | get |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#af202a7815e384c2dcb119b647f350ae0)TransitionDuration
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float SandBox.Missions.MissionLogics.Hideout.HideoutCinematicController.TransitionDuration | | get |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#ad4028201fa3dc1fe42afaf0eeff9aa77)BehaviorType
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [MissionBehaviorType](namespace_tale_worlds_1_1_mount_and_blade.html#a372fbfd8b3eae375d7fd2e0dcbb76993) SandBox.Missions.MissionLogics.Hideout.HideoutCinematicController.BehaviorType | | get |

Event Documentation
-------------------

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a584d7589b3be46f407d22dc128f1fb1b)OnCinematicFinished
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action SandBox.Missions.MissionLogics.Hideout.HideoutCinematicController.OnCinematicFinished |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#ad769d13f6a250d80db55c12d394a5eb3)OnCinematicStateChanged
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[HideoutCinematicState](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a93174cde7b156e66b073696d916816d0)> SandBox.Missions.MissionLogics.Hideout.HideoutCinematicController.OnCinematicStateChanged |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a6f207dc153a7f72ba4c89baa78420639)OnCinematicTransition
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[HideoutCinematicState](class_sand_box_1_1_missions_1_1_mission_logics_1_1_hideout_1_1_hideout_cinematic_controller.html#a93174cde7b156e66b073696d916816d0), float> SandBox.Missions.MissionLogics.Hideout.HideoutCinematicController.OnCinematicTransition |

