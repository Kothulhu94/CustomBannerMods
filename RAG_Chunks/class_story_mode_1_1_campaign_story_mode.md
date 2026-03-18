--- SOURCE: class_story_mode_1_1_campaign_story_mode.html ---

StoryMode.CampaignStoryMode Class ReferenceInherits [TaleWorlds.CampaignSystem.Campaign](class_tale_worlds_1_1_campaign_system_1_1_campaign.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [CampaignStoryMode](class_story_mode_1_1_campaign_story_mode.html#a72f26165407190de6d896039397b0242) ([CampaignGameMode](namespace_tale_worlds_1_1_campaign_system.html#a86d7fcfdd4ea726877c5f94e8eb8ef75) gameMode) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.Campaign](class_tale_worlds_1_1_campaign_system_1_1_campaign.html) | |
| float | [GetAverageDistanceBetweenClosestTwoTownsWithNavigationType](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#af2c9b70811a8f3e31e0231756b59a531) ([MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) navigationType) |
|  | [Campaign](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a916bbf9d6f91f3a7d3c69931291869a3) ([CampaignGameMode](namespace_tale_worlds_1_1_campaign_system.html#a86d7fcfdd4ea726877c5f94e8eb8ef75) gameMode) |
| void | [AddCustomManager< T >](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a887cb46bd900e0a7250dc2e4291ea5f1) () |
| T | [GetCustomManager< T >](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#aa44c42ddde8020ad0a945f6d30f03a1a) () |
| void | [InitializeMainParty](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a59817d23a1103f0818f167693a4567fe) () |
| void | [WaitAsyncTasks](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a36d6bb1372de840342beca896921af79) () |
| [CampaignTimeControlMode](namespace_tale_worlds_1_1_campaign_system.html#ab32ec2efa5ffa8984dc1c6788caa28cc) | [GetSimplifiedTimeControlMode](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a7af2001b12a2995af0320ed1e82536b7) () |
| void | [OnGameOver](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a630eb93a1cb107576b12e8a9adcd427f) () |
| void | [SetTimeSpeed](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#afcc8c95322c984d0a2c4d131de571ab8) (int speed) |
| TComponent | [GetEntityComponent< TComponent >](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a94859ec710b8235f282fc42660abc184) () |
| TComponent | [AddEntityComponent< TComponent >](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a07d0310010555c056bf845937fed3117) () |
| void | [RemoveEntityComponent< TComponent >](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a0558960c17b424732dd89d25ed73f26e) () |
| void | [RemoveEntityComponent< TComponent >](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a52b593444c786d03b56e71b000b5a639) (TComponent component) |
| List< TComponent > | [GetComponents< TComponent >](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a56f28a2333eb590df7c82f8866651353) () |
| T | [GetCampaignBehavior< T >](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#ae5d5275e815997dc09635a0e3ff0efa9) () |
| IEnumerable< T > | [GetCampaignBehaviors< T >](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a0845fdb5f0cc79c493a1f3c1f42e03e9) () |
| void | [AddCampaignBehaviorManager](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a705c418aaa059aba1fd6a83e01420bca) ([ICampaignBehaviorManager](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior_manager.html) manager) |
| override void | [OnDestroy](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#adf212c8d2452543fe71870ce158ebcff) () |
| void | [InitializeSinglePlayerReferences](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a2983f13c274abb2b6bf1895afd2668df) () |
| void | [InitializeGamePlayReferences](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a62fed57ac6eca3e1b8f36ef1170ec2da) () |
| void | [SetLoadingParameters](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a54e5ec14af602f2c2346108f710933fd) ([GameLoadingType](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a9dfcac454a59bfcb98fea108f67ea1a3) gameLoadingType) |
| void | [AddCampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a624017004989d3fb5f0ad96fcf59c7e5) ([CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html) receiver) |
| override void | [OnMissionIsStarting](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#ab3698e6d810d91ac02e6d68bca491554) (string missionName, [MissionInitializerRecord](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html) rec) |
| override void | [InitializeParameters](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a24b88f764a51cc91846bffda6d627d58) () |
| void | [SetTimeControlModeLock](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a4752620dc4915fea429cab1740bddc35) (bool isLocked) |
| void | [OnPlayerCharacterChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a036ff38a8da7667aa3c4c5d6e67ad872) (out bool isMainPartyChanged) |
| void | [SetPlayerFormationPreference](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a0bb59564f2e1a21d8a31946caa2f57d3) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) formation) |
| override void | [OnStateChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a99169df6340cc8ab05439ce4926ea734) ([Core.GameState](class_tale_worlds_1_1_core_1_1_game_state.html) oldState) |
| void | [UnlockFigurehead](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a68ed4515915544b937d7b3c1474246fc) ([Figurehead](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_figurehead.html) figurehead) |
| Public Member Functions inherited from [TaleWorlds.Core.GameType](class_tale_worlds_1_1_core_1_1_game_type.html) | |
|  | [GameType](class_tale_worlds_1_1_core_1_1_game_type.html#a1672ec9ec9bcf5f37ad0f3a1d7abed74) () |
| void | [OnStateChanged](class_tale_worlds_1_1_core_1_1_game_type.html#a0f97febd2cd7948e5a1c5c1f9718be2f) ([GameState](class_tale_worlds_1_1_core_1_1_game_state.html) oldState) |
| bool | [DoLoadingForGameType](class_tale_worlds_1_1_core_1_1_game_type.html#ae363131cec92ccb6b0bfef161301f9b1) () |
| void | [OnDestroy](class_tale_worlds_1_1_core_1_1_game_type.html#aafaef391218a6cfe3f9fb98f2f9a638e) () |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [BeforeRegisterTypes](class_story_mode_1_1_campaign_story_mode.html#af392e732aa115a2a9a87f37a597ce177) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager) |
| override void | [DoLoadingForGameType](class_story_mode_1_1_campaign_story_mode.html#a8b2af3a235de621bffa491f108318f4c) ([GameTypeLoadingStates](namespace_tale_worlds_1_1_core.html#aa5c6ef1ec27a8a2faeb27e9349c49a1b) gameTypeLoadingState, out [GameTypeLoadingStates](namespace_tale_worlds_1_1_core.html#aa5c6ef1ec27a8a2faeb27e9349c49a1b) nextState) |
| Protected Member Functions inherited from [TaleWorlds.CampaignSystem.Campaign](class_tale_worlds_1_1_campaign_system_1_1_campaign.html) | |
| override void | [OnInitialize](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a7e4663c81994e2850a743cb059881f45) () |
| override void | [BeforeRegisterTypes](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a59cbc7b6102b5eeee26b33287f871791) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager) |
| override void | [OnRegisterTypes](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a0fe5daddc37456ab46fe4ae97a8b016a) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager) |
| override void | [DoLoadingForGameType](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#adeada78ee946bedf4fc70293400ecc6e) ([GameTypeLoadingStates](namespace_tale_worlds_1_1_core.html#aa5c6ef1ec27a8a2faeb27e9349c49a1b) gameTypeLoadingState, out [GameTypeLoadingStates](namespace_tale_worlds_1_1_core.html#aa5c6ef1ec27a8a2faeb27e9349c49a1b) nextState) |
| Protected Member Functions inherited from [TaleWorlds.Core.GameType](class_tale_worlds_1_1_core_1_1_game_type.html) | |
| void | [DoLoadingForGameType](class_tale_worlds_1_1_core_1_1_game_type.html#ab2ed65bb4555655d8f3b4a5afe1530f7) ([GameTypeLoadingStates](namespace_tale_worlds_1_1_core.html#aa5c6ef1ec27a8a2faeb27e9349c49a1b) gameTypeLoadingState, out [GameTypeLoadingStates](namespace_tale_worlds_1_1_core.html#aa5c6ef1ec27a8a2faeb27e9349c49a1b) nextState) |

|  |  |
| --- | --- |
| Properties | |
| [StoryModeManager](class_story_mode_1_1_story_mode_manager.html) | [StoryMode](class_story_mode_1_1_campaign_story_mode.html#add56905eae2c88a8bb0830e1b1e23691) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.Campaign](class_tale_worlds_1_1_campaign_system_1_1_campaign.html) | |
| static float | [MapDiagonal](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a32c99b160d3060708ccfa57831178bc9) `[get]` |
| static float | [MapDiagonalSquared](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a3e8a72eeadbab06802d05e9b926b4014) `[get]` |
| static [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [MapMinimumPosition](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#ab4372f008e1cb6adf14b3e8dc3fd4b22) `[get]` |
| static [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [MapMaximumPosition](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#af0f6ab3e2e93469bab0be10f96420132) `[get]` |
| static float | [MapMaximumHeight](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#aef97dce7495510ed2dfa4acc74ec01c6) `[get]` |
| float | [AverageWage](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a6c06b9e5abf217879ae3a49c84840403) `[get]` |
| string | [NewGameVersion](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#aa55fea5b89e30cad0d76d25f7518c785) `[get]` |
| MBReadOnlyList< string > | [PreviouslyUsedModules](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a10c060c99be2f4bd33412b86bfeb8621) `[get]` |
| MBReadOnlyList< string > | [UsedGameVersions](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#ab8216c7a7ec8711f48c0884ade5eabc1) `[get]` |
| bool | [EnabledCheatsBefore](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a3e4b639c23c98de241953d0729a3f51f) `[get, set]` |
| string | [PlatformID](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a35b3029544ee06271b3e7428564b83d0) `[get]` |
| string | [UniqueGameId](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#aa1842ebcba948b216091a8063656545c) `[get]` |
| SaveHandler | [SaveHandler](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#aa0080135023d7a689a07468d94d4078a) `[get]` |
| override bool | [SupportsSaving](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a1339e7b1d1fad41b839afe05ebd949a7) `[get]` |
| CampaignObjectManager | [CampaignObjectManager](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a882e1f5ca9c2c31b10ffbfb7ef430577) `[get]` |
| override bool | [IsDevelopment](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a5f04d3e3518aad1b0178a4d9810436cc) `[get]` |
| bool | [IsCraftingEnabled](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a1766b6388c117ba0fefc985d4ae97bde) = true `[get, set]` |
| bool | [IsBannerEditorEnabled](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#ae274117eb74c3b044a9741b4ce50c24d) = true `[get, set]` |
| bool | [IsFaceGenEnabled](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a909aef9ada8afacf38468e3c23c9ba71) = true `[get, set]` |
| [ICampaignBehaviorManager](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior_manager.html) | [CampaignBehaviorManager](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a587401db6263665e185151085da88671) `[get]` |
| QuestManager | [QuestManager](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#ad8b9540ad1d140608bb9d0ad77f18fe8) `[get]` |
| IssueManager | [IssueManager](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a57813bbbcfec7e7488270f909cc87406) `[get]` |
| FactionManager | [FactionManager](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#aff48011fa23eb37a5b4bcafc65cdc184) `[get]` |
| CharacterRelationManager | [CharacterRelationManager](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#aa2a7a998ca9048782dca4e6b0fd3aa4a) `[get]` |
| Romance | [Romance](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a08c9e8f3d7c8ddc16ccd62588490e8f7) `[get]` |
| PlayerCaptivity | [PlayerCaptivity](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#af129dd68f6c726848a36a913ecc5bad5) `[get]` |
| ICampaignMissionManager | [CampaignMissionManager](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#aeec1117d2f5b57bcd75fea2103c0842e) `[get, set]` |
| [ISkillLevelingManager](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html) | [SkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a16e7c5452a07fec48ab6b3a71e558c02) `[get, set]` |
| [IMapSceneCreator](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene_creator.html) | [MapSceneCreator](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#ab75d831cab6544661b4e77dcae760e07) `[get, set]` |
| override bool | [IsInventoryAccessibleAtMission](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a25df8a0de11a9b039ae467a322de6923) `[get]` |
| GameMenuCallbackManager | [GameMenuCallbackManager](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a0a8bf286160a5faf6f8dd7243c8b012f) `[get]` |
| VisualCreator | [VisualCreator](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a21149ff49ef2d906dd7bc8a01f7da020) `[get, set]` |
| MapStateData | [MapStateData](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#ab8650bf5e6c4b9264f9e6c540393b773) `[get]` |
| DefaultPerks | [DefaultPerks](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a508f765b94708db30a5af36e03a6210f) `[get]` |
| DefaultTraits | [DefaultTraits](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#aaf9d1ab0f8283571aa85e19ca9a0a4b0) `[get]` |
| DefaultPolicies | [DefaultPolicies](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a2869d39b08f5004353c9c824ea65dddd) `[get]` |
| DefaultBuildingTypes | [DefaultBuildingTypes](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a6af8b31ebcb05739663528851700db29) `[get]` |
| DefaultIssueEffects | [DefaultIssueEffects](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a3edf4281a3814bcb2022d79c5ba8159e) `[get]` |
| DefaultItems | [DefaultItems](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a1cf7fa11d5091af81bf1e7aa7b56d14a) `[get]` |
| DefaultFigureheads | [DefaultFigureheads](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a7f9f45bb072b6490698f1f095a81c0a9) `[get]` |
| DefaultSiegeStrategies | [DefaultSiegeStrategies](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a1d2388414fb245ffa2d287827a8909f0) `[get]` |
| DefaultSkillEffects | [DefaultSkillEffects](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a2d77516393558d10a73b3e0b48a75d29) `[get]` |
| DefaultVillageTypes | [DefaultVillageTypes](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#adafc3da15426de38b01e4700cda67e75) `[get]` |
| [DefaultCulturalFeats](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_cultural_feats.html) | [DefaultFeats](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#ab311fcabf6afeb7068857952c695bd9c) `[get]` |
| float | [EstimatedMaximumLordPartySpeedExceptPlayer](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a8c9cf15e7f0aa9e2065e3c4d3961430d) `[get, set]` |
| float | [EstimatedAverageLordPartySpeed](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a5bc8cb0e3d6c19c24c092763c442f09a) `[get, set]` |
| float | [EstimatedAverageCaravanPartySpeed](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a689e37a836c2bb82f7b253a5d64835e2) `[get, set]` |
| float | [EstimatedAverageVillagerPartySpeed](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a39fdfaf6649276039fa6d2a112519bd4) `[get, set]` |
| float | [EstimatedAverageBanditPartySpeed](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a61e83e67aa7c23af3c67e1f2c6a5a7e3) `[get, set]` |
| float | [EstimatedAverageLordPartyNavalSpeed](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#ace8875adb5efb6fd61628ffae692f690) `[get, set]` |
| float | [EstimatedAverageCaravanPartyNavalSpeed](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a009e7e12feb58dd5c462ec026ecf33b9) `[get, set]` |
| float | [EstimatedAverageVillagerPartyNavalSpeed](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a478083cafa8fb477f0bd81a8d3864f4e) `[get, set]` |
| float | [EstimatedAverageBanditPartyNavalSpeed](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#afdfb3c46736e5d46fce6b0b8cdd69edc) `[get, set]` |
| bool | [TimeControlModeLock](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a8ff3344da157be7349bb60c7d9d0f841) `[get]` |
| [CampaignTimeControlMode](namespace_tale_worlds_1_1_campaign_system.html#ab32ec2efa5ffa8984dc1c6788caa28cc) | [TimeControlMode](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a3df01211506c1328511343ee76739d6c) `[get, set]` |
| bool | [IsMapTooltipLongForm](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#afe9aed872f9835b04441b7c4e7cd16df) `[get, set]` |
| float | [SpeedUpMultiplier](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#af826e541a3b0202de8c65401ee903329) = 4.0f `[get, set]` |
| float | [CampaignDt](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#aa8d137c57e22795a364dbee686788daf) `[get]` |
| bool | [TrueSight](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a739c2fb9636d68755a9ba70f959d8cac) `[get, set]` |
| static [Campaign](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a916bbf9d6f91f3a7d3c69931291869a3) | [Current](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a08f714d304f89d74b28d36fb6e4259ae) `[get]` |
| [CampaignGameMode](namespace_tale_worlds_1_1_campaign_system.html#a86d7fcfdd4ea726877c5f94e8eb8ef75) | [GameMode](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a8e3c4a33ce89c9e7102a08abeed6550c) `[get]` |
| float | [PlayerProgress](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a5245218b423877cb40c878cac1402d91) `[get]` |
| GameMenuManager | [GameMenuManager](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#ad98be0800eba874f6ef2d36d42278b91) `[get]` |
| [GameModels](class_tale_worlds_1_1_campaign_system_1_1_game_models.html) | [Models](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a2c5c21d86a0ba082f999d4f76ec1f6ac) `[get]` |
| SandBoxManager | [SandBoxManager](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a9a9fa519e3d693b5d0f0f54b922f7c5a) `[get]` |
| [GameLoadingType](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a9dfcac454a59bfcb98fea108f67ea1a3) | [CampaignGameLoadingType](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#adbfef8b304b73d2b436e57e03f020bb3) `[get]` |
| SiegeEventManager | [SiegeEventManager](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#ac365025bef36c5de5bb90e933555b04a) `[get]` |
| MapEventManager | [MapEventManager](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#ad2fe59bacdf9f3d0ccbd9eb295e2ca05) `[get]` |
| MapMarkerManager | [MapMarkerManager](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#ad3401d5e6014e27df2d23ab0d85fd53b) `[get]` |
| [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) | [CurrentMenuContext](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#af9518ec3fc8445c633f9df20e7692b32) `[get]` |
| bool | [IsMainPartyWaiting](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#ae5cb61f5db92f402b927253857704729) `[get]` |
| [IMapScene](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html) | [MapSceneWrapper](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a993f48c62d851438d2ea982b4dc86445) `[get]` |
| PlayerEncounter | [PlayerEncounter](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#af8a8e5657b9ef16be6dc2d050e08a688) `[get]` |
| BarterManager | [BarterManager](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#af13cb5ffd276faea8a185101d76495c0) `[get]` |
| bool | [IsMainHeroDisguised](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#abfa6669769d401ca2eeb8689387d632b) `[get, set]` |
| [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) | [DeadBattleEquipment](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a9efa6caf28a170baf146a00c8d2669e6) `[get, set]` |
| [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) | [DeadCivilianEquipment](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a3e6e70b1d58c118a2126b7221cf3bb60) `[get, set]` |
| [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) | [DefaultStealthEquipment](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a14f5a594be9704dbd4858efb0f2de041) `[get]` |
| static float | [CurrentTime](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a57086e62a40578a99bd32131f9c838c2) `[get]` |
|  | DEPRECATED! Do not use! Time should be held as [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html). Current time is simply [CampaignTime.Now](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a7f2a79d217c196a3d8a1848cd91a98af). |
| MBReadOnlyList< [CampaignEntityComponent](class_tale_worlds_1_1_campaign_system_1_1_campaign_entity_component.html) > | [CampaignEntityComponents](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a06cfab340f48e85446e3e293960a8672) `[get]` |
| MBReadOnlyList< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [AliveHeroes](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a8740f76fd844a9321cb151fca4f704f7) `[get]` |
| MBReadOnlyList< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [DeadOrDisabledHeroes](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#ab4f1e26fc3fb66d2c3950990a6f15d5b) `[get]` |
| MBReadOnlyList< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | [MobileParties](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a16d3a0061adb8c78819e4897beabe481) `[get]` |
| MBReadOnlyList< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | [CaravanParties](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a28140a50c8c861816ee977ae5325dfc9) `[get]` |
| MBReadOnlyList< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | [PatrolParties](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#ad8e8c53266bc4b335ea3f83ad2b3ed78) `[get]` |
| MBReadOnlyList< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | [VillagerParties](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a7fff57d5888bf4e61fb1a2c5732deec1) `[get]` |
| MBReadOnlyList< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | [MilitiaParties](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a7a21e302220bdf911fb0d9b6a6691d57) `[get]` |
| MBReadOnlyList< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | [GarrisonParties](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a86f515e6426978c95313497021ece478) `[get]` |
| MBReadOnlyList< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | [CustomParties](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a304ae24c44f11d8ae2c7507b2773b0e0) `[get]` |
| MBReadOnlyList< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | [LordParties](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#ad67db33bb6f391ad11849f26fae26c34) `[get]` |
| MBReadOnlyList< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | [BanditParties](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a65cab3fc53e4362e955c7bc71db33da1) `[get]` |
| MBReadOnlyList< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | [PartiesWithoutPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a894e6692dd84073761e815626607d7fe) `[get]` |
| MBReadOnlyList< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) > | [Settlements](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a88b0abf1c64a1b7ab93755828b219bd1) `[get]` |
| IEnumerable< [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) > | [Factions](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a708e34dc9634698355f600b4f2582920) `[get]` |
| MBReadOnlyList< [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) > | [Kingdoms](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a9981a63ed79bad9d60d6498e3a2b8253) `[get]` |
| MBReadOnlyList< [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) > | [Clans](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a513db8af93314d3518a2120cc46edda3) `[get]` |
| MBReadOnlyList< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > | [Characters](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#aaef9c4f31584098a1f0fae2a63592dca) `[get]` |
| MBReadOnlyList< [WorkshopType](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html) > | [Workshops](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a8305c3c5dbe0c7e2d0a5dd59f514430f) `[get]` |
| MBReadOnlyList< [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) > | [ItemModifiers](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#ad12e318bfd5a3471f0983172b54b470a) `[get]` |
| MBReadOnlyList< [ItemModifierGroup](class_tale_worlds_1_1_core_1_1_item_modifier_group.html) > | [ItemModifierGroups](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a3550758ff24550f4efb58c9a22c483b4) `[get]` |
| MBReadOnlyList< [Concept](class_tale_worlds_1_1_campaign_system_1_1_concept.html) > | [Concepts](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a994c9921a018ff260f776646d53ccd6b) `[get]` |
| [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | [MainParty](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a301ddfe206d5797ef0a06f1b49352e72) `[get]` |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | [CameraFollowParty](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a0f93b18a7caf5f2a7b217e7822bb34ea) `[get, set]` |
| CampaignInformationManager | [CampaignInformationManager](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a06524ff84804aa5f1164a56e23392aa3) `[get, set]` |
| VisualTrackerManager | [VisualTrackerManager](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#ac4a66358269ea4b18e736df6f2eed641) `[get, set]` |
| LogEntryHistory | [LogEntryHistory](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a8f88ec8b7bdd763f6c5b6137bbdaa287) `[get]` |
| EncyclopediaManager | [EncyclopediaManager](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#aef2900f0de5383513953ad7b0f930ad4) `[get]` |
| ConversationManager | [ConversationManager](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a0b4202d38ba42d3dca9da8083103ce68) `[get]` |
| bool | [IsDay](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#afff37b1db5b4cb109a8ca7e55845c059) `[get]` |
| bool | [IsNight](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#ae288e9ccc76963754149c09d3ae1d516) `[get]` |
| override bool | [IsPartyWindowAccessibleAtMission](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a445f526c9c5c9a6174e9ed641debec4f) `[get]` |
| PropertyOwner< [PropertyObject](class_tale_worlds_1_1_core_1_1_property_object.html) > | [PlayerTraitDeveloper](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a3f20e3f83dae5ebb58d2508b5b05dd02) `[get]` |
| Properties inherited from [TaleWorlds.Core.GameType](class_tale_worlds_1_1_core_1_1_game_type.html) | |
| virtual bool | [SupportsSaving](class_tale_worlds_1_1_core_1_1_game_type.html#ab73062dfcd7f1ccfc2d3e6ca43e2c182) `[get]` |
| [Game](class_tale_worlds_1_1_core_1_1_game.html) | [CurrentGame](class_tale_worlds_1_1_core_1_1_game_type.html#a419314df916e46484ef1af7c3a3c22d0) `[get]` |
| [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | [ObjectManager](class_tale_worlds_1_1_core_1_1_game_type.html#a1572f7b5db1d31f8addf326966bf77aa) `[get]` |
| [GameManagerBase](class_tale_worlds_1_1_core_1_1_game_manager_base.html) | [GameManager](class_tale_worlds_1_1_core_1_1_game_type.html#a72bf450c38b7a45f35f17c4b776e116d) `[get]` |
| virtual bool | [IsInventoryAccessibleAtMission](class_tale_worlds_1_1_core_1_1_game_type.html#a18d1dba029ee637b3662851a9d269547) `[get]` |
| virtual bool | [IsQuestScreenAccessibleAtMission](class_tale_worlds_1_1_core_1_1_game_type.html#a621d8736007143f0322110b724fd08c5) `[get]` |
| virtual bool | [IsCharacterWindowAccessibleAtMission](class_tale_worlds_1_1_core_1_1_game_type.html#a956ec31fee5e29528bf3546dbcd8f890) `[get]` |
| virtual bool | [IsPartyWindowAccessibleAtMission](class_tale_worlds_1_1_core_1_1_game_type.html#a5a4a147ea5fe579d3a0ea8200ea3198c) `[get]` |
| virtual bool | [IsKingdomWindowAccessibleAtMission](class_tale_worlds_1_1_core_1_1_game_type.html#af74a1c6f8c31334f693f629ad87ae714) `[get]` |
| virtual bool | [IsClanWindowAccessibleAtMission](class_tale_worlds_1_1_core_1_1_game_type.html#adf4205d80eb103ddf0cbf7b29ac1d7c4) `[get]` |
| virtual bool | [IsEncyclopediaWindowAccessibleAtMission](class_tale_worlds_1_1_core_1_1_game_type.html#a5a39a1b9bb0fb0f435c74c6430aa4b87) `[get]` |
| virtual bool | [IsBannerWindowAccessibleAtMission](class_tale_worlds_1_1_core_1_1_game_type.html#af489363161afe3b6a9a438fdac6a815c) `[get]` |
| virtual bool | [IsDevelopment](class_tale_worlds_1_1_core_1_1_game_type.html#a6410ea27467258f51150641c3e86b227) `[get]` |
| virtual bool | [IsCoreOnlyGameMode](class_tale_worlds_1_1_core_1_1_game_type.html#ac83d81edf86ea3492876cb01d00e9992) `[get]` |
| virtual bool | [RequiresTutorial](class_tale_worlds_1_1_core_1_1_game_type.html#a02e1689f8ee71bbb4e9d1bf0821e8a4a) `[get]` |
| virtual string | [GameTypeStringId](class_tale_worlds_1_1_core_1_1_game_type.html#a5a4d23c085eeb77de969d80d4f146fb0) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Types inherited from [TaleWorlds.CampaignSystem.Campaign](class_tale_worlds_1_1_campaign_system_1_1_campaign.html) | |
| enum | [PartyRestFlags](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a728eef2a70c65f7fb7b1e61f6ca53810) : uint {     [None](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a728eef2a70c65f7fb7b1e61f6ca53810a6adf97f83acf6453d4a6a4b1070f3754) = 0x00000000 ,     [SafeMode](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a728eef2a70c65f7fb7b1e61f6ca53810abe9942a71fc5150a76b9f61f281de1b9) = 0x00000001   } |
| enum | [GameLoadingType](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a9dfcac454a59bfcb98fea108f67ea1a3) {     [Tutorial](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a9dfcac454a59bfcb98fea108f67ea1a3a368fe771261fcb18f7988833c9294a20) ,     [NewCampaign](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a9dfcac454a59bfcb98fea108f67ea1a3adad51a64511d5dfbf5e85ef7e3c6450e) ,     [SavedCampaign](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a9dfcac454a59bfcb98fea108f67ea1a3afff9631d569ba80d520b142b8a690a2b) ,     [Editor](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a9dfcac454a59bfcb98fea108f67ea1a3a344a7f427fb765610ef96eb7bce95257)   } |
| Static Public Member Functions inherited from [TaleWorlds.CampaignSystem.Campaign](class_tale_worlds_1_1_campaign_system_1_1_campaign.html) | |
| static void | [LateAITick](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#ac6c612f5d21269b83cef36b6245c7de1) () |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.Campaign](class_tale_worlds_1_1_campaign_system_1_1_campaign.html) | |
| [ITask](interface_tale_worlds_1_1_library_1_1_i_task.html) | [CampaignLateAITickTask](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#ab66b8cda64528a6e5e1b47209576cb84) |
| readonly [CampaignOptions](class_tale_worlds_1_1_campaign_system_1_1_campaign_options.html) | [Options](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#ade5068dbe69a8bbbbe5571db534c7b2e) |
| MBReadOnlyDictionary< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) > | [PlayerFormationPreferences](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a90ee1023f2ebf67a50ee8b7c9e51920e) |
| [ITournamentManager](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html) | [TournamentManager](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a379f92f7a4f4a01366b711e0c19ecb05) |
| float | [MinSettlementX](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a07deaec454be67cea3481faa8b3737c6) |
| float | [MaxSettlementX](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a30cda3072fda9c48ad067e8e518f8da0) |
| float | [MinSettlementY](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a60d681e347248eb5b7365d38e51708d9) |
| float | [MaxSettlementY](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#ae884735d901613c8db4e2997b3423a63) |
| bool | [IsSinglePlayerReferencesInitialized](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a2e9171f9ce6f2ad74546ee1d060631e2) |
| [CampaignTimeControlMode](namespace_tale_worlds_1_1_campaign_system.html#ab32ec2efa5ffa8984dc1c6788caa28cc) | [LastTimeControlMode](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a4c658e4258f6a27bc7a5d145854d0511) = [CampaignTimeControlMode.UnstoppablePlay](namespace_tale_worlds_1_1_campaign_system.html#ab32ec2efa5ffa8984dc1c6788caa28cca3d5da9752eec36f8233ac0618a7e668c) |
| bool | [GameStarted](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#ae8d7997f2ffcf04241e1b0b6652ad1d8) = false |
| [ConversationContext](namespace_tale_worlds_1_1_campaign_system.html#aed5ce79a4b69fd07e3318a1914f8597d) | [CurrentConversationContext](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a72f8235df098511481d8043c986268c2) |
| int | [CurrentTickCount](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#aa25e44e3b486ee802de5807ae71c1c48) = 0 |
| int | [MainHeroIllDays](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#ac2885828d50794e753a4d21b4197c13f) = -1 |
| int | [DefaultWeatherNodeDimension](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#aee9017466cb11599ab09fd85a81f32fa) = 0 |
| List< [Figurehead](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_figurehead.html) > | [UnlockedFigureheadsByMainHero](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#ae79648b3c4bd795dd72e2ac346c4d344) = new List<[Figurehead](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_figurehead.html)>() |
| KingdomManager | [KingdomManager](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a42aae735c9bc166a3bb0bf75a0e6d56b) |
| Static Public Attributes inherited from [TaleWorlds.CampaignSystem.Campaign](class_tale_worlds_1_1_campaign_system_1_1_campaign.html) | |
| const float | [ConfigTimeMultiplier](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a3b10e9dc1e08ac511037d8b3b18cc5b9) = 0.25f |
| static int | [PlayerRegionSwitchCostFromLandToSea](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#ad9c9c162278209fdd9bff7eef6062dc5) |
| static int | [PathFindingMaxCostLimit](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a72de180889c43d6837163b51a101df9c) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_story_mode_1_1_campaign_story_mode.html#a72f26165407190de6d896039397b0242)CampaignStoryMode()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| StoryMode.CampaignStoryMode.CampaignStoryMode | ( | [CampaignGameMode](namespace_tale_worlds_1_1_campaign_system.html#a86d7fcfdd4ea726877c5f94e8eb8ef75) | *gameMode* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_story_mode_1_1_campaign_story_mode.html#af392e732aa115a2a9a87f37a597ce177)BeforeRegisterTypes()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void StoryMode.CampaignStoryMode.BeforeRegisterTypes | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager* | ) |  | | protected |

[◆](class_story_mode_1_1_campaign_story_mode.html#a8b2af3a235de621bffa491f108318f4c)DoLoadingForGameType()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void StoryMode.CampaignStoryMode.DoLoadingForGameType | ( | [GameTypeLoadingStates](namespace_tale_worlds_1_1_core.html#aa5c6ef1ec27a8a2faeb27e9349c49a1b) | *gameTypeLoadingState*, | |  |  | out [GameTypeLoadingStates](namespace_tale_worlds_1_1_core.html#aa5c6ef1ec27a8a2faeb27e9349c49a1b) | *nextState* ) | | protected |

Property Documentation
----------------------

[◆](class_story_mode_1_1_campaign_story_mode.html#add56905eae2c88a8bb0830e1b1e23691)StoryMode
---------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [StoryModeManager](class_story_mode_1_1_story_mode_manager.html) StoryMode.CampaignStoryMode.StoryMode | | get |

