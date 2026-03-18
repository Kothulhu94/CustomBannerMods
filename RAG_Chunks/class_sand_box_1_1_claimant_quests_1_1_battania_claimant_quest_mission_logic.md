--- SOURCE: class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html ---

SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic Class ReferenceInherits [TaleWorlds.MountAndBlade.MissionLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html).

|  |  |
| --- | --- |
| Classes | |
| class | [SceneState](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic_1_1_scene_state.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
| delegate bool | [MissionExitDelegate](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a0628f6609c76d55fb0f043e5043ba0fa) (out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) explanation) |
|  | [BattaniaClaimantQuestMissionLogic](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a04d299d02f7809d18eeab0db45ae8215) () |
| override void | [AfterStart](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a13bad9a941be791075fbda4728826a69) () |
| override [InquiryData](class_tale_worlds_1_1_library_1_1_inquiry_data.html) | [OnEndMissionRequest](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#ae68c7b96fdd6d9d4e78031e0c90942f5) (out bool canPlayerLeave) |
| override void | [OnAgentRemoved](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a3e1a47f6277ecbfdc5e0571060b525a8) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectedAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectorAgent, [AgentState](namespace_tale_worlds_1_1_core.html#a799bcc77ddb6372c7383f3340ed4d1c0) agentState, [KillingBlow](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html) blow) |
| void | [SetConversationAgent](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a4d50ec2222db05e6f3bb063347e6aa7c) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, float time=-1) |
| void | [ChangeSceneState](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a712cda5f9ef2e54fa2fde32c59ea286f) ([SceneState.StateDefinition](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic_1_1_scene_state.html#a0c91e77226f7383c508040d9692c7c6b) state) |
| override void | [OnMissionTick](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#adddbe23bd53c1665bdd48029d4e41329) (float dt) |
| override void | [OnRemoveBehavior](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#aab5a6ba2acbe8c80200f2c0961ac6bc7) () |
| override void | [OnObjectUsed](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a844791f7b2b2f7c79510937c8e15d724) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) userAgent, [UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) usedObject) |
| override void | [OnAgentHit](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a77575ed884515b53af975cf392f2198e) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectedAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectorAgent, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) affectorWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) attackCollisionData) |
| void | [TeleportHeroToPosition](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a19caa5eb2e924eb19458ea0461a6c1e0) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agentToTeleport, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) target) |
| void | [TeleportNearAgent](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#ac8fa70efb4667d88044a49bcd6f8202b) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agentToTeleport, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) target, float minDist=2f, float maxDist=5f) |
| void | [StartDuel](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a0440aee8cdd426ddd387e80478332a75) (bool dropWeapons, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) opponent, OnFightEndDelegate onFightEnd) |
| void | [StartFistFight](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#aedeb17707be2c76b32fcc720eb9504c2) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) opponent, OnFightEndDelegate onFightEnd) |
| [TeleportUsePoint](class_sand_box_1_1_objects_1_1_teleport_use_point.html) | [GetTeleportUsePoint](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a5fb7c6334b2b138e92eb6508387d33b9) (string tag) |
| void | [ActivateTeleportPoint](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a79e1405b2e6c826c1562039482f99f14) (string tag) |
| void | [DeactivateTeleportPoint](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a4b03376868d4a47c6575882308cdfc78) (string tag) |
| void | [StartBattle](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#afa1a93e9f2481c827c8ac3247aad47bf) (List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > attackers, List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > defenders, OnFightEndDelegate onFightEnd, float delay=float.Epsilon, float minTime=float.Epsilon) |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [SpawnAgent](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a813915d8117cbe1445ed358116be8218) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, string spawnTag, string actionSetCode, [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) spawnEntity, [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) culture, AddBehaviorsDelegate addBehaviors, AfterAgentCreatedDelegate afterAgentCreated, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction, CharacterRelations relation=CharacterRelations.Neutral, bool isTracked=false, bool isFixedCharacter=true) |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [SpawnAgent](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a30d9175476ef09573a91db83d86d2d51) (string stringId, string spawnTag, string actionSetCode, [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) spawnEntity, [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) culture, AddBehaviorsDelegate addBehaviors, AfterAgentCreatedDelegate afterAgentCreated, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction, CharacterRelations relation=CharacterRelations.Neutral, bool isTracked=false, bool isFixedCharacter=true) |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [SpawnAgent](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a04ce98d8ea4a50aa7a59942fb0a75432) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, string spawnTag, [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame, [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) spawnEntity, string actionSetCode, [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) culture, AddBehaviorsDelegate addBehaviors, AfterAgentCreatedDelegate afterAgentCreated, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction, CharacterRelations relation=CharacterRelations.Neutral, bool isTracked=false, bool isFixedCharacter=true) |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [SpawnAgent](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a4cc403441595d9149708bf98bf6962a7) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, string spawnTag, [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) spawnEntity, string actionSetCode, [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) culture, AddBehaviorsDelegate addBehaviors, AfterAgentCreatedDelegate afterAgentCreated, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction, CharacterRelations relation=CharacterRelations.Neutral, bool isTracked=false, bool isFixedCharacter=true) |
| void | [SpawnAgentDelayed](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#ab70a38781a7e0ada86255cab67614aa1) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, string spawnTag, [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) spawnEntity, string actionSetCode, [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) culture, AddBehaviorsDelegate addBehaviors, AfterAgentCreatedDelegate afterAgentCreated, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction, CharacterRelations relation=CharacterRelations.Neutral, bool isTracked=false, bool isFixedCharacter=true, float delay=3f) |
| void | [SpawnAgentDelayed](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a52c89ff75278dc8d95c77a7631ea0754) (string stringId, string spawnTag, [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) spawnEntity, string actionSetCode, [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) culture, AddBehaviorsDelegate addBehaviors, AfterAgentCreatedDelegate afterAgentCreated, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction, CharacterRelations relation=CharacterRelations.Neutral, bool isTracked=false, bool isFixedCharacter=true, float delay=3f) |
| void | [SpawnAgentsAroundEntityDelayed](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#afcc04199eacbfcff7f7f69df1d91e395) (string stringId, string spawnTag, [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) spawnEntity, string actionSetCode, int count, [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) culture, AddBehaviorsDelegate addBehaviors, AfterAgentCreatedDelegate afterAgentCreated, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction, CharacterRelations relation=CharacterRelations.Neutral, bool isTracked=false, bool isFixedCharacter=true, float delay=3f) |
| List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | [SpawnAgentsAroundEntity](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#ae16a7a125be5746d53cc92bf698c347b) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) entity, string spawnTag, string actionSetCode, int count, [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) culture, AddBehaviorsDelegate addBehaviors, AfterAgentCreatedDelegate afterAgentCreated, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction, CharacterRelations relation=CharacterRelations.Neutral, float minDist=1f, float maxDist=6f, bool isTracked=false, bool isFixedCharacter=true) |
| List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | [SpawnAgentsAroundEntity](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a4630cd0d8dd3fa3d5c918a34982be384) (string stringId, [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) entity, string spawnTag, string actionSetCode, int count, [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) culture, AddBehaviorsDelegate addBehaviors, AfterAgentCreatedDelegate afterAgentCreated, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction, CharacterRelations relation=CharacterRelations.Neutral, float minDist=1f, float maxDist=6f, bool isTracked=false, bool isFixedCharacter=true) |
| List< [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) > | [AddLocationCharacters](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a27008f0714a01caf1f9002fa4e7e9ce2) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, string spawnTag, string actionSetCode, int count, [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) culture, AddBehaviorsDelegate addBehaviors, AfterAgentCreatedDelegate afterAgentCreated, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction, CharacterRelations relation=CharacterRelations.Neutral, bool isTracked=false, bool isFixedCharacter=true) |
| List< [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) > | [AddLocationCharacters](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a74b5eb9845c4d7bcf9710e2a771759da) (string stringId, string spawnTag, string actionSetCode, int count, [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) culture, AddBehaviorsDelegate addBehaviors, AfterAgentCreatedDelegate afterAgentCreated, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction, CharacterRelations relation=CharacterRelations.Neutral, bool isTracked=false, bool isFixedCharacter=true) |
| [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) | [AddLocationCharacter](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#aea58adb54bea394d3d1056c16623f906) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, string spawnTag, string actionSetCode, [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) culture, AddBehaviorsDelegate addBehaviors, AfterAgentCreatedDelegate afterAgentCreated, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction, CharacterRelations relation=CharacterRelations.Neutral, bool isTracked=false, bool isFixedCharacter=true) |
| [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) | [AddLocationCharacter](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#aa4aeb3f110562974fd4bb0965fe3dee7) (string stringId, string spawnTag, string actionSetCode, [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) culture, AddBehaviorsDelegate addBehaviors, AfterAgentCreatedDelegate afterAgentCreated, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction, CharacterRelations relation=CharacterRelations.Neutral, bool isTracked=false, bool isFixedCharacter=true) |
| List< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > | [GetVisibleEntitiesWithTag](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a2c2d28637a846e59705180b46efa348a) (string tag) |
| List< [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) > | [GetSpawnPoints](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#ac910b4d5807a17002b5f7d0b139a81d2) (string tag) |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [GetVisibleEntityWithTag](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a28589650287cafe628d9cceb78e62e92) (string tag) |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [GetEntityWithTag](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#ac667330571f8cb013a337886884773a9) (string tag, bool checkVisibility=true) |
| void | [FadeOut](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a2c7b89652394d90b262858e21a73263f) (float fadeOutTime, float blackTime, float fadeInTime) |
| void | [FadeOut](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a6b2613a5c0871d6a50306926ae756469) () |
| void | [AddGenericMarker](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a6dc3450f2d88c814e78cfec8f8fd3cf2) (string tag, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) name, string type, float radius=5f) |
| void | [AddGenericMarker](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a7a33f5be8e3ef2e17b7f157647b47ab0) ([WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) name, string type, float radius=5f) |
| void | [AddGenericMarker](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a7a9f005d4dbb51347a82563ea0681e48) ([StealthAreaUsePoint](class_sand_box_1_1_objects_1_1_usables_1_1_stealth_area_use_point.html) stealthAreaUsePoint) |
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
| virtual void | [OnFixedMissionTick](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aee013ab26ac67f4043a1b839112572a3) (float fixedDt) |
| virtual void | [OnPreMissionTick](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ac5f9da64f58e30eb4ef62a39596e1af7) (float dt) |
| virtual void | [OnPreDisplayMissionTick](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aca165ecaaa9e2c3e2c96219353678a3c) (float dt) |
| virtual void | [OnAgentMount](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#acd50c486f7723094db2816a6628b43fd) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| virtual void | [OnAgentDismount](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a0b9976fba83dd53e5936601bf4ee976b) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| virtual bool | [IsThereAgentAction](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a7624ad654b98307d9787ea0306201eee) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) userAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) otherAgent) |
| virtual void | [OnEntityRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a57fadca1dc84db12184b4b565f9c80ca) ([GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) entity) |
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
| Public Attributes | |
| [MissionExitDelegate](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a0628f6609c76d55fb0f043e5043ba0fa) | [OnMissionExitRequested](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a677e47ac11695ad98d5887bca3ba82bb) = null |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const string | [HiddenEntranceTag](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#afe704d63e1b26c9f216810ea6dd9bc05) = "teleport\_1" |
| const string | [HiddenExitTag](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a0e04a50782868cee31a99d9772aeec79) = "teleport\_2" |
| const string | [CastleGateEntranceTag](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a7e8c667b0743d95d14b8386e902ab1c5) = "inner\_gate" |
| const string | [NormalState](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#ad9afd888f2ae38f8a512e85ae8d38147) = "mission\_state" |
| const string | [AmbushState](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a4e5a5f1f2736ed151ee8f5bf1aa63bac) = "ambush\_state" |
| const string | [BattleState](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a1290be32214a26ad4c5145e6976db434) = "battle\_state" |
| const string | [FinalState](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#aed09ff3eb77125d5706b07cf879a32f5) = "final\_state" |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnEndMission](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#ae5c5445fa78df9835e1955c6e4c31988) () |
|  | Called right before the mission ends (i.e. after player clicks done/retreat button in battle results screen for SP missions). Preferably unregister all your Mission dependent events here. Some mission fields (like agent lists) will be deallocated after the mission ends. |

|  |  |
| --- | --- |
| Properties | |
| [StealthZone](class_sand_box_1_1_objects_1_1_stealth_zone.html) | [PermanentStealthZone](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a72d595b6f6cd9e87321949c423c8d3ee) `[get]` |
| [StealthZone](class_sand_box_1_1_objects_1_1_stealth_zone.html) | [AmbushZone](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a41f9a4f80def7108e2976e589898908e) `[get]` |
| [SceneState](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic_1_1_scene_state.html) | [CurrentSceneState](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a291a2f82d9f3e1bd632c51e137a8fefa) `[get]` |
| CastleGate | [CastleGate](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#ac277f295346c5da3aaf23014b98c4afb) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.MissionLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html) | |
| override [MissionBehaviorType](namespace_tale_worlds_1_1_mount_and_blade.html#a372fbfd8b3eae375d7fd2e0dcbb76993) | [BehaviorType](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html#a22dc913ab511b0a23db3e6a09b76fcd7) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html) | |
| Mission | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aa8057eb8e1718954a667dc0c9a334281) `[get]` |
| [IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html) | [DebugInput](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ac73ea22074a4d9e10f0018fda1a4c67c) `[get]` |
| [MissionBehaviorType](namespace_tale_worlds_1_1_mount_and_blade.html#a372fbfd8b3eae375d7fd2e0dcbb76993) | [BehaviorType](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#aca34f7ade7fa89aba9d51c8330684cc5) `[get]` |

|  |  |
| --- | --- |
| Events | |
| Action< float, float, float > | [OnFadeOut](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a3c265f323df5a2798e1440891665faee) |
| Action< [UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) > | [OnMissionObjectUsed](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#aa886d2054d5b7624faf15cde9110b262) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a04d299d02f7809d18eeab0db45ae8215)BattaniaClaimantQuestMissionLogic()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.BattaniaClaimantQuestMissionLogic | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a0628f6609c76d55fb0f043e5043ba0fa)MissionExitDelegate()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| delegate bool SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.MissionExitDelegate | ( | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *explanation* | ) |  |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a13bad9a941be791075fbda4728826a69)AfterStart()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.AfterStart | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a693295e26d8b0fcf634c52b1c08fd974).

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#ae68c7b96fdd6d9d4e78031e0c90942f5)OnEndMissionRequest()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override [InquiryData](class_tale_worlds_1_1_library_1_1_inquiry_data.html) SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.OnEndMissionRequest | ( | out bool | *canPlayerLeave* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_logic.html#a9373241b87874466fbb93f73f44acc83).

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a3e1a47f6277ecbfdc5e0571060b525a8)OnAgentRemoved()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.OnAgentRemoved | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *affectedAgent*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *affectorAgent*, | |  |  | [AgentState](namespace_tale_worlds_1_1_core.html#a799bcc77ddb6372c7383f3340ed4d1c0) | *agentState*, | |  |  | [KillingBlow](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html) | *blow* ) | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#ad4987b5b5e719f90cad1856b8c0b7976).

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a4d50ec2222db05e6f3bb063347e6aa7c)SetConversationAgent()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.SetConversationAgent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | float | *time* = -1 ) |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a712cda5f9ef2e54fa2fde32c59ea286f)ChangeSceneState()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.ChangeSceneState | ( | [SceneState.StateDefinition](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic_1_1_scene_state.html#a0c91e77226f7383c508040d9692c7c6b) | *state* | ) |  |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#adddbe23bd53c1665bdd48029d4e41329)OnMissionTick()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.OnMissionTick | ( | float | *dt* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a006b322c9ef8b55a1897419394c0a1e4).

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#aab5a6ba2acbe8c80200f2c0961ac6bc7)OnRemoveBehavior()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.OnRemoveBehavior | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a80cb93b393ebaa09e4fd5fbab467556f).

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#ae5c5445fa78df9835e1955c6e4c31988)OnEndMission()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.OnEndMission | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a2520fc88c264958b60ba7b75a4714117).

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a844791f7b2b2f7c79510937c8e15d724)OnObjectUsed()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.OnObjectUsed | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *userAgent*, | |  |  | [UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) | *usedObject* ) | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a3d381cb580df73e192ed90ca3b5748aa).

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a77575ed884515b53af975cf392f2198e)OnAgentHit()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.OnAgentHit | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *affectedAgent*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *affectorAgent*, | |  |  | in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *affectorWeapon*, | |  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow*, | |  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *attackCollisionData* ) | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html#a2ca3ef8b8c9419285565e1443873345d).

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a19caa5eb2e924eb19458ea0461a6c1e0)TeleportHeroToPosition()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.TeleportHeroToPosition | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agentToTeleport*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *target* ) |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#ac8fa70efb4667d88044a49bcd6f8202b)TeleportNearAgent()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.TeleportNearAgent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agentToTeleport*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *target*, |
|  |  | float | *minDist* = 2f, |
|  |  | float | *maxDist* = 5f ) |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a0440aee8cdd426ddd387e80478332a75)StartDuel()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.StartDuel | ( | bool | *dropWeapons*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *opponent*, |
|  |  | OnFightEndDelegate | *onFightEnd* ) |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#aedeb17707be2c76b32fcc720eb9504c2)StartFistFight()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.StartFistFight | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *opponent*, |
|  |  | OnFightEndDelegate | *onFightEnd* ) |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a5fb7c6334b2b138e92eb6508387d33b9)GetTeleportUsePoint()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [TeleportUsePoint](class_sand_box_1_1_objects_1_1_teleport_use_point.html) SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.GetTeleportUsePoint | ( | string | *tag* | ) |  |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a79e1405b2e6c826c1562039482f99f14)ActivateTeleportPoint()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.ActivateTeleportPoint | ( | string | *tag* | ) |  |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a4b03376868d4a47c6575882308cdfc78)DeactivateTeleportPoint()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.DeactivateTeleportPoint | ( | string | *tag* | ) |  |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#afa1a93e9f2481c827c8ac3247aad47bf)StartBattle()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.StartBattle | ( | List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | *attackers*, |
|  |  | List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | *defenders*, |
|  |  | OnFightEndDelegate | *onFightEnd*, |
|  |  | float | *delay* = float::Epsilon, |
|  |  | float | *minTime* = float::Epsilon ) |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a813915d8117cbe1445ed358116be8218)SpawnAgent() [1/4]
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.SpawnAgent | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, |
|  |  | string | *spawnTag*, |
|  |  | string | *actionSetCode*, |
|  |  | [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *spawnEntity*, |
|  |  | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | *culture*, |
|  |  | AddBehaviorsDelegate | *addBehaviors*, |
|  |  | AfterAgentCreatedDelegate | *afterAgentCreated*, |
|  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction*, |
|  |  | CharacterRelations | *relation* = CharacterRelations::Neutral, |
|  |  | bool | *isTracked* = false, |
|  |  | bool | *isFixedCharacter* = true ) |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a30d9175476ef09573a91db83d86d2d51)SpawnAgent() [2/4]
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.SpawnAgent | ( | string | *stringId*, |
|  |  | string | *spawnTag*, |
|  |  | string | *actionSetCode*, |
|  |  | [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *spawnEntity*, |
|  |  | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | *culture*, |
|  |  | AddBehaviorsDelegate | *addBehaviors*, |
|  |  | AfterAgentCreatedDelegate | *afterAgentCreated*, |
|  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction*, |
|  |  | CharacterRelations | *relation* = CharacterRelations::Neutral, |
|  |  | bool | *isTracked* = false, |
|  |  | bool | *isFixedCharacter* = true ) |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a04ce98d8ea4a50aa7a59942fb0a75432)SpawnAgent() [3/4]
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.SpawnAgent | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, |
|  |  | string | *spawnTag*, |
|  |  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame*, |
|  |  | [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *spawnEntity*, |
|  |  | string | *actionSetCode*, |
|  |  | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | *culture*, |
|  |  | AddBehaviorsDelegate | *addBehaviors*, |
|  |  | AfterAgentCreatedDelegate | *afterAgentCreated*, |
|  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction*, |
|  |  | CharacterRelations | *relation* = CharacterRelations::Neutral, |
|  |  | bool | *isTracked* = false, |
|  |  | bool | *isFixedCharacter* = true ) |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a4cc403441595d9149708bf98bf6962a7)SpawnAgent() [4/4]
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.SpawnAgent | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, |
|  |  | string | *spawnTag*, |
|  |  | [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *spawnEntity*, |
|  |  | string | *actionSetCode*, |
|  |  | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | *culture*, |
|  |  | AddBehaviorsDelegate | *addBehaviors*, |
|  |  | AfterAgentCreatedDelegate | *afterAgentCreated*, |
|  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction*, |
|  |  | CharacterRelations | *relation* = CharacterRelations::Neutral, |
|  |  | bool | *isTracked* = false, |
|  |  | bool | *isFixedCharacter* = true ) |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#ab70a38781a7e0ada86255cab67614aa1)SpawnAgentDelayed() [1/2]
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.SpawnAgentDelayed | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, |
|  |  | string | *spawnTag*, |
|  |  | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *spawnEntity*, |
|  |  | string | *actionSetCode*, |
|  |  | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | *culture*, |
|  |  | AddBehaviorsDelegate | *addBehaviors*, |
|  |  | AfterAgentCreatedDelegate | *afterAgentCreated*, |
|  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction*, |
|  |  | CharacterRelations | *relation* = CharacterRelations::Neutral, |
|  |  | bool | *isTracked* = false, |
|  |  | bool | *isFixedCharacter* = true, |
|  |  | float | *delay* = 3f ) |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a52c89ff75278dc8d95c77a7631ea0754)SpawnAgentDelayed() [2/2]
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.SpawnAgentDelayed | ( | string | *stringId*, |
|  |  | string | *spawnTag*, |
|  |  | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *spawnEntity*, |
|  |  | string | *actionSetCode*, |
|  |  | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | *culture*, |
|  |  | AddBehaviorsDelegate | *addBehaviors*, |
|  |  | AfterAgentCreatedDelegate | *afterAgentCreated*, |
|  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction*, |
|  |  | CharacterRelations | *relation* = CharacterRelations::Neutral, |
|  |  | bool | *isTracked* = false, |
|  |  | bool | *isFixedCharacter* = true, |
|  |  | float | *delay* = 3f ) |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#afcc04199eacbfcff7f7f69df1d91e395)SpawnAgentsAroundEntityDelayed()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.SpawnAgentsAroundEntityDelayed | ( | string | *stringId*, |
|  |  | string | *spawnTag*, |
|  |  | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *spawnEntity*, |
|  |  | string | *actionSetCode*, |
|  |  | int | *count*, |
|  |  | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | *culture*, |
|  |  | AddBehaviorsDelegate | *addBehaviors*, |
|  |  | AfterAgentCreatedDelegate | *afterAgentCreated*, |
|  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction*, |
|  |  | CharacterRelations | *relation* = CharacterRelations::Neutral, |
|  |  | bool | *isTracked* = false, |
|  |  | bool | *isFixedCharacter* = true, |
|  |  | float | *delay* = 3f ) |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#ae16a7a125be5746d53cc92bf698c347b)SpawnAgentsAroundEntity() [1/2]
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.SpawnAgentsAroundEntity | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, |
|  |  | [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *entity*, |
|  |  | string | *spawnTag*, |
|  |  | string | *actionSetCode*, |
|  |  | int | *count*, |
|  |  | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | *culture*, |
|  |  | AddBehaviorsDelegate | *addBehaviors*, |
|  |  | AfterAgentCreatedDelegate | *afterAgentCreated*, |
|  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction*, |
|  |  | CharacterRelations | *relation* = CharacterRelations::Neutral, |
|  |  | float | *minDist* = 1f, |
|  |  | float | *maxDist* = 6f, |
|  |  | bool | *isTracked* = false, |
|  |  | bool | *isFixedCharacter* = true ) |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a4630cd0d8dd3fa3d5c918a34982be384)SpawnAgentsAroundEntity() [2/2]
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.SpawnAgentsAroundEntity | ( | string | *stringId*, |
|  |  | [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *entity*, |
|  |  | string | *spawnTag*, |
|  |  | string | *actionSetCode*, |
|  |  | int | *count*, |
|  |  | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | *culture*, |
|  |  | AddBehaviorsDelegate | *addBehaviors*, |
|  |  | AfterAgentCreatedDelegate | *afterAgentCreated*, |
|  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction*, |
|  |  | CharacterRelations | *relation* = CharacterRelations::Neutral, |
|  |  | float | *minDist* = 1f, |
|  |  | float | *maxDist* = 6f, |
|  |  | bool | *isTracked* = false, |
|  |  | bool | *isFixedCharacter* = true ) |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a27008f0714a01caf1f9002fa4e7e9ce2)AddLocationCharacters() [1/2]
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| List< [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) > SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.AddLocationCharacters | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, |
|  |  | string | *spawnTag*, |
|  |  | string | *actionSetCode*, |
|  |  | int | *count*, |
|  |  | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | *culture*, |
|  |  | AddBehaviorsDelegate | *addBehaviors*, |
|  |  | AfterAgentCreatedDelegate | *afterAgentCreated*, |
|  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction*, |
|  |  | CharacterRelations | *relation* = CharacterRelations::Neutral, |
|  |  | bool | *isTracked* = false, |
|  |  | bool | *isFixedCharacter* = true ) |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a74b5eb9845c4d7bcf9710e2a771759da)AddLocationCharacters() [2/2]
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| List< [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) > SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.AddLocationCharacters | ( | string | *stringId*, |
|  |  | string | *spawnTag*, |
|  |  | string | *actionSetCode*, |
|  |  | int | *count*, |
|  |  | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | *culture*, |
|  |  | AddBehaviorsDelegate | *addBehaviors*, |
|  |  | AfterAgentCreatedDelegate | *afterAgentCreated*, |
|  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction*, |
|  |  | CharacterRelations | *relation* = CharacterRelations::Neutral, |
|  |  | bool | *isTracked* = false, |
|  |  | bool | *isFixedCharacter* = true ) |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#aea58adb54bea394d3d1056c16623f906)AddLocationCharacter() [1/2]
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.AddLocationCharacter | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, |
|  |  | string | *spawnTag*, |
|  |  | string | *actionSetCode*, |
|  |  | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | *culture*, |
|  |  | AddBehaviorsDelegate | *addBehaviors*, |
|  |  | AfterAgentCreatedDelegate | *afterAgentCreated*, |
|  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction*, |
|  |  | CharacterRelations | *relation* = CharacterRelations::Neutral, |
|  |  | bool | *isTracked* = false, |
|  |  | bool | *isFixedCharacter* = true ) |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#aa4aeb3f110562974fd4bb0965fe3dee7)AddLocationCharacter() [2/2]
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.AddLocationCharacter | ( | string | *stringId*, |
|  |  | string | *spawnTag*, |
|  |  | string | *actionSetCode*, |
|  |  | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | *culture*, |
|  |  | AddBehaviorsDelegate | *addBehaviors*, |
|  |  | AfterAgentCreatedDelegate | *afterAgentCreated*, |
|  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction*, |
|  |  | CharacterRelations | *relation* = CharacterRelations::Neutral, |
|  |  | bool | *isTracked* = false, |
|  |  | bool | *isFixedCharacter* = true ) |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a2c2d28637a846e59705180b46efa348a)GetVisibleEntitiesWithTag()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| List< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.GetVisibleEntitiesWithTag | ( | string | *tag* | ) |  |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#ac910b4d5807a17002b5f7d0b139a81d2)GetSpawnPoints()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| List< [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) > SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.GetSpawnPoints | ( | string | *tag* | ) |  |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a28589650287cafe628d9cceb78e62e92)GetVisibleEntityWithTag()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.GetVisibleEntityWithTag | ( | string | *tag* | ) |  |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#ac667330571f8cb013a337886884773a9)GetEntityWithTag()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.GetEntityWithTag | ( | string | *tag*, |
|  |  | bool | *checkVisibility* = true ) |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a2c7b89652394d90b262858e21a73263f)FadeOut() [1/2]
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.FadeOut | ( | float | *fadeOutTime*, |
|  |  | float | *blackTime*, |
|  |  | float | *fadeInTime* ) |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a6b2613a5c0871d6a50306926ae756469)FadeOut() [2/2]
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.FadeOut | ( |  | ) |  |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a6dc3450f2d88c814e78cfec8f8fd3cf2)AddGenericMarker() [1/3]
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.AddGenericMarker | ( | string | *tag*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *name*, |
|  |  | string | *type*, |
|  |  | float | *radius* = 5f ) |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a7a33f5be8e3ef2e17b7f157647b47ab0)AddGenericMarker() [2/3]
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.AddGenericMarker | ( | [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *name*, |
|  |  | string | *type*, |
|  |  | float | *radius* = 5f ) |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a7a9f005d4dbb51347a82563ea0681e48)AddGenericMarker() [3/3]
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.AddGenericMarker | ( | [StealthAreaUsePoint](class_sand_box_1_1_objects_1_1_usables_1_1_stealth_area_use_point.html) | *stealthAreaUsePoint* | ) |  |

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a677e47ac11695ad98d5887bca3ba82bb)OnMissionExitRequested
----------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [MissionExitDelegate](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a0628f6609c76d55fb0f043e5043ba0fa) SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.OnMissionExitRequested = null |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#afe704d63e1b26c9f216810ea6dd9bc05)HiddenEntranceTag
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.HiddenEntranceTag = "teleport\_1" | | static |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a0e04a50782868cee31a99d9772aeec79)HiddenExitTag
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.HiddenExitTag = "teleport\_2" | | static |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a7e8c667b0743d95d14b8386e902ab1c5)CastleGateEntranceTag
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.CastleGateEntranceTag = "inner\_gate" | | static |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#ad9afd888f2ae38f8a512e85ae8d38147)NormalState
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.NormalState = "mission\_state" | | static |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a4e5a5f1f2736ed151ee8f5bf1aa63bac)AmbushState
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.AmbushState = "ambush\_state" | | static |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a1290be32214a26ad4c5145e6976db434)BattleState
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.BattleState = "battle\_state" | | static |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#aed09ff3eb77125d5706b07cf879a32f5)FinalState
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.FinalState = "final\_state" | | static |

Property Documentation
----------------------

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a72d595b6f6cd9e87321949c423c8d3ee)PermanentStealthZone
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [StealthZone](class_sand_box_1_1_objects_1_1_stealth_zone.html) SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.PermanentStealthZone | | get |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a41f9a4f80def7108e2976e589898908e)AmbushZone
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [StealthZone](class_sand_box_1_1_objects_1_1_stealth_zone.html) SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.AmbushZone | | get |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a291a2f82d9f3e1bd632c51e137a8fefa)CurrentSceneState
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SceneState](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic_1_1_scene_state.html) SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.CurrentSceneState | | get |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#ac277f295346c5da3aaf23014b98c4afb)CastleGate
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | CastleGate SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.CastleGate | | get |

Event Documentation
-------------------

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#a3c265f323df5a2798e1440891665faee)OnFadeOut
---------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<float, float, float> SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.OnFadeOut |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_mission_logic.html#aa886d2054d5b7624faf15cde9110b262)OnMissionObjectUsed
-------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html)> SandBox.ClaimantQuests.BattaniaClaimantQuestMissionLogic.OnMissionObjectUsed |

