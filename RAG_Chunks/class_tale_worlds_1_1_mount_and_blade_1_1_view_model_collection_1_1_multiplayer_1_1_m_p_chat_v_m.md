--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html ---

TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html), and IChatHandler.

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MPChatVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a121fea212db81557b62f73933cba6010) () |
| override void | [RefreshValues](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a48bc3c7b39de3223ceb433ab7f4e4fb6) () |
|  | Used for updating localized texts. |
| void | [ToggleIncludeCombatLog](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a6b1601408bbbf9b558248fe94e8c03c2) () |
| void | [ExecuteToggleIncludeShouts](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a1823ecf322e4b3eb11a0b1fc8ba6a5d8) () |
| void | [Tick](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a710da1412e6179a180d8bfd613e2dd1a) (float dt) |
| void | [Hide](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#acd0cb02d62d4c4b62be814cbd2021f74) () |
| void | [Clear](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a0df34b6b7c3fc01e630f5be587c6eee1) () |
| void | [UpdateObjects](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#aab63219af171b7da7fee358f0312839e) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game, [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission) |
| override void | [OnFinalize](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a7e0552fdcedaf7a05c6d3469a73e5dde) () |
| void | [SendMessageToChannel](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#aaeb60ae55fe90ecd0e7c0e6558edbbce) (ChatChannelType channel, string message) |
| void | [CheckChatFading](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#add59c3114339a6ab098f16f602cb9414) (float dt) |
| void | [SetChatDisabledStateChangedCallback](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a745f138b38459b86b4010c6c3b6a3245) (Action< bool > onChatDisabledStateChanged) |
| void | [SetGetKeyTextFromKeyIDFunc](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a5256882d46d2e61e097e3e51b818439e) (Func< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > getToggleChatKeyText) |
| void | [SetGetCycleChannelKeyTextFunc](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#ad346b4cd3aa0850d7f921620eda1ec5f) (Func< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > getCycleChannelsKeyText) |
| void | [SetGetSendMessageKeyTextFunc](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a00fa95e153da6cc785bc14559fd5b36e) (Func< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > getSendMessageKeyText) |
| void | [SetGetCancelSendingKeyTextFunc](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#af3950fea986bbff5553e0dc9638df3ea) (Func< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > getCancelSendingKeyText) |
| bool | [IsChatAllowedByOptions](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#ae0e4f3e60fab16afc2e32ebf3fada03e) () |
| void | [TypeToChannelAll](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#aa768b544af8cbce63675ad651537f575) (bool startTyping=false) |
| void | [TypeToChannelTeam](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a3e47a236e4abd0b3a262b87fde8e13c7) (bool startTyping=false) |
| void | [StartInspectingMessages](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#ad1a8a65369151b654b3acc3b678b651e) () |
| void | [StopInspectingMessages](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#af3d26f62d291092725829e26f118fbb4) () |
| void | [StartTyping](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#ab2a9bea6a23bbc3199838caa3ff70e9a) () |
| void | [StopTyping](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#ad8ac8156449e305e7f16c53215545db2) (bool resetWrittenText=false) |
| void | [SendCurrentlyTypedMessage](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#aa0e9cb45a8bcbbc7c0cf8804a0e5e4ea) () |
| void | [ExecuteSaveSizes](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a275bd3628ab4250f6ecae5525aa71357) () |
| void | [SetMessageHistoryCapacity](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a73ac1c4ad6342272026bf2e6b12e1452) (int capacity) |
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
| Static Public Attributes | |
| const string | [DefaultCategory](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a5d536030abb16d209e2063cd95da241f) = "Default" |
| const string | [CombatCategory](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#af627e10022693f36d85902387ef53ccd) = "Combat" |
| const string | [SocialCategory](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#ac8c1d70fa129afa443808cd4301a47ef) = "Social" |
| const string | [BarkCategory](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#ad8f696661ab7ff539202ae1ff2fe6422) = "Bark" |
| Static Public Attributes inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static bool | [UIDebugMode](class_tale_worlds_1_1_library_1_1_view_model.html#a14668e8bcc887c0a2edfa9593be97fe5) |

|  |  |
| --- | --- |
| Properties | |
| ChatChannelType | [ActiveChannelType](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a07d1a35652f1115547979b96082540b2) `[get, set]` |
| float | [ChatBoxSizeX](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a1a611053baf171844008aa290388751c) `[get, set]` |
| float | [ChatBoxSizeY](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a6ce6b533771ccb80343695119329c4ff) `[get, set]` |
| int | [MaxMessageLength](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#aa04ad00791bcb790cc52fb0ef85bb2b7) `[get, set]` |
| bool | [IsTypingText](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#aa6b38543871c269bd7bf18b1fda83696) `[get, set]` |
| bool | [IsInspectingMessages](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a7a3707485fdbd1a0dec15106774f10e5) `[get, set]` |
| bool | [IsChatDisabled](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#ae8b45846809c205665a9a058ac080b3b) `[get, set]` |
| bool | [ShowHideShowHint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a697f442c4fe1818438d56a571e3a9c06) `[get, set]` |
| bool | [IsOptionsAvailable](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#ab4affd7c4c23adab03da450a84936019) `[get, set]` |
| bool | [ShouldHaveOffset](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a18b9c27144ed3093dac8df215d9efa1f) `[get, set]` |
| string | [WrittenText](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a8292669741b013de673247399d4b6b4e) `[get, set]` |
| [Color](struct_tale_worlds_1_1_library_1_1_color.html) | [ActiveChannelColor](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a98e0094fdccff60a57f695791d7cd5a8) `[get, set]` |
| string | [ActiveChannelNameText](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a7c39899f7a5e0c93d9fbbcce65e5cc68) `[get, set]` |
| string | [HideShowText](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#aaf3764468ca045dd471f99e830e88db9) `[get, set]` |
| string | [ToggleCombatLogText](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a47e6f38c2dd03bb4e45595d62a93c243) `[get, set]` |
| string | [ToggleBarkText](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a0b8708d043bae0b57c55b273d33f84d0) `[get, set]` |
| string | [CycleThroughChannelsText](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#af7ce0586c3ab1a30b8a4c85ad800cead) `[get, set]` |
| string | [SendMessageText](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#aceb61fe9e03883f9c367f76bce32cbf2) `[get, set]` |
| string | [CancelSendingText](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a34a3b274503d678637e71538179d2d28) `[get, set]` |
| MBBindingList< [MPChatLineVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_line_v_m.html) > | [MessageHistory](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#aa89fe18c83185d3df0e9fbe2d0c9d808) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [CombatLogHint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a71564c7960e6d3468777fb84d308a5e1) `[get, set]` |
| bool | [IncludeCombatLog](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a935aa38acf26d55692bdeb5ca5fac7d3) `[get, set]` |
| bool | [IncludeBark](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#aed3108342bfa0d6bc420474ceffacda6) `[get, set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static void | [RefreshPropertyAndMethodInfos](class_tale_worlds_1_1_library_1_1_view_model.html#af97f39f16f411d47a799f0544f96ede1) () |
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

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a121fea212db81557b62f73933cba6010)MPChatVM()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.MPChatVM | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a48bc3c7b39de3223ceb433ab7f4e4fb6)RefreshValues()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a6b1601408bbbf9b558248fe94e8c03c2)ToggleIncludeCombatLog()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.ToggleIncludeCombatLog | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a1823ecf322e4b3eb11a0b1fc8ba6a5d8)ExecuteToggleIncludeShouts()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.ExecuteToggleIncludeShouts | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a710da1412e6179a180d8bfd613e2dd1a)Tick()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.Tick | ( | float | *dt* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#acd0cb02d62d4c4b62be814cbd2021f74)Hide()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.Hide | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a0df34b6b7c3fc01e630f5be587c6eee1)Clear()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.Clear | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#aab63219af171b7da7fee358f0312839e)UpdateObjects()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.UpdateObjects | ( | [Game](class_tale_worlds_1_1_core_1_1_game.html) | *game*, |
|  |  | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | *mission* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a7e0552fdcedaf7a05c6d3469a73e5dde)OnFinalize()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#aaeb60ae55fe90ecd0e7c0e6558edbbce)SendMessageToChannel()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.SendMessageToChannel | ( | ChatChannelType | *channel*, |
|  |  | string | *message* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#add59c3114339a6ab098f16f602cb9414)CheckChatFading()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.CheckChatFading | ( | float | *dt* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a745f138b38459b86b4010c6c3b6a3245)SetChatDisabledStateChangedCallback()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.SetChatDisabledStateChangedCallback | ( | Action< bool > | *onChatDisabledStateChanged* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a5256882d46d2e61e097e3e51b818439e)SetGetKeyTextFromKeyIDFunc()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.SetGetKeyTextFromKeyIDFunc | ( | Func< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > | *getToggleChatKeyText* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#ad346b4cd3aa0850d7f921620eda1ec5f)SetGetCycleChannelKeyTextFunc()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.SetGetCycleChannelKeyTextFunc | ( | Func< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > | *getCycleChannelsKeyText* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a00fa95e153da6cc785bc14559fd5b36e)SetGetSendMessageKeyTextFunc()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.SetGetSendMessageKeyTextFunc | ( | Func< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > | *getSendMessageKeyText* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#af3950fea986bbff5553e0dc9638df3ea)SetGetCancelSendingKeyTextFunc()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.SetGetCancelSendingKeyTextFunc | ( | Func< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > | *getCancelSendingKeyText* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#ae0e4f3e60fab16afc2e32ebf3fada03e)IsChatAllowedByOptions()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.IsChatAllowedByOptions | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#aa768b544af8cbce63675ad651537f575)TypeToChannelAll()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.TypeToChannelAll | ( | bool | *startTyping* = false | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a3e47a236e4abd0b3a262b87fde8e13c7)TypeToChannelTeam()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.TypeToChannelTeam | ( | bool | *startTyping* = false | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#ad1a8a65369151b654b3acc3b678b651e)StartInspectingMessages()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.StartInspectingMessages | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#af3d26f62d291092725829e26f118fbb4)StopInspectingMessages()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.StopInspectingMessages | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#ab2a9bea6a23bbc3199838caa3ff70e9a)StartTyping()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.StartTyping | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#ad8ac8156449e305e7f16c53215545db2)StopTyping()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.StopTyping | ( | bool | *resetWrittenText* = false | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#aa0e9cb45a8bcbbc7c0cf8804a0e5e4ea)SendCurrentlyTypedMessage()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.SendCurrentlyTypedMessage | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a275bd3628ab4250f6ecae5525aa71357)ExecuteSaveSizes()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.ExecuteSaveSizes | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a73ac1c4ad6342272026bf2e6b12e1452)SetMessageHistoryCapacity()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.SetMessageHistoryCapacity | ( | int | *capacity* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a5d536030abb16d209e2063cd95da241f)DefaultCategory
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.DefaultCategory = "Default" | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#af627e10022693f36d85902387ef53ccd)CombatCategory
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.CombatCategory = "Combat" | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#ac8c1d70fa129afa443808cd4301a47ef)SocialCategory
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.SocialCategory = "Social" | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#ad8f696661ab7ff539202ae1ff2fe6422)BarkCategory
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.BarkCategory = "Bark" | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a07d1a35652f1115547979b96082540b2)ActiveChannelType
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ChatChannelType TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.ActiveChannelType | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a1a611053baf171844008aa290388751c)ChatBoxSizeX
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.ChatBoxSizeX | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a6ce6b533771ccb80343695119329c4ff)ChatBoxSizeY
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.ChatBoxSizeY | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#aa04ad00791bcb790cc52fb0ef85bb2b7)MaxMessageLength
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.MaxMessageLength | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#aa6b38543871c269bd7bf18b1fda83696)IsTypingText
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.IsTypingText | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a7a3707485fdbd1a0dec15106774f10e5)IsInspectingMessages
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.IsInspectingMessages | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#ae8b45846809c205665a9a058ac080b3b)IsChatDisabled
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.IsChatDisabled | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a697f442c4fe1818438d56a571e3a9c06)ShowHideShowHint
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.ShowHideShowHint | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#ab4affd7c4c23adab03da450a84936019)IsOptionsAvailable
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.IsOptionsAvailable | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a18b9c27144ed3093dac8df215d9efa1f)ShouldHaveOffset
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.ShouldHaveOffset | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a8292669741b013de673247399d4b6b4e)WrittenText
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.WrittenText | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a98e0094fdccff60a57f695791d7cd5a8)ActiveChannelColor
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Color](struct_tale_worlds_1_1_library_1_1_color.html) TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.ActiveChannelColor | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a7c39899f7a5e0c93d9fbbcce65e5cc68)ActiveChannelNameText
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.ActiveChannelNameText | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#aaf3764468ca045dd471f99e830e88db9)HideShowText
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.HideShowText | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a47e6f38c2dd03bb4e45595d62a93c243)ToggleCombatLogText
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.ToggleCombatLogText | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a0b8708d043bae0b57c55b273d33f84d0)ToggleBarkText
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.ToggleBarkText | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#af7ce0586c3ab1a30b8a4c85ad800cead)CycleThroughChannelsText
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.CycleThroughChannelsText | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#aceb61fe9e03883f9c367f76bce32cbf2)SendMessageText
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.SendMessageText | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a34a3b274503d678637e71538179d2d28)CancelSendingText
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.CancelSendingText | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#aa89fe18c83185d3df0e9fbe2d0c9d808)MessageHistory
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[MPChatLineVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_line_v_m.html)> TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.MessageHistory | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a71564c7960e6d3468777fb84d308a5e1)CombatLogHint
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.CombatLogHint | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#a935aa38acf26d55692bdeb5ca5fac7d3)IncludeCombatLog
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.IncludeCombatLog | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_multiplayer_1_1_m_p_chat_v_m.html#aed3108342bfa0d6bc420474ceffacda6)IncludeBark
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.Multiplayer.MPChatVM.IncludeBark | | getset |

