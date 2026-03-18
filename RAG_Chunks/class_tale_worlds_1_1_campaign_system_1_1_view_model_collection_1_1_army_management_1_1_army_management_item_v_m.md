--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementItemVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ArmyManagementItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a213b7b9111eb41e92a12a792a6d8dac7) (Action< ArmyManagementItemVM > onAddToCart, Action< ArmyManagementItemVM > onRemove, Action< ArmyManagementItemVM > onFocus, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#aa5e6cf1bad01c9d2269e5c0ff85371da) () |
|  | Used for updating localized texts. |
| void | [ExecuteAction](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a90f3a5520698506e8bea7140792fc479) () |
| void | [ExecuteSetFocused](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#add0209785ac2f95384a95a72bec6f192) () |
| void | [ExecuteSetUnfocused](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a6478ca82bf20a172be8a9473e2db150b) () |
| void | [UpdateEligibility](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a1e19f371a5ccf79e49596ebffc4c3c46) () |
| void | [ExecuteBeginHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#aa9be84fda3604bf1ffb6f7e82577a64f) () |
| void | [ExecuteBeginClanHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#ae121b8831081b719f03aa238fa36b113) () |
| void | [ExecuteEndHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a19e075426790716f1b313500799bc691) () |
| void | [ExecuteOpenEncyclopedia](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#af96bcc41d215af5625de8e49da6ba2ce) () |
| void | [ExecuteOpenClanEncyclopedia](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a0b6062d3ad499c5b93fe8e67de429a9e) () |
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
| Public Attributes | |
| readonly [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | [Party](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a7029e32e008d1e20440fdbbc04dd36e3) |
| bool | [CanJoinBackWithoutCost](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#aa796b6449d984bd4c0161d2f7bbc495d) = false |

|  |  |
| --- | --- |
| Properties | |
| float | [DistInTime](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a6d064b12f66a8eb6585814d476f8fcfc) `[get]` |
| float | [\_distance](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a9d322e4d652ad1bd86fa9e4264f12b13) `[get]` |
| Clan | [Clan](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a3035786fc2aaecb1d0dd0987e5013308) `[get]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [RemoveInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#af4603b8473217271bea4a184ecadf604) `[get, set]` |
| bool | [IsEligible](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a0ceaa41020fbbb8b2c51b554c063f4d8) `[get, set]` |
| bool | [IsInCart](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#aa348ace7d2283a2eb7b16d8eb0bfe90f) `[get, set]` |
| bool | [IsMainHero](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a50c6a33186804d3ae5e2bbabd9cd4b88) `[get, set]` |
| int | [Strength](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a044ad0901422b3f5363d56300154dff2) `[get, set]` |
| int | [ShipCount](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a234f3ceb20fa386dc390806859dbbb4d) `[get, set]` |
| bool | [HasShip](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a5cae5c744ab20f79f40d48238db1d466) `[get, set]` |
| string | [DistanceText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a5012c3d73f5d8f8cf46ed10e77e70d78) `[get, set]` |
| string | [InArmyText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a52580eb32daed264858fb09aacf34a80) `[get, set]` |
| int | [Cost](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#ab5d04ffde2b1278362548436dacb2834) `[get, set]` |
| bool | [IsCostRelevant](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a12ed94292130c56946a8fbb22bd829f6) `[get, set]` |
| int | [Relation](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a439813bef5320a597b758915b4407dbf) `[get, set]` |
| [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) | [ClanBanner](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a65a3d8bfab71e8f15d800c525a980e17) `[get, set]` |
| [CharacterImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_character_image_identifier_v_m.html) | [LordFace](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a7e25b27bcd2531cc286cad25aba7fafd) `[get, set]` |
| string | [NameText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a57e272972bcd5adb8cc0cf366e95b6cd) `[get, set]` |
| bool | [IsAlreadyWithPlayer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#aae8755640058ef4108f0119eb958a9ac) `[get, set]` |
| bool | [IsTransferDisabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a998ee1533edec25b8e24b7af2afbafb9) `[get, set]` |
| string | [LeaderNameText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a1f5cb0f2ee91d2458640e1d8b72bf31d) `[get, set]` |
| bool | [IsFocused](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#ac953f40b080886df248da0ae6f381bba) `[get, set]` |

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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a213b7b9111eb41e92a12a792a6d8dac7)ArmyManagementItemVM()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementItemVM.ArmyManagementItemVM | ( | Action< ArmyManagementItemVM > | *onAddToCart*, |
|  |  | Action< ArmyManagementItemVM > | *onRemove*, |
|  |  | Action< ArmyManagementItemVM > | *onFocus*, |
|  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#aa5e6cf1bad01c9d2269e5c0ff85371da)RefreshValues()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementItemVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a90f3a5520698506e8bea7140792fc479)ExecuteAction()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementItemVM.ExecuteAction | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#add0209785ac2f95384a95a72bec6f192)ExecuteSetFocused()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementItemVM.ExecuteSetFocused | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a6478ca82bf20a172be8a9473e2db150b)ExecuteSetUnfocused()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementItemVM.ExecuteSetUnfocused | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a1e19f371a5ccf79e49596ebffc4c3c46)UpdateEligibility()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementItemVM.UpdateEligibility | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#aa9be84fda3604bf1ffb6f7e82577a64f)ExecuteBeginHint()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementItemVM.ExecuteBeginHint | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#ae121b8831081b719f03aa238fa36b113)ExecuteBeginClanHint()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementItemVM.ExecuteBeginClanHint | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a19e075426790716f1b313500799bc691)ExecuteEndHint()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementItemVM.ExecuteEndHint | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#af96bcc41d215af5625de8e49da6ba2ce)ExecuteOpenEncyclopedia()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementItemVM.ExecuteOpenEncyclopedia | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a0b6062d3ad499c5b93fe8e67de429a9e)ExecuteOpenClanEncyclopedia()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementItemVM.ExecuteOpenClanEncyclopedia | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a7029e32e008d1e20440fdbbc04dd36e3)Party
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementItemVM.Party |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#aa796b6449d984bd4c0161d2f7bbc495d)CanJoinBackWithoutCost
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementItemVM.CanJoinBackWithoutCost = false |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a6d064b12f66a8eb6585814d476f8fcfc)DistInTime
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementItemVM.DistInTime | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a9d322e4d652ad1bd86fa9e4264f12b13)\_distance
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementItemVM.\_distance | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a3035786fc2aaecb1d0dd0987e5013308)Clan
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Clan TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementItemVM.Clan | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#af4603b8473217271bea4a184ecadf604)RemoveInputKey
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementItemVM.RemoveInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a0ceaa41020fbbb8b2c51b554c063f4d8)IsEligible
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementItemVM.IsEligible | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#aa348ace7d2283a2eb7b16d8eb0bfe90f)IsInCart
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementItemVM.IsInCart | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a50c6a33186804d3ae5e2bbabd9cd4b88)IsMainHero
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementItemVM.IsMainHero | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a044ad0901422b3f5363d56300154dff2)Strength
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementItemVM.Strength | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a234f3ceb20fa386dc390806859dbbb4d)ShipCount
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementItemVM.ShipCount | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a5cae5c744ab20f79f40d48238db1d466)HasShip
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementItemVM.HasShip | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a5012c3d73f5d8f8cf46ed10e77e70d78)DistanceText
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementItemVM.DistanceText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a52580eb32daed264858fb09aacf34a80)InArmyText
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementItemVM.InArmyText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#ab5d04ffde2b1278362548436dacb2834)Cost
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementItemVM.Cost | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a12ed94292130c56946a8fbb22bd829f6)IsCostRelevant
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementItemVM.IsCostRelevant | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a439813bef5320a597b758915b4407dbf)Relation
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementItemVM.Relation | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a65a3d8bfab71e8f15d800c525a980e17)ClanBanner
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementItemVM.ClanBanner | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a7e25b27bcd2531cc286cad25aba7fafd)LordFace
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_character_image_identifier_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementItemVM.LordFace | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a57e272972bcd5adb8cc0cf366e95b6cd)NameText
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementItemVM.NameText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#aae8755640058ef4108f0119eb958a9ac)IsAlreadyWithPlayer
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementItemVM.IsAlreadyWithPlayer | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a998ee1533edec25b8e24b7af2afbafb9)IsTransferDisabled
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementItemVM.IsTransferDisabled | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#a1f5cb0f2ee91d2458640e1d8b72bf31d)LeaderNameText
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementItemVM.LeaderNameText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html#ac953f40b080886df248da0ae6f381bba)IsFocused
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementItemVM.IsFocused | | getset |

