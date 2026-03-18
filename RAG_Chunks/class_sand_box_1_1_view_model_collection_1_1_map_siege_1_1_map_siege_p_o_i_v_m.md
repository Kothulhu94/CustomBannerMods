--- SOURCE: class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html ---

SandBox.ViewModelCollection.MapSiege.MapSiegePOIVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [POIType](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#a8a4090847ce2aa2365f584f52cfe6a70) {     [WallSection](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#a8a4090847ce2aa2365f584f52cfe6a70a6a665d505b5a359b90efddfbd8cfe89b) ,     [DefenderSiegeMachine](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#a8a4090847ce2aa2365f584f52cfe6a70a2d89e6e48debfd32df54be5afcc78277) ,     [AttackerRamSiegeMachine](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#a8a4090847ce2aa2365f584f52cfe6a70a206d6c3c4820bc7c75ccd08e094eef0b) ,     [AttackerTowerSiegeMachine](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#a8a4090847ce2aa2365f584f52cfe6a70a8d6d9e51bac240fc858f234bddb63fcf) ,     [AttackerRangedSiegeMachine](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#a8a4090847ce2aa2365f584f52cfe6a70ad7d4d07a88f57ddb98fa7d7a9483afd7)   } |
| enum | [MachineTypes](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#ad2a9a342f8215c2e38335f9399369ee9) {     [None](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#ad2a9a342f8215c2e38335f9399369ee9a6adf97f83acf6453d4a6a4b1070f3754) = -1 ,     [Wall](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#ad2a9a342f8215c2e38335f9399369ee9a94e8a499539d1a472f3b5dbbb85508c0) = 0 ,     [BrokenWall](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#ad2a9a342f8215c2e38335f9399369ee9a4f5ef64f6308628e9887414c66adbffd) ,     [Ballista](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#ad2a9a342f8215c2e38335f9399369ee9ad0a2e600040b35b7d25c1a1bd343889c) ,     [Trebuchet](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#ad2a9a342f8215c2e38335f9399369ee9ac373314dcf20f32146a40d5daddd4896) ,     [Ladder](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#ad2a9a342f8215c2e38335f9399369ee9aa9e50715f7fd967738ee867b32cfb42e) ,     [Ram](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#ad2a9a342f8215c2e38335f9399369ee9ae5d284b6015067eaa11e06b809fe6f13) ,     [SiegeTower](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#ad2a9a342f8215c2e38335f9399369ee9aefc2d870cd2ff8553592c376513e26d4) ,     [Mangonel](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#ad2a9a342f8215c2e38335f9399369ee9adb01753b66920f25a39a1160aa52ca73)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MapSiegePOIVM](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#a9fe122459ff63f9256fa92a3e090bb67) ([POIType](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#a8a4090847ce2aa2365f584f52cfe6a70) type, [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) mapSceneLocation, [Camera](class_tale_worlds_1_1_engine_1_1_camera.html) mapCamera, int machineIndex, Action< MapSiegePOIVM > onSelection) |
| void | [ExecuteSelection](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#ae777203847d79714a0dd2639e680af6a) () |
| void | [UpdateProperties](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#a1131e3c419f147682ef808e095016582) () |
| void | [RefreshDistanceValue](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#a13923eaef67b971169880a106f8630ba) (float newDistance) |
| void | [RefreshPosition](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#a91409792a054d7a4b460a7eabd91e2d4) () |
| void | [RefreshBinding](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#a8f000e1cfeb2ca2075b648aae66b0346) () |
| void | [ExecuteShowTooltip](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#a051cb7a729d8967839a8c952159f165e) () |
| void | [ExecuteHideTooltip](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#ac246a0b4090ba59356ab834930c36989) () |
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
| Properties | |
| [POIType](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#a8a4090847ce2aa2365f584f52cfe6a70) | [Type](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#aa71099c1b38be84a57a75d4c1d70c115) `[get]` |
| int | [MachineIndex](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#a917106970dbc4cf6303a86d2af5d08d6) `[get]` |
| float | [LatestW](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#aaf64f9168546bddf4ff0fe7a72d59986) `[get]` |
| [SiegeEvent.SiegeEngineConstructionProgress](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engine_construction_progress.html) | [Machine](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#ac50571a5df1bca4aa9283ef0c2f8176e) `[get]` |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [MapSceneLocationFrame](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#a98b6b4c63d80ddcb32d4ea0da9ede438) `[get]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [Position](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#ad2c41038f92ba057ac0e756edf35f5c3) `[get, set]` |
| [Color](struct_tale_worlds_1_1_library_1_1_color.html) | [SidePrimaryColor](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#a5c0f9d8e9abac5a63df4ef2d86ac28a8) `[get, set]` |
| [Color](struct_tale_worlds_1_1_library_1_1_color.html) | [SideSecondaryColor](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#a1fad93b14972ebdf6039ce9cdf5827a6) `[get, set]` |
| int | [QueueIndex](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#a1f5bdcaea226d32aaa8677f29ede46c2) `[get, set]` |
| int | [MachineType](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#ad24b5a0a9a67616f419b5597a916b7ea) `[get, set]` |
| float | [CurrentHitpoints](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#a230132799dbc04ca37c66a4ccdf5b004) `[get, set]` |
| float | [MaxHitpoints](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#ae56b5171348a7fc593c4eac5ad397ca0) `[get, set]` |
| bool | [IsPlayerSidePOI](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#aed58ea4c64bb8c80ade7792d30896d45) `[get, set]` |
| bool | [IsFireVersion](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#a9adbdd712a9cf1781f7ce2ccff0e423a) `[get, set]` |
| bool | [IsInVisibleRange](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#a197422a36f02789519765d19a8fcee78) `[get, set]` |
| bool | [IsConstructing](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#a50a803d7072e0e4b8b0ae8f605c2903c) `[get, set]` |
| bool | [IsSelected](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#af8722a4478ebf16222fc277f3e3b7596) `[get, set]` |
| bool | [HasItem](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#ab29626419d3efa88edec591a8112a852) `[get, set]` |
|  | Represents if POI has a machine dedicated or is a wall. |
| bool | [IsInside](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#af23df310f043ced267c4350a5b9efb2f) `[get, set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static void | [RefreshPropertyAndMethodInfos](class_tale_worlds_1_1_library_1_1_view_model.html#af97f39f16f411d47a799f0544f96ede1) () |
| Static Public Attributes inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static bool | [UIDebugMode](class_tale_worlds_1_1_library_1_1_view_model.html#a14668e8bcc887c0a2edfa9593be97fe5) |
| Protected Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
|  | [ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa7ebef6752dad8cfe2fc8d327365ee17) () |
| bool | [SetField< T >](class_tale_worlds_1_1_library_1_1_view_model.html#a97fe93429d4e1d7ad6e5645f2b542d38) (ref T field, T value, string propertyName) |
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

[◆](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#a8a4090847ce2aa2365f584f52cfe6a70)POIType
---------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [SandBox.ViewModelCollection.MapSiege.MapSiegePOIVM.POIType](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#a8a4090847ce2aa2365f584f52cfe6a70) |

| Enumerator | |
| --- | --- |
| WallSection |  |
| DefenderSiegeMachine |  |
| AttackerRamSiegeMachine |  |
| AttackerTowerSiegeMachine |  |
| AttackerRangedSiegeMachine |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#ad2a9a342f8215c2e38335f9399369ee9)MachineTypes
--------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [SandBox.ViewModelCollection.MapSiege.MapSiegePOIVM.MachineTypes](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#ad2a9a342f8215c2e38335f9399369ee9) |

| Enumerator | |
| --- | --- |
| None |  |
| Wall |  |
| BrokenWall |  |
| Ballista |  |
| Trebuchet |  |
| Ladder |  |
| Ram |  |
| SiegeTower |  |
| Mangonel |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#a9fe122459ff63f9256fa92a3e090bb67)MapSiegePOIVM()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| SandBox.ViewModelCollection.MapSiege.MapSiegePOIVM.MapSiegePOIVM | ( | [POIType](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#a8a4090847ce2aa2365f584f52cfe6a70) | *type*, |
|  |  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *mapSceneLocation*, |
|  |  | [Camera](class_tale_worlds_1_1_engine_1_1_camera.html) | *mapCamera*, |
|  |  | int | *machineIndex*, |
|  |  | Action< MapSiegePOIVM > | *onSelection* ) |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#ae777203847d79714a0dd2639e680af6a)ExecuteSelection()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.MapSiege.MapSiegePOIVM.ExecuteSelection | ( |  | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#a1131e3c419f147682ef808e095016582)UpdateProperties()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.MapSiege.MapSiegePOIVM.UpdateProperties | ( |  | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#a13923eaef67b971169880a106f8630ba)RefreshDistanceValue()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.MapSiege.MapSiegePOIVM.RefreshDistanceValue | ( | float | *newDistance* | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#a91409792a054d7a4b460a7eabd91e2d4)RefreshPosition()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.MapSiege.MapSiegePOIVM.RefreshPosition | ( |  | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#a8f000e1cfeb2ca2075b648aae66b0346)RefreshBinding()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.MapSiege.MapSiegePOIVM.RefreshBinding | ( |  | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#a051cb7a729d8967839a8c952159f165e)ExecuteShowTooltip()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.MapSiege.MapSiegePOIVM.ExecuteShowTooltip | ( |  | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#ac246a0b4090ba59356ab834930c36989)ExecuteHideTooltip()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.MapSiege.MapSiegePOIVM.ExecuteHideTooltip | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#aa71099c1b38be84a57a75d4c1d70c115)Type
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [POIType](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#a8a4090847ce2aa2365f584f52cfe6a70) SandBox.ViewModelCollection.MapSiege.MapSiegePOIVM.Type | | get |

[◆](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#a917106970dbc4cf6303a86d2af5d08d6)MachineIndex
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.ViewModelCollection.MapSiege.MapSiegePOIVM.MachineIndex | | get |

[◆](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#aaf64f9168546bddf4ff0fe7a72d59986)LatestW
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float SandBox.ViewModelCollection.MapSiege.MapSiegePOIVM.LatestW | | get |

[◆](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#ac50571a5df1bca4aa9283ef0c2f8176e)Machine
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SiegeEvent.SiegeEngineConstructionProgress](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engine_construction_progress.html) SandBox.ViewModelCollection.MapSiege.MapSiegePOIVM.Machine | | get |

[◆](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#a98b6b4c63d80ddcb32d4ea0da9ede438)MapSceneLocationFrame
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) SandBox.ViewModelCollection.MapSiege.MapSiegePOIVM.MapSceneLocationFrame | | get |

[◆](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#ad2c41038f92ba057ac0e756edf35f5c3)Position
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) SandBox.ViewModelCollection.MapSiege.MapSiegePOIVM.Position | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#a5c0f9d8e9abac5a63df4ef2d86ac28a8)SidePrimaryColor
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Color](struct_tale_worlds_1_1_library_1_1_color.html) SandBox.ViewModelCollection.MapSiege.MapSiegePOIVM.SidePrimaryColor | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#a1fad93b14972ebdf6039ce9cdf5827a6)SideSecondaryColor
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Color](struct_tale_worlds_1_1_library_1_1_color.html) SandBox.ViewModelCollection.MapSiege.MapSiegePOIVM.SideSecondaryColor | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#a1f5bdcaea226d32aaa8677f29ede46c2)QueueIndex
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.ViewModelCollection.MapSiege.MapSiegePOIVM.QueueIndex | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#ad24b5a0a9a67616f419b5597a916b7ea)MachineType
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.ViewModelCollection.MapSiege.MapSiegePOIVM.MachineType | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#a230132799dbc04ca37c66a4ccdf5b004)CurrentHitpoints
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float SandBox.ViewModelCollection.MapSiege.MapSiegePOIVM.CurrentHitpoints | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#ae56b5171348a7fc593c4eac5ad397ca0)MaxHitpoints
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float SandBox.ViewModelCollection.MapSiege.MapSiegePOIVM.MaxHitpoints | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#aed58ea4c64bb8c80ade7792d30896d45)IsPlayerSidePOI
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.MapSiege.MapSiegePOIVM.IsPlayerSidePOI | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#a9adbdd712a9cf1781f7ce2ccff0e423a)IsFireVersion
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.MapSiege.MapSiegePOIVM.IsFireVersion | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#a197422a36f02789519765d19a8fcee78)IsInVisibleRange
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.MapSiege.MapSiegePOIVM.IsInVisibleRange | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#a50a803d7072e0e4b8b0ae8f605c2903c)IsConstructing
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.MapSiege.MapSiegePOIVM.IsConstructing | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#af8722a4478ebf16222fc277f3e3b7596)IsSelected
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.MapSiege.MapSiegePOIVM.IsSelected | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#ab29626419d3efa88edec591a8112a852)HasItem
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.MapSiege.MapSiegePOIVM.HasItem | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_map_siege_1_1_map_siege_p_o_i_v_m.html#af23df310f043ced267c4350a5b9efb2f)IsInside
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.MapSiege.MapSiegePOIVM.IsInside | | getset |

