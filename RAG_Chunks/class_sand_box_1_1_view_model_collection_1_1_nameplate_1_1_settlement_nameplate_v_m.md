--- SOURCE: class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html ---

SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM Class ReferenceInherits [SandBox.ViewModelCollection.Nameplate.NameplateVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [Type](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a91fe28c8eb7c2452ed9f8feff4e8b551) {     [Village](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a91fe28c8eb7c2452ed9f8feff4e8b551aabc63490c815af81276f930216c8d92b) = 0 ,     [Castle](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a91fe28c8eb7c2452ed9f8feff4e8b551a11081b0ce75b0e635708443850bef902) = 1 ,     [Town](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a91fe28c8eb7c2452ed9f8feff4e8b551ac16dac173aa8377a1c07aed8e0472f7c)   } |
| enum | [RelationType](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a9739d60b3ad809c8cd306f213530d9d2) {     [Neutral](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a9739d60b3ad809c8cd306f213530d9d2ae9bb5320b3890b6747c91b5a71ae5a01) = 0 ,     [Ally](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a9739d60b3ad809c8cd306f213530d9d2a0dd87782600574e2f791bcfe639d4fcc) = 1 ,     [Enemy](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a9739d60b3ad809c8cd306f213530d9d2a8c6d21187fb58b7a079d70030686b33e)   } |
| enum | [IssueTypes](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a0d07453bf14963730c81f2348405acd1) {     [None](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a0d07453bf14963730c81f2348405acd1a6adf97f83acf6453d4a6a4b1070f3754) = 0 ,     [Possible](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a0d07453bf14963730c81f2348405acd1a7ed6c322b81093217dd80a7d098736eb) ,     [Active](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a0d07453bf14963730c81f2348405acd1a4d3d769b812b6faa6b76e1a8abaece2d)   } |
| enum | [MainQuestTypes](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a7a057eb63104b84a4583542035291757) {     [None](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a7a057eb63104b84a4583542035291757a6adf97f83acf6453d4a6a4b1070f3754) = 0 ,     [Possible](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a7a057eb63104b84a4583542035291757a7ed6c322b81093217dd80a7d098736eb) ,     [Active](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a7a057eb63104b84a4583542035291757a4d3d769b812b6faa6b76e1a8abaece2d)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [SettlementNameplateVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#ab657ff164874f1327e2e86672656447e) ([Settlement](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#abd7cf4bd98235e86d8b759ee20c33138) settlement, [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) entity, [Camera](class_tale_worlds_1_1_engine_1_1_camera.html) mapCamera, Action< [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) > fastMoveCameraToPosition) |
| override void | [OnFinalize](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#ae66dd6551f6149ce82bb21f8482d6be5) () |
| override void | [RefreshValues](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#ada21a2b91571946f9a46aa22e9f55495) () |
|  | Used for updating localized texts. |
| override void | [RefreshDynamicProperties](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#acb8ac69096ccb434e715fd9375a6a5b5) (bool forceUpdate) |
| override void | [RefreshRelationStatus](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a2f5c5fe13e448a2477a86d15939c4811) () |
| override void | [RefreshPosition](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a43e6faac9fcf5995d4dbdbaa891ddd98) () |
| override void | [RefreshTutorialStatus](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a32b2b7523279edc8e74f8aa284bb4873) (string newTutorialHighlightElementID) |
| void | [OnSiegeEventStartedOnSettlement](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a21705ed7592ecdcb15d87839c77dde4a) ([SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) siegeEvent) |
| void | [OnSiegeEventEndedOnSettlement](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a7fc4a512c0afb025ddaa4782b7a3f1db) ([SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) siegeEvent) |
| void | [OnMapEventStartedOnSettlement](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#ac8a770624f81bb9b19426481ab34e652) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) mapEvent) |
| void | [OnMapEventEndedOnSettlement](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#ade0f6bbd459a41c22928ad226588b106) () |
| void | [OnRebelliousClanFormed](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#aa64248f8b3a58c1a1bd87345a2a85985) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| void | [OnRebelliousClanDisbanded](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a08b95ca807f911191c097cb334bf3c68) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| void | [UpdateNameplateMT](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#aee1d6c252a308cab5d858712944907e3) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) cameraPosition) |
| void | [RefreshBindValues](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#aaac7203118783107e17efc31d491d768) () |
| void | [ExecuteTrack](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#aeb77b11f5c2162ccb997d8aca823465a) () |
| void | [ExecuteSetCameraPosition](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a0fd2f5bd8524ed75f9d42af3d8d45432) () |
| void | [ExecuteOpenEncyclopedia](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a1ead715094b1b14a697107b386143bcd) () |
| Public Member Functions inherited from [SandBox.ViewModelCollection.Nameplate.NameplateVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html) | |
|  | [NameplateVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#a555aed693caf5a959be646f772d860b1) () |
| Public Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| void | [OnPropertyChanged](class_tale_worlds_1_1_library_1_1_view_model.html#a1a9dee9bab5986a33083d31a689dc7fe) ([CallerMemberName] string propertyName=null) |
|  | Method for notifying binded views about the changes in a property. Uses reflection to get the value of the property. If reflection is not needed or updated value of the property is already known, use [OnPropertyChangedWithValue()](class_tale_worlds_1_1_library_1_1_view_model.html#a0d6928eeec2b43ac9ae089830783bd7f) instead. |
| void | [OnPropertyChangedWithValue< T >](class_tale_worlds_1_1_library_1_1_view_model.html#ae5000d209ee6d4e7baec2fa8e8803c7e) (T value, [CallerMemberName]string propertyName=null) |
|  | Faster method for notifying binded views about the changes in a property. To avoid reflection, caller can pass changed value to this method. If caller does not have access rights to the value, use [OnPropertyChanged()](class_tale_worlds_1_1_library_1_1_view_model.html#a1a9dee9bab5986a33083d31a689dc7fe "Method for notifying binded views about the changes in a property. Uses reflection to get the value o...") instead. |
| void | [OnPropertyChangedWithValue](class_tale_worlds_1_1_library_1_1_view_model.html#a0d6928eeec2b43ac9ae089830783bd7f) (bool value, [CallerMemberName] string propertyName=null) |
| void | [OnPropertyChangedWithValue](class_tale_worlds_1_1_library_1_1_view_model.html#abf208d3c50803f5d1f70fa658c21dc96) (int value, [CallerMemberName] string propertyName=null) |
| void | [OnPropertyChangedWithValue](class_tale_worlds_1_1_library_1_1_view_model.html#a991eb5001ba6210a9fefb4a69f8883c2) (float value, [CallerMemberName] string propertyName=null) |
| void | [OnPropertyChangedWithValue](class_tale_worlds_1_1_library_1_1_view_model.html#ac54722f74e27aa6143d62a9dc589fb95) (uint value, [CallerMemberName] string propertyName=null) |
| void | [OnPropertyChangedWithValue](class_tale_worlds_1_1_library_1_1_view_model.html#a62ff1ab710820c9583a4b6ee66bb05e8) ([Color](struct_tale_worlds_1_1_library_1_1_color.html) value, [CallerMemberName] string propertyName=null) |
| void | [OnPropertyChangedWithValue](class_tale_worlds_1_1_library_1_1_view_model.html#adb40c37120d9480a9c61934104b3b0ee) (double value, [CallerMemberName] string propertyName=null) |
| void | [OnPropertyChangedWithValue](class_tale_worlds_1_1_library_1_1_view_model.html#a3298a1b9a60a7057cac4df839915f49d) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) value, [CallerMemberName] string propertyName=null) |
| object | [GetViewModelAtPath](class_tale_worlds_1_1_library_1_1_view_model.html#adab1a5fac562c67766ef900113c2fd48) ([BindingPath](class_tale_worlds_1_1_library_1_1_binding_path.html) path, bool isList) |
| object | [GetViewModelAtPath](class_tale_worlds_1_1_library_1_1_view_model.html#a58ad0a333f63aeb396cf0282a65b3b73) ([BindingPath](class_tale_worlds_1_1_library_1_1_binding_path.html) path) |
| object | [GetPropertyValue](class_tale_worlds_1_1_library_1_1_view_model.html#a870f5daf5e6f307138260ee84406bd4e) (string name, [PropertyTypeFeeder](namespace_tale_worlds_1_1_library.html#a74850bfe0b5488f44574810b7462b0f7) propertyTypeFeeder) |
| object | [GetPropertyValue](class_tale_worlds_1_1_library_1_1_view_model.html#a6c761a8baf9a75c1d8fd65dbaed24055) (string name) |
| Type | [GetPropertyType](class_tale_worlds_1_1_library_1_1_view_model.html#ade14a4f33f7022fa0b20393db6e5f1b1) (string name) |
| void | [SetPropertyValue](class_tale_worlds_1_1_library_1_1_view_model.html#ad53397f315ef866a738a5e65556043df) (string name, object value) |
| void | [ExecuteCommand](class_tale_worlds_1_1_library_1_1_view_model.html#a857f69ffddc4dc222280b3e2b3c206bb) (string commandName, object[] parameters) |

|  |  |
| --- | --- |
| Properties | |
| Settlement | [Settlement](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#abd7cf4bd98235e86d8b759ee20c33138) `[get]` |
| [Type](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a91fe28c8eb7c2452ed9f8feff4e8b551) | [SettlementTypeEnum](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a6ab6458bec8af131810e288d416dd264) `[get]` |
| [SettlementNameplateNotificationsVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_notifications_1_1_settlemen29577672a35c81689803dfcaf1fbc897.html) | [SettlementNotifications](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a1bfcb310cd443b1e69ef27a12e278e80) `[get, set]` |
| [SettlementNameplatePartyMarkersVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_party_markers_v_m.html) | [SettlementParties](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a1add794e86ff84972d81b40fb74156be) `[get, set]` |
| [SettlementNameplateEventsVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_events_v_m.html) | [SettlementEvents](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#ad4282738451aa0891e4beb6fdd0983cb) `[get, set]` |
| int | [Relation](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a1ff2ff2f877a32cc888faaf7a90939a9) `[get, set]` |
| int | [MapEventVisualType](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a7d427e50fa171373e8244598057311ed) `[get, set]` |
| int | [WSign](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a45f680e2fdc933b6c7323fc6e3a184b8) `[get, set]` |
| float | [WPos](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a9eb7dad3ade5755a107f8f442a453e4c) `[get, set]` |
| [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) | [Banner](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a4b5823ce4882d6a232ef7dbb6fc40284) `[get, set]` |
| string | [Name](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#af9a484efbbb391bdb7752c215b8e3d2f) `[get, set]` |
| bool | [IsTracked](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a5d8a3200deed8bbaf379de9f23326449) `[get, set]` |
| bool | [IsInside](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a0aa007db72bb5f0a7d550a95917e1967) `[get, set]` |
| bool | [IsInRange](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a415b9f8787c44e4b17d20517f27f82ee) `[get, set]` |
| bool | [HasPort](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#af80b8fe6a008882ea3853430a91728f7) `[get, set]` |
| int | [SettlementType](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#ae93c12ba95960d050c428d30a8db27db) `[get, set]` |
| Properties inherited from [SandBox.ViewModelCollection.Nameplate.NameplateVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html) | |
| double | [Scale](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#a5d3dc2225dd7b164c5c5e2df769c239f) `[get, set]` |
| int | [NameplateOrder](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#ad54345e32e89e14af5fa5fbf429496ee) `[get, set]` |
| string | [FactionColor](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#accaefa9664bfd1218bdbb48cfd904b80) `[get, set]` |
| float | [DistanceToCamera](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#a52779c8f617c46333429959a24017ba3) `[get, set]` |
| bool | [IsVisibleOnMap](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#abcda4f4f0b3b5c57d3aff2df3247b501) `[get, set]` |
| bool | [IsTargetedByTutorial](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#a5bdf373585f449704cc3835ca1c4a915) `[get, set]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [Position](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#af3d7e1f26eda35561c09398af08e1dec) `[get, set]` |
| bool | [CanParley](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#af176d6782bf1eac58f369e9fa91a67a7) `[get, set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static void | [RefreshPropertyAndMethodInfos](class_tale_worlds_1_1_library_1_1_view_model.html#af97f39f16f411d47a799f0544f96ede1) () |
| Static Public Attributes inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static bool | [UIDebugMode](class_tale_worlds_1_1_library_1_1_view_model.html#a14668e8bcc887c0a2edfa9593be97fe5) |
| Protected Types inherited from [SandBox.ViewModelCollection.Nameplate.NameplateVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html) | |
| enum | [NameplateSize](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#aaf92261788f69b391875b2cf3f654851) {     [Small](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#aaf92261788f69b391875b2cf3f654851a2660064e68655415da2628c2ae2f7592) = 0 ,     [Normal](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#aaf92261788f69b391875b2cf3f654851a960b44c579bc2f6818d2daaf9e4c16f0) ,     [Big](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#aaf92261788f69b391875b2cf3f654851ad491538da818a2ba11a3195ba035cfd3)   } |
| Protected Member Functions inherited from [SandBox.ViewModelCollection.Nameplate.NameplateVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html) | |
| void | [OnTutorialNotificationElementChanged](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#a89978d373bd37016107518fcd6ccc7ed) ([TutorialNotificationElementChangeEvent](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_notification_element_change_event.html) obj) |
| Protected Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
|  | [ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa7ebef6752dad8cfe2fc8d327365ee17) () |
| bool | [SetField< T >](class_tale_worlds_1_1_library_1_1_view_model.html#a97fe93429d4e1d7ad6e5645f2b542d38) (ref T field, T value, string propertyName) |
| Protected Attributes inherited from [SandBox.ViewModelCollection.Nameplate.NameplateVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html) | |
| bool | [\_bindIsTargetedByTutorial](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#a2a5d76eadfcef4d4c8fe4a87442a4368) |
| Events inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| PropertyChangedEventHandler | [PropertyChanged](class_tale_worlds_1_1_library_1_1_view_model.html#a7f8d83700f17f8092632c1eaa406d665) `[add, remove]` |
| [PropertyChangedWithValueEventHandler](namespace_tale_worlds_1_1_library.html#aa511552e184232616e64f386cf1146b5) | [PropertyChangedWithValue](class_tale_worlds_1_1_library_1_1_view_model.html#acad8d628c31163e3022bea1e04675de6) `[add, remove]` |
| [PropertyChangedWithBoolValueEventHandler](namespace_tale_worlds_1_1_library.html#a6b0d7e614739868a8f81c53a64f081bd) | [PropertyChangedWithBoolValue](class_tale_worlds_1_1_library_1_1_view_model.html#a4d3b2d6f05fc919dca9e764b9e36af5d) `[add, remove]` |
| [PropertyChangedWithIntValueEventHandler](namespace_tale_worlds_1_1_library.html#a91bc6d8c78c447d9acf86771f3b3e932) | [PropertyChangedWithIntValue](class_tale_worlds_1_1_library_1_1_view_model.html#a3b31df15300b9652b9b5f664e03a5af9) `[add, remove]` |
| [PropertyChangedWithFloatValueEventHandler](namespace_tale_worlds_1_1_library.html#aa44f77d2af0c3adb609a79640e080914) | [PropertyChangedWithFloatValue](class_tale_worlds_1_1_library_1_1_view_model.html#a3cb9bd971256835c5f6169cb58d67470) `[add, remove]` |
| [PropertyChangedWithUIntValueEventHandler](namespace_tale_worlds_1_1_library.html#aec7149fde7f195f3c4b4f10c4ce23cb8) | [PropertyChangedWithUIntValue](class_tale_worlds_1_1_library_1_1_view_model.html#a197c48c4f8ba00372fc86a548ccb86f7) `[add, remove]` |
| [PropertyChangedWithColorValueEventHandler](namespace_tale_worlds_1_1_library.html#a90de79687e9792b5065a8a4e9c30eeac) | [PropertyChangedWithColorValue](class_tale_worlds_1_1_library_1_1_view_model.html#aea6e76a6562fbdf20688565257699162) `[add, remove]` |
| [PropertyChangedWithDoubleValueEventHandler](namespace_tale_worlds_1_1_library.html#a8ce8e1aa20a71b9da4d1655fe04b089b) | [PropertyChangedWithDoubleValue](class_tale_worlds_1_1_library_1_1_view_model.html#a7d6e829c2ae2ef0147ca5f05e554dfc4) `[add, remove]` |
| [PropertyChangedWithVec2ValueEventHandler](namespace_tale_worlds_1_1_library.html#aa3ec79ffa85e522745c02340a7a41f2e) | [PropertyChangedWithVec2Value](class_tale_worlds_1_1_library_1_1_view_model.html#a8d1fb5f70c9230599a24b5d89a9a18f4) `[add, remove]` |
| Events inherited from [TaleWorlds.Library.IViewModel](interface_tale_worlds_1_1_library_1_1_i_view_model.html) | |
| [PropertyChangedWithValueEventHandler](namespace_tale_worlds_1_1_library.html#aa511552e184232616e64f386cf1146b5) | [PropertyChangedWithValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#a19415fe20feafa29a4e6d8d61dd95834) |
| [PropertyChangedWithBoolValueEventHandler](namespace_tale_worlds_1_1_library.html#a6b0d7e614739868a8f81c53a64f081bd) | [PropertyChangedWithBoolValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#ae0ed3e57e466612e46fcf77b394b9ba6) |
| [PropertyChangedWithIntValueEventHandler](namespace_tale_worlds_1_1_library.html#a91bc6d8c78c447d9acf86771f3b3e932) | [PropertyChangedWithIntValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#ad33c6216fef22f2e150e0c0673c3c6ef) |
| [PropertyChangedWithFloatValueEventHandler](namespace_tale_worlds_1_1_library.html#aa44f77d2af0c3adb609a79640e080914) | [PropertyChangedWithFloatValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#acef7bf697f161b4c0d742215107b0b8b) |
| [PropertyChangedWithUIntValueEventHandler](namespace_tale_worlds_1_1_library.html#aec7149fde7f195f3c4b4f10c4ce23cb8) | [PropertyChangedWithUIntValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#afd24d3b78a5e7fab669c340045b8533f) |
| [PropertyChangedWithColorValueEventHandler](namespace_tale_worlds_1_1_library.html#a90de79687e9792b5065a8a4e9c30eeac) | [PropertyChangedWithColorValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#a3bc123550acc0a47f8c061c5a8300fa1) |
| [PropertyChangedWithDoubleValueEventHandler](namespace_tale_worlds_1_1_library.html#a8ce8e1aa20a71b9da4d1655fe04b089b) | [PropertyChangedWithDoubleValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#a4b1a715b622570235d8224ecef32dc13) |
| [PropertyChangedWithVec2ValueEventHandler](namespace_tale_worlds_1_1_library.html#aa3ec79ffa85e522745c02340a7a41f2e) | [PropertyChangedWithVec2Value](interface_tale_worlds_1_1_library_1_1_i_view_model.html#a5b8667b3ad8595517ada80e2928bd6ab) |

Member Enumeration Documentation
--------------------------------

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a91fe28c8eb7c2452ed9f8feff4e8b551)Type
-----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM.Type](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a91fe28c8eb7c2452ed9f8feff4e8b551) |

| Enumerator | |
| --- | --- |
| Village |  |
| Castle |  |
| Town |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a9739d60b3ad809c8cd306f213530d9d2)RelationType
-------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM.RelationType](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a9739d60b3ad809c8cd306f213530d9d2) |

| Enumerator | |
| --- | --- |
| Neutral |  |
| Ally |  |
| Enemy |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a0d07453bf14963730c81f2348405acd1)IssueTypes
-----------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM.IssueTypes](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a0d07453bf14963730c81f2348405acd1) |

| Enumerator | |
| --- | --- |
| None |  |
| Possible |  |
| Active |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a7a057eb63104b84a4583542035291757)MainQuestTypes
---------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM.MainQuestTypes](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a7a057eb63104b84a4583542035291757) |

| Enumerator | |
| --- | --- |
| None |  |
| Possible |  |
| Active |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#ab657ff164874f1327e2e86672656447e)SettlementNameplateVM()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM.SettlementNameplateVM | ( | [Settlement](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#abd7cf4bd98235e86d8b759ee20c33138) | *settlement*, |
|  |  | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *entity*, |
|  |  | [Camera](class_tale_worlds_1_1_engine_1_1_camera.html) | *mapCamera*, |
|  |  | Action< [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) > | *fastMoveCameraToPosition* ) |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#ae66dd6551f6149ce82bb21f8482d6be5)OnFinalize()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#ada21a2b91571946f9a46aa22e9f55495)RefreshValues()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#acb8ac69096ccb434e715fd9375a6a5b5)RefreshDynamicProperties()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM.RefreshDynamicProperties | ( | bool | *forceUpdate* | ) |  | | virtual |

Reimplemented from [SandBox.ViewModelCollection.Nameplate.NameplateVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#a847688a81bfee28ed3f2d6717b162458).

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a2f5c5fe13e448a2477a86d15939c4811)RefreshRelationStatus()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM.RefreshRelationStatus | ( |  | ) |  | | virtual |

Reimplemented from [SandBox.ViewModelCollection.Nameplate.NameplateVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#a5196fa11609dd40be7f0358de69498ee).

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a43e6faac9fcf5995d4dbdbaa891ddd98)RefreshPosition()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM.RefreshPosition | ( |  | ) |  | | virtual |

Reimplemented from [SandBox.ViewModelCollection.Nameplate.NameplateVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#a92ea64508163ebed07cdddea2fe8aed6).

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a32b2b7523279edc8e74f8aa284bb4873)RefreshTutorialStatus()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM.RefreshTutorialStatus | ( | string | *newTutorialHighlightElementID* | ) |  | | virtual |

Reimplemented from [SandBox.ViewModelCollection.Nameplate.NameplateVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#a15f901a0f8e2736045932aaf23cf0919).

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a21705ed7592ecdcb15d87839c77dde4a)OnSiegeEventStartedOnSettlement()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM.OnSiegeEventStartedOnSettlement | ( | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) | *siegeEvent* | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a7fc4a512c0afb025ddaa4782b7a3f1db)OnSiegeEventEndedOnSettlement()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM.OnSiegeEventEndedOnSettlement | ( | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) | *siegeEvent* | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#ac8a770624f81bb9b19426481ab34e652)OnMapEventStartedOnSettlement()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM.OnMapEventStartedOnSettlement | ( | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *mapEvent* | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#ade0f6bbd459a41c22928ad226588b106)OnMapEventEndedOnSettlement()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM.OnMapEventEndedOnSettlement | ( |  | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#aa64248f8b3a58c1a1bd87345a2a85985)OnRebelliousClanFormed()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM.OnRebelliousClanFormed | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a08b95ca807f911191c097cb334bf3c68)OnRebelliousClanDisbanded()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM.OnRebelliousClanDisbanded | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#aee1d6c252a308cab5d858712944907e3)UpdateNameplateMT()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM.UpdateNameplateMT | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *cameraPosition* | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#aaac7203118783107e17efc31d491d768)RefreshBindValues()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM.RefreshBindValues | ( |  | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#aeb77b11f5c2162ccb997d8aca823465a)ExecuteTrack()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM.ExecuteTrack | ( |  | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a0fd2f5bd8524ed75f9d42af3d8d45432)ExecuteSetCameraPosition()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM.ExecuteSetCameraPosition | ( |  | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a1ead715094b1b14a697107b386143bcd)ExecuteOpenEncyclopedia()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM.ExecuteOpenEncyclopedia | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#abd7cf4bd98235e86d8b759ee20c33138)Settlement
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Settlement SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM.Settlement | | get |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a6ab6458bec8af131810e288d416dd264)SettlementTypeEnum
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Type](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a91fe28c8eb7c2452ed9f8feff4e8b551) SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM.SettlementTypeEnum | | get |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a1bfcb310cd443b1e69ef27a12e278e80)SettlementNotifications
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SettlementNameplateNotificationsVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_notifications_1_1_settlemen29577672a35c81689803dfcaf1fbc897.html) SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM.SettlementNotifications | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a1add794e86ff84972d81b40fb74156be)SettlementParties
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SettlementNameplatePartyMarkersVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_party_markers_v_m.html) SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM.SettlementParties | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#ad4282738451aa0891e4beb6fdd0983cb)SettlementEvents
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SettlementNameplateEventsVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_events_v_m.html) SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM.SettlementEvents | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a1ff2ff2f877a32cc888faaf7a90939a9)Relation
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM.Relation | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a7d427e50fa171373e8244598057311ed)MapEventVisualType
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM.MapEventVisualType | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a45f680e2fdc933b6c7323fc6e3a184b8)WSign
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM.WSign | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a9eb7dad3ade5755a107f8f442a453e4c)WPos
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM.WPos | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a4b5823ce4882d6a232ef7dbb6fc40284)Banner
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM.Banner | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#af9a484efbbb391bdb7752c215b8e3d2f)Name
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM.Name | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a5d8a3200deed8bbaf379de9f23326449)IsTracked
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM.IsTracked | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a0aa007db72bb5f0a7d550a95917e1967)IsInside
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM.IsInside | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a415b9f8787c44e4b17d20517f27f82ee)IsInRange
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM.IsInRange | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#af80b8fe6a008882ea3853430a91728f7)HasPort
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM.HasPort | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#ae93c12ba95960d050c428d30a8db27db)SettlementType
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM.SettlementType | | getset |

