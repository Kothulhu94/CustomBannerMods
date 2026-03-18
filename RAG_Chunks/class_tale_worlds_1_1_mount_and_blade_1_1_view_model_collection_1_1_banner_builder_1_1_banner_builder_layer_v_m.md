--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html ---

TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderLayerVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [BannerBuilderLayerVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#ab873491ab051db7bc02336d5ff69603a) ([BannerData](class_tale_worlds_1_1_core_1_1_banner_data.html) data, int layerIndex) |
| void | [Refresh](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#a6c53a28f0b038e7127ad3335be7d0cd3) () |
| void | [ExecuteDelete](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#a49e2cbf5208a8b0c0460d9cbdeca054e) () |
| void | [ExecuteSelection](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#aafbd0c2d17ad0300e25ced317196037c) () |
| void | [SetLayerIndex](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#abea5ffdd742f1fe610e9dd863f30db24) (int newIndex) |
| void | [ExecuteSelectColor1](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#ae306b2cff5b3ef4c5e8320fcb16bd252) () |
| void | [ExecuteSelectColor2](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#a64bee777ac7fb21c34def9310630424d) () |
| void | [ExecuteSwapColors](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#ab9a6966d64698e4cb703d65bf6a8636d) () |
| void | [ExecuteCenterSigil](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#abf98503d94ae1842edcf16bdce73bdd2) () |
| void | [ExecuteResetSize](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#a41d7fc131eceab9dab038ec402a96761) () |
| void | [ExecuteUpdateBanner](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#a4568b399490705697a05a70da458e43c) () |
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
| Static Public Member Functions | |
| static void | [SetLayerActions](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#a83eba28421c3503836c6fe2bc2769e1f) (Action refresh, Action< [BannerBuilderLayerVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#ab873491ab051db7bc02336d5ff69603a) > onSelection, Action< [BannerBuilderLayerVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#ab873491ab051db7bc02336d5ff69603a) > onDeletion, Action< int, Action< [BannerBuilderColorItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_color_item_v_m.html) > > onColorSelection) |
| static void | [ResetLayerActions](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#a2591bc43144be360ddeea03e9ac8d819) () |
| Static Public Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static void | [RefreshPropertyAndMethodInfos](class_tale_worlds_1_1_library_1_1_view_model.html#af97f39f16f411d47a799f0544f96ede1) () |

|  |  |
| --- | --- |
| Properties | |
| [BannerData](class_tale_worlds_1_1_core_1_1_banner_data.html) | [Data](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#a99e4cb342e2a91c8ba9dcd9d21197d98) `[get]` |
| bool | [IsSelected](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#aaeb843090909d2102eb4ab23d9f52236) `[get, set]` |
| bool | [CanDeleteLayer](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#ac05baa2baf201cb5a87c25f1dafbc3a9) `[get, set]` |
| bool | [IsLayerPattern](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#a1d0919dbd6dd0c89b429f33eb29ed34a) `[get, set]` |
| bool | [IsDrawStrokeActive](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#a20d2efffb902331fac1facb0f8b6fec8) `[get, set]` |
| bool | [IsMirrorActive](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#acf09cf7f412d921b3748813857cde795) `[get, set]` |
| float | [RotationValue](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#a9cad9606c3732321795cfa79bb0260cb) `[get, set]` |
| int | [RotationValue360](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#a26a7bc4cbcfe8252d8111a6bac4cfbb6) `[get, set]` |
| int | [IconID](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#ad865beaaf268d7abfbccde3e2c5191df) `[get, set]` |
| int | [LayerIndex](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#aaa4338d6f5c4a2758f38f3570fe35633) `[get, set]` |
| int | [EditableAreaSize](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#ab0dac6ce0eea4ecdafc886c8c298a51d) `[get, set]` |
| int | [TotalAreaSize](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#a614ce3afe77c2141fbfb772f21d049a5) `[get, set]` |
| string | [IconIDAsString](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#ae4a12cae063c8bfd091bac5c0ef1fcf9) `[get, set]` |
| [Library.Color](struct_tale_worlds_1_1_library_1_1_color.html) | [Color1](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#a8732ebcd0899b8865ff4b37e5377a364) `[get, set]` |
| [Library.Color](struct_tale_worlds_1_1_library_1_1_color.html) | [Color2](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#a8bd8f14318203c3033ed4b580bfa5579) `[get, set]` |
| string | [Color1AsStr](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#a2546bb79135e952274c409e828a19396) `[get, set]` |
| string | [Color2AsStr](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#a633ff78703a082e5140ea9ba19882c41) `[get, set]` |
| [Library.Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [PositionValue](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#aad323c9e94260a1e1a02258225a15eae) `[get, set]` |
| float | [PositionValueX](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#a4f80d02bc0696e1c7a743028b50778c9) `[get, set]` |
| float | [PositionValueY](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#a20afd04dfdda31090b4343b6f1bde0f3) `[get, set]` |
| [Library.Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [SizeValue](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#a8bc86c82337aeb344007ec26ea810952) `[get, set]` |
| float | [SizeValueX](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#a5137943ee217bbe2890a2eff5a469309) `[get, set]` |
| float | [SizeValueY](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#ae263455571f307c2d5b443a70b6ee024) `[get, set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
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

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#ab873491ab051db7bc02336d5ff69603a)BannerBuilderLayerVM()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderLayerVM.BannerBuilderLayerVM | ( | [BannerData](class_tale_worlds_1_1_core_1_1_banner_data.html) | *data*, |
|  |  | int | *layerIndex* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#a6c53a28f0b038e7127ad3335be7d0cd3)Refresh()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderLayerVM.Refresh | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#a49e2cbf5208a8b0c0460d9cbdeca054e)ExecuteDelete()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderLayerVM.ExecuteDelete | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#aafbd0c2d17ad0300e25ced317196037c)ExecuteSelection()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderLayerVM.ExecuteSelection | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#abea5ffdd742f1fe610e9dd863f30db24)SetLayerIndex()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderLayerVM.SetLayerIndex | ( | int | *newIndex* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#ae306b2cff5b3ef4c5e8320fcb16bd252)ExecuteSelectColor1()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderLayerVM.ExecuteSelectColor1 | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#a64bee777ac7fb21c34def9310630424d)ExecuteSelectColor2()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderLayerVM.ExecuteSelectColor2 | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#ab9a6966d64698e4cb703d65bf6a8636d)ExecuteSwapColors()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderLayerVM.ExecuteSwapColors | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#abf98503d94ae1842edcf16bdce73bdd2)ExecuteCenterSigil()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderLayerVM.ExecuteCenterSigil | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#a41d7fc131eceab9dab038ec402a96761)ExecuteResetSize()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderLayerVM.ExecuteResetSize | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#a4568b399490705697a05a70da458e43c)ExecuteUpdateBanner()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderLayerVM.ExecuteUpdateBanner | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#a83eba28421c3503836c6fe2bc2769e1f)SetLayerActions()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderLayerVM.SetLayerActions | ( | Action | *refresh*, | |  |  | Action< [BannerBuilderLayerVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#ab873491ab051db7bc02336d5ff69603a) > | *onSelection*, | |  |  | Action< [BannerBuilderLayerVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#ab873491ab051db7bc02336d5ff69603a) > | *onDeletion*, | |  |  | Action< int, Action< [BannerBuilderColorItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_color_item_v_m.html) > > | *onColorSelection* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#a2591bc43144be360ddeea03e9ac8d819)ResetLayerActions()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderLayerVM.ResetLayerActions | ( |  | ) |  | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#a99e4cb342e2a91c8ba9dcd9d21197d98)Data
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BannerData](class_tale_worlds_1_1_core_1_1_banner_data.html) TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderLayerVM.Data | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#aaeb843090909d2102eb4ab23d9f52236)IsSelected
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderLayerVM.IsSelected | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#ac05baa2baf201cb5a87c25f1dafbc3a9)CanDeleteLayer
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderLayerVM.CanDeleteLayer | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#a1d0919dbd6dd0c89b429f33eb29ed34a)IsLayerPattern
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderLayerVM.IsLayerPattern | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#a20d2efffb902331fac1facb0f8b6fec8)IsDrawStrokeActive
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderLayerVM.IsDrawStrokeActive | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#acf09cf7f412d921b3748813857cde795)IsMirrorActive
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderLayerVM.IsMirrorActive | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#a9cad9606c3732321795cfa79bb0260cb)RotationValue
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderLayerVM.RotationValue | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#a26a7bc4cbcfe8252d8111a6bac4cfbb6)RotationValue360
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderLayerVM.RotationValue360 | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#ad865beaaf268d7abfbccde3e2c5191df)IconID
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderLayerVM.IconID | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#aaa4338d6f5c4a2758f38f3570fe35633)LayerIndex
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderLayerVM.LayerIndex | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#ab0dac6ce0eea4ecdafc886c8c298a51d)EditableAreaSize
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderLayerVM.EditableAreaSize | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#a614ce3afe77c2141fbfb772f21d049a5)TotalAreaSize
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderLayerVM.TotalAreaSize | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#ae4a12cae063c8bfd091bac5c0ef1fcf9)IconIDAsString
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderLayerVM.IconIDAsString | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#a8732ebcd0899b8865ff4b37e5377a364)Color1
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Library.Color](struct_tale_worlds_1_1_library_1_1_color.html) TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderLayerVM.Color1 | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#a8bd8f14318203c3033ed4b580bfa5579)Color2
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Library.Color](struct_tale_worlds_1_1_library_1_1_color.html) TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderLayerVM.Color2 | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#a2546bb79135e952274c409e828a19396)Color1AsStr
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderLayerVM.Color1AsStr | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#a633ff78703a082e5140ea9ba19882c41)Color2AsStr
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderLayerVM.Color2AsStr | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#aad323c9e94260a1e1a02258225a15eae)PositionValue
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Library.Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderLayerVM.PositionValue | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#a4f80d02bc0696e1c7a743028b50778c9)PositionValueX
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderLayerVM.PositionValueX | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#a20afd04dfdda31090b4343b6f1bde0f3)PositionValueY
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderLayerVM.PositionValueY | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#a8bc86c82337aeb344007ec26ea810952)SizeValue
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Library.Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderLayerVM.SizeValue | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#a5137943ee217bbe2890a2eff5a469309)SizeValueX
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderLayerVM.SizeValueX | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html#ae263455571f307c2d5b443a70b6ee024)SizeValueY
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderLayerVM.SizeValueY | | getset |

