--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Classes | |
| class | [ManagementItemComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_manaca79701759c68c9c154e37e7a9aac2f.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ArmyManagementVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a66534e0a13fdb5782714730f84879f21) (Action onClose) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#ada89cac234631a538031767b8a89a4e9) () |
|  | Used for updating localized texts. |
| void | [ExecuteDone](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a6c90d661b5ff4c695f2744b40e845c46) () |
| void | [ExecuteCancel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a9762ecd7847f0fb7bdb75608ae6aca26) () |
| void | [ExecuteReset](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#afbcc57b3424e779a192d951b5c85384f) () |
| void | [ExecuteDisbandArmy](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a5037c9902a49fe9d4451dcd38fdb6342) () |
| void | [ExecuteBoostCohesionManual](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#abea14c550f2af76722d974c6c019b7c3) () |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#ab34de129f17c5f94cd7ef2b5811b072a) () |
| void | [SetResetInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a3cde47888d9fc8b50e9dd0f2364162ef) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [SetCancelInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a82679d0ec152a73a16488b5511180112) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [SetDoneInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#ae66e81b0d03b961089813c940d6c7a9a) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [SetRemoveInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a41a5ca76d5c20ca09587358240e237b4) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
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
| Public Attributes | |
| [ElementNotificationVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_tutorial_1_1_element_notification_v_m.html) | [\_tutorialNotification](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#aa132f2ebf57884f6d92e3e0d25e928ca) |

|  |  |
| --- | --- |
| Properties | |
| [ElementNotificationVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_tutorial_1_1_element_notification_v_m.html) | [TutorialNotification](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a9645fe54064759b8c55ec64f15c631e8) `[get, set]` |
| [ArmyManagementSortControllerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_sort_controller_v_m.html) | [SortControllerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a316c135617a0f090576bcc1697330afe) `[get, set]` |
| string | [BoostTitleText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a02e5387527c633b23ab0c1a96a796343) `[get, set]` |
| string | [DisbandArmyText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#ac6d0682131326906078f2ba5ac60683e) `[get, set]` |
| string | [CohesionBoostAmountText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#af13ac0869b4b0abb205774efde025491) `[get, set]` |
| string | [DistanceText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#ad540e162a76b166b8d3441e3c038e96f) `[get, set]` |
| string | [CostText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#abc6fcd86c63f51e6f401fb3924faa085) `[get, set]` |
| string | [OwnerText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a4096386b661d06d9bc6a6177975fa03c) `[get, set]` |
| string | [StrengthText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a5ea8efe620e5fdb69967a5683ea3eb08) `[get, set]` |
| string | [ShipCountText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a2562912ea4df393b0b14e46a874ef6a2) `[get, set]` |
| string | [LordsText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a418cb3195c49bc8fb2146069b4bee0f9) `[get, set]` |
| string | [TotalInfluence](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a0d967c20a0180570077af323ea058f5b) `[get, set]` |
| int | [TotalStrength](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a6d1af5dccf5b04ef20d8bf88fb23c36b) `[get, set]` |
| int | [TotalCost](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#af352f3306f18ca4a516c50d971d88f93) `[get, set]` |
| string | [TotalLords](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#abb7c37439d82d3f0d0fdce871f2148f1) `[get, set]` |
| bool | [CanCreateArmy](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#ad82144d96196e24de3cb85673ca909a7) `[get, set]` |
| bool | [CanBoostCohesion](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a9114ce1e1cc83717c2efb18af97b11f3) `[get, set]` |
| bool | [CanDisbandArmy](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a29b4a1d039d66284360f434f8a78315a) `[get, set]` |
| bool | [CanAffordInfluenceCost](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a08a2ed4afddcb4c7acbf27bdb91ed9e6) `[get, set]` |
| string | [TitleText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a2f87323321e948b533aa4c82365b8b83) `[get, set]` |
| string | [ClanText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#ae7704ca79dc52ed0e9bc7b0dec6a5179) `[get, set]` |
| string | [NameText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#aadcd658736758a07b10a7fb230e9ddd9) `[get, set]` |
| string | [CancelText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#af40eec5b5ea64b4336bc40daadde5ff3) `[get, set]` |
| string | [DoneText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a7e1a275f520da8a3a4d1a8f5f8ab6ee7) `[get, set]` |
| [ArmyManagementItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html) | [FocusedItem](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#aa3871f9509875b846d819f10e78b0391) `[get, set]` |
| MBBindingList< [ArmyManagementItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html) > | [PartyList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a20c1ba14b7dde98991ef1f00a95d421a) `[get, set]` |
| MBBindingList< [ArmyManagementItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html) > | [PartiesInCart](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a8ddc9e04193d636b8936bab0e27b65fe) `[get, set]` |
| string | [TotalStrengthText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#afc611709ab4571486e0fa7e388f4dc47) `[get, set]` |
| string | [TotalCostText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a0a30e791b16aa020d7ba0bf1a6adcf5d) `[get, set]` |
| string | [TotalCostNumbersText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a78350d9f88dbb89de71f730985e38c84) `[get, set]` |
| string | [CohesionText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#ae7bd23f46e174746a7211a6957a726e4) `[get, set]` |
| int | [Cohesion](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a4497d66293e8e8189dcfbe1dc49a87b6) `[get, set]` |
| int | [CohesionBoostCost](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#afa181b1b519dcfb87ea4d7ab48815849) `[get, set]` |
| bool | [PlayerHasArmy](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a23d3058b17c5d17de8352cb5ee644d85) `[get, set]` |
| string | [MoraleText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a8f351297c1cca05b6775407e2a4bbbf3) `[get, set]` |
| string | [FoodText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a4ee951191877e87104eee0411dfc0cb6) `[get, set]` |
| int | [NewCohesion](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a0cd8d3ce151358e3d72f916e3fcc7078) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [CohesionHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a0464487872f7d2e65104277f078b2d1e) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [MoraleHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#aeb8144320e8d305450f36e896506545f) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [BoostCohesionHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a9d469a5a0485392206cec1266b9c5de9) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [DisbandArmyHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#aece5fea67b34e1d1d299e48bc3af28d7) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [DoneHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a2077f18fb31f4a960ac38bdafb51c949) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [FoodHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a083eade6bef80adf100c4048c90b7b62) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [ResetInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a31225b263ebc331c23a50958ac66c413) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [CancelInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#aa3f4d0d0fa252de4c001e044217f82e9) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [DoneInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a87187cb0f859a8d3230e8ea000038791) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [RemoveInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#afa9dce398ecc1417d3303b335b17b902) `[get, set]` |

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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a66534e0a13fdb5782714730f84879f21)ArmyManagementVM()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.ArmyManagementVM | ( | Action | *onClose* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#ada89cac234631a538031767b8a89a4e9)RefreshValues()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a6c90d661b5ff4c695f2744b40e845c46)ExecuteDone()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.ExecuteDone | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a9762ecd7847f0fb7bdb75608ae6aca26)ExecuteCancel()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.ExecuteCancel | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#afbcc57b3424e779a192d951b5c85384f)ExecuteReset()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.ExecuteReset | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a5037c9902a49fe9d4451dcd38fdb6342)ExecuteDisbandArmy()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.ExecuteDisbandArmy | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#abea14c550f2af76722d974c6c019b7c3)ExecuteBoostCohesionManual()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.ExecuteBoostCohesionManual | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#ab34de129f17c5f94cd7ef2b5811b072a)OnFinalize()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a3cde47888d9fc8b50e9dd0f2364162ef)SetResetInputKey()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.SetResetInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a82679d0ec152a73a16488b5511180112)SetCancelInputKey()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.SetCancelInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#ae66e81b0d03b961089813c940d6c7a9a)SetDoneInputKey()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.SetDoneInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a41a5ca76d5c20ca09587358240e237b4)SetRemoveInputKey()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.SetRemoveInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#aa132f2ebf57884f6d92e3e0d25e928ca)\_tutorialNotification
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [ElementNotificationVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_tutorial_1_1_element_notification_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.\_tutorialNotification |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a9645fe54064759b8c55ec64f15c631e8)TutorialNotification
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ElementNotificationVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_tutorial_1_1_element_notification_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.TutorialNotification | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a316c135617a0f090576bcc1697330afe)SortControllerVM
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ArmyManagementSortControllerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_sort_controller_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.SortControllerVM | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a02e5387527c633b23ab0c1a96a796343)BoostTitleText
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.BoostTitleText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#ac6d0682131326906078f2ba5ac60683e)DisbandArmyText
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.DisbandArmyText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#af13ac0869b4b0abb205774efde025491)CohesionBoostAmountText
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.CohesionBoostAmountText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#ad540e162a76b166b8d3441e3c038e96f)DistanceText
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.DistanceText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#abc6fcd86c63f51e6f401fb3924faa085)CostText
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.CostText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a4096386b661d06d9bc6a6177975fa03c)OwnerText
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.OwnerText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a5ea8efe620e5fdb69967a5683ea3eb08)StrengthText
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.StrengthText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a2562912ea4df393b0b14e46a874ef6a2)ShipCountText
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.ShipCountText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a418cb3195c49bc8fb2146069b4bee0f9)LordsText
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.LordsText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a0d967c20a0180570077af323ea058f5b)TotalInfluence
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.TotalInfluence | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a6d1af5dccf5b04ef20d8bf88fb23c36b)TotalStrength
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.TotalStrength | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#af352f3306f18ca4a516c50d971d88f93)TotalCost
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.TotalCost | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#abb7c37439d82d3f0d0fdce871f2148f1)TotalLords
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.TotalLords | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#ad82144d96196e24de3cb85673ca909a7)CanCreateArmy
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.CanCreateArmy | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a9114ce1e1cc83717c2efb18af97b11f3)CanBoostCohesion
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.CanBoostCohesion | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a29b4a1d039d66284360f434f8a78315a)CanDisbandArmy
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.CanDisbandArmy | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a08a2ed4afddcb4c7acbf27bdb91ed9e6)CanAffordInfluenceCost
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.CanAffordInfluenceCost | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a2f87323321e948b533aa4c82365b8b83)TitleText
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.TitleText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#ae7704ca79dc52ed0e9bc7b0dec6a5179)ClanText
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.ClanText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#aadcd658736758a07b10a7fb230e9ddd9)NameText
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.NameText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#af40eec5b5ea64b4336bc40daadde5ff3)CancelText
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.CancelText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a7e1a275f520da8a3a4d1a8f5f8ab6ee7)DoneText
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.DoneText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#aa3871f9509875b846d819f10e78b0391)FocusedItem
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ArmyManagementItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.FocusedItem | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a20c1ba14b7dde98991ef1f00a95d421a)PartyList
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[ArmyManagementItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.PartyList | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a8ddc9e04193d636b8936bab0e27b65fe)PartiesInCart
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[ArmyManagementItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.PartiesInCart | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#afc611709ab4571486e0fa7e388f4dc47)TotalStrengthText
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.TotalStrengthText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a0a30e791b16aa020d7ba0bf1a6adcf5d)TotalCostText
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.TotalCostText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a78350d9f88dbb89de71f730985e38c84)TotalCostNumbersText
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.TotalCostNumbersText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#ae7bd23f46e174746a7211a6957a726e4)CohesionText
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.CohesionText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a4497d66293e8e8189dcfbe1dc49a87b6)Cohesion
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.Cohesion | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#afa181b1b519dcfb87ea4d7ab48815849)CohesionBoostCost
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.CohesionBoostCost | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a23d3058b17c5d17de8352cb5ee644d85)PlayerHasArmy
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.PlayerHasArmy | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a8f351297c1cca05b6775407e2a4bbbf3)MoraleText
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.MoraleText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a4ee951191877e87104eee0411dfc0cb6)FoodText
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.FoodText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a0cd8d3ce151358e3d72f916e3fcc7078)NewCohesion
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.NewCohesion | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a0464487872f7d2e65104277f078b2d1e)CohesionHint
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.CohesionHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#aeb8144320e8d305450f36e896506545f)MoraleHint
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.MoraleHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a9d469a5a0485392206cec1266b9c5de9)BoostCohesionHint
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.BoostCohesionHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#aece5fea67b34e1d1d299e48bc3af28d7)DisbandArmyHint
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.DisbandArmyHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a2077f18fb31f4a960ac38bdafb51c949)DoneHint
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.DoneHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a083eade6bef80adf100c4048c90b7b62)FoodHint
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.FoodHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a31225b263ebc331c23a50958ac66c413)ResetInputKey
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.ResetInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#aa3f4d0d0fa252de4c001e044217f82e9)CancelInputKey
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.CancelInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#a87187cb0f859a8d3230e8ea000038791)DoneInputKey
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.DoneInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_v_m.html#afa9dce398ecc1417d3303b335b17b902)RemoveInputKey
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementVM.RemoveInputKey | | getset |

