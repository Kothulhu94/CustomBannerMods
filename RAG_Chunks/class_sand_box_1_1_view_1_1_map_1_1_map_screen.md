--- SOURCE: class_sand_box_1_1_view_1_1_map_1_1_map_screen.html ---

SandBox.View.Map.MapScreen Class ReferenceInherits ScreenBase, [TaleWorlds.CampaignSystem.GameState.IMapStateHandler](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html), [TaleWorlds.Core.IGameStateListener](interface_tale_worlds_1_1_core_1_1_i_game_state_listener.html), and [TaleWorlds.MountAndBlade.View.IChatLogHandlerScreen](interface_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_i_chat_log_handler_screen.html).

|  |  |
| --- | --- |
| Classes | |
| struct | [DecalEntity](struct_sand_box_1_1_view_1_1_map_1_1_map_screen_1_1_decal_entity.html) |
| class | [MainMapCameraMoveEvent](class_sand_box_1_1_view_1_1_map_1_1_map_screen_1_1_main_map_camera_move_event.html) |

|  |  |
| --- | --- |
| Public Types | |
| enum | [MapOverlayType](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a0fd29fc360d3191398dd0d987346e444) {     [None](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a0fd29fc360d3191398dd0d987346e444a6adf97f83acf6453d4a6a4b1070f3754) ,     [Army](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a0fd29fc360d3191398dd0d987346e444ab06662c1658f052b202f87a33fa00138)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MapScreen](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a7c49506e82203f67e51d711959f1ffd1) ([MapState](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a9c1fcdb36a14701881143163e02199d1) mapState) |
| void | [OnHoverMapEntity](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a3ff6c7162527b98335a1a5413c9468ba) ([MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) mapEntityVisual) |
| void | [RemoveMapTooltip](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#adf655eff20c625ef3bbbed95f7991cf7) () |
| void | [ClearGPUMemory](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#afa0ea79638d68f1d9d39ad00d29a2ddf) () |
| override void | [OnFocusChangeOnGameWindow](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a726db2fe9bcf0666f04b0be0452afbbe) (bool focusGained) |
| [MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html) | [AddMapView< T >](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a19227dcb6375aec6ef5833176fa75367) (params object[] parameters) |
| T | [GetMapView< T >](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a860da8df1e87d83ee227826f5c89329e) () |
| void | [RemoveMapView](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#aa356adf203ed004a1175d40e969089bb) ([MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html) mapView) |
| void | [AddEncounterOverlay](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a6350a4d068f23432951ed76e33eede70) (GameMenu.MenuOverlayType type) |
| void | [AddArmyOverlay](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a8f7e6694bf0f1c4545d90846ffdd438b) ([MapOverlayType](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a0fd29fc360d3191398dd0d987346e444) type) |
| void | [RemoveEncounterOverlay](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a8d11b5f61baf898d82a284d5f39db791) () |
| void | [RemoveArmyOverlay](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a844755b0964b98e738ff00163559f044) () |
| void | [CloseMarriageOfferPopup](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#adcbe65012988c79436619210b5bc6a50) () |
| void | [OnHourlyTick](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a710f2f861c6ea590ab5052587b03c308) () |
| void | [BeginParleyWith](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a4d76a87038d50a5b9c21ba9b102b4bfd) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| void | [SetMapScreenSceneDebugInfo](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a552b21d8f7271998ae5dc3fd77424cd5) (bool enabled) |
| void | [OnExit](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a500c4aabce041edd365897e5fdb18df7) () |
| void | [GetCursorIntersectionPoint](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a404283d5dda4cdee2880a2eec1716800) (ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) clippedMouseNear, ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) clippedMouseFar, out float closestDistanceSquared, out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) intersectionPoint, ref [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) currentFace, out bool isOnland, [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) excludedBodyFlags=BodyFlags.CommonFocusRayCastExcludeFlags) |
| void | [FastMoveCameraToPosition](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a0539c0226cd459b1738195709867bcb8) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) target) |
| void | [OnSiegeEngineFrameClick](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a632c04f5046f6b9421e118311f0f9558) ([MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) siegeFrame) |
| void | [OnFadeInAndOut](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a7f420949e57793e7d5536483d52ae1c0) (float fadeOutTime, float blackTime, float fadeInTime) |
| void | [SetIsMapCheatsActive](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a5ea9a1610d5049196292190d8bb68060) (bool isMapCheatsActive) |
| void | [SetIsInTownManagement](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a36833997d9c2bfb5aad92476d4891bdd) (bool isInTownManagement) |
| void | [SetIsInHideoutTroopManage](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a95d88711ac8f3017418d0f381dbee6e8) (bool isInHideoutTroopManage) |
| void | [SetIsInArmyManagement](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a81deb704ff6aaf259444042bd5df5292) (bool isInArmyManagement) |
| void | [SetIsOverlayContextMenuActive](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a00c87a1df4529bdafd871399f31b1e76) (bool isOverlayContextMenuEnabled) |
| void | [SetIsInRecruitment](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#acb0f5834a2d7b8bbd947737281612ca5) (bool isInRecruitment) |
| void | [SetIsBarExtended](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a3d93213eb89421aa7773fb7e3a6b3b48) (bool isBarExtended) |
| void | [SetIsMarriageOfferPopupActive](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#ae947b4929651fd3a36fe40f7137d4f3a) (bool isMarriageOfferPopupActive) |
| void | [SetIsInCampaignOptions](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#af53d2a49c3749f367d20187c67333396) (bool isInCampaignOptions) |
| void | [SetIsMapIncidentActive](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#aca319f431d43e2aaf65220be373f6f51) (bool isMapIncidentActive) |
| void | [SetMouseVisible](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a610b698b075da586495886404ce21ce1) (bool value) |
| void | [SetIsHeirSelectionPopupActive](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#afbcd2de7f08818b1601410ebc8a6dd9f) (bool isHeirSelectionPopupActive) |
| bool | [GetMouseVisible](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#ac1b588885cd139813aa60039c8d84380) () |
| void | [RestartAmbientSounds](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a5ffd6f375befc952de0826a156404a7c) () |
| void | [PauseAmbientSounds](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#aa0403cc3fb72fc75d5b1beb2898a1c27) () |
| [MBCampaignEvent](class_tale_worlds_1_1_campaign_system_1_1_m_b_campaign_event.html) | [CreatePeriodicUIEvent](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#aa968771b4b05c9ffc67ddd62e8361ecf) ([CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) triggerPeriod, [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) initialWait) |
| void | [DeletePeriodicUIEvent](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a11c252a237952f96f4e0c78616b7eb70) ([MBCampaignEvent](class_tale_worlds_1_1_campaign_system_1_1_m_b_campaign_event.html) campaignEvent) |
| void | [OpenOptions](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#abf2676023aab4df37b945cdc0d4adf13) () |
| void | [OpenEncyclopedia](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a4360799032d17b59fed832c6f83fd845) () |
| void | [OpenSaveLoad](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a4fc5c976bf7d51d9d8d001cf8c4d52cf) (bool isSaving) |
| void | [CloseEscapeMenu](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#ad1c176b832253e75a6f5a1a42b847b9a) () |
| void | [OpenEscapeMenu](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#aa90079b1564eb45cf0a05d010413066a) () |
| void | [CloseGameplayCheats](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a766e222642f666c6a13eaa25d6dfe421) () |
| void | [CloseCampaignOptions](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a059e66f38134f032c8888ddfa711d37f) () |
| void | [OpenInventory](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a8c9a0e80ded278f7ba9f3098a4750023) () |
| void | [OpenFacegenScreenAux](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#acafc546725f732630ad65ff3d0a1cfdc) () |
| bool | [IsCameraLockedToPlayerParty](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a814680010cf75a96ef7a0216baf2dad0) () |
| void | [FastMoveCameraToMainParty](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#ab824194cbaaf0de3c93dfddd59d06f7c) () |
| void | [ResetCamera](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a468c3d838cdfba79f3441db148c98feb) (bool resetDistance, bool teleportToMainParty) |
| void | [TeleportCameraToMainParty](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a9920557f7b12ef91c260733e912c338b) () |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly Dictionary< Tuple< [Material](class_tale_worlds_1_1_engine_1_1_material.html), [Banner](class_tale_worlds_1_1_core_1_1_banner.html) >, [Material](class_tale_worlds_1_1_engine_1_1_material.html) > | [CharacterBannerMaterialCache](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#ae1520a77706a7ea866158f06a0ca55b4) = new Dictionary<Tuple<[Material](class_tale_worlds_1_1_engine_1_1_material.html), [Banner](class_tale_worlds_1_1_core_1_1_banner.html)>, [Material](class_tale_worlds_1_1_engine_1_1_material.html)>() |
| [IMapTracksCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_map_tracks_campaign_behavior.html) | [MapTracksCampaignBehavior](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#af59f2810369791b0e48b435b698221d1) |
| bool | [TooltipHandlingDisabled](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#aa5639f3e4e41a9ad6b7f7133868e9ccb) = false |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static bool | [DisableVisualTicks](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a654b32cfd2eb49a6c06c213fd651d975) = false |
| const uint | [EnemyPartyDecalColor](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a6b26a59116e8bf031f21807bd604de2e) = 4292093218 |
| const uint | [AllyPartyDecalColor](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a0d459eb119230ca9c26bd1a4e18eeacc) = 4284183827 |
| const uint | [NeutralPartyDecalColor](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#ad76963b53e7aa04359599fc22f96eb1b) = 4291596077 |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnResume](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#aeb7acaaca4532b3aa947fffdb53b28b3) () |
| override void | [OnPause](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a24b836a8aad3520daefd0c4ab9be2041) () |
| override void | [OnActivate](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a0888555066add36e4df89fa77800fec5) () |
| override void | [OnDeactivate](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a48bc19685ffc115a9eb70db536b82d01) () |
| override void | [OnInitialize](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#afd6bd4c3f2384b094fa55d57f28a2c4d) () |
| override void | [OnFinalize](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a1ac743b71b9bbedc60b6a818177f5924) () |
| override void | [OnFrameTick](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#af5ca6bdb0862b156ae2d5e25c48bc027) (float dt) |
| override void | [OnPostFrameTick](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#ad3d481ebde1492370513e9b473f7f3f9) (float dt) |
| virtual bool | [TickNavigationInput](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a24154c49d6c71d0553e72a9859f53604) (float dt) |
| virtual [SPScoreboardVM](class_sand_box_1_1_view_model_collection_1_1_s_p_scoreboard_v_m.html) | [CreateSimulationScoreboardDatasource](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#acd2cd1239cf9552b5abe6f47df995e3f) ([BattleSimulation](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html) battleSimulation) |

|  |  |
| --- | --- |
| Properties | |
| [IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html) | [Input](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#aa582d9261e0f70d966d40c638b99c837) `[get]` |
| static [MapScreen](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a7c49506e82203f67e51d711959f1ffd1) | [Instance](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#ac0472a3b856ef2d2a8f2b61ce222b545) `[get]` |
| bool | [IsReady](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#aa1ae8408b4ababf4e0084cf1a895cab7) `[get]` |
| [INavigationHandler](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_handler.html) | [NavigationHandler](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a7809ba8d01eec3ae4dea268141485db3) `[get, set]` |
| [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) | [CurrentVisualOfTooltip](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#ad7495a13606cfd6c57cfde31106bcf98) `[get]` |
| [CampaignMapSiegePrefabEntityCache](class_sand_box_1_1_campaign_map_siege_prefab_entity_cache.html) | [PrefabEntityCache](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a597a5f51e39d80c7e808a8be793705cd) `[get]` |
| [MapEncyclopediaView](class_sand_box_1_1_view_1_1_map_1_1_map_encyclopedia_view.html) | [EncyclopediaScreenManager](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a076a69ed1dbf179a2216f50b398cac87) `[get]` |
| bool | [IsEscapeMenuOpened](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a8bb96028a3aceb32e9785f668d6a4d61) `[get]` |
| MapNotificationView | [MapNotificationView](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a361afea8d0453acf74630f47e98d83b3) `[get]` |
| Dictionary< Tuple< [Material](class_tale_worlds_1_1_engine_1_1_material.html), [Banner](class_tale_worlds_1_1_core_1_1_banner.html) >, [Material](class_tale_worlds_1_1_engine_1_1_material.html) > | [BannerTexturedMaterialCache](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#ad8590dda10d089c0c0cce7c2faeffee9) `[get]` |
| bool | [IsInMenu](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#ad27c5743f2629fef960b7b672137e1fa) `[get]` |
| SceneLayer | [SceneLayer](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a4882df70150de07e7169fee3964a4078) `[get]` |
| MapCameraView | [MapCameraView](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a3c6dbdd6804e5fbd2fb8383193ea4df2) `[get]` |
| bool | [MapSceneCursorActive](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a6df20e3ac2fdf71f095732575ef4b93e) `[get, set]` |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [ContourMaskEntity](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#aab1edbed9d27070aad86914c3f41956e) `[get]` |
| MapCursor | [MapCursor](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a996db20748898fc967dcc1c6bbbfd966) = new MapCursor() `[get]` |
| List< [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) > | [InactiveLightMeshes](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a047f72854a39bec15d00381c1ee05c63) `[get]` |
| List< [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) > | [ActiveLightMeshes](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a00a49b848a7190ac62686cf8442298b2) `[get]` |
| [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | [MapScene](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#af8cc8fe76204a33f6904e01d19140263) `[get]` |
| MapState | [MapState](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a9c1fcdb36a14701881143163e02199d1) `[get]` |
| bool | [IsInBattleSimulation](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#aa6f96f4fc6bc571359dee31e33e83d75) `[get]` |
| bool | [IsInTownManagement](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a156074af7f739fbf0e6d0aff8420cb7c) `[get]` |
| bool | [IsInHideoutTroopManage](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#ad5b33d34caae9f4782b782539f3b2a2f) `[get]` |
| bool | [IsInArmyManagement](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#ab005d0bd9c0154087a8e92800f460ea1) `[get]` |
| bool | [IsInRecruitment](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#aa152965c9430c451448f164f4fe2c4db) `[get]` |
| bool | [IsBarExtended](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a396b5c77a2273c6d7f3c40e3974604d0) `[get]` |
| bool | [IsInCampaignOptions](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a500bf13abd249bc594526e6a27b56a07) `[get]` |
| bool | [IsMarriageOfferPopupActive](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a73c9e431eb9a588e7bb3e6f6ffe69aaa) `[get]` |
| bool | [IsMapCheatsActive](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a56ab8c3cc3a03f8c5e1a2c895d8030d3) `[get]` |
| bool | [IsMapIncidentActive](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a60cdd61af96fb3ef3bcb1cac18ef9c38) `[get]` |
| bool | [IsHeirSelectionPopupActive](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#aa811162bc59fd88f32bddac693f9a181) `[get]` |
| bool | [IsOverlayContextMenuEnabled](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#aa37b94babb457a29d21652aa3a25cb24) `[get]` |
| bool | [IsSoundOn](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a2591a7c21d2130de5ad880c21190771c) = true `[get]` |
| static Dictionary< UIntPtr, [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) > | [VisualsOfEntities](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#aabc101d01f2f07ff90560d62da18d701) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a0fd29fc360d3191398dd0d987346e444)MapOverlayType
--------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum SandBox.View.Map.MapScreen.MapOverlayType |

| Enumerator | |
| --- | --- |
| None |  |
| Army |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a7c49506e82203f67e51d711959f1ffd1)MapScreen()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| SandBox.View.Map.MapScreen.MapScreen | ( | [MapState](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a9c1fcdb36a14701881143163e02199d1) | *mapState* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a3ff6c7162527b98335a1a5413c9468ba)OnHoverMapEntity()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.OnHoverMapEntity | ( | [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) | *mapEntityVisual* | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#adf655eff20c625ef3bbbed95f7991cf7)RemoveMapTooltip()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.RemoveMapTooltip | ( |  | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#aeb7acaaca4532b3aa947fffdb53b28b3)OnResume()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.View.Map.MapScreen.OnResume | ( |  | ) |  | | protected |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a24b836a8aad3520daefd0c4ab9be2041)OnPause()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.View.Map.MapScreen.OnPause | ( |  | ) |  | | protected |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a0888555066add36e4df89fa77800fec5)OnActivate()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.View.Map.MapScreen.OnActivate | ( |  | ) |  | | protected |

Implements [TaleWorlds.Core.IGameStateListener](interface_tale_worlds_1_1_core_1_1_i_game_state_listener.html#aa8b05eeab9e1f4691b9ef1ac12a05b77).

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#afa0ea79638d68f1d9d39ad00d29a2ddf)ClearGPUMemory()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.ClearGPUMemory | ( |  | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a48bc19685ffc115a9eb70db536b82d01)OnDeactivate()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.View.Map.MapScreen.OnDeactivate | ( |  | ) |  | | protected |

Implements [TaleWorlds.Core.IGameStateListener](interface_tale_worlds_1_1_core_1_1_i_game_state_listener.html#a64ece7c9e2bec7a45b85be293166b6ef).

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a726db2fe9bcf0666f04b0be0452afbbe)OnFocusChangeOnGameWindow()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void SandBox.View.Map.MapScreen.OnFocusChangeOnGameWindow | ( | bool | *focusGained* | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a19227dcb6375aec6ef5833176fa75367)AddMapView< T >()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html) SandBox.View.Map.MapScreen.AddMapView< T > | ( | params object[] | *parameters* | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html)* |  |
    | *T* | : | *new()* |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a860da8df1e87d83ee227826f5c89329e)GetMapView< T >()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| T SandBox.View.Map.MapScreen.GetMapView< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html)* |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#aa356adf203ed004a1175d40e969089bb)RemoveMapView()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.RemoveMapView | ( | [MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html) | *mapView* | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a6350a4d068f23432951ed76e33eede70)AddEncounterOverlay()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.AddEncounterOverlay | ( | GameMenu.MenuOverlayType | *type* | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a8f7e6694bf0f1c4545d90846ffdd438b)AddArmyOverlay()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.AddArmyOverlay | ( | [MapOverlayType](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a0fd29fc360d3191398dd0d987346e444) | *type* | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a8d11b5f61baf898d82a284d5f39db791)RemoveEncounterOverlay()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.RemoveEncounterOverlay | ( |  | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a844755b0964b98e738ff00163559f044)RemoveArmyOverlay()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.RemoveArmyOverlay | ( |  | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#afd6bd4c3f2384b094fa55d57f28a2c4d)OnInitialize()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.View.Map.MapScreen.OnInitialize | ( |  | ) |  | | protected |

Implements [TaleWorlds.Core.IGameStateListener](interface_tale_worlds_1_1_core_1_1_i_game_state_listener.html#a8df8104360d9c66aedb341b13367b8e5).

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#adcbe65012988c79436619210b5bc6a50)CloseMarriageOfferPopup()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.CloseMarriageOfferPopup | ( |  | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a1ac743b71b9bbedc60b6a818177f5924)OnFinalize()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.View.Map.MapScreen.OnFinalize | ( |  | ) |  | | protected |

Implements [TaleWorlds.Core.IGameStateListener](interface_tale_worlds_1_1_core_1_1_i_game_state_listener.html#ac916ee3e48edbf09b47eacac07b5c574).

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a710f2f861c6ea590ab5052587b03c308)OnHourlyTick()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.OnHourlyTick | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.GameState.IMapStateHandler](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#ae5039a32bb1a20760e4051da25fa4427).

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a4d76a87038d50a5b9c21ba9b102b4bfd)BeginParleyWith()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.BeginParleyWith | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#af5ca6bdb0862b156ae2d5e25c48bc027)OnFrameTick()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.View.Map.MapScreen.OnFrameTick | ( | float | *dt* | ) |  | | protected |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#ad3d481ebde1492370513e9b473f7f3f9)OnPostFrameTick()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.View.Map.MapScreen.OnPostFrameTick | ( | float | *dt* | ) |  | | protected |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a552b21d8f7271998ae5dc3fd77424cd5)SetMapScreenSceneDebugInfo()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.SetMapScreenSceneDebugInfo | ( | bool | *enabled* | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a500c4aabce041edd365897e5fdb18df7)OnExit()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.OnExit | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.GameState.IMapStateHandler](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#a22b6bea6dbc2b4ea3bbb07b114c90a6e).

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a404283d5dda4cdee2880a2eec1716800)GetCursorIntersectionPoint()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.GetCursorIntersectionPoint | ( | ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *clippedMouseNear*, |
|  |  | ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *clippedMouseFar*, |
|  |  | out float | *closestDistanceSquared*, |
|  |  | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *intersectionPoint*, |
|  |  | ref [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | *currentFace*, |
|  |  | out bool | *isOnland*, |
|  |  | [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) | *excludedBodyFlags* = BodyFlags::CommonFocusRayCastExcludeFlags ) |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a0539c0226cd459b1738195709867bcb8)FastMoveCameraToPosition()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.FastMoveCameraToPosition | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *target* | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a632c04f5046f6b9421e118311f0f9558)OnSiegeEngineFrameClick()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.OnSiegeEngineFrameClick | ( | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *siegeFrame* | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a24154c49d6c71d0553e72a9859f53604)TickNavigationInput()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual bool SandBox.View.Map.MapScreen.TickNavigationInput | ( | float | *dt* | ) |  | | protectedvirtual |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#acd2cd1239cf9552b5abe6f47df995e3f)CreateSimulationScoreboardDatasource()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual [SPScoreboardVM](class_sand_box_1_1_view_model_collection_1_1_s_p_scoreboard_v_m.html) SandBox.View.Map.MapScreen.CreateSimulationScoreboardDatasource | ( | [BattleSimulation](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html) | *battleSimulation* | ) |  | | protectedvirtual |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a7f420949e57793e7d5536483d52ae1c0)OnFadeInAndOut()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.OnFadeInAndOut | ( | float | *fadeOutTime*, |
|  |  | float | *blackTime*, |
|  |  | float | *fadeInTime* ) |

Implements [TaleWorlds.CampaignSystem.GameState.IMapStateHandler](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#a4ebc3308c5717b092f2ff177f5d412fe).

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a5ea9a1610d5049196292190d8bb68060)SetIsMapCheatsActive()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.SetIsMapCheatsActive | ( | bool | *isMapCheatsActive* | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a36833997d9c2bfb5aad92476d4891bdd)SetIsInTownManagement()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.SetIsInTownManagement | ( | bool | *isInTownManagement* | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a95d88711ac8f3017418d0f381dbee6e8)SetIsInHideoutTroopManage()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.SetIsInHideoutTroopManage | ( | bool | *isInHideoutTroopManage* | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a81deb704ff6aaf259444042bd5df5292)SetIsInArmyManagement()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.SetIsInArmyManagement | ( | bool | *isInArmyManagement* | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a00c87a1df4529bdafd871399f31b1e76)SetIsOverlayContextMenuActive()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.SetIsOverlayContextMenuActive | ( | bool | *isOverlayContextMenuEnabled* | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#acb0f5834a2d7b8bbd947737281612ca5)SetIsInRecruitment()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.SetIsInRecruitment | ( | bool | *isInRecruitment* | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a3d93213eb89421aa7773fb7e3a6b3b48)SetIsBarExtended()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.SetIsBarExtended | ( | bool | *isBarExtended* | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#ae947b4929651fd3a36fe40f7137d4f3a)SetIsMarriageOfferPopupActive()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.SetIsMarriageOfferPopupActive | ( | bool | *isMarriageOfferPopupActive* | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#af53d2a49c3749f367d20187c67333396)SetIsInCampaignOptions()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.SetIsInCampaignOptions | ( | bool | *isInCampaignOptions* | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#aca319f431d43e2aaf65220be373f6f51)SetIsMapIncidentActive()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.SetIsMapIncidentActive | ( | bool | *isMapIncidentActive* | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a610b698b075da586495886404ce21ce1)SetMouseVisible()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.SetMouseVisible | ( | bool | *value* | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#afbcd2de7f08818b1601410ebc8a6dd9f)SetIsHeirSelectionPopupActive()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.SetIsHeirSelectionPopupActive | ( | bool | *isHeirSelectionPopupActive* | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#ac1b588885cd139813aa60039c8d84380)GetMouseVisible()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool SandBox.View.Map.MapScreen.GetMouseVisible | ( |  | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a5ffd6f375befc952de0826a156404a7c)RestartAmbientSounds()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.RestartAmbientSounds | ( |  | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#aa0403cc3fb72fc75d5b1beb2898a1c27)PauseAmbientSounds()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.PauseAmbientSounds | ( |  | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#aa968771b4b05c9ffc67ddd62e8361ecf)CreatePeriodicUIEvent()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [MBCampaignEvent](class_tale_worlds_1_1_campaign_system_1_1_m_b_campaign_event.html) SandBox.View.Map.MapScreen.CreatePeriodicUIEvent | ( | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | *triggerPeriod*, |
|  |  | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | *initialWait* ) |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a11c252a237952f96f4e0c78616b7eb70)DeletePeriodicUIEvent()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.DeletePeriodicUIEvent | ( | [MBCampaignEvent](class_tale_worlds_1_1_campaign_system_1_1_m_b_campaign_event.html) | *campaignEvent* | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#abf2676023aab4df37b945cdc0d4adf13)OpenOptions()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.OpenOptions | ( |  | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a4360799032d17b59fed832c6f83fd845)OpenEncyclopedia()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.OpenEncyclopedia | ( |  | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a4fc5c976bf7d51d9d8d001cf8c4d52cf)OpenSaveLoad()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.OpenSaveLoad | ( | bool | *isSaving* | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#ad1c176b832253e75a6f5a1a42b847b9a)CloseEscapeMenu()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.CloseEscapeMenu | ( |  | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#aa90079b1564eb45cf0a05d010413066a)OpenEscapeMenu()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.OpenEscapeMenu | ( |  | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a766e222642f666c6a13eaa25d6dfe421)CloseGameplayCheats()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.CloseGameplayCheats | ( |  | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a059e66f38134f032c8888ddfa711d37f)CloseCampaignOptions()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.CloseCampaignOptions | ( |  | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a8c9a0e80ded278f7ba9f3098a4750023)OpenInventory()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.OpenInventory | ( |  | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#acafc546725f732630ad65ff3d0a1cfdc)OpenFacegenScreenAux()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.OpenFacegenScreenAux | ( |  | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a814680010cf75a96ef7a0216baf2dad0)IsCameraLockedToPlayerParty()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool SandBox.View.Map.MapScreen.IsCameraLockedToPlayerParty | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.GameState.IMapStateHandler](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#a0de4e1c6b4657c91a320e2410f49c8aa).

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#ab824194cbaaf0de3c93dfddd59d06f7c)FastMoveCameraToMainParty()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.FastMoveCameraToMainParty | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.GameState.IMapStateHandler](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#a9bbebde55503e8225a828da68fd23388).

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a468c3d838cdfba79f3441db148c98feb)ResetCamera()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.ResetCamera | ( | bool | *resetDistance*, |
|  |  | bool | *teleportToMainParty* ) |

Implements [TaleWorlds.CampaignSystem.GameState.IMapStateHandler](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#a07ea89baa9f0b82d361cc9cc5bf7eef1).

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a9920557f7b12ef91c260733e912c338b)TeleportCameraToMainParty()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapScreen.TeleportCameraToMainParty | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.GameState.IMapStateHandler](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html#a1a23d7759de0dac94eed4ba534ca5574).

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#ae1520a77706a7ea866158f06a0ca55b4)CharacterBannerMaterialCache
----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly Dictionary<Tuple<[Material](class_tale_worlds_1_1_engine_1_1_material.html), [Banner](class_tale_worlds_1_1_core_1_1_banner.html)>, [Material](class_tale_worlds_1_1_engine_1_1_material.html)> SandBox.View.Map.MapScreen.CharacterBannerMaterialCache = new Dictionary<Tuple<[Material](class_tale_worlds_1_1_engine_1_1_material.html), [Banner](class_tale_worlds_1_1_core_1_1_banner.html)>, [Material](class_tale_worlds_1_1_engine_1_1_material.html)>() |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a654b32cfd2eb49a6c06c213fd651d975)DisableVisualTicks
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.View.Map.MapScreen.DisableVisualTicks = false | | static |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#af59f2810369791b0e48b435b698221d1)MapTracksCampaignBehavior
-------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [IMapTracksCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_map_tracks_campaign_behavior.html) SandBox.View.Map.MapScreen.MapTracksCampaignBehavior |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a6b26a59116e8bf031f21807bd604de2e)EnemyPartyDecalColor
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const uint SandBox.View.Map.MapScreen.EnemyPartyDecalColor = 4292093218 | | static |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a0d459eb119230ca9c26bd1a4e18eeacc)AllyPartyDecalColor
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const uint SandBox.View.Map.MapScreen.AllyPartyDecalColor = 4284183827 | | static |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#ad76963b53e7aa04359599fc22f96eb1b)NeutralPartyDecalColor
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const uint SandBox.View.Map.MapScreen.NeutralPartyDecalColor = 4291596077 | | static |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#aa5639f3e4e41a9ad6b7f7133868e9ccb)TooltipHandlingDisabled
-----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool SandBox.View.Map.MapScreen.TooltipHandlingDisabled = false |

Property Documentation
----------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#aa582d9261e0f70d966d40c638b99c837)Input
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html) SandBox.View.Map.MapScreen.Input | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#ac0472a3b856ef2d2a8f2b61ce222b545)Instance
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MapScreen](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a7c49506e82203f67e51d711959f1ffd1) SandBox.View.Map.MapScreen.Instance | | staticget |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#aa1ae8408b4ababf4e0084cf1a895cab7)IsReady
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.View.Map.MapScreen.IsReady | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a7809ba8d01eec3ae4dea268141485db3)NavigationHandler
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [INavigationHandler](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_handler.html) SandBox.View.Map.MapScreen.NavigationHandler | | getset |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#ad7495a13606cfd6c57cfde31106bcf98)CurrentVisualOfTooltip
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html) SandBox.View.Map.MapScreen.CurrentVisualOfTooltip | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a597a5f51e39d80c7e808a8be793705cd)PrefabEntityCache
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignMapSiegePrefabEntityCache](class_sand_box_1_1_campaign_map_siege_prefab_entity_cache.html) SandBox.View.Map.MapScreen.PrefabEntityCache | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a076a69ed1dbf179a2216f50b398cac87)EncyclopediaScreenManager
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MapEncyclopediaView](class_sand_box_1_1_view_1_1_map_1_1_map_encyclopedia_view.html) SandBox.View.Map.MapScreen.EncyclopediaScreenManager | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a8bb96028a3aceb32e9785f668d6a4d61)IsEscapeMenuOpened
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.View.Map.MapScreen.IsEscapeMenuOpened | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a361afea8d0453acf74630f47e98d83b3)MapNotificationView
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MapNotificationView SandBox.View.Map.MapScreen.MapNotificationView | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#ad8590dda10d089c0c0cce7c2faeffee9)BannerTexturedMaterialCache
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Dictionary<Tuple<[Material](class_tale_worlds_1_1_engine_1_1_material.html), [Banner](class_tale_worlds_1_1_core_1_1_banner.html)>, [Material](class_tale_worlds_1_1_engine_1_1_material.html)> SandBox.View.Map.MapScreen.BannerTexturedMaterialCache | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#ad27c5743f2629fef960b7b672137e1fa)IsInMenu
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.View.Map.MapScreen.IsInMenu | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a4882df70150de07e7169fee3964a4078)SceneLayer
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | SceneLayer SandBox.View.Map.MapScreen.SceneLayer | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a3c6dbdd6804e5fbd2fb8383193ea4df2)MapCameraView
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MapCameraView SandBox.View.Map.MapScreen.MapCameraView | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a6df20e3ac2fdf71f095732575ef4b93e)MapSceneCursorActive
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.View.Map.MapScreen.MapSceneCursorActive | | getset |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#aab1edbed9d27070aad86914c3f41956e)ContourMaskEntity
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) SandBox.View.Map.MapScreen.ContourMaskEntity | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a996db20748898fc967dcc1c6bbbfd966)MapCursor
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MapCursor SandBox.View.Map.MapScreen.MapCursor = new MapCursor() | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a047f72854a39bec15d00381c1ee05c63)InactiveLightMeshes
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html)> SandBox.View.Map.MapScreen.InactiveLightMeshes | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a00a49b848a7190ac62686cf8442298b2)ActiveLightMeshes
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html)> SandBox.View.Map.MapScreen.ActiveLightMeshes | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#af8cc8fe76204a33f6904e01d19140263)MapScene
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) SandBox.View.Map.MapScreen.MapScene | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a9c1fcdb36a14701881143163e02199d1)MapState
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MapState SandBox.View.Map.MapScreen.MapState | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#aa6f96f4fc6bc571359dee31e33e83d75)IsInBattleSimulation
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.View.Map.MapScreen.IsInBattleSimulation | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a156074af7f739fbf0e6d0aff8420cb7c)IsInTownManagement
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.View.Map.MapScreen.IsInTownManagement | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#ad5b33d34caae9f4782b782539f3b2a2f)IsInHideoutTroopManage
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.View.Map.MapScreen.IsInHideoutTroopManage | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#ab005d0bd9c0154087a8e92800f460ea1)IsInArmyManagement
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.View.Map.MapScreen.IsInArmyManagement | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#aa152965c9430c451448f164f4fe2c4db)IsInRecruitment
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.View.Map.MapScreen.IsInRecruitment | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a396b5c77a2273c6d7f3c40e3974604d0)IsBarExtended
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.View.Map.MapScreen.IsBarExtended | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a500bf13abd249bc594526e6a27b56a07)IsInCampaignOptions
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.View.Map.MapScreen.IsInCampaignOptions | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a73c9e431eb9a588e7bb3e6f6ffe69aaa)IsMarriageOfferPopupActive
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.View.Map.MapScreen.IsMarriageOfferPopupActive | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a56ab8c3cc3a03f8c5e1a2c895d8030d3)IsMapCheatsActive
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.View.Map.MapScreen.IsMapCheatsActive | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a60cdd61af96fb3ef3bcb1cac18ef9c38)IsMapIncidentActive
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.View.Map.MapScreen.IsMapIncidentActive | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#aa811162bc59fd88f32bddac693f9a181)IsHeirSelectionPopupActive
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.View.Map.MapScreen.IsHeirSelectionPopupActive | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#aa37b94babb457a29d21652aa3a25cb24)IsOverlayContextMenuEnabled
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.View.Map.MapScreen.IsOverlayContextMenuEnabled | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#a2591a7c21d2130de5ad880c21190771c)IsSoundOn
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.View.Map.MapScreen.IsSoundOn = true | | get |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_screen.html#aabc101d01f2f07ff90560d62da18d701)VisualsOfEntities
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Dictionary<UIntPtr, [MapEntityVisual](class_sand_box_1_1_view_1_1_map_1_1_visuals_1_1_map_entity_visual.html)> SandBox.View.Map.MapScreen.VisualsOfEntities | | staticget |

