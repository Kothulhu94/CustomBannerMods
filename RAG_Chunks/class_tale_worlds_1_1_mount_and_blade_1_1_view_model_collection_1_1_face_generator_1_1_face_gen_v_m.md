--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html ---

TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Classes | |
| struct | [GenderBasedSelectedValue](struct_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen365ffad5912cd3fbef0e5a89f97b260b.html) |

|  |  |
| --- | --- |
| Public Types | |
| enum | [FaceGenTabs](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ac63120e4232b6882e45a9c0ba9de2dff) : int {     [None](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ac63120e4232b6882e45a9c0ba9de2dffa6adf97f83acf6453d4a6a4b1070f3754) = -1 ,     [Body](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ac63120e4232b6882e45a9c0ba9de2dffaac101b32dda4448cf13a93fe283dddd8) ,     [Face](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ac63120e4232b6882e45a9c0ba9de2dffa8af5861002f3c157f9ba842bba10aa3f) ,     [Eyes](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ac63120e4232b6882e45a9c0ba9de2dffaae6e9b63e87076a8c0188b659ab93a28) ,     [Nose](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ac63120e4232b6882e45a9c0ba9de2dffa4432170f33a27181720d70ee7d6d2dee) ,     [Mouth](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ac63120e4232b6882e45a9c0ba9de2dffad39f272ab2d5fa9230e90da7b1547655) ,     [Hair](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ac63120e4232b6882e45a9c0ba9de2dffac2ad21c07984f2ba47de12b7e88766e3) ,     [Taint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ac63120e4232b6882e45a9c0ba9de2dffa0f13555d1a84eb63891f4d5f3ebf9846) ,     [NumOfFaceGenTabs](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ac63120e4232b6882e45a9c0ba9de2dffadb92ee5235bb3e2bb1dd80610df34de2)   } |
| enum | [Presets](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#aae95708613950a5cbbdce89c9e74f601) : int {     [Gender](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#aae95708613950a5cbbdce89c9e74f601a019ec3132cdf8ee0f2e2a75cf5d3e459) = -1 ,     [FacePresets](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#aae95708613950a5cbbdce89c9e74f601a61add889344bf6b0c228adb1d1f267a2) = -2 ,     [FaceType](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#aae95708613950a5cbbdce89c9e74f601ab9fea885953d7dd57643fc4c28516d55) = -3 ,     [EyePresets](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#aae95708613950a5cbbdce89c9e74f601a4c6596b49ac894e52f6dff46a65f51b9) = -4 ,     [HairBeardPreset](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#aae95708613950a5cbbdce89c9e74f601a43f0a02eee721dddbc68745c7a1e9e4a) = -5 ,     [HairType](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#aae95708613950a5cbbdce89c9e74f601a9caf53766fc41dfc255e21dcae07aab1) = -6 ,     [BeardType](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#aae95708613950a5cbbdce89c9e74f601af0f17d43162b1b3e9708346bfc6a2676) = -7 ,     [TaintPresets](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#aae95708613950a5cbbdce89c9e74f601a5c80ed2b1f116b3bfafcd1013aef0fc1) = -8 ,     [SoundPresets](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#aae95708613950a5cbbdce89c9e74f601a13a6239fc27198000e6a2ae16c764a62) = -9 ,     [TaintType](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#aae95708613950a5cbbdce89c9e74f601aa40cdf1c8036e2d7f13bbe8ab348b0d6) = -10 ,     [Age](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#aae95708613950a5cbbdce89c9e74f601a9d8d2d5ab12b515182a505f54db7f538) = -11 ,     [EyeColor](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#aae95708613950a5cbbdce89c9e74f601a1f8a6be9d3ee7d390758cf02ac10c4a3) = -12 ,     [HairAndBeardColor](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#aae95708613950a5cbbdce89c9e74f601ac399230b78f4dc197b1793d8082a8192) = -13 ,     [TeethType](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#aae95708613950a5cbbdce89c9e74f601ac268918309216d1bf18425032534a986) = -14 ,     [EyebrowType](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#aae95708613950a5cbbdce89c9e74f601ac2834a8bb43fcebc3e890ca8ae439a6b) = -15 ,     [Scale](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#aae95708613950a5cbbdce89c9e74f601a85a7cd587d6142dbfc1a4de05af7b75d) = -16 ,     [Weight](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#aae95708613950a5cbbdce89c9e74f601a8c489d0946f66d17d73f26366a4bf620) = -17 ,     [Build](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#aae95708613950a5cbbdce89c9e74f601ac74c1f42f141c011ca6bd8b1114fc3d0) = -18 ,     [Pitch](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#aae95708613950a5cbbdce89c9e74f601a87f800274a7f46c50e17114f89171e2e) = -19 ,     [Race](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#aae95708613950a5cbbdce89c9e74f601a4e221fc084bb69a82315a154d6dd7879) = -20   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [SetFaceGenerationParams](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a91058e0382a1495fb267e05f5afccc9e) ([FaceGenerationParams](struct_tale_worlds_1_1_mount_and_blade_1_1_face_generation_params.html) faceGenerationParams) |
|  | [FaceGenVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ae5173288edddecf021d4c3cedfa68169) ([BodyGenerator](class_tale_worlds_1_1_mount_and_blade_1_1_body_generator.html) bodyGenerator, [IFaceGeneratorHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_face_generator_handler.html) faceGeneratorScreen, Action< float > onHeightChanged, Action onAgeChanged, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) affirmitiveText, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) negativeText, int currentStageIndex, int totalStagesCount, int furthestIndex, Action< int > goToIndex, bool canChangeGender, bool openedFromMultiplayer, [IFaceGeneratorCustomFilter](interface_tale_worlds_1_1_core_1_1_i_face_generator_custom_filter.html) filter) |
| override void | [RefreshValues](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a67de675608e71f9f64746a1302bc89d6) () |
|  | Used for updating localized texts. |
| void | [InitializeHistory](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ace2e3fe5be15922ab6305d11c0bfd080) ([FaceGenHistory](class_tale_worlds_1_1_core_1_1_face_gen_history.html) faceGenHistory) |
| void | [OnTabClicked](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#afebbc2493e77ed58533b1204df9c6762) (int index) |
| void | [SelectPreviousTab](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#aef3374b20c34af44ab909c0d31c83674) () |
| void | [SelectNextTab](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a9bbfc2a893fa2860ff27ae356225b794) () |
| void | [Refresh](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a4cac15590e012702923e907d31ca8263) (bool clearProperties) |
| void | [ExecuteHearCurrentVoiceSample](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a14e3d9f1e609281cbb5880d62bb2a76b) () |
| void | [ExecuteReset](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a2c4a19e2c33092a1023e8c47e7169d82) () |
| void | [ExecuteResetAll](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a97789c64d0e2a446a889e7aaaee7bf29) () |
| void | [ExecuteRandomize](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ac3c708334bf8ec94108ea2deacf3af07) () |
| void | [ExecuteRandomizeAll](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a12a34ee0b3d529f36aec23dea9d4730a) () |
| void | [ExecuteCancel](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ac3b468b59b1a310f5364b81a11d43056) () |
| void | [ExecuteDone](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a61c49685cd61d3b9b2a4cae02be7e129) () |
| void | [ExecuteRedo](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a15780e05a0a2a713781ce5d9f070fed3) () |
| void | [ExecuteUndo](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a6a31ede24e3874a371053d01b35d427f) () |
| void | [ExecuteChangeClothing](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a273466b5a4ac0ef040bd925a6f026a00) () |
| void | [AddCommand](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a1bdf0d56ace104cfc4073c5d46edeb1b) () |
| void | [SetBodyProperties](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a4fe5620a184cf9650d26c5a3340e564c) ([BodyProperties](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ac1d98c9e35f6a98d48730e029678c70e) bodyProperties, bool ignoreDebugValues, int race=0, int gender=-1, bool recordChange=false) |
| void | [UpdateFacegen](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a4a5df54e2c6eef426f7d84a9a32b0860) () |
| override void | [OnFinalize](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a088bee91d1d5f790eea2cd7abe6b9381) () |
| void | [SetCancelInputKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a8d9e454b1a29af56dd42731985bcdb93) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [SetDoneInputKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#afa4cda9f54065d4d897656d5076e7e2f) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [SetPreviousTabInputKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a179fbc60d0873b92637b92932cab2731) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [SetNextTabInputKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a11893e50fc0f819ad2cca2f069b1f160) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [AddCameraControlInputKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a21b940b00943a6438a7d2aa1e9351eb4) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [AddCameraControlInputKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a156e43fb5962220233cbd3fa229b1fee) ([GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) gameKey) |
| void | [AddCameraControlInputKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a19d143af99e89b623471c6e7d7149737) ([GameAxisKey](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html) gameAxisKey) |
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
| [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [CancelInputKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a1e8f406e3cf64ae2b709afe6d22ff670) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [DoneInputKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ac0d71d560f2920fd25ac41e689538745) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [PreviousTabInputKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ab3e11f0a39b8e6b5537e6cf3dfb7dee2) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [NextTabInputKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ae0a6e8ed08f2527e3f627d78b5db4c88) `[get, set]` |
| MBBindingList< [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) > | [CameraControlKeys](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a0584cb6a744a3fc9d9e6eaa3664c578d) `[get, set]` |
| bool | [AreAllTabsEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a41908411f34a7376c58323718ee03f6d) `[get]` |
| bool | [IsBodyEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#acb4ccad2211622bb7af2c762155c9aa4) `[get, set]` |
| bool | [IsFaceEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a52fbfa7d01028c64af73dab65ca58bbf) `[get, set]` |
| bool | [IsEyesEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#aa8ed0b4d13baca66e809738bcdb91477) `[get, set]` |
| bool | [IsNoseEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a88a3044b1e5fa157c749453a1980f39f) `[get, set]` |
| bool | [IsMouthEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ae06587ba5fe76a710a2f32c125e0e0f4) `[get, set]` |
| bool | [IsHairEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a759e4b1b1eabc900aad8b1f68617cfa3) `[get, set]` |
| bool | [IsTaintEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a49008938fef6605b2c7efd81be7c33fc) `[get, set]` |
| string | [FlipHairLbl](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#aa1f9004c769dee2a28b84fa058ef4f90) `[get, set]` |
| string | [SkinColorLbl](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a33ebefc7aae4d0f773bc82b61decb3b8) `[get, set]` |
| string | [RaceLbl](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ad9ed05f5b938aed48d7e8220c6a0a1d3) `[get, set]` |
| string | [GenderLbl](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ac8f351230dd5db4bf0e80aa8d0f92352) `[get, set]` |
| string | [CancelBtnLbl](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a0f9ed94db709aebe2536cb5861d6739e) `[get, set]` |
| string | [DoneBtnLbl](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a531fba4020ea47b0bdf7aba9d12561d3) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [BodyHint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a70335a8ba9d24a570fcc6a4432562939) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [FaceHint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#af4fe961765f73dedee9e8df42f6e9672) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [EyesHint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a3395e7e3a852d3eb611d2e89e0a18da3) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [NoseHint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#acb80a2a4ae855a7f0ae969dd20891cb5) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [HairHint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#aa25f08f1a7f38bf6614a1be99180041d) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [TaintHint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ab75cd135b1ca09122739fb517fda4fa6) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [MouthHint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a4355e1c8e71e0c649844d22f1410813d) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [RedoHint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#abb693ced3220e5bb96b86bc2e00199c3) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [UndoHint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a84ce1ab35dc05425604c3dfac6dac0f3) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [RandomizeHint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a499bffcf671cd774a078142199dec9dd) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [RandomizeAllHint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a00d05d9fbc7a336dd31c93f5ca050ad7) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [ResetHint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ac2f98e6106da4465119d2d2dcf076523) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [ResetAllHint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a8d4692c2510c866c770728d089e18340) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [ClothHint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#af97eb9d12d049e479b45ec23c2dfcd97) `[get, set]` |
| int | [HairNum](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#aaf267b6b70a6859e4a6be91bf5a713f0) `[get, set]` |
| SelectorVM< [SelectorItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_selector_1_1_selector_item_v_m.html) > | [SkinColorSelector](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a88cf095efa80adacbf5e4720d0571ff3) `[get, set]` |
| SelectorVM< [SelectorItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_selector_1_1_selector_item_v_m.html) > | [HairColorSelector](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ae4180087d301f3c660c5146ccf62630a) `[get, set]` |
| SelectorVM< [SelectorItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_selector_1_1_selector_item_v_m.html) > | [TattooColorSelector](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ac058ba61f67e5bf3c975aac862762ba1) `[get, set]` |
| SelectorVM< [SelectorItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_selector_1_1_selector_item_v_m.html) > | [RaceSelector](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a4348aba2b7e225a486603a836a9c6ff3) `[get, set]` |
| int | [Tab](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#aa6dc720e7254c921ff3ae13bc8badd4b) `[get, set]` |
| int | [SelectedGender](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a035b5086ea55c535627ec9f0eb284bee) `[get, set]` |
| bool | [IsFemale](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a889a661f0578cf6944237d4386009ff6) `[get]` |
| MBBindingList< [FaceGenPropertyVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html) > | [BodyProperties](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ac1d98c9e35f6a98d48730e029678c70e) `[get, set]` |
| bool | [CanChangeGender](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a1acbcada4d43959243e9cba8dbcff40d) `[get, set]` |
| bool | [CanChangeRace](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ac6d7381ea3b38bc07dc361146238db8e) `[get, set]` |
| bool | [IsUndoEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#aba19e6ce74a8cfe5e2896607036cb5c6) `[get, set]` |
| bool | [IsRedoEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ace2ef450f45a0d86c92b8d7560252484) `[get, set]` |
| MBBindingList< [FaceGenPropertyVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html) > | [FaceProperties](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a82a122ddddd442c17152313952b1ad43) `[get, set]` |
| MBBindingList< [FaceGenPropertyVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html) > | [EyesProperties](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a8ba3bff525256326715d2c63e1239735) `[get, set]` |
| MBBindingList< [FaceGenPropertyVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html) > | [NoseProperties](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a31b08b29ce7a443afe1282bbea701939) `[get, set]` |
| MBBindingList< [FaceGenPropertyVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html) > | [MouthProperties](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a1f823160558c21fad959b3b48ff3df9f) `[get, set]` |
| MBBindingList< [FaceGenPropertyVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html) > | [HairProperties](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ac13606b668f0719581927c20b3c4c771) `[get, set]` |
| MBBindingList< [FaceGenPropertyVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html) > | [TaintProperties](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#acfb54c339e4ac0eb40b02a8d8bde1c9f) `[get, set]` |
| MBBindingList< [FacegenListItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_facegen_list_item_v_m.html) > | [TaintTypes](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a4995f7064041e691ddeb1eea9279a0e1) `[get, set]` |
| MBBindingList< [FacegenListItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_facegen_list_item_v_m.html) > | [BeardTypes](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a202d82e9a34ce5e64675876f4f085759) `[get, set]` |
| MBBindingList< [FacegenListItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_facegen_list_item_v_m.html) > | [HairTypes](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#adeb0591aaa33c10a74bfedfce4804c7e) `[get, set]` |
| [FaceGenPropertyVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html) | [SoundPreset](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a67f07934c32870dc1f8a12b49974d0cc) `[get, set]` |
| [FaceGenPropertyVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html) | [EyebrowTypes](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a57ae239fd0148b856e9f970ccef403bf) `[get, set]` |
| [FaceGenPropertyVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html) | [TeethTypes](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a41340269244b2b1456a868fe5a045013) `[get, set]` |
| bool | [FlipHairCb](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a793ed9a875b49880c8e46a6f6a3447c4) `[get, set]` |
| bool | [IsDressed](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ac7e385bdf30d6f8f9f55644e3b20c21e) `[get, set]` |
| bool | [CharacterGamepadControlsEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ac6efb87411d09e03776ca9588e0dd2b9) `[get, set]` |
| [FaceGenPropertyVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html) | [FaceTypes](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a3e4e7fab9904298b7422516179446373) `[get, set]` |
| string | [Title](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a459fe0dd6ca439f1a9f14291b599ea0e) `[get, set]` |
| int | [TotalStageCount](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a7c34abbfeaf2d65de02b482bc7891577) `[get, set]` |
| int | [CurrentStageIndex](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a5c5fcada4ae0389b7958d84b633ae822) `[get, set]` |
| int | [FurthestIndex](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a52b25a46702b0332ae2edade9b763168) `[get, set]` |

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

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ac63120e4232b6882e45a9c0ba9de2dff)FaceGenTabs
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.FaceGenTabs](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ac63120e4232b6882e45a9c0ba9de2dff) : int |

| Enumerator | |
| --- | --- |
| None |  |
| Body |  |
| Face |  |
| Eyes |  |
| Nose |  |
| Mouth |  |
| Hair |  |
| Taint |  |
| NumOfFaceGenTabs |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#aae95708613950a5cbbdce89c9e74f601)Presets
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.Presets](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#aae95708613950a5cbbdce89c9e74f601) : int |

| Enumerator | |
| --- | --- |
| Gender |  |
| FacePresets |  |
| FaceType |  |
| EyePresets |  |
| HairBeardPreset |  |
| HairType |  |
| BeardType |  |
| TaintPresets |  |
| SoundPresets |  |
| TaintType |  |
| Age |  |
| EyeColor |  |
| HairAndBeardColor |  |
| TeethType |  |
| EyebrowType |  |
| Scale |  |
| Weight |  |
| Build |  |
| Pitch |  |
| Race |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ae5173288edddecf021d4c3cedfa68169)FaceGenVM()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.FaceGenVM | ( | [BodyGenerator](class_tale_worlds_1_1_mount_and_blade_1_1_body_generator.html) | *bodyGenerator*, |
|  |  | [IFaceGeneratorHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_face_generator_handler.html) | *faceGeneratorScreen*, |
|  |  | Action< float > | *onHeightChanged*, |
|  |  | Action | *onAgeChanged*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *affirmitiveText*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *negativeText*, |
|  |  | int | *currentStageIndex*, |
|  |  | int | *totalStagesCount*, |
|  |  | int | *furthestIndex*, |
|  |  | Action< int > | *goToIndex*, |
|  |  | bool | *canChangeGender*, |
|  |  | bool | *openedFromMultiplayer*, |
|  |  | [IFaceGeneratorCustomFilter](interface_tale_worlds_1_1_core_1_1_i_face_generator_custom_filter.html) | *filter* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a91058e0382a1495fb267e05f5afccc9e)SetFaceGenerationParams()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.SetFaceGenerationParams | ( | [FaceGenerationParams](struct_tale_worlds_1_1_mount_and_blade_1_1_face_generation_params.html) | *faceGenerationParams* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a67de675608e71f9f64746a1302bc89d6)RefreshValues()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ace2e3fe5be15922ab6305d11c0bfd080)InitializeHistory()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.InitializeHistory | ( | [FaceGenHistory](class_tale_worlds_1_1_core_1_1_face_gen_history.html) | *faceGenHistory* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#afebbc2493e77ed58533b1204df9c6762)OnTabClicked()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.OnTabClicked | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#aef3374b20c34af44ab909c0d31c83674)SelectPreviousTab()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.SelectPreviousTab | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a9bbfc2a893fa2860ff27ae356225b794)SelectNextTab()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.SelectNextTab | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a4cac15590e012702923e907d31ca8263)Refresh()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.Refresh | ( | bool | *clearProperties* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a14e3d9f1e609281cbb5880d62bb2a76b)ExecuteHearCurrentVoiceSample()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.ExecuteHearCurrentVoiceSample | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a2c4a19e2c33092a1023e8c47e7169d82)ExecuteReset()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.ExecuteReset | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a97789c64d0e2a446a889e7aaaee7bf29)ExecuteResetAll()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.ExecuteResetAll | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ac3c708334bf8ec94108ea2deacf3af07)ExecuteRandomize()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.ExecuteRandomize | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a12a34ee0b3d529f36aec23dea9d4730a)ExecuteRandomizeAll()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.ExecuteRandomizeAll | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ac3b468b59b1a310f5364b81a11d43056)ExecuteCancel()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.ExecuteCancel | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a61c49685cd61d3b9b2a4cae02be7e129)ExecuteDone()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.ExecuteDone | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a15780e05a0a2a713781ce5d9f070fed3)ExecuteRedo()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.ExecuteRedo | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a6a31ede24e3874a371053d01b35d427f)ExecuteUndo()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.ExecuteUndo | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a273466b5a4ac0ef040bd925a6f026a00)ExecuteChangeClothing()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.ExecuteChangeClothing | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a1bdf0d56ace104cfc4073c5d46edeb1b)AddCommand()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.AddCommand | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a4fe5620a184cf9650d26c5a3340e564c)SetBodyProperties()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.SetBodyProperties | ( | [BodyProperties](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ac1d98c9e35f6a98d48730e029678c70e) | *bodyProperties*, |
|  |  | bool | *ignoreDebugValues*, |
|  |  | int | *race* = 0, |
|  |  | int | *gender* = -1, |
|  |  | bool | *recordChange* = false ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a4a5df54e2c6eef426f7d84a9a32b0860)UpdateFacegen()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.UpdateFacegen | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a088bee91d1d5f790eea2cd7abe6b9381)OnFinalize()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a8d9e454b1a29af56dd42731985bcdb93)SetCancelInputKey()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.SetCancelInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#afa4cda9f54065d4d897656d5076e7e2f)SetDoneInputKey()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.SetDoneInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a179fbc60d0873b92637b92932cab2731)SetPreviousTabInputKey()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.SetPreviousTabInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a11893e50fc0f819ad2cca2f069b1f160)SetNextTabInputKey()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.SetNextTabInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a21b940b00943a6438a7d2aa1e9351eb4)AddCameraControlInputKey() [1/3]
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.AddCameraControlInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a156e43fb5962220233cbd3fa229b1fee)AddCameraControlInputKey() [2/3]
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.AddCameraControlInputKey | ( | [GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) | *gameKey* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a19d143af99e89b623471c6e7d7149737)AddCameraControlInputKey() [3/3]
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.AddCameraControlInputKey | ( | [GameAxisKey](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html) | *gameAxisKey* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a1e8f406e3cf64ae2b709afe6d22ff670)CancelInputKey
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.CancelInputKey | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ac0d71d560f2920fd25ac41e689538745)DoneInputKey
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.DoneInputKey | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ab3e11f0a39b8e6b5537e6cf3dfb7dee2)PreviousTabInputKey
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.PreviousTabInputKey | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ae0a6e8ed08f2527e3f627d78b5db4c88)NextTabInputKey
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.NextTabInputKey | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a0584cb6a744a3fc9d9e6eaa3664c578d)CameraControlKeys
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html)> TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.CameraControlKeys | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a41908411f34a7376c58323718ee03f6d)AreAllTabsEnabled
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.AreAllTabsEnabled | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#acb4ccad2211622bb7af2c762155c9aa4)IsBodyEnabled
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.IsBodyEnabled | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a52fbfa7d01028c64af73dab65ca58bbf)IsFaceEnabled
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.IsFaceEnabled | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#aa8ed0b4d13baca66e809738bcdb91477)IsEyesEnabled
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.IsEyesEnabled | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a88a3044b1e5fa157c749453a1980f39f)IsNoseEnabled
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.IsNoseEnabled | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ae06587ba5fe76a710a2f32c125e0e0f4)IsMouthEnabled
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.IsMouthEnabled | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a759e4b1b1eabc900aad8b1f68617cfa3)IsHairEnabled
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.IsHairEnabled | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a49008938fef6605b2c7efd81be7c33fc)IsTaintEnabled
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.IsTaintEnabled | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#aa1f9004c769dee2a28b84fa058ef4f90)FlipHairLbl
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.FlipHairLbl | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a33ebefc7aae4d0f773bc82b61decb3b8)SkinColorLbl
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.SkinColorLbl | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ad9ed05f5b938aed48d7e8220c6a0a1d3)RaceLbl
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.RaceLbl | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ac8f351230dd5db4bf0e80aa8d0f92352)GenderLbl
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.GenderLbl | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a0f9ed94db709aebe2536cb5861d6739e)CancelBtnLbl
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.CancelBtnLbl | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a531fba4020ea47b0bdf7aba9d12561d3)DoneBtnLbl
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.DoneBtnLbl | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a70335a8ba9d24a570fcc6a4432562939)BodyHint
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.BodyHint | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#af4fe961765f73dedee9e8df42f6e9672)FaceHint
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.FaceHint | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a3395e7e3a852d3eb611d2e89e0a18da3)EyesHint
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.EyesHint | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#acb80a2a4ae855a7f0ae969dd20891cb5)NoseHint
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.NoseHint | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#aa25f08f1a7f38bf6614a1be99180041d)HairHint
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.HairHint | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ab75cd135b1ca09122739fb517fda4fa6)TaintHint
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.TaintHint | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a4355e1c8e71e0c649844d22f1410813d)MouthHint
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.MouthHint | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#abb693ced3220e5bb96b86bc2e00199c3)RedoHint
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.RedoHint | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a84ce1ab35dc05425604c3dfac6dac0f3)UndoHint
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.UndoHint | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a499bffcf671cd774a078142199dec9dd)RandomizeHint
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.RandomizeHint | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a00d05d9fbc7a336dd31c93f5ca050ad7)RandomizeAllHint
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.RandomizeAllHint | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ac2f98e6106da4465119d2d2dcf076523)ResetHint
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.ResetHint | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a8d4692c2510c866c770728d089e18340)ResetAllHint
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.ResetAllHint | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#af97eb9d12d049e479b45ec23c2dfcd97)ClothHint
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.ClothHint | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#aaf267b6b70a6859e4a6be91bf5a713f0)HairNum
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.HairNum | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a88cf095efa80adacbf5e4720d0571ff3)SkinColorSelector
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | SelectorVM<[SelectorItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_selector_1_1_selector_item_v_m.html)> TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.SkinColorSelector | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ae4180087d301f3c660c5146ccf62630a)HairColorSelector
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | SelectorVM<[SelectorItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_selector_1_1_selector_item_v_m.html)> TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.HairColorSelector | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ac058ba61f67e5bf3c975aac862762ba1)TattooColorSelector
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | SelectorVM<[SelectorItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_selector_1_1_selector_item_v_m.html)> TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.TattooColorSelector | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a4348aba2b7e225a486603a836a9c6ff3)RaceSelector
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | SelectorVM<[SelectorItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_selector_1_1_selector_item_v_m.html)> TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.RaceSelector | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#aa6dc720e7254c921ff3ae13bc8badd4b)Tab
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.Tab | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a035b5086ea55c535627ec9f0eb284bee)SelectedGender
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.SelectedGender | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a889a661f0578cf6944237d4386009ff6)IsFemale
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.IsFemale | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ac1d98c9e35f6a98d48730e029678c70e)BodyProperties
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[FaceGenPropertyVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html)> TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.BodyProperties | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a1acbcada4d43959243e9cba8dbcff40d)CanChangeGender
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.CanChangeGender | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ac6d7381ea3b38bc07dc361146238db8e)CanChangeRace
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.CanChangeRace | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#aba19e6ce74a8cfe5e2896607036cb5c6)IsUndoEnabled
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.IsUndoEnabled | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ace2ef450f45a0d86c92b8d7560252484)IsRedoEnabled
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.IsRedoEnabled | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a82a122ddddd442c17152313952b1ad43)FaceProperties
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[FaceGenPropertyVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html)> TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.FaceProperties | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a8ba3bff525256326715d2c63e1239735)EyesProperties
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[FaceGenPropertyVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html)> TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.EyesProperties | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a31b08b29ce7a443afe1282bbea701939)NoseProperties
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[FaceGenPropertyVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html)> TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.NoseProperties | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a1f823160558c21fad959b3b48ff3df9f)MouthProperties
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[FaceGenPropertyVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html)> TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.MouthProperties | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ac13606b668f0719581927c20b3c4c771)HairProperties
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[FaceGenPropertyVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html)> TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.HairProperties | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#acfb54c339e4ac0eb40b02a8d8bde1c9f)TaintProperties
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[FaceGenPropertyVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html)> TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.TaintProperties | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a4995f7064041e691ddeb1eea9279a0e1)TaintTypes
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[FacegenListItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_facegen_list_item_v_m.html)> TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.TaintTypes | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a202d82e9a34ce5e64675876f4f085759)BeardTypes
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[FacegenListItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_facegen_list_item_v_m.html)> TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.BeardTypes | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#adeb0591aaa33c10a74bfedfce4804c7e)HairTypes
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[FacegenListItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_facegen_list_item_v_m.html)> TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.HairTypes | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a67f07934c32870dc1f8a12b49974d0cc)SoundPreset
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [FaceGenPropertyVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.SoundPreset | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a57ae239fd0148b856e9f970ccef403bf)EyebrowTypes
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [FaceGenPropertyVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.EyebrowTypes | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a41340269244b2b1456a868fe5a045013)TeethTypes
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [FaceGenPropertyVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.TeethTypes | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a793ed9a875b49880c8e46a6f6a3447c4)FlipHairCb
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.FlipHairCb | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ac7e385bdf30d6f8f9f55644e3b20c21e)IsDressed
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.IsDressed | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#ac6efb87411d09e03776ca9588e0dd2b9)CharacterGamepadControlsEnabled
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.CharacterGamepadControlsEnabled | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a3e4e7fab9904298b7422516179446373)FaceTypes
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [FaceGenPropertyVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.FaceTypes | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a459fe0dd6ca439f1a9f14291b599ea0e)Title
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.Title | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a7c34abbfeaf2d65de02b482bc7891577)TotalStageCount
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.TotalStageCount | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a5c5fcada4ae0389b7958d84b633ae822)CurrentStageIndex
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.CurrentStageIndex | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html#a52b25a46702b0332ae2edade9b763168)FurthestIndex
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenVM.FurthestIndex | | getset |

