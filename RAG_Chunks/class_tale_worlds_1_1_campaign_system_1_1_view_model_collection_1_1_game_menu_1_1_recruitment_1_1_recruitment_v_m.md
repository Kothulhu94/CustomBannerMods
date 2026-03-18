--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [RecruitmentVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#aba0d3d3cb489878d4486cbc8fa36697e) () |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#aa6a46281e51031e5c404f839cf869455) () |
|  | Used for updating localized texts. |
| void | [RefreshScreen](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a3a8936a089ba22cb8c9148d2db0b4f14) () |
| void | [ExecuteDone](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a5a655b27ebf68e373703143da8315f78) () |
| void | [ExecuteForceQuit](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a104010b04fc41b25ec311962013abd4f) () |
| void | [ExecuteReset](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#ac93cdd1845c221d0e413a2a3a993d7dd) () |
| void | [ExecuteRecruitAll](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a06e7b814883279d982fe4bd956209252) () |
| void | [Deactivate](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a0a1aa2abee6199244c623985e4784eb4) () |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a0934555568c37c9ec18e065e6e116f65) () |
| void | [SetGetKeyTextFromKeyIDFunc](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#ac739facfd8ae0e3f439a32bc6b870e56) (Func< string, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > getKeyTextFromKeyId) |
| void | [SetCancelInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#ada9ccebfce53f6d0fd6833e9fbff9e36) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [SetDoneInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a3f2d244fa2770bf8118a6caa8c189e49) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [SetRecruitAllInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a56b9b40227f64ddfd842f1481315f1b3) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [SetResetInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a7e34186e14315aea61cfb08de554fd38) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
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
| bool | [IsQuitting](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a17c8eae1c36e9a464142dc41309e8a25) `[get]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [ResetHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a6b139da73f436dda65514820fbd9bd4e) `[get, set]` |
| [RecruitVolunteerTroopVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_troop_v_m.html) | [FocusedVolunteerTroop](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a3518a90c24683a7d786b4efb0fe445c6) `[get, set]` |
| [RecruitVolunteerOwnerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_owner_v_m.html) | [FocusedVolunteerOwner](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a698a84a57fbb47d7f0b37e18afbe62f9) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [PartyWageHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a34575f2772cffb44276c073c6103495b) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [PartyCapacityHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a8ee09b88ec3cdd7baf4a097e758004af) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [PartySpeedHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a7ac8fe8f4e2ba2031771b2c4e8f79c89) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [RemainingFoodHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a6a649fdf772fd8d738089ed860f5dca3) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [TotalWealthHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#ac7a946e7fe275c48a1a212b8cc2b4bc9) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [TotalCostHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a5da72cf3aab9edb10bbb315c546e2bdc) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [DoneHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a23ad5cc120b67bfb855bc6ff6c8c3ca5) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [RecruitAllHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#ae4b1f5eba5ece863476edf452ca093c1) `[get, set]` |
| int | [PartyWage](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#aba82e66d980289bb2aaa9a363e7d8361) `[get, set]` |
| string | [PartyCapacityText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a27026078ed652b1d3376c26e4092cc22) `[get, set]` |
| string | [PartyWageText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a28513eb0ac29bf5db81388143831e7c4) `[get, set]` |
| string | [RecruitAllText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#ac561dd9bb9a4101e8fb1ce8583dd9d0f) `[get, set]` |
| string | [PartySpeedText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#ad44ebb0f81522fe26bba57ed680033f6) `[get, set]` |
| string | [ResetAllText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a944e567d4a45e0b258c88f8abbbf5fcb) `[get, set]` |
| string | [CancelText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#af92d6df66919e2a256a2a79a60df187f) `[get, set]` |
| string | [RemainingFoodText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#afa7b1c25fd04abd654110b6b3bc559f4) `[get, set]` |
| string | [TotalCostText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a959bef3fa4cb7af91c6471b664c9c1b6) `[get, set]` |
| bool | [Enabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a58ade47b19df36657bababbb5c7938e3) `[get, set]` |
| bool | [IsDoneEnabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a2f63bfbfd69235e3098ae42f7f97c243) `[get, set]` |
| bool | [IsPartyCapacityWarningEnabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a9e52023fc51fd108fbf9b9583bfcf17a) `[get, set]` |
| string | [TitleText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a6287d7e96ddea9d007a60b1feed6c6d8) `[get, set]` |
| string | [DoneText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a0f7a6cd65f4be717d049381ab53c4c78) `[get, set]` |
| bool | [CanRecruitAll](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a44a83d05e2f534c59199bad99635bf8c) `[get, set]` |
| int | [TotalWealth](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a44a1499b8f26f8b5ea0b7c843be56634) `[get, set]` |
| int | [PartyCapacity](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a5e9be87c8e044353ee52e3b4e6c47601) `[get, set]` |
| int | [InitialPartySize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#ad23b273587a2e64745f8235a8f1c219b) `[get, set]` |
| int | [CurrentPartySize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#ad02481373f990257fd920d887e698d04) `[get, set]` |
| MBBindingList< [RecruitVolunteerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_v_m.html) > | [VolunteerList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#acdc847c8af5605cdcbe1a11c5511406c) `[get, set]` |
| MBBindingList< [RecruitVolunteerTroopVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_troop_v_m.html) > | [TroopsInCart](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#ab1ab8e1f6adc5e713e0112e529252c24) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [CancelInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a0afb01d55cc7acfc7a1f0db54aa172d5) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [DoneInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#ab026e74fb97feed8121b2929a90c0108) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [ResetInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#ad853e7e052b5bcd312b3cb4577618295) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [RecruitAllInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a3c56df7d52b56338794c7dc41c0ca53e) `[get, set]` |

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

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#aba0d3d3cb489878d4486cbc8fa36697e)RecruitmentVM()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.RecruitmentVM | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#aa6a46281e51031e5c404f839cf869455)RefreshValues()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a3a8936a089ba22cb8c9148d2db0b4f14)RefreshScreen()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.RefreshScreen | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a5a655b27ebf68e373703143da8315f78)ExecuteDone()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.ExecuteDone | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a104010b04fc41b25ec311962013abd4f)ExecuteForceQuit()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.ExecuteForceQuit | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#ac93cdd1845c221d0e413a2a3a993d7dd)ExecuteReset()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.ExecuteReset | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a06e7b814883279d982fe4bd956209252)ExecuteRecruitAll()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.ExecuteRecruitAll | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a0a1aa2abee6199244c623985e4784eb4)Deactivate()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.Deactivate | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a0934555568c37c9ec18e065e6e116f65)OnFinalize()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#ac739facfd8ae0e3f439a32bc6b870e56)SetGetKeyTextFromKeyIDFunc()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.SetGetKeyTextFromKeyIDFunc | ( | Func< string, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > | *getKeyTextFromKeyId* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#ada9ccebfce53f6d0fd6833e9fbff9e36)SetCancelInputKey()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.SetCancelInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a3f2d244fa2770bf8118a6caa8c189e49)SetDoneInputKey()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.SetDoneInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a56b9b40227f64ddfd842f1481315f1b3)SetRecruitAllInputKey()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.SetRecruitAllInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a7e34186e14315aea61cfb08de554fd38)SetResetInputKey()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.SetResetInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a17c8eae1c36e9a464142dc41309e8a25)IsQuitting
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.IsQuitting | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a6b139da73f436dda65514820fbd9bd4e)ResetHint
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.ResetHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a3518a90c24683a7d786b4efb0fe445c6)FocusedVolunteerTroop
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [RecruitVolunteerTroopVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_troop_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.FocusedVolunteerTroop | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a698a84a57fbb47d7f0b37e18afbe62f9)FocusedVolunteerOwner
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [RecruitVolunteerOwnerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_owner_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.FocusedVolunteerOwner | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a34575f2772cffb44276c073c6103495b)PartyWageHint
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.PartyWageHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a8ee09b88ec3cdd7baf4a097e758004af)PartyCapacityHint
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.PartyCapacityHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a7ac8fe8f4e2ba2031771b2c4e8f79c89)PartySpeedHint
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.PartySpeedHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a6a649fdf772fd8d738089ed860f5dca3)RemainingFoodHint
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.RemainingFoodHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#ac7a946e7fe275c48a1a212b8cc2b4bc9)TotalWealthHint
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.TotalWealthHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a5da72cf3aab9edb10bbb315c546e2bdc)TotalCostHint
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.TotalCostHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a23ad5cc120b67bfb855bc6ff6c8c3ca5)DoneHint
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.DoneHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#ae4b1f5eba5ece863476edf452ca093c1)RecruitAllHint
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.RecruitAllHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#aba82e66d980289bb2aaa9a363e7d8361)PartyWage
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.PartyWage | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a27026078ed652b1d3376c26e4092cc22)PartyCapacityText
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.PartyCapacityText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a28513eb0ac29bf5db81388143831e7c4)PartyWageText
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.PartyWageText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#ac561dd9bb9a4101e8fb1ce8583dd9d0f)RecruitAllText
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.RecruitAllText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#ad44ebb0f81522fe26bba57ed680033f6)PartySpeedText
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.PartySpeedText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a944e567d4a45e0b258c88f8abbbf5fcb)ResetAllText
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.ResetAllText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#af92d6df66919e2a256a2a79a60df187f)CancelText
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.CancelText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#afa7b1c25fd04abd654110b6b3bc559f4)RemainingFoodText
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.RemainingFoodText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a959bef3fa4cb7af91c6471b664c9c1b6)TotalCostText
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.TotalCostText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a58ade47b19df36657bababbb5c7938e3)Enabled
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.Enabled | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a2f63bfbfd69235e3098ae42f7f97c243)IsDoneEnabled
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.IsDoneEnabled | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a9e52023fc51fd108fbf9b9583bfcf17a)IsPartyCapacityWarningEnabled
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.IsPartyCapacityWarningEnabled | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a6287d7e96ddea9d007a60b1feed6c6d8)TitleText
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.TitleText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a0f7a6cd65f4be717d049381ab53c4c78)DoneText
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.DoneText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a44a83d05e2f534c59199bad99635bf8c)CanRecruitAll
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.CanRecruitAll | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a44a1499b8f26f8b5ea0b7c843be56634)TotalWealth
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.TotalWealth | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a5e9be87c8e044353ee52e3b4e6c47601)PartyCapacity
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.PartyCapacity | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#ad23b273587a2e64745f8235a8f1c219b)InitialPartySize
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.InitialPartySize | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#ad02481373f990257fd920d887e698d04)CurrentPartySize
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.CurrentPartySize | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#acdc847c8af5605cdcbe1a11c5511406c)VolunteerList
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[RecruitVolunteerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.VolunteerList | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#ab1ab8e1f6adc5e713e0112e529252c24)TroopsInCart
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[RecruitVolunteerTroopVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_troop_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.TroopsInCart | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a0afb01d55cc7acfc7a1f0db54aa172d5)CancelInputKey
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.CancelInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#ab026e74fb97feed8121b2929a90c0108)DoneInputKey
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.DoneInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#ad853e7e052b5bcd312b3cb4577618295)ResetInputKey
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.ResetInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruitment_v_m.html#a3c56df7d52b56338794c7dc41c0ca53e)RecruitAllInputKey
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitmentVM.RecruitAllInputKey | | getset |

