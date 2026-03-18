--- SOURCE: class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_targets_1_1_mission_pa70da24ef95eca312d24053fc379f5b23.html ---

SandBox.ViewModelCollection.Missions.NameMarker.Targets.MissionPassageUsePointNameMarkerTargetVM Class ReferenceInherits [SandBox.ViewModelCollection.Missions.NameMarker.MissionNameMarkerTargetVM< T >](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_target_v_m-1-g.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MissionPassageUsePointNameMarkerTargetVM](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_targets_1_1_mission_pa70da24ef95eca312d24053fc379f5b23.html#a6ce791419fa99ff81e05ce247cc2f966) ([PassageUsePoint](class_sand_box_1_1_objects_1_1_passage_use_point.html) target) |
| override void | [UpdatePosition](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_targets_1_1_mission_pa70da24ef95eca312d24053fc379f5b23.html#a1008b011467ba913aa6d0046c1d0aa70) ([Camera](class_tale_worlds_1_1_engine_1_1_camera.html) missionCamera) |
| Public Member Functions inherited from [SandBox.ViewModelCollection.Missions.NameMarker.MissionNameMarkerTargetVM< T >](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_target_v_m-1-g.html) | |
| override bool | [Equals](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_target_v_m-1-g.html#a96ebfad8040c262f890a1330d6c29bab) ([MissionNameMarkerTargetBaseVM](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_target_base_v_m.html#a6bedc0453a6071c703e35731f5683d1e) other) |
| Public Member Functions inherited from [SandBox.ViewModelCollection.Missions.NameMarker.MissionNameMarkerTargetBaseVM](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_target_base_v_m.html) | |
|  | [MissionNameMarkerTargetBaseVM](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_target_base_v_m.html#a6bedc0453a6071c703e35731f5683d1e) () |
| void | [UpdatePosition](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_target_base_v_m.html#a28662cc8c76ab58fccae0114d6cbfd4b) ([Camera](class_tale_worlds_1_1_engine_1_1_camera.html) missionCamera) |
| bool | [Equals](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_target_base_v_m.html#a5b8c0d897435daa27ce1f624cfade114) ([MissionNameMarkerTargetBaseVM](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_target_base_v_m.html#a6bedc0453a6071c703e35731f5683d1e) other) |
| override void | [RefreshValues](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_target_base_v_m.html#afeb2cd30865694a1b82acfdded608a71) () |
|  | Used for updating localized texts. |
| void | [SetEnabledState](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_target_base_v_m.html#a38bb39f7164b1f5fba49854240b1a64f) (bool enabled) |
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

|  |  |
| --- | --- |
| Protected Member Functions | |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetName](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_targets_1_1_mission_pa70da24ef95eca312d24053fc379f5b23.html#aea8aa07bd7e6f424a3c4ba7761c7546c) () |
| Protected Member Functions inherited from [SandBox.ViewModelCollection.Missions.NameMarker.MissionNameMarkerTargetVM< T >](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_target_v_m-1-g.html) | |
|  | [MissionNameMarkerTargetVM](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_target_v_m-1-g.html#a3db9a1537b7ab784cf3fd94dcdfeea20) (T target) |
| Protected Member Functions inherited from [SandBox.ViewModelCollection.Missions.NameMarker.MissionNameMarkerTargetBaseVM](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_target_base_v_m.html) | |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetName](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_target_base_v_m.html#a3bc1ade2ded2c669bc5f0df3027f3f1b) () |
| void | [UpdatePositionWith](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_target_base_v_m.html#a6e4d7a05b869c96e444771ab36a83dc1) ([Camera](class_tale_worlds_1_1_engine_1_1_camera.html) missionCamera, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) worldPosition) |
| Protected Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
|  | [ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa7ebef6752dad8cfe2fc8d327365ee17) () |
| bool | [SetField< T >](class_tale_worlds_1_1_library_1_1_view_model.html#a97fe93429d4e1d7ad6e5645f2b542d38) (ref T field, T value, string propertyName) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static void | [RefreshPropertyAndMethodInfos](class_tale_worlds_1_1_library_1_1_view_model.html#af97f39f16f411d47a799f0544f96ede1) () |
| Static Public Attributes inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static bool | [UIDebugMode](class_tale_worlds_1_1_library_1_1_view_model.html#a14668e8bcc887c0a2edfa9593be97fe5) |
| Properties inherited from [SandBox.ViewModelCollection.Missions.NameMarker.MissionNameMarkerTargetVM< T >](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_target_v_m-1-g.html) | |
| T | [Target](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_target_v_m-1-g.html#a9f34701f71c7e15aecc7970aa9c870ab) `[get]` |
| Properties inherited from [SandBox.ViewModelCollection.Missions.NameMarker.MissionNameMarkerTargetBaseVM](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_target_base_v_m.html) | |
| MBBindingList< [QuestMarkerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_marker_v_m.html) > | [Quests](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_target_base_v_m.html#a7b523586725b33d09e01e2cc67d150f9) `[get, set]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [ScreenPosition](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_target_base_v_m.html#a8ba4e6d480f4c2225edd810db3dfb278) `[get, set]` |
| string | [Name](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_target_base_v_m.html#af82617d29dab2daee2eb9eb704a8e917) `[get, set]` |
| string | [IconType](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_target_base_v_m.html#ae945386cbfbf1bb376bda62af5b6d0a3) `[get, set]` |
| string | [NameType](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_target_base_v_m.html#af9596e700b3e5b976bf12703cc588b05) `[get, set]` |
| int | [Distance](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_target_base_v_m.html#ae32488b4b214304221b071d31b2eb15b) `[get, set]` |
| bool | [IsEnabled](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_target_base_v_m.html#acf05313ba4910890f9c28794c9e514e4) `[get, set]` |
| bool | [IsTracked](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_target_base_v_m.html#a20e9fc590b748f511800cbd04d7b0815) `[get, set]` |
| bool | [IsQuestMainStory](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_target_base_v_m.html#aaf3383cb430a8687e25f97bdafa2aa82) `[get, set]` |
| bool | [IsEnemy](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_target_base_v_m.html#ada26eb6b095e8e747bb6606c4e9510cf) `[get, set]` |
| bool | [IsFriendly](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_target_base_v_m.html#ad71ee78fc24ecc1be7294838d3709edc) `[get, set]` |
| bool | [IsPersistent](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_target_base_v_m.html#a58b78e7e0e9791416fb5452fb48c30a8) `[get, set]` |
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

[◆](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_targets_1_1_mission_pa70da24ef95eca312d24053fc379f5b23.html#a6ce791419fa99ff81e05ce247cc2f966)MissionPassageUsePointNameMarkerTargetVM()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| SandBox.ViewModelCollection.Missions.NameMarker.Targets.MissionPassageUsePointNameMarkerTargetVM.MissionPassageUsePointNameMarkerTargetVM | ( | [PassageUsePoint](class_sand_box_1_1_objects_1_1_passage_use_point.html) | *target* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_targets_1_1_mission_pa70da24ef95eca312d24053fc379f5b23.html#a1008b011467ba913aa6d0046c1d0aa70)UpdatePosition()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void SandBox.ViewModelCollection.Missions.NameMarker.Targets.MissionPassageUsePointNameMarkerTargetVM.UpdatePosition | ( | [Camera](class_tale_worlds_1_1_engine_1_1_camera.html) | *missionCamera* | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_targets_1_1_mission_pa70da24ef95eca312d24053fc379f5b23.html#aea8aa07bd7e6f424a3c4ba7761c7546c)GetName()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) SandBox.ViewModelCollection.Missions.NameMarker.Targets.MissionPassageUsePointNameMarkerTargetVM.GetName | ( |  | ) |  | | protected |

