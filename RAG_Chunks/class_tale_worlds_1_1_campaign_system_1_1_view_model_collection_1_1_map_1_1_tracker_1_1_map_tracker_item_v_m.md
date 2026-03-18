--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.Map.Tracker.MapTrackerItemVM Class ReferenceabstractInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

Inherited by [TaleWorlds.CampaignSystem.ViewModelCollection.Map.Tracker.MapTrackerItemVM< T >](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m-1-g.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MapTrackerItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#ae191b0037afd42312f3df4e7e38837bb) ([ITrackableCampaignObject](interface_tale_worlds_1_1_campaign_system_1_1_i_trackable_campaign_object.html) trackedObject) |
| void | [UpdateProperties](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#acf80dea725fc8d56d495403e469c613e) () |
| void | [UpdatePosition](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a2bf8e37a19a83a9d7ec7cee5efb8b521) (float screenX, float screenY, float screenW) |
| void | [ExecuteToggleTrack](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a57a5f3e62c87edf97bb4b11351067b11) () |
| void | [ExecuteGoToPosition](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a373184fe295a22f8b16316caad098837) () |
| void | [ExecuteShowTooltip](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#aed43b47746806aaa58bf455641337d26) () |
| void | [ExecuteHideTooltip](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#aea695c38c6b53ce929ec9efd886a0814) () |
| void | [RefreshBinding](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a6c60097305edf306c9aa6105d9ebfe55) () |
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
| virtual void | [OnFinalize](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc) () |
| void | [ExecuteCommand](class_tale_worlds_1_1_library_1_1_view_model.html#a857f69ffddc4dc222280b3e2b3c206bb) (string commandName, object[] parameters) |
| virtual void | [RefreshValues](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd) () |
|  | Used for updating localized texts. |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly [ITrackableCampaignObject](interface_tale_worlds_1_1_campaign_system_1_1_i_trackable_campaign_object.html) | [TrackedObject](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a99a5c7aa0ac5f1240cc80c182cd0e44f) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static Action< [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) > | [OnFastMoveCameraToPosition](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#ac07ad0d982a949d78d7c33573416c98a) |
| Static Public Attributes inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static bool | [UIDebugMode](class_tale_worlds_1_1_library_1_1_view_model.html#a14668e8bcc887c0a2edfa9593be97fe5) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| void | [OnShowTooltip](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a8f279bc0908ff4122ac0bf4b1fe60cac) () |
| void | [OnUpdateProperties](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a772b0ef47db325972dab38e18180b369) () |
| void | [OnUpdatePosition](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a7b4c50844bc01cbccea2805f9d5b6efe) (float screenX, float screenY, float screenW) |
| void | [OnToggleTrack](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a6602017877d5537d23e97075a003011a) () |
| void | [OnGoToPosition](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a281bdd835ac2ee8f54eb3de485729085) () |
| void | [OnRefreshBinding](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a6efab0af38ce535b5d428bf26a57389f) () |
| bool | [IsVisibleOnMap](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#ad9351ea8032b03a6d95793a00d30e86b) () |
| bool | [GetCanToggleTrack](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a729b386e5375afb423bc736ac913c8b6) () |
| string | [GetTrackerType](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a2b7d979441516a724024b038dd706954) () |
| [CampaignUIHelper.IssueQuestFlags](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_u_i_helper.html#a3852b52bbf0e4b69bec10268df346439) | [GetRelatedQuests](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a5f75a164c79c7e7fd40c2be3fa668a25) () |
| Protected Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
|  | [ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa7ebef6752dad8cfe2fc8d327365ee17) () |
| bool | [SetField< T >](class_tale_worlds_1_1_library_1_1_view_model.html#a97fe93429d4e1d7ad6e5645f2b542d38) (ref T field, T value, string propertyName) |

|  |  |
| --- | --- |
| Protected Attributes | |
| float | [\_latestX](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#ae72f2ae0de9cb4ac81b678bdcaa76515) |
| float | [\_latestY](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#acab5b2a2437b4f3216dbe81028ec54b9) |
| float | [\_latestW](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a259df85b922bd0db7f9d30e155fa978b) |
| [CampaignUIHelper.IssueQuestFlags](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_u_i_helper.html#a3852b52bbf0e4b69bec10268df346439) | [\_previousQuestsBind](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a886b125886c101884140579f49f132b8) |
| [CampaignUIHelper.IssueQuestFlags](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_u_i_helper.html#a3852b52bbf0e4b69bec10268df346439) | [\_questsBind](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#af9f83f64fda7240d398a323fcd2cad08) |
| bool | [\_isVisibleOnMapBind](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#aa98249cf418d1c2119dd16f649c083f2) |
| bool | [\_isBehindBind](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a34680a81bf684b02368feca7db3d7ac2) |
| bool | [\_canToggleTrackBind](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#ab52cf7fb6285a7c70a8bb9bb8d4945e6) |
| string | [\_nameBind](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a2426ffd9384c2d0d6e6d62f2f9ee5683) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [\_partyPositionBind](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#ab4854cbc0292a0715d91adb2f01b52a0) |
| [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) | [\_factionVisualBind](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a18021c48e8e4409bd3c24aa7478aec48) |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsTracked](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#ae6c0b658fe29fcf5cf1457a8345e3f72) `[get, set]` |
| bool | [CanToggleTrack](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#af05a42fb84ce645991b5529391288263) `[get, set]` |
| bool | [IsEnabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a3f38d2cae53f8afe6da335c9ac5501ed) `[get, set]` |
| bool | [IsBehind](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a1f3161d37f705e434334d31f7da0d282) `[get, set]` |
| string | [Name](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a101a52395a4ed7c84c1220ad41fbbaf0) `[get, set]` |
| string | [TrackerType](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#ac36330980592d4c7e94c2916992a6632) `[get, set]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [PartyPosition](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a73814b301fd62db99fea491fa10b9155) `[get, set]` |
| [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) | [FactionVisual](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a03fc47e0b8510a8bc0cc6f7c7eb69e84) `[get, set]` |
| MBBindingList< [QuestMarkerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_marker_v_m.html) > | [Quests](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#ae30427f39b1e21820eef78f30615b027) `[get, set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static void | [RefreshPropertyAndMethodInfos](class_tale_worlds_1_1_library_1_1_view_model.html#af97f39f16f411d47a799f0544f96ede1) () |
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

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#ae191b0037afd42312f3df4e7e38837bb)MapTrackerItemVM()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.Map.Tracker.MapTrackerItemVM.MapTrackerItemVM | ( | [ITrackableCampaignObject](interface_tale_worlds_1_1_campaign_system_1_1_i_trackable_campaign_object.html) | *trackedObject* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a8f279bc0908ff4122ac0bf4b1fe60cac)OnShowTooltip()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.ViewModelCollection.Map.Tracker.MapTrackerItemVM.OnShowTooltip | ( |  | ) |  | | abstractprotected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a772b0ef47db325972dab38e18180b369)OnUpdateProperties()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.ViewModelCollection.Map.Tracker.MapTrackerItemVM.OnUpdateProperties | ( |  | ) |  | | abstractprotected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a7b4c50844bc01cbccea2805f9d5b6efe)OnUpdatePosition()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.ViewModelCollection.Map.Tracker.MapTrackerItemVM.OnUpdatePosition | ( | float | *screenX*, | |  |  | float | *screenY*, | |  |  | float | *screenW* ) | | abstractprotected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a6602017877d5537d23e97075a003011a)OnToggleTrack()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.ViewModelCollection.Map.Tracker.MapTrackerItemVM.OnToggleTrack | ( |  | ) |  | | abstractprotected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a281bdd835ac2ee8f54eb3de485729085)OnGoToPosition()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.ViewModelCollection.Map.Tracker.MapTrackerItemVM.OnGoToPosition | ( |  | ) |  | | abstractprotected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a6efab0af38ce535b5d428bf26a57389f)OnRefreshBinding()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.ViewModelCollection.Map.Tracker.MapTrackerItemVM.OnRefreshBinding | ( |  | ) |  | | abstractprotected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#ad9351ea8032b03a6d95793a00d30e86b)IsVisibleOnMap()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Map.Tracker.MapTrackerItemVM.IsVisibleOnMap | ( |  | ) |  | | abstractprotected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a729b386e5375afb423bc736ac913c8b6)GetCanToggleTrack()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Map.Tracker.MapTrackerItemVM.GetCanToggleTrack | ( |  | ) |  | | abstractprotected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a2b7d979441516a724024b038dd706954)GetTrackerType()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Map.Tracker.MapTrackerItemVM.GetTrackerType | ( |  | ) |  | | abstractprotected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a5f75a164c79c7e7fd40c2be3fa668a25)GetRelatedQuests()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [CampaignUIHelper.IssueQuestFlags](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_u_i_helper.html#a3852b52bbf0e4b69bec10268df346439) TaleWorlds.CampaignSystem.ViewModelCollection.Map.Tracker.MapTrackerItemVM.GetRelatedQuests | ( |  | ) |  | | abstractprotected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#acf80dea725fc8d56d495403e469c613e)UpdateProperties()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Map.Tracker.MapTrackerItemVM.UpdateProperties | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a2bf8e37a19a83a9d7ec7cee5efb8b521)UpdatePosition()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Map.Tracker.MapTrackerItemVM.UpdatePosition | ( | float | *screenX*, |
|  |  | float | *screenY*, |
|  |  | float | *screenW* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a57a5f3e62c87edf97bb4b11351067b11)ExecuteToggleTrack()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Map.Tracker.MapTrackerItemVM.ExecuteToggleTrack | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a373184fe295a22f8b16316caad098837)ExecuteGoToPosition()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Map.Tracker.MapTrackerItemVM.ExecuteGoToPosition | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#aed43b47746806aaa58bf455641337d26)ExecuteShowTooltip()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Map.Tracker.MapTrackerItemVM.ExecuteShowTooltip | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#aea695c38c6b53ce929ec9efd886a0814)ExecuteHideTooltip()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Map.Tracker.MapTrackerItemVM.ExecuteHideTooltip | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a6c60097305edf306c9aa6105d9ebfe55)RefreshBinding()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Map.Tracker.MapTrackerItemVM.RefreshBinding | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a99a5c7aa0ac5f1240cc80c182cd0e44f)TrackedObject
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [ITrackableCampaignObject](interface_tale_worlds_1_1_campaign_system_1_1_i_trackable_campaign_object.html) TaleWorlds.CampaignSystem.ViewModelCollection.Map.Tracker.MapTrackerItemVM.TrackedObject |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#ae72f2ae0de9cb4ac81b678bdcaa76515)\_latestX
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ViewModelCollection.Map.Tracker.MapTrackerItemVM.\_latestX | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#acab5b2a2437b4f3216dbe81028ec54b9)\_latestY
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ViewModelCollection.Map.Tracker.MapTrackerItemVM.\_latestY | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a259df85b922bd0db7f9d30e155fa978b)\_latestW
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ViewModelCollection.Map.Tracker.MapTrackerItemVM.\_latestW | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a886b125886c101884140579f49f132b8)\_previousQuestsBind
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignUIHelper.IssueQuestFlags](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_u_i_helper.html#a3852b52bbf0e4b69bec10268df346439) TaleWorlds.CampaignSystem.ViewModelCollection.Map.Tracker.MapTrackerItemVM.\_previousQuestsBind | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#af9f83f64fda7240d398a323fcd2cad08)\_questsBind
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignUIHelper.IssueQuestFlags](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_u_i_helper.html#a3852b52bbf0e4b69bec10268df346439) TaleWorlds.CampaignSystem.ViewModelCollection.Map.Tracker.MapTrackerItemVM.\_questsBind | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#aa98249cf418d1c2119dd16f649c083f2)\_isVisibleOnMapBind
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Map.Tracker.MapTrackerItemVM.\_isVisibleOnMapBind | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a34680a81bf684b02368feca7db3d7ac2)\_isBehindBind
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Map.Tracker.MapTrackerItemVM.\_isBehindBind | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#ab52cf7fb6285a7c70a8bb9bb8d4945e6)\_canToggleTrackBind
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Map.Tracker.MapTrackerItemVM.\_canToggleTrackBind | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a2426ffd9384c2d0d6e6d62f2f9ee5683)\_nameBind
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Map.Tracker.MapTrackerItemVM.\_nameBind | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#ab4854cbc0292a0715d91adb2f01b52a0)\_partyPositionBind
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.CampaignSystem.ViewModelCollection.Map.Tracker.MapTrackerItemVM.\_partyPositionBind | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a18021c48e8e4409bd3c24aa7478aec48)\_factionVisualBind
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Map.Tracker.MapTrackerItemVM.\_factionVisualBind | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#ac07ad0d982a949d78d7c33573416c98a)OnFastMoveCameraToPosition
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<[CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Map.Tracker.MapTrackerItemVM.OnFastMoveCameraToPosition | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#ae6c0b658fe29fcf5cf1457a8345e3f72)IsTracked
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Map.Tracker.MapTrackerItemVM.IsTracked | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#af05a42fb84ce645991b5529391288263)CanToggleTrack
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Map.Tracker.MapTrackerItemVM.CanToggleTrack | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a3f38d2cae53f8afe6da335c9ac5501ed)IsEnabled
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Map.Tracker.MapTrackerItemVM.IsEnabled | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a1f3161d37f705e434334d31f7da0d282)IsBehind
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Map.Tracker.MapTrackerItemVM.IsBehind | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a101a52395a4ed7c84c1220ad41fbbaf0)Name
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Map.Tracker.MapTrackerItemVM.Name | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#ac36330980592d4c7e94c2916992a6632)TrackerType
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Map.Tracker.MapTrackerItemVM.TrackerType | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a73814b301fd62db99fea491fa10b9155)PartyPosition
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.CampaignSystem.ViewModelCollection.Map.Tracker.MapTrackerItemVM.PartyPosition | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#a03fc47e0b8510a8bc0cc6f7c7eb69e84)FactionVisual
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Map.Tracker.MapTrackerItemVM.FactionVisual | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_tracker_1_1_map_tracker_item_v_m.html#ae30427f39b1e21820eef78f30615b027)Quests
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[QuestMarkerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_marker_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Map.Tracker.MapTrackerItemVM.Quests | | getset |

